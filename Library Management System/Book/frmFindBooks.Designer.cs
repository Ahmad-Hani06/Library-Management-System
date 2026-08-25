namespace Library_Management_System.Book
{
    partial class frmFindBooks
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.pnlHeaderIcon = new System.Windows.Forms.Panel();
            this.lblHeaderIcon = new System.Windows.Forms.Label();
            this.lblHeaderSubtitle = new System.Windows.Forms.Label();
            this.lblHeaderTitle = new System.Windows.Forms.Label();
            this.pnlSearchCard = new Guna.UI2.WinForms.Guna2Panel();
            this.lblSearchHint = new System.Windows.Forms.Label();
            this.lblSearchCaption = new System.Windows.Forms.Label();
            this.cmbSearchBy = new Guna.UI2.WinForms.Guna2ComboBox();
            this.txtSearchValue = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnSearch = new Guna.UI2.WinForms.Guna2Button();
            this.btnClear = new Guna.UI2.WinForms.Guna2Button();
            this.pnlResultHeading = new System.Windows.Forms.Panel();
            this.lblResultIcon = new System.Windows.Forms.Label();
            this.lblResultTitle = new System.Windows.Forms.Label();
            this.lblResultSubtitle = new System.Windows.Forms.Label();
            this.pnlBookInfoHost = new Guna.UI2.WinForms.Guna2Panel();
            this.ctrlBookInfo1 = new Library_Management_System.Book.ctrlBookInfo();
            this.pnlHeader.SuspendLayout();
            this.pnlHeaderIcon.SuspendLayout();
            this.pnlSearchCard.SuspendLayout();
            this.pnlResultHeading.SuspendLayout();
            this.pnlBookInfoHost.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(33)))), ((int)(((byte)(61)))));
            this.pnlHeader.Controls.Add(this.pnlHeaderIcon);
            this.pnlHeader.Controls.Add(this.lblHeaderSubtitle);
            this.pnlHeader.Controls.Add(this.lblHeaderTitle);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(1100, 108);
            this.pnlHeader.TabIndex = 0;
            // 
            // pnlHeaderIcon
            // 
            this.pnlHeaderIcon.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlHeaderIcon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(63)))), ((int)(((byte)(105)))));
            this.pnlHeaderIcon.Controls.Add(this.lblHeaderIcon);
            this.pnlHeaderIcon.Location = new System.Drawing.Point(1006, 22);
            this.pnlHeaderIcon.Name = "pnlHeaderIcon";
            this.pnlHeaderIcon.Size = new System.Drawing.Size(64, 64);
            this.pnlHeaderIcon.TabIndex = 2;
            // 
            // lblHeaderIcon
            // 
            this.lblHeaderIcon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblHeaderIcon.Font = new System.Drawing.Font("Segoe MDL2 Assets", 24F);
            this.lblHeaderIcon.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(209)))), ((int)(((byte)(197)))));
            this.lblHeaderIcon.Location = new System.Drawing.Point(0, 0);
            this.lblHeaderIcon.Name = "lblHeaderIcon";
            this.lblHeaderIcon.Size = new System.Drawing.Size(64, 64);
            this.lblHeaderIcon.TabIndex = 0;
            this.lblHeaderIcon.Text = "îœ¡";
            this.lblHeaderIcon.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblHeaderSubtitle
            // 
            this.lblHeaderSubtitle.AutoSize = true;
            this.lblHeaderSubtitle.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblHeaderSubtitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(184)))), ((int)(((byte)(209)))));
            this.lblHeaderSubtitle.Location = new System.Drawing.Point(31, 66);
            this.lblHeaderSubtitle.Name = "lblHeaderSubtitle";
            this.lblHeaderSubtitle.Size = new System.Drawing.Size(365, 17);
            this.lblHeaderSubtitle.TabIndex = 1;
            this.lblHeaderSubtitle.Text = "Search the catalog and review the selected book information.";
            // 
            // lblHeaderTitle
            // 
            this.lblHeaderTitle.AutoSize = true;
            this.lblHeaderTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 20F, System.Drawing.FontStyle.Bold);
            this.lblHeaderTitle.ForeColor = System.Drawing.Color.White;
            this.lblHeaderTitle.Location = new System.Drawing.Point(27, 25);
            this.lblHeaderTitle.Name = "lblHeaderTitle";
            this.lblHeaderTitle.Size = new System.Drawing.Size(151, 37);
            this.lblHeaderTitle.TabIndex = 0;
            this.lblHeaderTitle.Text = "Find Books";
            // 
            // pnlSearchCard
            // 
            this.pnlSearchCard.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlSearchCard.BackColor = System.Drawing.Color.White;
            this.pnlSearchCard.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(228)))), ((int)(((byte)(238)))));
            this.pnlSearchCard.BorderRadius = 12;
            this.pnlSearchCard.BorderThickness = 1;
            this.pnlSearchCard.Controls.Add(this.lblSearchHint);
            this.pnlSearchCard.Controls.Add(this.lblSearchCaption);
            this.pnlSearchCard.Controls.Add(this.cmbSearchBy);
            this.pnlSearchCard.Controls.Add(this.txtSearchValue);
            this.pnlSearchCard.Controls.Add(this.btnSearch);
            this.pnlSearchCard.Controls.Add(this.btnClear);
            this.pnlSearchCard.Location = new System.Drawing.Point(28, 128);
            this.pnlSearchCard.Name = "pnlSearchCard";
            this.pnlSearchCard.Size = new System.Drawing.Size(1044, 112);
            this.pnlSearchCard.TabIndex = 1;
            // 
            // lblSearchHint
            // 
            this.lblSearchHint.AutoSize = true;
            this.lblSearchHint.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.lblSearchHint.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(139)))), ((int)(((byte)(162)))));
            this.lblSearchHint.Location = new System.Drawing.Point(22, 81);
            this.lblSearchHint.Name = "lblSearchHint";
            this.lblSearchHint.Size = new System.Drawing.Size(255, 13);
            this.lblSearchHint.TabIndex = 5;
            this.lblSearchHint.Text = "Choose a field, enter a value, then select Search.";
            // 
            // lblSearchCaption
            // 
            this.lblSearchCaption.AutoSize = true;
            this.lblSearchCaption.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.lblSearchCaption.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(33)))), ((int)(((byte)(61)))));
            this.lblSearchCaption.Location = new System.Drawing.Point(22, 17);
            this.lblSearchCaption.Name = "lblSearchCaption";
            this.lblSearchCaption.Size = new System.Drawing.Size(93, 15);
            this.lblSearchCaption.TabIndex = 0;
            this.lblSearchCaption.Text = "SEARCH BOOKS";
            // 
            // cmbSearchBy
            // 
            this.cmbSearchBy.BackColor = System.Drawing.Color.Transparent;
            this.cmbSearchBy.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(214)))), ((int)(((byte)(227)))));
            this.cmbSearchBy.BorderRadius = 7;
            this.cmbSearchBy.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbSearchBy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSearchBy.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(166)))), ((int)(((byte)(154)))));
            this.cmbSearchBy.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(166)))), ((int)(((byte)(154)))));
            this.cmbSearchBy.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cmbSearchBy.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(48)))), ((int)(((byte)(73)))));
            this.cmbSearchBy.ItemHeight = 30;
            this.cmbSearchBy.Items.AddRange(new object[] {
            "Book ID",
            "ISBN",
            "Title"});
            this.cmbSearchBy.Location = new System.Drawing.Point(24, 39);
            this.cmbSearchBy.Name = "cmbSearchBy";
            this.cmbSearchBy.Size = new System.Drawing.Size(184, 36);
            this.cmbSearchBy.StartIndex = 0;
            this.cmbSearchBy.TabIndex = 1;
            // 
            // txtSearchValue
            // 
            this.txtSearchValue.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSearchValue.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(214)))), ((int)(((byte)(227)))));
            this.txtSearchValue.BorderRadius = 7;
            this.txtSearchValue.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSearchValue.DefaultText = "";
            this.txtSearchValue.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(166)))), ((int)(((byte)(154)))));
            this.txtSearchValue.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtSearchValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(48)))), ((int)(((byte)(73)))));
            this.txtSearchValue.Location = new System.Drawing.Point(220, 39);
            this.txtSearchValue.Name = "txtSearchValue";
            this.txtSearchValue.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(165)))), ((int)(((byte)(184)))));
            this.txtSearchValue.PlaceholderText = "Enter the value to search for";
            this.txtSearchValue.SelectedText = "";
            this.txtSearchValue.Size = new System.Drawing.Size(492, 36);
            this.txtSearchValue.TabIndex = 2;
            // 
            // btnSearch
            // 
            this.btnSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSearch.BorderRadius = 7;
            this.btnSearch.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(166)))), ((int)(((byte)(154)))));
            this.btnSearch.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Location = new System.Drawing.Point(724, 39);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(142, 36);
            this.btnSearch.TabIndex = 3;
            this.btnSearch.Text = "Search";
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnClear
            // 
            this.btnClear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClear.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(214)))), ((int)(((byte)(227)))));
            this.btnClear.BorderRadius = 7;
            this.btnClear.BorderThickness = 1;
            this.btnClear.FillColor = System.Drawing.Color.White;
            this.btnClear.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.btnClear.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(80)))), ((int)(((byte)(103)))));
            this.btnClear.Location = new System.Drawing.Point(878, 39);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(142, 36);
            this.btnClear.TabIndex = 4;
            this.btnClear.Text = "Clear";
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // pnlResultHeading
            // 
            this.pnlResultHeading.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlResultHeading.BackColor = System.Drawing.Color.Transparent;
            this.pnlResultHeading.Controls.Add(this.lblResultIcon);
            this.pnlResultHeading.Controls.Add(this.lblResultTitle);
            this.pnlResultHeading.Controls.Add(this.lblResultSubtitle);
            this.pnlResultHeading.Location = new System.Drawing.Point(28, 253);
            this.pnlResultHeading.Name = "pnlResultHeading";
            this.pnlResultHeading.Size = new System.Drawing.Size(1044, 52);
            this.pnlResultHeading.TabIndex = 2;
            // 
            // lblResultIcon
            // 
            this.lblResultIcon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(250)))), ((int)(((byte)(248)))));
            this.lblResultIcon.Font = new System.Drawing.Font("Segoe MDL2 Assets", 15F);
            this.lblResultIcon.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(166)))), ((int)(((byte)(154)))));
            this.lblResultIcon.Location = new System.Drawing.Point(0, 3);
            this.lblResultIcon.Name = "lblResultIcon";
            this.lblResultIcon.Size = new System.Drawing.Size(42, 42);
            this.lblResultIcon.TabIndex = 0;
            this.lblResultIcon.Text = "î¢©";
            this.lblResultIcon.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblResultTitle
            // 
            this.lblResultTitle.AutoSize = true;
            this.lblResultTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            this.lblResultTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(33)))), ((int)(((byte)(61)))));
            this.lblResultTitle.Location = new System.Drawing.Point(54, 5);
            this.lblResultTitle.Name = "lblResultTitle";
            this.lblResultTitle.Size = new System.Drawing.Size(100, 20);
            this.lblResultTitle.TabIndex = 1;
            this.lblResultTitle.Text = "Search Result";
            // 
            // lblResultSubtitle
            // 
            this.lblResultSubtitle.AutoSize = true;
            this.lblResultSubtitle.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.lblResultSubtitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(139)))), ((int)(((byte)(162)))));
            this.lblResultSubtitle.Location = new System.Drawing.Point(55, 27);
            this.lblResultSubtitle.Name = "lblResultSubtitle";
            this.lblResultSubtitle.Size = new System.Drawing.Size(299, 15);
            this.lblResultSubtitle.TabIndex = 2;
            this.lblResultSubtitle.Text = "Book details will appear below after a successful search.";
            // 
            // pnlBookInfoHost
            // 
            this.pnlBookInfoHost.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlBookInfoHost.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(228)))), ((int)(((byte)(238)))));
            this.pnlBookInfoHost.BorderRadius = 12;
            this.pnlBookInfoHost.BorderThickness = 1;
            this.pnlBookInfoHost.Controls.Add(this.ctrlBookInfo1);
            this.pnlBookInfoHost.Location = new System.Drawing.Point(28, 311);
            this.pnlBookInfoHost.Name = "pnlBookInfoHost";
            this.pnlBookInfoHost.Padding = new System.Windows.Forms.Padding(1);
            this.pnlBookInfoHost.Size = new System.Drawing.Size(1044, 432);
            this.pnlBookInfoHost.TabIndex = 3;
            // 
            // ctrlBookInfo1
            // 
            this.ctrlBookInfo1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(245)))), ((int)(((byte)(249)))));
            this.ctrlBookInfo1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ctrlBookInfo1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ctrlBookInfo1.Location = new System.Drawing.Point(1, 1);
            this.ctrlBookInfo1.Name = "ctrlBookInfo1";
            this.ctrlBookInfo1.Size = new System.Drawing.Size(1042, 430);
            this.ctrlBookInfo1.TabIndex = 0;
            // 
            // frmFindBooks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(245)))), ((int)(((byte)(249)))));
            this.ClientSize = new System.Drawing.Size(1100, 749);
            this.Controls.Add(this.pnlBookInfoHost);
            this.Controls.Add(this.pnlResultHeading);
            this.Controls.Add(this.pnlSearchCard);
            this.Controls.Add(this.pnlHeader);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmFindBooks";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Find Books";
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.pnlHeaderIcon.ResumeLayout(false);
            this.pnlSearchCard.ResumeLayout(false);
            this.pnlSearchCard.PerformLayout();
            this.pnlResultHeading.ResumeLayout(false);
            this.pnlResultHeading.PerformLayout();
            this.pnlBookInfoHost.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Panel pnlHeaderIcon;
        private System.Windows.Forms.Label lblHeaderIcon;
        private System.Windows.Forms.Label lblHeaderSubtitle;
        private System.Windows.Forms.Label lblHeaderTitle;
        private Guna.UI2.WinForms.Guna2Panel pnlSearchCard;
        private System.Windows.Forms.Label lblSearchHint;
        private System.Windows.Forms.Label lblSearchCaption;
        private Guna.UI2.WinForms.Guna2ComboBox cmbSearchBy;
        private Guna.UI2.WinForms.Guna2TextBox txtSearchValue;
        private Guna.UI2.WinForms.Guna2Button btnSearch;
        private Guna.UI2.WinForms.Guna2Button btnClear;
        private System.Windows.Forms.Panel pnlResultHeading;
        private System.Windows.Forms.Label lblResultIcon;
        private System.Windows.Forms.Label lblResultTitle;
        private System.Windows.Forms.Label lblResultSubtitle;
        private Guna.UI2.WinForms.Guna2Panel pnlBookInfoHost;
        private Library_Management_System.Book.ctrlBookInfo ctrlBookInfo1;
    }
}
