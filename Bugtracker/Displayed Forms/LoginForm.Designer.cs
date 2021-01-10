namespace Bugtracker
{
    partial class LoginForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.TextBox_Username = new System.Windows.Forms.TextBox();
            this.TextBox_Password = new System.Windows.Forms.TextBox();
            this.Button_Login = new System.Windows.Forms.Button();
            this.Button_Register = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Panel_Login = new System.Windows.Forms.Panel();
            this.Panel_Register = new System.Windows.Forms.Panel();
            this.Panel_TopBar = new System.Windows.Forms.Panel();
            this.ToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.PictureBox_LogoSmall = new System.Windows.Forms.PictureBox();
            this.Button_Minimize = new System.Windows.Forms.Button();
            this.Button_Maximize = new System.Windows.Forms.Button();
            this.Button_Close = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.Label_LoginTitle = new System.Windows.Forms.Label();
            this.Label_Bug = new System.Windows.Forms.Label();
            this.Label_Tracker = new System.Windows.Forms.Label();
            this.Panel_Login.SuspendLayout();
            this.Panel_Register.SuspendLayout();
            this.Panel_TopBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox_LogoSmall)).BeginInit();
            this.SuspendLayout();
            // 
            // TextBox_Username
            // 
            this.TextBox_Username.Location = new System.Drawing.Point(43, 257);
            this.TextBox_Username.Margin = new System.Windows.Forms.Padding(4);
            this.TextBox_Username.Name = "TextBox_Username";
            this.TextBox_Username.Size = new System.Drawing.Size(132, 22);
            this.TextBox_Username.TabIndex = 0;
            // 
            // TextBox_Password
            // 
            this.TextBox_Password.Location = new System.Drawing.Point(43, 343);
            this.TextBox_Password.Margin = new System.Windows.Forms.Padding(4);
            this.TextBox_Password.Name = "TextBox_Password";
            this.TextBox_Password.Size = new System.Drawing.Size(132, 22);
            this.TextBox_Password.TabIndex = 1;
            // 
            // Button_Login
            // 
            this.Button_Login.Location = new System.Drawing.Point(332, 431);
            this.Button_Login.Margin = new System.Windows.Forms.Padding(4);
            this.Button_Login.Name = "Button_Login";
            this.Button_Login.Size = new System.Drawing.Size(100, 28);
            this.Button_Login.TabIndex = 2;
            this.Button_Login.Text = "Login";
            this.Button_Login.UseVisualStyleBackColor = true;
            this.Button_Login.Click += new System.EventHandler(this.Button_Login_Click);
            // 
            // Button_Register
            // 
            this.Button_Register.Location = new System.Drawing.Point(332, 495);
            this.Button_Register.Margin = new System.Windows.Forms.Padding(4);
            this.Button_Register.Name = "Button_Register";
            this.Button_Register.Size = new System.Drawing.Size(100, 28);
            this.Button_Register.TabIndex = 3;
            this.Button_Register.Text = "Register";
            this.Button_Register.UseVisualStyleBackColor = true;
            this.Button_Register.Click += new System.EventHandler(this.Button_Register_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 222);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Username";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 322);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Password";
            // 
            // Panel_Login
            // 
            this.Panel_Login.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Panel_Login.Controls.Add(this.Label_LoginTitle);
            this.Panel_Login.Controls.Add(this.label1);
            this.Panel_Login.Controls.Add(this.Button_Login);
            this.Panel_Login.Controls.Add(this.Button_Register);
            this.Panel_Login.Controls.Add(this.label2);
            this.Panel_Login.Controls.Add(this.TextBox_Username);
            this.Panel_Login.Controls.Add(this.TextBox_Password);
            this.Panel_Login.Location = new System.Drawing.Point(0, 40);
            this.Panel_Login.MaximumSize = new System.Drawing.Size(608, 608);
            this.Panel_Login.MinimumSize = new System.Drawing.Size(608, 608);
            this.Panel_Login.Name = "Panel_Login";
            this.Panel_Login.Size = new System.Drawing.Size(608, 608);
            this.Panel_Login.TabIndex = 6;
            // 
            // Panel_Register
            // 
            this.Panel_Register.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Panel_Register.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(85)))), ((int)(((byte)(0)))));
            this.Panel_Register.Controls.Add(this.Label_Tracker);
            this.Panel_Register.Controls.Add(this.Label_Bug);
            this.Panel_Register.Location = new System.Drawing.Point(608, 40);
            this.Panel_Register.MaximumSize = new System.Drawing.Size(608, 608);
            this.Panel_Register.MinimumSize = new System.Drawing.Size(608, 608);
            this.Panel_Register.Name = "Panel_Register";
            this.Panel_Register.Size = new System.Drawing.Size(608, 608);
            this.Panel_Register.TabIndex = 7;
            // 
            // Panel_TopBar
            // 
            this.Panel_TopBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Panel_TopBar.Controls.Add(this.label3);
            this.Panel_TopBar.Controls.Add(this.PictureBox_LogoSmall);
            this.Panel_TopBar.Controls.Add(this.Button_Minimize);
            this.Panel_TopBar.Controls.Add(this.Button_Maximize);
            this.Panel_TopBar.Controls.Add(this.Button_Close);
            this.Panel_TopBar.Location = new System.Drawing.Point(0, 0);
            this.Panel_TopBar.MaximumSize = new System.Drawing.Size(1216, 40);
            this.Panel_TopBar.MinimumSize = new System.Drawing.Size(1216, 40);
            this.Panel_TopBar.Name = "Panel_TopBar";
            this.Panel_TopBar.Size = new System.Drawing.Size(1216, 40);
            this.Panel_TopBar.TabIndex = 8;
            this.Panel_TopBar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Panel_TopBar_MouseMove);
            // 
            // PictureBox_LogoSmall
            // 
            this.PictureBox_LogoSmall.BackgroundImage = global::Bugtracker.Properties.Resources.bt_logo_small;
            this.PictureBox_LogoSmall.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.PictureBox_LogoSmall.Location = new System.Drawing.Point(0, 0);
            this.PictureBox_LogoSmall.Margin = new System.Windows.Forms.Padding(0);
            this.PictureBox_LogoSmall.Name = "PictureBox_LogoSmall";
            this.PictureBox_LogoSmall.Size = new System.Drawing.Size(40, 40);
            this.PictureBox_LogoSmall.TabIndex = 3;
            this.PictureBox_LogoSmall.TabStop = false;
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
            this.Button_Minimize.Location = new System.Drawing.Point(1096, 0);
            this.Button_Minimize.Margin = new System.Windows.Forms.Padding(0);
            this.Button_Minimize.Name = "Button_Minimize";
            this.Button_Minimize.Size = new System.Drawing.Size(40, 40);
            this.Button_Minimize.TabIndex = 2;
            this.ToolTip.SetToolTip(this.Button_Minimize, "Minimize");
            this.Button_Minimize.UseVisualStyleBackColor = false;
            this.Button_Minimize.Click += new System.EventHandler(this.Button_Minimize_Click);
            // 
            // Button_Maximize
            // 
            this.Button_Maximize.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Button_Maximize.BackColor = System.Drawing.Color.Transparent;
            this.Button_Maximize.BackgroundImage = global::Bugtracker.Properties.Resources.bt_maximize_disabled;
            this.Button_Maximize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Button_Maximize.FlatAppearance.BorderSize = 0;
            this.Button_Maximize.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(154)))), ((int)(((byte)(110)))));
            this.Button_Maximize.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(223)))), ((int)(((byte)(223)))));
            this.Button_Maximize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_Maximize.Location = new System.Drawing.Point(1136, 0);
            this.Button_Maximize.Margin = new System.Windows.Forms.Padding(0);
            this.Button_Maximize.Name = "Button_Maximize";
            this.Button_Maximize.Size = new System.Drawing.Size(40, 40);
            this.Button_Maximize.TabIndex = 1;
            this.ToolTip.SetToolTip(this.Button_Maximize, "Maximize");
            this.Button_Maximize.UseVisualStyleBackColor = false;
            this.Button_Maximize.Click += new System.EventHandler(this.Button_Maximize_Click);
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
            this.Button_Close.Location = new System.Drawing.Point(1176, 0);
            this.Button_Close.Margin = new System.Windows.Forms.Padding(0);
            this.Button_Close.Name = "Button_Close";
            this.Button_Close.Size = new System.Drawing.Size(40, 40);
            this.Button_Close.TabIndex = 0;
            this.ToolTip.SetToolTip(this.Button_Close, "Close");
            this.Button_Close.UseVisualStyleBackColor = false;
            this.Button_Close.Click += new System.EventHandler(this.Button_Close_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(82)))), ((int)(((byte)(82)))));
            this.label3.Location = new System.Drawing.Point(40, 11);
            this.label3.Margin = new System.Windows.Forms.Padding(0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 18);
            this.label3.TabIndex = 4;
            this.label3.Text = "BugTracker";
            // 
            // Label_LoginTitle
            // 
            this.Label_LoginTitle.AutoSize = true;
            this.Label_LoginTitle.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold);
            this.Label_LoginTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(82)))), ((int)(((byte)(82)))));
            this.Label_LoginTitle.Location = new System.Drawing.Point(35, 81);
            this.Label_LoginTitle.Name = "Label_LoginTitle";
            this.Label_LoginTitle.Size = new System.Drawing.Size(126, 46);
            this.Label_LoginTitle.TabIndex = 6;
            this.Label_LoginTitle.Text = "Login";
            // 
            // Label_Bug
            // 
            this.Label_Bug.AutoSize = true;
            this.Label_Bug.Font = new System.Drawing.Font("Arial", 64F, System.Drawing.FontStyle.Bold);
            this.Label_Bug.ForeColor = System.Drawing.Color.White;
            this.Label_Bug.Location = new System.Drawing.Point(0, 360);
            this.Label_Bug.Margin = new System.Windows.Forms.Padding(0);
            this.Label_Bug.Name = "Label_Bug";
            this.Label_Bug.Size = new System.Drawing.Size(289, 124);
            this.Label_Bug.TabIndex = 7;
            this.Label_Bug.Text = "BUG";
            // 
            // Label_Tracker
            // 
            this.Label_Tracker.AutoSize = true;
            this.Label_Tracker.Font = new System.Drawing.Font("Arial", 64F, System.Drawing.FontStyle.Bold);
            this.Label_Tracker.ForeColor = System.Drawing.Color.White;
            this.Label_Tracker.Location = new System.Drawing.Point(0, 484);
            this.Label_Tracker.Margin = new System.Windows.Forms.Padding(0);
            this.Label_Tracker.Name = "Label_Tracker";
            this.Label_Tracker.Size = new System.Drawing.Size(570, 124);
            this.Label_Tracker.TabIndex = 8;
            this.Label_Tracker.Text = "TRACKER";
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1216, 648);
            this.Controls.Add(this.Panel_TopBar);
            this.Controls.Add(this.Panel_Register);
            this.Controls.Add(this.Panel_Login);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximumSize = new System.Drawing.Size(1216, 648);
            this.MinimumSize = new System.Drawing.Size(1216, 648);
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LoginForm";
            this.Panel_Login.ResumeLayout(false);
            this.Panel_Login.PerformLayout();
            this.Panel_Register.ResumeLayout(false);
            this.Panel_Register.PerformLayout();
            this.Panel_TopBar.ResumeLayout(false);
            this.Panel_TopBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox_LogoSmall)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox TextBox_Username;
        private System.Windows.Forms.TextBox TextBox_Password;
        private System.Windows.Forms.Button Button_Login;
        private System.Windows.Forms.Button Button_Register;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel Panel_Login;
        private System.Windows.Forms.Panel Panel_Register;
        private System.Windows.Forms.Panel Panel_TopBar;
        private System.Windows.Forms.Button Button_Maximize;
        private System.Windows.Forms.Button Button_Minimize;
        private System.Windows.Forms.Button Button_Close;
        private System.Windows.Forms.ToolTip ToolTip;
        private System.Windows.Forms.PictureBox PictureBox_LogoSmall;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label Label_LoginTitle;
        private System.Windows.Forms.Label Label_Bug;
        private System.Windows.Forms.Label Label_Tracker;
    }
}