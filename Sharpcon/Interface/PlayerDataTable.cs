using System;
using System.Windows.Forms;
using System.Collections.Generic;

using Sharpcon.WebSockets.CustomPackets;

namespace Sharpcon.Interface
{
    public static class PlayerDataTable
    {
        /// <summary>
        /// Clear and update player data box
        /// </summary>
        /// <param name="list"></param>
        public static void Update(List<Player> list)
        {
            Form1.Players.Rows.Clear();

            for (var i = 0; i < list.Count; i++)
            {
                var player = list[i];
                var timeStr = TimeSpan.FromSeconds(player.ConnectedSeconds).ToString(@"hh\:mm\:ss");
                AddNewEntry(i, player.SteamId, player.DisplayName, player.Address, player.Ping, timeStr);
            }
        }

        /// <summary>
        /// Add a new row to the data box
        /// </summary>
        /// <param name="number"></param>
        /// <param name="steamId"></param>
        /// <param name="playerName"></param>
        /// <param name="address"></param>
        /// <param name="ping"></param>
        /// <param name="timeConnected"></param>
        public static void AddNewEntry(int number, string steamId, string playerName, string address, int ping, string timeConnected)
        {
            var row = new DataGridViewRow();
            row.CreateCells(Form1.Players, number, steamId, playerName, address, ping, timeConnected);
            Form1.Players.Rows.Add(row);
        }
    }
}
