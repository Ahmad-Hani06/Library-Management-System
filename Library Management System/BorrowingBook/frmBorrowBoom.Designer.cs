namespace Library_Management_System.BorrowingBook
{
    partial class frmBorrowBoom
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
            this.lblHeaderMark = new System.Windows.Forms.Label();
            this.lblHeaderSubtitle = new System.Windows.Forms.Label();
            this.lblHeaderTitle = new System.Windows.Forms.Label();
            this.pnlContent = new System.Windows.Forms.Panel();
            this.pnlBorrowInfoCard = new Guna.UI2.WinForms.Guna2Panel();
            this.btnConfirmBorrow = new Guna.UI2.WinForms.Guna2Button();
            this.btnReset = new Guna.UI2.WinForms.Guna2Button();
            this.txtBorrowNotes = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblNotesCaption = new System.Windows.Forms.Label();
            this.pnlFee = new Guna.UI2.WinForms.Guna2Panel();
            this.lblFeeValue = new System.Windows.Forms.Label();
            this.lblFeeCaption = new System.Windows.Forms.Label();
            this.dtpDueDate = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.lblDueDateCaption = new System.Windows.Forms.Label();
            this.dtpBorrowDate = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.lblBorrowDateCaption = new System.Windows.Forms.Label();
            this.lblBorrowInfoSubtitle = new System.Windows.Forms.Label();
            this.lblBorrowInfoTitle = new System.Windows.Forms.Label();
            this.lblBorrowStep = new System.Windows.Forms.Label();
            this.pnlBookInfoHost = new Guna.UI2.WinForms.Guna2Panel();
            this.pnlBookSearchCard = new Guna.UI2.WinForms.Guna2Panel();
            this.btnClearBook = new Guna.UI2.WinForms.Guna2Button();
            this.btnFindBook = new Guna.UI2.WinForms.Guna2Button();
            this.txtBookSearchValue = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblBookSearchHint = new System.Windows.Forms.Label();
            this.lblBookSearchTitle = new System.Windows.Forms.Label();
            this.lblBookStep = new System.Windows.Forms.Label();
            this.lblBookSearchIcon = new System.Windows.Forms.Label();
            this.pnlMemberInfoHost = new Guna.UI2.WinForms.Guna2Panel();
            this.pnlMemberSearchCard = new Guna.UI2.WinForms.Guna2Panel();
            this.btnClearMember = new Guna.UI2.WinForms.Guna2Button();
            this.btnFindMember = new Guna.UI2.WinForms.Guna2Button();
            this.txtMemberID = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblMemberSearchHint = new System.Windows.Forms.Label();
            this.lblMemberSearchTitle = new System.Windows.Forms.Label();
            this.lblMemberStep = new System.Windows.Forms.Label();
            this.lblMemberSearchIcon = new System.Windows.Forms.Label();
            this.ctrlBookInfo1 = new Library_Management_System.Book.ctrlBookInfo();
            this.ctrlMemberInfo1 = new Library_Management_System.Member.ctrlMemberInfo();
            this.pnlHeader.SuspendLayout();
            this.pnlContent.SuspendLayout();
            this.pnlBorrowInfoCard.SuspendLayout();
            this.pnlFee.SuspendLayout();
            this.pnlBookInfoHost.SuspendLayout();
            this.pnlBookSearchCard.SuspendLayout();
            this.pnlMemberInfoHost.SuspendLayout();
            this.pnlMemberSearchCard.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(33)))), ((int)(((byte)(61)))));
            this.pnlHeader.Controls.Add(this.lblHeaderMark);
            this.pnlHeader.Controls.Add(this.lblHeaderSubtitle);
            this.pnlHeader.Controls.Add(this.lblHeaderTitle);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(1184, 104);
            this.pnlHeader.TabIndex = 0;
            // 
            // lblHeaderMark
            // 
            this.lblHeaderMark.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblHeaderMark.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(63)))), ((int)(((byte)(105)))));
            this.lblHeaderMark.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold);
            this.lblHeaderMark.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(209)))), ((int)(((byte)(197)))));
            this.lblHeaderMark.Location = new System.Drawing.Point(1094, 23);
            this.lblHeaderMark.Name = "lblHeaderMark";
            this.lblHeaderMark.Size = new System.Drawing.Size(58, 58);
            this.lblHeaderMark.TabIndex = 2;
            this.lblHeaderMark.Text = "B";
            this.lblHeaderMark.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblHeaderSubtitle
            // 
            this.lblHeaderSubtitle.AutoSize = true;
            this.lblHeaderSubtitle.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblHeaderSubtitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(184)))), ((int)(((byte)(209)))));
            this.lblHeaderSubtitle.Location = new System.Drawing.Point(31, 64);
            this.lblHeaderSubtitle.Name = "lblHeaderSubtitle";
            this.lblHeaderSubtitle.Size = new System.Drawing.Size(399, 17);
            this.lblHeaderSubtitle.TabIndex = 1;
            this.lblHeaderSubtitle.Text = "Select a member and a book, then complete the borrowing details.";
            // 
            // lblHeaderTitle
            // 
            this.lblHeaderTitle.AutoSize = true;
            this.lblHeaderTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 20F, System.Drawing.FontStyle.Bold);
            this.lblHeaderTitle.ForeColor = System.Drawing.Color.White;
            this.lblHeaderTitle.Location = new System.Drawing.Point(27, 23);
            this.lblHeaderTitle.Name = "lblHeaderTitle";
            this.lblHeaderTitle.Size = new System.Drawing.Size(195, 37);
            this.lblHeaderTitle.TabIndex = 0;
            this.lblHeaderTitle.Text = "Borrow a Book";
            // 
            // pnlContent
            // 
            this.pnlContent.AutoScroll = true;
            this.pnlContent.AutoScrollMinSize = new System.Drawing.Size(0, 1242);
            this.pnlContent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(245)))), ((int)(((byte)(249)))));
            this.pnlContent.Controls.Add(this.pnlBorrowInfoCard);
            this.pnlContent.Controls.Add(this.pnlBookInfoHost);
            this.pnlContent.Controls.Add(this.pnlBookSearchCard);
            this.pnlContent.Controls.Add(this.pnlMemberInfoHost);
            this.pnlContent.Controls.Add(this.pnlMemberSearchCard);
            this.pnlContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContent.Location = new System.Drawing.Point(0, 104);
            this.pnlContent.Name = "pnlContent";
            this.pnlContent.Size = new System.Drawing.Size(1184, 645);
            this.pnlContent.TabIndex = 1;
            // 
            // pnlBorrowInfoCard
            // 
            this.pnlBorrowInfoCard.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlBorrowInfoCard.BackColor = System.Drawing.Color.White;
            this.pnlBorrowInfoCard.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(228)))), ((int)(((byte)(238)))));
            this.pnlBorrowInfoCard.BorderRadius = 14;
            this.pnlBorrowInfoCard.BorderThickness = 1;
            this.pnlBorrowInfoCard.Controls.Add(this.btnConfirmBorrow);
            this.pnlBorrowInfoCard.Controls.Add(this.btnReset);
            this.pnlBorrowInfoCard.Controls.Add(this.txtBorrowNotes);
            this.pnlBorrowInfoCard.Controls.Add(this.lblNotesCaption);
            this.pnlBorrowInfoCard.Controls.Add(this.pnlFee);
            this.pnlBorrowInfoCard.Controls.Add(this.dtpDueDate);
            this.pnlBorrowInfoCard.Controls.Add(this.lblDueDateCaption);
            this.pnlBorrowInfoCard.Controls.Add(this.dtpBorrowDate);
            this.pnlBorrowInfoCard.Controls.Add(this.lblBorrowDateCaption);
            this.pnlBorrowInfoCard.Controls.Add(this.lblBorrowInfoSubtitle);
            this.pnlBorrowInfoCard.Controls.Add(this.lblBorrowInfoTitle);
            this.pnlBorrowInfoCard.Controls.Add(this.lblBorrowStep);
            this.pnlBorrowInfoCard.Location = new System.Drawing.Point(30, 974);
            this.pnlBorrowInfoCard.Name = "pnlBorrowInfoCard";
            this.pnlBorrowInfoCard.Size = new System.Drawing.Size(1107, 238);
            this.pnlBorrowInfoCard.TabIndex = 4;
            // 
            // btnConfirmBorrow
            // 
            this.btnConfirmBorrow.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnConfirmBorrow.BorderRadius = 8;
            this.btnConfirmBorrow.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(166)))), ((int)(((byte)(154)))));
            this.btnConfirmBorrow.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.btnConfirmBorrow.ForeColor = System.Drawing.Color.White;
            this.btnConfirmBorrow.Location = new System.Drawing.Point(876, 170);
            this.btnConfirmBorrow.Name = "btnConfirmBorrow";
            this.btnConfirmBorrow.Size = new System.Drawing.Size(198, 44);
            this.btnConfirmBorrow.TabIndex = 7;
            this.btnConfirmBorrow.Text = "Confirm Borrowing";
            this.btnConfirmBorrow.Click += new System.EventHandler(this.btnConfirmBorrow_Click);
            // 
            // btnReset
            // 
            this.btnReset.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnReset.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(214)))), ((int)(((byte)(227)))));
            this.btnReset.BorderRadius = 8;
            this.btnReset.BorderThickness = 1;
            this.btnReset.FillColor = System.Drawing.Color.White;
            this.btnReset.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.btnReset.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(80)))), ((int)(((byte)(103)))));
            this.btnReset.Location = new System.Drawing.Point(738, 170);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(126, 44);
            this.btnReset.TabIndex = 6;
            this.btnReset.Text = "Reset";
            // 
            // txtBorrowNotes
            // 
            this.txtBorrowNotes.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBorrowNotes.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(214)))), ((int)(((byte)(227)))));
            this.txtBorrowNotes.BorderRadius = 8;
            this.txtBorrowNotes.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtBorrowNotes.DefaultText = "";
            this.txtBorrowNotes.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(166)))), ((int)(((byte)(154)))));
            this.txtBorrowNotes.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtBorrowNotes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(48)))), ((int)(((byte)(73)))));
            this.txtBorrowNotes.Location = new System.Drawing.Point(716, 86);
            this.txtBorrowNotes.Multiline = true;
            this.txtBorrowNotes.Name = "txtBorrowNotes";
            this.txtBorrowNotes.PlaceholderText = "Optional notes about this borrowing";
            this.txtBorrowNotes.SelectedText = "";
            this.txtBorrowNotes.Size = new System.Drawing.Size(358, 66);
            this.txtBorrowNotes.TabIndex = 5;
            // 
            // lblNotesCaption
            // 
            this.lblNotesCaption.AutoSize = true;
            this.lblNotesCaption.Font = new System.Drawing.Font("Segoe UI Semibold", 8.5F, System.Drawing.FontStyle.Bold);
            this.lblNotesCaption.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(80)))), ((int)(((byte)(103)))));
            this.lblNotesCaption.Location = new System.Drawing.Point(713, 65);
            this.lblNotesCaption.Name = "lblNotesCaption";
            this.lblNotesCaption.Size = new System.Drawing.Size(38, 15);
            this.lblNotesCaption.TabIndex = 10;
            this.lblNotesCaption.Text = "Notes";
            // 
            // pnlFee
            // 
            this.pnlFee.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(250)))), ((int)(((byte)(248)))));
            this.pnlFee.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(228)))), ((int)(((byte)(221)))));
            this.pnlFee.BorderRadius = 10;
            this.pnlFee.BorderThickness = 1;
            this.pnlFee.Controls.Add(this.lblFeeValue);
            this.pnlFee.Controls.Add(this.lblFeeCaption);
            this.pnlFee.Location = new System.Drawing.Point(502, 65);
            this.pnlFee.Name = "pnlFee";
            this.pnlFee.Size = new System.Drawing.Size(190, 87);
            this.pnlFee.TabIndex = 4;
            // 
            // lblFeeValue
            // 
            this.lblFeeValue.Font = new System.Drawing.Font("Segoe UI Semibold", 21F, System.Drawing.FontStyle.Bold);
            this.lblFeeValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(133)))), ((int)(((byte)(123)))));
            this.lblFeeValue.Location = new System.Drawing.Point(13, 31);
            this.lblFeeValue.Name = "lblFeeValue";
            this.lblFeeValue.Size = new System.Drawing.Size(164, 43);
            this.lblFeeValue.TabIndex = 1;
            this.lblFeeValue.Text = "3.00";
            this.lblFeeValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblFeeCaption
            // 
            this.lblFeeCaption.Font = new System.Drawing.Font("Segoe UI Semibold", 8F, System.Drawing.FontStyle.Bold);
            this.lblFeeCaption.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(117)))), ((int)(((byte)(111)))));
            this.lblFeeCaption.Location = new System.Drawing.Point(13, 11);
            this.lblFeeCaption.Name = "lblFeeCaption";
            this.lblFeeCaption.Size = new System.Drawing.Size(164, 18);
            this.lblFeeCaption.TabIndex = 0;
            this.lblFeeCaption.Text = "BORROWING FEE";
            this.lblFeeCaption.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dtpDueDate
            // 
            this.dtpDueDate.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(214)))), ((int)(((byte)(227)))));
            this.dtpDueDate.BorderRadius = 8;
            this.dtpDueDate.BorderThickness = 1;
            this.dtpDueDate.Checked = true;
            this.dtpDueDate.Enabled = false;
            this.dtpDueDate.FillColor = System.Drawing.Color.White;
            this.dtpDueDate.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtpDueDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(48)))), ((int)(((byte)(73)))));
            this.dtpDueDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDueDate.Location = new System.Drawing.Point(266, 86);
            this.dtpDueDate.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpDueDate.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpDueDate.Name = "dtpDueDate";
            this.dtpDueDate.Size = new System.Drawing.Size(214, 42);
            this.dtpDueDate.TabIndex = 3;
            this.dtpDueDate.Value = new System.DateTime(2026, 8, 17, 12, 24, 24, 330);
            // 
            // lblDueDateCaption
            // 
            this.lblDueDateCaption.AutoSize = true;
            this.lblDueDateCaption.Font = new System.Drawing.Font("Segoe UI Semibold", 8.5F, System.Drawing.FontStyle.Bold);
            this.lblDueDateCaption.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(80)))), ((int)(((byte)(103)))));
            this.lblDueDateCaption.Location = new System.Drawing.Point(263, 65);
            this.lblDueDateCaption.Name = "lblDueDateCaption";
            this.lblDueDateCaption.Size = new System.Drawing.Size(57, 15);
            this.lblDueDateCaption.TabIndex = 7;
            this.lblDueDateCaption.Text = "Due Date";
            // 
            // dtpBorrowDate
            // 
            this.dtpBorrowDate.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(214)))), ((int)(((byte)(227)))));
            this.dtpBorrowDate.BorderRadius = 8;
            this.dtpBorrowDate.BorderThickness = 1;
            this.dtpBorrowDate.Checked = true;
            this.dtpBorrowDate.Enabled = false;
            this.dtpBorrowDate.FillColor = System.Drawing.Color.White;
            this.dtpBorrowDate.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtpBorrowDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(48)))), ((int)(((byte)(73)))));
            this.dtpBorrowDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpBorrowDate.Location = new System.Drawing.Point(28, 86);
            this.dtpBorrowDate.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpBorrowDate.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpBorrowDate.Name = "dtpBorrowDate";
            this.dtpBorrowDate.Size = new System.Drawing.Size(214, 42);
            this.dtpBorrowDate.TabIndex = 2;
            this.dtpBorrowDate.Value = new System.DateTime(2026, 8, 17, 12, 24, 24, 381);
            // 
            // lblBorrowDateCaption
            // 
            this.lblBorrowDateCaption.AutoSize = true;
            this.lblBorrowDateCaption.Font = new System.Drawing.Font("Segoe UI Semibold", 8.5F, System.Drawing.FontStyle.Bold);
            this.lblBorrowDateCaption.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(80)))), ((int)(((byte)(103)))));
            this.lblBorrowDateCaption.Location = new System.Drawing.Point(25, 65);
            this.lblBorrowDateCaption.Name = "lblBorrowDateCaption";
            this.lblBorrowDateCaption.Size = new System.Drawing.Size(73, 15);
            this.lblBorrowDateCaption.TabIndex = 5;
            this.lblBorrowDateCaption.Text = "Borrow Date";
            // 
            // lblBorrowInfoSubtitle
            // 
            this.lblBorrowInfoSubtitle.AutoSize = true;
            this.lblBorrowInfoSubtitle.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.lblBorrowInfoSubtitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(139)))), ((int)(((byte)(162)))));
            this.lblBorrowInfoSubtitle.Location = new System.Drawing.Point(205, 36);
            this.lblBorrowInfoSubtitle.Name = "lblBorrowInfoSubtitle";
            this.lblBorrowInfoSubtitle.Size = new System.Drawing.Size(268, 15);
            this.lblBorrowInfoSubtitle.TabIndex = 3;
            this.lblBorrowInfoSubtitle.Text = "Set the borrowing period and review the fixed fee.";
            // 
            // lblBorrowInfoTitle
            // 
            this.lblBorrowInfoTitle.AutoSize = true;
            this.lblBorrowInfoTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 13F, System.Drawing.FontStyle.Bold);
            this.lblBorrowInfoTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(33)))), ((int)(((byte)(61)))));
            this.lblBorrowInfoTitle.Location = new System.Drawing.Point(82, 29);
            this.lblBorrowInfoTitle.Name = "lblBorrowInfoTitle";
            this.lblBorrowInfoTitle.Size = new System.Drawing.Size(114, 25);
            this.lblBorrowInfoTitle.TabIndex = 1;
            this.lblBorrowInfoTitle.Text = "Loan Details";
            // 
            // lblBorrowStep
            // 
            this.lblBorrowStep.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(250)))), ((int)(((byte)(248)))));
            this.lblBorrowStep.Font = new System.Drawing.Font("Segoe UI Semibold", 8F, System.Drawing.FontStyle.Bold);
            this.lblBorrowStep.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(133)))), ((int)(((byte)(123)))));
            this.lblBorrowStep.Location = new System.Drawing.Point(24, 24);
            this.lblBorrowStep.Name = "lblBorrowStep";
            this.lblBorrowStep.Size = new System.Drawing.Size(46, 34);
            this.lblBorrowStep.TabIndex = 0;
            this.lblBorrowStep.Text = "03";
            this.lblBorrowStep.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlBookInfoHost
            // 
            this.pnlBookInfoHost.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlBookInfoHost.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(228)))), ((int)(((byte)(238)))));
            this.pnlBookInfoHost.BorderRadius = 12;
            this.pnlBookInfoHost.BorderThickness = 1;
            this.pnlBookInfoHost.Controls.Add(this.ctrlBookInfo1);
            this.pnlBookInfoHost.Location = new System.Drawing.Point(30, 518);
            this.pnlBookInfoHost.Name = "pnlBookInfoHost";
            this.pnlBookInfoHost.Padding = new System.Windows.Forms.Padding(1);
            this.pnlBookInfoHost.Size = new System.Drawing.Size(1107, 432);
            this.pnlBookInfoHost.TabIndex = 3;
            // 
            // pnlBookSearchCard
            // 
            this.pnlBookSearchCard.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlBookSearchCard.BackColor = System.Drawing.Color.White;
            this.pnlBookSearchCard.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(228)))), ((int)(((byte)(238)))));
            this.pnlBookSearchCard.BorderRadius = 12;
            this.pnlBookSearchCard.BorderThickness = 1;
            this.pnlBookSearchCard.Controls.Add(this.btnClearBook);
            this.pnlBookSearchCard.Controls.Add(this.btnFindBook);
            this.pnlBookSearchCard.Controls.Add(this.txtBookSearchValue);
            this.pnlBookSearchCard.Controls.Add(this.lblBookSearchHint);
            this.pnlBookSearchCard.Controls.Add(this.lblBookSearchTitle);
            this.pnlBookSearchCard.Controls.Add(this.lblBookStep);
            this.pnlBookSearchCard.Controls.Add(this.lblBookSearchIcon);
            this.pnlBookSearchCard.Location = new System.Drawing.Point(30, 390);
            this.pnlBookSearchCard.Name = "pnlBookSearchCard";
            this.pnlBookSearchCard.Size = new System.Drawing.Size(1107, 112);
            this.pnlBookSearchCard.TabIndex = 2;
            // 
            // btnClearBook
            // 
            this.btnClearBook.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClearBook.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(214)))), ((int)(((byte)(227)))));
            this.btnClearBook.BorderRadius = 8;
            this.btnClearBook.BorderThickness = 1;
            this.btnClearBook.FillColor = System.Drawing.Color.White;
            this.btnClearBook.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.btnClearBook.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(80)))), ((int)(((byte)(103)))));
            this.btnClearBook.Location = new System.Drawing.Point(738, 45);
            this.btnClearBook.Name = "btnClearBook";
            this.btnClearBook.Size = new System.Drawing.Size(118, 38);
            this.btnClearBook.TabIndex = 4;
            this.btnClearBook.Text = "Clear";
            // 
            // btnFindBook
            // 
            this.btnFindBook.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFindBook.BorderRadius = 8;
            this.btnFindBook.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(166)))), ((int)(((byte)(154)))));
            this.btnFindBook.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.btnFindBook.ForeColor = System.Drawing.Color.White;
            this.btnFindBook.Location = new System.Drawing.Point(606, 45);
            this.btnFindBook.Name = "btnFindBook";
            this.btnFindBook.Size = new System.Drawing.Size(120, 38);
            this.btnFindBook.TabIndex = 3;
            this.btnFindBook.Text = "Find Book";
            this.btnFindBook.Click += new System.EventHandler(this.btnFindBook_Click);
            // 
            // txtBookSearchValue
            // 
            this.txtBookSearchValue.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBookSearchValue.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(214)))), ((int)(((byte)(227)))));
            this.txtBookSearchValue.BorderRadius = 8;
            this.txtBookSearchValue.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtBookSearchValue.DefaultText = "";
            this.txtBookSearchValue.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(166)))), ((int)(((byte)(154)))));
            this.txtBookSearchValue.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtBookSearchValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(48)))), ((int)(((byte)(73)))));
            this.txtBookSearchValue.Location = new System.Drawing.Point(227, 44);
            this.txtBookSearchValue.Name = "txtBookSearchValue";
            this.txtBookSearchValue.PlaceholderText = "Enter the value to search for";
            this.txtBookSearchValue.SelectedText = "";
            this.txtBookSearchValue.Size = new System.Drawing.Size(358, 38);
            this.txtBookSearchValue.TabIndex = 2;
            // 
            // lblBookSearchHint
            // 
            this.lblBookSearchHint.AutoSize = true;
            this.lblBookSearchHint.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.lblBookSearchHint.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(139)))), ((int)(((byte)(162)))));
            this.lblBookSearchHint.Location = new System.Drawing.Point(90, 66);
            this.lblBookSearchHint.Name = "lblBookSearchHint";
            this.lblBookSearchHint.Size = new System.Drawing.Size(79, 13);
            this.lblBookSearchHint.TabIndex = 7;
            this.lblBookSearchHint.Text = "Search by title";
            // 
            // lblBookSearchTitle
            // 
            this.lblBookSearchTitle.AutoSize = true;
            this.lblBookSearchTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            this.lblBookSearchTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(33)))), ((int)(((byte)(61)))));
            this.lblBookSearchTitle.Location = new System.Drawing.Point(89, 40);
            this.lblBookSearchTitle.Name = "lblBookSearchTitle";
            this.lblBookSearchTitle.Size = new System.Drawing.Size(78, 20);
            this.lblBookSearchTitle.TabIndex = 6;
            this.lblBookSearchTitle.Text = "Find Book";
            // 
            // lblBookStep
            // 
            this.lblBookStep.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(250)))), ((int)(((byte)(248)))));
            this.lblBookStep.Font = new System.Drawing.Font("Segoe UI Semibold", 8F, System.Drawing.FontStyle.Bold);
            this.lblBookStep.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(133)))), ((int)(((byte)(123)))));
            this.lblBookStep.Location = new System.Drawing.Point(19, 19);
            this.lblBookStep.Name = "lblBookStep";
            this.lblBookStep.Size = new System.Drawing.Size(42, 20);
            this.lblBookStep.TabIndex = 1;
            this.lblBookStep.Text = "STEP 2";
            this.lblBookStep.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblBookSearchIcon
            // 
            this.lblBookSearchIcon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(250)))), ((int)(((byte)(248)))));
            this.lblBookSearchIcon.Font = new System.Drawing.Font("Segoe UI Semibold", 16F, System.Drawing.FontStyle.Bold);
            this.lblBookSearchIcon.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(166)))), ((int)(((byte)(154)))));
            this.lblBookSearchIcon.Location = new System.Drawing.Point(20, 45);
            this.lblBookSearchIcon.Name = "lblBookSearchIcon";
            this.lblBookSearchIcon.Size = new System.Drawing.Size(54, 48);
            this.lblBookSearchIcon.TabIndex = 0;
            this.lblBookSearchIcon.Text = "B";
            this.lblBookSearchIcon.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlMemberInfoHost
            // 
            this.pnlMemberInfoHost.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlMemberInfoHost.BackColor = System.Drawing.Color.White;
            this.pnlMemberInfoHost.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(228)))), ((int)(((byte)(238)))));
            this.pnlMemberInfoHost.BorderRadius = 12;
            this.pnlMemberInfoHost.BorderThickness = 1;
            this.pnlMemberInfoHost.Controls.Add(this.ctrlMemberInfo1);
            this.pnlMemberInfoHost.Location = new System.Drawing.Point(30, 136);
            this.pnlMemberInfoHost.Name = "pnlMemberInfoHost";
            this.pnlMemberInfoHost.Padding = new System.Windows.Forms.Padding(1);
            this.pnlMemberInfoHost.Size = new System.Drawing.Size(1107, 230);
            this.pnlMemberInfoHost.TabIndex = 1;
            // 
            // pnlMemberSearchCard
            // 
            this.pnlMemberSearchCard.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlMemberSearchCard.BackColor = System.Drawing.Color.White;
            this.pnlMemberSearchCard.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(228)))), ((int)(((byte)(238)))));
            this.pnlMemberSearchCard.BorderRadius = 12;
            this.pnlMemberSearchCard.BorderThickness = 1;
            this.pnlMemberSearchCard.Controls.Add(this.btnClearMember);
            this.pnlMemberSearchCard.Controls.Add(this.btnFindMember);
            this.pnlMemberSearchCard.Controls.Add(this.txtMemberID);
            this.pnlMemberSearchCard.Controls.Add(this.lblMemberSearchHint);
            this.pnlMemberSearchCard.Controls.Add(this.lblMemberSearchTitle);
            this.pnlMemberSearchCard.Controls.Add(this.lblMemberStep);
            this.pnlMemberSearchCard.Controls.Add(this.lblMemberSearchIcon);
            this.pnlMemberSearchCard.Location = new System.Drawing.Point(30, 24);
            this.pnlMemberSearchCard.Name = "pnlMemberSearchCard";
            this.pnlMemberSearchCard.Size = new System.Drawing.Size(1107, 96);
            this.pnlMemberSearchCard.TabIndex = 0;
            // 
            // btnClearMember
            // 
            this.btnClearMember.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClearMember.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(214)))), ((int)(((byte)(227)))));
            this.btnClearMember.BorderRadius = 8;
            this.btnClearMember.BorderThickness = 1;
            this.btnClearMember.FillColor = System.Drawing.Color.White;
            this.btnClearMember.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.btnClearMember.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(80)))), ((int)(((byte)(103)))));
            this.btnClearMember.Location = new System.Drawing.Point(957, 29);
            this.btnClearMember.Name = "btnClearMember";
            this.btnClearMember.Size = new System.Drawing.Size(118, 40);
            this.btnClearMember.TabIndex = 3;
            this.btnClearMember.Text = "Clear";
            this.btnClearMember.Click += new System.EventHandler(this.btnClearMember_Click);
            // 
            // btnFindMember
            // 
            this.btnFindMember.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFindMember.BorderRadius = 8;
            this.btnFindMember.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(166)))), ((int)(((byte)(154)))));
            this.btnFindMember.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.btnFindMember.ForeColor = System.Drawing.Color.White;
            this.btnFindMember.Location = new System.Drawing.Point(815, 29);
            this.btnFindMember.Name = "btnFindMember";
            this.btnFindMember.Size = new System.Drawing.Size(130, 40);
            this.btnFindMember.TabIndex = 2;
            this.btnFindMember.Text = "Find Member";
            this.btnFindMember.Click += new System.EventHandler(this.btnFindMember_Click);
            // 
            // txtMemberID
            // 
            this.txtMemberID.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMemberID.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(214)))), ((int)(((byte)(227)))));
            this.txtMemberID.BorderRadius = 8;
            this.txtMemberID.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMemberID.DefaultText = "";
            this.txtMemberID.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(166)))), ((int)(((byte)(154)))));
            this.txtMemberID.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.txtMemberID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(48)))), ((int)(((byte)(73)))));
            this.txtMemberID.Location = new System.Drawing.Point(289, 29);
            this.txtMemberID.Name = "txtMemberID";
            this.txtMemberID.PlaceholderText = "Enter Member ID";
            this.txtMemberID.SelectedText = "";
            this.txtMemberID.Size = new System.Drawing.Size(511, 40);
            this.txtMemberID.TabIndex = 1;
            // 
            // lblMemberSearchHint
            // 
            this.lblMemberSearchHint.AutoSize = true;
            this.lblMemberSearchHint.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.lblMemberSearchHint.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(139)))), ((int)(((byte)(162)))));
            this.lblMemberSearchHint.Location = new System.Drawing.Point(90, 55);
            this.lblMemberSearchHint.Name = "lblMemberSearchHint";
            this.lblMemberSearchHint.Size = new System.Drawing.Size(170, 13);
            this.lblMemberSearchHint.TabIndex = 6;
            this.lblMemberSearchHint.Text = "Use the numeric membership ID";
            // 
            // lblMemberSearchTitle
            // 
            this.lblMemberSearchTitle.AutoSize = true;
            this.lblMemberSearchTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            this.lblMemberSearchTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(33)))), ((int)(((byte)(61)))));
            this.lblMemberSearchTitle.Location = new System.Drawing.Point(89, 29);
            this.lblMemberSearchTitle.Name = "lblMemberSearchTitle";
            this.lblMemberSearchTitle.Size = new System.Drawing.Size(101, 20);
            this.lblMemberSearchTitle.TabIndex = 5;
            this.lblMemberSearchTitle.Text = "Find Member";
            // 
            // lblMemberStep
            // 
            this.lblMemberStep.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(250)))), ((int)(((byte)(248)))));
            this.lblMemberStep.Font = new System.Drawing.Font("Segoe UI Semibold", 8F, System.Drawing.FontStyle.Bold);
            this.lblMemberStep.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(133)))), ((int)(((byte)(123)))));
            this.lblMemberStep.Location = new System.Drawing.Point(19, 10);
            this.lblMemberStep.Name = "lblMemberStep";
            this.lblMemberStep.Size = new System.Drawing.Size(42, 20);
            this.lblMemberStep.TabIndex = 1;
            this.lblMemberStep.Text = "STEP 1";
            this.lblMemberStep.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblMemberSearchIcon
            // 
            this.lblMemberSearchIcon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(250)))), ((int)(((byte)(248)))));
            this.lblMemberSearchIcon.Font = new System.Drawing.Font("Segoe UI Semibold", 13F, System.Drawing.FontStyle.Bold);
            this.lblMemberSearchIcon.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(166)))), ((int)(((byte)(154)))));
            this.lblMemberSearchIcon.Location = new System.Drawing.Point(20, 35);
            this.lblMemberSearchIcon.Name = "lblMemberSearchIcon";
            this.lblMemberSearchIcon.Size = new System.Drawing.Size(54, 46);
            this.lblMemberSearchIcon.TabIndex = 0;
            this.lblMemberSearchIcon.Text = "ID";
            this.lblMemberSearchIcon.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ctrlBookInfo1
            // 
            this.ctrlBookInfo1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(245)))), ((int)(((byte)(249)))));
            this.ctrlBookInfo1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ctrlBookInfo1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ctrlBookInfo1.Location = new System.Drawing.Point(1, 1);
            this.ctrlBookInfo1.Name = "ctrlBookInfo1";
            this.ctrlBookInfo1.Size = new System.Drawing.Size(1105, 430);
            this.ctrlBookInfo1.TabIndex = 0;
            // 
            // ctrlMemberInfo1
            // 
            this.ctrlMemberInfo1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(245)))), ((int)(((byte)(249)))));
            this.ctrlMemberInfo1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ctrlMemberInfo1.Location = new System.Drawing.Point(159, 3);
            this.ctrlMemberInfo1.Name = "ctrlMemberInfo1";
            this.ctrlMemberInfo1.Size = new System.Drawing.Size(804, 224);
            this.ctrlMemberInfo1.TabIndex = 0;
            // 
            // frmBorrowBoom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(245)))), ((int)(((byte)(249)))));
            this.ClientSize = new System.Drawing.Size(1184, 749);
            this.Controls.Add(this.pnlContent);
            this.Controls.Add(this.pnlHeader);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.MinimumSize = new System.Drawing.Size(1000, 700);
            this.Name = "frmBorrowBoom";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Borrow Book";
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.pnlContent.ResumeLayout(false);
            this.pnlBorrowInfoCard.ResumeLayout(false);
            this.pnlBorrowInfoCard.PerformLayout();
            this.pnlFee.ResumeLayout(false);
            this.pnlBookInfoHost.ResumeLayout(false);
            this.pnlBookSearchCard.ResumeLayout(false);
            this.pnlBookSearchCard.PerformLayout();
            this.pnlMemberInfoHost.ResumeLayout(false);
            this.pnlMemberSearchCard.ResumeLayout(false);
            this.pnlMemberSearchCard.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblHeaderMark;
        private System.Windows.Forms.Label lblHeaderSubtitle;
        private System.Windows.Forms.Label lblHeaderTitle;
        private System.Windows.Forms.Panel pnlContent;
        private Guna.UI2.WinForms.Guna2Panel pnlMemberSearchCard;
        private System.Windows.Forms.Label lblMemberSearchIcon;
        private System.Windows.Forms.Label lblMemberStep;
        private System.Windows.Forms.Label lblMemberSearchTitle;
        private System.Windows.Forms.Label lblMemberSearchHint;
        private Guna.UI2.WinForms.Guna2TextBox txtMemberID;
        private Guna.UI2.WinForms.Guna2Button btnFindMember;
        private Guna.UI2.WinForms.Guna2Button btnClearMember;
        private Guna.UI2.WinForms.Guna2Panel pnlMemberInfoHost;
        private Library_Management_System.Member.ctrlMemberInfo ctrlMemberInfo1;
        private Guna.UI2.WinForms.Guna2Panel pnlBookSearchCard;
        private System.Windows.Forms.Label lblBookSearchIcon;
        private System.Windows.Forms.Label lblBookStep;
        private System.Windows.Forms.Label lblBookSearchTitle;
        private System.Windows.Forms.Label lblBookSearchHint;
        private Guna.UI2.WinForms.Guna2TextBox txtBookSearchValue;
        private Guna.UI2.WinForms.Guna2Button btnFindBook;
        private Guna.UI2.WinForms.Guna2Button btnClearBook;
        private Guna.UI2.WinForms.Guna2Panel pnlBookInfoHost;
        private Library_Management_System.Book.ctrlBookInfo ctrlBookInfo1;
        private Guna.UI2.WinForms.Guna2Panel pnlBorrowInfoCard;
        private System.Windows.Forms.Label lblBorrowStep;
        private System.Windows.Forms.Label lblBorrowInfoTitle;
        private System.Windows.Forms.Label lblBorrowInfoSubtitle;
        private System.Windows.Forms.Label lblBorrowDateCaption;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpBorrowDate;
        private System.Windows.Forms.Label lblDueDateCaption;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpDueDate;
        private Guna.UI2.WinForms.Guna2Panel pnlFee;
        private System.Windows.Forms.Label lblFeeCaption;
        private System.Windows.Forms.Label lblFeeValue;
        private System.Windows.Forms.Label lblNotesCaption;
        private Guna.UI2.WinForms.Guna2TextBox txtBorrowNotes;
        private Guna.UI2.WinForms.Guna2Button btnReset;
        private Guna.UI2.WinForms.Guna2Button btnConfirmBorrow;
    }
}
