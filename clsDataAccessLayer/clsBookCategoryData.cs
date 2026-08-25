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
    public class clsBookCategoryData
    {

        public static bool GetCategoryIDByCategoryName(string CategoryName,ref int CategoryID)
        {

            using (SqlConnection connection =
                new SqlConnection(clsConnectionString.connectionString))
            {
                using (SqlCommand command =
                    new SqlCommand("SP_GetCategoryByCategoryName", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.AddWithValue("@CategoryName", CategoryName);

                    SqlParameter outputParameter =
                        new SqlParameter("@CategoryID", SqlDbType.Int);

                    outputParameter.Direction = ParameterDirection.Output;

                    command.Parameters.Add(outputParameter);

                    try
                    {
                        connection.Open();

                        command.ExecuteNonQuery();

                        if (outputParameter.Value != DBNull.Value)
                        {
                            CategoryID = Convert.ToInt32(outputParameter.Value);
                        }
                    }
                    catch
                    {
                        CategoryID = -1;
                    }
                }
            }

            return CategoryID > 0;
        }

        public static bool GetCategoryNameByCategoryID(
    int CategoryID,
    ref string CategoryName)
        {
            bool IsFound = false;

            using (SqlConnection connection =
                new SqlConnection(clsConnectionString.connectionString))
            {
                using (SqlCommand command =
                    new SqlCommand("SP_GetCategoryNameByCategoryID", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.AddWithValue("@CategoryID", CategoryID);

                    try
                    {
                        connection.Open();

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                IsFound = true;

                                CategoryName = reader["BookCategoryName"].ToString();
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
    }
}
