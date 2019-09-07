using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Minecraft_Server_Launcher
{
    public class EditObject
    {
        public string objType { get; set; }
        public Permission permission { get; set; }
        public Player player { get; set; }
        public Pack pack { get; set; }
        public string verb { get; set; }
    }

    public class Permission
    {
        public string permission { get; set; }
        public string xuid { get; set; }
    }

    public class Player
    {
        public bool ignoresPlayerLimit { get; set; }
        public string name { get; set; }
        public string xuid { get; set; }
    }

    public class Pack
    {
        public string file_version { get; set; }
        public string file_system { get; set; }
        public string path { get; set; }
        public string uuid { get; set; }
        public string version { get; set; }
    }


}
