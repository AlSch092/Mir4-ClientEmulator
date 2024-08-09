//By AlSch092 @ Github
﻿using Mir4ClientEmulator.Network;
using Mir4ClientEmulator.Network.Packets;
using Mir4ClientEmulator.Network.Packets.Messages;
using Mir4ClientEmulator.Utilities;
using System;
using System.Threading;


namespace Mir4ClientEmulator.Context
{
    public sealed class GameContext : CBase
    {
        private const int header_len = 17;
        private const int data_offset = 15;

        private bool is_first_spawn = true;

        public GameContext(Client client, Session session)
            : base(client, session)
        {
            Console.WriteLine("Created GameContext.");

            if (client.GameAccount.UniqueLoginKey.Length > 0)
            {
                client.m_session.SendPacket(Factory.CLIENT_GAME_AUTH(client.GameAccount.PlayerKey, client.GameAccount.account_uid, "pc", client.GameAccount.UniqueLoginKey));      
            }

            if(client.stuckStageThread != null)
            {
                client.stuckStageThread.Abort();
            }
        }

        public void SendHeartbeat()
        {
            while (Client.m_session.Connected)
            {
                Console.WriteLine("Sending heartbeat...");
                MessageWrapper.CLIENT_GAME_HEARTBEAT(Client);
                Thread.Sleep(30000);
            }
        }

        public void HandleReadyInGame() //can trigger from moving maps too..
        {
            if (is_first_spawn)
            {
                Client.HeartbeatWorker = new Thread(new ThreadStart(SendHeartbeat));
                Client.HeartbeatWorker.Start();

                is_first_spawn = false;
            }

            Thread.Sleep(500);
            MessageWrapper.CLIENT_GAME_CHARACTER_INVEN(Client, Client.GameAccount.character_identifier);
            Thread.Sleep(500);
            MessageWrapper.CLIENT_GAME_CHARACTER_QUICKSLOT_DATA(Client, Client.GameAccount.character_identifier);
            Thread.Sleep(500);
            MessageWrapper.CLIENT_GAME_QUEST_RELATION_DATA(Client, Client.GameAccount.character_identifier);
            Thread.Sleep(500);
            MessageWrapper.CLIENT_GAME_CHARACTER_ENERGY_POINT_DATA(Client, Client.GameAccount.character_identifier);
            Thread.Sleep(500);
            MessageWrapper.CLIENT_GAME_CHARACTER_QUEST(Client, Client.GameAccount.character_identifier);
            Thread.Sleep(500);
            MessageWrapper.CLIENT_GAME_CHARACTER_SKILL(Client, Client.GameAccount.character_identifier);//get skill list
            
            Client.ReadyInGame = true;
        }

        public override void HandleConnected()
        {
            Console.WriteLine("Connected to game server!!");
        }

        public override void HandleDisconnected(bool byChoice)
        {
            if (!byChoice)
            {
                Console.WriteLine("Remote server disconnected the client. Please reconnect.");
                Client.UIMessages.Enqueue("[WARNING] Forcefully disconnected from the GAME server.");
            }
            else
            {
                Console.WriteLine("User disconnected from the game server.");
                Client.UIMessages.Enqueue("[INFO] User disconnected from GAME server.");
            }

            if (Client.m_GameSocket != null)
                if (Client.m_GameSocket.Connected)
                    Client.m_session.Disconnect();

            Client.Bot.Reset(Client.Bot.AutoGathering);

            if (Client.Bot.EntityList != null)
                Client.Bot.EntityList.Clear();
            
            if(Client.Bot.CharacterIds != null)
                Client.Bot.CharacterIds.Clear(); //clear charname -> id list

            if (Client.Bot.PlayerInventory != null)
                Client.Bot.PlayerInventory.Clear();

            if (Client.Bot.QuickSlot != null)
                Client.Bot.QuickSlot.Clear();

            if(Client.HeartbeatWorker != null)
            {
                Client.HeartbeatWorker.Abort();
                Client.HeartbeatWorker = null;
            }

            is_first_spawn = true;
            Client.ReadyInGame = false;

            if (Client.AutoReconnect)
            {
                Thread.Sleep(10000);
                Client.Migrate(Client.FrontServerIP, Client.FrontServerPort, true);
            }
        }

        public override void HandlePacket(Reader packet)
        {
            int length = packet.ReadInt();
            byte recvFlag = packet.ReadByte();
            ushort opcode = packet.ReadUShort();

            string named_opcode = FileHelper.GetNamedOpcode("Data/opcodes.proto", opcode);

            packet.Skip(10); //timestamp + 2byte flags

            byte[] packet_data = packet.ReadBytes(packet.Length - header_len - data_offset);

            //if (named_opcode.Length > 0)
            //    Console.WriteLine("Received Opcode: {0}", named_opcode);
            //else
            //    Console.WriteLine("Received UNKNOWN opcode: 0x" + opcode.ToString("X4"));

            switch ((Opcodes)opcode)
            {
                case Opcodes.GAME_CLIENT_AUTH:
                    GameServerHandler.GAME_CLIENT_AUTH(this, packet);
                    break;

                case Opcodes.LOBBY_CLIENT_CHARACTER_LIST_ALL:
                    GameServerHandler.LOBBY_CLIENT_CHARACTER_LIST_ALL(this, packet_data);
                    break;

                case Opcodes.GAME_CLIENT_GAME_OPTION_LIST:
                    GameServerHandler.GAME_CLIENT_GAME_OPTION_LIST(this, packet_data);
                    break;

                case Opcodes.WORLD_CLIENT_SELECT_CHARACTER:
                    GameServerHandler.WORLD_CLIENT_SELECT_CHARACTER(this, packet_data);
                    break;

                case Opcodes.GAME_CLIENT_BENEDICTION_EVENT_SELECT:
                    GameServerHandler.GAME_CLIENT_BENEDICTION_EVENT_SELECT(this, packet_data);
                    break;

                case Opcodes.GAME_CLIENT_QUEST_NPC_TALK:
                    GameServerHandler.GAME_CLIENT_QUEST_NPC_TALK(this, packet_data);
                    break;

                case Opcodes.GAME_CLIENT_CHARACTER_ENERGY_POINT_DATA:
                    GameServerHandler.GAME_CLIENT_CHARACTER_ENERGY_POINT_DATA(this, packet_data);
                    break;

                case Opcodes.GAME_CLIENT_MEDITATION_ADD_ENERGYPOINT:
                    GameServerHandler.GAME_CLIENT_MEDITATION_ADD_ENERGYPOINT(this, packet_data);
                    break;

                case Opcodes.GAME_CLIENT_WARP_START: //migration
                    GameServerHandler.GAME_CLIENT_WARP_START(this, packet_data);
                    break;

                case Opcodes.GAME_CLIENT_WARP_READY:
                    GameServerHandler.GAME_CLIENT_WARP_READY(this, packet_data);
                    break;

                case Opcodes.WORLD_CLIENT_GUILD_MEMBER_LIST:
                    GameServerHandler.WORLD_CLIENT_GUILD_MEMBER_LIST(this, packet_data);
                    break;

                case Opcodes.GAME_CLIENT_GUILD_GIFT_LIST:
                    GameServerHandler.GAME_CLIENT_GUILD_GIFT_LIST(this, packet_data);
                    break;

                case Opcodes.GAME_CLIENT_ITEM_RANDOM_EXCHANGE:
                    GameServerHandler.GAME_CLIENT_ITEM_RANDOM_EXCHANGE(this, packet_data);
                    break;

                case Opcodes.GAME_CLIENT_GREAT_BUILDING_INFO:
                    GameServerHandler.GAME_CLIENT_GREAT_BUILDING_INFO(this, packet_data);
                    break;

                case Opcodes.GAME_CLIENT_GET_DARKSTEEL_DAILY_SUM:
                    GameServerHandler.GAME_CLIENT_GET_DARKSTEEL_DAILY_SUM(this, packet_data);
                    break;

                case Opcodes.GAME_WORLD_ENTER_MAGIC_SQUARE:
                    GameServerHandler.GAME_WORLD_ENTER_MAGIC_SQUARE(this, packet_data);
                    break;

                case Opcodes.GAME_CLIENT_CHARACTER_QUEST:
                    GameServerHandler.GAME_CLIENT_CHARACTER_QUEST(this, packet_data);
                    break;

                case Opcodes.GAME_CLIENT_CHARACTER_SUB_QUEST:
                    GameServerHandler.GAME_CLIENT_CHARACTER_SUB_QUEST(this, packet_data);
                    break;

                case Opcodes.GAME_CLIENT_QUEST_ACTION_RESULT:
                    GameServerHandler.GAME_CLIENT_QUEST_ACTION_RESULT(this, packet_data);
                    break;

                case Opcodes.GAME_CLIENT_START_QUEST:
                    GameServerHandler.GAME_CLIENT_START_QUEST(this, packet_data);
                    break;

                case Opcodes.GAME_CLIENT_END_QUEST:
                    GameServerHandler.GAME_CLIENT_END_QUEST(this, packet_data);
                    break;

                case Opcodes.GAME_CLIENT_CANCEL_SUBQUEST:
                    GameServerHandler.GAME_CLIENT_CANCEL_SUBQUEST(this, packet_data);
                    break;

                case Opcodes.GAME_CLIENT_CHANGE_QUEST_COUNTER:
                    GameServerHandler.GAME_CLIENT_CHANGE_QUEST_COUNTER(this, packet_data);
                    break;

                case Opcodes.GAME_CLIENT_UPDATE_QUEST:
                    GameServerHandler.GAME_CLIENT_UPDATE_QUEST(this, packet_data);
                    break;

                case Opcodes.GAME_CLIENT_COMPLETE_QUEST:
                    GameServerHandler.GAME_CLIENT_COMPLETE_QUEST(this, packet_data);
                    break;

                case Opcodes.GAME_CLIENT_QUEST_RELATION_DATA:
                    GameServerHandler.GAME_CLIENT_QUEST_RELATION_DATA(this, packet_data);
                    break;

                case Opcodes.GAME_CLIENT_DELETE_QUEST:
                    GameServerHandler.GAME_CLIENT_DELETE_QUEST(this, packet_data);
                    break;

                case Opcodes.GAME_CLIENT_ADD_SUBQUEST:
                    GameServerHandler.GAME_CLIENT_ADD_SUBQUEST(this, packet_data);
                    break;

                case Opcodes.GAME_CLIENT_ENDQUEST_GUILD_DAILY_MISSION:
                    GameServerHandler.GAME_CLIENT_ENDQUEST_GUILD_DAILY_MISSION(this, packet_data);
                    break;

                case Opcodes.GAME_CLIENT_REWARD_GUILD_GIFT:
                    GameServerHandler.GAME_CLIENT_REWARD_GUILD_GIFT(this, packet_data);
                    break;

                case Opcodes.GAME_CLIENT_GUILD_DAILY_MISSION_DATA:
                    GameServerHandler.GAME_CLIENT_GUILD_DAILY_MISSION_DATA(this, packet_data);
                    break;

                //case Opcodes.GAME_CLIENT_GUILD_COST

                case Opcodes.GAME_CLIENT_NOTIFY_DUNGEON_CLEAR_LIST:
                    GameServerHandler.GAME_CLIENT_NOTIFY_DUNGEON_CLEAR_LIST(this, packet_data);
                    break;

                case Opcodes.GAME_CLIENT_CHARACTER_MAP_WAYPOINT_DATA:
                    GameServerHandler.GAME_CLIENT_CHARACTER_MAP_WAYPOINT_DATA(this, packet_data);
                    break;

                case Opcodes.GAME_CLIENT_SMELTING_ITEM:
                    GameServerHandler.GAME_CLIENT_SMELTING_ITEM(this, packet_data);
                    break;

                case Opcodes.GAME_CLIENT_CHANNEL_INFO:
                    GameServerHandler.GAME_CLIENT_CHANNEL_INFO(this, packet_data);
                    break;

                case Opcodes.GAME_CLIENT_COMMIT_SUBQUEST:
                    GameServerHandler.GAME_CLIENT_COMMIT_SUBQUEST(this, packet_data);
                    break;

                case Opcodes.GAME_CLIENT_CHARACTER_PLAY_DATA:
                    GameServerHandler.GAME_CLIENT_CHARACTER_PLAY_DATA(this, packet_data);
                    break;
                    
                case Opcodes.GAME_CLIENT_NPC_SHOP_DATA:
                    GameServerHandler.GAME_CLIENT_NPC_SHOP_DATA(this, packet_data);
                    break;

                case Opcodes.GAME_CLIENT_NPC_SHOP_BUY:
                    GameServerHandler.GAME_CLIENT_NPC_SHOP_BUY(this, packet_data);
                    break;

                case Opcodes.GAME_CLIENT_GUILD_SHOP_LIST:
                    GameServerHandler.GAME_CLIENT_GUILD_SHOP_LIST(this, packet_data);
                    break;

                case Opcodes.GAME_CLIENT_GUILD_SHOP_BUY:
                    GameServerHandler.GAME_CLIENT_GUILD_SHOP_BUY(this, packet_data);
                    break;
                 
                case Opcodes.GAME_CLIENT_BUFF_LIST:
                    GameServerHandler.GAME_CLIENT_BUFF_LIST(this, packet_data);
                    break;

                case Opcodes.GAME_CLIENT_CHARACTER_MASTERY_DATA:
                    GameServerHandler.GAME_CLIENT_CHARACTER_MASTERY_DATA(this, packet_data);
                    break;

                case Opcodes.GAME_CLIENT_LEVEL_UP:
                    GameServerHandler.GAME_CLIENT_LEVEL_UP(this, packet_data);
                    break;

                case Opcodes.GAME_CLIENT_BATTLE_STATE:
                    GameServerHandler.GAME_CLIENT_BATTLE_STATE(this, packet_data);
                    break;

                case Opcodes.GAME_CLIENT_REVIVAL_RESULT:
                    GameServerHandler.GAME_CLIENT_REVIVAL_RESULT(this, packet_data);
                    break;

                case Opcodes.GAME_CLIENT_BROADCAST_REVIVAL:
                    GameServerHandler.GAME_CLIENT_BROADCAST_REVIVAL(this, packet_data);
                    break;

                case Opcodes.GAME_CLIENT_GUILD_GIFT_OPEN:
                    GameServerHandler.GAME_CLIENT_GUILD_GIFT_OPEN(this, packet_data);
                    break;

                case Opcodes.GAME_CLIENT_SYNC_EVENT_DATA:
                    GameServerHandler.GAME_CLIENT_SYNC_EVENT_DATA(this, packet_data);
                    break;

                case Opcodes.GAME_CLIENT_DESTROY_NPC:
                    GameServerHandler.GAME_CLIENT_DESTROY_NPC(this, packet_data);
                    break;

                case Opcodes.WORLD_CLIENT_NOTIFY_FRIEND_INVITE:
                    GameServerHandler.WORLD_CLIENT_NOTIFY_FRIEND_INVITE(this, packet_data);
                    break;

                case Opcodes.GAME_CLIENT_MAIL_NEW:
                    GameServerHandler.GAME_CLIENT_MAIL_NEW(this, packet_data);
                    break;

                case Opcodes.GAME_CLIENT_CHARACTER_INVEN_START:
                    GameServerHandler.GAME_CLIENT_CHARACTER_INVEN_START(this, packet_data);
                    break;

                case Opcodes.GAME_CLIENT_CHARACTER_INVEN_END:
                    GameServerHandler.GAME_CLIENT_CHARACTER_INVEN_END(this, packet_data);
                    break;

                case Opcodes.GAME_CLIENT_CHARACTER_INVEN_DATA:
                    GameServerHandler.GAME_CLIENT_CHARACTER_INVEN_DATA(this, packet_data);
                    break;

                case Opcodes.GAME_CLIENT_CHARACTER_QUICKSLOT_DATA:
                    GameServerHandler.GAME_CLIENT_CHARACTER_QUICKSLOT_DATA(this, packet_data);
                    break;

                case Opcodes.GATEWAY_CLIENT_UNCHEATER_COOKIE:
                    GameServerHandler.GATEWAY_CLIENT_UNCHEATER_COOKIE(this, packet);
                    break;

                case Opcodes.GAME_CLIENT_SYSTEM_MESSAGE:
                    GameServerHandler.GAME_CLIENT_SYSTEM_MESSAGE(this, packet_data);
                    break;

                case Opcodes.GAME_CLIENT_CHATMSG:
                    GameServerHandler.GAME_CLIENT_CHATMSG(this, packet_data);
                    break;

                case Opcodes.GAME_CLIENT_PARTY_MEMBER_ENTER:
                    GameServerHandler.GAME_CLIENT_PARTY_MEMBER_ENTER(this, packet_data);
                    break;

                //case Opcodes.GAME_CLIENT_HEARTBEAT:
                //    Console.WriteLine("Sending back heartbeat..");
                //    this.Client.m_session.SendPacket(Factory.CLIENT_GAME_HEARTBEAT());
                //    break;

                case Opcodes.GAME_CLIENT_VEHICLE_RIDE_EQUIP:
                    GameServerHandler.GAME_CLIENT_VEHICLE_RIDE_EQUIP(this, packet_data);
                    break;

                case Opcodes.GAME_CLIENT_ERROR:
                    GameServerHandler.GAME_CLIENT_ERROR(this, packet_data);
                    break;

                case Opcodes.GAME_CLIENT_CONTENTS_LOCK_CHANGE:

                    break;

                case Opcodes.GAME_CLIENT_CHARACTER_BATTLE_PASS_CLEAR_DATA:
                    GameServerHandler.GAME_CLIENT_CHARACTER_BATTLE_PASS_CLEAR_DATA(this, packet_data);
                    break;

                case Opcodes.GAME_CLIENT_DELETE_PERIOD_ITEM:

                    break;

                case Opcodes.WORLD_CLIENT_NTF_PLUNDER_INFO:

                    break;

                case Opcodes.GAME_CLIENT_DEBUG_FORCE_SYNC_MONSTER:
                    Console.WriteLine("Got GAME_CLIENT_DEBUG_FORCE_SYNC_MONSTER!");
                    break;

                case Opcodes.GAME_CLIENT_DUNGEON_SHOP_BUY:
                    GameServerHandler.GAME_CLIENT_DUNGEON_SHOP_BUY(this, packet_data);
                    break;

                case Opcodes.GAME_CLIENT_STAT_CONTENTS_LIST:
                    GameServerHandler.GAME_CLIENT_STAT_CONTENTS_LIST(this, packet_data);
                    break;

                case Opcodes.GAME_CLIENT_BOSS_SPAWN:
                    GameServerHandler.GAME_CLIENT_BOSS_SPAWN(this, packet_data);
                    break;

                case Opcodes.GAME_CLIENT_GET_RANKING_REWARD:
                    GameServerHandler.GAME_CLIENT_GET_RANKING_REWARD(this, packet_data);
                    break;

                case Opcodes.GAME_CLIENT_UI_SHOP_BUY:
                    GameServerHandler.GAME_CLIENT_UI_SHOP_BUY(this, packet_data);
                    break;

                case Opcodes.GAME_CLIENT_UI_SHOP_BUYITEM:
                    GameServerHandler.GAME_CLIENT_UI_SHOP_BUYITEM(this, packet_data);
                    break;

                case Opcodes.GAME_CLIENT_EXPBOOSTER_SPEND_END:
                    GameServerHandler.GAME_CLIENT_EXPBOOSTER_SPEND_END(this, packet_data);
                    break;

                case Opcodes.GAME_CLIENT_NOTIFY_CREATE_PARTY:
                    GameServerHandler.GAME_CLIENT_NOTIFY_CREATE_PARTY(this, packet_data);
                    break;

                case Opcodes.GAME_CLIENT_EVENT_PROGRESS:
                    GameServerHandler.GAME_CLIENT_EVENT_PROGRESS(this, packet_data);
                    break;

                case Opcodes.GAME_CLIENT_USER_EVENT_INFO:
                    GameServerHandler.GAME_CLIENT_USER_EVENT_INFO(this, packet_data);
                    break;

                case Opcodes.GAME_CLIENT_SYNC_REWARD_BATTLE_PASS:
                    GameServerHandler.GAME_CLIENT_SYNC_REWARD_BATTLE_PASS(this, packet_data);
                    break;

                case Opcodes.GAME_CLIENT_REWARD_BATTLE_PASS_LIST_RESULT:
                    GameServerHandler.GAME_CLIENT_REWARD_BATTLE_PASS_LIST_RESULT(this, packet_data);
                    break;

                case Opcodes.GAME_CLIENT_NOTIFY_ITEM_GAIN:
                    GameServerHandler.GAME_CLIENT_NOTIFY_ITEM_GAIN(this, packet_data);
                    break;

                case Opcodes.GAME_CLIENT_SKILL_ERROR:
                    GameServerHandler.GAME_CLIENT_SKILL_ERROR(this, packet_data);
                    break;

                case Opcodes.GAME_CLIENT_CHANGE_INFO: //hp, mp, stats update from attacks, etc
                    GameServerHandler.GAME_CLIENT_CHANGE_INFO(this, packet_data); 
                    break;

                case Opcodes.GAME_CLIENT_MAIL_LIST_DATA:
                    GameServerHandler.GAME_CLIENT_MAIL_LIST_DATA(this, packet_data);
                    break;

                case Opcodes.GAME_CLIENT_GACHA_PULL:
                    GameServerHandler.GAME_CLIENT_GACHA_PULL(this, packet_data);
                    break;

                case Opcodes.GAME_CLIENT_GACHA_PULL_EVENT:
                    GameServerHandler.GAME_CLIENT_GACHA_PULL_EVENT(this, packet_data);
                    break;

                case Opcodes.GAME_CLIENT_ITEM_COMPOSE_POINT_REWARD:
                    GameServerHandler.GAME_CLIENT_ITEM_COMPOSE_POINT_REWARD(this, packet_data);
                    break;

                case Opcodes.GAME_CLIENT_PK_TRACEABLILITY_CHECK:
                    GameServerHandler.GAME_CLIENT_PK_TRACEABLILITY_CHECK(this, packet_data);
                    break;

                case Opcodes.WORLD_CLIENT_UNSEALING_SUPPORT_REGISTER:
                    GameServerHandler.WORLD_CLIENT_UNSEALING_SUPPORT_REGISTER(this, packet_data);
                    break;

                case Opcodes.WORLD_CLIENT_UNSEALING_SUPPORT_REGISTER_NOTICE:
                    GameServerHandler.WORLD_CLIENT_UNSEALING_SUPPORT_REGISTER_NOTICE(this, packet_data);
                    break;

                case Opcodes.GAME_CLIENT_UNSEALING_REGISTER_COMPLETE:
                    GameServerHandler.GAME_CLIENT_UNSEALING_REGISTER_COMPLETE(this, packet_data);
                    break;

                case Opcodes.GAME_CLIENT_UNSEALING_REGISTER:
                    GameServerHandler.GAME_CLIENT_UNSEALING_REGISTER(this, packet_data);
                    break;

                case Opcodes.GAME_CLIENT_UNSEALING_GET:
                    GameServerHandler.GAME_CLIENT_UNSEALING_GET(this, packet_data);
                    break;

                case Opcodes.GAME_CLIENT_UNSEALING_GET_ALL:
                    GameServerHandler.GAME_CLIENT_UNSEALING_GET_ALL(this, packet_data);
                    break;
                    
                case Opcodes.GAME_CLIENT_ATTACK_NPC: //npc attacks us
                    GameServerHandler.GAME_CLIENT_ATTACK_NPC(this, packet_data);
                    break;

                case Opcodes.GAME_CLIENT_PAINTING_EVENT_PROCESS:
                    GameServerHandler.GAME_CLIENT_PAINTING_EVENT_PROCESS(this, packet_data);
                    break;

                //30 75 2E 03 30 79 00 00 00 00 00 00 08 AE 86 C0 C9 07 10 7F 22 06 08 02 10 9E A7 07 22 05 08 14 10 98 04 2A 12 08 80 80 88 A9 C7 A4 A4 BF 13 10 91 B4 CF F6 01 20 06 2A 12 08 81 80 88 A9 C7 BD E2 B9 13 10 92 B4 CF F6 01 20 11 2A 12 08 81 80 88 A9 C7 D4 A3 BF 13 10 E4 BF 92 9C 05 20 03 2A 12 08 80 80 90 A9 C7 81 BA C2 13 10 EE BF 92 9C 05 20 01 2A 12 08 80 80 88 A9 87 F5 A2 BF 13 10 F8 BF 92 9C 05 20 08 2A 12 08 81 80 90 A9 C7 81 BA C2 13 10 82 C0 92 9C 05 20 01 2A 12 08 82 80 90 A9 C7 81 BA C2 13 10 C2 88 AA F2 01 20 02 2A 12 08 83 80 90 A9 C7 81 BA C2 13 10 86 F8 DC AD 03 20 01 30 81 CE FE A6 01 
                case Opcodes.GAME_CLIENT_ACTIVATE_OBJECT_REWARD:
                    GameServerHandler.GAME_CLIENT_ACTIVATE_OBJECT_REWARD(this, packet_data);
                    break;

                case Opcodes.GAME_CLIENT_SYNC_USER:
                    GameServerHandler.GAME_CLIENT_SYNC_USER(this, packet_data);
                    break;

                //EA 57 00 00 00 00 00 00 00 00 00 01 08 30 10 03 22 0F 0D 1C 41 A9 C3 15 2A 16 CD 45 1D 49 0E CD C4 40 98 01 5A 0F 0D D9 10 97 C4 15 37 30 D1 45 1D 90 E9 CD C4 70 12 
                case Opcodes.GAME_CLIENT_SYNCNPC: //monster movement too!
                    GameServerHandler.GAME_CLIENT_SYNCNPC(this, packet_data);
                    break;

                case Opcodes.GAME_CLIENT_APPEAR_NPC:
                    GameServerHandler.GAME_CLIENT_APPEAR_NPC(this, packet_data);
                    break;

                case Opcodes.GAME_CLIENT_APPEAR_USER:
                    GameServerHandler.GAME_CLIENT_APPEAR_USER(this, packet_data);
                    break;

                case Opcodes.GAME_CLIENT_STRUCK:
                    GameServerHandler.GAME_CLIENT_STRUCK(this, packet_data);
                    break;

                case Opcodes.GAME_CLIENT_ATTACK:
                    GameServerHandler.GAME_CLIENT_ATTACK(this, packet_data);
                    break;

                case Opcodes.CLIENT_GAME_CHARACTER_ACHIEVEMENT_CLEAR_REWARD:
                    GameServerHandler.CLIENT_GAME_CHARACTER_ACHIEVEMENT_CLEAR_REWARD(this, packet_data);
                    break;

                case Opcodes.GAME_CLIENT_DISAPPEAR_ENTITY:
                    GameServerHandler.GAME_CLIENT_DISAPPEAR_ENTITY(this, packet_data);
                    break;

                case Opcodes.GAME_CLIENT_START_CASTING: //mining, gathering
                    GameServerHandler.GAME_CLIENT_START_CASTING(this, packet_data);
                    break;

                case Opcodes.GAME_CLIENT_CASTING_SUCCESS:
                    GameServerHandler.GAME_CLIENT_CASTING_SUCCESS(this, packet_data);
                    break;

                case Opcodes.GAME_CLIENT_CANCEL_CASTING:
                    GameServerHandler.GAME_CLIENT_CANCEL_CASTING(this, packet_data);
                    break;

                case Opcodes.GAME_CLIENT_CASTING_FAIL:
                    GameServerHandler.GAME_CLIENT_CASTING_FAIL(this, packet_data);
                    break;

                case Opcodes.GAME_CLIENT_PARTY_INVITE_REQUEST:
                    GameServerHandler.GAME_CLIENT_PARTY_INVITE_REQUEST(this, packet_data);
                    break;

                case Opcodes.GAME_CLIENT_END_LOADING:
                    GameServerHandler.GAME_CLIENT_END_LOADING(this, packet_data);
                    break;

                case Opcodes.GAME_CLIENT_SKILL_NOT_EXIST_TARGET_LIST:
                    GameServerHandler.GAME_CLIENT_SKILL_NOT_EXIST_TARGET_LIST(this, packet_data);
                    break;

                case Opcodes.GAME_CLIENT_SYNC_PLAY_DATA:
                    GameServerHandler.GAME_CLIENT_SYNC_PLAY_DATA(this, packet_data);
                    break;

                case Opcodes.GAME_CLIENT_DROP_ITEM:
                    GameServerHandler.GAME_CLIENT_DROP_ITEM(this, packet_data);
                    break;

                case Opcodes.GAME_CLIENT_GAIN_EXP:
                    GameServerHandler.GAME_CLIENT_GAIN_EXP(this, packet_data);
                    break;

                case Opcodes.GAME_CLIENT_CHARACTER_SKILL:
                    GameServerHandler.GAME_CLIENT_CHARACTER_SKILL(this, packet_data);
                    break;

                case Opcodes.GAME_CLIENT_BROADCAST_DIE_USER:
                    GameServerHandler.GAME_CLIENT_BROADCAST_DIE_USER(this, packet_data);
                    break;

                case Opcodes.GAME_CLIENT_DIE:
                    GameServerHandler.GAME_CLIENT_DIE(this, packet_data);
                    break;

                case Opcodes.GAME_CLIENT_OBJECT_UPDATE_USE_COUNT:
                    GameServerHandler.GAME_CLIENT_OBJECT_UPDATE_USE_COUNT(this, packet_data);
                    break;

                case Opcodes.GAME_CLIENT_APPEAR_OBJECT: //clean this up
                    GameServerHandler.GAME_CLIENT_APPEAR_OBJECT(this, packet_data);                
                    break;

                case Opcodes.WORLD_CLIENT_DOMINION_TAX_WITHDRAWAL:
                    GameServerHandler.WORLD_CLIENT_DOMINION_TAX_WITHDRAWAL(this, packet_data);
                    break;

                case Opcodes.GAME_CLIENT_GUILD_DONATION:
                    GameServerHandler.GAME_CLIENT_GUILD_DONATION(this, packet_data);
                    break;

                case Opcodes.GAME_CLIENT_EQUIP_COSTUME:
                    GameServerHandler.GAME_CLIENT_EQUIP_COSTUME(this, packet_data);
                    break;

                case Opcodes.GAME_CLIENT_RECONNECT_SYNC:
                    GameServerHandler.GAME_CLIENT_RECONNECT_SYNC(this, packet_data);
                    break;

                case Opcodes.GAME_CLIENT_DISAPPEAR_ENTITY_LIST:
                    GameServerHandler.GAME_CLIENT_DISAPPEAR_ENTITY_LIST(this, packet_data);
                    break;

                default:
                    GameServerHandler.HandleUnknown(this, packet);
                    break;
            }
        }
    }
}
