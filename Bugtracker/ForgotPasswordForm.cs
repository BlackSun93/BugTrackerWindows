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
        public ForgotPasswordForm()
        {
            InitializeComponent();
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
    }
}
