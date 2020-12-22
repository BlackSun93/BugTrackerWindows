using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Bugtracker
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            loadCheckBox();

        }

        void loadCheckBox()
        {
            DataSet db = Connection.GetDbConn().GetDataSet($"SELECT username FROM user");
            DataRow sectionDBValue = db.Tables[0].Rows[0];

            //comboBox1.Items.Add(sectionDBValue.ItemArray[0].ToString());

            //bind the datasource to the combo box
            comboBox1.DataSource = db.Tables[0];
            comboBox1.ValueMember = "username";
            comboBox1.DisplayMember = "idUser";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlUser test = new SqlUser();
                test.InsertUser(textBox1.Text, textBox2.Text, textBox3.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ProjectsForm p = new ProjectsForm();
            this.Hide();
            p.Show();
        }
    }
}
