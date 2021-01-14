using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using System.Drawing;

namespace Bugtracker
{
    public partial class LoginPanel : Form
    {
        private Bitmap ACTIVE = Properties.Resources.bt_page_active;
        private Bitmap INACTIVE = Properties.Resources.bt_page_inactive;

        public LoginPanel()
        {
            InitializeComponent();
        }

        private void ActivePage(int page)
        {
            switch (page)
            {
                case 1:
                    PictureBox_Page1.BackgroundImage = ACTIVE;
                    PictureBox_Page2.BackgroundImage = INACTIVE;
                    PictureBox_Page3.BackgroundImage = INACTIVE;
                    PictureBox_Page4.BackgroundImage = INACTIVE;
                    break;

                case 2:
                    PictureBox_Page1.BackgroundImage = INACTIVE;
                    PictureBox_Page2.BackgroundImage = ACTIVE;
                    PictureBox_Page3.BackgroundImage = INACTIVE;
                    PictureBox_Page4.BackgroundImage = INACTIVE;
                    break;

                case 3:
                    PictureBox_Page1.BackgroundImage = INACTIVE;
                    PictureBox_Page2.BackgroundImage = INACTIVE;
                    PictureBox_Page3.BackgroundImage = ACTIVE;
                    PictureBox_Page4.BackgroundImage = INACTIVE;
                    break;

                case 4:
                    PictureBox_Page1.BackgroundImage = INACTIVE;
                    PictureBox_Page2.BackgroundImage = INACTIVE;
                    PictureBox_Page3.BackgroundImage = INACTIVE;
                    PictureBox_Page4.BackgroundImage = ACTIVE;
                    break;
            }
        }

        private void PictureBox_Page1_Click(object sender, EventArgs e)
        {
            ActivePage(1);
        }

        private void PictureBox_Page2_Click(object sender, EventArgs e)
        {
            ActivePage(2);
        }

        private void PictureBox_Page3_Click(object sender, EventArgs e)
        {
            ActivePage(3);
        }

        private void PictureBox_Page4_Click(object sender, EventArgs e)
        {
            ActivePage(4);
        }
    }
}
