namespace contact_tracing
{
    partial class by_date
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
            this.lbl_bydate = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_bydate
            // 
            this.lbl_bydate.AutoSize = true;
            this.lbl_bydate.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_bydate.ForeColor = System.Drawing.Color.White;
            this.lbl_bydate.Location = new System.Drawing.Point(26, 31);
            this.lbl_bydate.Name = "lbl_bydate";
            this.lbl_bydate.Size = new System.Drawing.Size(253, 21);
            this.lbl_bydate.TabIndex = 19;
            this.lbl_bydate.Text = "List of all records (by selected date)";
            // 
            // by_date
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(116)))), ((int)(((byte)(183)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbl_bydate);
            this.Name = "by_date";
            this.Text = "by_date";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_bydate;
    }
}