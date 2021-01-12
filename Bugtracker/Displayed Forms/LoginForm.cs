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

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect,     // x-coordinate of upper-left corner
            int nTopRect,      // y-coordinate of upper-left corner
            int nRightRect,    // x-coordinate of lower-right corner
            int nBottomRect,   // y-coordinate of lower-right corner
            int nWidthEllipse, // width of ellipse
            int nHeightEllipse // height of ellipse
        );

        public Bitmap CLOSE = Properties.Resources.bt_close;
        public Bitmap MINIMIZE = Properties.Resources.bt_minimize;
        public Bitmap MAXIMIZE = Properties.Resources.bt_maximize;
        public Bitmap MAXIMIZE_DISABLED = Properties.Resources.bt_maximize_disabled;
        public Bitmap RESTORE = Properties.Resources.bt_restore;
        private Bitmap HIDE = Properties.Resources.bt_pass_hide;
        private Bitmap SHOW = Properties.Resources.bt_pass_show;
        private Bitmap USERNAME = Properties.Resources.bt_login_username;
        private Bitmap PASSWORD = Properties.Resources.bt_login_password;
        private Bitmap EMAIL = Properties.Resources.bt_login_email;
        private Bitmap ERROR = Properties.Resources.bt_error;

        char position = 'r';
        int x;
        int y;
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
            FormBorderStyle = FormBorderStyle.None;
            Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 10, 10));
            loginPanel = new LoginPanel();
            loginPanel.Location = new Point(Width/2, -10);
            loginPanel.Owner = this;
            loginPanel.Show();

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
                    Properties.Settings.Default.Save();
                }
                else if (CheckBox_StayLoggedIn.CheckState == CheckState.Unchecked)
                {
                    Properties.Settings.Default.StayLoggedIn = false;
                    Properties.Settings.Default.Save();
                }

                Hide();
                loginPanel.Hide();
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

                MessageBox.Show("incorrect credentials ");
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

            x = loginPanel.Location.X;
            y = loginPanel.Location.Y;

            while (loginPanel.Location.X != Left)
            {
                x -= 1;
                loginPanel.Location = new Point(x, y);
            }
            position = 'l';

            passwordVisible = false;
            HidePasswords();

            Label_LoginUsername.Location = new Point(61, 164);
            Label_LoginPassword.Location = new Point(61, 255);

            Label_LoginUsernameSeparator.BackColor = Color.FromArgb(119, 119, 136);
            Label_LoginPasswordSeparator.BackColor = Color.FromArgb(119, 119, 136);

            PictureBox_LoginUsername.BackgroundImage = USERNAME;
            PictureBox_LoginPassword.BackgroundImage = PASSWORD;
        }

        private void Button_GoToLogin_Click(object sender, EventArgs e)
        {
            TextBox_RegisterUsername.Clear();
            TextBox_RegisterPassword.Clear();
            TextBox_RegisterEmail.Clear();

            x = loginPanel.Location.X;
            y = loginPanel.Location.Y;

            while (loginPanel.Location.X != (Left + (Width / 2)))
            {
                x += 1;
                loginPanel.Location = new Point(x, y);
            }
            position = 'r';

            passwordVisible = false;
            HidePasswords();

            Label_RegisterUsername.Location = new Point(61, 164);
            Label_RegisterPassword.Location = new Point(61, 255);
            Label_RegisterEmail.Location = new Point(61, 340);

            Label_RegisterUsernameSeparator.BackColor = Color.FromArgb(119, 119, 136);
            Label_RegisterPasswordSeparator.BackColor = Color.FromArgb(119, 119, 136);
            Label_RegisterEmailSeparator.BackColor = Color.FromArgb(119, 119, 136);
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
            string username = TextBox_RegisterUsername.Text;
            string email = TextBox_RegisterEmail.Text;
            string password = TextBox_RegisterPassword.Text;
            SqlUser newUser = new SqlUser();
            newUser.InsertUser(username, email, password);
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
            TextBox_LoginUsername.SelectAll();
            PictureBox_LoginUsername.BackgroundImage = USERNAME;

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
            }
        }

        private void TextBox_LoginPassword_Enter(object sender, EventArgs e)
        {
            Label_LoginPasswordSeparator.BackColor = Color.FromArgb(119, 119, 136);
            TextBox_LoginPassword.ForeColor = Color.FromArgb(82, 82, 82);
            PictureBox_LoginPassword.BackgroundImage = PASSWORD;

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
            Label_RegisterUsernameSeparator.BackColor = Color.FromArgb(255, 86, 0);

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
            }
        }

        private void TextBox_RegisterPassword_Enter(object sender, EventArgs e)
        {
            Label_RegisterPasswordSeparator.BackColor = Color.FromArgb(255, 86, 0);

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
            }
        }

        private void TextBox_RegisterEmail_Enter(object sender, EventArgs e)
        {
            Label_RegisterEmailSeparator.BackColor = Color.FromArgb(255, 86, 0);

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
    }
}
