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
        private LoginPanel loginForm;
        private ForgotPasswordForm focusedForm;
        private DarkenForm darkForm;
        private string mode;
        public LoginPanelBack(LoginPanel form, string position)
        {
            InitializeComponent();
            loginForm = form;
            mode = "normal";

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

        public LoginPanelBack(double opacity, ForgotPasswordForm form1, DarkenForm form2, string position)
        {
            InitializeComponent();
            Opacity = opacity;
            focusedForm = form1;
            darkForm = form2;
            mode = "shadow";

            if (position == "top")
            {
                BackgroundImage = Properties.Resources.bt_LoginPanelBackTopShadow;
                TransparencyKey = Color.Black;
            }
            else if (position == "bottom")
            {
                BackgroundImage = Properties.Resources.bt_LoginPanelBackBottomShadow;
                TransparencyKey = Color.Black;
            }
            FormBorderStyle = FormBorderStyle.None;
        }

        private void LoginPanelBack_MouseDown(object sender, MouseEventArgs e)
        {
            if (mode == "shadow")
            {
                darkForm.Focus();
                focusedForm.Focus();
            }
            else if (mode == "normal")
            {
                loginForm.Focus();
            }
            
        }
    }
}
