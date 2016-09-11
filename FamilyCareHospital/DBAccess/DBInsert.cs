using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Configuration;
using System.Windows.Forms;
using FamilyCareHospital.Controllers;

namespace FamilyCareHospital.DBAccess
{
    class DBInsert
    {
        MySqlConnection conn;
        public DBInsert()
        {
                conn = ConnectionManager.GetConnection();
        }

        
        




        /*insert lab appointmetn limit details to DB*/
        public  void insertLabAppointmentLimit(string laL)
        {
            string query;

            try
            {
                conn.Open();

                query = "insert into lab_appointment_limit(appointment_limit) values('" + Convert.ToInt32(laL) + "' )";

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
