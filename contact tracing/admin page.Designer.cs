namespace contact_tracing
{
    partial class admin
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
            this.btn_view = new System.Windows.Forms.Button();
            this.btn_select = new System.Windows.Forms.Button();
            this.pnl_all = new System.Windows.Forms.Panel();
            this.date = new System.Windows.Forms.DateTimePicker();
            this.pnl_date = new System.Windows.Forms.Panel();
            this.lbl_allrecords = new System.Windows.Forms.Label();
            this.lbl_calendar = new System.Windows.Forms.Label();
            this.pnl_all.SuspendLayout();
            this.pnl_date.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_view
            // 
            this.btn_view.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(45)))), ((int)(((byte)(72)))));
            this.btn_view.Font = new System.Drawing.Font("Impact", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_view.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(212)))), ((int)(((byte)(224)))));
            this.btn_view.Location = new System.Drawing.Point(138, 149);
            this.btn_view.Name = "btn_view";
            this.btn_view.Size = new System.Drawing.Size(105, 46);
            this.btn_view.TabIndex = 0;
            this.btn_view.Text = "VIEW";
            this.btn_view.UseVisualStyleBackColor = false;
            // 
            // btn_select
            // 
            this.btn_select.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(45)))), ((int)(((byte)(72)))));
            this.btn_select.Font = new System.Drawing.Font("Impact", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_select.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(212)))), ((int)(((byte)(224)))));
            this.btn_select.Location = new System.Drawing.Point(138, 364);
            this.btn_select.Name = "btn_select";
            this.btn_select.Size = new System.Drawing.Size(105, 46);
            this.btn_select.TabIndex = 1;
            this.btn_select.Text = "SELECT";
            this.btn_select.UseVisualStyleBackColor = false;
            // 
            // pnl_all
            // 
            this.pnl_all.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(93)))), ((int)(((byte)(160)))));
            this.pnl_all.Controls.Add(this.lbl_allrecords);
            this.pnl_all.Location = new System.Drawing.Point(87, 43);
            this.pnl_all.Name = "pnl_all";
            this.pnl_all.Size = new System.Drawing.Size(205, 100);
            this.pnl_all.TabIndex = 2;
            // 
            // date
            // 
            this.date.CalendarFont = new System.Drawing.Font("Limousine", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.date.Font = new System.Drawing.Font("Mongolian Baiti", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.date.Location = new System.Drawing.Point(13, 47);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(236, 25);
            this.date.TabIndex = 3;
            this.date.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // pnl_date
            // 
            this.pnl_date.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(93)))), ((int)(((byte)(160)))));
            this.pnl_date.Controls.Add(this.lbl_calendar);
            this.pnl_date.Controls.Add(this.date);
            this.pnl_date.Location = new System.Drawing.Point(58, 258);
            this.pnl_date.Name = "pnl_date";
            this.pnl_date.Size = new System.Drawing.Size(261, 100);
            this.pnl_date.TabIndex = 3;
            // 
            // lbl_allrecords
            // 
            this.lbl_allrecords.AutoSize = true;
            this.lbl_allrecords.Font = new System.Drawing.Font("Impact", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_allrecords.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(212)))), ((int)(((byte)(224)))));
            this.lbl_allrecords.Location = new System.Drawing.Point(54, 22);
            this.lbl_allrecords.Name = "lbl_allrecords";
            this.lbl_allrecords.Size = new System.Drawing.Size(100, 58);
            this.lbl_allrecords.TabIndex = 1;
            this.lbl_allrecords.Text = "       ALL \r\nRECORDS";
            // 
            // lbl_calendar
            // 
            this.lbl_calendar.AutoSize = true;
            this.lbl_calendar.Font = new System.Drawing.Font("Impact", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_calendar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(212)))), ((int)(((byte)(224)))));
            this.lbl_calendar.Location = new System.Drawing.Point(77, 15);
            this.lbl_calendar.Name = "lbl_calendar";
            this.lbl_calendar.Size = new System.Drawing.Size(108, 29);
            this.lbl_calendar.TabIndex = 2;
            this.lbl_calendar.Text = "CALENDAR";
            // 
            // admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(377, 450);
            this.Controls.Add(this.pnl_date);
            this.Controls.Add(this.pnl_all);
            this.Controls.Add(this.btn_select);
            this.Controls.Add(this.btn_view);
            this.Name = "admin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ADMIN ";
            this.pnl_all.ResumeLayout(false);
            this.pnl_all.PerformLayout();
            this.pnl_date.ResumeLayout(false);
            this.pnl_date.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_view;
        private System.Windows.Forms.Button btn_select;
        private System.Windows.Forms.Panel pnl_all;
        private System.Windows.Forms.DateTimePicker date;
        private System.Windows.Forms.Panel pnl_date;
        private System.Windows.Forms.Label lbl_allrecords;
        private System.Windows.Forms.Label lbl_calendar;
    }
}