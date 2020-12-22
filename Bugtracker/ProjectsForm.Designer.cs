namespace Bugtracker
{
    partial class ProjectsForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.newProject = new System.Windows.Forms.Button();
            this.Panel_DisplayProjects = new System.Windows.Forms.Panel();
            this.Panel_Management = new System.Windows.Forms.Panel();
            this.Panel_Navigation.SuspendLayout();
            this.SuspendLayout();
            // 
            // Panel_Navigation
            // 
            this.Panel_Navigation.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.Panel_Navigation.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Panel_Navigation.Controls.Add(this.label1);
            this.Panel_Navigation.Location = new System.Drawing.Point(0, 0);
            this.Panel_Navigation.Name = "Panel_Navigation";
            this.Panel_Navigation.Size = new System.Drawing.Size(160, 563);
            this.Panel_Navigation.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "logged in user";
            // 
            // newProject
            // 
            this.newProject.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.newProject.Location = new System.Drawing.Point(648, 72);
            this.newProject.Name = "newProject";
            this.newProject.Size = new System.Drawing.Size(124, 33);
            this.newProject.TabIndex = 2;
            this.newProject.Text = "New Project";
            this.newProject.UseVisualStyleBackColor = true;
            this.newProject.Click += new System.EventHandler(this.NewProject_Click);
            // 
            // Panel_DisplayProjects
            // 
            this.Panel_DisplayProjects.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Panel_DisplayProjects.AutoScroll = true;
            this.Panel_DisplayProjects.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Panel_DisplayProjects.Location = new System.Drawing.Point(166, 111);
            this.Panel_DisplayProjects.Name = "Panel_DisplayProjects";
            this.Panel_DisplayProjects.Size = new System.Drawing.Size(617, 452);
            this.Panel_DisplayProjects.TabIndex = 3;
            // 
            // Panel_Management
            // 
            this.Panel_Management.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Panel_Management.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Panel_Management.Location = new System.Drawing.Point(169, 0);
            this.Panel_Management.Name = "Panel_Management";
            this.Panel_Management.Size = new System.Drawing.Size(614, 56);
            this.Panel_Management.TabIndex = 1;
            // 
            // ProjectsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.Panel_Management);
            this.Controls.Add(this.Panel_DisplayProjects);
            this.Controls.Add(this.newProject);
            this.Controls.Add(this.Panel_Navigation);
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "ProjectsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "project";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Resize += new System.EventHandler(this.ProjectsForm_Resize);
            this.Panel_Navigation.ResumeLayout(false);
            this.Panel_Navigation.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Panel_Navigation;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button newProject;
        private System.Windows.Forms.Panel Panel_DisplayProjects;
        private System.Windows.Forms.Panel Panel_Management;
    }
}