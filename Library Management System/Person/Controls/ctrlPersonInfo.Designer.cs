namespace Library_Management_System.Person
{
    partial class ctrlPersonInfo
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
            this.lbPersonID = new System.Windows.Forms.Label();
            this.lblPersonIdCaption = new System.Windows.Forms.Label();
            this.lblHeaderSubtitle = new System.Windows.Forms.Label();
            this.lblHeaderTitle = new System.Windows.Forms.Label();
            this.pnlProfileCard = new System.Windows.Forms.Panel();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblMemberType = new System.Windows.Forms.Label();
            this.lbName = new System.Windows.Forms.Label();
            this.lblAvatar = new System.Windows.Forms.Label();
            this.pnlAccent = new System.Windows.Forms.Panel();
            this.pnlDetailsCard = new System.Windows.Forms.Panel();
            this.lbCreatedAt = new System.Windows.Forms.Label();
            this.lblCreatedAt = new System.Windows.Forms.Label();
            this.lbDateOfBirth = new System.Windows.Forms.Label();
            this.lblDateOfBirth = new System.Windows.Forms.Label();
            this.pnlDivider3 = new System.Windows.Forms.Panel();
            this.lbEmail = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblPhoneValue = new System.Windows.Forms.Label();
            this.lblPhone = new System.Windows.Forms.Label();
            this.pnlDivider2 = new System.Windows.Forms.Panel();
            this.lbAddress = new System.Windows.Forms.Label();
            this.lblAddress = new System.Windows.Forms.Label();
            this.pnlDivider1 = new System.Windows.Forms.Panel();
            this.lblDetailsSubtitle = new System.Windows.Forms.Label();
            this.lblDetailsTitle = new System.Windows.Forms.Label();
            this.pnlHeader.SuspendLayout();
            this.pnlProfileCard.SuspendLayout();
            this.pnlDetailsCard.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(33)))), ((int)(((byte)(61)))));
            this.pnlHeader.Controls.Add(this.lbPersonID);
            this.pnlHeader.Controls.Add(this.lblPersonIdCaption);
            this.pnlHeader.Controls.Add(this.lblHeaderSubtitle);
            this.pnlHeader.Controls.Add(this.lblHeaderTitle);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(780, 104);
            this.pnlHeader.TabIndex = 0;
            // 
            // lbPersonID
            // 
            this.lbPersonID.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.lbPersonID.ForeColor = System.Drawing.Color.White;
            this.lbPersonID.Location = new System.Drawing.Point(614, 48);
            this.lbPersonID.Name = "lbPersonID";
            this.lbPersonID.Size = new System.Drawing.Size(132, 25);
            this.lbPersonID.TabIndex = 3;
            this.lbPersonID.Text = "#0000";
            this.lbPersonID.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblPersonIdCaption
            // 
            this.lblPersonIdCaption.Font = new System.Drawing.Font("Segoe UI Semibold", 7.5F, System.Drawing.FontStyle.Bold);
            this.lblPersonIdCaption.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(213)))), ((int)(((byte)(205)))));
            this.lblPersonIdCaption.Location = new System.Drawing.Point(614, 28);
            this.lblPersonIdCaption.Name = "lblPersonIdCaption";
            this.lblPersonIdCaption.Size = new System.Drawing.Size(132, 18);
            this.lblPersonIdCaption.TabIndex = 2;
            this.lblPersonIdCaption.Text = "PERSON ID";
            this.lblPersonIdCaption.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblHeaderSubtitle
            // 
            this.lblHeaderSubtitle.AutoSize = true;
            this.lblHeaderSubtitle.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblHeaderSubtitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(184)))), ((int)(((byte)(209)))));
            this.lblHeaderSubtitle.Location = new System.Drawing.Point(28, 62);
            this.lblHeaderSubtitle.Name = "lblHeaderSubtitle";
            this.lblHeaderSubtitle.Size = new System.Drawing.Size(249, 17);
            this.lblHeaderSubtitle.TabIndex = 1;
            this.lblHeaderSubtitle.Text = "A quick overview of this member\'s profile";
            // 
            // lblHeaderTitle
            // 
            this.lblHeaderTitle.AutoSize = true;
            this.lblHeaderTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold);
            this.lblHeaderTitle.ForeColor = System.Drawing.Color.White;
            this.lblHeaderTitle.Location = new System.Drawing.Point(25, 24);
            this.lblHeaderTitle.Name = "lblHeaderTitle";
            this.lblHeaderTitle.Size = new System.Drawing.Size(223, 32);
            this.lblHeaderTitle.TabIndex = 0;
            this.lblHeaderTitle.Text = "Person Information";
            // 
            // pnlProfileCard
            // 
            this.pnlProfileCard.BackColor = System.Drawing.Color.White;
            this.pnlProfileCard.Controls.Add(this.lblStatus);
            this.pnlProfileCard.Controls.Add(this.lblMemberType);
            this.pnlProfileCard.Controls.Add(this.lbName);
            this.pnlProfileCard.Controls.Add(this.lblAvatar);
            this.pnlProfileCard.Controls.Add(this.pnlAccent);
            this.pnlProfileCard.Location = new System.Drawing.Point(24, 128);
            this.pnlProfileCard.Name = "pnlProfileCard";
            this.pnlProfileCard.Size = new System.Drawing.Size(732, 116);
            this.pnlProfileCard.TabIndex = 1;
            // 
            // lblStatus
            // 
            this.lblStatus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(250)))), ((int)(((byte)(248)))));
            this.lblStatus.Font = new System.Drawing.Font("Segoe UI Semibold", 8F, System.Drawing.FontStyle.Bold);
            this.lblStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(133)))), ((int)(((byte)(123)))));
            this.lblStatus.Location = new System.Drawing.Point(606, 39);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(92, 30);
            this.lblStatus.TabIndex = 4;
            this.lblStatus.Text = "ACTIVE";
            this.lblStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblMemberType
            // 
            this.lblMemberType.AutoSize = true;
            this.lblMemberType.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblMemberType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(127)))), ((int)(((byte)(151)))));
            this.lblMemberType.Location = new System.Drawing.Point(116, 64);
            this.lblMemberType.Name = "lblMemberType";
            this.lblMemberType.Size = new System.Drawing.Size(91, 15);
            this.lblMemberType.TabIndex = 3;
            this.lblMemberType.Text = "Library member";
            // 
            // lbName
            // 
            this.lbName.AutoEllipsis = true;
            this.lbName.Font = new System.Drawing.Font("Segoe UI Semibold", 16F, System.Drawing.FontStyle.Bold);
            this.lbName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(33)))), ((int)(((byte)(61)))));
            this.lbName.Location = new System.Drawing.Point(113, 31);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(450, 32);
            this.lbName.TabIndex = 2;
            this.lbName.Text = "Person full name";
            // 
            // lblAvatar
            // 
            this.lblAvatar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(250)))), ((int)(((byte)(248)))));
            this.lblAvatar.Font = new System.Drawing.Font("Segoe UI Semibold", 24F, System.Drawing.FontStyle.Bold);
            this.lblAvatar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(166)))), ((int)(((byte)(154)))));
            this.lblAvatar.Location = new System.Drawing.Point(28, 22);
            this.lblAvatar.Name = "lblAvatar";
            this.lblAvatar.Size = new System.Drawing.Size(68, 68);
            this.lblAvatar.TabIndex = 1;
            this.lblAvatar.Text = "P";
            this.lblAvatar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlAccent
            // 
            this.pnlAccent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(209)))), ((int)(((byte)(197)))));
            this.pnlAccent.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlAccent.Location = new System.Drawing.Point(0, 0);
            this.pnlAccent.Name = "pnlAccent";
            this.pnlAccent.Size = new System.Drawing.Size(5, 116);
            this.pnlAccent.TabIndex = 0;
            // 
            // pnlDetailsCard
            // 
            this.pnlDetailsCard.BackColor = System.Drawing.Color.White;
            this.pnlDetailsCard.Controls.Add(this.lbCreatedAt);
            this.pnlDetailsCard.Controls.Add(this.lblCreatedAt);
            this.pnlDetailsCard.Controls.Add(this.lbDateOfBirth);
            this.pnlDetailsCard.Controls.Add(this.lblDateOfBirth);
            this.pnlDetailsCard.Controls.Add(this.pnlDivider3);
            this.pnlDetailsCard.Controls.Add(this.lbEmail);
            this.pnlDetailsCard.Controls.Add(this.lblEmail);
            this.pnlDetailsCard.Controls.Add(this.lblPhoneValue);
            this.pnlDetailsCard.Controls.Add(this.lblPhone);
            this.pnlDetailsCard.Controls.Add(this.pnlDivider2);
            this.pnlDetailsCard.Controls.Add(this.lbAddress);
            this.pnlDetailsCard.Controls.Add(this.lblAddress);
            this.pnlDetailsCard.Controls.Add(this.pnlDivider1);
            this.pnlDetailsCard.Controls.Add(this.lblDetailsSubtitle);
            this.pnlDetailsCard.Controls.Add(this.lblDetailsTitle);
            this.pnlDetailsCard.Location = new System.Drawing.Point(24, 260);
            this.pnlDetailsCard.Name = "pnlDetailsCard";
            this.pnlDetailsCard.Size = new System.Drawing.Size(732, 300);
            this.pnlDetailsCard.TabIndex = 2;
            // 
            // lbCreatedAt
            // 
            this.lbCreatedAt.AutoEllipsis = true;
            this.lbCreatedAt.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.lbCreatedAt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(57)))), ((int)(((byte)(78)))));
            this.lbCreatedAt.Location = new System.Drawing.Point(386, 248);
            this.lbCreatedAt.Name = "lbCreatedAt";
            this.lbCreatedAt.Size = new System.Drawing.Size(312, 24);
            this.lbCreatedAt.TabIndex = 14;
            this.lbCreatedAt.Text = "Not available";
            // 
            // lblCreatedAt
            // 
            this.lblCreatedAt.Font = new System.Drawing.Font("Segoe UI Semibold", 7.5F, System.Drawing.FontStyle.Bold);
            this.lblCreatedAt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(127)))), ((int)(((byte)(151)))));
            this.lblCreatedAt.Location = new System.Drawing.Point(386, 227);
            this.lblCreatedAt.Name = "lblCreatedAt";
            this.lblCreatedAt.Size = new System.Drawing.Size(100, 18);
            this.lblCreatedAt.TabIndex = 13;
            this.lblCreatedAt.Text = "CREATED AT";
            // 
            // lbDateOfBirth
            // 
            this.lbDateOfBirth.AutoEllipsis = true;
            this.lbDateOfBirth.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.lbDateOfBirth.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(57)))), ((int)(((byte)(78)))));
            this.lbDateOfBirth.Location = new System.Drawing.Point(28, 248);
            this.lbDateOfBirth.Name = "lbDateOfBirth";
            this.lbDateOfBirth.Size = new System.Drawing.Size(312, 24);
            this.lbDateOfBirth.TabIndex = 12;
            this.lbDateOfBirth.Text = "Not available";
            // 
            // lblDateOfBirth
            // 
            this.lblDateOfBirth.Font = new System.Drawing.Font("Segoe UI Semibold", 7.5F, System.Drawing.FontStyle.Bold);
            this.lblDateOfBirth.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(127)))), ((int)(((byte)(151)))));
            this.lblDateOfBirth.Location = new System.Drawing.Point(28, 227);
            this.lblDateOfBirth.Name = "lblDateOfBirth";
            this.lblDateOfBirth.Size = new System.Drawing.Size(110, 18);
            this.lblDateOfBirth.TabIndex = 11;
            this.lblDateOfBirth.Text = "DATE OF BIRTH";
            // 
            // pnlDivider3
            // 
            this.pnlDivider3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(247)))));
            this.pnlDivider3.Location = new System.Drawing.Point(28, 213);
            this.pnlDivider3.Name = "pnlDivider3";
            this.pnlDivider3.Size = new System.Drawing.Size(670, 1);
            this.pnlDivider3.TabIndex = 10;
            // 
            // lbEmail
            // 
            this.lbEmail.AutoEllipsis = true;
            this.lbEmail.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.lbEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(57)))), ((int)(((byte)(78)))));
            this.lbEmail.Location = new System.Drawing.Point(386, 173);
            this.lbEmail.Name = "lbEmail";
            this.lbEmail.Size = new System.Drawing.Size(312, 24);
            this.lbEmail.TabIndex = 9;
            this.lbEmail.Text = "Not available";
            // 
            // lblEmail
            // 
            this.lblEmail.Font = new System.Drawing.Font("Segoe UI Semibold", 7.5F, System.Drawing.FontStyle.Bold);
            this.lblEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(127)))), ((int)(((byte)(151)))));
            this.lblEmail.Location = new System.Drawing.Point(386, 152);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(70, 18);
            this.lblEmail.TabIndex = 8;
            this.lblEmail.Text = "EMAIL";
            // 
            // lblPhoneValue
            // 
            this.lblPhoneValue.AutoEllipsis = true;
            this.lblPhoneValue.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.lblPhoneValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(57)))), ((int)(((byte)(78)))));
            this.lblPhoneValue.Location = new System.Drawing.Point(28, 173);
            this.lblPhoneValue.Name = "lblPhoneValue";
            this.lblPhoneValue.Size = new System.Drawing.Size(312, 24);
            this.lblPhoneValue.TabIndex = 7;
            this.lblPhoneValue.Text = "Not available";
            // 
            // lblPhone
            // 
            this.lblPhone.Font = new System.Drawing.Font("Segoe UI Semibold", 7.5F, System.Drawing.FontStyle.Bold);
            this.lblPhone.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(127)))), ((int)(((byte)(151)))));
            this.lblPhone.Location = new System.Drawing.Point(28, 152);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(70, 18);
            this.lblPhone.TabIndex = 6;
            this.lblPhone.Text = "PHONE";
            // 
            // pnlDivider2
            // 
            this.pnlDivider2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(247)))));
            this.pnlDivider2.Location = new System.Drawing.Point(28, 138);
            this.pnlDivider2.Name = "pnlDivider2";
            this.pnlDivider2.Size = new System.Drawing.Size(670, 1);
            this.pnlDivider2.TabIndex = 5;
            // 
            // lbAddress
            // 
            this.lbAddress.AutoEllipsis = true;
            this.lbAddress.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.lbAddress.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(57)))), ((int)(((byte)(78)))));
            this.lbAddress.Location = new System.Drawing.Point(28, 99);
            this.lbAddress.Name = "lbAddress";
            this.lbAddress.Size = new System.Drawing.Size(670, 24);
            this.lbAddress.TabIndex = 4;
            this.lbAddress.Text = "No address available";
            // 
            // lblAddress
            // 
            this.lblAddress.Font = new System.Drawing.Font("Segoe UI Semibold", 7.5F, System.Drawing.FontStyle.Bold);
            this.lblAddress.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(127)))), ((int)(((byte)(151)))));
            this.lblAddress.Location = new System.Drawing.Point(28, 78);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(80, 18);
            this.lblAddress.TabIndex = 3;
            this.lblAddress.Text = "ADDRESS";
            // 
            // pnlDivider1
            // 
            this.pnlDivider1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(247)))));
            this.pnlDivider1.Location = new System.Drawing.Point(28, 64);
            this.pnlDivider1.Name = "pnlDivider1";
            this.pnlDivider1.Size = new System.Drawing.Size(670, 1);
            this.pnlDivider1.TabIndex = 2;
            // 
            // lblDetailsSubtitle
            // 
            this.lblDetailsSubtitle.AutoSize = true;
            this.lblDetailsSubtitle.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.lblDetailsSubtitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(156)))), ((int)(((byte)(177)))));
            this.lblDetailsSubtitle.Location = new System.Drawing.Point(493, 27);
            this.lblDetailsSubtitle.Name = "lblDetailsSubtitle";
            this.lblDetailsSubtitle.Size = new System.Drawing.Size(208, 15);
            this.lblDetailsSubtitle.TabIndex = 1;
            this.lblDetailsSubtitle.Text = "Contact and membership information";
            // 
            // lblDetailsTitle
            // 
            this.lblDetailsTitle.AutoSize = true;
            this.lblDetailsTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 13F, System.Drawing.FontStyle.Bold);
            this.lblDetailsTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(33)))), ((int)(((byte)(61)))));
            this.lblDetailsTitle.Location = new System.Drawing.Point(24, 20);
            this.lblDetailsTitle.Name = "lblDetailsTitle";
            this.lblDetailsTitle.Size = new System.Drawing.Size(129, 25);
            this.lblDetailsTitle.TabIndex = 0;
            this.lblDetailsTitle.Text = "Profile Details";
            // 
            // ctrlPersonInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(245)))), ((int)(((byte)(249)))));
            this.Controls.Add(this.pnlDetailsCard);
            this.Controls.Add(this.pnlProfileCard);
            this.Controls.Add(this.pnlHeader);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Name = "ctrlPersonInfo";
            this.Size = new System.Drawing.Size(780, 584);
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.pnlProfileCard.ResumeLayout(false);
            this.pnlProfileCard.PerformLayout();
            this.pnlDetailsCard.ResumeLayout(false);
            this.pnlDetailsCard.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblHeaderTitle;
        private System.Windows.Forms.Label lblHeaderSubtitle;
        private System.Windows.Forms.Label lblPersonIdCaption;
        private System.Windows.Forms.Label lbPersonID;
        private System.Windows.Forms.Panel pnlProfileCard;
        private System.Windows.Forms.Panel pnlAccent;
        private System.Windows.Forms.Label lblAvatar;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.Label lblMemberType;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Panel pnlDetailsCard;
        private System.Windows.Forms.Label lblDetailsTitle;
        private System.Windows.Forms.Label lblDetailsSubtitle;
        private System.Windows.Forms.Panel pnlDivider1;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label lbAddress;
        private System.Windows.Forms.Panel pnlDivider2;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.Label lblPhoneValue;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lbEmail;
        private System.Windows.Forms.Panel pnlDivider3;
        private System.Windows.Forms.Label lblDateOfBirth;
        private System.Windows.Forms.Label lbDateOfBirth;
        private System.Windows.Forms.Label lblCreatedAt;
        private System.Windows.Forms.Label lbCreatedAt;
    }
}
