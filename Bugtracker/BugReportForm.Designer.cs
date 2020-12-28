namespace Bugtracker
{
    partial class BugReportForm
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
            this.Label_Title = new System.Windows.Forms.Label();
            this.TextBox_Title = new System.Windows.Forms.TextBox();
            this.Label_Description = new System.Windows.Forms.Label();
            this.RichText_Description = new System.Windows.Forms.RichTextBox();
            this.Label_Location = new System.Windows.Forms.Label();
            this.TextBox_Location = new System.Windows.Forms.TextBox();
            this.Label_Priority = new System.Windows.Forms.Label();
            this.ComboBox_Priority = new System.Windows.Forms.ComboBox();
            this.Button_Save = new System.Windows.Forms.Button();
            this.Button_Back = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Label_Title
            // 
            this.Label_Title.AutoSize = true;
            this.Label_Title.Location = new System.Drawing.Point(197, 35);
            this.Label_Title.Name = "Label_Title";
            this.Label_Title.Size = new System.Drawing.Size(27, 13);
            this.Label_Title.TabIndex = 0;
            this.Label_Title.Text = "Title";
            // 
            // TextBox_Title
            // 
            this.TextBox_Title.Location = new System.Drawing.Point(200, 60);
            this.TextBox_Title.Name = "TextBox_Title";
            this.TextBox_Title.Size = new System.Drawing.Size(229, 20);
            this.TextBox_Title.TabIndex = 1;
            // 
            // Label_Description
            // 
            this.Label_Description.AutoSize = true;
            this.Label_Description.Location = new System.Drawing.Point(197, 110);
            this.Label_Description.Name = "Label_Description";
            this.Label_Description.Size = new System.Drawing.Size(60, 13);
            this.Label_Description.TabIndex = 2;
            this.Label_Description.Text = "Description";
            // 
            // RichText_Description
            // 
            this.RichText_Description.Location = new System.Drawing.Point(200, 150);
            this.RichText_Description.Name = "RichText_Description";
            this.RichText_Description.Size = new System.Drawing.Size(229, 96);
            this.RichText_Description.TabIndex = 3;
            this.RichText_Description.Text = "";
            // 
            // Label_Location
            // 
            this.Label_Location.AutoSize = true;
            this.Label_Location.Location = new System.Drawing.Point(197, 277);
            this.Label_Location.Name = "Label_Location";
            this.Label_Location.Size = new System.Drawing.Size(48, 13);
            this.Label_Location.TabIndex = 4;
            this.Label_Location.Text = "Location";
            // 
            // TextBox_Location
            // 
            this.TextBox_Location.Location = new System.Drawing.Point(200, 313);
            this.TextBox_Location.Name = "TextBox_Location";
            this.TextBox_Location.Size = new System.Drawing.Size(229, 20);
            this.TextBox_Location.TabIndex = 5;
            // 
            // Label_Priority
            // 
            this.Label_Priority.AutoSize = true;
            this.Label_Priority.Location = new System.Drawing.Point(197, 359);
            this.Label_Priority.Name = "Label_Priority";
            this.Label_Priority.Size = new System.Drawing.Size(67, 13);
            this.Label_Priority.TabIndex = 6;
            this.Label_Priority.Text = "Priority Level";
            // 
            // ComboBox_Priority
            // 
            this.ComboBox_Priority.FormattingEnabled = true;
            this.ComboBox_Priority.Location = new System.Drawing.Point(200, 396);
            this.ComboBox_Priority.Name = "ComboBox_Priority";
            this.ComboBox_Priority.Size = new System.Drawing.Size(229, 21);
            this.ComboBox_Priority.TabIndex = 7;
            // 
            // Button_Save
            // 
            this.Button_Save.Location = new System.Drawing.Point(564, 431);
            this.Button_Save.Name = "Button_Save";
            this.Button_Save.Size = new System.Drawing.Size(91, 29);
            this.Button_Save.TabIndex = 8;
            this.Button_Save.Text = "Save";
            this.Button_Save.UseVisualStyleBackColor = true;
            // 
            // Button_Back
            // 
            this.Button_Back.Location = new System.Drawing.Point(56, 431);
            this.Button_Back.Name = "Button_Back";
            this.Button_Back.Size = new System.Drawing.Size(91, 29);
            this.Button_Back.TabIndex = 9;
            this.Button_Back.Text = "Back";
            this.Button_Back.UseVisualStyleBackColor = true;
            // 
            // BugReportForm
            // 
            this.ClientSize = new System.Drawing.Size(763, 547);
            this.Controls.Add(this.Button_Back);
            this.Controls.Add(this.Button_Save);
            this.Controls.Add(this.ComboBox_Priority);
            this.Controls.Add(this.Label_Priority);
            this.Controls.Add(this.TextBox_Location);
            this.Controls.Add(this.Label_Location);
            this.Controls.Add(this.RichText_Description);
            this.Controls.Add(this.Label_Description);
            this.Controls.Add(this.TextBox_Title);
            this.Controls.Add(this.Label_Title);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "BugReportForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Label_Title;
        private System.Windows.Forms.TextBox TextBox_Title;
        private System.Windows.Forms.Label Label_Description;
        private System.Windows.Forms.RichTextBox RichText_Description;
        private System.Windows.Forms.Label Label_Location;
        private System.Windows.Forms.TextBox TextBox_Location;
        private System.Windows.Forms.Label Label_Priority;
        private System.Windows.Forms.ComboBox ComboBox_Priority;
        private System.Windows.Forms.Button Button_Save;
        private System.Windows.Forms.Button Button_Back;
    }
}