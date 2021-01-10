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
        public System.Drawing.Bitmap CLOSE = Properties.Resources.bt_close;
        public System.Drawing.Bitmap MINIMIZE = Properties.Resources.bt_minimize;
        public System.Drawing.Bitmap MAXIMIZE = Properties.Resources.bt_maximize;
        public System.Drawing.Bitmap MAXIMIZE_DISABLED = Properties.Resources.bt_maximize_disabled;
        public System.Drawing.Bitmap RESTORE = Properties.Resources.bt_restore;

        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        char position = 'r';

        public LoginForm()
        {
            InitializeComponent();
        }

        private void Button_Register_Click(object sender, EventArgs e)
        {
            //RegistrationForm rf = new RegistrationForm();
            //rf.Show();
            //Hide();

            int ix = Panel_Slider.Location.X;
            int x = Panel_Slider.Location.X;
            int y = Panel_Slider.Location.Y;

            if (position == 'r')
            {
                while (Panel_Slider.Location.X != 0)
                {
                    x -= 1;
                    Panel_Slider.Location = new Point(x, y);
                }
                position = 'l';
            }
            else if (position == 'l')
            {
                while (Panel_Slider.Location.X != ix)
                {
                    x += 1;
                    Panel_Slider.Location = new Point(x, y);
                }
                position = 'r';
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
            login.GetUser(TextBox_Username.Text, TextBox_Password.Text);
            if (UserObject.loggedUser.username != "")
            {
                this.Hide();
                Window w = new Window();
                w.Show();
            }
            else 
            {
                TextBox_Username.Clear();
                TextBox_Password.Clear();
                MessageBox.Show("incorrect credentials ");
                this.Show();
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
    }
}
