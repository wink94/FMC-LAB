using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FamilyCareHospital.interfaces_HR
{
    public partial class mainHR : Form
    {
        public mainHR(String username=null)
        {

            InitializeComponent();
            lbl_uname.Text = username;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            interfaces_HR.registrationHR registrationLink = new interfaces_HR.registrationHR();
            registrationLink.Show();
        }

        private void btn_addCat_Click(object sender, EventArgs e)
        {
            interfaces_HR.add_departmentHR addDeptLink = new interfaces_HR.add_departmentHR();
            addDeptLink.Show();
        }

        private void btn_logOut_Click(object sender, EventArgs e)
        {
            loginHR lh = new loginHR();
            lh.Show();
            this.Close();
        }

        private void mainHR_Load(object sender, EventArgs e)
        {
            clock.Start();
            label1.Text = DateTime.Now.ToString("hh:mm:ss tt");
            label2.Text = DateTime.Now.ToLongDateString();
            label3.Text = DateTime.Now.DayOfWeek.ToString();
        }

        private void clock_Tick(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.ToString("hh:mm:ss tt");
            clock.Start();
        }

        private void btn_leave_Click(object sender, EventArgs e)
        {
            apply_leaveHR al = new apply_leaveHR();
            al.Show();
        }

        private void btn_mngAttn_Click(object sender, EventArgs e)
        {
            AttendanceHR al = new AttendanceHR();
            al.Show();
        }

        private void btn_vwAttn_Click(object sender, EventArgs e)
        {
            AttendanceHR al = new AttendanceHR();
            al.Show();
        }

        private void btn_vwLeave_Click(object sender, EventArgs e)
        {
            view_leaveHR al = new view_leaveHR();
            al.Show();
        }

        private void btn_mngPay_Click(object sender, EventArgs e)
        {
            calculate_salaryHR al = new calculate_salaryHR();
            al.Show();
        }

        private void btn_vwPay_Click(object sender, EventArgs e)
        {
            view_salaryHR al = new view_salaryHR();
            al.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            interfaces_HR.registrationHR registrationLink = new interfaces_HR.registrationHR();
            registrationLink.Show();
        }

        //private void button4_Click(object sender, EventArgs e)
        //{
        //    interfaces_HR.apply_leaveHR aplyLink= new interfaces_HR.apply_leaveHR();
        //    aplyLink.Show();
        //}
    }
}
