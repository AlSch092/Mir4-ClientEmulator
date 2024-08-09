//By AlSch092 @ Github
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mir4ClientEmulator.Game
{
    public class PatchInfos
    {
        public List<Step0> Step0 { get; set; }
        public string TargetPlatform { get; set; }
    }

    public class PatchInfoJSON
    {
        public PatchInfos PatchInfos { get; set; }
    }

    public class Step0
    {
        public string FileName { get; set; }
        public string Size { get; set; }
        public string Version { get; set; }
        public string Crc { get; set; }
    }
}
