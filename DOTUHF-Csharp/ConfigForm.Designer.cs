namespace DOTUHF_Csharp
{
    partial class ConfigForm
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
            this.textBox_appversion = new System.Windows.Forms.TextBox();
            this.textBox_firmwarever = new System.Windows.Forms.TextBox();
            this.label_appversion = new System.Windows.Forms.Label();
            this.label_firmwarever = new System.Windows.Forms.Label();
            this.label_duty = new System.Windows.Forms.Label();
            this.trackBar_duty = new System.Windows.Forms.TrackBar();
            this.label_txpwr = new System.Windows.Forms.Label();
            this.trackBar_txpwr = new System.Windows.Forms.TrackBar();
            this.textBox_scantime = new System.Windows.Forms.TextBox();
            this.label_scantime = new System.Windows.Forms.Label();
            this.comboBox_q = new System.Windows.Forms.ComboBox();
            this.checkBox_skipsame = new System.Windows.Forms.CheckBox();
            this.comboBox_target = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox_session = new System.Windows.Forms.ComboBox();
            this.checkBox_continue = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // textBox_appversion
            // 
            this.textBox_appversion.Location = new System.Drawing.Point(131, 233);
            this.textBox_appversion.Name = "textBox_appversion";
            this.textBox_appversion.Size = new System.Drawing.Size(101, 23);
            this.textBox_appversion.TabIndex = 100;
            // 
            // textBox_firmwarever
            // 
            this.textBox_firmwarever.Location = new System.Drawing.Point(131, 204);
            this.textBox_firmwarever.Name = "textBox_firmwarever";
            this.textBox_firmwarever.Size = new System.Drawing.Size(101, 23);
            this.textBox_firmwarever.TabIndex = 99;
            // 
            // label_appversion
            // 
            this.label_appversion.Font = new System.Drawing.Font("Gulim", 9F, System.Drawing.FontStyle.Bold);
            this.label_appversion.Location = new System.Drawing.Point(31, 238);
            this.label_appversion.Name = "label_appversion";
            this.label_appversion.Size = new System.Drawing.Size(100, 12);
            this.label_appversion.Text = "App. Version :";
            // 
            // label_firmwarever
            // 
            this.label_firmwarever.Font = new System.Drawing.Font("Gulim", 9F, System.Drawing.FontStyle.Bold);
            this.label_firmwarever.Location = new System.Drawing.Point(4, 211);
            this.label_firmwarever.Name = "label_firmwarever";
            this.label_firmwarever.Size = new System.Drawing.Size(131, 12);
            this.label_firmwarever.Text = "Firmware Version :";
            // 
            // label_duty
            // 
            this.label_duty.Font = new System.Drawing.Font("Gulim", 9F, System.Drawing.FontStyle.Bold);
            this.label_duty.Location = new System.Drawing.Point(187, 145);
            this.label_duty.Name = "label_duty";
            this.label_duty.Size = new System.Drawing.Size(35, 12);
            this.label_duty.Text = "MAX";
            // 
            // trackBar_duty
            // 
            this.trackBar_duty.LargeChange = 10;
            this.trackBar_duty.Location = new System.Drawing.Point(4, 160);
            this.trackBar_duty.Maximum = 40;
            this.trackBar_duty.Name = "trackBar_duty";
            this.trackBar_duty.Size = new System.Drawing.Size(228, 28);
            this.trackBar_duty.TabIndex = 98;
            this.trackBar_duty.TickFrequency = 10;
            this.trackBar_duty.ValueChanged += new System.EventHandler(this.trackBar_duty_ValueChanged);
            // 
            // label_txpwr
            // 
            this.label_txpwr.Font = new System.Drawing.Font("Gulim", 9F, System.Drawing.FontStyle.Bold);
            this.label_txpwr.Location = new System.Drawing.Point(187, 86);
            this.label_txpwr.Name = "label_txpwr";
            this.label_txpwr.Size = new System.Drawing.Size(35, 12);
            this.label_txpwr.Text = "MAX";
            // 
            // trackBar_txpwr
            // 
            this.trackBar_txpwr.LargeChange = 10;
            this.trackBar_txpwr.Location = new System.Drawing.Point(4, 101);
            this.trackBar_txpwr.Maximum = 90;
            this.trackBar_txpwr.Name = "trackBar_txpwr";
            this.trackBar_txpwr.Size = new System.Drawing.Size(228, 29);
            this.trackBar_txpwr.TabIndex = 97;
            this.trackBar_txpwr.TickFrequency = 10;
            this.trackBar_txpwr.ValueChanged += new System.EventHandler(this.trackBar_txpwr_ValueChanged);
            // 
            // textBox_scantime
            // 
            this.textBox_scantime.Location = new System.Drawing.Point(55, 50);
            this.textBox_scantime.Name = "textBox_scantime";
            this.textBox_scantime.Size = new System.Drawing.Size(37, 23);
            this.textBox_scantime.TabIndex = 93;
            // 
            // label_scantime
            // 
            this.label_scantime.Font = new System.Drawing.Font("Gulim", 9F, System.Drawing.FontStyle.Bold);
            this.label_scantime.Location = new System.Drawing.Point(4, 56);
            this.label_scantime.Name = "label_scantime";
            this.label_scantime.Size = new System.Drawing.Size(48, 17);
            this.label_scantime.Text = "Time :";
            // 
            // comboBox_q
            // 
            this.comboBox_q.Items.Add("   0");
            this.comboBox_q.Items.Add("~ 1 ");
            this.comboBox_q.Items.Add("~ 2");
            this.comboBox_q.Items.Add("~ 3");
            this.comboBox_q.Items.Add("~ 4");
            this.comboBox_q.Items.Add("~ 5");
            this.comboBox_q.Items.Add("~ 6");
            this.comboBox_q.Items.Add("~ 7");
            this.comboBox_q.Items.Add("~ 8");
            this.comboBox_q.Items.Add("~ 9");
            this.comboBox_q.Items.Add("~ 10");
            this.comboBox_q.Items.Add("~ 11");
            this.comboBox_q.Items.Add("~ 12");
            this.comboBox_q.Items.Add("~ 13");
            this.comboBox_q.Items.Add("~ 14");
            this.comboBox_q.Items.Add("~ 15 ");
            this.comboBox_q.Location = new System.Drawing.Point(122, 50);
            this.comboBox_q.Name = "comboBox_q";
            this.comboBox_q.Size = new System.Drawing.Size(110, 23);
            this.comboBox_q.TabIndex = 96;
            // 
            // checkBox_skipsame
            // 
            this.checkBox_skipsame.Font = new System.Drawing.Font("Gulim", 9F, System.Drawing.FontStyle.Bold);
            this.checkBox_skipsame.Location = new System.Drawing.Point(3, 28);
            this.checkBox_skipsame.Name = "checkBox_skipsame";
            this.checkBox_skipsame.Size = new System.Drawing.Size(92, 16);
            this.checkBox_skipsame.TabIndex = 92;
            this.checkBox_skipsame.Text = "skip same";
            // 
            // comboBox_target
            // 
            this.comboBox_target.Items.Add("A");
            this.comboBox_target.Items.Add("B");
            this.comboBox_target.Items.Add("AB");
            this.comboBox_target.Location = new System.Drawing.Point(173, 21);
            this.comboBox_target.Name = "comboBox_target";
            this.comboBox_target.Size = new System.Drawing.Size(59, 23);
            this.comboBox_target.TabIndex = 95;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Gulim", 9F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(175, 6);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 12);
            this.label3.Text = "Target";
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Gulim", 9F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(102, 56);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(15, 12);
            this.label4.Text = "Q";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Gulim", 9F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(101, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 12);
            this.label2.Text = "Session";
            // 
            // comboBox_session
            // 
            this.comboBox_session.Items.Add("S00");
            this.comboBox_session.Items.Add("S01");
            this.comboBox_session.Items.Add("S10");
            this.comboBox_session.Items.Add("S11");
            this.comboBox_session.Location = new System.Drawing.Point(101, 21);
            this.comboBox_session.Name = "comboBox_session";
            this.comboBox_session.Size = new System.Drawing.Size(66, 23);
            this.comboBox_session.TabIndex = 94;
            // 
            // checkBox_continue
            // 
            this.checkBox_continue.Font = new System.Drawing.Font("Gulim", 9F, System.Drawing.FontStyle.Bold);
            this.checkBox_continue.Location = new System.Drawing.Point(2, 6);
            this.checkBox_continue.Name = "checkBox_continue";
            this.checkBox_continue.Size = new System.Drawing.Size(80, 16);
            this.checkBox_continue.TabIndex = 91;
            this.checkBox_continue.Text = "continue";
            // 
            // ConfigForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(238, 275);
            this.Controls.Add(this.textBox_appversion);
            this.Controls.Add(this.textBox_firmwarever);
            this.Controls.Add(this.label_appversion);
            this.Controls.Add(this.label_firmwarever);
            this.Controls.Add(this.label_duty);
            this.Controls.Add(this.trackBar_duty);
            this.Controls.Add(this.label_txpwr);
            this.Controls.Add(this.trackBar_txpwr);
            this.Controls.Add(this.textBox_scantime);
            this.Controls.Add(this.label_scantime);
            this.Controls.Add(this.comboBox_q);
            this.Controls.Add(this.checkBox_skipsame);
            this.Controls.Add(this.comboBox_target);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBox_session);
            this.Controls.Add(this.checkBox_continue);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "ConfigForm";
            this.Text = "ConfigForm";
            this.Closing += new System.ComponentModel.CancelEventHandler(this.ConfigForm_Closing);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_appversion;
        private System.Windows.Forms.TextBox textBox_firmwarever;
        private System.Windows.Forms.Label label_appversion;
        private System.Windows.Forms.Label label_firmwarever;
        private System.Windows.Forms.Label label_duty;
        private System.Windows.Forms.TrackBar trackBar_duty;
        private System.Windows.Forms.Label label_txpwr;
        private System.Windows.Forms.TrackBar trackBar_txpwr;
        private System.Windows.Forms.TextBox textBox_scantime;
        private System.Windows.Forms.Label label_scantime;
        private System.Windows.Forms.ComboBox comboBox_q;
        private System.Windows.Forms.CheckBox checkBox_skipsame;
        private System.Windows.Forms.ComboBox comboBox_target;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox_session;
        private System.Windows.Forms.CheckBox checkBox_continue;
    }
}