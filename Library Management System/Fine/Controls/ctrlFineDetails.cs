using clsBussinessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library_Management_System.Fine.Controls
{
    public partial class ctrlFineDetails : UserControl
    {
        private clsFine _fine = new clsFine();

  
        public ctrlFineDetails()
        {
            InitializeComponent();
        }

        public void LoadData(int FineID)
        {
            _fine = clsFine.Find(FineID);

            lblFineID.Text = _fine.FineID.ToString();
            lblBorrowingID.Text = _fine.BorrowingID.ToString();
            lblMember.Text = _fine.MemberName;
            lblBook.Text = _fine.BookTitle;
            lblFineType.Text = _fine.FineTypeName;
            //lblFine.Text = fine.FineAmount.ToString();
            lblFineDate.Text = _fine.FineDate.ToShortDateString();
            lblFineStatus.Text = _fine.PaymentStatus.ToString();
        }

        public void ChangePaymentStatus(clsFine.enPaymentStatus paymentStatus)
        {
            _fine.PaymentStatus = paymentStatus;
            lblFineStatus.Text = _fine.PaymentStatus.ToString();
        }
    }
}
