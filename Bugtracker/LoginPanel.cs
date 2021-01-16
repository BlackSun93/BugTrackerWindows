using System;
using System.Windows.Forms;
using System.Drawing;
using System.Threading;

namespace Bugtracker
{
    public partial class LoginPanel : Form
    {
        private Bitmap ACTIVE = Properties.Resources.bt_page_active;
        private Bitmap INACTIVE = Properties.Resources.bt_page_inactive;

        private SplashForm page1;
        private SplashForm page2;
        private SplashForm page3;
        private SplashForm page4;

        private string activePage = "1";

        private Color backgroundColour;

        private double splashTransitionRate = .00005;

        public LoginPanel(SplashForm splash1, SplashForm splash2, SplashForm splash3, SplashForm splash4)
        {
            InitializeComponent();

            backgroundColour = BackColor;

            page1 = splash1;
            page2 = splash2;
            page3 = splash3;
            page4 = splash4;
        }


        private void ActivePage(int page)
        {
            switch (page)
            {
                case 1:
                    if (activePage != "1")
                    {
                        PictureBox_Page1.BackgroundImage = ACTIVE;
                        PictureBox_Page2.BackgroundImage = INACTIVE;
                        PictureBox_Page3.BackgroundImage = INACTIVE;
                        PictureBox_Page4.BackgroundImage = INACTIVE;
                        ActivatePage1();
                        activePage = "1";
                    }
                    break;

                case 2:
                    if (activePage != "2")
                    {
                        PictureBox_Page1.BackgroundImage = INACTIVE;
                        PictureBox_Page2.BackgroundImage = ACTIVE;
                        PictureBox_Page3.BackgroundImage = INACTIVE;
                        PictureBox_Page4.BackgroundImage = INACTIVE;
                        ActivatePage2();
                        activePage = "2";
                    }
                    break;

                case 3:
                    if (activePage != "3")
                    {
                        PictureBox_Page1.BackgroundImage = INACTIVE;
                        PictureBox_Page2.BackgroundImage = INACTIVE;
                        PictureBox_Page3.BackgroundImage = ACTIVE;
                        PictureBox_Page4.BackgroundImage = INACTIVE;
                        ActivatePage3();
                        activePage = "3";
                    }
                    break;

                case 4:
                    if (activePage != "4")
                    {
                        PictureBox_Page1.BackgroundImage = INACTIVE;
                        PictureBox_Page2.BackgroundImage = INACTIVE;
                        PictureBox_Page3.BackgroundImage = INACTIVE;
                        PictureBox_Page4.BackgroundImage = ACTIVE;
                        ActivatePage4();
                        activePage = "4";
                    }
                    break;
            }
        }

        private void ActivatePage1()
        {
            double o1 = page1.Opacity;
            double o2 = page2.Opacity;
            double o3 = page3.Opacity;
            double o4 = page4.Opacity;


            if (page2.Visible)
            {
                while (page2.Opacity != 0)
                {
                    o2 -= splashTransitionRate;
                    page2.Opacity = o2;
                }
                page2.Hide();
            }
            else if (page3.Visible)
            {
                while (page3.Opacity != 0)
                {
                    o3 -= splashTransitionRate;
                    page3.Opacity = o3;
                }
                page3.Hide();
            }
            else if (page4.Visible)
            {
                while (page4.Opacity != 0)
                {
                    o4 -= splashTransitionRate;
                    page4.Opacity = o4;
                }
                page4.Hide();
            }

            page1.Show();

            while (page1.Opacity != 1)
            {
                o1 += splashTransitionRate;
                page1.Opacity = o1;
            }
        }

        private void ActivatePage2()
        {
            double o1 = page1.Opacity;
            double o2 = page2.Opacity;
            double o3 = page3.Opacity;
            double o4 = page4.Opacity;


            if (page1.Visible)
            {
                while (page1.Opacity != 0)
                {
                    o1 -= splashTransitionRate;
                    page1.Opacity = o1;
                }
                page1.Hide();
            }
            else if (page3.Visible)
            {
                while (page3.Opacity != 0)
                {
                    o3 -= splashTransitionRate;
                    page3.Opacity = o3;
                }
                page3.Hide();
            }
            else if (page4.Visible)
            {
                while (page4.Opacity != 0)
                {
                    o4 -= splashTransitionRate;
                    page4.Opacity = o4;
                }
                page4.Hide();
            }

            page2.Show();

            while (page2.Opacity != 1)
            {
                o2 += splashTransitionRate;
                page2.Opacity = o2;
            }
        }

        private void ActivatePage3()
        {
            double o1 = page1.Opacity;
            double o2 = page2.Opacity;
            double o3 = page3.Opacity;
            double o4 = page4.Opacity;


            if (page1.Visible)
            {
                while (page1.Opacity != 0)
                {
                    o1 -= splashTransitionRate;
                    page1.Opacity = o1;
                }
                page1.Hide();
            }
            else if (page2.Visible)
            {
                while (page2.Opacity != 0)
                {
                    o2 -= splashTransitionRate;
                    page2.Opacity = o2;
                }
                page2.Hide();
            }
            else if (page4.Visible)
            {
                while (page4.Opacity != 0)
                {
                    o4 -= splashTransitionRate;
                    page4.Opacity = o4;
                }
                page4.Hide();
            }

            page3.Show();

            while (page3.Opacity != 1)
            {
                o3 += splashTransitionRate;
                page3.Opacity = o3;
            }
        }

        private void ActivatePage4()
        {
            double o1 = page1.Opacity;
            double o2 = page2.Opacity;
            double o3 = page3.Opacity;
            double o4 = page4.Opacity;


            if (page1.Visible)
            {
                while (page1.Opacity != 0)
                {
                    o1 -= splashTransitionRate;
                    page1.Opacity = o1;
                }
                page1.Hide();
            }
            else if (page2.Visible)
            {
                while (page2.Opacity != 0)
                {
                    o2 -= splashTransitionRate;
                    page2.Opacity = o2;
                }
                page2.Hide();
            }
            else if (page3.Visible)
            {
                while (page3.Opacity != 0)
                {
                    o3 -= splashTransitionRate;
                    page3.Opacity = o3;
                }
                page3.Hide();
            }

            page4.Show();

            while (page4.Opacity != 1)
            {
                o4 += splashTransitionRate;
                page4.Opacity = o4;
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
