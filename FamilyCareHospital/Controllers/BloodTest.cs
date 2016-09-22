using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using MySql.Data.MySqlClient;
using FamilyCareHospital.DBAccess;
using System.Windows.Forms;
using System.Data;
using FamilyCareHospital.Interfaces;

namespace FamilyCareHospital.Controllers
{
    class BloodTest
    {
        //private int BTNo;
        private int sugar;
        private int WBC;
        private int RBC;
        private int Platelet_Count;
        private string units;
        private MySqlConnection conn;
        private LabTest labtest;

        public BloodTest()
        {
            labtest = new LabTest();
        }

        public void BloodSugar(int sugar,string testUnits)
        {
            this.sugar = sugar;
            units = testUnits;
        }

        public void BloodCellCount(int wbcCount,int rbcCount)
        {
            WBC = wbcCount;
            RBC = rbcCount;
        }

        public void PlateletCount(int plateletCount)
        {
            Platelet_Count = plateletCount;
        }

        public static Dictionary<string,string> identifyBloodTests(string test)
        {
            var dic = new Dictionary<string, string> ();

            //string patternSugar=@"BS";
            //string patternCellCount = @"BCC";
            //string patternPlatelets= @"PC"; 
            //Match sugar = Regex.Match(testID, patternSugar);
            //Match cellCount = Regex.Match(testID, patternCellCount);
            //Match platelet = Regex.Match(testID, patternPlatelets);

            if ("sugar"==test)
            {
                dic.Add("field1_units", "mg/dm\u00b3");
                dic.Add("field1_name", "Sugar");
                dic.Add("field1_dataType", "int");
                dic.Add("field_num", "1");
                return dic;
            }
            if ("cellcount" == test)
            {
                dic.Add("field1_units", "");
                dic.Add("field1_name", "WBC");
                dic.Add("field1_dataType", "int");
                dic.Add("field2_units", "");
                dic.Add("field2_name", "RBC");
                dic.Add("field2_dataType", "int");
                dic.Add("field_num", "2");
                return dic;
            }
             if ("platelet"==test)
            {
                dic.Add("field1_units", "");
                dic.Add("field1_name", "Platelet Count");
                dic.Add("field1_dataType", "int");
                dic.Add("field_num", "1");
                return dic;
            }

            return dic;  

        }

        private string checkBloodTestPatient(string PID)
        {
            if (conn.State.ToString() == "Closed")
            {
                conn.Open();
            }

            try
            {
                var function = "lab_check_BloodTestPatient";
                var functionCommand = new MySqlCommand(function, conn);
                functionCommand.CommandType = System.Data.CommandType.StoredProcedure;
                functionCommand.Parameters.AddWithValue("@PID", PID);
                string testno = functionCommand.ExecuteScalar().ToString();
                return testno;

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


        public bool insertSugar(string PID,string testid,string value)
        {
            if (string.IsNullOrEmpty(value))
            {
                return false;
            }
            else
            {
                conn = ConnectionManager.GetConnection();
                string query;
                string testno = checkBloodTestPatient(PID);
                MySqlCommand command;
                try
                {
                    conn.Open();

                    if (testno != null)
                    {
                        query = "update lab_blood_test set  Sugar=@sugar where Num=@num";
                        command = new MySqlCommand(query, conn);
                        command.Parameters.AddWithValue("@num", Convert.ToInt32(testno));
                        command.Parameters.AddWithValue("@sugar", Convert.ToInt32(value));
                    }

                    else
                    {

                        query = "insert into lab_blood_test(PatientID,Sugar) values(@PID,@sugar)";
                         command = new MySqlCommand(query, conn);
                        command.Parameters.AddWithValue("@PID", Convert.ToInt32(PID));
                        command.Parameters.AddWithValue("@sugar", Convert.ToInt32(value));
                    }

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


        public bool insertPlatelet(string PID, string testid, string value)
        {
            if (string.IsNullOrEmpty(value))
            {
                return false;
            }
            else
            {
                conn = ConnectionManager.GetConnection();
                string query;
                string testno = checkBloodTestPatient(PID);
                MySqlCommand command;
                try
                {
                    conn.Open();

                    if (testno != null)
                    {
                        query = "update lab_blood_test set  platelet_count=@platelet where Num=@num";
                        command = new MySqlCommand(query, conn);
                        command.Parameters.AddWithValue("@num", Convert.ToInt32(testno));
                        command.Parameters.AddWithValue("@platelet", Convert.ToInt32(value));
                    }

                    else
                    {

                        query = "insert into lab_blood_test(PatientID,platelet_count) values(@PID,@platelet)";
                        command = new MySqlCommand(query, conn);
                        command.Parameters.AddWithValue("@PID", Convert.ToInt32(PID));
                        command.Parameters.AddWithValue("@platelet", Convert.ToInt32(value));
                    }

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



        public bool insertCellCount(string PID, string testid, string wbc,string rbc)
        {
            if (string.IsNullOrEmpty(wbc) || string.IsNullOrEmpty(rbc))
            {
                return false;
            }
            else
            {
                conn = ConnectionManager.GetConnection();
                string query;
                MySqlCommand command;
                string testno = checkBloodTestPatient(PID);
                try
                {
                    conn.Open();

                    

                    if (!string.IsNullOrEmpty(testno))
                    {

                        query = "update lab_blood_test set  blood_cell_count_WBC=@WBC,blood_cell_count_RBC=@RBC where Num=@num";
                         command = new MySqlCommand(query, conn);
                        command.Parameters.AddWithValue("@num", Convert.ToInt32(testno));
                        command.Parameters.AddWithValue("@WBC", Convert.ToInt32(wbc));
                        command.Parameters.AddWithValue("@RBC", Convert.ToInt32(rbc));
                    }

                    else
                    {
                        query = "insert into lab_blood_test(PatientID,blood_cell_count_WBC,blood_cell_count_RBC) values(@PID,@WBC,@RBC)";
                         command = new MySqlCommand(query, conn);
                        command.Parameters.AddWithValue("@PID", Convert.ToInt32(PID));
                        command.Parameters.AddWithValue("@WBC", Convert.ToInt32(wbc));
                        command.Parameters.AddWithValue("@RBC", Convert.ToInt32(rbc));
                    }

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

        public Dictionary<string,string> getSugarValues(string PID)
        {
            conn = ConnectionManager.GetConnection();
            var dic = new Dictionary<string, string>();
            string query;
            try
            {
                conn.Open();
                query = "SELECT Sugar FROM lab_blood_test where PatientID=@PID;";
                var command = new MySqlCommand(query, conn);
                command.Parameters.AddWithValue("@PID", Convert.ToInt32(PID));
                string value = command.ExecuteScalar().ToString();
                dic.Add("field1_name","Sugar");
                dic.Add("field1_value", value);
                dic.Add("field_num", "1");

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


        public Dictionary<string, string> getBloodCellCountValues(string PID)
        {
            conn = ConnectionManager.GetConnection();
            var dic = new Dictionary<string, string>();
            string query;
            try
            {
                conn.Open();
                query = "SELECT blood_cell_count_WBC,blood_cell_count_RBC FROM lab_blood_test where PatientID=@PID limit 1;";
                var command = new MySqlCommand(query, conn);
                command.Parameters.AddWithValue("@PID", Convert.ToInt32(PID));
                MySqlDataReader dr = command.ExecuteReader();

                while (dr.HasRows && dr.Read())
                {
                    dic.Add("field1_name", "WBC");
                    dic.Add("field1_value", dr["blood_cell_count_WBC"].ToString());
                    dic.Add("field2_name", "RBC");
                    dic.Add("field2_value", dr["blood_cell_count_RBC"].ToString());
                    
                }
                dic.Add("field_num", "2");

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


        public Dictionary<string, string> getPlateletValues(string PID)
        {
            conn = ConnectionManager.GetConnection();
            var dic = new Dictionary<string, string>();
            string query;
            try
            {
                conn.Open();
                query = "SELECT platelet_count FROM lab_blood_test where PatientID=@PID;";
                var command = new MySqlCommand(query, conn);
                command.Parameters.AddWithValue("@PID", Convert.ToInt32(PID));
                string value = command.ExecuteScalar().ToString();
                dic.Add("field1_name", "Platelet Count");
                dic.Add("field1_value", value);
                dic.Add("field_num", "1");

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

        public DataSet fillSugarReport(string PID)
        {
            string query;
            conn = ConnectionManager.GetConnection();
            try
            {
                conn.Open();
                query = "select lp.labPatientName,lp.labPatientAge,lp.labPatientGender,lbt.sugar,la.labAppointmentDate,lp.labPatientID from lab_blood_test lbt,lab_patient lp,lab_appointment la where lp.labPatientID=lbt.PatientID and lp.labPatientID=@PID and la.labPatientID=lp.labPatientID";
                var command = new MySqlCommand(query, conn);
                command.Parameters.AddWithValue("@PID", Convert.ToInt32(PID));
                var da = new MySqlDataAdapter(command);
                var s = new sugar();
                s.Clear();
                da.Fill(s.Tables["sugarRes1"]);
                return s;
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

        public DataSet fillPlateletReport(string PID)
        {
            string query;
            conn = ConnectionManager.GetConnection();
            try
            {
                conn.Open();
                query = "select lp.labPatientName,lp.labPatientAge,lp.labPatientGender,lbt.platelet_count,la.labAppointmentDate,lp.labPatientID from lab_blood_test lbt,lab_patient lp,lab_appointment la where lp.labPatientID=lbt.PatientID and lp.labPatientID=@PID and la.labPatientID=lp.labPatientID";
                var command = new MySqlCommand(query, conn);
                command.Parameters.AddWithValue("@PID", Convert.ToInt32(PID));
                var da = new MySqlDataAdapter(command);
                var ds = new sugar();
                ds.Clear();
                da.Fill(ds.Tables["plateletCountTable"]);
                return ds;
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



        public DataSet fillCellcountReport(string PID)
        {
            string query;
            conn = ConnectionManager.GetConnection();
            try
            {
                conn.Open();
                query = "select lp.labPatientName,lp.labPatientAge,lp.labPatientGender,lbt.blood_cell_count_WBC,lbt.blood_cell_count_RBC,la.labAppointmentDate from lab_blood_test lbt,lab_patient lp,lab_appointment la where lp.labPatientID=lbt.PatientID and la.labPatientID=lp.labPatientID and lp.labPatientID=@PID";
                var command = new MySqlCommand(query, conn);
                command.Parameters.AddWithValue("@PID", Convert.ToInt32(PID));
                var da = new MySqlDataAdapter(command);
                var ds = new sugar();
                ds.Clear();
                da.Fill(ds.Tables["cellCount1"]);
                return ds;
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

    }
}
