//By AlSch092 @ Github
﻿using Mir4ClientEmulator.Network.Packets.Messages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Mir4ClientEmulator.Game
{
    public enum e_class
    {
        Warrior = 1,
        Sorcerer = 2,
        Taoist = 3,
        Arbalist = 4,
        Lancer = 5,
        Darkest = 6
    }

    public enum state
    {
        Normal = 11,
        Casting = 12
    }

    public class Entity
    {
        public ulong id { get; set; }
 
        public int type { get; set; }

        public _vector3 Position { get; set; }
        public float movespeed { get; set; }

        public uint state { get; set; }

        public uint max_hp { get; set; }
        public uint hp { get; set; }

        public uint max_mp { get; set; }
        public uint mana { get; set; }

        public int classid { get; set; }

        public ulong zone_uid { get; set; }

        public uint UsageCountsLeft { get; set; }
        public uint UsageCountsMax { get; set; }

        public bool IsHoneyPot { get; set; }

        public const int HoneyPotMask = 100;

        public static bool IsDuplicate(ulong uid, List<Entity> entlist)
        {
            foreach(Entity ent in entlist)
            {
                if (uid == ent.id)
                    return true;
            }

            return false;
        }

        public Entity(ulong objectId, int objectType, _vector3 coords, uint nCountsLeft, uint nCountsMax, uint state) //gather-type
        {
            this.id = objectId;
            this.type = objectType;
            this.UsageCountsLeft = nCountsLeft;
            this.UsageCountsMax = nCountsMax;
            this.state = state;

            Position = new _vector3
            {
                x = coords.x,
                y = coords.y,
                z = coords.z,
            };

            if(Entity.IsHoneypot(this))
            {
                this.IsHoneyPot = true;
            }
        }

        public Entity(ulong objectId, int objectType, int classType, _vector3 position, uint state, uint hp, ulong zone_unique, float movespeed) //monster
        {
            this.id = objectId;
            this.type = objectType;
            this.UsageCountsLeft = 0;
            this.UsageCountsMax = 0;
            this.state = state;
            this.classid = classType;
            this.hp = hp;
            this.zone_uid = zone_unique;
            this.movespeed = movespeed;

            Position = new _vector3
            {
                x = position.x,
                y = position.y,
                z = position.z,
            };

            if (Entity.IsHoneypot(this))
            {
                this.IsHoneyPot = true;
            }
        }

        public static bool IsHoneypot(Entity ent)
        {
            bool foundHoneypot = false;
            
            //check state
            uint state = ent.state;
            uint maskValue = state & HoneyPotMask;

            if (maskValue == HoneyPotMask)
            {
                foundHoneypot = true;
                ent.IsHoneyPot = true;
            }

            
            return foundHoneypot;
        }

    }
}
