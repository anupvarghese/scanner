namespace DOTUHFBT_XP
{
    partial class ConfigForm
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
            this.checkBox_continue = new System.Windows.Forms.CheckBox();
            this.checkBox_skipsame = new System.Windows.Forms.CheckBox();
            this.label_scantime = new System.Windows.Forms.Label();
            this.textBox_scantime = new System.Windows.Forms.TextBox();
            this.comboBox_session = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox_target = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBox_q = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label_txpwr = new System.Windows.Forms.Label();
            this.trackBar_txpwr = new System.Windows.Forms.TrackBar();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label_duty = new System.Windows.Forms.Label();
            this.trackBar_duty = new System.Windows.Forms.TrackBar();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label_firmwarever = new System.Windows.Forms.Label();
            this.label_appversion = new System.Windows.Forms.Label();
            this.textBox_firmwarever = new System.Windows.Forms.TextBox();
            this.textBox_appversion = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_txpwr)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_duty)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // checkBox_continue
            // 
            this.checkBox_continue.AutoSize = true;
            this.checkBox_continue.Font = new System.Drawing.Font("Gulim", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.checkBox_continue.Location = new System.Drawing.Point(13, 32);
            this.checkBox_continue.Name = "checkBox_continue";
            this.checkBox_continue.Size = new System.Drawing.Size(80, 16);
            this.checkBox_continue.TabIndex = 0;
            this.checkBox_continue.Text = "continue";
            this.checkBox_continue.UseVisualStyleBackColor = true;
            // 
            // checkBox_skipsame
            // 
            this.checkBox_skipsame.AutoSize = true;
            this.checkBox_skipsame.Font = new System.Drawing.Font("Gulim", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.checkBox_skipsame.Location = new System.Drawing.Point(13, 57);
            this.checkBox_skipsame.Name = "checkBox_skipsame";
            this.checkBox_skipsame.Size = new System.Drawing.Size(92, 16);
            this.checkBox_skipsame.TabIndex = 1;
            this.checkBox_skipsame.Text = "skip same";
            this.checkBox_skipsame.UseVisualStyleBackColor = true;
            // 
            // label_scantime
            // 
            this.label_scantime.AutoSize = true;
            this.label_scantime.Font = new System.Drawing.Font("Gulim", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label_scantime.Location = new System.Drawing.Point(11, 85);
            this.label_scantime.Name = "label_scantime";
            this.label_scantime.Size = new System.Drawing.Size(48, 12);
            this.label_scantime.TabIndex = 2;
            this.label_scantime.Text = "Time :";
            // 
            // textBox_scantime
            // 
            this.textBox_scantime.Location = new System.Drawing.Point(65, 82);
            this.textBox_scantime.Name = "textBox_scantime";
            this.textBox_scantime.Size = new System.Drawing.Size(37, 21);
            this.textBox_scantime.TabIndex = 3;
            // 
            // comboBox_session
            // 
            this.comboBox_session.FormattingEnabled = true;
            this.comboBox_session.Items.AddRange(new object[] {
            "S00",
            "S01",
            "S10",
            "S11"});
            this.comboBox_session.Location = new System.Drawing.Point(8, 34);
            this.comboBox_session.Name = "comboBox_session";
            this.comboBox_session.Size = new System.Drawing.Size(66, 20);
            this.comboBox_session.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Gulim", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(6, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 12);
            this.label2.TabIndex = 5;
            this.label2.Text = "Session";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Gulim", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.Location = new System.Drawing.Point(80, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 12);
            this.label3.TabIndex = 7;
            this.label3.Text = "Target";
            // 
            // comboBox_target
            // 
            this.comboBox_target.FormattingEnabled = true;
            this.comboBox_target.Items.AddRange(new object[] {
            "A",
            "B",
            "AB"});
            this.comboBox_target.Location = new System.Drawing.Point(79, 34);
            this.comboBox_target.Name = "comboBox_target";
            this.comboBox_target.Size = new System.Drawing.Size(59, 20);
            this.comboBox_target.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Gulim", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label4.Location = new System.Drawing.Point(6, 63);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(15, 12);
            this.label4.TabIndex = 8;
            this.label4.Text = "Q";
            // 
            // comboBox_q
            // 
            this.comboBox_q.FormattingEnabled = true;
            this.comboBox_q.Items.AddRange(new object[] {
            "   0",
            "~ 1 ",
            "~ 2",
            "~ 3",
            "~ 4",
            "~ 5",
            "~ 6",
            "~ 7",
            "~ 8",
            "~ 9",
            "~ 10",
            "~ 11",
            "~ 12",
            "~ 13",
            "~ 14",
            "~ 15 "});
            this.comboBox_q.Location = new System.Drawing.Point(28, 60);
            this.comboBox_q.Name = "comboBox_q";
            this.comboBox_q.Size = new System.Drawing.Size(110, 20);
            this.comboBox_q.TabIndex = 9;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.comboBox_q);
            this.groupBox1.Controls.Add(this.comboBox_target);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.comboBox_session);
            this.groupBox1.Font = new System.Drawing.Font("Gulim", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.groupBox1.Location = new System.Drawing.Point(111, 20);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(144, 87);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Query Param.";
            // 
            // label_txpwr
            // 
            this.label_txpwr.AutoSize = true;
            this.label_txpwr.Font = new System.Drawing.Font("Gulim", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label_txpwr.Location = new System.Drawing.Point(209, 125);
            this.label_txpwr.Name = "label_txpwr";
            this.label_txpwr.Size = new System.Drawing.Size(35, 12);
            this.label_txpwr.TabIndex = 74;
            this.label_txpwr.Text = "MAX";
            // 
            // trackBar_txpwr
            // 
            this.trackBar_txpwr.LargeChange = 10;
            this.trackBar_txpwr.Location = new System.Drawing.Point(13, 137);
            this.trackBar_txpwr.Maximum = 90;
            this.trackBar_txpwr.Name = "trackBar_txpwr";
            this.trackBar_txpwr.Size = new System.Drawing.Size(236, 45);
            this.trackBar_txpwr.TabIndex = 10;
            this.trackBar_txpwr.TickFrequency = 10;
            this.trackBar_txpwr.ValueChanged += new System.EventHandler(this.trackBar_txpwr_ValueChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Font = new System.Drawing.Font("Gulim", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.groupBox2.Location = new System.Drawing.Point(3, 113);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(252, 76);
            this.groupBox2.TabIndex = 75;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Power Control";
            // 
            // label_duty
            // 
            this.label_duty.AutoSize = true;
            this.label_duty.Font = new System.Drawing.Font("Gulim", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label_duty.Location = new System.Drawing.Point(206, 29);
            this.label_duty.Name = "label_duty";
            this.label_duty.Size = new System.Drawing.Size(35, 12);
            this.label_duty.TabIndex = 77;
            this.label_duty.Text = "MAX";
            // 
            // trackBar_duty
            // 
            this.trackBar_duty.LargeChange = 10;
            this.trackBar_duty.Location = new System.Drawing.Point(13, 212);
            this.trackBar_duty.Maximum = 40;
            this.trackBar_duty.Name = "trackBar_duty";
            this.trackBar_duty.Size = new System.Drawing.Size(190, 45);
            this.trackBar_duty.TabIndex = 10;
            this.trackBar_duty.TickFrequency = 10;
            this.trackBar_duty.ValueChanged += new System.EventHandler(this.trackBar_duty_ValueChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label_duty);
            this.groupBox3.Font = new System.Drawing.Font("Gulim", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.groupBox3.Location = new System.Drawing.Point(3, 195);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(252, 65);
            this.groupBox3.TabIndex = 78;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Tx Duty";
            // 
            // label_firmwarever
            // 
            this.label_firmwarever.AutoSize = true;
            this.label_firmwarever.Font = new System.Drawing.Font("Gulim", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label_firmwarever.Location = new System.Drawing.Point(3, 277);
            this.label_firmwarever.Name = "label_firmwarever";
            this.label_firmwarever.Size = new System.Drawing.Size(131, 12);
            this.label_firmwarever.TabIndex = 79;
            this.label_firmwarever.Text = "Firmware Version :";
            // 
            // label_appversion
            // 
            this.label_appversion.AutoSize = true;
            this.label_appversion.Font = new System.Drawing.Font("Gulim", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label_appversion.Location = new System.Drawing.Point(34, 301);
            this.label_appversion.Name = "label_appversion";
            this.label_appversion.Size = new System.Drawing.Size(100, 12);
            this.label_appversion.TabIndex = 80;
            this.label_appversion.Text = "App. Version :";
            // 
            // textBox_firmwarever
            // 
            this.textBox_firmwarever.Location = new System.Drawing.Point(140, 272);
            this.textBox_firmwarever.Name = "textBox_firmwarever";
            this.textBox_firmwarever.Size = new System.Drawing.Size(114, 21);
            this.textBox_firmwarever.TabIndex = 81;
            // 
            // textBox_appversion
            // 
            this.textBox_appversion.Location = new System.Drawing.Point(140, 298);
            this.textBox_appversion.Name = "textBox_appversion";
            this.textBox_appversion.Size = new System.Drawing.Size(114, 21);
            this.textBox_appversion.TabIndex = 82;
            // 
            // ConfigForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(264, 368);
            this.Controls.Add(this.textBox_appversion);
            this.Controls.Add(this.textBox_firmwarever);
            this.Controls.Add(this.label_appversion);
            this.Controls.Add(this.label_firmwarever);
            this.Controls.Add(this.trackBar_duty);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.label_txpwr);
            this.Controls.Add(this.trackBar_txpwr);
            this.Controls.Add(this.textBox_scantime);
            this.Controls.Add(this.label_scantime);
            this.Controls.Add(this.checkBox_skipsame);
            this.Controls.Add(this.checkBox_continue);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "ConfigForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ConfigForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ConfigForm_FormClosing);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_txpwr)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_duty)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox checkBox_continue;
        private System.Windows.Forms.CheckBox checkBox_skipsame;
        private System.Windows.Forms.Label label_scantime;
        private System.Windows.Forms.TextBox textBox_scantime;
        private System.Windows.Forms.ComboBox comboBox_session;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox_target;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBox_q;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label_txpwr;
        private System.Windows.Forms.TrackBar trackBar_txpwr;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label_duty;
        private System.Windows.Forms.TrackBar trackBar_duty;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label_firmwarever;
        private System.Windows.Forms.Label label_appversion;
        private System.Windows.Forms.TextBox textBox_firmwarever;
        private System.Windows.Forms.TextBox textBox_appversion;
    }
}