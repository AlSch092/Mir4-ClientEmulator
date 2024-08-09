//By AlSch092 @ Github
﻿using System.Runtime.InteropServices;

namespace Mir4ClientEmulator.Network.Packets.Encryption
{
    internal class Encryption
    {
        [DllImport("System.Encodings.dll", EntryPoint = "Encode", CallingConvention = CallingConvention.Cdecl)]
        public static extern int Encode(byte[] data, byte[] outData, int length);
    }
}
