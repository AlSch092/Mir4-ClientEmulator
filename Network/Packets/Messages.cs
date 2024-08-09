//By AlSch092 @ Github
﻿using ProtoBuf;
using static Mir4ClientEmulator.Utilities.Enums;

namespace Mir4ClientEmulator.Network.Packets.Messages
{
    [ProtoContract]
    public class ServerInfo
    {
        [ProtoMember(1)]

        public int Index { get; set; }
        [ProtoMember(2)]
        public int State { get; set; }
        [ProtoMember(3)]
        public string Name { get; set; }
        [ProtoMember(4)]
        public string Ip { get; set; }
        [ProtoMember(5)]
        public int Port { get; set; }
    }


    [ProtoContract]
    public class Packet
    {
        enum Type
        {
            None,
            AuthenticationLogin = 20000,
        }
    }

    [ProtoContract]
    public class ClientServerAuthLogin
    {
        [ProtoMember(1)]

        Packet Packet { get; set; }
        [ProtoMember(2)]
        Sdk Sdk { get; set; }
        [ProtoMember(3)]
        Os Os { get; set; }
        [ProtoMember(4)]
        public string Device { get; set; }
        [ProtoMember(5)]
        public string AccountId { get; set; }
        [ProtoMember(6)]
        public string Version { get; set; }
        [ProtoMember(7)]
        public string PushId { get; set; }

    }

    [ProtoContract]
    public class ServerClientAuthLogin
    {
        [ProtoMember(1)]

        ErrorCode Error { get; set; }
        [ProtoMember(2)]
        public ulong Uid { get; set; }
        [ProtoMember(3)]
        public string AccessToken { get; set; }
        [ProtoMember(4)]
        ServerInfo[] ServerList { get; set; }

    }

    [ProtoContract]
    public class CharacterInfoEquipSlot
    {
        [ProtoMember(1)]

        public int slot_index { get; set; }
        [ProtoMember(2)]
        public _character_inven_item item { get; set; }

    }

    [ProtoContract]
    public class _other_user_ui_great_building_info
    {
        [ProtoMember(1)]

        public uint building_id { get; set; }
        [ProtoMember(2)]
        public int level { get; set; }

    }

    [ProtoContract]
    public class _other_user_ui_holy_stuff_info
    {
        [ProtoMember(1)]

        public uint phase_group_id { get; set; }
        [ProtoMember(2)]
        public uint grade { get; set; }

    }

    [ProtoContract]
    public class _other_user_ui_potential_level_info
    {
        [ProtoMember(1)]

        public uint node_category { get; set; }
        [ProtoMember(2)]
        public uint total_level { get; set; }

    }

    [ProtoContract]
    public class _other_pet_info
    {
        [ProtoMember(1)]

        public int tid { get; set; }
        [ProtoMember(2)]
        public _pet_equip_item_info[] equip_item_list { get; set; }
        [ProtoMember(3)]
        public int grade { get; set; }
        [ProtoMember(4)]
        public int slot_id { get; set; }

    }

    [ProtoContract]
    public class _other_user_ui_info
    {
        [ProtoMember(1)]

        public ulong user_uid { get; set; }
        [ProtoMember(2)]
        public string nickname { get; set; }
        [ProtoMember(3)]
        public string custom_title { get; set; }
        [ProtoMember(4)]
        public int class_index { get; set; }
        [ProtoMember(5)]
        public int level { get; set; }
        [ProtoMember(6)]
        public int combat_point { get; set; }
        [ProtoMember(7)]
        public int pk_point { get; set; }
        [ProtoMember(8)]
        public ulong guild_uid { get; set; }
        [ProtoMember(10)]
        public CharacterInfoEquipSlot[] equip_slot_list { get; set; }
        [ProtoMember(12)]
        public int skill_level_count { get; set; }
        [ProtoMember(13)]
        public int mastery_level_count { get; set; }
        [ProtoMember(14)]
        public int force_level_count { get; set; }
        [ProtoMember(15)]
        public int jewel_count { get; set; }
        [ProtoMember(16)]
        public customize_info[] customize_list { get; set; }
        [ProtoMember(17)]
        public _equip_costume_info[] equip_costume_list { get; set; }
        [ProtoMember(18)]
        public ulong fame_rank { get; set; }
        [ProtoMember(19)]
        public fame_info[] fame_list { get; set; }
        [ProtoMember(20)]
        public ulong fame_score { get; set; }
        [ProtoMember(21)]
        public uint fame_level { get; set; }
        [ProtoMember(22)]
        public ulong fame_level_exp { get; set; }
        [ProtoMember(23)]
        public string profile { get; set; }
        [ProtoMember(24)]
        public uint world_id { get; set; }
        [ProtoMember(25)]
        public uint dominion_title_tid { get; set; }
        [ProtoMember(26)]
        public _pet_info[] _pet_list { get; set; }
        [ProtoMember(27)]
        public _character_skill[] skill_list { get; set; }
        [ProtoMember(28)]
        public _force_level_info[] force_list { get; set; }
        [ProtoMember(29)]
        public int mastery_level_limit_grade { get; set; }
        [ProtoMember(30)]
        public bool delete_character { get; set; }
        [ProtoMember(31)]
        public int closed_training_total_level { get; set; }
        [ProtoMember(32)]
        public int closed_training_collect_step { get; set; }
        [ProtoMember(33)]
        public bool trans_server { get; set; }
        [ProtoMember(34)]
        public int luxury_costume_pet_id { get; set; }
        [ProtoMember(35)]
        public int luxury_costume_vehicle_id { get; set; }
        [ProtoMember(36)]
        public int cur_play_world_id { get; set; }
        [ProtoMember(37)]
        public _cost_info[] can_receive_money_limit { get; set; }
        [ProtoMember(38)]
        public bool is_custom_title_show { get; set; }
        [ProtoMember(39)]
        public long custom_title_end_time { get; set; }
        [ProtoMember(40)]
        public _other_user_ui_great_building_info[] great_building_info { get; set; }
        [ProtoMember(41)]
        public ulong daily_wonder { get; set; }
        [ProtoMember(42)]
        public int current_server_pos { get; set; }
        [ProtoMember(43)]
        public ulong wonder { get; set; }
        [ProtoMember(44)]
        public _other_user_ui_holy_stuff_info[] _holy_stuff_info { get; set; }
        [ProtoMember(45)]
        public _other_user_ui_potential_level_info[] _potential_level_list { get; set; }
        [ProtoMember(46)]
        public _other_pet_info[] _curr_pet_info_list { get; set; }
    }

    [ProtoContract]
    public class _other_user_ui_info_guild
    {
        [ProtoMember(1)]

        _guild_name_ui_info guild_name_info { get; set; }
        [ProtoMember(2)]
        public int guild_member_grade { get; set; }
        [ProtoMember(3)]
        public int guild_level { get; set; }
        [ProtoMember(5)]
        public string guild_custom_title { get; set; }
        [ProtoMember(6)]
        public int guild_official_grade { get; set; }
        [ProtoMember(7)]
        public bool is_sabuk_master { get; set; }

    }

    [ProtoContract]
    public class _other_user_ui_info_rank
    {
        [ProtoMember(1)]

        public uint power_ranking { get; set; }
        [ProtoMember(2)]
        public uint pvp_ranking { get; set; }
        [ProtoMember(3)]
        public uint guild_ranking { get; set; }
        [ProtoMember(4)]
        public uint item_collection_ranking { get; set; }
        [ProtoMember(5)]
        public uint level_ranking { get; set; }

    }

    [ProtoContract]
    public class _other_user_info_etc
    {
        [ProtoMember(1)]

        public _character_guild_receive_cost_server_sync[] receive_cost_list { get; set; }

    }


    [ProtoContract]
    public class _refuse_info
    {
        [ProtoMember(1)]

        public uint buff_tid { get; set; }
        [ProtoMember(2)]
        public long buff_end_time { get; set; }

    }

    [ProtoContract]
    public class _characterInfo_login
    {
        [ProtoMember(1)]

        public int eClass { get; set; }
        [ProtoMember(2)]
        public int Level { get; set; }
        [ProtoMember(3)]
        public string NickName { get; set; }
        [ProtoMember(4)]
        public long LastLoginTime { get; set; }
        [ProtoMember(5)]
        public int WeaponItemIndex { get; set; }
        [ProtoMember(6)]
        public int WeaponSmeltingLevel { get; set; }
        [ProtoMember(7)]
        public int CostumeID { get; set; }
        [ProtoMember(8)]
        public int HairColorIndex { get; set; }
        [ProtoMember(9)]
        public int ClothesColorIndex { get; set; }
        [ProtoMember(10)]
        public long Exp { get; set; }
        [ProtoMember(11)]
        public int CombatPoint { get; set; }
        [ProtoMember(12)]
        public uint StageID { get; set; }
        [ProtoMember(13)]
        public int playtime_sec { get; set; }
        [ProtoMember(14)]
        public ulong character_uid { get; set; }
        [ProtoMember(15)]
        public customize_info[] customize_list { get; set; }
        [ProtoMember(16)]
        public _equip_costume_info[] costume_list { get; set; }
        [ProtoMember(17)]
        public long del_time { get; set; }
        [ProtoMember(18)]
        public string GuildName { get; set; }
        [ProtoMember(19)]
        public int server_change_state { get; set; }

    }

    [ProtoContract]
    public class _characterInfo_login_global
    {
        [ProtoMember(1)]

        public int eClass { get; set; }
        [ProtoMember(2)]
        public int Level { get; set; }
        [ProtoMember(3)]
        public string NickName { get; set; }
        [ProtoMember(4)]
        public long LastLoginTime { get; set; }
        [ProtoMember(5)]
        public int WeaponItemIndex { get; set; }
        [ProtoMember(6)]
        public int WeaponSmeltingLevel { get; set; }
        [ProtoMember(7)]
        public int CostumeID { get; set; }
        [ProtoMember(8)]
        public int HairColorIndex { get; set; }
        [ProtoMember(9)]
        public int ClothesColorIndex { get; set; }
        [ProtoMember(10)]
        public long Exp { get; set; }
        [ProtoMember(11)]
        public int CombatPoint { get; set; }
        [ProtoMember(12)]
        public int StageID { get; set; }
        [ProtoMember(13)]
        public int playtime_sec { get; set; }
        [ProtoMember(14)]
        public ulong character_uid { get; set; }
        [ProtoMember(15)]
        public customize_info[] customize_list { get; set; }
        [ProtoMember(16)]
        public _equip_costume_info[] costume_list { get; set; }
        [ProtoMember(17)]
        public long del_time { get; set; }
        [ProtoMember(18)]
        public string GuildName { get; set; }
        [ProtoMember(19)]
        public int server_change_state { get; set; }
        [ProtoMember(20)]
        public long NftType { get; set; }
        [ProtoMember(21)]
        public string NftTokenURL { get; set; }
        [ProtoMember(22)]
        public int luxury_costume_pet_id { get; set; }

    }

    [ProtoContract]
    public class _character_equip_item
    {
        [ProtoMember(1)]

        public ulong ItemUID { get; set; }
        [ProtoMember(2)]
        public int Position { get; set; }
        [ProtoMember(3)]
        public int mastery_count { get; set; }

    }

    [ProtoContract]
    public class _character_equip_magic_stone_item
    {
        [ProtoMember(1)]

        public ulong item_uid { get; set; }
        [ProtoMember(2)]
        public int equip_slot { get; set; }

    }

    [ProtoContract]
    public class _vehicle_equip_item
    {
        [ProtoMember(1)]

        public ulong ItemUID { get; set; }
        [ProtoMember(2)]
        public int GroupId { get; set; }
        [ProtoMember(3)]
        public int Position { get; set; }

    }

    [ProtoContract]
    public class _character_skill
    {
        [ProtoMember(1)]

        public int SkillIndex { get; set; }
        [ProtoMember(2)]
        public int SkillLevel { get; set; }

    }

    [ProtoContract]
    public class _character_skill_deck
    {
        [ProtoMember(1)]

        public int deckId { get; set; }
        [ProtoMember(2)]
        public int slotId { get; set; }
        [ProtoMember(3)]
        public int skillId { get; set; }

    }

    [ProtoContract]
    public class _skill_passive_group
    {
        [ProtoMember(1)]

        public uint group_id { get; set; }
        [ProtoMember(2)]
        public int level { get; set; }
        [ProtoMember(3)]
        public uint exp { get; set; }
        [ProtoMember(4)]
        public uint learn_point { get; set; }

    }

    [ProtoContract]
    public class _passive_skill_info
    {
        [ProtoMember(1)]

        public uint group_id { get; set; }
        [ProtoMember(2)]
        public uint passive_index { get; set; }
        [ProtoMember(3)]
        public uint level { get; set; }

    }

    [ProtoContract]
    public class _character_quest
    {
        [ProtoMember(1)]

        public int QuestIndex { get; set; }
        [ProtoMember(2)]
        public int State { get; set; }
        [ProtoMember(3)]
        public int CurrentCount { get; set; }
        [ProtoMember(4)]
        public int quest_type { get; set; }

        public _character_quest() { }

        public _character_quest(_character_quest to_copy)
        {
            QuestIndex = to_copy.QuestIndex;
            State = to_copy.State;
            CurrentCount = to_copy.CurrentCount;
            quest_type = to_copy.quest_type;
        }

    }

    [ProtoContract]
    public class _character_inven_item
    {
        [ProtoMember(1)]

        public ulong item_uid { get; set; }
        [ProtoMember(2)]
        public uint item_index { get; set; }
        [ProtoMember(3)]
        public uint smelting_level { get; set; }
        [ProtoMember(4)]
        public int stack_count { get; set; }
        [ProtoMember(5)]
        public int durability { get; set; }
        [ProtoMember(6)]
        public int period_end_time { get; set; }
        [ProtoMember(7)]
        public bool is_equip { get; set; }
        [ProtoMember(8)]
        public ItemOptionInfo[] random_option_list { get; set; }
        [ProtoMember(9)]
        public bool is_lock { get; set; }
        [ProtoMember(10)]
        public int trance_step { get; set; }
        [ProtoMember(11)]
        public long last_used_time { get; set; }
        [ProtoMember(12)]
        public long item_remain_cooltime { get; set; }
        [ProtoMember(13)]
        public int xdraco_trade_state { get; set; }
        [ProtoMember(14)]
        public int acquisition_path { get; set; }
        [ProtoMember(15)]
        public int acquisition_path_value { get; set; }
        [ProtoMember(16)]
        public long acquisition_path_create_time { get; set; }
        [ProtoMember(17)]
        public string serial_number { get; set; }
        [ProtoMember(18)]
        public int collectable { get; set; }
        [ProtoMember(19)]
        public string limited { get; set; }
        [ProtoMember(20)]
        public uint refine_step { get; set; }

    }

    [ProtoContract]
    public class _character_mastery_slot
    {
        [ProtoMember(1)]

        public int slot_index { get; set; }
        [ProtoMember(2)]
        public int mastery_count { get; set; }

    }

    [ProtoContract]
    public class _character_play_data_info
    {
        [ProtoMember(1)]

        public int play_data_id { get; set; }
        [ProtoMember(2)]
        public long count { get; set; }

    }

    [ProtoContract]
    public class _character_achievement_complete_info
    {
        [ProtoMember(1)]

        public int achievement_group_id { get; set; }
        [ProtoMember(2)]
        public int achievement_group_grade { get; set; }

    }

    [ProtoContract]
    public class _reward_cost_info
    {
        [ProtoMember(1)]

        public int CostType { get; set; }
        [ProtoMember(2)]
        public long Value { get; set; }

    }

    [ProtoContract]
    public class _cost_info
    {
        [ProtoMember(1)]

        public int CostSubType { get; set; }
        [ProtoMember(2)]
        public long CurrentValue { get; set; }

    }

    [ProtoContract]
    public class _used_cost_info
    {
        [ProtoMember(1)]

        public int CostType { get; set; }
        [ProtoMember(2)]
        public long CurrentValue { get; set; }
        [ProtoMember(3)]
        public long ChangeValue { get; set; }

    }

    [ProtoContract]
    public class _time_ticket_info
    {
        [ProtoMember(1)]

        public int time_ticket_type { get; set; }
        [ProtoMember(2)]
        public long time_ticket_amount { get; set; }
        [ProtoMember(3)]
        public int last_increase_time_sec { get; set; }

    }

    [ProtoContract]
    public class _simple_cost_info
    {
        [ProtoMember(1)]

        public int cost_type { get; set; }
        [ProtoMember(2)]
        public long cost_value { get; set; }

    }

    [ProtoContract]
    public class _simple_item_info
    {
        [ProtoMember(1)]

        public int itemindex { get; set; }
        [ProtoMember(2)]
        public int itemcount { get; set; }

    }

    [ProtoContract]
    public class _simple_item_info_ex_xdraco
    {
        [ProtoMember(1)]

        public int itemindex { get; set; }
        [ProtoMember(2)]
        public int itemcount { get; set; }
        [ProtoMember(3)]
        public int xdraco_trade_state { get; set; }

    }

    [ProtoContract]
    public class _mail_item_info
    {
        [ProtoMember(1)]

        public int item_index { get; set; }
        [ProtoMember(2)]
        public int item_count { get; set; }
        [ProtoMember(3)]
        public int smelting_lv { get; set; }

    }

    [ProtoContract]
    public class _mail_item_list
    {
        [ProtoMember(1)]

        public _mail_item_info[] item_list { get; set; }

    }

    [ProtoContract]
    public class _vector3
    {
        [ProtoMember(1)]
        public float x { get; set; }
        [ProtoMember(2)]
        public float y { get; set; }
        [ProtoMember(3)]
        public float z { get; set; }
    }

    [ProtoContract]
    public class _characterInfo
    {
        [ProtoMember(1)]

        public long Exp { get; set; }
        [ProtoMember(2)]
        public int StageID { get; set; }
        [ProtoMember(3)]
        public _vector3 loc { get; set; }
        [ProtoMember(4)]
        public _cost_info[] cost_infos { get; set; }
        [ProtoMember(5)]
        public int awaken_grade { get; set; }
        [ProtoMember(6)]
        public uint current_hp { get; set; }
        [ProtoMember(7)]
        public uint current_mana { get; set; }
        [ProtoMember(8)]
        public uint current_vigor { get; set; }
        [ProtoMember(9)]
        public int pk_grade { get; set; }
        [ProtoMember(10)]
        public int pk_point { get; set; }
        [ProtoMember(11)]
        public int pk_assault { get; set; }
        [ProtoMember(12)]
        public _guild_name_ui_info guild_info { get; set; }
        [ProtoMember(13)]
        public _time_ticket_info[] time_ticket_info { get; set; }
        [ProtoMember(14)]
        public uint guild_contribution { get; set; }
        [ProtoMember(15)]
        public uint current_rage { get; set; }
        [ProtoMember(16)]
        public string profile { get; set; }
        [ProtoMember(17)]
        public ulong guild_gift_box_open_time { get; set; }
        [ProtoMember(19)]
        public int today_get_guild_point { get; set; }
        [ProtoMember(20)]
        public long last_support_time { get; set; }
        [ProtoMember(21)]
        public _dungeon_ticket_info[] dungeon_ticket_info { get; set; }
        [ProtoMember(22)]
        public uint world_id { get; set; }
        [ProtoMember(23)]
        public uint dominion_title_tid { get; set; }
        [ProtoMember(24)]
        public uint exp_booster_left_time { get; set; }
        [ProtoMember(25)]
        public uint account_garde { get; set; }
        [ProtoMember(26)]
        public uint class_id { get; set; }
        [ProtoMember(27)]
        public ulong daily_wonder { get; set; }

    }

    [ProtoContract]
    public class _stack_item_info
    {
        [ProtoMember(1)]

        public ulong itemuid { get; set; }
        [ProtoMember(2)]
        public int itemcount { get; set; }
        [ProtoMember(3)]
        public long item_lastusedtime { get; set; }
        [ProtoMember(4)]
        public long item_remain_cooltime { get; set; }

    }

    [ProtoContract]
    public class _attack_target_info
    {
        [ProtoMember(1)]

        public int targettype { get; set; }
        [ProtoMember(2)]
        public ulong targetid { get; set; }

    }

    [ProtoContract]
    public class _phasing_target_info
    {
        [ProtoMember(1)]

        public int targettype { get; set; }
        [ProtoMember(2)]
        public int targetindex { get; set; }
        [ProtoMember(3)]
        public ulong targetid { get; set; }

    }

    [ProtoContract]
    public class _phasing_target_damage
    {
        [ProtoMember(1)]

        public int targettype { get; set; }
        [ProtoMember(2)]
        public ulong targetid { get; set; }
        [ProtoMember(3)]
        public int damage { get; set; }
        [ProtoMember(4)]
        public int hp { get; set; }
        [ProtoMember(5)]
        public int crowd { get; set; }
        [ProtoMember(6)]
        public int cctime_ms { get; set; }

    }

    [ProtoContract]
    public class _vehicle_info
    {
        [ProtoMember(1)]

        public int vehicle_group { get; set; }
        [ProtoMember(2)]
        public int vehicle_index { get; set; }
        [ProtoMember(3)]
        public int reinforce_level { get; set; }
        [ProtoMember(4)]
        public int reinforce_exp { get; set; }

    }

    [ProtoContract]
    public class _character_quest_daily_info
    {
        [ProtoMember(1)]

        public int list_receive_time { get; set; }
        [ProtoMember(2)]
        public int free_reset_count { get; set; }
        [ProtoMember(3)]
        public int clear_count { get; set; }
        [ProtoMember(4)]
        public int plus_reward_count { get; set; }
        [ProtoMember(5)]
        public int plus_reward_grade { get; set; }

    }

    [ProtoContract]
    public class _character_quest_daily_list_info
    {
        [ProtoMember(1)]

        public int slot_index { get; set; }
        [ProtoMember(2)]
        public int quest_id { get; set; }
        [ProtoMember(3)]
        public int count { get; set; }
        [ProtoMember(4)]
        public int grade { get; set; }
        [ProtoMember(5)]
        public int start_time { get; set; }
        [ProtoMember(6)]
        public bool is_clear { get; set; }
        [ProtoMember(7)]
        public bool is_reward { get; set; }

    }

    [ProtoContract]
    public class _character_quest_daily_reward_list_info
    {
        [ProtoMember(1)]

        public int slot_index { get; set; }
        [ProtoMember(2)]
        public int grade { get; set; }

    }

    [ProtoContract]
    public class _stat_info
    {
        [ProtoMember(1)]

        public int attribute_type { get; set; }
        [ProtoMember(2)]
        public int attribute_value { get; set; }

    }

    [ProtoContract]
    public class _building_stat_info
    {
        [ProtoMember(1)]

        public int building_id { get; set; }
        [ProtoMember(2)]
        public int attribute_type { get; set; }
        [ProtoMember(3)]
        public int attribute_value { get; set; }

    }

    [ProtoContract]
    public class _buff_effect_info
    {
        [ProtoMember(1)]

        public int buff_effect_type { get; set; }
        [ProtoMember(2)]
        public int buff_effect_value { get; set; }

    }

    [ProtoContract]
    public class _buff_info
    {
        [ProtoMember(1)]

        public int buff_id { get; set; }
        [ProtoMember(2)]
        public int buff_level { get; set; }
        [ProtoMember(3)]
        public int stack_count { get; set; }
        [ProtoMember(4)]
        public float buff_left_time { get; set; }
        [ProtoMember(5)]
        public int buff_owner_type { get; set; }
        [ProtoMember(6)]
        public ulong buff_owner_uid { get; set; }
        [ProtoMember(7)]
        public bool is_infinite { get; set; }
        [ProtoMember(8)]
        public uint attach_skill_attack_id { get; set; }
        [ProtoMember(9)]
        public _buff_effect_info[] buff_effect_info { get; set; }
        [ProtoMember(11)]
        public _stat_info[] buff_stat_info { get; set; }
        [ProtoMember(12)]
        public _buff_special_effect_info[] buff_special_effect_info { get; set; }

    }

    [ProtoContract]
    public class _buff_special_effect_info
    {
        [ProtoMember(1)]

        public int buff_special_effect_type { get; set; }
        [ProtoMember(2)]
        public int buff_index { get; set; }
        [ProtoMember(3)]
        public int buff_special_effect_value { get; set; }
        [ProtoMember(4)]
        public int buff_special_effect_value_ex { get; set; }

    }

    [ProtoContract]
    public class _raid_reward_receive_info
    {
        [ProtoMember(1)]

        public uint raid_id { get; set; }
        [ProtoMember(2)]
        public uint receive_count { get; set; }
        [ProtoMember(3)]
        public uint last_reward_receive_time { get; set; }

    }

    [ProtoContract]
    public class _world_server_info
    {
        [ProtoMember(1)]

        public uint world_id { get; set; }
        [ProtoMember(2)]
        public string world_name { get; set; }
        [ProtoMember(3)]
        public uint world_state { get; set; }
        [ProtoMember(4)]
        public int order_num { get; set; }
        [ProtoMember(5)]
        public int recommend_server { get; set; }
        [ProtoMember(6)]
        public int new_server { get; set; }
        [ProtoMember(7)]
        public int blind { get; set; }
        [ProtoMember(8)]
        public int user_connect { get; set; }
        [ProtoMember(9)]
        public int character_create { get; set; }
        [ProtoMember(10)]
        public uint congestion { get; set; }
        [ProtoMember(11)]
        public int max_user { get; set; }
        [ProtoMember(12)]
        public int non_pk_server { get; set; }
        [ProtoMember(13)]
        public int nft_server { get; set; }
        [ProtoMember(14)]
        public int nft_block { get; set; }

    }

    [ProtoContract]
    public class _db_info
    {
        [ProtoMember(1)]

        public int db_type { get; set; }
        [ProtoMember(2)]
        public uint world_id { get; set; }
        [ProtoMember(3)]
        public string db_ip { get; set; }
        [ProtoMember(4)]
        public int db_port { get; set; }
        [ProtoMember(5)]
        public string db_user { get; set; }
        [ProtoMember(6)]
        public string db_pw { get; set; }
        [ProtoMember(7)]
        public string db_name { get; set; }
        [ProtoMember(8)]
        public int db_connection_count { get; set; }

    }

    [ProtoContract]
    public class _guild_name_ui_info
    {
        [ProtoMember(1)]

        public ulong guild_uid { get; set; }
        [ProtoMember(2)]
        public string guild_name { get; set; }
        [ProtoMember(3)]
        public uint guild_mark { get; set; }
        [ProtoMember(4)]
        public uint guild_mark_edge { get; set; }
        [ProtoMember(5)]
        public uint world_id { get; set; }

    }

    [ProtoContract]
    public class _guild_simple_info
    {
        [ProtoMember(1)]

        public ulong guild_uid { get; set; }
        [ProtoMember(2)]
        public string guild_name { get; set; }
        [ProtoMember(3)]
        public string master_name { get; set; }
        [ProtoMember(4)]
        public uint guild_mark { get; set; }
        [ProtoMember(5)]
        public uint guild_mark_edge { get; set; }

    }

    [ProtoContract]
    public class _guild_info
    {
        [ProtoMember(1)]

        public ulong guild_uid { get; set; }
        [ProtoMember(2)]
        public string guild_name { get; set; }
        [ProtoMember(3)]
        public string master_name { get; set; }
        [ProtoMember(4)]
        public uint guild_mark { get; set; }
        [ProtoMember(5)]
        public uint guild_mark_edge { get; set; }
        [ProtoMember(6)]
        public uint guild_join_type { get; set; }
        [ProtoMember(7)]
        public uint guild_level { get; set; }
        [ProtoMember(8)]
        public uint guild_members { get; set; }
        [ProtoMember(10)]
        public uint guild_max_members { get; set; }
        [ProtoMember(11)]
        public string guild_pr { get; set; }
        [ProtoMember(12)]
        public string guild_notice { get; set; }
        [ProtoMember(13)]
        public ulong master_uid { get; set; }
        [ProtoMember(14)]
        public uint guild_rank { get; set; }
        [ProtoMember(15)]
        public long total_combat_point { get; set; }
        [ProtoMember(16)]
        public long join_limit_combat_point { get; set; }
        [ProtoMember(18)]
        _guild_gift_box_info guild_gift_box_info { get; set; }
        [ProtoMember(19)]
        public string master_profile { get; set; }
        [ProtoMember(20)]
        public int world_id { get; set; }

    }

    [ProtoContract]
    public class _guild_member_partner_info
    {
        [ProtoMember(1)]

        public ulong member_uid { get; set; }
        [ProtoMember(2)]
        public _guild_member_authority[] auth_list { get; set; }

    }

    [ProtoContract]
    public class _guild_member_simple_info
    {
        [ProtoMember(1)]

        public uint member_grade { get; set; }
        [ProtoMember(2)]
        public uint class_id { get; set; }
        [ProtoMember(3)]
        public string nickname { get; set; }
        [ProtoMember(4)]
        public string profile { get; set; }
        [ProtoMember(5)]
        public int ranking { get; set; }
        [ProtoMember(6)]
        public string guild_custom_title { get; set; }
        [ProtoMember(7)]
        public uint official_grade { get; set; }
        [ProtoMember(8)]
        public long member_join_time { get; set; }
        [ProtoMember(9)]
        public bool trans_server { get; set; }
        [ProtoMember(10)]
        public int current_server_pos { get; set; }
        [ProtoMember(11)]
        public bool is_sabuk_master { get; set; }

    }

    [ProtoContract]
    public class _guild_member_detail_info
    {
        [ProtoMember(1)]

        public uint level { get; set; }
        [ProtoMember(2)]
        public uint locate { get; set; }
        [ProtoMember(4)]
        public long logout_time { get; set; }
        [ProtoMember(5)]
        public int combat_point { get; set; }
        [ProtoMember(6)]
        public ulong partner_member_uid { get; set; }
        [ProtoMember(8)]
        public int cost_give_count { get; set; }
        [ProtoMember(10)]
        public _guild_member_authority[] auth_list { get; set; }
        [ProtoMember(11)]
        public _cost_info[] can_receive_money_limit { get; set; }

    }

    [ProtoContract]
    public class _guild_member_info
    {
        [ProtoMember(1)]

        public ulong member_uid { get; set; }
        [ProtoMember(2)]
        public _guild_member_simple_info simple_info { get; set; }
        [ProtoMember(3)]
        public _guild_member_detail_info detail_info { get; set; }

    }

    [ProtoContract]
    public class _guild_option
    {
        [ProtoMember(1)]

        public uint option_type { get; set; }
        [ProtoMember(2)]
        public uint option_value { get; set; }

    }

    [ProtoContract]
    public class _character_guild_receive_cost_server_sync
    {
        [ProtoMember(1)]

        public int cost_type { get; set; }
        [ProtoMember(2)]
        public int cost_value { get; set; }
        [ProtoMember(3)]
        public long receive_time { get; set; }

    }

    [ProtoContract]
    public class _character_guild_receive_cost_by_user_uid_server_sync
    {
        [ProtoMember(1)]

        public long user_uid { get; set; }
        [ProtoMember(2)]
        public _character_guild_receive_cost_server_sync[] receive_info { get; set; }

    }

    [ProtoContract]
    public class _guild_member_info_server_sync
    {
        [ProtoMember(1)]

        public ulong member_uid { get; set; }
        [ProtoMember(2)]
        public string nickname { get; set; }
        [ProtoMember(3)]
        public string guild_custom_title { get; set; }
        [ProtoMember(4)]
        public string profile { get; set; }
        [ProtoMember(5)]
        public uint class_id { get; set; }
        [ProtoMember(6)]
        public uint level { get; set; }
        [ProtoMember(7)]
        public uint member_grade { get; set; }
        [ProtoMember(8)]
        public long contribution { get; set; }
        [ProtoMember(9)]
        public uint locate { get; set; }
        [ProtoMember(10)]
        public long logout_time { get; set; }
        [ProtoMember(11)]
        public int combat_point { get; set; }
        [ProtoMember(12)]
        public long member_join_time { get; set; }
        [ProtoMember(13)]
        public long partner_member_uid { get; set; }
        [ProtoMember(14)]
        public _guild_member_authority[] auth_list { get; set; }
        [ProtoMember(15)]
        public int cost_give_count { get; set; }
        [ProtoMember(17)]
        public long cost_give_time { get; set; }
        [ProtoMember(18)]
        public _character_guild_receive_cost_server_sync[] receive_cost_list { get; set; }
        [ProtoMember(19)]
        public int chang_bit_flag { get; set; }
        [ProtoMember(26)]
        public int official_grade { get; set; }
        [ProtoMember(27)]
        public long last_donation_time { get; set; }
        [ProtoMember(28)]
        public _cost_info[] donation_info_daily { get; set; }
        [ProtoMember(29)]
        public _cost_info[] donation_info_weekly { get; set; }
        [ProtoMember(30)]
        public bool is_trans_server { get; set; }
        [ProtoMember(31)]
        public int current_server_pos { get; set; }
        [ProtoMember(32)]
        public bool is_sabuk_master { get; set; }

    }

    [ProtoContract]
    public class _guild_stat_info
    {
        [ProtoMember(1)]

        public int stat_type { get; set; }
        [ProtoMember(2)]
        public int value { get; set; }

    }

    [ProtoContract]
    public class _character_guild_donation_info
    {
        [ProtoMember(1)]

        public uint money_index { get; set; }
        [ProtoMember(2)]
        public long money_amount { get; set; }
        [ProtoMember(3)]
        public long donation_time { get; set; }

    }

    [ProtoContract]
    public class _history_param
    {
        [ProtoMember(1)]

        public int order_num { get; set; }
        [ProtoMember(2)]
        public int param_type { get; set; }
        [ProtoMember(3)]
        public long num { get; set; }
        [ProtoMember(4)]
        public string val { get; set; }

    }

    [ProtoContract]
    public class _guild_hostility_info_server_sync
    {
        [ProtoMember(1)]

        public ulong enemy_guild_uid { get; set; }
        [ProtoMember(2)]
        public ulong declare_uid { get; set; }
        [ProtoMember(3)]
        public ulong target_uid { get; set; }
        [ProtoMember(4)]
        public long start_time_per_sec { get; set; }
        [ProtoMember(5)]
        public long end_time_per_sec { get; set; }
        [ProtoMember(6)]
        public int kill_count { get; set; }
        [ProtoMember(7)]
        public int death_count { get; set; }
        [ProtoMember(8)]
        public int chang_bit_flag { get; set; }
        [ProtoMember(9)]
        public int declare_world_id { get; set; }
        [ProtoMember(10)]
        public int target_world_id { get; set; }

    }

    [ProtoContract]
    public class _guild_member_position_server_sync
    {
        [ProtoMember(1)]

        public uint position_num { get; set; }
        [ProtoMember(2)]
        public ulong member_uid { get; set; }

    }

    [ProtoContract]
    public class _siege_info
    {
        [ProtoMember(1)]

        public int siege_tid { get; set; }
        [ProtoMember(2)]
        public int siege_status { get; set; }
        [ProtoMember(3)]
        _guild_simple_info occupation_guild_info { get; set; }
        [ProtoMember(4)]
        public ulong this_siege_auction_start_time { get; set; }
        [ProtoMember(5)]
        public ulong this_siege_battle_start_time { get; set; }

    }

    [ProtoContract]
    public class _strong_point_info_v2
    {
        [ProtoMember(1)]

        public int strong_point_tid { get; set; }
        [ProtoMember(2)]
        public uint strong_point_status { get; set; }
        [ProtoMember(3)]
        public uint next_strong_point_status { get; set; }
        [ProtoMember(4)]
        public long next_status_time { get; set; }
        [ProtoMember(5)]
        _guild_simple_info occupation_guild_info { get; set; }
        [ProtoMember(6)]
        public ulong occupy_time { get; set; }

    }

    [ProtoContract]
    public class _strong_point_server_info
    {
        [ProtoMember(1)]

        public int strong_point_tid { get; set; }
        [ProtoMember(2)]
        public uint strong_point_status { get; set; }
        [ProtoMember(3)]
        public uint next_strong_point_status { get; set; }
        [ProtoMember(4)]
        public long next_status_time { get; set; }
        [ProtoMember(5)]
        _guild_simple_info occupation_guild_info { get; set; }
        [ProtoMember(6)]
        public ulong occupy_time { get; set; }
        [ProtoMember(7)]
        public ulong win_target_occupy_guild_uid { get; set; }
        [ProtoMember(8)]
        public string occupy_guild_proclamation { get; set; }

    }

    [ProtoContract]
    public class _guild_war_npc_info
    {
        [ProtoMember(1)]

        public int war_type { get; set; }
        [ProtoMember(2)]
        public int war_tid { get; set; }
        [ProtoMember(3)]
        public int npc_tid { get; set; }
        [ProtoMember(4)]
        _guild_simple_info occupation_guild_info { get; set; }
        [ProtoMember(5)]
        public ulong occupy_time { get; set; }

    }

    [ProtoContract]
    public class _sanctum_info
    {
        [ProtoMember(1)]

        public int sanctum_stage_tid { get; set; }
        [ProtoMember(2)]
        public uint sanctum_status { get; set; }
        [ProtoMember(3)]
        public _guild_simple_info occupation_guild_info { get; set; }
        [ProtoMember(4)]
        public ulong occupy_time { get; set; }
        [ProtoMember(5)]
        public ulong sanctum_life_end_time { get; set; }

    }

    [ProtoContract]
    public class _sanctum_server_info
    {
        [ProtoMember(1)]

        public int sanctum_stage_tid { get; set; }
        [ProtoMember(2)]
        public uint sanctum_status { get; set; }
        [ProtoMember(3)]
        public _guild_simple_info occupation_guild_info { get; set; }
        [ProtoMember(4)]
        public ulong occupy_time { get; set; }

    }

    [ProtoContract]
    public class _plunder_info
    {
        [ProtoMember(1)]

        public int plunder_tid { get; set; }
        [ProtoMember(2)]
        public int plunder_status { get; set; }
        [ProtoMember(3)]
        public _guild_simple_info occupy_guild_info { get; set; }
        [ProtoMember(4)]
        public ulong plunder_battle_start_time { get; set; }

    }

    [ProtoContract]
    public class _plunder_server_info
    {
        [ProtoMember(1)]

        public int plunder_tid { get; set; }
        [ProtoMember(2)]
        public int plunder_status { get; set; }
        [ProtoMember(3)]
        public ulong occupy_guild_uid { get; set; }
        [ProtoMember(4)]
        public ulong plunder_battle_start_time { get; set; }

    }

    [ProtoContract]
    public class _dark_altar_info
    {
        [ProtoMember(1)]

        public int dark_altar_tid { get; set; }
        [ProtoMember(2)]
        public int dark_altar_status { get; set; }
        [ProtoMember(3)]
        public ulong this_battle_start_time { get; set; }
        [ProtoMember(4)]
        public ulong altar_gen_time { get; set; }

    }

    [ProtoContract]
    public class _dark_altar_server_info
    {
        [ProtoMember(1)]

        public int dark_altar_tid { get; set; }
        [ProtoMember(2)]
        public int dark_altar_status { get; set; }
        [ProtoMember(3)]
        public ulong this_battle_start_time { get; set; }
        [ProtoMember(4)]
        public ulong altar_gen_time { get; set; }

    }

    [ProtoContract]
    public class _force_info
    {
        [ProtoMember(1)]

        public int force_id { get; set; }
        [ProtoMember(2)]
        public int level { get; set; }
        [ProtoMember(3)]
        public int upgrade_time { get; set; }

    }

    [ProtoContract]
    public class _force_blood_info
    {
        [ProtoMember(1)]

        public int force_id { get; set; }
        [ProtoMember(2)]
        public int blood_slot_id { get; set; }
        [ProtoMember(3)]
        public int blood_slot_level { get; set; }

    }

    [ProtoContract]
    public class _force_level_info
    {
        [ProtoMember(1)]

        public int force_id { get; set; }
        [ProtoMember(2)]
        public int level { get; set; }

    }

    [ProtoContract]
    public class _potential_info
    {
        [ProtoMember(1)]

        public uint id { get; set; }
        [ProtoMember(2)]
        public int level { get; set; }

    }

    [ProtoContract]
    public class _treasure_open_info
    {
        [ProtoMember(1)]

        public uint treasure_index { get; set; }

    }

    [ProtoContract]
    public class customize_info
    {
        [ProtoMember(1)]

        public int type { get; set; }
        [ProtoMember(2)]
        public int value { get; set; }

    }

    [ProtoContract]
    public class _costume_info
    {
        [ProtoMember(1)]

        public int costume_id { get; set; }
        [ProtoMember(2)]
        public int palette_group_id { get; set; }
        [ProtoMember(3)]
        public int palette_main_id { get; set; }
        [ProtoMember(4)]
        public int palette_main_brightness { get; set; }
        [ProtoMember(5)]
        public int palette_sub_id { get; set; }
        [ProtoMember(6)]
        public int palette_sub_brightness { get; set; }

    }

    [ProtoContract]
    public class _equip_costume_info
    {
        [ProtoMember(1)]

        public uint parts { get; set; }
        [ProtoMember(2)]
        public int costume_index { get; set; }
        [ProtoMember(3)]
        public int palette_group_id { get; set; }
        [ProtoMember(4)]
        public int palette_main_id { get; set; }
        [ProtoMember(5)]
        public int palette_main_brightness { get; set; }
        [ProtoMember(6)]
        public int palette_sub_id { get; set; }
        [ProtoMember(7)]
        public int palette_sub_brightness { get; set; }

    }

    [ProtoContract]
    public class _costume_hide_info
    {
        [ProtoMember(1)]

        public uint parts { get; set; }
        [ProtoMember(2)]
        public bool is_hide { get; set; }

    }

    [ProtoContract]
    public class _equip_luxury_costume_info
    {
        [ProtoMember(1)]

        public uint parts { get; set; }
        [ProtoMember(2)]
        public ulong equip_item_uid { get; set; }

    }

    [ProtoContract]
    public class _luxury_costume_hide_info
    {
        [ProtoMember(1)]

        public uint parts { get; set; }
        [ProtoMember(2)]
        public bool is_hide { get; set; }

    }

    [ProtoContract]
    public class _shop_ui_limit_buy_item_data
    {
        [ProtoMember(1)]

        public uint buy_id { get; set; }
        [ProtoMember(2)]
        public uint buy_count { get; set; }
        [ProtoMember(3)]
        public int last_buy_count_time { get; set; }
        [ProtoMember(4)]
        public long reset_time { get; set; }

    }

    [ProtoContract]
    public class _object_casting_info
    {
        [ProtoMember(1)]

        public uint casting_time { get; set; }
        [ProtoMember(2)]
        public ulong casting_start_time { get; set; }

    }

    [ProtoContract]
    public class _casting_info
    {
        [ProtoMember(1)]

        public uint casting_type { get; set; }
        [ProtoMember(2)]
        public uint casting_sub_type { get; set; }
        [ProtoMember(3)]
        public uint casting_target_type { get; set; }
        [ProtoMember(4)]
        public ulong casting_target_uid { get; set; }
        [ProtoMember(5)]
        public uint contents_data_ex { get; set; }
        [ProtoMember(6)]
        public uint casting_time_ms { get; set; }
        [ProtoMember(7)]
        public bool is_auto_casting { get; set; }

    }

    [ProtoContract]
    public class _party_member_info
    {
        [ProtoMember(1)]

        public ulong member_uid { get; set; }
        [ProtoMember(2)]
        public int member_class { get; set; }
        [ProtoMember(3)]
        public int level { get; set; }
        [ProtoMember(4)]
        public string nickname { get; set; }
        [ProtoMember(5)]
        public int stageid { get; set; }
        [ProtoMember(6)]
        public int combatpoint { get; set; }
        [ProtoMember(7)]
        public int channel_index { get; set; }
        [ProtoMember(8)]
        public bool alive { get; set; }
        [ProtoMember(9)]
        public int slot_index { get; set; }
        [ProtoMember(10)]
        public string guild_name { get; set; }
        [ProtoMember(11)]
        public uint guild_mark { get; set; }
        [ProtoMember(12)]
        public uint guild_mark_edge { get; set; }
        [ProtoMember(13)]
        public ulong guild_uid { get; set; }
        [ProtoMember(14)]
        public uint member_voice_chat_state { get; set; }
        [ProtoMember(15)]
        public uint slot_class { get; set; }
        [ProtoMember(16)]
        public bool is_ready { get; set; }
        [ProtoMember(17)]
        public string profile { get; set; }
        [ProtoMember(18)]
        _refuse_info refuse_buff_info { get; set; }
        [ProtoMember(19)]
        public uint world_id { get; set; }

    }

    [ProtoContract]
    public class _party_attribute
    {
        [ProtoMember(1)]

        public uint party_stage_type { get; set; }
        [ProtoMember(2)]
        public uint party_target_stage_index { get; set; }
        [ProtoMember(3)]
        public string party_description { get; set; }
        [ProtoMember(4)]
        public uint joinable_type { get; set; }
        [ProtoMember(5)]
        public uint limit_combat_point { get; set; }
        [ProtoMember(6)]
        public uint party_level { get; set; }
        [ProtoMember(7)]
        public uint party_header_type { get; set; }
        [ProtoMember(8)]
        public uint party_number_type { get; set; }

    }

    [ProtoContract]
    public class _party_info
    {
        [ProtoMember(1)]

        public ulong party_leader_uid { get; set; }
        [ProtoMember(2)]
        public ulong party_uid { get; set; }
        [ProtoMember(3)]
        _party_attribute party_attribute { get; set; }
        [ProtoMember(4)]
        public uint party_create_time { get; set; }
        [ProtoMember(5)]
        public uint party_update_time { get; set; }
        [ProtoMember(6)]
        public uint dungeon_start_time { get; set; }
        [ProtoMember(7)]
        public ulong party_guild_uid { get; set; }
        [ProtoMember(8)]
        public uint dungeon_startable_time { get; set; }
        [ProtoMember(9)]
        public uint target_entity_type { get; set; }
        [ProtoMember(10)]
        public ulong target_uid { get; set; }
        [ProtoMember(11)]
        public ulong target_zone_uid { get; set; }
        [ProtoMember(12)]
        public uint target_stage_id { get; set; }
        [ProtoMember(13)]
        public int dungeon_auto_start { get; set; }
        [ProtoMember(14)]
        public bool assassin_mode { get; set; }

    }

    [ProtoContract]
    public class _gameserver_sync_party_info
    {
        [ProtoMember(1)]

        public ulong party_uid { get; set; }
        [ProtoMember(2)]
        public _party_info party_info { get; set; }
        [ProtoMember(3)]
        public _party_member_info[] party_member_infos { get; set; }

    }

    [ProtoContract]
    public class _gameserver_sync_hunting_squad_info
    {
        [ProtoMember(1)]

        public ulong hunting_squad_uid { get; set; }
        [ProtoMember(2)]
        public ulong leader_uid { get; set; }

    }

    [ProtoContract]
    public class _gameserver_sync_magic_square_exit_time
    {
        [ProtoMember(1)]

        public ulong exit_time { get; set; }

    }

    [ProtoContract]
    public class _gameserver_sync_secret_dungeon_exit_time
    {
        [ProtoMember(1)]

        public ulong exit_time { get; set; }

    }

    [ProtoContract]
    public class _guild_member_authority
    {
        [ProtoMember(1)]

        public uint authority_type { get; set; }
        [ProtoMember(2)]
        public bool authority_value { get; set; }

    }

    [ProtoContract]
    public class supply_unlock_time
    {
        [ProtoMember(1)]

        public uint index { get; set; }
        [ProtoMember(2)]
        public long unlock_time { get; set; }

    }

    [ProtoContract]
    public class _friend_info_base
    {
        [ProtoMember(1)]

        public ulong friend_uid { get; set; }
        [ProtoMember(2)]
        public int friend_class { get; set; }
        [ProtoMember(3)]
        public int level { get; set; }
        [ProtoMember(4)]
        public string nickname { get; set; }
        [ProtoMember(5)]
        public string custom_title { get; set; }
        [ProtoMember(6)]
        public int stageid { get; set; }
        [ProtoMember(7)]
        public int combatpoint { get; set; }
        [ProtoMember(8)]
        public ulong guild_uid { get; set; }
        [ProtoMember(9)]
        public string guild_name { get; set; }
        [ProtoMember(10)]
        public uint guild_mark { get; set; }
        [ProtoMember(11)]
        public uint guild_mark_edge { get; set; }
        [ProtoMember(12)]
        public ulong last_logout_time { get; set; }
        [ProtoMember(13)]
        public string profile { get; set; }

    }

    [ProtoContract]
    public class _friend_info
    {
        [ProtoMember(1)]

        public _friend_info_base friend_info_base { get; set; }
        [ProtoMember(2)]
        public bool online { get; set; }
        [ProtoMember(3)]
        public bool favorites { get; set; }

    }

    [ProtoContract]
    public class _friend_request_info
    {
        [ProtoMember(1)]

        public _friend_info_base friend_info_base { get; set; }
        [ProtoMember(2)]
        public ulong request_time { get; set; }

    }

    [ProtoContract]
    public class _recommend_friend_info
    {
        [ProtoMember(1)]

        public _friend_info_base friend_info_base { get; set; }
        [ProtoMember(2)]
        public bool online { get; set; }

    }

    [ProtoContract]
    public class _bless_info
    {
        [ProtoMember(1)]

        public uint equip_slot_num { get; set; }
        [ProtoMember(2)]
        public uint grade { get; set; }

    }

    [ProtoContract]
    public class _pk_history_info
    {
        [ProtoMember(1)]

        public ulong event_time { get; set; }
        [ProtoMember(2)]
        public bool result { get; set; }
        [ProtoMember(3)]
        public bool isaggressor { get; set; }
        [ProtoMember(4)]
        public ulong character_uid { get; set; }
        [ProtoMember(5)]
        public int _class { get; set; }
        [ProtoMember(6)]
        public string nickname { get; set; }
        [ProtoMember(7)]
        public int combatpoint { get; set; }
        [ProtoMember(8)]
        public _guild_name_ui_info guildinfo { get; set; }
        [ProtoMember(9)]
        public _simple_cost_info losscostinfo { get; set; }
        [ProtoMember(10)]
        public _simple_item_info[] lossiteminfo { get; set; }
        [ProtoMember(11)]
        public ulong event_timepoint { get; set; }

    }

    [ProtoContract]
    public class fame_quest
    {
        [ProtoMember(1)]

        public int fame_quest_id { get; set; }
        [ProtoMember(2)]
        public ulong fame_score { get; set; }
        [ProtoMember(3)]
        public uint fame_level { get; set; }

    }

    [ProtoContract]
    public class fame_info
    {
        [ProtoMember(1)]

        public int fame_category_id { get; set; }
        [ProtoMember(2)]
        public fame_quest[] fame_quest_list { get; set; }

    }

    [ProtoContract]
    public class _mail_string_template
    {
        [ProtoMember(1)]

        public int type { get; set; }
        [ProtoMember(2)]
        public string value { get; set; }

    }

    [ProtoContract]
    public class _mail_data
    {
        [ProtoMember(1)]

        public ulong mail_uid { get; set; }
        [ProtoMember(2)]
        public uint mail_type { get; set; }
        [ProtoMember(3)]
        public string title { get; set; }
        [ProtoMember(4)]
        public string sub_title { get; set; }
        [ProtoMember(5)]
        public string contents { get; set; }
        [ProtoMember(6)]
        public string receive_nick_name { get; set; }
        [ProtoMember(7)]
        public string sender_nick_name { get; set; }
        [ProtoMember(8)]
        public uint send_time { get; set; }
        [ProtoMember(9)]
        public uint exptry_time { get; set; }
        [ProtoMember(10)]
        public bool is_read { get; set; }
        [ProtoMember(11)]
        public _cost_info[] gift_cost { get; set; }
        [ProtoMember(12)]
        public _simple_item_info[] gift_item { get; set; }
        [ProtoMember(13)]
        public _character_inven_item[] gift_fixitem { get; set; }
        [ProtoMember(14)]
        public uint title_idx { get; set; }
        [ProtoMember(15)]
        public uint sub_title_idx { get; set; }
        [ProtoMember(16)]
        public uint contents_idx { get; set; }
        [ProtoMember(17)]
        public string guild_name { get; set; }
        [ProtoMember(18)]
        public bool is_send_mail { get; set; }
        [ProtoMember(19)]
        public uint stage_id { get; set; }
        [ProtoMember(20)]
        public ulong guild_uid { get; set; }
        [ProtoMember(21)]
        public uint mail_sub_type { get; set; }
        [ProtoMember(22)]
        public int mail_button_idx { get; set; }
        [ProtoMember(23)]
        public int function_type { get; set; }
        [ProtoMember(25)]
        public int mail_preset_id { get; set; }
        [ProtoMember(26)]
        public string wanted_name { get; set; }
        [ProtoMember(27)]
        public string[] character_name_list { get; set; }
        [ProtoMember(28)]
        public int[] dominion_id { get; set; }
        [ProtoMember(29)]
        public int dominion_prize_id { get; set; }
        [ProtoMember(30)]
        public bool attach_get_item { get; set; }
        [ProtoMember(32)]
        public int monster_id { get; set; }
        [ProtoMember(33)]
        public int quest_id { get; set; }
        [ProtoMember(34)]
        public int pk_grade_type { get; set; }
        [ProtoMember(35)]
        public int pk_point_min { get; set; }
        [ProtoMember(36)]
        public int pk_point_max { get; set; }
        [ProtoMember(37)]
        public int ranking { get; set; }
        [ProtoMember(38)]
        public long deathpenalty_exp { get; set; }
        [ProtoMember(39)]
        public long deathpenalty_date { get; set; }
        [ProtoMember(40)]
        public int contribution_rank { get; set; }
        [ProtoMember(41)]
        public int guild_point { get; set; }
        [ProtoMember(42)]
        public int guild_war_siege_id { get; set; }
        [ProtoMember(43)]
        public int guild_war_ranking { get; set; }
        [ProtoMember(44)]
        public int guild_war_point { get; set; }
        [ProtoMember(45)]
        public int guild_money_value { get; set; }
        [ProtoMember(46)]
        public float donationreward_money_rate { get; set; }
        [ProtoMember(47)]
        public int wanted_money { get; set; }
        [ProtoMember(48)]
        public bool delete_character { get; set; }
        [ProtoMember(49)]
        public int money_type { get; set; }
        [ProtoMember(50)]
        public long money_value { get; set; }
        [ProtoMember(51)]
        public int guild_war_strong_id { get; set; }
        [ProtoMember(52)]
        public string mail_args { get; set; }
        [ProtoMember(53)]
        public long[] values { get; set; }
        [ProtoMember(54)]
        public int item_id { get; set; }
        [ProtoMember(55)]
        public int item_count { get; set; }
        [ProtoMember(56)]
        public int guild_world_id { get; set; }
    }

    [ProtoContract]
    public class _send_mail_data
    {
        [ProtoMember(1)]

        public uint mail_type { get; set; }
        [ProtoMember(2)]
        public string title { get; set; }
        [ProtoMember(3)]
        public string sub_title { get; set; }
        [ProtoMember(4)]
        public string contents { get; set; }
        [ProtoMember(5)]
        public string receive_nick_name { get; set; }

    }

    [ProtoContract]
    public class _pet_deck_info
    {
        [ProtoMember(1)]

        public int slot_id { get; set; }
        [ProtoMember(2)]
        public int pet_tid { get; set; }
        [ProtoMember(3)]
        public int deck_id { get; set; }

    }

    [ProtoContract]
    public class _pet_skill_info
    {
        [ProtoMember(1)]

        public int skill_id { get; set; }
        [ProtoMember(2)]
        public int skill_lv { get; set; }

    }

    [ProtoContract]
    public class _pet_equip_item_info
    {
        [ProtoMember(1)]

        public int slot_id { get; set; }
        [ProtoMember(2)]
        public ulong item_uid { get; set; }

    }

    [ProtoContract]
    public class _pet_info
    {
        [ProtoMember(1)]

        public int tid { get; set; }
        [ProtoMember(2)]
        public _pet_equip_item_info[] _equip_item_list { get; set; }
        [ProtoMember(3)]
        public int grade { get; set; }

    }

    [ProtoContract]
    public class _daily_goods_info
    {
        [ProtoMember(1)]

        public int DailyGoodsType { get; set; }
        [ProtoMember(2)]
        public int Value { get; set; }
        [ProtoMember(3)]
        public int RechargeCount { get; set; }
        [ProtoMember(4)]
        public long LastSpendTime { get; set; }

    }

    [ProtoContract]
    public class _great_building_info
    {
        [ProtoMember(1)]

        public int building_uid { get; set; }
        [ProtoMember(2)]
        public int opened { get; set; }
        [ProtoMember(3)]
        public int upgrade_level { get; set; }
        [ProtoMember(4)]
        public int upgrade_process_state { get; set; }
        [ProtoMember(5)]
        public long process_remain_time { get; set; }
        [ProtoMember(6)]
        public long last_harvest_time { get; set; }
        [ProtoMember(7)]
        public int product_count { get; set; }

    }

    [ProtoContract]
    public class _redis_great_building_info
    {
        [ProtoMember(1)]

        public int building_uid { get; set; }
        [ProtoMember(2)]
        public int opened { get; set; }
        [ProtoMember(3)]
        public int level { get; set; }
        [ProtoMember(4)]
        public int upgrade_process_state { get; set; }
        [ProtoMember(5)]
        public long process_start_time { get; set; }
        [ProtoMember(6)]
        public int upgrade_accel_time { get; set; }
        [ProtoMember(7)]
        public int upgrade_support_count { get; set; }
        [ProtoMember(8)]
        public long last_harvest_time { get; set; }
        [ProtoMember(9)]
        public int product_count { get; set; }

    }

    [ProtoContract]
    public class _upgrade_building_info
    {
        [ProtoMember(1)]

        public int building_id { get; set; }
        [ProtoMember(2)]
        public int building_level { get; set; }
        [ProtoMember(3)]
        public long start_upgrade_time { get; set; }
        [ProtoMember(4)]
        public int max_support_count { get; set; }
        [ProtoMember(5)]
        public int upgrade_accel_time { get; set; }
        [ProtoMember(6)]
        public int is_supportable { get; set; }

    }

    [ProtoContract]
    public class _ranking_info
    {
        [ProtoMember(1)]

        public int rank { get; set; }
        [ProtoMember(2)]
        public ulong character_uid { get; set; }
        [ProtoMember(3)]
        public string nickname { get; set; }
        [ProtoMember(4)]
        public int _class { get; set; }
        [ProtoMember(5)]
        public string profile { get; set; }
        [ProtoMember(6)]
        public _guild_name_ui_info guild_info { get; set; }
        [ProtoMember(7)]
        public long ranking_value { get; set; }

    }

    [ProtoContract]
    public class _guild_ranking_info
    {
        [ProtoMember(1)]

        public int rank { get; set; }
        [ProtoMember(2)]
        public ulong guild_uid { get; set; }
        [ProtoMember(3)]
        public string guild_name { get; set; }
        [ProtoMember(4)]
        public uint guild_mark { get; set; }
        [ProtoMember(5)]
        public uint guild_mark_edge { get; set; }
        [ProtoMember(6)]
        public ulong master_uid { get; set; }
        [ProtoMember(7)]
        public string master_nickname { get; set; }
        [ProtoMember(8)]
        public string master_profile { get; set; }
        [ProtoMember(9)]
        public uint guild_member_num { get; set; }
        [ProtoMember(10)]
        public long ranking_value { get; set; }

    }

    [ProtoContract]
    public class _guild_sort_info
    {
        [ProtoMember(1)]

        public ulong guild_uid { get; set; }
        [ProtoMember(2)]
        public int rank { get; set; }
        [ProtoMember(3)]
        public string guild_name { get; set; }
        [ProtoMember(4)]
        public uint guild_level { get; set; }
        [ProtoMember(5)]
        public uint guild_mark { get; set; }
        [ProtoMember(6)]
        public uint guild_mark_edge { get; set; }
        [ProtoMember(7)]
        public uint guild_members { get; set; }
        [ProtoMember(8)]
        public uint guild_max_members { get; set; }
        [ProtoMember(9)]
        public long total_combat_point { get; set; }
        [ProtoMember(10)]
        public uint guild_join_type { get; set; }
        [ProtoMember(11)]
        public long join_limit_combat_point { get; set; }
        [ProtoMember(12)]
        public string guild_pr { get; set; }

    }

    [ProtoContract]
    public class _guild_search_info
    {
        [ProtoMember(1)]

        public ulong guild_uid { get; set; }
        [ProtoMember(2)]
        public int rank { get; set; }
        [ProtoMember(3)]
        public string guild_name { get; set; }
        [ProtoMember(4)]
        public uint guild_level { get; set; }
        [ProtoMember(5)]
        public uint guild_mark { get; set; }
        [ProtoMember(6)]
        public uint guild_mark_edge { get; set; }
        [ProtoMember(7)]
        public uint guild_members { get; set; }
        [ProtoMember(8)]
        public uint guild_max_members { get; set; }
        [ProtoMember(9)]
        public long total_combat_point { get; set; }
        [ProtoMember(10)]
        public string master_name { get; set; }
        [ProtoMember(12)]
        public uint sabuk_title_id { get; set; }

    }

    [ProtoContract]
    public class _character_search_info
    {
        [ProtoMember(1)]

        public int rank { get; set; }
        [ProtoMember(2)]
        public long character_uid { get; set; }
        [ProtoMember(3)]
        public string nickname { get; set; }
        [ProtoMember(4)]
        public int level { get; set; }
        [ProtoMember(5)]
        public string profile { get; set; }
        [ProtoMember(6)]
        _guild_name_ui_info guild_info { get; set; }
        [ProtoMember(7)]
        public int fame_level { get; set; }
        [ProtoMember(8)]
        public int combat_point { get; set; }
        [ProtoMember(9)]
        public int char_class { get; set; }
        [ProtoMember(10)]
        public bool is_guild_invite { get; set; }
        [ProtoMember(11)]
        public bool is_online { get; set; }
        [ProtoMember(12)]
        _cost_info can_receive_money_limit { get; set; }

    }

    [ProtoContract]
    public class _guild_expedition_list
    {
        [ProtoMember(1)]

        public uint guild_expedission_id { get; set; }
        [ProtoMember(2)]
        public int event_state { get; set; }
        [ProtoMember(3)]
        public bool is_clear { get; set; }
        [ProtoMember(4)]
        public bool is_lock { get; set; }
        [ProtoMember(5)]
        public int summon_count { get; set; }

    }

    [ProtoContract]
    public class _world_event_boss_gen
    {
        [ProtoMember(1)]

        public int gen_id { get; set; }
        [ProtoMember(2)]
        public int boss_id { get; set; }

    }

    [ProtoContract]
    public class upgrade_building_data
    {
        [ProtoMember(1)]

        public int building_id { get; set; }
        [ProtoMember(2)]
        public int building_level { get; set; }
        [ProtoMember(3)]
        public long start_time_t { get; set; }
        [ProtoMember(4)]
        public int support_count { get; set; }
        [ProtoMember(5)]
        public ulong total_accelerate_time { get; set; }
        [ProtoMember(6)]
        public bool is_supportable { get; set; }
        [ProtoMember(7)]
        public int max_support_count { get; set; }
        [ProtoMember(8)]
        public int remain_time { get; set; }

    }

    [ProtoContract]
    public class upgrade_building_notice_game_data
    {
        [ProtoMember(1)]

        public int building_id { get; set; }
        [ProtoMember(2)]
        public int support_count { get; set; }

    }

    [ProtoContract]
    public class _guild_gift_box_info
    {
        [ProtoMember(1)]

        public uint guild_gift_level { get; set; }
        [ProtoMember(2)]
        public uint guild_gift_exp { get; set; }
        [ProtoMember(3)]
        public uint guild_gift_box_key { get; set; }
        [ProtoMember(4)]
        public ulong guild_gift_box_key_full_time { get; set; }
        [ProtoMember(5)]
        public uint guild_gift_box_key_maintain_time { get; set; }

    }

    [ProtoContract]
    public class _guild_gift_info
    {
        [ProtoMember(1)]

        public ulong gift_uid { get; set; }
        [ProtoMember(2)]
        public uint gift_id { get; set; }
        [ProtoMember(3)]
        public uint gift_tap_type { get; set; }
        [ProtoMember(4)]
        public ulong send_character_uid { get; set; }
        [ProtoMember(5)]
        public string send_character_name { get; set; }
        [ProtoMember(6)]
        public uint is_open { get; set; }
        [ProtoMember(7)]
        public uint gain_gift_type { get; set; }
        [ProtoMember(8)]
        public uint gain_gift_sub_type { get; set; }
        [ProtoMember(9)]
        public uint gain_gift_value { get; set; }
        [ProtoMember(10)]
        public ulong gift_recv_date { get; set; }
        [ProtoMember(11)]
        public ulong gift_end_date { get; set; }

    }

    [ProtoContract]
    public class _guild_gift_gain_info
    {
        [ProtoMember(1)]

        public uint gain_gift_type { get; set; }
        [ProtoMember(2)]
        public uint gain_gift_sub_type { get; set; }
        [ProtoMember(3)]
        public uint gain_gift_value { get; set; }

    }

    [ProtoContract]
    public class _guild_command_mark
    {
        [ProtoMember(1)]

        public int command_mark_idx { get; set; }
        [ProtoMember(2)]
        public ulong target_uid { get; set; }
        [ProtoMember(3)]
        public uint target_world_id { get; set; }

    }

    [ProtoContract]
    public class _pk_wanted_info
    {
        [ProtoMember(1)]

        public ulong wanted_uid { get; set; }
        [ProtoMember(2)]
        public ulong character_uid { get; set; }
        [ProtoMember(3)]
        public string nickname { get; set; }
        [ProtoMember(4)]
        public int _class { get; set; }
        [ProtoMember(5)]
        public long combatpoint { get; set; }
        [ProtoMember(6)]
        public _guild_name_ui_info guildinfo { get; set; }
        [ProtoMember(7)]
        public int cumulative_count { get; set; }
        [ProtoMember(8)]
        public int prize_type { get; set; }
        [ProtoMember(9)]
        public long prize { get; set; }
        [ProtoMember(10)]
        public long fram_point { get; set; }
        [ProtoMember(11)]
        public long wanted_end_time { get; set; }
        [ProtoMember(12)]
        public int end_type { get; set; }

    }

    [ProtoContract]
    public class _user_event_info
    {
        [ProtoMember(1)]

        public int event_id { get; set; }
        [ProtoMember(2)]
        public int event_step { get; set; }
        [ProtoMember(3)]
        public int reward_available { get; set; }
        [ProtoMember(4)]
        public long event_end_time { get; set; }
        [ProtoMember(5)]
        public int[] unattended_step { get; set; }
        [ProtoMember(6)]
        _gacha_info gacha_info { get; set; }
        [ProtoMember(7)]
        public int[] rewarded_step { get; set; }

    }

    [ProtoContract]
    public class _imperial_order_count
    {
        [ProtoMember(1)]

        public int imperial_order_id { get; set; }
        [ProtoMember(2)]
        public int imperial_order_count { get; set; }

    }

    [ProtoContract]
    public class _dominion_info
    {
        [ProtoMember(1)]

        public int dominion_id { get; set; }
        [ProtoMember(2)]
        public int tax_rate { get; set; }
        [ProtoMember(3)]
        public int tax_rate_new { get; set; }
        [ProtoMember(4)]
        public ulong tax_rate_update_date { get; set; }
        [ProtoMember(5)]
        public bool is_tax_on { get; set; }
        [ProtoMember(6)]
        public int imperial_order { get; set; }
        [ProtoMember(7)]
        public ulong imperial_order_end_time { get; set; }
        [ProtoMember(8)]
        public ulong guild_uid { get; set; }
        [ProtoMember(9)]
        public int dominion_type { get; set; }
        [ProtoMember(10)]
        public _dominion_prize_info[] dominion_prize_list { get; set; }
        [ProtoMember(11)]
        public int tax_rate_gold { get; set; }
        [ProtoMember(12)]
        public int tax_rate_new_gold { get; set; }
        [ProtoMember(13)]
        _guild_simple_info guild_info { get; set; }
        [ProtoMember(14)]
        public bool is_member_count_over { get; set; }
        [ProtoMember(15)]
        public bool is_storage_open { get; set; }
        [ProtoMember(16)]
        public _cost_info[] storage_cost_info { get; set; }
        [ProtoMember(17)]
        public _cost_info[] storage_guild_give_cost_info { get; set; }
        [ProtoMember(18)]
        public _imperial_order_count[] imperial_order_count_list { get; set; }
        [ProtoMember(19)]
        public _cost_info[] tax_cost_list { get; set; }
        [ProtoMember(20)]
        public int world_id { get; set; }
        [ProtoMember(21)]
        public ulong sabuk_guild_update_date { get; set; }

    }

    [ProtoContract]
    public class _dominion_tax_log_info
    {
        [ProtoMember(1)]

        public int tax_log_type { get; set; }
        [ProtoMember(2)]
        public int tax_log_kind { get; set; }
        [ProtoMember(3)]
        public ulong tax_log_value { get; set; }

    }

    [ProtoContract]
    public class _dominion_tax_info
    {
        [ProtoMember(1)]

        public _dominion_tax_log_info[] tax_log_info { get; set; }
        [ProtoMember(2)]
        public int money_type { get; set; }
        [ProtoMember(3)]
        public ulong tax_value { get; set; }

    }

    [ProtoContract]
    public class _dominion_prize_info
    {
        [ProtoMember(1)]

        public int prize_grade { get; set; }
        [ProtoMember(2)]
        public int prize_count { get; set; }
        [ProtoMember(3)]
        public int prize_max { get; set; }
        [ProtoMember(4)]
        public ulong[] prize_character_list { get; set; }

    }

    [ProtoContract]
    public class _dominion_title_info
    {
        [ProtoMember(1)]

        public int title_id { get; set; }
        [ProtoMember(2)]
        public ulong title_user_uid { get; set; }
        [ProtoMember(3)]
        public string title_user_name { get; set; }
        [ProtoMember(4)]
        public string title_user_profile { get; set; }

    }

    [ProtoContract]
    public class _gacha_info
    {
        [ProtoMember(1)]

        public int gacha_type { get; set; }
        [ProtoMember(2)]
        public int free_type { get; set; }
        [ProtoMember(3)]
        public int free_count { get; set; }
        [ProtoMember(4)]
        public ulong free_time { get; set; }
        [ProtoMember(5)]
        public int day_gold_pull_count { get; set; }
        [ProtoMember(6)]
        public ulong day_gold_pull_time { get; set; }
        [ProtoMember(7)]
        public ulong left_free_time { get; set; }
        [ProtoMember(8)]
        public int current_event_point { get; set; }
        [ProtoMember(9)]
        public int day_event_pull_count { get; set; }
        [ProtoMember(10)]
        public ulong day_event_pull_time { get; set; }
        [ProtoMember(11)]
        public int bonus_gacha_point { get; set; }
        [ProtoMember(12)]
        public ulong bonus_gacha_event_end_time { get; set; }
        [ProtoMember(13)]
        public int limit_gacha_count { get; set; }
        [ProtoMember(14)]
        public ulong limit_gacha_pull_time { get; set; }
        [ProtoMember(15)]
        public ulong next_limit_reset_time { get; set; }

    }

    [ProtoContract]
    public class _item_collection_info
    {
        [ProtoMember(1)]

        public int collection_id { get; set; }
        [ProtoMember(2)]
        public int[] collect_slot_list { get; set; }
        [ProtoMember(3)]
        public int phase_group_id { get; set; }

    }

    [ProtoContract]
    public class _dungeon_ticket_info
    {
        [ProtoMember(1)]

        public int ticket_type { get; set; }
        [ProtoMember(2)]
        public int ticket_count { get; set; }
        [ProtoMember(3)]
        public int ticket_max { get; set; }
        [ProtoMember(4)]
        public int ticket_buy_count { get; set; }
        [ProtoMember(5)]
        public ulong last_update_time { get; set; }

    }

    [ProtoContract]
    public class _stat_contents_info
    {
        [ProtoMember(1)]

        public int stat_id { get; set; }
        [ProtoMember(2)]
        public int stat_contents_id { get; set; }
        [ProtoMember(3)]
        public int stat_value { get; set; }

    }

    [ProtoContract]
    public class _character_event_data_info
    {
        [ProtoMember(1)]

        public int event_data_id { get; set; }
        [ProtoMember(2)]
        public long count { get; set; }

    }

    [ProtoContract]
    public class _character_battle_pass_info
    {
        [ProtoMember(1)]

        public int battle_pass_idx { get; set; }
        [ProtoMember(2)]
        public long battle_pass_date { get; set; }

    }

    [ProtoContract]
    public class _character_battle_pass_complete_info
    {
        [ProtoMember(1)]

        public int battle_pass_mission_id { get; set; }
        [ProtoMember(2)]
        public ulong battle_pass_info_uid { get; set; }
        [ProtoMember(3)]
        public int battle_pass_group_type { get; set; }

    }

    [ProtoContract]
    public class _character_battle_pass_reward_info
    {
        [ProtoMember(1)]

        public int battle_pass_reward_id { get; set; }
        [ProtoMember(2)]
        public ulong battle_pass_info_uid { get; set; }

    }

    [ProtoContract]
    public class _character_battle_pass_date
    {
        [ProtoMember(1)]

        public ulong battle_pass_info_uid { get; set; }
        [ProtoMember(2)]
        public ulong character_battle_pass { get; set; }
        [ProtoMember(3)]
        public ulong character_battle_pass2 { get; set; }
        [ProtoMember(4)]
        public int order { get; set; }
        [ProtoMember(5)]
        public ulong mission_start_time { get; set; }
        [ProtoMember(6)]
        public ulong mission_end_time { get; set; }

    }

    [ProtoContract]
    public class _character_battle_pass_check
    {
        [ProtoMember(1)]

        public int battle_pass_group_type { get; set; }
        [ProtoMember(2)]
        public int battle_pass_check_level { get; set; }

    }

    [ProtoContract]
    public class _dominion_history_info
    {
        [ProtoMember(1)]

        public ulong history_uid { get; set; }
        [ProtoMember(2)]
        public ulong guild_uid { get; set; }
        [ProtoMember(3)]
        public int dominion_tid { get; set; }
        [ProtoMember(4)]
        public int history_type { get; set; }
        [ProtoMember(5)]
        public int tax_rate { get; set; }
        [ProtoMember(6)]
        public int prize_tid { get; set; }
        [ProtoMember(7)]
        public int title_tid { get; set; }
        [ProtoMember(8)]
        public int wanted_tid { get; set; }
        [ProtoMember(9)]
        public ulong send_character_uid { get; set; }
        [ProtoMember(10)]
        public string send_character_name { get; set; }
        [ProtoMember(11)]
        public ulong recv_character_uid { get; set; }
        [ProtoMember(12)]
        public string recv_character_name { get; set; }
        [ProtoMember(13)]
        public int imperial_order_tid { get; set; }
        [ProtoMember(14)]
        public ulong regdate { get; set; }
        [ProtoMember(15)]
        public string guild_name { get; set; }
        [ProtoMember(16)]
        public int target_world_id { get; set; }
        [ProtoMember(17)]
        public ulong recv_guild_uid { get; set; }
        [ProtoMember(18)]
        public string recv_guild_name { get; set; }

    }

    [ProtoContract]
    public class _guild_develop_skill_info
    {
        [ProtoMember(1)]

        public uint index { get; set; }
        [ProtoMember(2)]
        public long skill_remaining_time { get; set; }

    }

    [ProtoContract]
    public class death_penalty_info
    {
        [ProtoMember(1)]

        public ulong death_penalty_uid { get; set; }
        [ProtoMember(2)]
        public int penalty_type { get; set; }
        [ProtoMember(3)]
        public uint stage_id { get; set; }
        [ProtoMember(4)]
        public int channel_id { get; set; }
        [ProtoMember(5)]
        public float x { get; set; }
        [ProtoMember(7)]
        public float y { get; set; }
        [ProtoMember(8)]
        public float z { get; set; }
        [ProtoMember(9)]
        public long exp { get; set; }
        [ProtoMember(10)]
        public _cost_info[] drop_cost { get; set; }
        [ProtoMember(11)]
        public _character_inven_item[] drop_item { get; set; }
        [ProtoMember(12)]
        public long start_date { get; set; }
        [ProtoMember(13)]
        public long end_date { get; set; }
        [ProtoMember(14)]
        public int level { get; set; }
        [ProtoMember(15)]
        public bool disabled { get; set; }
        [ProtoMember(16)]
        public bool recovery_completed { get; set; }
        [ProtoMember(17)]
        public int world_id { get; set; }

    }

    [ProtoContract]
    public class _character_cashbag_info
    {
        [ProtoMember(1)]

        public int goods_id { get; set; }
        [ProtoMember(2)]
        public long insert_time { get; set; }
        [ProtoMember(3)]
        public long pay_id { get; set; }
        [ProtoMember(4)]
        public int pay_second_id { get; set; }
        [ProtoMember(5)]
        public string gift_sender_nick_name { get; set; }

    }

    [ProtoContract]
    public class _gm_contents_lock
    {
        [ProtoMember(1)]

        public int contents_type { get; set; }
        [ProtoMember(2)]
        public int contents_value { get; set; }
        [ProtoMember(3)]
        public int contents_lock { get; set; }

    }

    [ProtoContract]
    public class _gm_gen_time
    {
        [ProtoMember(1)]

        public int stage_id { get; set; }
        [ProtoMember(2)]
        public float gen_percent { get; set; }

    }

    [ProtoContract]
    public class _compose_fail_data
    {
        [ProtoMember(1)]

        public int fail_point_type { get; set; }
        [ProtoMember(2)]
        public int corrent_fail_point { get; set; }

    }

    [ProtoContract]
    public class _period_goods_data
    {
        [ProtoMember(1)]

        public int period_id { get; set; }
        [ProtoMember(2)]
        public int buy_time { get; set; }
        [ProtoMember(3)]
        public bool is_first_reward { get; set; }
        [ProtoMember(4)]
        public int last_receive_daily_reward_time { get; set; }
        [ProtoMember(5)]
        public int daily_receive_count { get; set; }
        [ProtoMember(6)]
        public bool is_end { get; set; }
        [ProtoMember(7)]
        public int end_time { get; set; }
        [ProtoMember(8)]
        public int total_end_time { get; set; }
        [ProtoMember(9)]
        public long reset_time { get; set; }

    }

    [ProtoContract]
    public class _item_cooltime_data
    {
        [ProtoMember(1)]

        public int item_sub_type { get; set; }
        [ProtoMember(2)]
        public long end_time { get; set; }
        [ProtoMember(3)]
        public long item_remain_cooltime { get; set; }

    }

    [ProtoContract]
    public class _item_subcooltime_data
    {
        [ProtoMember(1)]

        public int item_sub_type { get; set; }
        [ProtoMember(2)]
        public long last_used_time { get; set; }

    }

    [ProtoContract]
    public class _closed_training_satus_data
    {
        [ProtoMember(1)]

        public int status_Id { get; set; }
        [ProtoMember(2)]
        public int status_level { get; set; }

    }

    [ProtoContract]
    public class _closed_training_data
    {
        [ProtoMember(1)]

        public int training_group_Id { get; set; }
        [ProtoMember(2)]
        public _closed_training_satus_data[] status_data_list { get; set; }

    }

    [ProtoContract]
    public class _character_phase_info
    {
        [ProtoMember(1)]

        public int open_phase_class { get; set; }
        [ProtoMember(2)]
        public _character_skill[] character_skill { get; set; }

    }

    [ProtoContract]
    public class _contract_transaction_info
    {
        [ProtoMember(1)]

        public string user_address { get; set; }
        [ProtoMember(2)]
        public string nonce { get; set; }
        [ProtoMember(3)]
        public string access_token { get; set; }
        [ProtoMember(4)]
        public string validator_hash { get; set; }
        [ProtoMember(5)]
        public string hash_sign { get; set; }
        [ProtoMember(6)]
        public ulong id { get; set; }
        [ProtoMember(7)]
        public uint transaction_type { get; set; }
        [ProtoMember(8)]
        public ulong totalamount { get; set; }
        [ProtoMember(9)]
        public uint amount { get; set; }
        [ProtoMember(10)]
        public string coin_str { get; set; }
        [ProtoMember(11)]
        public ulong derby { get; set; }
        [ProtoMember(12)]
        public string token_uri { get; set; }
        [ProtoMember(13)]
        public ulong token_id { get; set; }
        [ProtoMember(14)]
        public int zone_group_id { get; set; }

    }

    [ProtoContract]
    public class _characterInfo_mint
    {
        [ProtoMember(1)]

        public long character_uid { get; set; }
        [ProtoMember(2)]
        public int eClass { get; set; }
        [ProtoMember(3)]
        public int Level { get; set; }
        [ProtoMember(4)]
        public string NickName { get; set; }
        [ProtoMember(5)]
        public int CombatPoint { get; set; }
        [ProtoMember(6)]
        public long token_id { get; set; }

    }

    [ProtoContract]
    public class _holy_stuff_slot_info
    {
        [ProtoMember(1)]

        public int slot_Id { get; set; }
        [ProtoMember(2)]
        public int slot_level { get; set; }

    }

    [ProtoContract]
    public class _holy_stuff_info
    {
        [ProtoMember(1)]

        public int holy_stuff_id { get; set; }
        [ProtoMember(2)]
        public int holy_stuff_grade { get; set; }
        [ProtoMember(3)]
        public _holy_stuff_slot_info[] slot_infos { get; set; }

    }

    [ProtoContract]
    public class _quick_slot
    {
        [ProtoMember(1)]

        public uint slot_index { get; set; }
        [ProtoMember(2)]
        public uint item_index { get; set; }

    }

    [ProtoContract]
    public class _sabuk_taxrate_info
    {
        [ProtoMember(1)]

        public int money_type { get; set; }
        [ProtoMember(2)]
        public int tax_rate { get; set; }
        [ProtoMember(3)]
        public ulong yesterday_tax_value { get; set; }

    }

    [ProtoContract]
    public class _dominion_sabuk_taxrate_info
    {
        [ProtoMember(1)]

        public uint world_id { get; set; }
        [ProtoMember(2)]
        _guild_simple_info guild_info { get; set; }
        [ProtoMember(3)]
        public _sabuk_taxrate_info[] sabuk_taxrate_infos { get; set; }

    }

    [ProtoContract]
    public class _dominion_sabuk_imperialorder_info
    {
        [ProtoMember(1)]

        public uint world_id { get; set; }
        [ProtoMember(2)]
        public uint imperial_order_buff { get; set; }
        [ProtoMember(3)]
        public ulong imperial_order_end_buff_time { get; set; }
        [ProtoMember(4)]
        _guild_simple_info guild_info { get; set; }

    }

    [ProtoContract]
    public class _dominion_sabuk_guild_title_info
    {
        [ProtoMember(1)]

        public int title_id { get; set; }
        [ProtoMember(2)]
        public uint world_id { get; set; }
        [ProtoMember(3)]
        public ulong title_guild_id { get; set; }
        [ProtoMember(4)]
        _guild_simple_info guild_info { get; set; }

    }

    [ProtoContract]
    public class _dominion_sabuk_bicheon_tax_interval
    {
        [ProtoMember(1)]

        public uint world_id { get; set; }
        [ProtoMember(2)]
        public ulong gold_tax { get; set; }
        [ProtoMember(3)]
        public ulong black_iron_tax { get; set; }

    }

    [ProtoContract]
    public class _character_event_pass_data_info
    {
        [ProtoMember(1)]

        public int event_pass_data_id { get; set; }
        [ProtoMember(2)]
        public long count { get; set; }

    }

    [ProtoContract]
    public class _character_event_pass_info
    {
        [ProtoMember(1)]

        public int event_pass_idx { get; set; }
        [ProtoMember(2)]
        public long event_pass_date { get; set; }
        [ProtoMember(3)]
        public int event_pass_user_event_id { get; set; }
        [ProtoMember(4)]
        public int group_type { get; set; }

    }

    [ProtoContract]
    public class _character_event_pass_mission_complete_info
    {
        [ProtoMember(1)]

        public int event_pass_mission_id { get; set; }
        [ProtoMember(2)]
        public int event_pass_user_event_id { get; set; }
        [ProtoMember(3)]
        public int event_pass_group_type { get; set; }

    }

    [ProtoContract]
    public class _character_event_pass_reward_info
    {
        [ProtoMember(1)]

        public int event_pass_reward_id { get; set; }
        [ProtoMember(2)]
        public int event_pass_user_event_id { get; set; }
        [ProtoMember(3)]
        public int group_type { get; set; }

    }

    [ProtoContract]
    public class _character_event_pass_date
    {
        [ProtoMember(1)]

        public int event_pass_user_event_id { get; set; }
        [ProtoMember(2)]
        public ulong character_event_pass { get; set; }
        [ProtoMember(3)]
        public ulong character_event_pass2 { get; set; }
        [ProtoMember(4)]
        public ulong event_pass_start_time { get; set; }
        [ProtoMember(5)]
        public ulong event_pass_end_time { get; set; }

    }

    [ProtoContract]
    public class _character_event_pass_check
    {
        [ProtoMember(1)]

        public int event_pass_group_type { get; set; }
        [ProtoMember(2)]
        public int event_pass_check_level { get; set; }

    }

    [ProtoContract]
    public class region_mail_receipt_info
    {
        [ProtoMember(1)]

        public uint event_id { get; set; }
        [ProtoMember(2)]
        public uint state { get; set; }

    }

    [ProtoContract]
    public class _guild_friendship_info
    {
        [ProtoMember(1)]

        public int friendship_type { get; set; }
        [ProtoMember(2)]
        public ulong user_uid { get; set; }
        [ProtoMember(3)]
        public string nickname { get; set; }
        [ProtoMember(4)]
        public string profile { get; set; }
        [ProtoMember(5)]
        public int rank { get; set; }
        [ProtoMember(6)]
        public uint level { get; set; }
        [ProtoMember(7)]
        public uint class_id { get; set; }
        [ProtoMember(8)]
        public uint combat_point { get; set; }
        [ProtoMember(9)]
        _guild_name_ui_info guild_name_info { get; set; }
        [ProtoMember(10)]
        public int guild_member_grade { get; set; }
        [ProtoMember(11)]
        public int guild_partner_uid { get; set; }
        [ProtoMember(12)]
        public uint locate { get; set; }
        [ProtoMember(13)]
        public long logout_time { get; set; }
        [ProtoMember(14)]
        public string guild_custom_title { get; set; }
        [ProtoMember(15)]
        _cost_info can_receive_money_limit { get; set; }

    }

    [ProtoContract]
    public class ItemOptionInfo
    {
        [ProtoMember(1)]

        public uint index { get; set; }
        [ProtoMember(2)]
        public uint value { get; set; }
        [ProtoMember(3)]
        public uint slot { get; set; }

    }

    [ProtoContract]
    public class ItemJewelInfo
    {
        [ProtoMember(1)]

        public uint slot { get; set; }
        [ProtoMember(2)]
        public uint item_index { get; set; }

    }


    [ProtoContract]
    public class buff_list
    {
        [ProtoMember(1)]

        public _buff_info[] list { get; set; }

    }

    [ProtoContract]
    public class character_data
    {
        [ProtoMember(1)]

        public ulong account_uid { get; set; }
        [ProtoMember(2)]
        public ulong character_uid { get; set; }
        [ProtoMember(3)]
        public string nick_name { get; set; }
        [ProtoMember(4)]
        public int _class { get; set; }
        [ProtoMember(5)]
        public int level { get; set; }
        [ProtoMember(6)]
        public _characterInfo character_info { get; set; }
        [ProtoMember(7)]
        public uint escape_stage_id { get; set; }
        [ProtoMember(8)]
        public _vector3 escape_loc { get; set; }
        [ProtoMember(9)]
        public uint awaken_grade { get; set; }
        [ProtoMember(10)]
        public int action_point_last_update_time_sec { get; set; }
        [ProtoMember(11)]
        bool observer_mode { get; set; }
        [ProtoMember(12)]
        string custom_title { get; set; }
        [ProtoMember(13)]
        public uint play_time { get; set; }

    }

    [ProtoContract]
    public class costume_list
    {
        [ProtoMember(1)]

        public uint equip_costume_index { get; set; }
        [ProtoMember(2)]
        public _costume_info[] cost_list { get; set; }

    }

    [ProtoContract]
    public class equip_list
    {
        [ProtoMember(1)]

        public _character_equip_item[] list { get; set; }

    }

    [ProtoContract]
    public class inven_list
    {
        [ProtoMember(1)]

        public int use_count { get; set; }
        [ProtoMember(2)]
        public int max_count { get; set; }
        [ProtoMember(3)]
        public int buy_count { get; set; }
        [ProtoMember(4)]
        public _character_inven_item[] list { get; set; }

    }

    [ProtoContract]
    public class mastery_list
    {
        [ProtoMember(1)]

        public _character_mastery_slot[] list { get; set; }

    }

    [ProtoContract]
    public class skill_list
    {
        [ProtoMember(1)]

        public _character_skill[] active_skill_list { get; set; }
        [ProtoMember(2)]
        public _character_skill_deck[] active_skill_deck_list { get; set; }
        [ProtoMember(3)]
        public _passive_skill_info[] passive_skill_list { get; set; }
        [ProtoMember(4)]
        public _skill_passive_group[] passive_skill_group_list { get; set; }

    }

    [ProtoContract]
    public class treasure_list
    {
        [ProtoMember(1)]

        public uint[] treasure_id_list { get; set; }

    }

    [ProtoContract]
    public class tutorial_list
    {
        [ProtoMember(1)]

        public uint[] tutorial_group_id_list { get; set; }

    }

    [ProtoContract]
    public class vehicle_list
    {
        [ProtoMember(1)]

        public uint equip_group { get; set; }
        [ProtoMember(2)]
        public int equip_time { get; set; }
        [ProtoMember(3)]
        public _vehicle_info[] list { get; set; }

    }

    [ProtoContract]
    public class waypoint_list
    {
        [ProtoMember(1)]

        public uint[] list { get; set; }

    }

    [ProtoContract]
    public class mainquest_data
    {
        [ProtoMember(1)]

        public int index { get; set; }
        [ProtoMember(2)]
        public int state { get; set; }
        [ProtoMember(3)]
        public int count { get; set; }
        [ProtoMember(4)]
        public int mission_state { get; set; }

    }

    [ProtoContract]
    public class subquest_data
    {
        [ProtoMember(1)]

        public int index { get; set; }
        [ProtoMember(2)]
        public int state { get; set; }
        [ProtoMember(3)]
        public int count { get; set; }

    }

    [ProtoContract]
    public class quest_list
    {
        [ProtoMember(1)]

        mainquest_data main_quest { get; set; }
        [ProtoMember(2)]
        public subquest_data[] sub_quest_list { get; set; }
        [ProtoMember(3)]
        public int[] end_subquest_list { get; set; }
        [ProtoMember(4)]
        public int[] active_subquest_list { get; set; }

    }

    [ProtoContract]
    public class quest_daily_list
    {
        [ProtoMember(1)]

        public subquest_data[] quest_list { get; set; }

    }


    [ProtoContract]
    public class CLIENT_GAME_CHARACTER_ACHIEVEMENT_CLEAR_REWARD
    {
        [ProtoMember(1)]

        public ulong user_uid { get; set; }
        [ProtoMember(2)]
        public uint[] request_achievement_id_list { get; set; }

    }

    [ProtoContract]
    public class GAME_CLIENT_SYNC_REWARD_ACHIVEMENT
    {
        [ProtoMember(1)]

        public uint achievement_id { get; set; }
        [ProtoMember(2)]
        public _cost_info[] cost_info_list { get; set; }
        [ProtoMember(3)]
        public _character_inven_item[] reward_item_list { get; set; }

    }

    [ProtoContract]
    public class GAME_CLIENT_REWARD_ACHIEVEMENT_LIST_RESULT
    {
        [ProtoMember(1)]

        public bool success_all { get; set; }
        [ProtoMember(2)]
        public uint[] achievement_id_list { get; set; }
        [ProtoMember(3)]
        public uint error_id { get; set; }
        [ProtoMember(4)]
        public uint error_reason_achievement_id { get; set; }

    }

    [ProtoContract]
    public class GAME_CLIENT_SYNC_PLAY_DATA
    {
        [ProtoMember(1)]

        public _character_play_data_info[] play_data_list { get; set; }

    }


    [ProtoContract]
    public class WORLD_INFO
    {
        [ProtoMember(1)]

        public int index { get; set; }
        [ProtoMember(2)]
        public int state { get; set; }
        [ProtoMember(3)]
        public string name { get; set; }
        [ProtoMember(4)]
        public string ip { get; set; }
        [ProtoMember(5)]
        public int port { get; set; }
        [ProtoMember(6)]
        public int recommend_server { get; set; }
        [ProtoMember(7)]
        public int new_server { get; set; }
        [ProtoMember(8)]
        public int user_connect { get; set; }
        [ProtoMember(9)]
        public int character_create { get; set; }
        [ProtoMember(10)]
        public uint congestion { get; set; }
        [ProtoMember(11)]
        public int non_pk_server { get; set; }
        [ProtoMember(12)]
        public int nft_server { get; set; }
        [ProtoMember(13)]
        public int nft_block { get; set; }

    }

    [ProtoContract]
    public class WORLD_INFO_2
    {
        [ProtoMember(1)]

        public int index { get; set; }
        [ProtoMember(2)]
        public int state { get; set; }
        [ProtoMember(3)]
        public string name { get; set; }
        [ProtoMember(4)]
        public string ip { get; set; }
        [ProtoMember(5)]
        public int port { get; set; }
        [ProtoMember(6)]
        public int recommend_server { get; set; }
        [ProtoMember(7)]
        public int new_server { get; set; }
        [ProtoMember(8)]
        public int user_connect { get; set; }
        [ProtoMember(9)]
        public int character_create { get; set; }
        [ProtoMember(10)]
        public uint congestion { get; set; }

    }

    [ProtoContract]
    public class _front_character_info
    {
        [ProtoMember(1)]

        public int world_id { get; set; }
        [ProtoMember(2)]
        public int class_id { get; set; }
        [ProtoMember(3)]
        public string name { get; set; }
        [ProtoMember(4)]
        public int level { get; set; }

    }

    [ProtoContract]
    public class _front_world_character_info
    {
        [ProtoMember(1)]

        public int world_id { get; set; }
        [ProtoMember(2)]
        public int class_id { get; set; }
        [ProtoMember(3)]
        public string name { get; set; }
        [ProtoMember(4)]
        public int level { get; set; }
        [ProtoMember(5)]
        public ulong last_login_date { get; set; }

    }

    [ProtoContract]
    public class CLIENT_FRONT_AUTH_CUSTOM_TOKEN
    {
        [ProtoMember(1)]

        public string custom_id { get; set; }

    }

    [ProtoContract]
    public class FRONT_CLIENT_AUTH_CUSTOM_TOKEN
    {
        [ProtoMember(1)]

        public int result { get; set; }
        [ProtoMember(2)]
        public string custom_token { get; set; }
        [ProtoMember(3)]
        public string custom_id { get; set; }

    }

    [ProtoContract]
    public class CLIENT_FRONT_AUTH_LOGIN
    {
        [ProtoMember(1)]

        public int sdk_type { get; set; }
        [ProtoMember(2)]
        public int os_type { get; set; }
        [ProtoMember(3)]
        public string device { get; set; }
        [ProtoMember(4)]
        public string auth_user_id { get; set; }
        [ProtoMember(5)]
        public string email { get; set; }
        [ProtoMember(8)]
        public string id_token { get; set; }
        [ProtoMember(6)]
        public string version { get; set; }

    }

    [ProtoContract]
    public class CLIENT_FRONT_SERVER_INFO
    {

    }

    [ProtoContract]
    public class FRONT_CLIENT_SERVER_INFO
    {
        [ProtoMember(1)]

        public int result { get; set; }
        [ProtoMember(2)]
        public WORLD_INFO_2[] world_list { get; set; }

    }

    [ProtoContract]
    public class FRONT_CLIENT_SERVER_INFO_V3
    {
        [ProtoMember(1)]

        public int result { get; set; }
        [ProtoMember(2)]
        public WORLD_INFO[] world_list { get; set; }

    }

    [ProtoContract]
    public class CLIENT_FRONT_WORLD_CHARACTER_INFO
    {
        [ProtoMember(1)]

        public ulong account_uid { get; set; }

    }

    [ProtoContract]
    public class FRONT_CLIENT_WORLD_CHARACTER_INFO
    {
        [ProtoMember(1)]

        public _front_world_character_info[] character_info { get; set; }

    }

    [ProtoContract]
    public class FRONT_CLIENT_AUTH_LOGIN_V3
    {
        [ProtoMember(1)]

        public int result { get; set; }
        [ProtoMember(2)]
        public ulong user_uid { get; set; }
        [ProtoMember(3)]
        public string email { get; set; }
        [ProtoMember(4)]
        public WORLD_INFO[] world_list { get; set; }

    }

    [ProtoContract]
    public class FRONT_CLIENT_AUTH_LOGIN_2
    {
        [ProtoMember(1)]

        public int result { get; set; }
        [ProtoMember(2)]
        public ulong user_uid { get; set; }
        [ProtoMember(3)]
        public string email { get; set; }
        [ProtoMember(4)]
        public WORLD_INFO_2[] world_list { get; set; }

    }

    [ProtoContract]
    public class FRONT_FIREBASE_ID_TOKEN
    {
        [ProtoMember(1)]

        public string auth_user_id { get; set; }
        [ProtoMember(2)]
        public string email { get; set; }
        [ProtoMember(3)]
        public string id_token { get; set; }
        [ProtoMember(4)]
        public int sdk_type { get; set; }

    }

    [ProtoContract]
    public class FIREBASE_FRONT_ID_TOKEN
    {
        [ProtoMember(1)]

        public int result { get; set; }
        [ProtoMember(2)]
        public string email { get; set; }
        [ProtoMember(3)]
        public int sdk_type { get; set; }

    }

    [ProtoContract]
    public class FRONT_WORLD_GATEWAY_INFO
    {
        [ProtoMember(1)]

        public uint auth_user_uid { get; set; }

    }

    [ProtoContract]
    public class WORLD_FRONT_GATEWAY_INFO
    {
        [ProtoMember(1)]

        public uint auth_user_uid { get; set; }
        [ProtoMember(2)]
        public string ip { get; set; }
        [ProtoMember(3)]
        public int port { get; set; }

    }

    [ProtoContract]
    public class CLIENT_FRONT_AUTH_LOGIN_TEST
    {
        [ProtoMember(1)]

        public string email { get; set; }

    }

    [ProtoContract]
    public class CLIENT_FRONT_AUTH_SERVICE_LOGIN
    {
        [ProtoMember(1)]

        public string player_key { get; set; }
        [ProtoMember(2)]
        public string token_id { get; set; }

    }

    [ProtoContract]
    public class FIREBASE_FRONT_AUTH_SERVICE_LOGIN_RESULT
    {
        [ProtoMember(1)]

        public int result { get; set; }
        [ProtoMember(2)]
        public string player_key { get; set; }
        [ProtoMember(3)]
        public string sdk_type { get; set; }

    }

    [ProtoContract]
    public class FRONT_CLIENT_AUTH_SERVICE_LOGIN
    {
        [ProtoMember(1)]

        public int result { get; set; }
        [ProtoMember(2)]
        public ulong user_uid { get; set; }
        [ProtoMember(3)]
        public string player_key { get; set; }
        [ProtoMember(4)]
        public WORLD_INFO[] world_list { get; set; }
        [ProtoMember(5)]
        public bool create_account { get; set; }

    }

    [ProtoContract]
    public class CLIENT_FRONT_SERVICE_AUTH
    {
        [ProtoMember(1)]

        public string player_key { get; set; }
        [ProtoMember(2)]
        public string token_id { get; set; }
        [ProtoMember(3)]
        public int os_type { get; set; }
        [ProtoMember(4)]
        public string device { get; set; }
        [ProtoMember(5)]
        public int store_type { get; set; }

    }

    [ProtoContract]
    public class FRONT_CLIENT_SERVICE_AUTH_ERROR
    {
        [ProtoMember(1)]

        public int result { get; set; }

    }

    [ProtoContract]
    public class FIREBASE_FRONT_SERVICE_AUTH
    {
        [ProtoMember(1)]

        public int result { get; set; }
        [ProtoMember(2)]
        public string player_key { get; set; }
        [ProtoMember(3)]
        public string sdk_type { get; set; }

    }

    [ProtoContract]
    public class FRONT_CLIENT_SERVICE_AUTH_V3
    {
        [ProtoMember(1)]

        public int result { get; set; }
        [ProtoMember(2)]
        public ulong user_uid { get; set; }
        [ProtoMember(3)]
        public string player_key { get; set; }
        [ProtoMember(4)]
        public bool create_account { get; set; }
        [ProtoMember(5)]
        public WORLD_INFO[] world_list { get; set; }

    }

    [ProtoContract]
    public class FRONT_CLIENT_SERVICE_AUTH_2
    {
        [ProtoMember(1)]

        public int result { get; set; }
        [ProtoMember(2)]
        public ulong user_uid { get; set; }
        [ProtoMember(3)]
        public string player_key { get; set; }
        [ProtoMember(4)]
        public bool create_account { get; set; }
        [ProtoMember(5)]
        public WORLD_INFO_2[] world_list { get; set; }

    }

    [ProtoContract]
    public class CLIENT_FRONT_SELECT_WORLD
    {
        [ProtoMember(1)]

        public uint world_id { get; set; }

    }

    [ProtoContract]
    public class FRONT_MANAGER_SELECT_WORLD_WAITING_INFO
    {
        [ProtoMember(1)]

        public uint user_socket_id { get; set; }
        [ProtoMember(2)]
        public ulong user_uid { get; set; }
        [ProtoMember(3)]
        public uint world_id { get; set; }
        [ProtoMember(4)]
        public uint user_admin { get; set; }
        [ProtoMember(5)]
        public int os_type { get; set; }

    }

    [ProtoContract]
    public class MANAGER_WORLD_SELECT_WORLD_WAITING_INFO
    {
        [ProtoMember(1)]

        public ulong user_uid { get; set; }
        [ProtoMember(2)]
        public uint user_socket_id { get; set; }
        [ProtoMember(3)]
        public uint front_socket_id { get; set; }

    }

    [ProtoContract]
    public class WORLD_MANAGER_SELECT_WORLD_WAITING_INFO
    {
        [ProtoMember(1)]

        public ulong user_uid { get; set; }
        [ProtoMember(2)]
        public uint user_socket_id { get; set; }
        [ProtoMember(3)]
        public uint front_socket_id { get; set; }
        [ProtoMember(4)]
        public uint world_id { get; set; }
        [ProtoMember(5)]
        public uint waiting_count { get; set; }
        [ProtoMember(6)]
        public int error_id { get; set; }

    }

    [ProtoContract]
    public class MANAGER_FRONT_SELECT_WORLD_WAITING_INFO
    {
        [ProtoMember(1)]

        public uint user_socket_id { get; set; }
        [ProtoMember(2)]
        public uint world_id { get; set; }
        [ProtoMember(3)]
        public uint waiting_count { get; set; }
        [ProtoMember(4)]
        public string gateway_ip { get; set; }
        [ProtoMember(5)]
        public uint gateway_port { get; set; }
        [ProtoMember(6)]
        public int error_id { get; set; }
        [ProtoMember(7)]
        public ulong user_uid { get; set; }
        [ProtoMember(8)]
        public string auth_key { get; set; }

    }

    [ProtoContract]
    public class FRONT_CLIENT_SELECT_WORLD_WAITING_INFO
    {
        [ProtoMember(1)]

        public uint world_id { get; set; }
        [ProtoMember(2)]
        public uint waiting_count { get; set; }
        [ProtoMember(3)]
        public string auth_key { get; set; }

    }

    [ProtoContract]
    public class CLIENT_FRONT_CANCEL_WAITING_INFO
    {
    }

    [ProtoContract]
    public class FRONT_MANAGER_CANCEL_WAITING_INFO
    {
        [ProtoMember(1)]

        public uint world_id { get; set; }
        [ProtoMember(2)]
        public ulong user_uid { get; set; }

    }

    [ProtoContract]
    public class MANAGER_WORLD_CANCEL_WAITING_INFO
    {
        [ProtoMember(1)]

        public ulong user_uid { get; set; }

    }

    [ProtoContract]
    public class FRONT_WORLD_SELECT_WORLD
    {
        [ProtoMember(1)]

        public uint world_id { get; set; }
        [ProtoMember(2)]
        public ulong user_uid { get; set; }
        [ProtoMember(3)]
        public string user_id { get; set; }
        [ProtoMember(4)]
        public string device { get; set; }
        [ProtoMember(5)]
        public int os_type { get; set; }
        [ProtoMember(6)]
        public string sdk_type { get; set; }
        [ProtoMember(7)]
        public string user_ip { get; set; }

    }

    [ProtoContract]
    public class WORLD_FRONT_SELECT_WORLD
    {
        [ProtoMember(1)]

        public int result { get; set; }
        [ProtoMember(2)]
        public ulong user_socket_id { get; set; }
        [ProtoMember(3)]
        public uint world_id { get; set; }
        [ProtoMember(4)]
        public string ip { get; set; }
        [ProtoMember(5)]
        public int port { get; set; }
        [ProtoMember(6)]
        public ulong account_uid { get; set; }
        [ProtoMember(7)]
        public string auth_key { get; set; }
        [ProtoMember(8)]
        public int front_socket_index { get; set; }

    }

    [ProtoContract]
    public class FRONT_CLIENT_SELECT_WORLD
    {
        [ProtoMember(1)]

        public int result { get; set; }
        [ProtoMember(2)]
        public uint world_id { get; set; }
        [ProtoMember(3)]
        public string ip { get; set; }
        [ProtoMember(4)]
        public int port { get; set; }
        [ProtoMember(5)]
        public string auth_key { get; set; }

    }

    [ProtoContract]
    public class CLIENT_FRONT_CHARACTER_INFO
    {
    }

    [ProtoContract]
    public class FRONT_CLIENT_CHARACTER_INFO
    {
        [ProtoMember(1)]

        public _front_character_info[] info_list { get; set; }

    }

    [ProtoContract]
    public class MANAGER_WORLD_REQUEST_DUPILICATION_CHECK
    {
        [ProtoMember(1)]

        public ulong account_uid { get; set; }

    }

    [ProtoContract]
    public class WORLD_LOBBY_DUPLICATION_CHECK
    {
        [ProtoMember(1)]

        public ulong account_uid { get; set; }

    }

    [ProtoContract]
    public class MANAGER_WORLD_AUTH_KEY
    {
        [ProtoMember(1)]

        public ulong account_uid { get; set; }
        [ProtoMember(2)]
        public string auth_key { get; set; }
        [ProtoMember(3)]
        public int os_type { get; set; }
        [ProtoMember(4)]
        public int front_socket_index { get; set; }
        [ProtoMember(5)]
        public int user_socket_id { get; set; }

    }

    [ProtoContract]
    public class CLIENT_FRONT_WORLD_AND_CHARACTER_INFO
    {
        [ProtoMember(1)]

        public ulong account_uid { get; set; }

    }

    [ProtoContract]
    public class FRONT_CLIENT_WORLD_AND_CHARACTER_INFO
    {
        [ProtoMember(1)]

        public ulong account_uid { get; set; }
        [ProtoMember(2)]
        public int time_region { get; set; }
        [ProtoMember(3)]
        public WORLD_INFO[] world_list { get; set; }
        [ProtoMember(4)]
        public _front_world_character_info[] character_list { get; set; }

    }

    [ProtoContract]
    public class MANAGER_RELAY_REQUEST_DUPILICATION_CHECK
    {
        [ProtoMember(1)]

        public ulong account_uid { get; set; }
        [ProtoMember(2)]
        public uint world_id { get; set; }

    }

    [ProtoContract]
    public class WORLD_MANAGER_REQUEST_DUPILICATION_CHECK
    {
        [ProtoMember(1)]

        public ulong account_uid { get; set; }
        [ProtoMember(2)]
        public uint world_id { get; set; }

    }

    [ProtoContract]
    public class CLIENT_GAME_UPDATE_AWAKEN
    {
        [ProtoMember(1)]

        public ulong uid { get; set; }

    }

    [ProtoContract]
    public class GAME_CLIENT_UPDATE_AWAKEN
    {
        [ProtoMember(1)]

        public int open_awaken_grade { get; set; }

    }

    [ProtoContract]
    public class CLIENT_GAME_CHARACTER_BATTLE_PASS_CLEAR
    {
        [ProtoMember(1)]

        public ulong user_uid { get; set; }
        [ProtoMember(2)]
        public bool is_direct { get; set; }
        [ProtoMember(3)]
        public uint[] request_battle_pass_id_list { get; set; }

    }

    [ProtoContract]
    public class GAME_CLIENT_SYNC_CLEAR_BATTLE_PASS
    {
        [ProtoMember(1)]

        public uint battle_pass_id { get; set; }
        [ProtoMember(2)]
        public uint total_mission_point { get; set; }

    }

    [ProtoContract]
    public class GAME_CLIENT_CLEAR_BATTLE_PASS_LIST_RESULT
    {
        [ProtoMember(1)]

        public bool success_all { get; set; }
        [ProtoMember(2)]
        public uint[] battle_pass_id_list { get; set; }
        [ProtoMember(3)]
        public _cost_info[] cost_info_list { get; set; }
        [ProtoMember(4)]
        public uint error_id { get; set; }
        [ProtoMember(5)]
        public uint error_reason_battle_pass_id { get; set; }
        [ProtoMember(6)]
        public _character_battle_pass_complete_info[] character_battle_pass_complete_list { get; set; }

    }

    [ProtoContract]
    public class GAME_CLIENT_SYNC_EVENT_DATA
    {
        [ProtoMember(1)]

        public _character_event_data_info[] event_data_list { get; set; }

    }

    [ProtoContract]
    public class CLIENT_GAME_CHARACTER_BATTLE_PASS_REWARD
    {
        [ProtoMember(1)]

        public ulong user_uid { get; set; }
        [ProtoMember(2)]
        public uint[] reward_type { get; set; }
        [ProtoMember(3)]
        public uint[] request_battle_pass_id_list { get; set; }

    }

    [ProtoContract]
    public class GAME_CLIENT_SYNC_REWARD_BATTLE_PASS
    {
        [ProtoMember(1)]

        public uint battle_pass_id { get; set; }
        [ProtoMember(2)]
        public _cost_info[] cost_info_list { get; set; }
        [ProtoMember(3)]
        public _character_inven_item[] reward_item_list { get; set; }
        [ProtoMember(4)]
        public ulong battle_pass_info_uid { get; set; }

    }

    [ProtoContract]
    public class GAME_CLIENT_REWARD_BATTLE_PASS_LIST_RESULT
    {
        [ProtoMember(1)]

        public bool success_all { get; set; }
        [ProtoMember(2)]
        public uint[] battle_pass_id_list { get; set; }
        [ProtoMember(3)]
        public uint error_id { get; set; }
        [ProtoMember(4)]
        public uint error_reason_battle_pass_id { get; set; }
        [ProtoMember(5)]
        _user_event_info event_info { get; set; }

    }

    [ProtoContract]
    public class CLIENT_GAME_CHARACTER_BATTLE_PASS_TICKET
    {

    }

    [ProtoContract]
    public class GAME_CLIENT_CHARACTER_BATTLE_PASS_TICKET
    {
        [ProtoMember(1)]

        public ulong character_battle_pass { get; set; }
        [ProtoMember(2)]
        public ulong character_battle_pass2 { get; set; }
        [ProtoMember(3)]
        public _character_battle_pass_date[] character_battle_pass_date_list { get; set; }

    }

    [ProtoContract]
    public class WORLD_GAME_API_UPDATE_BATTLEPASS
    {
        [ProtoMember(1)]

        public ulong user_uid { get; set; }
        [ProtoMember(2)]
        public ulong account_uid { get; set; }
        [ProtoMember(3)]
        public uint category { get; set; }

    }

    [ProtoContract]
    public class CLIENT_GAME_CHARACTER_BATTLE_PASS_BUY_TICKET_ITEM
    {
        [ProtoMember(1)]

        public ulong user_uid { get; set; }
        [ProtoMember(2)]
        public uint battle_pass_info_uid { get; set; }
        [ProtoMember(3)]
        public uint purchase_number { get; set; }

    }

    [ProtoContract]
    public class GAME_CLIENT_CHARACTER_BATTLE_PASS_BUY_TICKET_ITEM
    {
        [ProtoMember(1)]

        public uint error_id { get; set; }
        [ProtoMember(2)]
        public _stack_item_info[] del_item_list { get; set; }
        [ProtoMember(3)]
        public _character_battle_pass_date[] character_battle_pass_date_list { get; set; }

    }


    [ProtoContract]
    public class _black_dragon_dungeon_ui_info
    {
        [ProtoMember(1)]

        public uint dungeon_id { get; set; }
        [ProtoMember(2)]
        public bool is_lock { get; set; }
        [ProtoMember(3)]
        public int round_info { get; set; }

    }

    [ProtoContract]
    public class CLIENT_GAME_BLACKDRAGON_DUNGEON_INFO
    {

    }

    [ProtoContract]
    public class GAME_CLIENT_BLACKDRAGON_DUNGEON_INFO
    {
        [ProtoMember(1)]

        public _black_dragon_dungeon_ui_info[] dungeon_info { get; set; }
        [ProtoMember(2)]
        public int conquer_round_info { get; set; }

    }

    [ProtoContract]
    public class CLIENT_GAME_ENTER_BLACKDRAGON_DUNGEON
    {
        [ProtoMember(1)]

        public uint enter_dungeon_id { get; set; }

    }

    [ProtoContract]
    public class GAME_WORLD_ENTER_BLACKDRAGON_DUNGEON
    {
        [ProtoMember(1)]

        public uint enter_dungeon_id { get; set; }

    }

    [ProtoContract]
    public class CLIENT_GAME_LEAVE_BLACKDRAGON_DUNGEON
    {

    }

    [ProtoContract]
    public class GAME_WORLD_LEAVE_BLACKDRAGON_DUNGEON
    {

    }


    [ProtoContract]
    public class _block_user_info
    {
        [ProtoMember(1)]

        public ulong block_user_uid { get; set; }
        [ProtoMember(2)]
        public string block_user_name { get; set; }
        [ProtoMember(3)]
        public string block_user_profile { get; set; }

    }

    [ProtoContract]
    public class CLIENT_CHATTING_BLOCK_LIST
    {
    }

    [ProtoContract]
    public class CHATTING_CLIENT_BLOCK_LIST_START
    {
    }

    [ProtoContract]
    public class CHATTING_CLIENT_BLOCK_LIST
    {
        [ProtoMember(1)]

        public _block_user_info[] block_user_list { get; set; }

    }

    [ProtoContract]
    public class CHATTING_CLIENT_BLOCK_LIST_END
    {
    }

    [ProtoContract]
    public class CLIENT_CHATTING_ADD_BLOCK
    {
        [ProtoMember(1)]

        public string block_user_name { get; set; }

    }

    [ProtoContract]
    public class CHATTING_CLIENT_ADD_BLOCK
    {
        [ProtoMember(1)]

        _block_user_info block_user_info { get; set; }
        [ProtoMember(2)]
        public uint result { get; set; }

    }

    [ProtoContract]
    public class CLIENT_CHATTING_CANCEL_BLOCK
    {
        [ProtoMember(1)]
        public ulong block_user_uid { get; set; }
    }

    [ProtoContract]
    public class CHATTING_CLIENT_CANCEL_BLOCK
    {
        [ProtoMember(1)]

        public ulong block_user_uid { get; set; }
        [ProtoMember(2)]
        public uint result { get; set; }

    }


    [ProtoContract]
    public class GAME_CLIENT_ATTACH_BUFF
    {
        [ProtoMember(1)]

        public int type { get; set; }
        [ProtoMember(2)]
        public ulong uid { get; set; }
        [ProtoMember(3)]
        _buff_info attach_buff_info { get; set; }
        [ProtoMember(4)]
        _buff_special_effect_info special_effect_info { get; set; }

    }

    [ProtoContract]
    public class GAME_CLIENT_DETACH_BUFF
    {
        [ProtoMember(1)]

        public int type { get; set; }
        [ProtoMember(2)]
        public ulong uid { get; set; }
        [ProtoMember(3)]
        public int buff_id { get; set; }

    }

    [ProtoContract]
    public class GAME_CLIENT_BUFF_LIST
    {
        [ProtoMember(1)]

        public int type { get; set; }
        [ProtoMember(2)]
        public ulong uid { get; set; }
        [ProtoMember(3)]
        public _buff_info[] buff_list { get; set; }

    }

    [ProtoContract]
    public class CLIENT_GAME_BUFF_LIST
    {
        [ProtoMember(1)]

        public ulong user_uid { get; set; }

    }

    [ProtoContract]
    public class GAME_CLIENT_ATTACH_SPECIAL_EFFECT
    {
        [ProtoMember(1)]

        public int type { get; set; }
        [ProtoMember(2)]
        public ulong uid { get; set; }
        [ProtoMember(3)]
        public _buff_special_effect_info[] special_effect_info { get; set; }

    }

    [ProtoContract]
    public class GAME_CLIENT_DETACH_SPECIAL_EFFECT
    {
        [ProtoMember(1)]

        public int type { get; set; }
        [ProtoMember(2)]
        public ulong uid { get; set; }
        [ProtoMember(3)]
        public _buff_special_effect_info[] special_effect_info { get; set; }

    }

    [ProtoContract]
    public class GAME_CLIENT_BUFF_ATTACK
    {
        [ProtoMember(1)]

        public int entity_type { get; set; }
        [ProtoMember(2)]
        public ulong entity_uid { get; set; }
        [ProtoMember(3)]
        public int buff_attack_id { get; set; }

    }

    [ProtoContract]
    public class GAME_CLIENT_BUFF_ATTACK_STRUCK
    {
        [ProtoMember(1)]

        public int target_type { get; set; }
        [ProtoMember(2)]
        public ulong target_uid { get; set; }
        [ProtoMember(3)]
        public int attacker_type { get; set; }
        [ProtoMember(4)]
        public ulong attacker_uid { get; set; }
        [ProtoMember(5)]
        public int buff_attack_id { get; set; }
        [ProtoMember(6)]
        public int damage_type { get; set; }
        [ProtoMember(7)]
        public int damage { get; set; }
        [ProtoMember(8)]
        public int shield_damage { get; set; }
        [ProtoMember(9)]
        public int hp { get; set; }
        [ProtoMember(10)]
        public int cc_type { get; set; }
        [ProtoMember(11)]
        public int cc_time_ms { get; set; }
        [ProtoMember(12)]
        public _vector3 loc { get; set; }
        [ProtoMember(13)]
        public long server_time_ms { get; set; }

    }

    [ProtoContract]
    public class GAME_CLIENT_BUFF_CHANGE_TIME
    {
        [ProtoMember(1)]

        public int buff_id { get; set; }
        [ProtoMember(2)]
        public int buff_left_time { get; set; }

    }

    [ProtoContract]
    public class GAME_WORLD_WORLDBUFF_APPLY
    {
        [ProtoMember(1)]

        public int world_buff_tid { get; set; }
        [ProtoMember(2)]
        public bool is_apply { get; set; }

    }


    [ProtoContract]
    public class CLIENT_GAME_START_CASTING
    {
        [ProtoMember(1)]

        public ulong casting_user_uid { get; set; }
        [ProtoMember(2)]
        public int casting_type { get; set; }
        [ProtoMember(3)]
        public ulong casting_target_uid { get; set; }
        [ProtoMember(4)]
        public uint casting_sub_type { get; set; }
        [ProtoMember(5)]
        public uint casting_exec_type { get; set; }
        [ProtoMember(6)]
        public bool is_auto_casting { get; set; }

    }

    [ProtoContract]
    public class GAME_CLIENT_START_CASTING
    {
        [ProtoMember(1)]

        public ulong casting_user_uid { get; set; }
        [ProtoMember(2)]
        public int casting_target_type { get; set; }
        [ProtoMember(3)]
        public ulong casting_target_uid { get; set; }
        [ProtoMember(4)]
        public int casting_time { get; set; }
        [ProtoMember(5)]
        public int casting_type { get; set; }
        [ProtoMember(6)]
        public bool is_auto_casting { get; set; }
        [ProtoMember(7)]
        public int casting_sub_type { get; set; }
        [ProtoMember(8)]
        public _vector3 position { get; set; }
        [ProtoMember(9)]
        public bool steal_protected { get; set; }

    }

    [ProtoContract]
    public class GAME_CLIENT_CASTING_FAIL
    {
        [ProtoMember(1)]

        public ulong casting_user_uid { get; set; }
        [ProtoMember(2)]
        public int fail_reason { get; set; }
        [ProtoMember(3)]
        public int casting_type { get; set; }
        [ProtoMember(4)]
        public ulong casting_target_uid { get; set; }
        [ProtoMember(5)]
        public ulong fail_reason_arg { get; set; }
        [ProtoMember(6)]
        public ulong use_user_uid { get; set; }

    }

    [ProtoContract]
    public class GAME_CLIENT_CASTING_SUCCESS
    {
        [ProtoMember(1)]

        public ulong uid { get; set; }
        [ProtoMember(2)]
        public int casting_type { get; set; }
        [ProtoMember(3)]
        public ulong casting_target_uid { get; set; }
        [ProtoMember(4)]
        public int casting_success_value { get; set; }
        [ProtoMember(5)]
        public bool is_auto_casting { get; set; }
        [ProtoMember(6)]
        public int casting_sub_type { get; set; }

    }

    [ProtoContract]
    public class GAME_CLIENT_CANCEL_CASTING
    {
        [ProtoMember(1)]

        public ulong casting_user_uid { get; set; }
        [ProtoMember(2)]
        public int casting_type { get; set; }
        [ProtoMember(3)]
        public int cancel_reason { get; set; }

    }

    [ProtoContract]
    public class GAME_CLIENT_END_CASTING
    {
        [ProtoMember(1)]

        public ulong casting_user_uid { get; set; }
        [ProtoMember(2)]
        public int casting_type { get; set; }
        [ProtoMember(3)]
        public bool is_auto_casting { get; set; }

    }

    [ProtoContract]
    public class CLIENT_GAME_CANCEL_CASTING
    {

    }

    [ProtoContract]
    public class GAME_CLIENT_CHANGE_CASTING_TIME
    {
        [ProtoMember(1)]

        public int casting_target_type { get; set; }
        [ProtoMember(2)]
        public ulong casting_target_uid { get; set; }
        [ProtoMember(3)]
        public int casting_time { get; set; }

    }


    [ProtoContract]
    public class CLIENT_WORLD_OTHER_CHARACTER_INFO
    {
        [ProtoMember(1)]

        public ulong target_uid { get; set; }
        [ProtoMember(2)]
        public int target_world_id { get; set; }

    }

    [ProtoContract]
    public class CLIENT_GAME_AROUND_OTHER_CHARACTER_INFO
    {
        [ProtoMember(1)]

        public ulong target_uid { get; set; }

    }

    [ProtoContract]
    public class WORLD_CLIENT_OTHER_CHARACTER_INFO
    {
        [ProtoMember(1)]

        public int result { get; set; }
        [ProtoMember(2)]
        _other_user_ui_info character_info { get; set; }
        [ProtoMember(3)]
        _other_user_ui_info_guild guild_info { get; set; }
        [ProtoMember(4)]
        _other_user_ui_info_rank rank_info { get; set; }
        [ProtoMember(5)]
        public bool is_my_guild_applicant { get; set; }
        [ProtoMember(7)]
        public bool is_my_guild_invite { get; set; }
        [ProtoMember(8)]
        public ulong guild_partner_member_uid { get; set; }
        [ProtoMember(9)]
        public uint server_index { get; set; }
        [ProtoMember(10)]
        public ulong request_uid { get; set; }

    }

    [ProtoContract]
    public class COMMUNITY_GAME_OTHER_CHARACTER_INFO
    {
        [ProtoMember(1)]

        public ulong request_uid { get; set; }
        [ProtoMember(2)]
        WORLD_CLIENT_OTHER_CHARACTER_INFO other_info { get; set; }

    }

    [ProtoContract]
    public class GAME_WORLD_OTHER_CHARACTER_INFO_TO_OTHER_WORLD
    {
        [ProtoMember(1)]

        public int world_server_zone_group_id { get; set; }
        [ProtoMember(2)]
        public ulong wait_uid { get; set; }
        [ProtoMember(3)]
        public ulong[] target_uid { get; set; }
        [ProtoMember(4)]
        public uint start_world_id { get; set; }

    }

    [ProtoContract]
    public class WOLRD_GAME_OTHER_CHARACTER_INFO_TO_OTHER_WORLD
    {
        [ProtoMember(1)]

        public uint result { get; set; }
        [ProtoMember(2)]
        public ulong target_uid { get; set; }
        [ProtoMember(3)]
        public ulong wait_uid { get; set; }
        [ProtoMember(4)]
        _other_user_ui_info character_info { get; set; }
        [ProtoMember(5)]
        _other_user_info_etc character_info_etc { get; set; }

    }

    [ProtoContract]
    public class GAME_WORLD_OTHER_CHARACTER_SAVE_TO_OTHER_WORLD
    {
        [ProtoMember(1)]

        _other_user_ui_info character_info { get; set; }

    }

    [ProtoContract]
    public class _other_character_info_change_value
    {
        [ProtoMember(1)]

        public string value_name { get; set; }
        [ProtoMember(2)]
        public ulong sub_key { get; set; }
        [ProtoMember(3)]
        public int int_value { get; set; }
        [ProtoMember(4)]
        public ulong long_value { get; set; }

    }

    [ProtoContract]
    public class GAME_WORLD_OTHER_CHARACTER_INFO_CHANGE_VALUE_TO_OTHER_WORLD
    {
        [ProtoMember(1)]

        public ulong target_uid { get; set; }
        [ProtoMember(2)]
        public _other_character_info_change_value[] change_values { get; set; }

    }

    [ProtoContract]
    public class CLIENT_GAME_CHARACTER_CUSTOM_TITLE_CHANGE
    {
        [ProtoMember(1)]

        public string custom_title { get; set; }

    }

    [ProtoContract]
    public class GAME_CLIENT_CHARACTER_CUSTOM_TITLE_CHANGE
    {
        [ProtoMember(1)]

        public uint result { get; set; }
        [ProtoMember(2)]
        public _stack_item_info[] update_items { get; set; }
        [ProtoMember(3)]
        public string custom_title { get; set; }
        [ProtoMember(4)]
        public long custom_title_end_time { get; set; }
        [ProtoMember(5)]
        public bool is_custom_title_show { get; set; }

    }

    [ProtoContract]
    public class GAME_CLIENT_CHARACTER_CUSTOM_TITLE_CHANGE_FIELD_BROADCAST
    {
        [ProtoMember(1)]

        public ulong user_uid { get; set; }
        [ProtoMember(2)]
        public string custom_title { get; set; }

    }

    [ProtoContract]
    public class GAME_CLIENT_CHARACTER_CUSTOM_TITLE_TIME_OUT
    {
    }

    [ProtoContract]
    public class CLIENT_GAME_CHARACTER_CUSTOM_TITLE_SHOW
    {
        [ProtoMember(1)]

        public bool is_custom_title_show { get; set; }

    }

    [ProtoContract]
    public class GAME_CLIENT_CHARACTER_CUSTOM_TITLE_SHOW
    {
        [ProtoMember(1)]

        public int result { get; set; }
        [ProtoMember(2)]
        public bool is_custom_title_show { get; set; }

    }

    [ProtoContract]
    public class CLIENT_GAME_CHARACTER_PROFILE_CHANGE
    {
        [ProtoMember(1)]

        public string profile { get; set; }

    }

    [ProtoContract]
    public class GAME_CLIENT_CHARACTER_PROFILE_CHANGE
    {
        [ProtoMember(1)]

        public uint result { get; set; }
        [ProtoMember(2)]
        public string profile { get; set; }

    }

    [ProtoContract]
    public class GAME_WORLD_CHARACTER_PROFILE_CHANGE
    {
        [ProtoMember(1)]

        public ulong user_uid { get; set; }
        [ProtoMember(2)]
        public string profile { get; set; }

    }

    [ProtoContract]
    public class GAME_CLIENT_EXPBOOSTER_CHANGE_NOTIFY
    {
        [ProtoMember(1)]

        public uint exp_booster_left_time { get; set; }
        [ProtoMember(2)]
        public uint add_exp_booster_time { get; set; }
        [ProtoMember(3)]
        public bool is_item_use { get; set; }
        [ProtoMember(4)]
        public int result { get; set; }

    }

    [ProtoContract]
    public class GAME_CLIENT_EXPBOOSTER_SPEND_START
    {
        [ProtoMember(1)]

        public uint exp_booster_left_time { get; set; }

    }

    [ProtoContract]
    public class GAME_CLIENT_EXPBOOSTER_SPEND_END
    {
        [ProtoMember(1)]

        public uint exp_booster_left_time { get; set; }

    }

    [ProtoContract]
    public class WORLD_GAME_DELETE_CHARACTER
    {
        [ProtoMember(1)]

        public ulong character_uid { get; set; }

    }

    [ProtoContract]
    public class WORLD_GAME_DELETE_CHARACTER_END
    {
        [ProtoMember(1)]

        public ulong character_uid { get; set; }

    }

    [ProtoContract]
    public class GAME_COMMUNITY_CHANGE_EQUIP_ITEM_INFO
    {
        [ProtoMember(1)]

        public ulong character_uid { get; set; }
        [ProtoMember(2)]
        public int position { get; set; }
        [ProtoMember(3)]
        CharacterInfoEquipSlot equip_slot { get; set; }

    }

    [ProtoContract]
    public class GAME_COMMUNITY_CHANGE_EQUIP_COSTUME_INFO
    {
        [ProtoMember(1)]

        public ulong character_uid { get; set; }
        [ProtoMember(2)]
        public int position { get; set; }
        [ProtoMember(3)]
        _equip_costume_info costume_info { get; set; }

    }

    [ProtoContract]
    public class GAME_COMMUNITY_CHANGE_LUXURY_COSTUME_INFO
    {
        [ProtoMember(1)]

        public ulong character_uid { get; set; }
        [ProtoMember(2)]
        public int position { get; set; }
        [ProtoMember(3)]
        _equip_costume_info costume_info { get; set; }

    }

    [ProtoContract]
    public class GAME_COMMUNITY_CHANGE_LEVEL_INFO
    {
        [ProtoMember(1)]

        public ulong character_uid { get; set; }
        [ProtoMember(2)]
        public int level { get; set; }
        [ProtoMember(3)]
        public int combat_point { get; set; }

    }

    [ProtoContract]
    public class GAME_COMMUNITY_CHANGE_PET_INFO
    {
        [ProtoMember(1)]

        public ulong character_uid { get; set; }
        [ProtoMember(2)]
        public bool equip { get; set; }
        [ProtoMember(3)]
        _pet_info pet_info { get; set; }
        [ProtoMember(4)]
        public bool is_upgrade { get; set; }
        [ProtoMember(5)]
        public int slot_id { get; set; }

    }

    [ProtoContract]
    public class GAME_COMMUNITY_CHANGE_NAME_INFO
    {
        [ProtoMember(1)]

        public ulong character_uid { get; set; }
        [ProtoMember(2)]
        public string name { get; set; }

    }

    [ProtoContract]
    public class GAME_COMMUNITY_CHANGE_CUSTOM_TITLE_INFO
    {
        [ProtoMember(1)]

        public ulong character_uid { get; set; }
        [ProtoMember(2)]
        public string custom_title { get; set; }
        [ProtoMember(3)]
        public ulong custom_title_end_time { get; set; }
        [ProtoMember(4)]
        public bool is_custom_title_show { get; set; }

    }

    [ProtoContract]
    public class GAME_COMMUNITY_CHANGE_FAME_INFO
    {
        [ProtoMember(1)]

        public ulong character_uid { get; set; }
        [ProtoMember(2)]
        public uint fame_level { get; set; }
        [ProtoMember(3)]
        public ulong fame_level_exp { get; set; }

    }

    [ProtoContract]
    public class GAME_COMMUNITY_CHANGE_CLASS_INFO
    {
        [ProtoMember(1)]

        public ulong character_uid { get; set; }
        [ProtoMember(2)]
        public int _class { get; set; }

    }

    [ProtoContract]
    public class GAME_COMMUNITY_CHANGE_COMBAT_POINT_INFO
    {
        [ProtoMember(1)]

        public ulong character_uid { get; set; }
        [ProtoMember(2)]
        public int combat_point { get; set; }

    }

    [ProtoContract]
    public class GAME_COMMUNITY_CHANGE_PK_POINT_INFO
    {
        [ProtoMember(1)]

        public ulong character_uid { get; set; }
        [ProtoMember(2)]
        public int pk_point { get; set; }

    }

    [ProtoContract]
    public class GAME_COMMUNITY_CHANGE_PROFILE_INFO
    {
        [ProtoMember(1)]

        public ulong character_uid { get; set; }
        [ProtoMember(2)]
        public string profile { get; set; }

    }

    [ProtoContract]
    public class GAME_COMMUNITY_CHANGE_TRAINING_INFO
    {
        [ProtoMember(1)]

        public ulong character_uid { get; set; }
        [ProtoMember(2)]
        public int closed_training_total_level { get; set; }
        [ProtoMember(3)]
        public int closed_training_collect_step { get; set; }

    }

    [ProtoContract]
    public class GAME_COMMUNITY_CHANGE_WONDER_INFO
    {
        [ProtoMember(1)]

        public ulong character_uid { get; set; }
        [ProtoMember(2)]
        public ulong daily_wonder { get; set; }
        [ProtoMember(3)]
        public ulong wonder { get; set; }

    }

    [ProtoContract]
    public class GAME_COMMUNITY_CHANGE_MASTERY_INFO
    {
        [ProtoMember(1)]

        public ulong character_uid { get; set; }
        [ProtoMember(2)]
        public int mastery_level_count { get; set; }
        [ProtoMember(3)]
        public int mastery_level_limit_grade { get; set; }

    }

    [ProtoContract]
    public class GAME_COMMUNITY_CHANGE_FORCE_INFO
    {
        [ProtoMember(1)]

        public ulong character_uid { get; set; }
        [ProtoMember(2)]
        public int force_id { get; set; }
        [ProtoMember(3)]
        public int level { get; set; }
        [ProtoMember(4)]
        public int force_level_count { get; set; }

    }

    [ProtoContract]
    public class GAME_COMMUNITY_CHANGE_SKILL_INFO
    {
        [ProtoMember(1)]

        public ulong character_uid { get; set; }
        [ProtoMember(2)]
        public int skillindex { get; set; }
        [ProtoMember(3)]
        public int skilllevel { get; set; }
        [ProtoMember(4)]
        public int skill_level_count { get; set; }

    }

    [ProtoContract]
    public class GAME_COMMUNITY_CHANGE_CUSTOMIZE_INFO
    {
        [ProtoMember(1)]

        public ulong character_uid { get; set; }
        [ProtoMember(2)]
        public customize_info[] customize_list { get; set; }

    }

    [ProtoContract]
    public class GAME_COMMUNITY_CHANGE_GREAT_BUILDING_INFO
    {
        [ProtoMember(1)]

        public ulong character_uid { get; set; }
        [ProtoMember(2)]
        _other_user_ui_great_building_info building_info { get; set; }

    }

    [ProtoContract]
    public class GAME_COMMUNITY_CHANGE_HOLY_STUFF_INFO
    {
        [ProtoMember(1)]

        public ulong character_uid { get; set; }
        [ProtoMember(2)]
        _other_user_ui_holy_stuff_info holy_stuff_info { get; set; }

    }

    [ProtoContract]
    public class GAME_COMMUNITY_CHANGE_SERVER_POS_INFO
    {
        [ProtoMember(1)]

        public ulong character_uid { get; set; }
        [ProtoMember(2)]
        public int server_pos { get; set; }

    }

    [ProtoContract]
    public class GAME_COMMUNITY_CHANGE_ASSASSIN_MODE
    {
        [ProtoMember(1)]

        public ulong character_uid { get; set; }
        [ProtoMember(2)]
        public bool mode { get; set; }

    }

    [ProtoContract]
    public class WORLD_COMMUNITY_CHANGE_RANKING_INFO
    {
        [ProtoMember(1)]

        public int process_state { get; set; }
        [ProtoMember(2)]
        public int world_id { get; set; }

    }

    [ProtoContract]
    public class GAME_COMMUNITY_CHANGE_GUILD_MEMBER_INFO
    {
        [ProtoMember(1)]

        public ulong character_uid { get; set; }
        [ProtoMember(2)]
        GuildChangeType change_type { get; set; }
        [ProtoMember(3)]
        public string title { get; set; }
        [ProtoMember(4)]
        public int grade { get; set; }
        [ProtoMember(5)]
        public uint official_grade { get; set; }

    }

    [ProtoContract]
    public class GAME_COMMUNITY_CHANGE_GUILD_NAME_INFO
    {
        [ProtoMember(1)]

        public ulong character_uid { get; set; }
        [ProtoMember(2)]
        _guild_name_ui_info guild_name { get; set; }

    }

    [ProtoContract]
    public class GAME_COMMUNITY_CHANGE_GUILD_JOIN_INFO
    {
        [ProtoMember(1)]

        public ulong character_uid { get; set; }
        [ProtoMember(2)]
        _other_user_ui_info_guild guild_info { get; set; }

    }

    [ProtoContract]
    public class GAME_COMMUNITY_CHARACTER_INFO_CLEAR
    {
        [ProtoMember(1)]

        public ulong character_uid { get; set; }

    }

    [ProtoContract]
    public class GAME_COMMUNITY_CHARACTER_POTENTIAL
    {
        [ProtoMember(1)]

        public ulong character_uid { get; set; }
        [ProtoMember(2)]
        public _other_user_ui_potential_level_info[] potential_level_list { get; set; }

    }

    [ProtoContract]
    public class GAME_COMMUNITY_CHANGE_DOMINION_TITLE
    {
        [ProtoMember(1)]

        public ulong character_uid { get; set; }
        [ProtoMember(2)]
        public uint dominion_title { get; set; }

    }

    enum RankingProcessState
    {
        RESET = 0,
        LOAD = 1,
    }

    enum GuildChangeType
    {
        TITLE = 0,
        GRADE = 1,
        DROP = 2,
        OFFICIAL_GRADE = 3

    }


    [ProtoContract]
    public class CLIENT_GAME_CHARACTER_PHASE_CREATE
    {
        [ProtoMember(1)]

        public int phase_class { get; set; }
        [ProtoMember(2)]
        public customize_info[] customize_list { get; set; }
        [ProtoMember(3)]
        public bool is_use_item { get; set; }

    }

    [ProtoContract]
    public class GAME_CLIENT_CHARACTER_PHASE_CREATE
    {
        [ProtoMember(1)]

        public int result { get; set; }
        [ProtoMember(2)]
        public int phase_class { get; set; }
        [ProtoMember(3)]
        public _cost_info[] costInfo { get; set; }

    }

    [ProtoContract]
    public class CLIENT_GAME_CHARACTER_PHASE
    {
        [ProtoMember(1)]

        public int phase_class { get; set; }

    }

    [ProtoContract]
    public class GAME_CLIENT_CHARACTER_PHASE
    {
        [ProtoMember(1)]

        public int result { get; set; }
        [ProtoMember(2)]
        public int phase_class { get; set; }

    }

    [ProtoContract]
    public class GAME_WORLD_CHARACTER_PHASE
    {
        [ProtoMember(1)]

        public ulong user_uid { get; set; }
        [ProtoMember(2)]
        public ulong guild_uid { get; set; }
        [ProtoMember(3)]
        public int phase_class { get; set; }

    }

    [ProtoContract]
    public class CLIENT_GAME_CHARACTER_PHASE_INFO
    {

    }

    [ProtoContract]
    public class GAME_CLIENT_CHARACTER_PHASE_INFO
    {
        [ProtoMember(1)]

        public int origin_class { get; set; }
        [ProtoMember(2)]
        public _character_phase_info[] open_phase_info { get; set; }
        [ProtoMember(3)]
        public long update_phase_time { get; set; }

    }


    [ProtoContract]
    public class _chatting_header
    {
        [ProtoMember(1)]

        public ulong uid { get; set; }
        [ProtoMember(2)]
        public string name { get; set; }
        [ProtoMember(3)]
        public int class_type { get; set; }
        [ProtoMember(4)]
        public int level { get; set; }
        [ProtoMember(5)]
        public string guild_name { get; set; }
        [ProtoMember(6)]
        public int share_type { get; set; }
        [ProtoMember(7)]
        public ulong guild_uid { get; set; }
        [ProtoMember(8)]
        public ulong send_time { get; set; }
        [ProtoMember(9)]
        public string profile { get; set; }
        [ProtoMember(10)]
        public int account_grade { get; set; }
        [ProtoMember(11)]
        public int official_grade { get; set; }
        [ProtoMember(12)]
        public uint world_id { get; set; }
        [ProtoMember(13)]
        public uint guild_member_grade { get; set; }
        [ProtoMember(14)]
        public string guild_custom_title { get; set; }
        [ProtoMember(15)]
        public uint chatting_server_world_id { get; set; }
        [ProtoMember(16)]
        public bool assassin_mode { get; set; }
        [ProtoMember(17)]
        public bool is_sabuk_master { get; set; }

    }

    [ProtoContract]
    public class CLIENT_GAME_CHATMSG //@cheatmsg makeitem 1811200073 1
    {
        [ProtoMember(1)]

        public int type { get; set; }
        [ProtoMember(2)]
        public string msg { get; set; }
        [ProtoMember(3)]
        public bool is_command { get; set; }

    }

    [ProtoContract]
    public class _save_chatmsg_info
    {
        [ProtoMember(1)]

        _chatting_header chat_header { get; set; }
        [ProtoMember(2)]
        public string msg { get; set; }
        [ProtoMember(3)]
        public int type { get; set; }

    }

    [ProtoContract]
    public class _save_whisper_chatmsg_info
    {
        [ProtoMember(1)]

        _chatting_header chat_header { get; set; }
        [ProtoMember(2)]
        public string msg { get; set; }
        [ProtoMember(3)]
        public int type { get; set; }
        [ProtoMember(4)]
        public long send_user_uid { get; set; }
        [ProtoMember(5)]
        public long recv_user_uid { get; set; }

    }

    [ProtoContract]
    public class _search_user_info
    {
        [ProtoMember(1)]

        public long search_uid { get; set; }
        [ProtoMember(2)]
        public string search_name { get; set; }
        [ProtoMember(3)]
        public string search_profile { get; set; }
        [ProtoMember(4)]
        public long reg_date { get; set; }
        [ProtoMember(5)]
        public long last_chat_msg_time { get; set; }
        [ProtoMember(6)]
        public uint class_id { get; set; }
        [ProtoMember(7)]
        public uint level { get; set; }
        [ProtoMember(8)]
        public uint combat_point { get; set; }

    }

    [ProtoContract]
    public class _enter_chatting_room_info
    {
        [ProtoMember(1)]

        public uint chat_room_type { get; set; }
        [ProtoMember(2)]
        public ulong chat_room_data { get; set; }
        [ProtoMember(3)]
        public ulong chat_user_uid { get; set; }
        [ProtoMember(4)]
        _chatting_header chat_header { get; set; }
        [ProtoMember(5)]
        public uint gateway_server_index { get; set; }

    }

    [ProtoContract]
    public class _alliance_guild_info
    {
        [ProtoMember(1)]

        public ulong guild_uid { get; set; }
        [ProtoMember(2)]
        public string guild_name { get; set; }
        [ProtoMember(3)]
        public uint world_id { get; set; }

    }

    [ProtoContract]
    public class GAME_CLIENT_CHATMSG
    {
        [ProtoMember(1)]
        public _chatting_header chat_header { get; set; }
        [ProtoMember(2)]
        public string msg { get; set; }
        [ProtoMember(3)]
        public int type { get; set; }
        [ProtoMember(4)]
        public ulong target_uid { get; set; }

    }

    [ProtoContract]
    public class GATEWAY_WORLD_CHATMSG
    {
        [ProtoMember(1)]

        public ulong character_uid { get; set; }
        [ProtoMember(2)]
        public int type { get; set; }
        [ProtoMember(3)]
        public string msg { get; set; }

    }

    [ProtoContract]
    public class WORLD_GATEWAY_CHATMSG
    {
        [ProtoMember(1)]

        public ulong character_uid { get; set; }
        [ProtoMember(2)]
        public string name { get; set; }
        [ProtoMember(3)]
        public string msg { get; set; }

    }

    [ProtoContract]
    public class WORLD_CHATTING_ENTER_CHATTING_ROOM
    {
        [ProtoMember(1)]

        _enter_chatting_room_info enter_chatting_room_info { get; set; }

    }

    [ProtoContract]
    public class WORLD_CHATTING_LEAVE_CHATTING_ROOM
    {
        [ProtoMember(1)]

        public uint chat_room_type { get; set; }
        [ProtoMember(2)]
        public ulong chat_user_uid { get; set; }

    }

    [ProtoContract]
    public class WORLD_CHATTING_SYNC_CHAT_USER_INFO
    {
        [ProtoMember(1)]

        public ulong chat_user_uid { get; set; }
        [ProtoMember(2)]
        public uint chat_user_level { get; set; }
        [ProtoMember(3)]
        public string chat_user_guild_name { get; set; }
        [ProtoMember(4)]
        public ulong chat_guild_uid { get; set; }
        [ProtoMember(5)]
        public uint official_grade { get; set; }
        [ProtoMember(6)]
        public uint guild_member_grade { get; set; }
        [ProtoMember(7)]
        public string guild_custom_title { get; set; }
        [ProtoMember(8)]
        public bool is_sabuk_master { get; set; }

    }

    [ProtoContract]
    public class WORLD_CHATTING_CHATMSG
    {
        [ProtoMember(1)]

        public ulong chat_user_uid { get; set; }
        [ProtoMember(2)]
        public int type { get; set; }
        [ProtoMember(3)]
        public string msg { get; set; }
        [ProtoMember(4)]
        public int share_type { get; set; }
        [ProtoMember(5)]
        public ulong chat_room_uid { get; set; }

    }

    [ProtoContract]
    public class GAME_MACRO_CHATMSG
    {
        [ProtoMember(1)]

        public ulong chat_user_uid { get; set; }
        [ProtoMember(2)]
        public int type { get; set; }
        [ProtoMember(3)]
        public string msg { get; set; }
        [ProtoMember(4)]
        public int share_type { get; set; }

    }

    [ProtoContract]
    public class WORLD_CHATTING_LOGOUT_CHAT_USER
    {
        [ProtoMember(1)]

        public ulong chat_user_uid { get; set; }

    }

    [ProtoContract]
    public class CLIENT_CHATTING_WHISPER
    {
        [ProtoMember(1)]

        public ulong send_user_uid { get; set; }
        [ProtoMember(2)]
        public ulong receive_user_uid { get; set; }
        [ProtoMember(3)]
        public string msg { get; set; }
        [ProtoMember(4)]
        public string receive_user_name { get; set; }

    }

    [ProtoContract]
    public class WORLD_CHATTING_WHISPER
    {
        [ProtoMember(1)]

        public ulong send_user_uid { get; set; }
        [ProtoMember(2)]
        public ulong receive_user_uid { get; set; }
        [ProtoMember(3)]
        public string msg { get; set; }
        [ProtoMember(4)]
        public string receive_user_name { get; set; }

    }

    [ProtoContract]
    public class CHATTING_CLIENT_WHISPER_ERROR
    {
        [ProtoMember(1)]

        public uint error_id { get; set; }

    }

    [ProtoContract]
    public class WORLD_CLIENT_REQUEST_CONNECT_CHATTING_SERVER
    {
        [ProtoMember(1)]

        public string server_ip { get; set; }
        [ProtoMember(2)]
        public uint connect_port { get; set; }

    }

    [ProtoContract]
    public class GATEWAY_CHATTING_REQUEST_LOGIN
    {
        [ProtoMember(1)]

        public ulong user_uid { get; set; }
        [ProtoMember(2)]
        public uint proxy_server_index { get; set; }
        [ProtoMember(3)]
        public uint proxy_connected_session_id { get; set; }
        [ProtoMember(4)]
        public bool assassin_mode { get; set; }

    }

    [ProtoContract]
    public class CLIENT_CHATTING_REQUEST_WHISPER_USER_INFO
    {
        [ProtoMember(1)]

        public string whisper_user_name { get; set; }
        [ProtoMember(2)]
        public ulong whisper_user_uid { get; set; }

    }

    [ProtoContract]
    public class CHATTING_CLIENT_WHISPER_USER_INFO_RESULT
    {
        [ProtoMember(1)]

        public uint result { get; set; }
        [ProtoMember(2)]
        _chatting_header whisper_user_info { get; set; }
        [ProtoMember(3)]
        public bool is_hidden { get; set; }

    }

    [ProtoContract]
    public class WORLD_CHATTING_REQUEST_WHISPER_USER_INFO
    {
        [ProtoMember(1)]

        public string whisper_user_name { get; set; }
        [ProtoMember(2)]
        public ulong whisper_user_uid { get; set; }
        [ProtoMember(3)]
        public int whisper_cmd_type { get; set; }

    }

    [ProtoContract]
    public class CHATTING_WORLD_WHISPER_USER_INFO_RESULT
    {
        [ProtoMember(1)]

        public uint result { get; set; }
        [ProtoMember(2)]
        public ulong request_user_uid { get; set; }
        [ProtoMember(3)]
        _chatting_header whisper_user_info { get; set; }
        [ProtoMember(4)]
        public int whisper_cmd_type { get; set; }

    }

    [ProtoContract]
    public class CLIENT_GAME_WORLD_CHATMSG
    {
        [ProtoMember(1)]

        public string msg { get; set; }
        [ProtoMember(2)]
        public ulong chatting_item_uid { get; set; }

    }

    [ProtoContract]
    public class GAME_GATEWAY_WORLD_CHATMSG
    {
        [ProtoMember(1)]

        public ulong character_uid { get; set; }
        [ProtoMember(2)]
        public string msg { get; set; }

    }

    [ProtoContract]
    public class CLIENT_GAME_ITEM_INFO_SHARE
    {
        [ProtoMember(1)]

        public int chatting_type { get; set; }
        [ProtoMember(2)]
        public ulong share_item_uid { get; set; }
        [ProtoMember(3)]
        public ulong chatting_item_uid { get; set; }

    }

    [ProtoContract]
    public class GAME_GATEWAY_ITEM_INFO_SHARE
    {
        [ProtoMember(1)]

        public int chatting_type { get; set; }
        [ProtoMember(2)]
        public ulong share_character_uid { get; set; }
        [ProtoMember(3)]
        public string msg { get; set; }
        [ProtoMember(4)]
        public int share_type { get; set; }

    }

    [ProtoContract]
    public class CLIENT_TRADE_ITEM_INFO_SHARE
    {
        [ProtoMember(1)]

        public int chatting_type { get; set; }
        [ProtoMember(2)]
        public ulong trade_uid { get; set; }

    }

    [ProtoContract]
    public class TRADE_GATEWAY_ITEM_INFO_SHARE
    {
        [ProtoMember(1)]

        public int chatting_type { get; set; }
        [ProtoMember(2)]
        public ulong share_character_uid { get; set; }
        [ProtoMember(3)]
        public string msg { get; set; }

    }

    [ProtoContract]
    public class CLIENT_WORLD_CHANGE_VOICE_CHAT_STATE
    {
        [ProtoMember(1)]

        public uint voice_chat_room_type { get; set; }
        [ProtoMember(2)]
        public ulong community_uid { get; set; }
        [ProtoMember(3)]
        public uint voice_chat_state { get; set; }

    }

    [ProtoContract]
    public class WORLD_CLIENT_CHANGE_MEMBER_VOICE_CHAT_STATE
    {
        [ProtoMember(1)]

        public uint voice_chat_room_type { get; set; }
        [ProtoMember(2)]
        public ulong community_uid { get; set; }
        [ProtoMember(3)]
        public uint voice_chat_state { get; set; }
        [ProtoMember(4)]
        public ulong change_user_uid { get; set; }

    }

    [ProtoContract]
    public class CLIENT_GAME_ITEM_INFO_SHARE_WHISPER
    {
        [ProtoMember(1)]

        public ulong send_user_uid { get; set; }
        [ProtoMember(2)]
        public ulong receive_user_uid { get; set; }
        [ProtoMember(3)]
        public ulong share_item_uid { get; set; }

    }

    [ProtoContract]
    public class GAME_WORLD_ITEM_INFO_SHARE_WHISPER
    {
        [ProtoMember(1)]

        public ulong receive_user_uid { get; set; }
        [ProtoMember(2)]
        public string msg { get; set; }

    }

    [ProtoContract]
    public class CLIENT_TRADE_ITEM_INFO_SHARE_WHISPER
    {
        [ProtoMember(1)]

        public ulong receive_user_uid { get; set; }
        [ProtoMember(2)]
        public ulong trade_uid { get; set; }

    }

    [ProtoContract]
    public class TRADE_WORLD_ITEM_INFO_SHARE_WHISPER
    {
        [ProtoMember(1)]

        public ulong receive_user_uid { get; set; }
        [ProtoMember(2)]
        public string msg { get; set; }

    }

    [ProtoContract]
    public class WORLD_CHATTING_SHARE_WHISPER
    {
        [ProtoMember(1)]

        public ulong receive_user_uid { get; set; }
        [ProtoMember(2)]
        public string msg { get; set; }
        [ProtoMember(3)]
        public uint share_type { get; set; }

    }

    [ProtoContract]
    public class CHATTING_CLIENT_ITEM_INFO_SHARE_WHISPER
    {
        [ProtoMember(1)]

        public ulong receive_user_uid { get; set; }
        [ProtoMember(2)]
        public string msg { get; set; }
        [ProtoMember(3)]
        public uint share_type { get; set; }

    }

    [ProtoContract]
    public class CHATTING_CLIENT_NOTIFY_GUILD_CHATTING_LIST_START
    {

    }

    [ProtoContract]
    public class CHATTING_CLIENT_NOTIFY_GUILD_CHATTING_LIST
    {
        [ProtoMember(1)]

        public _save_chatmsg_info[] chatmsg_info { get; set; }

    }

    [ProtoContract]
    public class CHATTING_CLIENT_NOTIFY_GUILD_CHATTING_LIST_END
    {

    }

    [ProtoContract]
    public class CHATTING_CLIENT_NOTIFY_WHISPER_CHATTING_LIST_START
    {
        [ProtoMember(1)]

        public ulong whisper_user_uid { get; set; }

    }

    [ProtoContract]
    public class CHATTING_CLIENT_NOTIFY_WHISPER_CHATTING_LIST
    {
        [ProtoMember(1)]

        public ulong whisper_user_uid { get; set; }
        [ProtoMember(2)]
        public _save_whisper_chatmsg_info[] chatmsg_info { get; set; }
        [ProtoMember(3)]
        public string whisper_user_profile { get; set; }
        [ProtoMember(4)]
        public long reg_date { get; set; }

    }

    [ProtoContract]
    public class CHATTING_CLIENT_NOTIFY_WHISPER_CHATTING_LIST_END
    {
        [ProtoMember(1)]

        public ulong whisper_user_uid { get; set; }

    }

    [ProtoContract]
    public class CLIENT_CHATTING_GUILD_CHATTING_LIST
    {
        [ProtoMember(1)]

        public ulong chatting_msg_read_time { get; set; }

    }

    [ProtoContract]
    public class CHATTING_CLIENT_GUILD_CHATTING_LIST_START
    {


    }

    [ProtoContract]
    public class CHATTING_CLIENT_GUILD_CHATTING_LIST
    {
        [ProtoMember(1)]

        public ulong chatting_msg_read_time { get; set; }
        [ProtoMember(2)]
        public _save_chatmsg_info[] chatmsg_info { get; set; }

    }

    [ProtoContract]
    public class CHATTING_CLIENT_GUILD_CHATTING_LIST_END
    {

    }

    [ProtoContract]
    public class CLIENT_CHATTING_WHISPER_CHATTING_LIST
    {
        [ProtoMember(1)]

        public ulong chatting_msg_read_time { get; set; }
        [ProtoMember(2)]
        public ulong target_user_uid { get; set; }

    }

    [ProtoContract]
    public class CHATTING_CLIENT_WHISPER_CHATTING_LIST_START
    {
        [ProtoMember(1)]

        public ulong target_user_uid { get; set; }

    }

    [ProtoContract]
    public class CHATTING_CLIENT_WHISPER_CHATTING_LIST
    {
        [ProtoMember(1)]

        public ulong target_user_uid { get; set; }
        [ProtoMember(2)]
        public _save_whisper_chatmsg_info[] chatmsg_info { get; set; }
        [ProtoMember(3)]
        public string target_user_profile { get; set; }
        [ProtoMember(4)]
        public long reg_date { get; set; }

    }

    [ProtoContract]
    public class CHATTING_CLIENT_WHISPER_CHATTING_LIST_END
    {
        [ProtoMember(1)]

        public ulong target_user_uid { get; set; }

    }

    [ProtoContract]
    public class CLIENT_CHATTING_SEARCH_NAME
    {
        [ProtoMember(1)]

        public string search_name { get; set; }

    }

    [ProtoContract]
    public class CHATTING_CLIENT_SEARCH_NAME
    {
        [ProtoMember(1)]

        public _search_user_info[] search_user_list { get; set; }

    }

    [ProtoContract]
    public class CLIENT_CHATTING_DELETE_WHISPER
    {
        [ProtoMember(1)]

        public ulong target_user_uid { get; set; }

    }

    [ProtoContract]
    public class CHATTING_CLIENT_DELETE_WHISPER
    {
        [ProtoMember(1)]

        public uint result { get; set; }
        [ProtoMember(2)]
        public ulong target_user_uid { get; set; }

    }

    [ProtoContract]
    public class CLIENT_CHATTING_GET_WHISPER_LIST
    {


    }

    [ProtoContract]
    public class CHATTING_CLIENT_NOTIFY_GET_WHISPER_LIST_START
    {
        [ProtoMember(1)]

        public bool is_login { get; set; }

    }

    [ProtoContract]
    public class CHATTING_CLIENT_NOTIFY_GET_WHISPER_LIST
    {
        [ProtoMember(1)]

        public _search_user_info[] whisper_list { get; set; }
        [ProtoMember(2)]
        public bool is_login { get; set; }

    }

    [ProtoContract]
    public class CHATTING_CLIENT_NOTIFY_GET_WHISPER_LIST_END
    {
        [ProtoMember(1)]

        public bool is_login { get; set; }

    }

    [ProtoContract]
    public class WORLD_CHATTING_SYNC_CHAT_PROFILE
    {
        [ProtoMember(1)]

        public string change_profile { get; set; }

    }

    [ProtoContract]
    public class CHATTING_CLIENT_NOTIFY_NOTICE
    {
        [ProtoMember(1)]

        public string _msg { get; set; }

        [ProtoMember(2)]
        public int notify_type { get; set; }
        [ProtoMember(3)]
        public ulong notify_start_time { get; set; }
        [ProtoMember(4)]
        public ulong notify_end_time { get; set; }
        [ProtoMember(5)]
        public string bg_color { get; set; }
        [ProtoMember(6)]
        public int repeat_cycle { get; set; }
        [ProtoMember(7)]
        public string font_color { get; set; }

    }

    [ProtoContract]
    public class CHATTING_CLIENT_NOTIFY_NOTICE_STOP
    {

    }

    [ProtoContract]
    public class GATEWAY_TRADE_CHATMSG
    {
        [ProtoMember(1)]

        public ulong character_uid { get; set; }
        [ProtoMember(2)]
        public int type { get; set; }
        [ProtoMember(3)]
        public string msg { get; set; }

    }

    [ProtoContract]
    public class GATEWAY_SHOP_CHATMSG
    {
        [ProtoMember(1)]

        public ulong character_uid { get; set; }
        [ProtoMember(2)]
        public int type { get; set; }
        [ProtoMember(3)]
        public string msg { get; set; }

    }

    [ProtoContract]
    public class GATEWAY_LOBBY_CHATMSG
    {
        [ProtoMember(1)]

        public ulong character_uid { get; set; }
        [ProtoMember(2)]
        public int type { get; set; }
        [ProtoMember(3)]
        public string msg { get; set; }

    }

    [ProtoContract]
    public class CHATTING_GATEWAY_NOTIFY_NOTICE
    {
        [ProtoMember(1)]

        public string _msg { get; set; }

        [ProtoMember(2)]
        public int notify_type { get; set; }
        [ProtoMember(3)]
        public ulong notify_start_time { get; set; }
        [ProtoMember(4)]
        public ulong notify_end_time { get; set; }
        [ProtoMember(5)]
        public string bg_color { get; set; }
        [ProtoMember(6)]
        public int repeat_cycle { get; set; }
        [ProtoMember(7)]
        public string font_color { get; set; }

    }

    [ProtoContract]
    public class CHATTING_GATEWAY_NOTIFY_NOTICE_STOP
    {

    }

    [ProtoContract]
    public class WORLD_CHATTING_RE_ENTER_CHATTING_ROOM_ALL_USER
    {
        [ProtoMember(1)]

        public _enter_chatting_room_info[] enter_chatting_room_info { get; set; }

    }

    [ProtoContract]
    public class CLIENT_GAME_SHARE_STAGE_INFO
    {
        [ProtoMember(1)]

        public int chat_type { get; set; }
        [ProtoMember(2)]
        public ulong receive_user_uid { get; set; }
        [ProtoMember(3)]
        public string receive_user_name { get; set; }

    }

    [ProtoContract]
    public class GAME_WORLD_SHARE_INFO
    {
        [ProtoMember(1)]

        public int chat_type { get; set; }
        [ProtoMember(2)]
        public ulong receive_user_uid { get; set; }
        [ProtoMember(3)]
        public string msg { get; set; }
        [ProtoMember(4)]
        public int chat_share_type { get; set; }

    }

    [ProtoContract]
    public class WORLD_CHATTING_WHISPER_INFO_DELETE
    {
        [ProtoMember(1)]

        public int delete_type { get; set; }
        [ProtoMember(2)]
        public ulong character_uid { get; set; }
        [ProtoMember(3)]
        public uint world_id { get; set; }

    }

    [ProtoContract]
    public class CHATTING_CLIENT_NOTIFY_WHISPER_INFO_DELETE
    {
        [ProtoMember(1)]

        public int delete_type { get; set; }
        [ProtoMember(2)]
        public ulong character_uid { get; set; }

    }

    [ProtoContract]
    public class CLIENT_GAME_ALLIANCE_GUILD_CHATTING
    {
        [ProtoMember(1)]

        public int chatting_type { get; set; }
        [ProtoMember(2)]
        public string msg { get; set; }
        [ProtoMember(3)]
        public int share_type { get; set; }
        [ProtoMember(4)]
        public ulong target_guild_uid { get; set; }

    }

    [ProtoContract]
    public class GAME_GATEWAY_ALLIANCE_GUILD_CHATTING
    {
        [ProtoMember(1)]

        public ulong character_uid { get; set; }
        [ProtoMember(2)]
        public int chatting_type { get; set; }
        [ProtoMember(3)]
        public string msg { get; set; }
        [ProtoMember(4)]
        public int share_type { get; set; }
        [ProtoMember(5)]
        public ulong target_guild_uid { get; set; }

    }

    [ProtoContract]
    public class CLIENT_GAME_ALLIANCE_GUILD_LIST
    {


    }

    [ProtoContract]
    public class GAME_CLIENT_ALLIANCE_GUILD_LIST
    {
        [ProtoMember(1)]

        public _alliance_guild_info[] _alliance_guild_list { get; set; }

    }

    [ProtoContract]
    public class RELAY_CHATMSG
    {
        [ProtoMember(1)]

        public ulong chat_user_uid { get; set; }
        [ProtoMember(2)]
        public int type { get; set; }
        [ProtoMember(3)]
        public string msg { get; set; }
        [ProtoMember(4)]
        public int share_type { get; set; }
        [ProtoMember(5)]
        public ulong chat_room_uid { get; set; }
        [ProtoMember(6)]
        _chatting_header chat_header { get; set; }

    }


    [ProtoContract]
    public class _cheat_user_pos
    {
        [ProtoMember(1)]

        public ulong user_uid { get; set; }
        [ProtoMember(2)]
        public int stage_id { get; set; }
        [ProtoMember(3)]
        public int channel_id { get; set; }
        [ProtoMember(4)]
        public _vector3 target_pos { get; set; }

    }

    [ProtoContract]
    public class WORLD_GAME_CHEAT_REQUEST_USER_POS
    {
        [ProtoMember(1)]

        public ulong user_uid { get; set; }
        [ProtoMember(2)]
        public ulong target_user_uid { get; set; }

    }

    [ProtoContract]
    public class GAME_WORLD_CHEAT_REQUEST_USER_POS
    {
        [ProtoMember(1)]

        public ulong user_uid { get; set; }
        [ProtoMember(2)]
        _cheat_user_pos target_user_info { get; set; }
        [ProtoMember(3)]
        public int result { get; set; }

    }

    [ProtoContract]
    public class WORLD_GAME_CHEAT_NOTIFY_USER_POS
    {
        [ProtoMember(1)]

        public ulong user_uid { get; set; }
        [ProtoMember(2)]
        _cheat_user_pos target_user_info { get; set; }
        [ProtoMember(3)]
        public int result { get; set; }

    }

    [ProtoContract]
    public class GAME_CLIENT_CHEAT_NOTIFY_USER_POS
    {
        [ProtoMember(1)]

        public _cheat_user_pos target_user_info { get; set; }
        [ProtoMember(2)]
        public int result { get; set; }

    }

    [ProtoContract]
    public class _cheat_user_info
    {
        [ProtoMember(1)]

        public ulong user_uid { get; set; }
        [ProtoMember(2)]
        public int user_state { get; set; }
        [ProtoMember(3)]
        public int zonegroup_index { get; set; }
        [ProtoMember(4)]
        public ulong zone_uid { get; set; }
        [ProtoMember(5)]
        public int zone_state { get; set; }
        [ProtoMember(6)]
        public int stage_id { get; set; }
        [ProtoMember(7)]
        public int channel_id { get; set; }

    }

    [ProtoContract]
    public class GAME_WORLD_CHEAT_REQUEST_USER_INFO
    {
        [ProtoMember(1)]

        public ulong request_user_uid { get; set; }
        [ProtoMember(2)]
        public string target_name { get; set; }

    }

    [ProtoContract]
    public class WORLD_GAME_CHEAT_NOTIFY_USER_INFO
    {
        [ProtoMember(1)]

        public ulong request_user_uid { get; set; }
        [ProtoMember(2)]
        public bool find_flag { get; set; }
        [ProtoMember(3)]
        _cheat_user_info target_user_info { get; set; }

    }

    [ProtoContract]
    public class WORLD_GAME_CHEAT_CHANNEL_ZONE_INFO
    {
        [ProtoMember(1)]

        public ulong request_user_uid { get; set; }
        [ProtoMember(2)]
        public int attach_user_count { get; set; }
        [ProtoMember(3)]
        public int wait_login_user_count { get; set; }
        [ProtoMember(4)]
        public int wait_warp_user_count { get; set; }
        [ProtoMember(5)]
        public int waiting_enter_user_count { get; set; }
        [ProtoMember(6)]
        public int waiting_register_user_count { get; set; }

    }

    [ProtoContract]
    public class GAME_WORLD_CHEAT_CHANGE_SETTLEMENT_TIME
    {
        [ProtoMember(1)]

        public int change_settlement_time { get; set; }
        [ProtoMember(2)]
        public int is_local_time_use { get; set; }

    }

    [ProtoContract]
    public class GAME_WORLD_CHEAT_TRANSFER_INFO_DELETE
    {
        [ProtoMember(1)]

        public ulong user_uid { get; set; }

    }

    [ProtoContract]
    public class WEBAPI_LOG_CHEAT_MAKE
    {
        [ProtoMember(1)]

        public int count { get; set; }

    }

    [ProtoContract]
    public class AGGRO_INFO
    {
        [ProtoMember(1)]

        public ulong uid { get; set; }
        [ProtoMember(2)]
        public int entity_type { get; set; }
        [ProtoMember(3)]
        public int aggro_point { get; set; }

    }

    [ProtoContract]
    public class CLIENT_GAME_AGGRO_INFO
    {
        [ProtoMember(1)]

        public ulong monster_uid { get; set; }

    }

    [ProtoContract]
    public class GAME_CLIENT_AGGRO_INFO
    {
        [ProtoMember(1)]

        public AGGRO_INFO[] aggro_info { get; set; }

    }

    [ProtoContract]
    public class WORLD_GAME_NTF_CHEAT_ACCOUNT_GRADE
    {
        [ProtoMember(1)]

        public ulong user_uid { get; set; }
        [ProtoMember(2)]
        public int account_grade { get; set; }

    }

    [ProtoContract]
    public class GAME_CLIENT_NTF_CHEAT_ACCOUNT_GRADE
    {
        [ProtoMember(1)]

        public int account_grade { get; set; }

    }


    [ProtoContract]
    public class CLIENT_GAME_CLOSED_TRAINING_INFO
    {

    }

    [ProtoContract]
    public class GAME_CLIENT_CLOSED_TRAINING_INFO
    {
        [ProtoMember(1)]

        public _closed_training_data[] training_data_list { get; set; }
        [ProtoMember(2)]
        public int total_level { get; set; }
        [ProtoMember(3)]
        public int collect_step { get; set; }
        [ProtoMember(4)]
        public int internal_injury_resistance { get; set; }

    }

    [ProtoContract]
    public class CLIENT_GAME_CLOSED_TRAINING_UPGRADE
    {
        [ProtoMember(1)]

        public int status_id { get; set; }

    }

    [ProtoContract]
    public class GAME_CLIENT_CLOSED_TRAINING_UPGRADE
    {
        [ProtoMember(1)]

        public int result { get; set; }
        [ProtoMember(2)]
        public int status_id { get; set; }
        [ProtoMember(3)]
        public int result_level { get; set; }
        [ProtoMember(4)]
        public int result_collectstep { get; set; }
        [ProtoMember(5)]
        public int internal_injury_resistance { get; set; }
        [ProtoMember(6)]
        _cost_info cost_Info { get; set; }
        [ProtoMember(7)]
        public _stack_item_info[] update_items { get; set; }

    }


    [ProtoContract]
    public class CLIENT_GAME_GET_CONTRACTADDRESS
    {

    }

    [ProtoContract]
    public class CLIENT_LOBBY_GET_CONTRACTADDRESS
    {
        [ProtoMember(1)]

        public ulong account_uid { get; set; }

    }

    [ProtoContract]
    public class GAME_CLIENT_GET_CONTRACTADDRESS
    {
        [ProtoMember(1)]

        public string draco_address { get; set; }
        [ProtoMember(2)]
        public string character_address { get; set; }
        [ProtoMember(3)]
        public string nft_character_url { get; set; }
        [ProtoMember(4)]
        public string hydra_address { get; set; }
        [ProtoMember(5)]
        public string mirage_address { get; set; }
        [ProtoMember(6)]
        public string wemixdollar_address { get; set; }

    }

    [ProtoContract]
    public class LOBBY_CLIENT_GET_CONTRACTADDRESS
    {
        [ProtoMember(1)]

        public string draco_address { get; set; }
        [ProtoMember(2)]
        public string character_address { get; set; }
        [ProtoMember(3)]
        public string nft_character_url { get; set; }
        [ProtoMember(4)]
        public string hydra_address { get; set; }
        [ProtoMember(5)]
        public string mirage_address { get; set; }
        [ProtoMember(6)]
        public string wemixdollar_address { get; set; }

    }

    [ProtoContract]
    public class CLIENT_GAME_DRACO_BALANCEOF
    {
        [ProtoMember(1)]

        public string user_address { get; set; }

    }

    [ProtoContract]
    public class GAME_CLIENT_DRACO_BALANCEOF
    {
        [ProtoMember(1)]

        public uint balanceof { get; set; }
        [ProtoMember(2)]
        public ulong accum_darksteel { get; set; }
        [ProtoMember(3)]
        public uint draco_smelting_count { get; set; }
        [ProtoMember(4)]
        public ulong draco_smelting_update_time { get; set; }

    }

    [ProtoContract]
    public class CLIENT_GAME_DRACO_EXCHANGE
    {
        [ProtoMember(1)]

        public int exchange_type { get; set; }
        [ProtoMember(2)]
        public string user_address { get; set; }
        [ProtoMember(3)]
        public string nonce { get; set; }
        [ProtoMember(4)]
        public string access_token { get; set; }
        [ProtoMember(5)]
        public uint amount { get; set; }

    }

    [ProtoContract]
    public class GAME_CLIENT_DRACO_EXCHANGE_RESULT
    {
        [ProtoMember(1)]

        public int exchange_type { get; set; }
        [ProtoMember(2)]
        public int transaction_state { get; set; }
        [ProtoMember(3)]
        public int result { get; set; }
        [ProtoMember(4)]
        public string tx_result { get; set; }

    }

    [ProtoContract]
    public class CLIENT_GAME_CHARACTER_MINT
    {
        [ProtoMember(1)]

        public string user_address { get; set; }
        [ProtoMember(2)]
        public string nonce { get; set; }
        [ProtoMember(3)]
        public string access_token { get; set; }
        [ProtoMember(4)]
        public string token_uri { get; set; }

    }

    [ProtoContract]
    public class CLIENT_GAME_REGISTER_USER_ADDRESS
    {
        [ProtoMember(1)]

        public string user_address { get; set; }
        [ProtoMember(2)]
        public string access_token { get; set; }

    }

    [ProtoContract]
    public class GAME_CLIENT_REGISTER_USER_ADDRESS
    {
        [ProtoMember(1)]

        public int result { get; set; }
        [ProtoMember(2)]
        public string user_address { get; set; }

    }

    [ProtoContract]
    public class GAME_WORLD_REGISTER_USER_ADDRESS
    {
        [ProtoMember(1)]

        public ulong user_uid { get; set; }
        [ProtoMember(2)]
        public string user_address { get; set; }
        [ProtoMember(3)]
        public string access_token { get; set; }

    }

    [ProtoContract]
    public class WORLD_GAME_REGISTER_USER_ADDRESS
    {
        [ProtoMember(1)]

        public ulong user_uid { get; set; }
        [ProtoMember(2)]
        public int result { get; set; }
        [ProtoMember(3)]
        public string user_address { get; set; }

    }

    [ProtoContract]
    public class CLIENT_LOBBY_REGISTER_USER_ADDRESS
    {
        [ProtoMember(1)]

        public ulong account_uid { get; set; }
        [ProtoMember(2)]
        public string user_address { get; set; }
        [ProtoMember(3)]
        public string access_token { get; set; }

    }

    [ProtoContract]
    public class LOBBY_CLIENT_REGISTER_USER_ADDRESS
    {
        [ProtoMember(1)]

        public int result { get; set; }
        [ProtoMember(2)]
        public string user_address { get; set; }

    }

    [ProtoContract]
    public class CLIENT_GAME_CHARACTER_SEAL
    {
        [ProtoMember(1)]

        public string user_address { get; set; }
        [ProtoMember(2)]
        public string nonce { get; set; }
        [ProtoMember(3)]
        public string user_sig { get; set; }
        [ProtoMember(4)]
        public ulong token_id { get; set; }

    }

    [ProtoContract]
    public class CLIENT_LOBBY_CHARACTER_UNSEAL
    {
        [ProtoMember(1)]

        public string user_address { get; set; }
        [ProtoMember(2)]
        public string nonce { get; set; }
        [ProtoMember(3)]
        public string user_sig { get; set; }
        [ProtoMember(4)]
        public ulong token_id { get; set; }
        [ProtoMember(5)]
        public ulong account_uid { get; set; }

    }

    [ProtoContract]
    public class GAME_CLIENT_CHARACTER_NFT_RESULT
    {
        [ProtoMember(1)]

        public int exchange_type { get; set; }
        [ProtoMember(2)]
        public int transaction_state { get; set; }
        [ProtoMember(3)]
        public int result { get; set; }
        [ProtoMember(4)]
        public ulong token_id { get; set; }

    }

    [ProtoContract]
    public class CLIENT_GAME_GET_DARKSTEEL_DAILY_SUM
    {
    }

    [ProtoContract]
    public class GAME_CLIENT_GET_DARKSTEEL_DAILY_SUM
    {
        [ProtoMember(1)]

        public ulong accum_darksteel { get; set; }
        [ProtoMember(2)]
        public ulong smelting_cost { get; set; }

    }

    [ProtoContract]
    public class CLIENT_GAME_GET_CHARACTER_SEAL_INFO
    {

    }

    [ProtoContract]
    public class GAME_CLIENT_GET_CHARACTER_SEAL_INFO
    {
        [ProtoMember(1)]

        public ulong server_prev_change_time { get; set; }
        [ProtoMember(2)]
        public ulong last_character_seal_time { get; set; }

    }

    [ProtoContract]
    public class LOBBY_CLIENT_CHARACTER_NFT_RESULT
    {
        [ProtoMember(1)]

        public int exchange_type { get; set; }
        [ProtoMember(2)]
        public int transaction_state { get; set; }
        [ProtoMember(3)]
        public int result { get; set; }
        [ProtoMember(4)]
        public ulong token_id { get; set; }

    }

    [ProtoContract]
    public class CLIENT_GAME_DARKSTEEL_MINIMUMRESERVE
    {
    }

    [ProtoContract]
    public class GAME_CLIENT_DARKSTEEL_MINIMUMRESERVE
    {
        [ProtoMember(1)]

        public int minimum_reserve { get; set; }

    }

    [ProtoContract]
    public class WORLDLINK_WORLD_CHARACTER_SEAL
    {
        [ProtoMember(1)]

        public int result { get; set; }
        [ProtoMember(2)]
        public ulong account_uid { get; set; }
        [ProtoMember(3)]
        public ulong character_uid { get; set; }
        [ProtoMember(4)]
        _contract_transaction_info contract_transaction_info { get; set; }
        [ProtoMember(5)]
        _characterInfo_mint characterInfo_mint { get; set; }

    }

    [ProtoContract]
    public class GAME_WORLDLINK_CHARACTER_SEAL_CANCEL
    {
        [ProtoMember(1)]

        public ulong account_uid { get; set; }
        [ProtoMember(2)]
        public ulong token_id { get; set; }
        [ProtoMember(3)]
        public int world_id { get; set; }

    }

    [ProtoContract]
    public class GAME_BLOCKCHAIN_CHARACTER_MINT
    {
        [ProtoMember(1)]

        public ulong account_uid { get; set; }
        [ProtoMember(2)]
        public ulong character_uid { get; set; }
        [ProtoMember(3)]
        public _contract_transaction_info contract_transaction_info { get; set; }
        [ProtoMember(4)]
        public _characterInfo_mint characterInfo_mint { get; set; }

    }

    [ProtoContract]
    public class BLOCKCHAIN_GAME_CHARACTER_MINT
    {
        [ProtoMember(1)]

        public int result { get; set; }
        [ProtoMember(2)]
        public ulong account_uid { get; set; }
        [ProtoMember(3)]
        public ulong character_uid { get; set; }
        [ProtoMember(4)]
        _contract_transaction_info contract_transaction_info { get; set; }
        [ProtoMember(5)]
        public ulong token_id { get; set; }
        [ProtoMember(6)]
        public int status { get; set; }

    }

    [ProtoContract]
    public class GAME_BLOCKCHAIN_CHARACTER_SEAL
    {
        [ProtoMember(1)]

        public ulong account_uid { get; set; }
        [ProtoMember(2)]
        public ulong character_uid { get; set; }
        [ProtoMember(3)]
        _contract_transaction_info contract_transaction_info { get; set; }
        [ProtoMember(4)]
        _characterInfo_mint characterInfo_mint { get; set; }

    }

    [ProtoContract]
    public class BLOCKCHAIN_GAME_CHARACTER_SEAL
    {
        [ProtoMember(1)]

        public int result { get; set; }
        [ProtoMember(2)]
        public ulong account_uid { get; set; }
        [ProtoMember(3)]
        public ulong character_uid { get; set; }
        [ProtoMember(4)]
        _contract_transaction_info contract_transaction_info { get; set; }
        [ProtoMember(5)]
        public int status { get; set; }

    }

    [ProtoContract]
    public class GAME_SHOP_NFT_SEAL_CHECK
    {
        [ProtoMember(1)]

        public ulong account_uid { get; set; }
        [ProtoMember(2)]
        public ulong character_uid { get; set; }
        [ProtoMember(3)]
        public uint transaction_type { get; set; }
        [ProtoMember(4)]
        public string user_address { get; set; }
        [ProtoMember(5)]
        public string nonce { get; set; }
        [ProtoMember(6)]
        public string access_token { get; set; }
        [ProtoMember(7)]
        public ulong id { get; set; }
        [ProtoMember(8)]
        public ulong token_id { get; set; }

    }

    [ProtoContract]
    public class SHOP_GAME_NFT_SEAL_CHECK
    {
        [ProtoMember(1)]

        public int result { get; set; }
        [ProtoMember(2)]
        public ulong account_uid { get; set; }
        [ProtoMember(3)]
        public ulong character_uid { get; set; }
        [ProtoMember(4)]
        public uint transaction_type { get; set; }
        [ProtoMember(5)]
        public string user_address { get; set; }
        [ProtoMember(6)]
        public string nonce { get; set; }
        [ProtoMember(7)]
        public string access_token { get; set; }
        [ProtoMember(8)]
        public ulong id { get; set; }
        [ProtoMember(9)]
        public ulong token_id { get; set; }

    }

    [ProtoContract]
    public class GAME_BLOCKCHAIN_MINT_CHARACTER_INFO_UPDATE
    {
        [ProtoMember(1)]

        _characterInfo_mint characterInfo_mint { get; set; }

    }

    [ProtoContract]
    public class GAME_WORLD_CHARACTER_NFT_RESULT
    {
        [ProtoMember(1)]

        public int result { get; set; }
        [ProtoMember(2)]
        public ulong character_uid { get; set; }
        [ProtoMember(3)]
        public ulong token_id { get; set; }
        [ProtoMember(4)]
        public bool is_seal { get; set; }

    }

    [ProtoContract]
    public class WORLD_GAME_CHARACTER_NFT_RESULT
    {
        [ProtoMember(1)]

        public int result { get; set; }
        [ProtoMember(2)]
        public ulong character_uid { get; set; }
        [ProtoMember(3)]
        public ulong token_id { get; set; }
        [ProtoMember(4)]
        public bool is_seal { get; set; }

    }

    [ProtoContract]
    public class GAME_TRADE_NFT_SEAL_CHECK
    {
        [ProtoMember(1)]

        public ulong account_uid { get; set; }
        [ProtoMember(2)]
        public ulong character_uid { get; set; }
        [ProtoMember(3)]
        public uint transaction_type { get; set; }
        [ProtoMember(4)]
        public string user_address { get; set; }
        [ProtoMember(5)]
        public string nonce { get; set; }
        [ProtoMember(6)]
        public string access_token { get; set; }
        [ProtoMember(7)]
        public ulong id { get; set; }
        [ProtoMember(8)]
        public ulong token_id { get; set; }

    }

    [ProtoContract]
    public class TRADE_GAME_NFT_SEAL_CHECK
    {
        [ProtoMember(1)]

        public int result { get; set; }
        [ProtoMember(2)]
        public ulong account_uid { get; set; }
        [ProtoMember(3)]
        public ulong character_uid { get; set; }
        [ProtoMember(4)]
        public uint transaction_type { get; set; }
        [ProtoMember(5)]
        public string user_address { get; set; }
        [ProtoMember(6)]
        public string nonce { get; set; }
        [ProtoMember(7)]
        public string access_token { get; set; }
        [ProtoMember(8)]
        public ulong id { get; set; }
        [ProtoMember(9)]
        public ulong token_id { get; set; }

    }

    [ProtoContract]
    public class CLIENT_GAME_HYDRA_EXCHANGE
    {
        [ProtoMember(1)]

        public int exchange_type { get; set; }
        [ProtoMember(2)]
        public string user_address { get; set; }
        [ProtoMember(3)]
        public string nonce { get; set; }
        [ProtoMember(4)]
        public string access_token { get; set; }
        [ProtoMember(5)]
        public uint amount { get; set; }

    }

    [ProtoContract]
    public class GAME_CLIENT_HYDRA_EXCHANGE_RESULT
    {
        [ProtoMember(1)]

        public int exchange_type { get; set; }
        [ProtoMember(2)]
        public int transaction_state { get; set; }
        [ProtoMember(3)]
        public int result { get; set; }
        [ProtoMember(4)]
        public string tx_result { get; set; }

    }

    [ProtoContract]
    public class CLIENT_GAME_CHECK_DRACO_APPOVE
    {
        [ProtoMember(1)]

        public string user_address { get; set; }

    }

    [ProtoContract]
    public class GAME_CLIENT_CHECK_DRACO_APPOVE
    {
        [ProtoMember(1)]

        public int result { get; set; }
        [ProtoMember(2)]
        public string tx_hash { get; set; }

    }

    [ProtoContract]
    public class CLIENT_GAME_DRACO_HYDRA_APPROVE
    {
        [ProtoMember(1)]

        public string user_address { get; set; }
        [ProtoMember(2)]
        public string signature { get; set; }

    }

    [ProtoContract]
    public class GAME_CLIENT_DRACO_HYDRA_APPROVE
    {
        [ProtoMember(1)]

        public int result { get; set; }

    }

    [ProtoContract]
    public class CLIENT_GAME_GET_HYDRA_REFINE_FEE
    {
    }

    [ProtoContract]
    public class GAME_CLIENT_GET_HYDRA_REFINE_FEE
    {
        [ProtoMember(1)]

        public int draco_fee { get; set; }
        [ProtoMember(2)]
        public int septaria_fee { get; set; }
        [ProtoMember(3)]
        public int darksteel_fee { get; set; }

    }

    [ProtoContract]
    public class CLIENT_GAME_HYDRA_BALANCEOF
    {
        [ProtoMember(1)]
        public string user_address { get; set; }

    }

    [ProtoContract]
    public class GAME_CLIENT_HYDRA_BALANCEOF
    {
        [ProtoMember(1)]

        public uint balanceof { get; set; }
        [ProtoMember(2)]
        public int draco_fee { get; set; }
        [ProtoMember(3)]
        public int septaria_fee { get; set; }
        [ProtoMember(4)]
        public int darksteel_fee { get; set; }
        [ProtoMember(5)]
        public int fee_stage { get; set; }
        [ProtoMember(6)]
        public int draco_add { get; set; }
        [ProtoMember(7)]
        public string balanceof_org { get; set; }

    }

    [ProtoContract]
    public class CLIENT_GAME_CHECK_HYDRA_APPOVE
    {
        [ProtoMember(1)]

        public string user_address { get; set; }

    }

    [ProtoContract]
    public class GAME_CLIENT_CHECK_HYDRA_APPOVE
    {
        [ProtoMember(1)]

        public int result { get; set; }
        [ProtoMember(2)]
        public string tx_hash { get; set; }

    }

    [ProtoContract]
    public class CLIENT_GAME_HYDRA_APPROVE
    {
        [ProtoMember(1)]

        public string user_address { get; set; }
        [ProtoMember(2)]
        public string signature { get; set; }

    }

    [ProtoContract]
    public class GAME_CLIENT_HYDRA_APPROVE
    {
        [ProtoMember(1)]

        public int result { get; set; }

    }

    [ProtoContract]
    public class CLIENT_GAME_DRAGONSTEEL_EXCHANGE_START
    {
        [ProtoMember(1)]

        public uint amount { get; set; }
        [ProtoMember(2)]
        public string player_key { get; set; }

    }

    [ProtoContract]
    public class GAME_CLIENT_DRAGONSTEEL_EXCHANGE_RESULT
    {
        [ProtoMember(1)]

        public int result { get; set; }
        [ProtoMember(2)]
        public int game_result { get; set; }

    }

    [ProtoContract]
    public class GAME_CLIENT_DRAGONSTEEL_EXCHANGE_START
    {
        [ProtoMember(1)]

        public int result { get; set; }
        [ProtoMember(2)]
        public string pay_id { get; set; }
        [ProtoMember(3)]
        public int game_result { get; set; }
        [ProtoMember(4)]
        public long sign_id { get; set; }
        [ProtoMember(5)]
        public long sign_amount { get; set; }

    }

    [ProtoContract]
    public class CLIENT_GAME_DRAGONSTEEL_EXCHANGE_VERIFY
    {
        [ProtoMember(1)]

        public string pay_id { get; set; }
        [ProtoMember(2)]
        public string player_key { get; set; }
        [ProtoMember(3)]
        public string purchase_token { get; set; }
        [ProtoMember(4)]
        public uint amount { get; set; }

    }

    [ProtoContract]
    public class GAME_CLIENT_DRAGONSTEEL_EXCHANGE_VERIFY
    {
        [ProtoMember(1)]

        public int result { get; set; }
        [ProtoMember(2)]
        public long dragonsteel_amount { get; set; }

    }

    [ProtoContract]
    public class CLIENT_GAME_WEMIXDOLLAR_BALANCEOF
    {
        [ProtoMember(1)]

        public string user_address { get; set; }

    }

    [ProtoContract]
    public class GAME_CLIENT_WEMIXDOLLAR_BALANCEOF
    {
        [ProtoMember(1)]

        public uint balanceof { get; set; }
        [ProtoMember(2)]
        public string balanceof_org { get; set; }

    }

    [ProtoContract]
    public class CLIENT_GAME_CHECK_WEMIXDOLLAR_APPROVE
    {
        [ProtoMember(1)]

        public string user_address { get; set; }

    }

    [ProtoContract]
    public class GAME_CLIENT_CHECK_WEMIXDOLLAR_APPROVE
    {
        [ProtoMember(1)]

        public int result { get; set; }
        [ProtoMember(2)]
        public string tx_hash { get; set; }

    }

    [ProtoContract]
    public class CLIENT_GAME_WEMIXDOLLAR_APPROVE
    {
        [ProtoMember(1)]

        public string user_address { get; set; }
        [ProtoMember(2)]
        public string signature { get; set; }

    }

    [ProtoContract]
    public class GAME_CLIENT_WEMIXDOLLAR_APPROVE
    {
        [ProtoMember(1)]

        public int result { get; set; }

    }

    [ProtoContract]
    public class GAME_CLIENT_COST_INFO
    {
        [ProtoMember(1)]

        public _cost_info[] costInfo { get; set; }
        [ProtoMember(2)]
        public _time_ticket_info[] time_ticket_info { get; set; }

    }


    [ProtoContract]
    public class CLIENT_GAME_EQUIP_COSTUME
    {
        [ProtoMember(1)]

        public ulong uid { get; set; }
        [ProtoMember(2)]
        public uint equip_costume_id { get; set; }

    }

    [ProtoContract]
    public class GAME_CLIENT_EQUIP_COSTUME
    {
        [ProtoMember(1)]

        public uint result { get; set; }
        [ProtoMember(2)]
        public uint parts { get; set; }
        [ProtoMember(3)]
        public uint equip_costume_id { get; set; }
        [ProtoMember(4)]
        public uint un_equip_costume_id { get; set; }

    }

    [ProtoContract]
    public class CLIENT_GAME_UNEQUIP_COSTUME
    {
        [ProtoMember(1)]

        public ulong uid { get; set; }
        [ProtoMember(2)]
        public uint un_equip_costume_id { get; set; }

    }

    [ProtoContract]
    public class GAME_CLIENT_UNEQUIP_COSTUME
    {
        [ProtoMember(1)]

        public uint result { get; set; }
        [ProtoMember(2)]
        public uint parts { get; set; }
        [ProtoMember(3)]
        public uint un_equip_costume_id { get; set; }

    }

    [ProtoContract]
    public class CLIENT_GAME_PURCHASE_COSTUME
    {
        [ProtoMember(1)]

        public _costume_info purchase_costume_info { get; set; }

    }

    [ProtoContract]
    public class GAME_CLIENT_PURCHASE_COSTUME
    {
        [ProtoMember(1)]

        public uint result { get; set; }
        [ProtoMember(2)]
        _costume_info purchase_costume_info { get; set; }
        [ProtoMember(3)]
        public _cost_info[] costInfo { get; set; }
        [ProtoMember(4)]
        public _stack_item_info[] update_items { get; set; }

    }

    [ProtoContract]
    public class CLIENT_GAME_HIDE_COSTUME
    {
        [ProtoMember(1)]

        public ulong uid { get; set; }
        [ProtoMember(2)]
        public uint parts { get; set; }
        [ProtoMember(3)]
        public bool is_hide { get; set; }

    }

    [ProtoContract]
    public class GAME_CLIENT_HIDE_COSTUME
    {
        [ProtoMember(1)]

        public uint result { get; set; }
        [ProtoMember(2)]
        public uint parts { get; set; }
        [ProtoMember(3)]
        public bool is_hide { get; set; }

    }

    [ProtoContract]
    public class CLIENT_GAME_CHANGE_COSTUME_COLOR
    {
        [ProtoMember(1)]

        _costume_info change_costume_info { get; set; }

    }

    [ProtoContract]
    public class GAME_CLIENT_CHANGE_COSTUME_COLOR
    {
        [ProtoMember(1)]

        public uint result { get; set; }
        [ProtoMember(2)]
        _costume_info change_costume_info { get; set; }
        [ProtoMember(3)]
        public _cost_info[] costInfo { get; set; }
        [ProtoMember(4)]
        public _stack_item_info[] update_items { get; set; }

    }

    [ProtoContract]
    public class CLIENT_GAME_EQUIP_LUXURY_COSTUME
    {
        [ProtoMember(1)]

        public ulong equip_item_uid { get; set; }

    }

    [ProtoContract]
    public class GAME_CLIENT_EQUIP_LUXURY_COSTUME
    {
        [ProtoMember(1)]

        public uint result { get; set; }
        [ProtoMember(2)]
        public uint luxury_parts { get; set; }
        [ProtoMember(3)]
        public ulong equip_item_uid { get; set; }
        [ProtoMember(4)]
        public ulong un_equip_item_uid { get; set; }

    }

    [ProtoContract]
    public class CLIENT_GAME_UNEQUIP_LUXURY_COSTUME
    {
        [ProtoMember(1)]

        public ulong un_equip_item_uid { get; set; }

    }

    [ProtoContract]
    public class GAME_CLIENT_UNEQUIP_LUXURY_COSTUME
    {
        [ProtoMember(1)]

        public uint result { get; set; }
        [ProtoMember(2)]
        public uint luxury_parts { get; set; }
        [ProtoMember(3)]
        public ulong un_equip_item_uid { get; set; }

    }

    [ProtoContract]
    public class CLIENT_GAME_HIDE_LUXURY_COSTUME
    {
        [ProtoMember(1)]

        _luxury_costume_hide_info hide_info { get; set; }

    }

    [ProtoContract]
    public class GAME_CLIENT_HIDE_LUXURY_COSTUME
    {
        [ProtoMember(1)]

        public uint result { get; set; }
        [ProtoMember(2)]
        _luxury_costume_hide_info hide_info { get; set; }

    }

    [ProtoContract]
    public class GAME_CLIENT_NOTIFY_DAILY_GOODS_INFO
    {
        [ProtoMember(1)]

        public _daily_goods_info[] daily_goods_info { get; set; }

    }

    [ProtoContract]
    public class CLIENT_GAME_DAILY_GOODS_ADD
    {
        [ProtoMember(1)]

        public int DailyGoodsType { get; set; }
        [ProtoMember(2)]
        public int Value { get; set; }

    }

    [ProtoContract]
    public class GAME_CLIENT_DAILY_GOODS_ADD
    {
        [ProtoMember(1)]

        _daily_goods_info daily_goods_info { get; set; }
        [ProtoMember(2)]
        public _cost_info[][] character_cost { get; set; }

    }

    [ProtoContract]
    public class GAME_CLIENT_NOTIFY_DAILY_GOODS_RESET
    {
        [ProtoMember(1)]

        public _daily_goods_info[] daily_goods_info { get; set; }

    }


    [ProtoContract]
    public class GAME_CLIENT_NTF_DARK_ALTAR_ZONE_ENTER_INFO
    {
        [ProtoMember(1)]

        _dark_altar_info dark_altar_info { get; set; }
        [ProtoMember(2)]
        public ulong altar_monster_uid { get; set; }

    }

    [ProtoContract]
    public class CLIENT_WORLD_REQ_DARK_ALTAR_INFO_LIST
    {
    }

    [ProtoContract]
    public class WORLD_CLIENT_ACK_DARK_ALTAR_INFO_LIST
    {
        [ProtoMember(1)]

        public _dark_altar_info[] dark_altar_info_list { get; set; }

    }

    [ProtoContract]
    public class WORLD_GAME_NTF_DARK_ALTAR_SERVER_INFO
    {
        [ProtoMember(1)]

        public ulong dark_altar_zone_uid { get; set; }
        [ProtoMember(2)]
        _dark_altar_server_info dark_altar_server_info { get; set; }

    }

    [ProtoContract]
    public class WORLD_GAME_NTF_DARK_ALTAR_MONSTER_INFO_TO_UNDER_WORLD_ZONE
    {
        [ProtoMember(1)]

        public ulong under_world_zone_uid { get; set; }
        [ProtoMember(2)]
        _dark_altar_server_info dark_altar_server_info { get; set; }

    }

    [ProtoContract]
    public class WORLD_CLIENT_NTF_DARK_ALTAR_INFO_TO_ALL_USER
    {
        [ProtoMember(1)]

        _dark_altar_info dark_altar_info { get; set; }

    }

    [ProtoContract]
    public class GAME_WORLD_NTF_DARK_ALTAR_MONSTER_DIE
    {
        [ProtoMember(1)]

        public int dark_altar_tid { get; set; }
        [ProtoMember(2)]
        public ulong dark_altar_zone_uid { get; set; }
        [ProtoMember(3)]
        public ulong mvp_user_uid { get; set; }
        [ProtoMember(4)]
        public string mvp_user_name { get; set; }

    }

    [ProtoContract]
    public class GAME_CLIENT_NTF_RESULT_DARK_ALTAR_TO_BATTLE_USER
    {
        [ProtoMember(1)]

        public int dark_altar_tid { get; set; }
        [ProtoMember(2)]
        public string mvp_user_name { get; set; }

    }

    [ProtoContract]
    public class WORLD_GAME_SYNC_DARK_ALTAR_INFO_IN_ZONE_GROUP
    {
        [ProtoMember(1)]

        _dark_altar_server_info dark_altar_server_info { get; set; }

    }

    [ProtoContract]
    public class WORLD_GAME_SYNC_DARK_ALTAR_INFO_LIST_IN_ZONE_GROUP
    {
        [ProtoMember(1)]

        public _dark_altar_server_info[] dark_altar_server_info_list { get; set; }

    }

    [ProtoContract]
    public class SERVER_CLIENT_NTF_DARK_ALTAR_NOTICE
    {
        [ProtoMember(1)]

        public int dark_altar_tid { get; set; }
        [ProtoMember(2)]
        public int notice_type { get; set; }
        [ProtoMember(3)]
        public long value { get; set; }

    }

    [ProtoContract]
    public class GAME_CLIENT_NTF_DARK_ALTAR_UNDER_WORLD_ZONE_ENTER_INFO
    {
        [ProtoMember(1)]

        _dark_altar_info dark_altar_info { get; set; }

    }

    [ProtoContract]
    public class GAME_CLIENT_NTF_DARK_ALTAR_CHEAT_ATTACK
    {
        [ProtoMember(1)]

        public bool is_attackable { get; set; }

    }

    [ProtoContract]
    public class GAME_WORLD_NTF_DARK_ALTAR_ATTACK
    {
        [ProtoMember(1)]

        public int dark_altar_tid { get; set; }
        [ProtoMember(2)]
        public int notice_type { get; set; }

    }


    [ProtoContract]
    public class _dominion_wanted_info_server
    {
        [ProtoMember(1)]

        public uint dominion_pk_tid { get; set; }
        [ProtoMember(2)]
        public ulong target_uid { get; set; }
        [ProtoMember(3)]
        public long wanted_start_time { get; set; }
        [ProtoMember(4)]
        public long wanted_end_time { get; set; }

    }

    [ProtoContract]
    public class _dominion_wanted_info
    {
        [ProtoMember(1)]

        public uint dominion_pk_tid { get; set; }
        [ProtoMember(2)]
        public ulong target_uid { get; set; }
        [ProtoMember(3)]
        public string nickname { get; set; }
        [ProtoMember(4)]
        public int _class { get; set; }
        [ProtoMember(5)]
        public long combatpoint { get; set; }
        [ProtoMember(6)]
        public _guild_name_ui_info guildinfo { get; set; }
        [ProtoMember(7)]
        bool is_online { get; set; }
        [ProtoMember(8)]
        public long wanted_end_time { get; set; }

    }

    [ProtoContract]
    public class _dark_altar_state
    {
        [ProtoMember(1)]

        public uint dark_altar_id { get; set; }
        [ProtoMember(2)]
        public bool is_destruction { get; set; }

    }

    [ProtoContract]
    public class CLIENT_WORLD_GET_DOMINION_TAX_INFO
    {
        [ProtoMember(1)]

        public int dominion_tid { get; set; }

    }

    [ProtoContract]
    public class WORLD_CLIENT_GET_DOMINION_TAX_INFO
    {
        [ProtoMember(1)]

        public int dominion_tid { get; set; }
        [ProtoMember(2)]
        public _dominion_tax_info[] dominion_tax_info_list { get; set; }

    }

    [ProtoContract]
    public class GAME_WORLD_UPDATE_DOMINION_TAX
    {
        [ProtoMember(1)]

        public int dominion_tid { get; set; }
        [ProtoMember(2)]
        public int money_type { get; set; }
        [ProtoMember(3)]
        public int tax_log_type { get; set; }
        [ProtoMember(4)]
        public int tax_log_kind { get; set; }
        [ProtoMember(5)]
        public long update_value { get; set; }

    }

    [ProtoContract]
    public class CLIENT_WORLD_REQ_DOMINION_STRONG_POINT_INFO
    {
        [ProtoMember(1)]

        public int strong_point_tid { get; set; }

    }

    [ProtoContract]
    public class WORLD_CLIENT_ACK_DOMINION_STRONG_POINT_INFO
    {
        [ProtoMember(1)]

        _strong_point_info_v2 strong_point_info { get; set; }
        [ProtoMember(2)]
        public uint win_target_cur_hp { get; set; }
        [ProtoMember(3)]
        public bool is_appear_boss { get; set; }
        [ProtoMember(4)]
        public ulong black_iron_value { get; set; }
        [ProtoMember(5)]
        public uint zone_user_count { get; set; }
        [ProtoMember(6)]
        public ulong win_target_occupy_guild_uid { get; set; }
        [ProtoMember(7)]
        public string win_target_occupy_guild_name { get; set; }
        [ProtoMember(8)]
        public bool is_take_over_time { get; set; }
        [ProtoMember(9)]
        public uint channel_state { get; set; }
        [ProtoMember(10)]
        public _cost_info[] dominion_storage_cost { get; set; }
        [ProtoMember(11)]
        public long guild_npc_shop_remain_black_iron { get; set; }
        [ProtoMember(12)]
        public string occupy_guild_proclamation { get; set; }
        [ProtoMember(13)]
        public int[] event_buff_id_list { get; set; }
        [ProtoMember(14)]
        _dark_altar_info dark_altar_info { get; set; }

    }

    [ProtoContract]
    public class GAME_WORLD_UPDATE_APPEAR_BOSS_MONSTER
    {
        [ProtoMember(1)]

        public int strong_point_tid { get; set; }
        [ProtoMember(2)]
        public bool is_appear_boss { get; set; }

    }

    [ProtoContract]
    public class GAME_WORLD_UPDATE_BLACK_IRON_INFO
    {
        [ProtoMember(1)]

        public int dominion_tid { get; set; }
        [ProtoMember(2)]
        public int black_lron_value { get; set; }

    }

    [ProtoContract]
    public class CLIENT_WORLD_REQ_DOMINION_SIEGE_INFO
    {
        [ProtoMember(1)]

        public int siege_tid { get; set; }

    }

    [ProtoContract]
    public class _dominion_siege_battle_guilds_info
    {
        [ProtoMember(1)]

        _guild_simple_info defense_guild_simple_info { get; set; }
        [ProtoMember(2)]
        public long defense_guild_total_combat_point { get; set; }
        [ProtoMember(3)]
        _guild_simple_info offense_guild_simple_info { get; set; }
        [ProtoMember(4)]
        public long offense_guild_total_combat_point { get; set; }

    }

    [ProtoContract]
    public class WORLD_CLIENT_ACK_DOMINION_SIEGE_INFO
    {
        [ProtoMember(1)]

        _siege_info siege_info { get; set; }
        [ProtoMember(2)]
        public long guild_total_combat_point { get; set; }
        [ProtoMember(3)]
        _siege_info_in_normal siege_info_in_normal { get; set; }
        [ProtoMember(5)]
        _siege_info_in_auction siege_info_in_auction { get; set; }
        [ProtoMember(6)]
        _dominion_siege_battle_guilds_info siege_battle_guilds_info { get; set; }
        [ProtoMember(7)]
        public int siege_run_time_minute { get; set; }
        [ProtoMember(8)]
        public ulong siege_occupy_time { get; set; }

    }

    [ProtoContract]
    public class CLIENT_WORLD_GET_DOMINION_INFO
    {
    }

    [ProtoContract]
    public class WORLD_CLIENT_GET_DOMINION_INFO
    {
        [ProtoMember(1)]

        public _dominion_info[] dominion_info_list { get; set; }

    }

    [ProtoContract]
    public class CLIENT_WORLD_DOMINION_TAX_RATE_CHANGE
    {
        [ProtoMember(1)]

        public int dominion_tid { get; set; }
        [ProtoMember(2)]
        public int change_rate { get; set; }
        [ProtoMember(3)]
        public int change_money_type { get; set; }

    }

    [ProtoContract]
    public class WORLD_CLIENT_DOMINION_TAX_RATE_CHANGE
    {
        [ProtoMember(1)]

        public int dominion_tid { get; set; }
        [ProtoMember(2)]
        public int change_rate { get; set; }
        [ProtoMember(3)]
        public int change_money_type { get; set; }
        [ProtoMember(4)]
        public int result { get; set; }

    }

    [ProtoContract]
    public class WORLD_CLIENT_DOMINION_TAX_RATE_CHANGE_NOTIFY
    {
        [ProtoMember(1)]

        _dominion_info dominion_info { get; set; }

    }

    [ProtoContract]
    public class CLIENT_WORLD_DOMINION_TAX_WITHDRAWAL
    {
        [ProtoMember(1)]

        public int dominion_tid { get; set; }
        [ProtoMember(2)]
        public long withdrawal_gold { get; set; }
        [ProtoMember(3)]
        public long withdrawal_coin { get; set; }

    }

    [ProtoContract]
    public class WORLD_CLIENT_DOMINION_TAX_WITHDRAWAL
    {
        [ProtoMember(1)]

        public int dominion_tid { get; set; }
        [ProtoMember(2)]
        public long withdrawal_gold { get; set; }
        [ProtoMember(3)]
        public long withdrawal_coin { get; set; }
        [ProtoMember(4)]
        public _dominion_tax_info[] dominion_tax_info_list { get; set; }
        [ProtoMember(5)]
        public int result { get; set; }

    }

    [ProtoContract]
    public class CLIENT_WORLD_DOMINION_IMPERIAL_ORDER
    {
        [ProtoMember(1)]

        public int dominion_buff_id { get; set; }

    }

    [ProtoContract]
    public class WORLD_CLIENT_DOMINION_IMPERIAL_ORDER
    {
        [ProtoMember(1)]

        public int dominion_buff_id { get; set; }
        [ProtoMember(2)]
        public int result { get; set; }
        [ProtoMember(3)]
        public int imperial_order_count { get; set; }

    }

    [ProtoContract]
    public class WORLD_GAME_DOMINION_IMPERIAL_ORDER
    {
        [ProtoMember(1)]

        public int dominion_id { get; set; }
        [ProtoMember(2)]
        public int dominion_buff_id { get; set; }
        [ProtoMember(3)]
        public long dominion_buff_end_time { get; set; }

    }

    [ProtoContract]
    public class CLIENT_WORLD_DOMINION_PRIZE
    {
        [ProtoMember(1)]

        public uint dominion_id { get; set; }
        [ProtoMember(2)]
        public uint prize_tid { get; set; }
        [ProtoMember(3)]
        public string target_name { get; set; }
        [ProtoMember(4)]
        public ulong target_user_uid { get; set; }

    }

    [ProtoContract]
    public class WORLD_CLIENT_DOMINION_PRIZE
    {
        [ProtoMember(1)]

        public uint dominion_id { get; set; }
        [ProtoMember(2)]
        public uint prize_tid { get; set; }
        [ProtoMember(3)]
        public string target_name { get; set; }
        [ProtoMember(4)]
        public _dominion_prize_info[] dominion_prize_list { get; set; }
        [ProtoMember(5)]
        public int result { get; set; }

    }

    [ProtoContract]
    public class WORLD_GAME_SYNC_DOMINION_INFO
    {
        [ProtoMember(1)]

        _dominion_info dominion_info { get; set; }

    }

    [ProtoContract]
    public class WORLD_GAME_SYNC_DOMINION_INFO_LIST
    {
        [ProtoMember(1)]

        public _dominion_info[] dominion_info_list { get; set; }
        [ProtoMember(2)]
        public _dominion_wanted_info_server[] dominion_wanted_info_list { get; set; }
        [ProtoMember(3)]
        public ulong before_daily_black_iron { get; set; }
        [ProtoMember(4)]
        public ulong last_daily_black_iron_update_time { get; set; }

    }

    [ProtoContract]
    public class CLIENT_WORLD_DOMINION_TITLE_LIST
    {
        [ProtoMember(1)]

        public int dominion_tid { get; set; }

    }

    [ProtoContract]
    public class WORLD_CLIENT_DOMINION_TITLE_LIST
    {
        [ProtoMember(1)]

        public int dominion_tid { get; set; }
        [ProtoMember(2)]
        public _dominion_title_info[] _dominion_title_list { get; set; }

    }

    [ProtoContract]
    public class CLIENT_WORLD_DOMINION_GIVE_TITLE
    {
        [ProtoMember(1)]

        public int dominion_tid { get; set; }
        [ProtoMember(2)]
        public int title_tid { get; set; }
        [ProtoMember(3)]
        public ulong target_user_uid { get; set; }
        [ProtoMember(4)]
        public string target_user_name { get; set; }
        [ProtoMember(5)]
        public bool is_give { get; set; }

    }

    [ProtoContract]
    public class WORLD_CLIENT_DOMINION_GIVE_TITLE
    {
        [ProtoMember(1)]

        public int dominion_tid { get; set; }
        [ProtoMember(2)]
        public int title_tid { get; set; }
        [ProtoMember(4)]
        public ulong target_user_uid { get; set; }
        [ProtoMember(5)]
        public string target_user_name { get; set; }
        [ProtoMember(6)]
        public string target_user_profile { get; set; }
        [ProtoMember(7)]
        public bool is_give { get; set; }
        [ProtoMember(8)]
        public int result { get; set; }

    }

    [ProtoContract]
    public class WORLD_CLIENT_DOMINION_GIVE_TITLE_TARGET_NOTIFY
    {
        [ProtoMember(1)]

        public int dominion_tid { get; set; }
        [ProtoMember(2)]
        public ulong target_user_uid { get; set; }
        [ProtoMember(3)]
        public int title_tid { get; set; }
        [ProtoMember(4)]
        public bool is_give { get; set; }
        [ProtoMember(5)]
        public ulong guild_uid { get; set; }

    }

    [ProtoContract]
    public class WORLD_CLIENT_DOMINION_GIVE_TITLE_NOTIFY
    {
        [ProtoMember(1)]

        public int title_tid { get; set; }
        [ProtoMember(2)]
        public ulong target_user_uid { get; set; }
        [ProtoMember(3)]
        public string target_user_name { get; set; }

    }

    [ProtoContract]
    public class WORLD_CLIENT_DOMINION_IMPERIAL_ORDER_NOTIFY
    {
        [ProtoMember(1)]

        public int dominion_id { get; set; }
        [ProtoMember(2)]
        public int dominion_buff_id { get; set; }
        [ProtoMember(3)]
        public ulong master_uid { get; set; }
        [ProtoMember(4)]
        public string master_name { get; set; }

    }

    [ProtoContract]
    public class WORLD_CLIENT_DOMINION_PRIZE_NOTIFY
    {
        [ProtoMember(1)]

        public uint dominion_tid { get; set; }
        [ProtoMember(2)]
        public uint prize_tid { get; set; }
        [ProtoMember(3)]
        public string target_name { get; set; }
        [ProtoMember(4)]
        public ulong send_user_uid { get; set; }

    }

    [ProtoContract]
    public class CLIENT_GAME_DOMINION_WANTED_LIST
    {

    }

    [ProtoContract]
    public class GAME_CLIENT_DOMINION_WANTED_LIST_START
    {
    }

    [ProtoContract]
    public class GAME_CLIENT_DOMINION_WANTED_LIST
    {
        [ProtoMember(1)]

        public _dominion_wanted_info[] wanted_list { get; set; }

    }

    [ProtoContract]
    public class GAME_CLIENT_DOMINION_WANTED_LIST_END
    {
    }

    [ProtoContract]
    public class CLIENT_WORLD_DOMINION_WANTED_ADD
    {
        [ProtoMember(1)]

        public ulong target_user_uid { get; set; }
        [ProtoMember(2)]
        public uint dominion_pk_tid { get; set; }
        [ProtoMember(3)]
        public string target_user_name { get; set; }

    }

    [ProtoContract]
    public class WORLD_CLIENT_DOMINION_WANTED_ADD
    {
        [ProtoMember(1)]

        public int result { get; set; }
        [ProtoMember(2)]
        public ulong target_user_uid { get; set; }
        [ProtoMember(3)]
        public uint dominion_pk_tid { get; set; }
        [ProtoMember(4)]
        _dominion_wanted_info_server dominion_pk_info { get; set; }

    }

    [ProtoContract]
    public class WORLD_GAME_SYNC_DOMINION_WANTED_INFO
    {
        [ProtoMember(1)]

        public ulong target_user_uid { get; set; }
        [ProtoMember(2)]
        public uint dominion_pk_tid { get; set; }
        [ProtoMember(3)]
        public uint state_type { get; set; }
        [ProtoMember(4)]
        _dominion_wanted_info_server dominion_pk_info { get; set; }

    }

    [ProtoContract]
    public class GAME_WORLD_DOMINION_WANTED_PK
    {
        [ProtoMember(1)]

        public ulong attacker_user_uid { get; set; }
        [ProtoMember(2)]
        public ulong target_user_uid { get; set; }

    }

    [ProtoContract]
    public class CLIENT_WORLD_DOMINION_WANTED_CANCEL
    {
        [ProtoMember(1)]

        public ulong target_user_uid { get; set; }

    }

    [ProtoContract]
    public class WORLD_CLIENT_DOMINION_WANTED_CANCEL
    {
        [ProtoMember(1)]

        public int result { get; set; }
        [ProtoMember(2)]
        public ulong target_user_uid { get; set; }

    }

    [ProtoContract]
    public class CLIENT_WORLD_DOMINION_HISTORY_LIST
    {
        [ProtoMember(1)]

        public uint dominion_tid { get; set; }
        [ProtoMember(2)]
        public ulong end_history_uid { get; set; }

    }

    [ProtoContract]
    public class WORLD_CLIENT_DOMINION_HISTORY_LIST_START
    {
        [ProtoMember(1)]

        public uint dominion_tid { get; set; }
        [ProtoMember(2)]
        public ulong end_history_uid { get; set; }

    }

    [ProtoContract]
    public class WORLD_CLIENT_DOMINION_HISTORY_LIST
    {
        [ProtoMember(1)]

        public uint dominion_tid { get; set; }
        [ProtoMember(2)]
        public _dominion_history_info[] history_list { get; set; }
        [ProtoMember(3)]
        public ulong end_history_uid { get; set; }

    }

    [ProtoContract]
    public class WORLD_CLIENT_DOMINION_HISTORY_LIST_END
    {
        [ProtoMember(1)]

        public uint dominion_tid { get; set; }
        [ProtoMember(2)]
        public ulong end_history_uid { get; set; }

    }

    [ProtoContract]
    public class WORLD_GAME_SYNC_DOMINION_COST
    {
        [ProtoMember(1)]

        public int dominion_tid { get; set; }
        [ProtoMember(2)]
        public _cost_info[] guild_cost_info { get; set; }

    }

    [ProtoContract]
    public class WORLD_GAME_SYNC_DOMINION_COST_GIVE_COUNT
    {
        [ProtoMember(1)]

        public int dominion_tid { get; set; }
        [ProtoMember(2)]
        public _cost_info[] guild_cost_info { get; set; }

    }

    [ProtoContract]
    public class CLIENT_GAME_DOMINION_STORAGE_INFO
    {
        [ProtoMember(1)]

        public int dominion_tid { get; set; }

    }

    [ProtoContract]
    public class GAME_WORLD_DOMINION_STORAGE_INFO
    {
        [ProtoMember(1)]

        public int dominion_tid { get; set; }

    }

    [ProtoContract]
    public class WORLD_GAME_DOMINION_STORAGE_INFO
    {
        [ProtoMember(1)]

        public int result { get; set; }
        [ProtoMember(2)]
        public long user_uid { get; set; }
        [ProtoMember(3)]
        public int dominion_tid { get; set; }
        [ProtoMember(4)]
        public long tex_remain_time { get; set; }
        [ProtoMember(5)]
        public _cost_info[] storage_tax_income { get; set; }
        [ProtoMember(6)]
        public _cost_info[] storage_use_cost { get; set; }
        [ProtoMember(7)]
        public long black_iron_plunder_count { get; set; }
        [ProtoMember(8)]
        public long black_iron_plunder_repayment_count { get; set; }
        [ProtoMember(9)]
        public _sabuk_taxrate_info[] sabuk_taxrate_infos { get; set; }

    }

    [ProtoContract]
    public class GAME_CLIENT_DOMINION_STORAGE_INFO
    {
        [ProtoMember(1)]

        public int result { get; set; }
        [ProtoMember(2)]
        public int dominion_tid { get; set; }
        [ProtoMember(3)]
        public _cost_info[] storage_cost_info { get; set; }
        [ProtoMember(5)]
        public _cost_info[] storage_cost_info_max { get; set; }
        [ProtoMember(6)]
        public _cost_info[] storage_guild_give_cost_info { get; set; }
        [ProtoMember(7)]
        public long tex_remain_time { get; set; }
        [ProtoMember(8)]
        public _cost_info[] storage_tax_income { get; set; }
        [ProtoMember(9)]
        public int npc_shop_state { get; set; }
        [ProtoMember(10)]
        public long npc_shop_remain_close_time { get; set; }
        [ProtoMember(11)]
        public long npc_shop_income_gold { get; set; }
        [ProtoMember(13)]
        public long npc_shop_black_iron_remain_count { get; set; }
        [ProtoMember(14)]
        public _cost_info[] storage_use_cost { get; set; }
        [ProtoMember(15)]
        public long black_iron_plunder_count { get; set; }
        [ProtoMember(16)]
        public long black_iron_plunder_repayment_count { get; set; }
        [ProtoMember(17)]
        public _dark_altar_state[] dark_altar_state_list { get; set; }
        [ProtoMember(18)]
        public _sabuk_taxrate_info[] sabuk_taxrate_infos { get; set; }

    }

    [ProtoContract]
    public class CLIENT_GAME_DOMINION_STORAGE_HISTORY
    {
        [ProtoMember(1)]

        public int dominion_tid { get; set; }
        [ProtoMember(2)]
        public int history_group_id { get; set; }
        [ProtoMember(3)]
        public int history_sub_group_id { get; set; }
        [ProtoMember(4)]
        public long cur_page_first_history_uid { get; set; }
        [ProtoMember(5)]
        public long cur_page_last_history_uid { get; set; }
        [ProtoMember(6)]
        public int cur_page { get; set; }
        [ProtoMember(7)]
        public bool is_next_page { get; set; }

    }

    [ProtoContract]
    public class _dominion_storage_history_info
    {
        [ProtoMember(1)]

        public long history_uid { get; set; }
        [ProtoMember(2)]
        public int history_index { get; set; }
        [ProtoMember(3)]
        public long history_time { get; set; }
        [ProtoMember(4)]
        public ulong member_uid { get; set; }
        [ProtoMember(5)]
        public string member_name { get; set; }
        [ProtoMember(6)]
        public string member_profile { get; set; }
        [ProtoMember(7)]
        public _history_param param_list { get; set; }
        [ProtoMember(8)]
        public _reward_cost_info[] cost_info { get; set; }

    }

    [ProtoContract]
    public class GAME_CLIENT_DOMINION_STORAGE_HISTORY
    {
        [ProtoMember(1)]

        public int result { get; set; }
        [ProtoMember(2)]
        public int dominion_tid { get; set; }
        [ProtoMember(3)]
        public int history_group_id { get; set; }
        [ProtoMember(4)]
        public int history_sub_group_id { get; set; }
        [ProtoMember(5)]
        public int page { get; set; }
        [ProtoMember(6)]
        public _dominion_storage_history_info[] history_list { get; set; }

    }

    [ProtoContract]
    public class _dominion_storage_give_guild_info
    {
        [ProtoMember(1)]

        public ulong guild_uid { get; set; }
        [ProtoMember(2)]
        public string guild_name { get; set; }
        [ProtoMember(3)]
        public string guild_master_name { get; set; }
        [ProtoMember(4)]
        public long total_combat_point { get; set; }
        [ProtoMember(5)]
        public long remain_storage_cost_value { get; set; }

    }

    [ProtoContract]
    public class CLIENT_GAME_DOMINION_STORAGE_COST_GIVE_TO_GUILD_INFO
    {
        [ProtoMember(1)]

        public int dominion_tid { get; set; }
        [ProtoMember(2)]
        public ulong target_guild_uid { get; set; }
        [ProtoMember(3)]
        public int cost_type { get; set; }

    }

    [ProtoContract]
    public class GAME_CLIENT_DOMINION_STORAGE_COST_GIVE_TO_GUILD_INFO
    {
        [ProtoMember(1)]

        public int result { get; set; }
        [ProtoMember(2)]
        public int dominion_tid { get; set; }
        [ProtoMember(3)]
        _cost_info storage_cost_info { get; set; }
        [ProtoMember(5)]
        public long storage_cost_info_max { get; set; }
        [ProtoMember(6)]
        _dominion_storage_give_guild_info target_guild_info { get; set; }

    }

    [ProtoContract]
    public class CLIENT_GAME_DOMINION_STORAGE_COST_GIVE_TO_GUILD
    {
        [ProtoMember(1)]

        public int dominion_tid { get; set; }
        [ProtoMember(2)]
        public ulong target_guild_uid { get; set; }
        [ProtoMember(3)]
        _cost_info cost_info { get; set; }

    }

    [ProtoContract]
    public class GAME_WORLD_DOMINION_STORAGE_COST_GIVE_TO_GUILD
    {
        [ProtoMember(1)]

        public int dominion_tid { get; set; }
        [ProtoMember(2)]
        public ulong target_guild_uid { get; set; }
        [ProtoMember(3)]
        _cost_info cost_info { get; set; }

    }

    [ProtoContract]
    public class WORLD_GAME_DOMINION_STORAGE_COST_GIVE_TO_GUILD
    {
        [ProtoMember(1)]

        public int result { get; set; }
        [ProtoMember(2)]
        public ulong user_uid { get; set; }
        [ProtoMember(3)]
        public int dominion_tid { get; set; }
        [ProtoMember(4)]
        public ulong target_guild_uid { get; set; }
        [ProtoMember(5)]
        _cost_info remain_cost_info { get; set; }

    }

    [ProtoContract]
    public class GAME_CLIENT_DOMINION_STORAGE_COST_GIVE_TO_GUILD
    {
        [ProtoMember(1)]

        public int result { get; set; }
        [ProtoMember(2)]
        public int dominion_tid { get; set; }
        [ProtoMember(3)]
        public ulong target_guild_uid { get; set; }
        [ProtoMember(4)]
        public _cost_info remain_cost_info { get; set; }

    }

    [ProtoContract]
    public class CLIENT_GAME_DOMINION_STORAGE_COST_GIVE_TO_USER
    {
        [ProtoMember(1)]

        public int dominion_tid { get; set; }
        [ProtoMember(2)]
        public ulong[] target_user_uid_list { get; set; }
        [ProtoMember(3)]
        public _cost_info cost_info { get; set; }

    }

    [ProtoContract]
    public class GAME_WORLD_DOMINION_STORAGE_COST_GIVE_TO_USER
    {
        [ProtoMember(1)]

        public int dominion_tid { get; set; }
        [ProtoMember(2)]
        public ulong[] target_user_uid_list { get; set; }
        [ProtoMember(3)]
        public _cost_info cost_info { get; set; }

    }

    [ProtoContract]
    public class _dominion_cost_give_target_user_name
    {
        [ProtoMember(1)]

        public ulong user_uid { get; set; }
        [ProtoMember(2)]
        public string character_name { get; set; }
        [ProtoMember(3)]
        public _cost_info can_recv_limit { get; set; }

    }

    [ProtoContract]
    public class WORLD_GAME_DOMINION_STORAGE_COST_GIVE_TO_USER
    {
        [ProtoMember(1)]

        public int result { get; set; }
        [ProtoMember(2)]
        public ulong user_uid { get; set; }
        [ProtoMember(3)]
        public int dominion_tid { get; set; }
        [ProtoMember(4)]
        public _dominion_cost_give_target_user_name[] target_user_list { get; set; }
        [ProtoMember(5)]
        public _dominion_cost_give_target_user_name[] target_user_fail_list { get; set; }
        [ProtoMember(6)]
        public _cost_info remain_cost_info { get; set; }
        [ProtoMember(7)]
        public _character_guild_receive_cost_by_user_uid_server_sync[] receive_cost_sync_info { get; set; }

    }

    [ProtoContract]
    public class GAME_CLIENT_DOMINION_STORAGE_COST_GIVE_TO_USER
    {
        [ProtoMember(1)]

        public int result { get; set; }
        [ProtoMember(2)]
        public int dominion_tid { get; set; }
        [ProtoMember(3)]
        public _dominion_cost_give_target_user_name[] target_user_list { get; set; }
        [ProtoMember(4)]
        public _dominion_cost_give_target_user_name[] target_user_fail_list { get; set; }
        [ProtoMember(5)]
        public _cost_info remain_cost_info { get; set; }

    }

    [ProtoContract]
    public class CLIENT_GAME_DOMINION_STORAGE_COST_TAKE_OUT
    {
        [ProtoMember(1)]

        public int dominion_tid { get; set; }
        [ProtoMember(2)]
        public _cost_info cost_info { get; set; }

    }

    [ProtoContract]
    public class GAME_WORLD_DOMINION_STORAGE_COST_TAKE_OUT
    {
        [ProtoMember(1)]

        public int dominion_tid { get; set; }
        [ProtoMember(2)]
        public _cost_info cost_info { get; set; }

    }

    [ProtoContract]
    public class WORLD_GAME_DOMINION_STORAGE_COST_TAKE_OUT
    {
        [ProtoMember(1)]

        public int result { get; set; }
        [ProtoMember(2)]
        public ulong user_uid { get; set; }
        [ProtoMember(3)]
        public int dominion_tid { get; set; }
        [ProtoMember(4)]
        public _cost_info remain_cost_info { get; set; }

    }

    [ProtoContract]
    public class GAME_CLIENT_DOMINION_STORAGE_COST_TAKE_OUT
    {
        [ProtoMember(1)]

        public int result { get; set; }
        [ProtoMember(2)]
        public int dominion_tid { get; set; }
        [ProtoMember(3)]
        public _cost_info remain_cost_info { get; set; }

    }

    [ProtoContract]
    public class CLIENT_WORLD_DOMINION_GIVE_OFFICIAL_GRADE
    {
        [ProtoMember(1)]

        public int dominion_tid { get; set; }
        [ProtoMember(2)]
        public int official_tid { get; set; }
        [ProtoMember(3)]
        public ulong target_user_uid { get; set; }
        [ProtoMember(4)]
        public string target_user_name { get; set; }

    }

    [ProtoContract]
    public class WORLD_CLIENT_DOMINION_GIVE_OFFICIAL_GRADE
    {
        [ProtoMember(1)]

        public int dominion_tid { get; set; }
        [ProtoMember(2)]
        public int official_tid { get; set; }
        [ProtoMember(3)]
        public ulong target_user_uid { get; set; }
        [ProtoMember(4)]
        public int result { get; set; }

    }

    [ProtoContract]
    public class WORLD_GAME_DOMINION_GIVE_OFFICIAL_GRADE_TARGET_NOTIFY
    {
        [ProtoMember(1)]

        public int dominion_tid { get; set; }
        [ProtoMember(2)]
        public ulong target_user_uid { get; set; }
        [ProtoMember(3)]
        public int official_tid { get; set; }
        [ProtoMember(4)]
        public ulong before_official_user_uid { get; set; }
        [ProtoMember(5)]
        public ulong guild_uid { get; set; }
        [ProtoMember(6)]
        public bool is_sabuk_master { get; set; }
        [ProtoMember(7)]
        public bool is_sabuk_master_change { get; set; }

    }

    [ProtoContract]
    public class WORLD_CLIENT_DOMINION_GIVE_OFFICIAL_GRADE_TARGET_NOTIFY
    {
        [ProtoMember(1)]

        public int dominion_tid { get; set; }
        [ProtoMember(2)]
        public ulong target_user_uid { get; set; }
        [ProtoMember(3)]
        public int official_tid { get; set; }
        [ProtoMember(4)]
        public bool is_give { get; set; }
        [ProtoMember(5)]
        public bool is_sabuk_master { get; set; }
        [ProtoMember(6)]
        public bool is_sabuk_master_change { get; set; }

    }

    [ProtoContract]
    public class WORLD_CLIENT_DOMINION_CHANGE_OFFICIAL_GRADE_NOTIFY
    {
        [ProtoMember(1)]

        public int dominion_tid { get; set; }
        [ProtoMember(2)]
        public ulong character_uid { get; set; }
        [ProtoMember(3)]
        public string character_name { get; set; }
        [ProtoMember(4)]
        public string character_profile { get; set; }
        [ProtoMember(5)]
        public int official_tid { get; set; }
        [ProtoMember(6)]
        public bool is_new { get; set; }
        [ProtoMember(7)]
        public ulong guild_uid { get; set; }
        [ProtoMember(8)]
        public string guild_name { get; set; }
        [ProtoMember(9)]
        public bool is_sabuk_master { get; set; }
        [ProtoMember(10)]
        public bool is_sabuk_master_change { get; set; }

    }

    [ProtoContract]
    public class GAME_CLIENT_DOMINION_OFFICIAL_GRADE_FIELD_BROADCAST
    {
        [ProtoMember(1)]

        public int dominion_tid { get; set; }
        [ProtoMember(2)]
        public ulong character_uid { get; set; }
        [ProtoMember(3)]
        public int official_tid { get; set; }
        [ProtoMember(4)]
        public bool is_sabuk_master { get; set; }

    }

    [ProtoContract]
    public class WORLD_GAME_SYNC_DAILY_BLACK_IRON_INFO
    {
        [ProtoMember(1)]

        public ulong before_daily_black_iron { get; set; }
        [ProtoMember(2)]
        public ulong last_daily_black_iron_update_time { get; set; }

    }

    [ProtoContract]
    public class CLIENT_WORLD_GET_DOMINION_SABUK_TAXRATE_INFO
    {
    }

    [ProtoContract]
    public class WORLD_CLIENT_GET_DOMINION_SABUK_TAXRATE_INFO
    {
        [ProtoMember(1)]

        public _dominion_sabuk_taxrate_info[] dominion_sabuk_taxrate_info_list { get; set; }

    }

    [ProtoContract]
    public class CLIENT_WORLD_GET_DOMINION_SABUK_IMPERIAL_ORDER_INFO
    {
    }

    [ProtoContract]
    public class WORLD_CLIENT_GET_DOMINION_SABUK_IMPERIAL_ORDER_INFO
    {
        [ProtoMember(1)]

        public _dominion_sabuk_imperialorder_info[] dominion_sabuk_imperialorder_info_list { get; set; }

    }

    [ProtoContract]
    public class CLIENT_WORLD_GET_DOMINION_SABUK_GUILD_TITLE_INFO
    {
    }

    [ProtoContract]
    public class WORLD_CLIENT_GET_DOMINION_SABUK_GUILD_TITLE_INFO
    {
        [ProtoMember(1)]

        public _dominion_sabuk_guild_title_info[] dominion_sabuk_guild_title_info_list { get; set; }

    }

    [ProtoContract]
    public class CLIENT_WORLD_DOMINION_SABUK_TAXRATE_CHANGE
    {
        [ProtoMember(1)]

        public _dominion_sabuk_taxrate_info[] change_taxrate_info_list { get; set; }
        [ProtoMember(2)]
        public int money_type { get; set; }

    }

    [ProtoContract]
    public class WORLD_CLIENT_DOMINION_SABUK_TAXRATE_CHANGE
    {
        [ProtoMember(1)]

        public _dominion_sabuk_taxrate_info[] change_taxrate_info_list { get; set; }
        [ProtoMember(2)]
        public int result { get; set; }

    }

    [ProtoContract]
    public class RELAY_WORLD_DOMINION_SABUK_TAXRATE_CHANGE_NOTIFY
    {
        [ProtoMember(1)]

        public _dominion_sabuk_taxrate_info[] change_taxrate_info_list { get; set; }

    }

    [ProtoContract]
    public class CLIENT_WORLD_DOMINION_SABUK_IMPERIAL_ORDER_CHANGE
    {
        [ProtoMember(1)]

        public uint target_world_id { get; set; }
        [ProtoMember(2)]
        public uint dominion_buff_id { get; set; }
        [ProtoMember(3)]
        public bool is_give { get; set; }

    }

    [ProtoContract]
    public class WORLD_CLIENT_DOMINION_SABUK_IMPERIAL_ORDER_CHANGE
    {
        [ProtoMember(1)]

        public uint target_world_id { get; set; }
        [ProtoMember(2)]
        _dominion_sabuk_imperialorder_info dominion_sabuk_imperialorder_info { get; set; }
        [ProtoMember(3)]
        public int imperial_order_count { get; set; }
        [ProtoMember(4)]
        public bool is_give { get; set; }
        [ProtoMember(5)]
        public int result { get; set; }
        [ProtoMember(6)]
        public uint dominion_buff_id { get; set; }

    }

    [ProtoContract]
    public class RELAY_WORLD_DOMINION_SABUK_IMPERIAL_ORDER_CHANGE_NOTIFY
    {
        [ProtoMember(1)]

        public uint target_world_id { get; set; }
        [ProtoMember(2)]
        public int dominion_buff_id { get; set; }
        [ProtoMember(3)]
        public long dominion_buff_end_time { get; set; }
        [ProtoMember(4)]
        public bool is_give { get; set; }

    }

    [ProtoContract]
    public class CLIENT_WORLD_DOMINION_SABUK_GUILD_TITLE_CHANGE
    {
        [ProtoMember(1)]

        public int title_id { get; set; }
        [ProtoMember(2)]
        public uint world_id { get; set; }
        [ProtoMember(3)]
        public ulong title_guild_id { get; set; }

    }

    [ProtoContract]
    public class WORLD_CLIENT_DOMINION_SABUK_GUILD_TITLE_CHANGE
    {
        [ProtoMember(1)]

        _dominion_sabuk_guild_title_info dominion_sabuk_guild_title_info { get; set; }
        [ProtoMember(2)]
        public int reset_title_id { get; set; }
        [ProtoMember(3)]
        public int result { get; set; }

    }

    [ProtoContract]
    public class GAME_CLIENT_DOMINION_SABUK_GUILD_TITLE_CHANGE
    {
        [ProtoMember(1)]

        public int title_id { get; set; }
        [ProtoMember(2)]
        public bool is_give { get; set; }

    }

    [ProtoContract]
    public class RELAY_WORLD_DOMINION_SABUK_GUILD_TITLE_CHANGE_NOTIFY
    {
        [ProtoMember(1)]

        public int title_id { get; set; }
        [ProtoMember(2)]
        public uint world_id { get; set; }
        [ProtoMember(3)]
        public ulong title_guild_id { get; set; }
        [ProtoMember(4)]
        public bool is_give { get; set; }

    }

    [ProtoContract]
    public class WORLD_CLIENT_DOMINION_SABUK_GIVE_TITLE_NOTIFY
    {
        [ProtoMember(1)]

        public int title_tid { get; set; }
        [ProtoMember(2)]
        public ulong target_guild_uid { get; set; }
        [ProtoMember(3)]
        public string target_guild_name { get; set; }
        [ProtoMember(4)]
        public uint world_id { get; set; }

    }

    [ProtoContract]
    public class WORLD_GAME_SYNC_DOMINION_INFO_FOR_SABUK
    {
        [ProtoMember(1)]

        _dominion_info dominion_sabuk_info { get; set; }
        [ProtoMember(2)]
        public _dominion_sabuk_taxrate_info[] dominion_sabuk_taxrate_info_list { get; set; }
        [ProtoMember(3)]
        public _dominion_sabuk_imperialorder_info[] dominion_sabuk_imperialorder_list { get; set; }
        [ProtoMember(4)]
        public _dominion_sabuk_guild_title_info[] dominion_sabuk_guild_title_list { get; set; }
        [ProtoMember(5)]
        public bool is_new_dominion_guild { get; set; }
        [ProtoMember(6)]
        public ulong before_sabuk_guild_uid { get; set; }

    }

    [ProtoContract]
    public class WORLD_CLIENT_DOMINION_SABUK_IMPERIAL_ORDER_NOTIFY
    {
        [ProtoMember(1)]

        public int world_id { get; set; }
        [ProtoMember(2)]
        public int dominion_buff_id { get; set; }
        [ProtoMember(3)]
        public ulong sabuk_master_uid { get; set; }
        [ProtoMember(4)]
        public string sabuk_master_name { get; set; }
        [ProtoMember(5)]
        public bool is_give { get; set; }

    }

    [ProtoContract]
    public class RELAY_WORLD_DOMINION_SABUK_TAX_UPDATE_CHANGE
    {
        [ProtoMember(1)]

        public uint world_id { get; set; }
        [ProtoMember(2)]
        public int money_type { get; set; }
        [ProtoMember(3)]
        public long tax_value { get; set; }
        [ProtoMember(4)]
        public int active_log_type { get; set; }
        [ProtoMember(5)]
        public int tax_log_type { get; set; }

    }

    [ProtoContract]
    public class RELAY_WORLD_DOMINION_SABUK_TAX_UPDATE_CHANGE_NOITFY
    {
        [ProtoMember(1)]

        public uint world_id { get; set; }
        [ProtoMember(2)]
        public int money_type { get; set; }
        [ProtoMember(3)]
        public long tax_value { get; set; }
        [ProtoMember(4)]
        public int active_log_type { get; set; }
        [ProtoMember(5)]
        public int tax_log_type { get; set; }
        [ProtoMember(6)]
        public ulong current_value { get; set; }

    }

    [ProtoContract]
    public class CLIENT_WORLD_GET_DOMINION_INFO_BY_ID
    {
        [ProtoMember(1)]

        public int dominion_tid { get; set; }

    }

    [ProtoContract]
    public class WORLD_CLIENT_GET_DOMINION_INFO_BY_ID
    {
        [ProtoMember(1)]

        _dominion_info dominion_info { get; set; }
        [ProtoMember(2)]
        public ulong sabuk_occupy_expire_time { get; set; }

    }

    [ProtoContract]
    public class RELAY_WORLD_DOMINION_SABUK_HISTORY_NOTIFY
    {
        [ProtoMember(1)]

        _dominion_history_info new_history { get; set; }
        [ProtoMember(2)]
        public ulong del_log_uid { get; set; }

    }

    [ProtoContract]
    public class RELAY_WORLD_DOMINION_CHANGE_BICHEON_GUILD
    {
        [ProtoMember(1)]

        public int dominion_tid { get; set; }
        [ProtoMember(2)]
        public uint world_id { get; set; }
        [ProtoMember(3)]
        public ulong guild_uid { get; set; }

    }

    [ProtoContract]
    public class RELAY_WORLD_DOMINION_BICHEON_TAX_INTERVAL
    {
        [ProtoMember(1)]

        public uint world_id { get; set; }
        [ProtoMember(2)]
        public ulong gold_tax { get; set; }
        [ProtoMember(3)]
        public ulong black_iron_tax { get; set; }

    }

    [ProtoContract]
    public class RELAY_WORLD_DOMINION_BICHEON_TAX_INTERVAL_NOTIFY
    {
        [ProtoMember(1)]

        public _dominion_sabuk_bicheon_tax_interval bicheon_tax_interval_list { get; set; }

    }

    [ProtoContract]
    public class WORLD_COMMUNITY_CHANGE_SABUK_GUILD
    {
        [ProtoMember(1)]

        public uint world_id { get; set; }
        [ProtoMember(2)]
        public ulong guild_uid { get; set; }

    }

    [ProtoContract]
    public class RELAY_WORLD_DOMINION_PRIZE_NOTIFY
    {
        [ProtoMember(1)]

        public uint dominion_id { get; set; }
        [ProtoMember(2)]
        public int prize_grade { get; set; }
        [ProtoMember(3)]
        public int prize_count { get; set; }

    }

    [ProtoContract]
    public class _door_object_sync_info
    {
        [ProtoMember(1)]

        public int doorobject_id { get; set; }
        [ProtoMember(2)]
        public bool is_open { get; set; }

    }

    [ProtoContract]
    public class GAME_CLIENT_SYNC_DOOR_OBJECT_STATE_IN_ZONE
    {
        [ProtoMember(1)]

        public _door_object_sync_info doorobject_sync_info { get; set; }

    }

    [ProtoContract]
    public class GAME_CLIENT_CHANGE_DOOR_OBJECT_STATE
    {
        [ProtoMember(1)]

        _door_object_sync_info change_doorobject_info { get; set; }

    }


    [ProtoContract]
    public class CLIENT_GAME_DUEL_REQUEST
    {
        [ProtoMember(1)]

        public long target_uid { get; set; }

    }

    [ProtoContract]
    public class GAME_CLIENT_DUEL_REQUEST
    {
        [ProtoMember(1)]
        public int result { get; set; }
        [ProtoMember(2)]
        public long target_uid { get; set; }

    }

    [ProtoContract]
    public class GAME_CLIENT_DUEL_REQUEST_INFO
    {
        [ProtoMember(1)]

        public long request_uid { get; set; }
        [ProtoMember(2)]
        public long request_ms_time { get; set; }

    }

    [ProtoContract]
    public class CLIENT_GAME_DUEL_REQUEST_AGREE
    {
        [ProtoMember(1)]
        public long request_uid { get; set; }
        [ProtoMember(2)]
        public bool agree { get; set; }
    }

    [ProtoContract]
    public class GAME_CLIENT_DUEL_REQUEST_AGREE
    {
        [ProtoMember(1)]
        public int result { get; set; }
        [ProtoMember(2)]
        public bool agree { get; set; }

    }

    [ProtoContract]
    public class GAME_CLIENT_DUEL_START
    {
        [ProtoMember(1)]
        public long flag_obj_uid { get; set; }
        [ProtoMember(2)]
        public long target_uid { get; set; }
        [ProtoMember(3)]
        public long duel_ms_time { get; set; }

    }

    [ProtoContract]
    public class GAME_CLIENT_DUEL_END
    {
        [ProtoMember(1)]

        public long winner_uid { get; set; }
        [ProtoMember(2)]
        public long loser_uid { get; set; }

    }

    [ProtoContract]
    public class CLIENT_GAME_DUEL_GIVEUP
    {
    }

    [ProtoContract]
    public class GAME_CLIENT_DUEL_UPDATE
    {
        [ProtoMember(1)]

        public long flag_obj_uid { get; set; }
        [ProtoMember(2)]
        public long target_uid { get; set; }

    }

    [ProtoContract]
    public class GAME_CLIENT_DUEL_RINGOUT_TIME_START
    {
        [ProtoMember(1)]

        public long user_uid { get; set; }
        [ProtoMember(2)]
        public uint reason { get; set; }
        [ProtoMember(3)]
        public long duel_ms_time { get; set; }

    }

    [ProtoContract]
    public class GAME_CLIENT_DUEL_RINGOUT_TIME_END
    {
        [ProtoMember(1)]

        public long user_uid { get; set; }
        [ProtoMember(2)]
        public uint reason { get; set; }

    }


    [ProtoContract]
    public class CLIENT_GAME_DUNGEON_TICKET_INFO
    {
    }

    [ProtoContract]
    public class GAME_CLIENT_DUNGEON_TICKET_INFO
    {
        [ProtoMember(1)]

        public _dungeon_ticket_info dungeon_ticket_info_list { get; set; }
    }

    [ProtoContract]
    public class CLIENT_GAME_DUNGEON_TICKET_CHARGE
    {
        [ProtoMember(1)]

        public uint dungeon_ticket_type { get; set; }
        [ProtoMember(2)]
        public bool item_check { get; set; }

    }

    [ProtoContract]
    public class GAME_CLIENT_DUNGEON_TICKET_CHARGE
    {
        [ProtoMember(1)]

        public uint dungeon_ticket_type { get; set; }
        [ProtoMember(2)]
        _dungeon_ticket_info dungeon_ticket_info { get; set; }
        [ProtoMember(3)]
        public _cost_info[] cost_infos { get; set; }
        [ProtoMember(4)]
        public int result { get; set; }
        [ProtoMember(5)]
        public _stack_item_info[] del_item_list { get; set; }

    }

    [ProtoContract]
    public class GAME_CLIENT_DUNGEON_TICKET_CHANGE_NOTIFY
    {
        [ProtoMember(1)]

        _dungeon_ticket_info dungeon_ticket_info { get; set; }

    }


    [ProtoContract]
    public class GAME_CLIENT_CHAR_DURABILITY
    {
        [ProtoMember(1)]

        public int cur_durability { get; set; }
        [ProtoMember(2)]
        public int max_durability { get; set; }

    }

    [ProtoContract]
    public class ITEM_DURABILITY
    {
        [ProtoMember(1)]

        public ulong item_uid { get; set; }
        [ProtoMember(2)]
        public int item_durability { get; set; }

    }

    [ProtoContract]
    public class GAME_CLIENT_ITEM_DURABILITY
    {
        [ProtoMember(1)]

        ITEM_DURABILITY[] item_durability { get; set; }

    }

    [ProtoContract]
    public class CLIENT_GAME_ITEM_DURABILITY_REPAIR
    {
        [ProtoMember(1)]

        public ulong item_uid { get; set; }

    }

    [ProtoContract]
    public class GAME_CLIENT_ITEM_DURABILITY_REPAIR
    {
        [ProtoMember(1)]

        public int result { get; set; }
        [ProtoMember(2)]
        ITEM_DURABILITY item_durability { get; set; }
        [ProtoMember(3)]
        _cost_info[] repair_cost_list { get; set; }
        [ProtoMember(4)]
        _stack_item_info[] repair_item_list { get; set; }

    }

    [ProtoContract]
    public class CLIENT_GAME_SICKNESS_RECOVERY_SUPPORT_REGISTER
    {
    }

    [ProtoContract]
    public class GAME_CLIENT_SICKNESS_RECOVERY_SUPPORT_REGISTER
    {
        [ProtoMember(1)]

        public int result { get; set; }

    }

    [ProtoContract]
    public class GAME_WORLD_SICKNESS_RECOVERY_SUPPORT_REGISTER
    {
        [ProtoMember(1)]

        public int max_support_count { get; set; }
        [ProtoMember(2)]
        public int buff_id { get; set; }
        [ProtoMember(3)]
        public long spend_buff_time { get; set; }
        [ProtoMember(4)]
        public int slot { get; set; }
        [ProtoMember(5)]
        public uint start_world_id { get; set; }

    }

    [ProtoContract]
    public class WORLD_GAME_SICKNESS_RECOVERY_SUPPORT_REGISTER
    {
        [ProtoMember(1)]

        public int result { get; set; }
        [ProtoMember(2)]
        public ulong user_uid { get; set; }

    }

    [ProtoContract]
    public class GAME_WORLD_SICKNESS_RECOVERY_SUPPORT_DELETE
    {
        [ProtoMember(1)]

        public int buff_id { get; set; }
        [ProtoMember(2)]
        public uint start_world_id { get; set; }

    }

    [ProtoContract]
    public class WORLD_GAME_SICKNESS_RECOVERY_SUPPORT_DELETE
    {
        [ProtoMember(1)]

        public int result { get; set; }
        [ProtoMember(2)]
        public ulong user_uid { get; set; }

    }

    [ProtoContract]
    public class CLIENT_GAME_IMMEDIATELY_SICKNESS_RECOVERY
    {
        [ProtoMember(1)]
        public bool recovery_type { get; set; }
    }

    [ProtoContract]
    public class GAME_CLIENT_IMMEDIATELY_SICKNESS_RECOVERY
    {
        [ProtoMember(1)]

        public int result { get; set; }
        [ProtoMember(2)]
        _cost_info[] recovery_cost_list { get; set; }
        [ProtoMember(3)]
        _stack_item_info[] recovery_item_list { get; set; }

    }

    [ProtoContract]
    public class SICKNESS_GUILD_SUPPORT_INFO
    {
        [ProtoMember(1)]

        public long guild_support_time { get; set; }
        [ProtoMember(2)]
        public bool guild_support { get; set; }
        [ProtoMember(3)]
        public int received_guild_support_count { get; set; }
        [ProtoMember(4)]
        public int receiveable_guild_support_count { get; set; }

    }

    [ProtoContract]
    public class CLIENT_GAME_SICKNESS_RECOVERY_INFO
    {
    }

    [ProtoContract]
    public class GAME_WORLD_SICKNESS_RECOVERY_INFO
    {
        [ProtoMember(1)]

        public ulong user_uid { get; set; }
    }

    [ProtoContract]
    public class GAME_CLIENT_SICKNESS_RECOVERY_REFRESH
    {
        [ProtoMember(1)]

        public uint buff_id { get; set; }
        [ProtoMember(2)]
        public long left_buff_time { get; set; }
        [ProtoMember(3)]
        SICKNESS_GUILD_SUPPORT_INFO sickness_guild_support_info { get; set; }
        [ProtoMember(4)]
        public uint reason { get; set; }
        [ProtoMember(5)]
        public long support_user_uid { get; set; }
    }

    [ProtoContract]
    public class WORLD_GAME_SICKNESS_RECOVERY_REFRESH
    {
        [ProtoMember(1)]

        public ulong user_uid { get; set; }
        [ProtoMember(2)]
        SICKNESS_GUILD_SUPPORT_INFO sickness_guild_support_info { get; set; }
        [ProtoMember(3)]
        public uint reason { get; set; }
        [ProtoMember(4)]
        public long support_user_uid { get; set; }
    }


    [ProtoContract]
    public class CLIENT_GAME_EQUIP_ITEM
    {
        [ProtoMember(1)]

        public ulong UID { get; set; }
        [ProtoMember(2)]
        public int position { get; set; }
        [ProtoMember(3)]
        public ulong ItemUID { get; set; }
    }

    [ProtoContract]
    public class GAME_CLIENT_EQUIP_ITEM
    {
        [ProtoMember(1)]

        public int result { get; set; }
        [ProtoMember(2)]
        public int position { get; set; }
        [ProtoMember(3)]
        public ulong equipItemUID { get; set; }
        [ProtoMember(4)]
        public ulong unequipItemUID { get; set; }
    }

    [ProtoContract]
    public class CLIENT_GAME_UNEQUIP_ITEM
    {
        [ProtoMember(1)]

        public int equip_slot { get; set; }
    }

    [ProtoContract]
    public class GAME_CLIENT_UNEQUIP_ITEM
    {
        [ProtoMember(1)]

        public int result { get; set; }
        [ProtoMember(2)]
        public int equip_slot { get; set; }
        [ProtoMember(3)]
        public ulong unequip_item_uid { get; set; }
    }

    [ProtoContract]
    public class CLIENT_GAME_EQUIP_MAGIC_STONE
    {
        [ProtoMember(1)]

        public int equip_slot { get; set; }
        [ProtoMember(2)]
        public ulong equip_item_uid { get; set; }
    }

    [ProtoContract]
    public class GAME_CLIENT_EQUIP_MAGIC_STONE
    {
        [ProtoMember(1)]

        public int result { get; set; }
        [ProtoMember(2)]
        public int equip_slot { get; set; }
        [ProtoMember(3)]
        public ulong equip_item_uid { get; set; }
        [ProtoMember(4)]
        public ulong unequip_item_uid { get; set; }

    }

    [ProtoContract]
    public class CLIENT_GAME_UNEQUIP_MAGIC_STONE
    {
        [ProtoMember(1)]

        public int equip_slot { get; set; }
    }

    [ProtoContract]
    public class GAME_CLIENT_UNEQUIP_MAGIC_STONE
    {
        [ProtoMember(1)]

        public int result { get; set; }
        [ProtoMember(2)]
        public int equip_slot { get; set; }
        [ProtoMember(3)]
        public ulong unequip_item_uid { get; set; }
    }

    [ProtoContract]
    public class MAGIC_STONE_SLOT_INFO
    {
        [ProtoMember(1)]

        public int equip_slot { get; set; }
        [ProtoMember(2)]
        public ulong equip_item_uid { get; set; }
    }

    [ProtoContract]
    public class MAGIC_STONE_DECK_INFO
    {
        [ProtoMember(1)]

        public int deck_index { get; set; }
        [ProtoMember(2)]
        public MAGIC_STONE_SLOT_INFO slot_info { get; set; }
    }

    [ProtoContract]
    public class CLIENT_GAME_MAGIC_STONE_DECK_LIST
    {
    }

    [ProtoContract]
    public class GAME_CLIENT_MAGIC_STONE_DECK_LIST
    {
        [ProtoMember(1)]

        public int active_deck_index { get; set; }
        [ProtoMember(2)]
        public MAGIC_STONE_DECK_INFO deck_info { get; set; }

    }

    [ProtoContract]
    public class CLIENT_GAME_MAGIC_STONE_DECK_SET
    {
        [ProtoMember(1)]

        public int deck_index { get; set; }
        [ProtoMember(2)]
        public int equip_slot { get; set; }
        [ProtoMember(3)]
        public ulong equip_item_uid { get; set; }

    }

    [ProtoContract]
    public class GAME_CLIENT_MAGIC_STONE_DECK_SET
    {
        [ProtoMember(1)]

        public int result { get; set; }
        [ProtoMember(2)]
        public int deck_index { get; set; }
        [ProtoMember(3)]
        public int equip_slot { get; set; }
        [ProtoMember(4)]
        public ulong equip_item_uid { get; set; }
        [ProtoMember(5)]
        public ulong unequip_item_uid { get; set; }

    }

    [ProtoContract]
    public class CLIENT_GAME_MAGIC_STONE_DECK_DEL
    {
        [ProtoMember(1)]

        public int deck_index { get; set; }
        [ProtoMember(2)]
        public int unequip_slot { get; set; }
        [ProtoMember(3)]
        public ulong unequip_item_uid { get; set; }

    }

    [ProtoContract]
    public class GAME_CLIENT_MAGIC_STONE_DECK_DEL
    {
        [ProtoMember(1)]

        public int result { get; set; }
        [ProtoMember(2)]
        public int deck_index { get; set; }
        [ProtoMember(3)]
        public int unequip_slot { get; set; }
        [ProtoMember(4)]
        public ulong unequip_item_uid { get; set; }

    }

    [ProtoContract]
    public class CLIENT_GAME_MAGIC_STONE_DECK_ENABLE
    {
        [ProtoMember(1)]

        public int deck_index { get; set; }

    }

    [ProtoContract]
    public class GAME_CLIENT_MAGIC_STONE_DECK_ENABLE
    {
        [ProtoMember(1)]

        public int result { get; set; }
        [ProtoMember(2)]
        public int deck_index { get; set; }

    }

    [ProtoContract]
    public class _mystical_piece_slot_info
    {
        [ProtoMember(1)]

        public int equip_slot { get; set; }
        [ProtoMember(2)]
        public ulong equip_item_uid { get; set; }

    }

    [ProtoContract]
    public class _mystical_piece_deck_info
    {
        [ProtoMember(1)]

        public int deck_index { get; set; }
        [ProtoMember(2)]
        public _mystical_piece_slot_info slot_info { get; set; }

    }

    [ProtoContract]
    public class CLIENT_GAME_MYSTICAL_PIECE_DECK_LIST
    {
    }

    [ProtoContract]
    public class GAME_CLIENT_MYSTICAL_PIECE_DECK_LIST
    {
        [ProtoMember(1)]

        public int active_deck_index { get; set; }
        [ProtoMember(2)]
        public _mystical_piece_deck_info deck_info { get; set; }

    }

    [ProtoContract]
    public class CLIENT_GAME_MYSTICAL_PIECE_DECK_SET
    {
        [ProtoMember(1)]

        public int deck_index { get; set; }
        [ProtoMember(2)]
        public int equip_slot { get; set; }
        [ProtoMember(3)]
        public ulong equip_item_uid { get; set; }

    }

    [ProtoContract]
    public class GAME_CLIENT_MYSTICAL_PIECE_DECK_SET
    {
        [ProtoMember(1)]

        public int result { get; set; }
        [ProtoMember(2)]
        public int deck_index { get; set; }
        [ProtoMember(3)]
        public int equip_slot { get; set; }
        [ProtoMember(4)]
        public ulong equip_item_uid { get; set; }
        [ProtoMember(5)]
        public ulong unequip_item_uid { get; set; }

    }

    [ProtoContract]
    public class CLIENT_GAME_MYSTICAL_PIECE_DECK_DEL
    {
        [ProtoMember(1)]

        public int deck_index { get; set; }
        [ProtoMember(2)]
        public int unequip_slot { get; set; }
        [ProtoMember(3)]
        public ulong unequip_item_uid { get; set; }

    }

    [ProtoContract]
    public class GAME_CLIENT_MYSTICAL_PIECE_DECK_DEL
    {
        [ProtoMember(1)]

        public int result { get; set; }
        [ProtoMember(2)]
        public int deck_index { get; set; }
        [ProtoMember(3)]
        public int unequip_slot { get; set; }
        [ProtoMember(4)]
        public ulong unequip_item_uid { get; set; }

    }

    [ProtoContract]
    public class CLIENT_GAME_MYSTICAL_PIECE_DECK_ENABLE
    {
        [ProtoMember(1)]

        public int deck_index { get; set; }

    }

    [ProtoContract]
    public class GAME_CLIENT_MYSTICAL_PIECE_DECK_ENABLE
    {
        [ProtoMember(1)]

        public int result { get; set; }
        [ProtoMember(2)]
        public int deck_index { get; set; }

    }


    [ProtoContract]
    public class GAME_CLIENT_ERROR
    {
        [ProtoMember(1)]

        public int error { get; set; }

    }

    [ProtoContract]
    public class GAME_CLIENT_SYSTEM_ERROR
    {
        [ProtoMember(1)]

        public int error_type { get; set; }
        [ProtoMember(2)]
        public int error_code { get; set; }
        [ProtoMember(3)]
        public string error_msg { get; set; }
}

[ProtoContract]
public class _fake_reward_info
{
    [ProtoMember(1)]

    public int id { get; set; }
    [ProtoMember(2)]
    public int count { get; set; }

}

[ProtoContract]
public class CLIENT_GAME_FAKE_REWARD
{
    [ProtoMember(1)]

    public uint id { get; set; }

}

[ProtoContract]
public class GAME_CLIENT_FAKE_REWARD
{
    [ProtoMember(1)]

    public _fake_reward_info fake_info { get; set; }

}

[ProtoContract]
public class SERVER_GATEWAY_ERROR
{
    [ProtoMember(1)]

    public ulong account_uid { get; set; }
    [ProtoMember(2)]
    public ulong char_uid { get; set; }
    [ProtoMember(3)]
    public int error_id { get; set; }
    [ProtoMember(4)]
    public bool is_disconnect_user { get; set; }

}

[ProtoContract]
public class SERVER_GATEWAY_USER_KICK
{
    [ProtoMember(1)]

    public ulong account_uid { get; set; }

}

[ProtoContract]
public class GAME_CLIENT_SYSTEM_MESSAGE
{
    [ProtoMember(1)]

    public int title_sting_id { get; set; }
    [ProtoMember(2)]
    public int message_string_id { get; set; }
    [ProtoMember(3)]
    public string[] message_arg { get; set; }

}

[ProtoContract]
public class LOG_SERVER_MESSAGE
{
    [ProtoMember(1)]

    public uint ServerType { get; set; }
    [ProtoMember(2)]
    public uint ServerIndex { get; set; }
    [ProtoMember(3)]
    public uint WorldUID { get; set; }

}

[ProtoContract]
public class LOG_USER_INFO
{
    [ProtoMember(1)]

    public ulong AccountUID { get; set; }
    [ProtoMember(2)]
    public ulong CharacterUID { get; set; }
    [ProtoMember(3)]
    public string CharacterName { get; set; }
    [ProtoMember(4)]
    public uint CharacterClass { get; set; }
    [ProtoMember(5)]
    public uint Lev { get; set; }

}

[ProtoContract]
public class LOG_ACCOUNTUID
{
    [ProtoMember(1)]

    public ulong AccountUID { get; set; }

}

[ProtoContract]
public class LOG_ACCOUNTNAME
{
    [ProtoMember(1)]

    public string AccountName { get; set; }

}

[ProtoContract]
public class LOG_CHARACTERUID
{
    [ProtoMember(1)]

    public ulong CharacterUID { get; set; }

}

[ProtoContract]
public class LOG_DEVICEID
{
    [ProtoMember(1)]

    public string DeviceID { get; set; }

}

[ProtoContract]
public class LOG_WORLDNAME
{
    [ProtoMember(1)]

    public string WorldName { get; set; }

}

[ProtoContract]
public class LOG_DOMINIONID
{
    [ProtoMember(1)]

    public int DominionID { get; set; }

}

[ProtoContract]
public class LOG_DOMINION_BUFF_ID
{
    [ProtoMember(1)]

    public int Dominion_Buff_ID { get; set; }

}

[ProtoContract]
public class LOG_CONCURRENTUSERS
{
    [ProtoMember(1)]
    public uint ConcurrentUsers { get; set; }

}

[ProtoContract]
public class LOG_WAITTINGUSERS
{
    [ProtoMember(1)]

    public uint WaittingUsers { get; set; }

}

[ProtoContract]
public class LOG_SERVERTYPE
{
    [ProtoMember(1)]

    public uint ServerType { get; set; }

}

[ProtoContract]
public class LOG_OSTYPE
{
    [ProtoMember(1)]

    public uint OSType { get; set; }

}

[ProtoContract]
public class LOG_IPADDRESS
{
    [ProtoMember(1)]

    public string IpAddress { get; set; }

}

[ProtoContract]
public class LOG_CHARACTERNAME
{
    [ProtoMember(1)]

    public string CharacterName { get; set; }

}

[ProtoContract]
public class LOG_CHARACTERCLASS
{
    [ProtoMember(1)]

    public uint CharacterClass { get; set; }

}

[ProtoContract]
public class LOG_LEV
{
    [ProtoMember(1)]

    public uint Lev { get; set; }

}

[ProtoContract]
public class LOG_COMBATPOINT
{
    [ProtoMember(1)]

    public uint CombatPoint { get; set; }

}

[ProtoContract]
public class LOG_STAGEIDX
{
    [ProtoMember(1)]

    public uint StageIdx { get; set; }

}

[ProtoContract]
public class LOG_GOODSIDX
{
    [ProtoMember(1)]

    public uint GoodsIdx { get; set; }

}

[ProtoContract]
public class LOG_LOCX
{
    [ProtoMember(1)]

    public float LocX { get; set; }

}

[ProtoContract]
public class LOG_LOCY
{
    [ProtoMember(1)]

    public float LocY { get; set; }

}

[ProtoContract]
public class LOG_LOCZ
{
    [ProtoMember(1)]

    public float LocZ { get; set; }

}

[ProtoContract]
public class LOG_CHAR_VAL_ID
{
    [ProtoMember(1)]

    public ulong Char_Val_id { get; set; }

}

[ProtoContract]
public class LOG_CHAR_VAL_APPLY
{
    [ProtoMember(1)]

    public long Char_Val_apply { get; set; }

}

[ProtoContract]
public class LOG_CHAR_VAL_TOTAL
{
    [ProtoMember(1)]

    public long Char_Val_total { get; set; }

}

[ProtoContract]
public class LOG_ADJUSTMENT
{
    [ProtoMember(1)]

    public long Adjustment { get; set; }

}

[ProtoContract]
public class LOG_TOTALVALUE
{
    [ProtoMember(1)]

    public ulong TotalValue { get; set; }

}

[ProtoContract]
public class LOG_ADJUSTMENTEXP
{
    [ProtoMember(1)]

    public long AdjustmentExp { get; set; }

}

[ProtoContract]
public class LOG_TOTALEXP
{
    [ProtoMember(1)]

    public long TotalExp { get; set; }

}

[ProtoContract]
public class LOG_ACTIVESKILLIDX
{
    [ProtoMember(1)]

    public uint ActiveSkillIdx { get; set; }

}

[ProtoContract]
public class LOG_GUILDUID
{
    [ProtoMember(1)]

    public ulong GuildUID { get; set; }

}

[ProtoContract]
public class LOG_GUILDNAME
{
    [ProtoMember(1)]

    public string GuildName { get; set; }

}

[ProtoContract]
public class LOG_GUILD_COMBATPOINT
{
    [ProtoMember(1)]

    public long Guild_CombatPoint { get; set; }

}

[ProtoContract]
public class LOG_GUILDLEV
{
    [ProtoMember(1)]

    public uint GuildLev { get; set; }

}

[ProtoContract]
public class LOG_ISCHANGEDSYMBOL
{
    [ProtoMember(1)]

    public bool IsChangedSymbol { get; set; }

}

[ProtoContract]
public class LOG_GUILDMASTERUID
{
    [ProtoMember(1)]

    public ulong GuildMasterUID { get; set; }

}

[ProtoContract]
public class LOG_GUILDMEMBERGRADE
{
    [ProtoMember(1)]

    public uint GuildMemberGrade { get; set; }

}

[ProtoContract]
public class LOG_GUILDMASTERNAME
{
    [ProtoMember(1)]

    public string GuildMasterName { get; set; }

}

[ProtoContract]
public class LOG_PREGUILDNAME
{
    [ProtoMember(1)]

    public string PreGuildName { get; set; }

}

[ProtoContract]
public class LOG_DEVELOPIDX
{
    [ProtoMember(1)]

    public int DevelopIdx { get; set; }

}

[ProtoContract]
public class LOG_DEVELOPLEV
{
    [ProtoMember(1)]

    public uint DevelopLev { get; set; }

}

[ProtoContract]
public class LOG_IS_LEVEL_DOWN
{
    [ProtoMember(1)]

    public bool IsLevelDown { get; set; }

}

[ProtoContract]
public class LOG_MONEYIDX
{
    [ProtoMember(1)]

    public uint MoneyIdx { get; set; }

}

[ProtoContract]
public class LOG_EVENTTYPE
{
    [ProtoMember(1)]

    public uint EventType { get; set; }

}

[ProtoContract]
public class LOG_ITEMIDX
{
    [ProtoMember(1)]

    public uint ItemIdx { get; set; }

}

[ProtoContract]
public class LOG_ITEMUID
{
    [ProtoMember(1)]

    public ulong ItemUID { get; set; }

}

[ProtoContract]
public class LOG_ITEM_MAIN
{
    [ProtoMember(1)]

    public uint Item_Main { get; set; }

}

[ProtoContract]
public class LOG_ITEM_SUB
{
    [ProtoMember(1)]

    public uint Item_Sub { get; set; }

}

[ProtoContract]
public class LOG_ITEM_GRADE
{
    [ProtoMember(1)]

    public uint Item_Grade { get; set; }

}

[ProtoContract]
public class LOG_ITEM_NUM
{
    [ProtoMember(1)]

    public int Item_Num { get; set; }

}

[ProtoContract]
public class LOG_ITEM_SMELTING_LV
{
    [ProtoMember(1)]

    public uint Item_Smelting_lv { get; set; }

}

[ProtoContract]
public class LOG_ITEM_REINFORCE_LV
{
    [ProtoMember(1)]

    public uint Item_Reinforce_lv { get; set; }

}

[ProtoContract]
public class LOG_ITEM_REINFORCE_EXP
{
    [ProtoMember(1)]

    public uint Item_Reinforce_exp { get; set; }

}

[ProtoContract]
public class LOG_INVENUSE
{
    [ProtoMember(1)]

    public uint InvenUse { get; set; }

}

[ProtoContract]
public class LOG_INVENTOTAL
{
    [ProtoMember(1)]

    public uint InvenTotal { get; set; }

}

[ProtoContract]
public class LOG_TARGET_ITEMIDX
{
    [ProtoMember(1)]

    public uint Target_ItemIdx { get; set; }

}

[ProtoContract]
public class LOG_TARGET_ITEMUID
{
    [ProtoMember(1)]

    public ulong Target_ItemUID { get; set; }

}

[ProtoContract]
public class LOG_INITEMIDX
{
    [ProtoMember(1)]

    public uint InItemIdx { get; set; }

}

[ProtoContract]
public class LOG_INITEMUID
{
    [ProtoMember(1)]

    public ulong InItemUID { get; set; }

}

[ProtoContract]
public class LOG_INITEM_MAIN
{
    [ProtoMember(1)]

    public uint InItem_Main { get; set; }

}

[ProtoContract]
public class LOG_INITEM_SUB
{
    [ProtoMember(1)]

    public uint InItem_Sub { get; set; }

}

[ProtoContract]
public class LOG_INITEM_GRADE
{
    [ProtoMember(1)]

    public uint InItem_Grade { get; set; }

}

[ProtoContract]
public class LOG_INITEM_NUM
{
    [ProtoMember(1)]

    public int InItem_Num { get; set; }

}

[ProtoContract]
public class LOG_INITEM_SMELTING_LV
{
    [ProtoMember(1)]

    public uint InItem_Smelting_lv { get; set; }

}

[ProtoContract]
public class LOG_INITEM_REINFORCE_LV
{
    [ProtoMember(1)]

    public uint InItem_Reinforce_lv { get; set; }

}

[ProtoContract]
public class LOG_INITEM_REINFORCE_EXP
{
    [ProtoMember(1)]

    public uint InItem_Reinforce_exp { get; set; }

}

[ProtoContract]
public class LOG_CURRENCY_TYPE
{
    [ProtoMember(1)]

    public uint Currency_type { get; set; }

}

[ProtoContract]
public class LOG_CURRENCY_VAL
{
    [ProtoMember(1)]

    public long Currency_val { get; set; }

}

[ProtoContract]
public class LOG_SRC_SMELTING_LV
{
    [ProtoMember(1)]

    public uint src_smelting_lv { get; set; }

}

[ProtoContract]
public class LOG_SRC_REINFORCE_LV
{
    [ProtoMember(1)]

    public uint src_reinforce_lv { get; set; }

}

[ProtoContract]
public class LOG_OPTION_TYPE
{
    [ProtoMember(1)]

    public uint Option_type { get; set; }

}

[ProtoContract]
public class LOG_OPTION_VAL
{
    [ProtoMember(1)]

    public int Option_val { get; set; }

}

[ProtoContract]
public class LOG_SLOTIDX
{
    [ProtoMember(1)]

    public int SlotIdx { get; set; }

}

[ProtoContract]
public class LOG_BEFORELEV
{
    [ProtoMember(1)]

    public uint beforeLev { get; set; }

}

[ProtoContract]
public class LOG_APPLYLEV
{
    [ProtoMember(1)]

    public uint applyLev { get; set; }

}

[ProtoContract]
public class LOG_AFTERLEV
{
    [ProtoMember(1)]

    public uint afterLev { get; set; }

}

[ProtoContract]
public class LOG_TARGET_ACCOUNTUID
{
    [ProtoMember(1)]

    public ulong Target_AccountUID { get; set; }

}

[ProtoContract]
public class LOG_TARGET_DEVICEID
{
    [ProtoMember(1)]

    public string Target_DeviceID { get; set; }

}

[ProtoContract]
public class LOG_TARGETUID
{
    [ProtoMember(1)]

    public ulong TargetUID { get; set; }

}

[ProtoContract]
public class LOG_TARGETNAME
{
    [ProtoMember(1)]

    public string TargetName { get; set; }

}

[ProtoContract]
public class LOG_TARGET_CHAR_JOB
{
    [ProtoMember(1)]

    public uint Target_Char_Job { get; set; }

}

[ProtoContract]
public class LOG_TARGET_CHAR_LV
{
    [ProtoMember(1)]

    public uint Target_Char_Lv { get; set; }

}

[ProtoContract]
public class LOG_TARGET_CHAR_BATTLE_POWER
{
    [ProtoMember(1)]

    public uint Target_Char_battle_power { get; set; }

}

[ProtoContract]
public class LOG_TARGET_CHAR_EXP
{
    [ProtoMember(1)]

    public uint Target_Char_exp { get; set; }

}

[ProtoContract]
public class LOG_PREV_SYMBOL
{
    [ProtoMember(1)]

    public uint prev_symbol { get; set; }

}

[ProtoContract]
public class LOG_AFTER_SYMBOL
{
    [ProtoMember(1)]

    public uint after_symbol { get; set; }

}

[ProtoContract]
public class LOG_PREV_BACKGROUND
{
    [ProtoMember(1)]

    public uint prev_background { get; set; }

}

[ProtoContract]
public class LOG_AFTER_BACKGROUND
{
    [ProtoMember(1)]

    public uint after_background { get; set; }

}

[ProtoContract]
public class LOG_TARGETGUILD_UID
{
    [ProtoMember(1)]

    public ulong TargetGuild_uid { get; set; }

}

[ProtoContract]
public class LOG_TARGETGUILD_NAME
{
    [ProtoMember(1)]

    public string TargetGuild_name { get; set; }

}

[ProtoContract]
public class LOG_TARGETGUILD_LV
{
    [ProtoMember(1)]

    public uint TargetGuild_lv { get; set; }

}

[ProtoContract]
public class LOG_TARGETGUILD_SYMBOL
{
    [ProtoMember(1)]

    public uint TargetGuild_symbol { get; set; }

}

[ProtoContract]
public class LOG_TARGETGUILD_MASTER_ID
{
    [ProtoMember(1)]

    public ulong TargetGuild_master_id { get; set; }

}

[ProtoContract]
public class LOG_TARGETGUILD_MASTER_NAME
{
    [ProtoMember(1)]

    public string TargetGuild_master_name { get; set; }

}

[ProtoContract]
public class LOG_TARGETGUILD_COMBATPOINT
{
    [ProtoMember(1)]

    public long TargetGuild_CombatPoint { get; set; }

}

[ProtoContract]
public class LOG_TARGETMEMBERGRADE
{
    [ProtoMember(1)]

    public uint TargetMemberGrade { get; set; }

}

[ProtoContract]
public class LOG_PARTYUID
{
    [ProtoMember(1)]

    public ulong PartyUID { get; set; }

}

[ProtoContract]
public class LOG_PARTYTYPE
{
    [ProtoMember(1)]

    public uint PartyType { get; set; }

}

[ProtoContract]
public class LOG_LEADERID
{
    [ProtoMember(1)]

    public ulong LeaderID { get; set; }

}

[ProtoContract]
public class LOG_LEADERNAME
{
    [ProtoMember(1)]

    public string LeaderName { get; set; }

}

[ProtoContract]
public class LOG_TICKET_VAL_ID
{
    [ProtoMember(1)]

    public uint Ticket_Val_id { get; set; }

}

[ProtoContract]
public class LOG_TICKET_VAL_APPLY
{
    [ProtoMember(1)]

    public uint Ticket_Val_apply { get; set; }

}

[ProtoContract]
public class LOG_TICKET_VAL_TOTAL
{
    [ProtoMember(1)]

    public uint Ticket_Val_total { get; set; }

}

[ProtoContract]
public class LOG_BATTLE_POWER
{
    [ProtoMember(1)]

    public uint battle_power { get; set; }

}

[ProtoContract]
public class LOG_PLAYTIME
{
    [ProtoMember(1)]

    public uint playTime { get; set; }

}

[ProtoContract]
public class LOG_MONSTERIDX
{
    [ProtoMember(1)]

    public uint MonsterIdx { get; set; }

}

[ProtoContract]
public class LOG_MONSTER_GRADE
{
    [ProtoMember(1)]

    public uint Monster_grade { get; set; }

}

[ProtoContract]
public class LOG_QUESTIDX
{
    [ProtoMember(1)]

    public uint QuestIdx { get; set; }

}

[ProtoContract]
public class LOG_QUESTTYPE
{
    [ProtoMember(1)]

    public uint QuestType { get; set; }

}

[ProtoContract]
public class LOG_QUEST_VALUE
{
    [ProtoMember(1)]

    public uint Quest_value { get; set; }

}

[ProtoContract]
public class LOG_QUESTCOMPLETE
{
    [ProtoMember(1)]

    public uint QuestComplete { get; set; }

}

[ProtoContract]
public class LOG_QUESTTOTAL
{
    [ProtoMember(1)]

    public uint QuestTotal { get; set; }

}

[ProtoContract]
public class LOG_BATTLEPASSMISSIONIDX
{
    [ProtoMember(1)]

    public uint BattlePassMissionIdx { get; set; }

}

[ProtoContract]
public class LOG_BATTLEPASSGRADE
{
    [ProtoMember(1)]

    public uint BattlePassGrade { get; set; }

}

[ProtoContract]
public class LOG_TREASURE_UID
{
    [ProtoMember(1)]

    public ulong Treasure_uid { get; set; }

}

[ProtoContract]
public class LOG_TREASURE_ID
{
    [ProtoMember(1)]

    public uint Treasure_id { get; set; }

}

[ProtoContract]
public class LOG_TREASURE_APPLY
{
    [ProtoMember(1)]

    public uint Treasure_apply { get; set; }

}

[ProtoContract]
public class LOG_TREASURE_TOTAL
{
    [ProtoMember(1)]

    public uint Treasure_total { get; set; }

}

[ProtoContract]
public class LOG_COLLECTIONID
{
    [ProtoMember(1)]

    public uint CollectionId { get; set; }

}

[ProtoContract]
public class LOG_REGITEMIDX
{
    [ProtoMember(1)]

    public uint RegItemIdx { get; set; }

}

[ProtoContract]
public class LOG_REGITEMUID
{
    [ProtoMember(1)]

    public ulong RegItemUID { get; set; }

}

[ProtoContract]
public class LOG_VEHICLEUID
{
    [ProtoMember(1)]

    public ulong VehicleUID { get; set; }

}

[ProtoContract]
public class LOG_VEHICLEIDX
{
    [ProtoMember(1)]

    public uint VehicleIdx { get; set; }

}

[ProtoContract]
public class LOG_MAILUID
{
    [ProtoMember(1)]

    public ulong MailUID { get; set; }

}

[ProtoContract]
public class LOG_MAILTYPEIDX
{
    [ProtoMember(1)]

    public uint MailTypeIdx { get; set; }

}

[ProtoContract]
public class LOG_ISEXPIRED
{
    [ProtoMember(1)]

    public bool IsExpired { get; set; }

}

[ProtoContract]
public class LOG_MAILTITLE
{
    [ProtoMember(1)]

    public string MailTitle { get; set; }

}

[ProtoContract]
public class LOG_COUPON_UID
{
    [ProtoMember(1)]

    public uint Coupon_uid { get; set; }

}

[ProtoContract]
public class LOG_COUPON_CODE
{
    [ProtoMember(1)]

    public string Coupon_code { get; set; }

}

[ProtoContract]
public class LOG_APPLY
{
    [ProtoMember(1)]

    public uint apply { get; set; }

}

[ProtoContract]
public class LOG_PRODUCT_MARKET
{
    [ProtoMember(1)]

    public uint Product_market { get; set; }

}

[ProtoContract]
public class LOG_PRODUCT_UID
{
    [ProtoMember(1)]

    public string Product_uid { get; set; }

}

[ProtoContract]
public class LOG_PRODUCT_NAME
{
    [ProtoMember(1)]

    public string Product_name { get; set; }

}

[ProtoContract]
public class LOG_RECEIPT
{
    [ProtoMember(1)]

    public string receipt { get; set; }

}

[ProtoContract]
public class LOG_RECEIPT2
{
    [ProtoMember(1)]

    public uint receipt2 { get; set; }

}

[ProtoContract]
public class LOG_RECEIVER_NAME
{
    [ProtoMember(1)]

    public string receiver_name { get; set; }

}

[ProtoContract]
public class LOG_RECEIVER_UID
{
    [ProtoMember(1)]

    public ulong receiver_uid { get; set; }

}

[ProtoContract]
public class LOG_PURCHASEAMOUNT
{
    [ProtoMember(1)]

    public ulong PurchaseAmount { get; set; }

}

[ProtoContract]
public class LOG_PRODUCTIDX
{
    [ProtoMember(1)]

    public uint ProductIdx { get; set; }

}

[ProtoContract]
public class LOG_VAL
{
    [ProtoMember(1)]

    public ulong val { get; set; }

}

[ProtoContract]
public class LOG_MONSTER_UID
{
    [ProtoMember(1)]

    public ulong Monster_UID { get; set; }

}

[ProtoContract]
public class LOG_MONSTER_NAME
{
    [ProtoMember(1)]

    public string Monster_Name { get; set; }

}

[ProtoContract]
public class LOG_TRADEUID
{
    [ProtoMember(1)]

    public ulong TradeUID { get; set; }

}

[ProtoContract]
public class LOG_MONEYADJUSTMENT
{
    [ProtoMember(1)]

    public long MoneyAdjustment { get; set; }

}

[ProtoContract]
public class LOG_MONEYTOTALVALUE
{
    [ProtoMember(1)]

    public long MoneyTotalValue { get; set; }

}

[ProtoContract]
public class LOG_TARGETTYPE
{
    [ProtoMember(1)]

    public uint TargetType { get; set; }

}

[ProtoContract]
public class LOG_ISCRITICAL
{
    [ProtoMember(1)]

    public bool IsCritical { get; set; }

}

[ProtoContract]
public class LOG_ISDEFENCED
{
    [ProtoMember(1)]

    public bool IsDefenced { get; set; }

}

[ProtoContract]
public class LOG_ISEVADED
{
    [ProtoMember(1)]

    public bool IsEvaded { get; set; }

}

[ProtoContract]
public class LOG_TOTALDEMAGE
{
    [ProtoMember(1)]

    public ulong TotalDemage { get; set; }

}

[ProtoContract]
public class LOG_HEALTYPE
{
    [ProtoMember(1)]

    public uint HealType { get; set; }

}

[ProtoContract]
public class LOG_CASTERUID
{
    [ProtoMember(1)]

    public ulong CasterUID { get; set; }

}

[ProtoContract]
public class LOG_TOTALHEAL
{
    [ProtoMember(1)]

    public ulong TotalHeal { get; set; }

}

[ProtoContract]
public class LOG_DECKID
{
    [ProtoMember(1)]

    public int DeckId { get; set; }

}

[ProtoContract]
public class LOG_SLOTID
{
    [ProtoMember(1)]

    public int SlotId { get; set; }

}

[ProtoContract]
public class LOG_PETID
{
    [ProtoMember(1)]

    public int PetId { get; set; }

}

[ProtoContract]
public class LOG_PETGRADE
{
    [ProtoMember(1)]

    public int PetGrade { get; set; }

}

[ProtoContract]
public class LOG_SKILLTIME
{
    [ProtoMember(1)]

    public ulong SkillTime { get; set; }

}

[ProtoContract]
public class LOG_SKILLID
{
    [ProtoMember(1)]

    public int SkillID { get; set; }

}

[ProtoContract]
public class LOG_EXPEDITIONIDX
{
    [ProtoMember(1)]

    public int ExpeditionIdx { get; set; }

}

[ProtoContract]
public class LOG_EXPEDITIONCOUNT
{
    [ProtoMember(1)]

    public int ExpeditionCount { get; set; }

}

[ProtoContract]
public class LOG_GIFTLEV
{
    [ProtoMember(1)]

    public int GiftLev { get; set; }

}

[ProtoContract]
public class LOG_ADJUSTMENTGIFTEXP
{
    [ProtoMember(1)]

    public int AdjustmentGiftEXP { get; set; }

}

[ProtoContract]
public class LOG_TOTALGIFTEXP
{
    [ProtoMember(1)]

    public int TotalGiftExp { get; set; }

}

[ProtoContract]
public class LOG_STATIDX
{
    [ProtoMember(1)]

    public uint StatIdx { get; set; }

}

[ProtoContract]
public class LOG_GACHAIDX
{
    [ProtoMember(1)]

    public uint GachaIdx { get; set; }

}

[ProtoContract]
public class LOG_CHEATCMD
{
    [ProtoMember(1)]

    public string CheatCmd { get; set; }

}

[ProtoContract]
public class LOG_ITEM
{
    [ProtoMember(1)]

    public uint ItemIdx { get; set; }
    [ProtoMember(2)]
    public ulong ItemUID { get; set; }
    [ProtoMember(3)]
    public int Adjustment { get; set; }
    [ProtoMember(4)]
    public int TotalValue { get; set; }
    [ProtoMember(5)]
    public int XdracoTag { get; set; }

}

[ProtoContract]
public class LOG_DELITEMS
{
    [ProtoMember(1)]

    public LOG_ITEM Items { get; set; }

}

[ProtoContract]
public class LOG_ADDITEMS
{
    [ProtoMember(1)]

    public LOG_ITEM Items { get; set; }

}

[ProtoContract]
public class LOG_OPTIONS
{
    [ProtoMember(1)]

    public uint OptionIdx { get; set; }
    [ProtoMember(2)]
    public ulong OptionValue { get; set; }

}

[ProtoContract]
public class LOG_CHANGEOPTIONITEM
{
    [ProtoMember(1)]

    public LOG_OPTIONITEMS OptionItems { get; set; }

}

[ProtoContract]
public class LOG_SMELTINGITEMS
{
    [ProtoMember(1)]

    public uint ItemIdx { get; set; }
    [ProtoMember(2)]
    public ulong ItemUID { get; set; }
    [ProtoMember(3)]
    public int Adjustment { get; set; }
    [ProtoMember(4)]
    public uint SmeltingLv { get; set; }

}

[ProtoContract]
public class LOG_TRADEITEMS
{
    [ProtoMember(1)]

    public LOG_SMELTINGITEMS SmeltingItems { get; set; }

}

[ProtoContract]
public class LOG_BUFF
{
    [ProtoMember(1)]

    public uint BuffType { get; set; }
    [ProtoMember(2)]
    public uint BuffIdx { get; set; }

}

[ProtoContract]
public class LOG_BATTLEATTACKBUFFS
{
    [ProtoMember(1)]

    public LOG_BUFF BattleAttackBuffs { get; set; }

}

[ProtoContract]
public class LOG_BATTLETARGETBUFFS
{
    [ProtoMember(1)]

    public LOG_BUFF BattleTargetBuffs { get; set; }

}

[ProtoContract]
public class LOG_BATTLECASTERBUFFS
{
    [ProtoMember(1)]

    public LOG_BUFF BattleCasterBuffs { get; set; }

}

[ProtoContract]
public class LOG_ACTIVESKILL
{
    [ProtoMember(1)]

    public uint SkillIdx { get; set; }
    [ProtoMember(2)]
    public uint SkillLev { get; set; }
    [ProtoMember(3)]
    public uint AttackIdx { get; set; }

}

[ProtoContract]
public class LOG_BATTLEACTIVESKILLS
{
    [ProtoMember(1)]

    LOG_ACTIVESKILL BattleActiveSkills { get; set; }

}

[ProtoContract]
public class LOG_STATUSEFFECT
{
    [ProtoMember(1)]

    public int[] EffectIdx { get; set; }

}

[ProtoContract]
public class LOG_BATTLESTATUSEFFECTS
{
    [ProtoMember(1)]

    LOG_STATUSEFFECT BattleStatusEffects { get; set; }

}

[ProtoContract]
public class LOG_MAILITEM
{
    [ProtoMember(1)]

    public LOG_ITEM Items { get; set; }

}

[ProtoContract]
public class LOG_MAILMONEY
{
    [ProtoMember(1)]

    public uint MoneyIdx { get; set; }
    [ProtoMember(2)]
    public uint MoneyAdjustment { get; set; }

}

[ProtoContract]
public class LOG_MONEYS
{
    [ProtoMember(1)]

    public LOG_MAILMONEY Moneys { get; set; }

}

[ProtoContract]
public class LOG_OPTIONITEMS
{
    [ProtoMember(1)]

    public uint ItemIdx { get; set; }
    [ProtoMember(2)]
    public ulong ItemUID { get; set; }
    [ProtoMember(3)]
    public int Adjustment { get; set; }
    [ProtoMember(4)]
    public int TotalValue { get; set; }
    [ProtoMember(5)]
    public LOG_OPTIONS Options { get; set; }

}

[ProtoContract]
public class LOG_SMELTINGITEM
{
    [ProtoMember(1)]

    public LOG_OPTIONITEMS OptionItems { get; set; }

}

[ProtoContract]
public class LOG_STRONGPOINTTID
{
    [ProtoMember(1)]

    public int StrongPointTid { get; set; }

}

[ProtoContract]
public class LOG_MILEAGE
{
    [ProtoMember(1)]

    public ulong Mileage { get; set; }

}

[ProtoContract]
public class LOG_STORETYPE
{
    [ProtoMember(1)]

    public string StoreType { get; set; }

}

[ProtoContract]
public class LOG_BUILDINGID
{
    [ProtoMember(1)]

    public int BuildingId { get; set; }

}

[ProtoContract]
public class LOG_BUILDINGLEVEL
{
    [ProtoMember(1)]

    public int BuildingLevel { get; set; }

}

[ProtoContract]
public class LOG_UPGRADEACCELTIME
{
    [ProtoMember(1)]

    public int UpgradeAccelTime { get; set; }

}

[ProtoContract]
public class LOG_SUPPORTDATA
{
    [ProtoMember(1)]

    public long SupportCharacterUID { get; set; }
    [ProtoMember(2)]
    public int SupportType { get; set; }
    [ProtoMember(3)]
    public int SupportSlot { get; set; }
    [ProtoMember(4)]
    public int SupportIdx { get; set; }
    [ProtoMember(5)]
    public int SupportCount { get; set; }
    [ProtoMember(6)]
    public int MaxSupportCount { get; set; }

}

[ProtoContract]
public class LOG_SUPPORTDATAS
{
    [ProtoMember(1)]

    public LOG_SUPPORTDATA SupportData { get; set; }

}

[ProtoContract]
public class LOG_GUILDGIFTLEV
{
    [ProtoMember(1)]

    public int GuildGiftLev { get; set; }

}

[ProtoContract]
public class LOG_GIFTEXP
{
    [ProtoMember(1)]

    public int GiftExp { get; set; }

}

[ProtoContract]
public class LOG_SLOT
{
    [ProtoMember(1)]

    public int Slot { get; set; }

}

[ProtoContract]
public class LOG_TICKETTYPE
{
    [ProtoMember(1)]

    public int TicketType { get; set; }

}

[ProtoContract]
public class LOG_TICKETCOUNT
{
    [ProtoMember(1)]

    public int TicketCount { get; set; }

}

[ProtoContract]
public class LOG_TICKETMAX
{
    [ProtoMember(1)]

    public int TicketMax { get; set; }

}

[ProtoContract]
public class LOG_TICKETBUYCOUNT
{
    [ProtoMember(1)]

    public int TicketBuyCount { get; set; }

}

[ProtoContract]
public class LOG_DUNGEONIDX
{
    [ProtoMember(1)]

    public int DungeonIdx { get; set; }

}

[ProtoContract]
public class LOG_MATERIAL
{
    [ProtoMember(1)]

    public uint ItemIdx { get; set; }
    [ProtoMember(2)]
    public ulong ItemUID { get; set; }
    [ProtoMember(3)]
    public int Adjustment { get; set; }

}

[ProtoContract]
public class LOG_MATERIALS
{
    [ProtoMember(1)]

    public LOG_MATERIAL Materials { get; set; }

}

[ProtoContract]
public class LOG_MAILPRESETID
{
    [ProtoMember(1)]

    public uint MailPresetID { get; set; }

}

[ProtoContract]
public class LOG_MAILARGS
{
    [ProtoMember(1)]

    public string MailArgs { get; set; }

}

[ProtoContract]
public class LOG_FAILPOINTTYPE
{
    [ProtoMember(1)]

    public int FailPointType { get; set; }

}

[ProtoContract]
public class LOG_ADJUSTMENTFAILPOINT
{
    [ProtoMember(1)]

    public int AdjustmentFailPoint { get; set; }

}

[ProtoContract]
public class LOG_TOTALFAILPOINT
{
    [ProtoMember(1)]

    public int TotalFailPoint { get; set; }

}

[ProtoContract]
public class LOG_WANTEDUID
{
    [ProtoMember(1)]

    public long WantedUid { get; set; }

}

[ProtoContract]
public class LOG_COMPOSE_ADDITEMS
{
    [ProtoMember(1)]

    public LOG_ITEM Items { get; set; }

}

[ProtoContract]
public class LOG_COMPOSE_MATERIALS
{
    [ProtoMember(1)]

    public LOG_MATERIAL Materials { get; set; }

}

[ProtoContract]
public class LOG_NEWCHARACTERNAME
{
    [ProtoMember(1)]

    public string NewCharacterName { get; set; }

}

[ProtoContract]
public class LOG_GIFTID
{
    [ProtoMember(1)]

    public int GiftId { get; set; }

}

[ProtoContract]
public class LOG_GIFTUID
{
    [ProtoMember(1)]

    public long GiftUID { get; set; }

}

[ProtoContract]
public class LOG_GIFTTAPTYPE
{
    [ProtoMember(1)]

    public int GiftTapType { get; set; }

}

[ProtoContract]
public class LOG_SENDCHARACTERUID
{
    [ProtoMember(1)]

    public long SendCharacterUID { get; set; }

}

[ProtoContract]
public class LOG_SENDCHARACTERNAME
{
    [ProtoMember(1)]

    public string SendCharacterName { get; set; }

}

[ProtoContract]
public class LOG_GAINGIFTTYPE
{
    [ProtoMember(1)]

    public int GainGiftType { get; set; }

}

[ProtoContract]
public class LOG_GAINGIFTSUBTYPE
{
    [ProtoMember(1)]

    public int GainGiftSubType { get; set; }

}

[ProtoContract]
public class LOG_GAINGIFTVALUE
{
    [ProtoMember(1)]

    public int GainGiftValue { get; set; }

}

[ProtoContract]
public class LOG_SIEGETID
{
    [ProtoMember(1)]

    public int SiegeTid { get; set; }

}

[ProtoContract]
public class LOG_SIEGEAUCTIONTYPE
{
    [ProtoMember(1)]

    public int siegeauctiontype { get; set; }

}

[ProtoContract]
public class LOG_GUILDCAMPKIND
{
    [ProtoMember(1)]

    public int GuildCampKind { get; set; }

}

[ProtoContract]
public class LOG_PETLEVEL
{
    [ProtoMember(1)]

    public int PetLevel { get; set; }

}

[ProtoContract]
public class LOG_TRAININGSTATUSID
{
    [ProtoMember(1)]

    public int TrainingStatusId { get; set; }

}

[ProtoContract]
public class LOG_TRAININGLEVEL
{
    [ProtoMember(1)]

    public int TrainingLevel { get; set; }

}

[ProtoContract]
public class LOG_CRITICALFAILRESULT
{
    [ProtoMember(1)]

    public int CriticalFailResult { get; set; }

}

[ProtoContract]
public class LOG_ISALLIANCE
{
    [ProtoMember(1)]

    public bool IsAlliance { get; set; }

}

[ProtoContract]
public class LOG_PURCHASEMONEY
{
    [ProtoMember(1)]

    public uint MoneyIdx { get; set; }
    [ProtoMember(2)]
    public ulong PurchaseAmount { get; set; }
    [ProtoMember(3)]
    public long MoneyTotalValue { get; set; }

}

[ProtoContract]
public class LOG_PURCHASEMONEYS
{
    [ProtoMember(1)]

    public LOG_PURCHASEMONEY purchaseMoneys { get; set; }

}

[ProtoContract]
public class LOG_CHANGEMONEY
{
    [ProtoMember(1)]

    public uint MoneyIdx { get; set; }
    [ProtoMember(2)]
    public ulong ChangeAmount { get; set; }
    [ProtoMember(3)]
    public long MoneyTotalValue { get; set; }

}

[ProtoContract]
public class LOG_CHANGEMONEYS
{
    [ProtoMember(1)]

    public LOG_CHANGEMONEY changesMoneys { get; set; }

}

[ProtoContract]
public class LOG_SUCCESS
{
    [ProtoMember(1)]

    public int Success { get; set; }

}

[ProtoContract]
public class LOG_STARTTIME
{
    [ProtoMember(1)]

    public string StartTime { get; set; }

}

[ProtoContract]
public class LOG_BOSSMONSTERKILLCOUNT
{
    [ProtoMember(1)]

    public int BossMonsterKillCount { get; set; }

}

[ProtoContract]
public class LOG_STARTWORLDID
{
    [ProtoMember(1)]

    public int StartWorldID { get; set; }

}

[ProtoContract]
public class LOG_TARGETWORLDID
{
    [ProtoMember(1)]

    public int TargetWorldID { get; set; }

}

[ProtoContract]
public class LOG_ADJUSTMENTPKPOINT
{
    [ProtoMember(1)]

    public int AdjustmentPKPoint { get; set; }

}

[ProtoContract]
public class LOG_PKPOINT
{
    [ProtoMember(1)]

    public int PKPoint { get; set; }

}

[ProtoContract]
public class LOG_ADJUSTMENTBONUSPOINT
{
    [ProtoMember(1)]

    public int AdjustmentBonusPoint { get; set; }

}

[ProtoContract]
public class LOG_TOTALBONUSPOINT
{
    [ProtoMember(1)]

    public int TotalBonusPoint { get; set; }

}

[ProtoContract]
public class LOG_ADJUSTMENTBONUSCOUNT
{
    [ProtoMember(1)]

    public int AdjustmentBonusCount { get; set; }

}

[ProtoContract]
public class LOG_TOTALBONUSCOUNT
{
    [ProtoMember(1)]

    public int TotalBonusCount { get; set; }

}

[ProtoContract]
public class LOG_USERAGENT
{
    [ProtoMember(1)]

    public int UserAgent { get; set; }

}

[ProtoContract]
public class LOG_OPENCHACTERCLASS
{
    [ProtoMember(1)]

    public int OpenCharacterClass { get; set; }

}

[ProtoContract]
public class LOG_CHANGECHACTERCLASS
{
    [ProtoMember(1)]

    public int ChangeCharacterClass { get; set; }

}

[ProtoContract]
public class LOG_CHARACTERCLASSLIST
{
    [ProtoMember(1)]

    public LOG_OPENCHACTERCLASS CharacterClassList { get; set; }

}

[ProtoContract]
public class LOG_BONUSCOUNT
{
    [ProtoMember(1)]

    public int BonusCount { get; set; }

}

[ProtoContract]
public class LOG_SUCCESSCOUNT
{
    [ProtoMember(1)]

    public int SuccessCount { get; set; }

}

[ProtoContract]
public class LOG_FAILCOUNT
{
    [ProtoMember(1)]

    public int FailCount { get; set; }

}

[ProtoContract]
public class LOG_TRYMAKECOUNT
{
    [ProtoMember(1)]

    public int TryMakeCount { get; set; }

}

[ProtoContract]
public class LOG_MAKECOUNT
{
    [ProtoMember(1)]

    public int MakeCount { get; set; }

}

[ProtoContract]
public class LOG_WORLDMAKECOUNT
{
    [ProtoMember(1)]

    public int WorldMakeCount { get; set; }

}

[ProtoContract]
public class LOG_WEMIXID
{
    [ProtoMember(1)]

    public string WemixID { get; set; }

}

[ProtoContract]
public class LOG_DERBY
{
    [ProtoMember(1)]

    public long Derby { get; set; }

}

[ProtoContract]
public class LOG_ISSUED
{
    [ProtoMember(1)]

    public long Issued { get; set; }

}

[ProtoContract]
public class LOG_OBJECTGATHERTYPE
{
    [ProtoMember(1)]

    public int ObjectGatherType { get; set; }

}

[ProtoContract]
public class LOG_OBJECTPOSID
{
    [ProtoMember(1)]

    public int ObjectPosID { get; set; }

}

[ProtoContract]
public class LOG_DEPARTURESTAGEIDX
{
    [ProtoMember(1)]

    public int DepartureStageIdx { get; set; }

}

[ProtoContract]
public class LOG_ARRIVALSTAGEIDX
{
    [ProtoMember(1)]

    public int ArrivalStageIdx { get; set; }

}

[ProtoContract]
public class LOG_TARGET_ITEMCOUNT
{
    [ProtoMember(1)]

    public uint Target_ItemCount { get; set; }

}

[ProtoContract]
public class LOG_POINT_ADJUSTMENT
{
    [ProtoMember(1)]

    public int PointAdjustment { get; set; }

}

[ProtoContract]
public class LOG_POINT_TOTAL_VALUE
{
    [ProtoMember(1)]

    public int PointTotalValue { get; set; }

}

[ProtoContract]
public class LOG_VIEW_COUNT
{
    [ProtoMember(1)]

    public int ViewCount { get; set; }

}

[ProtoContract]
public class LOG_TOKEN_ID
{
    [ProtoMember(1)]

    public ulong TokenID { get; set; }

}

[ProtoContract]
public class LOG_EVENTIDX
{
    [ProtoMember(1)]

    public ulong EventIdx { get; set; }

}

[ProtoContract]
public class LOG_CALCULATEADJUSTMENT
{
    [ProtoMember(1)]

    public ulong CalculateAdjustment { get; set; }

}

[ProtoContract]
public class LOG_BUYTRYCHARACTERUID
{
    [ProtoMember(1)]

    public ulong BuyTryCharacterUID { get; set; }

}

[ProtoContract]
public class LOG_DRACO_FEE
{
    [ProtoMember(1)]

    public int Dracofee { get; set; }

}

[ProtoContract]
public class LOG_SEPTARIA_FEE
{
    [ProtoMember(1)]

    public int Septariafee { get; set; }

}

[ProtoContract]
public class LOG_SEPTARIA_UID
{
    [ProtoMember(1)]

    public ulong SeptariaUID { get; set; }

}

[ProtoContract]
public class LOG_PLAYERKEY
{
    [ProtoMember(1)]

    public string playerkey { get; set; }

}

[ProtoContract]
public class LOG_AUTHTOKENID
{
    [ProtoMember(1)]

    public string authtokenid { get; set; }

}

[ProtoContract]
public class LOG_BEFORECOMBATPOINT
{
    [ProtoMember(1)]

    public uint BeforeCombatPoint { get; set; }

}

[ProtoContract]
public class LOG_REFININGSTAGE
{
    [ProtoMember(1)]

    public int RefiningStage { get; set; }

}

[ProtoContract]
public class LOG_SPECIALEFFECT
{
    [ProtoMember(1)]

    public int SpecialEffect { get; set; }

}

[ProtoContract]
public class LOG_STEALCHARACTERUID
{
    [ProtoMember(1)]

    public long StealCharacterUID { get; set; }

}

[ProtoContract]
public class LOG_STEALCHARACTERNAME
{
    [ProtoMember(1)]

    public string StealCharacterName { get; set; }

}

[ProtoContract]
public class LOG_MARKET_RECEIPT
{
    [ProtoMember(1)]

    public string MarketReceipt { get; set; }

}

[ProtoContract]
public class LOG_DARKALTARID
{
    [ProtoMember(1)]

    public uint DarkAltarId { get; set; }

}

[ProtoContract]
public class LOG_PRODUCTINFO
{
    [ProtoMember(1)]

    public uint ProductIdx { get; set; }
    [ProtoMember(2)]
    public int ProductCount { get; set; }

}

[ProtoContract]
public class LOG_PRODUCTINFOS
{
    [ProtoMember(1)]

    public LOG_PRODUCTINFO ProductInfos { get; set; }

}

[ProtoContract]
public class LOG_CASHBAGINFO
{
    [ProtoMember(1)]

    public uint ProductIdx { get; set; }
    [ProtoMember(2)]
    public int ProductDivisionNumber { get; set; }
    [ProtoMember(3)]
    public string receipt { get; set; }

}

[ProtoContract]
public class LOG_CASHBAGINFOS
{
    [ProtoMember(1)]

    public LOG_CASHBAGINFO CashBagInfos { get; set; }

}

[ProtoContract]
public class LOG_PLUNDERTID
{
    [ProtoMember(1)]

    public int PlunderTid { get; set; }

}

[ProtoContract]
public class LOG_OBJECTID
{
    [ProtoMember(1)]

    public int ObjecTid { get; set; }

}

[ProtoContract]
public class LOG_REWARDVALUE
{
    [ProtoMember(1)]

    public long RewardValue { get; set; }

}

[ProtoContract]
public class LOG_TOTAL_DARKSTEELTEX
{
    [ProtoMember(1)]

    public long Total_DarksteelTex { get; set; }

}

[ProtoContract]
public class LOG_CURRENT_DARKSTEELTEX
{
    [ProtoMember(1)]

    public long Current_DarksteelTex { get; set; }

}

[ProtoContract]
public class LOG_SUM_DARKSTEELTEX
{
    [ProtoMember(1)]

    public long Sum_DarksteelTex { get; set; }

}

[ProtoContract]
public class LOG_DAILYDEDUCTION_DARKSTEELTEX
{
    [ProtoMember(1)]

    public long DailyDeduction_DarkSteelTex { get; set; }

}

[ProtoContract]
public class LOG_REMAINDEDUCTION_DARKSTEELTEX
{
    [ProtoMember(1)]

    public long RemainDeduction_DarkSteelTex { get; set; }

}

[ProtoContract]
public class LOG_RESULT
{
    [ProtoMember(1)]

    public int Result { get; set; }

}

[ProtoContract]
public class LOG_HOLYSTUFFID
{
    [ProtoMember(1)]

    public int HolyStuffId { get; set; }

}

[ProtoContract]
public class LOG_HOLYSTUFFGRADE
{
    [ProtoMember(1)]

    public int HolyStuffGrade { get; set; }

}

[ProtoContract]
public class LOG_HOLYSTUFFLEVEL
{
    [ProtoMember(1)]

    public int HolyStuffLevel { get; set; }

}

[ProtoContract]
public class LOG_GROWTHSTATUSSLOTNUMBER
{
    [ProtoMember(1)]

    public int GrowthStatusSlotNumber { get; set; }

}

[ProtoContract]
public class LOG_REWARDITEMIDX
{
    [ProtoMember(1)]

    public uint RewardItemIdx { get; set; }

}

[ProtoContract]
public class LOG_REWARDITEMCOUNT
{
    [ProtoMember(1)]

    public int RewardItemCount { get; set; }

}

[ProtoContract]
public class LOG_SUMMONCOUNT
{
    [ProtoMember(1)]

    public int SummonCount { get; set; }

}

[ProtoContract]
public class LOG_GROUPID
{
    [ProtoMember(1)]

    public int GroupID { get; set; }

}

[ProtoContract]
public class LOG_CURRENTFREERESTORE
{
    [ProtoMember(1)]

    public int CurrentFreeRestore { get; set; }

}

[ProtoContract]
public class LOG_MAXFREERESTORE
{
    [ProtoMember(1)]

    public int MaxFreeRestore { get; set; }

}

[ProtoContract]
public class LOG_SABUK_ROUNDTID
{
    [ProtoMember(1)]

    public int Sabuk_RoundTID { get; set; }

}

[ProtoContract]
public class LOG_RESETRESULTCOUNT
{
    [ProtoMember(1)]

    public int ResetResultCount { get; set; }

}

[ProtoContract]
public class LOG_SABUKTAXRATE
{
    [ProtoMember(1)]

    public int SabukTaxRate { get; set; }

}

[ProtoContract]
public class LOG_SABUKTAXRATEBEFORE
{
    [ProtoMember(1)]

    public int SabukTaxRateBefore { get; set; }

}

[ProtoContract]
public class LOG_SABUKTAXRATEAFTER
{
    [ProtoMember(1)]

    public int SabukTaxRateAfter { get; set; }

}

[ProtoContract]
public class LOG_UNSEALING_ACCELERATE_INFO
{
    [ProtoMember(1)]

    public int Slot { get; set; }
    [ProtoMember(2)]
    public int AccelerateTimeMin { get; set; }

}

[ProtoContract]
public class LOG_UNSEALING_ACCELERATE_INFOS
{
    [ProtoMember(1)]

    public LOG_UNSEALING_ACCELERATE_INFO UnsealingAccelerateInfos { get; set; }

}

[ProtoContract]
public class LOG_POTENTIALID
{
    [ProtoMember(1)]

    public int potentialid { get; set; }

}

[ProtoContract]
public class LOG_POTENTIALRESULT
{
    [ProtoMember(1)]

    public bool potentialresult { get; set; }

}

[ProtoContract]
public class LOG_POTENTIALLEV
{
    [ProtoMember(1)]

    public int potentiallev { get; set; }

}

[ProtoContract]
public class LOG_POTENTIALRESULT_LEV
{
    [ProtoMember(1)]

    public int potentialresult_lev { get; set; }

}


[ProtoContract]
public class CLIENT_GAME_USER_EVENT_INFO
{
}

[ProtoContract]
public class GAME_CLIENT_USER_EVENT_INFO
{
    [ProtoMember(1)]

    public int daily_first_access { get; set; }
    [ProtoMember(2)]
    public _user_event_info[] event_info_list { get; set; }

}

[ProtoContract]
public class GAME_CLIENT_START_EVENT
{
    [ProtoMember(1)]

    public int event_id { get; set; }

}

[ProtoContract]
public class GAME_CLIENT_END_EVENT
{
    [ProtoMember(1)]

    public int event_id { get; set; }

}

[ProtoContract]
public class CLIENT_GAME_EVENT_PROGRESS
{
    [ProtoMember(1)]

    public int event_id { get; set; }
    [ProtoMember(2)]
    public int event_step_number { get; set; }

}

[ProtoContract]
public class GAME_CLIENT_EVENT_PROGRESS
{
    [ProtoMember(1)]

    public int result { get; set; }
    [ProtoMember(2)]
    _user_event_info event_info { get; set; }
    [ProtoMember(3)]
    public _cost_info[] cost_info { get; set; }
    [ProtoMember(4)]
    public _character_inven_item[] item_info { get; set; }
    [ProtoMember(5)]
    public _cost_info[] reward_cost_info { get; set; }
    [ProtoMember(6)]
    public _simple_item_info[] reward_item_info { get; set; }

}

[ProtoContract]
public class CLIENT_GAME_UNATTENDED_STEP_ATTENDED_PROGRESS
{
    [ProtoMember(1)]

    public int event_id { get; set; }
    [ProtoMember(2)]
    public int event_step_number { get; set; }

}

[ProtoContract]
public class GAME_CLIENT_UNATTENDED_STEP_ATTENDED_PROGRESS
{
    [ProtoMember(1)]

    public int result { get; set; }
    [ProtoMember(2)]
    _user_event_info event_info { get; set; }
    [ProtoMember(3)]
    public _cost_info[] cost_info { get; set; }
    [ProtoMember(4)]
    public _character_inven_item[] item_info { get; set; }
    [ProtoMember(5)]
    public _cost_info[] reward_cost_info { get; set; }
    [ProtoMember(6)]
    public _simple_item_info[] reward_item_info { get; set; }

}

[ProtoContract]
public class GAME_CLIENT_GOAL_ACHIEVEMENT_EVENT_NEXT_STEP_STATE
{
    [ProtoMember(1)]

    public int event_id { get; set; }
    [ProtoMember(2)]
    public int reward_available { get; set; }

}

[ProtoContract]
public class WORLD_GAME_ENTER_NPC_SHOW_SCHEDULE
{
    [ProtoMember(1)]

    public int schedule_id { get; set; }

}

[ProtoContract]
public class WORLD_GAME_EXIT_NPC_SHOW_SCHEDULE
{
    [ProtoMember(1)]

    public int schedule_id { get; set; }

}

[ProtoContract]
public class benediction_data
{
    [ProtoMember(1)]

    public bool used { get; set; }
    [ProtoMember(2)]
    public int incense_type { get; set; }
    [ProtoMember(3)]
    public int benediction_tid { get; set; }

}

[ProtoContract]
public class CLIENT_GAME_BENEDICTION_EVENT_DATA
{
    [ProtoMember(1)]

    public int user_event_tid { get; set; }

}

[ProtoContract]
public class GAME_CLIENT_BENEDICTION_EVENT_DATA
{
    [ProtoMember(1)]

    public int result { get; set; }
    [ProtoMember(2)]
    public benediction_data benediction_list { get; set; }

}

[ProtoContract]
public class CLIENT_GAME_BENEDICTION_EVENT_SELECT
{
    [ProtoMember(1)]

    public int user_event_tid { get; set; }
    [ProtoMember(2)]
    public int benediction_tid { get; set; }

}

[ProtoContract]
public class GAME_CLIENT_BENEDICTION_EVENT_SELECT
{
    [ProtoMember(1)]

    public int result { get; set; }
    [ProtoMember(2)]
    benediction_data event_data { get; set; }
    [ProtoMember(3)]
    _stack_item_info delete_item { get; set; }
    [ProtoMember(4)]
    public _character_inven_item[] update_items { get; set; }

}

[ProtoContract]
public class WORLD_GAME_CHANGE_EVENT_TIME
{
    [ProtoMember(1)]

    public int event_id { get; set; }
    [ProtoMember(2)]
    public string start_time { get; set; }
    [ProtoMember(3)]
    public string end_time { get; set; }
    [ProtoMember(4)]
    public int change_type { get; set; }

}

[ProtoContract]
public class CLIENT_GAME_SIEGE_EVE_EVENT_DATA
{
    [ProtoMember(1)]

    public int user_event_id { get; set; }

}

[ProtoContract]
public class GAME_CLIENT_SIEGE_EVE_EVENT_DATA
{
    [ProtoMember(1)]

    public int result { get; set; }
    [ProtoMember(2)]
    public int user_event_id { get; set; }
    [ProtoMember(3)]
    public int event_item_count { get; set; }
    [ProtoMember(4)]
    public int total_defense_cheering_count { get; set; }
    [ProtoMember(5)]
    public int total_siege_cheering_count { get; set; }
    [ProtoMember(6)]
    public int cheering_count { get; set; }
    [ProtoMember(7)]
    public int cheering_event_state { get; set; }

}

[ProtoContract]
public class CLIENT_GAME_SIEGE_EVE_EVENT_SELECT_CHEERING_TEAM
{
    [ProtoMember(1)]

    public int user_event_id { get; set; }
    [ProtoMember(2)]
    public int select_cheering_team { get; set; }
    [ProtoMember(3)]
    public int cheering_count { get; set; }

}

[ProtoContract]
public class GAME_CLIENT_SIEGE_EVE_EVENT_SELECT_CHEERING_TEAM
{
    [ProtoMember(1)]

    public int result { get; set; }
    [ProtoMember(2)]
    public int user_event_id { get; set; }
    [ProtoMember(3)]
    public _stack_item_info[] delete_item { get; set; }
    [ProtoMember(4)]
    public int cheering_count { get; set; }
    [ProtoMember(5)]
    public _simple_item_info[] reward_item_info { get; set; }
    [ProtoMember(6)]
    public int total_defense_cheering_count { get; set; }
    [ProtoMember(7)]
    public int total_siege_cheering_count { get; set; }
    [ProtoMember(8)]
    public _character_inven_item[] change_item_info { get; set; }

}

[ProtoContract]
public class CLIENT_GAME_PAINTING_EVENT_PROCESS
{
    [ProtoMember(1)]

    public int user_event_id { get; set; }

}

[ProtoContract]
public class GAME_CLIENT_PAINTING_EVENT_PROCESS
{
    [ProtoMember(1)]

    public int result { get; set; }
    [ProtoMember(2)]
    _user_event_info event_info { get; set; }
    [ProtoMember(3)]
    public _stack_item_info[] delete_item { get; set; }
    [ProtoMember(4)]
    public _simple_item_info[] reward_item_info { get; set; }
    [ProtoMember(5)]
    public _character_inven_item[] change_item_info { get; set; }

}

[ProtoContract]
public class CLIENT_GAME_BOSS_SPAWN_LIST
{
}

[ProtoContract]
public class GAME_CLIENT_BOSS_SPAWN_LIST
{
    [ProtoMember(1)]

    public int result { get; set; }
    [ProtoMember(2)]
    public uint[] boss_tid_list { get; set; }

}

[ProtoContract]
public class GAME_CLIENT_BOSS_SPAWN
{
    [ProtoMember(1)]

    public uint boss_tid { get; set; }

}

[ProtoContract]
public class GAME_CLIENT_BOSS_DESPAWN
{
    [ProtoMember(1)]

    public uint boss_tid { get; set; }

}


[ProtoContract]
public class CLIENT_GAME_CHARACTER_EVENT_PASS_MISSION_CLEAR
{
    [ProtoMember(1)]

    public ulong user_uid { get; set; }
    [ProtoMember(2)]
    public uint[] request_event_pass_id_list { get; set; }

}

[ProtoContract]
public class GAME_CLIENT_SYNC_CLEAR_EVENT_PASS
{
    [ProtoMember(1)]

    public uint event_pass_id { get; set; }
    [ProtoMember(2)]
    public uint total_mission_point { get; set; }

}

[ProtoContract]
public class GAME_CLIENT_EVENT_PASS_MISSION_CLEAR_LIST_RESULT
{
    [ProtoMember(1)]

    public bool success_all { get; set; }
    [ProtoMember(2)]
    public uint[] event_pass_id_list { get; set; }
    [ProtoMember(3)]
    public _cost_info[] cost_info_list { get; set; }
    [ProtoMember(4)]
    public uint error_id { get; set; }
    [ProtoMember(5)]
    public uint error_reason_event_pass_id { get; set; }
    [ProtoMember(6)]
    public _character_event_pass_mission_complete_info character_event_pass_complete_list { get; set; }

}

[ProtoContract]
public class GAME_CLIENT_SYNC_EVENT_PASS_DATA
{
    [ProtoMember(1)]

    public _character_event_pass_data_info event_pass_data_list { get; set; }

}

[ProtoContract]
public class CLIENT_GAME_CHARACTER_EVENT_PASS_REWARD
{
    [ProtoMember(1)]

    public ulong user_uid { get; set; }
    [ProtoMember(2)]
    public uint[] reward_type { get; set; }
    [ProtoMember(3)]
    public uint[] request_event_pass_id_list { get; set; }

}

[ProtoContract]
public class GAME_CLIENT_SYNC_REWARD_EVENT_PASS
{
    [ProtoMember(1)]

    public uint event_pass_id { get; set; }
    [ProtoMember(2)]
    public _cost_info[] cost_info_list { get; set; }
    [ProtoMember(3)]
    public _character_inven_item[] reward_item_list { get; set; }
    [ProtoMember(4)]
    public ulong user_event_id { get; set; }

}

[ProtoContract]
public class GAME_CLIENT_REWARD_EVENT_PASS_LIST_RESULT
{
    [ProtoMember(1)]

    public bool success_all { get; set; }
    [ProtoMember(2)]
    public uint[] event_pass_id_list { get; set; }
    [ProtoMember(3)]
    public uint error_id { get; set; }
    [ProtoMember(4)]
    public uint error_reason_event_pass_id { get; set; }
    [ProtoMember(5)]
    _user_event_info event_info { get; set; }

}

[ProtoContract]
public class CLIENT_GAME_CHARACTER_EVENT_PASS_TICKET
{
}

[ProtoContract]
public class GAME_CLIENT_CHARACTER_EVENT_PASS_TICKET
{
    [ProtoMember(1)]

    public ulong character_event_pass { get; set; }
    [ProtoMember(2)]
    public ulong character_event_pass2 { get; set; }
    [ProtoMember(3)]
    public _character_event_pass_date character_event_pass_date_list { get; set; }

}

[ProtoContract]
public class WORLD_GAME_API_UPDATE_EVENTPASS
{
    [ProtoMember(1)]

    public ulong user_uid { get; set; }
    [ProtoMember(2)]
    public ulong account_uid { get; set; }
    [ProtoMember(3)]
    public uint category { get; set; }

}

[ProtoContract]
public class CLIENT_GAME_CHARACTER_EVENT_PASS_BUY_TICKET_MONEY
{
    [ProtoMember(1)]

    public ulong user_uid { get; set; }
    [ProtoMember(2)]
    public uint event_pass_info_uid { get; set; }
    [ProtoMember(3)]
    public uint purchase_number { get; set; }

}

[ProtoContract]
public class GAME_CLIENT_CHARACTER_EVENT_PASS_BUY_TICKET_MONEY
{
    [ProtoMember(1)]

    public uint error_id { get; set; }
    [ProtoMember(2)]
    public _cost_info[] cost_info_list { get; set; }
    [ProtoMember(3)]
    public _character_event_pass_date character_event_pass_date_list { get; set; }

}


[ProtoContract]
public class CLIENT_GAME_FAME_LIST
{
}

[ProtoContract]
public class GAME_CLIENT_FAME_LIST
{
    [ProtoMember(1)]

    public fame_info fame_list { get; set; }

}

[ProtoContract]
public class GAME_CLIENT_FAME_RANK
{
    [ProtoMember(1)]

    public ulong rank { get; set; }
    [ProtoMember(2)]
    public ulong score { get; set; }
    [ProtoMember(3)]
    public uint level { get; set; }
    [ProtoMember(4)]
    public ulong level_exp { get; set; }

}

[ProtoContract]
public class GAME_CLIENT_FAME_DATA
{
    [ProtoMember(1)]

    public ulong add_score { get; set; }
    [ProtoMember(2)]
    fame_info fame_data { get; set; }
    [ProtoMember(3)]
    public uint level { get; set; }
    [ProtoMember(4)]
    public ulong level_exp { get; set; }

}


[ProtoContract]
public class CLIENT_GAME_FORCE_LEARN
{
    [ProtoMember(1)]

    public int force_id { get; set; }

}

[ProtoContract]
public class GAME_CLIENT_FORCE_LEARN
{
    [ProtoMember(1)]

    public int result { get; set; }
    [ProtoMember(2)]
    _force_info data { get; set; }
    [ProtoMember(3)]
    public _stack_item_info[] del_item_list { get; set; }

}

[ProtoContract]
public class GAME_CLIENT_FORCE_UPDATE
{
    [ProtoMember(1)]

    public int update_state { get; set; }
    [ProtoMember(2)]
    _force_info data { get; set; }

}

[ProtoContract]
public class CLIENT_GAME_FORCE_BLOOD_UPGRADE
{
    [ProtoMember(1)]

    public int force_id { get; set; }
    [ProtoMember(2)]
    public int blood_slot_id { get; set; }

}

[ProtoContract]
public class GAME_CLIENT_FORCE_BLOOD_UPGRADE
{
    [ProtoMember(1)]

    public int result { get; set; }
    [ProtoMember(2)]
    _force_blood_info data { get; set; }
    [ProtoMember(3)]
    _cost_info cost_info { get; set; }
    [ProtoMember(4)]
    public _force_info slump_force_list { get; set; }
    [ProtoMember(5)]
    public _stack_item_info[] del_item_list { get; set; }

}

[ProtoContract]
public class CLIENT_GAME_FORCE_CURE
{
}

[ProtoContract]
public class GAME_CLIENT_FORCE_CURE
{
    [ProtoMember(1)]

    public int result { get; set; }
    [ProtoMember(2)]
    public _stack_item_info[] del_item_list { get; set; }
    [ProtoMember(3)]
    public _force_info update_force_list { get; set; }

}

[ProtoContract]
public class CLIENT_GAME_FORCE_UPGRADE
{
    [ProtoMember(1)]

    public int force_id { get; set; }

}

[ProtoContract]
public class GAME_CLIENT_FORCE_UPGRADE
{
    [ProtoMember(1)]

    public int result { get; set; }
    [ProtoMember(2)]
    _force_info data { get; set; }
    [ProtoMember(3)]
    public _stack_item_info[] del_item_list { get; set; }
    [ProtoMember(4)]
    public _cost_info[] cost_info { get; set; }

}

[ProtoContract]
public class CLIENT_GAME_FORCE_UPGRADE_APPLY
{
    [ProtoMember(1)]

    public int force_id { get; set; }
    [ProtoMember(2)]
    public int apply_type { get; set; }

}

[ProtoContract]
public class GAME_CLIENT_FORCE_UPGRADE_APPLY
{
    [ProtoMember(1)]

    public int result { get; set; }
    [ProtoMember(2)]
    _force_info data { get; set; }
    [ProtoMember(3)]
    public _stack_item_info[] del_item_list { get; set; }

}

[ProtoContract]
public class GAME_CLIENT_FORCE_SLUMP_TIME_UPDATE
{
    [ProtoMember(1)]

    public int update_state { get; set; }
    [ProtoMember(2)]
    public int slump_time { get; set; }
    [ProtoMember(3)]
    public int reflow_time { get; set; }

}


[ProtoContract]
public class CLIENT_WORLD_FRIEND_LIST
{
}

[ProtoContract]
public class WORLD_CLIENT_FRIEND_LIST_START
{
    [ProtoMember(1)]

    public uint total_cnt { get; set; }

}

[ProtoContract]
public class WORLD_CLIENT_FRIEND_LIST
{
    [ProtoMember(1)]

    public _friend_info friend_list { get; set; }

}

[ProtoContract]
public class WORLD_CLIENT_FRIEND_LIST_END
{
}

[ProtoContract]
public class CLIENT_WORLD_FRIEND_REQUEST_LIST
{
    [ProtoMember(1)]

    public int type { get; set; }

}

[ProtoContract]
public class WORLD_CLIENT_FRIEND_REQUEST_LIST_START
{
    [ProtoMember(1)]

    public int type { get; set; }
    [ProtoMember(2)]
    public uint total_cnt { get; set; }

}

[ProtoContract]
public class WORLD_CLIENT_FRIEND_REQUEST_LIST
{
    [ProtoMember(1)]

    public int type { get; set; }
    [ProtoMember(2)]
    public _friend_request_info friend_request_list { get; set; }

}

[ProtoContract]
public class WORLD_CLIENT_FRIEND_REQUEST_LIST_END
{
    [ProtoMember(1)]

    public int type { get; set; }

}

[ProtoContract]
public class CLIENT_WORLD_RECOMMEND_FRIEND_LIST
{    
}

[ProtoContract]
public class WORLD_CLIENT_RECOMMEND_FRIEND_LIST
{
    [ProtoMember(1)]

    public _recommend_friend_info recommend_friend_list { get; set; }

}

[ProtoContract]
public class GAME_WORLD_RECOMMEND_FRIEND_LIST
{
}

[ProtoContract]
public class WORLD_GAME_RECOMMEND_FRIEND_LIST
{
    [ProtoMember(1)]

    public ulong[] recommend_friend_list { get; set; }
    [ProtoMember(2)]
    public ulong user_uid { get; set; }

}

[ProtoContract]
public class CLIENT_WORLD_FRIEND_INVITE
{
    [ProtoMember(1)]

    public ulong target_user_uid { get; set; }

}

[ProtoContract]
public class WORLD_CLIENT_FRIEND_INVITE
{
    [ProtoMember(1)]

    public int result { get; set; }
    [ProtoMember(2)]
    public ulong target_user_uid { get; set; }

}

[ProtoContract]
public class WORLD_CLIENT_NOTIFY_FRIEND_INVITE
{
    [ProtoMember(1)]

    public _friend_request_info friend_request_info { get; set; }

}

[ProtoContract]
public class CLIENT_WORLD_FRIEND_INVITE_CANCEL
{
    [ProtoMember(1)]

    public ulong target_user_uid { get; set; }
    [ProtoMember(2)]
    public bool all { get; set; }

}

[ProtoContract]
public class WORLD_CLIENT_FRIEND_INVITE_CANCEL
{
    [ProtoMember(1)]

    public int result { get; set; }
    [ProtoMember(2)]
    public ulong target_user_uid { get; set; }

}

[ProtoContract]
public class WORLD_CLIENT_NOTIFY_FRIEND_INVITE_CANCEL
{
    [ProtoMember(1)]

    public ulong send_user_uid { get; set; }

}

[ProtoContract]
public class CLIENT_WORLD_FRIEND_INVITE_AGREE
{
    [ProtoMember(1)]

    public ulong target_user_uid { get; set; }
    [ProtoMember(2)]
    public bool all { get; set; }
    [ProtoMember(3)]
    public bool agree { get; set; }

}

[ProtoContract]
public class WORLD_CLIENT_FRIEND_INVITE_AGREE
{
    [ProtoMember(1)]

    public int result { get; set; }
    [ProtoMember(2)]
    public bool agree { get; set; }
    [ProtoMember(3)]
    _friend_info friend_info { get; set; }

}

[ProtoContract]
public class WORLD_CLIENT_NOTIFY_FRIEND_INVITE_AGREE
{
    [ProtoMember(1)]

    public bool agree { get; set; }
    [ProtoMember(2)]
    _friend_info friend_info { get; set; }

}

[ProtoContract]
public class CLIENT_WORLD_FRIEND_DEL
{
    [ProtoMember(1)]

    public ulong friend_uid { get; set; }

}

[ProtoContract]
public class WORLD_CLIENT_FRIEND_DEL
{
    [ProtoMember(1)]

    public int result { get; set; }
    [ProtoMember(2)]
    public ulong friend_uid { get; set; }

}

[ProtoContract]
public class WORLD_CLIENT_NOTIFY_FRIEND_DEL
{
    [ProtoMember(1)]

    public ulong friend_uid { get; set; }

}

[ProtoContract]
public class GAME_WORLD_NOTIFY_FRIEND
{
    [ProtoMember(1)]

    public ulong friend_uid { get; set; }
    [ProtoMember(2)]
    public ulong req_friend_uid { get; set; }
    [ProtoMember(3)]
    public int notify_type { get; set; }
    [ProtoMember(4)]
    _friend_info friend_info { get; set; }
    [ProtoMember(5)]
    public bool is_cancel { get; set; }

}

[ProtoContract]
public class WORLD_GAME_NOTIFY_FRIEND
{
    [ProtoMember(1)]

    public ulong friend_uid { get; set; }
    [ProtoMember(2)]
    public ulong req_friend_uid { get; set; }
    [ProtoMember(3)]
    public int notify_type { get; set; }
    [ProtoMember(4)]
    _friend_info friend_info { get; set; }
    [ProtoMember(5)]
    public bool is_cancel { get; set; }

}

[ProtoContract]
public class WORLD_CLIENT_FRIEND_ENTER_NOTIFY
{
    [ProtoMember(1)]

    public ulong enter_friend_uid { get; set; }

}

[ProtoContract]
public class CLIENT_WORLD_FRIEND_SEARCH
{
    [ProtoMember(1)]

    public string name { get; set; }
    [ProtoMember(2)]
    public int search_type { get; set; }

}

[ProtoContract]
public class WORLD_CLIENT_FRIEND_SEARCH
{
    [ProtoMember(1)]

    public int result { get; set; }
    [ProtoMember(2)]
    _friend_info_base friend_info_base { get; set; }
    [ProtoMember(3)]
    public bool online { get; set; }
    [ProtoMember(4)]
    public int search_type { get; set; }

}

[ProtoContract]
public class CLIENT_WORLD_FRIEND_FAVORITES
{
    [ProtoMember(1)]

    public ulong friend_uid { get; set; }
    [ProtoMember(2)]
    public bool favorites { get; set; }

}

[ProtoContract]
public class WORLD_CLIENT_FRIEND_FAVORITES
{
    [ProtoMember(1)]

    public int result { get; set; }
    [ProtoMember(2)]
    public ulong friend_uid { get; set; }
    [ProtoMember(3)]
    public bool favorites { get; set; }

}

[ProtoContract]
public class GAME_WORLD_FRIEND_ENTER_NOTIFY
{
    [ProtoMember(1)]

    public ulong user_uid { get; set; }
    [ProtoMember(2)]
    public ulong[] friend_list { get; set; }

}


[ProtoContract]
public class CLIENT_GAME_GACHA_INFO
{
}

[ProtoContract]
public class GAME_CLIENT_GACHA_INFO
{
    [ProtoMember(1)]

    public _gacha_info gacha_info_list { get; set; }

}

[ProtoContract]
public class CLIENT_GAME_GACHA_PULL
{
    [ProtoMember(1)]

    public uint gacha_type { get; set; }
    [ProtoMember(2)]
    public uint gacha_pull_type { get; set; } //-> 2 to 1 = free pull on certain gacha_type
    [ProtoMember(3)]
    public uint money_type { get; set; }
    [ProtoMember(4)]
    public bool is_many_count { get; set; }
    [ProtoMember(5)]
    public uint shop_goods_id { get; set; }
    [ProtoMember(6)]
    public uint shop_goods_ver { get; set; }

}

[ProtoContract]
public class GAME_CLIENT_GACHA_PULL
{
    [ProtoMember(1)]

    public int result { get; set; }
    [ProtoMember(2)]
    public _gacha_info gacha_info { get; set; }
    [ProtoMember(3)]
    public _cost_info[] costInfos { get; set; }
    [ProtoMember(4)]
    public _character_inven_item[] update_items { get; set; }
    [ProtoMember(5)]
    _stack_item_info use_item_info { get; set; }
    [ProtoMember(6)]
    public _simple_item_info[] gacha_items { get; set; }
    [ProtoMember(7)]
    public uint gacha_pull_type { get; set; }

}

[ProtoContract]
public class GAME_CLIENT_GACHA_PULL_EVENT
{
    [ProtoMember(1)]

    public int result { get; set; }
    [ProtoMember(2)]
    public _user_event_info event_info { get; set; }
    [ProtoMember(3)]
    public _cost_info[] costInfos { get; set; }
    [ProtoMember(4)]
    public _character_inven_item[] update_items { get; set; }
    [ProtoMember(5)]
    _stack_item_info use_item_info { get; set; }
    [ProtoMember(6)]
    public _simple_item_info[] gacha_items { get; set; }
    [ProtoMember(7)]
    public uint gacha_pull_type { get; set; }

}

[ProtoContract]
public class GAME_CLIENT_BONUS_GACHA_EVENT_START
{
    [ProtoMember(1)]

    public int[] gacha_types { get; set; }
    [ProtoMember(2)]
    public ulong end_time { get; set; }

}

[ProtoContract]
public class GAME_CLIENT_BONUS_GACHA_EVENT_END
{
    [ProtoMember(1)]

    public int[] gacha_types { get; set; }

}

[ProtoContract]
public class _game_option_info
{
    [ProtoMember(1)]

    public int option_type { get; set; }
    [ProtoMember(2)]
    public int value { get; set; }

}

[ProtoContract]
public class CLIENT_GAME_GAME_OPTION_LIST
{

}

[ProtoContract]
public class GAME_CLIENT_GAME_OPTION_LIST
{
    [ProtoMember(1)]

    public _game_option_info game_option_list { get; set; }

}

[ProtoContract]
public class CLIENT_GAME_CHANGE_GAME_OPTION
{
    [ProtoMember(1)]

    public int option_type { get; set; }
    [ProtoMember(2)]
    public int value { get; set; }

}

[ProtoContract]
public class GAME_CLIENT_CHANGE_GAME_OPTION
{
    [ProtoMember(1)]

    public int result { get; set; }
    [ProtoMember(2)]
    public int option_type { get; set; }
    [ProtoMember(3)]
    public int value { get; set; }

}


[ProtoContract]
public class WORLD_ALLSERVER_GM_CONTENTS_LOCK
{
    [ProtoMember(1)]

    public _gm_contents_lock[] lock_list { get; set; }

}

[ProtoContract]
public class WORLD_ALLSERVER_GM_GEN_TIME
{
    [ProtoMember(1)]

    public _gm_gen_time gen_time_list { get; set; }

}

[ProtoContract]
public class WORLD_ALLSERVER_GM_CONTROL_LIST
{
    [ProtoMember(1)]

    public _gm_contents_lock[] lock_list { get; set; }
    [ProtoMember(2)]
    public _gm_gen_time gen_time_list { get; set; }

}

[ProtoContract]
public class WORLD_GAME_CHECK_ZONE_GROUP
{
}

[ProtoContract]
public class WORLD_GAME_CHECK_ZONE
{
    [ProtoMember(1)]

    public long zone_uid { get; set; }

}

[ProtoContract]
public class WORLD_GAME_GM_OBSERVER
{
    [ProtoMember(1)]

    public long user_uid { get; set; }
    [ProtoMember(2)]
    public bool observer { get; set; }

}

[ProtoContract]
public class WORLD_GAME_GM_MONSTER_GEN
{
    [ProtoMember(1)]

    public long zone_uid { get; set; }
    [ProtoMember(2)]
    public long gen_id { get; set; }

}

[ProtoContract]
public class WORLD_GAME_GM_SPEED_HACK_REGULATION
{
    [ProtoMember(1)]

    public int regulation { get; set; }

}

[ProtoContract]
public class WORLD_GAME_GM_HACK_REGULATION
{
    [ProtoMember(1)]

    public int hack_type { get; set; }
    [ProtoMember(2)]
    public int regulation { get; set; }

}

[ProtoContract]
public class world_buff_info
{
    [ProtoMember(1)]

    public bool running { get; set; }
    [ProtoMember(2)]
    public int buff_tid { get; set; }
    [ProtoMember(3)]
    public long start_time { get; set; }
    [ProtoMember(4)]
    public long end_time { get; set; }
    [ProtoMember(5)]
    public int world_buff_tid { get; set; }

}

[ProtoContract]
public class WORLD_GAME_GM_WORLD_BUFF_ON
{
    [ProtoMember(1)]

    public bool on_off { get; set; }

}

[ProtoContract]
public class WORLD_GAME_GM_WORLD_BUFF_INFO
{
    [ProtoMember(1)]

    public bool is_add { get; set; }
    [ProtoMember(2)]
    public world_buff_info world_buff_list { get; set; }

}

[ProtoContract]
public class WORLD_GAME_GM_WORLD_BUFF_INFO_ADD
{
    [ProtoMember(1)]

    public world_buff_info world_buff_list { get; set; }

}

[ProtoContract]
public class WORLD_GAME_GM_WORLD_BUFF_INFO_DEL
{
    [ProtoMember(1)]

    public int[] buff_tid_list { get; set; }

}

[ProtoContract]
public class WORLD_GAME_GM_WORLD_BUFF_START
{
    [ProtoMember(1)]

    public int buff_tid { get; set; }
    [ProtoMember(2)]
    public long end_time { get; set; }

}

[ProtoContract]
public class WORLD_GAME_GM_WORLD_BUFF_END
{
    [ProtoMember(1)]

    public int buff_tid { get; set; }

}

[ProtoContract]
public class WORLD_GAME_GM_TRADE_ACCOUNT_LOCK
{
    [ProtoMember(1)]

    public int account_lock { get; set; }
    [ProtoMember(2)]
    public ulong[] account_list { get; set; }

}

[ProtoContract]
public class WORLD_GAME_GM_SERVER_LOCK
{
    [ProtoMember(1)]

    public int lock_type { get; set; }
    [ProtoMember(2)]
    public int is_lock { get; set; }

}

[ProtoContract]
public class WORLD_GAME_GM_CAPTCHA_REAUTH_DATA
{
    [ProtoMember(1)]

    public int reauth_on_off { get; set; }
    [ProtoMember(2)]
    public int reauth_term_min { get; set; }
    [ProtoMember(3)]
    public int reauth_level { get; set; }

}


[ProtoContract]
public class CLIENT_GAME_GREAT_BUILDING_INFO
{
}

[ProtoContract]
public class GAME_CLIENT_GREAT_BUILDING_INFO
{
    [ProtoMember(1)]

    public uint result { get; set; }
    [ProtoMember(2)]
    public _great_building_info great_building_info { get; set; }

}

[ProtoContract]
public class CLIENT_GAME_OPEN_BUILDING
{
    [ProtoMember(1)]

    public uint building_uid { get; set; }

}

[ProtoContract]
public class GAME_CLIENT_OPEN_BUILDING
{
    [ProtoMember(1)]

    public uint result { get; set; }
    [ProtoMember(2)]
    public uint building_uid { get; set; }

}

[ProtoContract]
public class CLIENT_GAME_UPGRADE_BUILDING_REQUEST
{
    [ProtoMember(1)]

    public uint building_uid { get; set; }

}

[ProtoContract]
public class GAME_CLIENT_UPGRADE_BUILDING_REQUEST
{
    [ProtoMember(1)]

    public uint result { get; set; }
    [ProtoMember(2)]
    public uint building_uid { get; set; }
    [ProtoMember(3)]
    public ulong upgrade_remain_time { get; set; }
    [ProtoMember(4)]
    public _cost_info[] cost_info { get; set; }
    [ProtoMember(5)]
    public _stack_item_info[] del_item_list { get; set; }

}

[ProtoContract]
public class GAME_CLIENT_UPGRADE_BUILDING_COMPLETE
{
    [ProtoMember(1)]

    public uint building_uid { get; set; }

}

[ProtoContract]
public class CLIENT_GAME_UPGRADE_BUILDING_REQUEST_COMPLETE
{
    [ProtoMember(1)]

    public uint building_uid { get; set; }

}

[ProtoContract]
public class GAME_CLIENT_UPGRADE_BUILDING_REQUEST_COMPLETE
{
    [ProtoMember(1)]

    public uint result { get; set; }
    [ProtoMember(2)]
    public uint building_uid { get; set; }
    [ProtoMember(3)]
    public uint result_level { get; set; }

}

[ProtoContract]
public class CLIENT_GAME_UPGRADE_ACCELERATION
{
    [ProtoMember(1)]

    public uint building_uid { get; set; }
    [ProtoMember(2)]
    public uint use_item_id { get; set; }
    [ProtoMember(3)]
    public uint point_value { get; set; }

}

[ProtoContract]
public class GAME_CLIENT_UPGRADE_ACCELERATION
{
    [ProtoMember(1)]

    public uint result { get; set; }
    [ProtoMember(2)]
    public uint building_uid { get; set; }
    [ProtoMember(3)]
    public ulong remain_time { get; set; }
    [ProtoMember(4)]
    _stack_item_info del_item { get; set; }
    [ProtoMember(5)]
    public _cost_info[] update_cost_info { get; set; }

}

[ProtoContract]
public class WORLD_GAME_BUILDING_UPGRADE_SUPPORT_NOTICE
{
    [ProtoMember(1)]

    public ulong user_uid { get; set; }
    [ProtoMember(2)]
    public upgrade_building_notice_game_data building_data_list { get; set; }

}

[ProtoContract]
public class CLIENT_GAME_HARVEST_PRODUCTS_FROM_BUILDING
{
    [ProtoMember(1)]

    public uint building_id { get; set; }

}

[ProtoContract]
public class GAME_CLIENT_HARVEST_PRODUCTS_FROM_BUILDING
{
    [ProtoMember(1)]

    public uint result { get; set; }
    [ProtoMember(2)]
    public uint building_id { get; set; }
    [ProtoMember(3)]
    public uint gain_type { get; set; }
    [ProtoMember(4)]
    public uint reward_id { get; set; }
    [ProtoMember(5)]
    public uint reward_count { get; set; }
    [ProtoMember(6)]
    public ulong last_harvest_time { get; set; }
    [ProtoMember(7)]
    public _character_inven_item[] update_item { get; set; }
    [ProtoMember(8)]
    public _cost_info[] update_cost_info { get; set; }

}

[ProtoContract]
public class GAME_CLIENT_PRODUCTION_NOTIFICATION
{
    [ProtoMember(1)]

    public uint building_id { get; set; }
    [ProtoMember(2)]
    public uint gain_type { get; set; }
    [ProtoMember(3)]
    public uint reward_id { get; set; }
    [ProtoMember(4)]
    public uint reward_count { get; set; }
    [ProtoMember(5)]
    public ulong last_harvest_time { get; set; }

}


[ProtoContract]
public class _guild_fame
{
    [ProtoMember(1)]

    public uint fame_type { get; set; }
    [ProtoMember(2)]
    public long fame_value { get; set; }

}

[ProtoContract]
public class _guild_dungeon_clrear_reward
{
    [ProtoMember(1)]

    public uint reward_type { get; set; }
    [ProtoMember(2)]
    public uint reward_type_sub { get; set; }
    [ProtoMember(3)]
    public uint reward_value { get; set; }

}

[ProtoContract]
public class CLIENT_GAME_GUILD_CREATION
{
    [ProtoMember(1)]

    public string guild_name { get; set; }
    [ProtoMember(2)]
    public uint guild_mark { get; set; }
    [ProtoMember(3)]
    public uint guild_mark_edge { get; set; }

}

[ProtoContract]
public class GAME_WORLD_GUILD_CREATION
{
    [ProtoMember(1)]

    _guild_name_ui_info guild_info { get; set; }

}

[ProtoContract]
public class WORLD_GAME_GUILD_CREATION
{
    [ProtoMember(1)]

    public ulong uid { get; set; }
    [ProtoMember(2)]
    public uint result { get; set; }
    [ProtoMember(3)]
    _guild_info guild_info { get; set; }

}

[ProtoContract]
public class GAME_CLIENT_GUILD_CREATION
{
    [ProtoMember(1)]

    public uint result { get; set; }
    [ProtoMember(2)]
    _guild_info guild_info { get; set; }
    [ProtoMember(3)]
    _cost_info cost_info { get; set; }
    [ProtoMember(4)]
    public _guild_member_authority auth_list { get; set; }

}

[ProtoContract]
public class GAME_WORLD_GUILD_CREATION_RESERVE
{
    [ProtoMember(1)]

    public ulong guild_uid { get; set; }
    [ProtoMember(2)]
    public string guild_name { get; set; }
    [ProtoMember(3)]
    public uint guild_mark { get; set; }
    [ProtoMember(4)]
    public uint guild_mark_edge { get; set; }

}

[ProtoContract]
public class WORLD_GAME_GUILD_CREATION_RESERVE
{
    [ProtoMember(1)]

    public int result { get; set; }
    [ProtoMember(2)]
    public ulong user_uid { get; set; }
    [ProtoMember(3)]
    public ulong guild_uid { get; set; }
    [ProtoMember(4)]
    public string guild_name { get; set; }
    [ProtoMember(5)]
    public uint guild_mark { get; set; }
    [ProtoMember(6)]
    public uint guild_mark_edge { get; set; }

}

[ProtoContract]
public class GAME_WORLD_GUILD_CREATION_RESERVE_CANCEL
{
    [ProtoMember(1)]

    public ulong guild_uid { get; set; }

}

[ProtoContract]
public class CLIENT_WORLD_GUILD_DELETE
{

}

[ProtoContract]
public class WORLD_CLIENT_GUILD_DELETE
{
    [ProtoMember(1)]

    public uint result { get; set; }

}

[ProtoContract]
public class GAME_WORLD_GUILD_DELETE
{
}

[ProtoContract]
public class WORLD_GAME_GUILD_DELETE
{
    [ProtoMember(1)]

    public uint result { get; set; }
    [ProtoMember(2)]
    public ulong user_uid { get; set; }
    [ProtoMember(3)]
    public ulong guild_uid { get; set; }

}

[ProtoContract]
public class CLIENT_WORLD_GUILD_SORT_LIST
{
    [ProtoMember(1)]

    public int sort_option_type { get; set; }
    [ProtoMember(2)]
    public int sort_filter_type { get; set; }
    [ProtoMember(3)]
    public int request_page { get; set; }
    [ProtoMember(4)]
    public int target_world_id { get; set; }

}

[ProtoContract]
public class GAME_WORLD_GUILD_SORT_LIST
{
    [ProtoMember(1)]

    public int sort_option_type { get; set; }
    [ProtoMember(2)]
    public int sort_filter_type { get; set; }
    [ProtoMember(3)]
    public int request_page { get; set; }
    [ProtoMember(4)]
    public int target_world_id { get; set; }
    [ProtoMember(5)]
    public uint start_world_id { get; set; }

}

[ProtoContract]
public class WORLD_GAME_GUILD_SORT_LIST
{
    [ProtoMember(1)]

    public ulong user_uid { get; set; }
    [ProtoMember(2)]
    public int request_page { get; set; }
    [ProtoMember(3)]
    public _guild_sort_info guild_search_list { get; set; }
    [ProtoMember(4)]
    public int guild_invite_count { get; set; }
    [ProtoMember(5)]
    public int guild_applicant_count { get; set; }
    [ProtoMember(6)]
    public int target_world_id { get; set; }

}

[ProtoContract]
public class WORLD_CLIENT_GUILD_SORT_LIST
{
    [ProtoMember(1)]

    public int request_page { get; set; }
    [ProtoMember(2)]
    public _guild_sort_info guild_search_list { get; set; }
    [ProtoMember(3)]
    public int guild_invite_count { get; set; }
    [ProtoMember(4)]
    public int guild_applicant_count { get; set; }
    [ProtoMember(5)]
    public int target_world_id { get; set; }

}

[ProtoContract]
public class CLIENT_WORLD_GUILD_SORT_LIST_BY_FRIENDSHIP_FIRST
{
    [ProtoMember(1)]

    public int request_page { get; set; }

}

[ProtoContract]
public class WORLD_CLIENT_GUILD_SORT_LIST_BY_FRIENDSHIP_FIRST
{
    [ProtoMember(1)]

    public int result { get; set; }
    [ProtoMember(2)]
    public int request_page { get; set; }
    [ProtoMember(3)]
    public _guild_sort_info guild_search_list { get; set; }

}

[ProtoContract]
public class CLIENT_WORLD_GUILD_MY_GUILD_INFO
{

}

[ProtoContract]
public class GAME_WORLD_GUILD_MY_GUILD_INFO
{
}

[ProtoContract]
public class _guild_grade_info
{
    [ProtoMember(1)]

    public int grade { get; set; }
    [ProtoMember(2)]
    public string grade_name { get; set; }

}

[ProtoContract]
public class _guild_hostility_info
{
    [ProtoMember(1)]

    public ulong guild_uid { get; set; }

}

[ProtoContract]
public class WORLD_CLIENT_GUILD_MY_GUILD_INFO
{
    [ProtoMember(1)]

    public uint result { get; set; }
    [ProtoMember(2)]
    _guild_info guild_data { get; set; }
    [ProtoMember(3)]
    public _guild_hostility_info hostility_list { get; set; }
    [ProtoMember(4)]
    public _guild_grade_info grade_info_list { get; set; }
    [ProtoMember(5)]
    public ulong[] alliance_list { get; set; }
    [ProtoMember(6)]
    public uint my_grade { get; set; }
    [ProtoMember(7)]
    public uint[] develop_can_levelup_index_list { get; set; }
    [ProtoMember(9)]
    public _cost_info[] guild_cost_info { get; set; }
    [ProtoMember(10)]
    public _guild_member_authority auth_list { get; set; }
    [ProtoMember(11)]
    public ulong[] guild_wanted_list { get; set; }
    [ProtoMember(12)]
    public _guild_stat_info stat_list { get; set; }
    [ProtoMember(14)]
    _guild_member_partner_info partner_member_info { get; set; }
    [ProtoMember(15)]
    public int[] dominion_list { get; set; }
    [ProtoMember(16)]
    public _guild_develop_skill_info[] develop_skill_info { get; set; }
    [ProtoMember(17)]
    public ulong[] except_attack_list { get; set; }
    [ProtoMember(18)]
    public _guild_command_mark command_mark_list { get; set; }
    [ProtoMember(19)]
    public ulong[] alliance_appliance_recv_list { get; set; }

}

[ProtoContract]
public class CLIENT_WORLD_GUILD_MY_GUILD_UI_ETC_INFO
{

}

[ProtoContract]
public class _guild_develop_group_level
{
    [ProtoMember(1)]

    public int list_group_index { get; set; }
    [ProtoMember(2)]
    public int total_level { get; set; }

}

[ProtoContract]
public class WORLD_CLIENT_GUILD_MY_GUILD_UI_ETC_INFO
{
    [ProtoMember(1)]

    public int result { get; set; }
    [ProtoMember(2)]
    public ulong guild_uid { get; set; }
    [ProtoMember(3)]
    public long guild_exp { get; set; }
    [ProtoMember(4)]
    public long total_combat_point { get; set; }
    [ProtoMember(5)]
    public int rank { get; set; }
    [ProtoMember(6)]
    public int occupation_id { get; set; }
    [ProtoMember(8)]
    public uint tendency { get; set; }
    [ProtoMember(9)]
    public _guild_develop_group_level[] develop_group_level_list { get; set; }
    [ProtoMember(10)]
    public uint[] dominion_index { get; set; }
    [ProtoMember(11)]
    public _guild_develop_skill_info[] develop_skill_info { get; set; }
    [ProtoMember(13)]
    public int recommend_id { get; set; }
    [ProtoMember(14)]
    public int member_count { get; set; }
    [ProtoMember(15)]
    public int member_max_count { get; set; }
    [ProtoMember(16)]
    public string master_name { get; set; }
    [ProtoMember(17)]
    public ulong last_box_open_time { get; set; }
    [ProtoMember(18)]
    public _sanctum_info sanctum_info { get; set; }
    [ProtoMember(19)]
    public int sabuk_guild_title_tid { get; set; }

}

[ProtoContract]
public class CLIENT_WORLD_GUILD_OTHER_GUILD_UI_INFO
{
    [ProtoMember(1)]

    public ulong guild_uid { get; set; }

}

[ProtoContract]
public class WORLD_CLIENT_GUILD_OTHER_GUILD_UI_INFO
{
    [ProtoMember(1)]

    public uint result { get; set; }
    [ProtoMember(2)]
    _guild_info guild_data { get; set; }
    [ProtoMember(3)]
    public long guild_exp { get; set; }
    [ProtoMember(7)]
    public int occupation_id { get; set; }
    [ProtoMember(8)]
    public bool is_member_invite { get; set; }
    [ProtoMember(10)]
    public bool is_member_applicant { get; set; }
    [ProtoMember(11)]
    public uint other_guild_diplomacy_state_type { get; set; }
    [ProtoMember(12)]
    public uint tendency { get; set; }
    [ProtoMember(13)]
    public _guild_develop_group_level[] develop_group_level_list { get; set; }
    [ProtoMember(14)]
    public int remain_hostility_time { get; set; }
    [ProtoMember(15)]
    public uint[] dominion_index { get; set; }
    [ProtoMember(16)]
    public _guild_develop_skill_info[] develop_skill_info { get; set; }
    [ProtoMember(17)]
    public bool is_my_guild_declare { get; set; }
    [ProtoMember(18)]
    _sanctum_info sanctum_info { get; set; }
    [ProtoMember(19)]
    public bool is_except_attack { get; set; }
    [ProtoMember(20)]
    public int sabuk_guild_title_tid { get; set; }

}

[ProtoContract]
public class CLIENT_WORLD_GUILD_JOIN_TYPE
{
    [ProtoMember(1)]

    public uint join_type { get; set; }

}

[ProtoContract]
public class WORLD_CLIENT_GUILD_JOIN_TYPE
{
    [ProtoMember(1)]

    public uint result { get; set; }
    [ProtoMember(2)]
    public uint join_type { get; set; }

}

[ProtoContract]
public class CLIENT_WORLD_GUILD_OPTION_SET
{
    [ProtoMember(1)]

    public _guild_option[] option_info { get; set; }

}

[ProtoContract]
public class GAME_WORLD_GUILD_OPTION_SET
{
    [ProtoMember(1)]

    public _guild_option[] option_info { get; set; }
    [ProtoMember(2)]
    public uint start_world_id { get; set; }

}

[ProtoContract]
public class WORLD_CLIENT_GUILD_OPTION_SET
{
    [ProtoMember(1)]

    public uint result { get; set; }
    [ProtoMember(2)]
    public _guild_option[] option_info { get; set; }

}

[ProtoContract]
public class WORLD_GAME_GUILD_OPTION_SET
{
    [ProtoMember(1)]

    public uint result { get; set; }
    [ProtoMember(2)]
    public ulong guild_uid { get; set; }
    [ProtoMember(3)]
    public _guild_option[] option_info { get; set; }
    [ProtoMember(4)]
    public ulong user_uid { get; set; }

}

[ProtoContract]
public class CLIENT_WORLD_GUILD_OPTION_LIST
{

}

[ProtoContract]
public class WORLD_CLIENT_GUILD_OPTION_LIST
{
    [ProtoMember(1)]

    public _guild_option[] guild_option_list { get; set; }
    [ProtoMember(2)]
    public uint result { get; set; }

}

[ProtoContract]
public class CLIENT_WORLD_GUILD_CHANGE_PR
{
    [ProtoMember(1)]

    public string guild_pr { get; set; }

}

[ProtoContract]
public class WORLD_CLIENT_GUILD_CHANGE_PR
{
    [ProtoMember(1)]

    public uint result { get; set; }
    [ProtoMember(2)]
    public string guild_pr { get; set; }

}

[ProtoContract]
public class GAME_WORLD_GUILD_CHANGE_PR
{
    [ProtoMember(1)]

    public string guild_pr { get; set; }
    [ProtoMember(2)]
    public ulong user_uid { get; set; }
    [ProtoMember(3)]
    public uint start_world_id { get; set; }

}

[ProtoContract]
public class WORLD_GAME_GUILD_CHANGE_PR
{
    [ProtoMember(1)]

    public int result { get; set; }
    [ProtoMember(2)]
    public ulong guild_uid { get; set; }
    [ProtoMember(3)]
    public ulong user_uid { get; set; }
    [ProtoMember(4)]
    public string guild_pr { get; set; }

}

[ProtoContract]
public class GAME_CLIENT_GUILD_MEMBER_JOIN_APPLICANT_DEL_NOTIFY
{
    [ProtoMember(1)]

    public ulong del_user_uid { get; set; }

}

[ProtoContract]
public class CLIENT_WORLD_GUILD_MY_APPLICANT_LIST
{

}

[ProtoContract]
public class GAME_WORLD_GUILD_MY_APPLICANT_LIST
{
    [ProtoMember(1)]

    public uint start_world_id { get; set; }

}

[ProtoContract]
public class WORLD_GAME_GUILD_MY_APPLICANT_LIST
{
    [ProtoMember(1)]

    public int result { get; set; }
    [ProtoMember(2)]
    public ulong user_uid { get; set; }
    [ProtoMember(3)]
    public _guild_info[] applicant_list { get; set; }
    [ProtoMember(4)]
    public long[] applicant_req_time { get; set; }

}

[ProtoContract]
public class WORLD_CLIENT_GUILD_MY_APLLICANT_LIST
{
    [ProtoMember(1)]

    public int result { get; set; }
    [ProtoMember(2)]
    public _guild_info[] applicant_list { get; set; }
    [ProtoMember(3)]
    public long[] applicant_req_time { get; set; }

}

[ProtoContract]
public class CLIENT_WORLD_GUILD_HOSTILITY_MY_GUILD_UI_LIST
{

}

[ProtoContract]
public class _my_guild_hostility_ui_info
{
    [ProtoMember(1)]

    _guild_name_ui_info name_ui_info { get; set; }
    [ProtoMember(2)]
    public string master_name { get; set; }
    [ProtoMember(3)]
    public uint level { get; set; }
    [ProtoMember(4)]
    public uint member_count { get; set; }
    [ProtoMember(5)]
    public uint max_member_count { get; set; }
    [ProtoMember(6)]
    public long combat_point { get; set; }
    [ProtoMember(7)]
    public uint kill_our_count { get; set; }
    [ProtoMember(9)]
    public uint death_count { get; set; }
    [ProtoMember(10)]
    public int remain_hostility_time { get; set; }
    [ProtoMember(11)]
    public uint guild_rank { get; set; }
    [ProtoMember(12)]
    public bool is_my_declear { get; set; }
    [ProtoMember(13)]
    public int world_id { get; set; }

}

[ProtoContract]
public class WORLD_CLIENT_GUILD_HOSTILITY_MY_GUILD_UI_LIST
{
    [ProtoMember(1)]

    public int result { get; set; }
    [ProtoMember(2)]
    public uint declare_max_count { get; set; }
    [ProtoMember(3)]
    public _my_guild_hostility_ui_info[] hostility_list { get; set; }

}

[ProtoContract]
public class CLIENT_WORLD_GUILD_HOSTILITY_ADD
{
    [ProtoMember(1)]

    public ulong target_guild_uid { get; set; }

}

[ProtoContract]
public class GAME_WORLD_GUILD_HOSTILITY_ADD
{
    [ProtoMember(1)]

    public ulong target_guild_uid { get; set; }
    [ProtoMember(2)]
    public uint start_world_id { get; set; }

}

[ProtoContract]
public class GUILD_WORLD_GUILD_HOSTILITY_ADD
{
    [ProtoMember(1)]

    public ulong user_uid { get; set; }
    [ProtoMember(2)]
    public int user_world_id { get; set; }
    [ProtoMember(3)]
    public ulong guild_uid { get; set; }
    [ProtoMember(4)]
    public ulong target_guild_uid { get; set; }
    [ProtoMember(5)]
    public long start_time { get; set; }
    [ProtoMember(6)]
    public long end_time { get; set; }
    [ProtoMember(7)]
    public uint start_world_id { get; set; }

}

[ProtoContract]
public class GUILD_WORLD_GUILD_HOSTILITY_ADD_ACK
{
    [ProtoMember(1)]

    public int result { get; set; }
    [ProtoMember(2)]
    public ulong user_uid { get; set; }
    [ProtoMember(3)]
    public int user_world_id { get; set; }
    [ProtoMember(4)]
    public ulong guild_uid { get; set; }
    [ProtoMember(5)]
    public ulong target_guild_uid { get; set; }
    [ProtoMember(6)]
    public long start_time { get; set; }
    [ProtoMember(7)]
    public long end_time { get; set; }
    [ProtoMember(8)]
    public uint start_world_id { get; set; }

}

[ProtoContract]
public class WORLD_GAME_GUILD_HOSTILITY_ADD
{
    [ProtoMember(1)]

    public int result { get; set; }
    [ProtoMember(2)]
    public ulong target_guild_uid { get; set; }
    [ProtoMember(3)]
    public ulong user_uid { get; set; }
    [ProtoMember(4)]
    _guild_hostility_info_server_sync hostility_info { get; set; }
    [ProtoMember(5)]
    _guild_name_ui_info guild_name_info { get; set; }
    [ProtoMember(6)]
    _guild_name_ui_info target_guild_name_info { get; set; }

}

[ProtoContract]
public class WORLD_CLIENT_GUILD_HOSTILITY_ADD
{
    [ProtoMember(1)]

    public int result { get; set; }
    [ProtoMember(2)]
    public ulong target_guild_uid { get; set; }
    [ProtoMember(3)]
    public long remain_time { get; set; }

}

[ProtoContract]
public class GAME_CLIENT_GUILD_HOSTILITY_ADD_MEMBER_BROADCAST
{
    [ProtoMember(1)]

    _guild_name_ui_info target_name_ui_info { get; set; }
    [ProtoMember(2)]
    public bool is_my_guild_declare { get; set; }

}

[ProtoContract]
public class WORLD_GAME_GUILD_HOSTILITY_KILL
{
    [ProtoMember(1)]

    public ulong declare_guild_uid { get; set; }
    [ProtoMember(2)]
    public ulong target_guild_uid { get; set; }
    [ProtoMember(3)]
    public int declare_kill_count { get; set; }
    [ProtoMember(4)]
    public int target_kill_count { get; set; }

}

[ProtoContract]
public class CLIENT_WORLD_GUILD_HOSTILITY_DEL
{
    [ProtoMember(1)]

    public ulong target_guild_uid { get; set; }

}

[ProtoContract]
public class GAME_WORLD_GUILD_HOSTILITY_DEL
{
    [ProtoMember(1)]

    public ulong target_guild_uid { get; set; }
    [ProtoMember(2)]
    public ulong user_uid { get; set; }
    [ProtoMember(3)]
    public uint start_world_id { get; set; }

}

[ProtoContract]
public class WORLD_GAME_GUILD_HOSTILITY_DEL
{
    [ProtoMember(1)]

    public uint result { get; set; }
    [ProtoMember(2)]
    public ulong user_uid { get; set; }
    [ProtoMember(3)]
    public ulong guild_uid { get; set; }
    [ProtoMember(4)]
    public ulong target_guild_uid { get; set; }
    [ProtoMember(5)]
    _guild_name_ui_info guild_name_info { get; set; }
    [ProtoMember(6)]
    _guild_name_ui_info target_guild_name_info { get; set; }

}

[ProtoContract]
public class GUILD_WORLD_GUILD_HOSTILITY_DEL
{
    [ProtoMember(1)]

    public ulong declare_guild_uid { get; set; }
    [ProtoMember(2)]
    public ulong target_guild_uid { get; set; }
    [ProtoMember(3)]
    public ulong user_uid { get; set; }

}

[ProtoContract]
public class WORLD_CLIENT_GUILD_HOSTILITY_DEL
{
    [ProtoMember(1)]

    public uint result { get; set; }
    [ProtoMember(2)]
    public ulong target_guild_uid { get; set; }
    [ProtoMember(3)]
    _guild_name_ui_info target_name_ui_info { get; set; }

}

[ProtoContract]
public class GAME_CLIENT_GUILD_HOSTILITY_DEL_MEMBER_BROADCAST
{
    [ProtoMember(1)]

    public ulong target_guild_uid { get; set; }
    [ProtoMember(2)]
    _guild_name_ui_info target_name_ui_info { get; set; }
    [ProtoMember(3)]
    public ulong declare_guild_uid { get; set; }

}

[ProtoContract]
public class GAME_WORLD_GUILD_KILL_NOTI
{
    [ProtoMember(1)]

    public ulong kill_user_uid { get; set; }
    [ProtoMember(2)]
    public ulong die_user_uid { get; set; }
    [ProtoMember(3)]
    public ulong kill_user_guild_uid { get; set; }
    [ProtoMember(4)]
    public ulong die_user_guild_uid { get; set; }
    [ProtoMember(5)]
    public uint start_world_id { get; set; }

}

[ProtoContract]
public class GUILD_WORLD_GUILD_HOSTILTY_KILL_NOTI
{
    [ProtoMember(1)]

    public ulong kill_user_uid { get; set; }
    [ProtoMember(2)]
    public ulong die_user_uid { get; set; }
    [ProtoMember(3)]
    public ulong kill_user_guild_uid { get; set; }
    [ProtoMember(4)]
    public ulong die_user_guild_uid { get; set; }
    [ProtoMember(5)]
    public int kill_guild_kill_count { get; set; }
    [ProtoMember(6)]
    public uint start_world_id { get; set; }

}

[ProtoContract]
public class GAME_CLIENT_GUILD_JOIN_FIELD_BROADCAST
{
    [ProtoMember(1)]

    public ulong uid { get; set; }
    [ProtoMember(2)]
    _guild_name_ui_info guild_info { get; set; }

}

[ProtoContract]
public class CLIENT_WORLD_GUILD_GRADE_INFO_SET
{
    [ProtoMember(1)]

    public uint grade { get; set; }
    [ProtoMember(2)]
    public string grade_name { get; set; }

}

[ProtoContract]
public class WORLD_CLIENT_GUILD_GRADE_INFO_SET
{
    [ProtoMember(1)]

    public int result { get; set; }
    [ProtoMember(2)]
    public string grade_name { get; set; }
    [ProtoMember(3)]
    public uint grade { get; set; }

}

[ProtoContract]
public class CLIENT_WORLD_GUILD_NAME_CHANGE
{
    [ProtoMember(1)]

    public string guild_name { get; set; }
    [ProtoMember(2)]
    public uint guild_mark { get; set; }
    [ProtoMember(3)]
    public uint guild_mark_edge { get; set; }
    [ProtoMember(4)]
    public bool is_change_type_mark { get; set; }

}

[ProtoContract]
public class GAME_WORLD_GUILD_NAME_CHANGE
{
    [ProtoMember(1)]

    public string guild_name { get; set; }
    [ProtoMember(2)]
    public uint guild_mark { get; set; }
    [ProtoMember(3)]
    public uint guild_mark_edge { get; set; }
    [ProtoMember(4)]
    public bool is_change_type_mark { get; set; }
    [ProtoMember(5)]
    public _cost_info[] use_cost { get; set; }
    [ProtoMember(6)]
    public uint start_world_id { get; set; }

}

[ProtoContract]
public class WORLD_GAME_GUILD_NAME_CHANGE
{
    [ProtoMember(1)]

    public int result { get; set; }
    [ProtoMember(2)]
    _guild_name_ui_info guild_info { get; set; }
    [ProtoMember(3)]
    public bool is_change_type_mark { get; set; }
    [ProtoMember(4)]
    public ulong user_uid { get; set; }
    [ProtoMember(5)]
    public _cost_info[] use_cost { get; set; }

}

[ProtoContract]
public class WORLD_CLIENT_GUILD_NAME_CHANGE
{
    [ProtoMember(1)]

    public int result { get; set; }
    [ProtoMember(2)]
    _guild_name_ui_info guild_info { get; set; }
    [ProtoMember(3)]
    _cost_info costInfo { get; set; }
    [ProtoMember(4)]
    public bool is_change_type_mark { get; set; }

}

[ProtoContract]
public class GAME_CLIENT_GUILD_NAME_CHANGE_FIELD_BROADCAST
{
    [ProtoMember(1)]

    _guild_name_ui_info guild_info { get; set; }

}

[ProtoContract]
public class GAME_WORLD_GUILD_COST_INCREASE
{
    [ProtoMember(1)]

    public uint add_action_type { get; set; }
    [ProtoMember(2)]
    _cost_info Increase_guild_cost_info { get; set; }
    [ProtoMember(3)]
    public int money_log_event_type { get; set; }
    [ProtoMember(4)]
    public uint start_world_id { get; set; }

}

[ProtoContract]
public class WORLD_GAME_GUILD_COST
{
    [ProtoMember(1)]

    public ulong guild_uid { get; set; }
    [ProtoMember(2)]
    public _cost_info[] guild_cost_info { get; set; }

}

[ProtoContract]
public class GAME_CLIENT_GUILD_COST
{
    [ProtoMember(1)]

    public _cost_info[] guild_cost_info { get; set; }

}

[ProtoContract]
public class GAME_WORLD_GUILD_COST_USE_EVENT
{
    [ProtoMember(1)]

    public ulong guild_uid { get; set; }
    [ProtoMember(2)]
    public ulong zone_id { get; set; }
    [ProtoMember(3)]
    public int zone_group_id { get; set; }
    [ProtoMember(4)]
    public int contents_event_type { get; set; }
    [ProtoMember(5)]
    public long contents_event_value { get; set; }
    [ProtoMember(6)]
    public _cost_info[] use_cost_info { get; set; }
    [ProtoMember(7)]
    public int money_log_event_type { get; set; }
    [ProtoMember(8)]
    public ulong user_uid { get; set; }
    [ProtoMember(9)]
    public uint start_world_id { get; set; }

}

[ProtoContract]
public class WORLD_GAME_GUILD_COST_USE_EVENT
{
    [ProtoMember(1)]

    public int result { get; set; }
    [ProtoMember(2)]
    public ulong guild_uid { get; set; }
    [ProtoMember(3)]
    public ulong zone_id { get; set; }
    [ProtoMember(4)]
    public int contents_event_type { get; set; }
    [ProtoMember(5)]
    public long contents_event_value { get; set; }
    [ProtoMember(6)]
    public _cost_info[] use_cost_info { get; set; }

}

[ProtoContract]
public class CLIENT_GAME_GUILD_DONATION_INFO
{
}

[ProtoContract]
public class GAME_CLIENT_GUILD_DONATION_INFO
{
    [ProtoMember(1)]

    public _character_guild_donation_info[] char_guild_donation_list { get; set; }

}

[ProtoContract]
public class CLIENT_GAME_GUILD_DONATION_DETAIL_INFO_LIST
{

}

[ProtoContract]
public class member_donation_detail_info
{
    [ProtoMember(1)]

    public ulong user_uid { get; set; }
    [ProtoMember(2)]
    public _cost_info[] daily_donation_cost { get; set; }
    [ProtoMember(3)]
    public _cost_info[] weekly_donation_cost { get; set; }

}

[ProtoContract]
public class GAME_CLIENT_GUILD_DONATION_DETAIL_INFO_LIST
{
    [ProtoMember(1)]

    public int result { get; set; }
    [ProtoMember(2)]
    public member_donation_detail_info detail_list { get; set; }

}

[ProtoContract]
public class CLIENT_GAME_GUILD_DONATION
{
    [ProtoMember(1)]

    public int cost_type { get; set; }
    [ProtoMember(2)]
    public int cost_value { get; set; }

}

[ProtoContract]
public class GAME_WORLD_GUILD_DONATION
{
    [ProtoMember(1)]

    public int cost_type { get; set; }
    [ProtoMember(2)]
    public int cost_value { get; set; }
    [ProtoMember(3)]
    public _cost_info[] use_cost_info { get; set; }
    [ProtoMember(4)]
    public int guild_give_cost_type { get; set; }
    [ProtoMember(5)]
    public int guild_give_cost_value { get; set; }
    [ProtoMember(6)]
    _reward_cost_info user_reward_cost { get; set; }
    [ProtoMember(7)]
    public uint start_world_id { get; set; }

}

[ProtoContract]
public class WORLD_GAME_GUILD_DONATION
{
    [ProtoMember(1)]

    public int result { get; set; }
    [ProtoMember(2)]
    public ulong user_uid { get; set; }
    [ProtoMember(3)]
    public int cost_type { get; set; }
    [ProtoMember(4)]
    public int cost_value { get; set; }
    [ProtoMember(5)]
    public _cost_info[] use_cost_info { get; set; }
    [ProtoMember(6)]
    _reward_cost_info user_reward_cost { get; set; }

}

[ProtoContract]
public class GAME_CLIENT_GUILD_DONATION
{
    [ProtoMember(1)]

    public int result { get; set; }
    [ProtoMember(2)]
    public _cost_info use_cost { get; set; }
    [ProtoMember(3)]
    public _reward_cost_info user_reward_cost { get; set; }

}

[ProtoContract]
public class GAME_CLIENT_GUILD_DONATION_SYNC
{
    [ProtoMember(1)]

    public _cost_info[] costInfo { get; set; }
    [ProtoMember(2)]
    _character_guild_donation_info donation_info { get; set; }

}

[ProtoContract]
public class CLIENT_GAME_GUILD_COST_GIVE
{
    [ProtoMember(1)]

    public ulong target_user_uid { get; set; }
    [ProtoMember(2)]
    public int cost_type { get; set; }
    [ProtoMember(3)]
    public int cost_value { get; set; }

}

[ProtoContract]
public class GAME_WORLD_GUILD_COST_GIVE
{
    [ProtoMember(1)]

    public ulong target_user_uid { get; set; }
    [ProtoMember(2)]
    public int cost_type { get; set; }
    [ProtoMember(3)]
    public int cost_value { get; set; }
    [ProtoMember(4)]
    public uint start_world_id { get; set; }

}

[ProtoContract]
public class WORLD_GAME_GUILD_COST_GIVE
{
    [ProtoMember(1)]

    public int result { get; set; }
    [ProtoMember(2)]
    public ulong user_uid { get; set; }

}

[ProtoContract]
public class GAME_CLIENT_GUILD_COST_GIVE
{
    [ProtoMember(1)]

    public int result { get; set; }

}

[ProtoContract]
public class CLIENT_GAME_GUILD_COST_GIVE_TO_OTHER_USER
{
    [ProtoMember(1)]

    public ulong[] target_user_uid_list { get; set; }
    [ProtoMember(2)]
    public int cost_type { get; set; }
    [ProtoMember(3)]
    public int cost_value { get; set; }
    [ProtoMember(4)]
    public bool is_my_guild_member { get; set; }

}

[ProtoContract]
public class GAME_WORLD_GUILD_COST_GIVE_TO_OTHER_USER
{
    [ProtoMember(1)]

    public ulong[] target_user_uid_list { get; set; }
    [ProtoMember(2)]
    public int cost_type { get; set; }
    [ProtoMember(3)]
    public int cost_value { get; set; }
    [ProtoMember(4)]
    public bool is_my_guild_member { get; set; }
    [ProtoMember(5)]
    public uint start_world_id { get; set; }

}

[ProtoContract]
public class _guild_cost_give_target_user_name
{
    [ProtoMember(1)]

    public ulong user_uid { get; set; }
    [ProtoMember(2)]
    public string character_name { get; set; }
    [ProtoMember(3)]
    _cost_info can_recv_limit { get; set; }

}

[ProtoContract]
public class WORLD_GAME_GUILD_COST_GIVE_TO_OTHER_USER
{
    [ProtoMember(1)]

    public int result { get; set; }
    [ProtoMember(2)]
    public ulong user_uid { get; set; }
    [ProtoMember(3)]
    public _guild_cost_give_target_user_name[] target_user_list { get; set; }
    [ProtoMember(4)]
    public _guild_cost_give_target_user_name[] target_user_fail_list { get; set; }
    [ProtoMember(5)]
    public bool is_my_guild_member { get; set; }
    [ProtoMember(6)]
    public _character_guild_receive_cost_by_user_uid_server_sync[] receive_cost_sync_info { get; set; }

}

[ProtoContract]
public class GAME_CLIENT_GUILD_COST_GIVE_TO_OTHER_USER
{
    [ProtoMember(1)]

    public int result { get; set; }
    [ProtoMember(2)]
    public _guild_cost_give_target_user_name[] target_user_list { get; set; }
    [ProtoMember(4)]
    public _guild_cost_give_target_user_name[] target_user_fail_list { get; set; }
    [ProtoMember(5)]
    public bool is_my_guild_member { get; set; }

}

[ProtoContract]
public class CLIENT_GAME_GUILD_COST_GIVE_TO_OTHER_GUILD
{
    [ProtoMember(1)]

    public ulong[] target_guild_uid_list { get; set; }
    [ProtoMember(2)]
    public int cost_type { get; set; }
    [ProtoMember(3)]
    public int cost_value { get; set; }

}

[ProtoContract]
public class GAME_WORLD_GUILD_COST_GIVE_TO_OTHER_GUILD
{
    [ProtoMember(1)]

    public ulong[] target_guild_uid_list { get; set; }
    [ProtoMember(2)]
    public int cost_type { get; set; }
    [ProtoMember(3)]
    public int cost_value { get; set; }
    [ProtoMember(4)]
    public uint start_world_id { get; set; }

}

[ProtoContract]
public class WORLD_GAME_GUILD_COST_GIVE_TO_OTHER_GUILD
{
    [ProtoMember(1)]

    public int result { get; set; }
    [ProtoMember(2)]
    public ulong user_uid { get; set; }
    [ProtoMember(3)]
    public ulong[] target_guild_uid_list { get; set; }
    [ProtoMember(4)]
    public ulong[] target_guild_uid_fail_list { get; set; }

}

[ProtoContract]
public class GAME_CLIENT_GUILD_COST_GIVE_TO_OTHER_GUILD
{
    [ProtoMember(1)]

    public int result { get; set; }
    [ProtoMember(2)]
    public _guild_name_ui_info target_guild_list { get; set; }
    [ProtoMember(3)]
    public _guild_name_ui_info target_guild_fail_list { get; set; }

}

[ProtoContract]
public class CLIENT_GAME_GUILD_COST_EXCHANGE
{
    [ProtoMember(1)]

    public int send_cost_type { get; set; }
    [ProtoMember(2)]
    public int exchange_cost_type { get; set; }
    [ProtoMember(3)]
    public long cost_value { get; set; }

}

[ProtoContract]
public class GAME_WORLD_GUILD_COST_EXCHANGE
{
    [ProtoMember(1)]

    public int send_cost_type { get; set; }
    [ProtoMember(2)]
    public int exchange_cost_type { get; set; }
    [ProtoMember(3)]
    public long cost_value { get; set; }
    [ProtoMember(4)]
    public uint start_world_id { get; set; }

}

[ProtoContract]
public class WORLD_GAME_GUILD_COST_EXCHANGE
{
    [ProtoMember(1)]

    public int result { get; set; }
    [ProtoMember(2)]
    public ulong user_uid { get; set; }

}

[ProtoContract]
public class GAME_CLIENT_GUILD_COST_EXCHANGE
{
    [ProtoMember(1)]

    public int result { get; set; }

}

[ProtoContract]
public class GAME_CLIENT_GUILD_LEVELUP_BROADCAST
{
    [ProtoMember(1)]

    public ulong guild_uid { get; set; }
    [ProtoMember(2)]
    public int guild_level { get; set; }
    [ProtoMember(3)]
    public ulong guild_exp { get; set; }

}

[ProtoContract]
public class WORLD_GAME_GUILD_LEVEL_SYNC
{
    [ProtoMember(1)]

    public ulong guild_uid { get; set; }
    [ProtoMember(2)]
    public int guild_level { get; set; }
    [ProtoMember(3)]
    public ulong guild_exp { get; set; }

}

[ProtoContract]
public class CLIENT_WORLD_GUILD_ALLIANCE_LIST
{
    [ProtoMember(1)]

    public bool is_guild_inven { get; set; }

}

[ProtoContract]
public class WORLD_CLIENT_GUILD_ALLIANCE_LIST
{
    [ProtoMember(1)]

    public int result { get; set; }
    [ProtoMember(2)]
    public _guild_info[] alliance_list { get; set; }
    [ProtoMember(3)]
    public _guild_info[] alliance_receive_applicant_list { get; set; }
    [ProtoMember(4)]
    public _guild_info[] alliance_applicant_list { get; set; }

}

[ProtoContract]
public class CLIENT_WORLD_GUILD_ALLIANCE_APPLICANT
{
    [ProtoMember(1)]

    public ulong target_guild_uid { get; set; }

}

[ProtoContract]
public class GAME_WORLD_GUILD_ALLIANCE_APPLICANT
{
    [ProtoMember(1)]

    public ulong target_guild_uid { get; set; }
    [ProtoMember(2)]
    public uint start_world_id { get; set; }

}

[ProtoContract]
public class GUILD_WORLD_GUILD_ALLIANCE_APPLICANT
{
    [ProtoMember(1)]

    public ulong user_uid { get; set; }
    [ProtoMember(2)]
    public ulong guild_uid { get; set; }
    [ProtoMember(3)]
    public ulong target_guild_uid { get; set; }
    [ProtoMember(4)]
    public int guild_world_id { get; set; }
    [ProtoMember(5)]
    public int target_guild_world_id { get; set; }

}

[ProtoContract]
public class WORLD_CLIENT_GUILD_ALLIANCE_APPLICANT
{
    [ProtoMember(1)]

    public int result { get; set; }
    [ProtoMember(2)]
    public ulong target_guild_uid { get; set; }

}

[ProtoContract]
public class WORLD_CLIENT_GUILD_ALLIANCE_APPLICANT_TO_TARGET
{
    [ProtoMember(1)]

    public ulong applicant_guild_uid { get; set; }

}

[ProtoContract]
public class CLIENT_WORLD_GUILD_ALLIANCE_APPLICANT_AGREE
{
    [ProtoMember(1)]

    public ulong target_guild_uid { get; set; }
    [ProtoMember(2)]
    public bool is_agree { get; set; }

}

[ProtoContract]
public class GAME_WORLD_GUILD_ALLIANCE_APPLICANT_AGREE
{
    [ProtoMember(1)]

    public ulong target_guild_uid { get; set; }
    [ProtoMember(2)]
    public bool is_agree { get; set; }
    [ProtoMember(3)]
    public uint start_world_id { get; set; }

}

[ProtoContract]
public class GUILD_WORLD_GUILD_ALLIANCE_APPLICANT_AGREE
{
    [ProtoMember(1)]

    public ulong user_uid { get; set; }
    [ProtoMember(2)]
    public int user_world_id { get; set; }
    [ProtoMember(3)]
    public ulong guild_uid { get; set; }
    [ProtoMember(4)]
    public ulong target_guild_uid { get; set; }
    [ProtoMember(5)]
    public bool is_agree { get; set; }
    [ProtoMember(6)]
    public uint start_world_id { get; set; }

}

[ProtoContract]
public class GUILD_WORLD_GUILD_ALLIANCE_APPLICANT_AGREE_ACK
{
    [ProtoMember(1)]

    public int result { get; set; }
    [ProtoMember(2)]
    public ulong user_uid { get; set; }
    [ProtoMember(3)]
    public int user_world_id { get; set; }
    [ProtoMember(4)]
    public ulong guild_uid { get; set; }
    [ProtoMember(5)]
    public ulong target_guild_uid { get; set; }
    [ProtoMember(6)]
    public bool is_agree { get; set; }

}

[ProtoContract]
public class WORLD_GAME_GUILD_ALLIANCE_APPLICANT_AGREE
{
    [ProtoMember(1)]

    public int result { get; set; }
    [ProtoMember(2)]
    public ulong user_uid { get; set; }
    [ProtoMember(3)]
    public ulong target_guild_uid { get; set; }
    [ProtoMember(4)]
    public bool is_agree { get; set; }
    [ProtoMember(5)]
    public ulong applicant_guild_uid { get; set; }
    [ProtoMember(6)]
    public ulong applicant_recv_guild_uid { get; set; }
    [ProtoMember(7)]
    public int applicant_guild_world_id { get; set; }
    [ProtoMember(8)]
    public int applicant_recv_guild_world_id { get; set; }
    [ProtoMember(9)]
    _guild_name_ui_info applicant_guild_name_info { get; set; }
    [ProtoMember(10)]
    _guild_name_ui_info applicant_recv_guild_name_info { get; set; }

}

[ProtoContract]
public class WORLD_CLIENT_GUILD_ALLIANCE_APPLICANT_AGREE
{
    [ProtoMember(1)]

    public int result { get; set; }
    [ProtoMember(2)]
    public ulong target_guild_uid { get; set; }
    [ProtoMember(3)]
    public bool is_agree { get; set; }

}

[ProtoContract]
public class GAME_CLIENT_GUILD_ALLIANCE_ADD_BROADCAST
{
    [ProtoMember(1)]

    public ulong target_guild_uid { get; set; }
    [ProtoMember(2)]
    public string alliance_guild_name { get; set; }
    [ProtoMember(3)]
    public uint world_id { get; set; }

}

[ProtoContract]
public class CLIENT_WORLD_GUILD_ALLIANCE_APPLICANT_CANCEL
{
    [ProtoMember(1)]

    public ulong target_guild_uid { get; set; }

}

[ProtoContract]
public class GAME_WORLD_GUILD_ALLIANCE_APPLICANT_CANCEL
{
    [ProtoMember(1)]

    public ulong target_guild_uid { get; set; }
    [ProtoMember(2)]
    public uint start_world_id { get; set; }

}

[ProtoContract]
public class WORLD_GAME_GUILD_ALLIANCE_APPLICANT_CANCEL
{
    [ProtoMember(1)]

    public int result { get; set; }
    [ProtoMember(2)]
    public ulong user_uid { get; set; }
    [ProtoMember(3)]
    public ulong applicant_guild_uid { get; set; }
    [ProtoMember(4)]
    public ulong target_guild_uid { get; set; }

}

[ProtoContract]
public class WORLD_CLIENT_GUILD_ALLIANCE_APPLICANT_CANCEL
{
    [ProtoMember(1)]

    public int result { get; set; }
    [ProtoMember(2)]
    public ulong target_guild_uid { get; set; }

}

[ProtoContract]
public class GUILD_WORLD_GUILD_ALLIANCE_APPLICANT_CANCEL
{
    [ProtoMember(1)]

    public ulong applicant_guild_uid { get; set; }
    [ProtoMember(2)]
    public ulong target_guild_uid { get; set; }

}

[ProtoContract]
public class GAME_CLIENT_GUILD_ALLIANCE_APPLICANT_DEL_NOTI
{
    [ProtoMember(1)]

    public ulong applicant_guild_uid { get; set; }

}

[ProtoContract]
public class CLIENT_WORLD_GUILD_ALLIANCE_DEL
{
    [ProtoMember(1)]

    public ulong target_guild_uid { get; set; }

}

[ProtoContract]
public class GAME_WORLD_GUILD_ALLIANCE_DEL
{
    [ProtoMember(1)]

    public ulong target_guild_uid { get; set; }
    [ProtoMember(2)]
    public uint start_world_id { get; set; }

}

[ProtoContract]
public class GUILD_WORLD_GUILD_ALLIANCE_DEL
{
    [ProtoMember(1)]

    public ulong target_guild_uid { get; set; }
    [ProtoMember(2)]
    public ulong guild_uid { get; set; }

}

[ProtoContract]
public class WORLD_CLIENT_GUILD_ALLIANCE_DEL
{
    [ProtoMember(1)]

    public int result { get; set; }
    [ProtoMember(2)]
    public ulong target_guild_uid { get; set; }

}

[ProtoContract]
public class WORLD_GAME_GUILD_ALLIANCE_DEL
{
    [ProtoMember(1)]

    public int result { get; set; }
    [ProtoMember(2)]
    public ulong user_uid { get; set; }
    [ProtoMember(3)]
    public ulong guild_uid { get; set; }
    [ProtoMember(4)]
    public ulong target_guild_uid { get; set; }
    [ProtoMember(5)]
    _guild_name_ui_info guild_name_info { get; set; }
    [ProtoMember(6)]
    _guild_name_ui_info target_guild_name_info { get; set; }

}

[ProtoContract]
public class GAME_CLIENT_GUILD_ALLIANCE_DEL_BROADCAST
{
    [ProtoMember(1)]

    public ulong target_guild_uid { get; set; }
    [ProtoMember(2)]
    public string alliance_guild_name { get; set; }

}

[ProtoContract]
public class WORLD_GAME_GUILD_ALLIANCE_APPLICANT
{
    [ProtoMember(1)]

    public int result { get; set; }
    [ProtoMember(2)]
    public ulong user_uid { get; set; }
    [ProtoMember(3)]
    public ulong applicant_guild_uid { get; set; }
    [ProtoMember(4)]
    public ulong target_guild_uid { get; set; }
    [ProtoMember(5)]
    public int applicant_guild_world_id { get; set; }
    [ProtoMember(6)]
    public int target_guild_world_id { get; set; }

}

[ProtoContract]
public class CLIENT_GAME_GUILD_SUPPLY_TIME
{
}

[ProtoContract]
public class guild_supply_time
{
    [ProtoMember(1)]

    public uint index { get; set; }
    [ProtoMember(2)]
    public long remain_time { get; set; }

}

[ProtoContract]
public class GAME_CLIENT_GUILD_SUPPLY_TIME
{
    [ProtoMember(1)]

    public guild_supply_time supply_info { get; set; }

}

[ProtoContract]
public class CLIENT_GAME_GUILD_SUPPLY_GET
{
    [ProtoMember(1)]

    public uint index { get; set; }

}

[ProtoContract]
public class GAME_CLIENT_GUILD_SUPPLY_GET
{
    [ProtoMember(1)]

    public int result { get; set; }
    [ProtoMember(2)]
    guild_supply_time supply_info { get; set; }
    [ProtoMember(3)]
    public _character_inven_item[] update_item { get; set; }

}

[ProtoContract]
public class WORLD_GAME_GUILD_SUPPLY_UNLOCK
{
    [ProtoMember(1)]

    public ulong guild_uid { get; set; }
    [ProtoMember(2)]
    public supply_unlock_time unlock_list { get; set; }

}

[ProtoContract]
public class GAME_CLIENT_GUILD_STAT_CHANGE
{
    [ProtoMember(1)]

    public _guild_stat_info stat_list { get; set; }

}

[ProtoContract]
public class CLIENT_WORLD_GUILD_WANTED_LIST
{
}

[ProtoContract]
public class _guild_wanted_list_info
{
    [ProtoMember(1)]

    public ulong user_uid { get; set; }
    [ProtoMember(2)]
    public string nick_name { get; set; }
    [ProtoMember(3)]
    public int class_id { get; set; }
    [ProtoMember(4)]
    public string profile { get; set; }
    [ProtoMember(5)]
    public uint level { get; set; }
    [ProtoMember(6)]
    public uint fame_level { get; set; }
    [ProtoMember(7)]
    public int combat_point { get; set; }
    [ProtoMember(8)]
    public uint wanted_grade { get; set; }
    [ProtoMember(9)]
    public int end_time { get; set; }
    [ProtoMember(10)]
    public int kill_count { get; set; }
    [ProtoMember(11)]
    public uint rank { get; set; }
    [ProtoMember(12)]
    public uint locate { get; set; }
    [ProtoMember(13)]
    public bool is_login { get; set; }
    [ProtoMember(14)]
    public bool is_trans_server { get; set; }
    [ProtoMember(15)]
    public int kill_count_limit { get; set; }
    [ProtoMember(16)]
    public int current_server_pos { get; set; }

}

[ProtoContract]
public class WORLD_CLIENT_GUILD_WANTED_LIST
{
    [ProtoMember(1)]

    public int result { get; set; }
    [ProtoMember(2)]
    public _guild_wanted_list_info wanted_list { get; set; }
    [ProtoMember(3)]
    public int wanted_max_count { get; set; }

}

[ProtoContract]
public class CLIENT_WORLD_GUILD_WANTED_ADD
{
    [ProtoMember(1)]

    public ulong target_user_uid { get; set; }
    [ProtoMember(2)]
    public uint wanted_grade { get; set; }
    [ProtoMember(3)]
    public int kill_count_limit { get; set; }

}

[ProtoContract]
public class GAME_WORLD_GUILD_WANTED_ADD
{
    [ProtoMember(1)]

    public ulong target_user_uid { get; set; }
    [ProtoMember(2)]
    public uint wanted_grade { get; set; }
    [ProtoMember(3)]
    public int kill_count_limit { get; set; }

}

[ProtoContract]
public class WORLD_CLIENT_GUILD_WANTED_ADD
{
    [ProtoMember(1)]

    public int result { get; set; }
    [ProtoMember(2)]
    public ulong target_user_uid { get; set; }
    [ProtoMember(3)]
    public uint wanted_grade { get; set; }
    [ProtoMember(4)]
    public int kill_count_limit { get; set; }

}

[ProtoContract]
public class WORLD_GAME_GUILD_WANTED_ADD
{
    [ProtoMember(1)]

    public int result { get; set; }
    [ProtoMember(2)]
    public ulong user_uid { get; set; }
    [ProtoMember(3)]
    public ulong guild_uid { get; set; }
    [ProtoMember(4)]
    public ulong target_user_uid { get; set; }
    [ProtoMember(5)]
    public uint wanted_grade { get; set; }
    [ProtoMember(6)]
    public long start_time { get; set; }
    [ProtoMember(7)]
    public long end_time { get; set; }
    [ProtoMember(8)]
    public int kill_count_limit { get; set; }

}

[ProtoContract]
public class GAME_CLIENT_GUILD_WANTED_ADD_BROADCAST
{
    [ProtoMember(1)]

    public ulong target_user_uid { get; set; }

}

[ProtoContract]
public class WORLD_GAME_GUILD_WANTED_DEL
{
    [ProtoMember(1)]

    public ulong guild_uid { get; set; }
    [ProtoMember(2)]
    public ulong target_user_uid { get; set; }

}

[ProtoContract]
public class GAME_CLIENT_GUILD_WANTED_DEL_BROADCAST
{
    [ProtoMember(1)]

    public ulong target_user_uid { get; set; }

}

[ProtoContract]
public class WORLD_GAME_GUILD_WANTED_KILL_BROADCAST
{
    [ProtoMember(1)]

    public ulong guild_uid { get; set; }
    [ProtoMember(2)]
    public ulong target_user_uid { get; set; }
    [ProtoMember(3)]
    public int kill_count { get; set; }

}

[ProtoContract]
public class GAME_WORLD_GUILD_EXP_ADD
{
    [ProtoMember(1)]

    public ulong guild_uid { get; set; }
    [ProtoMember(2)]
    public int add_exp { get; set; }
    [ProtoMember(3)]
    public ulong user_uid { get; set; }
    [ProtoMember(4)]
    public uint start_world_id { get; set; }

}

[ProtoContract]
public class CLIENT_GAME_GUILD_HISTORY_LIST
{
    [ProtoMember(1)]

    public ulong guild_uid { get; set; }
    [ProtoMember(2)]
    public int history_group_id { get; set; }
    [ProtoMember(3)]
    public long cur_page_first_history_uid { get; set; }
    [ProtoMember(4)]
    public long cur_page_last_history_uid { get; set; }
    [ProtoMember(5)]
    public int cur_page { get; set; }
    [ProtoMember(6)]
    public bool is_next_page { get; set; }
    [ProtoMember(7)]
    public int history_sub_group_id { get; set; }

}

[ProtoContract]
public class _guild_history_info
{
    [ProtoMember(1)]

    public long history_uid { get; set; }
    [ProtoMember(2)]
    public int history_index { get; set; }
    [ProtoMember(3)]
    public long history_time { get; set; }
    [ProtoMember(4)]
    public ulong member_uid { get; set; }
    [ProtoMember(5)]
    public _history_param param_list { get; set; }
    [ProtoMember(6)]
    public _reward_cost_info[] cost_info { get; set; }

}

[ProtoContract]
public class GAME_CLIENT_GUILD_HISTORY_LIST
{
    [ProtoMember(1)]

    public int result { get; set; }
    [ProtoMember(2)]
    public ulong guild_uid { get; set; }
    [ProtoMember(3)]
    public int history_group_id { get; set; }
    [ProtoMember(4)]
    public int page { get; set; }
    [ProtoMember(5)]
    public _guild_history_info history_list { get; set; }
    [ProtoMember(6)]
    public int guild_shop_remaining_time { get; set; }
    [ProtoMember(7)]
    public int history_sub_group_id { get; set; }

}

[ProtoContract]
public class GUILD_WORLD_GUILD_HISTORY_REQ_TO_HOME_WORLD
{
    [ProtoMember(1)]

    public ulong guild_uid { get; set; }
    [ProtoMember(2)]
    _guild_history_info guild_history_info { get; set; }

}

[ProtoContract]
public class CLIENT_GAME_GUILD_INVEN_UI_INFO
{
}

[ProtoContract]
public class GAME_CLIENT_GUILD_INVEN_UI_INFO
{
    [ProtoMember(1)]

    public int result { get; set; }
    [ProtoMember(2)]
    public int guild_shop_state { get; set; }

}

[ProtoContract]
public class GAME_WORLD_GUILD_DUNGEON_CLREAR_REWARD
{
    [ProtoMember(1)]

    public ulong guild_uid { get; set; }
    [ProtoMember(2)]
    public _guild_dungeon_clrear_reward guild_reward_list { get; set; }
    [ProtoMember(3)]
    public uint dungeon_id { get; set; }
    [ProtoMember(4)]
    public uint dungeon_kind { get; set; }
    [ProtoMember(5)]
    public ulong user_uid { get; set; }

}

[ProtoContract]
public class CLIENT_GAME_GUILD_FRIENDSHIP_LIST
{
    [ProtoMember(1)]

    public bool is_guild_inven { get; set; }
    [ProtoMember(2)]
    public int receive_money_limit_type { get; set; }

}

[ProtoContract]
public class GAME_CLIENT_GUILD_FRIENDSHIP_LIST
{
    [ProtoMember(1)]

    public int result { get; set; }
    [ProtoMember(2)]
    public _guild_friendship_info friendship_list { get; set; }

}

[ProtoContract]
public class CLIENT_GAME_EXCEPT_ATTACK_GUILD_LIST
{
}

[ProtoContract]
public class GAME_WORLD_EXCEPT_ATTACK_GUILD_LIST
{
    [ProtoMember(1)]

    public uint start_world_id { get; set; }

}

[ProtoContract]
public class WORLD_GAME_EXCEPT_ATTACK_GUILD_LIST
{
    [ProtoMember(1)]

    public ulong user_uid { get; set; }
    [ProtoMember(2)]
    public int result { get; set; }

}

[ProtoContract]
public class GAME_CLIENT_EXCEPT_ATTACK_GUILD_LIST
{
    [ProtoMember(1)]

    public _guild_info[] alliance_list { get; set; }
    [ProtoMember(2)]
    public _guild_info[] except_attack_list { get; set; }

}

[ProtoContract]
public class CLIENT_GAME_ADD_EXCEPT_ATTACK_GUILD
{
    [ProtoMember(1)]

    public ulong target_guild_uid { get; set; }

}

[ProtoContract]
public class GAME_WORLD_ADD_EXCEPT_ATTACK_GUILD
{
    [ProtoMember(1)]

    public ulong target_guild_uid { get; set; }
    [ProtoMember(2)]
    public uint start_world_id { get; set; }

}

[ProtoContract]
public class WORLD_GAME_ADD_EXCEPT_ATTACK_GUILD
{
    [ProtoMember(1)]

    public int result { get; set; }
    [ProtoMember(2)]
    public ulong user_uid { get; set; }
    [ProtoMember(3)]
    public ulong guild_uid { get; set; }
    [ProtoMember(4)]
    public ulong target_guild_uid { get; set; }
    [ProtoMember(5)]
    public int target_world_id { get; set; }

}

[ProtoContract]
public class WORLD_WORLD_EXCEPT_ATTACK_GUILD_ETC_SET
{
    [ProtoMember(1)]

    public long guild_uid { get; set; }
    [ProtoMember(2)]
    public ulong target_guild_uid { get; set; }
    [ProtoMember(3)]
    public bool is_add_except { get; set; }

}

[ProtoContract]
public class WORLD_WORLD_EXCEPT_ATTACK_GUILD_CHAT_SET
{
    [ProtoMember(1)]

    public ulong user_uid { get; set; }
    [ProtoMember(2)]
    public ulong guild_uid { get; set; }
    [ProtoMember(3)]
    public ulong target_guild_uid { get; set; }
    [ProtoMember(4)]
    public bool is_add_except { get; set; }

}

[ProtoContract]
public class GAME_CLIENT_ADD_EXCEPT_ATTACK_GUILD
{
    [ProtoMember(1)]

    public int result { get; set; }
    [ProtoMember(2)]
    public ulong target_guild_uid { get; set; }
    [ProtoMember(3)]
    public int target_world_id { get; set; }

}

[ProtoContract]
public class CLIENT_GAME_DEL_EXCEPT_ATTACK_GUILD
{
    [ProtoMember(1)]

    public ulong target_guild_uid { get; set; }

}

[ProtoContract]
public class GAME_WORLD_DEL_EXCEPT_ATTACK_GUILD
{
    [ProtoMember(1)]

    public ulong target_guild_uid { get; set; }
    [ProtoMember(2)]
    public uint start_world_id { get; set; }

}

[ProtoContract]
public class WORLD_GAME_DEL_EXCEPT_ATTACK_GUILD
{
    [ProtoMember(1)]

    public int result { get; set; }
    [ProtoMember(2)]
    public ulong user_uid { get; set; }
    [ProtoMember(3)]
    public ulong guild_uid { get; set; }
    [ProtoMember(4)]
    public ulong[] target_guild_uid_list { get; set; }

}

[ProtoContract]
public class WORLD_WORLD_DEL_EXCEPT_ATTACK_GUILD_REQUEST
{
    [ProtoMember(1)]

    public ulong guild_uid { get; set; }
    [ProtoMember(2)]
    public ulong target_guild_uid { get; set; }

}

[ProtoContract]
public class GAME_CLIENT_DEL_EXCEPT_ATTACK_GUILD
{
    [ProtoMember(1)]

    public int result { get; set; }
    [ProtoMember(2)]
    public ulong[] target_guild_uid_list { get; set; }

}

[ProtoContract]
public class GAME_WORLD_GUILD_INDEX_INSERT
{
    [ProtoMember(1)]

    public ulong character_uid { get; set; }
    [ProtoMember(2)]
    public string guild_name { get; set; }
    [ProtoMember(3)]
    public uint guild_mark { get; set; }
    [ProtoMember(4)]
    public uint guild_mark_edge { get; set; }

}

[ProtoContract]
public class WORLD_GAME_GUILD_INDEX_INSERT
{
    [ProtoMember(1)]

    public int result { get; set; }
    [ProtoMember(2)]
    public string guild_name { get; set; }
    [ProtoMember(3)]
    public ulong guild_uid { get; set; }
    [ProtoMember(4)]
    public ulong character_uid { get; set; }
    [ProtoMember(5)]
    public uint guild_mark { get; set; }
    [ProtoMember(6)]
    public uint guild_mark_edge { get; set; }

}

[ProtoContract]
public class GAME_WORLD_GUILD_INDEX_UPDATE
{
    [ProtoMember(1)]

    public ulong guild_uid { get; set; }
    [ProtoMember(2)]
    public string guild_name { get; set; }

}

[ProtoContract]
public class WORLD_GAME_GUILD_INDEX_UPDATE
{
    [ProtoMember(1)]

    public int result { get; set; }

}

[ProtoContract]
public class GAME_WORLD_GUILD_INDEX_DELETE
{
    [ProtoMember(1)]

    public ulong guild_uid { get; set; }

}

[ProtoContract]
public class WORLD_GAME_GUILD_INDEX_DELETE
{
    [ProtoMember(1)]

    public int result { get; set; }

}

[ProtoContract]
public class CLIENT_GAME_GUILD_COMMAND_MARK_SET
{
    [ProtoMember(1)]

    public int command_mark_idx { get; set; }
    [ProtoMember(2)]
    public ulong target_uid { get; set; }

}

[ProtoContract]
public class GAME_WORLD_GUILD_COMMAND_MARK_SET
{
    [ProtoMember(1)]

    public int command_mark_idx { get; set; }
    [ProtoMember(2)]
    public ulong target_uid { get; set; }
    [ProtoMember(3)]
    public string target_name { get; set; }
    [ProtoMember(4)]
    public uint target_world_id { get; set; }
    [ProtoMember(5)]
    public uint start_world_id { get; set; }

}

[ProtoContract]
public class WORLD_GAME_GUILD_COMMAND_MARK_SET
{
    [ProtoMember(1)]

    public int result { get; set; }
    [ProtoMember(2)]
    public ulong user_uid { get; set; }
    [ProtoMember(3)]
    public ulong guild_uid { get; set; }
    [ProtoMember(4)]
    public int command_mark_idx { get; set; }
    [ProtoMember(5)]
    public int del_command_mark_idx { get; set; }
    [ProtoMember(6)]
    public ulong target_uid { get; set; }
    [ProtoMember(7)]
    public int target_world_id { get; set; }
    [ProtoMember(8)]
    public string target_name { get; set; }

}

[ProtoContract]
public class GAME_CLIENT_GUILD_COMMAND_MARK_SET
{
    [ProtoMember(1)]

    public int result { get; set; }
    [ProtoMember(2)]
    public ulong guild_uid { get; set; }
    [ProtoMember(3)]
    public int command_mark_idx { get; set; }
    [ProtoMember(4)]
    public int del_command_mark_idx { get; set; }
    [ProtoMember(5)]
    public ulong target_uid { get; set; }
    [ProtoMember(6)]
    public string target_name { get; set; }

}

[ProtoContract]
public class CLIENT_GAME_TRANSLTAE_TEXT
{
    [ProtoMember(1)]

    public ulong user_uid { get; set; }
    [ProtoMember(2)]
    public ulong target_guild_uid { get; set; }
    [ProtoMember(3)]
    public int contents_index { get; set; }
    [ProtoMember(4)]
    public int lanaguageIdx { get; set; }

}

[ProtoContract]
public class GAME_WORLD_TRANSLATE_TEXT
{
    [ProtoMember(1)]

    public ulong user_uid { get; set; }
    [ProtoMember(2)]
    public ulong target_guild_uid { get; set; }
    [ProtoMember(3)]
    public int contents_index { get; set; }
    [ProtoMember(4)]
    public int lanaguageIdx { get; set; }

}

[ProtoContract]
public class WORLD_GAME_TRANSLATE_TEXT
{
    [ProtoMember(1)]

    public int result { get; set; }
    [ProtoMember(2)]
    public ulong user_uid { get; set; }
    [ProtoMember(3)]
    public ulong guild_uid { get; set; }
    [ProtoMember(4)]
    public int contents_index { get; set; }
    [ProtoMember(5)]
    public int lanaguageIdx { get; set; }
    [ProtoMember(6)]
    public string translateText { get; set; }

}

[ProtoContract]
public class GAME_CLIENT_TRANSLATE_TEXT
{
    [ProtoMember(1)]

    public int result { get; set; }
    [ProtoMember(2)]
    public ulong guild_uid { get; set; }
    [ProtoMember(3)]
    public int contents_index { get; set; }
    [ProtoMember(4)]
    public int lanaguageIdx { get; set; }
    [ProtoMember(5)]
    public string translateText { get; set; }

}

[ProtoContract]
public class CLIENT_GAME_SAVE_TRANSLTE_TEXT
{
    [ProtoMember(1)]

    public ulong user_uid { get; set; }
    [ProtoMember(2)]
    public ulong target_guild_uid { get; set; }
    [ProtoMember(3)]
    public int contents_index { get; set; }
    [ProtoMember(4)]
    public int lanaguageIdx { get; set; }
    [ProtoMember(5)]
    public string translateText { get; set; }

}

[ProtoContract]
public class GAME_WORLD_SAVE_TRANSLATE_TEXT
{
    [ProtoMember(1)]

    public ulong user_uid { get; set; }
    [ProtoMember(2)]
    public ulong target_guild_uid { get; set; }
    [ProtoMember(3)]
    public int contents_index { get; set; }
    [ProtoMember(4)]
    public int lanaguageIdx { get; set; }
    [ProtoMember(5)]
    public string translateText { get; set; }

}

[ProtoContract]
public class WORLD_GAME_SAVE_TRANSLTE_TEXT
{
    [ProtoMember(1)]

    public int result { get; set; }
    [ProtoMember(2)]
    public ulong user_uid { get; set; }
    [ProtoMember(3)]
    public ulong target_guild_uid { get; set; }
    [ProtoMember(4)]
    public int contents_index { get; set; }
    [ProtoMember(5)]
    public int lanaguageIdx { get; set; }

}

[ProtoContract]
public class GAME_CLIENT_SAVE_TRANSLATE_TEXT
{
    [ProtoMember(1)]

    public int result { get; set; }
    [ProtoMember(2)]
    public ulong target_guild_uid { get; set; }
    [ProtoMember(3)]
    public int contents_index { get; set; }
    [ProtoMember(4)]
    public int lanaguageIdx { get; set; }

}

[ProtoContract]
public class WORLD_GAME_GUILD_GIVE_TO_USER_LIMIT_SETTING_INFO
{
    [ProtoMember(1)]

    public _cost_info[] guild_give_limit { get; set; }

}

[ProtoContract]
public class WORLD_GAME_GUILD_GIVE_TO_USER_LIMIT_NOTIFY
{
    [ProtoMember(1)]

    public long user_uid { get; set; }
    [ProtoMember(2)]
    public _character_guild_receive_cost_server_sync receive_info { get; set; }

}

[ProtoContract]
public class _current_guild_mission_list
{
    [ProtoMember(1)]

    public int mission_idx { get; set; }

}

[ProtoContract]
public class _complete_guild_mission_group_list
{
    [ProtoMember(1)]

    public int group_idx { get; set; }
    [ProtoMember(2)]
    public int summon_count { get; set; }

}

[ProtoContract]
public class _guild_member_current_mission_info
{
    [ProtoMember(1)]

    public ulong user_uid { get; set; }
    [ProtoMember(2)]
    public string member_name { get; set; }
    [ProtoMember(3)]
    public uint memeber_level { get; set; }
    [ProtoMember(4)]
    public uint class_id { get; set; }
    [ProtoMember(5)]
    public long combat_point { get; set; }
    [ProtoMember(6)]
    public ulong mission_point { get; set; }

}

[ProtoContract]
public class WORLD_GAME_SYNC_GUILD_COOP_MISSION
{
    [ProtoMember(1)]

    public ulong guild_uid { get; set; }
    [ProtoMember(2)]
    public int current_group_idx { get; set; }
    [ProtoMember(3)]
    public int current_mission_point { get; set; }
    [ProtoMember(4)]
    public bool is_current_summon_stat { get; set; }
    [ProtoMember(5)]
    public _current_guild_mission_list currnet_guild_mission_list { get; set; }
    [ProtoMember(6)]
    public _complete_guild_mission_group_list complete_guild_mission_group_list { get; set; }

}

[ProtoContract]
public class GAME_WORLD_GUILD_COOP_MISSION_DECREASE_SUMMON_BOSS
{
    [ProtoMember(1)]

    public ulong guild_uid { get; set; }
    [ProtoMember(2)]
    public int target_group_id { get; set; }
    [ProtoMember(3)]
    public int decrease_summon_count { get; set; }

}

[ProtoContract]
public class GAME_WORLD_GUILD_COOP_MISSION_LIST
{
    [ProtoMember(1)]

    public ulong user_uid { get; set; }
    [ProtoMember(2)]
    public ulong guild_uid { get; set; }

}

[ProtoContract]
public class WORLD_GAME_GUILD_COOP_MISSION_LIST
{
    [ProtoMember(1)]

    public ulong user_uid { get; set; }
    [ProtoMember(2)]
    public ulong guild_uid { get; set; }
    [ProtoMember(3)]
    public int current_group_idx { get; set; }
    [ProtoMember(4)]
    public ulong current_mission_point { get; set; }
    [ProtoMember(5)]
    public _current_guild_mission_list currnet_guild_mission_list { get; set; }
    [ProtoMember(6)]
    public _complete_guild_mission_group_list complete_guild_mission_group_list { get; set; }

}

[ProtoContract]
public class CLIENT_WORLD_GUILD_COOP_MISSION_LIST
{
    [ProtoMember(1)]

    public ulong guild_uid { get; set; }

}

[ProtoContract]
public class WORLD_CLIENT_GUILD_COOP_MISSION_LIST
{
    [ProtoMember(1)]

    public ulong guild_uid { get; set; }
    [ProtoMember(2)]
    public int current_group_idx { get; set; }
    [ProtoMember(3)]
    public ulong current_mission_point { get; set; }
    [ProtoMember(4)]
    public _current_guild_mission_list currnet_guild_mission_list { get; set; }
    [ProtoMember(5)]
    public _complete_guild_mission_group_list complete_guild_mission_group_list { get; set; }

}

[ProtoContract]
public class GAME_WORLD_GUILD_COOP_MISSION_COMPLETE
{
    [ProtoMember(1)]

    public ulong guild_uid { get; set; }
    [ProtoMember(2)]
    public int complete_group_id { get; set; }
    [ProtoMember(3)]
    public int complete_mission_id { get; set; }

}

[ProtoContract]
public class GAME_WORLD_GUILD_COOP_MISSION_DESTROY_SUMMON_BOSS
{
    [ProtoMember(1)]

    public ulong user_uid { get; set; }
    [ProtoMember(2)]
    public ulong guild_uid { get; set; }
    [ProtoMember(3)]
    public int target_group_id { get; set; }
    [ProtoMember(4)]
    public int history_type { get; set; }

}

[ProtoContract]
public class CLIENT_WORLD_GUILD_COOP_MISSION_MEMBER_POPUP
{
    [ProtoMember(1)]

    public ulong guild_uid { get; set; }

}

[ProtoContract]
public class WORLD_CLIENT_GUILD_COOP_MISSION_MEMBER_POPUP
{
    [ProtoMember(1)]

    public ulong guild_uid { get; set; }
    [ProtoMember(2)]
    public _guild_member_current_mission_info guild_member_list { get; set; }

}

[ProtoContract]
public class GAME_WORLD_GUILD_COOP_MISSION_MEMBER_POPUP
{
    [ProtoMember(1)]

    public ulong user_uid { get; set; }
    [ProtoMember(2)]
    public ulong guild_uid { get; set; }

}

[ProtoContract]
public class WORLD_CLIENT_GUILD_COOP_MISSION_CHANGED_MISSION
{
    [ProtoMember(1)]

    public ulong guild_uid { get; set; }

}

[ProtoContract]
public class _painting_guild_trade_data
{
    [ProtoMember(1)]

    public ulong painting_guild_trade_uid { get; set; }
    [ProtoMember(2)]
    public ulong reg_char_uid { get; set; }
    [ProtoMember(3)]
    public uint reg_item_id { get; set; }
    [ProtoMember(4)]
    public uint reg_item_count { get; set; }
    [ProtoMember(5)]
    public uint exchange_item_id { get; set; }
    [ProtoMember(6)]
    public uint exchange_item_count { get; set; }
    [ProtoMember(7)]
    public bool complete { get; set; }

}

[ProtoContract]
public class CLIENT_GAME_PAINTING_GUILD_TRADE_DATA_LIST
{

}

[ProtoContract]
public class GAME_CLIENT_PAINTING_GUILD_TRADE_DATA_LIST
{
    [ProtoMember(1)]

    public int result { get; set; }
    [ProtoMember(2)]
    public _painting_guild_trade_data painting_guild_trade_data_list { get; set; }

}

[ProtoContract]
public class CLIENT_GAME_PAINTING_GUILD_TRADE_REG
{
    [ProtoMember(1)]

    public ulong reg_item_uid { get; set; }
    [ProtoMember(2)]
    public uint reg_item_count { get; set; }
    [ProtoMember(3)]
    public uint exchange_item_id { get; set; }
    [ProtoMember(4)]
    public uint exchange_item_count { get; set; }

}

[ProtoContract]
public class GAME_CLIENT_PAINTING_GUILD_TRADE_REG
{
    [ProtoMember(1)]

    public int result { get; set; }
    [ProtoMember(2)]
    public _stack_item_info[] update_stack_items { get; set; }

}

[ProtoContract]
public class CLIENT_GAME_PAINTING_GUILD_TRADE_CANCEL
{
    [ProtoMember(1)]

    public ulong painting_guild_trade_uid { get; set; }

}

[ProtoContract]
public class GAME_CLIENT_PAINTING_GUILD_TRADE_CANCEL
{
    [ProtoMember(1)]

    public int result { get; set; }
    [ProtoMember(2)]
    public _character_inven_item[] update_items { get; set; }

}

[ProtoContract]
public class CLIENT_GAME_PAINTING_GUILD_TRADE_EXCHANGE
{
    [ProtoMember(1)]

    public ulong painting_guild_trade_uid { get; set; }
    [ProtoMember(2)]
    public ulong exchange_item_uid { get; set; }
    [ProtoMember(3)]
    public uint exchange_item_count { get; set; }

}

[ProtoContract]
public class GAME_CLIENT_PAINTING_GUILD_TRADE_EXCHANGE
{
    [ProtoMember(1)]

    public int result { get; set; }
    [ProtoMember(2)]
    public _stack_item_info[] update_stack_items { get; set; }
    [ProtoMember(3)]
    public _character_inven_item[] update_items { get; set; }
    [ProtoMember(4)]
    public _simple_item_info[] reward_update_items { get; set; }

}

[ProtoContract]
public class CLIENT_GAME_PAINTING_GUILD_TRADE_EXCHANGE_COMPLETE
{
    [ProtoMember(1)]

    public ulong painting_guild_trade_uid { get; set; }

}

[ProtoContract]
public class GAME_CLIENT_PAINTING_GUILD_TRADE_EXCHANGE_COMPLETE
{
    [ProtoMember(1)]

    public int result { get; set; }
    [ProtoMember(2)]
    public _character_inven_item[] update_items { get; set; }
    [ProtoMember(3)]
    public _simple_item_info[] reward_update_items { get; set; }

}

[ProtoContract]
public class GAME_WORLD_PAINTING_GUILD_TRADE_DATA_LIST
{
    [ProtoMember(1)]

    public ulong user_uid { get; set; }
    [ProtoMember(2)]
    public ulong guild_uid { get; set; }

}

[ProtoContract]
public class WORLD_GAME_PAINTING_GUILD_TRADE_DATA_LIST
{
    [ProtoMember(1)]

    public int result { get; set; }
    [ProtoMember(2)]
    public _painting_guild_trade_data painting_guild_trade_data_list { get; set; }

}

[ProtoContract]
public class GAME_WORLD_PAINTING_GUILD_TRADE_REG_CHECK
{
    [ProtoMember(1)]

    public ulong user_uid { get; set; }
    [ProtoMember(2)]
    public ulong guild_uid { get; set; }
    [ProtoMember(3)]
    public ulong reg_item_uid { get; set; }
    [ProtoMember(4)]
    public uint reg_item_count { get; set; }
    [ProtoMember(5)]
    public uint exchange_item_id { get; set; }
    [ProtoMember(6)]
    public uint exchange_item_count { get; set; }

}

[ProtoContract]
public class WORLD_GAME_PAINTING_GUILD_TRADE_REG_CHECK
{
    [ProtoMember(1)]

    public int result { get; set; }
    [ProtoMember(2)]
    public ulong user_uid { get; set; }
    [ProtoMember(3)]
    public ulong reg_item_uid { get; set; }
    [ProtoMember(4)]
    public uint reg_item_count { get; set; }
    [ProtoMember(5)]
    public uint exchange_item_id { get; set; }
    [ProtoMember(6)]
    public uint exchange_item_count { get; set; }

}

[ProtoContract]
public class GAME_WORLD_PAINTING_GUILD_TRADE_REG
{
    [ProtoMember(1)]

    public ulong user_uid { get; set; }
    [ProtoMember(2)]
    public ulong guild_uid { get; set; }
    [ProtoMember(3)]
    public uint reg_item_id { get; set; }
    [ProtoMember(4)]
    public uint reg_item_count { get; set; }
    [ProtoMember(5)]
    public uint exchange_item_id { get; set; }
    [ProtoMember(6)]
    public uint exchange_item_count { get; set; }
    [ProtoMember(7)]
    public long reg_time { get; set; }
    [ProtoMember(8)]
    public ulong painting_guild_trade_uid { get; set; }

}

[ProtoContract]
public class WORLD_GAME_PAINTING_GUILD_TRADE_REG
{
    [ProtoMember(1)]

    public int result { get; set; }
    [ProtoMember(2)]
    public _stack_item_info[] update_stack_items { get; set; }
    [ProtoMember(3)]
    _painting_guild_trade_data painting_guild_trade_data { get; set; }
    [ProtoMember(4)]
    public ulong painting_guild_trade_uid { get; set; }

}

[ProtoContract]
public class GAME_WORLD_PAINTING_GUILD_TRADE_CANCEL
{
    [ProtoMember(1)]

    public ulong user_uid { get; set; }
    [ProtoMember(2)]
    public ulong guild_uid { get; set; }
    [ProtoMember(3)]
    public ulong painting_guild_trade_uid { get; set; }

}

[ProtoContract]
public class WORLD_GAME_PAINTING_GUILD_TRADE_CANCEL
{
    [ProtoMember(1)]

    public int result { get; set; }
    [ProtoMember(2)]
    public ulong painting_guild_trade_uid { get; set; }
    [ProtoMember(3)]
    public uint reg_item_id { get; set; }
    [ProtoMember(4)]
    public uint reg_item_count { get; set; }

}

[ProtoContract]
public class GAME_WORLD_PAINTING_GUILD_TRADE_EXCHANGE
{
    [ProtoMember(1)]

    public ulong user_uid { get; set; }
    [ProtoMember(2)]
    public ulong guild_uid { get; set; }
    [ProtoMember(3)]
    public ulong painting_guild_trade_uid { get; set; }
    [ProtoMember(4)]
    public ulong exchange_item_uid { get; set; }
    [ProtoMember(5)]
    public uint exchange_item_count { get; set; }
    [ProtoMember(6)]
    public uint exchange_item_id { get; set; }

}

[ProtoContract]
public class WORLD_GAME_PAINTING_GUILD_TRADE_EXCHANGE
{
    [ProtoMember(1)]

    public int result { get; set; }
    [ProtoMember(2)]
    public uint reg_item_id { get; set; }
    [ProtoMember(4)]
    public uint reg_item_count { get; set; }
    [ProtoMember(5)]
    public ulong exchange_item_uid { get; set; }
    [ProtoMember(6)]
    public uint exchange_item_count { get; set; }
    [ProtoMember(7)]
    public uint exchange_item_id { get; set; }
    [ProtoMember(8)]
    public ulong painting_guild_trade_uid { get; set; }

}

[ProtoContract]
public class GAME_WORLD_PAINTING_GUILD_TRADE_EXCHANGE_COMPLETE
{
    [ProtoMember(1)]

    public ulong user_uid { get; set; }
    [ProtoMember(2)]
    public ulong guild_uid { get; set; }
    [ProtoMember(3)]
    public ulong painting_guild_trade_uid { get; set; }

}

[ProtoContract]
public class WORLD_GAME_PAINTING_GUILD_TRADE_EXCHANGE_COMPLETE
{
    [ProtoMember(1)]

    public int result { get; set; }
    [ProtoMember(2)]
    public ulong user_uid { get; set; }
    [ProtoMember(3)]
    public ulong guild_uid { get; set; }
    [ProtoMember(4)]
    public uint reg_item_id { get; set; }
    [ProtoMember(5)]
    public uint reg_item_count { get; set; }
    [ProtoMember(6)]
    public uint exchange_item_id { get; set; }
    [ProtoMember(7)]
    public uint exchange_item_count { get; set; }
    [ProtoMember(8)]
    public ulong painting_guild_trade_uid { get; set; }
    [ProtoMember(9)]
    public long reg_time { get; set; }

}

[ProtoContract]
public class WORLD_GAME_PAINTING_TRADE_ALARAM
{
    [ProtoMember(1)]

    public int result { get; set; }

}

[ProtoContract]
public class GAME_CLIENT_PAINTING_TRADE_ALARAM
{
    [ProtoMember(1)]

    public int result { get; set; }

}

[ProtoContract]
public class GAME_WORLD_GET_PAINTING_GUILD_POINT
{
    [ProtoMember(1)]

    public ulong user_uid { get; set; }
    [ProtoMember(2)]
    public ulong guild_uid { get; set; }
    [ProtoMember(3)]
    public uint point_type { get; set; }
    [ProtoMember(4)]
    public uint point_value { get; set; }

}

[ProtoContract]
public class WORLD_GAME_GET_PAINTING_GUILD_POINT
{
    [ProtoMember(1)]

    public ulong guild_uid { get; set; }
    [ProtoMember(2)]
    public uint point_type { get; set; }
    [ProtoMember(3)]
    public uint point_value { get; set; }

}

[ProtoContract]
public class GAME_WORLD_PAINTING_GUILD_TRADE_EXCHANGE_ROLLBACK
{
    [ProtoMember(1)]

    public ulong user_uid { get; set; }
    [ProtoMember(2)]
    public ulong guild_uid { get; set; }
    [ProtoMember(3)]
    public ulong painting_guild_trade_uid { get; set; }

}

[ProtoContract]
public class GAME_WORLD_PAINTING_GUILD_TRADE_EXCHANGE_COMPLETE_ROLLBACK
{
    [ProtoMember(1)]

    public ulong painting_guild_trade_uid { get; set; }
    [ProtoMember(2)]
    public ulong guild_uid { get; set; }
    [ProtoMember(3)]
    public ulong user_uid { get; set; }
    [ProtoMember(4)]
    public uint reg_item_id { get; set; }
    [ProtoMember(5)]
    public uint reg_item_count { get; set; }
    [ProtoMember(6)]
    public uint exchange_item_id { get; set; }
    [ProtoMember(7)]
    public uint exchange_item_count { get; set; }
    [ProtoMember(8)]
    public long reg_time { get; set; }

}


[ProtoContract]
public class guild_dev_simple_info
{
    [ProtoMember(1)]

    public int index { get; set; }
    [ProtoMember(2)]
    public int level { get; set; }
    [ProtoMember(3)]
    public int exp { get; set; }
    [ProtoMember(4)]
    public bool is_lock { get; set; }
    [ProtoMember(5)]
    public bool is_skill_start { get; set; }

}

[ProtoContract]
public class WORLD_CLIENT_GUILD_DEVELOP_LEVEL_DATA
{
    [ProtoMember(1)]

    public guild_dev_simple_info develop_list { get; set; }

}

[ProtoContract]
public class CLIENT_WORLD_GUILD_DEVELOP_LIST
{
    [ProtoMember(1)]

    public int list_id { get; set; }

}

[ProtoContract]
public class WORLD_CLIENT_GUILD_DEVELOP_LIST
{
    [ProtoMember(1)]

    public int result { get; set; }
    [ProtoMember(2)]
    public int list_id { get; set; }
    [ProtoMember(3)]
    public guild_dev_simple_info develop_list { get; set; }
    [ProtoMember(4)]
    public int recommend_index { get; set; }

}

[ProtoContract]
public class CLIENT_WORLD_GUILD_DEVELOP_DETAIL
{
    [ProtoMember(1)]

    public int index { get; set; }

}

[ProtoContract]
public class WORLD_GAME_GUILD_DEVELOP_DETAIL
{
    [ProtoMember(1)]

    public ulong user_uid { get; set; }
    [ProtoMember(2)]
    public int index { get; set; }

}

[ProtoContract]
public class WORLD_CLIENT_GUILD_DEVELOP_DETAIL
{
    [ProtoMember(1)]

    public int result { get; set; }
    [ProtoMember(2)]
    public int index { get; set; }
    [ProtoMember(3)]
    public int level { get; set; }
    [ProtoMember(4)]
    public int exp { get; set; }
    [ProtoMember(5)]
    public bool is_level_up_start { get; set; }
    [ProtoMember(6)]
    public int levelup_remain_time { get; set; }
    [ProtoMember(7)]
    public int levelup_max_time { get; set; }
    [ProtoMember(8)]
    public _cost_info[] guild_cost_info { get; set; }
    [ProtoMember(10)]
    public bool is_clear_expedition { get; set; }
    [ProtoMember(11)]
    public bool is_skill_start { get; set; }
    [ProtoMember(12)]
    public long skill_remain_time { get; set; }
    [ProtoMember(13)]
    public int skill_point { get; set; }

}

[ProtoContract]
public class CLIENT_WORLD_GUILD_DEVELOP_RECOMMEND
{
    [ProtoMember(1)]

    public int index { get; set; }
    [ProtoMember(2)]
    public bool is_recommend { get; set; }

}

[ProtoContract]
public class GAME_WORLD_GUILD_DEVELOP_RECOMMEND
{
    [ProtoMember(1)]

    public int index { get; set; }
    [ProtoMember(2)]
    public bool is_recommend { get; set; }
    [ProtoMember(3)]
    public uint start_world_id { get; set; }

}

[ProtoContract]
public class WORLD_CLIENT_GUILD_DEVELOP_RECOMMEND
{
    [ProtoMember(1)]

    public int result { get; set; }
    [ProtoMember(2)]
    public int index { get; set; }
    [ProtoMember(3)]
    public bool is_recommend { get; set; }

}

[ProtoContract]
public class WORLD_GAME_GUILD_DEVELOP_RECOMMEND
{
    [ProtoMember(1)]

    public int result { get; set; }
    [ProtoMember(2)]
    public long user_uid { get; set; }
    [ProtoMember(3)]
    public long guild_uid { get; set; }
    [ProtoMember(4)]
    public int index { get; set; }
    [ProtoMember(5)]
    public bool is_recommend { get; set; }

}

[ProtoContract]
public class GAME_CLIENT_GUILD_DEVELOP_RECOMMEND_NOTIFY
{
    [ProtoMember(1)]

    public int recommend_id { get; set; }
    [ProtoMember(2)]
    public bool is_recommend { get; set; }

}

[ProtoContract]
public class CLIENT_WORLD_GUILD_DEVELOP_LEVELUP_START
{
    [ProtoMember(1)]

    public int index { get; set; }

}

[ProtoContract]
public class GAME_WORLD_GUILD_DEVELOP_LEVELUP_START
{
    [ProtoMember(1)]

    public int index { get; set; }
    [ProtoMember(2)]
    public uint start_world_id { get; set; }

}

[ProtoContract]
public class WORLD_CLIENT_GUILD_DEVELOP_LEVELUP_START
{
    [ProtoMember(1)]

    public int result { get; set; }
    [ProtoMember(2)]
    public int index { get; set; }
    [ProtoMember(3)]
    public int remain_time { get; set; }
    [ProtoMember(4)]
    public int max_time { get; set; }
    [ProtoMember(5)]
    public int develop_level { get; set; }

}

[ProtoContract]
public class WORLD_GAME_GUILD_DEVELOP_LEVELUP_START
{
    [ProtoMember(1)]

    public int result { get; set; }
    [ProtoMember(2)]
    public ulong user_uid { get; set; }
    [ProtoMember(3)]
    public ulong guild_uid { get; set; }
    [ProtoMember(4)]
    public int index { get; set; }
    [ProtoMember(5)]
    public long start_time { get; set; }
    [ProtoMember(6)]
    public long end_time { get; set; }
    [ProtoMember(7)]
    public int develop_level { get; set; }

}

[ProtoContract]
public class CLIENT_WORLD_GUILD_DEVELOP_LEVELUP_COMPLETE
{
    [ProtoMember(1)]

    public int index { get; set; }

}

[ProtoContract]
public class WORLD_CLIENT_GUILD_DEVELOP_LEVELUP_COMPLETE
{
    [ProtoMember(1)]

    public int result { get; set; }
    [ProtoMember(2)]
    public int index { get; set; }
    [ProtoMember(3)]
    public int level { get; set; }
    [ProtoMember(4)]
    public int levelup_reward_guild_exp { get; set; }

}

[ProtoContract]
public class WORLD_CLIENT_GUILD_DEVELOP_LEVELUP_FAIL
{
    [ProtoMember(1)]

    public uint index { get; set; }
    [ProtoMember(2)]
    public int level { get; set; }
    [ProtoMember(3)]
    public int exp { get; set; }

}

[ProtoContract]
public class GAME_CLIENT_GUILD_DEVELOP_LEVELUP_COMPLETE
{
    [ProtoMember(1)]

    public int index { get; set; }
    [ProtoMember(2)]
    public int level { get; set; }

}

[ProtoContract]
public class CLIENT_WORLD_GUILD_DEVELOP_DONATION
{
    [ProtoMember(1)]

    public int index { get; set; }

}

[ProtoContract]
public class GAME_WORLD_GUILD_DEVELOP_DONATION
{
    [ProtoMember(1)]

    public int index { get; set; }
    [ProtoMember(2)]
    public uint start_world_id { get; set; }

}

[ProtoContract]
public class WORLD_GAME_GUILD_DEVELOP_DONATION
{
    [ProtoMember(1)]

    public ulong user_uid { get; set; }
    [ProtoMember(2)]
    public ulong guild_uid { get; set; }
    [ProtoMember(3)]
    public int index { get; set; }
    [ProtoMember(4)]
    public uint develop_level { get; set; }
    [ProtoMember(5)]
    public int skill_point { get; set; }

}

[ProtoContract]
public class GAME_WORLD_GUILD_DEVELOP_DONATION_RESULT
{
    [ProtoMember(1)]

    public int result { get; set; }
    [ProtoMember(2)]
    public ulong user_uid { get; set; }
    [ProtoMember(3)]
    public ulong guild_uid { get; set; }
    [ProtoMember(4)]
    public int index { get; set; }
    [ProtoMember(5)]
    public bool is_happy_bonus { get; set; }
    [ProtoMember(7)]
    public int reward_develop_exp { get; set; }
    [ProtoMember(9)]
    public _cost_info[] user_reward_cost_info_list { get; set; }
    [ProtoMember(10)]
    public int skill_point { get; set; }
    [ProtoMember(11)]
    public uint start_world_id { get; set; }

}

[ProtoContract]
public class GAME_CLIENT_GUILD_DEVELOP_DONATION_RESULT
{
    [ProtoMember(1)]

    _cost_info user_use_cost_info { get; set; }
    [ProtoMember(2)]
    public _cost_info[] user_reward_cost_info_list { get; set; }
    [ProtoMember(3)]
    public _time_ticket_info time_ticket_info { get; set; }
    [ProtoMember(4)]
    public int skill_point { get; set; }

}

[ProtoContract]
public class WORLD_CLIENT_GUILD_DEVELOP_DONATION_RESULT
{
    [ProtoMember(1)]

    public int result { get; set; }
    [ProtoMember(2)]
    public int index { get; set; }
    [ProtoMember(3)]
    public bool is_happy_bonus { get; set; }
    [ProtoMember(4)]
    public int reward_develop_exp { get; set; }
    [ProtoMember(7)]
    public int result_develop_exp { get; set; }
    [ProtoMember(8)]
    public _cost_info[] user_reward_cost_info_list { get; set; }
    [ProtoMember(9)]
    public int skill_point { get; set; }

}

[ProtoContract]
public class WORLD_GAME_GUILD_DEVELOP_DONATION_RESULT
{
    [ProtoMember(1)]

    public int result { get; set; }
    [ProtoMember(2)]
    public ulong user_uid { get; set; }
    [ProtoMember(3)]
    public int index { get; set; }
    [ProtoMember(4)]
    public bool is_happy_bonus { get; set; }
    [ProtoMember(5)]
    public int reward_develop_exp { get; set; }
    [ProtoMember(7)]
    public int result_develop_exp { get; set; }
    [ProtoMember(8)]
    public _cost_info[] user_reward_cost_info_list { get; set; }
    [ProtoMember(9)]
    public int skill_point { get; set; }

}

[ProtoContract]
public class WORLD_GAME_GUILD_DEVELOP_SERVER_SYNC
{
    [ProtoMember(1)]

    public ulong guild_uid { get; set; }
    [ProtoMember(2)]
    public int index { get; set; }
    [ProtoMember(3)]
    public int level { get; set; }
    [ProtoMember(4)]
    public int exp { get; set; }
    [ProtoMember(5)]
    public bool is_recommand { get; set; }
    [ProtoMember(6)]
    public bool is_skill_start { get; set; }
    [ProtoMember(7)]
    public long skill_start_time { get; set; }
    [ProtoMember(8)]
    public long skill_end_time { get; set; }
    [ProtoMember(9)]
    public int skill_point { get; set; }

}

[ProtoContract]
public class CLIENT_GAME_GUILD_DEVELOP_SKILL_START
{
    [ProtoMember(1)]

    public int index { get; set; }

}

[ProtoContract]
public class GAME_WORLD_GUILD_DEVELOP_SKILL_START
{
    [ProtoMember(1)]

    public int index { get; set; }
    [ProtoMember(2)]
    public uint start_world_id { get; set; }

}

[ProtoContract]
public class WORLD_GAME_GUILD_DEVELOP_SKILL_START
{
    [ProtoMember(1)]

    public int result { get; set; }
    [ProtoMember(2)]
    public int index { get; set; }
    [ProtoMember(3)]
    public ulong guild_uid { get; set; }
    [ProtoMember(4)]
    public long skill_start_time { get; set; }
    [ProtoMember(5)]
    public long skill_end_time { get; set; }
    [ProtoMember(6)]
    public ulong user_uid { get; set; }

}

[ProtoContract]
public class GAME_CLIENT_GUILD_DEVELOP_SKILL_START
{
    [ProtoMember(1)]

    public int result { get; set; }
    [ProtoMember(2)]
    public int index { get; set; }
    [ProtoMember(3)]
    public long skill_remaining_time { get; set; }

}

[ProtoContract]
public class WORLD_GAME_GUILD_DEVELOP_SKILL_END
{
    [ProtoMember(1)]

    public int index { get; set; }
    [ProtoMember(2)]
    public ulong guild_uid { get; set; }

}

[ProtoContract]
public class GAME_CLIENT_GUILD_DEVELOP_SKILL_END
{
    [ProtoMember(1)]

    public int index { get; set; }

}

[ProtoContract]
public class GAME_CLIENT_NOTIFY_GUILD_DEVELOP_SKILL_START
{
    [ProtoMember(1)]

    public int index { get; set; }

}

[ProtoContract]
public class GAME_CLIENT_NOTIFY_GUILD_DEVELOP_UNLOCK_SKILL
{
    [ProtoMember(1)]

    public int index { get; set; }

}


[ProtoContract]
public class CLIENT_GAME_GUILD_EXPEDITION_CREATE
{
    [ProtoMember(1)]

    public uint guild_expedission_id { get; set; }

}

[ProtoContract]
public class GAME_CLIENT_GUILD_EXPEDITION_CREATE
{
    [ProtoMember(1)]

    public int result { get; set; }
    [ProtoMember(2)]
    public uint guild_expedission_id { get; set; }

}

[ProtoContract]
public class GAME_WORLD_GUILD_EXPEDITION_CREATE
{
    [ProtoMember(1)]

    public ulong user_uid { get; set; }
    [ProtoMember(2)]
    public uint guild_expedission_id { get; set; }

}

[ProtoContract]
public class WORLD_GAME_GUILD_EXPEDITION_CREATE
{
    [ProtoMember(1)]

    public int result { get; set; }
    [ProtoMember(2)]
    public ulong user_uid { get; set; }
    [ProtoMember(3)]
    public uint guild_expedission_id { get; set; }
    [ProtoMember(4)]
    public ulong zone_uid { get; set; }
    [ProtoMember(5)]
    public ulong guild_uid { get; set; }

}

[ProtoContract]
public class GAME_CLIENT_GUILD_EXPEDITION_FAIL
{
    [ProtoMember(1)]

    public int result { get; set; }

}

[ProtoContract]
public class CLIENT_WORLD_GUILD_EXPEDITION_LIST
{
    [ProtoMember(1)]

    public int expedition_type { get; set; }

}

[ProtoContract]
public class WORLD_CLIENT_GUILD_EXPEDITION_LIST
{
    [ProtoMember(1)]

    public _guild_expedition_list guild_expedition_list { get; set; }
    [ProtoMember(2)]
    public int guild_expedission_ticket { get; set; }
    [ProtoMember(3)]
    public int guild_expedission_max_ticket { get; set; }

}

[ProtoContract]
public class CLIENT_WORLD_GUILD_EXPEDITION_DETAIL
{
    [ProtoMember(1)]

    public uint guild_expedission_id { get; set; }

}

[ProtoContract]
public class GAME_WORLD_GUILD_EXPEDITION_DETAIL
{
    [ProtoMember(1)]

    public uint guild_expedission_id { get; set; }
    [ProtoMember(2)]
    public int contribute_reward { get; set; }

}

[ProtoContract]
public class WORLD_CLIENT_GUILD_EXPEDITION_DETAIL
{
    [ProtoMember(1)]

    public uint guild_expedission_id { get; set; }
    [ProtoMember(2)]
    public int event_state { get; set; }
    [ProtoMember(3)]
    public int user_count { get; set; }
    [ProtoMember(4)]
    public int max_user_count { get; set; }
    [ProtoMember(5)]
    public long remaining_time { get; set; }
    [ProtoMember(6)]
    public int summon_count { get; set; }
    [ProtoMember(8)]
    public int contribute_reward { get; set; }

}

[ProtoContract]
public class GAME_WORLD_GUILD_EXPEDITION_ENTER
{
    [ProtoMember(1)]

    public ulong user_uid { get; set; }
    [ProtoMember(2)]
    public int expedition_type { get; set; }

}

[ProtoContract]
public class WORLD_GAME_GUILD_EXPEDITION_ENTER
{
    [ProtoMember(1)]

    public int result { get; set; }
    [ProtoMember(2)]
    public ulong user_uid { get; set; }
    [ProtoMember(3)]
    public uint guild_expedission_id { get; set; }
    [ProtoMember(4)]
    public ulong zone_uid { get; set; }

}

[ProtoContract]
public class GAME_WORLD_GUILD_EXPEDITION_STAGE_CLEAR
{
    [ProtoMember(1)]

    public uint guild_expedission_id { get; set; }
    [ProtoMember(2)]
    public ulong zone_uid { get; set; }
    [ProtoMember(3)]
    public ulong guild_uid { get; set; }

}

[ProtoContract]
public class WORLD_GAME_GUILD_EXPEDITION_STAGE_CLEAR
{
    [ProtoMember(1)]

    public uint guild_expedission_id { get; set; }
    [ProtoMember(2)]
    public ulong zone_uid { get; set; }
    [ProtoMember(3)]
    public ulong guild_uid { get; set; }

}

[ProtoContract]
public class GAME_WORLD_USER_EXPEDISSION_TICKET
{
    [ProtoMember(1)]

    public ulong user_uid { get; set; }
    [ProtoMember(2)]
    public uint guild_expedission_ticket { get; set; }

}

[ProtoContract]
public class WORLD_CLIENT_EXPEDISSION_REGISTER_NOTICE
{
    [ProtoMember(1)]

    public uint guild_expedission_id { get; set; }

}

[ProtoContract]
public class WORLD_GAME_GUILD_EXPEDITION_SUMMON_SYNC
{
    [ProtoMember(1)]

    public uint guild_expedission_id { get; set; }
    [ProtoMember(2)]
    public uint summon_count { get; set; }
    [ProtoMember(3)]
    public ulong guild_uid { get; set; }
    [ProtoMember(4)]
    public long create_date { get; set; }
    [ProtoMember(5)]
    public long reset_date { get; set; }

}

[ProtoContract]
public class WORLD_GAME_USER_GUILD_EXPEDITION_RESET
{
    [ProtoMember(1)]

    public ulong user_uid { get; set; }
    [ProtoMember(2)]
    public uint guild_expedission_id { get; set; }

}

[ProtoContract]
public class GAME_WORLD_GUILD_EXPEDITION_FAIL
{
    [ProtoMember(1)]

    public ulong guild_uid { get; set; }
    [ProtoMember(2)]
    public uint guild_expedission_id { get; set; }
    [ProtoMember(3)]
    public ulong zone_uid { get; set; }

}


[ProtoContract]
public class CLIENT_GAME_GUILD_GIFT_LIST
{
    [ProtoMember(1)]

    public uint gift_tap_type { get; set; }

}

[ProtoContract]
public class GAME_CLIENT_GUILD_GIFT_LIST_START
{
    [ProtoMember(1)]

    public uint gift_tap_type { get; set; }

}

[ProtoContract]
public class GAME_CLIENT_GUILD_GIFT_LIST
{
    [ProtoMember(1)]

    public uint gift_tap_type { get; set; }
    [ProtoMember(2)]
    public _guild_gift_info[] guild_gift_list { get; set; }

}

[ProtoContract]
public class GAME_CLIENT_GUILD_GIFT_LIST_END
{
    [ProtoMember(1)]

    public uint gift_tap_type { get; set; }

}

[ProtoContract]
public class CLIENT_GAME_GUILD_GIFT_OPEN
{
    [ProtoMember(1)]

    public uint gift_tap_type { get; set; }
    [ProtoMember(2)]
    public ulong gift_uid { get; set; }

}

[ProtoContract]
public class GAME_CLIENT_GUILD_GIFT_OPEN
{
    [ProtoMember(1)]

    _guild_gift_info guild_gift_info { get; set; }
    [ProtoMember(2)]
    public _character_inven_item[] update_items { get; set; }
    [ProtoMember(3)]
    public int result { get; set; }
    [ProtoMember(4)]
    public _cost_info[] costInfos { get; set; }

}

[ProtoContract]
public class GAME_WORLD_GUILD_GIFT_OPEN
{
    [ProtoMember(1)]

    public uint gift_id { get; set; }

}

[ProtoContract]
public class WORLD_GAME_GUILD_GIFT_OPEN
{
    [ProtoMember(1)]

    public ulong uid { get; set; }
    [ProtoMember(2)]
    public ulong guild_uid { get; set; }
    [ProtoMember(3)]
    _guild_gift_box_info guild_gift_box_info { get; set; }

}

[ProtoContract]
public class WORLD_CLIENT_GUILD_GIFT_OPEN
{
    [ProtoMember(1)]

    public ulong uid { get; set; }
    [ProtoMember(2)]
    public ulong guild_uid { get; set; }
    [ProtoMember(3)]
    _guild_gift_box_info guild_gift_box_info { get; set; }

}

[ProtoContract]
public class CLIENT_GAME_OPEN_GUILD_GIFT_DELETE
{
    [ProtoMember(1)]

    public uint gift_tap_type { get; set; }

}

[ProtoContract]
public class GAME_CLIENT_OPEN_GUILD_GIFT_DELETE
{
    [ProtoMember(1)]

    public uint gift_tap_type { get; set; }
    [ProtoMember(2)]
    public ulong[] delete_gift_list { get; set; }

}

[ProtoContract]
public class CLIENT_GAME_GUILD_KEY_BOX_OPEN
{
}

[ProtoContract]
public class GAME_CLIENT_GUILD_KEY_BOX_OPEN
{
    [ProtoMember(1)]

    public _cost_info[] costInfos { get; set; }
    [ProtoMember(2)]
    public _character_inven_item[] update_items { get; set; }
    [ProtoMember(3)]
    public ulong last_box_open_time { get; set; }
    [ProtoMember(4)]
    public _guild_gift_gain_info guild_gift_gain_info { get; set; }

}

[ProtoContract]
public class GAME_WORLD_REWARD_GUILD_GIFT
{
    [ProtoMember(1)]

    public ulong guild_uid { get; set; }
    [ProtoMember(2)]
    public uint gift_id { get; set; }
    [ProtoMember(3)]
    public ulong send_character_uid { get; set; }
    [ProtoMember(4)]
    public uint start_world_id { get; set; }

}

[ProtoContract]
public class WORLD_GAME_REWARD_GUILD_GIFT
{
    [ProtoMember(1)]

    public ulong uid { get; set; }
    [ProtoMember(2)]
    public ulong gift_uid { get; set; }
    [ProtoMember(3)]
    public uint gift_id { get; set; }
    [ProtoMember(4)]
    public uint gift_tap_type { get; set; }
    [ProtoMember(5)]
    public ulong send_character_uid { get; set; }
    [ProtoMember(6)]
    public string send_character_name { get; set; }
    [ProtoMember(7)]
    public ulong recv_date { get; set; }

}

[ProtoContract]
public class GAME_CLIENT_REWARD_GUILD_GIFT
{
    [ProtoMember(1)]

    public _guild_gift_info guild_gift_info { get; set; }

}

[ProtoContract]
public class CLIENT_GAME_GUILD_GIFT_OPEN_ALL
{
    [ProtoMember(1)]

    public uint gift_tap_type { get; set; }

}

[ProtoContract]
public class GAME_CLIENT_GUILD_GIFT_OPEN_ALL_START
{
    [ProtoMember(1)]

    public uint gift_tap_type { get; set; }

}

[ProtoContract]
public class GAME_CLIENT_GUILD_GIFT_OPEN_ALL
{
    [ProtoMember(1)]

    public uint gift_tap_type { get; set; }
    [ProtoMember(2)]
    public _guild_gift_info guild_gift_infos { get; set; }
    [ProtoMember(3)]
    public _character_inven_item[] update_items { get; set; }
    [ProtoMember(4)]
    public _cost_info[] costInfos { get; set; }

}

[ProtoContract]
public class GAME_CLIENT_GUILD_GIFT_OPEN_ALL_END
{
    [ProtoMember(1)]

    public uint gift_tap_type { get; set; }
    [ProtoMember(2)]
    public int result { get; set; }

}


[ProtoContract]
public class _guild_member_join_info
{
    [ProtoMember(1)]

    public ulong user_uid { get; set; }
    [ProtoMember(2)]
    public string nickname { get; set; }
    [ProtoMember(3)]
    public uint level { get; set; }
    [ProtoMember(4)]
    public uint class_id { get; set; }
    [ProtoMember(5)]
    public uint combat_point { get; set; }
    [ProtoMember(6)]
    public ulong req_time { get; set; }
    [ProtoMember(7)]
    public ulong fame_point { get; set; }
    [ProtoMember(8)]
    public uint rank { get; set; }
    [ProtoMember(9)]
    public uint fame_level { get; set; }
    [ProtoMember(10)]
    public string profile { get; set; }

}

[ProtoContract]
public class CLIENT_WORLD_GUILD_MEMBER_LIST
{
    [ProtoMember(1)]

    public ulong guild_uid { get; set; }

}

[ProtoContract]
public class WORLD_CLIENT_GUILD_MEMBER_LIST
{
    [ProtoMember(1)]

    public uint result { get; set; }
    [ProtoMember(2)]
    public ulong guild_uid { get; set; }
    [ProtoMember(3)]
    public int position_group_id { get; set; }
    [ProtoMember(4)]
    public _guild_member_info[] member_list { get; set; }
    [ProtoMember(5)]
    public bool is_full_member_list { get; set; }

}

[ProtoContract]
public class WORLD_GAME_GUILD_MEMBER_ADD
{
    [ProtoMember(1)]

    public ulong guild_uid { get; set; }
    [ProtoMember(2)]
    _guild_member_info_server_sync member_info { get; set; }
    [ProtoMember(3)]
    public uint member_count { get; set; }

}

[ProtoContract]
public class WORLD_CLIENT_GUILD_MEMBER_ADD
{
    [ProtoMember(1)]

    _guild_member_info member { get; set; }
    [ProtoMember(2)]
    public uint member_count { get; set; }

}

[ProtoContract]
public class WORLD_GAME_GUILD_MEMBER_DEL
{
    [ProtoMember(1)]

    public ulong guild_uid { get; set; }
    [ProtoMember(2)]
    public ulong del_uid { get; set; }
    [ProtoMember(4)]
    public uint member_count { get; set; }
    [ProtoMember(5)]
    public bool is_kick { get; set; }

}

[ProtoContract]
public class WORLD_CLIENT_GUILD_MEMBER_DEL
{
    [ProtoMember(1)]

    public uint del_reason { get; set; }
    [ProtoMember(2)]
    public ulong del_uid { get; set; }
    [ProtoMember(3)]
    public uint member_count { get; set; }
    [ProtoMember(4)]
    public string del_user_name { get; set; }
    [ProtoMember(5)]
    public bool is_leave { get; set; }

}

[ProtoContract]
public class CLIENT_WORLD_GUILD_MEMBER_LEAVE
{
}

[ProtoContract]
public class GAME_WORLD_GUILD_MEMBER_LEAVE
{
    [ProtoMember(1)]

    public uint start_world_id { get; set; }

}

[ProtoContract]
public class WORLD_GAME_GUILD_MEMBER_LEAVE
{
    [ProtoMember(1)]

    public uint result { get; set; }
    [ProtoMember(2)]
    public ulong user_uid { get; set; }

}

[ProtoContract]
public class WORLD_CLIENT_GUILD_MEMBER_LEAVE
{
    [ProtoMember(1)]

    public uint result { get; set; }

}

[ProtoContract]
public class GAME_CLIENT_GUILD_MEMBER_LEAVE_FIELD_BROADCAST
{
    [ProtoMember(1)]

    public ulong uid { get; set; }

}

[ProtoContract]
public class CLIENT_WORLD_GUILD_MEMBER_KICK
{
    [ProtoMember(1)]

    public ulong target_uid { get; set; }

}

[ProtoContract]
public class GAME_WORLD_GUILD_MEMBER_KICK
{
    [ProtoMember(1)]

    public ulong target_uid { get; set; }
    [ProtoMember(2)]
    public uint start_world_id { get; set; }

}

[ProtoContract]
public class WORLD_GAME_GUILD_MEMBER_KICK
{
    [ProtoMember(1)]

    public int result { get; set; }
    [ProtoMember(2)]
    public ulong user_uid { get; set; }
    [ProtoMember(3)]
    public ulong target_uid { get; set; }

}

[ProtoContract]
public class WORLD_CLIENT_GUILD_MEMBER_KICK
{
    [ProtoMember(1)]

    public uint result { get; set; }

}

[ProtoContract]
public class WORLD_CLIENT_GUILD_MEMBER_KICK_NOTIFY_TO_TARGET
{ 
}

[ProtoContract]
public class CLIENT_WORLD_GUILD_MEMBER_JOIN_REQUEST_LIST
{
}


[ProtoContract]
public class WORLD_CLIENT_GUILD_MEMBER_JOIN_REQUEST_LIST
{
    [ProtoMember(1)]

    public uint result { get; set; }
    [ProtoMember(2)]
    public _guild_member_join_info invite_list { get; set; }
    [ProtoMember(3)]
    public _guild_member_join_info applicant_list { get; set; }
    [ProtoMember(4)]
    public uint max_invite_count { get; set; }
    [ProtoMember(5)]
    public uint max_applicant_count { get; set; }

}

[ProtoContract]
public class CLIENT_WORLD_GUILD_MEMBER_INVITE_LIST
{
}

[ProtoContract]
public class WORLD_CLIENT_GUILD_MEMBER_INVITE_LIST
{
    [ProtoMember(1)]

    public uint result { get; set; }
    [ProtoMember(2)]
    public _guild_member_join_info invite_list { get; set; }

}

[ProtoContract]
public class CLIENT_WORLD_GUILD_MEMBER_JOIN_APPLICANT_LIST
{

}

[ProtoContract]
public class WORLD_CLIENT_GUILD_MEMBER_JOIN_APPLICANT_LIST
{
    [ProtoMember(1)]

    public uint result { get; set; }
    [ProtoMember(2)]
    public _guild_member_join_info applicant_list { get; set; }

}

[ProtoContract]
public class CLIENT_WORLD_GUILD_MEMBER_JOIN_APPLICANT
{
    [ProtoMember(1)]

    public ulong guild_uid { get; set; }

}

[ProtoContract]
public class GAME_WORLD_GUILD_MEMBER_JOIN_APPLICANT
{
    [ProtoMember(1)]

    public ulong guild_uid { get; set; }
    [ProtoMember(2)]
    public uint start_world_id { get; set; }

}

[ProtoContract]
public class WORLD_GAME_GUILD_MEMBER_JOIN_APPLICANT
{
    [ProtoMember(1)]

    public int result { get; set; }
    [ProtoMember(2)]
    public ulong guild_uid { get; set; }
    [ProtoMember(3)]
    public ulong user_uid { get; set; }
    [ProtoMember(4)]
    public bool is_free_join { get; set; }

}

[ProtoContract]
public class WORLD_CLIENT_GUILD_MEMBER_JOIN_APPLICANT
{
    [ProtoMember(1)]

    public uint result { get; set; }
    [ProtoMember(2)]
    public ulong guild_uid { get; set; }
    [ProtoMember(3)]
    public bool is_free_join { get; set; }

}

[ProtoContract]
public class CLIENT_WORLD_GUILD_MEMBER_JOIN_APPLICANT_CANCEL
{
    [ProtoMember(1)]

    public ulong guild_uid { get; set; }

}

[ProtoContract]
public class GAME_WORLD_GUILD_MEMBER_JOIN_APPLICANT_CANCEL
{
    [ProtoMember(1)]

    public ulong guild_uid { get; set; }
    [ProtoMember(2)]
    public uint start_world_id { get; set; }

}

[ProtoContract]
public class WORLD_GAME_GUILD_MEMBER_JOIN_APPLICANT_CANCEL
{
    [ProtoMember(1)]

    public int result { get; set; }
    [ProtoMember(2)]
    public ulong guild_uid { get; set; }
    [ProtoMember(3)]
    public ulong user_uid { get; set; }

}

[ProtoContract]
public class WORLD_CLIENT_GUILD_MEMBER_JOIN_APPLICANT_CANCEL
{
    [ProtoMember(1)]

    public uint result { get; set; }
    [ProtoMember(2)]
    public ulong guild_uid { get; set; }

}

[ProtoContract]
public class CLIENT_WORLD_GUILD_MEMBER_JOIN_APPLICANT_AGREE
{
    [ProtoMember(1)]

    public ulong target_uid { get; set; }
    [ProtoMember(2)]
    public bool agree { get; set; }

}

[ProtoContract]
public class GAME_WORLD_GUILD_MEMBER_JOIN_APPLICANT_AGREE
{
    [ProtoMember(1)]

    public ulong user_uid { get; set; }
    [ProtoMember(2)]
    public ulong target_uid { get; set; }
    [ProtoMember(3)]
    public bool agree { get; set; }
    [ProtoMember(4)]
    public string profile { get; set; }
    [ProtoMember(5)]
    public uint level { get; set; }
    [ProtoMember(6)]
    public long logout_time { get; set; }
    [ProtoMember(7)]
    public int combat_point { get; set; }
    [ProtoMember(8)]
    public uint start_world_id { get; set; }

}

[ProtoContract]
public class WORLD_GAME_GUILD_MEMBER_JOIN_APPLICANT_AGREE
{
    [ProtoMember(1)]

    public int result { get; set; }
    [ProtoMember(2)]
    public ulong user_uid { get; set; }
    [ProtoMember(3)]
    public ulong target_user_uid { get; set; }
    [ProtoMember(4)]
    public bool agree { get; set; }
    [ProtoMember(5)]
    public ulong guild_uid { get; set; }

}

[ProtoContract]
public class WORLD_CLIENT_GUILD_MEMBER_JOIN_APPLICANT_AGREE
{
    [ProtoMember(1)]

    public int result { get; set; }
    [ProtoMember(2)]
    public ulong target_uid { get; set; }
    [ProtoMember(3)]
    public bool agree { get; set; }
    [ProtoMember(4)]
    public ulong guild_uid { get; set; }

}

[ProtoContract]
public class GAME_CLIENT_GUILD_MEMBER_JOIN_INVITE_ADD_NOTIFY
{
    [ProtoMember(1)]

    _guild_member_join_info invite_info { get; set; }

}

[ProtoContract]
public class GAME_CLIENT_GUILD_MEMBER_JOIN_INVITE_DEL_NOTIFY
{
    [ProtoMember(1)]

    public ulong del_user_uid { get; set; }

}

[ProtoContract]
public class GAME_CLIENT_GUILD_MEMBER_JOIN_APPLICANT_ADD_NOTIFY
{
    [ProtoMember(1)]

    _guild_member_join_info applicant_info { get; set; }

}

[ProtoContract]
public class CLIENT_GAME_RECOMMEND_MEMBER_INVITE_LIST
{
}

[ProtoContract]
public class GAME_CLIENT_RECOMMEND_MEMBER_INVITE_LIST
{
    [ProtoMember(1)]

    public _friend_request_info recommend_list { get; set; }

}

[ProtoContract]
public class GAME_WORLD_RECOMMEND_MEMBER_INVITE_LIST
{
    [ProtoMember(1)]

    public uint start_world_id { get; set; }

}

[ProtoContract]
public class WORLD_GAME_RECOMMEND_MEMBER_INVITE_LIST
{
    [ProtoMember(1)]

    public ulong[] recommend_user_list { get; set; }
    [ProtoMember(2)]
    public ulong user_uid { get; set; }

}

[ProtoContract]
public class CLIENT_WORLD_GUILD_INVITE_ME_LIST
{

}

[ProtoContract]
public class WORLD_CLIENT_GUILD_INVITE_ME_LIST
{
    [ProtoMember(1)]

    public uint result { get; set; }
    [ProtoMember(2)]
    public _guild_info[] guild_list { get; set; }
    [ProtoMember(3)]
    public long[] req_time { get; set; }

}

[ProtoContract]
public class CLIENT_WORLD_GUILD_MEMBER_INVITE
{
    [ProtoMember(1)]

    public ulong target_uid { get; set; }

}

[ProtoContract]
public class GAME_WORLD_GUILD_MEMBER_INVITE
{
    [ProtoMember(1)]

    public ulong target_uid { get; set; }
    [ProtoMember(2)]
    public uint start_world_id { get; set; }

}

[ProtoContract]
public class WORLD_GAME_GUILD_MEMBER_INVITE
{
    [ProtoMember(1)]

    public uint result { get; set; }
    [ProtoMember(2)]
    public ulong user_uid { get; set; }
    [ProtoMember(3)]
    public ulong guild_uid { get; set; }
    [ProtoMember(4)]
    public ulong target_user_uid { get; set; }

}

[ProtoContract]
public class WORLD_CLIENT_GUILD_MEMBER_INVITE
{
    [ProtoMember(1)]

    public ulong guild_uid { get; set; }
    [ProtoMember(2)]
    public string guild_name { get; set; }

}

[ProtoContract]
public class WORLD_CLIENT_GUILD_MEMBER_INVITE_RESULT
{
    [ProtoMember(1)]

    public uint result { get; set; }
    [ProtoMember(2)]
    public ulong target_uid { get; set; }

}

[ProtoContract]
public class CLIENT_WORLD_GUILD_MEMBER_INVITE_AGREE
{
    [ProtoMember(1)]

    public ulong guild_uid { get; set; }
    [ProtoMember(2)]
    public bool agree { get; set; }

}

[ProtoContract]
public class GAME_WORLD_GUILD_MEMBER_INVITE_AGREE
{
    [ProtoMember(1)]

    public ulong guild_uid { get; set; }
    [ProtoMember(2)]
    public bool agree { get; set; }
    [ProtoMember(3)]
    public uint start_world_id { get; set; }

}

[ProtoContract]
public class WORLD_GAME_GUILD_MEMBER_INVITE_AGREE
{
    [ProtoMember(1)]

    public uint result { get; set; }
    [ProtoMember(2)]
    public bool agree { get; set; }
    [ProtoMember(3)]
    public ulong guild_uid { get; set; }
    [ProtoMember(4)]
    public ulong user_uid { get; set; }

}

[ProtoContract]
public class WORLD_CLIENT_GUILD_MEMBER_INVITE_AGREE
{
    [ProtoMember(1)]

    public uint result { get; set; }
    [ProtoMember(2)]
    public bool agree { get; set; }
    [ProtoMember(3)]
    public ulong guild_uid { get; set; }
    [ProtoMember(4)]
    public ulong target_user_uid { get; set; }

}

[ProtoContract]
public class WORLD_CLIENT_GUILD_MEMBER_INVITE_AGREE_NOTIFY_TO_MEMBER
{
    [ProtoMember(1)]

    public ulong guild_uid { get; set; }
    [ProtoMember(2)]
    public ulong target_user_uid { get; set; }
    [ProtoMember(3)]
    public bool agree { get; set; }

}

[ProtoContract]
public class CLIENT_WORLD_GUILD_MEMBER_INVITE_CANCEL
{
    [ProtoMember(1)]

    public ulong target_uid { get; set; }

}

[ProtoContract]
public class GAME_WORLD_GUILD_MEMBER_INVITE_CANCEL
{
    [ProtoMember(1)]

    public ulong target_uid { get; set; }
    [ProtoMember(2)]
    public uint start_world_id { get; set; }

}

[ProtoContract]
public class WORLD_GAME_GUILD_MEMBER_INVITE_CANCEL
{
    [ProtoMember(1)]

    public uint result { get; set; }
    [ProtoMember(2)]
    public ulong user_uid { get; set; }
    [ProtoMember(3)]
    public ulong target_user_uid { get; set; }
    [ProtoMember(4)]
    public ulong guild_uid { get; set; }

}

[ProtoContract]
public class WORLD_CLIENT_GUILD_MEMBER_INVITE_CANCEL
{
    [ProtoMember(1)]

    public uint result { get; set; }
    [ProtoMember(2)]
    public ulong target_uid { get; set; }
    [ProtoMember(3)]
    public ulong guild_uid { get; set; }

}

[ProtoContract]
public class GAME_CLIENT_GUILD_MEMBER_JOIN_NOTIFY_TO_TARGET
{ 
}

[ProtoContract]
public class CLIENT_WORLD_GUILD_MEMBER_SETTING_INFO
{
    [ProtoMember(1)]

    public ulong target_uid { get; set; }

}

[ProtoContract]
public class _guild_member_setting_grade_info
{
    [ProtoMember(1)]

    public uint grade { get; set; }
    [ProtoMember(2)]
    public uint member_count { get; set; }

}

[ProtoContract]
public class WORLD_CLIENT_GUILD_MEMBER_SETTING_INFO
{
    [ProtoMember(1)]

    public int result { get; set; }
    [ProtoMember(2)]
    public ulong target_uid { get; set; }
    [ProtoMember(4)]
    public string name { get; set; }
    [ProtoMember(5)]
    public string custom_title { get; set; }
    [ProtoMember(6)]
    public int class_index { get; set; }
    [ProtoMember(7)]
    public uint level { get; set; }
    [ProtoMember(8)]
    public int power_point { get; set; }
    [ProtoMember(9)]
    public uint member_grade { get; set; }
    [ProtoMember(10)]
    public string profile { get; set; }
    [ProtoMember(11)]
    public ulong partner_member_uid { get; set; }
    [ProtoMember(12)]
    public string partner_member_name { get; set; }
    [ProtoMember(13)]
    public long logout_time { get; set; }
    [ProtoMember(14)]
    public uint locate { get; set; }
    [ProtoMember(15)]
    public uint max_grade2_member_count { get; set; }
    [ProtoMember(21)]
    public _guild_member_setting_grade_info grade_info { get; set; }
    [ProtoMember(22)]
    public _guild_member_authority auth_list { get; set; }
    [ProtoMember(23)]
    public uint position_group_id { get; set; }
    [ProtoMember(24)]
    public uint position_num { get; set; }
    [ProtoMember(25)]
    public uint[] can_change_position { get; set; }

}

[ProtoContract]
public class CLIENT_WORLD_GUILD_MEMBER_GRADE_SET
{
    [ProtoMember(1)]

    public ulong target_member_uid { get; set; }
    [ProtoMember(2)]
    public uint target_grade { get; set; }

}

[ProtoContract]
public class GAME_WORLD_GUILD_MEMBER_GRADE_SET
{
    [ProtoMember(1)]

    public ulong target_member_uid { get; set; }
    [ProtoMember(2)]
    public uint target_grade { get; set; }
    [ProtoMember(3)]
    public uint start_world_id { get; set; }

}

[ProtoContract]
public class WORLD_GAME_GUILD_MEMBER_GRADE_SET
{
    [ProtoMember(1)]

    public int result { get; set; }
    [ProtoMember(2)]
    public ulong user_uid { get; set; }
    [ProtoMember(3)]
    public ulong guild_uid { get; set; }
    [ProtoMember(4)]
    public ulong target_member_uid { get; set; }
    [ProtoMember(5)]
    public uint target_grade { get; set; }
    [ProtoMember(6)]
    public uint target_old_grade { get; set; }
    [ProtoMember(7)]
    public ulong old_master_uid { get; set; }

}

[ProtoContract]
public class WORLD_CLIENT_GUILD_MEMBER_GRADE_SET
{
    [ProtoMember(1)]

    public int result { get; set; }
    [ProtoMember(2)]
    public ulong target_member_uid { get; set; }
    [ProtoMember(3)]
    public uint target_grade { get; set; }
    [ProtoMember(4)]
    public string target_member_name { get; set; }
    [ProtoMember(5)]
    public ulong old_master_uid { get; set; }
    [ProtoMember(7)]
    public uint old_master_grade { get; set; }
    [ProtoMember(8)]
    public _guild_member_setting_grade_info member_setting_grade_info { get; set; }
    [ProtoMember(10)]
    public uint position_group_id { get; set; }
    [ProtoMember(11)]
    public uint position_num { get; set; }
    [ProtoMember(12)]
    public uint old_master_position_num { get; set; }

}

[ProtoContract]
public class WORLD_CLIENT_GUILD_MEMBER_GRADE_SET_TO_TARGET
{
    [ProtoMember(1)]

    public ulong target_member_uid { get; set; }
    [ProtoMember(2)]
    public uint target_grade { get; set; }
    [ProtoMember(3)]
    public _guild_member_authority auth_list { get; set; }

}

[ProtoContract]
public class CLIENT_WORLD_GUILD_PARTNER_MEMBET_SET
{
    [ProtoMember(1)]

    public ulong target_partner_member_uid { get; set; }

}

[ProtoContract]
public class GAME_WORLD_GUILD_PARTNER_MEMBET_SET
{
    [ProtoMember(1)]

    public ulong target_partner_member_uid { get; set; }
    [ProtoMember(2)]
    public uint start_world_id { get; set; }

}

[ProtoContract]
public class WORLD_GAME_GUILD_PARTNER_MEMBET_SET
{
    [ProtoMember(1)]

    public int result { get; set; }
    [ProtoMember(2)]
    public ulong user_uid { get; set; }
    [ProtoMember(3)]
    public ulong target_partner_member_uid { get; set; }

}

[ProtoContract]
public class WORLD_CLIENT_GUILD_PARTNER_MEMBET_SET
{
    [ProtoMember(1)]

    public int result { get; set; }
    [ProtoMember(2)]
    public ulong target_partner_member_uid { get; set; }

}

[ProtoContract]
public class GAME_CLIENT_GUILD_PARTNER_MEMBET_INFO
{
    [ProtoMember(1)]

    _guild_member_partner_info partner_member_info { get; set; }
    [ProtoMember(3)]
    public ulong delete_partner_member_uid { get; set; }

}

[ProtoContract]
public class CLIENT_WORLD_GUILD_MEMBER_POSITION_SET
{
    [ProtoMember(1)]

    public ulong target_member_uid { get; set; }
    [ProtoMember(2)]
    public uint target_position_num { get; set; }

}

[ProtoContract]
public class WORLD_CLIENT_GUILD_MEMBER_POSITION_SET
{
    [ProtoMember(1)]

    public int result { get; set; }
    [ProtoMember(2)]
    public ulong target_member_uid { get; set; }
    [ProtoMember(3)]
    public uint target_position_num { get; set; }
    [ProtoMember(4)]
    public uint target_old_position_num { get; set; }

}

[ProtoContract]
public class CLIENT_WORLD_GUILD_MEMBER_AUTHORITY_SET
{
    [ProtoMember(1)]

    public ulong target_user_uid { get; set; }
    [ProtoMember(2)]
    public _guild_member_authority authority_info_list { get; set; }

}

[ProtoContract]
public class GAME_WORLD_GUILD_MEMBER_AUTHORITY_SET
{
    [ProtoMember(1)]

    public ulong target_user_uid { get; set; }
    [ProtoMember(2)]
    public _guild_member_authority authority_info_list { get; set; }
    [ProtoMember(3)]
    public uint start_world_id { get; set; }

}

[ProtoContract]
public class WORLD_GAME_GUILD_MEMBER_AUTHORITY_SET
{
    [ProtoMember(1)]

    public int result { get; set; }
    [ProtoMember(2)]
    public ulong user_uid { get; set; }
    [ProtoMember(3)]
    public ulong target_user_uid { get; set; }
    [ProtoMember(4)]
    public _guild_member_authority authority_info_list { get; set; }

}

[ProtoContract]
public class WORLD_CLIENT_GUILD_MEMBER_AUTHORITY_SET
{
    [ProtoMember(1)]

    public int result { get; set; }
    [ProtoMember(2)]
    public ulong target_user_uid { get; set; }
    [ProtoMember(3)]
    public _guild_member_authority authority_info_list { get; set; }

}

[ProtoContract]
public class GAME_CLIENT_GUILD_MEMBER_AUTHORITY_SET
{
    [ProtoMember(1)]

    public ulong target_user_uid { get; set; }
    [ProtoMember(3)]
    public _guild_member_authority authority_info_list { get; set; }

}

[ProtoContract]
public class CLIENT_WORLD_GUILD_MEMBER_CUSTOM_TITLE_SET
{
    [ProtoMember(1)]

    public ulong target_uid { get; set; }
    [ProtoMember(2)]
    public string custom_title { get; set; }

}

[ProtoContract]
public class GAME_WORLD_GUILD_MEMBER_CUSTOM_TITLE_SET
{
    [ProtoMember(1)]

    public ulong target_uid { get; set; }
    [ProtoMember(2)]
    public string custom_title { get; set; }
    [ProtoMember(3)]
    public uint start_world_id { get; set; }

}

[ProtoContract]
public class WORLD_GAME_GUILD_MEMBER_CUSTOM_TITLE_SET
{
    [ProtoMember(1)]

    public int result { get; set; }
    [ProtoMember(2)]
    public ulong user_uid { get; set; }
    [ProtoMember(3)]
    public ulong target_uid { get; set; }
    [ProtoMember(4)]
    public string custom_title { get; set; }

}

[ProtoContract]
public class WORLD_CLIENT_GUILD_MEMBER_CUSTOM_TITLE_SET
{
    [ProtoMember(1)]

    public int result { get; set; }
    [ProtoMember(2)]
    public ulong target_uid { get; set; }
    [ProtoMember(3)]
    public string custom_title { get; set; }

}


[ProtoContract]
public class CLIENT_GAME_GUILD_NPC_SHOP_INFO
{

}

[ProtoContract]
public class GAME_CLIENT_GUILD_NPC_SHOP_INFO
{
    [ProtoMember(1)]

    public int result { get; set; }
    [ProtoMember(2)]
    public int sell_guild_cost_type { get; set; }
    [ProtoMember(3)]
    public int sell_guild_cost_count { get; set; }
    [ProtoMember(4)]
    public int sell_guild_cost_remain_count { get; set; }
    [ProtoMember(5)]
    public int sell_price { get; set; }
    [ProtoMember(6)]
    _cost_info income_cost { get; set; }
    [ProtoMember(7)]
    public long remain_time { get; set; }
    [ProtoMember(8)]
    public int guild_shop_state { get; set; }

}

[ProtoContract]
public class CLIENT_GAME_GUILD_NPC_SHOP_OPEN
{
    [ProtoMember(1)]

    public int sell_count { get; set; }
    [ProtoMember(2)]
    public int sell_price { get; set; }

}

[ProtoContract]
public class GAME_WORLD_GUILD_NPC_SHOP_OPEN
{
    [ProtoMember(1)]

    public int sell_count { get; set; }
    [ProtoMember(2)]
    public int sell_price { get; set; }

}

[ProtoContract]
public class WORLD_GAME_GUILD_NPC_SHOP_OPEN
{
    [ProtoMember(1)]

    public int result { get; set; }
    [ProtoMember(2)]
    public ulong user_uid { get; set; }
    [ProtoMember(3)]
    public ulong guild_uid { get; set; }
    [ProtoMember(4)]
    public int sell_cost_type { get; set; }
    [ProtoMember(5)]
    public int sell_count { get; set; }
    [ProtoMember(6)]
    public int sell_price { get; set; }
    [ProtoMember(7)]
    public long open_time { get; set; }
    [ProtoMember(8)]
    public long close_time { get; set; }
    [ProtoMember(9)]
    public int dominion_tid { get; set; }

}

[ProtoContract]
public class GAME_CLIENT_GUILD_NPC_SHOP_OPEN
{
    [ProtoMember(1)]

    public int result { get; set; }

}

[ProtoContract]
public class CLIENT_GAME_GUILD_NPC_SHOP_CLOSE
    { 
}

[ProtoContract]
public class GAME_WORLD_GUILD_NPC_SHOP_CLOSE
{
    [ProtoMember(1)]

    public long guild_uid { get; set; }
    [ProtoMember(2)]
    public int close_reason { get; set; }

}

[ProtoContract]
public class WORLD_GAME_GUILD_NPC_SHOP_CLOSE
{
    [ProtoMember(1)]

    public int result { get; set; }
    [ProtoMember(2)]
    public ulong user_uid { get; set; }
    [ProtoMember(3)]
    public ulong guild_uid { get; set; }
    [ProtoMember(4)]
    public bool is_complate_takeout { get; set; }

}

[ProtoContract]
public class GAME_CLIENT_GUILD_NPC_SHOP_CLOSE
{
    [ProtoMember(1)]

    public int result { get; set; }

}

[ProtoContract]
public class GAME_WORLD_GUILD_NPC_SHOP_BUY
{
    [ProtoMember(1)]

    public ulong npc_shop_guild_uid { get; set; }
    [ProtoMember(2)]
    public uint shop_id { get; set; }
    [ProtoMember(3)]
    public uint goods_id { get; set; }
    [ProtoMember(4)]
    public uint goods_count { get; set; }
    [ProtoMember(5)]
    public int sell_guild_cost_type { get; set; }
    [ProtoMember(6)]
    public int sell_guild_cost_count { get; set; }
    [ProtoMember(7)]
    public int add_income_guild_cost_type { get; set; }
    [ProtoMember(8)]
    public long add_income_guild_cost_count { get; set; }

}

[ProtoContract]
public class WORLD_GAME_GUILD_NPC_SHOP_BUY
{
    [ProtoMember(1)]

    public int result { get; set; }
    [ProtoMember(2)]
    public ulong user_uid { get; set; }
    [ProtoMember(3)]
    public ulong npc_shop_guild_uid { get; set; }
    [ProtoMember(4)]
    public uint shop_id { get; set; }
    [ProtoMember(5)]
    public uint goods_id { get; set; }
    [ProtoMember(6)]
    public uint goods_count { get; set; }

}

[ProtoContract]
public class CLIENT_GAME_GUILD_NPC_SHOP_RE_OPEN
{
}

[ProtoContract]
public class GAME_WORLD_GUILD_NPC_SHOP_RE_OPEN
{
}

[ProtoContract]
public class WORLD_GAME_GUILD_NPC_SHOP_RE_OPEN
{
    [ProtoMember(1)]

    public int result { get; set; }
    [ProtoMember(2)]
    public ulong user_uid { get; set; }
    [ProtoMember(3)]
    public ulong guild_uid { get; set; }

}

[ProtoContract]
public class GAME_CLIENT_GUILD_NPC_SHOP_RE_OPEN
{
    [ProtoMember(1)]

    public int result { get; set; }

}

[ProtoContract]
public class CLIENT_GAME_GUILD_NPC_SHOP_TAKE_OUT
{
}

[ProtoContract]
public class GAME_WORLD_GUILD_NPC_SHOP_TAKE_OUT
{
}

[ProtoContract]
public class WORLD_GAME_GUILD_NPC_SHOP_TAKE_OUT
{
    [ProtoMember(1)]

    public int result { get; set; }
    [ProtoMember(2)]
    public ulong user_uid { get; set; }
    [ProtoMember(3)]
    public ulong guild_uid { get; set; }

}

[ProtoContract]
public class GAME_CLIENT_GUILD_NPC_SHOP_TAKE_OUT
{
    [ProtoMember(1)]

    public int result { get; set; }

}

[ProtoContract]
public class GAME_WORLD_GUILD_NPC_SHOP_STOP
{
    [ProtoMember(1)]

    public ulong guild_uid { get; set; }

}

[ProtoContract]
public class WORLD_GAME_GUILD_NPC_SHOP_STOP
{
    [ProtoMember(1)]

    public ulong guild_uid { get; set; }

}

[ProtoContract]
public class WORLD_GAME_GUILD_NPC_SHOP_REMAIN_COUNT_SYNC
{
    [ProtoMember(1)]

    public ulong guild_uid { get; set; }
    [ProtoMember(2)]
    public int cost_type { get; set; }
    [ProtoMember(3)]
    public int cost_remain_count { get; set; }
    [ProtoMember(4)]
    public int income_cost_type { get; set; }
    [ProtoMember(5)]
    public long income_cost_value { get; set; }
    [ProtoMember(6)]
    public _cost_info[] income_cost { get; set; }

}

[ProtoContract]
public class GAME_WORLD_GUILD_NPC_SHOP_OPEN_INFO_SYNC_REQ
{

}

[ProtoContract]
public class WORLD_GAME_GUILD_NPC_SHOP_OPEN_INFO_SYNC
{
    [ProtoMember(1)]

    public ulong guild_uid { get; set; }
    [ProtoMember(2)]
    public long close_time { get; set; }
    [ProtoMember(3)]
    public long last_open_time { get; set; }
    [ProtoMember(5)]
    public bool is_not_first_open { get; set; }
    [ProtoMember(6)]
    public bool cheat_force_open_time { get; set; }

}

[ProtoContract]
public class GAME_CLIENT_GUILD_NPC_SHOP_NOTIFY_BROADCAST
{
    [ProtoMember(1)]

    public int dominion_index { get; set; }
    [ProtoMember(2)]
    public int guild_shop_state { get; set; }
    [ProtoMember(3)]
    public bool is_reopen { get; set; }

}

[ProtoContract]
public class GAME_CLIENT_GUILD_NPC_SHOP_TAKE_OUT_NOTIFY
{
    [ProtoMember(1)]

    public bool is_need_take_out { get; set; }

}

[ProtoContract]
public class GAME_CLIENT_GUILD_NPC_SHOP_MEMBER_NOTIFY
{
    [ProtoMember(1)]

    public bool is_can_open { get; set; }

}

[ProtoContract]
public class WORLD_GUILD_GUILD_NPC_SHOP_OPEN_INFO_SYNC
{
    [ProtoMember(1)]

    public ulong guild_uid { get; set; }
    [ProtoMember(2)]
    public long close_time { get; set; }
    [ProtoMember(3)]
    public long last_open_time { get; set; }
    [ProtoMember(4)]
    public bool is_not_first_open { get; set; }
    [ProtoMember(6)]
    public bool cheat_force_open_time { get; set; }

}


[ProtoContract]
public class _guild_info_base_server_sync
{
    [ProtoMember(1)]

    public string guild_name { get; set; }
    [ProtoMember(2)]
    public string guild_pr { get; set; }
    [ProtoMember(3)]
    public long exp { get; set; }
    [ProtoMember(4)]
    public int level { get; set; }
    [ProtoMember(5)]
    public uint mark_index { get; set; }
    [ProtoMember(6)]
    public uint mark_edge_index { get; set; }
    [ProtoMember(7)]
    public uint world_id { get; set; }
    [ProtoMember(8)]
    public long create_time { get; set; }
    [ProtoMember(9)]
    public long master_set_time { get; set; }
    [ProtoMember(10)]
    public bool is_delete_wait { get; set; }
    [ProtoMember(11)]
    public uint gift_level { get; set; }
    [ProtoMember(12)]
    public uint gift_exp { get; set; }
    [ProtoMember(13)]
    public uint gift_box_key { get; set; }
    [ProtoMember(14)]
    public ulong gift_box_key_full_time { get; set; }
    [ProtoMember(15)]
    public _guild_option[] option_list { get; set; }
    [ProtoMember(16)]
    public int chang_bit_flag { get; set; }

}

[ProtoContract]
public class _guild_stat_info_server_sync
{
    [ProtoMember(1)]

    public _guild_stat_info[] stat_list { get; set; }
    [ProtoMember(2)]
    public int status_type { get; set; }
    [ProtoMember(11)]
    public int value { get; set; }

}

[ProtoContract]
public class _guild_dominion_info_server_sync
{
    [ProtoMember(1)]

    public uint[] dominion_list { get; set; }
    [ProtoMember(2)]
    public uint main_dominion { get; set; }
    [ProtoMember(3)]
    public bool is_changed { get; set; }

}

[ProtoContract]
public class _guild_wanted_target_info_server_sync
{
    [ProtoMember(1)]

    public ulong target_user_uid { get; set; }
    [ProtoMember(2)]
    public uint grade { get; set; }
    [ProtoMember(3)]
    public long start_time { get; set; }
    [ProtoMember(4)]
    public long end_time { get; set; }
    [ProtoMember(5)]
    public int kill_count { get; set; }
    [ProtoMember(6)]
    public int kill_count_limit { get; set; }

}

[ProtoContract]
public class _guild_wanted_target_kill_info_server_sync
{
    [ProtoMember(1)]

    public ulong target_user_uid { get; set; }
    [ProtoMember(2)]
    public int kill_count { get; set; }

}

[ProtoContract]
public class _guild_wanted_info_server_sync
{
    [ProtoMember(1)]

    public _guild_wanted_target_info_server_sync[] target_list { get; set; }
    [ProtoMember(2)]
    public _guild_wanted_target_kill_info_server_sync[] kill_info_list { get; set; }
    [ProtoMember(3)]
    public ulong[] del_list { get; set; }
    [ProtoMember(4)]
    public bool is_all_info { get; set; }
    [ProtoMember(5)]
    public ulong target_user_uid { get; set; }
    [ProtoMember(11)]
    public uint grade { get; set; }
    [ProtoMember(21)]
    public long start_time { get; set; }
    [ProtoMember(31)]
    public long end_time { get; set; }
    [ProtoMember(41)]
    public int kill_count { get; set; }

}

[ProtoContract]
public class _guild_alliance_info_server_sync
{
    [ProtoMember(1)]

    public ulong guild_uid { get; set; }
    [ProtoMember(2)]
    public int world_id { get; set; }

}

[ProtoContract]
public class _guild_alliance_manager_info_server_sync
{
    [ProtoMember(1)]

    public _guild_alliance_info_server_sync[] add_alliance_guild_list { get; set; }
    [ProtoMember(2)]
    public ulong[] del_alliance_guild_list { get; set; }
    [ProtoMember(3)]
    public _guild_alliance_info_server_sync[] add_alliance_guild_applicant_list { get; set; }
    [ProtoMember(4)]
    public ulong[] del_alliance_guild_applicant_list { get; set; }
    [ProtoMember(5)]
    public _guild_alliance_info_server_sync[] add_alliance_guild_receive_list { get; set; }
    [ProtoMember(6)]
    public ulong[] del_alliance_guild_receive_list { get; set; }
    [ProtoMember(7)]
    public bool is_all_info { get; set; }

}

[ProtoContract]
public class _guild_join_request_target_server_sync
{
    [ProtoMember(1)]

    public ulong user_uid { get; set; }
    [ProtoMember(2)]
    public long request_time { get; set; }

}

[ProtoContract]
public class _guild_member_join_request_info_server_sync
{
    [ProtoMember(1)]

    public _guild_join_request_target_server_sync[] invite_list { get; set; }
    [ProtoMember(2)]
    public _guild_join_request_target_server_sync[] applicant_list { get; set; }
[ProtoMember(3)]
public ulong[] del_invite_list { get; set; }
[ProtoMember(4)]
public ulong[] del_applicant_list { get; set; }
[ProtoMember(5)]
public bool is_all_info { get; set; }
    
}

[ProtoContract]
public class _guild_cost_info_server_sync
{
    [ProtoMember(1)]

    public _cost_info[] guild_cost_list { get; set; }

}

[ProtoContract]
public class _guild_shop_resister_goods_server_sync
{
    [ProtoMember(1)]

    public int goods_index { get; set; }
    [ProtoMember(2)]
    public int goods_count { get; set; }

}

[ProtoContract]
public class _guild_shop_log_server_sync
{
    [ProtoMember(1)]

    public long log_uid { get; set; }
    [ProtoMember(2)]
    public int type { get; set; }
    [ProtoMember(3)]
    public ulong user_uid { get; set; }
    [ProtoMember(4)]
    public string nick_name { get; set; }
    [ProtoMember(5)]
    public string profile { get; set; }
    [ProtoMember(6)]
    public int goods_index { get; set; }
    [ProtoMember(7)]
    public int goods_change_count { get; set; }
    [ProtoMember(8)]
    public ulong update_time { get; set; }

}

[ProtoContract]
public class _guild_shop_info_server_sync
{
    [ProtoMember(1)]

    public _guild_shop_resister_goods_server_sync[] goods_list { get; set; }
    [ProtoMember(2)]
    public _guild_shop_log_server_sync[] log_list { get; set; }
    [ProtoMember(3)]
    public long[] del_log_list { get; set; }
    [ProtoMember(4)]
    public bool is_all_info { get; set; }

}

[ProtoContract]
public class _guild_develop_info
{
    [ProtoMember(1)]

    public int index { get; set; }
    [ProtoMember(2)]
    public uint level { get; set; }
    [ProtoMember(3)]
    public int exp { get; set; }
    [ProtoMember(4)]
    public bool is_recommend { get; set; }
    [ProtoMember(5)]
    public long level_up_start_time { get; set; }
    [ProtoMember(6)]
    public long level_up_end_time { get; set; }
    [ProtoMember(7)]
    public bool is_level_up_time { get; set; }
    [ProtoMember(8)]
    public int skill_point { get; set; }
    [ProtoMember(9)]
    public bool is_skill_start { get; set; }
    [ProtoMember(10)]
    public long skill_start_time { get; set; }
    [ProtoMember(11)]
    public long skill_end_time { get; set; }
    [ProtoMember(12)]
    public int chang_bit_flag { get; set; }

}

[ProtoContract]
public class _guild_develop_list_info_server_sync
{
    [ProtoMember(1)]

    public _guild_develop_info[] develop_list { get; set; }

}

[ProtoContract]
public class _guild_hostility_info_list_server_sync
{
    [ProtoMember(1)]

    public _guild_hostility_info_server_sync[] hostility_guild_list { get; set; }
    [ProtoMember(2)]
    public ulong[] del_list { get; set; }
    [ProtoMember(3)]
    public bool is_all_info { get; set; }

}

[ProtoContract]
public class _guild_member_manager_info_server_sync
{
    [ProtoMember(1)]

    public _guild_member_info_server_sync[] add_member_info { get; set; }
    [ProtoMember(2)]
    public _guild_member_info_server_sync[] changed_member_info { get; set; }
    [ProtoMember(3)]
    public ulong[] del_list { get; set; }
    [ProtoMember(4)]
    public bool is_all_info { get; set; }

}

[ProtoContract]
public class _guild_except_attack_server_sync
{
    [ProtoMember(1)]

    public ulong guild_uid { get; set; }
    [ProtoMember(2)]
    public int world_id { get; set; }

}

[ProtoContract]
public class _guild_except_attack_info_server_sync
{
    [ProtoMember(1)]

    public _guild_except_attack_server_sync[] except_attack_info { get; set; }
    [ProtoMember(2)]
    public ulong[] del_list { get; set; }
    [ProtoMember(3)]
    public bool is_all_info { get; set; }

}

[ProtoContract]
public class _guild_command_mark_info_server_sync
{
    [ProtoMember(1)]

    public _guild_command_mark[] command_mark_list { get; set; }
    [ProtoMember(2)]
    public int[] del_list { get; set; }
    [ProtoMember(3)]
    public bool is_all_info { get; set; }

}

[ProtoContract]
public class _guild_point_server_sync
{
    [ProtoMember(1)]

    public int point_type { get; set; }
    [ProtoMember(2)]
    public int point_value { get; set; }

}

[ProtoContract]
public class _guild_point_info_server_sync
{
    [ProtoMember(1)]

    public _guild_point_server_sync[] guild_point_info { get; set; }

}

[ProtoContract]
public class _guild_info_server_sync
{
    [ProtoMember(1)]

    _guild_info_base_server_sync guild_base_info { get; set; }
    [ProtoMember(3)]
    _guild_member_join_request_info_server_sync member_request_info { get; set; }
    [ProtoMember(4)]
    _guild_wanted_info_server_sync wanted_info { get; set; }
    [ProtoMember(5)]
    _guild_alliance_manager_info_server_sync alliance_info { get; set; }
    [ProtoMember(6)]
    _guild_hostility_info_list_server_sync hostility_info { get; set; }
    [ProtoMember(7)]
    _guild_cost_info_server_sync cost_info { get; set; }
    [ProtoMember(8)]
    _guild_dominion_info_server_sync dominion_info { get; set; }
    [ProtoMember(9)]
    _guild_shop_info_server_sync guild_shop_info { get; set; }
    [ProtoMember(10)]
    _guild_develop_list_info_server_sync develop_info { get; set; }
    [ProtoMember(11)]
    _guild_except_attack_info_server_sync except_attack_info { get; set; }
    [ProtoMember(12)]
    _guild_member_manager_info_server_sync memger_info { get; set; }
    [ProtoMember(13)]
    _guild_command_mark_info_server_sync command_mark_info { get; set; }
    [ProtoMember(14)]
    _guild_point_info_server_sync point_info { get; set; }
    [ProtoMember(15)]
    _guild_stat_info_server_sync stat_info { get; set; }
    [ProtoMember(16)]
    public bool is_all { get; set; }

}

[ProtoContract]
public class _guild_rank_sync
{
    [ProtoMember(1)]

    public ulong guild_uid { get; set; }
    [ProtoMember(2)]
    public uint rank { get; set; }

}

[ProtoContract]
public class WORLD_GAME_GUILD_INFO_SERVER_SYNC
{
    [ProtoMember(1)]

    public ulong guild_uid { get; set; }
    [ProtoMember(2)]
    _guild_info_server_sync guild_info { get; set; }
    [ProtoMember(3)]
    public int result { get; set; }

}

[ProtoContract]
public class WORLD_GAME_GUILD_CHANGE_STAT_SERVER_SYNC
{
    [ProtoMember(1)]

    public ulong guild_uid { get; set; }
    [ProtoMember(2)]
    _guild_stat_info_server_sync stat_info { get; set; }
    [ProtoMember(3)]
    public _guild_stat_info[] stat_list { get; set; }

}

[ProtoContract]
public class GUILD_WORLD_GUILD_CHANGE_STAT_SERVER_SYNC
{
    [ProtoMember(1)]

    public ulong guild_uid { get; set; }
    [ProtoMember(2)]
    _guild_stat_info_server_sync stat_info { get; set; }

}

[ProtoContract]
public class GUILD_WORLD_GUILD_LEVELUP_SERVER_SYNC
{
    [ProtoMember(1)]

    public ulong guild_uid { get; set; }
    [ProtoMember(2)]
    public int guild_level { get; set; }
    [ProtoMember(3)]
    public ulong guild_exp { get; set; }

}

[ProtoContract]
public class GUILD_WORLD_GUILD_INFO_SERVER_SYNC_REQ
{
    [ProtoMember(1)]

    public ulong guild_uid { get; set; }
    [ProtoMember(2)]
    public uint start_world_id { get; set; }

}

[ProtoContract]
public class WORLD_GAME_GUILD_MEMBER_INFO_SERVER_SYNC
{
    [ProtoMember(1)]

    public ulong guild_uid { get; set; }
    [ProtoMember(2)]
    public _guild_member_info_server_sync[] member_info { get; set; }

}

[ProtoContract]
public class WORLD_GAME_GUILD_MEMBER_CHANGE_INFO_SERVER_SYNC
{
    [ProtoMember(1)]

    public ulong guild_uid { get; set; }
    [ProtoMember(2)]
    public _guild_member_info_server_sync[] member_info_list { get; set; }

}

[ProtoContract]
public class WORLD_GAME_GUILD_MEMBER_REQUEST_SERVER_SYNC
{
    [ProtoMember(1)]

    public ulong guild_uid { get; set; }
    [ProtoMember(2)]
    public ulong del_invite_user_uid { get; set; }
    [ProtoMember(3)]
    public ulong del_applicant_user_uid { get; set; }

}

[ProtoContract]
public class WORLD_GAME_GUILD_END_SERVER_SYNC
{
    [ProtoMember(1)]

    public ulong guild_uid { get; set; }

}

[ProtoContract]
public class GUILD_WORLD_GUILD_END_SERVER_SYNC
{
    [ProtoMember(1)]

    public ulong guild_uid { get; set; }

}

[ProtoContract]
public class WORLD_GAME_GUILD_RELOAD
{
    [ProtoMember(1)]

    public uint target_guild_world_id { get; set; }
    [ProtoMember(2)]
    public ulong[] target_guild_uid { get; set; }
    [ProtoMember(3)]
    public bool is_server_expedition { get; set; }

}

[ProtoContract]
public class WORLD_GAME_GUILD_SHOP_LOG_SYNC
{
    [ProtoMember(1)]

    public ulong guild_uid { get; set; }
    [ProtoMember(2)]
    public _guild_shop_log_server_sync[] shop_log { get; set; }
    [ProtoMember(3)]
    public long[] register_del_log_uid { get; set; }
    [ProtoMember(4)]
    public long[] buy_del_log_uid { get; set; }

}

[ProtoContract]
public class GUILD_WORLD_GUILD_INFO_SERVER_SYNC
{
    [ProtoMember(1)]

    public ulong guild_uid { get; set; }
    [ProtoMember(2)]
    _guild_info_server_sync guild_info { get; set; }

}

[ProtoContract]
public class WORLD_GUILD_GUILD_INFO_SERVER_SYNC
{
    [ProtoMember(1)]

    public ulong guild_uid { get; set; }
    [ProtoMember(2)]
    _guild_info_server_sync guild_info { get; set; }

}

[ProtoContract]
public class GUILD_WORLD_GUILD_DELETE_SERVER_SYNC
{
    [ProtoMember(1)]

    public ulong guild_uid { get; set; }

}

[ProtoContract]
public class GUILD_WORLD_GUILD_COST_SERVER_SYNC
{
    [ProtoMember(1)]

    public ulong guild_uid { get; set; }
    [ProtoMember(2)]
    public _cost_info[] guild_cost_info { get; set; }

}

[ProtoContract]
public class GUILD_WORLD_SYNC_PLAY_WORLD_ID
{
    [ProtoMember(1)]

    public int world_id { get; set; }
    [ProtoMember(2)]
    public bool is_login { get; set; }

}

[ProtoContract]
public class GUILD_WORLD_GUILD_DEVELOP_SERVER_SYNC
{
    [ProtoMember(1)]

    public ulong guild_uid { get; set; }
    [ProtoMember(2)]
    _guild_develop_list_info_server_sync develop_info { get; set; }

}

[ProtoContract]
public class GUILD_WORLD_OTHER_WORLD_GUILD_LOAD_SYNC
{
    [ProtoMember(1)]

    public ulong guild_uid { get; set; }
    [ProtoMember(2)]
    public uint world_id { get; set; }

}

[ProtoContract]
public class GUILD_WORLD_SEND_GUILD_INFO_RESET
{
    [ProtoMember(1)]

    public uint world_id { get; set; }

}

[ProtoContract]
public class GUILD_WORLD_GUILD_OFFICIAL_GRADE
{
    [ProtoMember(1)]

    public ulong guild_uid { get; set; }
    [ProtoMember(2)]
    public _guild_member_info_server_sync[] member_info_list { get; set; }

}

[ProtoContract]
public class GAME_WORLD_GUILD_INFO_SYNC_REQUEST
{
    [ProtoMember(1)]

    public ulong guild_uid { get; set; }
    [ProtoMember(2)]
    public int zone_group_id { get; set; }

}

[ProtoContract]
public class GUILD_WORLD_SYNC_USER_INFO_BY_GUILD_MEMBER_REQ
{
    [ProtoMember(1)]

    public ulong guild_uid { get; set; }
    [ProtoMember(2)]
    _guild_member_info_server_sync member_info { get; set; }

}

[ProtoContract]
public class GUILD_WORLD_GUILD_MEMBER_LOCATION_SYNC_REQ
{
    [ProtoMember(1)]

    public ulong guild_uid { get; set; }
    [ProtoMember(2)]
    public ulong user_uid { get; set; }
    [ProtoMember(3)]
    public uint locate { get; set; }
    [ProtoMember(4)]
    public int current_server_pos { get; set; }

}

[ProtoContract]
public class GUILD_WORLD_GUILD_MEMBER_PROFILE_CHANGE_REQ
{
    [ProtoMember(1)]

    public ulong guild_uid { get; set; }
    [ProtoMember(2)]
    public ulong user_uid { get; set; }
    [ProtoMember(3)]
    public string profile { get; set; }

}

[ProtoContract]
public class _db_load_guild_info
{
    [ProtoMember(1)]

    public ulong guild_uid { get; set; }
    [ProtoMember(2)]
    public string guild_name { get; set; }
    [ProtoMember(3)]
    public int mark_id { get; set; }
    [ProtoMember(4)]
    public int mark_edge { get; set; }
    [ProtoMember(5)]
    public string guild_pr { get; set; }
    [ProtoMember(6)]
    public long exp { get; set; }
    [ProtoMember(7)]
    public uint level { get; set; }
    [ProtoMember(8)]
    public uint guild_gift_level { get; set; }
    [ProtoMember(9)]
    public uint guild_gift_exp { get; set; }
    [ProtoMember(10)]
    public uint guild_gift_box_key { get; set; }
    [ProtoMember(11)]
    public ulong guild_gift_box_key_full_time { get; set; }
    [ProtoMember(12)]
    public uint world_id { get; set; }
    [ProtoMember(13)]
    public long create_time { get; set; }
    [ProtoMember(14)]
    public uint is_npc_shop_open { get; set; }
    [ProtoMember(15)]
    public uint is_npc_shop_stop { get; set; }
    [ProtoMember(16)]
    public long npc_shop_open_time { get; set; }
    [ProtoMember(17)]
    public long npc_shop_end_time { get; set; }
    [ProtoMember(18)]
    public long master_set_time { get; set; }
    [ProtoMember(19)]
    public uint delete_reserve { get; set; }
    [ProtoMember(20)]
    public uint npc_shop_not_first_open { get; set; }
    [ProtoMember(21)]
    public int npc_shop_dominion_tid { get; set; }

}

[ProtoContract]
public class _db_load_guild_option
{
    [ProtoMember(1)]

    public int option_index { get; set; }
    [ProtoMember(2)]
    public int option_value { get; set; }

}

[ProtoContract]
public class _db_load_guild_develop
{
    [ProtoMember(1)]

    public uint index { get; set; }
    [ProtoMember(2)]
    public uint level { get; set; }
    [ProtoMember(3)]
    public int exp { get; set; }
    [ProtoMember(4)]
    public uint is_recommend { get; set; }
    [ProtoMember(5)]
    public long level_up_start_time { get; set; }
    [ProtoMember(6)]
    public long level_up_end_time { get; set; }
    [ProtoMember(7)]
    public int level_up { get; set; }
    [ProtoMember(8)]
    public int skill_point { get; set; }
    [ProtoMember(9)]
    public int skill_start { get; set; }
    [ProtoMember(10)]
    public long skill_start_time { get; set; }
    [ProtoMember(11)]
    public long skill_end_time { get; set; }

}

[ProtoContract]
public class _db_load_guild_member
{
    [ProtoMember(1)]

    public ulong user_uid { get; set; }
    [ProtoMember(2)]
    public string nick_name { get; set; }
    [ProtoMember(3)]
    public uint _class { get; set; }
    [ProtoMember(4)]
    public uint level { get; set; }
    [ProtoMember(5)]
    public long logout_time { get; set; }
    [ProtoMember(6)]
    public int combat_point { get; set; }
    [ProtoMember(7)]
    public uint member_grade { get; set; }
    [ProtoMember(8)]
    string guild_custom_title { get; set; }
    [ProtoMember(9)]
    public long member_join_time { get; set; }
    [ProtoMember(10)]
    public string profile { get; set; }
    [ProtoMember(11)]
    public ulong partner_member_uid { get; set; }
    [ProtoMember(12)]
    public int cost_give_count { get; set; }
    [ProtoMember(13)]
    public long cost_give_time { get; set; }
    [ProtoMember(14)]
    public int official_grade { get; set; }
    [ProtoMember(15)]
    public long last_donation_time { get; set; }
    [ProtoMember(16)]
    public _character_guild_receive_cost_server_sync[] receive_cost { get; set; }

}

[ProtoContract]
public class _db_load_guild_alliance
{
    [ProtoMember(1)]

    public ulong target_guild_uid { get; set; }
    [ProtoMember(2)]
    public uint target_world_id { get; set; }

}

[ProtoContract]
public class _db_load_guild_member_join_request
{
    [ProtoMember(1)]

    public ulong character_uid { get; set; }
    [ProtoMember(2)]
    public ulong time { get; set; }

}

[ProtoContract]
public class _db_load_guild_member_authority
{
    [ProtoMember(1)]

    public ulong character_uid { get; set; }
    [ProtoMember(2)]
    public uint[] option_type_list { get; set; }

}

[ProtoContract]
public class _db_load_guild_supply_unlock_time
{
    [ProtoMember(1)]

    public uint supply_index { get; set; }
    [ProtoMember(2)]
    public long unlock_time { get; set; }
    [ProtoMember(3)]
    public long supply_reward_time { get; set; }

}

[ProtoContract]
public class _db_load_guild_hostility
{
    [ProtoMember(1)]

    public ulong declare_guild_uid { get; set; }
    [ProtoMember(2)]
    public ulong target_guild_uid { get; set; }
    [ProtoMember(3)]
    public ulong start_time { get; set; }
    [ProtoMember(4)]
    public ulong end_time { get; set; }
    [ProtoMember(5)]
    public int declare_guild_kill_count { get; set; }
    [ProtoMember(6)]
    public int target_guild_kill_count { get; set; }
    [ProtoMember(7)]
    public uint declare_world_id { get; set; }
    [ProtoMember(8)]
    public uint target_world_id { get; set; }

}

[ProtoContract]
public class _db_load_guild_money
{
    [ProtoMember(1)]

    public uint money_index { get; set; }
    [ProtoMember(2)]
    public long money_amount { get; set; }

}

[ProtoContract]
public class _db_load_guild_expedition
{
    [ProtoMember(1)]

    public uint expedission_id { get; set; }
    [ProtoMember(2)]
    public ulong clear_date { get; set; }

}

[ProtoContract]
public class _db_load_guild_wanted
{
    [ProtoMember(1)]

    public ulong character_uid { get; set; }
    [ProtoMember(2)]
    public uint wanted_grade { get; set; }
    [ProtoMember(3)]
    public int kill_count { get; set; }
    [ProtoMember(4)]
    public long start_time { get; set; }
    [ProtoMember(5)]
    public long end_time { get; set; }
    [ProtoMember(6)]
    public int kill_count_limit { get; set; }

}

[ProtoContract]
public class _db_load_guild_shop_data
{
    [ProtoMember(1)]

    public int goods_index { get; set; }
    [ProtoMember(2)]
    public int goods_count { get; set; }

}

[ProtoContract]
public class _db_load_guild_shop_log_data
{
    [ProtoMember(1)]

    public long log_uid { get; set; }
    [ProtoMember(2)]
    public uint action_type { get; set; }
    [ProtoMember(3)]
    public long log_time { get; set; }
    [ProtoMember(4)]
    public string user_name { get; set; }
    [ProtoMember(5)]
    public string user_profile { get; set; }
    [ProtoMember(6)]
    public long character_uid { get; set; }
    [ProtoMember(7)]
    public int goods_index { get; set; }
    [ProtoMember(8)]
    public int goods_count { get; set; }

}

[ProtoContract]
public class _db_load_guild_history_uid
{
    [ProtoMember(1)]

    public uint history_group_id { get; set; }
    [ProtoMember(2)]
    public long[] history_uid { get; set; }

}

[ProtoContract]
public class _db_load_guild_npc_shop
{
    [ProtoMember(1)]

    public int cost_type { get; set; }
    [ProtoMember(2)]
    public int sell_cont { get; set; }
    [ProtoMember(3)]
    public int remain_sell_cont { get; set; }
    [ProtoMember(4)]
    public int sell_price { get; set; }

}

[ProtoContract]
public class _db_load_guild_npc_shop_incom
{
    [ProtoMember(1)]

    public uint money_index { get; set; }
    [ProtoMember(2)]
    public long money_amount { get; set; }

}

[ProtoContract]
public class _db_load_guild_expedition_create
{
    [ProtoMember(1)]

    public uint expedission_id { get; set; }
    [ProtoMember(2)]
    public uint summon_count { get; set; }
    [ProtoMember(3)]
    public long create_date { get; set; }
    [ProtoMember(4)]
    public long expedition_reset_time { get; set; }

}

[ProtoContract]
public class _db_load_guild_cost
{
    [ProtoMember(1)]

    public uint money_index { get; set; }
    [ProtoMember(2)]
    public long money_amount { get; set; }

}

[ProtoContract]
public class _db_load_guild_member_donation
{
    [ProtoMember(1)]

    public ulong user_uid { get; set; }
    [ProtoMember(2)]
    public _db_load_guild_cost[] cost_list { get; set; }

}

[ProtoContract]
public class _db_load_guild_except_attack
{
    [ProtoMember(1)]

    public ulong target_guild_uid { get; set; }
    [ProtoMember(2)]
    public uint target_world_id { get; set; }

}

[ProtoContract]
public class _db_load_guild_point
{
    [ProtoMember(1)]

    public int point_type { get; set; }
    [ProtoMember(2)]
    public int point_value { get; set; }

}

[ProtoContract]
public class _db_load_guild
{
    [ProtoMember(1)]

    public _db_load_guild_info db_load_guild_info { get; set; }
    [ProtoMember(2)]
    public _db_load_guild_option[] db_load_guild_option_list { get; set; }
    [ProtoMember(3)]
    public _db_load_guild_develop[] db_load_guild_develop_list { get; set; }
    [ProtoMember(4)]
    public _db_load_guild_member[] db_load_guild_member_list { get; set; }
    [ProtoMember(5)]
    public _db_load_guild_alliance[] db_load_guild_alliance_list { get; set; }
    [ProtoMember(6)]
    public _db_load_guild_alliance[] db_load_guild_alliance_request_list { get; set; }
    [ProtoMember(7)]
    public _db_load_guild_member_join_request[] db_load_guild_join_invite_list { get; set; }
    [ProtoMember(8)]
    public _db_load_guild_member_join_request[] db_load_guild_join_applicant_list { get; set; }
    [ProtoMember(9)]
    public _db_load_guild_member_authority[] db_load_guild_member_authority_list { get; set; }
    [ProtoMember(10)]
    public _db_load_guild_supply_unlock_time[] db_load_guild_supply_unlock_time_list { get; set; }
    [ProtoMember(11)]
    public _db_load_guild_hostility[] db_load_guild_hostility_list { get; set; }
    [ProtoMember(12)]
    public _db_load_guild_money[] db_load_guild_money_list { get; set; }
    [ProtoMember(13)]
    public _db_load_guild_expedition[] db_load_guild_expedition_list { get; set; }
    [ProtoMember(14)]
    public _db_load_guild_wanted[] db_load_guild_wanted_list { get; set; }
    [ProtoMember(15)]
    public _db_load_guild_shop_data[] db_load_guild_shop_data_list { get; set; }
    [ProtoMember(16)]
    public _db_load_guild_shop_log_data[] db_load_guild_shop_log_data_list { get; set; }
    [ProtoMember(17)]
    public _db_load_guild_npc_shop[] db_load_guild_npc_shop_list { get; set; }
    [ProtoMember(18)]
    public _db_load_guild_npc_shop_incom[] db_load_guild_npc_shop_incom_list { get; set; }
    [ProtoMember(19)]
    public _db_load_guild_expedition_create[] db_load_guild_expedition_create_list { get; set; }
    [ProtoMember(20)]
    public _db_load_guild_member_donation[] db_load_guild_member_donation_daily_list { get; set; }
    [ProtoMember(21)]
    public _db_load_guild_member_donation[] db_load_guild_member_donation_weekly_list { get; set; }
    [ProtoMember(22)]
    public _db_load_guild_except_attack[] db_load_guild_except_attack_list { get; set; }
    [ProtoMember(23)]
    public _guild_command_mark_info_server_sync[] command_mark_info { get; set; }
    [ProtoMember(24)]
    public _db_load_guild_alliance[] db_load_guild_alliance_receive_list { get; set; }
    [ProtoMember(25)]
    public _db_load_guild_point[] db_load_guild_point_list { get; set; }

}

[ProtoContract]
public class WORLD_SERVER_LOAD_GUILD_INFO
{
    [ProtoMember(1)]

    public _db_load_guild[] load_guild { get; set; }

}

[ProtoContract]
public class WORLD_SERVER_LOAD_GUILD_INFO_FINISH
{

}

[ProtoContract]
public class WORLD_SERVER_GUILD_INFO_ETC_SETTING
{
}

[ProtoContract]
public class _guild_relay_packet_info
{
    [ProtoMember(1)]

    public uint cmd { get; set; }
    [ProtoMember(2)]
    public uint world_id { get; set; }
    [ProtoMember(3)]
    public uint target_world_id { get; set; }
    [ProtoMember(4)]
    public byte[] context { get; set; }

}

[ProtoContract]
public class GUILD_WORLD_REALAY_PACKET_TO_ALL_ZONE_GROUP_BROADCAST
{
    [ProtoMember(1)]

    _guild_relay_packet_info packet_info { get; set; }

}

[ProtoContract]
public class WORLD_GUILD_RELAY_PACKET_TO_WORLD_BROADCAST
{
    [ProtoMember(1)]

    _guild_relay_packet_info packet_info { get; set; }

}

[ProtoContract]
public class GUILD_WORLD_REALAY_PACKET_TO_TARGET_USER
{
    [ProtoMember(1)]

    public ulong user_uid { get; set; }
    [ProtoMember(2)]
    _guild_relay_packet_info packet_info { get; set; }

}

[ProtoContract]
public class GUILD_WORLD_REALAY_PACKET_TO_ZONE_GROUP
{
    [ProtoMember(1)]

    public int world_server_zone_group_id { get; set; }
    [ProtoMember(2)]
    _guild_relay_packet_info packet_info { get; set; }

}

[ProtoContract]
public class GAME_GUILD_RELAY_PACKET_TO_TARGET_WORLD
{
    [ProtoMember(1)]

    _guild_relay_packet_info packet_info { get; set; }

}

[ProtoContract]
public class WORLD_GUILD_RELAY_PACKET_TO_TARGET_WORLD
{
    [ProtoMember(1)]

    _guild_relay_packet_info packet_info { get; set; }

}

[ProtoContract]
public class GUILD_WORLD_GUILD_CREATION
{
    [ProtoMember(1)]

    public ulong guild_uid { get; set; }
    [ProtoMember(2)]
    _guild_info_server_sync guild_sync_info { get; set; }

}

[ProtoContract]
public class GUILD_WORLD_GUILD_NAME_CHANGE
{
    [ProtoMember(1)]

    public ulong guild_uid { get; set; }
    [ProtoMember(2)]
    _guild_info_base_server_sync guild_base_info { get; set; }

}

[ProtoContract]
public class GUILD_WORLD_GUILD_MEMBER_ADD
{
    [ProtoMember(1)]

    public ulong guild_uid { get; set; }
    [ProtoMember(2)]
    _guild_info_server_sync guild_sync_info { get; set; }

}

[ProtoContract]
public class GUILD_WORLD_GUILD_MEMBER_DEL
{
    [ProtoMember(1)]

    public ulong guild_uid { get; set; }
    [ProtoMember(2)]
    _guild_info_server_sync guild_sync_info { get; set; }

}

[ProtoContract]
public class GUILD_WORLD_GUILD_HOSTILITY_ADD_SERVER_SYNC
{
    [ProtoMember(1)]

    public ulong guild_uid { get; set; }
    [ProtoMember(2)]
    _guild_hostility_info_list_server_sync hostility_info { get; set; }

}

[ProtoContract]
public class GUILD_WORLD_GUILD_HOSTILITY_DEL_SERVER_SYNC
{
    [ProtoMember(1)]

    public ulong guild_uid { get; set; }
    [ProtoMember(2)]
    _guild_hostility_info_list_server_sync hostility_info { get; set; }

}

[ProtoContract]
public class GUILD_WORLD_GUILD_ALLIANCE_APPLICANT_SERVER_SYNC
{
    [ProtoMember(1)]

    public ulong guild_uid { get; set; }
    [ProtoMember(2)]
    _guild_alliance_manager_info_server_sync alliance_info { get; set; }

}

[ProtoContract]
public class GUILD_WORLD_GUILD_ALLIANCE_ADD_SERVER_SYNC
{
    [ProtoMember(1)]

    public ulong guild_uid { get; set; }
    [ProtoMember(2)]
    _guild_alliance_manager_info_server_sync alliance_info { get; set; }

}

[ProtoContract]
public class GUILD_WORLD_GUILD_ALLIANCE_DEL_SERVER_SYNC
{
    [ProtoMember(1)]

    public ulong guild_uid { get; set; }
    [ProtoMember(2)]
    _guild_alliance_manager_info_server_sync alliance_info { get; set; }

}

[ProtoContract]
public class GUILD_WORLD_GUILD_RANK_SORT_DATA_SERVER_SYNC
{
    [ProtoMember(1)]

    public uint target_world_id { get; set; }
    [ProtoMember(2)]
    public _guild_rank_sync guild_rank_list { get; set; }

}

[ProtoContract]
public class GUILD_WORLD_GUILD_MEMBER_GRADE_SET
{
    [ProtoMember(1)]

    public ulong guild_uid { get; set; }
    [ProtoMember(2)]
    public _guild_member_info[] _server_sync_member_info_list { get; set; } 
    
}

[ProtoContract]
public class GUILD_WORLD_GUILD_CHANGE_PR_SERVER_SYNC
{
    [ProtoMember(1)]

    public ulong guild_uid { get; set; }
    [ProtoMember(2)]
    public uint world_id { get; set; }
    [ProtoMember(3)]
    public string guild_pr { get; set; }

}

[ProtoContract]
public class GUILD_WORLD_GUILD_OPTION_SET_SYNC
{
    [ProtoMember(1)]

    public ulong guild_uid { get; set; }
    [ProtoMember(2)]
    _guild_info_base_server_sync guild_base_info { get; set; }

}

[ProtoContract]
public class GUILD_WORLD_GUILD_HOSTILITY_KILL_SYNC
{
    [ProtoMember(1)]

    public ulong guild_uid { get; set; }
    [ProtoMember(2)]
    _guild_hostility_info_list_server_sync hostility_info { get; set; }

}

[ProtoContract]
public class GUILD_WORLD_GUILD_GIFT_OPEN_SYNC
{
    [ProtoMember(1)]

    public ulong guild_uid { get; set; }
    [ProtoMember(2)]
    _guild_gift_box_info gift_box_info { get; set; }

}

[ProtoContract]
public class GUILD_WORLD_GUILD_EXCEPT_ATTACK_SYNC
{
    [ProtoMember(1)]

    public ulong guild_uid { get; set; }
    [ProtoMember(2)]
    public bool except_attack_add { get; set; }
    [ProtoMember(3)]
    public _guild_except_attack_server_sync except_attack_info { get; set; }

}

[ProtoContract]
public class GUILD_WORLD_GUILD_MEMBER_REQUEST_SERVER_SYNC
{
    [ProtoMember(1)]

    public ulong guild_uid { get; set; }
    [ProtoMember(2)]
    _guild_member_join_request_info_server_sync member_request_info { get; set; }

}

[ProtoContract]
public class GUILD_WORLD_GUILD_MEMBER_INVITE
{
    [ProtoMember(1)]

    public ulong guild_uid { get; set; }
    [ProtoMember(2)]
    _guild_member_join_request_info_server_sync member_request_info { get; set; }

}

[ProtoContract]
public class GUILD_WORLD_GUILD_MEMBER_INVITE_AGREE
{
    [ProtoMember(1)]

    public ulong guild_uid { get; set; }
    [ProtoMember(2)]
    _guild_member_join_request_info_server_sync member_request_info { get; set; }
    [ProtoMember(3)]
    _guild_member_manager_info_server_sync memger_info { get; set; }

}

[ProtoContract]
public class GUILD_WORLD_GUILD_MEMBER_AUTHORITY_SET
{
    [ProtoMember(1)]

    public ulong guild_uid { get; set; }
    [ProtoMember(2)]
    _guild_member_manager_info_server_sync memger_info { get; set; }

}

[ProtoContract]
public class GUILD_WORLD_GUILD_PARTNER_MEMBET_SET
{
    [ProtoMember(1)]

    public ulong guild_uid { get; set; }
    [ProtoMember(2)]
    _guild_member_manager_info_server_sync memger_info { get; set; }

}

[ProtoContract]
public class GUILD_WORLD_GUILD_MEMBER_CUSTOM_TITLE_SET
{
    [ProtoMember(1)]

    public ulong guild_uid { get; set; }
    [ProtoMember(2)]
    _guild_member_info_server_sync member_info { get; set; }

}

[ProtoContract]
public class GUILD_WORLD_GUILD_MEMBER_CHANGE_INFO_SERVER_SYNC
{
    [ProtoMember(1)]

    public ulong guild_uid { get; set; }
    [ProtoMember(2)]
    _guild_member_manager_info_server_sync member_info { get; set; }

}

[ProtoContract]
public class GUILD_WORLD_GUILD_DEVELOP_RECOMMEND
{
    [ProtoMember(1)]

    public ulong guild_uid { get; set; }
    [ProtoMember(2)]
    _guild_develop_list_info_server_sync develop_info { get; set; }

}

[ProtoContract]
public class GUILD_WORLD_GUILD_DEVELOP_SKILL_END
{
    [ProtoMember(1)]

    public ulong guild_uid { get; set; }
    [ProtoMember(2)]
    _guild_develop_list_info_server_sync develop_info { get; set; }

}

[ProtoContract]
public class GUILD_WORLD_GUILD_DEVELOP_SKILL_START
{
    [ProtoMember(1)]

    public ulong guild_uid { get; set; }
    [ProtoMember(2)]
    _guild_develop_list_info_server_sync develop_info { get; set; }

}

[ProtoContract]
public class GUILD_WORLD_GUILD_SHOP_SERVER_SYNC
{
    [ProtoMember(1)]

    public ulong guild_uid { get; set; }
    [ProtoMember(2)]
    _guild_shop_info_server_sync guild_shop_info { get; set; }

}

[ProtoContract]
public class GUILD_WORLD_GUILD_WANTED_SERVER_SYNC
{
    [ProtoMember(1)]

    public ulong guild_uid { get; set; }
    [ProtoMember(2)]
    _guild_wanted_info_server_sync wanted_info { get; set; }

}

[ProtoContract]
public class GUILD_WORLD_GUILD_COMMAND_MARK_SET
{
    [ProtoMember(1)]

    public ulong guild_uid { get; set; }
    [ProtoMember(2)]
    _guild_command_mark_info_server_sync command_mark_info { get; set; }

}

[ProtoContract]
public class _guild_war_board_user_view_info
{
    [ProtoMember(1)]

    public ulong user_uid { get; set; }
    [ProtoMember(2)]
    public ulong guild_uid { get; set; }
    [ProtoMember(3)]
    public bool is_guild_master { get; set; }
    [ProtoMember(4)]
    public ulong party_uid { get; set; }
    [ProtoMember(5)]
    public bool is_party_leader { get; set; }
    [ProtoMember(6)]
    public uint user_status { get; set; }
    [ProtoMember(7)]
    public _vector3 cur_pos { get; set; }
    [ProtoMember(8)]
    public int guild_camp_kind { get; set; }

}

[ProtoContract]
public class _guild_war_board_user_move_info
{
    [ProtoMember(1)]

    public ulong user_uid { get; set; }
    [ProtoMember(2)]
    public _vector3 cur_pos { get; set; }

}

[ProtoContract]
public class _guild_war_board_command_info
{
    [ProtoMember(1)]

    public int command_mark_tid { get; set; }
    [ProtoMember(2)]
    public _vector3 target_pos { get; set; }
        [ProtoMember(3)]
        public string _msg { get; set; }

    
}

[ProtoContract]
public class _guild_war_board_class_info
{
    [ProtoMember(1)]

    public int user_class { get; set; }
    [ProtoMember(2)]
    public int defense_user_count { get; set; }
    [ProtoMember(3)]
    public int offense_user_count { get; set; }

}

[ProtoContract]
public class _guild_war_board_watcher_ui_info
{
    [ProtoMember(1)]

    public ulong defense_combat_point { get; set; }
    [ProtoMember(2)]
    public ulong offense_combat_point { get; set; }
    [ProtoMember(3)]
    public _guild_war_board_class_info guild_war_board_class_info_list { get; set; }

}

[ProtoContract]
public class CLIENT_GAME_REQ_GUILD_WAR_BOARD_INFO
{
    [ProtoMember(1)]

    public int info_req_kind { get; set; }

}

[ProtoContract]
public class GAME_CLIENT_ACK_GUILD_WAR_BOARD_INFO
{
    [ProtoMember(1)]

    public uint result { get; set; }

}

[ProtoContract]
public class GAME_CLIENT_NTF_GUILD_WAR_BOARD_MOVE_INFO
{
    [ProtoMember(1)]

    public int info_req_kind { get; set; }
    [ProtoMember(2)]
    public _guild_war_board_user_move_info user_move_info_list { get; set; }

}

[ProtoContract]
public class CLIENT_GAME_REQ_GUILD_WAR_COMMAND
{
    [ProtoMember(1)]

    public int command_update_kind { get; set; }
    [ProtoMember(2)]
    _guild_war_board_command_info command_info { get; set; }

}

[ProtoContract]
public class GAME_CLIENT_ACK_GUILD_WAR_COMMAND
{
    [ProtoMember(1)]

    public uint result { get; set; }
    [ProtoMember(2)]
    public int command_update_kind { get; set; }
    [ProtoMember(3)]
    _guild_war_board_command_info command_info { get; set; }

}

[ProtoContract]
public class GAME_CLIENT_NTF_GUILD_WAR_COMMAND
{
    [ProtoMember(1)]

    public int command_update_kind { get; set; }
    [ProtoMember(2)]
    _guild_war_board_command_info command_info { get; set; }

}


[ProtoContract]
public class _plunder_trap_info
{
    [ProtoMember(1)]

    public int monster_tid { get; set; }
    [ProtoMember(2)]
    public int production_remain_second { get; set; }

}

[ProtoContract]
public class GAME_WORLD_NTF_PLUNDER_REWARD_BOX_OPENED
{
    [ProtoMember(1)]

    public int plunder_tid { get; set; }
    [ProtoMember(2)]
    public ulong plunder_zone_uid { get; set; }
    [ProtoMember(3)]
    public ulong opened_user_uid { get; set; }
    [ProtoMember(4)]
    public long battle_tax_plunder_value { get; set; }
    [ProtoMember(5)]
    public long added_battle_tax_plunder_value { get; set; }

}

[ProtoContract]
public class GAME_CLIENT_NTF_PLUNDER_ZONE_ENTER_INFO
{
    [ProtoMember(1)]

    _plunder_info plunder_info { get; set; }
    [ProtoMember(2)]
    public int guild_camp_kind { get; set; }
    [ProtoMember(3)]
    public long black_iron_plunder_total_count { get; set; }
    [ProtoMember(4)]
    public _plunder_trap_info plunder_trap_info_list { get; set; }
    [ProtoMember(5)]
    public int plunder_run_time_minute { get; set; }

}

[ProtoContract]
public class WORLD_GAME_NTF_PLUNDER_SERVER_INFO
{
    [ProtoMember(1)]

    _plunder_server_info plunder_server_info { get; set; }
    [ProtoMember(2)]
    public ulong plunder_zone_uid { get; set; }

}

[ProtoContract]
public class WORLD_GAME_NTF_PLUNDER_PREPARE_START
{
    [ProtoMember(1)]

    _plunder_server_info plunder_server_info { get; set; }
    [ProtoMember(2)]
    public ulong plunder_zone_uid { get; set; }

}

[ProtoContract]
public class WORLD_GAME_NTF_PLUNDER_BATTLE_START
{
    [ProtoMember(1)]

    _plunder_server_info plunder_server_info { get; set; }
    [ProtoMember(2)]
    public ulong plunder_zone_uid { get; set; }

}

[ProtoContract]
public class WORLD_GAME_NTF_PLUNDER_BATTLE_END_TIMEOUT
{
    [ProtoMember(1)]

    _plunder_server_info plunder_server_info { get; set; }
    [ProtoMember(2)]
    public ulong plunder_zone_uid { get; set; }

}

[ProtoContract]
public class WORLD_GAME_NTF_PLUNDER_BATTLE_END_OCCUPY_CHANGE
{
    [ProtoMember(1)]

    _plunder_server_info plunder_server_info { get; set; }
    [ProtoMember(2)]
    public ulong plunder_zone_uid { get; set; }

}

[ProtoContract]
public class GAME_CLIENT_NTF_PLUNDER_END_TO_BATTLE_USER
{
    [ProtoMember(1)]

    public int battle_end_type { get; set; }

}

[ProtoContract]
public class WORLD_GAME_NTF_PLUNDER_LOCK_START_GM_TOOL
{
    [ProtoMember(1)]

    _plunder_server_info plunder_server_info { get; set; }
    [ProtoMember(2)]
    public ulong plunder_zone_uid { get; set; }
    [ProtoMember(3)]
    public bool is_battle_end { get; set; }

}

[ProtoContract]
public class WORLD_GAME_NTF_PLUNDER_LOCK_STOP_GM_TOOL
{
    [ProtoMember(1)]

    _plunder_server_info plunder_server_info { get; set; }
    [ProtoMember(2)]
    public ulong plunder_zone_uid { get; set; }

}

[ProtoContract]
public class CLIENT_WORLD_REQ_PLUNDER_INFO
{
    [ProtoMember(1)]

    public int plunder_tid { get; set; }

}

[ProtoContract]
public class WORLD_CLIENT_ACK_PLUNDER_INFO
{
    [ProtoMember(1)]

    _plunder_info plunder_info { get; set; }
    [ProtoMember(2)]
    public long black_iron_plunder_count { get; set; }
    [ProtoMember(3)]
    public long black_iron_plunder_repayment_count { get; set; }
    [ProtoMember(4)]
    public int plunder_run_time_minute { get; set; }
    [ProtoMember(5)]
    public int battle_npc_status { get; set; }
    [ProtoMember(6)]
    public uint channel_state { get; set; }
    [ProtoMember(7)]
    public long black_iron_plunder_total_count { get; set; }

}

[ProtoContract]
public class WORLD_GAME_SYNC_PLUNDER_INFO_IN_ZONE_GROUP
{
    [ProtoMember(1)]

    _plunder_server_info plunder_server_info { get; set; }

}

[ProtoContract]
public class WORLD_GAME_SYNC_PLUNDER_INFO_LIST_IN_ZONE_GROUP
{
    [ProtoMember(1)]

    public _plunder_server_info plunder_server_info_list { get; set; }

}

[ProtoContract]
public class SERVER_CLIENT_NTF_NOTICE_PLUNDER
{
    [ProtoMember(1)]

    public int plunder_tid { get; set; }
    [ProtoMember(2)]
    public uint notice_type { get; set; }
    [ProtoMember(3)]
    public int monster_tid { get; set; }
    [ProtoMember(4)]
    public string user_name { get; set; }

}

[ProtoContract]
public class GAME_CLIENT_NTF_PLUNDER_MONEY_INFO
{
    [ProtoMember(1)]

    public long black_iron_plunder_total_count { get; set; }

}

[ProtoContract]
public class CLIENT_GAME_REQ_PLUNDER_TRAP_BUY
{
    [ProtoMember(1)]

    public int buy_monster_tid { get; set; }

}

[ProtoContract]
public class GAME_CLIENT_ACK_PLUNDER_TRAP_BUY
{
    [ProtoMember(1)]

    public uint result { get; set; }
    [ProtoMember(2)]
    public int trap_possible_remain_second { get; set; }
    [ProtoMember(3)]
    public int reproduction_remain_second { get; set; }

}

[ProtoContract]
public class GAME_CLIENT_NTF_PLUNDER_TRAP_BUY
{
    [ProtoMember(1)]

    public string buyer_user_name { get; set; }
    [ProtoMember(2)]
    public int buy_monster_tid { get; set; }

}

[ProtoContract]
public class GAME_WORLD_NTF_PLUNDER_TRAP_BUY
{
    [ProtoMember(1)]

    public int plunder_tid { get; set; }
    [ProtoMember(2)]
    public ulong buyer_guild_uid { get; set; }
    [ProtoMember(3)]
    public ulong buyer_user_uid { get; set; }
    [ProtoMember(4)]
    public string buyer_user_name { get; set; }
    [ProtoMember(5)]
    public _cost_info[] use_cost_info { get; set; }

}

[ProtoContract]
public class GAME_WORLD_NTF_PLUNDER_MONSTER_EVENT
{
    [ProtoMember(1)]

    public int plunder_tid { get; set; }
    [ProtoMember(2)]
    public int monster_tid { get; set; }
    [ProtoMember(3)]
    public uint notice_type { get; set; }

}

[ProtoContract]
public class WORLD_CLIENT_NTF_PLUNDER_BATTLE_NPC_STATUS
{
    [ProtoMember(1)]

    public int plunder_tid { get; set; }
    [ProtoMember(2)]
    public int battle_npc_status { get; set; }

}

[ProtoContract]
public class WORLD_CLIENT_NTF_PLUNDER_INFO
{
    [ProtoMember(1)]

    _plunder_info plunder_info { get; set; }

}


[ProtoContract]
public class _sabuk_info
{
    [ProtoMember(1)]

    public int sabuk_status { get; set; }
    [ProtoMember(2)]
    public ulong battle_start_time { get; set; }

}

[ProtoContract]
public class _sabuk_server_info
{
    [ProtoMember(1)]

    public int sabuk_status { get; set; }
    [ProtoMember(2)]
    public ulong battle_start_time { get; set; }

}

[ProtoContract]
public class _sabuk_guild_info
{
    [ProtoMember(1)]

    public ulong guild_uid { get; set; }
    [ProtoMember(2)]
    public string guild_name { get; set; }
    [ProtoMember(3)]
    public string master_name { get; set; }
    [ProtoMember(4)]
    public uint guild_mark { get; set; }
    [ProtoMember(5)]
    public uint guild_mark_edge { get; set; }
    [ProtoMember(6)]
    public uint world_id { get; set; }

}

[ProtoContract]
public class _sabuk_r3_guild_info
{
    [ProtoMember(1)]

    _sabuk_guild_info sabuk_guild_info { get; set; }
    [ProtoMember(2)]
    public int r2_round_occupy_stage_tid { get; set; }

}

[ProtoContract]
public class _sabuk_user_ranking_info
{
    [ProtoMember(1)]

    public ulong guild_uid { get; set; }
    [ProtoMember(2)]
    public ulong user_uid { get; set; }
    [ProtoMember(3)]
    public string user_name { get; set; }
    [ProtoMember(4)]
    public ulong first_score_get_time { get; set; }
    [ProtoMember(5)]
    public uint player_kill_score { get; set; }
    [ProtoMember(6)]
    public uint occupation_score { get; set; }
    [ProtoMember(7)]
    public uint monster_kill_score { get; set; }

}

[ProtoContract]
public class _sabuk_capture_monster_info
{
    [ProtoMember(1)]

    public int monster_tid { get; set; }
    [ProtoMember(2)]
    public ulong occupy_guild_uid { get; set; }

}

[ProtoContract]
public class _sabuk_outpost_monster_info
{
    [ProtoMember(1)]

    public int monster_tid { get; set; }
    [ProtoMember(2)]
    public ulong occupy_guild_uid { get; set; }

}

[ProtoContract]
public class _sabuk_buff_monster_info
{
    [ProtoMember(1)]

    public int gen_pos_id { get; set; }
    [ProtoMember(2)]
    public int monster_tid { get; set; }
    [ProtoMember(3)]
    public ulong regen_time { get; set; }

}

[ProtoContract]
public class _sabuk_dominion_war_info
{
    [ProtoMember(1)]

    public int sabuk_round_tid { get; set; }
    [ProtoMember(2)]
    _sabuk_guild_info capture_occupy_guild_info { get; set; }
    [ProtoMember(3)]
    public uint channel_state { get; set; }

}

[ProtoContract]
public class _sabuk_ranking_board_info
{
    [ProtoMember(1)]

    _sabuk_guild_info guild_info { get; set; }
    [ProtoMember(2)]
    public int guild_level { get; set; }
    [ProtoMember(3)]
    public long guild_combat_point { get; set; }
    [ProtoMember(4)]
    public int guild_member_count { get; set; }
    [ProtoMember(5)]
    public int guild_member_max_count { get; set; }
    [ProtoMember(6)]
    public int sabuk_round { get; set; }
    [ProtoMember(7)]
    public uint score { get; set; }

}

[ProtoContract]
public class _sabuk_r1r2_popup_info
{
    [ProtoMember(1)]

    public int sabuk_round_tid { get; set; }
    [ProtoMember(2)]
    _sabuk_capture_monster_info capture_monster_info { get; set; }
    [ProtoMember(3)]
    _sabuk_outpost_monster_info outpost_monster_info { get; set; }

}

[ProtoContract]
public class _sabuk_r1r2_popup_stage_info
{
    [ProtoMember(1)]

    public int sabuk_round_tid { get; set; }
    [ProtoMember(2)]
    _sabuk_guild_info capture_occupy_guild_info { get; set; }

}

[ProtoContract]
public class _sabuk_board_user_view_info
{
    [ProtoMember(1)]

    public ulong user_uid { get; set; }
    [ProtoMember(2)]
    public ulong guild_uid { get; set; }
    [ProtoMember(3)]
    public bool is_guild_master { get; set; }
    [ProtoMember(4)]
    public ulong party_uid { get; set; }
    [ProtoMember(5)]
    public bool is_party_leader { get; set; }
    [ProtoMember(6)]
    public uint user_status { get; set; }
    [ProtoMember(7)]
    public _vector3 cur_pos { get; set; }

}

[ProtoContract]
public class _sabuk_world_sync_guild_info
{
    [ProtoMember(1)]

    public ulong guild_uid { get; set; }
    [ProtoMember(2)]
    public int highest_occupy_complete_sabuk_round_tid { get; set; }
    [ProtoMember(3)]
    public uint score { get; set; }

}

[ProtoContract]
public class _sabuk_gm_round_schedule_info
{
    [ProtoMember(1)]

    public int round { get; set; }
    [ProtoMember(2)]
    public int start_day { get; set; }
    [ProtoMember(3)]
    public int start_hour { get; set; }
    [ProtoMember(4)]
    public int start_minute { get; set; }
    [ProtoMember(5)]
    public ulong update_time { get; set; }

}

[ProtoContract]
public class _sabuk_selected_guild_info
{
    [ProtoMember(1)]

    public ulong guild_uid { get; set; }

}

[ProtoContract]
public class _sabuk_zone_create_guild_info
{
    [ProtoMember(1)]

    public ulong guild_uid { get; set; }
    [ProtoMember(2)]
    public int before_round_occupy_sabuk_round_tid { get; set; }

}

[ProtoContract]
public class _sabuk_zone_create_user_info
{
    [ProtoMember(1)]

    public ulong user_uid { get; set; }
    [ProtoMember(2)]
    public string user_name { get; set; }
    [ProtoMember(3)]
    public ulong guild_uid { get; set; }
    [ProtoMember(4)]
    public ulong first_score_get_time { get; set; }
    [ProtoMember(5)]
    public int player_kill_score { get; set; }
    [ProtoMember(6)]
    public int occupation_score { get; set; }
    [ProtoMember(7)]
    public int monster_kill_score { get; set; }

}

[ProtoContract]
public class _sabuk_zone_create_capture_monster_info
{
    [ProtoMember(1)]

    public int sabuk_round_tid { get; set; }
    [ProtoMember(2)]
    public int monster_tid { get; set; }
    [ProtoMember(3)]
    public ulong occupy_guild_uid { get; set; }
    [ProtoMember(4)]
    public ulong killer_user_uid { get; set; }
    [ProtoMember(6)]
    public string killer_user_name { get; set; }
    [ProtoMember(7)]
    public uint hp { get; set; }

}

[ProtoContract]
public class _sabuk_zone_create_outpost_monster_info
{
    [ProtoMember(1)]

    public int sabuk_round_tid { get; set; }
    [ProtoMember(2)]
    public int monster_tid { get; set; }
    [ProtoMember(3)]
    public ulong occupy_guild_uid { get; set; }
    [ProtoMember(4)]
    public uint hp { get; set; }
    [ProtoMember(5)]
    public ulong die_time { get; set; }

}

[ProtoContract]
public class _sabuk_zone_create_gate_monster_info
{
    [ProtoMember(1)]

    public int sabuk_round_tid { get; set; }
    [ProtoMember(2)]
    public int monster_tid { get; set; }
    [ProtoMember(3)]
    public uint hp { get; set; }

}

[ProtoContract]
public class _sabuk_zone_create_info
{
    [ProtoMember(1)]

    _sabuk_server_info sabuk_server_info { get; set; }
    [ProtoMember(2)]
    public _sabuk_zone_create_guild_info guild_info_list { get; set; }
    [ProtoMember(3)]
    public _sabuk_zone_create_user_info user_info_list { get; set; }
    [ProtoMember(4)]
    _sabuk_zone_create_capture_monster_info capture_monster_info { get; set; }
    [ProtoMember(5)]
    public _sabuk_zone_create_outpost_monster_info outpost_monster_info_list { get; set; }
    [ProtoMember(6)]
    public _sabuk_zone_create_gate_monster_info gate_monster_info_list { get; set; }

}

[ProtoContract]
public class CLIENT_WORLD_REQ_SABUK_DOMINION_CASTLE_INFO
{

}

[ProtoContract]
public class WORLD_CLIENT_ACK_SABUK_DOMINION_CASTLE_INFO
{
    [ProtoMember(1)]

    _sabuk_guild_info occupy_guild_info { get; set; }
    [ProtoMember(2)]
    public ulong occupy_expire_time { get; set; }
    [ProtoMember(3)]
    public string master_profile { get; set; }
    [ProtoMember(4)]
    _sabuk_info sabuk_info { get; set; }

}

[ProtoContract]
public class CLIENT_WORLD_REQ_SABUK_DOMINION_WAR_INFO
{

}

[ProtoContract]
public class WORLD_CLIENT_ACK_SABUK_DOMINION_WAR_INFO
{
    [ProtoMember(1)]

    _sabuk_info sabuk_info { get; set; }
    [ProtoMember(2)]
    public _sabuk_dominion_war_info sabuk_dominion_war_info_list { get; set; }

}

[ProtoContract]
public class CLIENT_WORLD_REQ_SABUK_RANKING_BOARD_INFO
{
}

[ProtoContract]
public class WORLD_CLIENT_ACK_SABUK_RANKING_BOARD_INFO
{
    [ProtoMember(1)]

    public _sabuk_ranking_board_info sabuk_ranking_board_info_list { get; set; }
    [ProtoMember(2)]
    public ulong battle_period_start_time { get; set; }
    [ProtoMember(3)]
    public ulong battle_period_end_time { get; set; }
    [ProtoMember(4)]
    public ulong occupy_guild_uid { get; set; }

}

[ProtoContract]
public class CLIENT_WORLD_REQ_SABUK_R1R2_POPUP
{

}

[ProtoContract]
public class WORLD_CLIENT_ACK_SABUK_R1R2_POPUP
{
    [ProtoMember(1)]

    public uint result { get; set; }
    [ProtoMember(2)]
    public _sabuk_r1r2_popup_info sabuk_r1r2_popup_info_list { get; set; }
    [ProtoMember(3)]
    public _sabuk_r1r2_popup_stage_info sabuk_r1r2_popup_stage_info_list { get; set; }

}

[ProtoContract]
public class GAME_WORLD_NTF_SABUK_CAPTURE_MONSTER_OCCUPY
{
    [ProtoMember(1)]

    public ulong sabuk_zone_uid { get; set; }
    [ProtoMember(2)]
    public int sabuk_round_tid { get; set; }
    [ProtoMember(3)]
    public int monster_tid { get; set; }
    [ProtoMember(4)]
    public ulong occupy_guild_uid { get; set; }
    [ProtoMember(5)]
    public ulong killer_user_uid { get; set; }
    [ProtoMember(6)]
    public string killer_user_name { get; set; }

}

[ProtoContract]
public class WORLD_GAME_NTF_SABUK_CAPTURE_MONSTER_OCCUPY_CANCEL
{
    [ProtoMember(1)]

    public ulong sabuk_zone_uid { get; set; }

}

[ProtoContract]
public class GAME_WORLD_NTF_SABUK_OUTPOST_MONSTER_INSTALL
{
    [ProtoMember(1)]

    public ulong sabuk_zone_uid { get; set; }
    [ProtoMember(2)]
    public int sabuk_round_tid { get; set; }
    [ProtoMember(3)]
    public int monster_tid { get; set; }
    [ProtoMember(4)]
    public ulong occupy_guild_uid { get; set; }
    [ProtoMember(5)]
    public ulong user_uid { get; set; }
    [ProtoMember(6)]
    public string user_name { get; set; }

}

[ProtoContract]
public class GAME_WORLD_NTF_SABUK_OUTPOST_MONSTER_DIE
{
    [ProtoMember(1)]

    public ulong sabuk_zone_uid { get; set; }
    [ProtoMember(2)]
    public int sabuk_round_tid { get; set; }
    [ProtoMember(3)]
    public int monster_tid { get; set; }

}

[ProtoContract]
public class WORLD_GAME_NTF_SABUK_OUTPOST_MONSTER_DESTROY
{
    [ProtoMember(1)]

    public ulong sabuk_zone_uid { get; set; }

}

[ProtoContract]
public class GAME_WORLD_NTF_SABUK_MONSTER_HP
{
    [ProtoMember(1)]

    public ulong sabuk_zone_uid { get; set; }
    [ProtoMember(2)]
    public int sabuk_round_tid { get; set; }
    [ProtoMember(3)]
    public int monster_tid { get; set; }
    [ProtoMember(4)]
    public uint hp { get; set; }

}

[ProtoContract]
public class GAME_CLIENT_NTF_SABUK_R1R2_ZONE_ENTER_INFO
{
    [ProtoMember(1)]

    _sabuk_info sabuk_info { get; set; }
    [ProtoMember(2)]
    public _sabuk_guild_info sabuk_guild_info_list { get; set; }
    [ProtoMember(3)]
    _sabuk_capture_monster_info capture_monster_info { get; set; }
    [ProtoMember(4)]
    _sabuk_outpost_monster_info outpost_monster_info { get; set; }
    [ProtoMember(5)]
    public _sabuk_buff_monster_info buff_monster_info_list { get; set; }
    [ProtoMember(6)]
    public ulong capture_occupy_banish_time { get; set; }

}

[ProtoContract]
public class GAME_CLIENT_NTF_SABUK_R3_ZONE_ENTER_INFO
{
    [ProtoMember(1)]

    _sabuk_info sabuk_info { get; set; }
    [ProtoMember(2)]
    public _sabuk_r3_guild_info sabuk_r3_guild_info_list { get; set; }
    [ProtoMember(3)]
    _sabuk_capture_monster_info capture_monster_info { get; set; }
    [ProtoMember(4)]
    public _sabuk_outpost_monster_info outpost_monster_info_list { get; set; }
    [ProtoMember(5)]
    public _sabuk_buff_monster_info buff_monster_info_list { get; set; }
    [ProtoMember(6)]
    public ulong guild_outpost_casting_possible_time { get; set; }
    [ProtoMember(7)]
    public _guild_war_board_command_info command_info_list { get; set; }
    [ProtoMember(8)]
    public ulong capture_occupy_banish_time { get; set; }

}

[ProtoContract]
public class WORLD_GAME_NTF_SABUK_STATUS_CHANGE
{
    [ProtoMember(1)]

    public ulong sabuk_zone_uid { get; set; }
    [ProtoMember(2)]
    _sabuk_server_info sabuk_server_info { get; set; }
    [ProtoMember(3)]
    _sabuk_zone_create_info sabuk_zone_create_info { get; set; }

}

[ProtoContract]
public class WORLD_CLIENT_NTF_SABUK_INFO
{
    [ProtoMember(1)]

    _sabuk_info sabuk_info { get; set; }

}

[ProtoContract]
public class WORLD_CLIENT_NTF_SABUK_R3_RESULT_TO_ALL_USER
{
    [ProtoMember(1)]

    _sabuk_info sabuk_info { get; set; }
    [ProtoMember(2)]
    _sabuk_guild_info occupy_guild_info { get; set; }

}

[ProtoContract]
public class GAME_CLIENT_NTF_RESULT_SABUK_TO_BATTLE_USER
{
    [ProtoMember(1)]

    _sabuk_guild_info occupy_guild_info { get; set; }
    [ProtoMember(2)]
    public ulong mvp_user_uid { get; set; }
    [ProtoMember(3)]
    public string mvp_user_name { get; set; }
    [ProtoMember(4)]
    public _sabuk_user_ranking_info user_ranking_info_list { get; set; }
    [ProtoMember(5)]
    public string occupy_guild_master_profile { get; set; }

}

[ProtoContract]
public class WORLD_GAME_SYNC_SABUK_INFO_IN_ZONE_GROUP
{
    [ProtoMember(1)]

    _sabuk_server_info sabuk_server_info { get; set; }

}

[ProtoContract]
public class WORLD_WORLD_SYNC_SABUK_INFO
{
    [ProtoMember(1)]

    public bool is_init_sync_sabuk_info { get; set; }
    [ProtoMember(2)]
    _sabuk_server_info sabuk_server_info { get; set; }
    [ProtoMember(3)]
    public _sabuk_world_sync_guild_info sabuk_world_sync_guild_info_list { get; set; }
    [ProtoMember(4)]
    public _sabuk_gm_round_schedule_info sabuk_gm_round_schedule_info_list { get; set; }
    [ProtoMember(5)]
    public bool is_conquer_server_disconnected_with_relay { get; set; }

}

[ProtoContract]
public class SERVER_CLIENT_NTF_SABUK_NOTICE
{
    [ProtoMember(1)]

    public uint notice_type { get; set; }
    [ProtoMember(2)]
    public int monster_tid { get; set; }
    [ProtoMember(3)]
    public int monster_tid_2 { get; set; }
    [ProtoMember(4)]
    public int stage_tid { get; set; }
    [ProtoMember(5)]
    public int stage_tid_2 { get; set; }
    [ProtoMember(6)]
    public string guild_name { get; set; }
    [ProtoMember(7)]
    public string user_name { get; set; }
    [ProtoMember(8)]
    public uint world_id { get; set; }

}

[ProtoContract]
public class GAME_WORLD_NTF_SABUK_USER_SCORE
{
    [ProtoMember(1)]

    public ulong user_uid { get; set; }
    [ProtoMember(2)]
    public ulong first_score_get_time { get; set; }
    [ProtoMember(3)]
    public uint player_kill_score { get; set; }
    [ProtoMember(4)]
    public uint occupation_score { get; set; }
    [ProtoMember(5)]
    public uint monster_kill_score { get; set; }
    [ProtoMember(6)]
    public uint add_score { get; set; }

}

[ProtoContract]
public class CLIENT_GAME_REQ_SABUK_RANK_INFO
{
}

[ProtoContract]
public class GAME_CLIENT_ACK_SABUK_RANK_INFO
{
    [ProtoMember(1)]

    public uint result { get; set; }
    [ProtoMember(2)]
    public _sabuk_user_ranking_info user_ranking_info_list { get; set; }

}

[ProtoContract]
public class CLIENT_GAME_REQ_SABUK_BOARD_INFO
{
    [ProtoMember(1)]

    public int info_req_kind { get; set; }

}

[ProtoContract]
public class GAME_CLIENT_ACK_SABUK_BOARD_INFO
{
    [ProtoMember(1)]

    public uint result { get; set; }

}

[ProtoContract]
public class GAME_CLIENT_NTF_SABUK_BOARD_MOVE_INFO
{
    [ProtoMember(1)]

    public int info_req_kind { get; set; }
    [ProtoMember(2)]
    public _guild_war_board_user_move_info user_move_info_list { get; set; }

}

[ProtoContract]
public class GAME_CLIENT_NTF_SABUK_BOARD_INFO
{
    [ProtoMember(1)]

    public int info_req_kind { get; set; }
    [ProtoMember(2)]
    public bool is_modify { get; set; }
    [ProtoMember(3)]
    public _sabuk_board_user_view_info user_view_info_list { get; set; }
    [ProtoMember(4)]
    public _guild_war_board_command_info command_info_list { get; set; }

}

[ProtoContract]
public class GAME_CLIENT_NTF_SABUK_CAPTURE_MONSTER_INFO
{
    [ProtoMember(1)]

    _sabuk_capture_monster_info capture_monster_info { get; set; }
    [ProtoMember(2)]
    public string mvp_user_name { get; set; }
    [ProtoMember(3)]
    public ulong capture_occupy_banish_time { get; set; }

}

[ProtoContract]
public class GAME_CLIENT_NTF_SABUK_OUTPOST_MONSTER_INFO
{
    [ProtoMember(1)]

    _sabuk_outpost_monster_info outpost_monster_info { get; set; }

}

[ProtoContract]
public class GAME_CLIENT_NTF_SABUK_BUFF_MONSTER_INFO
{
    [ProtoMember(1)]

    _sabuk_buff_monster_info buff_monster_info { get; set; }

}

[ProtoContract]
public class GAME_CLIENT_NTF_SABUK_GUILD_OUTPOST_CASTING_POSSIBLE_TIME
{
    [ProtoMember(1)]

    public ulong guild_outpost_casting_possible_time { get; set; }

}

[ProtoContract]
public class WORLD_GAME_NTF_SABUK_CAPTURE_MONSTER_OCCUPY_BY_CHEAT
{
    [ProtoMember(1)]

    public ulong sabuk_zone_uid { get; set; }
    [ProtoMember(2)]
    public ulong occupy_guild_uid { get; set; }
    [ProtoMember(3)]
    public ulong killer_user_uid { get; set; }
    [ProtoMember(4)]
    public string killer_user_name { get; set; }

}

[ProtoContract]
public class CLIENT_WORLD_REQ_SABUK_SELECTED_GUILD_INFO
{
}

[ProtoContract]
public class WORLD_CLIENT_ACK_SABUK_SELECTED_GUILD_INFO
{
    [ProtoMember(1)]

    public _sabuk_selected_guild_info sabuk_selected_guild_info_list { get; set; }
    [ProtoMember(2)]
    _sabuk_info sabuk_info { get; set; }

}

[ProtoContract]
public class WORLD_CLIENT_NTF_SABUK_SELECTED_GUILD_INFO
{
    [ProtoMember(1)]

    public _sabuk_selected_guild_info sabuk_selected_guild_info_list { get; set; }

}

[ProtoContract]
public class GAME_WORLD_NTF_SABUK_NOTICE
{
    [ProtoMember(1)]

    public ulong sabuk_zone_uid { get; set; }
    [ProtoMember(2)]
    public int sabuk_round_tid { get; set; }
    [ProtoMember(3)]
    public uint notice_type { get; set; }
    [ProtoMember(4)]
    public int monster_tid { get; set; }
    [ProtoMember(5)]
    public ulong guild_uid { get; set; }

}

[ProtoContract]
public class GUILD_WORLD_SABUK_GUILD_COST_REWARD
{
    [ProtoMember(1)]

    public ulong guild_uid { get; set; }
    [ProtoMember(2)]
    public int stage_tid { get; set; }
    [ProtoMember(3)]
    public int cost_type { get; set; }
    [ProtoMember(4)]
    public long cost_value { get; set; }

}

[ProtoContract]
public class RELAY_WORLD_NTF_SABUK_CONQUER_SERVER_DISCONNECTED
{
}


[ProtoContract]
public class _sanctum_monster_info
{
    [ProtoMember(1)]

    public ulong monster_uid { get; set; }
    [ProtoMember(2)]
    _guild_simple_info occupy_guild_info { get; set; }

}

[ProtoContract]
public class WORLD_GAME_SYNC_SANCTUM_INFO_IN_ZONE_GROUP
{
    [ProtoMember(1)]

    _sanctum_server_info sanctum_server_info { get; set; }

}

[ProtoContract]
public class WORLD_GAME_SYNC_SANCTUM_INFO_LIST_IN_ZONE_GROUP
{
    [ProtoMember(1)]

    public _sanctum_server_info sanctum_server_info_list { get; set; }

}

[ProtoContract]
public class CLIENT_WORLD_REQ_SANCTUM_INFO_LIST
{

}

[ProtoContract]
public class WORLD_CLIENT_ACK_SANCTUM_INFO_LIST
{
    [ProtoMember(1)]

    public _sanctum_info sanctum_info_list { get; set; }

}

[ProtoContract]
public class GAME_CLIENT_NTF_SANCTUM_ZONE_ENTER_INFO
{
    [ProtoMember(1)]

    _sanctum_monster_info sanctum_monster_info { get; set; }

}

[ProtoContract]
public class GAME_CLIENT_NTF_SANCTUM_MONSTER_INFO
{
    [ProtoMember(1)]

    _sanctum_monster_info sanctum_monster_info { get; set; }

}

[ProtoContract]
public class GAME_WORLD_REQ_SANCTUM_OCCUPY
{
    [ProtoMember(1)]

    public int sanctum_stage_tid { get; set; }
    [ProtoMember(2)]
    public ulong sanctum_zone_uid { get; set; }
    [ProtoMember(3)]
    public ulong occupy_guild_uid { get; set; }
    [ProtoMember(4)]
    public ulong mvp_user_uid { get; set; }

}

[ProtoContract]
public class WORLD_GAME_ACK_SANCTUM_OCCUPY
{
    [ProtoMember(1)]

    public uint result { get; set; }
    [ProtoMember(2)]
    _sanctum_server_info sanctum_server_info { get; set; }
    [ProtoMember(3)]
    public ulong sanctum_zone_uid { get; set; }

}

[ProtoContract]
public class WORLD_CLIENT_NTF_SANCTUM_OCCUPY_TO_ALL_USER
{
    [ProtoMember(1)]

    _sanctum_info sanctum_info { get; set; }

}

[ProtoContract]
public class GAME_WORLD_NTF_SANCTUM_MONSTER_ATTACKED
{
    [ProtoMember(1)]

    public int sanctum_stage_tid { get; set; }
    [ProtoMember(2)]
    public ulong sanctum_zone_uid { get; set; }

}

[ProtoContract]
public class GAME_WORLD_NTF_SANCTUM_MONSTER_KILLED
{
    [ProtoMember(1)]

    public int sanctum_stage_tid { get; set; }
    [ProtoMember(2)]
    public ulong sanctum_zone_uid { get; set; }
    [ProtoMember(3)]
    public ulong killer_guild_uid { get; set; }
    [ProtoMember(4)]
    public ulong killer_user_uid { get; set; }

}

[ProtoContract]
public class WORLD_CLIENT_NTF_SANCTUM_MONSTER_KILLED_TO_ALL_USER
{
    [ProtoMember(1)]

    _sanctum_info sanctum_info { get; set; }

}

[ProtoContract]
public class WORLD_GAME_NTF_SANCTUM_OCCUPY_RETURN
{
    [ProtoMember(1)]

    _sanctum_server_info sanctum_server_info { get; set; }
    [ProtoMember(2)]
    public ulong sanctum_zone_uid { get; set; }

}

[ProtoContract]
public class WORLD_CLIENT_NTF_SANCTUM_OCCUPY_RETURN_TO_ALL_USER
{
    [ProtoMember(1)]

    _sanctum_info sanctum_info { get; set; }

}

[ProtoContract]
public class WORLD_GAME_NTF_SANCTUM_LIFE_TIMEOUT
{
    [ProtoMember(1)]

    _sanctum_server_info sanctum_server_info { get; set; }
    [ProtoMember(2)]
    public ulong sanctum_zone_uid { get; set; }

}

[ProtoContract]
public class WORLD_CLIENT_NTF_SANCTUM_LIFE_TIMEOUT_TO_ALL_USER
{
    [ProtoMember(1)]

    _sanctum_info sanctum_info { get; set; }

}

[ProtoContract]
public class WORLD_GAME_NTF_SANCTUM_STATUS
{
    [ProtoMember(1)]

    _sanctum_server_info sanctum_server_info { get; set; }
    [ProtoMember(2)]
    public ulong sanctum_zone_uid { get; set; }

}

[ProtoContract]
public class WORLD_CLIENT_NTF_SANCTUM_STATUS_TO_ALL_USER
{
    [ProtoMember(1)]

    public int sanctum_stage_tid { get; set; }
    [ProtoMember(2)]
    public uint sanctum_status { get; set; }

}

[ProtoContract]
public class SERVER_CLIENT_NTF_SANCTUM_NOTICE
{
    [ProtoMember(1)]

    public int sanctum_stage_tid { get; set; }
    [ProtoMember(2)]
    public uint notice_type { get; set; }
    [ProtoMember(3)]
    public string guild_name { get; set; }
    [ProtoMember(4)]
    public string user_name { get; set; }

}


[ProtoContract]
public class _siege_ranking_info
{
    [ProtoMember(1)]

    public ulong guild_uid { get; set; }
    [ProtoMember(2)]
    public ulong user_uid { get; set; }
    [ProtoMember(3)]
    public string user_name { get; set; }
    [ProtoMember(4)]
    public int guild_camp_kind { get; set; }
    [ProtoMember(5)]
    public uint guild_mark { get; set; }
    [ProtoMember(6)]
    public uint guild_mark_edge { get; set; }
    [ProtoMember(7)]
    public uint score { get; set; }
    [ProtoMember(8)]
    public uint ranking { get; set; }
    [ProtoMember(9)]
    public uint player_kill_score { get; set; }
    [ProtoMember(10)]
    public uint occupation_score { get; set; }
    [ProtoMember(11)]
    public uint monster_kill_score { get; set; }
    [ProtoMember(12)]
    public uint user_status { get; set; }

}

[ProtoContract]
public class _siege_info_in_normal
{
    [ProtoMember(1)]

    public long defense_past_bidding_value { get; set; }
    [ProtoMember(3)]
    public long offense_past_bidding_value { get; set; }

}

[ProtoContract]
public class _siege_info_in_auction
{
    [ProtoMember(1)]

    _guild_simple_info first_candidate_guild_simple_info { get; set; }
    [ProtoMember(2)]
    public long first_candidate_guild_total_combat_point { get; set; }
    [ProtoMember(3)]
    public long first_candidate_bidding_value { get; set; }
    [ProtoMember(4)]
    _guild_simple_info second_candidate_guild_simple_info { get; set; }
    [ProtoMember(5)]
    public long second_candidate_guild_total_combat_point { get; set; }
    [ProtoMember(6)]
    public long second_candidate_bidding_value { get; set; }
    [ProtoMember(7)]
    public int my_guild_candidate_rank { get; set; }
    [ProtoMember(8)]
    public long my_guild_coin { get; set; }
    [ProtoMember(9)]
    public int bidding_cooltime_remain_second { get; set; }
    [ProtoMember(10)]
    public long auction_end_time { get; set; }

}

[ProtoContract]
public class _siege_battle_guilds_simple_info
{
    [ProtoMember(1)]

    _guild_simple_info defense_main_guild_simple_info { get; set; }
    [ProtoMember(2)]
    _guild_simple_info offense_main_guild_simple_info { get; set; }

}

[ProtoContract]
public class _siege_revival_flag_info
{
    [ProtoMember(1)]

    public ulong object_uid { get; set; }
    [ProtoMember(2)]
    public int object_tid { get; set; }
    [ProtoMember(3)]
    public ulong ownner_guild_uid { get; set; }
    [ProtoMember(4)]
    public ulong point_ownner_guild_uid { get; set; }
    [ProtoMember(5)]
    public uint cur_point { get; set; }
    [ProtoMember(6)]
    public int lock_time_remain_second { get; set; }

}

[ProtoContract]
public class _siege_weapon_info
{
    [ProtoMember(1)]

    public int monster_tid { get; set; }
    [ProtoMember(2)]
    public int production_remain_second { get; set; }

}

[ProtoContract]
public class _siege_board_team_user_count_info
{
    [ProtoMember(1)]

    public uint defense_user_total_count { get; set; }
    [ProtoMember(2)]
    public uint defense_alliance_user_count { get; set; }
    [ProtoMember(3)]
    public uint offense_user_total_count { get; set; }
    [ProtoMember(4)]
    public uint offense_alliance_user_count { get; set; }

}

[ProtoContract]
public class _siege_user_point_info
{
    [ProtoMember(1)]

    public uint player_kill_score { get; set; }
    [ProtoMember(2)]
    public uint occupation_score { get; set; }
    [ProtoMember(3)]
    public uint monster_kill_score { get; set; }

}

[ProtoContract]
public class _siege_event_info
{
    [ProtoMember(1)]

    public int siege_tid { get; set; }
    [ProtoMember(2)]
    public int siege_event_type { get; set; }
    [ProtoMember(3)]
    public ulong start_time { get; set; }
    [ProtoMember(4)]
    public ulong end_time { get; set; }

}

[ProtoContract]
public class _siege_sync_event_info
{
    [ProtoMember(1)]

    public int siege_tid { get; set; }
    [ProtoMember(2)]
    public ulong siege_period_start_time { get; set; }
    [ProtoMember(3)]
    public _siege_event_info siege_event_info_list { get; set; }

}

[ProtoContract]
public class GAME_WORLD_REQ_SIEGE_OCCUPY
{
    [ProtoMember(1)]

    public int siege_tid { get; set; }
    [ProtoMember(2)]
    public ulong win_guild_uid { get; set; }
    [ProtoMember(3)]
    public ulong siege_zone_uid { get; set; }

}

[ProtoContract]
public class WORLD_GAME_ACK_SIEGE_OCCUPY
{
    [ProtoMember(1)]

    public uint result { get; set; }
    [ProtoMember(2)]
    _siege_info siege_info { get; set; }
    [ProtoMember(3)]
    public ulong siege_zone_uid { get; set; }

}

[ProtoContract]
public class GAME_CLIENT_NTF_SIEGE_ZONE_ENTER_INFO
{
    [ProtoMember(1)]

    _siege_info siege_info { get; set; }
    [ProtoMember(2)]
    _siege_battle_guilds_simple_info siege_battle_guilds_simple_info { get; set; }
    [ProtoMember(3)]
    public int guild_camp_kind { get; set; }
    [ProtoMember(4)]
    _siege_user_point_info siege_user_point_info { get; set; }
    [ProtoMember(6)]
    public _siege_revival_flag_info siege_revival_flag_info_list { get; set; }
    [ProtoMember(7)]
    public _siege_weapon_info siege_weapon_info_list { get; set; }
    [ProtoMember(8)]
    public _guild_war_board_command_info command_info_list { get; set; }
    [ProtoMember(9)]
    public int siege_run_time_minute { get; set; }
    [ProtoMember(10)]
    public ulong[] defnse_alliance_guild_uid_list { get; set; }
    [ProtoMember(11)]
    public ulong[] offense_alliance_guild_uid_list { get; set; }

}

[ProtoContract]
public class WORLD_CLIENT_NTF_SIEGE_BATTLE_STATUS
{
    [ProtoMember(1)]

    public int siege_tid { get; set; }
    [ProtoMember(2)]
    public int siege_battle_status { get; set; }

}

[ProtoContract]
public class WORLD_GAME_NTF_PREPARE_SIEGE_BATTLE
{
    [ProtoMember(1)]

    public ulong siege_zone_uid { get; set; }
    [ProtoMember(2)]
    _siege_info siege_info { get; set; }
    [ProtoMember(3)]
    _siege_battle_guilds_simple_info siege_battle_guilds_simple_info { get; set; }

}

[ProtoContract]
public class WORLD_GAME_NTF_START_SIEGE_BATTLE
{
    [ProtoMember(1)]

    public ulong siege_zone_uid { get; set; }
    [ProtoMember(2)]
    public int siege_tid { get; set; }

}

[ProtoContract]
public class WORLD_CLIENT_NTF_START_SIEGE_BATTLE
{
    [ProtoMember(1)]

    public int siege_tid { get; set; }

}

[ProtoContract]
public class WORLD_GAME_NTF_TIMEOUT_SIEGE_BATTLE
{
    [ProtoMember(1)]

    _siege_info siege_info { get; set; }
    [ProtoMember(2)]
    public ulong siege_zone_uid { get; set; }

}

[ProtoContract]
public class WORLD_GAME_NTF_SIEGE_OCCUPY_CANCEL
{
    [ProtoMember(1)]

    _siege_info siege_info { get; set; }
    [ProtoMember(2)]
    public ulong siege_zone_uid { get; set; }

}

[ProtoContract]
public class WORLD_CLIENT_NTF_RESULT_SIEGE_TO_ALL_USER
{
    [ProtoMember(1)]

    _siege_info siege_info { get; set; }

}

[ProtoContract]
public class WORLD_CLIENT_NTF_SIEGE_OCCUPY_CANCEL_TO_ALL_USER
{
    [ProtoMember(1)]

    public int siege_tid { get; set; }

}

[ProtoContract]
public class WORLD_CLIENT_NTF_CANCEL_SIEGE_TO_ALL_USER
{
    [ProtoMember(1)]

    _siege_info siege_info { get; set; }

}

[ProtoContract]
public class GAME_CLIENT_NTF_RESULT_SIEGE_TO_BATTLE_USER
{
    [ProtoMember(1)]

    public int win_type { get; set; }
    [ProtoMember(2)]
    _guild_simple_info occupation_guild_simple_info { get; set; }
    [ProtoMember(3)]
    public _siege_ranking_info rank_info_list { get; set; }
    [ProtoMember(4)]
    public string mvp_user_name { get; set; }

}

[ProtoContract]
public class WORLD_GAME_NTF_CLOSE_SIEGE_BATTLE
{
    [ProtoMember(1)]

    public ulong siege_zone_uid { get; set; }
    [ProtoMember(2)]
    public int siege_tid { get; set; }

}

[ProtoContract]
public class WORLD_GAME_NTF_SIEGE_BATTLE_STOP
{
    [ProtoMember(1)]

    _siege_info siege_info { get; set; }
    [ProtoMember(2)]
    public ulong siege_zone_uid { get; set; }

}

[ProtoContract]
public class CLIENT_WORLD_REQ_SIEGE_INFO_LIST
{
}

[ProtoContract]
public class WORLD_CLIENT_ACK_SIEGE_INFO_LIST
{
    [ProtoMember(1)]

    public _siege_info siege_info_list { get; set; }

}

[ProtoContract]
public class WORLD_GAME_SYNC_SIEGE_INFO_IN_ZONE_GROUP
{
    [ProtoMember(1)]

    _siege_info siege_info { get; set; }
    [ProtoMember(2)]
    public int siege_tid { get; set; }
    [ProtoMember(3)]
    _guild_simple_info occupation_guild_info { get; set; }

}

[ProtoContract]
public class WORLD_GAME_SYNC_SIEGE_INFO_LIST_IN_ZONE_GROUP
{
    [ProtoMember(1)]

    public _siege_info siege_info_list { get; set; }
    [ProtoMember(2)]
    public WORLD_GAME_SYNC_SIEGE_INFO_IN_ZONE_GROUP occupation_guild_info_list { get; set; }

}

[ProtoContract]
public class SERVER_CLIENT_NTF_NOTICE_SIEGE
{
    [ProtoMember(1)]

    public int siege_tid { get; set; }
    [ProtoMember(2)]
    public uint notice_type { get; set; }
    [ProtoMember(3)]
    public int value { get; set; }
    [ProtoMember(4)]
    public ulong guild_uid { get; set; }
    [ProtoMember(5)]
    public string defense_guild_name { get; set; }
    [ProtoMember(6)]
    public string offense_guild_name { get; set; }

}

[ProtoContract]
public class CLIENT_GAME_REQ_SIEGE_RANK_INFO
{

}

[ProtoContract]
public class GAME_CLIENT_ACK_SIEGE_RANK_INFO
{
    [ProtoMember(1)]

    public uint result { get; set; }
    [ProtoMember(2)]
    public _siege_ranking_info rank_info_list { get; set; }

}

[ProtoContract]
public class GAME_WORLD_NTF_SIEGE_MAIL_RANK_INFO
{
    [ProtoMember(1)]

    public int siege_tid { get; set; }
    [ProtoMember(2)]
    public int win_type { get; set; }
    [ProtoMember(3)]
    _guild_simple_info defense_guild_simple_info { get; set; }
    [ProtoMember(4)]
    _guild_simple_info offense_guild_simple_info { get; set; }
    [ProtoMember(5)]
    public _siege_ranking_info rank_info_list { get; set; }
    [ProtoMember(6)]
    public string mvp_user_name { get; set; }

}

[ProtoContract]
public class CLIENT_WORLD_REQ_SIEGE_MAIL_RANK_INFO
{
    [ProtoMember(1)]

    public int siege_tid { get; set; }

}

[ProtoContract]
public class WORLD_CLIENT_ACK_SIEGE_MAIL_RANK_INFO
{
    [ProtoMember(1)]

    public uint result { get; set; }
    [ProtoMember(2)]
    public int win_type { get; set; }
    [ProtoMember(3)]
    _guild_simple_info defense_guild_simple_info { get; set; }
    [ProtoMember(4)]
    _guild_simple_info offense_guild_simple_info { get; set; }
    [ProtoMember(5)]
    public _siege_ranking_info rank_info_list { get; set; }
    [ProtoMember(6)]
    public string mvp_user_name { get; set; }

}

[ProtoContract]
public class CLIENT_WORLD_REQ_SIEGE_AUCTION_BIDDING
{
    [ProtoMember(1)]

    public int siege_tid { get; set; }
    [ProtoMember(2)]
    public long bidding_value { get; set; }

}

[ProtoContract]
public class WORLD_CLIENT_ACK_SIEGE_AUCTION_BIDDING
{
    [ProtoMember(1)]

    public uint result { get; set; }
    [ProtoMember(2)]
    public int siege_tid { get; set; }
    [ProtoMember(3)]
    public _siege_info_in_auction siege_info_in_auction { get; set; }

}

[ProtoContract]
public class WORLD_CLIENT_NTF_SIEGE_AUCTION_BIDDING
{
    [ProtoMember(1)]

    public int siege_tid { get; set; }
    [ProtoMember(2)]
    public _siege_info_in_auction siege_info_in_auction { get; set; }
    [ProtoMember(3)]
    public string bidding_user_name { get; set; }

}

[ProtoContract]
public class WORLD_CLIENT_NTF_SIEGE_AUCTION_CANDIDATE_STATUS
{
    [ProtoMember(1)]

    public int siege_tid { get; set; }
    [ProtoMember(2)]
    public uint candidate_status { get; set; }

}

[ProtoContract]
public class GAME_CLIENT_NTF_SIEGE_BOARD_INFO
{
    [ProtoMember(1)]

    public int info_req_kind { get; set; }
    [ProtoMember(2)]
    public bool is_modify { get; set; }
    [ProtoMember(3)]
    _siege_board_team_user_count_info team_user_count_info { get; set; }
    [ProtoMember(4)]
    public _guild_war_board_user_view_info user_view_info_list { get; set; }
    [ProtoMember(5)]
    public _guild_war_board_command_info command_info_list { get; set; }
    [ProtoMember(6)]
    public _guild_war_board_watcher_ui_info watcher_ui_info { get; set; }

}

[ProtoContract]
public class GAME_CLIENT_NTF_SIEGE_POINT_INFO
{
    [ProtoMember(1)]

    _siege_user_point_info siege_user_point_info { get; set; }
    [ProtoMember(2)]
    public int point_acquire_type { get; set; }
    [ProtoMember(3)]
    public int acquire_guild_camp_kind { get; set; }
    [ProtoMember(4)]
    public ulong acquire_user_uid { get; set; }
    [ProtoMember(5)]
    public string attacker_player_name { get; set; }
    [ProtoMember(6)]
    public string target_player_name { get; set; }
    [ProtoMember(7)]
    public int target_monster_tid { get; set; }
    [ProtoMember(8)]
    public ulong acquire_guild_uid { get; set; }

}

[ProtoContract]
public class GAME_CLIENT_NTF_SIEGE_REVIVAL_FLAG_INFO
{
    [ProtoMember(1)]

    _siege_revival_flag_info siege_revival_flag_info { get; set; }

}

[ProtoContract]
public class CLIENT_GAME_REQ_SIEGE_WEAPON_BUY
{
    [ProtoMember(1)]

    public int buy_monster_tid { get; set; }

}

[ProtoContract]
public class GAME_CLIENT_ACK_SIEGE_WEAPON_BUY
{
    [ProtoMember(1)]

    public uint result { get; set; }
    [ProtoMember(2)]
    public int reproduction_remain_second { get; set; }

}

[ProtoContract]
public class GAME_CLIENT_NTF_SIEGE_WEAPON_BUY
{
    [ProtoMember(1)]

    public string buyer_user_name { get; set; }
    [ProtoMember(2)]
    public int buy_monster_tid { get; set; }

}

[ProtoContract]
public class GAME_WORLD_NTF_SIEGE_WEAPON_BUY
{
    [ProtoMember(1)]

    public int siege_tid { get; set; }
    [ProtoMember(2)]
    public ulong buyer_guild_uid { get; set; }
    [ProtoMember(3)]
    public ulong buyer_user_uid { get; set; }
    [ProtoMember(4)]
    public string buyer_user_name { get; set; }
    [ProtoMember(5)]
    public _cost_info[] use_cost_info { get; set; }

}

[ProtoContract]
public class GAME_CLIENT_NTF_SIEGE_ALLIANCE_GUILD_UID_LIST
{
    [ProtoMember(1)]

    public ulong guild_uid { get; set; }
    [ProtoMember(2)]
    public ulong[] alliance_guild_uid_list { get; set; }

}

[ProtoContract]
public class WORLD_GAME_NTF_GUILD_MASTER_SIEGE_WIN_BY_AUCTION_FAIL
{
    [ProtoMember(1)]

    public int siege_tid { get; set; }
    [ProtoMember(2)]
    public ulong guild_uid { get; set; }

}

[ProtoContract]
public class CLIENT_WORLD_REQ_SIEGE_EVENT_INFO
{

}

[ProtoContract]
public class WORLD_CLIENT_ACK_SIEGE_EVENT_INFO
{
    [ProtoMember(1)]

    public _siege_event_info siege_event_info_list { get; set; }

}

[ProtoContract]
public class WORLD_CLIENT_NTF_SIEGE_EVENT_INFO
{
    [ProtoMember(1)]

    public _siege_event_info siege_event_info_list { get; set; }

}

[ProtoContract]
public class WORLD_GAME_NTF_SIEGE_SYNC_EVENT_INFO_IN_ZONE_GROUP
{
    [ProtoMember(1)]

    _siege_sync_event_info siege_sync_event_info { get; set; }

}

[ProtoContract]
public class WORLD_GAME_NTF_SIEGE_SYNC_EVENT_INFO_LIST_IN_ZONE_GROUP
{
    [ProtoMember(1)]

    public _siege_sync_event_info siege_sync_event_info_list { get; set; }

}

[ProtoContract]
public class GAME_WORLD_SIEGE_EVE_EVENT_SELECT_CHEERING_TEAM
{
    [ProtoMember(1)]

    public long user_uid { get; set; }
    [ProtoMember(2)]
    public int user_event_id { get; set; }
    [ProtoMember(3)]
    public int select_cheering_team { get; set; }
    [ProtoMember(4)]
    public int cheering_count { get; set; }

}

[ProtoContract]
public class WORLD_GAME_SIEGE_EVE_EVENT_SELECT_CHEERING_TEAM
{
    [ProtoMember(1)]

    public long user_uid { get; set; }
    [ProtoMember(2)]
    public int user_event_id { get; set; }
    [ProtoMember(3)]
    public int cheering_count { get; set; }
    [ProtoMember(4)]
    public int select_cheering_team { get; set; }
    [ProtoMember(5)]
    public int total_defense_cheering_count { get; set; }
    [ProtoMember(6)]
    public int total_siege_cheering_count { get; set; }

}

[ProtoContract]
public class WORLD_GAME_SIEGE_EVE_EVENT_UPDATE_TOTAL_CHEERING_COUNT
{
    [ProtoMember(1)]

    public int total_defense_cheering_count { get; set; }
    [ProtoMember(2)]
    public int total_siege_cheering_count { get; set; }
    [ProtoMember(3)]
    public int is_reset_next_piriod { get; set; }

}

[ProtoContract]
public class GAME_WORLD_SIEGE_EVE_EVENT_CHECT_TOTAL_CHEERING_COUNT_RESET
{

}

[ProtoContract]
public class _siege_watcher_trace_user_info
{
    [ProtoMember(1)]

    public ulong user_uid { get; set; }
    [ProtoMember(2)]
    public int trace_user_status { get; set; }
    [ProtoMember(3)]
    public _vector3 cur_pos { get; set; }

}

[ProtoContract]
public class CLIENT_GAME_REQ_SIEGE_WATCHER_TRACE_USER
{
    [ProtoMember(1)]

    public bool start { get; set; }
    [ProtoMember(2)]
    public string user_name { get; set; }

}

[ProtoContract]
public class GAME_CLIENT_ACK_SIEGE_WATCHER_TRACE_USER
{
    [ProtoMember(1)]

    public uint result { get; set; }
    [ProtoMember(2)]
    public bool start { get; set; }
    [ProtoMember(3)]
    public string user_name { get; set; }
    [ProtoMember(4)]
    _siege_watcher_trace_user_info siege_watcher_trace_user_info { get; set; }

}

[ProtoContract]
public class GAME_CLIENT_NTF_SIEGE_WATCHER_TRACE_USER
{
    [ProtoMember(1)]

    _siege_watcher_trace_user_info siege_watcher_trace_user_info { get; set; }

}


[ProtoContract]
public class _strong_point_win_target_info
{
    [ProtoMember(1)]

    public ulong monster_uid { get; set; }
    [ProtoMember(2)]
    public uint cur_hp { get; set; }
    [ProtoMember(3)]
    _guild_simple_info occupy_guild_info { get; set; }

}

[ProtoContract]
public class _strong_point_win_target_hp_info
{
    [ProtoMember(1)]

    public ulong monster_uid { get; set; }
    [ProtoMember(2)]
    public uint cur_hp { get; set; }

}

[ProtoContract]
public class GAME_CLIENT_NTF_STRONG_POINT_ZONE_ENTER_INFO
{
    [ProtoMember(1)]

    _strong_point_info_v2 strong_point_info { get; set; }
    [ProtoMember(2)]
    _strong_point_win_target_info strong_point_win_target_info { get; set; }
    [ProtoMember(3)]
    public long win_target_occupy_time { get; set; }
    [ProtoMember(4)]
    public bool is_take_over_time { get; set; }
    [ProtoMember(5)]
    public long game_end_time { get; set; }
    [ProtoMember(6)]
    public string occupy_guild_proclamation { get; set; }

}

[ProtoContract]
public class GAME_CLIENT_NTF_STRONG_POINT_WIN_TARGET_INFO
{
    [ProtoMember(1)]

    _strong_point_win_target_info strong_point_win_target_info { get; set; }

}

[ProtoContract]
public class GAME_CLIENT_NTF_STRONG_POINT_WIN_TARGET_HP_INFO
{
    [ProtoMember(1)]

    _strong_point_win_target_hp_info strong_point_win_target_hp_info { get; set; }

}

[ProtoContract]
public class WORLD_CLIENT_ACK_STRONG_POINT_INFO_LIST
{
    [ProtoMember(1)]

    public _strong_point_info_v2 strong_point_info_list { get; set; }

}

[ProtoContract]
public class GAME_CLIENT_NTF_STRONG_POINT_GAME_END_INFO
{
    [ProtoMember(1)]

    public bool is_start_take_over { get; set; }
    [ProtoMember(2)]
    public bool is_take_over_time { get; set; }
    [ProtoMember(3)]
    public long game_end_time { get; set; }
    [ProtoMember(4)]
    public long next_status_time { get; set; }

}

[ProtoContract]
public class GAME_CLIENT_NTF_GAME_END_INFO
{
    [ProtoMember(1)]

    public bool is_start_take_over { get; set; }
    [ProtoMember(2)]
    public bool is_take_over_time { get; set; }
    [ProtoMember(3)]
    public long game_end_time { get; set; }
    [ProtoMember(4)]
    public long next_status_time { get; set; }

}

[ProtoContract]
public class WORLD_GAME_NTF_STRONG_POINT_STATUS
{
    [ProtoMember(1)]

    public ulong strong_point_zone_uid { get; set; }
    [ProtoMember(2)]
    _strong_point_server_info strong_point_server_info { get; set; }

}

[ProtoContract]
public class WORLD_CLIENT_NTF_STRONG_POINT_STATUS
{
    [ProtoMember(1)]

    public int strong_point_tid { get; set; }
    [ProtoMember(2)]
    public int strong_point_status { get; set; }

}

[ProtoContract]
public class GAME_WORLD_NTF_STRONG_POINT_WIN_TARGET_INFO
{
    [ProtoMember(1)]

    public int strong_point_tid { get; set; }
    [ProtoMember(2)]
    public ulong win_target_occupy_guild_uid { get; set; }
    [ProtoMember(3)]
    public bool is_win_target_new_guild_occupy { get; set; }
    [ProtoMember(4)]
    public uint win_target_cur_hp { get; set; }
    [ProtoMember(5)]
    public bool is_take_over_time { get; set; }

}

[ProtoContract]
public class WORLD_CLIENT_NTF_STRONG_POINT_WIN_TARGET_INFO
{
    [ProtoMember(1)]

    public int strong_point_tid { get; set; }
    [ProtoMember(2)]
    public ulong win_target_occupy_guild_uid { get; set; }
    [ProtoMember(3)]
    public string win_target_occupy_guild_name { get; set; }
    [ProtoMember(4)]
    public uint win_target_cur_hp { get; set; }
    [ProtoMember(5)]
    public bool is_take_over_time { get; set; }

}

[ProtoContract]
public class GAME_WORLD_REQ_STRONG_POINT_GAME_END
{
    [ProtoMember(1)]

    public int strong_point_tid { get; set; }
    [ProtoMember(2)]
    public ulong occupy_guild_uid { get; set; }
    [ProtoMember(3)]
    public ulong strong_point_zone_uid { get; set; }
    [ProtoMember(4)]
    public ulong mvp_user_uid { get; set; }

}

[ProtoContract]
public class WORLD_GAME_ACK_STRONG_POINT_GAME_END
{
    [ProtoMember(1)]

    public uint result { get; set; }
    [ProtoMember(2)]
    _strong_point_server_info strong_point_server_info { get; set; }
    [ProtoMember(3)]
    public ulong strong_point_zone_uid { get; set; }
    [ProtoMember(4)]
    public int return_strong_point_tid { get; set; }
    [ProtoMember(5)]
    public bool is_give_reward { get; set; }

}

[ProtoContract]
public class GAME_CLIENT_NTF_RESULT_STRONG_POINT_TO_BATTLE_USER
{
    [ProtoMember(1)]

    _guild_simple_info occupation_guild_simple_info { get; set; }
    [ProtoMember(2)]
    public string mvp_user_name { get; set; }
    [ProtoMember(3)]
    public int return_strong_point_tid { get; set; }

}

[ProtoContract]
public class WORLD_CLIENT_NTF_RESULT_STRONG_POINT_TO_ALL_USER
{
    [ProtoMember(1)]

    public int strong_point_tid { get; set; }
    [ProtoMember(2)]
    public string occupation_guild_name { get; set; }

}

[ProtoContract]
public class CLIENT_WORLD_REQ_STRONG_POINT_INFO_LIST
{

}

[ProtoContract]
public class WORLD_GAME_SYNC_STRONG_POINT_INFO_IN_ZONE_GROUP
{
    [ProtoMember(1)]

    _strong_point_server_info strong_point_server_info { get; set; }
    [ProtoMember(2)]
    public int strong_point_tid { get; set; }
    [ProtoMember(3)]
    _guild_simple_info strong_point_occupy_guild_info { get; set; }
    [ProtoMember(4)]
    public ulong win_target_occupy_guild_uid { get; set; }

}

[ProtoContract]
public class WORLD_GAME_SYNC_STRONG_POINT_INFO_LIST_IN_ZONE_GROUP
{
    [ProtoMember(1)]

    public _strong_point_server_info strong_point_server_info_list { get; set; }
    [ProtoMember(2)]
    public WORLD_GAME_SYNC_STRONG_POINT_INFO_IN_ZONE_GROUP strong_point_occupy_guild_info_list { get; set; }

}

[ProtoContract]
public class SERVER_CLIENT_NTF_STRONG_POINT_NOTICE
{
    [ProtoMember(1)]

    public int strong_point_tid { get; set; }
    [ProtoMember(2)]
    public uint notice_type { get; set; }
    [ProtoMember(3)]
    public ulong value { get; set; }
    [ProtoMember(4)]
    public string guild_name { get; set; }

}

[ProtoContract]
public class WORLD_GAME_NTF_STRONG_POINT_OCCUPY_CANCEL
{
    [ProtoMember(1)]

    public ulong strong_point_zone_uid { get; set; }

}

[ProtoContract]
public class WORLD_GAME_NTF_STRONG_POINT_WIN_TARGET_OCCUPY_CANCEL
{
    [ProtoMember(1)]

    public ulong strong_point_zone_uid { get; set; }
    [ProtoMember(2)]
    public ulong occupy_cancel_guild_uid { get; set; }

}

[ProtoContract]
public class WORLD_CLIENT_NTF_STRONG_POINT_OCCUPY_CANCEL
{
    [ProtoMember(1)]

    public int strong_point_tid { get; set; }

}

[ProtoContract]
public class WORLD_GAME_NTF_STRONG_POINT_SERVER_INFO_CHEAT
{
    [ProtoMember(1)]

    public ulong strong_point_zone_uid { get; set; }
    [ProtoMember(2)]
    _strong_point_server_info strong_point_server_info { get; set; }

}

[ProtoContract]
public class WORLD_GAME_NTF_STRONG_POINT_REWARD_TO_GUILD_MEMBER
{
    [ProtoMember(1)]

    public int strong_point_tid { get; set; }
    [ProtoMember(2)]
    public ulong user_uid { get; set; }

}

[ProtoContract]
public class GAME_CLIENT_NTF_STRONG_POINT_UNDER_WORLD_ZONE_ENTER_INFO
{
    [ProtoMember(1)]

    _strong_point_info_v2 strong_point_info { get; set; }
    [ProtoMember(2)]
    public string occupy_guild_proclamation { get; set; }

}

[ProtoContract]
public class CLIENT_WORLD_REQ_STRONG_POINT_PROCLAMATION
{
    [ProtoMember(1)]

    public int strong_point_tid { get; set; }
    [ProtoMember(2)]
    public string occupy_guild_proclamation { get; set; }

}

[ProtoContract]
public class WORLD_CLIENT_ACK_STRONG_POINT_PROCLAMATION
{
    [ProtoMember(1)]

    public uint result { get; set; }
    [ProtoMember(2)]
    public int strong_point_tid { get; set; }
    [ProtoMember(3)]
    public string occupy_guild_proclamation { get; set; }

}

[ProtoContract]
public class WORLD_CLIENT_NTF_STRONG_POINT_PROCLAMATION
{
    [ProtoMember(1)]

    public int strong_point_tid { get; set; }
    [ProtoMember(2)]
    public string occupy_guild_proclamation { get; set; }

}


[ProtoContract]
public class CLIENT_GAME_HOLY_STUFF_INFO
{

}

[ProtoContract]
public class GAME_CLIENT_HOLY_STUFF_INFO
{
    [ProtoMember(1)]

    public _holy_stuff_info[] _holy_stuff_infos { get; set; }

}

[ProtoContract]
public class CLIENT_GAME_HOLY_STUFF_SLOT_LEVELUP
{
    [ProtoMember(1)]

    public int holy_stuff_id { get; set; }

}

[ProtoContract]
public class GAME_CLIENT_HOLY_STUFF_SLOT_LEVELUP
{
    [ProtoMember(1)]

    public int result { get; set; }
    [ProtoMember(2)]
    public int holy_stuff_id { get; set; }
    [ProtoMember(3)]
    _holy_stuff_slot_info holy_stuff_slot_info { get; set; }
    [ProtoMember(4)]
    _cost_info cost_Infos { get; set; }
    [ProtoMember(5)]
    public _stack_item_info[] del_item_list { get; set; }
    [ProtoMember(6)]
    public bool is_success { get; set; }

}

[ProtoContract]
public class CLIENT_GAME_HOLY_STUFF_GRADE_UPGRADE
{
    [ProtoMember(1)]

    public int holy_stuff_id { get; set; }

}

[ProtoContract]
public class GAME_CLIENT_HOLY_STUFF_GRADE_UPGRADE
{
    [ProtoMember(1)]

    public int result { get; set; }
    [ProtoMember(2)]
    public int holy_stuff_id { get; set; }
    [ProtoMember(3)]
    public int holy_stuff_grade { get; set; }
    [ProtoMember(4)]
    _cost_info cost_Infos { get; set; }
    [ProtoMember(5)]
    public _stack_item_info[] del_item_list { get; set; }

}

[ProtoContract]
public class CLIENT_GAME_HOLY_STUFF_OPEN
{
    [ProtoMember(1)]

    public int holy_stuff_id { get; set; }

}

[ProtoContract]
public class GAME_CLIENT_HOLY_STUFF_OPEN
{
    [ProtoMember(1)]

    public int result { get; set; }
    [ProtoMember(2)]
    public int holy_stuff_id { get; set; }
    [ProtoMember(3)]
    public int holy_stuff_grade { get; set; }

}


[ProtoContract]
public class _hunting_squad_attribute
{
    [ProtoMember(1)]

    public uint target_dungeon_index { get; set; }
    [ProtoMember(2)]
    public uint limit_combat_point { get; set; }
    [ProtoMember(3)]
    public uint locked_slot_count { get; set; }

}

[ProtoContract]
public class _hunting_squad_member_info
{
    [ProtoMember(1)]

    public ulong member_uid { get; set; }
    [ProtoMember(2)]
    public int member_class { get; set; }
    [ProtoMember(3)]
    public int level { get; set; }
    [ProtoMember(4)]
    public string nickname { get; set; }
    [ProtoMember(5)]
    public int combatpoint { get; set; }
    [ProtoMember(6)]
    public string guild_name { get; set; }
    [ProtoMember(7)]
    public uint guild_mark { get; set; }
    [ProtoMember(8)]
    public uint guild_mark_edge { get; set; }
    [ProtoMember(9)]
    public ulong guild_uid { get; set; }

}

[ProtoContract]
public class _hunting_squad_member_slot_info
{
    [ProtoMember(1)]

    public uint slot_index { get; set; }
    [ProtoMember(2)]
    _hunting_squad_member_info member_info { get; set; }
    [ProtoMember(3)]
    public bool is_ready { get; set; }
    [ProtoMember(4)]
    public uint member_voice_chat_state { get; set; }

}

[ProtoContract]
public class _hunting_squad_info
{
    [ProtoMember(1)]

    public ulong uid { get; set; }
    [ProtoMember(2)]
    _hunting_squad_attribute hunting_squad_attribute { get; set; }
    [ProtoMember(3)]
    public _hunting_squad_member_info hunting_squad_member_list { get; set; }
    [ProtoMember(4)]
    public ulong leader_uid_ { get; set; }

}

[ProtoContract]
public class CLIENT_GAME_CREATE_HUNTING_SQUAD
{
    [ProtoMember(1)]

    _hunting_squad_attribute hunting_squad_attribute { get; set; }

}

[ProtoContract]
public class GAME_WORLD_CREATE_HUNTING_SQUAD
{
    [ProtoMember(1)]

    _hunting_squad_attribute hunting_squad_attribute { get; set; }
    [ProtoMember(2)]
    _hunting_squad_member_info create_member_info { get; set; }

}

[ProtoContract]
public class WORLD_GAME_CREATE_HUNTING_SQUAD
{
    [ProtoMember(1)]

    public ulong hunting_squad_uid { get; set; }
    [ProtoMember(2)]
    _hunting_squad_attribute hunting_squad_attribute { get; set; }
    [ProtoMember(3)]
    public ulong create_user_uid { get; set; }

}

[ProtoContract]
public class SERVER_CLIENT_CREATE_HUNTING_SQUAD_RESULT
{
    [ProtoMember(1)]

    public uint create_result { get; set; }
    [ProtoMember(2)]
    public ulong hunting_squad_uid { get; set; }
    [ProtoMember(3)]
    _hunting_squad_attribute hunting_squad_attribute { get; set; }

}

[ProtoContract]
public class CLIENT_GAME_INVITE_HUNTING_SQUAD
{
    [ProtoMember(1)]

    public ulong invite_user_uid { get; set; }

}

[ProtoContract]
public class GAME_WORLD_INVITE_HUNTING_SQUAD
{
    [ProtoMember(1)]

    public ulong invite_user_uid { get; set; }
    [ProtoMember(2)]
    public ulong invite_hunting_squad_uid { get; set; }
    [ProtoMember(3)]
    _hunting_squad_member_info request_user_info { get; set; }

}

[ProtoContract]
public class WORLD_GAME_REQUEST_INVITE_AGREE_HUNTING_SQUAD
{
    [ProtoMember(1)]

    public ulong agree_user_uid { get; set; }
    [ProtoMember(2)]
    public ulong invite_hunting_squad_uid { get; set; }
    [ProtoMember(3)]
    _hunting_squad_member_info request_member_info { get; set; }
    [ProtoMember(4)]
    public uint target_dungeon_index { get; set; }

}

[ProtoContract]
public class GAME_CLIENT_REQUEST_INVITE_AGREE_HUNTING_SQUAD
{
    [ProtoMember(1)]

    public ulong invite_hunting_squad_uid { get; set; }
    [ProtoMember(2)]
    _hunting_squad_member_info request_member_info { get; set; }

}

[ProtoContract]
public class CLIENT_GAME_REPLY_INVITE_AGREE_HUNTING_SQUAD
{
    [ProtoMember(1)]

    public ulong invite_hunting_squad_uid { get; set; }
    [ProtoMember(2)]
    public ulong request_user_uid { get; set; }
    [ProtoMember(3)]
    public bool agree_invite { get; set; }

}

[ProtoContract]
public class GAME_WORLD_REPLY_INVITE_AGREE_HUNTING_SQUAD
{
    [ProtoMember(1)]

    public ulong invite_hunting_squad_uid { get; set; }
    [ProtoMember(2)]
    public ulong request_user_uid { get; set; }
    [ProtoMember(3)]
    public bool agree_invite { get; set; }
    [ProtoMember(4)]
    public ulong prev_invite_user_hunting_squad_uid { get; set; }
    [ProtoMember(5)]
    _hunting_squad_member_info invite_member_info { get; set; }

}

[ProtoContract]
public class WORLD_GAME_ENTER_HUNTING_SQUAD
{
    [ProtoMember(1)]

    public ulong enter_user_uid { get; set; }
    [ProtoMember(2)]
    public ulong enter_hunting_squad_uid { get; set; }
    [ProtoMember(3)]
    public int enter_member_slot_index { get; set; }
    [ProtoMember(4)]
    _hunting_squad_attribute enter_hunting_squad_attribute { get; set; }
    [ProtoMember(5)]
    public _hunting_squad_member_slot_info member_info_list { get; set; }
    [ProtoMember(6)]
    public ulong leader_uid { get; set; }

}

[ProtoContract]
public class GAME_CLIENT_ENTER_HUNTING_SQUAD
{
    [ProtoMember(1)]

    public ulong enter_hunting_squad_uid { get; set; }
    [ProtoMember(2)]
    public int enter_member_slot_index { get; set; }
    [ProtoMember(3)]
    _hunting_squad_attribute enter_hunting_squad_attribute { get; set; }
    [ProtoMember(4)]
    public _hunting_squad_member_slot_info member_info_list { get; set; }
    [ProtoMember(5)]
    public ulong leader_uid { get; set; }

}

[ProtoContract]
public class WORLD_CLIENT_JOIN_HUNTING_SQUAD_MEMBER
{
    [ProtoMember(1)]

    _hunting_squad_member_slot_info join_member_info { get; set; }

}

[ProtoContract]
public class WORLD_CLIENT_LEAVE_HUNTING_SQUAD_MEMBER
{
    [ProtoMember(1)]

    public ulong leave_member_uid { get; set; }
    [ProtoMember(2)]
    public uint leave_reason { get; set; }
    [ProtoMember(3)]
    public ulong leader_uid { get; set; }

}

[ProtoContract]
public class CLIENT_GAME_REQUEST_ENTER_HUNTING_SQUAD
{
    [ProtoMember(1)]

    public ulong request_enter_hunting_squad_uid { get; set; }

}

[ProtoContract]
public class GAME_WORLD_REQUEST_ENTER_HUNTING_SQUAD
{
    [ProtoMember(1)]

    public ulong request_enter_hunting_squad_uid { get; set; }
    [ProtoMember(2)]
    _hunting_squad_member_info request_enter_member_info { get; set; }
    [ProtoMember(3)]
    public ulong prev_joined_hunting_squad_uid { get; set; }

}

[ProtoContract]
public class GAME_WORLD_REQUEST_HUNTING_SQUAD_INFO_FOR_REQUEST_ENTER
{
    [ProtoMember(1)]

    public ulong request_enter_hunting_squad_uid { get; set; }

}

[ProtoContract]
public class WORLD_GAME_HUNTING_SQUAD_INFO_FOR_REQUEST_ENTER
{
    [ProtoMember(1)]

    public ulong request_enter_user_uid { get; set; }
    [ProtoMember(2)]
    public ulong request_enter_hunting_squad_uid { get; set; }
    [ProtoMember(3)]
    _hunting_squad_attribute request_enter_hunting_squad_attribute { get; set; }

}

[ProtoContract]
public class SERVER_CLIENT_INVITE_ERROR
{
    [ProtoMember(1)]

    public uint error_id { get; set; }
    [ProtoMember(2)]
    public string invite_user_name { get; set; }

}

[ProtoContract]
public class SERVER_CLIENT_REQUEST_ENTER_ERROR
{
    [ProtoMember(1)]

    public uint error_id { get; set; }

}

[ProtoContract]
public class GAME_WORLD_HUNTING_SQUAD_INVITE_ERROR
{
    [ProtoMember(1)]

    public ulong request_user_uid { get; set; }
    [ProtoMember(2)]
    public uint error_id { get; set; }
    [ProtoMember(3)]
    public string invite_user_name { get; set; }

}

[ProtoContract]
public class WORLD_GAME_LEAVE_HUNTING_SQUAD
{
    [ProtoMember(1)]

    public ulong leave_user_uid { get; set; }
    [ProtoMember(2)]
    public uint leave_reason { get; set; }

}

[ProtoContract]
public class GAME_CLIENT_LEAVE_HUNTING_SQUAD
{
    [ProtoMember(1)]

    public uint leave_reason { get; set; }

}

[ProtoContract]
public class CLIENT_GAME_REQUEST_LEAVE_HUNTING_SQUAD
{

}

[ProtoContract]
public class GAME_WORLD_REQUEST_LEAVE_HUNTING_SQUAD
{
    [ProtoMember(1)]

    public ulong leave_hunting_squad_uid { get; set; }

}

[ProtoContract]
public class CLIENT_WORLD_LOCK_SLOT
{
    [ProtoMember(1)]

    public ulong hunting_squad_uid { get; set; }

}

[ProtoContract]
public class CLIENT_WORLD_UNLOCK_SLOT
{
    [ProtoMember(1)]

    public ulong hunting_squad_uid { get; set; }

}

[ProtoContract]
public class WORLD_CLIENT_NOTIFY_MEMBER_SLOT_LOCK
{
    [ProtoMember(1)]

    public uint slot_lock_count { get; set; }

}

[ProtoContract]
public class CLIENT_WORLD_REQUEST_KICK_USER
{
    [ProtoMember(1)]

    public ulong hunting_squad_uid { get; set; }
    [ProtoMember(2)]
    public ulong kick_user_uid { get; set; }

}

[ProtoContract]
public class CLIENT_WORLD_HUNTING_SQUAD_LIST
{
    [ProtoMember(1)]

    public uint dungeon_index { get; set; }

}

[ProtoContract]
public class WORLD_CLIENT_HUNTING_SQUAD_LIST
{
    [ProtoMember(1)]

    public _hunting_squad_info hunting_squad_list { get; set; }

}

[ProtoContract]
public class CLIENT_WORLD_HUNTING_SQUAD_NOTIFY_READY
{
    [ProtoMember(1)]

    public bool is_ready { get; set; }
    [ProtoMember(2)]
    public ulong hunting_squad_uid { get; set; }

}

[ProtoContract]
public class WORLD_CLIENT_HUNTING_SQUAD_NOTIFY_CHANGE_READY
{
    [ProtoMember(1)]

    public ulong change_user_uid { get; set; }
    [ProtoMember(2)]
    public bool is_ready { get; set; }

}

[ProtoContract]
public class GAME_CLIENT_SYNC_HUNTING_SQUAD_MEMBER_INFO
{
    [ProtoMember(1)]

    public ulong member_uid { get; set; }
    [ProtoMember(2)]
    public uint hp { get; set; }
    [ProtoMember(3)]
    public uint max_hp { get; set; }
    [ProtoMember(4)]
    public _vector3 pos { get; set; }

}

[ProtoContract]
public class GAME_WORLD_REQUEST_USER_HUNTING_SQUAD_INFO
{

}

[ProtoContract]
public class WORLD_GAME_USER_HUNTING_SQUAD_INFO
{
    [ProtoMember(1)]

    public ulong request_user_uid { get; set; }
    [ProtoMember(2)]
    public ulong hunting_squad_uid { get; set; }
    [ProtoMember(3)]
    _hunting_squad_attribute hunting_squad_attribute { get; set; }
    [ProtoMember(4)]
    public _hunting_squad_member_slot_info member_info_list { get; set; }
    [ProtoMember(5)]
    public ulong leader_uid { get; set; }

}

[ProtoContract]
public class GAME_CLIENT_USER_HUNTING_SQUAD_INFO
{
    [ProtoMember(1)]

    public ulong hunting_squad_uid { get; set; }
    [ProtoMember(2)]
    _hunting_squad_attribute hunting_squad_attribute { get; set; }
    [ProtoMember(3)]
    public _hunting_squad_member_slot_info member_info_list { get; set; }
    [ProtoMember(4)]
    public ulong leader_uid { get; set; }

}

[ProtoContract]
public class WORLD_GAME_NOTIFY_CHANGE_HUNTING_SQUAD_LEADER
{
    [ProtoMember(1)]

    public ulong member_uid { get; set; }
    [ProtoMember(2)]
    public ulong leader_uid { get; set; }

}

[ProtoContract]
public class CLIENT_WORLD_REQUEST_RECOMMEND_HUNTING_SQUAD_LIST
{
    [ProtoMember(1)]

    public uint[] recommend_dungeon_index { get; set; }

}

[ProtoContract]
public class WORLD_CLIENT_RECOMMEND_HUNTING_SQUAD_LIST
{
    [ProtoMember(1)]

    public _hunting_squad_info hunting_squad_list { get; set; }

}

[ProtoContract]
public class GAME_CLIENT_HUNTING_SQUAD_MEMBER_ITEM_DROP
{
    [ProtoMember(1)]

    public ulong member_uid { get; set; }
    [ProtoMember(2)]
    public _simple_item_info[] member_drop_item_list { get; set; }

}

[ProtoContract]
public class WORLD_GAME_NOTIFY_HUNTING_SQUAD_MEMBER_LEAVE
{
    [ProtoMember(1)]

    public ulong zone_uid { get; set; }
    [ProtoMember(2)]
    public ulong leave_user_uid { get; set; }

}

[ProtoContract]
public class GAME_CLIENT_NOTIFY_DUNGEON_CLEAR_LIST
{
    [ProtoMember(1)]

    public uint[] clear_dungeon_index { get; set; }

}

[ProtoContract]
public class _in_equip_jewel_info
{
    [ProtoMember(1)]

    public uint jewel_slot { get; set; }
    [ProtoMember(2)]
    public ulong jewel_itemuid { get; set; }

}

[ProtoContract]
public class _out_equip_jewel_info
{
    [ProtoMember(1)]

    public uint jewel_slot { get; set; }
    [ProtoMember(2)]
    public uint jewel_itemindex { get; set; }

}

[ProtoContract]
public class _drop_stackitem_info
{
    [ProtoMember(1)]

    public ulong itemuid { get; set; }
    [ProtoMember(2)]
    public int itemcount { get; set; }

}

[ProtoContract]
public class CLIENT_GAME_SELL_INVEN_ITEM
{
    [ProtoMember(1)]

    public ulong uid { get; set; }
    [ProtoMember(2)]
    public _stack_item_info[] sell_items { get; set; }

}

[ProtoContract]
public class GAME_CLIENT_SELL_INVEN_ITEM
{
    [ProtoMember(1)]

        public _cost_info costInfo { get; set; }
    [ProtoMember(2)]
        public _cost_info sellinfo { get; set; }
    [ProtoMember(3)]
    public _stack_item_info[] update_items { get; set; }

}

[ProtoContract]
public class CLIENT_GAME_SELL_INVEN_ITEM_STACK
{
    [ProtoMember(1)]

    public ulong uid { get; set; }
    [ProtoMember(2)]
    public ulong itemuid { get; set; }
    [ProtoMember(3)]
    public int sellcount { get; set; }

}

[ProtoContract]
public class GAME_CLIENT_SELL_INVEN_ITEM_STACK
{
    [ProtoMember(1)]

        public _cost_info costInfo { get; set; }
    [ProtoMember(2)]
        public _cost_info sellinfo { get; set; }
    [ProtoMember(3)]
    public _stack_item_info[] update_items { get; set; }

}

[ProtoContract]
public class CLIENT_GAME_BREAK_ITEM
{
    [ProtoMember(1)]

    public ulong uid { get; set; }
    [ProtoMember(2)]
    public ulong[] itemuids { get; set; }

}

[ProtoContract]
public class GAME_CLIENT_BREAK_ITEM
{
    [ProtoMember(1)]

    public ulong[] delitemuids { get; set; }
    [ProtoMember(2)]
    public _simple_item_info[] rewarditems { get; set; }
    [ProtoMember(3)]
    public _character_inven_item[] breakitems { get; set; }

}

[ProtoContract]
public class CLIENT_GAME_SMELTING_ITEM
{
    [ProtoMember(1)]

    public ulong uid { get; set; }
    [ProtoMember(2)]
    public ulong smelting_itemuid { get; set; }
    [ProtoMember(3)]
    public _stack_item_info[] material_item_list { get; set; }
    [ProtoMember(4)]
    public bool is_add_probability { get; set; }

}

[ProtoContract]
public class GAME_CLIENT_SMELTING_ITEM
{
    [ProtoMember(1)]

    public uint result { get; set; }
    [ProtoMember(2)]
    public uint smelting_result { get; set; }
    [ProtoMember(3)]
    _character_inven_item smelting_iteminfo { get; set; }
    [ProtoMember(4)]
    public _cost_info[] costinfo { get; set; }
    [ProtoMember(5)]
    public _stack_item_info[] material_items { get; set; }
    [ProtoMember(6)]
    public ulong break_item_uid { get; set; }

}

[ProtoContract]
public class _smelting_item
{
    [ProtoMember(1)]

    public ulong smelting_itemuid { get; set; }
    [ProtoMember(3)]
    public _stack_item_info[] material_item_list { get; set; }

}

[ProtoContract]
public class CLIENT_GAME_SMELTING_ITEM_MULTI
{
    [ProtoMember(1)]

    public ulong uid { get; set; }
    [ProtoMember(2)]
    public _smelting_item smeting_item_list { get; set; }

}

[ProtoContract]
public class GAME_CLIENT_SMELTING_ITEM_MULTI
{
    [ProtoMember(1)]

    public uint result { get; set; }
    [ProtoMember(2)]
    public uint[] smelting_result { get; set; }
    [ProtoMember(3)]
    public _character_inven_item[] smelting_iteminfo { get; set; }
    [ProtoMember(4)]
    public _cost_info[] costinfo { get; set; }
    [ProtoMember(5)]
    public _stack_item_info[] material_items { get; set; }
    [ProtoMember(6)]
    public ulong[] break_item_uid { get; set; }

}

[ProtoContract]
public class CLIENT_GAME_UPGRADE_ITEM
{
    [ProtoMember(1)]

    public ulong uid { get; set; }
    [ProtoMember(2)]
    public ulong upgrade_itemuid { get; set; }

}

[ProtoContract]
public class GAME_CLIENT_UPGRADE_ITEM
{
    [ProtoMember(1)]

    public uint result { get; set; }
    [ProtoMember(2)]
    _character_inven_item upgrade_info { get; set; }
    [ProtoMember(3)]
    _cost_info costinfo { get; set; }
    [ProtoMember(4)]
    public _stack_item_info[] del_item_info { get; set; }

}

[ProtoContract]
public class CLIENT_GAME_BUY_INVEN
{
    [ProtoMember(1)]

    public ulong uid { get; set; }
    [ProtoMember(2)]
    public int buyCount { get; set; }

}

[ProtoContract]
public class GAME_CLIENT_BUY_INVEN
{
    [ProtoMember(1)]

    public int buyCount { get; set; }
    [ProtoMember(2)]
    public int MaxInvenCount { get; set; }
    [ProtoMember(3)]
    public _cost_info[] costinfo { get; set; }

}

[ProtoContract]
public class _packet_c_useitem
{
    [ProtoMember(1)]

    public ulong uid { get; set; }

}

[ProtoContract]
public class CLIENT_GAME_USE_ITEM
{
    [ProtoMember(1)]

    public ulong use_item_uid { get; set; }
    [ProtoMember(2)]
    public int use_item_count { get; set; }
    [ProtoMember(3)]
    public bool is_inven_use { get; set; }

}

[ProtoContract]
public class GAME_CLIENT_FAILED_TO_USE_ITEM
{
    [ProtoMember(1)]

    public ulong use_item_uid { get; set; }

}

[ProtoContract]
public class GAME_CLIENT_CHANGE_HP
{
    [ProtoMember(1)]

    public ulong uid { get; set; }
    [ProtoMember(2)]
    public int hp { get; set; }

}

[ProtoContract]
public class GAME_CLIENT_OPEN_BOX
{
    [ProtoMember(1)]

    public _cost_info[] costInfos { get; set; }
    [ProtoMember(2)]
    public _simple_item_info[] rewarditems { get; set; }
    [ProtoMember(3)]
    public _character_inven_item[] openboxitems { get; set; }

}

[ProtoContract]
public class GAME_CLIENT_DROP_ITEM
{
    [ProtoMember(1)]

    public _cost_info[] costInfos { get; set; }
    [ProtoMember(2)]
    public _character_inven_item[] dropitems { get; set; }
    [ProtoMember(3)]
    public uint drop_type { get; set; }
    [ProtoMember(4)]
    public _vector3 drop_pos { get; set; }
    [ProtoMember(5)]
    public _time_ticket_info[] time_ticket_info { get; set; }
    [ProtoMember(6)]
    public uint drop_entity_type { get; set; }
    [ProtoMember(7)]
    public ulong drop_entity_uid { get; set; }
    [ProtoMember(8)]
    public uint drop_entity_tid { get; set; }

}

[ProtoContract]
public class GAME_CLIENT_CHANGE_ITEM_STACK
{
    [ProtoMember(1)]

    _stack_item_info item_info { get; set; }
    [ProtoMember(2)]
    public bool is_inven_use { get; set; }

}

[ProtoContract]
public class CLIENT_GAME_MAKE_ITEM
{
    [ProtoMember(1)]

    public ulong uid { get; set; }
    [ProtoMember(2)]
    public int makeitem_index { get; set; }
    [ProtoMember(3)]
    public int makeitem_count { get; set; }

}

[ProtoContract]
public class GAME_CLIENT_MAKE_ITEM
{
    [ProtoMember(1)]

    public int result { get; set; }
    [ProtoMember(2)]
    public int[] make_result { get; set; }
    [ProtoMember(3)]
    public _cost_info[] costInfo { get; set; }
    [ProtoMember(4)]
    public _stack_item_info[] update_stack_items { get; set; }
    [ProtoMember(5)]
    public _character_inven_item[] update_items { get; set; }
    [ProtoMember(6)]
    public int makeitem_index { get; set; }
    [ProtoMember(7)]
    public int makeitem_count { get; set; }
    [ProtoMember(8)]
    public _reward fail_reward_list { get; set; }
    [ProtoMember(9)]
    public _reward_cost fail_reward_cost_list { get; set; }
    [ProtoMember(10)]
    public uint[] fail_reward_cost_max_info { get; set; }

}

[ProtoContract]
public class CLIENT_GAME_MAKE_ITEM_XDRACO
{
    [ProtoMember(1)]

    public ulong uid { get; set; }
    [ProtoMember(2)]
    public int makeitem_index { get; set; }
    [ProtoMember(3)]
    public int makeitem_count { get; set; }

}

[ProtoContract]
public class GAME_CLIENT_MAKE_ITEM_XDRACO
{
    [ProtoMember(1)]

    public int result { get; set; }
    [ProtoMember(2)]
    public int[] make_result { get; set; }
    [ProtoMember(3)]
    public _cost_info[] costInfo { get; set; }
    [ProtoMember(4)]
    public _stack_item_info[] update_stack_items { get; set; }
    [ProtoMember(5)]
    public _character_inven_item[] update_items { get; set; }
    [ProtoMember(6)]
    public int makeitem_index { get; set; }
    [ProtoMember(7)]
    public int makeitem_count { get; set; }

}

[ProtoContract]
public class item_make_material_data
{
    [ProtoMember(1)]

    public int material_slot { get; set; }
    [ProtoMember(2)]
    public bool is_stack_item { get; set; }
    [ProtoMember(3)]
    public long item_uid { get; set; }

}

[ProtoContract]
public class CLIENT_GAME_SPECIAL_MAKE_ITEM
{
    [ProtoMember(1)]

    public uint makeitem_index { get; set; }
    [ProtoMember(2)]
    public item_make_material_data[] material_item_data { get; set; }

}

[ProtoContract]
public class GAME_CLIENT_SPECIAL_MAKE_ITEM
{
    [ProtoMember(1)]

    public int result { get; set; }
    [ProtoMember(2)]
    public _cost_info[] costInfo { get; set; }
    [ProtoMember(3)]
    public _stack_item_info[] del_items { get; set; }
    [ProtoMember(4)]
    _character_inven_item make_item { get; set; }
    [ProtoMember(5)]
    public _character_inven_item[] update_items { get; set; }
    [ProtoMember(6)]
    public int makeitem_index { get; set; }
    [ProtoMember(7)]
    public int make_result { get; set; }

}

[ProtoContract]
public class CLIENT_GAME_TRANSCENDENCE_ITEM
{
    [ProtoMember(1)]

    public ulong uid { get; set; }
    [ProtoMember(2)]
    public ulong transcendence_item_uid { get; set; }
    [ProtoMember(3)]
    public ulong material_itemuid { get; set; }

}

[ProtoContract]
public class GAME_CLIENT_TRANSCENDENCE_ITEM
{
    [ProtoMember(1)]

    public ulong del_itemuid { get; set; }
    [ProtoMember(2)]
    _cost_info costInfo { get; set; }
    [ProtoMember(3)]
    _character_inven_item update_item { get; set; }

}

[ProtoContract]
public class CLIENT_GAME_EQUIP_JEWEL
{
    [ProtoMember(1)]

    public ulong uid { get; set; }
    [ProtoMember(2)]
    public ulong item_uid { get; set; }
    [ProtoMember(3)]
    public _in_equip_jewel_info[] equip_jewel_slots { get; set; }

}

[ProtoContract]
public class GAME_CLIENT_EQUIP_JEWEL
{
    [ProtoMember(1)]

    public uint result { get; set; }
    [ProtoMember(2)]
    public ulong item_uid { get; set; }
    [ProtoMember(3)]
    public _out_equip_jewel_info[] equip_jewel_slots { get; set; }
    [ProtoMember(4)]
    public _stack_item_info[] update_items { get; set; }

}

[ProtoContract]
public class CLIENT_GAME_SWAP_JEWEL
{
    [ProtoMember(1)]

    public ulong item_uid { get; set; }
    [ProtoMember(2)]
    _in_equip_jewel_info swap_jewel_slot { get; set; }

}

[ProtoContract]
public class GAME_CLIENT_SWAP_JEWEL
{
    [ProtoMember(1)]

    public uint result { get; set; }
    [ProtoMember(2)]
    public ulong item_uid { get; set; }
    [ProtoMember(3)]
    public _out_equip_jewel_info[] equip_jewel_slot { get; set; }
    [ProtoMember(4)]
    public _stack_item_info[] del_item { get; set; }
    [ProtoMember(5)]
    public _character_inven_item[] update_item { get; set; }

}

[ProtoContract]
public class CLIENT_GAME_UPGRADE_JEWEL
{
    [ProtoMember(1)]

    public ulong item_uid { get; set; }
    [ProtoMember(2)]
    public int jewel_slot { get; set; }
    [ProtoMember(3)]
    public ulong jewel_itemuid { get; set; }
    [ProtoMember(4)]
    public _stack_item_info[] material_jewel_item { get; set; }
    [ProtoMember(5)]
    public bool is_auto { get; set; }

}

[ProtoContract]
public class GAME_CLIENT_UPGRADE_JEWEL_EQUIP_SLOT
{
    [ProtoMember(1)]

    public uint result { get; set; }
    [ProtoMember(2)]
    public ulong item_uid { get; set; }
    [ProtoMember(3)]
    public uint jewel_slot { get; set; }
    [ProtoMember(4)]
    public uint jewel_itemindex { get; set; }
    [ProtoMember(5)]
    public uint before_jewel_itemindex { get; set; }
    [ProtoMember(6)]
    public _cost_info costInfo { get; set; }
    [ProtoMember(7)]
    public _stack_item_info[] update_items { get; set; }
    [ProtoMember(8)]
    public bool is_success { get; set; }

}

[ProtoContract]
public class GAME_CLIENT_JEWEL_UPGRADE_INVEN
{
    [ProtoMember(1)]

    public uint result { get; set; }
    [ProtoMember(2)]
    public _cost_info costInfo { get; set; }
    [ProtoMember(3)]
    public _character_inven_item upgrade_item { get; set; }
    [ProtoMember(4)]
    public _stack_item_info[] update_items { get; set; }
    [ProtoMember(5)]
    public bool is_success { get; set; }
    [ProtoMember(6)]
    public bool is_auto { get; set; }

}

[ProtoContract]
public class CLIENT_GAME_EXTRACTION_JEWEL
{
    [ProtoMember(1)]

    public ulong uid { get; set; }
    [ProtoMember(2)]
    public ulong item_uid { get; set; }
    [ProtoMember(3)]
    public uint jewel_slot { get; set; }

}

[ProtoContract]
public class GAME_CLIENT_EXTRACTION_JEWEL
{
    [ProtoMember(1)]

    public uint result { get; set; }
    [ProtoMember(2)]
    public ulong item_uid { get; set; }
    [ProtoMember(3)]
    public uint jewel_slot { get; set; }
    [ProtoMember(4)]
    _cost_info costInfo { get; set; }
    [ProtoMember(5)]
    _character_inven_item update_items { get; set; }

}

[ProtoContract]
public class CLIENT_GAME_EXTRACTION_JEWEL_new
{
    [ProtoMember(1)]

    public ulong uid { get; set; }
    [ProtoMember(2)]
    public ulong item_uid { get; set; }
    [ProtoMember(3)]
    public uint[] jewel_slots { get; set; }
    [ProtoMember(4)]
    public uint client_link_type { get; set; }

}

[ProtoContract]
public class GAME_CLIENT_EXTRACTION_JEWEL_new
{
    [ProtoMember(1)]

    public uint result { get; set; }
    [ProtoMember(2)]
    public ulong item_uid { get; set; }
    [ProtoMember(3)]
    public uint[] jewel_slots { get; set; }
    [ProtoMember(4)]
    _cost_info cost_info { get; set; }
    [ProtoMember(5)]
    public _character_inven_item[] update_items { get; set; }
    [ProtoMember(6)]
    public uint client_link_type { get; set; }

}

[ProtoContract]
public class CLIENT_GAME_JEWEL_COMPOSE
{
    [ProtoMember(1)]

    public _stack_item_info[] meterials { get; set; }
    [ProtoMember(2)]
    public bool is_auto { get; set; }

}

[ProtoContract]
public class GAME_CLIENT_JEWEL_COMPOSE
{
    [ProtoMember(1)]

    public uint result { get; set; }
    [ProtoMember(2)]
    public int compose_result { get; set; }
    [ProtoMember(3)]
    public _cost_info[] cost_info { get; set; }
    [ProtoMember(5)]
    public _stack_item_info[] update_item { get; set; }
    [ProtoMember(6)]
    public _character_inven_item[] reward_item { get; set; }
    [ProtoMember(7)]
    public bool is_auto { get; set; }

}

[ProtoContract]
public class CLIENT_GAME_TRANSFER_ITEM
{
    [ProtoMember(1)]

    public ulong uid { get; set; }
    [ProtoMember(2)]
    public ulong target_item_uid { get; set; }
    [ProtoMember(3)]
    public ulong material_item_uid { get; set; }

}

[ProtoContract]
public class GAME_CLIENT_TRANSFER_ITEM
{
    [ProtoMember(1)]

    public uint result { get; set; }
    [ProtoMember(2)]
    _cost_info costInfo { get; set; }
    [ProtoMember(3)]
    _character_inven_item target_item { get; set; }
    [ProtoMember(4)]
    public ulong del_material_item_uid { get; set; }

}

[ProtoContract]
public class GAME_CLIENT_TRANSFER_ITEM_new
{
    [ProtoMember(1)]

    public uint result { get; set; }
    [ProtoMember(2)]
    _cost_info costInfo { get; set; }
    [ProtoMember(3)]
    _character_inven_item target_item { get; set; }
    [ProtoMember(4)]
    public ulong del_material_item_uid { get; set; }
    [ProtoMember(5)]
    public uint target_item_equip_slot { get; set; }
    [ProtoMember(6)]
    public _character_inven_item[] extraction_jewel_item_list { get; set; }
    [ProtoMember(7)]
    _character_inven_item material_item { get; set; }

}

[ProtoContract]
public class CLIENT_GAME_GET_CHANGE_OPTION
{
    [ProtoMember(1)]

    public ulong uid { get; set; }

}

[ProtoContract]
public class GAME_CLIENT_GET_CHANGE_OPTION
{
    [ProtoMember(1)]

    public uint result { get; set; }
    [ProtoMember(2)]
    public ulong item_uid { get; set; }
    [ProtoMember(3)]
    public ItemOptionInfo[] random_option_list { get; set; }
    [ProtoMember(4)]
    public bool is_special { get; set; }

}

[ProtoContract]
public class CLIENT_GAME_CHANGE_OPTION_ITEM
{
    [ProtoMember(1)]

    public ulong uid { get; set; }
    [ProtoMember(2)]
    public ulong item_uid { get; set; }
    [ProtoMember(3)]
    public bool is_special { get; set; }

}

[ProtoContract]
public class GAME_CLIENT_CHANGE_OPTION_ITEM
{
    [ProtoMember(1)]

    public uint result { get; set; }
    [ProtoMember(2)]
    public _cost_info[] costInfo { get; set; }
    [ProtoMember(3)]
    public ItemOptionInfo[] random_option_list { get; set; }
    [ProtoMember(4)]
    public _stack_item_info[] del_item_list { get; set; }
    [ProtoMember(5)]
    public bool is_special { get; set; }

}

[ProtoContract]
public class CLIENT_GAME_DECIDE_CHANGE_OPTION
{
    [ProtoMember(1)]

    public ulong uid { get; set; }
    [ProtoMember(2)]
    public ulong item_uid { get; set; }
    [ProtoMember(3)]
    public bool is_new_option { get; set; }
    [ProtoMember(4)]
    public bool is_special { get; set; }

}

[ProtoContract]
public class GAME_CLIENT_DECIDE_CHANGE_OPTION
{
    [ProtoMember(1)]

    public uint result { get; set; }
    [ProtoMember(2)]
    _character_inven_item target_item { get; set; }

}

[ProtoContract]
public class GAME_CLIENT_PACKAGE_ITEM
{
    [ProtoMember(1)]

    public uint result { get; set; }
    [ProtoMember(2)]
    _stack_item_info delete_item { get; set; }
    [ProtoMember(3)]
    public _cost_info[] cost_infos { get; set; }
    [ProtoMember(4)]
    public _character_inven_item[] update_items { get; set; }

}

[ProtoContract]
public class GAME_CLIENT_RANDOM_BOX_ITEM
{
    [ProtoMember(1)]

    public uint result { get; set; }
    [ProtoMember(2)]
    _stack_item_info delete_item { get; set; }
    [ProtoMember(3)]
    public _reward_cost_info[] reward_cost_infos { get; set; }
    [ProtoMember(4)]
    public _simple_item_info[] reward_item_index { get; set; }
    [ProtoMember(5)]
    public _cost_info[] cost_infos { get; set; }
    [ProtoMember(6)]
    public _character_inven_item[] update_items { get; set; }

}

[ProtoContract]
public class GAME_CLIENT_PACKAGE_ITEM_START
{
    [ProtoMember(1)]

    public uint result { get; set; }
    [ProtoMember(2)]
    public uint use_packet_item_count { get; set; }
    [ProtoMember(3)]
    _stack_item_info delete_item { get; set; }
    [ProtoMember(4)]
    public _cost_info[] cost_infos { get; set; }
    [ProtoMember(5)]
    public uint stop_result { get; set; }
    [ProtoMember(6)]
    public _dungeon_ticket_info dungeon_ticket_info { get; set; }

}

[ProtoContract]
public class GAME_CLIENT_PACKAGE_ITEM_DATA
{
    [ProtoMember(1)]

    public _character_inven_item[] update_items { get; set; }

}

[ProtoContract]
public class GAME_CLIENT_PACKAGE_ITEM_END
{

}

[ProtoContract]
public class GAME_CLIENT_RANDOM_BOX_ITEM_START
{
    [ProtoMember(1)]

    public uint result { get; set; }
    [ProtoMember(2)]
    _stack_item_info delete_item { get; set; }
    [ProtoMember(3)]
    public _reward_cost_info[] reward_cost_infos { get; set; }
    [ProtoMember(4)]
    public _simple_item_info[] reward_item_index { get; set; }
    [ProtoMember(5)]
    public _cost_info[] cost_infos { get; set; }
    [ProtoMember(6)]
    public uint stop_result { get; set; }
    [ProtoMember(7)]
    public _dungeon_ticket_info dungeon_ticket_info { get; set; }

}

[ProtoContract]
public class GAME_CLIENT_RANDOM_BOX_ITEM_DATA
{
    [ProtoMember(1)]

    public _character_inven_item[] update_items { get; set; }

}

[ProtoContract]
public class GAME_CLIENT_RANDOM_BOX_ITEM_END
{

}

[ProtoContract]
public class CLIENT_GAME_EXCHANGE_ITEM
{
    [ProtoMember(1)]

    public ulong uid { get; set; }
    [ProtoMember(2)]
    public int makeitem_index { get; set; }
    [ProtoMember(3)]
    public int makeitem_count { get; set; }

}

[ProtoContract]
public class GAME_CLIENT_EXCHANGE_ITEM
{
    [ProtoMember(1)]

    public int result { get; set; }
    [ProtoMember(2)]
    public int[] make_result { get; set; }
    [ProtoMember(3)]
    public _cost_info[] costInfo { get; set; }
    [ProtoMember(4)]
    public _stack_item_info[] update_stack_items { get; set; }
    [ProtoMember(5)]
    public _character_inven_item[] update_items { get; set; }
    [ProtoMember(6)]
    public int makeitem_index { get; set; }
    [ProtoMember(7)]
    public int makeitem_count { get; set; }

}

[ProtoContract]
public class _compse_data
{
    [ProtoMember(1)]

    public _stack_item_info[] compse_material_list { get; set; }

}

[ProtoContract]
public class _compose_result_data
{
    [ProtoMember(1)]

    public int compse_result { get; set; }
    [ProtoMember(3)]
    _simple_item_info compse_item_data { get; set; }
    [ProtoMember(4)]
    public int add_fail_point { get; set; }
    [ProtoMember(5)]
    _compose_fail_data current_fail_data { get; set; }
    [ProtoMember(6)]
    _simple_item_info_ex_xdraco compose_item_data_ex_xdraco { get; set; }

}

[ProtoContract]
public class CLIENT_GAME_ITEM_COMPOSE
{
    [ProtoMember(1)]

    public _compse_data[] material_list { get; set; }

}

[ProtoContract]
public class GAME_CLIENT_ITEM_COMPOSE
{
    [ProtoMember(1)]

    public int result { get; set; }
    [ProtoMember(2)]
    public _compose_result_data compse_result_data { get; set; }
    [ProtoMember(3)]
    public _stack_item_info[] update_stack_items { get; set; }
    [ProtoMember(4)]
    public _character_inven_item[] update_items { get; set; }
    [ProtoMember(5)]
    public _cost_info[] update_cost_infos { get; set; }

}

[ProtoContract]
public class CLIENT_GAME_ITEM_COMPOSE_POINT_REWARD //b5 ea 00 00 00 00 00 00 00 00 00 00 
{
    [ProtoMember(1)]

    public int[] fail_type_list { get; set; }

}

[ProtoContract]
public class GAME_CLIENT_ITEM_COMPOSE_POINT_REWARD
{
    [ProtoMember(1)]

    public int result { get; set; }
    [ProtoMember(2)]
    public _compose_result_data compse_result_data { get; set; }
    [ProtoMember(3)]
    public _stack_item_info[] update_stack_items { get; set; }
    [ProtoMember(4)]
    public _character_inven_item[] update_items { get; set; }

}

[ProtoContract]
public class GAME_CLIENT_USE_COMPOSE_POINT
{
    [ProtoMember(1)]

    public int result { get; set; }
    [ProtoMember(2)]
    public _compose_result_data compse_result_data { get; set; }
    [ProtoMember(3)]
    public _stack_item_info[] update_stack_items { get; set; }

}

[ProtoContract]
public class CLIENT_GAME_ITEM_COLLECTION_REGISTER
{
    [ProtoMember(1)]

    public int collection_id { get; set; }
    [ProtoMember(2)]
    public int collection_slot { get; set; }
    [ProtoMember(3)]
    public long resigter_item_uid { get; set; }

}

[ProtoContract]
public class GAME_CLIENT_ITEM_COLLECTION_REGISTER
{
    [ProtoMember(1)]

    public int result { get; set; }
    [ProtoMember(2)]
    public int collection_id { get; set; }
    [ProtoMember(3)]
    public bool is_complate { get; set; }
    [ProtoMember(4)]
    _item_collection_info collection_info { get; set; }
    [ProtoMember(5)]
    public _stack_item_info[] update_stack_items { get; set; }

}

[ProtoContract]
public class WORLD_GAME_ITEM_COLLECTION_DEL_ALL
{
    [ProtoMember(1)]

    public int[] del_collection_id { get; set; }

}

[ProtoContract]
public class _period_equip_info
{
    [ProtoMember(1)]

    public ulong item_uid { get; set; }
    [ProtoMember(2)]
    public int equip_type { get; set; }
    [ProtoMember(3)]
    public ulong equip_object_uid { get; set; }
    [ProtoMember(4)]
    public int equip_slot { get; set; }

}

[ProtoContract]
public class GAME_CLIENT_DELETE_PERIOD_ITEM
{
    [ProtoMember(1)]

    public _period_equip_info del_period_item_equip_info_list { get; set; }
    [ProtoMember(2)]
    public _stack_item_info[] del_period_item_list { get; set; }

}

[ProtoContract]
public class CLIENT_GAME_CHANGE_ITEM_LOCK
{
    [ProtoMember(1)]

    public ulong item_uid { get; set; }
    [ProtoMember(2)]
    public bool is_lock { get; set; }

}

[ProtoContract]
public class GAME_CLIENT_CHANGE_ITEM_LOCK
{
    [ProtoMember(1)]

    public int result { get; set; }
    [ProtoMember(2)]
    public ulong item_uid { get; set; }
    [ProtoMember(3)]
    public bool is_lock { get; set; }

}

[ProtoContract]
public class CLIENT_GAME_ITEM_RANDOM_EXCHANGE
{
    [ProtoMember(1)]

    _stack_item_info material_info { get; set; }

}

[ProtoContract]
public class GAME_CLIENT_ITEM_RANDOM_EXCHANGE
{
    [ProtoMember(1)]

    public int result { get; set; }
    [ProtoMember(2)]
    _simple_item_info exchange_info { get; set; }
    [ProtoMember(3)]
    public _cost_info[] costInfo { get; set; }
    [ProtoMember(4)]
    public _stack_item_info[] update_stack_items { get; set; }
    [ProtoMember(5)]
    public _character_inven_item[] update_items { get; set; }

}

[ProtoContract]
public class CLIENT_GAME_ITEM_SPECIAL_EXCHANGE
{
    [ProtoMember(1)]

    _stack_item_info material_info { get; set; }
    [ProtoMember(2)]
    public int select_item_index { get; set; }

}

[ProtoContract]
public class GAME_CLIENT_ITEM_SPECIAL_EXCHANGE
{
    [ProtoMember(1)]

    public int result { get; set; }
    [ProtoMember(2)]
    _simple_item_info exchange_info { get; set; }
    [ProtoMember(3)]
    public _cost_info[] costInfo { get; set; }
    [ProtoMember(4)]
    public _stack_item_info[] update_stack_items { get; set; }
    [ProtoMember(5)]
    public _character_inven_item[] update_items { get; set; }

}

[ProtoContract]
public class CLIENT_GAME_MAGICSTONE_TRANCE_ITEM
{
    [ProtoMember(1)]

    public ulong trance_itemuid { get; set; }
    [ProtoMember(2)]
    public ulong material_itemuid { get; set; }
    [ProtoMember(3)]
    public bool use_item_add_rate { get; set; }

}

[ProtoContract]
public class GAME_CLIENT_MAGICSTONE_TRANCE_ITEM
{
    [ProtoMember(1)]

    public uint result { get; set; }
    [ProtoMember(2)]
    public uint trance_result { get; set; }
    [ProtoMember(3)]
    _character_inven_item trance_iteminfo { get; set; }
    [ProtoMember(4)]
    public _cost_info[] cost_info { get; set; }
    [ProtoMember(5)]
    public _stack_item_info[] material_items { get; set; }
    [ProtoMember(6)]
    public _character_inven_item[] break_pieces_items { get; set; }
    [ProtoMember(7)]
    public ulong break_item_uid { get; set; }
    [ProtoMember(8)]
    public int[] del_deck_solt_list { get; set; }

}

[ProtoContract]
public class CLIENT_GAME_ITEM_COOLTIME
{

}

[ProtoContract]
public class GAME_CLIENT_ITEM_COOLTIME
{
    [ProtoMember(1)]

    public _item_cooltime_data[] cooltime_list { get; set; }

}

[ProtoContract]
public class GAME_CLIENT_INVEN_EXTEND
{
    [ProtoMember(1)]

    public uint result { get; set; }
    [ProtoMember(2)]
    public int buy_count { get; set; }
    [ProtoMember(3)]
    public int max_inven_count { get; set; }
    [ProtoMember(4)]
    public _cost_info[] costinfo { get; set; }
    [ProtoMember(5)]
    public _stack_item_info[] del_items { get; set; }

}

[ProtoContract]
public class GAME_CLIENT_USE_SERVER_EXPEDITION_CHARGE_LIFE
{
    [ProtoMember(1)]

    public int result { get; set; }
    [ProtoMember(2)]
    public int life_count { get; set; }
    [ProtoMember(3)]
    public _stack_item_info[] update_stack_items { get; set; }

}

[ProtoContract]
public class _make_item_agency_info
{
    [ProtoMember(1)]

    public int makeitem_index { get; set; }
    [ProtoMember(2)]
    public int makeitem_make_count { get; set; }
    [ProtoMember(3)]
    public int makeitem_try_make_count { get; set; }
    [ProtoMember(4)]
    public int makeitem_world_make_count { get; set; }

}

[ProtoContract]
public class CLIENT_GAME_MAKE_ITEM_AGENCY_INFOS
{
    [ProtoMember(1)]

    public ulong uid { get; set; }

}

[ProtoContract]
public class GAME_WORLD_MAKE_ITEM_AGENCY_INFOS
{
    [ProtoMember(1)]

    public ulong uid { get; set; }
    [ProtoMember(2)]
    public _make_item_agency_info make_item_agency_infos { get; set; }

}

[ProtoContract]
public class WORLD_CLIENT_MAKE_ITEM_AGENCY_INFOS
{
    [ProtoMember(1)]

    public _make_item_agency_info make_item_agency_infos { get; set; }

}

[ProtoContract]
public class CLIENT_GAME_MAKE_ITEM_AGENCY
{
    [ProtoMember(1)]

    public ulong uid { get; set; }
    [ProtoMember(2)]
    public int makeitem_index { get; set; }
    [ProtoMember(3)]
    public int makeitem_count { get; set; }

}

[ProtoContract]
public class GAME_CLIENT_MAKE_ITEM_AGENCY
{
    [ProtoMember(1)]

    public int result { get; set; }
    [ProtoMember(2)]
    public int[] make_result { get; set; }
    [ProtoMember(3)]
    public _cost_info[] costInfo { get; set; }
    [ProtoMember(4)]
    public _stack_item_info[] update_stack_items { get; set; }
    [ProtoMember(5)]
    public _character_inven_item[] update_items { get; set; }
    [ProtoMember(6)]
    public int makeitem_index { get; set; }
    [ProtoMember(7)]
    public int makeitem_count { get; set; }
    [ProtoMember(8)]
    public _is_fail_reward is_fail_rewards { get; set; }
    [ProtoMember(9)]
    public int make_count { get; set; }
    [ProtoMember(11)]
    public int try_make_count { get; set; }
    [ProtoMember(12)]
    public int world_make_count { get; set; }

}

[ProtoContract]
public class _reward
{
    [ProtoMember(1)]

    public int item_index { get; set; }
    [ProtoMember(2)]
    public int item_count { get; set; }
    [ProtoMember(3)]
    public int smelting_level { get; set; }

}

[ProtoContract]
public class _del_materialI
{
    [ProtoMember(1)]

    public long item_uid { get; set; }
    [ProtoMember(2)]
    public int spend_stack_count { get; set; }
    [ProtoMember(3)]
    public long period_end_time { get; set; }

}

[ProtoContract]
public class _reward_cost
{
    [ProtoMember(1)]

    public int cost_type { get; set; }
    [ProtoMember(2)]
    public long cost_value { get; set; }

}

[ProtoContract]
public class _is_fail_reward
{
    [ProtoMember(1)]

    public bool[] is_rewards { get; set; }

}

[ProtoContract]
public class GAME_WORLD_MAKE_ITEM_AGENCY
{
    [ProtoMember(1)]

    public ulong uid { get; set; }
    [ProtoMember(2)]
    public int makeitem_index { get; set; }
    [ProtoMember(3)]
    public int makeitem_count { get; set; }
    [ProtoMember(4)]
    public int[] make_result { get; set; }
    [ProtoMember(5)]
    public _reward reward_list { get; set; }
    [ProtoMember(6)]
    public _del_materialI del_materialI_list { get; set; }
    [ProtoMember(7)]
    public _reward_cost reward_cost_list { get; set; }
    [ProtoMember(8)]
    public int success_count { get; set; }
    [ProtoMember(9)]
    public int bonus_count { get; set; }
    [ProtoMember(10)]
    public int fail_count { get; set; }
    [ProtoMember(11)]
    public _is_fail_reward is_fail_rewards { get; set; }

}

[ProtoContract]
public class WORLD_GAME_MAKE_ITEM_AGENCY
{
    [ProtoMember(1)]

    public ulong uid { get; set; }
    [ProtoMember(2)]
    public int makeitem_index { get; set; }
    [ProtoMember(3)]
    public int makeitem_count { get; set; }
    [ProtoMember(4)]
    public int[] make_result { get; set; }
    [ProtoMember(5)]
    public _reward reward_list { get; set; }
    [ProtoMember(6)]
    public _del_materialI del_materialI_list { get; set; }
    [ProtoMember(7)]
    public _reward_cost reward_cost_list { get; set; }
    [ProtoMember(8)]
    public int success_count { get; set; }
    [ProtoMember(9)]
    public int bonus_count { get; set; }
    [ProtoMember(10)]
    public int fail_count { get; set; }
    [ProtoMember(11)]
    public _is_fail_reward is_fail_rewards { get; set; }
    [ProtoMember(12)]
    public int world_make_count { get; set; }
    [ProtoMember(13)]
    public int result { get; set; }

}

[ProtoContract]
public class GAME_WORLD_MAKE_ITEM_AGENCY_COUNT
{
    [ProtoMember(1)]

    public ulong uid { get; set; }
    [ProtoMember(2)]
    public int request_makeitem_index { get; set; }
    [ProtoMember(3)]
    public int request_makeitem_count { get; set; }

}

[ProtoContract]
public class WORLD_GAME_MAKE_ITEM_AGENCY_COUNT
{
    [ProtoMember(1)]

    public ulong uid { get; set; }
    [ProtoMember(2)]
    public int request_makeitem_index { get; set; }
    [ProtoMember(3)]
    public int request_makeitem_count { get; set; }
    [ProtoMember(4)]
    public int world_make_count { get; set; }

}

[ProtoContract]
public class GAME_WORLD_CHEAT_MAKE_ITEM_AGENCY_COUNT
{
    [ProtoMember(1)]

    public ulong uid { get; set; }
    [ProtoMember(2)]
    public _make_item_agency_info make_item_agency_infos { get; set; }
    [ProtoMember(3)]
    public int makeitem_index { get; set; }
    [ProtoMember(4)]
    public int world_make_count { get; set; }

}

[ProtoContract]
public class _expensive_item
{
    [ProtoMember(1)]

    public uint item_index { get; set; }
    [ProtoMember(2)]
    public uint item_count { get; set; }

}

[ProtoContract]
public class GAME_WORLD_EXPENSIVE_ITEM_ADD_COUNT
{
    [ProtoMember(1)]

    public ulong uid { get; set; }
    [ProtoMember(2)]
    public _expensive_item reward_list { get; set; }
    [ProtoMember(3)]
    public _vector3 drop_pos { get; set; }
    [ProtoMember(4)]
    public uint drop_entity_type { get; set; }
    [ProtoMember(5)]
    public ulong drop_entity_uid { get; set; }
    [ProtoMember(6)]
    public uint drop_entity_tid { get; set; }
    [ProtoMember(7)]
    public uint stage_id { get; set; }

}

[ProtoContract]
public class WORLD_GAME_EXPENSIVE_ITEM_DROP
{
    [ProtoMember(1)]

    public ulong uid { get; set; }
    [ProtoMember(2)]
    public _expensive_item reward_list { get; set; }
    [ProtoMember(3)]
    public _vector3 drop_pos { get; set; }
    [ProtoMember(4)]
    public uint drop_entity_type { get; set; }
    [ProtoMember(5)]
    public ulong drop_entity_uid { get; set; }
    [ProtoMember(6)]
    public uint drop_entity_tid { get; set; }
    [ProtoMember(7)]
    public uint stage_id { get; set; }

}

[ProtoContract]
public class GAME_WORLD_EXPENSIVE_ITEM_MINUS_COUNT
{
    [ProtoMember(1)]

    public _expensive_item reward_list { get; set; }

}

[ProtoContract]
public class CLIENT_GAME_MYSTICAL_PIECE_TRANCE_ITEM
{
    [ProtoMember(1)]

    public ulong trance_itemuid { get; set; }
    [ProtoMember(2)]
    public ulong material_itemuid { get; set; }
    [ProtoMember(3)]
    public bool use_item_add_rate { get; set; }

}

[ProtoContract]
public class GAME_CLIENT_MYSTICAL_PIECE_TRANCE_ITEM
{
    [ProtoMember(1)]

    public uint result { get; set; }
    [ProtoMember(2)]
    public uint trance_result { get; set; }
    [ProtoMember(3)]
    _character_inven_item trance_iteminfo { get; set; }
    [ProtoMember(4)]
    public _cost_info[] cost_info { get; set; }
    [ProtoMember(5)]
    public _stack_item_info[] material_items { get; set; }
    [ProtoMember(6)]
    public _character_inven_item[] break_pieces_items { get; set; }
    [ProtoMember(7)]
    public ulong break_item_uid { get; set; }
    [ProtoMember(8)]
    public int[] del_deck_solt_list { get; set; }

}

[ProtoContract]
public class _make_item_xdraco_limit_package_info
{
    [ProtoMember(1)]

    public int makeitem_index { get; set; }
    [ProtoMember(2)]
    public int make_count { get; set; }

}

[ProtoContract]
public class CLIENT_GAME_MAKE_ITEM_XDRACO_LIMIT_PACKAGE_INFOS
{

}

[ProtoContract]
public class GAME_CLIENT_MAKE_ITEM_XDRACO_LIMIT_PACKAGE_INFOS
{
    [ProtoMember(1)]

    public _make_item_xdraco_limit_package_info make_item_xdraco_limit_packet_infos { get; set; }

}

[ProtoContract]
public class CLIENT_GAME_MAKE_ITEM_XDRACO_LIMIT_PACKAGE
{
    [ProtoMember(1)]

    public ulong uid { get; set; }
    [ProtoMember(2)]
    public int makeitem_index { get; set; }
    [ProtoMember(3)]
    public int makeitem_count { get; set; }

}

[ProtoContract]
public class GAME_CLIENT_MAKE_ITEM_XDRACO_LIMIT_PACKAGE
{
    [ProtoMember(1)]

    public int result { get; set; }
    [ProtoMember(2)]
    public int[] make_result { get; set; }
    [ProtoMember(3)]
    public _cost_info[] costInfo { get; set; }
    [ProtoMember(4)]
    public _stack_item_info[] update_stack_items { get; set; }
    [ProtoMember(5)]
    public _character_inven_item[] update_items { get; set; }
    [ProtoMember(6)]
    public int makeitem_index { get; set; }
    [ProtoMember(7)]
    public int makeitem_count { get; set; }
    [ProtoMember(8)]
    public int make_count { get; set; }

}

[ProtoContract]
public class CLIENT_GAME_REFINE_ITEM
{
    [ProtoMember(1)]

    public ulong refine_item_uid { get; set; }

}

[ProtoContract]
public class GAME_CLIENT_REFINE_ITEM
{
    [ProtoMember(1)]

    public uint result { get; set; }
    [ProtoMember(2)]
    public uint refine_result { get; set; }
    [ProtoMember(3)]
    public _cost_info[] costInfo { get; set; }
    [ProtoMember(4)]
    _character_inven_item refine_item { get; set; }
    [ProtoMember(5)]
    public _stack_item_info[] material_items { get; set; }

}

[ProtoContract]
public class GAME_CLIENT_ITEM_COLLECTION_PERIOD_END
{

}


[ProtoContract]
public class CLIENT_GAME_ITEM_STORAGE_LIST
{
}

[ProtoContract]
public class GAME_CLIENT_ITEM_STORAGE_LIST_START
{
    [ProtoMember(1)]

    public uint storage_size { get; set; }

}

[ProtoContract]
public class GAME_CLIENT_ITEM_STORAGE_LIST
{
    [ProtoMember(1)]

    public uint storage_size { get; set; }
    [ProtoMember(2)]
    public _character_inven_item[] storage_items { get; set; }

}

[ProtoContract]
public class GAME_CLIENT_ITEM_STORAGE_LIST_END
{
    [ProtoMember(1)]

    public uint storage_size { get; set; }
    [ProtoMember(2)]
    public ulong hold_random_option_item_uid { get; set; }

}

[ProtoContract]
public class CLIENT_GAME_ITEM_STORAGE_SAVE
{
    [ProtoMember(1)]

    _stack_item_info save_item { get; set; }

}

[ProtoContract]
public class GAME_CLIENT_ITEM_STORAGE_SAVE
{
    [ProtoMember(1)]

    _character_inven_item update_storage_item { get; set; }
    [ProtoMember(2)]
    _character_inven_item update_inven_item { get; set; }
    [ProtoMember(3)]
    public ulong delete_item_uid { get; set; }
    [ProtoMember(4)]
    public uint result { get; set; }

}

[ProtoContract]
public class CLIENT_GAME_ITEM_STORAGE_TAKE_OUT
{
    [ProtoMember(1)]

    _stack_item_info take_out_item { get; set; }

}

[ProtoContract]
public class GAME_CLIENT_ITEM_STORAGE_TAKE_OUT
{
    [ProtoMember(1)]

    _character_inven_item update_storage_item { get; set; }
    [ProtoMember(2)]
    _character_inven_item update_inven_item { get; set; }
    [ProtoMember(3)]
    public ulong delete_item_uid { get; set; }
    [ProtoMember(4)]
    public uint result { get; set; }

}

[ProtoContract]
public class CLIENT_GAME_ITEM_STORAGE_EXTEND
{
    [ProtoMember(1)]

    public uint extend_count { get; set; }

}

[ProtoContract]
public class GAME_CLIENT_ITEM_STORAGE_EXTEND
{
    [ProtoMember(1)]

    public uint result { get; set; }
    [ProtoMember(2)]
    public uint extend_count { get; set; }
    [ProtoMember(3)]
    public _cost_info[] costInfos { get; set; }
    [ProtoMember(4)]
    public uint storage_count { get; set; }

}

[ProtoContract]
public class CLIENT_SHOP_XDRACO_STORAGE_LIST
{

}

[ProtoContract]
public class SHOP_CLIENT_XDRACO_STORAGE_LIST_START
{
    [ProtoMember(1)]

    public uint storage_size { get; set; }

}

[ProtoContract]
public class SHOP_CLIENT_XDRACO_STORAGE_LIST
{
    [ProtoMember(1)]

    public uint storage_size { get; set; }
    [ProtoMember(2)]
    public _character_inven_item[] storage_items { get; set; }

}

[ProtoContract]
public class SHOP_CLIENT_XDRACO_STORAGE_LIST_END
{
    [ProtoMember(1)]

    public uint storage_size { get; set; }

}

[ProtoContract]
public class CLIENT_GAME_ITEM_XDRACO_STORAGE_SAVE
{
    [ProtoMember(1)]

    _stack_item_info save_item { get; set; }

}

[ProtoContract]
public class GAME_SHOP_ITEM_XDRACO_STORAGE_SAVE
{
    [ProtoMember(1)]

    public uint region_id { get; set; }
    [ProtoMember(2)]
    public uint world_id { get; set; }
    [ProtoMember(3)]
    public ulong account_uid { get; set; }
    [ProtoMember(4)]
    _character_inven_item update_storage_item { get; set; }
    [ProtoMember(5)]
    public _cost_info[] costInfos { get; set; }

}

[ProtoContract]
public class GAME_SHOP_ITEM_XDRACO_STORAGE_SAVE_PRE_CHECK
{
    [ProtoMember(1)]

    public uint result { get; set; }
    [ProtoMember(2)]
    public ulong try_item_uid { get; set; }

}

[ProtoContract]
public class SHOP_GAME_ITEM_XDRACO_STORAGE_SAVE_PRE_CHECK
{
    [ProtoMember(1)]

    public uint result { get; set; }
    [ProtoMember(2)]
    public uint seal_storage_size { get; set; }
    [ProtoMember(3)]
    public ulong try_item_uid { get; set; }
    [ProtoMember(4)]
    public _cost_info[] costInfos { get; set; }

}

[ProtoContract]
public class SHOP_GAME_ITEM_XDRACO_STORAGE_SAVE
{
    [ProtoMember(1)]

    public uint result { get; set; }
    [ProtoMember(2)]
    _character_inven_item update_storage_item { get; set; }

}

[ProtoContract]
public class GAME_CLIENT_ITEM_XDRACO_STORAGE_SAVE
{
    [ProtoMember(1)]

    _character_inven_item update_storage_item { get; set; }
    [ProtoMember(2)]
    _character_inven_item update_inven_item { get; set; }
    [ProtoMember(3)]
    public ulong delete_item_uid { get; set; }
    [ProtoMember(4)]
    public _cost_info[] costInfos { get; set; }
    [ProtoMember(5)]
    public uint result { get; set; }

}

[ProtoContract]
public class CLIENT_GAME_ITEM_XDRACO_STORAGE_TAKE_OUT
{
    [ProtoMember(1)]

    _stack_item_info take_out_item { get; set; }

}

[ProtoContract]
public class GAME_SHOP_ITEM_XDRACO_STORAGE_TAKE_OUT
{
    [ProtoMember(1)]

    public uint region_id { get; set; }
    [ProtoMember(2)]
    public uint world_id { get; set; }
    [ProtoMember(3)]
    public ulong account_uid { get; set; }
    [ProtoMember(4)]
    public ulong take_out_item_uid { get; set; }

}

[ProtoContract]
public class SHOP_GAME_ITEM_XDRACO_STORAGE_TAKE_OUT
{
    [ProtoMember(1)]

    public uint result { get; set; }
    [ProtoMember(2)]
    _character_inven_item update_storage_item { get; set; }

}

[ProtoContract]
public class GAME_CLIENT_ITEM_XDRACO_STORAGE_TAKE_OUT
{
    [ProtoMember(1)]

    _character_inven_item update_storage_item { get; set; }
    [ProtoMember(2)]
    _character_inven_item update_inven_item { get; set; }
    [ProtoMember(3)]
    public ulong delete_item_uid { get; set; }
    [ProtoMember(4)]
    public uint result { get; set; }

}

[ProtoContract]
public class SHOP_WORLD_DEBUG_CHAT_MSG
{
    [ProtoMember(1)]

    public ulong character_uid { get; set; }
    [ProtoMember(2)]
    public string msg { get; set; }

}

[ProtoContract]
public class WORLD_GAME_DEBUG_CHAT_MSG
{
    [ProtoMember(1)]

    public ulong character_uid { get; set; }
    [ProtoMember(2)]
    public string msg { get; set; }

}

[ProtoContract]
public class CLIENT_GAME_XDRACO_STORAGE_ITEM_LOCK_CHECK
{
    [ProtoMember(1)]

    public ulong character_uid { get; set; }

}

[ProtoContract]
public class GAME_CLIENT_XDRACO_STORAGE_ITEM_LOCK_CHECK
{
    [ProtoMember(1)]

    public int result { get; set; }

}

[ProtoContract]
public class GAME_SHOP_XDRACO_STORAGE_ITEM_LOCK_CHECK
{
    [ProtoMember(1)]

    public ulong character_uid { get; set; }

}

[ProtoContract]
public class SHOP_GAME_XDRACO_STORAGE_ITEM_LOCK_CHECK
{
    [ProtoMember(1)]

    public int result { get; set; }

}

[ProtoContract]
public class SHOP_WORLD_DSP_MAIL
{
    [ProtoMember(1)]

    public ulong character_uid { get; set; }
    [ProtoMember(2)]
    public uint item_id { get; set; }
    [ProtoMember(3)]
    public uint item_count { get; set; }
    [ProtoMember(4)]
    public uint region_id { get; set; }
    [ProtoMember(5)]
    public uint world_id { get; set; }
    [ProtoMember(6)]
    public uint mail_sub_type { get; set; }

}

[ProtoContract]
public class XDRACO_SHOP_LOCK_ITEM
{
    [ProtoMember(1)]

    public ulong account_uid { get; set; }
    [ProtoMember(2)]
    public ulong character_uid { get; set; }
    [ProtoMember(3)]
    public ulong item_uid { get; set; }
    [ProtoMember(4)]
    public bool is_lock { get; set; }
    [ProtoMember(5)]
    public uint item_idx { get; set; }

}

[ProtoContract]
public class XDRACO_SHOP_TRADE_RECEIVER_CHAR_ITEM
{
    [ProtoMember(1)]

    public ulong account_uid { get; set; }
    [ProtoMember(2)]
    public ulong character_uid { get; set; }
    [ProtoMember(3)]
    public ulong item_uid { get; set; }
    [ProtoMember(4)]
    public uint item_idx { get; set; }

}

[ProtoContract]
public class XDRACO_SHOP_TRADE_SENDER_CHAR_ITEM
{
    [ProtoMember(1)]

    public ulong account_uid { get; set; }
    [ProtoMember(2)]
    public ulong character_uid { get; set; }
    [ProtoMember(3)]
    public ulong item_uid { get; set; }
    [ProtoMember(4)]
    public uint item_idx { get; set; }

}

[ProtoContract]
public class XDRACO_SHOP_HOLDER_UPDOWN
{
    [ProtoMember(1)]

    public ulong account_uid { get; set; }
    [ProtoMember(2)]
    public ulong character_uid { get; set; }
    [ProtoMember(3)]
    public ulong item_uid { get; set; }
    [ProtoMember(4)]
    public bool is_upload { get; set; }
    [ProtoMember(5)]
    public uint item_idx { get; set; }

}

[ProtoContract]
public class XDRACO_SHOP_WEBINVEN_UPDOWN
{
    [ProtoMember(1)]

    public ulong account_uid { get; set; }
    [ProtoMember(2)]
    public ulong character_uid { get; set; }
    [ProtoMember(3)]
    public ulong item_uid { get; set; }
    [ProtoMember(4)]
    public bool is_upload { get; set; }
    [ProtoMember(5)]
    public uint item_idx { get; set; }

}


[ProtoContract]
public class CLIENT_GAME_AUTH
{
    [ProtoMember(1)]

    public ulong account_uid { get; set; }
    [ProtoMember(2)]
    public string strID { get; set; }
    [ProtoMember(3)]
    public string strSDK { get; set; }
    [ProtoMember(4)]
    public string auth_key { get; set; }

}

[ProtoContract]
public class GAME_CLIENT_AUTH
{
    [ProtoMember(1)]

    public int result { get; set; }
    [ProtoMember(2)]
    public int cash { get; set; }
    [ProtoMember(3)]
    public int time_region { get; set; }

}

[ProtoContract]
public class CLIENT_GAME_TIME
{

}

[ProtoContract]
public class GAME_CLIENT_TIME
{
    [ProtoMember(1)]

    public int time { get; set; }
    [ProtoMember(2)]
    public long time_ms { get; set; }
    [ProtoMember(3)]
    public long time_zone { get; set; }

}

[ProtoContract]
public class CLIENT_LOBBY_CHARACTER_LIST_ALL
{
    [ProtoMember(1)]

    public ulong account_uid { get; set; }

}

[ProtoContract]
public class CLIENT_LOBBY_CHARACTER_LIST_ALL_GLOBAL
{
    [ProtoMember(1)]

    public ulong account_uid { get; set; }

}

[ProtoContract]
public class LOBBY_CLIENT_CHARACTER_LIST_ALL
{
    [ProtoMember(1)]

    public _characterInfo_login[] characterInfo_login { get; set; }
    [ProtoMember(2)]
    public long server_current_time { get; set; }
    [ProtoMember(3)]
    public int voice_download_state { get; set; }
    [ProtoMember(4)]
    public string wemix_user_address { get; set; }

}

[ProtoContract]
public class LOBBY_CLIENT_CHARACTER_LIST_ALL_GLOBAL
{
    [ProtoMember(1)]

    public _characterInfo_login_global characterInfo_login { get; set; }
    [ProtoMember(2)]
    public long server_current_time { get; set; }
    [ProtoMember(3)]
    public int voice_download_state { get; set; }
    [ProtoMember(4)]
    public string wemix_user_address { get; set; }

}

[ProtoContract]
public class MACRO_LUA_CHARACTER_INFO
{
    [ProtoMember(1)]

    _characterInfo_login characterInfo_login { get; set; }
    [ProtoMember(2)]
    public long server_current_time { get; set; }

}

[ProtoContract]
public class MACRO_LUA_COMMAND
{
    [ProtoMember(1)]

    public string content { get; set; }

}

[ProtoContract]
public class MACRO_LUA_START
{
    [ProtoMember(1)]

    public string init_action { get; set; }
    [ProtoMember(2)]
    public string[] parameters { get; set; }

}

[ProtoContract]
public class CLIENT_LOBBY_CREATE_CHARACTER
{
    [ProtoMember(1)]

    public ulong account_uid { get; set; }
    [ProtoMember(2)]
    public int classId { get; set; }
    [ProtoMember(3)]
    public string nickName { get; set; }
    [ProtoMember(4)]
    public int hair_color_index { get; set; }
    [ProtoMember(5)]
    public int clothes_color_index { get; set; }
    [ProtoMember(6)]
    public customize_info[] customize_list { get; set; }
    [ProtoMember(7)]
    public _costume_info costume_info { get; set; }

}

[ProtoContract]
public class LOBBY_CLIENT_CREATE_CHARACTER
{
    [ProtoMember(1)]

    public int result { get; set; }
    [ProtoMember(2)]
    public int classId { get; set; }
    [ProtoMember(3)]
    public string nickName { get; set; }
    [ProtoMember(4)]
    public int stageindex { get; set; }
    [ProtoMember(5)]
    public int combatpoint { get; set; }
    [ProtoMember(6)]
    public int costume_id { get; set; }
    [ProtoMember(7)]
    public int hair_color_index { get; set; }
    [ProtoMember(8)]
    public int clothes_color_index { get; set; }
    [ProtoMember(9)]
    public ulong character_uid { get; set; }
    [ProtoMember(10)]
    public customize_info[] customize_list { get; set; }
    [ProtoMember(11)]
    public _costume_info costume_info { get; set; }

}

[ProtoContract]
public class CLIENT_LOBBY_CHARACTER_DELETE
{
    [ProtoMember(1)]

    public ulong account_uid { get; set; }
    [ProtoMember(2)]
    public ulong character_uid { get; set; }

}

[ProtoContract]
public class LOBBY_CLIENT_CHARACTER_DELETE
{
    [ProtoMember(1)]

    public ulong character_uid { get; set; }
    [ProtoMember(2)]
    public long del_time { get; set; }

}

[ProtoContract]
public class LOBBY_WORLD_CHARACTER_DELETE_CHECK
{
    [ProtoMember(1)]

    public ulong account_uid { get; set; }
    [ProtoMember(2)]
    public ulong character_uid { get; set; }

}

[ProtoContract]
public class WORLD_LOBBY_CHARACTER_DELETE_CHECK
{
    [ProtoMember(1)]

    public int result { get; set; }
    [ProtoMember(2)]
    public ulong account_uid { get; set; }
    [ProtoMember(3)]
    public ulong character_uid { get; set; }

}

[ProtoContract]
public class CLIENT_LOBBY_SELECT_CHARACTER
{
    [ProtoMember(1)]

    public ulong account_uid { get; set; }
    [ProtoMember(2)]
    public int classId { get; set; }
    [ProtoMember(3)]
    public ulong character_uid { get; set; }
    [ProtoMember(4)]
    public int store_type { get; set; }

}

[ProtoContract]
public class WORLD_CLIENT_SELECT_CHARACTER
{
    [ProtoMember(1)]

    public string gameserver_ip { get; set; }
    [ProtoMember(2)]
    public int gameserver_port { get; set; }
    [ProtoMember(3)]
    public ulong zone_unique { get; set; }
    [ProtoMember(4)]
    public ulong uid_um { get; set; }
    [ProtoMember(5)]
    public string auth_key { get; set; }

}

[ProtoContract]
public class WORLD_GATEWAY_CHARACTER_AUTH_KEY
{
    [ProtoMember(1)]

    public ulong character_uid { get; set; }
    [ProtoMember(2)]
    public string auth_key { get; set; }

}

[ProtoContract]
public class CLIENT_LOBBY_CHARACTER_DELETE_CANCEL
{
    [ProtoMember(1)]

    public ulong account_uid { get; set; }
    [ProtoMember(2)]
    public ulong character_uid { get; set; }

}

[ProtoContract]
public class LOBBY_CLIENT_CHARACTER_DELETE_CANCEL
{
    [ProtoMember(1)]

    public ulong character_uid { get; set; }

}

[ProtoContract]
public class CLIENT_LOBBY_CHARACTER_CHANGE_CUSTOMIZE
{
    [ProtoMember(1)]

    public ulong character_uid { get; set; }
    [ProtoMember(2)]
    public customize_info[] customize_list { get; set; }

}

[ProtoContract]
public class LOBBY_CLIENT_CHARACTER_CHANGE_CUSTOMIZE
{
    [ProtoMember(1)]

    public int result { get; set; }
    [ProtoMember(2)]
    public ulong character_uid { get; set; }

}

[ProtoContract]
public class CLIENT_GAME_CHARACTER_EQUIP
{
    [ProtoMember(1)]

    public ulong uid { get; set; }

}

[ProtoContract]
public class GAME_CLIENT_CHARACTER_EQUIP
{
    [ProtoMember(1)]

    public _character_equip_item character_equip_items { get; set; }

}

[ProtoContract]
public class CLIENT_GAME_CHARACTER_INVEN
{
    [ProtoMember(1)]

    public ulong uid { get; set; }

}

[ProtoContract]
public class CLIENT_GAME_CHARACTER_MASTERY_DATA
{
    [ProtoMember(1)]

    public ulong uid { get; set; }

}

[ProtoContract]
public class GAME_CLIENT_CHARACTER_MASTERY_DATA
{
    [ProtoMember(1)]

    public _character_mastery_slot[] mastery_slot_list { get; set; }
    [ProtoMember(2)]
    public uint level_limit_grade { get; set; }

}

[ProtoContract]
public class _packet_s_characterInven
{
    [ProtoMember(1)]

    public _character_inven_item[] character_inven_items { get; set; }

}

[ProtoContract]
public class GAME_CLIENT_CHARACTER_INVEN_START
{
    [ProtoMember(1)]

    public int maxInvenCount { get; set; }
    [ProtoMember(2)]
    public int itemCount { get; set; }
    [ProtoMember(3)]
    public int useInvenCount { get; set; }

}

[ProtoContract]
public class GAME_CLIENT_CHARACTER_INVEN_DATA
{
    [ProtoMember(1)]

    public _character_inven_item[] character_inven_items { get; set; }

}

[ProtoContract]
public class GAME_CLIENT_CHARACTER_INVEN_END
{
}

[ProtoContract]
public class CLIENT_GAME_CHARACTER_QUEST
{
    [ProtoMember(1)]

    public ulong uid { get; set; }

}

[ProtoContract]
public class GAME_CLIENT_CHARACTER_QUEST
{
    [ProtoMember(1)]

    public _character_quest[] questinfos { get; set; }

}

[ProtoContract]
public class CLIENT_GAME_CHARACTER_SUB_QUEST
{
    [ProtoMember(1)]

    public ulong uid { get; set; }

}

[ProtoContract]
public class _repeat_quest_info
{
    [ProtoMember(1)]

    public int repeatquest_index { get; set; }
    [ProtoMember(2)]
    public int clear_count { get; set; }
    [ProtoMember(3)]
    public int clear_week_count { get; set; }

}

[ProtoContract]
public class _request_quest_info
{
    [ProtoMember(1)]

    public int quest_index { get; set; }
    [ProtoMember(2)]
    public int state { get; set; }
    [ProtoMember(3)]
    public int seq { get; set; }

}

[ProtoContract]
public class _cooperation_quest_info
{
    [ProtoMember(1)]

    public int quest_index { get; set; }
    [ProtoMember(2)]
    public int state { get; set; }
    [ProtoMember(3)]
    public int clear_count { get; set; }
    [ProtoMember(4)]
    public int week_clear_count { get; set; }
    [ProtoMember(5)]
    public uint update_time { get; set; }

}

[ProtoContract]
public class GAME_CLIENT_CHARACTER_SUB_QUEST
{
    [ProtoMember(1)]

    public int[] end_subquest_indexs { get; set; }
    [ProtoMember(2)]
    public int[] subquest_indexs { get; set; }
    [ProtoMember(3)]
    public _character_quest[] active_questinfos { get; set; }
    [ProtoMember(4)]
    public _repeat_quest_info repeat_quest_infos { get; set; }
    [ProtoMember(5)]
    public _request_quest_info request_quest_infos { get; set; }
    [ProtoMember(6)]
    public int[] end_reqquest_indexs { get; set; }
    [ProtoMember(7)]
    public _cooperation_quest_info cooperation_quest_infos { get; set; }
    [ProtoMember(8)]
    public int[] end_coopquest_indexs { get; set; }

}

[ProtoContract]
public class GAME_CLIENT_CHARACTER_SUB_REPEAT_QUEST
{
    [ProtoMember(1)]

    public _repeat_quest_info repeat_quest_infos { get; set; }
    [ProtoMember(2)]
    public int[] subquest_indexs { get; set; }
    [ProtoMember(3)]
    public _character_quest[] active_questinfos { get; set; }
    [ProtoMember(4)]
    public int reset_period { get; set; }

}

[ProtoContract]
public class CLIENT_GAME_QUEST_RELATION_DATA
{
    [ProtoMember(1)]

    public ulong uid { get; set; }

}

[ProtoContract]
public class _relation_quest_info
{
    [ProtoMember(1)]

    public int index { get; set; }
    [ProtoMember(2)]
    public int state { get; set; }
    [ProtoMember(3)]
    public int count { get; set; }
    [ProtoMember(4)]
    public uint updatetime { get; set; }

}

[ProtoContract]
public class _relation_reward_quest_info
{
    [ProtoMember(1)]

    public int episode_index { get; set; }
}

[ProtoContract]
public class GAME_CLIENT_QUEST_RELATION_DATA
{
    [ProtoMember(1)]

    public _relation_quest_info[] relation_quest_infos { get; set; }
    [ProtoMember(2)]
    public int[] end_releation_indexs { get; set; }
    [ProtoMember(3)]
    public _relation_reward_quest_info[] relation_reward_quest_infos { get; set; }

}

[ProtoContract]
public class CLIENT_GAME_GUILD_DAILY_MISSION_DATA
{
    [ProtoMember(1)]

    public ulong uid { get; set; }

}

[ProtoContract]
public class _guild_daily_mission_info
{
    [ProtoMember(1)]

    public int index { get; set; }
    [ProtoMember(2)]
    public int state { get; set; }
    [ProtoMember(3)]
    public int count { get; set; }
    [ProtoMember(4)]
    public int clearcnt { get; set; }

}

[ProtoContract]
public class GAME_CLIENT_GUILD_DAILY_MISSION_DATA
{
    [ProtoMember(1)]

    public _guild_daily_mission_info[] guild_daily_mission_infos { get; set; }

}

[ProtoContract]
public class CLIENT_GAME_CHARACTER_SKILL
{
    [ProtoMember(1)]

    public ulong uid { get; set; }

}

[ProtoContract]
public class GAME_CLIENT_CHARACTER_SKILL
{
    [ProtoMember(1)]

    public _character_skill[] skillinfos { get; set; }

}

[ProtoContract]
public class CLIENT_GAME_CHARACTER_SKILL_DECK_SLOT_DATA
{
    [ProtoMember(1)]

    public ulong uid { get; set; }

}

[ProtoContract]
public class GAME_CLIENT_CHARACTER_SKILL_DECK_SLOT_DATA
{
    [ProtoMember(1)]

    public _character_skill_deck[] deck_list { get; set; }
    [ProtoMember(2)]
    public int current_deck_id { get; set; }

}

[ProtoContract]
public class CLIENT_GAME_CHARACTER_ENERGY_POINT_DATA
{
    [ProtoMember(1)]

    public ulong uid { get; set; }

}

[ProtoContract]
public class GAME_CLIENT_CHARACTER_ENERGY_POINT_DATA
{
    [ProtoMember(1)]

    public int energyPoint { get; set; }

}

[ProtoContract]
public class CLIENT_GAME_CHARACTER_ACHIEVEMENT_EXP_DATA
{
    [ProtoMember(1)]

    public ulong uid { get; set; }

}

[ProtoContract]
public class GAME_CLIENT_CHARACTER_ACHIEVEMENT_EXP_DATA
{
    [ProtoMember(1)]

    public ulong uid { get; set; }
    [ProtoMember(2)]
    public ulong achievement_exp { get; set; }

}

[ProtoContract]
public class CLIENT_GAME_CHARACTER_PLAY_DATA
{
    [ProtoMember(1)]

    public ulong uid { get; set; }

}

[ProtoContract]
public class GAME_CLIENT_CHARACTER_PLAY_DATA
{
    [ProtoMember(1)]

    public _character_play_data_info[] character_play_data_list { get; set; }

}

[ProtoContract]
public class CLIENT_GAME_CHARACTER_ACHIEVEMENT_CLEAR_DATA
{
    [ProtoMember(1)]

    public ulong uid { get; set; }

}

[ProtoContract]
public class GAME_CLIENT_CHARACTER_ACHIEVEMENT_CLEAR_DATA
{
    [ProtoMember(1)]
    public _character_achievement_complete_info[] character_achievement_complete_list { get; set; }

}

[ProtoContract]
public class CLIENT_GAME_QUEST_DAILY_DATA
{
    [ProtoMember(1)]

    public ulong uid { get; set; }

}

[ProtoContract]
public class GAME_CLIENT_QUEST_DAILY_DATA
{
    [ProtoMember(1)]

    _character_quest_daily_info daily_info { get; set; }
    [ProtoMember(2)]
    public _character_quest_daily_list_info[] daily_list { get; set; }
    [ProtoMember(3)]
    public _character_quest_daily_reward_list_info[] daily_reward_list { get; set; }

}

[ProtoContract]
public class GAME_CLIENT_CHARACTER_DAILY_HOMEWORK
{
    [ProtoMember(1)]

    public _character_quest[] questinfos { get; set; }
    [ProtoMember(2)]
    public int plusreward { get; set; }
    [ProtoMember(3)]
    public int[] complete_plusreward { get; set; }

}

[ProtoContract]
public class CLIENT_GAME_EQUIP_COSTUME_NEW
    {
    [ProtoMember(1)]

    public ulong user_uid { get; set; }
    [ProtoMember(2)]
    public uint costume_index { get; set; }
}

[ProtoContract]
public class CLIENT_GAME_COSTUME_LIST
{

}

[ProtoContract]
public class GAME_CLIENT_COSTUME_LIST
{
    [ProtoMember(1)]

    public _costume_info[] costume_list { get; set; }
    [ProtoMember(2)]
    public _equip_costume_info[] equip_costume_list { get; set; }
    [ProtoMember(3)]
    public _costume_hide_info[] costume_hide_list { get; set; }

}

[ProtoContract]
public class CLIENT_GAME_LUXURY_COSTUME_LIST
{
}

[ProtoContract]
public class GAME_CLIENT_LUXURY_COSTUME_LIST
{
    [ProtoMember(1)]

    public _equip_luxury_costume_info[] equip_list { get; set; }
    [ProtoMember(2)]
    public _luxury_costume_hide_info[] hide_list { get; set; }

}

[ProtoContract]
public class CLIENT_GAME_LIST_COSTUME
{
    [ProtoMember(1)]

    public ulong uid { get; set; }

}

[ProtoContract]
public class GAME_CLIENT_LIST_COSTUME
{
    [ProtoMember(1)]

    public int _equip_costume_id { get; set; }
    [ProtoMember(2)]
    public _costume_info[] costume_infos { get; set; }

}

[ProtoContract]
public class CLIENT_GAME_VEHICLE_LIST
{
}

[ProtoContract]
public class GAME_CLIENT_VEHICLE_LIST
{
    [ProtoMember(1)]

    public int equip_vehicle_index { get; set; }
    [ProtoMember(2)]
    public int[] vehicle_index_list { get; set; }

}

[ProtoContract]
public class CLIENT_GAME_TUTORIAL_CLEAR_LIST
{
    [ProtoMember(1)]

    public ulong uid { get; set; }

}

[ProtoContract]
public class GAME_CLIENT_TUTORIAL_CLEAR_LIST
{
    [ProtoMember(1)]

    public uint[] tutorial_group_index_list { get; set; }

}

[ProtoContract]
public class CLIENT_GAME_CHARACTER_MAP_WAYPOINT_DATA
{
    [ProtoMember(1)]

    public ulong uid { get; set; }

}

[ProtoContract]
public class GAME_CLIENT_CHARACTER_MAP_WAYPOINT_DATA
{
    [ProtoMember(1)]

    public int[] map_waypoint_id_list { get; set; }

}

[ProtoContract]
public class CLIENT_GAME_CHARACTER_TREASURE_DATA
{
    [ProtoMember(1)]

    public ulong uid { get; set; }

}

[ProtoContract]
public class GAME_CLIENT_CHARACTER_TREASURE_DATA
{
    [ProtoMember(1)]

    public _treasure_open_info[] treasure_open_list { get; set; }

}

[ProtoContract]
public class CLIENT_GAME_CHARACTER_HOLY_STUFF_DATA
{
    [ProtoMember(1)]

    public ulong uid { get; set; }

}

[ProtoContract]
public class GAME_CLIENT_CHARACTER_HOLY_STUFF_DATA
{
    [ProtoMember(1)]

    public _holy_stuff_info[] holy_stuff_list { get; set; }

}

[ProtoContract]
public class CLIENT_GAME_LOGIN
{
    [ProtoMember(1)]

    public ulong uid { get; set; }
    [ProtoMember(2)]
    public int os_type { get; set; }

}

[ProtoContract]
public class GAME_CLIENT_LOGIN
{
    [ProtoMember(1)]

    public int result { get; set; }

}

[ProtoContract]
public class LOGIN_WORLD_AUTH
{
    [ProtoMember(1)]

    public ulong account_uid { get; set; }
    [ProtoMember(2)]
    public uint socket_index { get; set; }

}

[ProtoContract]
public class WORLD_LOGIN_AUTH
{
    [ProtoMember(1)]

    public ulong account_uid { get; set; }
    [ProtoMember(2)]
    public uint socket_index { get; set; }
    [ProtoMember(3)]
    public uint error { get; set; }

}

[ProtoContract]
public class LOBBY_WORLD_SELECT_CHARACTER
{
    [ProtoMember(1)]

    public ulong account_uid { get; set; }
    [ProtoMember(2)]
    public ulong character_uid { get; set; }
    [ProtoMember(3)]
    public int proxy_server_type { get; set; }
    [ProtoMember(4)]
    public int proxy_server_index { get; set; }
    [ProtoMember(5)]
    public uint proxy_connected_session_index { get; set; }
    [ProtoMember(6)]
    public string user_ip { get; set; }
    [ProtoMember(7)]
    public uint trans_server { get; set; }
    [ProtoMember(8)]
    public int store_type { get; set; }
    [ProtoMember(9)]
    public int classId { get; set; }

}

[ProtoContract]
public class WORLD_LOBBY_SELECT_CHARACTER
{
    [ProtoMember(1)]

    public ulong account_uid { get; set; }
    [ProtoMember(2)]
    public uint socket_index { get; set; }
    [ProtoMember(3)]
    public string gameserver_ip { get; set; }
    [ProtoMember(4)]
    public int gameserver_port { get; set; }
    [ProtoMember(5)]
    public ulong zone_unique { get; set; }
    [ProtoMember(6)]
    public ulong uid_um { get; set; }
    [ProtoMember(7)]
    public uint error { get; set; }
    [ProtoMember(8)]
    public uint user_count { get; set; }

}

[ProtoContract]
public class LOBBY_WORLD_FORCED_DISCONNECT_USER
{
    [ProtoMember(1)]

    public ulong user_uid { get; set; }

}

[ProtoContract]
public class _packet_world_game_forced_disconnect_user_session
{
    [ProtoMember(1)]

    public ulong user_uid { get; set; }

}

[ProtoContract]
public class _packet_game_world_forced_logout_user
{
    [ProtoMember(1)]

    public ulong user_uid { get; set; }
    [ProtoMember(2)]
    public bool init_auth_key { get; set; }

}

[ProtoContract]
public class GAME_WORLD_NEW_LOGOUT_USER
{
    [ProtoMember(1)]

    public ulong user_uid { get; set; }
    [ProtoMember(2)]
    public bool init_auth_key { get; set; }
    [ProtoMember(3)]
    public int reason { get; set; }

}

[ProtoContract]
public class WORLD_GAME_RELOGIN_READY
{
    [ProtoMember(1)]

    public ulong user_uid { get; set; }
    [ProtoMember(2)]
    public int proxy_server_type { get; set; }
    [ProtoMember(3)]
    public uint proxy_server_index { get; set; }
    [ProtoMember(4)]
    public uint proxy_connected_session_id { get; set; }
    [ProtoMember(5)]
    public string user_ip { get; set; }

}

[ProtoContract]
public class GAME_WORLD_RELOGIN_READY_RESULT
{
    [ProtoMember(1)]

    public ulong user_uid { get; set; }

}

[ProtoContract]
public class CLIENT_GAME_REQUEST_RECONNECT
{
    [ProtoMember(1)]

    public ulong reconnect_user_uid { get; set; }
    [ProtoMember(2)]
    public string auth_key { get; set; }

}

[ProtoContract]
public class _packet_game_world_request_reconnect
{
    [ProtoMember(1)]

    public ulong reconnect_user_uid { get; set; }
    [ProtoMember(2)]
    public int reconnect_session_index { get; set; }

}

[ProtoContract]
public class _packet_world_game_reconnect_result
{
    [ProtoMember(1)]

    public ulong reconnect_user_uid { get; set; }
    [ProtoMember(2)]
    public int reconnect_session_index { get; set; }
    [ProtoMember(3)]
    public int error_id { get; set; }

}

[ProtoContract]
public class GAME_CLIENT_RECONNECT_RESULT
{
    [ProtoMember(1)]

    public ulong reconnect_user_uid { get; set; }
    [ProtoMember(2)]
    public int error_id { get; set; }

}

[ProtoContract]
public class _packet_game_world_request_reconnect_complete
{
    [ProtoMember(1)]

    public ulong reconnect_user_uid { get; set; }

}

[ProtoContract]
public class _packet_world_game_reconnect_complete
{
    [ProtoMember(1)]

    public ulong reconnect_user_uid { get; set; }

}

[ProtoContract]
public class GAME_CLIENT_RECONNECT_COMPLETE
{
    [ProtoMember(1)]

    public ulong reconnect_user_uid { get; set; }

}

[ProtoContract]
public class GATEWAY_LOBBY_AUTH
{
    [ProtoMember(1)]

    public ulong account_uid { get; set; }
    [ProtoMember(2)]
    public string account_id { get; set; }
    [ProtoMember(3)]
    public uint proxy_server_index { get; set; }
    [ProtoMember(4)]
    public uint proxy_connected_session_id { get; set; }
    [ProtoMember(5)]
    public string user_ip { get; set; }

}

[ProtoContract]
public class LOBBY_GATEWAY_AUTH
{
    [ProtoMember(1)]

    public uint result { get; set; }
    [ProtoMember(2)]
    public ulong account_uid { get; set; }
    [ProtoMember(3)]
    public uint proxy_server_index { get; set; }
    [ProtoMember(4)]
    public uint proxy_connected_session_id { get; set; }

}

[ProtoContract]
public class LOBBY_WORLD_AUTH
{
    [ProtoMember(1)]

    public ulong account_uid { get; set; }
    [ProtoMember(2)]
    public int proxy_server_type { get; set; }
    [ProtoMember(3)]
    public uint proxy_server_index { get; set; }
    [ProtoMember(4)]
    public uint proxy_session_index { get; set; }

}

[ProtoContract]
public class WORLD_LOBBY_AUTH
{
    [ProtoMember(1)]

    public uint result { get; set; }
    [ProtoMember(2)]
    public ulong account_uid { get; set; }
    [ProtoMember(3)]
    public int proxy_server_type { get; set; }
    [ProtoMember(4)]
    public uint proxy_server_index { get; set; }
    [ProtoMember(5)]
    public uint proxy_session_index { get; set; }
    [ProtoMember(6)]
    public int os_type { get; set; }
    [ProtoMember(7)]
    public string auth_key { get; set; }

}

[ProtoContract]
public class WORLD_MANAGER_LOBBY_AUTH_RESULT
{
    [ProtoMember(1)]

    public ulong account_uid { get; set; }

}

[ProtoContract]
public class GATEWAY_LOBBY_DISCONNECT_LOGIN_USER
{
    [ProtoMember(1)]

    public ulong account_uid { get; set; }
    [ProtoMember(2)]
    public uint proxy_server_index { get; set; }
    [ProtoMember(3)]
    public uint proxy_server_session_index { get; set; }

}

[ProtoContract]
public class GATEWAY_WORLD_DISCONNECT_USER
{
    [ProtoMember(1)]

    public ulong user_uid { get; set; }
    [ProtoMember(2)]
    public bool close_reconnect { get; set; }
    [ProtoMember(3)]
    public string auth_key { get; set; }

}

[ProtoContract]
public class LOBBY_WORLD_DISCONNECT_LOGIN_USER
{
    [ProtoMember(1)]

    public ulong account_uid { get; set; }

}

[ProtoContract]
public class GATEWAY_WORLD_REQUEST_RECONNECT_USER
{
    [ProtoMember(1)]

    public ulong reconnect_user_uid { get; set; }
    [ProtoMember(2)]
    public int proxy_server_index { get; set; }
    [ProtoMember(3)]
    public int client_connected_session_index { get; set; }
    [ProtoMember(4)]
    public string auth_key { get; set; }

}

[ProtoContract]
public class WORLD_GAME_REQUEST_RECONNECT_USER
{
    [ProtoMember(1)]

    public ulong reconnect_user_uid { get; set; }
    [ProtoMember(2)]
    public int proxy_server_type { get; set; }
    [ProtoMember(3)]
    public int proxy_server_index { get; set; }
    [ProtoMember(4)]
    public int client_connected_session_index { get; set; }

}

[ProtoContract]
public class GAME_WORLD_RECONNECT_USER_RESULT
{
    [ProtoMember(1)]

    public uint result { get; set; }
    [ProtoMember(2)]
    public ulong reconnect_user_uid { get; set; }
    [ProtoMember(3)]
    public int proxy_server_type { get; set; }
    [ProtoMember(4)]
    public int proxy_server_index { get; set; }
    [ProtoMember(5)]
    public int client_connected_session_index { get; set; }

}

[ProtoContract]
public class WORLD_GATEWAY_RECONNECT_USER_RESULT
{
    [ProtoMember(1)]

    public uint result { get; set; }
    [ProtoMember(2)]
    public ulong reconnect_user_uid { get; set; }
    [ProtoMember(3)]
    public ulong zone_unique { get; set; }
    [ProtoMember(4)]
    public int zonegroup_index { get; set; }
    [ProtoMember(5)]
    public int gameserver_index { get; set; }
    [ProtoMember(6)]
    public int gameserver_zonegroup_index { get; set; }
    [ProtoMember(7)]
    public uint cur_stage_index { get; set; }
    [ProtoMember(8)]
    public int client_connected_session_index { get; set; }
    [ProtoMember(9)]
    public string auth_key { get; set; }
    [ProtoMember(10)]
    public int account_grade { get; set; }
    [ProtoMember(11)]
    public int store_type { get; set; }

}

[ProtoContract]
public class WORLD_GAME_RECONNECT_USER_COMPLETE
{
    [ProtoMember(1)]

    public ulong reconnect_user_uid { get; set; }

}

[ProtoContract]
public class GATEWAY_WORLD_RECONNECT_USER_COMPLETE
{
    [ProtoMember(1)]

    public ulong reconnect_user_uid { get; set; }

}

[ProtoContract]
public class WORLD_LOBBY_LOGIN_ERROR
{
    [ProtoMember(1)]

    public ulong error_account_uid { get; set; }
    [ProtoMember(2)]
    public uint error_id { get; set; }

}

[ProtoContract]
public class LOBBY_WORLD_DELETE_CHARACTER
{
    [ProtoMember(1)]

    public ulong character_uid { get; set; }
    [ProtoMember(2)]
    public long delete_time { get; set; }

}

[ProtoContract]
public class LOBBY_WORLD_CHARACTER_DELETE_CANCEL
{
    [ProtoMember(1)]

    public ulong character_uid { get; set; }

}

[ProtoContract]
public class CLIENT_GAME_CHARACTER_FORCE_DATA
{
}

[ProtoContract]
public class GAME_CLIENT_CHARACTER_FORCE_DATA
{
    [ProtoMember(1)]

    public _force_info force_info_list { get; set; }
    [ProtoMember(2)]
    public int slump_time { get; set; }

}

[ProtoContract]
public class CLIENT_GAME_CHARACTER_FORCE_BLOOD_DATA
{

}

[ProtoContract]
public class GAME_CLIENT_CHARACTER_FORCE_BLOOD_DATA
{
    [ProtoMember(1)]

    public _force_blood_info force_blood_info_list { get; set; }

}

[ProtoContract]
public class CLIENT_GAME_CHARACTER_POTENTIAL_DATA
{

}

[ProtoContract]
public class GAME_CLIENT_CHARACTER_POTENTIAL_DATA
{
    [ProtoMember(1)]

    public _potential_info potential_list { get; set; }

}

[ProtoContract]
public class CLIENT_GAME_CHARACTER_CUSTOM_TITLE_DATA
{

}

[ProtoContract]
public class GAME_CLIENT_CHARACTER_CUSTOM_TITLE_DATA
{
    [ProtoMember(1)]

    public string custom_title { get; set; }
    [ProtoMember(2)]
    public long custom_title_end_time { get; set; }
    [ProtoMember(3)]
    public bool is_custom_title_show { get; set; }

}

[ProtoContract]
public class CLIENT_GAME_CHARACTER_CUSTOMIZE_DATA
{

}

[ProtoContract]
public class GAME_CLIENT_CHARACTER_CUSTOMIZE_DATA
{
    [ProtoMember(1)]

    public customize_info[] customize_list { get; set; }

}

[ProtoContract]
public class CLIENT_GAME_CHARACTER_QUICKSLOT_DATA
{
    [ProtoMember(1)]

    public ulong uid { get; set; }

}

[ProtoContract]
public class _quickslot_info
{
    [ProtoMember(1)]

    public int slot_index { get; set; }
    [ProtoMember(2)]
    public int item_index { get; set; }

}

[ProtoContract]
public class GAME_CLIENT_CHARACTER_QUICKSLOT_DATA
{
    [ProtoMember(1)]

    public _quickslot_info slot_infos { get; set; }

}

[ProtoContract]
public class CLIENT_GAME_CHARACTER_MAKE_ITME_DATA
{
}

[ProtoContract]
public class GAME_CLIENT_CHARACTER_MAKE_ITME_DATA
{
    [ProtoMember(1)]

    public uint[] make_item_list { get; set; }

}

[ProtoContract]
public class CLIENT_GAME_CHARACTER_ITME_COLLECTION_DATA
{
}

[ProtoContract]
public class GAME_CLIENT_CHARACTER_ITME_COLLECTION_DATA
{
    [ProtoMember(1)]

    public bool is_end { get; set; }
    [ProtoMember(2)]
    public _item_collection_info collection_info_list { get; set; }

}

[ProtoContract]
public class CLIENT_GAME_CHARACTER_ITME_COLLECTION_COMPLATE_DATA
{
}

[ProtoContract]
public class GAME_CLIENT_CHARACTER_ITME_COLLECTION_COMPLATE_DATA
{
    [ProtoMember(1)]

    public bool is_end { get; set; }
    [ProtoMember(2)]
    public int[] complate_collection_id_list { get; set; }

}

[ProtoContract]
public class CLIENT_GAME_CHARACTER_EQUIP_MAGIC_STONE_DATA
{
}

[ProtoContract]
public class GAME_CLIENT_CHARACTER_EQUIP_MAGIC_STONE_DATA
{
    [ProtoMember(1)]

    public _character_equip_magic_stone_item[] list { get; set; }

}

[ProtoContract]
public class CLIENT_GAME_CHARACTER_EVENT_DATA
{
    [ProtoMember(1)]

    public ulong uid { get; set; }

}

[ProtoContract]
public class GAME_CLIENT_CHARACTER_EVENT_DATA
{
    [ProtoMember(1)]

    public _character_event_data_info character_event_data_list { get; set; }

}

[ProtoContract]
public class CLIENT_GAME_CHARACTER_BATTLE_PASS_CLEAR_DATA
{
    [ProtoMember(1)]

    public ulong uid { get; set; }

}

[ProtoContract]
public class GAME_CLIENT_CHARACTER_BATTLE_PASS_CLEAR_DATA
{
    [ProtoMember(1)]

    public _character_battle_pass_complete_info[] character_battle_pass_complete_list { get; set; }
    [ProtoMember(2)]
    public int order { get; set; }
    [ProtoMember(3)]
    public ulong character_battle_pass { get; set; }
    [ProtoMember(4)]
    public ulong mission_start_time { get; set; }
    [ProtoMember(5)]
    public ulong mission_end_time { get; set; }
    [ProtoMember(6)]
    public ulong character_battle_pass2 { get; set; }
    [ProtoMember(7)]
    public _character_battle_pass_date[] character_battle_pass_date_list { get; set; }

}

[ProtoContract]
public class CLIENT_GAME_CHARACTER_BATTLE_PASS_REWARD_DATA
{
    [ProtoMember(1)]

    public ulong uid { get; set; }

}

[ProtoContract]
public class GAME_CLIENT_CHARACTER_BATTLE_PASS_REWARD_DATA
{
    [ProtoMember(1)]

    public _character_battle_pass_reward_info character_battle_pass_reward_list { get; set; }

}

[ProtoContract]
public class CLIENT_GAME_CHARACTER_CASHBAG_DATA
{
    [ProtoMember(1)]

    public ulong uid { get; set; }

}

[ProtoContract]
public class GAME_CLIENT_CHARACTER_CASHBAG_DATA
{
    [ProtoMember(1)]

    public _character_cashbag_info[] cashbag_info { get; set; }
    [ProtoMember(2)]
    public bool is_end { get; set; }

}

[ProtoContract]
public class CLIENT_GAME_COST_DATA
{

}

[ProtoContract]
public class GAME_CLIENT_COST_DATA
{
    [ProtoMember(1)]

    public _cost_info[] user_cost_list { get; set; }
    [ProtoMember(2)]
    public _time_ticket_info[] time_ticket_list { get; set; }
    [ProtoMember(3)]
    public _cost_info[] guild_cost_list { get; set; }

}

[ProtoContract]
public class CLIENT_LOBBY_VOICE_DOWNLOAD_COMPLETE
{
    [ProtoMember(1)]

    public ulong account_uid { get; set; }

}

[ProtoContract]
public class CLIENT_GAME_CHARACTER_COMPOSE_POINT_DATA
{

}

[ProtoContract]
public class GAME_CLIENT_CHARACTER_COMPOSE_POINT_DATA
{
    [ProtoMember(1)]

    public _compose_fail_data[] compose_fail_info { get; set; }

}

[ProtoContract]
public class CLIENT_GAME_CHARACTER_PERIOD_GOODS_DATA
{

}

[ProtoContract]
public class GAME_CLIENT_CHARACTER_PERIOD_GOODS_DATA
{
    [ProtoMember(1)]

    public _period_goods_data[] period_goods_info { get; set; }

}

[ProtoContract]
public class GATEWAY_WORLD_AUTH
{
    [ProtoMember(1)]

    public string auth_key { get; set; }
    [ProtoMember(2)]
    public ulong account_uid { get; set; }
    [ProtoMember(3)]
    public string account_id { get; set; }
    [ProtoMember(4)]
    public uint proxy_server_index { get; set; }
    [ProtoMember(5)]
    public uint proxy_connected_session_id { get; set; }
    [ProtoMember(6)]
    public string user_ip { get; set; }

}

[ProtoContract]
public class WORLD_GATEWAY_AUTH
{
    [ProtoMember(1)]

    public bool auth_result { get; set; }
    [ProtoMember(2)]
    public ulong account_uid { get; set; }
    [ProtoMember(3)]
    public string account_id { get; set; }
    [ProtoMember(4)]
    public uint proxy_server_index { get; set; }
    [ProtoMember(5)]
    public uint proxy_connected_session_id { get; set; }
    [ProtoMember(6)]
    public string user_ip { get; set; }

}

[ProtoContract]
public class CLIENT_GAME_DATA_SEQUENTIAL_PACKET
{

}

[ProtoContract]
public class CLIENT_GAME_DATA_LOGIN_PARALLEL_PACKET
{
}

[ProtoContract]
public class GATEWAY_CLIENT_UNCHEATER_COOKIE
{
    [ProtoMember(1)]

    public byte[] cookie { get; set; }

}

[ProtoContract]
public class CLIENT_GATEWAY_UNCHEATER_RESPONSE
{
    [ProtoMember(1)]

    public byte[] cookie { get; set; }

}

[ProtoContract]
public class CLIENT_GAME_CHARACTER_EVENT_PASS_DATA
{
    [ProtoMember(1)]

    public ulong uid { get; set; }

}

[ProtoContract]
public class GAME_CLIENT_CHARACTER_EVENT_PASS_DATA
{
    [ProtoMember(1)]

    public _character_event_pass_data_info[] character_event_pass_data_list { get; set; }

}

[ProtoContract]
public class CLIENT_GAME_CHARACTER_EVENT_PASS_MISSION_CLEAR_DATA
{
    [ProtoMember(1)]

    public ulong uid { get; set; }

}

[ProtoContract]
public class GAME_CLIENT_CHARACTER_EVENT_PASS_MISSION_CLEAR_DATA
{
    [ProtoMember(1)]

    public _character_event_pass_mission_complete_info[] character_event_pass_complete_list { get; set; }
    [ProtoMember(2)]
    public int order { get; set; }
    [ProtoMember(3)]
    public ulong character_event_pass { get; set; }
    [ProtoMember(4)]
    public ulong mission_start_time { get; set; }
    [ProtoMember(5)]
    public ulong mission_end_time { get; set; }
    [ProtoMember(6)]
    public ulong character_event_pass2 { get; set; }
    [ProtoMember(7)]
    public _character_event_pass_date[] character_event_pass_date_list { get; set; }

}

[ProtoContract]
public class CLIENT_GAME_CHARACTER_EVENT_PASS_REWARD_DATA
{
    [ProtoMember(1)]

    public ulong uid { get; set; }

}

[ProtoContract]
public class GAME_CLIENT_CHARACTER_EVENT_PASS_REWARD_DATA
{
    [ProtoMember(1)]

    public _character_event_pass_reward_info[] character_event_pass_reward_list { get; set; }

}


[ProtoContract]
public class WORLD_GAME_REQUEST_DICONNECT_USER
{
    [ProtoMember(1)]

    public ulong uid { get; set; }
    [ProtoMember(2)]
    public uint error_id { get; set; }
    [ProtoMember(3)]
    public uint reason { get; set; }

}

[ProtoContract]
public class GAME_WORLD_CMD_LOGOUT_USER
{
    [ProtoMember(1)]

    public ulong uid { get; set; }

}

[ProtoContract]
public class WORLD_GATEWAY_REQUEST_DICONNECT_USER
{
    [ProtoMember(1)]

    public ulong uid { get; set; }
    [ProtoMember(2)]
    public uint error_id { get; set; }
    [ProtoMember(3)]
    public uint reason { get; set; }
    [ProtoMember(4)]
    public ulong account_uid { get; set; }
    [ProtoMember(5)]
    public string auth_key { get; set; }

}

[ProtoContract]
public class CLIENT_GAME_REQUEST_LOGOUT
{
    [ProtoMember(1)]

    public uint request_type { get; set; }

}

[ProtoContract]
public class GAME_CLIENT_SUCCESS_LOGOUT
{
    [ProtoMember(1)]

    public uint request_type { get; set; }

}

[ProtoContract]
public class GAME_CLIENT_LOGOUT_CANCEL
{
    [ProtoMember(1)]

    public uint cancel_reason { get; set; }

}

[ProtoContract]
public class GAME_WORLD_REQUEST_LOGOUT
{
    [ProtoMember(1)]

    public uint request_type { get; set; }

}

[ProtoContract]
public class WORLD_LOBBY_DICONNECT_USER
{
    [ProtoMember(1)]

    public int reason { get; set; }

}

[ProtoContract]
public class CLIENT_WORLD_MACHING_REQ
{
    [ProtoMember(1)]

    public ulong uid { get; set; }
    [ProtoMember(2)]
    public uint raid_index { get; set; }

}


[ProtoContract]
public class GAME_MACRO_USER_CHANGE_MACRO
{
    [ProtoMember(1)]

    public ulong account_uid { get; set; }
    [ProtoMember(2)]
    public ulong character_uid { get; set; }
    [ProtoMember(3)]
    public uint action_state { get; set; }
    [ProtoMember(4)]
    public ulong target_uid { get; set; }
    [ProtoMember(5)]
    public int target_object_id { get; set; }

}

[ProtoContract]
public class MACRO_GAME_PASSIVE_SKILL_LIST
{
    [ProtoMember(1)]

    public ulong character_uid { get; set; }

}

[ProtoContract]
public class GAME_MACRO_PASSIVE_SKILL_LIST
{
    [ProtoMember(1)]

    public ulong character_uid { get; set; }
    [ProtoMember(2)]
    public _passive_skill_info[] passive_list { get; set; }

}

[ProtoContract]
public class GAME_MACRO_COMMAND
{
    [ProtoMember(1)]

    public ulong account_uid { get; set; }
    [ProtoMember(2)]
    public ulong character_uid { get; set; }
    [ProtoMember(3)]
    public uint stage_id { get; set; }
    [ProtoMember(4)]
    public _vector3 loc { get; set; }
    [ProtoMember(5)]
    public string[] command_list { get; set; }

}

[ProtoContract]
public class MACRO_LOBBY_CREATE_COPY
{
    [ProtoMember(1)]

    public ulong account_uid { get; set; }
    [ProtoMember(2)]
    public string target_char_name { get; set; }
    [ProtoMember(3)]
    public string new_char_name { get; set; }

}

[ProtoContract]
public class GAME_MACRO_MONSTER_KILL_INFO
{
    [ProtoMember(1)]

    public int monster_tid { get; set; }

}

[ProtoContract]
public class MACRO_LUA_MAS_STATUS
{
    [ProtoMember(1)]

    public uint world_id { get; set; }
    [ProtoMember(2)]
    public uint server_index { get; set; }
    [ProtoMember(3)]
    public long last_tick_time { get; set; }
    [ProtoMember(4)]
    public uint user_count { get; set; }

}

[ProtoContract]
public class MACRO_LUA_DISCONNECT_USER
{
    [ProtoMember(1)]

    public uint reason { get; set; }

}

[ProtoContract]
public class GAME_MACRO_ADD_USER
{
    [ProtoMember(1)]

    public ulong character_uid { get; set; }
    [ProtoMember(2)]
    public int gameserver_index { get; set; }
    [ProtoMember(3)]
    public int gameserver_zonegroup_index { get; set; }
    [ProtoMember(4)]
    public string init_action { get; set; }
    [ProtoMember(5)]
    public string[] parameters { get; set; }

}

[ProtoContract]
public class GAME_CLIENT_TRY_CHANGE_MACRO
{
    [ProtoMember(1)]

    public int result { get; set; }

}

[ProtoContract]
public class GATEWAY_WORLD_USER_CHANGE_MACRO
{
    [ProtoMember(1)]

    public ulong uid { get; set; }

}

[ProtoContract]
public class WORLD_MACRO_DISCONNECT_USER
{
    [ProtoMember(1)]

    public int reason { get; set; }
    [ProtoMember(2)]
    public ulong account_uid { get; set; }
    [ProtoMember(3)]
    public ulong character_uid { get; set; }
    [ProtoMember(4)]
    public ulong zone_unique { get; set; }
    [ProtoMember(5)]
    public uint enter_server_index { get; set; }

}

[ProtoContract]
public class MACRO_WORLD_DISCONNECT_USER_RESULT
{
    [ProtoMember(1)]

    public int result { get; set; }
    [ProtoMember(2)]
    public ulong account_uid { get; set; }

}

[ProtoContract]
public class WORLD_MACRO_CONNECT_USER
{
    [ProtoMember(1)]

    public int reason { get; set; }
    [ProtoMember(2)]
    public ulong account_uid { get; set; }
    [ProtoMember(3)]
    public ulong character_uid { get; set; }
    [ProtoMember(4)]
    public ulong zone_unique { get; set; }
    [ProtoMember(5)]
    public uint leave_server_index { get; set; }
    [ProtoMember(6)]
    public uint class_id { get; set; }
    [ProtoMember(7)]
    public string nickname { get; set; }

}

[ProtoContract]
public class MACRO_WORLD_CONNECT_USER_RESULT
{
    [ProtoMember(1)]

    public int result { get; set; }
    [ProtoMember(2)]
    public ulong account_uid { get; set; }

}

[ProtoContract]
public class MACRO_GAME_WARP_READY
{
    [ProtoMember(1)]

    public ulong warp_user_uid { get; set; }
    [ProtoMember(2)]
    public ulong warp_zone_unique { get; set; }
    [ProtoMember(3)]
    public int warp_zonegroup_index { get; set; }
    [ProtoMember(4)]
    warp_info warp_info { get; set; }
    [ProtoMember(5)]
    _characterInfo char_info { get; set; }
    [ProtoMember(6)]
    public int gameserver_index { get; set; }
    [ProtoMember(7)]
    public int gameserver_zonegroup_index { get; set; }
    [ProtoMember(8)]
    public int gatewayserver_index { get; set; }
    [ProtoMember(9)]
    public ulong depature_zone_uid { get; set; }

}

[ProtoContract]
public class GAME_MACRO_WARP_READY
{
    [ProtoMember(1)]

    public ulong warp_user_uid { get; set; }
    [ProtoMember(2)]
    public ulong warp_zone_unique { get; set; }
    [ProtoMember(3)]
    public int warp_zonegroup_index { get; set; }
    [ProtoMember(4)]
    warp_info warp_info { get; set; }
    [ProtoMember(5)]
    _characterInfo char_info { get; set; }
    [ProtoMember(6)]
    public int gameserver_index { get; set; }
    [ProtoMember(7)]
    public int gameserver_zonegroup_index { get; set; }
    [ProtoMember(8)]
    public int gatewayserver_index { get; set; }
    [ProtoMember(9)]
    public ulong depature_zone_uid { get; set; }

}


[ProtoContract]
public class CLIENT_GAME_CHANGE_ROOM_IN_MAGIC_SQUARE
{

}

[ProtoContract]
public class GAME_WORLD_CHANGE_ROOM_IN_MAGIC_SQUARE
{
    [ProtoMember(1)]

    public uint magic_square_id { get; set; }
    [ProtoMember(2)]
    public uint location_id { get; set; }

}

[ProtoContract]
public class CLIENT_GAME_LEAVE_MAGIC_SQUARE
{
}

[ProtoContract]
public class GAME_WORLD_LEAVE_MAGIC_SQUARE
{
    [ProtoMember(1)]

    public uint cur_zone_unique { get; set; }

}

[ProtoContract]
public class CLIENT_GAME_ENTER_MAGIC_SQUARE
{
    [ProtoMember(1)]

    public uint magic_square_id { get; set; }

}

[ProtoContract]
public class GAME_WORLD_ENTER_MAGIC_SQUARE
{
    [ProtoMember(1)]

    public uint magic_square_id { get; set; }
    [ProtoMember(2)]
    public uint enter_location_id { get; set; }

}

[ProtoContract]
public class GAME_WORLD_REQUEST_MAGIC_SQURE_EXIT_TIME
{
}

[ProtoContract]
public class WORLD_GAME_NOTIFY_MAGIC_SQUARE_EXIT_TIME
{
    [ProtoMember(1)]

    public ulong request_user_uid { get; set; }
    [ProtoMember(2)]
    public ulong exit_time { get; set; }

}

[ProtoContract]
public class GAME_CLIENT_MAGIC_SQUARE_TIME
{
    [ProtoMember(1)]

    public ulong exit_time { get; set; }
    [ProtoMember(2)]
    public ulong warp_available_time { get; set; }

}

[ProtoContract]
public class GAME_CLIENT_FAIL_MAGIC_SQUARE_ROOM_CHANGE
{
    [ProtoMember(1)]

    public uint fail_reason { get; set; }

}

[ProtoContract]
public class CLIENT_GAME_MAGIC_SQUARE_TIME_EXTEND
{
}

[ProtoContract]
public class GAME_CLIENT_MAGIC_SQUARE_TIME_EXTEND
{
    [ProtoMember(1)]

    public int result { get; set; }
    [ProtoMember(2)]
    public ulong exit_time { get; set; }
    [ProtoMember(3)]
    _dungeon_ticket_info dungeon_ticket_info { get; set; }

}

[ProtoContract]
public class GAME_WORLD_MAGIC_SQUARE_TIME_EXTEND
{

}

[ProtoContract]
public class WORLD_GAME_MAGIC_SQUARE_TIME_EXTEND
{
    [ProtoMember(1)]

    public int result { get; set; }
    [ProtoMember(2)]
    public ulong user_uid { get; set; }
    [ProtoMember(3)]
    public ulong exit_time { get; set; }

}


[ProtoContract]
public class _packet_c_mail_recv_gift
{
    [ProtoMember(1)]

    public ulong uid { get; set; }
    [ProtoMember(2)]
    public ulong mail_uid { get; set; }

}

[ProtoContract]
public class GAME_CLIENT_MAIL_RECV_GIFT
{
    [ProtoMember(1)]

    public _cost_info[] gift_cost { get; set; }
    [ProtoMember(2)]
    public _simple_item_info[] gift_item { get; set; }
    [ProtoMember(3)]
    public _character_inven_item[] gift_fixitem { get; set; }
    [ProtoMember(4)]
    public _cost_info[] character_cost { get; set; }
    [ProtoMember(5)]
    public _character_inven_item[] inven_item { get; set; }
    [ProtoMember(6)]
    public ulong del_mail_uid { get; set; }

}

[ProtoContract]
public class _ranking_mail_user_data
{
    [ProtoMember(1)]

    public string nick_name { get; set; }
    [ProtoMember(2)]
    public uint contribution { get; set; }

}

[ProtoContract]
public class _ranking_reward
{
    [ProtoMember(1)]

    public _cost_info[] reward_costInfos { get; set; }
    [ProtoMember(2)]
    public _simple_item_info[] reward_simple_item_info { get; set; }

}

[ProtoContract]
public class CLIENT_GAME_MAIL_DEL
{
    [ProtoMember(1)]

    public ulong[] mail_uid { get; set; }

}

[ProtoContract]
public class GAME_CLIENT_MAIL_DEL
{
    [ProtoMember(1)]

    public uint result { get; set; }
    [ProtoMember(2)]
    public ulong[] del_mail_uid { get; set; }

}

[ProtoContract]
public class _packet_c_mail_del_all
{
    [ProtoMember(1)]

    public uint mail_type { get; set; }

}

[ProtoContract]
public class _packet_s_mail_del_all
{
    [ProtoMember(1)]

    public uint result { get; set; }

}

[ProtoContract]
public class _packet_c_mail_recv_gift_all
{
    [ProtoMember(1)]

    public ulong uid { get; set; }
    [ProtoMember(2)]
    public ulong start_mail_uid { get; set; }
    [ProtoMember(3)]
    public ulong end_mail_uid { get; set; }

}

[ProtoContract]
public class _packet_s_mail_recv_gift_all_start
{

}

[ProtoContract]
public class _packet_s_mail_recv_gift_all_end
{
}

[ProtoContract]
public class CLIENT_GAME_MAIL_LIST
{
}

[ProtoContract]
public class GAME_CLIENT_MAIL_LIST_DATA
{
    [ProtoMember(1)]

    public bool is_end { get; set; }
    [ProtoMember(2)]
    public _mail_data[] mail_info { get; set; }
    [ProtoMember(3)]
    public uint send_cost_type { get; set; }
    [ProtoMember(4)]
    public ulong send_cost_value { get; set; }
    [ProtoMember(5)]
    public bool is_start { get; set; }

}

[ProtoContract]
public class CLIENT_GAME_MAIL_RECV_GIFT
{
    [ProtoMember(1)]

    public ulong mail_uid { get; set; }

}

[ProtoContract]
public class CLIENT_GAME_MAIL_RECV_GIFT_ALL
{
    [ProtoMember(1)]

    public uint mail_type { get; set; }

}

[ProtoContract]
public class GAME_CLIENT_MAIL_RECV_GIFT_ALL_GIFT_INFO
{
    [ProtoMember(1)]

    public bool is_end { get; set; }
    [ProtoMember(2)]
    public _cost_info[] gift_cost { get; set; }
    [ProtoMember(3)]
    public _simple_item_info[] gift_item { get; set; }
    [ProtoMember(4)]
    public _character_inven_item[] gift_fixitem { get; set; }
    [ProtoMember(5)]
    public bool is_start { get; set; }
    [ProtoMember(6)]
    public uint mail_type { get; set; }

}

[ProtoContract]
public class GAME_CLIENT_MAIL_RECV_GIFT_ALL_UPDATE_INFO
{
    [ProtoMember(1)]

    public bool is_end { get; set; }
    [ProtoMember(2)]
    public _cost_info[] character_cost { get; set; }
    [ProtoMember(3)]
    public _character_inven_item[] inven_item { get; set; }
    [ProtoMember(4)]
    public uint mail_type { get; set; }

}

[ProtoContract]
public class CLIENT_GAME_MAIL_SEND
{
    [ProtoMember(1)]

    _send_mail_data send_mail { get; set; }

}

[ProtoContract]
public class GAME_CLIENT_MAIL_SEND
{
    [ProtoMember(1)]

    public uint result { get; set; }
    [ProtoMember(2)]
    _mail_data mail_data { get; set; }

}

[ProtoContract]
public class GAME_CLIENT_MAIL_NEW
{
    [ProtoMember(1)]

    public _mail_data mail_data { get; set; }

}

[ProtoContract]
public class GAME_WORLD_MAIL_NEW
{
    [ProtoMember(1)]

    public ulong user_uid { get; set; }
    [ProtoMember(2)]
    _mail_data mail_data { get; set; }

}

[ProtoContract]
public class WORLD_GAME_MAIL_NEW
{
    [ProtoMember(1)]

    public ulong user_uid { get; set; }
    [ProtoMember(2)]
    _mail_data mail_data { get; set; }

}

[ProtoContract]
public class CLIENT_GAME_MAIL_RECEIVE_NAME
{
    [ProtoMember(1)]

    public string receive_nick_name { get; set; }

}

[ProtoContract]
public class GAME_CLIENT_MAIL_RECEIVE_NAME
{
    [ProtoMember(1)]

    public uint result { get; set; }
    [ProtoMember(2)]
    public string receive_nick_name { get; set; }

}

[ProtoContract]
public class CLIENT_GAME_NTF_MAIL_READ
{
    [ProtoMember(1)]

    public ulong mail_uid { get; set; }
    [ProtoMember(2)]
    public uint mail_type { get; set; }

}

[ProtoContract]
public class WORLD_GAME_NEW_EVENT_MAIL
{
    [ProtoMember(1)]

    public uint event_id { get; set; }
    [ProtoMember(2)]
    public uint mail_preset_id { get; set; }
    [ProtoMember(3)]
    public string title { get; set; }
    [ProtoMember(4)]
    public string contents { get; set; }
    [ProtoMember(5)]
    public uint mail_type { get; set; }
    [ProtoMember(6)]
    public _reward_cost_info[] reward_costInfos { get; set; }
    [ProtoMember(7)]
    public _simple_item_info[] reward_simple_item_info { get; set; }
    [ProtoMember(8)]
    public ulong start_date { get; set; }
    [ProtoMember(9)]
    public ulong end_date { get; set; }

}

[ProtoContract]
public class CLIENT_GAME_MAIL_DELETE_ALL
{
    [ProtoMember(1)]

    public uint mail_type { get; set; }

}

[ProtoContract]
public class SERVER_SERVER_ACCOUNT_EVENT_NEW_MAIL
{
    [ProtoMember(1)]

    public int event_id { get; set; }

}

[ProtoContract]
public class _region_mail
{
    [ProtoMember(1)]

    public int event_id { get; set; }
    [ProtoMember(2)]
    public int preset_id { get; set; }
    [ProtoMember(3)]
    public string title { get; set; }
    [ProtoMember(4)]
    public string contents { get; set; }
    [ProtoMember(5)]
    public int event_state { get; set; }
    [ProtoMember(6)]
    public _region_mail[] reward_list { get; set; }
[ProtoMember(7)]
public long start_date { get; set; }
[ProtoMember(8)]
public long end_date { get; set; }
    
}

[ProtoContract]
public class _region_mail_reward
{
    [ProtoMember(1)]

    public int reward_type { get; set; }
    [ProtoMember(2)]
    public int reward_id { get; set; }
    [ProtoMember(3)]
    public int reward_value { get; set; }
    [ProtoMember(4)]
    public int reward_ext_value { get; set; }

}

[ProtoContract]
public class GAME_WORLD_REGION_MAIL_LIST
{
    [ProtoMember(1)]

    public bool send_packet { get; set; }

}

[ProtoContract]
public class WORLD_GAME_REGION_MAIL_LIST
{
    [ProtoMember(1)]

    public ulong user_uid { get; set; }
    [ProtoMember(2)]
    public bool send_packet { get; set; }
    [ProtoMember(3)]
    public _region_mail[] mail_list { get; set; }

}

[ProtoContract]
public class WORLD_GAME_NEW_REGION_MAIL
{
    [ProtoMember(1)]

    public _region_mail[] mail_list { get; set; }

}

[ProtoContract]
public class GAME_WORLD_REGION_MAIL_STATE
{
    [ProtoMember(1)]

    public int region_mail_uid { get; set; }
    [ProtoMember(2)]
    public int mail_state { get; set; }

}

[ProtoContract]
public class WORLD_GAME_REGION_MAIL_STATE
{
    [ProtoMember(1)]

    public ulong user_uid { get; set; }
    [ProtoMember(2)]
    public uint result { get; set; }
    [ProtoMember(3)]
    public int region_mail_uid { get; set; }
    [ProtoMember(4)]
    public int mail_state { get; set; }

}

[ProtoContract]
public class SERVER_SERVER_NEW_REGION_MAIL
{
    [ProtoMember(1)]

    public int region_mail_uid { get; set; }

}

[ProtoContract]
public class CLIENT_GAME_MAIL_PACK_SEND
{
    [ProtoMember(1)]

    public _send_mail_data send_mail { get; set; }
    [ProtoMember(2)]
    public ulong[] recv_user_id_list { get; set; }

}

[ProtoContract]
public class CLIENT_GAME_DOMINION_MAIL_SEND
{
    [ProtoMember(1)]

    public int dominion_id { get; set; }
    [ProtoMember(2)]
    _send_mail_data send_mail { get; set; }

}

[ProtoContract]
public class GAME_CLIENT_DOMINION_MAIL_SEND
{
    [ProtoMember(1)]

    public int result { get; set; }
    [ProtoMember(2)]
    public int dominion_id { get; set; }
    [ProtoMember(3)]
    public ulong last_dominion_mail_send_time { get; set; }

}

[ProtoContract]
public class GAME_WORLD_DOMINION_MAIL_SEND
{
    [ProtoMember(1)]

    public int dominion_id { get; set; }
    [ProtoMember(2)]
    _mail_data mail_data { get; set; }
    [ProtoMember(3)]
    public ulong last_dominion_mail_send_time { get; set; }

}

[ProtoContract]
public class RELAY_WORLD_DOMINION_MAIL_SEND
{
    [ProtoMember(1)]

    public int dominion_id { get; set; }
    [ProtoMember(2)]
    _mail_data mail_data { get; set; }
    [ProtoMember(3)]
    public ulong last_dominion_mail_send_time { get; set; }

}

[ProtoContract]
public class GAME_WORLD_REGION_MAIL_STATE_INFO_LIST
{

}

[ProtoContract]
public class WORLD_GAME_REGION_MAIL_STATE_INFO_LIST
{
    [ProtoMember(1)]

    public ulong user_uid { get; set; }
    [ProtoMember(2)]
    public region_mail_receipt_info[] region_mail_state_list { get; set; }

}

[ProtoContract]
public class CLIENT_GAME_UPGRADE_MASTERY
{
    [ProtoMember(1)]

    public ulong uid { get; set; }
    [ProtoMember(2)]
    public uint slot_number { get; set; }

}

[ProtoContract]
public class GAME_CLIENT_UPGRADE_MASTERY
{
    [ProtoMember(1)]

    public uint result { get; set; }
    [ProtoMember(2)]
    _cost_info costInfo { get; set; }
    [ProtoMember(4)]
    public _stack_item_info[] update_items { get; set; }
    [ProtoMember(5)]
    public uint slot_number { get; set; }
    [ProtoMember(6)]
    public uint mastery_level { get; set; }
    [ProtoMember(8)]
    public bool is_success { get; set; }

}

[ProtoContract]
public class CLIENT_GAME_UPGRADE_MASTERY_LEVEL_LIMIT
{
}

[ProtoContract]
public class GAME_CLIENT_UPGRADE_MASTERY_LEVEL_LIMIT
{
    [ProtoMember(1)]

    public uint result { get; set; }
    [ProtoMember(2)]
    public uint level_limit_grade { get; set; }
    [ProtoMember(3)]
    _cost_info cost_info { get; set; }
    [ProtoMember(4)]
    public _stack_item_info[] update_items { get; set; }

}


[ProtoContract]
public class CLIENT_WORLD_MATCHING_REQ
{
    [ProtoMember(1)]

    public ulong uid { get; set; }
    [ProtoMember(2)]
    public uint dungeon_index { get; set; }

}

[ProtoContract]
public class WORLD_CLIENT_MATCHING_REQ
{
    [ProtoMember(1)]

    public uint result { get; set; }

}

[ProtoContract]
public class CLIENT_GAME_MEDITATION_RESERVE
{
    [ProtoMember(1)]

    public ulong uid { get; set; }

}

[ProtoContract]
public class GAME_CLIENT_MEDITATION_RESERVE
{
    [ProtoMember(1)]

    public int groupId { get; set; }
    [ProtoMember(2)]
    public int slotId { get; set; }

}

[ProtoContract]
public class GAME_CLIENT_MEDITATION_END
{
    [ProtoMember(1)]

    public ulong uid { get; set; }

}

[ProtoContract]
public class GAME_CLIENT_MEDITATION_ADD_ENERGYPOINT
{
    [ProtoMember(1)]

    public int addEnergyPoint { get; set; }

}


[ProtoContract]
public class GAME_CLIENT_APPEAR_MINION
{
    [ProtoMember(1)]

    public long uid { get; set; }
    [ProtoMember(2)]
    public int classid { get; set; }
    [ProtoMember(3)]
    public int type { get; set; }
    [ProtoMember(4)]
    public _vector3 loc { get; set; }
    [ProtoMember(5)]
    public _vector3 rot { get; set; }
    [ProtoMember(6)]
    public int state { get; set; }
    [ProtoMember(7)]
    public int hp { get; set; }
    [ProtoMember(8)]
    public int ownertype { get; set; }
    [ProtoMember(9)]
    public long owneruid { get; set; }

}

[ProtoContract]
public class CLIENT_GAME_SYNCLIENT_GAME_MINION
{
    [ProtoMember(1)]

    public long uid { get; set; }
    [ProtoMember(2)]
    public _vector3 loc { get; set; }
    [ProtoMember(3)]
    public _vector3 rot { get; set; }
    [ProtoMember(4)]
    public int state { get; set; }

}

[ProtoContract]
public class GAME_CLIENT_SYNCLIENT_GAME_MINION
{
    [ProtoMember(1)]

    public long uid { get; set; }
    [ProtoMember(2)]
    public _vector3 loc { get; set; }
    [ProtoMember(3)]
    public _vector3 rot { get; set; }
    [ProtoMember(4)]
    public int state { get; set; }

}

[ProtoContract]
public class CLIENT_GAME_ATTACK_MINION
{
    [ProtoMember(1)]

    public long uid { get; set; }
    [ProtoMember(2)]
    public int state { get; set; }
    [ProtoMember(3)]
    public int skill { get; set; }
    [ProtoMember(4)]
    public int attack_id { get; set; }
    [ProtoMember(5)]
    public _vector3 loc_start { get; set; }
    [ProtoMember(6)]
    public _vector3 loc_end { get; set; }
    [ProtoMember(7)]
    public _attack_target_info[] targets { get; set; }
    [ProtoMember(8)]
    public uint cur_skill_step { get; set; }

}

[ProtoContract]
public class GAME_CLIENT_ATTACK_MINION
{
    [ProtoMember(1)]

    public long uid { get; set; }
    [ProtoMember(2)]
    public int state { get; set; }
    [ProtoMember(3)]
    public int skill { get; set; }
    [ProtoMember(4)]
    public int attack_id { get; set; }
    [ProtoMember(5)]
    public _vector3 loc_start { get; set; }
    [ProtoMember(6)]
    public _vector3 loc_end { get; set; }
    [ProtoMember(7)]
    public _attack_target_info[] targets { get; set; }
    [ProtoMember(8)]
    public uint cur_skill_step { get; set; }

}

[ProtoContract]
public class GAME_CLIENT_DIE_MINION
{
    [ProtoMember(1)]

    public long uid { get; set; }

}


[ProtoContract]
public class GAME_CLIENT_NOTIFY_ITEM_GAIN
{
    [ProtoMember(1)]

    public int gain_type { get; set; }
    [ProtoMember(2)]
    public string user_name { get; set; }
    [ProtoMember(3)]
    public int item_tid { get; set; }
    [ProtoMember(4)]
    public int second_value { get; set; }
    [ProtoMember(5)]
    public int xdraco_state { get; set; }
    [ProtoMember(6)]
    public int world_id { get; set; }

}

[ProtoContract]
public class CLIENT_GAME_REQUEST_NOTIFY_ITEM_GAIN
{
    [ProtoMember(1)]

    public int item_tid { get; set; }

}

[ProtoContract]
public class WORLD_GAME_NOTIFY_CONTETNS_LOCK
{
    [ProtoMember(1)]

    public ulong user_uid { get; set; }
    [ProtoMember(2)]
    public int result { get; set; }
    [ProtoMember(3)]
    public int contents_type { get; set; }
    [ProtoMember(4)]
    public int contetns_value { get; set; }

}

[ProtoContract]
public class GAME_CLIENT_NOTIFY_CONTETNS_LOCK
{
    [ProtoMember(1)]

    public int result { get; set; }
    [ProtoMember(2)]
    public int contents_type { get; set; }
    [ProtoMember(3)]
    public int contetns_value { get; set; }
    [ProtoMember(4)]
    public bool kick_zone { get; set; }

}

[ProtoContract]
public class CLIENT_GAME_CONTENTS_LOCK_LIST
{
}

[ProtoContract]
public class GAME_CLIENT_CONTENTS_LOCK_LIST
{
    [ProtoMember(1)]

    public _gm_contents_lock[] lock_list { get; set; }

}

[ProtoContract]
public class GAME_CLIENT_CONTENTS_LOCK_CHANGE
{
    [ProtoMember(1)]

    public _gm_contents_lock[] lock_list { get; set; }

}

[ProtoContract]
public class GAME_CLIENT_NOTIFY_CHANGE_DATE
{

}

[ProtoContract]
public class GAME_CLIENT_NOTIFY_TIMELINE_GEN
{
    [ProtoMember(1)]

    public int[] timeline_tid { get; set; }

}

[ProtoContract]
public class GAME_CLIENT_NOTIFY_TIMELINE_GEN_ANOTHER_WORLD
{
    [ProtoMember(1)]

    public int[] timeline_tid { get; set; }

}

[ProtoContract]
public class GAME_CLIENT_NOTIFY_GAIN_INFO
{
    [ProtoMember(1)]

    public int gain_type { get; set; }
    [ProtoMember(2)]
    public uint string_tid { get; set; }
    [ProtoMember(3)]
    public string user_name { get; set; }
    [ProtoMember(4)]
    public uint gain_tid { get; set; }
    [ProtoMember(5)]
    public uint stage_tid { get; set; }

}

[ProtoContract]
public class SERVER_SERVER_GUILD_NOTIFY_GAIN_INFO
{
    [ProtoMember(1)]

    public ulong guild_uid { get; set; }
    [ProtoMember(2)]
    public int gain_type { get; set; }
    [ProtoMember(3)]
    public uint string_tid { get; set; }
    [ProtoMember(4)]
    public string user_name { get; set; }
    [ProtoMember(5)]
    public uint gain_tid { get; set; }
    [ProtoMember(6)]
    public uint stage_tid { get; set; }

}

[ProtoContract]
public class LOBBY_CLIENT_NOTIFY_CONTENTS_LOCK
{
    [ProtoMember(1)]

    public ulong user_uid { get; set; }
    [ProtoMember(2)]
    public int result { get; set; }
    [ProtoMember(3)]
    public int contents_type { get; set; }
    [ProtoMember(4)]
    public int contetns_value { get; set; }

}

[ProtoContract]
public class CLIENT_LOBBY_CONTENTS_LOCK_LIST
{
}

[ProtoContract]
public class LOBBY_CLIENT_CONTENTS_LOCK_LIST
{
    [ProtoMember(1)]

    public _gm_contents_lock[] lock_list { get; set; }

}

[ProtoContract]
public class LOBBY_CLIENT_CONTENTS_LOCK_CHANGE
{
    [ProtoMember(1)]

    public _gm_contents_lock[] lock_list { get; set; }

}

[ProtoContract]
public class GAME_CLIENT_NOTIFY_CAPTCHA_REAUTH_CHANGE
{
    [ProtoMember(1)]

    public int reauth_term_min { get; set; }
    [ProtoMember(2)]
    public int reauth_level { get; set; }

}


[ProtoContract]
public class GAME_CLIENT_ACTIVATE_OBJECT_REWARD
{
    [ProtoMember(1)]

    public ulong activate_user_uid { get; set; }
    [ProtoMember(2)]
    public ulong activated_object_uid { get; set; }
    [ProtoMember(3)]
    public int use_inven_count { get; set; }
    [ProtoMember(4)]
    public _cost_info[] reward_costInfo { get; set; }
    [ProtoMember(5)]
    public _character_inven_item[] reward_item { get; set; }
    [ProtoMember(6)]
    public uint object_id { get; set; }
    [ProtoMember(7)]
    public _stack_item_info[] del_item_list { get; set; }

}

[ProtoContract]
public class GAME_CLIENT_CHANGE_OBJECT_STATE
{
    [ProtoMember(1)]

    public ulong object_uid { get; set; }
    [ProtoMember(2)]
    public uint object_state { get; set; }
    [ProtoMember(3)]
    public string state_string { get; set; }

}

[ProtoContract]
public class GAME_CLIENT_OBJECT_UPDATE_USE_COUNT
{
    [ProtoMember(1)]

    public ulong object_uid { get; set; }
    [ProtoMember(2)]
    public uint remaining_use_count { get; set; }

}

[ProtoContract]
public class GAME_CLIENT_STAGE_MONSTER_STATUS_NOTIFY
{
    [ProtoMember(1)]

    public int message_id { get; set; }

}

[ProtoContract]
public class CLIENT_GAME_PROUD_ITEM
{
    [ProtoMember(1)]

    public _vector3 pos { get; set; }
    [ProtoMember(2)]
    public ulong item_uid { get; set; }

}

[ProtoContract]
public class GAME_CLIENT_PROUD_ITEM
{
    [ProtoMember(1)]

    public uint result { get; set; }
    [ProtoMember(2)]
    public ulong item_uid { get; set; }

}

[ProtoContract]
public class CLIENT_GAME_PROUD_ITEM_CANCEL
{
    [ProtoMember(1)]

    public ulong object_uid { get; set; }

}

[ProtoContract]
public class GAME_CLIENT_PROUD_ITEM_CANCEL
{
    [ProtoMember(1)]

    public uint result { get; set; }

}

[ProtoContract]
public class GAME_CLIENT_PROUD_ITEM_DISAPPEAR
{
    [ProtoMember(1)]

    public ulong object_uid { get; set; }

}

[ProtoContract]
public class CLIENT_GAME_PROUD_ITEM_INFO
{
    [ProtoMember(1)]

    public ulong object_uid { get; set; }

}

[ProtoContract]
public class GAME_CLIENT_PROUD_ITEM_INFO
{
    [ProtoMember(1)]

    public uint result { get; set; }
    [ProtoMember(2)]
    public long despawn_time { get; set; }
    [ProtoMember(3)]
    public string nick_name { get; set; }
    [ProtoMember(4)]
    _character_inven_item inven_item { get; set; }
    [ProtoMember(5)]
    public ulong object_uid { get; set; }

}

[ProtoContract]
public class GAME_CLIENT_PROUD_ITEM_UPDATE_WONDER
{
    [ProtoMember(1)]

    public uint result { get; set; }
    [ProtoMember(2)]
    public ulong my_daily_wonder { get; set; }
    [ProtoMember(3)]
    public _cost_info[] cost_info_list { get; set; }

}

[ProtoContract]
public class CLIENT_GAME_PROUD_ITEM_WONDER
{
    [ProtoMember(1)]

    public ulong object_uid { get; set; }

}

[ProtoContract]
public class GAME_CLIENT_PROUD_ITEM_WONDER
{
    [ProtoMember(1)]

    public uint result { get; set; }
    [ProtoMember(2)]
    public string nick_name { get; set; }
    [ProtoMember(3)]
    public uint item_id { get; set; }

}

[ProtoContract]
public class _total_party_info
{
    [ProtoMember(1)]

    _party_info party_info { get; set; }
    [ProtoMember(2)]
    public _party_member_info[] party_member_infos { get; set; }

}

[ProtoContract]
public class _party_member_sync_info
{
    [ProtoMember(1)]

    public ulong member_uid { get; set; }
    [ProtoMember(2)]
    public uint hp { get; set; }
    [ProtoMember(3)]
    public uint mana { get; set; }
    [ProtoMember(4)]
    public uint vigor { get; set; }
    [ProtoMember(5)]
    public _vector3 pos { get; set; }
    [ProtoMember(6)]
    public uint max_hp { get; set; }
    [ProtoMember(7)]
    public uint max_mana { get; set; }
    [ProtoMember(8)]
    public uint max_vigor { get; set; }
    [ProtoMember(9)]
    public uint cur_damage_absorb { get; set; }
    [ProtoMember(10)]
    public bool alive { get; set; }
    [ProtoMember(11)]
    _refuse_info refuse_buff_info { get; set; }

}

[ProtoContract]
public class _recommend_party_member_info
{
    [ProtoMember(1)]

    public ulong member_uid { get; set; }
    [ProtoMember(2)]
    public int member_class { get; set; }
    [ProtoMember(3)]
    public int level { get; set; }
    [ProtoMember(4)]
    public string nickname { get; set; }
    [ProtoMember(5)]
    public int combatpoint { get; set; }
    [ProtoMember(6)]
    public string guild_name { get; set; }
    [ProtoMember(7)]
    public uint guild_mark { get; set; }
    [ProtoMember(8)]
    public uint guild_mark_edge { get; set; }
    [ProtoMember(9)]
    public ulong guild_uid { get; set; }

}

[ProtoContract]
public class _party_alarm_info
{
    [ProtoMember(1)]

    public uint target_stage_type { get; set; }
    [ProtoMember(2)]
    public ulong last_party_uid { get; set; }
    [ProtoMember(3)]
    public bool is_new_alarm { get; set; }
    [ProtoMember(4)]
    public bool is_guild_party { get; set; }

}

[ProtoContract]
public class CLIENT_GAME_CREATE_PARTY_REQUEST
{
    [ProtoMember(1)]

    public ulong uid { get; set; }
    [ProtoMember(2)]
    public _party_attribute create_party_attribute { get; set; }
    [ProtoMember(3)]
    public string password { get; set; }

}

[ProtoContract]
public class GAME_WORLD_CREATE_PARTY_REQUEST
{
    [ProtoMember(1)]

    public ulong uid { get; set; }
    [ProtoMember(2)]
    _party_attribute create_party_attribute { get; set; }
    [ProtoMember(3)]
    public string password { get; set; }
    [ProtoMember(4)]
    public int dungeon_auto_start { get; set; }

}

[ProtoContract]
public class WORLD_GAME_CREATE_PARTY_REPLY
{
    [ProtoMember(1)]

    public ulong uid { get; set; }
    [ProtoMember(2)]
    public ulong party_uid { get; set; }
    [ProtoMember(3)]
    _total_party_info total_party_info { get; set; }
    [ProtoMember(4)]
    public bool is_send_to_client { get; set; }

}

[ProtoContract]
public class GAME_CLIENT_NOTIFY_CREATE_PARTY
{
    [ProtoMember(1)]

    public ulong party_uid { get; set; }
    [ProtoMember(2)]
    public _total_party_info total_party_info { get; set; }

}

[ProtoContract]
public class CLIENT_GAME_PARTY_INVITE
{
    [ProtoMember(1)]

    public ulong request_user_uid { get; set; }
    [ProtoMember(2)]
    public ulong invite_user_uid { get; set; }
    [ProtoMember(3)]
    public bool is_all_invite { get; set; }

}

[ProtoContract]
public class GAME_CLIENT_PARTY_INVITE_REQUEST
{
    [ProtoMember(1)]

    public ulong invite_user_uid { get; set; }
    [ProtoMember(2)]
    public ulong request_user_uid { get; set; }
    [ProtoMember(3)]
    public string request_user_name { get; set; }
    [ProtoMember(4)]
    public ulong request_party_uid { get; set; }
    [ProtoMember(5)]
    public uint request_user_level { get; set; }
    [ProtoMember(6)]
    public uint request_user_class { get; set; }
    [ProtoMember(7)]
    public int request_user_combatpoint { get; set; }
    [ProtoMember(8)]
    public string request_user_guild_name { get; set; }
    [ProtoMember(9)]
    public uint request_user_guild_mark { get; set; }
    [ProtoMember(10)]
    public uint request_user_guild_mark_edge { get; set; }
    [ProtoMember(11)]
    public ulong request_user_guild_uid { get; set; }
    [ProtoMember(12)]
    public uint party_stage_type { get; set; }
    [ProtoMember(13)]
    public uint party_target_stage_index { get; set; }
    [ProtoMember(14)]
    public ulong invite_end_time { get; set; }
    [ProtoMember(15)]
    public bool is_dungeon_party { get; set; }
    [ProtoMember(16)]
    public bool is_invite_all { get; set; }
    [ProtoMember(17)]
    public uint party_number_type { get; set; }
    [ProtoMember(18)]
    public bool request_user_assassin_mode { get; set; }

}

[ProtoContract]
public class GAME_WORLD_PARTY_INVITE_RESULT
{
    [ProtoMember(1)]

    public ulong request_user_uid { get; set; }
    [ProtoMember(2)]
    public ulong invite_user_uid { get; set; }
    [ProtoMember(3)]
    public int fail_reason { get; set; }

}

[ProtoContract]
public class CLIENT_GAME_PARTY_INVITE_REPLY
{
    [ProtoMember(1)]

    public ulong reply_user_uid { get; set; }
    [ProtoMember(2)]
    public ulong request_user_uid { get; set; }
    [ProtoMember(3)]
    public ulong request_party_uid { get; set; }
    [ProtoMember(4)]
    public bool request_result { get; set; }

}

[ProtoContract]
public class GAME_WORLD_PARTY_INVITE_REPLY
{
    [ProtoMember(1)]

    public ulong reply_user_uid { get; set; }
    [ProtoMember(2)]
    public ulong request_user_uid { get; set; }
    [ProtoMember(3)]
    public ulong request_party_uid { get; set; }
    [ProtoMember(4)]
    public bool request_result { get; set; }
    [ProtoMember(5)]
    public int dungeon_auto_start { get; set; }
    [ProtoMember(6)]
    public bool assassin_mode { get; set; }

}

[ProtoContract]
public class GAME_CLIENT_PARTY_MEMBER_ENTER
{
    [ProtoMember(1)]

    public ulong receive_user_uid { get; set; }
    [ProtoMember(2)]
    public ulong join_party_uid { get; set; }
    [ProtoMember(3)]
    _party_member_info enter_party_member_info { get; set; }

}

[ProtoContract]
public class GAME_CLIENT_PARTY_JOIN
{
    [ProtoMember(1)]

    public ulong join_user_uid { get; set; }
    [ProtoMember(2)]
    public ulong join_party_uid { get; set; }
    [ProtoMember(3)]
    _total_party_info total_party_info { get; set; }

}

[ProtoContract]
public class GAME_CLIENT_PARTY_INFO
{
    [ProtoMember(1)]

    public ulong receive_user_uid { get; set; }
    [ProtoMember(2)]
    public ulong party_uid { get; set; }
    [ProtoMember(3)]
    _total_party_info total_party_info { get; set; }

}

[ProtoContract]
public class CLIENT_GAME_REQUEST_PARTY_LEAVE
{
    [ProtoMember(1)]

    public ulong leave_user_uid { get; set; }
    [ProtoMember(2)]
    public ulong leave_party_uid { get; set; }

}

[ProtoContract]
public class CLIENT_GAME_REQUEST_PARTY_MEMBER_KICK
{
    [ProtoMember(1)]

    public ulong request_user_uid { get; set; }
    [ProtoMember(2)]
    public ulong kick_user_uid { get; set; }
    [ProtoMember(3)]
    public ulong request_party_uid { get; set; }

}

[ProtoContract]
public class GAME_CLIENT_NOTIFY_PARTY_MEMBER_LEAVE
{
    [ProtoMember(1)]

    public ulong receive_user_uid { get; set; }
    [ProtoMember(2)]
    public ulong leave_user_uid { get; set; }
    [ProtoMember(3)]
    public ulong leave_party_uid { get; set; }
    [ProtoMember(4)]
    public int leave_reason { get; set; }
    [ProtoMember(5)]
    public bool change_party_leader { get; set; }
    [ProtoMember(6)]
    public ulong next_party_leader_uid { get; set; }
    [ProtoMember(7)]
    public int dungeon_auto_start { get; set; }

}

[ProtoContract]
public class GAME_CLIENT_PARTY_MEMBER_LEAVE_RESULT
{
    [ProtoMember(1)]

    public ulong leave_user_uid { get; set; }
    [ProtoMember(2)]
    public int leave_reason { get; set; }

}

[ProtoContract]
public class GAME_CLIENT_PARTY_ERROR
{
    [ProtoMember(1)]

    public ulong receive_user_uid { get; set; }
    [ProtoMember(2)]
    public int party_error_id { get; set; }

}

[ProtoContract]
public class GAME_WORLD_REQUEST_PARTY_INFO
{
    [ProtoMember(1)]

    public ulong request_user_uid { get; set; }

}

[ProtoContract]
public class GAME_CLIENT_NOTIFY_PARTY_MEMBER_LOGINOUT
{
    [ProtoMember(1)]

    public ulong receive_user_uid { get; set; }
    [ProtoMember(2)]
    public ulong user_uid { get; set; }
    [ProtoMember(3)]
    public bool log_in { get; set; }

}

[ProtoContract]
public class GAME_CLIENT_NOTIFY_PARTY_INVITE_REFUSE
{
    [ProtoMember(1)]

    public ulong receive_user_uid { get; set; }
    [ProtoMember(2)]
    public ulong refuse_user_uid { get; set; }
    [ProtoMember(3)]
    public string refuse_user_name { get; set; }
    [ProtoMember(4)]
    public int error_id { get; set; }

}

[ProtoContract]
public class GAME_CLIENT_NOTIFY_PARTYMEMBER_INFO_UPDATE
{
    [ProtoMember(1)]

    public ulong receive_user_uid { get; set; }
    [ProtoMember(2)]
    public int stageid { get; set; }
    [ProtoMember(3)]
    public long update_partymember_id { get; set; }
    [ProtoMember(4)]
    public int channel_index { get; set; }
    [ProtoMember(5)]
    public int Level { get; set; }
    [ProtoMember(6)]
    public int combat_point { get; set; }
    [ProtoMember(7)]
    public bool alive { get; set; }
    [ProtoMember(8)]
    _refuse_info refuse_buff_info { get; set; }

}

[ProtoContract]
public class GAME_CLIENT_SYNC_PARTY_MEMBER_INFO_IN_STAGE
{
    [ProtoMember(1)]

    public ulong receive_user_uid { get; set; }
    [ProtoMember(2)]
    public _party_member_sync_info[] party_member_sync_info { get; set; }

}

[ProtoContract]
public class WORLD_GAME_REQUEST_START_PARTY_VOTE
{
    [ProtoMember(1)]

    public ulong vote_user_uid { get; set; }
    [ProtoMember(2)]
    public ulong vote_start_user_uid { get; set; }
    [ProtoMember(3)]
    public int vote_type { get; set; }
    [ProtoMember(4)]
    public ulong vote_arg { get; set; }
    [ProtoMember(5)]
    public ulong default_vote_user_uid { get; set; }

}

[ProtoContract]
public class GAME_WORLD_START_PARTY_VOTE_ERROR
{
    [ProtoMember(1)]

    public ulong vote_start_user_uid { get; set; }
    [ProtoMember(3)]
    public ulong vote_user_uid { get; set; }
    [ProtoMember(2)]
    public uint error_id { get; set; }

}

[ProtoContract]
public class GAME_CLIENT_START_PARTY_VOTE
{
    [ProtoMember(1)]

    public ulong receive_user_uid { get; set; }
    [ProtoMember(2)]
    public int vote_type { get; set; }
    [ProtoMember(3)]
    public ulong vote_arg { get; set; }

}

[ProtoContract]
public class CLIENT_GAME_PARTY_VOTE_RESULT
{
    [ProtoMember(1)]

    public ulong vote_user_uid { get; set; }
    [ProtoMember(2)]
    public bool vote_result { get; set; }

}

[ProtoContract]
public class GAME_CLIENT_PARTY_MEMBER_VOTE_RESULT
{
    [ProtoMember(1)]

    public ulong receive_user_uid { get; set; }
    [ProtoMember(2)]
    public ulong vote_user_uid { get; set; }
    [ProtoMember(3)]
    public bool vote_result { get; set; }

}

[ProtoContract]
public class GAME_CLIENT_VOTE_RESULT
{
    [ProtoMember(1)]

    public ulong receive_user_uid { get; set; }
    [ProtoMember(2)]
    public ulong vote_party_uid { get; set; }
    [ProtoMember(3)]
    public bool vote_result { get; set; }

}

[ProtoContract]
public class CLIENT_GAME_CHANGE_PARTY_LEADER
{
    [ProtoMember(1)]

    public ulong request_user_uid { get; set; }
    [ProtoMember(2)]
    public ulong request_party_uid { get; set; }
    [ProtoMember(3)]
    public ulong next_leader_uid { get; set; }

}

[ProtoContract]
public class GAME_CLIENT_CHANGE_PARTY_LEADER_RESULT
{
    [ProtoMember(1)]

    public ulong receive_user_uid { get; set; }
    [ProtoMember(2)]
    public ulong next_leader_uid { get; set; }
    [ProtoMember(3)]
    public ulong before_leader_uid { get; set; }
    [ProtoMember(4)]
    public bool before_leader_is_ready { get; set; }
    [ProtoMember(5)]
    public int dungeon_auto_start { get; set; }

}

[ProtoContract]
public class GAME_CLIENT_NOTIFY_PARTY_MEMBER_ALIVE
{
    [ProtoMember(1)]

    public ulong receive_user_uid { get; set; }
    [ProtoMember(2)]
    public ulong user_uid { get; set; }
    [ProtoMember(3)]
    public bool alive { get; set; }
    [ProtoMember(4)]
    _refuse_info refuse_buff_info { get; set; }

}

[ProtoContract]
public class CLIENT_GAME_REQUEST_RECOMMEND_PARTY_MEMBER_LIST
{
    [ProtoMember(1)]

    public ulong uid { get; set; }

}

[ProtoContract]
public class GAME_CLIENT_RECOMMEND_PARTY_MEMBER_LIST
{
    [ProtoMember(1)]

    public ulong receive_user_uid { get; set; }
    [ProtoMember(2)]
    public _recommend_party_member_info[] recommend_user_list { get; set; }

}

[ProtoContract]
public class CLIENT_GAME_CHANGE_FREE_ENTER_PARTY
{
    [ProtoMember(1)]

    public ulong request_user_uid { get; set; }
    [ProtoMember(2)]
    public ulong party_uid { get; set; }
    [ProtoMember(3)]
    public bool free_enter_party { get; set; }

}

[ProtoContract]
public class GAME_CLIENT_NOTIFY_CHANGE_FREE_ENTER_PARTY
{
    [ProtoMember(1)]

    public ulong receive_user_uid { get; set; }
    [ProtoMember(2)]
    public ulong party_uid { get; set; }
    [ProtoMember(3)]
    public bool free_enter_party { get; set; }

}

[ProtoContract]
public class CLIENT_GAME_REQUEST_CALL_PARTY_MEMBER
{
    [ProtoMember(1)]

    public ulong request_user_uid { get; set; }
    [ProtoMember(2)]
    public ulong party_uid { get; set; }

}

[ProtoContract]
public class GAME_CLIENT_REQUEST_CALL_PARTY_MEMBER
{
    [ProtoMember(1)]

    public ulong request_user_uid { get; set; }
    [ProtoMember(2)]
    public ulong party_uid { get; set; }
    [ProtoMember(3)]
    public int leader_stage_id { get; set; }
    [ProtoMember(4)]
    public _vector3 leader_position { get; set; }

}

[ProtoContract]
public class GAME_CLIENT_CALL_PARTY_MEMBER_TO_LEADER_POSITION
{
    [ProtoMember(1)]

    public ulong receive_user_uid { get; set; }
    [ProtoMember(2)]
    public int leader_stage_id { get; set; }
    [ProtoMember(3)]
    public _vector3 leader_position { get; set; }

}

[ProtoContract]
public class CLIENT_GAME_REFUSE_MEMBER_CALL
{
    [ProtoMember(1)]

    public ulong refuse_user_uid { get; set; }
    [ProtoMember(2)]
    public ulong party_uid { get; set; }

}

[ProtoContract]
public class GAME_CLIENT_NOTIFY_REFUSE_MEMBER_CALL
{
    [ProtoMember(1)]

    public ulong receive_user_uid { get; set; }
    [ProtoMember(2)]
    public ulong refuse_user_uid { get; set; }

}

[ProtoContract]
public class CLIENT_GAME_REQUEST_PARTY_USER_POSITION
{
    [ProtoMember(1)]

    public ulong target_user_uid { get; set; }
    [ProtoMember(2)]
    public ulong party_uid { get; set; }

}

[ProtoContract]
public class GAME_CLIENT_REQUEST_PARTY_USER_POSITION_GAME_SERVER
{
    [ProtoMember(1)]

    public ulong target_user_uid { get; set; }
    [ProtoMember(2)]
    public ulong request_user_uid { get; set; }
    [ProtoMember(3)]
    public ulong party_uid { get; set; }

}

[ProtoContract]
public class GAME_CLIENT_REQUEST_PARTY_USER_POSITION_RESULT
{
    [ProtoMember(1)]

    public ulong target_user_uid { get; set; }
    [ProtoMember(2)]
    public ulong request_user_uid { get; set; }
    [ProtoMember(3)]
    public ulong party_uid { get; set; }
    [ProtoMember(4)]
    public int target_stage_id { get; set; }
    [ProtoMember(5)]
    public _vector3 target_position { get; set; }

}

[ProtoContract]
public class CLIENT_WORLD_FIND_PARTY_LIST
{
    [ProtoMember(1)]

    public ulong uid { get; set; }
    [ProtoMember(2)]
    public uint party_stage_type { get; set; }
    [ProtoMember(3)]
    public uint start_search_level { get; set; }
    [ProtoMember(4)]
    public uint end_search_level { get; set; }
    [ProtoMember(5)]
    public bool is_guild_party { get; set; }

}

[ProtoContract]
public class WORLD_CLIENT_FIND_PARTY_LIST_START
{
    [ProtoMember(1)]

    public uint party_stage_type { get; set; }
    [ProtoMember(2)]
    public bool is_guild_party { get; set; }
    [ProtoMember(3)]
    public uint normal_party_count { get; set; }
    [ProtoMember(4)]
    public uint party_dungeon_count { get; set; }
    [ProtoMember(5)]
    public uint boss_dungeon_count { get; set; }
    [ProtoMember(6)]
    public uint guild_party_count { get; set; }
    [ProtoMember(7)]
    public uint hell_dungeon_count { get; set; }

}

[ProtoContract]
public class WORLD_CLIENT_FIND_PARTY_LIST
{
    [ProtoMember(1)]

    public _total_party_info[]  find_party_list { get; set; }
[ProtoMember(2)]
public uint party_stage_type { get; set; }
[ProtoMember(3)]
public bool is_guild_party { get; set; } 
    
}

[ProtoContract]
public class WORLD_CLIENT_FIND_PARTY_LIST_END
{
    [ProtoMember(1)]

    public uint party_stage_type { get; set; }
    [ProtoMember(2)]
    public bool is_guild_party { get; set; }

}

[ProtoContract]
public class CLIENT_WORLD_CHANGE_PARTY_ATTRIBUTE
{
    [ProtoMember(1)]

    public ulong request_user_uid { get; set; }
    [ProtoMember(2)]
    public ulong party_uid { get; set; }
    [ProtoMember(3)]
    _party_attribute change_party_attribute { get; set; }

}

[ProtoContract]
public class WORLD_CLIENT_CHANGE_PARTY_ATTRIBUTE
{
    [ProtoMember(1)]

    public ulong receive_user_uid { get; set; }
    [ProtoMember(2)]
    public ulong party_uid { get; set; }
    [ProtoMember(3)]
    _party_attribute change_party_attribute { get; set; }

}

[ProtoContract]
public class CLIENT_GAME_REQUEST_PARTY_ENTER
{
    [ProtoMember(1)]

    public ulong request_user { get; set; }
    [ProtoMember(2)]
    public ulong request_party_uid { get; set; }
    [ProtoMember(3)]
    public uint party_stage_type { get; set; }
    [ProtoMember(4)]
    public uint party_target_stage_index { get; set; }
    [ProtoMember(5)]
    public string password { get; set; }
    [ProtoMember(6)]
    public bool is_chatting_invite { get; set; }

}

[ProtoContract]
public class GAME_WORLD_REQUEST_PARTY_ENTER
{
    [ProtoMember(1)]

    public ulong request_user { get; set; }
    [ProtoMember(2)]
    public ulong request_party_uid { get; set; }
    [ProtoMember(3)]
    public string password { get; set; }
    [ProtoMember(4)]
    public bool is_chatting_invite { get; set; }
    [ProtoMember(5)]
    public int dungeon_auto_start { get; set; }

}

[ProtoContract]
public class WORLD_CLIENT_REQUEST_PARTY_ENTER_AGREE
{
    [ProtoMember(1)]

    public ulong receive_user_uid { get; set; }
    [ProtoMember(2)]
    public ulong request_user_uid { get; set; }
    [ProtoMember(3)]
    public string request_user_name { get; set; }
    [ProtoMember(4)]
    public uint request_user_level { get; set; }
    [ProtoMember(5)]
    public uint request_user_class { get; set; }
    [ProtoMember(6)]
    public ulong request_enter_party_uid { get; set; }
    [ProtoMember(7)]
    public int request_user_combatpoint { get; set; }
    [ProtoMember(8)]
    public string request_user_guild_name { get; set; }
    [ProtoMember(9)]
    public uint request_user_guild_mark { get; set; }
    [ProtoMember(10)]
    public uint request_user_guild_mark_edge { get; set; }
    [ProtoMember(11)]
    public ulong request_user_guild_uid { get; set; }

}

[ProtoContract]
public class CLIENT_WORLD_REPLY_PARTY_ENTER_AGREE
{
    [ProtoMember(1)]

    public ulong reply_user_uid { get; set; }
    [ProtoMember(2)]
    public ulong request_user_uid { get; set; }
    [ProtoMember(3)]
    public ulong request_enter_party_uid { get; set; }
    [ProtoMember(4)]
    public bool request_result { get; set; }

}

[ProtoContract]
public class CLIENT_WORLD_REMOVE_PARTY
{
    [ProtoMember(1)]

    public ulong request_user_uid { get; set; }
    [ProtoMember(2)]
    public ulong request_party_uid { get; set; }

}

[ProtoContract]
public class WORLD_GAME_NOTIFY_CHANGE_PARTY_ATTRIBUTE
{
    [ProtoMember(1)]

    public ulong receive_user_uid { get; set; }
    [ProtoMember(2)]
    public ulong party_uid { get; set; }
    [ProtoMember(3)]
    _party_attribute party_attribute { get; set; }

}

[ProtoContract]
public class WORLD_CLIENT_PARTY_VOTE_CANCEL
{
    [ProtoMember(1)]

    public ulong error_user_uid { get; set; }
    [ProtoMember(2)]
    public uint error_id { get; set; }

}

[ProtoContract]
public class GAME_WORLD_SYNC_PARTY_MEMBER_INFO
{
    [ProtoMember(1)]

    _party_member_sync_info member_sync_info { get; set; }

}

[ProtoContract]
public class WORLD_CLIENT_SYNC_PARTY_MEMBER_INFO
{
    [ProtoMember(1)]

    _party_member_sync_info member_sync_info { get; set; }

}

[ProtoContract]
public class GAME_CLIENT_PARTY_MEMBER_ITEM_DROP
{
    [ProtoMember(1)]

    public ulong member_uid { get; set; }
    [ProtoMember(2)]
    public _simple_item_info[] member_drop_item_list { get; set; }

}

[ProtoContract]
public class WORLD_CLIENT_PARTY_MEMBER_CHANGE_GUILD_NAME
{
    [ProtoMember(1)]

    public ulong member_uid { get; set; }
    [ProtoMember(2)]
    public string guild_name { get; set; }

}

[ProtoContract]
public class CLIENT_WORLD_WARP_PARTY_USER_MAGIC_SQUARE_ROOM
{
    [ProtoMember(1)]

    public ulong target_uid { get; set; }

}

[ProtoContract]
public class CLIENT_WORLD_CHANGE_MEMBER_SLOT_CLASS
{
    [ProtoMember(1)]

    public ulong request_user_uid { get; set; }
    [ProtoMember(2)]
    public ulong party_uid { get; set; }
    [ProtoMember(3)]
    public uint slot_number { get; set; }
    [ProtoMember(4)]
    public uint change_slot_class { get; set; }

}

[ProtoContract]
public class WORLD_CLIENT_NOTIFY_CHANGE_MEMBER_SLOT_CLASS
{
    [ProtoMember(1)]

    public ulong receive_user_uid { get; set; }
    [ProtoMember(2)]
    public ulong party_uid { get; set; }
    [ProtoMember(3)]
    public uint slot_number { get; set; }
    [ProtoMember(4)]
    public uint change_slot_class { get; set; }

}

[ProtoContract]
public class CLIENT_WORLD_PARTY_CHANGE_READY
{
    [ProtoMember(1)]

    public bool is_ready { get; set; }
    [ProtoMember(2)]
    public ulong party_uid { get; set; }

}

[ProtoContract]
public class WORLD_CLIENT_PARTY_NOTIFY_CHANGE_READY
{
    [ProtoMember(1)]

    public ulong change_user_uid { get; set; }
    [ProtoMember(2)]
    public bool is_ready { get; set; }

}

[ProtoContract]
public class CLIENT_GAME_PARTY_INSTANCE_DUNGEON_ENTER
{
    [ProtoMember(1)]

    public ulong uid { get; set; }
    [ProtoMember(2)]
    public uint world_boss_raid_id { get; set; }

}

[ProtoContract]
public class GAME_WORLD_PARTY_INSTANCE_DUNGEON_ENTER
{
    [ProtoMember(1)]

    public ulong uid { get; set; }
    [ProtoMember(2)]
    public uint world_boss_raid_id { get; set; }

}

[ProtoContract]
public class CLIENT_WORLD_PARTY_ADVERTISING
{

}

[ProtoContract]
public class CLIENT_WORLD_PARTY_SEARCH
{
    [ProtoMember(1)]

    public ulong target_party_uid { get; set; }

}

[ProtoContract]
public class WORLD_CLIENT_PARTY_SEARCH
{
    [ProtoMember(1)]

    public ulong target_party_uid { get; set; }
    [ProtoMember(2)]
    _total_party_info total_party_info { get; set; }
    [ProtoMember(3)]
    public bool is_exist { get; set; }

}

[ProtoContract]
public class CLIENT_WORLD_SET_PARTY_ALARM
{
    [ProtoMember(1)]

    public uint target_stage_type { get; set; }
    [ProtoMember(2)]
    public bool is_on { get; set; }
    [ProtoMember(3)]
    public bool is_guild { get; set; }

}

[ProtoContract]
public class WORLD_CLIENT_SET_PARTY_ALARM
{
    [ProtoMember(1)]

    public uint target_stage_type { get; set; }
    [ProtoMember(2)]
    public bool is_on { get; set; }
    [ProtoMember(3)]
    public bool is_guild { get; set; }

}

[ProtoContract]
public class CLIENT_WORLD_GET_PARTY_ALARM
{
}

[ProtoContract]
public class WORLD_CLIENT_GET_PARTY_ALARM
{
    [ProtoMember(1)]

    public _party_alarm_info[] party_alarm_info { get; set; }

}

[ProtoContract]
public class WORLD_CLIENT_NOTIFY_PARTY_DUNGEON_START
{
    [ProtoMember(1)]

    public uint dungeon_start_time { get; set; }

}

[ProtoContract]
public class CLIENT_WORLD_GET_PARTY_INFO
{

}

[ProtoContract]
public class CLIENT_WORLD_PARTY_TARGET_MONSTER
{
    [ProtoMember(1)]

    public uint target_entity_type { get; set; }
    [ProtoMember(2)]
    public ulong target_monster_uid { get; set; }

}

[ProtoContract]
public class WORLD_CLIENT_PARTY_TARGET_MONSTER_NOTIFY
{
    [ProtoMember(1)]

    public uint target_entity_type { get; set; }
    [ProtoMember(2)]
    public ulong target_uid { get; set; }
    [ProtoMember(3)]
    public ulong target_zone_uid { get; set; }
    [ProtoMember(4)]
    public ulong target_stage_id { get; set; }

}

[ProtoContract]
public class CLIENT_GAME_PARTY_INVITE_ALL
{
    [ProtoMember(1)]

    public uint invite_type { get; set; }

}

[ProtoContract]
public class GAME_WORLD_PARTY_UPDATE_ALIVE
{
    [ProtoMember(1)]

    public ulong user_uid { get; set; }
    [ProtoMember(2)]
    public bool alive { get; set; }
    [ProtoMember(3)]
    _refuse_info refuse_buff_info { get; set; }

}

[ProtoContract]
public class CLIENT_WORLD_PARTY_INVITE_CHATTING
{
    [ProtoMember(1)]

    public uint chat_type { get; set; }
    [ProtoMember(2)]
    public ulong target_uid { get; set; }

}

[ProtoContract]
public class WORLD_CLIENT_PARTY_INVITE_CHATTING
{
    [ProtoMember(1)]

    public uint result { get; set; }
    [ProtoMember(2)]
    public uint chat_type { get; set; }
    [ProtoMember(3)]
    public ulong target_uid { get; set; }

}

[ProtoContract]
public class GAME_WORLD_PARTY_CHANGE_DUNGEON_AUTO_START
{
    [ProtoMember(1)]

    public int dungeon_auto_start { get; set; }

}

[ProtoContract]
public class GAME_CLIENT_PARTY_CHANGE_DUNGEON_AUTO_START
{
    [ProtoMember(1)]

    public ulong user_uid { get; set; }
    [ProtoMember(2)]
    public int dungeon_auto_start { get; set; }

}


[ProtoContract]
public class CLIENT_GAME_PET_LIST
{
}

[ProtoContract]
public class GAME_CLIENT_PET_LIST
{
    [ProtoMember(1)]

    public int current_pet_deck { get; set; }
    [ProtoMember(2)]
    public _pet_deck_info[] pet_deck_list { get; set; }
    [ProtoMember(3)]
    public _pet_info[] pet_info_list { get; set; }

}

[ProtoContract]
public class CLIENT_GAME_PET_UNLOCK
{
    [ProtoMember(1)]

    public int open_pet_tid { get; set; }

}

[ProtoContract]
public class GAME_CLIENT_PET_UNLOCK
{
    [ProtoMember(1)]

    public int result { get; set; }
    [ProtoMember(2)]
    _pet_info pet_info { get; set; }
    [ProtoMember(3)]
    public _stack_item_info[] del_item_list { get; set; }

}

[ProtoContract]
public class CLIENT_GAME_PET_SET_DECK
{
    [ProtoMember(1)]

    public int deck_id { get; set; }
    [ProtoMember(2)]
    public int slot_id { get; set; }
    [ProtoMember(3)]
    public int pet_tid { get; set; }

}

[ProtoContract]
public class GAME_CLIENT_PET_SET_DECK
{
    [ProtoMember(1)]

    public int result { get; set; }
    [ProtoMember(2)]
    public int deck_id { get; set; }
    [ProtoMember(3)]
    public int slot_id { get; set; }
    [ProtoMember(4)]
    public int pet_tid { get; set; }

}

[ProtoContract]
public class CLIENT_GAME_PET_DEL_DECK
{
    [ProtoMember(1)]

    public int deck_id { get; set; }
    [ProtoMember(2)]
    public int slot_id { get; set; }

}

[ProtoContract]
public class GAME_CLIENT_PET_DEL_DECK
{
    [ProtoMember(1)]

    public int result { get; set; }
    [ProtoMember(2)]
    public int deck_id { get; set; }
    [ProtoMember(3)]
    public int slot_id { get; set; }

}

[ProtoContract]
public class CLIENT_GAME_PET_EQUIP_ITEM
{
    [ProtoMember(1)]

    public int pet_tid { get; set; }
    [ProtoMember(2)]
    public int slot_id { get; set; }
    [ProtoMember(3)]
    public ulong item_uid { get; set; }

}

[ProtoContract]
public class GAME_CLIENT_PET_EQUIP_ITEM
{
    [ProtoMember(1)]

    public int result { get; set; }
    [ProtoMember(2)]
    public int pet_tid { get; set; }
    [ProtoMember(3)]
    public int slot_id { get; set; }
    [ProtoMember(4)]
    public ulong item_uid { get; set; }
    [ProtoMember(5)]
    public ulong del_item_uid { get; set; }

}

[ProtoContract]
public class CLIENT_GAME_PET_UNEQUIP_ITEM
{
    [ProtoMember(1)]

    public int pet_tid { get; set; }
    [ProtoMember(2)]
    public int slot_id { get; set; }
    [ProtoMember(3)]
    public ulong item_uid { get; set; }

}

[ProtoContract]
public class GAME_CLIENT_PET_UNEQUIP_ITEM
{
    [ProtoMember(1)]

    public int result { get; set; }
    [ProtoMember(2)]
    public int pet_tid { get; set; }
    [ProtoMember(3)]
    public int slot_id { get; set; }

}

[ProtoContract]
public class GAME_CLIENT_PET_LEADER_CHANGE
{
    [ProtoMember(1)]

    public long user_uid { get; set; }
    [ProtoMember(2)]
    public int pet_tid { get; set; }

}

[ProtoContract]
public class CLIENT_GAME_PET_DECK_CHANGE
{
    [ProtoMember(1)]

    public int deck_id { get; set; }

}

[ProtoContract]
public class GAME_CLIENT_PET_DECK_CHANGE
{
    [ProtoMember(1)]

    public int result { get; set; }
    [ProtoMember(2)]
    public int deck_id { get; set; }

}

[ProtoContract]
public class CLIENT_GAME_PET_UPGRADE
{
    [ProtoMember(1)]

    public int pet_tid { get; set; }

}

[ProtoContract]
public class GAME_CLIENT_PET_UPGRADE
{
    [ProtoMember(1)]

    public int result { get; set; }
    [ProtoMember(2)]
    public int pet_tid { get; set; }
    [ProtoMember(3)]
    public int pte_grade { get; set; }
    [ProtoMember(4)]
    public _stack_item_info[] del_item { get; set; }
    [ProtoMember(5)]
    public _cost_info[] costinfo { get; set; }
    [ProtoMember(6)]
    public int upgrade_result { get; set; }

}

[ProtoContract]
public class CLIENT_GAME_PET_ITEM_TRANCE
{
    [ProtoMember(1)]

    public int pet_tid { get; set; }
    [ProtoMember(2)]
    public int slot_id { get; set; }
    [ProtoMember(3)]
    public ulong trance_item_uid { get; set; }
    [ProtoMember(4)]
    public ulong material_itemuid { get; set; }
    [ProtoMember(5)]
    public bool use_item_add_rate { get; set; }

}

[ProtoContract]
public class GAME_CLIENT_PET_ITEM_TRANCE
{
    [ProtoMember(1)]

    public uint result { get; set; }
    [ProtoMember(2)]
    public uint trance_result { get; set; }
    [ProtoMember(3)]
    _character_inven_item trance_iteminfo { get; set; }
    [ProtoMember(4)]
    public _cost_info[] cost_info { get; set; }
    [ProtoMember(5)]
    public _stack_item_info[] material_items { get; set; }
    [ProtoMember(6)]
    public _character_inven_item[] break_pieces_items { get; set; }
    [ProtoMember(7)]
    public ulong break_item_uid { get; set; }
    [ProtoMember(8)]
    public int pet_tid { get; set; }
    [ProtoMember(9)]
    public int slot_id { get; set; }

}


[ProtoContract]
public class CLIENT_GAME_PK_MODE
{
    [ProtoMember(1)]

    public int pk_mode { get; set; }

}

[ProtoContract]
public class GAME_CLIENT_PK_MODE
{
    [ProtoMember(1)]

    public uint result { get; set; }
    [ProtoMember(2)]
    public int pk_mode { get; set; }

}

[ProtoContract]
public class GAME_CLIENT_PK_ASSAULT
{
    [ProtoMember(1)]

    public ulong uid { get; set; }
    [ProtoMember(2)]
    public int assault { get; set; }
    [ProtoMember(3)]
    public long end_time { get; set; }

}

[ProtoContract]
public class GAME_CLIENT_PK_WINNER_RESULT
{
    [ProtoMember(1)]

    public int pk_grade { get; set; }
    [ProtoMember(2)]
    public int pk_point { get; set; }
    [ProtoMember(3)]
    _cost_info costinfo { get; set; }
    [ProtoMember(4)]
    public ulong targetUid { get; set; }

}

[ProtoContract]
public class GAME_CLIENT_PK_LOSER_RESULT
{
    [ProtoMember(1)]

    _cost_info costinfo { get; set; }
    [ProtoMember(2)]
    public ulong targetUid { get; set; }
    [ProtoMember(3)]
    public _stack_item_info[] steal_item_info_list_ { get; set; }
    [ProtoMember(4)]
    _time_ticket_info time_ticket_info { get; set; }

}

[ProtoContract]
public class GAME_CLIENT_PK_GRADE_UPDATE
{
    [ProtoMember(1)]

    public ulong uid { get; set; }
    [ProtoMember(2)]
    public int pk_grade { get; set; }

}

[ProtoContract]
public class GAME_CLIENT_PK_POINT
{
    [ProtoMember(1)]

    public int pk_point { get; set; }

}

[ProtoContract]
public class CLIENT_GAME_PK_MODE_REQUEST
{
}

[ProtoContract]
public class GAME_CLIENT_PK_MODE_REQUEST
{
    [ProtoMember(1)]

    public int pk_mode { get; set; }

}

[ProtoContract]
public class CLIENT_GAME_PK_HISTORY_LIST
{
    [ProtoMember(1)]

    public int history_page { get; set; }

}

[ProtoContract]
public class GAME_CLIENT_PK_HISTORY_LIST
{
    [ProtoMember(1)]

    public uint result { get; set; }
    [ProtoMember(2)]
    public uint history_page { get; set; }
    [ProtoMember(3)]
    public uint max_num_per_page { get; set; }
    [ProtoMember(4)]
    public _pk_history_info[] pk_history_info { get; set; }
    [ProtoMember(5)]
    public uint daily_kill_count { get; set; }
    [ProtoMember(6)]
    public uint daily_death_count { get; set; }

}

[ProtoContract]
public class CLIENT_GAME_PK_TRACEABLILITY_CHECK
{
    [ProtoMember(1)]

    public ulong event_time { get; set; }
    [ProtoMember(2)]
    public ulong target_uid { get; set; }
    [ProtoMember(3)]
    public uint trace_type { get; set; }

}

[ProtoContract]
public class GAME_CLIENT_PK_TRACEABLILITY_CHECK
{
    [ProtoMember(1)]

    public uint result { get; set; }
    [ProtoMember(2)]
    public uint target_stageid { get; set; }
    [ProtoMember(3)]
    public _vector3 target_position { get; set; }

}

[ProtoContract]
public class CLIENT_GAME_PK_OFFER_A_REWARD
{
    [ProtoMember(1)]

    public ulong event_time { get; set; }
    [ProtoMember(2)]
    public ulong target_uid { get; set; }
    [ProtoMember(3)]
    public ulong reward_cost { get; set; }

}

[ProtoContract]
public class GAME_CLIENT_PK_OFFER_A_REWARD
{
    [ProtoMember(1)]

    public uint result { get; set; }

}

[ProtoContract]
public class CLIENT_GAME_PK_WANTED_LIST
{
    [ProtoMember(1)]

    public uint list_type { get; set; }
    [ProtoMember(2)]
    public uint sort_type { get; set; }
    [ProtoMember(3)]
    public uint page_index { get; set; }

}

[ProtoContract]
public class GAME_CLIENT_PK_WANTED_LIST
{
    [ProtoMember(1)]

    public uint result { get; set; }
    [ProtoMember(2)]
    public uint page_index { get; set; }
    [ProtoMember(3)]
    public _pk_wanted_info[] wanted_list { get; set; }

}

[ProtoContract]
public class CLIENT_GAME_PK_WANTED_REGISTER
{
    [ProtoMember(1)]

    public ulong event_time { get; set; }
    [ProtoMember(2)]
    public ulong wanted_user_uid { get; set; }
    [ProtoMember(3)]
    public uint wanted_prize_type { get; set; }
    [ProtoMember(4)]
    public ulong wanted_prize { get; set; }

}

[ProtoContract]
public class GAME_CLIENT_PK_WANTED_REGISTER
{
    [ProtoMember(1)]

    public uint result { get; set; }
    [ProtoMember(2)]
    public string nickname { get; set; }
    [ProtoMember(3)]
    public uint newregistered { get; set; }
    [ProtoMember(4)]
    public _cost_info[] change_cost_list { get; set; }

}

[ProtoContract]
public class GAME_WORLD_PK_WANTED_REGISTER
{
    [ProtoMember(1)]

    public ulong account_uid { get; set; }
    [ProtoMember(2)]
    public ulong character_uid { get; set; }
    [ProtoMember(3)]
    public ulong event_time { get; set; }
    [ProtoMember(4)]
    public ulong wanted_user_uid { get; set; }
    [ProtoMember(5)]
    public uint wanted_prize_type { get; set; }
    [ProtoMember(6)]
    public ulong wanted_prize { get; set; }
    [ProtoMember(7)]
    public ulong money_result_server { get; set; }
    [ProtoMember(8)]
    public ulong fame_point { get; set; }
    [ProtoMember(9)]
    public _used_cost_info[] change_cost_list { get; set; }

}

[ProtoContract]
public class WORLD_GAME_PK_WANTED_REGISTER
{
    [ProtoMember(1)]

    public ulong register_uid { get; set; }
    [ProtoMember(2)]
    public uint result { get; set; }
    [ProtoMember(3)]
    public ulong wanted_uid { get; set; }
    [ProtoMember(4)]
    public ulong character_uid { get; set; }
    [ProtoMember(5)]
    public string nickname { get; set; }
    [ProtoMember(6)]
    public ulong total_prize { get; set; }
    [ProtoMember(7)]
    public ulong wanted_end_time { get; set; }
    [ProtoMember(8)]
    public uint newregistered { get; set; }
    [ProtoMember(9)]
    public _used_cost_info[] change_cost_list { get; set; }
    [ProtoMember(10)]
    public uint wanted_prize_type { get; set; }
    [ProtoMember(11)]
    public ulong wanted_prize { get; set; }

}

[ProtoContract]
public class WORLD_GAME_PK_INFORM_WANTED_REGISTER
{
    [ProtoMember(1)]

    public ulong wanted_uid { get; set; }
    [ProtoMember(2)]
    public ulong character_uid { get; set; }
    [ProtoMember(3)]
    public string nickname { get; set; }
    [ProtoMember(4)]
    public int cumulative_count { get; set; }
    [ProtoMember(5)]
    public ulong prize_type { get; set; }
    [ProtoMember(6)]
    public ulong total_prize { get; set; }
    [ProtoMember(7)]
    public ulong wanted_end_time { get; set; }

}

[ProtoContract]
public class GAME_WORLD_PK_WANTED_CHARACTER
{
    [ProtoMember(1)]

    public ulong target_uid { get; set; }
    [ProtoMember(2)]
    public ulong character_uid { get; set; }

}

[ProtoContract]
public class WORLD_GAME_PK_WANTED_CHARACTER
{
    [ProtoMember(1)]

    public uint result { get; set; }
    [ProtoMember(2)]
    public ulong character_uid { get; set; }
    [ProtoMember(3)]
    public ulong target_uid { get; set; }

}

[ProtoContract]
public class GAME_WORLD_INFROM_PK_WANTED_CHARACTER
{
    [ProtoMember(1)]

    public ulong target_uid { get; set; }
    [ProtoMember(2)]
    public uint wanted_state { get; set; }
    [ProtoMember(3)]
    public uint end_type { get; set; }

}

[ProtoContract]
public class WORLD_GAME_INFROM_PK_WANTED_CHARACTER
{
    [ProtoMember(1)]

    public ulong target_uid { get; set; }
    [ProtoMember(2)]
    public uint wanted_state { get; set; }
    [ProtoMember(3)]
    public uint end_type { get; set; }

}

[ProtoContract]
public class GAME_CLIENT_PK_INFORM_MODIRY_WANTED_STATE
{
    [ProtoMember(1)]

    public ulong target_uid { get; set; }
    [ProtoMember(2)]
    public uint wanted_state { get; set; }

}

[ProtoContract]
public class GAME_CLIENT_DEATH_PENALTY_INFO
{
    [ProtoMember(1)]

    public int steal_getobject_limit_count { get; set; }
    [ProtoMember(2)]
    public int steal_getobject_limit_max_count { get; set; }
    [ProtoMember(3)]
    public int exp_free_recovery_count { get; set; }
    [ProtoMember(4)]
    public int exp_free_recovery_maxcount { get; set; }

}

[ProtoContract]
public class CLIENT_GAME_DEATH_PENALTY_LIST
{

}

[ProtoContract]
public class GAME_CLIENT_DEATH_PENALTY_LIST
{
    [ProtoMember(1)]

    public death_penalty_info[] death_penalty_list { get; set; }

}

[ProtoContract]
public class GAME_CLIENT_DEATH_PENALTY_ADD
{
    [ProtoMember(1)]

    death_penalty_info death_penalty_add { get; set; }

}

[ProtoContract]
public class GAME_CLIENT_DEATH_PENALTY_DEL
{
    [ProtoMember(1)]

    public ulong death_penalty_uid { get; set; }

}

[ProtoContract]
public class GAME_WORLD_DEATH_PENALTY_DEL
{
    [ProtoMember(1)]

    public ulong death_penalty_uid { get; set; }
    [ProtoMember(2)]
    public ulong user_uid { get; set; }

}

[ProtoContract]
public class WORLD_GAME_DEATH_PENALTY_DEL
{
    [ProtoMember(1)]

    public ulong death_penalty_uid { get; set; }
    [ProtoMember(2)]
    public ulong user_uid { get; set; }

}

[ProtoContract]
public class CLIENT_GAME_DEATH_PENALTY_GET_EXP
{
    [ProtoMember(1)]

    public ulong death_penalty_uid { get; set; }
    [ProtoMember(2)]
    public int recovery_type { get; set; }

}

[ProtoContract]
public class GAME_CLIENT_DEATH_PENALTY_GET_EXP
{
    [ProtoMember(1)]

    public ulong result { get; set; }
    [ProtoMember(2)]
    public ulong death_penalty_uid { get; set; }
    [ProtoMember(3)]
    public long add_exp { get; set; }
    [ProtoMember(4)]
    public _used_cost_info[] change_cost_list { get; set; }
    [ProtoMember(5)]
    public _stack_item_info[] del_item_list { get; set; }
    [ProtoMember(6)]
    public int recovery_type { get; set; }

}

[ProtoContract]
public class GAME_WORLD_DEATH_PENALTY_DISABLED
{
    [ProtoMember(1)]

    public ulong death_penalty_uid { get; set; }
    [ProtoMember(2)]
    public ulong user_uid { get; set; }

}

[ProtoContract]
public class WORLD_GAME_DEATH_PENALTY_DISABLED
{
    [ProtoMember(1)]

    public ulong death_penalty_uid { get; set; }
    [ProtoMember(2)]
    public ulong user_uid { get; set; }

}

[ProtoContract]
public class GAME_CLIENT_DEATH_PENALTY_DISABLED
{
    [ProtoMember(1)]

    public ulong death_penalty_uid { get; set; }

}

[ProtoContract]
public class GAME_CLIENT_DEATH_PENALTY_RECOVERY_COMPLETED
{
    [ProtoMember(1)]

    public ulong death_penalty_uid { get; set; }

}

[ProtoContract]
public class CLIENT_GAME_DEATH_PENALTY_DEL
{
    [ProtoMember(1)]

    public ulong death_penalty_uid { get; set; }

}

[ProtoContract]
public class _playlog_pk_user_info
{
    [ProtoMember(1)]

    public long user_uid { get; set; }
    [ProtoMember(2)]
    public int class_id { get; set; }
    [ProtoMember(3)]
    public string nick_name { get; set; }
    [ProtoMember(4)]
    public int combat_point { get; set; }

}

[ProtoContract]
public class GAME_CLIENT_PLAYLOG_PK_RESULT
{
    [ProtoMember(1)]

    public ulong log_time { get; set; }
    [ProtoMember(2)]
    public bool win_result { get; set; }
    [ProtoMember(3)]
    _playlog_pk_user_info target_info { get; set; }
    [ProtoMember(4)]
    _guild_name_ui_info target_guild_info { get; set; }
    [ProtoMember(5)]
    _simple_cost_info loss_cost_info { get; set; }
    [ProtoMember(6)]
    public _simple_item_info[] loss_item_info_list { get; set; }

}

[ProtoContract]
public class CLIENT_GAME_POTENTIAL_UPGRADE
{
    [ProtoMember(1)]

    public uint potential_id { get; set; }

}

[ProtoContract]
public class GAME_CLIENT_POTENTIAL_UPGRADE
{
    [ProtoMember(1)]

    public int result { get; set; }
    [ProtoMember(2)]
    _potential_info potential_info { get; set; }
    [ProtoMember(3)]
    public bool is_levelup_fail { get; set; }
    [ProtoMember(4)]
    public _cost_info[] cost_info { get; set; }
    [ProtoMember(5)]
    public _stack_item_info[] update_items { get; set; }

}

[ProtoContract]
public class GAME_CLIENT_POTENTIAL_UPGRADE_NOTI
{
    [ProtoMember(1)]

    public string nickname { get; set; }
    [ProtoMember(2)]
    public int potential_id { get; set; }
    [ProtoMember(3)]
    public int level_id { get; set; }

}


[ProtoContract]
public class CLIENT_GAME_QUEST_ACTION
{
    [ProtoMember(1)]

    public int quest_index { get; set; }
    [ProtoMember(2)]
    public int action { get; set; }
    [ProtoMember(3)]
    public int flag { get; set; }

}

[ProtoContract]
public class GAME_CLIENT_UPDATE_QUEST
{
    [ProtoMember(1)]

    public int quest_index { get; set; }
    [ProtoMember(2)]
    public int state { get; set; }

}

[ProtoContract]
public class CLIENT_GAME_START_QUEST
{
    [ProtoMember(1)]

    public ulong uid { get; set; }
    [ProtoMember(2)]
    public int QuestIndex { get; set; }

}

[ProtoContract]
public class GAME_CLIENT_START_QUEST
{
    [ProtoMember(1)]

    public int result { get; set; }
    [ProtoMember(2)]
    public _character_quest questinfo { get; set; }

}

[ProtoContract]
public class CLIENT_GAME_END_QUEST
{
    [ProtoMember(1)]

    public ulong uid { get; set; }
    [ProtoMember(2)]
    public int QuestIndex { get; set; }

}

[ProtoContract]
public class GAME_CLIENT_END_QUEST
{
    [ProtoMember(1)]

    public int result { get; set; }
    [ProtoMember(2)]
    public int endquestindex { get; set; }
    [ProtoMember(3)]
    public int currentLevel { get; set; }
    [ProtoMember(4)]
    public _cost_info[] costInfos { get; set; }
    [ProtoMember(5)]
    public _character_inven_item[] rewardItem { get; set; }
    [ProtoMember(6)]
    public _character_quest[] questinfos { get; set; }
    [ProtoMember(7)]
    public ulong exp { get; set; }
    [ProtoMember(8)]
    public int quest_type { get; set; }

}

[ProtoContract]
public class CLIENT_GAME_COMPLETE_QUEST
{
    [ProtoMember(1)]

    public int QuestIndex { get; set; }
    [ProtoMember(2)]
    public int quest_type { get; set; }

}

[ProtoContract]
public class GAME_CLIENT_COMPLETE_QUEST
{
    [ProtoMember(1)]

    public int QuestIndex { get; set; }
    [ProtoMember(2)]
    public int quest_type { get; set; }

}

[ProtoContract]
public class GAME_CLIENT_CHANGE_QUEST_COUNTER
{
    [ProtoMember(1)]

    public int quest_index { get; set; }
    [ProtoMember(2)]
    public int count { get; set; }
    [ProtoMember(3)]
    public int quest_type { get; set; }

}

[ProtoContract]
public class GAME_CLIENT_DELETE_QUEST
{
    [ProtoMember(1)]

    public ulong uid { get; set; }
    [ProtoMember(2)]
    public int delete_quest_id { get; set; }

}

[ProtoContract]
public class GAME_CLIENT_FAILED_QUEST
{
    [ProtoMember(1)]

    public int quest_index { get; set; }

}

[ProtoContract]
public class CLIENT_GAME_FAILED_QUEST_CONFIRM
{
    [ProtoMember(1)]

    public int quest_index { get; set; }

}

[ProtoContract]
public class GAME_CLIENT_ADD_SUBQUEST
{
    [ProtoMember(1)]

    public int quest_index { get; set; }
    [ProtoMember(2)]
    public int tracker { get; set; }

}

[ProtoContract]
public class CLIENT_GAME_ACCEPT_SUBQUEST
{
    [ProtoMember(1)]

    public int quest_index { get; set; }
    [ProtoMember(2)]
    public int quest_type { get; set; }

}

[ProtoContract]
public class CLIENT_GAME_COMMIT_SUBQUEST
{
    [ProtoMember(1)]

    public int quest_index { get; set; }
    [ProtoMember(2)]
    public int quest_type { get; set; }

}

[ProtoContract]
public class GAME_CLIENT_COMMIT_SUBQUEST
{
    [ProtoMember(1)]

    public int quest_index { get; set; }
    [ProtoMember(2)]
    public int result { get; set; }
    [ProtoMember(3)]
    public int state { get; set; }

}

[ProtoContract]
public class CLIENT_GAME_CANCEL_SUBQUEST
{
    [ProtoMember(1)]

    public int quest_index { get; set; }

}

[ProtoContract]
public class GAME_CLIENT_CANCEL_SUBQUEST
{
    [ProtoMember(1)]

    public int quest_index { get; set; }
    [ProtoMember(2)]
    public int result { get; set; }

}

[ProtoContract]
public class CLIENT_GAME_START_PHASING_QUEST
{
    [ProtoMember(1)]

    public int quest_index { get; set; }

}

[ProtoContract]
public class CLIENT_GAME_END_PHASING_QUEST
{
    [ProtoMember(1)]

    public int quest_index { get; set; }
    [ProtoMember(2)]
    public _vector3 pos { get; set; }
    [ProtoMember(3)]
    public int flag { get; set; }
    [ProtoMember(4)]
    public int success { get; set; }

}

[ProtoContract]
public class GAME_CLIENT_RESET_REPEAT_QUEST
{
    [ProtoMember(1)]

    public int[] quest_indexs { get; set; }

}

[ProtoContract]
public class CLIENT_GAME_REWARD_DAILYHOMEWORK_PLUSREWARD
{
    [ProtoMember(1)]

    public int count { get; set; }

}

[ProtoContract]
public class GAME_CLIENT_REWARD_DAILYHOMEWORK_PLUSREWARD
{
    [ProtoMember(1)]

    public int result { get; set; }
    [ProtoMember(2)]
    public _cost_info[] costInfos { get; set; }
    [ProtoMember(3)]
    public int count { get; set; }
    [ProtoMember(4)]
    public _character_inven_item[] rewardItem { get; set; }

}

[ProtoContract]
public class CLIENT_GAME_COMPLETEALL_DAILYHOMEWORK
{
}

[ProtoContract]
public class GAME_CLIENT_COMPLETEALL_DAILYHOMEWORK
{
    [ProtoMember(1)]

    public int result { get; set; }
    [ProtoMember(2)]
    public int[] endquestindexs { get; set; }
    [ProtoMember(3)]
    public _cost_info[] costInfos { get; set; }
    [ProtoMember(4)]
    public _character_inven_item[] rewardItems { get; set; }

}

[ProtoContract]
public class GAME_CLIENT_ADD_RELATION_QUEST
{
    [ProtoMember(1)]

    public int quest_index { get; set; }

}

[ProtoContract]
public class GAME_CLIENT_QUEST_ACTION_RESULT
{
    [ProtoMember(1)]

    public int quest_index { get; set; }
    [ProtoMember(2)]
    public int result { get; set; }

}

[ProtoContract]
public class GAME_CLIENT_ENDQUEST_RELATION
{
    [ProtoMember(1)]

    public int index { get; set; }
    [ProtoMember(2)]
    public int state { get; set; }
    [ProtoMember(3)]
    public int currentLevel { get; set; }
    [ProtoMember(4)]
    public _cost_info[] costInfos { get; set; }
    [ProtoMember(5)]
    public _character_inven_item[] rewardItem { get; set; }
    [ProtoMember(6)]
    public ulong exp { get; set; }
    [ProtoMember(7)]
    public int result { get; set; }

}

[ProtoContract]
public class CLIENT_GAME_START_QUEST_CINEMATIC
{
    [ProtoMember(1)]

    public int quest_index { get; set; }
    [ProtoMember(2)]
    public int cinematic_type { get; set; }
    [ProtoMember(3)]
    public int cinematic_id { get; set; }

}

[ProtoContract]
public class CLIENT_GAME_END_QUEST_CINEMATIC
{
    [ProtoMember(1)]

    public int quest_index { get; set; }

}

[ProtoContract]
public class CLIENT_GAME_QUEST_NPC_TALK
{
    [ProtoMember(1)]

    public int quest_index { get; set; }

}

[ProtoContract]
public class GAME_CLIENT_QUEST_NPC_TALK
{
    [ProtoMember(1)]

    public int quest_index { get; set; }
    [ProtoMember(2)]
    public int result { get; set; }

}

[ProtoContract]
public class GAME_CLIENT_ADD_QUEST_REQUEST
{
    [ProtoMember(1)]

    public int quest_index { get; set; }
    [ProtoMember(2)]
    public int state { get; set; }
    [ProtoMember(3)]
    public int seq { get; set; }

}

[ProtoContract]
public class GAME_CLIENT_ENDQUEST_REQUEST
{
    [ProtoMember(1)]

    public int index { get; set; }
    [ProtoMember(2)]
    public int state { get; set; }
    [ProtoMember(3)]
    public int currentLevel { get; set; }
    [ProtoMember(4)]
    public _cost_info[] costInfos { get; set; }
    [ProtoMember(5)]
    public _character_inven_item[] rewardItem { get; set; }
    [ProtoMember(6)]
    public ulong exp { get; set; }
    [ProtoMember(7)]
    public int result { get; set; }

}

[ProtoContract]
public class GAME_CLIENT_ADD_QUEST_COOPERATION
{
    [ProtoMember(1)]

    public int quest_index { get; set; }
    [ProtoMember(2)]
    public int state { get; set; }

}

[ProtoContract]
public class GAME_CLIENT_ENDQUEST_COOPERATION
{
    [ProtoMember(1)]

    public int index { get; set; }
    [ProtoMember(2)]
    public int state { get; set; }
    [ProtoMember(3)]
    public _cost_info[] costInfos { get; set; }
    [ProtoMember(4)]
    public _character_inven_item[] rewardItem { get; set; }
    [ProtoMember(5)]
    public int clearcnt { get; set; }
    [ProtoMember(6)]
    public int weekclearcnt { get; set; }
    [ProtoMember(7)]
    public int guild_point { get; set; }
    [ProtoMember(8)]
    public int result { get; set; }

}

[ProtoContract]
public class GAME_CLIENT_ENDQUEST_GUILD_DAILY_MISSION
{
    [ProtoMember(1)]

    public int index { get; set; }
    [ProtoMember(2)]
    public int state { get; set; }
    [ProtoMember(3)]
    public int currentLevel { get; set; }
    [ProtoMember(4)]
    public _cost_info[] costInfos { get; set; }
    [ProtoMember(5)]
    public _character_inven_item[] rewardItem { get; set; }
    [ProtoMember(6)]
    public ulong exp { get; set; }
    [ProtoMember(7)]
    public int clearcnt { get; set; }
    [ProtoMember(8)]
    public int result { get; set; }

}

[ProtoContract]
public class CLIENT_GAME_ENDQUEST_RELATION_PLUSREWARD
{
    [ProtoMember(1)]

    public int reward_index { get; set; }

}

[ProtoContract]
public class GAME_CLIENT_ENDQUEST_RELATION_PLUSREWARD
{
    [ProtoMember(1)]

    public int index { get; set; }
    [ProtoMember(2)]
    public int state { get; set; }
    [ProtoMember(3)]
    public int currentLevel { get; set; }
    [ProtoMember(4)]
    public _cost_info[] costInfos { get; set; }
    [ProtoMember(5)]
    public _character_inven_item[] rewardItem { get; set; }
    [ProtoMember(6)]
    public ulong exp { get; set; }
    [ProtoMember(7)]
    public int result { get; set; }

}

[ProtoContract]
public class CLIENT_GAME_QUEST_TRACKER
{
    [ProtoMember(1)]

    public int quest_index { get; set; }
    [ProtoMember(2)]
    public int action { get; set; }
    [ProtoMember(3)]
    public int flag { get; set; }

}

[ProtoContract]
public class GAME_CLIENT_QUEST_TRACKER
{
    [ProtoMember(1)]

    public int quest_index { get; set; }
    [ProtoMember(2)]
    public int result { get; set; }

}

[ProtoContract]
public class CLIENT_GAME_ENDQUEST_GUILD_DAILY_ALL_MISSION
{

}

[ProtoContract]
public class GAME_CLIENT_ENDQUEST_GUILD_DAILY_ALL_MISSION
{
    [ProtoMember(1)]

    public int[] indexs { get; set; }
    [ProtoMember(2)]
    public int[] states { get; set; }
    [ProtoMember(3)]
    public _cost_info[] costInfos { get; set; }
    [ProtoMember(4)]
    public _character_inven_item[] rewardItem { get; set; }
    [ProtoMember(5)]
    public int[] clearcnts { get; set; }
    [ProtoMember(6)]
    public int result { get; set; }

}


[ProtoContract]
public class CLIENT_GAME_RANKING_INFO
{
    [ProtoMember(1)]

    public uint rankingtype { get; set; }
    [ProtoMember(2)]
    public uint request_character_info { get; set; }

}

[ProtoContract]
public class GAME_CLIENT_RANKING_INFO
{
    [ProtoMember(1)]

    public uint result { get; set; }
    [ProtoMember(2)]
    public uint rankingtype { get; set; }
    [ProtoMember(3)]
    public uint myrank { get; set; }
    [ProtoMember(4)]
    public uint[] ranking_schedule_id { get; set; }
    [ProtoMember(5)]
    public uint current_ranking_value { get; set; }
    [ProtoMember(6)]
    public uint current_value { get; set; }

}

[ProtoContract]
public class GAME_CLIENT_CHARACTER_RANKING_INFO
{
    [ProtoMember(1)]

    public _ranking_info[] ranking_info { get; set; }

}

[ProtoContract]
public class GAME_CLIENT_GUILD_RANKING_INFO
{
    [ProtoMember(1)]

    public _guild_ranking_info[] guild_ranking_info { get; set; }

}

[ProtoContract]
public class WORLD_GAME_CALCULATE_RANKING
{
    [ProtoMember(1)]

    public uint calculatation_state { get; set; }
    [ProtoMember(2)]
    public uint pk_season_end { get; set; }
    [ProtoMember(3)]
    public uint pk_season_start { get; set; }
    [ProtoMember(4)]
    public uint portrait_event_state { get; set; }

}

[ProtoContract]
public class GAME_CLIENT_CALCULATE_RANKING
{
    [ProtoMember(1)]

    public uint calculatation_state { get; set; }
    [ProtoMember(2)]
    public uint reset_pk_score { get; set; }

}

[ProtoContract]
public class GAME_WORLD_GET_RANKING_REWARD
{
    [ProtoMember(1)]

    public ulong characteruid { get; set; }
    [ProtoMember(2)]
    public uint rankingtype { get; set; }
    [ProtoMember(3)]
    public uint weeklyreward { get; set; }
    [ProtoMember(4)]
    public uint seasonreward { get; set; }
    [ProtoMember(5)]
    public uint dailyreward { get; set; }

}

[ProtoContract]
public class WORLD_GAME_GET_RANKING_REWARD
{
    [ProtoMember(1)]

    public ulong characteruid { get; set; }
    [ProtoMember(2)]
    public uint rankingtype { get; set; }
    [ProtoMember(3)]
    public uint weeklyreward { get; set; }
    [ProtoMember(4)]
    public uint seasonreward { get; set; }
    [ProtoMember(5)]
    public uint dailyreward { get; set; }

}

[ProtoContract]
public class GAME_WORLD_FINISHED_LOAD_RANKING_INFO
{
    [ProtoMember(1)]

    public uint pk_season_end { get; set; }
    [ProtoMember(2)]
    public uint pk_season_start { get; set; }
    [ProtoMember(3)]
    public uint weekly_settlement { get; set; }

}

[ProtoContract]
public class WORLD_GAME_FINISHED_LOAD_RANKING_INFO
{
    [ProtoMember(1)]

    public uint pk_season_end { get; set; }
    [ProtoMember(2)]
    public uint pk_season_start { get; set; }
    [ProtoMember(3)]
    public uint weekly_settlement { get; set; }

}

[ProtoContract]
public class WORLD_GAME_FINISHED_RANKING_SETTLEMENT
{
    [ProtoMember(1)]

    public uint is_local_time_use { get; set; }

}

[ProtoContract]
public class WORLD_GAME_RANKING_LOAD
{
    [ProtoMember(1)]

    public uint pk_season_end { get; set; }
    [ProtoMember(2)]
    public uint weekly_settlement { get; set; }
    [ProtoMember(3)]
    public uint server_start { get; set; }

}

[ProtoContract]
public class CLIENT_GAME_GET_RANKING_REWARD
{
    [ProtoMember(1)]

    public uint rankingtype { get; set; }

}

[ProtoContract]
public class GAME_CLIENT_GET_RANKING_REWARD
{
    [ProtoMember(1)]

    public uint result { get; set; }
    [ProtoMember(2)]
    public uint rankingtype { get; set; }
    [ProtoMember(3)]
    public _cost_info[] cost_info { get; set; }
    [ProtoMember(4)]
    public _character_inven_item[] item_info { get; set; }
    [ProtoMember(5)]
    public _cost_info[] reward_cost_info { get; set; }
    [ProtoMember(6)]
    public _simple_item_info[] reward_item_info { get; set; }

}

[ProtoContract]
public class GAME_CLIENT_RANKING_REWARD_NOTIFICATION
{
    [ProtoMember(1)]

    public uint rankingtype { get; set; }
    [ProtoMember(2)]
    public uint reward_available { get; set; }

}

[ProtoContract]
public class CLIENT_GAME_RANKING_FOR_MY_INFO
{
}

[ProtoContract]
public class GAME_CLIENT_RANKING_FOR_MY_INFO
{
    [ProtoMember(1)]

    public uint result { get; set; }
    [ProtoMember(2)]
    public uint level { get; set; }
    [ProtoMember(3)]
    public uint combat_point { get; set; }
    [ProtoMember(4)]
    public uint item_collection { get; set; }
    [ProtoMember(5)]
    public uint guild { get; set; }

}

[ProtoContract]
public class CLIENT_WORLD_SEARCH
{
    [ProtoMember(1)]

    public int search_type { get; set; }
    [ProtoMember(2)]
    public int request_page { get; set; }
    [ProtoMember(3)]
    public string search_string { get; set; }
    [ProtoMember(4)]
    public int ui_type { get; set; }
    [ProtoMember(5)]
    public int world_id { get; set; }
    [ProtoMember(6)]
    public int receive_money_limit_type { get; set; }

}

[ProtoContract]
public class WORLD_CLIENT_SEARCH_GUILD
{
    [ProtoMember(1)]

    public int request_page { get; set; }
    [ProtoMember(2)]
    public string search_string { get; set; }
    [ProtoMember(3)]
    public _guild_search_info[] search_info { get; set; }
    [ProtoMember(4)]
    public int world_id { get; set; }
    [ProtoMember(5)]
    public int ui_type { get; set; }

}

[ProtoContract]
public class WORLD_CLIENT_SEARCH_CHARACTER
{
    [ProtoMember(1)]

    public int request_page { get; set; }
    [ProtoMember(2)]
    public string search_string { get; set; }
    [ProtoMember(3)]
    public _character_search_info[] search_info { get; set; }
    [ProtoMember(4)]
    public int ui_type { get; set; }
    [ProtoMember(5)]
    public int world_id { get; set; }

}


[ProtoContract]
public class CLIENT_GAME_ENTER_SECRET_DUNGEON
{
    [ProtoMember(1)]

    public uint enter_secret_dungeon_id { get; set; }

}

[ProtoContract]
public class GAME_WORLD_ENTER_SECRET_DUNGEON
{
    [ProtoMember(1)]

    public uint enter_secret_dungeon_id { get; set; }

}

[ProtoContract]
public class CLIENT_GAME_LEAVE_SECRET_DUNGEON
{

}

[ProtoContract]
public class GAME_WORLD_LEAVE_SECRET_DUNGEON
{
    [ProtoMember(1)]

    public ulong cur_zone_unique { get; set; }

}

[ProtoContract]
public class GAME_WORLD_REQUEST_SECRET_DUNGEON_EXIT_TIME
{

}

[ProtoContract]
public class WORLD_GAME_NOTIFY_SECRET_DUNGEON_EXIT_TIME
{
    [ProtoMember(1)]

    public ulong request_user_uid { get; set; }
    [ProtoMember(2)]
    public ulong exit_time { get; set; }

}

[ProtoContract]
public class GAME_CLIENT_SECRET_DUNGEON_EXIT_TIME
{
    [ProtoMember(1)]

    public ulong exit_time { get; set; }

}

[ProtoContract]
public class CLIENT_GAME_SECRET_DUNGEON_TIME_EXTEND
{
}

[ProtoContract]
public class GAME_CLIENT_SECRET_DUNGEON_TIME_EXTEND
{
    [ProtoMember(1)]

    public uint result { get; set; }
    [ProtoMember(2)]
    public ulong exit_time { get; set; }
    [ProtoMember(3)]
    _dungeon_ticket_info dungeon_ticket_info { get; set; }

}

[ProtoContract]
public class GAME_WORLD_SECRET_DUNGEON_TIME_EXTEND
{

}

[ProtoContract]
public class WORLD_GAME_SECRET_DUNGEON_TIME_EXTEND
{
    [ProtoMember(1)]
    public uint result { get; set; }
    [ProtoMember(2)]
    public ulong user_uid { get; set; }
    [ProtoMember(3)]
    public ulong exit_time { get; set; }

}


[ProtoContract]
public class _ServerChangeInfo
{
    [ProtoMember(1)]
    public uint world_id { get; set; }
    [ProtoMember(2)]
    public string world_name { get; set; }
    [ProtoMember(3)]
    public bool server_change { get; set; }
    [ProtoMember(4)]
    public int character_count { get; set; }
    [ProtoMember(5)]
    public uint regionid { get; set; }
    [ProtoMember(6)]
    public uint region { get; set; }
    [ProtoMember(7)]
    public uint nft_server { get; set; }

}

[ProtoContract]
public class CLIENT_GAME_SERVER_CHANGE_LIST
{

}

[ProtoContract]
public class GAME_CLIENT_SERVER_CHANGE_LIST
{
    [ProtoMember(1)]

    public int[] world_id_list { get; set; }

}

[ProtoContract]
public class CLIENT_GAME_SERVER_CHANGE_WORLD_LIST
{
}

[ProtoContract]
public class GAME_CLIENT_SERVER_CHANGE_WORLD_LIST
{
    [ProtoMember(1)]

    public uint current_world_id { get; set; }
    [ProtoMember(2)]
    public _ServerChangeInfo[] world_list { get; set; }
    [ProtoMember(3)]
    public bool is_server_expedition { get; set; }
    [ProtoMember(4)]
    public long siege_use_time { get; set; }

}

[ProtoContract]
public class CLIENT_GAME_SERVER_CHANGE_START
{
    [ProtoMember(1)]

    public int target_world_id { get; set; }

}

[ProtoContract]
public class GAME_CLIENT_SERVER_CHANGE_START
{
    [ProtoMember(1)]

    public int result { get; set; }
    [ProtoMember(2)]
    public int target_world_id { get; set; }
    [ProtoMember(3)]
    public _cost_info[] use_cost_list { get; set; }

}

[ProtoContract]
public class CLIENT_GAME_SERVER_CHANGE_STATE
{

}

[ProtoContract]
public class GAME_CLIENT_SERVER_CHANGE_STATE
{
    [ProtoMember(1)]

    public int state { get; set; }
    [ProtoMember(2)]
    public long prev_change_time_sec { get; set; }

}

[ProtoContract]
public class GAME_WORLD_SERVER_CHANGE_START
{
    [ProtoMember(1)]

    public ulong account_uid { get; set; }
    [ProtoMember(2)]
    public ulong character_uid { get; set; }
    [ProtoMember(3)]
    public uint cur_world_id { get; set; }
    [ProtoMember(4)]
    public uint next_world_id { get; set; }
    [ProtoMember(5)]
    public uint level { get; set; }
    [ProtoMember(6)]
    public bool nft_flag { get; set; }
    [ProtoMember(7)]
    public ulong nft_token_id { get; set; }
    [ProtoMember(8)]
    _contract_transaction_info contract_transaction_info { get; set; }
    [ProtoMember(10)]
    public _stat_info[] stat_info_list { get; set; }
    [ProtoMember(11)]
    public _characterInfo_mint characterInfo_mint { get; set; }

}

[ProtoContract]
public class GAME_TRADE_SERVER_CHANGE_CHECK
{
    [ProtoMember(1)]

    public ulong account_uid { get; set; }
    [ProtoMember(2)]
    public ulong character_uid { get; set; }
    [ProtoMember(3)]
    public uint cur_world_id { get; set; }
    [ProtoMember(4)]
    public uint next_world_id { get; set; }
    [ProtoMember(5)]
    public bool check_register { get; set; }
    [ProtoMember(6)]
    public bool check_close { get; set; }
    [ProtoMember(7)]
    public bool check_calculate { get; set; }

}

[ProtoContract]
public class TRADE_GAME_SERVER_CHANGE_CHECK
{
    [ProtoMember(1)]

    public int result { get; set; }
    [ProtoMember(2)]
    public ulong account_uid { get; set; }
    [ProtoMember(3)]
    public ulong character_uid { get; set; }
    [ProtoMember(4)]
    public uint cur_world_id { get; set; }
    [ProtoMember(5)]
    public uint next_world_id { get; set; }

}

[ProtoContract]
public class GAME_SHOP_SERVER_CHANGE_CHECK
{
    [ProtoMember(1)]

    public ulong account_uid { get; set; }
    [ProtoMember(2)]
    public ulong character_uid { get; set; }
    [ProtoMember(3)]
    public uint cur_world_id { get; set; }
    [ProtoMember(4)]
    public uint next_world_id { get; set; }

}

[ProtoContract]
public class SHOP_GAME_SERVER_CHANGE_CHECK
{
    [ProtoMember(1)]

    public int result { get; set; }
    [ProtoMember(2)]
    public ulong account_uid { get; set; }
    [ProtoMember(3)]
    public ulong character_uid { get; set; }
    [ProtoMember(4)]
    public uint cur_world_id { get; set; }
    [ProtoMember(5)]
    public uint next_world_id { get; set; }

}

[ProtoContract]
public class GAME_SHOP_SERVER_CHANGE_CLEAR_STORAGE
{
    [ProtoMember(1)]

    public ulong character_uid { get; set; }

}

[ProtoContract]
public class GAME_WORLD_SERVER_CHANGE_CHECK
{
    [ProtoMember(1)]

    public ulong account_uid { get; set; }
    [ProtoMember(2)]
    public ulong character_uid { get; set; }
    [ProtoMember(3)]
    public uint cur_world_id { get; set; }
    [ProtoMember(4)]
    public uint next_world_id { get; set; }
    [ProtoMember(5)]
    public bool check_register { get; set; }
    [ProtoMember(6)]
    public bool check_get { get; set; }

}

[ProtoContract]
public class WORLD_GAME_SERVER_CHANGE_CHECK
{
    [ProtoMember(1)]

    public int result { get; set; }
    [ProtoMember(2)]
    public ulong account_uid { get; set; }
    [ProtoMember(3)]
    public ulong character_uid { get; set; }
    [ProtoMember(4)]
    public uint cur_world_id { get; set; }
    [ProtoMember(5)]
    public uint next_world_id { get; set; }

}

[ProtoContract]
public class WORLD_WORLDLINK_SERVER_CHANGE_CHECK
{
    [ProtoMember(1)]

    public ulong account_uid { get; set; }
    [ProtoMember(2)]
    public ulong character_uid { get; set; }
    [ProtoMember(3)]
    public uint cur_world_id { get; set; }
    [ProtoMember(4)]
    public uint next_world_id { get; set; }
    [ProtoMember(5)]
    public uint zone_group { get; set; }

}

[ProtoContract]
public class WORLDLINK_WORLD_SERVER_CHANGE_CHECK
{
    [ProtoMember(1)]

    public int result { get; set; }
    [ProtoMember(2)]
    public ulong account_uid { get; set; }
    [ProtoMember(3)]
    public ulong character_uid { get; set; }
    [ProtoMember(4)]
    public uint cur_world_id { get; set; }
    [ProtoMember(5)]
    public uint next_world_id { get; set; }
    [ProtoMember(6)]
    public uint zone_group { get; set; }

}

[ProtoContract]
public class WORLDLINK_FRONT_SERVER_CHANGE_CHECK
{
    [ProtoMember(1)]

    public ulong account_uid { get; set; }
    [ProtoMember(2)]
    public ulong character_uid { get; set; }
    [ProtoMember(3)]
    public uint cur_world_id { get; set; }
    [ProtoMember(4)]
    public uint next_world_id { get; set; }
    [ProtoMember(5)]
    public uint zone_group { get; set; }

}

[ProtoContract]
public class FRONT_WORLDLINK_SERVER_CHANGE_CHECK
{
    [ProtoMember(1)]

    public int result { get; set; }
    [ProtoMember(2)]
    public ulong account_uid { get; set; }
    [ProtoMember(3)]
    public ulong character_uid { get; set; }
    [ProtoMember(4)]
    public uint cur_world_id { get; set; }
    [ProtoMember(5)]
    public uint next_world_id { get; set; }
    [ProtoMember(6)]
    public uint zone_group { get; set; }

}

[ProtoContract]
public class _WorldBossInfo
{
    [ProtoMember(1)]

    public uint monster_tid { get; set; }
    [ProtoMember(2)]
    public long activate_time { get; set; }

}

[ProtoContract]
public class _ServerExpeditionInfo
{
    [ProtoMember(1)]

    public uint world_id { get; set; }
    [ProtoMember(2)]
    public string world_name { get; set; }
    [ProtoMember(3)]
    public bool expedition_start { get; set; }
    [ProtoMember(4)]
    public bool expedition_destination { get; set; }
    [ProtoMember(5)]
    public int character_count { get; set; }
    [ProtoMember(6)]
    public int users { get; set; }
    [ProtoMember(7)]
    public int max_users { get; set; }
    [ProtoMember(8)]
    public _WorldBossInfo[] world_boss_list { get; set; }
    [ProtoMember(9)]
    public bool plunder_possible { get; set; }
    [ProtoMember(10)]
    public int nft_server { get; set; }

}

[ProtoContract]
public class CLIENT_GAME_SERVER_EXPEDITION_INFO
{

}

[ProtoContract]
public class GAME_CLIENT_SERVER_EXPEDITION_INFO
{
    [ProtoMember(1)]

    public uint dest_world_id { get; set; }
    [ProtoMember(2)]
    public long departure_time { get; set; }
    [ProtoMember(3)]
    public uint guild_rank { get; set; }
    [ProtoMember(4)]
    public int life_count { get; set; }
    [ProtoMember(5)]
    public long expedition_start_time { get; set; }
    [ProtoMember(6)]
    public long expedition_end_time { get; set; }
    [ProtoMember(7)]
    public bool assassin_mode_used_item { get; set; }

}

[ProtoContract]
public class CLIENT_GAME_SERVER_EXPEDITION_WORLD_LIST
{
}

[ProtoContract]
public class GAME_CLIENT_SERVER_EXPEDITION_WORLD_LIST
{
    [ProtoMember(1)]

    public uint current_world_id { get; set; }
    [ProtoMember(2)]
    public _ServerExpeditionInfo[] expedition_list { get; set; }

}

[ProtoContract]
public class CLIENT_GAME_SERVER_EXPEDITION_START
{
    [ProtoMember(1)]

    public int target_world_id { get; set; }
    [ProtoMember(2)]
    public bool assassin_mode { get; set; }

}

[ProtoContract]
public class GAME_CLIENT_SERVER_EXPEDITION_START
{
    [ProtoMember(1)]

    public int result { get; set; }
    [ProtoMember(2)]
    public int target_world_id { get; set; }
    [ProtoMember(3)]
    public string ip { get; set; }
    [ProtoMember(4)]
    public int port { get; set; }

}

[ProtoContract]
public class _SE_base_data
{
    [ProtoMember(1)]

    public ulong account_uid { get; set; }
    [ProtoMember(2)]
    public ulong character_uid { get; set; }
    [ProtoMember(3)]
    public ulong guild_uid { get; set; }
    [ProtoMember(4)]
    public int cur_world_id { get; set; }
    [ProtoMember(5)]
    public int target_world_id { get; set; }
    [ProtoMember(6)]
    public bool check_cost { get; set; }
    [ProtoMember(7)]
    public bool assassin_mode { get; set; }

}

[ProtoContract]
public class GAME_WORLD_SERVER_EXPEDITION_START
{
    [ProtoMember(1)]

    _SE_base_data base_data { get; set; }
    [ProtoMember(2)]
    public int max_users { get; set; }

}

[ProtoContract]
public class WORLD_WORLDLINK_SERVER_EXPEDITION_START
{
    [ProtoMember(1)]

    _SE_base_data base_data { get; set; }
    [ProtoMember(2)]
    public int max_users { get; set; }
    [ProtoMember(3)]
    public string auth_key { get; set; }

}

[ProtoContract]
public class WORLDLINK_WORLD_SERVER_EXPEDITION_START
{
    [ProtoMember(1)]

    public int result { get; set; }
    [ProtoMember(2)]
    _SE_base_data base_data { get; set; }

}

[ProtoContract]
public class WORLD_MANAGER_SERVER_EXPEDITION_START
{
    [ProtoMember(1)]

    _SE_base_data base_data { get; set; }

}

[ProtoContract]
public class MANAGER_WORLD_SERVER_EXPEDITION_START
{
    [ProtoMember(1)]

    public int result { get; set; }
    [ProtoMember(2)]
    _SE_base_data base_data { get; set; }
    [ProtoMember(3)]
    public string ip { get; set; }
    [ProtoMember(4)]
    public int port { get; set; }

}

[ProtoContract]
public class WORLD_GAME_SERVER_EXPEDITION_START
{
    [ProtoMember(1)]

    public int result { get; set; }
    [ProtoMember(2)]
    _SE_base_data base_data { get; set; }
    [ProtoMember(3)]
    public string ip { get; set; }
    [ProtoMember(4)]
    public int port { get; set; }

}

[ProtoContract]
public class GAME_WORLD_SERVER_EXPEDITION_CANCEL
{
    [ProtoMember(1)]

    public ulong account_uid { get; set; }
    [ProtoMember(2)]
    public ulong character_uid { get; set; }
    [ProtoMember(3)]
    public int target_world_id { get; set; }

}

[ProtoContract]
public class WORLDLINK_WORLD_SERVER_EXPEDITION_START_AUTH_KEY
{
    [ProtoMember(1)]

    _SE_base_data base_data { get; set; }
    [ProtoMember(2)]
    public string auth_key { get; set; }

}

[ProtoContract]
public class WORLD_WORLDLINK_SERVER_EXPEDITION_START_AUTH_KEY
{
    [ProtoMember(1)]

    public int result { get; set; }
    [ProtoMember(2)]
    _SE_base_data base_data { get; set; }

}

[ProtoContract]
public class GAME_WORLD_SERVER_EXPEDITION_TIMELINE_ALARM
{
    [ProtoMember(1)]

    public int world_id { get; set; }
    [ProtoMember(2)]
    public int timeline_tid { get; set; }

}

[ProtoContract]
public class WORLDLINK_WORLD_SERVER_EXPEDITION_TIMELINE_ALARM
{
    [ProtoMember(1)]

    public int world_id { get; set; }
    [ProtoMember(2)]
    public int timeline_tid { get; set; }

}

[ProtoContract]
public class WORLD_MANAGER_SERVER_EXPEDITION_TARGET_WORLD_GATEWAY_INFO
{
    [ProtoMember(1)]

    public int world_id { get; set; }
    [ProtoMember(2)]
    public ulong account_uid { get; set; }

}

[ProtoContract]
public class MANAGER_WORLD_SERVER_EXPEDITION_TARGET_WORLD_GATEWAY_INFO
{
    [ProtoMember(1)]

    public int result { get; set; }
    [ProtoMember(2)]
    public int world_id { get; set; }
    [ProtoMember(3)]
    public ulong account_uid { get; set; }
    [ProtoMember(4)]
    public string ip { get; set; }
    [ProtoMember(5)]
    public int port { get; set; }

}

[ProtoContract]
public class WORLD_CLIENT_SERVER_EXPEDITION_RETURN_WORLD
{
    [ProtoMember(1)]

    public bool result { get; set; }
    [ProtoMember(2)]
    public string origin_ip { get; set; }
    [ProtoMember(3)]
    public int origin_port { get; set; }
    [ProtoMember(4)]
    public int origin_worldid { get; set; }

}

[ProtoContract]
public class WORLD_WORLDLINK_SERVER_EXPEDITION_END
{
    [ProtoMember(1)]

    public int world_id { get; set; }

}

[ProtoContract]
public class GATEWAY_WORLD_TRANS_SERVER_AUTH
{
    [ProtoMember(1)]

    public string auth_key { get; set; }
    [ProtoMember(2)]
    public ulong account_uid { get; set; }
    [ProtoMember(3)]
    public string account_id { get; set; }
    [ProtoMember(4)]
    public uint proxy_server_index { get; set; }
    [ProtoMember(5)]
    public uint proxy_connected_session_id { get; set; }
    [ProtoMember(6)]
    public string user_ip { get; set; }

}

[ProtoContract]
public class WORLD_GATEWAY_TRANS_SERVER_AUTH
{
    [ProtoMember(1)]

    public bool auth_result { get; set; }
    [ProtoMember(2)]
    public ulong account_uid { get; set; }
    [ProtoMember(3)]
    public string account_id { get; set; }
    [ProtoMember(4)]
    public uint proxy_server_index { get; set; }
    [ProtoMember(5)]
    public uint proxy_connected_session_id { get; set; }
    [ProtoMember(6)]
    public string user_ip { get; set; }

}

[ProtoContract]
public class CLIENT_GAME_TRANS_SERVER_SELECT_CHARACTER
{
    [ProtoMember(1)]

    public ulong account_uid { get; set; }
    [ProtoMember(2)]
    public int classId { get; set; }
    [ProtoMember(3)]
    public ulong character_uid { get; set; }
    [ProtoMember(4)]
    public int world_id { get; set; }
    [ProtoMember(5)]
    public int store_type { get; set; }

}

[ProtoContract]
public class CLIENT_WORLD_REQUEST_TRANS_SERVER_RETURN
{
    [ProtoMember(1)]

    public ulong character_uid { get; set; }

}

[ProtoContract]
public class GAME_CLIENT_SERVER_EXPEDITION_LIFE_UPDATE
{
    [ProtoMember(1)]

    public int life_count { get; set; }

}

[ProtoContract]
public class GAME_CLIENT_SERVER_EXPEDITION_PK_REWARD
{
    [ProtoMember(1)]

    public int result { get; set; }
    [ProtoMember(2)]
    public ulong target_user_uid { get; set; }
    [ProtoMember(3)]
    public int gain_count { get; set; }
    [ProtoMember(4)]
    public _character_inven_item[] reward_item_list { get; set; }

}

[ProtoContract]
public class WORLD_GAME_SERVER_EXPEDITION_RESET_TIME
{
    [ProtoMember(1)]

    public long reset_start_time { get; set; }
    [ProtoMember(2)]
    public long reset_end_time { get; set; }

}

[ProtoContract]
public class MANAGER_WORLD_REQUEST_CHECK_EXPEDITION_MEMBER
{
    [ProtoMember(1)]

    public ulong account_uid { get; set; }

}

[ProtoContract]
public class WORLDLINK_WORLD_SERVER_RELOAD_PRIZE_CHARACTER_INFO
{
}

[ProtoContract]
public class WORLD_WORLDLINK_SERVER_EXPEDITION_USER_LOG
{

}

[ProtoContract]
public class GAME_CLIENT_SERVER_EXPEDITION_ASSASSIN_MODE_INFO
{
    [ProtoMember(1)]

    public string nickname { get; set; }

}

[ProtoContract]
public class LOBBY_WORLDLINK_CHARACTER_UNSEAL
{
    [ProtoMember(1)]

    public ulong account_uid { get; set; }
    [ProtoMember(2)]
    public ulong token_id { get; set; }
    [ProtoMember(3)]
    public int unseal_world_id { get; set; }

}

[ProtoContract]
public class LOBBY_WORLDLINK_TOKEN_CHARACTER_LIST
{
    [ProtoMember(1)]

    public ulong account_uid { get; set; }
    [ProtoMember(2)]
    public ulong[] token_id { get; set; }
    [ProtoMember(3)]
    public int world_id { get; set; }

}

[ProtoContract]
public class TOKEN_CHARACTER_INFO
{
    [ProtoMember(1)]

    public ulong token_id { get; set; }
    [ProtoMember(2)]
    public int region { get; set; }
    [ProtoMember(3)]
    public int world_id { get; set; }
    [ProtoMember(4)]
    public ulong character_uid { get; set; }
    [ProtoMember(5)]
    public string character_name { get; set; }
    [ProtoMember(6)]
    public int character_level { get; set; }
    [ProtoMember(7)]
    public ulong money { get; set; }
    [ProtoMember(8)]
    public int collection { get; set; }
    [ProtoMember(9)]
    public int class_id { get; set; }

}

[ProtoContract]
public class WORLDLINK_LOBBY_TOKEN_CHARACTER_LIST
{
    [ProtoMember(1)]

    public ulong account_uid { get; set; }
    [ProtoMember(2)]
    public TOKEN_CHARACTER_INFO[] character_list { get; set; }

}

[ProtoContract]
public class CLIENT_LOBBY_TOKEN_CHARACTER_LIST
{
    [ProtoMember(1)]

    public ulong account_uid { get; set; }

}

[ProtoContract]
public class LOBBY_CLIENT_TOKEN_CHARACTER_LIST
{
    [ProtoMember(1)]

    public ulong account_uid { get; set; }
    [ProtoMember(2)]
    public TOKEN_CHARACTER_INFO[] character_list { get; set; }

}

[ProtoContract]
public class WORLDLINK_WORLDLINK_SERVER_CHANGE_START
{
    [ProtoMember(1)]

    public uint transper_id { get; set; }
    [ProtoMember(2)]
    public ulong account_uid { get; set; }
    [ProtoMember(3)]
    public ulong character_uid { get; set; }
    [ProtoMember(4)]
    public int cur_world_id { get; set; }
    [ProtoMember(5)]
    public int next_world_id { get; set; }
    [ProtoMember(6)]
    public int ori_region_id { get; set; }

}

[ProtoContract]
public class WORLDLINK_WORLDLINK_SERVER_CHANGE_COMPLETE
{
    [ProtoMember(1)]

    public uint transper_id { get; set; }
    [ProtoMember(2)]
    public ulong account_uid { get; set; }
    [ProtoMember(3)]
    public ulong character_uid { get; set; }
    [ProtoMember(4)]
    public int cur_world_id { get; set; }
    [ProtoMember(5)]
    public int next_world_id { get; set; }
    [ProtoMember(6)]
    public int ori_region_id { get; set; }

}

[ProtoContract]
public class WORLDLINK_WORLDLINK_TRANSFER_DIRECT_DELETE
{
    [ProtoMember(1)]

    public uint transper_id { get; set; }
    [ProtoMember(2)]
    public ulong account_uid { get; set; }
    [ProtoMember(3)]
    public ulong character_uid { get; set; }
    [ProtoMember(4)]
    public int cur_world_id { get; set; }
    [ProtoMember(5)]
    public int next_world_id { get; set; }

}

[ProtoContract]
public class WORLDLINK_WORLDLINK_CHARACTER_SERVERCHANGESTATE_UPDATE
{
    [ProtoMember(1)]

    public uint transper_id { get; set; }
    [ProtoMember(2)]
    public ulong account_uid { get; set; }
    [ProtoMember(3)]
    public ulong character_uid { get; set; }
    [ProtoMember(4)]
    public int cur_world_id { get; set; }
    [ProtoMember(5)]
    public int next_world_id { get; set; }
    [ProtoMember(6)]
    public int server_change_state { get; set; }

}

[ProtoContract]
public class WORLDLINK_WORLD_INFO
{
    [ProtoMember(1)]

    public uint world_id { get; set; }
    [ProtoMember(2)]
    public uint regiongroup { get; set; }
    [ProtoMember(3)]
    public uint region { get; set; }
    [ProtoMember(4)]
    public uint changestart { get; set; }
    [ProtoMember(5)]
    public uint changeend { get; set; }
    [ProtoMember(6)]
    public string world_name { get; set; }
    [ProtoMember(7)]
    public uint hidden { get; set; }
    [ProtoMember(8)]
    public uint nft_server { get; set; }

}

[ProtoContract]
public class WORLDLINK_GAME_WORLD_INFO
{
    [ProtoMember(1)]

    public WORLDLINK_WORLD_INFO[] info_list { get; set; }

}

[ProtoContract]
public class WORLDLINK_WORLDLINK_INFO
{
    [ProtoMember(1)]

    public uint world_id { get; set; }
    [ProtoMember(2)]
    public uint regiongroup { get; set; }
    [ProtoMember(3)]
    public uint region { get; set; }
    [ProtoMember(4)]
    public uint changestart { get; set; }
    [ProtoMember(5)]
    public uint changeend { get; set; }
    [ProtoMember(6)]
    public uint regiongroupdb { get; set; }
    [ProtoMember(7)]
    public string world_name { get; set; }
    [ProtoMember(8)]
    public uint hidden { get; set; }
    [ProtoMember(9)]
    public uint nft_server { get; set; }

}

[ProtoContract]
public class WORLDLINK_WORLDLINK_WORLD_INFO
{
    [ProtoMember(1)]

    public WORLDLINK_WORLDLINK_INFO[] info_list { get; set; }

}

[ProtoContract]
public class WORLDLINK_WORLDLINK_TRANSFER_ROLLBACK
{
    [ProtoMember(1)]

    public int start_world_id { get; set; }
    [ProtoMember(2)]
    public int dest_world_id { get; set; }
    [ProtoMember(3)]
    public ulong account_uid { get; set; }
    [ProtoMember(4)]
    public ulong character_uid { get; set; }

}

[ProtoContract]
public class WORLDLINK_WORLDLINK_TRANSFER_RESTORE
{
    [ProtoMember(1)]

    public int start_world_id { get; set; }
    [ProtoMember(2)]
    public uint transper_id { get; set; }
    [ProtoMember(3)]
    public ulong account_uid { get; set; }
    [ProtoMember(4)]
    public ulong character_uid { get; set; }

}

[ProtoContract]
public class WORLDLINK_WORLDLINK_GREATBUILDING_UPGRADE_REGISTER
{
    [ProtoMember(1)]

    public long user_uid { get; set; }
    [ProtoMember(2)]
    public int target_world_id { get; set; }
    [ProtoMember(3)]
    public _upgrade_building_info[] upgrade_building_list { get; set; }

}

[ProtoContract]
public class _conquer_server_round_info
{
    [ProtoMember(1)]

    public int round_id { get; set; }
    [ProtoMember(2)]
    public long start_time { get; set; }
    [ProtoMember(3)]
    public long end_time { get; set; }

}

[ProtoContract]
public class CLIENT_GAME_CONQUER_SERVER_INFO
{
}

[ProtoContract]
public class GAME_CLIENT_CONQUER_SERVER_INFO
{
    [ProtoMember(1)]

    public long latest_use_time { get; set; }
    [ProtoMember(2)]
    public uint guild_rank { get; set; }
    [ProtoMember(3)]
    public int life_count { get; set; }
    [ProtoMember(4)]
    public int round_use_count { get; set; }
    [ProtoMember(5)]
    public int user_count { get; set; }
    [ProtoMember(6)]
    public _conquer_server_round_info[] round_info { get; set; }

}

[ProtoContract]
public class CLIENT_GAME_CONQUER_SERVER_START
{

}

[ProtoContract]
public class GAME_CLIENT_CONQUER_SERVER_START
{
    [ProtoMember(1)]

    public int result { get; set; }
    [ProtoMember(2)]
    public string ip { get; set; }
    [ProtoMember(3)]
    public int port { get; set; }
    [ProtoMember(4)]
    public int conquer_server_world_id { get; set; }

}

[ProtoContract]
public class WORLD_GAME_CONQUER_SERVER_RESET_ROUND_TIME
{
    [ProtoMember(1)]

    public long next_reset_time { get; set; }

}

[ProtoContract]
public class WORLD_MANAGER_TARGET_WORLD_GATEWAY_INFO
{
    [ProtoMember(1)]

    public int world_id { get; set; }
    [ProtoMember(2)]
    public ulong account_uid { get; set; }
    [ProtoMember(3)]
    public int request_type { get; set; }

}

[ProtoContract]
public class MANAGER_WORLD_TARGET_WORLD_GATEWAY_INFO
{
    [ProtoMember(1)]

    public int result { get; set; }
    [ProtoMember(2)]
    public int world_id { get; set; }
    [ProtoMember(3)]
    public ulong account_uid { get; set; }
    [ProtoMember(4)]
    public int request_type { get; set; }
    [ProtoMember(5)]
    public string ip { get; set; }
    [ProtoMember(6)]
    public int port { get; set; }

}

[ProtoContract]
public class _CS_base_data
{
    [ProtoMember(1)]

    public ulong account_uid { get; set; }
    [ProtoMember(2)]
    public ulong character_uid { get; set; }
    [ProtoMember(3)]
    public ulong guild_uid { get; set; }
    [ProtoMember(4)]
    public int cur_world_id { get; set; }
    [ProtoMember(5)]
    public bool add_use_count { get; set; }
    [ProtoMember(6)]
    public int cheat_world_id { get; set; }

}

[ProtoContract]
public class GAME_WORLD_CONQUER_SERVER_START
{
    [ProtoMember(1)]

    _CS_base_data base_data { get; set; }
    [ProtoMember(2)]
    public int max_users { get; set; }

}

[ProtoContract]
public class WORLD_MANAGER_CONQUER_SERVER_START
{
    [ProtoMember(1)]

    _CS_base_data base_data { get; set; }
    [ProtoMember(2)]
    public int max_users { get; set; }
    [ProtoMember(3)]
    public string auth_key { get; set; }

}

[ProtoContract]
public class MANAGER_WORLD_CONQUER_SERVER_START_RESERVE
{
    [ProtoMember(1)]

    _CS_base_data base_data { get; set; }
    [ProtoMember(2)]
    public int max_users { get; set; }
    [ProtoMember(3)]
    public string auth_key { get; set; }

}

[ProtoContract]
public class WORLD_MANAGER_CONQUER_SERVER_START_RESERVE
{
    [ProtoMember(1)]

    public int result { get; set; }
    [ProtoMember(2)]
    _CS_base_data base_data { get; set; }

}

[ProtoContract]
public class MANAGER_WORLD_CONQUER_SERVER_START
{
    [ProtoMember(1)]

    public int result { get; set; }
    [ProtoMember(2)]
    _CS_base_data base_data { get; set; }
    [ProtoMember(3)]
    public string ip { get; set; }
    [ProtoMember(4)]
    public int port { get; set; }
    [ProtoMember(5)]
    public int conquer_server_world_id { get; set; }

}

[ProtoContract]
public class WORLD_GAME_CONQUER_SERVER_START
{
    [ProtoMember(1)]

    public int result { get; set; }
    [ProtoMember(2)]
    _CS_base_data base_data { get; set; }
    [ProtoMember(3)]
    public string ip { get; set; }
    [ProtoMember(4)]
    public int port { get; set; }
    [ProtoMember(5)]
    public int conquer_server_world_id { get; set; }

}

[ProtoContract]
public class MANAGER_WORLD_CONQUER_SERVER_USER_COUNT
{
    [ProtoMember(1)]

    public int user_count { get; set; }

}

[ProtoContract]
public class WORLD_GAME_CONQUER_SERVER_USER_COUNT
{
    [ProtoMember(1)]

    public int user_count { get; set; }

}

[ProtoContract]
public class WORLD_MANAGER_TRAS_USER_AUTH
{
    [ProtoMember(1)]

    public int auth_type { get; set; }
    [ProtoMember(2)]
    public int world_id { get; set; }
    [ProtoMember(3)]
    public ulong account_uid { get; set; }

}

[ProtoContract]
public class MANAGER_WORLD_TRAS_USER_AUTH
{
    [ProtoMember(1)]

    public int auth_type { get; set; }
    [ProtoMember(2)]
    public ulong account_uid { get; set; }

}

[ProtoContract]
public class _world_server_state
{
    [ProtoMember(1)]

    public int world_id { get; set; }
    [ProtoMember(2)]
    public int world_server_state { get; set; }

}

[ProtoContract]
public class WORLD_MANAGER_WORLD_SERVER_STATE_LIST
{
    [ProtoMember(1)]

    public int world_id { get; set; }

}

[ProtoContract]
public class MANAGER_WORLD_WORLD_SERVER_STATE_LIST
{
    [ProtoMember(1)]

    public _world_server_state[] world_server_info_list { get; set; }

}

[ProtoContract]
public class WORLD_GAME_WORLD_SERVER_STATE_LIST
{
    [ProtoMember(1)]

    public _world_server_state[] world_server_info_list { get; set; }

}

[ProtoContract]
public class MANAGER_WORLD_WORLD_SERVER_STATE_NOTI
{
    [ProtoMember(1)]

    _world_server_state world_server_info { get; set; }

}

[ProtoContract]
public class WORLD_GAME_WORLD_SERVER_STATE_NOTI
{
    [ProtoMember(1)]

    _world_server_state world_server_info { get; set; }

}


[ProtoContract]
public class _shop_item_cost
{
    [ProtoMember(1)]

    public uint cost_type { get; set; }
    [ProtoMember(2)]
    public long cost_value { get; set; }

}

[ProtoContract]
public class _shop_item_data
{
    [ProtoMember(1)]

    public uint tbl_shop_item_id { get; set; }
    [ProtoMember(2)]
    public _shop_item_cost[] need_cost_data_list { get; set; }
    [ProtoMember(3)]
    public uint result_item_index { get; set; }
    [ProtoMember(4)]
    public uint result_item_count { get; set; }

}

[ProtoContract]
public class CLIENT_GAME_BUY_ITEM
{
    [ProtoMember(1)]

    public ulong uid { get; set; }
    [ProtoMember(2)]
    public uint shop_id { get; set; }
    [ProtoMember(3)]
    public uint shop_item_id { get; set; }
    [ProtoMember(4)]
    public uint shop_item_count { get; set; }

}

[ProtoContract]
public class GAME_CLIENT_BUY_ITEM
{
    [ProtoMember(1)]

    public int use_inven_count { get; set; }
    [ProtoMember(2)]
    public _cost_info[] cost_info { get; set; }
    [ProtoMember(3)]
    public _stack_item_info[] update_stack_items { get; set; }
    [ProtoMember(4)]
    public _character_inven_item[] update_items { get; set; }

}

[ProtoContract]
public class CLIENT_GAME_SHOP_ITEM_DATA
{
    [ProtoMember(1)]

    public uint shop_id { get; set; }

}

[ProtoContract]
public class GAME_CLIENT_SHOP_ITEM_DATA
{
    [ProtoMember(1)]

    public uint shop_id { get; set; }
    [ProtoMember(2)]
    public _shop_item_data[] shop_item_list { get; set; }

}

[ProtoContract]
public class _shop_ui_category_main
{
    [ProtoMember(1)]

    public uint main_category_id { get; set; }
    [ProtoMember(2)]
    public uint name_str_id { get; set; }
    [ProtoMember(3)]
    public uint ads_id { get; set; }
    [ProtoMember(4)]
    public uint order_num { get; set; }
    [ProtoMember(5)]
    public uint tag_icon_id { get; set; }
    [ProtoMember(6)]
    public _shop_ui_category_sub[] category_sub_list { get; set; }

}

[ProtoContract]
public class _shop_ui_category_sub
{
    [ProtoMember(1)]

    public uint main_category_id { get; set; }
    [ProtoMember(2)]
    public uint sub_category_id { get; set; }
    [ProtoMember(3)]
    public uint name_str_id { get; set; }
    [ProtoMember(4)]
    public uint sub_category_type { get; set; }
    [ProtoMember(5)]
    public uint list_ui_type { get; set; }
    [ProtoMember(6)]
    public uint buy_group_id { get; set; }
    [ProtoMember(7)]
    public uint max_sell_count { get; set; }
    [ProtoMember(8)]
    public uint open_time { get; set; }
    [ProtoMember(9)]
    public uint close_time { get; set; }
    [ProtoMember(10)]
    public uint interval_time { get; set; }
    [ProtoMember(11)]
    public uint order_num { get; set; }
    [ProtoMember(12)]
    public uint tag_icon_id { get; set; }
    [ProtoMember(13)]
    public uint reset_category_sub_time { get; set; }

}

[ProtoContract]
public class _shop_ui_bouns_data
{
    [ProtoMember(1)]

    public uint bonus_type { get; set; }
    [ProtoMember(2)]
    public uint bonus_id { get; set; }
    [ProtoMember(3)]
    public uint bonus_count { get; set; }

}

[ProtoContract]
public class _shop_ui_buy_item_data
{
    [ProtoMember(1)]

    public uint buy_group_id { get; set; }
    [ProtoMember(2)]
    public uint buy_id { get; set; }
    [ProtoMember(3)]
    public uint buy_type { get; set; }
    [ProtoMember(4)]
    public uint buy_type_sub { get; set; }
    [ProtoMember(5)]
    public uint name_str_id { get; set; }
    [ProtoMember(6)]
    public uint explain_str_id { get; set; }
    [ProtoMember(7)]
    public uint commodity_id { get; set; }
    [ProtoMember(8)]
    public int commodity_count { get; set; }
    [ProtoMember(9)]
    public _shop_ui_bouns_data[] bonus_data_list { get; set; }
    [ProtoMember(10)]
    public uint goods_id { get; set; }
    [ProtoMember(11)]
    public uint goods_id_chain { get; set; }
    [ProtoMember(12)]
    public long goods_value { get; set; }
    [ProtoMember(13)]
    public uint market_uid { get; set; }
    [ProtoMember(14)]
    public uint mileage_id { get; set; }
    [ProtoMember(15)]
    public long mileage_value { get; set; }
    [ProtoMember(16)]
    public uint gacha_interval_time { get; set; }
    [ProtoMember(17)]
    public uint gacha_discount_value { get; set; }
    [ProtoMember(18)]
    public uint limit_target { get; set; }
    [ProtoMember(19)]
    public uint limit_count_type { get; set; }
    [ProtoMember(20)]
    public uint limit_count_value { get; set; }
    [ProtoMember(21)]
    public uint limit_level_min { get; set; }
    [ProtoMember(22)]
    public uint limit_level_max { get; set; }
    [ProtoMember(23)]
    public uint discount_value { get; set; }
    [ProtoMember(24)]
    public uint increase_value { get; set; }
    [ProtoMember(25)]
    public uint randomRate { get; set; }
    [ProtoMember(26)]
    public uint pop_up_type { get; set; }
    [ProtoMember(27)]
    public uint icon_id { get; set; }
    [ProtoMember(28)]
    public uint effect_id { get; set; }
    [ProtoMember(29)]
    public uint order_num { get; set; }
    [ProtoMember(30)]
    public uint tag_icon_id { get; set; }
    [ProtoMember(31)]
    public uint guild_gift_id { get; set; }

}

[ProtoContract]
public class CLIENT_GAME_UI_SHOP_VERSION
{
    [ProtoMember(1)]

    public uint current_version { get; set; }

}

[ProtoContract]
public class GAME_CLIENT_UI_SHOP_VERSION
{
    [ProtoMember(1)]

    public uint server_version { get; set; }

}

[ProtoContract]
public class GAME_CLIENT_UI_SHOP_DATA_CATEGORY
{
    [ProtoMember(1)]

    public uint server_version { get; set; }
    [ProtoMember(2)]
    public _shop_ui_category_main[] category_main_list { get; set; }

}

[ProtoContract]
public class GAME_CLIENT_UI_SHOP_DATA_PRODUCT
{
    [ProtoMember(1)]

    public bool is_end { get; set; }
    [ProtoMember(2)]
    public _shop_ui_buy_item_data[] buy_item_list { get; set; }

}

[ProtoContract]
public class CLIENT_GAME_UI_SHOP_LIMIT_BUY
{
}

[ProtoContract]
public class GAME_CLIENT_UI_SHOP_LIMIT_BUY
{
    [ProtoMember(1)]

    public _shop_ui_limit_buy_item_data[] limit_data_list { get; set; }

}

[ProtoContract]
public class CLIENT_GAME_UI_SHOP_LIMIT_BUY_LIST
{

}

[ProtoContract]
public class GAME_CLIENT_UI_SHOP_LIMIT_BUY_LIST
{
    [ProtoMember(1)]

    public bool is_end { get; set; }
    [ProtoMember(2)]
    public _shop_ui_limit_buy_item_data[] limit_data_list { get; set; }

}

[ProtoContract]
public class CLIENT_GAME_UI_SHOP_BUY
{
    [ProtoMember(1)]

    public uint current_version { get; set; }
    [ProtoMember(2)]
    public uint main_category_id { get; set; }
    [ProtoMember(3)]
    public uint sub_category_id { get; set; }
    [ProtoMember(4)]
    public uint buy_group_id { get; set; }
    [ProtoMember(5)]
    public uint buy_id { get; set; }
    [ProtoMember(6)]
    public int buy_count { get; set; }

}

[ProtoContract]
public class GAME_CLIENT_UI_SHOP_BUY
{
    [ProtoMember(1)]

    public uint result { get; set; }
    [ProtoMember(2)]
    public _cost_info[] cost_info { get; set; }
    [ProtoMember(3)]
    public _character_inven_item[] update_items { get; set; }
    [ProtoMember(4)]
    public uint reason_send_mail { get; set; }
    [ProtoMember(5)]
    public uint buy_id { get; set; }
    [ProtoMember(6)]
    public int buy_count { get; set; }
    [ProtoMember(7)]
    public bool is_Sublbag { get; set; }
    [ProtoMember(8)]
    _period_goods_data period_goods_info { get; set; }

}

[ProtoContract]
public class _shop_npc_data
{
    [ProtoMember(1)]

    public uint shop_id { get; set; }
    [ProtoMember(2)]
    public uint shop_type { get; set; }
    [ProtoMember(3)]
    public uint open_time { get; set; }
    [ProtoMember(4)]
    public uint close_time { get; set; }
    [ProtoMember(5)]
    public uint refresh_time { get; set; }
    [ProtoMember(6)]
    public bool refresh_permission { get; set; }
    [ProtoMember(7)]
    public uint refresh_money_type { get; set; }
    [ProtoMember(8)]
    public uint refresh_money_value { get; set; }
    [ProtoMember(9)]
    public long refresh_money_increase { get; set; }
    [ProtoMember(10)]
    public uint refresh_count { get; set; }
    [ProtoMember(11)]
    public uint display_ui { get; set; }
    [ProtoMember(12)]
    public uint not_buy_time_sec { get; set; }
    [ProtoMember(13)]
    public int guild_shop_item_count { get; set; }
    [ProtoMember(15)]
    public long guild_shop_remaining_time { get; set; }
    [ProtoMember(16)]
    public int guild_shop_state { get; set; }
    [ProtoMember(17)]
    _guild_name_ui_info guild_name_ui_info { get; set; }
    [ProtoMember(19)]
    public bool is_event_shop { get; set; }

}

[ProtoContract]
public class _shop_npc_item_data
{
    [ProtoMember(1)]

    public uint goods_group_id { get; set; }
    [ProtoMember(2)]
    public uint goods_id { get; set; }
    [ProtoMember(3)]
    public uint commodity_id { get; set; }
    [ProtoMember(4)]
    public int commodity_type { get; set; }
    [ProtoMember(5)]
    public int commodity_count { get; set; }
    [ProtoMember(6)]
    public uint count_adjust_min { get; set; }
    [ProtoMember(7)]
    public uint count_adjust_max { get; set; }
    [ProtoMember(8)]
    public uint money_id { get; set; }
    [ProtoMember(9)]
    public long money_value { get; set; }
    [ProtoMember(10)]
    public uint limit_target { get; set; }
    [ProtoMember(11)]
    public uint limit_count_type { get; set; }
    [ProtoMember(12)]
    public uint limit_count_value { get; set; }
    [ProtoMember(13)]
    public uint order_num { get; set; }
    [ProtoMember(14)]
    public int pop_up_type { get; set; }
    [ProtoMember(15)]
    public int pop_up_count { get; set; }
    [ProtoMember(16)]
    public int sell_type { get; set; }
    [ProtoMember(17)]
    public int sell_id { get; set; }
    [ProtoMember(18)]
    public int sell_value { get; set; }
    [ProtoMember(19)]
    public int limit_level { get; set; }

}

[ProtoContract]
public class CLIENT_GAME_NPC_SHOP_BUY
{
    [ProtoMember(1)]

    public uint npc_id { get; set; }
    [ProtoMember(2)]
    public uint shop_id { get; set; }
    [ProtoMember(3)]
    public uint goods_id { get; set; }
    [ProtoMember(4)]
    public uint goods_count { get; set; }
    [ProtoMember(5)]
    public ulong npc_shop_guild_uid { get; set; }

}

[ProtoContract]
public class GAME_CLIENT_NPC_SHOP_BUY
{
    [ProtoMember(1)]

    public _cost_info[] money_info { get; set; }
    [ProtoMember(2)]
    public _time_ticket_info[] time_ticket_info { get; set; }
    [ProtoMember(3)]
    public _stack_item_info[] update_stack_items { get; set; }
    [ProtoMember(4)]
    public _character_inven_item[] update_items { get; set; }
    [ProtoMember(5)]
    public int result { get; set; }
    [ProtoMember(6)]
    public long guild_npc_shop_remain_time { get; set; }
    [ProtoMember(7)]
    public int guild_npc_shop_remain_count { get; set; }

}

[ProtoContract]
public class CLIENT_GAME_NPC_SHOP_DATA
{
    [ProtoMember(1)]

    public uint npc_id { get; set; }
    [ProtoMember(2)]
    public uint shop_id { get; set; }

}

[ProtoContract]
public class GAME_CLIENT_NPC_SHOP_DATA
{
    [ProtoMember(1)]

    _shop_npc_data shop_info { get; set; }
    [ProtoMember(2)]
    public _shop_npc_item_data[] shop_item_list { get; set; }

}

[ProtoContract]
public class CLIENT_GAME_NPC_SHOP_DATA_REFRESH
{
    [ProtoMember(1)]

    public uint npc_id { get; set; }
    [ProtoMember(2)]
    public uint shop_id { get; set; }

}

[ProtoContract]
public class GAME_CLIENT_NPC_SHOP_DATA_REFRESH
{
    [ProtoMember(1)]

    _shop_npc_data shop_info { get; set; }
    [ProtoMember(2)]
    public _cost_info[] money_info { get; set; }
    [ProtoMember(3)]
    public _shop_npc_item_data[] shop_item_list { get; set; }

}

[ProtoContract]
public class _guild_goods_info
{
    [ProtoMember(1)]

    public int goods_index { get; set; }
    [ProtoMember(2)]
    public int goods_count { get; set; }

}

[ProtoContract]
public class _guild_shop_log_info
{
    [ProtoMember(1)]

    public long user_uid { get; set; }
    [ProtoMember(2)]
    public string nick_name { get; set; }
    [ProtoMember(3)]
    public string profile { get; set; }
    [ProtoMember(4)]
    _guild_goods_info goods_info { get; set; }
    [ProtoMember(5)]
    public int log_create_time { get; set; }

}

[ProtoContract]
public class CLIENT_GAME_GUILD_SHOP_LIST
{

}

[ProtoContract]
public class GAME_WORLD_GUILD_SHOP_LIST
{
    [ProtoMember(1)]

    public long req_user_uid { get; set; }

}

[ProtoContract]
public class WORLD_GAME_GUILD_SHOP_LIST
{
    [ProtoMember(1)]

    public int result { get; set; }
    [ProtoMember(2)]
    public long req_user_uid { get; set; }
    [ProtoMember(3)]
    public _guild_goods_info[] goods_list { get; set; }

}

[ProtoContract]
public class GAME_CLIENT_GUILD_SHOP_LIST
{
    [ProtoMember(1)]

    public int result { get; set; }
    [ProtoMember(2)]
    public _guild_goods_info[] goods_list { get; set; }
    [ProtoMember(3)]
    public int[] dominion_list { get; set; }

}

[ProtoContract]
public class CLIENT_GAME_GUILD_SHOP_REGISTER
{
    [ProtoMember(1)]

    _guild_goods_info register_goods { get; set; }

}

[ProtoContract]
public class GAME_WORLD_GUILD_SHOP_REGISTER
{
    [ProtoMember(1)]

    public long req_user_uid { get; set; }
    [ProtoMember(2)]
    _guild_goods_info register_goods { get; set; }
    [ProtoMember(3)]
    public uint start_world_id { get; set; }

}

[ProtoContract]
public class WORLD_GAME_GUILD_SHOP_REGISTER
{
    [ProtoMember(1)]

    public int result { get; set; }
    [ProtoMember(2)]
    public long req_user_uid { get; set; }
    [ProtoMember(3)]
    public ulong guild_uid { get; set; }
    [ProtoMember(4)]
    _guild_goods_info registered_goods { get; set; }

}

[ProtoContract]
public class GAME_CLIENT_GUILD_SHOP_REGISTER
{
    [ProtoMember(1)]

    public int result { get; set; }
    [ProtoMember(2)]
    _guild_goods_info registered_goods { get; set; }

}

[ProtoContract]
public class CLIENT_GAME_GUILD_SHOP_BUY
{
    [ProtoMember(1)]

    public _guild_goods_info buy_goods { get; set; }

}

[ProtoContract]
public class GAME_WORLD_GUILD_SHOP_BUY
{
    [ProtoMember(1)]

    public long req_user_uid { get; set; }
    [ProtoMember(2)]
    _guild_goods_info buy_goods { get; set; }
    [ProtoMember(3)]
    public uint start_world_id { get; set; }

}

[ProtoContract]
public class WORLD_GAME_GUILD_SHOP_BUY
{
    [ProtoMember(1)]

    public int result { get; set; }
    [ProtoMember(2)]
    public long req_user_uid { get; set; }
    [ProtoMember(3)]
    public ulong guild_uid { get; set; }
    [ProtoMember(4)]
    _guild_goods_info buy_goods { get; set; }
    [ProtoMember(5)]
    _guild_goods_info shop_goods { get; set; }

}

[ProtoContract]
public class GAME_CLIENT_GUILD_SHOP_BUY
{
    [ProtoMember(1)]

    public int result { get; set; }
    [ProtoMember(2)]
    _guild_goods_info shop_goods { get; set; }
    [ProtoMember(3)]
    public _cost_info[] update_cost_infos { get; set; }
    [ProtoMember(4)]
    public _character_inven_item[] update_items { get; set; }

}

[ProtoContract]
public class CLIENT_GAME_GUILD_SHOP_LOG
{
    [ProtoMember(1)]

    public int log_type { get; set; }

}

[ProtoContract]
public class WORLD_GAME_GUILD_SHOP_LOG
{
    [ProtoMember(1)]

    public long req_user_uid { get; set; }
    [ProtoMember(2)]
    public bool is_end { get; set; }
    [ProtoMember(3)]
    public _guild_shop_log_info[] logs { get; set; }

}

[ProtoContract]
public class GAME_CLIENT_GUILD_SHOP_LOG
{
    [ProtoMember(1)]

    public bool is_end { get; set; }
    [ProtoMember(2)]
    public _guild_shop_log_info[] logs { get; set; }

}

[ProtoContract]
public class WORLD_GAME_ENTER_GUILD_BLACKIRON_NPC
{
    [ProtoMember(1)]

    public int npc_id { get; set; }
    [ProtoMember(2)]
    public int stage_id { get; set; }
    [ProtoMember(3)]
    public long blackiron_npc_uid { get; set; }
    [ProtoMember(4)]
    public ulong guild_uid { get; set; }

}

[ProtoContract]
public class CLIENT_GAME_DUNGEON_SHOP_BUY
{
    [ProtoMember(1)]

    public int shop_group_id { get; set; }
    [ProtoMember(2)]
    public int shop_id { get; set; }
    [ProtoMember(3)]
    public int buy_count { get; set; }

}

[ProtoContract]
public class GAME_CLIENT_DUNGEON_SHOP_BUY
{
    [ProtoMember(1)]

    public int result { get; set; }
    [ProtoMember(2)]
    public _cost_info[] money_info { get; set; }
    [ProtoMember(3)]
    public _character_inven_item[] update_items { get; set; }

}

[ProtoContract]
public class CLIENT_SHOP_UI_SHOP_VERSION
{
}

[ProtoContract]
public class SHOP_CLIENT_UI_SHOP_VERSION
{
    [ProtoMember(1)]

    public int tap_version { get; set; }
    [ProtoMember(2)]
    public int goods_version { get; set; }
    [ProtoMember(3)]
    public int item_package_version { get; set; }

}

[ProtoContract]
public class GOODS_BONUS_ITEM
{
    [ProtoMember(1)]

    public int type { get; set; }
    [ProtoMember(2)]
    public int id { get; set; }
    [ProtoMember(3)]
    public int count { get; set; }

}

[ProtoContract]
public class UI_SHOP_GOODS
{
    [ProtoMember(1)]

    public uint goodsid { get; set; }
    [ProtoMember(2)]
    public int[] tabid { get; set; }
    [ProtoMember(3)]
    public int goodstype { get; set; }
    [ProtoMember(4)]
    public int frontid { get; set; }
    [ProtoMember(5)]
    public int linkid { get; set; }
    [ProtoMember(6)]
    public int groupid { get; set; }
    [ProtoMember(7)]
    public uint namestrid { get; set; }
    [ProtoMember(8)]
    public uint explainstrid { get; set; }
    [ProtoMember(9)]
    public int description { get; set; }
    [ProtoMember(10)]
    public uint goodscommodityid { get; set; }
    [ProtoMember(11)]
    public int goodsvalue { get; set; }
    [ProtoMember(12)]
    public GOODS_BONUS_ITEM[] Bonus { get; set; }
    [ProtoMember(13)]
    public int moneyid { get; set; }
    [ProtoMember(14)]
    public int moneyvalue { get; set; }
    [ProtoMember(15)]
    public int mileageid { get; set; }
    [ProtoMember(16)]
    public int mileagevalue { get; set; }
    [ProtoMember(17)]
    public int limittarget { get; set; }
    [ProtoMember(18)]
    public int limitcounttype { get; set; }
    [ProtoMember(19)]
    public int limitcountvalue { get; set; }
    [ProtoMember(20)]
    public int limitleveltype { get; set; }
    [ProtoMember(21)]
    public int limitlevelmin { get; set; }
    [ProtoMember(22)]
    public int limitlevelmax { get; set; }
    [ProtoMember(23)]
    public int iconid { get; set; }
    [ProtoMember(24)]
    public int ordertype { get; set; }
    [ProtoMember(25)]
    public int[] ordernums { get; set; }
    [ProtoMember(26)]
    public int tagiconid { get; set; }
    [ProtoMember(27)]
    public int onofftype { get; set; }
    [ProtoMember(28)]
    public long onofftimestart { get; set; }
    [ProtoMember(29)]
    public long onofftimeend { get; set; }
    [ProtoMember(30)]
    public int sublbag { get; set; }
    [ProtoMember(31)]
    public int displayonoff { get; set; }
    [ProtoMember(32)]
    public int hotdeal { get; set; }
    [ProtoMember(33)]
    public long hotdealtimestart { get; set; }
    [ProtoMember(34)]
    public long hotdealtimeend { get; set; }
    [ProtoMember(35)]
    public int discountrate { get; set; }
    [ProtoMember(36)]
    public int guildgift { get; set; }
    [ProtoMember(37)]
    public int guildgiftstr { get; set; }
    [ProtoMember(38)]
    public int gotab { get; set; }
    [ProtoMember(39)]
    public long releasetime { get; set; }
    [ProtoMember(40)]
    public int oneplus { get; set; }
    [ProtoMember(41)]
    public int bgcolor { get; set; }
    [ProtoMember(42)]
    public int labeliconid { get; set; }
    [ProtoMember(43)]
    public int detaildescription { get; set; }

}

[ProtoContract]
public class ITEM_PACKAGE_REWARD
{
    [ProtoMember(1)]

    public int rewardtype { get; set; }
    [ProtoMember(2)]
    public int[] rewardid { get; set; }
    [ProtoMember(3)]
    public int rewardvalue { get; set; }
    [ProtoMember(4)]
    public int smeltingtype { get; set; }
    [ProtoMember(5)]
    public int smeltingvalue { get; set; }

}

[ProtoContract]
public class UI_SHOP_ITEM_PACKAGE
{
    [ProtoMember(1)]

    public int shoppackageid { get; set; }
    [ProtoMember(2)]
    public int choice { get; set; }
    [ProtoMember(3)]
    public int icon { get; set; }
    [ProtoMember(4)]
    public int openeffect { get; set; }
    [ProtoMember(5)]
    public ITEM_PACKAGE_REWARD[] rewards { get; set; }

}

[ProtoContract]
public class UI_SHOP_TAP
{
    [ProtoMember(1)]

    public uint goodsid { get; set; }
    [ProtoMember(2)]
    public int tabid { get; set; }
    [ProtoMember(3)]
    public int taptype { get; set; }
    [ProtoMember(4)]
    public int highertapid { get; set; }
    [ProtoMember(5)]
    public int tapname { get; set; }
    [ProtoMember(6)]
    public int ordernum { get; set; }
    [ProtoMember(7)]
    public int viewtype { get; set; }
    [ProtoMember(8)]
    public int tagicontype { get; set; }
    [ProtoMember(10)]
    public int taponoff { get; set; }
    [ProtoMember(11)]
    public string rateaddress { get; set; }
    [ProtoMember(12)]
    public int gachainfoid { get; set; }

}

[ProtoContract]
public class CLIENT_SHOP_UI_SHOP_REQUEST_METADATA
{
    [ProtoMember(1)]

    public int json_type { get; set; }

}

[ProtoContract]
public class SHOP_CLIENT_UI_SHOP_RESPONSE_METADATA
{
    [ProtoMember(1)]

    public int json_type { get; set; }
    [ProtoMember(2)]
    public int version { get; set; }
    [ProtoMember(3)]
    public UI_SHOP_GOODS[] shop_goods { get; set; }
    [ProtoMember(4)]
    public UI_SHOP_ITEM_PACKAGE[] item_packages { get; set; }
    [ProtoMember(5)]
    public UI_SHOP_TAP[] shop_taps { get; set; }

}

[ProtoContract]
public class CLIENT_SHOP_UI_SHOP_REQUEST_METADATA_DIVISION
{
    [ProtoMember(1)]

    public int json_type { get; set; }

}

[ProtoContract]
public class SHOP_CLIENT_UI_SHOP_RESPONSE_METADATA_DIVISION
{
    [ProtoMember(1)]

    public int json_type { get; set; }
    [ProtoMember(2)]
    public int version { get; set; }
    [ProtoMember(3)]
    public UI_SHOP_GOODS[] shop_goods { get; set; }
    [ProtoMember(4)]
    public UI_SHOP_ITEM_PACKAGE[] item_packages { get; set; }
    [ProtoMember(5)]
    public UI_SHOP_TAP[] shop_taps { get; set; }
    [ProtoMember(6)]
    public bool is_end { get; set; }

}

[ProtoContract]
public class CLIENT_GAME_UI_SHOP_BUYITEM
{
    [ProtoMember(1)]

    public uint shop_goods_ver { get; set; }
    [ProtoMember(2)]
    public uint goods_id { get; set; }
    [ProtoMember(3)]
    public int buy_count { get; set; }

}

[ProtoContract]
public class GAME_CLIENT_UI_SHOP_BUYITEM
{
    [ProtoMember(1)]

    public int result { get; set; }

}

[ProtoContract]
public class GAME_SHOP_UI_SHOP_BUYITEM
{
    [ProtoMember(1)]

    public uint shop_goods_ver { get; set; }
    [ProtoMember(2)]
    public uint goods_id { get; set; }
    [ProtoMember(3)]
    public int buy_count { get; set; }
    [ProtoMember(4)]
    public string product_id { get; set; }

}

[ProtoContract]
public class SHOP_GAME_UI_SHOP_BUYITEM
{
    [ProtoMember(1)]

    public int result { get; set; }
    [ProtoMember(2)]
    public int buy_count { get; set; }
    [ProtoMember(3)]
    public UI_SHOP_GOODS shop_goods { get; set; }
    [ProtoMember(4)]
    public  UI_SHOP_ITEM_PACKAGE item_pacakages { get; set; }

}

[ProtoContract]
public class CLIENT_GAME_UI_SHOP_BUY_CASHITEM_START
{
    [ProtoMember(1)]

    public string player_key { get; set; }
    [ProtoMember(2)]
    public string item_name { get; set; }
    [ProtoMember(3)]
    public string product_id { get; set; }
    [ProtoMember(4)]
    public string total_price { get; set; }
    [ProtoMember(5)]
    public string user_agent { get; set; }
    [ProtoMember(6)]
    public int item_type { get; set; }
    [ProtoMember(7)]
    public uint shop_goods_ver { get; set; }
    [ProtoMember(8)]
    public int shop_goods_id { get; set; }
    [ProtoMember(9)]
    public string user_agent_id { get; set; }

}

[ProtoContract]
public class GAME_CLIENT_UI_SHOP_BUY_CASHITEM_START
{
    [ProtoMember(1)]

    public int result { get; set; }
    [ProtoMember(2)]
    public string pay_id { get; set; }
    [ProtoMember(3)]
    public int game_result { get; set; }
    [ProtoMember(4)]
    public string payment_url { get; set; }
    [ProtoMember(5)]
    public string token { get; set; }

}

[ProtoContract]
public class CLIENT_GAME_UI_SHOP_BUY_CASHITEM_VERIFY
{
    [ProtoMember(1)]

    public string pay_id { get; set; }
    [ProtoMember(2)]
    public string player_key { get; set; }
    [ProtoMember(3)]
    public string user_agent { get; set; }
    [ProtoMember(4)]
    public string purchase_token { get; set; }
    [ProtoMember(5)]
    public int item_type { get; set; }
    [ProtoMember(6)]
    public uint shop_goods_ver { get; set; }
    [ProtoMember(7)]
    public int shop_goods_id { get; set; }

}

[ProtoContract]
public class GAME_CLIENT_UI_SHOP_BUY_CASHITEM_VERIFY
{
    [ProtoMember(1)]

    public int result { get; set; }

}

[ProtoContract]
public class CLIENT_GAME_UI_SHOP_BUY_CASHITEM_PRE_VERIFY
{
    [ProtoMember(1)]

    public string player_key { get; set; }
    [ProtoMember(2)]
    public string user_agent { get; set; }
    [ProtoMember(3)]
    public string purchase_token { get; set; }
    [ProtoMember(4)]
    public string product_id { get; set; }

}

[ProtoContract]
public class GAME_CLIENT_UI_SHOP_BUY_CASHITEM_PRE_VERIFY
{
    [ProtoMember(1)]

    public int result { get; set; }

}

[ProtoContract]
public class GAME_SHOP_UI_SHOP_REQUEST_METADATA
{

}

[ProtoContract]
public class SHOP_GAME_UI_SHOP_RESPONSE_METADATA
{
    [ProtoMember(1)]

    public int data_version { get; set; }
    [ProtoMember(2)]
    public UI_SHOP_GOODS[] shop_goods { get; set; }
    [ProtoMember(3)]
    public UI_SHOP_ITEM_PACKAGE[] item_pacakages { get; set; }
    [ProtoMember(4)]
    public UI_SHOP_TAP[] shop_tap { get; set; }

}

[ProtoContract]
public class CLIENT_GAME_RECEIVE_CASHBAG_ITEM
{
    [ProtoMember(1)]

    public int goods_id { get; set; }
    [ProtoMember(2)]
    public long insert_time { get; set; }

}

[ProtoContract]
public class GAME_CLIENT_RECEIVE_CASHBAG_ITEM
{
    [ProtoMember(1)]

    public uint result { get; set; }
    [ProtoMember(2)]
    public _cost_info[] cost_info { get; set; }
    [ProtoMember(3)]
    public _character_inven_item[] update_items { get; set; }
    [ProtoMember(4)]
    public bool is_send_mail { get; set; }
    [ProtoMember(5)]
    public int goods_id { get; set; }
    [ProtoMember(6)]
    public long insert_time { get; set; }

}

[ProtoContract]
public class CLIENT_GAME_GET_CASHBAG_ITEM
{
    [ProtoMember(1)]

    public long pay_id { get; set; }
    [ProtoMember(2)]
    public int pay_second_id { get; set; }

}

[ProtoContract]
public class GAME_CLIENT_GET_CASHBAG_ITEM
{
    [ProtoMember(1)]

    public uint result { get; set; }
    [ProtoMember(2)]
    public _cost_info[] cost_info { get; set; }
    [ProtoMember(3)]
    public _character_inven_item[] update_items { get; set; }
    [ProtoMember(4)]
    public uint reason_send_mail { get; set; }
    [ProtoMember(5)]
    public long pay_id { get; set; }
    [ProtoMember(6)]
    public int pay_second_id { get; set; }

}

[ProtoContract]
public class CLIENT_GAME_GET_CASHBAG_ITEM_MULTI
{
    [ProtoMember(1)]

    public bool is_gift { get; set; }

}

[ProtoContract]
public class _cashbag_index
{
    [ProtoMember(1)]

    public long pay_id { get; set; }
    [ProtoMember(2)]
    public int pay_second_id { get; set; }

}

[ProtoContract]
public class GAME_CLIENT_GET_CASHBAG_ITEM_MULTI
{
    [ProtoMember(1)]

    public uint result { get; set; }
    [ProtoMember(2)]
    public uint stop_result { get; set; }
    [ProtoMember(3)]
    public _cashbag_index[] index_list { get; set; }
    [ProtoMember(4)]
    public _cost_info[] cost_info { get; set; }
    [ProtoMember(5)]
    public _character_inven_item[] update_items { get; set; }
    [ProtoMember(6)]
    public bool is_end { get; set; }

}

[ProtoContract]
public class SHOP_WORLD_SHOP_DATA_PURGE
{

}

[ProtoContract]
public class WORLD_GAME_SHOP_DATA_PURGE
{
}

[ProtoContract]
public class CLIENT_GAME_GET_PERIOD_GOODS
{
    [ProtoMember(1)]

    public int goods_id { get; set; }

}

[ProtoContract]
public class GAME_CLIENT_GET_PERIOD_GOODS
{
    [ProtoMember(1)]

    public uint result { get; set; }
    [ProtoMember(2)]
    public int goods_id { get; set; }
    [ProtoMember(3)]
    public _cost_info[] cost_info { get; set; }
    [ProtoMember(4)]
    public _character_inven_item[] update_items { get; set; }
    [ProtoMember(5)]
    _period_goods_data period_goods_info { get; set; }
    [ProtoMember(6)]
    public uint reason_send_mail { get; set; }
    [ProtoMember(7)]
    public bool is_reset { get; set; }

}

[ProtoContract]
public class GAME_CLIENT_RESET_PERIOD_GOODS
{
    [ProtoMember(1)]

    public int[] goods_id { get; set; }

}

[ProtoContract]
public class CLIENT_GAME_UI_SHOP_BUY_CASHITEM_PROMO_VERIFY
{
    [ProtoMember(1)]

    public string player_key { get; set; }
    [ProtoMember(2)]
    public string user_agent { get; set; }
    [ProtoMember(3)]
    public string item_name { get; set; }
    [ProtoMember(4)]
    public string product_id { get; set; }
    [ProtoMember(5)]
    public string purchase_token { get; set; }
    [ProtoMember(6)]
    public int shop_goods_id { get; set; }

}

[ProtoContract]
public class GAME_CLIENT_UI_SHOP_BUY_CASHITEM_PROMO_VERIFY
{
    [ProtoMember(1)]

    public int result { get; set; }
    [ProtoMember(2)]
    public string purchase_token { get; set; }

}

[ProtoContract]
public class UI_SHOP_GOODS_simple
{
    [ProtoMember(1)]

    public uint goodsid { get; set; }
    [ProtoMember(2)]
    public int onofftype { get; set; }
    [ProtoMember(3)]
    public long onofftimeend { get; set; }

}

[ProtoContract]
public class CLIENT_SHOP_UI_SHOP_REQUEST_METADATA_SIMPLE
{
}

[ProtoContract]
public class SHOP_CLIENT_UI_SHOP_RESPONSE_METADATA_SIMPLE
{
    [ProtoMember(1)]

    public int version { get; set; }
    [ProtoMember(2)]
    public UI_SHOP_GOODS_simple[] shop_goods { get; set; }
    [ProtoMember(3)]
    public bool is_end { get; set; }

}

[ProtoContract]
public class CLIENT_GAME_UI_SHOP_HYDRA_ORACLE
{

}

[ProtoContract]
public class GAME_CLIENT_UI_SHOP_HYDRA_ORACLE
{
    [ProtoMember(1)]

    public int result { get; set; }
    [ProtoMember(2)]
    public long last_update_time { get; set; }
    [ProtoMember(3)]
    public uint oracle { get; set; }
    [ProtoMember(4)]
    public float oracle_fee { get; set; }

}

[ProtoContract]
public class CLIENT_GAME_UI_SHOP_BUY_CASHITEM_START_HYDRA
{
    [ProtoMember(1)]

    public string player_key { get; set; }
    [ProtoMember(2)]
    public string item_name { get; set; }
    [ProtoMember(3)]
    public string product_id { get; set; }
    [ProtoMember(4)]
    public string total_price { get; set; }
    [ProtoMember(5)]
    public string user_agent { get; set; }
    [ProtoMember(6)]
    public int item_type { get; set; }
    [ProtoMember(7)]
    public uint shop_goods_ver { get; set; }
    [ProtoMember(8)]
    public int shop_goods_id { get; set; }
    [ProtoMember(9)]
    public string user_agent_id { get; set; }

}

[ProtoContract]
public class GAME_CLIENT_UI_SHOP_BUY_CASHITEM_START_HYDRA
{
    [ProtoMember(1)]

    public int result { get; set; }
    [ProtoMember(2)]
    public string pay_id { get; set; }
    [ProtoMember(3)]
    public int game_result { get; set; }
    [ProtoMember(4)]
    public long sign_id { get; set; }
    [ProtoMember(5)]
    public long sign_amount { get; set; }

}

[ProtoContract]
public class CLIENT_GAME_UI_SHOP_BUY_CASHITEM_VERIFY_HYDRA
{
    [ProtoMember(1)]

    public string pay_id { get; set; }
    [ProtoMember(2)]
    public string player_key { get; set; }
    [ProtoMember(3)]
    public string user_agent { get; set; }
    [ProtoMember(4)]
    public string purchase_token { get; set; }
    [ProtoMember(5)]
    public int item_type { get; set; }
    [ProtoMember(6)]
    public uint shop_goods_ver { get; set; }
    [ProtoMember(7)]
    public int shop_goods_id { get; set; }

}

[ProtoContract]
public class GAME_CLIENT_UI_SHOP_BUY_CASHITEM_VERIFY_HYDRA
{
    [ProtoMember(1)]

    public int result { get; set; }
    [ProtoMember(2)]
    public float hydra_amount { get; set; }

}

[ProtoContract]
public class WORLD_GAME_UPDATE_HYDRA_ORACLE
{
    [ProtoMember(1)]

    public uint hydra_oracle_new { get; set; }
    [ProtoMember(2)]
    public ulong next_update_time_new { get; set; }
    [ProtoMember(3)]
    public ulong last_update_time_new { get; set; }
    [ProtoMember(4)]
    public uint hydra_oracle { get; set; }
    [ProtoMember(5)]
    public ulong next_update_time { get; set; }
    [ProtoMember(6)]
    public ulong last_update_time { get; set; }

}

[ProtoContract]
public class product_info
{
    [ProtoMember(1)]

    public int shop_goods_id { get; set; }
    [ProtoMember(2)]
    public int count { get; set; }

}

[ProtoContract]
public class CLIENT_GAME_UI_SHOP_BUY_CASHITEM_START_HYDRA_MULTI
{
    [ProtoMember(1)]

    public string player_key { get; set; }
    [ProtoMember(2)]
    public uint shop_goods_ver { get; set; }
    [ProtoMember(3)]
    public product_info[] product_info_list { get; set; }

}

[ProtoContract]
public class GAME_CLIENT_UI_SHOP_BUY_CASHITEM_START_HYDRA_MULTI
{
    [ProtoMember(1)]

    public int result { get; set; }
    [ProtoMember(2)]
    public string pay_id { get; set; }
    [ProtoMember(3)]
    public int game_result { get; set; }
    [ProtoMember(4)]
    public long sign_id { get; set; }
    [ProtoMember(5)]
    public long sign_amount { get; set; }

}

[ProtoContract]
public class CLIENT_GAME_UI_SHOP_BUY_CASHITEM_VERIFY_HYDRA_MULTI
{
    [ProtoMember(1)]

    public string pay_id { get; set; }
    [ProtoMember(2)]
    public string player_key { get; set; }
    [ProtoMember(3)]
    public string purchase_token { get; set; }
    [ProtoMember(4)]
    public uint shop_goods_ver { get; set; }
    [ProtoMember(5)]
    public product_info[] product_info_list { get; set; }

}

[ProtoContract]
public class GAME_CLIENT_UI_SHOP_BUY_CASHITEM_VERIFY_HYDRA_MULTI
{
    [ProtoMember(1)]

    public int result { get; set; }
    [ProtoMember(2)]
    public float hydra_amount { get; set; }

}

[ProtoContract]
public class GAME_CLIENT_UI_SHOP_BUY_HYDRA_MULTI
{
    [ProtoMember(1)]

    public uint result { get; set; }
    [ProtoMember(2)]
    public product_info[] product_info_list { get; set; }

}

[ProtoContract]
public class GAME_CLIENT_UI_SHOP_BUY_MULTI
{
    [ProtoMember(1)]

    public uint result { get; set; }
    [ProtoMember(2)]
    public product_info[] product_info_list { get; set; }

}

[ProtoContract]
public class CLIENT_GAME_UI_SHOP_BUY_CASHITEM_START_WEMIX_DOLLAR
{
    [ProtoMember(1)]

    public string player_key { get; set; }
    [ProtoMember(2)]
    public string item_name { get; set; }
    [ProtoMember(3)]
    public string product_id { get; set; }
    [ProtoMember(4)]
    public int item_type { get; set; }
    [ProtoMember(5)]
    public uint shop_goods_ver { get; set; }
    [ProtoMember(6)]
    public int shop_goods_id { get; set; }

}

[ProtoContract]
public class GAME_CLIENT_UI_SHOP_BUY_CASHITEM_START_WEMIX_DOLLAR
{
    [ProtoMember(1)]

    public int result { get; set; }
    [ProtoMember(2)]
    public string pay_id { get; set; }
    [ProtoMember(3)]
    public int game_result { get; set; }
    [ProtoMember(4)]
    public string tx_hash { get; set; }
    [ProtoMember(5)]
    public string total_price { get; set; }

}

[ProtoContract]
public class CLIENT_GAME_UI_SHOP_BUY_CASHITEM_VERIFY_WEMIX_DOLLAR
{
    [ProtoMember(1)]

    public string pay_id { get; set; }
    [ProtoMember(2)]
    public string player_key { get; set; }
    [ProtoMember(3)]
    public string user_sig { get; set; }
    [ProtoMember(4)]
    public int item_type { get; set; }
    [ProtoMember(5)]
    public uint shop_goods_ver { get; set; }
    [ProtoMember(6)]
    public int shop_goods_id { get; set; }

}

[ProtoContract]
public class GAME_CLIENT_UI_SHOP_BUY_CASHITEM_VERIFY_WEMIX_DOLLAR
{
    [ProtoMember(1)]

    public int result { get; set; }
    [ProtoMember(2)]
    public int wemix_dollar_amount { get; set; }

}

[ProtoContract]
public class CLIENT_GAME_UI_SHOP_BUY_CASHITEM_START_WEMIX_DOLLAR_MULTI
{
    [ProtoMember(1)]

    public string player_key { get; set; }
    [ProtoMember(2)]
    public uint shop_goods_ver { get; set; }
    [ProtoMember(3)]
    public product_info[] product_info_list { get; set; }

}

[ProtoContract]
public class GAME_CLIENT_UI_SHOP_BUY_CASHITEM_START_WEMIX_DOLLAR_MULTI
{
    [ProtoMember(1)]

    public int result { get; set; }
    [ProtoMember(2)]
    public string pay_id { get; set; }
    [ProtoMember(3)]
    public int game_result { get; set; }
    [ProtoMember(4)]
    public string tx_hash { get; set; }
    [ProtoMember(5)]
    public string total_price { get; set; }

}

[ProtoContract]
public class CLIENT_GAME_UI_SHOP_BUY_CASHITEM_VERIFY_WEMIX_DOLLAR_MULTI
{
    [ProtoMember(1)]

    public string pay_id { get; set; }
    [ProtoMember(2)]
    public string player_key { get; set; }
    [ProtoMember(3)]
    public string user_sig { get; set; }
    [ProtoMember(4)]
    public uint shop_goods_ver { get; set; }
    [ProtoMember(5)]
    public product_info[] product_info_list { get; set; }

}

[ProtoContract]
public class GAME_CLIENT_UI_SHOP_BUY_CASHITEM_VERIFY_WEMIX_DOLLAR_MULTI
{
    [ProtoMember(1)]

    public int result { get; set; }
    [ProtoMember(2)]
    public int wemix_dollar_amount { get; set; }

}

[ProtoContract]
public class GAME_CLIENT_UI_SHOP_BUY_WEMIX_DOLLAR_MULTI
{
    [ProtoMember(1)]

    public uint result { get; set; }
    [ProtoMember(2)]
    public product_info[] product_info_list { get; set; }

}

[ProtoContract]
public class CLIENT_GAME_SEND_GIFT_CASHBAG
{
    [ProtoMember(1)]

    public long character_uid { get; set; }
    [ProtoMember(2)]
    public _cashbag_index[] send_gift_infos { get; set; }

}

[ProtoContract]
public class GAME_CLIENT_SEND_GIFT_CASHBAG
{
    [ProtoMember(1)]

    public uint result { get; set; }
    [ProtoMember(2)]
    public _cashbag_index[] send_gift_infos { get; set; }

}

[ProtoContract]
public class CLIENT_GAME_SEND_GIFT_GUILD_FRIENDSHIP_LIST
{
    [ProtoMember(1)]

    public bool is_guild_inven { get; set; }
    [ProtoMember(2)]
    public int receive_money_limit_type { get; set; }

}

[ProtoContract]
public class GAME_CLIENT_SEND_GIFT_GUILD_FRIENDSHIP_LIST
{
    [ProtoMember(1)]

    public int result { get; set; }
    [ProtoMember(2)]
    public _guild_friendship_info[] friendship_list { get; set; }

}

[ProtoContract]
public class CLIENT_WORLD_SEND_GIFT_GUILD_MEMBER_LIST
{
    [ProtoMember(1)]

    public ulong guild_uid { get; set; }

}

[ProtoContract]
public class WORLD_CLIENT_SEND_GIFT_GUILD_MEMBER_LIST
{
    [ProtoMember(1)]

    public uint result { get; set; }
    [ProtoMember(2)]
    public ulong guild_uid { get; set; }
    [ProtoMember(3)]
    public _guild_member_info[] member_list { get; set; }
    [ProtoMember(5)]
    public bool is_full_member_list { get; set; }

}

[ProtoContract]
public class GAME_WORLD_NOTI_GIFT_CASHBAG
{
    [ProtoMember(1)]

    public long receiver_character_uid { get; set; }
    [ProtoMember(2)]
    public long sender_character_uid { get; set; }
    [ProtoMember(3)]
    public string sender_character_name { get; set; }
    [ProtoMember(4)]
    public string sender_profile { get; set; }
    [ProtoMember(5)]
    public _cashbag_index[] send_gift_infos { get; set; }

}

[ProtoContract]
public class WORLD_GAME_NOTI_GIFT_CASHBAG
{
    [ProtoMember(1)]

    public long receiver_character_uid { get; set; }
    [ProtoMember(2)]
    public long sender_character_uid { get; set; }
    [ProtoMember(3)]
    public string sender_character_name { get; set; }
    [ProtoMember(4)]
    public string sender_profile { get; set; }
    [ProtoMember(5)]
    public _cashbag_index[] send_gift_infos { get; set; }

}

[ProtoContract]
public class GAME_WORLD_WHISPER_GIFT_CASHBAG
{
    [ProtoMember(1)]

    public long sender_user_uid { get; set; }
    [ProtoMember(2)]
    public long receiver_user_uid { get; set; }

}

[ProtoContract]
public class WORLD_CLIENT_WHISPER_GIFT_CASHBAG
{
    [ProtoMember(1)]

    public uint result { get; set; }
    [ProtoMember(2)]
    public long sender_user_uid { get; set; }
    [ProtoMember(3)]
    public string sender_nick_name { get; set; }
    [ProtoMember(4)]
    public string sender_profile { get; set; }
    [ProtoMember(5)]
    public uint world_id { get; set; }
    [ProtoMember(6)]
    public uint chatting_server_world_id { get; set; }

}

[ProtoContract]
public class _gift_cashbag_history
{
    [ProtoMember(1)]

    public ulong gift_time { get; set; }
    [ProtoMember(2)]
    public int shop_goods_id { get; set; }
    [ProtoMember(3)]
    public string character_name { get; set; }

}

[ProtoContract]
public class CLIENT_GAME_SEND_GIFT_CASHBAG_HISTORY_LIST
{
}

[ProtoContract]
public class GAME_CLIENT_SEND_GIFT_CASHBAG_HISTORY_LIST
{
    [ProtoMember(1)]

    public uint result { get; set; }
    [ProtoMember(2)]
    public _gift_cashbag_history[] gift_cashbag_history_list { get; set; }

}

[ProtoContract]
public class CLIENT_GAME_RECEIVE_GIFT_CASHBAG_HISTORY_LIST
{

}

[ProtoContract]
public class GAME_CLIENT_RECEIVE_GIFT_CASHBAG_HISTORY_LIST
{
    [ProtoMember(1)]

    public uint result { get; set; }
    [ProtoMember(2)]
    public _gift_cashbag_history[] gift_cashbag_history_list { get; set; }

}


[ProtoContract]
public class _target_info
{
    [ProtoMember(1)]

    public int target_type { get; set; }
    [ProtoMember(2)]
    public ulong target_uid { get; set; }
    [ProtoMember(3)]
    public uint target_sub_id { get; set; }

}

[ProtoContract]
public class _monster_parts_info
{
    [ProtoMember(1)]

    public ulong monster_uid { get; set; }
    [ProtoMember(2)]
    public uint parts_id { get; set; }

}

[ProtoContract]
public class _struck_info
{
    [ProtoMember(1)]

    public int target_type { get; set; }
    [ProtoMember(2)]
    public ulong target_uid { get; set; }
    [ProtoMember(3)]
    public uint target_sub_id { get; set; }
    [ProtoMember(4)]
    public _vector3 loc { get; set; }
    [ProtoMember(5)]
    public int damage { get; set; }
    [ProtoMember(6)]
    public int hp { get; set; }
    [ProtoMember(7)]
    public int crowd { get; set; }
    [ProtoMember(8)]
    public int cctime_ms { get; set; }
    [ProtoMember(9)]
    public uint attacker_cur_skill_step { get; set; }
    [ProtoMember(10)]
    public int damage_type { get; set; }
    [ProtoMember(11)]
    public bool critical { get; set; }
    [ProtoMember(12)]
    public bool smite { get; set; }
    [ProtoMember(13)]
    public int shield_damage { get; set; }
    [ProtoMember(14)]
    public int damage_absorb { get; set; }
    [ProtoMember(15)]
    public int cur_damage_absorb { get; set; }

}

[ProtoContract]
public class CLIENT_GAME_ATTACK
{
    [ProtoMember(1)]

    public int state { get; set; }
    [ProtoMember(2)]
    public int skill { get; set; }
    [ProtoMember(3)]
    public int attack_id { get; set; }
    [ProtoMember(4)]
    public _vector3 loc_start { get; set; }
    [ProtoMember(5)]
    public _vector3 loc_end { get; set; }
    [ProtoMember(6)]
    public _attack_target_info[] targets { get; set; }
    [ProtoMember(7)]
    public _vector3 attack_direction_vector { get; set; }
    [ProtoMember(8)]
    public uint cur_skill_step { get; set; }
    [ProtoMember(9)]
    public _monster_parts_info[] target_monster_parts_list { get; set; }

}

[ProtoContract]
public class GAME_CLIENT_ATTACK
{
    [ProtoMember(1)]

    public ulong uid { get; set; }
    [ProtoMember(2)]
    public int state { get; set; }
    [ProtoMember(3)]
    public int skill { get; set; }
    [ProtoMember(4)]
    public int attack_id { get; set; }
    [ProtoMember(5)]
    public _vector3 loc_start { get; set; }
    [ProtoMember(6)]
    public _vector3 loc_end { get; set; }
    [ProtoMember(7)]
    public _attack_target_info[] targets { get; set; }
    [ProtoMember(8)]
    public uint cur_skill_step { get; set; }
    [ProtoMember(9)]
    public _vector3 direction { get; set; }
    [ProtoMember(10)]
    public int cool_time { get; set; }

}

[ProtoContract]
public class CLIENT_GAME_ATTACK_CHAIN
{
    [ProtoMember(1)]

    public int state { get; set; }
    [ProtoMember(2)]
    public int skill { get; set; }
    [ProtoMember(3)]
    public int attack_id { get; set; }
    [ProtoMember(4)]
    public _vector3 loc_start { get; set; }
    [ProtoMember(5)]
    public _vector3 loc_end { get; set; }
    [ProtoMember(6)]
    public _vector3 attack_direction_vector { get; set; }
    [ProtoMember(7)]
    public uint cur_skill_step { get; set; }
    [ProtoMember(8)]
    public _target_info[] target_list { get; set; }

}

[ProtoContract]
public class GAME_CLIENT_ATTACK_CHAIN
{
    [ProtoMember(1)]

    public ulong uid { get; set; }
    [ProtoMember(2)]
    public int state { get; set; }
    [ProtoMember(3)]
    public int skill { get; set; }
    [ProtoMember(4)]
    public int attack_id { get; set; }
    [ProtoMember(5)]
    public _vector3 loc_start { get; set; }
    [ProtoMember(6)]
    public _vector3 loc_end { get; set; }
    [ProtoMember(7)]
    public uint cur_skill_step { get; set; }
    [ProtoMember(8)]
    public _vector3 direction { get; set; }
    [ProtoMember(9)]
    public _target_info[] target_list { get; set; }
    [ProtoMember(10)]
    public int cool_time { get; set; }

}

[ProtoContract]
public class CLIENT_GAME_ATTACK_CANCEL
{
    [ProtoMember(1)]

    public int attack_id { get; set; }

}

[ProtoContract]
public class CLIENT_GAME_ATTACK_IN_PHASING
{
    [ProtoMember(1)]

    public int attacker_type { get; set; }
    [ProtoMember(2)]
    public ulong attacker { get; set; }
    [ProtoMember(3)]
    public int skill { get; set; }
    [ProtoMember(4)]
    public int attack_id { get; set; }
    [ProtoMember(5)]
    public _phasing_target_info[] targets { get; set; }

}

[ProtoContract]
public class GAME_CLIENT_STRUCK_IN_PHASING
{
    [ProtoMember(1)]

    public int skillid { get; set; }
    [ProtoMember(2)]
    public int attacker_type { get; set; }
    [ProtoMember(3)]
    public ulong attacker { get; set; }
    [ProtoMember(4)]
    public _phasing_target_damage[] damages { get; set; }

}

[ProtoContract]
public class GAME_CLIENT_STRUCK
{
    [ProtoMember(1)]

    public int type { get; set; }
    [ProtoMember(2)]
    public ulong uid { get; set; }
    [ProtoMember(3)]
    public int skillid { get; set; }
    [ProtoMember(4)]
    public int attacker_type { get; set; }
    [ProtoMember(5)]
    public ulong attacker { get; set; }
    [ProtoMember(6)]
    public _vector3 loc { get; set; }
    [ProtoMember(7)]
    public int damage { get; set; }
    [ProtoMember(8)]
    public uint hp { get; set; }
    [ProtoMember(9)]
    public int crowd { get; set; }
    [ProtoMember(10)]
    public int cctime_ms { get; set; }
    [ProtoMember(11)]
    public uint attacker_cur_skill_step { get; set; }
    [ProtoMember(12)]
    public int damage_type { get; set; }
    [ProtoMember(13)]
    public bool critical { get; set; }
    [ProtoMember(14)]
    public bool smite { get; set; }
    [ProtoMember(15)]
    public int shield_damage { get; set; }
    [ProtoMember(16)]
    public int damage_absorb { get; set; }
    [ProtoMember(17)]
    public int cur_damage_absorb { get; set; }
    [ProtoMember(18)]
    public long server_time_ms { get; set; }

}

[ProtoContract]
public class GAME_CLIENT_STRUCK_CHAIN
{
    [ProtoMember(1)]

    public int attack_id { get; set; }
    [ProtoMember(2)]
    public int attacker_type { get; set; }
    [ProtoMember(3)]
    public ulong attacker { get; set; }
    [ProtoMember(4)]
    public _struck_info[] struck_info_list { get; set; }
    [ProtoMember(5)]
    public long server_time_ms { get; set; }

}

[ProtoContract]
public class GAME_CLIENT_MONSTER_PARTS_STRUCK
{
    [ProtoMember(1)]

    public ulong monster_uid { get; set; }
    [ProtoMember(2)]
    public uint parts_id { get; set; }
    [ProtoMember(3)]
    public int skill_id { get; set; }
    [ProtoMember(4)]
    public int attacker_type { get; set; }
    [ProtoMember(5)]
    public ulong attacker_uid { get; set; }

}

[ProtoContract]
public class CLIENT_GAME_LEARN_SKILL
{
    [ProtoMember(1)]

    public ulong uid { get; set; }
    [ProtoMember(2)]
    public int skillindex { get; set; }

}

[ProtoContract]
public class GAME_CLIENT_LEARN_SKILL
{
    [ProtoMember(1)]

    public int skillindex { get; set; }
    [ProtoMember(2)]
    _stack_item_info del_item_info { get; set; }

}

[ProtoContract]
public class CLIENT_GAME_LEVEL_UP_SKILL
{
    [ProtoMember(1)]

    public ulong uid { get; set; }
    [ProtoMember(2)]
    public int skillindex { get; set; }

}

[ProtoContract]
public class GAME_CLIENT_LEVEL_UP_SKILL
{
    [ProtoMember(1)]

    public int skillindex { get; set; }
    [ProtoMember(2)]
    public _cost_info[] costinfo { get; set; }
    [ProtoMember(3)]
    _stack_item_info del_item_info { get; set; }
    [ProtoMember(4)]
    public _stack_item_info[] del_item_list { get; set; }

}

[ProtoContract]
public class CLIENT_GAME_ENTER_INVINCIBLE_STATE
{
    [ProtoMember(1)]

    public ulong uid { get; set; }

}

[ProtoContract]
public class CLIENT_GAME_LEAVE_INVINCIBLE_STATE
{
    [ProtoMember(1)]

    public ulong uid { get; set; }

}

[ProtoContract]
public class GAME_CLIENT_SKILL_ERROR
{
    [ProtoMember(1)]

    public int result { get; set; }
    [ProtoMember(2)]
    public int skill_id { get; set; }

}

[ProtoContract]
public class CLIENT_GAME_SKILL_DECK_SLOT_SET
{
    [ProtoMember(1)]

    public int deckId { get; set; }
    [ProtoMember(2)]
    public int slotId { get; set; }
    [ProtoMember(3)]
    public int skillId { get; set; }

}

[ProtoContract]
public class GAME_CLIENT_SKILL_DECK_SLOT_SET
{
    [ProtoMember(1)]

    public int result { get; set; }
    [ProtoMember(2)]
    _character_skill_deck deck { get; set; }

}

[ProtoContract]
public class CLIENT_GAME_SKILL_DECK_SLOT_DEL
{
    [ProtoMember(1)]

    public int deckId { get; set; }
    [ProtoMember(2)]
    public int slotId { get; set; }

}

[ProtoContract]
public class GAME_CLIENT_SKILL_DECK_SLOT_DEL
{
    [ProtoMember(1)]

    public int result { get; set; }
    [ProtoMember(2)]
    public int deckId { get; set; }
    [ProtoMember(3)]
    public int slotId { get; set; }

}

[ProtoContract]
public class CLIENT_GAME_SKILL_DECK_CHANGE
{
    [ProtoMember(1)]

    public int deckId { get; set; }

}

[ProtoContract]
public class GAME_CLIENT_SKILL_DECK_CHANGE
{
    [ProtoMember(1)]

    public int result { get; set; }
    [ProtoMember(2)]
    public int deckId { get; set; }

}

[ProtoContract]
public class _skill_cool_time
{
    [ProtoMember(1)]

    public int skill_index { get; set; }
    [ProtoMember(2)]
    public int fall_cool_time { get; set; }

}

[ProtoContract]
public class GAME_CLIENT_SKILL_COOL_TIME_FALL
{
    [ProtoMember(1)]

    public _skill_cool_time[] data_list { get; set; }

}

[ProtoContract]
public class GAME_CLIENT_SKILL_NOT_EXIST_TARGET_LIST
{
    [ProtoMember(1)]

    public _attack_target_info[] targets { get; set; }

}

[ProtoContract]
public class CLIENT_GAME_SKILL_NON_TARGET_GUILD_LIST
{
    [ProtoMember(1)]

    public ulong[] guild_uid_list { get; set; }

}


[ProtoContract]
public class CLIENT_GAME_SKILL_PASSIVE_GROUP_LIST
{
    [ProtoMember(1)]

    public ulong uid { get; set; }

}

[ProtoContract]
public class GAME_CLIENT_SKILL_PASSIVE_GROUP_LIST
{
    [ProtoMember(1)]

    public _skill_passive_group[] group_infos { get; set; }

}

[ProtoContract]
public class CLIENT_GAME_SKILL_PASSIVE_LIST
{
    [ProtoMember(1)]

    public ulong uid { get; set; }

}

[ProtoContract]
public class GAME_CLIENT_SKILL_PASSIVE_LIST
{
    [ProtoMember(1)]

    public _passive_skill_info[] passive_infos { get; set; }

}


[ProtoContract]
public class _monster_part_state_info
{
    [ProtoMember(1)]

    public int parts_id { get; set; }
    [ProtoMember(2)]
    public bool is_on { get; set; }
    [ProtoMember(3)]
    public int parts_hp { get; set; }

}

[ProtoContract]
public class _user_appear_casting_info
{
    [ProtoMember(1)]

    public bool is_casting { get; set; }
    [ProtoMember(2)]
    public int casting_target_type { get; set; }
    [ProtoMember(3)]
    public ulong casting_target_uid { get; set; }
    [ProtoMember(4)]
    public uint casting_type { get; set; }

}

[ProtoContract]
public class GAME_CLIENT_APPEAR_USER
{
    [ProtoMember(1)]

    public ulong uid { get; set; }
    [ProtoMember(2)]
    public int classId { get; set; }
    [ProtoMember(3)]
    public string nickname { get; set; }
    [ProtoMember(4)]
    public _vector3 loc { get; set; }
    [ProtoMember(5)]
    public _vector3 dest_pos { get; set; }
    [ProtoMember(6)]
    public float degree { get; set; }
    [ProtoMember(7)]
    public int hp { get; set; }
    [ProtoMember(8)]
    public int level { get; set; }
    [ProtoMember(9)]
    public int weapon_id { get; set; }
    [ProtoMember(10)]
    public int costume_id { get; set; }
    [ProtoMember(11)]
    public int hair_color_index_id { get; set; }
    [ProtoMember(12)]
    public int clothes_color_index { get; set; }
    [ProtoMember(13)]
    public int vehicle_id { get; set; }
    [ProtoMember(14)]
    public int weapon_level { get; set; }
    [ProtoMember(15)]
    public int state { get; set; }
    [ProtoMember(16)]
    public int anim_state { get; set; }
    [ProtoMember(17)]
    public float moveSpeed { get; set; }
    [ProtoMember(18)]
    public int actionState { get; set; }
    [ProtoMember(19)]
    public _buff_special_effect_info[] special_effect_info { get; set; }
    [ProtoMember(20)]
    public int applied_crowd_control_type { get; set; }
    [ProtoMember(21)]
    public int applied_crowd_control_left_time { get; set; }
    [ProtoMember(22)]
    public int heightState { get; set; }
    [ProtoMember(23)]
    public int pk_grade { get; set; }
    [ProtoMember(24)]
    public int pk_assault { get; set; }
    [ProtoMember(25)]
    public int max_hp { get; set; }
    [ProtoMember(26)]
    public _guild_name_ui_info guild_info { get; set; }
    [ProtoMember(27)]
    public string custom_title { get; set; }
    [ProtoMember(28)]
    public customize_info[] customize_list { get; set; }
    [ProtoMember(29)]
    public _user_appear_casting_info casting_info { get; set; }
    [ProtoMember(30)]
    public _equip_costume_info[] equip_costume_list { get; set; }
    [ProtoMember(31)]
    public int pet_leader_id { get; set; }
    [ProtoMember(32)]
    public int is_wanted { get; set; }
    [ProtoMember(34)]
    public int faction { get; set; }
    [ProtoMember(35)]
    public uint world_id { get; set; }
    [ProtoMember(36)]
    public int battle_state { get; set; }
    [ProtoMember(37)]
    public ulong zone_uid { get; set; }
    [ProtoMember(38)]
    public _buff_info[] buff_list { get; set; }
    [ProtoMember(39)]
    public uint dominion_official_grade { get; set; }
    [ProtoMember(40)]
    public int guild_camp_kind { get; set; }
    [ProtoMember(41)]
    public bool assassin_mode { get; set; }
    [ProtoMember(42)]
    public bool is_sabuk_master { get; set; }
}

[ProtoContract]
public class GAME_CLIENT_APPEAR_NPC
{
    [ProtoMember(1)]

    public ulong uid { get; set; }
    [ProtoMember(2)]
    public int classid { get; set; }
    [ProtoMember(3)]
    public int type { get; set; }
    [ProtoMember(4)]
    public _vector3 loc { get; set; }
    [ProtoMember(5)]
    public _vector3 dest_pos { get; set; }
    [ProtoMember(6)]
    public _vector3 rot { get; set; }
    [ProtoMember(7)]
    public uint state { get; set; }
    [ProtoMember(8)]
    public ulong target_uid { get; set; }
    [ProtoMember(9)]
    public int hp { get; set; }
    [ProtoMember(10)]
    public int target_type { get; set; }
    [ProtoMember(11)]
    public _buff_info[] buff_list { get; set; }
    [ProtoMember(12)]
    public int applied_crowd_control_type { get; set; }
    [ProtoMember(13)]
    public int applied_crowd_control_left_time { get; set; }
    [ProtoMember(14)]
    public float degree { get; set; }
    [ProtoMember(15)]
    public bool event_state { get; set; }
    [ProtoMember(16)]
    public int event_state_left_time_ms { get; set; }
    [ProtoMember(17)]
    public int target_slot_index { get; set; }
    [ProtoMember(18)]
    public bool create_appear { get; set; }
    [ProtoMember(19)]
    public int event_ani_type_index { get; set; }
    [ProtoMember(20)]
    public int move_speed { get; set; }
    [ProtoMember(21)]
    public int state_elapsed_time { get; set; }
    [ProtoMember(22)]
    public int shield { get; set; }
    [ProtoMember(23)]
    public _monster_part_state_info[] parts_info_list { get; set; }
    [ProtoMember(24)]
    public uint cofirmation_drop_item_index { get; set; }
    [ProtoMember(25)]
    public ulong owner_guild_uid { get; set; }
    [ProtoMember(26)]
    public string owner_guild_name { get; set; }
    [ProtoMember(27)]
    public int effect_state { get; set; }
    [ProtoMember(28)]
    public int battle_state { get; set; }
    [ProtoMember(29)]
    public ulong zone_uid { get; set; }
    [ProtoMember(30)]
    public _guild_simple_info owner_guild_info { get; set; }
    [ProtoMember(31)]
    public int guild_camp_kind { get; set; }

}

[ProtoContract]
public class GAME_CLIENT_APPEAR_OBJECT
{
    [ProtoMember(1)]

    public ulong uid { get; set; }
    [ProtoMember(2)]
    public int object_id { get; set; }
    [ProtoMember(3)]
    public _vector3 loc { get; set; }
    [ProtoMember(4)]
    public _vector3 rot { get; set; }
    [ProtoMember(5)]
    public float degree { get; set; }
    [ProtoMember(6)]
    public bool create_appear { get; set; }
    [ProtoMember(7)]
    public _object_casting_info[] casting_info { get; set; }
    [ProtoMember(8)]
    _guild_simple_info owner_guild_info { get; set; }
    [ProtoMember(9)]
    public uint object_state { get; set; }
    [ProtoMember(10)]
    public uint remaining_use_cnt { get; set; }
    [ProtoMember(11)]
    public uint max_use_cnt { get; set; }
    [ProtoMember(12)]
    public uint cofirmation_drop_item_index { get; set; }
    [ProtoMember(13)]
    public string owner_nickname { get; set; }
    [ProtoMember(14)]
    public ulong owner_uid { get; set; }
    [ProtoMember(15)]
    public ulong zone_uid { get; set; }
    [ProtoMember(16)]
    public ulong death_penalty_owner_uid { get; set; }
    [ProtoMember(17)]
    public int guild_camp_kind { get; set; }
    [ProtoMember(18)]
    public bool steal_protected { get; set; }
    [ProtoMember(19)]
    public int item_id { get; set; }

}

[ProtoContract]
public class GAME_CLIENT_DISAPPEAR_ENTITY
{
    [ProtoMember(1)]

    public ulong uid { get; set; }
    [ProtoMember(2)]
    public int entity_type { get; set; }
    [ProtoMember(3)]
    public uint disappear_reason { get; set; }
    [ProtoMember(4)]
    public ulong zone_uid { get; set; }

}

[ProtoContract]
public class GAME_CLIENT_DISAPPEAR_ENTITY_LIST
{
    [ProtoMember(1)]

    public GAME_CLIENT_DISAPPEAR_ENTITY[] disappear_list { get; set; }

}

[ProtoContract]
public class CLIENT_GAME_SYNC_USER
{
    [ProtoMember(1)]

    public _vector3 loc { get; set; }
    [ProtoMember(2)]
    public _vector3 direction { get; set; }
    [ProtoMember(3)]
    public float moveSpeed { get; set; }
    [ProtoMember(4)]
    public int state { get; set; }
    [ProtoMember(5)]
    public int animState { get; set; }
    [ProtoMember(6)]
    public int heightState { get; set; }
    [ProtoMember(7)]
    public _vector3 dest_loc { get; set; }
    [ProtoMember(8)]
    public _vector3 fix_loc { get; set; }

}

[ProtoContract]
public class GAME_CLIENT_SYNC_USER
{
    [ProtoMember(1)]

    public ulong uid { get; set; }
    [ProtoMember(2)]
    public _vector3 loc { get; set; }
    [ProtoMember(3)]
    public _vector3 direction { get; set; }
    [ProtoMember(4)]
    public float moveSpeed { get; set; }
    [ProtoMember(5)]
    public int state { get; set; }
    [ProtoMember(6)]
    public int animState { get; set; }
    [ProtoMember(7)]
    public int heightState { get; set; }
    [ProtoMember(8)]
    public int actionState { get; set; }
    [ProtoMember(9)]
    public float degree { get; set; }
    [ProtoMember(10)]
    public _vector3 dest_loc { get; set; }
    [ProtoMember(11)]
    public int battle_state { get; set; }
    [ProtoMember(12)]
    public ulong zone_uid { get; set; }

}

[ProtoContract]
public class GAME_CLIENT_SYNCNPC
{
    [ProtoMember(1)]

    public ulong npc_uid { get; set; }
    [ProtoMember(2)]
    public uint state { get; set; }
    [ProtoMember(3)]
    public int type { get; set; }
    [ProtoMember(4)]
    public _vector3 dest_pos { get; set; }
    [ProtoMember(5)]
    public ulong target_uid { get; set; }
    [ProtoMember(6)]
    public int target_type { get; set; }
    [ProtoMember(7)]
    public int target_slot_index { get; set; }
    [ProtoMember(8)]
    public int move_speed { get; set; }
    [ProtoMember(9)]
    public int state_elapsed_time { get; set; }
    [ProtoMember(10)]
    public float degree { get; set; }
    [ProtoMember(11)]
    public _vector3 loc { get; set; }
    [ProtoMember(12)]
    public int state_event_value { get; set; }
    [ProtoMember(13)]
    public int battle_state { get; set; }
    [ProtoMember(14)]
    public ulong zone_uid { get; set; }

}

[ProtoContract]
public class GAME_CLIENT_SYNC_ROTATE
{
    [ProtoMember(1)]

    public ulong uid { get; set; }
    [ProtoMember(2)]
    public int type { get; set; }
    [ProtoMember(3)]
    public float dest_angle { get; set; }

}

[ProtoContract]
public class GAME_CLIENT_ENTER_MONSTER_EVENT_STATE
{
    [ProtoMember(1)]

    public ulong uid { get; set; }
    [ProtoMember(2)]
    public int state_time_ms { get; set; }
    [ProtoMember(3)]
    public int ani_type_index { get; set; }

}

[ProtoContract]
public class GAME_CLIENT_LEAVE_MONSTER_EVENT_STATE
{
    [ProtoMember(1)]

    public ulong uid { get; set; }

}

[ProtoContract]
public class _packet_s_sync_user_info_worldserver
{
    [ProtoMember(1)]

    public ulong uid { get; set; }
    [ProtoMember(2)]
    public int level { get; set; }
    [ProtoMember(3)]
    public int combat_point { get; set; }
    [ProtoMember(4)]
    public uint escape_stage_id { get; set; }
    [ProtoMember(5)]
    public _vector3 escape_pos { get; set; }
    [ProtoMember(6)]
    public ulong guild_uid { get; set; }
    [ProtoMember(7)]
    public ulong party_uid { get; set; }
    [ProtoMember(8)]
    public int class_id { get; set; }

}

[ProtoContract]
public class GAME_CLIENT_MONSTER_COMEBACK
{
    [ProtoMember(1)]

    public ulong monster_uid { get; set; }

}

[ProtoContract]
public class GAME_CLIENT_SYNC_PARTS_STATE
{
    [ProtoMember(1)]

    public ulong owner_monster_uid { get; set; }
    [ProtoMember(2)]
    public int parts_id { get; set; }
    [ProtoMember(3)]
    public bool is_on { get; set; }
    [ProtoMember(4)]
    public int parts_hp { get; set; }

}

[ProtoContract]
public class GAME_GATEWAY_ATTACH_BLOCK
{
    [ProtoMember(1)]

    public ulong user_uid { get; set; }
    [ProtoMember(2)]
    public ulong zone_uid { get; set; }
    [ProtoMember(3)]
    public int attach_block_index { get; set; }
    [ProtoMember(4)]
    public _vector3 user_pos { get; set; }

}

[ProtoContract]
public class GAME_GATEWAY_DETACH_BLOCK
{
    [ProtoMember(1)]

    public ulong user_uid { get; set; }
    [ProtoMember(2)]
    public ulong zone_uid { get; set; }
    [ProtoMember(3)]
    public int detach_block_index { get; set; }

}

[ProtoContract]
public class GAME_GATEWAY_CHANGE_BLOCK
{
    [ProtoMember(1)]

    public ulong user_uid { get; set; }
    [ProtoMember(2)]
    public ulong zone_uid { get; set; }
    [ProtoMember(3)]
    public int prev_block_index { get; set; }
    [ProtoMember(4)]
    public int cur_block_index { get; set; }
    [ProtoMember(5)]
    public _vector3 user_pos { get; set; }

}

[ProtoContract]
public class GAME_GATEWAY_CHANGE_BLOCK_USER_SYNC
{
    [ProtoMember(1)]

    public ulong user_uid { get; set; }
    [ProtoMember(2)]
    public ulong zone_uid { get; set; }
    [ProtoMember(3)]
    public int prev_block_index { get; set; }
    [ProtoMember(4)]
    public int cur_block_index { get; set; }
    [ProtoMember(5)]
    public _vector3 user_pos { get; set; }
    [ProtoMember(6)]
    GAME_CLIENT_SYNC_USER sync_packet { get; set; }
    [ProtoMember(7)]
    GAME_CLIENT_APPEAR_USER appear_packet { get; set; }
    [ProtoMember(8)]
    GAME_CLIENT_DISAPPEAR_ENTITY disappear_packet { get; set; }

}

[ProtoContract]
public class GAME_GATEWAY_CHANGE_BLOCK_MONSTER_SYNC
{
    [ProtoMember(1)]

    public ulong zone_uid { get; set; }
    [ProtoMember(2)]
    public int prev_block_index { get; set; }
    [ProtoMember(3)]
    public int cur_block_index { get; set; }
    [ProtoMember(4)]
    GAME_CLIENT_APPEAR_NPC monster_appear { get; set; }
    [ProtoMember(5)]
    public uint broad_cast_range { get; set; }
    [ProtoMember(6)]
    GAME_CLIENT_DISAPPEAR_ENTITY disappear_packet { get; set; }

}

[ProtoContract]
public class GAME_GATEWAY_CHANGE_BLOCK_USER_ATTACK
{
    [ProtoMember(1)]

    public ulong user_uid { get; set; }
    [ProtoMember(2)]
    public ulong zone_uid { get; set; }
    [ProtoMember(3)]
    public int prev_block_index { get; set; }
    [ProtoMember(4)]
    public int cur_block_index { get; set; }
    [ProtoMember(5)]
    public _vector3 user_pos { get; set; }
    [ProtoMember(6)]
    GAME_CLIENT_APPEAR_USER appear_packet { get; set; }
    [ProtoMember(7)]
    GAME_CLIENT_DISAPPEAR_ENTITY disappear_packet { get; set; }
    [ProtoMember(8)]
    GAME_CLIENT_ATTACK attack_packet { get; set; }

}

[ProtoContract]
public class GAME_GATEWAY_CHANGE_BLOCK_USER_ATTACK_CHAIN
{
    [ProtoMember(1)]

    public ulong user_uid { get; set; }
    [ProtoMember(2)]
    public ulong zone_uid { get; set; }
    [ProtoMember(3)]
    public int prev_block_index { get; set; }
    [ProtoMember(4)]
    public int cur_block_index { get; set; }
    [ProtoMember(5)]
    public _vector3 user_pos { get; set; }
    [ProtoMember(6)]
    GAME_CLIENT_APPEAR_USER appear_packet { get; set; }
    [ProtoMember(7)]
    GAME_CLIENT_ATTACK_CHAIN attack_chain_packet { get; set; }
    [ProtoMember(8)]
    GAME_CLIENT_DISAPPEAR_ENTITY disappear_packet { get; set; }

}

[ProtoContract]
public class GAME_CLIENT_NPC_SHIELD_INFO
{
    [ProtoMember(1)]

    public ulong uid { get; set; }
    [ProtoMember(2)]
    public ulong shield { get; set; }
    [ProtoMember(3)]
    public int reason { get; set; }

}

[ProtoContract]
public class GAME_CLIENT_COMBO_RETAIN_END
{
}

[ProtoContract]
public class CLIENT_GAME_AUTO_MOVE_DIRECTING
{
    [ProtoMember(1)]

    public uint index { get; set; }

}

[ProtoContract]
public class GAME_CLIENT_AUTO_MOVE_DIRECTING
{
    [ProtoMember(1)]

    public int entity_type { get; set; }
    [ProtoMember(2)]
    public ulong entity_uid { get; set; }
    [ProtoMember(3)]
    public uint auto_move_id { get; set; }

}

[ProtoContract]
public class CLIENT_GAME_QUEST_MOVE_POS
{
    [ProtoMember(1)]

    public _vector3 dest_loc { get; set; }
    [ProtoMember(2)]
    public int quest_index { get; set; }

}

[ProtoContract]
public class CLIENT_GAME_REQUEST_ENTITY_APPEAR_DATA
{
    [ProtoMember(1)]

    public ulong uid { get; set; }
    [ProtoMember(2)]
    public int entity_type { get; set; }

}

[ProtoContract]
public class CLIENT_GAME_SYNC_STATE
{
    [ProtoMember(1)]

    public int state { get; set; }
    [ProtoMember(2)]
    public int anim_state { get; set; }

}

[ProtoContract]
public class GAME_CLIENT_SYNC_STATE
{
    [ProtoMember(1)]

    public long user_uid { get; set; }
    [ProtoMember(2)]
    public int state { get; set; }
    [ProtoMember(3)]
    public int anim_state { get; set; }

}

[ProtoContract]
public class GAME_CLIENT_CHANGE_USER_STATE
{
    [ProtoMember(1)]

    public ulong user_uid { get; set; }
    [ProtoMember(2)]
    public int faction { get; set; }

}

[ProtoContract]
public class CLIENT_GAME_TARGET_BATTLE_INFO
{
    [ProtoMember(1)]

    public int entity_type { get; set; }
    [ProtoMember(2)]
    public ulong entity_uid { get; set; }

}

[ProtoContract]
public class GAME_CLIENT_TARGET_BATTLE_INFO
{
    [ProtoMember(1)]

    public int entity_type { get; set; }
    [ProtoMember(2)]
    public ulong entity_uid { get; set; }
    [ProtoMember(3)]
    public _stat_info[] stat_info_list { get; set; }

}

[ProtoContract]
public class GAME_CLIENT_CHANGE_DROP_OBJECT_STATE
{
    [ProtoMember(1)]

    public ulong entity_uid { get; set; }
    [ProtoMember(2)]
    public ulong owner_uid { get; set; }

}

[ProtoContract]
public class GAME_CLIENT_BATTLE_STATE
{
    [ProtoMember(1)]

    public ulong user_uid { get; set; }
    [ProtoMember(2)]
    public int battle_state { get; set; }

}

[ProtoContract]
public class CLIENT_GAME_RECONNECT_SYNC
{

}

[ProtoContract]
public class GAME_CLIENT_RECONNECT_SYNC
{
    [ProtoMember(1)]

    public ulong zone_uid { get; set; }
    [ProtoMember(2)]
    public uint stage_id { get; set; }
    [ProtoMember(3)]
    public uint hp { get; set; }
    [ProtoMember(4)]
    public uint mana { get; set; }
    [ProtoMember(5)]
    public uint vigor { get; set; }
    [ProtoMember(6)]
    public uint rage { get; set; }

}

[ProtoContract]
public class WORLD_GAME_SYNC_OTHERCHARACTER_INFO
{
    [ProtoMember(1)]

    public ulong uid { get; set; }

}

[ProtoContract]
public class CLIENT_GAME_CHARACTER_ALIVE_CHECK
{

}

[ProtoContract]
public class GAME_CLIENT_CHARACTER_ALIVE_CHECK
{
    [ProtoMember(1)]

    public bool alive { get; set; }
    [ProtoMember(2)]
    public ulong uid { get; set; }
    [ProtoMember(3)]
    public uint hp { get; set; }
    [ProtoMember(4)]
    public uint mana { get; set; }
    [ProtoMember(5)]
    public uint vigor { get; set; }
    [ProtoMember(6)]
    public int type { get; set; }
    [ProtoMember(7)]
    public int change_reason { get; set; }
    [ProtoMember(8)]
    public uint rage { get; set; }

}

[ProtoContract]
public class GAME_CLIENT_SYNC_ERROR
{
    [ProtoMember(1)]

    public int result { get; set; }

}

[ProtoContract]
public class CLIENT_GAME_SYNC_ROLL
{
    [ProtoMember(1)]

    public _vector3 loc { get; set; }
    [ProtoMember(2)]
    public _vector3 direction { get; set; }
    [ProtoMember(3)]
    public _vector3 dest_loc { get; set; }
    [ProtoMember(4)]
    public float moveSpeed { get; set; }
    [ProtoMember(5)]
    public int anim_state { get; set; }

}

[ProtoContract]
public class GAME_CLIENT_SYNC_ROLL
{
    [ProtoMember(1)]

    public int result { get; set; }
    [ProtoMember(2)]
    public _vector3 loc { get; set; }
    [ProtoMember(3)]
    public _vector3 direction { get; set; }
    [ProtoMember(4)]
    public _vector3 dest_loc { get; set; }
    [ProtoMember(5)]
    public float moveSpeed { get; set; }
    [ProtoMember(6)]
    public ulong server_time_ms { get; set; }
    [ProtoMember(7)]
    public int anim_state { get; set; }

}

[ProtoContract]
public class GAME_CLIENT_NTF_SYNC_NPC_GUILD_INFO
{
    [ProtoMember(1)]

    public ulong uid { get; set; }
    [ProtoMember(2)]
    _guild_simple_info owner_guild_info { get; set; }
    [ProtoMember(3)]
    public int guild_camp_kind { get; set; }

}

[ProtoContract]
public class GAME_CLIENT_NTF_SYNC_OBJECT_GUILD_INFO
{
    [ProtoMember(1)]

    public ulong uid { get; set; }
    [ProtoMember(2)]
    _guild_simple_info owner_guild_info { get; set; }
    [ProtoMember(3)]
    public int guild_camp_kind { get; set; }

}

[ProtoContract]
public class CLIENT_GAME_ERROR_STATE
{
    [ProtoMember(1)]

    public int state_type { get; set; }
    [ProtoMember(2)]
    public long param01 { get; set; }
    [ProtoMember(3)]
    public long param02 { get; set; }

}

[ProtoContract]
public class CLIENT_GAME_REQUEST_APPEAR_DATA
{
    [ProtoMember(1)]

    public int entity_type { get; set; }

}

[ProtoContract]
public class GAME_GATEWAY_RECV_BLOCK
{
    [ProtoMember(1)]

    public ulong character_uid { get; set; }
    [ProtoMember(2)]
    public bool block_flag { get; set; }

}


[ProtoContract]
public class CLIENT_GAME_END_LOADING
{
    [ProtoMember(1)]

    public long user_time { get; set; }

}

[ProtoContract]
public class GAME_CLIENT_END_LOADING
{
    [ProtoMember(1)]

    public int result { get; set; }

}

[ProtoContract]
public class CLIENT_GAME_HEARTBEAT
{

}

[ProtoContract]
public class GAME_CLIENT_HEARTBEAT
{

}

[ProtoContract]
public class CLIENT_FRONT_HEARTBEAT
{

}

[ProtoContract]
public class FRONT_CLIENT_HEARTBEAT
{

}

[ProtoContract]
public class GAME_CLIENT_ON_CONNECTED
{


}

[ProtoContract]
public class ON_DISCONNECT_SESSION
{

}

[ProtoContract]
public class ON_CONNECT_SESSION
{

}

[ProtoContract]
public class CLIENT_GATEWAY_HEARTBEAT
{
    [ProtoMember(1)]

    public long server_time { get; set; }

}

[ProtoContract]
public class GATEWAY_CLIENT_HEARTBEAT
{
    [ProtoMember(1)]

    public long server_time { get; set; }

}

[ProtoContract]
public class WORLD_GAME_NTF_ZONE_GROUP_START
{

}

[ProtoContract]
public class GAME_WORLD_REQUEST_ASSIGN_ZONEGROUP
{

}

[ProtoContract]
public class WORLD_GAME_ASSIGN_ZONEGROUP
{
    [ProtoMember(1)]

    public int zonegroup_index { get; set; }
    [ProtoMember(2)]
    public int monitor_update_time { get; set; }

}

[ProtoContract]
public class GAME_WORLD_ASSIGN_ZONEGROUP_RESULT
{
    [ProtoMember(1)]

    public string gameserver_public_ip { get; set; }
    [ProtoMember(2)]
    public int gameserver_connect_port { get; set; }
    [ProtoMember(3)]
    public int gameserver_zonegroup_index { get; set; }
    [ProtoMember(4)]
    public int gameserver_index { get; set; }
    [ProtoMember(5)]
    public bool gameserver_zonegroup_init { get; set; }

}

[ProtoContract]
public class GAME_WORLD_REQUEST_SERVER_INFO
{
    [ProtoMember(1)]

    public string ip_address { get; set; }
    [ProtoMember(2)]
    public int server_type { get; set; }
    [ProtoMember(3)]
    public uint server_index { get; set; }
    [ProtoMember(4)]
    public int server_category { get; set; }

}

[ProtoContract]
public class WORLD_GAME_SERVER_INFO
{
    [ProtoMember(1)]

    public uint gateway_server_listen_port { get; set; }
    [ProtoMember(2)]
    public uint macro_server_listen_port { get; set; }
    [ProtoMember(3)]
    public uint world_id { get; set; }
    [ProtoMember(4)]
    public _db_info[] db_info { get; set; }
    [ProtoMember(5)]
    public uint world_unique { get; set; }
    [ProtoMember(6)]
    public string world_name { get; set; }
    [ProtoMember(7)]
    public bool use_world_id { get; set; }

}

[ProtoContract]
public class GAME_WORLD_RECONNECT_SESSION
{
    [ProtoMember(1)]

    public uint server_index { get; set; }
    [ProtoMember(2)]
    public int gameserver_session_index { get; set; }

}

[ProtoContract]
public class WORLD_GAME_RECONNECT_SESSION
{
    [ProtoMember(1)]

    public int gameserver_session_index { get; set; }
    [ProtoMember(2)]
    public int world_zonegroup_index { get; set; }

}

[ProtoContract]
public class GAME_WORLD_NTF_SERVER_READY
{
    [ProtoMember(1)]

    public uint server_index { get; set; }
    [ProtoMember(2)]
    public int worker_thread_count { get; set; }

}

[ProtoContract]
public class GAME_WORLD_NOTIFY_SERVER_INFO
{
    [ProtoMember(1)]

    public int server_type { get; set; }
    [ProtoMember(2)]
    public uint server_index { get; set; }
    [ProtoMember(3)]
    public string ip_address { get; set; }
    [ProtoMember(4)]
    public int server_category { get; set; }

}

[ProtoContract]
public class WORLD_GAME_NOTIFY_SERVER_INFO
{
    [ProtoMember(1)]

    public int connected_session_count { get; set; }

}

[ProtoContract]
public class WORLD_REQUEST_SERVER_CATEGORY
{
    [ProtoMember(1)]

    public int game_server_index { get; set; }
    [ProtoMember(2)]
    public int game_server_category { get; set; }

}

[ProtoContract]
public class _game_server_info
{
    [ProtoMember(1)]

    public string game_server_ip { get; set; }
    [ProtoMember(2)]
    public uint game_server_index { get; set; }
    [ProtoMember(3)]
    public uint game_server_connect_port { get; set; }

}

[ProtoContract]
public class _packet_world_gateway_notify_game_server_info
{
    [ProtoMember(1)]

    public _game_server_info[] game_server_info { get; set; }

}

[ProtoContract]
public class _packet_world_gateway_notify_game_server_connect
{
    [ProtoMember(1)]

    _game_server_info game_server_info { get; set; }

}

[ProtoContract]
public class _packet_gateway_world_request_server_info
{
    [ProtoMember(1)]

    public string ip_address { get; set; }
    [ProtoMember(2)]
    public string public_ip { get; set; }
    [ProtoMember(3)]
    public uint public_port { get; set; }
    [ProtoMember(4)]
    public int server_type { get; set; }
    [ProtoMember(5)]
    public uint server_index { get; set; }

}

[ProtoContract]
public class _packet_world_gateway_server_info
{
    [ProtoMember(1)]

    public uint world_id { get; set; }
    [ProtoMember(2)]
    public _db_info[] db_info { get; set; }
    [ProtoMember(3)]
    public int monitor_update_time { get; set; }

}

[ProtoContract]
public class _packet_gateway_world_notify_server_info
{
    [ProtoMember(1)]

    public int server_type { get; set; }
    [ProtoMember(2)]
    public uint server_index { get; set; }
    [ProtoMember(3)]
    public ulong[] disconnect_users { get; set; }
    [ProtoMember(4)]
    public uint max_count { get; set; }

}

[ProtoContract]
public class GATEWAY_GAME_NOTIFY_SERVER_INFO
{
    [ProtoMember(1)]

    public int server_type { get; set; }
    [ProtoMember(2)]
    public uint server_index { get; set; }
    [ProtoMember(3)]
    public string ip_address { get; set; }

}

[ProtoContract]
public class _packet_world_macro_notify_game_server_info
{
    [ProtoMember(1)]

    public _game_server_info[] game_server_info { get; set; }

}

[ProtoContract]
public class _packet_world_macro_notify_game_server_connect
{
    [ProtoMember(1)]

    _game_server_info game_server_info { get; set; }

}

[ProtoContract]
public class _packet_macro_world_request_server_info
{
    [ProtoMember(1)]

    public string ip_address { get; set; }
    [ProtoMember(2)]
    public int server_type { get; set; }
    [ProtoMember(3)]
    public uint server_index { get; set; }

}

[ProtoContract]
public class _packet_world_macro_server_info
{
    [ProtoMember(1)]

    public uint world_id { get; set; }
    [ProtoMember(2)]
    public _db_info[] db_info { get; set; }
    [ProtoMember(3)]
    public int monitor_update_time { get; set; }

}

[ProtoContract]
public class _packet_macro_world_notify_server_info
{
    [ProtoMember(1)]

    public int server_type { get; set; }
    [ProtoMember(2)]
    public uint server_index { get; set; }
    [ProtoMember(3)]
    public uint macro_count_max { get; set; }

}

[ProtoContract]
public class _packet_macro_game_notify_server_info
{
    [ProtoMember(1)]

    public int server_type { get; set; }
    [ProtoMember(2)]
    public uint server_index { get; set; }
    [ProtoMember(3)]
    public string ip_address { get; set; }
    [ProtoMember(4)]
    public uint macro_count_max { get; set; }

}

[ProtoContract]
public class CHATTING_WORLD_REQUEST_SERVER_INFO
{
    [ProtoMember(1)]

    public string ip_address { get; set; }
    [ProtoMember(2)]
    public string public_ip_address { get; set; }
    [ProtoMember(3)]
    public uint public_port { get; set; }
    [ProtoMember(4)]
    public int server_type { get; set; }
    [ProtoMember(5)]
    public uint server_index { get; set; }

}

[ProtoContract]
public class CHATTING_WORLD_NOTIFY_SERVER_INFO
{
    [ProtoMember(1)]

    public int server_type { get; set; }
    [ProtoMember(2)]
    public uint server_index { get; set; }

}

[ProtoContract]
public class WORLD_CHATTING_SERVER_INFO
{
    [ProtoMember(1)]

    public uint world_id { get; set; }
    [ProtoMember(2)]
    public _db_info[] db_info { get; set; }
    [ProtoMember(3)]
    public bool use_world_id { get; set; }
    [ProtoMember(4)]
    public int monitor_update_time { get; set; }

}

[ProtoContract]
public class FRONT_WORLD_REQUEST_SERVER_INFO
{

}

[ProtoContract]
public class WORLD_FRONT_SERVER_INFO
{
    [ProtoMember(1)]

    public uint world_id { get; set; }

}

[ProtoContract]
public class FRONT_WORLD_SERVER_INFO
{
    [ProtoMember(1)]

    public uint world_id { get; set; }
    [ProtoMember(2)]
    public string world_name { get; set; }

}

[ProtoContract]
public class GATEWAY_CHATTING_NOTIFY_SERVER_INFO
{
    [ProtoMember(1)]

    public int server_type { get; set; }
    [ProtoMember(2)]
    public uint server_index { get; set; }
    [ProtoMember(3)]
    public string ip_address { get; set; }
    [ProtoMember(4)]
    public uint world_id { get; set; }

}

[ProtoContract]
public class MACRO_CHATTING_NOTIFY_SERVER_INFO
{
    [ProtoMember(1)]

    public int server_type { get; set; }
    [ProtoMember(2)]
    public uint server_index { get; set; }
    [ProtoMember(3)]
    public string ip_address { get; set; }
    [ProtoMember(4)]
    public uint world_id { get; set; }

}

[ProtoContract]
public class LOBBY_WORLD_REQUEST_SERVER_INFO
{
    [ProtoMember(1)]

    public string ip_address { get; set; }
    [ProtoMember(2)]
    public string public_ip_address { get; set; }
    [ProtoMember(3)]
    public uint public_port { get; set; }
    [ProtoMember(4)]
    public int server_type { get; set; }
    [ProtoMember(5)]
    public uint server_index { get; set; }

}

[ProtoContract]
public class WORLD_LOBBY_SERVER_INFO
{
    [ProtoMember(1)]

    public uint world_id { get; set; }
    [ProtoMember(2)]
    public _db_info[] db_info { get; set; }
    [ProtoMember(3)]
    public bool use_world_id { get; set; }
    [ProtoMember(4)]
    public int monitor_update_time { get; set; }

}

[ProtoContract]
public class LOBBY_WORLD_NOTIFY_SERVER_INFO
{
    [ProtoMember(1)]

    public int server_type { get; set; }
    [ProtoMember(2)]
    public uint server_index { get; set; }

}

[ProtoContract]
public class GATEWAY_LOBBY_NOTIFY_SERVER_INFO
{
    [ProtoMember(1)]

    public int server_type { get; set; }
    [ProtoMember(2)]
    public uint server_index { get; set; }
    [ProtoMember(3)]
    public uint world_id { get; set; }
    [ProtoMember(4)]
    public string ip_address { get; set; }

}

[ProtoContract]
public class MACRO_LOBBY_NOTIFY_SERVER_INFO
{
    [ProtoMember(1)]

    public int server_type { get; set; }
    [ProtoMember(2)]
    public uint server_index { get; set; }
    [ProtoMember(3)]
    public uint world_id { get; set; }
    [ProtoMember(4)]
    public string ip_address { get; set; }

}

[ProtoContract]
public class DBCACHE_WORLD_NOTIFY_SERVER_INFO
{
    [ProtoMember(1)]

    public int server_type { get; set; }
    [ProtoMember(2)]
    public uint server_index { get; set; }

}

[ProtoContract]
public class DBCACHE_WORLD_REQUEST_SERVER_INFO
{
    [ProtoMember(1)]

    public string ip_address { get; set; }
    [ProtoMember(2)]
    public string public_ip_address { get; set; }
    [ProtoMember(3)]
    public uint public_port { get; set; }
    [ProtoMember(4)]
    public int server_type { get; set; }
    [ProtoMember(5)]
    public uint server_index { get; set; }

}

[ProtoContract]
public class WORLD_DBCACHE_SERVER_INFO
{
    [ProtoMember(1)]

    public uint world_id { get; set; }
    [ProtoMember(2)]
    public _db_info[] db_info { get; set; }
    [ProtoMember(3)]
    public bool use_world_id { get; set; }

}

[ProtoContract]
public class SERVER_WORLD_REQUEST_SERVER_INFO
{
    [ProtoMember(1)]

    public int server_type { get; set; }
    [ProtoMember(2)]
    public uint server_index { get; set; }
    [ProtoMember(3)]
    public string ip_address { get; set; }

}

[ProtoContract]
public class SERVER_WORLD_NOTIFY_SERVER_INFO
{
    [ProtoMember(1)]

    public int server_type { get; set; }
    [ProtoMember(2)]
    public uint server_index { get; set; }

}

[ProtoContract]
public class SERVER_TRADE_REQUEST_SERVER_INFO
{
    [ProtoMember(1)]

    public int server_type { get; set; }
    [ProtoMember(2)]
    public uint server_index { get; set; }
    [ProtoMember(3)]
    public string ip_address { get; set; }

}

[ProtoContract]
public class SERVER_TRADE_NOTIFY_SERVER_INFO
{
    [ProtoMember(1)]

    public int server_type { get; set; }
    [ProtoMember(2)]
    public uint server_index { get; set; }

}

[ProtoContract]
public class WORLD_TRADE_SERVER_INFO
{
    [ProtoMember(1)]

    public uint world_id { get; set; }
    [ProtoMember(2)]
    public bool use_world_id { get; set; }
    [ProtoMember(3)]
    public _db_info[] db_info { get; set; }
    [ProtoMember(4)]
    public int monitor_update_time { get; set; }

}

[ProtoContract]
public class TRADE_GAME_SERVER_INFO
{
}

[ProtoContract]
public class TRADE_GATEWAY_SERVER_INFO
{
}

[ProtoContract]
public class TRADE_MACRO_SERVER_INFO
{

}

[ProtoContract]
public class SHOP_XDRACO_NOTIFY_SERVER_INFO
{
    [ProtoMember(1)]

    public int server_type { get; set; }
    [ProtoMember(2)]
    public uint region_id { get; set; }
    [ProtoMember(3)]
    public uint world_id { get; set; }

}

[ProtoContract]
public class SERVER_SHOP_REQUEST_SERVER_INFO
{
    [ProtoMember(1)]

    public int server_type { get; set; }
    [ProtoMember(2)]
    public uint server_index { get; set; }
    [ProtoMember(3)]
    public string ip_address { get; set; }

}

[ProtoContract]
public class SERVER_SHOP_NOTIFY_SERVER_INFO
{
    [ProtoMember(1)]

    public int server_type { get; set; }
    [ProtoMember(2)]
    public uint server_index { get; set; }

}

[ProtoContract]
public class WORLD_SHOP_SERVER_INFO
{
    [ProtoMember(1)]

    public uint server_index { get; set; }
    [ProtoMember(2)]
    public uint world_id { get; set; }
    [ProtoMember(3)]
    public bool use_world_id { get; set; }
    [ProtoMember(4)]
    public _db_info[] db_info { get; set; }
    [ProtoMember(5)]
    public int monitor_update_time { get; set; }

}

[ProtoContract]
public class SHOP_GAME_SERVER_INFO
{
    [ProtoMember(1)]

    public uint server_index { get; set; }

}

[ProtoContract]
public class SHOP_GATEWAY_SERVER_INFO
{
    [ProtoMember(1)]

    public uint server_index { get; set; }

}

[ProtoContract]
public class MONITOR_SESSION_INFO
{
    [ProtoMember(1)]

    public int server_type { get; set; }
    [ProtoMember(2)]
    public uint session_count { get; set; }

}

[ProtoContract]
public class MONITOR_INFO
{
    [ProtoMember(1)]

    public int server_type { get; set; }
    [ProtoMember(2)]
    public uint server_index { get; set; }
    [ProtoMember(3)]
    public string ip_address { get; set; }
    [ProtoMember(4)]
    public uint port { get; set; }
    [ProtoMember(5)]
    public uint worker_count { get; set; }
    [ProtoMember(6)]
    public uint worker_index { get; set; }
    [ProtoMember(7)]
    public uint user_count { get; set; }
    [ProtoMember(8)]
    public uint zone_count { get; set; }
    [ProtoMember(9)]
    public uint zone_group_index { get; set; }
    [ProtoMember(10)]
    public MONITOR_SESSION_INFO[] session_infos { get; set; }

}

[ProtoContract]
public class game_server_detail_info
{
    [ProtoMember(1)]

    public ulong zone_uid { get; set; }
    [ProtoMember(2)]
    public uint stage_id { get; set; }
    [ProtoMember(3)]
    public int user_count { get; set; }
    [ProtoMember(4)]
    public uint update_call_count { get; set; }

}

[ProtoContract]
public class SERVER_WORLD_MONITOR_INFO_UPDATE
{
    [ProtoMember(1)]

    MONITOR_INFO monitor_info { get; set; }

}

[ProtoContract]
public class MANAGER_WORLD_REQ_MONITOR_INFO
{

}

[ProtoContract]
public class WORLD_MANAGER_RES_MONITOR_INFO
{
    [ProtoMember(1)]

    public uint world_id { get; set; }
    [ProtoMember(2)]
    public uint build_revision { get; set; }
    [ProtoMember(3)]
    public MONITOR_INFO[] monitor_info { get; set; }

}

[ProtoContract]
public class GAME_WORLD_MONITOR_DETAIL_UPDATE
{
    [ProtoMember(1)]

    public int server_type { get; set; }
    [ProtoMember(2)]
    public uint server_index { get; set; }
    [ProtoMember(3)]
    public uint worker_index { get; set; }
    [ProtoMember(4)]
    public uint zone_group_index { get; set; }
    [ProtoMember(5)]
    public ulong last_update_time { get; set; }
    [ProtoMember(6)]
    public game_server_detail_info[] detail_list { get; set; }

}

[ProtoContract]
public class MANAGER_WORLD_GAME_SERVER_DETAIL_INFO
{

}

[ProtoContract]
public class WORLD_MANAGER_GAME_SERVER_DETAIL_INFO
{
    [ProtoMember(1)]

    public uint world_id { get; set; }
    [ProtoMember(2)]
    public GAME_WORLD_MONITOR_DETAIL_UPDATE[] game_server_list { get; set; }

}

[ProtoContract]
public class CLOSED_SERVER_TO_MANAGER
{
    [ProtoMember(1)]

    public uint world_id { get; set; }
    [ProtoMember(2)]
    public int server_type { get; set; }
    [ProtoMember(3)]
    public uint server_index { get; set; }

}

[ProtoContract]
public class FRONT_MANAGER_SERVER_INFO
{
    [ProtoMember(1)]

    public string ip_address { get; set; }

}

[ProtoContract]
public class MANAGER_FRONT_SERVER_INFO
{

}

[ProtoContract]
public class FRONT_MANAGER_WORLD_SERVER_INFO
{

}

[ProtoContract]
public class MANAGER_FRONT_WORLD_SERVER_INFO
{
    [ProtoMember(1)]

    public _world_server_info[] world_server_info { get; set; }

}

[ProtoContract]
public class MANAGER_FRONT_WORLD_SERVER_INFO_UPDATE
{
    [ProtoMember(1)]

    public _world_server_info[] world_server_info { get; set; }

}

[ProtoContract]
public class MANAGER_WORLD_SERVER_INFO_UPDATE
{
    [ProtoMember(1)]

    public int character_create { get; set; }
    [ProtoMember(2)]
    public int max_user { get; set; }

}

[ProtoContract]
public class WORLD_MANAGER_SERVER_INFO
{
    [ProtoMember(1)]

    public uint world_id { get; set; }
    [ProtoMember(2)]
    public string ip_address { get; set; }
    [ProtoMember(3)]
    public bool conquer_server { get; set; }

}

[ProtoContract]
public class MANAGER_WORLD_SERVER_INFO
{
    [ProtoMember(1)]

    public uint world_id { get; set; }
    [ProtoMember(2)]
    public string world_name { get; set; }
    [ProtoMember(3)]
    public int max_user { get; set; }

}

[ProtoContract]
public class SERVER_MANAGER_SERVER_INFO
{
    [ProtoMember(1)]

    public uint world_id { get; set; }
    [ProtoMember(2)]
    public string ip_address { get; set; }
    [ProtoMember(3)]
    public int server_type { get; set; }

}

[ProtoContract]
public class MANAGER_SERVER_SERVER_INFO
{
    [ProtoMember(1)]

    public uint world_id { get; set; }
    [ProtoMember(2)]
    public string world_name { get; set; }

}

[ProtoContract]
public class WORLD_MANAGER_TOTAL_USER_COUNT
{
    [ProtoMember(1)]

    public uint world_id { get; set; }
    [ProtoMember(2)]
    public uint user_count { get; set; }

}

[ProtoContract]
public class MANAGER_WORLD_WAITING_LOGIN_USER_LOG
{
    [ProtoMember(1)]

    public uint waiting_user_count { get; set; }

}

[ProtoContract]
public class WORLD_LOBBY_CHARACTER_CREATE_LIMIT
{
    [ProtoMember(1)]

    public uint character_create { get; set; }

}

[ProtoContract]
public class WORLD_CACHEDATA_CONNECT
{
    [ProtoMember(1)]

    public int monitor_update_time { get; set; }

}

[ProtoContract]
public class _world_cachedata_base
{
    [ProtoMember(1)]

    public ulong key { get; set; }
    [ProtoMember(2)]
    public byte[] data { get; set; }

}

[ProtoContract]
public class _world_cachedata
{
    [ProtoMember(1)]

    public uint type { get; set; }
    [ProtoMember(2)]
    public _world_cachedata_base[] data_list { get; set; }

}

[ProtoContract]
public class CACHEDATA_WORLD_INFO
{
    [ProtoMember(1)]

    public _world_cachedata[] _msg { get; set; }
    [ProtoMember(2)]
    public int _class { get; set; }

}

[ProtoContract]
public class WORLD_CACHEDATA_REQUEST_DATA_REGISTER
{
    [ProtoMember(1)]

    public uint type { get; set; }
    [ProtoMember(2)]
    public ulong key { get; set; }
    [ProtoMember(3)]
    public byte[] data { get; set; }

}

[ProtoContract]
public class WORLD_CACHEDATA_REQUEST_DATA_GET
{
    [ProtoMember(1)]

    public uint type { get; set; }
    [ProtoMember(2)]
    public ulong key { get; set; }

}

[ProtoContract]
public class WORLD_CACHEDATA_RESPONSE_DATA_GET
{
    [ProtoMember(1)]

    public uint type { get; set; }
    [ProtoMember(2)]
    public ulong key { get; set; }
    [ProtoMember(3)]
    public byte[] data { get; set; }

}

[ProtoContract]
public class WORLD_CACHEDATA_REQUEST_DATA_REMOVE
{
    [ProtoMember(1)]

    public uint type { get; set; }
    [ProtoMember(2)]
    public ulong key { get; set; }

}

[ProtoContract]
public class WORLD_GAME_REASSIGN_ZONEGROUP
{
    [ProtoMember(1)]

    public int zonegroup_index { get; set; }
    [ProtoMember(2)]
    public int monitor_update_time { get; set; }

}

[ProtoContract]
public class WORLD_WORLDLINK_SERVER_INFO
{
    [ProtoMember(1)]

    public int world_id { get; set; }
    [ProtoMember(2)]
    public string ip_address { get; set; }

}

[ProtoContract]
public class WORLD_WORLDLINK_WORLD_INFO
{

}

[ProtoContract]
public class MANAGER_FRONT_MAINTENANCE_UPDATE
{
    [ProtoMember(1)]

    public int update_flag { get; set; }

}

[ProtoContract]
public class GAME_GUILD_NOTIFY_SERVER_INFO
{
    [ProtoMember(1)]

    public int server_type { get; set; }
    [ProtoMember(2)]
    public uint server_index { get; set; }
    [ProtoMember(3)]
    public uint world_id { get; set; }
    [ProtoMember(4)]
    public string ip_address { get; set; }

}

[ProtoContract]
public class GUILD_GAME_NOTIFY_SERVER_INFO
{
    [ProtoMember(1)]

    public int world_group_id { get; set; }

}

[ProtoContract]
public class SERVER_GUILD_REQUEST_SERVER_INFO
{

}

[ProtoContract]
public class GUILD_SERVER_RESPONSE_SERVER_INFO
{
    [ProtoMember(1)]

    public int world_group_id { get; set; }
    [ProtoMember(2)]
    public uint[] world_id_list { get; set; }

}

[ProtoContract]
public class WORLD_GUILD_NOTIFY_SERVER_INFO
{
    [ProtoMember(1)]

    public uint world_id { get; set; }
    [ProtoMember(2)]
    public string ip_address { get; set; }

}

[ProtoContract]
public class SERVER_SERVER_WORLD_BUFF_INFO
{
    [ProtoMember(1)]

    public int world_buff { get; set; }

}

[ProtoContract]
public class SERVER_RELAY_SERVER_INFO
{
    [ProtoMember(1)]

    public int server_type { get; set; }
    [ProtoMember(2)]
    public uint server_index { get; set; }
    [ProtoMember(3)]
    public string ip_address { get; set; }
    [ProtoMember(4)]
    public uint world_id { get; set; }

}

[ProtoContract]
public class MANAGER_WORLD_WORLD_EX_INFO
{
}

[ProtoContract]
public class WORLD_MANAGER_WORLD_EX_INFO
{
    [ProtoMember(1)]

    public int world_id { get; set; }
    [ProtoMember(2)]
    public bool conquer_server { get; set; }

}

[ProtoContract]
public class SERVER_BLOCK_CHAIN_SERVER_INFO
{
    [ProtoMember(1)]

    public int server_type { get; set; }
    [ProtoMember(2)]
    public uint server_index { get; set; }
    [ProtoMember(3)]
    public string ip_address { get; set; }
    [ProtoMember(4)]
    public uint world_id { get; set; }

}

[ProtoContract]
public class TRINITY_TRADE_REQUEST_ITEM_AVERAGEPRICE
{
    [ProtoMember(1)]

    public uint item_id { get; set; }

}

[ProtoContract]
public class TRADE_TRINITY_RESPONSE_ITEM_AVERAGEPRICE
{
    [ProtoMember(1)]

    public uint world_id { get; set; }
    [ProtoMember(2)]
    public float average_price { get; set; }

}

[ProtoContract]
public class TRINITY_TRADE_TRINITY_SMELTING_COST
{
    [ProtoMember(1)]

    double smelting_cost { get; set; }

}

[ProtoContract]
public class TRADE_GAME_TRINITY_SMELTING_COST
{
    [ProtoMember(1)]

    double smelting_cost { get; set; }

}

[ProtoContract]
public class GAME_TRADE_REQUEST_TRINITY_SMELTING_COST
{
}

[ProtoContract]
public class TRINITY_TRADE_HYDRA_SUPPLY_TOTAL
{
    [ProtoMember(1)]

    public ulong supply_total { get; set; }

}

[ProtoContract]
public class TRADE_GAME_HYDRA_SUPPLY_TOTAL
{
    [ProtoMember(1)]

    public ulong supply_total { get; set; }

}

[ProtoContract]
public class GAME_TRADE_HYDRA_SUPPLY_TOTAL
{
}

[ProtoContract]
public class WORLD_LOBBY_NFT_CHARACTER_BLOCK
{
    [ProtoMember(1)]

    public uint nft_block { get; set; }

}

[ProtoContract]
public class GATEWAY_COMMUNITY_SERVER_INFO
{
    [ProtoMember(1)]

    public uint world_index { get; set; }
    [ProtoMember(2)]
    public uint server_index { get; set; }
    [ProtoMember(3)]
    public string ip_address { get; set; }

}

[ProtoContract]
public class GAME_COMMUNITY_SERVER_INFO
{
    [ProtoMember(1)]

    public uint world_index { get; set; }
    [ProtoMember(2)]
    public uint server_index { get; set; }
    [ProtoMember(3)]
    public string ip_address { get; set; }

}

[ProtoContract]
public class GAME_COMMUNITY_CHARACTER_INFO
{
    [ProtoMember(1)]

    public uint world_index { get; set; }
    [ProtoMember(2)]
    public uint server_index { get; set; }
    [ProtoMember(3)]
    public uint zonegroup_index { get; set; }
    [ProtoMember(4)]
    public ulong character_uid { get; set; }
    [ProtoMember(5)]
    public bool online { get; set; }
    [ProtoMember(6)]
    public uint connect_world_index { get; set; }

}

[ProtoContract]
public class GAME_CLIENT_APPEAR_TOTEM
{
    [ProtoMember(1)]

    public ulong totem_uid { get; set; }
    [ProtoMember(2)]
    public int totem_id { get; set; }
    [ProtoMember(3)]
    public int owner_type { get; set; }
    [ProtoMember(4)]
    public ulong owner_uid { get; set; }
    [ProtoMember(5)]
    public _vector3 loc { get; set; }
    [ProtoMember(6)]
    public float degree { get; set; }
    [ProtoMember(7)]
    public int owner_index { get; set; }
    [ProtoMember(8)]
    public string owner_name { get; set; }

}

[ProtoContract]
public class GAME_CLIENT_ATTACK_TOTEM
{
    [ProtoMember(1)]

    public ulong totem_uid { get; set; }
    [ProtoMember(2)]
    public int attack_id { get; set; }
    [ProtoMember(3)]
    public _vector3 dest_pos { get; set; }
    [ProtoMember(4)]
    public ulong target_uid { get; set; }
    [ProtoMember(5)]
    public int target_type { get; set; }
    [ProtoMember(6)]
    public float degree { get; set; }

}


[ProtoContract]
public class _trade_register_data
{
    [ProtoMember(1)]

    public ulong trade_uid { get; set; }
    [ProtoMember(2)]
    public ulong item_uid { get; set; }
    [ProtoMember(3)]
    public int state { get; set; }
    [ProtoMember(4)]
    public uint item_tid { get; set; }
    [ProtoMember(5)]
    public uint smelting_level { get; set; }
    [ProtoMember(6)]
    public int statck_count { get; set; }
    [ProtoMember(7)]
    public long end_time { get; set; }
    [ProtoMember(8)]
    _cost_info cost_info { get; set; }
    [ProtoMember(9)]
    public long calculate_value { get; set; }
    [ProtoMember(10)]
    public int trance_step { get; set; }
    [ProtoMember(11)]
    public int xdraco_trade_state { get; set; }
    [ProtoMember(12)]
    public int collectable { get; set; }
    [ProtoMember(13)]
    public int refine_step { get; set; }

}

[ProtoContract]
public class _trade_purchase_data
{
    [ProtoMember(1)]

    public ulong trade_uid { get; set; }
    [ProtoMember(2)]
    public ulong item_uid { get; set; }
    [ProtoMember(3)]
    public uint item_tid { get; set; }
    [ProtoMember(4)]
    public int statck_count { get; set; }
    [ProtoMember(5)]
    public uint smelting_level { get; set; }
    [ProtoMember(6)]
    _cost_info cost_info { get; set; }
    [ProtoMember(7)]
    public int decrease_sell_tax { get; set; }
    [ProtoMember(8)]
    public int trance_step { get; set; }
    [ProtoMember(9)]
    public int xdraco_trade_state { get; set; }
    [ProtoMember(10)]
    public int collectable { get; set; }
    [ProtoMember(11)]
    public int refine_step { get; set; }

}

[ProtoContract]
public class _trade_calculate_info
{
    [ProtoMember(1)]

    public ulong trade_uid { get; set; }
    [ProtoMember(2)]
    public ulong item_uid { get; set; }
    [ProtoMember(3)]
    public uint item_tid { get; set; }
    [ProtoMember(4)]
    public int statck_count { get; set; }
    [ProtoMember(5)]
    public uint smelting_level { get; set; }
    [ProtoMember(6)]
    _cost_info cost_info { get; set; }
    [ProtoMember(8)]
    public long calculate_value { get; set; }
    [ProtoMember(9)]
    public int trance_step { get; set; }
    [ProtoMember(10)]
    public int xdraco_trade_state { get; set; }
    [ProtoMember(11)]
    public int collectable { get; set; }
    [ProtoMember(12)]
    public int refine_step { get; set; }

}

[ProtoContract]
public class _trade_item_detail
{
    [ProtoMember(1)]

    public ulong trade_uid { get; set; }
    [ProtoMember(2)]
    public ulong item_uid { get; set; }
    [ProtoMember(3)]
    public uint item_tid { get; set; }
    [ProtoMember(4)]
    public uint smelting_level { get; set; }
    [ProtoMember(5)]
    public int stack_count { get; set; }
    [ProtoMember(6)]
    public ItemOptionInfo[] random_option_list { get; set; }
    [ProtoMember(7)]
    public int trance_step { get; set; }
    [ProtoMember(8)]
    public int xdraco_trade_state { get; set; }
    [ProtoMember(9)]
    public int acquisition_path { get; set; }
    [ProtoMember(10)]
    public int acquisition_path_value { get; set; }
    [ProtoMember(11)]
    public long acquisition_path_create_time { get; set; }
    [ProtoMember(12)]
    public string serial_number { get; set; }
    [ProtoMember(13)]
    public int collectable { get; set; }
    [ProtoMember(14)]
    public string limited { get; set; }
    [ProtoMember(15)]
    public int refine_step { get; set; }

}

[ProtoContract]
public class _trade_sales_data
{
    [ProtoMember(1)]

    public uint item_tid { get; set; }
    [ProtoMember(2)]
    _cost_info minimum_cost { get; set; }
    [ProtoMember(3)]
    public int list_count { get; set; }
    [ProtoMember(4)]
    public float oneitem_minimum_cost { get; set; }

}

[ProtoContract]
public class _trade_sales_detail_data
{
    [ProtoMember(1)]

    _trade_item_detail trade_item_data { get; set; }
    [ProtoMember(2)]
    _cost_info cost_info { get; set; }
    [ProtoMember(3)]
    public long end_time { get; set; }

}

[ProtoContract]
public class CLIENT_GAME_REGISTER_TRADE_ITEM
{
    [ProtoMember(1)]

    public ulong item_uid { get; set; }
    [ProtoMember(2)]
    public int stack_count { get; set; }
    [ProtoMember(3)]
    public _cost_info cost_info { get; set; }

}

[ProtoContract]
public class GAME_CLIENT_REGISTER_TRADE_ITEM
{
    [ProtoMember(1)]

    public int result { get; set; }
    [ProtoMember(2)]
    _stack_item_info del_item_info { get; set; }
    [ProtoMember(3)]
    public _cost_info[] commission_cost_info { get; set; }

}

[ProtoContract]
public class GAME_TRADE_REGISTER_TRADE_ITEM_NOTIFY
{
    [ProtoMember(1)]

    public ulong trade_uid { get; set; }

}

[ProtoContract]
public class CLIENT_GAME_REGISTER_CANCEL
{
    [ProtoMember(1)]

    public ulong[] trade_uid_list { get; set; }

}

[ProtoContract]
public class GAME_CLIENT_REGISTER_CANCEL
{
    [ProtoMember(1)]

    public int result { get; set; }

}

[ProtoContract]
public class GAME_CLIENT_REGISTER_CANCEL_ITEM_DATA
{
    [ProtoMember(1)]

    public _character_inven_item[] purchase_item { get; set; }

}

[ProtoContract]
public class GAME_TRADE_REGISTER_CANCEL_REQUEST
{
    [ProtoMember(1)]

    public ulong[] trade_uid_list { get; set; }

}

[ProtoContract]
public class TRADE_GAME_REGISTER_CANCEL_REQUEST
{
    [ProtoMember(1)]

    public int result { get; set; }
    [ProtoMember(2)]
    public _trade_purchase_data[] cancel_list { get; set; }

}

[ProtoContract]
public class GAME_TRADE_REGISTER_CANCEL_NOTIFY
{
    [ProtoMember(1)]

    public int result { get; set; }
    [ProtoMember(2)]
    public ulong[] trade_uid_list { get; set; }

}

[ProtoContract]
public class TRADE_GAME_REGISTER_TRADE_ITEM_END
{

}

[ProtoContract]
public class GAME_CLIENT_REGISTER_TRADE_ITEM_END
{

}

[ProtoContract]
public class CLIENT_GAME_PURCHASE_TRADE_ITEM
{
    [ProtoMember(1)]

    public ulong trade_uid { get; set; }

}

[ProtoContract]
public class GAME_CLIENT_PURCHASE_TRADE_ITEM
{
    [ProtoMember(1)]

    public int result { get; set; }
    [ProtoMember(2)]
    public _cost_info[] purchase_cost_info { get; set; }

}

[ProtoContract]
public class GAME_CLIENT_PUCHASE_TRADE_ITEM_DATA
{
    [ProtoMember(1)]

    public _character_inven_item[] purchase_item { get; set; }

}

[ProtoContract]
public class GAME_TRADE_REQUEST_PURCHASE_TRADE_ITEM_DATA
{
    [ProtoMember(1)]

    public ulong trade_uid { get; set; }

}

[ProtoContract]
public class TRADE_GAME_REQUEST_PURCHASE_TRADE_ITEM_DATA
{
    [ProtoMember(1)]

    public int result { get; set; }
    [ProtoMember(2)]
    _trade_purchase_data purchase_data { get; set; }

}

[ProtoContract]
public class GAME_TRADE_PURCHASE_TRADE_ITEM_RESULT
{
    [ProtoMember(1)]

    public int result { get; set; }
    [ProtoMember(2)]
    public ulong trade_uid { get; set; }
    [ProtoMember(3)]
    public long calc_cost_value { get; set; }

}

[ProtoContract]
public class TRADE_WORLD_PURCHASE_NOTIFY
{
    [ProtoMember(1)]

    public ulong character_uid { get; set; }
    [ProtoMember(2)]
    public ulong trade_uid { get; set; }

}

[ProtoContract]
public class WORLD_GAME_PURCHASE_NOTIFY
{
    [ProtoMember(1)]

    public ulong character_uid { get; set; }
    [ProtoMember(2)]
    public ulong trade_uid { get; set; }

}

[ProtoContract]
public class GAME_CLIENT_PURCHASE_NOTIFY
{
    [ProtoMember(1)]

    public ulong trade_uid { get; set; }

}

[ProtoContract]
public class CLIENT_GAME_CALCULATE_TRADE_ITEM
{
    [ProtoMember(1)]

    public ulong[] trade_uid_list { get; set; }

}

[ProtoContract]
public class GAME_CLIENT_CALCULATE_TRADE_ITEM
{
    [ProtoMember(1)]

    public int result { get; set; }
    [ProtoMember(2)]
    public _cost_info[] cost_list { get; set; }

}

[ProtoContract]
public class GAME_TRADE_REQUEST_CALCULATE_TRADE_ITEM
{
    [ProtoMember(1)]

    public ulong[] trade_uid_list { get; set; }

}

[ProtoContract]
public class TRADE_GAME_REQUEST_CALCULATE_TRADE_ITEM
{
    [ProtoMember(1)]

    public int result { get; set; }
    [ProtoMember(2)]
    public _trade_calculate_info[] calculate_cost_list { get; set; }

}

[ProtoContract]
public class GAME_TRADE_CALCULATE_RESULT_TRADE_ITEM
{
    [ProtoMember(1)]

    public int result { get; set; }
    [ProtoMember(2)]
    public ulong[] trade_uid_list { get; set; }

}

[ProtoContract]
public class CLIENT_TRADE_SEARCH_BOOKMARK_LIST
{
    [ProtoMember(1)]

    public int[] bookmark_item_list { get; set; }
    [ProtoMember(2)]
    public int smelting_min { get; set; }
    [ProtoMember(3)]
    public int smelting_max { get; set; }

}

[ProtoContract]
public class TRADE_CLIENT_SEARCH_BOOKMARK_LIST
{
    [ProtoMember(1)]

    public _trade_sales_data[] sales_list { get; set; }

}

[ProtoContract]
public class CLIENT_TRADE_SEARCH_SALES_LIST
{
    [ProtoMember(1)]

    public int trade_category { get; set; }
    [ProtoMember(2)]
    public int smelting_min { get; set; }
    [ProtoMember(3)]
    public int smelting_max { get; set; }

}

[ProtoContract]
public class TRADE_CLIENT_SEARCH_SALES_LIST
{
    [ProtoMember(1)]

    public _trade_sales_data[] sales_list { get; set; }

}

[ProtoContract]
public class TRADE_CLIENT_SEARCH_SALES_LIST_END
{
}

[ProtoContract]
public class CLIENT_TRADE_SEARCH_SALES_DETAIL_LIST
{
    [ProtoMember(1)]

    public uint item_tid { get; set; }
    [ProtoMember(2)]
    public int smelting_min { get; set; }
    [ProtoMember(3)]
    public int smelting_max { get; set; }

}

[ProtoContract]
public class TRADE_CLIENT_SEARCH_SALES_DETAIL_LIST
{
    [ProtoMember(1)]

    public _trade_sales_detail_data[] sales_detail_list { get; set; }

}

[ProtoContract]
public class TRADE_CLIENT_SEARCH_SALES_DETAIL_LIST_END
{

}

[ProtoContract]
public class CLIENT_TRADE_REGISTER_LIST
{


}

[ProtoContract]
public class TRADE_CLIENT_REGISTER_LIST
{
    [ProtoMember(1)]

    public _trade_register_data[] register_list { get; set; }

}

[ProtoContract]
public class CLIENT_TRADE_REGISTER_DETAIL_INFO
{
    [ProtoMember(1)]

    public ulong trade_uid { get; set; }

}

[ProtoContract]
public class TRADE_CLIENT_REGISTER_DETAIL_INFO
{
    [ProtoMember(1)]

    _trade_item_detail trade_item_info { get; set; }

}

[ProtoContract]
public class CLIENT_TRADE_CALCULATE_LOG_LIST
{
}

[ProtoContract]
public class TRADE_CLIENT_CALCULATE_LIST
{
    [ProtoMember(1)]

    public _trade_register_data[] calculate_log_list { get; set; }

}

[ProtoContract]
public class CLIENT_TRADE_PURCHASE_LOG_LIST
{
}

[ProtoContract]
public class TRADE_CLIENT_PURCHASE_LOG_LIST
{
    [ProtoMember(1)]

    public _trade_register_data[] purchase_log_list { get; set; }

}

[ProtoContract]
public class CLIENT_TRADE_AVERAGE_PRICE
{
    [ProtoMember(1)]

    public uint item_tid { get; set; }

}

[ProtoContract]
public class TRADE_CLIENT_AVERAGE_PRICE
{
    [ProtoMember(1)]

    public uint item_tid { get; set; }
    [ProtoMember(2)]
    public int cost_type { get; set; }
    [ProtoMember(3)]
    public float cost_value { get; set; }

}


[ProtoContract]
public class CLIENT_GAME_GET_TREASURE
{
    [ProtoMember(1)]

    public ulong character_uid { get; set; }
    [ProtoMember(2)]
    public uint treasure_id { get; set; }

}

[ProtoContract]
public class GAME_CLIENT_GET_TREASURE
{
    [ProtoMember(1)]

    public uint get_treasure_id { get; set; }

}

[ProtoContract]
public class CLIENT_GAME_TREASURE_OPEN
{
    [ProtoMember(1)]

    public ulong character_uid { get; set; }
    [ProtoMember(2)]
    public uint treasure_id { get; set; }

}

[ProtoContract]
public class GAME_CLIENT_TREASURE_OPEN
{
    [ProtoMember(1)]

    public uint result { get; set; }
    [ProtoMember(2)]
    _treasure_open_info treasure_info { get; set; }
    [ProtoMember(3)]
    public _bless_info[] bless_info { get; set; }
    [ProtoMember(4)]
    public _stack_item_info[] update_items { get; set; }

}


[ProtoContract]
public class CLIENT_GAME_ACTIVATE_TRIGGER
{
    [ProtoMember(1)]

    public ulong uid { get; set; }
    [ProtoMember(2)]
    public uint trigger_group_id { get; set; }
    [ProtoMember(3)]
    public uint triggerid { get; set; }
    [ProtoMember(4)]
    public int link_entity_type { get; set; }
    [ProtoMember(5)]
    public int link_entity_uid { get; set; }

}

[ProtoContract]
public class GAME_CLIENT_ACTIVATE_TRIGGER
{
    [ProtoMember(1)]

    public int trigger_group_id { get; set; }
    [ProtoMember(2)]
    public int triggerid { get; set; }

}

[ProtoContract]
public class GAME_CLIENT_SYNC_ACTIVATED_TRIGGER
{
    [ProtoMember(1)]

    public int trigger_group_id { get; set; }
    [ProtoMember(2)]
    public int[] triggerid { get; set; }

}

[ProtoContract]
public class CLIENT_GAME_TUTORIAL_CLEAR
{
    [ProtoMember(1)]

    public ulong uid { get; set; }
    [ProtoMember(2)]
    public uint tutorial_group_index { get; set; }

}

[ProtoContract]
public class GAME_CLIENT_TUTORIAL_CLEAR
{
    [ProtoMember(1)]

    public uint tutorial_group_index { get; set; }

}


[ProtoContract]
public class unsealing_data
{
    [ProtoMember(1)]

    public int slot { get; set; }
    [ProtoMember(2)]
    public int item_index { get; set; }
    [ProtoMember(3)]
    public long start_time_t { get; set; }
    [ProtoMember(4)]
    public int support_count { get; set; }
    [ProtoMember(5)]
    public int total_accelerate_time { get; set; }
    [ProtoMember(6)]
    public bool is_supportable { get; set; }
    [ProtoMember(7)]
    public int spend_buff_time { get; set; }
    [ProtoMember(8)]
    public int max_support_count { get; set; }

}

[ProtoContract]
public class unsealing_support_data
{
    [ProtoMember(1)]

    public long unsealing_user_uid { get; set; }
    [ProtoMember(2)]
    public int support_type { get; set; }
    [ProtoMember(3)]
    public int slot { get; set; }
    [ProtoMember(4)]
    public int item_index { get; set; }
    [ProtoMember(5)]
    public int support_count { get; set; }
    [ProtoMember(6)]
    public int max_support_count { get; set; }

}

[ProtoContract]
public class CLIENT_WORLD_UNSEALING_LIST
{
}

[ProtoContract]
public class GAME_WORLD_UNSEALING_LIST
{
    [ProtoMember(1)]

    public uint start_world_id { get; set; }

}

[ProtoContract]
public class WORLD_CLIENT_UNSEALING_LIST
{
    [ProtoMember(1)]

    public unsealing_data[] unsealing_data_list { get; set; }
    [ProtoMember(2)]
    public upgrade_building_data[] building_data_list { get; set; }

}

[ProtoContract]
public class CLIENT_WORLD_UNSEALING_REGISTER
{
    [ProtoMember(1)]

    public long unsealing_item_uid { get; set; }
    [ProtoMember(2)]
    public int unsealing_slot { get; set; }

}

[ProtoContract]
public class GAME_WORLD_UNSEALING_REGISTER_REQUEST
{
    [ProtoMember(1)]

    public long unsealing_item_uid { get; set; }
    [ProtoMember(2)]
    public int unsealing_slot { get; set; }
    [ProtoMember(3)]
    public uint start_world_id { get; set; }

}

[ProtoContract]
public class WORLD_GAME_UNSEALING_REGISTER
{
    [ProtoMember(1)]

    public long user_uid { get; set; }
    [ProtoMember(2)]
    public long unsealing_item_uid { get; set; }
    [ProtoMember(3)]
    public int unsealing_slot { get; set; }
    [ProtoMember(4)]
    public long start_timt_t { get; set; }

}

[ProtoContract]
public class GAME_WORLD_UNSEALING_REGISTER
{
    [ProtoMember(1)]

    public int result { get; set; }
    [ProtoMember(2)]
    public long user_uid { get; set; }
    [ProtoMember(3)]
    public int unsealing_slot { get; set; }
    [ProtoMember(4)]
    public int unsealing_item_index { get; set; }
    [ProtoMember(5)]
    public long start_timt_t { get; set; }
    [ProtoMember(6)]
    public int spend_buff_time { get; set; }
    [ProtoMember(7)]
    public int max_support_count { get; set; }
    [ProtoMember(8)]
    public uint start_world_id { get; set; }

}

[ProtoContract]
public class GAME_CLIENT_UNSEALING_REGISTER
{
    [ProtoMember(1)]

    public int result { get; set; }
    [ProtoMember(2)]
    public unsealing_data unsealing_info { get; set; }
    [ProtoMember(3)]
    public _cost_info[] update_cost_info { get; set; }
    [ProtoMember(4)]
    public _stack_item_info[] update_items { get; set; }

}

[ProtoContract]
public class WORLD_GAME_UNSEALING_REGISTER_COMPLETE
{
    [ProtoMember(1)]

    public int result { get; set; }
    [ProtoMember(2)]
    public long user_uid { get; set; }
    [ProtoMember(3)]
    public int unsealing_slot { get; set; }

}

[ProtoContract]
public class GAME_CLIENT_UNSEALING_REGISTER_COMPLETE
{
    [ProtoMember(1)]

    public int result { get; set; }
    [ProtoMember(2)]
    public int unsealing_slot { get; set; }

}

[ProtoContract]
public class CLIENT_WORLD_UNSEALING_ACCELERATE
{
    [ProtoMember(1)]

    public int unsealing_slot { get; set; }
    [ProtoMember(2)]
    public int unsealing_accelerate_type { get; set; }
    [ProtoMember(3)]
    public bool is_use_item { get; set; }
    [ProtoMember(4)]
    public int unsealing_accelerate_count { get; set; }
    [ProtoMember(5)]
    public long unsealing_accelerate_item_uid { get; set; }
    [ProtoMember(6)]
    public int accelerate_type { get; set; }

}

[ProtoContract]
public class GAME_WORLD_UNSEALING_ACCELERATE_REQUEST
{
    [ProtoMember(1)]

    public int unsealing_slot { get; set; }
    [ProtoMember(2)]
    public int unsealing_accelerate_type { get; set; }
    [ProtoMember(3)]
    public bool is_use_item { get; set; }
    [ProtoMember(4)]
    public int unsealing_accelerate_count { get; set; }
    [ProtoMember(5)]
    public long unsealing_accelerate_item_uid { get; set; }
    [ProtoMember(6)]
    public int accelerate_type { get; set; }
    [ProtoMember(7)]
    public uint start_world_id { get; set; }

}

[ProtoContract]
public class WORLD_GAME_UNSEALING_ACCELERATE
{
    [ProtoMember(1)]

    public long user_uid { get; set; }
    [ProtoMember(2)]
    public int unsealing_slot { get; set; }
    [ProtoMember(3)]
    public int unsealing_accelerate_type { get; set; }
    [ProtoMember(4)]
    public bool is_use_item { get; set; }
    [ProtoMember(5)]
    public int unsealing_accelerate_count { get; set; }
    [ProtoMember(6)]
    public long unsealing_accelerate_item_uid { get; set; }
    [ProtoMember(7)]
    public int total_accelerate_time { get; set; }

}

[ProtoContract]
public class GAME_WORLD_UNSEALING_ACCELERATE
{
    [ProtoMember(1)]

    public long user_uid { get; set; }
    [ProtoMember(2)]
    public int unsealing_slot { get; set; }
    [ProtoMember(3)]
    public int total_accelerate_time { get; set; }
    [ProtoMember(4)]
    public uint start_world_id { get; set; }

}

[ProtoContract]
public class GAME_CLIENT_UNSEALING_ACCELERATE
{
    [ProtoMember(1)]

    public int result { get; set; }
    [ProtoMember(2)]
    public int unsealing_slot { get; set; }
    [ProtoMember(3)]
    public int total_accelerate_time { get; set; }
    [ProtoMember(4)]
    public _cost_info[] update_cost_info { get; set; }
    [ProtoMember(5)]
    public _stack_item_info[] update_items { get; set; }

}

[ProtoContract]
public class CLIENT_WORLD_UNSEALING_ACCELERATE_POINT
{
    [ProtoMember(1)]

    public int unsealing_slot { get; set; }
    [ProtoMember(2)]
    public int unsealing_point_type { get; set; }
    [ProtoMember(3)]
    public int unsealing_point_value { get; set; }

}

[ProtoContract]
public class GAME_WORLD_UNSEALING_ACCELERATE_POINT_REQUEST
{
    [ProtoMember(1)]

    public int unsealing_slot { get; set; }
    [ProtoMember(2)]
    public int unsealing_point_type { get; set; }
    [ProtoMember(3)]
    public int unsealing_point_value { get; set; }
    [ProtoMember(4)]
    public uint start_world_id { get; set; }

}

[ProtoContract]
public class WORLD_GAME_UNSEALING_ACCELERATE_POINT
{
    [ProtoMember(1)]

    public long user_uid { get; set; }
    [ProtoMember(2)]
    public int unsealing_slot { get; set; }
    [ProtoMember(3)]
    public int unsealing_point_type { get; set; }
    [ProtoMember(4)]
    public int unsealing_point_value { get; set; }
    [ProtoMember(5)]
    public int total_accelerate_time { get; set; }
    [ProtoMember(6)]
    public long unsealing_item_index { get; set; }

}

[ProtoContract]
public class GAME_WORLD_UNSEALING_ACCELERATE_POINT
{
    [ProtoMember(1)]

    public long user_uid { get; set; }
    [ProtoMember(2)]
    public int unsealing_slot { get; set; }
    [ProtoMember(3)]
    public int total_accelerate_time { get; set; }
    [ProtoMember(4)]
    public uint start_world_id { get; set; }

}

[ProtoContract]
public class GAME_CLIENT_UNSEALING_ACCELERATE_POINT
{
    [ProtoMember(1)]

    public int result { get; set; }
    [ProtoMember(2)]
    public int unsealing_slot { get; set; }
    [ProtoMember(3)]
    public int total_accelerate_time { get; set; }
    [ProtoMember(4)]
    public _cost_info[] update_cost_info { get; set; }
    [ProtoMember(5)]
    public _stack_item_info[] update_items { get; set; }

}

[ProtoContract]
public class CLIENT_WORLD_UNSEALING_SUPPORT_LIST
{
}

[ProtoContract]
public class GAME_WORLD_UNSEALING_SUPPORT_LIST
{
    [ProtoMember(1)]

    public uint start_world_id { get; set; }

}

[ProtoContract]
public class WORLD_CLIENT_UNSEALING_SUPPORT_LIST
{
    [ProtoMember(1)]

    public unsealing_support_data[] unsealing_support_data_list { get; set; }

}

[ProtoContract]
public class CLIENT_WORLD_UNSEALING_SUPPORT_REGISTER
{
    [ProtoMember(1)]

    public int support_type { get; set; }
    [ProtoMember(2)]
    public int slot { get; set; }

}

[ProtoContract]
public class GAME_WORLD_UNSEALING_SUPPORT_REGISTER
{
    [ProtoMember(1)]

    public int support_type { get; set; }
    [ProtoMember(2)]
    public int slot { get; set; }
    [ProtoMember(3)]
    public uint start_world_id { get; set; }

}

[ProtoContract]
public class WORLD_CLIENT_UNSEALING_SUPPORT_REGISTER
{
    [ProtoMember(1)]

    public int result { get; set; }
    [ProtoMember(2)]
    public int support_type { get; set; }
    [ProtoMember(3)]
    public int slot { get; set; }

}

[ProtoContract]
public class WORLD_CLIENT_UNSEALING_SUPPORT_REGISTER_NOTICE
{
    [ProtoMember(1)]

    public unsealing_support_data unsealing_support_data { get; set; }

}

[ProtoContract]
public class CLIENT_WORLD_UNSEALING_SUPPORT
{

}

[ProtoContract]
public class GAME_WORLD_UNSEALING_SUPPORT_REQUEST
{
    [ProtoMember(1)]

    public uint start_world_id { get; set; }

}

[ProtoContract]
public class WORLD_GAME_UNSEALING_SUPPORT
{
    [ProtoMember(1)]

    public long user_uid { get; set; }
    [ProtoMember(2)]
    public int result { get; set; }
    [ProtoMember(3)]
    public unsealing_support_data[] unsealing_support_data_list { get; set; }
    [ProtoMember(4)]
    public int support_count { get; set; }
    [ProtoMember(5)]
    public int add_guild_exp { get; set; }

}

[ProtoContract]
public class GAME_WORLD_UNSEALING_SUPPORT
{
    [ProtoMember(1)]

    public long user_uid { get; set; }

}

[ProtoContract]
public class WORLD_CLIENT_UNSEALING_SUPPORT
{
    [ProtoMember(1)]

    public int result { get; set; }
    [ProtoMember(2)]
    public unsealing_support_data[] unsealing_support_data_list { get; set; }
    [ProtoMember(3)]
    public int support_count { get; set; }
    [ProtoMember(4)]
    public long last_support_time { get; set; }
    [ProtoMember(5)]
    public int today_get_guild_point { get; set; }
    [ProtoMember(6)]
    public _cost_info[] update_cost_info { get; set; }
    [ProtoMember(7)]
    public int add_guild_exp { get; set; }

}

[ProtoContract]
public class WORLD_CLIENT_UNSEALING_SUPPORT_NOTICE
{
    [ProtoMember(1)]

    public unsealing_data[] unsealing_data_list { get; set; }
    [ProtoMember(2)]
    public long support_user_uid { get; set; }

}

[ProtoContract]
public class WORLD_GAME_UNSEALING_SUPPORT_DEL_LIST
{
    [ProtoMember(1)]

    public long user_uid { get; set; }
    [ProtoMember(2)]
    public unsealing_support_data[] del_support_data_list { get; set; }

}

[ProtoContract]
public class GAME_CLIENT_UNSEALING_SUPPORT_DEL_LIST
{
    [ProtoMember(1)]

    public unsealing_support_data[] del_support_data_list { get; set; }

}

[ProtoContract]
public class WORLD_GAME_UNSEALING_SUPPORTED_LIST
{
    [ProtoMember(1)]

    public long user_uid { get; set; }
    [ProtoMember(2)]
    public unsealing_support_data[] support_data_list { get; set; }

}

[ProtoContract]
public class CLIENT_WORLD_UNSEALING_GET
{
    [ProtoMember(1)]

    public int unsealing_slot { get; set; }

}

[ProtoContract]
public class GAME_WORLD_UNSEALING_GET_REQUEST
{
    [ProtoMember(1)]

    public int unsealing_slot { get; set; }
    [ProtoMember(2)]
    public uint start_world_id { get; set; }

}

[ProtoContract]
public class WORLD_GAME_UNSEALING_GET
{
    [ProtoMember(1)]

    public long user_uid { get; set; }
    [ProtoMember(2)]
    public int unsealing_slot { get; set; }
    [ProtoMember(3)]
    public int openbox_type { get; set; }
    [ProtoMember(4)]
    public int reward_index { get; set; }
    [ProtoMember(5)]
    public int reward_get_count { get; set; }
    [ProtoMember(6)]
    public int register_item_index { get; set; }
    [ProtoMember(7)]
    public long register_time { get; set; }

}

[ProtoContract]
public class GAME_WORLD_UNSEALING_GET
{
    [ProtoMember(1)]

    public long user_uid { get; set; }
    [ProtoMember(2)]
    public int unsealing_slot { get; set; }
    [ProtoMember(3)]
    public int result { get; set; }
    [ProtoMember(4)]
    public uint start_world_id { get; set; }

}

[ProtoContract]
public class GAME_CLIENT_UNSEALING_GET
{
    [ProtoMember(1)]

    public int result { get; set; }
    [ProtoMember(2)]
    public int unsealing_slot { get; set; }
    [ProtoMember(3)]
    public _cost_info[] update_cost_info { get; set; }
    [ProtoMember(4)]
    public _character_inven_item[] update_items { get; set; }

}

[ProtoContract]
public class CLIENT_GAME_UNSEALING_GET_ALL
{


}

[ProtoContract]
public class GAME_WORLD_UNSEALING_GET_ALL
{
    [ProtoMember(1)]

    public long user_uid { get; set; }
    [ProtoMember(2)]
    public uint start_world_id { get; set; }

}

[ProtoContract]
public class _unsealing_reward_info
{
    [ProtoMember(1)]

    public int unsealing_slot { get; set; }
    [ProtoMember(2)]
    public int openbox_type { get; set; }
    [ProtoMember(3)]
    public int reward_index { get; set; }
    [ProtoMember(4)]
    public int reward_get_count { get; set; }
    [ProtoMember(5)]
    public int register_item_index { get; set; }
    [ProtoMember(6)]
    public long register_time { get; set; }

}

[ProtoContract]
public class WORLD_GAME_UNSEALING_GET_ALL
{
    [ProtoMember(1)]

    public long user_uid { get; set; }
    [ProtoMember(2)]
    public _unsealing_reward_info[] unsealing_reward_info { get; set; }
    [ProtoMember(3)]
    public int result { get; set; }

}

[ProtoContract]
public class GAME_CLIENT_UNSEALING_GET_ALL
{
    [ProtoMember(1)]

    public int result { get; set; }
    [ProtoMember(2)]
    public int stop_result { get; set; }
    [ProtoMember(3)]
    public _cost_info[] update_cost_info { get; set; }
    [ProtoMember(4)]
    public _character_inven_item[] update_items { get; set; }
    [ProtoMember(5)]
    public int[] unsealing_slot { get; set; }

}

[ProtoContract]
public class GAME_WORLD_UNSEALING_GET_ALL_COMPLETE
{
    [ProtoMember(1)]

    public int result { get; set; }
    [ProtoMember(2)]
    public long user_uid { get; set; }
    [ProtoMember(3)]
    public int[] unsealing_slot { get; set; }
    [ProtoMember(4)]
    public uint start_world_id { get; set; }

}

[ProtoContract]
public class WORLD_GAME_UNSEALING_GET_ALL_COMPLETE
{
    [ProtoMember(1)]

    public int result { get; set; }
    [ProtoMember(2)]
    public long user_uid { get; set; }

}

[ProtoContract]
public class GAME_CLIENT_UNSEALING_GET_ALL_COMPLETE
{
    [ProtoMember(1)]

    public int result { get; set; }

}

[ProtoContract]
public class GAME_WORLD_GREATBUILDING_UPGRADE_REGISTER
{
    [ProtoMember(1)]

    public long user_uid { get; set; }
    [ProtoMember(2)]
    public int building_id { get; set; }
    [ProtoMember(3)]
    public int building_level { get; set; }
    [ProtoMember(4)]
    public long start_upgrade_timt_t { get; set; }
    [ProtoMember(5)]
    public int max_support_count { get; set; }
    [ProtoMember(6)]
    public uint start_world_id { get; set; }

}

[ProtoContract]
public class GAME_WORLD_GREATBUILDING_UPGRADE_ACCELERATE
{
    [ProtoMember(1)]

    public long user_uid { get; set; }
    [ProtoMember(2)]
    public uint building_id { get; set; }
    [ProtoMember(3)]
    public uint Acceleration_time { get; set; }
    [ProtoMember(4)]
    public uint start_world_id { get; set; }

}

[ProtoContract]
public class GAME_WORLD_GREATBUILDING_UPGRADE_COMPLETE
{
    [ProtoMember(1)]

    public long user_uid { get; set; }
    [ProtoMember(2)]
    public uint building_id { get; set; }
    [ProtoMember(3)]
    public uint start_world_id { get; set; }

}

[ProtoContract]
public class WORLD_CLIENT_BUILDING_UPGRADE_SUPPORT_NOTICE
{
    [ProtoMember(1)]

    public upgrade_building_data[] building_data_list { get; set; }
    [ProtoMember(2)]
    public long support_user_uid { get; set; }

}

[ProtoContract]
public class WORLDLINK_WORLD_GREATBUILDING_UPGRADE_REGISTER
{
    [ProtoMember(1)]

    public long user_uid { get; set; }
    [ProtoMember(2)]
    public _upgrade_building_info[] upgrade_building_list { get; set; }

}

[ProtoContract]
public class CLIENT_GAME_UNSEALING_ACCELERATE_POINT_ALL
{
    [ProtoMember(1)]

    public int use_cost_type { get; set; }

}

[ProtoContract]
public class GAME_WORLD_UNSEALING_ACCELERATE_POINT_ALL
{
    [ProtoMember(1)]

    public int use_cost_type { get; set; }
    [ProtoMember(2)]
    public uint start_world_id { get; set; }

}

[ProtoContract]
public class _unsealing_accelerate_info
{
    [ProtoMember(1)]

    public int unsealing_slot { get; set; }
    [ProtoMember(2)]
    public int unsealing_point_value { get; set; }
    [ProtoMember(3)]
    public int total_accelerate_time { get; set; }
    [ProtoMember(4)]
    public int unsealing_item_index { get; set; }

}

[ProtoContract]
public class WORLD_GAME_UNSEALING_ACCELERATE_POINT_ALL
{
    [ProtoMember(1)]

    public ulong user_uid { get; set; }
    [ProtoMember(2)]
    public int use_cost_type { get; set; }
    [ProtoMember(3)]
    public int total_unsealing_point_value { get; set; }
    [ProtoMember(4)]
    public _unsealing_accelerate_info[] accelerate_info { get; set; }

}

[ProtoContract]
public class GAME_CLIENT_UNSEALING_ACCELERATE_POINT_ALL
{
    [ProtoMember(1)]

    public int result { get; set; }
    [ProtoMember(2)]
    public _cost_info[] update_cost_info { get; set; }
    [ProtoMember(3)]
    public _unsealing_accelerate_info[] accelerate_info { get; set; }

}

[ProtoContract]
public class GAME_WORLD_UNSEALING_ACCELERATE_POINT_ALL_COMPLETE
{
    [ProtoMember(1)]

    public long user_uid { get; set; }
    [ProtoMember(2)]
    public _unsealing_accelerate_info[] accelerate_info { get; set; }
    [ProtoMember(3)]
    public uint start_world_id { get; set; }

}

[ProtoContract]
public class WORLD_GAME_UNSEALING_ACCELERATE_POINT_ALL_COMPLETE
{
    [ProtoMember(1)]

    public int result { get; set; }
    [ProtoMember(2)]
    public long user_uid { get; set; }

}

[ProtoContract]
public class GAME_CLIENT_UNSEALING_ACCELERATE_POINT_ALL_COMPLETE
{
    [ProtoMember(1)]

    public int result { get; set; }

}


[ProtoContract]
public class CLIENT_GAME_REVIVAL
{
    [ProtoMember(1)]

    public int type { get; set; }

}

[ProtoContract]
public class GAME_CLIENT_BROADCAST_REVIVAL
{
    [ProtoMember(1)]

    public ulong uid { get; set; }
    [ProtoMember(2)]
    public int entity_type { get; set; }
    [ProtoMember(3)]
    public uint hp { get; set; }
    [ProtoMember(4)]
    public uint mana { get; set; }
    [ProtoMember(5)]
    public uint vigor { get; set; }
    [ProtoMember(6)]
    public uint rage { get; set; }
    [ProtoMember(7)]
    public uint max_hp { get; set; }
    [ProtoMember(8)]
    public uint max_mana { get; set; }
    [ProtoMember(9)]
    public uint max_vigor { get; set; }
    [ProtoMember(10)]
    public uint max_rage { get; set; }

}

[ProtoContract]
public class GAME_CLIENT_BROADCAST_DIE_USER
{
    [ProtoMember(1)]

    public ulong uid { get; set; }
    [ProtoMember(2)]
    public int reason { get; set; }
    [ProtoMember(3)]
    public int attacker_type { get; set; }
    [ProtoMember(4)]
    public ulong attacker_uid { get; set; }

}

[ProtoContract]
public class GAME_CLIENT_GAIN_EXP
{
    [ProtoMember(1)]

    public long exp { get; set; }
    [ProtoMember(2)]
    public int exp_booster_value { get; set; }

}

[ProtoContract]
public class _packet_s_levelup
{
    [ProtoMember(1)]

    public ulong uid { get; set; }
    [ProtoMember(2)]
    public int level { get; set; }
    [ProtoMember(3)]
    public ulong exp { get; set; }
    [ProtoMember(4)]
    public int hp { get; set; }

}

[ProtoContract]
public class GAME_CLIENT_LEVEL_UP
{
    [ProtoMember(1)]

    public ulong uid { get; set; }
    [ProtoMember(2)]
    public int level { get; set; }
    [ProtoMember(3)]
    public ulong exp { get; set; }
    [ProtoMember(4)]
    public int hp { get; set; }
    [ProtoMember(5)]
    public _time_ticket_info[] time_ticket_info { get; set; }

}

[ProtoContract]
public class _packet_s_change_stat
{
    [ProtoMember(1)]

    public int combatpoint { get; set; }
    [ProtoMember(2)]
    public _stat_info[] stat_infos { get; set; }
    [ProtoMember(3)]
    public _building_stat_info[] buliding_stat_infos { get; set; }

}

[ProtoContract]
public class GAME_CLIENT_CHANGE_STAT
{
    [ProtoMember(1)]

    public int combatpoint { get; set; }
    [ProtoMember(2)]
    public _stat_info[] stat_infos { get; set; }
    [ProtoMember(3)]
    public _building_stat_info[] buliding_stat_infos { get; set; }
    [ProtoMember(4)]
    public _time_ticket_info[] time_ticket_info { get; set; }

}

[ProtoContract]
public class GAME_CLIENT_CHANGE_INFO
{
    [ProtoMember(1)]

    public ulong uid { get; set; }
    [ProtoMember(2)]
    public uint hp { get; set; }
    [ProtoMember(3)]
    public uint mana { get; set; }
    [ProtoMember(4)]
    public uint vigor { get; set; }
    [ProtoMember(5)]
    public int type { get; set; }
    [ProtoMember(6)]
    public int change_reason { get; set; }
    [ProtoMember(7)]
    public uint rage { get; set; }
    [ProtoMember(8)]
    public uint max_hp { get; set; }
    [ProtoMember(9)]
    public uint max_mana { get; set; }

}

[ProtoContract]
public class GAME_CLIENT_DIE
{
    [ProtoMember(1)]

    public uint revival_cost_type { get; set; }
    [ProtoMember(2)]
    public ulong revival_cost_value { get; set; }
    [ProtoMember(3)]
    public ulong revival_delay_ms { get; set; }
    [ProtoMember(4)]
    public int attacker_type { get; set; }
    [ProtoMember(5)]
    public ulong attacker_uid { get; set; }
    [ProtoMember(6)]
    _cost_info costinfo { get; set; }
    [ProtoMember(7)]
    public _stack_item_info[] steal_item_info_list_ { get; set; }
    [ProtoMember(9)]
    public _time_ticket_info time_ticket_info { get; set; }
    [ProtoMember(10)]
    public int death_panalty_buff_id { get; set; }
    [ProtoMember(11)]
    public int die_reason { get; set; }
    [ProtoMember(12)]
    public long penalty_exp { get; set; }
    [ProtoMember(13)]
    public int exp_save_log_count { get; set; }
    [ProtoMember(14)]
    public string attacker_name { get; set; }
    [ProtoMember(15)]
    public int attacker_tid { get; set; }

}

[ProtoContract]
public class GAME_CLIENT_REVIVAL_RESULT
{
    [ProtoMember(1)]

    public uint revival_result { get; set; }
    [ProtoMember(2)]
    public _cost_info[] revival_cost { get; set; }
    [ProtoMember(3)]
    public _time_ticket_info[] revival_time_ticket { get; set; }
    [ProtoMember(4)]
    public int revived_type { get; set; }
    [ProtoMember(5)]
    public long revived_uid { get; set; }
    [ProtoMember(6)]
    public long restore_exp { get; set; }

}

[ProtoContract]
public class CLIENT_GAME_ALRM_INFO
{
}

[ProtoContract]
public class GAME_CLIENT_GAME_ALRM_INFO
{
    [ProtoMember(1)]

    public uint account_mail_count { get; set; }
    [ProtoMember(2)]
    public uint character_mail_count { get; set; }

}

[ProtoContract]
public class CLIENT_GAME_QUICKSLOT_UPDATE
{
    [ProtoMember(1)]

    public uint slot_index { get; set; }
    [ProtoMember(2)]
    public uint item_index { get; set; }
    [ProtoMember(3)]
    public _quick_slot[] quick_slot_list { get; set; }

}

[ProtoContract]
public class GAME_CLIENT_QUICKSLOT_UPDATE_RESULT
{
    [ProtoMember(1)]

    public int result { get; set; }

}

[ProtoContract]
public class CLIENT_GAME_REQUEST_REBIRTH_HELP
{

}

[ProtoContract]
public class GAME_CLIENT_HELP_REBIRTH
{
    [ProtoMember(1)]

    public ulong user_uid { get; set; }
    [ProtoMember(2)]
    public string user_name { get; set; }
    [ProtoMember(3)]
    public _vector3 user_pos { get; set; }
    [ProtoMember(4)]
    public string guild_name { get; set; }
    [ProtoMember(5)]
    public uint guild_mark { get; set; }
    [ProtoMember(6)]
    public uint guild_mark_edge { get; set; }
    [ProtoMember(7)]
    public uint class_id { get; set; }
    [ProtoMember(8)]
    public uint user_level { get; set; }

}

[ProtoContract]
public class CLIENT_GAME_ALARM
{
}

[ProtoContract]
public class GAME_CLIENT_DROP_RECEIVE_INFO_LIST
{
    [ProtoMember(1)]

    public _simple_cost_info[] cost_receive_info { get; set; }
    [ProtoMember(2)]
    public _simple_item_info[] item_receive_info { get; set; }
    [ProtoMember(3)]
    public uint receive_contents_index { get; set; }
    [ProtoMember(4)]
    public uint receive_exp { get; set; }
    [ProtoMember(5)]
    public uint stage_type { get; set; }
    [ProtoMember(6)]
    public _simple_item_info_ex_xdraco[] item_receive_info_ex_xdarco { get; set; }

}

[ProtoContract]
public class CLIENT_GAME_REQUEST_DROP_RECEIVE_INFO_LIST
{

}

[ProtoContract]
public class GAME_WORLD_REQUEST_PK_USER_POS_INFO
{
    [ProtoMember(1)]

    public ulong user_uid { get; set; }
    [ProtoMember(2)]
    public ulong target_uid { get; set; }

}

[ProtoContract]
public class WORLD_GAME_RESULT_PK_USER_POS_INFO
{
    [ProtoMember(1)]

    public int result { get; set; }
    [ProtoMember(2)]
    public ulong user_uid { get; set; }
    [ProtoMember(3)]
    public uint stage_index { get; set; }
    [ProtoMember(4)]
    public _vector3 target_pos { get; set; }

}

[ProtoContract]
public class WORLD_GAME_REQUEST_PK_USER_POS_INFO
{
    [ProtoMember(1)]

    public ulong user_uid { get; set; }
    [ProtoMember(2)]
    public ulong target_uid { get; set; }

}

[ProtoContract]
public class GAME_WORLD_RESULT_PK_USER_POS_INFO
{
    [ProtoMember(1)]

    public int result { get; set; }
    [ProtoMember(2)]
    public ulong user_uid { get; set; }
    [ProtoMember(3)]
    public uint stage_index { get; set; }
    [ProtoMember(4)]
    public _vector3 target_pos { get; set; }

}

[ProtoContract]
public class CLIENT_GAME_CUSTOMIZE_CHANGE
{
    [ProtoMember(1)]

    public ulong character_uid { get; set; }
    [ProtoMember(2)]
    public customize_info[] customize_list { get; set; }

}

[ProtoContract]
public class GAME_CLIENT_CUSTOMIZE_CHANGE
{
    [ProtoMember(1)]

    public int result { get; set; }
    [ProtoMember(2)]
    public ulong character_uid { get; set; }
    [ProtoMember(3)]
    public _stack_item_info[] del_item_list { get; set; }
    [ProtoMember(4)]
    public _cost_info[] cost_list { get; set; }

}

[ProtoContract]
public class GUILD_WAR_REVIVAL_INFO_v2
{
    [ProtoMember(1)]

    public int guild_war_revival_type { get; set; }
    [ProtoMember(2)]
    public int warp_location_tid { get; set; }
    [ProtoMember(3)]
    public ulong occupy_guild_uid { get; set; }
    [ProtoMember(4)]
    public bool is_disable { get; set; }

}

[ProtoContract]
public class GAME_CLIENT_NTF_GUILD_WAR_REVIVAL_LIST
{
    [ProtoMember(1)]

    public GUILD_WAR_REVIVAL_INFO_v2[] guild_war_revival_info_list { get; set; }

}

[ProtoContract]
public class GAME_CLIENT_NTF_GUILD_WAR_REVIVAL_CHANGE
{
    [ProtoMember(1)]

    GUILD_WAR_REVIVAL_INFO_v2 guild_war_revival_info { get; set; }

}

[ProtoContract]
public class GUILD_WAR_MONSTER_INTERACTION_INFO
{
}

[ProtoContract]
public class CLIENT_GAME_GUILD_WAR_MONSTER_INTERACTION
{
    [ProtoMember(1)]

    public ulong uid { get; set; }

}

[ProtoContract]
public class GAME_CLIENT_GUILD_WAR_MONSTER_INTERACTION
{
    [ProtoMember(1)]

    public ulong ownership_guild_uid { get; set; }
    [ProtoMember(2)]
    public string ownership_guild_name { get; set; }
    [ProtoMember(3)]
    public string server_name { get; set; }
    [ProtoMember(4)]
    public uint left_second_time { get; set; }
    [ProtoMember(5)]
    public uint event_second_time { get; set; }
    [ProtoMember(6)]
    public uint buff_id { get; set; }
    [ProtoMember(7)]
    public bool on_fire { get; set; }

}

[ProtoContract]
public class CLIENT_GAME_CLOSE_GUILD_WAR_MONSTER_INTERACTION
{
    [ProtoMember(1)]
    public ulong uid { get; set; }

}

[ProtoContract]
public class GAME_CLIENT_CLOSE_GUILD_WAR_MONSTER_INTERACTION
{

}

[ProtoContract]
public class CLIENT_GAME_GUILD_WAR_MONSTER_INTERACTION_ACTION
{
    [ProtoMember(1)]

    public ulong uid { get; set; }
    [ProtoMember(2)]
    public uint action_type { get; set; }

}

[ProtoContract]
public class GAME_CLIENT_GUILD_WAR_MONSTER_INTERACTION_ACTION
{
    [ProtoMember(1)]

    public uint result { get; set; }
    [ProtoMember(2)]
    public uint action_type { get; set; }
    [ProtoMember(3)]
    public _cost_info[] cost_list { get; set; }
    [ProtoMember(4)]
    public _stack_item_info[] item_list { get; set; }

}

[ProtoContract]
public class CLIENT_GAME_STAT_CONTENTS_LIST
{
    [ProtoMember(1)]

    public int[] stat_id_list { get; set; }

}

[ProtoContract]
public class GAME_CLIENT_STAT_CONTENTS_LIST
{
    [ProtoMember(1)]

    public int result { get; set; }
    [ProtoMember(2)]
    public _stat_contents_info[] stat_contents_list { get; set; }

}

[ProtoContract]
public class CLIENT_GAME_STAT_CONTENTS_TYPE_LIST
{
    [ProtoMember(1)]

    public int[] stat_contents_type_list { get; set; }

}

[ProtoContract]
public class GAME_CLIENT_STAT_CONTENTS_TYPE_LIST
{
    [ProtoMember(1)]

    public int result { get; set; }
    [ProtoMember(2)]
    public _stat_contents_info[] stat_contents_list { get; set; }

}

[ProtoContract]
public class GAME_WORLD_NTF_USER_ATTRIBUTE
{
    [ProtoMember(1)]

    public int combat_point { get; set; }
    [ProtoMember(2)]
    public ulong user_uid { get; set; }
    [ProtoMember(3)]
    public int user_level { get; set; }

}

[ProtoContract]
public class CLIENT_GAME_ONE_USER_REBIRTH
{
    [ProtoMember(1)]

    public ulong target_uid { get; set; }

}

[ProtoContract]
public class GAME_CLIENT_ONE_USER_REBIRTH
{
    [ProtoMember(1)]

    public int result { get; set; }
    [ProtoMember(2)]
    public int remote_id { get; set; }
    [ProtoMember(3)]
    public int cooltime { get; set; }

}

[ProtoContract]
public class GAME_WORLD_ACCOUNT_GRADE
{
    [ProtoMember(1)]

    public ulong user_uid { get; set; }

}

[ProtoContract]
public class WORLD_GAME_ACCOUNT_GRADE
{
    [ProtoMember(1)]

    public ulong user_uid { get; set; }
    [ProtoMember(2)]
    public int account_grade { get; set; }

}

[ProtoContract]
public class WORLD_GAME_OTHER_CHARACTER_STATE
{
    [ProtoMember(1)]

    public ulong user_uid { get; set; }
    [ProtoMember(2)]
    public bool is_online { get; set; }
    [ProtoMember(3)]
    public uint stage_id { get; set; }

}

[ProtoContract]
public class WORLD_GAME_OTHER_CHARACTER_STATE_RELOAD
{
    [ProtoMember(1)]

    public ulong[] user_uid { get; set; }

}

[ProtoContract]
public class CLIENT_GAME_NAME_CHANGE
{
    [ProtoMember(1)]

    public bool use_cost { get; set; }
    [ProtoMember(2)]
    public string new_name { get; set; }

}

[ProtoContract]
public class GAME_CLIENT_NAME_CHANGE
{
    [ProtoMember(1)]

    public int result { get; set; }
    [ProtoMember(2)]
    public _cost_info[] use_cost_list { get; set; }
    [ProtoMember(3)]
    public _stack_item_info[] use_item_list { get; set; }

}

[ProtoContract]
public class GAME_WORLD_NAME_CHANGE
{
    [ProtoMember(1)]

    public ulong user_uid { get; set; }
    [ProtoMember(2)]
    public string new_name { get; set; }
    [ProtoMember(3)]
    public ulong guild_uid { get; set; }

}

[ProtoContract]
public class GAME_WORLD_CHARACTER_INDEX_UPDATE
{
    [ProtoMember(1)]

    public ulong user_uid { get; set; }
    [ProtoMember(2)]
    public string new_name { get; set; }
    [ProtoMember(3)]
    public bool use_cost { get; set; }

}

[ProtoContract]
public class WORLD_GAME_CHARACTER_INDEX_UPDATE
{
    [ProtoMember(1)]

    public int result { get; set; }
    [ProtoMember(2)]
    public ulong user_uid { get; set; }
    [ProtoMember(3)]
    public string new_name { get; set; }
    [ProtoMember(4)]
    public bool use_cost { get; set; }

}

[ProtoContract]
public class GAME_WORLD_CHARACTER_INDEX_DELETE
{
    [ProtoMember(1)]

    public ulong user_uid { get; set; }

}

[ProtoContract]
public class WORLD_GAME_CHARACTER_INDEX_DELETE
{
    [ProtoMember(1)]

    public int result { get; set; }
    [ProtoMember(2)]
    public ulong user_uid { get; set; }

}

[ProtoContract]
public class GAME_WORLD_ACCOUNT_WEMIX_ADDRESS
{
    [ProtoMember(1)]

    public ulong user_uid { get; set; }

}

[ProtoContract]
public class WORLD_GAME_ACCOUNT_WEMIX_ADDRESS
{
    [ProtoMember(1)]

    public ulong user_uid { get; set; }
    [ProtoMember(2)]
    public string wemix_address { get; set; }

}

[ProtoContract]
public class MANAGER_WROLD_BLOCK_USER_UPDATE
{
    [ProtoMember(1)]

    public ulong account_uid { get; set; }
    [ProtoMember(2)]
    public bool is_block { get; set; }

}

[ProtoContract]
public class CLIENT_GAME_ADS_INFO
{

}

[ProtoContract]
public class GAME_CLIENT_ADS_INFO
{
    [ProtoMember(1)]

    public int view_count { get; set; }
    [ProtoMember(2)]
    public int view_point { get; set; }

}

[ProtoContract]
public class CLIENT_GAME_ADS_GET_REWARD
{
}

[ProtoContract]
public class GAME_CLIENT_ADS_GET_REWARD
{
    [ProtoMember(1)]

    public int result { get; set; }
    [ProtoMember(2)]
    public int view_point { get; set; }
    [ProtoMember(3)]
    public _character_inven_item[] reward_item_list { get; set; }

}

[ProtoContract]
public class CLIENT_GAME_ADS_VIEW_END
{
    [ProtoMember(1)]

    public string client_guid { get; set; }

}

[ProtoContract]
public class GAME_CLIENT_ADS_VIEW_END
{
    [ProtoMember(1)]

    public int result { get; set; }
    [ProtoMember(2)]
    _cost_info cost_data { get; set; }
    [ProtoMember(3)]
    public int view_count { get; set; }
    [ProtoMember(4)]
    public int view_point { get; set; }

}

[ProtoContract]
public class CLIENT_GAME_TRANSLATION_LOG
{
    [ProtoMember(1)]

    public int type { get; set; }
    [ProtoMember(2)]
    public int size { get; set; }

}

[ProtoContract]
public class CLIENT_GAME_ACCOUNT_EX_INFO
{
}

[ProtoContract]
public class GAME_CLIENT_ACCOUNT_EX_INFO
{
    [ProtoMember(1)]

    public long captcha_next_auth_time_sec { get; set; }
    [ProtoMember(2)]
    public int captcha_reauth_level { get; set; }
    [ProtoMember(3)]
    public int captcha_reauth_term_min { get; set; }

}

[ProtoContract]
public class CLIENT_GAME_CAPTCHA_REVOKE
{

}

[ProtoContract]
public class GAME_CLIENT_CAPTCHA_REVOKE
{
    [ProtoMember(1)]

    public int result { get; set; }

}

[ProtoContract]
public class CLIENT_GAME_CAPTCHA_REAUTH
{
    [ProtoMember(1)]

    public string token_id { get; set; }

}

[ProtoContract]
public class GAME_CLIENT_CAPTCHA_REAUTH
{
    [ProtoMember(1)]

    public int result { get; set; }
    [ProtoMember(2)]
    public long captcha_next_auth_time_sec { get; set; }
    [ProtoMember(3)]
    public int captcha_reauth_level { get; set; }

}


[ProtoContract]
public class CLIENT_GAME_VEHICLE_RIDE_ON_OFF
{
    [ProtoMember(1)]

    public _vector3 loc { get; set; }
    [ProtoMember(2)]
    public bool isRide { get; set; }

}

[ProtoContract]
public class GAME_CLIENT_VEHICLE_RIDE_ON_OFF
{
    [ProtoMember(1)]

    public ulong uid { get; set; }
    [ProtoMember(2)]
    public int vehicle_index { get; set; }
    [ProtoMember(3)]
    public _vector3 loc { get; set; }
    [ProtoMember(4)]
    public int result { get; set; }

}

[ProtoContract]
public class CLIENT_GAME_VEHICLE_EQUIP
{
    [ProtoMember(1)]

    public int vehicle_group { get; set; }

}

[ProtoContract]
public class GAME_CLIENT_VEHICLE_EQUIP
{
    [ProtoMember(1)]

    public int result { get; set; }
    [ProtoMember(2)]
    public int vehicle_group { get; set; }

}

[ProtoContract]
public class CLIENT_GAME_VEHICLE_UNLOCK
{
    [ProtoMember(1)]

    public int vehicle_group { get; set; }

}

[ProtoContract]
public class GAME_CLIENT_VEHICLE_UNLOCK
{
    [ProtoMember(1)]

    public int result { get; set; }
    [ProtoMember(2)]
    public int vehicle_group { get; set; }
    [ProtoMember(3)]
    public int vehicle_index { get; set; }
    [ProtoMember(4)]
    public _stack_item_info[] update_items { get; set; }

}

[ProtoContract]
public class CLIENT_GAME_VEHICLE_REINFORCE
{
    [ProtoMember(1)]

    public int vehicle_group { get; set; }
    [ProtoMember(2)]
    public int reinforce_count { get; set; }

}

[ProtoContract]
public class GAME_CLIENT_VEHICLE_REINFORCE
{
    [ProtoMember(1)]

    public int result { get; set; }
    [ProtoMember(2)]
    public int vehicle_group { get; set; }
    [ProtoMember(3)]
    public int reinforce_index { get; set; }
    [ProtoMember(4)]
    public int reinforce_level { get; set; }
    [ProtoMember(5)]
    public int reinforce_exp { get; set; }
    [ProtoMember(6)]
    _cost_info costInfo { get; set; }
    [ProtoMember(7)]
    public _stack_item_info[] update_items { get; set; }

}

[ProtoContract]
public class CLIENT_GAME_VEHICLE_UPGRADE
{
    [ProtoMember(1)]

    public int vehicle_group { get; set; }

}

[ProtoContract]
public class GAME_CLIENT_VEHICLE_UPGRADE
{
    [ProtoMember(1)]

    public int result { get; set; }
    [ProtoMember(2)]
    public int vehicle_group { get; set; }
    [ProtoMember(3)]
    public int upgrade_vehicle_index { get; set; }
    [ProtoMember(4)]
    _cost_info costInfo { get; set; }
    [ProtoMember(5)]
    public _stack_item_info[] update_items { get; set; }

}

[ProtoContract]
public class CLIENT_GAME_VEHICLE_ITEM_EQUIP
{
    [ProtoMember(1)]

    public int vehicle_group_id { get; set; }
    [ProtoMember(2)]
    public int position { get; set; }
    [ProtoMember(3)]
    public ulong ItemUID { get; set; }

}

[ProtoContract]
public class GAME_CLIENT_VEHICLE_ITEM_EQUIP
{
    [ProtoMember(1)]

    public int result { get; set; }
    [ProtoMember(2)]
    public int vehicle_group_id { get; set; }
    [ProtoMember(3)]
    public int position { get; set; }
    [ProtoMember(4)]
    public ulong equipItemUID { get; set; }
    [ProtoMember(5)]
    public ulong unequipItemUID { get; set; }

}

[ProtoContract]
public class CLIENT_GAME_VEHICLE_RIDE_EQUIP
{
    [ProtoMember(1)]

    public int vehicle_index { get; set; }

}

[ProtoContract]
public class GAME_CLIENT_VEHICLE_RIDE_EQUIP
{
    [ProtoMember(1)]

    public int result { get; set; }
    [ProtoMember(2)]
    public int vehicle_index { get; set; }

}

[ProtoContract]
public class CLIENT_GAME_VEHICLE_BUY
{
    [ProtoMember(1)]

    public int vehicle_index { get; set; }

}

[ProtoContract]
public class GAME_CLIENT_VEHICLE_BUY
{
    [ProtoMember(1)]

    public int result { get; set; }
    [ProtoMember(2)]
    public int vehicle_index { get; set; }
    [ProtoMember(3)]
    public _cost_info[] costInfo { get; set; }
    [ProtoMember(4)]
    public _stack_item_info[] update_items { get; set; }

}

[ProtoContract]
public class warp_info
{
    [ProtoMember(1)]

    public uint warp_stage_id { get; set; }
    [ProtoMember(2)]
    public _vector3 warp_pos { get; set; }
    [ProtoMember(3)]
    public int warp_method { get; set; }
    [ProtoMember(4)]
    public uint warp_arg { get; set; }
    [ProtoMember(5)]
    public uint warp_location_id { get; set; }
    [ProtoMember(6)]
    public _cost_info[] warp_cost_list { get; set; }
    [ProtoMember(7)]
    public _stack_item_info[] warp_item_list { get; set; }
    [ProtoMember(8)]
    public float warp_rotation { get; set; }
    [ProtoMember(9)]
    public _dungeon_ticket_info[] warp_dungeon_ticket { get; set; }
    [ProtoMember(10)]
    public int warp_radius { get; set; }

}

[ProtoContract]
public class GAME_WORLD_DISCONNECT_USER
{
    [ProtoMember(1)]

    public ulong user_uid { get; set; }

}

[ProtoContract]
public class WORLD_GAME_REMOVE_USER
{
    [ProtoMember(1)]

    public ulong user_uid { get; set; }
    [ProtoMember(2)]
    public int reason { get; set; }

}

[ProtoContract]
public class GAME_WORLD_REQ_WAITING_ZONE_CASTING_WARP_CHECK
{
    [ProtoMember(1)]

    public ulong uid { get; set; }
    [ProtoMember(2)]
    warp_info warp_info { get; set; }
    [ProtoMember(3)]
    _casting_info casting_info { get; set; }

}

[ProtoContract]
public class WORLD_GAME_RES_WAITING_ZONE_CASTING_WARP_CHECK
{
    [ProtoMember(1)]

    public ulong uid { get; set; }
    [ProtoMember(2)]
    public ulong zone_uid { get; set; }
    [ProtoMember(3)]
    _casting_info casting_info { get; set; }

}

[ProtoContract]
public class CLIENT_GAME_WAITING_ZONE_WARP
{
    [ProtoMember(1)]

    public ulong uid { get; set; }
    [ProtoMember(2)]
    public uint location_id { get; set; }
    [ProtoMember(3)]
    public ulong zone_uid { get; set; }

}

[ProtoContract]
public class GAME_WORLD_WAITING_ZONE_WARP
{
    [ProtoMember(1)]

    public ulong uid { get; set; }
    [ProtoMember(2)]
    public uint location_id { get; set; }
    [ProtoMember(3)]
    public ulong zone_uid { get; set; }

}

[ProtoContract]
public class CLIENT_GAME_WARP_PORTAL
{
    [ProtoMember(1)]

    public ulong uid { get; set; }
    [ProtoMember(2)]
    public uint portal_id { get; set; }

}

[ProtoContract]
public class _packet_game_world_request_warp
{
    [ProtoMember(1)]

    public ulong uid { get; set; }
    [ProtoMember(2)]
    warp_info warp_info { get; set; }
    [ProtoMember(3)]
    public ulong casting_warp_zone_uid { get; set; }

}

[ProtoContract]
public class _packet_world_game_rep_try_warp
{
    [ProtoMember(1)]

    public ulong uid { get; set; }
    [ProtoMember(2)]
    public int result { get; set; }
    [ProtoMember(3)]
    public string gameserver_ip { get; set; }
    [ProtoMember(4)]
    public int gameserver_port { get; set; }
    [ProtoMember(5)]
    public ulong zone_unique { get; set; }
    [ProtoMember(6)]
    public int zonegroup_index { get; set; }
    [ProtoMember(7)]
    public uint stage_id { get; set; }
    [ProtoMember(8)]
    public _vector3 loc { get; set; }
    [ProtoMember(9)]
    public uint warp_type { get; set; }
    [ProtoMember(10)]
    public uint warp_arg { get; set; }
    [ProtoMember(11)]
    public bool change_zone_group { get; set; }

}

[ProtoContract]
public class _packet_s_forced_warp_error
{
    [ProtoMember(1)]

    public ulong receive_user_id { get; set; }
    [ProtoMember(2)]
    public int error_id { get; set; }

}

[ProtoContract]
public class GAME_CLIENT_WARP_TO_ESCAPE_POS
{
    [ProtoMember(1)]

    public ulong uid { get; set; }

}

[ProtoContract]
public class _packet_game_world_warp_to_pos
{
    [ProtoMember(1)]

    public ulong uid { get; set; }
    [ProtoMember(2)]
    warp_info warp_info { get; set; }

}

[ProtoContract]
public class CLIENT_GAME_WARP_USER
{
    [ProtoMember(1)]

    public uint stage_id { get; set; }
    [ProtoMember(2)]
    public _vector3 loc { get; set; }

}

[ProtoContract]
public class _packet_world_game_request_prepare_warp
{
    [ProtoMember(1)]

    public ulong warp_user_uid { get; set; }
    [ProtoMember(2)]
    warp_info warp_info { get; set; }
    [ProtoMember(3)]
    public int dest_world_server_zonegroup_index { get; set; }
    [ProtoMember(4)]
    public ulong dest_zone_uid { get; set; }

}

[ProtoContract]
public class _packet_game_world_warp_prepare_result
{
    [ProtoMember(1)]

    public bool result { get; set; }
    [ProtoMember(2)]
    public ulong warp_user_uid { get; set; }
    [ProtoMember(3)]
    warp_info warp_info { get; set; }
    [ProtoMember(4)]
    public int dest_world_server_zonegroup_index { get; set; }
    [ProtoMember(5)]
    public ulong dest_zone_uid { get; set; }

}

[ProtoContract]
public class _packet_world_game_request_warp_ready
{
    [ProtoMember(1)]

    public ulong warp_user_account_uid { get; set; }
    [ProtoMember(2)]
    public ulong warp_user_uid { get; set; }
    [ProtoMember(3)]
    public int dest_world_server_zonegroup_index { get; set; }
    [ProtoMember(4)]
    public ulong dest_zone_uid { get; set; }
    [ProtoMember(5)]
    public int depature_world_server_zonegroup_index { get; set; }
    [ProtoMember(6)]
    warp_info warp_info { get; set; }
    [ProtoMember(7)]
    public int user_connected_proxy_server_type { get; set; }
    [ProtoMember(8)]
    public int user_connected_proxy_server_index { get; set; }

}

[ProtoContract]
public class _packet_game_world_warp_ready_result
{
    [ProtoMember(1)]

    public ulong warp_user_uid { get; set; }
    [ProtoMember(2)]
    public int depature_world_server_zonegroup_index { get; set; }
    [ProtoMember(3)]
    warp_info warp_info { get; set; }
    [ProtoMember(4)]
    _characterInfo char_info { get; set; }

}

[ProtoContract]
public class _packet_world_game_warp_start
{
    [ProtoMember(1)]

    public ulong warp_user_uid { get; set; }
    [ProtoMember(2)]
    public string gameserver_ip { get; set; }
    [ProtoMember(3)]
    public int gameserver_port { get; set; }
    [ProtoMember(4)]
    public ulong warp_zone_unique { get; set; }
    [ProtoMember(5)]
    public int warp_zonegroup_index { get; set; }
    [ProtoMember(6)]
    warp_info warp_info { get; set; }

}

[ProtoContract]
public class CLIENT_GAME_NOTIFY_WARP_READY
{
    [ProtoMember(1)]

    public ulong warp_user_uid { get; set; }
    [ProtoMember(2)]
    public int warp_user_connected_session_index { get; set; }

}

[ProtoContract]
public class _packet_world_game_notify_client_warp_start
{
    [ProtoMember(1)]

    public ulong warp_user_uid { get; set; }
    [ProtoMember(2)]
    public int warp_user_connected_session_index { get; set; }

}

[ProtoContract]
public class _packet_game_world_request_warp_end
{
    [ProtoMember(1)]

    public ulong warp_user_uid { get; set; }
    [ProtoMember(2)]
    public long user_time { get; set; }

}

[ProtoContract]
public class _packet_world_game_warp_end_result
{
    [ProtoMember(1)]

    public ulong warp_user_uid { get; set; }
    [ProtoMember(2)]
    public bool is_login { get; set; }
    [ProtoMember(3)]
    public long user_time { get; set; }
    [ProtoMember(4)]
    _gameserver_sync_party_info party_info { get; set; }

}

[ProtoContract]
public class GAME_CLIENT_WARP_END
{
    [ProtoMember(1)]

    public ulong warp_user_uid { get; set; }
    [ProtoMember(2)]
    public long user_time { get; set; }

}

[ProtoContract]
public class _packet_world_game_request_login_ready
{
    [ProtoMember(1)]

    public ulong login_user_account_uid { get; set; }
    [ProtoMember(2)]
    public ulong login_user_uid { get; set; }
    [ProtoMember(3)]
    public int dest_world_server_zonegroup_index { get; set; }
    [ProtoMember(4)]
    public ulong dest_zone_uid { get; set; }
    [ProtoMember(5)]
    warp_info warp_info { get; set; }
    [ProtoMember(6)]
    public int user_connected_proxy_server_type { get; set; }
    [ProtoMember(7)]
    public int user_connected_proxy_server_index { get; set; }
    [ProtoMember(8)]
    public string user_ip { get; set; }
    [ProtoMember(10)]
    public int login_user_world_id { get; set; }
    [ProtoMember(11)]
    public int class_id { get; set; }
    [ProtoMember(12)]
    public bool assassin_mode { get; set; }
    [ProtoMember(13)]
    public string assassin_name { get; set; }

}

[ProtoContract]
public class _packet_game_world_login_ready_result
{
    [ProtoMember(1)]

    public ulong login_user_uid { get; set; }
    [ProtoMember(2)]
    warp_info warp_info { get; set; }
    [ProtoMember(3)]
    public uint error_id { get; set; }

}

[ProtoContract]
public class GAME_CLIENT_WARP_READY
{
    [ProtoMember(1)]

    public string gameserver_ip { get; set; }
    [ProtoMember(2)]
    public int gameserver_port { get; set; }
    [ProtoMember(3)]
    public ulong zone_unique { get; set; }
    [ProtoMember(4)]
    public uint stage_id { get; set; }
    [ProtoMember(6)]
    public _vector3 loc { get; set; }
    [ProtoMember(7)]
    public uint warp_arg { get; set; }
    [ProtoMember(8)]
    public int user_connected_gateway_server_index { get; set; }
    [ProtoMember(9)]
    public uint warp_location_id { get; set; }
    [ProtoMember(10)]
    _characterInfo char_info { get; set; }
    [ProtoMember(11)]
    public _cost_info[] warp_cost_list { get; set; }
    [ProtoMember(12)]
    public _stack_item_info[] warp_item_list { get; set; }
    [ProtoMember(13)]
    public uint warp_method { get; set; }
    [ProtoMember(14)]
    public float warp_rotation { get; set; }
    [ProtoMember(15)]
    public bool is_same_stage_warp { get; set; }
    [ProtoMember(16)]
    public _dungeon_ticket_info[] warp_dungeon_ticket { get; set; }
    [ProtoMember(17)]
    public bool pvp_enable { get; set; }

}

[ProtoContract]
public class _packet_world_game_request_warp_ready_same_zonegroup
{
    [ProtoMember(1)]

    public ulong warp_user_account_uid { get; set; }
    [ProtoMember(2)]
    public ulong warp_user_uid { get; set; }
    [ProtoMember(3)]
    public int dest_world_server_zonegroup_index { get; set; }
    [ProtoMember(4)]
    public ulong dest_zone_uid { get; set; }
    [ProtoMember(5)]
    warp_info warp_info { get; set; }

}

[ProtoContract]
public class GAME_CLIENT_WARP_FAIL
{
    [ProtoMember(1)]

    public ulong warp_user_uid { get; set; }
    [ProtoMember(2)]
    public int fail_reason { get; set; }

}

[ProtoContract]
public class _packet_game_world_connect_client_session_success
{
    [ProtoMember(1)]

    public ulong warp_user_uid { get; set; }

}

[ProtoContract]
public class _packet_client_game_warp_way_point
{
    [ProtoMember(1)]

    public ulong warp_user_uid { get; set; }
    [ProtoMember(2)]
    public uint way_point_index { get; set; }

}

[ProtoContract]
public class _packet_client_game_warp_direct_point
{
    [ProtoMember(1)]

    public ulong warp_user_uid { get; set; }
    [ProtoMember(2)]
    public uint stage_id { get; set; }
    [ProtoMember(3)]
    public _vector3 warp_location { get; set; }

}

[ProtoContract]
public class WORLD_GATEWAY_REQUEST_LOGIN_READY
{
    [ProtoMember(1)]

    public ulong account_uid { get; set; }
    [ProtoMember(2)]
    public ulong login_user_uid { get; set; }
    [ProtoMember(3)]
    public int zonegroup_index { get; set; }
    [ProtoMember(4)]
    public ulong zone_unique { get; set; }
    [ProtoMember(5)]
    public uint stage_id { get; set; }
    [ProtoMember(6)]
    public int gameserver_index { get; set; }
    [ProtoMember(7)]
    public int gameserver_zonegroup_index { get; set; }
    [ProtoMember(8)]
    public int account_grade { get; set; }
    [ProtoMember(9)]
    public int store_type { get; set; }
    [ProtoMember(10)]
    public bool assassin_mode { get; set; }

}

[ProtoContract]
public class GATEWAY_WORLD_LOGIN_READY_RESULT
{
    [ProtoMember(1)]

    public uint result { get; set; }
    [ProtoMember(2)]
    public ulong login_user_uid { get; set; }

}

[ProtoContract]
public class WORLD_GATEWAY_REQUEST_WARP_READY
{
    [ProtoMember(1)]

    public ulong warp_user_uid { get; set; }
    [ProtoMember(2)]
    public ulong warp_zone_unique { get; set; }
    [ProtoMember(5)]
    public int warp_zonegroup_index { get; set; }
    [ProtoMember(6)]
    warp_info warp_info { get; set; }
    [ProtoMember(7)]
    _characterInfo char_info { get; set; }
    [ProtoMember(8)]
    public int gameserver_index { get; set; }
    [ProtoMember(9)]
    public int gameserver_zonegroup_index { get; set; }
    [ProtoMember(10)]
    public int gatewayserver_index { get; set; }
    [ProtoMember(11)]
    public ulong depature_zone_uid { get; set; }
    [ProtoMember(12)]
    public bool pvp_enable { get; set; }

}

[ProtoContract]
public class GAME_WORLD_REQUEST_EVENT_BOSS_WARP
{
    [ProtoMember(1)]

    public ulong uid { get; set; }
    [ProtoMember(2)]
    public uint event_boss_id { get; set; }
    [ProtoMember(3)]
    warp_info warp_info { get; set; }
    [ProtoMember(4)]
    public uint exec_type { get; set; }
    [ProtoMember(5)]
    public ulong zone_uid { get; set; }

}

[ProtoContract]
public class WORLD_GAME_POST_WARP_READY
{
    [ProtoMember(1)]

    public ulong warp_user_uid { get; set; }
    [ProtoMember(2)]
    _gameserver_sync_hunting_squad_info hunting_squad_info { get; set; }
    [ProtoMember(3)]
    _gameserver_sync_secret_dungeon_exit_time secret_dungeon_exit_time { get; set; }
    [ProtoMember(4)]
    _gameserver_sync_magic_square_exit_time magic_square_exit_time { get; set; }

}

[ProtoContract]
public class WORLD_CLIENT_POST_WARP_END
{


}

[ProtoContract]
public class WORLD_GAME_CHEAT_GO_TO_OTHERUSER
{
    [ProtoMember(1)]

    public ulong user_uid { get; set; }
    [ProtoMember(2)]
    public ulong target_user_uid { get; set; }

}

[ProtoContract]
public class GAME_WORLD_CHEAT_GO_TO_OTHERUSER
{
    [ProtoMember(1)]

    public ulong user_uid { get; set; }
    [ProtoMember(2)]
    public ulong target_user_uid { get; set; }
    [ProtoMember(3)]
    public _vector3 target_pos { get; set; }

}

[ProtoContract]
public class CLIENT_GAME_WARP_TO_ESCAPE_POS
{
}

[ProtoContract]
public class GAME_WORLD_WARP_TO_ESCAPE_POS
{
}

[ProtoContract]
public class warp_register_info
{
    [ProtoMember(1)]

    public ulong user_uid { get; set; }
    [ProtoMember(2)]
    public ulong dest_zone_uid { get; set; }
    [ProtoMember(3)]
    public uint dest_world_server_zonegroup_index { get; set; }
    [ProtoMember(4)]
    warp_info warp_info { get; set; }

}

[ProtoContract]
public class warp_cache_data
{
    [ProtoMember(1)]

    public byte[] user_data { get; set; }

}

[ProtoContract]
public class GAME_CACHEDATA_REQUEST_DATA_REGISTER
{
    [ProtoMember(1)]

    warp_register_info warp_data { get; set; }
    [ProtoMember(2)]
    warp_cache_data cache_data { get; set; }

}

[ProtoContract]
public class GAME_CACHEDATA_RESPONSE_DATA_REGISTER
{
    [ProtoMember(1)]

    warp_register_info warp_data { get; set; }

}

[ProtoContract]
public class warp_get_info
{
    [ProtoMember(1)]

    public ulong user_uid { get; set; }
    [ProtoMember(2)]
    public ulong account_uid { get; set; }
    [ProtoMember(3)]
    public int cur_worker_index { get; set; }
    [ProtoMember(4)]
    public ulong dest_zone_uid { get; set; }
    [ProtoMember(5)]
    public int depature_world_server_zone_group_index { get; set; }
    [ProtoMember(6)]
    public int user_connected_proxy_server_type { get; set; }
    [ProtoMember(7)]
    public int user_connected_proxy_server_index { get; set; }
    [ProtoMember(8)]
    warp_info warp_info { get; set; }

}

[ProtoContract]
public class GAME_CACHEDATA_REQUEST_DATA_GET
{
    [ProtoMember(1)]

    warp_get_info warp_data { get; set; }

}

[ProtoContract]
public class GAME_CACHEDATA_RESPONSE_DATA_GET
{
    [ProtoMember(1)]

    warp_get_info warp_data { get; set; }
    [ProtoMember(2)]
    warp_cache_data cache_data { get; set; }

}

[ProtoContract]
public class CLIENT_GAME_WARP_STATE_CHECK
{
    [ProtoMember(1)]

    public ulong user_uid { get; set; }

}

[ProtoContract]
public class CLIENT_GAME_EMERGENCY_WARP
{

}

[ProtoContract]
public class GAME_CLIENT_RETURN_POSITION
{
    [ProtoMember(1)]

    public _vector3 loc { get; set; }
    [ProtoMember(2)]
    public float degree { get; set; }

}

[ProtoContract]
public class CLIENT_GAME_WARP_USER_STATE
{

}

[ProtoContract]
public class GAME_CLIENT_WARP_USER_STATE
{
    [ProtoMember(1)]

    public bool is_retry { get; set; }

}


[ProtoContract]
public class _world_boss_zone_info
{
    [ProtoMember(1)]

    public ulong zone_unique { get; set; }
    [ProtoMember(2)]
    public int channel_id { get; set; }
    [ProtoMember(3)]
    public int curr_users { get; set; }
    [ProtoMember(4)]
    public int zone_state { get; set; }
    [ProtoMember(5)]
    public bool in_party_member { get; set; }

}

[ProtoContract]
public class _user_contribute_info
{
    [ProtoMember(1)]

    public uint rank { get; set; }
    [ProtoMember(2)]
    public ulong user_uid { get; set; }
    [ProtoMember(3)]
    public string nickname { get; set; }
    [ProtoMember(4)]
    public int class_id { get; set; }
    [ProtoMember(5)]
    public int level { get; set; }
    [ProtoMember(6)]
    public bool is_party { get; set; }
    [ProtoMember(7)]
    public uint point { get; set; }
    [ProtoMember(8)]
    public ulong total_point { get; set; }

}

[ProtoContract]
public class _contribute_info
{
    [ProtoMember(1)]

    public _user_contribute_info[] contribute_info { get; set; }

}

[ProtoContract]
public class _boss_event_info
{
    [ProtoMember(1)]

    public int event_boss_id { get; set; }
    [ProtoMember(2)]
    public int event_state { get; set; }
    [ProtoMember(3)]
    public long event_remaining_time { get; set; }

}

[ProtoContract]
public class WORLD_GAME_WORLD_EVENT_NOTIFY
{
    [ProtoMember(1)]

    public ulong zone_uid { get; set; }
    [ProtoMember(2)]
    GAME_CLIENT_WORLD_EVENT_NOTIFY notify_packet { get; set; }

}

[ProtoContract]
public class GAME_CLIENT_WORLD_EVENT_NOTIFY
{
    [ProtoMember(1)]

    public int event_stage_id { get; set; }
    [ProtoMember(2)]
    public int event_type { get; set; }
    [ProtoMember(3)]
    public int event_value { get; set; }
    [ProtoMember(4)]
    public int title_sting_id { get; set; }
    [ProtoMember(5)]
    public int message_string_id { get; set; }
    [ProtoMember(6)]
    public int event_state { get; set; }

}

[ProtoContract]
public class WORLD_CLIENT_WORLD_EVENT_NOTIFY_ONE_USER
{
    [ProtoMember(1)]

    public int event_type { get; set; }
    [ProtoMember(2)]
    public int event_value { get; set; }
    [ProtoMember(3)]
    public int title_sting_id { get; set; }
    [ProtoMember(4)]
    public int message_string_id { get; set; }
    [ProtoMember(5)]
    public int run_time { get; set; }
    [ProtoMember(6)]
    public int event_state { get; set; }

}

[ProtoContract]
public class GAME_WORLD_EVENT_BOSS_DIE
{
    [ProtoMember(1)]

    public ulong zone_uid { get; set; }
    [ProtoMember(2)]
    public int boss_id { get; set; }
    [ProtoMember(3)]
    public int boss_Type { get; set; }
    [ProtoMember(4)]
    public bool is_success { get; set; }

}

[ProtoContract]
public class CLIENT_WORLD_WORLD_EVENT_BOSS_LIST
{
    [ProtoMember(1)]

    public int boss_type { get; set; }
    [ProtoMember(2)]
    public int boos_area_id { get; set; }

}

[ProtoContract]
public class WORLD_CLIENT_WORLD_EVENT_BOSS_LIST
{
    [ProtoMember(1)]

    public int boss_type { get; set; }
    [ProtoMember(2)]
    public int boos_area_id { get; set; }
    [ProtoMember(3)]
    public int[] run_event_list { get; set; }
    [ProtoMember(4)]
    public _boss_event_info[] info_list { get; set; }

}

[ProtoContract]
public class WORLD_CLIENT_WORLD_EVENT_END
{
    [ProtoMember(1)]

    public int event_type { get; set; }
    [ProtoMember(2)]
    public int event_value { get; set; }

}

[ProtoContract]
public class CLIENT_WORLD_WORLD_BOSS_ZONE_LIST
{
    [ProtoMember(1)]

    public int boss_id { get; set; }

}

[ProtoContract]
public class WORLD_CLIENT_WORLD_BOSS_ZONE_LIST
{
    [ProtoMember(1)]

    public int boss_id { get; set; }
    [ProtoMember(2)]
    public int event_state { get; set; }
    [ProtoMember(3)]
    public _world_boss_zone_info[] zone_list { get; set; }

}

[ProtoContract]
public class CLIENT_GAME_WORLD_BOSS_CONTRIBUTE_INFO
{

}

[ProtoContract]
public class GAME_CLIENT_WORLD_BOSS_CONTRIBUTE_INFO
{
    [ProtoMember(1)]

    public _user_contribute_info[] contribute_list { get; set; }
    [ProtoMember(2)]
    _user_contribute_info my_contribute { get; set; }

}

[ProtoContract]
public class GAME_CLIENT_WORLD_BOSS_DROP_ITEM
{
    [ProtoMember(1)]

    public int boss_id { get; set; }
    [ProtoMember(2)]
    public int drop_rank { get; set; }
    [ProtoMember(3)]
    public _cost_info[] costInfos { get; set; }
    [ProtoMember(4)]
    public _character_inven_item[] dropitems { get; set; }
    [ProtoMember(5)]
    public string last_attack_nick_name { get; set; }
    [ProtoMember(6)]
    public int boss_type { get; set; }
    [ProtoMember(7)]
    public bool is_first_clear { get; set; }
    [ProtoMember(8)]
    public _cost_info[] reward_costInfos { get; set; }
    [ProtoMember(9)]
    public _simple_item_info[] reward_simple_item_info { get; set; }
    [ProtoMember(10)]
    public int GuildPoint { get; set; }
    [ProtoMember(11)]
    public int contribute_reward { get; set; }
    [ProtoMember(12)]
    public string contribute_grade { get; set; }
    [ProtoMember(13)]
    public _used_cost_info[] reward_used_costInfos { get; set; }
    [ProtoMember(14)]
    public int wave_num { get; set; }

}

[ProtoContract]
public class CLIENT_GAME_BOSS_CONTRIBUTE_LIST
{
}

[ProtoContract]
public class GAME_CLIENT_BOSS_CONTRIBUTE_LIST
{
    [ProtoMember(1)]

    public _contribute_info[] contribute_list { get; set; }

}

[ProtoContract]
public class BOSS_DROP_ITEM_INFO
{
    [ProtoMember(1)]

    public _user_contribute_info user_contribute { get; set; }
    [ProtoMember(2)]
    public _cost_info[] costInfos { get; set; }
    [ProtoMember(3)]
    public _character_inven_item[] dropitems { get; set; }
    [ProtoMember(4)]
    public _used_cost_info[] used_costInfos { get; set; }
    [ProtoMember(5)]
    public _simple_item_info[] simple_drop_items { get; set; }
    [ProtoMember(6)]
    public string contribute_grade { get; set; }

}

[ProtoContract]
public class BOSS_DROP_ITEM_GROUP_INFO
{
    [ProtoMember(1)]

    public BOSS_DROP_ITEM_INFO[] boss_drop_item_info { get; set; }

}

[ProtoContract]
public class CLIENT_GAME_BOSS_DROP_ITEM_LIST
{
}

[ProtoContract]
public class GAME_CLIENT_BOSS_DROP_ITEM_LIST
{
    [ProtoMember(1)]

    public BOSS_DROP_ITEM_INFO[] contribute_drop_item { get; set; }
    [ProtoMember(2)]
    public BOSS_DROP_ITEM_GROUP_INFO[] contribute_drop_group_item { get; set; }

}

[ProtoContract]
public class GAME_WORLD_EVENT_CONTENTS
{
}

[ProtoContract]
public class WORLD_GAME_EVENT_CONTENTS
{
    [ProtoMember(1)]

    public int[] ruuning_event_contents { get; set; }

}

[ProtoContract]
public class WORLD_GAME_EVENT_CONTENTS_NOTIFY
{
    [ProtoMember(1)]

    public int[] start_event_contents { get; set; }
    [ProtoMember(2)]
    public int[] end_event_contents { get; set; }

}

[ProtoContract]
public class _event_repeat_info
{
    [ProtoMember(1)]

    public int event_repeat_tid { get; set; }
    [ProtoMember(2)]
    public ulong period_start_time { get; set; }
    [ProtoMember(3)]
    public ulong period_end_time { get; set; }
    [ProtoMember(4)]
    public ulong event_start_time { get; set; }
    [ProtoMember(5)]
    public ulong event_end_time { get; set; }

}

[ProtoContract]
public class WORLD_GAME_EVENT_REPEAT_NOTIFY
{
    [ProtoMember(1)]

    public _event_repeat_info[] event_repeat_list { get; set; }

}

[ProtoContract]
public class CLIENT_GAME_EVENT_REPEAT
{
}

[ProtoContract]
public class GAME_CLIENT_EVENT_REPEAT
{
    [ProtoMember(1)]

    public _event_repeat_info[] event_repeat_list { get; set; }

}


[ProtoContract]
public class _channel_info
{
    [ProtoMember(1)]

    public int channel_index { get; set; }
    [ProtoMember(2)]
    public int party_member_count { get; set; }
    [ProtoMember(3)]
    public int status { get; set; }
    [ProtoMember(4)]
    public int boss_tid { get; set; }

}

[ProtoContract]
public class _raid_reward_info
{
    [ProtoMember(1)]

    public int item_index { get; set; }
    [ProtoMember(2)]
    public int count { get; set; }

}

[ProtoContract]
public class _user_raid_reward_info
{
    [ProtoMember(1)]

    public ulong user_uid { get; set; }
    [ProtoMember(2)]
    public _raid_reward_info[] default_reward_info { get; set; }
    [ProtoMember(3)]
    public _raid_reward_info[] random_reward_info { get; set; }
    [ProtoMember(4)]
    public uint reward_exp { get; set; }
    [ProtoMember(5)]
    public uint reward_cost_type { get; set; }
    [ProtoMember(6)]
    public uint reward_cost_value { get; set; }
    [ProtoMember(7)]
    public string nickname { get; set; }
    [ProtoMember(8)]
    public uint class_id { get; set; }
    [ProtoMember(9)]
    public uint level { get; set; }
    [ProtoMember(10)]
    public uint reward_guild_party_cost_type { get; set; }
    [ProtoMember(11)]
    public uint reward_guild_party_cost_value { get; set; }

}

[ProtoContract]
public class _packet_s_wg_request_remove_zone
{
    [ProtoMember(1)]

    public ulong zone_unique { get; set; }

}

[ProtoContract]
public class _packet_s_gw_remove_zone_result
{
    [ProtoMember(1)]

    public ulong zone_unique { get; set; }
    [ProtoMember(2)]
    public bool remove_result { get; set; }

}

[ProtoContract]
public class CLIENT_GAME_CHANNEL_MOVE
{
    [ProtoMember(1)]

    public ulong user_uid { get; set; }
    [ProtoMember(2)]
    public int channel_index { get; set; }

}

[ProtoContract]
public class GAME_WORLD_CHANNEL_MOVE_CHECK
{
    [ProtoMember(1)]

    public ulong user_uid { get; set; }
    [ProtoMember(2)]
    _casting_info casting_info { get; set; }

}

[ProtoContract]
public class WORLD_GAME_CHANNEL_MOVE_CHECK
{
    [ProtoMember(1)]

    public ulong user_uid { get; set; }
    [ProtoMember(2)]
    _casting_info casting_info { get; set; }

}

[ProtoContract]
public class _packet_game_world_channel_move
{
    [ProtoMember(1)]

    public ulong user_uid { get; set; }
    [ProtoMember(2)]
    public int channel_index { get; set; }
    [ProtoMember(3)]
    public _vector3 loc { get; set; }

}

[ProtoContract]
public class WORLD_CLIENT_CHANNEL_LIST
{
    [ProtoMember(1)]

    public ulong user_uid { get; set; }
    [ProtoMember(2)]
    public int cur_channel_index { get; set; }
    [ProtoMember(3)]
    public _channel_info[] channel_info { get; set; }

}

[ProtoContract]
public class CLIENT_WORLD_CHANNEL_LIST
{
    [ProtoMember(1)]

    public ulong user_uid { get; set; }

}

[ProtoContract]
public class a
{
    [ProtoMember(1)]

    public ulong enter_user_uid { get; set; }
    [ProtoMember(2)]
    public int stageid { get; set; }
    [ProtoMember(3)]
    public _vector3 loc { get; set; }

}

[ProtoContract]
public class _packet_s_enter_phasing_zone
{
    [ProtoMember(1)]

    public ulong enter_user_uid { get; set; }
    [ProtoMember(2)]
    public int enter_phasing_id { get; set; }
    [ProtoMember(3)]
    public int stageid { get; set; }
    [ProtoMember(4)]
    public _vector3 loc { get; set; }

}

[ProtoContract]
public class _packet_s_leave_phasing_zone
{
    [ProtoMember(1)]

    public ulong leave_user_uid { get; set; }
    [ProtoMember(2)]
    public int stageid { get; set; }
    [ProtoMember(3)]
    public _vector3 loc { get; set; }

}

[ProtoContract]
public class GAME_CLIENT_WORLD_BOSS_RAID_COUNT_DOWN
{
    [ProtoMember(1)]

    public int left_time_sec { get; set; }

}

[ProtoContract]
public class CLIENT_WORLD_INSTANCE_DUNGEON_ENTER
{
    [ProtoMember(1)]

    public ulong uid { get; set; }
    [ProtoMember(2)]
    public uint world_boss_raid_id { get; set; }
    [ProtoMember(3)]
    public bool is_party { get; set; }

}

[ProtoContract]
public class WORLD_CLIENT_INSTANCE_DUNGEON_ENTER_ERROR
{
    [ProtoMember(1)]

    public ulong receive_user_id { get; set; }
    [ProtoMember(2)]
    public int error_id { get; set; }

}

[ProtoContract]
public class CLIENT_GAME_INSTANCE_ZONE_OUT
{
    [ProtoMember(1)]

    public ulong uid { get; set; }
    [ProtoMember(2)]
    public int out_stage_type { get; set; }

}

[ProtoContract]
public class GAME_CLIENT_CHANNEL_MOVE_FAIL
{
    [ProtoMember(1)]

    public ulong user_uid { get; set; }
    [ProtoMember(2)]
    public int error_id { get; set; }

}

[ProtoContract]
public class _packet_s_notify_stage_clear_to_world_server
{
    [ProtoMember(1)]

    public ulong zone_uid { get; set; }

}

[ProtoContract]
public class GAME_CLIENT_REWARD_RECEVE_INFO
{
    [ProtoMember(1)]

    public _raid_reward_receive_info[] receive_info { get; set; }

}

[ProtoContract]
public class WORLD_GAME_QRY_CREATE_ZONE_v2
{
    [ProtoMember(1)]

    public int zonegroup_index { get; set; }
    [ProtoMember(2)]
    public ulong zoneUnique { get; set; }
    [ProtoMember(3)]
    public int stageId { get; set; }
    [ProtoMember(4)]
    public int phasing_id { get; set; }
    [ProtoMember(5)]
    public int channel_index { get; set; }
    [ProtoMember(6)]
    _siege_info siege_info { get; set; }
    [ProtoMember(7)]
    public ulong hunting_squad_uid { get; set; }
    [ProtoMember(8)]
    public ulong[] hunting_squad_member_list { get; set; }
    [ProtoMember(9)]
    _strong_point_server_info strong_point_server_info { get; set; }
    [ProtoMember(11)]
    _guild_war_npc_info guild_war_npc_info { get; set; }
    [ProtoMember(12)]
    _sanctum_server_info sanctum_server_info { get; set; }
    [ProtoMember(13)]
    _dark_altar_server_info dark_altar_server_info { get; set; }
    [ProtoMember(14)]
    _plunder_server_info plunder_server_info { get; set; }
    [ProtoMember(15)]
    _sabuk_zone_create_info sabuk_zone_create_info { get; set; }

}

[ProtoContract]
public class GAME_WORLD_REP_CREATE_ZONE
{
    [ProtoMember(1)]

    public uint zonegroup_index { get; set; }
    [ProtoMember(2)]
    public long zoneUnique { get; set; }
    [ProtoMember(3)]
    public int result { get; set; }

}

[ProtoContract]
public class GAME_CLIENT_ATTACK_NPC
{
    [ProtoMember(1)]

    public ulong npc_uid { get; set; }
    [ProtoMember(2)]
    public int attack_id { get; set; }
    [ProtoMember(3)]
    public _vector3 cur_pos { get; set; }
    [ProtoMember(4)]
    public ulong target_uid { get; set; }
    [ProtoMember(5)]
    public int target_type { get; set; }
    [ProtoMember(6)]
    public _vector3 dest_pos { get; set; }
    [ProtoMember(7)]
    public bool is_skill_move { get; set; }
    [ProtoMember(8)]
    public bool is_link_attack { get; set; }
    [ProtoMember(9)]
    public float degree { get; set; }

}

[ProtoContract]
public class WORLD_CLIENT_WAITING_ZONE
{
    [ProtoMember(1)]

    public uint stage_id { get; set; }
    [ProtoMember(2)]
    public uint location_id { get; set; }
    [ProtoMember(3)]
    public int warp_method { get; set; }
    [ProtoMember(4)]
    public uint warp_arg { get; set; }
    [ProtoMember(5)]
    public uint need_item_id { get; set; }

}

[ProtoContract]
public class CLIENT_WORLD_REGISTER_WAITING_ZONE
{
    [ProtoMember(1)]

    public ulong uid { get; set; }
    [ProtoMember(2)]
    public uint location_id { get; set; }
    [ProtoMember(3)]
    public int warp_method { get; set; }
    [ProtoMember(4)]
    public uint warp_arg { get; set; }

}

[ProtoContract]
public class CLIENT_WORLD_CANCEL_REGISTER_WAITING_ZONE
{
    [ProtoMember(1)]

    public ulong uid { get; set; }
    [ProtoMember(2)]
    public ulong zone_uid { get; set; }

}

[ProtoContract]
public class WORLD_CLIENT_REGISTER_WAITING_ZONE_FAIL
{
    [ProtoMember(1)]

    public int error_id { get; set; }

}

[ProtoContract]
public class WORLD_CLIENT_WAITING_ZONE_INFO
{
    [ProtoMember(1)]

    public uint stage_id { get; set; }
    [ProtoMember(2)]
    public uint location_id { get; set; }
    [ProtoMember(3)]
    public ulong zone_uid { get; set; }
    [ProtoMember(4)]
    public int estimated_time { get; set; }
    [ProtoMember(5)]
    public int waiting_number { get; set; }

}

[ProtoContract]
public class WORLD_CLIENT_WAITING_ZONE_ENTER_READY
{
    [ProtoMember(1)]

    public uint stage_id { get; set; }
    [ProtoMember(2)]
    public uint location_id { get; set; }
    [ProtoMember(3)]
    public ulong zone_uid { get; set; }
    [ProtoMember(4)]
    public int end_time { get; set; }

}

[ProtoContract]
public class CLIENT_WORLD_CANCEL_WAITING_ZONE_ENTER
{
    [ProtoMember(1)]

    public ulong uid { get; set; }
    [ProtoMember(2)]
    public ulong zone_uid { get; set; }

}

[ProtoContract]
public class WORLD_CLIENT_CANCEL_ALL_WAITING_ZONE
{
    [ProtoMember(1)]

    public int error_id { get; set; }

}

[ProtoContract]
public class _packet_c_warpZone
{
    [ProtoMember(1)]

    public ulong uid { get; set; }
    [ProtoMember(2)]
    public ulong uid_um { get; set; }
    [ProtoMember(3)]
    public ulong zone_unique { get; set; }

}

[ProtoContract]
public class GAME_CLIENT_WARP_START
{
    [ProtoMember(1)]

    public _characterInfo CharInfo { get; set; }
    [ProtoMember(2)]
    public int CombatPoint { get; set; }
    [ProtoMember(3)]
    public _stat_info[] stat { get; set; }
    [ProtoMember(4)]
    public ulong zone_uid { get; set; }
    [ProtoMember(5)]
    public bool pvp_enable { get; set; }
    [ProtoMember(6)]
    public bool assassin_mode { get; set; }

}

[ProtoContract]
public class GAME_CLIENT_MONSTER_STRING
{
    [ProtoMember(1)]

    public int first_string_id { get; set; }
    [ProtoMember(2)]
    public int second_string_id { get; set; }

}

[ProtoContract]
public class GAME_CLIENT_DEBUG_FORCE_SYNC_MONSTER
{
    [ProtoMember(1)]

    public ulong monster_uid { get; set; }
    [ProtoMember(2)]
    public _vector3 loc { get; set; }

}

[ProtoContract]
public class GAME_CLIENT_DEBUG_FORCE_SYNC_USER
{
    [ProtoMember(1)]

    public _vector3 loc { get; set; }
    [ProtoMember(2)]
    public int prevBlockId { get; set; }
    [ProtoMember(3)]
    public int currBlockId { get; set; }

}

[ProtoContract]
public class GAME_CLIENT_CHANGE_FEATURE
{
    [ProtoMember(1)]

    public ulong uid { get; set; }
    [ProtoMember(2)]
    public int weapon_id { get; set; }
    [ProtoMember(3)]
    public int costume_id { get; set; }
    [ProtoMember(4)]
    public int weapon_level { get; set; }
    [ProtoMember(5)]
    public int hair_color_index_id { get; set; }
    [ProtoMember(6)]
    public int clothes_color_index { get; set; }
    [ProtoMember(7)]
    public _equip_costume_info[] equip_costume_list { get; set; }

}

[ProtoContract]
public class GAME_CLIENT_START_TIMER
{
    [ProtoMember(1)]

    public long remainingTime { get; set; }
    [ProtoMember(2)]
    public int timer_index { get; set; }

}

[ProtoContract]
public class GAME_CLIENT_NOTIFY_STAGE_CLEAR
{
    [ProtoMember(1)]

    public _raid_reward_info[] default_reward_info { get; set; }
    [ProtoMember(2)]
    public _raid_reward_info[] random_reward_info { get; set; }
    [ProtoMember(3)]
    public uint raid_id { get; set; }
    [ProtoMember(4)]
    public uint sequence_id { get; set; }
    [ProtoMember(5)]
    public _user_raid_reward_info[] user_reward_info { get; set; }
    [ProtoMember(6)]
    public uint end_time { get; set; }
    [ProtoMember(7)]
    public uint gain_point { get; set; }

}

[ProtoContract]
public class GAME_CLIENT_NOTIFY_STAGE_CLEAR_UPDATE_ITEM
{
    [ProtoMember(1)]

    public _character_inven_item[] update_items { get; set; }

}

[ProtoContract]
public class GAME_CLIENT_NOTIFY_STAGE_FAIL
{
    [ProtoMember(1)]

    public uint fail_result { get; set; }
    [ProtoMember(2)]
    public uint sequence_id { get; set; }
    [ProtoMember(3)]
    public uint raid_id { get; set; }
    [ProtoMember(4)]
    public uint die_count { get; set; }
    [ProtoMember(5)]
    public int boss_id { get; set; }
    [ProtoMember(6)]
    public _cost_info[] costInfos { get; set; }
    [ProtoMember(7)]
    public _character_inven_item[] dropitems { get; set; }
    [ProtoMember(8)]
    public int boss_type { get; set; }
    [ProtoMember(9)]
    public uint gain_point { get; set; }
    [ProtoMember(10)]
    public int wave_num { get; set; }

}

[ProtoContract]
public class CLIENT_GAME_MAP_WAYPOINT_OPEN
{
    [ProtoMember(1)]

    public int waypoint_id { get; set; }

}

[ProtoContract]
public class GAME_CLIENT_MAP_WAYPOINT_OPEN
{
    [ProtoMember(1)]

    public int result { get; set; }
    [ProtoMember(2)]
    public int waypoint_id { get; set; }

}

[ProtoContract]
public class GAME_CLIENT_CHANNEL_INFO
{
    [ProtoMember(1)]

    public int cur_channel_index { get; set; }

}

[ProtoContract]
public class WORLD_GATEWAY_NOTIFY_REMOVE_ZONE
{
    [ProtoMember(1)]

    public ulong zone_unique { get; set; }

}

[ProtoContract]
public class CLIENT_GAME_ENTER_OCCUPATION_BATTLE_FIELD
{
    [ProtoMember(1)]

    public uint occupation_id { get; set; }

}

[ProtoContract]
public class GAME_WORLD_ENTER_OCCUPATION_BATTLE_FIELD
{
    [ProtoMember(1)]

    public uint occupation_id { get; set; }
    [ProtoMember(2)]
    public ulong user_uid { get; set; }
    [ProtoMember(3)]
    public uint warp_method { get; set; }

}

[ProtoContract]
public class UserDropReceiveInfo
{
    [ProtoMember(1)]

    public ulong receive_user_uid { get; set; }
    [ProtoMember(2)]
    public _simple_item_info[] item_receive_info { get; set; }

}

[ProtoContract]
public class GAME_CLIENT_MEMBER_ITEM_DROP_RECEIVE_LIST
{
    [ProtoMember(1)]

    public UserDropReceiveInfo[] drop_receive_info_list { get; set; }

}

[ProtoContract]
public class CLIENT_GAME_REQUEST_MEMBER_DROP_RECEIVE_LIST
{

}

[ProtoContract]
public class GAME_WORLD_STAGE_FAIL
{
    [ProtoMember(1)]

    public ulong zone_unique { get; set; }

}

[ProtoContract]
public class CLIENT_GAME_ENTER_PLUNDER_BATTLE_FIELD
{
    [ProtoMember(1)]

    public uint plunder_tid { get; set; }

}

[ProtoContract]
public class GAME_WORLD_ENTER_PLUNDER_BATTLE_FIELD
{
    [ProtoMember(1)]

    public uint plunder_tid { get; set; }
    [ProtoMember(2)]
    public ulong user_uid { get; set; }
    [ProtoMember(3)]
    public uint warp_method { get; set; }

}

[ProtoContract]
public class stage_mon_gen_info
{
    [ProtoMember(1)]

    public int stage_mon_gen_id { get; set; }
    [ProtoMember(2)]
    public long despawn_time { get; set; }

}

[ProtoContract]
public class GAME_CLIENT_STAGE_MON_GEN_LIST
{
    [ProtoMember(1)]

    public stage_mon_gen_info[] info_list { get; set; }
    [ProtoMember(3)]
    public int[] stage_mon_gen_id_list { get; set; }

}

[ProtoContract]
public class GAME_CLIENT_STAGE_MON_GEN_ADD
{
    [ProtoMember(1)]

    public stage_mon_gen_info[] info_list { get; set; }
    [ProtoMember(3)]
    public int[] stage_mon_gen_id_list { get; set; }

}

[ProtoContract]
public class GAME_CLIENT_STAGE_MON_GEN_DEL
{
    [ProtoMember(1)]

    public int[] stage_mon_gen_id_list { get; set; }

}

[ProtoContract]
public class GAME_CLIENT_MONSTER_SYSTEM_MESSAGE
{
    [ProtoMember(1)]

    public int first_string_id { get; set; }

}

[ProtoContract]
public class GAME_CLIENT_MONSTER_STRING_2
{
    [ProtoMember(1)]

    public int first_string_id { get; set; }
    [ProtoMember(2)]
    public string second_string { get; set; }

}

[ProtoContract]
public class CLIENT_GAME_ENTER_SABUK_BATTLE_FIELD
{
    [ProtoMember(1)]

    public uint sabuk_round_tid { get; set; }

}

[ProtoContract]
public class GAME_WORLD_ENTER_SABUK_BATTLE_FIELD
{
    [ProtoMember(1)]

    public uint sabuk_round_tid { get; set; }
    [ProtoMember(2)]
    public ulong user_uid { get; set; }
    [ProtoMember(3)]
    public uint warp_method { get; set; }

}

[ProtoContract]
public class GAME_CLIENT_ZONE_MONSTER_ATTACKER_LIST
{
    [ProtoMember(1)]

    public ulong zone_uid { get; set; }
    [ProtoMember(2)]
    public uint zone_tid { get; set; }
    [ProtoMember(3)]
    public ulong monster_uid { get; set; }
    [ProtoMember(4)]
    public ulong monster_guild_uid { get; set; }
    [ProtoMember(5)]
    public ulong[] attacker_uid { get; set; }

}

[ProtoContract]
public class GAME_CLIENT_ZONE_MONSTER_ATTACKER_ADD
{
    [ProtoMember(1)]

    public ulong monster_uid { get; set; }
    [ProtoMember(2)]
    public ulong monster_guild_uid { get; set; }
    [ProtoMember(3)]
    public ulong attacker_uid { get; set; }

}

[ProtoContract]
public class GAME_CLIENT_ZONE_MONSTER_ATTACKER_DEL
{
    [ProtoMember(1)]

    public ulong monster_uid { get; set; }
    [ProtoMember(2)]
    public ulong monster_guild_uid { get; set; }
    [ProtoMember(3)]
    public ulong[] attacker_uid { get; set; }

}


[ProtoContract]
public class GAME_CLIENT_ZONEEVENT_NOTIFY
{
    [ProtoMember(1)]

    public int notify_type { get; set; }
    [ProtoMember(2)]
    public int argument01 { get; set; }
    [ProtoMember(3)]
    public int argument02 { get; set; }
    [ProtoMember(4)]
    public int argument03 { get; set; }

}

[ProtoContract]
public class GAME_CLIENT_ZONE_EVENT_USER_CONTROL
{
    [ProtoMember(1)]

    public int control_type { get; set; }
    [ProtoMember(2)]
    public int control_value { get; set; }

}

[ProtoContract]
public class CLIENT_GAME_ZONE_EVENT_NOTIFY
{
    [ProtoMember(1)]

    public int notify_type { get; set; }

}

[ProtoContract]
public class CLIENT_GAME_ZONE_EVENT_TIMER
{
}

[ProtoContract]
public class GAME_CLIENT_ZONE_EVENT_TIMER
{
    [ProtoMember(1)]

    public int timer_index { get; set; }
    [ProtoMember(2)]
    public long remaining_time { get; set; }

}

}
