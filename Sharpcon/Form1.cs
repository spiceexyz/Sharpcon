using System;
using System.Windows.Forms;

using Sharpcon.Interface;
using Sharpcon.WebSockets;

namespace Sharpcon
{
    public partial class Form1 : Form
    {
        public static Settings Settings;
        public static ToolStripStatusLabel Status;
        public static RichTextBox Console;
        public static ToolStripStatusLabel Counter;
        public static DataGridView Players;

        /// <summary>
        /// Form1 constructor
        /// </summary>
        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Called when Form1 is loading
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_Load(object sender, EventArgs e)
        {
            Settings = Settings.Read();
            Status = toolStripStatusLabelRight;
            Console = richTextBoxConsole;
            Counter = toolStripStatusLabelCounter;
            Players = dataGridViewPlayers;

            textBoxAddress.Text = Settings.ServerAddress;
            textBoxPort.Text = Settings.ServerPort;
            textBoxPassword.Text = Settings.ServerPassword;

            ServerConsole.Disable();
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (WebSocketsWrapper.IsConnected())
                WebSocketsWrapper.Disconnect();
        }

        /// <summary>
        /// Called when the "Show Password" boxed is checked or unchecked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void checkBoxShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            textBoxPassword.UseSystemPasswordChar = !checkBoxShowPassword.Checked;
        }

        /// <summary>
        /// Called when "Save" button is clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonSave_Click(object sender, EventArgs e)
        {
            Settings.Write(new Settings(textBoxAddress.Text, textBoxPort.Text, textBoxPassword.Text));
            Settings = Settings.Read();
        }

        /// <summary>
        /// Called when "Connect" button is clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonConnect_Click(object sender, EventArgs e)
        {
            WebSocketsWrapper.Connect();
        }

        /// <summary>
        /// Called when "Disconnect" button is clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonDisconnect_Click(object sender, EventArgs e)
        {
            WebSocketsWrapper.Disconnect();
        }

        /// <summary>
        /// Called when "Send" (command) button is clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonCommand_Click(object sender, EventArgs e)
        {
            SendCommand();
        }

        /// <summary>
        /// Called when "Send" (broadcast) button is clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonBroadcast_Click(object sender, EventArgs e)
        {
            WebSocketsWrapper.Send($"say {textBoxBroadcast.Text}");
        }

        /// <summary>
        /// Called when a key is pressed in the command box
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textBoxCommand_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((ConsoleKey)e.KeyChar == ConsoleKey.Enter)
                SendCommand();
        }

        /// <summary>
        /// Called when a key is pressed in the broadcast box
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textBoxBroadcast_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((ConsoleKey)e.KeyChar == ConsoleKey.Enter)
                WebSocketsWrapper.Send($"say {textBoxBroadcast.Text}");
        }

        /// <summary>
        /// Called when the "Clear" button is pressed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonClear_Click(object sender, EventArgs e)
        {
            ServerConsole.Clear();
        }

        /// <summary>
        /// Sends a command to the server, while setting up the callback
        /// </summary>
        private void SendCommand()
        {
            var command = textBoxCommand.Text;
            var identifier = 1;

            if (Listener.NeedListener.Contains(command))
            {
                identifier = new Random(DateTime.Now.Millisecond).Next(0, int.MaxValue);

                if (Listener.Listeners.ContainsKey(identifier))
                {
                    MessageBox.Show("Duplicate identifier found!", "Sharpcon", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                Listener.Listeners.Add(identifier, command);
            }

            WebSocketsWrapper.Send(textBoxCommand.Text, identifier);
        }
    }
}
