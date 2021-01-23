namespace Bugtracker
{
    partial class ForgotPasswordForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ForgotPasswordForm));
            this.Label_PasswordReset = new System.Windows.Forms.Label();
            this.Label_EmailSeparator = new System.Windows.Forms.Label();
            this.PictureBox_Email = new System.Windows.Forms.PictureBox();
            this.TextBox_RegisterEmail = new System.Windows.Forms.TextBox();
            this.Button_Send = new System.Windows.Forms.Button();
            this.Button_Cancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox_Email)).BeginInit();
            this.SuspendLayout();
            // 
            // Label_PasswordReset
            // 
            this.Label_PasswordReset.AutoSize = true;
            this.Label_PasswordReset.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.Label_PasswordReset.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(82)))), ((int)(((byte)(82)))));
            this.Label_PasswordReset.Location = new System.Drawing.Point(38, 41);
            this.Label_PasswordReset.Margin = new System.Windows.Forms.Padding(29, 32, 0, 6);
            this.Label_PasswordReset.Name = "Label_PasswordReset";
            this.Label_PasswordReset.Size = new System.Drawing.Size(160, 22);
            this.Label_PasswordReset.TabIndex = 6;
            this.Label_PasswordReset.Text = "Password Reset";
            // 
            // Label_EmailSeparator
            // 
            this.Label_EmailSeparator.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(119)))), ((int)(((byte)(136)))));
            this.Label_EmailSeparator.Location = new System.Drawing.Point(39, 127);
            this.Label_EmailSeparator.Margin = new System.Windows.Forms.Padding(32, 3, 32, 0);
            this.Label_EmailSeparator.Name = "Label_EmailSeparator";
            this.Label_EmailSeparator.Size = new System.Drawing.Size(378, 2);
            this.Label_EmailSeparator.TabIndex = 39;
            // 
            // PictureBox_Email
            // 
            this.PictureBox_Email.BackgroundImage = global::Bugtracker.Properties.Resources.bt_login_email;
            this.PictureBox_Email.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.PictureBox_Email.Location = new System.Drawing.Point(39, 95);
            this.PictureBox_Email.Margin = new System.Windows.Forms.Padding(0);
            this.PictureBox_Email.Name = "PictureBox_Email";
            this.PictureBox_Email.Size = new System.Drawing.Size(30, 32);
            this.PictureBox_Email.TabIndex = 49;
            this.PictureBox_Email.TabStop = false;
            this.PictureBox_Email.Click += new System.EventHandler(this.PictureBox_Email_Click);
            // 
            // TextBox_RegisterEmail
            // 
            this.TextBox_RegisterEmail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TextBox_RegisterEmail.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.TextBox_RegisterEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(119)))), ((int)(((byte)(136)))));
            this.TextBox_RegisterEmail.Location = new System.Drawing.Point(72, 101);
            this.TextBox_RegisterEmail.Margin = new System.Windows.Forms.Padding(32, 3, 32, 3);
            this.TextBox_RegisterEmail.Name = "TextBox_RegisterEmail";
            this.TextBox_RegisterEmail.Size = new System.Drawing.Size(345, 19);
            this.TextBox_RegisterEmail.TabIndex = 50;
            this.TextBox_RegisterEmail.TabStop = false;
            this.TextBox_RegisterEmail.Text = "Enter your email here";
            this.TextBox_RegisterEmail.Enter += new System.EventHandler(this.TextBox_RegisterEmail_Enter);
            this.TextBox_RegisterEmail.Leave += new System.EventHandler(this.TextBox_RegisterEmail_Leave);
            // 
            // Button_Send
            // 
            this.Button_Send.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(85)))), ((int)(((byte)(0)))));
            this.Button_Send.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Button_Send.FlatAppearance.BorderSize = 0;
            this.Button_Send.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(186)))), ((int)(((byte)(131)))));
            this.Button_Send.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(174)))), ((int)(((byte)(71)))));
            this.Button_Send.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_Send.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.Button_Send.ForeColor = System.Drawing.Color.White;
            this.Button_Send.Location = new System.Drawing.Point(289, 186);
            this.Button_Send.Name = "Button_Send";
            this.Button_Send.Size = new System.Drawing.Size(128, 26);
            this.Button_Send.TabIndex = 51;
            this.Button_Send.TabStop = false;
            this.Button_Send.Text = "Send";
            this.Button_Send.UseVisualStyleBackColor = false;
            // 
            // Button_Cancel
            // 
            this.Button_Cancel.AutoSize = true;
            this.Button_Cancel.BackColor = System.Drawing.Color.Transparent;
            this.Button_Cancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Button_Cancel.FlatAppearance.BorderSize = 0;
            this.Button_Cancel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.Button_Cancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.Button_Cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_Cancel.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.Button_Cancel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(82)))), ((int)(((byte)(82)))));
            this.Button_Cancel.Location = new System.Drawing.Point(208, 186);
            this.Button_Cancel.Margin = new System.Windows.Forms.Padding(0);
            this.Button_Cancel.Name = "Button_Cancel";
            this.Button_Cancel.Size = new System.Drawing.Size(78, 26);
            this.Button_Cancel.TabIndex = 52;
            this.Button_Cancel.TabStop = false;
            this.Button_Cancel.Text = "Cancel";
            this.Button_Cancel.UseVisualStyleBackColor = false;
            this.Button_Cancel.Click += new System.EventHandler(this.Button_Cancel_Click);
            this.Button_Cancel.MouseLeave += new System.EventHandler(this.Button_Cancel_MouseLeave);
            this.Button_Cancel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Button_Cancel_MouseMove);
            // 
            // ForgotPasswordForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(456, 224);
            this.Controls.Add(this.Button_Cancel);
            this.Controls.Add(this.Button_Send);
            this.Controls.Add(this.PictureBox_Email);
            this.Controls.Add(this.Label_EmailSeparator);
            this.Controls.Add(this.Label_PasswordReset);
            this.Controls.Add(this.TextBox_RegisterEmail);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(456, 224);
            this.MinimumSize = new System.Drawing.Size(456, 224);
            this.Name = "ForgotPasswordForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "BugTracker";
            this.Click += new System.EventHandler(this.ForgotPasswordForm_Click);
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox_Email)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Label_PasswordReset;
        private System.Windows.Forms.Label Label_EmailSeparator;
        private System.Windows.Forms.PictureBox PictureBox_Email;
        private System.Windows.Forms.TextBox TextBox_RegisterEmail;
        private System.Windows.Forms.Button Button_Send;
        private System.Windows.Forms.Button Button_Cancel;
    }
}