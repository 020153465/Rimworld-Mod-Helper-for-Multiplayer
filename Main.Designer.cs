namespace Rimworld_Mods_Helper
{
    partial class Main_menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main_menu));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.mpBtn1 = new System.Windows.Forms.Button();
            this.sepLabel = new System.Windows.Forms.Label();
            this.modRTB = new System.Windows.Forms.RichTextBox();
            this.modLabel = new System.Windows.Forms.Label();
            this.configLabel = new System.Windows.Forms.Label();
            this.configRTB = new System.Windows.Forms.RichTextBox();
            this.insModStatus = new System.Windows.Forms.RichTextBox();
            this.insConfigStatus = new System.Windows.Forms.RichTextBox();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.insConfigBtn = new System.Windows.Forms.Button();
            this.insModBtn = new System.Windows.Forms.Button();
            this.modListRTB = new System.Windows.Forms.RichTextBox();
            this.insModLabel = new System.Windows.Forms.Label();
            this.insConfigLabel = new System.Windows.Forms.Label();
            this.watcher = new System.IO.FileSystemWatcher();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.watcher)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.IsSplitterFixed = true;
            this.splitContainer1.Location = new System.Drawing.Point(-5, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.mpBtn1);
            this.splitContainer1.Panel1.Controls.Add(this.sepLabel);
            this.splitContainer1.Panel1.Controls.Add(this.modRTB);
            this.splitContainer1.Panel1.Controls.Add(this.modLabel);
            this.splitContainer1.Panel1.Controls.Add(this.configLabel);
            this.splitContainer1.Panel1.Controls.Add(this.configRTB);
            this.splitContainer1.Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Panel1_Paint);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.insModStatus);
            this.splitContainer1.Panel2.Controls.Add(this.insConfigStatus);
            this.splitContainer1.Panel2.Controls.Add(this.progressBar);
            this.splitContainer1.Panel2.Controls.Add(this.insConfigBtn);
            this.splitContainer1.Panel2.Controls.Add(this.insModBtn);
            this.splitContainer1.Panel2.Controls.Add(this.modListRTB);
            this.splitContainer1.Panel2.Controls.Add(this.insModLabel);
            this.splitContainer1.Panel2.Controls.Add(this.insConfigLabel);
            this.splitContainer1.Panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Panel2_Paint);
            this.splitContainer1.Size = new System.Drawing.Size(715, 320);
            this.splitContainer1.SplitterDistance = 109;
            this.splitContainer1.TabIndex = 0;
            // 
            // mpBtn1
            // 
            this.mpBtn1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.mpBtn1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.mpBtn1.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mpBtn1.Location = new System.Drawing.Point(627, 52);
            this.mpBtn1.Name = "mpBtn1";
            this.mpBtn1.Size = new System.Drawing.Size(70, 32);
            this.mpBtn1.TabIndex = 4;
            this.mpBtn1.Text = "Browse";
            this.mpBtn1.UseVisualStyleBackColor = false;
            this.mpBtn1.Click += new System.EventHandler(this.mpBtn1_Click);
            // 
            // sepLabel
            // 
            this.sepLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.sepLabel.Location = new System.Drawing.Point(-28, 100);
            this.sepLabel.Name = "sepLabel";
            this.sepLabel.Size = new System.Drawing.Size(740, 1);
            this.sepLabel.TabIndex = 0;
            // 
            // modRTB
            // 
            this.modRTB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.modRTB.Cursor = System.Windows.Forms.Cursors.Hand;
            this.modRTB.DetectUrls = false;
            this.modRTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modRTB.Location = new System.Drawing.Point(116, 52);
            this.modRTB.Multiline = false;
            this.modRTB.Name = "modRTB";
            this.modRTB.ReadOnly = true;
            this.modRTB.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.modRTB.Size = new System.Drawing.Size(505, 32);
            this.modRTB.TabIndex = 3;
            this.modRTB.Text = "Empty";
            this.modRTB.WordWrap = false;
            // 
            // modLabel
            // 
            this.modLabel.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.modLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.modLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.modLabel.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modLabel.Location = new System.Drawing.Point(10, 52);
            this.modLabel.Name = "modLabel";
            this.modLabel.Size = new System.Drawing.Size(100, 32);
            this.modLabel.TabIndex = 2;
            this.modLabel.Text = "Mod Path";
            this.modLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.modLabel.Click += new System.EventHandler(this.modLabel_Click);
            // 
            // configLabel
            // 
            this.configLabel.BackColor = System.Drawing.SystemColors.Control;
            this.configLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.configLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.configLabel.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.configLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.configLabel.Location = new System.Drawing.Point(10, 10);
            this.configLabel.Name = "configLabel";
            this.configLabel.Size = new System.Drawing.Size(100, 32);
            this.configLabel.TabIndex = 1;
            this.configLabel.Text = "Config Path";
            this.configLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.configLabel.UseCompatibleTextRendering = true;
            this.configLabel.Click += new System.EventHandler(this.configLabel_Click);
            // 
            // configRTB
            // 
            this.configRTB.AutoWordSelection = true;
            this.configRTB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.configRTB.Cursor = System.Windows.Forms.Cursors.Hand;
            this.configRTB.DetectUrls = false;
            this.configRTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.configRTB.Location = new System.Drawing.Point(116, 10);
            this.configRTB.Multiline = false;
            this.configRTB.Name = "configRTB";
            this.configRTB.ReadOnly = true;
            this.configRTB.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Horizontal;
            this.configRTB.Size = new System.Drawing.Size(581, 32);
            this.configRTB.TabIndex = 0;
            this.configRTB.Text = "Empty";
            this.configRTB.WordWrap = false;
            // 
            // insModStatus
            // 
            this.insModStatus.AutoWordSelection = true;
            this.insModStatus.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.insModStatus.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.insModStatus.DetectUrls = false;
            this.insModStatus.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.insModStatus.Location = new System.Drawing.Point(597, 0);
            this.insModStatus.Multiline = false;
            this.insModStatus.Name = "insModStatus";
            this.insModStatus.ReadOnly = true;
            this.insModStatus.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.insModStatus.Size = new System.Drawing.Size(100, 30);
            this.insModStatus.TabIndex = 13;
            this.insModStatus.Text = "";
            this.insModStatus.WordWrap = false;
            // 
            // insConfigStatus
            // 
            this.insConfigStatus.AutoWordSelection = true;
            this.insConfigStatus.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.insConfigStatus.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.insConfigStatus.DetectUrls = false;
            this.insConfigStatus.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.insConfigStatus.Location = new System.Drawing.Point(216, 0);
            this.insConfigStatus.Multiline = false;
            this.insConfigStatus.Name = "insConfigStatus";
            this.insConfigStatus.ReadOnly = true;
            this.insConfigStatus.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.insConfigStatus.ShowSelectionMargin = true;
            this.insConfigStatus.Size = new System.Drawing.Size(100, 30);
            this.insConfigStatus.TabIndex = 5;
            this.insConfigStatus.Text = "";
            this.insConfigStatus.WordWrap = false;
            // 
            // progressBar
            // 
            this.progressBar.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.progressBar.Location = new System.Drawing.Point(166, 149);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(375, 30);
            this.progressBar.TabIndex = 12;
            // 
            // insConfigBtn
            // 
            this.insConfigBtn.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.insConfigBtn.Location = new System.Drawing.Point(10, 149);
            this.insConfigBtn.Name = "insConfigBtn";
            this.insConfigBtn.Size = new System.Drawing.Size(150, 30);
            this.insConfigBtn.TabIndex = 11;
            this.insConfigBtn.Text = "Install Config";
            this.insConfigBtn.UseVisualStyleBackColor = true;
            this.insConfigBtn.Click += new System.EventHandler(this.insConfigBtn_Click);
            // 
            // insModBtn
            // 
            this.insModBtn.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.insModBtn.Location = new System.Drawing.Point(547, 149);
            this.insModBtn.Name = "insModBtn";
            this.insModBtn.Size = new System.Drawing.Size(150, 30);
            this.insModBtn.TabIndex = 10;
            this.insModBtn.Text = "Install Mods";
            this.insModBtn.UseVisualStyleBackColor = true;
            this.insModBtn.Click += new System.EventHandler(this.insModBtn_Click);
            // 
            // modListRTB
            // 
            this.modListRTB.AutoWordSelection = true;
            this.modListRTB.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.modListRTB.BulletIndent = 4;
            this.modListRTB.DetectUrls = false;
            this.modListRTB.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modListRTB.ForeColor = System.Drawing.Color.LemonChiffon;
            this.modListRTB.Location = new System.Drawing.Point(10, 33);
            this.modListRTB.Name = "modListRTB";
            this.modListRTB.ReadOnly = true;
            this.modListRTB.Size = new System.Drawing.Size(687, 110);
            this.modListRTB.TabIndex = 9;
            this.modListRTB.Text = "Empty";
            // 
            // insModLabel
            // 
            this.insModLabel.BackColor = System.Drawing.SystemColors.Control;
            this.insModLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.insModLabel.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.insModLabel.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.insModLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.insModLabel.Location = new System.Drawing.Point(391, 0);
            this.insModLabel.Name = "insModLabel";
            this.insModLabel.Size = new System.Drawing.Size(200, 30);
            this.insModLabel.TabIndex = 7;
            this.insModLabel.Text = "Installer Mods Status";
            this.insModLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.insModLabel.UseCompatibleTextRendering = true;
            // 
            // insConfigLabel
            // 
            this.insConfigLabel.BackColor = System.Drawing.SystemColors.Control;
            this.insConfigLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.insConfigLabel.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.insConfigLabel.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.insConfigLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.insConfigLabel.Location = new System.Drawing.Point(10, 0);
            this.insConfigLabel.Name = "insConfigLabel";
            this.insConfigLabel.Size = new System.Drawing.Size(200, 30);
            this.insConfigLabel.TabIndex = 5;
            this.insConfigLabel.Text = "Installer Config\'s Status";
            this.insConfigLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.insConfigLabel.UseCompatibleTextRendering = true;
            // 
            // watcher
            // 
            this.watcher.EnableRaisingEvents = true;
            this.watcher.SynchronizingObject = this;
            // 
            // Main_menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(704, 321);
            this.Controls.Add(this.splitContainer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(720, 360);
            this.MinimumSize = new System.Drawing.Size(720, 360);
            this.Name = "Main_menu";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Rimworld Mod Helper";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.watcher)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button mpBtn1;
        private System.Windows.Forms.Label modLabel;
        private System.Windows.Forms.Label configLabel;
        private System.Windows.Forms.RichTextBox configRTB;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.RichTextBox modRTB;
        private System.Windows.Forms.Label sepLabel;
        private System.Windows.Forms.Label insConfigLabel;
        private System.Windows.Forms.Label insModLabel;
        private System.Windows.Forms.RichTextBox modListRTB;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.Button insConfigBtn;
        private System.Windows.Forms.Button insModBtn;
        private System.Windows.Forms.RichTextBox insConfigStatus;
        private System.Windows.Forms.RichTextBox insModStatus;
        private System.IO.FileSystemWatcher watcher;
    }
}

