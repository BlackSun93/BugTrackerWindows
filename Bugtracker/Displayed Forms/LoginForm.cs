using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Bugtracker
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void Button_Register_Click(object sender, EventArgs e)
        {
            RegistrationForm rf = new RegistrationForm();
            rf.Show();
            this.Hide();
            
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
    }
}
