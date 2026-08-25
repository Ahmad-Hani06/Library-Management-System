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
    public partial class frmManageMember : Form
    {
        private DataTable _dt = new DataTable();
        public frmManageMember()
        {
            InitializeComponent();
        }

        private void frmManageMember_Load(object sender, EventArgs e)
        {
            clsMember.DeactivateExpiredMembers(); // Check if the Membership expired
            _RefreshMembersList();
        }
        private void _RefreshMembersList()
        {
            _dt = clsMember.GetAllMembers();
            dgvManageMember.DataSource = _dt;
        }
        private void editMemberToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddEditMember frmAddEdit = new frmAddEditMember((int)dgvManageMember.SelectedCells[0].Value);
            frmAddEdit.ShowDialog();
            _RefreshMembersList();
        }

        private void showMemberDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmShowMemberInfo frmShowMember = new frmShowMemberInfo((int)dgvManageMember.SelectedCells[0].Value);
            frmShowMember.ShowDialog();
        }

        private void guna2ContextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {
            string stActivation = Convert.ToString(dgvManageMember.CurrentRow.Cells["MemberStatus"].Value);

            if (stActivation == "Active")
            {
                deactivToolStripMenuItem.Text = "Deactivate";
                renewToolStripMenuItem.Enabled = false;
            }
            else
            {
                deactivToolStripMenuItem.Text = "Activate";
                renewToolStripMenuItem.Enabled = true;
            }
        }

        private void deactivToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string Status = Convert.ToString(dgvManageMember.CurrentRow.Cells["MemberStatus"].Value);

            bool isActive = Status != "Active";
            int MemberID = (int)dgvManageMember.SelectedCells[0].Value;
            if (!clsMember.ChangeMemberStatus(MemberID, isActive))
            {
                MessageBox.Show("Error: This process Failed", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            _RefreshMembersList();
        }

        private void renewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRenewMember frmRenew = new frmRenewMember((int)dgvManageMember.SelectedCells[0].Value);
            frmRenew.ShowDialog();
            _RefreshMembersList();
        }
    }
}
