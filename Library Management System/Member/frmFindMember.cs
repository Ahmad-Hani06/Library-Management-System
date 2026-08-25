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
    public partial class frmFindMember : Form
    {
        public frmFindMember()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
           if(!ctrlMemberInfo1.LoadMemberInfo(Convert.ToInt32(txtBoxMemberID.Text.Trim())))
            {
                MessageBox.Show("Member does not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
