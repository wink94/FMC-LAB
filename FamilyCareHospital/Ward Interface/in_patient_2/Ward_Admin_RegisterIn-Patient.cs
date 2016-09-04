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
using System.Text.RegularExpressions; //for searchSum function

namespace FamilyCareHospital
{
    public partial class Ward_Admin_RegisterIn_Patient : Form
    {
        public Ward_Admin_RegisterIn_Patient()
        {
            InitializeComponent();

            // 1st TAB
            AutoGenerateInPatientID();
            load_datagrid_Tab1();

            //2nd TAB
            FillWardNameCombo();
        }


        static string myConnection = "Data Source=localhost; Initial Catalog=itp; port=3306; username=root; password=sagarox";
        //static MySqlConnection myConn = new MySqlConnection(myConnection);



        /*
         * //////////////////////////////////
         * 1st TAB
         * Add New Patient
         * content
         * Start
         * ////////////////////////////////
         */



        string InPatientLetter = "IP_";
        DataTable dbDataset;
        string gender;
        string Gua_gender;

        private void AutoGenerateInPatientID()
        {
            MySqlConnection myConn = new MySqlConnection(myConnection);
            myConn.Open();

            try
            {
                string autogenerateInPaQuery = "Select Count(patient_id) from itp.in_patient;";
                MySqlCommand cmd = new MySqlCommand(autogenerateInPaQuery, myConn);
                int i = Convert.ToInt32(cmd.ExecuteScalar());
                int j;

                if (i == 0)
                {
                    i = i + 1;
                    j = i + 100;

                    this.txt_Pa_ID_Tab1.Text = InPatientLetter+j.ToString();
                    this.txt_Pa_ID_Tab3.Text = InPatientLetter + j.ToString();
                }
                else
                {
                    string lastPaIDQuery = "SELECT patient_id FROM itp.in_patient order by patient_id desc limit 1;";
                    MySqlCommand cmd1 = new MySqlCommand(lastPaIDQuery, myConn);

                    string value = (string)cmd1.ExecuteScalar();
                    string s = SearchNum(value);

                    int k = Convert.ToInt32(s);
                    k = k + 1;

                    this.txt_Pa_ID_Tab1.Text = InPatientLetter+k.ToString();
                    this.txt_Pa_ID_Tab3.Text = InPatientLetter + k.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            myConn.Close();
        }


        private string SearchNum(string st)
        {
            return string.Join("\n", Regex.Split(st, "[^\\d]"));
        }

        private void radioButton1_Pa_genderMale_Tab1_CheckedChanged(object sender, EventArgs e)
        {
            gender = "Male";
        }

        private void radioButton2_Pa_genderFemale_Tab1_CheckedChanged(object sender, EventArgs e)
        {
            gender = "Female";
        }

        private void radioButton4_Gua_genderMale_Tab1_CheckedChanged(object sender, EventArgs e)
        {
            Gua_gender = "Male";
        }

        private void radioButton3_Gua_genderFemale_Tab1_CheckedChanged(object sender, EventArgs e)
        {
            Gua_gender = "Female";
        }


        private void dateTimePicker_Pa_DOB_Tab1_ValueChanged(object sender, EventArgs e)
        {
            TimeSpan age = DateTime.Now - dateTimePicker_Pa_DOB_Tab1.Value;
            int years = DateTime.Now.Year - dateTimePicker_Pa_DOB_Tab1.Value.Year;
            if (dateTimePicker_Pa_DOB_Tab1.Value.AddYears(years) > DateTime.Now) years--;
            this.txt_Pa_age_Tab1.Text = years.ToString();
        }


        private void load_datagrid_Tab1()
        {
            MySqlConnection myConn = new MySqlConnection(myConnection);
            myConn.Open();

            try
            {
                string loadDataGridTab1Query = "SELECT i.patient_id as 'PA_ID', i.title as 'TITLE', i.first_name as 'FIRST_NAME', i.last_name as 'LAST_NAME', w.ward_name as 'WARD_NAME', w.floor as 'FLOOR', a.room_no as 'ROOM_NO', a.bed_no as 'BED_NO' from itp.ward_category w, itp.room_details r, itp.bed_details b, itp.in_patient i, itp.assign_patient_to_bed a WHERE w.ward_id=r.ward_id AND r.room_no=b.room_no AND b.room_no=a.room_no AND b.bed_no=a.bed_no AND i.patient_id=a.patient_id;";
                MySqlCommand cmd = new MySqlCommand(loadDataGridTab1Query, myConn);

                MySqlDataAdapter sda = new MySqlDataAdapter();
                sda.SelectCommand = cmd;
                dbDataset = new DataTable();
                sda.Fill(dbDataset);
                BindingSource bSource = new BindingSource();

                bSource.DataSource = dbDataset;
                dataGridView1_RegisterInPatient_Tab1.DataSource = bSource;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            myConn.Close();
        }

        private void btnRefresh_Tab1_Click(object sender, EventArgs e)
        {
            load_datagrid_Tab1();
        }


        private void btnClear_Content_Tab1_Click(object sender, EventArgs e)
        {
            //in Patient
            AutoGenerateInPatientID();
            this.cmb_Pa_title_Tab1.SelectedIndex = -1;
            this.txt_Pa_FName_Tab1.Text = "";
            this.txt_Pa_MName_Tab1.Text = "";
            this.txt_Pa_LName_Tab1.Text = "";
            this.txt_Pa_NIC_Tab1.Text = "";
            this.radioButton1_Pa_genderMale_Tab1.Checked = false;
            this.radioButton2_Pa_genderFemale_Tab1.Checked = false;
            this.dateTimePicker_Pa_DOB_Tab1.Value = DateTime.Now;
            this.txt_Pa_age_Tab1.Text = "";
            this.cmb_Pa_civilStatus_Tab1.SelectedIndex = -1;
            this.txt_Pa_phone_Tab1.Text = "";
            this.txt_Pa_diagnosis_Tab1.Text = "";
            this.cmb_Pa_BloodGrp_Tab1.SelectedIndex = -1;
            this.dateTimePicker_Pa_DateAdmit_Tab1.Value = DateTime.Now;

            //guardian
            this.cmb_Gua_title_Tab1.SelectedIndex = -1;
            this.txt_Gua_name_Tab1.Text = "";
            this.txt_Gua_NIC_Tab1.Text = "";
            this.radioButton4_Gua_genderMale_Tab1.Checked = false;
            this.radioButton3_Gua_genderFemale_Tab1.Checked = false;
            this.txt_Gua_age_Tab1.Text = "";
            this.txt_Gua_relationship_Tab1.Text = "";
            this.txt_Gua_add1_Tab1.Text = "";
            this.txt_Gua_add2_Tab1.Text = "";
            this.txt_Gua_city_Tab1.Text = "";
            this.txt_Gua_province_Tab1.Text = "";
            this.txt_Gua_conNumber_Tab1.Text = "";
        }


        //validating txt tab1
        private void cmb_Pa_title_Tab1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void txt_Pa_FName_Tab1_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txt_Pa_MName_Tab1_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txt_Pa_LName_Tab1_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txt_Pa_NIC_Tab1_KeyPress(object sender, KeyPressEventArgs e)
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

        private void cmb_Pa_civilStatus_Tab1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void txt_Pa_phone_Tab1_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txt_Pa_diagnosis_Tab1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) || e.KeyChar == 8 || e.KeyChar == ' ' || e.KeyChar == 46) //8=backspace 46=del
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void cmb_Pa_BloodGrp_Tab1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void cmb_Gua_title_Tab1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void txt_Gua_name_Tab1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) || e.KeyChar == 8 || e.KeyChar == ' ' || e.KeyChar == 46) //8=backspace 46=del
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void txt_Gua_NIC_Tab1_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txt_Gua_age_Tab1_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txt_Gua_relationship_Tab1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) || e.KeyChar == 8 || e.KeyChar == ' ' || e.KeyChar == 46) //8=backspace 46=del
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void txt_Gua_add1_Tab1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) || char.IsNumber(e.KeyChar) || e.KeyChar == 8 || e.KeyChar == ' ' || e.KeyChar == '/' || e.KeyChar == ',' || e.KeyChar == '.' || e.KeyChar == 46) //8=backspace 46=del
            {
                e.Handled = false;
            }          
            else
            {
                e.Handled = true;
            }
        }

        private void txt_Gua_add2_Tab1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) || e.KeyChar == 8 || e.KeyChar == ' ' || e.KeyChar == ',' || e.KeyChar == 46) //8=backspace 46=del
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void txt_Gua_city_Tab1_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txt_Gua_province_Tab1_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txt_Gua_conNumber_Tab1_KeyPress(object sender, KeyPressEventArgs e)
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






        //SAVE button common to all Tabs
        private void btnSave_Click(object sender, EventArgs e)
        {
            MySqlConnection myConn = new MySqlConnection(myConnection);

            
           if (this.txt_Pa_ID_Tab1.Text==""|| this.cmb_Pa_title_Tab1.Text == "" || this.txt_Pa_FName_Tab1.Text == "" || this.txt_Pa_MName_Tab1.Text=="" || this.txt_Pa_LName_Tab1.Text=="" || this.txt_Pa_NIC_Tab1.Text=="" || this.txt_Pa_age_Tab1.Text=="" || this.cmb_Pa_civilStatus_Tab1.Text=="" || this.txt_Pa_phone_Tab1.Text=="" || this.txt_Pa_diagnosis_Tab1.Text=="" || this.cmb_Pa_BloodGrp_Tab1.Text=="")
            {
                MessageBox.Show("Please Fill Empty Fields in Tab 01", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            else if (!radioButton1_Pa_genderMale_Tab1.Checked && !radioButton2_Pa_genderFemale_Tab1.Checked)
            {
                MessageBox.Show("Please Fill Empty Fields in Tab 01", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            else if (this.cmb_Gua_title_Tab1.Text == "" || this.txt_Gua_name_Tab1.Text == "" || this.txt_Gua_NIC_Tab1.Text == "" || this.txt_Gua_age_Tab1.Text == "" || this.txt_Gua_relationship_Tab1.Text == "" || this.txt_Gua_add1_Tab1.Text == "" || this.txt_Gua_add2_Tab1.Text == "" || this.txt_Gua_city_Tab1.Text == "" || this.txt_Gua_province_Tab1.Text == "" || this.txt_Gua_conNumber_Tab1.Text == "")
            {
                MessageBox.Show("Please Fill Empty Fields in Tab 01", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            else if (!radioButton4_Gua_genderMale_Tab1.Checked && !radioButton3_Gua_genderFemale_Tab1.Checked)
            {
                MessageBox.Show("Please Fill Empty Fields in Tab 01", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            else if (this.txt_WardID_Tab2.Text == "" || this.txt_WardName_Tab2.Text == "" || this.txt_Floor_Tab2.Text == "" || this.txt_RoomNo_Tab2.Text == "" || this.txt_BedNo_Tab2.Text == "" || this.txt_status_Tab2.Text == "")
            {
                MessageBox.Show("Cannot Register a Patient without assigning to a Room and Bed.", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            else
            {
                try
                {
                    myConn.Open();
                    string saveTab1_Pa_Query = "insert into itp.in_patient (patient_id,title,first_name,middle_name,last_name,nic,gender,date_of_birth,age,civil_status,contact_number,diagnosis,blood_group,date_admit) values('"+this.txt_Pa_ID_Tab1.Text+"','"+this.cmb_Pa_title_Tab1.Text+"','"+this.txt_Pa_FName_Tab1.Text+"','"+this.txt_Pa_MName_Tab1.Text+"','"+this.txt_Pa_LName_Tab1.Text+"','"+this.txt_Pa_NIC_Tab1.Text+"','"+gender+"','"+this.dateTimePicker_Pa_DOB_Tab1.Text+"','"+this.txt_Pa_age_Tab1.Text+"','"+this.cmb_Pa_civilStatus_Tab1.Text+"','"+this.txt_Pa_phone_Tab1.Text+"','"+this.txt_Pa_diagnosis_Tab1.Text+"','"+this.cmb_Pa_BloodGrp_Tab1.Text+"','"+this.dateTimePicker_Pa_DateAdmit_Tab1.Text+"');";
                    MySqlCommand cmd = new MySqlCommand(saveTab1_Pa_Query, myConn);
                    MySqlDataReader myReader;
                    myReader = cmd.ExecuteReader();
                    myConn.Close();

                    myConn.Open();
                    string saveTab1_Gua_Query = "insert into itp.in_patient_guardian (patient_id,gua_title,gua_name,gua_nic,gua_gender,gua_age,relationship,address_line1,address_line2,city,province,gua_contact_number) values('"+this.txt_Pa_ID_Tab1.Text+"','"+this.cmb_Gua_title_Tab1.Text+"','"+this.txt_Gua_name_Tab1.Text+"','"+this.txt_Gua_NIC_Tab1.Text+"','"+Gua_gender+"','"+this.txt_Gua_age_Tab1.Text+"','"+txt_Gua_relationship_Tab1.Text+"','"+this.txt_Gua_add1_Tab1.Text+"','"+this.txt_Gua_add2_Tab1.Text+"','"+this.txt_Gua_city_Tab1.Text+"','"+this.txt_Gua_province_Tab1.Text+"','"+this.txt_Gua_conNumber_Tab1.Text+"');";
                    MySqlCommand cmd1 = new MySqlCommand(saveTab1_Gua_Query, myConn);
                    MySqlDataReader myReader1;
                    myReader1 = cmd1.ExecuteReader();
                    myConn.Close();

                    myConn.Open();
                    string saveTab2_book_roomBed_Query = "insert into itp.assign_patient_to_bed (patient_id,room_no,bed_no) values('"+this.txt_Pa_ID_Tab1.Text+"','"+this.txt_RoomNo_Tab2.Text+"','"+this.txt_BedNo_Tab2.Text+"')";
                    MySqlCommand cmd2 = new MySqlCommand(saveTab2_book_roomBed_Query, myConn);
                    MySqlDataReader myReader2;
                    myReader2 = cmd2.ExecuteReader();
                    myConn.Close();

                    myConn.Open();
                    string updateTab2_bedStatus_Query = "UPDATE `itp`.`bed_details` SET `status`='"+this.txt_status_Tab2.Text+"' WHERE `room_no`='"+this.txt_RoomNo_Tab2.Text+ "' AND `bed_no`='"+this.txt_BedNo_Tab2.Text+"';";
                    MySqlCommand cmd3 = new MySqlCommand(updateTab2_bedStatus_Query,myConn);
                    MySqlDataReader myReader3;
                    myReader3 = cmd3.ExecuteReader();
                    myConn.Close();

                    myConn.Open();
                    string add_file_id_Query = "insert into itp.file_in_patient (patient_id,file_id) values('"+this.txt_Pa_ID_Tab1.Text+"','"+this.txt_Pa_ID_Tab1.Text+"');";
                    MySqlCommand cmd4 = new MySqlCommand(add_file_id_Query, myConn);
                    MySqlDataReader myReader4;
                    myReader4 = cmd4.ExecuteReader();
                    myConn.Close();


                    MessageBox.Show("Record Saved Successfully !!", "Successful Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    

                    this.txt_Pa_Name_Tab3.Text = txt_Pa_FName_Tab1.Text;
                    this.txt_Pa_LastName_Tab3.Text = txt_Pa_LName_Tab1.Text;

                    //in Patient
                    AutoGenerateInPatientID();
                    this.cmb_Pa_title_Tab1.SelectedIndex = -1;
                    this.txt_Pa_FName_Tab1.Text = "";
                    this.txt_Pa_MName_Tab1.Text = "";
                    this.txt_Pa_LName_Tab1.Text = "";
                    this.txt_Pa_NIC_Tab1.Text = "";
                    this.radioButton1_Pa_genderMale_Tab1.Checked = false;
                    this.radioButton2_Pa_genderFemale_Tab1.Checked = false;
                    this.dateTimePicker_Pa_DOB_Tab1.Value = DateTime.Now;
                    this.txt_Pa_age_Tab1.Text = "";
                    this.cmb_Pa_civilStatus_Tab1.SelectedIndex = -1;
                    this.txt_Pa_phone_Tab1.Text = "";
                    this.txt_Pa_diagnosis_Tab1.Text = "";
                    this.cmb_Pa_BloodGrp_Tab1.SelectedIndex = -1;
                    this.dateTimePicker_Pa_DateAdmit_Tab1.Value = DateTime.Now;

                    //guardian
                    this.cmb_Gua_title_Tab1.SelectedIndex = -1;
                    this.txt_Gua_name_Tab1.Text = "";
                    this.txt_Gua_NIC_Tab1.Text = "";
                    this.radioButton4_Gua_genderMale_Tab1.Checked = false;
                    this.radioButton3_Gua_genderFemale_Tab1.Checked = false;
                    this.txt_Gua_age_Tab1.Text = "";
                    this.txt_Gua_relationship_Tab1.Text = "";
                    this.txt_Gua_add1_Tab1.Text = "";
                    this.txt_Gua_add2_Tab1.Text = "";
                    this.txt_Gua_city_Tab1.Text = "";
                    this.txt_Gua_province_Tab1.Text = "";
                    this.txt_Gua_conNumber_Tab1.Text = "";

                    //TAB 02
                    this.cmb_WardName_Tab2.SelectedIndex = -1;
                    this.txt_WardID_Tab2.Text = "";
                    this.txt_WardName_Tab2.Text = "";
                    this.txt_Floor_Tab2.Text = "";
                    this.txt_RoomNo_Tab2.Text = "";
                    this.txt_BedNo_Tab2.Text = "";
                    this.txt_status_Tab2.Text = "";
                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "SError Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                load_datagrid_Tab1();
                load_datagrid_Tab2();

            }
        }


        //BACK button common to all
        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            Ward_MainFrame f1 = new Ward_MainFrame();
            f1.ShowDialog();
        }





        /*
         * //////////////////////////////////
         * 2nd TAB
         * Check Room Availability
         * content
         * Start
         * ////////////////////////////////
         */



        void FillWardNameCombo()
        {
            MySqlConnection myConn = new MySqlConnection(myConnection);
            myConn.Open();

            string combo1Query = "select * from itp.ward_category;";
            MySqlCommand cmd = new MySqlCommand(combo1Query, myConn);
            MySqlDataReader myReader;

            try
            {
                myReader = cmd.ExecuteReader();
                cmb_WardName_Tab2.Items.Clear();


                while (myReader.Read())
                {
                    string wName = myReader.GetString("ward_name");
                    cmb_WardName_Tab2.Items.Add(wName);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            myConn.Close();
        }


        private void cmb_WardName_Tab2_SelectedIndexChanged(object sender, EventArgs e)
        {
            MySqlConnection myConn = new MySqlConnection(myConnection);
            myConn.Open();

            string wardDetailsQuery = "select * from itp.ward_category where ward_name='"+cmb_WardName_Tab2.Text+"';";
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

                    txt_WardID_Tab2.Text = wID;
                    txt_WardName_Tab2.Text = wName;
                    txt_Floor_Tab2.Text = floor;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            myConn.Close();
        }


        private void btn_Check_Tab2_Click(object sender, EventArgs e)
        {
            load_datagrid_Tab2();
        }



        private void load_datagrid_Tab2()
        {
            MySqlConnection myConn = new MySqlConnection(myConnection);
            myConn.Open();

            try
            {
                string loadDataGridQuery = "SELECT w.ward_name as 'WARD_NAME', w.floor as 'FLOOR', c.type as 'CLASS_TYPE', r.room_no as 'ROOM_NO', b.bed_no as 'BED_NO', c.price as 'PRICE', b.status as 'STATUS' from itp.ward_category w, itp.class_type c, itp.room_details r, itp.bed_details b WHERE w.ward_id=r.ward_id AND c.type=r.type AND r.room_no=b.room_no AND w.ward_id='"+txt_WardID_Tab2.Text+"' AND b.status='Available';";
                MySqlCommand cmd = new MySqlCommand(loadDataGridQuery, myConn);

                MySqlDataAdapter sda = new MySqlDataAdapter();
                sda.SelectCommand = cmd;
                dbDataset = new DataTable();
                sda.Fill(dbDataset);
                BindingSource bSource = new BindingSource();

                bSource.DataSource = dbDataset;
                dataGridView1_Tab2.DataSource = bSource;

                Bitmap img = new Bitmap(Properties.Resources.AVAILABILITY_CHECK_checkmark_24px);
                Click_to_book_room_bed.Image = img;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            myConn.Close();
        }


        private void dataGridView1_Tab2_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (this.dataGridView1_Tab2.Rows[e.RowIndex].IsNewRow && e.ColumnIndex == 0)
            {
                e.Value = Properties.Resources.more_24px;
            }
        }


        private void dataGridView1_Tab2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.ColumnIndex == 0)
            {
                try
                {
                    this.txt_RoomNo_Tab2.Text = dataGridView1_Tab2.SelectedRows[0].Cells[4].Value.ToString();
                    this.txt_BedNo_Tab2.Text = dataGridView1_Tab2.SelectedRows[0].Cells[5].Value.ToString();
                    this.txt_status_Tab2.Text = "Not Available";
                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
           
        }


        private void dataGridView1_Tab2_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                this.txt_RoomNo_Tab2.Text = dataGridView1_Tab2.SelectedRows[0].Cells[4].Value.ToString();
                this.txt_BedNo_Tab2.Text = dataGridView1_Tab2.SelectedRows[0].Cells[5].Value.ToString();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }


        private void btn_Clear_Content_Tab2_Click(object sender, EventArgs e)
        {
            this.cmb_WardName_Tab2.SelectedIndex = -1;
            this.txt_WardID_Tab2.Text = "";
            this.txt_WardName_Tab2.Text = "";
            this.txt_Floor_Tab2.Text = "";
            this.txt_RoomNo_Tab2.Text = "";
            this.txt_BedNo_Tab2.Text = "";
            this.txt_status_Tab2.Text = "";
        }


        private void btn_Refresh_Tab2_Click(object sender, EventArgs e)
        {
            load_datagrid_Tab2();
        }



        /*
         * //////////////////////////////////
         * 3rd TAB
         * Print Documents
         * content
         * Start
         * ////////////////////////////////
         */






            //Print Button should come here







        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void Ward_Admin_RegisterIn_Patient_Load(object sender, EventArgs e)
        {

        }
        
    }
}
