using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace clsBussinessLogic
{
    public partial class frmAddEditPerson : Form
    {
        private clsPerson _person = new clsPerson();
        private int _PersonID = -1;
        static public event Action<clsPerson, int> OnPersonAdd;

        public frmAddEditPerson()
        {
            InitializeComponent();
            _person = new clsPerson();
            Text = "Add New Person";
            DtTimePi.MaxDate = DateTime.Now;
        }

        public frmAddEditPerson(int PersonID)
        {
            InitializeComponent();
            _PersonID = PersonID;
            _person = clsPerson.Find(_PersonID);
            DtTimePi.MaxDate = DateTime.Now;
        }


        private void _AddNewPerson()
        {
            _person.FullName = txtBoxFullName.Text.Trim();
            _person.Address = txtBoxAddress.Text.Trim();
            _person.Phone = txtBoxPhone.Text.Trim();
            _person.Email = txtBoxEmail.Text.Trim();
            _person.DateOfBirth = DtTimePi.Value;

            if (_person.Save())
            {
                MessageBox.Show($"Person {_person.PersonID} Saved Successfully.", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtBoxPersonID.Text = _person.PersonID.ToString();
                this.Text = "Update Person";
                OnPersonAdd?.Invoke(_person, _person.PersonID);
                return;
            }
            else
            {
                MessageBox.Show($"Error.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void _ClearPersonInfo()
        {
            txtBoxPersonID.Text = "";
            txtBoxFullName.Text = "";
            txtBoxAddress.Text = "";
            txtBoxEmail.Text = "";
            txtBoxPhone.Text = "";
            //DtTimePi.Value = DateTime.MinValue;
        }
        private void _FillPersonInfo()
        {
            txtBoxPersonID.Text = _person.PersonID.ToString();
            txtBoxFullName.Text = _person.FullName;
            txtBoxAddress.Text = _person.Address;
            txtBoxEmail.Text = _person.Email;
            txtBoxPhone.Text = _person.Phone;
            DtTimePi.Value = _person.DateOfBirth;
        }
        private void _UpdatePerson()
        {
            _person.FullName = txtBoxFullName.Text.Trim();
            _person.Address = txtBoxAddress.Text.Trim();
            _person.Phone = txtBoxPhone.Text.Trim();
            _person.Email = txtBoxEmail.Text.Trim();
            _person.DateOfBirth = DtTimePi.Value;


            if (_person.Save())
            {
                MessageBox.Show($"Person {_person.PersonID} Updated Successfully.", "Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtBoxPersonID.Text = _person.PersonID.ToString();
                return;
            }
            else
            {
                MessageBox.Show($"Error.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private bool _ValidateInputs()
        {
            if (string.IsNullOrWhiteSpace(txtBoxFullName.Text))
            {
                MessageBox.Show("Please enter the full name.", "Missing Data", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtBoxFullName.Focus();
                return false;
            }

            return true;
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!_ValidateInputs())
                return;

            if (_person.Mode == clsPerson.enMode.AddNew)
            {
                _AddNewPerson();
                return;
            }
            else
            {
                _UpdatePerson();
                return;
            }
        }

        private void txtBoxFullName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtBoxPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmAddEditPerson_Load(object sender, EventArgs e)
        {
            if (_person.Mode == clsPerson.enMode.AddNew)
            {
                _ClearPersonInfo();
            }
            else
            {
                _FillPersonInfo();
            }
        }
    }
}
