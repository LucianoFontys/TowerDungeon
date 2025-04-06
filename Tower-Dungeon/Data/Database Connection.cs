using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Tower_Dungeon.Business;

namespace Tower_Dungeon.Data
{
    class Database_Connection
    {
        public void addUsers(string username, string fName, string lName, string email, string password, bool isAdmin)
        {
            try
            {
                int isAdminInt = isAdmin ? 1 : 0;

                using (SqlConnection conn = new SqlConnection(SQLQueries.connectionString))
                {
                    try
                    {
                        conn.Open();
                        using (SqlCommand AddUser = new SqlCommand(SQLQueries.addUsers, conn))
                        {
                            AddUser.Parameters.AddWithValue("@fName", fName);
                            AddUser.Parameters.AddWithValue("@lName", lName);
                            AddUser.Parameters.AddWithValue("@email", email);
                            AddUser.Parameters.AddWithValue("@password", PassHash.Hash(password));
                            AddUser.Parameters.AddWithValue("@username", username);
                            AddUser.Parameters.AddWithValue("@isAdmin", isAdminInt);
                            int rowsAffected = AddUser.ExecuteNonQuery();
                        }
                    }
                    catch (Exception)
                    {
                        throw;
                    }

                    finally
                    {
                        conn.Close();
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        static public bool CheckUser(string username, string password)
        {
            using (SqlConnection conn = new SqlConnection(SQLQueries.connectionString))
            {
                try
                {
                    conn.Open();
                    return false;
                }
                catch (Exception)
                {
                    throw;
                }
                finally
                {
                    conn.Close();
                }
            }
        }
    }
}
