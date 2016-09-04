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
    public partial class DriverDetails : Form
    {
        public DriverDetails()
        {
            InitializeComponent();
            tableLoad();
        }

        static string conn = "datasource=localhost;port=3306;username=root;password=sagarox";
        MySqlConnection mc = new MySqlConnection(conn);

        public void tableLoad()
        {

            MySqlCommand mcmd = new MySqlCommand("select Date,Shift,DriverId, DriverName, ContactNo, VehicleNo from itp.driversdetails", mc);

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

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            TransportMain tm = new TransportMain();
            tm.Show();
            this.Hide();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsDigit(e.KeyChar) && e.KeyChar !=8)
            {
                e.Handled = true;
            }
            else
            {
                e.Handled = false;
            }
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsLetter(e.KeyChar) && e.KeyChar !=8 && e.KeyChar !=32)
            {
                e.Handled = true;
            }
            else
            {
                e.Handled = false;
            }
        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsDigit(e.KeyChar) && e.KeyChar !=8 && e.KeyChar != 32  )
            {
                e.Handled = true;
            }
            else
            {
                e.Handled = false;
            }
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox5_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsLetterOrDigit(e.KeyChar) && e.KeyChar !=8 && e.KeyChar !=32)
            {
                e.Handled = true;
            }
            else
            {
                e.Handled = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String query = "insert into itp.driversdetails (DriverId, DriverName, Date, Shift, ContactNo, VehicleNo) values('" + textBox2.Text+ "','" + textBox3.Text+ "','" + dateTimePicker1.Text + "','" + comboBox1.Text + "','" + textBox4.Text + "','" + textBox5.Text + "')";
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
            ////autoGenerateID();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string query = "update itp.driversdetails set DriverId='" + textBox2.Text + "', DriverName='" + textBox3.Text + "', Date='" + dateTimePicker1.Text + "', Shift='" + comboBox1.Text + "', ContactNo='" + textBox4.Text + "', VehicleNo='" + textBox5.Text + "'";
            MySqlCommand cmd = new MySqlCommand(query, mc);
            MySqlDataReader mr;

            try
            {
                mc.Open();
                mr = cmd.ExecuteReader();
                MessageBox.Show("successfully updated");
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
        }

        private void dataGridView1_MouseClick(object sender, MouseEventArgs e)
        {
            dateTimePicker1.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            comboBox1.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            textBox2.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            textBox3.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
            textBox4.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
            textBox5.Text = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {

            string query = "delete from itp.driversdetails where DriverId ='" + textBox2.Text + "'";
            MySqlCommand cmd = new MySqlCommand(query, mc);
            MySqlDataReader mr;

            try
            {
                mc.Open();
                mr = cmd.ExecuteReader();
                MessageBox.Show("Data Removed");
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
        }

        /*  private void button4_Click(object sender, EventArgs e)
          {
              TransportMain tm = new TransportMain();
              tm.Show();

          }*/
    }
}
