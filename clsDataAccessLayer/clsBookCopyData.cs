using clsConnetionStringDatabase;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clsDataAccessLayer
{
    public class clsBookCopyData
    {
        public static int GetAvailableCopiesCountByBookID(int BookID)
        {
            int AvailableCopies = -1;

            using (SqlConnection connection =
                new SqlConnection(clsConnectionString.connectionString))
            {
                using (SqlCommand command =
                    new SqlCommand("SP_GetAvailableCopiesCountByBookID", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.AddWithValue("@BookID", BookID);

                    try
                    {
                        connection.Open();

                        object result = command.ExecuteScalar();

                        if (result != null && result != DBNull.Value)
                        {
                            AvailableCopies = Convert.ToInt32(result);
                        }
                    }
                    catch (Exception)
                    {
                        AvailableCopies = -1;
                    }
                }
            }

            return AvailableCopies;
        }

        public static int AddNewBookCopy(int BookID)
        {
            int BookCopyID = -1;

            using (SqlConnection connection =
                new SqlConnection(clsConnectionString.connectionString))
            {
                using (SqlCommand command =
                    new SqlCommand("SP_AddNewBookCopy", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.AddWithValue("@BookID", BookID);

                    try
                    {
                        connection.Open();

                        object result = command.ExecuteScalar();

                        if (result != null &&
                            int.TryParse(result.ToString(), out int ID))
                        {
                            BookCopyID = ID;
                        }
                    }
                    catch
                    {
                        BookCopyID = -1;
                    }
                }
            }

            return BookCopyID;
        }

        public static bool GetBookCopyByID(
            int BookCopyID,
            ref int BookID,
            ref int BookCopyStatus)
        {
            bool IsFound = false;

            using (SqlConnection connection =
                new SqlConnection(clsConnectionString.connectionString))
            {
                using (SqlCommand command =
                    new SqlCommand("SP_GetBookCopyByID", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.AddWithValue(
                        "@BookCopyID", BookCopyID);

                    try
                    {
                        connection.Open();

                        using (SqlDataReader reader =
                            command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                IsFound = true;

                                BookID =
                                    (int)reader["BookID"];

                                BookCopyStatus =
                                    (int)reader["BookCopyStatus"];
                            }
                        }
                    }
                    catch
                    {
                        IsFound = false;
                    }
                }
            }

            return IsFound;
        }


        public static bool UpdateBookCopyStatus(
            int BookCopyID,
            int BookCopyStatus)
        {
            int RowsAffected = 0;

            using (SqlConnection connection =
                new SqlConnection(clsConnectionString.connectionString))
            {
                using (SqlCommand command =
                    new SqlCommand("SP_UpdateBookCopyStatus", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.AddWithValue(
                        "@BookCopyID", BookCopyID);

                    command.Parameters.AddWithValue(
                        "@BookCopyStatus", BookCopyStatus);

                    try
                    {
                        connection.Open();

                        RowsAffected =
                            command.ExecuteNonQuery();
                    }
                    catch
                    {
                        RowsAffected = 0;
                    }
                }
            }

            return RowsAffected > 0;
        }


        public static List<int> GetAvailableBookCopyByBookID(int BookID)
        {
            List<int> bookCopies = new List<int>();
            using (SqlConnection connection =
                new SqlConnection(clsConnectionString.connectionString))
            {
                using (SqlCommand command =
                    new SqlCommand("SP_GetAvailableBookCopiesByBookID", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.AddWithValue("@BookID", BookID);

                    connection.Open();

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            bookCopies.Add((int)reader["BookCopyID"]);
                        }
                    }
                }
            }
            return bookCopies;

        }
    }
}
