//By AlSch092 @ Github
﻿using System.Runtime.InteropServices;

namespace Mir4ClientEmulator.Network.Packets.Encryption
{
    internal class Encryption
    {
        [DllImport("Mir4Encryption.dll", EntryPoint = "Encrypt", CallingConvention = CallingConvention.Cdecl)]  //change this to whatever dll you're using for encryption
        public static extern int Encode(byte[] data, byte[] outData, int length);
    }
}
