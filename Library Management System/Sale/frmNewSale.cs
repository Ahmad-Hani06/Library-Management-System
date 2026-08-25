using clsBussinessLayer;
using clsBussinessLogic;
using System;
using System.Windows.Forms;

namespace Library_Management_System.Sale
{
    public partial class frmNewSale : Form
    {

        private clsPerson _person;
        private clsBook _book;
        private clsSale _sale = new clsSale();

        public frmNewSale()
        {
            InitializeComponent();
        }

        private void frmNewSale_Load(object sender, EventArgs e)
        {
            dgvSaleItems.AutoGenerateColumns = false;
            _ResetSaleForm();
        }

        private void btnFindPerson_Click(object sender, EventArgs e)
        {
            int personID;

            if (!int.TryParse(txtPersonID.Text.Trim(), out personID) || personID <= 0)
            {
                _ShowWarning("Enter a valid numeric Person ID greater than zero.", "Invalid Person ID");
                txtPersonID.Focus();
                return;
            }

            _ClearCustomerSelection();

            try
            {
                _person = clsPerson.Find(personID);

                if (_person == null)
                {
                    _ShowWarning(
                        "No customer was found with Person ID " + personID + ". Check the ID and try again.",
                        "Customer Not Found");
                    txtPersonID.Focus();
                    return;
                }

                _sale.SetCustomer(_person);
                txtCustomerName.Text = _person.FullName;
                txtPhone.Text = Convert.ToString(_person.Phone);
            }
            catch (Exception ex)
            {
                _ShowOperationError("The customer could not be loaded.", ex);
            }
        }

        private void btnFindBook_Click(object sender, EventArgs e)
        {
            string searchBy = cmbBookSearchBy.Text;
            string searchValue = txtBookSearchValue.Text.Trim();

            if (string.IsNullOrWhiteSpace(searchValue))
            {
                _ShowWarning("Enter a value to search for the book.", "Missing Search Value");
                txtBookSearchValue.Focus();
                return;
            }

            _ClearBookSelection();

            try
            {
                switch (searchBy)
                {
                    case "ISBN":
                        int isbn;
                        if (!int.TryParse(searchValue, out isbn) || isbn <= 0)
                        {
                            _ShowWarning("ISBN must be a valid number greater than zero.", "Invalid ISBN");
                            txtBookSearchValue.Focus();
                            return;
                        }

                        _book = clsBook.FindByISBN(isbn);
                        break;

                    case "Title":
                        _book = clsBook.Find(searchValue);
                        break;

                    case "Book ID":
                        int bookID;
                        if (!int.TryParse(searchValue, out bookID) || bookID <= 0)
                        {
                            _ShowWarning("Book ID must be a valid number greater than zero.", "Invalid Book ID");
                            txtBookSearchValue.Focus();
                            return;
                        }

                        _book = clsBook.Find(bookID);
                        break;

                    default:
                        _ShowWarning("Select how you want to search for the book.", "Search Type Required");
                        cmbBookSearchBy.Focus();
                        return;
                }

                if (_book == null)
                {
                    _ShowWarning(
                        "No book matched the entered " + searchBy + ". Check the value and try again.",
                        "Book Not Found");
                    txtBookSearchValue.Focus();
                    return;
                }

                int availableBookCount = _book.GetAvailableCopiesCount();
                txtBookTitle.Text = _book.Title;
                txtBookAuthor.Text = _book.AuthorName;
                lblAvailableCopiesValue.Text = availableBookCount.ToString();

                if (availableBookCount == 0)
                {
                    _ShowWarning(
                        "The book was found, but it has no available copies to sell.",
                        "No Available Copies");
                }
                else
                {
                    txtSalePrice.Focus();
                }
            }
            catch (Exception ex)
            {
                _ShowOperationError("The book could not be loaded.", ex);
            }
        }

        private void btnAddToSale_Click(object sender, EventArgs e)
        {
            if (_book == null || _book.BookID <= 0)
            {
                _ShowWarning("Find and select a book before adding it to the sale.", "Book Required");
                txtBookSearchValue.Focus();
                return;
            }

            decimal price;
            if (!decimal.TryParse(txtSalePrice.Text.Trim(), out price) || price <= 0)
            {
                _ShowWarning("Enter a valid sale price greater than zero.", "Invalid Sale Price");
                txtSalePrice.Focus();
                return;
            }

            try
            {
                if (_sale.AddToSale(_book.BookID, price))
                {
                    _RefreshSaleItems();
                    txtSalePrice.Clear();
                    return;
                }

                _ShowWarning(
                    "No additional copy of this book is available. All available copies may already be included in this sale.",
                    "Book Cannot Be Added");
            }
            catch (Exception ex)
            {
                _ShowOperationError("The book could not be added to the sale.", ex);
            }
        }

        private void deleteRecordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgvSaleItems.CurrentRow == null || _sale.SaleID > 0)
                return;

            clsSaleItem saleItem = dgvSaleItems.CurrentRow.DataBoundItem as clsSaleItem;

            if (saleItem == null)
                return;

            _sale.RemoveFromSale(saleItem);
            _RefreshSaleItems();
        }

        private void _RefreshSaleItems()
        {
            dgvSaleItems.DataSource = null;
            dgvSaleItems.DataSource = _sale.saleItems;

            foreach (DataGridViewRow row in dgvSaleItems.Rows)
                row.Cells[colLineNumber.Index].Value = row.Index + 1;

            lblTotalItemsValue.Text = _sale.saleItems.Count.ToString();
            lblTotalAmountValue.Text = _sale.CalculateTotalAmount().ToString("N2") + " JD";
        }

        private void btnCompleteSale_Click(object sender, EventArgs e)
        {
            if (!_sale.HasCustomer())
            {
                _ShowWarning("Select a customer before completing the sale.", "Customer Required");
                txtPersonID.Focus();
                return;
            }

            if (!_sale.HasSaleItems())
            {
                _ShowWarning("Add at least one book before completing the sale.", "Sale Is Empty");
                txtBookSearchValue.Focus();
                return;
            }

            _sale.UserID = clsGlobal.CurrentUser.UserID;
            _sale.SaleDate = dtpSaleDate.Value;

            try
            {
                if (!_sale.CompleteSale())
                {
                    MessageBox.Show(
                        "The sale could not be saved. The selected copy may no longer be available, or the database rejected the operation. Refresh the selections and try again.",
                        "Sale Not Completed",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                    return;
                }

                lblHeaderMark.Text = "SALE #" + _sale.SaleID;
                lblSaleIdBanner.Text = "Sale completed successfully. Sale ID: " + _sale.SaleID;
                _SetSaleEditingEnabled(false);

                MessageBox.Show(
                    "Sale #" + _sale.SaleID + " was completed successfully.",
                    "Sale Completed",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                _ShowOperationError("The sale could not be completed.", ex);
            }
        }

        private void _SetSaleEditingEnabled(bool enabled)
        {
            pnlCustomerCard.Enabled = enabled;
            pnlAddBookCard.Enabled = enabled;
            pnlItemsCard.Enabled = enabled;
            dtpSaleDate.Enabled = enabled;
            btnCompleteSale.Enabled = enabled;

            // Clear must stay enabled so a completed sale can be replaced with a new one.
            btnClearSale.Enabled = true;
        }

        private void btnClearSale_Click(object sender, EventArgs e)
        {
            _ResetSaleForm();
        }

        private void _ResetSaleForm()
        {
            _sale = new clsSale();
            _person = null;
            _book = null;

            txtPersonID.Clear();
            txtCustomerName.Clear();
            txtPhone.Clear();

            cmbBookSearchBy.SelectedIndex = 1;
            txtBookSearchValue.Clear();
            txtBookTitle.Clear();
            txtBookAuthor.Clear();
            txtSalePrice.Clear();
            lblAvailableCopiesValue.Text = "0";

            dtpSaleDate.Value = DateTime.Now;
            txtCashier.Text = "User #" + clsGlobal.CurrentUser.UserID;
            lblHeaderMark.Text = "NEW SALE";
            lblSaleIdBanner.Text = "Sale ID will be generated automatically when the sale is completed.";

            _SetSaleEditingEnabled(true);
            _RefreshSaleItems();
            txtPersonID.Focus();
        }

        private void _ClearCustomerSelection()
        {
            _person = null;
            _sale.Person = null;
            _sale.PersonID = 0;
            txtCustomerName.Clear();
            txtPhone.Clear();
        }

        private void _ClearBookSelection()
        {
            _book = null;
            txtBookTitle.Clear();
            txtBookAuthor.Clear();
            txtSalePrice.Clear();
            lblAvailableCopiesValue.Text = "0";
        }

        private void _ShowWarning(string message, string title)
        {
            MessageBox.Show(message, title, MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void _ShowOperationError(string message, Exception exception)
        {
            MessageBox.Show(
                message + Environment.NewLine + Environment.NewLine + "Details: " + exception.Message,
                "Operation Failed",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);
        }
    }
}
