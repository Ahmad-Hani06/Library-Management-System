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
    public class clsSaleData
    {
        public static int CompleteSale(
    int PersonID,
    int UserID,
    DateTime SaleDate,
    decimal TotalAmount,
    DataTable SaleItems)
        {
            int SaleID = -1;
            using (SqlConnection connection =
                new SqlConnection(clsConnectionString.connectionString))
            {
                using (SqlCommand command =
                    new SqlCommand("SP_CompleteSale", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.AddWithValue("@PersonID", PersonID);
                    command.Parameters.AddWithValue("@UserID", UserID);
                    command.Parameters.AddWithValue("@SaleDate", SaleDate);
                    command.Parameters.AddWithValue("@TotalAmount", TotalAmount);

                    SqlParameter itemsParameter =
                        command.Parameters.Add("@SaleItems", SqlDbType.Structured);

                    //itemsParameter.TypeName = "SaleItemTableType";
                    itemsParameter.Value = SaleItems;

                    SqlParameter saleIDParameter =
                        command.Parameters.Add("@SaleID", SqlDbType.Int);

                    saleIDParameter.Direction = ParameterDirection.Output;

                    connection.Open();
                    command.ExecuteNonQuery();

                    SaleID = Convert.ToInt32(saleIDParameter.Value);

                    return SaleID;
                }
            }
        }





    }
}
