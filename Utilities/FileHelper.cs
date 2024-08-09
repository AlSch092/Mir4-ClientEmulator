//By AlSch092 @ Github
﻿using CsvHelper.Configuration;
using CsvHelper;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mir4ClientEmulator.Utilities
{
    public static class FileHelper
    {
        public static byte[] FileToByteArray(string fileName)
        {
            byte[] buff = null;
            FileStream fs = new FileStream(fileName, FileMode.Open, FileAccess.Read);
            BinaryReader br = new BinaryReader(fs);
            long numBytes = new FileInfo(fileName).Length;
            buff = br.ReadBytes((int)numBytes);
            fs.Close();
            return buff;
        }

        public static ushort GetOpcodeFromName(string fileName, string str_opcode)
        {
            ushort opcode = 0;

            try
            {
                using (StreamReader reader = new StreamReader(fileName))
                {
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        // Split the line into the string and integer parts
                        string[] parts = line.Split('=');

                        if (parts.Length == 2)
                        {
                            parts[0] = parts[0].Trim();
                            ushort num;

                            int index = parts[1].IndexOf(';');
                            if (index > 0)
                            {
                                parts[1] = parts[1].Remove(index); //parts1 = numeric , [0] = string opcode
                            }

                            if (parts[0] == str_opcode)
                            {
                                if (ushort.TryParse(parts[1].Trim(), out num))
                                {
                                    opcode = num;
                                    return opcode;
                                }
                            }
                        }
                        else
                        {
                            Console.WriteLine("Invalid line format: " + line);
                        }
                    }
                }
            }
            catch
            {
                Console.WriteLine("[ERROR] Failed to read opcodes file!");
                return 0;
            }

            return opcode;
        }

        public static string GetNamedOpcode(string fileName, ushort opcode)
        {
            string namedOpcode = "";

            try
            {
                using (StreamReader reader = new StreamReader(fileName))
                {
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        // Split the line into the string and integer parts
                        string[] parts = line.Split('=');

                        if (parts.Length == 2)
                        {
                            string str = parts[0].Trim();
                            ushort num;

                            int index = parts[1].IndexOf(';');
                            if(index > 0)
                            {
                                parts[1] = parts[1].Remove(index);
                            }

                            if (ushort.TryParse(parts[1].Trim(), out num))
                            {
                                if(opcode == num)
                                    namedOpcode = str;
                            }
                            else
                            {
                                Console.WriteLine("Invalid opcode value: " + parts[1]);
                            }
                        }
                        else
                        {
                            Console.WriteLine("Invalid line format: " + line);
                        }
                    }
                }
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("File not found: " + fileName);
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred: " + ex.Message);
            }

            return namedOpcode;
        }

        public static bool ReadDesiredEntitiesFile(string file, Dictionary<long, int> fillList)
        {
            try
            {
                using (StreamReader reader = new StreamReader(file))
                {
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        // Split the line into the string and integer parts
                        string[] parts = line.Split(',');

                        if (parts.Length == 2)
                        {
                            long id = Convert.ToInt64(parts[0]);
                            int priority = Convert.ToInt32(parts[1]);

                            if (id != 0 && priority > 0)
                            {
                                if(!fillList.ContainsKey(id))
                                    fillList.Add(id, priority);
                            }
                        }
                        else
                        {
                            Console.WriteLine("Invalid line format: " + line);
                        }
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

        public static string GetPacketErrorString(string fileName, int error_num)
        {
            string namedOpcode = "";

            try
            {
                using (StreamReader reader = new StreamReader(fileName))
                {
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        // Split the line into the string and integer parts
                        string[] parts = line.Split('=');

                        if (parts.Length == 2)
                        {
                            if (Convert.ToUInt32(parts[1]) == error_num)
                            {
                                return parts[0];
                            }
                        }
                        else
                        {
                            Console.WriteLine("Invalid line format: " + line);
                        }
                    }
                }
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("File not found: " + fileName);
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred: " + ex.Message);
            }

            return namedOpcode;
        }

        public static void WriteColoredLine(ConsoleColor color, string text)
        {
            Console.ForegroundColor = color;
            Console.WriteLine(text);
            Console.ResetColor();
        }
    }
}
