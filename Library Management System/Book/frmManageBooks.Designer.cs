namespace Library_Management_System.Book
{
    partial class frmManageBooks
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.btnAddBook = new Guna.UI2.WinForms.Guna2Button();
            this.pnlHeaderIcon = new System.Windows.Forms.Panel();
            this.lblHeaderIcon = new System.Windows.Forms.Label();
            this.lblHeaderSubtitle = new System.Windows.Forms.Label();
            this.lblHeaderTitle = new System.Windows.Forms.Label();
            this.dgvManageBooks = new Guna.UI2.WinForms.Guna2DataGridView();
            this.colBookID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colISBN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTitle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAuthor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCategory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PublicationYear = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmsBookActions = new Guna.UI2.WinForms.Guna2ContextMenuStrip();
            this.viewBookDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editBookToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.deleteBookToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlFooter = new System.Windows.Forms.Panel();
            this.lblFooterIcon = new System.Windows.Forms.Label();
            this.lblFooterText = new System.Windows.Forms.Label();
            this.addBookCopyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteBookCopyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.pnlHeader.SuspendLayout();
            this.pnlHeaderIcon.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvManageBooks)).BeginInit();
            this.cmsBookActions.SuspendLayout();
            this.pnlFooter.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(33)))), ((int)(((byte)(61)))));
            this.pnlHeader.Controls.Add(this.btnAddBook);
            this.pnlHeader.Controls.Add(this.pnlHeaderIcon);
            this.pnlHeader.Controls.Add(this.lblHeaderSubtitle);
            this.pnlHeader.Controls.Add(this.lblHeaderTitle);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(1180, 108);
            this.pnlHeader.TabIndex = 0;
            // 
            // btnAddBook
            // 
            this.btnAddBook.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddBook.BorderRadius = 8;
            this.btnAddBook.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(166)))), ((int)(((byte)(154)))));
            this.btnAddBook.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.btnAddBook.ForeColor = System.Drawing.Color.White;
            this.btnAddBook.Location = new System.Drawing.Point(866, 35);
            this.btnAddBook.Name = "btnAddBook";
            this.btnAddBook.Size = new System.Drawing.Size(176, 40);
            this.btnAddBook.TabIndex = 2;
            this.btnAddBook.Text = "+  Add New Book";
            this.btnAddBook.Click += new System.EventHandler(this.btnAddBook_Click);
            // 
            // pnlHeaderIcon
            // 
            this.pnlHeaderIcon.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlHeaderIcon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(63)))), ((int)(((byte)(105)))));
            this.pnlHeaderIcon.Controls.Add(this.lblHeaderIcon);
            this.pnlHeaderIcon.Location = new System.Drawing.Point(1086, 22);
            this.pnlHeaderIcon.Name = "pnlHeaderIcon";
            this.pnlHeaderIcon.Size = new System.Drawing.Size(64, 64);
            this.pnlHeaderIcon.TabIndex = 3;
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
            this.lblHeaderIcon.Text = "";
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
            this.lblHeaderSubtitle.Text = "Browse the library catalog and access available book actions.";
            // 
            // lblHeaderTitle
            // 
            this.lblHeaderTitle.AutoSize = true;
            this.lblHeaderTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 20F, System.Drawing.FontStyle.Bold);
            this.lblHeaderTitle.ForeColor = System.Drawing.Color.White;
            this.lblHeaderTitle.Location = new System.Drawing.Point(27, 25);
            this.lblHeaderTitle.Name = "lblHeaderTitle";
            this.lblHeaderTitle.Size = new System.Drawing.Size(197, 37);
            this.lblHeaderTitle.TabIndex = 0;
            this.lblHeaderTitle.Text = "Manage Books";
            // 
            // dgvManageBooks
            // 
            this.dgvManageBooks.AllowUserToAddRows = false;
            this.dgvManageBooks.AllowUserToDeleteRows = false;
            this.dgvManageBooks.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(251)))), ((int)(((byte)(254)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(80)))), ((int)(((byte)(103)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(250)))), ((int)(((byte)(248)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(33)))), ((int)(((byte)(61)))));
            this.dgvManageBooks.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvManageBooks.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(43)))), ((int)(((byte)(75)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(43)))), ((int)(((byte)(75)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvManageBooks.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvManageBooks.ColumnHeadersHeight = 44;
            this.dgvManageBooks.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colBookID,
            this.colISBN,
            this.colTitle,
            this.colAuthor,
            this.colCategory,
            this.PublicationYear,
            this.Column1});
            this.dgvManageBooks.ContextMenuStrip = this.cmsBookActions;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(80)))), ((int)(((byte)(103)))));
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(250)))), ((int)(((byte)(248)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(33)))), ((int)(((byte)(61)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvManageBooks.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvManageBooks.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(239)))), ((int)(((byte)(246)))));
            this.dgvManageBooks.Location = new System.Drawing.Point(12, 114);
            this.dgvManageBooks.MultiSelect = false;
            this.dgvManageBooks.Name = "dgvManageBooks";
            this.dgvManageBooks.ReadOnly = true;
            this.dgvManageBooks.RowHeadersVisible = false;
            this.dgvManageBooks.RowTemplate.Height = 43;
            this.dgvManageBooks.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvManageBooks.Size = new System.Drawing.Size(1124, 428);
            this.dgvManageBooks.TabIndex = 5;
            this.dgvManageBooks.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(251)))), ((int)(((byte)(254)))));
            this.dgvManageBooks.ThemeStyle.AlternatingRowsStyle.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dgvManageBooks.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(80)))), ((int)(((byte)(103)))));
            this.dgvManageBooks.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(250)))), ((int)(((byte)(248)))));
            this.dgvManageBooks.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(33)))), ((int)(((byte)(61)))));
            this.dgvManageBooks.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(239)))), ((int)(((byte)(246)))));
            this.dgvManageBooks.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(43)))), ((int)(((byte)(75)))));
            this.dgvManageBooks.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dgvManageBooks.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvManageBooks.ThemeStyle.HeaderStyle.Height = 44;
            this.dgvManageBooks.ThemeStyle.ReadOnly = true;
            this.dgvManageBooks.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dgvManageBooks.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(80)))), ((int)(((byte)(103)))));
            this.dgvManageBooks.ThemeStyle.RowsStyle.Height = 43;
            this.dgvManageBooks.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(250)))), ((int)(((byte)(248)))));
            this.dgvManageBooks.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(33)))), ((int)(((byte)(61)))));
            // 
            // colBookID
            // 
            this.colBookID.DataPropertyName = "BookID";
            this.colBookID.FillWeight = 55F;
            this.colBookID.HeaderText = "BOOK ID";
            this.colBookID.Name = "colBookID";
            this.colBookID.ReadOnly = true;
            // 
            // colISBN
            // 
            this.colISBN.DataPropertyName = "ISBN";
            this.colISBN.FillWeight = 88F;
            this.colISBN.HeaderText = "ISBN";
            this.colISBN.Name = "colISBN";
            this.colISBN.ReadOnly = true;
            // 
            // colTitle
            // 
            this.colTitle.DataPropertyName = "Title";
            this.colTitle.FillWeight = 145F;
            this.colTitle.HeaderText = "TITLE";
            this.colTitle.Name = "colTitle";
            this.colTitle.ReadOnly = true;
            // 
            // colAuthor
            // 
            this.colAuthor.DataPropertyName = "Author";
            this.colAuthor.FillWeight = 110F;
            this.colAuthor.HeaderText = "AUTHOR";
            this.colAuthor.Name = "colAuthor";
            this.colAuthor.ReadOnly = true;
            // 
            // colCategory
            // 
            this.colCategory.DataPropertyName = "Category";
            this.colCategory.FillWeight = 85F;
            this.colCategory.HeaderText = "CATEGORY";
            this.colCategory.Name = "colCategory";
            this.colCategory.ReadOnly = true;
            // 
            // PublicationYear
            // 
            this.PublicationYear.HeaderText = "Publication Year";
            this.PublicationYear.Name = "PublicationYear";
            this.PublicationYear.ReadOnly = true;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "AvailableCopies";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // cmsBookActions
            // 
            this.cmsBookActions.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.cmsBookActions.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewBookDetailsToolStripMenuItem,
            this.editBookToolStripMenuItem,
            this.deleteBookToolStripMenuItem,
            this.toolStripSeparator2,
            this.addBookCopyToolStripMenuItem,
            this.deleteBookCopyToolStripMenuItem,
            this.toolStripSeparator1});
            this.cmsBookActions.Name = "cmsBookActions";
            this.cmsBookActions.RenderStyle.ArrowColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(166)))), ((int)(((byte)(154)))));
            this.cmsBookActions.RenderStyle.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(225)))), ((int)(((byte)(236)))));
            this.cmsBookActions.RenderStyle.ColorTable = null;
            this.cmsBookActions.RenderStyle.RoundedEdges = true;
            this.cmsBookActions.RenderStyle.SelectionArrowColor = System.Drawing.Color.White;
            this.cmsBookActions.RenderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(166)))), ((int)(((byte)(154)))));
            this.cmsBookActions.RenderStyle.SelectionForeColor = System.Drawing.Color.White;
            this.cmsBookActions.RenderStyle.SeparatorColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(234)))), ((int)(((byte)(242)))));
            this.cmsBookActions.RenderStyle.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.cmsBookActions.Size = new System.Drawing.Size(214, 166);
            // 
            // viewBookDetailsToolStripMenuItem
            // 
            this.viewBookDetailsToolStripMenuItem.Name = "viewBookDetailsToolStripMenuItem";
            this.viewBookDetailsToolStripMenuItem.Padding = new System.Windows.Forms.Padding(4);
            this.viewBookDetailsToolStripMenuItem.Size = new System.Drawing.Size(221, 28);
            this.viewBookDetailsToolStripMenuItem.Text = "View Book Details";
            this.viewBookDetailsToolStripMenuItem.Click += new System.EventHandler(this.viewBookDetailsToolStripMenuItem_Click);
            // 
            // editBookToolStripMenuItem
            // 
            this.editBookToolStripMenuItem.Name = "editBookToolStripMenuItem";
            this.editBookToolStripMenuItem.Padding = new System.Windows.Forms.Padding(4);
            this.editBookToolStripMenuItem.Size = new System.Drawing.Size(221, 28);
            this.editBookToolStripMenuItem.Text = "Edit Book";
            this.editBookToolStripMenuItem.Click += new System.EventHandler(this.editBookToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(210, 6);
            // 
            // deleteBookToolStripMenuItem
            // 
            this.deleteBookToolStripMenuItem.ForeColor = System.Drawing.Color.Red;
            this.deleteBookToolStripMenuItem.Name = "deleteBookToolStripMenuItem";
            this.deleteBookToolStripMenuItem.Padding = new System.Windows.Forms.Padding(4);
            this.deleteBookToolStripMenuItem.Size = new System.Drawing.Size(221, 28);
            this.deleteBookToolStripMenuItem.Text = "Delete Book";
            this.deleteBookToolStripMenuItem.Click += new System.EventHandler(this.deleteBookToolStripMenuItem_Click);
            // 
            // pnlFooter
            // 
            this.pnlFooter.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlFooter.Controls.Add(this.lblFooterIcon);
            this.pnlFooter.Controls.Add(this.lblFooterText);
            this.pnlFooter.Location = new System.Drawing.Point(12, 552);
            this.pnlFooter.Name = "pnlFooter";
            this.pnlFooter.Size = new System.Drawing.Size(1124, 34);
            this.pnlFooter.TabIndex = 6;
            // 
            // lblFooterIcon
            // 
            this.lblFooterIcon.Font = new System.Drawing.Font("Segoe MDL2 Assets", 10F);
            this.lblFooterIcon.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(166)))), ((int)(((byte)(154)))));
            this.lblFooterIcon.Location = new System.Drawing.Point(0, 5);
            this.lblFooterIcon.Name = "lblFooterIcon";
            this.lblFooterIcon.Size = new System.Drawing.Size(22, 22);
            this.lblFooterIcon.TabIndex = 0;
            this.lblFooterIcon.Text = "";
            this.lblFooterIcon.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblFooterText
            // 
            this.lblFooterText.AutoSize = true;
            this.lblFooterText.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.lblFooterText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(127)))), ((int)(((byte)(151)))));
            this.lblFooterText.Location = new System.Drawing.Point(27, 9);
            this.lblFooterText.Name = "lblFooterText";
            this.lblFooterText.Size = new System.Drawing.Size(298, 15);
            this.lblFooterText.TabIndex = 1;
            this.lblFooterText.Text = "Select a book row and right-click to open book actions.";
            // 
            // addBookCopyToolStripMenuItem
            // 
            this.addBookCopyToolStripMenuItem.Name = "addBookCopyToolStripMenuItem";
            this.addBookCopyToolStripMenuItem.Size = new System.Drawing.Size(213, 22);
            this.addBookCopyToolStripMenuItem.Text = "Add Book Copy";
            this.addBookCopyToolStripMenuItem.Click += new System.EventHandler(this.addBookCopyToolStripMenuItem_Click);
            // 
            // deleteBookCopyToolStripMenuItem
            // 
            this.deleteBookCopyToolStripMenuItem.ForeColor = System.Drawing.Color.Red;
            this.deleteBookCopyToolStripMenuItem.Name = "deleteBookCopyToolStripMenuItem";
            this.deleteBookCopyToolStripMenuItem.Size = new System.Drawing.Size(213, 22);
            this.deleteBookCopyToolStripMenuItem.Text = "Remove Available Copy";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(210, 6);
            // 
            // frmManageBooks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(245)))), ((int)(((byte)(249)))));
            this.ClientSize = new System.Drawing.Size(1180, 710);
            this.Controls.Add(this.pnlFooter);
            this.Controls.Add(this.dgvManageBooks);
            this.Controls.Add(this.pnlHeader);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmManageBooks";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manage Books";
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.pnlHeaderIcon.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvManageBooks)).EndInit();
            this.cmsBookActions.ResumeLayout(false);
            this.pnlFooter.ResumeLayout(false);
            this.pnlFooter.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlHeader;
        private Guna.UI2.WinForms.Guna2Button btnAddBook;
        private System.Windows.Forms.Panel pnlHeaderIcon;
        private System.Windows.Forms.Label lblHeaderIcon;
        private System.Windows.Forms.Label lblHeaderSubtitle;
        private System.Windows.Forms.Label lblHeaderTitle;
        private Guna.UI2.WinForms.Guna2DataGridView dgvManageBooks;
        private Guna.UI2.WinForms.Guna2ContextMenuStrip cmsBookActions;
        private System.Windows.Forms.ToolStripMenuItem viewBookDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editBookToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem deleteBookToolStripMenuItem;
        private System.Windows.Forms.Panel pnlFooter;
        private System.Windows.Forms.Label lblFooterIcon;
        private System.Windows.Forms.Label lblFooterText;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBookID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colISBN;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTitle;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAuthor;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCategory;
        private System.Windows.Forms.DataGridViewTextBoxColumn PublicationYear;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.ToolStripMenuItem addBookCopyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteBookCopyToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
    }
}
