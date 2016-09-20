using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using FamilyCareHospital.Controllers;

namespace FamilyCareHospital.DBAccess
{
    class DBRetrieve
    {

        private MySqlConnection conn;

        public DBRetrieve()
        {
            conn = ConnectionManager.GetConnection();
        }



        /*  retrieve test details from db */

        public DataTable getSearchedTestDetails(string testName = null)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("TestID", typeof(string));
            dt.Columns.Add("TestName", typeof(string));
            string query;

            try
            {
                conn.Open();

                if(testName!=null || testName!=" ")
                    query = "select labTestID,labTestName from lab_test where labTestName like '%" + testName + "%'";
                else
                    query = "select labTestID,labTestName from lab_test";

                MySqlCommand newCmd = new MySqlCommand(query, conn);        
                MySqlDataReader dr = newCmd.ExecuteReader(); 

                while (dr.Read())
                {
                    dt.Rows.Add(dr["labTestID"], dr["labTestName"]);        //read retrived data row wise
                }

            }
            catch (MySqlException e)
            {
                MessageBox.Show("DB Error " + e.Message);
            }
            conn.Close();
            return dt;
        }

        /* populate datagridview with test details*/

        public DataSet getLabTest()
        {
            if (conn.State.ToString() == "Closed")
            {
                conn.Open();
            }

            string query = "select * from lab_test";
            MySqlCommand newCmd = new MySqlCommand(query, conn);
            
            DataSet ds = new DataSet();
            try
            {
                MySqlDataAdapter da = new MySqlDataAdapter(newCmd);
                da.Fill(ds, "labtests");
            }

            catch (Exception e)
            {
                MessageBox.Show("DB Error " + e.Message);
            }
            conn.Close();

            return ds;
        }

        /* get lab  test by test id or test name by search key word*/
        public DataSet getSearcehdLabTest(string test=null)
        {
            string query;
            LabTest labtest = new LabTest();

            if (conn.State.ToString() == "Closed")
            {
                conn.Open();
            }

            if(labtest.searchTestByID(test))
                query = "select * from lab_test where  labTestID like '%" + test + "%'";
            else
                query = "select * from lab_test where  labTestName like '%" + test + "%'";

            MySqlCommand newCmd = new MySqlCommand(query, conn);

            DataSet ds = new DataSet();
            try
            {
                MySqlDataAdapter da = new MySqlDataAdapter(newCmd);
                da.Fill(ds, "searchtests");
            }

            catch (Exception e)
            {
                MessageBox.Show("DB Error " + e.Message);
            }
            conn.Close();

            return ds;
        }
        /*get lasst patient's id*/
        public string getRegisteredPatientID()
        {
            string query= "SELECT max(labPatientID) FROM lab_patient";
            string id="";
            try
            {
                conn.Open();
                MySqlCommand newCmd = new MySqlCommand(query, conn);
                id = newCmd.ExecuteScalar().ToString();

            }
            catch (MySqlException e)
            {
                MessageBox.Show("DB Error :" + e.Message);
                return null;
            }

            conn.Close();
            return id;
        }

        /* get  appointment count on date */
        public int getAppointmentCount(string date)
        {
            string query = "SELECT count(labAppointmentID) FROM lab_appointment where labAppointmentDate='" + date+"'";
            int count=-1 ;
            try
            {
                conn.Open();
                MySqlCommand newCmd = new MySqlCommand(query, conn);
                
                count = Convert.ToInt32(newCmd.ExecuteScalar());

            }
            catch (MySqlException e)
            {
                MessageBox.Show("DB Error :" + e.Message);
                return -1;
            }

            conn.Close();
            return count;
        }

        /*get appointment limit*/

        public int getAppointmentLimit()
        {
            string query = "SELECT appointment_limit,max(ID) FROM lab_appointment_limit";
            int count = -1;
            try
            {
                conn.Open();
                MySqlCommand newCmd = new MySqlCommand(query, conn);

                count = Convert.ToInt32(newCmd.ExecuteScalar());

            }
            catch (MySqlException e)
            {
                MessageBox.Show("DB Error :" + e.Message);
                return -1;
            }

            conn.Close();
            return count;
        }

        /* populate datagridview with appointment details */

        public DataSet getAppointmentDetails()
        {
            if (conn.State.ToString() == "Closed")
            {
                conn.Open();
            }

            string query = "SELECT la.labAppointmentID ,la.labPatientID ,lp.labPatientName ,DATE_FORMAT(la.labAppointmentDate, '%Y-%m-%d') as labAppointmentDate FROM lab_patient lp, lab_appointment la WHERE lp.labPatientID = la.labPatientID ";
            MySqlCommand newCmd = new MySqlCommand(query, conn);

            DataSet ds = new DataSet();
            try
            {
                MySqlDataAdapter da = new MySqlDataAdapter(newCmd);
                da.Fill(ds, "lab_appointments");
            }

            catch (Exception e)
            {
                MessageBox.Show("DB Error " + e.Message);
            }
            conn.Close();

            return ds;
        }


        /* get lab  appointment by lab apponiment id search key word*/
        public DataSet getSearcehdLabAppointment(string labappmnt = null)
        {
            string query;
            int appmntID = Convert.ToInt32(labappmnt);
            LabTest labtest = new LabTest();

            if (conn.State.ToString() == "Closed")
            {
                conn.Open();
            }

            
            query = "SELECT la.labAppointmentID ,la.labPatientID ,lp.labPatientName ,la.labAppointmentDate FROM lab_patient lp, lab_appointment la WHERE lp.labPatientID = la.labPatientID AND la.labAppointmentID  like '%" + appmntID + "%'";
            

            MySqlCommand newCmd = new MySqlCommand(query, conn);

            DataSet ds = new DataSet();
            try
            {
                MySqlDataAdapter da = new MySqlDataAdapter(newCmd);
                da.Fill(ds, "lab_appointments");
            }

            catch (Exception e)
            {
                MessageBox.Show("DB Error " + e.Message);
            }
            conn.Close();

            return ds;
        }

        /* get lab  appointment by lab apponiment date search */
        public DataSet getSearcehdLabAppointmentFromDate(DateTime fromDate,DateTime toDate )
        {
            string query,Date1,Date2;
            Date1=fromDate.ToString("yyyy-MM-dd");
            Date2=toDate.ToString("yyyy-MM-dd");
            

            if (conn.State.ToString() == "Closed")
            {
                conn.Open();
            }


            query = "SELECT la.labAppointmentID ,la.labPatientID ,lp.labPatientName ,la.labAppointmentDate FROM lab_patient lp, lab_appointment la WHERE lp.labPatientID = la.labPatientID AND la.labAppointmentDate >='"+Date1+ "' AND la.labAppointmentDate <='"+Date2+"'";


            MySqlCommand newCmd = new MySqlCommand(query, conn);

            DataSet ds = new DataSet();
            try
            {
                MySqlDataAdapter da = new MySqlDataAdapter(newCmd);
                da.Fill(ds, "lab_appointments");
            }

            catch (Exception e)
            {
                MessageBox.Show("DB Error " + e.Message);
            }
            conn.Close();

            return ds;
        }

        //public bool getTestStatusOfPatient(string PID,MySqlDataReader datareader)
        //{
        //    string query;

        //    if (conn.State.ToString() == "Closed")
        //    {
        //        conn.Open();
        //    }

        //    try
        //    {
        //        //conn.Open();
        //        query= "SELECT labAppointmentStatus FROM lab_test_result WHERE labPatientID = @PID";
        //        MySqlCommand command = new MySqlCommand(query,conn);
        //        command.Parameters.AddWithValue("@PID",Convert.ToInt32(PID));

        //        //MySqlDataReader datareader = command.ExecuteReader();
        //        datareader = command.ExecuteReader();

        //        while (datareader.HasRows && datareader.Read())
        //        {
        //            if(!Convert.ToBoolean(datareader["labAppointmentStatus"]))
        //            {
        //                return false;
        //            }
        //        }

        //    }

        //    catch (Exception e)
        //    {
        //        MessageBox.Show("connection error"+e.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                
        //    }
        //    finally
        //    {
        //        conn.Close();
                
        //    }
        //    return true;

        //}

        public DataSet getTestPatientList(string appointmentID=null,string fromdate=null,string todate=null)
        {
            
            var dataset = new DataSet();
            DataTable dt = dataset.Tables.Add("TestPatients");
            string query,previous="";
            int count = 0;

            dt.Columns.Add("AppointmentID", typeof(string));
            dt.Columns.Add("PatientID", typeof(string));
            dt.Columns.Add("PatientName", typeof(string));
            dt.Columns.Add("AppointmentDate", typeof(string));
            dt.Columns.Add("TestStatus", typeof(string));

            if (conn.State.ToString() == "Closed")
            {
                conn.Open();
                
            }

            try
            {
                //conn.Open();
                if (appointmentID == null && fromdate == null && todate == null)
                {
                    query = "SELECT distinct la.labAppointmentID ,la.labPatientID ,lp.labPatientName ,la.labAppointmentDate,ltr.labAppointmentStatus FROM lab_patient lp, lab_appointment la,lab_test_result ltr  WHERE lp.labPatientID = la.labPatientID  AND ltr.labPatientID=lp.labPatientID";
                }
                else if(fromdate == null && todate == null)
                {
                    query = "SELECT distinct la.labAppointmentID ,la.labPatientID ,lp.labPatientName ,la.labAppointmentDate,ltr.labAppointmentStatus FROM lab_patient lp, lab_appointment la,lab_test_result ltr  WHERE lp.labPatientID = la.labPatientID  AND ltr.labPatientID=lp.labPatientID AND la.labAppointmentID  LIKE '%" + appointmentID + "%'";

                }
                else
                {
                    query = "SELECT distinct la.labAppointmentID ,la.labPatientID ,lp.labPatientName ,la.labAppointmentDate,ltr.labAppointmentStatus FROM lab_patient lp, lab_appointment la,lab_test_result ltr  WHERE lp.labPatientID = la.labPatientID  AND ltr.labPatientID=lp.labPatientID AND la.labAppointmentDate >='" + fromdate + "' AND la.labAppointmentDate <='" + todate + "'";

                }

                MySqlCommand command = new MySqlCommand(query,conn);
                MySqlDataReader datareader = command.ExecuteReader();

                while ( datareader.Read())
                {
                    if (count == 0)
                    {
                        if (!Convert.ToBoolean(datareader["labAppointmentStatus"]) )
                        {
                            dt.Rows.Add(datareader["labAppointmentID"], datareader["labPatientID"], datareader["labPatientName"], Convert.ToDateTime(datareader["labAppointmentDate"]).ToString("yyyy-MM-dd"), "Incomplete");
                            
                            previous = datareader["labAppointmentID"].ToString();
                        }
                        else
                        {
                            dt.Rows.Add(datareader["labAppointmentID"], datareader["labPatientID"], datareader["labPatientName"], Convert.ToDateTime(datareader["labAppointmentDate"]).ToString("yyyy-MM-dd"), "Complete");
                            
                            previous = datareader["labAppointmentID"].ToString();
                        }
                    }
                    else
                    {
                        if(previous== datareader["labAppointmentID"].ToString())
                        {
                            //if (!Convert.ToBoolean(datareader["labAppointmentStatus"]))
                            //{
                                //dataset.Tables["TestPatients"].Rows[count-1]["TestStatus"]= "Incomplete";
                            dt.Rows[count - 1]["TestStatus"] = "Incomplete";

                            //    dt.Rows.Add(datareader["labAppointmentID"], datareader["labPatientID"], datareader["labPatientName"], Convert.ToDateTime(datareader["labAppointmentDate"]).ToString("yyyy-MM-dd"), "Incomplete");
                            //    //dt.AcceptChanges();
                            count--;
                              
                        }
                        else
                        {

                            if (!Convert.ToBoolean(datareader["labAppointmentStatus"]))
                            {
                                dt.Rows.Add(datareader["labAppointmentID"], datareader["labPatientID"], datareader["labPatientName"], Convert.ToDateTime(datareader["labAppointmentDate"]).ToString("yyyy-MM-dd"), "Incomplete");
                                
                                previous = datareader["labAppointmentID"].ToString();
                            }
                            else
                            {
                                dt.Rows.Add(datareader["labAppointmentID"], datareader["labPatientID"], datareader["labPatientName"], Convert.ToDateTime(datareader["labAppointmentDate"]).ToString("yyyy-MM-dd"), "Complete");
                                
                                previous = datareader["labAppointmentID"].ToString();
                            }

                        }


                    }

                    count++;
                }
                //dt.AcceptChanges();
                datareader.Close();

            }
            catch (Exception e)
            {
                MessageBox.Show("connection error "+e.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

            finally
            {
                conn.Close();
            }
            return dataset;
        }

        public Dictionary<string,string> getTestPrices(List<getTestList> lst)
        {
            var dic = new Dictionary<string, string>();
            string query="";
            double tot = 0;
            string price;

            try
            {
                conn.Open();
                var command = new MySqlCommand(query, conn);

                foreach(getTestList gtl in lst)
                {
                    command.CommandText = "SELECT labTestPrice FROM lab_test where labTestID='"+ gtl.id+"'";
                    //command.Parameters.AddWithValue("@LTID", gtl.id);
                    price = command.ExecuteScalar().ToString();
                    dic.Add(gtl.name, price);
                    tot += Convert.ToDouble(price);
                }

                dic.Add("Total :", tot.ToString("N2"));

                return dic;
            }
            catch (Exception e)
            {
                MessageBox.Show("connection error " + e.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
            finally
            {
                conn.Close();
            }

        }

    }
}
