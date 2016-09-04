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
    public partial class DoctorSearch : Form
    {
        public DoctorSearch()
        {
            InitializeComponent();
            dctrnamelbl.Text = ""; spelbl.Text = ""; dcfeelbl.Text = ""; hspichar.Text = ""; mndylbl.Text = ""; tuelbl.Text = "";
            wenlbl.Text = ""; thurlbl.Text = ""; frilbl.Text = ""; satlbl.Text = "";  sunlbl.Text = ""; label12.Text = "";
        }

        int total;
        static string mycon = "SERVER=localhost; DATABASE=itp; UID=root; PASSWORD=sagarox";
        MySqlConnection mc = new MySqlConnection(mycon);

        private void button1_Click(object sender, EventArgs e)
        {
            validation val = new validation();
            try
            {
                if (val.textisEmpty(dctrnametxt, label12) == true)
                {
                    if (val.alphaVal(dctrnametxt.Text, label12) == true)
                    {
                        mc.Open();
                        String qry = "select Name, DcReNo,Speciality,ConsltFee,HospCharges,Monday,Tuesday,Wendesday,Thursday,Friday,Saturday,Sunday from doctorinfo  where Name like '%" + dctrnametxt.Text + "%'";
                        MySqlDataAdapter ad = new MySqlDataAdapter(qry, mycon);
                        DataTable tb = new DataTable();
                        ad.Fill(tb);
                        searchView1.DataSource = tb;
                        mc.Close();
                    }
                    else
                    {
                        MessageBox.Show("Invalid Value!");
                    }
                }
                else
                {
                    MessageBox.Show("Mandatory Fields!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        //string dctrfe

        private void searchView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow rw = searchView1.Rows[e.RowIndex];
                dctrnamelbl.ForeColor = System.Drawing.Color.Blue; spelbl.ForeColor = System.Drawing.Color.Blue; mndylbl.ForeColor = System.Drawing.Color.Blue;
                tuelbl.ForeColor = System.Drawing.Color.Blue; wenlbl.ForeColor = System.Drawing.Color.Blue; thurlbl.ForeColor = System.Drawing.Color.Blue;
                frilbl.ForeColor = System.Drawing.Color.Blue; satlbl.ForeColor = System.Drawing.Color.Blue; sunlbl.ForeColor = System.Drawing.Color.Blue;
                dcfeelbl.ForeColor = System.Drawing.Color.Blue; hspichar.ForeColor = System.Drawing.Color.Blue;

                dctrnamelbl.Text = rw.Cells["Name"].Value.ToString();
                spelbl.Text = rw.Cells["Speciality"].Value.ToString();
                dcfeelbl.Text = rw.Cells["ConsltFee"].Value.ToString();
                hspichar.Text = rw.Cells["HospCharges"].Value.ToString();
                mndylbl.Text = rw.Cells["Monday"].Value.ToString();
                tuelbl.Text = rw.Cells["Tuesday"].Value.ToString();
                wenlbl.Text = rw.Cells["Wendesday"].Value.ToString();
                thurlbl.Text = rw.Cells["Thursday"].Value.ToString();
                frilbl.Text = rw.Cells["Friday"].Value.ToString();
                satlbl.Text = rw.Cells["Saturday"].Value.ToString();
                sunlbl.Text = rw.Cells["Sunday"].Value.ToString();

                int dctfee = Convert.ToInt32(dcfeelbl.Text);
                int hospichar = Convert.ToInt32(hspichar.Text);
                total = dctfee + hospichar;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            validation val = new validation();
            if (val.textisEmpty(dctrnametxt, label12) == true)
            {
                MakeAppointment d5 = new MakeAppointment(dctrnamelbl.Text, spelbl.Text, mndylbl.Text, tuelbl.Text, wenlbl.Text, thurlbl.Text, frilbl.Text, satlbl.Text, sunlbl.Text, dcfeelbl.Text, hspichar.Text, total);
                d5.ShowDialog();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DoctorMain dm = new DoctorMain();
            this.Hide();
            dm.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {

           /* Admin ad = new Admin();
            this.Hide();
            ad.ShowDialog();*/
        }

        private void dctrnametxt_MouseClick(object sender, MouseEventArgs e)
        {


            dctrnametxt.AutoCompleteMode = AutoCompleteMode.Suggest;
            dctrnametxt.AutoCompleteSource = AutoCompleteSource.CustomSource;
            AutoCompleteStringCollection name = new AutoCompleteStringCollection();

            String query = "select * from doctorinfo;";
            MySqlCommand cmd = new MySqlCommand(query, mc);
            MySqlDataReader rdr;

                try
                {

                    mc.Open();
                    rdr = cmd.ExecuteReader();

                    while (rdr.Read())
                    {
                        String cn = rdr.GetString("Name");
                        name.Add(cn);
                    }

                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);

                }

             dctrnametxt.AutoCompleteCustomSource = name;
             mc.Close();
            
        }
    }
}
