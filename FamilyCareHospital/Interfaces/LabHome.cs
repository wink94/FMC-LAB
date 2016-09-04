using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Threading;
using FamilyCareHospital.DBAccess;
using FamilyCareHospital.Interfaces;

namespace FamilyCareHospital
{
    public partial class Form1 : Form
    {
        public Form1(String position = null)
        {
            InitializeComponent();
            lbl_user.Text = position;
            showSystemDateTime(true);
            //DBInsert a = new DBInsert();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        void showSystemDateTime(bool show)
        {
            if (show)
            {
                DateTime dt = DateTime.Parse(DateTime.Today.ToString());
                label6.Text = DateTime.Now.ToString("yyyy MMMM dd");
                
                Timer tmr = new Timer();
                tmr.Interval = 1000;//ticks every 1 second
                tmr.Tick += new EventHandler(tmr_Tick);
                tmr.Start();
            }
            
        }

        void tmr_Tick(object sender, EventArgs e)
        {
            string time = DateTime.Now.ToString("HH:mm:ss");
            int hrs= Convert.ToInt32(DateTime.Now.ToString("HH"));

            if (hrs > 12)
                time += " PM";
            else
                time += " AM";

            label5.Text = time;

        }

        private void btnregPatient_Click(object sender, EventArgs e)
        {
            Form2 patient_appmnt = new Form2();
            patient_appmnt.tabCtrlPReg_App.SelectedIndex = 0;
            patient_appmnt.Show();
            Hide();
        }

        private void btnmanageAppmt_Click(object sender, EventArgs e)
        {
            Form2 patient_appmnt = new Form2();
            patient_appmnt.tabCtrlPReg_App.SelectedIndex = 1;
            patient_appmnt.Show();
            Hide();
        }

        private void btnmanageLabTest_Click(object sender, EventArgs e)
        {
            ManageTest mt= new ManageTest();
            mt.Show();
            Hide();
        }

        private void btn_logout_Click(object sender, EventArgs e)
        {
            loginHR lh = new loginHR();
            lh.Show();
            this.Close();
        }
    }
}
