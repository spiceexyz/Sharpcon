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

            ConnectStatus.SetText("Connecting...");
            webSocket = new WebSocket($"ws://{Form1.settings.ServerAddress}:{Form1.settings.ServerPort}/{Form1.settings.ServerPassword}");
            webSocket.OnOpen += WebSocket_OnOpen;
            webSocket.OnMessage += WebSocket_OnMessage;
            webSocket.OnError += WebSocket_OnError;
            webSocket.OnClose += WebSocket_OnClose;
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

            ConnectStatus.SetText("Disconnecting...");
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
            ServerConsole.AddNewEntry($"> {packetObj.Message}");
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
        /// OnOpen event handler
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private static void WebSocket_OnOpen(object sender, System.EventArgs e)
        {
            ConnectStatus.SetText("Connected");
            ServerConsole.Enable();
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

            ServerConsole.AddNewEntry(packet.Message);
        }

        /// <summary>
        /// OnError event handler
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private static void WebSocket_OnError(object sender, ErrorEventArgs e)
        {
            MessageBox.Show($"An error occurred:\n\n{e.Message}");
        }

        /// <summary>
        /// OnClose event handler
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private static void WebSocket_OnClose(object sender, CloseEventArgs e)
        {
            ConnectStatus.SetText("Disconnected");
            ServerConsole.Disable();
        }
    }
}
