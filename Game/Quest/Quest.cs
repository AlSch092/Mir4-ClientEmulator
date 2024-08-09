//By AlSch092 @ Github
﻿namespace Mir4.Game.Quest
{
    public class Quest
    {
        public int Name { get; set; }
        public int QuestId { get; set; }
        public int QuestLevel { get; set; }
        public int StepNo { get; set; }
        public string StartScript { get; set; }
        public string EndScript { get; set; }
        public string CountSmallTalk { get; set; }
        public int MissionType { get; set; }
        public int MissionTarget { get; set; }
        public int Parameter1 { get; set; }
        public int Parameter2 { get; set; }
        public string ParameterClass { get; set; }
        public int CountIndication { get; set; }
        public double QuestTrackerType { get; set; }
        public int MissionStageId { get; set; }
        public string ViaCoordinate { get; set; }
        public string MissionCoordinate { get; set; }
        public string PhaseExitCoordinate { get; set; }
        public int SoundId { get; set; }
        public int SoundRange { get; set; }
        public int EffectId { get; set; }
        public int IconId { get; set; }
        public int ContentOpenPage { get; set; }
        public int StringMESSAGE { get; set; }
        public int AutoBattleType { get; set; }
        public int PcTargetSearchDist { get; set; }
        public int CoordinateRange { get; set; }
        public int QuestTitleSID { get; set; }
        public int QuestMissionSID { get; set; }
        public int RewardExp { get; set; }
        public int RewardGOLD { get; set; }
        public int RewardCostId { get; set; }
        public int RewardCostCount { get; set; }
        public string RewardItem01Id { get; set; }
        public int RewardItem01Count { get; set; }
        public string RewardItem02Id { get; set; }
        public int RewardItem02Count { get; set; }
        public int TutorialGroupId { get; set; }
    }
}
