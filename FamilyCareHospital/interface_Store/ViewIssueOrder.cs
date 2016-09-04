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

namespace FamilyCareHospital
{
    public partial class ViewIssueOrder : Form
    {
        public ViewIssueOrder()
        {
            InitializeComponent();
            tableLoad();
        }

        static String conn = "datasource=localhost;port=3306;username=root;password=sagarox";
        MySqlConnection mc = new MySqlConnection(conn);


        public void tableLoad()
        {

            MySqlCommand mcmd = new MySqlCommand("select * from itp.store_issueorder_m", mc);

            try
            {
                mc.Open();
                MySqlDataAdapter mda = new MySqlDataAdapter();
                mda.SelectCommand = mcmd;
                DataTable dt = new DataTable();
                mda.Fill(dt);
                //  BindingSource bs = new BindingSource();
                // bs.DataSource = dt;
                dataGridView1.DataSource = dt;
                // mda.Update(dt);



            }
            catch (Exception ex)
            {


                MessageBox.Show(ex.Message);
            }
            mc.Close();
        }

        private void btn_viewall_Click(object sender, EventArgs e)
        {
            tableLoad();
        }

        private void txt_search_MouseClick(object sender, MouseEventArgs e)
        {
            if (comboBox1.Text == "Issue Order ID") {

                txt_search.AutoCompleteMode = AutoCompleteMode.Suggest;
                txt_search.AutoCompleteSource = AutoCompleteSource.CustomSource;
                AutoCompleteStringCollection acol = new AutoCompleteStringCollection();

                String query = "select * from itp.store_issueorder_m;";
                MySqlCommand cmd = new MySqlCommand(query, mc);
                MySqlDataReader mr;

                try
                {

                    mc.Open();
                    mr = cmd.ExecuteReader();

                    while (mr.Read())
                    {
                        String cn = mr.GetString("Issue_Order_ID");
                        acol.Add(cn);



                    }

                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);

                }
                txt_search.AutoCompleteCustomSource = acol;
                mc.Close();


            } else if (comboBox1.Text == "Department") {




            }
            else {

                MessageBox.Show("Please select type");


            }
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text == "Issue Order ID") {

                MySqlCommand mcmd = new MySqlCommand("select * from itp.store_issueorder_m where Issue_Order_ID = '"+txt_search.Text+"' ", mc);

                try
                {
                    mc.Open();
                    MySqlDataAdapter mda = new MySqlDataAdapter();
                    mda.SelectCommand = mcmd;
                    DataTable dt = new DataTable();
                    mda.Fill(dt);
                    //  BindingSource bs = new BindingSource();
                    // bs.DataSource = dt;
                    dataGridView1.DataSource = dt;
                    // mda.Update(dt);



                }
                catch (Exception ex)
                {


                    MessageBox.Show(ex.Message);
                }
                mc.Close();


            } else if(comboBox1.Text == "Department")
            {
                MySqlCommand mcmd = new MySqlCommand("select * from itp.store_issueorder_m where Department = '" + txt_search.Text + "' ", mc);

                try
                {
                    mc.Open();
                    MySqlDataAdapter mda = new MySqlDataAdapter();
                    mda.SelectCommand = mcmd;
                    DataTable dt = new DataTable();
                    mda.Fill(dt);
                    //  BindingSource bs = new BindingSource();
                    // bs.DataSource = dt;
                    dataGridView1.DataSource = dt;
                    // mda.Update(dt);



                }
                catch (Exception ex)
                {


                    MessageBox.Show(ex.Message);
                }
                mc.Close();

            } else {

                MessageBox.Show("Invalid Search Type");
            }
        }

        private void btn_issueo_Click(object sender, EventArgs e)
        {
            MySqlCommand mcmd = new MySqlCommand("select * from itp.store_issueorder_m where Entry_Date = '" + dateTimePicker1.Text + "' ", mc);

            try
            {
                mc.Open();
                MySqlDataAdapter mda = new MySqlDataAdapter();
                mda.SelectCommand = mcmd;
                DataTable dt = new DataTable();
                mda.Fill(dt);
                //  BindingSource bs = new BindingSource();
                // bs.DataSource = dt;
                dataGridView1.DataSource = dt;
                // mda.Update(dt);



            }
            catch (Exception ex)
            {


                MessageBox.Show(ex.Message);
            }
            mc.Close();
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            StoreMain sm = new StoreMain();
            sm.Show();
            this.Close();
        }

        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            dataGridView1.Rows[e.RowIndex].Cells[0].Value = "Remove";
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Do you want to Remove ?", "Remove", MessageBoxButtons.YesNo);

            if (dialog == DialogResult.Yes)
            {

                if (e.ColumnIndex == 0)
                {
                    String issue_o_id;
                    String dept;
                    String item_id;
                    String bn;
                    

                     int rowIndex = dataGridView1.CurrentCell.RowIndex;

                    DataGridViewRow row = dataGridView1.Rows[rowIndex];
                    issue_o_id = row.Cells[1].Value.ToString();
                    dept = row.Cells[2].Value.ToString();
                    item_id = row.Cells[4].Value.ToString();
                    bn = row.Cells[6].Value.ToString();
                   
                    

                    String query = "delete from itp.store_issueorder_m where Issue_Order_ID = '" + issue_o_id + "' and Department = '"+dept+ "' and ItemID = '"+item_id+ "' and Batch_Number = '"+bn+ "'  ;";
                    MySqlCommand cmd = new MySqlCommand(query, mc);
                    MySqlDataReader mr;

                    try
                    {
                        mc.Open();
                        mr = cmd.ExecuteReader();

                        MessageBox.Show("Deleted");
                        while (mr.Read())
                        {

                        }


                    }
                    catch (Exception ex)
                    {

                        MessageBox.Show(ex.Message);

                    }
                    mc.Close();
                    

                    dataGridView1.Rows.RemoveAt(rowIndex);

                    tableLoad();
                }
            }
        }

        private void btn_removeall_Click(object sender, EventArgs e)
        {
            if (txt_id.Text != "")
            {
                DialogResult dialog = MessageBox.Show("Do you want to Remove All Details " + txt_id.Text + " ? ", "Update", MessageBoxButtons.YesNo);

                if (dialog == DialogResult.Yes)
                {

                    String query = "delete from itp.store_issueorder_m where Issue_Order_ID = '" + txt_id.Text + "'   ;";
                    MySqlCommand cmd = new MySqlCommand(query, mc);
                    MySqlDataReader mr;

                    try
                    {
                        mc.Open();
                        mr = cmd.ExecuteReader();

                        MessageBox.Show("Deleted");
                        while (mr.Read())
                        {

                        }


                    }
                    catch (Exception ex)
                    {

                        MessageBox.Show(ex.Message);

                    }
                    mc.Close();




                    tableLoad();

                }
            }
            else {

                MessageBox.Show("please Enter ID");

            }
            }

        private void txt_id_MouseClick(object sender, MouseEventArgs e)
        {
           txt_id.AutoCompleteMode = AutoCompleteMode.Suggest;
            txt_id.AutoCompleteSource = AutoCompleteSource.CustomSource;
            AutoCompleteStringCollection acol = new AutoCompleteStringCollection();

            String query = "select * from itp.store_issueorder_m;";
            MySqlCommand cmd = new MySqlCommand(query, mc);
            MySqlDataReader mr;

            try
            {

                mc.Open();
                mr = cmd.ExecuteReader();

                while (mr.Read())
                {
                    String cn = mr.GetString("Issue_Order_ID");
                    acol.Add(cn);



                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);

            }
            txt_id.AutoCompleteCustomSource = acol;
            mc.Close();
        }
    }
}
