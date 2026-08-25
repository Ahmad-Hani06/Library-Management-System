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

namespace Library_Management_System.User
{
    public partial class frmManageUsers : Form
    {
        private DataTable _dt = clsUser.GetAllUsers();
        public frmManageUsers()
        {
            InitializeComponent();
        }

        private void ManageUsers_Load(object sender, EventArgs e)
        {
            dgvManageUsers.DataSource = _dt;
            lblRecords.Text = _dt.Rows.Count.ToString();

        }


        private void btnAdd_Click(object sender, EventArgs e)
        {
            
        }
    }
}
