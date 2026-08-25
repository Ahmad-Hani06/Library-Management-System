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
    public partial class frmShowMemberInfo : Form
    {
        private int _memberID = -1;
        public frmShowMemberInfo()
        {
            InitializeComponent();
        }
        public frmShowMemberInfo(int MemberID)
        {
            InitializeComponent();
            _memberID = MemberID;
        }

        private void frmShowMemberInfo_Load(object sender, EventArgs e)
        {
            ctrlMemberInfo1.LoadMemberInfo(_memberID);
        }
    }
}
