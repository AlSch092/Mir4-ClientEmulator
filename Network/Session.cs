//By AlSch092 @ Github
﻿
using Mir4ClientEmulator.Context;
using Mir4ClientEmulator.Network.Packets;
using Mir4ClientEmulator.Network.Packets.Encryption;
using System;
using System.Collections.Generic;
using System.Net.Sockets;
using System.Threading;

namespace Mir4ClientEmulator.Network
{
    public sealed class Session : IDisposable
    {
        public const int HeaderLen = 17;
        public const short ReceiveSize = 8192;

        public int packetCount = 0; //+1 for each packet in each zone

        private readonly Socket m_socket;

        private bool m_connected;
        private bool m_userClose;

        private byte[] m_recvBuffer;
        private byte[] m_packetBuffer;
        
        private int m_cursor;
        public event EventHandler<Reader> OnPacket;

        private object m_sendLock;

        public event EventHandler<bool> OnDisconnected;

        public FrontContext m_FrontContext;
        public GameContext m_GameContext;

        public Thread RecvThread;

        public bool Connected
        {
            get
            {
                return m_connected;
            }
        }

        public Session(Socket socket)
        {
            m_socket = socket;

            m_connected = true;
            m_userClose = false;

            m_packetBuffer = new byte[ReceiveSize];
            m_recvBuffer = new byte[ReceiveSize];

            m_sendLock = new object();
        }

        public void Receive() //cleaner version, works the same.
        {
            if (m_connected)
            {
                var error = SocketError.Success;

                if(m_socket == null)
                {
                    Console.WriteLine("Socket was null!");
                    return;
                }

                try
                {
                    m_socket.BeginReceive(m_recvBuffer, 0, ReceiveSize, SocketFlags.None, out error, PacketCallback, null);      
                }
                catch (Exception e)
                {
                    return;
                }

                if (error != SocketError.Success)
                {
                    Dispose();
                }
            }
        }

        private void PacketCallback(IAsyncResult iar)
        {
            if (m_connected)
            {
                var error = SocketError.Success;

                int length = m_socket.EndReceive(iar, out error);

                if (length == 0 || error != SocketError.Success)
                {
                    Dispose();
                }
                else
                {
                    Append(length);
                    ManipulateBuffer();
                    Receive();
                }
            }
        }

        private void Append(int length)
        {
            if (m_packetBuffer.Length - m_cursor < length)
            {
                int newSize = m_packetBuffer.Length * 2;

                while (newSize < m_cursor + length)
                    newSize *= 2;

                Array.Resize<byte>(ref m_packetBuffer, newSize);
            }

            Buffer.BlockCopy(m_recvBuffer, 0, m_packetBuffer, m_cursor, length);

            m_cursor += length;
        }
        private void ManipulateBuffer()
        {
            while (m_cursor > HeaderLen && m_connected)
            {
                int packetSize = m_packetBuffer[0] | m_packetBuffer[1] << 8; // | m_packetBuffer[2] << 16 | m_packetBuffer[3] << 24;

                if (m_cursor < packetSize)
                {
                    break;
                }

                byte[] buffer = new byte[packetSize + 15]; //why +15?
                Buffer.BlockCopy(m_packetBuffer, 0, buffer, 0, packetSize);

                m_cursor -= packetSize;

                if (m_cursor > 0)
                {
                    Buffer.BlockCopy(m_packetBuffer, packetSize, m_packetBuffer, 0, m_cursor);
                }

                if (m_GameContext != null)
                {
                    if(m_GameContext.Client.RecvPacketQueue != null)
                    {
                        byte[] sub_buff = new byte[packetSize - 5];
                        Buffer.BlockCopy(m_packetBuffer, 5, sub_buff, 0, packetSize - 5);
                        m_GameContext.Client.RecvPacketQueue.Enqueue(new Reader(sub_buff, packetSize - 5));
                    }
                }

                if (OnPacket != null)
                    OnPacket(this, new Reader(buffer));

                buffer = null;
            }
        }

        public bool SendNonEncryptedPacket(Writer packet)
        {
            if (m_connected)
            {
                byte[] data = packet.ToArray_Raw();
                byte[] dataWithHeader = new byte[data.Length + 5];

                int dataLen = dataWithHeader.Length;

                dataWithHeader[0] = (byte)dataLen; //copy first 4 bytes
                dataWithHeader[1] = (byte)(dataLen >> 8);
                dataWithHeader[2] = (byte)(dataLen >> 0x10);
                dataWithHeader[3] = (byte)(dataLen >> 0x18);

                Buffer.BlockCopy(data, 0, dataWithHeader, 5, data.Length);

                if (m_FrontContext != null)
                {
                    if(m_FrontContext.Client.SendPacketQueue != null)
                        m_FrontContext.Client.SendPacketQueue.Enqueue(new Reader(data, data.Length));
                }

                lock (m_sendLock)
                {
                    int offset = 0;

                    while (offset < data.Length)
                    {
                        SocketError errorCode = SocketError.Success;

                        int sent = m_socket.Send(dataWithHeader, offset, dataWithHeader.Length - offset, SocketFlags.None, out errorCode);

                        if (sent == 0 || errorCode != SocketError.Success)
                        {
                            Dispose();
                            return false;
                        }

                        offset += sent;
                    }
                }

                packet.Dispose();
            }
            else
            {
                return false;
            }

            return true;
        }

        public bool SendProtobuf(Opcodes opcode, byte[] data)
        {
            if (data == null)
                return false;

            if (m_connected)
            {   
                byte[] full_packet = new byte[data.Length + 12]; //12 bytes for opcode + timestamp + 2 padding
                byte[] encrypted_packet = new byte[data.Length + 12 + 30];

                byte[] opcode_arr = BitConverter.GetBytes((ushort)opcode);
          
                Buffer.BlockCopy(opcode_arr, 0, full_packet, 0, 2);
                Buffer.BlockCopy(data, 0, full_packet, 12, data.Length);

                if (m_GameContext != null)
                {
                    if (m_GameContext.Client.SendPacketQueue != null)
                        m_GameContext.Client.SendPacketQueue.Enqueue(new Reader(full_packet, full_packet.Length));
                }

                int EncryptedLength = Encryption.Encode(full_packet, encrypted_packet, full_packet.Length);

                lock (m_sendLock)
                {
                    int offset = 0;

                    while (offset < EncryptedLength)
                    {
                        SocketError errorCode = SocketError.Success;

                        if (m_socket != null)
                        {
                            if (m_socket.Connected)
                            {
                                int sent = m_socket.Send(encrypted_packet, offset, EncryptedLength, SocketFlags.None, out errorCode);

                                if (sent == 0 || errorCode != SocketError.Success)
                                {
                                    Dispose();
                                    return false;
                                }

                                offset += sent;
                            }
                        }
                    }
                }
            }
            else
            {
                Console.WriteLine("[ERROR] Not connected!");
                return false;
            }

            return true;
        }

        public bool SendPacketList(List<byte[]> packets, int delay)
        {
            if(packets != null)
            {
                foreach(byte[] packet in packets)
                {
                    if (!m_socket.Connected)
                        return false;

                    Writer p_writer = new Writer();
                    p_writer.WriteBytes(packet);

                    if (!SendPacket(p_writer, 0))
                    {
                        Console.WriteLine("[ERROR] Failed to send packet at SendPacketList..");
                        return false;
                    }

                    Thread.Sleep(delay);
                }

                return true;
            }

            return false;
        }

        public void SpamPacket(Writer packet, int delay_ms) //this thread gets aborted by GUI thread
        {
            if (packet == null)
                return;

            bool spamming = true;

            while(spamming)
            {
                try
                {
                    bool send_success = SendPacket(packet, 0);
                    Thread.Sleep(delay_ms);
                }
                catch(Exception e)
                {
                    Console.WriteLine("Failed to send packet @ SpamPacket");
                    return;
                }
            }
        }

        public void SendThreadedPacket(Writer packet, int delay)
        {
            Thread myNewThread = new Thread(() => SendPacket(packet, delay));
            myNewThread.Start();
            myNewThread.Join();
        }

        public bool SendPacket(Writer packet) //Game Server, encrypts
        {
            if (packet == null)
                return false;

            if (m_connected)
            {
                byte[] data = packet.ToArray_Raw();
                byte[] outData = new byte[data.Length + 30];

                if (m_GameContext != null)
                {
                    if (m_GameContext.Client.SendPacketQueue != null)
                        m_GameContext.Client.SendPacketQueue.Enqueue(new Reader(data, data.Length));
                }

                int EncryptedLength = Encryption.Encode(data, outData, data.Length);

                lock (m_sendLock)
                {
                    int offset = 0;

                    while (offset < EncryptedLength)
                    {
                        SocketError errorCode = SocketError.Success;

                        if (m_socket != null)
                        {
                            if (m_socket.Connected)
                            {
                                int sent = m_socket.Send(outData, offset, EncryptedLength, SocketFlags.None, out errorCode);
                                //Console.WriteLine("Sending {0} bytes.., sent {1} bytes", EncryptedLength, sent);

                                if (sent == 0 || errorCode != SocketError.Success)
                                {
                                    Dispose();
                                    return false;
                                }

                                offset += sent;
                            }
                        }
                    }
                }

                packet.Dispose();
            }
            else
            {
                return false;
            }

            return true;
        }

        public bool SendPacket(Writer packet, int delay) //Game Server, encrypts
        {
            if (packet == null)
                return false;

            if (m_connected)
            {             
                byte[] data = packet.ToArray_Raw();              
                byte[] outData = new byte[data.Length + 30];

                if (m_GameContext != null)
                {
                    if(m_GameContext.Client.SendPacketQueue != null)
                        m_GameContext.Client.SendPacketQueue.Enqueue(new Reader(data, data.Length));
                }

                int EncryptedLength = Encryption.Encode(data, outData, data.Length);

                if(delay > 0)
                    Thread.Sleep(delay);

                lock (m_sendLock)
                {
                    int offset = 0;

                    while (offset < EncryptedLength)
                    {
                        SocketError errorCode = SocketError.Success;

                        if(m_socket != null)
                        {
                            if (m_socket.Connected)
                            {
                                int sent = m_socket.Send(outData, offset, EncryptedLength, SocketFlags.None, out errorCode);
                                //Console.WriteLine("Sending {0} bytes.., sent {1} bytes", EncryptedLength, sent);

                                if (sent == 0 || errorCode != SocketError.Success)
                                {
                                    Dispose();
                                    return false;
                                }

                                offset += sent;
                            }
                        }                                           
                    }
                }

                packet.Dispose();
            }
            else
            {
                return false;
            }

            return true;
        }

        public void Disconnect()
        {
            m_userClose = true;
            Dispose();
        }
        public void Dispose()
        {
            if (m_connected)
            {
                m_connected = false;

                try
                {
                    m_socket.Shutdown(SocketShutdown.Both);
                    m_socket.Close();
                }
                finally
                {
                    if (OnDisconnected != null)
                        OnDisconnected(this, m_userClose);
                }
            }
        }
    }
}
