using clsBussinessLogic.Person;
using Library_Management_System;
using Library_Management_System.Book;
using Library_Management_System.BorrowBook;
using Library_Management_System.BorrowingBook;
using Library_Management_System.Fine;
using Library_Management_System.Member;
using Library_Management_System.Payment;
using Library_Management_System.Sale;
using Library_Management_System.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows.Forms;

namespace clsBussinessLogic
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmLogin());
        }
    }
}
