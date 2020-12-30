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
            this.label1 = new System.Windows.Forms.Label();
            this.Panel_DisplayBugs = new System.Windows.Forms.Panel();
            this.Button_NewBug = new System.Windows.Forms.Button();
            this.Button_Back = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "label1";
            // 
            // Panel_DisplayBugs
            // 
            this.Panel_DisplayBugs.AutoScroll = true;
            this.Panel_DisplayBugs.Location = new System.Drawing.Point(12, 38);
            this.Panel_DisplayBugs.Name = "Panel_DisplayBugs";
            this.Panel_DisplayBugs.Size = new System.Drawing.Size(596, 408);
            this.Panel_DisplayBugs.TabIndex = 1;
            // 
            // Button_NewBug
            // 
            this.Button_NewBug.Location = new System.Drawing.Point(96, 9);
            this.Button_NewBug.Name = "Button_NewBug";
            this.Button_NewBug.Size = new System.Drawing.Size(106, 23);
            this.Button_NewBug.TabIndex = 4;
            this.Button_NewBug.Text = "Report New Bug";
            this.Button_NewBug.UseVisualStyleBackColor = true;
            this.Button_NewBug.Click += new System.EventHandler(this.Button_NewBug_Click);
            // 
            // Button_Back
            // 
            this.Button_Back.Location = new System.Drawing.Point(12, 452);
            this.Button_Back.Name = "Button_Back";
            this.Button_Back.Size = new System.Drawing.Size(75, 23);
            this.Button_Back.TabIndex = 5;
            this.Button_Back.Text = "Back";
            this.Button_Back.UseVisualStyleBackColor = true;
            this.Button_Back.Click += new System.EventHandler(this.Button_Back_Click);
            // 
            // BugsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(620, 480);
            this.Controls.Add(this.Button_Back);
            this.Controls.Add(this.Button_NewBug);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Panel_DisplayBugs);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimumSize = new System.Drawing.Size(620, 480);
            this.Name = "BugsForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "BugsForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel Panel_DisplayBugs;
        private System.Windows.Forms.Button Button_NewBug;
        private System.Windows.Forms.Button Button_Back;
    }
}