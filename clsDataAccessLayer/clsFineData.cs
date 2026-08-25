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
    public class clsFineData
    {
        public static bool PayFine(int FineID, int UserID)
        {
            using (SqlConnection connection =
                new SqlConnection(clsConnectionString.connectionString))
            {
                using (SqlCommand command =
                    new SqlCommand("SP_PayFine", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.Add("@FineID", SqlDbType.Int).Value = FineID;
                    command.Parameters.Add("@UserID", SqlDbType.Int).Value = UserID;

                    connection.Open();

                    command.ExecuteNonQuery();

                    return true;
                }
            }
        }


        public static bool GetFineInfoByID(
     int FineID,
     ref int BorrowingID,
     ref decimal FineAmount,
     ref DateTime FineDate,
     ref bool IsPaid,
     ref string FullName,
     ref string BookTitle,
     ref string FineTypeName)
        {
            bool IsFound = false;

            using (SqlConnection connection =
                new SqlConnection(clsConnectionString.connectionString))
            {
                using (SqlCommand command =
                    new SqlCommand("SP_GetFineInfoByID", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.Add("@FineID", SqlDbType.Int).Value = FineID;

                    connection.Open();

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            IsFound = true;

                            BorrowingID = Convert.ToInt32(reader["BorrowingID"]);
                            FineAmount = Convert.ToDecimal(reader["FineAmount"]);
                            FineDate = Convert.ToDateTime(reader["FineDate"]);
                            IsPaid = Convert.ToBoolean(reader["IsPaid"]);

                            FullName = reader["FullName"].ToString();
                            BookTitle = reader["Title"].ToString();
                            FineTypeName = reader["FineTypeName"].ToString();
                        }
                    }
                }
            }

            return IsFound;
        }

    public static DataTable GetAllFines()
        {
            DataTable dt = new DataTable();

            using (SqlConnection connection =
                new SqlConnection(clsConnectionString.connectionString))
            {
                using (SqlCommand command =
                    new SqlCommand("SP_GetAllFine", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    connection.Open();

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        dt.Load(reader);
                    }
                }
            }

            return dt;
        }
    }
    }
