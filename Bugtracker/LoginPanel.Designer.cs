namespace Bugtracker
{
    partial class LoginPanel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginPanel));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Label_Tracker = new System.Windows.Forms.Label();
            this.Label_Bug = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(9, 360);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(96, 104);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // Label_Tracker
            // 
            this.Label_Tracker.AutoSize = true;
            this.Label_Tracker.Font = new System.Drawing.Font("Arial", 64F, System.Drawing.FontStyle.Bold);
            this.Label_Tracker.ForeColor = System.Drawing.Color.White;
            this.Label_Tracker.Location = new System.Drawing.Point(3, 464);
            this.Label_Tracker.Margin = new System.Windows.Forms.Padding(0);
            this.Label_Tracker.Name = "Label_Tracker";
            this.Label_Tracker.Size = new System.Drawing.Size(458, 99);
            this.Label_Tracker.TabIndex = 9;
            this.Label_Tracker.Text = "TRACKER";
            // 
            // Label_Bug
            // 
            this.Label_Bug.AutoSize = true;
            this.Label_Bug.Font = new System.Drawing.Font("Arial", 64F, System.Drawing.FontStyle.Bold);
            this.Label_Bug.ForeColor = System.Drawing.Color.White;
            this.Label_Bug.Location = new System.Drawing.Point(105, 365);
            this.Label_Bug.Margin = new System.Windows.Forms.Padding(0);
            this.Label_Bug.Name = "Label_Bug";
            this.Label_Bug.Size = new System.Drawing.Size(233, 99);
            this.Label_Bug.TabIndex = 10;
            this.Label_Bug.Text = "BUG";
            // 
            // LoginPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(85)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(456, 566);
            this.Controls.Add(this.Label_Bug);
            this.Controls.Add(this.Label_Tracker);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(456, 566);
            this.MinimumSize = new System.Drawing.Size(456, 566);
            this.Name = "LoginPanel";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "BugTracker";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label Label_Tracker;
        private System.Windows.Forms.Label Label_Bug;
    }
}