namespace Bugtracker
{
    partial class NotificationsForm
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
            this.Panel_MasterPanel = new System.Windows.Forms.Panel();
            this.Button_Back = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Panel_MasterPanel
            // 
            this.Panel_MasterPanel.Location = new System.Drawing.Point(13, 45);
            this.Panel_MasterPanel.Name = "Panel_MasterPanel";
            this.Panel_MasterPanel.Size = new System.Drawing.Size(579, 384);
            this.Panel_MasterPanel.TabIndex = 0;
            // 
            // Button_Back
            // 
            this.Button_Back.Location = new System.Drawing.Point(30, 13);
            this.Button_Back.Name = "Button_Back";
            this.Button_Back.Size = new System.Drawing.Size(75, 23);
            this.Button_Back.TabIndex = 1;
            this.Button_Back.Text = "Back";
            this.Button_Back.UseVisualStyleBackColor = true;
            // 
            // NotificationsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(604, 441);
            this.Controls.Add(this.Button_Back);
            this.Controls.Add(this.Panel_MasterPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "NotificationsForm";
            this.Text = "NotificationsForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Panel_MasterPanel;
        private System.Windows.Forms.Button Button_Back;
    }
}