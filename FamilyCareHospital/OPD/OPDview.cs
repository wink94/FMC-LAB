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
    public partial class OPDview : Form
    {
        string MyConnection = "datasource=localhost;port=3306;username=root;password=sagarox";

        public OPDview()
        {
            InitializeComponent();
        }

        public void FillGrid()
        {
            try
            {

                MySqlConnection MyConn2 = new MySqlConnection(MyConnection);
                MySqlDataAdapter mda = new MySqlDataAdapter("Select patientID,Date,Fname,Lname,NIC,Gender,Age,Address,City,ContactNo from itp.opd;", MyConn2);

                MyConn2.Open();
                DataSet ds = new DataSet();
                mda.Fill(ds, "opd");
                dataGridView2.DataSource = ds.Tables["opd"];
                MyConn2.Close();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }


        private void btnRefresh_Click(object sender, EventArgs e)
        {
            FillGrid();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {

                MySqlConnection MyConn2 = new MySqlConnection(MyConnection);
                MySqlDataAdapter mda = new MySqlDataAdapter("Select patientID,Date,Fname,Lname,NIC,Gender,Age,Address,City,ContactNo from itp.opd where patientID LIKE '%" + this.txtSearch.Text + "%'; ", MyConn2);
                // MySqlCommand MyCommand2 = new MySqlCommand(mda, MyConn2);
                MyConn2.Open();
                DataSet ds = new DataSet();
                mda.Fill(ds, "opd");
                dataGridView2.DataSource = ds.Tables["opd"];
                MyConn2.Close();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void OPDview_Load(object sender, EventArgs e)
        {
            FillGrid();
        }

        private void btn_Back_ManageInPa_Click(object sender, EventArgs e)
        {
            this.Close();
            OPDmain opdm =new OPDmain();
            opdm.Show();
        }
    }
}
