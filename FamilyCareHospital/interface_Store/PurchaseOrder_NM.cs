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
    public partial class PurchaseOrder_NM : Form
    {
        public PurchaseOrder_NM()
        {
            InitializeComponent();
            tableLoad();
            autoGenerateID();
            FillCombo();
        }


        static String conn = "datasource=localhost;port=3306;username=root;password=sagarox";
        MySqlConnection mc = new MySqlConnection(conn);

        public void autoGenerateID()
        {
            String poID = "NMPO";
            mc.Open();
            MySqlCommand cmd = new MySqlCommand("select COUNT( distinct OrderID ) from itp.store_order_nm", mc);
            int i = Convert.ToInt32(cmd.ExecuteScalar());
            i++;
            mc.Close();

            txt_order.Text = poID + i.ToString();
        }

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

            MySqlCommand mcmd = new MySqlCommand("select * from itp.store_order_nm", mc);

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
            if (txt_Qn.Text != "" && txt_supplier.Text != "" && txt_name.Text != "")
            {
                String query = "insert into itp.store_order_nm (OrderID,Name,Category,Quantity,SupplierID,Entry_Date) values('" + txt_order.Text + "','" + txt_name.Text + "','" + comboBox1.Text + "','" + txt_Qn.Text + "','" + txt_supplier.Text + "','" + dateTimePicker1.Text + "');";
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
                txt_Qn.Clear();
                txt_supplier.Clear();
                tableLoad();
            }
            else
            {

                MessageBox.Show("Invalid Details");

            }
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Do you want to Update ?", "Update", MessageBoxButtons.YesNo);

            if (dialog == DialogResult.Yes)
            {

                if (txt_Qn.Text != "" && txt_order.Text != "" && txt_name.Text != "")
                {
                    String query = "update itp.store_order_nm set  Category = '" + comboBox1.Text + "', Quantity ='" + txt_Qn.Text + "', SupplierID ='" + txt_supplier.Text + "', Entry_Date = '" + dateTimePicker1.Text + "' where OrderID='" + txt_order.Text + "' and Name='" + txt_name.Text + "' ;";
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
                    txt_Qn.Clear();
                    txt_supplier.Clear();
                    tableLoad();

                }
                else
                {

                    MessageBox.Show("Invalid Details");

                }
            }
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Do you want to Delete ?", "Delete", MessageBoxButtons.YesNo);

            if (dialog == DialogResult.Yes)
            {

                if (txt_order.Text != "" && txt_name.Text != "")
                {
                    String query = "delete from itp.store_order_nm where OrderID = '" + txt_order.Text + "' and Name = '" + txt_name.Text + "';";
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
                    txt_Qn.Clear();
                    txt_supplier.Clear();
                    tableLoad();
                }
                else
                {

                    MessageBox.Show("invalid details");

                }
            }
        }

        private void btn_NO_Click(object sender, EventArgs e)
        {
            autoGenerateID();
        }

        private void btn_editSatus_Click(object sender, EventArgs e)
        {
            if (txt_order.Text != "" && txt_name.Text != "")
            {
                String query = "update itp.store_order_nm set Current_Status = '" + comboBox3.Text + "', Receive_Date = '" + dateTimePicker2.Text + "', Payment_Status ='" + comboBox4.Text + "', Return_status ='" + comboBox5.Text + "', Entry_Date = '" + dateTimePicker1.Text + "' where OrderID='" + txt_order.Text + "' and Name='" + txt_name.Text + "' ;";
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
                txt_Qn.Clear();
                txt_supplier.Clear();
                tableLoad();
            }
            else {

                MessageBox.Show("invalid details");

            }
        }

        private void dataGridView1_MouseClick(object sender, MouseEventArgs e)
        {
            txt_order.Text       = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            txt_name.Text        = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            comboBox1.Text       = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            txt_Qn.Text          = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
            txt_supplier.Text    = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
            dateTimePicker1.Text = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();
            comboBox3.Text       = dataGridView1.SelectedRows[0].Cells[6].Value.ToString();
            dateTimePicker2.Text = dataGridView1.SelectedRows[0].Cells[7].Value.ToString();
            comboBox4.Text       = dataGridView1.SelectedRows[0].Cells[8].Value.ToString();
            comboBox5.Text       = dataGridView1.SelectedRows[0].Cells[9].Value.ToString();
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            String searchType = comboBox2.Text;
            String searchKey = txt_search.Text;

            if (searchType != "select" && searchType != "")
            {

                if (searchKey != "")
                {


                    if (searchType == "Name")
                    {

                        MySqlCommand mcmd = new MySqlCommand("select * from itp.store_order_nm where Name = '" + searchKey + "'", mc);

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
                    else if (searchType == "OrderID")
                    {

                        MySqlCommand mcmd = new MySqlCommand("select * from itp.store_order_nm where OrderID = '" + searchKey + "'", mc);

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

        private void txt_name_MouseClick(object sender, MouseEventArgs e)
        {
            txt_name.AutoCompleteMode = AutoCompleteMode.Suggest;
            txt_name.AutoCompleteSource = AutoCompleteSource.CustomSource;
            AutoCompleteStringCollection acol = new AutoCompleteStringCollection();

            String query = "select * from itp.store_item_nm;";
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
            txt_name.AutoCompleteCustomSource = acol;
            mc.Close();
        }

        private void txt_supplier_MouseClick(object sender, MouseEventArgs e)
        {
            txt_supplier.AutoCompleteMode = AutoCompleteMode.Suggest;
            txt_supplier.AutoCompleteSource = AutoCompleteSource.CustomSource;
            AutoCompleteStringCollection acol = new AutoCompleteStringCollection();

            String query = "select * from itp.store_suplier_nm;";
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
            txt_supplier.AutoCompleteCustomSource = acol;
            mc.Close();
        }

        private void txt_search_MouseClick(object sender, MouseEventArgs e)
        {
            if (comboBox2.Text == "OrderID")
            {

                txt_search.AutoCompleteMode = AutoCompleteMode.Suggest;
                txt_search.AutoCompleteSource = AutoCompleteSource.CustomSource;
                AutoCompleteStringCollection acol = new AutoCompleteStringCollection();

                String query = "select * from itp.store_order_nm;";
                MySqlCommand cmd = new MySqlCommand(query, mc);
                MySqlDataReader mr;

                try
                {

                    mc.Open();
                    mr = cmd.ExecuteReader();

                    while (mr.Read())
                    {
                        String cn = mr.GetString("OrderID");
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

                String query = "select * from itp.store_order_nm;";
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

        private void txt_name_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && e.KeyChar != 8)
            {

                e.Handled = true;

            }
            else
            {

                e.Handled = false;


            }
        }

        private void txt_Qn_KeyPress(object sender, KeyPressEventArgs e)
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

        private void btn_viewAll_Click(object sender, EventArgs e)
        {
            tableLoad();
        }

        private void btn_payment_Click(object sender, EventArgs e)
        {
            Payment_NM p = new Payment_NM();
            p.Show();
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            StoreMain sm = new StoreMain();
            sm.Show();
            this.Close();
        }
    }
}
