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
        private double testPrice;
        private DBUpdate dbu = new DBUpdate();
        private DBDelete dbd = new DBDelete();

        public string ID { get { return testID; } }
        public string Name { get { return testName; } set { testName = value; } }
        public double Price { get { return testPrice; } set { testPrice = value; } }

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



    }
}
