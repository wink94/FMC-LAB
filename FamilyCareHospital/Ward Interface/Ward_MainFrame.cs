using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace FamilyCareHospital
{
    public partial class Ward_MainFrame : Form
    {
        public Ward_MainFrame(String position = null)
        {
            InitializeComponent();
            lblCurrentUser.Text = position;
            timer1.Start();
        }

        //static string myConnection = "Data Source=localhost; Initial Catalog=itp; port=3306; username=root; password=darkangel143";
        //static MySqlConnection myConn = new MySqlConnection(myConnection);

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            DateTime DateTime = DateTime.Now;
            DateTime MonthName = DateTime.Now;

            this.lblCurrentDayName.Text = DateTime.ToString("dddd");
            this.lblCurrentTime.Text = DateTime.ToShortTimeString();
            this.lblCurrentFullDate.Text = DateTime.ToString("dd" + " : " + "MMMM" + " : " + "yyyy");
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            this.Hide();
            Admin f0 = new Admin();
            f0.ShowDialog();
        }

        private void btnWardHandling_Click(object sender, EventArgs e)
        {
            try
            {
                this.Hide();
                Ward_Admin_WardHandling f2 = new Ward_Admin_WardHandling();
                f2.ShowDialog();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
           
            /*
            MySqlConnection myConn = new MySqlConnection(myConnection);
            myConn.Open();

            try
            {
                MySqlDataAdapter myDataAdapter = new MySqlDataAdapter();
                myDataAdapter.SelectCommand = new MySqlCommand("select * itp;", myConn);
                MySqlCommandBuilder cb = new MySqlCommandBuilder(myDataAdapter);

                this.Hide();
                Ward_Admin_WardHandling f2 = new Ward_Admin_WardHandling();
                f2.ShowDialog();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            myConn.Close();
            */
        }

        private void btnViewWard_Click(object sender, EventArgs e)
        {

            try
            {
                this.Hide();
                Ward_Admin_ViewWard_WHandling f3 = new Ward_Admin_ViewWard_WHandling();
                f3.ShowDialog();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnRegisterInPatient_Click(object sender, EventArgs e)
        {
            try
            {
                this.Hide();
                Ward_Admin_RegisterIn_Patient f4 = new Ward_Admin_RegisterIn_Patient();
                f4.ShowDialog();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnManageInPatient_Click(object sender, EventArgs e)
        {
            try
            {
                this.Hide();
                Ward_Admin_Manage_In_Patient f5 = new Ward_Admin_Manage_In_Patient();
                f5.ShowDialog();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnViewInPatient_Click(object sender, EventArgs e)
        {
            try
            {
                this.Hide();
                Ward_Admin_View_In_Patient f6 = new Ward_Admin_View_In_Patient();
                f6.ShowDialog();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnManageDrugStore_Click(object sender, EventArgs e)
        {
            try
            {
                this.Hide();
                Ward_Admin_Manage_Drug_Store f7 = new Ward_Admin_Manage_Drug_Store();
                f7.ShowDialog();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnViewDrugStore_Click(object sender, EventArgs e)
        {
            try
            {
                this.Hide();
                Ward_Admin_View_Drugs f8 = new Ward_Admin_View_Drugs();
                f8.ShowDialog();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_logout_Click(object sender, EventArgs e)
        {
            loginHR lh = new loginHR();
            lh.Show();
            this.Close();
        }
    }
}
