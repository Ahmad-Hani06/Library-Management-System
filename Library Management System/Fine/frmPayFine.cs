using clsBussinessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library_Management_System.Fine
{
    public partial class frmPayFine : Form
    {
        private int _fineID = -1;
        private clsFine _fine = new clsFine();
        public frmPayFine(int FineID)
        {
            InitializeComponent();
            _fineID = FineID;
            ctrlFine1.LoadData(_fineID);
        }
    }
}
