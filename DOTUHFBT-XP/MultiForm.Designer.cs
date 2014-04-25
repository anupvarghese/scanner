namespace DOTUHFBT_XP
{
    partial class MultiForm
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
            this.label_txpower = new System.Windows.Forms.Label();
            this.button_clear = new System.Windows.Forms.Button();
            this.label_txpwr = new System.Windows.Forms.Label();
            this.trackBar_txpwr = new System.Windows.Forms.TrackBar();
            this.button_mask = new System.Windows.Forms.Button();
            this.checkBox_mask = new System.Windows.Forms.CheckBox();
            this.checkBox_continue = new System.Windows.Forms.CheckBox();
            this.label_sec = new System.Windows.Forms.Label();
            this.textBox_scantime = new System.Windows.Forms.TextBox();
            this.label_scantime = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.label_count = new System.Windows.Forms.Label();
            this.pictureBox_link = new System.Windows.Forms.PictureBox();
            this.label_link = new System.Windows.Forms.Label();
            this.button_multi = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_txpwr)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_link)).BeginInit();
            this.SuspendLayout();
            // 
            // label_txpower
            // 
            this.label_txpower.AutoSize = true;
            this.label_txpower.Font = new System.Drawing.Font("Gulim", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label_txpower.Location = new System.Drawing.Point(13, 296);
            this.label_txpower.Name = "label_txpower";
            this.label_txpower.Size = new System.Drawing.Size(68, 12);
            this.label_txpower.TabIndex = 30;
            this.label_txpower.Text = "Tx Power";
            // 
            // button_clear
            // 
            this.button_clear.Font = new System.Drawing.Font("Gulim", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button_clear.Location = new System.Drawing.Point(194, 307);
            this.button_clear.Name = "button_clear";
            this.button_clear.Size = new System.Drawing.Size(58, 49);
            this.button_clear.TabIndex = 29;
            this.button_clear.Text = "CLEAR";
            this.button_clear.UseVisualStyleBackColor = true;
            this.button_clear.Click += new System.EventHandler(this.button_clear_Click);
            // 
            // label_txpwr
            // 
            this.label_txpwr.AutoSize = true;
            this.label_txpwr.Font = new System.Drawing.Font("Gulim", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label_txpwr.Location = new System.Drawing.Point(146, 297);
            this.label_txpwr.Name = "label_txpwr";
            this.label_txpwr.Size = new System.Drawing.Size(35, 12);
            this.label_txpwr.TabIndex = 26;
            this.label_txpwr.Text = "MAX";
            // 
            // trackBar_txpwr
            // 
            this.trackBar_txpwr.LargeChange = 10;
            this.trackBar_txpwr.Location = new System.Drawing.Point(9, 315);
            this.trackBar_txpwr.Maximum = 90;
            this.trackBar_txpwr.Name = "trackBar_txpwr";
            this.trackBar_txpwr.Size = new System.Drawing.Size(179, 45);
            this.trackBar_txpwr.TabIndex = 27;
            this.trackBar_txpwr.TickFrequency = 10;
            this.trackBar_txpwr.ValueChanged += new System.EventHandler(this.trackBar_txpwr_ValueChanged);
            // 
            // button_mask
            // 
            this.button_mask.Font = new System.Drawing.Font("Gulim", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button_mask.Location = new System.Drawing.Point(188, 266);
            this.button_mask.Name = "button_mask";
            this.button_mask.Size = new System.Drawing.Size(64, 23);
            this.button_mask.TabIndex = 28;
            this.button_mask.Text = "MASK";
            this.button_mask.UseVisualStyleBackColor = true;
            this.button_mask.Click += new System.EventHandler(this.button_mask_Click);
            // 
            // checkBox_mask
            // 
            this.checkBox_mask.AutoSize = true;
            this.checkBox_mask.Location = new System.Drawing.Point(167, 271);
            this.checkBox_mask.Name = "checkBox_mask";
            this.checkBox_mask.Size = new System.Drawing.Size(15, 14);
            this.checkBox_mask.TabIndex = 25;
            this.checkBox_mask.UseVisualStyleBackColor = true;
            this.checkBox_mask.CheckedChanged += new System.EventHandler(this.checkBox_mask_CheckedChanged);
            // 
            // checkBox_continue
            // 
            this.checkBox_continue.AutoSize = true;
            this.checkBox_continue.Font = new System.Drawing.Font("Gulim", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.checkBox_continue.Location = new System.Drawing.Point(166, 244);
            this.checkBox_continue.Name = "checkBox_continue";
            this.checkBox_continue.Size = new System.Drawing.Size(82, 16);
            this.checkBox_continue.TabIndex = 24;
            this.checkBox_continue.Text = "Continue";
            this.checkBox_continue.UseVisualStyleBackColor = true;
            this.checkBox_continue.CheckedChanged += new System.EventHandler(this.checkBox_continue_CheckedChanged);
            // 
            // label_sec
            // 
            this.label_sec.AutoSize = true;
            this.label_sec.Font = new System.Drawing.Font("Gulim", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label_sec.Location = new System.Drawing.Point(125, 248);
            this.label_sec.Name = "label_sec";
            this.label_sec.Size = new System.Drawing.Size(25, 12);
            this.label_sec.TabIndex = 23;
            this.label_sec.Text = "(s)";
            // 
            // textBox_scantime
            // 
            this.textBox_scantime.Location = new System.Drawing.Point(95, 241);
            this.textBox_scantime.Name = "textBox_scantime";
            this.textBox_scantime.Size = new System.Drawing.Size(28, 21);
            this.textBox_scantime.TabIndex = 22;
            this.textBox_scantime.TextChanged += new System.EventHandler(this.textBox_scantime_TextChanged);
            // 
            // label_scantime
            // 
            this.label_scantime.AutoSize = true;
            this.label_scantime.Font = new System.Drawing.Font("Gulim", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label_scantime.Location = new System.Drawing.Point(16, 246);
            this.label_scantime.Name = "label_scantime";
            this.label_scantime.Size = new System.Drawing.Size(76, 12);
            this.label_scantime.TabIndex = 21;
            this.label_scantime.Text = "Scan Time";
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.listView1.Location = new System.Drawing.Point(13, 64);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(239, 171);
            this.listView1.TabIndex = 16;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "PC/EPC";
            this.columnHeader1.Width = 190;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "COUNT";
            this.columnHeader2.Width = 47;
            // 
            // label_count
            // 
            this.label_count.AutoSize = true;
            this.label_count.Font = new System.Drawing.Font("Gulim", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label_count.Location = new System.Drawing.Point(224, 23);
            this.label_count.Name = "label_count";
            this.label_count.Size = new System.Drawing.Size(24, 24);
            this.label_count.TabIndex = 20;
            this.label_count.Text = "0";
            this.label_count.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // pictureBox_link
            // 
            this.pictureBox_link.Location = new System.Drawing.Point(20, 30);
            this.pictureBox_link.Name = "pictureBox_link";
            this.pictureBox_link.Size = new System.Drawing.Size(17, 17);
            this.pictureBox_link.TabIndex = 19;
            this.pictureBox_link.TabStop = false;
            // 
            // label_link
            // 
            this.label_link.AutoSize = true;
            this.label_link.Font = new System.Drawing.Font("Gulim", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label_link.Location = new System.Drawing.Point(12, 13);
            this.label_link.Name = "label_link";
            this.label_link.Size = new System.Drawing.Size(36, 12);
            this.label_link.TabIndex = 18;
            this.label_link.Text = "LINK";
            // 
            // button_multi
            // 
            this.button_multi.Font = new System.Drawing.Font("Gulim", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button_multi.Location = new System.Drawing.Point(84, 14);
            this.button_multi.Name = "button_multi";
            this.button_multi.Size = new System.Drawing.Size(89, 37);
            this.button_multi.TabIndex = 17;
            this.button_multi.Text = "MULTI";
            this.button_multi.UseVisualStyleBackColor = true;
            this.button_multi.Click += new System.EventHandler(this.button_normal_Click);
            // 
            // MultiForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(264, 368);
            this.Controls.Add(this.label_txpower);
            this.Controls.Add(this.button_clear);
            this.Controls.Add(this.label_txpwr);
            this.Controls.Add(this.trackBar_txpwr);
            this.Controls.Add(this.button_mask);
            this.Controls.Add(this.checkBox_mask);
            this.Controls.Add(this.checkBox_continue);
            this.Controls.Add(this.label_sec);
            this.Controls.Add(this.textBox_scantime);
            this.Controls.Add(this.label_scantime);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.label_count);
            this.Controls.Add(this.pictureBox_link);
            this.Controls.Add(this.label_link);
            this.Controls.Add(this.button_multi);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "MultiForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Multi Mode";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MultiForm_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_txpwr)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_link)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_txpower;
        private System.Windows.Forms.Button button_clear;
        private System.Windows.Forms.Label label_txpwr;
        private System.Windows.Forms.TrackBar trackBar_txpwr;
        private System.Windows.Forms.Button button_mask;
        private System.Windows.Forms.CheckBox checkBox_mask;
        private System.Windows.Forms.CheckBox checkBox_continue;
        private System.Windows.Forms.Label label_sec;
        private System.Windows.Forms.TextBox textBox_scantime;
        private System.Windows.Forms.Label label_scantime;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.Label label_count;
        private System.Windows.Forms.PictureBox pictureBox_link;
        private System.Windows.Forms.Label label_link;
        private System.Windows.Forms.Button button_multi;
    }
}