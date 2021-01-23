
namespace Bugtracker
{
    partial class SplashForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SplashForm));
            this.PictureBox_SplashLogo = new System.Windows.Forms.PictureBox();
            this.Label_SplashTitle = new System.Windows.Forms.Label();
            this.Label_SplashText = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox_SplashLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // PictureBox_SplashLogo
            // 
            this.PictureBox_SplashLogo.BackgroundImage = global::Bugtracker.Properties.Resources.bt_splash_1;
            this.PictureBox_SplashLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PictureBox_SplashLogo.Location = new System.Drawing.Point(144, 0);
            this.PictureBox_SplashLogo.Margin = new System.Windows.Forms.Padding(0);
            this.PictureBox_SplashLogo.MaximumSize = new System.Drawing.Size(96, 104);
            this.PictureBox_SplashLogo.MinimumSize = new System.Drawing.Size(96, 104);
            this.PictureBox_SplashLogo.Name = "PictureBox_SplashLogo";
            this.PictureBox_SplashLogo.Size = new System.Drawing.Size(96, 104);
            this.PictureBox_SplashLogo.TabIndex = 8;
            this.PictureBox_SplashLogo.TabStop = false;
            // 
            // Label_SplashTitle
            // 
            this.Label_SplashTitle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Label_SplashTitle.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold);
            this.Label_SplashTitle.ForeColor = System.Drawing.Color.White;
            this.Label_SplashTitle.Location = new System.Drawing.Point(0, 104);
            this.Label_SplashTitle.Margin = new System.Windows.Forms.Padding(29, 32, 0, 6);
            this.Label_SplashTitle.Name = "Label_SplashTitle";
            this.Label_SplashTitle.Size = new System.Drawing.Size(374, 94);
            this.Label_SplashTitle.TabIndex = 0;
            this.Label_SplashTitle.Text = "Title";
            this.Label_SplashTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Label_SplashText
            // 
            this.Label_SplashText.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Label_SplashText.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.Label_SplashText.ForeColor = System.Drawing.Color.White;
            this.Label_SplashText.Location = new System.Drawing.Point(0, 198);
            this.Label_SplashText.Margin = new System.Windows.Forms.Padding(29, 32, 0, 6);
            this.Label_SplashText.Name = "Label_SplashText";
            this.Label_SplashText.Size = new System.Drawing.Size(374, 94);
            this.Label_SplashText.TabIndex = 9;
            this.Label_SplashText.Text = "Text.";
            // 
            // SplashForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(85)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(374, 292);
            this.Controls.Add(this.Label_SplashText);
            this.Controls.Add(this.Label_SplashTitle);
            this.Controls.Add(this.PictureBox_SplashLogo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(374, 292);
            this.MinimumSize = new System.Drawing.Size(374, 292);
            this.Name = "SplashForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "BugTracker";
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox_SplashLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox PictureBox_SplashLogo;
        private System.Windows.Forms.Label Label_SplashTitle;
        private System.Windows.Forms.Label Label_SplashText;
    }
}