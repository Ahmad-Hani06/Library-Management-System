using clsBussinessLogic;
using System;
using System.Runtime.Remoting.Messaging;
using System.Windows.Forms;

namespace Library_Management_System.Member
{
    public partial class frmRenewMember : Form
    {
        private int _memberID = -1;
        private clsMember _member = new clsMember();
        public frmRenewMember(int MemberID)
        {
            InitializeComponent();
            _memberID = MemberID;
            FillData();
        }

        private void FillData()
        {
            _member = clsMember.Find(_memberID);
            txtBoxMemberID.Enabled = false;
            ctrlMemberInfo1.Enabled = false;
            btnSearch.Enabled = false;
            txtBoxMemberID.Text = _memberID.ToString();
            ctrlMemberInfo1.LoadMemberInfo(_memberID);
        }
        public frmRenewMember()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, System.EventArgs e)
        {
            _memberID = Convert.ToInt32(txtBoxMemberID.Text.Trim());

            if (!clsMember.IsMemberIDExists(_memberID))
            {
                MessageBox.Show("MemberID does not Exists, Enter another one.", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            ctrlMemberInfo1.LoadMemberInfo(_memberID);
        }

        private void btnRenew_Click(object sender, EventArgs e)
        {
            if (!clsMember.RenewMember(_memberID, dateTimePickStartDate.Value,dateTimePickEndDate.Value, Convert.ToDecimal(txtBoxRenewalFee.Text.Trim()), clsGlobal.CurrentUser.UserID))
            {
                MessageBox.Show("Renewal membership process didn't Completed", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            MessageBox.Show("Renewal membership process successfully", "Successfull", MessageBoxButtons.OK, MessageBoxIcon.Information);
            ctrlMemberInfo1.ActivateMember = "Active";
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
