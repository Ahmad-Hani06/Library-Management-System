using clsBussinessLogic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library_Management_System.Person
{
    public partial class ctrlPersonInfo : UserControl
    {
        private int _PersonID = -1;
        private clsPerson _Person;
        public ctrlPersonInfo()
        {
            InitializeComponent();
        }

        public bool LoadPersonInfo(int PersonID)
        {
            _ResetPersonInfo();
            _Person = clsPerson.Find(_PersonID);

            if (_Person == null)
            {
                MessageBox.Show("Person does not exsits", "Not found", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            _PersonID = _Person.PersonID;

            _FillPersonInfo();

            return true;
        }


        private void _ResetPersonInfo()
        {
            _PersonID = -1;
            _Person = null;

            lbPersonID.Text = "[????]";
            lbName.Text = "[????]";
            lbAddress.Text = "[????]";
            lbEmail.Text = "[????]";
            lbDateOfBirth.Text = "[????]";
            lblCreatedAt.Text = "[????]";

            // lblPhone.Text = "[????]";
        }

        private void _FillPersonInfo()
        {
            if (_Person == null)
                return;

            lbPersonID.Text = _PersonID.ToString();
            lbAddress.Text = string.IsNullOrWhiteSpace(_Person.Address) ? "N/A" : _Person.Address;

            lbEmail.Text = string.IsNullOrWhiteSpace(_Person.Email) ? "N/A" : _Person.Email;
            lbName.Text = _Person.FullName;
            lbDateOfBirth.Text = _Person.DateOfBirth.ToString("dd/MM/yyyy");
            lblCreatedAt.Text = _Person.CreatedAt.ToString("dd/MM/yyyy hh:mm tt");
        }
        private void ctrlPersonInfo_Load(object sender, EventArgs e)
        {
 
        }

        private void lbEditPerson_Click(object sender, EventArgs e)
        {
            frmAddEditPerson frmAddEditPerson = new frmAddEditPerson(_PersonID);
            frmAddEditPerson.Show();
        }
    }
}
