﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Windows.Forms;
using FamilyCareHospital.DBAccess;
using MySql.Data.MySqlClient;

namespace FamilyCareHospital.Controllers
{
    class LabPatient
    {
        private string patientID;
        private int patientAge;
        private string patientName;
        private string patientGender;
        private string patientEmail;
        private string patientTelephone;
        private string patientType;
        private BindingList<getTestList> testList = new BindingList<getTestList>();
        private DBRetrieve dbr = new DBRetrieve();

        public string ID { get { return patientID; } set { patientID = value; } }
        public int Age { get { return patientAge; } set { patientAge = value; } }
        public string Name { get { return patientName; } set { patientName = value; } }
        public string Gender { get { return patientGender; } set { patientGender = value; } }
        public string Email { get { return patientEmail; } set { patientEmail = value; } }
        public string Phone { get { return patientTelephone; } set { patientTelephone = value; } }
        public string PatientType { get { return patientType; } set { patientType = value; } }
        public BindingList<getTestList> tests { get { return testList; } }

        public void setDetails(string PatientName, string PatientGender, string PatientEmail, string PatientTelephone,int PatientAge,string labPatientType)
        {
            patientName = PatientName;
            patientGender = PatientGender;
            patientEmail = PatientEmail;
            patientTelephone = PatientTelephone;
            patientAge = PatientAge;
            patientType = labPatientType;
        }

        public void getPatientTest(getTestList gTL)
        {
            testList.Add(gTL);
        }


        /*  check test-id exist in binding list */

        public bool findIfExist(string id)
        {
            foreach (getTestList gTL in testList)
            {
                if (gTL.id == id)
                    return true;

            }
            return false;
        }


        /*  add tests to patient lists */

        public string getSelectedFromList(string id)
        {
            DataTable dt2 = dbr.getSearchedTestDetails();
            DataRow[] arr;
            string qry = "TestID='" + id + "'";
            arr = dt2.Select(qry);


            return arr[0][1].ToString();

        }

        /*  remove tests from patient list */

        public bool removeTest(int index)
        {
            if (testList.Count > 0 )
            {
                testList.RemoveAt(index);
                return true;
            }
            return false;
            
        }

        public bool checkTestListEmpty()
        {
            return testList.Count > 0;
        }

        public void emptyTestList()
        {
            for(int i = 0; i < testList.Count; i++)
            {
                testList.RemoveAt(i);
            }
        }

        public bool setPatientID()
        {
            patientID = dbr.getRegisteredPatientID();
            return (patientID == null || patientID == "") ? false : true;
        }


        /* delete lab patient and tests from labpatient id*/
        public bool deleteLabPatientAndTests()
        {
            string query1,  query;
            MySqlConnection conn = ConnectionManager.GetConnection();
            try
            {
                conn.Open();
                query1 = "delete from lab_patient  where labPatientID ='" + Convert.ToInt32(ID) + "';";
                //query2 = "delete from lab_test_result  where labPatientID ='" + Convert.ToInt32(ID) + "';";
                query = query1 ;
                MySqlCommand newCmd = new MySqlCommand(query, conn);
                newCmd.ExecuteNonQuery();
                conn.Close();
                return true;
            }
            catch (MySqlException e)
            {
                MessageBox.Show("DB Error :" + e.Message);
                conn.Close();
                return false;
            }

        }

        /* get patinet details from db by patient id */
        public void getLabPatientDetails()
        {
            string query;
            MySqlConnection conn = ConnectionManager.GetConnection();
            try
            {
                conn.Open();


                query = "SELECT labPatientName,labPatientAge,labPatientGender,labPatientEmail,labPatientPhone FROM lab_patient WHERE labPatientID='"+Convert.ToInt32(ID)+"'";
                

                MySqlCommand newCmd = new MySqlCommand(query, conn);
                MySqlDataReader dr = newCmd.ExecuteReader();

                while (dr.Read() && dr.HasRows)
                {
                    patientName=dr["labPatientName"].ToString();        
                    patientAge = Convert.ToInt32(dr["labPatientAge"]);
                    patientGender = dr["labPatientGender"].ToString();
                    patientEmail = dr["labPatientEmail"].ToString();
                    patientTelephone = dr["labPatientPhone"].ToString();
                }

            }
            catch (MySqlException e)
            {
                MessageBox.Show("DB Error " + e.Message);
            }
            conn.Close();
        }

        /*update patients details */
        public void updateLabPatientData( string updateFlag)
        {
            string query="";
            MySqlConnection conn = ConnectionManager.GetConnection();

            try
            {
                conn.Open();

                if (updateFlag == "Name")
                    query = "update lab_patient set labPatientName ='" + Name + "' where labPatientID ='" + Convert.ToInt32(ID) + "'";
                else if (updateFlag == "Age")
                    query = "update lab_patient set labPatientAge ='" + Name + "' where labPatientID ='" + Convert.ToInt32(ID) + "'";
                else if(updateFlag == "Phone")
                    query = "update lab_patient set labPatientPhone ='" + Phone + "' where labPatientID ='" + Convert.ToInt32(ID) + "'";
                else if (updateFlag == "Email")
                    query = "update lab_patient set labPatientEmail ='" + Email + "' where labPatientID ='" + Convert.ToInt32(ID) + "'";
                else if (updateFlag == "Gender")
                    query = "update lab_patient set labPatientGender ='" + Gender + "' where labPatientID ='" + Convert.ToInt32(ID) + "'";

                MySqlCommand newCmd = new MySqlCommand(query, conn);
                newCmd.ExecuteNonQuery();

            }
            catch (MySqlException e)
            {
                MessageBox.Show("DB Error :" + e.Message);
            }
            conn.Close();
        }


        /*get patients test details*/
        public DataSet getPatientsTestList()
        {
            string query;
            var dataset = new DataSet();
            var datatable = dataset.Tables.Add("PatientTestList");
            int count = 0;
            datatable.Columns.Add("Test_LTRNumber", typeof(int));
            datatable.Columns.Add("Test_Number", typeof(int));
            datatable.Columns.Add("Test_Name", typeof(string));
            datatable.Columns.Add("Test_ID", typeof(string));
            datatable.Columns.Add("Test_Status", typeof(string));

            MySqlConnection conn = ConnectionManager.GetConnection();

            try
            {
                conn.Open();
                query = "SELECT ltr.labTestNo,lt.labTestName,lt.labTestID,ltr.labAppointmentStatus  FROM lab_test lt,lab_test_result ltr WHERE lt.labTestID=ltr.labTestID AND ltr.labPatientID=@PID";

                MySqlCommand command = new MySqlCommand(query, conn);
                command.Parameters.AddWithValue("@PID", patientID);

                MySqlDataReader datareader = command.ExecuteReader();
                while (datareader.HasRows && datareader.Read())
                {
                    count++;

                    if (!Convert.ToBoolean(datareader["labAppointmentStatus"]))
                    {
                        datatable.Rows.Add(datareader["labTestNo"], count.ToString(), datareader["labTestName"], datareader["labTestID"], "Incomplete");
                    }
                    else
                    {
                        datatable.Rows.Add(datareader["labTestNo"], count.ToString(), datareader["labTestName"], datareader["labTestID"], "Complete");
                    }

                    
                }
            }

            catch (Exception e)
            {
                MessageBox.Show("connection error " + e.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            finally
            {
                conn.Close();
            }
            return dataset;
        }

        /*insert patient details to DB*/
        public void insertLabPatient()
        {
            string query;
            MySqlConnection conn = ConnectionManager.GetConnection();
            try
            {
                conn.Open();

                query = "insert into lab_patient(labPatientName,labPatientAge,labPatientGender,labPatientEmail,labPatientPhone,labPatientType) values('" + Name + "','" + Age + "','" + Gender + "','" + Email + "','" + Phone + "','"+patientType+"')";

                MySqlCommand newCmd = new MySqlCommand(query, conn);
                newCmd.ExecuteNonQuery();

            }
            catch (MySqlException e)
            {
                MessageBox.Show("DB Error :" + e.Message);
            }
            conn.Close();
        }

        public void insertTestListData(string pid, List<getTestList> lst)
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


    }
}
