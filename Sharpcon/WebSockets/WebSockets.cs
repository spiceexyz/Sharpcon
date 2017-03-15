using System;
using System.Windows.Forms;

using Newtonsoft.Json;

using WebSocketSharp;

using Sharpcon.Interface;
using Sharpcon.Threading;

namespace Sharpcon.WebSockets
{
    public static class WebSocketsWrapper
    {
        private static WebSocket webSocket;
        private static Random random;

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
            webSocket = new WebSocket($"ws://{Form1.Settings.ServerAddress}:{Form1.Settings.ServerPort}/{Form1.Settings.ServerPassword}");
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
        /// Sends a packet with the specified message and identifier
        /// </summary>
        /// <param name="packet"></param>
        public static void Send(string message, int identifier = 1)
        {
            if (!IsConnected())
            {
                MessageBox.Show("You aren't connected.", "Sharpcon", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var packetObj = new Packet(message, identifier);
            var packetStr = JsonConvert.SerializeObject(packetObj);
            webSocket.SendAsync(packetStr, null);
            ServerConsole.AddNewEntry($"> {packetObj.Message}");
        }

        /// <summary>
        /// Sends a command to the server, while setting up the callback
        /// </summary>
        public static void SendCommand(string command)
        {
            var identifier = 1;

            if (Listener.NeedListener.Contains(command))
            {
                if (random == null)
                    random = new Random(DateTime.Now.Millisecond);

                identifier = random.Next(0, int.MaxValue);

                if (Listener.Listeners.ContainsKey(identifier))
                {
                    MessageBox.Show("Duplicate identifier found!", "Sharpcon", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                Listener.Listeners.Add(identifier, command);
            }

            Send(command, identifier);
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
        private static void WebSocket_OnOpen(object sender, EventArgs e)
        {
            ConnectStatus.SetText("Connected");
            ServerConsole.Enable();
            Update.StartThreads();
        }

        /// <summary>
        /// OnMessage event handler
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private static void WebSocket_OnMessage(object sender, MessageEventArgs e)
        {
            var packet = JsonConvert.DeserializeObject<Packet>(e.Data);

            // If this is a return from something called earlier, process it.
            if (Listener.Listeners.ContainsKey(packet.Identifier))
            {
                Listener.ProcessMessage(packet);
                return;
            }

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
            PlayerCounter.Reset();
            Update.StopThreads();
        }
    }
}
