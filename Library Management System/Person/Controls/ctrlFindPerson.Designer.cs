namespace clsBussinessLogic
{
    partial class ctrlFindPerson
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        private void InitializeComponent()
        {
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.lblHeaderIcon = new System.Windows.Forms.Label();
            this.lblSubtitle = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.pnlSearch = new System.Windows.Forms.Panel();
            this.btnAdd = new Guna.UI2.WinForms.Guna2Button();
            this.btnClear = new Guna.UI2.WinForms.Guna2Button();
            this.btnFind = new Guna.UI2.WinForms.Guna2Button();
            this.txtBoxPersonID = new System.Windows.Forms.TextBox();
            this.pnlSearchLine = new System.Windows.Forms.Panel();
            this.lblSearchHint = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblSearchIcon = new System.Windows.Forms.Label();
            this.pnlDetails = new System.Windows.Forms.Panel();
            this.pnlAccent = new System.Windows.Forms.Panel();
            this.lblDetailsSubtitle = new System.Windows.Forms.Label();
            this.lblDetailsTitle = new System.Windows.Forms.Label();
            this.lblAvatar = new System.Windows.Forms.Label();
            this.pnlDivider = new System.Windows.Forms.Panel();
            this.txtBoxCreatedAt = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.DateTimePickerDateOfBirth = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.txtBoxEmail = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtBoxPhone = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtBoxAddress = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBoxFullName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pnlHeader.SuspendLayout();
            this.pnlSearch.SuspendLayout();
            this.pnlDetails.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(33)))), ((int)(((byte)(61)))));
            this.pnlHeader.Controls.Add(this.lblHeaderIcon);
            this.pnlHeader.Controls.Add(this.lblSubtitle);
            this.pnlHeader.Controls.Add(this.lblTitle);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(836, 95);
            this.pnlHeader.TabIndex = 0;
            // 
            // lblHeaderIcon
            // 
            this.lblHeaderIcon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(63)))), ((int)(((byte)(105)))));
            this.lblHeaderIcon.Font = new System.Drawing.Font("Segoe UI Symbol", 22F);
            this.lblHeaderIcon.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(209)))), ((int)(((byte)(197)))));
            this.lblHeaderIcon.Location = new System.Drawing.Point(684, 20);
            this.lblHeaderIcon.Name = "lblHeaderIcon";
            this.lblHeaderIcon.Size = new System.Drawing.Size(52, 52);
            this.lblHeaderIcon.TabIndex = 2;
            this.lblHeaderIcon.Text = "♙";
            this.lblHeaderIcon.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSubtitle
            // 
            this.lblSubtitle.AutoSize = true;
            this.lblSubtitle.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblSubtitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(184)))), ((int)(((byte)(209)))));
            this.lblSubtitle.Location = new System.Drawing.Point(27, 56);
            this.lblSubtitle.Name = "lblSubtitle";
            this.lblSubtitle.Size = new System.Drawing.Size(277, 17);
            this.lblSubtitle.TabIndex = 1;
            this.lblSubtitle.Text = "Find a member and review their profile details";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(24, 20);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(162, 32);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Person Finder";
            // 
            // pnlSearch
            // 
            this.pnlSearch.BackColor = System.Drawing.Color.White;
            this.pnlSearch.Controls.Add(this.btnAdd);
            this.pnlSearch.Controls.Add(this.btnClear);
            this.pnlSearch.Controls.Add(this.btnFind);
            this.pnlSearch.Controls.Add(this.txtBoxPersonID);
            this.pnlSearch.Controls.Add(this.pnlSearchLine);
            this.pnlSearch.Controls.Add(this.lblSearchHint);
            this.pnlSearch.Controls.Add(this.label1);
            this.pnlSearch.Controls.Add(this.lblSearchIcon);
            this.pnlSearch.Location = new System.Drawing.Point(24, 112);
            this.pnlSearch.Name = "pnlSearch";
            this.pnlSearch.Size = new System.Drawing.Size(792, 92);
            this.pnlSearch.TabIndex = 1;
            // 
            // btnAdd
            // 
            this.btnAdd.BorderRadius = 8;
            this.btnAdd.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAdd.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAdd.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAdd.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAdd.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(166)))), ((int)(((byte)(154)))));
            this.btnAdd.Font = new System.Drawing.Font("Segoe UI Semibold", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(682, 31);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(96, 39);
            this.btnAdd.TabIndex = 6;
            this.btnAdd.Text = "Add";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnClear
            // 
            this.btnClear.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(226)))), ((int)(((byte)(239)))));
            this.btnClear.BorderRadius = 8;
            this.btnClear.BorderThickness = 1;
            this.btnClear.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnClear.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnClear.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnClear.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnClear.FillColor = System.Drawing.Color.White;
            this.btnClear.Font = new System.Drawing.Font("Segoe UI Semibold", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnClear.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(95)))), ((int)(((byte)(120)))));
            this.btnClear.Location = new System.Drawing.Point(598, 31);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(78, 39);
            this.btnClear.TabIndex = 3;
            this.btnClear.Text = "Clear";
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnFind
            // 
            this.btnFind.BorderRadius = 8;
            this.btnFind.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnFind.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnFind.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnFind.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnFind.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(166)))), ((int)(((byte)(154)))));
            this.btnFind.Font = new System.Drawing.Font("Segoe UI Semibold", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnFind.ForeColor = System.Drawing.Color.White;
            this.btnFind.Location = new System.Drawing.Point(496, 31);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(96, 39);
            this.btnFind.TabIndex = 2;
            this.btnFind.Text = "Find Person";
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // txtBoxPersonID
            // 
            this.txtBoxPersonID.BackColor = System.Drawing.Color.White;
            this.txtBoxPersonID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBoxPersonID.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            this.txtBoxPersonID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(33)))), ((int)(((byte)(61)))));
            this.txtBoxPersonID.Location = new System.Drawing.Point(214, 39);
            this.txtBoxPersonID.Name = "txtBoxPersonID";
            this.txtBoxPersonID.Size = new System.Drawing.Size(265, 20);
            this.txtBoxPersonID.TabIndex = 1;
            this.txtBoxPersonID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBoxPersonID_KeyPress);
            // 
            // pnlSearchLine
            // 
            this.pnlSearchLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(209)))), ((int)(((byte)(197)))));
            this.pnlSearchLine.Location = new System.Drawing.Point(214, 64);
            this.pnlSearchLine.Name = "pnlSearchLine";
            this.pnlSearchLine.Size = new System.Drawing.Size(265, 2);
            this.pnlSearchLine.TabIndex = 5;
            // 
            // lblSearchHint
            // 
            this.lblSearchHint.AutoSize = true;
            this.lblSearchHint.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.lblSearchHint.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(156)))), ((int)(((byte)(177)))));
            this.lblSearchHint.Location = new System.Drawing.Point(76, 54);
            this.lblSearchHint.Name = "lblSearchHint";
            this.lblSearchHint.Size = new System.Drawing.Size(101, 13);
            this.lblSearchHint.TabIndex = 4;
            this.lblSearchHint.Text = "Enter a numeric ID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(33)))), ((int)(((byte)(61)))));
            this.label1.Location = new System.Drawing.Point(75, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "Person ID";
            // 
            // lblSearchIcon
            // 
            this.lblSearchIcon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(250)))), ((int)(((byte)(248)))));
            this.lblSearchIcon.Font = new System.Drawing.Font("Segoe UI Symbol", 17F);
            this.lblSearchIcon.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(166)))), ((int)(((byte)(154)))));
            this.lblSearchIcon.Location = new System.Drawing.Point(20, 24);
            this.lblSearchIcon.Name = "lblSearchIcon";
            this.lblSearchIcon.Size = new System.Drawing.Size(44, 44);
            this.lblSearchIcon.TabIndex = 0;
            this.lblSearchIcon.Text = "⌕";
            this.lblSearchIcon.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlDetails
            // 
            this.pnlDetails.BackColor = System.Drawing.Color.White;
            this.pnlDetails.Controls.Add(this.pnlAccent);
            this.pnlDetails.Controls.Add(this.lblDetailsSubtitle);
            this.pnlDetails.Controls.Add(this.lblDetailsTitle);
            this.pnlDetails.Controls.Add(this.lblAvatar);
            this.pnlDetails.Controls.Add(this.pnlDivider);
            this.pnlDetails.Controls.Add(this.txtBoxCreatedAt);
            this.pnlDetails.Controls.Add(this.label7);
            this.pnlDetails.Controls.Add(this.DateTimePickerDateOfBirth);
            this.pnlDetails.Controls.Add(this.label6);
            this.pnlDetails.Controls.Add(this.txtBoxEmail);
            this.pnlDetails.Controls.Add(this.label5);
            this.pnlDetails.Controls.Add(this.txtBoxPhone);
            this.pnlDetails.Controls.Add(this.label4);
            this.pnlDetails.Controls.Add(this.txtBoxAddress);
            this.pnlDetails.Controls.Add(this.label3);
            this.pnlDetails.Controls.Add(this.txtBoxFullName);
            this.pnlDetails.Controls.Add(this.label2);
            this.pnlDetails.Location = new System.Drawing.Point(24, 220);
            this.pnlDetails.Name = "pnlDetails";
            this.pnlDetails.Size = new System.Drawing.Size(712, 296);
            this.pnlDetails.TabIndex = 2;
            // 
            // pnlAccent
            // 
            this.pnlAccent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(209)))), ((int)(((byte)(197)))));
            this.pnlAccent.Location = new System.Drawing.Point(0, 0);
            this.pnlAccent.Name = "pnlAccent";
            this.pnlAccent.Size = new System.Drawing.Size(5, 296);
            this.pnlAccent.TabIndex = 16;
            // 
            // lblDetailsSubtitle
            // 
            this.lblDetailsSubtitle.AutoSize = true;
            this.lblDetailsSubtitle.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.lblDetailsSubtitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(156)))), ((int)(((byte)(177)))));
            this.lblDetailsSubtitle.Location = new System.Drawing.Point(78, 52);
            this.lblDetailsSubtitle.Name = "lblDetailsSubtitle";
            this.lblDetailsSubtitle.Size = new System.Drawing.Size(144, 15);
            this.lblDetailsSubtitle.TabIndex = 15;
            this.lblDetailsSubtitle.Text = "Member information card";
            // 
            // lblDetailsTitle
            // 
            this.lblDetailsTitle.AutoSize = true;
            this.lblDetailsTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 13F, System.Drawing.FontStyle.Bold);
            this.lblDetailsTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(33)))), ((int)(((byte)(61)))));
            this.lblDetailsTitle.Location = new System.Drawing.Point(77, 25);
            this.lblDetailsTitle.Name = "lblDetailsTitle";
            this.lblDetailsTitle.Size = new System.Drawing.Size(129, 25);
            this.lblDetailsTitle.TabIndex = 14;
            this.lblDetailsTitle.Text = "Profile Details";
            // 
            // lblAvatar
            // 
            this.lblAvatar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(250)))), ((int)(((byte)(248)))));
            this.lblAvatar.Font = new System.Drawing.Font("Segoe UI Symbol", 24F);
            this.lblAvatar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(166)))), ((int)(((byte)(154)))));
            this.lblAvatar.Location = new System.Drawing.Point(20, 20);
            this.lblAvatar.Name = "lblAvatar";
            this.lblAvatar.Size = new System.Drawing.Size(48, 48);
            this.lblAvatar.TabIndex = 13;
            this.lblAvatar.Text = "♙";
            this.lblAvatar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlDivider
            // 
            this.pnlDivider.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(247)))));
            this.pnlDivider.Location = new System.Drawing.Point(24, 82);
            this.pnlDivider.Name = "pnlDivider";
            this.pnlDivider.Size = new System.Drawing.Size(664, 1);
            this.pnlDivider.TabIndex = 12;
            // 
            // txtBoxCreatedAt
            // 
            this.txtBoxCreatedAt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(253)))));
            this.txtBoxCreatedAt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBoxCreatedAt.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.txtBoxCreatedAt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(71)))), ((int)(((byte)(94)))));
            this.txtBoxCreatedAt.Location = new System.Drawing.Point(373, 261);
            this.txtBoxCreatedAt.Name = "txtBoxCreatedAt";
            this.txtBoxCreatedAt.ReadOnly = true;
            this.txtBoxCreatedAt.Size = new System.Drawing.Size(315, 24);
            this.txtBoxCreatedAt.TabIndex = 17;
            this.txtBoxCreatedAt.TabStop = false;
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 7.5F, System.Drawing.FontStyle.Bold);
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(127)))), ((int)(((byte)(151)))));
            this.label7.Location = new System.Drawing.Point(373, 239);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 18);
            this.label7.TabIndex = 18;
            this.label7.Text = "CREATED AT";
            // 
            // DateTimePickerDateOfBirth
            // 
            this.DateTimePickerDateOfBirth.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(231)))), ((int)(((byte)(241)))));
            this.DateTimePickerDateOfBirth.BorderRadius = 5;
            this.DateTimePickerDateOfBirth.BorderThickness = 1;
            this.DateTimePickerDateOfBirth.Checked = true;
            this.DateTimePickerDateOfBirth.Enabled = false;
            this.DateTimePickerDateOfBirth.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(253)))));
            this.DateTimePickerDateOfBirth.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.DateTimePickerDateOfBirth.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(71)))), ((int)(((byte)(94)))));
            this.DateTimePickerDateOfBirth.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DateTimePickerDateOfBirth.Location = new System.Drawing.Point(28, 261);
            this.DateTimePickerDateOfBirth.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.DateTimePickerDateOfBirth.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.DateTimePickerDateOfBirth.Name = "DateTimePickerDateOfBirth";
            this.DateTimePickerDateOfBirth.Size = new System.Drawing.Size(300, 25);
            this.DateTimePickerDateOfBirth.TabIndex = 8;
            this.DateTimePickerDateOfBirth.Value = new System.DateTime(2026, 7, 26, 0, 0, 0, 0);
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 7.5F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(127)))), ((int)(((byte)(151)))));
            this.label6.Location = new System.Drawing.Point(28, 239);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(95, 18);
            this.label6.TabIndex = 19;
            this.label6.Text = "DATE OF BIRTH";
            // 
            // txtBoxEmail
            // 
            this.txtBoxEmail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(253)))));
            this.txtBoxEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBoxEmail.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.txtBoxEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(71)))), ((int)(((byte)(94)))));
            this.txtBoxEmail.Location = new System.Drawing.Point(373, 193);
            this.txtBoxEmail.Name = "txtBoxEmail";
            this.txtBoxEmail.ReadOnly = true;
            this.txtBoxEmail.Size = new System.Drawing.Size(315, 24);
            this.txtBoxEmail.TabIndex = 20;
            this.txtBoxEmail.TabStop = false;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 7.5F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(127)))), ((int)(((byte)(151)))));
            this.label5.Location = new System.Drawing.Point(373, 171);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 18);
            this.label5.TabIndex = 21;
            this.label5.Text = "EMAIL";
            // 
            // txtBoxPhone
            // 
            this.txtBoxPhone.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(253)))));
            this.txtBoxPhone.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBoxPhone.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.txtBoxPhone.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(71)))), ((int)(((byte)(94)))));
            this.txtBoxPhone.Location = new System.Drawing.Point(28, 193);
            this.txtBoxPhone.Name = "txtBoxPhone";
            this.txtBoxPhone.ReadOnly = true;
            this.txtBoxPhone.Size = new System.Drawing.Size(300, 24);
            this.txtBoxPhone.TabIndex = 22;
            this.txtBoxPhone.TabStop = false;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 7.5F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(127)))), ((int)(((byte)(151)))));
            this.label4.Location = new System.Drawing.Point(28, 171);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 18);
            this.label4.TabIndex = 23;
            this.label4.Text = "PHONE";
            // 
            // txtBoxAddress
            // 
            this.txtBoxAddress.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(253)))));
            this.txtBoxAddress.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBoxAddress.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.txtBoxAddress.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(71)))), ((int)(((byte)(94)))));
            this.txtBoxAddress.Location = new System.Drawing.Point(373, 125);
            this.txtBoxAddress.Name = "txtBoxAddress";
            this.txtBoxAddress.ReadOnly = true;
            this.txtBoxAddress.Size = new System.Drawing.Size(315, 24);
            this.txtBoxAddress.TabIndex = 24;
            this.txtBoxAddress.TabStop = false;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 7.5F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(127)))), ((int)(((byte)(151)))));
            this.label3.Location = new System.Drawing.Point(373, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 18);
            this.label3.TabIndex = 25;
            this.label3.Text = "ADDRESS";
            // 
            // txtBoxFullName
            // 
            this.txtBoxFullName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(253)))));
            this.txtBoxFullName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBoxFullName.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.txtBoxFullName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(71)))), ((int)(((byte)(94)))));
            this.txtBoxFullName.Location = new System.Drawing.Point(28, 125);
            this.txtBoxFullName.Name = "txtBoxFullName";
            this.txtBoxFullName.ReadOnly = true;
            this.txtBoxFullName.Size = new System.Drawing.Size(300, 24);
            this.txtBoxFullName.TabIndex = 26;
            this.txtBoxFullName.TabStop = false;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 7.5F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(127)))), ((int)(((byte)(151)))));
            this.label2.Location = new System.Drawing.Point(28, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 18);
            this.label2.TabIndex = 27;
            this.label2.Text = "FULL NAME";
            // 
            // ctrlFindPerson
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(245)))), ((int)(((byte)(249)))));
            this.Controls.Add(this.pnlDetails);
            this.Controls.Add(this.pnlSearch);
            this.Controls.Add(this.pnlHeader);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Name = "ctrlFindPerson";
            this.Size = new System.Drawing.Size(836, 546);
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.pnlSearch.ResumeLayout(false);
            this.pnlSearch.PerformLayout();
            this.pnlDetails.ResumeLayout(false);
            this.pnlDetails.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblHeaderIcon;
        private System.Windows.Forms.Label lblSubtitle;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel pnlSearch;
        private Guna.UI2.WinForms.Guna2Button btnClear;
        private Guna.UI2.WinForms.Guna2Button btnFind;
        private System.Windows.Forms.TextBox txtBoxPersonID;
        private System.Windows.Forms.Panel pnlSearchLine;
        private System.Windows.Forms.Label lblSearchHint;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblSearchIcon;
        private System.Windows.Forms.Panel pnlDetails;
        private System.Windows.Forms.Panel pnlAccent;
        private System.Windows.Forms.Label lblDetailsSubtitle;
        private System.Windows.Forms.Label lblDetailsTitle;
        private System.Windows.Forms.Label lblAvatar;
        private System.Windows.Forms.Panel pnlDivider;
        private System.Windows.Forms.TextBox txtBoxFullName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBoxAddress;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtBoxPhone;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtBoxEmail;
        private System.Windows.Forms.Label label5;
        private Guna.UI2.WinForms.Guna2DateTimePicker DateTimePickerDateOfBirth;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtBoxCreatedAt;
        private System.Windows.Forms.Label label7;
        private Guna.UI2.WinForms.Guna2Button btnAdd;
    }
}
