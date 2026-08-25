using clsDataAccessLayer;
using System.Data;

namespace clsBussinessLogic
{
    public class clsBorrowing
    {




        public static bool BorrowBook(int MemberID, int BookID, int UserID)
        {
            return clsBorrowingBookData.BorrowBook(MemberID, BookID, UserID);
        }

        public static DataTable GetAllBorrowings()
        {
            return clsBorrowingBookData.GetAllBorrowings();
        }


        public static bool ReturnBookAfterBorrowed(int BorrowingID,int ReturnUserID)
        {
            return clsBorrowingBookData.ReturnBookAfterBorrowed(BorrowingID, ReturnUserID);
        }
    }
}