using clsBussinessLayer;
using System.Data;
using System.Windows.Forms;

namespace Library_Management_System.Fine
{
    public partial class frmManageFine : Form
    {
        private DataTable _dt = new DataTable();
        public frmManageFine()
        {
            InitializeComponent();
            _LoadData();
        }

        private void _LoadData()
        {
            _dt = clsFine.GetAllFine();
            dgvManageFine.DataSource = _dt;
        }

        private void payFineToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            frmPayFine frmPay = new frmPayFine((int)dgvManageFine.CurrentRow.Cells[0].Value);
            frmPay.ShowDialog();
            _LoadData();
        }

        private void payDetailsToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            frmFineDetails frmFine = new frmFineDetails((int)dgvManageFine.CurrentRow.Cells[0].Value);
            frmFine.ShowDialog();
        }
    }
}
