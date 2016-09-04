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
    public partial class MakeAppointment : Form
    {
        public MakeAppointment(string dname, string spec, string mnd, string tue, string wen, string thur, string fri, String sat, string sun,string dctrfee,string hospchar,int total)
        {
            InitializeComponent();
            drnamelbl.ForeColor = System.Drawing.Color.Blue; spelbl.ForeColor = System.Drawing.Color.Blue; monlbl.ForeColor = System.Drawing.Color.Blue;
            tuelbl.ForeColor = System.Drawing.Color.Blue; wenlbl.ForeColor = System.Drawing.Color.Blue; thurlbl.ForeColor = System.Drawing.Color.Blue;
            frilbl.ForeColor = System.Drawing.Color.Blue; satlbl.ForeColor = System.Drawing.Color.Blue; sunlbl.ForeColor = System.Drawing.Color.Blue;
            dctrfeelbl.ForeColor = System.Drawing.Color.Blue; hspicharlbl.ForeColor = System.Drawing.Color.Blue; totlamntlbl.ForeColor = System.Drawing.Color.Blue;
            drnamelbl.Text = dname;
            spelbl.Text = spec;
            monlbl.Text = mnd;
            tuelbl.Text = tue;
            wenlbl.Text = wen;
            thurlbl.Text = thur;
            frilbl.Text = fri;
            satlbl.Text = sat;
            sunlbl.Text = sun;
            dctrfeelbl.Text = dctrfee;
            hspicharlbl.Text = hospchar;
            string totalamnt = Convert.ToString(total);
            totlamntlbl.Text = totalamnt;
            label13.Text = ""; label14.Text = ""; label15.Text = ""; label16.Text = "";

        }

        String selctday;
        String selctmonth;
        static string mycon = "SERVER=localhost; DATABASE=itp; UID=root; PASSWORD=sagarox";
        MySqlConnection mc = new MySqlConnection(mycon);

        private void button1_Click(object sender, EventArgs e)
        {
           
            String qry;
            validation val = new validation();
            try
            {
                if (val.textisEmpty(patientnametxt, label13) & val.textisEmpty(phonetxt, label15) & val.textisEmpty(appdatetxt, label16) == true)
                {
                    if (val.alphaVal(patientnametxt.Text, label13) & val.numberVal(phonetxt.Text, label15) & val.IsNumeric(agetxt.Text, label14) == true)
                    {
                        mc.Open();
                        qry = "insert into appointmentdetails(DoctorName,Speciality,TotalAmount,AppDate, PatientName, PatientAge, PatientPhone) values('" + drnamelbl.Text + "','" + spelbl.Text + "','" + totlamntlbl.Text + "','" + appdatetxt.Text + "','" + patientnametxt.Text + "','" + agetxt.Text + "','" + phonetxt.Text + "')";
                        MySqlCommand cmd = new MySqlCommand(qry, mc);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Make Appointment successfully!");
                        mc.Close();
                        
                    }
                    else
                    {
                        MessageBox.Show("Invalid values!");
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
        private void button2_Click(object sender, EventArgs e)
        {
            string todayday = DateTime.Today.ToString("dd");
            string todaymonth = DateTime.Today.ToString("MM");

            int td = Convert.ToInt32(todayday);
            int tm = Convert.ToInt32(todaymonth);

            int sd = Convert.ToInt32(selctday);
            int sm = Convert.ToInt32(selctmonth);
 
            if (sm < tm)
                MessageBox.Show("prvious month");
            else if (sm == tm & sd < td)
                MessageBox.Show("prvious day");
            else
            {
                MessageBox.Show("valid day");

            }
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            this.appdatetxt.Text = e.Start.ToString("dd-MM-yyyy"); //ShortDate
            selctday = e.Start.ToString("dd");
            selctmonth = e.Start.ToString("MM");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

      

        private void button4_Click(object sender, EventArgs e)
        {
            //DoctorSearch ds = new DoctorSearch();
            this.Dispose();
            //ds.ShowDialog();
        }
    }
}
