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
            this.components = new System.ComponentModel.Container();
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
            this.btn_startcam = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lbl_mobile = new System.Windows.Forms.Label();
            this.lbl_email = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_firstname = new System.Windows.Forms.Label();
            this.lbl_lastname = new System.Windows.Forms.Label();
            this.lbl_middlename = new System.Windows.Forms.Label();
            this.lbl_address = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
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
            this.date.Location = new System.Drawing.Point(393, 22);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(257, 25);
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
            // btn_startcam
            // 
            this.btn_startcam.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(192)))));
            this.btn_startcam.Font = new System.Drawing.Font("Impact", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_startcam.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(212)))), ((int)(((byte)(224)))));
            this.btn_startcam.Location = new System.Drawing.Point(100, 576);
            this.btn_startcam.Name = "btn_startcam";
            this.btn_startcam.Size = new System.Drawing.Size(220, 43);
            this.btn_startcam.TabIndex = 15;
            this.btn_startcam.Text = "START CAMERA";
            this.btn_startcam.UseVisualStyleBackColor = false;
            this.btn_startcam.Click += new System.EventHandler(this.btn_startcam_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lbl_mobile
            // 
            this.lbl_mobile.AutoSize = true;
            this.lbl_mobile.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_mobile.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(212)))), ((int)(((byte)(224)))));
            this.lbl_mobile.Location = new System.Drawing.Point(8, 198);
            this.lbl_mobile.Name = "lbl_mobile";
            this.lbl_mobile.Size = new System.Drawing.Size(86, 21);
            this.lbl_mobile.TabIndex = 16;
            this.lbl_mobile.Text = "Mobile No.";
            // 
            // lbl_email
            // 
            this.lbl_email.AutoSize = true;
            this.lbl_email.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_email.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(212)))), ((int)(((byte)(224)))));
            this.lbl_email.Location = new System.Drawing.Point(46, 240);
            this.lbl_email.Name = "lbl_email";
            this.lbl_email.Size = new System.Drawing.Size(48, 21);
            this.lbl_email.TabIndex = 17;
            this.lbl_email.Text = "Email";
            this.lbl_email.Click += new System.EventHandler(this.lbl_email_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(212)))), ((int)(((byte)(224)))));
            this.label1.Location = new System.Drawing.Point(28, 150);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 21);
            this.label1.TabIndex = 18;
            this.label1.Text = "Address";
            // 
            // lbl_firstname
            // 
            this.lbl_firstname.AutoSize = true;
            this.lbl_firstname.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_firstname.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(212)))), ((int)(((byte)(224)))));
            this.lbl_firstname.Location = new System.Drawing.Point(8, 63);
            this.lbl_firstname.Name = "lbl_firstname";
            this.lbl_firstname.Size = new System.Drawing.Size(86, 21);
            this.lbl_firstname.TabIndex = 19;
            this.lbl_firstname.Text = "First Name";
            // 
            // lbl_lastname
            // 
            this.lbl_lastname.AutoSize = true;
            this.lbl_lastname.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_lastname.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(212)))), ((int)(((byte)(224)))));
            this.lbl_lastname.Location = new System.Drawing.Point(460, 61);
            this.lbl_lastname.Name = "lbl_lastname";
            this.lbl_lastname.Size = new System.Drawing.Size(84, 21);
            this.lbl_lastname.TabIndex = 20;
            this.lbl_lastname.Text = "Last Name";
            // 
            // lbl_middlename
            // 
            this.lbl_middlename.AutoSize = true;
            this.lbl_middlename.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_middlename.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(212)))), ((int)(((byte)(224)))));
            this.lbl_middlename.Location = new System.Drawing.Point(208, 61);
            this.lbl_middlename.Name = "lbl_middlename";
            this.lbl_middlename.Size = new System.Drawing.Size(104, 21);
            this.lbl_middlename.TabIndex = 21;
            this.lbl_middlename.Text = "Middle Name";
            // 
            // lbl_address
            // 
            this.lbl_address.AutoSize = true;
            this.lbl_address.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_address.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(212)))), ((int)(((byte)(224)))));
            this.lbl_address.Location = new System.Drawing.Point(28, 101);
            this.lbl_address.Name = "lbl_address";
            this.lbl_address.Size = new System.Drawing.Size(66, 21);
            this.lbl_address.TabIndex = 22;
            this.lbl_address.Text = "Address";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(212)))), ((int)(((byte)(224)))));
            this.label2.Location = new System.Drawing.Point(246, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 21);
            this.label2.TabIndex = 23;
            this.label2.Text = "Address";
            // 
            // form_contacttracing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(93)))), ((int)(((byte)(160)))));
            this.ClientSize = new System.Drawing.Size(783, 734);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbl_address);
            this.Controls.Add(this.lbl_middlename);
            this.Controls.Add(this.lbl_lastname);
            this.Controls.Add(this.lbl_firstname);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_email);
            this.Controls.Add(this.lbl_mobile);
            this.Controls.Add(this.btn_startcam);
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
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.form_contacttracing_FormClosing);
            this.Load += new System.EventHandler(this.form_contacttracing_Load);
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
        private System.Windows.Forms.Button btn_startcam;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lbl_mobile;
        private System.Windows.Forms.Label lbl_email;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_firstname;
        private System.Windows.Forms.Label lbl_lastname;
        private System.Windows.Forms.Label lbl_middlename;
        private System.Windows.Forms.Label lbl_address;
        private System.Windows.Forms.Label label2;
    }
}

