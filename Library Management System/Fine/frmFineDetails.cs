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
    public partial class frmFineDetails : Form
    {
        public frmFineDetails(int FineID)
        {
            InitializeComponent();
            ctrlFineDetails1.LoadData(FineID);
        }

        
    }
}
