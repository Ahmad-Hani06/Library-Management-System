using clsBussinessLogic.Person;
using Library_Management_System.Book;
using Library_Management_System.BorrowBook;
using Library_Management_System.BorrowingBook;
using Library_Management_System.Fine;
using Library_Management_System.Member;
using Library_Management_System.Payment;
using Library_Management_System.Sale;
using Library_Management_System.User;
using System.Windows.Forms;

namespace Library_Management_System
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private Form _activeForm;

        private void OpenFormInsidePanel(Form childForm)
        {
            //if (_activeForm != null)
            //    _activeForm.Close();

            _activeForm = childForm;

            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;

            //pnlMain.Controls.Clear();
            pnlMain.Controls.Add(childForm);

            childForm.BringToFront();
            childForm.Show();
        }

        private void btnBooks_Click(object sender, System.EventArgs e)
        {
            frmManageBooks frmManage = new frmManageBooks();
            OpenFormInsidePanel(frmManage);
        }

        private void btnMembers_Click(object sender, System.EventArgs e)
        {
            frmManageMember manageMember = new frmManageMember();
            OpenFormInsidePanel(manageMember);
        }

        private void btnBorrowing_Click(object sender, System.EventArgs e)
        {
            frmManageBorrow manageBorrow = new frmManageBorrow();
            OpenFormInsidePanel(manageBorrow);
        }

        private void btnFines_Click(object sender, System.EventArgs e)
        {
            frmManageFine frmManagefine = new frmManageFine();
            OpenFormInsidePanel(frmManagefine);
        }

        private void btnPayments_Click(object sender, System.EventArgs e)
        {
            frmListPayment frmList = new frmListPayment();
            OpenFormInsidePanel(frmList);
        }

        private void btnSales_Click(object sender, System.EventArgs e)
        {
            frmNewSale newSale = new frmNewSale();
            OpenFormInsidePanel(newSale);
        }

        private void btnPeople_Click(object sender, System.EventArgs e)
        {
            frmManagePersons frmManage = new frmManagePersons();
            OpenFormInsidePanel(frmManage);
        }

        private void btnUsers_Click(object sender, System.EventArgs e)
        {
            frmManageUsers manageUsers = new frmManageUsers();
            OpenFormInsidePanel(manageUsers);
        }

        private void frmMain_Load(object sender, System.EventArgs e)
        {
            lblCurrentUser.Text = clsGlobal.CurrentUser.UserName;
        }

        private void btnLogout_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }
    }
}
