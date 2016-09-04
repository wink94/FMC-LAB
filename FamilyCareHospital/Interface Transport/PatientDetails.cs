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
      
    public partial class PatientDetails : Form
    {
       
        public PatientDetails()
        {
            InitializeComponent();
            tableLoad();
            autoGenerateID();
        }

        static string conn = "datasource=localhost;port=3306;username=root;password=sagarox";
        MySqlConnection mc = new MySqlConnection(conn);

        public void autoGenerateID()
        {
            String tpID = "PID";
            mc.Open();
            MySqlCommand cmd = new MySqlCommand("select COUNT(Patient_Id) from itp.patient_details", mc);
            int i = Convert.ToInt32(cmd.ExecuteScalar());
            i++;
            mc.Close();

            textBox11.Text = tpID + i.ToString();
        }


        public void tableLoad()
        {

            MySqlCommand mcmd = new MySqlCommand("select * from itp.patient_details", mc);

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
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void dataGridView1_MouseClick(object sender, MouseEventArgs e)
        {
            textBox11.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString(); 
            textBox1.Text  = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            textBox2.Text  = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            textBox3.Text  = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
            textBox4.Text  = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
            textBox5.Text  = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();
            textBox6.Text  = dataGridView1.SelectedRows[0].Cells[6].Value.ToString();
            textBox7.Text  = dataGridView1.SelectedRows[0].Cells[7].Value.ToString();
            textBox8.Text  = dataGridView1.SelectedRows[0].Cells[8].Value.ToString();
            textBox9.Text  = dataGridView1.SelectedRows[0].Cells[9].Value.ToString();
            textBox10.Text = dataGridView1.SelectedRows[0].Cells[10].Value.ToString();
            dateTimePicker1.Text = dataGridView1.SelectedRows[0].Cells[11].Value.ToString(); ;
        }

        private void button1_Click(object sender, EventArgs e)
        {

            String query = "insert into itp.patient_details (Patient_Id,First_Name,Last_Name,Age,Illness,Address,Address_2,City,Guardian_Name,G_Contact_No,Special_Comments,Date) values('" + textBox11.Text + "','" + textBox1.Text + "','"+textBox2.Text+"','"+textBox3.Text+"','"+textBox4.Text+"','"+textBox5.Text+"','"+textBox6.Text+"','"+textBox7.Text+"','"+textBox8.Text+"','"+textBox9.Text+"','"+textBox10.Text+"','"+dateTimePicker1.Text+"');";
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

         private void button4_Click(object sender, EventArgs e)
        {
            TransportMain tm = new TransportMain();
            tm.Show();
            this.Hide();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void PatientDetails_Load(object sender, EventArgs e)
        {
      
        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {
            
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsLetter(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != 32 )
            {
                e.Handled = true;

            }
            else
            {
                e.Handled = false;
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
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

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter (e.KeyChar) && e.KeyChar !=8 && e.KeyChar != 32)

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
            if(!char.IsLetter (e.KeyChar) && e.KeyChar !=8 && e.KeyChar !=32)
            {
                e.Handled = true;
            }
            else
            {
                e.Handled = false;
            }

        }

        private void textBox8_KeyPress(object sender, KeyPressEventArgs e)
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

        private void textBox9_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsDigit(e.KeyChar) && e.KeyChar !=8 )
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
            if(!char.IsLetterOrDigit(e.KeyChar) && e.KeyChar !=8 && e.KeyChar !=32 )
            {
                e.Handled = true;
            }
            else
            {
                e.Handled = false;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string query = "delete from itp.patient_details where Patient_Id ='" + textBox11.Text+ "';";
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
            autoGenerateID();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string query = "update itp.patient_details set First_Name='" + textBox1.Text + "',Last_Name='" + textBox2.Text + "',Age='" + textBox3.Text + "',Illness='" + textBox4.Text + "',Address='" + textBox5.Text + "',Address_2='" + textBox6.Text + "',City='" + textBox7.Text + "',Guardian_Name='" + textBox8.Text + "',G_Contact_No='" + textBox9.Text + "',Special_Comments='" + textBox10.Text + "',Date='" + dateTimePicker1.Text + "' where Patient_Id= '" + textBox11.Text + "' ";
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
            autoGenerateID();
        }
    }
}
