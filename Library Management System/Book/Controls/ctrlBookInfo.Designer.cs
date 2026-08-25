namespace Library_Management_System.Book
{
    partial class ctrlBookInfo
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

        #region Component Designer generated code

        private void InitializeComponent()
        {
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.pnlHeaderIcon = new System.Windows.Forms.Panel();
            this.lblHeaderIcon = new System.Windows.Forms.Label();
            this.lblHeaderSubtitle = new System.Windows.Forms.Label();
            this.lblHeaderTitle = new System.Windows.Forms.Label();
            this.pnlBookCard = new Guna.UI2.WinForms.Guna2Panel();
            this.tblBookDetails = new System.Windows.Forms.TableLayoutPanel();
            this.lblBookIdCaption = new System.Windows.Forms.Label();
            this.lblBookIDValue = new System.Windows.Forms.Label();
            this.lblIsbnCaption = new System.Windows.Forms.Label();
            this.lblISBNValue = new System.Windows.Forms.Label();
            this.lblTitleCaption = new System.Windows.Forms.Label();
            this.lblTitleValue = new System.Windows.Forms.Label();
            this.lblAuthorCaption = new System.Windows.Forms.Label();
            this.lblAuthorValue = new System.Windows.Forms.Label();
            this.lblCategoryCaption = new System.Windows.Forms.Label();
            this.lblCategoryValue = new System.Windows.Forms.Label();
            this.lblPublishedCaption = new System.Windows.Forms.Label();
            this.lblPublishedValue = new System.Windows.Forms.Label();
            this.pnlCover = new System.Windows.Forms.Panel();
            this.lblCoverCaption = new System.Windows.Forms.Label();
            this.lblCoverIcon = new System.Windows.Forms.Label();
            this.pnlAccent = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.lblCopiesValue = new System.Windows.Forms.Label();
            this.pnlHeader.SuspendLayout();
            this.pnlHeaderIcon.SuspendLayout();
            this.pnlBookCard.SuspendLayout();
            this.tblBookDetails.SuspendLayout();
            this.pnlCover.SuspendLayout();
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
            this.pnlHeader.Size = new System.Drawing.Size(1030, 94);
            this.pnlHeader.TabIndex = 0;
            // 
            // pnlHeaderIcon
            // 
            this.pnlHeaderIcon.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlHeaderIcon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(63)))), ((int)(((byte)(105)))));
            this.pnlHeaderIcon.Controls.Add(this.lblHeaderIcon);
            this.pnlHeaderIcon.Location = new System.Drawing.Point(947, 18);
            this.pnlHeaderIcon.Name = "pnlHeaderIcon";
            this.pnlHeaderIcon.Size = new System.Drawing.Size(58, 58);
            this.pnlHeaderIcon.TabIndex = 2;
            // 
            // lblHeaderIcon
            // 
            this.lblHeaderIcon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblHeaderIcon.Font = new System.Drawing.Font("Segoe MDL2 Assets", 22F);
            this.lblHeaderIcon.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(209)))), ((int)(((byte)(197)))));
            this.lblHeaderIcon.Location = new System.Drawing.Point(0, 0);
            this.lblHeaderIcon.Name = "lblHeaderIcon";
            this.lblHeaderIcon.Size = new System.Drawing.Size(58, 58);
            this.lblHeaderIcon.TabIndex = 0;
            this.lblHeaderIcon.Text = "";
            this.lblHeaderIcon.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblHeaderSubtitle
            // 
            this.lblHeaderSubtitle.AutoSize = true;
            this.lblHeaderSubtitle.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblHeaderSubtitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(184)))), ((int)(((byte)(209)))));
            this.lblHeaderSubtitle.Location = new System.Drawing.Point(27, 57);
            this.lblHeaderSubtitle.Name = "lblHeaderSubtitle";
            this.lblHeaderSubtitle.Size = new System.Drawing.Size(304, 15);
            this.lblHeaderSubtitle.TabIndex = 1;
            this.lblHeaderSubtitle.Text = "A complete overview of the selected library book record.";
            // 
            // lblHeaderTitle
            // 
            this.lblHeaderTitle.AutoSize = true;
            this.lblHeaderTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold);
            this.lblHeaderTitle.ForeColor = System.Drawing.Color.White;
            this.lblHeaderTitle.Location = new System.Drawing.Point(24, 21);
            this.lblHeaderTitle.Name = "lblHeaderTitle";
            this.lblHeaderTitle.Size = new System.Drawing.Size(206, 32);
            this.lblHeaderTitle.TabIndex = 0;
            this.lblHeaderTitle.Text = "Book Information";
            // 
            // pnlBookCard
            // 
            this.pnlBookCard.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlBookCard.BackColor = System.Drawing.Color.White;
            this.pnlBookCard.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(228)))), ((int)(((byte)(238)))));
            this.pnlBookCard.BorderRadius = 14;
            this.pnlBookCard.BorderThickness = 1;
            this.pnlBookCard.Controls.Add(this.tblBookDetails);
            this.pnlBookCard.Controls.Add(this.pnlCover);
            this.pnlBookCard.Controls.Add(this.pnlAccent);
            this.pnlBookCard.Location = new System.Drawing.Point(24, 112);
            this.pnlBookCard.Name = "pnlBookCard";
            this.pnlBookCard.Size = new System.Drawing.Size(982, 294);
            this.pnlBookCard.TabIndex = 1;
            // 
            // tblBookDetails
            // 
            this.tblBookDetails.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tblBookDetails.ColumnCount = 4;
            this.tblBookDetails.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 104F));
            this.tblBookDetails.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblBookDetails.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 112F));
            this.tblBookDetails.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblBookDetails.Controls.Add(this.label1, 2, 2);
            this.tblBookDetails.Controls.Add(this.lblCopiesValue, 3, 2);
            this.tblBookDetails.Controls.Add(this.lblBookIdCaption, 0, 0);
            this.tblBookDetails.Controls.Add(this.lblBookIDValue, 1, 0);
            this.tblBookDetails.Controls.Add(this.lblIsbnCaption, 2, 0);
            this.tblBookDetails.Controls.Add(this.lblISBNValue, 3, 0);
            this.tblBookDetails.Controls.Add(this.lblTitleCaption, 0, 1);
            this.tblBookDetails.Controls.Add(this.lblTitleValue, 1, 1);
            this.tblBookDetails.Controls.Add(this.lblAuthorCaption, 2, 1);
            this.tblBookDetails.Controls.Add(this.lblAuthorValue, 3, 1);
            this.tblBookDetails.Controls.Add(this.lblCategoryCaption, 0, 2);
            this.tblBookDetails.Controls.Add(this.lblCategoryValue, 1, 2);
            this.tblBookDetails.Controls.Add(this.lblPublishedCaption, 0, 3);
            this.tblBookDetails.Controls.Add(this.lblPublishedValue, 1, 3);
            this.tblBookDetails.Location = new System.Drawing.Point(231, 25);
            this.tblBookDetails.Name = "tblBookDetails";
            this.tblBookDetails.RowCount = 4;
            this.tblBookDetails.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tblBookDetails.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tblBookDetails.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tblBookDetails.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tblBookDetails.Size = new System.Drawing.Size(724, 244);
            this.tblBookDetails.TabIndex = 2;
            // 
            // lblBookIdCaption
            // 
            this.lblBookIdCaption.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblBookIdCaption.Font = new System.Drawing.Font("Segoe UI Semibold", 7.5F, System.Drawing.FontStyle.Bold);
            this.lblBookIdCaption.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(139)))), ((int)(((byte)(162)))));
            this.lblBookIdCaption.Location = new System.Drawing.Point(3, 3);
            this.lblBookIdCaption.Margin = new System.Windows.Forms.Padding(3);
            this.lblBookIdCaption.Name = "lblBookIdCaption";
            this.lblBookIdCaption.Size = new System.Drawing.Size(98, 55);
            this.lblBookIdCaption.TabIndex = 0;
            this.lblBookIdCaption.Text = "BOOK ID";
            this.lblBookIdCaption.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblBookIDValue
            // 
            this.lblBookIDValue.AutoEllipsis = true;
            this.lblBookIDValue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblBookIDValue.Font = new System.Drawing.Font("Segoe UI Semibold", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblBookIDValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(48)))), ((int)(((byte)(73)))));
            this.lblBookIDValue.Location = new System.Drawing.Point(107, 3);
            this.lblBookIDValue.Margin = new System.Windows.Forms.Padding(3, 3, 10, 3);
            this.lblBookIDValue.Name = "lblBookIDValue";
            this.lblBookIDValue.Size = new System.Drawing.Size(241, 55);
            this.lblBookIDValue.TabIndex = 1;
            this.lblBookIDValue.Text = "—";
            this.lblBookIDValue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblIsbnCaption
            // 
            this.lblIsbnCaption.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblIsbnCaption.Font = new System.Drawing.Font("Segoe UI Semibold", 7.5F, System.Drawing.FontStyle.Bold);
            this.lblIsbnCaption.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(139)))), ((int)(((byte)(162)))));
            this.lblIsbnCaption.Location = new System.Drawing.Point(361, 3);
            this.lblIsbnCaption.Margin = new System.Windows.Forms.Padding(3);
            this.lblIsbnCaption.Name = "lblIsbnCaption";
            this.lblIsbnCaption.Size = new System.Drawing.Size(106, 55);
            this.lblIsbnCaption.TabIndex = 2;
            this.lblIsbnCaption.Text = "ISBN";
            this.lblIsbnCaption.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblISBNValue
            // 
            this.lblISBNValue.AutoEllipsis = true;
            this.lblISBNValue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblISBNValue.Font = new System.Drawing.Font("Segoe UI Semibold", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblISBNValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(48)))), ((int)(((byte)(73)))));
            this.lblISBNValue.Location = new System.Drawing.Point(473, 3);
            this.lblISBNValue.Margin = new System.Windows.Forms.Padding(3, 3, 10, 3);
            this.lblISBNValue.Name = "lblISBNValue";
            this.lblISBNValue.Size = new System.Drawing.Size(241, 55);
            this.lblISBNValue.TabIndex = 3;
            this.lblISBNValue.Text = "—";
            this.lblISBNValue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblTitleCaption
            // 
            this.lblTitleCaption.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTitleCaption.Font = new System.Drawing.Font("Segoe UI Semibold", 7.5F, System.Drawing.FontStyle.Bold);
            this.lblTitleCaption.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(139)))), ((int)(((byte)(162)))));
            this.lblTitleCaption.Location = new System.Drawing.Point(3, 64);
            this.lblTitleCaption.Margin = new System.Windows.Forms.Padding(3);
            this.lblTitleCaption.Name = "lblTitleCaption";
            this.lblTitleCaption.Size = new System.Drawing.Size(98, 55);
            this.lblTitleCaption.TabIndex = 4;
            this.lblTitleCaption.Text = "TITLE";
            this.lblTitleCaption.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblTitleValue
            // 
            this.lblTitleValue.AutoEllipsis = true;
            this.lblTitleValue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTitleValue.Font = new System.Drawing.Font("Segoe UI Semibold", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblTitleValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(48)))), ((int)(((byte)(73)))));
            this.lblTitleValue.Location = new System.Drawing.Point(107, 64);
            this.lblTitleValue.Margin = new System.Windows.Forms.Padding(3, 3, 10, 3);
            this.lblTitleValue.Name = "lblTitleValue";
            this.lblTitleValue.Size = new System.Drawing.Size(241, 55);
            this.lblTitleValue.TabIndex = 5;
            this.lblTitleValue.Text = "No book selected";
            this.lblTitleValue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblAuthorCaption
            // 
            this.lblAuthorCaption.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblAuthorCaption.Font = new System.Drawing.Font("Segoe UI Semibold", 7.5F, System.Drawing.FontStyle.Bold);
            this.lblAuthorCaption.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(139)))), ((int)(((byte)(162)))));
            this.lblAuthorCaption.Location = new System.Drawing.Point(361, 64);
            this.lblAuthorCaption.Margin = new System.Windows.Forms.Padding(3);
            this.lblAuthorCaption.Name = "lblAuthorCaption";
            this.lblAuthorCaption.Size = new System.Drawing.Size(106, 55);
            this.lblAuthorCaption.TabIndex = 6;
            this.lblAuthorCaption.Text = "AUTHOR";
            this.lblAuthorCaption.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblAuthorValue
            // 
            this.lblAuthorValue.AutoEllipsis = true;
            this.lblAuthorValue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblAuthorValue.Font = new System.Drawing.Font("Segoe UI Semibold", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblAuthorValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(48)))), ((int)(((byte)(73)))));
            this.lblAuthorValue.Location = new System.Drawing.Point(473, 64);
            this.lblAuthorValue.Margin = new System.Windows.Forms.Padding(3, 3, 10, 3);
            this.lblAuthorValue.Name = "lblAuthorValue";
            this.lblAuthorValue.Size = new System.Drawing.Size(241, 55);
            this.lblAuthorValue.TabIndex = 7;
            this.lblAuthorValue.Text = "—";
            this.lblAuthorValue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblCategoryCaption
            // 
            this.lblCategoryCaption.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblCategoryCaption.Font = new System.Drawing.Font("Segoe UI Semibold", 7.5F, System.Drawing.FontStyle.Bold);
            this.lblCategoryCaption.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(139)))), ((int)(((byte)(162)))));
            this.lblCategoryCaption.Location = new System.Drawing.Point(3, 125);
            this.lblCategoryCaption.Margin = new System.Windows.Forms.Padding(3);
            this.lblCategoryCaption.Name = "lblCategoryCaption";
            this.lblCategoryCaption.Size = new System.Drawing.Size(98, 55);
            this.lblCategoryCaption.TabIndex = 8;
            this.lblCategoryCaption.Text = "CATEGORY";
            this.lblCategoryCaption.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblCategoryValue
            // 
            this.lblCategoryValue.AutoEllipsis = true;
            this.lblCategoryValue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblCategoryValue.Font = new System.Drawing.Font("Segoe UI Semibold", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblCategoryValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(48)))), ((int)(((byte)(73)))));
            this.lblCategoryValue.Location = new System.Drawing.Point(107, 125);
            this.lblCategoryValue.Margin = new System.Windows.Forms.Padding(3, 3, 10, 3);
            this.lblCategoryValue.Name = "lblCategoryValue";
            this.lblCategoryValue.Size = new System.Drawing.Size(241, 55);
            this.lblCategoryValue.TabIndex = 9;
            this.lblCategoryValue.Text = "—";
            this.lblCategoryValue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblPublishedCaption
            // 
            this.lblPublishedCaption.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblPublishedCaption.Font = new System.Drawing.Font("Segoe UI Semibold", 7.5F, System.Drawing.FontStyle.Bold);
            this.lblPublishedCaption.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(139)))), ((int)(((byte)(162)))));
            this.lblPublishedCaption.Location = new System.Drawing.Point(3, 186);
            this.lblPublishedCaption.Margin = new System.Windows.Forms.Padding(3);
            this.lblPublishedCaption.Name = "lblPublishedCaption";
            this.lblPublishedCaption.Size = new System.Drawing.Size(98, 55);
            this.lblPublishedCaption.TabIndex = 12;
            this.lblPublishedCaption.Text = "PUBLISHED";
            this.lblPublishedCaption.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblPublishedValue
            // 
            this.lblPublishedValue.AutoEllipsis = true;
            this.lblPublishedValue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblPublishedValue.Font = new System.Drawing.Font("Segoe UI Semibold", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblPublishedValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(48)))), ((int)(((byte)(73)))));
            this.lblPublishedValue.Location = new System.Drawing.Point(107, 186);
            this.lblPublishedValue.Margin = new System.Windows.Forms.Padding(3, 3, 10, 3);
            this.lblPublishedValue.Name = "lblPublishedValue";
            this.lblPublishedValue.Size = new System.Drawing.Size(241, 55);
            this.lblPublishedValue.TabIndex = 13;
            this.lblPublishedValue.Text = "—";
            this.lblPublishedValue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pnlCover
            // 
            this.pnlCover.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.pnlCover.Controls.Add(this.lblCoverCaption);
            this.pnlCover.Controls.Add(this.lblCoverIcon);
            this.pnlCover.Location = new System.Drawing.Point(25, 25);
            this.pnlCover.Name = "pnlCover";
            this.pnlCover.Size = new System.Drawing.Size(184, 244);
            this.pnlCover.TabIndex = 1;
            // 
            // lblCoverCaption
            // 
            this.lblCoverCaption.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.lblCoverCaption.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(112)))), ((int)(((byte)(170)))));
            this.lblCoverCaption.Location = new System.Drawing.Point(20, 121);
            this.lblCoverCaption.Name = "lblCoverCaption";
            this.lblCoverCaption.Size = new System.Drawing.Size(144, 22);
            this.lblCoverCaption.TabIndex = 1;
            this.lblCoverCaption.Text = "LIBRARY BOOK";
            this.lblCoverCaption.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCoverIcon
            // 
            this.lblCoverIcon.Font = new System.Drawing.Font("Segoe MDL2 Assets", 48F);
            this.lblCoverIcon.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(112)))), ((int)(((byte)(170)))));
            this.lblCoverIcon.Location = new System.Drawing.Point(22, 31);
            this.lblCoverIcon.Name = "lblCoverIcon";
            this.lblCoverIcon.Size = new System.Drawing.Size(140, 90);
            this.lblCoverIcon.TabIndex = 0;
            this.lblCoverIcon.Text = "";
            this.lblCoverIcon.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlAccent
            // 
            this.pnlAccent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(166)))), ((int)(((byte)(154)))));
            this.pnlAccent.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlAccent.Location = new System.Drawing.Point(0, 0);
            this.pnlAccent.Name = "pnlAccent";
            this.pnlAccent.Size = new System.Drawing.Size(5, 294);
            this.pnlAccent.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 7.5F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(139)))), ((int)(((byte)(162)))));
            this.label1.Location = new System.Drawing.Point(361, 125);
            this.label1.Margin = new System.Windows.Forms.Padding(3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 55);
            this.label1.TabIndex = 14;
            this.label1.Text = "Copies Available";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblCopiesValue
            // 
            this.lblCopiesValue.AutoEllipsis = true;
            this.lblCopiesValue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblCopiesValue.Font = new System.Drawing.Font("Segoe UI Semibold", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblCopiesValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(48)))), ((int)(((byte)(73)))));
            this.lblCopiesValue.Location = new System.Drawing.Point(473, 125);
            this.lblCopiesValue.Margin = new System.Windows.Forms.Padding(3, 3, 10, 3);
            this.lblCopiesValue.Name = "lblCopiesValue";
            this.lblCopiesValue.Size = new System.Drawing.Size(241, 55);
            this.lblCopiesValue.TabIndex = 15;
            this.lblCopiesValue.Text = "—";
            this.lblCopiesValue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ctrlBookInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(245)))), ((int)(((byte)(249)))));
            this.Controls.Add(this.pnlBookCard);
            this.Controls.Add(this.pnlHeader);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Name = "ctrlBookInfo";
            this.Size = new System.Drawing.Size(1030, 430);
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.pnlHeaderIcon.ResumeLayout(false);
            this.pnlBookCard.ResumeLayout(false);
            this.tblBookDetails.ResumeLayout(false);
            this.pnlCover.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Panel pnlHeaderIcon;
        private System.Windows.Forms.Label lblHeaderIcon;
        private System.Windows.Forms.Label lblHeaderSubtitle;
        private System.Windows.Forms.Label lblHeaderTitle;
        private Guna.UI2.WinForms.Guna2Panel pnlBookCard;
        private System.Windows.Forms.Panel pnlCover;
        private System.Windows.Forms.Label lblCoverIcon;
        private System.Windows.Forms.Label lblCoverCaption;
        private System.Windows.Forms.Panel pnlAccent;
        private System.Windows.Forms.TableLayoutPanel tblBookDetails;
        private System.Windows.Forms.Label lblBookIdCaption;
        private System.Windows.Forms.Label lblBookIDValue;
        private System.Windows.Forms.Label lblIsbnCaption;
        private System.Windows.Forms.Label lblISBNValue;
        private System.Windows.Forms.Label lblTitleCaption;
        private System.Windows.Forms.Label lblTitleValue;
        private System.Windows.Forms.Label lblAuthorCaption;
        private System.Windows.Forms.Label lblAuthorValue;
        private System.Windows.Forms.Label lblCategoryCaption;
        private System.Windows.Forms.Label lblCategoryValue;
        private System.Windows.Forms.Label lblPublishedCaption;
        private System.Windows.Forms.Label lblPublishedValue;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblCopiesValue;
    }
}
