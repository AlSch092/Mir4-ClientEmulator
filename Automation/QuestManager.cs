//By AlSch092 @ Github
﻿using Mir4.Game.Quest;
using Mir4ClientEmulator.Network;
using Mir4ClientEmulator.Network.Packets.Messages;
using Mir4ClientEmulator.Utilities;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading;
using System.Windows.Forms;

namespace Mir4.Scripter
{
    public class QuestManager
    {
        public bool AutoQuesting { get; set; }
       
        public List<_character_quest> QuestList { get; set; } //quests we are completing 
        public List<int> CompletedQuestIds { get; set; }

        public List<Quest> QuestInfo { get; set; } //from CSVs

        public Quest CurrentQuest { get; set; }

        public Thread worker { get; set; }

        public Client MirClient { get; set; }

        public QuestManager(Client c) 
        {
            AutoQuesting = false;
            QuestList = new List<_character_quest>();
            CompletedQuestIds = new List<int>();
            CurrentQuest = null;
            MirClient = c;

            try
            {
                QuestInfo = CSVSerializer.DeserializeCsv<Quest>("Data/csv/QUEST_001.csv"); //todo: add all other csv files into this same list
            }
            catch(FileNotFoundException e)
            {
                MessageBox.Show("[INFO] Unable to find Data/csv/QUEST_001.csv, this error is non-critical but may impact questing functionality");
            }
        }

        //public void FormEntireQuestList() //entire game quest lists, thousands of list elements
        //{
        //    List<Quest> QuestInfo_001 = CSVSerializer.DeserializeCsv<Quest>("Data/csv/QUEST_001.csv");
        //    List<Quest> QuestInfo_002 = CSVSerializer.DeserializeCsv<Quest>("Data/csv/QUEST_002.csv");
        //    List<Quest> QuestInfo_011 = CSVSerializer.DeserializeCsv<Quest>("Data/csv/QUEST_011.csv");
        //    List<Quest> QuestInfo_012 = CSVSerializer.DeserializeCsv<Quest>("Data/csv/QUEST_012.csv");
        //    List<Quest> QuestInfo_013 = CSVSerializer.DeserializeCsv<Quest>("Data/csv/QUEST_013.csv");
        //    List<Quest> QuestInfo_021 = CSVSerializer.DeserializeCsv<Quest>("Data/csv/QUEST_021.csv");
        //    List<Quest> QuestInfo_022 = CSVSerializer.DeserializeCsv<Quest>("Data/csv/QUEST_022.csv");
        //    List<Quest> QuestInfo_031 = CSVSerializer.DeserializeCsv<Quest>("Data/csv/QUEST_031.csv");
        //}

        public Quest GetQuest(_character_quest q)
        {
            Quest quest = new Quest();

            foreach (Quest _quest in QuestInfo.ToList())
            {
                if (q.QuestIndex == _quest.QuestId)
                {
                    quest = _quest;
                    return quest;
                }
            }

            return null;
        }

        public void AutoQuest() //thread worker
        {
            AutoQuesting = true;

            while (AutoQuesting)
            {
                while (!MirClient.m_GameSocket.Connected)
                    Thread.Sleep(7000);

                while (!MirClient.ReadyInGame)
                    Thread.Sleep(7000);

                MessageWrapper.CLIENT_GAME_CHARACTER_QUEST(MirClient, MirClient.GameAccount.character_identifier);

                Thread.Sleep(2000);

                foreach (_character_quest q in QuestList.ToList())
                {
                    if (!MirClient.m_GameSocket.Connected)
                        Thread.Sleep(10000);

                    Quest quest = GetQuest(q);

                    if(quest != null)
                    {
                        CompleteQuest(quest);
                    }
                }

                if(QuestList.Count == 0)
                {
                    Console.WriteLine("[ERROR] No quests detected!");
                    Thread.Sleep(5000);
                }
            }
        }

        public int GetMissionType(int quest_index)
        {
            int missionType = 0;

            foreach (Quest quest in QuestInfo.ToList())
            {
                if(quest_index == quest.QuestId)
                {
                    missionType = quest.MissionType;
                    break;
                }
            }

            return missionType;
        }

        public int GetSubquestMissionType(int quest_index)
        {
            int missionType = 0;
            bool foundIndex = false;

            foreach (Quest quest in QuestInfo.ToList())
            {
                if (quest_index == quest.QuestId)
                {
                    missionType = quest.MissionType;
                    foundIndex = true;
                    continue;
                }

                if(foundIndex) //this should execute on n+1 of quest_index row
                {
                    missionType = quest.MissionType;
                    break;
                }
            }

            return missionType;
        }

        public int GetSubquestMissionTarget(int quest_index)
        {
            int missionTarget = 0;
            bool foundIndex = false;

            foreach (Quest quest in QuestInfo.ToList())
            {
                if (quest_index == quest.QuestId)
                {
                    missionTarget = quest.MissionTarget;
                    foundIndex = true;
                    continue;
                }

                if (foundIndex) //this should execute on n+1 of quest_index row
                {
                    missionTarget = quest.MissionType;
                    break;
                }
            }

            return missionTarget;
        }

        public void ProcessStartScript(_character_quest q)
        {
            Quest quest = GetQuest(q);

            if(quest == null)
            {
                Console.WriteLine("[ERROR] quest was null @ ProcessStartScript");
                return;
            }

            if (quest.StartScript != null)
            {
                string[] script_steps = quest.StartScript.Split('/');

                if (script_steps != null)
                {
                    foreach (string step in script_steps)
                    {
                        if(step.Contains("SMALLTALK"))
                        {
                            Console.WriteLine("Sending CLIENT_GAME_QUEST_ACTION: {0}, {1}, {2}", quest.QuestId, Convert.ToInt32(quest.MissionType), quest.MissionTarget);
                            MessageWrapper.CLIENT_GAME_QUEST_ACTION(MirClient, quest.QuestId, Convert.ToInt32(quest.MissionType), quest.MissionTarget);
                            Thread.Sleep(2000);
                        }
                        else if(step.Contains("PCWARP"))
                        {
                            //_vector3 quest_pos = CSVSerializer.ParseVector3(quest.MissionCoordinate);
                            //MessageWrapper.CLIENT_GAME_MOVE_QUEST_POS(MirClient, quest.QuestId, quest_pos); //not sure if needed
                        }
                    }
                }           
            }
        }

        public void Action_Complete(Quest quest)
        {
            MessageWrapper.CLIENT_GAME_QUEST_ACTION(MirClient, quest.QuestId, quest.MissionType, quest.MissionTarget);
            Thread.Sleep(1000);
            MessageWrapper.CLIENT_GAME_COMPLETE_QUEST(MirClient, quest.QuestId, quest.MissionType);
            Thread.Sleep(1000);
        }

        public void Action_Complete(int questId, int missionType, int missionTarget)
        {
            MessageWrapper.CLIENT_GAME_QUEST_ACTION(MirClient, questId, missionType, missionTarget);
            Thread.Sleep(1000);
            MessageWrapper.CLIENT_GAME_COMPLETE_QUEST(MirClient, questId, missionType);
            Thread.Sleep(1000);
        }

        public void Action_Complete_Linked(Quest quest, int missionType, int missionTarget)
        {
            Action_Complete(quest);
            Thread.Sleep(1000);
            MessageWrapper.CLIENT_GAME_QUEST_ACTION(MirClient, quest.QuestId, missionType, missionTarget); //todo: make func to read 1 row below current quest (these have '0' as ID)
            Thread.Sleep(1000);
            MessageWrapper.CLIENT_GAME_COMPLETE_QUEST(MirClient, quest.QuestId, missionType);
            Thread.Sleep(1000);
        }

        public bool CompleteQuest(Quest quest) //use QUEST_XXX.csv
        {
            CurrentQuest = quest;

            switch (quest.QuestId)
            {
                case 100000000:
                case 100000010: //walk to blue circle
                case 100000020: //Dark secret passage: 1. Go to yiun -> walk into blue circle
                case 100000030:
                case 100000035:
                case 100000040: //cinematic thing, logging into this auto-completed it
                case 100000050:
                case 100000100:
                case 100000200:
                    Action_Complete(quest);
                    break;
                
                case 100000300: //has 2 states, "6. Go down the cliff (Air walk), then 7. Rescue Brother from danger                   
                    Action_Complete_Linked(quest, 84, 10025);
                    break;

                case 100000400:
                    Action_Complete(quest);
                    break;

                case 100000500: //0. Defeat Bats in Cavern Bloom  -> need walk/teleport over to  (-7000, 2500, 3660), enable auto attack and check QUEST_COUNTER updates

                    _vector3 bats_pos = new _vector3();
                    bats_pos.x = -7000.0f; bats_pos.y = 2500.0f; bats_pos.z = 3660.0f;

                    MirClient.Bot.Teleport(MirClient.Bot.Position, bats_pos);
                    Thread.Sleep(2000);
                    
                    //if(MirClient.Bot.attack_worker != null)
                    //{
                        if (MirClient.Bot.attack_worker.ThreadState != ThreadState.Running)
                        {
                            //TODO: auto attacking needs to go here, then be exited after quest is completed
                            MirClient.Bot.MaxRadius = 10000.0f;
                            MirClient.Bot.AutoAttacking = true;
                            MirClient.Bot.attack_worker = new Thread(new ThreadStart(MirClient.Bot.AttackMonstersWithinRange)); //need to focus specific monster ID?
                            MirClient.Bot.attack_worker.Start(); //kill thread on quest complete?
                        }
                    //}
                    break;

                case 100000700: //10. Collect Cavern bloom sap -> loot object_id 100001007

                    _vector3 obj_pos = new _vector3();
                    obj_pos.x = -9900.0f; obj_pos.y = 3610.0f; obj_pos.z = 4128.0f;

                    MirClient.Bot.Teleport(MirClient.Bot.Position, obj_pos);
                    Thread.Sleep(2000);
                    
                    MirClient.Bot.CollectObjectId(100001007);
                    Thread.Sleep(3000);
                    MessageWrapper.CLIENT_GAME_COMPLETE_QUEST(MirClient, quest.QuestId, quest.MissionType);
                    Thread.Sleep(500);
                    break;

                case 100000750: //cinematic with boss fight
                    Action_Complete_Linked(quest, 84, 10026);
                    break;

                case 100001300:
                case 100001400:
                case 100001500: //switches to bicheon castle underground jail -> might need to fix this
                case 100001600:
                case 100001700:
                case 100001800:
                case 100001850:
                case 100001900:
                case 100001930:
                case 100001940:
                case 100001950:
                case 100002000:
                case 100002100:
                case 100002300:
                case 100002450:
                    Action_Complete(quest);
                    break;

                case 100002330:
                case 100002350:
                    Action_Complete_Linked(quest, GetSubquestMissionType(quest.QuestId), GetSubquestMissionTarget(quest.QuestId));
                    break;

                case 100002480: //open the jail door -> teleport to -2511, 8753, 1418, loot 100002004
                    _vector3 door_pos = new _vector3();
                    door_pos.x = -2511.0f; door_pos.y = 8753.0f; door_pos.z = 1418.0f;

                    MirClient.Bot.Teleport(MirClient.Bot.Position, door_pos);
                    Thread.Sleep(2000);

                    MirClient.Bot.CollectObjectId(100002004);
                    Thread.Sleep(3000);
                    MessageWrapper.CLIENT_GAME_COMPLETE_QUEST(MirClient, quest.QuestId, quest.MissionType);
                    Thread.Sleep(500);
                    break;

                case 100002500:

                    //need teleport to object
                    _vector3 obj_pos1 = new _vector3();
                    obj_pos1.x = 13000.0f; obj_pos1.y = 9960.0f; obj_pos1.z = 100.0f;

                    MirClient.Bot.Teleport(MirClient.Bot.Position, obj_pos1);
                    Thread.Sleep(2000);
                    MirClient.Bot.CollectObjectId(100002005);
                    Thread.Sleep(3000);
                    MessageWrapper.CLIENT_GAME_COMPLETE_QUEST(MirClient, quest.QuestId, quest.MissionType);
                    Thread.Sleep(1000);
                    break;

                case 100002550: //has two substeps/rows after
                    Action_Complete_Linked(quest, GetSubquestMissionType(quest.QuestId), GetSubquestMissionTarget(quest.QuestId));
                    Action_Complete(quest.QuestId, 84, 10032);
                    break;

                case 100002600: //warp to peach blossom valley: need to check this again  ** WARNING -> BANS?
                    //_vector3 mission_coord = CSVSerializer.ParseVector3(quest.MissionCoordinate);
                    //MessageWrapper.CLIENT_GAME_WARP_USER(MirClient, (uint)quest.MissionStageId, mission_coord);

                    Action_Complete(quest);
                    break;

                case 100002700: //gets stuck here... changes to other map?
                case 100002800: //QUEST_002.csv!
                case 100002900:
                case 100002950:
                case 100003100:
                    Action_Complete(quest);
                    break;

                case 100003110: //wooden dummies 0/4
                   //_vector3 dummies_loc = new _vector3(-13036.0f, -10521.0f, 8829.0f);
                    break;

                case 101001000: //Shadow of darkness: Collect mushrooms
                    break;

                case 101001100: //Shadow of darkness: Talk to herbalist Hong
                    break;

                case 101001200: //Shadow of darkness: 15. walking to marker
                    break;

                case 101001205: //Shadow of darkness: 16. Talk to cheomseung
                    break;

                default:
                    Console.WriteLine("[WARNING] Unsupported quest found at CompleteQuest: {0}", quest.QuestId);
                    break;
            };

            Thread.Sleep(1000);

            return true;
        }
    }
}
