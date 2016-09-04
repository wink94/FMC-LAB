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
    public partial class OPDmain : Form
    {
        public OPDmain(String position = null)
        {
            InitializeComponent();
        }


        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            OPD_Manage opdm = new OPD_Manage();
            opdm.Show();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            this.Close();
            OPDview opdvw =new OPDview();
              opdvw.Show();
        }

        private void btnmanage_clinic_Click(object sender, EventArgs e)
        {
            this.Close();
            Clinic_Manage clm = new Clinic_Manage();
            clm.Show();
        }

        private void btnview_presc_Click(object sender, EventArgs e)
        {
            this.Close();
            Prescriptionview pv = new Prescriptionview();
            pv.Show();
        }

        private void btnadvance_bill_Click(object sender, EventArgs e)
        {
            this.Close();
            Advance_payement advp = new Advance_payement();
            advp.Show();

        }

        private void btnview_clinic_Click(object sender, EventArgs e)
        {
            this.Close();
            Clinicview clv = new Clinicview();
            clv.Show();
        }

        private void btnclinic_bill_Click(object sender, EventArgs e)
        {
            this.Close();
            Clinicbill_1 clb = new Clinicbill_1();
            clb.Show();
        }

        private void btnopd_bill_Click(object sender, EventArgs e)
        {
            this.Close();
            OPDbill_1 opdb = new OPDbill_1();
            opdb.Show();
        }

        private void btnpresc_manage_Click(object sender, EventArgs e)
        {
            this.Close();
            Prescription_Manage prm = new Prescription_Manage();
            prm.Show();
        }

        private void btnfull_bill_Click(object sender, EventArgs e)
        {
            this.Close();
            Fullbill fb = new Fullbill();
            fb.Show();
        }

        private void OPDmain_Load(object sender, EventArgs e)
        {
            DateTime DateTime = DateTime.Now;
            DateTime MonthName = DateTime.Now;

            this.lblCurrentDayName.Text = DateTime.ToString("dddd");
            this.lblCurrentTime.Text = DateTime.ToShortTimeString();
            this.lblCurrentFullDate.Text = DateTime.ToString("dd" + " : " + "MMMM" + " : " + "yyyy");
        }
    }
}
