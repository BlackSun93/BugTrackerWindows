using System;
using System.Data;
using System.Windows.Forms;

namespace Bugtracker
{
    public partial class Form1 : Form
    {
        Window display;
        public Form1(Window window)
        {
            InitializeComponent();
            display = window;
            LoadCheckBox();

        }

        void LoadCheckBox()
        {
            DataSet db = Connection.GetDbConn().GetDataSet($"SELECT username FROM user");
            //DataRow sectionDBValue = db.Tables[0].Rows[0];

            //comboBox1.Items.Add(sectionDBValue.ItemArray[0].ToString());

            //bind the datasource to the combo box
            comboBox1.DataSource = db.Tables[0];
            comboBox1.ValueMember = "username";
            comboBox1.DisplayMember = "idUser";
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            SqlUser test = new SqlUser();
                test.InsertUser(textBox1.Text, textBox2.Text, textBox3.Text);
        }

        private void Button2_Click(object sender, EventArgs e)
        {

            //display.DisplayProjectsForm();
        }
    }
}
