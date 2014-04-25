namespace DOTUHFBT_XP
{
    partial class MaskForm
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
            this.radioButton_epcmask = new System.Windows.Forms.RadioButton();
            this.textBox_epcdata = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButton_multimode = new System.Windows.Forms.RadioButton();
            this.comboBox_bank = new System.Windows.Forms.ComboBox();
            this.label_bank = new System.Windows.Forms.Label();
            this.label_offset = new System.Windows.Forms.Label();
            this.textBox_offset = new System.Windows.Forms.TextBox();
            this.label_length = new System.Windows.Forms.Label();
            this.textBox_length = new System.Windows.Forms.TextBox();
            this.textBox_maskdata = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // radioButton_epcmask
            // 
            this.radioButton_epcmask.AutoSize = true;
            this.radioButton_epcmask.Font = new System.Drawing.Font("Gulim", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.radioButton_epcmask.Location = new System.Drawing.Point(6, 25);
            this.radioButton_epcmask.Name = "radioButton_epcmask";
            this.radioButton_epcmask.Size = new System.Drawing.Size(178, 16);
            this.radioButton_epcmask.TabIndex = 0;
            this.radioButton_epcmask.TabStop = true;
            this.radioButton_epcmask.Text = "Select Mask EPC Mode";
            this.radioButton_epcmask.UseVisualStyleBackColor = true;
            // 
            // textBox_epcdata
            // 
            this.textBox_epcdata.Location = new System.Drawing.Point(18, 76);
            this.textBox_epcdata.Name = "textBox_epcdata";
            this.textBox_epcdata.Size = new System.Drawing.Size(228, 21);
            this.textBox_epcdata.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButton_epcmask);
            this.groupBox1.Font = new System.Drawing.Font("Gulim", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.groupBox1.Location = new System.Drawing.Point(12, 24);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(240, 87);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "EPC Mode";
            // 
            // radioButton_multimode
            // 
            this.radioButton_multimode.AutoSize = true;
            this.radioButton_multimode.Font = new System.Drawing.Font("Gulim", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.radioButton_multimode.Location = new System.Drawing.Point(18, 158);
            this.radioButton_multimode.Name = "radioButton_multimode";
            this.radioButton_multimode.Size = new System.Drawing.Size(192, 16);
            this.radioButton_multimode.TabIndex = 3;
            this.radioButton_multimode.TabStop = true;
            this.radioButton_multimode.Text = "Select Mask MULTI Mode";
            this.radioButton_multimode.UseVisualStyleBackColor = true;
            // 
            // comboBox_bank
            // 
            this.comboBox_bank.FormattingEnabled = true;
            this.comboBox_bank.Items.AddRange(new object[] {
            "RESERVED",
            "EPC",
            "TID",
            "USER"});
            this.comboBox_bank.Location = new System.Drawing.Point(74, 190);
            this.comboBox_bank.Name = "comboBox_bank";
            this.comboBox_bank.Size = new System.Drawing.Size(172, 20);
            this.comboBox_bank.TabIndex = 4;
            // 
            // label_bank
            // 
            this.label_bank.AutoSize = true;
            this.label_bank.Font = new System.Drawing.Font("Gulim", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label_bank.Location = new System.Drawing.Point(16, 194);
            this.label_bank.Name = "label_bank";
            this.label_bank.Size = new System.Drawing.Size(52, 12);
            this.label_bank.TabIndex = 5;
            this.label_bank.Text = "BANK :";
            // 
            // label_offset
            // 
            this.label_offset.AutoSize = true;
            this.label_offset.Font = new System.Drawing.Font("Gulim", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label_offset.Location = new System.Drawing.Point(16, 226);
            this.label_offset.Name = "label_offset";
            this.label_offset.Size = new System.Drawing.Size(101, 12);
            this.label_offset.TabIndex = 6;
            this.label_offset.Text = "OFFSET (bit) :";
            // 
            // textBox_offset
            // 
            this.textBox_offset.Location = new System.Drawing.Point(126, 222);
            this.textBox_offset.Name = "textBox_offset";
            this.textBox_offset.Size = new System.Drawing.Size(120, 21);
            this.textBox_offset.TabIndex = 7;
            // 
            // label_length
            // 
            this.label_length.AutoSize = true;
            this.label_length.Font = new System.Drawing.Font("Gulim", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label_length.Location = new System.Drawing.Point(16, 260);
            this.label_length.Name = "label_length";
            this.label_length.Size = new System.Drawing.Size(103, 12);
            this.label_length.TabIndex = 8;
            this.label_length.Text = "LENGTH (bit) :";
            // 
            // textBox_length
            // 
            this.textBox_length.Location = new System.Drawing.Point(126, 256);
            this.textBox_length.Name = "textBox_length";
            this.textBox_length.Size = new System.Drawing.Size(120, 21);
            this.textBox_length.TabIndex = 9;
            // 
            // textBox_maskdata
            // 
            this.textBox_maskdata.Location = new System.Drawing.Point(126, 291);
            this.textBox_maskdata.Name = "textBox_maskdata";
            this.textBox_maskdata.Size = new System.Drawing.Size(120, 21);
            this.textBox_maskdata.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Gulim", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(16, 294);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 12);
            this.label1.TabIndex = 10;
            this.label1.Text = "MASK DATA :";
            // 
            // groupBox2
            // 
            this.groupBox2.Font = new System.Drawing.Font("Gulim", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.groupBox2.Location = new System.Drawing.Point(12, 133);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(240, 191);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "MULTI Mode";
            // 
            // MaskForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(264, 368);
            this.Controls.Add(this.textBox_maskdata);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_length);
            this.Controls.Add(this.label_length);
            this.Controls.Add(this.textBox_offset);
            this.Controls.Add(this.label_offset);
            this.Controls.Add(this.label_bank);
            this.Controls.Add(this.comboBox_bank);
            this.Controls.Add(this.radioButton_multimode);
            this.Controls.Add(this.textBox_epcdata);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "MaskForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MaskForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MaskForm_FormClosing);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton radioButton_epcmask;
        private System.Windows.Forms.TextBox textBox_epcdata;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButton_multimode;
        private System.Windows.Forms.ComboBox comboBox_bank;
        private System.Windows.Forms.Label label_bank;
        private System.Windows.Forms.Label label_offset;
        private System.Windows.Forms.TextBox textBox_offset;
        private System.Windows.Forms.Label label_length;
        private System.Windows.Forms.TextBox textBox_length;
        private System.Windows.Forms.TextBox textBox_maskdata;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}