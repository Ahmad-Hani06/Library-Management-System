using System;
using System.Data;
using System.Data.SqlClient;
using System.Runtime.CompilerServices;
using clsConnetionStringDatabase;

namespace clsDataAccessLayer
{
    public class clsPersonData
    {
        public static bool GetPersonByID(int PersonID, ref string FullName, ref string Address, ref string Phone, ref string Email, ref DateTime DateOfBirth, ref DateTime CreatedAt)
        {
            bool isFound = false;
            using (SqlConnection connection = new SqlConnection(clsConnectionString.connectionString))
            {
                using (SqlCommand command = new SqlCommand("SP_GetPersonByID", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@PersonID", PersonID);
                    connection.Open();

                   using (SqlDataReader reader = command.ExecuteReader())
                   {
                        if (reader.Read())
                        {
                            isFound = true;
                            FullName = reader["FullName"].ToString();

                            if (reader["Address"] != DBNull.Value)
                            Address = reader["Address"].ToString();

                            if (reader["Phone"] != DBNull.Value)
                                Phone = reader["Phone"].ToString();


                            if (reader["Email"] != DBNull.Value)
                            Email = reader["Email"].ToString();

                            if (reader["DateOfBirth"] != DBNull.Value)
                            DateOfBirth = (DateTime)reader["DateOfBirth"];


                            if (reader["CreatedAt"] != DBNull.Value)
                            CreatedAt = (DateTime)reader["CreatedAt"];
                        }
                   }
                }
            }
            return isFound;

        }

        public static int   AddNewPerson(string FullName, string Address, string Phone, string Email, DateTime? DateOfBirth)
        {
            int newPersonID = -1;
            using (SqlConnection connection = new SqlConnection(clsConnectionString.connectionString))
            {
                using (SqlCommand command = new SqlCommand("dbo.SP_AddNewPerson", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@FullName", FullName);

                    if (string.IsNullOrEmpty(Address))
                        command.Parameters.AddWithValue("@Address", DBNull.Value);
                    else
                        command.Parameters.AddWithValue("@Address", Address);


                    if (string.IsNullOrEmpty(Phone))
                    {
                        command.Parameters.AddWithValue("@Phone", DBNull.Value);
                    }
                    else
                    {
                        command.Parameters.AddWithValue("@Phone", Phone);
                    }

                    if (string.IsNullOrEmpty(Email))
                    {
                        command.Parameters.AddWithValue("@Email", DBNull.Value);
                    }
                    else
                    {
                        command.Parameters.AddWithValue("@Email", Email);
                    }

                    if (DateOfBirth.HasValue)
                        command.Parameters.AddWithValue("@DateOfBirth", DateOfBirth);

                    else
                        command.Parameters.AddWithValue("@DateOfBirth", DBNull.Value);



                    SqlParameter parameter = new SqlParameter("@NewPersonID", SqlDbType.Int)
                    {
                        Direction = ParameterDirection.Output
                    };
                    command.Parameters.Add(parameter);
                    connection.Open();
                    command.ExecuteNonQuery();

                    newPersonID = (int)command.Parameters["@NewPersonID"].Value;
                }
            }

            return newPersonID;
        }
        public static bool UpdatePerson(int PersonID, string FullName, string Address, string Phone, string Email, DateTime DateOfBirth) 
        {
            int rowAffected = 0;
            using (SqlConnection connection = new SqlConnection(clsConnectionString.connectionString))
            {
                using(SqlCommand command = new SqlCommand("dbo.SP_UpdatePerson",connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@PersonID", PersonID);
                    command.Parameters.AddWithValue("@FullName", FullName);
                    command.Parameters.AddWithValue("@Address", Address);
                    command.Parameters.AddWithValue("@Phone", Phone);
                    command.Parameters.AddWithValue("@Email", Email);
                    command.Parameters.AddWithValue("@DateOfBirth", DateOfBirth);

                    SqlParameter returnParameter = command.Parameters.Add("@ReturnValue", SqlDbType.Int);
                    returnParameter.Direction = ParameterDirection.ReturnValue;

                    connection.Open();

                   command.ExecuteNonQuery();
                   rowAffected = Convert.ToInt32(returnParameter.Value);

                }
            }
            return rowAffected > 0;
        }

        public static DataTable GetAllPerson()
        {
            DataTable dt = new DataTable();
            using(SqlConnection connection = new SqlConnection(clsConnectionString.connectionString))
            {
                using (SqlCommand command = new SqlCommand("dbo.SP_GetAllPersons", connection))
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
    }
}
