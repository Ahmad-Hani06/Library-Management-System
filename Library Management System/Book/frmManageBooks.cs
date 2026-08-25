
using clsBussinessLayer;
using clsBussinessLogic;
using System.Data;
using System.Windows.Forms;

namespace Library_Management_System.Book
{
    public partial class frmManageBooks : Form
    {
        private DataTable _dt = new DataTable();
        public frmManageBooks()
        {
            InitializeComponent();
            _LoadData();
        }

        private void _LoadData()
        {
            _dt = clsBook.GetAllBooks();
            dgvManageBooks.DataSource = _dt;
        }

        private void btnAddBook_Click(object sender, System.EventArgs e)
        {
            frmAddEditBooks frmAddEdit = new frmAddEditBooks();
            frmAddEdit.ShowDialog();
            _LoadData();
        }


        private void editBookToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            frmAddEditBooks frmAddEdit = new frmAddEditBooks((int)dgvManageBooks.CurrentRow.Cells["colBookID"].Value);
            frmAddEdit.ShowDialog();
            _LoadData();
        }

        private void viewBookDetailsToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            frmFindBooks frmFind = new frmFindBooks((int)dgvManageBooks.CurrentRow.Cells["colBookID"].Value);
            frmFind.ShowDialog();

        }

        private void addBookCopyToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            clsBookCopy bookCopy = new clsBookCopy();
            bookCopy.BookID = (int)dgvManageBooks.CurrentRow.Cells["colBookID"].Value;
            //bookCopy.BookCopyStatus = clsBookCopy.enBookCopyStatus.Available;
            if (bookCopy.AddNewBookCopy())
            {
                MessageBox.Show(
                    "Book copy added successfully.",
                    "Success",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                _LoadData();
            }
            else
            {
                MessageBox.Show(
                    "Failed to add book copy.",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void deleteBookToolStripMenuItem_Click(object sender, System.EventArgs e)
        {

        }
    }
}
