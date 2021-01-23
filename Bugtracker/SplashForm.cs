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
    public partial class SplashForm : Form
    {
        private Bitmap SPLASH1 = Properties.Resources.bt_splash_1;
        private Bitmap SPLASH2 = Properties.Resources.bt_splash_2;
        private Bitmap SPLASH3 = Properties.Resources.bt_splash_3;
        private Bitmap SPLASH4 = Properties.Resources.bt_splash_4;

        public SplashForm(int version)
        {
            InitializeComponent();

            switch (version)
            {
                case 1:
                    Opacity = 0;
                    PictureBox_SplashLogo.BackgroundImage = SPLASH1;
                    Label_SplashTitle.Text = "Catch the most important bugs";
                    Label_SplashText.Text = "Found a bug? You can submit it to the relevant " +
                                            "project where other users will be notified." +
                                            "\nSimple and effective.";
                    break;

                case 2:
                    Opacity = 0;
                    PictureBox_SplashLogo.BackgroundImage = SPLASH2;
                    Label_SplashTitle.Text = "Fix and clean the latest issues";
                    Label_SplashText.Text = "Developer who loves to tinker? Browse an endless " +
                                            "supply of bugs that need your help. The new recent " +
                                            "tab will keep you busy.";
                    break;

                case 3:
                    Opacity = 0;
                    PictureBox_SplashLogo.BackgroundImage = SPLASH3;
                    Label_SplashTitle.Text = "Track projects to be up to date";
                    Label_SplashText.Text = "Want to know what the latest bugs are? Follow a " +
                                            "project or create your own to be notified as soon as " +
                                            "a bug has been reported.";
                    break;

                case 4:
                    Opacity = 0;
                    PictureBox_SplashLogo.BackgroundImage = SPLASH4;
                    Label_SplashTitle.Text = "Easily view your contributions";
                    Label_SplashText.Text = "Like to see visual data? View your progress and " +
                                            "statistics on your dashboard. There are some " +
                                            "hidden rewards for your contributions.";
                    break;
            }
        }
    }
}
