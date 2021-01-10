
namespace Bugtracker
{
    partial class SettingsForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Button_Save = new System.Windows.Forms.Button();
            this.Panel_MiniWindow = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.Panel_Navigation = new System.Windows.Forms.Panel();
            this.Label_Settings = new System.Windows.Forms.Label();
            this.Label_Recent = new System.Windows.Forms.Label();
            this.Label_Projects = new System.Windows.Forms.Label();
            this.Panel_DisplayBugs = new System.Windows.Forms.Panel();
            this.Label_Dashboard = new System.Windows.Forms.Label();
            this.Label_Tracker = new System.Windows.Forms.Label();
            this.Label_Bug = new System.Windows.Forms.Label();
            this.Panel_Management = new System.Windows.Forms.Panel();
            this.Panel_BackPanel = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.colorDialog_TopBar = new System.Windows.Forms.ColorDialog();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.colorDialog_BackPanel = new System.Windows.Forms.ColorDialog();
            this.button2 = new System.Windows.Forms.Button();
            this.Panel_MiniWindow.SuspendLayout();
            this.Panel_Navigation.SuspendLayout();
            this.Panel_DisplayBugs.SuspendLayout();
            this.Panel_BackPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // Button_Save
            // 
            this.Button_Save.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(85)))), ((int)(((byte)(0)))));
            this.Button_Save.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Button_Save.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Button_Save.FlatAppearance.BorderSize = 0;
            this.Button_Save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_Save.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_Save.ForeColor = System.Drawing.Color.White;
            this.Button_Save.Location = new System.Drawing.Point(41, 429);
            this.Button_Save.Margin = new System.Windows.Forms.Padding(32, 8, 8, 16);
            this.Button_Save.Name = "Button_Save";
            this.Button_Save.Size = new System.Drawing.Size(108, 26);
            this.Button_Save.TabIndex = 6;
            this.Button_Save.Text = "Save";
            this.Button_Save.UseVisualStyleBackColor = false;
            this.Button_Save.Click += new System.EventHandler(this.Button_Save_Click);
            // 
            // Panel_MiniWindow
            // 
            this.Panel_MiniWindow.Controls.Add(this.Panel_Navigation);
            this.Panel_MiniWindow.Location = new System.Drawing.Point(139, 176);
            this.Panel_MiniWindow.Name = "Panel_MiniWindow";
            this.Panel_MiniWindow.Size = new System.Drawing.Size(300, 225);
            this.Panel_MiniWindow.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(62, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Top bar";
            // 
            // Panel_Navigation
            // 
            this.Panel_Navigation.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.Panel_Navigation.BackColor = System.Drawing.Color.White;
            this.Panel_Navigation.Controls.Add(this.Label_Settings);
            this.Panel_Navigation.Controls.Add(this.Label_Recent);
            this.Panel_Navigation.Controls.Add(this.Label_Projects);
            this.Panel_Navigation.Controls.Add(this.Panel_DisplayBugs);
            this.Panel_Navigation.Controls.Add(this.Label_Dashboard);
            this.Panel_Navigation.Controls.Add(this.Label_Tracker);
            this.Panel_Navigation.Controls.Add(this.Label_Bug);
            this.Panel_Navigation.Location = new System.Drawing.Point(0, 0);
            this.Panel_Navigation.Margin = new System.Windows.Forms.Padding(0);
            this.Panel_Navigation.Name = "Panel_Navigation";
            this.Panel_Navigation.Size = new System.Drawing.Size(300, 225);
            this.Panel_Navigation.TabIndex = 3;
            // 
            // Label_Settings
            // 
            this.Label_Settings.AutoSize = true;
            this.Label_Settings.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Label_Settings.Font = new System.Drawing.Font("Arial", 4F, System.Drawing.FontStyle.Bold);
            this.Label_Settings.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(82)))), ((int)(((byte)(82)))));
            this.Label_Settings.Location = new System.Drawing.Point(17, 144);
            this.Label_Settings.Name = "Label_Settings";
            this.Label_Settings.Size = new System.Drawing.Size(27, 6);
            this.Label_Settings.TabIndex = 5;
            this.Label_Settings.Text = "Settings";
            // 
            // Label_Recent
            // 
            this.Label_Recent.AutoSize = true;
            this.Label_Recent.Cursor = System.Windows.Forms.Cursors.No;
            this.Label_Recent.Font = new System.Drawing.Font("Arial", 4F, System.Drawing.FontStyle.Bold);
            this.Label_Recent.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(82)))), ((int)(((byte)(82)))));
            this.Label_Recent.Location = new System.Drawing.Point(17, 90);
            this.Label_Recent.Name = "Label_Recent";
            this.Label_Recent.Size = new System.Drawing.Size(22, 6);
            this.Label_Recent.TabIndex = 4;
            this.Label_Recent.Text = "Recent";
            // 
            // Label_Projects
            // 
            this.Label_Projects.AutoSize = true;
            this.Label_Projects.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Label_Projects.Font = new System.Drawing.Font("Arial", 4F, System.Drawing.FontStyle.Bold);
            this.Label_Projects.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(82)))), ((int)(((byte)(82)))));
            this.Label_Projects.Location = new System.Drawing.Point(17, 74);
            this.Label_Projects.Name = "Label_Projects";
            this.Label_Projects.Size = new System.Drawing.Size(26, 6);
            this.Label_Projects.TabIndex = 3;
            this.Label_Projects.Text = "Projects";
            // 
            // Panel_DisplayBugs
            // 
            this.Panel_DisplayBugs.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.Panel_DisplayBugs.Controls.Add(this.Panel_BackPanel);
            this.Panel_DisplayBugs.Location = new System.Drawing.Point(76, 46);
            this.Panel_DisplayBugs.Name = "Panel_DisplayBugs";
            this.Panel_DisplayBugs.Size = new System.Drawing.Size(221, 179);
            this.Panel_DisplayBugs.TabIndex = 1;
            // 
            // Label_Dashboard
            // 
            this.Label_Dashboard.AutoSize = true;
            this.Label_Dashboard.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Label_Dashboard.Font = new System.Drawing.Font("Arial", 4F, System.Drawing.FontStyle.Bold);
            this.Label_Dashboard.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(82)))), ((int)(((byte)(82)))));
            this.Label_Dashboard.Location = new System.Drawing.Point(17, 56);
            this.Label_Dashboard.Name = "Label_Dashboard";
            this.Label_Dashboard.Size = new System.Drawing.Size(34, 6);
            this.Label_Dashboard.TabIndex = 2;
            this.Label_Dashboard.Text = "Dashboard";
            // 
            // Label_Tracker
            // 
            this.Label_Tracker.AutoSize = true;
            this.Label_Tracker.Font = new System.Drawing.Font("Arial", 6F, System.Drawing.FontStyle.Bold);
            this.Label_Tracker.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(82)))), ((int)(((byte)(82)))));
            this.Label_Tracker.Location = new System.Drawing.Point(16, 26);
            this.Label_Tracker.Name = "Label_Tracker";
            this.Label_Tracker.Size = new System.Drawing.Size(44, 10);
            this.Label_Tracker.TabIndex = 1;
            this.Label_Tracker.Text = "TRACKER";
            // 
            // Label_Bug
            // 
            this.Label_Bug.AutoSize = true;
            this.Label_Bug.Font = new System.Drawing.Font("Arial", 6F, System.Drawing.FontStyle.Bold);
            this.Label_Bug.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(85)))), ((int)(((byte)(0)))));
            this.Label_Bug.Location = new System.Drawing.Point(16, 16);
            this.Label_Bug.Name = "Label_Bug";
            this.Label_Bug.Size = new System.Drawing.Size(23, 10);
            this.Label_Bug.TabIndex = 0;
            this.Label_Bug.Text = "BUG";
            // 
            // Panel_Management
            // 
            this.Panel_Management.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Panel_Management.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(85)))), ((int)(((byte)(0)))));
            this.Panel_Management.Location = new System.Drawing.Point(215, 176);
            this.Panel_Management.Margin = new System.Windows.Forms.Padding(0, 0, 8, 0);
            this.Panel_Management.MaximumSize = new System.Drawing.Size(224, 43);
            this.Panel_Management.Name = "Panel_Management";
            this.Panel_Management.Size = new System.Drawing.Size(224, 43);
            this.Panel_Management.TabIndex = 6;
            // 
            // Panel_BackPanel
            // 
            this.Panel_BackPanel.BackColor = System.Drawing.Color.Yellow;
            this.Panel_BackPanel.Controls.Add(this.panel5);
            this.Panel_BackPanel.Controls.Add(this.panel4);
            this.Panel_BackPanel.Controls.Add(this.panel3);
            this.Panel_BackPanel.Controls.Add(this.panel2);
            this.Panel_BackPanel.Location = new System.Drawing.Point(26, 10);
            this.Panel_BackPanel.Name = "Panel_BackPanel";
            this.Panel_BackPanel.Size = new System.Drawing.Size(174, 166);
            this.Panel_BackPanel.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(80, 80);
            this.panel2.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Location = new System.Drawing.Point(91, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(80, 80);
            this.panel3.TabIndex = 1;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.Location = new System.Drawing.Point(3, 86);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(80, 80);
            this.panel4.TabIndex = 2;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.White;
            this.panel5.Location = new System.Drawing.Point(91, 86);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(80, 80);
            this.panel5.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(139, 29);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "set colour";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(62, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Back panel";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(139, 67);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 11;
            this.button2.Text = "set colour";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(620, 480);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Panel_Management);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Panel_MiniWindow);
            this.Controls.Add(this.Button_Save);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SettingsForm";
            this.Text = "SettingsForm";
            this.Panel_MiniWindow.ResumeLayout(false);
            this.Panel_Navigation.ResumeLayout(false);
            this.Panel_Navigation.PerformLayout();
            this.Panel_DisplayBugs.ResumeLayout(false);
            this.Panel_BackPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Button_Save;
        private System.Windows.Forms.Panel Panel_MiniWindow;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel Panel_Navigation;
        private System.Windows.Forms.Label Label_Settings;
        private System.Windows.Forms.Label Label_Recent;
        private System.Windows.Forms.Label Label_Projects;
        private System.Windows.Forms.Panel Panel_DisplayBugs;
        private System.Windows.Forms.Label Label_Dashboard;
        private System.Windows.Forms.Label Label_Tracker;
        private System.Windows.Forms.Label Label_Bug;
        private System.Windows.Forms.Panel Panel_Management;
        private System.Windows.Forms.Panel Panel_BackPanel;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.ColorDialog colorDialog_TopBar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ColorDialog colorDialog_BackPanel;
        private System.Windows.Forms.Button button2;
    }
}