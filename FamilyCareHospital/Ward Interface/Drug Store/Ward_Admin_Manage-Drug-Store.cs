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
    public partial class Ward_Admin_Manage_Drug_Store : Form
    {
        public Ward_Admin_Manage_Drug_Store()
        {
            InitializeComponent();
            auto_load_datagrid();
        }

        static string myConnection = "Data Source=localhost; Initial Catalog=itp; port=3306; username=root; password=sagarox";
        //static MySqlConnection myConn = new MySqlConnection(myConnection);


        DataTable dbDataset;



        private void btn_Back_ManaDrugStr_Click(object sender, EventArgs e)
        {
            this.Hide();
            Ward_MainFrame f1 = new Ward_MainFrame();
            f1.ShowDialog();
        }

        private void btn_Save_MangDrugStore_Click(object sender, EventArgs e)
        {
            MySqlConnection myConn = new MySqlConnection(myConnection);
            myConn.Open();

            if (txt_DrugName.Text == "" || txt_Quantity.Text == "" || dateTimePicker1_ManageDrugs.Text == "")
            {
                MessageBox.Show("Please Fill Empty Fields", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }

            else
            {
                try
                {
                    string saveDrugsQuery = "insert into itp.drugs (drug_name,quantity,expiry_date) values('"+this.txt_DrugName.Text+"','"+this.txt_Quantity.Text+"','"+this.dateTimePicker1_ManageDrugs.Text+"');";
                    MySqlCommand cmd = new MySqlCommand(saveDrugsQuery, myConn);
                    MySqlDataReader myReader;

                    myReader = cmd.ExecuteReader();
                    MessageBox.Show("Record Saved Successfully !!", "Successful Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    this.txt_DrugName.Text = "";
                    this.txt_Quantity.Text = "";
                    this.dateTimePicker1_ManageDrugs.Value = DateTime.Now;

                    while (myReader.Read())
                    {

                    }
                    myConn.Close();
                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "SError Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            auto_load_datagrid();
        }

        private void btnClear_Content_MangDrugStore_Click(object sender, EventArgs e)
        {
            this.txt_DrugName.Text = "";
            this.txt_Quantity.Text = "";
            this.dateTimePicker1_ManageDrugs.Value = DateTime.Now;

            this.txt_DrugName.Enabled = true;
            this.txt_Quantity.Enabled = true;
            this.dateTimePicker1_ManageDrugs.Enabled = true;
        }

        private void auto_load_datagrid()
        {
            MySqlConnection myConn = new MySqlConnection(myConnection);
            myConn.Open();

            try
            {
                string autoloadDataGridQuery = "select drug_name as 'DRUG_NAME', quantity as 'QUANTITY', expiry_date as 'EXPIRY_DATE' from itp.drugs;";
                MySqlCommand cmd = new MySqlCommand(autoloadDataGridQuery, myConn);

                MySqlDataAdapter sda = new MySqlDataAdapter();
                sda.SelectCommand = cmd;
                dbDataset = new DataTable();
                sda.Fill(dbDataset);
                BindingSource bSource = new BindingSource();

                bSource.DataSource = dbDataset;
                dataGridView1_MangDrugStore.DataSource = bSource;

                Bitmap img = new Bitmap(Properties.Resources.edit_black_24px);
                btn_clickForUpdate.Image = img;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            myConn.Close();
        }




        
        private void dataGridView1_MangDrugStore_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (this.dataGridView1_MangDrugStore.Rows[e.RowIndex].IsNewRow && e.ColumnIndex == 0)
            {
                e.Value = Properties.Resources.more_24px;
            }
        }

        private void btnUpdate_MangDrugStore_Click(object sender, EventArgs e)
        {
            MySqlConnection myConn = new MySqlConnection(myConnection);
            myConn.Open();

            if (txt_DrugName.Text == "" || txt_Quantity.Text == "" || dateTimePicker1_ManageDrugs.Text == "")
            {
                MessageBox.Show("Cannot Update. Fields are Empty", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            else
            {
                try
                {
                    string updateQuery = "UPDATE `itp`.`drugs` SET `quantity`='"+this.txt_Quantity.Text+"',`expiry_date`='"+this.dateTimePicker1_ManageDrugs.Text+"' WHERE `drug_name`='"+this.txt_DrugName.Text+"';";
                    MySqlCommand cmd = new MySqlCommand(updateQuery, myConn);
                    MySqlDataReader myReader;


                    myReader = cmd.ExecuteReader();
                    MessageBox.Show("Record Updated Successfully !!", "Successful Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    this.txt_DrugName.Text = "";
                    this.txt_Quantity.Text = "";
                    this.dateTimePicker1_ManageDrugs.Value = DateTime.Now;

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
            myConn.Close();
        }

        private void btnRefresh_MangDrugStore_Click(object sender, EventArgs e)
        {
            auto_load_datagrid();
        }

        private void dataGridView1_MangDrugStore_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.ColumnIndex == 0)
                {
                    this.txt_Quantity.Enabled = true;
                    this.dateTimePicker1_ManageDrugs.Enabled = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void dataGridView1_MangDrugStore_MouseClick(object sender, MouseEventArgs e)
        {
            this.txt_DrugName.Enabled = false;
            this.txt_Quantity.Enabled = false;
            this.dateTimePicker1_ManageDrugs.Enabled = false;

            try
            {
                txt_DrugName.Text = dataGridView1_MangDrugStore.SelectedRows[0].Cells[1].Value.ToString();
                txt_Quantity.Text = dataGridView1_MangDrugStore.SelectedRows[0].Cells[2].Value.ToString();
                dateTimePicker1_ManageDrugs.Text = dataGridView1_MangDrugStore.SelectedRows[0].Cells[3].Value.ToString();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }


        private void btnDelete_MangDrugStore_Click(object sender, EventArgs e)
        {
            MySqlConnection myConn = new MySqlConnection(myConnection);
            myConn.Open();

            if (txt_DrugName.Text == "" || txt_Quantity.Text == "" || dateTimePicker1_ManageDrugs.Text == "")
            {
                MessageBox.Show("Cannot Delete. Fields are Empty", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }

            else
            {
                try
                {
                    string deleteDrugQuery = "DELETE FROM `itp`.`drugs` WHERE `drug_name`='"+this.txt_DrugName.Text+"';";
                    MySqlCommand cmd = new MySqlCommand(deleteDrugQuery, myConn);
                    MySqlDataReader myReader;

                    myReader = cmd.ExecuteReader();
                    MessageBox.Show("Record Deleted Successfully", "Successful Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    this.txt_DrugName.Text = "";
                    this.txt_Quantity.Text = "";
                    this.dateTimePicker1_ManageDrugs.Value = DateTime.Now;

                    this.txt_DrugName.Enabled = true;
                    this.txt_Quantity.Enabled = true;
                    this.dateTimePicker1_ManageDrugs.Enabled = true;

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
        }

        private void btnSearch_MangDrugStore_Click(object sender, EventArgs e)
        {
            MySqlConnection myConn = new MySqlConnection(myConnection);
            myConn.Open();

            DataView DVSearch = new DataView(dbDataset);

            if (txtSearchKeyWord_MangDrugStore.Text == "")
            {
                MessageBox.Show("Please Input data to Search", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            else
            {
                try
                {
                        DVSearch.RowFilter = string.Format("DRUG_NAME LIKE '%{0}%'", txtSearchKeyWord_MangDrugStore.Text);
                        dataGridView1_MangDrugStore.DataSource = DVSearch;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                this.txtSearchKeyWord_MangDrugStore.Text = "";
                myConn.Close();
            }
        }

        private void txt_DrugName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) || char.IsNumber(e.KeyChar) || e.KeyChar == 8 || e.KeyChar == '_' || e.KeyChar == ' ' || e.KeyChar == 46) //8=backspace 46=del
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void txt_Quantity_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtSearchKeyWord_MangDrugStore_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) || char.IsNumber(e.KeyChar) || e.KeyChar == 8 || e.KeyChar == '_' || e.KeyChar == ' ' || e.KeyChar == 46) //8=backspace 46=del
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }
    }
}
