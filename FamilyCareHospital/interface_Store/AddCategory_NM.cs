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
    public partial class AddCategory_NM : Form
    {
        public AddCategory_NM()
        {
            InitializeComponent();
            tableLoad();
            autoGenerateID();
        }

        static String conn = "datasource=localhost;port=3306;username=root;password=sagarox";
        MySqlConnection mc = new MySqlConnection(conn);

        public void autoGenerateID()
        {
            String McID = "NMC";
            mc.Open();
            MySqlCommand cmd = new MySqlCommand("select COUNT(ID) from itp.store_category_nm", mc);
            int i = Convert.ToInt32(cmd.ExecuteScalar());
            i++;
            mc.Close();

            txt_ID.Text = McID + i.ToString();
        }
        public void tableLoad()
        {

            MySqlCommand mcmd = new MySqlCommand("select * from itp.store_category_nm", mc);

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

        private void btn_Add_Click(object sender, EventArgs e)
        {
            if (txt_ID.Text != "" && txt_Name.Text != "")
            {
                String query = "insert into itp.store_category_nm (ID,CName) values('" + txt_ID.Text + "','" + txt_Name.Text + "');";
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
            else
            {

                MessageBox.Show("Invalid details");

            }
        }

        private void dataGridView1_MouseClick(object sender, MouseEventArgs e)
        {
            txt_ID.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            txt_Name.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            StoreMain sm = new StoreMain();
            sm.Show();
            this.Close();
        }
    }
}
