using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Tower_Dungeon.Data
{
    class Database_Connection
    {

        string connectionString = SQLQueries.connectionString;

        private void addUsers()
        {
            using (SqlConnection conn = new SqlConnection(SQLQueries.connectionString))
            {

            }
        }
    }
}
