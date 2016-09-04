using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.Net.Mail;

namespace FamilyCareHospital
{
    class validation
    {
        /*textbox isempty*/
        public bool textisEmpty(TextBox txt, Label lbl)
        {
            string errormsgalphaVal;

            if (txt.Text == "" || txt.Text == null)
            {
                errormsgalphaVal = "*This is mandatory field.Please enter valid value!" + "\n";
                //lbl.ForeColor = Color.Green;
                lbl.ForeColor = System.Drawing.Color.Red;
                lbl.Text = errormsgalphaVal;
                return false;
            }
            else
            {
                lbl.Text = "";
                errormsgalphaVal = "";
                return true;
            }
        }
        /*combobox isempty*/
        public bool comboisEmpty(ComboBox cmb, Label lbl)
        {
            string errormsgalphaVal;

            if (cmb.Text == "" || cmb.Text == null)
            {
                errormsgalphaVal = "*This is mandatory field.Please enter valid value!" + "\n";
                //lbl.ForeColor = Color.Green;
                lbl.ForeColor = System.Drawing.Color.Red;
                lbl.Text = errormsgalphaVal;
                return false;
            }
            else
            {
                lbl.Text ="";
                errormsgalphaVal = "";
                return true;
            }
        }
        /*Two radiobutton isempty*/
        public bool TworadiobuttonisEmpty(RadioButton rb1, RadioButton rb2, Label lbl)
        {
            string errormsgalphaVal;

            if (rb1.Checked | rb2.Checked)
            {
                lbl.Text = "";
                errormsgalphaVal = "";
                return true;
            }
            else
            {
                errormsgalphaVal = "*This is mandatory field.Please enter valid value!" + "\n";
                //lbl.ForeColor = Color.Green;
                lbl.ForeColor = System.Drawing.Color.Red;
                lbl.Text = errormsgalphaVal;
                return false;
            }
        }
        /*Days radiobuttons isempty*/
        public bool DaysradiobuttonisEmpty(RadioButton rb1, RadioButton rb2, RadioButton rb3, RadioButton rb4, RadioButton rb5, RadioButton rb6, RadioButton rb7,
            RadioButton rb8, RadioButton rb9, RadioButton rb10, RadioButton rb11, RadioButton rb12, RadioButton rb13, RadioButton rb14,
            RadioButton rb15, RadioButton rb16, RadioButton rb17, RadioButton rb18, RadioButton rb19, RadioButton rb20, RadioButton rb21, Label lbl)
        {
            string errormsgalphaVal;

            if (rb1.Checked | rb2.Checked | rb3.Checked | rb4.Checked | rb5.Checked | rb6.Checked | rb7.Checked | rb8.Checked | rb9.Checked | rb10.Checked
                | rb11.Checked | rb12.Checked | rb13.Checked | rb14.Checked | rb15.Checked | rb16.Checked | rb17.Checked | rb18.Checked | rb19.Checked | rb20.Checked | rb21.Checked)
            {
                lbl.Text = "";
                errormsgalphaVal = "";
                return true;
            }
            else
            {
                errormsgalphaVal = "*Select Days!" + "\n";
                //lbl.ForeColor = Color.Green;
                lbl.ForeColor = System.Drawing.Color.Red;
                lbl.Text = errormsgalphaVal;
                return false;
            }
        }
        /* letters only!! validation*/

        public bool alphaVal(string val, Label lbl)
        {
            string pattern = @"^[A-Za-z.\s]+$";
            Match m = Regex.Match(val, pattern);
            string errormsgalphaVal;

            if (!m.Success || val.Length > 45)
            {
                errormsgalphaVal = "invalid entry only letters are allowed.!" + "\n";
                lbl.ForeColor = System.Drawing.Color.Red;
                lbl.Text = errormsgalphaVal;
                return false;
            }
            else
            {
                lbl.Text = "";
                errormsgalphaVal = "";
                return true;
            }
        }

        /* phone number validation*/
        public bool numberVal(string val, Label lbl)
        {
            string pattern = @"\d{10}";
            Match m = Regex.Match(val, pattern);
            string errormsgnumberVal;

            if (!m.Success || val.Length != 10)
            {

                errormsgnumberVal = "invalid entry.Please enter 10 digits number!" + "\n";
                lbl.ForeColor = System.Drawing.Color.Red;
                lbl.Text = errormsgnumberVal;
                return false;
            }
            else
            {
                lbl.Text = "";
                errormsgnumberVal = "";
                return true;
            }

        }
        /* email validation*/
        public bool emailVal(string emailaddress, Label lbl)
        {
            string errormsgemailVal;
            try
            {
                MailAddress m = new MailAddress(emailaddress);
                lbl.Text = "";
                errormsgemailVal = "";
                return true;
            }
            catch (Exception)
            {
                errormsgemailVal = "invalid email.!" + "\n";
                lbl.ForeColor = System.Drawing.Color.Red;
                lbl.Text = errormsgemailVal;
                return false;
            }
        }

        /* numeric validation*/
        public bool IsNumeric(string input, Label lbl)
        {
            int test;
            string errormsgIsNumeric;
            if (!int.TryParse(input, out test))
            {
                errormsgIsNumeric = "invalid numeric value.!" + "\n";
                lbl.ForeColor = System.Drawing.Color.Red;
                lbl.Text = errormsgIsNumeric;
                return false;
            }
            else
            {
                lbl.Text = "";
                errormsgIsNumeric = "";
                return true;
            }
        }

        /* check for alphbatical and numeric characters  */

        public bool alphaNumericVal(string val, Label lbl)
        {
            string pattern = @"^[A-Za-z0-9-\s]+$";
            Match m = Regex.Match(val, pattern);
            string errormsgalphaNumericVal;

            if (!m.Success || val.Length > 45)
            {
                errormsgalphaNumericVal = "invalid entry only letters are allowed.!" + "\n";
                lbl.ForeColor = System.Drawing.Color.Red;
                lbl.Text = errormsgalphaNumericVal;
                return false;
            }
            else
            {
                lbl.Text = "";
                errormsgalphaNumericVal = "";
                return true;
            }

        }

        public bool patientLimit(string input, Label lbl)
        {
            int test;
            int x = Convert.ToInt32(input);
            string errormsgIsNumeric;
            if (!int.TryParse(input, out test) | x > 25)
            {
                errormsgIsNumeric = "Invalid numeric and maximum limit is 25.!" + "\n";
                lbl.ForeColor = System.Drawing.Color.Red;
                lbl.Text = errormsgIsNumeric;
                return false;
            }
            else
            {
                lbl.Text = "";
                errormsgIsNumeric = "";
                return true;
            }
        }
    }
}
