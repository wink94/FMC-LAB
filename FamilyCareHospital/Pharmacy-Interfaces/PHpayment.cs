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


namespace FamilyCareHospital.Pharmacy_Interfaces
{
    public partial class PHpayment : Form
    {
        public PHpayment()
        {
            InitializeComponent();
            tableLoad();
            autoGenerateID();
            
        }

        static String conn = "datasource=localhost;port=3306;username=root;password=sagarox";
        MySqlConnection mc = new MySqlConnection(conn);

//method-auto gen:
        public void autoGenerateID()
        {
            String pyID = "PYMNT";
            mc.Open();
            MySqlCommand cmd = new MySqlCommand("select COUNT(payment_ID) from itp.pharmacy_payment", mc);
            int count = Convert.ToInt32(cmd.ExecuteScalar());
            count++;
            mc.Close();

            txt_pID.Text = pyID + count.ToString();
        }

//table load
        public void tableLoad()
        {

            MySqlCommand mscmd = new MySqlCommand("select * from itp.pharmacy_payment", mc);

            try
            {
                mc.Open();
                MySqlDataAdapter msad = new MySqlDataAdapter();
                msad.SelectCommand = mscmd;
                DataTable dt = new DataTable();
                msad.Fill(dt);
                dgv_pymnt.DataSource = dt;

            }
            catch (Exception ex)
            {


                MessageBox.Show(ex.Message);
            }
            mc.Close();
        }
        

       

        //add button
        private void btn_add_Click(object sender, EventArgs e)
        {
            String query = "insert into itp.pharmacy_payment (payment_ID, order_ID, supplier_ID, amount, payment_type) values('" + txt_pID.Text + "','" + txt_oID.Text + "','" + txt_supID.Text + "','" + txt_amnt.Text + "','"+ cmbx_pType.Text +"'); ";
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
            tableLoad();
            autoGenerateID();
        }

//delete button
        private void btn_del_Click(object sender, EventArgs e)
        {
            String query = "delete from itp.pharmacy_payment  where payment_ID = '" + txt_pID.Text + "';";
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
            autoGenerateID();
        }
        //Validations_below
        private void txt_amntID_KeyPress(object sender, KeyPressEventArgs e)
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

        //Form data sending to db
        private void dgv_pymnt_MouseClick(object sender, MouseEventArgs e)
        {
            if (dgv_pymnt.SelectedRows.Count>0)
            {
                txt_pID.Text = dgv_pymnt.SelectedRows[0].Cells[0].Value.ToString();
                txt_oID.Text = dgv_pymnt.SelectedRows[0].Cells[1].Value.ToString();
                txt_supID.Text = dgv_pymnt.SelectedRows[0].Cells[2].Value.ToString();
                txt_amnt.Text = dgv_pymnt.SelectedRows[0].Cells[3].Value.ToString();
                cmbx_pType.Text = dgv_pymnt.SelectedRows[0].Cells[4].Value.ToString();
            }
        }

//update 
        private void btn_updt_Click(object sender, EventArgs e)
        {
            DialogResult dg = MessageBox.Show("Do you want to update?", "Update", MessageBoxButtons.YesNo);
            if (dg == DialogResult.Yes)
            {

                if (txt_pID.Text != "" && txt_oID.Text != "" && txt_supID.Text != "")
                {
                    String query = "update itp.pharmacy_payment set order_ID = '" + txt_oID.Text + "', supplier_ID = '" + txt_supID.Text + "',amount = '" + txt_amnt.Text + "' ,payment_type='" + cmbx_pType.Text + "' where payment_ID='" + txt_pID.Text + "' ; ";
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
                    txt_oID.Clear();
                    txt_supID.Clear();
                    txt_amnt.Clear();
                    

                    tableLoad();
                    autoGenerateID();
                }
                else
                {
                    MessageBox.Show("Invalid detil");
                }
            }
        }
        //search
        private void btn_search_Click(object sender, EventArgs e)
        {
            String searchType = cmbx_typ.Text;
            String searchKey = txt_search.Text;

            if (searchType != "select" && searchType != "")
            {

                if (searchKey != "")
                {

                    if (searchType == "payment_ID")
                    {

                        MySqlCommand mcmd = new MySqlCommand("select * from itp.pharmacy_payment where payment_ID = '" + searchKey + "'", mc);

                        try
                        {
                            mc.Open();
                            MySqlDataAdapter mda = new MySqlDataAdapter();
                            mda.SelectCommand = mcmd;
                            DataTable dt = new DataTable();
                            mda.Fill(dt);
                            dgv_pymnt.DataSource = dt;




                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                        mc.Close();

                    }
                    else if (searchType == "Order ID")
                    {

                        MySqlCommand mcmd = new MySqlCommand("select * from itp.pharmacy_payment where order_ID = '" + searchKey + "'", mc);

                        try
                        {
                            mc.Open();
                            MySqlDataAdapter mda = new MySqlDataAdapter();
                            mda.SelectCommand = mcmd;
                            DataTable dt = new DataTable();
                            mda.Fill(dt);
                            dgv_pymnt.DataSource = dt;




                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                        mc.Close();

                    }
                    else if (searchType == "Supplier ID")
                    {

                        MySqlCommand mcmd = new MySqlCommand("select * from itp.pharmacy_payment where supplier_ID = '" + searchKey + "'", mc);

                        try
                        {
                            mc.Open();
                            MySqlDataAdapter mda = new MySqlDataAdapter();
                            mda.SelectCommand = mcmd;
                            DataTable dt = new DataTable();
                            mda.Fill(dt);
                            dgv_pymnt.DataSource = dt;




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

        private void btn_vwAll_Click(object sender, EventArgs e)
        {
            tableLoad();
        }
        //search auto complete
        private void txt_search_MouseClick(object sender, MouseEventArgs e)
        {
            if (cmbx_typ.Text == "payment_ID")
            {

                txt_search.AutoCompleteMode = AutoCompleteMode.Suggest;
                txt_search.AutoCompleteSource = AutoCompleteSource.CustomSource;
                AutoCompleteStringCollection acol = new AutoCompleteStringCollection();

                String query = "select * from itp.pharmacy_payment ;";
                MySqlCommand cmd = new MySqlCommand(query, mc);
                MySqlDataReader mr;

                try
                {

                    mc.Open();
                    mr = cmd.ExecuteReader();

                    while (mr.Read())
                    {
                        String cn = mr.GetString("payment_ID");
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
            else if (cmbx_typ.Text == "order_ID")
            {


                txt_search.AutoCompleteMode = AutoCompleteMode.Suggest;
                txt_search.AutoCompleteSource = AutoCompleteSource.CustomSource;
                AutoCompleteStringCollection acol = new AutoCompleteStringCollection();

                String query = "select * from itp.pharmacy_payment ;";
                MySqlCommand cmd = new MySqlCommand(query, mc);
                MySqlDataReader mr;

                try
                {

                    mc.Open();
                    mr = cmd.ExecuteReader();

                    while (mr.Read())
                    {
                        String cn = mr.GetString("order_ID");
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

            else if (cmbx_typ.Text == "supplier_ID")
            {


                txt_search.AutoCompleteMode = AutoCompleteMode.Suggest;
                txt_search.AutoCompleteSource = AutoCompleteSource.CustomSource;
                AutoCompleteStringCollection acol = new AutoCompleteStringCollection();

                String query = "select * from itp.pharmacy_payment ;";
                MySqlCommand cmd = new MySqlCommand(query, mc);
                MySqlDataReader mr;

                try
                {

                    mc.Open();
                    mr = cmd.ExecuteReader();

                    while (mr.Read())
                    {
                        String cn = mr.GetString("supplier_ID");
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
            this.Close();
            PHmain pm = new PHmain();
            pm.Show();
        }
    }
   }
    

       

    
    


    






