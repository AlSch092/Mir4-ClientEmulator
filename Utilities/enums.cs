//By AlSch092 @ Github
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mir4ClientEmulator.Utilities
{
    static public class Enums
    {
        public enum Os
        {
            None = 0,
            Android = 1,
            Ios = 2,
            Editor = 3,
            Windows = 4
        }

        public enum ErrorCode
        {
            None = 0,
            Success = 1,
            Unauthorized = 101,
            AccountIdEmpty = 102,
            AccountBlock = 103,
            Mysql = 201,
            Redis = 301,
            System = 901
        }

        public enum Sdk
        {
            None = 0,
            Pc = 1,
            Google = 2,
            Facebook = 3,
            Gamecenter = 4,
            Naver = 5,
            Kakao = 6,
            Guest = 7
        }

        public enum  DungeonKind
        {
            none = 0,
            hunting_squad = 1,
            boss = 2,
            hell = 3, // Defeat hell
            Guild_boss = 4, // Defeat clan boss (development cancelled)
        };

        public  enum Sub_Etc
        {
            Scrap = 1, // Miscellaneous item
            PK_Gain = 2, // pk acquired item // 2021-04-19 add

            BlackDragon_DungeonTicket = 4, // Black Dragon's Tower admission ticket item // 2022-03-08
            Hell_DungeonTicket = 5, // Hell Conquest admission ticket
        };


        public enum ItemGainType
        {
            None = 0,
            Drop = 1, //Drop
            Product = 2, //Crafting
            Synthesis = 3, //Synthesis
            Gacha = 4, //Summon
            Reinforce = 5, //Reinforcement
            Exchange = 6, //Exchange
            Unsealing = 7, //Unseal
            RandomBox = 8, //Random box (bag)
            ComposeFailReward = 9, //Mysterious Incense
            EventGacha = 10, //Event Summon
            EventPointGacha = 11, //Event Point Summon
            GM_EventGacha = 12, // GM Event Summon
            GM_EventPointGacha = 13, //GM Event Point Summon
            BenedictionEvent = 14, // Divine Dragon's Incense Burner (Event)
            DominionPrize = 15, // Territory Reward
            PetUpgrade = 16, // Spirit Transcendence
            PetItemTrance = 17, // Spirit Treasure Transcendence
            MagicStoneTrance = 18, // Magic Stone Transcendence
            DungeonClearReward = 19, // Subjugation clear reward
            BossDungeonClearReward = 20, // Boss defeat clear reward
            GachaPullBonusGacha = 21, // Divine Dragon's Promise
            ItemMakeAgency = 22, //
            MysticalPieceTrance = 23, // HellDungeonClearReward
            HellConquest = 24, //Hell Conquest Clear Reward
            //////////////////////////////////////// /////////////////////////////////////
            //------------- ----------- Enum value for server identification --------------------------//
            ////// ///////////////////////////////////////////////////// //////////////////

            Unsealing_All = 1000, //Obtain all unsealing
        };


        enum  MatchingType
        {
            None = 0,
            Party = 1,
            Party_dungeon = 2, //Punishment
            Boss_dungeon = 3,
            Dungeon = 4,
            Hell_dungeon = 5,
            Max,
        };


        enum StageType
        {
            None = 0,

            Field = 1,
            SingleField = 2,
            MockBattleField = 6, // sparring (mock battle)

            EliteField = 11, // Elite
            Labyrinth = 12, // Labyrinth
            UnderWorld = 13, // Underworld
            HiddenPath = 14, // Secret Field = 1, similar to the properties
            SiegeBattleField = 21, // Siege
                                   //#ifdef DEF_PLUNDER_BY_AUTULN_20211028
            PlunderBattleField = 31, // Plunder Battle Map
                                     //#endif // DEF_PLUNDER_BY_AUTULN_20211028
            WorldBossField = 51,
            Guild_Expedition_dungeon = 52, // Guild Expedition Clan Expedition Stage
            Guild_Challenge_Dungeon = 53, // Guild Challenge Stage
            Boss_dungeon = 101, // Bosstoval
            Party_dungeon = 102, // Party Conquest
            Magic_square = 103, // Magic Square
            Secret_Dungeon = 104, // Secret Dungeon (=Bijeongbong)
            ArenaPvP = 105, // Arena
            Magic_square_StartMap = 106, // Magic Square Start Map

            //#ifdef DEF_BLACK_DRAGON_DUNGEON_20220307
            Black_Dragon_Gungeon = 110, // Tower of the Black Dragon
                                        //#endif //DEF_BLACK_DRAGON_DUNGEON_20220307

            //#ifdef DEF_HELL_DUNGEON_20220427
            Hell_dungeon = 120,
            //#endif
            HairSalon = 200, // Hair Salon

            DungeonScriptTestMap = 251,
        };

        public enum GachaType
        {
            SkillTome = 1,
            
            DragonLeather = 4,
            LegendarySpirit = 13,
            DragonSphere = 14,
            LegenarySpiritTreasureEvent = 502,
        }

        public enum CurrencyType
        {
            Gold = 4,
            Copper = 11,
            Darksteel = 12,
        }


    }
}
