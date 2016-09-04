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
    public partial class Ward_Admin_WardHandling : Form
    {
        public Ward_Admin_WardHandling()
        {
            InitializeComponent();

            auto_load_datagrid();       //Tab1
            auto_load_datagrid_Tab2();  //Tab2
            auto_load_datagrid_Tab3();  //Tab3
            auto_load_datagrid_Tab4();  //Tab4

            //1st TAB
            AutoGenerateWardID();

            //2nd TAB
            AutoGenerateClassID();
            
            //3rd TAB
            FillWardIDCombo();
            FillClassTypCombo();
            AutoGenerateRoomNo();

            //4th TAB
            FillRoomNoCombo();
            //AutoGenerate_BedNo();
        }

        static string myConnection = "Data Source=localhost; Initial Catalog=itp; port=3306; username=root; password=sagarox";
        //static MySqlConnection myConn = new MySqlConnection(myConnection);



        /*
         * //////////////////////////////////
         * 1st TAB
         * Add New Ward
         * content
         * Start
         * ////////////////////////////////
         */


        string wardIDletter = "W";
        DataTable dbDataset;


        private void AutoGenerateWardID()
        {
            MySqlConnection myConn = new MySqlConnection(myConnection);
            myConn.Open();

            try
            {
                string autogenerateQuery = "Select Count(ward_id) from itp.ward_category;";
                MySqlCommand cmd = new MySqlCommand(autogenerateQuery, myConn);
                int i = Convert.ToInt32(cmd.ExecuteScalar());
                int j;

                if (i == 0)
                {
                    i = i + 1;
                    j = i + 100;

                    this.txtWardID.Text =wardIDletter+j.ToString();
                }
                else
                {
                    string lastIDQuery = "SELECT ward_id FROM itp.ward_category order by ward_id desc limit 1;";
                    MySqlCommand cmd1 = new MySqlCommand(lastIDQuery, myConn);

                    string value = (string)cmd1.ExecuteScalar();
                    string s = SearchNum(value);

                    int k = Convert.ToInt32(s);
                    k = k + 1;

                    this.txtWardID.Text = wardIDletter + k.ToString();
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



        private void btnSave_Click(object sender, EventArgs e)
        {
            MySqlConnection myConn = new MySqlConnection(myConnection);
            myConn.Open();

            if (txtWardName.Text == "" || cmbFloor.Text == "")
            {
                MessageBox.Show("Please Fill Empty Fields", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            else
            {
                try
                {
                    string saveQuery = "insert into itp.ward_category (ward_id,ward_name,floor) values('"+this.txtWardID.Text+"','"+this.txtWardName.Text+"','"+this.cmbFloor.Text+"');";
                    MySqlCommand cmd = new MySqlCommand(saveQuery, myConn);
                    MySqlDataReader myReader;

                    myReader = cmd.ExecuteReader();
                    MessageBox.Show("Record Saved Successfully !!", "Successful Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    AutoGenerateWardID();
                    this.txtWardName.Text = "";
                    this.cmbFloor.SelectedIndex = -1;

                    while (myReader.Read())
                    {

                    }
                    myConn.Close();
                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "SError Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                auto_load_datagrid();
                FillWardIDCombo(); //3rd Tab (inside)
            }
        }


        private void auto_load_datagrid()
        {
            MySqlConnection myConn = new MySqlConnection(myConnection);
            myConn.Open();

            try
            {
                string autoloadDataGridQuery = "select ward_id as 'WARD_ID', ward_name as 'WARD_NAME', floor as 'FLOOR' from itp.ward_category;";
                MySqlCommand cmd = new MySqlCommand(autoloadDataGridQuery, myConn);

                MySqlDataAdapter sda = new MySqlDataAdapter();
                sda.SelectCommand = cmd;
                dbDataset = new DataTable();
                sda.Fill(dbDataset);
                BindingSource bSource = new BindingSource();

                bSource.DataSource = dbDataset;
                dataGridView1_wardHandling.DataSource = bSource;

                Bitmap img = new Bitmap(Properties.Resources.edit_black_24px);
                btnClickForUpdate.Image = img;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            dataGridView1_wardHandling.Columns["WARD_ID"].ReadOnly = true;
            dataGridView1_wardHandling.Columns["WARD_NAME"].ReadOnly = true;
            dataGridView1_wardHandling.Columns["FLOOR"].ReadOnly = true;

            myConn.Close();
        }

        private void dataGridView1_wardHandling_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (this.dataGridView1_wardHandling.Rows[e.RowIndex].IsNewRow && e.ColumnIndex == 0)
            {
                e.Value = Properties.Resources.more_24px;
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            MySqlConnection myConn = new MySqlConnection(myConnection);
            myConn.Open();

            if (txtWardName.Text == "" || cmbFloor.Text == "")
            {
                MessageBox.Show("Cannot Update. Fields are Empty", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }

            else if (cmbFloor.Text != "Ground Floor" && cmbFloor.Text != "Floor 1" && cmbFloor.Text != "Floor 2" && cmbFloor.Text != "Floor 3" && cmbFloor.Text != "Floor 4")
            {
                MessageBox.Show("Please Select from Combo Box", "ComboBoxError Message", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }

            else
            {
                try
                {
                    string updateQuery = "UPDATE `itp`.`ward_category` SET `ward_name`='"+this.txtWardName.Text+"',`floor`='"+this.cmbFloor.Text+"' WHERE `ward_id`='"+this.txtWardID.Text+"';";
                    MySqlCommand cmd = new MySqlCommand(updateQuery, myConn);
                    MySqlDataReader myReader;


                    myReader = cmd.ExecuteReader();
                    MessageBox.Show("Record Updated Successfully !!", "Successful Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    AutoGenerateWardID();
                    this.txtWardName.Text = "";
                    this.cmbFloor.SelectedIndex = -1;
                    //this.cmbFloor.DropDownStyle = ComboBoxStyle.DropDownList;

                    while (myReader.Read())
                    {

                    }
                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                auto_load_datagrid();
                FillWardIDCombo(); //3rd Tab (inside)
                myConn.Close();
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            auto_load_datagrid();
        }
        
        private void dataGridView1_wardHandling_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.ColumnIndex == 0)
                {
                    this.txtWardName.Enabled = true;
                    this.cmbFloor.Enabled = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void dataGridView1_wardHandling_MouseClick(object sender, MouseEventArgs e)
        {
            //this.cmbFloor.DropDownStyle = ComboBoxStyle.DropDown;
            this.txtWardName.Enabled = false;
            this.cmbFloor.Enabled = false;

            try
            {
                txtWardID.Text = dataGridView1_wardHandling.SelectedRows[0].Cells[1].Value.ToString();
                txtWardName.Text = dataGridView1_wardHandling.SelectedRows[0].Cells[2].Value.ToString();
                cmbFloor.Text = dataGridView1_wardHandling.SelectedRows[0].Cells[3].Value.ToString();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        
        private void btnDelete_Click(object sender, EventArgs e)
        {
            MySqlConnection myConn = new MySqlConnection(myConnection);
            myConn.Open();

            if (txtWardName.Text == "" || cmbFloor.Text == "")
            {
                MessageBox.Show("Cannot Delete. Fields are Empty", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }

            else
            {
                try
                {
                    string deleteQuery = "DELETE FROM `itp`.`ward_category` WHERE `ward_id`='"+this.txtWardID.Text+"';";
                    MySqlCommand cmd = new MySqlCommand(deleteQuery, myConn);
                    MySqlDataReader myReader;


                    myReader = cmd.ExecuteReader();
                    MessageBox.Show("Record Deleted Successfully", "Successful Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    AutoGenerateWardID();
                    this.txtWardName.Text = "";
                    this.cmbFloor.SelectedIndex = -1;
                    this.txtWardName.Enabled = true;
                    this.cmbFloor.Enabled = true;
                    //this.cmbFloor.DropDownStyle = ComboBoxStyle.DropDownList;

                    while (myReader.Read())
                    {

                    }
                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            auto_load_datagrid();
            FillWardIDCombo(); //3rd Tab (inside)
            myConn.Close();
        }


        private void btnSearch_Click(object sender, EventArgs e)
        {
            MySqlConnection myConn = new MySqlConnection(myConnection);
            myConn.Open();

            DataView DVSearch = new DataView(dbDataset);

            if (cmbSelectKeywordtoSearch.Text == "")
            {
                MessageBox.Show("Please Select a Category to Search", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            else if (txtSearchKeyWord.Text == "")
            {
                MessageBox.Show("Please Input data to Search", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            else
            {
                try
                {
                    if (cmbSelectKeywordtoSearch.Text == "Ward ID")
                    {
                        DVSearch.RowFilter = string.Format("WARD_ID LIKE '%{0}%'", txtSearchKeyWord.Text);
                        dataGridView1_wardHandling.DataSource = DVSearch;
                    }

                    else if (cmbSelectKeywordtoSearch.Text == "Ward Name")
                    {
                        DVSearch.RowFilter = string.Format("WARD_NAME LIKE '%{0}%'", txtSearchKeyWord.Text);
                        dataGridView1_wardHandling.DataSource = DVSearch;
                    }

                    else if (cmbSelectKeywordtoSearch.Text == "Floor")
                    {
                        DVSearch.RowFilter = string.Format("FLOOR LIKE '%{0}%'", txtSearchKeyWord.Text);
                        dataGridView1_wardHandling.DataSource = DVSearch;
                    }
                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                this.txtSearchKeyWord.Text = "";
                this.cmbSelectKeywordtoSearch.Text = "";
                myConn.Close();
            }
        }

        
        private void btnClear_Content_Click(object sender, EventArgs e)
        {
            MySqlConnection myConn = new MySqlConnection(myConnection);
            myConn.Open();

            try
            {
                AutoGenerateWardID();
                this.txtWardName.Text = "";
                this.cmbFloor.SelectedIndex = -1;
                this.txtWardName.Enabled = true;
                this.cmbFloor.Enabled = true;
                //this.cmbFloor.DropDownStyle = ComboBoxStyle.DropDownList;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            myConn.Close();
        }

        
        private void txtWardName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) || e.KeyChar == 8 || e.KeyChar == '_' || e.KeyChar == ' ' || e.KeyChar == 46) //8=backspace 46=del
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void cmbFloor_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void cmbSelectKeywordtoSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }




        /*
          *back button common to all tabs
        */

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            Ward_MainFrame f1 = new Ward_MainFrame();
            f1.ShowDialog();
        }


        /*
         * ///////////////////////////////////////////////
         * 2nd TAB
         * Add New Class Types
         * content
         * Start
         * //////////////////////////////////////////////
         */

//
        string classIDletter = "C";
        string Ventilation;
        string Sleeper_Unit;
        string Ameni_TV, Ameni_sofa, Ameni_phone, Ameni_fridge, Ameni_wardrobe;
        //DataTable dbDataset_Tab2;

        private void AutoGenerateClassID()
        {
            MySqlConnection myConn = new MySqlConnection(myConnection);
            myConn.Open();

            try
            {
                string autogenerateClassQuery = "Select Count(type) from itp.class_type;";
                MySqlCommand cmd = new MySqlCommand(autogenerateClassQuery, myConn);
                int i = Convert.ToInt32(cmd.ExecuteScalar());
                int j;

                if (i == 0)
                {
                    i = i + 1;
                    j = i + 100;

                    this.txtTab2_ClassType.Text = classIDletter + j.ToString();
                }
                else
                {
                    string lastIDQuery = "SELECT type FROM itp.class_type order by type desc limit 1;";
                    MySqlCommand cmd1 = new MySqlCommand(lastIDQuery, myConn);

                    string value = (string)cmd1.ExecuteScalar();
                    string s = SearchNum(value);  //function located in above

                    int k = Convert.ToInt32(s);
                    k = k + 1;

                    this.txtTab2_ClassType.Text = classIDletter + k.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            myConn.Close();
        }
        
        private void radioBtnTab2_AC_CheckedChanged(object sender, EventArgs e)
        {
            Ventilation = "AC";
        }

        private void radioBtnTab2_NonAC_CheckedChanged(object sender, EventArgs e)
        {
            Ventilation = "Non AC";
        }

        private void radioBtnTab2_OptionalSleeper_YES_CheckedChanged(object sender, EventArgs e)
        {
            Sleeper_Unit = "Yes";
        }

        private void radioBtnTab2_OptionalSleeper_NO_CheckedChanged(object sender, EventArgs e)
        {
            Sleeper_Unit = "No";
        }

        private void checkBox1_Tab2_Amenities_TV_CheckedChanged(object sender, EventArgs e)
        {   
        }

        private void checkBox5_Tab2_Amenities_Sofa_CheckedChanged(object sender, EventArgs e)
        {
         }

        private void checkBox2_Tab2_Amenities_4n_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void checkBox4_Tab2_Amenities_Fridge_CheckedChanged(object sender, EventArgs e)
        {
         }

        private void checkBox3_Tab2_Amenities_Wardrobe_CheckedChanged(object sender, EventArgs e)
        {
         }

        private void btnTab2_Save_Click(object sender, EventArgs e)
        {
            MySqlConnection myConn = new MySqlConnection(myConnection);
            myConn.Open();

            if (txtTab2_BathRoom.Text == "" || txtTab2_Food.Text == "" || txtTab2_Price.Text == "" || txtTab2_Food.Text == "")
            {
                MessageBox.Show("Please Fill Empty Fields", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            else if(!radioBtnTab2_AC.Checked && !radioBtnTab2_NonAC.Checked)
            {
                MessageBox.Show("Please Fill Empty Fields", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            else if (!radioBtnTab2_OptionalSleeper_NO.Checked && !radioBtnTab2_OptionalSleeper_YES.Checked)
            {
                MessageBox.Show("Please Fill Empty Fields", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            else
            {
                try
                {
                    if (checkBox1_Tab2_Amenities_TV.Checked == true) //TV
                    {
                        Ameni_TV = "Yes";
                    }
                    else
                    {
                        Ameni_TV = "No";
                    }

                    if (checkBox5_Tab2_Amenities_Sofa.Checked == true) //sofa
                    {
                        Ameni_sofa = "Yes";
                    }
                    else
                    {
                        Ameni_sofa = "No";
                    }

                    if (checkBox2_Tab2_Amenities_4n.Checked == true) //4n
                    {
                        Ameni_phone = "Yes";
                    }
                    else
                    {
                        Ameni_phone = "No";
                    }


                    if (checkBox4_Tab2_Amenities_Fridge.Checked == true) //fridge
                    {
                        Ameni_fridge = "Yes";
                    }
                    else
                    {
                        Ameni_fridge = "No";
                    }


                    if (checkBox3_Tab2_Amenities_Wardrobe.Checked == true) //wardrobe
                    {
                        Ameni_wardrobe = "Yes";
                    }
                    else
                    {
                        Ameni_wardrobe = "No";
                    }
                    


                    string saveTab2Query = "INSERT INTO `itp`.`class_type` (`type`, `bathroom`, `food`, `ventilation`, `optional_sleeper_unit`, `amenities_tv`, `amenities_sofa`, `amenities_phone`, `amenities_fridge`, `amenities_wardrobe`, `price`) VALUES ('"+txtTab2_ClassType.Text+"', '"+txtTab2_BathRoom.Text+"', '"+txtTab2_Food.Text+"', '"+Ventilation+"', '"+Sleeper_Unit+"', '"+Ameni_TV+"', '"+Ameni_sofa+"', '"+Ameni_phone+"', '"+Ameni_fridge+"', '"+Ameni_wardrobe+"', '"+txtTab2_Price.Text+"');";
                    MySqlCommand cmd = new MySqlCommand(saveTab2Query, myConn);
                    MySqlDataReader myReader;

                    myReader = cmd.ExecuteReader();
                    MessageBox.Show("Record Saved Successfully !!", "Successful Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    AutoGenerateClassID();
                    this.txtTab2_BathRoom.Text = "";
                    this.txtTab2_Food.Text = "";
                    this.txtTab2_Price.Text = "";
                    radioBtnTab2_AC.Checked = false;
                    radioBtnTab2_NonAC.Checked = false;
                    radioBtnTab2_OptionalSleeper_NO.Checked = false;
                    radioBtnTab2_OptionalSleeper_YES.Checked = false;
                    checkBox1_Tab2_Amenities_TV.Checked = false;
                    checkBox5_Tab2_Amenities_Sofa.Checked = false;
                    checkBox2_Tab2_Amenities_4n.Checked = false;
                    checkBox4_Tab2_Amenities_Fridge.Checked = false;
                    checkBox3_Tab2_Amenities_Wardrobe.Checked = false;

                    while (myReader.Read())
                    {

                    }
                    FillClassTypCombo();
                    myConn.Close();
                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "SError Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                auto_load_datagrid_Tab2();
            }
        }
        

        private void auto_load_datagrid_Tab2()
        {
            MySqlConnection myConn = new MySqlConnection(myConnection);
            myConn.Open();

            try
            {
                string autoloadDataGrid_Tab2_Query = "select type as 'CLASS_TYPE', bathroom as 'BATHROOM/TOILET', food as 'FOOD', ventilation as 'VENTILATION', optional_sleeper_unit as 'OPTIONAL_SLEEPER_UNIT', amenities_tv as 'TELEVISION', amenities_sofa as 'SOFA', amenities_phone as 'TELEPHONE', amenities_fridge as 'FRIDGE', amenities_wardrobe as 'WARDROBE', price as 'PRICE(Rs.)' from itp.class_type;";
                MySqlCommand cmd = new MySqlCommand(autoloadDataGrid_Tab2_Query, myConn);

                MySqlDataAdapter sda = new MySqlDataAdapter();
                sda.SelectCommand = cmd;
                dbDataset = new DataTable();
                sda.Fill(dbDataset);
                BindingSource bSource = new BindingSource();

                bSource.DataSource = dbDataset;
                dataGridView1_Tab2_WardHandling.DataSource = bSource;

                Bitmap img = new Bitmap(Properties.Resources.edit_black_24px);
                btnClickForUpdate_Tab2.Image = img;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            dataGridView1_Tab2_WardHandling.Columns["CLASS_TYPE"].ReadOnly = true;
            dataGridView1_Tab2_WardHandling.Columns["BATHROOM/TOILET"].ReadOnly = true;
            dataGridView1_Tab2_WardHandling.Columns["FOOD"].ReadOnly = true;

            dataGridView1_Tab2_WardHandling.Columns["VENTILATION"].ReadOnly = true;
            dataGridView1_Tab2_WardHandling.Columns["OPTIONAL_SLEEPER_UNIT"].ReadOnly = true;
            dataGridView1_Tab2_WardHandling.Columns["TELEVISION"].ReadOnly = true;

            dataGridView1_Tab2_WardHandling.Columns["SOFA"].ReadOnly = true;
            dataGridView1_Tab2_WardHandling.Columns["TELEPHONE"].ReadOnly = true;
            dataGridView1_Tab2_WardHandling.Columns["FRIDGE"].ReadOnly = true;

            dataGridView1_Tab2_WardHandling.Columns["WARDROBE"].ReadOnly = true;
            dataGridView1_Tab2_WardHandling.Columns["PRICE(Rs.)"].ReadOnly = true;


            myConn.Close();
        }

        
        private void dataGridView1_Tab2_WardHandling_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (this.dataGridView1_Tab2_WardHandling.Rows[e.RowIndex].IsNewRow && e.ColumnIndex == 0)
            {
                e.Value = Properties.Resources.more_24px;
            }
        }

        
        
        private void btnTab2_Update_Click(object sender, EventArgs e)
        {
            MySqlConnection myConn = new MySqlConnection(myConnection);
            myConn.Open();

            if (txtTab2_BathRoom.Text == "" || txtTab2_Food.Text == "" || txtTab2_Price.Text == "" || txtTab2_Food.Text == "")
            {
                MessageBox.Show("Cannot Update. Fields are Empty", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            else if (!radioBtnTab2_AC.Checked && !radioBtnTab2_NonAC.Checked)
            {
                MessageBox.Show("Cannot Update. Please Select Ventilation Type", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            else if (!radioBtnTab2_OptionalSleeper_NO.Checked && !radioBtnTab2_OptionalSleeper_YES.Checked)
            {
                MessageBox.Show("Cannot Update. Please Select Optional Sleeper Unit", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            else
            {
                try
                {
                    if (checkBox1_Tab2_Amenities_TV.Checked == true) //TV
                    {
                        Ameni_TV = "Yes";
                    }
                    else
                    {
                        Ameni_TV = "No";
                    }

                    if (checkBox5_Tab2_Amenities_Sofa.Checked == true) //sofa
                    {
                        Ameni_sofa = "Yes";
                    }
                    else
                    {
                        Ameni_sofa = "No";
                    }

                    if (checkBox2_Tab2_Amenities_4n.Checked == true) //4n
                    {
                        Ameni_phone = "Yes";
                    }
                    else
                    {
                        Ameni_phone = "No";
                    }


                    if (checkBox4_Tab2_Amenities_Fridge.Checked == true) //fridge
                    {
                        Ameni_fridge = "Yes";
                    }
                    else
                    {
                        Ameni_fridge = "No";
                    }


                    if (checkBox3_Tab2_Amenities_Wardrobe.Checked == true) //wardrobe
                    {
                        Ameni_wardrobe = "Yes";
                    }
                    else
                    {
                        Ameni_wardrobe = "No";
                    }



                    string updateTab2Query = "UPDATE `itp`.`class_type` SET `bathroom`='"+this.txtTab2_BathRoom.Text+"',`food`='"+this.txtTab2_Food.Text+"',`ventilation`='"+Ventilation+"',`optional_sleeper_unit`='"+Sleeper_Unit+"' ,`amenities_tv`='"+Ameni_TV+"' ,`amenities_sofa`='"+Ameni_sofa+"' ,`amenities_phone`='"+Ameni_phone+"' ,`amenities_fridge`='"+Ameni_fridge+"' ,`amenities_wardrobe`='"+Ameni_wardrobe+"',`price`='"+txtTab2_Price.Text+"' WHERE `type`='"+this.txtTab2_ClassType.Text+"';";
                    
                    MySqlCommand cmd = new MySqlCommand(updateTab2Query, myConn);
                    MySqlDataReader myReader;


                    myReader = cmd.ExecuteReader();
                    MessageBox.Show("Record Updated Successfully !!", "Successful Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    AutoGenerateClassID();
                    this.txtTab2_BathRoom.Text = "";
                    this.txtTab2_Food.Text = "";
                    this.txtTab2_Price.Text = "";
                    radioBtnTab2_AC.Checked = false;
                    radioBtnTab2_NonAC.Checked = false;
                    radioBtnTab2_OptionalSleeper_NO.Checked = false;
                    radioBtnTab2_OptionalSleeper_YES.Checked = false;
                    checkBox1_Tab2_Amenities_TV.Checked = false;
                    checkBox5_Tab2_Amenities_Sofa.Checked = false;
                    checkBox2_Tab2_Amenities_4n.Checked = false;
                    checkBox4_Tab2_Amenities_Fridge.Checked = false;
                    checkBox3_Tab2_Amenities_Wardrobe.Checked = false;

                    while (myReader.Read())
                    {

                    }
                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                auto_load_datagrid_Tab2();
                FillClassTypCombo(); //3rd Tab (inside)
                myConn.Close();
            }
        }

        private void btnTab2_Refresh_Click(object sender, EventArgs e)
        {
            auto_load_datagrid_Tab2();
        }

        
        private void dataGridView1_Tab2_WardHandling_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.ColumnIndex == 0)
                {
                    this.txtTab2_BathRoom.Enabled = true;
                    this.txtTab2_Food.Enabled = true;
                    this.txtTab2_Price.Enabled = true;
                    this.radioBtnTab2_AC.Enabled = true;
                    this.radioBtnTab2_NonAC.Enabled = true;
                    this.radioBtnTab2_OptionalSleeper_NO.Enabled = true;
                    this.radioBtnTab2_OptionalSleeper_YES.Enabled = true;
                    this.checkBox1_Tab2_Amenities_TV.Enabled = true;
                    this.checkBox5_Tab2_Amenities_Sofa.Enabled = true;
                    this.checkBox2_Tab2_Amenities_4n.Enabled = true;
                    this.checkBox4_Tab2_Amenities_Fridge.Enabled = true;
                    this.checkBox3_Tab2_Amenities_Wardrobe.Enabled = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        
        private void dataGridView1_Tab2_WardHandling_MouseClick(object sender, MouseEventArgs e)
        {
            this.txtTab2_BathRoom.Enabled = false;
            this.txtTab2_Food.Enabled = false;
            this.txtTab2_Price.Enabled = false;
            this.radioBtnTab2_AC.Enabled = false;
            this.radioBtnTab2_NonAC.Enabled = false;
            this.radioBtnTab2_OptionalSleeper_NO.Enabled = false;
            this.radioBtnTab2_OptionalSleeper_YES.Enabled = false;
            this.checkBox1_Tab2_Amenities_TV.Enabled = false;
            this.checkBox5_Tab2_Amenities_Sofa.Enabled = false;
            this.checkBox2_Tab2_Amenities_4n.Enabled = false;
            this.checkBox4_Tab2_Amenities_Fridge.Enabled = false;
            this.checkBox3_Tab2_Amenities_Wardrobe.Enabled = false;

            try
            {
                txtTab2_ClassType.Text = dataGridView1_Tab2_WardHandling.SelectedRows[0].Cells[1].Value.ToString();
                txtTab2_BathRoom.Text = dataGridView1_Tab2_WardHandling.SelectedRows[0].Cells[2].Value.ToString();
                txtTab2_Food.Text = dataGridView1_Tab2_WardHandling.SelectedRows[0].Cells[3].Value.ToString();

                //ventilation
                string ventilation_value = dataGridView1_Tab2_WardHandling.SelectedRows[0].Cells[4].Value.ToString();
                if(ventilation_value=="AC")
                {
                    radioBtnTab2_AC.Checked = true;
                }
                else
                {
                    radioBtnTab2_NonAC.Checked = true;
                }

                //sleeper unit
                string sleeper_Unit_value = dataGridView1_Tab2_WardHandling.SelectedRows[0].Cells[5].Value.ToString();
                if (sleeper_Unit_value == "Yes")
                {
                    radioBtnTab2_OptionalSleeper_YES.Checked = true;
                }
                else
                {
                    radioBtnTab2_OptionalSleeper_NO.Checked = true;
                }
                

                //checkbox - tv
                string TV_value = dataGridView1_Tab2_WardHandling.SelectedRows[0].Cells[6].Value.ToString();
                if (TV_value == "Yes")
                {
                    checkBox1_Tab2_Amenities_TV.Checked = true;
                }
                else
                {
                    checkBox1_Tab2_Amenities_TV.Checked = false;
                }

                //checkbox - sofa
                string sofa_value = dataGridView1_Tab2_WardHandling.SelectedRows[0].Cells[7].Value.ToString();
                if (sofa_value == "Yes")
                {
                    checkBox5_Tab2_Amenities_Sofa.Checked = true;
                }
                else
                {
                    checkBox5_Tab2_Amenities_Sofa.Checked = false;
                }

                //checkbox - 4n
                string phone_value = dataGridView1_Tab2_WardHandling.SelectedRows[0].Cells[8].Value.ToString();
                if (phone_value == "Yes")
                {
                    checkBox2_Tab2_Amenities_4n.Checked = true;
                }
                else
                {
                    checkBox2_Tab2_Amenities_4n.Checked = false;
                }

                //checkbox - fridge
                string fridge_value = dataGridView1_Tab2_WardHandling.SelectedRows[0].Cells[9].Value.ToString();
                if (fridge_value == "Yes")
                {
                    checkBox4_Tab2_Amenities_Fridge.Checked = true;
                }
                else
                {
                    checkBox4_Tab2_Amenities_Fridge.Checked = false;
                }

                //checkbox - wardrobe
                string wardrobe_value = dataGridView1_Tab2_WardHandling.SelectedRows[0].Cells[10].Value.ToString();
                if (wardrobe_value == "Yes")
                {
                    checkBox3_Tab2_Amenities_Wardrobe.Checked = true;
                }
                else
                {
                    checkBox3_Tab2_Amenities_Wardrobe.Checked = false;
                }


                txtTab2_Price.Text = dataGridView1_Tab2_WardHandling.SelectedRows[0].Cells[11].Value.ToString();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        
        private void btnTab2_Delete_Click(object sender, EventArgs e)
        {
            MySqlConnection myConn = new MySqlConnection(myConnection);
            myConn.Open();

            if (txtTab2_BathRoom.Text == "" || txtTab2_Food.Text == "" || txtTab2_Price.Text == "" || txtTab2_Food.Text == "")
            {
                MessageBox.Show("Cannot Update. Fields are Empty", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            else if (!radioBtnTab2_AC.Checked && !radioBtnTab2_NonAC.Checked)
            {
                MessageBox.Show("Cannot Update. Please Select Ventilation Type", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            else if (!radioBtnTab2_OptionalSleeper_NO.Checked && !radioBtnTab2_OptionalSleeper_YES.Checked)
            {
                MessageBox.Show("Cannot Update. Please Select Optional Sleeper Unit", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }

            else
            {
                try
                {
                    string deleteTab2Query = "DELETE FROM `itp`.`class_type` WHERE `type`= '" + this.txtTab2_ClassType.Text + " ';";
                    MySqlCommand cmd = new MySqlCommand(deleteTab2Query, myConn);
                    MySqlDataReader myReader;


                    myReader = cmd.ExecuteReader();
                    MessageBox.Show("Record Deleted Successfully", "Successful Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    AutoGenerateClassID();
                    this.txtTab2_BathRoom.Text = "";
                    this.txtTab2_Food.Text = "";
                    this.txtTab2_Price.Text = "";
                    radioBtnTab2_AC.Checked = false;
                    radioBtnTab2_NonAC.Checked = false;
                    radioBtnTab2_OptionalSleeper_NO.Checked = false;
                    radioBtnTab2_OptionalSleeper_YES.Checked = false;
                    checkBox1_Tab2_Amenities_TV.Checked = false;
                    checkBox5_Tab2_Amenities_Sofa.Checked = false;
                    checkBox2_Tab2_Amenities_4n.Checked = false;
                    checkBox4_Tab2_Amenities_Fridge.Checked = false;
                    checkBox3_Tab2_Amenities_Wardrobe.Checked = false;

                    while (myReader.Read())
                    {

                    }
                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }

            auto_load_datagrid_Tab2();
            FillClassTypCombo(); //3rd Tab (inside)
            myConn.Close();
        }

        
        private void btnTab2_Search_Click(object sender, EventArgs e)
        {
            MySqlConnection myConn = new MySqlConnection(myConnection);
            myConn.Open();

            DataView DVSearch_Tab2 = new DataView(dbDataset);
            
            if (cmbTab2_SelectKeywordToSearch.Text == "")
            {
                MessageBox.Show("Please Select a Category to Search", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (txtTab2_SearchWord.Text == "")
            {
                MessageBox.Show("Please Input data to Search", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                try
                {
                    if (cmbTab2_SelectKeywordToSearch.Text == "Class Type")
                    {
                        DVSearch_Tab2.RowFilter = string.Format("CLASS_TYPE LIKE '%{0}%'", txtTab2_SearchWord.Text);
                        dataGridView1_Tab2_WardHandling.DataSource = DVSearch_Tab2;
                    }

                    else if (cmbTab2_SelectKeywordToSearch.Text == "Bath Room/ Toilet")
                    {
                        DVSearch_Tab2.RowFilter = string.Format("BATHROOM/TOILET LIKE '%{0}%'", txtTab2_SearchWord.Text);
                        dataGridView1_Tab2_WardHandling.DataSource = DVSearch_Tab2;
                    }

                    else if (cmbTab2_SelectKeywordToSearch.Text == "Food")
                    {
                        DVSearch_Tab2.RowFilter = string.Format("FOOD LIKE '%{0}%'", txtTab2_SearchWord.Text);
                        dataGridView1_Tab2_WardHandling.DataSource = DVSearch_Tab2;
                    }
                    else if (cmbTab2_SelectKeywordToSearch.Text == "Ventilation")
                    {
                        DVSearch_Tab2.RowFilter = string.Format("VENTILATION LIKE '%{0}%'", txtTab2_SearchWord.Text);
                        dataGridView1_Tab2_WardHandling.DataSource = DVSearch_Tab2;
                    }

                    else if (cmbTab2_SelectKeywordToSearch.Text == "Optional Sleeper Unit")
                    {
                        DVSearch_Tab2.RowFilter = string.Format("OPTIONAL_SLEEPER_UNIT LIKE '%{0}%'", txtTab2_SearchWord.Text);
                        dataGridView1_Tab2_WardHandling.DataSource = DVSearch_Tab2;
                    }
                    else if (cmbTab2_SelectKeywordToSearch.Text == "Television")
                    {
                        DVSearch_Tab2.RowFilter = string.Format("TELEVISION LIKE '%{0}%'", txtTab2_SearchWord.Text);
                        dataGridView1_Tab2_WardHandling.DataSource = DVSearch_Tab2;
                    }

                    else if (cmbTab2_SelectKeywordToSearch.Text == "Sofa")
                    {
                        DVSearch_Tab2.RowFilter = string.Format("SOFA LIKE '%{0}%'", txtTab2_SearchWord.Text);
                        dataGridView1_Tab2_WardHandling.DataSource = DVSearch_Tab2;
                    }
                    else if (cmbTab2_SelectKeywordToSearch.Text == "Telephone")
                    {
                        DVSearch_Tab2.RowFilter = string.Format("TELEPHONE LIKE '%{0}%'", txtTab2_SearchWord.Text);
                        dataGridView1_Tab2_WardHandling.DataSource = DVSearch_Tab2;
                    }

                    else if (cmbTab2_SelectKeywordToSearch.Text == "Fridge")
                    {
                        DVSearch_Tab2.RowFilter = string.Format("FRIDGE LIKE '%{0}%'", txtTab2_SearchWord.Text);
                        dataGridView1_Tab2_WardHandling.DataSource = DVSearch_Tab2;
                    }
                    else if (cmbTab2_SelectKeywordToSearch.Text == "Wardrobe")
                    {
                        DVSearch_Tab2.RowFilter = string.Format("WARDROBE LIKE '%{0}%'", txtTab2_SearchWord.Text);
                        dataGridView1_Tab2_WardHandling.DataSource = DVSearch_Tab2;
                    }

                    else if (cmbTab2_SelectKeywordToSearch.Text == "Price")
                    {
                        DVSearch_Tab2.RowFilter = string.Format("PRICE(Rs.) LIKE '%{0}%'", txtTab2_SearchWord.Text);
                        dataGridView1_Tab2_WardHandling.DataSource = DVSearch_Tab2;
                    }
                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                this.txtTab2_SearchWord.Text = "";
                this.cmbTab2_SelectKeywordToSearch.Text = "";
                myConn.Close();
            }
        }

        
        private void btnTab2_Clear_Click(object sender, EventArgs e)
        {
            MySqlConnection myConn = new MySqlConnection(myConnection);
            myConn.Open();

            try
            {
                AutoGenerateClassID();
                this.txtTab2_BathRoom.Text = "";
                this.txtTab2_Food.Text = "";
                this.txtTab2_Price.Text = "";
                radioBtnTab2_AC.Checked = false;
                radioBtnTab2_NonAC.Checked = false;
                radioBtnTab2_OptionalSleeper_NO.Checked = false;
                radioBtnTab2_OptionalSleeper_YES.Checked = false;
                checkBox1_Tab2_Amenities_TV.Checked = false;
                checkBox5_Tab2_Amenities_Sofa.Checked = false;
                checkBox2_Tab2_Amenities_4n.Checked = false;
                checkBox4_Tab2_Amenities_Fridge.Checked = false;
                checkBox3_Tab2_Amenities_Wardrobe.Checked = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            myConn.Close();
        }

        
        private void txtTab2_BathRoom_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) || e.KeyChar == 8 || e.KeyChar == 46) //8=backspace, 46=del (allow)
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void txtTab2_Food_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '1' || e.KeyChar == '2' || e.KeyChar == '3' || e.KeyChar == 8 || e.KeyChar == 46)
            {
                    e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void txtTab2_Price_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar) || e.KeyChar== '.' || e.KeyChar == 8 || e.KeyChar == 46) //8=backspace, 46=del (allow)
            {
                TextBox tb = sender as TextBox;
                int cursorPosLeft = tb.SelectionStart;
                int cursorPosRight = tb.SelectionStart + tb.SelectionLength;
                string result = tb.Text.Substring(0, cursorPosLeft) + e.KeyChar + tb.Text.Substring(cursorPosRight);
                string[] parts = result.Split('.');

                if (parts.Length > 1)
                {
                    if (parts[1].Length > 2 || parts.Length > 2)
                    {
                        e.Handled = true;
                    }
                }
            }
            
            else
            {
                e.Handled = true;
            }
        }

        private void cmbTab2_SelectKeywordToSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }




        /*
        * ///////////////////////////////////////////////
        * 3rd TAB
        * Add New Room
        * content
        * Start
        * //////////////////////////////////////////////
        */


        string RoomNoletter = "RNo_";
        //DataTable dbDataset_Tab3;


        void FillWardIDCombo()
        {
            MySqlConnection myConn = new MySqlConnection(myConnection);
            myConn.Open();

            string combo1Query = "select * from itp.ward_category;";
            MySqlCommand cmd = new MySqlCommand(combo1Query, myConn);
            MySqlDataReader myReader;

            try
            {
                myReader = cmd.ExecuteReader();
                cmb_Tab3_wardID.Items.Clear();


                while (myReader.Read())
                {
                    string wID = myReader.GetString("ward_id");
                    cmb_Tab3_wardID.Items.Add(wID);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            myConn.Close();
        }
        

        private void cmb_Tab3_wardID_SelectedIndexChanged(object sender, EventArgs e)
        {
            MySqlConnection myConn = new MySqlConnection(myConnection);
            myConn.Open();

            string wardNameQuery = "select * from itp.ward_category where ward_id='"+cmb_Tab3_wardID.Text+"';";
            MySqlCommand cmd = new MySqlCommand(wardNameQuery, myConn);
            MySqlDataReader myReader;

            try
            {
                myReader = cmd.ExecuteReader();

                while (myReader.Read())
                {
                    string wName = myReader.GetString("ward_name");
                    txt_Tab3_WardName.Text = wName;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            myConn.Close();
        }

        void FillClassTypCombo()
        {
            MySqlConnection myConn = new MySqlConnection(myConnection);
            myConn.Open();

            string combo2Query = "select * from itp.class_type;";
            MySqlCommand cmd = new MySqlCommand(combo2Query, myConn);
            MySqlDataReader myReader;

            try
            {
                myReader = cmd.ExecuteReader();
                cmb_Tab3_classType.Items.Clear();

                while (myReader.Read())
                {
                    string class_typ = myReader.GetString("type");
                    cmb_Tab3_classType.Items.Add(class_typ);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            myConn.Close();
        }

        private void AutoGenerateRoomNo()
        {
            MySqlConnection myConn = new MySqlConnection(myConnection);
            myConn.Open();

            try
            {
                string autogenerateRoomNoQuery = "Select Count(room_no) from itp.room_details;";
                MySqlCommand cmd = new MySqlCommand(autogenerateRoomNoQuery, myConn);
                int i = Convert.ToInt32(cmd.ExecuteScalar());
                int j;

                if (i == 0)
                {
                    i = i + 1;
                    j = i + 100;

                    this.txt_Tab3_RoomNo.Text = RoomNoletter + j.ToString();
                }
                else
                {
                    string lastIDQuery = "SELECT room_no FROM itp.room_details order by room_no desc limit 1;";
                    MySqlCommand cmd1 = new MySqlCommand(lastIDQuery, myConn);

                    string value = (string)cmd1.ExecuteScalar();
                    string s = SearchNum(value);

                    int k = Convert.ToInt32(s);
                    k = k + 1;

                    this.txt_Tab3_RoomNo.Text = RoomNoletter + k.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            myConn.Close();
        }

        private void btn_Tab3_Save_Click(object sender, EventArgs e)
        {
            MySqlConnection myConn = new MySqlConnection(myConnection);
            myConn.Open();

            if (cmb_Tab3_wardID.Text == "" || txt_Tab3_WardName.Text == "" || cmb_Tab3_classType.Text=="" || txt_Tab3_RoomNo.Text=="" || txt_Tab3_NOofBeds.Text=="")
            {
                MessageBox.Show("Please Fill Empty Fields", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            else
            {
                try
                {
                    string saveTab3Query = "INSERT INTO `itp`.`room_details` (`ward_id`, `type`, `room_no`, `no_of_beds`) VALUES('"+this.cmb_Tab3_wardID.Text+"','"+this.cmb_Tab3_classType.Text+"','"+this.txt_Tab3_RoomNo.Text+"','"+this.txt_Tab3_NOofBeds.Text+"');";

                    MySqlCommand cmd = new MySqlCommand(saveTab3Query, myConn);
                    MySqlDataReader myReader;

                    myReader = cmd.ExecuteReader();
                    MessageBox.Show("Record Saved Successfully !!", "Successful Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    this.cmb_Tab3_wardID.SelectedIndex = -1;
                    this.txt_Tab3_WardName.Text = "";
                    this.cmb_Tab3_classType.SelectedIndex = -1;
                    AutoGenerateRoomNo();
                    this.txt_Tab3_NOofBeds.Text = "";

                    while (myReader.Read())
                    {

                    }
                    myConn.Close();
                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "SError Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                auto_load_datagrid_Tab3();
                FillRoomNoCombo();
            }
        }

        private void auto_load_datagrid_Tab3()
        {
            MySqlConnection myConn = new MySqlConnection(myConnection);
            myConn.Open();

            try
            {
                string autoload_Tab3_GridQuery = "select r.ward_id as 'WARD_ID', w.ward_name as 'WARD_NAME',c.type as 'CLASS_TYPE', r.room_no as 'ROOM_NO', r.no_of_beds as 'NO_OF_BEDS' from itp.room_details r, itp.ward_category w, itp.class_type c where w.ward_id=r.ward_id AND c.type=r.type order by room_no;";
                MySqlCommand cmd = new MySqlCommand(autoload_Tab3_GridQuery, myConn);

                MySqlDataAdapter sda = new MySqlDataAdapter();
                sda.SelectCommand = cmd;
                dbDataset = new DataTable();
                sda.Fill(dbDataset);
                BindingSource bSource = new BindingSource();

                bSource.DataSource = dbDataset;
                dataGridView1_Tab3_WardHandling.DataSource = bSource;

                Bitmap img = new Bitmap(Properties.Resources.edit_black_24px);
                btnClickforUpdate_Tab3.Image = img;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            dataGridView1_Tab3_WardHandling.Columns["WARD_ID"].ReadOnly = true;
            dataGridView1_Tab3_WardHandling.Columns["WARD_NAME"].ReadOnly = true;
            dataGridView1_Tab3_WardHandling.Columns["CLASS_TYPE"].ReadOnly = true;
            dataGridView1_Tab3_WardHandling.Columns["ROOM_NO"].ReadOnly = true;
            dataGridView1_Tab3_WardHandling.Columns["NO_OF_BEDS"].ReadOnly = true;

            myConn.Close();
        }

        private void dataGridView1_Tab3_WardHandling_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (this.dataGridView1_Tab3_WardHandling.Rows[e.RowIndex].IsNewRow && e.ColumnIndex == 0)
            {
                e.Value = Properties.Resources.more_24px;
            }
        }

        private void btn_Tab3_update_Click(object sender, EventArgs e)
        {
            MySqlConnection myConn = new MySqlConnection(myConnection);
            myConn.Open();

            if (cmb_Tab3_wardID.Text == "" || txt_Tab3_WardName.Text == "" || cmb_Tab3_classType.Text == "" || txt_Tab3_RoomNo.Text == "" || txt_Tab3_NOofBeds.Text == "")
            {
                MessageBox.Show("Please Fill Empty Fields", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }

            else
            {
                try
                {
                    string updateTab3Query = "UPDATE `itp`.`room_details` SET `ward_id`='"+this.cmb_Tab3_wardID.Text+ "',`type`='"+this.cmb_Tab3_classType.Text+"',`no_of_beds`='" + this.txt_Tab3_NOofBeds.Text+"' WHERE `room_no`='"+this.txt_Tab3_RoomNo.Text+"';";
                    MySqlCommand cmd = new MySqlCommand(updateTab3Query, myConn);
                    MySqlDataReader myReader;


                    myReader = cmd.ExecuteReader();
                    MessageBox.Show("Record Updated Successfully !!", "Successful Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    this.cmb_Tab3_wardID.SelectedIndex = -1;
                    this.txt_Tab3_WardName.Text = "";
                    this.cmb_Tab3_classType.SelectedIndex = -1;
                    AutoGenerateRoomNo();
                    this.txt_Tab3_NOofBeds.Text = "";

                    while (myReader.Read())
                    {

                    }
                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                auto_load_datagrid_Tab3();
                FillRoomNoCombo();
                myConn.Close();
            }
        }

        private void btn_Tab3_refresh_Click(object sender, EventArgs e)
        {
            auto_load_datagrid_Tab3();
        }

        private void dataGridView1_Tab3_WardHandling_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.ColumnIndex == 0)
                {
                    this.cmb_Tab3_wardID.Enabled = true;
                    this.cmb_Tab3_classType.Enabled = true;
                    this.txt_Tab3_NOofBeds.Enabled = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void dataGridView1_Tab3_WardHandling_MouseClick(object sender, MouseEventArgs e)
        {
            this.cmb_Tab3_wardID.Enabled = false;
            this.cmb_Tab3_classType.Enabled = false;
            this.txt_Tab3_NOofBeds.Enabled = false;

            try
            {
                cmb_Tab3_wardID.Text = dataGridView1_Tab3_WardHandling.SelectedRows[0].Cells[1].Value.ToString();
                txt_Tab3_WardName.Text = dataGridView1_Tab3_WardHandling.SelectedRows[0].Cells[2].Value.ToString();
                cmb_Tab3_classType.Text = dataGridView1_Tab3_WardHandling.SelectedRows[0].Cells[3].Value.ToString();
                txt_Tab3_RoomNo.Text = dataGridView1_Tab3_WardHandling.SelectedRows[0].Cells[4].Value.ToString();
                txt_Tab3_NOofBeds.Text = dataGridView1_Tab3_WardHandling.SelectedRows[0].Cells[5].Value.ToString();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btn_Tab3_delete_Click(object sender, EventArgs e)
        {
            MySqlConnection myConn = new MySqlConnection(myConnection);
            myConn.Open();

            if (cmb_Tab3_wardID.Text == "" || txt_Tab3_WardName.Text == "" || cmb_Tab3_classType.Text == "" || txt_Tab3_RoomNo.Text == "" || txt_Tab3_NOofBeds.Text == "")
            {
                MessageBox.Show("Cannot Delete. Fields are Empty", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            
            else
            {
                try
                {
                    string deleteTab3Query = "DELETE FROM `itp`.`room_details` WHERE `room_no`='"+this.txt_Tab3_RoomNo.Text+"';";
                    MySqlCommand cmd = new MySqlCommand(deleteTab3Query, myConn);
                    MySqlDataReader myReader;


                    myReader = cmd.ExecuteReader();
                    MessageBox.Show("Record Deleted Successfully", "Successful Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    this.cmb_Tab3_wardID.SelectedIndex = -1;
                    this.txt_Tab3_WardName.Text = "";
                    this.cmb_Tab3_classType.SelectedIndex = -1;
                    AutoGenerateRoomNo();
                    this.txt_Tab3_NOofBeds.Text = "";

                    while (myReader.Read())
                    {

                    }
                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                auto_load_datagrid_Tab3();
                FillRoomNoCombo();
                myConn.Close();
            }
        }

        private void btn_Tab3_search_Click(object sender, EventArgs e)
        {
            MySqlConnection myConn = new MySqlConnection(myConnection);
            myConn.Open();

            DataView DVSearch_Tab3 = new DataView(dbDataset);

            if (cmb_Tab3_keyWordsToSearch.Text == "")
            {
                MessageBox.Show("Please Select a Category to Search", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            else if (txt_Tab3_wordsToSearch.Text == "")
            {
                MessageBox.Show("Please Input data to Search", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            else
            {
                try
                {
                    if (cmb_Tab3_keyWordsToSearch.Text == "Ward ID")
                    {
                        DVSearch_Tab3.RowFilter = string.Format("WARD_ID LIKE '%{0}%'", txt_Tab3_wordsToSearch.Text);
                        dataGridView1_Tab3_WardHandling.DataSource = DVSearch_Tab3;
                    }

                    else if (cmb_Tab3_keyWordsToSearch.Text == "Ward Name")
                    {
                        DVSearch_Tab3.RowFilter = string.Format("WARD_NAME LIKE '%{0}%'", txt_Tab3_wordsToSearch.Text);
                        dataGridView1_Tab3_WardHandling.DataSource = DVSearch_Tab3;
                    }

                    else if (cmb_Tab3_keyWordsToSearch.Text == "Class Type")
                    {
                        DVSearch_Tab3.RowFilter = string.Format("CLASS_TYPE LIKE '%{0}%'", txt_Tab3_wordsToSearch.Text);
                        dataGridView1_Tab3_WardHandling.DataSource = DVSearch_Tab3;
                    }
                    
                    else if (cmb_Tab3_keyWordsToSearch.Text == "Room Number")
                    {
                        DVSearch_Tab3.RowFilter = string.Format("ROOM_NO LIKE '%{0}%'", txt_Tab3_wordsToSearch.Text);
                        dataGridView1_Tab3_WardHandling.DataSource = DVSearch_Tab3;
                    }

                    else if (cmb_Tab3_keyWordsToSearch.Text == "Number of Beds")
                    {
                        DVSearch_Tab3.RowFilter = string.Format("NO_OF_BEDS LIKE '%{0}%'", txt_Tab3_wordsToSearch.Text);
                        dataGridView1_Tab3_WardHandling.DataSource = DVSearch_Tab3;
                    }
                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                this.txt_Tab3_wordsToSearch.Text = "";
                this.cmb_Tab3_keyWordsToSearch.Text = "";
                myConn.Close();
            }
        }


        private void btn_Tab3_Clear_Click(object sender, EventArgs e)
        {
            MySqlConnection myConn = new MySqlConnection(myConnection);
            myConn.Open();

            try
            {
                this.cmb_Tab3_wardID.SelectedIndex = -1;
                this.txt_Tab3_WardName.Text = "";
                this.cmb_Tab3_classType.SelectedIndex = -1;
                AutoGenerateRoomNo();
                this.txt_Tab3_NOofBeds.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            myConn.Close();
        }

        private void cmb_Tab3_wardID_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void cmb_Tab3_classType_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void txt_Tab3_NOofBeds_KeyPress(object sender, KeyPressEventArgs e)
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
         * 4th TAB
         * Add New Bed
         * content
         * Start
         * //////////////////////////////////////////////
         */


        string bedNoLetter = "BNo_";
        string status;
        //DataTable dbDataset_Tab4;

        void FillRoomNoCombo()
        {
            MySqlConnection myConn = new MySqlConnection(myConnection);
            myConn.Open();

            string combo_Tab4_Query = "select * from itp.room_details;";
            MySqlCommand cmd = new MySqlCommand(combo_Tab4_Query, myConn);
            MySqlDataReader myReader;

            try
            {
                myReader = cmd.ExecuteReader();
                cmb_Tab4_RoomNo.Items.Clear();
                
                while (myReader.Read())
                {
                    string R_no = myReader.GetString("room_no");
                    cmb_Tab4_RoomNo.Items.Add(R_no);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            myConn.Close();
        }

        private void AutoGenerate_BedNo()
        {
            MySqlConnection myConn = new MySqlConnection(myConnection);
            myConn.Open();

            try
            {
                string autogenerateQuery = "Select Count(bed_no) from itp.bed_details where room_no='"+this.cmb_Tab4_RoomNo.Text+"';";
                MySqlCommand cmd = new MySqlCommand(autogenerateQuery, myConn);
                int i = Convert.ToInt32(cmd.ExecuteScalar());
                int j;

                if (i == 0)
                {
                    i = i + 1;
                    j = i + 100;

                    this.txt_Tab4_BedNo.Text = bedNoLetter + j.ToString();
                }
                else
                {
                    string lastNoQuery = "SELECT bed_no FROM itp.bed_details where room_no='"+this.cmb_Tab4_RoomNo.Text+"' order by bed_no desc limit 1;";
                    MySqlCommand cmd1 = new MySqlCommand(lastNoQuery, myConn);

                    string value = (string)cmd1.ExecuteScalar();
                    string s = SearchNum(value);

                    int k = Convert.ToInt32(s);
                    k = k + 1;

                    this.txt_Tab4_BedNo.Text = bedNoLetter + k.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            myConn.Close();
        }

   
        private void cmb_Tab4_RoomNo_SelectedIndexChanged(object sender, EventArgs e)
        {
            AutoGenerate_BedNo();
        }

        private void radioBtn_Tab4_status_Available_CheckedChanged(object sender, EventArgs e)
        {
            status = "Available";
        }

        private void radioBtn_Tab4_status_NotAvailable_CheckedChanged(object sender, EventArgs e)
        {
            status = "Not Available";
        }

        private void btn_Tab4_Save_Click(object sender, EventArgs e)
        {
            MySqlConnection myConn = new MySqlConnection(myConnection);
            myConn.Open();

            string checkBedSumQuery = "select no_of_beds from itp.room_details where room_no='"+this.cmb_Tab4_RoomNo.Text+"';";
            MySqlCommand cmd2 = new MySqlCommand(checkBedSumQuery, myConn);
            int sum = Convert.ToInt32(cmd2.ExecuteScalar());

            string bedCountQuery = "Select Count(bed_no) from itp.bed_details where room_no='"+this.cmb_Tab4_RoomNo.Text+"';";
            MySqlCommand cmd3 = new MySqlCommand(bedCountQuery, myConn);
            int count = Convert.ToInt32(cmd3.ExecuteScalar());

            
            if (cmb_Tab4_RoomNo.Text == "" || txt_Tab4_BedNo.Text == "" )
            {
                MessageBox.Show("Please Fill Empty Fields", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            else if (!radioBtn_Tab4_status_Available.Checked && !radioBtn_Tab4_status_NotAvailable.Checked)
            {
                MessageBox.Show("Please Fill Empty Fields", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            else if(count==sum)
            {
                MessageBox.Show("Cannot Add Another Bed to this Room", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Stop);

                this.cmb_Tab4_RoomNo.SelectedIndex = -1;
                this.txt_Tab4_BedNo.Text = "";
                radioBtn_Tab4_status_Available.Checked = false;
                radioBtn_Tab4_status_NotAvailable.Checked = false;
            }
            else
            {
                try
                {
                    string saveTab4Query = "INSERT INTO `itp`.`bed_details` (`room_no`, `bed_no`, `status`) VALUES ('"+cmb_Tab4_RoomNo.Text+"','"+txt_Tab4_BedNo.Text+"','"+status+"');";
                    MySqlCommand cmd = new MySqlCommand(saveTab4Query, myConn);
                    MySqlDataReader myReader;

                    myReader = cmd.ExecuteReader();
                    MessageBox.Show("Record Saved Successfully !!", "Successful Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    this.cmb_Tab4_RoomNo.SelectedIndex = -1;
                    this.txt_Tab4_BedNo.Text = "";
                    radioBtn_Tab4_status_Available.Checked = false;
                    radioBtn_Tab4_status_NotAvailable.Checked = false;

                    while (myReader.Read())
                    {

                    }
                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "SError Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                auto_load_datagrid_Tab4();
                myConn.Close();
            }
        }

        private void auto_load_datagrid_Tab4()
        {
            MySqlConnection myConn = new MySqlConnection(myConnection);
            myConn.Open();

            try
            {
                string autoloadDataGrid_Tab4_Query = "select w.ward_id as 'WARD_ID', w.ward_name as 'WARD_NAME', c.type as 'CLASS_TYPE', r.room_no as 'ROOM_NO', b.bed_no as 'BED_NO', b.status as 'STATUS' from itp.bed_details b, itp.ward_category w, itp.class_type c, itp.room_details r where w.ward_id=r.ward_id AND c.type=r.type AND r.room_no=b.room_no;";
                MySqlCommand cmd = new MySqlCommand(autoloadDataGrid_Tab4_Query, myConn);

                MySqlDataAdapter sda = new MySqlDataAdapter();
                sda.SelectCommand = cmd;
                dbDataset = new DataTable();
                sda.Fill(dbDataset);
                BindingSource bSource = new BindingSource();

                bSource.DataSource = dbDataset;
                dataGridView1_Tab4_wardHandling.DataSource = bSource;

                Bitmap img = new Bitmap(Properties.Resources.edit_black_24px);
                ClickToUpdate_Tab4.Image = img;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            dataGridView1_Tab4_wardHandling.Columns["WARD_ID"].ReadOnly = true;
            dataGridView1_Tab4_wardHandling.Columns["WARD_NAME"].ReadOnly = true;
            dataGridView1_Tab4_wardHandling.Columns["CLASS_TYPE"].ReadOnly = true;
            dataGridView1_Tab4_wardHandling.Columns["ROOM_NO"].ReadOnly = true;
            dataGridView1_Tab4_wardHandling.Columns["BED_NO"].ReadOnly = true;
            dataGridView1_Tab4_wardHandling.Columns["STATUS"].ReadOnly = true;

            myConn.Close();
        }

        private void dataGridView1_Tab4_wardHandling_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (this.dataGridView1_Tab4_wardHandling.Rows[e.RowIndex].IsNewRow && e.ColumnIndex == 0)
            {
                e.Value = Properties.Resources.more_24px;
            }
        }

        private void btn_Tab4_refresh_Click(object sender, EventArgs e)
        {
            auto_load_datagrid_Tab4();
        }

        private void dataGridView1_Tab4_wardHandling_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }


        private void dataGridView1_Tab4_wardHandling_MouseClick(object sender, MouseEventArgs e)
        {
            this.cmb_Tab4_RoomNo.Enabled = false;            
            this.radioBtn_Tab4_status_Available.Enabled = false;
            this.radioBtn_Tab4_status_NotAvailable.Enabled = false;            

            try
            {
                cmb_Tab4_RoomNo.Text = dataGridView1_Tab4_wardHandling.SelectedRows[0].Cells[4].Value.ToString();
                txt_Tab4_BedNo.Text = dataGridView1_Tab4_wardHandling.SelectedRows[0].Cells[5].Value.ToString();
                
                //status
                string status_value = dataGridView1_Tab4_wardHandling.SelectedRows[0].Cells[6].Value.ToString();
                if (status_value == "Available")
                {
                    radioBtn_Tab4_status_Available.Checked = true;
                }
                else
                {
                    radioBtn_Tab4_status_NotAvailable.Checked = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }


        private void btn_Tab4_delete_Click(object sender, EventArgs e)
        {
            MySqlConnection myConn = new MySqlConnection(myConnection);
            myConn.Open();

            if (cmb_Tab4_RoomNo.Text == "" || txt_Tab4_BedNo.Text == "")
            {
                MessageBox.Show("Please Fill Empty Fields", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            else if (!radioBtn_Tab4_status_Available.Checked && !radioBtn_Tab4_status_NotAvailable.Checked)
            {
                MessageBox.Show("Please Fill Empty Fields", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            else
            {
                try
                {
                    string deleteTab4Query = "DELETE FROM `itp`.`bed_details` WHERE `bed_no`='"+this.txt_Tab4_BedNo.Text+ "' AND `room_no`='"+this.cmb_Tab4_RoomNo.Text+"';";
                    MySqlCommand cmd = new MySqlCommand(deleteTab4Query, myConn);
                    MySqlDataReader myReader;


                    myReader = cmd.ExecuteReader();
                    MessageBox.Show("Record Deleted Successfully", "Successful Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    this.cmb_Tab4_RoomNo.SelectedIndex = -1;
                    this.cmb_Tab4_RoomNo.Enabled = true;
                    this.txt_Tab4_BedNo.Text = "";                  
                    radioBtn_Tab4_status_Available.Checked = false;
                    radioBtn_Tab4_status_Available.Enabled = true;

                    while (myReader.Read())
                    {

                    }
                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }

            auto_load_datagrid_Tab4();
            myConn.Close();
        }


        private void btn_Tab4_Clear_Click(object sender, EventArgs e)
        {
            MySqlConnection myConn = new MySqlConnection(myConnection);
            myConn.Open();

            try
            {
                this.cmb_Tab4_RoomNo.SelectedIndex = -1;
                this.cmb_Tab4_RoomNo.Enabled = true;
                this.txt_Tab4_BedNo.Text = "";
                radioBtn_Tab4_status_Available.Checked = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            myConn.Close();
        }


        private void cmb_Tab4_RoomNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }


    }
}
