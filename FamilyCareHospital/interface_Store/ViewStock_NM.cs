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
    public partial class ViewStock_NM : Form
    {
        public ViewStock_NM()
        {
            InitializeComponent();
            tableLoad();
            FillCombo();
        }

        static String conn = "datasource=localhost;port=3306;username=root;password=sagarox";
        MySqlConnection mc = new MySqlConnection(conn);

        public void FillCombo()
        {
            String query = "select * from itp.store_category_nm;";
            MySqlCommand cmd = new MySqlCommand(query, mc);
            MySqlDataReader mr;

            try
            {

                mc.Open();
                mr = cmd.ExecuteReader();

                while (mr.Read())
                {
                    String cn = mr.GetString("CName");
                    comboBox1.Items.Add(cn);



                }

            }
            catch (Exception e)
            {

                MessageBox.Show(e.Message);

            }

            mc.Close();
        }

        public void tableLoad()
        {

            MySqlCommand mcmd = new MySqlCommand("select * from itp.store_item_nm", mc);

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
        private void btn_viewAll_Click(object sender, EventArgs e)
        {
            tableLoad();
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            String searchType = comboBox2.Text;
            String searchKey = txt_search.Text;

            if (searchType != "select" && searchType != "")
            {

                if (searchKey != "")
                {

                    if (searchType == "ItemID")
                    {

                        MySqlCommand mcmd = new MySqlCommand("select * from itp.store_item_nm where ItemID = '" + searchKey + "'", mc);

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
                    else if (searchType == "Name")
                    {

                        MySqlCommand mcmd = new MySqlCommand("select * from itp.store_item_nm where Name = '" + searchKey + "'", mc);

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
                    else if (searchType == "Batch Number")
                    {

                        MySqlCommand mcmd = new MySqlCommand("select * from itp.store_item_nm where Batch_Number = '" + searchKey + "'", mc);

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
                    else
                    {

                        MessageBox.Show("invalid Search Type");

                    }



                }
                else
                {

                    MessageBox.Show("Please Enter Keyword ");

                }


            }
            else
            {


                MessageBox.Show("Please select type");

            }
        }

        private void btn_view_Click(object sender, EventArgs e)
        {
            String cat = comboBox1.Text;
            if (cat != "select" && cat != "")
            {

                MySqlCommand mcmd = new MySqlCommand("select * from itp.store_item_nm where Category = '" + cat + "'", mc);

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

            else
            {

                MessageBox.Show("Please select Category");
            }
        }

        private void btn_expierItem_Click(object sender, EventArgs e)
        {
            MySqlCommand mcmd = new MySqlCommand("select * from itp.store_item_nm where Expier_Date between '" + dateTimePicker1.Text + "' and '" + dateTimePicker2.Text + "'", mc);

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

        private void btn_LQI_Click(object sender, EventArgs e)
        {
            MySqlCommand mcmd = new MySqlCommand("select * from itp.store_item_nm where Quantity < 10", mc);

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

        private void btn_OSI_Click(object sender, EventArgs e)
        {
            MySqlCommand mcmd = new MySqlCommand("select * from itp.store_item_nm where Quantity = 0", mc);

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

        private void txt_search_MouseClick(object sender, MouseEventArgs e)
        {
            if (comboBox2.Text == "ItemID")
            {

                txt_search.AutoCompleteMode = AutoCompleteMode.Suggest;
                txt_search.AutoCompleteSource = AutoCompleteSource.CustomSource;
                AutoCompleteStringCollection acol = new AutoCompleteStringCollection();

                String query = "select * from itp.store_item_nm ;";
                MySqlCommand cmd = new MySqlCommand(query, mc);
                MySqlDataReader mr;

                try
                {

                    mc.Open();
                    mr = cmd.ExecuteReader();

                    while (mr.Read())
                    {
                        String cn = mr.GetString("ItemID");
                        acol.Add(cn);



                    }

                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);

                }
                txt_search.AutoCompleteCustomSource = acol;
                mc.Close();


            }
            else if (comboBox2.Text == "Name")
            {


                txt_search.AutoCompleteMode = AutoCompleteMode.Suggest;
                txt_search.AutoCompleteSource = AutoCompleteSource.CustomSource;
                AutoCompleteStringCollection acol = new AutoCompleteStringCollection();

                String query = "select * from itp.store_item_nm ;";
                MySqlCommand cmd = new MySqlCommand(query, mc);
                MySqlDataReader mr;

                try
                {

                    mc.Open();
                    mr = cmd.ExecuteReader();

                    while (mr.Read())
                    {
                        String cn = mr.GetString("Name");
                        acol.Add(cn);



                    }

                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);

                }
                txt_search.AutoCompleteCustomSource = acol;
                mc.Close();

            }

            else if (comboBox2.Text == "Batch Number")
            {


                txt_search.AutoCompleteMode = AutoCompleteMode.Suggest;
                txt_search.AutoCompleteSource = AutoCompleteSource.CustomSource;
                AutoCompleteStringCollection acol = new AutoCompleteStringCollection();

                String query = "select * from itp.store_item_nm ;";
                MySqlCommand cmd = new MySqlCommand(query, mc);
                MySqlDataReader mr;

                try
                {

                    mc.Open();
                    mr = cmd.ExecuteReader();

                    while (mr.Read())
                    {
                        String cn = mr.GetString("Batch_Number");
                        acol.Add(cn);



                    }

                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);

                }
                txt_search.AutoCompleteCustomSource = acol;
                mc.Close();

            }
            else
            {

                MessageBox.Show("Please select type");


            }
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            StoreMain sm = new StoreMain();
            sm.Show();
            this.Close();
        }
    }
}
