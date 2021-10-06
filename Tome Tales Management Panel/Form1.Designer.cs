
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.MainTabs = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.LootBoxPanel = new System.Windows.Forms.Panel();
            this.ItemBoxMenuTitle = new System.Windows.Forms.Label();
            this.BoxSelectionDropdown = new System.Windows.Forms.ComboBox();
            this.NumOfBoxes = new System.Windows.Forms.NumericUpDown();
            this.NumBoxesDescriptor = new System.Windows.Forms.Label();
            this.OpenBoxesExec = new System.Windows.Forms.Button();
            this.LootBoxOutput = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.MainTabs.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.LootBoxPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumOfBoxes)).BeginInit();
            this.SuspendLayout();
            // 
            // MainTabs
            // 
            this.MainTabs.Controls.Add(this.tabPage1);
            this.MainTabs.Controls.Add(this.tabPage2);
            this.MainTabs.HotTrack = true;
            this.MainTabs.Location = new System.Drawing.Point(3, 3);
            this.MainTabs.Name = "MainTabs";
            this.MainTabs.SelectedIndex = 0;
            this.MainTabs.Size = new System.Drawing.Size(794, 444);
            this.MainTabs.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.LootBoxPanel);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(786, 418);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Tome Tales Panel";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(786, 418);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Eterna Panel";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // LootBoxPanel
            // 
            this.LootBoxPanel.Controls.Add(this.LootBoxOutput);
            this.LootBoxPanel.Controls.Add(this.OpenBoxesExec);
            this.LootBoxPanel.Controls.Add(this.NumBoxesDescriptor);
            this.LootBoxPanel.Controls.Add(this.NumOfBoxes);
            this.LootBoxPanel.Controls.Add(this.BoxSelectionDropdown);
            this.LootBoxPanel.Controls.Add(this.ItemBoxMenuTitle);
            this.LootBoxPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LootBoxPanel.Location = new System.Drawing.Point(3, 3);
            this.LootBoxPanel.Name = "LootBoxPanel";
            this.LootBoxPanel.Size = new System.Drawing.Size(780, 412);
            this.LootBoxPanel.TabIndex = 0;
            // 
            // ItemBoxMenuTitle
            // 
            this.ItemBoxMenuTitle.AutoSize = true;
            this.ItemBoxMenuTitle.Font = new System.Drawing.Font("Exo", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ItemBoxMenuTitle.Location = new System.Drawing.Point(48, 0);
            this.ItemBoxMenuTitle.Name = "ItemBoxMenuTitle";
            this.ItemBoxMenuTitle.Size = new System.Drawing.Size(140, 22);
            this.ItemBoxMenuTitle.TabIndex = 0;
            this.ItemBoxMenuTitle.Text = "Loot Box Controls";
            // 
            // BoxSelectionDropdown
            // 
            this.BoxSelectionDropdown.BackColor = System.Drawing.SystemColors.Window;
            this.BoxSelectionDropdown.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BoxSelectionDropdown.FormattingEnabled = true;
            this.BoxSelectionDropdown.Items.AddRange(new object[] {
            "Gift Box (Anniversary II)",
            "Gift Box (Spookfest)",
            "Gift Box (Leon\'s Super Surprise)",
            "Gift Box (Summer)"});
            this.BoxSelectionDropdown.Location = new System.Drawing.Point(3, 35);
            this.BoxSelectionDropdown.Name = "BoxSelectionDropdown";
            this.BoxSelectionDropdown.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.BoxSelectionDropdown.Size = new System.Drawing.Size(239, 21);
            this.BoxSelectionDropdown.TabIndex = 1;
            this.BoxSelectionDropdown.Text = "Select Box Type...";
            this.BoxSelectionDropdown.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // NumOfBoxes
            // 
            this.NumOfBoxes.AllowDrop = true;
            this.NumOfBoxes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.NumOfBoxes.Cursor = System.Windows.Forms.Cursors.HSplit;
            this.NumOfBoxes.Location = new System.Drawing.Point(100, 63);
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
            // NumBoxesDescriptor
            // 
            this.NumBoxesDescriptor.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.NumBoxesDescriptor.AutoSize = true;
            this.NumBoxesDescriptor.Location = new System.Drawing.Point(3, 65);
            this.NumBoxesDescriptor.Name = "NumBoxesDescriptor";
            this.NumBoxesDescriptor.Size = new System.Drawing.Size(91, 13);
            this.NumBoxesDescriptor.TabIndex = 3;
            this.NumBoxesDescriptor.Text = "Number of Boxes:";
            // 
            // OpenBoxesExec
            // 
            this.OpenBoxesExec.BackColor = System.Drawing.Color.Gainsboro;
            this.OpenBoxesExec.FlatAppearance.BorderSize = 0;
            this.OpenBoxesExec.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OpenBoxesExec.Location = new System.Drawing.Point(3, 89);
            this.OpenBoxesExec.Name = "OpenBoxesExec";
            this.OpenBoxesExec.Size = new System.Drawing.Size(239, 23);
            this.OpenBoxesExec.TabIndex = 4;
            this.OpenBoxesExec.Text = "Commence Opening";
            this.OpenBoxesExec.UseVisualStyleBackColor = false;
            this.OpenBoxesExec.Click += new System.EventHandler(this.OpenBoxesExec_Click);
            // 
            // LootBoxOutput
            // 
            this.LootBoxOutput.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.LootBoxOutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LootBoxOutput.Location = new System.Drawing.Point(3, 118);
            this.LootBoxOutput.Multiline = true;
            this.LootBoxOutput.Name = "LootBoxOutput";
            this.LootBoxOutput.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.LootBoxOutput.Size = new System.Drawing.Size(239, 291);
            this.LootBoxOutput.TabIndex = 5;
            this.LootBoxOutput.Text = "Sample Text";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.MainTabs);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Eterna Control Center | Iteration 85 | v0.16";
            this.MainTabs.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.LootBoxPanel.ResumeLayout(false);
            this.LootBoxPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumOfBoxes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabControl MainTabs;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Panel LootBoxPanel;
        private System.Windows.Forms.Label ItemBoxMenuTitle;
        private System.Windows.Forms.ComboBox BoxSelectionDropdown;
        private System.Windows.Forms.Label NumBoxesDescriptor;
        private System.Windows.Forms.NumericUpDown NumOfBoxes;
        private System.Windows.Forms.TextBox LootBoxOutput;
        private System.Windows.Forms.Button OpenBoxesExec;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}

