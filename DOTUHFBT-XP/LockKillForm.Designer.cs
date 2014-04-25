namespace DOTUHFBT_XP
{
    partial class LockKillForm
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
            this.textBox_epc = new System.Windows.Forms.TextBox();
            this.checkBox_mask = new System.Windows.Forms.CheckBox();
            this.checkBox_continue = new System.Windows.Forms.CheckBox();
            this.radioButton_kill = new System.Windows.Forms.RadioButton();
            this.radioButton_lock = new System.Windows.Forms.RadioButton();
            this.pictureBox_status = new System.Windows.Forms.PictureBox();
            this.label_status = new System.Windows.Forms.Label();
            this.pictureBox_detect = new System.Windows.Forms.PictureBox();
            this.label_detect = new System.Windows.Forms.Label();
            this.pictureBox_link = new System.Windows.Forms.PictureBox();
            this.label_link = new System.Windows.Forms.Label();
            this.button_access = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button_mask = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.textBox_accesspassword = new System.Windows.Forms.TextBox();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.textBox_killpassword = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.comboBox_bank = new System.Windows.Forms.ComboBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.comboBox_lockop = new System.Windows.Forms.ComboBox();
            this.label_txpwr = new System.Windows.Forms.Label();
            this.trackBar_txpwr = new System.Windows.Forms.TrackBar();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_status)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_detect)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_link)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_txpwr)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox_epc
            // 
            this.textBox_epc.Location = new System.Drawing.Point(11, 121);
            this.textBox_epc.Name = "textBox_epc";
            this.textBox_epc.Size = new System.Drawing.Size(244, 21);
            this.textBox_epc.TabIndex = 62;
            // 
            // checkBox_mask
            // 
            this.checkBox_mask.AutoSize = true;
            this.checkBox_mask.Font = new System.Drawing.Font("Gulim", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.checkBox_mask.Location = new System.Drawing.Point(96, 75);
            this.checkBox_mask.Name = "checkBox_mask";
            this.checkBox_mask.Size = new System.Drawing.Size(15, 14);
            this.checkBox_mask.TabIndex = 59;
            this.checkBox_mask.UseVisualStyleBackColor = true;
            this.checkBox_mask.CheckedChanged += new System.EventHandler(this.checkBox_mask_CheckedChanged);
            // 
            // checkBox_continue
            // 
            this.checkBox_continue.AutoSize = true;
            this.checkBox_continue.Font = new System.Drawing.Font("Gulim", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.checkBox_continue.Location = new System.Drawing.Point(96, 54);
            this.checkBox_continue.Name = "checkBox_continue";
            this.checkBox_continue.Size = new System.Drawing.Size(82, 16);
            this.checkBox_continue.TabIndex = 58;
            this.checkBox_continue.Text = "Continue";
            this.checkBox_continue.UseVisualStyleBackColor = true;
            this.checkBox_continue.CheckedChanged += new System.EventHandler(this.checkBox_continue_CheckedChanged);
            // 
            // radioButton_kill
            // 
            this.radioButton_kill.AutoSize = true;
            this.radioButton_kill.Font = new System.Drawing.Font("Gulim", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.radioButton_kill.Location = new System.Drawing.Point(13, 74);
            this.radioButton_kill.Name = "radioButton_kill";
            this.radioButton_kill.Size = new System.Drawing.Size(44, 16);
            this.radioButton_kill.TabIndex = 57;
            this.radioButton_kill.TabStop = true;
            this.radioButton_kill.Text = "Kill";
            this.radioButton_kill.UseVisualStyleBackColor = true;
            // 
            // radioButton_lock
            // 
            this.radioButton_lock.AutoSize = true;
            this.radioButton_lock.Font = new System.Drawing.Font("Gulim", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.radioButton_lock.Location = new System.Drawing.Point(13, 54);
            this.radioButton_lock.Name = "radioButton_lock";
            this.radioButton_lock.Size = new System.Drawing.Size(54, 16);
            this.radioButton_lock.TabIndex = 56;
            this.radioButton_lock.TabStop = true;
            this.radioButton_lock.Text = "Lock";
            this.radioButton_lock.UseVisualStyleBackColor = true;
            // 
            // pictureBox_status
            // 
            this.pictureBox_status.Location = new System.Drawing.Point(189, 50);
            this.pictureBox_status.Name = "pictureBox_status";
            this.pictureBox_status.Size = new System.Drawing.Size(17, 17);
            this.pictureBox_status.TabIndex = 55;
            this.pictureBox_status.TabStop = false;
            // 
            // label_status
            // 
            this.label_status.AutoSize = true;
            this.label_status.Font = new System.Drawing.Font("Gulim", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label_status.Location = new System.Drawing.Point(210, 54);
            this.label_status.Name = "label_status";
            this.label_status.Size = new System.Drawing.Size(46, 12);
            this.label_status.TabIndex = 54;
            this.label_status.Text = "Status";
            // 
            // pictureBox_detect
            // 
            this.pictureBox_detect.Location = new System.Drawing.Point(189, 27);
            this.pictureBox_detect.Name = "pictureBox_detect";
            this.pictureBox_detect.Size = new System.Drawing.Size(17, 17);
            this.pictureBox_detect.TabIndex = 53;
            this.pictureBox_detect.TabStop = false;
            // 
            // label_detect
            // 
            this.label_detect.AutoSize = true;
            this.label_detect.Font = new System.Drawing.Font("Gulim", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label_detect.Location = new System.Drawing.Point(210, 31);
            this.label_detect.Name = "label_detect";
            this.label_detect.Size = new System.Drawing.Size(46, 12);
            this.label_detect.TabIndex = 52;
            this.label_detect.Text = "Detect";
            // 
            // pictureBox_link
            // 
            this.pictureBox_link.Location = new System.Drawing.Point(189, 5);
            this.pictureBox_link.Name = "pictureBox_link";
            this.pictureBox_link.Size = new System.Drawing.Size(17, 17);
            this.pictureBox_link.TabIndex = 51;
            this.pictureBox_link.TabStop = false;
            // 
            // label_link
            // 
            this.label_link.AutoSize = true;
            this.label_link.Font = new System.Drawing.Font("Gulim", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label_link.Location = new System.Drawing.Point(210, 9);
            this.label_link.Name = "label_link";
            this.label_link.Size = new System.Drawing.Size(23, 12);
            this.label_link.TabIndex = 50;
            this.label_link.Text = "On";
            // 
            // button_access
            // 
            this.button_access.Font = new System.Drawing.Font("Gulim", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button_access.Location = new System.Drawing.Point(4, 3);
            this.button_access.Name = "button_access";
            this.button_access.Size = new System.Drawing.Size(179, 31);
            this.button_access.TabIndex = 49;
            this.button_access.Text = "ACCESS";
            this.button_access.UseVisualStyleBackColor = true;
            this.button_access.Click += new System.EventHandler(this.button_access_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Font = new System.Drawing.Font("Gulim", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.groupBox1.Location = new System.Drawing.Point(6, 38);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(75, 56);
            this.groupBox1.TabIndex = 60;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Type";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button_mask);
            this.groupBox2.Font = new System.Drawing.Font("Gulim", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.groupBox2.Location = new System.Drawing.Point(86, 37);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(97, 57);
            this.groupBox2.TabIndex = 61;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Mode";
            // 
            // button_mask
            // 
            this.button_mask.Location = new System.Drawing.Point(29, 34);
            this.button_mask.Name = "button_mask";
            this.button_mask.Size = new System.Drawing.Size(59, 20);
            this.button_mask.TabIndex = 0;
            this.button_mask.Text = "MASK";
            this.button_mask.UseVisualStyleBackColor = true;
            this.button_mask.Click += new System.EventHandler(this.button_mask_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Font = new System.Drawing.Font("Gulim", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.groupBox3.Location = new System.Drawing.Point(4, 103);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(256, 48);
            this.groupBox3.TabIndex = 63;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "EPC";
            // 
            // textBox_accesspassword
            // 
            this.textBox_accesspassword.Location = new System.Drawing.Point(143, 181);
            this.textBox_accesspassword.Name = "textBox_accesspassword";
            this.textBox_accesspassword.Size = new System.Drawing.Size(112, 21);
            this.textBox_accesspassword.TabIndex = 64;
            // 
            // groupBox8
            // 
            this.groupBox8.Font = new System.Drawing.Font("Gulim", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.groupBox8.Location = new System.Drawing.Point(135, 163);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(125, 46);
            this.groupBox8.TabIndex = 65;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "Access pwd";
            // 
            // textBox_killpassword
            // 
            this.textBox_killpassword.Location = new System.Drawing.Point(10, 181);
            this.textBox_killpassword.Name = "textBox_killpassword";
            this.textBox_killpassword.Size = new System.Drawing.Size(111, 21);
            this.textBox_killpassword.TabIndex = 66;
            // 
            // groupBox4
            // 
            this.groupBox4.Font = new System.Drawing.Font("Gulim", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.groupBox4.Location = new System.Drawing.Point(3, 163);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(126, 46);
            this.groupBox4.TabIndex = 67;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Kill pwd";
            // 
            // comboBox_bank
            // 
            this.comboBox_bank.FormattingEnabled = true;
            this.comboBox_bank.Items.AddRange(new object[] {
            "Kill PWD",
            "Access PWD",
            "EPC",
            "TID",
            "USER"});
            this.comboBox_bank.Location = new System.Drawing.Point(6, 20);
            this.comboBox_bank.Name = "comboBox_bank";
            this.comboBox_bank.Size = new System.Drawing.Size(111, 20);
            this.comboBox_bank.TabIndex = 68;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.comboBox_bank);
            this.groupBox5.Font = new System.Drawing.Font("Gulim", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.groupBox5.Location = new System.Drawing.Point(4, 228);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(125, 54);
            this.groupBox5.TabIndex = 69;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Bank";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.comboBox_lockop);
            this.groupBox6.Font = new System.Drawing.Font("Gulim", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.groupBox6.Location = new System.Drawing.Point(135, 228);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(125, 54);
            this.groupBox6.TabIndex = 70;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Lock Op.";
            // 
            // comboBox_lockop
            // 
            this.comboBox_lockop.FormattingEnabled = true;
            this.comboBox_lockop.Items.AddRange(new object[] {
            "skip",
            "accessible",
            "secured accessible",
            "perm. accessible",
            "perm. inaccessibe"});
            this.comboBox_lockop.Location = new System.Drawing.Point(8, 20);
            this.comboBox_lockop.Name = "comboBox_lockop";
            this.comboBox_lockop.Size = new System.Drawing.Size(112, 20);
            this.comboBox_lockop.TabIndex = 68;
            // 
            // label_txpwr
            // 
            this.label_txpwr.AutoSize = true;
            this.label_txpwr.Font = new System.Drawing.Font("Gulim", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label_txpwr.Location = new System.Drawing.Point(206, 299);
            this.label_txpwr.Name = "label_txpwr";
            this.label_txpwr.Size = new System.Drawing.Size(35, 12);
            this.label_txpwr.TabIndex = 72;
            this.label_txpwr.Text = "MAX";
            // 
            // trackBar_txpwr
            // 
            this.trackBar_txpwr.LargeChange = 10;
            this.trackBar_txpwr.Location = new System.Drawing.Point(7, 311);
            this.trackBar_txpwr.Maximum = 90;
            this.trackBar_txpwr.Name = "trackBar_txpwr";
            this.trackBar_txpwr.Size = new System.Drawing.Size(245, 45);
            this.trackBar_txpwr.TabIndex = 10;
            this.trackBar_txpwr.TickFrequency = 10;
            this.trackBar_txpwr.ValueChanged += new System.EventHandler(this.trackBar_txpwr_ValueChanged);
            // 
            // LockKillForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(264, 368);
            this.Controls.Add(this.label_txpwr);
            this.Controls.Add(this.trackBar_txpwr);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.textBox_killpassword);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.textBox_accesspassword);
            this.Controls.Add(this.groupBox8);
            this.Controls.Add(this.textBox_epc);
            this.Controls.Add(this.checkBox_mask);
            this.Controls.Add(this.checkBox_continue);
            this.Controls.Add(this.radioButton_kill);
            this.Controls.Add(this.radioButton_lock);
            this.Controls.Add(this.pictureBox_status);
            this.Controls.Add(this.label_status);
            this.Controls.Add(this.pictureBox_detect);
            this.Controls.Add(this.label_detect);
            this.Controls.Add(this.pictureBox_link);
            this.Controls.Add(this.label_link);
            this.Controls.Add(this.button_access);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "LockKillForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LockKillForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.LockKillForm_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_status)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_detect)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_link)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_txpwr)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_epc;
        private System.Windows.Forms.CheckBox checkBox_mask;
        private System.Windows.Forms.CheckBox checkBox_continue;
        private System.Windows.Forms.RadioButton radioButton_kill;
        private System.Windows.Forms.RadioButton radioButton_lock;
        private System.Windows.Forms.PictureBox pictureBox_status;
        private System.Windows.Forms.Label label_status;
        private System.Windows.Forms.PictureBox pictureBox_detect;
        private System.Windows.Forms.Label label_detect;
        private System.Windows.Forms.PictureBox pictureBox_link;
        private System.Windows.Forms.Label label_link;
        private System.Windows.Forms.Button button_access;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button_mask;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox textBox_accesspassword;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.TextBox textBox_killpassword;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.ComboBox comboBox_bank;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.ComboBox comboBox_lockop;
        private System.Windows.Forms.Label label_txpwr;
        private System.Windows.Forms.TrackBar trackBar_txpwr;
    }
}