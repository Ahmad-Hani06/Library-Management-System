using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace clsBussinessLogic.Person
{
    public partial class frmManagePersons : Form
    {
        private DataTable _dt = clsPerson.GetAllPerson();
        public frmManagePersons()
        {
            InitializeComponent();
        }

        private void ManagePerson_Load(object sender, EventArgs e)
        {

            dgvManagePersons.DataSource = _dt;
            lblRecords.Text = _dt.Rows.Count.ToString();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void updatePersonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddEditPerson frm = new frmAddEditPerson((int)dgvManagePersons.SelectedCells[0].Value);
            frm.Show();
        }

        private void deletePerToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
