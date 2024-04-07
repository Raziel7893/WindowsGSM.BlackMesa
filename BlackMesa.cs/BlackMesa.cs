using WindowsGSM.Functions;
using WindowsGSM.GameServer.Engine;

namespace WindowsGSM.Plugins
{
    public class BlackMesa : Source
    {
        // - Plugin Details
        public Plugin Plugin = new Plugin
        {
            name = "WindowsGSM.BlackMesa",
            author = "Raziel7893",
            description = "WindowsGSM plugin for supporting Black Mesa Dedicated Server",
            version = "1.0",
            url = "https://github.com/Raziel7893/WindowsGSM.BlackMesa",
            color = "#34FFeb"
        };

        public string FullName = "BlackMesa: Dedicated Server";
        public override string Defaultmap { get { return "gasworks"; } }
        public override string Additional { get { return "-tickrate 64"; } }
        public override string Game { get { return "bms"; } }
        public override string AppId { get { return "346680"; } }

        public BlackMesa(Functions.ServerConfig serverData) : base(serverData)
        {
            base.serverData = serverData;
        }
    }
}
