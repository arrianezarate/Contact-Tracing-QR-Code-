namespace contact_tracing
{
    partial class admin_login_page
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
            this.txtbox_username = new System.Windows.Forms.TextBox();
            this.txtbox_password = new System.Windows.Forms.TextBox();
            this.lbl_contact = new System.Windows.Forms.Label();
            this.lbl_adminlogin = new System.Windows.Forms.Label();
            this.lbl_username = new System.Windows.Forms.Label();
            this.lbl_password = new System.Windows.Forms.Label();
            this.btn_login = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtbox_username
            // 
            this.txtbox_username.Location = new System.Drawing.Point(559, 75);
            this.txtbox_username.Name = "txtbox_username";
            this.txtbox_username.Size = new System.Drawing.Size(220, 20);
            this.txtbox_username.TabIndex = 9;
            // 
            // txtbox_password
            // 
            this.txtbox_password.Location = new System.Drawing.Point(559, 118);
            this.txtbox_password.Name = "txtbox_password";
            this.txtbox_password.PasswordChar = '*';
            this.txtbox_password.Size = new System.Drawing.Size(220, 20);
            this.txtbox_password.TabIndex = 10;
            // 
            // lbl_contact
            // 
            this.lbl_contact.AutoSize = true;
            this.lbl_contact.Font = new System.Drawing.Font("Impact", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_contact.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(212)))), ((int)(((byte)(224)))));
            this.lbl_contact.Location = new System.Drawing.Point(56, 39);
            this.lbl_contact.Name = "lbl_contact";
            this.lbl_contact.Size = new System.Drawing.Size(370, 60);
            this.lbl_contact.TabIndex = 11;
            this.lbl_contact.Text = "CONTACT TRACING";
            // 
            // lbl_adminlogin
            // 
            this.lbl_adminlogin.AutoSize = true;
            this.lbl_adminlogin.Font = new System.Drawing.Font("Impact", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_adminlogin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(212)))), ((int)(((byte)(224)))));
            this.lbl_adminlogin.Location = new System.Drawing.Point(197, 99);
            this.lbl_adminlogin.Name = "lbl_adminlogin";
            this.lbl_adminlogin.Size = new System.Drawing.Size(79, 58);
            this.lbl_adminlogin.TabIndex = 12;
            this.lbl_adminlogin.Text = "ADMIN \r\n LOGIN";
            // 
            // lbl_username
            // 
            this.lbl_username.AutoSize = true;
            this.lbl_username.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_username.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(212)))), ((int)(((byte)(224)))));
            this.lbl_username.Location = new System.Drawing.Point(472, 72);
            this.lbl_username.Name = "lbl_username";
            this.lbl_username.Size = new System.Drawing.Size(81, 21);
            this.lbl_username.TabIndex = 19;
            this.lbl_username.Text = "Username";
            this.lbl_username.Click += new System.EventHandler(this.label2_Click);
            // 
            // lbl_password
            // 
            this.lbl_password.AutoSize = true;
            this.lbl_password.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_password.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(212)))), ((int)(((byte)(224)))));
            this.lbl_password.Location = new System.Drawing.Point(472, 115);
            this.lbl_password.Name = "lbl_password";
            this.lbl_password.Size = new System.Drawing.Size(77, 21);
            this.lbl_password.TabIndex = 20;
            this.lbl_password.Text = "Password";
            // 
            // btn_login
            // 
            this.btn_login.BackColor = System.Drawing.Color.Navy;
            this.btn_login.Font = new System.Drawing.Font("Impact", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_login.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(212)))), ((int)(((byte)(224)))));
            this.btn_login.Location = new System.Drawing.Point(592, 144);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(146, 43);
            this.btn_login.TabIndex = 21;
            this.btn_login.Text = "LOGIN";
            this.btn_login.UseVisualStyleBackColor = false;
            this.btn_login.Click += new System.EventHandler(this.btn_login_Click);
            // 
            // admin_login_page
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(45)))), ((int)(((byte)(72)))));
            this.ClientSize = new System.Drawing.Size(861, 199);
            this.Controls.Add(this.btn_login);
            this.Controls.Add(this.lbl_password);
            this.Controls.Add(this.lbl_username);
            this.Controls.Add(this.lbl_adminlogin);
            this.Controls.Add(this.lbl_contact);
            this.Controls.Add(this.txtbox_password);
            this.Controls.Add(this.txtbox_username);
            this.Name = "admin_login_page";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ADMIN LOGIN";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtbox_username;
        private System.Windows.Forms.TextBox txtbox_password;
        private System.Windows.Forms.Label lbl_contact;
        private System.Windows.Forms.Label lbl_adminlogin;
        private System.Windows.Forms.Label lbl_username;
        private System.Windows.Forms.Label lbl_password;
        private System.Windows.Forms.Button btn_login;
    }
}