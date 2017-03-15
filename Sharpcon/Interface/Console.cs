using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sharpcon.Interface
{
    public static class Console
    {
        public static void AddNewEntry(string text)
        {
            Form1.console.AppendText($"[{DateTime.Now.ToShortTimeString()}] {text}\r\n");
        }

        public static void Clear()
        {
            Form1.console.Clear();
        }
    }
}
