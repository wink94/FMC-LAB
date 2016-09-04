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
    public partial class OPDbill_1 : Form
    {
        string MyConnection = "datasource=localhost;port=3306;username=root;password=sagarox";
        string BillID = "BI-";

        public OPDbill_1()
        {
            InitializeComponent();
        }

        private string SearchNum(string st)
        {
            return string.Join("\n", Regex.Split(st, "[^\\d]"));
        }


        private void AutoGenerateBID()
        {
            MySqlConnection Myconn2 = new MySqlConnection(MyConnection);
            Myconn2.Open();

            try
            {
                string Query = "Select Count(billNo) from itp.opd_bill;";
                MySqlCommand cmd = new MySqlCommand(Query, Myconn2);
                int i = Convert.ToInt32(cmd.ExecuteScalar());
                int j;

                if (i == 0)
                {
                    i = i + 1;
                    j = i + 100;

                    this.txtBill_No.Text = BillID + j.ToString();
                }
                else
                {
                    string Query2 = "SELECT billNo FROM itp.opd_bill order by billNo desc limit 1;";
                    MySqlCommand cmd1 = new MySqlCommand(Query2, Myconn2);

                    string value = (string)cmd1.ExecuteScalar();
                    string s = SearchNum(value);

                    int k = Convert.ToInt32(s);
                    k = k + 1;

                    this.txtBill_No.Text = BillID + k.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            Myconn2.Close();
        }

        private void Token()
        {
            MySqlConnection Myconn2 = new MySqlConnection(MyConnection);
            string currentdate = DateTime.Now.ToLongDateString();


            Myconn2.Open();

            string Query3 = "SELECT BillDate FROM itp.opd_bill order by BillNo desc limit 1;";
            MySqlCommand cmd2 = new MySqlCommand(Query3, Myconn2);

            string value1 = (string)cmd2.ExecuteScalar();


            try
            {
                string Query = "Select Count(TokenNo) from itp.opd_bill;";
                MySqlCommand cmd = new MySqlCommand(Query, Myconn2);
                int i = Convert.ToInt32(cmd.ExecuteScalar());
                int j;

                if (i == 0)
                {
                    j = i + 1;


                    this.txtToken_No.Text = j.ToString();
                }
                else if (currentdate == value1)
                {
                    string Query2 = "SELECT TokenNo FROM itp.opd_bill order by TokenNo desc limit 1;";
                    MySqlCommand cmd1 = new MySqlCommand(Query2, Myconn2);

                    int value = (int)cmd1.ExecuteScalar();

                    int k = value;
                    k = k + 1;

                    this.txtToken_No.Text = k.ToString();
                }
                else if (currentdate != value1)
                {
                    int m = 0;
                    j = m + 1;


                    this.txtToken_No.Text = j.ToString();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            Myconn2.Close();
        }


        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {

                string Query=("select * from itp.opd where PatientID LIKE '%" + this.txtPatient.Text + "%';");
               // string Query = "select * from hospital.opd where patientID= " + this.txtPatient.Text + "; "; 
                MySqlConnection MyConn2 = new MySqlConnection(MyConnection);
                MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);
                MySqlDataReader MyReader2;
                MyConn2.Open();
                MyReader2 = MyCommand2.ExecuteReader();

                if (MyReader2.Read())
                {
                    this.txtFirstName.Text = MyReader2.GetString("Fname");
                    this.txtLastName.Text = MyReader2.GetString("Lname");
                    this.txtGender.Text = MyReader2.GetString("Gender");
                    this.txtAge.Text = MyReader2.GetString("Age");
                }
                MyConn2.Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {

                string Query = "insert into itp.opd_bill(BillNo,BillDate,Amount,Doctor,RoomNo,TokenNo) values('" + this.txtBill_No.Text + "','" + this.txtBill_Date.Text + "','" + this.txtbill_Amount.Text + "','" + this.cmbDoctor.SelectedItem + "','" + this.txtRoom_No.Text + "','" + this.txtToken_No.Text + "');";
                MySqlConnection MyConn2 = new MySqlConnection(MyConnection);
                MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);
                MySqlDataReader MyReader2;
                MyConn2.Open();
                MyReader2 = MyCommand2.ExecuteReader();
                MessageBox.Show("Save Bill details");
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

        private void OPDbill_1_Load(object sender, EventArgs e)
        {
            txtBill_Date.Text = DateTime.Now.ToLongDateString();
           

            Token();
            AutoGenerateBID();

        }

        private void txtbill_Amount_KeyPress(object sender, KeyPressEventArgs e)
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

        private void btn_Back_ManageInPa_Click(object sender, EventArgs e)
        {
            this.Close();
            OPDmain opdm = new OPDmain();
            opdm.Show();
        }
    }
}
