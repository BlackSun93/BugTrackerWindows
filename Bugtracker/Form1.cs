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

            comboBox1.Items.Add(sectionDBValue.ItemArray[0].ToString());
        }
    }
}
