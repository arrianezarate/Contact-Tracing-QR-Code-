namespace contact_tracing
{
    partial class admin_page
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
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
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
            this.pnl_all.Location = new System.Drawing.Point(87, 43);
            this.pnl_all.Name = "pnl_all";
            this.pnl_all.Size = new System.Drawing.Size(205, 100);
            this.pnl_all.TabIndex = 2;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(34, 38);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 3;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(93)))), ((int)(((byte)(160)))));
            this.panel1.Controls.Add(this.dateTimePicker1);
            this.panel1.Location = new System.Drawing.Point(58, 258);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(261, 100);
            this.panel1.TabIndex = 3;
            // 
            // admin_page
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(377, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnl_all);
            this.Controls.Add(this.btn_select);
            this.Controls.Add(this.btn_view);
            this.Name = "admin_page";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ADMIN ";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_view;
        private System.Windows.Forms.Button btn_select;
        private System.Windows.Forms.Panel pnl_all;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Panel panel1;
    }
}