//By AlSch092 @ Github
﻿using Mir4ClientEmulator.Utilities;
using Mir4ClientEmulator.Game;
using Mir4ClientEmulator.Network.Packets.Messages;

namespace Mir4ClientEmulator.Network.Packets
{
    public static class Factory
    {
        // 36 34 38 62 37 32 31 66 66 62 30 30 32 62 33 64 62 63 34 35 36 61 30 31 1A 02 70 63 22 26 7B 35 34 46 36 38 32 37 45 2D 31 34 39 38 2D 34 33 44 35 2D 38 46 32 45 2D 39 42 41 34 39 31 32 38 44 30 32 38 7D 
        //BA EA 5A BD 82 14 F0 76 07 00 00 00 08 FA 87 F5 E7 03 12 18 36 33 37 62 30 62 62 38 34 62 33 35 35 62 36 62 34 63 35 38 63 64 37 31 1A 02 70 63 22 26 7B 33 43 37 30 31 38 38 45 2D 30 38 46 42 2D 34 33 46 30 2D 42 32 35 35 2D 30 45 38 34 34 33 37 39 39 31 35 46 7D 
        public static Writer CLIENT_GAME_AUTH(string strID, ulong account_uid, string strSDK, string auth_key)
        {
            Writer p = new Writer((ushort)Opcodes.CLIENT_GAME_AUTH);
            p.WriteLong(0); //timestamp
            p.WriteShort(0);

            var payload = new CLIENT_GAME_AUTH();
            payload.account_uid = account_uid;
            payload.strID = strID;
            payload.auth_key = auth_key;
            payload.strSDK = strSDK;

            byte[] serialized_payload = Protobuf.Serialize<CLIENT_GAME_AUTH>(payload);
            
            p.WriteBytes(serialized_payload);

            return p;
        }

        //64 EA 00 00 00 00 00 00 00 00 00 00 0A 18 36 34 38 62 37 32 31 66 66 62 30 30 32 62 33 64 62 63 34 35 36 61 30 31 12 40 38 61 33 39 66 66 30 33 33 33 37 62 64 65 32 38 64 39 64 39 38 64 62 36 63 65 32 39 38 37 36 63 66 61 64 37 32 62 65 62 39 37 65 35 36 33 62 65 31 33 34 33 37 61 64 37 65 32 37 37 32 65 65 36 18 04 22 0C 64 34 35 64 36 34 32 37 37 61 64 31 28 0B
        public static Writer CLIENT_FRONT_SERVICE_AUTH(string player_key, string token_id, Enums.Os os_type, string device, int store_type)
        {
            Writer p = new Writer((ushort)Opcodes.CLIENT_FRONT_SERVICE_AUTH);
            p.WriteLong(0); //timestamp
            p.WriteShort(0);

            var payload = new CLIENT_FRONT_SERVICE_AUTH();
            payload.player_key = player_key;
            payload.token_id = token_id;
            payload.os_type = (int)os_type;
            payload.device = device;
            payload.store_type = store_type;

            byte[] serialized_payload = Protobuf.Serialize<CLIENT_FRONT_SERVICE_AUTH>(payload);
            p.WriteBytes(serialized_payload);        
            return p;
        }

        //53 EB 81 A4 05 00 00 00 00 00 00 00
        public static Writer CLIENT_FRONT_HEARTBEAT()
        {
            Writer p = new Writer((ushort)Opcodes.CLIENT_FRONT_HEARTBEAT);
            p.WriteLong(0);
            p.WriteShort(0);
            return p;
        }

        public static Writer CLIENT_GAME_HEARTBEAT()
        {
            Writer p = new Writer((ushort)Opcodes.CLIENT_GAME_HEARTBEAT);
            p.WriteLong(0);
            p.WriteShort(0);
            return p;
        }

        public static Writer CLIENT_FRONT_SELECT_WORLD(uint worldId)
        {
            Writer p = new Writer((ushort)Opcodes.CLIENT_FRONT_SELECT_WORLD);
            p.WriteLong(0);
            p.WriteShort(0);

            var payload = new CLIENT_FRONT_SELECT_WORLD();
            payload.world_id = worldId;

            byte[] serialized_payload = Protobuf.Serialize<CLIENT_FRONT_SELECT_WORLD>(payload);
            p.WriteBytes(serialized_payload);
            return p;
        }

        public static Writer CLIENT_FRONT_WORLD_CHARACTER_INFO(ulong account_uid)
        {
            Writer p = new Writer((ushort)Opcodes.CLIENT_FRONT_WORLD_CHARACTER_INFO);
            p.WriteLong(0);
            p.WriteShort(0);

            var payload = new CLIENT_FRONT_WORLD_CHARACTER_INFO();
            payload.account_uid = account_uid;

            byte[] serialized_payload = Protobuf.Serialize<CLIENT_FRONT_WORLD_CHARACTER_INFO>(payload);
            p.WriteBytes(serialized_payload);
            return p;
        }

        //BF EC 00 00 00 00 00 00 00 00 00 00 08 DA D3 92 E8 03
        public static Writer CLIENT_FRONT_WORLD_AND_CHARACTER_INFO(uint accountId, byte unk1)
        {
            Writer p = new Writer((ushort)Opcodes.CLIENT_FRONT_WORLD_AND_CHARACTER_INFO);
            p.WriteLong(0);
            p.WriteShort(0);
            p.WriteByte(8);
            p.WriteUInt(accountId);
            p.WriteByte(unk1); //not sure
            return p;
        }

        //
        public static Writer CLIENT_LOBBY_CHARACTER_LIST_ALL_GLOBAL(ulong account_uid)
        {
            Writer p = new Writer((ushort)Opcodes.CLIENT_LOBBY_CHARACTER_LIST_ALL_GLOBAL);
            p.WriteLong(0); //timestamp
            p.WriteShort(0);

            var payload = new CLIENT_LOBBY_CHARACTER_LIST_ALL_GLOBAL();
            payload.account_uid = account_uid;

            byte[] serialized_payload = Protobuf.Serialize<CLIENT_LOBBY_CHARACTER_LIST_ALL_GLOBAL>(payload);
            p.WriteBytes(serialized_payload);

            return p;
        }

        //BF EA 40 61 1C BC 06 77 07 00 00 00 08 FA 87 F5 E7 03 10 02 18 83 A2 8D C9 07 20 0B 
        public static Writer CLIENT_LOBBY_SELECT_CHARACTER(ulong account_uid, int classId, ulong character_uid, int store_type)
        {
            Writer p = new Writer((ushort)Opcodes.CLIENT_LOBBY_SELECT_CHARACTER);
            p.WriteLong(0); //timestamp
            p.WriteShort(0);

            var payload = new CLIENT_LOBBY_SELECT_CHARACTER();
            payload.account_uid = account_uid;
            payload.classId = classId;
            payload.character_uid = character_uid;
            payload.store_type = store_type;

            byte[] serialized_payload = Protobuf.Serialize<CLIENT_LOBBY_SELECT_CHARACTER>(payload);
            p.WriteBytes(serialized_payload);
            return p;
        }

        public static Writer CLIENT_GAME_REVIVAL(ulong uid, int type)
        {
            Writer p = new Writer((ushort)Opcodes.CLIENT_GAME_REVIVAL);
            p.WriteLong(0); //timestamp
            p.WriteShort(0);

            var payload = new CLIENT_GAME_REVIVAL();
            payload.type = type;

            byte[] serialized_payload = Protobuf.Serialize<CLIENT_GAME_REVIVAL>(payload);
            p.WriteBytes(serialized_payload);

            return p;
        }

        public static Writer CLIENT_GAME_LOGIN(ulong uid, int os_type)
        {
            Writer p = new Writer((ushort)Opcodes.CLIENT_GAME_LOGIN);
            p.WriteLong(0); //timestamp
            p.WriteShort(0);

            var payload = new CLIENT_GAME_LOGIN();
            payload.uid = uid;
            payload.os_type= os_type;

            byte[] serialized_payload = Protobuf.Serialize<CLIENT_GAME_LOGIN>(payload);
            p.WriteBytes(serialized_payload);

            return p;
        }

        //3E EB 00 00 00 00 00 00 00 00 00 00 08 AE 86 C0 C9 07 18 98 91 01 
        public static Writer CLIENT_GAME_NOTIFY_WARP_READY(ulong warp_user_uid, int warp_user_connected_session_index)
        {
            Writer p = new Writer((ushort)Opcodes.CLIENT_GAME_NOTIFY_WARP_READY);
            p.WriteLong(0); //timestamp
            p.WriteShort(0);

            var msg = new CLIENT_GAME_NOTIFY_WARP_READY();
            msg.warp_user_uid = warp_user_uid;
            msg.warp_user_connected_session_index = warp_user_connected_session_index;

            byte[] serialized_payload = Protobuf.Serialize<CLIENT_GAME_NOTIFY_WARP_READY>(msg);
            p.WriteBytes(serialized_payload);

            return p;
        }

        public static Writer CLIENT_GAME_END_LOADING()
        {
            Writer p = new Writer((ushort)Opcodes.CLIENT_GAME_END_LOADING);
            p.WriteLong(0); //timestamp
            p.WriteShort(0);
            return p;
        }

        public static Writer CLIENT_GAME_DATA_SEQUENTIAL_PACKET()
        {
            Writer p = new Writer((ushort)Opcodes.CLIENT_GAME_DATA_SEQUENTIAL_PACKET);
            p.WriteLong(0); //timestamp
            p.WriteShort(0);
            return p;
        }

        public static Writer CLIENT_GAME_SYNC_USER(_vector3 loc, _vector3 direction, float movespeed, MovementStates state, byte animState, byte heightState, _vector3 dest_loc, _vector3 fix_loc)
        {
            Writer p = new Writer((ushort)Opcodes.CLIENT_GAME_SYNC_USER);
            p.WriteLong(0); //timestamp
            p.WriteShort(0);

            var sync = new CLIENT_GAME_SYNC_USER();
            sync.state = (int)state;
            sync.moveSpeed = movespeed;
            sync.animState = animState;
            sync.heightState = heightState;

            sync.loc = loc;
            sync.dest_loc = dest_loc;
            sync.fix_loc = fix_loc;
            sync.direction = direction;

            byte[] serialized_payload = Protobuf.Serialize<CLIENT_GAME_SYNC_USER>(sync);
            p.WriteBytes(serialized_payload);
            return p;
        }

        public static Writer CLIENT_GAME_UI_SHOP_BUYITEM(ulong item_id, byte quantity) //check structure
        {
            Writer p = new Writer((ushort)Opcodes.CLIENT_GAME_UI_SHOP_BUYITEM);
            p.WriteLong(0); //timestamp
            p.WriteShort(0);
            p.WriteByte(8);
            p.WriteULong(item_id);
            p.WriteByte(quantity);
            return p;
        }

        public static Writer CLIENT_GAME_GACHA_PULL(byte index, byte quantity) //check structure
        {
            Writer p = new Writer((ushort)Opcodes.CLIENT_GAME_GACHA_PULL);
            p.WriteLong(0); //timestamp
            p.WriteShort(0);
            p.WriteByte(8);
            p.WriteByte(index);
            p.WriteByte(0x10);
            p.WriteByte(quantity);
            return p;
        }

        public static Writer CLIENT_GAME_CHARACTER_CASHBAG_DATA(uint session_seed)
        {
            Writer p = new Writer((ushort)Opcodes.CLIENT_GAME_GACHA_PULL);
            p.WriteLong(0); //timestamp
            p.WriteShort(0);
            p.WriteByte(8);
            p.WriteUInt(session_seed);
            p.WriteByte(0x07);
            return p;
        }

        public static Writer CLIENT_GAME_ENTER_MAGIC_SQUARE(byte stage) //0x65 = 1st stage?
        {
            Writer p = new Writer((ushort)Opcodes.CLIENT_GAME_ENTER_MAGIC_SQUARE);
            p.WriteLong(0); //timestamp
            p.WriteShort(0);
            p.WriteByte(8);
            p.WriteByte(stage);
            return p;
        }

        public static Writer CLIENT_GAME_CHANGE_ROOM_IN_MAGIC_SQUARE()
        {
            Writer p = new Writer((ushort)Opcodes.CLIENT_GAME_CHANGE_ROOM_IN_MAGIC_SQUARE);
            p.WriteLong(0); //timestamp
            p.WriteShort(0);
            return p;
        }

        
        //78 EA 00 00 00 00 00 00 00 00 00 00 08 B4 C4 C1 C9 07 10 01 18 01 
        public static Writer CLIENT_GAME_START_CASTING(ulong character_identifier, ulong entity_id, int casting_type, uint casting_sub_type, bool is_auto_casting)
        {
            Writer p = new Writer((ushort)Opcodes.CLIENT_GAME_START_CASTING);
            p.WriteLong(0); //timestamp
            p.WriteShort(0);

            var start_cast = new CLIENT_GAME_START_CASTING();
            start_cast.casting_user_uid = character_identifier;
            start_cast.casting_target_uid = entity_id;
            start_cast.casting_type = casting_type;
            start_cast.casting_sub_type = casting_sub_type;
            start_cast.is_auto_casting = is_auto_casting;

            byte[] serialized_payload = Protobuf.Serialize<CLIENT_GAME_START_CASTING>(start_cast);
            p.WriteBytes(serialized_payload);
            return p;
        }

        public static Writer CLIENT_GAME_CANCEL_CASTING()
        {
            Writer p = new Writer((ushort)Opcodes.CLIENT_GAME_CANCEL_CASTING);
            p.WriteLong(0); //timestamp
            p.WriteShort(0);
            return p;
        }

        public static Writer CLIENT_GAME_QUEST_MOVE_POS(_vector3 pos, int questId) //values are packed into protobuf
        {
            Writer p = new Writer((ushort)Opcodes.CLIENT_GAME_QUEST_MOVE_POS);
            p.WriteLong(0); //timestamp
            p.WriteShort(0); //flags

            var quest_tp = new CLIENT_GAME_QUEST_MOVE_POS();
            quest_tp.dest_loc = new _vector3();
            quest_tp.dest_loc.x = pos.x; quest_tp.dest_loc.y = pos.y; quest_tp.dest_loc.z = pos.z;
            quest_tp.quest_index = questId;

            byte[] serialized_payload = Protobuf.Serialize<CLIENT_GAME_QUEST_MOVE_POS>(quest_tp);
            p.WriteBytes(serialized_payload);
            return p;
        }

        public static Writer CLIENT_GAME_CHARACTER_SKILL(ulong uid)
        {
            Writer p = new Writer((ushort)Opcodes.CLIENT_GAME_ATTACK);
            p.WriteLong(0); //timestamp
            p.WriteShort(0);

            var payload = new CLIENT_GAME_CHARACTER_SKILL();
            payload.uid = uid;

            byte[] serialized_payload = Protobuf.Serialize<CLIENT_GAME_CHARACTER_SKILL>(payload);
            p.WriteBytes(serialized_payload);
            return p;
        }

        public static Writer CLIENT_GAME_ATTACK(int state, int skill, int attack_id, _vector3 loc_start, _vector3 loc_end, _attack_target_info[] targets, _vector3 attack_direction_vector, uint cur_skill_step, _monster_parts_info[] target_monster_parts_list)
        {
            Writer p = new Writer((ushort)Opcodes.CLIENT_GAME_ATTACK);
            p.WriteLong(0); //timestamp
            p.WriteShort(0);

            var payload = new CLIENT_GAME_ATTACK();
            payload.state = state;
            payload.skill = skill;
            payload.attack_id = attack_id;
            payload.loc_start = loc_start;
            payload.loc_end = loc_end;
            payload.targets = targets;
            payload.attack_direction_vector = attack_direction_vector;

            //payload.cur_skill_step = cur_skill_step; //unused in client
            payload.target_monster_parts_list = target_monster_parts_list;

            byte[] serialized_payload = Protobuf.Serialize<CLIENT_GAME_ATTACK>(payload);
            p.WriteBytes(serialized_payload);
            return p;
        }

        public static Writer CLIENT_GAME_QUEST_ACTION(int quest_index, int action, int flag)
        {
            Writer p = new Writer((ushort)Opcodes.CLIENT_GAME_QUEST_ACTION);
            p.WriteLong(0); //timestamp
            p.WriteShort(0);

            var payload = new CLIENT_GAME_QUEST_ACTION();
            payload.quest_index = quest_index;
            payload.flag = flag;
            payload.action = action;

            byte[] serialized_payload = Protobuf.Serialize<CLIENT_GAME_QUEST_ACTION>(payload);
            p.WriteBytes(serialized_payload);
            return p;
        }

        public static Writer CLIENT_GAME_ITEM_COLLECTION_REGISTER(int collection_id, int collection_slot, long resigter_item_uid)
        {
            Writer p = new Writer((ushort)Opcodes.CLIENT_GAME_ITEM_COLLECTION_REGISTER);
            p.WriteLong(0); //timestamp
            p.WriteShort(0);

            var payload = new CLIENT_GAME_ITEM_COLLECTION_REGISTER();
            payload.collection_id = collection_id;
            payload.collection_slot = collection_slot;
            payload.resigter_item_uid = resigter_item_uid;

            byte[] serialized_payload = Protobuf.Serialize<CLIENT_GAME_ITEM_COLLECTION_REGISTER>(payload);
            p.WriteBytes(serialized_payload);
            return p;
        }

        public static Writer CLIENT_GAME_REQUEST_ENTITY_APPEAR_DATA(int a, byte b)
        {
            Writer p = new Writer((ushort)Opcodes.CLIENT_GAME_QUEST_ACTION);
            p.WriteLong(0); //timestamp
            p.WriteShort(0);
            p.WriteByte(8);
            p.WriteInt(a); //need to use protobuf encode
            p.WriteByte(0x10);
            p.WriteByte(b);
            return p;
        }

        public static Writer CLIENT_GAME_UPGRADE_BUILDING_REQUEST(int tower) //3F EC 00 00 00 00 00 00 00 00 00 00 08 C0 84 3D 
        {
            Writer p = new Writer((ushort)Opcodes.CLIENT_GAME_UPGRADE_BUILDING_REQUEST);
            p.WriteLong(0); //timestamp
            p.WriteShort(0);
            p.WriteByte(8);
            p.WriteInt(tower); //need to use protobuf encode
            return p;
        }

        public static Writer CLIENT_GAME_UPGRADE_BUILDING_RE
            (int tower)
        {
            Writer p = new Writer((ushort)Opcodes.CLIENT_GAME_UPGRADE_BUILDING_REQUEST_COMPLETE);
            p.WriteLong(0); //timestamp
            p.WriteShort(0);
            p.WriteByte(8);
            p.WriteInt(tower); //need to use protobuf encode
            return p;
        }

        public static Writer CLIENT_GAME_ITEM_COLLECTION_REGISTER(int codexId, byte slot, ulong item_id) //2A EC 00 00 00 00 00 00 00 00 00 00 08 F4 E8 9E 01 10 02 18 80 80 88 A9 C7 E9 B5 AF 13 
        {
            Writer p = new Writer((ushort)Opcodes.CLIENT_GAME_ITEM_COLLECTION_REGISTER);
            p.WriteLong(0); //timestamp
            p.WriteShort(0);
            return p;
        }

        public static Writer CLIENT_GAME_PARTY_INVITE_REPLY(ulong reply_user_uid, ulong request_user_uid, ulong request_party_uid, bool request_result)
        {
            Writer p = new Writer((ushort)Opcodes.CLIENT_GAME_PARTY_INVITE_REPLY);
            p.WriteLong(0); //timestamp
            p.WriteShort(0);

            var payload = new CLIENT_GAME_PARTY_INVITE_REPLY();
            payload.reply_user_uid = reply_user_uid;
            payload.request_user_uid = request_user_uid;
            //payload.request_party_uid = request_party_uid; //unused in client
            payload.request_result = request_result;

            byte[] serialized_payload = Protobuf.Serialize<CLIENT_GAME_PARTY_INVITE_REPLY>(payload);
            p.WriteBytes(serialized_payload);
            return p;
        }
    }
}
