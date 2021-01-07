namespace Bugtracker
{
    partial class DashboardForm
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
            this.Label_TotalBugs = new System.Windows.Forms.Label();
            this.Label_ProgressBugs = new System.Windows.Forms.Label();
            this.Label_SolvedBugs = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Panel_MasterPanel
            // 
            this.Panel_MasterPanel.Location = new System.Drawing.Point(12, 197);
            this.Panel_MasterPanel.Name = "Panel_MasterPanel";
            this.Panel_MasterPanel.Size = new System.Drawing.Size(596, 271);
            this.Panel_MasterPanel.TabIndex = 0;
            // 
            // Label_TotalBugs
            // 
            this.Label_TotalBugs.AutoSize = true;
            this.Label_TotalBugs.Location = new System.Drawing.Point(120, 86);
            this.Label_TotalBugs.Name = "Label_TotalBugs";
            this.Label_TotalBugs.Size = new System.Drawing.Size(35, 13);
            this.Label_TotalBugs.TabIndex = 1;
            this.Label_TotalBugs.Text = "label1";
            // 
            // Label_ProgressBugs
            // 
            this.Label_ProgressBugs.AutoSize = true;
            this.Label_ProgressBugs.Location = new System.Drawing.Point(273, 86);
            this.Label_ProgressBugs.Name = "Label_ProgressBugs";
            this.Label_ProgressBugs.Size = new System.Drawing.Size(35, 13);
            this.Label_ProgressBugs.TabIndex = 2;
            this.Label_ProgressBugs.Text = "label2";
            // 
            // Label_SolvedBugs
            // 
            this.Label_SolvedBugs.AutoSize = true;
            this.Label_SolvedBugs.Location = new System.Drawing.Point(443, 86);
            this.Label_SolvedBugs.Name = "Label_SolvedBugs";
            this.Label_SolvedBugs.Size = new System.Drawing.Size(35, 13);
            this.Label_SolvedBugs.TabIndex = 3;
            this.Label_SolvedBugs.Text = "label3";
            // 
            // DashboardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(620, 480);
            this.Controls.Add(this.Label_SolvedBugs);
            this.Controls.Add(this.Label_ProgressBugs);
            this.Controls.Add(this.Label_TotalBugs);
            this.Controls.Add(this.Panel_MasterPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DashboardForm";
            this.Text = "DashboardForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel Panel_MasterPanel;
        private System.Windows.Forms.Label Label_TotalBugs;
        private System.Windows.Forms.Label Label_ProgressBugs;
        private System.Windows.Forms.Label Label_SolvedBugs;
    }
}