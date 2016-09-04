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
    public partial class TransportMain : Form
    {
        public TransportMain(String position =null)
        {
            InitializeComponent();
            lbl_user.Text = position;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PatientDetails ps = new PatientDetails();
            ps.Show();
            this.Hide();
        }

        private void D_D_Click(object sender, EventArgs e)
        {
            DriverDetails dd = new DriverDetails();
            dd.Show();
            this.Hide();
           
        }

        private void TransportMain_Load(object sender, EventArgs e)
        {

        }

        private void V_D_Click(object sender, EventArgs e)
        {
            VehicleDetails vd = new VehicleDetails();
            vd.Show();
            this.Hide();
        }

        private void PD_Click(object sender, EventArgs e)
        {
            PaymentDetails pd = new PaymentDetails();
            pd.Show();
            this.Hide();
        }

        private void ST_Click(object sender, EventArgs e)
        {
            Statement st = new Statement();
            st.Show();
            this.Hide();
        }

        private void btn_logout_Click(object sender, EventArgs e)
        {
            loginHR lh = new loginHR();
            lh.Show();
            this.Close();
        }
    }
}
