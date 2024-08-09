//By AlSch092 @ Github
﻿using Microsoft.Win32.SafeHandles;
using Mir4.Game;
using Mir4.Scripter;
using Mir4.Utilities;
using Mir4ClientEmulator.Game;
using Mir4ClientEmulator.Network;
using Mir4ClientEmulator.Network.Packets;
using Mir4ClientEmulator.Network.Packets.Messages;
using Mir4ClientEmulator.Scripter;
using Mir4ClientEmulator.Utilities;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace Mir4ClientEmulator
{
    public partial class MainForm : Form
    {
        public Client MirClient { get; set; }

        public Thread PacketLogWorker { get; private set; }
        public Thread InfoUpdateWorker { get; set; }
        public Thread UIMessageWorker { get; set; }

        public Thread WhisperThread { get; set; }

        public Thread PacketSpamThread { get; set; }

        public EntityMap EntityMapForm { get; set; }

        private Profile LaunchProfile { get; set; }

        public MainForm()
        {
            InitializeComponent();
        }

        private void ProcessUIMessages() //queue processing to post msgs to main listview
        {
            bool loggingMessages = true;

            while(loggingMessages)
            {
                try
                {
                    if (MirClient.UIMessages == null)
                        continue;

                    if (MirClient.UIMessages.Count > 0)
                    {
                        string msg = MirClient.UIMessages.Dequeue();
                        
                        if (msg != null)
                        {
                            if (!ControlInvokeRequired(this.textBox_LogArea, () => LogAppend(msg + "\r\n")))
                            {
                                textBox_LogArea.AppendText(msg + "\r\n");
                            }
                        }
                    }
                }
                catch(Exception e)
                {
                    Console.WriteLine("Failed to dequeue UI message: " + e.Message);
                }

                Thread.Sleep(500);
            }
        }

        private void ProcessPacketQueues()
        {
            bool recving = true;

            Console.WriteLine("Started processing packets (GUI)...");

            while (recving)
            {
                try
                {
                    if (MirClient.RecvPacketQueue == null)
                        continue;

                    if (MirClient.RecvPacketQueue.Count > 0)
                    {
                        Reader packet = MirClient.RecvPacketQueue.Dequeue();

                        //packet.Position = 0;

                        if (packet == null)
                        {
                            // Dispose();
                            continue;
                        }

                        string s_length = Convert.ToString(packet.Length);

                        if (listView_RawView.InvokeRequired)
                        {
                            listView_RawView.Invoke((MethodInvoker)delegate ()
                            {
                                if (packet.Length >= 2)
                                {
                                    packet.m_index = 0;
                                    byte[] bytes = packet.ReadBytes(packet.Length);

                                    if (bytes != null)
                                    {
                                        string hexString = BitConverter.ToString(bytes);
                                        string hexOpcode = BitConverter.ToString(bytes, 0, 2);
                                        hexString = hexString.Replace("-", " ");
                                        hexOpcode = hexOpcode.Replace("-", " ");

                                        string[] row = { "In", s_length, hexOpcode, hexString };
                                        var listViewItem = new ListViewItem(row);
                                        listView_RawView.Items.Add(listViewItem);
                                    }

                                }
                                else
                                {
                                    byte[] bytes = packet.ReadBytes(packet.Length);

                                    if (bytes != null)
                                    {
                                        string hexOpcode = BitConverter.ToString(bytes);
                                        hexOpcode = hexOpcode.Replace("-", " ");

                                        string[] row = { "In", s_length, hexOpcode, " " };
                                        var listViewItem = new ListViewItem(row);
                                        listView_RawView.Items.Add(listViewItem);
                                    }
                                }
                            });

                        }
                    }

                    if(MirClient.SendPacketQueue == null)
                    {
                        return;
                    }

                    if (MirClient.SendPacketQueue.Count > 0)
                    {
                        Reader packet = MirClient.SendPacketQueue.Dequeue();

                        if (packet == null)
                        {
                            // Dispose();
                            continue;
                        }

                        if (listView_RawView.InvokeRequired)
                        {
                            listView_RawView.Invoke((MethodInvoker)delegate ()
                            {
                                if (packet.Length >= 2)
                                {
                                    if (packet.m_index == packet.Length)
                                        packet.m_index = 0;

                                    byte[] bytes = packet.ReadBytes(packet.Length);

                                    if (bytes != null)
                                    {
                                        string hexString = BitConverter.ToString(bytes);
                                        string hexOpcode = BitConverter.ToString(bytes, 0, 2);
                                        hexString = hexString.Replace("-", " ");
                                        hexOpcode = hexOpcode.Replace("-", " ");

                                        string[] row = { "Out", Convert.ToString(packet.Length), hexOpcode, hexString };
                                        var listViewItem = new ListViewItem(row);
                                        listView_RawView.Items.Add(listViewItem);
                                    }
                                }
                                else
                                {
                                    byte[] bytes = packet.ReadBytes(packet.Length);

                                    if (bytes != null)
                                    {

                                        string hexOpcode = BitConverter.ToString(bytes);
                                        hexOpcode = hexOpcode.Replace("-", " ");

                                        string[] row = { "In", Convert.ToString(packet.Length), hexOpcode, " " };
                                        var listViewItem = new ListViewItem(row);
                                        listView_RawView.Items.Add(listViewItem);
                                    }
                                }
                            });
                        }
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine("Failed to de-queue packet: " + e.Message);
                    continue;
                }

                Thread.Sleep(50);
            }
        }

        private string[] LookupWorldServer(string worldName)
        {
            string[] serverAndPort = null;

            if (worldName.Contains("NA0")) //todo: needs hash table lookup, or put in its own function
            {
                serverAndPort = MirClient.WebLogin.servers.NA1.Split(':');
            }
            else if (worldName.Contains("ASIA0"))
            {
                serverAndPort = MirClient.WebLogin.servers.ASIA1.Split(':');
            }
            else if (worldName.Contains("EU0"))
            {
                serverAndPort = MirClient.WebLogin.servers.EU1.Split(':');
            }
            else if (worldName.Contains("INMENA0"))
            {
                serverAndPort = MirClient.WebLogin.servers.INMENA1.Split(':');
            }
            else if (worldName.Contains("SA0"))
            {
                serverAndPort = MirClient.WebLogin.servers.SA1.Split(':');
            }

            return serverAndPort;
        }


        private void Connect()
        {
            if (MirClient == null)
                MirClient = new Client();

            MirClient.GameAccount.LoginToken = this.textBox_TokenID.Text;

            MirClient.GameAccount.PlayerKey = MirClient.WebLogin.GetPlayerKey(this.textBox_DeviceKey.Text, this.comboBox_LoginMethod.Text, this.textBox_TokenID.Text);

            MirClient.Bot.AutoGathering = checkBox_Gather.Checked;

            MirClient.Bot.AutoAttacking = checkBox_KillMonsters.Checked;

            MirClient.GameAccount.CharacterName = textBox_CharacterName.Text;

            MirClient.GameAccount.strWorld = comboBox_World.Text;

            string[] serverAndPort = LookupWorldServer(MirClient.GameAccount.strWorld);

            if (MirClient.GameAccount.PlayerKey != null && serverAndPort != null)
            { 
                //connect to mir4 front server and send login packet
                if (MirClient.WebLogin.loginInfo.isHumanVerified)
                {

                    string server = null;
                    int port = 0;

                    if (serverAndPort != null)
                    {
                        server = serverAndPort[0];

                        try
                        {
                            port = Convert.ToInt32(serverAndPort[1]);
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine("Failed parsing port in FrontServerURL: " + ex.Message);
                            return;
                        }
                    }

                    if (server != null)
                    {
                        MirClient.ConnectedIp = server;
                        MirClient.Port = port;

                        Console.WriteLine("Connecting to: " + server + " (port: " + port + ")");

                        if (!ControlInvokeRequired(this.textBox_LogArea, () => LogAppend("Connecting to: " + MirClient.ConnectedIp + "\r\n")))
                        {
                            textBox_LogArea.AppendText("Connecting to: " + MirClient.ConnectedIp + "\r\n");
                        }

                        if (InfoUpdateWorker == null)
                        {
                            InfoUpdateWorker = new Thread(new ThreadStart(UpdateInformation));
                            InfoUpdateWorker.Start();
                        }

                        if (UIMessageWorker == null)
                        {
                            UIMessageWorker = new Thread(new ThreadStart(ProcessUIMessages));
                            UIMessageWorker.Start();
                        }

                        MirClient.Migrate(server, port, true);
                    }
                }
                else
                {
                    Console.WriteLine("[ERROR] Account needs human verification! Please verify manually and then retry.");
                    MirClient.GameAccount.NeedsHumanVerification = true;
                    
                    //if(HumanVerify.VerifyAccount(MirClient.GameAccount.LoginToken))
                    //{
                    //    //try login again after verifying
                    //    Connect();
                    //}
                }
            }
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            try
            {
                Connect();
            }
            catch
            {
                Console.WriteLine("[ERROR] Failed to connect! Please make sure programs like Fiddler are not logging traffic before retrying.");
            }
        }

        private void LogAppend(string text) //for cross-thread methods
        {
            textBox_LogArea.AppendText(text);
        }

        public bool ControlInvokeRequired(Control c, Action a) //for cross-thread methods
        {
            try
            {
                if (c.InvokeRequired)
                    c.Invoke(new MethodInvoker(delegate { a(); }));
                else
                    return false;
            }
            catch(NullReferenceException e)
            {
                Console.WriteLine("[ERROR] at ControlInvokeRequired: NullReference");
                return false;
            }

            return true;
        }

        private void button_SendPacket_Click(object sender, EventArgs e)
        {
            string sendPacketText = textBox_SendPacket.Text.Trim();

            byte[] packetBytes = HexText.ToBytes(sendPacketText);

            var p = new Writer();
            p.WriteBytes(packetBytes);

            MirClient.m_session.SendPacket(p);
        }

        private void buttonDisconnect_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Disconnected from server (by choice)");
            
            if(MirClient != null)
                if(MirClient.m_session != null)
                    if(MirClient.m_session.Connected)
                        MirClient.m_session.Disconnect();
        }

        private void SetupGathering()
        {
            string target_map = comboBox_GatherMap.Text;

            MirClient.Bot.AutoGathering = checkBox_Gather.Checked;

            string gathering_type = comboBox_GatheringType.Text;

            switch (gathering_type)
            {
                case "Mining":
                    MirClient.Bot.GatheringType = 0;
                    break;

                case "Herbs":
                    MirClient.Bot.GatheringType = 1;
                    break;

                case "Energy":
                    MirClient.Bot.GatheringType = 2;
                    break;

                default:
                    MirClient.Bot.GatheringType = 2;
                    break;
            };

            string desired_map = comboBox_GatherMap.Text;

            uint stage_map = (uint)MirClient.Bot.GetStageIdFromName(desired_map);

            //MirClient.Bot.TargetStageID

            if (stage_map != MirClient.GameAccount.StageID)
            {
                //teleport to stage
                MirClient.Bot.TeleportToMap(desired_map);
            }
        }

        private void checkBox_Gather_CheckedChanged(object sender, EventArgs e)
        {
            if (MirClient == null)
            {
                Console.WriteLine("[ERROR] Please log in first!");
                return;
            }

            if (MirClient.Bot == null)
            {
                Console.WriteLine("[ERROR] Please log in first!");
                return;
            }
        
            if (checkBox_Gather.Checked)
            {
                MirClient.Bot.MinimumGatheringPriority = (int)numericUpDown_GatherPriority.Value;

                if (MirClient.Bot.worker == null)
                {
                    SetupGathering();
                    MirClient.Bot.worker = new Thread(new ThreadStart(MirClient.Bot.Gather));
                    MirClient.Bot.worker.Start();
                }
            }
            else
            {
                MirClient.Bot.worker.Abort();
                MirClient.Bot.worker = null;
            }
        }

        private void copySelectedToolStripMenuItem_Click(object sender, EventArgs e)
        {
            String text = "";
            foreach (ListViewItem item in listView_RawView.Items)
            {
                if(item.Selected)
                    text = item.SubItems[3].Text;
            }
            Clipboard.SetText(text);
        }

        private void button_Teleport_Click(object sender, EventArgs e)
        {
            float x = Convert.ToSingle(numericUpDown_X.Value);
            float y = Convert.ToSingle(numericUpDown_Y.Value);
            float z = Convert.ToSingle(numericUpDown_Z.Value);

            _vector3 dest_v = new _vector3();
            dest_v.x = x;
            dest_v.y = y;
            dest_v.z = z;

            MirClient.Bot.Teleport(MirClient.Bot.Position, dest_v);
        }

        private void checkBox_Reconnect_CheckedChanged(object sender, EventArgs e)
        {
            if(MirClient != null)
                MirClient.AutoReconnect = checkBox_Reconnect.Checked;
        }

        private void button_PrintEntityList_Click(object sender, EventArgs e)
        {
            if(MirClient != null)
                if(MirClient.Bot != null)
                    if(MirClient.Bot.EntityList.Count > 0)
                    {
                        foreach(Entity ent in MirClient.Bot.EntityList)
                        {
                            Console.WriteLine("Entity: {0} Type: {1} Class: {2} at ({3},{4},{5}) Usages: {6}, Max Uses: {7}, HP: {8}, State: {9}, Honeypot: {10}", ent.id, ent.type, ent.classid, ent.Position.x, ent.Position.y, ent.Position.z, ent.UsageCountsLeft, ent.UsageCountsMax, ent.hp, ent.state, Entity.IsHoneypot(ent));
                        }
                    }
        }

        private void WriteTextLabel(System.Windows.Forms.Label label, string str)
        {
            label.Text = str;
        }

        private void UpdateInformation()
        {
            bool displaying = true;

            while(displaying)
            {
                if(MirClient != null)
                {
                    if(MirClient.GameAccount != null && MirClient.Bot.Position != null)
                    {
                        if (!ControlInvokeRequired(this.label_CharX, () => WriteTextLabel(this.label_CharX, "X: " + Convert.ToString(MirClient.Bot.Position.x))))
                        {
                            label_CharX.Text = "X: " + Convert.ToString(MirClient.Bot.Position.x);
                        }

                        if (!ControlInvokeRequired(this.label_CharY, () => WriteTextLabel(this.label_CharY, "Y: " + Convert.ToString(MirClient.Bot.Position.y))))
                        {
                            label_CharY.Text = "Y: " + Convert.ToString(MirClient.Bot.Position.y);
                        }

                        if (!ControlInvokeRequired(this.label_CharZ, () => WriteTextLabel(this.label_CharZ, "Z: " + Convert.ToString(MirClient.Bot.Position.z))))
                        {
                            label_CharZ.Text = "Z: " + Convert.ToString(MirClient.Bot.Position.z);
                        }

                        if (!ControlInvokeRequired(this.label_CharLvl, () => WriteTextLabel(this.label_CharLvl, "Level: " + Convert.ToString(MirClient.GameAccount.Level))))
                        {
                            label_CharLvl.Text = "Level: " + Convert.ToString(MirClient.GameAccount.Level);
                        }

                        if (!ControlInvokeRequired(this.label_GatherCounter, () => WriteTextLabel(this.label_GatherCounter, "Gathering Count: " + Convert.ToString(MirClient.Bot.ObjectsGathered))))
                        {
                            label_GatherCounter.Text = "Gathered: " + Convert.ToString(MirClient.Bot.ObjectsGathered);
                        }

                        if (!ControlInvokeRequired(this.label_CharName, () => WriteTextLabel(this.label_CharName, "Name: " + Convert.ToString(MirClient.GameAccount.CharacterName))))
                        {
                            label_CharName.Text = "Name: " + Convert.ToString(MirClient.GameAccount.CharacterName);
                        }

                        if (!ControlInvokeRequired(this.label_UID, () => WriteTextLabel(this.label_UID, "UID: " + Convert.ToString(MirClient.GameAccount.character_identifier))))
                        {
                            label_UID.Text = "UID: " + Convert.ToString(MirClient.GameAccount.character_identifier);
                        }

                        if (!ControlInvokeRequired(this.label_PlayerEnergy, () => WriteTextLabel(this.label_PlayerEnergy, "Energy: " + Convert.ToString(MirClient.GameAccount.Energy))))
                        {
                            label_PlayerEnergy.Text = "Energy: " + Convert.ToString(MirClient.GameAccount.Energy);
                        }

                        if (!ControlInvokeRequired(this.label_PlayerStage, () => WriteTextLabel(this.label_PlayerStage, "Stage: " + MirClient.Bot.GetStageNameFromId((int)MirClient.GameAccount.StageID))))
                        {

                        }

                    }
                }

                Thread.Sleep(2000);
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            MirClient = new Client();
            MirClient.Bot = new Automation(MirClient);
            LaunchProfile = new Profile();

            if (MirClient.Bot.MapNames.Count > 0)
            {
                foreach (NamedStage map in MirClient.Bot.MapNames)
                {
                    this.comboBox_Warp.Items.Add(map.StageNameSID);
                    this.comboBox_GatherMap.Items.Add(map.StageNameSID);
                }
            }

            if (LaunchProfile.ProcessCommandLine()) //auto-startup
            {
                this.textBox_CharacterName.Text = LaunchProfile.character_name;
                this.textBox_DeviceKey.Text = LaunchProfile.device_id;
                this.textBox_TokenID.Text = LaunchProfile.login_token;
                this.comboBox_LoginMethod.Text = LaunchProfile.login_method;
                this.comboBox_World.Text = LaunchProfile.character_world;

                bool gatherOnLogin = false;

                if(LaunchProfile.desired_action.Contains("Gather") || LaunchProfile.desired_action.Contains("Mining"))
                {
                    if(LaunchProfile.desired_action.Contains("Energy"))
                    {
                        comboBox_GatheringType.Text = "Energy";
                    }
                    else if (LaunchProfile.desired_action.Contains("Herbs"))
                    {
                        comboBox_GatheringType.Text = "Herbs";
                    }
                    else if (LaunchProfile.desired_action.Contains("Mining"))
                    {
                        comboBox_GatheringType.Text = "Mining";
                    }
                    gatherOnLogin = true;
                }

                if (LaunchProfile.reconnecting)
                {
                    checkBox_Reconnect.Checked = true;
                    MirClient.AutoReconnect = checkBox_Reconnect.Checked;
                }
               
                try
                {
                    Connect();
                }
                catch
                {
                    Console.WriteLine("[ERROR] Failed to connect!");
                    return;
                }

                if(gatherOnLogin)
                {
                    SetupGathering();

                    MirClient.Bot.worker = new Thread(new ThreadStart(MirClient.Bot.Gather));
                    MirClient.Bot.worker.Start();
                }
            }
        }

        private void checkBox_KillMonsters_CheckedChanged(object sender, EventArgs e) //ENABLE KILL MONSTERS
        {
            if(checkBox_KillMonsters.Checked)
            {
                if (MirClient != null)
                    if(MirClient.Bot != null)
                        MirClient.Bot.AutoAttacking = true;
              
                MirClient.Bot.MaxRadius = (float)numericUpDown_MaxRadius.Value;
                MirClient.Bot.attack_worker = new Thread(new ThreadStart(MirClient.Bot.AttackMonstersWithinRange));
                MirClient.Bot.attack_worker.Start();
            }
            else
            {
                if (MirClient != null)
                    if(MirClient.Bot != null)
                        MirClient.Bot.AutoAttacking = false;
                 
                if(MirClient.Bot.attack_worker != null)
                    MirClient.Bot.attack_worker.Abort();
            }
        }

        private void button_CollectEnt_Click(object sender, EventArgs e) //COLLECT ENTITY
        {
            ulong id = Convert.ToUInt64(numericUpDown_CollectEnt.Value);

            if(MirClient != null)
            {
                try
                {
                    foreach (Entity ent in MirClient.Bot.EntityList)
                    {
                        if (id == ent.id)
                        {
                            if (ent.UsageCountsLeft == 0)
                            {
                                Console.WriteLine("Couldn't collect entity {0}, no uses left.", ent.id);
                                return;
                            }

                            if(Entity.IsHoneypot(ent))
                            {
                                Console.WriteLine("Couldn't collect entity {0}, fake object detected.", ent.id);
                                return;
                            }
                            else
                            {
                                MirClient.Bot.Teleport(MirClient.Bot.Position, ent.Position);

                                //attempt collect object
                                MirClient.m_session.SendPacket(Factory.CLIENT_GAME_START_CASTING(MirClient.GameAccount.character_identifier, ent.id, 1, 0, false));
                                Console.WriteLine("Attempted collection of entity {0}, {1} uses left.", ent.id, ent.UsageCountsLeft);
                            }                         
                        }
                    }
                }
                catch(Exception ex)
                {
                    Console.WriteLine("[ERROR] Some network or object error occured when collecting entity: {0}", ex.Message);                  
                }             
            }
        }

        private void checkBox_LogPackets_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox_LogPackets.Checked)
            {
                //create recv GUI threads
                if (MirClient.SendPacketQueue == null)
                {
                    MirClient.SendPacketQueue = new Queue<Reader>();
                }
                if (MirClient.RecvPacketQueue == null)
                {
                    MirClient.RecvPacketQueue = new Queue<Reader>();
                }

                if (PacketLogWorker == null)
                {
                    PacketLogWorker = new Thread(new ThreadStart(ProcessPacketQueues));
                    PacketLogWorker.Start();
                }
                else
                {
                    if (PacketLogWorker.ThreadState != ThreadState.Running)
                    {
                        PacketLogWorker = new Thread(new ThreadStart(ProcessPacketQueues));
                        PacketLogWorker.Start();
                    }
                }
            }
            else
            {
                if (PacketLogWorker != null)
                {
                    PacketLogWorker.Abort();
                }
            }
        }

        private void button_AddEncoderField_Click(object sender, EventArgs e)
        {        
            string param_type = comboBox_EncoderType.Text;
            string param_val = textBox_EncoderValue.Text;

            ListViewItem listitem = new ListViewItem();
            listitem.Text = param_val; //+ ", " + param_type;

            listBox_EncoderArgs.Items.Add(listitem);
        }

        private void clearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listView_RawView.Items.Clear();
        }

        private void button_SendProtobuf_Click(object sender, EventArgs e)
        {
            string param_opcode = comboBox_EncoderOpcode.Text;
            ushort msg_opcode = FileHelper.GetOpcodeFromName("Data/opcodes.proto", param_opcode);

            //get params list
            List<string> args = new List<string>();

            foreach(ListViewItem item in listBox_EncoderArgs.Items)
            {
                string arg = item.Text;
                args.Add(arg);
            }

            MessageWrapper.SendWrappedMessage(MirClient, msg_opcode, args);
        }

        private void button_EntityMap_Click(object sender, EventArgs e)
        {
            EntityMapForm = new EntityMap();
            EntityMapForm.Show();
            EntityMapForm.LoadMap(MirClient.GameAccount.StageID);
            EntityMapForm.DrawHeroIcon((int)MirClient.Bot.Position.x, (int)MirClient.Bot.Position.y);
        }

        private void button_ClearProtobuf_Click(object sender, EventArgs e)
        {
            listBox_EncoderArgs.Items.Clear();
        }

        private void button_PrintNearbyPlayers_Click(object sender, EventArgs e)
        {
            foreach(KeyValuePair<ulong, string> player in MirClient.Bot.CharacterIds)
            {
                Console.WriteLine("Player: {0}, {1}", player.Value, player.Key);
            }
        }

        private void button_Test_Click(object sender, EventArgs e)
        {
            foreach (KeyValuePair<ulong, string> player in MirClient.Bot.CharacterIds)
            {
                Console.WriteLine("Player: {0}, {1}", player.Value, player.Key);
                MessageWrapper.CLIENT_GAME_START_CASTING(MirClient, MirClient.GameAccount.character_identifier, 1, player.Key, 0, 0, false);              
            }
        }

        private void button_PrintItems_Click(object sender, EventArgs e)
        {
            if (MirClient == null) return;
            if (MirClient.Bot == null) return;
            if (MirClient.Bot.PlayerInventory == null) return;

            if(MirClient.Bot.PlayerInventory.Count == 0)
            {
                MessageWrapper.CLIENT_GAME_CHARACTER_INVEN(MirClient, MirClient.GameAccount.character_identifier);
                Thread.Sleep(1000);
            }

            foreach(_character_inven_item item in MirClient.Bot.PlayerInventory)
            {
                Console.WriteLine("Inventory Item: {0}, {1}, count: {2}, isEquip {3}", item.item_index, item.item_uid, item.stack_count, item.is_equip);
            }
        }

        private void button_PrintQuestList_Click(object sender, EventArgs e)
        {
            if (MirClient == null) return;
            if (MirClient.Bot == null) return;
            if (MirClient.Bot.QuestManager == null) return;
            if (MirClient.Bot.QuestManager.QuestList == null) return;

            MessageWrapper.CLIENT_GAME_CHARACTER_QUEST(MirClient, MirClient.GameAccount.character_identifier);

            Thread.Sleep(2000);

            foreach (_character_quest q in  MirClient.Bot.QuestManager.QuestList)
            {
                Console.WriteLine("Quest Index: {0}, Type: {1}, Current Count: {2}", q.QuestIndex, q.quest_type, q.CurrentCount);
            }
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            if(MirClient.Bot.worker != null)
            {
                if (MirClient.Bot.worker.ThreadState == ThreadState.Running)
                    MirClient.Bot.worker.Abort();
            }

            if(this.UIMessageWorker != null)
            {
                if (this.UIMessageWorker.ThreadState == ThreadState.Running)
                    this.UIMessageWorker.Abort();
            }

            if(this.InfoUpdateWorker != null)
            {
                if (this.InfoUpdateWorker.ThreadState == ThreadState.Running)
                    this.InfoUpdateWorker.Abort();
            }

            if(this.PacketLogWorker != null)
            {
                if(this.PacketLogWorker.ThreadState == ThreadState.Running)
                    this.PacketLogWorker.Abort();
            }

            if(MirClient.HeartbeatWorker != null)
            {
                if (MirClient.HeartbeatWorker.ThreadState == ThreadState.Running)
                    MirClient.HeartbeatWorker.Abort();
            }

            Application.Exit();
            DllImports.ExitProcess(0);
       
        }

        private void SpamProtobuf()
        {
            string param_opcode = comboBox_EncoderOpcode.Text;
            ushort msg_opcode = FileHelper.GetOpcodeFromName("Data/opcodes.proto", param_opcode);

            //get params list
            List<string> args = new List<string>();

            foreach (ListViewItem item in listBox_EncoderArgs.Items)
            {
                string arg = item.Text;
                args.Add(arg);
            }

            bool spamming = true;

            int delay_ms = (int)numericUpDown_SpamDelay.Value;

            while (spamming)
            {
                try
                {
                    MessageWrapper.SendWrappedMessage(MirClient, msg_opcode, args);
                    Thread.Sleep(delay_ms);
                }
                catch (Exception e)
                {
                    Console.WriteLine("Failed to send packet @ SpamPacket");
                    return;
                }
            }
        }

        private void checkBox_SpamMessage_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox_SpamMessage.Checked)
            {
                if(PacketSpamThread == null)
                {
                    PacketSpamThread = new Thread(new ThreadStart(SpamProtobuf));
                    PacketSpamThread.Start();
                }
                else
                {
                    if(PacketSpamThread.ThreadState == ThreadState.Running)
                    {
                        PacketSpamThread.Abort();
                        PacketSpamThread = new Thread(new ThreadStart(SpamProtobuf));
                        PacketSpamThread.Start();
                    }
                }
            }
            else
            {
                PacketSpamThread.Abort();
                PacketSpamThread = null;
            }
        }

        private void checkBox_AutoQuest_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox_AutoQuest.Checked)
            {
                if(checkBox_QuestFromStart.Checked)
                {
                    
                }

                MirClient.Bot.QuestManager.AutoQuesting = true;
                MirClient.Bot.QuestManager.worker = new Thread(new ThreadStart(MirClient.Bot.QuestManager.AutoQuest));
                MirClient.Bot.QuestManager.worker.Start();
            }
            else
            {
                MirClient.Bot.QuestManager.AutoQuesting = false;
                
                if(MirClient.Bot.QuestManager.worker != null)
                    MirClient.Bot.QuestManager.worker.Abort();
            }
        }

        private void checkBox_UseConsole_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox_UseConsole.Checked)
            { 
                DllImports.AllocConsole();

                IntPtr stdHandle = DllImports.GetStdHandle(DllImports.STD_OUTPUT_HANDLE);
                SafeFileHandle safeFileHandle = new SafeFileHandle(stdHandle, true);
                FileStream fileStream = new FileStream(safeFileHandle, FileAccess.Write);
                Encoding encoding = System.Text.Encoding.GetEncoding(DllImports.MY_CODE_PAGE);
                StreamWriter standardOutput = new StreamWriter(fileStream, encoding);
                standardOutput.AutoFlush = true;
                Console.SetOut(standardOutput);

                MirClient.IsConsoleOutput = true;
                FileHelper.WriteColoredLine(ConsoleColor.Green, "Welcome to Mir4 Clientless Bot (Power Gather). Made by Better Bots Co.");
                FileHelper.WriteColoredLine(ConsoleColor.Blue, "!! Found an issue or glitch you'd like fixed? Contact a sales rep with an explanation/screenshot of the issue and we'd be happy to address it !!");
            }
            else
            {
                MirClient.IsConsoleOutput = false;
                DllImports.FreeConsole();
            }
        }

        private void button2_Click(object sender, EventArgs e) //spam packet
        {
            string sendPacketText = textBox_SendPacket.Text.Trim();

            for (int i = 0; i < 100; i++)
            {
                byte[] packetBytes = HexText.ToBytes(sendPacketText);

                var p = new Writer();
                p.WriteBytes(packetBytes);
                MirClient.m_session.SendPacket(p);
            }

        }

        private void button_NewDayRoutine_Click(object sender, EventArgs e)
        {
            //new thread -> collect clan gifts, check mail, collect attendande event
            MessageWrapper.CLIENT_GAME_GUILD_DONATION(MirClient, 2, 10000); //donate 10k coppers

            foreach(_guild_gift_info gift in MirClient.Bot.GuildGiftList)
            {
                MessageWrapper.CLIENT_GAME_GUILD_GIFT_OPEN(MirClient, gift.gift_tap_type, gift.gift_uid);
            }
        }

        private void button_WarpPortal_Click(object sender, EventArgs e)
        {
            string map = comboBox_Warp.Text;
            MirClient.Bot.TeleportToMap(map);
        }

        private void button_Portal_Click(object sender, EventArgs e)
        {
            string portal_map = comboBox_Portal.Text;

            if(portal_map != null)
            {
                if (portal_map.Contains("Secret Peak"))
                {
                    uint dungeon_num = 0;

                    if (portal_map.Contains("1F"))
                    {
                        dungeon_num = 1001;
                    }
                    else if (portal_map.Contains("2F"))
                    {
                        dungeon_num = 1002;
                    }
                    else if (portal_map.Contains("3F"))
                    {
                        dungeon_num = 1003;
                    }
                    else if (portal_map.Contains("4F"))
                    {
                        dungeon_num = 1004;
                    }
                    else if (portal_map.Contains("5F"))
                    {
                        dungeon_num = 1005;
                    }
                    else if (portal_map.Contains("6F"))
                    {
                        dungeon_num = 1006;
                    }

                    MessageWrapper.CLIENT_GAME_ENTER_SECRET_DUNGEON(MirClient, dungeon_num);
                }
                else if (portal_map.Contains("Magic Square"))
                {
                    uint dungeon_num = 0;

                    if (portal_map.Contains("1F"))
                    {
                        dungeon_num = 101;
                    }
                    else if (portal_map.Contains("2F"))
                    {
                        dungeon_num = 102;
                    }
                    else if (portal_map.Contains("3F"))
                    {
                        dungeon_num = 103;
                    }
                    else if (portal_map.Contains("4F"))
                    {
                        dungeon_num = 104;
                    }
                    else if (portal_map.Contains("5F"))
                    {
                        dungeon_num = 105;
                    }
                    else if (portal_map.Contains("6F"))
                    {
                        dungeon_num = 106;
                    }

                    MessageWrapper.CLIENT_GAME_ENTER_MAGIC_SQUARE(MirClient, dungeon_num);
                }

                MirClient.UIMessages.Enqueue("Tried entering map: " + portal_map);
            }
        }

        private void checkBox_AcceptParties_CheckedChanged(object sender, EventArgs e)
        {
            MirClient.Bot.AutoJoinParties = checkBox_AcceptParties.Checked;
        }

        private void button_LeaveParty_Click(object sender, EventArgs e)
        {
            if (MirClient == null)
                return;

            if(MirClient.Bot.InParty)
            {
                MessageWrapper.CLIENT_GAME_REQUEST_PARTY_LEAVE(MirClient, MirClient.GameAccount.character_identifier, MirClient.Bot.PartyUID);             
            }
        }

        private void creditsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Made by AlSch092 @ Github. This is free and open source software: if you paid for it, you've been ripped off!");
        }
    }
}
