using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Collections.Specialized;

namespace Bugtracker
{
    public partial class SettingsForm : Form
    {
        Window display;
        DrawPanels dp = new DrawPanels();
        public SettingsForm(Window window)
        {
            InitializeComponent();
            display = window;
            Size = new Size(window.Width, window.Height);
            UpdateMiniWindowDisplay();
        }

        private void UpdateMiniWindowDisplay()
        {
            //Panel_MiniWindow.Controls.Add(new Window()); 

            Panel_Management.BackColor = Properties.Settings.Default.managementPanel_Color;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            colorDialog_TopBar.ShowDialog();
            Panel_Management.BackColor = colorDialog_TopBar.Color;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            colorDialog_BackPanel.ShowDialog();
            Panel_BackPanel.BackColor = colorDialog_BackPanel.Color;
        }

        private void Button_Save_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.managementPanel_Color = Panel_Management.BackColor;
            display.Recolor();
            Properties.Settings.Default.Save();
        }
    }
}
