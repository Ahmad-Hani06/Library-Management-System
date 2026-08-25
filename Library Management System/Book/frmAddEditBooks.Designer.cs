namespace Library_Management_System.Book
{
    partial class frmAddEditBooks
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
            this.pnlFormCard = new Guna.UI2.WinForms.Guna2Panel();
            this.lblBibliographicTitle = new System.Windows.Forms.Label();
            this.lblBibliographicSubtitle = new System.Windows.Forms.Label();
            this.lblInventoryTitle = new System.Windows.Forms.Label();
            this.pnlDivider = new System.Windows.Forms.Panel();
            this.lblBookId = new System.Windows.Forms.Label();
            this.txtBookID = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblISBN = new System.Windows.Forms.Label();
            this.txtISBN = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.txtTitle = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblAuthor = new System.Windows.Forms.Label();
            this.txtAuthor = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblCategory = new System.Windows.Forms.Label();
            this.cmbCategory = new Guna.UI2.WinForms.Guna2ComboBox();
            this.lblPublicationDate = new System.Windows.Forms.Label();
            this.lblNotes = new System.Windows.Forms.Label();
            this.txtNotes = new Guna.UI2.WinForms.Guna2TextBox();
            this.pnlRequiredHint = new System.Windows.Forms.Panel();
            this.lblRequiredHintIcon = new System.Windows.Forms.Label();
            this.lblRequiredHint = new System.Windows.Forms.Label();
            this.pnlActions = new System.Windows.Forms.Panel();
            this.btnCancel = new Guna.UI2.WinForms.Guna2Button();
            this.btnSave = new Guna.UI2.WinForms.Guna2Button();
            this.lblActionsHint = new System.Windows.Forms.Label();
            this.txtBoxPubYear = new Guna.UI2.WinForms.Guna2TextBox();
            this.pnlHeader.SuspendLayout();
            this.pnlHeaderIcon.SuspendLayout();
            this.pnlFormCard.SuspendLayout();
            this.pnlRequiredHint.SuspendLayout();
            this.pnlActions.SuspendLayout();
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
            this.lblHeaderIcon.Text = "\r\n";
            this.lblHeaderIcon.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblHeaderSubtitle
            // 
            this.lblHeaderSubtitle.AutoSize = true;
            this.lblHeaderSubtitle.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblHeaderSubtitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(184)))), ((int)(((byte)(209)))));
            this.lblHeaderSubtitle.Location = new System.Drawing.Point(31, 66);
            this.lblHeaderSubtitle.Name = "lblHeaderSubtitle";
            this.lblHeaderSubtitle.Size = new System.Drawing.Size(421, 17);
            this.lblHeaderSubtitle.TabIndex = 1;
            this.lblHeaderSubtitle.Text = "Create a catalog record or update the information of an existing book.";
            // 
            // lblHeaderTitle
            // 
            this.lblHeaderTitle.AutoSize = true;
            this.lblHeaderTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 20F, System.Drawing.FontStyle.Bold);
            this.lblHeaderTitle.ForeColor = System.Drawing.Color.White;
            this.lblHeaderTitle.Location = new System.Drawing.Point(27, 25);
            this.lblHeaderTitle.Name = "lblHeaderTitle";
            this.lblHeaderTitle.Size = new System.Drawing.Size(208, 37);
            this.lblHeaderTitle.TabIndex = 0;
            this.lblHeaderTitle.Text = "Add / Edit Book";
            // 
            // pnlFormCard
            // 
            this.pnlFormCard.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlFormCard.BackColor = System.Drawing.Color.White;
            this.pnlFormCard.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(228)))), ((int)(((byte)(238)))));
            this.pnlFormCard.BorderRadius = 14;
            this.pnlFormCard.BorderThickness = 1;
            this.pnlFormCard.Controls.Add(this.txtBoxPubYear);
            this.pnlFormCard.Controls.Add(this.lblBibliographicTitle);
            this.pnlFormCard.Controls.Add(this.lblBibliographicSubtitle);
            this.pnlFormCard.Controls.Add(this.lblInventoryTitle);
            this.pnlFormCard.Controls.Add(this.pnlDivider);
            this.pnlFormCard.Controls.Add(this.lblBookId);
            this.pnlFormCard.Controls.Add(this.txtBookID);
            this.pnlFormCard.Controls.Add(this.lblISBN);
            this.pnlFormCard.Controls.Add(this.txtISBN);
            this.pnlFormCard.Controls.Add(this.lblTitle);
            this.pnlFormCard.Controls.Add(this.txtTitle);
            this.pnlFormCard.Controls.Add(this.lblAuthor);
            this.pnlFormCard.Controls.Add(this.txtAuthor);
            this.pnlFormCard.Controls.Add(this.lblCategory);
            this.pnlFormCard.Controls.Add(this.cmbCategory);
            this.pnlFormCard.Controls.Add(this.lblPublicationDate);
            this.pnlFormCard.Controls.Add(this.lblNotes);
            this.pnlFormCard.Controls.Add(this.txtNotes);
            this.pnlFormCard.Controls.Add(this.pnlRequiredHint);
            this.pnlFormCard.Location = new System.Drawing.Point(28, 128);
            this.pnlFormCard.Name = "pnlFormCard";
            this.pnlFormCard.Size = new System.Drawing.Size(1044, 434);
            this.pnlFormCard.TabIndex = 1;
            // 
            // lblBibliographicTitle
            // 
            this.lblBibliographicTitle.AutoSize = true;
            this.lblBibliographicTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 13F, System.Drawing.FontStyle.Bold);
            this.lblBibliographicTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(33)))), ((int)(((byte)(61)))));
            this.lblBibliographicTitle.Location = new System.Drawing.Point(28, 22);
            this.lblBibliographicTitle.Name = "lblBibliographicTitle";
            this.lblBibliographicTitle.Size = new System.Drawing.Size(181, 25);
            this.lblBibliographicTitle.TabIndex = 0;
            this.lblBibliographicTitle.Text = "Bibliographic details";
            // 
            // lblBibliographicSubtitle
            // 
            this.lblBibliographicSubtitle.AutoSize = true;
            this.lblBibliographicSubtitle.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.lblBibliographicSubtitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(139)))), ((int)(((byte)(162)))));
            this.lblBibliographicSubtitle.Location = new System.Drawing.Point(30, 49);
            this.lblBibliographicSubtitle.Name = "lblBibliographicSubtitle";
            this.lblBibliographicSubtitle.Size = new System.Drawing.Size(285, 15);
            this.lblBibliographicSubtitle.TabIndex = 1;
            this.lblBibliographicSubtitle.Text = "Core information used to identify the catalog record.";
            // 
            // lblInventoryTitle
            // 
            this.lblInventoryTitle.AutoSize = true;
            this.lblInventoryTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 13F, System.Drawing.FontStyle.Bold);
            this.lblInventoryTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(33)))), ((int)(((byte)(61)))));
            this.lblInventoryTitle.Location = new System.Drawing.Point(551, 22);
            this.lblInventoryTitle.Name = "lblInventoryTitle";
            this.lblInventoryTitle.Size = new System.Drawing.Size(232, 25);
            this.lblInventoryTitle.TabIndex = 16;
            this.lblInventoryTitle.Text = "Publishing And Decription";
            // 
            // pnlDivider
            // 
            this.pnlDivider.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(236)))), ((int)(((byte)(244)))));
            this.pnlDivider.Location = new System.Drawing.Point(521, 22);
            this.pnlDivider.Name = "pnlDivider";
            this.pnlDivider.Size = new System.Drawing.Size(1, 452);
            this.pnlDivider.TabIndex = 15;
            // 
            // lblBookId
            // 
            this.lblBookId.AutoSize = true;
            this.lblBookId.Font = new System.Drawing.Font("Segoe UI Semibold", 8F, System.Drawing.FontStyle.Bold);
            this.lblBookId.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(80)))), ((int)(((byte)(103)))));
            this.lblBookId.Location = new System.Drawing.Point(30, 84);
            this.lblBookId.Name = "lblBookId";
            this.lblBookId.Size = new System.Drawing.Size(51, 13);
            this.lblBookId.TabIndex = 2;
            this.lblBookId.Text = "BOOK ID";
            // 
            // txtBookID
            // 
            this.txtBookID.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(221)))), ((int)(((byte)(233)))));
            this.txtBookID.BorderRadius = 7;
            this.txtBookID.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtBookID.DefaultText = "Auto-generated";
            this.txtBookID.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(249)))), ((int)(((byte)(252)))));
            this.txtBookID.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtBookID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(139)))), ((int)(((byte)(162)))));
            this.txtBookID.Location = new System.Drawing.Point(33, 101);
            this.txtBookID.Name = "txtBookID";
            this.txtBookID.PlaceholderText = "";
            this.txtBookID.ReadOnly = true;
            this.txtBookID.SelectedText = "";
            this.txtBookID.Size = new System.Drawing.Size(214, 36);
            this.txtBookID.TabIndex = 3;
            // 
            // lblISBN
            // 
            this.lblISBN.AutoSize = true;
            this.lblISBN.Font = new System.Drawing.Font("Segoe UI Semibold", 8F, System.Drawing.FontStyle.Bold);
            this.lblISBN.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(80)))), ((int)(((byte)(103)))));
            this.lblISBN.Location = new System.Drawing.Point(265, 84);
            this.lblISBN.Name = "lblISBN";
            this.lblISBN.Size = new System.Drawing.Size(39, 13);
            this.lblISBN.TabIndex = 4;
            this.lblISBN.Text = "ISBN *";
            // 
            // txtISBN
            // 
            this.txtISBN.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(214)))), ((int)(((byte)(227)))));
            this.txtISBN.BorderRadius = 7;
            this.txtISBN.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtISBN.DefaultText = "";
            this.txtISBN.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(166)))), ((int)(((byte)(154)))));
            this.txtISBN.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtISBN.Location = new System.Drawing.Point(268, 101);
            this.txtISBN.Name = "txtISBN";
            this.txtISBN.PlaceholderText = "978-...";
            this.txtISBN.SelectedText = "";
            this.txtISBN.Size = new System.Drawing.Size(220, 36);
            this.txtISBN.TabIndex = 5;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 8F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(80)))), ((int)(((byte)(103)))));
            this.lblTitle.Location = new System.Drawing.Point(30, 153);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(41, 13);
            this.lblTitle.TabIndex = 6;
            this.lblTitle.Text = "TITLE *";
            // 
            // txtTitle
            // 
            this.txtTitle.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(214)))), ((int)(((byte)(227)))));
            this.txtTitle.BorderRadius = 7;
            this.txtTitle.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTitle.DefaultText = "";
            this.txtTitle.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(166)))), ((int)(((byte)(154)))));
            this.txtTitle.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtTitle.Location = new System.Drawing.Point(33, 170);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.PlaceholderText = "Enter the full book title";
            this.txtTitle.SelectedText = "";
            this.txtTitle.Size = new System.Drawing.Size(455, 36);
            this.txtTitle.TabIndex = 7;
            // 
            // lblAuthor
            // 
            this.lblAuthor.AutoSize = true;
            this.lblAuthor.Font = new System.Drawing.Font("Segoe UI Semibold", 8F, System.Drawing.FontStyle.Bold);
            this.lblAuthor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(80)))), ((int)(((byte)(103)))));
            this.lblAuthor.Location = new System.Drawing.Point(30, 222);
            this.lblAuthor.Name = "lblAuthor";
            this.lblAuthor.Size = new System.Drawing.Size(59, 13);
            this.lblAuthor.TabIndex = 8;
            this.lblAuthor.Text = "AUTHOR *";
            // 
            // txtAuthor
            // 
            this.txtAuthor.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(214)))), ((int)(((byte)(227)))));
            this.txtAuthor.BorderRadius = 7;
            this.txtAuthor.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtAuthor.DefaultText = "";
            this.txtAuthor.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(166)))), ((int)(((byte)(154)))));
            this.txtAuthor.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtAuthor.Location = new System.Drawing.Point(33, 239);
            this.txtAuthor.Name = "txtAuthor";
            this.txtAuthor.PlaceholderText = "Author name";
            this.txtAuthor.SelectedText = "";
            this.txtAuthor.Size = new System.Drawing.Size(455, 36);
            this.txtAuthor.TabIndex = 9;
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Font = new System.Drawing.Font("Segoe UI Semibold", 8F, System.Drawing.FontStyle.Bold);
            this.lblCategory.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(80)))), ((int)(((byte)(103)))));
            this.lblCategory.Location = new System.Drawing.Point(30, 291);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(69, 13);
            this.lblCategory.TabIndex = 10;
            this.lblCategory.Text = "CATEGORY *";
            // 
            // cmbCategory
            // 
            this.cmbCategory.BackColor = System.Drawing.Color.Transparent;
            this.cmbCategory.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(214)))), ((int)(((byte)(227)))));
            this.cmbCategory.BorderRadius = 7;
            this.cmbCategory.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCategory.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(166)))), ((int)(((byte)(154)))));
            this.cmbCategory.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(166)))), ((int)(((byte)(154)))));
            this.cmbCategory.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cmbCategory.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(48)))), ((int)(((byte)(73)))));
            this.cmbCategory.ItemHeight = 30;
            this.cmbCategory.Items.AddRange(new object[] {
            "Science",
            "History",
            "Technology",
            "Biography",
            "Children"});
            this.cmbCategory.Location = new System.Drawing.Point(33, 308);
            this.cmbCategory.Name = "cmbCategory";
            this.cmbCategory.Size = new System.Drawing.Size(455, 36);
            this.cmbCategory.TabIndex = 11;
            // 
            // lblPublicationDate
            // 
            this.lblPublicationDate.AutoSize = true;
            this.lblPublicationDate.Font = new System.Drawing.Font("Segoe UI Semibold", 8F, System.Drawing.FontStyle.Bold);
            this.lblPublicationDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(80)))), ((int)(((byte)(103)))));
            this.lblPublicationDate.Location = new System.Drawing.Point(542, 85);
            this.lblPublicationDate.Name = "lblPublicationDate";
            this.lblPublicationDate.Size = new System.Drawing.Size(103, 13);
            this.lblPublicationDate.TabIndex = 18;
            this.lblPublicationDate.Text = "PUBLICATION YEAR";
            // 
            // lblNotes
            // 
            this.lblNotes.AutoSize = true;
            this.lblNotes.Font = new System.Drawing.Font("Segoe UI Semibold", 8F, System.Drawing.FontStyle.Bold);
            this.lblNotes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(80)))), ((int)(((byte)(103)))));
            this.lblNotes.Location = new System.Drawing.Point(542, 153);
            this.lblNotes.Name = "lblNotes";
            this.lblNotes.Size = new System.Drawing.Size(75, 13);
            this.lblNotes.TabIndex = 28;
            this.lblNotes.Text = "DESCRIPTION";
            // 
            // txtNotes
            // 
            this.txtNotes.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(214)))), ((int)(((byte)(227)))));
            this.txtNotes.BorderRadius = 7;
            this.txtNotes.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNotes.DefaultText = "";
            this.txtNotes.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(166)))), ((int)(((byte)(154)))));
            this.txtNotes.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtNotes.Location = new System.Drawing.Point(545, 170);
            this.txtNotes.Multiline = true;
            this.txtNotes.Name = "txtNotes";
            this.txtNotes.PlaceholderText = "Optional catalog Description";
            this.txtNotes.SelectedText = "";
            this.txtNotes.Size = new System.Drawing.Size(455, 105);
            this.txtNotes.TabIndex = 29;
            // 
            // pnlRequiredHint
            // 
            this.pnlRequiredHint.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.pnlRequiredHint.Controls.Add(this.lblRequiredHintIcon);
            this.pnlRequiredHint.Controls.Add(this.lblRequiredHint);
            this.pnlRequiredHint.Location = new System.Drawing.Point(33, 372);
            this.pnlRequiredHint.Name = "pnlRequiredHint";
            this.pnlRequiredHint.Size = new System.Drawing.Size(978, 42);
            this.pnlRequiredHint.TabIndex = 30;
            // 
            // lblRequiredHintIcon
            // 
            this.lblRequiredHintIcon.Font = new System.Drawing.Font("Segoe MDL2 Assets", 11F);
            this.lblRequiredHintIcon.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(112)))), ((int)(((byte)(170)))));
            this.lblRequiredHintIcon.Location = new System.Drawing.Point(13, 9);
            this.lblRequiredHintIcon.Name = "lblRequiredHintIcon";
            this.lblRequiredHintIcon.Size = new System.Drawing.Size(24, 24);
            this.lblRequiredHintIcon.TabIndex = 0;
            this.lblRequiredHintIcon.Text = "";
            this.lblRequiredHintIcon.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblRequiredHint
            // 
            this.lblRequiredHint.AutoSize = true;
            this.lblRequiredHint.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.lblRequiredHint.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(112)))), ((int)(((byte)(170)))));
            this.lblRequiredHint.Location = new System.Drawing.Point(43, 13);
            this.lblRequiredHint.Name = "lblRequiredHint";
            this.lblRequiredHint.Size = new System.Drawing.Size(249, 15);
            this.lblRequiredHint.TabIndex = 1;
            this.lblRequiredHint.Text = "Fields marked with an asterisk (*) are required.";
            // 
            // pnlActions
            // 
            this.pnlActions.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlActions.Controls.Add(this.btnCancel);
            this.pnlActions.Controls.Add(this.btnSave);
            this.pnlActions.Controls.Add(this.lblActionsHint);
            this.pnlActions.Location = new System.Drawing.Point(26, 586);
            this.pnlActions.Name = "pnlActions";
            this.pnlActions.Size = new System.Drawing.Size(1044, 58);
            this.pnlActions.TabIndex = 2;
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(214)))), ((int)(((byte)(227)))));
            this.btnCancel.BorderRadius = 8;
            this.btnCancel.BorderThickness = 1;
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.FillColor = System.Drawing.Color.White;
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.btnCancel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(80)))), ((int)(((byte)(103)))));
            this.btnCancel.Location = new System.Drawing.Point(733, 6);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(140, 42);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "Cancel";
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.BorderRadius = 8;
            this.btnSave.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(166)))), ((int)(((byte)(154)))));
            this.btnSave.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(893, 6);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(148, 42);
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "Save Book";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lblActionsHint
            // 
            this.lblActionsHint.AutoSize = true;
            this.lblActionsHint.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.lblActionsHint.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(139)))), ((int)(((byte)(162)))));
            this.lblActionsHint.Location = new System.Drawing.Point(2, 18);
            this.lblActionsHint.Name = "lblActionsHint";
            this.lblActionsHint.Size = new System.Drawing.Size(249, 15);
            this.lblActionsHint.TabIndex = 0;
            this.lblActionsHint.Text = "Review the catalog information before saving.";
            // 
            // txtBoxPubYear
            // 
            this.txtBoxPubYear.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(214)))), ((int)(((byte)(227)))));
            this.txtBoxPubYear.BorderRadius = 7;
            this.txtBoxPubYear.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtBoxPubYear.DefaultText = "";
            this.txtBoxPubYear.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(166)))), ((int)(((byte)(154)))));
            this.txtBoxPubYear.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtBoxPubYear.Location = new System.Drawing.Point(545, 101);
            this.txtBoxPubYear.Name = "txtBoxPubYear";
            this.txtBoxPubYear.PlaceholderText = "2026";
            this.txtBoxPubYear.SelectedText = "";
            this.txtBoxPubYear.Size = new System.Drawing.Size(220, 36);
            this.txtBoxPubYear.TabIndex = 31;
            // 
            // frmAddEditBooks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(245)))), ((int)(((byte)(249)))));
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(1100, 658);
            this.Controls.Add(this.pnlActions);
            this.Controls.Add(this.pnlFormCard);
            this.Controls.Add(this.pnlHeader);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmAddEditBooks";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add / Edit Book";
            this.Load += new System.EventHandler(this.frmAddEditBooks_Load);
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.pnlHeaderIcon.ResumeLayout(false);
            this.pnlFormCard.ResumeLayout(false);
            this.pnlFormCard.PerformLayout();
            this.pnlRequiredHint.ResumeLayout(false);
            this.pnlRequiredHint.PerformLayout();
            this.pnlActions.ResumeLayout(false);
            this.pnlActions.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Panel pnlHeaderIcon;
        private System.Windows.Forms.Label lblHeaderIcon;
        private System.Windows.Forms.Label lblHeaderSubtitle;
        private System.Windows.Forms.Label lblHeaderTitle;
        private Guna.UI2.WinForms.Guna2Panel pnlFormCard;
        private System.Windows.Forms.Label lblBibliographicTitle;
        private System.Windows.Forms.Label lblBibliographicSubtitle;
        private System.Windows.Forms.Label lblInventoryTitle;
        private System.Windows.Forms.Panel pnlDivider;
        private System.Windows.Forms.Label lblBookId;
        private Guna.UI2.WinForms.Guna2TextBox txtBookID;
        private System.Windows.Forms.Label lblISBN;
        private Guna.UI2.WinForms.Guna2TextBox txtISBN;
        private System.Windows.Forms.Label lblTitle;
        private Guna.UI2.WinForms.Guna2TextBox txtTitle;
        private System.Windows.Forms.Label lblAuthor;
        private Guna.UI2.WinForms.Guna2TextBox txtAuthor;
        private System.Windows.Forms.Label lblCategory;
        private Guna.UI2.WinForms.Guna2ComboBox cmbCategory;
        private System.Windows.Forms.Label lblPublicationDate;
        private System.Windows.Forms.Label lblNotes;
        private Guna.UI2.WinForms.Guna2TextBox txtNotes;
        private System.Windows.Forms.Panel pnlRequiredHint;
        private System.Windows.Forms.Label lblRequiredHintIcon;
        private System.Windows.Forms.Label lblRequiredHint;
        private System.Windows.Forms.Panel pnlActions;
        private Guna.UI2.WinForms.Guna2Button btnCancel;
        private Guna.UI2.WinForms.Guna2Button btnSave;
        private System.Windows.Forms.Label lblActionsHint;
        private Guna.UI2.WinForms.Guna2TextBox txtBoxPubYear;
    }
}
