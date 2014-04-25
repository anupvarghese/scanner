namespace DOTUHFBT_XP
{
    partial class MenuForm
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
            this.label_link = new System.Windows.Forms.Label();
            this.pictureBox_link = new System.Windows.Forms.PictureBox();
            this.button_normal = new System.Windows.Forms.Button();
            this.label_app_ver = new System.Windows.Forms.Label();
            this.label_fw_ver = new System.Windows.Forms.Label();
            this.button_multi = new System.Windows.Forms.Button();
            this.button_single = new System.Windows.Forms.Button();
            this.button_custom = new System.Windows.Forms.Button();
            this.button_readwrite = new System.Windows.Forms.Button();
            this.button_lockkill = new System.Windows.Forms.Button();
            this.button_config = new System.Windows.Forms.Button();
            this.button_link = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_link)).BeginInit();
            this.SuspendLayout();
            // 
            // label_link
            // 
            this.label_link.AutoSize = true;
            this.label_link.Font = new System.Drawing.Font("Gulim", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label_link.Location = new System.Drawing.Point(13, 13);
            this.label_link.Name = "label_link";
            this.label_link.Size = new System.Drawing.Size(36, 12);
            this.label_link.TabIndex = 0;
            this.label_link.Text = "LINK";
            // 
            // pictureBox_link
            // 
            this.pictureBox_link.Location = new System.Drawing.Point(21, 30);
            this.pictureBox_link.Name = "pictureBox_link";
            this.pictureBox_link.Size = new System.Drawing.Size(17, 17);
            this.pictureBox_link.TabIndex = 1;
            this.pictureBox_link.TabStop = false;
            // 
            // button_normal
            // 
            this.button_normal.Font = new System.Drawing.Font("Gulim", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button_normal.Location = new System.Drawing.Point(21, 64);
            this.button_normal.Name = "button_normal";
            this.button_normal.Size = new System.Drawing.Size(189, 28);
            this.button_normal.TabIndex = 2;
            this.button_normal.Text = "NORMAL MODE";
            this.button_normal.UseVisualStyleBackColor = true;
            this.button_normal.Click += new System.EventHandler(this.button_normal_Click);
            // 
            // label_app_ver
            // 
            this.label_app_ver.AutoSize = true;
            this.label_app_ver.Font = new System.Drawing.Font("Gulim", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label_app_ver.Location = new System.Drawing.Point(58, 13);
            this.label_app_ver.Name = "label_app_ver";
            this.label_app_ver.Size = new System.Drawing.Size(95, 12);
            this.label_app_ver.TabIndex = 3;
            this.label_app_ver.Text = "App Version :";
            // 
            // label_fw_ver
            // 
            this.label_fw_ver.AutoSize = true;
            this.label_fw_ver.Font = new System.Drawing.Font("Gulim", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label_fw_ver.Location = new System.Drawing.Point(64, 35);
            this.label_fw_ver.Name = "label_fw_ver";
            this.label_fw_ver.Size = new System.Drawing.Size(89, 12);
            this.label_fw_ver.TabIndex = 4;
            this.label_fw_ver.Text = "Fw Version :";
            // 
            // button_multi
            // 
            this.button_multi.Font = new System.Drawing.Font("Gulim", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button_multi.Location = new System.Drawing.Point(21, 98);
            this.button_multi.Name = "button_multi";
            this.button_multi.Size = new System.Drawing.Size(189, 28);
            this.button_multi.TabIndex = 5;
            this.button_multi.Text = "MULTI MODE";
            this.button_multi.UseVisualStyleBackColor = true;
            this.button_multi.Click += new System.EventHandler(this.button_multi_Click);
            // 
            // button_single
            // 
            this.button_single.Font = new System.Drawing.Font("Gulim", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button_single.Location = new System.Drawing.Point(21, 132);
            this.button_single.Name = "button_single";
            this.button_single.Size = new System.Drawing.Size(189, 28);
            this.button_single.TabIndex = 6;
            this.button_single.Text = "SINGLE MODE";
            this.button_single.UseVisualStyleBackColor = true;
            this.button_single.Click += new System.EventHandler(this.button_single_Click);
            // 
            // button_custom
            // 
            this.button_custom.Font = new System.Drawing.Font("Gulim", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button_custom.Location = new System.Drawing.Point(21, 166);
            this.button_custom.Name = "button_custom";
            this.button_custom.Size = new System.Drawing.Size(189, 28);
            this.button_custom.TabIndex = 7;
            this.button_custom.Text = "CUSTOM MODE";
            this.button_custom.UseVisualStyleBackColor = true;
            this.button_custom.Click += new System.EventHandler(this.button_custom_Click);
            // 
            // button_readwrite
            // 
            this.button_readwrite.Font = new System.Drawing.Font("Gulim", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button_readwrite.Location = new System.Drawing.Point(21, 200);
            this.button_readwrite.Name = "button_readwrite";
            this.button_readwrite.Size = new System.Drawing.Size(189, 28);
            this.button_readwrite.TabIndex = 8;
            this.button_readwrite.Text = "READ / WRITE MODE";
            this.button_readwrite.UseVisualStyleBackColor = true;
            this.button_readwrite.Click += new System.EventHandler(this.button_readwrite_Click);
            // 
            // button_lockkill
            // 
            this.button_lockkill.Font = new System.Drawing.Font("Gulim", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button_lockkill.Location = new System.Drawing.Point(21, 234);
            this.button_lockkill.Name = "button_lockkill";
            this.button_lockkill.Size = new System.Drawing.Size(189, 28);
            this.button_lockkill.TabIndex = 9;
            this.button_lockkill.Text = "LOCK / KILL MODE";
            this.button_lockkill.UseVisualStyleBackColor = true;
            this.button_lockkill.Click += new System.EventHandler(this.button_lockkill_Click);
            // 
            // button_config
            // 
            this.button_config.Font = new System.Drawing.Font("Gulim", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button_config.Location = new System.Drawing.Point(21, 268);
            this.button_config.Name = "button_config";
            this.button_config.Size = new System.Drawing.Size(189, 28);
            this.button_config.TabIndex = 10;
            this.button_config.Text = "CONFIG MODE";
            this.button_config.UseVisualStyleBackColor = true;
            this.button_config.Click += new System.EventHandler(this.button_config_Click);
            // 
            // button_link
            // 
            this.button_link.Font = new System.Drawing.Font("Gulim", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button_link.Location = new System.Drawing.Point(21, 301);
            this.button_link.Name = "button_link";
            this.button_link.Size = new System.Drawing.Size(189, 28);
            this.button_link.TabIndex = 11;
            this.button_link.Text = "LINK";
            this.button_link.UseVisualStyleBackColor = true;
            this.button_link.Click += new System.EventHandler(this.button_link_Click);
            // 
            // MenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(237, 341);
            this.Controls.Add(this.button_link);
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
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MenuForm";
            this.Text = "MenuForm";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_link)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_link;
        private System.Windows.Forms.PictureBox pictureBox_link;
        private System.Windows.Forms.Button button_normal;
        private System.Windows.Forms.Label label_app_ver;
        private System.Windows.Forms.Label label_fw_ver;
        private System.Windows.Forms.Button button_multi;
        private System.Windows.Forms.Button button_single;
        private System.Windows.Forms.Button button_custom;
        private System.Windows.Forms.Button button_readwrite;
        private System.Windows.Forms.Button button_lockkill;
        private System.Windows.Forms.Button button_config;
        private System.Windows.Forms.Button button_link;
    }
}