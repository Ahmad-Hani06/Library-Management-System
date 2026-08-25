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
    public class clsPaymentData
    {
        public static int AddMemberPayment(int MemberID, decimal PaymentAmount,
    int UserID, string Notes)
        {
            int NewPaymentID = -1;

            using (SqlConnection connection =
                new SqlConnection(clsConnectionString.connectionString))
            {
                using (SqlCommand command =
                    new SqlCommand("SP_AddMemberPayment", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.Add("@MemberID", SqlDbType.Int).Value = MemberID;

                    command.Parameters.Add("@PaymentAmount", SqlDbType.Decimal).Value = PaymentAmount;

                    command.Parameters.Add("@UserID", SqlDbType.Int).Value = UserID;

                    command.Parameters.Add("@Notes", SqlDbType.NVarChar, 500).Value =
                        string.IsNullOrEmpty(Notes)
                        ? (object)DBNull.Value
                        : Notes;

                    SqlParameter outputParameter = command.Parameters.Add("@NewPaymentID", SqlDbType.Int);

                    outputParameter.Direction = ParameterDirection.Output;

                    connection.Open();

                    command.ExecuteNonQuery();

                    NewPaymentID = Convert.ToInt32(outputParameter.Value);
                }
            }

            return NewPaymentID;
        }

        public static DataTable GetAllPayments()
        {
            DataTable dt = new DataTable();

            using (SqlConnection connection =
                new SqlConnection(clsConnectionString.connectionString))
            {
                using (SqlCommand command =
                    new SqlCommand("SP_GetAllPayment", connection))
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
