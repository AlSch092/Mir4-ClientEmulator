//By AlSch092 @ Github
﻿using CsvHelper.Configuration;
using CsvHelper;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using Mir4ClientEmulator.Network.Packets.Messages;

namespace Mir4ClientEmulator.Utilities
{
    public class CSVSerializer
    {
        public static List<T> DeserializeCsv<T>(string filePath)
        {
            using (var reader = new StreamReader(filePath))
            using (var csv = new CsvReader(reader, new CsvConfiguration(CultureInfo.InvariantCulture)))
            {
                var records = csv.GetRecords<T>().ToList();
                return records;
            }
        }

        public static _vector3 ParseVector3(string input) ////parse "(X=6540.000000,Y=2063.000000,Z=493.000000)" to _vector3
        {
            _vector3 output = null;

            if (input == "0")
                return null;

            string input_copy = input;

            string[] coords = input_copy.Split(',');

            if(coords != null)
            {
                if(coords.Length == 3)
                {
                    coords[0] = coords[0].Remove(0, 3); //remove '(X='
                    coords[1] = coords[1].Remove(0, 2); //remove Y=
                    coords[2] = coords[2].Remove(0, 2); //remove Z=
                    coords[2] = coords[2].Remove(coords[2].Length - 1, 1); //remove ')'

                    output = new _vector3();
                    output.x = Convert.ToSingle(coords[0]); output.y = Convert.ToSingle(coords[1]); output.z = Convert.ToSingle(coords[2]);
                }
            }

            return output;
        }
    }
}
