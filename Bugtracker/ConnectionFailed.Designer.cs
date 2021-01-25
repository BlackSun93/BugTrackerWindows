
namespace Bugtracker
{
    partial class ConnectionFailed
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConnectionFailed));
            this.Button_Retry = new System.Windows.Forms.Button();
            this.PictureBox_ConnectionFailed = new System.Windows.Forms.PictureBox();
            this.Label_ConnectionFailed = new System.Windows.Forms.Label();
            this.Label_RetryConnection = new System.Windows.Forms.Label();
            this.Panel_TopBar = new System.Windows.Forms.Panel();
            this.Button_Minimize = new System.Windows.Forms.Button();
            this.Button_Close = new System.Windows.Forms.Button();
            this.Label_TopBarTitle = new System.Windows.Forms.Label();
            this.PictureBox_TopBarLogo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox_ConnectionFailed)).BeginInit();
            this.Panel_TopBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox_TopBarLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // Button_Retry
            // 
            this.Button_Retry.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(85)))), ((int)(((byte)(0)))));
            this.Button_Retry.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Button_Retry.FlatAppearance.BorderSize = 0;
            this.Button_Retry.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(186)))), ((int)(((byte)(131)))));
            this.Button_Retry.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(174)))), ((int)(((byte)(71)))));
            this.Button_Retry.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_Retry.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.Button_Retry.ForeColor = System.Drawing.Color.White;
            this.Button_Retry.Location = new System.Drawing.Point(34, 424);
            this.Button_Retry.Margin = new System.Windows.Forms.Padding(0);
            this.Button_Retry.Name = "Button_Retry";
            this.Button_Retry.Size = new System.Drawing.Size(389, 26);
            this.Button_Retry.TabIndex = 1;
            this.Button_Retry.TabStop = false;
            this.Button_Retry.Text = "Retry";
            this.Button_Retry.UseVisualStyleBackColor = false;
            this.Button_Retry.Click += new System.EventHandler(this.Button_Retry_Click);
            // 
            // PictureBox_ConnectionFailed
            // 
            this.PictureBox_ConnectionFailed.BackColor = System.Drawing.Color.White;
            this.PictureBox_ConnectionFailed.BackgroundImage = global::Bugtracker.Properties.Resources.bt_connection;
            this.PictureBox_ConnectionFailed.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.PictureBox_ConnectionFailed.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PictureBox_ConnectionFailed.Location = new System.Drawing.Point(164, 141);
            this.PictureBox_ConnectionFailed.Margin = new System.Windows.Forms.Padding(0);
            this.PictureBox_ConnectionFailed.Name = "PictureBox_ConnectionFailed";
            this.PictureBox_ConnectionFailed.Size = new System.Drawing.Size(127, 127);
            this.PictureBox_ConnectionFailed.TabIndex = 10;
            this.PictureBox_ConnectionFailed.TabStop = false;
            // 
            // Label_ConnectionFailed
            // 
            this.Label_ConnectionFailed.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold);
            this.Label_ConnectionFailed.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(85)))), ((int)(((byte)(0)))));
            this.Label_ConnectionFailed.Location = new System.Drawing.Point(37, 268);
            this.Label_ConnectionFailed.Margin = new System.Windows.Forms.Padding(0);
            this.Label_ConnectionFailed.Name = "Label_ConnectionFailed";
            this.Label_ConnectionFailed.Size = new System.Drawing.Size(386, 78);
            this.Label_ConnectionFailed.TabIndex = 43;
            this.Label_ConnectionFailed.Text = "Connection Failed";
            this.Label_ConnectionFailed.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Label_RetryConnection
            // 
            this.Label_RetryConnection.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.Label_RetryConnection.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(119)))), ((int)(((byte)(136)))));
            this.Label_RetryConnection.Location = new System.Drawing.Point(34, 346);
            this.Label_RetryConnection.Margin = new System.Windows.Forms.Padding(0);
            this.Label_RetryConnection.Name = "Label_RetryConnection";
            this.Label_RetryConnection.Size = new System.Drawing.Size(389, 78);
            this.Label_RetryConnection.TabIndex = 44;
            this.Label_RetryConnection.Text = "Error";
            this.Label_RetryConnection.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Panel_TopBar
            // 
            this.Panel_TopBar.BackColor = System.Drawing.Color.White;
            this.Panel_TopBar.Controls.Add(this.Button_Minimize);
            this.Panel_TopBar.Controls.Add(this.Button_Close);
            this.Panel_TopBar.Controls.Add(this.Label_TopBarTitle);
            this.Panel_TopBar.Controls.Add(this.PictureBox_TopBarLogo);
            this.Panel_TopBar.Location = new System.Drawing.Point(0, 0);
            this.Panel_TopBar.Margin = new System.Windows.Forms.Padding(2);
            this.Panel_TopBar.MaximumSize = new System.Drawing.Size(456, 32);
            this.Panel_TopBar.MinimumSize = new System.Drawing.Size(456, 32);
            this.Panel_TopBar.Name = "Panel_TopBar";
            this.Panel_TopBar.Size = new System.Drawing.Size(456, 32);
            this.Panel_TopBar.TabIndex = 45;
            this.Panel_TopBar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Panel_TopBar_MouseMove);
            // 
            // Button_Minimize
            // 
            this.Button_Minimize.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Button_Minimize.BackColor = System.Drawing.Color.Transparent;
            this.Button_Minimize.BackgroundImage = global::Bugtracker.Properties.Resources.bt_minimize;
            this.Button_Minimize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Button_Minimize.FlatAppearance.BorderSize = 0;
            this.Button_Minimize.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(154)))), ((int)(((byte)(110)))));
            this.Button_Minimize.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(223)))), ((int)(((byte)(223)))));
            this.Button_Minimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_Minimize.Location = new System.Drawing.Point(396, 0);
            this.Button_Minimize.Margin = new System.Windows.Forms.Padding(0);
            this.Button_Minimize.Name = "Button_Minimize";
            this.Button_Minimize.Size = new System.Drawing.Size(30, 32);
            this.Button_Minimize.TabIndex = 6;
            this.Button_Minimize.TabStop = false;
            this.Button_Minimize.UseVisualStyleBackColor = false;
            this.Button_Minimize.Click += new System.EventHandler(this.Button_Minimize_Click);
            // 
            // Button_Close
            // 
            this.Button_Close.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Button_Close.BackColor = System.Drawing.Color.Transparent;
            this.Button_Close.BackgroundImage = global::Bugtracker.Properties.Resources.bt_close;
            this.Button_Close.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Button_Close.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Button_Close.FlatAppearance.BorderSize = 0;
            this.Button_Close.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(154)))), ((int)(((byte)(110)))));
            this.Button_Close.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(223)))), ((int)(((byte)(223)))));
            this.Button_Close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_Close.Location = new System.Drawing.Point(426, 0);
            this.Button_Close.Margin = new System.Windows.Forms.Padding(0);
            this.Button_Close.Name = "Button_Close";
            this.Button_Close.Size = new System.Drawing.Size(30, 32);
            this.Button_Close.TabIndex = 5;
            this.Button_Close.TabStop = false;
            this.Button_Close.UseVisualStyleBackColor = false;
            this.Button_Close.Click += new System.EventHandler(this.Button_Close_Click);
            // 
            // Label_TopBarTitle
            // 
            this.Label_TopBarTitle.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.Label_TopBarTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(82)))), ((int)(((byte)(82)))));
            this.Label_TopBarTitle.Location = new System.Drawing.Point(30, 0);
            this.Label_TopBarTitle.Margin = new System.Windows.Forms.Padding(0);
            this.Label_TopBarTitle.Name = "Label_TopBarTitle";
            this.Label_TopBarTitle.Size = new System.Drawing.Size(76, 32);
            this.Label_TopBarTitle.TabIndex = 4;
            this.Label_TopBarTitle.Text = "BugTracker";
            this.Label_TopBarTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // PictureBox_TopBarLogo
            // 
            this.PictureBox_TopBarLogo.BackgroundImage = global::Bugtracker.Properties.Resources.bt_logo_small;
            this.PictureBox_TopBarLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.PictureBox_TopBarLogo.Location = new System.Drawing.Point(0, 0);
            this.PictureBox_TopBarLogo.Margin = new System.Windows.Forms.Padding(0);
            this.PictureBox_TopBarLogo.Name = "PictureBox_TopBarLogo";
            this.PictureBox_TopBarLogo.Size = new System.Drawing.Size(30, 32);
            this.PictureBox_TopBarLogo.TabIndex = 3;
            this.PictureBox_TopBarLogo.TabStop = false;
            // 
            // ConnectionFailed
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(456, 566);
            this.Controls.Add(this.Panel_TopBar);
            this.Controls.Add(this.Label_RetryConnection);
            this.Controls.Add(this.Label_ConnectionFailed);
            this.Controls.Add(this.PictureBox_ConnectionFailed);
            this.Controls.Add(this.Button_Retry);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(456, 566);
            this.MinimumSize = new System.Drawing.Size(456, 566);
            this.Name = "ConnectionFailed";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BugTracker";
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox_ConnectionFailed)).EndInit();
            this.Panel_TopBar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox_TopBarLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Button_Retry;
        private System.Windows.Forms.PictureBox PictureBox_ConnectionFailed;
        private System.Windows.Forms.Label Label_ConnectionFailed;
        private System.Windows.Forms.Label Label_RetryConnection;
        private System.Windows.Forms.Panel Panel_TopBar;
        private System.Windows.Forms.Button Button_Minimize;
        private System.Windows.Forms.Button Button_Close;
        private System.Windows.Forms.Label Label_TopBarTitle;
        private System.Windows.Forms.PictureBox PictureBox_TopBarLogo;
    }
}