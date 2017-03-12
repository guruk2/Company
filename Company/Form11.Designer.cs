namespace Company
{
    partial class Form11
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
            this.btn_Spare_user = new System.Windows.Forms.Button();
            this.btn_insert_user = new System.Windows.Forms.Button();
            this.btn_Search_User = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_Spare_user
            // 
            this.btn_Spare_user.Location = new System.Drawing.Point(237, 297);
            this.btn_Spare_user.Name = "btn_Spare_user";
            this.btn_Spare_user.Size = new System.Drawing.Size(124, 78);
            this.btn_Spare_user.TabIndex = 5;
            this.btn_Spare_user.Text = "Open Spare Work Order";
            this.btn_Spare_user.UseVisualStyleBackColor = true;
            this.btn_Spare_user.Click += new System.EventHandler(this.btn_Spare_user_Click);
            // 
            // btn_insert_user
            // 
            this.btn_insert_user.Location = new System.Drawing.Point(237, 197);
            this.btn_insert_user.Name = "btn_insert_user";
            this.btn_insert_user.Size = new System.Drawing.Size(124, 68);
            this.btn_insert_user.TabIndex = 4;
            this.btn_insert_user.Text = "Insert Data in Hoist WorkOrder";
            this.btn_insert_user.UseVisualStyleBackColor = true;
            this.btn_insert_user.Click += new System.EventHandler(this.btn_insert_user_Click);
            // 
            // btn_Search_User
            // 
            this.btn_Search_User.Location = new System.Drawing.Point(237, 74);
            this.btn_Search_User.Name = "btn_Search_User";
            this.btn_Search_User.Size = new System.Drawing.Size(124, 70);
            this.btn_Search_User.TabIndex = 3;
            this.btn_Search_User.Text = "Search";
            this.btn_Search_User.UseVisualStyleBackColor = true;
            this.btn_Search_User.Click += new System.EventHandler(this.btn_Search_User_Click);
            // 
            // Form11
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(598, 449);
            this.Controls.Add(this.btn_Spare_user);
            this.Controls.Add(this.btn_insert_user);
            this.Controls.Add(this.btn_Search_User);
            this.Name = "Form11";
            this.Text = "Form11";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_Spare_user;
        private System.Windows.Forms.Button btn_insert_user;
        private System.Windows.Forms.Button btn_Search_User;
    }
}