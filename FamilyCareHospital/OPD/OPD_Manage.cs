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
    public partial class OPD_Manage : Form
    {
        string MyConnection = "datasource=localhost;port=3306;username=root;password=sagarox";
       

        public OPD_Manage()
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
        
        private void btnSearch_Click(object sender, EventArgs e)
        {
            string search = this.txtSearch.Text;
            try
            {

                MySqlConnection MyConn2 = new MySqlConnection(MyConnection);
                MySqlDataAdapter mda = new MySqlDataAdapter("Select patientID,Date,Fname,Lname,NIC,Gender,Age,Address,City,ContactNo from itp.opd where PatientID LIKE '%" + search + "%';", MyConn2);
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

        private void OPD_Manage_Load(object sender, EventArgs e)
        {
            FillGrid();
        }

        private void btnAdd_reg_Click(object sender, EventArgs e)
        {
            this.Close();
            OPD_Registration opdreg = new OPD_Registration();
            opdreg.Show();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            FillGrid();
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                StringBuilder sb = new StringBuilder();
                DataGridViewRow row = this.dataGridView2.Rows[e.RowIndex];
                DataGridViewCell cel = this.dataGridView2.Rows[e.RowIndex].Cells[e.ColumnIndex];

                // Pid = row.Cells["dgvPatient_ID"].Value.ToString();
                this.txtSearch.Text = row.Cells["dgvPatient_ID"].Value.ToString();
                // string id = row.Cells["dgvPatient_ID"].Value.ToString();
                string deleterow = row.Cells["dgvdelete"].Value.ToString();
                // string update = row.Cells["dgvupdate"].Value.ToString();
                string delete = "delete";
                string select = cel.Value.ToString();

                if (select == "Delete")
                {
                    try
                    {
                        MySqlConnection MyConn2 = new MySqlConnection(MyConnection);
                        string Query = "delete from itp.opd where patientID ='" + this.txtSearch.Text + "';";

                        MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);
                        MySqlDataReader MyReader2;
                        MyConn2.Open();
                        MyReader2 = MyCommand2.ExecuteReader();
                        MessageBox.Show("Data Deleted");

                        while (MyReader2.Read())
                        {

                        }
                        MyConn2.Close();
                    }
                    catch (Exception ex)
                    {

                        MessageBox.Show(ex.Message);
                    }
                    FillGrid();
                }
                else if (select == "Update")
                {
                    try
                    {
                        MySqlConnection MyConn2 = new MySqlConnection(MyConnection);


                        string Query = "update itp.opd set Fname='" + dataGridView2.Rows[e.RowIndex].Cells["dgvFirst_Name"].Value.ToString() + "',Lname = '" + dataGridView2.Rows[e.RowIndex].Cells["dgvLast_Name"].Value.ToString() + "',NIC = '" + dataGridView2.Rows[e.RowIndex].Cells["dgvNIC"].Value.ToString() + "',Gender = '" + dataGridView2.Rows[e.RowIndex].Cells["dgvGender"].Value.ToString() + "',Age = '" + dataGridView2.Rows[e.RowIndex].Cells["dgvAge"].Value.ToString() + "',Address = '" + dataGridView2.Rows[e.RowIndex].Cells["dgvAddress"].Value.ToString() + "',City = '" + dataGridView2.Rows[e.RowIndex].Cells["dgvCity"].Value.ToString() + "',ContactNo = '" + dataGridView2.Rows[e.RowIndex].Cells["dgvContactNO"].Value.ToString() + "'where patientID = '" + this.txtSearch.Text + "';";


                        MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);
                        MySqlDataReader MyReader2;
                        MyConn2.Open();
                        MyReader2 = MyCommand2.ExecuteReader();
                        MessageBox.Show("Data Updated");
                        while (MyReader2.Read())
                        {

                        }
                        MyConn2.Close();//Connection closed here
                    }
                    catch (Exception ex)
                    {

                        MessageBox.Show(ex.Message);
                    }
                    FillGrid();

                }
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
           
        }

        private void btn_Back_ManageInPa_Click(object sender, EventArgs e)
        {
            this.Close();
            OPDmain opdm = new OPDmain();
            opdm.Show();
        }
    }
}
