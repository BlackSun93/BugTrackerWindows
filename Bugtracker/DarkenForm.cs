using System;
using System.Windows.Forms;

namespace Bugtracker
{
    public partial class DarkenForm : Form
    {
        Form focusedForm;
        public DarkenForm(double opacity, Form form)
        {
            InitializeComponent();
            Opacity = opacity;
            focusedForm = form;
        }

        private void DarkenForm_MouseDown(object sender, MouseEventArgs e)
        {
            focusedForm.Focus();
        }
    }
}
