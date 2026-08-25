using clsBussinessLogic;
using System.Data;
using System.Windows.Forms;

namespace Library_Management_System.Payment
{
    public partial class frmListPayment : Form
    {

        private DataTable _dt = new DataTable();
        public frmListPayment()
        {
            InitializeComponent();
            _dt = clsPayment.GetAllPayments();
            dgvPayments.DataSource = _dt;
            lblRecordsValue.Text = _dt.Rows.Count.ToString();
            dgvPayments.DefaultCellStyle.NullValue = "N/A";
        }
    }
}
