//By AlSch092 @ Github
﻿using ProtoBuf;
using System.IO;

namespace Mir4ClientEmulator.Network.Packets
{
    public class Protobuf
    {
        public static byte[] Serialize<T>(T obj) where T : class
        {
            try
            {
                using (var stream = new MemoryStream())
                {
                    Serializer.Serialize<T>(stream, obj);
                    return stream.ToArray();
                }
            }
            catch
            {
                // Log error
                throw;
            }
        }

        public static T ProtoDeserialize<T>(byte[] data) where T : class
        {
            if (null == data) 
                return null;

            try
            {
                using (var stream = new MemoryStream(data))
                {
                    return Serializer.Deserialize<T>(stream);
                }
            }
            catch
            {
                // Log error
                throw;
            }
        }

        //public static List<Metadata> WriteTree(ref ProtoReader.State reader)
        //{
        //    List<Metadata> decoded_list = new List<Metadata>(); //generic type list, bad implementation sort of

        //    try
        //    {
        //        int fieldNumber = reader.ReadFieldHeader();
                
        //        while (fieldNumber > 0)
        //        {
        //            ProtoReader.State reader_cpy = reader;

        //            switch (reader.WireType)
        //            {
                     
        //                case WireType.Varint:

        //                    long val = reader.ReadInt64();

        //                    Metadata<long> field = new Metadata<long>();
        //                    field.mLongData = val;
        //                    field.typeCode = val.GetTypeCode();
        //                    decoded_list.Add(field);
        //                    //Console.WriteLine("reader[{0}]: {1}", fieldNumber, val);
        //                    break;

        //                case WireType.String: // note: "string" here just means "some bytes"; could be UTF-8, could be a BLOB, could be a "packed array", or could be sub-object(s); showing UTF-8 for simplicity

        //                    string str = reader.ReadString(); //strings arent always well-aligned, lots of junk surrounds them. why?

        //                    bool isValid = false;

        //                    if ((str[0] >= 'A' && str[0] <= 'Z') || (str[0] >= 'a' && str[0] <= 'Z') || (str[0] >= '0' && str[0] <= '9'))
        //                        isValid = true;

        //                    if(str.Length >= 2 && isValid)
        //                    {
        //                        Metadata<byte> field_s = new Metadata<byte>(); //we use byte instead of string because the generic list wont take string primitive as type (compiler issue) and doesnt use byte type, so we can use that type instead
        //                        field_s.mStringData = str;
        //                        field_s.typeCode = str.GetTypeCode();
        //                        decoded_list.Add(field_s);
        //                        //Console.WriteLine("Found string field: " + field_s.mStringData);
        //                        continue;
        //                    }
        //                    else
        //                    {
        //                        var grp = reader_cpy.StartSubItem();
        //                        List<Metadata> decoded_list_inner = WriteTree(ref reader_cpy); //get inner group
        //                        reader_cpy.EndSubItem(grp);

        //                        if (decoded_list_inner.Count > 0)
        //                        {
        //                            foreach (Metadata p in decoded_list_inner)
        //                            {
        //                                switch (p.typeCode)
        //                                {
        //                                    case TypeCode.Double:
        //                                        Metadata<double> f_d = new Metadata<double>();
        //                                        f_d.mDoubleData = p.mDoubleData;
        //                                        f_d.typeCode = p.mDoubleData.GetTypeCode();
        //                                        decoded_list.Add(f_d);
        //                                        //Console.WriteLine("reader[{0}]: {1}", fieldNumber, p.mDoubleData);
        //                                        break;

        //                                    case TypeCode.Single:

        //                                        Metadata<float> f_s = new Metadata<float>();
        //                                        f_s.mFloatData = p.mFloatData;
        //                                        f_s.typeCode = p.mFloatData.GetTypeCode();
        //                                        decoded_list.Add(f_s);
        //                                        //Console.WriteLine("reader[{0}]: {1}", fieldNumber, p.mFloatData);
        //                                        break;

        //                                    case TypeCode.Int32:
        //                                        Metadata<int> f_i32 = new Metadata<int>();
        //                                        f_i32.mIntData = p.mIntData;
        //                                        f_i32.typeCode = p.mIntData.GetTypeCode();
        //                                        decoded_list.Add(f_i32);
        //                                        //Console.WriteLine("reader[{0}]: {1}, {2}", fieldNumber, p.mIntData, p.mLongData);
        //                                        break;

        //                                    case TypeCode.Int64:
        //                                        Metadata<long> f = new Metadata<long>();
        //                                        f.mLongData = p.mLongData;
        //                                        f.typeCode = p.mLongData.GetTypeCode();
        //                                        decoded_list.Add(f);
        //                                        //Console.WriteLine("reader[{0}]: {1}", fieldNumber, p.mLongData);
        //                                        break;

        //                                    case TypeCode.String: //check this

        //                                        string _str = reader.ReadString();
        //                                        Console.WriteLine("Found nested string field: " + _str);
        //                                        Metadata<byte> field_s = new Metadata<byte>();
        //                                        field_s.mStringData = _str;
        //                                        field_s.typeCode = _str.GetTypeCode();
        //                                        decoded_list.Add(field_s);
        //                                        break;

        //                                    case TypeCode.Object:
        //                                        Console.WriteLine("Object type..");
        //                                        break;

        //                                    default:
        //                                        Console.WriteLine("[WARNING] Found unknown wire type!");
        //                                        reader.SkipField();
        //                                        break;

        //                                };
        //                            }
        //                        }
        //                    }
        //                    break;

        //                case WireType.Fixed32:
        //                    // could be an integer, but probably floating point             
        //                    float val_f = reader.ReadSingle();

        //                    Metadata<float> field_f = new Metadata<float>();
        //                    field_f.mFloatData = val_f;
        //                    field_f.typeCode = val_f.GetTypeCode();
        //                    decoded_list.Add(field_f);
        //                    //Console.WriteLine("reader[{0}]: {1}", fieldNumber, val_f);
        //                    break;

        //                case WireType.Fixed64:
        //                    // could be an integer, but probably floating point

        //                    double val_d = reader.ReadDouble();
        //                    Console.WriteLine(val_d);
        //                    Metadata<double> field_d = new Metadata<double>();
        //                    field_d.mDoubleData = val_d;
        //                    field_d.typeCode = val_d.GetTypeCode();
        //                    decoded_list.Add(field_d);
        //                    //Console.WriteLine("reader[{0}]: {1}", fieldNumber, val_d);
        //                    break;

        //                case WireType.StartGroup:
        //                    // one of 2 sub-object formats
        //                    var tok = reader.StartSubItem();
        //                    WriteTree(ref reader);
        //                    reader.EndSubItem(tok);
        //                    break;

        //                case WireType.EndGroup:
        //                    Console.WriteLine("Got ending group!!");
        //                    break;

        //                default:
        //                    Console.WriteLine("[WARNING] Found unknown wire type!");
        //                    reader.SkipField();
        //                    break;
        //            }

        //            fieldNumber = reader.ReadFieldHeader();
        //        }
        //    }
        //    catch  (Exception ex)
        //    {
        //        string s = ex.Message;
        //    }

        //    return decoded_list;
        //}
    }
}
