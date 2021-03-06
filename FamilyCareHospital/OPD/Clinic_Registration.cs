﻿using System;
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
    public partial class Clinic_Registration : Form
    {
        string MyConnection = "datasource=localhost;port=3306;username=root;password=sagarox";
        string ClinicID = "CI-";

        public Clinic_Registration()
        {
            InitializeComponent();
        }

        private string SearchNum(string st)
        {
            return string.Join("\n", Regex.Split(st, "[^\\d]"));
        }

        private void AutoGenerateCID()
        {
            MySqlConnection Myconn2 = new MySqlConnection(MyConnection);
            Myconn2.Open();

            try
            {
                string Query = "Select Count(ClinicID) from itp.clinic;";
                MySqlCommand cmd = new MySqlCommand(Query, Myconn2);
                int i = Convert.ToInt32(cmd.ExecuteScalar());
                int j;

                if (i == 0)
                {
                    i = i + 1;
                    j = i + 100;

                    this.txtClinicID.Text = ClinicID + j.ToString();
                }
                else
                {
                    string Query2 = "SELECT ClinicID FROM itp.clinic order by ClinicID desc limit 1;";
                    MySqlCommand cmd1 = new MySqlCommand(Query2, Myconn2);

                    string value = (string)cmd1.ExecuteScalar();
                    string s = SearchNum(value);

                    int k = Convert.ToInt32(s);
                    k = k + 1;

                    this.txtClinicID.Text = ClinicID + k.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            Myconn2.Close();
        }

        public string CIDvalue
        {
            get
            {
                string u = SearchNum(txtClinicID.Text);
                int k = Convert.ToInt32(u) - 1;
                string m = k.ToString();
                return m;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            try
            {

                string Query = "insert into itp.clinic(ClinicID,Date,Fname,Lname,NIC,Gender,Age,CivilStatus,BloodGroup,Address,City,ContactNo) values('" + this.txtClinicID.Text + "','" + this.txtRegistrationDate.Text + "','" + this.txtFirstName.Text + "','" + this.txtLastName.Text + "','" + this.txtNic_No.Text + "','" + this.cmbGender.SelectedItem + "','" + this.txtAge.Text + "','"  + this.txtCivil_Status.Text + "','"  + this.txtBlood_Group.Text + "','" + this.txtAddress.Text + "','" + this.txtCity.Text + "','" + this.txtContactNO.Text + "');";
                MySqlConnection MyConn2 = new MySqlConnection(MyConnection);
                MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);
                MySqlDataReader MyReader2;
                MyConn2.Open();
                MyReader2 = MyCommand2.ExecuteReader();
                MessageBox.Show("Save Patient details");
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

        private void Clinic_Registration_Load(object sender, EventArgs e)
        {
            txtRegistrationDate.Text = DateTime.Now.ToLongDateString();
            AutoGenerateCID();
        }

        private void btnBill_Click(object sender, EventArgs e)
        {
            this.Close();
            Clinicbill clb = new Clinicbill();
            clb.Show();
        }

        private void txtContactNO_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtAge_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtLastName_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtNic_No_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar) || e.KeyChar == 'v' || e.KeyChar == 8 || e.KeyChar == 46) //8=backspace, 46=del (allow)
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void txtCity_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) || e.KeyChar == 8 || e.KeyChar == 46) //8=backspace 46=del
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void txtAddress_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (char.IsLetter(e.KeyChar) || char.IsNumber(e.KeyChar) || e.KeyChar == 8 || e.KeyChar == ' ' || e.KeyChar == '/' || e.KeyChar == ',' || e.KeyChar == '.' || e.KeyChar == 46) //8=backspace 46=del
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }
    }
}
