using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace contact_tracing
{
    public partial class admin_login_page : Form
    {
        public admin_login_page()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            if (txtbox_username.Text == "arriane" && txtbox_password.Text == "123")
            {
                new admin().Show();
                this.Hide();

            }

            else
            {
                MessageBox.Show("Wrong username or password.");
                txtbox_username.Clear();
                txtbox_password.Clear();
                lbl_username.Focus();


            }

            MessageBox.Show("Welcome!");
            MessageBox.Show("You are now logged in.");
        }
    }
}
