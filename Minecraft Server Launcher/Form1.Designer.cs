namespace Minecraft_Server_Launcher
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.txtServerName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cboGameMode = new System.Windows.Forms.ComboBox();
            this.cboDifficulty = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.chkAllowCheats = new System.Windows.Forms.CheckBox();
            this.numMaxPlayers = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.chkOnlineMode = new System.Windows.Forms.CheckBox();
            this.chkUseWhitelist = new System.Windows.Forms.CheckBox();
            this.numServerPort = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.numServerPortV6 = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.numViewDistance = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.numTickDistance = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.numIdleTimeout = new System.Windows.Forms.NumericUpDown();
            this.label10 = new System.Windows.Forms.Label();
            this.numMaxThreads = new System.Windows.Forms.NumericUpDown();
            this.cboLevelName = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtLevelSeed = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.cboPermission = new System.Windows.Forms.ComboBox();
            this.chkTexturePackRequired = new System.Windows.Forms.CheckBox();
            this.chkLogFileEnabled = new System.Windows.Forms.CheckBox();
            this.label14 = new System.Windows.Forms.Label();
            this.gridPermission = new System.Windows.Forms.DataGridView();
            this.contextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.addToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label15 = new System.Windows.Forms.Label();
            this.gridWhitelist = new System.Windows.Forms.DataGridView();
            this.btnSaveAndStart = new System.Windows.Forms.Button();
            this.cboLevelType = new System.Windows.Forms.ComboBox();
            this.label16 = new System.Windows.Forms.Label();
            this.btnSaveConfig = new System.Windows.Forms.Button();
            this.btnStopServer = new System.Windows.Forms.Button();
            this.txtServerOutput = new System.Windows.Forms.TextBox();
            this.gridPacks = new System.Windows.Forms.DataGridView();
            this.label17 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numMaxPlayers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numServerPort)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numServerPortV6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numViewDistance)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTickDistance)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numIdleTimeout)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMaxThreads)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridPermission)).BeginInit();
            this.contextMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridWhitelist)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridPacks)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Server Name:";
            // 
            // txtServerName
            // 
            this.txtServerName.Location = new System.Drawing.Point(114, 12);
            this.txtServerName.Name = "txtServerName";
            this.txtServerName.Size = new System.Drawing.Size(215, 20);
            this.txtServerName.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Game Mode:";
            // 
            // cboGameMode
            // 
            this.cboGameMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboGameMode.FormattingEnabled = true;
            this.cboGameMode.Items.AddRange(new object[] {
            "adventure",
            "creative",
            "survival"});
            this.cboGameMode.Location = new System.Drawing.Point(114, 118);
            this.cboGameMode.Name = "cboGameMode";
            this.cboGameMode.Size = new System.Drawing.Size(121, 21);
            this.cboGameMode.TabIndex = 3;
            // 
            // cboDifficulty
            // 
            this.cboDifficulty.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDifficulty.FormattingEnabled = true;
            this.cboDifficulty.Items.AddRange(new object[] {
            "peaceful",
            "easy",
            "normal",
            "hard"});
            this.cboDifficulty.Location = new System.Drawing.Point(114, 145);
            this.cboDifficulty.Name = "cboDifficulty";
            this.cboDifficulty.Size = new System.Drawing.Size(121, 21);
            this.cboDifficulty.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(58, 148);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Difficulty:";
            // 
            // chkAllowCheats
            // 
            this.chkAllowCheats.AutoSize = true;
            this.chkAllowCheats.Location = new System.Drawing.Point(177, 200);
            this.chkAllowCheats.Name = "chkAllowCheats";
            this.chkAllowCheats.Size = new System.Drawing.Size(87, 17);
            this.chkAllowCheats.TabIndex = 6;
            this.chkAllowCheats.Text = "Allow Cheats";
            this.chkAllowCheats.UseVisualStyleBackColor = true;
            // 
            // numMaxPlayers
            // 
            this.numMaxPlayers.Location = new System.Drawing.Point(113, 199);
            this.numMaxPlayers.Name = "numMaxPlayers";
            this.numMaxPlayers.Size = new System.Drawing.Size(58, 20);
            this.numMaxPlayers.TabIndex = 7;
            this.numMaxPlayers.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(40, 201);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Max Players:";
            // 
            // chkOnlineMode
            // 
            this.chkOnlineMode.AutoSize = true;
            this.chkOnlineMode.Checked = true;
            this.chkOnlineMode.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkOnlineMode.Location = new System.Drawing.Point(177, 226);
            this.chkOnlineMode.Name = "chkOnlineMode";
            this.chkOnlineMode.Size = new System.Drawing.Size(86, 17);
            this.chkOnlineMode.TabIndex = 9;
            this.chkOnlineMode.Text = "Online Mode";
            this.chkOnlineMode.UseVisualStyleBackColor = true;
            // 
            // chkUseWhitelist
            // 
            this.chkUseWhitelist.AutoSize = true;
            this.chkUseWhitelist.Location = new System.Drawing.Point(177, 252);
            this.chkUseWhitelist.Name = "chkUseWhitelist";
            this.chkUseWhitelist.Size = new System.Drawing.Size(88, 17);
            this.chkUseWhitelist.TabIndex = 10;
            this.chkUseWhitelist.Text = "Use Whitelist";
            this.chkUseWhitelist.UseVisualStyleBackColor = true;
            // 
            // numServerPort
            // 
            this.numServerPort.Location = new System.Drawing.Point(113, 225);
            this.numServerPort.Maximum = new decimal(new int[] {
            65534,
            0,
            0,
            0});
            this.numServerPort.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numServerPort.Name = "numServerPort";
            this.numServerPort.Size = new System.Drawing.Size(58, 20);
            this.numServerPort.TabIndex = 11;
            this.numServerPort.Value = new decimal(new int[] {
            19132,
            0,
            0,
            0});
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(44, 227);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Server Port:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(29, 253);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Server Port v6:";
            // 
            // numServerPortV6
            // 
            this.numServerPortV6.Location = new System.Drawing.Point(113, 251);
            this.numServerPortV6.Maximum = new decimal(new int[] {
            65534,
            0,
            0,
            0});
            this.numServerPortV6.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numServerPortV6.Name = "numServerPortV6";
            this.numServerPortV6.Size = new System.Drawing.Size(58, 20);
            this.numServerPortV6.TabIndex = 13;
            this.numServerPortV6.Value = new decimal(new int[] {
            19133,
            0,
            0,
            0});
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(29, 279);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(78, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "View Distance:";
            // 
            // numViewDistance
            // 
            this.numViewDistance.Location = new System.Drawing.Point(113, 277);
            this.numViewDistance.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numViewDistance.Name = "numViewDistance";
            this.numViewDistance.Size = new System.Drawing.Size(58, 20);
            this.numViewDistance.TabIndex = 15;
            this.numViewDistance.Value = new decimal(new int[] {
            32,
            0,
            0,
            0});
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(31, 305);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(76, 13);
            this.label8.TabIndex = 18;
            this.label8.Text = "Tick Distance:";
            // 
            // numTickDistance
            // 
            this.numTickDistance.Location = new System.Drawing.Point(113, 303);
            this.numTickDistance.Maximum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.numTickDistance.Minimum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.numTickDistance.Name = "numTickDistance";
            this.numTickDistance.Size = new System.Drawing.Size(58, 20);
            this.numTickDistance.TabIndex = 17;
            this.numTickDistance.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(39, 331);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(68, 13);
            this.label9.TabIndex = 20;
            this.label9.Text = "Idle Timeout:";
            // 
            // numIdleTimeout
            // 
            this.numIdleTimeout.Location = new System.Drawing.Point(113, 329);
            this.numIdleTimeout.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numIdleTimeout.Name = "numIdleTimeout";
            this.numIdleTimeout.Size = new System.Drawing.Size(58, 20);
            this.numIdleTimeout.TabIndex = 19;
            this.numIdleTimeout.Value = new decimal(new int[] {
            30,
            0,
            0,
            0});
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(35, 357);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(72, 13);
            this.label10.TabIndex = 22;
            this.label10.Text = "Max Threads:";
            // 
            // numMaxThreads
            // 
            this.numMaxThreads.Location = new System.Drawing.Point(113, 355);
            this.numMaxThreads.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numMaxThreads.Name = "numMaxThreads";
            this.numMaxThreads.Size = new System.Drawing.Size(58, 20);
            this.numMaxThreads.TabIndex = 21;
            this.numMaxThreads.Value = new decimal(new int[] {
            8,
            0,
            0,
            0});
            // 
            // cboLevelName
            // 
            this.cboLevelName.FormattingEnabled = true;
            this.cboLevelName.Location = new System.Drawing.Point(114, 38);
            this.cboLevelName.Name = "cboLevelName";
            this.cboLevelName.Size = new System.Drawing.Size(215, 21);
            this.cboLevelName.TabIndex = 24;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(41, 41);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(67, 13);
            this.label11.TabIndex = 23;
            this.label11.Text = "Level Name:";
            // 
            // txtLevelSeed
            // 
            this.txtLevelSeed.Location = new System.Drawing.Point(114, 65);
            this.txtLevelSeed.Name = "txtLevelSeed";
            this.txtLevelSeed.Size = new System.Drawing.Size(215, 20);
            this.txtLevelSeed.TabIndex = 26;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(44, 68);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(64, 13);
            this.label12.TabIndex = 25;
            this.label12.Text = "Level Seed:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(11, 175);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(97, 13);
            this.label13.TabIndex = 28;
            this.label13.Text = "Default Permission:";
            // 
            // cboPermission
            // 
            this.cboPermission.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboPermission.FormattingEnabled = true;
            this.cboPermission.Items.AddRange(new object[] {
            "visitor",
            "member",
            "operator"});
            this.cboPermission.Location = new System.Drawing.Point(114, 172);
            this.cboPermission.Name = "cboPermission";
            this.cboPermission.Size = new System.Drawing.Size(121, 21);
            this.cboPermission.TabIndex = 27;
            // 
            // chkTexturePackRequired
            // 
            this.chkTexturePackRequired.AutoSize = true;
            this.chkTexturePackRequired.Location = new System.Drawing.Point(177, 278);
            this.chkTexturePackRequired.Name = "chkTexturePackRequired";
            this.chkTexturePackRequired.Size = new System.Drawing.Size(136, 17);
            this.chkTexturePackRequired.TabIndex = 29;
            this.chkTexturePackRequired.Text = "Texture Pack Required";
            this.chkTexturePackRequired.UseVisualStyleBackColor = true;
            // 
            // chkLogFileEnabled
            // 
            this.chkLogFileEnabled.AutoSize = true;
            this.chkLogFileEnabled.Location = new System.Drawing.Point(177, 304);
            this.chkLogFileEnabled.Name = "chkLogFileEnabled";
            this.chkLogFileEnabled.Size = new System.Drawing.Size(105, 17);
            this.chkLogFileEnabled.TabIndex = 30;
            this.chkLogFileEnabled.Text = "Log File Enabled";
            this.chkLogFileEnabled.UseVisualStyleBackColor = true;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(350, 9);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(79, 13);
            this.label14.TabIndex = 31;
            this.label14.Text = "Permission List:";
            // 
            // gridPermission
            // 
            this.gridPermission.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridPermission.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.gridPermission.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridPermission.ContextMenuStrip = this.contextMenu;
            this.gridPermission.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.gridPermission.Location = new System.Drawing.Point(353, 25);
            this.gridPermission.MultiSelect = false;
            this.gridPermission.Name = "gridPermission";
            this.gridPermission.ReadOnly = true;
            this.gridPermission.RowHeadersVisible = false;
            this.gridPermission.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridPermission.Size = new System.Drawing.Size(342, 96);
            this.gridPermission.TabIndex = 32;
            this.gridPermission.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Grid_MouseDown);
            // 
            // contextMenu
            // 
            this.contextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addToolStripMenuItem,
            this.editToolStripMenuItem,
            this.removeToolStripMenuItem});
            this.contextMenu.Name = "contextMenu";
            this.contextMenu.Size = new System.Drawing.Size(118, 70);
            // 
            // addToolStripMenuItem
            // 
            this.addToolStripMenuItem.Name = "addToolStripMenuItem";
            this.addToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.addToolStripMenuItem.Text = "Add";
            this.addToolStripMenuItem.Click += new System.EventHandler(this.ContextMenuToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.editToolStripMenuItem.Text = "Edit";
            this.editToolStripMenuItem.Click += new System.EventHandler(this.ContextMenuToolStripMenuItem_Click);
            // 
            // removeToolStripMenuItem
            // 
            this.removeToolStripMenuItem.Name = "removeToolStripMenuItem";
            this.removeToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.removeToolStripMenuItem.Text = "Remove";
            this.removeToolStripMenuItem.Click += new System.EventHandler(this.ContextMenuToolStripMenuItem_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(349, 124);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(50, 13);
            this.label15.TabIndex = 33;
            this.label15.Text = "Whitelist:";
            // 
            // gridWhitelist
            // 
            this.gridWhitelist.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridWhitelist.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.gridWhitelist.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridWhitelist.ContextMenuStrip = this.contextMenu;
            this.gridWhitelist.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.gridWhitelist.Location = new System.Drawing.Point(353, 140);
            this.gridWhitelist.MultiSelect = false;
            this.gridWhitelist.Name = "gridWhitelist";
            this.gridWhitelist.ReadOnly = true;
            this.gridWhitelist.RowHeadersVisible = false;
            this.gridWhitelist.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridWhitelist.Size = new System.Drawing.Size(342, 96);
            this.gridWhitelist.TabIndex = 34;
            this.gridWhitelist.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Grid_MouseDown);
            // 
            // btnSaveAndStart
            // 
            this.btnSaveAndStart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSaveAndStart.Location = new System.Drawing.Point(539, 357);
            this.btnSaveAndStart.Name = "btnSaveAndStart";
            this.btnSaveAndStart.Size = new System.Drawing.Size(75, 23);
            this.btnSaveAndStart.TabIndex = 35;
            this.btnSaveAndStart.Text = "Start Server";
            this.btnSaveAndStart.UseVisualStyleBackColor = true;
            // 
            // cboLevelType
            // 
            this.cboLevelType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboLevelType.FormattingEnabled = true;
            this.cboLevelType.Items.AddRange(new object[] {
            "DEFAULT",
            "FLAT",
            "LEGACY"});
            this.cboLevelType.Location = new System.Drawing.Point(114, 91);
            this.cboLevelType.Name = "cboLevelType";
            this.cboLevelType.Size = new System.Drawing.Size(122, 21);
            this.cboLevelType.TabIndex = 37;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(41, 94);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(63, 13);
            this.label16.TabIndex = 36;
            this.label16.Text = "Level Type:";
            // 
            // btnSaveConfig
            // 
            this.btnSaveConfig.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSaveConfig.Location = new System.Drawing.Point(458, 357);
            this.btnSaveConfig.Name = "btnSaveConfig";
            this.btnSaveConfig.Size = new System.Drawing.Size(75, 23);
            this.btnSaveConfig.TabIndex = 38;
            this.btnSaveConfig.Text = "Save Config";
            this.btnSaveConfig.UseVisualStyleBackColor = true;
            // 
            // btnStopServer
            // 
            this.btnStopServer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnStopServer.Location = new System.Drawing.Point(620, 357);
            this.btnStopServer.Name = "btnStopServer";
            this.btnStopServer.Size = new System.Drawing.Size(75, 23);
            this.btnStopServer.TabIndex = 39;
            this.btnStopServer.Text = "Stop Server";
            this.btnStopServer.UseVisualStyleBackColor = true;
            // 
            // txtServerOutput
            // 
            this.txtServerOutput.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtServerOutput.Location = new System.Drawing.Point(12, 386);
            this.txtServerOutput.Multiline = true;
            this.txtServerOutput.Name = "txtServerOutput";
            this.txtServerOutput.ReadOnly = true;
            this.txtServerOutput.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtServerOutput.Size = new System.Drawing.Size(683, 150);
            this.txtServerOutput.TabIndex = 40;
            // 
            // gridPacks
            // 
            this.gridPacks.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridPacks.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.gridPacks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridPacks.ContextMenuStrip = this.contextMenu;
            this.gridPacks.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.gridPacks.Location = new System.Drawing.Point(353, 255);
            this.gridPacks.MultiSelect = false;
            this.gridPacks.Name = "gridPacks";
            this.gridPacks.ReadOnly = true;
            this.gridPacks.RowHeadersVisible = false;
            this.gridPacks.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridPacks.Size = new System.Drawing.Size(342, 96);
            this.gridPacks.TabIndex = 42;
            this.gridPacks.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Grid_MouseDown);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(350, 239);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(100, 13);
            this.label17.TabIndex = 41;
            this.label17.Text = "Valid known packs:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(707, 548);
            this.Controls.Add(this.gridPacks);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.txtServerOutput);
            this.Controls.Add(this.btnStopServer);
            this.Controls.Add(this.btnSaveConfig);
            this.Controls.Add(this.cboLevelType);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.btnSaveAndStart);
            this.Controls.Add(this.gridWhitelist);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.gridPermission);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.chkLogFileEnabled);
            this.Controls.Add(this.chkTexturePackRequired);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.cboPermission);
            this.Controls.Add(this.txtLevelSeed);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.cboLevelName);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.numMaxThreads);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.numIdleTimeout);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.numTickDistance);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.numViewDistance);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.numServerPortV6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.numServerPort);
            this.Controls.Add(this.chkUseWhitelist);
            this.Controls.Add(this.chkOnlineMode);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.numMaxPlayers);
            this.Controls.Add(this.chkAllowCheats);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cboDifficulty);
            this.Controls.Add(this.cboGameMode);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtServerName);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Minecraft (Bedrock) Server Launcher";
            ((System.ComponentModel.ISupportInitialize)(this.numMaxPlayers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numServerPort)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numServerPortV6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numViewDistance)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTickDistance)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numIdleTimeout)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMaxThreads)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridPermission)).EndInit();
            this.contextMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridWhitelist)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridPacks)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtServerName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboGameMode;
        private System.Windows.Forms.ComboBox cboDifficulty;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox chkAllowCheats;
        private System.Windows.Forms.NumericUpDown numMaxPlayers;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox chkOnlineMode;
        private System.Windows.Forms.CheckBox chkUseWhitelist;
        private System.Windows.Forms.NumericUpDown numServerPort;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown numServerPortV6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown numViewDistance;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown numTickDistance;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.NumericUpDown numIdleTimeout;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.NumericUpDown numMaxThreads;
        private System.Windows.Forms.ComboBox cboLevelName;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtLevelSeed;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox cboPermission;
        private System.Windows.Forms.CheckBox chkTexturePackRequired;
        private System.Windows.Forms.CheckBox chkLogFileEnabled;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.DataGridView gridPermission;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.DataGridView gridWhitelist;
        private System.Windows.Forms.Button btnSaveAndStart;
        private System.Windows.Forms.ComboBox cboLevelType;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Button btnSaveConfig;
        private System.Windows.Forms.Button btnStopServer;
        private System.Windows.Forms.TextBox txtServerOutput;
        private System.Windows.Forms.DataGridView gridPacks;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.ContextMenuStrip contextMenu;
        private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removeToolStripMenuItem;
    }
}

