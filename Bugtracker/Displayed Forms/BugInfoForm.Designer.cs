namespace Bugtracker
{
    partial class BugInfoForm
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
            this.Label_DescBugTitle = new System.Windows.Forms.Label();
            this.Labe_DescDescription = new System.Windows.Forms.Label();
            this.RichText_Description = new System.Windows.Forms.RichTextBox();
            this.Label_Title = new System.Windows.Forms.Label();
            this.Label_DescPoster = new System.Windows.Forms.Label();
            this.Label_Poster = new System.Windows.Forms.Label();
            this.Panel_Updates = new System.Windows.Forms.Panel();
            this.Button_AddUpdate = new System.Windows.Forms.Button();
            this.Button_Back = new System.Windows.Forms.Button();
            this.Label_DescPriority = new System.Windows.Forms.Label();
            this.Label_DescStatus = new System.Windows.Forms.Label();
            this.Label_Priority = new System.Windows.Forms.Label();
            this.Label_Status = new System.Windows.Forms.Label();
            this.Label_DescRefBug = new System.Windows.Forms.Label();
            this.Label_RefBug = new System.Windows.Forms.Label();
            this.Button_Follow = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Label_DescBugTitle
            // 
            this.Label_DescBugTitle.AutoSize = true;
            this.Label_DescBugTitle.Location = new System.Drawing.Point(63, 26);
            this.Label_DescBugTitle.Name = "Label_DescBugTitle";
            this.Label_DescBugTitle.Size = new System.Drawing.Size(27, 13);
            this.Label_DescBugTitle.TabIndex = 0;
            this.Label_DescBugTitle.Text = "Title";
            // 
            // Labe_DescDescription
            // 
            this.Labe_DescDescription.AutoSize = true;
            this.Labe_DescDescription.Location = new System.Drawing.Point(66, 79);
            this.Labe_DescDescription.Name = "Labe_DescDescription";
            this.Labe_DescDescription.Size = new System.Drawing.Size(60, 13);
            this.Labe_DescDescription.TabIndex = 1;
            this.Labe_DescDescription.Text = "Description";
            // 
            // RichText_Description
            // 
            this.RichText_Description.Location = new System.Drawing.Point(69, 104);
            this.RichText_Description.Name = "RichText_Description";
            this.RichText_Description.ReadOnly = true;
            this.RichText_Description.Size = new System.Drawing.Size(231, 96);
            this.RichText_Description.TabIndex = 2;
            this.RichText_Description.Text = "";
            // 
            // Label_Title
            // 
            this.Label_Title.AutoSize = true;
            this.Label_Title.Location = new System.Drawing.Point(120, 26);
            this.Label_Title.Name = "Label_Title";
            this.Label_Title.Size = new System.Drawing.Size(35, 13);
            this.Label_Title.TabIndex = 3;
            this.Label_Title.Text = "label1";
            // 
            // Label_DescPoster
            // 
            this.Label_DescPoster.AutoSize = true;
            this.Label_DescPoster.Location = new System.Drawing.Point(66, 226);
            this.Label_DescPoster.Name = "Label_DescPoster";
            this.Label_DescPoster.Size = new System.Drawing.Size(58, 13);
            this.Label_DescPoster.TabIndex = 4;
            this.Label_DescPoster.Text = "Posted By:";
            // 
            // Label_Poster
            // 
            this.Label_Poster.AutoSize = true;
            this.Label_Poster.Location = new System.Drawing.Point(130, 226);
            this.Label_Poster.Name = "Label_Poster";
            this.Label_Poster.Size = new System.Drawing.Size(35, 13);
            this.Label_Poster.TabIndex = 5;
            this.Label_Poster.Text = "label1";
            // 
            // Panel_Updates
            // 
            this.Panel_Updates.AutoScroll = true;
            this.Panel_Updates.Location = new System.Drawing.Point(360, 14);
            this.Panel_Updates.Name = "Panel_Updates";
            this.Panel_Updates.Size = new System.Drawing.Size(440, 460);
            this.Panel_Updates.TabIndex = 6;
            // 
            // Button_AddUpdate
            // 
            this.Button_AddUpdate.Location = new System.Drawing.Point(187, 445);
            this.Button_AddUpdate.Name = "Button_AddUpdate";
            this.Button_AddUpdate.Size = new System.Drawing.Size(75, 23);
            this.Button_AddUpdate.TabIndex = 8;
            this.Button_AddUpdate.Text = "New Update";
            this.Button_AddUpdate.UseVisualStyleBackColor = true;
            this.Button_AddUpdate.Click += new System.EventHandler(this.Button_AddUpdate_Click);
            // 
            // Button_Back
            // 
            this.Button_Back.Location = new System.Drawing.Point(39, 445);
            this.Button_Back.Name = "Button_Back";
            this.Button_Back.Size = new System.Drawing.Size(75, 23);
            this.Button_Back.TabIndex = 10;
            this.Button_Back.Text = "Back";
            this.Button_Back.UseVisualStyleBackColor = true;
            this.Button_Back.Click += new System.EventHandler(this.Button_Back_Click);
            // 
            // Label_DescPriority
            // 
            this.Label_DescPriority.AutoSize = true;
            this.Label_DescPriority.Location = new System.Drawing.Point(66, 261);
            this.Label_DescPriority.Name = "Label_DescPriority";
            this.Label_DescPriority.Size = new System.Drawing.Size(38, 13);
            this.Label_DescPriority.TabIndex = 11;
            this.Label_DescPriority.Text = "Priority";
            // 
            // Label_DescStatus
            // 
            this.Label_DescStatus.AutoSize = true;
            this.Label_DescStatus.Location = new System.Drawing.Point(66, 297);
            this.Label_DescStatus.Name = "Label_DescStatus";
            this.Label_DescStatus.Size = new System.Drawing.Size(40, 13);
            this.Label_DescStatus.TabIndex = 12;
            this.Label_DescStatus.Text = "Status:";
            // 
            // Label_Priority
            // 
            this.Label_Priority.AutoSize = true;
            this.Label_Priority.Location = new System.Drawing.Point(130, 261);
            this.Label_Priority.Name = "Label_Priority";
            this.Label_Priority.Size = new System.Drawing.Size(35, 13);
            this.Label_Priority.TabIndex = 13;
            this.Label_Priority.Text = "label1";
            // 
            // Label_Status
            // 
            this.Label_Status.AutoSize = true;
            this.Label_Status.Location = new System.Drawing.Point(130, 297);
            this.Label_Status.Name = "Label_Status";
            this.Label_Status.Size = new System.Drawing.Size(35, 13);
            this.Label_Status.TabIndex = 14;
            this.Label_Status.Text = "label1";
            // 
            // Label_DescRefBug
            // 
            this.Label_DescRefBug.AutoSize = true;
            this.Label_DescRefBug.Location = new System.Drawing.Point(69, 329);
            this.Label_DescRefBug.Name = "Label_DescRefBug";
            this.Label_DescRefBug.Size = new System.Drawing.Size(88, 13);
            this.Label_DescRefBug.TabIndex = 15;
            this.Label_DescRefBug.Text = "Referenced Bug:";
            // 
            // Label_RefBug
            // 
            this.Label_RefBug.AutoSize = true;
            this.Label_RefBug.Location = new System.Drawing.Point(164, 329);
            this.Label_RefBug.Name = "Label_RefBug";
            this.Label_RefBug.Size = new System.Drawing.Size(35, 13);
            this.Label_RefBug.TabIndex = 16;
            this.Label_RefBug.Text = "label1";
            // 
            // Button_Follow
            // 
            this.Button_Follow.Location = new System.Drawing.Point(187, 69);
            this.Button_Follow.Name = "Button_Follow";
            this.Button_Follow.Size = new System.Drawing.Size(75, 23);
            this.Button_Follow.TabIndex = 17;
            this.Button_Follow.Text = "Follow Bug";
            this.Button_Follow.UseVisualStyleBackColor = true;

            // 
            // BugInfoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 480);
            this.Controls.Add(this.Button_Follow);
            this.Controls.Add(this.Label_RefBug);
            this.Controls.Add(this.Label_DescRefBug);
            this.Controls.Add(this.Label_Status);
            this.Controls.Add(this.Label_Priority);
            this.Controls.Add(this.Label_DescStatus);
            this.Controls.Add(this.Label_DescPriority);
            this.Controls.Add(this.Button_Back);
            this.Controls.Add(this.Button_AddUpdate);
            this.Controls.Add(this.Panel_Updates);
            this.Controls.Add(this.Label_Poster);
            this.Controls.Add(this.Label_DescPoster);
            this.Controls.Add(this.Label_Title);
            this.Controls.Add(this.RichText_Description);
            this.Controls.Add(this.Labe_DescDescription);
            this.Controls.Add(this.Label_DescBugTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimumSize = new System.Drawing.Size(620, 480);
            this.Name = "BugInfoForm";
            this.Text = "BugInfoForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Label_DescBugTitle;
        private System.Windows.Forms.Label Labe_DescDescription;
        private System.Windows.Forms.RichTextBox RichText_Description;
        private System.Windows.Forms.Label Label_Title;
        private System.Windows.Forms.Label Label_DescPoster;
        private System.Windows.Forms.Label Label_Poster;
        private System.Windows.Forms.Panel Panel_Updates;
        private System.Windows.Forms.Button Button_AddUpdate;
        private System.Windows.Forms.Button Button_Back;
        private System.Windows.Forms.Label Label_DescPriority;
        private System.Windows.Forms.Label Label_DescStatus;
        private System.Windows.Forms.Label Label_Priority;
        private System.Windows.Forms.Label Label_Status;
        private System.Windows.Forms.Label Label_DescRefBug;
        private System.Windows.Forms.Label Label_RefBug;
        private System.Windows.Forms.Button Button_Follow;
    }
}