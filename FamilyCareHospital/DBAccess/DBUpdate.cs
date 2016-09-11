using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using FamilyCareHospital.Controllers;
using System.Windows.Forms;

namespace FamilyCareHospital.DBAccess
{
    class DBUpdate
    {

        private MySqlConnection conn;

        public DBUpdate()
        {
            conn = ConnectionManager.GetConnection();
        }
        


    }
}
