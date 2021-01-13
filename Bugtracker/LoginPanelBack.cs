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
        LoginForm loginForm;
        public LoginPanelBack(LoginForm form)
        {
            InitializeComponent();
            loginForm = form;
            FormBorderStyle = FormBorderStyle.None;
        }

        private void LoginPanelBack_MouseDown(object sender, MouseEventArgs e)
        {
            loginForm.Focus();
        }
    }
}
