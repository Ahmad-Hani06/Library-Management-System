namespace Library_Management_System.Member
{
    partial class frmAddEditMember
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tbControl = new Guna.UI2.WinForms.Guna2TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.lblPersonStepHint = new System.Windows.Forms.Label();
            this.btnNext = new Guna.UI2.WinForms.Guna2Button();
            this.ctrlFindPerson1 = new clsBussinessLogic.ctrlFindPerson();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.pnlMembershipHeader = new System.Windows.Forms.Panel();
            this.pnlFeeCard = new System.Windows.Forms.Panel();
            this.lblFeeCurrency = new System.Windows.Forms.Label();
            this.lblFee = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblFeeCaption = new System.Windows.Forms.Label();
            this.lblHeaderSubtitle = new System.Windows.Forms.Label();
            this.lblHeaderTitle = new System.Windows.Forms.Label();
            this.pnlMemberCard = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            this.btnCancel = new Guna.UI2.WinForms.Guna2Button();
            this.btnSave = new Guna.UI2.WinForms.Guna2Button();
            this.pnlActionsLine = new System.Windows.Forms.Panel();
            this.pnlStatus = new System.Windows.Forms.Panel();
            this.lblStatusHint = new System.Windows.Forms.Label();
            this.chkBoxActiveation = new Guna.UI2.WinForms.Guna2CheckBox();
            this.lblStatusCaption = new System.Windows.Forms.Label();
            this.dateTimePickEndDate = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.dateTimePickStartDate = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.guna2HtmlLabel2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel6 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblPeriodTitle = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtBoxPersonID = new Guna.UI2.WinForms.Guna2TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlIdBadge = new System.Windows.Forms.Panel();
            this.txtBoxMemberID = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblIdCaption = new System.Windows.Forms.Label();
            this.lblCardSubtitle = new System.Windows.Forms.Label();
            this.lblCardTitle = new System.Windows.Forms.Label();
            this.tbControl.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.pnlMembershipHeader.SuspendLayout();
            this.pnlFeeCard.SuspendLayout();
            this.pnlMemberCard.SuspendLayout();
            this.pnlStatus.SuspendLayout();
            this.panel1.SuspendLayout();
            this.pnlIdBadge.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbControl
            // 
            this.tbControl.Alignment = System.Windows.Forms.TabAlignment.Left;
            this.tbControl.Controls.Add(this.tabPage1);
            this.tbControl.Controls.Add(this.tabPage2);
            this.tbControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbControl.ItemSize = new System.Drawing.Size(190, 54);
            this.tbControl.Location = new System.Drawing.Point(0, 0);
            this.tbControl.Name = "tbControl";
            this.tbControl.SelectedIndex = 0;
            this.tbControl.Size = new System.Drawing.Size(1150, 650);
            this.tbControl.TabButtonHoverState.BorderColor = System.Drawing.Color.Empty;
            this.tbControl.TabButtonHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(49)))), ((int)(((byte)(81)))));
            this.tbControl.TabButtonHoverState.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.tbControl.TabButtonHoverState.ForeColor = System.Drawing.Color.White;
            this.tbControl.TabButtonHoverState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(49)))), ((int)(((byte)(81)))));
            this.tbControl.TabButtonIdleState.BorderColor = System.Drawing.Color.Empty;
            this.tbControl.TabButtonIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(33)))), ((int)(((byte)(61)))));
            this.tbControl.TabButtonIdleState.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.tbControl.TabButtonIdleState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(184)))), ((int)(((byte)(209)))));
            this.tbControl.TabButtonIdleState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(33)))), ((int)(((byte)(61)))));
            this.tbControl.TabButtonSelectedState.BorderColor = System.Drawing.Color.Empty;
            this.tbControl.TabButtonSelectedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(43)))), ((int)(((byte)(75)))));
            this.tbControl.TabButtonSelectedState.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.tbControl.TabButtonSelectedState.ForeColor = System.Drawing.Color.White;
            this.tbControl.TabButtonSelectedState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(209)))), ((int)(((byte)(197)))));
            this.tbControl.TabButtonSize = new System.Drawing.Size(190, 54);
            this.tbControl.TabIndex = 0;
            this.tbControl.TabMenuBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(33)))), ((int)(((byte)(61)))));
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(245)))), ((int)(((byte)(249)))));
            this.tabPage1.Controls.Add(this.lblPersonStepHint);
            this.tabPage1.Controls.Add(this.btnNext);
            this.tabPage1.Controls.Add(this.ctrlFindPerson1);
            this.tabPage1.Location = new System.Drawing.Point(194, 4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(952, 642);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "1   Select Person";
            // 
            // lblPersonStepHint
            // 
            this.lblPersonStepHint.AutoSize = true;
            this.lblPersonStepHint.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblPersonStepHint.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(127)))), ((int)(((byte)(151)))));
            this.lblPersonStepHint.Location = new System.Drawing.Point(38, 592);
            this.lblPersonStepHint.Name = "lblPersonStepHint";
            this.lblPersonStepHint.Size = new System.Drawing.Size(336, 15);
            this.lblPersonStepHint.TabIndex = 1;
            this.lblPersonStepHint.Text = "Choose a person, then continue to configure their membership.";
            // 
            // btnNext
            // 
            this.btnNext.BorderRadius = 9;
            this.btnNext.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnNext.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnNext.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(211)))), ((int)(((byte)(224)))));
            this.btnNext.DisabledState.ForeColor = System.Drawing.Color.White;
            this.btnNext.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(166)))), ((int)(((byte)(154)))));
            this.btnNext.Font = new System.Drawing.Font("Segoe UI Semibold", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnNext.ForeColor = System.Drawing.Color.White;
            this.btnNext.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(132)))), ((int)(((byte)(122)))));
            this.btnNext.Location = new System.Drawing.Point(761, 578);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(150, 42);
            this.btnNext.TabIndex = 2;
            this.btnNext.Text = "Continue  >";
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // ctrlFindPerson1
            // 
            this.ctrlFindPerson1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(245)))), ((int)(((byte)(249)))));
            this.ctrlFindPerson1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ctrlFindPerson1.Location = new System.Drawing.Point(38, 10);
            this.ctrlFindPerson1.Name = "ctrlFindPerson1";
            this.ctrlFindPerson1.PersonID = 0;
            this.ctrlFindPerson1.Size = new System.Drawing.Size(836, 546);
            this.ctrlFindPerson1.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(245)))), ((int)(((byte)(249)))));
            this.tabPage2.Controls.Add(this.pnlMemberCard);
            this.tabPage2.Controls.Add(this.pnlMembershipHeader);
            this.tabPage2.Location = new System.Drawing.Point(194, 4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(952, 642);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "2   Membership";
            // 
            // pnlMembershipHeader
            // 
            this.pnlMembershipHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(33)))), ((int)(((byte)(61)))));
            this.pnlMembershipHeader.Controls.Add(this.pnlFeeCard);
            this.pnlMembershipHeader.Controls.Add(this.lblHeaderSubtitle);
            this.pnlMembershipHeader.Controls.Add(this.lblHeaderTitle);
            this.pnlMembershipHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlMembershipHeader.Location = new System.Drawing.Point(3, 3);
            this.pnlMembershipHeader.Name = "pnlMembershipHeader";
            this.pnlMembershipHeader.Size = new System.Drawing.Size(946, 108);
            this.pnlMembershipHeader.TabIndex = 0;
            // 
            // pnlFeeCard
            // 
            this.pnlFeeCard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(49)))), ((int)(((byte)(81)))));
            this.pnlFeeCard.Controls.Add(this.lblFeeCurrency);
            this.pnlFeeCard.Controls.Add(this.lblFee);
            this.pnlFeeCard.Controls.Add(this.lblFeeCaption);
            this.pnlFeeCard.Location = new System.Drawing.Point(708, 19);
            this.pnlFeeCard.Name = "pnlFeeCard";
            this.pnlFeeCard.Size = new System.Drawing.Size(205, 70);
            this.pnlFeeCard.TabIndex = 2;
            // 
            // lblFeeCurrency
            // 
            this.lblFeeCurrency.AutoSize = true;
            this.lblFeeCurrency.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.lblFeeCurrency.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(184)))), ((int)(((byte)(209)))));
            this.lblFeeCurrency.Location = new System.Drawing.Point(148, 37);
            this.lblFeeCurrency.Name = "lblFeeCurrency";
            this.lblFeeCurrency.Size = new System.Drawing.Size(29, 15);
            this.lblFeeCurrency.TabIndex = 2;
            this.lblFeeCurrency.Text = "JOD";
            // 
            // lblFee
            // 
            this.lblFee.BackColor = System.Drawing.Color.Transparent;
            this.lblFee.Font = new System.Drawing.Font("Segoe UI Semibold", 17F, System.Drawing.FontStyle.Bold);
            this.lblFee.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(209)))), ((int)(((byte)(197)))));
            this.lblFee.Location = new System.Drawing.Point(17, 27);
            this.lblFee.Name = "lblFee";
            this.lblFee.Size = new System.Drawing.Size(14, 33);
            this.lblFee.TabIndex = 1;
            this.lblFee.Text = "0";
            // 
            // lblFeeCaption
            // 
            this.lblFeeCaption.AutoSize = true;
            this.lblFeeCaption.Font = new System.Drawing.Font("Segoe UI Semibold", 8F, System.Drawing.FontStyle.Bold);
            this.lblFeeCaption.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(184)))), ((int)(((byte)(209)))));
            this.lblFeeCaption.Location = new System.Drawing.Point(16, 10);
            this.lblFeeCaption.Name = "lblFeeCaption";
            this.lblFeeCaption.Size = new System.Drawing.Size(98, 13);
            this.lblFeeCaption.TabIndex = 0;
            this.lblFeeCaption.Text = "MEMBERSHIP FEE";
            // 
            // lblHeaderSubtitle
            // 
            this.lblHeaderSubtitle.AutoSize = true;
            this.lblHeaderSubtitle.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblHeaderSubtitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(184)))), ((int)(((byte)(209)))));
            this.lblHeaderSubtitle.Location = new System.Drawing.Point(29, 64);
            this.lblHeaderSubtitle.Name = "lblHeaderSubtitle";
            this.lblHeaderSubtitle.Size = new System.Drawing.Size(336, 17);
            this.lblHeaderSubtitle.TabIndex = 1;
            this.lblHeaderSubtitle.Text = "Set the membership period and review the account status.";
            // 
            // lblHeaderTitle
            // 
            this.lblHeaderTitle.AutoSize = true;
            this.lblHeaderTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 19F, System.Drawing.FontStyle.Bold);
            this.lblHeaderTitle.ForeColor = System.Drawing.Color.White;
            this.lblHeaderTitle.Location = new System.Drawing.Point(26, 24);
            this.lblHeaderTitle.Name = "lblHeaderTitle";
            this.lblHeaderTitle.Size = new System.Drawing.Size(251, 36);
            this.lblHeaderTitle.TabIndex = 0;
            this.lblHeaderTitle.Text = "Membership Details";
            // 
            // pnlMemberCard
            // 
            this.pnlMemberCard.BorderRadius = 14;
            this.pnlMemberCard.Controls.Add(this.btnCancel);
            this.pnlMemberCard.Controls.Add(this.btnSave);
            this.pnlMemberCard.Controls.Add(this.pnlActionsLine);
            this.pnlMemberCard.Controls.Add(this.pnlStatus);
            this.pnlMemberCard.Controls.Add(this.dateTimePickEndDate);
            this.pnlMemberCard.Controls.Add(this.dateTimePickStartDate);
            this.pnlMemberCard.Controls.Add(this.guna2HtmlLabel2);
            this.pnlMemberCard.Controls.Add(this.guna2HtmlLabel6);
            this.pnlMemberCard.Controls.Add(this.lblPeriodTitle);
            this.pnlMemberCard.Controls.Add(this.panel1);
            this.pnlMemberCard.Controls.Add(this.pnlIdBadge);
            this.pnlMemberCard.Controls.Add(this.lblCardSubtitle);
            this.pnlMemberCard.Controls.Add(this.lblCardTitle);
            this.pnlMemberCard.FillColor = System.Drawing.Color.White;
            this.pnlMemberCard.FillColor2 = System.Drawing.Color.White;
            this.pnlMemberCard.FillColor3 = System.Drawing.Color.White;
            this.pnlMemberCard.FillColor4 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(255)))));
            this.pnlMemberCard.Location = new System.Drawing.Point(30, 128);
            this.pnlMemberCard.Name = "pnlMemberCard";
            this.pnlMemberCard.Size = new System.Drawing.Size(892, 470);
            this.pnlMemberCard.TabIndex = 1;
            // 
            // btnCancel
            // 
            this.btnCancel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(225)))), ((int)(((byte)(236)))));
            this.btnCancel.BorderRadius = 9;
            this.btnCancel.BorderThickness = 1;
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnCancel.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnCancel.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCancel.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnCancel.FillColor = System.Drawing.Color.White;
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI Semibold", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnCancel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(92)))), ((int)(((byte)(115)))));
            this.btnCancel.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(247)))), ((int)(((byte)(251)))));
            this.btnCancel.Location = new System.Drawing.Point(615, 405);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(108, 42);
            this.btnCancel.TabIndex = 6;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.BorderRadius = 9;
            this.btnSave.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSave.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSave.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSave.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSave.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(166)))), ((int)(((byte)(154)))));
            this.btnSave.Font = new System.Drawing.Font("Segoe UI Semibold", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(132)))), ((int)(((byte)(122)))));
            this.btnSave.Location = new System.Drawing.Point(735, 405);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(129, 42);
            this.btnSave.TabIndex = 5;
            this.btnSave.Text = "Save Member";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // pnlActionsLine
            // 
            this.pnlActionsLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(239)))), ((int)(((byte)(246)))));
            this.pnlActionsLine.Location = new System.Drawing.Point(28, 382);
            this.pnlActionsLine.Name = "pnlActionsLine";
            this.pnlActionsLine.Size = new System.Drawing.Size(836, 1);
            this.pnlActionsLine.TabIndex = 12;
            // 
            // pnlStatus
            // 
            this.pnlStatus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(251)))), ((int)(((byte)(250)))));
            this.pnlStatus.Controls.Add(this.lblStatusHint);
            this.pnlStatus.Controls.Add(this.chkBoxActiveation);
            this.pnlStatus.Controls.Add(this.lblStatusCaption);
            this.pnlStatus.Location = new System.Drawing.Point(28, 302);
            this.pnlStatus.Name = "pnlStatus";
            this.pnlStatus.Size = new System.Drawing.Size(836, 60);
            this.pnlStatus.TabIndex = 11;
            // 
            // lblStatusHint
            // 
            this.lblStatusHint.AutoSize = true;
            this.lblStatusHint.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.lblStatusHint.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(127)))), ((int)(((byte)(151)))));
            this.lblStatusHint.Location = new System.Drawing.Point(110, 33);
            this.lblStatusHint.Name = "lblStatusHint";
            this.lblStatusHint.Size = new System.Drawing.Size(342, 15);
            this.lblStatusHint.TabIndex = 2;
            this.lblStatusHint.Text = "New memberships are activated automatically after saving.";
            // 
            // chkBoxActiveation
            // 
            this.chkBoxActiveation.AutoSize = true;
            this.chkBoxActiveation.Checked = true;
            this.chkBoxActiveation.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(166)))), ((int)(((byte)(154)))));
            this.chkBoxActiveation.CheckedState.BorderRadius = 3;
            this.chkBoxActiveation.CheckedState.BorderThickness = 0;
            this.chkBoxActiveation.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(166)))), ((int)(((byte)(154)))));
            this.chkBoxActiveation.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkBoxActiveation.Enabled = false;
            this.chkBoxActiveation.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.chkBoxActiveation.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(126)))), ((int)(((byte)(119)))));
            this.chkBoxActiveation.Location = new System.Drawing.Point(699, 20);
            this.chkBoxActiveation.Name = "chkBoxActiveation";
            this.chkBoxActiveation.Size = new System.Drawing.Size(108, 19);
            this.chkBoxActiveation.TabIndex = 4;
            this.chkBoxActiveation.Text = "Active member";
            this.chkBoxActiveation.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.chkBoxActiveation.UncheckedState.BorderRadius = 3;
            this.chkBoxActiveation.UncheckedState.BorderThickness = 1;
            this.chkBoxActiveation.UncheckedState.FillColor = System.Drawing.Color.White;
            // 
            // lblStatusCaption
            // 
            this.lblStatusCaption.AutoSize = true;
            this.lblStatusCaption.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.lblStatusCaption.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(126)))), ((int)(((byte)(119)))));
            this.lblStatusCaption.Location = new System.Drawing.Point(18, 22);
            this.lblStatusCaption.Name = "lblStatusCaption";
            this.lblStatusCaption.Size = new System.Drawing.Size(75, 15);
            this.lblStatusCaption.TabIndex = 0;
            this.lblStatusCaption.Text = "Membership";
            // 
            // dateTimePickEndDate
            // 
            this.dateTimePickEndDate.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(227)))), ((int)(((byte)(238)))));
            this.dateTimePickEndDate.BorderRadius = 8;
            this.dateTimePickEndDate.BorderThickness = 1;
            this.dateTimePickEndDate.Checked = true;
            this.dateTimePickEndDate.FillColor = System.Drawing.Color.White;
            this.dateTimePickEndDate.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.dateTimePickEndDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(57)))), ((int)(((byte)(78)))));
            this.dateTimePickEndDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickEndDate.Location = new System.Drawing.Point(464, 236);
            this.dateTimePickEndDate.MaxDate = new System.DateTime(2109, 12, 25, 23, 59, 59, 999);
            this.dateTimePickEndDate.MinDate = new System.DateTime(2019, 1, 25, 23, 59, 59, 999);
            this.dateTimePickEndDate.Name = "dateTimePickEndDate";
            this.dateTimePickEndDate.Size = new System.Drawing.Size(400, 44);
            this.dateTimePickEndDate.TabIndex = 3;
            this.dateTimePickEndDate.Value = new System.DateTime(2026, 8, 9, 0, 0, 0, 0);
            // 
            // dateTimePickStartDate
            // 
            this.dateTimePickStartDate.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(227)))), ((int)(((byte)(238)))));
            this.dateTimePickStartDate.BorderRadius = 8;
            this.dateTimePickStartDate.BorderThickness = 1;
            this.dateTimePickStartDate.Checked = true;
            this.dateTimePickStartDate.FillColor = System.Drawing.Color.White;
            this.dateTimePickStartDate.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.dateTimePickStartDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(57)))), ((int)(((byte)(78)))));
            this.dateTimePickStartDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickStartDate.Location = new System.Drawing.Point(28, 236);
            this.dateTimePickStartDate.MaxDate = new System.DateTime(2032, 3, 25, 23, 59, 59, 0);
            this.dateTimePickStartDate.MinDate = new System.DateTime(2023, 1, 25, 23, 59, 59, 999);
            this.dateTimePickStartDate.Name = "dateTimePickStartDate";
            this.dateTimePickStartDate.Size = new System.Drawing.Size(400, 44);
            this.dateTimePickStartDate.TabIndex = 2;
            this.dateTimePickStartDate.Value = new System.DateTime(2029, 12, 25, 23, 59, 59, 0);
            // 
            // guna2HtmlLabel2
            // 
            this.guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel2.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.guna2HtmlLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(85)))), ((int)(((byte)(108)))));
            this.guna2HtmlLabel2.Location = new System.Drawing.Point(464, 213);
            this.guna2HtmlLabel2.Name = "guna2HtmlLabel2";
            this.guna2HtmlLabel2.Size = new System.Drawing.Size(51, 17);
            this.guna2HtmlLabel2.TabIndex = 9;
            this.guna2HtmlLabel2.Text = "End date";
            // 
            // guna2HtmlLabel6
            // 
            this.guna2HtmlLabel6.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel6.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.guna2HtmlLabel6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(85)))), ((int)(((byte)(108)))));
            this.guna2HtmlLabel6.Location = new System.Drawing.Point(28, 213);
            this.guna2HtmlLabel6.Name = "guna2HtmlLabel6";
            this.guna2HtmlLabel6.Size = new System.Drawing.Size(56, 17);
            this.guna2HtmlLabel6.TabIndex = 8;
            this.guna2HtmlLabel6.Text = "Start date";
            // 
            // lblPeriodTitle
            // 
            this.lblPeriodTitle.AutoSize = true;
            this.lblPeriodTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.lblPeriodTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(33)))), ((int)(((byte)(61)))));
            this.lblPeriodTitle.Location = new System.Drawing.Point(25, 181);
            this.lblPeriodTitle.Name = "lblPeriodTitle";
            this.lblPeriodTitle.Size = new System.Drawing.Size(131, 19);
            this.lblPeriodTitle.TabIndex = 7;
            this.lblPeriodTitle.Text = "Membership period";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.txtBoxPersonID);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(464, 91);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(400, 66);
            this.panel1.TabIndex = 6;
            // 
            // txtBoxPersonID
            // 
            this.txtBoxPersonID.BorderThickness = 0;
            this.txtBoxPersonID.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtBoxPersonID.DefaultText = "";
            this.txtBoxPersonID.DisabledState.BorderColor = System.Drawing.Color.Transparent;
            this.txtBoxPersonID.DisabledState.FillColor = System.Drawing.Color.Transparent;
            this.txtBoxPersonID.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(94)))), ((int)(((byte)(159)))));
            this.txtBoxPersonID.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.txtBoxPersonID.Font = new System.Drawing.Font("Segoe UI Semibold", 13F, System.Drawing.FontStyle.Bold);
            this.txtBoxPersonID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(94)))), ((int)(((byte)(159)))));
            this.txtBoxPersonID.Location = new System.Drawing.Point(264, 20);
            this.txtBoxPersonID.Name = "txtBoxPersonID";
            this.txtBoxPersonID.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(94)))), ((int)(((byte)(159)))));
            this.txtBoxPersonID.PlaceholderText = "—";
            this.txtBoxPersonID.ReadOnly = true;
            this.txtBoxPersonID.SelectedText = "";
            this.txtBoxPersonID.Size = new System.Drawing.Size(116, 30);
            this.txtBoxPersonID.TabIndex = 1;
            this.txtBoxPersonID.TabStop = false;
            this.txtBoxPersonID.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(112)))), ((int)(((byte)(170)))));
            this.label1.Location = new System.Drawing.Point(17, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Person ID";
            // 
            // pnlIdBadge
            // 
            this.pnlIdBadge.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(250)))), ((int)(((byte)(248)))));
            this.pnlIdBadge.Controls.Add(this.txtBoxMemberID);
            this.pnlIdBadge.Controls.Add(this.lblIdCaption);
            this.pnlIdBadge.Location = new System.Drawing.Point(28, 91);
            this.pnlIdBadge.Name = "pnlIdBadge";
            this.pnlIdBadge.Size = new System.Drawing.Size(400, 66);
            this.pnlIdBadge.TabIndex = 5;
            // 
            // txtBoxMemberID
            // 
            this.txtBoxMemberID.BorderThickness = 0;
            this.txtBoxMemberID.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtBoxMemberID.DefaultText = "";
            this.txtBoxMemberID.DisabledState.BorderColor = System.Drawing.Color.Transparent;
            this.txtBoxMemberID.DisabledState.FillColor = System.Drawing.Color.Transparent;
            this.txtBoxMemberID.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(126)))), ((int)(((byte)(119)))));
            this.txtBoxMemberID.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(250)))), ((int)(((byte)(248)))));
            this.txtBoxMemberID.Font = new System.Drawing.Font("Segoe UI Semibold", 13F, System.Drawing.FontStyle.Bold);
            this.txtBoxMemberID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(126)))), ((int)(((byte)(119)))));
            this.txtBoxMemberID.Location = new System.Drawing.Point(264, 20);
            this.txtBoxMemberID.Name = "txtBoxMemberID";
            this.txtBoxMemberID.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(126)))), ((int)(((byte)(119)))));
            this.txtBoxMemberID.PlaceholderText = "NEW";
            this.txtBoxMemberID.ReadOnly = true;
            this.txtBoxMemberID.SelectedText = "";
            this.txtBoxMemberID.Size = new System.Drawing.Size(116, 30);
            this.txtBoxMemberID.TabIndex = 1;
            this.txtBoxMemberID.TabStop = false;
            this.txtBoxMemberID.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblIdCaption
            // 
            this.lblIdCaption.AutoSize = true;
            this.lblIdCaption.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.lblIdCaption.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(126)))), ((int)(((byte)(119)))));
            this.lblIdCaption.Location = new System.Drawing.Point(17, 25);
            this.lblIdCaption.Name = "lblIdCaption";
            this.lblIdCaption.Size = new System.Drawing.Size(68, 15);
            this.lblIdCaption.TabIndex = 0;
            this.lblIdCaption.Text = "Member ID";
            // 
            // lblCardSubtitle
            // 
            this.lblCardSubtitle.AutoSize = true;
            this.lblCardSubtitle.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.lblCardSubtitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(139)))), ((int)(((byte)(162)))));
            this.lblCardSubtitle.Location = new System.Drawing.Point(26, 54);
            this.lblCardSubtitle.Name = "lblCardSubtitle";
            this.lblCardSubtitle.Size = new System.Drawing.Size(313, 15);
            this.lblCardSubtitle.TabIndex = 1;
            this.lblCardSubtitle.Text = "Review the linked records before saving this membership.";
            // 
            // lblCardTitle
            // 
            this.lblCardTitle.AutoSize = true;
            this.lblCardTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 13F, System.Drawing.FontStyle.Bold);
            this.lblCardTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(33)))), ((int)(((byte)(61)))));
            this.lblCardTitle.Location = new System.Drawing.Point(24, 24);
            this.lblCardTitle.Name = "lblCardTitle";
            this.lblCardTitle.Size = new System.Drawing.Size(142, 25);
            this.lblCardTitle.TabIndex = 0;
            this.lblCardTitle.Text = "Account details";
            // 
            // frmAddEditMember
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(245)))), ((int)(((byte)(249)))));
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(1150, 650);
            this.Controls.Add(this.tbControl);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmAddEditMember";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add / Edit Member";
            this.Load += new System.EventHandler(this.frmAddEditMember_Load);
            this.tbControl.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.pnlMembershipHeader.ResumeLayout(false);
            this.pnlMembershipHeader.PerformLayout();
            this.pnlFeeCard.ResumeLayout(false);
            this.pnlFeeCard.PerformLayout();
            this.pnlMemberCard.ResumeLayout(false);
            this.pnlMemberCard.PerformLayout();
            this.pnlStatus.ResumeLayout(false);
            this.pnlStatus.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnlIdBadge.ResumeLayout(false);
            this.pnlIdBadge.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2TabControl tbControl;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label lblPersonStepHint;
        private Guna.UI2.WinForms.Guna2Button btnNext;
        private clsBussinessLogic.ctrlFindPerson ctrlFindPerson1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Panel pnlMembershipHeader;
        private System.Windows.Forms.Panel pnlFeeCard;
        private System.Windows.Forms.Label lblFeeCurrency;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblFee;
        private System.Windows.Forms.Label lblFeeCaption;
        private System.Windows.Forms.Label lblHeaderSubtitle;
        private System.Windows.Forms.Label lblHeaderTitle;
        private Guna.UI2.WinForms.Guna2CustomGradientPanel pnlMemberCard;
        private Guna.UI2.WinForms.Guna2Button btnCancel;
        private Guna.UI2.WinForms.Guna2Button btnSave;
        private System.Windows.Forms.Panel pnlActionsLine;
        private System.Windows.Forms.Panel pnlStatus;
        private System.Windows.Forms.Label lblStatusHint;
        private Guna.UI2.WinForms.Guna2CheckBox chkBoxActiveation;
        private System.Windows.Forms.Label lblStatusCaption;
        private Guna.UI2.WinForms.Guna2DateTimePicker dateTimePickEndDate;
        private Guna.UI2.WinForms.Guna2DateTimePicker dateTimePickStartDate;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel2;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel6;
        private System.Windows.Forms.Label lblPeriodTitle;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2TextBox txtBoxPersonID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnlIdBadge;
        private Guna.UI2.WinForms.Guna2TextBox txtBoxMemberID;
        private System.Windows.Forms.Label lblIdCaption;
        private System.Windows.Forms.Label lblCardSubtitle;
        private System.Windows.Forms.Label lblCardTitle;
    }
}
