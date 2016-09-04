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
using System.Configuration;
using System.Text.RegularExpressions;

namespace FamilyCareHospital
{
    public partial class Add_Prescription : Form
    {
        string MyConnection = "datasource=localhost;port=3306;username=root;password=sagarox";
        string ClinicID = "PR-";

        public Add_Prescription()
        {
            InitializeComponent();
        }

        private void lblLastName_Click(object sender, EventArgs e)
        {

        }

        private string SearchNum(string st)
        {
            return string.Join("\n", Regex.Split(st, "[^\\d]"));
        }

        private void AutoGeneratePrescID()
        {
            MySqlConnection Myconn2 = new MySqlConnection(MyConnection);
            Myconn2.Open();

            try
            {
                string Query = "Select Count(Presc_ID) from itp.prescription;";
                MySqlCommand cmd = new MySqlCommand(Query, Myconn2);
                int i = Convert.ToInt32(cmd.ExecuteScalar());
                int j;

                if (i == 0)
                {
                    i = i + 1;
                    j = i + 100;

                    this.txtPresciption_ID.Text = ClinicID + j.ToString();
                }
                else
                {
                    string Query2 = "SELECT Presc_ID FROM itp.prescription order by Presc_ID desc limit 1;";
                    MySqlCommand cmd1 = new MySqlCommand(Query2, Myconn2);

                    string value = (string)cmd1.ExecuteScalar();
                    string s = SearchNum(value);

                    int k = Convert.ToInt32(s);
                    k = k + 1;

                    this.txtPresciption_ID.Text = ClinicID + k.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            Myconn2.Close();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            try
            {

                string Query = "insert into itp.prescription(Presc_ID,Date,Chistory,Medication,Note) values('" + this.txtPresciption_ID.Text + "','" + this.txtDate.Text + "','" + this.richtxtCase_History.Text + "','" + this.richtxtMedication.Text + "','" + this.richtxtNote.Text + "');";
                MySqlConnection MyConn2 = new MySqlConnection(MyConnection);
                MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);
                MySqlDataReader MyReader2;
                MyConn2.Open();
                MyReader2 = MyCommand2.ExecuteReader();
                MessageBox.Show("Save Prescription details");
                while (MyReader2.Read())
                {

                }
                MyConn2.Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void Add_Prescription_Load(object sender, EventArgs e)
        {
            AutoGeneratePrescID();
            txtDate.Text = DateTime.Now.ToLongDateString();
        }

        private void txtBill_Date_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_Back_ManageInPa_Click(object sender, EventArgs e)
        {
            this.Close();
            OPDmain opdm = new OPDmain();
            opdm.Show();
        }
    }
}
