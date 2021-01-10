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
            this.Button_Login = new System.Windows.Forms.Button();
            this.Button_Register = new System.Windows.Forms.Button();
            this.Panel_Login = new System.Windows.Forms.Panel();
            this.Label_NoAccount = new System.Windows.Forms.Label();
            this.Label_PasswordSeparator = new System.Windows.Forms.Label();
            this.TextBox_Password = new System.Windows.Forms.TextBox();
            this.Label_Password = new System.Windows.Forms.Label();
            this.Label_UsernameSeparator = new System.Windows.Forms.Label();
            this.Label_Username = new System.Windows.Forms.Label();
            this.Label_LoginTitle = new System.Windows.Forms.Label();
            this.Panel_Slider = new System.Windows.Forms.Panel();
            this.Label_Tracker = new System.Windows.Forms.Label();
            this.Label_Bug = new System.Windows.Forms.Label();
            this.Panel_TopBar = new System.Windows.Forms.Panel();
            this.Label_Title = new System.Windows.Forms.Label();
            this.ToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.Label_ForgotPassword = new System.Windows.Forms.Label();
            this.Button_Reset = new System.Windows.Forms.Button();
            this.PictureBox_LogoSmall = new System.Windows.Forms.PictureBox();
            this.Button_Minimize = new System.Windows.Forms.Button();
            this.Button_Maximize = new System.Windows.Forms.Button();
            this.Button_Close = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Button_PasswordVisibility = new System.Windows.Forms.Button();
            this.Panel_Login.SuspendLayout();
            this.Panel_Slider.SuspendLayout();
            this.Panel_TopBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox_LogoSmall)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // TextBox_Username
            // 
            this.TextBox_Username.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TextBox_Username.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.TextBox_Username.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(85)))), ((int)(((byte)(0)))));
            this.TextBox_Username.Location = new System.Drawing.Point(32, 164);
            this.TextBox_Username.Margin = new System.Windows.Forms.Padding(32, 3, 32, 3);
            this.TextBox_Username.Name = "TextBox_Username";
            this.TextBox_Username.Size = new System.Drawing.Size(389, 19);
            this.TextBox_Username.TabIndex = 0;
            // 
            // Button_Login
            // 
            this.Button_Login.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(85)))), ((int)(((byte)(0)))));
            this.Button_Login.FlatAppearance.BorderSize = 0;
            this.Button_Login.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(186)))), ((int)(((byte)(131)))));
            this.Button_Login.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(174)))), ((int)(((byte)(71)))));
            this.Button_Login.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_Login.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.Button_Login.ForeColor = System.Drawing.Color.White;
            this.Button_Login.Location = new System.Drawing.Point(32, 397);
            this.Button_Login.Name = "Button_Login";
            this.Button_Login.Size = new System.Drawing.Size(389, 26);
            this.Button_Login.TabIndex = 2;
            this.Button_Login.Text = "Login";
            this.Button_Login.UseVisualStyleBackColor = false;
            this.Button_Login.Click += new System.EventHandler(this.Button_Login_Click);
            // 
            // Button_Register
            // 
            this.Button_Register.AutoSize = true;
            this.Button_Register.BackColor = System.Drawing.Color.Transparent;
            this.Button_Register.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Button_Register.FlatAppearance.BorderSize = 0;
            this.Button_Register.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.Button_Register.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.Button_Register.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_Register.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.Button_Register.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(85)))), ((int)(((byte)(0)))));
            this.Button_Register.Location = new System.Drawing.Point(202, 453);
            this.Button_Register.Margin = new System.Windows.Forms.Padding(0);
            this.Button_Register.Name = "Button_Register";
            this.Button_Register.Size = new System.Drawing.Size(78, 26);
            this.Button_Register.TabIndex = 0;
            this.Button_Register.TabStop = false;
            this.Button_Register.Text = "Register";
            this.Button_Register.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ToolTip.SetToolTip(this.Button_Register, "Create a new account");
            this.Button_Register.UseVisualStyleBackColor = false;
            this.Button_Register.Click += new System.EventHandler(this.Button_Register_Click);
            // 
            // Panel_Login
            // 
            this.Panel_Login.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Panel_Login.Controls.Add(this.Button_PasswordVisibility);
            this.Panel_Login.Controls.Add(this.Button_Reset);
            this.Panel_Login.Controls.Add(this.Label_ForgotPassword);
            this.Panel_Login.Controls.Add(this.Label_NoAccount);
            this.Panel_Login.Controls.Add(this.Label_PasswordSeparator);
            this.Panel_Login.Controls.Add(this.TextBox_Password);
            this.Panel_Login.Controls.Add(this.Label_Password);
            this.Panel_Login.Controls.Add(this.Label_UsernameSeparator);
            this.Panel_Login.Controls.Add(this.Label_Username);
            this.Panel_Login.Controls.Add(this.Label_LoginTitle);
            this.Panel_Login.Controls.Add(this.Button_Login);
            this.Panel_Login.Controls.Add(this.Button_Register);
            this.Panel_Login.Controls.Add(this.TextBox_Username);
            this.Panel_Login.Location = new System.Drawing.Point(0, 32);
            this.Panel_Login.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Panel_Login.MaximumSize = new System.Drawing.Size(456, 494);
            this.Panel_Login.MinimumSize = new System.Drawing.Size(456, 494);
            this.Panel_Login.Name = "Panel_Login";
            this.Panel_Login.Size = new System.Drawing.Size(456, 494);
            this.Panel_Login.TabIndex = 6;
            // 
            // Label_NoAccount
            // 
            this.Label_NoAccount.AutoSize = true;
            this.Label_NoAccount.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.Label_NoAccount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(119)))), ((int)(((byte)(136)))));
            this.Label_NoAccount.Location = new System.Drawing.Point(29, 458);
            this.Label_NoAccount.Margin = new System.Windows.Forms.Padding(29, 32, 0, 0);
            this.Label_NoAccount.Name = "Label_NoAccount";
            this.Label_NoAccount.Size = new System.Drawing.Size(173, 16);
            this.Label_NoAccount.TabIndex = 42;
            this.Label_NoAccount.Text = "Don\'t have an account?";
            // 
            // Label_PasswordSeparator
            // 
            this.Label_PasswordSeparator.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.Label_PasswordSeparator.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Label_PasswordSeparator.Location = new System.Drawing.Point(32, 278);
            this.Label_PasswordSeparator.Margin = new System.Windows.Forms.Padding(32, 3, 32, 0);
            this.Label_PasswordSeparator.Name = "Label_PasswordSeparator";
            this.Label_PasswordSeparator.Size = new System.Drawing.Size(389, 2);
            this.Label_PasswordSeparator.TabIndex = 41;
            // 
            // TextBox_Password
            // 
            this.TextBox_Password.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TextBox_Password.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.TextBox_Password.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(85)))), ((int)(((byte)(0)))));
            this.TextBox_Password.Location = new System.Drawing.Point(32, 253);
            this.TextBox_Password.Margin = new System.Windows.Forms.Padding(32, 3, 32, 3);
            this.TextBox_Password.Name = "TextBox_Password";
            this.TextBox_Password.Size = new System.Drawing.Size(389, 19);
            this.TextBox_Password.TabIndex = 1;
            this.TextBox_Password.UseSystemPasswordChar = true;
            this.TextBox_Password.TextChanged += new System.EventHandler(this.TextBox_Password_TextChanged);
            this.TextBox_Password.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TextBox_Password_KeyDown);
            // 
            // Label_Password
            // 
            this.Label_Password.AutoSize = true;
            this.Label_Password.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.Label_Password.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(82)))), ((int)(((byte)(82)))));
            this.Label_Password.Location = new System.Drawing.Point(29, 223);
            this.Label_Password.Margin = new System.Windows.Forms.Padding(29, 32, 0, 6);
            this.Label_Password.Name = "Label_Password";
            this.Label_Password.Size = new System.Drawing.Size(86, 19);
            this.Label_Password.TabIndex = 39;
            this.Label_Password.Text = "Password";
            // 
            // Label_UsernameSeparator
            // 
            this.Label_UsernameSeparator.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.Label_UsernameSeparator.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Label_UsernameSeparator.Location = new System.Drawing.Point(32, 189);
            this.Label_UsernameSeparator.Margin = new System.Windows.Forms.Padding(32, 3, 32, 0);
            this.Label_UsernameSeparator.Name = "Label_UsernameSeparator";
            this.Label_UsernameSeparator.Size = new System.Drawing.Size(389, 2);
            this.Label_UsernameSeparator.TabIndex = 38;
            // 
            // Label_Username
            // 
            this.Label_Username.AutoSize = true;
            this.Label_Username.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.Label_Username.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(82)))), ((int)(((byte)(82)))));
            this.Label_Username.Location = new System.Drawing.Point(29, 135);
            this.Label_Username.Margin = new System.Windows.Forms.Padding(29, 32, 0, 6);
            this.Label_Username.Name = "Label_Username";
            this.Label_Username.Size = new System.Drawing.Size(87, 19);
            this.Label_Username.TabIndex = 5;
            this.Label_Username.Text = "Username";
            // 
            // Label_LoginTitle
            // 
            this.Label_LoginTitle.AutoSize = true;
            this.Label_LoginTitle.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold);
            this.Label_LoginTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(82)))), ((int)(((byte)(82)))));
            this.Label_LoginTitle.Location = new System.Drawing.Point(26, 65);
            this.Label_LoginTitle.Margin = new System.Windows.Forms.Padding(26, 65, 0, 0);
            this.Label_LoginTitle.Name = "Label_LoginTitle";
            this.Label_LoginTitle.Size = new System.Drawing.Size(104, 37);
            this.Label_LoginTitle.TabIndex = 6;
            this.Label_LoginTitle.Text = "Login";
            // 
            // Panel_Slider
            // 
            this.Panel_Slider.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Panel_Slider.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(85)))), ((int)(((byte)(0)))));
            this.Panel_Slider.Controls.Add(this.pictureBox1);
            this.Panel_Slider.Controls.Add(this.Label_Tracker);
            this.Panel_Slider.Controls.Add(this.Label_Bug);
            this.Panel_Slider.Location = new System.Drawing.Point(456, 32);
            this.Panel_Slider.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Panel_Slider.MaximumSize = new System.Drawing.Size(456, 494);
            this.Panel_Slider.MinimumSize = new System.Drawing.Size(456, 494);
            this.Panel_Slider.Name = "Panel_Slider";
            this.Panel_Slider.Size = new System.Drawing.Size(456, 494);
            this.Panel_Slider.TabIndex = 7;
            // 
            // Label_Tracker
            // 
            this.Label_Tracker.AutoSize = true;
            this.Label_Tracker.Font = new System.Drawing.Font("Arial", 64F, System.Drawing.FontStyle.Bold);
            this.Label_Tracker.ForeColor = System.Drawing.Color.White;
            this.Label_Tracker.Location = new System.Drawing.Point(0, 393);
            this.Label_Tracker.Margin = new System.Windows.Forms.Padding(0);
            this.Label_Tracker.Name = "Label_Tracker";
            this.Label_Tracker.Size = new System.Drawing.Size(458, 99);
            this.Label_Tracker.TabIndex = 8;
            this.Label_Tracker.Text = "TRACKER";
            // 
            // Label_Bug
            // 
            this.Label_Bug.AutoSize = true;
            this.Label_Bug.Font = new System.Drawing.Font("Arial", 64F, System.Drawing.FontStyle.Bold);
            this.Label_Bug.ForeColor = System.Drawing.Color.White;
            this.Label_Bug.Location = new System.Drawing.Point(112, 292);
            this.Label_Bug.Margin = new System.Windows.Forms.Padding(0);
            this.Label_Bug.Name = "Label_Bug";
            this.Label_Bug.Size = new System.Drawing.Size(233, 99);
            this.Label_Bug.TabIndex = 7;
            this.Label_Bug.Text = "BUG";
            // 
            // Panel_TopBar
            // 
            this.Panel_TopBar.Controls.Add(this.Label_Title);
            this.Panel_TopBar.Controls.Add(this.PictureBox_LogoSmall);
            this.Panel_TopBar.Controls.Add(this.Button_Minimize);
            this.Panel_TopBar.Controls.Add(this.Button_Maximize);
            this.Panel_TopBar.Controls.Add(this.Button_Close);
            this.Panel_TopBar.Location = new System.Drawing.Point(0, 0);
            this.Panel_TopBar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Panel_TopBar.MaximumSize = new System.Drawing.Size(912, 32);
            this.Panel_TopBar.MinimumSize = new System.Drawing.Size(912, 32);
            this.Panel_TopBar.Name = "Panel_TopBar";
            this.Panel_TopBar.Size = new System.Drawing.Size(912, 32);
            this.Panel_TopBar.TabIndex = 8;
            this.Panel_TopBar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Panel_TopBar_MouseMove);
            // 
            // Label_Title
            // 
            this.Label_Title.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.Label_Title.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(82)))), ((int)(((byte)(82)))));
            this.Label_Title.Location = new System.Drawing.Point(30, 0);
            this.Label_Title.Margin = new System.Windows.Forms.Padding(0);
            this.Label_Title.Name = "Label_Title";
            this.Label_Title.Size = new System.Drawing.Size(76, 32);
            this.Label_Title.TabIndex = 4;
            this.Label_Title.Text = "BugTracker";
            this.Label_Title.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Label_ForgotPassword
            // 
            this.Label_ForgotPassword.AutoSize = true;
            this.Label_ForgotPassword.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.Label_ForgotPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(119)))), ((int)(((byte)(136)))));
            this.Label_ForgotPassword.Location = new System.Drawing.Point(29, 312);
            this.Label_ForgotPassword.Margin = new System.Windows.Forms.Padding(29, 32, 0, 0);
            this.Label_ForgotPassword.Name = "Label_ForgotPassword";
            this.Label_ForgotPassword.Size = new System.Drawing.Size(171, 16);
            this.Label_ForgotPassword.TabIndex = 43;
            this.Label_ForgotPassword.Text = "Forgot your password?";
            // 
            // Button_Reset
            // 
            this.Button_Reset.AutoSize = true;
            this.Button_Reset.BackColor = System.Drawing.Color.Transparent;
            this.Button_Reset.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Button_Reset.FlatAppearance.BorderSize = 0;
            this.Button_Reset.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.Button_Reset.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.Button_Reset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_Reset.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.Button_Reset.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(85)))), ((int)(((byte)(0)))));
            this.Button_Reset.Location = new System.Drawing.Point(202, 307);
            this.Button_Reset.Margin = new System.Windows.Forms.Padding(0);
            this.Button_Reset.Name = "Button_Reset";
            this.Button_Reset.Size = new System.Drawing.Size(78, 26);
            this.Button_Reset.TabIndex = 0;
            this.Button_Reset.TabStop = false;
            this.Button_Reset.Text = "Reset";
            this.Button_Reset.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ToolTip.SetToolTip(this.Button_Reset, "Reset your password");
            this.Button_Reset.UseVisualStyleBackColor = false;
            // 
            // PictureBox_LogoSmall
            // 
            this.PictureBox_LogoSmall.BackgroundImage = global::Bugtracker.Properties.Resources.bt_logo_small;
            this.PictureBox_LogoSmall.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.PictureBox_LogoSmall.Location = new System.Drawing.Point(0, 0);
            this.PictureBox_LogoSmall.Margin = new System.Windows.Forms.Padding(0);
            this.PictureBox_LogoSmall.Name = "PictureBox_LogoSmall";
            this.PictureBox_LogoSmall.Size = new System.Drawing.Size(30, 32);
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
            this.Button_Minimize.Location = new System.Drawing.Point(822, 0);
            this.Button_Minimize.Margin = new System.Windows.Forms.Padding(0);
            this.Button_Minimize.Name = "Button_Minimize";
            this.Button_Minimize.Size = new System.Drawing.Size(30, 32);
            this.Button_Minimize.TabIndex = 2;
            this.Button_Minimize.TabStop = false;
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
            this.Button_Maximize.Location = new System.Drawing.Point(852, 0);
            this.Button_Maximize.Margin = new System.Windows.Forms.Padding(0);
            this.Button_Maximize.Name = "Button_Maximize";
            this.Button_Maximize.Size = new System.Drawing.Size(30, 32);
            this.Button_Maximize.TabIndex = 1;
            this.Button_Maximize.TabStop = false;
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
            this.Button_Close.Location = new System.Drawing.Point(882, 0);
            this.Button_Close.Margin = new System.Windows.Forms.Padding(0);
            this.Button_Close.Name = "Button_Close";
            this.Button_Close.Size = new System.Drawing.Size(30, 32);
            this.Button_Close.TabIndex = 0;
            this.Button_Close.TabStop = false;
            this.ToolTip.SetToolTip(this.Button_Close, "Close");
            this.Button_Close.UseVisualStyleBackColor = false;
            this.Button_Close.Click += new System.EventHandler(this.Button_Close_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(16, 289);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(96, 104);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // Button_PasswordVisibility
            // 
            this.Button_PasswordVisibility.BackgroundImage = global::Bugtracker.Properties.Resources.bt_pass_show;
            this.Button_PasswordVisibility.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Button_PasswordVisibility.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Button_PasswordVisibility.FlatAppearance.BorderSize = 0;
            this.Button_PasswordVisibility.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.Button_PasswordVisibility.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.Button_PasswordVisibility.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_PasswordVisibility.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_PasswordVisibility.Location = new System.Drawing.Point(389, 246);
            this.Button_PasswordVisibility.Name = "Button_PasswordVisibility";
            this.Button_PasswordVisibility.Size = new System.Drawing.Size(32, 32);
            this.Button_PasswordVisibility.TabIndex = 0;
            this.Button_PasswordVisibility.TabStop = false;
            this.Button_PasswordVisibility.UseVisualStyleBackColor = false;
            this.Button_PasswordVisibility.Visible = false;
            this.Button_PasswordVisibility.Click += new System.EventHandler(this.Button_PasswordVisibility_Click);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(912, 526);
            this.Controls.Add(this.Panel_TopBar);
            this.Controls.Add(this.Panel_Slider);
            this.Controls.Add(this.Panel_Login);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(912, 526);
            this.MinimumSize = new System.Drawing.Size(912, 526);
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LoginForm";
            this.Panel_Login.ResumeLayout(false);
            this.Panel_Login.PerformLayout();
            this.Panel_Slider.ResumeLayout(false);
            this.Panel_Slider.PerformLayout();
            this.Panel_TopBar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox_LogoSmall)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox TextBox_Username;
        private System.Windows.Forms.Button Button_Login;
        private System.Windows.Forms.Button Button_Register;
        private System.Windows.Forms.Panel Panel_Login;
        private System.Windows.Forms.Panel Panel_Slider;
        private System.Windows.Forms.Panel Panel_TopBar;
        private System.Windows.Forms.Button Button_Maximize;
        private System.Windows.Forms.Button Button_Minimize;
        private System.Windows.Forms.Button Button_Close;
        private System.Windows.Forms.ToolTip ToolTip;
        private System.Windows.Forms.PictureBox PictureBox_LogoSmall;
        private System.Windows.Forms.Label Label_Title;
        private System.Windows.Forms.Label Label_LoginTitle;
        private System.Windows.Forms.Label Label_Bug;
        private System.Windows.Forms.Label Label_Tracker;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label Label_Username;
        private System.Windows.Forms.Label Label_UsernameSeparator;
        private System.Windows.Forms.Label Label_PasswordSeparator;
        private System.Windows.Forms.TextBox TextBox_Password;
        private System.Windows.Forms.Label Label_Password;
        private System.Windows.Forms.Label Label_NoAccount;
        private System.Windows.Forms.Label Label_ForgotPassword;
        private System.Windows.Forms.Button Button_Reset;
        private System.Windows.Forms.Button Button_PasswordVisibility;
    }
}