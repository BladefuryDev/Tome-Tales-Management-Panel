
namespace Tome_Tales_Management_Panel
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
            System.Windows.Forms.TabControl MainTabs;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.TomeTalesBgPanel = new System.Windows.Forms.Panel();
            this.Event_Generator = new System.Windows.Forms.Label();
            this.EnemySpawnerOutput = new System.Windows.Forms.TextBox();
            this.EnemSpawnExecute = new System.Windows.Forms.Button();
            this.EnemSpawnerSettings = new System.Windows.Forms.CheckedListBox();
            this.EnemySpawnCountTT = new System.Windows.Forms.NumericUpDown();
            this.NumEnemBoxDescriptor = new System.Windows.Forms.Label();
            this.PlaceSelectorEnemSpn = new System.Windows.Forms.ComboBox();
            this.EnemySpawnerTT_Title = new System.Windows.Forms.Label();
            this.LootBoxOutput = new System.Windows.Forms.TextBox();
            this.OpenBoxesExec = new System.Windows.Forms.Button();
            this.NumBoxesDescriptor = new System.Windows.Forms.Label();
            this.NumOfBoxes = new System.Windows.Forms.NumericUpDown();
            this.BoxSelectionDropdown = new System.Windows.Forms.ComboBox();
            this.ItemBoxMenuTitle = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.Eterna_JobIssuedBy = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Eterna_JobExecuteGeneration = new System.Windows.Forms.Button();
            this.Eterna_JobModifiers = new System.Windows.Forms.CheckedListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Eterna_JobPay = new System.Windows.Forms.NumericUpDown();
            this.Eterna_JobType = new System.Windows.Forms.ComboBox();
            this.JobTypeDescriptor = new System.Windows.Forms.Label();
            this.Eterna_JobLocationDescriptor = new System.Windows.Forms.Label();
            this.Eterna_JobLocation = new System.Windows.Forms.ComboBox();
            this.Eterna_JobOutput = new System.Windows.Forms.TextBox();
            this.Eterna_StoreOutput = new System.Windows.Forms.RichTextBox();
            this.Eterna_StoreGenerateButton = new System.Windows.Forms.Button();
            this.Eterna_StoreEvent = new System.Windows.Forms.ComboBox();
            this.Eterna_StoreGenSettings = new System.Windows.Forms.CheckedListBox();
            this.Eterna_StoreRareItemToggle = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Eterna_StoreNumOfItems = new System.Windows.Forms.NumericUpDown();
            this.Eterna_Job_Board_Label = new System.Windows.Forms.Label();
            this.Eterna_Shop_Label = new System.Windows.Forms.Label();
            this.Eterna_Dungeon_Panel_Label = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            MainTabs = new System.Windows.Forms.TabControl();
            MainTabs.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.TomeTalesBgPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EnemySpawnCountTT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumOfBoxes)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Eterna_JobPay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Eterna_StoreNumOfItems)).BeginInit();
            this.SuspendLayout();
            // 
            // MainTabs
            // 
            MainTabs.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            MainTabs.Controls.Add(this.tabPage1);
            MainTabs.Controls.Add(this.tabPage2);
            MainTabs.Cursor = System.Windows.Forms.Cursors.Hand;
            MainTabs.HotTrack = true;
            MainTabs.Location = new System.Drawing.Point(-1, 4);
            MainTabs.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            MainTabs.Name = "MainTabs";
            MainTabs.SelectedIndex = 0;
            MainTabs.Size = new System.Drawing.Size(802, 445);
            MainTabs.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            MainTabs.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.TomeTalesBgPanel);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.tabPage1.Size = new System.Drawing.Size(794, 419);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Tome Tales Panel";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // TomeTalesBgPanel
            // 
            this.TomeTalesBgPanel.BackColor = System.Drawing.Color.Transparent;
            this.TomeTalesBgPanel.Controls.Add(this.Event_Generator);
            this.TomeTalesBgPanel.Controls.Add(this.EnemySpawnerOutput);
            this.TomeTalesBgPanel.Controls.Add(this.EnemSpawnExecute);
            this.TomeTalesBgPanel.Controls.Add(this.EnemSpawnerSettings);
            this.TomeTalesBgPanel.Controls.Add(this.EnemySpawnCountTT);
            this.TomeTalesBgPanel.Controls.Add(this.NumEnemBoxDescriptor);
            this.TomeTalesBgPanel.Controls.Add(this.PlaceSelectorEnemSpn);
            this.TomeTalesBgPanel.Controls.Add(this.EnemySpawnerTT_Title);
            this.TomeTalesBgPanel.Controls.Add(this.LootBoxOutput);
            this.TomeTalesBgPanel.Controls.Add(this.OpenBoxesExec);
            this.TomeTalesBgPanel.Controls.Add(this.NumBoxesDescriptor);
            this.TomeTalesBgPanel.Controls.Add(this.NumOfBoxes);
            this.TomeTalesBgPanel.Controls.Add(this.BoxSelectionDropdown);
            this.TomeTalesBgPanel.Controls.Add(this.ItemBoxMenuTitle);
            this.TomeTalesBgPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TomeTalesBgPanel.Location = new System.Drawing.Point(2, 4);
            this.TomeTalesBgPanel.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.TomeTalesBgPanel.Name = "TomeTalesBgPanel";
            this.TomeTalesBgPanel.Size = new System.Drawing.Size(790, 419);
            this.TomeTalesBgPanel.TabIndex = 0;
            // 
            // Event_Generator
            // 
            this.Event_Generator.AutoSize = true;
            this.Event_Generator.Font = new System.Drawing.Font("Exo", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Event_Generator.Location = new System.Drawing.Point(555, 9);
            this.Event_Generator.Name = "Event_Generator";
            this.Event_Generator.Size = new System.Drawing.Size(164, 22);
            this.Event_Generator.TabIndex = 13;
            this.Event_Generator.Text = "Encounter Generator";
            // 
            // EnemySpawnerOutput
            // 
            this.EnemySpawnerOutput.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.EnemySpawnerOutput.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.EnemySpawnerOutput.Location = new System.Drawing.Point(252, 160);
            this.EnemySpawnerOutput.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.EnemySpawnerOutput.Multiline = true;
            this.EnemySpawnerOutput.Name = "EnemySpawnerOutput";
            this.EnemySpawnerOutput.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.EnemySpawnerOutput.Size = new System.Drawing.Size(206, 256);
            this.EnemySpawnerOutput.TabIndex = 12;
            this.EnemySpawnerOutput.Text = "Use the controls above and press \"Execute\" to generate foes.";
            // 
            // EnemSpawnExecute
            // 
            this.EnemSpawnExecute.BackColor = System.Drawing.Color.Gainsboro;
            this.EnemSpawnExecute.FlatAppearance.BorderSize = 0;
            this.EnemSpawnExecute.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EnemSpawnExecute.Location = new System.Drawing.Point(252, 130);
            this.EnemSpawnExecute.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.EnemSpawnExecute.Name = "EnemSpawnExecute";
            this.EnemSpawnExecute.Size = new System.Drawing.Size(206, 22);
            this.EnemSpawnExecute.TabIndex = 11;
            this.EnemSpawnExecute.Text = "Execute";
            this.toolTip1.SetToolTip(this.EnemSpawnExecute, "Click to start generating foes.");
            this.EnemSpawnExecute.UseVisualStyleBackColor = false;
            this.EnemSpawnExecute.Click += new System.EventHandler(this.EnemSpawnExecute_Click);
            // 
            // EnemSpawnerSettings
            // 
            this.EnemSpawnerSettings.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.EnemSpawnerSettings.FormattingEnabled = true;
            this.EnemSpawnerSettings.Items.AddRange(new object[] {
            "Enable Loot Drops",
            "Include Bosses (25%)"});
            this.EnemSpawnerSettings.Location = new System.Drawing.Point(252, 89);
            this.EnemSpawnerSettings.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.EnemSpawnerSettings.Name = "EnemSpawnerSettings";
            this.EnemSpawnerSettings.Size = new System.Drawing.Size(207, 30);
            this.EnemSpawnerSettings.TabIndex = 10;
            this.EnemSpawnerSettings.SelectedIndexChanged += new System.EventHandler(this.EnemSpawnerSettings_SelectedIndexChanged);
            // 
            // EnemySpawnCountTT
            // 
            this.EnemySpawnCountTT.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.EnemySpawnCountTT.Cursor = System.Windows.Forms.Cursors.HSplit;
            this.EnemySpawnCountTT.Location = new System.Drawing.Point(383, 63);
            this.EnemySpawnCountTT.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.EnemySpawnCountTT.Name = "EnemySpawnCountTT";
            this.EnemySpawnCountTT.Size = new System.Drawing.Size(76, 20);
            this.EnemySpawnCountTT.TabIndex = 9;
            this.EnemySpawnCountTT.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // NumEnemBoxDescriptor
            // 
            this.NumEnemBoxDescriptor.AutoSize = true;
            this.NumEnemBoxDescriptor.Location = new System.Drawing.Point(248, 65);
            this.NumEnemBoxDescriptor.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.NumEnemBoxDescriptor.Name = "NumEnemBoxDescriptor";
            this.NumEnemBoxDescriptor.Size = new System.Drawing.Size(128, 13);
            this.NumEnemBoxDescriptor.TabIndex = 8;
            this.NumEnemBoxDescriptor.Text = "Number of foes to spawn:";
            // 
            // PlaceSelectorEnemSpn
            // 
            this.PlaceSelectorEnemSpn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PlaceSelectorEnemSpn.FormattingEnabled = true;
            this.PlaceSelectorEnemSpn.Items.AddRange(new object[] {
            "Anville Town (Void Mission)",
            "Lonesome Resort",
            "Mirage Coastline"});
            this.PlaceSelectorEnemSpn.Location = new System.Drawing.Point(248, 34);
            this.PlaceSelectorEnemSpn.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.PlaceSelectorEnemSpn.Name = "PlaceSelectorEnemSpn";
            this.PlaceSelectorEnemSpn.Size = new System.Drawing.Size(210, 21);
            this.PlaceSelectorEnemSpn.TabIndex = 7;
            this.PlaceSelectorEnemSpn.Text = "Select Mission Area...";
            // 
            // EnemySpawnerTT_Title
            // 
            this.EnemySpawnerTT_Title.AutoSize = true;
            this.EnemySpawnerTT_Title.Font = new System.Drawing.Font("Exo", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EnemySpawnerTT_Title.Location = new System.Drawing.Point(291, 8);
            this.EnemySpawnerTT_Title.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.EnemySpawnerTT_Title.Name = "EnemySpawnerTT_Title";
            this.EnemySpawnerTT_Title.Size = new System.Drawing.Size(130, 22);
            this.EnemySpawnerTT_Title.TabIndex = 6;
            this.EnemySpawnerTT_Title.Text = "Enemy Spawner";
            // 
            // LootBoxOutput
            // 
            this.LootBoxOutput.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.LootBoxOutput.BackColor = System.Drawing.Color.White;
            this.LootBoxOutput.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.LootBoxOutput.Location = new System.Drawing.Point(2, 118);
            this.LootBoxOutput.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.LootBoxOutput.Multiline = true;
            this.LootBoxOutput.Name = "LootBoxOutput";
            this.LootBoxOutput.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.LootBoxOutput.Size = new System.Drawing.Size(239, 298);
            this.LootBoxOutput.TabIndex = 5;
            this.LootBoxOutput.Text = "Select a box type and number of boxes. Press \"Commence Opening\" to generate items" +
    ".";
            // 
            // OpenBoxesExec
            // 
            this.OpenBoxesExec.BackColor = System.Drawing.Color.Gainsboro;
            this.OpenBoxesExec.FlatAppearance.BorderSize = 0;
            this.OpenBoxesExec.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OpenBoxesExec.Location = new System.Drawing.Point(2, 89);
            this.OpenBoxesExec.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.OpenBoxesExec.Name = "OpenBoxesExec";
            this.OpenBoxesExec.Size = new System.Drawing.Size(239, 22);
            this.OpenBoxesExec.TabIndex = 4;
            this.OpenBoxesExec.Text = "Commence Opening";
            this.toolTip1.SetToolTip(this.OpenBoxesExec, "Click to open the selected box type and amount of them.");
            this.OpenBoxesExec.UseVisualStyleBackColor = false;
            this.OpenBoxesExec.Click += new System.EventHandler(this.OpenBoxesExec_Click);
            // 
            // NumBoxesDescriptor
            // 
            this.NumBoxesDescriptor.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.NumBoxesDescriptor.AutoSize = true;
            this.NumBoxesDescriptor.Location = new System.Drawing.Point(7, 65);
            this.NumBoxesDescriptor.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.NumBoxesDescriptor.Name = "NumBoxesDescriptor";
            this.NumBoxesDescriptor.Size = new System.Drawing.Size(91, 13);
            this.NumBoxesDescriptor.TabIndex = 3;
            this.NumBoxesDescriptor.Text = "Number of Boxes:";
            // 
            // NumOfBoxes
            // 
            this.NumOfBoxes.AllowDrop = true;
            this.NumOfBoxes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.NumOfBoxes.Cursor = System.Windows.Forms.Cursors.HSplit;
            this.NumOfBoxes.Location = new System.Drawing.Point(100, 63);
            this.NumOfBoxes.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.NumOfBoxes.Name = "NumOfBoxes";
            this.NumOfBoxes.Size = new System.Drawing.Size(142, 20);
            this.NumOfBoxes.TabIndex = 2;
            this.NumOfBoxes.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.NumOfBoxes.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // BoxSelectionDropdown
            // 
            this.BoxSelectionDropdown.BackColor = System.Drawing.SystemColors.Window;
            this.BoxSelectionDropdown.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BoxSelectionDropdown.FormattingEnabled = true;
            this.BoxSelectionDropdown.Items.AddRange(new object[] {
            "Gift Box (Anniversary II)",
            "Gift Box (Spookfest)",
            "Gift Box (Birthday)",
            "Gift Box (Leon\'s Super Surprise)",
            "Gift Box (Summer)",
            "Gift Box (Spring)",
            "Gift Box (Fall)",
            "Gift Box (Winter)",
            "Gift Box (Champion)",
            "Gift Box (Friendship)",
            "Gift Box (Heart)",
            "Gift Box (Lucky)"});
            this.BoxSelectionDropdown.Location = new System.Drawing.Point(2, 35);
            this.BoxSelectionDropdown.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.BoxSelectionDropdown.Name = "BoxSelectionDropdown";
            this.BoxSelectionDropdown.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.BoxSelectionDropdown.Size = new System.Drawing.Size(239, 21);
            this.BoxSelectionDropdown.TabIndex = 1;
            this.BoxSelectionDropdown.Text = "Select Box Type...";
            this.BoxSelectionDropdown.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // ItemBoxMenuTitle
            // 
            this.ItemBoxMenuTitle.AutoSize = true;
            this.ItemBoxMenuTitle.Font = new System.Drawing.Font("Exo", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ItemBoxMenuTitle.Location = new System.Drawing.Point(47, 9);
            this.ItemBoxMenuTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ItemBoxMenuTitle.Name = "ItemBoxMenuTitle";
            this.ItemBoxMenuTitle.Size = new System.Drawing.Size(140, 22);
            this.ItemBoxMenuTitle.TabIndex = 0;
            this.ItemBoxMenuTitle.Text = "Loot Box Controls";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.Eterna_JobIssuedBy);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.Eterna_JobExecuteGeneration);
            this.tabPage2.Controls.Add(this.Eterna_JobModifiers);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.Eterna_JobPay);
            this.tabPage2.Controls.Add(this.Eterna_JobType);
            this.tabPage2.Controls.Add(this.JobTypeDescriptor);
            this.tabPage2.Controls.Add(this.Eterna_JobLocationDescriptor);
            this.tabPage2.Controls.Add(this.Eterna_JobLocation);
            this.tabPage2.Controls.Add(this.Eterna_JobOutput);
            this.tabPage2.Controls.Add(this.Eterna_StoreOutput);
            this.tabPage2.Controls.Add(this.Eterna_StoreGenerateButton);
            this.tabPage2.Controls.Add(this.Eterna_StoreEvent);
            this.tabPage2.Controls.Add(this.Eterna_StoreGenSettings);
            this.tabPage2.Controls.Add(this.Eterna_StoreRareItemToggle);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.Eterna_StoreNumOfItems);
            this.tabPage2.Controls.Add(this.Eterna_Job_Board_Label);
            this.tabPage2.Controls.Add(this.Eterna_Shop_Label);
            this.tabPage2.Controls.Add(this.Eterna_Dungeon_Panel_Label);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.tabPage2.Size = new System.Drawing.Size(794, 419);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Eterna Panel";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // Eterna_JobIssuedBy
            // 
            this.Eterna_JobIssuedBy.FormattingEnabled = true;
            this.Eterna_JobIssuedBy.Items.AddRange(new object[] {
            "Anville Guild Administration",
            "Whitecap Mercenary Group"});
            this.Eterna_JobIssuedBy.Location = new System.Drawing.Point(373, 94);
            this.Eterna_JobIssuedBy.Name = "Eterna_JobIssuedBy";
            this.Eterna_JobIssuedBy.Size = new System.Drawing.Size(149, 21);
            this.Eterna_JobIssuedBy.TabIndex = 21;
            this.Eterna_JobIssuedBy.Text = "Anville Guild Administration";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(414, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 20;
            this.label3.Text = "Issued by:";
            // 
            // Eterna_JobExecuteGeneration
            // 
            this.Eterna_JobExecuteGeneration.Location = new System.Drawing.Point(373, 122);
            this.Eterna_JobExecuteGeneration.Name = "Eterna_JobExecuteGeneration";
            this.Eterna_JobExecuteGeneration.Size = new System.Drawing.Size(149, 32);
            this.Eterna_JobExecuteGeneration.TabIndex = 19;
            this.Eterna_JobExecuteGeneration.Text = "Generate Job";
            this.Eterna_JobExecuteGeneration.UseVisualStyleBackColor = true;
            this.Eterna_JobExecuteGeneration.Click += new System.EventHandler(this.Eterna_JobExecuteGeneration_Click);
            // 
            // Eterna_JobModifiers
            // 
            this.Eterna_JobModifiers.FormattingEnabled = true;
            this.Eterna_JobModifiers.Items.AddRange(new object[] {
            "Tough Boss",
            "Environmental Hazard",
            "High Value Target"});
            this.Eterna_JobModifiers.Location = new System.Drawing.Point(202, 90);
            this.Eterna_JobModifiers.Name = "Eterna_JobModifiers";
            this.Eterna_JobModifiers.Size = new System.Drawing.Size(164, 64);
            this.Eterna_JobModifiers.TabIndex = 18;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(373, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "Job Pay:";
            // 
            // Eterna_JobPay
            // 
            this.Eterna_JobPay.Location = new System.Drawing.Point(427, 58);
            this.Eterna_JobPay.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.Eterna_JobPay.Name = "Eterna_JobPay";
            this.Eterna_JobPay.Size = new System.Drawing.Size(95, 20);
            this.Eterna_JobPay.TabIndex = 16;
            this.Eterna_JobPay.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // Eterna_JobType
            // 
            this.Eterna_JobType.FormattingEnabled = true;
            this.Eterna_JobType.Items.AddRange(new object[] {
            "Exploration",
            "Rescue",
            "Item Collection",
            "Escort",
            "Outlaw Capture",
            "Resource Harvest",
            "Resource Survey"});
            this.Eterna_JobType.Location = new System.Drawing.Point(255, 57);
            this.Eterna_JobType.Name = "Eterna_JobType";
            this.Eterna_JobType.Size = new System.Drawing.Size(111, 21);
            this.Eterna_JobType.TabIndex = 15;
            this.Eterna_JobType.Text = "Exploration";
            // 
            // JobTypeDescriptor
            // 
            this.JobTypeDescriptor.AutoSize = true;
            this.JobTypeDescriptor.Location = new System.Drawing.Point(202, 60);
            this.JobTypeDescriptor.Name = "JobTypeDescriptor";
            this.JobTypeDescriptor.Size = new System.Drawing.Size(54, 13);
            this.JobTypeDescriptor.TabIndex = 14;
            this.JobTypeDescriptor.Text = "Job Type:";
            // 
            // Eterna_JobLocationDescriptor
            // 
            this.Eterna_JobLocationDescriptor.AutoSize = true;
            this.Eterna_JobLocationDescriptor.Location = new System.Drawing.Point(202, 32);
            this.Eterna_JobLocationDescriptor.Name = "Eterna_JobLocationDescriptor";
            this.Eterna_JobLocationDescriptor.Size = new System.Drawing.Size(86, 13);
            this.Eterna_JobLocationDescriptor.TabIndex = 13;
            this.Eterna_JobLocationDescriptor.Text = "Location for Job:";
            // 
            // Eterna_JobLocation
            // 
            this.Eterna_JobLocation.FormattingEnabled = true;
            this.Eterna_JobLocation.Items.AddRange(new object[] {
            "Eterna Forest",
            "Anville Pass",
            "Forest Cave",
            "Plains Depth",
            "Field Forest",
            "Aynor Woods",
            "Eterna Beach Forest",
            "Murkrow Cove",
            "River Cave",
            "Midnight Cliff",
            "Midnight Quarry",
            "Glimmermist Depth"});
            this.Eterna_JobLocation.Location = new System.Drawing.Point(289, 29);
            this.Eterna_JobLocation.Name = "Eterna_JobLocation";
            this.Eterna_JobLocation.Size = new System.Drawing.Size(233, 21);
            this.Eterna_JobLocation.TabIndex = 12;
            this.Eterna_JobLocation.Text = "Select Location";
            // 
            // Eterna_JobOutput
            // 
            this.Eterna_JobOutput.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Eterna_JobOutput.Location = new System.Drawing.Point(202, 160);
            this.Eterna_JobOutput.Multiline = true;
            this.Eterna_JobOutput.Name = "Eterna_JobOutput";
            this.Eterna_JobOutput.Size = new System.Drawing.Size(320, 255);
            this.Eterna_JobOutput.TabIndex = 11;
            this.Eterna_JobOutput.Text = "Output... Please configure the above and click \"Generate Job\"";
            // 
            // Eterna_StoreOutput
            // 
            this.Eterna_StoreOutput.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Eterna_StoreOutput.Location = new System.Drawing.Point(4, 160);
            this.Eterna_StoreOutput.Name = "Eterna_StoreOutput";
            this.Eterna_StoreOutput.Size = new System.Drawing.Size(192, 255);
            this.Eterna_StoreOutput.TabIndex = 10;
            this.Eterna_StoreOutput.Text = "Output... Please configure above and click \"Generate Goods\"";
            // 
            // Eterna_StoreGenerateButton
            // 
            this.Eterna_StoreGenerateButton.BackColor = System.Drawing.Color.Transparent;
            this.Eterna_StoreGenerateButton.FlatAppearance.BorderSize = 0;
            this.Eterna_StoreGenerateButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.Eterna_StoreGenerateButton.Location = new System.Drawing.Point(5, 122);
            this.Eterna_StoreGenerateButton.Name = "Eterna_StoreGenerateButton";
            this.Eterna_StoreGenerateButton.Size = new System.Drawing.Size(106, 31);
            this.Eterna_StoreGenerateButton.TabIndex = 9;
            this.Eterna_StoreGenerateButton.Text = "Generate Goods";
            this.Eterna_StoreGenerateButton.UseVisualStyleBackColor = false;
            this.Eterna_StoreGenerateButton.Click += new System.EventHandler(this.Eterna_StoreGenerateButton_Click);
            // 
            // Eterna_StoreEvent
            // 
            this.Eterna_StoreEvent.FormattingEnabled = true;
            this.Eterna_StoreEvent.Items.AddRange(new object[] {
            "No Event",
            "Berries Half Off",
            "Scarfs Half Off",
            "Orbs Half Off",
            "Activated Orbs",
            "Firesale"});
            this.Eterna_StoreEvent.Location = new System.Drawing.Point(5, 94);
            this.Eterna_StoreEvent.Name = "Eterna_StoreEvent";
            this.Eterna_StoreEvent.Size = new System.Drawing.Size(106, 21);
            this.Eterna_StoreEvent.TabIndex = 8;
            this.Eterna_StoreEvent.Text = "No Event";
            // 
            // Eterna_StoreGenSettings
            // 
            this.Eterna_StoreGenSettings.BackColor = System.Drawing.SystemColors.Window;
            this.Eterna_StoreGenSettings.FormattingEnabled = true;
            this.Eterna_StoreGenSettings.Items.AddRange(new object[] {
            "Berreis",
            "Scarfs",
            "Orbs",
            "Powerups",
            "Seeds"});
            this.Eterna_StoreGenSettings.Location = new System.Drawing.Point(117, 29);
            this.Eterna_StoreGenSettings.Name = "Eterna_StoreGenSettings";
            this.Eterna_StoreGenSettings.Size = new System.Drawing.Size(79, 124);
            this.Eterna_StoreGenSettings.TabIndex = 3;
            // 
            // Eterna_StoreRareItemToggle
            // 
            this.Eterna_StoreRareItemToggle.AutoSize = true;
            this.Eterna_StoreRareItemToggle.Location = new System.Drawing.Point(21, 71);
            this.Eterna_StoreRareItemToggle.Name = "Eterna_StoreRareItemToggle";
            this.Eterna_StoreRareItemToggle.Size = new System.Drawing.Size(77, 17);
            this.Eterna_StoreRareItemToggle.TabIndex = 7;
            this.Eterna_StoreRareItemToggle.Text = "Rare Items";
            this.Eterna_StoreRareItemToggle.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Number of items:";
            // 
            // Eterna_StoreNumOfItems
            // 
            this.Eterna_StoreNumOfItems.Location = new System.Drawing.Point(41, 45);
            this.Eterna_StoreNumOfItems.Name = "Eterna_StoreNumOfItems";
            this.Eterna_StoreNumOfItems.Size = new System.Drawing.Size(41, 20);
            this.Eterna_StoreNumOfItems.TabIndex = 4;
            this.Eterna_StoreNumOfItems.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // Eterna_Job_Board_Label
            // 
            this.Eterna_Job_Board_Label.AutoSize = true;
            this.Eterna_Job_Board_Label.Font = new System.Drawing.Font("Exo", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Eterna_Job_Board_Label.Location = new System.Drawing.Point(285, 4);
            this.Eterna_Job_Board_Label.Name = "Eterna_Job_Board_Label";
            this.Eterna_Job_Board_Label.Size = new System.Drawing.Size(161, 22);
            this.Eterna_Job_Board_Label.TabIndex = 2;
            this.Eterna_Job_Board_Label.Text = "Job Board Generator";
            // 
            // Eterna_Shop_Label
            // 
            this.Eterna_Shop_Label.AutoSize = true;
            this.Eterna_Shop_Label.Font = new System.Drawing.Font("Exo", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Eterna_Shop_Label.Location = new System.Drawing.Point(49, 4);
            this.Eterna_Shop_Label.Name = "Eterna_Shop_Label";
            this.Eterna_Shop_Label.Size = new System.Drawing.Size(129, 22);
            this.Eterna_Shop_Label.TabIndex = 1;
            this.Eterna_Shop_Label.Text = "Store Generator";
            this.toolTip1.SetToolTip(this.Eterna_Shop_Label, "This panel allows for a randomized store inventory, best used weekly. Select item" +
        " types to include and let it roll. Pokemon specific items should be added by the" +
        " user if they are to be included.");
            // 
            // Eterna_Dungeon_Panel_Label
            // 
            this.Eterna_Dungeon_Panel_Label.AutoSize = true;
            this.Eterna_Dungeon_Panel_Label.Font = new System.Drawing.Font("Exo", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Eterna_Dungeon_Panel_Label.Location = new System.Drawing.Point(589, 4);
            this.Eterna_Dungeon_Panel_Label.Name = "Eterna_Dungeon_Panel_Label";
            this.Eterna_Dungeon_Panel_Label.Size = new System.Drawing.Size(121, 22);
            this.Eterna_Dungeon_Panel_Label.TabIndex = 0;
            this.Eterna_Dungeon_Panel_Label.Text = "Dungeon Panel";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(MainTabs);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Eterna Control Center | I85 | v0.362";
            MainTabs.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.TomeTalesBgPanel.ResumeLayout(false);
            this.TomeTalesBgPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EnemySpawnCountTT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumOfBoxes)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Eterna_JobPay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Eterna_StoreNumOfItems)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Panel TomeTalesBgPanel;
        private System.Windows.Forms.Label ItemBoxMenuTitle;
        private System.Windows.Forms.ComboBox BoxSelectionDropdown;
        private System.Windows.Forms.Label NumBoxesDescriptor;
        private System.Windows.Forms.NumericUpDown NumOfBoxes;
        private System.Windows.Forms.TextBox LootBoxOutput;
        private System.Windows.Forms.Button OpenBoxesExec;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.NumericUpDown EnemySpawnCountTT;
        private System.Windows.Forms.Label NumEnemBoxDescriptor;
        private System.Windows.Forms.ComboBox PlaceSelectorEnemSpn;
        private System.Windows.Forms.Label EnemySpawnerTT_Title;
        private System.Windows.Forms.Button EnemSpawnExecute;
        private System.Windows.Forms.CheckedListBox EnemSpawnerSettings;
        private System.Windows.Forms.TextBox EnemySpawnerOutput;
        private System.Windows.Forms.Label Eterna_Dungeon_Panel_Label;
        private System.Windows.Forms.Label Eterna_Job_Board_Label;
        private System.Windows.Forms.Label Eterna_Shop_Label;
        private System.Windows.Forms.CheckedListBox Eterna_StoreGenSettings;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.RichTextBox Eterna_StoreOutput;
        private System.Windows.Forms.Button Eterna_StoreGenerateButton;
        private System.Windows.Forms.ComboBox Eterna_StoreEvent;
        private System.Windows.Forms.CheckBox Eterna_StoreRareItemToggle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown Eterna_StoreNumOfItems;
        private System.Windows.Forms.TextBox Eterna_JobOutput;
        private System.Windows.Forms.Label Eterna_JobLocationDescriptor;
        private System.Windows.Forms.ComboBox Eterna_JobLocation;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown Eterna_JobPay;
        private System.Windows.Forms.ComboBox Eterna_JobType;
        private System.Windows.Forms.Label JobTypeDescriptor;
        private System.Windows.Forms.ComboBox Eterna_JobIssuedBy;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Eterna_JobExecuteGeneration;
        private System.Windows.Forms.CheckedListBox Eterna_JobModifiers;
        private System.Windows.Forms.Label Event_Generator;
    }
}

