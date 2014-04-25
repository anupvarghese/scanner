namespace DOTUHF_Csharp
{
    partial class ReadWriteForm
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
            this.label_txpwr = new System.Windows.Forms.Label();
            this.trackBar_txpwr = new System.Windows.Forms.TrackBar();
            this.textBox_write = new System.Windows.Forms.TextBox();
            this.textBox_accesspassword = new System.Windows.Forms.TextBox();
            this.textBox_length = new System.Windows.Forms.TextBox();
            this.textBox_offset = new System.Windows.Forms.TextBox();
            this.comboBox_bank = new System.Windows.Forms.ComboBox();
            this.textBox_epc = new System.Windows.Forms.TextBox();
            this.checkBox_mask = new System.Windows.Forms.CheckBox();
            this.checkBox_continue = new System.Windows.Forms.CheckBox();
            this.radioButton_write = new System.Windows.Forms.RadioButton();
            this.radioButton_read = new System.Windows.Forms.RadioButton();
            this.pictureBox_status = new System.Windows.Forms.PictureBox();
            this.label_status = new System.Windows.Forms.Label();
            this.pictureBox_detect = new System.Windows.Forms.PictureBox();
            this.label_detect = new System.Windows.Forms.Label();
            this.pictureBox_link = new System.Windows.Forms.PictureBox();
            this.label_link = new System.Windows.Forms.Label();
            this.button_access = new System.Windows.Forms.Button();
            this.button_mask = new System.Windows.Forms.Button();
            this.textBox_writecnt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label_txpwr
            // 
            this.label_txpwr.Font = new System.Drawing.Font("Gulim", 9F, System.Drawing.FontStyle.Bold);
            this.label_txpwr.Location = new System.Drawing.Point(198, 244);
            this.label_txpwr.Name = "label_txpwr";
            this.label_txpwr.Size = new System.Drawing.Size(35, 12);
            this.label_txpwr.Text = "MAX";
            // 
            // trackBar_txpwr
            // 
            this.trackBar_txpwr.LargeChange = 10;
            this.trackBar_txpwr.Location = new System.Drawing.Point(5, 235);
            this.trackBar_txpwr.Maximum = 90;
            this.trackBar_txpwr.Name = "trackBar_txpwr";
            this.trackBar_txpwr.Size = new System.Drawing.Size(187, 32);
            this.trackBar_txpwr.TabIndex = 67;
            this.trackBar_txpwr.TickFrequency = 10;
            this.trackBar_txpwr.ValueChanged += new System.EventHandler(this.trackBar_txpwr_ValueChanged);
            // 
            // textBox_write
            // 
            this.textBox_write.Location = new System.Drawing.Point(5, 206);
            this.textBox_write.Name = "textBox_write";
            this.textBox_write.Size = new System.Drawing.Size(187, 23);
            this.textBox_write.TabIndex = 77;
            // 
            // textBox_accesspassword
            // 
            this.textBox_accesspassword.Location = new System.Drawing.Point(110, 168);
            this.textBox_accesspassword.Name = "textBox_accesspassword";
            this.textBox_accesspassword.Size = new System.Drawing.Size(123, 23);
            this.textBox_accesspassword.TabIndex = 76;
            // 
            // textBox_length
            // 
            this.textBox_length.Location = new System.Drawing.Point(177, 128);
            this.textBox_length.Name = "textBox_length";
            this.textBox_length.Size = new System.Drawing.Size(56, 23);
            this.textBox_length.TabIndex = 75;
            // 
            // textBox_offset
            // 
            this.textBox_offset.Location = new System.Drawing.Point(110, 128);
            this.textBox_offset.Name = "textBox_offset";
            this.textBox_offset.Size = new System.Drawing.Size(61, 23);
            this.textBox_offset.TabIndex = 74;
            // 
            // comboBox_bank
            // 
            this.comboBox_bank.Items.Add("RESERVED");
            this.comboBox_bank.Items.Add("EPC");
            this.comboBox_bank.Items.Add("TID");
            this.comboBox_bank.Items.Add("USER");
            this.comboBox_bank.Location = new System.Drawing.Point(5, 128);
            this.comboBox_bank.Name = "comboBox_bank";
            this.comboBox_bank.Size = new System.Drawing.Size(99, 23);
            this.comboBox_bank.TabIndex = 73;
            // 
            // textBox_epc
            // 
            this.textBox_epc.Location = new System.Drawing.Point(5, 85);
            this.textBox_epc.Name = "textBox_epc";
            this.textBox_epc.Size = new System.Drawing.Size(228, 23);
            this.textBox_epc.TabIndex = 72;
            // 
            // checkBox_mask
            // 
            this.checkBox_mask.Font = new System.Drawing.Font("Gulim", 9F, System.Drawing.FontStyle.Bold);
            this.checkBox_mask.Location = new System.Drawing.Point(76, 47);
            this.checkBox_mask.Name = "checkBox_mask";
            this.checkBox_mask.Size = new System.Drawing.Size(24, 20);
            this.checkBox_mask.TabIndex = 71;
            this.checkBox_mask.CheckStateChanged += new System.EventHandler(this.checkBox_mask_CheckStateChanged);
            // 
            // checkBox_continue
            // 
            this.checkBox_continue.Font = new System.Drawing.Font("Gulim", 9F, System.Drawing.FontStyle.Bold);
            this.checkBox_continue.Location = new System.Drawing.Point(76, 28);
            this.checkBox_continue.Name = "checkBox_continue";
            this.checkBox_continue.Size = new System.Drawing.Size(82, 16);
            this.checkBox_continue.TabIndex = 70;
            this.checkBox_continue.Text = "Continue";
            this.checkBox_continue.CheckStateChanged += new System.EventHandler(this.checkBox_continue_CheckStateChanged);
            // 
            // radioButton_write
            // 
            this.radioButton_write.Font = new System.Drawing.Font("Gulim", 9F, System.Drawing.FontStyle.Bold);
            this.radioButton_write.Location = new System.Drawing.Point(4, 49);
            this.radioButton_write.Name = "radioButton_write";
            this.radioButton_write.Size = new System.Drawing.Size(55, 16);
            this.radioButton_write.TabIndex = 69;
            this.radioButton_write.Text = "Write";
            // 
            // radioButton_read
            // 
            this.radioButton_read.Font = new System.Drawing.Font("Gulim", 9F, System.Drawing.FontStyle.Bold);
            this.radioButton_read.Location = new System.Drawing.Point(4, 29);
            this.radioButton_read.Name = "radioButton_read";
            this.radioButton_read.Size = new System.Drawing.Size(56, 16);
            this.radioButton_read.TabIndex = 68;
            this.radioButton_read.Text = "Read";
            // 
            // pictureBox_status
            // 
            this.pictureBox_status.Location = new System.Drawing.Point(166, 52);
            this.pictureBox_status.Name = "pictureBox_status";
            this.pictureBox_status.Size = new System.Drawing.Size(17, 13);
            // 
            // label_status
            // 
            this.label_status.Font = new System.Drawing.Font("Gulim", 9F, System.Drawing.FontStyle.Bold);
            this.label_status.Location = new System.Drawing.Point(187, 54);
            this.label_status.Name = "label_status";
            this.label_status.Size = new System.Drawing.Size(46, 10);
            this.label_status.Text = "Status";
            // 
            // pictureBox_detect
            // 
            this.pictureBox_detect.Location = new System.Drawing.Point(166, 29);
            this.pictureBox_detect.Name = "pictureBox_detect";
            this.pictureBox_detect.Size = new System.Drawing.Size(17, 13);
            // 
            // label_detect
            // 
            this.label_detect.Font = new System.Drawing.Font("Gulim", 9F, System.Drawing.FontStyle.Bold);
            this.label_detect.Location = new System.Drawing.Point(187, 31);
            this.label_detect.Name = "label_detect";
            this.label_detect.Size = new System.Drawing.Size(46, 10);
            this.label_detect.Text = "Detect";
            // 
            // pictureBox_link
            // 
            this.pictureBox_link.Location = new System.Drawing.Point(166, 7);
            this.pictureBox_link.Name = "pictureBox_link";
            this.pictureBox_link.Size = new System.Drawing.Size(17, 13);
            // 
            // label_link
            // 
            this.label_link.Font = new System.Drawing.Font("Gulim", 9F, System.Drawing.FontStyle.Bold);
            this.label_link.Location = new System.Drawing.Point(187, 9);
            this.label_link.Name = "label_link";
            this.label_link.Size = new System.Drawing.Size(23, 10);
            this.label_link.Text = "On";
            // 
            // button_access
            // 
            this.button_access.Font = new System.Drawing.Font("Gulim", 9F, System.Drawing.FontStyle.Bold);
            this.button_access.Location = new System.Drawing.Point(0, 3);
            this.button_access.Name = "button_access";
            this.button_access.Size = new System.Drawing.Size(160, 22);
            this.button_access.TabIndex = 65;
            this.button_access.Text = "ACCESS";
            this.button_access.Click += new System.EventHandler(this.button_access_Click);
            // 
            // button_mask
            // 
            this.button_mask.Location = new System.Drawing.Point(101, 46);
            this.button_mask.Name = "button_mask";
            this.button_mask.Size = new System.Drawing.Size(59, 20);
            this.button_mask.TabIndex = 64;
            this.button_mask.Text = "MASK";
            this.button_mask.Click += new System.EventHandler(this.button_mask_Click);
            // 
            // textBox_writecnt
            // 
            this.textBox_writecnt.Location = new System.Drawing.Point(198, 206);
            this.textBox_writecnt.Name = "textBox_writecnt";
            this.textBox_writecnt.Size = new System.Drawing.Size(35, 23);
            this.textBox_writecnt.TabIndex = 79;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(4, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 20);
            this.label1.Text = "Access Tag EPC :";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(4, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 20);
            this.label2.Text = "Tag Bank :";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(115, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 20);
            this.label3.Text = "Offset :";
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(182, 109);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 20);
            this.label4.Text = "Length :";
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(117, 151);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(116, 20);
            this.label5.Text = "Access Password :";
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(5, 189);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(116, 20);
            this.label6.Text = "Access Data :";
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(200, 190);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 20);
            this.label7.Text = "Len.";
            // 
            // ReadWriteForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(238, 275);
            this.Controls.Add(this.label_txpwr);
            this.Controls.Add(this.trackBar_txpwr);
            this.Controls.Add(this.textBox_write);
            this.Controls.Add(this.textBox_accesspassword);
            this.Controls.Add(this.textBox_length);
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
            this.Controls.Add(this.button_mask);
            this.Controls.Add(this.textBox_writecnt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "ReadWriteForm";
            this.Text = "ReadWriteForm";
            this.Closing += new System.ComponentModel.CancelEventHandler(this.ReadWriteForm_Closing);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label_txpwr;
        private System.Windows.Forms.TrackBar trackBar_txpwr;
        private System.Windows.Forms.TextBox textBox_write;
        private System.Windows.Forms.TextBox textBox_accesspassword;
        private System.Windows.Forms.TextBox textBox_length;
        private System.Windows.Forms.TextBox textBox_offset;
        private System.Windows.Forms.ComboBox comboBox_bank;
        private System.Windows.Forms.TextBox textBox_epc;
        private System.Windows.Forms.CheckBox checkBox_mask;
        private System.Windows.Forms.CheckBox checkBox_continue;
        private System.Windows.Forms.RadioButton radioButton_write;
        private System.Windows.Forms.RadioButton radioButton_read;
        private System.Windows.Forms.PictureBox pictureBox_status;
        private System.Windows.Forms.Label label_status;
        private System.Windows.Forms.PictureBox pictureBox_detect;
        private System.Windows.Forms.Label label_detect;
        private System.Windows.Forms.PictureBox pictureBox_link;
        private System.Windows.Forms.Label label_link;
        private System.Windows.Forms.Button button_access;
        private System.Windows.Forms.Button button_mask;
        private System.Windows.Forms.TextBox textBox_writecnt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}