//By AlSch092 @ Github
﻿using Mir4.Game;
using Mir4.Scripter;
using Mir4ClientEmulator.Game;
using Mir4ClientEmulator.Network;
using Mir4ClientEmulator.Network.Packets;
using Mir4ClientEmulator.Network.Packets.Messages;
using Mir4ClientEmulator.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

namespace Mir4ClientEmulator.Scripter
{
    public class Automation
    {
        private Client client;
        public Thread worker;
        public Thread attack_worker;

        public Stats PlayerStats { get; set; }

        public bool FoundCollectableObject { get; set; } //make gathering class

        public List<Entity> EntityList { get; set; }
        public Dictionary<long, int> DesiredGatheringIds { get; set; } //maps object to PRIORITY

        public bool AutoGathering { get; set; } //gathering includes mining,  herbs,  darksteel , chests
        public int GatheringType { get; set; } //todo: put gathering into its own class      
        public bool CurrentlyCollecting { get; set; }
        public int ObjectsGathered { get; set; }
        public int MinimumGatheringPriority { get; set; }
        public ulong CurrentObjectGathering { get; set; }

        public bool AutoAttacking { get; set; }
        public ulong CurrentlyAttacking { get; set; }

        public uint TargetStageID { get; set; }
        public float MaxRadius { get; set; }
        public bool IsDead { get; set; }
        public bool InParty { get; set; }
        public bool AutoJoinParties { get; set; }
        public ulong PartyUID { get; set; }
      
        public Dictionary<int, int> SkillList { get; set; } //index to level, sent by server

        public List<Skill> SkillData { get; set; }
        public List<SkillAttack> SkillAttackData { get; set; }
        public Dictionary<ulong, string> CharacterIds { get; set; }

        public _vector3 Position { get; set; }

        public _vector3 LastAlivePosition { get; set; } //if reviving, teleport back here
        
        public _vector3 Direction { get; set; }

        public List<_character_inven_item> QuickSlot { get; set; }

        public List<_character_inven_item> PlayerInventory { get; set; }

        public List<_character_inven_item> WarehouseInventory { get; set; }

        public Potion Potions { get; set; }

        public List<NamedStage> MapNames { get; set; }

        public List<Stage> Stages { get; set; } //maps
        public List<WarpLocation> WarpLocations { get; set; } 
        public List<Portal> Portals { get; set; }

        public QuestManager QuestManager { get; set; }

        public List<_guild_gift_info> GuildGiftList { get; set; }

        public ulong CurrentPartyUID { get; set; } //todo: make party class


        public Automation(Client c)
        {
            client = c;

            AutoGathering = false;
            FoundCollectableObject = false;
            CurrentlyCollecting = false;
            CurrentObjectGathering = 0;
            ObjectsGathered = 0;
            
            InParty = false;
            
            QuestManager = new QuestManager(this.client);
            
            EntityList = new List<Entity>();
       
            Potions = new Potion();
            PlayerStats = new Stats();

            MapNames = new List<NamedStage>();
            MapNames = CSVSerializer.DeserializeCsv<NamedStage>("Data/csv/MAP.csv");

            SkillList = new Dictionary<int, int>();
            SkillData = CSVSerializer.DeserializeCsv<Skill>("Data/csv/SKILL.csv");
            SkillAttackData = CSVSerializer.DeserializeCsv<SkillAttack>("Data/csv/SKILL_ATTACK.csv");

            WarpLocations = CSVSerializer.DeserializeCsv<WarpLocation>("Data/csv/WARP_LOCATION.csv");
            Portals = CSVSerializer.DeserializeCsv<Portal>("Data/csv/PORTAL.csv");
            Stages = CSVSerializer.DeserializeCsv<Stage>("Data/csv/STAGE.csv");

            Position = new _vector3();
            Direction = new _vector3();

            QuickSlot = new List<_character_inven_item>();
            PlayerInventory = new List<_character_inven_item>();
            WarehouseInventory = new List<_character_inven_item>();

            GuildGiftList = new List<_guild_gift_info>();

            DesiredGatheringIds = new Dictionary<long, int>();
            FileHelper.ReadDesiredEntitiesFile("./gathering_entities.ini", DesiredGatheringIds);

            Potions.InitializeDefaultLists();
        }
 
        public void Reset(bool shouldAutogather)
        {
            if (shouldAutogather)           
                AutoGathering = true;          
            else    
                AutoGathering = false;
            
            FoundCollectableObject = false;
            CurrentlyCollecting = false;
            CurrentlyAttacking = 0;
            CurrentObjectGathering = 0;
            Position = null;
            Direction = null;
        }

        public bool CollectObjectId(int object_id)
        {
            try
            {
                foreach (Entity ent in client.Bot.EntityList)
                {
                    if (object_id == ent.type)
                    {
                        if (ent.UsageCountsLeft == 0)
                        {
                            Console.WriteLine("Couldn't collect entity {0}, no uses left.", ent.id);
                            return false;
                        }

                        if (Entity.IsHoneypot(ent))
                        {
                            Console.WriteLine("Couldn't collect entity {0}, fake object detected.", ent.id);
                            return false;
                        }
                        else
                        {
                            Teleport(client.Bot.Position, ent.Position);
                            Thread.Sleep(1000);

                            //attempt collect object
                            MessageWrapper.CLIENT_GAME_START_CASTING(client, client.GameAccount.character_identifier, 1, ent.id, 0, 0, true);
                            Console.WriteLine("Attempted collection of entity {0}, {1} uses left.", ent.id, ent.UsageCountsLeft);

                            return true;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("[ERROR] Some network or object error occured when collecting entity: {0}", ex.Message);
                return false;
            }

            return false;
        }

        public _vector3 GetGatheringZoneInStage(uint stageId, int gathering_type) //0 == mining, 1 == herb, 2 == energy
        {     
            if (Stages == null)
                return null;

            _vector3 loc = null;

            foreach (Stage stage in Stages)
            {
                if(stageId == stage.Name)
                {
                    switch (gathering_type)
                    {
                        case 0:
                            if (stage.MiningZone != null)
                                loc = CSVSerializer.ParseVector3(stage.MiningZone);
                            break;

                        case 1:
                            if (stage.GatheringZone != null)
                                loc = CSVSerializer.ParseVector3(stage.GatheringZone);
                            break;

                        case 2:
                            if (stage.SpiritZone != null)
                                loc = CSVSerializer.ParseVector3(stage.SpiritZone);
                            break;

                        default:
                            loc = null;
                            break;
                    }

                    if (loc.x == 0.00f && loc.y == 0.00f && loc.z == 0.00f)
                        return null;

                    return loc;
                }
            }

            return null;
        }

        public void UnstuckCharacter()
        {
            MessageWrapper.CLIENT_GAME_START_CASTING(client, client.GameAccount.character_identifier, 6, 0, 0, 0, false);
        }

        public int GetNextSkillId(int attackId)
        {
            int nextSkillId = 0;

            foreach (Skill s in this.SkillData)
            {
                if(s.SkillId == attackId)
                {
                    if (s.NextNormalSkilLink == "(0)")
                        return 0;
                    
                    try
                    {
                        string next_skill_str = s.NextNormalSkilLink;

                        next_skill_str = next_skill_str.Remove(0, 1); //remove '('
                        next_skill_str = next_skill_str.Remove(next_skill_str.IndexOf(')'), 1);

                        string[] skill_list = next_skill_str.Split(',');
                        
                        if(skill_list != null) //multiple skill stages, which to pick?
                        {
                            if(skill_list.Length >= 2 )
                            {
                                nextSkillId = Convert.ToInt32(skill_list[0]);
                            }
                            else
                                nextSkillId = Convert.ToInt32(skill_list[0]);
                        }
                        else
                            nextSkillId = Convert.ToInt32(next_skill_str); //might be multiple/list
                    }
                    catch(Exception e)
                    {
                        Console.WriteLine("[ERROR] Failed to get next attack id: Conversion exception ({0})", e.Message);
                        return 0;
                    }              
                }
            }

            return nextSkillId;
        }

        public int GetAttackIdFromSkill(Skill skill)
        {
            foreach(SkillAttack sa in this.SkillAttackData)
            {
                if (sa.SkillId == skill.SkillId)
                    return sa.AttackId;
            }

            return 0;
        }

        public int GetAttackIdFromSkill(int skill)
        {
            foreach (SkillAttack sa in this.SkillAttackData)
            {
                if (sa.SkillId == skill)
                    return sa.AttackId;
            }

            return 0;
        }

        public Skill GetSkillFromSkillId(int skillId)
        {
            foreach (Skill s in this.SkillData)
            {
                if (s.SkillId == skillId)
                    return s;
            }

            return null;
        }

        public SkillAttack GetSkillFromAttackId(int attackId)
        {
            foreach (SkillAttack s in this.SkillAttackData)
            {
                if (s.AttackId == attackId)
                    return s;
            }

            return null;
        }



        public void UseSkill(int skillId, int state, _vector3 loc_start, _vector3 loc_end, _attack_target_info[] targets_list, _vector3 attack_direction, _monster_parts_info[] parts_list)
        {
            int added_delay_ms = 500;

            if (client.Bot.IsDead)
            {
                Console.WriteLine("[ERROR] Can't atack, player is dead!");
                return;
            }
              
            Skill s = GetSkillFromSkillId(skillId);
            
            if(s == null)
            {
                Console.WriteLine("[ERROR] Could not get skill from skill id: {0}", skillId);
                return;
            }

            int attackId = GetAttackIdFromSkill(skillId);

            client.m_session.SendPacket(Factory.CLIENT_GAME_ATTACK(state, skillId, attackId, loc_start, loc_end, targets_list, attack_direction, 0, parts_list));
            Thread.Sleep((int)(s.AttackAniTime * 1000) + added_delay_ms);

            int next_skill_Id = GetNextSkillId(skillId);

            while (next_skill_Id != 0)
            {
                if (CurrentlyAttacking != targets_list[0].targetid) //target was killed while using skills
                    break;

                Skill s_next = GetSkillFromSkillId(next_skill_Id);

                if (s_next != null)
                {
                    int next_attack_id = GetAttackIdFromSkill(next_skill_Id);
                    client.m_session.SendPacket(Factory.CLIENT_GAME_ATTACK(state, next_skill_Id, next_attack_id, loc_start, loc_end, targets_list, attack_direction, 0, parts_list));
                    Thread.Sleep((int)(s_next.AttackAniTime * 1000) + added_delay_ms); //attack delay
                    next_skill_Id = GetNextSkillId(next_skill_Id);
                }
                else
                    break;
            }
        }

        public void Teleport(_vector3 current_pos, _vector3 dest_pos)
        {
            if (current_pos.x == dest_pos.x && current_pos.y == dest_pos.y && current_pos.z == dest_pos.z)
                return;

            _vector3 direction = new _vector3();
            direction.x = 0.1f; direction.y = 0.1f; direction.z = 0.0f;

            client.m_session.SendPacket(Factory.CLIENT_GAME_SYNC_USER(current_pos, direction, 750.0f, MovementStates.AutoMove, 0, 0, current_pos, current_pos));
            Thread.Sleep(1000);
            client.m_session.SendPacket(Factory.CLIENT_GAME_SYNC_USER(dest_pos, direction, 750.0f, MovementStates.Stop, 0, 0, dest_pos, dest_pos));
            Thread.Sleep(2000);
            client.Bot.Position = dest_pos;
        }

        public void TeleportRandomWaypoint(uint stageID) //..or, traverse waypoint list and pick randomly from same map
        {           
            switch (stageID)
            {
                case 103003010: //snake pit
                    _vector3 map_top = new _vector3(); 
                    map_top.x = 11000.0f; map_top.y = 1500.0f; map_top.z = 1150.0f; //todo: better solution, some mapping somewhere

                    Teleport(client.Bot.Position, map_top);
                    break;

                case 103003070: //viperbeast plain
                    _vector3 map_middle = new _vector3();
                    map_middle.x = 5000.0f; map_middle.y = 0.0f; map_middle.z = 3000.0f;

                    _vector3 map_bottom = new _vector3();
                    map_bottom.x = 5000.0f; map_bottom.y = -15000.0f; map_bottom.z = 3000.0f;

                    Teleport(client.Bot.Position, map_bottom);
                    break;

            };
        }

        public void TeleportToMap(uint stageID) //..or, traverse waypoint list and pick randomly from same map
        {
            uint tele_id = Stage.GetWaitingWarpLocation(this.Stages, stageID);

            if(tele_id != 0)
            {
                MessageWrapper.CLIENT_GAME_START_CASTING(client, client.GameAccount.character_identifier, 3, tele_id, 0, 0, false);
            }
        }

        public int GetStageIdFromName(string name)
        {
            if (this.MapNames == null)
                return 0;

            int stageId = 0;


            foreach(NamedStage s in MapNames)
            {
                if(s.StageNameSID == name)
                {
                    stageId = s.StageID;
                }
            }

            return stageId;
        }

        public string GetStageNameFromId(int id)
        {
            if (this.MapNames == null)
                return null;

            string stageName = null;

            foreach (NamedStage s in MapNames)
            {
                if (s.StageID == id)
                {
                    stageName = s.StageNameSID;
                    break;
                }
            }

            return stageName;
        }

        public void TeleportToMap(string stage) //..or, traverse waypoint list and pick randomly from same map
        {
            uint stageId = 0;

            stageId = (uint)GetStageIdFromName(stage);

            Console.WriteLine("Stage id: {0}", stageId);

            if(stageId != 0)
                TeleportToMap(stageId);
        }

        public void TeleportGatheringZone(uint stageID, int collection_type) //..or, traverse waypoint list and pick randomly from same map
        {
            _vector3 gathering_zone = GetGatheringZoneInStage(stageID, collection_type);

            if(gathering_zone != null)
            {
                Teleport(client.Bot.Position, gathering_zone);
            }
        }

        public bool HasGatheringZone(uint stageID)
        {
            if (Stages == null)
                return false;

            foreach (Stage stage in Stages)
            {
                if (stageID == stage.Name)
                {
                    if (stage.GatheringZone != null)
                    {
                        
                        _vector3 loc = CSVSerializer.ParseVector3(stage.GatheringZone);

                        if (loc != null)
                            return true;
                    }
                }
            }

            return false;
        }
        
        public void MovePlayer(_vector3 current_pos, _vector3 dest_pos)
        {
            _vector3 direction = new _vector3 { x = 0.99999f, y = -0.005f };

            _vector3[] path = Geometry.SplitVector(current_pos, dest_pos, 4);
            _vector3 current_updated_pos = current_pos;

            if (path != null)
            {
                for (int i = 0; i < path.Length; i++)
                {
                    client.m_session.SendPacket(Factory.CLIENT_GAME_SYNC_USER(current_updated_pos, direction, 750.0f, MovementStates.AutoMove, 0, 0, path[i], path[i]));
                    Thread.Sleep(1000);
                    current_updated_pos = path[i];
                    client.Bot.Position = current_updated_pos;
                }
            }

            //move, then stop moving (teleport)
            client.m_session.SendPacket(Factory.CLIENT_GAME_SYNC_USER(current_updated_pos, direction, 750.0f, MovementStates.Stop, 0, 0, dest_pos, dest_pos));
            Thread.Sleep(1000);
            client.Bot.Position = dest_pos;
        }

        public ulong GetHighestPriorityObjectId() //needs testing, possibly change this to a list of ids with highest priority at start, then try to loot each member in list
        {
            ulong desired_uid = 0;

            List<Entity> valid_entities_list = new List<Entity>();
            
            Entity highest_priority = null;
            int max_pri_found = 0;

            foreach (Entity ent in client.Bot.EntityList.ToList())
            {
                if (DesiredGatheringIds.ContainsKey(ent.type)) //entity found is in desired list
                {
                    if (ent.UsageCountsLeft == 0 || ent.UsageCountsMax == 0 || ent.UsageCountsLeft > ent.UsageCountsMax || Entity.IsHoneypot(ent)) //unsuitable ent                    
                        continue;
                   
                    int priority = DesiredGatheringIds[ent.type];

                    if(priority > max_pri_found)
                    {
                        max_pri_found = priority;
                        highest_priority = ent;
                    }                
                }
            }

            if(highest_priority != null)
            {
                desired_uid = highest_priority.id;
                return desired_uid;
            }

            return 0;
        }

        public void Gather()
        {
            bool gathering  = true;
            bool no_good_ents = true;

            Console.WriteLine("[INFO] Starting gathering in 3 seconds...");
            Thread.Sleep(3000); //remove this 

            while (gathering)
            {
                if (client.m_GameSocket == null)
                    return;

                if (CurrentlyCollecting)
                {
                    Thread.Sleep(8000);
                    continue; 
                }

                if(!client.m_GameSocket.Connected)
                {
                    CurrentlyCollecting = false;
                    Thread.Sleep(10000);
                    continue;
                }

                try
                {
                    ulong id = GetHighestPriorityObjectId(); //best way to do this is make a descending list of IDs, loop over this list and try to loot. if loot is success, wait until switching object then re-make list
                    Console.WriteLine("Highest priority found: {0}", id);

                    foreach (Entity ent in client.Bot.EntityList.ToList())
                    {
                        if (!client.m_session.Connected)
                        {
                            Console.WriteLine("Can't gather, was disconnected.");
                            return;
                        }

                        if (ent == null || client.Bot.CurrentlyCollecting || CurrentObjectGathering != 0)
                            continue;

                        if (DesiredGatheringIds.ContainsKey(ent.type))
                        {
                            if (ent.UsageCountsLeft == 0 || ent.UsageCountsMax == 0)
                            {
                                continue;
                            }

                            if(Entity.IsHoneypot(ent))
                            {
                                Console.WriteLine("Possible honeypot detected at ID {0} (Position {1},{2},{3}) ", ent.id, ent.Position.x, ent.Position.y, ent.Position.z);
                                ent.IsHoneyPot = true;
                                continue;                   
                            }

                            no_good_ents = false; //found something suitable to gather
                         
                            Teleport(client.Bot.Position, ent.Position); //move to object
                            
                            //attempt collect object
                            client.m_session.SendPacket(Factory.CLIENT_GAME_START_CASTING(client.GameAccount.character_identifier, ent.id, 1, 0, true));
                            Console.WriteLine("Attempted collection of entity {0}, {1} uses left.", ent.id, ent.UsageCountsLeft);
                            Thread.Sleep(3000);

                            if(ent.UsageCountsLeft == 0)
                            {
                                CurrentlyCollecting = false;
                                CurrentObjectGathering = 0;
                            }
                        }
                    }

                    if(no_good_ents) //todo: add in current map checking + teleporting to waypoints
                    {
                        Console.WriteLine("No entities nearby suitable for gathering!"); //what do we do here? checkbox wil be ticked with zero action
                        
                        if(HasGatheringZone(client.GameAccount.StageID))
                        {
                            TeleportGatheringZone(client.GameAccount.StageID, client.Bot.GatheringType);
                        }
                        else
                        {
                            TeleportRandomWaypoint(client.GameAccount.StageID);
                        }
           
                        Thread.Sleep(2000);
                        continue;
                    }
                }
                catch(Exception ex)
                {
                    Console.WriteLine("Error at  Gather() : " + ex.Message);
                    return;
                }
            }
        }


        public void KillTarget(ulong targetuid) //uses class member MaxRadius as argument
        {
            if (client == null)
            {
                if (client.Bot == null)
                    Console.WriteLine("Client/bot was NULL at AttackMonsters!");

                Console.WriteLine("[ERROR] Can't auto-attack, client was null!");
                return;
            }

            while (AutoAttacking)
            {
                if (client.ReadyInGame)
                {
                    Skill.InitializeSkillsList(this.SkillList, (e_class)client.GameAccount.eClass);

                    while (client.m_GameSocket.Connected)
                    {
                        Entity TargetEnt = client.GetEntityFromList(targetuid);

                        if(TargetEnt == null)
                        {
                            Console.WriteLine("Could't find target entity nearby in list!");
                            return;
                        }

                        _vector3 offset_pos = new _vector3();
                        offset_pos.x = TargetEnt.Position.x; offset_pos.y = TargetEnt.Position.y; offset_pos.z = TargetEnt.Position.z + 2.0f;

                        _attack_target_info t = new _attack_target_info();
                        t.targettype = 2; //not sure, 2 == monster?
                        t.targetid = targetuid; //enemy UID

                        _monster_parts_info parts = new _monster_parts_info();
                        _attack_target_info[] t_list = new _attack_target_info[1];
                        t_list[0] = t;

                        _monster_parts_info[] parts_list = new _monster_parts_info[1];
                        parts_list[0] = parts;

                        //if distance > attacking distance, move player closer
                        MovePlayer(client.Bot.Position, TargetEnt.Position);

                        //loop until monster is dead
                        while (TargetEnt.hp > 0) //might not work due to looping inside while other thread updates
                        {
                            this.CurrentlyAttacking = TargetEnt.id;
                            _vector3 attack_direction = new _vector3();
                            attack_direction.x = 0.1f; attack_direction.y = 0.1f; attack_direction.z = 0.0f;

                            Console.WriteLine("Attacking {0} at {1}, {2}, {3}!", TargetEnt.id, TargetEnt.Position.x, TargetEnt.Position.y, TargetEnt.Position.z);

                            foreach (KeyValuePair<int, int> skill in SkillList)
                            {
                                UseSkill(skill.Key, 12, client.Bot.Position, TargetEnt.Position, t_list, attack_direction, parts_list); //might be better to put entity insted of position
                            }

                            TargetEnt = client.GetEntityFromList(targetuid);

                            if (TargetEnt == null)
                                return; 
                        }                                             
                    }
                }
                else
                {
                    while (!client.ReadyInGame)
                    {
                        Console.WriteLine("[INFO] Waiting to be in-game to auto-attack...");
                        Thread.Sleep(5000); //d/ced or busy, etc
                    }

                }
            }

            Console.WriteLine("[INFO] Ended auto-attacking!");

            if (client.UIMessages != null)
                client.UIMessages.Enqueue("[INFO] Ended auto-attacking");
        }

        public void AttackMonstersWithinRange() //uses class member MaxRadius as argument
        {
            if (client == null)
            {
                if (client.Bot == null)
                    Console.WriteLine("Client/bot was NULL at AttackMonsters!");

                Console.WriteLine("[ERROR] Can't auto-attack, client was null!");
                return;
            }

            while(AutoAttacking)
            {
                if (client.ReadyInGame)
                {
                    Skill.InitializeSkillsList(this.SkillList, (e_class)client.GameAccount.eClass);

                    while (client.m_GameSocket.Connected)
                    {
                        try
                        {
                            List<Entity> nearby = GetNearbyMonsters(this.MaxRadius);

                            if (nearby.Count == 0)
                            {
                                Console.WriteLine("No nearby monsters detected..");
                                Thread.Sleep(3000);
                                continue; //do nothing
                            }

                            foreach (Entity e in nearby.ToList())
                            {
                                if (!client.m_GameSocket.Connected)
                                {
                                    Console.WriteLine("[ERROR] Can't auto-attack, was disconnected...");
                                    return;
                                }


                                _vector3 offset_pos = new _vector3();
                                offset_pos.x = e.Position.x; offset_pos.y = e.Position.y; offset_pos.z = e.Position.z + 2.0f;

                                _attack_target_info t = new _attack_target_info();
                                t.targettype = 2; //not sure, 2 == monster?
                                t.targetid = e.id; //enemy UID

                                _monster_parts_info parts = new _monster_parts_info();
                                _attack_target_info[] t_list = new _attack_target_info[1];
                                t_list[0] = t;

                                _monster_parts_info[] parts_list = new _monster_parts_info[1];
                                parts_list[0] = parts;

                                //if distance > attacking distance, move player closer
                                MovePlayer(client.Bot.Position, e.Position);
                           
                                Entity _e = client.GetEntityFromList(e.id);
                                
                                if (_e == null)
                                {
                                    Console.WriteLine("[ERROR] Entity was NULL at AttackMonsters!");
                                    continue;
                                }

                                try
                                {
                                    //loop until monster is dead
                                    while (_e.hp > 0) //might not work due to looping inside while other thread updates
                                    {
                                        this.CurrentlyAttacking = e.id;
                                        _vector3 attack_direction = new _vector3();
                                        attack_direction.x = 0.1f; attack_direction.y = 0.1f; attack_direction.z = 0.0f;

                                        Console.WriteLine("Attacking {0} at {1}, {2}, {3}!", e.id, e.Position.x, e.Position.y, e.Position.z);

                                        foreach (KeyValuePair<int, int> skill in SkillList)
                                        {                                         
                                            UseSkill(skill.Key, 12, client.Bot.Position, _e.Position, t_list, attack_direction, parts_list); //might be better to put entity insted of position
                                        }

                                        _e = client.GetEntityFromList(e.id);

                                        if (_e == null)
                                            continue;
                                    }
                                }
                                catch(System.NullReferenceException ex)
                                {
                                    continue;
                                }
                                
                            }
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine("Could not attack monsters: " + e.Message);
                            continue;
                        }
                    }
                }
                else
                {
                    while(!client.ReadyInGame)
                    {
                        Console.WriteLine("[INFO] Waiting to be in-game to auto-attack...");
                        Thread.Sleep(5000); //d/ced or busy, etc
                    }
                        
                }
            }
           
            Console.WriteLine("[INFO] Ended auto-attacking!");

            if (client.UIMessages != null)
                client.UIMessages.Enqueue("[INFO] Ended auto-attacking");
        }

        public List<Entity> GetNearbyMonsters(float radius)
        {
            List<Entity> nearby_monsters = new List<Entity>();

            foreach(Entity e in this.EntityList.ToList())
            {
                if (e == null)
                    continue;

                if (e.hp == 0 || e.type != 2 || e.classid > 300000000 || e.type == 200000 || e.classid == 200000) //2 = npc
                    continue;
                
                if (Geometry.GetDistance(e.Position, client.Bot.Position) > radius)    
                    continue;
                
                nearby_monsters.Add(e);
            }

            return nearby_monsters;
        }

        public bool ChangeAreas(ulong zone_id)
        {

            MessageWrapper.CLIENT_GAME_START_CASTING(client, client.GameAccount.character_identifier, 3, zone_id, 0, 0, false);


            return true;
        }
 
    }
}