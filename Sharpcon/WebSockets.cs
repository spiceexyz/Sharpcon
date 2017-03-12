using System;
using System.Windows.Forms;

using Newtonsoft.Json;

using WebSocketSharp;

namespace Sharpcon
{
    public class WebSockets
    {
        private static WebSocket webSocket;

        /// <summary>
        /// Connects a websocket while attaching the event handlers
        /// </summary>
        public static void Connect()
        {
            webSocket = new WebSocket($"ws://{Form1.settings.ServerAddress}:{Form1.settings.ServerPort}/{Form1.settings.ServerPassword}");
            webSocket.OnMessage += WebSocket_OnMessage;
            webSocket.OnError += WebSocket_OnError;
            webSocket.ConnectAsync();
        }

        /// <summary>
        /// Disconnects a websocket
        /// </summary>
        public static void Disconnect()
        {
            if (!IsConnected())
            {
                MessageBox.Show("You aren't connected.", "Sharpcon", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            webSocket.CloseAsync();
        }

        /// <summary>
        /// Sends a packet
        /// </summary>
        /// <param name="packet"></param>
        public static void Send(string packet)
        {
            if (!IsConnected())
            {
                MessageBox.Show("You aren't connected.", "Sharpcon", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            webSocket.SendAsync(packet, null);
        }

        /// <summary>
        /// Checks to see if the websocket is connected or not
        /// </summary>
        /// <returns></returns>
        public static bool IsConnected() =>
            webSocket.ReadyState == WebSocketState.Open;

        /// <summary>
        /// OnMessage event handler
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private static void WebSocket_OnMessage(object sender, MessageEventArgs e)
        {
            var packet = JsonConvert.DeserializeObject<Packet>(e.Data);

            if (packet.Identifier == -1 || string.IsNullOrEmpty(packet.Message))
                return;

            Form1.console.AppendText($"[{DateTime.Now.ToShortTimeString()}] {packet.Message}\r\n");
        }

        /// <summary>
        /// OnError event handler
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private static void WebSocket_OnError(object sender, ErrorEventArgs e)
        {
            MessageBox.Show(e.Message);
        }
    }
}
