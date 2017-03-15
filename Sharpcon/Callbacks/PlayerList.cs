using System.Collections.Generic;

using Newtonsoft.Json;

using Sharpcon.Interface;
using Sharpcon.WebSockets.CustomPackets;

namespace Sharpcon.Callbacks
{
    public static class PlayerList
    {
        public static List<Player> CurrentPlayers;

        /// <summary>
        /// Update everything related to players
        /// </summary>
        /// <param name="list"></param>
        public static void UpdatePlayers(string list)
        {
            CurrentPlayers = JsonConvert.DeserializeObject<List<Player>>(list);
            PlayerCounter.SetText(CurrentPlayers.Count);
            PlayerDataTable.Update(CurrentPlayers);
        }
    }
}
