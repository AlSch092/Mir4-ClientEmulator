//By AlSch092 @ Github
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mir4ClientEmulator.Game
{
    public class LiveServers
    {
        public string ASIA1 { get; set; }
        public string ASIA2 { get; set; }
        public string ASIA3 { get; set; }
        public string ASIA4 { get; set; }
        public string ASIA5 { get; set; }
        public string ASIA6 { get; set; }
        public string ASIA7 { get; set; }
        public string NA1 { get; set; }
        public string NA2 { get; set; }
        public string EU1 { get; set; }
        public string SA1 { get; set; }
        public string SA2 { get; set; }
        public string INMENA1 { get; set; }
    }

    public class Data
    {
        public string FrontServerURL { get; set; }
        public string FrontServerList { get; set; }
        public string PaymentServerURL { get; set; }
        public string EventServerURL { get; set; }
        public string AuthServerURL { get; set; }
        public string MaintenanceURL { get; set; }
        public string ServiceURL { get; set; }
        public string PrivacyURL { get; set; }
        public string OperationURL { get; set; }
        public string SubscriptionURL { get; set; }
        public string CommunityURL { get; set; }
        public string CustomerURL { get; set; }
        public string CSURL { get; set; }
        public string ReportTyposURL { get; set; }
        public string GameguideURL { get; set; }
        public string HelpURL { get; set; }
        public string CouponURL { get; set; }
        public string OneStoreLogOutURL { get; set; }
        public string PolicyURL { get; set; }
        public string HotAndNewURL { get; set; }
        public string FrontBannerURL { get; set; }
        public string ProfileURL { get; set; }
        public string ImgUploadURL { get; set; }
        public string IOSConsumeURL { get; set; }
        public string HumanAuthURL { get; set; }
        public string StoreURL { get; set; }
        public string WemixWebAuthURL { get; set; }
        public string WemixOAuthURL { get; set; }
        public string WemixRedirectURL { get; set; }
        public string SteamAuthURL { get; set; }
        public string AdUnitAndroid { get; set; }
        public string AdUnitiOS { get; set; }
        public bool isGuestLoginAllowed { get; set; }
        public bool IsGameJoin { get; set; }
        public bool IsMantenance { get; set; }
        public int UpdateStatus { get; set; }
        public bool IsWhiteList { get; set; }
        public string MaintenanceList { get; set; }
        public string IsGameJoinList { get; set; }
    }

    public class ServerData
    {
        public Data Data { get; set; }
        public string Code { get; set; }
        public string Msg { get; set; }
    }
}
