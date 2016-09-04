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
    public partial class CalculatePayments : Form
    {
        public CalculatePayments()
        {
            InitializeComponent();
            label1.Text = ""; label2.Text = ""; totalAmntlbl.Text = "";
        }

        string appodate; bool staus = false;
        static string mycon = "SERVER=localhost; DATABASE=itp; UID=root; PASSWORD=sagarox";
        MySqlConnection mc = new MySqlConnection(mycon);

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {

            appodate= e.Start.ToString("dd-MM-yyyy");
            this.datetxt.Text=appodate;
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            validation val = new validation();
            try
            {
                if (val.textisEmpty(dctrnametxt, label1) & val.textisEmpty(datetxt, label2) == true)
                {
                    if (val.alphaVal(dctrnametxt.Text, label1) == true)
                    {
                        mc.Open();
                        string qry = "Select * from appointmentdetails AppDate where DoctorName like '%" + dctrnametxt.Text + "%' ";
                        MySqlCommand cmd1 = new MySqlCommand(qry, mc);
                        MySqlDataReader myReader1;
                        myReader1 = cmd1.ExecuteReader();
                        while (myReader1.Read()) {
                           
                            string appdate = (string)myReader1["AppDate"];
                           
                            if (appdate != appodate)
                            {
                                MessageBox.Show("No appointments for given date!");
                            }
                            else
                            {
                                //MessageBox.Show(" appointments fe!!");
                                staus = true;
                            }
                        }
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
           catch (Exception )
            {
               // MessageBox.Show("No Appointments for given Date!");
            }

            try
            {
                mc.Open();
                if (staus == true) { 
                string qry1 = "select sum(TotalAmount) from appointmentdetails where DoctorName like '%" + dctrnametxt.Text + "%' and AppDate='" + datetxt.Text + "' ";
                MySqlCommand cmd = new MySqlCommand(qry1, mc);
                MySqlDataReader myReader;
                myReader = cmd.ExecuteReader();
                while (myReader.Read())
                {

                    totalAmntlbl.ForeColor = System.Drawing.Color.Blue;
                    string totalAmnt = myReader.GetString(0); //MessageBox.Show("bvnmgm11"+ totalAmnt);
                    totalAmntlbl.Text = totalAmnt;

                } staus = false;

            }
                mc.Close();
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            DoctorMain dm = new DoctorMain();
            this.Hide();
            dm.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            /*Admin ad = new Admin();
            this.Hide();
            ad.ShowDialog();
            */
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

        private void CalculatePayments_Load(object sender, EventArgs e)
        {

        }
    }
}
