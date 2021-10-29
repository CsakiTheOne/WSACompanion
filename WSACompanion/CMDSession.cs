using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WSACompanion
{
    internal class CMDSession
    {
        public event DataReceivedEventHandler OnDataReceived;

        Process cmd;
        bool isStarted = false;

        public void Start()
        {
            ProcessStartInfo procStartInfo = new ProcessStartInfo("powershell.exe");
            //procStartInfo.WorkingDirectory = @"C:\Windows";
            procStartInfo.UseShellExecute = false;
            procStartInfo.CreateNoWindow = true;
            procStartInfo.RedirectStandardInput = true;
            procStartInfo.RedirectStandardOutput = true;
            cmd = new Process();
            cmd.StartInfo = procStartInfo;
            cmd.OutputDataReceived += Cmd_OutputDataReceived;
            cmd.Start();
            cmd.BeginOutputReadLine();
            isStarted = true;
        }

        private void Cmd_OutputDataReceived(object sender, DataReceivedEventArgs e)
        {
            OnDataReceived?.Invoke(sender, e);
        }

        public void Execute(string command)
        {
            if (!isStarted) return;

            StreamWriter sw = cmd.StandardInput;
            sw.WriteLine(command);
        }
    }
}
