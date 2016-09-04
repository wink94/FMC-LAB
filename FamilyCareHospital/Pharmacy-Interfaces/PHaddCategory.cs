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
    public partial class PHaddCategory : Form
    {
        public PHaddCategory()
        {
            InitializeComponent();
            tableLoad();
            autoGenerateID();
        }

        static String conn = "datasource=localhost;port=3306;username=root;password=sagarox";
        MySqlConnection mc = new MySqlConnection(conn);


//method-ID auto gen:
        public void autoGenerateID()
        {
            String catID = "CAT";
            mc.Open();
            MySqlCommand cmd = new MySqlCommand("select COUNT(ncID) from itp.pharmacy_add_category", mc);
            int count = Convert.ToInt32(cmd.ExecuteScalar());
            count++;
            mc.Close();

            txt_cID.Text = catID + count.ToString();
        }

//table load
        public void tableLoad()
        {

            MySqlCommand mscmd = new MySqlCommand("select * from itp.pharmacy_add_category", mc);

            try
            {
                mc.Open();
                MySqlDataAdapter msad = new MySqlDataAdapter();
                msad.SelectCommand = mscmd;
                DataTable dt = new DataTable();
                msad.Fill(dt);
                dgv_addCat.DataSource = dt;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            mc.Close();
        }



//Validations

        private void txt_cname_KeyPress(object sender, KeyPressEventArgs e)
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


//Form data sending to db
        private void dgv_addCat_MouseClick(object sender, MouseEventArgs e)
        {
            if (dgv_addCat.SelectedRows.Count > 0)
            {
                txt_cID.Text = dgv_addCat.SelectedRows[0].Cells[0].Value.ToString();
                txt_cname.Text = dgv_addCat.SelectedRows[0].Cells[1].Value.ToString();
            }
        }

//Add button

        private void btn_add_Click_1(object sender, EventArgs e)
        {

            String query = "insert into itp.pharmacy_add_category (ncID, ncName) values('" + txt_cID.Text + "','" + txt_cname.Text + "');";
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
            DialogResult dg = MessageBox.Show("Do you want to delete?","Delete",MessageBoxButtons.YesNo);
            if (dg == DialogResult.Yes)
            {


                String query = "delete from itp.pharmacy_add_category  where ncID = '" + txt_cID.Text + "';";
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




        
        }



//update grid view entry

        private void btn_updt_Click(object sender, EventArgs e)
        {
            DialogResult dg = MessageBox.Show("Do you want to update?", "Update", MessageBoxButtons.YesNo);
            if (dg == DialogResult.Yes)
            {
                String query = "update itp.pharmacy_add_category set ncName = '" + txt_cname.Text + "' where ncID = '" + txt_cID.Text + "';";
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
                tableLoad();
                autoGenerateID();
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
