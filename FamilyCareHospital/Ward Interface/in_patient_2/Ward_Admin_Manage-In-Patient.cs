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
    public partial class Ward_Admin_Manage_In_Patient : Form
    {
        public Ward_Admin_Manage_In_Patient()
        {
            InitializeComponent();

            auto_load_datagrid_Tab1(); //Tab 01
            auto_load_datagrid_Tab2(); //Tab 02
        }


        static string myConnection = "Data Source=localhost; Initial Catalog=itp; port=3306; username=root; password=sagarox";
        //static MySqlConnection myConn = new MySqlConnection(myConnection);


        DataTable dbDataset;


        //common to all TABS
        private void btn_Back_ManageInPa_Click(object sender, EventArgs e)
        {
            this.Hide();
            Ward_MainFrame f1 = new Ward_MainFrame();
            f1.ShowDialog();
        }




        /*
         * ///////////////////////////////////////////////
         * 1st TAB
         * In Patient Details
         * content
         * Start
         * //////////////////////////////////////////////
         */


        string Pa_Gender;



        private void radioButton1_InPa_genderMale_Tab1_CheckedChanged(object sender, EventArgs e)
        {
            Pa_Gender = "Male";
        }

        private void radioButton2_InPa_genderFemale_Tab1_CheckedChanged(object sender, EventArgs e)
        {
            Pa_Gender = "Female";
        }


        private void dateTimePicker_InPa_DOB_Tab1_ValueChanged(object sender, EventArgs e)
        {
            TimeSpan age = DateTime.Now - dateTimePicker_InPa_DOB_Tab1.Value;
            int years = DateTime.Now.Year - dateTimePicker_InPa_DOB_Tab1.Value.Year;
            if (dateTimePicker_InPa_DOB_Tab1.Value.AddYears(years) > DateTime.Now) years--;
            this.txt_InPa_age_Tab1.Text = years.ToString();
        }


        private void auto_load_datagrid_Tab1()
        {
            MySqlConnection myConn = new MySqlConnection(myConnection);
            myConn.Open();

            try
            {
                string autoload_Tab1_Query = "SELECT i.patient_id as 'PA_ID', i.title as 'TITLE', i.first_name as 'FIRST_NAME', i.middle_name as 'MIDDLE_NAME', i.last_name as 'LAST_NAME', i.nic as 'NIC', i.gender as 'GENDER', i.date_of_birth as 'DATE_OF_BIRTH', i.age as 'AGE', i.civil_status as 'CIVIL_STATUS', i.contact_number as 'CONTACT_NUMBER', w.ward_name as 'WARD_NAME', w.floor as 'FLOOR', a.room_no as 'ROOM_NO', a.bed_no as 'BED_NO' from itp.ward_category w, itp.room_details r, itp.bed_details b, itp.in_patient i, itp.assign_patient_to_bed a WHERE w.ward_id=r.ward_id AND r.room_no=b.room_no AND b.room_no=a.room_no AND b.bed_no=a.bed_no AND i.patient_id=a.patient_id;";
                MySqlCommand cmd = new MySqlCommand(autoload_Tab1_Query, myConn);

                MySqlDataAdapter sda = new MySqlDataAdapter();
                sda.SelectCommand = cmd;
                dbDataset = new DataTable();
                sda.Fill(dbDataset);
                BindingSource bSource = new BindingSource();

                bSource.DataSource = dbDataset;
                dataGridView1_InPaDetails_Tab1.DataSource = bSource;

                Bitmap img = new Bitmap(Properties.Resources.edit_black_24px);
                clickForUpdate_Tab1.Image = img;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            myConn.Close();
        }

        private void Ward_Admin_Manage_In_Patient_Load(object sender, EventArgs e)
        {

        }

        private void btnSearch_Tab1_Click(object sender, EventArgs e)
        {
            MySqlConnection myConn = new MySqlConnection(myConnection);
            myConn.Open();

            DataView DVSearch = new DataView(dbDataset);

            if (cmb_SelectKeywordtoSearch_InPa.Text == "")
            {
                MessageBox.Show("Please Select a Category to Search", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            else if (txt_SearchKeyWord_InPa.Text == "")
            {
                MessageBox.Show("Please Input data to Search", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            else
            {
                try
                {
                    if (cmb_SelectKeywordtoSearch_InPa.Text == "Patient ID")
                    {
                        DVSearch.RowFilter = string.Format("PA_ID LIKE '%{0}%'", txt_SearchKeyWord_InPa.Text);
                        dataGridView1_InPaDetails_Tab1.DataSource = DVSearch;
                    }

                    else if (cmb_SelectKeywordtoSearch_InPa.Text == "First Name")
                    {
                        DVSearch.RowFilter = string.Format("FIRST_NAME LIKE '%{0}%'", txt_SearchKeyWord_InPa.Text);
                        dataGridView1_InPaDetails_Tab1.DataSource = DVSearch;
                    }

                    else if (cmb_SelectKeywordtoSearch_InPa.Text == "Last Name")
                    {
                        DVSearch.RowFilter = string.Format("LAST_NAME LIKE '%{0}%'", txt_SearchKeyWord_InPa.Text);
                        dataGridView1_InPaDetails_Tab1.DataSource = DVSearch;
                    }
                    else if (cmb_SelectKeywordtoSearch_InPa.Text == "Ward Name")
                    {
                        DVSearch.RowFilter = string.Format("WARD_NAME LIKE '%{0}%'", txt_SearchKeyWord_InPa.Text);
                        dataGridView1_InPaDetails_Tab1.DataSource = DVSearch;
                    }
                    else if (cmb_SelectKeywordtoSearch_InPa.Text == "Room No")
                    {
                        DVSearch.RowFilter = string.Format("ROOM_NO LIKE '%{0}%'", txt_SearchKeyWord_InPa.Text);
                        dataGridView1_InPaDetails_Tab1.DataSource = DVSearch;
                    }
                    else if (cmb_SelectKeywordtoSearch_InPa.Text == "Bed No")
                    {
                        DVSearch.RowFilter = string.Format("BED_NO LIKE '%{0}%'", txt_SearchKeyWord_InPa.Text);
                        dataGridView1_InPaDetails_Tab1.DataSource = DVSearch;
                    }
                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                this.txt_SearchKeyWord_InPa.Text = "";
                this.cmb_SelectKeywordtoSearch_InPa.Text = "";
                myConn.Close();
            }
        }

        private void dataGridView1_InPaDetails_Tab1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (this.dataGridView1_InPaDetails_Tab1.Rows[e.RowIndex].IsNewRow && e.ColumnIndex == 0)
            {
                e.Value = Properties.Resources.more_24px;
            }
        }

        private void btnUpdate_Tab1_Click(object sender, EventArgs e)
        {
            MySqlConnection myConn = new MySqlConnection(myConnection);
            myConn.Open();

            if (txt_InPa_ID_Tab1.Text == "" || cmb_InPa_title_Tab1.Text == "" || txt_InPa_FName_Tab1.Text == "" || txt_InPa_MName_Tab1.Text == "" || txt_InPa_LName_Tab1.Text == "" || txt_InPa_NIC_Tab1.Text == "" || dateTimePicker_InPa_DOB_Tab1.Text == "" || txt_InPa_age_Tab1.Text == "" || cmb_InPa_civilStatus_Tab1.Text == "" || txt_InPa_phone_Tab1.Text == "")
            {
                MessageBox.Show("Cannot Update. Fields are Empty", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            else if (!radioButton1_InPa_genderMale_Tab1.Checked && !radioButton2_InPa_genderFemale_Tab1.Checked)
            {
                MessageBox.Show("Cannot Update. Please Select Ventilation Type", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            else
            {
                try
                {
                    string updateQuery = "UPDATE `itp`.`in_patient` SET `title`='" + this.cmb_InPa_title_Tab1.Text + "',`first_name`='" + this.txt_InPa_FName_Tab1.Text + "',`middle_name`='" + this.txt_InPa_MName_Tab1.Text + "',`last_name`='" + this.txt_InPa_LName_Tab1.Text + "',`nic`='" + this.txt_InPa_NIC_Tab1.Text + "',`gender`='" + Pa_Gender + "',`date_of_birth`='" + this.dateTimePicker_InPa_DOB_Tab1.Text + "',`age`='" + this.txt_InPa_age_Tab1.Text + "',`civil_status`='" + this.cmb_InPa_civilStatus_Tab1.Text + "',`contact_number`='" + this.txt_InPa_phone_Tab1.Text + "' WHERE `patient_id`='" + this.txt_InPa_ID_Tab1.Text + "';";
                    MySqlCommand cmd = new MySqlCommand(updateQuery, myConn);
                    MySqlDataReader myReader;

                    myReader = cmd.ExecuteReader();
                    MessageBox.Show("Record Updated Successfully !!", "Successful Message", MessageBoxButtons.OK, MessageBoxIcon.Information);


                    this.txt_InPa_ID_Tab1.Text = "";
                    this.cmb_InPa_title_Tab1.SelectedIndex = -1;

                    this.txt_InPa_FName_Tab1.Text = "";
                    this.txt_InPa_MName_Tab1.Text = "";
                    this.txt_InPa_LName_Tab1.Text = "";
                    this.txt_InPa_NIC_Tab1.Text = "";
                    this.dateTimePicker_InPa_DOB_Tab1.Value = DateTime.Now;
                    this.txt_InPa_age_Tab1.Text = "";
                    this.cmb_InPa_civilStatus_Tab1.SelectedIndex = -1;
                    this.txt_InPa_phone_Tab1.Text = "";
                    radioButton1_InPa_genderMale_Tab1.Checked = false;
                    radioButton2_InPa_genderFemale_Tab1.Checked = false;

                    this.cmb_InPa_title_Tab1.Enabled = false;
                    this.txt_InPa_FName_Tab1.Enabled = false;
                    this.txt_InPa_MName_Tab1.Enabled = false;
                    this.txt_InPa_LName_Tab1.Enabled = false;
                    this.txt_InPa_NIC_Tab1.Enabled = false;
                    this.dateTimePicker_InPa_DOB_Tab1.Enabled = false;
                    this.cmb_InPa_civilStatus_Tab1.Enabled = false;
                    this.txt_InPa_phone_Tab1.Enabled = false;
                    this.radioButton1_InPa_genderMale_Tab1.Enabled = false;
                    this.radioButton2_InPa_genderFemale_Tab1.Enabled = false;

                    while (myReader.Read())
                    {

                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                auto_load_datagrid_Tab1();
                myConn.Close();
            }
        }

        private void dataGridView1_InPaDetails_Tab1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.ColumnIndex == 0)
                {
                    this.cmb_InPa_title_Tab1.Enabled = true;
                    this.txt_InPa_FName_Tab1.Enabled = true;
                    this.txt_InPa_MName_Tab1.Enabled = true;
                    this.txt_InPa_LName_Tab1.Enabled = true;
                    this.txt_InPa_NIC_Tab1.Enabled = true;
                    this.dateTimePicker_InPa_DOB_Tab1.Enabled = true;
                    this.cmb_InPa_civilStatus_Tab1.Enabled = true;
                    this.txt_InPa_phone_Tab1.Enabled = true;
                    this.radioButton1_InPa_genderMale_Tab1.Enabled = true;
                    this.radioButton2_InPa_genderFemale_Tab1.Enabled = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void dataGridView1_InPaDetails_Tab1_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                this.txt_InPa_ID_Tab1.Text = dataGridView1_InPaDetails_Tab1.SelectedRows[0].Cells[1].Value.ToString();
                this.cmb_InPa_title_Tab1.Text = dataGridView1_InPaDetails_Tab1.SelectedRows[0].Cells[2].Value.ToString();
                this.txt_InPa_FName_Tab1.Text = dataGridView1_InPaDetails_Tab1.SelectedRows[0].Cells[3].Value.ToString();
                this.txt_InPa_MName_Tab1.Text = dataGridView1_InPaDetails_Tab1.SelectedRows[0].Cells[4].Value.ToString();
                this.txt_InPa_LName_Tab1.Text = dataGridView1_InPaDetails_Tab1.SelectedRows[0].Cells[5].Value.ToString();
                this.txt_InPa_NIC_Tab1.Text = dataGridView1_InPaDetails_Tab1.SelectedRows[0].Cells[6].Value.ToString();
                this.dateTimePicker_InPa_DOB_Tab1.Text = dataGridView1_InPaDetails_Tab1.SelectedRows[0].Cells[8].Value.ToString();
                this.txt_InPa_age_Tab1.Text = dataGridView1_InPaDetails_Tab1.SelectedRows[0].Cells[9].Value.ToString();
                this.cmb_InPa_civilStatus_Tab1.Text = dataGridView1_InPaDetails_Tab1.SelectedRows[0].Cells[10].Value.ToString();
                this.txt_InPa_phone_Tab1.Text = dataGridView1_InPaDetails_Tab1.SelectedRows[0].Cells[11].Value.ToString();

                //gender
                string gender_value = dataGridView1_InPaDetails_Tab1.SelectedRows[0].Cells[7].Value.ToString();
                if (gender_value == "Male")
                {
                    radioButton1_InPa_genderMale_Tab1.Checked = true;
                }
                else
                {
                    radioButton2_InPa_genderFemale_Tab1.Checked = true;
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnClear_Content_Tab1_Click(object sender, EventArgs e)
        {
            this.txt_InPa_ID_Tab1.Text = "";
            this.cmb_InPa_title_Tab1.SelectedIndex = -1;

            this.txt_InPa_FName_Tab1.Text = "";
            this.txt_InPa_MName_Tab1.Text = "";
            this.txt_InPa_LName_Tab1.Text = "";
            this.txt_InPa_NIC_Tab1.Text = "";
            this.dateTimePicker_InPa_DOB_Tab1.Value = DateTime.Now;
            this.txt_InPa_age_Tab1.Text = "";
            this.cmb_InPa_civilStatus_Tab1.SelectedIndex = -1;
            this.txt_InPa_phone_Tab1.Text = "";
            radioButton1_InPa_genderMale_Tab1.Checked = false;
            radioButton2_InPa_genderFemale_Tab1.Checked = false;
        }

        private void btnRefresh_Tab1_Click(object sender, EventArgs e)
        {
            auto_load_datagrid_Tab1();
        }

        private void cmb_SelectKeywordtoSearch_InPa_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void cmb_InPa_title_Tab1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void txt_InPa_FName_Tab1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) || e.KeyChar == 8 || e.KeyChar == 46) //8=backspace 46=del
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void txt_InPa_MName_Tab1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) || e.KeyChar == 8 || e.KeyChar == 46) //8=backspace 46=del
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void txt_InPa_LName_Tab1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) || e.KeyChar == 8 || e.KeyChar == 46) //8=backspace 46=del
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void txt_InPa_NIC_Tab1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar) || e.KeyChar == 'v' || e.KeyChar == 8 || e.KeyChar == 46) //8=backspace, 46=del (allow)
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void cmb_InPa_civilStatus_Tab1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void txt_InPa_phone_Tab1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar) || e.KeyChar == 8 || e.KeyChar == 46) //8=backspace, 46=del (allow)
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }






        /*
         * ///////////////////////////////////////////////
         * 2nd TAB
         * Transfer Room
         * content
         * Start
         * //////////////////////////////////////////////
         */



        private void auto_load_datagrid_Tab2()
        {
            MySqlConnection myConn = new MySqlConnection(myConnection);
            myConn.Open();

            try
            {
                string autoload_Tab2_Query = "SELECT i.patient_id as 'PA_ID', i.title as 'TITLE', i.first_name as 'FIRST_NAME', i.middle_name as 'MIDDLE_NAME', i.last_name as 'LAST_NAME', w.ward_id as 'WARD_ID', w.ward_name as 'WARD_NAME', w.floor as 'FLOOR', a.room_no as 'ROOM_NO', a.bed_no as 'BED_NO' from itp.ward_category w, itp.room_details r, itp.bed_details b, itp.in_patient i, itp.assign_patient_to_bed a WHERE w.ward_id=r.ward_id AND r.room_no=b.room_no AND b.room_no=a.room_no AND b.bed_no=a.bed_no AND i.patient_id=a.patient_id;";
                MySqlCommand cmd = new MySqlCommand(autoload_Tab2_Query, myConn);

                MySqlDataAdapter sda = new MySqlDataAdapter();
                sda.SelectCommand = cmd;
                dbDataset = new DataTable();
                sda.Fill(dbDataset);
                BindingSource bSource = new BindingSource();

                bSource.DataSource = dbDataset;
                dataGridView1_Tab2.DataSource = bSource;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            myConn.Close();
        }


        private void btn_Search_Tab2_Click(object sender, EventArgs e)
        {
            MySqlConnection myConn = new MySqlConnection(myConnection);
            myConn.Open();

            DataView DVSearch = new DataView(dbDataset);

            if (cmb_InPa_Search_Tab2.Text == "")
            {
                MessageBox.Show("Please Select a Category to Search", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            else if (txt_InPa_Search_Tab2.Text == "")
            {
                MessageBox.Show("Please Input data to Search", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            else
            {
                try
                {
                    if (cmb_InPa_Search_Tab2.Text == "Patient ID")
                    {
                        DVSearch.RowFilter = string.Format("PA_ID LIKE '%{0}%'", txt_InPa_Search_Tab2.Text);
                        dataGridView1_Tab2.DataSource = DVSearch;
                    }

                    else if (cmb_InPa_Search_Tab2.Text == "First Name")
                    {
                        DVSearch.RowFilter = string.Format("FIRST_NAME LIKE '%{0}%'", txt_InPa_Search_Tab2.Text);
                        dataGridView1_Tab2.DataSource = DVSearch;
                    }

                    else if (cmb_InPa_Search_Tab2.Text == "Last Name")
                    {
                        DVSearch.RowFilter = string.Format("LAST_NAME LIKE '%{0}%'", txt_InPa_Search_Tab2.Text);
                        dataGridView1_Tab2.DataSource = DVSearch;
                    }
                    else if (cmb_InPa_Search_Tab2.Text == "Ward Name")
                    {
                        DVSearch.RowFilter = string.Format("WARD_NAME LIKE '%{0}%'", txt_InPa_Search_Tab2.Text);
                        dataGridView1_Tab2.DataSource = DVSearch;
                    }
                    else if (cmb_InPa_Search_Tab2.Text == "Room No")
                    {
                        DVSearch.RowFilter = string.Format("ROOM_NO LIKE '%{0}%'", txt_InPa_Search_Tab2.Text);
                        dataGridView1_Tab2.DataSource = DVSearch;
                    }
                    else if (cmb_InPa_Search_Tab2.Text == "Bed No")
                    {
                        DVSearch.RowFilter = string.Format("BED_NO LIKE '%{0}%'", txt_InPa_Search_Tab2.Text);
                        dataGridView1_Tab2.DataSource = DVSearch;
                    }
                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                this.txt_InPa_Search_Tab2.Text = "";
                this.cmb_InPa_Search_Tab2.Text = "";
                myConn.Close();
            }
        }

        private void dataGridView1_Tab2_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                this.txt_InPa_ID_Tab2.Text = dataGridView1_Tab2.SelectedRows[0].Cells[0].Value.ToString();

                this.cmb_InPa_title_Tab2.Text = dataGridView1_Tab2.SelectedRows[0].Cells[1].Value.ToString();

                this.txt_InPa_FName_Tab2.Text = dataGridView1_Tab2.SelectedRows[0].Cells[2].Value.ToString();

                this.txt_InPa_MName_Tab2.Text = dataGridView1_Tab2.SelectedRows[0].Cells[3].Value.ToString();

                this.txt_InPa_LName_Tab2.Text = dataGridView1_Tab2.SelectedRows[0].Cells[4].Value.ToString();

                this.txt_InPa_WardID_Tab2.Text = dataGridView1_Tab2.SelectedRows[0].Cells[5].Value.ToString();

                this.txt_InPa_WardName_Tab2.Text = dataGridView1_Tab2.SelectedRows[0].Cells[6].Value.ToString();

                this.cmb_InPa_Floor_Tab2.Text = dataGridView1_Tab2.SelectedRows[0].Cells[7].Value.ToString();

                this.txt_InPa_RoomNo_Tab2.Text = dataGridView1_Tab2.SelectedRows[0].Cells[8].Value.ToString();

                this.txt_InPa_BedNo_Tab2.Text = dataGridView1_Tab2.SelectedRows[0].Cells[9].Value.ToString();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btn_Clear_Tab2_Click(object sender, EventArgs e)
        {
            this.txt_InPa_ID_Tab2.Text = "";
            this.cmb_InPa_title_Tab2.SelectedIndex = -1;

            this.txt_InPa_FName_Tab2.Text = "";
            this.txt_InPa_MName_Tab2.Text = "";
            this.txt_InPa_LName_Tab2.Text = "";
            this.txt_InPa_WardID_Tab2.Text = "";
            this.txt_InPa_WardName_Tab2.Text = "";
            this.cmb_InPa_Floor_Tab2.SelectedIndex = -1;
            this.txt_InPa_RoomNo_Tab2.Text = "";
            this.txt_InPa_BedNo_Tab2.Text = "";
        }

        private void btn_Refresh_Tab2_Click(object sender, EventArgs e)
        {
            auto_load_datagrid_Tab2();
        }

        private void cmb_InPa_Search_Tab2_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void btn_Transfer_InPa_Click(object sender, EventArgs e)
        {
            if (txt_InPa_ID_Tab2.Text == "" || txt_InPa_FName_Tab2.Text == "" || txt_InPa_LName_Tab2.Text == "" || txt_InPa_BedNo_Tab2.Text == "")
            {
                MessageBox.Show("Select a Patient to Transfer the Room", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                this.Hide();
                In_Patient_Transfer_Form f_sub = new In_Patient_Transfer_Form(txt_InPa_ID_Tab2.Text, txt_InPa_FName_Tab2.Text, txt_InPa_LName_Tab2.Text, txt_InPa_RoomNo_Tab2.Text, txt_InPa_BedNo_Tab2.Text);
                f_sub.ShowDialog();
            }

        }


        /*
         * ///////////////////////////////////////////////
         * 3rd TAB
         * Manage In Patient File
         * content
         * Start
         * //////////////////////////////////////////////
         */





        private void btn_Search_ManageFl_Tab3_Click(object sender, EventArgs e)
        {
            MySqlConnection myConn = new MySqlConnection(myConnection);

            DataView DVSearch = new DataView(dbDataset);

            if (txt_Search_ManageFl_Tab3.Text == "")
            {
                MessageBox.Show("Please Input data to Search", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            else
            {
                try
                {
                    myConn.Open();
                    string Get_Pa_Details_Query = "SELECT * FROM itp.in_patient WHERE patient_id='" + txt_Search_ManageFl_Tab3.Text + "'; ";
                    MySqlCommand cmd1 = new MySqlCommand(Get_Pa_Details_Query, myConn);
                    MySqlDataReader myReader1;

                    myReader1 = cmd1.ExecuteReader();

                    while (myReader1.Read())
                    {
                        string paID = myReader1.GetString("patient_id");
                        string paFirstName = myReader1.GetString("first_name");
                        string paLastName = myReader1.GetString("last_name");
                        string pagender = myReader1.GetString("gender");

                        this.txt_PaID_ManageFl_Tab3.Text = paID;
                        this.txt_FName_ManageFl_Tab3.Text = paFirstName;
                        this.txt_LName_ManageFl_Tab3.Text = paLastName;
                        this.txt_gender_ManageFl_Tab3.Text = pagender;
                    }
                    myConn.Close();

                    myConn.Open();
                    string Get_Room_Details_Query = "SELECT * FROM itp.assign_patient_to_bed WHERE patient_id='" + txt_Search_ManageFl_Tab3.Text + "'; ";
                    MySqlCommand cmd2 = new MySqlCommand(Get_Room_Details_Query, myConn);
                    MySqlDataReader myReader2;

                    myReader2 = cmd2.ExecuteReader();

                    while (myReader2.Read())
                    {
                        string RoomNo = myReader2.GetString("room_no");
                        string BedNo = myReader2.GetString("bed_no");

                        this.txt_RoomNo_ManageFl_Tab3.Text = RoomNo;
                        this.txt_BedNo_ManageFl_Tab3.Text = BedNo;
                    }
                    myConn.Close();


                    myConn.Open();
                    string Get_Ward_Query = "SELECT * FROM itp.room_details r, itp.ward_category w WHERE w.ward_id=r.ward_id AND room_no='" + txt_RoomNo_ManageFl_Tab3.Text + "'; ";
                    MySqlCommand cmd3 = new MySqlCommand(Get_Ward_Query, myConn);
                    MySqlDataReader myReader3;

                    myReader3 = cmd3.ExecuteReader();

                    while (myReader3.Read())
                    {
                        string wName = myReader3.GetString("ward_name");

                        this.txt_WardName_ManageFl_Tab3.Text = wName;
                    }
                    myConn.Close();


                    myConn.Open();
                    string Get_File_ID_Query = "SELECT * FROM itp.file_in_patient WHERE patient_id='" + txt_PaID_ManageFl_Tab3.Text + "'; ";
                    MySqlCommand cmd4 = new MySqlCommand(Get_File_ID_Query, myConn);
                    MySqlDataReader myReader4;

                    myReader4 = cmd4.ExecuteReader();

                    while (myReader4.Read())
                    {
                        string fID = myReader4.GetString("file_id");

                        this.txt_FileID_ManageFl_Tab3.Text = fID;
                    }
                    myConn.Close();

                    load_datagrid_Condition_Tab3();



                    myConn.Open();
                    string Get_History_Query = "SELECT * FROM itp.file_sub_history WHERE file_id='" + txt_FileID_ManageFl_Tab3.Text + "'; ";
                    MySqlCommand cmd5 = new MySqlCommand(Get_History_Query, myConn);
                    MySqlDataReader myReader5;

                    myReader5 = cmd5.ExecuteReader();

                    while (myReader5.Read())
                    {
                        string Pa_history = myReader5.GetString("history_patient");
                        string Fam_history = myReader5.GetString("history_family");

                        this.richTextBox1_Pa_History.Text = Pa_history;
                        this.richTextBox_Fam_History.Text = Fam_history;
                    }
                    txt_Search_ManageFl_Tab3.Text = "";
                    myConn.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                this.txt_SearchKeyWord_InPa.Text = "";
            }
        }


        private void load_datagrid_Condition_Tab3()
        {
            MySqlConnection myConn = new MySqlConnection(myConnection);
            myConn.Open();

            try
            {
                string loadDataGridQuery = "SELECT current_date_to_enter as 'DATE', current_condition 'CONDITION' FROM itp.file_sub_current_condition WHERE file_id='" + txt_FileID_ManageFl_Tab3.Text + "';";
                MySqlCommand cmd = new MySqlCommand(loadDataGridQuery, myConn);

                MySqlDataAdapter sda = new MySqlDataAdapter();
                sda.SelectCommand = cmd;
                dbDataset = new DataTable();
                sda.Fill(dbDataset);
                BindingSource bSource = new BindingSource();

                bSource.DataSource = dbDataset;
                dataGridView1_ManageFl_Tab3.DataSource = bSource;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            myConn.Close();
        }


        private void btn_Update_History_ManageFl_Tab3_Click(object sender, EventArgs e)
        {
            MySqlConnection myConn = new MySqlConnection(myConnection);


            try
            {
                myConn.Open();

                string insert_Pa_history_Query = "insert into itp.file_sub_history (file_id,history_patient,history_family) values('" + this.txt_FileID_ManageFl_Tab3.Text + "','" + this.richTextBox1_Pa_History.Text + "','" + this.richTextBox_Fam_History.Text + "');";
                MySqlCommand cmd = new MySqlCommand(insert_Pa_history_Query, myConn);
                MySqlDataReader myReader;

                myReader = cmd.ExecuteReader();
                MessageBox.Show("History Saved Successfully !!", "Successful Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.richTextBox1_Pa_History.Enabled = false;
                this.richTextBox_Fam_History.Enabled = false;

                while (myReader.Read())
                {

                }
                myConn.Close();
                Show_in_richText();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "SError Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btn_clickToEdit_Pa_Histo_Tab3_Click(object sender, EventArgs e)
        {
            richTextBox1_Pa_History.Enabled = true;
        }

        private void btn_clickToEdit_Fam_Histo_Tab3_Click(object sender, EventArgs e)
        {
            richTextBox_Fam_History.Enabled = true;
        }

        private void cmb_condition_tab3_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void btn_clickToEdit_condition_Tab3_Click(object sender, EventArgs e)
        {
            this.cmb_condition_tab3.Enabled = true;
        }

        private void btn_Update_Condition_ManageFl_Tab3_Click(object sender, EventArgs e)
        {
            MySqlConnection myConn = new MySqlConnection(myConnection);
            myConn.Open();

            int state;

            if (cmb_condition_tab3.Text == "")
            {
                MessageBox.Show("Please Fill Empty Fields", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            else
            {
                try
                {
                    
                    if(cmb_condition_tab3.Text=="Good")
                    {
                        state = 50;
                    }
                    else if(cmb_condition_tab3.Text== "Processing Well")
                    {
                        state = 40;
                    }
                    else if(cmb_condition_tab3.Text== "Fair")
                    {
                        state = 30;
                    }
                    else if(cmb_condition_tab3.Text== "Serious")
                    {
                        state = 20;
                    }
                    else
                    {
                        state = 10;
                    }
                    

                    string save_condition_Query = "insert into itp.file_sub_current_condition (file_id,current_date_to_enter,current_condition,state) values('"+this.txt_FileID_ManageFl_Tab3.Text+"','"+this.dateTimePicker1_tab3.Text+"','"+this.cmb_condition_tab3.Text+"','"+state+"');";

                    MySqlCommand cmd = new MySqlCommand(save_condition_Query, myConn);
                    MySqlDataReader myReader;

                    myReader = cmd.ExecuteReader();
                    MessageBox.Show("Record Saved Successfully !!", "Successful Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    this.cmb_condition_tab3.Enabled = false;

                    while (myReader.Read())
                    {

                    }
                    myConn.Close();
                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "SError Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                load_datagrid_Condition_Tab3();
            }
        }

        private void btn_Cancel_History_ManageFl_Tab3_Click(object sender, EventArgs e)
        {
            this.richTextBox1_Pa_History.Enabled = false;
            this.richTextBox_Fam_History.Enabled = false;

            Show_in_richText();
        }

        private void btn_cancel_Condition_ManageFl_Tab3_Click(object sender, EventArgs e)
        {
            this.cmb_condition_tab3.Enabled = false;
            load_datagrid_Condition_Tab3();
        }

        void Show_in_richText()
        {
            MySqlConnection myConn = new MySqlConnection(myConnection);

            try
            {
                myConn.Open();
                string get_Details_from_Query = "SELECT * FROM itp.file_sub_history WHERE file_id='" + this.txt_FileID_ManageFl_Tab3 + "';";
                MySqlCommand cmd1 = new MySqlCommand(get_Details_from_Query, myConn);
                MySqlDataReader myReader1;

                myReader1 = cmd1.ExecuteReader();

                while (myReader1.Read())
                {
                    string Pa_history = myReader1.GetString("history_patient");
                    string Fam_history = myReader1.GetString("history_family");

                    this.richTextBox1_Pa_History.Text = Pa_history;
                    this.richTextBox_Fam_History.Text = Fam_history;

                    load_datagrid_Condition_Tab3();
                }

                myConn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        private void cmb_Search_ManageFl_Tab3_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void btn_clearAll_tab3_Click(object sender, EventArgs e)
        {
            this.txt_Search_ManageFl_Tab3.Text = "";
            this.txt_PaID_ManageFl_Tab3.Text = "";
            this.txt_FName_ManageFl_Tab3.Text = "";
            this.txt_LName_ManageFl_Tab3.Text = "";
            this.txt_gender_ManageFl_Tab3.Text = "";
            this.txt_WardName_ManageFl_Tab3.Text = "";
            this.txt_RoomNo_ManageFl_Tab3.Text = "";
            this.txt_BedNo_ManageFl_Tab3.Text = "";
            this.txt_FileID_ManageFl_Tab3.Text = "";
            this.richTextBox1_Pa_History.Text = "";
            this.richTextBox_Fam_History.Text = "";
            this.cmb_condition_tab3.SelectedIndex = -1;
            this.load_datagrid_Condition_Tab3();

        }







        /*
         * ///////////////////////////////////////////////
         * 4th TAB
         * Manage Medical Side
         * content
         * Start
         * //////////////////////////////////////////////
         */



        private void btn_Search_Manag_Medi_Tab4_Click(object sender, EventArgs e)
        {
            MySqlConnection myConn = new MySqlConnection(myConnection);

            DataView DVSearch = new DataView(dbDataset);

            if (txt_Search_Manag_Medi_Tab4.Text == "")
            {
                MessageBox.Show("Please Input data to Search", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            else
            {
                try
                {
                    myConn.Open();
                    string Get_Pa_Details_Query = "SELECT * FROM itp.in_patient WHERE patient_id='" + txt_Search_Manag_Medi_Tab4.Text + "'; ";
                    MySqlCommand cmd1 = new MySqlCommand(Get_Pa_Details_Query, myConn);
                    MySqlDataReader myReader1;

                    myReader1 = cmd1.ExecuteReader();

                    while (myReader1.Read())
                    {
                        string paID = myReader1.GetString("patient_id");
                        string paFirstName = myReader1.GetString("first_name");
                        string paLastName = myReader1.GetString("last_name");
                        string pagender = myReader1.GetString("gender");

                        this.txt_PaID_Manag_Medi_Tab4.Text = paID;
                        this.txt_Fname_Manag_Medi_Tab4.Text = paFirstName;
                        this.txt_Lname_Manag_Medi_Tab4.Text = paLastName;
                        this.txt_gender_Manag_Medi_Tab4.Text = pagender;
                    }
                    myConn.Close();

                    myConn.Open();
                    string Get_Room_Details_Query = "SELECT * FROM itp.assign_patient_to_bed WHERE patient_id='" + txt_Search_Manag_Medi_Tab4.Text + "'; ";
                    MySqlCommand cmd2 = new MySqlCommand(Get_Room_Details_Query, myConn);
                    MySqlDataReader myReader2;

                    myReader2 = cmd2.ExecuteReader();

                    while (myReader2.Read())
                    {
                        string RoomNo = myReader2.GetString("room_no");
                        string BedNo = myReader2.GetString("bed_no");

                        this.txt_RoomNo_Manag_Medi_Tab4.Text = RoomNo;
                        this.txt_BedNo_Manag_Medi_Tab4.Text = BedNo;
                    }
                    myConn.Close();


                    myConn.Open();
                    string Get_Ward_Query = "SELECT * FROM itp.room_details r, itp.ward_category w WHERE w.ward_id=r.ward_id AND room_no='" + txt_RoomNo_Manag_Medi_Tab4.Text + "'; ";
                    MySqlCommand cmd3 = new MySqlCommand(Get_Ward_Query, myConn);
                    MySqlDataReader myReader3;

                    myReader3 = cmd3.ExecuteReader();

                    while (myReader3.Read())
                    {
                        string wName = myReader3.GetString("ward_name");

                        this.txt_WardName_Manag_Medi_Tab4.Text = wName;
                    }
                    myConn.Close();


                    myConn.Open();
                    string Get_File_ID_Query = "SELECT * FROM itp.file_in_patient WHERE patient_id='" + txt_PaID_Manag_Medi_Tab4.Text + "'; ";
                    MySqlCommand cmd4 = new MySqlCommand(Get_File_ID_Query, myConn);
                    MySqlDataReader myReader4;

                    myReader4 = cmd4.ExecuteReader();

                    while (myReader4.Read())
                    {
                        string fID = myReader4.GetString("file_id");

                        this.txt_FileID_Manag_Medi_Tab4.Text = fID;
                    }
                    myConn.Close();

                    load_datagrid_Drug_Tab4();
                    load_datagrid_Test_Tab4();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                this.txt_Search_Manag_Medi_Tab4.Text = "";
            }
        }

        private void load_datagrid_Drug_Tab4()
        {
            MySqlConnection myConn = new MySqlConnection(myConnection);
            myConn.Open();

            try
            {
                string loadData_Drugs_GridQuery = "SELECT current_date_to_enter as 'DATE', drug_name as 'DRUG_NAME', times_per_day as 'TIMES_PER_DAY', checked as 'CHECK' from itp.file_sub_drugs_to_give WHERE file_id='" + txt_FileID_Manag_Medi_Tab4.Text + "';";
                MySqlCommand cmd = new MySqlCommand(loadData_Drugs_GridQuery, myConn);

                MySqlDataAdapter sda = new MySqlDataAdapter();
                sda.SelectCommand = cmd;
                dbDataset = new DataTable();
                sda.Fill(dbDataset);
                BindingSource bSource = new BindingSource();

                bSource.DataSource = dbDataset;
                dataGridView1_Manag_Medi_Tab4.DataSource = bSource;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            myConn.Close();
        }


        private void load_datagrid_Test_Tab4()
        {
            MySqlConnection myConn = new MySqlConnection(myConnection);
            myConn.Open();

            try
            {
                string loadDataGridQuery = "SELECT current_date as 'DATE', test_name as 'TEST_NAME', checked as 'CHECK' from itp.file_sub_tests WHERE file_id='" + txt_FileID_Manag_Medi_Tab4.Text + "';";
                MySqlCommand cmd = new MySqlCommand(loadDataGridQuery, myConn);

                MySqlDataAdapter sda = new MySqlDataAdapter();
                sda.SelectCommand = cmd;
                dbDataset = new DataTable();
                sda.Fill(dbDataset);
                BindingSource bSource = new BindingSource();

                bSource.DataSource = dbDataset;
                dataGridView2_Manag_Medi_Tab4.DataSource = bSource;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            myConn.Close();
        }


        void FillDrugNameCombo()
        {
            MySqlConnection myConn = new MySqlConnection(myConnection);
            myConn.Open();

            string combo1Query = "select * from itp.drugs;";
            MySqlCommand cmd = new MySqlCommand(combo1Query, myConn);
            MySqlDataReader myReader;

            try
            {
                myReader = cmd.ExecuteReader();
                cmb_Drug_name_tab4.Items.Clear();


                while (myReader.Read())
                {
                    string dName = myReader.GetString("drug_name");
                    cmb_Drug_name_tab4.Items.Add(dName);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            myConn.Close();
        }

        private void btn_clickToEdit_Drugs_Tab4_Click(object sender, EventArgs e)
        {
            FillDrugNameCombo();
            this.cmb_Drug_name_tab4.Enabled = true;
            this.txt_timesPerDay_tab4.Enabled = true;
            this.cmb_Drug_check_tab4.Enabled = true;
        }

        private void btn_clickToEdit_Tests_Tab4_Click(object sender, EventArgs e)
        {
            this.txt_Test_name_tab4.Enabled = true;
            this.cmb_test_check_tab4.Enabled = true;
        }

        private void btn_Update_Drug_Manag_Medi_Tab4_Click(object sender, EventArgs e)
        {
            MySqlConnection myConn = new MySqlConnection(myConnection);
            myConn.Open();

            if (cmb_Drug_name_tab4.Text == "" || txt_timesPerDay_tab4.Text == "" || cmb_Drug_check_tab4.Text == "")
            {
                MessageBox.Show("Please Fill Empty Fields", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            else
            {
                try
                {
                    string save_drug_Query = "insert into itp.file_sub_drugs_to_give (file_id,current_date_to_enter,drug_name,times_per_day,checked) values('" + this.txt_FileID_Manag_Medi_Tab4.Text + "','" + this.dateTimePicker1_tab4.Text + "','" + this.cmb_Drug_name_tab4.Text + "','" + txt_timesPerDay_tab4.Text + "','" + cmb_Drug_check_tab4.Text + "');";
                    MySqlCommand cmd = new MySqlCommand(save_drug_Query, myConn);
                    MySqlDataReader myReader;

                    myReader = cmd.ExecuteReader();
                    MessageBox.Show("Record Saved Successfully !!", "Successful Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    load_datagrid_Test_Tab4();
                    cmb_Drug_name_tab4.Text = "";
                    txt_timesPerDay_tab4.Text = "";
                    cmb_Drug_check_tab4.Text = "";

                    this.cmb_Drug_name_tab4.Enabled = false;
                    this.txt_timesPerDay_tab4.Enabled = false;
                    this.cmb_Drug_check_tab4.Enabled = false;

                    while (myReader.Read())
                    {

                    }
                    myConn.Close();
                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "SError Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                load_datagrid_Drug_Tab4();
            }
        }

        private void btn_Cancel_Drug_Manag_Medi_Tab4_Click(object sender, EventArgs e)
        {
            load_datagrid_Test_Tab4();
            cmb_Drug_name_tab4.Text = "";
            txt_timesPerDay_tab4.Text = "";
            cmb_Drug_check_tab4.Text = "";

            this.cmb_Drug_name_tab4.Enabled = false;
            this.txt_timesPerDay_tab4.Enabled = false;
            this.cmb_Drug_check_tab4.Enabled = false;
            load_datagrid_Drug_Tab4();
        }

        private void btn_Update_Test_Manag_Medi_Tab4_Click(object sender, EventArgs e)
        {
            MySqlConnection myConn = new MySqlConnection(myConnection);
            myConn.Open();

            if (txt_Test_name_tab4.Text == "" || cmb_test_check_tab4.Text == "")
            {
                MessageBox.Show("Please Fill Empty Fields", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            else
            {
                try
                {
                    string save_test_Query = "insert into itp.file_sub_tests (file_id,current_date_to_enter,test_name,checked) values('" + this.txt_FileID_Manag_Medi_Tab4.Text + "','" + this.dateTimePicker1_tab4.Text + "','" + this.txt_Test_name_tab4.Text + "','" + cmb_test_check_tab4.Text + "');";
                    MySqlCommand cmd = new MySqlCommand(save_test_Query, myConn);
                    MySqlDataReader myReader;

                    myReader = cmd.ExecuteReader();
                    MessageBox.Show("Record Saved Successfully !!", "Successful Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    txt_Test_name_tab4.Text = "";
                    cmb_test_check_tab4.Text = "";

                    this.txt_Test_name_tab4.Enabled = false;
                    this.cmb_test_check_tab4.Enabled = false;

                    while (myReader.Read())
                    {

                    }
                    myConn.Close();
                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "SError Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                load_datagrid_Test_Tab4();
            }
        }

        private void btn_Cancel_Test_Manag_Medi_Tab4_Click(object sender, EventArgs e)
        {
            txt_Test_name_tab4.Text = "";
            cmb_test_check_tab4.Text = "";

            this.txt_Test_name_tab4.Enabled = false;
            this.cmb_test_check_tab4.Enabled = false;
            load_datagrid_Test_Tab4();

        }

        private void cmb_Search_Manag_Medi_Tab4_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void cmb_Drug_name_tab4_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void txt_timesPerDay_tab4_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar) || e.KeyChar == 8 || e.KeyChar == 46) //8=backspace 46=del
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void cmb_Drug_check_tab4_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void cmb_test_check_tab4_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void txt_Test_name_tab4_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) || e.KeyChar == 8 || e.KeyChar == 46 || e.KeyChar == '_' || e.KeyChar == '&' || e.KeyChar == '-' || e.KeyChar == ' ') //8=backspace 46=del
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void btn_clearAll_Tab4_Click(object sender, EventArgs e)
        {
            this.txt_Search_Manag_Medi_Tab4.Text = "";
            this.txt_PaID_Manag_Medi_Tab4.Text = "";
            this.txt_Fname_Manag_Medi_Tab4.Text = "";
            this.txt_Lname_Manag_Medi_Tab4.Text = "";
            this.txt_gender_Manag_Medi_Tab4.Text = "";
            this.txt_WardName_Manag_Medi_Tab4.Text = "";
            this.txt_RoomNo_Manag_Medi_Tab4.Text = "";
            this.txt_BedNo_Manag_Medi_Tab4.Text = "";
            this.txt_FileID_Manag_Medi_Tab4.Text = "";
            this.cmb_Drug_name_tab4.SelectedIndex = -1; ;
            this.txt_timesPerDay_tab4.Text = "";
            this.cmb_Drug_check_tab4.SelectedIndex = -1;
            this.txt_Test_name_tab4.Text = "";
            this.cmb_test_check_tab4.SelectedIndex = -1;

            this.load_datagrid_Drug_Tab4();
            this.load_datagrid_Test_Tab4();
        }






        /*
         * ///////////////////////////////////////////////
         * 5th TAB
         * Print Documents
         * content
         * Start
         * //////////////////////////////////////////////
         */



        private void btn_Search_PrintDoc_Tab5_Click(object sender, EventArgs e)
        {
            MySqlConnection myConn = new MySqlConnection(myConnection);

            DataView DVSearch = new DataView(dbDataset);

            if (txt_Search_PrintDoc_Tab5.Text == "")
            {
                MessageBox.Show("Please Input data to Search", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            else
            {
                try
                {
                    myConn.Open();
                    string Get_Pa_Details_Query = "SELECT * FROM itp.in_patient WHERE patient_id='" + txt_Search_PrintDoc_Tab5.Text + "'; ";
                    MySqlCommand cmd1 = new MySqlCommand(Get_Pa_Details_Query, myConn);
                    MySqlDataReader myReader1;

                    myReader1 = cmd1.ExecuteReader();

                    while (myReader1.Read())
                    {
                        string paID = myReader1.GetString("patient_id");
                        string paFirstName = myReader1.GetString("first_name");
                        string paLastName = myReader1.GetString("last_name");
                        string pagender = myReader1.GetString("gender");

                        this.txt_PaID_PrintDoc_Tab5.Text = paID;
                        this.txt_FName_PrintDoc_Tab5.Text = paFirstName;
                        this.txt_LName_PrintDoc_Tab5.Text = paLastName;
                        this.txt_gender_PrintDoc_Tab5.Text = pagender;
                    }
                    myConn.Close();

                    myConn.Open();
                    string Get_Room_Details_Query = "SELECT * FROM itp.assign_patient_to_bed WHERE patient_id='" + txt_Search_PrintDoc_Tab5.Text + "'; ";
                    MySqlCommand cmd2 = new MySqlCommand(Get_Room_Details_Query, myConn);
                    MySqlDataReader myReader2;

                    myReader2 = cmd2.ExecuteReader();

                    while (myReader2.Read())
                    {
                        string RoomNo = myReader2.GetString("room_no");
                        string BedNo = myReader2.GetString("bed_no");

                        this.txt_RoomNo_PrintDoc_Tab5.Text = RoomNo;
                        this.txt_BedNo_PrintDoc_Tab5.Text = BedNo;
                    }
                    myConn.Close();


                    myConn.Open();
                    string Get_Ward_Query = "SELECT * FROM itp.room_details r, itp.ward_category w WHERE w.ward_id=r.ward_id AND room_no='" + txt_RoomNo_PrintDoc_Tab5.Text + "'; ";
                    MySqlCommand cmd3 = new MySqlCommand(Get_Ward_Query, myConn);
                    MySqlDataReader myReader3;

                    myReader3 = cmd3.ExecuteReader();

                    while (myReader3.Read())
                    {
                        string wName = myReader3.GetString("ward_name");

                        this.txt_WardName_PrintDoc_Tab5.Text = wName;
                    }
                    myConn.Close();


                    myConn.Open();
                    string Get_File_ID_Query = "SELECT * FROM itp.file_in_patient WHERE patient_id='" + txt_PaID_PrintDoc_Tab5.Text + "'; ";
                    MySqlCommand cmd4 = new MySqlCommand(Get_File_ID_Query, myConn);
                    MySqlDataReader myReader4;

                    myReader4 = cmd4.ExecuteReader();

                    while (myReader4.Read())
                    {
                        string fID = myReader4.GetString("file_id");

                        this.txt_FileID_PrintDoc_Tab5.Text = fID;
                    }
                    myConn.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                this.txt_Search_PrintDoc_Tab5.Text = "";
            }
        }

        private void cmb_Search_PrintDoc_Tab5_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void btn_Print_PaDoc_Tab5_Click(object sender, EventArgs e)
        {
            //Print
        }

        private void btn_Print_Full_Tab5_Click(object sender, EventArgs e)
        {
            //print
        }

        private void btn_clearAll_Tab5_Click(object sender, EventArgs e)
        {
            this.txt_Search_PrintDoc_Tab5.Text = "";
            this.txt_PaID_PrintDoc_Tab5.Text = "";
            this.txt_FName_PrintDoc_Tab5.Text = "";
            this.txt_LName_PrintDoc_Tab5.Text = "";
            this.txt_gender_PrintDoc_Tab5.Text = "";
            this.txt_WardName_PrintDoc_Tab5.Text = "";
            this.txt_RoomNo_PrintDoc_Tab5.Text = "";
            this.txt_BedNo_PrintDoc_Tab5.Text = "";
            this.txt_FileID_PrintDoc_Tab5.Text = "";

        }




        /*
         * ///////////////////////////////////////////////
         * 6th TAB
         * Discharge
         * content
         * Start
         * //////////////////////////////////////////////
         */


        private void btn_Search_Discharge_Tab6_Click(object sender, EventArgs e)
        {
            MySqlConnection myConn = new MySqlConnection(myConnection);

            DataView DVSearch = new DataView(dbDataset);

            if (txt_Search_Discharge_Tab6.Text == "")
            {
                MessageBox.Show("Please Input data to Search", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                try
                {
                    load_datagrid_Discharge_byID_Tab6();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                txt_Search_Discharge_Tab6.Text = "";
            }

        }


        private void load_datagrid_Discharge_byID_Tab6()
        {
            MySqlConnection myConn = new MySqlConnection(myConnection);
            myConn.Open();

            try
            {
                string autoload_Tab6_Query = "SELECT i.patient_id as 'PA_ID', i.first_name as 'FIRST_NAME', i.last_name as 'LAST_NAME', i.nic as 'NIC', i.gender as 'GENDER', i.age as 'AGE', i.contact_number as 'CONTACT_NUMBER', w.ward_name as 'WARD_NAME', w.floor as 'FLOOR', a.room_no as 'ROOM_NO', a.bed_no as 'BED_NO', c.type as 'CLASS_TYPE' from itp.ward_category w, itp.room_details r, itp.bed_details b, itp.in_patient i, itp.assign_patient_to_bed a, itp.class_type c WHERE w.ward_id=r.ward_id AND r.room_no=b.room_no AND b.room_no=a.room_no AND b.bed_no=a.bed_no AND i.patient_id=a.patient_id AND c.type=r.type AND i.patient_id='" + txt_Search_Discharge_Tab6.Text + "'; ";
                MySqlCommand cmd = new MySqlCommand(autoload_Tab6_Query, myConn);

                MySqlDataAdapter sda = new MySqlDataAdapter();
                sda.SelectCommand = cmd;
                dbDataset = new DataTable();
                sda.Fill(dbDataset);
                BindingSource bSource = new BindingSource();

                bSource.DataSource = dbDataset;
                dataGridView1_Discharge_Tab6.DataSource = bSource;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            myConn.Close();
        }

        private void btn_clearAll_Tab6_Click(object sender, EventArgs e)
        {
            txt_Search_Discharge_Tab6.Text = "";
        }
    }
}
