//By AlSch092 @ Github
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mir4ClientEmulator.Network.WebLogin.JSON
{
    public class LoginCheck
    {
        public string Code { get; set; }
        public string PlayerKey { get; set; }
        public string CSKey { get; set; }
        public string TokenID { get; set; }
        public string DeviceID { get; set; }
        public string LinkID { get; set; }
        public bool isLinkPW { get; set; }
        public bool isGoogleLinked { get; set; }
        public bool isFacebookLinked { get; set; }
        public bool isAppleLinked { get; set; }
        public bool isSteamLinked { get; set; }
        public bool isNewUser { get; set; }
        public bool IsPushAgree { get; set; }
        public bool IsNightPushAgree { get; set; }
        public string LanguageCode { get; set; }
        public string AgreeTermsDT { get; set; }
        public bool isHumanVerified { get; set; }
    }
}
