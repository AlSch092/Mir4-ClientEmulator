//By AlSch092 @ Github
﻿using System;
using System.IO;
using System.Net;
using System.Threading;

namespace Mir4ClientEmulator.Network.WebLogin.Captcha
{
    internal class HumanVerify
    {
        public static string VerifyURL = "https://humanverify.mir4global.com";
        
        public static string verify_get = "/web/captcha/auth?VerifyID=";

        public static string post_url = "/web/captcha/auth/verify";
        public static string get_result = "/web/captcha/auth/result/200?VerifyID="; 
        
        public static string _2captcha_endpoint = "https://api.2captcha.com/in.php";
        public static string _2captcha_checkstatus = "https://2captcha.com/res.php";

        private static string g_recaptcha_sitekey = "INVALIDAPIKEY";
        private static string captcha_api_key = "INVALIDAPIKEY";

        public static bool CheckVerifyStatus(string verify_id) //last reqeust needed
        {
            string full_url = VerifyURL + get_result + verify_id  + "&lang=en";

            HttpWebRequest request = (HttpWebRequest)HttpWebRequest.Create(full_url);
            request.Method = "GET";

            Console.WriteLine("Checking {0}", full_url);

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
                Console.WriteLine(_responseData);

                if (_responseData.Contains("Verification <em>successful</em>"))
                {
                    return true;
                }
                else if (_responseData.Contains("Error"))
                {
                    return false;
                }
            }

            return false;
        }

        public static bool POSTHumanVerify(string captcha_answer, string verify_id, bool is_lemin) //use "Network" tab to log outbound requests
        {
            HttpWebRequest request = (HttpWebRequest)HttpWebRequest.Create(VerifyURL + post_url);         
            request.Method = "POST";
            request.ContentType = "text/html";

            String _responseData = String.Empty;

            using (var streamWriter = new StreamWriter(request.GetRequestStream()))
            {
                string request_body = "";

                if(is_lemin)
                {
                    request_body = "VerifyID=" + verify_id + "&VerifyType=lemin&lemin_challenge_id=" + "XXXXXXX" + "&lemin_answer=" + captcha_answer; //how to get lemin_challenge_id?
                }
                else
                {
                    request_body = "VerifyID=" + verify_id + "&VerifyType=google&g-recaptcha-response=" + captcha_answer;
                }

                streamWriter.Write(request_body); //page returns no data (302), need to GET https://humanverify.mir4global.com/web/captcha/auth/result/200?VerifyID=ODc3Y2I5ZWRmZmVkZTU1MWQwNzE3YzFlYzM1ZDhjMzkwNDcwNTJkNmZmOTg0ZjEzZDU1MDQ1ZDE5MjY5MGQxNw==&lang=en after
            }

            var httpResponse = (HttpWebResponse)request.GetResponse(); //In the response you will receive the id of your captcha, Wait 15-20 seconds and make a GET request to our API endpoint: https://2captcha.com/res.php. If the captcha is already solved you will receive the answer:
            using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
            {
                _responseData = streamReader.ReadToEnd();

                if (_responseData.Length > 0)
                {
                    //make GET request to check if success using get_result url
                    Console.WriteLine(_responseData);

                }

                if(CheckVerifyStatus(verify_id))
                {
                    Console.WriteLine("[INFO] CheckVerifyStatus was successful!");
                }
                else
                {
                    Console.WriteLine("[ERROR] Human verify submission failed!");
                    return false;
                }
            }

            return true;
        }

        public static bool SendLeminCaptcha(string api_key, string captchaId, string div_id, string pageurl, int json)
        {
            HttpWebRequest request = (HttpWebRequest)HttpWebRequest.Create(_2captcha_endpoint);
            request.Method = "POST";
            request.ContentType = "application/json";

            Console.WriteLine("SendLeminCaptcha: " + captchaId);

            String _responseData = String.Empty;

            using (var streamWriter = new StreamWriter(request.GetRequestStream()))
            {
                string request_json = "{\"key\":\"" + api_key + "\"," +
                              " \"method\":\"" + "lemin" + "\"," +
                              " \"captcha_id\":\"" + captchaId + "\"," +
                              " \"api_server\":\"" + "api.leminnow.com" + "\"," +
                              " \"div_id\":\"" + div_id + "\"," +
                              " \"pageurl\":\"" + pageurl + "\"," +
                              " \"json\":\"" + Convert.ToString(json) + "\"}";

                streamWriter.Write(request_json);
            }

            var httpResponse = (HttpWebResponse)request.GetResponse(); //In the response you will receive the id of your captcha, Wait 15-20 seconds and make a GET request to our API endpoint: https://2captcha.com/res.php. If the captcha is already solved you will receive the answer:
            using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
            {
                _responseData = streamReader.ReadToEnd();

                if (_responseData.Length > 0)
                {
                    Console.WriteLine(_responseData);
                    //parse for reqeust_id

                    if(_responseData.Contains("{\"status\":1")) //success
                    {
                        int start_index = "{\"status\":1,\"request\":\"".Length;

                        string request_num = _responseData.Substring(start_index);

                        if(request_num != null)
                        {
                            if(request_num.Length > 2)
                            {
                                request_num = request_num.Remove(request_num.Length - 2, 2); //remove last 2 characters 

                                string answer = GetCaptchaAnswer(HumanVerify.captcha_api_key, request_num, true);
                                Console.WriteLine("Answer: {0}", answer);
                            }
                        }
                    }
                    else
                    {
                        Console.WriteLine("[ERROR] could not find request_id at SendLeminCaptcha");
                    }
                }
            }

            return false;
        }

        public static bool SendGRecaptcha(string api_key, string g_recaptcha_sitekey, string pageurl, string verifyId)
        {
            string full_url = _2captcha_endpoint + "?key=" + api_key + "&method=userrecaptcha&googlekey=" + g_recaptcha_sitekey + "&pageurl=" + pageurl;

            Console.WriteLine("Connecting to {0}", full_url);

            HttpWebRequest request = (HttpWebRequest)HttpWebRequest.Create(full_url);
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
                Console.WriteLine(_responseData);

                if(_responseData.Contains("OK|"))
                {
                    string request_id = _responseData.Substring(3);

                    Console.WriteLine("Got request id: {0}", request_id);

                    if(request_id.Length > 3)
                    {
                        string answer = "";
                        
                        while(answer == "CAPTCHA_NOT_READY" || answer == "")
                        {
                            answer = GetCaptchaAnswer(HumanVerify.captcha_api_key, request_id, true);
                            Thread.Sleep(2000);
                        }

                        Console.WriteLine("Answer: {0}", answer);

                        if(answer.Length < 2)
                        {
                            Console.WriteLine("Captcha answer incorrect length..");
                            return false;
                        }

                        if (POSTHumanVerify(answer, verifyId, false))
                        {
                            Console.WriteLine("Sent POST request to verify...");
                            return true;
                        }
                    }
                }
            }

            return false;
        }


        public static string GetCaptchaAnswer(string api_key, string request_id, bool first_check)
        {
            string answer = "";

            string full_url = _2captcha_checkstatus + "?key=" + api_key + "&action=get&id=" + request_id;

            if (first_check)           
                Thread.Sleep(25000); //wait some time before checking captcha answer if it's the first time checking
            
            HttpWebRequest request = (HttpWebRequest)HttpWebRequest.Create(full_url);
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
                Console.WriteLine(_responseData);

                if(_responseData.Contains("OK|")) //g-recaptcha answer
                {
                    answer = _responseData.Substring(3);
                }
            }

            return answer;
        }


        public static bool VerifyAccount(string loginToken) //cant visit page or it refreshes, need to send url directly to recaptcha
        {
            var plainTextBytes = System.Text.Encoding.UTF8.GetBytes(loginToken);
            string base64_encode_token = System.Convert.ToBase64String(plainTextBytes);

            string URL = VerifyURL + verify_get + base64_encode_token + "&lang=en";
               
            //HttpWebRequest request = (HttpWebRequest)HttpWebRequest.Create(URL);
            //request.Method = "GET";
            //request.ContentType = "text/html; charset=UTF-8";

            String _responseData = String.Empty;

            //captcha can either be recaptcha or lemin...

            //PROBLEM: We can't view the page - or else it refreshes with a new captcha. send directly to recap

            //var httpResponse = (HttpWebResponse)request.GetResponse();
            //using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
            //{
            //    _responseData = streamReader.ReadToEnd();

            //    Console.WriteLine(_responseData);

            //    if (_responseData.Length > 0)
            //    {
            //        if(_responseData.Contains("lemin-cropped-captcha")) //lemin
            //        {
            //            int index = _responseData.IndexOf("https://api.leminnow.com/captcha/v1/cropped/");
            //            string captchaId = _responseData.Substring(index + "https://api.leminnow.com/captcha/v1/cropped/".Length, 48);
                        
            //            Console.WriteLine("Verification contains lemin catpcha... not supported by auto-captcha APIs. Please reconnect and hope for g");
            //            Console.WriteLine("Captcha ID: {0}", captchaId);

            //            return false;

            //            if (captchaId.Length > 0)
            //            {
            //                SendLeminCaptcha(captcha_api_key, captchaId, "lemin-cropped-captcha", URL, 1);
            //            }
            //            else
            //            {
            //                Console.WriteLine("[ERROR] Could not find captchaId on page!");
            //                return false;
            //            }
            //        }
            //        else if (_responseData.Contains("g-recaptcha")) //g-recaptcha
            //        {
            //            Console.WriteLine("Verification contains GOOGLE catpcha...");
            //            SendGRecaptcha(captcha_api_key, g_recaptcha_sitekey, URL, base64_encode_token);
            //        }
            //        else if (_responseData.Contains("Sorry.</span>A temporary error has occurred."))
            //        {
            //            Console.WriteLine("Server blocked account from verifying, please wait some time...");
            //            return false;
            //        }
            //    }
            //}

            return SendGRecaptcha(captcha_api_key, g_recaptcha_sitekey, URL, base64_encode_token);
        }

    }
}
