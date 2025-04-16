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

        static public string GetUsername(string username)
        {
            using (SqlConnection conn = new SqlConnection(SQLQueries.connectionString))
            {
                try
                {
                    conn.Open();

                    SqlCommand GetUser = new SqlCommand(SQLQueries.getUser, conn);
                    GetUser.Parameters.AddWithValue("@username", username);

                    SqlDataReader reader = GetUser.ExecuteReader();

                    while (reader.Read())
                    {
                        string user = reader["username"].ToString();
                        if (user == username)
                        {
                            return user;
                        }
                        else if (user != username)
                        {
                            return null;
                        }
                    }

                    return null;
                }
                catch (Exception)
                {
                    return null;
                    throw; 
                }
                finally
                {
                    conn.Close();
                }
            }
        }

        static public string GetPassword(string username)
        {
            using (SqlConnection conn = new SqlConnection(SQLQueries.connectionString))
            {
                try
                {
                    conn.Open();
                    SqlCommand GetPassword = new SqlCommand(SQLQueries.getPassword, conn);
                    GetPassword.Parameters.AddWithValue("@username", username);
                    SqlDataReader reader = GetPassword.ExecuteReader();
                    while (reader.Read())
                    {
                        string password = reader["password"].ToString();
                        return password;
                    }
                    return null;
                }
                catch (Exception)
                {
                    return null;
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
