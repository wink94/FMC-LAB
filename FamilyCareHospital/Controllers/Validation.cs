using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.Net.Mail;

namespace FamilyCareHospital.Controllers
{
    class Validation 
    {
        private Dictionary<string, string> errmsg;
        private string errormsg_IsNumeric;
        private string errormsg_alphaVal;
        private string errormsg_numberVal;
        private string errormsg_emailVal;

        public string AlphabeticEror{ get { return errormsg_alphaVal; } }
        public string NumericEror { get { return errormsg_IsNumeric; } }
        public string TelephoneNumberEror { get { return errormsg_numberVal; } }
        public string EmailEror { get { return errormsg_emailVal; } }


        //public string Error { get; }
        public Validation()
        {
            errmsg = new Dictionary<string, string> {
            {"alphaVal","" },{"numberVal","" },{"emailVal","" },{"IsNumeric","" },{"alphaNumericVal","" }, {"TestListEmpty","" }, {"checkFieldIsSet","" } };
        }
        /* letters only!! validation*/

        public bool alphaVal(string val)
        {
            string pattern = @"^[A-Za-z.\s]+$";
            Match m = Regex.Match(val, pattern);
            

            if (!m.Success || val.Length > 45)
            {
                errormsg_alphaVal = "*invalid entry only letters are allowed in  .!";
                //errmsg["alphaVal"]= errormsg_alphaVal;
                return false;
            }
            else
            {
                errormsg_alphaVal = "";
                //errmsg["alphaVal"] = errormsg_alphaVal;
                return true;
            }
        }

        /* phone number validation*/
        public bool numberVal(string val)
        {
            string pattern = @"\d{10}";
            Match m = Regex.Match(val, pattern);
            

            if (!m.Success || val.Length != 10)
            {

                errormsg_numberVal = "*invalid entry only 10 number are allowed ";
                //errmsg["numberVal"]=errormsg_numberVal;
                return false;
            }
            else
            {
                errormsg_numberVal = "";
                //errmsg["numberVal"] = errormsg_numberVal;
                return true;
            }

        }
        /* email validation*/
        public bool emailVal(string emailaddress)
        {
            
            try
            {
                MailAddress m = new MailAddress(emailaddress);
                errormsg_emailVal = "";
                //errmsg["emailVal"]=errormsg_emailVal;
                return true;
            }
            catch (Exception )
            {
                errormsg_emailVal = "*invalid email !";
                //errmsg["emailVal"] = errormsg_emailVal;
                return false;
            }
        }

        /* numeric validation*/
        public bool IsNumeric(string input)
        {
            int test;
            
            if (!int.TryParse(input, out test))
            {
                errormsg_IsNumeric = "*invalid numeric value in .!";
                //errmsg["IsNumeric"]=errormsg_IsNumeric;
                return false;
            }
            else
            {
                errormsg_IsNumeric = "";
                //errmsg["IsNumeric"] = errormsg_IsNumeric;
                return true;
            }
        }

        /* check for alphbatical and numeric characters  */

        public bool alphaNumericVal(string val,string field)
        {
            string pattern = @"^[A-Za-z0-9-\s]+$";
            Match m = Regex.Match(val, pattern);
            string errormsg_alphaNumericVal;

            if (!m.Success || val.Length > 45)
            {
                errormsg_alphaNumericVal = "*invalid entry only letters are allowed in " + field.ToUpper() + ".!\n";
                //errmsg["alphaNumericVal"]=errormsg_alphaNumericVal;
                return false;
            }
            else
            {
                errormsg_alphaNumericVal = "";
                //errmsg["alphaNumericVal"] = errormsg_alphaNumericVal;
                return true;
            }
        }
        /* patient test list check */
        public bool checkTestListEmpty(LabPatient lp)
        {
            string errormsg_checkTestListEmpty;
            if (!lp.checkTestListEmpty())
            {
                errormsg_checkTestListEmpty = "*Test List cannot be empty. Please Select Tests!" + "\n";
                MessageBox.Show(errormsg_checkTestListEmpty, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            //else
            //{
            //    errormsg_checkTestListEmpty = "";
            //    errmsg["TestListEmpty"] = errormsg_checkTestListEmpty;
            //    return true;
            //}
            else
                return true;
        }

        public bool checkFieldIsSet(string value)
        {
            string checkFieldIsSet;
            if (value=="" ||value==null)
            {
                checkFieldIsSet = " *field cannot be empty.!" + "\n";
                //errmsg["checkFieldIsSet"] = checkFieldIsSet;
                messageString(checkFieldIsSet);
                return false;
            }
            else
            {
                checkFieldIsSet = "";
                //errmsg["checkFieldIsSet"] = checkFieldIsSet;
                messageString(checkFieldIsSet);
                return true;
            }
        }


        public bool checkDateIsSet(string value,string field)
        {
            string checkFieldIsSet;
            if (value == "" || value == null)
            {
                checkFieldIsSet = field+" Date  cannot be empty.! ";
                //errmsg["checkFieldIsSet"] = checkFieldIsSet;
                MessageBox.Show(checkFieldIsSet, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else
                return true;
            
        }


       /* public void printError(bool val)
        {
            if (val)
            {
                string msg="";
               foreach(var a in errmsg)
                {
                    if (a.Value != "")
                        msg += a.Value;
                }
                MessageBox.Show(msg,"Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }*/




        public string messageString(string msg)
        {
            return msg;
        }

    }
}
