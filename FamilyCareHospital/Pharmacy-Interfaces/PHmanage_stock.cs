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
    public partial class PHmanage_stock : Form
    {
        public PHmanage_stock()
        {
            InitializeComponent();
            tableLoad();
            autoGenerateID();
            Fillcombo();
        }

        static String conn = "datasource=localhost;port=3306;username=root;password=sagarox";
        MySqlConnection mc = new MySqlConnection(conn);



//method-ID auto gen:
        public void autoGenerateID()
        {
            String itmID = "ITM";
            mc.Open();
            MySqlCommand cmd = new MySqlCommand("select COUNT(Item_ID) from itp.pharmacy_manage_store", mc);
            int count = Convert.ToInt32(cmd.ExecuteScalar());
            count++;
            mc.Close();

            txt_ID.Text = itmID + count.ToString();
        }


//table load
        public void tableLoad()
        {

            MySqlCommand mscmd = new MySqlCommand("select * from itp.pharmacy_manage_store", mc);

            try
            {
                mc.Open();
                MySqlDataAdapter msad = new MySqlDataAdapter();
                msad.SelectCommand = mscmd;
                DataTable dt = new DataTable();
                msad.Fill(dt);
                dgv_mngStock.DataSource = dt;

            }
            catch (Exception ex)
            {


                MessageBox.Show(ex.Message);
            }
            mc.Close();
        }

//fill combo

            public void Fillcombo()
        {
            String query = "select * from itp.pharmacy_add_category; ";
            MySqlCommand cmd = new MySqlCommand(query, mc);
            MySqlDataReader mr;

            try
            {
                mc.Open();
                mr = cmd.ExecuteReader();

                
                while (mr.Read())
                {
                    string com = mr.GetString("ncName");
                    cmbx_catgry.Items.Add(com);
                    cmbx_cat.Items.Add(com);
                }

            }

            catch (MySqlException ex)
            {

                MessageBox.Show(ex.Message);

            }
            mc.Close();
        }

//add button
        private void btn_add_Click(object sender, EventArgs e)
        {


            if (txt_ID.Text != "" && txt_batch.Text != "" && cmbx_catgry.Text != "" && cmbx_catgry.Text != "Select" && txt_name.Text != "" ) {

                String query = "insert into itp.pharmacy_manage_store (Item_ID, item_name, batch_no, Category,Packing_type, manufacturer, quantity, entry_date, production_date, expire_date, buying_price, selling_price, profit) values('" + txt_ID.Text + "','" + txt_name.Text + "','" + txt_batch.Text + "','" + cmbx_catgry.Text + "','" + cmbx_pkType.Text+"', '" + txt_manufac.Text + "','" + txt_Qty.Text + "','" + dtp_entry.Text + "','" + dtp_prodDate.Text + "','" + dtp_expDate.Text + "','" + txt_BuyPrice.Text + "','" + txt_sellPrice.Text + "','" + txt_profit.Text + "');";
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

                catch (MySqlException ex)
                {
                    MessageBox.Show(ex.Message);
                }
                mc.Close();
                txt_name.Clear();
                txt_batch.Clear();
                txt_manufac.Clear();
                txt_Qty.Clear();
                txt_BuyPrice.Clear();
                txt_profit.Clear();
                txt_sellPrice.Clear();
                tableLoad();
                autoGenerateID();
            } else
            {
                MessageBox.Show("Invalid detil");
            }
        }


//delete grid view entry

        private void btn_del_Click(object sender, EventArgs e)
        {

            DialogResult dg = MessageBox.Show("Do you want to delete?", "Delete", MessageBoxButtons.YesNo);
            if (dg == DialogResult.Yes)
            {

                if (txt_ID.Text != "" && txt_batch.Text != "")
                {
                    String query = "delete from itp.pharmacy_manage_store  where Item_ID = '" + txt_ID.Text + "' and batch_no = '" + txt_batch.Text + "';";
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
                    txt_batch.Clear();
                    txt_manufac.Clear();
                    txt_Qty.Clear();
                    txt_BuyPrice.Clear();
                    txt_profit.Clear();
                    txt_sellPrice.Clear();

                    tableLoad();
                    autoGenerateID();

                }
                else
                {
                    MessageBox.Show("Invalid detil");
                }
            }
        }


//update grid view entry

        private void btn_updt_Click(object sender, EventArgs e)
        {
            DialogResult dg = MessageBox.Show("Do you want to update?", "Update", MessageBoxButtons.YesNo);
            if (dg == DialogResult.Yes)
            {

                if (txt_ID.Text != "" && txt_batch.Text != "" && txt_name.Text != "")
                {
                    String query = "update itp.pharmacy_manage_store set item_name = '" + txt_name.Text + "', batch_no = '" + txt_batch.Text + "',Category = '" + cmbx_catgry.Text + "' ,Packing_type='" + cmbx_pkType.Text + "',manufacturer = '" + txt_manufac.Text + "',quantity = '" + txt_Qty.Text + "',entry_date = '" + dtp_entry.Text + "',production_date = '" + dtp_prodDate.Text + "',expire_date = '" + dtp_expDate.Text + "',buying_price = '" + txt_BuyPrice.Text + "',selling_price = '" + txt_sellPrice.Text + "',profit = '" + txt_profit.Text + "' where Item_ID='" + txt_ID.Text + "' and batch_no = '" + txt_batch.Text + "' ; ";
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
                    txt_batch.Clear();
                    txt_manufac.Clear();
                    txt_Qty.Clear();
                    txt_BuyPrice.Clear();
                    txt_profit.Clear();
                    txt_sellPrice.Clear();

                    tableLoad();
                    autoGenerateID();
                }
                else
                {
                    MessageBox.Show("Invalid detil");
                }
            }
        }


//Validations

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


        private void txt_Qty_KeyPress(object sender, KeyPressEventArgs e)
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


        private void txt_BPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != 46)  
            {
                e.Handled = true;
            }
            else
            {
                e.Handled = false;
            }
        }

         
        private void txt_manufac_KeyPress(object sender, KeyPressEventArgs e)
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

       

        private void txt_sellPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != 46)
            {
                e.Handled = true;
            }
            else
            {
                e.Handled = false;
            }
        }


        private void txt_profit_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != 46)
            {
                e.Handled = true;
            }
            else
            {
                e.Handled = false;
            }
        }



//Form data sending to db
        private void dgv_mngStock_MouseClick(object sender, MouseEventArgs e)
        {

            if (dgv_mngStock.SelectedRows.Count > 0)
            {
                txt_ID.Text = dgv_mngStock.SelectedRows[0].Cells[0].Value.ToString();
                txt_name.Text = dgv_mngStock.SelectedRows[0].Cells[1].Value.ToString();
                txt_batch.Text = dgv_mngStock.SelectedRows[0].Cells[2].Value.ToString();
                cmbx_catgry.Text = dgv_mngStock.SelectedRows[0].Cells[3].Value.ToString();
                cmbx_pkType.Text = dgv_mngStock.SelectedRows[0].Cells[4].Value.ToString();
                txt_manufac.Text = dgv_mngStock.SelectedRows[0].Cells[5].Value.ToString();
                txt_Qty.Text = dgv_mngStock.SelectedRows[0].Cells[6].Value.ToString();
                dtp_entry.Text = dgv_mngStock.SelectedRows[0].Cells[7].Value.ToString();
                dtp_prodDate.Text = dgv_mngStock.SelectedRows[0].Cells[8].Value.ToString();
                dtp_expDate.Text = dgv_mngStock.SelectedRows[0].Cells[9].Value.ToString();
                txt_BuyPrice.Text = dgv_mngStock.SelectedRows[0].Cells[10].Value.ToString();
                txt_profit.Text = dgv_mngStock.SelectedRows[0].Cells[11].Value.ToString();
                txt_sellPrice.Text = dgv_mngStock.SelectedRows[0].Cells[12].Value.ToString();
            }
            

        }

       

        
//calculate selling price button
        private void btn_sp_Click(object sender, EventArgs e)
        {
            Double sp;
            Double add;
            Double bp = Convert.ToDouble(txt_BuyPrice.Text);
            Double pf = Convert.ToDouble(txt_profit.Text);
            add =  (bp * pf) / 100;
            sp = bp + add;

            txt_sellPrice.Text = Convert.ToString(sp);
        }

//search button
        private void btn_search_Click(object sender, EventArgs e)
        {
            String searchType = cmbx_chooseTyp.Text;
            String searchKey = txt_search.Text;

            if (searchType != "select" && searchType != "")
            {

                if (searchKey != "")
                {

                    if (searchType == "Item ID")
                    {

                        MySqlCommand mcmd = new MySqlCommand("select * from itp.pharmacy_manage_store where Item_ID = '" + searchKey + "'", mc);

                        try
                        {
                            mc.Open();
                            MySqlDataAdapter mda = new MySqlDataAdapter();
                            mda.SelectCommand = mcmd;
                            DataTable dt = new DataTable();
                            mda.Fill(dt);
                            dgv_mngStock.DataSource = dt;
                            



                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                        mc.Close();

                    }
                    else if (searchType == "Item Name")
                    {

                        MySqlCommand mcmd = new MySqlCommand("select * from itp.pharmacy_manage_store where item_name = '" + searchKey + "'", mc);

                        try
                        {
                            mc.Open();
                            MySqlDataAdapter mda = new MySqlDataAdapter();
                            mda.SelectCommand = mcmd;
                            DataTable dt = new DataTable();
                            mda.Fill(dt);
                            dgv_mngStock.DataSource = dt;
                          



                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                        mc.Close();

                    }
                    else if (searchType == "Batch Number")
                    {

                        MySqlCommand mcmd = new MySqlCommand("select * from itp.pharmacy_manage_store where batch_no = '" + searchKey + "'", mc);

                        try
                        {
                            mc.Open();
                            MySqlDataAdapter mda = new MySqlDataAdapter();
                            mda.SelectCommand = mcmd;
                            DataTable dt = new DataTable();
                            mda.Fill(dt);
                            dgv_mngStock.DataSource = dt;
                           



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

//search auto complete
        private void txt_search_MouseClick(object sender, MouseEventArgs e)
        {
            if (cmbx_chooseTyp.Text == "Item ID")
            {

                txt_search.AutoCompleteMode = AutoCompleteMode.Suggest;
                txt_search.AutoCompleteSource = AutoCompleteSource.CustomSource;
                AutoCompleteStringCollection acol = new AutoCompleteStringCollection();

                String query = "select * from itp.pharmacy_manage_store ;";
                MySqlCommand cmd = new MySqlCommand(query, mc);
                MySqlDataReader mr;

                try
                {

                    mc.Open();
                    mr = cmd.ExecuteReader();

                    while (mr.Read())
                    {
                        String cn = mr.GetString("Item_ID");
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
            else if (cmbx_chooseTyp.Text == "Item Name")
            {


                txt_search.AutoCompleteMode = AutoCompleteMode.Suggest;
                txt_search.AutoCompleteSource = AutoCompleteSource.CustomSource;
                AutoCompleteStringCollection acol = new AutoCompleteStringCollection();

                String query = "select * from itp.pharmacy_manage_store ;";
                MySqlCommand cmd = new MySqlCommand(query, mc);
                MySqlDataReader mr;

                try
                {

                    mc.Open();
                    mr = cmd.ExecuteReader();

                    while (mr.Read())
                    {
                        String cn = mr.GetString("item_name");
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

            else if (cmbx_chooseTyp.Text == "Batch Number")
            {


                txt_search.AutoCompleteMode = AutoCompleteMode.Suggest;
                txt_search.AutoCompleteSource = AutoCompleteSource.CustomSource;
                AutoCompleteStringCollection acol = new AutoCompleteStringCollection();

                String query = "select * from itp.pharmacy_manage_store ;";
                MySqlCommand cmd = new MySqlCommand(query, mc);
                MySqlDataReader mr;

                try
                {

                    mc.Open();
                    mr = cmd.ExecuteReader();

                    while (mr.Read())
                    {
                        String cn = mr.GetString("batch_no");
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


//view button
        private void btn_vw_Click(object sender, EventArgs e)
        {
           

            

            String cat = cmbx_cat.Text;
            if (cat != "select" && cat != "")
            {

                MySqlCommand mcmd = new MySqlCommand("select * from itp.pharmacy_manage_store where Category = '" + cat + "'", mc);

                try
                {
                    mc.Open();
                    MySqlDataAdapter mda = new MySqlDataAdapter();
                    mda.SelectCommand = mcmd;
                    DataTable dt = new DataTable();
                    mda.Fill(dt);
                    dgv_mngStock.DataSource = dt;
                    



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

//view all button
        private void btn_vwall_Click(object sender, EventArgs e)
        {
            tableLoad();
        }
//back button
        private void btn_back_Click(object sender, EventArgs e)
        {
            this.Close();
            PHmain pm = new PHmain();
            pm.Show();
            
        }
    }
}