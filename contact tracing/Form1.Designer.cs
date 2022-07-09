namespace contact_tracing
{
    partial class form_contacttracing
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
            this.pnl_bot = new System.Windows.Forms.Panel();
            this.lbl_contact = new System.Windows.Forms.Label();
            this.btn_admin = new System.Windows.Forms.Button();
            this.txtbox_firstname = new System.Windows.Forms.TextBox();
            this.txtbox_middlename = new System.Windows.Forms.TextBox();
            this.txtbox_age = new System.Windows.Forms.TextBox();
            this.txtbox_birthdate = new System.Windows.Forms.TextBox();
            this.txtbox_lastname = new System.Windows.Forms.TextBox();
            this.txtbox_gender = new System.Windows.Forms.TextBox();
            this.txtbox_address = new System.Windows.Forms.TextBox();
            this.txtbox_mobile = new System.Windows.Forms.TextBox();
            this.txtbox_email = new System.Windows.Forms.TextBox();
            this.btn_finish = new System.Windows.Forms.Button();
            this.combobox_camera = new System.Windows.Forms.ComboBox();
            this.date = new System.Windows.Forms.DateTimePicker();
            this.picbox_cameradisplay = new System.Windows.Forms.PictureBox();
            this.txtbox_displaytxt = new System.Windows.Forms.TextBox();
            this.btn_filltxtbox = new System.Windows.Forms.Button();
            this.pnl_bot.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picbox_cameradisplay)).BeginInit();
            this.SuspendLayout();
            // 
            // pnl_bot
            // 
            this.pnl_bot.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(45)))), ((int)(((byte)(72)))));
            this.pnl_bot.Controls.Add(this.btn_admin);
            this.pnl_bot.Controls.Add(this.lbl_contact);
            this.pnl_bot.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnl_bot.Location = new System.Drawing.Point(0, 638);
            this.pnl_bot.Name = "pnl_bot";
            this.pnl_bot.Size = new System.Drawing.Size(783, 96);
            this.pnl_bot.TabIndex = 0;
            // 
            // lbl_contact
            // 
            this.lbl_contact.AutoSize = true;
            this.lbl_contact.Font = new System.Drawing.Font("Impact", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_contact.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(212)))), ((int)(((byte)(224)))));
            this.lbl_contact.Location = new System.Drawing.Point(12, 17);
            this.lbl_contact.Name = "lbl_contact";
            this.lbl_contact.Size = new System.Drawing.Size(370, 60);
            this.lbl_contact.TabIndex = 0;
            this.lbl_contact.Text = "CONTACT TRACING";
            // 
            // btn_admin
            // 
            this.btn_admin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(192)))));
            this.btn_admin.Font = new System.Drawing.Font("Impact", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_admin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(212)))), ((int)(((byte)(224)))));
            this.btn_admin.Location = new System.Drawing.Point(585, 3);
            this.btn_admin.Name = "btn_admin";
            this.btn_admin.Size = new System.Drawing.Size(146, 90);
            this.btn_admin.TabIndex = 1;
            this.btn_admin.Text = "ADMIN";
            this.btn_admin.UseVisualStyleBackColor = false;
            // 
            // txtbox_firstname
            // 
            this.txtbox_firstname.Location = new System.Drawing.Point(100, 64);
            this.txtbox_firstname.Name = "txtbox_firstname";
            this.txtbox_firstname.Size = new System.Drawing.Size(100, 20);
            this.txtbox_firstname.TabIndex = 1;
            // 
            // txtbox_middlename
            // 
            this.txtbox_middlename.Location = new System.Drawing.Point(318, 64);
            this.txtbox_middlename.Name = "txtbox_middlename";
            this.txtbox_middlename.Size = new System.Drawing.Size(100, 20);
            this.txtbox_middlename.TabIndex = 2;
            // 
            // txtbox_age
            // 
            this.txtbox_age.Location = new System.Drawing.Point(100, 104);
            this.txtbox_age.Name = "txtbox_age";
            this.txtbox_age.Size = new System.Drawing.Size(100, 20);
            this.txtbox_age.TabIndex = 3;
            // 
            // txtbox_birthdate
            // 
            this.txtbox_birthdate.Location = new System.Drawing.Point(318, 104);
            this.txtbox_birthdate.Name = "txtbox_birthdate";
            this.txtbox_birthdate.Size = new System.Drawing.Size(100, 20);
            this.txtbox_birthdate.TabIndex = 4;
            // 
            // txtbox_lastname
            // 
            this.txtbox_lastname.Location = new System.Drawing.Point(550, 64);
            this.txtbox_lastname.Name = "txtbox_lastname";
            this.txtbox_lastname.Size = new System.Drawing.Size(100, 20);
            this.txtbox_lastname.TabIndex = 5;
            // 
            // txtbox_gender
            // 
            this.txtbox_gender.Location = new System.Drawing.Point(550, 104);
            this.txtbox_gender.Name = "txtbox_gender";
            this.txtbox_gender.Size = new System.Drawing.Size(100, 20);
            this.txtbox_gender.TabIndex = 6;
            // 
            // txtbox_address
            // 
            this.txtbox_address.Location = new System.Drawing.Point(100, 151);
            this.txtbox_address.Name = "txtbox_address";
            this.txtbox_address.Size = new System.Drawing.Size(550, 20);
            this.txtbox_address.TabIndex = 7;
            // 
            // txtbox_mobile
            // 
            this.txtbox_mobile.Location = new System.Drawing.Point(100, 201);
            this.txtbox_mobile.Name = "txtbox_mobile";
            this.txtbox_mobile.Size = new System.Drawing.Size(220, 20);
            this.txtbox_mobile.TabIndex = 8;
            // 
            // txtbox_email
            // 
            this.txtbox_email.Location = new System.Drawing.Point(100, 241);
            this.txtbox_email.Name = "txtbox_email";
            this.txtbox_email.Size = new System.Drawing.Size(220, 20);
            this.txtbox_email.TabIndex = 9;
            // 
            // btn_finish
            // 
            this.btn_finish.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(192)))));
            this.btn_finish.Font = new System.Drawing.Font("Impact", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_finish.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(212)))), ((int)(((byte)(224)))));
            this.btn_finish.Location = new System.Drawing.Point(343, 218);
            this.btn_finish.Name = "btn_finish";
            this.btn_finish.Size = new System.Drawing.Size(146, 43);
            this.btn_finish.TabIndex = 2;
            this.btn_finish.Text = "FINISH";
            this.btn_finish.UseVisualStyleBackColor = false;
            // 
            // combobox_camera
            // 
            this.combobox_camera.FormattingEnabled = true;
            this.combobox_camera.Location = new System.Drawing.Point(100, 346);
            this.combobox_camera.Name = "combobox_camera";
            this.combobox_camera.Size = new System.Drawing.Size(220, 21);
            this.combobox_camera.TabIndex = 10;
            // 
            // date
            // 
            this.date.Font = new System.Drawing.Font("Mongolian Baiti", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.date.Location = new System.Drawing.Point(372, 22);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(278, 25);
            this.date.TabIndex = 11;
            // 
            // picbox_cameradisplay
            // 
            this.picbox_cameradisplay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(45)))), ((int)(((byte)(72)))));
            this.picbox_cameradisplay.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.picbox_cameradisplay.Location = new System.Drawing.Point(100, 373);
            this.picbox_cameradisplay.Name = "picbox_cameradisplay";
            this.picbox_cameradisplay.Size = new System.Drawing.Size(220, 197);
            this.picbox_cameradisplay.TabIndex = 12;
            this.picbox_cameradisplay.TabStop = false;
            // 
            // txtbox_displaytxt
            // 
            this.txtbox_displaytxt.Location = new System.Drawing.Point(393, 373);
            this.txtbox_displaytxt.Multiline = true;
            this.txtbox_displaytxt.Name = "txtbox_displaytxt";
            this.txtbox_displaytxt.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtbox_displaytxt.Size = new System.Drawing.Size(324, 197);
            this.txtbox_displaytxt.TabIndex = 13;
            // 
            // btn_filltxtbox
            // 
            this.btn_filltxtbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(192)))));
            this.btn_filltxtbox.Font = new System.Drawing.Font("Impact", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_filltxtbox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(212)))), ((int)(((byte)(224)))));
            this.btn_filltxtbox.Location = new System.Drawing.Point(571, 576);
            this.btn_filltxtbox.Name = "btn_filltxtbox";
            this.btn_filltxtbox.Size = new System.Drawing.Size(146, 43);
            this.btn_filltxtbox.TabIndex = 14;
            this.btn_filltxtbox.Text = "FILL";
            this.btn_filltxtbox.UseVisualStyleBackColor = false;
            // 
            // form_contacttracing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(93)))), ((int)(((byte)(160)))));
            this.ClientSize = new System.Drawing.Size(783, 734);
            this.Controls.Add(this.btn_filltxtbox);
            this.Controls.Add(this.txtbox_displaytxt);
            this.Controls.Add(this.picbox_cameradisplay);
            this.Controls.Add(this.date);
            this.Controls.Add(this.combobox_camera);
            this.Controls.Add(this.btn_finish);
            this.Controls.Add(this.txtbox_email);
            this.Controls.Add(this.txtbox_mobile);
            this.Controls.Add(this.txtbox_address);
            this.Controls.Add(this.txtbox_gender);
            this.Controls.Add(this.txtbox_lastname);
            this.Controls.Add(this.txtbox_birthdate);
            this.Controls.Add(this.txtbox_age);
            this.Controls.Add(this.txtbox_middlename);
            this.Controls.Add(this.txtbox_firstname);
            this.Controls.Add(this.pnl_bot);
            this.Name = "form_contacttracing";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Contact Tracing";
            this.pnl_bot.ResumeLayout(false);
            this.pnl_bot.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picbox_cameradisplay)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnl_bot;
        private System.Windows.Forms.Button btn_admin;
        private System.Windows.Forms.Label lbl_contact;
        private System.Windows.Forms.TextBox txtbox_firstname;
        private System.Windows.Forms.TextBox txtbox_middlename;
        private System.Windows.Forms.TextBox txtbox_age;
        private System.Windows.Forms.TextBox txtbox_birthdate;
        private System.Windows.Forms.TextBox txtbox_lastname;
        private System.Windows.Forms.TextBox txtbox_gender;
        private System.Windows.Forms.TextBox txtbox_address;
        private System.Windows.Forms.TextBox txtbox_mobile;
        private System.Windows.Forms.TextBox txtbox_email;
        private System.Windows.Forms.Button btn_finish;
        private System.Windows.Forms.ComboBox combobox_camera;
        private System.Windows.Forms.DateTimePicker date;
        private System.Windows.Forms.PictureBox picbox_cameradisplay;
        private System.Windows.Forms.TextBox txtbox_displaytxt;
        private System.Windows.Forms.Button btn_filltxtbox;
    }
}

