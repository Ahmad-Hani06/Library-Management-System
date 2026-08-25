using clsBussinessLogic;
using clsDataAccessLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace clsBussinessLayer
{
    public class clsSale
    {

        public List<clsSaleItem> saleItems = new List<clsSaleItem>();
        public int SaleID { get; set; }
        public int PersonID { get; set; }
        public DateTime SaleDate { get; set; }
        public int UserID { get; set; }

        public clsPerson Person;


        public clsSale()
        {
           saleItems = new List<clsSaleItem>();
            SaleID = 0;
            PersonID = 0;
            SaleDate = DateTime.Now;
            UserID = 0;
            Person = null;
        }

        public clsSale(int SaleID, int PersonID, DateTime SaleDate, int UserID)
        {
            this.SaleID = SaleID;
            this.PersonID = PersonID;
            this.SaleDate = SaleDate;
            this.UserID = UserID;
            Person = clsPerson.Find(PersonID);
        }





        public bool AddToSale(int BookID, decimal SalePrice)
        {
            List<int> _bookCopies = clsBookCopy.GetAvailableBookCopyByBookID(BookID);

            if (_bookCopies.Count == 0)
            {
                return false; // there doesnt have any BookCopiesAvailable
            }

            foreach(var item in _bookCopies)
            {
                bool isAlreadyExists = saleItems.Any(x => x.BookCopyID == item);

                if (!isAlreadyExists)
                {
                    saleItems.Add(new clsSaleItem(-1, -1, item, SalePrice));
                    return true;
                }
            }

            return false;
        }

        public bool RemoveFromSale(clsSaleItem saleItem)
        {
            return saleItems.Remove(saleItem);
        }

        public decimal CalculateTotalAmount()
        {
            decimal totalAmount = 0;

            foreach (var item in saleItems) 
            {
                totalAmount += item.SalePrice;
            }
            return totalAmount;
        }

        public bool HasSaleItems()
        {
            return saleItems.Count > 0;
        }

        public void SetCustomer(clsPerson person)
        {
            if (person == null)
                return;
            this.Person = person;
            this.PersonID = person.PersonID;
        }

        public bool HasCustomer()
        {
            return this.Person != null;
        }

        public bool HasUser()
        {
            return UserID > 0;
        }

        private DataTable _GetSaleItemsDataTable()
        {
            DataTable itemsTable = new DataTable();

            itemsTable.Columns.Add("BookCopyID", typeof(int));
            itemsTable.Columns.Add("SalePrice", typeof(decimal));

            foreach (var item in saleItems)
            {
                itemsTable.Rows.Add(item.BookCopyID, item.SalePrice);
            }
            return itemsTable;
        }
        public bool CompleteSale()
        {
            if (!HasSaleItems())
                return false;

            if (!HasCustomer())
                return false;

            if (!HasUser())
                return false;

            decimal totalAmount = CalculateTotalAmount(); // for Payment

            DataTable dt = _GetSaleItemsDataTable();

            if (dt.Rows.Count == 0)
                return false;


            this.SaleID = clsSaleData.CompleteSale(this.PersonID, this.UserID, this.SaleDate, totalAmount, dt);


            return this.SaleID != -1;

        }
    }
}
