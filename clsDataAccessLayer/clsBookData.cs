using clsConnetionStringDatabase;
using System;
using System.Data;
using System.Data.SqlClient;

namespace clsDataAccessLayer
{
    public class clsBookData
    {

        public static int AddNewBook(
            string Title,
            string AuthorName,
            int BookCategoryID,
            int ISBN,
            int PublicationYear,
            string Description)
        {
            int BookID = -1;

            using (SqlConnection connection =
                new SqlConnection(clsConnectionString.connectionString))
            {
                using (SqlCommand command =
                    new SqlCommand("SP_AddNewBook", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.AddWithValue("@Title", Title);
                    command.Parameters.AddWithValue("@AuthorName", AuthorName);
                    command.Parameters.AddWithValue("@BookCategoryID", BookCategoryID);
                    command.Parameters.AddWithValue("@ISBN", ISBN);
                    command.Parameters.AddWithValue("@PublicationYear", PublicationYear);
                    command.Parameters.AddWithValue("@Description", Description);

                    try
                    {
                        connection.Open();

                        object result = command.ExecuteScalar();

                        if (result != null &&
                            int.TryParse(result.ToString(), out int InsertedID))
                        {
                            BookID = InsertedID;
                        }
                    }
                    catch   
                    {
                        BookID = -1;
                    }
                }
            }

            return BookID;
        }


        public static bool UpdateBook(
            int BookID,
            string Title,
            string AuthorName,
            int BookCategoryID,
            int ISBN,
            int PublicationYear,
            string Description)
        {
            int RowsAffected = 0;

            using (SqlConnection connection =
                new SqlConnection(clsConnectionString.connectionString))
            {
                using (SqlCommand command =
                    new SqlCommand("SP_UpdateBook", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.AddWithValue("@BookID", BookID);
                    command.Parameters.AddWithValue("@Title", Title);
                    command.Parameters.AddWithValue("@AuthorName", AuthorName);
                    command.Parameters.AddWithValue("@BookCategoryID", BookCategoryID);
                    command.Parameters.AddWithValue("@ISBN", ISBN);
                    command.Parameters.AddWithValue("@PublicationYear", PublicationYear);
                    command.Parameters.AddWithValue("@Description", Description);

                    try
                    {
                        connection.Open();

                        RowsAffected = command.ExecuteNonQuery();
                    }
                    catch
                    {
                        return false;
                    }
                }
            }

            return RowsAffected > 0;
        }


        public static bool GetBookByID(
            int BookID,
            ref string Title,
            ref string AuthorName,
            ref int BookCategoryID,
            ref int ISBN,
            ref int PublicationYear,
            ref string Description)
        {
            bool IsFound = false;

            using (SqlConnection connection =
                new SqlConnection(clsConnectionString.connectionString))
            {
                using (SqlCommand command =
                    new SqlCommand("SP_GetBookByID", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.AddWithValue("@BookID", BookID);

                    try
                    {
                        connection.Open();

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                IsFound = true;

                                Title = (string)reader["Title"];
                                AuthorName = (string)reader["AuthorName"];
                                BookCategoryID = (int)reader["BookCategoryID"];
                                ISBN = (int)reader["ISBN"];
                                PublicationYear =
                                    Convert.ToInt32(reader["PublicationYear"]);
                                Description = (string)reader["Description"];
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


        public static DataTable GetAllBooks()
        {
            DataTable dt = new DataTable();

            using (SqlConnection connection =
                new SqlConnection(clsConnectionString.connectionString))
            {
                string query = "SELECT * FROM view_GetAllBooks";

                using (SqlCommand command =
                    new SqlCommand(query, connection))
                {
                    try
                    {
                        connection.Open();

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            dt.Load(reader);
                        }
                    }
                    catch
                    {
                        // Empty DataTable
                    }
                }
            }

            return dt;
        }


        public static bool IsBookIDExists(int BookID)
        {
            bool IsFound = false;

            using (SqlConnection connection =
                new SqlConnection(clsConnectionString.connectionString))
            {
                using (SqlCommand command =
                    new SqlCommand("SP_IsBookIDExists", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.AddWithValue("@BookID", BookID);

                    SqlParameter returnParameter =
                        command.Parameters.Add("@ReturnVal", SqlDbType.Int);

                    returnParameter.Direction =
                        ParameterDirection.ReturnValue;

                    try
                    {
                        connection.Open();

                        command.ExecuteNonQuery();

                        IsFound =
                            (int)returnParameter.Value == 1;
                    }
                    catch
                    {
                        IsFound = false;
                    }
                }
            }

            return IsFound;
        }


        public static bool IsISBNExists(string ISBN)
        {
            bool IsFound = false;

            using (SqlConnection connection =
                new SqlConnection(clsConnectionString.connectionString))
            {
                using (SqlCommand command =
                    new SqlCommand("SP_IsISBNExists", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.AddWithValue("@ISBN", ISBN);

                    SqlParameter returnParameter =
                        command.Parameters.Add("@ReturnVal", SqlDbType.Int);

                    returnParameter.Direction =
                        ParameterDirection.ReturnValue;

                    try
                    {
                        connection.Open();

                        command.ExecuteNonQuery();

                        IsFound =
                            (int)returnParameter.Value == 1;
                    }
                    catch
                    {
                        IsFound = false;
                    }
                }
            }

            return IsFound;
        }


        public static bool DeleteBook(int BookID)
        {
            int RowsAffected = 0;

            using (SqlConnection connection =
                new SqlConnection(clsConnectionString.connectionString))
            {
                using (SqlCommand command =
                    new SqlCommand("SP_DeleteBook", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.AddWithValue("@BookID", BookID);

                    try
                    {
                        connection.Open();

                        RowsAffected = command.ExecuteNonQuery();
                    }
                    catch
                    {
                        return false;
                    }
                }
            }

            return RowsAffected > 0;
        }

        public static bool GetBookInfoByISBN(
    int ISBN,
    ref int BookID,
    ref string Title,
    ref string AuthorName,
    ref int BookCategoryID,
    ref int PublicationYear,
    ref string Description)
        {
            bool IsFound = false;

            using (SqlConnection connection =
                new SqlConnection(clsConnectionString.connectionString))
            {
                using (SqlCommand command =
                    new SqlCommand("SP_GetBookByISBN", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.AddWithValue("@ISBN", ISBN);

                    try
                    {
                        connection.Open();

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                IsFound = true;

                                BookID = (int)reader["BookID"];
                                Title = (string)reader["Title"];
                                AuthorName = (string)reader["AuthorName"];
                                BookCategoryID = (int)reader["BookCategoryID"];
                                PublicationYear = Convert.ToInt32(reader["PublicationYear"]);

                                if (reader["Description"] != DBNull.Value)
                                    Description = (string)reader["Description"];
                                else
                                    Description = "";
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

        public static bool GetBookInfoByTitle(
    string Title,
    ref int BookID,
    ref string AuthorName,
    ref int BookCategoryID,
    ref int ISBN,
    ref int PublicationYear,
    ref string Description)
        {
            bool IsFound = false;

            using (SqlConnection connection =
                new SqlConnection(clsConnectionString.connectionString))
            {
                using (SqlCommand command =
                    new SqlCommand("SP_GetBookByTitle", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.AddWithValue("@Title", Title);

                    try
                    {
                        connection.Open();

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                IsFound = true;

                                BookID = (int)reader["BookID"];
                                AuthorName = (string)reader["AuthorName"];
                                BookCategoryID = (int)reader["BookCategoryID"];
                                ISBN = (int)reader["ISBN"];
                                PublicationYear = Convert.ToInt32(reader["PublicationYear"]);

                                if (reader["Description"] != DBNull.Value)
                                    Description = (string)reader["Description"];
                                else
                                    Description = "";
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