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
    public partial class all_records : Form
    {
        public all_records()
        {
            InitializeComponent();
            var allRecords = Directory.GetFiles(@"C:\Users\arriane\source\repos\contact tracing\lists");
            foreach (var file in allRecords)
            {
                string allcontents = File.ReadAllText(file);
                lbl_all.Text = lbl_all.Text + "\n" + allcontents + "\n";
            }
        }
    }
}
