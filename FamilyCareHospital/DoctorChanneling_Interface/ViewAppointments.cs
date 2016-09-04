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
    public partial class View_Appointments : Form
    {
        public View_Appointments()
        {
            InitializeComponent();
            label8.Text = ""; label9.Text = ""; dnamelbl.Text = ""; spelbl.Text = ""; panamelbl.Text = ""; appdatelbl.Text = ""; phnelbl.Text = ""; noOfApp.Text = "";
        }

        static string mycon = "SERVER=localhost; DATABASE=itp; UID=root; PASSWORD=sagarox";
        MySqlConnection mc = new MySqlConnection(mycon);

        private void button1_Click_1(object sender, EventArgs e)
        {
           
            validation val = new validation();
            try
            {
                if (val.textisEmpty(dctrnametxt, label8) & val.textisEmpty(appdatetxt, label9) == true)
                {
                    if (val.alphaVal(dctrnametxt.Text, label8) == true)
                    {
                        mc.Open();
                        String qry = "select DoctorName, Speciality, AppDate, PatientName, PatientAge, PatientPhone from appointmentdetails where DoctorName like '%" + dctrnametxt.Text + "%' and AppDate='" + appdatetxt.Text + "' ";
                        string qry1 = "select count(APID) from appointmentdetails where DoctorName like '%" + dctrnametxt.Text + "%' and AppDate='" + appdatetxt.Text + "' ";
                        MySqlDataAdapter ad = new MySqlDataAdapter(qry, mycon);

                        MySqlCommand cmd = new MySqlCommand(qry1, mc);
                        MySqlDataReader myReader;
                        myReader = cmd.ExecuteReader();
                        while (myReader.Read())
                        {
                            noOfApp.ForeColor = System.Drawing.Color.Blue;
                            noOfApp.Text = myReader.GetString(0);
                        }
                        DataTable tb = new DataTable();
                        ad.Fill(tb);
                        appdetailsview.DataSource = tb;
                        mc.Close();
                    }
                    else
                    {
                        MessageBox.Show("Invalid values!!");
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
        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            this.appdatetxt.Text = e.Start.ToString("dd-MM-yyyy");
        }

        private void appdetailsview_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                {
                    DataGridViewRow rw = appdetailsview.Rows[e.RowIndex];
                    dnamelbl.ForeColor = System.Drawing.Color.Blue; spelbl.ForeColor = System.Drawing.Color.Blue; appdatelbl.ForeColor = System.Drawing.Color.Blue;
                    panamelbl.ForeColor = System.Drawing.Color.Blue;  phnelbl.ForeColor = System.Drawing.Color.Blue;

                    dnamelbl.Text = rw.Cells["DoctorName"].Value.ToString();
                    spelbl.Text = rw.Cells["Speciality"].Value.ToString();
                    appdatelbl.Text = rw.Cells["AppDate"].Value.ToString();
                    panamelbl.Text = rw.Cells["PatientName"].Value.ToString();
                   // paAgelbl.Text = rw.Cells[" PatientAge"].Value.ToString();
                    phnelbl.Text = rw.Cells["PatientPhone"].Value.ToString();
                }
            }
            catch(Exception ex)
            {
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
            ad.ShowDialog();*/
        }

        private void dctrnametxt_MouseClick(object sender, MouseEventArgs e)
        {
            dctrnametxt.AutoCompleteMode = AutoCompleteMode.Suggest;
            dctrnametxt.AutoCompleteSource = AutoCompleteSource.CustomSource;
            AutoCompleteStringCollection App = new AutoCompleteStringCollection();

            String query = "select * from appointmentdetails;";
            MySqlCommand cmd = new MySqlCommand(query, mc);
            MySqlDataReader rdr;

            try
            {

                mc.Open();
                rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    String cn = rdr.GetString("DoctorName");
                    App.Add(cn);
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);

            }

            dctrnametxt.AutoCompleteCustomSource = App;
            mc.Close();

         }
    }
}
