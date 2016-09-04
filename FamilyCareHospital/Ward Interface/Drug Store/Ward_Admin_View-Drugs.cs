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
    public partial class Ward_Admin_View_Drugs : Form
    {
        public Ward_Admin_View_Drugs()
        {
            InitializeComponent();
            auto_load_datagrid();
        }

        static string myConnection = "Data Source=localhost; Initial Catalog=itp; port=3306; username=root; password=sagarox";
        //static MySqlConnection myConn = new MySqlConnection(myConnection);

        DataTable dbDataset;


        private void btn_Back_ViewDrugs_Click(object sender, EventArgs e)
        {
            this.Hide();
            Ward_MainFrame f1 = new Ward_MainFrame();
            f1.ShowDialog();
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
                dataGridView1_ViewDrugs.DataSource = bSource;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            myConn.Close();
        }

        private void dataGridView1_ViewDrugs_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            MySqlConnection myConn = new MySqlConnection(myConnection);
            myConn.Open();

            DataView DVSearch = new DataView(dbDataset);

            if (cmb_search.Text == "")
            {
                MessageBox.Show("Please Select a Category to Search", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            else if (txt_search.Text == "")
            {
                MessageBox.Show("Please Input data to Search", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            else
            {
                try
                {
                    if (cmb_search.Text == "Drug Name")
                    {
                        DVSearch.RowFilter = string.Format("DRUG_NAME LIKE '%{0}%'", txt_search.Text);
                        dataGridView1_ViewDrugs.DataSource = DVSearch;
                    }

                    else if (cmb_search.Text == "Quantity")
                    {
                        DVSearch.RowFilter = string.Format("QUANTITY LIKE '%{0}%'", txt_search.Text);
                        dataGridView1_ViewDrugs.DataSource = DVSearch;
                    }

                    else if (cmb_search.Text == "Expiry Date")
                    {
                        DVSearch.RowFilter = string.Format("FLOOR EXPIRY_DATE '%{0}%'", txt_search.Text);
                        dataGridView1_ViewDrugs.DataSource = DVSearch;
                    }
                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                this.txt_search.Text = "";
                this.cmb_search.Text = "";
                myConn.Close();
            }
        }

        private void dataGridView1_ViewDrugs_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                txt_DrugName.Text = dataGridView1_ViewDrugs.SelectedRows[0].Cells[0].Value.ToString();
                txt_Quantity.Text = dataGridView1_ViewDrugs.SelectedRows[0].Cells[1].Value.ToString();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btn_Prin_ViewDrugs_Click(object sender, EventArgs e)
        {
            //print button
        }

        private void cmb_search_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void txt_search_KeyPress(object sender, KeyPressEventArgs e)
        {
        }
    }
}
