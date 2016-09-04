using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using MySql.Data.MySqlClient;
using System.Configuration;
using System.Windows.Forms;

namespace FamilyCareHospital.DBAccess
{
   public class ConnectionManager
    {
        public static MySqlConnection NewCon;
        public static string ConStr = ConfigurationManager.ConnectionStrings["ConString"].ConnectionString; /* copy or edit app config file according to project */
        //private static string ConStr2 = "SERVER=localhost; DATABASE=itp; UID=root; PASSWORD=123456";
        public static MySqlConnection GetConnection()
        {
            NewCon = new MySqlConnection(ConStr);
            
            return NewCon;
        }

    }
}
