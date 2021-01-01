namespace Bugtracker
{
    partial class PostUpdateForm
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
            this.button1 = new System.Windows.Forms.Button();
            this.Label_UpdateBox = new System.Windows.Forms.Label();
            this.RichText_Update = new System.Windows.Forms.RichTextBox();
            this.ComboBox_Status = new System.Windows.Forms.ComboBox();
            this.Label_DescStatus = new System.Windows.Forms.Label();
            this.Button_PostUpdate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(37, 438);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Label_UpdateBox
            // 
            this.Label_UpdateBox.AutoSize = true;
            this.Label_UpdateBox.Location = new System.Drawing.Point(161, 106);
            this.Label_UpdateBox.Name = "Label_UpdateBox";
            this.Label_UpdateBox.Size = new System.Drawing.Size(35, 13);
            this.Label_UpdateBox.TabIndex = 1;
            this.Label_UpdateBox.Text = "label1";
            // 
            // RichText_Update
            // 
            this.RichText_Update.Location = new System.Drawing.Point(164, 144);
            this.RichText_Update.Name = "RichText_Update";
            this.RichText_Update.Size = new System.Drawing.Size(308, 102);
            this.RichText_Update.TabIndex = 2;
            this.RichText_Update.Text = "";
            // 
            // ComboBox_Status
            // 
            this.ComboBox_Status.FormattingEnabled = true;
            this.ComboBox_Status.Location = new System.Drawing.Point(164, 292);
            this.ComboBox_Status.Name = "ComboBox_Status";
            this.ComboBox_Status.Size = new System.Drawing.Size(121, 21);
            this.ComboBox_Status.TabIndex = 3;
            // 
            // Label_DescStatus
            // 
            this.Label_DescStatus.AutoSize = true;
            this.Label_DescStatus.Location = new System.Drawing.Point(161, 265);
            this.Label_DescStatus.Name = "Label_DescStatus";
            this.Label_DescStatus.Size = new System.Drawing.Size(35, 13);
            this.Label_DescStatus.TabIndex = 4;
            this.Label_DescStatus.Text = "label1";
            // 
            // Button_PostUpdate
            // 
            this.Button_PostUpdate.Location = new System.Drawing.Point(286, 338);
            this.Button_PostUpdate.Name = "Button_PostUpdate";
            this.Button_PostUpdate.Size = new System.Drawing.Size(75, 23);
            this.Button_PostUpdate.TabIndex = 5;
            this.Button_PostUpdate.Text = "Post Update";
            this.Button_PostUpdate.UseVisualStyleBackColor = true;
            this.Button_PostUpdate.Click += new System.EventHandler(this.Button_PostUpdate_Click);
            // 
            // PostUpdateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(620, 480);
            this.Controls.Add(this.Button_PostUpdate);
            this.Controls.Add(this.Label_DescStatus);
            this.Controls.Add(this.ComboBox_Status);
            this.Controls.Add(this.RichText_Update);
            this.Controls.Add(this.Label_UpdateBox);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimumSize = new System.Drawing.Size(620, 480);
            this.Name = "PostUpdateForm";
            this.Text = "PostUpdateForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label Label_UpdateBox;
        private System.Windows.Forms.RichTextBox RichText_Update;
        private System.Windows.Forms.ComboBox ComboBox_Status;
        private System.Windows.Forms.Label Label_DescStatus;
        private System.Windows.Forms.Button Button_PostUpdate;
    }
}