//By AlSch092 @ Github
﻿using Mir4ClientEmulator.Context;
using Mir4ClientEmulator.Game;
using Mir4ClientEmulator.Network.Packets;
using Mir4ClientEmulator.Scripter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Threading;


namespace Mir4ClientEmulator.Network
{
    public sealed class Client
    {
        public Socket m_GameSocket { get; set; }
        public Socket m_FrontSocket { get; set; }

        public Session m_session;

        public string ConnectedIp;
        public int Port;

        public string FrontServerIP { get; set; }
        public string GameServerIP { get; set; }

        public int FrontServerPort { get; set; }

        public int GameServerPort { get; set; }

        public Account GameAccount { get; set; }
        public UltimateLogin WebLogin { get; set; }

        public Queue<Packets.Reader> SendPacketQueue { get; set; }
        public Queue<Packets.Reader> RecvPacketQueue { get; set; }

        public Queue<string> UIMessages { get; set; }

        public bool ReadyInGame { get; set; }

        public bool PastFrontServer { get; set; }

        public Thread HeartbeatWorker;

        public Automation Bot { get; set; }

        public bool AutoReconnect { get; set; }

        public bool IsConsoleOutput { get; set; }

        public Thread stuckStageThread { get; set; }

        public Client()
        {
            GameAccount = new Account();
            Bot = new Automation(this);
            WebLogin = new UltimateLogin();
            UIMessages = new Queue<string>();
            IsConsoleOutput = false;
        }

        public bool Migrate(string ip, int port, bool isFrontServer)
        {
            Console.WriteLine("Trying to migrate to: {0}:{1}", ip, port);

            if(isFrontServer)
            {
                m_FrontSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

                try
                {
                    m_FrontSocket.Connect(ip, port);
                    m_session = new Session(m_FrontSocket);
                    Port = port;

                    ConnectedIp = ip;

                    FrontServerIP = ip;
                    FrontServerPort = port;
                }
                catch (Exception e)
                {
                    Console.WriteLine("Could not connect to server: " + e.Message);
                    return false;
                }

                PastFrontServer = false;
                m_session.m_FrontContext = new FrontContext(this, m_session);
            }
            else
            {
                if(m_FrontSocket != null)
                    if (m_FrontSocket.Connected)
                            m_FrontSocket.Close();

                m_GameSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

                try
                {
                    m_GameSocket.Connect(ip, port);
                    m_session = new Session(m_GameSocket);
                    Port = port;

                    ConnectedIp = ip;

                    GameServerIP = ip;
                    GameServerPort = port;

                    PastFrontServer = true;

                    if (m_session.m_FrontContext != null)
                        m_session.m_FrontContext.Disconnect();

                    m_session.m_GameContext = new GameContext(this, m_session);

                    Console.WriteLine("Migrated to : {0}:{1}", ip, port);
                }
                catch (Exception e)
                {
                    Console.WriteLine("Could not connect/migrate to server: " + e.Message);
                    return false;
                }
            }
            
            return true;
        }

        public Entity GetEntityFromList(ulong id)
        {
            foreach(Entity e in Bot.EntityList.ToList())
            {
                if(e.id == id)
                {
                    return e;
                }
            }

            return null;
        }

        public static void SendHeartbeats(Object obj) //threaded routine
        {
            bool sendingHeartbeats = true;
            const int timeBetweenHB = 30000;

            Client c = (Client)obj;

            Console.WriteLine("Started sending heartbeats to server...");

            while (sendingHeartbeats) //glitch with d/cing at lobby
            {
                if (c.m_GameSocket != null)
                {
                    if(c.ReadyInGame)
                    {
                        c.m_session.SendPacket(Factory.CLIENT_GAME_HEARTBEAT());
                        Thread.Sleep(timeBetweenHB);

                        if (!c.m_GameSocket.Connected)
                            return;
                    }
                }
            }
        }       

    }
}
