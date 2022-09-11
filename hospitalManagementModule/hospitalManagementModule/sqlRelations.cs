using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace hospitalManagementModule
{
    internal class sqlRelations
    {

        public SqlConnection newSqlConnection() // metod adı
        {
            SqlConnection sqlConnect = new SqlConnection("Data Source=DESKTOP-74AFNHN\\SQLEXPRESS;Initial Catalog=hospitalManagementSystem;Integrated Security=True");
            sqlConnect.Open(); // sqlConnect bir nesne
            return sqlConnect;
        }

        public SqlConnection closeSqlConnection()
        {
            SqlConnection sqlDisconnect = new SqlConnection("Data Source=DESKTOP-74AFNHN\\SQLEXPRESS;Initial Catalog=hospitalManagementSystem;Integrated Security=True");
            sqlDisconnect.Close();
            return sqlDisconnect;
        }
    }
}

