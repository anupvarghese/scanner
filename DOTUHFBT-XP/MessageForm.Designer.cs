namespace DOTUHFBT_XP
{
    partial class MessageForm
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
            this.label_title = new System.Windows.Forms.Label();
            this.label_message = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label_title
            // 
            this.label_title.AutoSize = true;
            this.label_title.Font = new System.Drawing.Font("Gulim", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label_title.Location = new System.Drawing.Point(12, 123);
            this.label_title.Name = "label_title";
            this.label_title.Size = new System.Drawing.Size(112, 12);
            this.label_title.TabIndex = 0;
            this.label_title.Text = "Error Message :";
            // 
            // label_message
            // 
            this.label_message.AutoSize = true;
            this.label_message.Font = new System.Drawing.Font("Gulim", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label_message.ForeColor = System.Drawing.Color.Red;
            this.label_message.Location = new System.Drawing.Point(12, 160);
            this.label_message.Name = "label_message";
            this.label_message.Size = new System.Drawing.Size(65, 12);
            this.label_message.TabIndex = 1;
            this.label_message.Text = "Message";
            this.label_message.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MessageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(264, 368);
            this.Controls.Add(this.label_message);
            this.Controls.Add(this.label_title);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "MessageForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MessageForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_title;
        private System.Windows.Forms.Label label_message;
    }
}