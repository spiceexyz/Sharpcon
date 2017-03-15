using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sharpcon.Callbacks;

namespace Sharpcon.WebSockets
{
    public static class Listener
    {
        public static Dictionary<int, string> Listeners = new Dictionary<int, string>();
        public static List<string> NeedListener = new List<string>()
        {
            "playerlist"
        };

        /// <summary>
        /// Callback for listener
        /// </summary>
        /// <param name="packet"></param>
        public static void ProcessMessage(Packet packet)
        {
            var command = Listeners[packet.Identifier];
            Listeners.Remove(packet.Identifier);

            switch (command.ToLower())
            {
                case "playerlist":
                    PlayerList.UpdatePlayers(packet.Message);
                    break;
            }
        }
    }
}
