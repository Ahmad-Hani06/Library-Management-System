using clsBussinessLogic;
using System.Windows.Forms;

namespace Library_Management_System
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
            _LoadLoginData();
        }


        private void _LoadLoginData()
        {
            string[] Data = clsRememberMe.Load();

            if (Data != null)
            {
                txtUserName.Text = Data[0];
                txtPassword.Text = Data[1];
                chkRememberMe.Checked = true;
            }

            else
                chkRememberMe.Checked = false;
        }

        private void btnLogIn_Click(object sender, System.EventArgs e)
        {
            string UserName = txtUserName.Text.Trim();
            string Password = txtPassword.Text.Trim();
           clsGlobal.CurrentUser = clsUser.Login(UserName, Password);

            if (clsGlobal.CurrentUser == null)
            {
                MessageBox.Show("The UserName or Password Invalid", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (chkRememberMe.Checked)
                clsRememberMe.Save(UserName, Password);

            else
                clsRememberMe.Delete();

            frmMain main = new frmMain();
            main.Show();
        }

        private void btnClose_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }


    }
}
