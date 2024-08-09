//By AlSch092 @ Github
﻿using System.Collections.Generic;

namespace Mir4ClientEmulator.Game
{
    public class Stage
    {
        public int Name { get; set; }
        public int StageID { get; set; }
        public int StageType { get; set; }
        public int ChannelId { get; set; }
        public int StageNameSID { get; set; }
        public int QuestStageNameSID { get; set; }
        public int LoadingId { get; set; }
        public int ThemeID { get; set; }
        public int CameraPreset { get; set; }
        public int BlockSize { get; set; }
        public int ChaVRadius { get; set; }
        public int RevivalId { get; set; }
        public int KickRevivalId { get; set; }
        public int RestartWarpLocation { get; set; }
        public int KillZone { get; set; }
        public int StageLevel { get; set; }
        public int CombatPower { get; set; }
        public int EnableLevel { get; set; }
        public int EnableQuest { get; set; }
        public int EnableCombatPower { get; set; }
        public int EnableGreatBuildingID { get; set; }
        public int EnableBuildingStep { get; set; }
        public int EnablePkGrade { get; set; }
        public int AirWalkban { get; set; }
        public int DirectWarpAble { get; set; }
        public int BoardOnOff { get; set; }
        public int CanMeditation { get; set; }
        public int GuildSanctumId { get; set; }
        public int SummonItemUseType { get; set; }
        public int EXPPenalty { get; set; }
        public int ReturnWarpLocation { get; set; }
        public int ReturnWarpItemUseId { get; set; }
        public int DirectWarpNeedCostId { get; set; }
        public int DirectWarpNeedCostCount { get; set; }
        public int DirectWarpNeedItemId { get; set; }
        public int DirectWarpNeedItemCount { get; set; }
        public int DirectWarpNeedItemUseId { get; set; }
        public int WaitingWarpLocation { get; set; }
        public int PkOnOff { get; set; }
        public int PkOnOffNonPK { get; set; }
        public int PKGuardOff { get; set; }
        public int PKtendency { get; set; }
        public int Durability { get; set; }
        public int StageRule { get; set; }
        public int DeathPenalty_Durability { get; set; }
        public int DeathPenalty_Injure { get; set; }
        public int DeathPenalty_Steal { get; set; }
        public int DeathPenalty_StealValue { get; set; }
        public int DeathPenalty_EXP { get; set; }
        public int IconId { get; set; }
        public string MapMiniInfo { get; set; }
        public string GraphicLevel { get; set; }
        public string TriggerLevel { get; set; }
        public string Gendata { get; set; }
        public string GenDoorData { get; set; }
        public string DungeonScriptData { get; set; }
        public int SpawnDataID { get; set; }
        public int NaviMeshId_Main { get; set; }
        public int NaviMeshId_Sub01 { get; set; }
        public int IsPossibleMacroMode { get; set; }
        public int StandardPosition_X { get; set; }
        public int StandardPosition_Y { get; set; }
        public string WayPoint { get; set; }
        public string SafetyArea { get; set; }
        public string SectorGrade { get; set; }
        public int GetWayType { get; set; }
        public string GatheringZone { get; set; }
        public string MiningZone { get; set; }
        public string SpiritZone { get; set; }
        public string GetWayCoordinate { get; set; }
        public int SequenceType { get; set; }
        public int SequencePlayId { get; set; }
        public int Repeat { get; set; }
        public int DominionId_Inter { get; set; }
        public int DominionId_Siege { get; set; }
        public int DominionId_StrongPoint { get; set; }
        public int IsInterServer { get; set; }
        public int DominionId_Grade1 { get; set; }
        public int DominionId_Grade2 { get; set; }
        public int DominionId_Grade3 { get; set; }
        public int GuildWarPlunderId { get; set; }
        public int SeverVisit { get; set; }
        public int SeverVisitRevivalId { get; set; }
        public int SeverVisitNoVitality { get; set; }
        public int ConquerSeverNoVitality { get; set; }
        public int Mapmark { get; set; }
        public int Union_Zone { get; set; }
        public int GuildAltarId { get; set; }
        public int PkPenalty { get; set; }
        public int PkDeathPanalty { get; set; }
        public int PkSteal { get; set; }
        public int PkDurability { get; set; }

        public static uint GetWaitingWarpLocation(List<Stage> stages, uint stageId)
        {
            uint WaitingWarpLocation = 0;

            //WaitingWarpLocation
            foreach(Stage s in stages)
            {
                if(stageId == s.Name)
                {
                    WaitingWarpLocation = (uint)s.WaitingWarpLocation;
                    break;
                }
            }

            return WaitingWarpLocation;
        }
    }
}
