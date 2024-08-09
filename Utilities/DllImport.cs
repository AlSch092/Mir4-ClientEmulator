//By AlSch092 @ Github
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
namespace Mir4.Utilities
{
    public static class DllImports
    {
        public const int STD_OUTPUT_HANDLE = -11;
        public const int MY_CODE_PAGE = 437;

        [DllImport("kernel32.dll", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool AllocConsole();

        [DllImport("kernel32.dll", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool FreeConsole();

        [DllImport("kernel32.dll", EntryPoint = "GetStdHandle",SetLastError = true,CharSet = CharSet.Auto, CallingConvention = CallingConvention.StdCall)]
        public static extern IntPtr GetStdHandle(int nStdHandle);

        [DllImport("kernel32.dll", SetLastError = true)]
        public static extern bool ExitProcess( uint uExitCode);
    }
}
