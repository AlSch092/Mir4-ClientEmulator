//By AlSch092 @ Github
﻿namespace Mir4ClientEmulator
{
    partial class MainForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveProfileAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.creditsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.readmeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.languagesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eNToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage_EventLog = new System.Windows.Forms.TabPage();
            this.textBox_LogArea = new System.Windows.Forms.TextBox();
            this.tabPage_RawView = new System.Windows.Forms.TabPage();
            this.listView_RawView = new System.Windows.Forms.ListView();
            this.columnHeader_Direction = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader_Length = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader_Opcode = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader_Data = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.contextMenuStrip_RawView = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.copySelectedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabPage_Info = new System.Windows.Forms.TabPage();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.button_LeaveParty = new System.Windows.Forms.Button();
            this.checkBox_AcceptParties = new System.Windows.Forms.CheckBox();
            this.button_PrintNearbyPlayers = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.button_PrintItems = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.comboBox_GatheringType = new System.Windows.Forms.ComboBox();
            this.comboBox_GatherMap = new System.Windows.Forms.ComboBox();
            this.button_EntityMap = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.numericUpDown_GatherPriority = new System.Windows.Forms.NumericUpDown();
            this.button_CollectEnt = new System.Windows.Forms.Button();
            this.numericUpDown_CollectEnt = new System.Windows.Forms.NumericUpDown();
            this.button_PrintEntityList = new System.Windows.Forms.Button();
            this.checkBox_Gather = new System.Windows.Forms.CheckBox();
            this.groupBox_CharInfo = new System.Windows.Forms.GroupBox();
            this.label_PlayerStage = new System.Windows.Forms.Label();
            this.label_PlayerEnergy = new System.Windows.Forms.Label();
            this.label_UID = new System.Windows.Forms.Label();
            this.label_GatherCounter = new System.Windows.Forms.Label();
            this.label_DarkSteel = new System.Windows.Forms.Label();
            this.label_CharLvl = new System.Windows.Forms.Label();
            this.label_CharName = new System.Windows.Forms.Label();
            this.label_CharZ = new System.Windows.Forms.Label();
            this.label_CharY = new System.Windows.Forms.Label();
            this.label_CharX = new System.Windows.Forms.Label();
            this.groupBox_Movement = new System.Windows.Forms.GroupBox();
            this.comboBox_Warp = new System.Windows.Forms.ComboBox();
            this.button_WarpPortal = new System.Windows.Forms.Button();
            this.button_Teleport = new System.Windows.Forms.Button();
            this.label_Z = new System.Windows.Forms.Label();
            this.label_X = new System.Windows.Forms.Label();
            this.label_Y = new System.Windows.Forms.Label();
            this.numericUpDown_Z = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown_Y = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown_X = new System.Windows.Forms.NumericUpDown();
            this.tabPage_Bots = new System.Windows.Forms.TabPage();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.button_Portal = new System.Windows.Forms.Button();
            this.comboBox_Portal = new System.Windows.Forms.ComboBox();
            this.button_NewDayRoutine = new System.Windows.Forms.Button();
            this.groupBox_Quests = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.checkBox_QuestFromStart = new System.Windows.Forms.CheckBox();
            this.button_PrintQuestList = new System.Windows.Forms.Button();
            this.checkBox_AutoQuest = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label_Radius = new System.Windows.Forms.Label();
            this.numericUpDown_MaxRadius = new System.Windows.Forms.NumericUpDown();
            this.checkBox_KillMonsters = new System.Windows.Forms.CheckBox();
            this.tabPage_Encoder = new System.Windows.Forms.TabPage();
            this.label_SpamPacket = new System.Windows.Forms.Label();
            this.numericUpDown_SpamDelay = new System.Windows.Forms.NumericUpDown();
            this.checkBox_SpamMessage = new System.Windows.Forms.CheckBox();
            this.button_ClearProtobuf = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.numericUpDown_FieldNumber = new System.Windows.Forms.NumericUpDown();
            this.textBox_EncoderValue = new System.Windows.Forms.TextBox();
            this.listBox_EncoderArgs = new System.Windows.Forms.ListBox();
            this.button_SendProtobuf = new System.Windows.Forms.Button();
            this.button_AddEncoderField = new System.Windows.Forms.Button();
            this.comboBox_EncoderType = new System.Windows.Forms.ComboBox();
            this.comboBox_EncoderOpcode = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboBox_LoginMethod = new System.Windows.Forms.ComboBox();
            this.textBox_TokenID = new System.Windows.Forms.TextBox();
            this.textBox_DeviceKey = new System.Windows.Forms.TextBox();
            this.buttonDisconnect = new System.Windows.Forms.Button();
            this.comboBox_World = new System.Windows.Forms.ComboBox();
            this.textBox_CharacterName = new System.Windows.Forms.TextBox();
            this.btnConnect = new System.Windows.Forms.Button();
            this.textBox_SendPacket = new System.Windows.Forms.TextBox();
            this.button_SendPacket = new System.Windows.Forms.Button();
            this.checkBox_Reconnect = new System.Windows.Forms.CheckBox();
            this.checkBox_LogPackets = new System.Windows.Forms.CheckBox();
            this.checkBox_UseConsole = new System.Windows.Forms.CheckBox();
            this.button2 = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage_EventLog.SuspendLayout();
            this.tabPage_RawView.SuspendLayout();
            this.contextMenuStrip_RawView.SuspendLayout();
            this.tabPage_Info.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_GatherPriority)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_CollectEnt)).BeginInit();
            this.groupBox_CharInfo.SuspendLayout();
            this.groupBox_Movement.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Z)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Y)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_X)).BeginInit();
            this.tabPage_Bots.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox_Quests.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_MaxRadius)).BeginInit();
            this.tabPage_Encoder.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_SpamDelay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_FieldNumber)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(721, 24);
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "menuStripMainForm";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveProfileAsToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // saveProfileAsToolStripMenuItem
            // 
            this.saveProfileAsToolStripMenuItem.Name = "saveProfileAsToolStripMenuItem";
            this.saveProfileAsToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.saveProfileAsToolStripMenuItem.Text = "Save Profile As...";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.creditsToolStripMenuItem,
            this.readmeToolStripMenuItem,
            this.languagesToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // creditsToolStripMenuItem
            // 
            this.creditsToolStripMenuItem.Name = "creditsToolStripMenuItem";
            this.creditsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.creditsToolStripMenuItem.Text = "Credits";
            this.creditsToolStripMenuItem.Click += new System.EventHandler(this.creditsToolStripMenuItem_Click);
            // 
            // readmeToolStripMenuItem
            // 
            this.readmeToolStripMenuItem.Name = "readmeToolStripMenuItem";
            this.readmeToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.readmeToolStripMenuItem.Text = "Readme";
            // 
            // languagesToolStripMenuItem
            // 
            this.languagesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.eNToolStripMenuItem});
            this.languagesToolStripMenuItem.Name = "languagesToolStripMenuItem";
            this.languagesToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.languagesToolStripMenuItem.Text = "Languages";
            // 
            // eNToolStripMenuItem
            // 
            this.eNToolStripMenuItem.Name = "eNToolStripMenuItem";
            this.eNToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.eNToolStripMenuItem.Text = "EN";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage_EventLog);
            this.tabControl1.Controls.Add(this.tabPage_RawView);
            this.tabControl1.Controls.Add(this.tabPage_Info);
            this.tabControl1.Controls.Add(this.tabPage_Bots);
            this.tabControl1.Controls.Add(this.tabPage_Encoder);
            this.tabControl1.Location = new System.Drawing.Point(12, 27);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(586, 385);
            this.tabControl1.TabIndex = 8;
            // 
            // tabPage_EventLog
            // 
            this.tabPage_EventLog.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage_EventLog.Controls.Add(this.textBox_LogArea);
            this.tabPage_EventLog.Location = new System.Drawing.Point(4, 22);
            this.tabPage_EventLog.Name = "tabPage_EventLog";
            this.tabPage_EventLog.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_EventLog.Size = new System.Drawing.Size(578, 359);
            this.tabPage_EventLog.TabIndex = 0;
            this.tabPage_EventLog.Text = "Event Log";
            // 
            // textBox_LogArea
            // 
            this.textBox_LogArea.ForeColor = System.Drawing.Color.Gray;
            this.textBox_LogArea.Location = new System.Drawing.Point(5, 6);
            this.textBox_LogArea.Multiline = true;
            this.textBox_LogArea.Name = "textBox_LogArea";
            this.textBox_LogArea.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBox_LogArea.Size = new System.Drawing.Size(567, 347);
            this.textBox_LogArea.TabIndex = 5;
            // 
            // tabPage_RawView
            // 
            this.tabPage_RawView.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage_RawView.Controls.Add(this.listView_RawView);
            this.tabPage_RawView.Location = new System.Drawing.Point(4, 22);
            this.tabPage_RawView.Name = "tabPage_RawView";
            this.tabPage_RawView.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_RawView.Size = new System.Drawing.Size(578, 359);
            this.tabPage_RawView.TabIndex = 1;
            this.tabPage_RawView.Text = "Raw View";
            // 
            // listView_RawView
            // 
            this.listView_RawView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader_Direction,
            this.columnHeader_Length,
            this.columnHeader_Opcode,
            this.columnHeader_Data});
            this.listView_RawView.ContextMenuStrip = this.contextMenuStrip_RawView;
            this.listView_RawView.FullRowSelect = true;
            this.listView_RawView.GridLines = true;
            this.listView_RawView.HideSelection = false;
            this.listView_RawView.Location = new System.Drawing.Point(6, 6);
            this.listView_RawView.Name = "listView_RawView";
            this.listView_RawView.Size = new System.Drawing.Size(566, 347);
            this.listView_RawView.TabIndex = 0;
            this.listView_RawView.UseCompatibleStateImageBehavior = false;
            this.listView_RawView.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader_Direction
            // 
            this.columnHeader_Direction.Text = "In/Out";
            this.columnHeader_Direction.Width = 47;
            // 
            // columnHeader_Length
            // 
            this.columnHeader_Length.Text = "Length";
            this.columnHeader_Length.Width = 48;
            // 
            // columnHeader_Opcode
            // 
            this.columnHeader_Opcode.Text = "Opcode";
            this.columnHeader_Opcode.Width = 55;
            // 
            // columnHeader_Data
            // 
            this.columnHeader_Data.Text = "Data";
            this.columnHeader_Data.Width = 415;
            // 
            // contextMenuStrip_RawView
            // 
            this.contextMenuStrip_RawView.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.copySelectedToolStripMenuItem,
            this.clearToolStripMenuItem});
            this.contextMenuStrip_RawView.Name = "contextMenuStrip_RawView";
            this.contextMenuStrip_RawView.Size = new System.Drawing.Size(150, 48);
            // 
            // copySelectedToolStripMenuItem
            // 
            this.copySelectedToolStripMenuItem.Name = "copySelectedToolStripMenuItem";
            this.copySelectedToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.copySelectedToolStripMenuItem.Text = "Copy Selected";
            this.copySelectedToolStripMenuItem.Click += new System.EventHandler(this.copySelectedToolStripMenuItem_Click);
            // 
            // clearToolStripMenuItem
            // 
            this.clearToolStripMenuItem.Name = "clearToolStripMenuItem";
            this.clearToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.clearToolStripMenuItem.Text = "Clear";
            this.clearToolStripMenuItem.Click += new System.EventHandler(this.clearToolStripMenuItem_Click);
            // 
            // tabPage_Info
            // 
            this.tabPage_Info.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage_Info.Controls.Add(this.groupBox5);
            this.tabPage_Info.Controls.Add(this.groupBox4);
            this.tabPage_Info.Controls.Add(this.groupBox3);
            this.tabPage_Info.Controls.Add(this.groupBox_CharInfo);
            this.tabPage_Info.Controls.Add(this.groupBox_Movement);
            this.tabPage_Info.Location = new System.Drawing.Point(4, 22);
            this.tabPage_Info.Name = "tabPage_Info";
            this.tabPage_Info.Size = new System.Drawing.Size(578, 359);
            this.tabPage_Info.TabIndex = 2;
            this.tabPage_Info.Text = "Info";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.button_LeaveParty);
            this.groupBox5.Controls.Add(this.checkBox_AcceptParties);
            this.groupBox5.Controls.Add(this.button_PrintNearbyPlayers);
            this.groupBox5.Location = new System.Drawing.Point(179, 226);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(141, 104);
            this.groupBox5.TabIndex = 18;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Players";
            // 
            // button_LeaveParty
            // 
            this.button_LeaveParty.Location = new System.Drawing.Point(11, 72);
            this.button_LeaveParty.Name = "button_LeaveParty";
            this.button_LeaveParty.Size = new System.Drawing.Size(120, 23);
            this.button_LeaveParty.TabIndex = 2;
            this.button_LeaveParty.Text = "Leave Party";
            this.button_LeaveParty.UseVisualStyleBackColor = true;
            this.button_LeaveParty.Click += new System.EventHandler(this.button_LeaveParty_Click);
            // 
            // checkBox_AcceptParties
            // 
            this.checkBox_AcceptParties.AutoSize = true;
            this.checkBox_AcceptParties.Location = new System.Drawing.Point(11, 50);
            this.checkBox_AcceptParties.Name = "checkBox_AcceptParties";
            this.checkBox_AcceptParties.Size = new System.Drawing.Size(121, 17);
            this.checkBox_AcceptParties.TabIndex = 1;
            this.checkBox_AcceptParties.Text = "Accept Party Invites";
            this.checkBox_AcceptParties.UseVisualStyleBackColor = true;
            this.checkBox_AcceptParties.CheckedChanged += new System.EventHandler(this.checkBox_AcceptParties_CheckedChanged);
            // 
            // button_PrintNearbyPlayers
            // 
            this.button_PrintNearbyPlayers.Location = new System.Drawing.Point(9, 19);
            this.button_PrintNearbyPlayers.Name = "button_PrintNearbyPlayers";
            this.button_PrintNearbyPlayers.Size = new System.Drawing.Size(122, 23);
            this.button_PrintNearbyPlayers.TabIndex = 0;
            this.button_PrintNearbyPlayers.Text = "Print Nearby Players";
            this.button_PrintNearbyPlayers.UseVisualStyleBackColor = true;
            this.button_PrintNearbyPlayers.Click += new System.EventHandler(this.button_PrintNearbyPlayers_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.button_PrintItems);
            this.groupBox4.Location = new System.Drawing.Point(13, 276);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(107, 60);
            this.groupBox4.TabIndex = 17;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Inventory";
            // 
            // button_PrintItems
            // 
            this.button_PrintItems.Location = new System.Drawing.Point(10, 26);
            this.button_PrintItems.Name = "button_PrintItems";
            this.button_PrintItems.Size = new System.Drawing.Size(86, 23);
            this.button_PrintItems.TabIndex = 0;
            this.button_PrintItems.Text = "Print Item List";
            this.button_PrintItems.UseVisualStyleBackColor = true;
            this.button_PrintItems.Click += new System.EventHandler(this.button_PrintItems_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.comboBox_GatheringType);
            this.groupBox3.Controls.Add(this.comboBox_GatherMap);
            this.groupBox3.Controls.Add(this.button_EntityMap);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.numericUpDown_GatherPriority);
            this.groupBox3.Controls.Add(this.button_CollectEnt);
            this.groupBox3.Controls.Add(this.numericUpDown_CollectEnt);
            this.groupBox3.Controls.Add(this.button_PrintEntityList);
            this.groupBox3.Controls.Add(this.checkBox_Gather);
            this.groupBox3.Location = new System.Drawing.Point(374, 13);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(192, 220);
            this.groupBox3.TabIndex = 16;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Objects, Entities";
            // 
            // comboBox_GatheringType
            // 
            this.comboBox_GatheringType.FormattingEnabled = true;
            this.comboBox_GatheringType.Items.AddRange(new object[] {
            "Mining",
            "Herbs",
            "Energy"});
            this.comboBox_GatheringType.Location = new System.Drawing.Point(10, 101);
            this.comboBox_GatheringType.Name = "comboBox_GatheringType";
            this.comboBox_GatheringType.Size = new System.Drawing.Size(176, 21);
            this.comboBox_GatheringType.TabIndex = 22;
            this.comboBox_GatheringType.Text = "Gathering Type";
            // 
            // comboBox_GatherMap
            // 
            this.comboBox_GatherMap.FormattingEnabled = true;
            this.comboBox_GatherMap.Location = new System.Drawing.Point(10, 74);
            this.comboBox_GatherMap.Name = "comboBox_GatherMap";
            this.comboBox_GatherMap.Size = new System.Drawing.Size(176, 21);
            this.comboBox_GatherMap.TabIndex = 21;
            this.comboBox_GatherMap.Text = "Map to gather in (optional)";
            // 
            // button_EntityMap
            // 
            this.button_EntityMap.Location = new System.Drawing.Point(6, 156);
            this.button_EntityMap.Name = "button_EntityMap";
            this.button_EntityMap.Size = new System.Drawing.Size(180, 25);
            this.button_EntityMap.TabIndex = 20;
            this.button_EntityMap.Text = "Visual Entity Map";
            this.button_EntityMap.UseVisualStyleBackColor = true;
            this.button_EntityMap.Visible = false;
            this.button_EntityMap.Click += new System.EventHandler(this.button_EntityMap_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 13);
            this.label2.TabIndex = 19;
            this.label2.Text = "Minimum Priority:";
            // 
            // numericUpDown_GatherPriority
            // 
            this.numericUpDown_GatherPriority.Location = new System.Drawing.Point(102, 47);
            this.numericUpDown_GatherPriority.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDown_GatherPriority.Name = "numericUpDown_GatherPriority";
            this.numericUpDown_GatherPriority.Size = new System.Drawing.Size(75, 20);
            this.numericUpDown_GatherPriority.TabIndex = 18;
            this.numericUpDown_GatherPriority.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // button_CollectEnt
            // 
            this.button_CollectEnt.Location = new System.Drawing.Point(102, 17);
            this.button_CollectEnt.Name = "button_CollectEnt";
            this.button_CollectEnt.Size = new System.Drawing.Size(75, 23);
            this.button_CollectEnt.TabIndex = 17;
            this.button_CollectEnt.Text = "Collect ID";
            this.button_CollectEnt.UseVisualStyleBackColor = true;
            this.button_CollectEnt.Click += new System.EventHandler(this.button_CollectEnt_Click);
            // 
            // numericUpDown_CollectEnt
            // 
            this.numericUpDown_CollectEnt.Location = new System.Drawing.Point(6, 19);
            this.numericUpDown_CollectEnt.Maximum = new decimal(new int[] {
            1410065408,
            2,
            0,
            0});
            this.numericUpDown_CollectEnt.Name = "numericUpDown_CollectEnt";
            this.numericUpDown_CollectEnt.Size = new System.Drawing.Size(86, 20);
            this.numericUpDown_CollectEnt.TabIndex = 16;
            // 
            // button_PrintEntityList
            // 
            this.button_PrintEntityList.Location = new System.Drawing.Point(6, 187);
            this.button_PrintEntityList.Name = "button_PrintEntityList";
            this.button_PrintEntityList.Size = new System.Drawing.Size(180, 23);
            this.button_PrintEntityList.TabIndex = 11;
            this.button_PrintEntityList.Text = "Print Entity List";
            this.button_PrintEntityList.UseVisualStyleBackColor = true;
            this.button_PrintEntityList.Click += new System.EventHandler(this.button_PrintEntityList_Click);
            // 
            // checkBox_Gather
            // 
            this.checkBox_Gather.AutoSize = true;
            this.checkBox_Gather.Location = new System.Drawing.Point(89, 131);
            this.checkBox_Gather.Name = "checkBox_Gather";
            this.checkBox_Gather.Size = new System.Drawing.Size(97, 17);
            this.checkBox_Gather.TabIndex = 1;
            this.checkBox_Gather.Text = "Auto-Gathering";
            this.checkBox_Gather.UseVisualStyleBackColor = true;
            this.checkBox_Gather.CheckedChanged += new System.EventHandler(this.checkBox_Gather_CheckedChanged);
            // 
            // groupBox_CharInfo
            // 
            this.groupBox_CharInfo.Controls.Add(this.label_PlayerStage);
            this.groupBox_CharInfo.Controls.Add(this.label_PlayerEnergy);
            this.groupBox_CharInfo.Controls.Add(this.label_UID);
            this.groupBox_CharInfo.Controls.Add(this.label_GatherCounter);
            this.groupBox_CharInfo.Controls.Add(this.label_DarkSteel);
            this.groupBox_CharInfo.Controls.Add(this.label_CharLvl);
            this.groupBox_CharInfo.Controls.Add(this.label_CharName);
            this.groupBox_CharInfo.Controls.Add(this.label_CharZ);
            this.groupBox_CharInfo.Controls.Add(this.label_CharY);
            this.groupBox_CharInfo.Controls.Add(this.label_CharX);
            this.groupBox_CharInfo.Location = new System.Drawing.Point(13, 13);
            this.groupBox_CharInfo.Name = "groupBox_CharInfo";
            this.groupBox_CharInfo.Size = new System.Drawing.Size(160, 257);
            this.groupBox_CharInfo.TabIndex = 12;
            this.groupBox_CharInfo.TabStop = false;
            this.groupBox_CharInfo.Text = "Character Info";
            // 
            // label_PlayerStage
            // 
            this.label_PlayerStage.AutoSize = true;
            this.label_PlayerStage.Location = new System.Drawing.Point(7, 156);
            this.label_PlayerStage.Name = "label_PlayerStage";
            this.label_PlayerStage.Size = new System.Drawing.Size(41, 13);
            this.label_PlayerStage.TabIndex = 17;
            this.label_PlayerStage.Text = "Stage: ";
            // 
            // label_PlayerEnergy
            // 
            this.label_PlayerEnergy.AutoSize = true;
            this.label_PlayerEnergy.Location = new System.Drawing.Point(7, 203);
            this.label_PlayerEnergy.Name = "label_PlayerEnergy";
            this.label_PlayerEnergy.Size = new System.Drawing.Size(43, 13);
            this.label_PlayerEnergy.TabIndex = 16;
            this.label_PlayerEnergy.Text = "Energy:";
            // 
            // label_UID
            // 
            this.label_UID.AutoSize = true;
            this.label_UID.Location = new System.Drawing.Point(7, 111);
            this.label_UID.Name = "label_UID";
            this.label_UID.Size = new System.Drawing.Size(32, 13);
            this.label_UID.TabIndex = 15;
            this.label_UID.Text = "UID: ";
            // 
            // label_GatherCounter
            // 
            this.label_GatherCounter.AutoSize = true;
            this.label_GatherCounter.Location = new System.Drawing.Point(6, 227);
            this.label_GatherCounter.Name = "label_GatherCounter";
            this.label_GatherCounter.Size = new System.Drawing.Size(90, 13);
            this.label_GatherCounter.TabIndex = 14;
            this.label_GatherCounter.Text = "Gathering Count: ";
            // 
            // label_DarkSteel
            // 
            this.label_DarkSteel.AutoSize = true;
            this.label_DarkSteel.Location = new System.Drawing.Point(6, 180);
            this.label_DarkSteel.Name = "label_DarkSteel";
            this.label_DarkSteel.Size = new System.Drawing.Size(55, 13);
            this.label_DarkSteel.TabIndex = 13;
            this.label_DarkSteel.Text = "Darksteel:";
            // 
            // label_CharLvl
            // 
            this.label_CharLvl.AutoSize = true;
            this.label_CharLvl.Location = new System.Drawing.Point(8, 132);
            this.label_CharLvl.Name = "label_CharLvl";
            this.label_CharLvl.Size = new System.Drawing.Size(36, 13);
            this.label_CharLvl.TabIndex = 12;
            this.label_CharLvl.Text = "Level:";
            // 
            // label_CharName
            // 
            this.label_CharName.AutoSize = true;
            this.label_CharName.Location = new System.Drawing.Point(6, 89);
            this.label_CharName.Name = "label_CharName";
            this.label_CharName.Size = new System.Drawing.Size(38, 13);
            this.label_CharName.TabIndex = 11;
            this.label_CharName.Text = "Name:";
            // 
            // label_CharZ
            // 
            this.label_CharZ.AutoSize = true;
            this.label_CharZ.Location = new System.Drawing.Point(7, 67);
            this.label_CharZ.Name = "label_CharZ";
            this.label_CharZ.Size = new System.Drawing.Size(17, 13);
            this.label_CharZ.TabIndex = 10;
            this.label_CharZ.Text = "Z:";
            // 
            // label_CharY
            // 
            this.label_CharY.AutoSize = true;
            this.label_CharY.Location = new System.Drawing.Point(6, 43);
            this.label_CharY.Name = "label_CharY";
            this.label_CharY.Size = new System.Drawing.Size(17, 13);
            this.label_CharY.TabIndex = 9;
            this.label_CharY.Text = "Y:";
            // 
            // label_CharX
            // 
            this.label_CharX.AutoSize = true;
            this.label_CharX.Location = new System.Drawing.Point(6, 21);
            this.label_CharX.Name = "label_CharX";
            this.label_CharX.Size = new System.Drawing.Size(17, 13);
            this.label_CharX.TabIndex = 8;
            this.label_CharX.Text = "X:";
            // 
            // groupBox_Movement
            // 
            this.groupBox_Movement.Controls.Add(this.comboBox_Warp);
            this.groupBox_Movement.Controls.Add(this.button_WarpPortal);
            this.groupBox_Movement.Controls.Add(this.button_Teleport);
            this.groupBox_Movement.Controls.Add(this.label_Z);
            this.groupBox_Movement.Controls.Add(this.label_X);
            this.groupBox_Movement.Controls.Add(this.label_Y);
            this.groupBox_Movement.Controls.Add(this.numericUpDown_Z);
            this.groupBox_Movement.Controls.Add(this.numericUpDown_Y);
            this.groupBox_Movement.Controls.Add(this.numericUpDown_X);
            this.groupBox_Movement.Location = new System.Drawing.Point(179, 13);
            this.groupBox_Movement.Name = "groupBox_Movement";
            this.groupBox_Movement.Size = new System.Drawing.Size(141, 207);
            this.groupBox_Movement.TabIndex = 10;
            this.groupBox_Movement.TabStop = false;
            this.groupBox_Movement.Text = "Movement";
            // 
            // comboBox_Warp
            // 
            this.comboBox_Warp.FormattingEnabled = true;
            this.comboBox_Warp.Location = new System.Drawing.Point(7, 148);
            this.comboBox_Warp.Name = "comboBox_Warp";
            this.comboBox_Warp.Size = new System.Drawing.Size(128, 21);
            this.comboBox_Warp.TabIndex = 11;
            // 
            // button_WarpPortal
            // 
            this.button_WarpPortal.Location = new System.Drawing.Point(6, 175);
            this.button_WarpPortal.Name = "button_WarpPortal";
            this.button_WarpPortal.Size = new System.Drawing.Size(129, 23);
            this.button_WarpPortal.TabIndex = 10;
            this.button_WarpPortal.Text = "Warp";
            this.button_WarpPortal.UseVisualStyleBackColor = true;
            this.button_WarpPortal.Click += new System.EventHandler(this.button_WarpPortal_Click);
            // 
            // button_Teleport
            // 
            this.button_Teleport.Location = new System.Drawing.Point(6, 95);
            this.button_Teleport.Name = "button_Teleport";
            this.button_Teleport.Size = new System.Drawing.Size(125, 23);
            this.button_Teleport.TabIndex = 6;
            this.button_Teleport.Text = "Teleport";
            this.button_Teleport.UseVisualStyleBackColor = true;
            this.button_Teleport.Click += new System.EventHandler(this.button_Teleport_Click);
            // 
            // label_Z
            // 
            this.label_Z.AutoSize = true;
            this.label_Z.Location = new System.Drawing.Point(6, 71);
            this.label_Z.Name = "label_Z";
            this.label_Z.Size = new System.Drawing.Size(17, 13);
            this.label_Z.TabIndex = 9;
            this.label_Z.Text = "Z:";
            // 
            // label_X
            // 
            this.label_X.AutoSize = true;
            this.label_X.Location = new System.Drawing.Point(6, 19);
            this.label_X.Name = "label_X";
            this.label_X.Size = new System.Drawing.Size(17, 13);
            this.label_X.TabIndex = 7;
            this.label_X.Text = "X:";
            // 
            // label_Y
            // 
            this.label_Y.AutoSize = true;
            this.label_Y.Location = new System.Drawing.Point(6, 44);
            this.label_Y.Name = "label_Y";
            this.label_Y.Size = new System.Drawing.Size(17, 13);
            this.label_Y.TabIndex = 8;
            this.label_Y.Text = "Y:";
            // 
            // numericUpDown_Z
            // 
            this.numericUpDown_Z.DecimalPlaces = 2;
            this.numericUpDown_Z.Location = new System.Drawing.Point(56, 69);
            this.numericUpDown_Z.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numericUpDown_Z.Minimum = new decimal(new int[] {
            100000000,
            0,
            0,
            -2147483648});
            this.numericUpDown_Z.Name = "numericUpDown_Z";
            this.numericUpDown_Z.Size = new System.Drawing.Size(75, 20);
            this.numericUpDown_Z.TabIndex = 3;
            // 
            // numericUpDown_Y
            // 
            this.numericUpDown_Y.DecimalPlaces = 2;
            this.numericUpDown_Y.Location = new System.Drawing.Point(56, 42);
            this.numericUpDown_Y.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.numericUpDown_Y.Minimum = new decimal(new int[] {
            100000000,
            0,
            0,
            -2147483648});
            this.numericUpDown_Y.Name = "numericUpDown_Y";
            this.numericUpDown_Y.Size = new System.Drawing.Size(75, 20);
            this.numericUpDown_Y.TabIndex = 4;
            // 
            // numericUpDown_X
            // 
            this.numericUpDown_X.DecimalPlaces = 2;
            this.numericUpDown_X.Location = new System.Drawing.Point(56, 16);
            this.numericUpDown_X.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.numericUpDown_X.Minimum = new decimal(new int[] {
            100000000,
            0,
            0,
            -2147483648});
            this.numericUpDown_X.Name = "numericUpDown_X";
            this.numericUpDown_X.Size = new System.Drawing.Size(75, 20);
            this.numericUpDown_X.TabIndex = 5;
            // 
            // tabPage_Bots
            // 
            this.tabPage_Bots.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage_Bots.Controls.Add(this.groupBox6);
            this.tabPage_Bots.Controls.Add(this.button_NewDayRoutine);
            this.tabPage_Bots.Controls.Add(this.groupBox_Quests);
            this.tabPage_Bots.Controls.Add(this.groupBox2);
            this.tabPage_Bots.Location = new System.Drawing.Point(4, 22);
            this.tabPage_Bots.Name = "tabPage_Bots";
            this.tabPage_Bots.Size = new System.Drawing.Size(578, 359);
            this.tabPage_Bots.TabIndex = 5;
            this.tabPage_Bots.Text = "Bots";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.button_Portal);
            this.groupBox6.Controls.Add(this.comboBox_Portal);
            this.groupBox6.Location = new System.Drawing.Point(12, 239);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(166, 84);
            this.groupBox6.TabIndex = 25;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Portal";
            // 
            // button_Portal
            // 
            this.button_Portal.Location = new System.Drawing.Point(12, 47);
            this.button_Portal.Name = "button_Portal";
            this.button_Portal.Size = new System.Drawing.Size(145, 23);
            this.button_Portal.TabIndex = 1;
            this.button_Portal.Text = "Enter Dungeon";
            this.button_Portal.UseVisualStyleBackColor = true;
            this.button_Portal.Click += new System.EventHandler(this.button_Portal_Click);
            // 
            // comboBox_Portal
            // 
            this.comboBox_Portal.FormattingEnabled = true;
            this.comboBox_Portal.Items.AddRange(new object[] {
            "Magic Square 1F",
            "Magic Square 2F",
            "Magic Square 3F",
            "Magic Square 4F",
            "Magic Square 5F",
            "Magic Square 6F",
            "Secret Peak 1F",
            "Secret Peak 2F",
            "Secret Peak 3F",
            "Secret Peak 4F",
            "Secret Peak 5F",
            "Secret Peak 6F",
            ""});
            this.comboBox_Portal.Location = new System.Drawing.Point(12, 19);
            this.comboBox_Portal.Name = "comboBox_Portal";
            this.comboBox_Portal.Size = new System.Drawing.Size(145, 21);
            this.comboBox_Portal.TabIndex = 0;
            this.comboBox_Portal.Text = "Secret Peak 1F";
            // 
            // button_NewDayRoutine
            // 
            this.button_NewDayRoutine.Location = new System.Drawing.Point(167, 19);
            this.button_NewDayRoutine.Name = "button_NewDayRoutine";
            this.button_NewDayRoutine.Size = new System.Drawing.Size(164, 23);
            this.button_NewDayRoutine.TabIndex = 24;
            this.button_NewDayRoutine.Text = "Collect Guild Gifts";
            this.button_NewDayRoutine.UseVisualStyleBackColor = true;
            this.button_NewDayRoutine.Click += new System.EventHandler(this.button_NewDayRoutine_Click);
            // 
            // groupBox_Quests
            // 
            this.groupBox_Quests.Controls.Add(this.label1);
            this.groupBox_Quests.Controls.Add(this.checkBox_QuestFromStart);
            this.groupBox_Quests.Controls.Add(this.button_PrintQuestList);
            this.groupBox_Quests.Controls.Add(this.checkBox_AutoQuest);
            this.groupBox_Quests.Location = new System.Drawing.Point(12, 98);
            this.groupBox_Quests.Name = "groupBox_Quests";
            this.groupBox_Quests.Size = new System.Drawing.Size(149, 135);
            this.groupBox_Quests.TabIndex = 21;
            this.groupBox_Quests.TabStop = false;
            this.groupBox_Quests.Text = "Quests";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "*QUEST = BAN RISK";
            // 
            // checkBox_QuestFromStart
            // 
            this.checkBox_QuestFromStart.AutoSize = true;
            this.checkBox_QuestFromStart.Location = new System.Drawing.Point(10, 46);
            this.checkBox_QuestFromStart.Name = "checkBox_QuestFromStart";
            this.checkBox_QuestFromStart.Size = new System.Drawing.Size(121, 17);
            this.checkBox_QuestFromStart.TabIndex = 2;
            this.checkBox_QuestFromStart.Text = "Start from Beginning";
            this.checkBox_QuestFromStart.UseVisualStyleBackColor = true;
            // 
            // button_PrintQuestList
            // 
            this.button_PrintQuestList.Location = new System.Drawing.Point(10, 103);
            this.button_PrintQuestList.Name = "button_PrintQuestList";
            this.button_PrintQuestList.Size = new System.Drawing.Size(133, 23);
            this.button_PrintQuestList.TabIndex = 1;
            this.button_PrintQuestList.Text = "Print Quest List";
            this.button_PrintQuestList.UseVisualStyleBackColor = true;
            this.button_PrintQuestList.Click += new System.EventHandler(this.button_PrintQuestList_Click);
            // 
            // checkBox_AutoQuest
            // 
            this.checkBox_AutoQuest.AutoSize = true;
            this.checkBox_AutoQuest.Location = new System.Drawing.Point(10, 23);
            this.checkBox_AutoQuest.Name = "checkBox_AutoQuest";
            this.checkBox_AutoQuest.Size = new System.Drawing.Size(93, 17);
            this.checkBox_AutoQuest.TabIndex = 0;
            this.checkBox_AutoQuest.Text = "Auto-Questing";
            this.checkBox_AutoQuest.UseVisualStyleBackColor = true;
            this.checkBox_AutoQuest.CheckedChanged += new System.EventHandler(this.checkBox_AutoQuest_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label_Radius);
            this.groupBox2.Controls.Add(this.numericUpDown_MaxRadius);
            this.groupBox2.Controls.Add(this.checkBox_KillMonsters);
            this.groupBox2.Location = new System.Drawing.Point(12, 19);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(149, 69);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Attacker (BETA)";
            // 
            // label_Radius
            // 
            this.label_Radius.AutoSize = true;
            this.label_Radius.Location = new System.Drawing.Point(7, 45);
            this.label_Radius.Name = "label_Radius";
            this.label_Radius.Size = new System.Drawing.Size(66, 13);
            this.label_Radius.TabIndex = 17;
            this.label_Radius.Text = "Max Radius:";
            // 
            // numericUpDown_MaxRadius
            // 
            this.numericUpDown_MaxRadius.Location = new System.Drawing.Point(79, 42);
            this.numericUpDown_MaxRadius.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.numericUpDown_MaxRadius.Name = "numericUpDown_MaxRadius";
            this.numericUpDown_MaxRadius.Size = new System.Drawing.Size(58, 20);
            this.numericUpDown_MaxRadius.TabIndex = 16;
            this.numericUpDown_MaxRadius.Value = new decimal(new int[] {
            20000,
            0,
            0,
            0});
            // 
            // checkBox_KillMonsters
            // 
            this.checkBox_KillMonsters.AutoSize = true;
            this.checkBox_KillMonsters.Location = new System.Drawing.Point(10, 19);
            this.checkBox_KillMonsters.Name = "checkBox_KillMonsters";
            this.checkBox_KillMonsters.Size = new System.Drawing.Size(110, 17);
            this.checkBox_KillMonsters.TabIndex = 13;
            this.checkBox_KillMonsters.Text = "Auto-Kill Monsters";
            this.checkBox_KillMonsters.UseVisualStyleBackColor = true;
            this.checkBox_KillMonsters.CheckedChanged += new System.EventHandler(this.checkBox_KillMonsters_CheckedChanged);
            // 
            // tabPage_Encoder
            // 
            this.tabPage_Encoder.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage_Encoder.Controls.Add(this.label_SpamPacket);
            this.tabPage_Encoder.Controls.Add(this.numericUpDown_SpamDelay);
            this.tabPage_Encoder.Controls.Add(this.checkBox_SpamMessage);
            this.tabPage_Encoder.Controls.Add(this.button_ClearProtobuf);
            this.tabPage_Encoder.Controls.Add(this.label3);
            this.tabPage_Encoder.Controls.Add(this.numericUpDown_FieldNumber);
            this.tabPage_Encoder.Controls.Add(this.textBox_EncoderValue);
            this.tabPage_Encoder.Controls.Add(this.listBox_EncoderArgs);
            this.tabPage_Encoder.Controls.Add(this.button_SendProtobuf);
            this.tabPage_Encoder.Controls.Add(this.button_AddEncoderField);
            this.tabPage_Encoder.Controls.Add(this.comboBox_EncoderType);
            this.tabPage_Encoder.Controls.Add(this.comboBox_EncoderOpcode);
            this.tabPage_Encoder.Location = new System.Drawing.Point(4, 22);
            this.tabPage_Encoder.Name = "tabPage_Encoder";
            this.tabPage_Encoder.Size = new System.Drawing.Size(578, 359);
            this.tabPage_Encoder.TabIndex = 4;
            this.tabPage_Encoder.Text = "Message Encoder";
            // 
            // label_SpamPacket
            // 
            this.label_SpamPacket.AutoSize = true;
            this.label_SpamPacket.Location = new System.Drawing.Point(13, 301);
            this.label_SpamPacket.Name = "label_SpamPacket";
            this.label_SpamPacket.Size = new System.Drawing.Size(65, 13);
            this.label_SpamPacket.TabIndex = 11;
            this.label_SpamPacket.Text = "Delay (MS) :";
            // 
            // numericUpDown_SpamDelay
            // 
            this.numericUpDown_SpamDelay.Location = new System.Drawing.Point(75, 298);
            this.numericUpDown_SpamDelay.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.numericUpDown_SpamDelay.Name = "numericUpDown_SpamDelay";
            this.numericUpDown_SpamDelay.Size = new System.Drawing.Size(61, 20);
            this.numericUpDown_SpamDelay.TabIndex = 10;
            this.numericUpDown_SpamDelay.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // checkBox_SpamMessage
            // 
            this.checkBox_SpamMessage.AutoSize = true;
            this.checkBox_SpamMessage.Location = new System.Drawing.Point(142, 300);
            this.checkBox_SpamMessage.Name = "checkBox_SpamMessage";
            this.checkBox_SpamMessage.Size = new System.Drawing.Size(53, 17);
            this.checkBox_SpamMessage.TabIndex = 9;
            this.checkBox_SpamMessage.Text = "Spam";
            this.checkBox_SpamMessage.UseVisualStyleBackColor = true;
            this.checkBox_SpamMessage.CheckedChanged += new System.EventHandler(this.checkBox_SpamMessage_CheckedChanged);
            // 
            // button_ClearProtobuf
            // 
            this.button_ClearProtobuf.Location = new System.Drawing.Point(109, 324);
            this.button_ClearProtobuf.Name = "button_ClearProtobuf";
            this.button_ClearProtobuf.Size = new System.Drawing.Size(86, 23);
            this.button_ClearProtobuf.TabIndex = 8;
            this.button_ClearProtobuf.Text = "Clear";
            this.button_ClearProtobuf.UseVisualStyleBackColor = true;
            this.button_ClearProtobuf.Click += new System.EventHandler(this.button_ClearProtobuf_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Field Number:";
            // 
            // numericUpDown_FieldNumber
            // 
            this.numericUpDown_FieldNumber.Location = new System.Drawing.Point(96, 99);
            this.numericUpDown_FieldNumber.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown_FieldNumber.Name = "numericUpDown_FieldNumber";
            this.numericUpDown_FieldNumber.Size = new System.Drawing.Size(99, 20);
            this.numericUpDown_FieldNumber.TabIndex = 6;
            this.numericUpDown_FieldNumber.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // textBox_EncoderValue
            // 
            this.textBox_EncoderValue.Location = new System.Drawing.Point(9, 72);
            this.textBox_EncoderValue.Name = "textBox_EncoderValue";
            this.textBox_EncoderValue.Size = new System.Drawing.Size(186, 20);
            this.textBox_EncoderValue.TabIndex = 5;
            this.textBox_EncoderValue.Text = "Value...";
            // 
            // listBox_EncoderArgs
            // 
            this.listBox_EncoderArgs.FormattingEnabled = true;
            this.listBox_EncoderArgs.Location = new System.Drawing.Point(201, 18);
            this.listBox_EncoderArgs.Name = "listBox_EncoderArgs";
            this.listBox_EncoderArgs.Size = new System.Drawing.Size(360, 329);
            this.listBox_EncoderArgs.TabIndex = 4;
            // 
            // button_SendProtobuf
            // 
            this.button_SendProtobuf.Location = new System.Drawing.Point(9, 324);
            this.button_SendProtobuf.Name = "button_SendProtobuf";
            this.button_SendProtobuf.Size = new System.Drawing.Size(94, 23);
            this.button_SendProtobuf.TabIndex = 3;
            this.button_SendProtobuf.Text = "Send";
            this.button_SendProtobuf.UseVisualStyleBackColor = true;
            this.button_SendProtobuf.Click += new System.EventHandler(this.button_SendProtobuf_Click);
            // 
            // button_AddEncoderField
            // 
            this.button_AddEncoderField.Location = new System.Drawing.Point(9, 126);
            this.button_AddEncoderField.Name = "button_AddEncoderField";
            this.button_AddEncoderField.Size = new System.Drawing.Size(186, 23);
            this.button_AddEncoderField.TabIndex = 2;
            this.button_AddEncoderField.Text = "Add Field";
            this.button_AddEncoderField.UseVisualStyleBackColor = true;
            this.button_AddEncoderField.Click += new System.EventHandler(this.button_AddEncoderField_Click);
            // 
            // comboBox_EncoderType
            // 
            this.comboBox_EncoderType.FormattingEnabled = true;
            this.comboBox_EncoderType.Items.AddRange(new object[] {
            "Int32",
            "Int64",
            "UInt32",
            "UInt64",
            "Single",
            "Double",
            "String"});
            this.comboBox_EncoderType.Location = new System.Drawing.Point(9, 45);
            this.comboBox_EncoderType.Name = "comboBox_EncoderType";
            this.comboBox_EncoderType.Size = new System.Drawing.Size(186, 21);
            this.comboBox_EncoderType.TabIndex = 1;
            this.comboBox_EncoderType.Text = "Type";
            // 
            // comboBox_EncoderOpcode
            // 
            this.comboBox_EncoderOpcode.FormattingEnabled = true;
            this.comboBox_EncoderOpcode.Items.AddRange(new object[] {
            "CLIENT_FRONT_AUTH_CUSTOM_TOKEN  ",
            "CLIENT_FRONT_AUTH_LOGIN  ",
            "CLIENT_FRONT_SERVER_INFO  ",
            "CLIENT_FRONT_AUTH_LOGIN_TEST  ",
            "CLIENT_FRONT_SERVICE_AUTH  ",
            "CLIENT_FRONT_SELECT_WORLD  ",
            "CLIENT_FRONT_CHARACTER_INFO  ",
            "CLIENT_FRONT_CANCEL_WAITING_INFO  ",
            "CLIENT_GAME_AGGRO_INFO  ",
            "CLIENT_GAME_CHARACTER_ACHIEVEMENT_CLEAR_REWARD  ",
            "CLIENT_GAME_CHARACTER_BATTLE_PASS_CLEAR  ",
            "CLIENT_GAME_CHARACTER_BATTLE_PASS_REWARD  ",
            "CLIENT_GAME_CHARACTER_BATTLE_PASS_TICKET  ",
            "CLIENT_GAME_SERVER_CHANGE_LIST  ",
            "CLIENT_GAME_SERVER_CHANGE_START  ",
            "CLIENT_GAME_SERVER_CHANGE_WORLD_LIST  ",
            "CLIENT_GAME_SERVER_CHANGE_STATE  ",
            "CLIENT_GAME_NAME_CHANGE  ",
            "CLIENT_GAME_TRY_CHANGE_MACRO  ",
            "CLIENT_GAME_USER_CHANGE_MACRO  ",
            "CLIENT_GAME_UPDATE_AWAKEN  ",
            "CLIENT_GAME_REQUEST_NOTIFY_ITEM_GAIN  ",
            "CLIENT_GAME_CONTENTS_LOCK_LIST  ",
            "CLIENT_GAME_BUFF_LIST  ",
            "CLIENT_GAME_START_CASTING  ",
            "CLIENT_GAME_CANCEL_CASTING  ",
            "CLIENT_GAME_CHATMSG  ",
            "CLIENT_CHATTING_WHISPER  ",
            "CLIENT_CHATTING_REQUEST_WHISPER_USER_INFO  ",
            "CLIENT_GAME_WORLD_CHATMSG  ",
            "CLIENT_GAME_ITEM_INFO_SHARE  ",
            "CLIENT_WORLD_CHANGE_VOICE_CHAT_STATE  ",
            "CLIENT_GAME_ITEM_INFO_SHARE_WHISPER  ",
            "CLIENT_CHATTING_GUILD_CHATTING_LIST  ",
            "CLIENT_CHATTING_WHISPER_CHATTING_LIST  ",
            "CLIENT_CHATTING_SEARCH_NAME  ",
            "CLIENT_CHATTING_DELETE_WHISPER  ",
            "CLIENT_TRADE_ITEM_INFO_SHARE  ",
            "CLIENT_TRADE_ITEM_INFO_SHARE_WHISPER  ",
            "CLIENT_GAME_SHARE_STAGE_INFO  ",
            "CLIENT_GAME_EQUIP_COSTUME  ",
            "CLIENT_GAME_UNLOCK_COSTUME  ",
            "CLIENT_GAME_COSTUME_COLOR_CHANGE  ",
            "CLIENT_GAME_COSTUME_UPGRADE  ",
            "CLIENT_GAME_EQUIP_COSTUME_NEW  ",
            "CLIENT_GAME_UNEQUIP_COSTUME  ",
            "CLIENT_GAME_PURCHASE_COSTUME  ",
            "CLIENT_GAME_HIDE_COSTUME  ",
            "CLIENT_GAME_CHANGE_COSTUME_COLOR  ",
            "CLIENT_GAME_EQUIP_LUXURY_COSTUME  ",
            "CLIENT_GAME_UNEQUIP_LUXURY_COSTUME  ",
            "CLIENT_GAME_HIDE_LUXURY_COSTUME  ",
            "CLIENT_GAME_EQUIP_ITEM  ",
            "CLIENT_GAME_EQUIP_MAGIC_STONE  ",
            "CLIENT_GAME_UNEQUIP_MAGIC_STONE  ",
            "CLIENT_GAME_MYSTICAL_PIECE_DECK_LIST  ",
            "CLIENT_GAME_MYSTICAL_PIECE_DECK_SET  ",
            "CLIENT_GAME_MYSTICAL_PIECE_DECK_DEL  ",
            "CLIENT_GAME_MYSTICAL_PIECE_DECK_ENABLE  ",
            "CLIENT_GAME_UPGRADE_MASTERY  ",
            "CLIENT_GAME_UPGRADE_MASTERY_LEVEL_LIMIT  ",
            "CLIENT_GAME_FAKE_REWARD  ",
            "CLIENT_GAME_SELL_INVEN_ITEM  ",
            "CLIENT_GAME_SELL_INVEN_ITEM_STACK  ",
            "CLIENT_GAME_BREAK_ITEM  ",
            "CLIENT_GAME_SMELTING_ITEM  ",
            "CLIENT_GAME_CHANGE_OPTION_ITEM  ",
            "CLIENT_GAME_UPGRADE_ITEM  ",
            "CLIENT_GAME_BUY_INVEN  ",
            "CLIENT_GAME_USE_ITEM  ",
            "CLIENT_GAME_MAKE_ITEM  ",
            "CLIENT_GAME_TRANSCENDENCE_ITEM  ",
            "CLIENT_GAME_EQUIP_JEWEL  ",
            "CLIENT_GAME_UPGRADE_JEWEL  ",
            "CLIENT_GAME_EXTRACTION_JEWEL  ",
            "CLIENT_GAME_TRANSFER_ITEM  ",
            "CLIENT_GAME_GET_CHANGE_OPTION  ",
            "CLIENT_GAME_DECIDE_CHANGE_OPTION  ",
            "CLIENT_GAME_SPECIAL_MAKE_ITEM  ",
            "CLIENT_GAME_SWAP_JEWEL  ",
            "CLIENT_GAME_JEWEL_COMPOSE  ",
            "CLIENT_GAME_EXCHANGE_ITEM  ",
            "CLIENT_GAME_ITEM_COMPOSE  ",
            "CLIENT_GAME_CHANGE_ITEM_LOCK  ",
            "CLIENT_GAME_ITEM_RANDOM_EXCHANGE  ",
            "CLIENT_GAME_ITEM_COMPOSE_POINT_REWARD  ",
            "CLIENT_GAME_MAGICSTONE_TRANCE_ITEM  ",
            "CLIENT_GAME_ITEM_COOLTIME  ",
            "CLIENT_GAME_PET_ITEM_TRANCE  ",
            "CLIENT_GAME_MYSTICAL_PIECE_TRANCE_ITEM  ",
            "CLIENT_GAME_AUTH  ",
            "CLIENT_GAME_TIME  ",
            "CLIENT_LOBBY_CHARACTER_LIST_ALL  ",
            "CLIENT_LOBBY_CREATE_CHARACTER  ",
            "CLIENT_LOBBY_CHARACTER_DELETE  ",
            "CLIENT_LOBBY_SELECT_CHARACTER  ",
            "CLIENT_LOBBY_CHARACTER_DELETE_CANCEL  ",
            "CLIENT_LOBBY_CHARACTER_CHANGE_CUSTOMIZE  ",
            "CLIENT_GAME_CHARACTER_EQUIP  ",
            "CLIENT_GAME_CHARACTER_INVEN  ",
            "CLIENT_GAME_CHARACTER_QUEST  ",
            "CLIENT_GAME_CHARACTER_SKILL  ",
            "CLIENT_GAME_CHARACTER_SKILL_DECK_SLOT_DATA  ",
            "CLIENT_GAME_CHARACTER_POST  ",
            "CLIENT_GAME_CHARACTER_ENERGY_POINT_DATA  ",
            "CLIENT_GAME_CHARACTER_ACHIEVEMENT_EXP_DATA  ",
            "CLIENT_GAME_CHARACTER_PLAY_DATA  ",
            "CLIENT_GAME_CHARACTER_ACHIEVEMENT_CLEAR_DATA  ",
            "CLIENT_GAME_QUEST_DAILY_DATA  ",
            "CLIENT_GAME_QUEST_RELATION_DATA  ",
            "CLIENT_GAME_LIST_COSTUME  ",
            "CLIENT_GAME_VEHICLE_LIST  ",
            "CLIENT_GAME_TUTORIAL_CLEAR_LIST  ",
            "CLIENT_GAME_CHARACTER_MAP_WAYPOINT_DATA  ",
            "CLIENT_GAME_CHARACTER_TREASURE_DATA  ",
            "CLIENT_GAME_CHARACTER_HOLY_STUFF_DATA  ",
            "CLIENT_GAME_CHARACTER_MASTERY_DATA  ",
            "CLIENT_GAME_CHARACTER_FORCE_DATA  ",
            "CLIENT_GAME_CHARACTER_FORCE_BLOOD_DATA  ",
            "CLIENT_GAME_CHARACTER_CUSTOM_TITLE_DATA  ",
            "CLIENT_GAME_CHARACTER_CUSTOMIZE_DATA  ",
            "CLIENT_GAME_CHARACTER_QUICKSLOT_DATA  ",
            "CLIENT_GAME_CHARACTER_MAKE_ITME_DATA  ",
            "CLIENT_GAME_CHARACTER_ITME_COLLECTION_DATA  ",
            "CLIENT_GAME_CHARACTER_ITME_COLLECTION_COMPLATE_DATA  ",
            "CLIENT_GAME_CHARACTER_EQUIP_MAGIC_STONE_DATA  ",
            "CLIENT_GAME_CHARACTER_EVENT_DATA  ",
            "CLIENT_GAME_CHARACTER_BATTLE_PASS_CLEAR_DATA  ",
            "CLIENT_GAME_CHARACTER_BATTLE_PASS_REWARD_DATA  ",
            "CLIENT_GAME_CHARACTER_COMPOSE_POINT_DATA  ",
            "CLIENT_GAME_CHARACTER_PERIOD_GOODS_DATA  ",
            "CLIENT_GAME_LUXURY_COSTUME_LIST  ",
            "CLIENT_GAME_LOGIN  ",
            "CLIENT_GAME_REQUEST_RECONNECT  ",
            "CLIENT_GAME_CHARACTER_SUB_QUEST  ",
            "CLIENT_GAME_COST_DATA  ",
            "CLIENT_LOBBY_VOICE_DOWNLOAD_COMPLETE  ",
            "CLIENT_GAME_REQUEST_LOGOUT  ",
            "CLIENT_GAME_CREATE_PARTY_REQUEST  ",
            "CLIENT_GAME_PARTY_INVITE  ",
            "CLIENT_GAME_PARTY_INVITE_REPLY  ",
            "CLIENT_GAME_REQUEST_PARTY_LEAVE  ",
            "CLIENT_GAME_REQUEST_PARTY_MEMBER_KICK  ",
            "CLIENT_GAME_PARTY_VOTE_RESULT  ",
            "CLIENT_GAME_CHANGE_PARTY_LEADER  ",
            "CLIENT_GAME_REQUEST_RECOMMEND_PARTY_MEMBER_LIST  ",
            "CLIENT_GAME_CHANGE_FREE_ENTER_PARTY  ",
            "CLIENT_GAME_REQUEST_CALL_PARTY_MEMBER  ",
            "CLIENT_GAME_REFUSE_MEMBER_CALL  ",
            "CLIENT_GAME_REQUEST_PARTY_USER_POSITION  ",
            "CLIENT_WORLD_FIND_PARTY_LIST  ",
            "CLIENT_WORLD_CHANGE_PARTY_ATTRIBUTE  ",
            "CLIENT_GAME_REQUEST_PARTY_ENTER  ",
            "CLIENT_WORLD_REPLY_PARTY_ENTER_AGREE  ",
            "CLIENT_WORLD_REMOVE_PARTY  ",
            "CLIENT_WORLD_WARP_PARTY_USER_MAGIC_SQUARE_ROOM  ",
            "CLIENT_WORLD_CHANGE_MEMBER_SLOT_CLASS  ",
            "CLIENT_WORLD_PARTY_CHANGE_READY  ",
            "CLIENT_GAME_PARTY_INSTANCE_DUNGEON_ENTER  ",
            "CLIENT_WORLD_PARTY_ADVERTISING  ",
            "CLIENT_WORLD_PARTY_SEARCH  ",
            "CLIENT_WORLD_SET_PARTY_ALARM  ",
            "CLIENT_WORLD_GET_PARTY_ALARM  ",
            "CLIENT_WORLD_GET_PARTY_INFO  ",
            "CLIENT_WORLD_PARTY_TARGET_MONSTER  ",
            "CLIENT_GAME_PARTY_INVITE_ALL  ",
            "CLIENT_GAME_MAIL_LIST  ",
            "CLIENT_GAME_MAIL_RECV_GIFT  ",
            "CLIENT_GAME_MAIL_RECV_GIFT_ALL  ",
            "CLIENT_GAME_MAIL_SEND  ",
            "CLIENT_GAME_NTF_MAIL_READ  ",
            "CLIENT_GAME_MAIL_DEL  ",
            "CLIENT_GAME_MAIL_RECEIVE_NAME  ",
            "CLIENT_GAME_START_QUEST  ",
            "CLIENT_GAME_END_QUEST  ",
            "CLIENT_GAME_QUEST_ACTION  ",
            "CLIENT_GAME_COMPLETE_QUEST  ",
            "CLIENT_GAME_FAILED_QUEST_CONFIRM  ",
            "CLIENT_GAME_ACCEPT_SUBQUEST  ",
            "CLIENT_GAME_COMMIT_SUBQUEST  ",
            "CLIENT_GAME_CANCEL_SUBQUEST  ",
            "CLIENT_GAME_START_PHASING_QUEST  ",
            "CLIENT_GAME_END_PHASING_QUEST  ",
            "CLIENT_GAME_START_QUEST_CINEMATIC  ",
            "CLIENT_GAME_END_QUEST_CINEMATIC  ",
            "CLIENT_GAME_QUEST_NPC_TALK  ",
            "CLIENT_GAME_GUILD_DAILY_MISSION_DATA  ",
            "CLIENT_GAME_ENDQUEST_RELATION_PLUSREWARD  ",
            "CLIENT_GAME_QUEST_TRACKER  ",
            "CLIENT_GAME_ATTACK  ",
            "CLIENT_GAME_ATTACK_CANCEL  ",
            "CLIENT_GAME_LEARN_SKILL  ",
            "CLIENT_GAME_LEVEL_UP_SKILL  ",
            "CLIENT_GAME_ENTER_INVINCIBLE_STATE  ",
            "CLIENT_GAME_LEAVE_INVINCIBLE_STATE  ",
            "CLIENT_GAME_SKILL_PASSIVE_LIST  ",
            "CLIENT_GAME_ATTACK_IN_PHASING  ",
            "CLIENT_GAME_SKILL_DECK_SLOT_SET  ",
            "CLIENT_GAME_SKILL_DECK_SLOT_DEL  ",
            "CLIENT_GAME_SKILL_DECK_CHANGE  ",
            "CLIENT_GAME_SKILL_PASSIVE_GROUP_LIST  ",
            "CLIENT_GAME_ATTACK_CHAIN  ",
            "CLIENT_GAME_ACTIVATE_TRIGGER  ",
            "CLIENT_GAME_REVIVAL  ",
            "CLIENT_GAME_REQUEST_REBIRTH_HELP  ",
            "CLIENT_GAME_REQUEST_DROP_RECEIVE_INFO_LIST  ",
            "CLIENT_GAME_CUSTOMIZE_CHANGE  ",
            "CLIENT_GAME_GUILD_WAR_MONSTER_INTERACTION  ",
            "CLIENT_GAME_CLOSE_GUILD_WAR_MONSTER_INTERACTION  ",
            "CLIENT_GAME_GUILD_WAR_MONSTER_INTERACTION_ACTION  ",
            "CLIENT_GAME_STAT_CONTENTS_LIST  ",
            "CLIENT_GAME_STAT_CONTENTS_TYPE_LIST  ",
            "CLIENT_GAME_ONE_USER_REBIRTH  ",
            "CLIENT_GAME_VEHICLE_RIDE_ON_OFF  ",
            "CLIENT_GAME_VEHICLE_EQUIP  ",
            "CLIENT_GAME_VEHICLE_UNLOCK  ",
            "CLIENT_GAME_VEHICLE_REINFORCE  ",
            "CLIENT_GAME_VEHICLE_UPGRADE  ",
            "CLIENT_GAME_VEHICLE_ITEM_EQUIP  ",
            "CLIENT_GAME_VEHICLE_RIDE_EQUIP  ",
            "CLIENT_GAME_VEHICLE_BUY  ",
            "CLIENT_GAME_WARP_PORTAL  ",
            "CLIENT_GAME_NOTIFY_WARP_READY  ",
            "CLIENT_GAME_WARP_TO_ESCAPE_POS  ",
            "CLIENT_GAME_WAITING_ZONE_WARP  ",
            "CLIENT_GAME_WARP_STATE_CHECK  ",
            "CLIENT_GAME_EMERGENCY_WARP  ",
            "CLIENT_GAME_WARP_USER_STATE  ",
            "CLIENT_GAME_WARP_USER  ",
            "CLIENT_WORLD_INSTANCE_DUNGEON_ENTER  ",
            "CLIENT_GAME_INSTANCE_ZONE_OUT  ",
            "CLIENT_GAME_PREPARE_FORCED_WARP_REPLY  ",
            "CLIENT_GAME_SPAWN  ",
            "CLIENT_WORLD_CHANNEL_LIST  ",
            "CLIENT_GAME_CHANNEL_MOVE  ",
            "CLIENT_GAME_ENTER_OCCUPATION_BATTLE_FIELD  ",
            "CLIENT_GAME_ENTER_MAGIC_SQUARE  ",
            "CLIENT_GAME_REQUEST_MEMBER_DROP_RECEIVE_LIST  ",
            "CLIENT_WORLD_REGISTER_WAITING_ZONE  ",
            "CLIENT_WORLD_CANCEL_REGISTER_WAITING_ZONE  ",
            "CLIENT_WORLD_CANCEL_WAITING_ZONE_ENTER  ",
            "CLIENT_GAME_END_LOADING  ",
            "CLIENT_GAME_HEARTBEAT  ",
            "CLIENT_FRONT_HEARTBEAT  ",
            "CLIENT_GAME_MEDITATION_RESERVE  ",
            "CLIENT_GAME_SYNCLIENT_GAME_MINION  ",
            "CLIENT_GAME_ATTACK_MINION  ",
            "CLIENT_GAME_SYNC_USER  ",
            "CLIENT_GAME_REQUEST_ENTITY_APPEAR_DATA  ",
            "CLIENT_GAME_AUTO_MOVE_DIRECTING  ",
            "CLIENT_GAME_QUEST_MOVE_POS  ",
            "CLIENT_GAME_SYNC_STATE  ",
            "CLIENT_GAME_TARGET_BATTLE_INFO  ",
            "CLIENT_GAME_RECONNECT_SYNC  ",
            "CLIENT_WORLD_MATCHING_REQ  ",
            "CLIENT_GAME_TUTORIAL_CLEAR  ",
            "CLIENT_GAME_REWARD_DAILYHOMEWORK_PLUSREWARD  ",
            "CLIENT_GAME_COMPLETEALL_DAILYHOMEWORK  ",
            "CLIENT_GAME_PK_MODE  ",
            "CLIENT_GAME_PK_MODE_REQUEST  ",
            "CLIENT_GAME_PK_HISTORY_LIST  ",
            "CLIENT_GAME_PK_TRACEABLILITY_CHECK  ",
            "CLIENT_GAME_PK_OFFER_A_REWARD  ",
            "CLIENT_GAME_PK_WANTED_LIST  ",
            "CLIENT_GAME_PK_WANTED_REGISTER  ",
            "CLIENT_GAME_DEATH_PENALTY_LIST  ",
            "CLIENT_GAME_DEATH_PENALTY_GET_EXP  ",
            "CLIENT_WORLD_OTHER_CHARACTER_INFO  ",
            "CLIENT_GAME_CHARACTER_CUSTOM_TITLE_CHANGE  ",
            "CLIENT_GAME_CHARACTER_PROFILE_CHANGE  ",
            "CLIENT_GAME_ZONE_EVENT_NOTIFY  ",
            "CLIENT_GAME_ZONE_EVENT_TIMER  ",
            "CLIENT_GAME_MAP_WAYPOINT_OPEN  ",
            "CLIENT_GAME_GET_TREASURE  ",
            "CLIENT_GAME_TREASURE_OPEN  ",
            "CLIENT_GAME_BUY_ITEM  ",
            "CLIENT_GAME_SHOP_ITEM_DATA  ",
            "CLIENT_GAME_UI_SHOP_VERSION  ",
            "CLIENT_GAME_UI_SHOP_LIMIT_BUY  ",
            "CLIENT_GAME_UI_SHOP_BUY  ",
            "CLIENT_GAME_NPC_SHOP_DATA  ",
            "CLIENT_GAME_NPC_SHOP_BUY  ",
            "CLIENT_GAME_NPC_SHOP_DATA_REFRESH  ",
            "CLIENT_GAME_GUILD_SHOP_LIST  ",
            "CLIENT_GAME_GUILD_SHOP_REGISTER  ",
            "CLIENT_GAME_GUILD_SHOP_BUY  ",
            "CLIENT_GAME_GUILD_SHOP_LOG  ",
            "CLIENT_GAME_DUNGEON_SHOP_BUY  ",
            "CLIENT_SHOP_UI_SHOP_VERSION  ",
            "CLIENT_SHOP_UI_SHOP_REQUEST_METADATA  ",
            "CLIENT_GAME_UI_SHOP_BUYITEM  ",
            "CLIENT_GAME_UI_SHOP_BUY_CASHITEM_START  ",
            "CLIENT_GAME_UI_SHOP_BUY_CASHITEM_VERIFY  ",
            "CLIENT_GAME_CHARACTER_CASHBAG_DATA  ",
            "CLIENT_GAME_RECEIVE_CASHBAG_ITEM  ",
            "CLIENT_GAME_GET_CASHBAG_ITEM  ",
            "CLIENT_GAME_UI_SHOP_BUY_CASHITEM_PRE_VERIFY  ",
            "CLIENT_SHOP_UI_SHOP_REQUEST_METADATA_DIVISION  ",
            "CLIENT_GAME_GET_PERIOD_GOODS  ",
            "CLIENT_GAME_UI_SHOP_BUY_CASHITEM_PROMO_VERIFY  ",
            "CLIENT_GAME_UI_SHOP_LIMIT_BUY_LIST  ",
            "CLIENT_SHOP_UI_SHOP_REQUEST_METADATA_SIMPLE  ",
            "CLIENT_SHOP_XDRACO_STORAGE_LIST  ",
            "CLIENT_GAME_UI_SHOP_HYDRA_ORACLE  ",
            "CLIENT_GAME_UI_SHOP_BUY_CASHITEM_START_HYDRA  ",
            "CLIENT_GAME_UI_SHOP_BUY_CASHITEM_VERIFY_HYDRA  ",
            "CLIENT_GAME_HOLY_STUFF_INFO  ",
            "CLIENT_GAME_HOLY_STUFF_SLOT_LEVELUP  ",
            "CLIENT_GAME_HOLY_STUFF_GRADE_UPGRADE  ",
            "CLIENT_GAME_GUILD_CREATION  ",
            "CLIENT_WORLD_GUILD_DELETE  ",
            "CLIENT_WORLD_GUILD_SORT_LIST  ",
            "CLIENT_WORLD_GUILD_MY_GUILD_INFO  ",
            "CLIENT_WORLD_GUILD_CHANGE_PR  ",
            "CLIENT_WORLD_GUILD_OTHER_GUILD_UI_INFO  ",
            "CLIENT_WORLD_GUILD_MEMBER_LIST  ",
            "CLIENT_WORLD_GUILD_MEMBER_INVITE  ",
            "CLIENT_WORLD_GUILD_MEMBER_INVITE_AGREE  ",
            "CLIENT_WORLD_GUILD_MEMBER_INVITE_CANCEL  ",
            "CLIENT_WORLD_GUILD_MEMBER_INVITE_LIST  ",
            "CLIENT_WORLD_GUILD_INVITE_ME_LIST  ",
            "CLIENT_WORLD_GUILD_MY_APPLICANT_LIST  ",
            "CLIENT_WORLD_GUILD_MEMBER_JOIN_APPLICANT  ",
            "CLIENT_WORLD_GUILD_MEMBER_JOIN_APPLICANT_AGREE  ",
            "CLIENT_WORLD_GUILD_MEMBER_JOIN_APPLICANT_LIST  ",
            "CLIENT_WORLD_GUILD_MEMBER_JOIN_APPLICANT_CANCEL  ",
            "CLIENT_WORLD_GUILD_MEMBER_JOIN_REQUEST_LIST  ",
            "CLIENT_WORLD_GUILD_MEMBER_LEAVE  ",
            "CLIENT_WORLD_GUILD_MEMBER_KICK  ",
            "CLIENT_WORLD_GUILD_JOIN_TYPE  ",
            "CLIENT_WORLD_GUILD_MEMBER_CUSTOM_TITLE_SET  ",
            "CLIENT_WORLD_GUILD_HOSTILITY_MY_GUILD_UI_LIST  ",
            "CLIENT_WORLD_GUILD_HOSTILITY_ADD  ",
            "CLIENT_WORLD_GUILD_HOSTILITY_DEL  ",
            "CLIENT_WORLD_GUILD_MEMBER_POSITION_SET  ",
            "CLIENT_WORLD_GUILD_GRADE_INFO_SET  ",
            "CLIENT_WORLD_GUILD_MEMBER_GRADE_SET  ",
            "CLIENT_WORLD_GUILD_MEMBER_AUTHORITY_SET  ",
            "CLIENT_WORLD_GUILD_MEMBER_SETTING_INFO  ",
            "CLIENT_WORLD_GUILD_NAME_CHANGE  ",
            "CLIENT_GAME_GUILD_DONATION  ",
            "CLIENT_GAME_GUILD_COST_GIVE  ",
            "CLIENT_GAME_GUILD_FRIENDSHIP_LIST  ",
            "CLIENT_GAME_TRANSLTAE_TEXT  ",
            "CLIENT_GAME_SAVE_TRANSLTE_TEXT  ",
            "CLIENT_WORLD_GUILD_MY_GUILD_UI_ETC_INFO  ",
            "CLIENT_WORLD_GUILD_OPTION_SET  ",
            "CLIENT_WORLD_GUILD_OPTION_LIST  ",
            "CLIENT_WORLD_GUILD_ALLIANCE_LIST  ",
            "CLIENT_WORLD_GUILD_ALLIANCE_APPLICANT  ",
            "CLIENT_WORLD_GUILD_ALLIANCE_APPLICANT_AGREE  ",
            "CLIENT_WORLD_GUILD_ALLIANCE_APPLICANT_CANCEL  ",
            "CLIENT_WORLD_GUILD_ALLIANCE_DEL  ",
            "CLIENT_GAME_GUILD_SUPPLY_TIME  ",
            "CLIENT_GAME_GUILD_SUPPLY_GET  ",
            "CLIENT_GAME_ADD_EXCEPT_ATTACK_GUILD  ",
            "CLIENT_GAME_DEL_EXCEPT_ATTACK_GUILD  ",
            "CLIENT_GAME_EXCEPT_ATTACK_GUILD_LIST  ",
            "CLIENT_WORLD_GUILD_DEVELOP_LIST  ",
            "CLIENT_WORLD_GUILD_DEVELOP_DETAIL  ",
            "CLIENT_WORLD_GUILD_DEVELOP_RECOMMEND  ",
            "CLIENT_WORLD_GUILD_DEVELOP_LEVELUP_START  ",
            "CLIENT_WORLD_GUILD_DEVELOP_LEVELUP_COMPLETE  ",
            "CLIENT_WORLD_GUILD_DEVELOP_DONATION  ",
            "CLIENT_WORLD_GUILD_WANTED_LIST  ",
            "CLIENT_WORLD_GUILD_WANTED_ADD  ",
            "CLIENT_GAME_GUILD_HISTORY_LIST  ",
            "CLIENT_WORLD_GUILD_PARTNER_MEMBET_SET  ",
            "CLIENT_GAME_RECOMMEND_MEMBER_INVITE_LIST  ",
            "CLIENT_GAME_GUILD_DEVELOP_SKILL_START  ",
            "CLIENT_GAME_GUILD_DONATION_INFO  ",
            "CLIENT_GAME_GUILD_COST_GIVE_TO_OTHER_USER  ",
            "CLIENT_GAME_GUILD_COST_GIVE_TO_OTHER_GUILD  ",
            "CLIENT_GAME_GUILD_COST_EXCHANGE  ",
            "CLIENT_GAME_GUILD_DONATION_DETAIL_INFO_LIST  ",
            "CLIENT_GAME_GUILD_INVEN_UI_INFO  ",
            "CLIENT_GAME_GUILD_NPC_SHOP_INFO  ",
            "CLIENT_GAME_GUILD_NPC_SHOP_OPEN  ",
            "CLIENT_GAME_GUILD_NPC_SHOP_CLOSE  ",
            "CLIENT_GAME_GUILD_NPC_SHOP_RE_OPEN  ",
            "CLIENT_GAME_GUILD_NPC_SHOP_TAKE_OUT  ",
            "CLIENT_WORLD_GUILD_SORT_LIST_BY_FRIENDSHIP_FIRST  ",
            "CLIENT_GAME_GUILD_COMMAND_MARK_SET  ",
            "CLIENT_WORLD_REQ_SIEGE_INFO_LIST  ",
            "CLIENT_GAME_REQ_SIEGE_RANK_INFO  ",
            "CLIENT_WORLD_REQ_SIEGE_AUCTION_BIDDING  ",
            "CLIENT_GAME_REQ_SIEGE_WEAPON_BUY  ",
            "CLIENT_GAME_FORCE_LEARN  ",
            "CLIENT_GAME_FORCE_BLOOD_UPGRADE  ",
            "CLIENT_GAME_FORCE_CURE  ",
            "CLIENT_GAME_FORCE_UPGRADE  ",
            "CLIENT_GAME_FORCE_UPGRADE_APPLY  ",
            "CLIENT_GAME_DUEL_REQUEST  ",
            "CLIENT_GAME_DUEL_REQUEST_AGREE  ",
            "CLIENT_GAME_DUEL_GIVEUP  ",
            "CLIENT_GAME_CREATE_HUNTING_SQUAD  ",
            "CLIENT_GAME_INVITE_HUNTING_SQUAD  ",
            "CLIENT_GAME_REPLY_INVITE_AGREE_HUNTING_SQUAD  ",
            "CLIENT_GAME_REQUEST_ENTER_HUNTING_SQUAD  ",
            "CLIENT_GAME_REQUEST_LEAVE_HUNTING_SQUAD  ",
            "CLIENT_WORLD_LOCK_SLOT  ",
            "CLIENT_WORLD_UNLOCK_SLOT  ",
            "CLIENT_WORLD_REQUEST_KICK_USER  ",
            "CLIENT_WORLD_HUNTING_SQUAD_LIST  ",
            "CLIENT_WORLD_HUNTING_SQUAD_NOTIFY_READY  ",
            "CLIENT_WORLD_REQUEST_RECOMMEND_HUNTING_SQUAD_LIST  ",
            "CLIENT_GAME_DUNGEON_TICKET_INFO  ",
            "CLIENT_GAME_DUNGEON_TICKET_CHARGE  ",
            "CLIENT_WORLD_WORLD_EVENT_BOSS_LIST  ",
            "CLIENT_WORLD_WORLD_BOSS_ZONE_LIST  ",
            "CLIENT_GAME_WORLD_BOSS_CONTRIBUTE_INFO  ",
            "CLIENT_GAME_BOSS_CONTRIBUTE_LIST  ",
            "CLIENT_GAME_BOSS_DROP_ITEM_LIST  ",
            "CLIENT_GAME_BOSS_SPAWN_LIST  ",
            "CLIENT_GAME_USER_EVENT_INFO  ",
            "CLIENT_GAME_EVENT_PROGRESS  ",
            "CLIENT_GAME_UNATTENDED_STEP_ATTENDED_PROGRESS  ",
            "CLIENT_GAME_BENEDICTION_EVENT_DATA  ",
            "CLIENT_GAME_BENEDICTION_EVENT_SELECT  ",
            "CLIENT_GAME_CHANGE_ROOM_IN_MAGIC_SQUARE  ",
            "CLIENT_GAME_LEAVE_MAGIC_SQUARE  ",
            "CLIENT_GAME_MAGIC_SQUARE_TIME_EXTEND  ",
            "CLIENT_GAME_QUICKSLOT_UPDATE  ",
            "CLIENT_GAME_ENTER_SECRET_DUNGEON  ",
            "CLIENT_GAME_LEAVE_SECRET_DUNGEON  ",
            "CLIENT_GAME_SECRET_DUNGEON_TIME_EXTEND  ",
            "CLIENT_WORLD_FRIEND_LIST  ",
            "CLIENT_WORLD_FRIEND_REQUEST_LIST  ",
            "CLIENT_WORLD_RECOMMEND_FRIEND_LIST  ",
            "CLIENT_WORLD_FRIEND_INVITE  ",
            "CLIENT_WORLD_FRIEND_INVITE_CANCEL  ",
            "CLIENT_WORLD_FRIEND_INVITE_AGREE  ",
            "CLIENT_WORLD_FRIEND_DEL  ",
            "CLIENT_WORLD_FRIEND_SEARCH  ",
            "CLIENT_WORLD_FRIEND_FAVORITES  ",
            "CLIENT_GAME_GAME_OPTION_LIST  ",
            "CLIENT_GAME_CHANGE_GAME_OPTION  ",
            "CLIENT_GAME_FAME_LIST  ",
            "CLIENT_GAME_PET_LIST  ",
            "CLIENT_GAME_PET_UNLOCK  ",
            "CLIENT_GAME_PET_SET_DECK  ",
            "CLIENT_GAME_PET_DEL_DECK  ",
            "CLIENT_GAME_PET_DECK_CHANGE  ",
            "CLIENT_GAME_PET_EQUIP_ITEM  ",
            "CLIENT_GAME_PET_UNEQUIP_ITEM  ",
            "CLIENT_WORLD_UNSEALING_LIST  ",
            "CLIENT_WORLD_UNSEALING_REGISTER  ",
            "CLIENT_WORLD_UNSEALING_ACCELERATE  ",
            "CLIENT_WORLD_UNSEALING_SUPPORT_LIST  ",
            "CLIENT_WORLD_UNSEALING_SUPPORT_REGISTER  ",
            "CLIENT_WORLD_UNSEALING_SUPPORT  ",
            "CLIENT_WORLD_UNSEALING_GET  ",
            "CLIENT_WORLD_UNSEALING_ACCELERATE_POINT  ",
            "CLIENT_GAME_UNSEALING_GET_ALL  ",
            "CLIENT_CHATTING_BLOCK_LIST  ",
            "CLIENT_CHATTING_ADD_BLOCK  ",
            "CLIENT_CHATTING_CANCEL_BLOCK  ",
            "CLIENT_WORLD_SEARCH  ",
            "CLIENT_GAME_ITEM_COLLECTION_REGISTER  ",
            "CLIENT_GAME_ITEM_DURABILITY_REPAIR  ",
            "CLIENT_GAME_IMMEDIATELY_SICKNESS_RECOVERY  ",
            "CLIENT_GAME_SICKNESS_RECOVERY_SUPPORT_REGISTER  ",
            "CLIENT_GAME_REQ_GUILD_WAR_BOARD_INFO  ",
            "CLIENT_GAME_REQ_GUILD_WAR_COMMAND  ",
            "CLIENT_GAME_REGISTER_TRADE_ITEM  ",
            "CLIENT_GAME_REGISTER_CANCEL  ",
            "CLIENT_GAME_PURCHASE_TRADE_ITEM  ",
            "CLIENT_GAME_CALCULATE_TRADE_ITEM  ",
            "CLIENT_TRADE_SEARCH_SALES_LIST  ",
            "CLIENT_TRADE_SEARCH_SALES_DETAIL_LIST  ",
            "CLIENT_TRADE_REGISTER_LIST  ",
            "CLIENT_TRADE_REGISTER_DETAIL_INFO  ",
            "CLIENT_TRADE_CALCULATE_LOG_LIST  ",
            "CLIENT_TRADE_AVERAGE_PRICE  ",
            "CLIENT_TRADE_SEARCH_BOOKMARK_LIST  ",
            "CLIENT_TRADE_PURCHASE_LOG_LIST  ",
            "CLIENT_WORLD_REQ_STRONG_POINT_INFO_LIST  ",
            "CLIENT_GAME_GREAT_BUILDING_INFO  ",
            "CLIENT_GAME_OPEN_BUILDING  ",
            "CLIENT_GAME_UPGRADE_BUILDING_REQUEST  ",
            "CLIENT_GAME_UPGRADE_BUILDING_REQUEST_COMPLETE  ",
            "CLIENT_GAME_UPGRADE_ACCELERATION  ",
            "CLIENT_GAME_RANKING_INFO  ",
            "CLIENT_GAME_GUILD_GIFT_LIST  ",
            "CLIENT_GAME_GUILD_GIFT_OPEN  ",
            "CLIENT_GAME_OPEN_GUILD_GIFT_DELETE  ",
            "CLIENT_GAME_GUILD_KEY_BOX_OPEN  ",
            "CLIENT_GAME_GUILD_GIFT_OPEN_ALL  ",
            "CLIENT_WORLD_GUILD_EXPEDITION_LIST  ",
            "CLIENT_GAME_GUILD_EXPEDITION_CREATE  ",
            "CLIENT_WORLD_GUILD_EXPEDITION_DETAIL  ",
            "CLIENT_GAME_ITEM_STORAGE_LIST  ",
            "CLIENT_GAME_ITEM_STORAGE_SAVE  ",
            "CLIENT_GAME_ITEM_STORAGE_TAKE_OUT  ",
            "CLIENT_GAME_ITEM_STORAGE_EXTEND  ",
            "CLIENT_GAME_ITEM_XDRACO_STORAGE_SAVE  ",
            "CLIENT_GAME_ITEM_XDRACO_STORAGE_TAKE_OUT  ",
            "CLIENT_GAME_XDRACO_STORAGE_ITEM_LOCK_CHECK  ",
            "CLIENT_GATEWAY_HEARTBEAT  ",
            "CLIENT_GATEWAY_UNCHEATER_RESPONSE  ",
            "CLIENT_GAME_MAGIC_STONE_DECK_LIST  ",
            "CLIENT_GAME_MAGIC_STONE_DECK_SET  ",
            "CLIENT_GAME_MAGIC_STONE_DECK_DEL  ",
            "CLIENT_GAME_MAGIC_STONE_DECK_ENABLE  ",
            "CLIENT_FRONT_WORLD_AND_CHARACTER_INFO  ",
            "CLIENT_GAME_ADS_INFO  ",
            "CLIENT_GAME_ADS_GET_REWARD  ",
            "CLIENT_GAME_ADS_VIEW_END  ",
            "CLIENT_GAME_SERVER_EXPEDITION_INFO  ",
            "CLIENT_GAME_SERVER_EXPEDITION_WORLD_LIST  ",
            "CLIENT_GAME_SERVER_EXPEDITION_START  ",
            "CLIENT_GAME_TRANS_SERVER_AUTH  ",
            "CLIENT_GAME_TRANS_SERVER_SELECT_CHARACTER  ",
            "CLIENT_GAME_TRANS_SERVER_RETURN_AUTH  ",
            "CLIENT_GAME_TRANS_SERVER_RETURN_SELECT_CHARACTER  ",
            "CLIENT_WORLD_REQUEST_TRANS_SERVER_RETURN  ",
            "CLIENT_LOBBY_CONTENTS_LOCK_LIST  ",
            "CLIENT_CHATTING_GET_WHISPER_LIST  ",
            "CLIENT_GAME_ALLIANCE_GUILD_CHATTING  ",
            "CLIENT_GAME_ALLIANCE_GUILD_LIST  ",
            "CLIENT_GAME_TRANSLATION_LOG  ",
            "CLIENT_GAME_SMELTING_ITEM_MULTI  ",
            "CLIENT_GAME_DATA_SEQUENTIAL_PACKET  ",
            "CLIENT_GAME_DATA_LOGIN_PARALLEL_PACKET  ",
            "CLIENT_WORLD_PARTY_INVITE_CHATTING  ",
            "CLIENT_GAME_MAIL_DELETE_ALL  ",
            "CLIENT_GAME_MAIL_PACK_SEND  ",
            "CLIENT_GAME_ENDQUEST_GUILD_DAILY_ALL_MISSION  ",
            "CLIENT_GAME_SKILL_NON_TARGET_GUILD_LIST  ",
            "CLIENT_GAME_ACCOUNT_EX_INFO  ",
            "CLIENT_GAME_CAPTCHA_REVOKE  ",
            "CLIENT_GAME_CAPTCHA_REAUTH  ",
            "CLIENT_GAME_CHARACTER_ALIVE_CHECK  ",
            "CLIENT_GAME_SYNC_ROLL  ",
            "CLIENT_GAME_ERROR_STATE  ",
            "CLIENT_GAME_REQUEST_APPEAR_DATA  ",
            "CLIENT_GAME_CHARACTER_PHASE_CREATE  ",
            "CLIENT_GAME_CHARACTER_PHASE  ",
            "CLIENT_GAME_CHARACTER_PHASE_INFO  ",
            "CLIENT_GAME_DEATH_PENALTY_DEL  ",
            "CLIENT_GAME_CHARACTER_CUSTOM_TITLE_SHOW  ",
            "CLIENT_WORLD_REQ_SIEGE_MAIL_RANK_INFO  ",
            "CLIENT_WORLD_REQ_SIEGE_EVENT_INFO  ",
            "CLIENT_GAME_REQ_SIEGE_WATCHER_TRACE_USER  ",
            "CLIENT_GAME_SIEGE_EVE_EVENT_DATA  ",
            "CLIENT_GAME_SIEGE_EVE_EVENT_SELECT_CHEERING_TEAM  ",
            "CLIENT_WORLD_GET_DOMINION_TAX_INFO  ",
            "CLIENT_WORLD_REQ_DOMINION_STRONG_POINT_INFO  ",
            "CLIENT_WORLD_REQ_DOMINION_SIEGE_INFO  ",
            "CLIENT_WORLD_GET_DOMINION_INFO  ",
            "CLIENT_WORLD_DOMINION_TAX_RATE_CHANGE  ",
            "CLIENT_WORLD_DOMINION_TAX_WITHDRAWAL  ",
            "CLIENT_WORLD_DOMINION_IMPERIAL_ORDER  ",
            "CLIENT_WORLD_DOMINION_PRIZE  ",
            "CLIENT_WORLD_DOMINION_TITLE_LIST  ",
            "CLIENT_WORLD_DOMINION_GIVE_TITLE  ",
            "CLIENT_GAME_DOMINION_WANTED_LIST  ",
            "CLIENT_WORLD_DOMINION_WANTED_ADD  ",
            "CLIENT_WORLD_DOMINION_HISTORY_LIST  ",
            "CLIENT_GAME_DOMINION_STORAGE_INFO  ",
            "CLIENT_GAME_DOMINION_STORAGE_HISTORY  ",
            "CLIENT_GAME_DOMINION_STORAGE_COST_GIVE_TO_GUILD  ",
            "CLIENT_GAME_DOMINION_STORAGE_COST_TAKE_OUT  ",
            "CLIENT_GAME_DOMINION_STORAGE_COST_GIVE_TO_GUILD_INFO  ",
            "CLIENT_GAME_DOMINION_STORAGE_COST_GIVE_TO_USER  ",
            "CLIENT_WORLD_DOMINION_GIVE_OFFICIAL_GRADE  ",
            "CLIENT_WORLD_DOMINION_WANTED_CANCEL  ",
            "CLIENT_GAME_GACHA_INFO  ",
            "CLIENT_GAME_GACHA_PULL  ",
            "CLIENT_GAME_MAKE_ITEM_AGENCY_INFOS  ",
            "CLIENT_GAME_MAKE_ITEM_AGENCY  ",
            "CLIENT_GAME_MAKE_ITEM_XDRACO  ",
            "CLIENT_GAME_PET_UPGRADE  ",
            "CLIENT_GAME_CLOSED_TRAINING_INFO  ",
            "CLIENT_GAME_CLOSED_TRAINING_UPGRADE  ",
            "CLIENT_WORLD_REQ_STRONG_POINT_PROCLAMATION  ",
            "CLIENT_GAME_HARVEST_PRODUCTS_FROM_BUILDING  ",
            "CLIENT_GAME_GET_RANKING_REWARD  ",
            "CLIENT_WORLD_REQ_SANCTUM_INFO_LIST  ",
            "CLIENT_GAME_GET_CONTRACTADDRESS  ",
            "CLIENT_GAME_DRACO_EXCHANGE  ",
            "CLIENT_GAME_DRACO_BALANCEOF  ",
            "CLIENT_GAME_REGISTER_USER_ADDRESS  ",
            "CLIENT_LOBBY_GET_CONTRACTADDRESS  ",
            "CLIENT_LOBBY_REGISTER_USER_ADDRESS  ",
            "CLIENT_GAME_CHARACTER_MINT  ",
            "CLIENT_GAME_CHARACTER_SEAL  ",
            "CLIENT_LOBBY_CHARACTER_UNSEAL  ",
            "CLIENT_LOBBY_CHARACTER_LIST_ALL_GLOBAL  ",
            "CLIENT_GAME_GET_DARKSTEEL_DAILY_SUM  ",
            "CLIENT_LOBBY_TOKEN_CHARACTER_LIST  ",
            "CLIENT_GAME_GET_CHARACTER_SEAL_INFO  ",
            "CLIENT_GAME_DARKSTEEL_MINIMUMRESERVE  ",
            "CLIENT_GAME_HYDRA_EXCHANGE  ",
            "CLIENT_GAME_CHECK_DRACO_APPOVE  ",
            "CLIENT_GAME_DRACO_HYDRA_APPROVE  ",
            "CLIENT_GAME_GET_HYDRA_REFINE_FEE  ",
            "CLIENT_GAME_HYDRA_BALANCEOF  ",
            "CLIENT_GAME_CHECK_HYDRA_APPOVE  ",
            "CLIENT_GAME_HYDRA_APPROVE  ",
            "CLIENT_WORLD_REQ_DARK_ALTAR_INFO_LIST  ",
            "CLIENT_GAME_UI_SHOP_BUY_CASHITEM_START_HYDRA_MULTI  ",
            "CLIENT_GAME_UI_SHOP_BUY_CASHITEM_VERIFY_HYDRA_MULTI  ",
            "CLIENT_GAME_GET_CASHBAG_ITEM_MULTI  ",
            "CLIENT_GAME_PROUD_ITEM  ",
            "CLIENT_GAME_PROUD_ITEM_CANCEL  ",
            "CLIENT_GAME_PROUD_ITEM_INFO  ",
            "CLIENT_FRONT_WORLD_CHARACTER_INFO  ",
            "CLIENT_GAME_PROUD_ITEM_WONDER  ",
            "CLIENT_WORLD_REQ_PLUNDER_INFO  ",
            "CLIENT_GAME_REQ_PLUNDER_TRAP_BUY  ",
            "CLIENT_GAME_ENTER_PLUNDER_BATTLE_FIELD  ",
            "CLIENT_GAME_CONQUER_SERVER_INFO  ",
            "CLIENT_GAME_CONQUER_SERVER_START  ",
            "CLIENT_GAME_BLACKDRAGON_DUNGEON_INFO  ",
            "CLIENT_GAME_ENTER_BLACKDRAGON_DUNGEON  ",
            "CLIENT_GAME_LEAVE_BLACKDRAGON_DUNGEON  ",
            "CLIENT_GAME_HOLY_STUFF_OPEN  ",
            "CLIENT_GAME_UNEQUIP_ITEM  ",
            "CLIENT_GAME_DRAGONSTEEL_EXCHANGE_START  ",
            "CLIENT_GAME_DRAGONSTEEL_EXCHANGE_VERIFY  ",
            "CLIENT_GAME_EVENT_REPEAT  ",
            "CLIENT_WORLD_GUILD_COOP_MISSION_LIST  ",
            "CLIENT_WORLD_GUILD_COOP_MISSION_MEMBER_POPUP  ",
            "CLIENT_GAME_PAINTING_GUILD_TRADE_DATA_LIST  ",
            "CLIENT_GAME_PAINTING_GUILD_TRADE_REG  ",
            "CLIENT_GAME_PAINTING_GUILD_TRADE_CANCEL  ",
            "CLIENT_GAME_PAINTING_GUILD_TRADE_EXCHANGE  ",
            "CLIENT_GAME_PAINTING_GUILD_TRADE_EXCHANGE_COMPLETE  ",
            "CLIENT_GAME_AROUND_OTHER_CHARACTER_INFO  ",
            "CLIENT_GAME_PAINTING_EVENT_PROCESS  ",
            "CLIENT_GAME_CHARACTER_EVENT_PASS_MISSION_CLEAR  ",
            "CLIENT_GAME_CHARACTER_EVENT_PASS_REWARD  ",
            "CLIENT_GAME_CHARACTER_EVENT_PASS_TICKET  ",
            "CLIENT_GAME_CHARACTER_EVENT_PASS_BUY_TICKET_MONEY  ",
            "CLIENT_GAME_CHARACTER_EVENT_PASS_DATA  ",
            "CLIENT_GAME_CHARACTER_EVENT_PASS_MISSION_CLEAR_DATA  ",
            "CLIENT_GAME_CHARACTER_EVENT_PASS_REWARD_DATA  ",
            "CLIENT_WORLD_GET_DOMINION_INFO_BY_ID  ",
            "CLIENT_WORLD_GET_DOMINION_SABUK_TAXRATE_INFO  ",
            "CLIENT_WORLD_GET_DOMINION_SABUK_IMPERIAL_ORDER_INFO  ",
            "CLIENT_WORLD_GET_DOMINION_SABUK_GUILD_TITLE_INFO  ",
            "CLIENT_WORLD_DOMINION_SABUK_TAXRATE_CHANGE  ",
            "CLIENT_WORLD_DOMINION_SABUK_IMPERIAL_ORDER_CHANGE  ",
            "CLIENT_WORLD_DOMINION_SABUK_GUILD_TITLE_CHANGE  ",
            "CLIENT_WORLD_REQ_SABUK_DOMINION_CASTLE_INFO  ",
            "CLIENT_WORLD_REQ_SABUK_DOMINION_WAR_INFO  ",
            "CLIENT_WORLD_REQ_SABUK_RANKING_BOARD_INFO  ",
            "CLIENT_WORLD_REQ_SABUK_RR_POPUP  ",
            "CLIENT_GAME_REQ_SABUK_RANK_INFO  ",
            "CLIENT_GAME_REQ_SABUK_BOARD_INFO  ",
            "CLIENT_GAME_REQ_SABUK_WATCHER_TRACE_USER  ",
            "CLIENT_GAME_ENTER_SABUK_BATTLE_FIELD  ",
            "CLIENT_WORLD_REQ_SABUK_SELECTED_GUILD_INFO  ",
            "CLIENT_GAME_DOMINION_MAIL_SEND  ",
            "CLIENT_GAME_ITEM_SPECIAL_EXCHANGE  ",
            "CLIENT_GAME_UNSEALING_ACCELERATE_POINT_ALL  ",
            "CLIENT_GAME_UI_SHOP_BUY_CASHITEM_START_WEMIX_DOLLAR  ",
            "CLIENT_GAME_UI_SHOP_BUY_CASHITEM_VERIFY_WEMIX_DOLLAR  ",
            "CLIENT_GAME_UI_SHOP_BUY_CASHITEM_START_WEMIX_DOLLAR_MULTI  ",
            "CLIENT_GAME_UI_SHOP_BUY_CASHITEM_VERIFY_WEMIX_DOLLAR_MULTI  ",
            "CLIENT_GAME_WEMIXDOLLAR_BALANCEOF  ",
            "CLIENT_GAME_WEMIXDOLLAR_APPROVE  ",
            "CLIENT_GAME_CHECK_WEMIXDOLLAR_APPROVE  ",
            "CLIENT_GAME_MAKE_ITEM_XDRACO_LIMIT_PACKAGE_INFOS  ",
            "CLIENT_GAME_MAKE_ITEM_XDRACO_LIMIT_PACKAGE  ",
            "CLIENT_GAME_REFINE_ITEM  ",
            "CLIENT_GAME_SEND_GIFT_GUILD_FRIENDSHIP_LIST  ",
            "CLIENT_WORLD_SEND_GIFT_GUILD_MEMBER_LIST  ",
            "CLIENT_GAME_SEND_GIFT_CASHBAG  ",
            "CLIENT_GAME_CHARACTER_BATTLE_PASS_BUY_TICKET_ITEM  ",
            "CLIENT_GAME_CHARACTER_POTENTIAL_DATA  ",
            "CLIENT_GAME_POTENTIAL_UPGRADE  ",
            "CLIENT_GAME_SEND_GIFT_CASHBAG_HISTORY_LIST  ",
            "CLIENT_GAME_RECEIVE_GIFT_CASHBAG_HISTORY_LIST  ",
            "CLIENT_GAME_RANKING_FOR_MY_INFO  "});
            this.comboBox_EncoderOpcode.Location = new System.Drawing.Point(9, 18);
            this.comboBox_EncoderOpcode.Name = "comboBox_EncoderOpcode";
            this.comboBox_EncoderOpcode.Size = new System.Drawing.Size(186, 21);
            this.comboBox_EncoderOpcode.TabIndex = 0;
            this.comboBox_EncoderOpcode.Text = "Opcode";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comboBox_LoginMethod);
            this.groupBox1.Controls.Add(this.textBox_TokenID);
            this.groupBox1.Controls.Add(this.textBox_DeviceKey);
            this.groupBox1.Controls.Add(this.buttonDisconnect);
            this.groupBox1.Controls.Add(this.comboBox_World);
            this.groupBox1.Controls.Add(this.textBox_CharacterName);
            this.groupBox1.Controls.Add(this.btnConnect);
            this.groupBox1.Location = new System.Drawing.Point(604, 49);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(111, 209);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Account";
            // 
            // comboBox_LoginMethod
            // 
            this.comboBox_LoginMethod.FormattingEnabled = true;
            this.comboBox_LoginMethod.Items.AddRange(new object[] {
            "google",
            "Facebook",
            "Apple"});
            this.comboBox_LoginMethod.Location = new System.Drawing.Point(8, 71);
            this.comboBox_LoginMethod.Name = "comboBox_LoginMethod";
            this.comboBox_LoginMethod.Size = new System.Drawing.Size(100, 21);
            this.comboBox_LoginMethod.TabIndex = 10;
            this.comboBox_LoginMethod.Text = "steam";
            // 
            // textBox_TokenID
            // 
            this.textBox_TokenID.Location = new System.Drawing.Point(8, 45);
            this.textBox_TokenID.Name = "textBox_TokenID";
            this.textBox_TokenID.Size = new System.Drawing.Size(99, 20);
            this.textBox_TokenID.TabIndex = 9;
            this.textBox_TokenID.Text = "TokenID";
            // 
            // textBox_DeviceKey
            // 
            this.textBox_DeviceKey.Location = new System.Drawing.Point(8, 19);
            this.textBox_DeviceKey.Name = "textBox_DeviceKey";
            this.textBox_DeviceKey.Size = new System.Drawing.Size(99, 20);
            this.textBox_DeviceKey.TabIndex = 8;
            this.textBox_DeviceKey.Text = "DeviceID";
            // 
            // buttonDisconnect
            // 
            this.buttonDisconnect.Location = new System.Drawing.Point(6, 177);
            this.buttonDisconnect.Name = "buttonDisconnect";
            this.buttonDisconnect.Size = new System.Drawing.Size(98, 22);
            this.buttonDisconnect.TabIndex = 7;
            this.buttonDisconnect.Text = "Disconnect";
            this.buttonDisconnect.UseVisualStyleBackColor = true;
            this.buttonDisconnect.Click += new System.EventHandler(this.buttonDisconnect_Click);
            // 
            // comboBox_World
            // 
            this.comboBox_World.FormattingEnabled = true;
            this.comboBox_World.Items.AddRange(new object[] {
            "NA14",
            "NA51",
            "NA52"});
            this.comboBox_World.Location = new System.Drawing.Point(8, 124);
            this.comboBox_World.Name = "comboBox_World";
            this.comboBox_World.Size = new System.Drawing.Size(99, 21);
            this.comboBox_World.TabIndex = 6;
            this.comboBox_World.Text = "NA14";
            // 
            // textBox_CharacterName
            // 
            this.textBox_CharacterName.Location = new System.Drawing.Point(8, 98);
            this.textBox_CharacterName.Name = "textBox_CharacterName";
            this.textBox_CharacterName.Size = new System.Drawing.Size(99, 20);
            this.textBox_CharacterName.TabIndex = 3;
            this.textBox_CharacterName.Text = "CharName";
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(7, 151);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(98, 20);
            this.btnConnect.TabIndex = 0;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // textBox_SendPacket
            // 
            this.textBox_SendPacket.Location = new System.Drawing.Point(12, 421);
            this.textBox_SendPacket.Name = "textBox_SendPacket";
            this.textBox_SendPacket.Size = new System.Drawing.Size(586, 20);
            this.textBox_SendPacket.TabIndex = 9;
            this.textBox_SendPacket.Visible = false;
            // 
            // button_SendPacket
            // 
            this.button_SendPacket.Location = new System.Drawing.Point(612, 420);
            this.button_SendPacket.Name = "button_SendPacket";
            this.button_SendPacket.Size = new System.Drawing.Size(101, 23);
            this.button_SendPacket.TabIndex = 8;
            this.button_SendPacket.Text = "Send";
            this.button_SendPacket.UseVisualStyleBackColor = true;
            this.button_SendPacket.Visible = false;
            this.button_SendPacket.Click += new System.EventHandler(this.button_SendPacket_Click);
            // 
            // checkBox_Reconnect
            // 
            this.checkBox_Reconnect.AutoSize = true;
            this.checkBox_Reconnect.Location = new System.Drawing.Point(608, 265);
            this.checkBox_Reconnect.Name = "checkBox_Reconnect";
            this.checkBox_Reconnect.Size = new System.Drawing.Size(104, 17);
            this.checkBox_Reconnect.TabIndex = 11;
            this.checkBox_Reconnect.Text = "Auto-Reconnect";
            this.checkBox_Reconnect.UseVisualStyleBackColor = true;
            this.checkBox_Reconnect.CheckedChanged += new System.EventHandler(this.checkBox_Reconnect_CheckedChanged);
            // 
            // checkBox_LogPackets
            // 
            this.checkBox_LogPackets.AutoSize = true;
            this.checkBox_LogPackets.Location = new System.Drawing.Point(604, 325);
            this.checkBox_LogPackets.Name = "checkBox_LogPackets";
            this.checkBox_LogPackets.Size = new System.Drawing.Size(86, 17);
            this.checkBox_LogPackets.TabIndex = 12;
            this.checkBox_LogPackets.Text = "Log Packets";
            this.checkBox_LogPackets.UseVisualStyleBackColor = true;
            this.checkBox_LogPackets.CheckedChanged += new System.EventHandler(this.checkBox_LogPackets_CheckedChanged);
            // 
            // checkBox_UseConsole
            // 
            this.checkBox_UseConsole.AutoSize = true;
            this.checkBox_UseConsole.Checked = true;
            this.checkBox_UseConsole.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox_UseConsole.Location = new System.Drawing.Point(604, 302);
            this.checkBox_UseConsole.Name = "checkBox_UseConsole";
            this.checkBox_UseConsole.Size = new System.Drawing.Size(86, 17);
            this.checkBox_UseConsole.TabIndex = 13;
            this.checkBox_UseConsole.Text = "Use Console";
            this.checkBox_UseConsole.UseVisualStyleBackColor = true;
            this.checkBox_UseConsole.CheckedChanged += new System.EventHandler(this.checkBox_UseConsole_CheckedChanged);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(611, 391);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(102, 23);
            this.button2.TabIndex = 12;
            this.button2.Text = "Spam";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Visible = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(721, 449);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.checkBox_UseConsole);
            this.Controls.Add(this.checkBox_LogPackets);
            this.Controls.Add(this.checkBox_Reconnect);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button_SendPacket);
            this.Controls.Add(this.textBox_SendPacket);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.menuStrip1);
            this.Name = "MainForm";
            this.Text = "Mir4 Global Client Emulator (By AlSch092)";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage_EventLog.ResumeLayout(false);
            this.tabPage_EventLog.PerformLayout();
            this.tabPage_RawView.ResumeLayout(false);
            this.contextMenuStrip_RawView.ResumeLayout(false);
            this.tabPage_Info.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_GatherPriority)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_CollectEnt)).EndInit();
            this.groupBox_CharInfo.ResumeLayout(false);
            this.groupBox_CharInfo.PerformLayout();
            this.groupBox_Movement.ResumeLayout(false);
            this.groupBox_Movement.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Z)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Y)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_X)).EndInit();
            this.tabPage_Bots.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox_Quests.ResumeLayout(false);
            this.groupBox_Quests.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_MaxRadius)).EndInit();
            this.tabPage_Encoder.ResumeLayout(false);
            this.tabPage_Encoder.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_SpamDelay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_FieldNumber)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem creditsToolStripMenuItem;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage_EventLog;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonDisconnect;
        private System.Windows.Forms.ComboBox comboBox_World;
        private System.Windows.Forms.TextBox textBox_CharacterName;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.TextBox textBox_LogArea;
        private System.Windows.Forms.TabPage tabPage_RawView;
        private System.Windows.Forms.ListView listView_RawView;
        private System.Windows.Forms.ColumnHeader columnHeader_Direction;
        private System.Windows.Forms.ColumnHeader columnHeader_Length;
        private System.Windows.Forms.ColumnHeader columnHeader_Opcode;
        private System.Windows.Forms.ColumnHeader columnHeader_Data;
        private System.Windows.Forms.TabPage tabPage_Info;
        private System.Windows.Forms.TextBox textBox_SendPacket;
        private System.Windows.Forms.Button button_SendPacket;
        private System.Windows.Forms.ComboBox comboBox_LoginMethod;
        private System.Windows.Forms.TextBox textBox_TokenID;
        private System.Windows.Forms.TextBox textBox_DeviceKey;
        private System.Windows.Forms.CheckBox checkBox_Gather;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip_RawView;
        private System.Windows.Forms.ToolStripMenuItem copySelectedToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clearToolStripMenuItem;
        private System.Windows.Forms.Button button_Teleport;
        private System.Windows.Forms.NumericUpDown numericUpDown_X;
        private System.Windows.Forms.NumericUpDown numericUpDown_Y;
        private System.Windows.Forms.NumericUpDown numericUpDown_Z;
        private System.Windows.Forms.Label label_Z;
        private System.Windows.Forms.Label label_Y;
        private System.Windows.Forms.Label label_X;
        private System.Windows.Forms.GroupBox groupBox_Movement;
        private System.Windows.Forms.CheckBox checkBox_Reconnect;
        private System.Windows.Forms.Button button_PrintEntityList;
        private System.Windows.Forms.GroupBox groupBox_CharInfo;
        private System.Windows.Forms.Label label_DarkSteel;
        private System.Windows.Forms.Label label_CharLvl;
        private System.Windows.Forms.Label label_CharName;
        private System.Windows.Forms.Label label_CharZ;
        private System.Windows.Forms.Label label_CharY;
        private System.Windows.Forms.Label label_CharX;
        private System.Windows.Forms.TabPage tabPage_Encoder;
        private System.Windows.Forms.ListBox listBox_EncoderArgs;
        private System.Windows.Forms.Button button_SendProtobuf;
        private System.Windows.Forms.Button button_AddEncoderField;
        private System.Windows.Forms.ComboBox comboBox_EncoderType;
        private System.Windows.Forms.ComboBox comboBox_EncoderOpcode;
        private System.Windows.Forms.TextBox textBox_EncoderValue;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button button_CollectEnt;
        private System.Windows.Forms.NumericUpDown numericUpDown_CollectEnt;
        private System.Windows.Forms.Button button_WarpPortal;
        private System.Windows.Forms.Label label_GatherCounter;
        private System.Windows.Forms.CheckBox checkBox_LogPackets;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numericUpDown_GatherPriority;
        private System.Windows.Forms.Label label_UID;
        private System.Windows.Forms.Button button_EntityMap;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button button_PrintItems;
        private System.Windows.Forms.Button button_ClearProtobuf;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numericUpDown_FieldNumber;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button button_PrintNearbyPlayers;
        private System.Windows.Forms.Label label_PlayerEnergy;
        private System.Windows.Forms.Label label_PlayerStage;
        private System.Windows.Forms.Label label_SpamPacket;
        private System.Windows.Forms.NumericUpDown numericUpDown_SpamDelay;
        private System.Windows.Forms.CheckBox checkBox_SpamMessage;
        private System.Windows.Forms.ComboBox comboBox_Warp;
        private System.Windows.Forms.TabPage tabPage_Bots;
        private System.Windows.Forms.GroupBox groupBox_Quests;
        private System.Windows.Forms.Button button_PrintQuestList;
        private System.Windows.Forms.CheckBox checkBox_AutoQuest;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label_Radius;
        private System.Windows.Forms.NumericUpDown numericUpDown_MaxRadius;
        private System.Windows.Forms.CheckBox checkBox_KillMonsters;
        private System.Windows.Forms.CheckBox checkBox_QuestFromStart;
        private System.Windows.Forms.CheckBox checkBox_UseConsole;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox comboBox_GatherMap;
        private System.Windows.Forms.ComboBox comboBox_GatheringType;
        private System.Windows.Forms.Button button_NewDayRoutine;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Button button_Portal;
        private System.Windows.Forms.ComboBox comboBox_Portal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem saveProfileAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem readmeToolStripMenuItem;
        private System.Windows.Forms.CheckBox checkBox_AcceptParties;
        private System.Windows.Forms.Button button_LeaveParty;
        private System.Windows.Forms.ToolStripMenuItem languagesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eNToolStripMenuItem;
    }
}

