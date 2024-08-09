//By AlSch092 @ Github
﻿using Mir4ClientEmulator.Game;
using Mir4ClientEmulator.Network.WebLogin.JSON;
using Newtonsoft.Json;
using System;
using System.IO;
using System.Net;
using System.Text;

namespace Mir4ClientEmulator.Network
{
    public class UltimateLogin //Ultimate Mobile kit?
    {
        private static string ServerInfo = "https://live-dl.mir4global.com/serverinfo/Steam/serverinfo.json";
        private static string IPRegion = "https://api.mir4global.com/ip/region";
        private static string LoginCheck = "https://api.mir4global.com/auth/loginCheck";
        private static string LanguageUrl = "https://api.mir4global.com/auth/language";
        private static string PrivacyUrl = "https://api.mir4global.com/auth/privacy?playerkey=";

        private const string current_version = "1.67.1.406743";

        public string PatchRootUrl { get; set; }
        public string PatchSubpath{ get; set; }
        public string WemadeServiceUrl { get; set; }
        public string WemadeServiceVersion { get; set; }

        public static int StoreType = 11; //steam
        public static string IpAddress = GenerateRandomHostname();
        public static string MacAddress = GenerateRandomMACAddress();

        public ServerInfoJSON serverInfo { get; set; }
        public ServerData serverData { get; set; }
        public RootRegionCode regionInfo { get; set; }
        public LoginCheck loginInfo { get; set; }

        public LiveServers servers { get; set; }

        public DataInfo FileDataInfo { get; set; }

        public string PlayerKey { get; set; }

        public static string GenerateRandomHostname()
        {
            Random random = new Random();

            int subnet1 = 192;
            int subnet2 = 168;
            int subnet3 = random.Next(0, 256); // Random number between 0 and 255
            int subnet4 = random.Next(0, 256); // Random number between 0 and 255
            int subnet5 = random.Next(0, 1000); // Random number between 0 and 999

            return $"{subnet1}.{subnet2}.{subnet3}.{subnet4}.{subnet5}";
        }

        public static string GenerateRandomMACAddress()
        {
            Random random = new Random();
            byte[] macAddressBytes = new byte[6];
            random.NextBytes(macAddressBytes);

            // Set the second least significant bit of the first byte to 1 (locally administered MAC address)
            macAddressBytes[0] |= 0x02;

            StringBuilder macAddressBuilder = new StringBuilder();
            for (int i = 0; i < macAddressBytes.Length; i++)
            {
                macAddressBuilder.AppendFormat("{0:X2}", macAddressBytes[i]);
            }

            return macAddressBuilder.ToString();
        }


        public string GetPlayerKey(string deviceKey, string channel, string token) //call this to start entire request process and eventually return playerKey which is what we need
        {
            if (GetServerInfo())
            {
                if (CheckVersion(this.serverInfo.BaseSetting._1671.WemadeServiceUrl, IpAddress, UltimateLogin.MacAddress))
                {
                    if (!GetPatchInfo())
                    {
                        Console.WriteLine("[ERROR] Failed to get patch info.");
                        return null;
                    }

                    if (!GetDataInfo())
                    {
                        Console.WriteLine("[ERROR] Failed to get server data info.");
                        return null;
                    }

                    Console.WriteLine("Got file data info!");

                    if (!PostIPRegion(IpAddress))
                    {
                        Console.WriteLine("[ERROR] Failed to send IP region.");
                        return null;
                    }

                    string playerKey = CheckLogin(deviceKey, channel, token);

                    if (playerKey != null) //will contain PlayerKey
                    {
                        Console.WriteLine("Web login success: " + playerKey);
                        this.PlayerKey = playerKey;

                        if (PostLanguage("en"))
                        {
                            if (PostUserPrivacy(this.PlayerKey))
                            {
                                return playerKey;
                            }
                        }
                    }
                }
            }
            else
                Console.WriteLine("GetServerInfo: fail");


            Console.WriteLine("Failed to get player key!");

            return null;
        }

        public bool GetServerInfo()
        {
            HttpWebRequest request = (HttpWebRequest)HttpWebRequest.Create(ServerInfo);
            request.Method = "GET";
            
            String _responseData = String.Empty;

            using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
            {
                Stream dataStream = response.GetResponseStream();
                StreamReader reader = new StreamReader(dataStream);
                _responseData = reader.ReadToEnd();
                reader.Close();
                dataStream.Close();
            }

            if(_responseData.Length > 0)
            { 
                //Console.WriteLine(_responseData);

                var versionInfo = JsonConvert.DeserializeObject<ServerInfoJSON>(_responseData);

                //Console.WriteLine(versionInfo.BaseSetting._1571.PatchRootUrl);

                if(versionInfo.BaseSetting._1671.PatchRootUrl.Length > 0) // _1571 = current version
                {
                    this.serverInfo = versionInfo;
                    this.PatchRootUrl = versionInfo.BaseSetting._1671.PatchRootUrl;
                    this.PatchSubpath = versionInfo.BaseSetting._1671.PatchSubPath;
                    this.WemadeServiceUrl = versionInfo.BaseSetting._1671.WemadeServiceUrl;
                    this.WemadeServiceVersion = versionInfo.BaseSetting._1671.WemadeServiceVersion;
                }

                return true;
            }

            return false;
        }

        public bool CheckVersion(string versionUrl, string IpAddress, string MacAddress)
        {
            HttpWebRequest request = (HttpWebRequest)HttpWebRequest.Create(versionUrl);
            request.Method = "POST";
            request.ContentType = "application/json";

            Console.WriteLine("WemadeServiceVersion: " + WemadeServiceVersion);

            String _responseData = String.Empty;

            using (var streamWriter = new StreamWriter(request.GetRequestStream()))
            {
                string json = "{\"Version\":\"" + WemadeServiceVersion + "\"," + 
                              " \"StoreType\":\"" + StoreType + "\"," +
                              " \"IpAddress\":\"" + IpAddress + "\"," +
                              " \"MacAddress\":\"" +  MacAddress + "\"}" ;

                streamWriter.Write(json);
            }

            var httpResponse = (HttpWebResponse)request.GetResponse();
            using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
            {
                _responseData = streamReader.ReadToEnd();

                if(_responseData.Length > 0)
                {
                    ServerData serverInfo = JsonConvert.DeserializeObject<ServerData>(_responseData);

                    if(serverInfo.Data.FrontServerURL.Length > 0) //success
                    {
                        this.serverData = serverInfo;

                        servers = JsonConvert.DeserializeObject<LiveServers>(this.serverData.Data.FrontServerList);
                      
                        Console.WriteLine("Front server: " + serverInfo.Data.FrontServerURL);
                        //Console.WriteLine(serverInfo.Data.CommunityURL);
                        return true;
                    }
                }
            }

            return false;
        }
        public bool GetPatchInfo() //needs updating on new wemadeservice versions
        {
            HttpWebRequest request = (HttpWebRequest)HttpWebRequest.Create(serverInfo.BaseSetting._1571.PatchRootUrl + serverInfo.BaseSetting._1571.PatchSubPath + "WindowsNoEditor/PatchInfo.json");
            request.Method = "GET";

            String _responseData = String.Empty;

            using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
            {
                Stream dataStream = response.GetResponseStream();
                StreamReader reader = new StreamReader(dataStream);
                _responseData = reader.ReadToEnd();
                reader.Close();
                dataStream.Close();
            }

            if (_responseData.Length > 0)
            {
                //Console.WriteLine(_responseData);

                var patchInfos = JsonConvert.DeserializeObject<PatchInfoJSON>(_responseData);

                Console.WriteLine(patchInfos.PatchInfos.Step0[0].FileName);

                return true;
            }

            return false;
        }

        public bool GetDataInfo()
        {
            HttpWebRequest request = (HttpWebRequest)HttpWebRequest.Create(serverInfo.BaseSetting._1351.PatchRootUrl + serverInfo.BaseSetting._1351.PatchSubPath + "Data/datainfo.json");
            request.Method = "GET";

            String _responseData = String.Empty;

            using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
            {
                Stream dataStream = response.GetResponseStream();
                StreamReader reader = new StreamReader(dataStream);
                _responseData = reader.ReadToEnd();
                reader.Close();
                dataStream.Close();
            }

            if (_responseData.Length > 0)
            {
               // Console.WriteLine(_responseData);

                var dataInfo = JsonConvert.DeserializeObject<DataInfo>(_responseData);

                if(dataInfo != null)
                {
                    this.FileDataInfo = dataInfo;
                    return true;
                }
            }

            return false;
        }

        public bool PostIPRegion(string IPAddress)
        {
            HttpWebRequest request = (HttpWebRequest)HttpWebRequest.Create(IPRegion);
            request.Method = "POST";
            request.ContentType = "application/json";

            String _responseData = String.Empty;

            using (var streamWriter = new StreamWriter(request.GetRequestStream()))
            {
                string json = "{\"IpAddress\":\"" + IPAddress + "\"}";

                streamWriter.Write(json);
            }

            var httpResponse = (HttpWebResponse)request.GetResponse();
            using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
            {
                _responseData = streamReader.ReadToEnd();

                if (_responseData.Length > 0)
                {
                    RootRegionCode regionInfo = JsonConvert.DeserializeObject<RootRegionCode>(_responseData);

                    if (regionInfo.RegionCode.Length > 0) //success
                    {
                        this.regionInfo = regionInfo;

                        Console.WriteLine(regionInfo.RegionCode);
                        return true;
                    }
                }
            }

            return false;
        }

        public string CheckLogin(string DeviceID, string Channel, string TokenID) //returns playerKey on success, used in login packet for game
        {
            HttpWebRequest request = (HttpWebRequest)HttpWebRequest.Create(LoginCheck);
            request.Method = "POST";
            request.ContentType = "application/json";

            String _responseData = String.Empty;

            using (var streamWriter = new StreamWriter(request.GetRequestStream()))
            {
                string json = "{\"DeviceID\":\"" + DeviceID + "\"," +
                              " \"Channel\":\"" + Channel + "\"," +
                              " \"TokenID\":\"" + TokenID + "\"}";

                streamWriter.Write(json);
            }

            var httpResponse = (HttpWebResponse)request.GetResponse();
            using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
            {
                _responseData = streamReader.ReadToEnd();

                if (_responseData.Length > 0)
                {
                    try
                    {
                        LoginCheck loginInfo = JsonConvert.DeserializeObject<LoginCheck>(_responseData);


                        if (loginInfo.PlayerKey != null)
                        {
                            if (loginInfo.PlayerKey.Length > 0) //success
                            {
                                this.loginInfo = loginInfo;

                                Console.WriteLine("Got player key: " + this.loginInfo.PlayerKey);
                                return this.loginInfo.PlayerKey;
                            }
                        }
                    }
                    catch
                    {
                        Console.WriteLine("Could not get player key! ");
                        return null;
                    }
                }
            }

            return null;
        }

        public bool PostLanguage(string language)
        {
            HttpWebRequest request = (HttpWebRequest)HttpWebRequest.Create(LanguageUrl);
            request.Method = "POST";
            request.ContentType = "application/json";

            String _responseData = String.Empty;

            using (var streamWriter = new StreamWriter(request.GetRequestStream()))
            {
                string json = "{\"PlayerKey\":\"" + this.PlayerKey + "\"," +
                              " \"LanguageCode\":\"" + language + "\"}";

                streamWriter.Write(json);
            }

            var httpResponse = (HttpWebResponse)request.GetResponse();
            using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
            {
                _responseData = streamReader.ReadToEnd();

                if (_responseData.Length > 0)
                {
                    if(_responseData.Contains("\"200\""))
                    {
                        Console.WriteLine("PostLanguage: {0}", language);
                        return true;
                    }                
                }
            }

            return false;
        }

        public bool PostUserPrivacy(string playerKey)
        {
            HttpWebRequest request = (HttpWebRequest)HttpWebRequest.Create(PrivacyUrl + playerKey);
            request.Method = "GET";

            String _responseData = String.Empty;

            var httpResponse = (HttpWebResponse)request.GetResponse();
            using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
            {
                _responseData = streamReader.ReadToEnd();

                if (_responseData.Length > 0)
                {
                    if (_responseData.Contains("\"Code\":200"))
                    {
                        Console.WriteLine("PostUserPrivacy: 200");
                        return true;
                    }
                }
            }

            return false;
        }

        public bool LoginSteam(string username, string password)
        {
            return true;
        }
    }
}
