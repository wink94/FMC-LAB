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
    public partial class PHplaced_order : Form
    {
        public PHplaced_order()
        {
            InitializeComponent();
            tableLoad();
            autoGenerateID();
        }

        static String conn = "datasource=localhost;port=3306;username=root;password=sagarox";
        MySqlConnection mc = new MySqlConnection(conn);

        //method,autogen
        public void autoGenerateID()
        {
            String odrID = "ODR";
            mc.Open();
            MySqlCommand cmd = new MySqlCommand("select COUNT(order_ID) from itp.pharmacy_placed_order", mc);
            int count = Convert.ToInt32(cmd.ExecuteScalar());
            count++;
            mc.Close();

            txt_odrID.Text = odrID + count.ToString();

        }
        //table load
        public void tableLoad()
        {

            MySqlCommand mscmd = new MySqlCommand("select * from itp.pharmacy_placed_order", mc);

            try
            {
                mc.Open();
                MySqlDataAdapter msad = new MySqlDataAdapter();
                msad.SelectCommand = mscmd;
                DataTable dt = new DataTable();
                msad.Fill(dt);
                dgv_PlcdOrdr.DataSource = dt;

            }
            catch (Exception ex)
            {


                MessageBox.Show(ex.Message);
            }
            mc.Close();
        }

       

        //Validations_below
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
        //add button
        private void btn_add_Click(object sender, EventArgs e)
        {
            String query = "insert into itp.pharmacy_placed_order (order_ID, item_ID, name, category, added_date, current_status, received_date, return, add_to_stock) values('" + txt_odrID.Text + "','" + txt_itmID.Text + "','" + txt_name.Text + "','" + cmbx_cat.Text + "','" + dtp_addDate.Text + "','" + cmbx_crntStus.Text + "','" + dtp_rcvdDate.Text + "','" + cmbx_return.Text + "','" + cmbx_addToStck.Text + "');";
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

        //Form data sending to db
        private void dgv_PlcdOrdr_MouseClick(object sender, MouseEventArgs e)
        {
            txt_odrID.Text = dgv_PlcdOrdr.SelectedRows[0].Cells[0].Value.ToString();
            txt_itmID.Text = dgv_PlcdOrdr.SelectedRows[0].Cells[1].Value.ToString();
            txt_name.Text = dgv_PlcdOrdr.SelectedRows[0].Cells[2].Value.ToString();
            cmbx_cat.Text = dgv_PlcdOrdr.SelectedRows[0].Cells[3].Value.ToString();
            dtp_addDate.Text = dgv_PlcdOrdr.SelectedRows[0].Cells[4].Value.ToString();
            cmbx_crntStus.Text = dgv_PlcdOrdr.SelectedRows[0].Cells[5].Value.ToString();
            dtp_rcvdDate.Text = dgv_PlcdOrdr.SelectedRows[0].Cells[6].Value.ToString();
            cmbx_return.Text = dgv_PlcdOrdr.SelectedRows[0].Cells[7].Value.ToString();
            cmbx_addToStck.Text = dgv_PlcdOrdr.SelectedRows[0].Cells[8].Value.ToString();
        }

        //delete
        private void btn_del_KeyPress(object sender, KeyPressEventArgs e)
        {
            String query = "delete from itp.pharmacy_placed_order  where order_ID = '" + txt_odrID.Text + "';";
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

        private void btn_search_Click(object sender, EventArgs e)
        {

        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            this.Close();
            PHmain pm = new PHmain();
            pm.Show();
        }
    }
    }
   
