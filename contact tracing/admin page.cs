using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace contact_tracing
{
    public partial class admin : Form
    {
        public admin()
        {
            InitializeComponent();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btn_view_Click(object sender, EventArgs e)
        {
            all_records show = new all_records();
            show.ShowDialog();
        }

        private void btn_select_Click(object sender, EventArgs e)
        {
            List<string> ByDate = new List<string>();
            string Date = date.Text;
            int results = 0;
            var txtlist = Directory.EnumerateFiles(@"C:\Users\arriane\source\repos\contact tracing\lists");
            foreach (string file in txtlist)
            {
                string allcontents = File.ReadAllText(file);
                if (allcontents.Contains(Date))
                {
                    ByDate.Add(allcontents);
                    results++;
                    continue;
                }
            }
            if (results == 0)
            {
                MessageBox.Show("The list for the selected date is empty.");
            }
            else
            {
                StreamWriter file = new StreamWriter(@"C:\Users\arriane\source\repos\contact tracing\lists\select date\records(by date).txt");
                foreach (string contents in ByDate)
                {
                    file.WriteLine(contents);
                }
                file.Close();
                MessageBox.Show("There are " + results + " record(s) on the selected date.");
                if (MessageBox.Show("Confirm", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    by_date bydate = new by_date();
                    bydate.ShowDialog();
                }
            }
        }
    }
}
