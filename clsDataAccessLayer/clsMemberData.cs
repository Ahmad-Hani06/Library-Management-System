using clsConnetionStringDatabase;
using System;
using System.Data;
using System.Data.SqlClient;

namespace clsDataAccessLayer
{
    public class clsMemberData
    {
        public static int AddNewMember(int PersonID,
            DateTime MembershipStartDate,
            DateTime MembershipEndDate,
            bool MembershipStatus)
        {
            int NewMemberID = -1;

            using (SqlConnection connection =
                new SqlConnection(clsConnectionString.connectionString))
            {
                using (SqlCommand command =
                    new SqlCommand("SP_AddNewMember", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.AddWithValue("@PersonID", PersonID);
                    command.Parameters.AddWithValue("@StartDate", MembershipStartDate);
                    command.Parameters.AddWithValue("@EndDate", MembershipEndDate);
                    command.Parameters.AddWithValue("@MemberStatus", MembershipStatus);

                    SqlParameter outputParameter =
                        command.Parameters.Add("@NewMemberID", SqlDbType.Int);

                    outputParameter.Direction = ParameterDirection.Output;

                    connection.Open();
                    command.ExecuteNonQuery();

                    NewMemberID = Convert.ToInt32(outputParameter.Value);
                }
            }

            return NewMemberID;
        }


        public static bool UpdateMember(int MemberID,
            int PersonID,
            DateTime MembershipStartDate,
            DateTime MembershipEndDate,
            bool MembershipStatus)
        {
            int RowsAffected = 0;

            using (SqlConnection connection =
                new SqlConnection(clsConnectionString.connectionString))
            {
                using (SqlCommand command =
                    new SqlCommand("SP_UpdateMember", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.AddWithValue("@MemberID", MemberID);
                    command.Parameters.AddWithValue("@PersonID", PersonID);
                    command.Parameters.AddWithValue("@StartDate", MembershipStartDate);
                    command.Parameters.AddWithValue("@EndDate", MembershipEndDate);
                    command.Parameters.AddWithValue("@MemberStatus", MembershipStatus);

                    connection.Open();

                    RowsAffected = command.ExecuteNonQuery();
                }
            }

            return RowsAffected > 0;
        }


        public static bool GetMemberByID(int MemberID,
            ref int PersonID,
            ref DateTime MembershipStartDate,
            ref DateTime MembershipEndDate,
            ref bool MembershipStatus)
        {
            bool IsFound = false;

            using (SqlConnection connection =
                new SqlConnection(clsConnectionString.connectionString))
            {
                using (SqlCommand command =
                    new SqlCommand("SP_GetMemberByID", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.AddWithValue("@MemberID", MemberID);

                    connection.Open();

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            IsFound = true;

                            PersonID = Convert.ToInt32(reader["PersonID"]);

                            MembershipStartDate =
                                Convert.ToDateTime(reader["StartDate"]);

                            MembershipEndDate =
                                Convert.ToDateTime(reader["EndDate"]);

                            MembershipStatus =
                                Convert.ToBoolean(reader["MemberStatus"]);
                        }
                    }
                }
            }

            return IsFound;
        }


        public static DataTable GetAllMembers()
        {
            DataTable dtMembers = new DataTable();

            using (SqlConnection connection =
                new SqlConnection(clsConnectionString.connectionString))
            {
                using (SqlCommand command =
                    new SqlCommand("SP_GetAllMembers", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    connection.Open();

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        dtMembers.Load(reader);
                    }
                }
            }

            return dtMembers;
        }


        public static bool IsPersonMember(int PersonID)
        {
            bool IsMember = false;

            using (SqlConnection connection =
                new SqlConnection(clsConnectionString.connectionString))
            {
                using (SqlCommand command =
                    new SqlCommand("SP_IsPersonMember", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.AddWithValue("@PersonID", PersonID);

                    SqlParameter returnParameter =
                        command.Parameters.Add("@ReturnValue", SqlDbType.Int);

                    returnParameter.Direction = ParameterDirection.ReturnValue;

                    connection.Open();

                    command.ExecuteNonQuery();

                    IsMember = Convert.ToBoolean(returnParameter.Value);
                }
            }

            return IsMember;
        }


        public static bool AddNewMemberWithPayment(ref int MemberID, ref int PaymentID, int PersonID, DateTime StartDate, DateTime EndDate,
            bool MemberStatus, decimal PaymentAmount, int UserID, string Notes)
        {
            using (SqlConnection connection = new SqlConnection(clsConnectionString.connectionString))
            {
                using (SqlCommand command = new SqlCommand("SP_AddMemberWithPayment", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@PersonID", PersonID);
                    command.Parameters.AddWithValue("@StartDate", StartDate);
                    command.Parameters.AddWithValue("@EndDate", EndDate);
                    command.Parameters.AddWithValue("@MemberStatus", MemberStatus);

                    command.Parameters.AddWithValue("@PaymentAmount", PaymentAmount);
                    command.Parameters.AddWithValue("@UserID", UserID);
                    if (Notes == null || Notes == "")
                        command.Parameters.AddWithValue("@Notes", DBNull.Value);
                    else
                        command.Parameters.AddWithValue("@Notes", Notes);

                    SqlParameter NewMemberIDParameter = command.Parameters.Add("@NewMemberID", SqlDbType.Int);
                    NewMemberIDParameter.Direction = ParameterDirection.Output;

                    SqlParameter NewPaymentIDParameter = command.Parameters.Add("@NewPaymentID", SqlDbType.Int);
                    NewPaymentIDParameter.Direction = ParameterDirection.Output;

                    connection.Open();
                    command.ExecuteNonQuery();

                    MemberID = Convert.ToInt32(NewMemberIDParameter.Value);

                    PaymentID = Convert.ToInt32(NewPaymentIDParameter.Value);

                    return MemberID > 0 && PaymentID > 0;
                }
            }
        }

        public static bool ChangeMemberStatus(int MemberID, bool IsActive)
        {
            using (SqlConnection conn = new SqlConnection(clsConnectionString.connectionString))
            {
                int rowAff = 0;
                using (SqlCommand command = new SqlCommand(@"Update Member Set MemberStatus = @MemberStatus Where MemberID = @MemberID", conn))
                {
                    command.Parameters.AddWithValue("@MemberStatus", IsActive);
                    command.Parameters.AddWithValue("@MemberID", MemberID);
                    conn.Open();
                    rowAff = command.ExecuteNonQuery();
                }
                return rowAff > 0;
            }
        }

        public static bool DeactivateExpiredMembers()
        {
            using (SqlConnection connection =
                new SqlConnection(clsConnectionString.connectionString))
            {
                using (SqlCommand command =
                    new SqlCommand("SP_DeactivateExpiredMembers", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    connection.Open();

                    return command.ExecuteNonQuery() >= 0;
                }
            }
        }

        public static bool RenewMember(int MemberID, DateTime StartDate, DateTime EndDate,
            decimal PaymentAmount, int UserID)
        {
            using (SqlConnection connection = new SqlConnection(clsConnectionString.connectionString))
            {
                using (SqlCommand command = new SqlCommand("SP_RenewMember", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.AddWithValue("@MemberID", MemberID);
                    command.Parameters.AddWithValue("@StartDate", StartDate);
                    command.Parameters.AddWithValue("@EndDate", EndDate);
                    command.Parameters.AddWithValue("@PaymentAmount", PaymentAmount);
                    command.Parameters.AddWithValue("@UserID", UserID);

                    connection.Open();

                    return command.ExecuteNonQuery() > 0;
                }
            }
        }

        public static bool IsMemberIDExists(int MemberID)
        {
            bool isExists = false;

            using (SqlConnection connection =
                new SqlConnection(clsConnectionString.connectionString))
            {
                using (SqlCommand command =
                    new SqlCommand("SP_IsMemberIDExists", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.AddWithValue("@MemberID", MemberID);

                    SqlParameter returnParameter =
                        command.Parameters.Add("@ReturnValue", SqlDbType.Int);

                    returnParameter.Direction = ParameterDirection.ReturnValue;

                    connection.Open();

                    command.ExecuteNonQuery();

                    isExists =
                        Convert.ToInt32(returnParameter.Value) == 1;
                }
            }

            return isExists;
        }
    }
}
