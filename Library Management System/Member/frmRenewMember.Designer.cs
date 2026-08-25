namespace Library_Management_System.Member
{
    partial class frmRenewMember
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
            this.pnlSearchCard = new System.Windows.Forms.Panel();
            this.btnSearch = new Guna.UI2.WinForms.Guna2Button();
            this.txtBoxMemberID = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblSearchHint = new System.Windows.Forms.Label();
            this.lblMemberIdCaption = new System.Windows.Forms.Label();
            this.lblSearchMark = new System.Windows.Forms.Label();
            this.pnlRenewalCard = new System.Windows.Forms.Panel();
            this.btnCancel = new Guna.UI2.WinForms.Guna2Button();
            this.btnRenew = new Guna.UI2.WinForms.Guna2Button();
            this.txtBoxRenewalFee = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblFeeHint = new System.Windows.Forms.Label();
            this.lblFeeCaption = new System.Windows.Forms.Label();
            this.dateTimePickEndDate = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.lblEndDateHint = new System.Windows.Forms.Label();
            this.lblEndDateCaption = new System.Windows.Forms.Label();
            this.dateTimePickStartDate = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.lblStartDateHint = new System.Windows.Forms.Label();
            this.lblStartDateCaption = new System.Windows.Forms.Label();
            this.lblRenewalSubtitle = new System.Windows.Forms.Label();
            this.lblRenewalTitle = new System.Windows.Forms.Label();
            this.ctrlMemberInfo1 = new Library_Management_System.Member.ctrlMemberInfo();
            this.pnlHeader.SuspendLayout();
            this.pnlSearchCard.SuspendLayout();
            this.pnlRenewalCard.SuspendLayout();
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
            this.pnlHeader.Size = new System.Drawing.Size(940, 104);
            this.pnlHeader.TabIndex = 0;
            // 
            // lblHeaderMark
            // 
            this.lblHeaderMark.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(63)))), ((int)(((byte)(105)))));
            this.lblHeaderMark.Font = new System.Drawing.Font("Segoe UI Semibold", 20F, System.Drawing.FontStyle.Bold);
            this.lblHeaderMark.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(209)))), ((int)(((byte)(197)))));
            this.lblHeaderMark.Location = new System.Drawing.Point(856, 25);
            this.lblHeaderMark.Name = "lblHeaderMark";
            this.lblHeaderMark.Size = new System.Drawing.Size(54, 54);
            this.lblHeaderMark.TabIndex = 2;
            this.lblHeaderMark.Text = "R";
            this.lblHeaderMark.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblHeaderSubtitle
            // 
            this.lblHeaderSubtitle.AutoSize = true;
            this.lblHeaderSubtitle.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblHeaderSubtitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(184)))), ((int)(((byte)(209)))));
            this.lblHeaderSubtitle.Location = new System.Drawing.Point(31, 62);
            this.lblHeaderSubtitle.Name = "lblHeaderSubtitle";
            this.lblHeaderSubtitle.Size = new System.Drawing.Size(375, 17);
            this.lblHeaderSubtitle.TabIndex = 1;
            this.lblHeaderSubtitle.Text = "Review the current membership and set the new validity period";
            // 
            // lblHeaderTitle
            // 
            this.lblHeaderTitle.AutoSize = true;
            this.lblHeaderTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 19F, System.Drawing.FontStyle.Bold);
            this.lblHeaderTitle.ForeColor = System.Drawing.Color.White;
            this.lblHeaderTitle.Location = new System.Drawing.Point(28, 23);
            this.lblHeaderTitle.Name = "lblHeaderTitle";
            this.lblHeaderTitle.Size = new System.Drawing.Size(250, 36);
            this.lblHeaderTitle.TabIndex = 0;
            this.lblHeaderTitle.Text = "Renew Membership";
            // 
            // pnlSearchCard
            // 
            this.pnlSearchCard.BackColor = System.Drawing.Color.White;
            this.pnlSearchCard.Controls.Add(this.btnSearch);
            this.pnlSearchCard.Controls.Add(this.txtBoxMemberID);
            this.pnlSearchCard.Controls.Add(this.lblSearchHint);
            this.pnlSearchCard.Controls.Add(this.lblMemberIdCaption);
            this.pnlSearchCard.Controls.Add(this.lblSearchMark);
            this.pnlSearchCard.Location = new System.Drawing.Point(28, 124);
            this.pnlSearchCard.Name = "pnlSearchCard";
            this.pnlSearchCard.Size = new System.Drawing.Size(884, 96);
            this.pnlSearchCard.TabIndex = 1;
            // 
            // btnSearch
            // 
            this.btnSearch.BorderRadius = 9;
            this.btnSearch.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSearch.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSearch.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(211)))), ((int)(((byte)(224)))));
            this.btnSearch.DisabledState.ForeColor = System.Drawing.Color.White;
            this.btnSearch.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(166)))), ((int)(((byte)(154)))));
            this.btnSearch.Font = new System.Drawing.Font("Segoe UI Semibold", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(132)))), ((int)(((byte)(122)))));
            this.btnSearch.Location = new System.Drawing.Point(728, 28);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(126, 40);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "Find Member";
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtBoxMemberID
            // 
            this.txtBoxMemberID.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(226)))), ((int)(((byte)(239)))));
            this.txtBoxMemberID.BorderRadius = 9;
            this.txtBoxMemberID.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtBoxMemberID.DefaultText = "";
            this.txtBoxMemberID.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtBoxMemberID.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(244)))), ((int)(((byte)(248)))));
            this.txtBoxMemberID.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtBoxMemberID.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtBoxMemberID.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(253)))));
            this.txtBoxMemberID.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(166)))), ((int)(((byte)(154)))));
            this.txtBoxMemberID.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.txtBoxMemberID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(33)))), ((int)(((byte)(61)))));
            this.txtBoxMemberID.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(209)))), ((int)(((byte)(197)))));
            this.txtBoxMemberID.Location = new System.Drawing.Point(292, 28);
            this.txtBoxMemberID.Margin = new System.Windows.Forms.Padding(4);
            this.txtBoxMemberID.Name = "txtBoxMemberID";
            this.txtBoxMemberID.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(156)))), ((int)(((byte)(177)))));
            this.txtBoxMemberID.PlaceholderText = "Enter member ID";
            this.txtBoxMemberID.SelectedText = "";
            this.txtBoxMemberID.Size = new System.Drawing.Size(416, 40);
            this.txtBoxMemberID.TabIndex = 1;
            // 
            // lblSearchHint
            // 
            this.lblSearchHint.AutoSize = true;
            this.lblSearchHint.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.lblSearchHint.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(156)))), ((int)(((byte)(177)))));
            this.lblSearchHint.Location = new System.Drawing.Point(82, 52);
            this.lblSearchHint.Name = "lblSearchHint";
            this.lblSearchHint.Size = new System.Drawing.Size(175, 13);
            this.lblSearchHint.TabIndex = 4;
            this.lblSearchHint.Text = "Locate the membership to renew";
            // 
            // lblMemberIdCaption
            // 
            this.lblMemberIdCaption.AutoSize = true;
            this.lblMemberIdCaption.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.lblMemberIdCaption.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(33)))), ((int)(((byte)(61)))));
            this.lblMemberIdCaption.Location = new System.Drawing.Point(81, 28);
            this.lblMemberIdCaption.Name = "lblMemberIdCaption";
            this.lblMemberIdCaption.Size = new System.Drawing.Size(79, 19);
            this.lblMemberIdCaption.TabIndex = 3;
            this.lblMemberIdCaption.Text = "Member ID";
            // 
            // lblSearchMark
            // 
            this.lblSearchMark.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(250)))), ((int)(((byte)(248)))));
            this.lblSearchMark.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold);
            this.lblSearchMark.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(166)))), ((int)(((byte)(154)))));
            this.lblSearchMark.Location = new System.Drawing.Point(24, 26);
            this.lblSearchMark.Name = "lblSearchMark";
            this.lblSearchMark.Size = new System.Drawing.Size(46, 46);
            this.lblSearchMark.TabIndex = 0;
            this.lblSearchMark.Text = "ID";
            this.lblSearchMark.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlRenewalCard
            // 
            this.pnlRenewalCard.BackColor = System.Drawing.Color.White;
            this.pnlRenewalCard.Controls.Add(this.btnCancel);
            this.pnlRenewalCard.Controls.Add(this.btnRenew);
            this.pnlRenewalCard.Controls.Add(this.txtBoxRenewalFee);
            this.pnlRenewalCard.Controls.Add(this.lblFeeHint);
            this.pnlRenewalCard.Controls.Add(this.lblFeeCaption);
            this.pnlRenewalCard.Controls.Add(this.dateTimePickEndDate);
            this.pnlRenewalCard.Controls.Add(this.lblEndDateHint);
            this.pnlRenewalCard.Controls.Add(this.lblEndDateCaption);
            this.pnlRenewalCard.Controls.Add(this.dateTimePickStartDate);
            this.pnlRenewalCard.Controls.Add(this.lblStartDateHint);
            this.pnlRenewalCard.Controls.Add(this.lblStartDateCaption);
            this.pnlRenewalCard.Controls.Add(this.lblRenewalSubtitle);
            this.pnlRenewalCard.Controls.Add(this.lblRenewalTitle);
            this.pnlRenewalCard.Location = new System.Drawing.Point(57, 418);
            this.pnlRenewalCard.Name = "pnlRenewalCard";
            this.pnlRenewalCard.Size = new System.Drawing.Size(855, 224);
            this.pnlRenewalCard.TabIndex = 3;
            // 
            // btnCancel
            // 
            this.btnCancel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(211)))), ((int)(((byte)(224)))));
            this.btnCancel.BorderRadius = 9;
            this.btnCancel.BorderThickness = 1;
            this.btnCancel.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnCancel.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnCancel.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(244)))), ((int)(((byte)(248)))));
            this.btnCancel.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(156)))), ((int)(((byte)(177)))));
            this.btnCancel.FillColor = System.Drawing.Color.White;
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI Semibold", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnCancel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(84)))), ((int)(((byte)(106)))));
            this.btnCancel.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(253)))));
            this.btnCancel.Location = new System.Drawing.Point(460, 155);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(134, 40);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnRenew
            // 
            this.btnRenew.BorderRadius = 9;
            this.btnRenew.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnRenew.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnRenew.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(211)))), ((int)(((byte)(224)))));
            this.btnRenew.DisabledState.ForeColor = System.Drawing.Color.White;
            this.btnRenew.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(166)))), ((int)(((byte)(154)))));
            this.btnRenew.Font = new System.Drawing.Font("Segoe UI Semibold", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnRenew.ForeColor = System.Drawing.Color.White;
            this.btnRenew.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(132)))), ((int)(((byte)(122)))));
            this.btnRenew.Location = new System.Drawing.Point(608, 155);
            this.btnRenew.Name = "btnRenew";
            this.btnRenew.Size = new System.Drawing.Size(158, 40);
            this.btnRenew.TabIndex = 4;
            this.btnRenew.Text = "Renew Membership";
            this.btnRenew.Click += new System.EventHandler(this.btnRenew_Click);
            // 
            // txtBoxRenewalFee
            // 
            this.txtBoxRenewalFee.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(226)))), ((int)(((byte)(239)))));
            this.txtBoxRenewalFee.BorderRadius = 8;
            this.txtBoxRenewalFee.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtBoxRenewalFee.DefaultText = "";
            this.txtBoxRenewalFee.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtBoxRenewalFee.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(244)))), ((int)(((byte)(248)))));
            this.txtBoxRenewalFee.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtBoxRenewalFee.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtBoxRenewalFee.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(253)))));
            this.txtBoxRenewalFee.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(166)))), ((int)(((byte)(154)))));
            this.txtBoxRenewalFee.Font = new System.Drawing.Font("Segoe UI Semibold", 9.5F, System.Drawing.FontStyle.Bold);
            this.txtBoxRenewalFee.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(33)))), ((int)(((byte)(61)))));
            this.txtBoxRenewalFee.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(209)))), ((int)(((byte)(197)))));
            this.txtBoxRenewalFee.Location = new System.Drawing.Point(513, 95);
            this.txtBoxRenewalFee.Margin = new System.Windows.Forms.Padding(4);
            this.txtBoxRenewalFee.Name = "txtBoxRenewalFee";
            this.txtBoxRenewalFee.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(156)))), ((int)(((byte)(177)))));
            this.txtBoxRenewalFee.PlaceholderText = "0.00 JOD";
            this.txtBoxRenewalFee.SelectedText = "";
            this.txtBoxRenewalFee.Size = new System.Drawing.Size(180, 40);
            this.txtBoxRenewalFee.TabIndex = 3;
            this.txtBoxRenewalFee.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblFeeHint
            // 
            this.lblFeeHint.AutoSize = true;
            this.lblFeeHint.Font = new System.Drawing.Font("Segoe UI", 7.5F);
            this.lblFeeHint.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(156)))), ((int)(((byte)(177)))));
            this.lblFeeHint.Location = new System.Drawing.Point(511, 140);
            this.lblFeeHint.Name = "lblFeeHint";
            this.lblFeeHint.Size = new System.Drawing.Size(112, 12);
            this.lblFeeHint.TabIndex = 10;
            this.lblFeeHint.Text = "Membership renewal fee";
            // 
            // lblFeeCaption
            // 
            this.lblFeeCaption.AutoSize = true;
            this.lblFeeCaption.Font = new System.Drawing.Font("Segoe UI Semibold", 8.5F, System.Drawing.FontStyle.Bold);
            this.lblFeeCaption.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(84)))), ((int)(((byte)(106)))));
            this.lblFeeCaption.Location = new System.Drawing.Point(510, 73);
            this.lblFeeCaption.Name = "lblFeeCaption";
            this.lblFeeCaption.Size = new System.Drawing.Size(72, 15);
            this.lblFeeCaption.TabIndex = 9;
            this.lblFeeCaption.Text = "Renewal Fee";
            // 
            // dateTimePickEndDate
            // 
            this.dateTimePickEndDate.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(226)))), ((int)(((byte)(239)))));
            this.dateTimePickEndDate.BorderRadius = 8;
            this.dateTimePickEndDate.BorderThickness = 1;
            this.dateTimePickEndDate.Checked = true;
            this.dateTimePickEndDate.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(253)))));
            this.dateTimePickEndDate.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.dateTimePickEndDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(33)))), ((int)(((byte)(61)))));
            this.dateTimePickEndDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickEndDate.Location = new System.Drawing.Point(301, 95);
            this.dateTimePickEndDate.MaxDate = new System.DateTime(2099, 12, 31, 0, 0, 0, 0);
            this.dateTimePickEndDate.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.dateTimePickEndDate.Name = "dateTimePickEndDate";
            this.dateTimePickEndDate.Size = new System.Drawing.Size(180, 40);
            this.dateTimePickEndDate.TabIndex = 2;
            this.dateTimePickEndDate.Value = new System.DateTime(2026, 8, 11, 12, 15, 4, 126);
            // 
            // lblEndDateHint
            // 
            this.lblEndDateHint.AutoSize = true;
            this.lblEndDateHint.Font = new System.Drawing.Font("Segoe UI", 7.5F);
            this.lblEndDateHint.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(156)))), ((int)(((byte)(177)))));
            this.lblEndDateHint.Location = new System.Drawing.Point(299, 140);
            this.lblEndDateHint.Name = "lblEndDateHint";
            this.lblEndDateHint.Size = new System.Drawing.Size(133, 12);
            this.lblEndDateHint.TabIndex = 8;
            this.lblEndDateHint.Text = "New membership expiry date";
            // 
            // lblEndDateCaption
            // 
            this.lblEndDateCaption.AutoSize = true;
            this.lblEndDateCaption.Font = new System.Drawing.Font("Segoe UI Semibold", 8.5F, System.Drawing.FontStyle.Bold);
            this.lblEndDateCaption.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(84)))), ((int)(((byte)(106)))));
            this.lblEndDateCaption.Location = new System.Drawing.Point(298, 73);
            this.lblEndDateCaption.Name = "lblEndDateCaption";
            this.lblEndDateCaption.Size = new System.Drawing.Size(82, 15);
            this.lblEndDateCaption.TabIndex = 7;
            this.lblEndDateCaption.Text = "New End Date";
            // 
            // dateTimePickStartDate
            // 
            this.dateTimePickStartDate.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(226)))), ((int)(((byte)(239)))));
            this.dateTimePickStartDate.BorderRadius = 8;
            this.dateTimePickStartDate.BorderThickness = 1;
            this.dateTimePickStartDate.Checked = true;
            this.dateTimePickStartDate.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(253)))));
            this.dateTimePickStartDate.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.dateTimePickStartDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(33)))), ((int)(((byte)(61)))));
            this.dateTimePickStartDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickStartDate.Location = new System.Drawing.Point(93, 95);
            this.dateTimePickStartDate.MaxDate = new System.DateTime(2099, 12, 31, 0, 0, 0, 0);
            this.dateTimePickStartDate.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.dateTimePickStartDate.Name = "dateTimePickStartDate";
            this.dateTimePickStartDate.Size = new System.Drawing.Size(180, 40);
            this.dateTimePickStartDate.TabIndex = 1;
            this.dateTimePickStartDate.Value = new System.DateTime(2026, 8, 11, 12, 15, 4, 173);
            // 
            // lblStartDateHint
            // 
            this.lblStartDateHint.AutoSize = true;
            this.lblStartDateHint.Font = new System.Drawing.Font("Segoe UI", 7.5F);
            this.lblStartDateHint.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(156)))), ((int)(((byte)(177)))));
            this.lblStartDateHint.Location = new System.Drawing.Point(91, 140);
            this.lblStartDateHint.Name = "lblStartDateHint";
            this.lblStartDateHint.Size = new System.Drawing.Size(142, 12);
            this.lblStartDateHint.TabIndex = 6;
            this.lblStartDateHint.Text = "Beginning of the renewed term";
            // 
            // lblStartDateCaption
            // 
            this.lblStartDateCaption.AutoSize = true;
            this.lblStartDateCaption.Font = new System.Drawing.Font("Segoe UI Semibold", 8.5F, System.Drawing.FontStyle.Bold);
            this.lblStartDateCaption.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(84)))), ((int)(((byte)(106)))));
            this.lblStartDateCaption.Location = new System.Drawing.Point(90, 73);
            this.lblStartDateCaption.Name = "lblStartDateCaption";
            this.lblStartDateCaption.Size = new System.Drawing.Size(87, 15);
            this.lblStartDateCaption.TabIndex = 5;
            this.lblStartDateCaption.Text = "New Start Date";
            // 
            // lblRenewalSubtitle
            // 
            this.lblRenewalSubtitle.AutoSize = true;
            this.lblRenewalSubtitle.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.lblRenewalSubtitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(156)))), ((int)(((byte)(177)))));
            this.lblRenewalSubtitle.Location = new System.Drawing.Point(148, 30);
            this.lblRenewalSubtitle.Name = "lblRenewalSubtitle";
            this.lblRenewalSubtitle.Size = new System.Drawing.Size(261, 15);
            this.lblRenewalSubtitle.TabIndex = 4;
            this.lblRenewalSubtitle.Text = "Set the new dates and renewal payment amount";
            // 
            // lblRenewalTitle
            // 
            this.lblRenewalTitle.AutoSize = true;
            this.lblRenewalTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 13F, System.Drawing.FontStyle.Bold);
            this.lblRenewalTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(33)))), ((int)(((byte)(61)))));
            this.lblRenewalTitle.Location = new System.Drawing.Point(24, 23);
            this.lblRenewalTitle.Name = "lblRenewalTitle";
            this.lblRenewalTitle.Size = new System.Drawing.Size(123, 25);
            this.lblRenewalTitle.TabIndex = 0;
            this.lblRenewalTitle.Text = "Renewal plan";
            // 
            // ctrlMemberInfo1
            // 
            this.ctrlMemberInfo1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(245)))), ((int)(((byte)(249)))));
            this.ctrlMemberInfo1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ctrlMemberInfo1.Location = new System.Drawing.Point(34, 223);
            this.ctrlMemberInfo1.Name = "ctrlMemberInfo1";
            this.ctrlMemberInfo1.Size = new System.Drawing.Size(876, 183);
            this.ctrlMemberInfo1.TabIndex = 4;
            // 
            // frmRenewMember
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(245)))), ((int)(((byte)(249)))));
            this.ClientSize = new System.Drawing.Size(940, 670);
            this.Controls.Add(this.ctrlMemberInfo1);
            this.Controls.Add(this.pnlRenewalCard);
            this.Controls.Add(this.pnlSearchCard);
            this.Controls.Add(this.pnlHeader);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmRenewMember";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Renew Membership";
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.pnlSearchCard.ResumeLayout(false);
            this.pnlSearchCard.PerformLayout();
            this.pnlRenewalCard.ResumeLayout(false);
            this.pnlRenewalCard.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblHeaderMark;
        private System.Windows.Forms.Label lblHeaderSubtitle;
        private System.Windows.Forms.Label lblHeaderTitle;
        private System.Windows.Forms.Panel pnlSearchCard;
        private System.Windows.Forms.Label lblSearchMark;
        private System.Windows.Forms.Label lblMemberIdCaption;
        private System.Windows.Forms.Label lblSearchHint;
        private Guna.UI2.WinForms.Guna2TextBox txtBoxMemberID;
        private Guna.UI2.WinForms.Guna2Button btnSearch;
        private System.Windows.Forms.Panel pnlRenewalCard;
        private System.Windows.Forms.Label lblRenewalTitle;
        private System.Windows.Forms.Label lblRenewalSubtitle;
        private System.Windows.Forms.Label lblStartDateCaption;
        private System.Windows.Forms.Label lblStartDateHint;
        private Guna.UI2.WinForms.Guna2DateTimePicker dateTimePickStartDate;
        private System.Windows.Forms.Label lblEndDateCaption;
        private System.Windows.Forms.Label lblEndDateHint;
        private Guna.UI2.WinForms.Guna2DateTimePicker dateTimePickEndDate;
        private System.Windows.Forms.Label lblFeeCaption;
        private System.Windows.Forms.Label lblFeeHint;
        private Guna.UI2.WinForms.Guna2TextBox txtBoxRenewalFee;
        private Guna.UI2.WinForms.Guna2Button btnRenew;
        private Guna.UI2.WinForms.Guna2Button btnCancel;
        private ctrlMemberInfo ctrlMemberInfo1;
    }
}
