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
using System.Configuration;

namespace FamilyCareHospital
{
    public partial class Clinicview : Form
    {
        string MyConnection = "datasource=localhost;port=3306;username=root;password=sagarox";

        public void FillGrid()
        {
            try
            {

                MySqlConnection MyConn2 = new MySqlConnection(MyConnection);
                MySqlDataAdapter mda = new MySqlDataAdapter("Select ClinicID,Date,Fname,Lname,NIC,Gender,Age,CivilStatus,BloodGroup,Address,City,ContactNo from itp.clinic;", MyConn2);

                MyConn2.Open();
                DataSet ds = new DataSet();
                mda.Fill(ds, "clinic");
                dataGridView2.DataSource = ds.Tables["clinic"];
                MyConn2.Close();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        public Clinicview()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {

                MySqlConnection MyConn2 = new MySqlConnection(MyConnection);
                MySqlDataAdapter mda = new MySqlDataAdapter("Select ClinicID,Date,Fname,Lname,NIC,Gender,Age,CivilStatus,BloodGroup,Address,City,ContactNo from itp.clinic where ClinicID LIKE '%" + this.txtSearch.Text + "%'; ", MyConn2);
                // MySqlCommand MyCommand2 = new MySqlCommand(mda, MyConn2);
                MyConn2.Open();
                DataSet ds = new DataSet();
                mda.Fill(ds, "clinic");
                dataGridView2.DataSource = ds.Tables["clinic"];
                MyConn2.Close();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }

        private void Clinicview_Load(object sender, EventArgs e)
        {
            FillGrid();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            FillGrid();
        }

        private void btn_Back_ManageInPa_Click(object sender, EventArgs e)
        {
            this.Close();
            OPDmain opdm = new OPDmain();
            opdm.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
