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

namespace Library_Management_System.Member
{
    public partial class frmAddEditMember : Form
    {

        private clsMember _member = new clsMember();
        private int _memberID = -1;
        private int _personID = -1;
        private enum enMode {AddNew, Update};
        private enMode _mode;

        public frmAddEditMember(int MemberID)
        {
            InitializeComponent();
            _memberID = MemberID;
            //_member.Mode = clsMember.enMode.Update;
            _mode = enMode.Update;
        }

        public frmAddEditMember()
        {
            InitializeComponent();
            //_member.Mode = clsMember.enMode.AddNew;
            _mode = enMode.AddNew;
        }

        private void btnNext_Click(object sender, EventArgs e)
        {

            if (_mode == enMode.AddNew)
            {
                if (clsMember.IsPersonMember(_personID))
                {
                    MessageBox.Show("This Person has a membership, Please enter another one!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            tbControl.SelectedIndex = 1;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!this.ValidateChildren())
            {
                MessageBox.Show("Some fileds are not valid!, put the mouse over the red icon(s)");
                return;
            }

            _member.PersonID = _personID;
            _member.StartDate = dateTimePickStartDate.Value;
            _member.EndDate = dateTimePickEndDate.Value;
            _member.Status = chkBoxActiveation.Checked;

            decimal PaymentAmount = Convert.ToDecimal(lblFee.Text.Trim());

            if (_member.Save(PaymentAmount, clsGlobal.CurrentUser.UserID, "New Membership Payment"))
            {
                MessageBox.Show("Data Saved Sucessfully");
                txtBoxMemberID.Text = _member.MemberID.ToString();
                this.Text = "Update Member";
            }

            else
            {
                MessageBox.Show("Error: Data Is not Save Successfully.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void _ResetData()
        {
            tabPage1.Enabled = true;
            ctrlFindPerson1.ClearPersonData();
            lblFee.Text = "5.00";
            chkBoxActiveation.Checked = true;
            dateTimePickStartDate.Value = DateTime.Now;
            dateTimePickEndDate.Value = DateTime.Now;
        }
        private void frmAddEditMember_Load(object sender, EventArgs e)
        {
            _ResetData();

            if (_mode == enMode.Update)
                _FillData();
        }
        private void _FillData()
        {
            _member = clsMember.Find(_memberID);
            if (_member == null)
            {
                MessageBox.Show("Member does not exists", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            ctrlFindPerson1.FillPersonData(_member.person, _member.PersonID);
            ctrlFindPerson1.Enabled = false;
            chkBoxActiveation.Enabled = true;
            _personID = ctrlFindPerson1.PersonID;
            txtBoxPersonID.Text = _personID.ToString();
            dateTimePickStartDate.Value = _member.StartDate;
            dateTimePickEndDate.Value = _member.EndDate;
            chkBoxActiveation.Checked = _member.Status;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
