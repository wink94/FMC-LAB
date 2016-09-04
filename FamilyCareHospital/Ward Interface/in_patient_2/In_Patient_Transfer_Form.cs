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
    public partial class In_Patient_Transfer_Form : Form
    {
        public In_Patient_Transfer_Form(string Pa_ID, string Pa_Fname, string Pa_Lname, string RoomNo, string BedNo)
        {
            InitializeComponent();
            txt_Transfer_InPa_ID.Text = Pa_ID;
            txt_Transfer_InPa_FName.Text = Pa_Fname;
            txt_Transfer_InPa_LName.Text = Pa_Lname;
            txt_RoomNo_from_ManageInPaForm_To_Transfer.Text = RoomNo;
            txt_BedNo_from_ManageInPaForm_To_Transfer.Text = BedNo;

            FillWardNameCombo_Transfer();
        }


        static string myConnection = "Data Source=localhost; Initial Catalog=itp; port=3306; username=root; password=sagarox";
        //static MySqlConnection myConn = new MySqlConnection(myConnection);


        DataTable dbDataset;



        void FillWardNameCombo_Transfer()
        {
            MySqlConnection myConn = new MySqlConnection(myConnection);
            myConn.Open();

            string combo1_Transfer_Query = "select * from itp.ward_category;";
            MySqlCommand cmd = new MySqlCommand(combo1_Transfer_Query, myConn);
            MySqlDataReader myReader;

            try
            {
                myReader = cmd.ExecuteReader();
                cmb_Transfer_Search.Items.Clear();


                while (myReader.Read())
                {
                    string wName = myReader.GetString("ward_name");
                    cmb_Transfer_Search.Items.Add(wName);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            myConn.Close();
        }



        private void cmb_Transfer_Search_SelectedIndexChanged(object sender, EventArgs e)
        {
            MySqlConnection myConn = new MySqlConnection(myConnection);
            myConn.Open();

            string wardDetailsQuery = "select * from itp.ward_category where ward_name='"+cmb_Transfer_Search.Text+"';";
            MySqlCommand cmd4 = new MySqlCommand(wardDetailsQuery, myConn);
            MySqlDataReader myReader;

            try
            {
                myReader = cmd4.ExecuteReader();

                while (myReader.Read())
                {
                    string wID = myReader.GetString("ward_id");
                    string wName = myReader.GetString("ward_name");
                    string floor = myReader.GetString("floor");

                    txt_Transfer_WardID.Text = wID;
                    txt_Transfer_WardName.Text = wName;
                    txt_Transfer_Floor.Text = floor;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            myConn.Close();
        }



        private void btn_Check_Transfer_Click(object sender, EventArgs e)
        {
            load_datagrid_Transfer();
        }



        private void load_datagrid_Transfer()
        {
            MySqlConnection myConn = new MySqlConnection(myConnection);
            myConn.Open();

            try
            {
                string loadDataGrid_Transfer_Query = "SELECT w.ward_name as 'WARD_NAME', w.floor as 'FLOOR', c.type as 'CLASS_TYPE', r.room_no as 'ROOM_NO', b.bed_no as 'BED_NO', c.price as 'PRICE', b.status as 'STATUS' from itp.ward_category w, itp.class_type c, itp.room_details r, itp.bed_details b WHERE w.ward_id=r.ward_id AND c.type=r.type AND r.room_no=b.room_no AND w.ward_id='"+txt_Transfer_WardID.Text+"' AND b.status='Available';";
                MySqlCommand cmd = new MySqlCommand(loadDataGrid_Transfer_Query, myConn);

                MySqlDataAdapter sda = new MySqlDataAdapter();
                sda.SelectCommand = cmd;
                dbDataset = new DataTable();
                sda.Fill(dbDataset);
                BindingSource bSource = new BindingSource();

                bSource.DataSource = dbDataset;
                dataGridView1_Transfer_InPa.DataSource = bSource;

                Bitmap img = new Bitmap(Properties.Resources.AVAILABILITY_CHECK_checkmark_24px);
                clickToBookBed_Transfer.Image = img;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            myConn.Close();
        }

        private void dataGridView1_Transfer_InPa_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (this.dataGridView1_Transfer_InPa.Rows[e.RowIndex].IsNewRow && e.ColumnIndex == 0)
            {
                e.Value = Properties.Resources.more_24px;
            }
        }

        private void dataGridView1_Transfer_InPa_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                try
                {
                    this.txt_Transfer_RoomNo.Text = dataGridView1_Transfer_InPa.SelectedRows[0].Cells[4].Value.ToString();
                    this.txt_Transfer_BedNo.Text = dataGridView1_Transfer_InPa.SelectedRows[0].Cells[5].Value.ToString();
                    this.txt_Transfer_Status.Text = "Not Available";
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void dataGridView1_Transfer_InPa_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                this.txt_Transfer_RoomNo.Text = dataGridView1_Transfer_InPa.SelectedRows[0].Cells[4].Value.ToString();
                this.txt_Transfer_BedNo.Text = dataGridView1_Transfer_InPa.SelectedRows[0].Cells[5].Value.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnUpdate_Transfer_Click(object sender, EventArgs e)
        {
            MySqlConnection myConn = new MySqlConnection(myConnection);

            if (this.txt_Transfer_WardID.Text == "" || this.txt_Transfer_WardName.Text == "" || this.txt_Transfer_Floor.Text == "" || this.txt_Transfer_RoomNo.Text == "" || this.txt_Transfer_BedNo.Text == "" || this.txt_Transfer_Status.Text == "")
            {
                MessageBox.Show("Cannot Register a Patient without assigning to a Room and Bed.", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            else
            {
                DialogResult updatePermission;
                updatePermission = MessageBox.Show("Do you want to Transfer the Patient", "Transfer Patient", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                if (updatePermission == DialogResult.OK)
                {
                    myConn.Open();
                    string update_booking_roomBed_Transfer_Query = "UPDATE `itp`.`assign_patient_to_bed` SET `room_no`='" + this.txt_Transfer_RoomNo.Text + "',`bed_no`='" + txt_Transfer_BedNo.Text + "' WHERE `patient_id`='" + this.txt_Transfer_InPa_ID.Text + "' AND `room_no`='" + txt_RoomNo_from_ManageInPaForm_To_Transfer.Text + "' AND `bed_no`='" + txt_BedNo_from_ManageInPaForm_To_Transfer.Text + "';";
                    MySqlCommand cmd1 = new MySqlCommand(update_booking_roomBed_Transfer_Query, myConn);
                    MySqlDataReader myReader1;
                    myReader1 = cmd1.ExecuteReader();
                    myConn.Close();


                    myConn.Open();
                    string update_bedStatus_Transfer_Query = "UPDATE `itp`.`bed_details` SET `status`='" + this.txt_Transfer_Status.Text + "' WHERE `room_no`='" + this.txt_Transfer_RoomNo.Text + "' AND `bed_no`='" + this.txt_Transfer_BedNo.Text + "';";
                    MySqlCommand cmd2 = new MySqlCommand(update_bedStatus_Transfer_Query, myConn);
                    MySqlDataReader myReader2;
                    myReader2 = cmd2.ExecuteReader();
                    myConn.Close();


                    myConn.Open();
                    string update_OLDbedStatus_Transfer_Query = "UPDATE `itp`.`bed_details` SET `status`='Available' WHERE `room_no`='" + this.txt_RoomNo_from_ManageInPaForm_To_Transfer.Text + "' AND `bed_no`='" + this.txt_BedNo_from_ManageInPaForm_To_Transfer.Text + "';";
                    MySqlCommand cmd3 = new MySqlCommand(update_OLDbedStatus_Transfer_Query, myConn);
                    MySqlDataReader myReader3;
                    myReader3 = cmd3.ExecuteReader();
                    myConn.Close();

                    MessageBox.Show("Successfully Transfered!!", "Successful Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    load_datagrid_Transfer();
                }  
            }
        }

        
        private void btn_Back_Transfer_InPa_Click(object sender, EventArgs e)
        {
            DialogResult backPermission;
            backPermission = MessageBox.Show("Do you want to go to the Previous Form", "Back to Previous", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (backPermission == DialogResult.OK)
            {
                this.Hide();
                Ward_Admin_Manage_In_Patient f_manageIn = new Ward_Admin_Manage_In_Patient();
                f_manageIn.ShowDialog();
            }
        }

        private void btn_Transfer_cancel_Click(object sender, EventArgs e)
        {
            DialogResult cancelPermission;
            cancelPermission=MessageBox.Show("Do you want to cancel the Patient Transfer", "Permission for Cancel", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if(cancelPermission==DialogResult.Yes)
            {
                this.Hide();
                Ward_Admin_Manage_In_Patient f_manageIn = new Ward_Admin_Manage_In_Patient();
                f_manageIn.ShowDialog();
            }

            
        }

        private void btn_Refresh_Transfer_Click(object sender, EventArgs e)
        {
            load_datagrid_Transfer();
        }

        private void cmb_Transfer_Search_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }




    }
}
