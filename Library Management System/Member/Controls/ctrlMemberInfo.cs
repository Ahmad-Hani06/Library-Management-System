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
    public partial class ctrlMemberInfo : UserControl
    {
        private clsMember _member;
        public ctrlMemberInfo()
        {
            InitializeComponent();
        }

        public string ActivateMember
        {
            set
            {
                lblMemberStatus.Text = value;
            }
        }
        public bool LoadMemberInfo(int MemberID)
        {
            _member = clsMember.Find(MemberID);

            if (_member == null)
                return false;

            lblMemberID.Text = _member.MemberID.ToString();
            lblPersonID.Text = _member.PersonID.ToString();
            lblStartDate.Text = _member.StartDate.ToShortDateString();
            lblEndDate.Text = _member.EndDate.ToShortDateString();
            lblMemberStatus.Text = _member.Status ? "Active" : "Inactive";
            return true;
        }
        private void ctrlMemberInfo_Load(object sender, EventArgs e)
        {

        }
    }
}
