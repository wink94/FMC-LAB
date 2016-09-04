using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using MySql.Data.MySqlClient;

namespace FamilyCareHospital
{
    public partial class Ward_Admin_View_In_Patient : Form
    {
        public Ward_Admin_View_In_Patient()
        {
            InitializeComponent();
            load_datagrid_viewPa();
        }

        static string myConnection = "Data Source=localhost; Initial Catalog=itp; port=3306; username=root; password=sagarox";
        //static MySqlConnection myConn = new MySqlConnection(myConnection);



        DataTable dbDataset;




        private void btn_Back_ViewInPa_Click(object sender, EventArgs e)
        {
            this.Hide();
            Ward_MainFrame f1 = new Ward_MainFrame();
            f1.ShowDialog();
        }


        private void load_datagrid_viewPa()
        {
            MySqlConnection myConn = new MySqlConnection(myConnection);
            myConn.Open();

            try
            {
                string loadDataGridTab1Query = "SELECT i.patient_id as 'PA_ID', i.title as 'TITLE', i.first_name as 'FIRST_NAME', i.last_name as 'LAST_NAME', i.gender as 'GENDER', w.ward_name as 'WARD_NAME', w.floor as 'FLOOR', a.room_no as 'ROOM_NO', a.bed_no as 'BED_NO' from itp.ward_category w, itp.room_details r, itp.bed_details b, itp.in_patient i, itp.assign_patient_to_bed a WHERE w.ward_id=r.ward_id AND r.room_no=b.room_no AND b.room_no=a.room_no AND b.bed_no=a.bed_no AND i.patient_id=a.patient_id;";
                MySqlCommand cmd = new MySqlCommand(loadDataGridTab1Query, myConn);

                MySqlDataAdapter sda = new MySqlDataAdapter();
                sda.SelectCommand = cmd;
                dbDataset = new DataTable();
                sda.Fill(dbDataset);
                BindingSource bSource = new BindingSource();

                bSource.DataSource = dbDataset;
                dataGridView1_viewPatient.DataSource = bSource;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            myConn.Close();
        }


        private void btn_Search_ViewInPa_Click(object sender, EventArgs e)
        {
            MySqlConnection myConn = new MySqlConnection(myConnection);
            myConn.Open();

            DataView DVSearch = new DataView(dbDataset);

            if (cmb_Search_ViewInPa.Text == "")
            {
                MessageBox.Show("Please Select a Category to Search", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
  
            }
            else if (txt_Search_ViewInPa.Text == "")
            {
                MessageBox.Show("Please Input data to Search", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
      
            }
            else
            {
                try
                {
                    if (cmb_Search_ViewInPa.Text == "Patient ID")
                    {
                        DVSearch.RowFilter = string.Format("PA_ID LIKE '%{0}%'", txt_Search_ViewInPa.Text);
                        dataGridView1_viewPatient.DataSource = DVSearch;
                    }
                    else if (cmb_Search_ViewInPa.Text == "First Name")
                    {
                        DVSearch.RowFilter = string.Format("FIRST_NAME LIKE '%{0}%'", txt_Search_ViewInPa.Text);
                        dataGridView1_viewPatient.DataSource = DVSearch;
                    }
                    else if (cmb_Search_ViewInPa.Text == "Last Name")
                    {
                        DVSearch.RowFilter = string.Format("LAST_NAME LIKE '%{0}%'", txt_Search_ViewInPa.Text);
                        dataGridView1_viewPatient.DataSource = DVSearch;
                    }
                    else if (cmb_Search_ViewInPa.Text == "Ward Name")
                    {
                        DVSearch.RowFilter = string.Format("WARD_NAME LIKE '%{0}%'", txt_Search_ViewInPa.Text);
                        dataGridView1_viewPatient.DataSource = DVSearch;
                    }
                    else if (cmb_Search_ViewInPa.Text == "Room No")
                    {
                        DVSearch.RowFilter = string.Format("ROOM_NO LIKE '%{0}%'", txt_Search_ViewInPa.Text);
                        dataGridView1_viewPatient.DataSource = DVSearch;
                    }
                    else if (cmb_Search_ViewInPa.Text == "Bed No")
                    {
                        DVSearch.RowFilter = string.Format("BED_NO LIKE '%{0}%'", txt_Search_ViewInPa.Text);
                        dataGridView1_viewPatient.DataSource = DVSearch;
                    }

                    //enna one method eka
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                this.txt_Search_ViewInPa.Text = "";
                this.cmb_Search_ViewInPa.Text = "";
                myConn.Close();
            }
        }

        private void dataGridView1_viewPatient_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                txt_PaID_ViewInPa.Text = dataGridView1_viewPatient.SelectedRows[0].Cells[0].Value.ToString();
                txt_Fname_ViewInPa.Text = dataGridView1_viewPatient.SelectedRows[0].Cells[2].Value.ToString();
                txt_Lname_ViewInPa.Text = dataGridView1_viewPatient.SelectedRows[0].Cells[3].Value.ToString();

                txt_gender_ViewInPa.Text = dataGridView1_viewPatient.SelectedRows[0].Cells[4].Value.ToString();
                txt_WardName_ViewInPa.Text = dataGridView1_viewPatient.SelectedRows[0].Cells[5].Value.ToString();
                txt_RoomNo_ViewInPa.Text = dataGridView1_viewPatient.SelectedRows[0].Cells[6].Value.ToString();

                txt_BedNo_ViewInPa.Text = dataGridView1_viewPatient.SelectedRows[0].Cells[7].Value.ToString();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnRefresh_ViewPa_Click(object sender, EventArgs e)
        {
            load_datagrid_viewPa();
        }

        private void cmb_Search_ViewInPa_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void btn_LoadChart_Click(object sender, EventArgs e)
        {
            MySqlConnection myConn = new MySqlConnection(myConnection);
            myConn.Open();

            string For_Chart_Query = "SELECT * FROM itp.file_sub_current_condition WHERE file_id='"+txt_PaID_ViewInPa.Text+"';";
            MySqlCommand cmd = new MySqlCommand(For_Chart_Query, myConn);

            MySqlDataReader myReader;

            try
            {
                myReader = cmd.ExecuteReader();

                while(myReader.Read())
                {
                    this.chart1_view.Series["Condition"].Points.AddXY(myReader.GetString("current_date_to_enter"), myReader.GetInt32("state"));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }
    }
}
