using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.IO;

namespace Minecraft_Server_Launcher
{
    class Server : IDisposable
    {
        public enum Commands
        {
            changesetting,
            deop,
            kick,
            op,
            permissions,
            save,
            stop,
            whitelist
        }

        private Process process;
        private StreamWriter sw;
        private Action<string> Callback;

        public Server(Action<string> callback)
        {
            Callback = callback;
            process = new Process();
            ProcessStartInfo startInfo = new ProcessStartInfo("bedrock_server.exe")
            {
                CreateNoWindow = true,
                WindowStyle = ProcessWindowStyle.Hidden,
                RedirectStandardInput = true,
                RedirectStandardOutput = true,
                UseShellExecute = false
            };
            process.StartInfo = startInfo;
            process.OutputDataReceived += P_OutputDataReceived;
            if (process.Start())
            {
                sw = process.StandardInput;
                process.BeginOutputReadLine();
            }
            else
            {
                Debug.WriteLine("Failed to start server.");
            }
        }

        private void StopServer()
        {
            if (!process.HasExited)
            {
                Debug.WriteLine("Stopping Server");
                sw.WriteLine("stop");
                sw.Close();
                process.WaitForExit();
                process.Close();
                Debug.WriteLine("Server stopped");
            }
            else
            {
                Debug.WriteLine("Server already stopped");
            }
        }

        public void SendCommand(Commands cmd, string arg1 = "", string arg2 = "")
        {
            string c = cmd.ToString() + (arg1 != "" ? $" {arg1}" : "") + (arg2 != "" ? $" {arg2}" : "");
            sw.WriteLine(c);
        }

        private void P_OutputDataReceived(object sender, DataReceivedEventArgs e)
        {
            if (!String.IsNullOrEmpty(e.Data))
            {
                Callback(e.Data);
            }
        }

        public void Dispose()
        {
            StopServer();
        }

        public static bool IsRunning()
        {
            return Process.GetProcessesByName("bedrock_server").Length > 0;
        }

        private Process GetServerProcess()
        {
            if (IsRunning())
            {
                return Process.GetProcessesByName("bedrock_server")[0];
            }
            else
            {
                return null;
            }
        }

    }
}
