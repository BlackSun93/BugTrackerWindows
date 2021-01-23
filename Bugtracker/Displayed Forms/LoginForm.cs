using System;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Drawing;
using System.Data;
using System.Threading;

namespace Bugtracker
{
    public partial class LoginForm : Form
    {

        public const int WM_NCLBUTTONDOWN = 0x00A1;
        public const int HT_CAPTION = 0x2;

        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        public Bitmap CLOSE = Properties.Resources.bt_close;
        public Bitmap MINIMIZE = Properties.Resources.bt_minimize;
        public Bitmap MAXIMIZE = Properties.Resources.bt_maximize;
        public Bitmap MAXIMIZE_DISABLED = Properties.Resources.bt_maximize_disabled;
        public Bitmap RESTORE = Properties.Resources.bt_restore;
        private Bitmap HIDE = Properties.Resources.bt_password_hide;
        private Bitmap SHOW = Properties.Resources.bt_password_show;
        private Bitmap USERNAME = Properties.Resources.bt_login_username;
        private Bitmap PASSWORD = Properties.Resources.bt_login_password;
        private Bitmap EMAIL = Properties.Resources.bt_login_email;
        private Bitmap ERROR = Properties.Resources.bt_error;
        private Bitmap USERNAME_SUCCESS = Properties.Resources.bt_login_username_success;
        private Bitmap PASSWORD_SUCCESS = Properties.Resources.bt_login_password_success;
        private Bitmap EMAIL_SUCCESS = Properties.Resources.bt_login_email_success;

        char position = 'r';
        int lpX, lpY, sp1X, sp1Y, sp2X, sp2Y, sp3X, sp3Y, sp4X, sp4Y;
        int loginUserX;
        int loginUserY;
        int loginPassX;
        int loginPassY;
        int registerUserX;
        int registerUserY;
        int registerPassX;
        int registerPassY;
        int registerEmailX;
        int registerEmailY;

        private bool passwordVisible = false;

        LoginPanel loginPanel;
        LoginPanelBack loginPanelBackTop;
        LoginPanelBack loginPanelBackBottom;

        private SplashForm SplashPage1;
        private SplashForm SplashPage2;
        private SplashForm SplashPage3;
        private SplashForm SplashPage4;

        public LoginForm()
        {
            InitializeComponent();

            if (Properties.Settings.Default.StayLoggedIn == true)
            {
                CheckBox_StayLoggedIn.Checked = true;
            }
            else
            {
                CheckBox_StayLoggedIn.Checked = false;
            }

            SplashPage1 = new SplashForm(1);
            SplashPage2 = new SplashForm(2);
            SplashPage3 = new SplashForm(3);
            SplashPage4 = new SplashForm(4);

            loginPanel = new LoginPanel(SplashPage1, SplashPage2, SplashPage3, SplashPage4);
            loginPanel.Location = new Point(Left + (Width / 2), Top - 20);
            loginPanel.Owner = this;

            loginPanelBackTop = new LoginPanelBack(loginPanel, "top");
            loginPanelBackTop.Location = new Point(Left + ((Width / 2) - 20), Top - 20);
            loginPanelBackTop.Owner = this;

            loginPanelBackBottom = new LoginPanelBack(loginPanel, "bottom");
            loginPanelBackBottom.Location = new Point(Left + ((Width / 2) - 20), Bottom);
            loginPanelBackBottom.Owner = this;

            SplashPage1.Location = new Point(loginPanel.Left + 41, loginPanel.Top + 137);
            SplashPage1.Owner = loginPanel;

            SplashPage2.Location = new Point(loginPanel.Left + 41, loginPanel.Top + 137);
            SplashPage2.Owner = loginPanel;

            SplashPage3.Location = new Point(loginPanel.Left + 41, loginPanel.Top + 137);
            SplashPage3.Owner = loginPanel;

            SplashPage4.Location = new Point(loginPanel.Left + 41, loginPanel.Top + 137);
            SplashPage4.Owner = loginPanel;

            SplashPage1.Opacity = 1;

            loginPanelBackTop.Show();
            loginPanelBackBottom.Show();
            loginPanel.Show();
            loginPanel.BringToFront();

            SplashPage1.Show();
            SplashPage2.Show();
            SplashPage3.Show();
            SplashPage4.Show();

        }

        protected override void OnMove(EventArgs e)
        {
            base.OnMove(e);
            if (position == 'r')
            {
                loginPanel.Location = new Point(Left + (Width / 2), Top - 20);
            }
            else if (position == 'l')
            {
                loginPanel.Location = new Point(Left, Top - 20);
            }
            loginPanelBackTop.Location = new Point(Left + ((Width / 2) - 20), Top - 20);
            loginPanelBackBottom.Location = new Point(Left + ((Width / 2) - 20), Bottom);
            SplashPage1.Location = new Point(loginPanel.Left + 41, loginPanel.Top + 137);
            SplashPage2.Location = new Point(loginPanel.Left + 41, loginPanel.Top + 137);
            SplashPage3.Location = new Point(loginPanel.Left + 41, loginPanel.Top + 137);
            SplashPage4.Location = new Point(loginPanel.Left + 41, loginPanel.Top + 137);

        }

        /// <summary>
        /// on login clicked, go to sqlUser class and attempt to find this user + make a UserObject instance of 
        /// logged user with the details
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Button_Login_Click(object sender, EventArgs e)
        {
            SqlUser loginUser = new SqlUser();
            string tempUsername = TextBox_LoginUsername.Text;
            string tempPassword = TextBox_LoginPassword.Text;
            string tempQuery = $"SELECT * from user WHERE username = '{tempUsername}' AND password = '{tempPassword}'";
            DataTable db = Connection.GetDbConn().GetDataTable(tempQuery);
            //login.GetUser(TextBox_LoginUsername.Text, TextBox_LoginPassword.Text);

            if (db.Rows.Count != 0)
            {
                UserObject.loggedUser.username = db.Rows[0].ItemArray[1].ToString();
                UserObject.loggedUser.iduser = db.Rows[0].ItemArray[0].ToString();

                if (CheckBox_StayLoggedIn.CheckState == CheckState.Checked)
                {
                    Properties.Settings.Default.StayLoggedIn = true;
                    Properties.Settings.Default.LoggedUserId = UserObject.loggedUser.iduser;
                    Properties.Settings.Default.LoggedUsername = UserObject.loggedUser.username;
                    Properties.Settings.Default.Save();
                }
                else if (CheckBox_StayLoggedIn.CheckState == CheckState.Unchecked)
                {
                    Properties.Settings.Default.StayLoggedIn = false;
                    Properties.Settings.Default.LoggedUserId = null;
                    Properties.Settings.Default.LoggedUsername = null;
                    Properties.Settings.Default.Save();
                }

                Hide();
                loginPanel.Hide();
                loginPanelBackTop.Hide();
                loginPanelBackBottom.Hide();
                SplashPage1.Hide();
                SplashPage2.Hide();
                SplashPage3.Hide();
                SplashPage4.Hide();
                Window window = new Window();
                window.Show();
            }
            else
            {
                Label_LoginUsernameSeparator.BackColor = Color.FromArgb(255, 85, 85);
                Label_LoginPasswordSeparator.BackColor = Color.FromArgb(255, 85, 85);
                TextBox_LoginUsername.ForeColor = Color.FromArgb(255, 85, 85);
                TextBox_LoginPassword.ForeColor = Color.FromArgb(255, 85, 85);
                PictureBox_LoginUsername.BackgroundImage = ERROR;
                PictureBox_LoginPassword.BackgroundImage = ERROR;
                Button_Login.BackColor = Color.FromArgb(255, 85, 85);
            }
        }

        private void Panel_TopBar_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void Button_LoginClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Button_Maximize_Click(object sender, EventArgs e)
        {
            // Disabled
            if (WindowState == FormWindowState.Maximized)
            {
                //Button_Maximize.BackgroundImage = RESTORE;
                //WindowState = FormWindowState.Normal;
            }
            else
            {
                //WindowState = FormWindowState.Maximized;
                //Button_Maximize.BackgroundImage = MAXIMIZE;
            }

        }

        private void Button_LoginMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void Button_PasswordVisibility_Click(object sender, EventArgs e)
        {
            if (passwordVisible == false)
            {
                ShowPasswords();
            }
            else if (passwordVisible == true)
            {
                HidePasswords();
            }
        }

        private void TextBox_Password_TextChanged(object sender, EventArgs e)
        {
            if (TextBox_LoginPassword.Text.Length > 0)
            {
                Button_LoginPasswordVisibility.Show();
            }
            else
            {
                Button_LoginPasswordVisibility.Hide();
            }
            
        }

        private void TextBox_Password_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                Button_Login_Click(this,null);
            }
        }

        private void Button_GoToRegister_Click(object sender, EventArgs e)
        {
            TextBox_LoginUsername.Clear();
            TextBox_LoginPassword.Clear();

            lpX = loginPanel.Location.X;
            lpY = loginPanel.Location.Y;
            sp1X = SplashPage1.Location.X;
            sp1Y = SplashPage1.Location.Y;
            sp2X = SplashPage2.Location.X;
            sp2Y = SplashPage2.Location.Y;
            sp3X = SplashPage3.Location.X;
            sp3Y = SplashPage3.Location.Y;
            sp4X = SplashPage4.Location.X;
            sp4Y = SplashPage4.Location.Y;

            while (loginPanel.Location.X != Left)
            {
                lpX -= 1;
                sp1X -= 1;
                sp2X -= 1;
                sp3X -= 1;
                sp4X -= 1;
                loginPanel.Location = new Point(lpX, lpY);
                SplashPage1.Location = new Point(sp1X, sp1Y);
                SplashPage2.Location = new Point(sp2X, sp2Y);
                SplashPage3.Location = new Point(sp3X, sp3Y);
                SplashPage4.Location = new Point(sp4X, sp4Y);
            }
            position = 'l';

            passwordVisible = false;
            HidePasswords();

            Label_LoginUsername.Location = new Point(61, 164);
            Label_LoginPassword.Location = new Point(61, 253);

            Label_LoginUsernameSeparator.BackColor = Color.FromArgb(119, 119, 136);
            Label_LoginPasswordSeparator.BackColor = Color.FromArgb(119, 119, 136);
            Button_Login.BackColor = Color.FromArgb(255, 85, 0);

            PictureBox_LoginUsername.BackgroundImage = USERNAME;
            PictureBox_LoginPassword.BackgroundImage = PASSWORD;

            CheckBox_StayLoggedIn.CheckState = CheckState.Unchecked;
        }

        private void Button_GoToLogin_Click(object sender, EventArgs e)
        {
            TextBox_RegisterUsername.Clear();
            TextBox_RegisterPassword.Clear();
            TextBox_RegisterEmail.Clear();

            lpX = loginPanel.Location.X;
            lpY = loginPanel.Location.Y;
            sp1X = SplashPage1.Location.X;
            sp1Y = SplashPage1.Location.Y;
            sp2X = SplashPage2.Location.X;
            sp2Y = SplashPage2.Location.Y;
            sp3X = SplashPage3.Location.X;
            sp3Y = SplashPage3.Location.Y;
            sp4X = SplashPage4.Location.X;
            sp4Y = SplashPage4.Location.Y;

            while (loginPanel.Location.X != (Left + (Width / 2)))
            {
                lpX += 1;
                sp1X += 1;
                sp2X += 1;
                sp3X += 1;
                sp4X += 1;
                loginPanel.Location = new Point(lpX, lpY);
                SplashPage1.Location = new Point(sp1X, sp1Y);
                SplashPage2.Location = new Point(sp2X, sp2Y);
                SplashPage3.Location = new Point(sp3X, sp3Y);
                SplashPage4.Location = new Point(sp4X, sp4Y);
            }
            position = 'r';

            passwordVisible = false;
            HidePasswords();

            Label_RegisterUsername.Location = new Point(29, 164);
            Label_RegisterPassword.Location = new Point(29, 253);
            Label_RegisterEmail.Location = new Point(29, 339);

            Label_RegisterUsernameSeparator.BackColor = Color.FromArgb(119, 119, 136);
            Label_RegisterPasswordSeparator.BackColor = Color.FromArgb(119, 119, 136);
            Label_RegisterEmailSeparator.BackColor = Color.FromArgb(119, 119, 136);

            PictureBox_RegisterUsername.BackgroundImage = USERNAME;
            PictureBox_RegisterPassword.BackgroundImage = PASSWORD;
            PictureBox_RegisterEmail.BackgroundImage = EMAIL;

            Label_RegisterUsernameError.Hide();
            Label_RegisterPasswordError.Hide();
            Label_RegisterEmailError.Hide();
        }

        private void Button_RegisterClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Button_RegisterMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void Button_Register_Click(object sender, EventArgs e)
        {
            string tempUsername = TextBox_RegisterUsername.Text;
            string tempQuery = $"SELECT * from user WHERE username = '{tempUsername}'";
            DataTable db = Connection.GetDbConn().GetDataTable(tempQuery);

            // Username error checks
            if (TextBox_RegisterUsername.TextLength == 0)
            {
                ShowRegisterUsernameError("Please enter a username.");
            }
            else if (TextBox_RegisterUsername.TextLength < 3)
            {
                ShowRegisterUsernameError("Please use 3 characters or more.");
            }
            else if (TextBox_RegisterUsername.TextLength > 30)
            {
                ShowRegisterUsernameError("Please use 30 characters or less.");
            }
            else if (db.Rows.Count != 0)
            {
                ShowRegisterUsernameError("Please choose a different username.");
            }

            // Password error checks
            else if (TextBox_RegisterPassword.TextLength == 0)
            {
                ShowRegisterPasswordError("Please enter a password.");
            }
            else if (TextBox_RegisterPassword.TextLength < 8)
            {
                ShowRegisterPasswordError("Please user 8 characters or more.");
            }
            else if (TextBox_RegisterPassword.TextLength < 8)
            {
                ShowRegisterPasswordError("Please enter a stronger password.");
            }

            // Email error checks
            else if (TextBox_RegisterEmail.TextLength == 0)
            {
                ShowRegisterEmailError("Please enter an email.");
            }
            else if (!TextBox_RegisterEmail.Text.Contains("@"))
            {
                ShowRegisterEmailError("Please enter a valid email address.");
            }

            // Successful registration
            else
            {
                string username = TextBox_RegisterUsername.Text;
                string email = TextBox_RegisterEmail.Text;
                string password = TextBox_RegisterPassword.Text;
                SqlUser newUser = new SqlUser();
                newUser.InsertUser(username, email, password);
            }
        }

        private void ShowRegisterUsernameError(string message)
        {
            Label_RegisterUsernameError.Text = message;
            Label_RegisterUsernameError.Show();

            Label_RegisterUsernameSeparator.BackColor = Color.FromArgb(255, 85, 85);
            TextBox_RegisterUsername.ForeColor = Color.FromArgb(255, 85, 85);
            PictureBox_RegisterUsername.BackgroundImage = ERROR;
            Button_Register.BackColor = Color.FromArgb(255, 85, 85);
        }

        private void ShowRegisterPasswordError(string message)
        {
            Label_RegisterPasswordError.Text = message;
            Label_RegisterPasswordError.Show();

            Label_RegisterPasswordSeparator.BackColor = Color.FromArgb(255, 85, 85);
            TextBox_RegisterPassword.ForeColor = Color.FromArgb(255, 85, 85);
            PictureBox_RegisterPassword.BackgroundImage = ERROR;
            Button_Register.BackColor = Color.FromArgb(255, 85, 85);
        }

        private void ShowRegisterEmailError(string message)
        {
            Label_RegisterEmailError.Text = message;
            Label_RegisterEmailError.Show();

            Label_RegisterEmailSeparator.BackColor = Color.FromArgb(255, 85, 85);
            TextBox_RegisterEmail.ForeColor = Color.FromArgb(255, 85, 85);
            PictureBox_RegisterEmail.BackgroundImage = ERROR;
            Button_Register.BackColor = Color.FromArgb(255, 85, 85);
        }

        private void Button_RegisterPasswordVisibility_Click(object sender, EventArgs e)
        {
            if (passwordVisible == false)
            {
                ShowPasswords();
            }
            else if (passwordVisible == true)
            {
                HidePasswords();
            }
        }

        private void TextBox_RegisterPassword_TextChanged(object sender, EventArgs e)
        {
            if (TextBox_RegisterPassword.Text.Length > 0)
            {
                Button_RegisterPasswordVisibility.Show();
            }
            else
            {
                Button_RegisterPasswordVisibility.Hide();
            }
        }

        private void HidePasswords()
        {
            passwordVisible = false;
            Button_LoginPasswordVisibility.Image = SHOW;
            Button_RegisterPasswordVisibility.Image = SHOW;
            TextBox_LoginPassword.UseSystemPasswordChar = true;
            TextBox_RegisterPassword.UseSystemPasswordChar = true;
        }

        private void ShowPasswords()
        {
            passwordVisible = true;
            Button_LoginPasswordVisibility.Image = HIDE;
            Button_RegisterPasswordVisibility.Image = HIDE;
            TextBox_LoginPassword.UseSystemPasswordChar = false;
            TextBox_RegisterPassword.UseSystemPasswordChar = false;
        }

        private void TextBox_LoginUsername_Enter(object sender, EventArgs e)
        {
            Label_LoginUsernameSeparator.BackColor = Color.FromArgb(119, 119, 136);
            TextBox_LoginUsername.ForeColor = Color.FromArgb(82, 82, 82);
            PictureBox_LoginUsername.BackgroundImage = USERNAME;
            Button_Login.BackColor = Color.FromArgb(255, 85, 0);

            if (TextBox_LoginUsername.TextLength == 0)
            {
                loginUserX = Label_LoginUsername.Location.X;
                loginUserY = Label_LoginUsername.Location.Y;

                while (Label_LoginUsername.Location.Y != 135)
                {
                    loginUserY -= 1;
                    Label_LoginUsername.Location = new Point(loginUserX, loginUserY);
                    Thread.Sleep(3);
                }
            }
            TextBox_LoginUsername.SelectAll();
            TextBox_LoginUsername.Focus();
        }

        private void TextBox_LoginUsername_Click(object sender, EventArgs e)
        {
            TextBox_LoginUsername.SelectAll();
            TextBox_LoginUsername.Focus();
        }

        private void TextBox_LoginUsername_Leave(object sender, EventArgs e)
        {
            if (TextBox_LoginUsername.TextLength == 0)
            {
                Label_LoginUsernameSeparator.BackColor = Color.FromArgb(119, 119, 136);

                loginUserX = Label_LoginUsername.Location.X;
                loginUserY = Label_LoginUsername.Location.Y;

                while (Label_LoginUsername.Location.Y != 164)
                {
                    loginUserY += 1;
                    Label_LoginUsername.Location = new Point(loginUserX, loginUserY);
                    Thread.Sleep(3);
                }
            }
            else
            {
                TextBox_LoginUsername.ForeColor = Color.FromArgb(38, 174, 96);
                Label_LoginUsernameSeparator.BackColor = Color.FromArgb(38, 174, 96);
                PictureBox_LoginUsername.BackgroundImage = USERNAME_SUCCESS;
            }
        }

        private void TextBox_LoginPassword_Enter(object sender, EventArgs e)
        {
            Label_LoginPasswordSeparator.BackColor = Color.FromArgb(119, 119, 136);
            TextBox_LoginPassword.ForeColor = Color.FromArgb(82, 82, 82);
            PictureBox_LoginPassword.BackgroundImage = PASSWORD;
            Button_Login.BackColor = Color.FromArgb(255, 85, 0);

            if (TextBox_LoginPassword.TextLength == 0)
            {
                loginPassX = Label_LoginPassword.Location.X;
                loginPassY = Label_LoginPassword.Location.Y;

                while (Label_LoginPassword.Location.Y != 223)
                {
                    loginPassY -= 1;
                    Label_LoginPassword.Location = new Point(loginPassX, loginPassY);
                    Thread.Sleep(3);
                }
            }
            TextBox_LoginPassword.SelectAll();
            TextBox_LoginPassword.Focus();
        }

        private void TextBox_LoginPassword_Click(object sender, EventArgs e)
        {
            TextBox_LoginPassword.SelectAll();
            TextBox_LoginPassword.Focus();
        }

        private void TextBox_LoginPassword_Leave(object sender, EventArgs e)
        {
            if (TextBox_LoginPassword.TextLength == 0)
            {
                Label_LoginPasswordSeparator.BackColor = Color.FromArgb(119, 119, 136);

                loginPassX = Label_LoginPassword.Location.X;
                loginPassY = Label_LoginPassword.Location.Y;

                while (Label_LoginPassword.Location.Y != 253)
                {
                    loginPassY += 1;
                    Label_LoginPassword.Location = new Point(loginPassX, loginPassY);
                    Thread.Sleep(3);
                }
            }
            else
            {
                TextBox_LoginPassword.ForeColor = Color.FromArgb(38, 174, 96);
                Label_LoginPasswordSeparator.BackColor = Color.FromArgb(38, 174, 96);
                PictureBox_LoginPassword.BackgroundImage = PASSWORD_SUCCESS;
            }
        }

        private void Label_LoginUsername_Click(object sender, EventArgs e)
        {
            TextBox_LoginUsername.Focus();
        }

        private void Label_LoginPassword_Click(object sender, EventArgs e)
        {
            TextBox_LoginPassword.Focus();
        }

        private void PictureBox_LoginUsername_Click(object sender, EventArgs e)
        {
            TextBox_LoginUsername.Focus();
        }

        private void PictureBox_LoginPassword_Click(object sender, EventArgs e)
        {
            TextBox_LoginPassword.Focus();
        }

        private void TextBox_RegisterUsername_Enter(object sender, EventArgs e)
        {
            Label_RegisterUsernameSeparator.BackColor = Color.FromArgb(119, 119, 136);
            TextBox_RegisterUsername.ForeColor = Color.FromArgb(82, 82, 82);
            PictureBox_RegisterUsername.BackgroundImage = USERNAME;
            Button_Login.BackColor = Color.FromArgb(255, 85, 0);


            if (TextBox_RegisterUsername.TextLength == 0)
            {
                registerUserX = Label_RegisterUsername.Location.X;
                registerUserY = Label_RegisterUsername.Location.Y;

                while (Label_RegisterUsername.Location.Y != 135)
                {
                    registerUserY -= 1;
                    Label_RegisterUsername.Location = new Point(registerUserX, registerUserY);
                    Thread.Sleep(3);
                }
            }
        }

        private void TextBox_RegisterUsername_Leave(object sender, EventArgs e)
        {
            if (TextBox_RegisterUsername.TextLength == 0)
            {
                Label_RegisterUsernameSeparator.BackColor = Color.FromArgb(119, 119, 136);

                registerUserX = Label_RegisterUsername.Location.X;
                registerUserY = Label_RegisterUsername.Location.Y;

                while (Label_RegisterUsername.Location.Y != 164)
                {
                    registerUserY += 1;
                    Label_RegisterUsername.Location = new Point(registerUserX, registerUserY);
                    Thread.Sleep(3);
                }
            }
            else
            {
                Label_RegisterUsernameSeparator.BackColor = Color.FromArgb(38, 174, 96);
                TextBox_RegisterUsername.ForeColor = Color.FromArgb(38, 174, 96);
                PictureBox_RegisterUsername.BackgroundImage = USERNAME_SUCCESS;
                Button_Register.BackColor = Color.FromArgb(255, 85, 0);
                Label_RegisterUsernameError.Hide();
            }
        }

        private void TextBox_RegisterPassword_Enter(object sender, EventArgs e)
        {
            Label_RegisterPasswordSeparator.BackColor = Color.FromArgb(119, 119, 136);
            TextBox_RegisterPassword.ForeColor = Color.FromArgb(82, 82, 82);
            PictureBox_RegisterPassword.BackgroundImage = PASSWORD;
            Button_Login.BackColor = Color.FromArgb(255, 85, 0);

            if (TextBox_RegisterPassword.TextLength == 0)
            {
                registerPassX = Label_RegisterPassword.Location.X;
                registerPassY = Label_RegisterPassword.Location.Y;

                while (Label_RegisterPassword.Location.Y != 223)
                {
                    registerPassY -= 1;
                    Label_RegisterPassword.Location = new Point(registerPassX, registerPassY);
                    Thread.Sleep(3);
                }
            }
        }

        private void TextBox_RegisterPassword_Leave(object sender, EventArgs e)
        {
            if (TextBox_RegisterPassword.TextLength == 0)
            {
                Label_RegisterPasswordSeparator.BackColor = Color.FromArgb(119, 119, 136);

                registerPassX = Label_RegisterPassword.Location.X;
                registerPassY = Label_RegisterPassword.Location.Y;

                while (Label_RegisterPassword.Location.Y != 253)
                {
                    registerPassY += 1;
                    Label_RegisterPassword.Location = new Point(registerPassX, registerPassY);
                    Thread.Sleep(3);
                }
            }
            else
            {
                Label_RegisterPasswordSeparator.BackColor = Color.FromArgb(38, 174, 96);
                TextBox_RegisterPassword.ForeColor = Color.FromArgb(38, 174, 96);
                PictureBox_RegisterPassword.BackgroundImage = PASSWORD_SUCCESS;
                Button_Register.BackColor = Color.FromArgb(255, 85, 0);
                Label_RegisterPasswordError.Hide();
            }
        }

        private void TextBox_RegisterEmail_Enter(object sender, EventArgs e)
        {
            Label_RegisterEmailSeparator.BackColor = Color.FromArgb(119, 119, 136);
            TextBox_RegisterEmail.ForeColor = Color.FromArgb(82, 82, 82);
            PictureBox_RegisterEmail.BackgroundImage = EMAIL;
            Button_Login.BackColor = Color.FromArgb(255, 85, 0);

            if (TextBox_RegisterEmail.TextLength == 0)
            {
                registerEmailX = Label_RegisterEmail.Location.X;
                registerEmailY = Label_RegisterEmail.Location.Y;

                while (Label_RegisterEmail.Location.Y != 312)
                {
                    registerEmailY -= 1;
                    Label_RegisterEmail.Location = new Point(registerEmailX, registerEmailY);
                    Thread.Sleep(3);
                }
            }
        }

        private void TextBox_RegisterEmail_Leave(object sender, EventArgs e)
        {


            if (TextBox_RegisterEmail.TextLength == 0)
            {
                Label_RegisterEmailSeparator.BackColor = Color.FromArgb(119, 119, 136);

                registerEmailX = Label_RegisterEmail.Location.X;
                registerEmailY = Label_RegisterEmail.Location.Y;

                while (Label_RegisterEmail.Location.Y != 339)
                {
                    registerEmailY += 1;
                    Label_RegisterEmail.Location = new Point(registerEmailX, registerEmailY);
                    Thread.Sleep(3);
                }
            }
            else
            {
                Label_RegisterEmailSeparator.BackColor = Color.FromArgb(38, 174, 96);
                TextBox_RegisterEmail.ForeColor = Color.FromArgb(38, 174, 96);
                PictureBox_RegisterEmail.BackgroundImage = EMAIL_SUCCESS;
                Button_Register.BackColor = Color.FromArgb(255, 85, 0);
                Label_RegisterEmailError.Hide();
            }
        }

        private void Label_RegisterUsername_Click(object sender, EventArgs e)
        {
            TextBox_RegisterUsername.Focus();
        }

        private void Label_RegisterPassword_Click(object sender, EventArgs e)
        {
            TextBox_RegisterPassword.Focus();
        }

        private void Label_RegisterEmail_Click(object sender, EventArgs e)
        {
            TextBox_RegisterEmail.Focus();
        }

        private void PictureBox_RegisterUsername_Click(object sender, EventArgs e)
        {
            TextBox_RegisterUsername.Focus();
        }

        private void PictureBox_RegisterPassword_Click(object sender, EventArgs e)
        {
            TextBox_RegisterPassword.Focus();
        }

        private void PictureBox_RegisterEmail_Click(object sender, EventArgs e)
        {
            TextBox_RegisterEmail.Focus();
        }

        private void Panel_Login_Click(object sender, EventArgs e)
        {
            Panel_Login.Focus();
        }

        private void Panel_Registration_Click(object sender, EventArgs e)
        {
            Panel_Registration.Focus();
        }

        private void Button_ForgotPassword_MouseMove(object sender, MouseEventArgs e)
        {
            Button_ForgotPassword.ForeColor = Color.FromArgb(255, 85, 0);
        }

        private void Button_ForgotPassword_MouseLeave(object sender, EventArgs e)
        {
            Button_ForgotPassword.ForeColor = Color.FromArgb(119, 119, 136);
        }

        private void Button_GoToRegister_MouseMove(object sender, MouseEventArgs e)
        {
            Button_GoToRegister.ForeColor = Color.FromArgb(19, 174, 71);
        }

        private void Button_GoToRegister_MouseLeave(object sender, EventArgs e)
        {
            Button_GoToRegister.ForeColor = Color.FromArgb(255, 85, 0);
        }

        private void Button_GoToLogin_MouseMove(object sender, MouseEventArgs e)
        {
            Button_GoToLogin.ForeColor = Color.FromArgb(19, 174, 71);
        }

        private void Button_GoToLogin_MouseLeave(object sender, EventArgs e)
        {
            Button_GoToLogin.ForeColor = Color.FromArgb(255, 85, 0);
        }

        private void CheckBox_StayLoggedIn_CheckedChanged(object sender, EventArgs e)
        {
            if (CheckBox_StayLoggedIn.Checked)
            {
                CheckBox_StayLoggedIn.ImageIndex = 1;
            }
            else
            {
                CheckBox_StayLoggedIn.ImageIndex = 0;
            }
        }

        private void Button_ForgotPassword_Click(object sender, EventArgs e)
        {
            ForgotPasswordForm forgotPassword = new ForgotPasswordForm();
            DarkenForm dark1 = new DarkenForm(.7, forgotPassword);
            DarkenForm dark2 = new DarkenForm(.7, forgotPassword);
            LoginPanelBack dark3 = new LoginPanelBack(.7, forgotPassword, dark2, "top");
            LoginPanelBack dark4 = new LoginPanelBack(.7, forgotPassword, dark2, "bottom");

            dark1.Size = dark1.MinimumSize = dark1.MaximumSize = new Size(Width/2, Height);
            dark1.Location = new Point(Left, Top);
            dark1.Owner = this;

            dark2.Size = dark2.MinimumSize = dark2.MaximumSize = new Size(loginPanel.Width, loginPanel.Height);
            dark2.Location = new Point(loginPanel.Left, loginPanel.Top);
            dark2.Owner = loginPanel;

            dark3.Size = dark3.MinimumSize = dark3.MaximumSize = new Size(20, 20);
            dark3.Location = new Point(Left + ((Width / 2) - 20), Top - 20);
            dark3.Owner = this;

            dark4.Size = dark4.MinimumSize = dark4.MaximumSize = new Size(20, 20);
            dark4.Location = new Point(Left + ((Width / 2) - 20), Bottom);
            dark4.Owner = this;

            forgotPassword.GetDarkenForms(dark1, dark2, dark3, dark4);
            forgotPassword.Location = new Point(Left + Width/4, Top + Height / 4);
            forgotPassword.Owner = this;

            dark3.Show();
            dark4.Show();
            dark1.Show();
            dark2.Show();
            forgotPassword.Show();

        }
    }
}
