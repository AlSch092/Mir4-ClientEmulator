//By AlSch092 @ Github
﻿using System;
using System.IO;
using System.Windows.Forms;

namespace Mir4.Scripter
{
    public class Profile
    {
        public string profile_path_ini { get; set; }
        public string[] command_line { get; set; }

        private string account_steam_name { get; set; }
        public string login_token { get; set; }
        public string device_id { get; set; }
        public string character_name { get; set; }
        public string login_method { get; set; }
        public string character_world { get; set; }
        public string desired_action { get; set; }
        public bool reconnecting { get; set; }

        private bool ReadProfileFile(string path)
        {
            try
            {
                using (StreamReader reader = new StreamReader(path))
                {
                    string line;
                    int line_index = 0;
                    while ((line = reader.ReadLine()) != null)
                    {
                        //Console.WriteLine("{0}", line);

                        switch (line_index)
                        {
                            case 0: //acct name
                                account_steam_name = line;
                                break;
                            case 1: //tokenid
                                login_token = line;
                                break;
                            case 2: //deviceid
                                device_id = line;
                                break;
                            case 3: //
                                character_name = line;
                                break;
                            case 4:
                                login_method = line;
                                break;
                            case 5:
                                character_world = line;
                                break;
                            case 6:
                                desired_action = line;
                                break;
                            case 7:
                                if (line == "Reconnect")
                                    reconnecting = true;
                                break;
                        };

                        line_index++;
                    }
                }
            }
            catch (FileNotFoundException ex)
            {
                Console.WriteLine("[ERROR] Could not find desired gathering entities file: {0}", ex.Message);
                return false;
            }

            return true;
        }

        public bool ProcessCommandLine()
        {
            command_line = Environment.GetCommandLineArgs();

            if(command_line != null)
            {
                if(command_line.Length == 2) //.ini file load
                {
                    profile_path_ini = command_line[1];
                    //read profile from ini
                    if(ReadProfileFile(profile_path_ini))
                    {
                        Console.WriteLine("Read profile successfully..");
                        return true;
                    }
                    else
                    {
                        MessageBox.Show("Failed to read .ini profile using command line!");
                        Console.WriteLine("Failed to read .ini profile from command line!");
                        return false;
                    }
                }
                else if(command_line.Length > 6) //no .ini file, only command line
                {
                    login_token = command_line[1];
                    device_id = command_line[2];
                    character_name = command_line[3];
                    login_method = command_line[4];
                    character_world = command_line[5];
                    desired_action = command_line[6];
                    return true;
                }
            }

            return false;
        }
    }
}
