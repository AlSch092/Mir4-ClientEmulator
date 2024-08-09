//By AlSch092 @ Github
﻿using System.Collections.Generic;

namespace Mir4ClientEmulator.Game
{
    public class Portal
    {
        public string Name { get; set; }
        public int PortalTriggerId { get; set; }
        public int CurrentStageId { get; set; }
        public int WarpId { get; set; }
        public int ArrivalStageId { get; set; }
    
        public int PositionNearPortalCheck { get; set; }

        public string PositionNearPortal { get; set; } //_vector3

        public int PortalStageType { get; set; }

        public int EnableLevel { get; set; }

        public int EnableGreatBuildingID { get; set; }

        public int EnableBuildingStep { get; set; }

        public int EnableDoingQuestType { get; set; }
        public List<int> EnableDoingQuest { get; set; }
        public int EnableCompleteQuestType { get; set; }
        public int EnableCompleteQuest { get; set; }
        public int EnableAchievement { get; set; }

        public int EnableDoingBuff { get; set;}

        public int ContentsAdminInfoId { get; set;}

        public int Weigth { get; set; }
    }
}
