﻿using System;

namespace Sharpcon.Interface
{
    public static class ServerConsole
    {
        /// <summary>
        /// Adds a new line to the server console and formats it
        /// </summary>
        /// <param name="text"></param>
        public static void AddNewEntry(string text)
        {
            Form1.Console.AppendText($"[{DateTime.Now.ToShortTimeString()}] {text}\r\n");
        }

        /// <summary>
        /// Clears the console
        /// </summary>
        public static void Clear()
        {
            Form1.Console.Clear();
        }

        /// <summary>
        /// Disables the console
        /// </summary>
        public static void Disable()
        {
            Form1.Console.Enabled = false;
        }

        /// <summary>
        /// Enables the console
        /// </summary>
        public static void Enable()
        {
            Form1.Console.Enabled = true;
        }
    }
}
