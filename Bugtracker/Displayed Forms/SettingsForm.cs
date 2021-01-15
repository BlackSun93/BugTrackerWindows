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
            Panel_ContainerPanel.BackColor = Properties.Settings.Default.containerPanel_Color;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            colorDialog_ManagementPanel.ShowDialog();
            Panel_Management.BackColor = colorDialog_ManagementPanel.Color;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            colorDialog_ContainerPanel.ShowDialog();
            Panel_ContainerPanel.BackColor = colorDialog_ContainerPanel.Color;
        }

        private void Button_Save_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.managementPanel_Color = Panel_Management.BackColor;
            Properties.Settings.Default.containerPanel_Color = Panel_ContainerPanel.BackColor;
            display.Recolor();
            Properties.Settings.Default.Save();
        }

        private void Panel_Management_Click(object sender, EventArgs e)
        {
            colorDialog_ManagementPanel.ShowDialog();
            Panel_Management.BackColor = colorDialog_ManagementPanel.Color;
        }

        private void Panel_ContainerPanel_Click(object sender, EventArgs e)
        {
            colorDialog_ContainerPanel.ShowDialog();
            Panel_ContainerPanel.BackColor = colorDialog_ContainerPanel.Color;
        }
    }
}
