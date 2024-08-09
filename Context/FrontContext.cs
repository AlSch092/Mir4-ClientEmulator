//By AlSch092 @ Github
﻿using Mir4ClientEmulator.Network.Packets;
using Mir4ClientEmulator.Network;
using System;
using System.Threading;
using Mir4ClientEmulator.Utilities;

namespace Mir4ClientEmulator.Context
{
    public sealed class FrontContext : CBase
    {
        private const int header_len = 15 + 17;

        public int login_stage = 0;

        public FrontContext(Client client, Session session) : base(client, session)
        {
            if(client.stuckStageThread == null && client.AutoReconnect)
            {
                client.stuckStageThread = new Thread(new ThreadStart(MonitorLoginStage));
                client.stuckStageThread.Start();
            } 
        }
     
        public override void HandleConnected()
        {
            Console.WriteLine("Connected to login/front server!!");
            this.Client.m_session.SendNonEncryptedPacket(Factory.CLIENT_FRONT_SERVICE_AUTH(Client.GameAccount.PlayerKey, Client.GameAccount.LoginToken, Enums.Os.Ios, UltimateLogin.MacAddress, 2)); //11 = steam? storetype
        }

        public override void HandleDisconnected(bool byChoice)
        {
            if (!byChoice)
            {
                Console.WriteLine("Remote server disconnected the client. Please reconnect.");
            }
            else
            {
                Console.WriteLine("Disconnected from FRONT server.");
            }

            Client.m_session.Disconnect();

            Client.ReadyInGame = false;

            if (Client.AutoReconnect) //reconnect
            {
                Thread.Sleep(10000);
                Client.Migrate(Client.FrontServerIP, Client.FrontServerPort, true);
            }
        }

        public void MonitorLoginStage()
        {
            //Console.WriteLine("CREATED MONITOR THREAD");

            while(!Client.ReadyInGame)
            {
                if (!this.Client.m_session.Connected)
                {
                    Console.WriteLine("ENDING MONITOR THREAD");
                    return;
                }

                int stage = login_stage;
                Thread.Sleep(15000);

                if (Client.ReadyInGame)
                    return;

                if(stage == login_stage)
                {
                    Console.WriteLine("[ERROR] Client is stuck at login, re-connecting...");
                    Client.m_session.Disconnect();
                    Console.WriteLine("ENDING MONITOR THREAD");
                    return;
                }
            }
        }

        public override void HandlePacket(Reader packet)
        {
            int length = packet.ReadInt();
            byte recvFlag = packet.ReadByte();
            ushort opcode = packet.ReadUShort();

            string named_opcode = FileHelper.GetNamedOpcode("Data/opcodes.proto", opcode);

            packet.Skip(10); //timestamp + 2byte flags

            byte[] packet_data = packet.ReadBytes(packet.Length - header_len);

            if (named_opcode.Length > 0)
                Console.WriteLine("Received opcode: {0}", named_opcode);
            else
                Console.WriteLine("Received UNKNOWN opcode: 0x" + opcode.ToString("X4"));

            switch ((Opcodes)opcode)
            {
                case Opcodes.FRONT_CLIENT_WORLD_CHARACTER_INFO:
                    FrontServerHandler.FRONT_CLIENT_WORLD_CHARACTER_INFO(this, packet_data);
                    break;

                case Opcodes.FRONT_CLIENT_WORLD_AND_CHARACTER_INFO:
                    FrontServerHandler.FRONT_CLIENT_WORLD_AND_CHARACTER_INFO(this, packet_data);
                    break;

                case Opcodes.FRONT_CLIENT_SELECT_WORLD: //migrate here
                    FrontServerHandler.FRONT_CLIENT_SELECT_WORLD(this, packet_data);
                    break;

                case Opcodes.FRONT_CLIENT_SERVICE_AUTH_V3:
                    FrontServerHandler.FRONT_CLIENT_SERVICE_AUTH_V3(this, packet_data);
                    break;

                default:
                    FrontServerHandler.HandleUnknown(this, packet);
                    break;
            }
        }
    }
}
