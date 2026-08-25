using clsBussinessLayer;
using clsDataAccessLayer;
using System.Data;

namespace clsBussinessLogic
{
    public class clsBook
    {
        public enum enMode
        {
            AddNew,
            Update
        }

        public enMode Mode { get; set; }

        public int BookID { get; set; }

        public string Title { get; set; }

        public string AuthorName { get; set; }

        public int BookCategoryID { get; set; }

        public int ISBN { get; set; }

        public int PublicationYear { get; set; }

        public string Description { get; set; }

        public clsBookCategory bookCategory { get; set; }


        public clsBook()
        {
            BookID = -1;
            Title = "";
            AuthorName = "";
            BookCategoryID = -1;
            ISBN = 0;
            PublicationYear = 0;
            Description = "";
            bookCategory = new clsBookCategory();
            Mode = enMode.AddNew;
        }


        private clsBook(
            int BookID,
            string Title,
            string AuthorName,
            int BookCategoryID,
            int ISBN,
            int PublicationYear,
            string Description)
        {
            this.BookID = BookID;
            this.Title = Title;
            this.AuthorName = AuthorName;
            this.BookCategoryID = BookCategoryID;
            this.ISBN = ISBN;
            this.PublicationYear = PublicationYear;
            this.Description = Description;
            Mode = enMode.Update;
            bookCategory = clsBookCategory.Find(BookCategoryID);
        }


        private bool _AddNewBook()
        {
            this.BookID = clsBookData.AddNewBook(
                this.Title,
                this.AuthorName,
                this.BookCategoryID,
                this.ISBN,
                this.PublicationYear,
                this.Description);

            return this.BookID != -1;
        }


        private bool _UpdateBook()
        {
            return clsBookData.UpdateBook(
                this.BookID,
                this.Title,
                this.AuthorName,
                this.BookCategoryID,
                this.ISBN,
                this.PublicationYear,
                this.Description);
        }


        public bool Save()
        {
            switch (Mode)
            {
                case enMode.AddNew:

                    if (_AddNewBook())
                    {
                        Mode = enMode.Update;
                        return true;
                    }

                    return false;


                case enMode.Update:

                    return _UpdateBook();
            }

            return false;
        }


        public static clsBook Find(int BookID)
        {
            string Title = "";
            string AuthorName = "";
            int BookCategoryID = -1;
            int ISBN = 0;
            int PublicationYear = 0;
            string Description = "";

            bool IsFound = clsBookData.GetBookByID(
                BookID,
                ref Title,
                ref AuthorName,
                ref BookCategoryID,
                ref ISBN,
                ref PublicationYear,
                ref Description);

            if (IsFound)
            {
                return new clsBook(
                    BookID,
                    Title,
                    AuthorName,
                    BookCategoryID,
                    ISBN,
                    PublicationYear,
                    Description);
            }

            return null;
        }


        public static DataTable GetAllBooks()
        {
            return clsBookData.GetAllBooks();
        }

        public static bool IsBookExists(int BookID)
        {
            return clsBookData.IsBookIDExists(BookID);
        }

        public static bool IsISBNExists(string ISBN)
        {
            return clsBookData.IsISBNExists(ISBN);
        }

        public static bool DeleteBook(int BookID)
        {
            return clsBookData.DeleteBook(BookID);
        }

        public static clsBook FindByISBN(int ISBN)
        {
            int BookID = -1;
            string Title = "";
            string AuthorName = "";
            int BookCategoryID = -1;
            int PublicationYear = 0;
            string Description = "";

            if (clsBookData.GetBookInfoByISBN(
                ISBN,
                ref BookID,
                ref Title,
                ref AuthorName,
                ref BookCategoryID,
                ref PublicationYear,
                ref Description))
            {
                return new clsBook(
                    BookID,
                    Title,
                    AuthorName,
                    BookCategoryID,
                    ISBN,
                    PublicationYear,
                    Description
                );
            }

            return null;
        }

        public static clsBook Find(string Title)
        {
            int BookID = -1;
            string AuthorName = "";
            int BookCategoryID = -1;
            int ISBN = 0;
            int PublicationYear = 0;
            string Description = "";

            if (clsBookData.GetBookInfoByTitle(
                Title,
                ref BookID,
                ref AuthorName,
                ref BookCategoryID,
                ref ISBN,
                ref PublicationYear,
                ref Description))
            {
                return new clsBook(
                    BookID,
                    Title,
                    AuthorName,
                    BookCategoryID,
                    ISBN,
                    PublicationYear,
                    Description
                );
            }

            return null;
        }

        public int GetAvailableCopiesCount()
        {
            return clsBookCopy.GetAvailableCopiesCountByBookID(BookID);
        }
    }
}