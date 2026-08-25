using clsBussinessLogic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library_Management_System.BorrowingBook
{
    public partial class frmBorrowBoom : Form
    {
        //private clsMember _member = new clsMember();
        private int _memberID = 0;
        private clsBook _book = new clsBook();
        //private int _bookID = 0;
        public frmBorrowBoom()
        {
            InitializeComponent();
            dtpBorrowDate.Value = DateTime.Today;
            dtpDueDate.Value = DateTime.Today.AddDays(7);
        }

        private void btnFindMember_Click(object sender, EventArgs e)
        {
            _memberID = Convert.ToInt32(txtMemberID.Text.Trim());
            if (!clsMember.IsMemberIDExists(_memberID))
            {
                MessageBox.Show("MemberID does not exists", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            ctrlMemberInfo1.LoadMemberInfo(_memberID);
        }

        private void btnClearMember_Click(object sender, EventArgs e)
        {
            
        }

        private void btnFindBook_Click(object sender, EventArgs e)
        {
            string title = txtBookSearchValue.Text.Trim();
            _book = clsBook.Find(title);
            if (_book == null)
            {
                MessageBox.Show("Book Title does not exists", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            ctrlBookInfo1.LoadData(title);
        }

        private void btnConfirmBorrow_Click(object sender, EventArgs e)
        {
            if (clsBorrowing.BorrowBook(_memberID, _book.BookID, clsGlobal.CurrentUser.UserID))
            {
                MessageBox.Show("Borrowed successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else
            {
                MessageBox.Show("Borrowed Failed", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }
    }
}
