using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using MySql.Data.MySqlClient;
using FamilyCareHospital.DBAccess;
using System.Windows.Forms;

namespace FamilyCareHospital.Controllers
{
    class LipidTest
    {
        private int CTNo;
        private double HDL;
        private double LDL;
        private double serum_cholesterol;
        private string units;
        private MySqlConnection conn = ConnectionManager.GetConnection();
        private LabTest labtest;

        public void Cholesterol(double HDL, double LDL, double serum_cholesterol, string units)
        {
            this.serum_cholesterol = serum_cholesterol;
            this.HDL = HDL;
            this.LDL = LDL;
            this.units = units;
        }

        public static Dictionary<string, string> identifyLipidTests(string test)
        {
            var dic = new Dictionary<string, string>();

            //string patternLipid = @"LC";

            //Match Lipid = Regex.Match(testID, patternLipid);



            if (test == "lipid")
            {
                dic.Add("field1_units", "mg/dm\u00b3");
                dic.Add("field1_name", "HDL");
                dic.Add("field1_dataType", "double");

                dic.Add("field2_units", "mg/dm\u00b3");
                dic.Add("field2_name", "LDL");
                dic.Add("field2_dataType", "double");

                dic.Add("field3_units", "mg/dm\u00b3");
                dic.Add("field3_name", "Serum Cholesterol");
                dic.Add("field3_dataType", "double");

                dic.Add("field_num", "3");
                return dic;
            }

            else
                return dic;

        }

        public bool insertCholestrolTest(string PID, string testid, string hdl, string ldl, string serum_cholesterol)
        {
            if (string.IsNullOrEmpty(ldl) || string.IsNullOrEmpty(hdl) || string.IsNullOrEmpty(serum_cholesterol))
            {
                return false;
            }
            else
            {
                string query;
                labtest = new LabTest();
                //conn = ConnectionManager.GetConnection();
                try
                {
                    conn.Open();
                    query = "INSERT INTO lab_lipid_profile_test(PatientID,HDL,LDL,serum_cholesterol)VALUES(@PID,@HDL,@LDL,@serum_ch);";
                    var command = new MySqlCommand(query, conn);
                    command.Parameters.AddWithValue("@PID", Convert.ToInt32(PID));
                    command.Parameters.AddWithValue("@HDL", Convert.ToDouble(hdl));
                    command.Parameters.AddWithValue("@LDL", Convert.ToDouble(ldl));
                    command.Parameters.AddWithValue("@serum_ch", Convert.ToDouble(serum_cholesterol));

                    if (command.ExecuteNonQuery() > 0)
                    {
                        labtest.updateLabTestStatus(PID, testid);
                        return true;
                    }
                    else
                    {
                        return false;
                    }

                }
                catch (Exception e)
                {
                    MessageBox.Show("DB Error :" + e.Message);
                    return false;
                }

                finally
                {
                    conn.Close();
                }
            }
        }

        public Dictionary<string,string> getCholesterolTestData(string PID)
        {
            //conn = ConnectionManager.GetConnection();
            var dic =new  Dictionary<string, string>();
            string query;
            try
            {
                conn.Open();
                query = "SELECT HDL,LDL,serum_cholesterol FROM itp.lab_lipid_profile_test where PatientID=@PID";
                var command = new MySqlCommand(query, conn);
                command.Parameters.AddWithValue("@PID", Convert.ToInt32(PID));

                MySqlDataReader dr = command.ExecuteReader();

                while(dr.HasRows && dr.Read())
                {
                    dic.Add("field1_name", "HDL");
                    dic.Add("field1_value", dr["HDL"].ToString());
                    dic.Add("field2_name", "LDL");
                    dic.Add("field2_value", dr["LDL"].ToString());
                    dic.Add("field3_name", "Serum Cholesterol");
                    dic.Add("field3_value", dr["serum_cholesterol"].ToString());

                }
                dic.Add("field_num", "3");

                return dic;

            }
            catch (Exception e)
            {
                MessageBox.Show("DB Error :" + e.Message);
                return null;
            }
            finally
            {
                conn.Close();
            }

        }

        public bool updateCholesterolTest(string PID, string hdl, string ldl, string serum_cholesterol)
        {
            if (string.IsNullOrEmpty(ldl) || string.IsNullOrEmpty(hdl) || string.IsNullOrEmpty(serum_cholesterol))
            {
                return false;
            }

            else
            {
                string query;
                try
                {
                    conn.Open();
                    query = "UPDATE lab_lipid_profile_test SET HDL =@HDL ,LDL =@LDL ,serum_cholesterol =@serum_ch WHERE PatientID =@PID ;";
                    var command = new MySqlCommand(query, conn);
                    command.Parameters.AddWithValue("@PID", Convert.ToInt32(PID));
                    command.Parameters.AddWithValue("@HDL", Convert.ToDouble(hdl));
                    command.Parameters.AddWithValue("@LDL", Convert.ToDouble(ldl));
                    command.Parameters.AddWithValue("@serum_ch", Convert.ToDouble(serum_cholesterol));

                    if (command.ExecuteNonQuery() > 0)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
                catch (Exception e)
                {
                    MessageBox.Show("DB Error :" + e.Message);
                    return false;
                }
                finally
                {
                    conn.Close();
                }

            }
        }

    }
}
