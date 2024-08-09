//By AlSch092 @ Github
﻿//By AlSch092 @ github
using Mir4ClientEmulator.Context;
using System;
using System.Threading;
using System.Collections.Generic;
using Mir4ClientEmulator.Game;
using static Mir4ClientEmulator.Utilities.Enums;
using Mir4ClientEmulator.Network.Packets.Messages;
using System.Linq;
using Mir4ClientEmulator.Utilities;

namespace Mir4ClientEmulator.Network.Packets
{
    public static class GameServerHandler
    {    
        public static void GAME_CLIENT_AUTH(GameContext context, Reader packet)
        {
            Console.WriteLine("Got GAME_CLIENT_AUTH!");
            Thread.Sleep(1000);
            MessageWrapper.CLIENT_LOBBY_CHARACTER_LIST_ALL(context.Client, context.Client.GameAccount.account_uid);
        }

        public static void GAME_CLIENT_ERROR(GameContext context, byte[] protobuffer) //GAME_CLIENT_ERROR
        {
            GAME_CLIENT_ERROR msg = Protobuf.ProtoDeserialize<GAME_CLIENT_ERROR>(protobuffer);

            string error_str = FileHelper.GetPacketErrorString("Data/error_strings.txt", msg.error);
            Console.WriteLine("[ERROR] {0} : {1}", msg.error, error_str);
        }

        public static void LOBBY_CLIENT_CHARACTER_LIST_ALL(GameContext context, byte[] protobuffer)
        {
            Console.WriteLine("Got LOBBY_CLIENT_CHARACTER_LIST_ALL!");

            LOBBY_CLIENT_CHARACTER_LIST_ALL msg = Protobuf.ProtoDeserialize<LOBBY_CLIENT_CHARACTER_LIST_ALL>(protobuffer);
            bool found_character = false;

            if (msg.characterInfo_login != null)
            {
                foreach(_characterInfo_login characterInfo in msg.characterInfo_login)
                {
                    if(characterInfo.NickName == context.Client.GameAccount.CharacterName)
                    {
                        context.Client.GameAccount.CharacterName = characterInfo.NickName;
                        context.Client.GameAccount.character_identifier = characterInfo.character_uid;
                        context.Client.GameAccount.eClass = (e_class)characterInfo.eClass;
                        context.Client.GameAccount.Level = characterInfo.Level;
                        context.Client.GameAccount.Experience = characterInfo.Exp;
                        context.Client.GameAccount.StageID = characterInfo.StageID;
                        found_character = true;
                        break;
                    }

                    Console.WriteLine("Character: {0} {1}, Class: {2}, Stage: {3}", characterInfo.character_uid, characterInfo.NickName, (e_class)characterInfo.eClass, characterInfo.StageID);
                }
            }
        
            if(found_character)
            {
                Thread.Sleep(1000);
                context.Client.m_session.SendPacket(Factory.CLIENT_LOBBY_SELECT_CHARACTER(context.Client.GameAccount.account_uid, (int)context.Client.GameAccount.eClass, context.Client.GameAccount.character_identifier, 2));
            }
            else
            {
                Console.WriteLine("[ERROR] No matching characters found.");
            }
        }

        public static void GAME_CLIENT_GAME_OPTION_LIST(GameContext context, byte[] protobuffer)
        {
            Thread.Sleep(1000);
            context.Client.m_session.SendPacket(Factory.CLIENT_GAME_LOGIN(context.Client.GameAccount.character_identifier, (int)Os.Editor)); //todo, put these in other handlers
        }

        public static void WORLD_CLIENT_SELECT_CHARACTER(GameContext context, byte[] protobuffer)
        {
            WORLD_CLIENT_SELECT_CHARACTER msg = Protobuf.ProtoDeserialize<WORLD_CLIENT_SELECT_CHARACTER>(protobuffer);
            context.Client.GameAccount.Zone = msg.zone_unique;

            Console.WriteLine("Entering zone id: {0}", context.Client.GameAccount.Zone);

            Thread.Sleep(1000);
            context.Client.Bot.CharacterIds = new Dictionary<ulong, string>();
            context.Client.m_session.SendPacket(Factory.CLIENT_GAME_NOTIFY_WARP_READY((uint)context.Client.GameAccount.character_identifier, context.Client.GameAccount.warp_user_connected_session_index));
        }

        
        public static void WORLD_CLIENT_GUILD_MEMBER_LIST(GameContext context, byte[] protobuf)
        {
            WORLD_CLIENT_GUILD_MEMBER_LIST msg = Protobuf.ProtoDeserialize<WORLD_CLIENT_GUILD_MEMBER_LIST>(protobuf);

            if(msg.member_list != null)
            {
                foreach(_guild_member_info guildie in msg.member_list)
                {
                    if(guildie.simple_info != null)
                    {
                        Console.WriteLine("Found guild member: {0}", guildie.simple_info.nickname);
                    }
                }
            }
        }

        public static void GAME_CLIENT_GUILD_GIFT_LIST(GameContext context, byte[] protobuf)
        {
            GAME_CLIENT_GUILD_GIFT_LIST msg = Protobuf.ProtoDeserialize<GAME_CLIENT_GUILD_GIFT_LIST>(protobuf);

            if (msg.guild_gift_list != null)
            {
                foreach (_guild_gift_info gift in msg.guild_gift_list)
                {
                    if(gift.is_open == 0)
                    {
                        Console.WriteLine("Guild gift: {0}, sent from {1} (tap {2}), endDate: {3}, current time: {4}", gift.gift_uid, gift.send_character_name, gift.gift_tap_type, gift.gift_recv_date, Environment.TickCount);

                        if (context.Client.Bot.GuildGiftList != null)
                        {
                            if(!context.Client.Bot.GuildGiftList.Contains(gift))
                                context.Client.Bot.GuildGiftList.Add(gift);
                        }
                    }
                }
            }
        }

        public static void GAME_CLIENT_BENEDICTION_EVENT_SELECT(GameContext context, byte[] protobuf)
        {
            GAME_CLIENT_BENEDICTION_EVENT_SELECT msg = Protobuf.ProtoDeserialize<GAME_CLIENT_BENEDICTION_EVENT_SELECT>(protobuf);

            Console.WriteLine("Opened BENEDICTION ticket: result {0}, ", msg.result);

            if (msg.update_items != null)
            {
                foreach (var item in msg.update_items)
                {
                    Console.WriteLine("Retrieved item from BENEDICTION ticket: {0} ({1}), Count: {2} ", item.item_index, item.item_uid, item.stack_count);
                }
            }
        }
     
        public static void GAME_CLIENT_GUILD_GIFT_OPEN(GameContext context, byte[] protobuf)
        {
            GAME_CLIENT_GUILD_GIFT_OPEN msg = Protobuf.ProtoDeserialize<GAME_CLIENT_GUILD_GIFT_OPEN>(protobuf);

            Console.WriteLine("Opened guild gift: result {0}, ", msg.result);

            if(msg.update_items != null)
            {
                foreach(var item in msg.update_items)
                {
                    Console.WriteLine("Retrieved item from guild gift: {0} ({1}), Count: {2} ", item.item_index, item.item_uid, item.stack_count);
                    context.Client.UIMessages.Enqueue("Opened guild gift " + Convert.ToUInt64(item.item_uid));
                }
            }            
        }

        public static void GAME_CLIENT_SYNC_EVENT_DATA(GameContext context, byte[] protobuf)
        {
            GAME_CLIENT_SYNC_EVENT_DATA msg = Protobuf.ProtoDeserialize<GAME_CLIENT_SYNC_EVENT_DATA>(protobuf);

            if (msg.event_data_list != null)
            {
                foreach (var event_data in msg.event_data_list)
                {
                    Console.WriteLine("event_data_id: {0}, count: {1}", event_data.event_data_id, event_data.count);
                }
            }
        }

        public static void GAME_CLIENT_BATTLE_STATE(GameContext context, byte[] protobuf)
        {
            GAME_CLIENT_BATTLE_STATE msg = Protobuf.ProtoDeserialize<GAME_CLIENT_BATTLE_STATE>(protobuf);

            if(msg.user_uid == context.Client.GameAccount.character_identifier)
            {
                Console.WriteLine("Our player changed to battle state: {0}", msg.battle_state);
            }
        }
        
        public static void GAME_CLIENT_END_QUEST(GameContext context, byte[] protobuf)
        {
            GAME_CLIENT_END_QUEST msg = Protobuf.ProtoDeserialize<GAME_CLIENT_END_QUEST>(protobuf);
            Console.WriteLine("Ended quest: result {0}, Exp gained: {1}, endquestindex: {2}", msg.result, msg.exp, msg.endquestindex);       

            if(msg.result == 0)
            {
                _character_quest to_delete = null;

                if(context.Client.Bot.QuestManager != null)
                {
                    if (context.Client.Bot.QuestManager.AutoQuesting)
                    {
                        foreach (_character_quest q in context.Client.Bot.QuestManager.QuestList)
                        {
                            if (msg.endquestindex == q.QuestIndex)
                            {
                                to_delete = q;
                                break;
                            }
                        }

                        if (to_delete != null)
                        {
                            context.Client.Bot.QuestManager.QuestList.Remove(to_delete);
                        }
                    }
                }           
            }
        }

        public static void GAME_CLIENT_CANCEL_SUBQUEST(GameContext context, byte[] protobuf)
        {
            GAME_CLIENT_CANCEL_SUBQUEST msg = Protobuf.ProtoDeserialize<GAME_CLIENT_CANCEL_SUBQUEST>(protobuf);
            Console.WriteLine("Cancelled sub-quest: result {0}, quest index: {1}", msg.result, msg.quest_index);

            if (msg.result == 0) //success
            {
                if (context.Client.Bot.QuestManager == null) return;

                if (context.Client.Bot.QuestManager.AutoQuesting)
                {

                }
            }
            else if(msg.result == 1) //failed
            {

            }
        }

        public static void GAME_CLIENT_CHANGE_QUEST_COUNTER(GameContext context, byte[] protobuf)
        {
            GAME_CLIENT_CHANGE_QUEST_COUNTER msg = Protobuf.ProtoDeserialize<GAME_CLIENT_CHANGE_QUEST_COUNTER>(protobuf);
            Console.WriteLine("Updated quest counter: quest index: {0}, type {1}, count {2} ", msg.quest_index, msg.quest_type, msg.count);

            //if (context.Client.Bot.QuestManager == null) return;
            //if (context.Client.Bot.QuestManager.QuestList == null) return;

            ////_character_quest to_update = null;
            ////int count_update = 0;

            //if (context.Client.Bot.QuestManager.QuestList.ToList() == null) return;

            //foreach (_character_quest q in context.Client.Bot.QuestManager.QuestList) //CRASHES.... for no reason
            //{
            //    if(q.QuestIndex == msg.quest_index)
            //    {
            //        //to_update = q;
            //        //count_update = msg.count;
            //        q.CurrentCount = msg.count;
            //        break;
            //    }

            //    if(context.Client.Bot.QuestManager.CurrentQuest.QuestId == msg.quest_index) //current quest we are doing -> DO WE ACTUALLY NEED THIS? OR DOES MAX COUNTER SEND US COMPLETE_QUEST??
            //    {
            //        MessageWrapper.CLIENT_GAME_COMPLETE_QUEST(context.Client, msg.quest_index, context.Client.Bot.QuestManager.GetMissionType(msg.quest_index));
            //    }
            //}

            ////if(to_update != null)
            ////{
            ////    to_update.CurrentCount = count_update;
            ////}

        }

        public static void GAME_CLIENT_GREAT_BUILDING_INFO(GameContext context, byte[] protobuf)
        {
            GAME_CLIENT_GREAT_BUILDING_INFO msg = Protobuf.ProtoDeserialize<GAME_CLIENT_GREAT_BUILDING_INFO>(protobuf);

        }

        public static void GAME_CLIENT_GET_DARKSTEEL_DAILY_SUM(GameContext context, byte[] protobuf)
        {
            GAME_CLIENT_GET_DARKSTEEL_DAILY_SUM msg = Protobuf.ProtoDeserialize<GAME_CLIENT_GET_DARKSTEEL_DAILY_SUM>(protobuf);

            Console.WriteLine("Total accum darksteel: {0}, smelting cost: {1} ", msg.accum_darksteel, msg.smelting_cost);
        }

        public static void GAME_WORLD_ENTER_MAGIC_SQUARE(GameContext context, byte[] protobuf)
        {
            GAME_WORLD_ENTER_MAGIC_SQUARE msg = Protobuf.ProtoDeserialize<GAME_WORLD_ENTER_MAGIC_SQUARE>(protobuf);

            Console.WriteLine("Entered magic square: magic square id {0}, location id {1}", msg.magic_square_id, msg.enter_location_id);
        }
        
        public static void GAME_CLIENT_CHARACTER_QUEST(GameContext context, byte[] protobuf)
        {
            GAME_CLIENT_CHARACTER_QUEST msg = Protobuf.ProtoDeserialize<GAME_CLIENT_CHARACTER_QUEST>(protobuf);

            bool duplicate = false;

            if(msg.questinfos != null)
            {
                foreach(_character_quest quest in msg.questinfos.ToList())
                {
                    Console.WriteLine("Got character quest: {0}, type: {1}, state: {2}, count: {3}", quest.QuestIndex, quest.quest_type, quest.State, quest.CurrentCount);
            
                    if (context.Client.Bot.QuestManager.QuestList != null)
                    {
                        foreach(_character_quest _quest in  context.Client.Bot.QuestManager.QuestList)
                        {
                            if(_quest.QuestIndex == quest.QuestIndex)
                            {
                                duplicate = true;
                            }
                        }

                        _character_quest q = new _character_quest(quest);
                        
                        if(!duplicate)
                            context.Client.Bot.QuestManager.QuestList.Add(q);
                    }
                }
            }
        }

        public static void GAME_CLIENT_CHARACTER_SUB_QUEST(GameContext context, byte[] protobuf)
        {
            GAME_CLIENT_CHARACTER_SUB_QUEST msg = Protobuf.ProtoDeserialize<GAME_CLIENT_CHARACTER_SUB_QUEST>(protobuf);

            if(msg.subquest_indexs != null)
            {
                foreach(int index in msg.subquest_indexs)
                {
                    Console.WriteLine("Subquest index: {0}", index);
                }
            }
        }

        public static void GAME_CLIENT_QUEST_ACTION_RESULT(GameContext context, byte[] protobuf)
        {
            GAME_CLIENT_QUEST_ACTION_RESULT msg = Protobuf.ProtoDeserialize<GAME_CLIENT_QUEST_ACTION_RESULT>(protobuf);

            Console.WriteLine("GAME_CLIENT_QUEST_ACTION_RESULT: {0}, result {1}", msg.quest_index, msg.result);
        }

        public static void GAME_CLIENT_QUEST_NPC_TALK(GameContext context, byte[] protobuf)
        {
            GAME_CLIENT_QUEST_NPC_TALK msg = Protobuf.ProtoDeserialize<GAME_CLIENT_QUEST_NPC_TALK>(protobuf);
            Console.WriteLine("GAME_CLIENT_QUEST_NPC_TALK: {0}, result {1}", msg.quest_index, msg.result);
        }

        public static void GAME_CLIENT_START_QUEST(GameContext context, byte[] protobuf)
        {
            GAME_CLIENT_START_QUEST msg = Protobuf.ProtoDeserialize<GAME_CLIENT_START_QUEST>(protobuf);
            Console.WriteLine("Started quest: result {0}, index {1}, type {2}, state {3}, currentCount {4}", msg.result, msg.questinfo.QuestIndex, msg.questinfo.quest_type, msg.questinfo.State, msg.questinfo.CurrentCount);

            if (msg.result == 0)
            {
                if(msg.questinfo != null)
                {
                    _character_quest q = new _character_quest(msg.questinfo);
                    
                    if(context.Client.Bot.QuestManager.QuestList != null)
                    {
                        if(!context.Client.Bot.QuestManager.QuestList.Contains(q)) //todo: check to make sure this works properly
                            context.Client.Bot.QuestManager.QuestList.Add(q);
                    }
                }
            }
        }
        public static void GAME_CLIENT_UPDATE_QUEST(GameContext context, byte[] protobuf)
        {
            GAME_CLIENT_UPDATE_QUEST msg = Protobuf.ProtoDeserialize<GAME_CLIENT_UPDATE_QUEST>(protobuf);
            Console.WriteLine("Updated quest: index {0}, state {1}", msg.quest_index, msg.state);
        }

        public static void GAME_CLIENT_COMPLETE_QUEST(GameContext context, byte[] protobuf)
        {
            GAME_CLIENT_COMPLETE_QUEST msg = Protobuf.ProtoDeserialize<GAME_CLIENT_COMPLETE_QUEST>(protobuf);
            
            Console.WriteLine("Completed quest: index {0}, quest_type {1}. Sending completion request...", msg.QuestIndex, context.Client.Bot.QuestManager.GetMissionType(msg.QuestIndex));
       
            if(context.Client.Bot.QuestManager.AutoQuesting)
            {
                if(msg.QuestIndex == context.Client.Bot.QuestManager.CurrentQuest.QuestId)
                {
                    Thread.Sleep(1000);
                    MessageWrapper.CLIENT_GAME_COMPLETE_QUEST(context.Client, msg.QuestIndex, context.Client.Bot.QuestManager.GetMissionType(msg.QuestIndex));

                    if(context.Client.Bot.attack_worker != null) //stop attacking thread when the quest we are doing is finished -> track counter in other handler and check to see if we're finished
                    {
                        if(context.Client.Bot.AutoAttacking)
                        {
                            context.Client.Bot.attack_worker.Abort();
                        }
                    }
                }
            }

            //delete from our list
            if (context.Client.Bot.QuestManager.QuestList != null)
            {
                _character_quest to_remove = null;

                foreach (_character_quest q in context.Client.Bot.QuestManager.QuestList.ToList())
                {
                    if (q.QuestIndex == msg.QuestIndex)
                    {
                        to_remove = q;
                        break;
                    }
                }

                if (to_remove != null)
                {
                    context.Client.Bot.QuestManager.QuestList.Remove(to_remove);
                }
            }

            if(context.Client.Bot.QuestManager.CompletedQuestIds != null)
            {
                if(!context.Client.Bot.QuestManager.CompletedQuestIds.Contains(msg.QuestIndex))
                    context.Client.Bot.QuestManager.CompletedQuestIds.Add(msg.QuestIndex);
            }
        }

        public static void GAME_CLIENT_DELETE_QUEST(GameContext context, byte[] protobuf)
        {
            GAME_CLIENT_DELETE_QUEST msg = Protobuf.ProtoDeserialize<GAME_CLIENT_DELETE_QUEST>(protobuf);
            Console.WriteLine("Deleted quest: quest_id {0}, uid {1}, count {2}", msg.delete_quest_id, msg.uid);

            //delete from our list
            if(context.Client.Bot.QuestManager.QuestList != null)
            {
                _character_quest to_remove = null;

                foreach (_character_quest q in context.Client.Bot.QuestManager.QuestList)
                {
                    if(q.QuestIndex == msg.delete_quest_id)
                    {
                        to_remove = q;
                        break;
                    }
                }

                if(to_remove != null)
                {
                    context.Client.Bot.QuestManager.QuestList.Remove(to_remove);
                }
            }
        }

        public static void GAME_CLIENT_ADD_SUBQUEST(GameContext context, byte[] protobuf)
        {
            GAME_CLIENT_ADD_SUBQUEST msg = Protobuf.ProtoDeserialize<GAME_CLIENT_ADD_SUBQUEST>(protobuf);
            Console.WriteLine("Added sub-quest: quest_id {0}, tracker {1}", msg.quest_index, msg.tracker);
        }

        public static void GAME_CLIENT_ENDQUEST_GUILD_DAILY_MISSION(GameContext context, byte[] protobuf)
        {
            GAME_CLIENT_ENDQUEST_GUILD_DAILY_MISSION msg = Protobuf.ProtoDeserialize<GAME_CLIENT_ENDQUEST_GUILD_DAILY_MISSION>(protobuf);

            Console.WriteLine("GAME_CLIENT_ENDQUEST_GUILD_DAILY_MISSION: result {0} ", msg.result);

            if(msg.result == 0)
            {
                Console.WriteLine("Quest info: {0}, {1}, {2}, {3}, {4}", msg.index, msg.clearcnt, msg.currentLevel, msg.exp, msg.state);
            }
        }

        public static void GAME_CLIENT_GUILD_DAILY_MISSION_DATA(GameContext context, byte[] protobuf)
        {
            GAME_CLIENT_GUILD_DAILY_MISSION_DATA msg = Protobuf.ProtoDeserialize<GAME_CLIENT_GUILD_DAILY_MISSION_DATA>(protobuf);
            
            if(msg.guild_daily_mission_infos != null)
            {
                foreach(_guild_daily_mission_info mission in msg.guild_daily_mission_infos)
                {
                    Console.WriteLine("Guild mission {0}, count {1}, clearcount {2}", mission.index, mission.count, mission.clearcnt);
                }
            }
        }

        public static void GAME_CLIENT_REWARD_GUILD_GIFT(GameContext context, byte[] protobuf)
        {
            GAME_CLIENT_REWARD_GUILD_GIFT msg = Protobuf.ProtoDeserialize<GAME_CLIENT_REWARD_GUILD_GIFT>(protobuf);
            
            if(msg.guild_gift_info != null)
            {
                Console.WriteLine("Guild reward: gift id {0}, uid {1} from {2}, attempting collection..", msg.guild_gift_info.gift_id, msg.guild_gift_info.gift_uid, msg.guild_gift_info.send_character_name);

                //collect guild reward
                context.Client.UIMessages.Enqueue("Attemped collection of guild gift..");
                MessageWrapper.CLIENT_GAME_GUILD_GIFT_OPEN(context.Client, msg.guild_gift_info.gift_tap_type, msg.guild_gift_info.gift_uid);
            }
        }

        
        public static void GAME_CLIENT_GUILD_COST(GameContext context, byte[] protobuf)
        {
            GAME_CLIENT_GUILD_COST msg = Protobuf.ProtoDeserialize<GAME_CLIENT_GUILD_COST>(protobuf);

            if (msg.guild_cost_info != null)
            {
                
            }
        }


        public static void GAME_CLIENT_QUEST_RELATION_DATA(GameContext context, byte[] protobuf)
        {
            GAME_CLIENT_QUEST_RELATION_DATA msg = Protobuf.ProtoDeserialize<GAME_CLIENT_QUEST_RELATION_DATA>(protobuf);

            if (msg.relation_quest_infos != null)
            {
                foreach (_relation_quest_info mission in msg.relation_quest_infos)
                {
                    Console.WriteLine("Relation quest {0}, count {1}, state {2}", mission.index, mission.count, mission.state);
                }
            }
        }
     
        public static void GAME_CLIENT_NOTIFY_DUNGEON_CLEAR_LIST(GameContext context, byte[] protobuf)
        {
            GAME_CLIENT_NOTIFY_DUNGEON_CLEAR_LIST msg = Protobuf.ProtoDeserialize<GAME_CLIENT_NOTIFY_DUNGEON_CLEAR_LIST>(protobuf);

            if (msg.clear_dungeon_index != null)
            {
                foreach (uint clear_index in msg.clear_dungeon_index)
                {
                    Console.WriteLine("Dungeon notify clear: {0}", clear_index);
                }
            }
        }

        public static void GAME_CLIENT_SMELTING_ITEM(GameContext context, byte[] protobuf)
        {
            GAME_CLIENT_SMELTING_ITEM msg = Protobuf.ProtoDeserialize<GAME_CLIENT_SMELTING_ITEM>(protobuf);
            Console.WriteLine("Item enahncement result: {0}, broken item: {1}, smelting result {2}", msg.result, msg.break_item_uid, msg.smelting_result);
            
        }

        
        public static void GAME_CLIENT_CHARACTER_MAP_WAYPOINT_DATA(GameContext context, byte[] protobuf)
        {
            GAME_CLIENT_CHARACTER_MAP_WAYPOINT_DATA msg = Protobuf.ProtoDeserialize<GAME_CLIENT_CHARACTER_MAP_WAYPOINT_DATA>(protobuf);
            
            if(msg.map_waypoint_id_list != null)
            {
                foreach(int waypoint_id in msg.map_waypoint_id_list)
                {
                    Console.WriteLine("Map waypoint ID: {0}", waypoint_id);
                }
            }
        }

        public static void GAME_CLIENT_CHANNEL_INFO(GameContext context, byte[] protobuf)
        {
            GAME_CLIENT_CHANNEL_INFO msg = Protobuf.ProtoDeserialize<GAME_CLIENT_CHANNEL_INFO>(protobuf);
            Console.WriteLine("Channel Info: current channel is {0}", msg.cur_channel_index);
        }

        
        public static void GAME_CLIENT_CHARACTER_PLAY_DATA(GameContext context, byte[] protobuf)
        {
            GAME_CLIENT_CHARACTER_PLAY_DATA msg = Protobuf.ProtoDeserialize<GAME_CLIENT_CHARACTER_PLAY_DATA>(protobuf);

            if(msg.character_play_data_list != null)
            {
                foreach(_character_play_data_info cpdi in msg.character_play_data_list)
                {
                    Console.WriteLine("Play data info: id {0}, count {1}", cpdi.play_data_id, cpdi.count);
                }
            }
        }
      
        public static void GAME_CLIENT_NPC_SHOP_DATA(GameContext context, byte[] protobuf)
        {
            GAME_CLIENT_NPC_SHOP_DATA msg = Protobuf.ProtoDeserialize<GAME_CLIENT_NPC_SHOP_DATA>(protobuf);
            
            if(msg.shop_item_list == null)
            {
                foreach(_shop_npc_item_data item in msg.shop_item_list)
                {
                    Console.WriteLine("Shop item: commodity_id {0}, sell_id {1}, money_id {2}, cost: {3}, order: {4}", item.commodity_id, item.sell_id, item.money_id, item.money_value, item.order_num);
                }
            }

        }

        public static void GAME_CLIENT_NPC_SHOP_BUY(GameContext context, byte[] protobuf)
        {
            GAME_CLIENT_NPC_SHOP_BUY msg = Protobuf.ProtoDeserialize<GAME_CLIENT_NPC_SHOP_BUY>(protobuf);

        }

        public static void GAME_CLIENT_GUILD_SHOP_LIST(GameContext context, byte[] protobuf)
        {
            GAME_CLIENT_GUILD_SHOP_LIST msg = Protobuf.ProtoDeserialize<GAME_CLIENT_GUILD_SHOP_LIST>(protobuf);

            if(msg.goods_list != null)
            {
                foreach(_guild_goods_info item in msg.goods_list)
                {
                    Console.WriteLine("Guild shop item: {0}, count {1}", item.goods_index, item.goods_count);
                }
            }
        }

        public static void GAME_CLIENT_GUILD_SHOP_BUY(GameContext context, byte[] protobuf)
        {
            GAME_CLIENT_GUILD_SHOP_BUY msg = Protobuf.ProtoDeserialize<GAME_CLIENT_GUILD_SHOP_BUY>(protobuf);

            if (msg.update_items != null)
            {
                foreach (_character_inven_item item in msg.update_items)
                {
                    Console.WriteLine("Bought Guild shop item: {0}, count {1}", item.item_index, item.stack_count);
                }
            }
        }
        

        public static void GAME_CLIENT_BUFF_LIST(GameContext context, byte[] protobuf)
        {
            GAME_CLIENT_BUFF_LIST msg = Protobuf.ProtoDeserialize<GAME_CLIENT_BUFF_LIST>(protobuf);

            if (msg.buff_list != null)
            {
                foreach (_buff_info buff in msg.buff_list)
                {
                    if(buff.buff_owner_uid == context.Client.GameAccount.character_identifier)
                    {
                        Console.WriteLine("Got buff: {0} with time {1} left", buff.buff_id, buff.buff_left_time);
                    }
                }
            }
        }
   
        public static void GAME_CLIENT_CHARACTER_MASTERY_DATA(GameContext context, byte[] protobuf)
        {
            GAME_CLIENT_CHARACTER_MASTERY_DATA msg = Protobuf.ProtoDeserialize<GAME_CLIENT_CHARACTER_MASTERY_DATA>(protobuf);

            if (msg.mastery_slot_list != null)
            {
                foreach (_character_mastery_slot mastery in msg.mastery_slot_list)
                {
                    Console.WriteLine("Mastery data: slot {0}, count {1}", mastery.slot_index, mastery.mastery_count);
                }
            }
        }    

        public static void GAME_CLIENT_COMMIT_SUBQUEST(GameContext context, byte[] protobuf)
        {
            GAME_CLIENT_COMMIT_SUBQUEST msg = Protobuf.ProtoDeserialize<GAME_CLIENT_COMMIT_SUBQUEST>(protobuf);
            Console.WriteLine("Commit sub-quest: quest_id {0}, result {1}, state {2} ", msg.quest_index, msg.result, msg.state);
        }

        public static void GAME_CLIENT_LEVEL_UP(GameContext context, byte[] protobuf)
        {
            GAME_CLIENT_LEVEL_UP msg = Protobuf.ProtoDeserialize<GAME_CLIENT_LEVEL_UP>(protobuf);
            
            if(msg.uid == context.Client.GameAccount.character_identifier)
            {
                Console.WriteLine("Level up: {0}", msg.level);
                context.Client.GameAccount.Level = msg.level;
            }       
        }
        
        public static void GAME_CLIENT_REVIVAL_RESULT(GameContext context, byte[] protobuf)
        {
            GAME_CLIENT_REVIVAL_RESULT msg = Protobuf.ProtoDeserialize<GAME_CLIENT_REVIVAL_RESULT>(protobuf);

            if ((ulong)msg.revived_uid == context.Client.GameAccount.character_identifier)
            {
                Console.WriteLine("[INFO] Revived successfully and lost {0} experience.", msg.restore_exp);
                context.Client.UIMessages.Enqueue("[INFO] Player revived for " + Convert.ToString(msg.restore_exp) + " experience.");
                context.Client.Bot.IsDead = false;
            }
        }

        public static void GAME_CLIENT_BROADCAST_REVIVAL(GameContext context, byte[] protobuf)
        {
            GAME_CLIENT_BROADCAST_REVIVAL msg = Protobuf.ProtoDeserialize<GAME_CLIENT_BROADCAST_REVIVAL>(protobuf);

            if (msg.uid == context.Client.GameAccount.character_identifier)
            {
                context.Client.Bot.PlayerStats.MaxHP = msg.max_hp;
                context.Client.Bot.PlayerStats.CurrentHP = msg.hp;
                context.Client.Bot.PlayerStats.CurrentMana = msg.mana;
                context.Client.Bot.PlayerStats.MaxMana = msg.max_mana;

                Console.WriteLine("[INFO] Revived successfully!");
                context.Client.UIMessages.Enqueue("[INFO] Revived successfully!");
                context.Client.Bot.IsDead = false;
            }
        }

        public static void GAME_CLIENT_WARP_START(GameContext context, byte[] protobuf)
        {
            GAME_CLIENT_WARP_START msg = Protobuf.ProtoDeserialize<GAME_CLIENT_WARP_START>(protobuf);

            context.Client.Bot.Position = msg.CharInfo.loc;

            context.Client.m_session.SendThreadedPacket(Factory.CLIENT_GAME_DATA_SEQUENTIAL_PACKET(), 1000);
            Thread.Sleep(1500);
            context.Client.m_session.SendThreadedPacket(Factory.CLIENT_GAME_END_LOADING(), 1500);
        }

        public static void GAME_CLIENT_PARTY_MEMBER_ENTER(GameContext context, byte[] protobuf)
        {
            GAME_CLIENT_PARTY_MEMBER_ENTER msg = Protobuf.ProtoDeserialize<GAME_CLIENT_PARTY_MEMBER_ENTER>(protobuf);

            Console.WriteLine("Player {0} joined party.", msg.join_party_uid);
            context.Client.UIMessages.Enqueue("[INFO] Player " + Convert.ToString(msg.join_party_uid) + " joined party.");
        }

        
        public static void GAME_CLIENT_ITEM_RANDOM_EXCHANGE(GameContext context, byte[] protobuff)
        {
            GAME_CLIENT_ITEM_RANDOM_EXCHANGE msg = Protobuf.ProtoDeserialize<GAME_CLIENT_ITEM_RANDOM_EXCHANGE>(protobuff);

            if(msg.result == 0)
            {
                if(msg.update_items != null)
                {
                    foreach(var item in msg.update_items)
                    {
                        Console.WriteLine("Got item from exchange: {0},{1}", item.item_index, item.item_uid);
                    }
                }

                if(msg.costInfo != null)
                {
                    foreach(var costInfo in msg.costInfo)
                    {
                        Console.WriteLine("Got costinfo from exchange: CurrentValue {0}, CostSubType {1}", costInfo.CurrentValue, costInfo.CostSubType);
                    }
                }
            }
        }

        public static void GAME_CLIENT_MAIL_NEW(GameContext context, byte[] protobuff)
        {
            GAME_CLIENT_MAIL_NEW msg = Protobuf.ProtoDeserialize<GAME_CLIENT_MAIL_NEW>(protobuff);
            Console.WriteLine("Received new mail: {0} from {1}", msg.mail_data.title, msg.mail_data.sender_nick_name);
        }

       
        public static void GAME_CLIENT_CHARACTER_INVEN_START(GameContext context, byte[] protobuff)
        {
            GAME_CLIENT_CHARACTER_INVEN_START msg = Protobuf.ProtoDeserialize<GAME_CLIENT_CHARACTER_INVEN_START>(protobuff);
            Console.WriteLine("Loading inventories: {0} items, maxInvenCount: {1} ", msg.itemCount, msg.maxInvenCount);
        }

        public static void GAME_CLIENT_CHARACTER_INVEN_END(GameContext context, byte[] protobuff)
        {
            GAME_CLIENT_CHARACTER_INVEN_END msg = Protobuf.ProtoDeserialize<GAME_CLIENT_CHARACTER_INVEN_END>(protobuff);           
        }

        public static void GAME_CLIENT_CHARACTER_INVEN_DATA(GameContext context, byte[] protobuff)
        {
            GAME_CLIENT_CHARACTER_INVEN_DATA msg = Protobuf.ProtoDeserialize<GAME_CLIENT_CHARACTER_INVEN_DATA>(protobuff);

            if(msg.character_inven_items != null)
            {
                foreach (var item in msg.character_inven_items)
                {
                    Console.WriteLine("Found Inventory item: {0}, count: {1}, uid {2}", item.item_index, item.stack_count, item.item_uid);

                    if (context.Client.Bot.PlayerInventory != null)
                        context.Client.Bot.PlayerInventory.Add(item);
                }
            }
        }

        public static void GAME_CLIENT_CHARACTER_QUICKSLOT_DATA(GameContext context, byte[] protobuff)
        {
            GAME_CLIENT_CHARACTER_INVEN_DATA msg = Protobuf.ProtoDeserialize<GAME_CLIENT_CHARACTER_INVEN_DATA>(protobuff);

            if(msg.character_inven_items != null)
            {
                foreach(var item in msg.character_inven_items)
                {
                    Console.WriteLine("Quickslot item: {0}, count: {1}, uid: {2}", item.item_index, item.stack_count, item.item_uid);

                    if (context.Client.Bot.QuickSlot != null)
                        context.Client.Bot.QuickSlot.Add(item);
                }
            }
        }

        public static void GATEWAY_CLIENT_UNCHEATER_COOKIE(GameContext context, Reader packet)
        {
            Console.WriteLine("Got Uncheater Cookie!");
        }

        //89 13 00 00 00 00 00 00 00 00 00 01 0A 40 8 A6 E9 DB BC 7 12 5 4F 43 6F 38 39 18 4 20 8C 1 2A C 44 54 4D 20 50 6F 73 65 69 64 6F 6E 30 9 38 B4 C8 2 40 85 FD D4 A4 6 4A C 32 30 30 36 33 38 31 37 33 34 2F 34 60 75 68 4 78 75 12 D3 3 7B 22 55 49 44 22 3A 22 31 34 30 33 36 37 32 30 32 32 34 31 34 30 30 30 31 32 39 22 2C 22 49 6E 64 65 78 22 3A 38 30 37 32 30 30 30 30 34 2C 22 53 6D 65 6C 74 69 6E 67 4C 76 22 3A 30 2C 22 64 75 72 61 62 69 6C 69 74 79 22 3A 30 2C 22 52 61 6E 64 6F 6D 4F 70 74 69 6F 6E 4C 69 73 74 22 3A 5B 7B 22 4F 70 74 69 6F 6E 53 6C 6F 74 22 3A 31 2C 22 4F 70 74 69 6F 6E 49 64 78 22 3A 34 35 35 2C 22 4F 70 74 69 6F 6E 56 61 6C 75 65 22 3A 31 39 7D 2C 7B 22 4F 70 74 69 6F 6E 53 6C 6F 74 22 3A 32 2C 22 4F 70 74 69 6F 6E 49 64 78 22 3A 34 36 38 2C 22 4F 70 74 69 6F 6E 56 61 6C 75 65 22 3A 39 7D 2C 7B 22 4F 70 74 69 6F 6E 53 6C 6F 74 22 3A 33 2C 22 4F 70 74 69 6F 6E 49 64 78 22 3A 34 35 34 2C 22 4F 70 74 69 6F 6E 56 61 6C 75 65 22 3A 31 37 7D 5D 2C 22 47 61 69 6E 54 79 70 65 22 3A 39 2C 22 53 65 63 6F 6E 64 56 61 6C 75 65 22 3A 30 2C 22 58 44 52 41 43 4F 5F 53 74 61 74 65 22 3A 30 2C 22 61 63 71 75 69 73 69 74 69 6F 6E 5F 70 61 74 68 22 3A 30 2C 22 61 63 71 75 69 73 69 74 69 6F 6E 5F 70 61 74 68 5F 76 61 6C 75 65 22 3A 30 2C 22 61 63 71 75 69 73 69 74 69 6F 6E 5F 70 61 74 68 5F 63 72 65 61 74 65 5F 74 69 6D 65 22 3A 30 2C 22 73 65 72 69 61 6C 5F 6E 75 6D 62 65 72 22 3A 22 22 2C 22 63 6F 6C 6C 65 63 74 61 62 6C 65 22 3A 30 2C 22 6C 69 6D 69 74 65 64 22 3A 22 22 2C 22 77 6F 72 6C 64 5F 69 64 22 3A 31 31 37 2C 22 54 72 61 6E 63 65 53 74 65 70 22 3A 30 2C 22 52 65 66 69 6E 65 53 74 65 70 22 3A 30 7D 18 3 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0
        public static void GAME_CLIENT_CHATMSG(GameContext context, byte[] protobuff) //GAME_CLIENT_CHATMSG
        {
            GAME_CLIENT_CHATMSG msg = Protobuf.ProtoDeserialize<GAME_CLIENT_CHATMSG>(protobuff);
            Console.WriteLine("Got game chat message from {0}: {1}",  msg.chat_header.name, msg.msg);
            context.Client.UIMessages.Enqueue("[" + msg.chat_header.name + "]: " + msg.msg);
        }

        public static void GAME_CLIENT_SYSTEM_MESSAGE(GameContext context, byte[] protobuff) //GAME_SYSTEM_MESSAGE
        {
            Console.WriteLine("Got system message!");
        }

        public static void GAME_CLIENT_DESTROY_NPC(GameContext context, byte[] protobuff)
        {
            Console.WriteLine("HandleDestroyNPC");
        }

        public static void WORLD_CLIENT_NOTIFY_FRIEND_INVITE(GameContext context, byte[] protobuff)
        {
            WORLD_CLIENT_NOTIFY_FRIEND_INVITE msg = Protobuf.ProtoDeserialize<WORLD_CLIENT_NOTIFY_FRIEND_INVITE>(protobuff);
            Console.WriteLine("Player {0} added us as friends!", msg.friend_request_info.friend_info_base.nickname);
        }
        

        public static void GAME_CLIENT_SYNC_USER(GameContext context, byte[] protobuffer)
        {
            /*uint64 uid = 1; _Vec3 loc = 2; _Vec3 dirsection = 3; float moveSpeed = 4;  int32 state = 5;int32 animState = 6; int32 heightState = 7; int32 actionState = 8;  float degree = 9;  _Vec3 dest_loc = 10; int32 battle_state = 11;uint64 zone_uid = 12; */
            GAME_CLIENT_SYNC_USER msg = Protobuf.ProtoDeserialize<GAME_CLIENT_SYNC_USER>(protobuffer);

            if(msg.uid == context.Client.GameAccount.character_identifier)
            {
                context.Client.Bot.Position = msg.dest_loc;
            }

        }

        //EA 57 00 00 00 00 00 00 00 00 00 01 08 C9 05 10 03 22 0F 0D 00 27 19 C4 15 5E 61 81 C5 1D E0 EE 05 43 40 EB 01 5A 0F 0D C9 CC 2E C4 15 13 46 76 C5 1D E0 EE 05 43 70 BE AA 01
        public static void GAME_CLIENT_SYNCNPC(GameContext context, byte[] protobuffer) //includes monster movement!
        {
            GAME_CLIENT_SYNCNPC msg = Protobuf.ProtoDeserialize<GAME_CLIENT_SYNCNPC>(protobuffer);
            //Console.WriteLine("GAME_CLIENT_SYNCNPC: {0}, {1}, {2}", msg.npc_uid, msg.zone_uid, msg.state);

            bool isDuplicate = Entity.IsDuplicate(msg.npc_uid, context.Client.Bot.EntityList);

            if (!isDuplicate)
            {
                Entity e = new Entity(msg.npc_uid, msg.type, msg.loc, 0, 0, msg.state);
                context.Client.Bot.EntityList.Add(e);
            }
            else
            {
                foreach(Entity ent in context.Client.Bot.EntityList)
                {
                    if(ent.id == msg.npc_uid) //update coordinates, etc
                    {
                        ent.Position.x = msg.dest_pos.x;
                        ent.Position.y = msg.dest_pos.y;
                        ent.Position.z = msg.dest_pos.z;
                        ent.state = msg.state; //dont think we can update it from here properly..
                    }
                }
            }
        }

        public static void GAME_CLIENT_APPEAR_USER(GameContext context, byte[] protobuffer)
        {
            GAME_CLIENT_APPEAR_USER msg = Protobuf.ProtoDeserialize<GAME_CLIENT_APPEAR_USER>(protobuffer);
            
            if (msg.uid == context.Client.GameAccount.character_identifier)
            {
                context.Client.Bot.Position = msg.loc;
                Console.WriteLine("Our character spawned at {0}, {1}, {2}!", msg.loc.x, msg.loc.y, msg.loc.z);
            }
            else
            {
                Console.WriteLine("User {0} spawned: {1} at {2}, {3}, {4} with mount {5}!", msg.nickname, msg.uid, msg.loc.x, msg.loc.y, msg.loc.z, msg.vehicle_id);

                if (!context.Client.Bot.CharacterIds.ContainsKey(msg.uid))
                {
                    context.Client.Bot.CharacterIds.Add(msg.uid, msg.nickname);
                }
            }
        }

        public static void GAME_CLIENT_APPEAR_NPC(GameContext context, byte[] protobuffer)
        {
            GAME_CLIENT_APPEAR_NPC msg = Protobuf.ProtoDeserialize<GAME_CLIENT_APPEAR_NPC>(protobuffer);
                   
            bool isDuplicate = Entity.IsDuplicate(msg.uid, context.Client.Bot.EntityList);

            if (!isDuplicate)
            {
                Entity e = new Entity(msg.uid, msg.type, msg.classid, msg.loc, msg.state, (uint)msg.hp, msg.zone_uid, msg.move_speed ); //todo: make better constructors

                e.zone_uid = msg.zone_uid;
                e.hp = (uint)msg.hp;
                e.classid = msg.classid;
  
                context.Client.Bot.EntityList.Add(e);
            }

            if(msg.uid == context.Client.GameAccount.character_identifier)
            {
                context.Client.Bot.PlayerStats.CurrentHP = (uint)msg.hp;
            }

            Console.WriteLine("Monster/NPC Spawned in area: {0} at ({1},{2},{3}) with {4} HP, BattleState={5}", msg.uid, msg.dest_pos.x, msg.dest_pos.y, msg.dest_pos.z, msg.hp, msg.battle_state);
        }

        //82 3E 00 00 00 00 00 00 00 00 00 01 08 02 10 E2 02 18 D2 AA EE 02 20 01 28 AE 86 C0 C9 07 32 0F 0D 90 27 96 43 15 4D 33 66 46 1D B8 FB 02 44 38 96 01 40 D8 0B 48 01 50 C8 01 90 01 E3 F5 96 D1 8E 31 
        public static void GAME_CLIENT_STRUCK(GameContext context, byte[] protobuf)
        {
            GAME_CLIENT_STRUCK msg = Protobuf.ProtoDeserialize<GAME_CLIENT_STRUCK>(protobuf);

            if (msg.uid == context.Client.GameAccount.character_identifier)
            {
                uint lostHP = context.Client.Bot.PlayerStats.CurrentHP - msg.hp;
                context.Client.Bot.PlayerStats.CurrentHP = msg.hp;
                Console.WriteLine("Actor {0} hit us for {1} damage ({2} hp left)!", msg.attacker, lostHP, context.Client.Bot.PlayerStats.CurrentHP);

                if(context.Client.Bot.PlayerStats.CurrentHP <= (context.Client.Bot.PlayerStats.MaxHP /2)) //50% or less use potion
                {
                    context.Client.Bot.Potions.UseHPPotion(context.Client);
                }

            }
            else if(msg.uid == context.Client.Bot.CurrentlyAttacking && msg.attacker == context.Client.GameAccount.character_identifier)
            {     
                Console.WriteLine("We hit monster ({0}) for {1} damage!", msg.uid, msg.damage);
                context.Client.UIMessages.Enqueue("Hit monster " + Convert.ToString(msg.uid) + " for " + Convert.ToString(msg.damage) + " damage.");
            }
        }
        public static void GAME_CLIENT_ATTACK(GameContext context, byte[] protobuf)
        {
            GAME_CLIENT_ATTACK msg = Protobuf.ProtoDeserialize<GAME_CLIENT_ATTACK>(protobuf);

            if (msg.uid == context.Client.GameAccount.character_identifier)
            {
                if(msg.targets != null)
                {
                    Console.WriteLine("Our player attacked {0} with skill {1}!", msg.targets[0].targetid, msg.skill);

                    foreach (Entity e in context.Client.Bot.EntityList)
                    {
                        if (e.id == msg.targets[0].targetid)
                        {
                            context.Client.Bot.CurrentlyAttacking = e.id;
                        }
                    }
                }
            }
            else
            {
                if(msg.targets != null)
                    Console.WriteLine("Entity {0} attacked {1} with skill {2}!", msg.uid, msg.targets[0].targetid, msg.skill);
            }
        }
        
        public static void GAME_CLIENT_ATTACK_NPC(GameContext context, byte[] protobuf) //GAME_CLIENT_ATTACK_NPC
        {
            GAME_CLIENT_ATTACK_NPC msg = Protobuf.ProtoDeserialize<GAME_CLIENT_ATTACK_NPC>(protobuf);

            if(msg.target_uid == context.Client.GameAccount.character_identifier)
            {
                Console.WriteLine("Entity {0} attacked us!", msg.target_uid);
                //context.Client.Bot.UnderAttack = true;
            }    
        }
        
        public static void GAME_CLIENT_PAINTING_EVENT_PROCESS(GameContext context, byte[] protobuf)
        {
            GAME_CLIENT_PAINTING_EVENT_PROCESS msg = Protobuf.ProtoDeserialize<GAME_CLIENT_PAINTING_EVENT_PROCESS>(protobuf);
            Console.WriteLine("Painting event response: result {0}", msg.result);

            if(msg.reward_item_info != null)
            {
                foreach(_simple_item_info item in msg.reward_item_info)
                {
                    Console.WriteLine("Got reward item: {0} x{1}", item.itemindex, item.itemcount);
                } //todo: add to inventory
            }
        }

        public static void GAME_CLIENT_SYNC_REWARD_BATTLE_PASS(GameContext context, byte[] protobuf)
        {
            GAME_CLIENT_SYNC_REWARD_BATTLE_PASS msg = Protobuf.ProtoDeserialize<GAME_CLIENT_SYNC_REWARD_BATTLE_PASS>(protobuf);

        }

        public static void GAME_CLIENT_REWARD_BATTLE_PASS_LIST_RESULT(GameContext context, byte[] protobuf)
        {
            GAME_CLIENT_REWARD_BATTLE_PASS_LIST_RESULT msg = Protobuf.ProtoDeserialize<GAME_CLIENT_REWARD_BATTLE_PASS_LIST_RESULT>(protobuf);

            if(msg.success_all)
            {
                Console.WriteLine("Successfully collected event reward!");
            }
        }
        
        public static void GAME_CLIENT_EVENT_PROGRESS(GameContext context, byte[] protobuf)
        {
            GAME_CLIENT_EVENT_PROGRESS msg = Protobuf.ProtoDeserialize<GAME_CLIENT_EVENT_PROGRESS>(protobuf);

            if(msg.result == 0)
            {
                if(msg.reward_item_info != null)
                {
                    foreach(_simple_item_info item in msg.reward_item_info)
                    {
                        Console.WriteLine("Reward item: {0}, count {1}", item.itemindex, item.itemcount);
                    }
                }
            }
            else
            {
                Console.WriteLine("GAME_CLIENT_EVENT_PROGRESS: {0}", msg.result);
            }
        }

        public static void GAME_CLIENT_USER_EVENT_INFO(GameContext context, byte[] protobuf)
        {
            GAME_CLIENT_USER_EVENT_INFO msg = Protobuf.ProtoDeserialize<GAME_CLIENT_USER_EVENT_INFO>(protobuf);

            Console.WriteLine("first_access: {0}", msg.daily_first_access);

            foreach (_user_event_info event_info in msg.event_info_list)
            {
                Console.WriteLine("Event: {0}, step: {1}", event_info.event_id, event_info.event_step);
            }
        }

        public static void GAME_CLIENT_NOTIFY_ITEM_GAIN(GameContext context, byte[] protobuf) //GAME_CLIENT_ATTACK_NPC
        {
            GAME_CLIENT_NOTIFY_ITEM_GAIN msg = Protobuf.ProtoDeserialize<GAME_CLIENT_NOTIFY_ITEM_GAIN>(protobuf);       
            Console.WriteLine("{0} gained item {1}, gain type: {2}", msg.user_name, msg.item_tid, msg.gain_type);
        }
        public static void GAME_CLIENT_SKILL_ERROR(GameContext context, byte[] protobuf) //GAME_CLIENT_ATTACK_NPC
        {
            GAME_CLIENT_SKILL_ERROR msg = Protobuf.ProtoDeserialize<GAME_CLIENT_SKILL_ERROR>(protobuf);                   
            Console.WriteLine("[ERROR] Skill error: {0} using {1}", msg.result, msg.skill_id);           

            if(msg.result == 21000013) //not enough mana
            {
                context.Client.Bot.Potions.UseMPPotion(context.Client);
            }
        }
        
        public static void GAME_CLIENT_GACHA_PULL_EVENT(GameContext context, byte[] protobuf)
        {
            GAME_CLIENT_GACHA_PULL_EVENT msg = Protobuf.ProtoDeserialize<GAME_CLIENT_GACHA_PULL_EVENT>(protobuf);

            Console.WriteLine("GAME_CLIENT_GACHA_PULL: result {0}", msg.result);

            if (msg.gacha_items != null)
            {
                foreach(_simple_item_info item in msg.gacha_items)
                {
                    Console.WriteLine("Pulled gacha item: {0}, count {1}", item.itemindex, item.itemcount);
                }
            }
        }

        public static void GAME_CLIENT_PK_TRACEABLILITY_CHECK(GameContext context, byte[] protobuf)
        {
            GAME_CLIENT_PK_TRACEABLILITY_CHECK msg = Protobuf.ProtoDeserialize<GAME_CLIENT_PK_TRACEABLILITY_CHECK>(protobuf);

            Console.WriteLine("GAME_CLIENT_PK_TRACEABLILITY_CHECK: result {0}", msg.result);

            if (msg.result == 0)
            {
                Console.WriteLine("Target stage: {0}, Target Position: {1}", msg.target_stageid, msg.target_position); 
            }
        }
    
        public static void GAME_CLIENT_ITEM_COMPOSE_POINT_REWARD(GameContext context, byte[] protobuf)
        {
            GAME_CLIENT_ITEM_COMPOSE_POINT_REWARD msg = Protobuf.ProtoDeserialize<GAME_CLIENT_ITEM_COMPOSE_POINT_REWARD>(protobuf);

            Console.WriteLine("GAME_CLIENT_ITEM_COMPOSE_POINT_REWARD: result {0}", msg.result);

            if (msg.update_items != null)
            {
                foreach (_character_inven_item item in msg.update_items)
                {
                    Console.WriteLine("Pulled gacha item: {0}, count {1}", item.item_index, item.stack_count);
                }
            }

            if (msg.compse_result_data != null)
            {
                Console.WriteLine("compse_result_data.compse_result: {0}", msg.compse_result_data.compse_result); //b5 ea 00 00 00 00 00 00 00 00 00 00 0A 01 0B
            }
        }

        public static void WORLD_CLIENT_UNSEALING_SUPPORT_REGISTER(GameContext context, byte[] protobuf)
        {
            WORLD_CLIENT_UNSEALING_SUPPORT_REGISTER msg = Protobuf.ProtoDeserialize<WORLD_CLIENT_UNSEALING_SUPPORT_REGISTER>(protobuf);
            Console.WriteLine("WORLD_CLIENT_UNSEALING_SUPPORT_REGISTER: result {0}, slot {1}, type {2}", msg.result, msg.slot, msg.support_type);
        }

        public static void WORLD_CLIENT_UNSEALING_SUPPORT_REGISTER_NOTICE(GameContext context, byte[] protobuf)
        {
            WORLD_CLIENT_UNSEALING_SUPPORT_REGISTER_NOTICE msg = Protobuf.ProtoDeserialize<WORLD_CLIENT_UNSEALING_SUPPORT_REGISTER_NOTICE>(protobuf);

            if (msg.unsealing_support_data != null)
            {
                Console.WriteLine("unsealing_user_uid: {0}, item_index {1}, slot {2}, support_count {3}", msg.unsealing_support_data.unsealing_user_uid, msg.unsealing_support_data.item_index, msg.unsealing_support_data.slot, msg.unsealing_support_data.support_count);
            }
        }

        public static void GAME_CLIENT_UNSEALING_REGISTER(GameContext context, byte[] protobuf)
        {
            GAME_CLIENT_UNSEALING_REGISTER msg = Protobuf.ProtoDeserialize<GAME_CLIENT_UNSEALING_REGISTER>(protobuf);
            
            if(msg.result == 0)
            {
                if(msg.unsealing_info != null)
                {
                    Console.WriteLine("GAME_CLIENT_UNSEALING_REGISTER item_index {0}, slot {1}, support_count {2}", msg.unsealing_info.item_index, msg.unsealing_info.slot, msg.unsealing_info.support_count);
                }

                if (msg.update_items != null)
                {
                    foreach (var item in msg.update_items)
                    {
                        Console.WriteLine("Got unsealing box item: {0}, count {1}", item.itemuid, item.itemcount);
                    }
                }
            }
        }
        

        public static void GAME_CLIENT_UNSEALING_REGISTER_COMPLETE(GameContext context, byte[] protobuf)
        {
            GAME_CLIENT_UNSEALING_REGISTER_COMPLETE msg = Protobuf.ProtoDeserialize<GAME_CLIENT_UNSEALING_REGISTER_COMPLETE>(protobuf);
            Console.WriteLine("GAME_CLIENT_UNSEALING_REGISTER_COMPLETE: result {0}, slot {1}", msg.result, msg.unsealing_slot);
        }     

        public static void GAME_CLIENT_UNSEALING_GET(GameContext context, byte[] protobuf)
        {
            GAME_CLIENT_UNSEALING_GET msg = Protobuf.ProtoDeserialize<GAME_CLIENT_UNSEALING_GET>(protobuf);

            Console.WriteLine("GAME_CLIENT_UNSEALING_GET: result {0}", msg.result);

            if (msg.result == 0)
            {
                if(msg.update_items != null)
                {
                    foreach (var item in msg.update_items)
                    {
                        Console.WriteLine("Got unsealing box reward: {0}, count {1}", item.item_index, item.stack_count);
                    }
                }
            }
        }

        public static void GAME_CLIENT_UNSEALING_GET_ALL(GameContext context, byte[] protobuf)
        {
            GAME_CLIENT_UNSEALING_GET msg = Protobuf.ProtoDeserialize<GAME_CLIENT_UNSEALING_GET>(protobuf);

            Console.WriteLine("GAME_CLIENT_UNSEALING_GET_ALL: result {0}", msg.result);

            if (msg.result == 0)
            {
                if (msg.update_items != null)
                {
                    foreach (var item in msg.update_items)
                    {
                        Console.WriteLine("Got unsealing box reward: {0}, count {1}", item.item_index, item.stack_count);
                    }
                }
            }
        }
        
        public static void GAME_CLIENT_GACHA_PULL(GameContext context, byte[] protobuf)
        {
            GAME_CLIENT_GACHA_PULL msg = Protobuf.ProtoDeserialize<GAME_CLIENT_GACHA_PULL>(protobuf);

            Console.WriteLine("GAME_CLIENT_GACHA_PULL_EVENT: result {0}", msg.result);

            if (msg.gacha_items != null)
            {
                foreach (_simple_item_info item in msg.gacha_items)
                {
                    Console.WriteLine("Pulled gacha item: {0}, count {1}", item.itemindex, item.itemcount);
                }

            }
        }
        
        public static void GAME_CLIENT_MAIL_LIST_DATA(GameContext context, byte[] protobuf)
        {
            GAME_CLIENT_MAIL_LIST_DATA msg = Protobuf.ProtoDeserialize<GAME_CLIENT_MAIL_LIST_DATA>(protobuf);

            Console.WriteLine("Received mail data!");

            if (msg.mail_info != null)
            {
                foreach (_mail_data mail in msg.mail_info)
                {
                    Console.WriteLine("Found mail data: {0}, {1}, from {2}", mail.title, mail.contents, mail.sender_nick_name);

                    if(mail.gift_item != null)
                    {
                        foreach(_simple_item_info gift in mail.gift_item)
                        {
                            Console.WriteLine("Found gift in mail: {0} x{1}", gift.itemindex, gift.itemcount);
                        }

                        if(!mail.attach_get_item)
                            MessageWrapper.CLIENT_GAME_MAIL_RECV_GIFT(context.Client, mail.mail_uid);
                    }
                }
            }
        }
        
        public static void GAME_CLIENT_CHANGE_INFO(GameContext context, byte[] protobuf) //GAME_CLIENT_ATTACK_NPC
        {
            GAME_CLIENT_CHANGE_INFO msg = Protobuf.ProtoDeserialize<GAME_CLIENT_CHANGE_INFO>(protobuf);

            if (msg.uid == context.Client.GameAccount.character_identifier)
            {
                context.Client.GameAccount.character_identifier = msg.uid;
                context.Client.Bot.PlayerStats.CurrentHP = msg.hp;
                context.Client.Bot.PlayerStats.MaxHP = msg.max_hp;
                
                //context.Client.Bot.MaxMana = msg.max_mana;
            }

            foreach(Entity e in context.Client.Bot.EntityList) //need to modify list
            {
                if(e.id == msg.uid)
                {
                    e.type = msg.type;
                    e.hp = msg.hp;
                    e.max_hp = msg.max_hp;
                    e.mana = msg.mana;
                    e.max_mp = msg.max_mana;
                }
            }
        }
     
        public static void CLIENT_GAME_CHARACTER_ACHIEVEMENT_CLEAR_REWARD(GameContext context, byte[] protobuf)
        {
            Console.WriteLine("Cleared achievement!");
            CLIENT_GAME_CHARACTER_ACHIEVEMENT_CLEAR_REWARD msg = Protobuf.ProtoDeserialize<CLIENT_GAME_CHARACTER_ACHIEVEMENT_CLEAR_REWARD>(protobuf);
        }
  
        public static void GAME_CLIENT_PARTY_INVITE_REQUEST(GameContext context, byte[] protobuf)
        {
            GAME_CLIENT_PARTY_INVITE_REQUEST msg = Protobuf.ProtoDeserialize<GAME_CLIENT_PARTY_INVITE_REQUEST>(protobuf);

            Console.WriteLine("Got party invitation from {0} (uid {1})!", msg.request_user_name, msg.request_user_uid);

            if (context.Client.Bot.AutoJoinParties)
            {        
                if(!context.Client.Bot.InParty)
                {
                    context.Client.Bot.InParty = true;
                    context.Client.m_session.SendPacket(Factory.CLIENT_GAME_PARTY_INVITE_REPLY(context.Client.GameAccount.character_identifier, msg.request_user_uid, msg.request_party_uid, true ));
                    context.Client.Bot.PartyUID = msg.request_party_uid;
                }
            }
        }

        public static void GAME_CLIENT_SKILL_NOT_EXIST_TARGET_LIST(GameContext context, byte[] protobuffer) //entities load before this is called
        {
            GAME_CLIENT_SKILL_NOT_EXIST_TARGET_LIST msg = Protobuf.ProtoDeserialize<GAME_CLIENT_SKILL_NOT_EXIST_TARGET_LIST>(protobuffer);

            if(msg.targets != null)
            {
                foreach(_attack_target_info target in msg.targets)
                {
                    if(target.targetid == context.Client.Bot.CurrentlyAttacking)
                    {
                        context.Client.UIMessages.Enqueue("Current target was killed, moving on..");
                        Console.WriteLine("Current target was killed, moving on..");
                        context.Client.Bot.CurrentlyAttacking = 0;
                    }
                }
            }
        }

        public static void GAME_CLIENT_SYNC_PLAY_DATA(GameContext context, byte[] protobuffer) //entities load before this is called
        {
            GAME_CLIENT_SYNC_PLAY_DATA msg = Protobuf.ProtoDeserialize<GAME_CLIENT_SYNC_PLAY_DATA>(protobuffer);

        }

        public static void GAME_CLIENT_CHARACTER_ENERGY_POINT_DATA(GameContext context, byte[] protobuffer)
        {
            GAME_CLIENT_CHARACTER_ENERGY_POINT_DATA msg = Protobuf.ProtoDeserialize<GAME_CLIENT_CHARACTER_ENERGY_POINT_DATA>(protobuffer);

            context.Client.GameAccount.Energy = msg.energyPoint;
            Console.WriteLine("Character Energy: {0}", msg.energyPoint);
        }

        public static void GAME_CLIENT_MEDITATION_ADD_ENERGYPOINT(GameContext context, byte[] protobuffer)
        {
            GAME_CLIENT_MEDITATION_ADD_ENERGYPOINT msg = Protobuf.ProtoDeserialize<GAME_CLIENT_MEDITATION_ADD_ENERGYPOINT>(protobuffer);

            context.Client.GameAccount.Energy += msg.addEnergyPoint;
            Console.WriteLine("Collected Energy: {0}, total: {1}", msg.addEnergyPoint, context.Client.GameAccount.Energy);
            context.Client.UIMessages.Enqueue("Collected " + Convert.ToString(msg.addEnergyPoint) + " Energy!");
        }
        
        public static void GAME_CLIENT_END_LOADING(GameContext context, byte[] protobuffer) //entities load before this is called
        {
            context.Client.UIMessages.Enqueue("[INFO] Spawned in map! Fetching additional UI and character info...");
            
            Thread t = new Thread(new ThreadStart(context.HandleReadyInGame));
            t.Start();

            context.Client.ReadyInGame = true;

            if (context.Client.Bot.AutoAttacking)
            {
                if (context.Client.Bot.attack_worker == null)
                {                  
                    context.Client.Bot.attack_worker = new Thread(new ThreadStart(context.Client.Bot.AttackMonstersWithinRange));
                    context.Client.Bot.attack_worker.Start();
                }
                else
                {
                    context.Client.Bot.attack_worker.Abort();
                    context.Client.Bot.attack_worker = new Thread(new ThreadStart(context.Client.Bot.AttackMonstersWithinRange));
                    context.Client.Bot.attack_worker.Start();
                }
            }

            if(context.Client.Bot.AutoGathering)
            {
                context.Client.Bot.CurrentlyCollecting = false;

                if (context.Client.Bot.worker != null)
                {
                    context.Client.Bot.worker.Abort();
                    context.Client.Bot.worker = null;
                }

                context.Client.Bot.worker = new Thread(new ThreadStart(context.Client.Bot.Gather));
                context.Client.Bot.worker.Start();
            }
        }

        public static void GAME_CLIENT_DROP_ITEM(GameContext context, byte[] protobuffer) //entities load before this is called
        {
            GAME_CLIENT_DROP_ITEM msg = Protobuf.ProtoDeserialize<GAME_CLIENT_DROP_ITEM>(protobuffer);

            if(msg.dropitems != null)
            {
                foreach(_character_inven_item item in msg.dropitems)
                {
                    Console.WriteLine("Acquired dropped item {0} with count: {1}!", item.item_index, item.stack_count);
                    context.Client.UIMessages.Enqueue("Got item " + Convert.ToString(item.item_index) + " x" + Convert.ToString(item.stack_count));
                }
            }

        }

        public static void GAME_CLIENT_GAIN_EXP(GameContext context, byte[] protobuffer) //entities load before this is called
        {
            GAME_CLIENT_GAIN_EXP msg = Protobuf.ProtoDeserialize<GAME_CLIENT_GAIN_EXP>(protobuffer);

            Console.WriteLine("Gained {0} experience (+{1})!", msg.exp, msg.exp_booster_value);
            context.Client.UIMessages.Enqueue("Gained " + Convert.ToString(msg.exp) + " experience (+" + Convert.ToString(msg.exp_booster_value) + ")");
        }

       
        public static void GAME_CLIENT_CHARACTER_SKILL(GameContext context, byte[] protobuffer)
        {
            GAME_CLIENT_CHARACTER_SKILL msg = Protobuf.ProtoDeserialize<GAME_CLIENT_CHARACTER_SKILL>(protobuffer);

            if(msg.skillinfos != null)
            {
                foreach(_character_skill skill in msg.skillinfos)
                {
                    Console.WriteLine("Detected skill {0} with level {1}!", skill.SkillIndex, skill.SkillLevel);

                    if (!context.Client.Bot.SkillList.ContainsKey(skill.SkillIndex))
                    {
                        context.Client.Bot.SkillList.Add(skill.SkillIndex, skill.SkillLevel);
                    }
                }
            }
        }

        public static void GAME_CLIENT_START_CASTING(GameContext context, byte[] protobuffer)
        {
            GAME_CLIENT_START_CASTING msg = Protobuf.ProtoDeserialize<GAME_CLIENT_START_CASTING>(protobuffer);

            Console.WriteLine("HandleStartCasting called on {0} from {1}: {2} milliseconds remaining, at {3},{4},{5}. Casting type: {6},{7}", msg.casting_target_uid, msg.casting_user_uid, msg.casting_time, msg.position.x, msg.position.y, msg.position.z, msg.casting_type, msg.casting_sub_type);

            if (msg.casting_user_uid == context.Client.GameAccount.character_identifier) //WE are casting
            {
                context.Client.Bot.CurrentlyCollecting = true;
                context.Client.Bot.CurrentObjectGathering = msg.casting_target_uid;
                context.Client.UIMessages.Enqueue("Currently gathering object: " + Convert.ToString(context.Client.Bot.CurrentObjectGathering));
            }     
        }

        public static void GAME_CLIENT_CASTING_SUCCESS(GameContext context, byte[] protobuffer)
        {
            Console.WriteLine("HandleCastingSuccess called");

            GAME_CLIENT_CASTING_SUCCESS msg = Protobuf.ProtoDeserialize<GAME_CLIENT_CASTING_SUCCESS>(protobuffer);
            
            if (msg.uid == context.Client.GameAccount.character_identifier) //WE are casting
            {
                context.Client.Bot.CurrentlyCollecting = true;
                context.Client.Bot.CurrentObjectGathering = msg.casting_target_uid;
                context.Client.Bot.ObjectsGathered += 1;
                context.Client.UIMessages.Enqueue("Successfully gathered object: " + Convert.ToString(context.Client.Bot.CurrentObjectGathering));
            }
        }

        public static void GAME_CLIENT_CANCEL_CASTING(GameContext context, byte[] protobuffer)
        {
            GAME_CLIENT_CANCEL_CASTING msg = Protobuf.ProtoDeserialize<GAME_CLIENT_CANCEL_CASTING>(protobuffer);
           
            if(msg.casting_user_uid == context.Client.GameAccount.character_identifier)
            {
                Console.WriteLine("Stopped mining/gathering!");
                context.Client.UIMessages.Enqueue("Stopped mining/gathering!");
            }
        }

        public static void GAME_CLIENT_BROADCAST_DIE_USER(GameContext context, byte[] protobuffer) //GAME_CLIENT_BROADCAST_DIE_USER
        {
            GAME_CLIENT_BROADCAST_DIE_USER msg = Protobuf.ProtoDeserialize<GAME_CLIENT_BROADCAST_DIE_USER>(protobuffer);

            if (msg.uid == context.Client.GameAccount.character_identifier)
            {
                Console.WriteLine("You have died! Need to wait and respawn...");
                context.Client.Bot.IsDead = true;
            }
            else
            {
                Console.WriteLine("Player {0} died!", msg.uid);
            }           
        }

        public static void GAME_CLIENT_DIE(GameContext context, byte[] protobuffer)
        {
            GAME_CLIENT_DIE msg = Protobuf.ProtoDeserialize<GAME_CLIENT_DIE>(protobuffer);
            
            context.Client.Bot.IsDead = true;
            context.Client.Bot.LastAlivePosition = context.Client.Bot.Position;

            Console.WriteLine("[WARNING] Player died from: {0}, Reason: {1}", msg.attacker_name, msg.die_reason);
            context.Client.UIMessages.Enqueue("[WARNING] Our player has died. Attempting to revive...");

            context.Client.m_session.SendThreadedPacket(Factory.CLIENT_GAME_REVIVAL(context.Client.GameAccount.character_identifier, 1), (int)msg.revival_delay_ms + 10000);
        }
        
        public static void GAME_CLIENT_CASTING_FAIL(GameContext context, byte[] protobuffer) //GAME_CLIENT_CASTING_FAIL
        {
            GAME_CLIENT_CASTING_FAIL msg = Protobuf.ProtoDeserialize<GAME_CLIENT_CASTING_FAIL>(protobuffer);

            if (msg.casting_user_uid == context.Client.GameAccount.character_identifier && context.Client.Bot.AutoGathering) //WE are casting
            {
                Console.WriteLine("Failed to start gathering/mining: {0}", msg.fail_reason_arg);
                context.Client.UIMessages.Enqueue("Failed to gather object: " + Convert.ToString(msg.casting_target_uid)); 
                context.Client.Bot.CurrentlyCollecting = false;
                context.Client.Bot.CurrentObjectGathering = 0;         
            }
            else if (msg.casting_user_uid == context.Client.GameAccount.character_identifier && context.Client.Bot.AutoGathering) //WE are casting
            {
                Console.WriteLine("Failed to cast: {0}", msg.fail_reason_arg);
                context.Client.UIMessages.Enqueue("Failed to cast: " + Convert.ToString(msg.casting_target_uid));
                context.Client.Bot.CurrentlyCollecting = false;
                context.Client.Bot.CurrentObjectGathering = 0;
            }
        }

        public static void GAME_CLIENT_ACTIVATE_OBJECT_REWARD(GameContext context, byte[] protobuffer)
        {     
            GAME_CLIENT_ACTIVATE_OBJECT_REWARD msg = Protobuf.ProtoDeserialize<GAME_CLIENT_ACTIVATE_OBJECT_REWARD>(protobuffer);
            Console.WriteLine("Retrieved items: {0}", msg.object_id);
        }

        public static void GAME_CLIENT_APPEAR_OBJECT(GameContext context, byte[] protobuffer)
        {
            GAME_CLIENT_APPEAR_OBJECT msg = Protobuf.ProtoDeserialize<GAME_CLIENT_APPEAR_OBJECT>(protobuffer);

            Console.WriteLine("Some object ({0}) spawned at {1},{2},{3}: with {4}/{5} counts ({6}), State: {7}", msg.uid, msg.loc.x, msg.loc.y, msg.loc.z, msg.remaining_use_cnt, msg.max_use_cnt, msg.object_id, msg.object_state);//, objectId);

            bool isDuplicate = false;

            foreach(Entity ent in context.Client.Bot.EntityList)
            {
                if(ent.id == msg.uid)
                    isDuplicate = true;
            }

            if(!isDuplicate) //add to object list if not duplicate
            {
                Entity e = new Entity(msg.uid, msg.object_id, msg.loc, msg.remaining_use_cnt, msg.max_use_cnt, msg.object_state);
                e.state = msg.object_state;
                e.hp = 0;
                context.Client.Bot.EntityList.Add(e);
            }

            if (context.Client.Bot.AutoGathering)
            {
                bool foundId = false;

                foreach(KeyValuePair<long, int> pair in context.Client.Bot.DesiredGatheringIds)
                {
                    if(pair.Key == msg.object_id)
                    {
                        foundId = true;
                    }
                }

                //if(!context.Client.Bot.CurrentlyCollecting && msg.remaining_use_cnt > 0 && foundId)
                //{
                //    if (context.Client.Bot == null)
                //        context.Client.Bot.CurrentObjectGathering = msg.uid;

                //    _vector3 v = new _vector3();
                //    v.x = 0.05f;
                //    v.y = 0.01f;
                //    context.Client.Bot.Position = msg.loc;
                //    Console.WriteLine("Found mining vein ({0}), type {1}! Attempting to teleport to object and collect..", msg.uid, msg.object_id);

                //    context.Client.Bot.Teleport(context.Client.Bot.Position, msg.loc);
                
                //    context.Client.m_session.SendPacket(Factory.CLIENT_GAME_START_CASTING(context.Client.GameAccount.character_identifier, msg.uid, 1, 0, true));

                //    context.Client.Bot.FoundCollectableObject = true;
                //    context.Client.Bot.CurrentlyCollecting = true;
                //}
            }
        }


        public static void WORLD_CLIENT_DOMINION_TAX_WITHDRAWAL(GameContext context, byte[] protobuffer)
        {
            WORLD_CLIENT_DOMINION_TAX_WITHDRAWAL msg = Protobuf.ProtoDeserialize<WORLD_CLIENT_DOMINION_TAX_WITHDRAWAL>(protobuffer);
            Console.WriteLine("WORLD_CLIENT_DOMINION_TAX_WITHDRAWAL {0}, dominion tid {1}", msg.result, msg.dominion_tid);

            if (msg.result == 0)
            {
                Console.WriteLine("Withdrew {0} gold, {1} coin, tid {2} ", msg.withdrawal_gold, msg.withdrawal_coin, msg.dominion_tid);
            }
        }

        public static void GAME_CLIENT_GUILD_DONATION(GameContext context, byte[] protobuffer)
        {
            GAME_CLIENT_GUILD_DONATION msg = Protobuf.ProtoDeserialize<GAME_CLIENT_GUILD_DONATION>(protobuffer);

            if (msg.result == 0)
            {
                Console.WriteLine("GAME_CLIENT_GUILD_DONATION success ");
            }
            else
            {
                Console.WriteLine("GAME_CLIENT_GUILD_DONATION failure ");
            }
        }
        public static void GAME_CLIENT_EQUIP_COSTUME(GameContext context, byte[] protobuffer)
        {
            GAME_CLIENT_EQUIP_COSTUME msg = Protobuf.ProtoDeserialize<GAME_CLIENT_EQUIP_COSTUME>(protobuffer);

            if (msg.result == 0)
            {
                Console.WriteLine("GAME_CLIENT_EQUIP_COSTUME success: {0} ", msg.equip_costume_id);
            }
            else
            {
                Console.WriteLine("GAME_CLIENT_EQUIP_COSTUME failure ");
            }
        }


        public static void GAME_CLIENT_RECONNECT_SYNC(GameContext context, byte[] protobuffer)
        {
            GAME_CLIENT_RECONNECT_SYNC msg = Protobuf.ProtoDeserialize<GAME_CLIENT_RECONNECT_SYNC>(protobuffer);

            if(msg != null)
            {
                context.Client.GameAccount.StageID = msg.stage_id;
                context.Client.GameAccount.Zone = msg.zone_uid;
                context.Client.Bot.PlayerStats.CurrentHP = msg.hp;
                context.Client.Bot.PlayerStats.CurrentMana = msg.mana;
                context.Client.Bot.PlayerStats.Vigor = msg.vigor;
            }
        }
        
        public static void GAME_CLIENT_OBJECT_UPDATE_USE_COUNT(GameContext context, byte[] protobuffer)
        {
            GAME_CLIENT_OBJECT_UPDATE_USE_COUNT msg = Protobuf.ProtoDeserialize<GAME_CLIENT_OBJECT_UPDATE_USE_COUNT>(protobuffer);

            Console.WriteLine("Got HandleUpdateObjectUseCount: {0} has {1} uses left.", msg.object_uid, msg.remaining_use_count);

            if (context.Client.Bot.EntityList != null)
            {
                Entity _toChange = null;
                foreach (Entity e in context.Client.Bot.EntityList)
                {
                    if (e.id == msg.object_uid)
                    {
                        _toChange = e;
                    }
                }

                if (_toChange != null)
                {
                    _toChange.UsageCountsLeft = msg.remaining_use_count;
                }

                if(context.Client.Bot.AutoGathering)
                {
                    if(context.Client.Bot.CurrentObjectGathering == msg.object_uid)
                        context.Client.UIMessages.Enqueue("Object " + Convert.ToString(msg.object_uid) + " has " + Convert.ToString(msg.remaining_use_count) + " usages remaining.");
                }
            }                
        }

        public static void GAME_CLIENT_DISAPPEAR_ENTITY(GameContext context, byte[] protobuffer)
        {
            GAME_CLIENT_DISAPPEAR_ENTITY msg = Protobuf.ProtoDeserialize<GAME_CLIENT_DISAPPEAR_ENTITY>(protobuffer);
   
                if (context.Client.Bot.EntityList != null)
                {
                    Entity _toRemove = null;
                    foreach (Entity e in context.Client.Bot.EntityList.ToList())
                    {
                        if (e.id == msg.uid)
                        {
                            _toRemove = e;
                        }
                    }

                    if(_toRemove != null)
                        context.Client.Bot.EntityList.Remove(_toRemove);

                    //Console.WriteLine("Got HandleDisappearingEntity: {0}", msg.uid);

                    ulong id = msg.uid;

                    if (id == context.Client.Bot.CurrentObjectGathering && context.Client.Bot.CurrentlyCollecting)
                    {
                        Console.WriteLine("Entity we were collecting disappeared, need to find new one: {0}", msg.uid);
                        context.Client.Bot.CurrentlyCollecting = false;
                        context.Client.Bot.CurrentObjectGathering = 0;
                    }
                }                      
        }

        public static void GAME_CLIENT_DISAPPEAR_ENTITY_LIST(GameContext context, byte[] protobuffer)
        {
            GAME_CLIENT_DISAPPEAR_ENTITY_LIST msg = Protobuf.ProtoDeserialize<GAME_CLIENT_DISAPPEAR_ENTITY_LIST>(protobuffer);

            if (context.Client.Bot.EntityList != null)
            {
                List<ulong> _toRemove = new List<ulong>(); //uids to remove

                if (msg.disappear_list != null)
                {
                    foreach (var e_disappear in msg.disappear_list.ToList())
                    {
                        _toRemove.Add(e_disappear.uid);
                    }
                }

                List<Entity> removing = new List<Entity>();

                foreach(Entity e in context.Client.Bot.EntityList.ToList())
                {
                    if(_toRemove.Contains(e.id))
                    {
                        removing.Add(e);
                    }
                }

                foreach(Entity remove in removing)
                {
                    context.Client.Bot.EntityList.Remove(remove);
                    Console.WriteLine("Deleted entity with ID {0} from list..", remove.id);
                }
            }
        }

        public static void GAME_CLIENT_VEHICLE_RIDE_EQUIP(GameContext context, byte[] protobuffer)
        {
            GAME_CLIENT_VEHICLE_RIDE_EQUIP msg = Protobuf.ProtoDeserialize<GAME_CLIENT_VEHICLE_RIDE_EQUIP>(protobuffer);
            Console.WriteLine("GAME_CLIENT_VEHICLE_RIDE_EQUIP {0}, {1}", msg.result, msg.vehicle_index);
            
            if (msg.result == 1)
            {
                Console.WriteLine("Changed to mount {0}", msg.vehicle_index);
            }
        }

        public static void GAME_CLIENT_CHARACTER_BATTLE_PASS_CLEAR_DATA(GameContext context, byte[] protobuffer)
        {
            GAME_CLIENT_CHARACTER_BATTLE_PASS_CLEAR_DATA msg = Protobuf.ProtoDeserialize<GAME_CLIENT_CHARACTER_BATTLE_PASS_CLEAR_DATA>(protobuffer);

            if(msg.character_battle_pass_complete_list != null)
                Console.WriteLine("GAME_CLIENT_CHARACTER_BATTLE_PASS_CLEAR_DATA: {0}", msg.character_battle_pass_complete_list[0].battle_pass_info_uid);
        }
        
        public static void GAME_CLIENT_STAT_CONTENTS_LIST(GameContext context, byte[] protobuffer)
        {
            GAME_CLIENT_STAT_CONTENTS_LIST msg = Protobuf.ProtoDeserialize<GAME_CLIENT_STAT_CONTENTS_LIST>(protobuffer);

            if (msg.stat_contents_list != null)
            {
                foreach(_stat_contents_info stat in msg.stat_contents_list)
                {
                    Console.WriteLine("Stat info: {0}, value {1}, contentsId {2}", stat.stat_id, stat.stat_value, stat.stat_contents_id);
                }
            }
        }

        public static void GAME_CLIENT_DUNGEON_SHOP_BUY(GameContext context, byte[] protobuffer)
        {
            GAME_CLIENT_DUNGEON_SHOP_BUY msg = Protobuf.ProtoDeserialize<GAME_CLIENT_DUNGEON_SHOP_BUY>(protobuffer);

            if (msg.result != 0)
                Console.WriteLine("GAME_CLIENT_DUNGEON_SHOP_BUY failed: {0}", msg.result);

            if (msg.update_items != null)
            {
                foreach (var item in msg.update_items)
                {
                    Console.WriteLine("Got item from dungeon shop: {0} x{1}", item.item_index, item.stack_count);
                }
            }
        }
        
        public static void GAME_CLIENT_GET_RANKING_REWARD(GameContext context, byte[] protobuffer)
        {
            GAME_CLIENT_GET_RANKING_REWARD msg = Protobuf.ProtoDeserialize<GAME_CLIENT_GET_RANKING_REWARD>(protobuffer);
            Console.WriteLine("GAME_CLIENT_GET_RANKING_REWARD: {0}", msg.result);

            if (msg.reward_item_info != null)
            {
                foreach (var item in msg.reward_item_info)
                {
                    Console.WriteLine("Got item from dungeon shop: {0} x{1}", item.itemindex, item.itemcount);
                }
            }
        }


        public static void GAME_CLIENT_BOSS_SPAWN(GameContext context, byte[] protobuffer)
        {
            GAME_CLIENT_BOSS_SPAWN msg = Protobuf.ProtoDeserialize<GAME_CLIENT_BOSS_SPAWN>(protobuffer);
            Console.WriteLine("Boss Spawned: {0}", msg.boss_tid);
        }
        
        public static void GAME_CLIENT_UI_SHOP_BUYITEM(GameContext context, byte[] protobuffer)
        {
            GAME_CLIENT_UI_SHOP_BUYITEM msg = Protobuf.ProtoDeserialize<GAME_CLIENT_UI_SHOP_BUYITEM>(protobuffer);
            Console.WriteLine("GAME_CLIENT_UI_SHOP_BUYITEM result: {0}", msg.result);
        }

        public static void GAME_CLIENT_UI_SHOP_BUY(GameContext context, byte[] protobuffer)
        {
            GAME_CLIENT_UI_SHOP_BUY msg = Protobuf.ProtoDeserialize<GAME_CLIENT_UI_SHOP_BUY>(protobuffer);
            Console.WriteLine("GAME_CLIENT_UI_SHOP_BUY result: {0}", msg.result);
        }


        
        public static void GAME_CLIENT_EXPBOOSTER_SPEND_END(GameContext context, byte[] protobuffer)
        {
            GAME_CLIENT_EXPBOOSTER_SPEND_END msg = Protobuf.ProtoDeserialize<GAME_CLIENT_EXPBOOSTER_SPEND_END>(protobuffer);
            Console.WriteLine("Time left on exp booster: {0}", msg.exp_booster_left_time);
        }
        
        public static void GAME_CLIENT_NOTIFY_CREATE_PARTY(GameContext context, byte[] protobuffer)
        {
            GAME_CLIENT_NOTIFY_CREATE_PARTY msg = Protobuf.ProtoDeserialize<GAME_CLIENT_NOTIFY_CREATE_PARTY>(protobuffer);
            
            context.Client.Bot.CurrentPartyUID = msg.party_uid;
            
            Console.WriteLine("Created/Joined party: {0}", msg.party_uid);

            if (msg.total_party_info != null)
            {
                foreach(_party_member_info member in msg.total_party_info.party_member_infos)
                {
                    Console.WriteLine("Member in party: {0}, level {1}, class {2}, member_uid {3}", member.nickname, member.level, member.member_class, member.member_uid);
                }
            }
        }

        public static void HandleDisappearingEntityList()
        {
            Console.WriteLine("Got HandleDisappearingEntityList");
        }

        public static void GAME_CLIENT_WARP_READY(GameContext context, byte[] protobuffer)
        {
            GAME_CLIENT_WARP_READY msg = Protobuf.ProtoDeserialize<GAME_CLIENT_WARP_READY>(protobuffer);

            context.Client.GameAccount.Zone = msg.zone_unique;
            context.Client.Bot.Position = msg.loc;

            context.Client.Bot.CharacterIds.Clear(); //clear charname -> id list
            context.Client.Bot.EntityList.Clear(); //make sure this is okay here

            if (msg.is_same_stage_warp)
                context.Client.UIMessages.Enqueue("Warped into zone (same stage): " + Convert.ToString(msg.zone_unique));
            else
                context.Client.UIMessages.Enqueue("Warped into zone: " + Convert.ToString(msg.zone_unique));

            Console.WriteLine("Warped into zone {0}!", msg.zone_unique);

            context.Client.Bot.CurrentObjectGathering = 0;
            context.Client.Bot.FoundCollectableObject = false;
            context.Client.Bot.CurrentlyCollecting = false;

            context.Client.m_session.SendThreadedPacket(Factory.CLIENT_GAME_END_LOADING(), 1000);
        }

        public static void HandleUnknown(GameContext context, Reader packet)
        {
            int len = packet.ToArray().Length;

            //Console.WriteLine("Parsing unknown packet:");

            //for (int i = 0; i < len - 15; i++) //15 for header len
            //{
            //    Console.Write("{0:X2} ", packet.ToArray()[i]);
            //}

            //Console.WriteLine();
        }
    }

    // --------------------- Front server handlers ----------------------------------------- //
    public static class FrontServerHandler
    {
        public static void FRONT_CLIENT_WORLD_AND_CHARACTER_INFO(FrontContext context, byte[] protobuffer) //FRONT_CLIENT_WORLD_AND_CHARACTER_INFO
        {
            FRONT_CLIENT_WORLD_AND_CHARACTER_INFO msg = Protobuf.ProtoDeserialize<FRONT_CLIENT_WORLD_AND_CHARACTER_INFO>(protobuffer);
            Console.WriteLine("Got CLIENT_FRONT_WORLD_AND_CHARACTER_INFO ");
            
            if(msg.world_list != null)
            {
                foreach(WORLD_INFO world_info in msg.world_list)
                {
                    Console.WriteLine("World Info: {0} ({1}:{2}), State: {3}", world_info.name, world_info.ip, world_info.port, world_info.state);
                }
            }

            if(msg.character_list != null)
            {
                foreach (_front_world_character_info character in msg.character_list)
                {
                    Console.WriteLine("Got Character: {0} (Level: {1}, Class: {2})", character.name, character.level, character.class_id);
                }
            }
        }

        public static void FRONT_CLIENT_WORLD_CHARACTER_INFO(FrontContext context, byte[] protobuffer)
        {
            FRONT_CLIENT_WORLD_CHARACTER_INFO msg = Protobuf.ProtoDeserialize<FRONT_CLIENT_WORLD_CHARACTER_INFO>(protobuffer);
            Console.WriteLine("Got world characters/FRONT_CLIENT_WORLD_CHARACTER_INFO!");

            if(msg.character_info != null)
            {
                foreach(_front_world_character_info character in msg.character_info)
                {
                    Console.WriteLine("Got Character: {0} (Level: {1}, Class: {2})", character.name, character.level, character.class_id);
                }
            }

            context.login_stage = 2; //stuck thread checker

            int selectedWorld = context.Client.GameAccount.GetWorldId(context.Client.GameAccount.strWorld);
            Console.WriteLine("Entering world {0}", context.Client.GameAccount.GetWorldId(context.Client.GameAccount.strWorld));
            context.Client.m_session.SendNonEncryptedPacket(Factory.CLIENT_FRONT_SELECT_WORLD((uint)selectedWorld)); //todo: un-hardcode this
        }

        public static void FRONT_CLIENT_SERVICE_AUTH_V3(FrontContext context, byte[] protobuffer)
        {
            FRONT_CLIENT_SERVICE_AUTH_V3 msg = Protobuf.ProtoDeserialize<FRONT_CLIENT_SERVICE_AUTH_V3>(protobuffer);
            context.Client.GameAccount.account_uid = msg.user_uid;
            Console.WriteLine("Got account id: {0}", msg.user_uid);

            if(msg.user_uid == 0)
            {
                Console.WriteLine("[ERROR] Account UID was: {0}. Disconnecting.", msg.user_uid);
                context.Disconnect();
                return;
            }

            if(msg.world_list != null)
            {
                if (context.Client.GameAccount.WorldList == null)
                    context.Client.GameAccount.WorldList = new List<WORLD_INFO>();

                foreach (WORLD_INFO world in msg.world_list)
                {
                    Console.WriteLine("Found world: {0}, {1}", world.index, world.name);
                    context.Client.GameAccount.WorldList.Add(world);
                }
            }

            context.login_stage = 1;
            Thread.Sleep(1000);
            context.Client.m_session.SendNonEncryptedPacket(Factory.CLIENT_FRONT_WORLD_CHARACTER_INFO(context.Client.GameAccount.account_uid)); //sometimes it doesn't send after d/c?
        }

        public static void FRONT_CLIENT_SELECT_WORLD(FrontContext context, byte[] protobuffer) //FRONT_CLIENT_SELECT_WORLD 
        {
            Console.WriteLine("Got FRONT_CLIENT_SELECT_WORLD");

            FRONT_CLIENT_SELECT_WORLD msg = Protobuf.ProtoDeserialize<FRONT_CLIENT_SELECT_WORLD>(protobuffer);

            if(msg.ip == null)
            {
                Console.WriteLine("[WARNING] Host/Game server IP was 0 at FRONT_CLIENT_SELECT_WORLD.");
                return;
            }

            context.Client.GameAccount.UniqueLoginKey = msg.auth_key;
            context.Client.GameAccount.WorldID = msg.world_id;
            context.login_stage = 3;
            context.Client.Migrate(msg.ip, msg.port, false); //todo: change this to auto-fetch the ip
        }

        public static void HandleUnknown(FrontContext context, Reader packet)
        {
            int len = packet.ToArray().Length;

            //Console.WriteLine("Parsing unknown packet:");

            //for (int i = 0; i < len; i++)
            //{
            //    Console.Write("{0:X2} ", packet.ToArray()[i]);
            //}

            //Console.WriteLine();
        }
    }
}
