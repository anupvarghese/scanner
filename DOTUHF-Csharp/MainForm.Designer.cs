namespace DOTUHF_Csharp
{
    partial class MainForm
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
            this.button_config = new System.Windows.Forms.Button();
            this.button_lockkill = new System.Windows.Forms.Button();
            this.button_readwrite = new System.Windows.Forms.Button();
            this.button_custom = new System.Windows.Forms.Button();
            this.button_single = new System.Windows.Forms.Button();
            this.button_multi = new System.Windows.Forms.Button();
            this.label_fw_ver = new System.Windows.Forms.Label();
            this.label_app_ver = new System.Windows.Forms.Label();
            this.button_normal = new System.Windows.Forms.Button();
            this.pictureBox_link = new System.Windows.Forms.PictureBox();
            this.label_link = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button_config
            // 
            this.button_config.Font = new System.Drawing.Font("Gulim", 9F, System.Drawing.FontStyle.Bold);
            this.button_config.Location = new System.Drawing.Point(24, 228);
            this.button_config.Name = "button_config";
            this.button_config.Size = new System.Drawing.Size(189, 28);
            this.button_config.TabIndex = 34;
            this.button_config.Text = "CONFIG MODE";
            this.button_config.Click += new System.EventHandler(this.button_config_Click);
            // 
            // button_lockkill
            // 
            this.button_lockkill.Font = new System.Drawing.Font("Gulim", 9F, System.Drawing.FontStyle.Bold);
            this.button_lockkill.Location = new System.Drawing.Point(24, 194);
            this.button_lockkill.Name = "button_lockkill";
            this.button_lockkill.Size = new System.Drawing.Size(189, 28);
            this.button_lockkill.TabIndex = 33;
            this.button_lockkill.Text = "LOCK / KILL MODE";
            this.button_lockkill.Click += new System.EventHandler(this.button_lockkill_Click);
            // 
            // button_readwrite
            // 
            this.button_readwrite.Font = new System.Drawing.Font("Gulim", 9F, System.Drawing.FontStyle.Bold);
            this.button_readwrite.Location = new System.Drawing.Point(24, 160);
            this.button_readwrite.Name = "button_readwrite";
            this.button_readwrite.Size = new System.Drawing.Size(189, 28);
            this.button_readwrite.TabIndex = 32;
            this.button_readwrite.Text = "READ / WRITE MODE";
            this.button_readwrite.Click += new System.EventHandler(this.button_readwrite_Click);
            // 
            // button_custom
            // 
            this.button_custom.Font = new System.Drawing.Font("Gulim", 9F, System.Drawing.FontStyle.Bold);
            this.button_custom.Location = new System.Drawing.Point(119, 126);
            this.button_custom.Name = "button_custom";
            this.button_custom.Size = new System.Drawing.Size(94, 28);
            this.button_custom.TabIndex = 31;
            this.button_custom.Text = "CUSTOM";
            this.button_custom.Click += new System.EventHandler(this.button_custom_Click);
            // 
            // button_single
            // 
            this.button_single.Font = new System.Drawing.Font("Gulim", 9F, System.Drawing.FontStyle.Bold);
            this.button_single.Location = new System.Drawing.Point(24, 126);
            this.button_single.Name = "button_single";
            this.button_single.Size = new System.Drawing.Size(90, 28);
            this.button_single.TabIndex = 30;
            this.button_single.Text = "SINGLE";
            this.button_single.Click += new System.EventHandler(this.button_single_Click);
            // 
            // button_multi
            // 
            this.button_multi.Font = new System.Drawing.Font("Gulim", 9F, System.Drawing.FontStyle.Bold);
            this.button_multi.Location = new System.Drawing.Point(24, 92);
            this.button_multi.Name = "button_multi";
            this.button_multi.Size = new System.Drawing.Size(189, 28);
            this.button_multi.TabIndex = 29;
            this.button_multi.Text = "MULTI MODE";
            this.button_multi.Click += new System.EventHandler(this.button_multi_Click);
            // 
            // label_fw_ver
            // 
            this.label_fw_ver.Font = new System.Drawing.Font("Gulim", 9F, System.Drawing.FontStyle.Bold);
            this.label_fw_ver.Location = new System.Drawing.Point(54, 35);
            this.label_fw_ver.Name = "label_fw_ver";
            this.label_fw_ver.Size = new System.Drawing.Size(176, 19);
            this.label_fw_ver.Text = "Fw Version :";
            // 
            // label_app_ver
            // 
            this.label_app_ver.Font = new System.Drawing.Font("Gulim", 9F, System.Drawing.FontStyle.Bold);
            this.label_app_ver.Location = new System.Drawing.Point(48, 14);
            this.label_app_ver.Name = "label_app_ver";
            this.label_app_ver.Size = new System.Drawing.Size(182, 20);
            this.label_app_ver.Text = "App Version :";
            // 
            // button_normal
            // 
            this.button_normal.Font = new System.Drawing.Font("Gulim", 9F, System.Drawing.FontStyle.Bold);
            this.button_normal.Location = new System.Drawing.Point(24, 58);
            this.button_normal.Name = "button_normal";
            this.button_normal.Size = new System.Drawing.Size(189, 28);
            this.button_normal.TabIndex = 28;
            this.button_normal.Text = "NORMAL MODE";
            this.button_normal.Click += new System.EventHandler(this.button_normal_Click);
            // 
            // pictureBox_link
            // 
            this.pictureBox_link.Location = new System.Drawing.Point(18, 30);
            this.pictureBox_link.Name = "pictureBox_link";
            this.pictureBox_link.Size = new System.Drawing.Size(17, 17);
            // 
            // label_link
            // 
            this.label_link.Font = new System.Drawing.Font("Gulim", 9F, System.Drawing.FontStyle.Bold);
            this.label_link.Location = new System.Drawing.Point(10, 13);
            this.label_link.Name = "label_link";
            this.label_link.Size = new System.Drawing.Size(36, 12);
            this.label_link.Text = "LINK";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(238, 275);
            this.Controls.Add(this.button_config);
            this.Controls.Add(this.button_lockkill);
            this.Controls.Add(this.button_readwrite);
            this.Controls.Add(this.button_custom);
            this.Controls.Add(this.button_single);
            this.Controls.Add(this.button_multi);
            this.Controls.Add(this.label_fw_ver);
            this.Controls.Add(this.label_app_ver);
            this.Controls.Add(this.button_normal);
            this.Controls.Add(this.pictureBox_link);
            this.Controls.Add(this.label_link);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "MainForm";
            this.Text = "DOTUHF";
            this.Closing += new System.ComponentModel.CancelEventHandler(this.MainForm_Closing);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_config;
        private System.Windows.Forms.Button button_lockkill;
        private System.Windows.Forms.Button button_readwrite;
        private System.Windows.Forms.Button button_custom;
        private System.Windows.Forms.Button button_single;
        private System.Windows.Forms.Button button_multi;
        private System.Windows.Forms.Label label_fw_ver;
        private System.Windows.Forms.Label label_app_ver;
        private System.Windows.Forms.Button button_normal;
        private System.Windows.Forms.PictureBox pictureBox_link;
        private System.Windows.Forms.Label label_link;
    }
}

