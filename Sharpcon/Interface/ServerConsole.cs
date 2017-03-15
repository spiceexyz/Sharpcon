using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            Form1.console.AppendText($"[{DateTime.Now.ToShortTimeString()}] {text}\r\n");
        }

        /// <summary>
        /// Clears the console
        /// </summary>
        public static void Clear()
        {
            Form1.console.Clear();
        }

        /// <summary>
        /// Disables the console
        /// </summary>
        public static void Disable()
        {
            Form1.console.Enabled = false;
        }

        /// <summary>
        /// Enables the console
        /// </summary>
        public static void Enable()
        {
            Form1.console.Enabled = true;
        }
    }
}
