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
    public partial class Payment : Form
    {
        public Payment()
        {
            InitializeComponent();
            autoGenerateID();
            tableLoad();
        }

        static String conn = "datasource=localhost;port=3306;username=root;password=sagarox";
        MySqlConnection mc = new MySqlConnection(conn);


        public void autoGenerateID()
        {
            String McID = "MSP";
            mc.Open();
            MySqlCommand cmd = new MySqlCommand("select COUNT(Payment_ID) from itp.store_payment_m", mc);
            int i = Convert.ToInt32(cmd.ExecuteScalar());
            i++;
            mc.Close();
            txt_pid.Text = McID + i.ToString();
        }


        public void tableLoad()
        {

            MySqlCommand mcmd = new MySqlCommand("select * from itp.store_payment_m", mc);

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
            if (comboBox1.Text != "" && comboBox1.Text != "select" && txt_sid.Text != "" && txt_oid.Text != "") {

                String query = "insert into itp.store_payment_m(Payment_ID,Order_ID,Supplier_ID,Entry_Date,Payment_Amount,Payment_Type) values('" + txt_pid.Text + "','" + txt_oid.Text + "','"+txt_sid.Text+"','"+dateTimePicker1.Text+"','"+txt_pa.Text+"','"+comboBox1.Text+"');";
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
                txt_oid.Clear();
                txt_sid.Clear();
                txt_pa.Clear();
                tableLoad();
                autoGenerateID();

            } else {

                MessageBox.Show("Invalid Details");

            }




        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Do you want to Update ?", "Update", MessageBoxButtons.YesNo);

            if (dialog == DialogResult.Yes)
            {

                if (comboBox1.Text != "" && comboBox1.Text != "select" && txt_sid.Text != "" && txt_oid.Text != "")
                {

                    String query = "update itp.store_payment_m set Order_ID= '" + txt_oid.Text + "', Supplier_ID = '" + txt_sid.Text + "', Entry_Date = '" + dateTimePicker1.Text + "', Payment_Amount =  '" + txt_pa.Text + "',Payment_Type = '" + comboBox1.Text + "'  where Payment_ID = '" + txt_pid.Text + "';";
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
                    txt_oid.Clear();
                    txt_sid.Clear();
                    txt_pa.Clear();
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
            txt_pid.Text         = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            txt_oid.Text         = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            txt_sid.Text         = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            dateTimePicker1.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
            txt_pa.Text          = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
            comboBox1.Text       = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Do you want to delete ?","Delete",MessageBoxButtons.YesNo);

            if (dialog == DialogResult.Yes) {
                if (txt_pid.Text != "") {

                    String query = "delete from itp.store_payment_m  where Payment_ID = '" + txt_pid.Text + "';";
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
                    txt_oid.Clear();
                    txt_sid.Clear();
                    txt_pa.Clear();
                    tableLoad();
                    autoGenerateID();

                } else {

                    MessageBox.Show("Please enter Payment ID");

                }

            } 


             

        }

        private void txt_search_MouseClick(object sender, MouseEventArgs e)
        {
            if (comboBox2.Text == "Payment ID")
            {

                txt_search.AutoCompleteMode = AutoCompleteMode.Suggest;
                txt_search.AutoCompleteSource = AutoCompleteSource.CustomSource;
                AutoCompleteStringCollection acol = new AutoCompleteStringCollection();

                String query = "select * from itp.store_payment_m ;";
                MySqlCommand cmd = new MySqlCommand(query, mc);
                MySqlDataReader mr;

                try
                {

                    mc.Open();
                    mr = cmd.ExecuteReader();

                    while (mr.Read())
                    {
                        String cn = mr.GetString("Payment_ID");
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
            else if (comboBox2.Text == "Order ID")
            {


                txt_search.AutoCompleteMode = AutoCompleteMode.Suggest;
                txt_search.AutoCompleteSource = AutoCompleteSource.CustomSource;
                AutoCompleteStringCollection acol = new AutoCompleteStringCollection();

                String query = "select * from itp.store_payment_m ;";
                MySqlCommand cmd = new MySqlCommand(query, mc);
                MySqlDataReader mr;

                try
                {

                    mc.Open();
                    mr = cmd.ExecuteReader();

                    while (mr.Read())
                    {
                        String cn = mr.GetString("Order_ID");
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

        private void txt_oid_MouseClick(object sender, MouseEventArgs e)
        {
            txt_oid.AutoCompleteMode = AutoCompleteMode.Suggest;
            txt_oid.AutoCompleteSource = AutoCompleteSource.CustomSource;
            AutoCompleteStringCollection acol = new AutoCompleteStringCollection();

            String query = "select * from itp.store_order_m ;";
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
            txt_oid.AutoCompleteCustomSource = acol;
            mc.Close();
        }

        private void txt_sid_MouseClick(object sender, MouseEventArgs e)
        {
            txt_sid.AutoCompleteMode = AutoCompleteMode.Suggest;
            txt_sid.AutoCompleteSource = AutoCompleteSource.CustomSource;
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
           txt_sid.AutoCompleteCustomSource = acol;
            mc.Close();
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            String searchType = comboBox2.Text;
            String searchKey = txt_search.Text;

            if (searchType != "select" && searchType != "")
            {

                if (searchKey != "")
                {


                    if (searchType == "Payment ID")
                    {

                        MySqlCommand mcmd = new MySqlCommand("select * from itp.store_payment_m where Payment_ID = '" + searchKey + "'", mc);

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
                    else if (searchType == "Order ID")
                    {

                        MySqlCommand mcmd = new MySqlCommand("select * from itp.store_payment_m where Order_ID = '" + searchKey + "'", mc);

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

        private void btn_back_Click(object sender, EventArgs e)
        {
            StoreMain sm = new StoreMain();
            sm.Show();
            this.Close();
        }

        private void txt_pa_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8  && e.KeyChar != 46)
            {

                e.Handled = true;

            }
            else
            {

                e.Handled = false;


            }
        }
    }
}
