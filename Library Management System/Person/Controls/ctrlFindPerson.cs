using System;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;


namespace clsBussinessLogic
{
    public partial class ctrlFindPerson : UserControl
    {
        public event Action<int> OnPersonFound;

        private int _personID;
        public int PersonID 
        {
            get
            {
                return _personID;
            }

            set
            {
                _personID = value;
            }
        }
        public ctrlFindPerson()
        {
            InitializeComponent();
            frmAddEditPerson.OnPersonAdd += FillPersonData;
        }

        public void ClearPersonData()
        {
            txtBoxPersonID.Clear();
            txtBoxFullName.Clear();
            txtBoxAddress.Clear();
            txtBoxPhone.Clear();
            txtBoxEmail.Clear();
            txtBoxCreatedAt.Clear();

            DateTimePickerDateOfBirth.Value = DateTime.Today;
        }
        public void FillPersonData(clsPerson person, int personID) // personID ??! clsperson.PersonID
        {
            PersonID = personID;
            txtBoxPersonID.Text = personID.ToString();
            txtBoxFullName.Text = person.FullName;
            txtBoxAddress.Text = person.Address;
            txtBoxPhone.Text = person.Phone;
            txtBoxEmail.Text = person.Email;
            DateTimePickerDateOfBirth.Value = Convert.ToDateTime(person.DateOfBirth);
            txtBoxCreatedAt.Text = person.CreatedAt.ToString("dd/MM/yyyy HH:mm");
            OnPersonFound?.Invoke(personID);
        }
        private void btnFind_Click(object sender, EventArgs e)
        {

            if (!int.TryParse(txtBoxPersonID.Text.Trim(), out int personID))
            {
                MessageBox.Show("Please enter a valid Person ID.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtBoxPersonID.Focus();
                return;
            }
            clsPerson person = clsPerson.Find(personID);

            if (person == null)
            {
                MessageBox.Show("Person is not found", "Falied", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ClearPersonData();
                return;
            }
            FillPersonData(person, personID);
            PersonID = personID;
        }

        private void txtBoxPersonID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearPersonData();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmAddEditPerson frmAddEditPerson = new frmAddEditPerson();
            frmAddEditPerson.Show();
        }
    }
}
