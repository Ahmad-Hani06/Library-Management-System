using clsBussinessLogic;
using Library_Management_System.BorrowingBook;
using System.Data;
using System.Windows.Forms;

namespace Library_Management_System.BorrowBook
{
    public partial class frmManageBorrow : Form
    {

        private DataTable _dt = new DataTable();
        public frmManageBorrow()
        {
            InitializeComponent();
            //dgvManageBorrow.Columns[].DefaultCellStyle.NullValue = "Not Returned Yet";
        }

        private void frmManageBorrow_Load(object sender, System.EventArgs e)
        {
            _LoadData();
        }


        private void _LoadData()
        {
            _dt = clsBorrowing.GetAllBorrowings();
            dgvManageBorrow.DataSource = _dt;
        }
        private void returnBorrowToolStripMenuItem_Click(object sender, System.EventArgs e)
        {

            try
            {
                int BorrowID = (int)dgvManageBorrow.CurrentRow.Cells[0].Value;
                bool hasFine = clsBorrowing.ReturnBookAfterBorrowed(BorrowID, clsGlobal.CurrentUser.UserID);

                if (hasFine)
                    MessageBox.Show("Book returned successfully. A fine has been added.","Return Book", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                else
                    MessageBox.Show("Book returned successfully.", "Return Book", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (System.Exception ex)
            {

                MessageBox.Show(
                  ex.Message,
                  "Error",
                  MessageBoxButtons.OK,
                  MessageBoxIcon.Error);
            }
           
            _LoadData();

        }

        private void btnBorrowingBook_Click(object sender, System.EventArgs e)
        {
            frmBorrowBoom borrowBoom = new frmBorrowBoom();
            borrowBoom.Show();
            _LoadData();
        }
    }
}
