using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bugtracker
{
    public partial class LoginPanelBack : Form
    {
        LoginPanel loginForm;
        public LoginPanelBack(LoginPanel form, string position)
        {
            InitializeComponent();
            loginForm = form;


            if (position == "top")
            {
                BackgroundImage = Properties.Resources.bt_LoginPanelBackTop;
                TransparencyKey = Color.Black;
            }
            else if (position == "bottom")
            {
                BackgroundImage = Properties.Resources.bt_LoginPanelBackBottom;
                TransparencyKey = Color.Black;
            }
            FormBorderStyle = FormBorderStyle.None;
        }

        private void LoginPanelBack_MouseDown(object sender, MouseEventArgs e)
        {
            loginForm.Focus();
        }
    }
}
