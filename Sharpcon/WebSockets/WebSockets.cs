using System.Windows.Forms;

using Newtonsoft.Json;

using WebSocketSharp;

using Sharpcon.Interface;

namespace Sharpcon.WebSockets
{
    public static class WebSocketsWrapper
    {
        private static WebSocket webSocket;

        /// <summary>
        /// Connects the websocket while attaching the event handlers
        /// </summary>
        public static void Connect()
        {
            if (IsConnected())
            {
                MessageBox.Show("You're already connected.", "Sharpcon", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            webSocket = new WebSocket($"ws://{Form1.settings.ServerAddress}:{Form1.settings.ServerPort}/{Form1.settings.ServerPassword}");
            webSocket.OnMessage += WebSocket_OnMessage;
            webSocket.OnError += WebSocket_OnError;
            webSocket.ConnectAsync();
        }

        /// <summary>
        /// Disconnects the websocket
        /// </summary>
        public static void Disconnect()
        {
            if (!IsConnected())
            {
                MessageBox.Show("You aren't connected.", "Sharpcon", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            webSocket.CloseAsync();
        }

        /// <summary>
        /// Sends a packet
        /// </summary>
        /// <param name="packet"></param>
        public static void Send(string message)
        {
            if (!IsConnected())
            {
                MessageBox.Show("You aren't connected.", "Sharpcon", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var packetObj = new Packet(message);
            var packetStr = JsonConvert.SerializeObject(packetObj);
            webSocket.SendAsync(packetStr, null);
            Console.AddNewEntry($"> {packetObj.Message}");
        }

        /// <summary>
        /// Checks to see if the websocket is connected or not
        /// </summary>
        /// <returns></returns>
        public static bool IsConnected()
        {
            if (webSocket == null)
                return false;

            return webSocket.ReadyState == WebSocketState.Open;
        }

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

            Console.AddNewEntry(packet.Message);
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
