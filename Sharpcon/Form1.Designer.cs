namespace Sharpcon
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tabPageHome = new System.Windows.Forms.TabPage();
            this.groupBoxConnection = new System.Windows.Forms.GroupBox();
            this.buttonDisconnect = new System.Windows.Forms.Button();
            this.buttonConnect = new System.Windows.Forms.Button();
            this.groupBoxCredentials = new System.Windows.Forms.GroupBox();
            this.buttonSave = new System.Windows.Forms.Button();
            this.checkBoxShowPassword = new System.Windows.Forms.CheckBox();
            this.labelPassword = new System.Windows.Forms.Label();
            this.labelPort = new System.Windows.Forms.Label();
            this.labelAddress = new System.Windows.Forms.Label();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.textBoxPort = new System.Windows.Forms.TextBox();
            this.textBoxAddress = new System.Windows.Forms.TextBox();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPageConsole = new System.Windows.Forms.TabPage();
            this.groupBoxConsole = new System.Windows.Forms.GroupBox();
            this.buttonClear = new System.Windows.Forms.Button();
            this.buttonBroadcast = new System.Windows.Forms.Button();
            this.buttonCommand = new System.Windows.Forms.Button();
            this.labelBroadcast = new System.Windows.Forms.Label();
            this.textBoxBroadcast = new System.Windows.Forms.TextBox();
            this.labelCommand = new System.Windows.Forms.Label();
            this.textBoxCommand = new System.Windows.Forms.TextBox();
            this.richTextBoxConsole = new System.Windows.Forms.RichTextBox();
            this.tabPagePlayers = new System.Windows.Forms.TabPage();
            this.dataGridViewPlayers = new System.Windows.Forms.DataGridView();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabelLeft = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabelRight = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabelSeparator = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabelPlayers = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabelCounter = new System.Windows.Forms.ToolStripStatusLabel();
            this.Number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SteamId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PlayerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ping = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TimeConnected = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPageHome.SuspendLayout();
            this.groupBoxConnection.SuspendLayout();
            this.groupBoxCredentials.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.tabPageConsole.SuspendLayout();
            this.groupBoxConsole.SuspendLayout();
            this.tabPagePlayers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPlayers)).BeginInit();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabPageHome
            // 
            this.tabPageHome.Controls.Add(this.groupBoxConnection);
            this.tabPageHome.Controls.Add(this.groupBoxCredentials);
            this.tabPageHome.Location = new System.Drawing.Point(4, 22);
            this.tabPageHome.Name = "tabPageHome";
            this.tabPageHome.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageHome.Size = new System.Drawing.Size(734, 360);
            this.tabPageHome.TabIndex = 0;
            this.tabPageHome.Text = "Home";
            this.tabPageHome.UseVisualStyleBackColor = true;
            // 
            // groupBoxConnection
            // 
            this.groupBoxConnection.Controls.Add(this.buttonDisconnect);
            this.groupBoxConnection.Controls.Add(this.buttonConnect);
            this.groupBoxConnection.Location = new System.Drawing.Point(6, 6);
            this.groupBoxConnection.Name = "groupBoxConnection";
            this.groupBoxConnection.Size = new System.Drawing.Size(344, 73);
            this.groupBoxConnection.TabIndex = 1;
            this.groupBoxConnection.TabStop = false;
            this.groupBoxConnection.Text = "Connection";
            // 
            // buttonDisconnect
            // 
            this.buttonDisconnect.Location = new System.Drawing.Point(6, 43);
            this.buttonDisconnect.Name = "buttonDisconnect";
            this.buttonDisconnect.Size = new System.Drawing.Size(332, 23);
            this.buttonDisconnect.TabIndex = 1;
            this.buttonDisconnect.Text = "Disconnect";
            this.buttonDisconnect.UseVisualStyleBackColor = true;
            this.buttonDisconnect.Click += new System.EventHandler(this.buttonDisconnect_Click);
            // 
            // buttonConnect
            // 
            this.buttonConnect.Location = new System.Drawing.Point(6, 17);
            this.buttonConnect.Name = "buttonConnect";
            this.buttonConnect.Size = new System.Drawing.Size(332, 23);
            this.buttonConnect.TabIndex = 0;
            this.buttonConnect.Text = "Connect";
            this.buttonConnect.UseVisualStyleBackColor = true;
            this.buttonConnect.Click += new System.EventHandler(this.buttonConnect_Click);
            // 
            // groupBoxCredentials
            // 
            this.groupBoxCredentials.Controls.Add(this.buttonSave);
            this.groupBoxCredentials.Controls.Add(this.checkBoxShowPassword);
            this.groupBoxCredentials.Controls.Add(this.labelPassword);
            this.groupBoxCredentials.Controls.Add(this.labelPort);
            this.groupBoxCredentials.Controls.Add(this.labelAddress);
            this.groupBoxCredentials.Controls.Add(this.textBoxPassword);
            this.groupBoxCredentials.Controls.Add(this.textBoxPort);
            this.groupBoxCredentials.Controls.Add(this.textBoxAddress);
            this.groupBoxCredentials.Location = new System.Drawing.Point(6, 85);
            this.groupBoxCredentials.Name = "groupBoxCredentials";
            this.groupBoxCredentials.Size = new System.Drawing.Size(344, 158);
            this.groupBoxCredentials.TabIndex = 0;
            this.groupBoxCredentials.TabStop = false;
            this.groupBoxCredentials.Text = "Credentials";
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(9, 121);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(324, 23);
            this.buttonSave.TabIndex = 7;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // checkBoxShowPassword
            // 
            this.checkBoxShowPassword.AutoSize = true;
            this.checkBoxShowPassword.Location = new System.Drawing.Point(65, 98);
            this.checkBoxShowPassword.Name = "checkBoxShowPassword";
            this.checkBoxShowPassword.Size = new System.Drawing.Size(102, 17);
            this.checkBoxShowPassword.TabIndex = 6;
            this.checkBoxShowPassword.Text = "Show Password";
            this.checkBoxShowPassword.UseVisualStyleBackColor = true;
            this.checkBoxShowPassword.CheckedChanged += new System.EventHandler(this.checkBoxShowPassword_CheckedChanged);
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.Location = new System.Drawing.Point(6, 74);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(53, 13);
            this.labelPassword.TabIndex = 5;
            this.labelPassword.Text = "Password";
            // 
            // labelPort
            // 
            this.labelPort.AutoSize = true;
            this.labelPort.Location = new System.Drawing.Point(6, 48);
            this.labelPort.Name = "labelPort";
            this.labelPort.Size = new System.Drawing.Size(26, 13);
            this.labelPort.TabIndex = 4;
            this.labelPort.Text = "Port";
            // 
            // labelAddress
            // 
            this.labelAddress.AutoSize = true;
            this.labelAddress.Location = new System.Drawing.Point(6, 22);
            this.labelAddress.Name = "labelAddress";
            this.labelAddress.Size = new System.Drawing.Size(45, 13);
            this.labelAddress.TabIndex = 3;
            this.labelAddress.Text = "Address";
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Location = new System.Drawing.Point(65, 71);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(268, 20);
            this.textBoxPassword.TabIndex = 2;
            this.textBoxPassword.UseSystemPasswordChar = true;
            // 
            // textBoxPort
            // 
            this.textBoxPort.Location = new System.Drawing.Point(65, 45);
            this.textBoxPort.Name = "textBoxPort";
            this.textBoxPort.Size = new System.Drawing.Size(268, 20);
            this.textBoxPort.TabIndex = 1;
            // 
            // textBoxAddress
            // 
            this.textBoxAddress.Location = new System.Drawing.Point(65, 19);
            this.textBoxAddress.Name = "textBoxAddress";
            this.textBoxAddress.Size = new System.Drawing.Size(268, 20);
            this.textBoxAddress.TabIndex = 0;
            // 
            // tabControl
            // 
            this.tabControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl.Controls.Add(this.tabPageHome);
            this.tabControl.Controls.Add(this.tabPageConsole);
            this.tabControl.Controls.Add(this.tabPagePlayers);
            this.tabControl.Location = new System.Drawing.Point(12, 12);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(742, 386);
            this.tabControl.TabIndex = 0;
            // 
            // tabPageConsole
            // 
            this.tabPageConsole.Controls.Add(this.groupBoxConsole);
            this.tabPageConsole.Location = new System.Drawing.Point(4, 22);
            this.tabPageConsole.Name = "tabPageConsole";
            this.tabPageConsole.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageConsole.Size = new System.Drawing.Size(734, 360);
            this.tabPageConsole.TabIndex = 1;
            this.tabPageConsole.Text = "Console";
            this.tabPageConsole.UseVisualStyleBackColor = true;
            // 
            // groupBoxConsole
            // 
            this.groupBoxConsole.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxConsole.Controls.Add(this.buttonClear);
            this.groupBoxConsole.Controls.Add(this.buttonBroadcast);
            this.groupBoxConsole.Controls.Add(this.buttonCommand);
            this.groupBoxConsole.Controls.Add(this.labelBroadcast);
            this.groupBoxConsole.Controls.Add(this.textBoxBroadcast);
            this.groupBoxConsole.Controls.Add(this.labelCommand);
            this.groupBoxConsole.Controls.Add(this.textBoxCommand);
            this.groupBoxConsole.Controls.Add(this.richTextBoxConsole);
            this.groupBoxConsole.Location = new System.Drawing.Point(6, 6);
            this.groupBoxConsole.Name = "groupBoxConsole";
            this.groupBoxConsole.Size = new System.Drawing.Size(722, 349);
            this.groupBoxConsole.TabIndex = 0;
            this.groupBoxConsole.TabStop = false;
            this.groupBoxConsole.Text = "Console";
            // 
            // buttonClear
            // 
            this.buttonClear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonClear.Location = new System.Drawing.Point(637, 294);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(79, 49);
            this.buttonClear.TabIndex = 7;
            this.buttonClear.Text = "Clear";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // buttonBroadcast
            // 
            this.buttonBroadcast.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonBroadcast.Location = new System.Drawing.Point(442, 320);
            this.buttonBroadcast.Name = "buttonBroadcast";
            this.buttonBroadcast.Size = new System.Drawing.Size(189, 23);
            this.buttonBroadcast.TabIndex = 6;
            this.buttonBroadcast.Text = "Send";
            this.buttonBroadcast.UseVisualStyleBackColor = true;
            this.buttonBroadcast.Click += new System.EventHandler(this.buttonBroadcast_Click);
            // 
            // buttonCommand
            // 
            this.buttonCommand.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCommand.Location = new System.Drawing.Point(442, 294);
            this.buttonCommand.Name = "buttonCommand";
            this.buttonCommand.Size = new System.Drawing.Size(189, 23);
            this.buttonCommand.TabIndex = 5;
            this.buttonCommand.Text = "Send";
            this.buttonCommand.UseVisualStyleBackColor = true;
            this.buttonCommand.Click += new System.EventHandler(this.buttonCommand_Click);
            // 
            // labelBroadcast
            // 
            this.labelBroadcast.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelBroadcast.AutoSize = true;
            this.labelBroadcast.Location = new System.Drawing.Point(6, 325);
            this.labelBroadcast.Name = "labelBroadcast";
            this.labelBroadcast.Size = new System.Drawing.Size(89, 13);
            this.labelBroadcast.TabIndex = 4;
            this.labelBroadcast.Text = "Server Broadcast";
            // 
            // textBoxBroadcast
            // 
            this.textBoxBroadcast.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxBroadcast.Location = new System.Drawing.Point(101, 322);
            this.textBoxBroadcast.Name = "textBoxBroadcast";
            this.textBoxBroadcast.Size = new System.Drawing.Size(335, 20);
            this.textBoxBroadcast.TabIndex = 3;
            this.textBoxBroadcast.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxBroadcast_KeyPress);
            // 
            // labelCommand
            // 
            this.labelCommand.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelCommand.AutoSize = true;
            this.labelCommand.Location = new System.Drawing.Point(6, 299);
            this.labelCommand.Name = "labelCommand";
            this.labelCommand.Size = new System.Drawing.Size(88, 13);
            this.labelCommand.TabIndex = 2;
            this.labelCommand.Text = "Server Command";
            // 
            // textBoxCommand
            // 
            this.textBoxCommand.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxCommand.Location = new System.Drawing.Point(101, 296);
            this.textBoxCommand.Name = "textBoxCommand";
            this.textBoxCommand.Size = new System.Drawing.Size(335, 20);
            this.textBoxCommand.TabIndex = 1;
            this.textBoxCommand.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxCommand_KeyPress);
            // 
            // richTextBoxConsole
            // 
            this.richTextBoxConsole.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBoxConsole.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.richTextBoxConsole.Location = new System.Drawing.Point(6, 19);
            this.richTextBoxConsole.Name = "richTextBoxConsole";
            this.richTextBoxConsole.ReadOnly = true;
            this.richTextBoxConsole.Size = new System.Drawing.Size(710, 269);
            this.richTextBoxConsole.TabIndex = 0;
            this.richTextBoxConsole.Text = "";
            // 
            // tabPagePlayers
            // 
            this.tabPagePlayers.Controls.Add(this.dataGridViewPlayers);
            this.tabPagePlayers.Location = new System.Drawing.Point(4, 22);
            this.tabPagePlayers.Name = "tabPagePlayers";
            this.tabPagePlayers.Padding = new System.Windows.Forms.Padding(3);
            this.tabPagePlayers.Size = new System.Drawing.Size(734, 360);
            this.tabPagePlayers.TabIndex = 2;
            this.tabPagePlayers.Text = "Players";
            this.tabPagePlayers.UseVisualStyleBackColor = true;
            // 
            // dataGridViewPlayers
            // 
            this.dataGridViewPlayers.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewPlayers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPlayers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Number,
            this.SteamId,
            this.PlayerName,
            this.Address,
            this.Ping,
            this.TimeConnected});
            this.dataGridViewPlayers.Location = new System.Drawing.Point(6, 6);
            this.dataGridViewPlayers.Name = "dataGridViewPlayers";
            this.dataGridViewPlayers.Size = new System.Drawing.Size(722, 348);
            this.dataGridViewPlayers.TabIndex = 0;
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabelLeft,
            this.toolStripStatusLabelRight,
            this.toolStripStatusLabelSeparator,
            this.toolStripStatusLabelPlayers,
            this.toolStripStatusLabelCounter});
            this.statusStrip.Location = new System.Drawing.Point(0, 410);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(766, 22);
            this.statusStrip.TabIndex = 1;
            this.statusStrip.Text = "statusStrip1";
            // 
            // toolStripStatusLabelLeft
            // 
            this.toolStripStatusLabelLeft.Name = "toolStripStatusLabelLeft";
            this.toolStripStatusLabelLeft.Size = new System.Drawing.Size(42, 17);
            this.toolStripStatusLabelLeft.Text = "Status:";
            // 
            // toolStripStatusLabelRight
            // 
            this.toolStripStatusLabelRight.Name = "toolStripStatusLabelRight";
            this.toolStripStatusLabelRight.Size = new System.Drawing.Size(26, 17);
            this.toolStripStatusLabelRight.Text = "Idle";
            // 
            // toolStripStatusLabelSeparator
            // 
            this.toolStripStatusLabelSeparator.Name = "toolStripStatusLabelSeparator";
            this.toolStripStatusLabelSeparator.Size = new System.Drawing.Size(10, 17);
            this.toolStripStatusLabelSeparator.Text = "|";
            // 
            // toolStripStatusLabelPlayers
            // 
            this.toolStripStatusLabelPlayers.Name = "toolStripStatusLabelPlayers";
            this.toolStripStatusLabelPlayers.Size = new System.Drawing.Size(47, 17);
            this.toolStripStatusLabelPlayers.Text = "Players:";
            // 
            // toolStripStatusLabelCounter
            // 
            this.toolStripStatusLabelCounter.Name = "toolStripStatusLabelCounter";
            this.toolStripStatusLabelCounter.Size = new System.Drawing.Size(13, 17);
            this.toolStripStatusLabelCounter.Text = "0";
            // 
            // Number
            // 
            this.Number.HeaderText = "Number";
            this.Number.Name = "Number";
            this.Number.ReadOnly = true;
            this.Number.Width = 50;
            // 
            // SteamId
            // 
            this.SteamId.HeaderText = "SteamId";
            this.SteamId.Name = "SteamId";
            this.SteamId.ReadOnly = true;
            this.SteamId.Width = 175;
            // 
            // PlayerName
            // 
            this.PlayerName.HeaderText = "PlayerName";
            this.PlayerName.Name = "PlayerName";
            this.PlayerName.ReadOnly = true;
            this.PlayerName.Width = 175;
            // 
            // Address
            // 
            this.Address.HeaderText = "Address";
            this.Address.Name = "Address";
            this.Address.ReadOnly = true;
            this.Address.Width = 150;
            // 
            // Ping
            // 
            this.Ping.HeaderText = "Ping";
            this.Ping.Name = "Ping";
            this.Ping.ReadOnly = true;
            this.Ping.Width = 50;
            // 
            // TimeConnected
            // 
            this.TimeConnected.HeaderText = "TimeConnected";
            this.TimeConnected.Name = "TimeConnected";
            this.TimeConnected.ReadOnly = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(766, 432);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.tabControl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Sharpcon";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabPageHome.ResumeLayout(false);
            this.groupBoxConnection.ResumeLayout(false);
            this.groupBoxCredentials.ResumeLayout(false);
            this.groupBoxCredentials.PerformLayout();
            this.tabControl.ResumeLayout(false);
            this.tabPageConsole.ResumeLayout(false);
            this.groupBoxConsole.ResumeLayout(false);
            this.groupBoxConsole.PerformLayout();
            this.tabPagePlayers.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPlayers)).EndInit();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TabPage tabPageHome;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.GroupBox groupBoxCredentials;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.Label labelPort;
        private System.Windows.Forms.Label labelAddress;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.TextBox textBoxPort;
        private System.Windows.Forms.TextBox textBoxAddress;
        private System.Windows.Forms.CheckBox checkBoxShowPassword;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.TabPage tabPageConsole;
        private System.Windows.Forms.GroupBox groupBoxConsole;
        private System.Windows.Forms.TextBox textBoxCommand;
        private System.Windows.Forms.RichTextBox richTextBoxConsole;
        private System.Windows.Forms.Label labelCommand;
        private System.Windows.Forms.Button buttonBroadcast;
        private System.Windows.Forms.Button buttonCommand;
        private System.Windows.Forms.Label labelBroadcast;
        private System.Windows.Forms.TextBox textBoxBroadcast;
        private System.Windows.Forms.GroupBox groupBoxConnection;
        private System.Windows.Forms.Button buttonDisconnect;
        private System.Windows.Forms.Button buttonConnect;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelLeft;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelRight;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.TabPage tabPagePlayers;
        private System.Windows.Forms.DataGridView dataGridViewPlayers;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelPlayers;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelCounter;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelSeparator;
        private System.Windows.Forms.DataGridViewTextBoxColumn Number;
        private System.Windows.Forms.DataGridViewTextBoxColumn SteamId;
        private System.Windows.Forms.DataGridViewTextBoxColumn PlayerName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Address;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ping;
        private System.Windows.Forms.DataGridViewTextBoxColumn TimeConnected;
    }
}

