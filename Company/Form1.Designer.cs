namespace Company
{
    partial class Form1
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
            this.label2 = new System.Windows.Forms.Label();
            this.text_username = new System.Windows.Forms.TextBox();
            this.text_password = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button_Admin_Login = new System.Windows.Forms.Button();
            this.button_User_Login = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(255, 330);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 0;
            // 
            // text_username
            // 
            this.text_username.Location = new System.Drawing.Point(308, 89);
            this.text_username.Name = "text_username";
            this.text_username.Size = new System.Drawing.Size(100, 20);
            this.text_username.TabIndex = 1;
            // 
            // text_password
            // 
            this.text_password.Location = new System.Drawing.Point(309, 126);
            this.text_password.Name = "text_password";
            this.text_password.PasswordChar = '*';
            this.text_password.Size = new System.Drawing.Size(100, 20);
            this.text_password.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(208, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "UserName";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(208, 133);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Password";
            // 
            // button_Admin_Login
            // 
            this.button_Admin_Login.Location = new System.Drawing.Point(243, 197);
            this.button_Admin_Login.Name = "button_Admin_Login";
            this.button_Admin_Login.Size = new System.Drawing.Size(75, 23);
            this.button_Admin_Login.TabIndex = 5;
            this.button_Admin_Login.Text = "AdminLogin";
            this.button_Admin_Login.UseVisualStyleBackColor = true;
            this.button_Admin_Login.Click += new System.EventHandler(this.button_Admin_Login_Click);
            // 
            // button_User_Login
            // 
            this.button_User_Login.Location = new System.Drawing.Point(351, 197);
            this.button_User_Login.Name = "button_User_Login";
            this.button_User_Login.Size = new System.Drawing.Size(75, 23);
            this.button_User_Login.TabIndex = 6;
            this.button_User_Login.Text = "UserLogin";
            this.button_User_Login.UseVisualStyleBackColor = true;
            this.button_User_Login.Click += new System.EventHandler(this.button_User_Login_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(211, 252);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(240, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "Could not login? Register here.....!!";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(645, 385);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button_User_Login);
            this.Controls.Add(this.button_Admin_Login);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.text_password);
            this.Controls.Add(this.text_username);
            this.Controls.Add(this.label2);
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load_1);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label userName;
        private System.Windows.Forms.Label password;
        private System.Windows.Forms.TextBox txt_username;
        private System.Windows.Forms.TextBox txt_password;
        private System.Windows.Forms.Button btn_Admin_login;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_User_login;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox text_username;
        private System.Windows.Forms.TextBox text_password;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button_Admin_Login;
        private System.Windows.Forms.Button button_User_Login;
        private System.Windows.Forms.Button button1;
    }
}

