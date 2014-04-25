namespace DOTUHFBT_XP
{
    partial class ReadWriteForm
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
            this.button_access = new System.Windows.Forms.Button();
            this.pictureBox_link = new System.Windows.Forms.PictureBox();
            this.label_link = new System.Windows.Forms.Label();
            this.pictureBox_detect = new System.Windows.Forms.PictureBox();
            this.label_detect = new System.Windows.Forms.Label();
            this.pictureBox_status = new System.Windows.Forms.PictureBox();
            this.label_status = new System.Windows.Forms.Label();
            this.radioButton_read = new System.Windows.Forms.RadioButton();
            this.radioButton_write = new System.Windows.Forms.RadioButton();
            this.checkBox_continue = new System.Windows.Forms.CheckBox();
            this.checkBox_mask = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button_mask = new System.Windows.Forms.Button();
            this.textBox_epc = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.comboBox_bank = new System.Windows.Forms.ComboBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.textBox_offset = new System.Windows.Forms.TextBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.textBox_length = new System.Windows.Forms.TextBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.textBox_accesspassword = new System.Windows.Forms.TextBox();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.textBox_write = new System.Windows.Forms.TextBox();
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            this.textBox_writecnt = new System.Windows.Forms.TextBox();
            this.trackBar_txpwr = new System.Windows.Forms.TrackBar();
            this.label_txpwr = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_link)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_detect)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_status)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_txpwr)).BeginInit();
            this.SuspendLayout();
            // 
            // button_access
            // 
            this.button_access.Font = new System.Drawing.Font("Gulim", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button_access.Location = new System.Drawing.Point(4, 3);
            this.button_access.Name = "button_access";
            this.button_access.Size = new System.Drawing.Size(179, 31);
            this.button_access.TabIndex = 0;
            this.button_access.Text = "ACCESS";
            this.button_access.UseVisualStyleBackColor = true;
            this.button_access.Click += new System.EventHandler(this.button_access_Click);
            // 
            // pictureBox_link
            // 
            this.pictureBox_link.Location = new System.Drawing.Point(189, 5);
            this.pictureBox_link.Name = "pictureBox_link";
            this.pictureBox_link.Size = new System.Drawing.Size(17, 17);
            this.pictureBox_link.TabIndex = 36;
            this.pictureBox_link.TabStop = false;
            // 
            // label_link
            // 
            this.label_link.AutoSize = true;
            this.label_link.Font = new System.Drawing.Font("Gulim", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label_link.Location = new System.Drawing.Point(210, 9);
            this.label_link.Name = "label_link";
            this.label_link.Size = new System.Drawing.Size(23, 12);
            this.label_link.TabIndex = 35;
            this.label_link.Text = "On";
            // 
            // pictureBox_detect
            // 
            this.pictureBox_detect.Location = new System.Drawing.Point(189, 27);
            this.pictureBox_detect.Name = "pictureBox_detect";
            this.pictureBox_detect.Size = new System.Drawing.Size(17, 17);
            this.pictureBox_detect.TabIndex = 38;
            this.pictureBox_detect.TabStop = false;
            // 
            // label_detect
            // 
            this.label_detect.AutoSize = true;
            this.label_detect.Font = new System.Drawing.Font("Gulim", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label_detect.Location = new System.Drawing.Point(210, 31);
            this.label_detect.Name = "label_detect";
            this.label_detect.Size = new System.Drawing.Size(46, 12);
            this.label_detect.TabIndex = 37;
            this.label_detect.Text = "Detect";
            // 
            // pictureBox_status
            // 
            this.pictureBox_status.Location = new System.Drawing.Point(189, 50);
            this.pictureBox_status.Name = "pictureBox_status";
            this.pictureBox_status.Size = new System.Drawing.Size(17, 17);
            this.pictureBox_status.TabIndex = 40;
            this.pictureBox_status.TabStop = false;
            this.pictureBox_status.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pictureBox_status_MouseClick);
            // 
            // label_status
            // 
            this.label_status.AutoSize = true;
            this.label_status.Font = new System.Drawing.Font("Gulim", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label_status.Location = new System.Drawing.Point(210, 54);
            this.label_status.Name = "label_status";
            this.label_status.Size = new System.Drawing.Size(46, 12);
            this.label_status.TabIndex = 39;
            this.label_status.Text = "Status";
            // 
            // radioButton_read
            // 
            this.radioButton_read.AutoSize = true;
            this.radioButton_read.Font = new System.Drawing.Font("Gulim", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.radioButton_read.Location = new System.Drawing.Point(13, 54);
            this.radioButton_read.Name = "radioButton_read";
            this.radioButton_read.Size = new System.Drawing.Size(56, 16);
            this.radioButton_read.TabIndex = 41;
            this.radioButton_read.TabStop = true;
            this.radioButton_read.Text = "Read";
            this.radioButton_read.UseVisualStyleBackColor = true;
            // 
            // radioButton_write
            // 
            this.radioButton_write.AutoSize = true;
            this.radioButton_write.Font = new System.Drawing.Font("Gulim", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.radioButton_write.Location = new System.Drawing.Point(13, 74);
            this.radioButton_write.Name = "radioButton_write";
            this.radioButton_write.Size = new System.Drawing.Size(55, 16);
            this.radioButton_write.TabIndex = 42;
            this.radioButton_write.TabStop = true;
            this.radioButton_write.Text = "Write";
            this.radioButton_write.UseVisualStyleBackColor = true;
            // 
            // checkBox_continue
            // 
            this.checkBox_continue.AutoSize = true;
            this.checkBox_continue.Font = new System.Drawing.Font("Gulim", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.checkBox_continue.Location = new System.Drawing.Point(96, 54);
            this.checkBox_continue.Name = "checkBox_continue";
            this.checkBox_continue.Size = new System.Drawing.Size(82, 16);
            this.checkBox_continue.TabIndex = 43;
            this.checkBox_continue.Text = "Continue";
            this.checkBox_continue.UseVisualStyleBackColor = true;
            this.checkBox_continue.CheckedChanged += new System.EventHandler(this.checkBox_continue_CheckedChanged);
            // 
            // checkBox_mask
            // 
            this.checkBox_mask.AutoSize = true;
            this.checkBox_mask.Font = new System.Drawing.Font("Gulim", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.checkBox_mask.Location = new System.Drawing.Point(96, 75);
            this.checkBox_mask.Name = "checkBox_mask";
            this.checkBox_mask.Size = new System.Drawing.Size(15, 14);
            this.checkBox_mask.TabIndex = 44;
            this.checkBox_mask.UseVisualStyleBackColor = true;
            this.checkBox_mask.CheckedChanged += new System.EventHandler(this.checkBox_mask_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Font = new System.Drawing.Font("Gulim", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.groupBox1.Location = new System.Drawing.Point(6, 38);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(75, 56);
            this.groupBox1.TabIndex = 45;
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
            this.groupBox2.TabIndex = 46;
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
            // textBox_epc
            // 
            this.textBox_epc.Location = new System.Drawing.Point(11, 115);
            this.textBox_epc.Name = "textBox_epc";
            this.textBox_epc.Size = new System.Drawing.Size(239, 21);
            this.textBox_epc.TabIndex = 47;
            // 
            // groupBox3
            // 
            this.groupBox3.Font = new System.Drawing.Font("Gulim", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.groupBox3.Location = new System.Drawing.Point(4, 97);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(256, 48);
            this.groupBox3.TabIndex = 48;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "EPC";
            // 
            // comboBox_bank
            // 
            this.comboBox_bank.FormattingEnabled = true;
            this.comboBox_bank.Items.AddRange(new object[] {
            "RESERVED",
            "EPC",
            "TID",
            "USER"});
            this.comboBox_bank.Location = new System.Drawing.Point(10, 168);
            this.comboBox_bank.Name = "comboBox_bank";
            this.comboBox_bank.Size = new System.Drawing.Size(105, 20);
            this.comboBox_bank.TabIndex = 49;
            this.comboBox_bank.SelectedIndexChanged += new System.EventHandler(this.comboBox_bank_SelectedIndexChanged);
            // 
            // groupBox4
            // 
            this.groupBox4.Font = new System.Drawing.Font("Gulim", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.groupBox4.Location = new System.Drawing.Point(4, 150);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(117, 99);
            this.groupBox4.TabIndex = 50;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Bank";
            // 
            // textBox_offset
            // 
            this.textBox_offset.Location = new System.Drawing.Point(133, 168);
            this.textBox_offset.Name = "textBox_offset";
            this.textBox_offset.Size = new System.Drawing.Size(53, 21);
            this.textBox_offset.TabIndex = 51;
            // 
            // groupBox5
            // 
            this.groupBox5.Font = new System.Drawing.Font("Gulim", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.groupBox5.Location = new System.Drawing.Point(127, 150);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(65, 46);
            this.groupBox5.TabIndex = 52;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Start";
            // 
            // textBox_length
            // 
            this.textBox_length.Location = new System.Drawing.Point(203, 168);
            this.textBox_length.Name = "textBox_length";
            this.textBox_length.Size = new System.Drawing.Size(52, 21);
            this.textBox_length.TabIndex = 53;
            // 
            // groupBox6
            // 
            this.groupBox6.Font = new System.Drawing.Font("Gulim", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.groupBox6.Location = new System.Drawing.Point(197, 150);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(64, 46);
            this.groupBox6.TabIndex = 54;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Length";
            // 
            // textBox_accesspassword
            // 
            this.textBox_accesspassword.Location = new System.Drawing.Point(134, 221);
            this.textBox_accesspassword.Name = "textBox_accesspassword";
            this.textBox_accesspassword.Size = new System.Drawing.Size(122, 21);
            this.textBox_accesspassword.TabIndex = 55;
            // 
            // groupBox8
            // 
            this.groupBox8.Font = new System.Drawing.Font("Gulim", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.groupBox8.Location = new System.Drawing.Point(127, 203);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(134, 46);
            this.groupBox8.TabIndex = 56;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "Access pwd";
            // 
            // textBox_write
            // 
            this.textBox_write.Location = new System.Drawing.Point(11, 269);
            this.textBox_write.Name = "textBox_write";
            this.textBox_write.Size = new System.Drawing.Size(203, 21);
            this.textBox_write.TabIndex = 57;
            // 
            // groupBox9
            // 
            this.groupBox9.Controls.Add(this.textBox_writecnt);
            this.groupBox9.Font = new System.Drawing.Font("Gulim", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.groupBox9.Location = new System.Drawing.Point(4, 253);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.Size = new System.Drawing.Size(257, 43);
            this.groupBox9.TabIndex = 58;
            this.groupBox9.TabStop = false;
            this.groupBox9.Text = "Write";
            // 
            // textBox_writecnt
            // 
            this.textBox_writecnt.Location = new System.Drawing.Point(216, 16);
            this.textBox_writecnt.Name = "textBox_writecnt";
            this.textBox_writecnt.Size = new System.Drawing.Size(35, 21);
            this.textBox_writecnt.TabIndex = 59;
            // 
            // trackBar_txpwr
            // 
            this.trackBar_txpwr.LargeChange = 10;
            this.trackBar_txpwr.Location = new System.Drawing.Point(10, 319);
            this.trackBar_txpwr.Maximum = 90;
            this.trackBar_txpwr.Name = "trackBar_txpwr";
            this.trackBar_txpwr.Size = new System.Drawing.Size(245, 45);
            this.trackBar_txpwr.TabIndex = 10;
            this.trackBar_txpwr.TickFrequency = 10;
            this.trackBar_txpwr.ValueChanged += new System.EventHandler(this.trackBar_txpwr_ValueChanged);
            // 
            // label_txpwr
            // 
            this.label_txpwr.AutoSize = true;
            this.label_txpwr.Font = new System.Drawing.Font("Gulim", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label_txpwr.Location = new System.Drawing.Point(209, 307);
            this.label_txpwr.Name = "label_txpwr";
            this.label_txpwr.Size = new System.Drawing.Size(35, 12);
            this.label_txpwr.TabIndex = 60;
            this.label_txpwr.Text = "MAX";
            // 
            // ReadWriteForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(264, 368);
            this.Controls.Add(this.label_txpwr);
            this.Controls.Add(this.trackBar_txpwr);
            this.Controls.Add(this.textBox_write);
            this.Controls.Add(this.textBox_accesspassword);
            this.Controls.Add(this.textBox_length);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.textBox_offset);
            this.Controls.Add(this.comboBox_bank);
            this.Controls.Add(this.textBox_epc);
            this.Controls.Add(this.checkBox_mask);
            this.Controls.Add(this.checkBox_continue);
            this.Controls.Add(this.radioButton_write);
            this.Controls.Add(this.radioButton_read);
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
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox8);
            this.Controls.Add(this.groupBox9);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "ReadWriteForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ReadWriteForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ReadWriteForm_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_link)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_detect)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_status)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox9.ResumeLayout(false);
            this.groupBox9.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_txpwr)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_access;
        private System.Windows.Forms.PictureBox pictureBox_link;
        private System.Windows.Forms.Label label_link;
        private System.Windows.Forms.PictureBox pictureBox_detect;
        private System.Windows.Forms.Label label_detect;
        private System.Windows.Forms.PictureBox pictureBox_status;
        private System.Windows.Forms.Label label_status;
        private System.Windows.Forms.RadioButton radioButton_read;
        private System.Windows.Forms.RadioButton radioButton_write;
        private System.Windows.Forms.CheckBox checkBox_continue;
        private System.Windows.Forms.CheckBox checkBox_mask;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox textBox_epc;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox comboBox_bank;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox textBox_offset;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.TextBox textBox_length;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.TextBox textBox_accesspassword;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.TextBox textBox_write;
        private System.Windows.Forms.GroupBox groupBox9;
        private System.Windows.Forms.TextBox textBox_writecnt;
        private System.Windows.Forms.TrackBar trackBar_txpwr;
        private System.Windows.Forms.Label label_txpwr;
        private System.Windows.Forms.Button button_mask;
    }
}