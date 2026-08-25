using clsBussinessLogic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Library_Management_System.User
{
    public partial class frmAddEditUsers : Form
    {
        private int _personID;
        private int _userID;
        private clsUser _user;
        public frmAddEditUsers(int UserID)
        {
            InitializeComponent();
            _userID = UserID;
            _user = clsUser.Find(_userID);
            _FillDataWithUpdateMode();
        }
        public frmAddEditUsers()
        {
            InitializeComponent();
            _user = new clsUser();
        }


        private void _FillDataWithUpdateMode()
        {
            ctrlFindPerson1.FillPersonData(_user.person, _user.PersonID);
        }
        private void frmAddEditUsers_Load(object sender, EventArgs e)
        {
            ctrlFindPerson1.OnPersonFound += _OnPersonFound;
        }

        private bool _IsPersonAvailableForUser()
        {
            if (clsUser.IsPersonAlreadyUser(_personID))
            {
                MessageBox.Show("Person Already has a User choose another one.", "Not Allowed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        private void _OnPersonFound(int PersonID)
        {
            _personID = PersonID;
           if(!_IsPersonAvailableForUser())
            {
                _personID = -1;
                btnNext.Enabled = false;
                return;
            }

            btnNext.Enabled = true;
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            tabControl.SelectedIndex = 1;
        }

        private void _AddNewUser()
        {
            _user.PersonID = ctrlFindPerson1.PersonID;
            _user.UserName = txtBoxUserName.Text.Trim();
            _user.PasswordHash = txtBoxPassword.Text.Trim();
            _user.IsActive = chkBoxIsActive.Checked;

            if (_user.Save())
            {
                MessageBox.Show("Add Data Successfully!", "Save", MessageBoxButtons.OK, MessageBoxIcon.Information);
                lblUserID.Text = _user.UserID.ToString();
                _userID = _user.UserID;
                this.Text = "Update User";
                txtBoxPassword.Enabled = false;
                txtBoxConfirmPassword.Enabled = false;
            }

            else
            {
                MessageBox.Show("Error, the user didnt add successfull", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void _UpdateUser()
        {
            _user.UserID = _userID;
            _user.UserName = txtBoxUserName.Text.Trim();
            _user.IsActive = chkBoxIsActive.Checked;
            

            if (_user.Save())
            {
                MessageBox.Show("Update Data Successfully!", "Update", MessageBoxButtons.OK, MessageBoxIcon.Information);
                lblUserID.Text = _user.UserID.ToString();
            }

            else
            {
                MessageBox.Show("Error, the user didnt Update successfull", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!this.ValidateChildren())
            {
                MessageBox.Show("Please Enter a correct info", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

               string userName = txtBoxUserName.Text.Trim();
            if (_user.Mode == clsUser.enMode.AddNew)
            {
                if (clsUser.isUserNameExists(userName))
                {
                    MessageBox.Show(
                        "UserName already exists. Please enter another one.",
                        "Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);

                    return;
                }
                else
                {
                    _AddNewUser();
                    return;
                }
            }

            if (userName != _user.UserName && clsUser.isUserNameExists(userName))
            {
                MessageBox.Show(
    "UserName already exists. Please enter another one.",
    "Error",
    MessageBoxButtons.OK,
    MessageBoxIcon.Error);

                return;
            }

            else
                _UpdateUser();
        }
    }
}
