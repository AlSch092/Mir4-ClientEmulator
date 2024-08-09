//By AlSch092 @ Github
﻿using Mir4ClientEmulator.Network;
using Mir4ClientEmulator.Network.Packets;
using System.Threading;

namespace Mir4ClientEmulator.Context
{
    public abstract class CBase
    {
        public Client Client { get; private set; }

        private Session m_session;

        public CBase(Client client, Session session)
        {
            Client = client;

            m_session = session;
            m_session.OnPacket += (s, e) => HandlePacket(e);
            m_session.OnDisconnected += (s, e) => HandleDisconnected(e);

            HandleConnected();

            Thread recvThread = new Thread(new ThreadStart(m_session.Receive));
            recvThread.Start();
        }

        public abstract void HandleConnected();
        public abstract void HandlePacket(Reader packet);
        public abstract void HandleDisconnected(bool byChoice);

        public void Send(Writer packet)
        {
            if (m_session != null)
                m_session.SendPacket(packet);
        }

        public void Disconnect()
        {
            m_session.Disconnect();
            Client.UIMessages.Enqueue("[WARNING] Client was disconnected!");
        }
    }
}
