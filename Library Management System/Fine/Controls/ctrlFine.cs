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

namespace Library_Management_System.Fine
{
    public partial class ctrlFine : UserControl
    {
        private int _fineID = -1;
        private clsFine _fine = new clsFine();
        public ctrlFine()
        {
            InitializeComponent();
        }

        public void LoadData(int FineID)
        {
            ctrlFineDetails1.LoadData(FineID);
            _fineID = FineID;
        }

        private void btnPayFine_Click(object sender, EventArgs e)
        {
            _fine = clsFine.Find(_fineID);
            if (_fine == null)
            {
                MessageBox.Show($"There is no FineID {_fineID} exists", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (_fine.Pay(clsGlobal.CurrentUser.UserID))
            {
                MessageBox.Show(
                    "Fine paid successfully.",
                    "Success",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                ctrlFineDetails1.ChangePaymentStatus(clsFine.enPaymentStatus.Paid);

            }
            else
            {
                MessageBox.Show(
                    "Fine could not be paid. It may already be paid.",
                    "Payment Failed",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
        }
    }
}
