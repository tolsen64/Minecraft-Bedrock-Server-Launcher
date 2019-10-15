using System;
using System.IO;
using System.Net;
using System.Reflection;
using System.Text.RegularExpressions;

namespace Minecraft_Server_Launcher
{
    static class ServerUpdate
    {
        private static readonly string url = "https://www.minecraft.net/en-us/download/server/bedrock/";
        private static readonly string pattern = "https:.*?bin-win/(?<filename>bedrock-server-(?<version>.*?).zip)";
        private static readonly string AppPath = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);

        public static async void UpdateServer(Action<string> callback)
        {
            using (WebClient client = new WebClient())
            {
                string pageSrc = await client.DownloadStringTaskAsync(url);
                Regex rx = new Regex(pattern);
                if (rx.IsMatch(pageSrc))
                {
                    Match m = rx.Match(pageSrc);
                    if (!File.Exists(Path.Combine(AppPath, m.Groups["filename"].Value)))
                    {
                        await client.DownloadFileTaskAsync(m.Value, Path.Combine(AppPath, m.Groups["filename"].Value));
                        callback("Update Available!");
                    }
                }
            }
        }
    }
}
