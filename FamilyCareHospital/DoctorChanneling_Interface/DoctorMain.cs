using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FamilyCareHospital
{
    public partial class DoctorMain : Form
    {
        public DoctorMain(String positon = null)
        {
            InitializeComponent();
            lbl_user.Text = positon;
            DateTime datetime = DateTime.Now;
            lbl_user.ForeColor = System.Drawing.Color.White; label5.ForeColor = System.Drawing.Color.Red;
            label6.ForeColor = System.Drawing.Color.White; label7.ForeColor = System.Drawing.Color.Red;
            panel2.BackColor= System.Drawing.Color.Black; panel4.BackColor = System.Drawing.Color.Black;
            this.label5.Text = datetime.ToString("hh : mm : ss tt");
            this.label6.Text = datetime.ToString("dd  MMMM  yyyy");
            label7.Text = DateTime.Now.DayOfWeek.ToString();
        }

      

        private void button1_Click_1(object sender, EventArgs e)
        {
            DoctorRegistrationForm d1 = new DoctorRegistrationForm();
            this.Hide();
            d1.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DoctorSearch d4 = new DoctorSearch();
            this.Hide();
            d4.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            View_Appointments d7 = new View_Appointments();
            this.Hide();
            d7.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            CalculatePayments ca = new CalculatePayments();
            this.Hide();
            ca.ShowDialog();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            
            loginHR lh = new loginHR();
            lh.Show();
            
            this.Dispose();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
           /* Admin ad = new Admin();
            this.Hide();
            ad.ShowDialog();*/
        }

        private void DoctorMain_Load(object sender, EventArgs e)
        {

        }
    }
}
