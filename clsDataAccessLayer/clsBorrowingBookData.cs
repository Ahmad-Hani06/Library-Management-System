using clsConnetionStringDatabase;
using System;
using System.Data;
using System.Data.SqlClient;

namespace clsDataAccessLayer
{
    public class clsBorrowingBookData
    {
        public static bool BorrowBook(
            int MemberID,
            int BookID,
            int UserID)
        {

            try
            {
                using (SqlConnection connection =
                    new SqlConnection(clsConnectionString.connectionString))
                {
                    using (SqlCommand command =
                        new SqlCommand("SP_BorrowBook", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        command.Parameters.AddWithValue("@MemberID", MemberID);
                        command.Parameters.AddWithValue("@BookID", BookID);
                        command.Parameters.AddWithValue("@UserID", UserID);

                        connection.Open();

                        command.ExecuteNonQuery();

                        return true;
                    }
                }
            }
            catch (SqlException ex)
            {
                return false;
            }
        }

        public static DataTable GetAllBorrowings()
        {
            DataTable dt = new DataTable();

            using (SqlConnection connection =
                new SqlConnection(clsConnectionString.connectionString))
            {
                using (SqlCommand command =
                    new SqlCommand("SELECT * FROM view_GetBorrowing", connection))
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
                        // ممكن لاحقاً تضيف Exception Handling
                    }
                }
            }

            return dt;
        }



        public static bool ReturnBookAfterBorrowed(int BorrowingID, int ReturnUserID)
        {
            bool HasFine = false;

            using (SqlConnection connection =
                new SqlConnection(clsConnectionString.connectionString))
            {
                using (SqlCommand command =
                    new SqlCommand("SP_ReturnBookAfterBorrowed", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.AddWithValue("@BorrowingID", BorrowingID);
                    command.Parameters.AddWithValue("@ReturnUserID", ReturnUserID);

                    SqlParameter outputPara =
                        command.Parameters.Add("@HasFine", SqlDbType.Bit);

                    outputPara.Direction = ParameterDirection.Output;

                    connection.Open();

                    command.ExecuteNonQuery();

                    HasFine = Convert.ToBoolean(outputPara.Value);
                }
            }

            return HasFine;
        }
    }
}