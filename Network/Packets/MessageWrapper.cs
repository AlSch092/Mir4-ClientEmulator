//By AlSch092 @ Github
﻿using Mir4ClientEmulator.Network.Packets.Messages;
using Mir4ClientEmulator.Network.Packets;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;

namespace Mir4ClientEmulator.Network
{
    internal class MessageWrapper
    {
        public static bool CLIENT_GAME_MOVE_QUEST_POS(Client c, int quest_index, _vector3 pos)
        {
            Mir4ClientEmulator.Network.Packets.Messages.CLIENT_GAME_QUEST_MOVE_POS msg = new Mir4ClientEmulator.Network.Packets.Messages.CLIENT_GAME_QUEST_MOVE_POS();
            msg.quest_index = quest_index;       
            msg.dest_loc = pos;
            byte[] serializedData = Protobuf.Serialize<CLIENT_GAME_QUEST_MOVE_POS>(msg);
            return c.m_session.SendProtobuf(Opcodes.CLIENT_GAME_QUEST_MOVE_POS, serializedData);
        }

        public static bool CLIENT_GAME_CHARACTER_BATTLE_PASS_REWARD(Client c, uint eventId, uint reward_type)
        {
            Mir4ClientEmulator.Network.Packets.Messages.CLIENT_GAME_CHARACTER_BATTLE_PASS_REWARD msg = new Mir4ClientEmulator.Network.Packets.Messages.CLIENT_GAME_CHARACTER_BATTLE_PASS_REWARD();
            msg.request_battle_pass_id_list = new uint[1];
            msg.request_battle_pass_id_list[0] = eventId;
            msg.user_uid = c.GameAccount.character_identifier;
            msg.reward_type = new uint[1];
            msg.reward_type[0] = reward_type;
            byte[] serializedData = Protobuf.Serialize<CLIENT_GAME_CHARACTER_BATTLE_PASS_REWARD>(msg);
            return c.m_session.SendProtobuf(Opcodes.CLIENT_GAME_CHARACTER_BATTLE_PASS_REWARD, serializedData);
        }

        public static bool CLIENT_GAME_EVENT_PROGRESS(Client c, int eventId, int step)
        {
            Mir4ClientEmulator.Network.Packets.Messages.CLIENT_GAME_EVENT_PROGRESS msg = new Mir4ClientEmulator.Network.Packets.Messages.CLIENT_GAME_EVENT_PROGRESS();
            msg.event_id = eventId;
            msg.event_step_number = step;
            byte[] serializedData = Protobuf.Serialize<CLIENT_GAME_EVENT_PROGRESS>(msg);
            return c.m_session.SendProtobuf(Opcodes.CLIENT_GAME_CHARACTER_BATTLE_PASS_REWARD, serializedData);
        }
        
        public static bool CLIENT_GAME_BENEDICTION_EVENT_SELECT(Client c, int user_event_tid, int benediction_tid)
        {
            Mir4ClientEmulator.Network.Packets.Messages.CLIENT_GAME_BENEDICTION_EVENT_SELECT msg = new Mir4ClientEmulator.Network.Packets.Messages.CLIENT_GAME_BENEDICTION_EVENT_SELECT();
            msg.user_event_tid = user_event_tid;
            msg.benediction_tid = benediction_tid;
            byte[] serializedData = Protobuf.Serialize<CLIENT_GAME_BENEDICTION_EVENT_SELECT>(msg);
            return c.m_session.SendProtobuf(Opcodes.CLIENT_GAME_BENEDICTION_EVENT_SELECT, serializedData);
        }

        public static bool CLIENT_GAME_SYNC_ROLL(Client c, _vector3 loc, _vector3 direction, _vector3 dest_loc, float movespeed, int anim_state)
        {
            Mir4ClientEmulator.Network.Packets.Messages.CLIENT_GAME_SYNC_ROLL msg = new Mir4ClientEmulator.Network.Packets.Messages.CLIENT_GAME_SYNC_ROLL();
            msg.loc = loc;
            msg.direction = direction;
            msg.dest_loc = dest_loc;
            msg.moveSpeed = movespeed;
            msg.anim_state = anim_state;

            byte[] serializedData = Protobuf.Serialize<CLIENT_GAME_SYNC_ROLL>(msg);
            return c.m_session.SendProtobuf(Opcodes.CLIENT_GAME_SYNC_ROLL, serializedData);
        }

        public static bool CLIENT_LOBBY_CHARACTER_LIST_ALL_GLOBAL(Client c, ulong account_uid)
        {
            Mir4ClientEmulator.Network.Packets.Messages.CLIENT_LOBBY_CHARACTER_LIST_ALL_GLOBAL msg = new Mir4ClientEmulator.Network.Packets.Messages.CLIENT_LOBBY_CHARACTER_LIST_ALL_GLOBAL();
            msg.account_uid = account_uid;
            byte[] serializedData = Protobuf.Serialize<CLIENT_LOBBY_CHARACTER_LIST_ALL_GLOBAL>(msg);
            return c.m_session.SendProtobuf(Opcodes.CLIENT_LOBBY_CHARACTER_LIST_ALL_GLOBAL, serializedData);
        }

        public static bool CLIENT_LOBBY_CHARACTER_LIST_ALL(Client c, ulong account_uid)
        {
            Mir4ClientEmulator.Network.Packets.Messages.CLIENT_LOBBY_CHARACTER_LIST_ALL msg = new Mir4ClientEmulator.Network.Packets.Messages.CLIENT_LOBBY_CHARACTER_LIST_ALL();
            msg.account_uid = account_uid;
            byte[] serializedData = Protobuf.Serialize<CLIENT_LOBBY_CHARACTER_LIST_ALL>(msg);
            return c.m_session.SendProtobuf(Opcodes.CLIENT_LOBBY_CHARACTER_LIST_ALL, serializedData);
        }
        
        public static bool CLIENT_GAME_START_CASTING(Client c, ulong casting_user_uid, int casting_type, ulong casting_target_uid, uint casting_subtype, uint casting_exec_type, bool is_auto_casting)
        {
            Mir4ClientEmulator.Network.Packets.Messages.CLIENT_GAME_START_CASTING msg = new Mir4ClientEmulator.Network.Packets.Messages.CLIENT_GAME_START_CASTING();
            msg.casting_user_uid = casting_user_uid;
            msg.casting_type = casting_type;
            msg.casting_target_uid = casting_target_uid;
            
            //msg.casting_sub_type = casting_subtype;
            //msg.casting_exec_type = casting_exec_type;
            //msg.is_auto_casting = is_auto_casting;

            byte[] serializedData = Protobuf.Serialize<CLIENT_GAME_START_CASTING>(msg);
            return c.m_session.SendProtobuf(Opcodes.CLIENT_GAME_START_CASTING, serializedData);
        }

        public static bool CLIENT_GAME_CHATMSG(Client c, string chat_msg, int chat_type, bool is_command)
        {
            Mir4ClientEmulator.Network.Packets.Messages.CLIENT_GAME_CHATMSG msg = new Mir4ClientEmulator.Network.Packets.Messages.CLIENT_GAME_CHATMSG();
         
            msg.msg = chat_msg;
            msg.is_command = is_command;
            msg.type = chat_type;

            byte[] serializedData = Protobuf.Serialize<CLIENT_GAME_CHATMSG>(msg);
            return c.m_session.SendProtobuf(Opcodes.CLIENT_GAME_CHATMSG, serializedData);
        }

        public static bool CLIENT_CHATTING_WHISPER(Client c, string chat_msg, string to_user)
        {
            Mir4ClientEmulator.Network.Packets.Messages.CLIENT_CHATTING_WHISPER msg = new Mir4ClientEmulator.Network.Packets.Messages.CLIENT_CHATTING_WHISPER();

            msg.msg = chat_msg;
            msg.send_user_uid = c.GameAccount.character_identifier;
            msg.receive_user_name = to_user;
            //needs recv unique ID?

            byte[] serializedData = Protobuf.Serialize<CLIENT_CHATTING_WHISPER>(msg);
            return c.m_session.SendProtobuf(Opcodes.CLIENT_CHATTING_WHISPER, serializedData);
        }
        
        public static bool CLIENT_GAME_START_QUEST(Client c, ulong uid, int questIndex)
        {
            Mir4ClientEmulator.Network.Packets.Messages.CLIENT_GAME_START_QUEST msg = new Mir4ClientEmulator.Network.Packets.Messages.CLIENT_GAME_START_QUEST();

            msg.uid = uid;
            msg.QuestIndex = questIndex;

            byte[] serializedData = Protobuf.Serialize<CLIENT_GAME_START_QUEST>(msg);
            return c.m_session.SendProtobuf(Opcodes.CLIENT_GAME_START_QUEST, serializedData);
        }

        public static bool CLIENT_GAME_CANCEL_SUBQUEST(Client c, int questIndex)
        {
            Mir4ClientEmulator.Network.Packets.Messages.CLIENT_GAME_CANCEL_SUBQUEST msg = new Mir4ClientEmulator.Network.Packets.Messages.CLIENT_GAME_CANCEL_SUBQUEST();

            msg.quest_index = questIndex;

            byte[] serializedData = Protobuf.Serialize<CLIENT_GAME_CANCEL_SUBQUEST>(msg);
            return c.m_session.SendProtobuf(Opcodes.CLIENT_GAME_CANCEL_SUBQUEST, serializedData);
        }
        

        public static bool CLIENT_GAME_QUEST_ACTION(Client c, int quest_index, int action, int flag)
        {
            Mir4ClientEmulator.Network.Packets.Messages.CLIENT_GAME_QUEST_ACTION msg = new Mir4ClientEmulator.Network.Packets.Messages.CLIENT_GAME_QUEST_ACTION();

            msg.quest_index = quest_index;
            msg.action = action;
            msg.flag = flag;

            byte[] serializedData = Protobuf.Serialize<CLIENT_GAME_QUEST_ACTION>(msg);
            return c.m_session.SendProtobuf(Opcodes.CLIENT_GAME_QUEST_ACTION, serializedData);
        }

        public static bool CLIENT_GAME_END_QUEST(Client c, ulong uid, int questIndex)
        {
            Mir4ClientEmulator.Network.Packets.Messages.CLIENT_GAME_END_QUEST msg = new Mir4ClientEmulator.Network.Packets.Messages.CLIENT_GAME_END_QUEST();

            msg.uid = uid;
            msg.QuestIndex = questIndex;

            byte[] serializedData = Protobuf.Serialize<CLIENT_GAME_END_QUEST>(msg);
            return c.m_session.SendProtobuf(Opcodes.CLIENT_GAME_END_QUEST, serializedData);
        }

        public static bool CLIENT_GAME_COMPLETE_QUEST(Client c, int questIndex, int questType)
        {
            Mir4ClientEmulator.Network.Packets.Messages.CLIENT_GAME_COMPLETE_QUEST msg = new Mir4ClientEmulator.Network.Packets.Messages.CLIENT_GAME_COMPLETE_QUEST();

            msg.QuestIndex = questIndex;
            msg.quest_type = questType;

            byte[] serializedData = Protobuf.Serialize<CLIENT_GAME_COMPLETE_QUEST>(msg);
            return c.m_session.SendProtobuf(Opcodes.CLIENT_GAME_COMPLETE_QUEST, serializedData);
        }

        public static bool CLIENT_GAME_ACCEPT_SUBQUEST(Client c, int questType, int questIndex)
        {
            Mir4ClientEmulator.Network.Packets.Messages.CLIENT_GAME_ACCEPT_SUBQUEST msg = new Mir4ClientEmulator.Network.Packets.Messages.CLIENT_GAME_ACCEPT_SUBQUEST();

            msg.quest_index = questIndex;
            msg.quest_type = questType;

            byte[] serializedData = Protobuf.Serialize<CLIENT_GAME_ACCEPT_SUBQUEST>(msg);
            return c.m_session.SendProtobuf(Opcodes.CLIENT_GAME_ACCEPT_SUBQUEST, serializedData);
        }

        public static bool CLIENT_GAME_COMMIT_SUBQUEST(Client c, int questType, int questIndex)
        {
            Mir4ClientEmulator.Network.Packets.Messages.CLIENT_GAME_COMMIT_SUBQUEST msg = new Mir4ClientEmulator.Network.Packets.Messages.CLIENT_GAME_COMMIT_SUBQUEST();

            msg.quest_index = questIndex;
            msg.quest_type = questType;

            byte[] serializedData = Protobuf.Serialize<CLIENT_GAME_COMMIT_SUBQUEST>(msg);
            return c.m_session.SendProtobuf(Opcodes.CLIENT_GAME_COMMIT_SUBQUEST, serializedData);
        }

        public static bool CLIENT_GAME_CHARACTER_ACHIEVEMENT_CLEAR_REWARD(Client c, ulong user_uid, uint[] achieve_id_list)
        {
            Mir4ClientEmulator.Network.Packets.Messages.CLIENT_GAME_CHARACTER_ACHIEVEMENT_CLEAR_REWARD msg = new Mir4ClientEmulator.Network.Packets.Messages.CLIENT_GAME_CHARACTER_ACHIEVEMENT_CLEAR_REWARD();

            msg.user_uid = user_uid;
            msg.request_achievement_id_list = achieve_id_list;

            byte[] serializedData = Protobuf.Serialize<CLIENT_GAME_CHARACTER_ACHIEVEMENT_CLEAR_REWARD>(msg);
            return c.m_session.SendProtobuf(Opcodes.CLIENT_GAME_CHARACTER_ACHIEVEMENT_CLEAR_REWARD, serializedData);
        }

        public static bool CLIENT_GAME_REVIVAL(Client c, int type)
        {
            Mir4ClientEmulator.Network.Packets.Messages.CLIENT_GAME_REVIVAL msg = new Mir4ClientEmulator.Network.Packets.Messages.CLIENT_GAME_REVIVAL();

            msg.type = type;

            byte[] serializedData = Protobuf.Serialize<CLIENT_GAME_REVIVAL>(msg);
            return c.m_session.SendProtobuf(Opcodes.CLIENT_GAME_REVIVAL, serializedData);
        }

        public static bool CLIENT_GAME_CHARACTER_INVEN(Client c, ulong uid)
        {
            Mir4ClientEmulator.Network.Packets.Messages.CLIENT_GAME_CHARACTER_INVEN msg = new Mir4ClientEmulator.Network.Packets.Messages.CLIENT_GAME_CHARACTER_INVEN();

            msg.uid = uid;

            byte[] serializedData = Protobuf.Serialize<CLIENT_GAME_CHARACTER_INVEN>(msg);
            return c.m_session.SendProtobuf(Opcodes.CLIENT_GAME_CHARACTER_INVEN, serializedData);
        }

        public static bool CLIENT_GAME_CHARACTER_QUICKSLOT_DATA(Client c, ulong uid)
        {
            Mir4ClientEmulator.Network.Packets.Messages.CLIENT_GAME_CHARACTER_QUICKSLOT_DATA msg = new Mir4ClientEmulator.Network.Packets.Messages.CLIENT_GAME_CHARACTER_QUICKSLOT_DATA();

            msg.uid = uid;

            byte[] serializedData = Protobuf.Serialize<CLIENT_GAME_CHARACTER_QUICKSLOT_DATA>(msg);
            return c.m_session.SendProtobuf(Opcodes.CLIENT_GAME_CHARACTER_QUICKSLOT_DATA, serializedData);
        }

        public static bool CLIENT_GAME_QUEST_RELATION_DATA(Client c, ulong uid)
        {
            Mir4ClientEmulator.Network.Packets.Messages.CLIENT_GAME_QUEST_RELATION_DATA msg = new Mir4ClientEmulator.Network.Packets.Messages.CLIENT_GAME_QUEST_RELATION_DATA();

            msg.uid = uid;

            byte[] serializedData = Protobuf.Serialize<CLIENT_GAME_QUEST_RELATION_DATA>(msg);
            return c.m_session.SendProtobuf(Opcodes.CLIENT_GAME_QUEST_RELATION_DATA, serializedData);
        }

        public static bool CLIENT_GAME_CHARACTER_ENERGY_POINT_DATA(Client c, ulong uid)
        {
            Mir4ClientEmulator.Network.Packets.Messages.CLIENT_GAME_CHARACTER_ENERGY_POINT_DATA msg = new Mir4ClientEmulator.Network.Packets.Messages.CLIENT_GAME_CHARACTER_ENERGY_POINT_DATA();

            msg.uid = uid;

            byte[] serializedData = Protobuf.Serialize<CLIENT_GAME_CHARACTER_ENERGY_POINT_DATA>(msg);
            return c.m_session.SendProtobuf(Opcodes.CLIENT_GAME_CHARACTER_ENERGY_POINT_DATA, serializedData);
        }

        public static bool CLIENT_GAME_GUILD_GIFT_LIST(Client c, uint tap_type)
        {
            Mir4ClientEmulator.Network.Packets.Messages.CLIENT_GAME_GUILD_GIFT_LIST msg = new Mir4ClientEmulator.Network.Packets.Messages.CLIENT_GAME_GUILD_GIFT_LIST();

            msg.gift_tap_type = tap_type; 

            byte[] serializedData = Protobuf.Serialize<CLIENT_GAME_GUILD_GIFT_LIST>(msg);
            return c.m_session.SendProtobuf(Opcodes.CLIENT_GAME_GUILD_GIFT_LIST, serializedData);
        }

        public static bool CLIENT_GAME_END_LOADING(Client c)
        {
            Mir4ClientEmulator.Network.Packets.Messages.CLIENT_GAME_END_LOADING msg = new Mir4ClientEmulator.Network.Packets.Messages.CLIENT_GAME_END_LOADING();
            byte[] serializedData = Protobuf.Serialize<CLIENT_GAME_END_LOADING>(msg);
            return c.m_session.SendProtobuf(Opcodes.CLIENT_GAME_END_LOADING, serializedData);
        }

        public static bool CLIENT_GAME_GUILD_GIFT_OPEN(Client c, uint tap_type, ulong gift_uid) //44 EC 88 C1 65 86 EF 96 07 00 00 00 08 01 10 9C 80 88 B0 DF 8C A5 8B 16
        {
            Mir4ClientEmulator.Network.Packets.Messages.CLIENT_GAME_GUILD_GIFT_OPEN msg = new Mir4ClientEmulator.Network.Packets.Messages.CLIENT_GAME_GUILD_GIFT_OPEN();

            msg.gift_tap_type = tap_type;
            msg.gift_uid = gift_uid;

            byte[] serializedData = Protobuf.Serialize<CLIENT_GAME_GUILD_GIFT_OPEN>(msg);
            return c.m_session.SendProtobuf(Opcodes.CLIENT_GAME_GUILD_GIFT_OPEN, serializedData);
        }
        
        public static bool CLIENT_WORLD_SEARCH(Client c, int search_type, int request_page, string search_string, int ui_type, int world_id, int receive_money_limit_type)
        {
            Mir4ClientEmulator.Network.Packets.Messages.CLIENT_WORLD_SEARCH msg = new Mir4ClientEmulator.Network.Packets.Messages.CLIENT_WORLD_SEARCH();

            msg.search_type = search_type;
            msg.request_page = request_page;
            msg.search_string = search_string;
            msg.ui_type = ui_type;
            msg.world_id = world_id;
            msg.receive_money_limit_type = receive_money_limit_type;

            byte[] serializedData = Protobuf.Serialize<CLIENT_WORLD_SEARCH>(msg);
            return c.m_session.SendProtobuf(Opcodes.CLIENT_WORLD_SEARCH, serializedData);
        }
        

        public static bool CLIENT_GAME_CHARACTER_QUEST(Client c, ulong uid)
        {
            Mir4ClientEmulator.Network.Packets.Messages.CLIENT_GAME_CHARACTER_QUEST msg = new Mir4ClientEmulator.Network.Packets.Messages.CLIENT_GAME_CHARACTER_QUEST();

            msg.uid = uid;

            byte[] serializedData = Protobuf.Serialize<CLIENT_GAME_CHARACTER_QUEST>(msg);
            return c.m_session.SendProtobuf(Opcodes.CLIENT_GAME_CHARACTER_QUEST, serializedData);
        }
        
        public static bool CLIENT_GAME_START_QUEST_CINEMATIC(Client c, int quest_index, int cinematic_type, int cinematic_id)
        {
            Mir4ClientEmulator.Network.Packets.Messages.CLIENT_GAME_START_QUEST_CINEMATIC msg = new Mir4ClientEmulator.Network.Packets.Messages.CLIENT_GAME_START_QUEST_CINEMATIC();

            msg.quest_index = quest_index;
            msg.cinematic_type = cinematic_type;
            msg.cinematic_id = cinematic_id;

            byte[] serializedData = Protobuf.Serialize<CLIENT_GAME_START_QUEST_CINEMATIC>(msg);
            return c.m_session.SendProtobuf(Opcodes.CLIENT_GAME_START_QUEST_CINEMATIC, serializedData);
        }

        public static bool CLIENT_GAME_ATTACK_IN_PHASING(Client c, int attacker_type, ulong attacker_uid, int skill, int attack_id, _phasing_target_info[] targets)
        {
            Mir4ClientEmulator.Network.Packets.Messages.CLIENT_GAME_ATTACK_IN_PHASING msg = new Mir4ClientEmulator.Network.Packets.Messages.CLIENT_GAME_ATTACK_IN_PHASING();

            msg.attacker_type = attacker_type;
            msg.attacker = attacker_uid;
            msg.skill = skill;
            msg.attack_id = attack_id;
            msg.targets = targets;

            byte[] serializedData = Protobuf.Serialize<CLIENT_GAME_ATTACK_IN_PHASING>(msg);
            return c.m_session.SendProtobuf(Opcodes.CLIENT_GAME_ATTACK_IN_PHASING, serializedData);
        }
        
        public static bool CLIENT_GAME_START_PHASING_QUEST(Client c, int quest_index)
        {
            Mir4ClientEmulator.Network.Packets.Messages.CLIENT_GAME_START_PHASING_QUEST msg = new Mir4ClientEmulator.Network.Packets.Messages.CLIENT_GAME_START_PHASING_QUEST();

            msg.quest_index = quest_index;

            byte[] serializedData = Protobuf.Serialize<CLIENT_GAME_START_PHASING_QUEST>(msg);
            return c.m_session.SendProtobuf(Opcodes.CLIENT_GAME_START_PHASING_QUEST, serializedData);
        }

        public static bool CLIENT_GAME_END_PHASING_QUEST(Client c, int quest_index, _vector3 pos, int success, int flag)
        {
            Mir4ClientEmulator.Network.Packets.Messages.CLIENT_GAME_END_PHASING_QUEST msg = new Mir4ClientEmulator.Network.Packets.Messages.CLIENT_GAME_END_PHASING_QUEST();

            msg.quest_index = quest_index;
            msg.pos = pos;
            msg.success = success;
            msg.flag = flag;

            byte[] serializedData = Protobuf.Serialize<CLIENT_GAME_END_PHASING_QUEST>(msg);
            return c.m_session.SendProtobuf(Opcodes.CLIENT_GAME_END_PHASING_QUEST, serializedData);
        }
 

        public static bool CLIENT_GAME_COMPLETEALL_DAILYHOMEWORK(Client c)
        {
            Mir4ClientEmulator.Network.Packets.Messages.CLIENT_GAME_COMPLETEALL_DAILYHOMEWORK msg = new Mir4ClientEmulator.Network.Packets.Messages.CLIENT_GAME_COMPLETEALL_DAILYHOMEWORK();
            byte[] serializedData = Protobuf.Serialize<CLIENT_GAME_COMPLETEALL_DAILYHOMEWORK>(msg);
            return c.m_session.SendProtobuf(Opcodes.CLIENT_GAME_COMPLETEALL_DAILYHOMEWORK, serializedData);
        }

        public static bool CLIENT_GAME_QUEST_NPC_TALK(Client c, int quest_index)
        {
            Mir4ClientEmulator.Network.Packets.Messages.CLIENT_GAME_QUEST_NPC_TALK msg = new Mir4ClientEmulator.Network.Packets.Messages.CLIENT_GAME_QUEST_NPC_TALK();

            msg.quest_index = quest_index;
            
            byte[] serializedData = Protobuf.Serialize<CLIENT_GAME_QUEST_NPC_TALK>(msg);
            return c.m_session.SendProtobuf(Opcodes.CLIENT_GAME_QUEST_NPC_TALK, serializedData);
        }

        public static bool CLIENT_GAME_WARP_PORTAL(Client c, ulong uid, uint portal_id)
        {
            Mir4ClientEmulator.Network.Packets.Messages.CLIENT_GAME_WARP_PORTAL msg = new Mir4ClientEmulator.Network.Packets.Messages.CLIENT_GAME_WARP_PORTAL();

            msg.uid = uid;
            msg.portal_id = portal_id;

            byte[] serializedData = Protobuf.Serialize<CLIENT_GAME_WARP_PORTAL>(msg);
            return c.m_session.SendProtobuf(Opcodes.CLIENT_GAME_WARP_PORTAL, serializedData);
        }

        public static bool CLIENT_GAME_WARP_USER(Client c, uint stageId, float x, float y, float z)
        {
            Mir4ClientEmulator.Network.Packets.Messages.CLIENT_GAME_WARP_USER msg = new Mir4ClientEmulator.Network.Packets.Messages.CLIENT_GAME_WARP_USER();

            _vector3 loc = new _vector3();
            loc.x = x; loc.y = y; loc.z = z;

            msg.stage_id = stageId;
            msg.loc = loc;

            byte[] serializedData = Protobuf.Serialize<CLIENT_GAME_WARP_USER>(msg);
            return c.m_session.SendProtobuf(Opcodes.CLIENT_GAME_WARP_USER, serializedData);
        }

        
        public static bool CLIENT_WORLD_UNSEALING_LIST(Client c)
        {
            Mir4ClientEmulator.Network.Packets.Messages.CLIENT_WORLD_UNSEALING_LIST msg = new Mir4ClientEmulator.Network.Packets.Messages.CLIENT_WORLD_UNSEALING_LIST();
            byte[] serializedData = Protobuf.Serialize<CLIENT_WORLD_UNSEALING_LIST>(msg);
            return c.m_session.SendProtobuf(Opcodes.CLIENT_WORLD_UNSEALING_LIST, serializedData);
        }

        public static bool CLIENT_WORLD_UNSEALING_REGISTER(Client c, long unsealing_item_uid, int slot)
        {
            Mir4ClientEmulator.Network.Packets.Messages.CLIENT_WORLD_UNSEALING_REGISTER msg = new Mir4ClientEmulator.Network.Packets.Messages.CLIENT_WORLD_UNSEALING_REGISTER();
            msg.unsealing_item_uid = unsealing_item_uid;
            msg.unsealing_slot = slot;

            byte[] serializedData = Protobuf.Serialize<CLIENT_WORLD_UNSEALING_REGISTER>(msg);
            return c.m_session.SendProtobuf(Opcodes.CLIENT_WORLD_UNSEALING_REGISTER, serializedData);
        }

        public static bool CLIENT_WORLD_UNSEALING_SUPPORT_LIST(Client c)
        {
            Mir4ClientEmulator.Network.Packets.Messages.CLIENT_WORLD_UNSEALING_SUPPORT_LIST msg = new Mir4ClientEmulator.Network.Packets.Messages.CLIENT_WORLD_UNSEALING_SUPPORT_LIST();
            byte[] serializedData = Protobuf.Serialize<CLIENT_WORLD_UNSEALING_SUPPORT_LIST>(msg);
            return c.m_session.SendProtobuf(Opcodes.CLIENT_WORLD_UNSEALING_SUPPORT_LIST, serializedData);
        }

        public static bool CLIENT_WORLD_UNSEALING_SUPPORT(Client c)
        {
            Mir4ClientEmulator.Network.Packets.Messages.CLIENT_WORLD_UNSEALING_SUPPORT msg = new Mir4ClientEmulator.Network.Packets.Messages.CLIENT_WORLD_UNSEALING_SUPPORT();
            byte[] serializedData = Protobuf.Serialize<CLIENT_WORLD_UNSEALING_SUPPORT>(msg);
            return c.m_session.SendProtobuf(Opcodes.CLIENT_WORLD_UNSEALING_SUPPORT, serializedData);
        }

        public static bool CLIENT_WORLD_UNSEALING_GET(Client c, int slot)
        {
            Mir4ClientEmulator.Network.Packets.Messages.CLIENT_WORLD_UNSEALING_GET msg = new Mir4ClientEmulator.Network.Packets.Messages.CLIENT_WORLD_UNSEALING_GET();
            
            msg.unsealing_slot = slot;
            
            byte[] serializedData = Protobuf.Serialize<CLIENT_WORLD_UNSEALING_GET>(msg);
            return c.m_session.SendProtobuf(Opcodes.CLIENT_WORLD_UNSEALING_GET, serializedData);
        }

        public static bool CLIENT_GAME_UNSEALING_GET_ALL(Client c )
        {
            Mir4ClientEmulator.Network.Packets.Messages.CLIENT_GAME_UNSEALING_GET_ALL msg = new Mir4ClientEmulator.Network.Packets.Messages.CLIENT_GAME_UNSEALING_GET_ALL();

            byte[] serializedData = Protobuf.Serialize<CLIENT_GAME_UNSEALING_GET_ALL>(msg);
            return c.m_session.SendProtobuf(Opcodes.CLIENT_GAME_UNSEALING_GET_ALL, serializedData);
        }
        
        public static bool CLIENT_WORLD_UNSEALING_SUPPORT_REGISTER(Client c, int support_type, int slot)
        {
            Mir4ClientEmulator.Network.Packets.Messages.CLIENT_WORLD_UNSEALING_SUPPORT_REGISTER msg = new Mir4ClientEmulator.Network.Packets.Messages.CLIENT_WORLD_UNSEALING_SUPPORT_REGISTER();
            msg.support_type = support_type;
            msg.slot = slot;

            byte[] serializedData = Protobuf.Serialize<CLIENT_WORLD_UNSEALING_SUPPORT_REGISTER>(msg);
            return c.m_session.SendProtobuf(Opcodes.CLIENT_WORLD_UNSEALING_SUPPORT_REGISTER, serializedData);
        }

        public static bool CLIENT_GAME_WARP_USER_STATE(Client c)
        {
            Mir4ClientEmulator.Network.Packets.Messages.CLIENT_GAME_WARP_USER_STATE msg = new Mir4ClientEmulator.Network.Packets.Messages.CLIENT_GAME_WARP_USER_STATE();


            byte[] serializedData = Protobuf.Serialize<CLIENT_GAME_WARP_USER_STATE>(msg);
            return c.m_session.SendProtobuf(Opcodes.CLIENT_GAME_WARP_USER_STATE, serializedData);
        }

        public static bool CLIENT_GAME_WARP_STATE_CHECK(Client c, ulong uid)
        {
            Mir4ClientEmulator.Network.Packets.Messages.CLIENT_GAME_WARP_STATE_CHECK msg = new Mir4ClientEmulator.Network.Packets.Messages.CLIENT_GAME_WARP_STATE_CHECK();

            msg.user_uid = uid;

            byte[] serializedData = Protobuf.Serialize<CLIENT_GAME_WARP_STATE_CHECK>(msg);
            return c.m_session.SendProtobuf(Opcodes.CLIENT_GAME_WARP_STATE_CHECK, serializedData);
        }

        //public static bool CLIENT_GAME_COSTUME_LIST(Client c)
        //{
        //    Mir4ClientEmulator.Network.Packets.Messages.CLIENT_GAME_COSTUME_LIST msg = new Mir4ClientEmulator.Network.Packets.Messages.CLIENT_GAME_COSTUME_LIST();

        //    byte[] serializedData = Protobuf.Serialize<CLIENT_GAME_COSTUME_LIST>(msg);
        //    return c.m_session.SendProtobuf(Opcodes.CLIENT_GAME_COSTUME_LIST, serializedData);
        //}

        public static bool CLIENT_GAME_EQUIP_COSTUME_NEW(Client c, ulong uid, uint costume_index)
        {
            Mir4ClientEmulator.Network.Packets.Messages.CLIENT_GAME_EQUIP_COSTUME_NEW msg = new Mir4ClientEmulator.Network.Packets.Messages.CLIENT_GAME_EQUIP_COSTUME_NEW();

            msg.user_uid = uid;
            msg.costume_index = costume_index;

            byte[] serializedData = Protobuf.Serialize<CLIENT_GAME_EQUIP_COSTUME_NEW>(msg);
            return c.m_session.SendProtobuf(Opcodes.CLIENT_GAME_EQUIP_COSTUME_NEW, serializedData);
        }

        public static bool CLIENT_GAME_EQUIP_LUXURY_COSTUME(Client c, ulong equip_item_uid)
        {
            Mir4ClientEmulator.Network.Packets.Messages.CLIENT_GAME_EQUIP_LUXURY_COSTUME msg = new Mir4ClientEmulator.Network.Packets.Messages.CLIENT_GAME_EQUIP_LUXURY_COSTUME();

            msg.equip_item_uid = equip_item_uid;

            byte[] serializedData = Protobuf.Serialize<CLIENT_GAME_EQUIP_LUXURY_COSTUME>(msg);
            return c.m_session.SendProtobuf(Opcodes.CLIENT_GAME_EQUIP_LUXURY_COSTUME, serializedData);
        }

        public static bool CLIENT_GAME_GACHA_PULL(Client c, uint gacha_type, uint gacha_pull_type, uint money_type, bool is_many_count, uint shop_goods_id, uint shop_goods_ver)
        {
            Mir4ClientEmulator.Network.Packets.Messages.CLIENT_GAME_GACHA_PULL msg = new Mir4ClientEmulator.Network.Packets.Messages.CLIENT_GAME_GACHA_PULL();

            msg.gacha_type = gacha_type;
            msg.gacha_pull_type = gacha_pull_type;
            msg.money_type = money_type;
            msg.is_many_count = is_many_count;
            msg.shop_goods_id = shop_goods_id;
            msg.shop_goods_ver = shop_goods_ver;

            byte[] serializedData = Protobuf.Serialize<CLIENT_GAME_GACHA_PULL>(msg);
            return c.m_session.SendProtobuf(Opcodes.CLIENT_GAME_GACHA_PULL, serializedData);
        }

        public static bool CLIENT_GAME_UI_SHOP_BUYITEM(Client c, uint shop_goods_ver, uint goods_id, int buy_count)
        {
            Mir4ClientEmulator.Network.Packets.Messages.CLIENT_GAME_UI_SHOP_BUYITEM msg = new Mir4ClientEmulator.Network.Packets.Messages.CLIENT_GAME_UI_SHOP_BUYITEM();

            msg.shop_goods_ver = shop_goods_ver;
            msg.goods_id = goods_id;
            msg.buy_count = buy_count;

            byte[] serializedData = Protobuf.Serialize<CLIENT_GAME_UI_SHOP_BUYITEM>(msg);
            return c.m_session.SendProtobuf(Opcodes.CLIENT_GAME_UI_SHOP_BUYITEM, serializedData);
        }

       
        public static bool CLIENT_GAME_WARP_TO_ESCAPE_POS(Client c)
        {
            Mir4ClientEmulator.Network.Packets.Messages.CLIENT_GAME_WARP_TO_ESCAPE_POS msg = new Mir4ClientEmulator.Network.Packets.Messages.CLIENT_GAME_WARP_TO_ESCAPE_POS();
            byte[] serializedData = Protobuf.Serialize<CLIENT_GAME_WARP_TO_ESCAPE_POS>(msg);
            return c.m_session.SendProtobuf(Opcodes.CLIENT_GAME_WARP_TO_ESCAPE_POS, serializedData);
        }
        
        public static bool CLIENT_GAME_GUILD_SHOP_BUY(Client c, int goods_index, int count)
        {
            Mir4ClientEmulator.Network.Packets.Messages.CLIENT_GAME_GUILD_SHOP_BUY msg = new Mir4ClientEmulator.Network.Packets.Messages.CLIENT_GAME_GUILD_SHOP_BUY();

            msg.buy_goods = new _guild_goods_info();
            msg.buy_goods.goods_index = goods_index;
            msg.buy_goods.goods_count = count;

            byte[] serializedData = Protobuf.Serialize<CLIENT_GAME_GUILD_SHOP_BUY>(msg);
            return c.m_session.SendProtobuf(Opcodes.CLIENT_GAME_GUILD_SHOP_BUY, serializedData);
        }

        public static bool CLIENT_GAME_NPC_SHOP_DATA(Client c, uint npc_id, uint shop_id)
        {
            Mir4ClientEmulator.Network.Packets.Messages.CLIENT_GAME_NPC_SHOP_DATA msg = new Mir4ClientEmulator.Network.Packets.Messages.CLIENT_GAME_NPC_SHOP_DATA();

            msg.npc_id = npc_id;
            msg.shop_id = shop_id;

            byte[] serializedData = Protobuf.Serialize<CLIENT_GAME_NPC_SHOP_DATA>(msg);
            return c.m_session.SendProtobuf(Opcodes.CLIENT_GAME_NPC_SHOP_DATA, serializedData);
        }

        public static bool CLIENT_GAME_GUILD_SHOP_LIST(Client c)
        {
            Mir4ClientEmulator.Network.Packets.Messages.CLIENT_GAME_GUILD_SHOP_LIST msg = new Mir4ClientEmulator.Network.Packets.Messages.CLIENT_GAME_GUILD_SHOP_LIST();

            byte[] serializedData = Protobuf.Serialize<CLIENT_GAME_GUILD_SHOP_LIST>(msg);
            return c.m_session.SendProtobuf(Opcodes.CLIENT_GAME_GUILD_SHOP_LIST, serializedData);
        }

        public static bool CLIENT_GAME_MAIL_LIST(Client c)
        {
            Mir4ClientEmulator.Network.Packets.Messages.CLIENT_GAME_MAIL_LIST msg = new Mir4ClientEmulator.Network.Packets.Messages.CLIENT_GAME_MAIL_LIST();

            byte[] serializedData = Protobuf.Serialize<CLIENT_GAME_MAIL_LIST>(msg);
            return c.m_session.SendProtobuf(Opcodes.CLIENT_GAME_MAIL_LIST, serializedData);
        }

       
        public static bool CLIENT_GAME_GUILD_SHOP_LOG(Client c, int log_type)
        {
            Mir4ClientEmulator.Network.Packets.Messages.CLIENT_GAME_GUILD_SHOP_LOG msg = new Mir4ClientEmulator.Network.Packets.Messages.CLIENT_GAME_GUILD_SHOP_LOG();

            msg.log_type = log_type;

            byte[] serializedData = Protobuf.Serialize<CLIENT_GAME_GUILD_SHOP_LOG>(msg);
            return c.m_session.SendProtobuf(Opcodes.CLIENT_GAME_GUILD_SHOP_LOG, serializedData);
        }

        public static bool CLIENT_GAME_USE_ITEM(Client c, ulong item_uid, int count)
        {
            Mir4ClientEmulator.Network.Packets.Messages.CLIENT_GAME_USE_ITEM msg = new Mir4ClientEmulator.Network.Packets.Messages.CLIENT_GAME_USE_ITEM();

            msg.use_item_uid = item_uid;
            msg.use_item_count = count;

            byte[] serializedData = Protobuf.Serialize<CLIENT_GAME_USE_ITEM>(msg);
            return c.m_session.SendProtobuf(Opcodes.CLIENT_GAME_USE_ITEM, serializedData);
        }

        public static bool CLIENT_GAME_ATTACK_CHAIN(Client c, int skill, int attack_id,  int state, uint cur_skill_step, _vector3 loc_start, _vector3 loc_end, _vector3 direction, _target_info[] target_list)
        {
            Mir4ClientEmulator.Network.Packets.Messages.CLIENT_GAME_ATTACK_CHAIN msg = new Mir4ClientEmulator.Network.Packets.Messages.CLIENT_GAME_ATTACK_CHAIN();

            msg.skill = skill;
            msg.attack_id = attack_id;
            msg.state = state;
            msg.cur_skill_step = cur_skill_step;
            msg.loc_start = loc_start;
            msg.loc_end = loc_end;
            msg.attack_direction_vector = direction;
            msg.target_list = target_list;

            byte[] serializedData = Protobuf.Serialize<CLIENT_GAME_ATTACK_CHAIN>(msg);
            return c.m_session.SendProtobuf(Opcodes.CLIENT_GAME_ATTACK_CHAIN, serializedData);
        }
        
        public static bool CLIENT_GAME_CREATE_PARTY_REQUEST(Client c, ulong uid, uint stageId, uint joinableType, uint partyNumberType, uint partyStageType, string partyTitle, string password, uint powerScoreMinimum)
        {
            Mir4ClientEmulator.Network.Packets.Messages.CLIENT_GAME_CREATE_PARTY_REQUEST msg = new Mir4ClientEmulator.Network.Packets.Messages.CLIENT_GAME_CREATE_PARTY_REQUEST();

            msg.create_party_attribute = new _party_attribute();
            msg.create_party_attribute.joinable_type = joinableType;

            msg.create_party_attribute.limit_combat_point = powerScoreMinimum;
            msg.create_party_attribute.party_number_type = partyNumberType;
            msg.create_party_attribute.party_description = partyTitle;
            msg.create_party_attribute.party_target_stage_index = stageId;
            msg.create_party_attribute.party_stage_type = partyStageType;
            
            msg.uid = uid;

            if (password != null)
                msg.password = password;

            byte[] serializedData = Protobuf.Serialize<CLIENT_GAME_CREATE_PARTY_REQUEST>(msg);
            return c.m_session.SendProtobuf(Opcodes.CLIENT_GAME_CREATE_PARTY_REQUEST, serializedData);
        }
        public static bool CLIENT_GAME_PARTY_INSTANCE_DUNGEON_ENTER(Client c, ulong uid, uint raid_instance_id)
        {
            Mir4ClientEmulator.Network.Packets.Messages.CLIENT_GAME_PARTY_INSTANCE_DUNGEON_ENTER msg = new Mir4ClientEmulator.Network.Packets.Messages.CLIENT_GAME_PARTY_INSTANCE_DUNGEON_ENTER();
            msg.uid = uid;
            msg.world_boss_raid_id = raid_instance_id;
            byte[] serializedData = Protobuf.Serialize<CLIENT_GAME_PARTY_INSTANCE_DUNGEON_ENTER>(msg);
            return c.m_session.SendProtobuf(Opcodes.CLIENT_GAME_PARTY_INSTANCE_DUNGEON_ENTER, serializedData);
        }

        public static bool CLIENT_GAME_ITEM_COMPOSE_POINT_REWARD(Client c, int[] fail_ids)
        {
            Mir4ClientEmulator.Network.Packets.Messages.CLIENT_GAME_ITEM_COMPOSE_POINT_REWARD msg = new Mir4ClientEmulator.Network.Packets.Messages.CLIENT_GAME_ITEM_COMPOSE_POINT_REWARD();
            msg.fail_type_list = fail_ids;
            byte[] serializedData = Protobuf.Serialize<CLIENT_GAME_ITEM_COMPOSE_POINT_REWARD>(msg);
            return c.m_session.SendProtobuf(Opcodes.CLIENT_GAME_ITEM_COMPOSE_POINT_REWARD, serializedData);
        }
        

        public static bool CLIENT_WORLD_INSTANCE_DUNGEON_ENTER(Client c, ulong uid, uint raid_instance_id, bool is_party)
        {
            Mir4ClientEmulator.Network.Packets.Messages.CLIENT_WORLD_INSTANCE_DUNGEON_ENTER msg = new Mir4ClientEmulator.Network.Packets.Messages.CLIENT_WORLD_INSTANCE_DUNGEON_ENTER();
            
            msg.uid = uid;
            msg.world_boss_raid_id = raid_instance_id;
            msg.is_party = is_party;

            byte[] serializedData = Protobuf.Serialize<CLIENT_WORLD_INSTANCE_DUNGEON_ENTER>(msg);
            return c.m_session.SendProtobuf(Opcodes.CLIENT_WORLD_INSTANCE_DUNGEON_ENTER, serializedData);
        }

        public static bool CLIENT_WORLD_UNSEALING_ACCELERATE_POINT(Client c, int unsealing_slot, int unsealing_point_type, int unsealing_point_value)
        {
            Mir4ClientEmulator.Network.Packets.Messages.CLIENT_WORLD_UNSEALING_ACCELERATE_POINT msg = new Mir4ClientEmulator.Network.Packets.Messages.CLIENT_WORLD_UNSEALING_ACCELERATE_POINT();

            msg.unsealing_slot = unsealing_slot;
            msg.unsealing_point_type = unsealing_point_type;
            msg.unsealing_point_value = unsealing_point_value;

            byte[] serializedData = Protobuf.Serialize<CLIENT_WORLD_UNSEALING_ACCELERATE_POINT>(msg);
            return c.m_session.SendProtobuf(Opcodes.CLIENT_WORLD_UNSEALING_ACCELERATE_POINT, serializedData);
        }

        public static bool CLIENT_GAME_DUNGEON_SHOP_BUY(Client c, int shop_group_id, int shop_id, int buy_count)
        {
            Mir4ClientEmulator.Network.Packets.Messages.CLIENT_GAME_DUNGEON_SHOP_BUY msg = new Mir4ClientEmulator.Network.Packets.Messages.CLIENT_GAME_DUNGEON_SHOP_BUY();

            msg.shop_group_id = shop_group_id;
            msg.shop_id = shop_id;
            msg.buy_count = buy_count;

            byte[] serializedData = Protobuf.Serialize<CLIENT_GAME_DUNGEON_SHOP_BUY>(msg);
            return c.m_session.SendProtobuf(Opcodes.CLIENT_GAME_DUNGEON_SHOP_BUY, serializedData);
        }
        

        public static bool CLIENT_GAME_INSTANCE_ZONE_OUT(Client c, ulong uid, int out_stage_type)
        {
            Mir4ClientEmulator.Network.Packets.Messages.CLIENT_GAME_INSTANCE_ZONE_OUT msg = new Mir4ClientEmulator.Network.Packets.Messages.CLIENT_GAME_INSTANCE_ZONE_OUT();

            msg.uid = uid;
            msg.out_stage_type = out_stage_type;

            byte[] serializedData = Protobuf.Serialize<CLIENT_GAME_INSTANCE_ZONE_OUT>(msg);
            return c.m_session.SendProtobuf(Opcodes.CLIENT_GAME_INSTANCE_ZONE_OUT, serializedData);
        }

        public static bool CLIENT_GAME_HEARTBEAT(Client c)
        {
            Mir4ClientEmulator.Network.Packets.Messages.CLIENT_GAME_HEARTBEAT msg = new Mir4ClientEmulator.Network.Packets.Messages.CLIENT_GAME_HEARTBEAT();

            byte[] serializedData = Protobuf.Serialize<CLIENT_GAME_HEARTBEAT>(msg);
            return c.m_session.SendProtobuf(Opcodes.CLIENT_GAME_HEARTBEAT, serializedData);
        }

        public static bool CLIENT_GAME_CHARACTER_SKILL(Client c, ulong uid)
        {
            Mir4ClientEmulator.Network.Packets.Messages.CLIENT_GAME_CHARACTER_SKILL msg = new Mir4ClientEmulator.Network.Packets.Messages.CLIENT_GAME_CHARACTER_SKILL();

            msg.uid = uid;

            byte[] serializedData = Protobuf.Serialize<CLIENT_GAME_CHARACTER_SKILL>(msg);
            return c.m_session.SendProtobuf(Opcodes.CLIENT_GAME_CHARACTER_SKILL, serializedData);
        }

        public static bool CLIENT_GAME_ENTER_INVINCIBLE_STATE(Client c, ulong uid)
        {
            Mir4ClientEmulator.Network.Packets.Messages.CLIENT_GAME_ENTER_INVINCIBLE_STATE msg = new Mir4ClientEmulator.Network.Packets.Messages.CLIENT_GAME_ENTER_INVINCIBLE_STATE();

            msg.uid = uid;

            byte[] serializedData = Protobuf.Serialize<CLIENT_GAME_ENTER_INVINCIBLE_STATE>(msg);
            return c.m_session.SendProtobuf(Opcodes.CLIENT_GAME_ENTER_INVINCIBLE_STATE, serializedData);
        }

        public static bool CLIENT_WORLD_WARP_PARTY_USER_MAGIC_SQUARE_ROOM(Client c, ulong uid)
        {
            Mir4ClientEmulator.Network.Packets.Messages.CLIENT_WORLD_WARP_PARTY_USER_MAGIC_SQUARE_ROOM msg = new Mir4ClientEmulator.Network.Packets.Messages.CLIENT_WORLD_WARP_PARTY_USER_MAGIC_SQUARE_ROOM();

            msg.target_uid = uid;

            byte[] serializedData = Protobuf.Serialize<CLIENT_WORLD_WARP_PARTY_USER_MAGIC_SQUARE_ROOM>(msg);
            return c.m_session.SendProtobuf(Opcodes.CLIENT_WORLD_WARP_PARTY_USER_MAGIC_SQUARE_ROOM, serializedData);
        }

        public static bool CLIENT_WORLD_PARTY_ADVERTISING(Client c)
        {
            Mir4ClientEmulator.Network.Packets.Messages.CLIENT_WORLD_PARTY_ADVERTISING msg = new Mir4ClientEmulator.Network.Packets.Messages.CLIENT_WORLD_PARTY_ADVERTISING();
            byte[] serializedData = Protobuf.Serialize<CLIENT_WORLD_PARTY_ADVERTISING>(msg);
            return c.m_session.SendProtobuf(Opcodes.CLIENT_WORLD_PARTY_ADVERTISING, serializedData);
        }

        public static bool CLIENT_GAME_WAITING_ZONE_WARP(Client c, ulong uid, ulong zone_uid, uint location_id)
        {
            Mir4ClientEmulator.Network.Packets.Messages.CLIENT_GAME_WAITING_ZONE_WARP msg = new Mir4ClientEmulator.Network.Packets.Messages.CLIENT_GAME_WAITING_ZONE_WARP();
            
            msg.uid = uid;
            msg.zone_uid = zone_uid;
            msg.location_id = location_id;
            
            byte[] serializedData = Protobuf.Serialize<CLIENT_GAME_WAITING_ZONE_WARP>(msg);
            return c.m_session.SendProtobuf(Opcodes.CLIENT_GAME_WAITING_ZONE_WARP, serializedData);
        }
        
        public static bool CLIENT_GAME_WARP_USER(Client c, uint stage_id, _vector3 loc)
        {
            Mir4ClientEmulator.Network.Packets.Messages.CLIENT_GAME_WARP_USER msg = new Mir4ClientEmulator.Network.Packets.Messages.CLIENT_GAME_WARP_USER();

            msg.stage_id = stage_id;
            msg.loc = loc;

            byte[] serializedData = Protobuf.Serialize<CLIENT_GAME_WARP_USER>(msg);
            return c.m_session.SendProtobuf(Opcodes.CLIENT_GAME_WARP_USER, serializedData);
        }

        public static bool CLIENT_GAME_MAIL_PACK_SEND(Client c, ulong recv_user_id, string title, string receive_nick_name, string contents)
        {
            Mir4ClientEmulator.Network.Packets.Messages.CLIENT_GAME_MAIL_PACK_SEND msg = new Mir4ClientEmulator.Network.Packets.Messages.CLIENT_GAME_MAIL_PACK_SEND();

            msg.recv_user_id_list = new ulong[1];
            msg.recv_user_id_list[0] = recv_user_id;
            msg.send_mail = new _send_mail_data();
            msg.send_mail.title = title;
            msg.send_mail.receive_nick_name = receive_nick_name;
            msg.send_mail.contents = contents;

            byte[] serializedData = Protobuf.Serialize<CLIENT_GAME_MAIL_PACK_SEND>(msg);
            return c.m_session.SendProtobuf(Opcodes.CLIENT_GAME_MAIL_PACK_SEND, serializedData);
        }
        
        public static bool CLIENT_GAME_CHARACTER_BATTLE_PASS_TICKET(Client c)
        {
            Mir4ClientEmulator.Network.Packets.Messages.CLIENT_GAME_CHARACTER_BATTLE_PASS_TICKET msg = new Mir4ClientEmulator.Network.Packets.Messages.CLIENT_GAME_CHARACTER_BATTLE_PASS_TICKET();
            byte[] serializedData = Protobuf.Serialize<CLIENT_GAME_CHARACTER_BATTLE_PASS_TICKET>(msg);
            return c.m_session.SendProtobuf(Opcodes.CLIENT_GAME_CHARACTER_BATTLE_PASS_TICKET, serializedData);
        }

        public static bool CLIENT_GAME_VEHICLE_UNLOCK(Client c, int vehicle_group)
        {
            Mir4ClientEmulator.Network.Packets.Messages.CLIENT_GAME_VEHICLE_UNLOCK msg = new Mir4ClientEmulator.Network.Packets.Messages.CLIENT_GAME_VEHICLE_UNLOCK();

            msg.vehicle_group = vehicle_group;

            byte[] serializedData = Protobuf.Serialize<CLIENT_GAME_VEHICLE_UNLOCK>(msg);
            return c.m_session.SendProtobuf(Opcodes.CLIENT_GAME_VEHICLE_UNLOCK, serializedData);
        }
        
        public static bool CLIENT_GAME_VEHICLE_RIDE_ON_OFF(Client c, _vector3 loc, bool is_ride)
        {
            Mir4ClientEmulator.Network.Packets.Messages.CLIENT_GAME_VEHICLE_RIDE_ON_OFF msg = new Mir4ClientEmulator.Network.Packets.Messages.CLIENT_GAME_VEHICLE_RIDE_ON_OFF();

            msg.loc = loc;
            msg.isRide = is_ride;

            byte[] serializedData = Protobuf.Serialize<CLIENT_GAME_VEHICLE_RIDE_ON_OFF>(msg);
            return c.m_session.SendProtobuf(Opcodes.CLIENT_GAME_VEHICLE_RIDE_ON_OFF, serializedData);
        }

        public static bool CLIENT_GAME_GET_DARKSTEEL_DAILY_SUM(Client c)
        {
            Mir4ClientEmulator.Network.Packets.Messages.CLIENT_GAME_GET_DARKSTEEL_DAILY_SUM msg = new Mir4ClientEmulator.Network.Packets.Messages.CLIENT_GAME_GET_DARKSTEEL_DAILY_SUM();

            byte[] serializedData = Protobuf.Serialize<CLIENT_GAME_GET_DARKSTEEL_DAILY_SUM>(msg);
            return c.m_session.SendProtobuf(Opcodes.CLIENT_GAME_GET_DARKSTEEL_DAILY_SUM, serializedData);
        }

        public static bool CLIENT_WORLD_DOMINION_PRIZE(Client c, uint dominion_id, uint prize_tid, string target_name, ulong target_uid)
        {
            Mir4ClientEmulator.Network.Packets.Messages.CLIENT_WORLD_DOMINION_PRIZE msg = new Mir4ClientEmulator.Network.Packets.Messages.CLIENT_WORLD_DOMINION_PRIZE();

            msg.prize_tid = prize_tid;
            msg.dominion_id = dominion_id;
            msg.target_name = target_name;
            msg.target_user_uid = target_uid;

            byte[] serializedData = Protobuf.Serialize<CLIENT_WORLD_DOMINION_PRIZE>(msg);
            return c.m_session.SendProtobuf(Opcodes.CLIENT_WORLD_DOMINION_PRIZE, serializedData);
        }

        public static bool CLIENT_WORLD_DOMINION_TAX_WITHDRAWAL(Client c, int dominion_tid, long withdrawal_coin, long withdrawal_gold)
        {
            Mir4ClientEmulator.Network.Packets.Messages.CLIENT_WORLD_DOMINION_TAX_WITHDRAWAL msg = new Mir4ClientEmulator.Network.Packets.Messages.CLIENT_WORLD_DOMINION_TAX_WITHDRAWAL();

            msg.dominion_tid = dominion_tid;
            msg.withdrawal_coin = withdrawal_coin;
            msg.withdrawal_gold = withdrawal_gold;

            byte[] serializedData = Protobuf.Serialize<CLIENT_WORLD_DOMINION_TAX_WITHDRAWAL>(msg);
            return c.m_session.SendProtobuf(Opcodes.CLIENT_WORLD_DOMINION_TAX_WITHDRAWAL, serializedData);
        }

        public static bool CLIENT_GAME_MAIL_RECV_GIFT(Client c, ulong mail_uid)
        {
            Mir4ClientEmulator.Network.Packets.Messages.CLIENT_GAME_MAIL_RECV_GIFT msg = new Mir4ClientEmulator.Network.Packets.Messages.CLIENT_GAME_MAIL_RECV_GIFT();

            msg.mail_uid = mail_uid;

            byte[] serializedData = Protobuf.Serialize<CLIENT_GAME_MAIL_RECV_GIFT>(msg);
            return c.m_session.SendProtobuf(Opcodes.CLIENT_GAME_MAIL_RECV_GIFT, serializedData);
        }
        
        public static bool CLIENT_GAME_GUILD_DONATION(Client c, int cost_type, int cost_value)
        {
            Mir4ClientEmulator.Network.Packets.Messages.CLIENT_GAME_GUILD_DONATION msg = new Mir4ClientEmulator.Network.Packets.Messages.CLIENT_GAME_GUILD_DONATION();

            msg.cost_value = cost_value;
            msg.cost_type = cost_type;

            byte[] serializedData = Protobuf.Serialize<CLIENT_GAME_GUILD_DONATION>(msg);
            return c.m_session.SendProtobuf(Opcodes.CLIENT_GAME_GUILD_DONATION, serializedData);
        }

        public static bool CLIENT_GAME_CHARACTER_SEAL(Client c, string user_address, string nonce, string user_sig, ulong token_id)
        {
            Mir4ClientEmulator.Network.Packets.Messages.CLIENT_GAME_CHARACTER_SEAL msg = new Mir4ClientEmulator.Network.Packets.Messages.CLIENT_GAME_CHARACTER_SEAL();

            msg.user_address = user_address;
            msg.nonce = nonce;
            msg.user_sig = user_sig;
            msg.token_id = token_id;

            byte[] serializedData = Protobuf.Serialize<CLIENT_GAME_CHARACTER_SEAL>(msg);
            return c.m_session.SendProtobuf(Opcodes.CLIENT_GAME_CHARACTER_SEAL, serializedData);
        }

        public static bool CLIENT_GAME_EQUIP_COSTUME(Client c, ulong uid, uint equip_costume_id )
        {
            Mir4ClientEmulator.Network.Packets.Messages.CLIENT_GAME_EQUIP_COSTUME msg = new Mir4ClientEmulator.Network.Packets.Messages.CLIENT_GAME_EQUIP_COSTUME();

            msg.uid = uid;
            msg.equip_costume_id = equip_costume_id;

            byte[] serializedData = Protobuf.Serialize<CLIENT_GAME_EQUIP_COSTUME>(msg);
            return c.m_session.SendProtobuf(Opcodes.CLIENT_GAME_EQUIP_COSTUME, serializedData);
        }

        public static bool CLIENT_GAME_SIEGE_EVE_EVENT_SELECT_CHEERING_TEAM(Client c, int user_event_id, int select_cheering_team, int cheering_count)
        {
            Mir4ClientEmulator.Network.Packets.Messages.CLIENT_GAME_SIEGE_EVE_EVENT_SELECT_CHEERING_TEAM msg = new Mir4ClientEmulator.Network.Packets.Messages.CLIENT_GAME_SIEGE_EVE_EVENT_SELECT_CHEERING_TEAM();

            msg.user_event_id = user_event_id;
            msg.select_cheering_team = select_cheering_team;
            msg.cheering_count = cheering_count;

            byte[] serializedData = Protobuf.Serialize<CLIENT_GAME_SIEGE_EVE_EVENT_SELECT_CHEERING_TEAM>(msg);
            return c.m_session.SendProtobuf(Opcodes.CLIENT_GAME_SIEGE_EVE_EVENT_SELECT_CHEERING_TEAM, serializedData);
        }
        public static bool CLIENT_GAME_CHANGE_ROOM_IN_MAGIC_SQUARE(Client c)
        {
            Mir4ClientEmulator.Network.Packets.Messages.CLIENT_GAME_CHANGE_ROOM_IN_MAGIC_SQUARE msg = new Mir4ClientEmulator.Network.Packets.Messages.CLIENT_GAME_CHANGE_ROOM_IN_MAGIC_SQUARE();

            byte[] serializedData = Protobuf.Serialize<CLIENT_GAME_CHANGE_ROOM_IN_MAGIC_SQUARE>(msg);
            return c.m_session.SendProtobuf(Opcodes.CLIENT_GAME_CHANGE_ROOM_IN_MAGIC_SQUARE, serializedData);
        }

        public static bool CLIENT_GAME_LEAVE_MAGIC_SQUARE(Client c)
        {
            Mir4ClientEmulator.Network.Packets.Messages.CLIENT_GAME_LEAVE_MAGIC_SQUARE msg = new Mir4ClientEmulator.Network.Packets.Messages.CLIENT_GAME_LEAVE_MAGIC_SQUARE();

            byte[] serializedData = Protobuf.Serialize<CLIENT_GAME_LEAVE_MAGIC_SQUARE>(msg);
            return c.m_session.SendProtobuf(Opcodes.CLIENT_GAME_LEAVE_MAGIC_SQUARE, serializedData);
        }

        public static bool CLIENT_GAME_MAGIC_SQUARE_TIME_EXTEND(Client c)
        {
            Mir4ClientEmulator.Network.Packets.Messages.CLIENT_GAME_MAGIC_SQUARE_TIME_EXTEND msg = new Mir4ClientEmulator.Network.Packets.Messages.CLIENT_GAME_MAGIC_SQUARE_TIME_EXTEND();

            byte[] serializedData = Protobuf.Serialize<CLIENT_GAME_MAGIC_SQUARE_TIME_EXTEND>(msg);
            return c.m_session.SendProtobuf(Opcodes.CLIENT_GAME_MAGIC_SQUARE_TIME_EXTEND, serializedData);
        }
        
        public static bool CLIENT_GAME_ENTER_MAGIC_SQUARE(Client c, uint magic_square_id)
        {
            Mir4ClientEmulator.Network.Packets.Messages.CLIENT_GAME_ENTER_MAGIC_SQUARE msg = new Mir4ClientEmulator.Network.Packets.Messages.CLIENT_GAME_ENTER_MAGIC_SQUARE();

            msg.magic_square_id = magic_square_id;

            byte[] serializedData = Protobuf.Serialize<CLIENT_GAME_ENTER_MAGIC_SQUARE>(msg);
            return c.m_session.SendProtobuf(Opcodes.CLIENT_GAME_ENTER_MAGIC_SQUARE, serializedData);
        }

        public static bool CLIENT_GAME_ENTER_SECRET_DUNGEON(Client c, uint enter_secret_dungeon_id)
        {
            Mir4ClientEmulator.Network.Packets.Messages.CLIENT_GAME_ENTER_SECRET_DUNGEON msg = new Mir4ClientEmulator.Network.Packets.Messages.CLIENT_GAME_ENTER_SECRET_DUNGEON();

            msg.enter_secret_dungeon_id = enter_secret_dungeon_id;

            byte[] serializedData = Protobuf.Serialize<CLIENT_GAME_ENTER_SECRET_DUNGEON>(msg);
            return c.m_session.SendProtobuf(Opcodes.CLIENT_GAME_ENTER_SECRET_DUNGEON, serializedData);
        }

        public static bool CLIENT_GAME_LEAVE_SECRET_DUNGEON(Client c)
        {
            Mir4ClientEmulator.Network.Packets.Messages.CLIENT_GAME_ENTER_SECRET_DUNGEON msg = new Mir4ClientEmulator.Network.Packets.Messages.CLIENT_GAME_ENTER_SECRET_DUNGEON();

            byte[] serializedData = Protobuf.Serialize<CLIENT_GAME_ENTER_SECRET_DUNGEON>(msg);
            return c.m_session.SendProtobuf(Opcodes.CLIENT_GAME_ENTER_SECRET_DUNGEON, serializedData);
        }

        public static bool CLIENT_GAME_SECRET_DUNGEON_TIME_EXTEND(Client c)
        {
            Mir4ClientEmulator.Network.Packets.Messages.CLIENT_GAME_SECRET_DUNGEON_TIME_EXTEND msg = new Mir4ClientEmulator.Network.Packets.Messages.CLIENT_GAME_SECRET_DUNGEON_TIME_EXTEND();

            byte[] serializedData = Protobuf.Serialize<CLIENT_GAME_SECRET_DUNGEON_TIME_EXTEND>(msg);
            return c.m_session.SendProtobuf(Opcodes.CLIENT_GAME_SECRET_DUNGEON_TIME_EXTEND, serializedData);
        }
   
        public static bool CLIENT_GAME_HIDE_COSTUME(Client c, ulong uid, uint parts, bool is_hide)
        {
            Mir4ClientEmulator.Network.Packets.Messages.CLIENT_GAME_HIDE_COSTUME msg = new Mir4ClientEmulator.Network.Packets.Messages.CLIENT_GAME_HIDE_COSTUME();

            msg.uid = uid;
            msg.parts = parts;
            msg.is_hide = is_hide;

            byte[] serializedData = Protobuf.Serialize<CLIENT_GAME_HIDE_COSTUME>(msg);
            return c.m_session.SendProtobuf(Opcodes.CLIENT_GAME_HIDE_COSTUME, serializedData);
        }

        public static bool CLIENT_GAME_UNATTENDED_STEP_ATTENDED_PROGRESS(Client c, int event_id, int event_step )
        {
            Mir4ClientEmulator.Network.Packets.Messages.CLIENT_GAME_UNATTENDED_STEP_ATTENDED_PROGRESS msg = new Mir4ClientEmulator.Network.Packets.Messages.CLIENT_GAME_UNATTENDED_STEP_ATTENDED_PROGRESS();

            msg.event_step_number = event_step;
            msg.event_id = event_id;

            byte[] serializedData = Protobuf.Serialize<CLIENT_GAME_UNATTENDED_STEP_ATTENDED_PROGRESS>(msg);
            return c.m_session.SendProtobuf(Opcodes.CLIENT_GAME_UNATTENDED_STEP_ATTENDED_PROGRESS, serializedData);
        }

        public static bool CLIENT_GAME_UPDATE_AWAKEN(Client c, ulong uid)
        {
            Mir4ClientEmulator.Network.Packets.Messages.CLIENT_GAME_UPDATE_AWAKEN msg = new Mir4ClientEmulator.Network.Packets.Messages.CLIENT_GAME_UPDATE_AWAKEN();

            msg.uid = uid;

            byte[] serializedData = Protobuf.Serialize<CLIENT_GAME_UPDATE_AWAKEN>(msg);
            return c.m_session.SendProtobuf(Opcodes.CLIENT_GAME_UPDATE_AWAKEN, serializedData);
        }

        public static bool CLIENT_GAME_CLOSED_TRAINING_UPGRADE(Client c, int status_id)
        {
            Mir4ClientEmulator.Network.Packets.Messages.CLIENT_GAME_CLOSED_TRAINING_UPGRADE msg = new Mir4ClientEmulator.Network.Packets.Messages.CLIENT_GAME_CLOSED_TRAINING_UPGRADE();

            msg.status_id = status_id;

            byte[] serializedData = Protobuf.Serialize<CLIENT_GAME_CLOSED_TRAINING_UPGRADE>(msg);
            return c.m_session.SendProtobuf(Opcodes.CLIENT_GAME_CLOSED_TRAINING_UPGRADE, serializedData);
        }

        public static bool CLIENT_GAME_REQUEST_PARTY_LEAVE(Client c, ulong leave_user_uid, ulong leave_party_uid)
        {
            Mir4ClientEmulator.Network.Packets.Messages.CLIENT_GAME_REQUEST_PARTY_LEAVE msg = new Mir4ClientEmulator.Network.Packets.Messages.CLIENT_GAME_REQUEST_PARTY_LEAVE();

            msg.leave_user_uid = leave_user_uid;
            msg.leave_party_uid = leave_party_uid;

            byte[] serializedData = Protobuf.Serialize<CLIENT_GAME_REQUEST_PARTY_LEAVE>(msg);
            return c.m_session.SendProtobuf(Opcodes.CLIENT_GAME_REQUEST_PARTY_LEAVE, serializedData);
        }
   
        public static void SendWrappedMessage(Client MirClient, ushort msg_opcode, List<string> args)
        {
            switch ((Opcodes)msg_opcode)
            {
                case Opcodes.CLIENT_GAME_BENEDICTION_EVENT_SELECT: //2 params
                    MessageWrapper.CLIENT_GAME_BENEDICTION_EVENT_SELECT(MirClient, Convert.ToInt32(args[0]), Convert.ToInt32(args[1]));
                    break;

                case Opcodes.CLIENT_GAME_QUEST_MOVE_POS:

                    _vector3 v = new _vector3();
                    v.x = Convert.ToSingle(args[1]); v.y = Convert.ToSingle(args[2]); v.z = Convert.ToSingle(args[3]);

                    MessageWrapper.CLIENT_GAME_MOVE_QUEST_POS(MirClient, Convert.ToInt32(args[0]), v);
                    break;

                case Opcodes.CLIENT_GAME_GET_DARKSTEEL_DAILY_SUM:
                    MessageWrapper.CLIENT_GAME_GET_DARKSTEEL_DAILY_SUM(MirClient);
                    break;

                case Opcodes.CLIENT_GAME_SYNC_ROLL:
                    //MessageWrapper.CLIENT_GAME_SYNC_ROLL(MirClient, );
                    break;

                case Opcodes.CLIENT_GAME_CHARACTER_BATTLE_PASS_REWARD:
                    MessageWrapper.CLIENT_GAME_CHARACTER_BATTLE_PASS_REWARD(MirClient, Convert.ToUInt32(args[0]), Convert.ToUInt32(args[1]));
                    break;

                case Opcodes.CLIENT_GAME_EVENT_PROGRESS:
                    MessageWrapper.CLIENT_GAME_EVENT_PROGRESS(MirClient, Convert.ToInt32(args[0]), Convert.ToInt32(args[1]));
                    break;

                case Opcodes.CLIENT_GAME_CREATE_PARTY_REQUEST:
                    MessageWrapper.CLIENT_GAME_CREATE_PARTY_REQUEST(MirClient, MirClient.GameAccount.character_identifier, Convert.ToUInt32(args[0]), Convert.ToUInt32(args[1]), Convert.ToUInt32(args[2]), Convert.ToUInt32(args[3]), args[4], null, Convert.ToUInt32(args[5]));
                    break;

                case Opcodes.CLIENT_GAME_PARTY_INSTANCE_DUNGEON_ENTER:
                    MessageWrapper.CLIENT_GAME_PARTY_INSTANCE_DUNGEON_ENTER(MirClient, MirClient.GameAccount.character_identifier, Convert.ToUInt32(args[0]));
                    break;

                case Opcodes.CLIENT_GAME_GUILD_SHOP_LIST:
                    MessageWrapper.CLIENT_GAME_GUILD_SHOP_LIST(MirClient);
                    break;

                case Opcodes.CLIENT_GAME_GUILD_SHOP_BUY:
                    MessageWrapper.CLIENT_GAME_GUILD_SHOP_BUY(MirClient, Convert.ToInt32(args[0]), Convert.ToInt32(args[1]));
                    break;

                case Opcodes.CLIENT_GAME_START_QUEST:
                    MessageWrapper.CLIENT_GAME_START_QUEST(MirClient, MirClient.GameAccount.character_identifier, Convert.ToInt32(args[0]));
                    break;

                case Opcodes.CLIENT_GAME_QUEST_ACTION:
                    MessageWrapper.CLIENT_GAME_QUEST_ACTION(MirClient, Convert.ToInt32(args[0]), Convert.ToInt32(args[1]), Convert.ToInt32(args[2]));
                    break;

                case Opcodes.CLIENT_GAME_CANCEL_SUBQUEST:
                    MessageWrapper.CLIENT_GAME_CANCEL_SUBQUEST(MirClient, Convert.ToInt32(args[0]));
                    break;

                case Opcodes.CLIENT_GAME_COMPLETE_QUEST:
                    MessageWrapper.CLIENT_GAME_COMPLETE_QUEST(MirClient, Convert.ToInt32(args[0]), Convert.ToInt32(args[1]));
                    break;

                case Opcodes.CLIENT_GAME_END_QUEST:
                    MessageWrapper.CLIENT_GAME_END_QUEST(MirClient, MirClient.GameAccount.character_identifier, Convert.ToInt32(args[0]));
                    break;

                case Opcodes.CLIENT_GAME_NPC_SHOP_DATA:
                    MessageWrapper.CLIENT_GAME_NPC_SHOP_DATA(MirClient, Convert.ToUInt32(args[0]), Convert.ToUInt32(args[1]));
                    break;

                case Opcodes.CLIENT_GAME_WARP_USER:
                    MessageWrapper.CLIENT_GAME_WARP_USER(MirClient, Convert.ToUInt32(args[0]), Convert.ToSingle(args[1]), Convert.ToSingle(args[2]), Convert.ToSingle(args[3]));
                    break;

                case Opcodes.CLIENT_GAME_WARP_PORTAL:
                    MessageWrapper.CLIENT_GAME_WARP_PORTAL(MirClient, MirClient.GameAccount.character_identifier, Convert.ToUInt32(args[0]));
                    break;

                case Opcodes.CLIENT_GAME_WARP_TO_ESCAPE_POS:
                    MessageWrapper.CLIENT_GAME_WARP_TO_ESCAPE_POS(MirClient);
                    break;

                case Opcodes.CLIENT_GAME_WARP_USER_STATE:
                    MessageWrapper.CLIENT_GAME_WARP_USER_STATE(MirClient);
                    break;

                case Opcodes.CLIENT_GAME_WARP_STATE_CHECK:
                    MessageWrapper.CLIENT_GAME_WARP_STATE_CHECK(MirClient, MirClient.GameAccount.character_identifier);
                    break;

                case Opcodes.CLIENT_GAME_WAITING_ZONE_WARP:
                    MessageWrapper.CLIENT_GAME_WAITING_ZONE_WARP(MirClient, MirClient.GameAccount.character_identifier, Convert.ToUInt64(args[0]), Convert.ToUInt32(args[1]));
                    break;

                case Opcodes.CLIENT_GAME_INSTANCE_ZONE_OUT:
                    MessageWrapper.CLIENT_GAME_INSTANCE_ZONE_OUT(MirClient, MirClient.GameAccount.character_identifier, Convert.ToInt32(args[0]));
                    break;

                case Opcodes.CLIENT_GAME_ENTER_INVINCIBLE_STATE:
                    MessageWrapper.CLIENT_GAME_ENTER_INVINCIBLE_STATE(MirClient, MirClient.GameAccount.character_identifier);
                    break;

                case Opcodes.CLIENT_WORLD_PARTY_ADVERTISING:
                    MessageWrapper.CLIENT_WORLD_PARTY_ADVERTISING(MirClient);
                    break;

                case Opcodes.CLIENT_GAME_MAIL_PACK_SEND:
                    MessageWrapper.CLIENT_GAME_MAIL_PACK_SEND(MirClient, MirClient.GameAccount.character_identifier, "Hello!", "CatTrainee", "You suck");
                    break;

                case Opcodes.CLIENT_GAME_MAIL_LIST:
                    MessageWrapper.CLIENT_GAME_MAIL_LIST(MirClient);
                    break;

                case Opcodes.CLIENT_GAME_VEHICLE_UNLOCK:
                    MessageWrapper.CLIENT_GAME_VEHICLE_UNLOCK(MirClient, Convert.ToInt32(args[0]));
                    break;

                case Opcodes.CLIENT_GAME_VEHICLE_RIDE_ON_OFF:
                    MessageWrapper.CLIENT_GAME_VEHICLE_RIDE_ON_OFF(MirClient, MirClient.Bot.Position, Convert.ToBoolean(args[0]));
                    break;

                case Opcodes.CLIENT_GAME_START_CASTING:
                    MessageWrapper.CLIENT_GAME_START_CASTING(MirClient, MirClient.GameAccount.character_identifier, Convert.ToInt32(args[0]), Convert.ToUInt64(args[1]), Convert.ToUInt32(args[2]), Convert.ToUInt32(args[3]), false );
                    break;

                case Opcodes.CLIENT_GAME_QUEST_NPC_TALK:
                    MessageWrapper.CLIENT_GAME_QUEST_NPC_TALK(MirClient, Convert.ToInt32(args[0]));
                    break;

                case Opcodes.CLIENT_GAME_START_QUEST_CINEMATIC:
                    MessageWrapper.CLIENT_GAME_START_QUEST_CINEMATIC(MirClient, Convert.ToInt32(args[0]), Convert.ToInt32(args[1]), Convert.ToInt32(args[2]));
                    break;

                case Opcodes.CLIENT_GAME_START_PHASING_QUEST:
                    MessageWrapper.CLIENT_GAME_START_PHASING_QUEST(MirClient, Convert.ToInt32(args[0]));
                    break;

                case Opcodes.CLIENT_GAME_END_PHASING_QUEST:
                    //_vector3 _v = new _vector3(Convert.ToSingle(args[0]), Convert.ToSingle(args[1]), Convert.ToSingle(args[2]));
                    MessageWrapper.CLIENT_GAME_END_PHASING_QUEST(MirClient, Convert.ToInt32(args[0]), MirClient.Bot.Position, Convert.ToInt32(args[1]), Convert.ToInt32(args[2]));
                    break;

                case Opcodes.CLIENT_GAME_COMMIT_SUBQUEST:
                    MessageWrapper.CLIENT_GAME_COMMIT_SUBQUEST(MirClient, Convert.ToInt32(args[0]), Convert.ToInt32(args[1]));
                    break;

                case Opcodes.CLIENT_GAME_ACCEPT_SUBQUEST:
                    MessageWrapper.CLIENT_GAME_ACCEPT_SUBQUEST(MirClient, Convert.ToInt32(args[0]), Convert.ToInt32(args[1]));
                    break;

                case Opcodes.CLIENT_WORLD_DOMINION_TAX_WITHDRAWAL:
                    MessageWrapper.CLIENT_WORLD_DOMINION_TAX_WITHDRAWAL(MirClient, Convert.ToInt32(args[0]), Convert.ToInt64(args[1]), Convert.ToInt64(args[2]));
                    break;

                case Opcodes.CLIENT_WORLD_DOMINION_PRIZE:
                    MessageWrapper.CLIENT_WORLD_DOMINION_PRIZE(MirClient, Convert.ToUInt32(args[0]), Convert.ToUInt32(args[1]), args[2], Convert.ToUInt64(args[3]));
                    break;

                case Opcodes.CLIENT_GAME_GUILD_DONATION:
                    MessageWrapper.CLIENT_GAME_GUILD_DONATION(MirClient, Convert.ToInt32(args[0]), Convert.ToInt32(args[1]));
                    break;

                case Opcodes.CLIENT_GAME_CHARACTER_SEAL:
                    MessageWrapper.CLIENT_GAME_CHARACTER_SEAL(MirClient, args[0], args[1], args[2], Convert.ToUInt64(args[3]));
                    break;

                case Opcodes.CLIENT_GAME_EQUIP_COSTUME:
                    MessageWrapper.CLIENT_GAME_EQUIP_COSTUME(MirClient, MirClient.GameAccount.character_identifier, Convert.ToUInt32(args[0]));
                    break;

                case Opcodes.CLIENT_GAME_HIDE_COSTUME:
                    MessageWrapper.CLIENT_GAME_HIDE_COSTUME(MirClient, MirClient.GameAccount.character_identifier, Convert.ToUInt32(args[0]), Convert.ToBoolean(args[1]));
                    break;

                case Opcodes.CLIENT_GAME_UNATTENDED_STEP_ATTENDED_PROGRESS:
                    MessageWrapper.CLIENT_GAME_UNATTENDED_STEP_ATTENDED_PROGRESS(MirClient, Convert.ToInt32(args[0]), Convert.ToInt32(args[1]));
                    break;

                case Opcodes.CLIENT_GAME_UPDATE_AWAKEN:
                    MessageWrapper.CLIENT_GAME_UPDATE_AWAKEN(MirClient, MirClient.GameAccount.character_identifier);
                    break;

                case Opcodes.CLIENT_GAME_CHARACTER_BATTLE_PASS_TICKET:
                    MessageWrapper.CLIENT_GAME_CHARACTER_BATTLE_PASS_TICKET(MirClient);
                    break;

                case Opcodes.CLIENT_GAME_CHARACTER_ENERGY_POINT_DATA:
                    MessageWrapper.CLIENT_GAME_CHARACTER_ENERGY_POINT_DATA(MirClient, MirClient.GameAccount.character_identifier);
                    break;

                case Opcodes.CLIENT_GAME_SIEGE_EVE_EVENT_SELECT_CHEERING_TEAM:
                    MessageWrapper.CLIENT_GAME_SIEGE_EVE_EVENT_SELECT_CHEERING_TEAM(MirClient, Convert.ToInt32(args[0]), Convert.ToInt32(args[1]), Convert.ToInt32(args[2]));
                    break;

                case Opcodes.CLIENT_WORLD_SEARCH:
                    MessageWrapper.CLIENT_WORLD_SEARCH(MirClient, Convert.ToInt32(args[0]), Convert.ToInt32(args[1]), args[2], Convert.ToInt32(args[3]), Convert.ToInt32(args[4]), Convert.ToInt32(args[5]));
                    break;

                case Opcodes.CLIENT_GAME_GUILD_GIFT_OPEN:
                    MessageWrapper.CLIENT_GAME_GUILD_GIFT_OPEN(MirClient, Convert.ToUInt32(args[0]), Convert.ToUInt64(args[1]));
                    break;

                case Opcodes.CLIENT_GAME_GUILD_GIFT_LIST:
                    MessageWrapper.CLIENT_GAME_GUILD_GIFT_LIST(MirClient, Convert.ToUInt32(args[0]));
                    break;

                case Opcodes.CLIENT_GAME_MAIL_RECV_GIFT:
                    MessageWrapper.CLIENT_GAME_MAIL_RECV_GIFT(MirClient, Convert.ToUInt64(args[0]));
                    break;

                case Opcodes.CLIENT_GAME_CHANGE_ROOM_IN_MAGIC_SQUARE:
                    MessageWrapper.CLIENT_GAME_CHANGE_ROOM_IN_MAGIC_SQUARE(MirClient);
                    break;

                case Opcodes.CLIENT_GAME_LEAVE_MAGIC_SQUARE:
                    MessageWrapper.CLIENT_GAME_LEAVE_MAGIC_SQUARE(MirClient);
                    break;

                case Opcodes.CLIENT_GAME_ENTER_MAGIC_SQUARE:
                    MessageWrapper.CLIENT_GAME_ENTER_MAGIC_SQUARE(MirClient, Convert.ToUInt32(args[0]));
                    break;

                case Opcodes.CLIENT_GAME_MAGIC_SQUARE_TIME_EXTEND:
                    MessageWrapper.CLIENT_GAME_MAGIC_SQUARE_TIME_EXTEND(MirClient);
                    break;

                case Opcodes.CLIENT_GAME_ENTER_SECRET_DUNGEON:
                    MessageWrapper.CLIENT_GAME_ENTER_SECRET_DUNGEON(MirClient, Convert.ToUInt32(args[0]));
                    break;

                case Opcodes.CLIENT_GAME_LEAVE_SECRET_DUNGEON:
                    MessageWrapper.CLIENT_GAME_LEAVE_SECRET_DUNGEON(MirClient);
                    break;

                case Opcodes.CLIENT_GAME_SECRET_DUNGEON_TIME_EXTEND:
                    MessageWrapper.CLIENT_GAME_SECRET_DUNGEON_TIME_EXTEND(MirClient);
                    break;

                case Opcodes.CLIENT_GAME_END_LOADING:
                    MessageWrapper.CLIENT_GAME_END_LOADING(MirClient);
                    break;

                case Opcodes.CLIENT_GAME_CLOSED_TRAINING_UPGRADE:
                    MessageWrapper.CLIENT_GAME_ENTER_SECRET_DUNGEON(MirClient, Convert.ToUInt32(args[0]));
                    break;

                case Opcodes.CLIENT_GAME_EQUIP_COSTUME_NEW:
                    MessageWrapper.CLIENT_GAME_EQUIP_COSTUME_NEW(MirClient, MirClient.GameAccount.character_identifier, Convert.ToUInt32(args[0]));
                    break;

                case Opcodes.CLIENT_GAME_EQUIP_LUXURY_COSTUME:
                    MessageWrapper.CLIENT_GAME_EQUIP_LUXURY_COSTUME(MirClient, Convert.ToUInt64(args[0]));
                    break;

                case Opcodes.CLIENT_GAME_GACHA_PULL:
                    MessageWrapper.CLIENT_GAME_GACHA_PULL(MirClient, Convert.ToUInt32(args[0]), Convert.ToUInt32(args[1]), Convert.ToUInt32(args[2]), Convert.ToBoolean(args[3]), Convert.ToUInt32(args[4]), Convert.ToUInt32(args[5]));
                    break;

                case Opcodes.CLIENT_GAME_UI_SHOP_BUYITEM:
                    MessageWrapper.CLIENT_GAME_UI_SHOP_BUYITEM(MirClient, Convert.ToUInt32(args[0]), Convert.ToUInt32(args[1]), Convert.ToInt32(args[2]));
                    break;

                case Opcodes.CLIENT_WORLD_UNSEALING_LIST:
                    MessageWrapper.CLIENT_WORLD_UNSEALING_LIST(MirClient);
                    break;

                case Opcodes.CLIENT_WORLD_UNSEALING_GET:
                    MessageWrapper.CLIENT_WORLD_UNSEALING_GET(MirClient, Convert.ToInt32(args[0]));
                    break;

                case Opcodes.CLIENT_GAME_UNSEALING_GET_ALL:
                    MessageWrapper.CLIENT_GAME_UNSEALING_GET_ALL(MirClient);
                    break;

                //case Opcodes.CLIENT_GAME_COSTUME_LIST:
                //    MessageWrapper.CLIENT_GAME_COSTUME_LIST(MirClient);
                //    break;

                case Opcodes.CLIENT_GAME_CHATMSG:
                    MessageWrapper.CLIENT_GAME_CHATMSG(MirClient, args[1], Convert.ToInt32(args[0]), Convert.ToBoolean(args[2]));
                    break;

                case Opcodes.CLIENT_WORLD_INSTANCE_DUNGEON_ENTER:
                    MessageWrapper.CLIENT_WORLD_INSTANCE_DUNGEON_ENTER(MirClient, MirClient.GameAccount.character_identifier, Convert.ToUInt32(args[0]), Convert.ToBoolean(args[1]));
                    break;

                case Opcodes.CLIENT_GAME_ITEM_COMPOSE_POINT_REWARD:
                    int[] fail_list_type = new int[1];
                    fail_list_type[0] = Convert.ToInt32(args[0]);
                    MessageWrapper.CLIENT_GAME_ITEM_COMPOSE_POINT_REWARD(MirClient, fail_list_type);
                    break;

                case Opcodes.CLIENT_WORLD_UNSEALING_ACCELERATE_POINT:
                    MessageWrapper.CLIENT_WORLD_UNSEALING_ACCELERATE_POINT(MirClient, Convert.ToInt32(args[0]), Convert.ToInt32(args[1]), Convert.ToInt32(args[2]));
                    break;

                case Opcodes.CLIENT_GAME_DUNGEON_SHOP_BUY:
                    MessageWrapper.CLIENT_GAME_DUNGEON_SHOP_BUY(MirClient, Convert.ToInt32(args[0]), Convert.ToInt32(args[1]), Convert.ToInt32(args[2]));
                    break;

                case Opcodes.CLIENT_GAME_REQUEST_PARTY_LEAVE:
                    MessageWrapper.CLIENT_GAME_REQUEST_PARTY_LEAVE(MirClient, Convert.ToUInt64(args[0]), Convert.ToUInt64(args[1]));
                    break;

                default:
                    Console.WriteLine("[ERROR] No opcode found with such name");
                    break;
            };
        }

    }
}
