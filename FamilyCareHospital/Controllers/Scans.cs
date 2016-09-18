using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using FamilyCareHospital.DBAccess;
using System.Windows.Forms;

namespace FamilyCareHospital.Controllers
{
    class Scans
    {
        private int SNo;
        private bool CT;
        private bool MRI;
        private bool X_RAY;
        private MySqlConnection conn;
        private LabTest labtest;
        

        public bool CT_Scan { set { CT = value; } get { return CT; } }
        public bool MRI_Scan { set { MRI = value; } get { return MRI; } }
        public bool X_RAY_Scan { set { X_RAY = value; } get { return X_RAY; } }
        

        public bool setScanStatus(int LTRNo, bool status,bool scanFlag)
        {
            string query;

            if (!scanFlag )
                return false;
            

            try
            {
                conn = ConnectionManager.GetConnection();
                conn.Open();


                query = "update lab_test_result set labAppointmentStatus=@sts where labTestNo=@ltrno";
                var command = new MySqlCommand(query, conn);
                command.Parameters.AddWithValue("@sts", status);
                command.Parameters.AddWithValue("@ltrno", Convert.ToInt32(LTRNo));

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
