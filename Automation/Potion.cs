//By AlSch092 @ Github
﻿using Mir4ClientEmulator.Network.Packets.Messages;
using Mir4ClientEmulator.Network;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Mir4.Scripter
{
    public class Potion
    {
        public List<ulong> HPPotionList { get; set; }
        public List<ulong> MPPotionList { get; set; }

        private long LastHPUseTime { get; set; }
        private long LastMPUseTime { get; set; }

        public Potion()
        {
            HPPotionList = new List<ulong>();
            MPPotionList = new List<ulong>();
        }

        public void InitializeDefaultLists()
        {
            HPPotionList.Add(604200101); //lowest tier
            MPPotionList.Add(605200101);

            HPPotionList.Add(604200102); //lowbie tier
            MPPotionList.Add(605200102);

            HPPotionList.Add(604200103); //medium
            MPPotionList.Add(605200103);

            HPPotionList.Add(604200104); //large
            MPPotionList.Add(605200104);

            LastHPUseTime = 0;
            LastMPUseTime = 0;
        }

        public bool UseHPPotion(Client client)
        {
            if (HPPotionList == null) return false;

            bool shouldUsePotion = false;
            _character_inven_item to_update = null;

            foreach (_character_inven_item item in client.Bot.PlayerInventory)
            {
                foreach (ulong index in HPPotionList.ToList())
                {
                    if (item.item_index == index)// match
                    {
                        if ((LastHPUseTime > DateTime.Now.Ticks - 5000) || LastHPUseTime == 0)
                        {
                            //use potion
                            if (item.stack_count > 0) //check last_used_time 
                            {
                                Console.WriteLine("Using HP Potion with index: {0}, uid {1}", item.item_index, item.item_uid);
                                client.UIMessages.Enqueue("Used HP Potion!");
                                to_update = item;
                                shouldUsePotion = true;
                                LastHPUseTime = DateTime.Now.Ticks;
                                MessageWrapper.CLIENT_GAME_USE_ITEM(client, item.item_uid, 1); //potions have 5 second cooldown .. .
                                break;
                            }
                        }
                    }
                }
            }

            if (shouldUsePotion && to_update != null)
            {
                to_update.last_used_time = DateTime.Now.Ticks;
                return true;
            }

            return false;
        }

        public bool UseMPPotion(Client client)
        {
            if (MPPotionList == null) return false;

            bool shouldUsePotion = false;
            _character_inven_item to_update = null;

            foreach (_character_inven_item item in client.Bot.PlayerInventory)
            {
                foreach (ulong index in MPPotionList.ToList())
                {
                    if (item.item_index == index)// match
                    {
                        if ((LastMPUseTime < DateTime.Now.Ticks - 5000) || LastMPUseTime == 0)
                        {
                            //use potion
                            if (item.stack_count > 0) //check last_used_time 
                            {
                                Console.WriteLine("Using HP Potion with index: {0}, uid {1}", item.item_index, item.item_uid);
                                client.UIMessages.Enqueue("Used MP Potion!");
                                to_update = item;
                                shouldUsePotion = true;
                                LastMPUseTime = DateTime.Now.Ticks;
                                MessageWrapper.CLIENT_GAME_USE_ITEM(client, item.item_uid, 1); //potions have 5 second cooldown .. .
                                break;
                            }
                        }
                    }
                }
            }

            if (shouldUsePotion && to_update != null)
            {
                to_update.last_used_time = DateTime.Now.Ticks;
                return true;
            }

            return false;
        }


    }
}
