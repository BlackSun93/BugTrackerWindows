namespace Bugtracker
{
    partial class BugsForm
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
            this.BackBtn = new System.Windows.Forms.Button();
            this.Panel_DisplayBugs = new System.Windows.Forms.Panel();
            this.Panel_Navigation = new System.Windows.Forms.Panel();
            this.Label_Recent = new System.Windows.Forms.Label();
            this.Label_Projects = new System.Windows.Forms.Label();
            this.Label_Dashboard = new System.Windows.Forms.Label();
            this.Label_Tracker = new System.Windows.Forms.Label();
            this.Label_Bug = new System.Windows.Forms.Label();
            this.Panel_Management = new System.Windows.Forms.Panel();
            this.Button_NewBug = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Panel_Navigation.SuspendLayout();
            this.Panel_Management.SuspendLayout();
            this.SuspendLayout();
            // 
            // BackBtn
            // 
            this.BackBtn.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.BackBtn.Location = new System.Drawing.Point(3, 530);
            this.BackBtn.Name = "BackBtn";
            this.BackBtn.Size = new System.Drawing.Size(70, 28);
            this.BackBtn.TabIndex = 0;
            this.BackBtn.Text = "Back";
            this.BackBtn.UseVisualStyleBackColor = true;
            this.BackBtn.Click += new System.EventHandler(this.BackBtn_Click);
            // 
            // Panel_DisplayBugs
            // 
            this.Panel_DisplayBugs.Location = new System.Drawing.Point(201, 67);
            this.Panel_DisplayBugs.Name = "Panel_DisplayBugs";
            this.Panel_DisplayBugs.Size = new System.Drawing.Size(590, 502);
            this.Panel_DisplayBugs.TabIndex = 1;
            // 
            // Panel_Navigation
            // 
            this.Panel_Navigation.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.Panel_Navigation.BackColor = System.Drawing.Color.White;
            this.Panel_Navigation.Controls.Add(this.Label_Recent);
            this.Panel_Navigation.Controls.Add(this.Label_Projects);
            this.Panel_Navigation.Controls.Add(this.Panel_DisplayBugs);
            this.Panel_Navigation.Controls.Add(this.BackBtn);
            this.Panel_Navigation.Controls.Add(this.Label_Dashboard);
            this.Panel_Navigation.Controls.Add(this.Label_Tracker);
            this.Panel_Navigation.Controls.Add(this.Label_Bug);
            this.Panel_Navigation.Location = new System.Drawing.Point(-1, 0);
            this.Panel_Navigation.Margin = new System.Windows.Forms.Padding(0);
            this.Panel_Navigation.Name = "Panel_Navigation";
            this.Panel_Navigation.Size = new System.Drawing.Size(202, 561);
            this.Panel_Navigation.TabIndex = 1;
            // 
            // Label_Recent
            // 
            this.Label_Recent.AutoSize = true;
            this.Label_Recent.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.Label_Recent.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(82)))), ((int)(((byte)(82)))));
            this.Label_Recent.Location = new System.Drawing.Point(20, 325);
            this.Label_Recent.Name = "Label_Recent";
            this.Label_Recent.Size = new System.Drawing.Size(74, 22);
            this.Label_Recent.TabIndex = 4;
            this.Label_Recent.Text = "Recent";
            // 
            // Label_Projects
            // 
            this.Label_Projects.AutoSize = true;
            this.Label_Projects.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.Label_Projects.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(85)))), ((int)(((byte)(0)))));
            this.Label_Projects.Location = new System.Drawing.Point(20, 266);
            this.Label_Projects.Name = "Label_Projects";
            this.Label_Projects.Size = new System.Drawing.Size(87, 22);
            this.Label_Projects.TabIndex = 3;
            this.Label_Projects.Text = "Projects";
            // 
            // Label_Dashboard
            // 
            this.Label_Dashboard.AutoSize = true;
            this.Label_Dashboard.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.Label_Dashboard.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(82)))), ((int)(((byte)(82)))));
            this.Label_Dashboard.Location = new System.Drawing.Point(16, 204);
            this.Label_Dashboard.Name = "Label_Dashboard";
            this.Label_Dashboard.Size = new System.Drawing.Size(113, 22);
            this.Label_Dashboard.TabIndex = 2;
            this.Label_Dashboard.Text = "Dashboard";
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
            this.Panel_Management.Controls.Add(this.Button_NewBug);
            this.Panel_Management.Location = new System.Drawing.Point(201, 0);
            this.Panel_Management.Margin = new System.Windows.Forms.Padding(0);
            this.Panel_Management.Name = "Panel_Management";
            this.Panel_Management.Size = new System.Drawing.Size(600, 66);
            this.Panel_Management.TabIndex = 2;
            // 
            // Button_NewBug
            // 
            this.Button_NewBug.Location = new System.Drawing.Point(498, 30);
            this.Button_NewBug.Name = "Button_NewBug";
            this.Button_NewBug.Size = new System.Drawing.Size(89, 33);
            this.Button_NewBug.TabIndex = 0;
            this.Button_NewBug.Text = "Report A Bug";
            this.Button_NewBug.UseVisualStyleBackColor = true;
            this.Button_NewBug.Click += new System.EventHandler(this.Button_NewBug_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(225, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "label1";
            // 
            // BugsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Panel_Management);
            this.Controls.Add(this.Panel_Navigation);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "BugsForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "BugsForm";
            this.Panel_Navigation.ResumeLayout(false);
            this.Panel_Navigation.PerformLayout();
            this.Panel_Management.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BackBtn;
        private System.Windows.Forms.Panel Panel_DisplayBugs;
        private System.Windows.Forms.Panel Panel_Navigation;
        private System.Windows.Forms.Label Label_Recent;
        private System.Windows.Forms.Label Label_Projects;
        private System.Windows.Forms.Label Label_Dashboard;
        private System.Windows.Forms.Label Label_Tracker;
        private System.Windows.Forms.Label Label_Bug;
        private System.Windows.Forms.Panel Panel_Management;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Button_NewBug;
    }
}