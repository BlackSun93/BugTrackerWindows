namespace Bugtracker
{
    partial class LoginForm
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
            this.TextBox_Username = new System.Windows.Forms.TextBox();
            this.TextBox_Password = new System.Windows.Forms.TextBox();
            this.Button_Login = new System.Windows.Forms.Button();
            this.Button_Register = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TextBox_Username
            // 
            this.TextBox_Username.Location = new System.Drawing.Point(319, 150);
            this.TextBox_Username.Name = "TextBox_Username";
            this.TextBox_Username.Size = new System.Drawing.Size(100, 20);
            this.TextBox_Username.TabIndex = 0;
            // 
            // TextBox_Password
            // 
            this.TextBox_Password.Location = new System.Drawing.Point(319, 236);
            this.TextBox_Password.Name = "TextBox_Password";
            this.TextBox_Password.Size = new System.Drawing.Size(100, 20);
            this.TextBox_Password.TabIndex = 1;
            // 
            // Button_Login
            // 
            this.Button_Login.Location = new System.Drawing.Point(401, 317);
            this.Button_Login.Name = "Button_Login";
            this.Button_Login.Size = new System.Drawing.Size(75, 23);
            this.Button_Login.TabIndex = 2;
            this.Button_Login.Text = "Login";
            this.Button_Login.UseVisualStyleBackColor = true;
            this.Button_Login.Click += new System.EventHandler(this.Button_Login_Click);
            // 
            // Button_Register
            // 
            this.Button_Register.Location = new System.Drawing.Point(232, 317);
            this.Button_Register.Name = "Button_Register";
            this.Button_Register.Size = new System.Drawing.Size(75, 23);
            this.Button_Register.TabIndex = 3;
            this.Button_Register.Text = "Register";
            this.Button_Register.UseVisualStyleBackColor = true;
            this.Button_Register.Click += new System.EventHandler(this.Button_Register_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(319, 112);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Username";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(319, 217);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Password";
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Button_Register);
            this.Controls.Add(this.Button_Login);
            this.Controls.Add(this.TextBox_Password);
            this.Controls.Add(this.TextBox_Username);
            this.Name = "LoginForm";
            this.Text = "LoginForm";
            this.ResumeLayout(false);
            this.PerformLayout(); 

        }

        #endregion

        private System.Windows.Forms.TextBox TextBox_Username;
        private System.Windows.Forms.TextBox TextBox_Password;
        private System.Windows.Forms.Button Button_Login;
        private System.Windows.Forms.Button Button_Register;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}