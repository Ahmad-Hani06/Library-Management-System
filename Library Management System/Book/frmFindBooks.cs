using System;
using System.Diagnostics.Eventing.Reader;
using System.Windows.Forms;

namespace Library_Management_System.Book
{
    public partial class frmFindBooks : Form
    {
        private int _bookID = -1;
        public frmFindBooks()
        {
            InitializeComponent();
        }
        public frmFindBooks(int BookID)
        {
            InitializeComponent();
            _bookID = BookID;
            _LoadDataInfo();
        }

        private void btnSearch_Click(object sender, System.EventArgs e)
        {

            switch (cmbSearchBy.Text)
            {
                case "Book ID":
                    ctrlBookInfo1.LoadData(Convert.ToInt32(txtSearchValue.Text.Trim()));
                    break;

                case "ISBN":
                    ctrlBookInfo1.LoadDataByISBN(Convert.ToInt32(txtSearchValue.Text.Trim()));
                    break;


                case "Title":
                    ctrlBookInfo1.LoadData(txtSearchValue.Text.Trim());
                    break;

                default:
                    break;
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ctrlBookInfo1.ClearData();
        }

        private void _LoadDataInfo()
        {
            pnlSearchCard.Enabled = false;
            ctrlBookInfo1.LoadData(_bookID);
        }
    }
}
