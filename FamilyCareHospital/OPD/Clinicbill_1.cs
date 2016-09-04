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
    public partial class Clinicbill_1 : Form
    {
        string MyConnection = "datasource=localhost;port=3306;username=root;password=sagarox";
        string BillID = "BI-";

        public Clinicbill_1()
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
                string Query = "Select Count(billNo) from itp.clinic_bill;";
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
                    string Query2 = "SELECT billNo FROM itp.clinic_bill order by billNo desc limit 1;";
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


        private void button1_Click(object sender, EventArgs e)
        {
            try
            {

                string Query = "insert into itp.clinic_bill(BillNo,BillDate,NextDate,Amount) values('" + this.txtBill_No.Text + "','" + this.txtBill_Date.Text + "','" + this.txtNext_Date.Text + "','" + this.txtbill_Amount.Text + "');";
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

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {


                string Query = "select * from itp.clinic where ClinicID LIKE '%" + this.txtPatient.Text + "%'; ";
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

        private void Clinicbill_1_Load(object sender, EventArgs e)
        {
            txtBill_Date.Text = DateTime.Now.ToLongDateString();
            
            txtNext_Date.Text = DateTime.Now.AddDays(28).ToLongDateString();


           
            AutoGenerateBID();
        }

        private void txtFirstName_KeyPress(object sender, KeyPressEventArgs e)
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

        private void btn_Back_ManageInPa_Click(object sender, EventArgs e)
        {
            this.Close();
            OPDmain opdm = new OPDmain();
            opdm.Show();
        }
    }
}
