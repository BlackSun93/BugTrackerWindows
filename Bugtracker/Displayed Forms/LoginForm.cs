using System;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Drawing;

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
        private Bitmap HIDE = Properties.Resources.bt_pass_hide;
        private Bitmap SHOW = Properties.Resources.bt_pass_show;

        char position = 'r';
        int ix;
        int x;
        int y;

        private bool passwordVisible = false;

        public LoginForm()
        {
            InitializeComponent();
        }

        private void Button_Register_Click(object sender, EventArgs e)
        {
            //RegistrationForm rf = new RegistrationForm();
            //rf.Show();
            //Hide();

            TextBox_LoginUsername.Clear();
            TextBox_LoginPassword.Clear();

            Panel_Registration.Hide();

            ix = Panel_Slider.Location.X;
            x = Panel_Slider.Location.X;
            y = Panel_Slider.Location.Y;

            while (Panel_Slider.Location.X != 0)
            {
                x -= 1;
                Panel_Slider.Location = new Point(x, y);
            }
            position = 'l';

            Panel_Registration.Show();

        }

        /// <summary>
        /// on login clicked, go to sqlUser class and attempt to find this user + make a UserObject instance of 
        /// logged user with the details
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Button_Login_Click(object sender, EventArgs e)
        {
            SqlUser login = new SqlUser();
            login.GetUser(TextBox_LoginUsername.Text, TextBox_LoginPassword.Text);
            if (UserObject.loggedUser.username != "")
            {
                Hide();
                Window w = new Window();
                w.Show();
            }
            else 
            {
                TextBox_LoginUsername.Clear();
                TextBox_LoginPassword.Clear();
                MessageBox.Show("incorrect credentials ");
                Show();
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

        private void Button_Close_Click(object sender, EventArgs e)
        {
            Close();
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

        private void Button_Minimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void Button_PasswordVisibility_Click(object sender, EventArgs e)
        {
            if (passwordVisible == false)
            {
                passwordVisible = true;
                Button_LoginPasswordVisibility.Image = HIDE;
                TextBox_LoginPassword.UseSystemPasswordChar = false;
            }
            else if (passwordVisible == true)
            {
                passwordVisible = false;
                Button_LoginPasswordVisibility.Image = SHOW;
                TextBox_LoginPassword.UseSystemPasswordChar = true;
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

        private void Button_GoToLogin_Click(object sender, EventArgs e)
        {
            TextBox_RegisterUsername.Clear();
            TextBox_RegisterPassword.Clear();
            TextBox_RegisterEmail.Clear();

            Panel_Login.Hide();

            x = Panel_Slider.Location.X;
            y = Panel_Slider.Location.Y;

            while (Panel_Slider.Location.X != ix)
            {
                x += 1;
                Panel_Slider.Location = new Point(x, y);
            }
            position = 'r';

            Panel_Login.Show();

        }
    }
}
