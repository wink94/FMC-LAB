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
    public partial class Clinic_Manage : Form
    {
        string MyConnection = "datasource=localhost;port=3306;username=root;password=sagarox";

        public Clinic_Manage()
        {
            InitializeComponent();
        }

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


        private void btnAdd_reg_Click(object sender, EventArgs e)
        {
            this.Close();
            Clinic_Registration clreg = new Clinic_Registration();
            clreg.Show();
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

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex >= 0)
            {
                StringBuilder sb = new StringBuilder();
                DataGridViewRow row = this.dataGridView2.Rows[e.RowIndex];
                DataGridViewCell cel = this.dataGridView2.Rows[e.RowIndex].Cells[e.ColumnIndex];

               
                this.txtSearch.Text = row.Cells["dgvClinic_ID"].Value.ToString();
               
               // string deleterow = row.Cells["dgvdelete"].Value.ToString();
               
               
                string select = cel.Value.ToString();

                if (select == "Delete")
                {
                    try
                    {
                        MySqlConnection MyConn2 = new MySqlConnection(MyConnection);
                        string Query = "delete from itp.clinic where ClinicID ='" + this.txtSearch.Text + "';";

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


                        string Query = "update itp.clinic set Fname='" + dataGridView2.Rows[e.RowIndex].Cells["dgvFirst_Name"].Value.ToString() + "',Lname = '" + dataGridView2.Rows[e.RowIndex].Cells["dgvLast_Name"].Value.ToString() + "',NIC = '" + dataGridView2.Rows[e.RowIndex].Cells["dgvNIC"].Value.ToString() + "',Gender = '" + dataGridView2.Rows[e.RowIndex].Cells["dgvGender"].Value.ToString() + "',Age = '" + dataGridView2.Rows[e.RowIndex].Cells["dgvAge"].Value.ToString() + "',CivilStatus = '" + dataGridView2.Rows[e.RowIndex].Cells["dgvcivil_status"].Value.ToString() + "',BloodGroup = '" + dataGridView2.Rows[e.RowIndex].Cells["dgvblood"].Value.ToString() + "',Address = '" + dataGridView2.Rows[e.RowIndex].Cells["dgvAddress"].Value.ToString() + "',City = '" + dataGridView2.Rows[e.RowIndex].Cells["dgvCity"].Value.ToString() + "',ContactNo = '" + dataGridView2.Rows[e.RowIndex].Cells["dgvContactNO"].Value.ToString() + "'where ClinicID = '" + this.txtSearch.Text + "';";


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

        private void Clinic_Manage_Load(object sender, EventArgs e)
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
    }
}
