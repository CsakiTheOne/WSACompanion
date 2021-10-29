using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WSACompanion
{
    internal static class Data
    {
        public static CMDSession CMD { get; set; }
        public static string IP { get; set; } = "172.20.77.222";
        public static string ADBPath { get; set; } = @"C:\Users\jocka\AppData\Local\Android\Sdk\platform-tools\adb.exe";
    }
}
