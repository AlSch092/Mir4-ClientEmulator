//By AlSch092 @ Github
﻿using Mir4ClientEmulator.Network.Packets.Messages;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Mir4ClientEmulator.Game
{
    public class Account
    {
        public string Email;
        public string Password;

        public string WemixAddress;

        public string LoginToken;

        public string CharacterName;

        public int Darksteel;
        public int Gold;
        public int Copper;

        public int Energy;

        public string PlayerKey;
        public string UniqueLoginKey;

        public ulong character_identifier; //first 4 bytes in many packets, doe sthis become a long when we parse stuff properly?
        public int warp_user_connected_session_index;
        public ulong account_uid; //first 8 bytes of click char packet

        public ulong Zone;
        public uint StageID;
        
        public uint WorldID;
        public string strWorld;

        public e_class eClass;
        public int Level;
        public long Experience;

        public Entity Character;

        public bool NeedsHumanVerification;

        public List<WORLD_INFO> WorldList;

        public int GetWorldId(string worldName)  //502 = NA14, 811 = ASIA11, 161 = SA011
        {
            int worldId = 0;

            foreach(WORLD_INFO world in WorldList)
            {
                if(worldName == world.name)
                {
                    worldId = world.index;
                    break;
                }
            }

            return worldId;
        }
    }
}
