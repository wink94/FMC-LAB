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
    public partial class PHview_stock : Form
    {
        public PHview_stock()
        {
            InitializeComponent();
            tableLoad();
            Fillcombo();
        }

        static String conn = "datasource=localhost;port=3306;username=root;password=sagarox";
        MySqlConnection mc = new MySqlConnection(conn);

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
                dgv_viwstk.DataSource = dt;

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
                    
                    cmbx_cat.Items.Add(com);
                }

            }

            catch (MySqlException ex)
            {

                MessageBox.Show(ex.Message);

            }
            mc.Close();
        }

//find button
        private void btn_outStock_Find_Click(object sender, EventArgs e)
        {
            MySqlCommand mcmd = new MySqlCommand("select * from itp.pharmacy_manage_store where expire_date between '" + dtp_firstDate.Text + "' and '" + dtp_secondDate.Text + "'", mc);

            try
            {
                mc.Open();
                MySqlDataAdapter mda = new MySqlDataAdapter();
                mda.SelectCommand = mcmd;
                DataTable dt = new DataTable();
                mda.Fill(dt);
                dgv_viwstk.DataSource = dt;
              



            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            mc.Close();
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
                            dgv_viwstk.DataSource = dt;




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
                            dgv_viwstk.DataSource = dt;




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
                            dgv_viwstk.DataSource = dt;




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
                    dgv_viwstk.DataSource = dt;
                    



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
