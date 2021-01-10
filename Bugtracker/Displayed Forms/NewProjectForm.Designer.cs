namespace Bugtracker
{
    partial class NewProjectForm
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
            this.TextBox_ProjectName = new System.Windows.Forms.TextBox();
            this.Label_ProjectName = new System.Windows.Forms.Label();
            this.RichTextBox_Description = new System.Windows.Forms.RichTextBox();
            this.Label_ProjectDescription = new System.Windows.Forms.Label();
            this.Button_SaveProject = new System.Windows.Forms.Button();
            this.Button_BackBtn = new System.Windows.Forms.Button();
            this.CheckBox_PrivateProject = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // TextBox_ProjectName
            // 
            this.TextBox_ProjectName.Location = new System.Drawing.Point(82, 61);
            this.TextBox_ProjectName.Name = "TextBox_ProjectName";
            this.TextBox_ProjectName.Size = new System.Drawing.Size(100, 20);
            this.TextBox_ProjectName.TabIndex = 0;
            // 
            // Label_ProjectName
            // 
            this.Label_ProjectName.AutoSize = true;
            this.Label_ProjectName.Location = new System.Drawing.Point(82, 30);
            this.Label_ProjectName.Name = "Label_ProjectName";
            this.Label_ProjectName.Size = new System.Drawing.Size(69, 13);
            this.Label_ProjectName.TabIndex = 1;
            this.Label_ProjectName.Text = "Project name";
            // 
            // RichTextBox_Description
            // 
            this.RichTextBox_Description.Location = new System.Drawing.Point(85, 147);
            this.RichTextBox_Description.Name = "RichTextBox_Description";
            this.RichTextBox_Description.Size = new System.Drawing.Size(291, 65);
            this.RichTextBox_Description.TabIndex = 2;
            this.RichTextBox_Description.Text = "";
            // 
            // Label_ProjectDescription
            // 
            this.Label_ProjectDescription.AutoSize = true;
            this.Label_ProjectDescription.Location = new System.Drawing.Point(85, 116);
            this.Label_ProjectDescription.Name = "Label_ProjectDescription";
            this.Label_ProjectDescription.Size = new System.Drawing.Size(96, 13);
            this.Label_ProjectDescription.TabIndex = 3;
            this.Label_ProjectDescription.Text = "Project Description";
            // 
            // Button_SaveProject
            // 
            this.Button_SaveProject.Location = new System.Drawing.Point(350, 301);
            this.Button_SaveProject.Name = "Button_SaveProject";
            this.Button_SaveProject.Size = new System.Drawing.Size(75, 23);
            this.Button_SaveProject.TabIndex = 4;
            this.Button_SaveProject.Text = "Save";
            this.Button_SaveProject.UseVisualStyleBackColor = true;
            this.Button_SaveProject.Click += new System.EventHandler(this.Button_SaveProject_Click);
            // 
            // Button_BackBtn
            // 
            this.Button_BackBtn.Location = new System.Drawing.Point(85, 300);
            this.Button_BackBtn.Name = "Button_BackBtn";
            this.Button_BackBtn.Size = new System.Drawing.Size(75, 23);
            this.Button_BackBtn.TabIndex = 5;
            this.Button_BackBtn.Text = "Back";
            this.Button_BackBtn.UseVisualStyleBackColor = true;
            this.Button_BackBtn.Click += new System.EventHandler(this.Button_BackBtn_Click);
            // 
            // CheckBox_PrivateProject
            // 
            this.CheckBox_PrivateProject.AutoSize = true;
            this.CheckBox_PrivateProject.Location = new System.Drawing.Point(88, 247);
            this.CheckBox_PrivateProject.Name = "CheckBox_PrivateProject";
            this.CheckBox_PrivateProject.Size = new System.Drawing.Size(398, 17);
            this.CheckBox_PrivateProject.TabIndex = 7;
            this.CheckBox_PrivateProject.Text = "Check Box To Make Project Private (only users you select can see/ post bugs)";
            this.CheckBox_PrivateProject.UseVisualStyleBackColor = true;
            // 
            // NewProjectForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(620, 480);
            this.Controls.Add(this.CheckBox_PrivateProject);
            this.Controls.Add(this.Button_BackBtn);
            this.Controls.Add(this.Button_SaveProject);
            this.Controls.Add(this.Label_ProjectDescription);
            this.Controls.Add(this.RichTextBox_Description);
            this.Controls.Add(this.Label_ProjectName);
            this.Controls.Add(this.TextBox_ProjectName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimumSize = new System.Drawing.Size(620, 480);
            this.Name = "NewProjectForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "NewProjectForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TextBox_ProjectName;
        private System.Windows.Forms.Label Label_ProjectName;
        private System.Windows.Forms.RichTextBox RichTextBox_Description;
        private System.Windows.Forms.Label Label_ProjectDescription;
        private System.Windows.Forms.Button Button_SaveProject;
        private System.Windows.Forms.Button Button_BackBtn;
        private System.Windows.Forms.CheckBox CheckBox_PrivateProject;
    }
}