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
            this.TextBox_LoginUsername = new System.Windows.Forms.TextBox();
            this.Button_Login = new System.Windows.Forms.Button();
            this.Button_GoToRegister = new System.Windows.Forms.Button();
            this.Panel_Login = new System.Windows.Forms.Panel();
            this.Button_Reset = new System.Windows.Forms.Button();
            this.Label_ForgotPassword = new System.Windows.Forms.Label();
            this.Label_NoAccount = new System.Windows.Forms.Label();
            this.Label_LoginPasswordSeparator = new System.Windows.Forms.Label();
            this.TextBox_LoginPassword = new System.Windows.Forms.TextBox();
            this.Label_LoginPassword = new System.Windows.Forms.Label();
            this.Label_LoginUsernameSeparator = new System.Windows.Forms.Label();
            this.Label_LoginUsername = new System.Windows.Forms.Label();
            this.Label_LoginTitle = new System.Windows.Forms.Label();
            this.Panel_TopBar = new System.Windows.Forms.Panel();
            this.Label_Title = new System.Windows.Forms.Label();
            this.ToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.Button_GoToLogin = new System.Windows.Forms.Button();
            this.Panel_Registration = new System.Windows.Forms.Panel();
            this.Label_RegisterEmailSeparator = new System.Windows.Forms.Label();
            this.TextBox_RegisterEmail = new System.Windows.Forms.TextBox();
            this.Label_RegisterEmail = new System.Windows.Forms.Label();
            this.Label_HaveAccount = new System.Windows.Forms.Label();
            this.Label_RegisterPasswordSeparator = new System.Windows.Forms.Label();
            this.TextBox_RegisterPassword = new System.Windows.Forms.TextBox();
            this.Label_RegisterPassword = new System.Windows.Forms.Label();
            this.Label_RegisterUsernameSeparator = new System.Windows.Forms.Label();
            this.Label_RegisterUsername = new System.Windows.Forms.Label();
            this.Label_RegisterTitle = new System.Windows.Forms.Label();
            this.Button_Register = new System.Windows.Forms.Button();
            this.TextBox_RegisterUsername = new System.Windows.Forms.TextBox();
            this.PictureBox_RegisterEmail = new System.Windows.Forms.PictureBox();
            this.PictureBox_RegisterPassword = new System.Windows.Forms.PictureBox();
            this.PictureBox_RegisterUsername = new System.Windows.Forms.PictureBox();
            this.Button_RegisterPasswordVisibility = new System.Windows.Forms.Button();
            this.Button_RegisterMinimize = new System.Windows.Forms.Button();
            this.Button_RegisterClose = new System.Windows.Forms.Button();
            this.PictureBox_LogoSmall = new System.Windows.Forms.PictureBox();
            this.Button_LoginMinimize = new System.Windows.Forms.Button();
            this.Button_LoginClose = new System.Windows.Forms.Button();
            this.PictureBox_LoginPassword = new System.Windows.Forms.PictureBox();
            this.PictureBox_LoginUsername = new System.Windows.Forms.PictureBox();
            this.Button_LoginPasswordVisibility = new System.Windows.Forms.Button();
            this.Panel_Login.SuspendLayout();
            this.Panel_TopBar.SuspendLayout();
            this.Panel_Registration.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox_RegisterEmail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox_RegisterPassword)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox_RegisterUsername)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox_LogoSmall)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox_LoginPassword)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox_LoginUsername)).BeginInit();
            this.SuspendLayout();
            // 
            // TextBox_LoginUsername
            // 
            this.TextBox_LoginUsername.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TextBox_LoginUsername.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.TextBox_LoginUsername.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(85)))), ((int)(((byte)(0)))));
            this.TextBox_LoginUsername.Location = new System.Drawing.Point(65, 164);
            this.TextBox_LoginUsername.Margin = new System.Windows.Forms.Padding(32, 3, 32, 3);
            this.TextBox_LoginUsername.Name = "TextBox_LoginUsername";
            this.TextBox_LoginUsername.Size = new System.Drawing.Size(356, 19);
            this.TextBox_LoginUsername.TabIndex = 1;
            this.TextBox_LoginUsername.TabStop = false;
            this.TextBox_LoginUsername.Enter += new System.EventHandler(this.TextBox_LoginUsername_Enter);
            this.TextBox_LoginUsername.Leave += new System.EventHandler(this.TextBox_LoginUsername_Leave);
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
            this.Button_Login.TabIndex = 0;
            this.Button_Login.TabStop = false;
            this.Button_Login.Text = "Login";
            this.Button_Login.UseVisualStyleBackColor = false;
            this.Button_Login.Click += new System.EventHandler(this.Button_Login_Click);
            // 
            // Button_GoToRegister
            // 
            this.Button_GoToRegister.AutoSize = true;
            this.Button_GoToRegister.BackColor = System.Drawing.Color.Transparent;
            this.Button_GoToRegister.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Button_GoToRegister.FlatAppearance.BorderSize = 0;
            this.Button_GoToRegister.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.Button_GoToRegister.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.Button_GoToRegister.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_GoToRegister.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.Button_GoToRegister.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(85)))), ((int)(((byte)(0)))));
            this.Button_GoToRegister.Location = new System.Drawing.Point(202, 453);
            this.Button_GoToRegister.Margin = new System.Windows.Forms.Padding(0);
            this.Button_GoToRegister.Name = "Button_GoToRegister";
            this.Button_GoToRegister.Size = new System.Drawing.Size(78, 26);
            this.Button_GoToRegister.TabIndex = 0;
            this.Button_GoToRegister.TabStop = false;
            this.Button_GoToRegister.Text = "Register";
            this.Button_GoToRegister.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ToolTip.SetToolTip(this.Button_GoToRegister, "Create a new account");
            this.Button_GoToRegister.UseVisualStyleBackColor = false;
            this.Button_GoToRegister.Click += new System.EventHandler(this.Button_GoToRegister_Click);
            // 
            // Panel_Login
            // 
            this.Panel_Login.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Panel_Login.Controls.Add(this.PictureBox_LoginPassword);
            this.Panel_Login.Controls.Add(this.PictureBox_LoginUsername);
            this.Panel_Login.Controls.Add(this.Button_LoginPasswordVisibility);
            this.Panel_Login.Controls.Add(this.Button_Reset);
            this.Panel_Login.Controls.Add(this.Label_ForgotPassword);
            this.Panel_Login.Controls.Add(this.Label_NoAccount);
            this.Panel_Login.Controls.Add(this.Label_LoginPasswordSeparator);
            this.Panel_Login.Controls.Add(this.Label_LoginPassword);
            this.Panel_Login.Controls.Add(this.Label_LoginUsernameSeparator);
            this.Panel_Login.Controls.Add(this.Label_LoginUsername);
            this.Panel_Login.Controls.Add(this.Label_LoginTitle);
            this.Panel_Login.Controls.Add(this.Button_Login);
            this.Panel_Login.Controls.Add(this.Button_GoToRegister);
            this.Panel_Login.Controls.Add(this.TextBox_LoginUsername);
            this.Panel_Login.Controls.Add(this.TextBox_LoginPassword);
            this.Panel_Login.Location = new System.Drawing.Point(0, 32);
            this.Panel_Login.Margin = new System.Windows.Forms.Padding(2);
            this.Panel_Login.MaximumSize = new System.Drawing.Size(456, 494);
            this.Panel_Login.MinimumSize = new System.Drawing.Size(456, 494);
            this.Panel_Login.Name = "Panel_Login";
            this.Panel_Login.Size = new System.Drawing.Size(456, 494);
            this.Panel_Login.TabIndex = 6;
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
            // Label_LoginPasswordSeparator
            // 
            this.Label_LoginPasswordSeparator.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(119)))), ((int)(((byte)(136)))));
            this.Label_LoginPasswordSeparator.Location = new System.Drawing.Point(32, 278);
            this.Label_LoginPasswordSeparator.Margin = new System.Windows.Forms.Padding(32, 3, 32, 0);
            this.Label_LoginPasswordSeparator.Name = "Label_LoginPasswordSeparator";
            this.Label_LoginPasswordSeparator.Size = new System.Drawing.Size(389, 2);
            this.Label_LoginPasswordSeparator.TabIndex = 41;
            // 
            // TextBox_LoginPassword
            // 
            this.TextBox_LoginPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TextBox_LoginPassword.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.TextBox_LoginPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(85)))), ((int)(((byte)(0)))));
            this.TextBox_LoginPassword.Location = new System.Drawing.Point(65, 253);
            this.TextBox_LoginPassword.Margin = new System.Windows.Forms.Padding(32, 3, 32, 3);
            this.TextBox_LoginPassword.Name = "TextBox_LoginPassword";
            this.TextBox_LoginPassword.Size = new System.Drawing.Size(356, 19);
            this.TextBox_LoginPassword.TabIndex = 2;
            this.TextBox_LoginPassword.TabStop = false;
            this.TextBox_LoginPassword.UseSystemPasswordChar = true;
            this.TextBox_LoginPassword.TextChanged += new System.EventHandler(this.TextBox_Password_TextChanged);
            this.TextBox_LoginPassword.Enter += new System.EventHandler(this.TextBox_LoginPassword_Enter);
            this.TextBox_LoginPassword.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TextBox_Password_KeyDown);
            this.TextBox_LoginPassword.Leave += new System.EventHandler(this.TextBox_LoginPassword_Leave);
            // 
            // Label_LoginPassword
            // 
            this.Label_LoginPassword.AutoSize = true;
            this.Label_LoginPassword.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.Label_LoginPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(82)))), ((int)(((byte)(82)))));
            this.Label_LoginPassword.Location = new System.Drawing.Point(61, 255);
            this.Label_LoginPassword.Margin = new System.Windows.Forms.Padding(29, 32, 0, 6);
            this.Label_LoginPassword.Name = "Label_LoginPassword";
            this.Label_LoginPassword.Size = new System.Drawing.Size(86, 19);
            this.Label_LoginPassword.TabIndex = 39;
            this.Label_LoginPassword.Text = "Password";
            this.Label_LoginPassword.Click += new System.EventHandler(this.Label_LoginPassword_Click);
            // 
            // Label_LoginUsernameSeparator
            // 
            this.Label_LoginUsernameSeparator.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(119)))), ((int)(((byte)(136)))));
            this.Label_LoginUsernameSeparator.Location = new System.Drawing.Point(32, 189);
            this.Label_LoginUsernameSeparator.Margin = new System.Windows.Forms.Padding(32, 3, 32, 0);
            this.Label_LoginUsernameSeparator.Name = "Label_LoginUsernameSeparator";
            this.Label_LoginUsernameSeparator.Size = new System.Drawing.Size(389, 2);
            this.Label_LoginUsernameSeparator.TabIndex = 38;
            // 
            // Label_LoginUsername
            // 
            this.Label_LoginUsername.AutoSize = true;
            this.Label_LoginUsername.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.Label_LoginUsername.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(82)))), ((int)(((byte)(82)))));
            this.Label_LoginUsername.Location = new System.Drawing.Point(61, 164);
            this.Label_LoginUsername.Margin = new System.Windows.Forms.Padding(29, 32, 0, 6);
            this.Label_LoginUsername.Name = "Label_LoginUsername";
            this.Label_LoginUsername.Size = new System.Drawing.Size(87, 19);
            this.Label_LoginUsername.TabIndex = 5;
            this.Label_LoginUsername.Text = "Username";
            this.Label_LoginUsername.Click += new System.EventHandler(this.Label_LoginUsername_Click);
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
            // Panel_TopBar
            // 
            this.Panel_TopBar.Controls.Add(this.Button_RegisterMinimize);
            this.Panel_TopBar.Controls.Add(this.Button_RegisterClose);
            this.Panel_TopBar.Controls.Add(this.Label_Title);
            this.Panel_TopBar.Controls.Add(this.PictureBox_LogoSmall);
            this.Panel_TopBar.Controls.Add(this.Button_LoginMinimize);
            this.Panel_TopBar.Controls.Add(this.Button_LoginClose);
            this.Panel_TopBar.Location = new System.Drawing.Point(0, 0);
            this.Panel_TopBar.Margin = new System.Windows.Forms.Padding(2);
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
            // Button_GoToLogin
            // 
            this.Button_GoToLogin.AutoSize = true;
            this.Button_GoToLogin.BackColor = System.Drawing.Color.Transparent;
            this.Button_GoToLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Button_GoToLogin.FlatAppearance.BorderSize = 0;
            this.Button_GoToLogin.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.Button_GoToLogin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.Button_GoToLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_GoToLogin.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.Button_GoToLogin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(85)))), ((int)(((byte)(0)))));
            this.Button_GoToLogin.Location = new System.Drawing.Point(218, 453);
            this.Button_GoToLogin.Margin = new System.Windows.Forms.Padding(0);
            this.Button_GoToLogin.Name = "Button_GoToLogin";
            this.Button_GoToLogin.Size = new System.Drawing.Size(78, 26);
            this.Button_GoToLogin.TabIndex = 0;
            this.Button_GoToLogin.TabStop = false;
            this.Button_GoToLogin.Text = "Login";
            this.Button_GoToLogin.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ToolTip.SetToolTip(this.Button_GoToLogin, "Log into your account");
            this.Button_GoToLogin.UseVisualStyleBackColor = false;
            this.Button_GoToLogin.Click += new System.EventHandler(this.Button_GoToLogin_Click);
            // 
            // Panel_Registration
            // 
            this.Panel_Registration.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Panel_Registration.Controls.Add(this.PictureBox_RegisterEmail);
            this.Panel_Registration.Controls.Add(this.PictureBox_RegisterPassword);
            this.Panel_Registration.Controls.Add(this.PictureBox_RegisterUsername);
            this.Panel_Registration.Controls.Add(this.Label_RegisterEmailSeparator);
            this.Panel_Registration.Controls.Add(this.Label_RegisterEmail);
            this.Panel_Registration.Controls.Add(this.Button_RegisterPasswordVisibility);
            this.Panel_Registration.Controls.Add(this.Label_HaveAccount);
            this.Panel_Registration.Controls.Add(this.Label_RegisterPasswordSeparator);
            this.Panel_Registration.Controls.Add(this.Label_RegisterPassword);
            this.Panel_Registration.Controls.Add(this.Label_RegisterUsernameSeparator);
            this.Panel_Registration.Controls.Add(this.Label_RegisterUsername);
            this.Panel_Registration.Controls.Add(this.Label_RegisterTitle);
            this.Panel_Registration.Controls.Add(this.Button_Register);
            this.Panel_Registration.Controls.Add(this.Button_GoToLogin);
            this.Panel_Registration.Controls.Add(this.TextBox_RegisterUsername);
            this.Panel_Registration.Controls.Add(this.TextBox_RegisterPassword);
            this.Panel_Registration.Controls.Add(this.TextBox_RegisterEmail);
            this.Panel_Registration.Location = new System.Drawing.Point(456, 32);
            this.Panel_Registration.Margin = new System.Windows.Forms.Padding(2);
            this.Panel_Registration.MaximumSize = new System.Drawing.Size(456, 494);
            this.Panel_Registration.MinimumSize = new System.Drawing.Size(456, 494);
            this.Panel_Registration.Name = "Panel_Registration";
            this.Panel_Registration.Size = new System.Drawing.Size(456, 494);
            this.Panel_Registration.TabIndex = 44;
            // 
            // Label_RegisterEmailSeparator
            // 
            this.Label_RegisterEmailSeparator.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(119)))), ((int)(((byte)(136)))));
            this.Label_RegisterEmailSeparator.Location = new System.Drawing.Point(32, 365);
            this.Label_RegisterEmailSeparator.Margin = new System.Windows.Forms.Padding(32, 3, 32, 0);
            this.Label_RegisterEmailSeparator.Name = "Label_RegisterEmailSeparator";
            this.Label_RegisterEmailSeparator.Size = new System.Drawing.Size(389, 2);
            this.Label_RegisterEmailSeparator.TabIndex = 45;
            // 
            // TextBox_RegisterEmail
            // 
            this.TextBox_RegisterEmail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TextBox_RegisterEmail.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.TextBox_RegisterEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(85)))), ((int)(((byte)(0)))));
            this.TextBox_RegisterEmail.Location = new System.Drawing.Point(65, 340);
            this.TextBox_RegisterEmail.Margin = new System.Windows.Forms.Padding(32, 3, 32, 3);
            this.TextBox_RegisterEmail.Name = "TextBox_RegisterEmail";
            this.TextBox_RegisterEmail.Size = new System.Drawing.Size(356, 19);
            this.TextBox_RegisterEmail.TabIndex = 2;
            this.TextBox_RegisterEmail.TabStop = false;
            this.TextBox_RegisterEmail.Enter += new System.EventHandler(this.TextBox_RegisterEmail_Enter);
            this.TextBox_RegisterEmail.Leave += new System.EventHandler(this.TextBox_RegisterEmail_Leave);
            // 
            // Label_RegisterEmail
            // 
            this.Label_RegisterEmail.AutoSize = true;
            this.Label_RegisterEmail.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.Label_RegisterEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(82)))), ((int)(((byte)(82)))));
            this.Label_RegisterEmail.Location = new System.Drawing.Point(61, 340);
            this.Label_RegisterEmail.Margin = new System.Windows.Forms.Padding(29, 32, 0, 6);
            this.Label_RegisterEmail.Name = "Label_RegisterEmail";
            this.Label_RegisterEmail.Size = new System.Drawing.Size(51, 19);
            this.Label_RegisterEmail.TabIndex = 43;
            this.Label_RegisterEmail.Text = "Email";
            this.Label_RegisterEmail.Click += new System.EventHandler(this.Label_RegisterEmail_Click);
            // 
            // Label_HaveAccount
            // 
            this.Label_HaveAccount.AutoSize = true;
            this.Label_HaveAccount.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.Label_HaveAccount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(119)))), ((int)(((byte)(136)))));
            this.Label_HaveAccount.Location = new System.Drawing.Point(29, 458);
            this.Label_HaveAccount.Margin = new System.Windows.Forms.Padding(29, 32, 0, 0);
            this.Label_HaveAccount.Name = "Label_HaveAccount";
            this.Label_HaveAccount.Size = new System.Drawing.Size(189, 16);
            this.Label_HaveAccount.TabIndex = 42;
            this.Label_HaveAccount.Text = "Already have an account?";
            // 
            // Label_RegisterPasswordSeparator
            // 
            this.Label_RegisterPasswordSeparator.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(119)))), ((int)(((byte)(136)))));
            this.Label_RegisterPasswordSeparator.Location = new System.Drawing.Point(32, 278);
            this.Label_RegisterPasswordSeparator.Margin = new System.Windows.Forms.Padding(32, 3, 32, 0);
            this.Label_RegisterPasswordSeparator.Name = "Label_RegisterPasswordSeparator";
            this.Label_RegisterPasswordSeparator.Size = new System.Drawing.Size(389, 2);
            this.Label_RegisterPasswordSeparator.TabIndex = 41;
            // 
            // TextBox_RegisterPassword
            // 
            this.TextBox_RegisterPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TextBox_RegisterPassword.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.TextBox_RegisterPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(85)))), ((int)(((byte)(0)))));
            this.TextBox_RegisterPassword.Location = new System.Drawing.Point(65, 253);
            this.TextBox_RegisterPassword.Margin = new System.Windows.Forms.Padding(32, 3, 32, 3);
            this.TextBox_RegisterPassword.Name = "TextBox_RegisterPassword";
            this.TextBox_RegisterPassword.Size = new System.Drawing.Size(356, 19);
            this.TextBox_RegisterPassword.TabIndex = 1;
            this.TextBox_RegisterPassword.TabStop = false;
            this.TextBox_RegisterPassword.UseSystemPasswordChar = true;
            this.TextBox_RegisterPassword.TextChanged += new System.EventHandler(this.TextBox_RegisterPassword_TextChanged);
            this.TextBox_RegisterPassword.Enter += new System.EventHandler(this.TextBox_RegisterPassword_Enter);
            this.TextBox_RegisterPassword.Leave += new System.EventHandler(this.TextBox_RegisterPassword_Leave);
            // 
            // Label_RegisterPassword
            // 
            this.Label_RegisterPassword.AutoSize = true;
            this.Label_RegisterPassword.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.Label_RegisterPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(82)))), ((int)(((byte)(82)))));
            this.Label_RegisterPassword.Location = new System.Drawing.Point(61, 255);
            this.Label_RegisterPassword.Margin = new System.Windows.Forms.Padding(29, 32, 0, 6);
            this.Label_RegisterPassword.Name = "Label_RegisterPassword";
            this.Label_RegisterPassword.Size = new System.Drawing.Size(86, 19);
            this.Label_RegisterPassword.TabIndex = 39;
            this.Label_RegisterPassword.Text = "Password";
            this.Label_RegisterPassword.Click += new System.EventHandler(this.Label_RegisterPassword_Click);
            // 
            // Label_RegisterUsernameSeparator
            // 
            this.Label_RegisterUsernameSeparator.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(119)))), ((int)(((byte)(136)))));
            this.Label_RegisterUsernameSeparator.Location = new System.Drawing.Point(32, 189);
            this.Label_RegisterUsernameSeparator.Margin = new System.Windows.Forms.Padding(32, 3, 32, 0);
            this.Label_RegisterUsernameSeparator.Name = "Label_RegisterUsernameSeparator";
            this.Label_RegisterUsernameSeparator.Size = new System.Drawing.Size(389, 2);
            this.Label_RegisterUsernameSeparator.TabIndex = 38;
            // 
            // Label_RegisterUsername
            // 
            this.Label_RegisterUsername.AutoSize = true;
            this.Label_RegisterUsername.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.Label_RegisterUsername.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(82)))), ((int)(((byte)(82)))));
            this.Label_RegisterUsername.Location = new System.Drawing.Point(61, 164);
            this.Label_RegisterUsername.Margin = new System.Windows.Forms.Padding(29, 32, 0, 6);
            this.Label_RegisterUsername.Name = "Label_RegisterUsername";
            this.Label_RegisterUsername.Size = new System.Drawing.Size(87, 19);
            this.Label_RegisterUsername.TabIndex = 5;
            this.Label_RegisterUsername.Text = "Username";
            this.Label_RegisterUsername.Click += new System.EventHandler(this.Label_RegisterUsername_Click);
            // 
            // Label_RegisterTitle
            // 
            this.Label_RegisterTitle.AutoSize = true;
            this.Label_RegisterTitle.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold);
            this.Label_RegisterTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(82)))), ((int)(((byte)(82)))));
            this.Label_RegisterTitle.Location = new System.Drawing.Point(26, 65);
            this.Label_RegisterTitle.Margin = new System.Windows.Forms.Padding(26, 65, 0, 0);
            this.Label_RegisterTitle.Name = "Label_RegisterTitle";
            this.Label_RegisterTitle.Size = new System.Drawing.Size(146, 37);
            this.Label_RegisterTitle.TabIndex = 6;
            this.Label_RegisterTitle.Text = "Register";
            // 
            // Button_Register
            // 
            this.Button_Register.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(85)))), ((int)(((byte)(0)))));
            this.Button_Register.FlatAppearance.BorderSize = 0;
            this.Button_Register.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(186)))), ((int)(((byte)(131)))));
            this.Button_Register.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(174)))), ((int)(((byte)(71)))));
            this.Button_Register.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_Register.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.Button_Register.ForeColor = System.Drawing.Color.White;
            this.Button_Register.Location = new System.Drawing.Point(32, 397);
            this.Button_Register.Name = "Button_Register";
            this.Button_Register.Size = new System.Drawing.Size(389, 26);
            this.Button_Register.TabIndex = 3;
            this.Button_Register.TabStop = false;
            this.Button_Register.Text = "Create";
            this.Button_Register.UseVisualStyleBackColor = false;
            this.Button_Register.Click += new System.EventHandler(this.Button_Register_Click);
            // 
            // TextBox_RegisterUsername
            // 
            this.TextBox_RegisterUsername.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TextBox_RegisterUsername.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.TextBox_RegisterUsername.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(85)))), ((int)(((byte)(0)))));
            this.TextBox_RegisterUsername.Location = new System.Drawing.Point(65, 164);
            this.TextBox_RegisterUsername.Margin = new System.Windows.Forms.Padding(32, 3, 32, 3);
            this.TextBox_RegisterUsername.Name = "TextBox_RegisterUsername";
            this.TextBox_RegisterUsername.Size = new System.Drawing.Size(356, 19);
            this.TextBox_RegisterUsername.TabIndex = 0;
            this.TextBox_RegisterUsername.TabStop = false;
            this.TextBox_RegisterUsername.Enter += new System.EventHandler(this.TextBox_RegisterUsername_Enter);
            this.TextBox_RegisterUsername.Leave += new System.EventHandler(this.TextBox_RegisterUsername_Leave);
            // 
            // PictureBox_RegisterEmail
            // 
            this.PictureBox_RegisterEmail.BackgroundImage = global::Bugtracker.Properties.Resources.bt_login_email;
            this.PictureBox_RegisterEmail.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.PictureBox_RegisterEmail.Location = new System.Drawing.Point(32, 335);
            this.PictureBox_RegisterEmail.Margin = new System.Windows.Forms.Padding(0);
            this.PictureBox_RegisterEmail.Name = "PictureBox_RegisterEmail";
            this.PictureBox_RegisterEmail.Size = new System.Drawing.Size(30, 32);
            this.PictureBox_RegisterEmail.TabIndex = 47;
            this.PictureBox_RegisterEmail.TabStop = false;
            this.PictureBox_RegisterEmail.Click += new System.EventHandler(this.PictureBox_RegisterEmail_Click);
            // 
            // PictureBox_RegisterPassword
            // 
            this.PictureBox_RegisterPassword.BackgroundImage = global::Bugtracker.Properties.Resources.bt_login_password;
            this.PictureBox_RegisterPassword.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.PictureBox_RegisterPassword.Location = new System.Drawing.Point(32, 248);
            this.PictureBox_RegisterPassword.Margin = new System.Windows.Forms.Padding(0);
            this.PictureBox_RegisterPassword.Name = "PictureBox_RegisterPassword";
            this.PictureBox_RegisterPassword.Size = new System.Drawing.Size(30, 32);
            this.PictureBox_RegisterPassword.TabIndex = 46;
            this.PictureBox_RegisterPassword.TabStop = false;
            this.PictureBox_RegisterPassword.Click += new System.EventHandler(this.PictureBox_RegisterPassword_Click);
            // 
            // PictureBox_RegisterUsername
            // 
            this.PictureBox_RegisterUsername.BackgroundImage = global::Bugtracker.Properties.Resources.bt_login_username;
            this.PictureBox_RegisterUsername.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.PictureBox_RegisterUsername.Location = new System.Drawing.Point(32, 159);
            this.PictureBox_RegisterUsername.Margin = new System.Windows.Forms.Padding(0);
            this.PictureBox_RegisterUsername.Name = "PictureBox_RegisterUsername";
            this.PictureBox_RegisterUsername.Size = new System.Drawing.Size(30, 32);
            this.PictureBox_RegisterUsername.TabIndex = 45;
            this.PictureBox_RegisterUsername.TabStop = false;
            this.PictureBox_RegisterUsername.Click += new System.EventHandler(this.PictureBox_RegisterUsername_Click);
            // 
            // Button_RegisterPasswordVisibility
            // 
            this.Button_RegisterPasswordVisibility.BackgroundImage = global::Bugtracker.Properties.Resources.bt_pass_show;
            this.Button_RegisterPasswordVisibility.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Button_RegisterPasswordVisibility.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Button_RegisterPasswordVisibility.FlatAppearance.BorderSize = 0;
            this.Button_RegisterPasswordVisibility.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.Button_RegisterPasswordVisibility.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.Button_RegisterPasswordVisibility.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_RegisterPasswordVisibility.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_RegisterPasswordVisibility.Location = new System.Drawing.Point(389, 246);
            this.Button_RegisterPasswordVisibility.Name = "Button_RegisterPasswordVisibility";
            this.Button_RegisterPasswordVisibility.Size = new System.Drawing.Size(32, 32);
            this.Button_RegisterPasswordVisibility.TabIndex = 0;
            this.Button_RegisterPasswordVisibility.TabStop = false;
            this.Button_RegisterPasswordVisibility.UseVisualStyleBackColor = false;
            this.Button_RegisterPasswordVisibility.Visible = false;
            this.Button_RegisterPasswordVisibility.Click += new System.EventHandler(this.Button_RegisterPasswordVisibility_Click);
            // 
            // Button_RegisterMinimize
            // 
            this.Button_RegisterMinimize.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Button_RegisterMinimize.BackColor = System.Drawing.Color.Transparent;
            this.Button_RegisterMinimize.BackgroundImage = global::Bugtracker.Properties.Resources.bt_minimize;
            this.Button_RegisterMinimize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Button_RegisterMinimize.FlatAppearance.BorderSize = 0;
            this.Button_RegisterMinimize.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(154)))), ((int)(((byte)(110)))));
            this.Button_RegisterMinimize.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(223)))), ((int)(((byte)(223)))));
            this.Button_RegisterMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_RegisterMinimize.Location = new System.Drawing.Point(852, 0);
            this.Button_RegisterMinimize.Margin = new System.Windows.Forms.Padding(0);
            this.Button_RegisterMinimize.Name = "Button_RegisterMinimize";
            this.Button_RegisterMinimize.Size = new System.Drawing.Size(30, 32);
            this.Button_RegisterMinimize.TabIndex = 6;
            this.Button_RegisterMinimize.TabStop = false;
            this.ToolTip.SetToolTip(this.Button_RegisterMinimize, "Minimize");
            this.Button_RegisterMinimize.UseVisualStyleBackColor = false;
            this.Button_RegisterMinimize.Click += new System.EventHandler(this.Button_RegisterMinimize_Click);
            // 
            // Button_RegisterClose
            // 
            this.Button_RegisterClose.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Button_RegisterClose.BackColor = System.Drawing.Color.Transparent;
            this.Button_RegisterClose.BackgroundImage = global::Bugtracker.Properties.Resources.bt_close;
            this.Button_RegisterClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Button_RegisterClose.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Button_RegisterClose.FlatAppearance.BorderSize = 0;
            this.Button_RegisterClose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(154)))), ((int)(((byte)(110)))));
            this.Button_RegisterClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(223)))), ((int)(((byte)(223)))));
            this.Button_RegisterClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_RegisterClose.Location = new System.Drawing.Point(882, 0);
            this.Button_RegisterClose.Margin = new System.Windows.Forms.Padding(0);
            this.Button_RegisterClose.Name = "Button_RegisterClose";
            this.Button_RegisterClose.Size = new System.Drawing.Size(30, 32);
            this.Button_RegisterClose.TabIndex = 5;
            this.Button_RegisterClose.TabStop = false;
            this.ToolTip.SetToolTip(this.Button_RegisterClose, "Close");
            this.Button_RegisterClose.UseVisualStyleBackColor = false;
            this.Button_RegisterClose.Click += new System.EventHandler(this.Button_RegisterClose_Click);
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
            // Button_LoginMinimize
            // 
            this.Button_LoginMinimize.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Button_LoginMinimize.BackColor = System.Drawing.Color.Transparent;
            this.Button_LoginMinimize.BackgroundImage = global::Bugtracker.Properties.Resources.bt_minimize;
            this.Button_LoginMinimize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Button_LoginMinimize.FlatAppearance.BorderSize = 0;
            this.Button_LoginMinimize.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(154)))), ((int)(((byte)(110)))));
            this.Button_LoginMinimize.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(223)))), ((int)(((byte)(223)))));
            this.Button_LoginMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_LoginMinimize.Location = new System.Drawing.Point(396, 0);
            this.Button_LoginMinimize.Margin = new System.Windows.Forms.Padding(0);
            this.Button_LoginMinimize.Name = "Button_LoginMinimize";
            this.Button_LoginMinimize.Size = new System.Drawing.Size(30, 32);
            this.Button_LoginMinimize.TabIndex = 2;
            this.Button_LoginMinimize.TabStop = false;
            this.ToolTip.SetToolTip(this.Button_LoginMinimize, "Minimize");
            this.Button_LoginMinimize.UseVisualStyleBackColor = false;
            this.Button_LoginMinimize.Click += new System.EventHandler(this.Button_LoginMinimize_Click);
            // 
            // Button_LoginClose
            // 
            this.Button_LoginClose.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Button_LoginClose.BackColor = System.Drawing.Color.Transparent;
            this.Button_LoginClose.BackgroundImage = global::Bugtracker.Properties.Resources.bt_close;
            this.Button_LoginClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Button_LoginClose.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Button_LoginClose.FlatAppearance.BorderSize = 0;
            this.Button_LoginClose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(154)))), ((int)(((byte)(110)))));
            this.Button_LoginClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(223)))), ((int)(((byte)(223)))));
            this.Button_LoginClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_LoginClose.Location = new System.Drawing.Point(426, 0);
            this.Button_LoginClose.Margin = new System.Windows.Forms.Padding(0);
            this.Button_LoginClose.Name = "Button_LoginClose";
            this.Button_LoginClose.Size = new System.Drawing.Size(30, 32);
            this.Button_LoginClose.TabIndex = 0;
            this.Button_LoginClose.TabStop = false;
            this.ToolTip.SetToolTip(this.Button_LoginClose, "Close");
            this.Button_LoginClose.UseVisualStyleBackColor = false;
            this.Button_LoginClose.Click += new System.EventHandler(this.Button_LoginClose_Click);
            // 
            // PictureBox_LoginPassword
            // 
            this.PictureBox_LoginPassword.BackgroundImage = global::Bugtracker.Properties.Resources.bt_login_password;
            this.PictureBox_LoginPassword.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.PictureBox_LoginPassword.Location = new System.Drawing.Point(33, 248);
            this.PictureBox_LoginPassword.Margin = new System.Windows.Forms.Padding(0);
            this.PictureBox_LoginPassword.Name = "PictureBox_LoginPassword";
            this.PictureBox_LoginPassword.Size = new System.Drawing.Size(30, 32);
            this.PictureBox_LoginPassword.TabIndex = 44;
            this.PictureBox_LoginPassword.TabStop = false;
            this.PictureBox_LoginPassword.Click += new System.EventHandler(this.PictureBox_LoginPassword_Click);
            // 
            // PictureBox_LoginUsername
            // 
            this.PictureBox_LoginUsername.BackgroundImage = global::Bugtracker.Properties.Resources.bt_login_username;
            this.PictureBox_LoginUsername.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.PictureBox_LoginUsername.Location = new System.Drawing.Point(33, 159);
            this.PictureBox_LoginUsername.Margin = new System.Windows.Forms.Padding(0);
            this.PictureBox_LoginUsername.Name = "PictureBox_LoginUsername";
            this.PictureBox_LoginUsername.Size = new System.Drawing.Size(30, 32);
            this.PictureBox_LoginUsername.TabIndex = 7;
            this.PictureBox_LoginUsername.TabStop = false;
            this.PictureBox_LoginUsername.Click += new System.EventHandler(this.PictureBox_LoginUsername_Click);
            // 
            // Button_LoginPasswordVisibility
            // 
            this.Button_LoginPasswordVisibility.BackgroundImage = global::Bugtracker.Properties.Resources.bt_pass_show;
            this.Button_LoginPasswordVisibility.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Button_LoginPasswordVisibility.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Button_LoginPasswordVisibility.FlatAppearance.BorderSize = 0;
            this.Button_LoginPasswordVisibility.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.Button_LoginPasswordVisibility.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.Button_LoginPasswordVisibility.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_LoginPasswordVisibility.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_LoginPasswordVisibility.Location = new System.Drawing.Point(389, 246);
            this.Button_LoginPasswordVisibility.Name = "Button_LoginPasswordVisibility";
            this.Button_LoginPasswordVisibility.Size = new System.Drawing.Size(32, 32);
            this.Button_LoginPasswordVisibility.TabIndex = 0;
            this.Button_LoginPasswordVisibility.TabStop = false;
            this.Button_LoginPasswordVisibility.UseVisualStyleBackColor = false;
            this.Button_LoginPasswordVisibility.Visible = false;
            this.Button_LoginPasswordVisibility.Click += new System.EventHandler(this.Button_PasswordVisibility_Click);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(912, 526);
            this.Controls.Add(this.Panel_Registration);
            this.Controls.Add(this.Panel_TopBar);
            this.Controls.Add(this.Panel_Login);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(912, 526);
            this.MinimumSize = new System.Drawing.Size(912, 526);
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BugTracker";
            this.Panel_Login.ResumeLayout(false);
            this.Panel_Login.PerformLayout();
            this.Panel_TopBar.ResumeLayout(false);
            this.Panel_Registration.ResumeLayout(false);
            this.Panel_Registration.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox_RegisterEmail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox_RegisterPassword)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox_RegisterUsername)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox_LogoSmall)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox_LoginPassword)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox_LoginUsername)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox TextBox_LoginUsername;
        private System.Windows.Forms.Button Button_Login;
        private System.Windows.Forms.Button Button_GoToRegister;
        private System.Windows.Forms.Panel Panel_Login;
        private System.Windows.Forms.Panel Panel_TopBar;
        private System.Windows.Forms.Button Button_LoginMinimize;
        private System.Windows.Forms.Button Button_LoginClose;
        private System.Windows.Forms.ToolTip ToolTip;
        private System.Windows.Forms.PictureBox PictureBox_LogoSmall;
        private System.Windows.Forms.Label Label_Title;
        private System.Windows.Forms.Label Label_LoginTitle;
        private System.Windows.Forms.Label Label_LoginUsername;
        private System.Windows.Forms.Label Label_LoginUsernameSeparator;
        private System.Windows.Forms.Label Label_LoginPasswordSeparator;
        private System.Windows.Forms.TextBox TextBox_LoginPassword;
        private System.Windows.Forms.Label Label_LoginPassword;
        private System.Windows.Forms.Label Label_NoAccount;
        private System.Windows.Forms.Label Label_ForgotPassword;
        private System.Windows.Forms.Button Button_Reset;
        private System.Windows.Forms.Button Button_LoginPasswordVisibility;
        private System.Windows.Forms.Panel Panel_Registration;
        private System.Windows.Forms.Button Button_RegisterPasswordVisibility;
        private System.Windows.Forms.Label Label_HaveAccount;
        private System.Windows.Forms.Label Label_RegisterPasswordSeparator;
        private System.Windows.Forms.TextBox TextBox_RegisterPassword;
        private System.Windows.Forms.Label Label_RegisterPassword;
        private System.Windows.Forms.Label Label_RegisterUsernameSeparator;
        private System.Windows.Forms.Label Label_RegisterUsername;
        private System.Windows.Forms.Label Label_RegisterTitle;
        private System.Windows.Forms.Button Button_Register;
        private System.Windows.Forms.Button Button_GoToLogin;
        private System.Windows.Forms.TextBox TextBox_RegisterUsername;
        private System.Windows.Forms.Label Label_RegisterEmailSeparator;
        private System.Windows.Forms.TextBox TextBox_RegisterEmail;
        private System.Windows.Forms.Label Label_RegisterEmail;
        private System.Windows.Forms.Button Button_RegisterMinimize;
        private System.Windows.Forms.Button Button_RegisterClose;
        private System.Windows.Forms.PictureBox PictureBox_LoginUsername;
        private System.Windows.Forms.PictureBox PictureBox_LoginPassword;
        private System.Windows.Forms.PictureBox PictureBox_RegisterEmail;
        private System.Windows.Forms.PictureBox PictureBox_RegisterPassword;
        private System.Windows.Forms.PictureBox PictureBox_RegisterUsername;
    }
}