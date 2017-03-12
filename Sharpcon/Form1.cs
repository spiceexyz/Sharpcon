using System;
using System.Windows.Forms;

using Newtonsoft.Json;

namespace Sharpcon
{
    public partial class Form1 : Form
    {
        public static Settings settings;
        public static ToolStripStatusLabel status;
        public static RichTextBox console;

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
            settings = Settings.Read();
            status = toolStripStatusLabelRight;
            console = richTextBoxConsole;
            textBoxAddress.Text = settings.ServerAddress;
            textBoxPort.Text = settings.ServerPort;
            textBoxPassword.Text = settings.ServerPassword;
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
        }

        /// <summary>
        /// Called when "Connect" button is clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonConnect_Click(object sender, EventArgs e)
        {
            WebSockets.Connect();
        }

        /// <summary>
        /// Called when "Disconnect" button is clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonDisconnect_Click(object sender, EventArgs e)
        {
            WebSockets.Disconnect();
        }

        /// <summary>
        /// Called when "Send" (command) button is clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonCommand_Click(object sender, EventArgs e)
        {
            WebSockets.Send(JsonConvert.SerializeObject(new Packet(textBoxCommand.Text)));
        }

        /// <summary>
        /// Called when "Send" (broadcast) button is clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonBroadcast_Click(object sender, EventArgs e)
        {
            WebSockets.Send(JsonConvert.SerializeObject(new Packet($"say {textBoxBroadcast.Text}")));
        }
    }
}
