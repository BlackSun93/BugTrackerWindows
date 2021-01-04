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
    public partial class RegistrationForm : Form
    {
        public RegistrationForm()
        {
            InitializeComponent();
        }

        private void Button_Save_Click(object sender, EventArgs e)
        {
            string username = TextBox_Username.Text;
            string email = TextBox_Email.Text;
            string password = TextBox_Password.Text;
            SqlUser newUser = new SqlUser();
            newUser.InsertUser(username, email, password);

            LoginForm lf = new LoginForm();
            this.Hide();
            lf.Show();
            
        }

        private void Button_Back_Click(object sender, EventArgs e)
        {
            LoginForm lf = new LoginForm();
            this.Hide();
            lf.Show();
        }
    }
}
