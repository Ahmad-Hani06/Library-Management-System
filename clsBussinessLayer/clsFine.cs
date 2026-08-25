using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using clsBussinessLogic;
using clsDataAccessLayer;

namespace clsBussinessLayer
{
    public class clsFine
    {
        public enum enPaymentStatus
        {
            Unpaid = 0,
            Paid = 1
        }
        public int FineID { get; set; }
        public int BorrowingID { get; set; }
        public int UserID { get; set; }
        public decimal FineAmount { get; set; }
        public DateTime FineDate { get; set; }
        public enPaymentStatus PaymentStatus { get; set; }

        public clsBorrowing Borrowing;


        public string MemberName { get; set; }
        public string BookTitle { get; set; }
        public string FineTypeName { get; set; }


        private bool IsPaid
        {
            get
            {
                return PaymentStatus == enPaymentStatus.Paid;
            }
        }
        public clsFine()
        {
            FineID = -1;
            BorrowingID = -1;
            UserID = -1;
            FineAmount = 0;
            FineDate = DateTime.MinValue;
            PaymentStatus = enPaymentStatus.Unpaid;

            MemberName = "";
            BookTitle = "";
            FineTypeName = "";
        }
        public clsFine(
      int FineID,
      int BorrowingID,
      decimal FineAmount,
      DateTime FineDate,
      enPaymentStatus paymentStatus,
      string MemberName,
      string BookTitle,
      string FineTypeName)
        {
            this.FineID = FineID;
            this.BorrowingID = BorrowingID;
            this.FineAmount = FineAmount;
            this.FineDate = FineDate;

            this.PaymentStatus = paymentStatus;
            this.MemberName = MemberName;
            this.BookTitle = BookTitle;
            this.FineTypeName = FineTypeName;
        }

        public static clsFine Find(int FineID)
        {
            int BorrowingID = -1;
            decimal FineAmount = 0;
            DateTime FineDate = DateTime.MinValue;
            bool IsPaid = false;
            string MemberName = "";
            string BookTitle = "";
            string FineTypeName = "";

            bool IsFound = clsFineData.GetFineInfoByID(
                FineID,
                ref BorrowingID,
                ref FineAmount,
                ref FineDate,
                ref IsPaid,
                ref MemberName,
                ref BookTitle,
                ref FineTypeName);

            if (!IsFound)
                return null;

            return new clsFine
            {
                FineID = FineID,
                BorrowingID = BorrowingID,
                FineAmount = FineAmount,
                FineDate = FineDate,

                PaymentStatus = IsPaid ? enPaymentStatus.Paid : enPaymentStatus.Unpaid,

                MemberName = MemberName,
                BookTitle = BookTitle,
                FineTypeName = FineTypeName
            };
        }


        public bool Pay(int UserID)
        {
            if (IsPaid)
                return false;


            if (!clsFineData.PayFine(this.FineID, UserID))
                return false;

            this.PaymentStatus = enPaymentStatus.Paid;

            return true;
        }

        public static DataTable GetAllFine()
        {
            return clsFineData.GetAllFines();
        }
    }
}
