namespace DOTUHF_Csharp
{
    partial class LockKillForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.MainMenu mainMenu1;

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
            this.mainMenu1 = new System.Windows.Forms.MainMenu();
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
            this.button_mask = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox_lockop = new System.Windows.Forms.ComboBox();
            this.textBox_killpassword = new System.Windows.Forms.TextBox();
            this.textBox_accesspassword = new System.Windows.Forms.TextBox();
            this.comboBox_bank = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label_txpwr = new System.Windows.Forms.Label();
            this.trackBar_txpwr = new System.Windows.Forms.TrackBar();
            this.SuspendLayout();
            // 
            // textBox_epc
            // 
            this.textBox_epc.Location = new System.Drawing.Point(8, 84);
            this.textBox_epc.Name = "textBox_epc";
            this.textBox_epc.Size = new System.Drawing.Size(228, 23);
            this.textBox_epc.TabIndex = 86;
            // 
            // checkBox_mask
            // 
            this.checkBox_mask.Font = new System.Drawing.Font("Gulim", 9F, System.Drawing.FontStyle.Bold);
            this.checkBox_mask.Location = new System.Drawing.Point(79, 46);
            this.checkBox_mask.Name = "checkBox_mask";
            this.checkBox_mask.Size = new System.Drawing.Size(24, 22);
            this.checkBox_mask.TabIndex = 85;
            this.checkBox_mask.CheckStateChanged += new System.EventHandler(this.checkBox_mask_CheckStateChanged);
            // 
            // checkBox_continue
            // 
            this.checkBox_continue.Font = new System.Drawing.Font("Gulim", 9F, System.Drawing.FontStyle.Bold);
            this.checkBox_continue.Location = new System.Drawing.Point(79, 27);
            this.checkBox_continue.Name = "checkBox_continue";
            this.checkBox_continue.Size = new System.Drawing.Size(82, 16);
            this.checkBox_continue.TabIndex = 84;
            this.checkBox_continue.Text = "Continue";
            this.checkBox_continue.CheckStateChanged += new System.EventHandler(this.checkBox_continue_CheckStateChanged);
            // 
            // radioButton_kill
            // 
            this.radioButton_kill.Font = new System.Drawing.Font("Gulim", 9F, System.Drawing.FontStyle.Bold);
            this.radioButton_kill.Location = new System.Drawing.Point(7, 48);
            this.radioButton_kill.Name = "radioButton_kill";
            this.radioButton_kill.Size = new System.Drawing.Size(55, 16);
            this.radioButton_kill.TabIndex = 83;
            this.radioButton_kill.Text = "Kill";
            // 
            // radioButton_lock
            // 
            this.radioButton_lock.Font = new System.Drawing.Font("Gulim", 9F, System.Drawing.FontStyle.Bold);
            this.radioButton_lock.Location = new System.Drawing.Point(7, 28);
            this.radioButton_lock.Name = "radioButton_lock";
            this.radioButton_lock.Size = new System.Drawing.Size(56, 16);
            this.radioButton_lock.TabIndex = 82;
            this.radioButton_lock.Text = "Lock";
            // 
            // pictureBox_status
            // 
            this.pictureBox_status.Location = new System.Drawing.Point(169, 51);
            this.pictureBox_status.Name = "pictureBox_status";
            this.pictureBox_status.Size = new System.Drawing.Size(17, 13);
            // 
            // label_status
            // 
            this.label_status.Font = new System.Drawing.Font("Gulim", 9F, System.Drawing.FontStyle.Bold);
            this.label_status.Location = new System.Drawing.Point(190, 53);
            this.label_status.Name = "label_status";
            this.label_status.Size = new System.Drawing.Size(46, 10);
            this.label_status.Text = "Status";
            // 
            // pictureBox_detect
            // 
            this.pictureBox_detect.Location = new System.Drawing.Point(169, 28);
            this.pictureBox_detect.Name = "pictureBox_detect";
            this.pictureBox_detect.Size = new System.Drawing.Size(17, 13);
            // 
            // label_detect
            // 
            this.label_detect.Font = new System.Drawing.Font("Gulim", 9F, System.Drawing.FontStyle.Bold);
            this.label_detect.Location = new System.Drawing.Point(190, 30);
            this.label_detect.Name = "label_detect";
            this.label_detect.Size = new System.Drawing.Size(46, 10);
            this.label_detect.Text = "Detect";
            // 
            // pictureBox_link
            // 
            this.pictureBox_link.Location = new System.Drawing.Point(169, 6);
            this.pictureBox_link.Name = "pictureBox_link";
            this.pictureBox_link.Size = new System.Drawing.Size(17, 13);
            // 
            // label_link
            // 
            this.label_link.Font = new System.Drawing.Font("Gulim", 9F, System.Drawing.FontStyle.Bold);
            this.label_link.Location = new System.Drawing.Point(190, 8);
            this.label_link.Name = "label_link";
            this.label_link.Size = new System.Drawing.Size(23, 10);
            this.label_link.Text = "On";
            // 
            // button_access
            // 
            this.button_access.Font = new System.Drawing.Font("Gulim", 9F, System.Drawing.FontStyle.Bold);
            this.button_access.Location = new System.Drawing.Point(3, 2);
            this.button_access.Name = "button_access";
            this.button_access.Size = new System.Drawing.Size(160, 22);
            this.button_access.TabIndex = 81;
            this.button_access.Text = "ACCESS";
            this.button_access.Click += new System.EventHandler(this.button_access_Click);
            // 
            // button_mask
            // 
            this.button_mask.Location = new System.Drawing.Point(104, 45);
            this.button_mask.Name = "button_mask";
            this.button_mask.Size = new System.Drawing.Size(59, 20);
            this.button_mask.TabIndex = 80;
            this.button_mask.Text = "MASK";
            this.button_mask.Click += new System.EventHandler(this.button_mask_Click);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(7, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 20);
            this.label1.Text = "Access Tag EPC :";
            // 
            // comboBox_lockop
            // 
            this.comboBox_lockop.Items.Add("skip");
            this.comboBox_lockop.Items.Add("accessible");
            this.comboBox_lockop.Items.Add("secured accessible");
            this.comboBox_lockop.Items.Add("perm. accessible");
            this.comboBox_lockop.Items.Add("perm. inaccessibe");
            this.comboBox_lockop.Location = new System.Drawing.Point(113, 188);
            this.comboBox_lockop.Name = "comboBox_lockop";
            this.comboBox_lockop.Size = new System.Drawing.Size(123, 23);
            this.comboBox_lockop.TabIndex = 97;
            // 
            // textBox_killpassword
            // 
            this.textBox_killpassword.Location = new System.Drawing.Point(7, 134);
            this.textBox_killpassword.Name = "textBox_killpassword";
            this.textBox_killpassword.Size = new System.Drawing.Size(111, 23);
            this.textBox_killpassword.TabIndex = 95;
            // 
            // textBox_accesspassword
            // 
            this.textBox_accesspassword.Location = new System.Drawing.Point(123, 134);
            this.textBox_accesspassword.Name = "textBox_accesspassword";
            this.textBox_accesspassword.Size = new System.Drawing.Size(112, 23);
            this.textBox_accesspassword.TabIndex = 94;
            // 
            // comboBox_bank
            // 
            this.comboBox_bank.Items.Add("Kill PWD");
            this.comboBox_bank.Items.Add("Access PWD");
            this.comboBox_bank.Items.Add("EPC");
            this.comboBox_bank.Items.Add("TID");
            this.comboBox_bank.Items.Add("USER");
            this.comboBox_bank.Location = new System.Drawing.Point(8, 188);
            this.comboBox_bank.Name = "comboBox_bank";
            this.comboBox_bank.Size = new System.Drawing.Size(98, 23);
            this.comboBox_bank.TabIndex = 96;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(7, 171);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 20);
            this.label2.Text = "Tag Bank :";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(113, 171);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 20);
            this.label3.Text = "Lock Op.";
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(8, 117);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 20);
            this.label4.Text = "Kill password :";
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(121, 117);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(117, 20);
            this.label5.Text = "Access password :";
            // 
            // label_txpwr
            // 
            this.label_txpwr.Font = new System.Drawing.Font("Gulim", 9F, System.Drawing.FontStyle.Bold);
            this.label_txpwr.Location = new System.Drawing.Point(199, 238);
            this.label_txpwr.Name = "label_txpwr";
            this.label_txpwr.Size = new System.Drawing.Size(35, 12);
            this.label_txpwr.Text = "MAX";
            // 
            // trackBar_txpwr
            // 
            this.trackBar_txpwr.LargeChange = 10;
            this.trackBar_txpwr.Location = new System.Drawing.Point(6, 229);
            this.trackBar_txpwr.Maximum = 90;
            this.trackBar_txpwr.Name = "trackBar_txpwr";
            this.trackBar_txpwr.Size = new System.Drawing.Size(187, 32);
            this.trackBar_txpwr.TabIndex = 107;
            this.trackBar_txpwr.TickFrequency = 10;
            this.trackBar_txpwr.ValueChanged += new System.EventHandler(this.trackBar_txpwr_ValueChanged);
            // 
            // LockKillForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(238, 275);
            this.Controls.Add(this.label_txpwr);
            this.Controls.Add(this.trackBar_txpwr);
            this.Controls.Add(this.comboBox_lockop);
            this.Controls.Add(this.textBox_killpassword);
            this.Controls.Add(this.textBox_accesspassword);
            this.Controls.Add(this.comboBox_bank);
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
            this.Controls.Add(this.button_mask);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "LockKillForm";
            this.Text = "LockKillForm";
            this.Closing += new System.ComponentModel.CancelEventHandler(this.LockKillForm_Closing);
            this.ResumeLayout(false);

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
        private System.Windows.Forms.Button button_mask;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox_lockop;
        private System.Windows.Forms.TextBox textBox_killpassword;
        private System.Windows.Forms.TextBox textBox_accesspassword;
        private System.Windows.Forms.ComboBox comboBox_bank;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label_txpwr;
        private System.Windows.Forms.TrackBar trackBar_txpwr;
    }
}