using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using FamilyCareHospital.DBAccess;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace FamilyCareHospital.Controllers
{
    class LabTest
    {
        private string testID;
        private string testName;
        private bool status;
        private double testPrice;
        private MySqlConnection conn;
        //private BloodTest bloodtest;
        private string LTRNo;

        public string ID { get { return testID; } set { testID = value; } }
        public bool Status { get { return status; } set { status = value; } }
        public string Name { get { return testName; } set { testName = value; } }
        public double Price { get { return testPrice; } set { testPrice = value; } }
        public string LTRNumber { set { LTRNo = value; } get { return LTRNo; } }



        /* seaarch test method*/

        public bool searchTestByID(string test)
        {

            string pattern = @"^LT[0-9]+$";
            Match m = Regex.Match(test, pattern);

            return (m.Success && test.Length <= 5);
         
        }

        public void setUpdateTest(string testid,string testname,double testprice)
        {
            testID = testid;
            testName = testname;
            testPrice = testprice;
        }
        //public void updateTest(int updateFlag)
        //{
        //    dbu.updateLabTestData(this, updateFlag);
        //}


        public void removeTest()
        {
            if (deleteLabTest())
            {
                testID = "";
                testName = "";
                testPrice = -1;
            }
        }

        /* enter test list data */
        public static void insertTestListData(string pid, List<getTestList> lst)
        {
            MySqlConnection conn = ConnectionManager.GetConnection();
            try
            {
                conn.Open();

                string query = "";
                foreach (getTestList gtl in lst)
                {
                    query += "insert into lab_test_result(labPatientID,labTestID) values (" + Convert.ToInt32(pid) + ",'" + gtl.id + "');";
                }

                MySqlCommand newCmd = new MySqlCommand(query, conn);
                newCmd.ExecuteNonQuery();

            }
            catch (Exception e)
            {
                MessageBox.Show("DB Error :" + e.Message);
            }
            conn.Close();
        }


        /* delete test from test id*/
        public bool deleteLabTest()
        {
            string query;
            MySqlConnection conn = ConnectionManager.GetConnection();
            try
            {
                conn.Open();
                query = "delete from lab_test  where labTestId ='" + ID + "'";
                MySqlCommand newCmd = new MySqlCommand(query, conn);
                newCmd.ExecuteNonQuery();
                conn.Close();
                return true;
            }
            catch (MySqlException e)
            {
                MessageBox.Show("DB Error :" + e.Message);

                return false;
            }
            finally
            {
                conn.Close();
            }
        }


        /* update test table according according to update flag fieds 1=tesname 2=testprice 3=both*/

        public void updateLabTestData( int updateFlag)
        {
            string query;
            MySqlConnection conn = ConnectionManager.GetConnection();
            try
            {
                conn.Open();

                if (updateFlag == 1)
                    query = "update lab_test set labTestName ='" + Name + "' where labTestId ='" + ID + "'";
                else if (updateFlag == 2)
                    query = "update lab_test set labTestPrice ='" + Price + "' where labTestId ='" + ID + "'";
                else
                    query = "update lab_test set labTestName ='" + Name + "',labTestPrice ='" + Price + "' where labTestId ='" + ID + "'";

                MySqlCommand newCmd = new MySqlCommand(query, conn);
                newCmd.ExecuteNonQuery();

            }
            catch (MySqlException e)
            {
                MessageBox.Show("DB Error :" + e.Message);
            }
            conn.Close();
        }


        public void updateLabTestStatus(string PID,string testID)
        {
            string procedure;
            conn = ConnectionManager.GetConnection();
            if (conn.State.ToString() == "Closed")
            {
                conn.Open();
            }

            try
            {
                procedure = "lab_check_labTestStausAndUpdate";
                var command = new MySqlCommand(procedure, conn);
                command.CommandType = System.Data.CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@PID", Convert.ToInt32(PID));
                command.Parameters.AddWithValue("@TestID",testID);
                command.ExecuteNonQuery();
            }
            catch (Exception e)
            {

                MessageBox.Show("DB Error :" + e.Message);
            }
            finally
            {
                conn.Close();
            }

        }




        public Dictionary<string, string> identifyTest()
        {
            string patternSugar = @"BS";
            string patternCellCount = @"BCC";
            string patternPlatelets = @"PC";
            string patternLipid = @"LC";
        
            Match sugar = Regex.Match(testID, patternSugar);
            Match cellCount = Regex.Match(testID, patternCellCount);
            Match platelet = Regex.Match(testID, patternPlatelets);

            Match Lipid = Regex.Match(testID, patternLipid);

           
            if (sugar.Success)
            {
                return BloodTest.identifyBloodTests("sugar");
            }
            else if (cellCount.Success)
                return BloodTest.identifyBloodTests("cellcount");

            else if (platelet.Success)
                return BloodTest.identifyBloodTests("platelet");

            else if (Lipid.Success)
                return LipidTest.identifyLipidTests("lipid");

            else
                return null;
        }

        public bool identifyScan()
        {
            string patternCT = @"SCT";
            string patternXRAY = @"SX";
            string patternMRI = @"SMRI";


            Match CT = Regex.Match(testID, patternCT);
            Match XRAY = Regex.Match(testID, patternXRAY);
            Match MRI = Regex.Match(testID, patternMRI);

            if (CT.Success || XRAY.Success || MRI.Success)
                return true;
            else
                return false;

        }


        public Dictionary<string, string> getUpdateTestDetails(string PID)
        {

            string patternSugar = @"BS";
            string patternCellCount = @"BCC";
            string patternPlatelets = @"PC";
            string patternLipid = @"LC";

            Match sugar = Regex.Match(testID, patternSugar);
            Match cellCount = Regex.Match(testID, patternCellCount);
            Match platelet = Regex.Match(testID, patternPlatelets);

            Match Lipid = Regex.Match(testID, patternLipid);

            var bloodtest = new BloodTest();
            var lipid = new LipidTest();

            if (sugar.Success)
            {
                return bloodtest.getSugarValues(PID);
            }
            else if (cellCount.Success)
            {
                return bloodtest.getBloodCellCountValues(PID);
            }
            else if (platelet.Success)
            {
                return bloodtest.getPlateletValues(PID);
            }
            else if (Lipid.Success)
            {
                return lipid.getCholesterolTestData(PID);
            }

            return null;

        }

        public static bool insertLabPayment(string PID,string PatientType,string amount,bool paymentStatus=false)
        {
            string query;
           MySqlConnection conn = ConnectionManager.GetConnection();

            try
            {
                conn.Open();
                query = "INSERT INTO lab_payment(labPatientID,labPaymentStatus,PatientType,PatientAmount) VALUES(@PID,@status,@PType,@amount);";

                var command = new MySqlCommand(query, conn);
                command.Parameters.AddWithValue("@PID",PID);
                command.Parameters.AddWithValue("@status", paymentStatus);
                command.Parameters.AddWithValue("@PType", PatientType);
                command.Parameters.AddWithValue("@amount", Convert.ToDouble(amount));

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
