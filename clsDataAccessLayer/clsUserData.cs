using clsConnetionStringDatabase;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace clsDataAccessLayer
{
    public class clsUserData
    {
        public static bool GetUserByID(int UserID, ref int PersonID, ref string UserName, ref string PasswordHash, ref bool IsActive)
        {
            bool isFound = false;
            using(SqlConnection connection = new SqlConnection(clsConnectionString.connectionString))
            {
                using (SqlCommand command = new SqlCommand("SP_GetUserByID", connection))
                {
                    command.CommandType = System.Data.CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@UserID", UserID);
                    connection.Open();

                    using(SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            isFound = true;
                            PersonID = (int)reader["PersonID"];
                            UserName = reader["UserName"].ToString();
                            PasswordHash = reader["PasswordHash"].ToString();
                            IsActive = (bool)reader["IsActive"];
                        }
                    }
                }
            }
            return isFound;
        }

        public static DataTable GetAllUsers()
        {
            DataTable dt = new DataTable();
            using (SqlConnection connection = new SqlConnection(clsConnectionString.connectionString))
            {
                using (SqlCommand command = new SqlCommand("dbo.SP_GetAllUsers", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    connection.Open();

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            dt.Load(reader);
                        }
                    }
                }
            }
            return dt;
        }

        public static int AddNewUser(int PersonID, string UserName, string PasswordHash, bool IsActive)
        {
            int newUserID = -1;
            using (SqlConnection connection = new SqlConnection(clsConnectionString.connectionString))
            {
                using (SqlCommand command = new SqlCommand("dbo.SP_AddNewUser", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@PersonID", PersonID);
         
                    command.Parameters.AddWithValue("@UserName", UserName);
           
                    command.Parameters.AddWithValue("@PasswordHash", PasswordHash);
 
                    command.Parameters.AddWithValue("@IsActive", IsActive);
                    


                    SqlParameter parameter = new SqlParameter("@UserID", SqlDbType.Int)
                    {
                        Direction = ParameterDirection.Output
                    };
                    command.Parameters.Add(parameter);
                    connection.Open();
                    command.ExecuteNonQuery();

                    newUserID = (int)command.Parameters["@UserID"].Value;
                }
            }

            return newUserID;
        }
        public static bool UpdateUser(int UserID, string UserName, bool IsActive)
        {
            int rowAffected = 0;
            using (SqlConnection connection = new SqlConnection(clsConnectionString.connectionString))
            {
                using (SqlCommand command = new SqlCommand("dbo.SP_UpdateUser", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@UserID", UserID);
                    command.Parameters.AddWithValue("@UserName", UserName);
                    command.Parameters.AddWithValue("@IsActive", IsActive);

                    SqlParameter returnParameter = command.Parameters.Add("@RowsAffected", SqlDbType.Int);
                    returnParameter.Direction = ParameterDirection.Output;

                    connection.Open();

                    command.ExecuteNonQuery();
                    rowAffected = (int)command.Parameters["@RowsAffected"].Value;
                }
            }
            return rowAffected > 0;
        }


        public static bool IsPersonAlreadyUser(int PersonID)
        {
            bool isPersonExists = false;

            using (SqlConnection connection = new SqlConnection(clsConnectionString.connectionString))
            {
                using (SqlCommand command = new SqlCommand("dbo.SP_IsPersonExists", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.AddWithValue("@PersonID", PersonID);
                    SqlParameter ReturnParameter = command.Parameters.Add("@ReturnValue", SqlDbType.Int);
                    ReturnParameter.Direction = ParameterDirection.ReturnValue;
                    connection.Open();
                    command.ExecuteNonQuery();

                    isPersonExists = Convert.ToBoolean(ReturnParameter.Value);
                }
            }
            return isPersonExists;
        }

        public static bool IsUserNameExists(string UserName)
        {
            bool isUserNameExists = false;
            using (SqlConnection connection = new SqlConnection(clsConnectionString.connectionString))
            {
                using (SqlCommand command = new SqlCommand("dbo.SP_IsUserNameExist", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@UserName", UserName);
                    SqlParameter ReturnParameter = command.Parameters.Add("@ReturnValue", SqlDbType.Int);
                    ReturnParameter.Direction = ParameterDirection.ReturnValue;
                    connection.Open();
                    command.ExecuteNonQuery();
                    isUserNameExists = Convert.ToBoolean(command.Parameters["@returnValue"].Value);
                }
            }
            return isUserNameExists;
        }


        public static bool Login(
           string UserName,
           string PasswordHash,
           ref int UserID)
        {
            bool IsFound = false;

            using (SqlConnection connection =
                new SqlConnection(clsConnectionString.connectionString))
            {
                using (SqlCommand command =
                    new SqlCommand("SP_Login", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.AddWithValue("@UserName", UserName);
                    command.Parameters.AddWithValue("@PasswordHash", PasswordHash);

                    try
                    {
                        connection.Open();

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                IsFound = true;

                                UserID = Convert.ToInt32(reader["UserID"]);
                            }
                        }
                    }
                    catch (Exception)
                    {
                        IsFound = false;
                    }
                }
            }

            return IsFound;
        }

    }
}
