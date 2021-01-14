namespace Bugtracker
{
    partial class LoginPanel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginPanel));
            this.Label_SplashTitle = new System.Windows.Forms.Label();
            this.PictureBox_SplashLogo = new System.Windows.Forms.PictureBox();
            this.Panel_Splash = new System.Windows.Forms.Panel();
            this.Label_SplashText = new System.Windows.Forms.Label();
            this.Panel_Pages = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox_SplashLogo)).BeginInit();
            this.Panel_Splash.SuspendLayout();
            this.SuspendLayout();
            // 
            // Label_SplashTitle
            // 
            this.Label_SplashTitle.BackColor = System.Drawing.Color.Transparent;
            this.Label_SplashTitle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Label_SplashTitle.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold);
            this.Label_SplashTitle.ForeColor = System.Drawing.Color.White;
            this.Label_SplashTitle.Location = new System.Drawing.Point(0, 104);
            this.Label_SplashTitle.Margin = new System.Windows.Forms.Padding(0);
            this.Label_SplashTitle.Name = "Label_SplashTitle";
            this.Label_SplashTitle.Size = new System.Drawing.Size(374, 94);
            this.Label_SplashTitle.TabIndex = 10;
            this.Label_SplashTitle.Text = "Catch.";
            this.Label_SplashTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // PictureBox_SplashLogo
            // 
            this.PictureBox_SplashLogo.BackColor = System.Drawing.Color.Transparent;
            this.PictureBox_SplashLogo.BackgroundImage = global::Bugtracker.Properties.Resources.bt_splash_1;
            this.PictureBox_SplashLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PictureBox_SplashLogo.Location = new System.Drawing.Point(144, 0);
            this.PictureBox_SplashLogo.Margin = new System.Windows.Forms.Padding(144, 0, 0, 0);
            this.PictureBox_SplashLogo.Name = "PictureBox_SplashLogo";
            this.PictureBox_SplashLogo.Size = new System.Drawing.Size(96, 104);
            this.PictureBox_SplashLogo.TabIndex = 13;
            this.PictureBox_SplashLogo.TabStop = false;
            // 
            // Panel_Splash
            // 
            this.Panel_Splash.BackColor = System.Drawing.Color.Transparent;
            this.Panel_Splash.Controls.Add(this.Label_SplashText);
            this.Panel_Splash.Controls.Add(this.PictureBox_SplashLogo);
            this.Panel_Splash.Controls.Add(this.Label_SplashTitle);
            this.Panel_Splash.Location = new System.Drawing.Point(41, 137);
            this.Panel_Splash.Margin = new System.Windows.Forms.Padding(32, 128, 32, 128);
            this.Panel_Splash.MaximumSize = new System.Drawing.Size(374, 292);
            this.Panel_Splash.MinimumSize = new System.Drawing.Size(374, 292);
            this.Panel_Splash.Name = "Panel_Splash";
            this.Panel_Splash.Size = new System.Drawing.Size(374, 292);
            this.Panel_Splash.TabIndex = 14;
            // 
            // Label_SplashText
            // 
            this.Label_SplashText.BackColor = System.Drawing.Color.Transparent;
            this.Label_SplashText.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Label_SplashText.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.Label_SplashText.ForeColor = System.Drawing.Color.White;
            this.Label_SplashText.Location = new System.Drawing.Point(0, 198);
            this.Label_SplashText.Margin = new System.Windows.Forms.Padding(0);
            this.Label_SplashText.Name = "Label_SplashText";
            this.Label_SplashText.Size = new System.Drawing.Size(374, 94);
            this.Label_SplashText.TabIndex = 14;
            this.Label_SplashText.Text = "Found a bug? You can report it to a project so that it can be fixed.";
            // 
            // Panel_Pages
            // 
            this.Panel_Pages.BackColor = System.Drawing.Color.Transparent;
            this.Panel_Pages.Location = new System.Drawing.Point(41, 429);
            this.Panel_Pages.Margin = new System.Windows.Forms.Padding(32, 0, 32, 0);
            this.Panel_Pages.MaximumSize = new System.Drawing.Size(374, 32);
            this.Panel_Pages.MinimumSize = new System.Drawing.Size(374, 32);
            this.Panel_Pages.Name = "Panel_Pages";
            this.Panel_Pages.Size = new System.Drawing.Size(374, 32);
            this.Panel_Pages.TabIndex = 15;
            // 
            // LoginPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(85)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(456, 566);
            this.Controls.Add(this.Panel_Pages);
            this.Controls.Add(this.Panel_Splash);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(456, 566);
            this.MinimumSize = new System.Drawing.Size(456, 566);
            this.Name = "LoginPanel";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "BugTracker";
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox_SplashLogo)).EndInit();
            this.Panel_Splash.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label Label_SplashTitle;
        private System.Windows.Forms.PictureBox PictureBox_SplashLogo;
        private System.Windows.Forms.Panel Panel_Splash;
        private System.Windows.Forms.Label Label_SplashText;
        private System.Windows.Forms.Panel Panel_Pages;
    }
}