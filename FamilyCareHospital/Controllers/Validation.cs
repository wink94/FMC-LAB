using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.Net.Mail;
using MySql.Data.MySqlClient;
using FamilyCareHospital.DBAccess;

namespace FamilyCareHospital.Controllers
{
    class Validation 
    {
        private Dictionary<string, string> errmsg;
        private string errormsg_IsNumeric;
        private string errormsg_alphaVal;
        private string errormsg_numberVal;
        private string errormsg_emailVal;
        private string errormsg_EmailUnique;
        private string errormsg_PhoneUnique;

        public string AlphabeticEror{ get { return errormsg_alphaVal; } }
        public string NumericEror { get { return errormsg_IsNumeric; } }
        public string TelephoneNumberEror { get { return errormsg_numberVal; } }
        public string TelephoneNumberEror_unique { get { return errormsg_PhoneUnique; } }
        public string EmailEror { get { return errormsg_emailVal; } }
        public string EmailEror_unique { get { return errormsg_EmailUnique; } }


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

                errormsg_numberVal = "*invalid entry only 10 number are allowed .!";
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

        /* double validation*/
        public bool IsDouble(string input)
        {
            double test;

            if (!double.TryParse(input, out test))
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
                errormsg_checkTestListEmpty = "*Test List cannot be empty. Please Select Tests .!" + "\n";
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

        public bool isEmailUnique(string value)
        {
            var conn = ConnectionManager.GetConnection();
            
            string procedure;
            int count;

            if (conn.State.ToString() == "Closed")
            {
                try
                {
                    conn.Open();
                    
                        procedure = "check_email_exist";
                        var command = new MySqlCommand(procedure, conn);
                        command.CommandType = System.Data.CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@email", value);
                        count = Convert.ToInt32(command.ExecuteScalar());

                        if (count > 0)
                        {
                            errormsg_EmailUnique = "*Email is a duplicate .!";
                            return false;
                        }
                        else
                        {
                            errormsg_EmailUnique = "";
                            return true;
                        }
                    


                }
                catch (Exception e)
                {

                    return false;
                }
                finally
                {
                    conn.Close();
                }

                
            }

            return false;
        }

        public bool isPhoneUnique(string value)
        {
            var conn = ConnectionManager.GetConnection();

            string procedure;
            int count;

            if (conn.State.ToString() == "Closed")
            {
                try
                {
                    conn.Open();

                    procedure = "check_phone_exist";
                    var command = new MySqlCommand(procedure, conn);
                    command.CommandType = System.Data.CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@phone", value);
                    count = Convert.ToInt32(command.ExecuteScalar());

                    if (count > 0)
                    {
                        errormsg_PhoneUnique = "*Phone Number is a duplicate .!";
                        return false;
                    }
                    else
                    {
                        errormsg_PhoneUnique = "";
                        return true;
                    }



                }
                catch (Exception e)
                {

                    return false;
                }
                finally
                {
                    conn.Close();
                }


            }

            return false;
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
