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
    public partial class AddCategory : Form
    {
        public AddCategory()
        {
            InitializeComponent();
            tableLoad();
            autoGenerateID();
        }

        static String conn = "datasource=localhost;port=3306;username=root;password=sagarox";
        MySqlConnection mc = new MySqlConnection(conn);

        public void autoGenerateID()
        {
            String McID = "MC";
            mc.Open();
            MySqlCommand cmd = new MySqlCommand("select COUNT(ID) from itp.store_categorym",mc);
            int i = Convert.ToInt32(cmd.ExecuteScalar());
            i++;
            mc.Close();

            txt_ID.Text = McID + i.ToString();
        }
        public void tableLoad()
        {
            
           MySqlCommand mcmd = new MySqlCommand("select * from itp.store_categorym",mc);

            try {
                mc.Open();
                MySqlDataAdapter mda = new MySqlDataAdapter();
                mda.SelectCommand = mcmd;
                DataTable dt = new DataTable();
                mda.Fill(dt);
              //  BindingSource bs = new BindingSource();
               // bs.DataSource = dt;
                dataGridView1.DataSource = dt;
                // mda.Update(dt);
                


            } catch(Exception ex) {


                MessageBox.Show(ex.Message);
            }
            mc.Close();
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            if (txt_ID.Text != "" && txt_Name.Text != "")
            {
                String query = "insert into itp.store_categorym (ID,CName) values('" + txt_ID.Text + "','" + txt_Name.Text + "');";
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
            else {

                MessageBox.Show("Invalid details");

            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
          
        }

        private void dataGridView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            txt_ID.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            txt_Name.Text= dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Do you want to Update ?", "Update", MessageBoxButtons.YesNo);

            if (dialog == DialogResult.Yes)
            {
                if (txt_ID.Text != "" && txt_Name.Text != "")
                {
                    String query = "update itp.store_categorym set CName = '" + txt_Name.Text + "' where ID = '" + txt_ID.Text + "';";
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
                else {

                    MessageBox.Show("Invalid Details");

                }
            }
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Do you want to delete ?", "Delete", MessageBoxButtons.YesNo);

            if (dialog == DialogResult.Yes)
            {
                if (txt_ID.Text != "")
                {
                    String query = "delete from itp.store_categorym  where ID = '" + txt_ID.Text + "';";
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
                else {

                    MessageBox.Show("Invalid ID");
                }
            }
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            StoreMain sm = new StoreMain();

            
            sm.Show();
            this.Close();

          
            
        }

        private void txt_Name_KeyPress(object sender, KeyPressEventArgs e)
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
    }
}
