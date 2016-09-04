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
    public partial class PHmanage_supplier_details : Form
    {
        public PHmanage_supplier_details()
        {
            InitializeComponent();
            tableLoad();
            autoGenerateID();
            Fillcombo();
        }
        static String conn = "datasource=localhost;port=3306;username=root;password=sagarox";
        MySqlConnection mc = new MySqlConnection(conn);

//method-auto gen:

        public void autoGenerateID()
        {
            String supID = "SUP";
            mc.Open();
            MySqlCommand cmd = new MySqlCommand("select COUNT(supp_ID) from itp.pharmacy_manage_supplier_details", mc);
            int count = Convert.ToInt32(cmd.ExecuteScalar());
            count++;
            mc.Close();

            txt_supID.Text = supID + count.ToString();
        }

//table load
        public void tableLoad()
        {

            MySqlCommand mscmd = new MySqlCommand("select * from itp.pharmacy_manage_supplier_details", mc);

            try
            {
                mc.Open();
                MySqlDataAdapter msad = new MySqlDataAdapter();
                msad.SelectCommand = mscmd;
                DataTable dt = new DataTable();
                msad.Fill(dt);
                dgv_mngSupDetails.DataSource = dt;

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
                    cmbx_chooseTyp.Items.Add(com);
                    
                }

            }

            catch (MySqlException ex)
            {

                MessageBox.Show(ex.Message);

            }
            mc.Close();
        }

        //Add button 
        private void btn_add_Click(object sender, EventArgs e)
        {
            String query = "insert into itp.pharmacy_manage_supplier_details (supp_ID, supp_name, contact_person, address, phone, email, fax, reg_no, agree_no, agree_date) values('" + txt_supID.Text + "','" + txt_supName.Text + "','" + txt_contactPersn.Text + "','" + txt_addr.Text + "','" + txt_phone.Text + "','" + txt_email.Text + "','" + txt_fax.Text + "','" + txt_regNo.Text + "','" + txt_agreeNo.Text + "','" + dtp_agreeDate.Text + "');";
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


//delete grid view entry
        private void btn_del_Click(object sender, EventArgs e)
        {
            String query = "delete from itp.pharmacy_manage_supplier_details  where supp_ID = '" + txt_supID.Text + "';";
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


//update grid view entry

        private void btn_updt_Click(object sender, EventArgs e)
        {
            DialogResult dg = MessageBox.Show("Do you want to update?", "Update", MessageBoxButtons.YesNo);
            if (dg == DialogResult.Yes)
            {

                if (txt_supID.Text != "" && txt_supName.Text != "")
                {
                    String query = "update itp.pharmacy_manage_supplier_details set supp_name = '" + txt_supName.Text + "',contact_person = '" + txt_contactPersn.Text + "',address = '" + txt_addr.Text + "',phone = '" + txt_phone.Text + "',email = '" + txt_email.Text + "',fax = '" + txt_fax.Text + "',reg_no= '" + txt_regNo.Text + "',agree_no = '" + txt_agreeNo.Text + "',agree_date = '" + dtp_agreeDate.Text + "' ; ";
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
                    txt_supName.Clear();
                    txt_contactPersn.Clear();
                    txt_addr.Clear();
                    txt_phone.Clear();
                    txt_email.Clear();
                    txt_fax.Clear();
                    txt_regNo.Clear();
                    txt_agreeNo.Clear();





                    tableLoad();
                    autoGenerateID();
                }
                else
                {

                    MessageBox.Show("Invalid details");
                }
            }
        }

//validations

        private void txt_supName_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txt_cntactPersn_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txt_addr_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txt_phone_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txt_fax_KeyPress(object sender, KeyPressEventArgs e)
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

        private void dgv_mngSupDetails_MouseClick(object sender, MouseEventArgs e)
        {
            txt_supID.Text        = dgv_mngSupDetails.SelectedRows[0].Cells[0].Value.ToString();
            txt_supName.Text      = dgv_mngSupDetails.SelectedRows[0].Cells[1].Value.ToString();
            txt_contactPersn.Text = dgv_mngSupDetails.SelectedRows[0].Cells[2].Value.ToString();
            txt_addr.Text         = dgv_mngSupDetails.SelectedRows[0].Cells[3].Value.ToString();
            txt_phone.Text        = dgv_mngSupDetails.SelectedRows[0].Cells[4].Value.ToString();
            txt_email.Text        = dgv_mngSupDetails.SelectedRows[0].Cells[5].Value.ToString();
            txt_fax.Text          = dgv_mngSupDetails.SelectedRows[0].Cells[6].Value.ToString();
            txt_regNo.Text        = dgv_mngSupDetails.SelectedRows[0].Cells[7].Value.ToString();
            txt_agreeNo.Text      = dgv_mngSupDetails.SelectedRows[0].Cells[8].Value.ToString();
            dtp_agreeDate.Text    = dgv_mngSupDetails.SelectedRows[0].Cells[9].Value.ToString();
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

                    if (searchType == "Supplier ID")
                    {

                        MySqlCommand mcmd = new MySqlCommand("select * from itp.pharmacy_manage_supplier_details where supp_ID = '" + searchKey + "'", mc);

                        try
                        {
                            mc.Open();
                            MySqlDataAdapter mda = new MySqlDataAdapter();
                            mda.SelectCommand = mcmd;
                            DataTable dt = new DataTable();
                            mda.Fill(dt);
                            dgv_mngSupDetails.DataSource = dt;
                            



                        }
                        catch (Exception ex)
                        {


                            MessageBox.Show(ex.Message);
                        }
                        mc.Close();

                    }
                    else if (searchType == "Supplier Name")
                    {

                        MySqlCommand mcmd = new MySqlCommand("select * from itp.pharmacy_manage_supplier_details where supp_name = '" + searchKey + "'", mc);

                        try
                        {
                            mc.Open();
                            MySqlDataAdapter mda = new MySqlDataAdapter();
                            mda.SelectCommand = mcmd;
                            DataTable dt = new DataTable();
                            mda.Fill(dt);
                            dgv_mngSupDetails.DataSource = dt;
                           



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
            if (cmbx_chooseTyp.Text == "Supplier ID")
            {

                txt_search.AutoCompleteMode = AutoCompleteMode.Suggest;
                txt_search.AutoCompleteSource = AutoCompleteSource.CustomSource;
                AutoCompleteStringCollection acol = new AutoCompleteStringCollection();

                String query = "select * from itp.pharmacy_manage_supplier_details ;";
                MySqlCommand cmd = new MySqlCommand(query, mc);
                MySqlDataReader mr;

                try
                {

                    mc.Open();
                    mr = cmd.ExecuteReader();

                    while (mr.Read())
                    {
                        String cn = mr.GetString("supp_ID");
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
            else if (cmbx_chooseTyp.Text == "Supplier Name")
            {


                txt_search.AutoCompleteMode = AutoCompleteMode.Suggest;
                txt_search.AutoCompleteSource = AutoCompleteSource.CustomSource;
                AutoCompleteStringCollection acol = new AutoCompleteStringCollection();

                String query = "select * from itp.pharmacy_manage_supplier_details ;";
                MySqlCommand cmd = new MySqlCommand(query, mc);
                MySqlDataReader mr;

                try
                {

                    mc.Open();
                    mr = cmd.ExecuteReader();

                    while (mr.Read())
                    {
                        String cn = mr.GetString("supp_name");
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

