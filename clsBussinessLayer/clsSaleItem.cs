using clsBussinessLogic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clsBussinessLayer
{
    public class clsSaleItem
    {
        public int SaleItemID { get; set; }
        public int SaleID { get; set; }
        public int BookCopyID { get; set; }
        public decimal SalePrice { get; set; }

        public string BookTitle => book.Title;
        public string AuthorName => book.AuthorName;

        //public clsSale sale;
        public clsBookCopy bookCopy;
        public clsBook book;


        public clsSaleItem()
        {
            SaleItemID = 0;
            SaleID = 0;
            BookCopyID = 0;
            SalePrice = 0;
            //sale = new clsSale();
            bookCopy = new clsBookCopy();
            book = new clsBook();
        }

        public clsSaleItem(int SaleItem, int SaleID, int BookCopyID, decimal SalePrice)
        {
            this.SaleItemID = SaleItem;
            this.SaleID = SaleID;
            this.BookCopyID = BookCopyID;
            this.SalePrice = SalePrice;
            bookCopy = clsBookCopy.Find(BookCopyID);
            book = clsBook.Find(bookCopy.BookID);
        }



    }
}
