//By AlSch092 @ Github
﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mir4ClientEmulator.Network.WebLogin.JSON
{
    // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse);
    public class Files
    {
        [JsonProperty("ACHIEVEMENT.csv")]
        public string ACHIEVEMENTcsv { get; set; }

        [JsonProperty("ACHIEVEMENT_LEVEL.csv")]
        public string ACHIEVEMENT_LEVELcsv { get; set; }

        [JsonProperty("ADS_INFO.csv")]
        public string ADS_INFOcsv { get; set; }

        [JsonProperty("AIRWALK.csv")]
        public string AIRWALKcsv { get; set; }

        [JsonProperty("AREANAME.csv")]
        public string AREANAMEcsv { get; set; }

        [JsonProperty("AUTOFLIGHT_PATH.csv")]
        public string AUTOFLIGHT_PATHcsv { get; set; }

        [JsonProperty("BATTLE_PASS_GROUP.csv")]
        public string BATTLE_PASS_GROUPcsv { get; set; }

        [JsonProperty("BATTLE_PASS_INFO.csv")]
        public string BATTLE_PASS_INFOcsv { get; set; }

        [JsonProperty("BATTLE_PASS_MISSION.csv")]
        public string BATTLE_PASS_MISSIONcsv { get; set; }

        [JsonProperty("BATTLE_PASS_REWARD.csv")]
        public string BATTLE_PASS_REWARDcsv { get; set; }

        [JsonProperty("BLACKDRAGON_DUNGEON.csv")]
        public string BLACKDRAGON_DUNGEONcsv { get; set; }

        [JsonProperty("BROADCAST.csv")]
        public string BROADCASTcsv { get; set; }

        [JsonProperty("BUFF.csv")]
        public string BUFFcsv { get; set; }

        [JsonProperty("BUFF_ATTACK.csv")]
        public string BUFF_ATTACKcsv { get; set; }

        [JsonProperty("BUFF_GUILD_DEV.csv")]
        public string BUFF_GUILD_DEVcsv { get; set; }

        [JsonProperty("BUFF_OVERLAPCALL.csv")]
        public string BUFF_OVERLAPCALLcsv { get; set; }

        [JsonProperty("BUFF_PARTY.csv")]
        public string BUFF_PARTYcsv { get; set; }

        [JsonProperty("CAMERA_PRESET.csv")]
        public string CAMERA_PRESETcsv { get; set; }

        [JsonProperty("CHANNEL.csv")]
        public string CHANNELcsv { get; set; }

        [JsonProperty("CHARACTER_EMOTE.csv")]
        public string CHARACTER_EMOTEcsv { get; set; }

        [JsonProperty("CHARACTER_EXPBOOSTER.csv")]
        public string CHARACTER_EXPBOOSTERcsv { get; set; }

        [JsonProperty("CHARACTER_EXPBOOSTER_ITEM.csv")]
        public string CHARACTER_EXPBOOSTER_ITEMcsv { get; set; }

        [JsonProperty("CHARACTER_FORCE.csv")]
        public string CHARACTER_FORCEcsv { get; set; }

        [JsonProperty("CHARACTER_FORCE_BLOOD.csv")]
        public string CHARACTER_FORCE_BLOODcsv { get; set; }

        [JsonProperty("CHARACTER_FORCE_LEVEL.csv")]
        public string CHARACTER_FORCE_LEVELcsv { get; set; }

        [JsonProperty("CHARACTER_GROW.csv")]
        public string CHARACTER_GROWcsv { get; set; }

        [JsonProperty("CHARACTER_GROWINDEX.csv")]
        public string CHARACTER_GROWINDEXcsv { get; set; }

        [JsonProperty("CHARACTER_MASTERY.csv")]
        public string CHARACTER_MASTERYcsv { get; set; }

        [JsonProperty("CHARACTER_MASTERY_LEVEL_LIMIT.csv")]
        public string CHARACTER_MASTERY_LEVEL_LIMITcsv { get; set; }

        [JsonProperty("CHARACTER_MASTERY_SLOT.csv")]
        public string CHARACTER_MASTERY_SLOTcsv { get; set; }

        [JsonProperty("CHARACTER_PARTS_DEFINES.csv")]
        public string CHARACTER_PARTS_DEFINEScsv { get; set; }

        [JsonProperty("CHARACTER_PRESET.csv")]
        public string CHARACTER_PRESETcsv { get; set; }

        [JsonProperty("CheatItemSet_Table.csv")]
        public string CheatItemSet_Tablecsv { get; set; }

        [JsonProperty("CINEMATIC_DIALOGUE.csv")]
        public string CINEMATIC_DIALOGUEcsv { get; set; }

        [JsonProperty("CLASS.csv")]
        public string CLASScsv { get; set; }

        [JsonProperty("CLASS_CREATE.csv")]
        public string CLASS_CREATEcsv { get; set; }

        [JsonProperty("CLASS_PHASE.csv")]
        public string CLASS_PHASEcsv { get; set; }

        [JsonProperty("CLIENT_ERROR_STRING.csv")]
        public string CLIENT_ERROR_STRINGcsv { get; set; }

        [JsonProperty("CLIENT_PRELOAD.csv")]
        public string CLIENT_PRELOADcsv { get; set; }

        [JsonProperty("CLOSED_TRAINING.csv")]
        public string CLOSED_TRAININGcsv { get; set; }

        [JsonProperty("CLOSED_TRAINING_COLLECT.csv")]
        public string CLOSED_TRAINING_COLLECTcsv { get; set; }

        [JsonProperty("CLOSED_TRAINING_LEVEL.csv")]
        public string CLOSED_TRAINING_LEVELcsv { get; set; }

        [JsonProperty("CLOSED_TRAINING_STATUS.csv")]
        public string CLOSED_TRAINING_STATUScsv { get; set; }

        [JsonProperty("COLLECTIONBOOK.csv")]
        public string COLLECTIONBOOKcsv { get; set; }

        [JsonProperty("COLLECTIONBOOK_MONSTER.csv")]
        public string COLLECTIONBOOK_MONSTERcsv { get; set; }

        [JsonProperty("COLLECTIONBOOK_MONSTER1.csv")]
        public string COLLECTIONBOOK_MONSTER1csv { get; set; }

        [JsonProperty("COLOR_INDEX.csv")]
        public string COLOR_INDEXcsv { get; set; }

        [JsonProperty("COMBATPOINT.csv")]
        public string COMBATPOINTcsv { get; set; }

        [JsonProperty("COMBO.csv")]
        public string COMBOcsv { get; set; }

        [JsonProperty("COMMAND_MARK.csv")]
        public string COMMAND_MARKcsv { get; set; }

        [JsonProperty("CONTENTS_ADMIN.csv")]
        public string CONTENTS_ADMINcsv { get; set; }

        [JsonProperty("CONTENTS_ALARM.csv")]
        public string CONTENTS_ALARMcsv { get; set; }

        [JsonProperty("CONTENTS_OPEN.csv")]
        public string CONTENTS_OPENcsv { get; set; }

        [JsonProperty("CONTRIBUTE_REWARD.csv")]
        public string CONTRIBUTE_REWARDcsv { get; set; }

        [JsonProperty("COSTUME.csv")]
        public string COSTUMEcsv { get; set; }

        [JsonProperty("COSTUME_ITEM.csv")]
        public string COSTUME_ITEMcsv { get; set; }

        [JsonProperty("COSTUME_PALETTE.csv")]
        public string COSTUME_PALETTEcsv { get; set; }

        [JsonProperty("COSTUME_PRESET.csv")]
        public string COSTUME_PRESETcsv { get; set; }

        [JsonProperty("CUSTOMIZING_TYPE.csv")]
        public string CUSTOMIZING_TYPEcsv { get; set; }

        [JsonProperty("DARKALTAR.csv")]
        public string DARKALTARcsv { get; set; }

        [JsonProperty("DEATHPENALTY_EXP.csv")]
        public string DEATHPENALTY_EXPcsv { get; set; }

        [JsonProperty("DROP_ITEM.csv")]
        public string DROP_ITEMcsv { get; set; }

        [JsonProperty("DROP_ITEMGROUP.csv")]
        public string DROP_ITEMGROUPcsv { get; set; }

        [JsonProperty("DROP_REWARD_BOX.csv")]
        public string DROP_REWARD_BOXcsv { get; set; }

        [JsonProperty("DROP_REWARD_BOX_POSITION.csv")]
        public string DROP_REWARD_BOX_POSITIONcsv { get; set; }

        [JsonProperty("DROP_REWARD_BOX_TYPE_PIE.csv")]
        public string DROP_REWARD_BOX_TYPE_PIEcsv { get; set; }

        [JsonProperty("DROP_REWARD_OBJECT_GROUP.csv")]
        public string DROP_REWARD_OBJECT_GROUPcsv { get; set; }

        [JsonProperty("DUNGEON_POSITION.csv")]
        public string DUNGEON_POSITIONcsv { get; set; }

        [JsonProperty("DUNGEON_SHOP.csv")]
        public string DUNGEON_SHOPcsv { get; set; }

        [JsonProperty("DUNGEON_TICKET.csv")]
        public string DUNGEON_TICKETcsv { get; set; }

        [JsonProperty("DUNGEON_TICKET_CHARGE.csv")]
        public string DUNGEON_TICKET_CHARGEcsv { get; set; }

        [JsonProperty("EFFECT.csv")]
        public string EFFECTcsv { get; set; }

        [JsonProperty("EFFECT_WIDGET.csv")]
        public string EFFECT_WIDGETcsv { get; set; }

        [JsonProperty("ELITEDUNGEON.csv")]
        public string ELITEDUNGEONcsv { get; set; }

        [JsonProperty("EVENTDATA.csv")]
        public string EVENTDATAcsv { get; set; }

        [JsonProperty("EVENT_CONTENTS.csv")]
        public string EVENT_CONTENTScsv { get; set; }

        [JsonProperty("EVENT_DROP.csv")]
        public string EVENT_DROPcsv { get; set; }

        [JsonProperty("EVENT_TIMELINE.csv")]
        public string EVENT_TIMELINEcsv { get; set; }

        [JsonProperty("EXPENSIVE_GROUP_SETTING.csv")]
        public string EXPENSIVE_GROUP_SETTINGcsv { get; set; }

        [JsonProperty("EXPENSIVE_ITEM_GROUP.csv")]
        public string EXPENSIVE_ITEM_GROUPcsv { get; set; }

        [JsonProperty("EXP_PENALTY.csv")]
        public string EXP_PENALTYcsv { get; set; }

        [JsonProperty("FAME_CATEGORY.csv")]
        public string FAME_CATEGORYcsv { get; set; }

        [JsonProperty("FAME_LEVEL.csv")]
        public string FAME_LEVELcsv { get; set; }

        [JsonProperty("FAME_QUEST.csv")]
        public string FAME_QUESTcsv { get; set; }

        [JsonProperty("GACHA_GROUP.csv")]
        public string GACHA_GROUPcsv { get; set; }

        [JsonProperty("GACHA_INFO.csv")]
        public string GACHA_INFOcsv { get; set; }

        [JsonProperty("GACHA_LIST.csv")]
        public string GACHA_LISTcsv { get; set; }

        [JsonProperty("GAMEOPTION_KEYSETTING.csv")]
        public string GAMEOPTION_KEYSETTINGcsv { get; set; }

        [JsonProperty("GAMEOPTION_SETTING.csv")]
        public string GAMEOPTION_SETTINGcsv { get; set; }

        [JsonProperty("GAME_DEFINE_OPTION.csv")]
        public string GAME_DEFINE_OPTIONcsv { get; set; }

        [JsonProperty("GENDATA_200501930_Goblin31.csv")]
        public string GENDATA_200501930_Goblin31csv { get; set; }

        [JsonProperty("GLOBAL_FONT_RANGE.csv")]
        public string GLOBAL_FONT_RANGEcsv { get; set; }

        [JsonProperty("GLOBAL_REGION.csv")]
        public string GLOBAL_REGIONcsv { get; set; }

        [JsonProperty("GREAT_BUILDING.csv")]
        public string GREAT_BUILDINGcsv { get; set; }

        [JsonProperty("GREAT_BUILDING_STATUS.csv")]
        public string GREAT_BUILDING_STATUScsv { get; set; }

        [JsonProperty("GREAT_BUILDING_STEP.csv")]
        public string GREAT_BUILDING_STEPcsv { get; set; }

        [JsonProperty("GUIDE_EFFECT.csv")]
        public string GUIDE_EFFECTcsv { get; set; }

        [JsonProperty("GUIDE_LINK.csv")]
        public string GUIDE_LINKcsv { get; set; }

        [JsonProperty("GUIDE_START.csv")]
        public string GUIDE_STARTcsv { get; set; }

        [JsonProperty("GUILD_AUTHORITY.csv")]
        public string GUILD_AUTHORITYcsv { get; set; }

        [JsonProperty("GUILD_CONTRIBUTION_GRADE.csv")]
        public string GUILD_CONTRIBUTION_GRADEcsv { get; set; }

        [JsonProperty("GUILD_COOP_MISSION.csv")]
        public string GUILD_COOP_MISSIONcsv { get; set; }

        [JsonProperty("GUILD_COOP_MISSION_GROUP.csv")]
        public string GUILD_COOP_MISSION_GROUPcsv { get; set; }

        [JsonProperty("GUILD_COOP_MISSION_GROUP_LIST.csv")]
        public string GUILD_COOP_MISSION_GROUP_LISTcsv { get; set; }

        [JsonProperty("GUILD_DAILY_MISSION.csv")]
        public string GUILD_DAILY_MISSIONcsv { get; set; }

        [JsonProperty("GUILD_DEV_LEVEL.csv")]
        public string GUILD_DEV_LEVELcsv { get; set; }

        [JsonProperty("GUILD_DEV_UI.csv")]
        public string GUILD_DEV_UIcsv { get; set; }

        [JsonProperty("GUILD_DEV_UNLOCK.csv")]
        public string GUILD_DEV_UNLOCKcsv { get; set; }

        [JsonProperty("GUILD_DOMINION.csv")]
        public string GUILD_DOMINIONcsv { get; set; }

        [JsonProperty("GUILD_DOMINION_BUFF.csv")]
        public string GUILD_DOMINION_BUFFcsv { get; set; }

        [JsonProperty("GUILD_DOMINION_EXCHANGE.csv")]
        public string GUILD_DOMINION_EXCHANGEcsv { get; set; }

        [JsonProperty("GUILD_DOMINION_PBS.csv")]
        public string GUILD_DOMINION_PBScsv { get; set; }

        [JsonProperty("GUILD_DOMINION_PK_GRADE.csv")]
        public string GUILD_DOMINION_PK_GRADEcsv { get; set; }

        [JsonProperty("GUILD_DOMINION_PRIZE.csv")]
        public string GUILD_DOMINION_PRIZEcsv { get; set; }

        [JsonProperty("GUILD_DOMINION_STROAGE_HISTORY.csv")]
        public string GUILD_DOMINION_STROAGE_HISTORYcsv { get; set; }

        [JsonProperty("GUILD_DONATION.csv")]
        public string GUILD_DONATIONcsv { get; set; }

        [JsonProperty("GUILD_EXPEDITION.csv")]
        public string GUILD_EXPEDITIONcsv { get; set; }

        [JsonProperty("GUILD_FAME_CATEGORY.csv")]
        public string GUILD_FAME_CATEGORYcsv { get; set; }

        [JsonProperty("GUILD_FAME_LEVEL.csv")]
        public string GUILD_FAME_LEVELcsv { get; set; }

        [JsonProperty("GUILD_GIFT.csv")]
        public string GUILD_GIFTcsv { get; set; }

        [JsonProperty("GUILD_GIFT_LEVEL.csv")]
        public string GUILD_GIFT_LEVELcsv { get; set; }

        [JsonProperty("GUILD_HISTORY.csv")]
        public string GUILD_HISTORYcsv { get; set; }

        [JsonProperty("GUILD_INFO.csv")]
        public string GUILD_INFOcsv { get; set; }

        [JsonProperty("GUILD_INSTANCE_DUNGEON_COST.csv")]
        public string GUILD_INSTANCE_DUNGEON_COSTcsv { get; set; }

        [JsonProperty("GUILD_LEVEL.csv")]
        public string GUILD_LEVELcsv { get; set; }

        [JsonProperty("GUILD_MARK.csv")]
        public string GUILD_MARKcsv { get; set; }

        [JsonProperty("GUILD_MEMBER_GRADE.csv")]
        public string GUILD_MEMBER_GRADEcsv { get; set; }

        [JsonProperty("GUILD_MONEY_EXCHANGE.csv")]
        public string GUILD_MONEY_EXCHANGEcsv { get; set; }

        [JsonProperty("GUILD_POINT.csv")]
        public string GUILD_POINTcsv { get; set; }

        [JsonProperty("GUILD_POSITION.csv")]
        public string GUILD_POSITIONcsv { get; set; }

        [JsonProperty("GUILD_SCORE.csv")]
        public string GUILD_SCOREcsv { get; set; }

        [JsonProperty("GUILD_SHOP.csv")]
        public string GUILD_SHOPcsv { get; set; }

        [JsonProperty("GUILD_STATUS.csv")]
        public string GUILD_STATUScsv { get; set; }

        [JsonProperty("GUILD_SUPPLY.csv")]
        public string GUILD_SUPPLYcsv { get; set; }

        [JsonProperty("GUILD_WANTED.csv")]
        public string GUILD_WANTEDcsv { get; set; }

        [JsonProperty("GUILD_WAR_COSTUME.csv")]
        public string GUILD_WAR_COSTUMEcsv { get; set; }

        [JsonProperty("GUILD_WAR_MONSTER.csv")]
        public string GUILD_WAR_MONSTERcsv { get; set; }

        [JsonProperty("GUILD_WAR_OBJECT.csv")]
        public string GUILD_WAR_OBJECTcsv { get; set; }

        [JsonProperty("GUILD_WAR_OCCUPATION.csv")]
        public string GUILD_WAR_OCCUPATIONcsv { get; set; }

        [JsonProperty("GUILD_WAR_OCCUPATION_RANKING.csv")]
        public string GUILD_WAR_OCCUPATION_RANKINGcsv { get; set; }

        [JsonProperty("GUILd_WAR_OCCUPATION_REWARD.csv")]
        public string GUILd_WAR_OCCUPATION_REWARDcsv { get; set; }

        [JsonProperty("GUILD_WAR_PLUNDER.csv")]
        public string GUILD_WAR_PLUNDERcsv { get; set; }

        [JsonProperty("GUILD_WAR_PLUNDER_REWARD.csv")]
        public string GUILD_WAR_PLUNDER_REWARDcsv { get; set; }

        [JsonProperty("GUILD_WAR_REVIVAL.csv")]
        public string GUILD_WAR_REVIVALcsv { get; set; }

        [JsonProperty("GUILD_WAR_SANCTUM.csv")]
        public string GUILD_WAR_SANCTUMcsv { get; set; }

        [JsonProperty("GUILD_WAR_SIEGE.csv")]
        public string GUILD_WAR_SIEGEcsv { get; set; }

        [JsonProperty("GUILD_WAR_SIEGE_REWARD.csv")]
        public string GUILD_WAR_SIEGE_REWARDcsv { get; set; }

        [JsonProperty("GUILD_WAR_STRONG_POINT.csv")]
        public string GUILD_WAR_STRONG_POINTcsv { get; set; }

        [JsonProperty("HIDDEN_PATH.csv")]
        public string HIDDEN_PATHcsv { get; set; }

        [JsonProperty("HOLYSTUFF.csv")]
        public string HOLYSTUFFcsv { get; set; }

        [JsonProperty("HOLYSTUFF_GRADE.csv")]
        public string HOLYSTUFF_GRADEcsv { get; set; }

        [JsonProperty("HOLYSTUFF_LEVEL.csv")]
        public string HOLYSTUFF_LEVELcsv { get; set; }

        [JsonProperty("HydraRefine_Fee.csv")]
        public string HydraRefine_Feecsv { get; set; }

        [JsonProperty("ICON.csv")]
        public string ICONcsv { get; set; }

        [JsonProperty("INSTANCE_DUNGEON_INFO.csv")]
        public string INSTANCE_DUNGEON_INFOcsv { get; set; }

        [JsonProperty("INSTANCE_DUNGEON_SETTING.csv")]
        public string INSTANCE_DUNGEON_SETTINGcsv { get; set; }

        [JsonProperty("INVENTORY.csv")]
        public string INVENTORYcsv { get; set; }

        [JsonProperty("INVENTORY_EXTEND.csv")]
        public string INVENTORY_EXTENDcsv { get; set; }

        [JsonProperty("INVENTORY_EXTEND_ITEM.csv")]
        public string INVENTORY_EXTEND_ITEMcsv { get; set; }

        [JsonProperty("INVENTORY_EXTEND_VALUE.csv")]
        public string INVENTORY_EXTEND_VALUEcsv { get; set; }

        [JsonProperty("INVENTORY_ORDER.csv")]
        public string INVENTORY_ORDERcsv { get; set; }

        [JsonProperty("ITEM.csv")]
        public string ITEMcsv { get; set; }

        [JsonProperty("ITEM_ATTRIBUTE.csv")]
        public string ITEM_ATTRIBUTEcsv { get; set; }

        [JsonProperty("ITEM_BLESS_INCREASERATE.csv")]
        public string ITEM_BLESS_INCREASERATEcsv { get; set; }

        [JsonProperty("ITEM_COLLECTION.csv")]
        public string ITEM_COLLECTIONcsv { get; set; }

        [JsonProperty("ITEM_DISPLAY.csv")]
        public string ITEM_DISPLAYcsv { get; set; }

        [JsonProperty("ITEM_DURABILITY_BROKENLV.csv")]
        public string ITEM_DURABILITY_BROKENLVcsv { get; set; }

        [JsonProperty("ITEM_DURABILITY_REPAIRCOST.csv")]
        public string ITEM_DURABILITY_REPAIRCOSTcsv { get; set; }

        [JsonProperty("ITEM_EQUIPSLOT.csv")]
        public string ITEM_EQUIPSLOTcsv { get; set; }

        [JsonProperty("ITEM_EXTEND.csv")]
        public string ITEM_EXTENDcsv { get; set; }

        [JsonProperty("ITEM_GETWAY.csv")]
        public string ITEM_GETWAYcsv { get; set; }

        [JsonProperty("ITEM_GETWAY_INFO.csv")]
        public string ITEM_GETWAY_INFOcsv { get; set; }

        [JsonProperty("ITEM_GETWAY_LIST.csv")]
        public string ITEM_GETWAY_LISTcsv { get; set; }

        [JsonProperty("ITEM_INFO_SUMMARY.csv")]
        public string ITEM_INFO_SUMMARYcsv { get; set; }

        [JsonProperty("ITEM_JEWEL_COMPOSE.csv")]
        public string ITEM_JEWEL_COMPOSEcsv { get; set; }

        [JsonProperty("ITEM_JEWEL_COMPOSE_RESULT.csv")]
        public string ITEM_JEWEL_COMPOSE_RESULTcsv { get; set; }

        [JsonProperty("ITEM_JEWEL_PROBABILITY.csv")]
        public string ITEM_JEWEL_PROBABILITYcsv { get; set; }

        [JsonProperty("ITEM_JEWEL_SLOTCOLOR.csv")]
        public string ITEM_JEWEL_SLOTCOLORcsv { get; set; }

        [JsonProperty("ITEM_JEWEL_TIER.csv")]
        public string ITEM_JEWEL_TIERcsv { get; set; }

        [JsonProperty("ITEM_MAGICSTONE_TRANCE.csv")]
        public string ITEM_MAGICSTONE_TRANCEcsv { get; set; }

        [JsonProperty("ITEM_MAKE.csv")]
        public string ITEM_MAKEcsv { get; set; }

        [JsonProperty("ITEM_MATERIAL_COMPOSE.csv")]
        public string ITEM_MATERIAL_COMPOSEcsv { get; set; }

        [JsonProperty("ITEM_MATERIAL_COMPOSE_LIST.csv")]
        public string ITEM_MATERIAL_COMPOSE_LISTcsv { get; set; }

        [JsonProperty("ITEM_MATERIAL_COMPOSE_POINT.csv")]
        public string ITEM_MATERIAL_COMPOSE_POINTcsv { get; set; }

        [JsonProperty("ITEM_MYSTICALPIECE_TRANCE.csv")]
        public string ITEM_MYSTICALPIECE_TRANCEcsv { get; set; }

        [JsonProperty("ITEM_OPTION.csv")]
        public string ITEM_OPTIONcsv { get; set; }

        [JsonProperty("ITEM_OPTION_GRADE.csv")]
        public string ITEM_OPTION_GRADEcsv { get; set; }

        [JsonProperty("ITEM_OPTION_PASSIVE.csv")]
        public string ITEM_OPTION_PASSIVEcsv { get; set; }

        [JsonProperty("ITEM_OPTION_RANDOM.csv")]
        public string ITEM_OPTION_RANDOMcsv { get; set; }

        [JsonProperty("ITEM_PACKAGE.csv")]
        public string ITEM_PACKAGEcsv { get; set; }

        [JsonProperty("ITEM_PROVIDE.csv")]
        public string ITEM_PROVIDEcsv { get; set; }

        [JsonProperty("ITEM_RANDOM_EXCHANGE.csv")]
        public string ITEM_RANDOM_EXCHANGEcsv { get; set; }

        [JsonProperty("ITEM_RANDOM_EXCHANGE_EQUIP.csv")]
        public string ITEM_RANDOM_EXCHANGE_EQUIPcsv { get; set; }

        [JsonProperty("ITEM_RANDOM_GET.csv")]
        public string ITEM_RANDOM_GETcsv { get; set; }

        [JsonProperty("ITEM_RANDOM_GET_INFO.csv")]
        public string ITEM_RANDOM_GET_INFOcsv { get; set; }

        [JsonProperty("ITEM_SET.csv")]
        public string ITEM_SETcsv { get; set; }

        [JsonProperty("ITEM_SMELTING.csv")]
        public string ITEM_SMELTINGcsv { get; set; }

        [JsonProperty("ITEM_SMELTING_ATTRIBUTE.csv")]
        public string ITEM_SMELTING_ATTRIBUTEcsv { get; set; }

        [JsonProperty("ITEM_SMELTING_EFFECT.csv")]
        public string ITEM_SMELTING_EFFECTcsv { get; set; }

        [JsonProperty("ITEM_SMELTING_RATE.csv")]
        public string ITEM_SMELTING_RATEcsv { get; set; }

        [JsonProperty("ITEM_SP_TREASURE_TRANCE.csv")]
        public string ITEM_SP_TREASURE_TRANCEcsv { get; set; }

        [JsonProperty("ITEM_SUBCOOLTIME.csv")]
        public string ITEM_SUBCOOLTIMEcsv { get; set; }

        [JsonProperty("ITEM_TRANSCENDENCE_DEFINE.csv")]
        public string ITEM_TRANSCENDENCE_DEFINEcsv { get; set; }

        [JsonProperty("ITEM_TYPE.csv")]
        public string ITEM_TYPEcsv { get; set; }

        [JsonProperty("ITEM_UNSEALING.csv")]
        public string ITEM_UNSEALINGcsv { get; set; }

        [JsonProperty("ITEM_UNSEALING_ACCELERATION.csv")]
        public string ITEM_UNSEALING_ACCELERATIONcsv { get; set; }

        [JsonProperty("ITEM_VIEWER.csv")]
        public string ITEM_VIEWERcsv { get; set; }

        [JsonProperty("ITEM_XDRACO_MAKE.csv")]
        public string ITEM_XDRACO_MAKEcsv { get; set; }

        [JsonProperty("ITEM_XDRACO_SEALING.csv")]
        public string ITEM_XDRACO_SEALINGcsv { get; set; }

        [JsonProperty("LABYRINTH.csv")]
        public string LABYRINTHcsv { get; set; }

        [JsonProperty("LEVEL.csv")]
        public string LEVELcsv { get; set; }

        [JsonProperty("LOADING.csv")]
        public string LOADINGcsv { get; set; }

        [JsonProperty("MAGICSQUARE.csv")]
        public string MAGICSQUAREcsv { get; set; }

        [JsonProperty("MAGICSQUARESTAGE.csv")]
        public string MAGICSQUARESTAGEcsv { get; set; }

        [JsonProperty("MAIL_PRESET.csv")]
        public string MAIL_PRESETcsv { get; set; }

        [JsonProperty("MAPUI_AREA.csv")]
        public string MAPUI_AREAcsv { get; set; }

        [JsonProperty("MAPUI_MINI.csv")]
        public string MAPUI_MINIcsv { get; set; }

        [JsonProperty("MAPUI_WORLD.csv")]
        public string MAPUI_WORLDcsv { get; set; }

        [JsonProperty("MAS_DEFAULTSETTING.csv")]
        public string MAS_DEFAULTSETTINGcsv { get; set; }

        [JsonProperty("MAS_PLAYLOG.csv")]
        public string MAS_PLAYLOGcsv { get; set; }

        [JsonProperty("MONEY.csv")]
        public string MONEYcsv { get; set; }

        [JsonProperty("MONSTER.csv")]
        public string MONSTERcsv { get; set; }

        [JsonProperty("MONSTER_1.csv")]
        public string MONSTER_1csv { get; set; }

        [JsonProperty("MONSTER_2.csv")]
        public string MONSTER_2csv { get; set; }

        [JsonProperty("MONSTER_AI.csv")]
        public string MONSTER_AIcsv { get; set; }

        [JsonProperty("MONSTER_ColorGroup.csv")]
        public string MONSTER_ColorGroupcsv { get; set; }

        [JsonProperty("MONSTER_COLOR_GROUP.csv")]
        public string MONSTER_COLOR_GROUPcsv { get; set; }

        [JsonProperty("MONSTER_FSM.csv")]
        public string MONSTER_FSMcsv { get; set; }

        [JsonProperty("MONSTER_PHASING.csv")]
        public string MONSTER_PHASINGcsv { get; set; }

        [JsonProperty("MONSTER_RAREACTION.csv")]
        public string MONSTER_RAREACTIONcsv { get; set; }

        [JsonProperty("MONSTER_RESOURCE.csv")]
        public string MONSTER_RESOURCEcsv { get; set; }

        [JsonProperty("MONTAGE.csv")]
        public string MONTAGEcsv { get; set; }

        [JsonProperty("MOVIEPLAY.csv")]
        public string MOVIEPLAYcsv { get; set; }

        [JsonProperty("MULTI_LANGUAGE.csv")]
        public string MULTI_LANGUAGEcsv { get; set; }

        [JsonProperty("NAVIMESH.csv")]
        public string NAVIMESHcsv { get; set; }

        [JsonProperty("NICKNAME.csv")]
        public string NICKNAMEcsv { get; set; }

        [JsonProperty("NPC.csv")]
        public string NPCcsv { get; set; }

        [JsonProperty("NPCDIALOG.csv")]
        public string NPCDIALOGcsv { get; set; }

        [JsonProperty("NPCSHOWSCHEDULE.csv")]
        public string NPCSHOWSCHEDULEcsv { get; set; }

        [JsonProperty("NPCSPAWN.csv")]
        public string NPCSPAWNcsv { get; set; }

        [JsonProperty("NPC_ITEM_LIST.csv")]
        public string NPC_ITEM_LISTcsv { get; set; }

        [JsonProperty("NPC_ITEM_MAKE_LIST.csv")]
        public string NPC_ITEM_MAKE_LISTcsv { get; set; }

        [JsonProperty("NPC_SHOP_GOODS.csv")]
        public string NPC_SHOP_GOODScsv { get; set; }

        [JsonProperty("NPC_SHOP_LIST.csv")]
        public string NPC_SHOP_LISTcsv { get; set; }

        [JsonProperty("OBJECT.csv")]
        public string OBJECTcsv { get; set; }

        [JsonProperty("OBJECT_INTERACTION_MON_GEN.csv")]
        public string OBJECT_INTERACTION_MON_GENcsv { get; set; }

        [JsonProperty("PET.csv")]
        public string PETcsv { get; set; }

        [JsonProperty("PET_DECK.csv")]
        public string PET_DECKcsv { get; set; }

        [JsonProperty("PET_EQUIPINFO.csv")]
        public string PET_EQUIPINFOcsv { get; set; }

        [JsonProperty("PET_LEVEL.csv")]
        public string PET_LEVELcsv { get; set; }

        [JsonProperty("PET_SKILL.csv")]
        public string PET_SKILLcsv { get; set; }

        [JsonProperty("PHASING.csv")]
        public string PHASINGcsv { get; set; }

        [JsonProperty("PK_GRADE.csv")]
        public string PK_GRADEcsv { get; set; }

        [JsonProperty("PK_MODE.csv")]
        public string PK_MODEcsv { get; set; }

        [JsonProperty("PK_SCORE.csv")]
        public string PK_SCOREcsv { get; set; }

        [JsonProperty("PK_STEAL.csv")]
        public string PK_STEALcsv { get; set; }

        [JsonProperty("PK_SYSTEM.csv")]
        public string PK_SYSTEMcsv { get; set; }

        [JsonProperty("PLAYDATA.csv")]
        public string PLAYDATAcsv { get; set; }

        [JsonProperty("PORTAL.csv")]
        public string PORTALcsv { get; set; }

        [JsonProperty("QUESTDAILY_BASE.csv")]
        public string QUESTDAILY_BASEcsv { get; set; }

        [JsonProperty("QUESTDAILY_GROUP.csv")]
        public string QUESTDAILY_GROUPcsv { get; set; }

        [JsonProperty("QUESTDAILY_HOMEWORK.csv")]
        public string QUESTDAILY_HOMEWORKcsv { get; set; }

        [JsonProperty("QUESTDAILY_HOMEWORK_PLUSREWARD.csv")]
        public string QUESTDAILY_HOMEWORK_PLUSREWARDcsv { get; set; }

        [JsonProperty("QUESTDAILY_INCREASE.csv")]
        public string QUESTDAILY_INCREASEcsv { get; set; }

        [JsonProperty("QUESTDAILY_PLUSREWARD.csv")]
        public string QUESTDAILY_PLUSREWARDcsv { get; set; }

        [JsonProperty("QUESTOPEN_CONDITION.csv")]
        public string QUESTOPEN_CONDITIONcsv { get; set; }

        [JsonProperty("QUESTWEEKLY_BASE.csv")]
        public string QUESTWEEKLY_BASEcsv { get; set; }

        [JsonProperty("QUESTWEEKLY_GROUP.csv")]
        public string QUESTWEEKLY_GROUPcsv { get; set; }

        [JsonProperty("QUESTWEEKLY_PLUSREWARD.csv")]
        public string QUESTWEEKLY_PLUSREWARDcsv { get; set; }

        [JsonProperty("QUEST_001.csv")]
        public string QUEST_001csv { get; set; }

        [JsonProperty("QUEST_002.csv")]
        public string QUEST_002csv { get; set; }

        [JsonProperty("QUEST_011.csv")]
        public string QUEST_011csv { get; set; }

        [JsonProperty("QUEST_012.csv")]
        public string QUEST_012csv { get; set; }

        [JsonProperty("QUEST_013.csv")]
        public string QUEST_013csv { get; set; }

        [JsonProperty("QUEST_021.csv")]
        public string QUEST_021csv { get; set; }

        [JsonProperty("QUEST_022.csv")]
        public string QUEST_022csv { get; set; }

        [JsonProperty("QUEST_031.csv")]
        public string QUEST_031csv { get; set; }

        [JsonProperty("QUEST_041.csv")]
        public string QUEST_041csv { get; set; }

        [JsonProperty("QUEST_042.csv")]
        public string QUEST_042csv { get; set; }

        [JsonProperty("QUEST_051.csv")]
        public string QUEST_051csv { get; set; }

        [JsonProperty("QUEST_052.csv")]
        public string QUEST_052csv { get; set; }

        [JsonProperty("QUEST_061.csv")]
        public string QUEST_061csv { get; set; }

        [JsonProperty("QUEST_071.csv")]
        public string QUEST_071csv { get; set; }

        [JsonProperty("QUEST_081.csv")]
        public string QUEST_081csv { get; set; }

        [JsonProperty("QUEST_091.csv")]
        public string QUEST_091csv { get; set; }

        [JsonProperty("QUEST_092.csv")]
        public string QUEST_092csv { get; set; }

        [JsonProperty("QUEST_COMBAT_DEVIATION.csv")]
        public string QUEST_COMBAT_DEVIATIONcsv { get; set; }

        [JsonProperty("QUEST_DROP_ITEM.csv")]
        public string QUEST_DROP_ITEMcsv { get; set; }

        [JsonProperty("QUEST_LIST.csv")]
        public string QUEST_LISTcsv { get; set; }

        [JsonProperty("QUEST_MISSION.csv")]
        public string QUEST_MISSIONcsv { get; set; }

        [JsonProperty("QUEST_RELATION.csv")]
        public string QUEST_RELATIONcsv { get; set; }

        [JsonProperty("QUEST_RELATION_REWARD.csv")]
        public string QUEST_RELATION_REWARDcsv { get; set; }

        [JsonProperty("QUEST_REQUEST.csv")]
        public string QUEST_REQUESTcsv { get; set; }

        [JsonProperty("QUEST_TAG_SET.csv")]
        public string QUEST_TAG_SETcsv { get; set; }

        [JsonProperty("QUEUE_UI.csv")]
        public string QUEUE_UIcsv { get; set; }

        [JsonProperty("QUICK_SLOT_SETTING.csv")]
        public string QUICK_SLOT_SETTINGcsv { get; set; }

        [JsonProperty("RANKING_CATEGORY.csv")]
        public string RANKING_CATEGORYcsv { get; set; }

        [JsonProperty("RANKING_REWARD.csv")]
        public string RANKING_REWARDcsv { get; set; }

        [JsonProperty("RANKING_SEASON_REWARD.csv")]
        public string RANKING_SEASON_REWARDcsv { get; set; }

        [JsonProperty("RESOURCE_ABP.csv")]
        public string RESOURCE_ABPcsv { get; set; }

        [JsonProperty("RESOURCE_ETC.csv")]
        public string RESOURCE_ETCcsv { get; set; }

        [JsonProperty("RESOURCE_MESH.csv")]
        public string RESOURCE_MESHcsv { get; set; }

        [JsonProperty("revision.csv")]
        public string revisioncsv { get; set; }

        [JsonProperty("REVIVAL.csv")]
        public string REVIVALcsv { get; set; }

        [JsonProperty("SCHEDULERCYCLE.csv")]
        public string SCHEDULERCYCLEcsv { get; set; }

        [JsonProperty("SCHEDULERCYCLE_Local.csv")]
        public string SCHEDULERCYCLE_Localcsv { get; set; }

        [JsonProperty("SECRET_DUNGEON.csv")]
        public string SECRET_DUNGEONcsv { get; set; }

        [JsonProperty("SEQUENCEPLAY.csv")]
        public string SEQUENCEPLAYcsv { get; set; }

        [JsonProperty("SEQUENCE_DIALOGUE.csv")]
        public string SEQUENCE_DIALOGUEcsv { get; set; }

        [JsonProperty("SERVER_CHANGE_CONDITION.csv")]
        public string SERVER_CHANGE_CONDITIONcsv { get; set; }

        [JsonProperty("SERVER_CHANGE_COST.csv")]
        public string SERVER_CHANGE_COSTcsv { get; set; }

        [JsonProperty("SERVER_CHANGE_UI.csv")]
        public string SERVER_CHANGE_UIcsv { get; set; }

        [JsonProperty("Sheet1.csv")]
        public string Sheet1csv { get; set; }

        [JsonProperty("SHOP.csv")]
        public string SHOPcsv { get; set; }

        [JsonProperty("SHOP_GOODS.csv")]
        public string SHOP_GOODScsv { get; set; }

        [JsonProperty("SHOP_ITEM.csv")]
        public string SHOP_ITEMcsv { get; set; }

        [JsonProperty("SHOP_LIST.csv")]
        public string SHOP_LISTcsv { get; set; }

        [JsonProperty("SHOP_UI.csv")]
        public string SHOP_UIcsv { get; set; }

        [JsonProperty("SHOP_UI_SELLGROUP.csv")]
        public string SHOP_UI_SELLGROUPcsv { get; set; }

        [JsonProperty("SKILL.csv")]
        public string SKILLcsv { get; set; }

        [JsonProperty("SKILL_ATTACK.csv")]
        public string SKILL_ATTACKcsv { get; set; }

        [JsonProperty("SKILL_COST.csv")]
        public string SKILL_COSTcsv { get; set; }

        [JsonProperty("SKILL_PASSIVE.csv")]
        public string SKILL_PASSIVEcsv { get; set; }

        [JsonProperty("SKILL_SPECIAL_ABILITY.csv")]
        public string SKILL_SPECIAL_ABILITYcsv { get; set; }

        [JsonProperty("SKILL_STATE.csv")]
        public string SKILL_STATEcsv { get; set; }

        [JsonProperty("SLANG.csv")]
        public string SLANGcsv { get; set; }

        [JsonProperty("SLANG_CHATTING.csv")]
        public string SLANG_CHATTINGcsv { get; set; }

        [JsonProperty("SLANG_NICKNAME.csv")]
        public string SLANG_NICKNAMEcsv { get; set; }

        [JsonProperty("SLANG_SPECIAL.csv")]
        public string SLANG_SPECIALcsv { get; set; }

        [JsonProperty("SLANG_WORD.csv")]
        public string SLANG_WORDcsv { get; set; }

        [JsonProperty("SMALLTALK_DIALOGUE.csv")]
        public string SMALLTALK_DIALOGUEcsv { get; set; }

        [JsonProperty("SMALLTALK_SETTING.csv")]
        public string SMALLTALK_SETTINGcsv { get; set; }

        [JsonProperty("SOUND.csv")]
        public string SOUNDcsv { get; set; }

        [JsonProperty("STAGE.csv")]
        public string STAGEcsv { get; set; }

        [JsonProperty("STAGE_MON_GEN.csv")]
        public string STAGE_MON_GENcsv { get; set; }

        [JsonProperty("STAGE_MON_GEN_EVENT.csv")]
        public string STAGE_MON_GEN_EVENTcsv { get; set; }

        [JsonProperty("STAGE_SECTOR.csv")]
        public string STAGE_SECTORcsv { get; set; }

        [JsonProperty("STATUS.csv")]
        public string STATUScsv { get; set; }

        [JsonProperty("STATUS_CALCULATE.csv")]
        public string STATUS_CALCULATEcsv { get; set; }

        [JsonProperty("STATUS_INFO.csv")]
        public string STATUS_INFOcsv { get; set; }

        [JsonProperty("STATUS_LIMIT.csv")]
        public string STATUS_LIMITcsv { get; set; }

        [JsonProperty("STD.csv")]
        public string STDcsv { get; set; }

        [JsonProperty("STRING_BUILTIN.csv")]
        public string STRING_BUILTINcsv { get; set; }

        [JsonProperty("STRING_ERROR.csv")]
        public string STRING_ERRORcsv { get; set; }

        [JsonProperty("STRING_MAIL.csv")]
        public string STRING_MAILcsv { get; set; }

        [JsonProperty("STRING_MAIL_CHS.csv")]
        public string STRING_MAIL_CHScsv { get; set; }

        [JsonProperty("STRING_MAIL_CHT.csv")]
        public string STRING_MAIL_CHTcsv { get; set; }

        [JsonProperty("STRING_MAIL_ENG.csv")]
        public string STRING_MAIL_ENGcsv { get; set; }

        [JsonProperty("STRING_MAIL_GER.csv")]
        public string STRING_MAIL_GERcsv { get; set; }

        [JsonProperty("STRING_MAIL_IND.csv")]
        public string STRING_MAIL_INDcsv { get; set; }

        [JsonProperty("STRING_MAIL_JPN.csv")]
        public string STRING_MAIL_JPNcsv { get; set; }

        [JsonProperty("STRING_MAIL_KOR.csv")]
        public string STRING_MAIL_KORcsv { get; set; }

        [JsonProperty("STRING_MAIL_POR.csv")]
        public string STRING_MAIL_PORcsv { get; set; }

        [JsonProperty("STRING_MAIL_RUS.csv")]
        public string STRING_MAIL_RUScsv { get; set; }

        [JsonProperty("STRING_MAIL_SPA.csv")]
        public string STRING_MAIL_SPAcsv { get; set; }

        [JsonProperty("STRING_MAIL_THA.csv")]
        public string STRING_MAIL_THAcsv { get; set; }

        [JsonProperty("STRING_MAIL_VIE.csv")]
        public string STRING_MAIL_VIEcsv { get; set; }

        [JsonProperty("STRING_MESSAGE.csv")]
        public string STRING_MESSAGEcsv { get; set; }

        [JsonProperty("STRING_MESSAGE_CHS.csv")]
        public string STRING_MESSAGE_CHScsv { get; set; }

        [JsonProperty("STRING_MESSAGE_CHT.csv")]
        public string STRING_MESSAGE_CHTcsv { get; set; }

        [JsonProperty("STRING_MESSAGE_ENG.csv")]
        public string STRING_MESSAGE_ENGcsv { get; set; }

        [JsonProperty("STRING_MESSAGE_GER.csv")]
        public string STRING_MESSAGE_GERcsv { get; set; }

        [JsonProperty("STRING_MESSAGE_IND.csv")]
        public string STRING_MESSAGE_INDcsv { get; set; }

        [JsonProperty("STRING_MESSAGE_JPN.csv")]
        public string STRING_MESSAGE_JPNcsv { get; set; }

        [JsonProperty("STRING_MESSAGE_KOR.csv")]
        public string STRING_MESSAGE_KORcsv { get; set; }

        [JsonProperty("STRING_MESSAGE_POR.csv")]
        public string STRING_MESSAGE_PORcsv { get; set; }

        [JsonProperty("STRING_MESSAGE_RUS.csv")]
        public string STRING_MESSAGE_RUScsv { get; set; }

        [JsonProperty("STRING_MESSAGE_SPA.csv")]
        public string STRING_MESSAGE_SPAcsv { get; set; }

        [JsonProperty("STRING_MESSAGE_THA.csv")]
        public string STRING_MESSAGE_THAcsv { get; set; }

        [JsonProperty("STRING_MESSAGE_VIE.csv")]
        public string STRING_MESSAGE_VIEcsv { get; set; }

        [JsonProperty("STRING_NPC.csv")]
        public string STRING_NPCcsv { get; set; }

        [JsonProperty("STRING_NPC_CHS.csv")]
        public string STRING_NPC_CHScsv { get; set; }

        [JsonProperty("STRING_NPC_CHT.csv")]
        public string STRING_NPC_CHTcsv { get; set; }

        [JsonProperty("STRING_NPC_ENG.csv")]
        public string STRING_NPC_ENGcsv { get; set; }

        [JsonProperty("STRING_NPC_GER.csv")]
        public string STRING_NPC_GERcsv { get; set; }

        [JsonProperty("STRING_NPC_IND.csv")]
        public string STRING_NPC_INDcsv { get; set; }

        [JsonProperty("STRING_NPC_JPN.csv")]
        public string STRING_NPC_JPNcsv { get; set; }

        [JsonProperty("STRING_NPC_KOR.csv")]
        public string STRING_NPC_KORcsv { get; set; }

        [JsonProperty("STRING_NPC_POR.csv")]
        public string STRING_NPC_PORcsv { get; set; }

        [JsonProperty("STRING_NPC_RUS.csv")]
        public string STRING_NPC_RUScsv { get; set; }

        [JsonProperty("STRING_NPC_SPA.csv")]
        public string STRING_NPC_SPAcsv { get; set; }

        [JsonProperty("STRING_NPC_THA.csv")]
        public string STRING_NPC_THAcsv { get; set; }

        [JsonProperty("STRING_NPC_VIE.csv")]
        public string STRING_NPC_VIEcsv { get; set; }

        [JsonProperty("STRING_QUESTTEMPLATE.csv")]
        public string STRING_QUESTTEMPLATEcsv { get; set; }

        [JsonProperty("STRING_QUESTTEMPLATE_CHS.csv")]
        public string STRING_QUESTTEMPLATE_CHScsv { get; set; }

        [JsonProperty("STRING_QUESTTEMPLATE_CHT.csv")]
        public string STRING_QUESTTEMPLATE_CHTcsv { get; set; }

        [JsonProperty("STRING_QUESTTEMPLATE_ENG.csv")]
        public string STRING_QUESTTEMPLATE_ENGcsv { get; set; }

        [JsonProperty("STRING_QUESTTEMPLATE_GER.csv")]
        public string STRING_QUESTTEMPLATE_GERcsv { get; set; }

        [JsonProperty("STRING_QUESTTEMPLATE_IND.csv")]
        public string STRING_QUESTTEMPLATE_INDcsv { get; set; }

        [JsonProperty("STRING_QUESTTEMPLATE_JPN.csv")]
        public string STRING_QUESTTEMPLATE_JPNcsv { get; set; }

        [JsonProperty("STRING_QUESTTEMPLATE_KOR.csv")]
        public string STRING_QUESTTEMPLATE_KORcsv { get; set; }

        [JsonProperty("STRING_QUESTTEMPLATE_POR.csv")]
        public string STRING_QUESTTEMPLATE_PORcsv { get; set; }

        [JsonProperty("STRING_QUESTTEMPLATE_RUS.csv")]
        public string STRING_QUESTTEMPLATE_RUScsv { get; set; }

        [JsonProperty("STRING_QUESTTEMPLATE_SPA.csv")]
        public string STRING_QUESTTEMPLATE_SPAcsv { get; set; }

        [JsonProperty("STRING_QUESTTEMPLATE_THA.csv")]
        public string STRING_QUESTTEMPLATE_THAcsv { get; set; }

        [JsonProperty("STRING_QUESTTEMPLATE_VIE.csv")]
        public string STRING_QUESTTEMPLATE_VIEcsv { get; set; }

        [JsonProperty("STRING_TEMPLATE.csv")]
        public string STRING_TEMPLATEcsv { get; set; }

        [JsonProperty("STRING_TEMPLATE_CHS.csv")]
        public string STRING_TEMPLATE_CHScsv { get; set; }

        [JsonProperty("STRING_TEMPLATE_CHT.csv")]
        public string STRING_TEMPLATE_CHTcsv { get; set; }

        [JsonProperty("STRING_TEMPLATE_ENG.csv")]
        public string STRING_TEMPLATE_ENGcsv { get; set; }

        [JsonProperty("STRING_TEMPLATE_GER.csv")]
        public string STRING_TEMPLATE_GERcsv { get; set; }

        [JsonProperty("STRING_TEMPLATE_IND.csv")]
        public string STRING_TEMPLATE_INDcsv { get; set; }

        [JsonProperty("STRING_TEMPLATE_JPN.csv")]
        public string STRING_TEMPLATE_JPNcsv { get; set; }

        [JsonProperty("STRING_TEMPLATE_KOR.csv")]
        public string STRING_TEMPLATE_KORcsv { get; set; }

        [JsonProperty("STRING_TEMPLATE_POR.csv")]
        public string STRING_TEMPLATE_PORcsv { get; set; }

        [JsonProperty("STRING_TEMPLATE_RUS.csv")]
        public string STRING_TEMPLATE_RUScsv { get; set; }

        [JsonProperty("STRING_TEMPLATE_SPA.csv")]
        public string STRING_TEMPLATE_SPAcsv { get; set; }

        [JsonProperty("STRING_TEMPLATE_THA.csv")]
        public string STRING_TEMPLATE_THAcsv { get; set; }

        [JsonProperty("STRING_TEMPLATE_VIE.csv")]
        public string STRING_TEMPLATE_VIEcsv { get; set; }

        [JsonProperty("STRING_TOOLTIP.csv")]
        public string STRING_TOOLTIPcsv { get; set; }

        [JsonProperty("STRING_TOOLTIP_CHS.csv")]
        public string STRING_TOOLTIP_CHScsv { get; set; }

        [JsonProperty("STRING_TOOLTIP_CHT.csv")]
        public string STRING_TOOLTIP_CHTcsv { get; set; }

        [JsonProperty("STRING_TOOLTIP_ENG.csv")]
        public string STRING_TOOLTIP_ENGcsv { get; set; }

        [JsonProperty("STRING_TOOLTIP_GER.csv")]
        public string STRING_TOOLTIP_GERcsv { get; set; }

        [JsonProperty("STRING_TOOLTIP_IND.csv")]
        public string STRING_TOOLTIP_INDcsv { get; set; }

        [JsonProperty("STRING_TOOLTIP_JPN.csv")]
        public string STRING_TOOLTIP_JPNcsv { get; set; }

        [JsonProperty("STRING_TOOLTIP_KOR.csv")]
        public string STRING_TOOLTIP_KORcsv { get; set; }

        [JsonProperty("STRING_TOOLTIP_POR.csv")]
        public string STRING_TOOLTIP_PORcsv { get; set; }

        [JsonProperty("STRING_TOOLTIP_RUS.csv")]
        public string STRING_TOOLTIP_RUScsv { get; set; }

        [JsonProperty("STRING_TOOLTIP_SPA.csv")]
        public string STRING_TOOLTIP_SPAcsv { get; set; }

        [JsonProperty("STRING_TOOLTIP_THA.csv")]
        public string STRING_TOOLTIP_THAcsv { get; set; }

        [JsonProperty("STRING_TOOLTIP_VIE.csv")]
        public string STRING_TOOLTIP_VIEcsv { get; set; }

        [JsonProperty("SUMMON.csv")]
        public string SUMMONcsv { get; set; }

        [JsonProperty("SUMMON_GROUP.csv")]
        public string SUMMON_GROUPcsv { get; set; }

        [JsonProperty("SUMMON_INFO.csv")]
        public string SUMMON_INFOcsv { get; set; }

        [JsonProperty("SYSTEM_DATA.csv")]
        public string SYSTEM_DATAcsv { get; set; }

        [JsonProperty("SYSTEM_DATA_CONQUER_SERVER.csv")]
        public string SYSTEM_DATA_CONQUER_SERVERcsv { get; set; }

        [JsonProperty("TIMETICKET.csv")]
        public string TIMETICKETcsv { get; set; }

        [JsonProperty("TIME_DEFINE.csv")]
        public string TIME_DEFINEcsv { get; set; }

        [JsonProperty("TOTAL_MENU.csv")]
        public string TOTAL_MENUcsv { get; set; }

        [JsonProperty("TOTAL_MENU_CONTENTS.csv")]
        public string TOTAL_MENU_CONTENTScsv { get; set; }

        [JsonProperty("TOTAL_MENU_FRAME.csv")]
        public string TOTAL_MENU_FRAMEcsv { get; set; }

        [JsonProperty("TOTEM.csv")]
        public string TOTEMcsv { get; set; }

        [JsonProperty("TRADE_INSPECTION.csv")]
        public string TRADE_INSPECTIONcsv { get; set; }

        [JsonProperty("TRADE_MENU.csv")]
        public string TRADE_MENUcsv { get; set; }

        [JsonProperty("TRIGGER_GROUPBASE.csv")]
        public string TRIGGER_GROUPBASEcsv { get; set; }

        [JsonProperty("TUTORIAL.csv")]
        public string TUTORIALcsv { get; set; }

        [JsonProperty("UI_SHOP_GOODS.csv")]
        public string UI_SHOP_GOODScsv { get; set; }

        [JsonProperty("UI_SHOP_IAP_INFO.csv")]
        public string UI_SHOP_IAP_INFOcsv { get; set; }

        [JsonProperty("UI_SHOP_ITEM_PACKAGE.csv")]
        public string UI_SHOP_ITEM_PACKAGEcsv { get; set; }

        [JsonProperty("UI_SHOP_PERIOD.csv")]
        public string UI_SHOP_PERIODcsv { get; set; }

        [JsonProperty("UI_SHOP_TAP.csv")]
        public string UI_SHOP_TAPcsv { get; set; }

        [JsonProperty("UNDERWORLD.csv")]
        public string UNDERWORLDcsv { get; set; }

        [JsonProperty("USEREVENT_BENEDICTION.csv")]
        public string USEREVENT_BENEDICTIONcsv { get; set; }

        [JsonProperty("USER_EVENT.csv")]
        public string USER_EVENTcsv { get; set; }

        [JsonProperty("USER_EVENT_GOAL.csv")]
        public string USER_EVENT_GOALcsv { get; set; }

        [JsonProperty("USER_EVENT_PAINTING.csv")]
        public string USER_EVENT_PAINTINGcsv { get; set; }

        [JsonProperty("USER_EVENT_REPEAT.csv")]
        public string USER_EVENT_REPEATcsv { get; set; }

        [JsonProperty("USER_EVENT_SIEGEEVE.csv")]
        public string USER_EVENT_SIEGEEVEcsv { get; set; }

        [JsonProperty("VEHICLE.csv")]
        public string VEHICLEcsv { get; set; }

        [JsonProperty("VEHICLE_RIDE.csv")]
        public string VEHICLE_RIDEcsv { get; set; }

        [JsonProperty("WARP_LOCATION.csv")]
        public string WARP_LOCATIONcsv { get; set; }

        [JsonProperty("WAYPOINT.csv")]
        public string WAYPOINTcsv { get; set; }

        [JsonProperty("SECTOR_GRADE_10010.csv")]
        public string SECTOR_GRADE_10010csv { get; set; }

        [JsonProperty("SECTOR_GRADE_10011.csv")]
        public string SECTOR_GRADE_10011csv { get; set; }

        [JsonProperty("SECTOR_GRADE_10012.csv")]
        public string SECTOR_GRADE_10012csv { get; set; }

        [JsonProperty("SECTOR_GRADE_10013.csv")]
        public string SECTOR_GRADE_10013csv { get; set; }

        [JsonProperty("SECTOR_GRADE_10020.csv")]
        public string SECTOR_GRADE_10020csv { get; set; }

        [JsonProperty("SECTOR_GRADE_10021.csv")]
        public string SECTOR_GRADE_10021csv { get; set; }

        [JsonProperty("SECTOR_GRADE_10022.csv")]
        public string SECTOR_GRADE_10022csv { get; set; }

        [JsonProperty("SECTOR_GRADE_10023.csv")]
        public string SECTOR_GRADE_10023csv { get; set; }

        [JsonProperty("SECTOR_GRADE_10030.csv")]
        public string SECTOR_GRADE_10030csv { get; set; }

        [JsonProperty("SECTOR_GRADE_10031.csv")]
        public string SECTOR_GRADE_10031csv { get; set; }

        [JsonProperty("SECTOR_GRADE_10032.csv")]
        public string SECTOR_GRADE_10032csv { get; set; }

        [JsonProperty("SECTOR_GRADE_10033.csv")]
        public string SECTOR_GRADE_10033csv { get; set; }

        [JsonProperty("SECTOR_GRADE_10040.csv")]
        public string SECTOR_GRADE_10040csv { get; set; }

        [JsonProperty("SECTOR_GRADE_10041.csv")]
        public string SECTOR_GRADE_10041csv { get; set; }

        [JsonProperty("SECTOR_GRADE_10042.csv")]
        public string SECTOR_GRADE_10042csv { get; set; }

        [JsonProperty("SECTOR_GRADE_10043.csv")]
        public string SECTOR_GRADE_10043csv { get; set; }

        [JsonProperty("SECTOR_GRADE_10045.csv")]
        public string SECTOR_GRADE_10045csv { get; set; }

        [JsonProperty("SECTOR_GRADE_10046.csv")]
        public string SECTOR_GRADE_10046csv { get; set; }

        [JsonProperty("SECTOR_GRADE_10047.csv")]
        public string SECTOR_GRADE_10047csv { get; set; }

        [JsonProperty("SECTOR_GRADE_10050.csv")]
        public string SECTOR_GRADE_10050csv { get; set; }

        [JsonProperty("SECTOR_GRADE_10051.csv")]
        public string SECTOR_GRADE_10051csv { get; set; }

        [JsonProperty("SECTOR_GRADE_10052.csv")]
        public string SECTOR_GRADE_10052csv { get; set; }

        [JsonProperty("SECTOR_GRADE_10053.csv")]
        public string SECTOR_GRADE_10053csv { get; set; }

        [JsonProperty("SECTOR_GRADE_10060.csv")]
        public string SECTOR_GRADE_10060csv { get; set; }

        [JsonProperty("SECTOR_GRADE_10061.csv")]
        public string SECTOR_GRADE_10061csv { get; set; }

        [JsonProperty("SECTOR_GRADE_10062.csv")]
        public string SECTOR_GRADE_10062csv { get; set; }

        [JsonProperty("SECTOR_GRADE_10063.csv")]
        public string SECTOR_GRADE_10063csv { get; set; }

        [JsonProperty("SECTOR_GRADE_10070.csv")]
        public string SECTOR_GRADE_10070csv { get; set; }

        [JsonProperty("SECTOR_GRADE_10071.csv")]
        public string SECTOR_GRADE_10071csv { get; set; }

        [JsonProperty("SECTOR_GRADE_10072.csv")]
        public string SECTOR_GRADE_10072csv { get; set; }

        [JsonProperty("SECTOR_GRADE_10073.csv")]
        public string SECTOR_GRADE_10073csv { get; set; }

        [JsonProperty("SECTOR_GRADE_10080.csv")]
        public string SECTOR_GRADE_10080csv { get; set; }

        [JsonProperty("SECTOR_GRADE_10081.csv")]
        public string SECTOR_GRADE_10081csv { get; set; }

        [JsonProperty("SECTOR_GRADE_10082.csv")]
        public string SECTOR_GRADE_10082csv { get; set; }

        [JsonProperty("SECTOR_GRADE_10083.csv")]
        public string SECTOR_GRADE_10083csv { get; set; }

        [JsonProperty("SECTOR_GRADE_10090.csv")]
        public string SECTOR_GRADE_10090csv { get; set; }

        [JsonProperty("SECTOR_GRADE_10091.csv")]
        public string SECTOR_GRADE_10091csv { get; set; }

        [JsonProperty("SECTOR_GRADE_10092.csv")]
        public string SECTOR_GRADE_10092csv { get; set; }

        [JsonProperty("SECTOR_GRADE_10093.csv")]
        public string SECTOR_GRADE_10093csv { get; set; }

        [JsonProperty("SECTOR_GRADE_101003010.csv")]
        public string SECTOR_GRADE_101003010csv { get; set; }

        [JsonProperty("SECTOR_GRADE_101003020.csv")]
        public string SECTOR_GRADE_101003020csv { get; set; }

        [JsonProperty("SECTOR_GRADE_101003030.csv")]
        public string SECTOR_GRADE_101003030csv { get; set; }

        [JsonProperty("SECTOR_GRADE_101004010.csv")]
        public string SECTOR_GRADE_101004010csv { get; set; }

        [JsonProperty("SECTOR_GRADE_101004020.csv")]
        public string SECTOR_GRADE_101004020csv { get; set; }

        [JsonProperty("SECTOR_GRADE_101004030.csv")]
        public string SECTOR_GRADE_101004030csv { get; set; }

        [JsonProperty("SECTOR_GRADE_101004040.csv")]
        public string SECTOR_GRADE_101004040csv { get; set; }

        [JsonProperty("SECTOR_GRADE_102003010.csv")]
        public string SECTOR_GRADE_102003010csv { get; set; }

        [JsonProperty("SECTOR_GRADE_102004010.csv")]
        public string SECTOR_GRADE_102004010csv { get; set; }

        [JsonProperty("SECTOR_GRADE_102004040.csv")]
        public string SECTOR_GRADE_102004040csv { get; set; }

        [JsonProperty("SECTOR_GRADE_102004070.csv")]
        public string SECTOR_GRADE_102004070csv { get; set; }

        [JsonProperty("SECTOR_GRADE_103003010.csv")]
        public string SECTOR_GRADE_103003010csv { get; set; }

        [JsonProperty("SECTOR_GRADE_103003020.csv")]
        public string SECTOR_GRADE_103003020csv { get; set; }

        [JsonProperty("SECTOR_GRADE_103003030.csv")]
        public string SECTOR_GRADE_103003030csv { get; set; }

        [JsonProperty("SECTOR_GRADE_103003070.csv")]
        public string SECTOR_GRADE_103003070csv { get; set; }

        [JsonProperty("SECTOR_GRADE_103004010.csv")]
        public string SECTOR_GRADE_103004010csv { get; set; }

        [JsonProperty("SECTOR_GRADE_104004010.csv")]
        public string SECTOR_GRADE_104004010csv { get; set; }

        [JsonProperty("SECTOR_GRADE_104004040.csv")]
        public string SECTOR_GRADE_104004040csv { get; set; }

        [JsonProperty("SECTOR_GRADE_104004050.csv")]
        public string SECTOR_GRADE_104004050csv { get; set; }

        [JsonProperty("SECTOR_GRADE_104004060.csv")]
        public string SECTOR_GRADE_104004060csv { get; set; }

        [JsonProperty("SECTOR_GRADE_104004070.csv")]
        public string SECTOR_GRADE_104004070csv { get; set; }

        [JsonProperty("SECTOR_GRADE_104004090.csv")]
        public string SECTOR_GRADE_104004090csv { get; set; }

        [JsonProperty("SECTOR_GRADE_104004100.csv")]
        public string SECTOR_GRADE_104004100csv { get; set; }

        [JsonProperty("SECTOR_GRADE_105001010.csv")]
        public string SECTOR_GRADE_105001010csv { get; set; }

        [JsonProperty("SECTOR_GRADE_105001020.csv")]
        public string SECTOR_GRADE_105001020csv { get; set; }

        [JsonProperty("SECTOR_GRADE_105002010.csv")]
        public string SECTOR_GRADE_105002010csv { get; set; }

        [JsonProperty("SECTOR_GRADE_105002050.csv")]
        public string SECTOR_GRADE_105002050csv { get; set; }

        [JsonProperty("SECTOR_GRADE_105002060.csv")]
        public string SECTOR_GRADE_105002060csv { get; set; }

        [JsonProperty("SECTOR_GRADE_105002070.csv")]
        public string SECTOR_GRADE_105002070csv { get; set; }

        [JsonProperty("SECTOR_GRADE_106001010.csv")]
        public string SECTOR_GRADE_106001010csv { get; set; }

        [JsonProperty("SECTOR_GRADE_106002010.csv")]
        public string SECTOR_GRADE_106002010csv { get; set; }

        [JsonProperty("SECTOR_GRADE_106002020.csv")]
        public string SECTOR_GRADE_106002020csv { get; set; }

        [JsonProperty("SECTOR_GRADE_106002030.csv")]
        public string SECTOR_GRADE_106002030csv { get; set; }

        [JsonProperty("SECTOR_GRADE_107001010.csv")]
        public string SECTOR_GRADE_107001010csv { get; set; }

        [JsonProperty("SECTOR_GRADE_107001020.csv")]
        public string SECTOR_GRADE_107001020csv { get; set; }

        [JsonProperty("SECTOR_GRADE_107002010.csv")]
        public string SECTOR_GRADE_107002010csv { get; set; }

        [JsonProperty("SECTOR_GRADE_107002020.csv")]
        public string SECTOR_GRADE_107002020csv { get; set; }

        [JsonProperty("SECTOR_GRADE_107003010.csv")]
        public string SECTOR_GRADE_107003010csv { get; set; }

        [JsonProperty("SECTOR_GRADE_107003020.csv")]
        public string SECTOR_GRADE_107003020csv { get; set; }

        [JsonProperty("SECTOR_GRADE_108001010.csv")]
        public string SECTOR_GRADE_108001010csv { get; set; }

        [JsonProperty("SECTOR_GRADE_108001020.csv")]
        public string SECTOR_GRADE_108001020csv { get; set; }

        [JsonProperty("SECTOR_GRADE_108001030.csv")]
        public string SECTOR_GRADE_108001030csv { get; set; }

        [JsonProperty("SECTOR_GRADE_108001040.csv")]
        public string SECTOR_GRADE_108001040csv { get; set; }

        [JsonProperty("SECTOR_GRADE_108001050.csv")]
        public string SECTOR_GRADE_108001050csv { get; set; }

        [JsonProperty("SECTOR_GRADE_109001010.csv")]
        public string SECTOR_GRADE_109001010csv { get; set; }

        [JsonProperty("SECTOR_GRADE_109001020.csv")]
        public string SECTOR_GRADE_109001020csv { get; set; }

        [JsonProperty("SECTOR_GRADE_109001030.csv")]
        public string SECTOR_GRADE_109001030csv { get; set; }

        [JsonProperty("SECTOR_GRADE_109001040.csv")]
        public string SECTOR_GRADE_109001040csv { get; set; }

        [JsonProperty("SECTOR_GRADE_109001050.csv")]
        public string SECTOR_GRADE_109001050csv { get; set; }

        [JsonProperty("SECTOR_GRADE_109001060.csv")]
        public string SECTOR_GRADE_109001060csv { get; set; }

        [JsonProperty("SECTOR_GRADE_110001010.csv")]
        public string SECTOR_GRADE_110001010csv { get; set; }

        [JsonProperty("SECTOR_GRADE_110001020.csv")]
        public string SECTOR_GRADE_110001020csv { get; set; }

        [JsonProperty("SECTOR_GRADE_110002010.csv")]
        public string SECTOR_GRADE_110002010csv { get; set; }

        [JsonProperty("SECTOR_GRADE_110002020.csv")]
        public string SECTOR_GRADE_110002020csv { get; set; }

        [JsonProperty("SECTOR_GRADE_110002030.csv")]
        public string SECTOR_GRADE_110002030csv { get; set; }

        [JsonProperty("SECTOR_GRADE_200022010.csv")]
        public string SECTOR_GRADE_200022010csv { get; set; }

        [JsonProperty("SECTOR_GRADE_200022020.csv")]
        public string SECTOR_GRADE_200022020csv { get; set; }

        [JsonProperty("SECTOR_GRADE_200022021.csv")]
        public string SECTOR_GRADE_200022021csv { get; set; }

        [JsonProperty("SECTOR_GRADE_200022030.csv")]
        public string SECTOR_GRADE_200022030csv { get; set; }

        [JsonProperty("SECTOR_GRADE_200022031.csv")]
        public string SECTOR_GRADE_200022031csv { get; set; }

        [JsonProperty("SECTOR_GRADE_200022040.csv")]
        public string SECTOR_GRADE_200022040csv { get; set; }

        [JsonProperty("SECTOR_GRADE_200022041.csv")]
        public string SECTOR_GRADE_200022041csv { get; set; }

        [JsonProperty("SECTOR_GRADE_200022042.csv")]
        public string SECTOR_GRADE_200022042csv { get; set; }

        [JsonProperty("SECTOR_GRADE_200022050.csv")]
        public string SECTOR_GRADE_200022050csv { get; set; }

        [JsonProperty("SECTOR_GRADE_200022051.csv")]
        public string SECTOR_GRADE_200022051csv { get; set; }

        [JsonProperty("SECTOR_GRADE_200022060.csv")]
        public string SECTOR_GRADE_200022060csv { get; set; }

        [JsonProperty("SECTOR_GRADE_200022070.csv")]
        public string SECTOR_GRADE_200022070csv { get; set; }

        [JsonProperty("SECTOR_GRADE_200022071.csv")]
        public string SECTOR_GRADE_200022071csv { get; set; }

        [JsonProperty("SECTOR_GRADE_200022072.csv")]
        public string SECTOR_GRADE_200022072csv { get; set; }

        [JsonProperty("SECTOR_GRADE_200022080.csv")]
        public string SECTOR_GRADE_200022080csv { get; set; }

        [JsonProperty("SECTOR_GRADE_200022081.csv")]
        public string SECTOR_GRADE_200022081csv { get; set; }

        [JsonProperty("SECTOR_GRADE_200022090.csv")]
        public string SECTOR_GRADE_200022090csv { get; set; }

        [JsonProperty("SECTOR_GRADE_200022091.csv")]
        public string SECTOR_GRADE_200022091csv { get; set; }

        [JsonProperty("SECTOR_GRADE_200022092.csv")]
        public string SECTOR_GRADE_200022092csv { get; set; }

        [JsonProperty("SECTOR_GRADE_200022100.csv")]
        public string SECTOR_GRADE_200022100csv { get; set; }

        [JsonProperty("SECTOR_GRADE_200022101.csv")]
        public string SECTOR_GRADE_200022101csv { get; set; }

        [JsonProperty("SECTOR_GRADE_200022102.csv")]
        public string SECTOR_GRADE_200022102csv { get; set; }

        [JsonProperty("SECTOR_GRADE_200022110.csv")]
        public string SECTOR_GRADE_200022110csv { get; set; }

        [JsonProperty("SECTOR_GRADE_200022120.csv")]
        public string SECTOR_GRADE_200022120csv { get; set; }

        [JsonProperty("SECTOR_GRADE_200022130.csv")]
        public string SECTOR_GRADE_200022130csv { get; set; }

        [JsonProperty("SECTOR_GRADE_200022210.csv")]
        public string SECTOR_GRADE_200022210csv { get; set; }

        [JsonProperty("SECTOR_GRADE_200022220.csv")]
        public string SECTOR_GRADE_200022220csv { get; set; }

        [JsonProperty("SECTOR_GRADE_200022221.csv")]
        public string SECTOR_GRADE_200022221csv { get; set; }

        [JsonProperty("SECTOR_GRADE_200022230.csv")]
        public string SECTOR_GRADE_200022230csv { get; set; }

        [JsonProperty("SECTOR_GRADE_200022240.csv")]
        public string SECTOR_GRADE_200022240csv { get; set; }

        [JsonProperty("SECTOR_GRADE_200022241.csv")]
        public string SECTOR_GRADE_200022241csv { get; set; }

        [JsonProperty("SECTOR_GRADE_200022242.csv")]
        public string SECTOR_GRADE_200022242csv { get; set; }

        [JsonProperty("SECTOR_GRADE_200022250.csv")]
        public string SECTOR_GRADE_200022250csv { get; set; }

        [JsonProperty("SECTOR_GRADE_200022251.csv")]
        public string SECTOR_GRADE_200022251csv { get; set; }

        [JsonProperty("SECTOR_GRADE_200022260.csv")]
        public string SECTOR_GRADE_200022260csv { get; set; }

        [JsonProperty("SECTOR_GRADE_200022270.csv")]
        public string SECTOR_GRADE_200022270csv { get; set; }

        [JsonProperty("SECTOR_GRADE_200022280.csv")]
        public string SECTOR_GRADE_200022280csv { get; set; }

        [JsonProperty("SECTOR_GRADE_200022290.csv")]
        public string SECTOR_GRADE_200022290csv { get; set; }

        [JsonProperty("SECTOR_GRADE_200022300.csv")]
        public string SECTOR_GRADE_200022300csv { get; set; }

        [JsonProperty("SECTOR_GRADE_200022310.csv")]
        public string SECTOR_GRADE_200022310csv { get; set; }

        [JsonProperty("SECTOR_GRADE_200022320.csv")]
        public string SECTOR_GRADE_200022320csv { get; set; }

        [JsonProperty("SECTOR_GRADE_200022330.csv")]
        public string SECTOR_GRADE_200022330csv { get; set; }

        [JsonProperty("SECTOR_GRADE_201003010.csv")]
        public string SECTOR_GRADE_201003010csv { get; set; }

        [JsonProperty("SECTOR_GRADE_201003011.csv")]
        public string SECTOR_GRADE_201003011csv { get; set; }

        [JsonProperty("SECTOR_GRADE_201003012.csv")]
        public string SECTOR_GRADE_201003012csv { get; set; }

        [JsonProperty("SECTOR_GRADE_201003013.csv")]
        public string SECTOR_GRADE_201003013csv { get; set; }

        [JsonProperty("SECTOR_GRADE_201003020.csv")]
        public string SECTOR_GRADE_201003020csv { get; set; }

        [JsonProperty("SECTOR_GRADE_201003021.csv")]
        public string SECTOR_GRADE_201003021csv { get; set; }

        [JsonProperty("SECTOR_GRADE_201003022.csv")]
        public string SECTOR_GRADE_201003022csv { get; set; }

        [JsonProperty("SECTOR_GRADE_201003023.csv")]
        public string SECTOR_GRADE_201003023csv { get; set; }

        [JsonProperty("SECTOR_GRADE_201003030.csv")]
        public string SECTOR_GRADE_201003030csv { get; set; }

        [JsonProperty("SECTOR_GRADE_201003031.csv")]
        public string SECTOR_GRADE_201003031csv { get; set; }

        [JsonProperty("SECTOR_GRADE_201003032.csv")]
        public string SECTOR_GRADE_201003032csv { get; set; }

        [JsonProperty("SECTOR_GRADE_201003033.csv")]
        public string SECTOR_GRADE_201003033csv { get; set; }

        [JsonProperty("SECTOR_GRADE_201003040.csv")]
        public string SECTOR_GRADE_201003040csv { get; set; }

        [JsonProperty("SECTOR_GRADE_201003041.csv")]
        public string SECTOR_GRADE_201003041csv { get; set; }

        [JsonProperty("SECTOR_GRADE_201003042.csv")]
        public string SECTOR_GRADE_201003042csv { get; set; }

        [JsonProperty("SECTOR_GRADE_201003043.csv")]
        public string SECTOR_GRADE_201003043csv { get; set; }

        [JsonProperty("SECTOR_GRADE_201004040.csv")]
        public string SECTOR_GRADE_201004040csv { get; set; }

        [JsonProperty("SECTOR_GRADE_201004041.csv")]
        public string SECTOR_GRADE_201004041csv { get; set; }

        [JsonProperty("SECTOR_GRADE_201004042.csv")]
        public string SECTOR_GRADE_201004042csv { get; set; }

        [JsonProperty("SECTOR_GRADE_201004043.csv")]
        public string SECTOR_GRADE_201004043csv { get; set; }

        [JsonProperty("SECTOR_GRADE_301001020.csv")]
        public string SECTOR_GRADE_301001020csv { get; set; }

        [JsonProperty("SECTOR_GRADE_301011010.csv")]
        public string SECTOR_GRADE_301011010csv { get; set; }

        [JsonProperty("SECTOR_GRADE_301011020.csv")]
        public string SECTOR_GRADE_301011020csv { get; set; }

        [JsonProperty("SECTOR_GRADE_301011030.csv")]
        public string SECTOR_GRADE_301011030csv { get; set; }

        [JsonProperty("SECTOR_GRADE_301011040.csv")]
        public string SECTOR_GRADE_301011040csv { get; set; }

        [JsonProperty("WAYPOINT_100002010.csv")]
        public string WAYPOINT_100002010csv { get; set; }

        [JsonProperty("WAYPOINT_100002012.csv")]
        public string WAYPOINT_100002012csv { get; set; }

        [JsonProperty("WAYPOINT_100002020.csv")]
        public string WAYPOINT_100002020csv { get; set; }

        [JsonProperty("WAYPOINT_1001.csv")]
        public string WAYPOINT_1001csv { get; set; }

        [JsonProperty("WAYPOINT_10010.csv")]
        public string WAYPOINT_10010csv { get; set; }

        [JsonProperty("WAYPOINT_10010_Global.csv")]
        public string WAYPOINT_10010_Globalcsv { get; set; }

        [JsonProperty("WAYPOINT_10011.csv")]
        public string WAYPOINT_10011csv { get; set; }

        [JsonProperty("WAYPOINT_10011_Global.csv")]
        public string WAYPOINT_10011_Globalcsv { get; set; }

        [JsonProperty("WAYPOINT_10012.csv")]
        public string WAYPOINT_10012csv { get; set; }

        [JsonProperty("WAYPOINT_10012_Global.csv")]
        public string WAYPOINT_10012_Globalcsv { get; set; }

        [JsonProperty("WAYPOINT_10013.csv")]
        public string WAYPOINT_10013csv { get; set; }

        [JsonProperty("WAYPOINT_10013_Global.csv")]
        public string WAYPOINT_10013_Globalcsv { get; set; }

        [JsonProperty("WAYPOINT_10020.csv")]
        public string WAYPOINT_10020csv { get; set; }

        [JsonProperty("WAYPOINT_10020_Global.csv")]
        public string WAYPOINT_10020_Globalcsv { get; set; }

        [JsonProperty("WAYPOINT_10021.csv")]
        public string WAYPOINT_10021csv { get; set; }

        [JsonProperty("WAYPOINT_10021_Global.csv")]
        public string WAYPOINT_10021_Globalcsv { get; set; }

        [JsonProperty("WAYPOINT_10022.csv")]
        public string WAYPOINT_10022csv { get; set; }

        [JsonProperty("WAYPOINT_10022_Global.csv")]
        public string WAYPOINT_10022_Globalcsv { get; set; }

        [JsonProperty("WAYPOINT_10023.csv")]
        public string WAYPOINT_10023csv { get; set; }

        [JsonProperty("WAYPOINT_10023_Global.csv")]
        public string WAYPOINT_10023_Globalcsv { get; set; }

        [JsonProperty("WAYPOINT_10030.csv")]
        public string WAYPOINT_10030csv { get; set; }

        [JsonProperty("WAYPOINT_10030_Global.csv")]
        public string WAYPOINT_10030_Globalcsv { get; set; }

        [JsonProperty("WAYPOINT_10031.csv")]
        public string WAYPOINT_10031csv { get; set; }

        [JsonProperty("WAYPOINT_10031_Global.csv")]
        public string WAYPOINT_10031_Globalcsv { get; set; }

        [JsonProperty("WAYPOINT_10032.csv")]
        public string WAYPOINT_10032csv { get; set; }

        [JsonProperty("WAYPOINT_10032_Global.csv")]
        public string WAYPOINT_10032_Globalcsv { get; set; }

        [JsonProperty("WAYPOINT_10033.csv")]
        public string WAYPOINT_10033csv { get; set; }

        [JsonProperty("WAYPOINT_10033_Global.csv")]
        public string WAYPOINT_10033_Globalcsv { get; set; }

        [JsonProperty("WAYPOINT_10040.csv")]
        public string WAYPOINT_10040csv { get; set; }

        [JsonProperty("WAYPOINT_10040_Global.csv")]
        public string WAYPOINT_10040_Globalcsv { get; set; }

        [JsonProperty("WAYPOINT_10041.csv")]
        public string WAYPOINT_10041csv { get; set; }

        [JsonProperty("WAYPOINT_10041_Global.csv")]
        public string WAYPOINT_10041_Globalcsv { get; set; }

        [JsonProperty("WAYPOINT_10042.csv")]
        public string WAYPOINT_10042csv { get; set; }

        [JsonProperty("WAYPOINT_10042_Global.csv")]
        public string WAYPOINT_10042_Globalcsv { get; set; }

        [JsonProperty("WAYPOINT_10043.csv")]
        public string WAYPOINT_10043csv { get; set; }

        [JsonProperty("WAYPOINT_10043_Global.csv")]
        public string WAYPOINT_10043_Globalcsv { get; set; }

        [JsonProperty("WAYPOINT_10045.csv")]
        public string WAYPOINT_10045csv { get; set; }

        [JsonProperty("WAYPOINT_10046.csv")]
        public string WAYPOINT_10046csv { get; set; }

        [JsonProperty("WAYPOINT_10047.csv")]
        public string WAYPOINT_10047csv { get; set; }

        [JsonProperty("WAYPOINT_10050.csv")]
        public string WAYPOINT_10050csv { get; set; }

        [JsonProperty("WAYPOINT_10050_Global.csv")]
        public string WAYPOINT_10050_Globalcsv { get; set; }

        [JsonProperty("WAYPOINT_10051.csv")]
        public string WAYPOINT_10051csv { get; set; }

        [JsonProperty("WAYPOINT_10051_Global.csv")]
        public string WAYPOINT_10051_Globalcsv { get; set; }

        [JsonProperty("WAYPOINT_10052.csv")]
        public string WAYPOINT_10052csv { get; set; }

        [JsonProperty("WAYPOINT_10052_Global.csv")]
        public string WAYPOINT_10052_Globalcsv { get; set; }

        [JsonProperty("WAYPOINT_10053.csv")]
        public string WAYPOINT_10053csv { get; set; }

        [JsonProperty("WAYPOINT_10053_Global.csv")]
        public string WAYPOINT_10053_Globalcsv { get; set; }

        [JsonProperty("WAYPOINT_10060.csv")]
        public string WAYPOINT_10060csv { get; set; }

        [JsonProperty("WAYPOINT_10060_Global.csv")]
        public string WAYPOINT_10060_Globalcsv { get; set; }

        [JsonProperty("WAYPOINT_10061.csv")]
        public string WAYPOINT_10061csv { get; set; }

        [JsonProperty("WAYPOINT_10061_Global.csv")]
        public string WAYPOINT_10061_Globalcsv { get; set; }

        [JsonProperty("WAYPOINT_10062.csv")]
        public string WAYPOINT_10062csv { get; set; }

        [JsonProperty("WAYPOINT_10062_Global.csv")]
        public string WAYPOINT_10062_Globalcsv { get; set; }

        [JsonProperty("WAYPOINT_10063.csv")]
        public string WAYPOINT_10063csv { get; set; }

        [JsonProperty("WAYPOINT_10063_Global.csv")]
        public string WAYPOINT_10063_Globalcsv { get; set; }

        [JsonProperty("WAYPOINT_10070.csv")]
        public string WAYPOINT_10070csv { get; set; }

        [JsonProperty("WAYPOINT_10070_Global.csv")]
        public string WAYPOINT_10070_Globalcsv { get; set; }

        [JsonProperty("WAYPOINT_10071.csv")]
        public string WAYPOINT_10071csv { get; set; }

        [JsonProperty("WAYPOINT_10071_Global.csv")]
        public string WAYPOINT_10071_Globalcsv { get; set; }

        [JsonProperty("WAYPOINT_10072.csv")]
        public string WAYPOINT_10072csv { get; set; }

        [JsonProperty("WAYPOINT_10072_Global.csv")]
        public string WAYPOINT_10072_Globalcsv { get; set; }

        [JsonProperty("WAYPOINT_10073.csv")]
        public string WAYPOINT_10073csv { get; set; }

        [JsonProperty("WAYPOINT_10073_Global.csv")]
        public string WAYPOINT_10073_Globalcsv { get; set; }

        [JsonProperty("WAYPOINT_10080.csv")]
        public string WAYPOINT_10080csv { get; set; }

        [JsonProperty("WAYPOINT_10081.csv")]
        public string WAYPOINT_10081csv { get; set; }

        [JsonProperty("WAYPOINT_10082.csv")]
        public string WAYPOINT_10082csv { get; set; }

        [JsonProperty("WAYPOINT_10083.csv")]
        public string WAYPOINT_10083csv { get; set; }

        [JsonProperty("WAYPOINT_10090.csv")]
        public string WAYPOINT_10090csv { get; set; }

        [JsonProperty("WAYPOINT_10091.csv")]
        public string WAYPOINT_10091csv { get; set; }

        [JsonProperty("WAYPOINT_10092.csv")]
        public string WAYPOINT_10092csv { get; set; }

        [JsonProperty("WAYPOINT_10093.csv")]
        public string WAYPOINT_10093csv { get; set; }

        [JsonProperty("WAYPOINT_101001010.csv")]
        public string WAYPOINT_101001010csv { get; set; }

        [JsonProperty("WAYPOINT_101001010_Global.csv")]
        public string WAYPOINT_101001010_Globalcsv { get; set; }

        [JsonProperty("WAYPOINT_101003010.csv")]
        public string WAYPOINT_101003010csv { get; set; }

        [JsonProperty("WAYPOINT_101003020.csv")]
        public string WAYPOINT_101003020csv { get; set; }

        [JsonProperty("WAYPOINT_101003030.csv")]
        public string WAYPOINT_101003030csv { get; set; }

        [JsonProperty("WAYPOINT_101003040.csv")]
        public string WAYPOINT_101003040csv { get; set; }

        [JsonProperty("WAYPOINT_101003060.csv")]
        public string WAYPOINT_101003060csv { get; set; }

        [JsonProperty("WAYPOINT_101003060_Global.csv")]
        public string WAYPOINT_101003060_Globalcsv { get; set; }

        [JsonProperty("WAYPOINT_101004010.csv")]
        public string WAYPOINT_101004010csv { get; set; }

        [JsonProperty("WAYPOINT_101004020.csv")]
        public string WAYPOINT_101004020csv { get; set; }

        [JsonProperty("WAYPOINT_101004030.csv")]
        public string WAYPOINT_101004030csv { get; set; }

        [JsonProperty("WAYPOINT_101004040.csv")]
        public string WAYPOINT_101004040csv { get; set; }

        [JsonProperty("WAYPOINT_101005020.csv")]
        public string WAYPOINT_101005020csv { get; set; }

        [JsonProperty("WAYPOINT_101005040.csv")]
        public string WAYPOINT_101005040csv { get; set; }

        [JsonProperty("WAYPOINT_102003010.csv")]
        public string WAYPOINT_102003010csv { get; set; }

        [JsonProperty("WAYPOINT_102004010.csv")]
        public string WAYPOINT_102004010csv { get; set; }

        [JsonProperty("WAYPOINT_102004040.csv")]
        public string WAYPOINT_102004040csv { get; set; }

        [JsonProperty("WAYPOINT_102004050.csv")]
        public string WAYPOINT_102004050csv { get; set; }

        [JsonProperty("WAYPOINT_102004070.csv")]
        public string WAYPOINT_102004070csv { get; set; }

        [JsonProperty("WAYPOINT_102005020.csv")]
        public string WAYPOINT_102005020csv { get; set; }

        [JsonProperty("WAYPOINT_102005020_Global.csv")]
        public string WAYPOINT_102005020_Globalcsv { get; set; }

        [JsonProperty("WAYPOINT_103003010.csv")]
        public string WAYPOINT_103003010csv { get; set; }

        [JsonProperty("WAYPOINT_103003010_Global.csv")]
        public string WAYPOINT_103003010_Globalcsv { get; set; }

        [JsonProperty("WAYPOINT_103003020.csv")]
        public string WAYPOINT_103003020csv { get; set; }

        [JsonProperty("WAYPOINT_103003030.csv")]
        public string WAYPOINT_103003030csv { get; set; }

        [JsonProperty("WAYPOINT_103003040.csv")]
        public string WAYPOINT_103003040csv { get; set; }

        [JsonProperty("WAYPOINT_103003050.csv")]
        public string WAYPOINT_103003050csv { get; set; }

        [JsonProperty("WAYPOINT_103003060.csv")]
        public string WAYPOINT_103003060csv { get; set; }

        [JsonProperty("WAYPOINT_103003070.csv")]
        public string WAYPOINT_103003070csv { get; set; }

        [JsonProperty("WAYPOINT_103003070_Global.csv")]
        public string WAYPOINT_103003070_Globalcsv { get; set; }

        [JsonProperty("WAYPOINT_103004010.csv")]
        public string WAYPOINT_103004010csv { get; set; }

        [JsonProperty("WAYPOINT_104003010.csv")]
        public string WAYPOINT_104003010csv { get; set; }

        [JsonProperty("WAYPOINT_104004010.csv")]
        public string WAYPOINT_104004010csv { get; set; }

        [JsonProperty("WAYPOINT_104004040.csv")]
        public string WAYPOINT_104004040csv { get; set; }

        [JsonProperty("WAYPOINT_104004050.csv")]
        public string WAYPOINT_104004050csv { get; set; }

        [JsonProperty("WAYPOINT_104004060.csv")]
        public string WAYPOINT_104004060csv { get; set; }

        [JsonProperty("WAYPOINT_104004060_Global.csv")]
        public string WAYPOINT_104004060_Globalcsv { get; set; }

        [JsonProperty("WAYPOINT_104004070.csv")]
        public string WAYPOINT_104004070csv { get; set; }

        [JsonProperty("WAYPOINT_104004090.csv")]
        public string WAYPOINT_104004090csv { get; set; }

        [JsonProperty("WAYPOINT_104004090_Global.csv")]
        public string WAYPOINT_104004090_Globalcsv { get; set; }

        [JsonProperty("WAYPOINT_104004100.csv")]
        public string WAYPOINT_104004100csv { get; set; }

        [JsonProperty("WAYPOINT_104005010.csv")]
        public string WAYPOINT_104005010csv { get; set; }

        [JsonProperty("WAYPOINT_104005010_Global.csv")]
        public string WAYPOINT_104005010_Globalcsv { get; set; }

        [JsonProperty("WAYPOINT_105001010.csv")]
        public string WAYPOINT_105001010csv { get; set; }

        [JsonProperty("WAYPOINT_105001020.csv")]
        public string WAYPOINT_105001020csv { get; set; }

        [JsonProperty("WAYPOINT_105002010.csv")]
        public string WAYPOINT_105002010csv { get; set; }

        [JsonProperty("WAYPOINT_105002020.csv")]
        public string WAYPOINT_105002020csv { get; set; }

        [JsonProperty("WAYPOINT_105002020_Global.csv")]
        public string WAYPOINT_105002020_Globalcsv { get; set; }

        [JsonProperty("WAYPOINT_105002050.csv")]
        public string WAYPOINT_105002050csv { get; set; }

        [JsonProperty("WAYPOINT_105002060.csv")]
        public string WAYPOINT_105002060csv { get; set; }

        [JsonProperty("WAYPOINT_105002070.csv")]
        public string WAYPOINT_105002070csv { get; set; }

        [JsonProperty("WAYPOINT_105002070_Global.csv")]
        public string WAYPOINT_105002070_Globalcsv { get; set; }

        [JsonProperty("WAYPOINT_106001010.csv")]
        public string WAYPOINT_106001010csv { get; set; }

        [JsonProperty("WAYPOINT_106002010.csv")]
        public string WAYPOINT_106002010csv { get; set; }

        [JsonProperty("WAYPOINT_106002010_Global.csv")]
        public string WAYPOINT_106002010_Globalcsv { get; set; }

        [JsonProperty("WAYPOINT_106002020.csv")]
        public string WAYPOINT_106002020csv { get; set; }

        [JsonProperty("WAYPOINT_106002020_Global.csv")]
        public string WAYPOINT_106002020_Globalcsv { get; set; }

        [JsonProperty("WAYPOINT_106002030.csv")]
        public string WAYPOINT_106002030csv { get; set; }

        [JsonProperty("WAYPOINT_106002040.csv")]
        public string WAYPOINT_106002040csv { get; set; }

        [JsonProperty("WAYPOINT_107001010.csv")]
        public string WAYPOINT_107001010csv { get; set; }

        [JsonProperty("WAYPOINT_107001020.csv")]
        public string WAYPOINT_107001020csv { get; set; }

        [JsonProperty("WAYPOINT_107002010.csv")]
        public string WAYPOINT_107002010csv { get; set; }

        [JsonProperty("WAYPOINT_107002020.csv")]
        public string WAYPOINT_107002020csv { get; set; }

        [JsonProperty("WAYPOINT_107003010.csv")]
        public string WAYPOINT_107003010csv { get; set; }

        [JsonProperty("WAYPOINT_107003020.csv")]
        public string WAYPOINT_107003020csv { get; set; }

        [JsonProperty("WAYPOINT_108001010.csv")]
        public string WAYPOINT_108001010csv { get; set; }

        [JsonProperty("WAYPOINT_108001020.csv")]
        public string WAYPOINT_108001020csv { get; set; }

        [JsonProperty("WAYPOINT_108001030.csv")]
        public string WAYPOINT_108001030csv { get; set; }

        [JsonProperty("WAYPOINT_108001040.csv")]
        public string WAYPOINT_108001040csv { get; set; }

        [JsonProperty("WAYPOINT_108001050.csv")]
        public string WAYPOINT_108001050csv { get; set; }

        [JsonProperty("WAYPOINT_109001010.csv")]
        public string WAYPOINT_109001010csv { get; set; }

        [JsonProperty("WAYPOINT_109001020.csv")]
        public string WAYPOINT_109001020csv { get; set; }

        [JsonProperty("WAYPOINT_109001030.csv")]
        public string WAYPOINT_109001030csv { get; set; }

        [JsonProperty("WAYPOINT_109001040.csv")]
        public string WAYPOINT_109001040csv { get; set; }

        [JsonProperty("WAYPOINT_109001050.csv")]
        public string WAYPOINT_109001050csv { get; set; }

        [JsonProperty("WAYPOINT_109001060.csv")]
        public string WAYPOINT_109001060csv { get; set; }

        [JsonProperty("WAYPOINT_110001010.csv")]
        public string WAYPOINT_110001010csv { get; set; }

        [JsonProperty("WAYPOINT_110001020.csv")]
        public string WAYPOINT_110001020csv { get; set; }

        [JsonProperty("WAYPOINT_110002010.csv")]
        public string WAYPOINT_110002010csv { get; set; }

        [JsonProperty("WAYPOINT_110002020.csv")]
        public string WAYPOINT_110002020csv { get; set; }

        [JsonProperty("WAYPOINT_110002030.csv")]
        public string WAYPOINT_110002030csv { get; set; }

        [JsonProperty("WAYPOINT_110003010.csv")]
        public string WAYPOINT_110003010csv { get; set; }

        [JsonProperty("WAYPOINT_11001.csv")]
        public string WAYPOINT_11001csv { get; set; }

        [JsonProperty("WAYPOINT_11001_Global.csv")]
        public string WAYPOINT_11001_Globalcsv { get; set; }

        [JsonProperty("WAYPOINT_11002.csv")]
        public string WAYPOINT_11002csv { get; set; }

        [JsonProperty("WAYPOINT_12001.csv")]
        public string WAYPOINT_12001csv { get; set; }

        [JsonProperty("WAYPOINT_12001_Global.csv")]
        public string WAYPOINT_12001_Globalcsv { get; set; }

        [JsonProperty("WAYPOINT_12002.csv")]
        public string WAYPOINT_12002csv { get; set; }

        [JsonProperty("WAYPOINT_13001.csv")]
        public string WAYPOINT_13001csv { get; set; }

        [JsonProperty("WAYPOINT_200022010.csv")]
        public string WAYPOINT_200022010csv { get; set; }

        [JsonProperty("WAYPOINT_200022020.csv")]
        public string WAYPOINT_200022020csv { get; set; }

        [JsonProperty("WAYPOINT_200022021.csv")]
        public string WAYPOINT_200022021csv { get; set; }

        [JsonProperty("WAYPOINT_200022030.csv")]
        public string WAYPOINT_200022030csv { get; set; }

        [JsonProperty("WAYPOINT_200022031.csv")]
        public string WAYPOINT_200022031csv { get; set; }

        [JsonProperty("WAYPOINT_200022040.csv")]
        public string WAYPOINT_200022040csv { get; set; }

        [JsonProperty("WAYPOINT_200022041.csv")]
        public string WAYPOINT_200022041csv { get; set; }

        [JsonProperty("WAYPOINT_200022042.csv")]
        public string WAYPOINT_200022042csv { get; set; }

        [JsonProperty("WAYPOINT_200022050.csv")]
        public string WAYPOINT_200022050csv { get; set; }

        [JsonProperty("WAYPOINT_200022051.csv")]
        public string WAYPOINT_200022051csv { get; set; }

        [JsonProperty("WAYPOINT_200022060.csv")]
        public string WAYPOINT_200022060csv { get; set; }

        [JsonProperty("WAYPOINT_200022070.csv")]
        public string WAYPOINT_200022070csv { get; set; }

        [JsonProperty("WAYPOINT_200022071.csv")]
        public string WAYPOINT_200022071csv { get; set; }

        [JsonProperty("WAYPOINT_200022072.csv")]
        public string WAYPOINT_200022072csv { get; set; }

        [JsonProperty("WAYPOINT_200022080.csv")]
        public string WAYPOINT_200022080csv { get; set; }

        [JsonProperty("WAYPOINT_200022081.csv")]
        public string WAYPOINT_200022081csv { get; set; }

        [JsonProperty("WAYPOINT_200022090.csv")]
        public string WAYPOINT_200022090csv { get; set; }

        [JsonProperty("WAYPOINT_200022091.csv")]
        public string WAYPOINT_200022091csv { get; set; }

        [JsonProperty("WAYPOINT_200022092.csv")]
        public string WAYPOINT_200022092csv { get; set; }

        [JsonProperty("WAYPOINT_200022100.csv")]
        public string WAYPOINT_200022100csv { get; set; }

        [JsonProperty("WAYPOINT_200022101.csv")]
        public string WAYPOINT_200022101csv { get; set; }

        [JsonProperty("WAYPOINT_200022102.csv")]
        public string WAYPOINT_200022102csv { get; set; }

        [JsonProperty("WAYPOINT_200022110.csv")]
        public string WAYPOINT_200022110csv { get; set; }

        [JsonProperty("WAYPOINT_200022120.csv")]
        public string WAYPOINT_200022120csv { get; set; }

        [JsonProperty("WAYPOINT_200022130.csv")]
        public string WAYPOINT_200022130csv { get; set; }

        [JsonProperty("WAYPOINT_200022210.csv")]
        public string WAYPOINT_200022210csv { get; set; }

        [JsonProperty("WAYPOINT_200022220.csv")]
        public string WAYPOINT_200022220csv { get; set; }

        [JsonProperty("WAYPOINT_200022221.csv")]
        public string WAYPOINT_200022221csv { get; set; }

        [JsonProperty("WAYPOINT_200022230.csv")]
        public string WAYPOINT_200022230csv { get; set; }

        [JsonProperty("WAYPOINT_200022240.csv")]
        public string WAYPOINT_200022240csv { get; set; }

        [JsonProperty("WAYPOINT_200022241.csv")]
        public string WAYPOINT_200022241csv { get; set; }

        [JsonProperty("WAYPOINT_200022242.csv")]
        public string WAYPOINT_200022242csv { get; set; }

        [JsonProperty("WAYPOINT_200022250.csv")]
        public string WAYPOINT_200022250csv { get; set; }

        [JsonProperty("WAYPOINT_200022251.csv")]
        public string WAYPOINT_200022251csv { get; set; }

        [JsonProperty("WAYPOINT_200022260.csv")]
        public string WAYPOINT_200022260csv { get; set; }

        [JsonProperty("WAYPOINT_200022270.csv")]
        public string WAYPOINT_200022270csv { get; set; }

        [JsonProperty("WAYPOINT_200022280.csv")]
        public string WAYPOINT_200022280csv { get; set; }

        [JsonProperty("WAYPOINT_200022290.csv")]
        public string WAYPOINT_200022290csv { get; set; }

        [JsonProperty("WAYPOINT_200022300.csv")]
        public string WAYPOINT_200022300csv { get; set; }

        [JsonProperty("WAYPOINT_200022310.csv")]
        public string WAYPOINT_200022310csv { get; set; }

        [JsonProperty("WAYPOINT_200022320.csv")]
        public string WAYPOINT_200022320csv { get; set; }

        [JsonProperty("WAYPOINT_200022330.csv")]
        public string WAYPOINT_200022330csv { get; set; }

        [JsonProperty("WAYPOINT_201003010.csv")]
        public string WAYPOINT_201003010csv { get; set; }

        [JsonProperty("WAYPOINT_201003010_Global.csv")]
        public string WAYPOINT_201003010_Globalcsv { get; set; }

        [JsonProperty("WAYPOINT_201003011.csv")]
        public string WAYPOINT_201003011csv { get; set; }

        [JsonProperty("WAYPOINT_201003011_Global.csv")]
        public string WAYPOINT_201003011_Globalcsv { get; set; }

        [JsonProperty("WAYPOINT_201003012.csv")]
        public string WAYPOINT_201003012csv { get; set; }

        [JsonProperty("WAYPOINT_201003012_Global.csv")]
        public string WAYPOINT_201003012_Globalcsv { get; set; }

        [JsonProperty("WAYPOINT_201003013.csv")]
        public string WAYPOINT_201003013csv { get; set; }

        [JsonProperty("WAYPOINT_201003013_Global.csv")]
        public string WAYPOINT_201003013_Globalcsv { get; set; }

        [JsonProperty("WAYPOINT_201003020.csv")]
        public string WAYPOINT_201003020csv { get; set; }

        [JsonProperty("WAYPOINT_201003020_Global.csv")]
        public string WAYPOINT_201003020_Globalcsv { get; set; }

        [JsonProperty("WAYPOINT_201003021.csv")]
        public string WAYPOINT_201003021csv { get; set; }

        [JsonProperty("WAYPOINT_201003021_Global.csv")]
        public string WAYPOINT_201003021_Globalcsv { get; set; }

        [JsonProperty("WAYPOINT_201003022.csv")]
        public string WAYPOINT_201003022csv { get; set; }

        [JsonProperty("WAYPOINT_201003022_Global.csv")]
        public string WAYPOINT_201003022_Globalcsv { get; set; }

        [JsonProperty("WAYPOINT_201003023.csv")]
        public string WAYPOINT_201003023csv { get; set; }

        [JsonProperty("WAYPOINT_201003023_Global.csv")]
        public string WAYPOINT_201003023_Globalcsv { get; set; }

        [JsonProperty("WAYPOINT_201003030.csv")]
        public string WAYPOINT_201003030csv { get; set; }

        [JsonProperty("WAYPOINT_201003030_Global.csv")]
        public string WAYPOINT_201003030_Globalcsv { get; set; }

        [JsonProperty("WAYPOINT_201003031.csv")]
        public string WAYPOINT_201003031csv { get; set; }

        [JsonProperty("WAYPOINT_201003031_Global.csv")]
        public string WAYPOINT_201003031_Globalcsv { get; set; }

        [JsonProperty("WAYPOINT_201003032.csv")]
        public string WAYPOINT_201003032csv { get; set; }

        [JsonProperty("WAYPOINT_201003032_Global.csv")]
        public string WAYPOINT_201003032_Globalcsv { get; set; }

        [JsonProperty("WAYPOINT_201003033.csv")]
        public string WAYPOINT_201003033csv { get; set; }

        [JsonProperty("WAYPOINT_201003033_Global.csv")]
        public string WAYPOINT_201003033_Globalcsv { get; set; }

        [JsonProperty("WAYPOINT_201003040.csv")]
        public string WAYPOINT_201003040csv { get; set; }

        [JsonProperty("WAYPOINT_201003040_Global.csv")]
        public string WAYPOINT_201003040_Globalcsv { get; set; }

        [JsonProperty("WAYPOINT_201003041.csv")]
        public string WAYPOINT_201003041csv { get; set; }

        [JsonProperty("WAYPOINT_201003041_Global.csv")]
        public string WAYPOINT_201003041_Globalcsv { get; set; }

        [JsonProperty("WAYPOINT_201003042.csv")]
        public string WAYPOINT_201003042csv { get; set; }

        [JsonProperty("WAYPOINT_201003042_Global.csv")]
        public string WAYPOINT_201003042_Globalcsv { get; set; }

        [JsonProperty("WAYPOINT_201003043.csv")]
        public string WAYPOINT_201003043csv { get; set; }

        [JsonProperty("WAYPOINT_201003043_Global.csv")]
        public string WAYPOINT_201003043_Globalcsv { get; set; }

        [JsonProperty("WAYPOINT_201004040.csv")]
        public string WAYPOINT_201004040csv { get; set; }

        [JsonProperty("WAYPOINT_201004041.csv")]
        public string WAYPOINT_201004041csv { get; set; }

        [JsonProperty("WAYPOINT_201004042.csv")]
        public string WAYPOINT_201004042csv { get; set; }

        [JsonProperty("WAYPOINT_201004043.csv")]
        public string WAYPOINT_201004043csv { get; set; }

        [JsonProperty("WAYPOINT_201400001.csv")]
        public string WAYPOINT_201400001csv { get; set; }

        [JsonProperty("WAYPOINT_201400002.csv")]
        public string WAYPOINT_201400002csv { get; set; }

        [JsonProperty("WAYPOINT_201400003.csv")]
        public string WAYPOINT_201400003csv { get; set; }

        [JsonProperty("WAYPOINT_201400004.csv")]
        public string WAYPOINT_201400004csv { get; set; }

        [JsonProperty("WAYPOINT_201400005.csv")]
        public string WAYPOINT_201400005csv { get; set; }

        [JsonProperty("WAYPOINT_201400006.csv")]
        public string WAYPOINT_201400006csv { get; set; }

        [JsonProperty("WAYPOINT_201400007.csv")]
        public string WAYPOINT_201400007csv { get; set; }

        [JsonProperty("WAYPOINT_201400008.csv")]
        public string WAYPOINT_201400008csv { get; set; }

        [JsonProperty("WAYPOINT_201500010.csv")]
        public string WAYPOINT_201500010csv { get; set; }

        [JsonProperty("WAYPOINT_201500020.csv")]
        public string WAYPOINT_201500020csv { get; set; }

        [JsonProperty("WAYPOINT_201500030.csv")]
        public string WAYPOINT_201500030csv { get; set; }

        [JsonProperty("WAYPOINT_2021.csv")]
        public string WAYPOINT_2021csv { get; set; }

        [JsonProperty("WAYPOINT_300230.csv")]
        public string WAYPOINT_300230csv { get; set; }

        [JsonProperty("WAYPOINT_3010.csv")]
        public string WAYPOINT_3010csv { get; set; }

        [JsonProperty("WAYPOINT_301001010.csv")]
        public string WAYPOINT_301001010csv { get; set; }

        [JsonProperty("WAYPOINT_301001020.csv")]
        public string WAYPOINT_301001020csv { get; set; }

        [JsonProperty("WAYPOINT_301011010.csv")]
        public string WAYPOINT_301011010csv { get; set; }

        [JsonProperty("WAYPOINT_301011020.csv")]
        public string WAYPOINT_301011020csv { get; set; }

        [JsonProperty("WAYPOINT_301011030.csv")]
        public string WAYPOINT_301011030csv { get; set; }

        [JsonProperty("WAYPOINT_301011040.csv")]
        public string WAYPOINT_301011040csv { get; set; }
    }

    public class List
    {
        public string name { get; set; }
        public Files files { get; set; }
    }

    public class DataInfo
    {
        public string Revision { get; set; }
        public List<List> List { get; set; }
    }


}
