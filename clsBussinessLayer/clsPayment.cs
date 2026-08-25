using clsDataAccessLayer;
using System.Data;

namespace clsBussinessLogic
{
    public class clsPayment
    {
        public enum enMode
        {
            AddNew,
            Update
        }

        public enMode Mode { get; private set; }

        public int PaymentID { get; set; }
        public int MemberID { get; set; }
        public decimal PaymentAmount { get; set; }
        public int UserID { get; set; }
        public string Notes { get; set; }


        public clsPayment()
        {
            PaymentID = -1;
            MemberID = -1;
            PaymentAmount = 0;
            UserID = -1;
            Notes = "";

            Mode = enMode.AddNew;
        }


        private bool _AddNewPayment()
        {
            this.PaymentID = clsPaymentData.AddMemberPayment(
                this.MemberID,
                this.PaymentAmount,
                this.UserID,
                this.Notes);

            return this.PaymentID != -1;
        }


        private bool _UpdatePayment()
        {
            // لما تعمل UpdatePayment في Data Access
            // نحط الاستدعاء هنا.

            return false;
        }


        public bool Save()
        {
            switch (Mode)
            {
                case enMode.AddNew:

                    if (_AddNewPayment())
                    {
                        Mode = enMode.Update;
                        return true;
                    }

                    return false;


                case enMode.Update:

                    return _UpdatePayment();
            }

            return false;
        }


        public static DataTable GetAllPayments()
        {
            return clsPaymentData.GetAllPayments();
        }
    }
}