using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tower_Dungeon.Data
{
    public static class SQLQueries
    {
        public static string connectionString = "Server=mssqlstud.fhict.local;Database=dbi417189;User Id=dbi417189;Password=Vly7GVzPun;";

        public static string addUsers = "INSERT INTO Users (fName, lName, email, password, username, isAdmin) " + "VALUES (@fName, @lName, @email, @password, @username, @isAdmin)";

        public static string validateUser = "SELECT username, password FROM Users WHERE username = @username";
    }
}
