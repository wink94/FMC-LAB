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
    public partial class PHpurchased_order : Form
    {
        public PHpurchased_order()
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
            String pordID = "ODR";
            mc.Open();
            MySqlCommand cmd = new MySqlCommand("select COUNT(order_ID) from itp.pharmacy_purchased_order", mc);
            int count = Convert.ToInt32(cmd.ExecuteScalar());
            count++;
            mc.Close();

            txt_odrID.Text = pordID + count.ToString();
        }
        //table load
        public void tableLoad()
        {

            MySqlCommand mscmd = new MySqlCommand("select * from itp.pharmacy_purchased_order", mc);

            try
            {
                mc.Open();
                MySqlDataAdapter msad = new MySqlDataAdapter();
                msad.SelectCommand = mscmd;
                DataTable dt = new DataTable();
                msad.Fill(dt);
                dgv_purchsdOrdr.DataSource = dt;

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
            String query = "insert into itp.pharmacy_purchased_order (order_ID, item_ID, name, category, quantity, supplier_ID, added_date, current_status, recived_date, return, payment, add_to_stock) values('" + txt_odrID.Text + "','" + txt_itmName.Text + "','" + txt_name.Text + "','" + cmbx_Cat.Text + "','" + txt_qty.Text + "','" + txt_supID.Text + "','" + dtp_adedDate.Text + "','" + cmbx_crntStats.Text + "','" + dtp_rcvdDate.Text + "','" + cmbx_qltyOfItm.Text + "','" + cmbx_return.Text + "','" + cmbx_addToStck.Text + "');";
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

        //validation
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

        private void txt_qty_KeyPress(object sender, KeyPressEventArgs e)
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

        private void dgv_purchsdOrdr_MouseClick(object sender, MouseEventArgs e)
        {
            txt_odrID.Text = dgv_purchsdOrdr.SelectedRows[0].Cells[0].Value.ToString();
            txt_itmName.Text = dgv_purchsdOrdr.SelectedRows[0].Cells[1].Value.ToString();
            txt_name.Text = dgv_purchsdOrdr.SelectedRows[0].Cells[2].Value.ToString();
            cmbx_Cat.Text = dgv_purchsdOrdr.SelectedRows[0].Cells[3].Value.ToString();
            txt_qty.Text = dgv_purchsdOrdr.SelectedRows[0].Cells[4].Value.ToString();
            txt_supID.Text = dgv_purchsdOrdr.SelectedRows[0].Cells[5].Value.ToString();
            dtp_adedDate.Text = dgv_purchsdOrdr.SelectedRows[0].Cells[6].Value.ToString();
            cmbx_crntStats.Text = dgv_purchsdOrdr.SelectedRows[0].Cells[7].Value.ToString();
            dtp_rcvdDate.Text = dgv_purchsdOrdr.SelectedRows[0].Cells[8].Value.ToString();
            cmbx_qltyOfItm.Text = dgv_purchsdOrdr.SelectedRows[0].Cells[9].Value.ToString();
            cmbx_return.Text = dgv_purchsdOrdr.SelectedRows[0].Cells[10].Value.ToString();
            cmbx_addToStck.Text = dgv_purchsdOrdr.SelectedRows[0].Cells[11].Value.ToString();
           
        }

        //delete
        private void btn_del_KeyPress(object sender, KeyPressEventArgs e)
        {
            String query = "delete from itp.pharmacy_purchased_order  where order_ID = '" + txt_odrID.Text + "';";
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

        private void btn_back_Click(object sender, EventArgs e)
        {
            this.Close();
            PHmain pm = new PHmain();
            pm.Show();
        }
    }
}
