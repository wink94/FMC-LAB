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
    public partial class Prescriptionview : Form
    {
        string MyConnection = "datasource=localhost;port=3306;username=root;password=sagarox";

        public Prescriptionview()
        {
            InitializeComponent();
        }

        public void FillGrid()
        {
            try
            {

                MySqlConnection MyConn2 = new MySqlConnection(MyConnection);
                MySqlDataAdapter mda = new MySqlDataAdapter("Select Presc_ID,Date,Chistory,Medication,Note from itp.prescription;", MyConn2);

                MyConn2.Open();
                DataSet ds = new DataSet();
                mda.Fill(ds, "prescription");
                dataGridView2.DataSource = ds.Tables["prescription"];
                MyConn2.Close();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }


        private void Prescriptionview_Load(object sender, EventArgs e)
        {
            FillGrid();
        }

        private void btn_Back_ManageInPa_Click(object sender, EventArgs e)
        {
            this.Close();
            OPDmain opdm = new OPDmain();
            opdm.Show();
        }
    }
}
