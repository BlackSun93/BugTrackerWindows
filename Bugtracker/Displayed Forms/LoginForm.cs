using System;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Drawing;
using System.Data;

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

        char position = 'r';
        int x;
        int y;

        private bool passwordVisible = false;

        LoginPanel loginPanel;

        public LoginForm()
        {
            InitializeComponent();
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
            SqlUser login = new SqlUser();
            string aaa = TextBox_LoginUsername.Text;
            string bb = TextBox_LoginPassword.Text;
            string oi = $"SELECT * from user WHERE username = '{aaa}' AND password = '{bb}'";
            DataTable db = Connection.GetDbConn().GetDataTable(oi );
            //login.GetUser(TextBox_LoginUsername.Text, TextBox_LoginPassword.Text);

            UserObject.loggedUser.username= db.Rows[0].ItemArray[1].ToString();
            UserObject.loggedUser.iduser = db.Rows[0].ItemArray[0].ToString();
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

        private void Button_LoginClose_Click(object sender, EventArgs e)
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

        }

        private void Button_RegisterClose_Click(object sender, EventArgs e)
        {
            Close();
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
    }
}
