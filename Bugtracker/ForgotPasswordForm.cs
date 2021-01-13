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
    public partial class ForgotPasswordForm : Form
    {
        private DarkenForm dark1;
        private DarkenForm dark2;
        private LoginPanelBack dark3;
        private LoginPanelBack dark4;

        public ForgotPasswordForm()
        {
            InitializeComponent();
        }

        public void GetDarkenForms(DarkenForm form1, DarkenForm form2, LoginPanelBack form3, LoginPanelBack form4)
        {
            dark1 = form1;
            dark2 = form2;
            dark3 = form3;
            dark4 = form4;
        }

        private void PictureBox_Email_Click(object sender, EventArgs e)
        {
            TextBox_RegisterEmail.Focus();
        }

        private void TextBox_RegisterEmail_Enter(object sender, EventArgs e)
        {
            Label_EmailSeparator.BackColor = Color.FromArgb(255, 85, 0);

            if (TextBox_RegisterEmail.Text == "Enter your email here")
            {
                TextBox_RegisterEmail.Clear();
                TextBox_RegisterEmail.ForeColor = Color.FromArgb(255, 85, 0);
            }
            else
            {
                TextBox_RegisterEmail.SelectAll();
                TextBox_RegisterEmail.Focus();
            }
        }

        private void TextBox_RegisterEmail_Leave(object sender, EventArgs e)
        {
            Label_EmailSeparator.BackColor = Color.FromArgb(119, 119, 136);

            if (TextBox_RegisterEmail.TextLength == 0)
            {
                TextBox_RegisterEmail.Text = "Enter your email here";
                TextBox_RegisterEmail.ForeColor = Color.FromArgb(119, 119, 136);
            }
        }

        private void ForgotPasswordForm_Click(object sender, EventArgs e)
        {
            Label_PasswordReset.Focus();
        }

        private void Button_Cancel_Click(object sender, EventArgs e)
        {
            dark1.Hide();
            dark2.Hide();
            dark3.Hide();
            dark4.Hide();
            Hide();
        }

        private void Button_Cancel_MouseMove(object sender, MouseEventArgs e)
        {
            Button_Cancel.ForeColor = Color.FromArgb(255, 85, 85);
        }

        private void Button_Cancel_MouseLeave(object sender, EventArgs e)
        {
            Button_Cancel.ForeColor = Color.FromArgb(82, 82, 82);
        }
    }
}
