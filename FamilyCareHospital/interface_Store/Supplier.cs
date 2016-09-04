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
    public partial class Supplier : Form
    {
        public Supplier()
        {
            InitializeComponent();
            autoGenerateID();
            tableLoad();
            FillCombo();
        }

        static String conn = "datasource=localhost;port=3306;username=root;password=sagarox";
        MySqlConnection mc = new MySqlConnection(conn);


        public void autoGenerateID()
        {
            String McID = "MSUP";
            mc.Open();
            MySqlCommand cmd = new MySqlCommand("select COUNT(SupplierID) from itp.store_suplier_m", mc);
            int i = Convert.ToInt32(cmd.ExecuteScalar());
            i++;
            mc.Close();

            txt_supID.Text = McID + i.ToString();
        }


        public void tableLoad()
        {

            MySqlCommand mcmd = new MySqlCommand("select * from itp.store_suplier_m", mc);

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

        public void FillCombo()
        {
            String query = "select * from itp.store_categorym;";
            MySqlCommand cmd = new MySqlCommand(query, mc);
            MySqlDataReader mr;

            try
            {

                mc.Open();
                mr = cmd.ExecuteReader();

                while (mr.Read())
                {
                    String cn = mr.GetString("CName");
                    comboBox3.Items.Add(cn);
                    comboBox2.Items.Add(cn);


                }

            }
            catch (Exception e)
            {

                MessageBox.Show(e.Message);

            }

            mc.Close();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            if (txt_name.Text != "" && comboBox3.Text != "" && comboBox3.Text != "select")
            {
                String query = "insert into itp.store_suplier_m (SupplierID,Name,Category,Address,Contact_Number,Agent_Name,Agent_Contactnumber) values('"+txt_supID.Text+"','"+txt_name.Text+"','"+comboBox3.Text+"','"+txt_address.Text+"','"+txt_contactnum.Text+"','"+txt_aname.Text+"','"+txt_acn.Text+"');";
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
                txt_address.Clear();
                txt_contactnum.Clear();
                txt_aname.Clear();
                txt_acn.Clear();
                tableLoad();
                autoGenerateID();
            }
            else {
                MessageBox.Show("Invalid Details");

            }
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Do you want to Update ?", "Update", MessageBoxButtons.YesNo);

            if (dialog == DialogResult.Yes)
            {
                if (txt_supID.Text != "" && txt_name.Text != "") {

                    String query = "update itp.store_suplier_m set Name = '" + txt_name.Text + "',Category = '" + comboBox3.Text + "', Address = '" + txt_address.Text + "',Contact_Number ='" + txt_contactnum.Text + "',Agent_Name ='" + txt_aname.Text + "',Agent_Contactnumber ='" + txt_acn.Text + "' where SupplierID = '" + txt_supID.Text + "';";
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
                    txt_address.Clear();
                    txt_contactnum.Clear();
                    txt_aname.Clear();
                    txt_acn.Clear();
                    tableLoad();
                    autoGenerateID();
                }
                else {

                    MessageBox.Show("Invalid Details");

                }
            }
        }

        private void dataGridView1_MouseClick(object sender, MouseEventArgs e)
        {
            txt_supID.Text      = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            txt_name.Text       = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            comboBox3.Text      = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            txt_address.Text    = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
            txt_contactnum.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
            txt_aname.Text      = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();
            txt_acn.Text        = dataGridView1.SelectedRows[0].Cells[6].Value.ToString();
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {

            DialogResult dialog = MessageBox.Show("Do you want to delete ?", "Delete", MessageBoxButtons.YesNo);

            if (dialog == DialogResult.Yes)
            {
                if (txt_supID.Text != "" && txt_name.Text != "")
                {

                    String query = "delete from itp.store_suplier_m  where SupplierID = '" + txt_supID.Text + "';";
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
                    txt_address.Clear();
                    txt_contactnum.Clear();
                    txt_aname.Clear();
                    txt_acn.Clear();
                    tableLoad();
                    autoGenerateID();
                }
                else {

                    MessageBox.Show("Invalid Details");

                }
            }
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            String searchType = comboBox1.Text;
            String searchKey = txt_search.Text;

            if (searchType != "select" && searchType != "")
            {

                if (searchKey != "")
                {


                    if (searchType == "Name")
                    {

                        MySqlCommand mcmd = new MySqlCommand("select * from itp.store_suplier_m where Name = '" + searchKey + "'", mc);

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
                    else if (searchType == "Supplier ID")
                    {

                        MySqlCommand mcmd = new MySqlCommand("select * from itp.store_suplier_m where SupplierID = '" + searchKey + "'", mc);

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

        private void btn_viewall_Click(object sender, EventArgs e)
        {
            tableLoad();
        }

        private void btn_view_Click(object sender, EventArgs e)
        {
            if (comboBox2.Text != "" && comboBox2.Text != "select") {
                MySqlCommand mcmd = new MySqlCommand("select * from itp.store_suplier_m where Category = '" + comboBox2.Text + "'", mc);

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

                MessageBox.Show("please select Category");
            }
        }

        private void txt_name_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != 32)
            {

                e.Handled = true;

            }
            else
            {

                e.Handled = false;


            }

        }

        private void txt_aname_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != 32)
            {

                e.Handled = true;

            }
            else
            {

                e.Handled = false;


            }

        }

        private void txt_contactnum_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {

                e.Handled = true;

            }
            else
            {

                e.Handled = false;


            }
        }

        private void txt_acn_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8)
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
            if (comboBox1.Text == "Supplier ID")
            {

                txt_search.AutoCompleteMode = AutoCompleteMode.Suggest;
                txt_search.AutoCompleteSource = AutoCompleteSource.CustomSource;
                AutoCompleteStringCollection acol = new AutoCompleteStringCollection();

                String query = "select * from itp.store_suplier_m;";
                MySqlCommand cmd = new MySqlCommand(query, mc);
                MySqlDataReader mr;

                try
                {

                    mc.Open();
                    mr = cmd.ExecuteReader();

                    while (mr.Read())
                    {
                        String cn = mr.GetString("SupplierID");
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
            else if (comboBox1.Text == "Name")
            {


                txt_search.AutoCompleteMode = AutoCompleteMode.Suggest;
                txt_search.AutoCompleteSource = AutoCompleteSource.CustomSource;
                AutoCompleteStringCollection acol = new AutoCompleteStringCollection();

                String query = "select * from itp.store_suplier_m;";
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
