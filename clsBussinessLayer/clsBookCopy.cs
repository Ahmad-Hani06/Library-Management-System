using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.VisualStyles;
using clsDataAccessLayer;

namespace clsBussinessLayer
{
    public class clsBookCopy
    {
        public enum enBookCopyStatus
        {
            Available = 1,
            Borrowed = 2,
            Sold = 3,
            Removed = 4
        }


        public int BookCopyID { get; set; }

        public int BookID { get; set; }

        public enBookCopyStatus BookCopyStatus { get; set; }


        public clsBookCopy()
        {
            BookCopyID = -1;
            BookID = -1;
            BookCopyStatus = enBookCopyStatus.Available;
        }


        private clsBookCopy(
            int BookCopyID,
            int BookID,
            enBookCopyStatus BookCopyStatus)
        {
            this.BookCopyID = BookCopyID;
            this.BookID = BookID;
            this.BookCopyStatus = BookCopyStatus;
        }

        public static int GetAvailableCopiesCountByBookID(int BookID)
        {
            return clsBookCopyData.GetAvailableCopiesCountByBookID(BookID);
        }

        public bool AddNewBookCopy()
        {
            this.BookCopyID =
                clsBookCopyData.AddNewBookCopy(this.BookID);

            return this.BookCopyID != -1;
        }


        public static clsBookCopy Find(int BookCopyID)
        {
            int BookID = -1;
            int Status = -1;

            if (clsBookCopyData.GetBookCopyByID(BookCopyID, ref BookID, ref Status))
            {
                return new clsBookCopy(BookCopyID, BookID, (enBookCopyStatus)Status);
            }

            return null;
        }


        public bool UpdateStatus(enBookCopyStatus NewStatus)
        {
             
            if (clsBookCopyData.UpdateBookCopyStatus(this.BookCopyID, (int)NewStatus))
            {
                this.BookCopyStatus = NewStatus;

                return true;
            }

            return false;
        }

        public static List<int> GetAvailableBookCopyByBookID(int BookID)
        {
            return clsBookCopyData.GetAvailableBookCopyByBookID(BookID);
        }
    }
}
