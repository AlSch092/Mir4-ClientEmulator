//By AlSch092 @ Github
﻿
namespace Mir4ClientEmulator.Game
{
    public class WarpLocation
    {
        public string Name { get; set; }
        public int WarpId { get; set; }
        public int Arrival_StageId { get; set; }
        public string Coordinate { get; set; } //todo: change back to vector3 once fixing formatting
        public float RotationYaw { get; set; }
        public float CameraYaw { get; set; }
        public float CameraPitch { get; set; }
        public float CameraDistance { get; set; }
        public int WarpArrivalRadius { get; set; }

        public static string GetZoneNameFromStageId(long stageId)
        {
            return "";
        }
    }
}
