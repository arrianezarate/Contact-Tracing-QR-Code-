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
    public partial class by_date : Form
    {
        public by_date()
        {
            InitializeComponent();
            var recordselectedDate = Directory.GetFiles(@"C:\Users\arriane\source\repos\contact tracing\lists\select date\");
            foreach (string file in recordselectedDate)
            {
                string dates = File.ReadAllText(file);
                lbl_bydate.Text = lbl_bydate.Text + dates + "\n";
            }
        }
    }
}
