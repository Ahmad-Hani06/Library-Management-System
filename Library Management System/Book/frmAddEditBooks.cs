using clsBussinessLayer;
using clsBussinessLogic;
using System;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace Library_Management_System.Book
{
    public partial class frmAddEditBooks : Form
    {

        private enum enMode { AddNew, Update};
        private enMode _mode = enMode.AddNew;
        private int _bookID = -1;
        private clsBook _book = new clsBook();

        public frmAddEditBooks()
        {
            InitializeComponent();
            _mode = enMode.AddNew;
        }
        public frmAddEditBooks(int BookID)
        {
            InitializeComponent();
            _bookID = BookID;
            _mode = enMode.Update;
        }

        private void btnSave_Click(object sender, System.EventArgs e)
        {
            _book.Title = txtTitle.Text.Trim();
            _book.AuthorName = txtAuthor.Text.Trim();
            _book.BookCategoryID = clsBookCategory.Find(cmbCategory.Text).BookCategoryID;
            _book.ISBN = Convert.ToInt32(txtISBN.Text.Trim());
            _book.PublicationYear = System.Convert.ToInt32(txtBoxPubYear.Text);
            _book.Description = txtNotes.Text.Trim();

            if (_book.Save())
            {
                _mode = enMode.Update;
                _bookID = _book.BookID;
                txtBookID.Text = _book.BookID.ToString();
                this.Text = "Update Book";
                lblHeaderTitle.Text = "Update Book";

                MessageBox.Show("Book saved successfully.", "Success",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Book was not saved.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void FillDataWithUpdateMode()
        {
            _book = clsBook.Find(_bookID);

            if (_book == null)
            {
                MessageBox.Show("Book does not exist.", "Not Found",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            this.Text = "Update Book";
            lblHeaderTitle.Text = "Update Book";

            txtBookID.Text = _book.BookID.ToString();
            txtISBN.Text = _book.ISBN.ToString();
            txtTitle.Text = _book.Title;
            txtAuthor.Text = _book.AuthorName;
            txtNotes.Text = _book.Description;

            cmbCategory.SelectedItem = clsBookCategory.Find(_book.BookCategoryID).BookCategoryName;
            txtBoxPubYear.Text = _book.PublicationYear.ToString();
        }

        private void ResetData()
        {
            _bookID = -1;
            _book = new clsBook();

            this.Text = "Add New Book";
            lblHeaderTitle.Text = "Add New Book";

            txtBookID.Text = "Auto-generated";
            txtISBN.Clear();
            txtTitle.Clear();
            txtAuthor.Clear();
            txtNotes.Clear();
            cmbCategory.SelectedIndex = -1;
            txtBoxPubYear.Clear();

        }
        private void frmAddEditBooks_Load(object sender, System.EventArgs e)
        {
            if (_mode == enMode.Update)
                FillDataWithUpdateMode();

            else
                ResetData();


        }
    }
}
