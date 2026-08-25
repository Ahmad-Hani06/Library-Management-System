using clsBussinessLayer;
using clsBussinessLogic;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace Library_Management_System.Book
{
    public partial class ctrlBookInfo : UserControl
    {
        private int _BookID = -1;
        private clsBook _book = new clsBook();
        public ctrlBookInfo()
        {
            InitializeComponent();
        }

        private void _FillBookInfo()
        {
            lblBookIDValue.Text = _book.BookID.ToString();
            lblAuthorValue.Text = _book.AuthorName;
            lblISBNValue.Text = _book.ISBN.ToString();
            lblCategoryValue.Text = _book.bookCategory.BookCategoryName;
            lblPublishedValue.Text = _book.PublicationYear.ToString();
            lblTitleValue.Text = _book.Title;
            lblCopiesValue.Text = clsBookCopy.GetAvailableCopiesCountByBookID(_book.BookID).ToString();
        }
        public void LoadData(int BookID)
        {
            _BookID = BookID;
            _book = clsBook.Find(_BookID);

            if (_book == null)
            {
                MessageBox.Show("The BookID does not exists", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            _FillBookInfo();
        }

        public void LoadDataByISBN(int ISBN)
        {
            int isbn = ISBN;
            _book = clsBook.FindByISBN(isbn);

            if (_book == null)
            {
                MessageBox.Show("The ISBN does not exists", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            _FillBookInfo();
        }

        public void LoadData(string Title)
        {
            string title = Title;
            _book = clsBook.Find(Title);

            if (_book == null)
            {
                MessageBox.Show("The Title does not exists", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            _FillBookInfo();
        }


        public void ClearData()
        {

            lblBookIDValue.Text = "â€”";
            lblAuthorValue.Text = "â€”";
            lblISBNValue.Text = "â€”";
            lblCategoryValue.Text = "â€”";
            lblPublishedValue.Text = "â€”";
            lblCopiesValue.Text = "â€”";
            lblTitleValue.Text = "No Book Selected";
        }

    }
}
