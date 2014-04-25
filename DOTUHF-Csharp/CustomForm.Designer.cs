namespace DOTUHF_Csharp
{
    partial class CustomForm
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
            this.label_txpower = new System.Windows.Forms.Label();
            this.button_clear = new System.Windows.Forms.Button();
            this.label_txpwr = new System.Windows.Forms.Label();
            this.trackBar_txpwr = new System.Windows.Forms.TrackBar();
            this.button_mask = new System.Windows.Forms.Button();
            this.checkBox_mask = new System.Windows.Forms.CheckBox();
            this.checkBox_continue = new System.Windows.Forms.CheckBox();
            this.textBox_scantime = new System.Windows.Forms.TextBox();
            this.label_scantime = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.label_count = new System.Windows.Forms.Label();
            this.pictureBox_link = new System.Windows.Forms.PictureBox();
            this.label_link = new System.Windows.Forms.Label();
            this.button_custom = new System.Windows.Forms.Button();
            this.label_sec = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label_txpower
            // 
            this.label_txpower.Font = new System.Drawing.Font("Gulim", 9F, System.Drawing.FontStyle.Bold);
            this.label_txpower.Location = new System.Drawing.Point(3, 217);
            this.label_txpower.Name = "label_txpower";
            this.label_txpower.Size = new System.Drawing.Size(68, 12);
            this.label_txpower.Text = "Tx Power";
            // 
            // button_clear
            // 
            this.button_clear.Font = new System.Drawing.Font("Gulim", 9F, System.Drawing.FontStyle.Bold);
            this.button_clear.Location = new System.Drawing.Point(180, 235);
            this.button_clear.Name = "button_clear";
            this.button_clear.Size = new System.Drawing.Size(55, 31);
            this.button_clear.TabIndex = 73;
            this.button_clear.Text = "CLEAR";
            this.button_clear.Click += new System.EventHandler(this.button_clear_Click);
            // 
            // label_txpwr
            // 
            this.label_txpwr.Font = new System.Drawing.Font("Gulim", 9F, System.Drawing.FontStyle.Bold);
            this.label_txpwr.Location = new System.Drawing.Point(108, 217);
            this.label_txpwr.Name = "label_txpwr";
            this.label_txpwr.Size = new System.Drawing.Size(35, 12);
            this.label_txpwr.Text = "MAX";
            // 
            // trackBar_txpwr
            // 
            this.trackBar_txpwr.LargeChange = 10;
            this.trackBar_txpwr.Location = new System.Drawing.Point(0, 232);
            this.trackBar_txpwr.Maximum = 90;
            this.trackBar_txpwr.Name = "trackBar_txpwr";
            this.trackBar_txpwr.Size = new System.Drawing.Size(179, 34);
            this.trackBar_txpwr.TabIndex = 72;
            this.trackBar_txpwr.TickFrequency = 10;
            this.trackBar_txpwr.ValueChanged += new System.EventHandler(this.trackBar_txpwr_ValueChanged);
            // 
            // button_mask
            // 
            this.button_mask.Font = new System.Drawing.Font("Gulim", 9F, System.Drawing.FontStyle.Bold);
            this.button_mask.Location = new System.Drawing.Point(172, 206);
            this.button_mask.Name = "button_mask";
            this.button_mask.Size = new System.Drawing.Size(63, 23);
            this.button_mask.TabIndex = 71;
            this.button_mask.Text = "MASK";
            this.button_mask.Click += new System.EventHandler(this.button_mask_Click);
            // 
            // checkBox_mask
            // 
            this.checkBox_mask.Location = new System.Drawing.Point(149, 209);
            this.checkBox_mask.Name = "checkBox_mask";
            this.checkBox_mask.Size = new System.Drawing.Size(27, 17);
            this.checkBox_mask.TabIndex = 70;
            this.checkBox_mask.CheckStateChanged += new System.EventHandler(this.checkBox_mask_CheckStateChanged);
            // 
            // checkBox_continue
            // 
            this.checkBox_continue.Font = new System.Drawing.Font("Gulim", 9F, System.Drawing.FontStyle.Bold);
            this.checkBox_continue.Location = new System.Drawing.Point(149, 188);
            this.checkBox_continue.Name = "checkBox_continue";
            this.checkBox_continue.Size = new System.Drawing.Size(82, 16);
            this.checkBox_continue.TabIndex = 69;
            this.checkBox_continue.Text = "Continue";
            this.checkBox_continue.CheckStateChanged += new System.EventHandler(this.checkBox_continue_CheckStateChanged);
            // 
            // textBox_scantime
            // 
            this.textBox_scantime.Location = new System.Drawing.Point(79, 185);
            this.textBox_scantime.Name = "textBox_scantime";
            this.textBox_scantime.Size = new System.Drawing.Size(28, 23);
            this.textBox_scantime.TabIndex = 68;
            this.textBox_scantime.TextChanged += new System.EventHandler(this.textBox_scantime_TextChanged);
            // 
            // label_scantime
            // 
            this.label_scantime.Font = new System.Drawing.Font("Gulim", 9F, System.Drawing.FontStyle.Bold);
            this.label_scantime.Location = new System.Drawing.Point(4, 191);
            this.label_scantime.Name = "label_scantime";
            this.label_scantime.Size = new System.Drawing.Size(76, 12);
            this.label_scantime.Text = "Scan Time";
            // 
            // listView1
            // 
            this.listView1.Columns.Add(this.columnHeader1);
            this.listView1.Columns.Add(this.columnHeader2);
            this.listView1.Location = new System.Drawing.Point(0, 39);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(238, 144);
            this.listView1.TabIndex = 67;
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
            this.label_count.Font = new System.Drawing.Font("Gulim", 18F, System.Drawing.FontStyle.Bold);
            this.label_count.Location = new System.Drawing.Point(165, 8);
            this.label_count.Name = "label_count";
            this.label_count.Size = new System.Drawing.Size(66, 24);
            this.label_count.Text = "0";
            this.label_count.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // pictureBox_link
            // 
            this.pictureBox_link.Location = new System.Drawing.Point(10, 17);
            this.pictureBox_link.Name = "pictureBox_link";
            this.pictureBox_link.Size = new System.Drawing.Size(17, 17);
            // 
            // label_link
            // 
            this.label_link.Font = new System.Drawing.Font("Gulim", 9F, System.Drawing.FontStyle.Bold);
            this.label_link.Location = new System.Drawing.Point(2, 2);
            this.label_link.Name = "label_link";
            this.label_link.Size = new System.Drawing.Size(36, 12);
            this.label_link.Text = "LINK";
            // 
            // button_custom
            // 
            this.button_custom.Font = new System.Drawing.Font("Gulim", 9F, System.Drawing.FontStyle.Bold);
            this.button_custom.Location = new System.Drawing.Point(70, 2);
            this.button_custom.Name = "button_custom";
            this.button_custom.Size = new System.Drawing.Size(89, 34);
            this.button_custom.TabIndex = 66;
            this.button_custom.Text = "CUSTOM";
            this.button_custom.Click += new System.EventHandler(this.button_custom_Click);
            // 
            // label_sec
            // 
            this.label_sec.Font = new System.Drawing.Font("Gulim", 9F, System.Drawing.FontStyle.Bold);
            this.label_sec.Location = new System.Drawing.Point(108, 194);
            this.label_sec.Name = "label_sec";
            this.label_sec.Size = new System.Drawing.Size(25, 12);
            this.label_sec.Text = "(s)";
            // 
            // CustomForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(238, 275);
            this.Controls.Add(this.label_txpower);
            this.Controls.Add(this.button_clear);
            this.Controls.Add(this.label_txpwr);
            this.Controls.Add(this.trackBar_txpwr);
            this.Controls.Add(this.button_mask);
            this.Controls.Add(this.checkBox_mask);
            this.Controls.Add(this.checkBox_continue);
            this.Controls.Add(this.textBox_scantime);
            this.Controls.Add(this.label_scantime);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.label_count);
            this.Controls.Add(this.pictureBox_link);
            this.Controls.Add(this.label_link);
            this.Controls.Add(this.button_custom);
            this.Controls.Add(this.label_sec);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "CustomForm";
            this.Text = "CustomForm";
            this.Closing += new System.ComponentModel.CancelEventHandler(this.CustomForm_Closing);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label_txpower;
        private System.Windows.Forms.Button button_clear;
        private System.Windows.Forms.Label label_txpwr;
        private System.Windows.Forms.TrackBar trackBar_txpwr;
        private System.Windows.Forms.Button button_mask;
        private System.Windows.Forms.CheckBox checkBox_mask;
        private System.Windows.Forms.CheckBox checkBox_continue;
        private System.Windows.Forms.TextBox textBox_scantime;
        private System.Windows.Forms.Label label_scantime;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.Label label_count;
        private System.Windows.Forms.PictureBox pictureBox_link;
        private System.Windows.Forms.Label label_link;
        private System.Windows.Forms.Button button_custom;
        private System.Windows.Forms.Label label_sec;
    }
}