using clsDataAccessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clsBussinessLayer
{
    public class clsBookCategory
    {

        public int BookCategoryID { get; set; }
        public string BookCategoryName { get; set; }


        public clsBookCategory()
        {
            this.BookCategoryID = 0;
            this.BookCategoryName = "";
        }

        public clsBookCategory(int BookCategoryID, string BookCategoryName)
        {
            this.BookCategoryID = BookCategoryID;
            this.BookCategoryName = BookCategoryName;
        }


        public static clsBookCategory Find(string CategoryName)
        {
            int BookCategoryID = 0;

            if (clsBookCategoryData.GetCategoryIDByCategoryName(CategoryName, ref BookCategoryID))
                return new clsBookCategory(BookCategoryID, CategoryName);

            else
                return null;
        }
        public static clsBookCategory Find(int CategoryID)
        {
            string BookCategoryName = "";

            if (clsBookCategoryData.GetCategoryNameByCategoryID(CategoryID, ref BookCategoryName))
                return new clsBookCategory(CategoryID, BookCategoryName);

            else
                return null;
        }



    }
}
