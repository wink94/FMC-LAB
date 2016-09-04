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
    public partial class ManageStock : Form
    {
        public ManageStock()
        {
            InitializeComponent();
            autoGenerateID();
            FillCombo();
            tableLoad();
        }

        static String conn = "datasource=localhost;port=3306;username=root;password=sagarox";
        MySqlConnection mc = new MySqlConnection(conn);

        public void autoGenerateID()
        {
            String McID = "MSI";
            mc.Open();
            MySqlCommand cmd = new MySqlCommand("select COUNT(distinct ItemID) from itp.store_item", mc);
            int i = Convert.ToInt32(cmd.ExecuteScalar());
            i++;
            mc.Close();

           txt_itemID.Text = McID + i.ToString();
        }

        public void FillCombo()
        {
            String query = "select * from itp.store_categorym;";
            MySqlCommand cmd = new MySqlCommand(query,mc);
            MySqlDataReader mr;

            try {

                mc.Open();
                mr = cmd.ExecuteReader();

                while (mr.Read())
                {
                    String cn = mr.GetString("CName");
                    comboBox1.Items.Add(cn);
                    comboBox3.Items.Add(cn);


                }

            } catch(Exception e) {

                MessageBox.Show(e.Message);

            }

            mc.Close();
        }

        public void tableLoad()
        {

            MySqlCommand mcmd = new MySqlCommand("select * from itp.store_item", mc);

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

        private void btn_add_Click(object sender, EventArgs e)
        {
            if (txt_name.Text != "" && txt_BN.Text != "")
            {
                String query = "insert into itp.store_item (ItemID,Name,Category,Batch_Number,Manufactuer,Entry_Date,Production_Date,Expier_Date,Quantity,Unit_Price)  values('" + txt_itemID.Text + "','" + txt_name.Text + "','" + comboBox1.Text + "','" + txt_BN.Text + "','" + txt_M.Text + "','" + dtp_Entry.Text + "','" + dtp_Pro.Text + "','" + dtp_expier.Text + "','" + txt_Qn.Text + "','" + txt_UP.Text + "');";
                MySqlCommand cmd = new MySqlCommand(query, mc);
                MySqlDataReader mr;

                try
                {
                    mc.Open();
                    mr = cmd.ExecuteReader();

                    MessageBox.Show("saved");
                    while (mr.Read())
                    {

                    }


                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);

                }
                mc.Close();
                txt_name.Clear();
                txt_BN.Clear();
                txt_M.Clear();
                txt_Qn.Clear();
                txt_UP.Clear();
                tableLoad();
                autoGenerateID();
            }
            else {

                MessageBox.Show("Invalid details");
            }
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Do you want to Update ?", "Update", MessageBoxButtons.YesNo);

            if (dialog == DialogResult.Yes)
            {

                if (txt_name.Text != "" && txt_itemID.Text != "" && txt_BN.Text != "")
                {
                    String query = "update itp.store_item set Name = '" + txt_name.Text + "',Category ='" + comboBox1.Text + "',Batch_Number ='" + txt_BN.Text + "',Manufactuer ='" + txt_M.Text + "',Entry_Date = '" + dtp_Entry.Text + "',Production_Date = '" + dtp_Pro.Text + "',Expier_Date = '" + dtp_expier.Text + "',Quantity = '" + txt_Qn.Text + "',Unit_Price = '" + txt_UP.Text + "' where ItemID = '" + txt_itemID.Text + "' and Expier_Date = '" + dtp_expier.Text + "' and Batch_Number ='" + txt_BN.Text + "';";
                    MySqlCommand cmd = new MySqlCommand(query, mc);
                    MySqlDataReader mr;

                    try
                    {
                        mc.Open();
                        mr = cmd.ExecuteReader();

                        MessageBox.Show("Updated");
                        while (mr.Read())
                        {

                        }


                    }
                    catch (Exception ex)
                    {

                        MessageBox.Show(ex.Message);

                    }
                    mc.Close();
                    txt_name.Clear();
                    txt_BN.Clear();
                    txt_M.Clear();
                    txt_Qn.Clear();
                    txt_UP.Clear();
                    tableLoad();
                    autoGenerateID();
                }
                else
                {

                    MessageBox.Show("Invalid Details");

                }
            }
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Do you want to delete ?", "Delete", MessageBoxButtons.YesNo);

            if (dialog == DialogResult.Yes)
            {

                if (txt_itemID.Text != "" && txt_BN.Text != "")
                {
                    String query = "delete from itp.store_item  where ItemID = '" + txt_itemID.Text + "' and Expier_Date = '" + dtp_expier.Text + "' and Batch_Number ='" + txt_BN.Text + "';";
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
                    txt_name.Clear();
                    txt_BN.Clear();
                    txt_M.Clear();
                    txt_Qn.Clear();
                    txt_UP.Clear();
                    tableLoad();
                    autoGenerateID();

                }
                else
                {
                    MessageBox.Show("Invalid details");

                }
            }
        }

        private void dataGridView1_MouseClick(object sender, MouseEventArgs e)
        {
            txt_itemID.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            txt_name.Text   = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            comboBox1.Text  = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            txt_BN.Text     = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
            txt_M.Text      = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
            dtp_Entry.Text  = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();
            dtp_Pro.Text    = dataGridView1.SelectedRows[0].Cells[6].Value.ToString();
            dtp_expier.Text = dataGridView1.SelectedRows[0].Cells[7].Value.ToString();
            txt_Qn.Text     = dataGridView1.SelectedRows[0].Cells[8].Value.ToString();
            txt_UP.Text     = dataGridView1.SelectedRows[0].Cells[9].Value.ToString();
        }

        private void btn_view_Click(object sender, EventArgs e)
        {
            String cat = comboBox3.Text;

            if (cat != "select" && cat != "")
            {

                MySqlCommand mcmd = new MySqlCommand("select * from itp.store_item where Category = '"+cat+"'", mc);

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

            else {

                MessageBox.Show("Please select Category");
            }
        }

        private void btn_viewAll_Click(object sender, EventArgs e)
        {
            tableLoad();
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            String searchType = comboBox2.Text;
            String searchKey = txt_search.Text;

            if (searchType != "select" && searchType != "") {

                if (searchKey != "") {

                    if (searchType == "ItemID") {

                        MySqlCommand mcmd = new MySqlCommand("select * from itp.store_item where ItemID = '" + searchKey + "'", mc);

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

                    } else if (searchType == "Name") {

                        MySqlCommand mcmd = new MySqlCommand("select * from itp.store_item where Name = '" + searchKey + "'", mc);

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

                    } else if (searchType == "Batch Number") {

                        MySqlCommand mcmd = new MySqlCommand("select * from itp.store_item where Batch_Number = '" + searchKey + "'", mc);

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

                        MessageBox.Show("invalid Search Type");

                    }



                } else {

                    MessageBox.Show("Please Enter Keyword ");

                }


            } else {


                MessageBox.Show("Please select type");

            }
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            StoreMain sm = new StoreMain();
            sm.Show();
            this.Close();
        }

        private void txt_name_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != 32) {

                e.Handled = true;

            } else {

                e.Handled = false;


            }
            
        }

        private void txt_Qn_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8 )
            {

                e.Handled = true;

            }
            else
            {

                e.Handled = false;


            }
        }

        private void txt_UP_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8 && e.KeyChar !=46)
            {

                e.Handled = true;

            }
            else
            {

                e.Handled = false;


            }
        }

        private void txt_search_MouseClick(object sender, MouseEventArgs e)
        {
            if (comboBox2.Text == "ItemID")
            {

                txt_search.AutoCompleteMode = AutoCompleteMode.Suggest;
                txt_search.AutoCompleteSource = AutoCompleteSource.CustomSource;
                AutoCompleteStringCollection acol = new AutoCompleteStringCollection();

                String query = "select * from itp.store_item ;";
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

                String query = "select * from itp.store_item ;";
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

                String query = "select * from itp.store_item ;";
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
    }
}
