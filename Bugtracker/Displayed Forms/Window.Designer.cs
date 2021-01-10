namespace Bugtracker
{
    partial class Window
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
            this.Panel_Navigation = new System.Windows.Forms.Panel();
            this.Label_Recent = new System.Windows.Forms.Label();
            this.Label_Projects = new System.Windows.Forms.Label();
            this.Panel_DisplayBugs = new System.Windows.Forms.Panel();
            this.Label_Dashboard = new System.Windows.Forms.Label();
            this.Label_Tracker = new System.Windows.Forms.Label();
            this.Label_Bug = new System.Windows.Forms.Label();
            this.Panel_Management = new System.Windows.Forms.Panel();
            this.Panel_FormContent = new System.Windows.Forms.Panel();
            this.Label_Settings = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Panel_Navigation.SuspendLayout();
            this.SuspendLayout();
            // 
            // Panel_Navigation
            // 
            this.Panel_Navigation.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.Panel_Navigation.BackColor = System.Drawing.Color.White;
            this.Panel_Navigation.Controls.Add(this.label2);
            this.Panel_Navigation.Controls.Add(this.label1);
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
            this.Panel_Navigation.Size = new System.Drawing.Size(152, 561);
            this.Panel_Navigation.TabIndex = 2;
            // 
            // Label_Recent
            // 
            this.Label_Recent.AutoSize = true;
            this.Label_Recent.Cursor = System.Windows.Forms.Cursors.No;
            this.Label_Recent.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.Label_Recent.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(82)))), ((int)(((byte)(82)))));
            this.Label_Recent.Location = new System.Drawing.Point(20, 325);
            this.Label_Recent.Name = "Label_Recent";
            this.Label_Recent.Size = new System.Drawing.Size(74, 22);
            this.Label_Recent.TabIndex = 4;
            this.Label_Recent.Text = "Recent";
            this.Label_Recent.Click += new System.EventHandler(this.Label_Recent_Click);
            // 
            // Label_Projects
            // 
            this.Label_Projects.AutoSize = true;
            this.Label_Projects.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Label_Projects.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.Label_Projects.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(82)))), ((int)(((byte)(82)))));
            this.Label_Projects.Location = new System.Drawing.Point(20, 266);
            this.Label_Projects.Name = "Label_Projects";
            this.Label_Projects.Size = new System.Drawing.Size(87, 22);
            this.Label_Projects.TabIndex = 3;
            this.Label_Projects.Text = "Projects";
            this.Label_Projects.Click += new System.EventHandler(this.Label_Projects_Click);
            // 
            // Panel_DisplayBugs
            // 
            this.Panel_DisplayBugs.Location = new System.Drawing.Point(201, 67);
            this.Panel_DisplayBugs.Name = "Panel_DisplayBugs";
            this.Panel_DisplayBugs.Size = new System.Drawing.Size(590, 502);
            this.Panel_DisplayBugs.TabIndex = 1;
            // 
            // Label_Dashboard
            // 
            this.Label_Dashboard.AutoSize = true;
            this.Label_Dashboard.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Label_Dashboard.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.Label_Dashboard.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(82)))), ((int)(((byte)(82)))));
            this.Label_Dashboard.Location = new System.Drawing.Point(16, 204);
            this.Label_Dashboard.Name = "Label_Dashboard";
            this.Label_Dashboard.Size = new System.Drawing.Size(113, 22);
            this.Label_Dashboard.TabIndex = 2;
            this.Label_Dashboard.Text = "Dashboard";
            this.Label_Dashboard.Click += new System.EventHandler(this.Label_Dashboard_Click);
            // 
            // Label_Tracker
            // 
            this.Label_Tracker.AutoSize = true;
            this.Label_Tracker.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold);
            this.Label_Tracker.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(82)))), ((int)(((byte)(82)))));
            this.Label_Tracker.Location = new System.Drawing.Point(16, 40);
            this.Label_Tracker.Name = "Label_Tracker";
            this.Label_Tracker.Size = new System.Drawing.Size(112, 24);
            this.Label_Tracker.TabIndex = 1;
            this.Label_Tracker.Text = "TRACKER";
            // 
            // Label_Bug
            // 
            this.Label_Bug.AutoSize = true;
            this.Label_Bug.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold);
            this.Label_Bug.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(85)))), ((int)(((byte)(0)))));
            this.Label_Bug.Location = new System.Drawing.Point(16, 16);
            this.Label_Bug.Name = "Label_Bug";
            this.Label_Bug.Size = new System.Drawing.Size(55, 24);
            this.Label_Bug.TabIndex = 0;
            this.Label_Bug.Text = "BUG";
            // 
            // Panel_Management
            // 
            this.Panel_Management.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Panel_Management.AutoSize = true;
            this.Panel_Management.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(85)))), ((int)(((byte)(0)))));
            this.Panel_Management.Location = new System.Drawing.Point(152, 0);
            this.Panel_Management.Margin = new System.Windows.Forms.Padding(0, 0, 8, 0);
            this.Panel_Management.Name = "Panel_Management";
            this.Panel_Management.Size = new System.Drawing.Size(631, 66);
            this.Panel_Management.TabIndex = 3;
            this.Panel_Management.Visible = true;
            // 
            // Panel_FormContent
            // 
            this.Panel_FormContent.Location = new System.Drawing.Point(152, 66);
            this.Panel_FormContent.Margin = new System.Windows.Forms.Padding(0, 0, 8, 0);
            this.Panel_FormContent.Name = "Panel_FormContent";
            this.Panel_FormContent.Size = new System.Drawing.Size(631, 493);
            this.Panel_FormContent.TabIndex = 4;
            // 
            // Label_Settings
            // 
            this.Label_Settings.AutoSize = true;
            this.Label_Settings.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Label_Settings.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.Label_Settings.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(82)))), ((int)(((byte)(82)))));
            this.Label_Settings.Location = new System.Drawing.Point(20, 460);
            this.Label_Settings.Name = "Label_Settings";
            this.Label_Settings.Size = new System.Drawing.Size(86, 22);
            this.Label_Settings.TabIndex = 5;
            this.Label_Settings.Text = "Settings";
            this.Label_Settings.Click += new System.EventHandler(this.Label_Settings_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "label2";
            // 
            // Window
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.Panel_FormContent);
            this.Controls.Add(this.Panel_Management);
            this.Controls.Add(this.Panel_Navigation);
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "Window";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BugTracker";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResizeEnd += new System.EventHandler(this.Window_Resize);
            this.Panel_Navigation.ResumeLayout(false);
            this.Panel_Navigation.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel Panel_Navigation;
        private System.Windows.Forms.Label Label_Recent;
        private System.Windows.Forms.Label Label_Projects;
        private System.Windows.Forms.Panel Panel_DisplayBugs;
        private System.Windows.Forms.Label Label_Dashboard;
        private System.Windows.Forms.Label Label_Tracker;
        private System.Windows.Forms.Label Label_Bug;
        private System.Windows.Forms.Panel Panel_Management;
        private System.Windows.Forms.Panel Panel_FormContent;
        private System.Windows.Forms.Label Label_Settings;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}