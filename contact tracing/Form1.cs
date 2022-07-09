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
using AForge.Video;
using AForge.Video.DirectShow;
using ZXing;

namespace contact_tracing
{
    public partial class form_contacttracing : Form
    {
        public form_contacttracing()
        {
            InitializeComponent();
        }

        FilterInfoCollection filter;
        VideoCaptureDevice captureDevice;

        private void form_contacttracing_Load(object sender, EventArgs e)
        {
            filter = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            foreach (FilterInfo filter_info in filter)
                combobox_camera.Items.Add(filter_info.Name);
            combobox_camera.SelectedIndex = 0;
        }

        private void btn_startcam_Click(object sender, EventArgs e)
        {
            captureDevice = new VideoCaptureDevice(filter[combobox_camera.SelectedIndex].MonikerString);
            captureDevice.NewFrame += CaptureDevie_NewFrame;
            captureDevice.Start();
            timer1.Start();
        }

        private void CaptureDevie_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            picbox_cameradisplay.Image = (Bitmap)eventArgs.Frame.Clone();
        }

        private void form_contacttracing_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (captureDevice.IsRunning)
                captureDevice.Stop();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (picbox_cameradisplay.Image != null)
            {
                BarcodeReader QRcode = new BarcodeReader();
                Result result = QRcode.Decode((Bitmap)picbox_cameradisplay.Image);
                if (result != null)
                {
                    txtbox_displaytxt.Text = result.ToString();
                    timer1.Stop();
                    if (captureDevice.IsRunning)
                        captureDevice.Stop();
                }
            }
        }

        private void lbl_email_Click(object sender, EventArgs e)
        {

        }

        private void btn_admin_Click(object sender, EventArgs e)
        {
            admin_login_page show = new admin_login_page();
            show.ShowDialog();
        }

        private void btn_finish_Click(object sender, EventArgs e)
        {
            StreamWriter file = new StreamWriter(@"C:\Users\arriane\source\repos\contact tracing\lists\" + txtbox_lastname.Text + ", " + txtbox_firstname.Text + ", " + txtbox_middlename.Text + ".txt", true);
            file.WriteLine("First Name - " + txtbox_firstname.Text);
            file.WriteLine("Middle Name - " + txtbox_middlename.Text);
            file.WriteLine("Last Name - " + txtbox_lastname.Text);
            file.WriteLine("Age - " + txtbox_age.Text);
            file.WriteLine("Date of Birth - " + txtbox_birthdate.Text);
            file.WriteLine("Mobile No. - " + txtbox_mobile.Text);
            file.WriteLine("Email - " + txtbox_email.Text);
            file.WriteLine("Gender - " + txtbox_gender.Text);
            file.WriteLine("Address - " + txtbox_address.Text);
            file.WriteLine("Date - " + date.Text);
            file.Close();

            MessageBox.Show("Thanks for cooperating.", "Contact Tracing", MessageBoxButtons.OK, MessageBoxIcon.Information);
            MessageBox.Show("Have a good day!", "Contact Tracing", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void date_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btn_filltxtbox_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Autofill processing...", "Contact Tracing", MessageBoxButtons.OK, MessageBoxIcon.Information);

            string myString = txtbox_displaytxt.Text;
            string[] str = myString.Split(' ');
            txtbox_firstname.Text = str[0].Substring(str[0].IndexOf('-') + 1);
            txtbox_middlename.Text = str[1].Substring(str[1].IndexOf('-') + 1);
            txtbox_lastname.Text = str[2].Substring(str[2].IndexOf('-') + 1);
            txtbox_birthdate.Text = str[3].Substring(str[3].IndexOf('-') + 1);
            txtbox_age.Text = str[4].Substring(str[4].IndexOf('-') + 1);
            txtbox_gender.Text = str[5].Substring(str[5].IndexOf('-') + 1);
            txtbox_address.Text = str[6].Substring(str[6].IndexOf('-') + 1);
            txtbox_mobile.Text = str[7].Substring(str[7].IndexOf('-') + 1);
            txtbox_email.Text = str[8].Substring(str[8].IndexOf('-') + 1);
        }
    }
}
