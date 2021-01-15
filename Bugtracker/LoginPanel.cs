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
        private Bitmap SPLASH1 = Properties.Resources.bt_splash_1;
        private Bitmap SPLASH2 = Properties.Resources.bt_splash_2;
        private Bitmap SPLASH3 = Properties.Resources.bt_splash_3;
        private Bitmap SPLASH4 = Properties.Resources.bt_splash_4;

        Panel Panel_Page1;
        Panel Panel_Page2;
        Panel Panel_Page3;
        Panel Panel_Page4;

        private string activePage = "1";

        private Color backgroundColour;

        public LoginPanel()
        {
            InitializeComponent();

            backgroundColour = BackColor;

            CreateSplashPanels();
        }

        private void CreateSplashPanels()
        {
            Panel_Page1 = new Panel
            {
                Name = "Panel_Page1",
                BackColor = Color.Blue,//backgroundColour,
                Size = new Size(374, 292),
                MaximumSize = new Size(374, 292),
                MinimumSize = new Size(374, 292),
                Location = new Point(41, 137),
            };

            Panel_Page2 = new Panel
            {
                Name = "Panel_Page2",
                BackColor = Color.Magenta,//backgroundColour,
                Size = new Size(374, 292),
                MaximumSize = new Size(374, 292),
                MinimumSize = new Size(374, 292),
                Location = new Point(456, 137),
            };

            Panel_Page3 = new Panel
            {
                Name = "Panel_Page3",
                BackColor = Color.Green,//backgroundColour,
                Size = new Size(374, 292),
                MaximumSize = new Size(374, 292),
                MinimumSize = new Size(374, 292),
                Location = new Point(456, 137),
            };

            Panel_Page4 = new Panel
            {
                Name = "Panel_Page4",
                BackColor = Color.Black,//backgroundColour,
                Size = new Size(374, 292),
                MaximumSize = new Size(374, 292),
                MinimumSize = new Size(374, 292),
                Location = new Point(456, 137),
            };

            PictureBox PictureBox_SplashLogo1 = new PictureBox
            {
                Name = "PictureBox_SplashLogo1",
                BackColor = backgroundColour,
                BackgroundImage = SPLASH1,
                BackgroundImageLayout = ImageLayout.Stretch,
                Size = new Size(96, 104),
                Location = new Point(144, 0),
            };

            PictureBox PictureBox_SplashLogo2 = new PictureBox
            {
                Name = "PictureBox_SplashLogo2",
                BackColor = backgroundColour,
                BackgroundImage = SPLASH2,
                BackgroundImageLayout = ImageLayout.Stretch,
                Size = new Size(96, 104),
                Location = new Point(144, 0),
            };

            PictureBox PictureBox_SplashLogo3 = new PictureBox
            {
                Name = "PictureBox_SplashLogo3",
                BackColor = backgroundColour,
                BackgroundImage = SPLASH3,
                BackgroundImageLayout = ImageLayout.Stretch,
                Size = new Size(96, 104),
                Location = new Point(144, 0),
            };

            PictureBox PictureBox_SplashLogo4 = new PictureBox
            {
                Name = "PictureBox_SplashLogo4",
                BackColor = backgroundColour,
                BackgroundImage = SPLASH4,
                BackgroundImageLayout = ImageLayout.Stretch,
                Size = new Size(96, 104),
                Location = new Point(144, 0),
            };

            Label Label_SplashTitle1 = new Label
            {
                Name = "Label_SplashTitle1",
                BackColor = backgroundColour,
                ForeColor = Color.White,
                Size = new Size(374, 94),
                Location = new Point(0, 104),
                Text = "Catch the most important bugs",
                Font = new Font("Arial", 18f, FontStyle.Bold),
                TextAlign = ContentAlignment.MiddleLeft,
            };

            Label Label_SplashTitle2 = new Label
            {
                Name = "Label_SplashTitle2",
                BackColor = backgroundColour,
                ForeColor = Color.White,
                Size = new Size(374, 94),
                Location = new Point(0, 104),
                Text = "Fix and clean the latest issues",
                Font = new Font("Arial", 18f, FontStyle.Bold),
                TextAlign = ContentAlignment.MiddleLeft,
            };

            Label Label_SplashTitle3 = new Label
            {
                Name = "Label_SplashTitle3",
                BackColor = backgroundColour,
                ForeColor = Color.White,
                Size = new Size(374, 94),
                Location = new Point(0, 104),
                Text = "Track projects to be up to date",
                Font = new Font("Arial", 18f, FontStyle.Bold),
                TextAlign = ContentAlignment.MiddleLeft,
            };

            Label Label_SplashTitle4 = new Label
            {
                Name = "Label_SplashTitle4",
                BackColor = backgroundColour,
                ForeColor = Color.White,
                Size = new Size(374, 94),
                Location = new Point(0, 104),
                Text = "Easily view your contributions",
                Font = new Font("Arial", 18f, FontStyle.Bold),
                TextAlign = ContentAlignment.MiddleLeft,
            };

            Label Label_SplashText1 = new Label
            {
                Name = "Label_SplashText1",
                BackColor = backgroundColour,
                ForeColor = Color.White,
                Size = new Size(374, 94),
                Location = new Point(0, 198),
                Text = "Found a bug? You can submit it to the relevant " +
                       "project where other users will be notified." +
                       "\nSimple and effective.",
                Font = new Font("Arial", 10f, FontStyle.Bold),
                TextAlign = ContentAlignment.TopLeft,
            };

            Label Label_SplashText2 = new Label
            {
                Name = "Label_SplashText2",
                BackColor = backgroundColour,
                ForeColor = Color.White,
                Size = new Size(374, 94),
                Location = new Point(0, 198),
                Text = "Developer who loves to tinker? Browse an endless " +
                       "supply of bugs that need your help. The new recent " +
                       "tab will keep you busy.",
                Font = new Font("Arial", 10f, FontStyle.Bold),
                TextAlign = ContentAlignment.TopLeft,
            };

            Label Label_SplashText3 = new Label
            {
                Name = "Label_SplashText3",
                BackColor = backgroundColour,
                ForeColor = Color.White,
                Size = new Size(374, 94),
                Location = new Point(0, 198),
                Text = "Want to know what the latest bugs are? Follow a " +
                       "project or create your own to be notified as soon as " +
                       "a bug has been reported.",
                Font = new Font("Arial", 10f, FontStyle.Bold),
                TextAlign = ContentAlignment.TopLeft,
            };

            Label Label_SplashText4 = new Label
            {
                Name = "Label_SplashText4",
                BackColor = backgroundColour,
                ForeColor = Color.White,
                Size = new Size(374, 94),
                Location = new Point(0, 198),
                Text = "Like to see visual data? View your progress and " +
                       "statistics on your dashboard. There are some " +
                       "hidden rewards for your contributions.",
                Font = new Font("Arial", 10f, FontStyle.Bold),
                TextAlign = ContentAlignment.TopLeft,
            };

            Panel_Page1.Controls.Add(PictureBox_SplashLogo1);
            Panel_Page2.Controls.Add(PictureBox_SplashLogo2);
            Panel_Page3.Controls.Add(PictureBox_SplashLogo3);
            Panel_Page4.Controls.Add(PictureBox_SplashLogo4);

            Panel_Page1.Controls.Add(Label_SplashTitle1);
            Panel_Page2.Controls.Add(Label_SplashTitle2);
            Panel_Page3.Controls.Add(Label_SplashTitle3);
            Panel_Page4.Controls.Add(Label_SplashTitle4);

            Panel_Page1.Controls.Add(Label_SplashText1);
            Panel_Page2.Controls.Add(Label_SplashText2);
            Panel_Page3.Controls.Add(Label_SplashText3);
            Panel_Page4.Controls.Add(Label_SplashText4);

            Controls.Add(Panel_Page1);
            Controls.Add(Panel_Page2);
            Controls.Add(Panel_Page3);
            Controls.Add(Panel_Page4);
            Panel_Page1.Show();
            Panel_Page2.Hide();
            Panel_Page3.Hide();
            Panel_Page4.Hide();
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
            int x1 = Panel_Page1.Location.X;
            int y1 = Panel_Page1.Location.Y;
            int x2 = Panel_Page2.Location.X;
            int y2 = Panel_Page2.Location.Y;
            int x3 = Panel_Page3.Location.X;
            int y3 = Panel_Page3.Location.Y;
            int x4 = Panel_Page4.Location.X;
            int y4 = Panel_Page4.Location.Y;

            if (Panel_Page2.Visible)
            {
                while (Panel_Page2.Location.X != (0 - Panel_Page2.Width))
                {
                    x2 -= 1;
                    Panel_Page2.Location = new Point(x2, y2);
                }
                Panel_Page2.Location = new Point(456, 137);
                Panel_Page2.Hide();
                //Controls.Remove(Panel_Page2);
            }
            else if (Panel_Page3.Visible)
            {
                while (Panel_Page3.Location.X != (0 - Panel_Page3.Width))
                {
                    x3 -= 1;
                    Panel_Page3.Location = new Point(x3, y3);
                }
                Panel_Page3.Location = new Point(456, 137);
                Panel_Page3.Hide();
                //Controls.Remove(Panel_Page3);
            }
            else if (Panel_Page4.Visible)
            {
                while (Panel_Page4.Location.X != (0 - Panel_Page4.Width))
                {
                    x4 -= 1;
                    Panel_Page4.Location = new Point(x4, y4);
                }
                Panel_Page4.Location = new Point(456, 137);
                Panel_Page4.Hide();
                //Controls.Remove(Panel_Page4);
            }

            //Controls.Add(Panel_Page1);
            Panel_Page1.Show();

            while (Panel_Page1.Location.X != 41)
            {
                x1 -= 1;
                Panel_Page1.Location = new Point(x1, y1);
            }
        }

        private void ActivatePage2()
        {
            int x1 = Panel_Page1.Location.X;
            int y1 = Panel_Page1.Location.Y;
            int x2 = Panel_Page2.Location.X;
            int y2 = Panel_Page2.Location.Y;
            int x3 = Panel_Page3.Location.X;
            int y3 = Panel_Page3.Location.Y;
            int x4 = Panel_Page4.Location.X;
            int y4 = Panel_Page4.Location.Y;


            if (Panel_Page1.Visible)
            {
                while (Panel_Page1.Location.X != (0 - Panel_Page1.Width) && Panel_Page2.Location.X != 41)
                {
                    x1 -= 1;
                    Panel_Page1.Location = new Point(x1, y1);
                }
                Panel_Page1.Location = new Point(456, 137);
                Panel_Page1.Hide();
                //Controls.Remove(Panel_Page1);
            }
            else if (Panel_Page3.Visible)
            {
                while (Panel_Page3.Location.X != (0 - Panel_Page3.Width))
                {
                    x3 -= 1;
                    Panel_Page3.Location = new Point(x3, y3);
                }
                Panel_Page3.Location = new Point(456, 137);
                Panel_Page3.Hide();
                //Controls.Remove(Panel_Page3);
            }
            else if (Panel_Page4.Visible)
            {
                while (Panel_Page4.Location.X != (0 - Panel_Page4.Width))
                {
                    x4 -= 1;
                    Panel_Page4.Location = new Point(x4, y4);
                }
                Panel_Page4.Location = new Point(456, 137);
                Panel_Page4.Hide();
                //Controls.Remove(Panel_Page4);
            }

            //Controls.Add(Panel_Page2);
            Panel_Page2.Show();

            while (Panel_Page2.Location.X != 41)
            {
                x2 -= 1;
                Panel_Page2.Location = new Point(x2, y2);
                Thread.Sleep(1);
            }
        }

        private void ActivatePage3()
        {
            int x1 = Panel_Page1.Location.X;
            int y1 = Panel_Page1.Location.Y;
            int x2 = Panel_Page2.Location.X;
            int y2 = Panel_Page2.Location.Y;
            int x3 = Panel_Page3.Location.X;
            int y3 = Panel_Page3.Location.Y;
            int x4 = Panel_Page4.Location.X;
            int y4 = Panel_Page4.Location.Y;

            if (Panel_Page1.Visible)
            {
                while (Panel_Page1.Location.X != (0 - Panel_Page1.Width))
                {
                    x1 -= 1;
                    Panel_Page1.Location = new Point(x1, y1);
                }
                Panel_Page1.Location = new Point(456, 137);
                Panel_Page1.Hide();
                //Controls.Remove(Panel_Page1);
            }
            else if (Panel_Page2.Visible)
            {
                while (Panel_Page2.Location.X != (0 - Panel_Page2.Width))
                {
                    x2 -= 1;
                    Panel_Page2.Location = new Point(x2, y2);
                }
                Panel_Page2.Location = new Point(456, 137);
                Panel_Page2.Hide();
                //Controls.Remove(Panel_Page2);
            }
            else if (Panel_Page4.Visible)
            {
                while (Panel_Page4.Location.X != (0 - Panel_Page4.Width))
                {
                    x4 -= 1;
                    Panel_Page4.Location = new Point(x4, y4);
                }
                Panel_Page4.Location = new Point(456, 137);
                Panel_Page4.Hide();
                //Controls.Remove(Panel_Page4);
            }

            //Controls.Add(Panel_Page3);
            Panel_Page3.Show();

            while (Panel_Page3.Location.X != 41)
            {
                x3 -= 1;
                Panel_Page3.Location = new Point(x3, y3);
            }
        }

        private void ActivatePage4()
        {
            int x1 = Panel_Page1.Location.X;
            int y1 = Panel_Page1.Location.Y;
            int x2 = Panel_Page2.Location.X;
            int y2 = Panel_Page2.Location.Y;
            int x3 = Panel_Page3.Location.X;
            int y3 = Panel_Page3.Location.Y;
            int x4 = Panel_Page4.Location.X;
            int y4 = Panel_Page4.Location.Y;

            if (Panel_Page1.Visible)
            {
                while (Panel_Page1.Location.X != (0 - Panel_Page1.Width))
                {
                    x1 -= 1;
                    Panel_Page1.Location = new Point(x1, y1);
                }
                Panel_Page1.Location = new Point(Right, 137);
                Panel_Page1.Hide();
                //Controls.Remove(Panel_Page1);
            }
            else if (Panel_Page2.Visible)
            {
                while (Panel_Page2.Location.X != (0 - Panel_Page2.Width))
                {
                    x2 -= 1;
                    Panel_Page2.Location = new Point(x2, y2);
                }
                Panel_Page2.Location = new Point(Right, 137);
                Panel_Page2.Hide();
                //Controls.Remove(Panel_Page2);
            }
            else if (Panel_Page3.Visible)
            {
                while (Panel_Page3.Location.X != (0 - Panel_Page3.Width))
                {
                    x3 -= 1;
                    Panel_Page3.Location = new Point(x3, y3);
                }
                Panel_Page3.Location = new Point(Right, 137);
                Panel_Page3.Hide();
                //Controls.Remove(Panel_Page3);
            }

            //Controls.Add(Panel_Page4);
            Panel_Page4.Show();

            while (Panel_Page4.Location.X != 41)
            {
                x4 -= 1;
                Panel_Page4.Location = new Point(x4, y4);
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
