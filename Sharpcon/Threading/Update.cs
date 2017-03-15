using System;
using System.Threading;

using Sharpcon.WebSockets;

namespace Sharpcon.Threading
{
    public static class Update
    {
        public static Thread PlayerThread;

        public static void StartThreads()
        {
            if (PlayerThread == null)
                PlayerThread = new Thread(new ThreadStart(UpdatePlayers));

            PlayerThread.Start();
        }

        public static void StopThreads()
        {
            if (PlayerThread == null)
                return;

            PlayerThread.Abort();
        }

        public static void UpdatePlayers()
        {
            while (WebSocketsWrapper.IsConnected())
            {
                WebSocketsWrapper.SendCommand("playerlist");
                Thread.Sleep(TimeSpan.FromSeconds(10));
            }
        }
    }
}
