namespace Library_Management_System.Payment
{
    partial class frmListPayment
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
            this.pnlHeaderIcon = new Guna.UI2.WinForms.Guna2Panel();
            this.lblHeaderIcon = new System.Windows.Forms.Label();
            this.lblHeaderSubtitle = new System.Windows.Forms.Label();
            this.lblHeaderTitle = new System.Windows.Forms.Label();
            this.pnlTableHeading = new Guna.UI2.WinForms.Guna2Panel();
            this.lblReadOnlyBadge = new System.Windows.Forms.Label();
            this.lblTableSubtitle = new System.Windows.Forms.Label();
            this.lblTableTitle = new System.Windows.Forms.Label();
            this.lblTableIcon = new System.Windows.Forms.Label();
            this.dgvPayments = new Guna.UI2.WinForms.Guna2DataGridView();
            this.pnlFooter = new Guna.UI2.WinForms.Guna2Panel();
            this.lblRecordsValue = new System.Windows.Forms.Label();
            this.lblRecordsCaption = new System.Windows.Forms.Label();
            this.lblFooterText = new System.Windows.Forms.Label();
            this.lblFooterIcon = new System.Windows.Forms.Label();
            this.pnlHeader.SuspendLayout();
            this.pnlHeaderIcon.SuspendLayout();
            this.pnlTableHeading.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPayments)).BeginInit();
            this.pnlFooter.SuspendLayout();
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
            this.pnlHeader.Size = new System.Drawing.Size(1251, 104);
            this.pnlHeader.TabIndex = 0;
            // 
            // pnlHeaderIcon
            // 
            this.pnlHeaderIcon.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlHeaderIcon.BackColor = System.Drawing.Color.Transparent;
            this.pnlHeaderIcon.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(78)))), ((int)(((byte)(116)))));
            this.pnlHeaderIcon.BorderRadius = 12;
            this.pnlHeaderIcon.BorderThickness = 1;
            this.pnlHeaderIcon.Controls.Add(this.lblHeaderIcon);
            this.pnlHeaderIcon.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(63)))), ((int)(((byte)(105)))));
            this.pnlHeaderIcon.Location = new System.Drawing.Point(1159, 20);
            this.pnlHeaderIcon.Name = "pnlHeaderIcon";
            this.pnlHeaderIcon.Size = new System.Drawing.Size(64, 64);
            this.pnlHeaderIcon.TabIndex = 2;
            // 
            // lblHeaderIcon
            // 
            this.lblHeaderIcon.BackColor = System.Drawing.Color.Transparent;
            this.lblHeaderIcon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblHeaderIcon.Font = new System.Drawing.Font("Segoe UI Semibold", 21F, System.Drawing.FontStyle.Bold);
            this.lblHeaderIcon.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(209)))), ((int)(((byte)(197)))));
            this.lblHeaderIcon.Location = new System.Drawing.Point(0, 0);
            this.lblHeaderIcon.Name = "lblHeaderIcon";
            this.lblHeaderIcon.Size = new System.Drawing.Size(64, 64);
            this.lblHeaderIcon.TabIndex = 0;
            this.lblHeaderIcon.Text = "$";
            this.lblHeaderIcon.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblHeaderSubtitle
            // 
            this.lblHeaderSubtitle.AutoSize = true;
            this.lblHeaderSubtitle.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblHeaderSubtitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(184)))), ((int)(((byte)(209)))));
            this.lblHeaderSubtitle.Location = new System.Drawing.Point(31, 64);
            this.lblHeaderSubtitle.Name = "lblHeaderSubtitle";
            this.lblHeaderSubtitle.Size = new System.Drawing.Size(363, 17);
            this.lblHeaderSubtitle.TabIndex = 1;
            this.lblHeaderSubtitle.Text = "A clear overview of all payment records in the library system.";
            // 
            // lblHeaderTitle
            // 
            this.lblHeaderTitle.AutoSize = true;
            this.lblHeaderTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 20F, System.Drawing.FontStyle.Bold);
            this.lblHeaderTitle.ForeColor = System.Drawing.Color.White;
            this.lblHeaderTitle.Location = new System.Drawing.Point(27, 24);
            this.lblHeaderTitle.Name = "lblHeaderTitle";
            this.lblHeaderTitle.Size = new System.Drawing.Size(136, 37);
            this.lblHeaderTitle.TabIndex = 0;
            this.lblHeaderTitle.Text = "Payments";
            // 
            // pnlTableHeading
            // 
            this.pnlTableHeading.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlTableHeading.BackColor = System.Drawing.Color.Transparent;
            this.pnlTableHeading.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(232)))), ((int)(((byte)(240)))));
            this.pnlTableHeading.BorderRadius = 10;
            this.pnlTableHeading.BorderThickness = 1;
            this.pnlTableHeading.Controls.Add(this.lblReadOnlyBadge);
            this.pnlTableHeading.Controls.Add(this.lblTableSubtitle);
            this.pnlTableHeading.Controls.Add(this.lblTableTitle);
            this.pnlTableHeading.Controls.Add(this.lblTableIcon);
            this.pnlTableHeading.FillColor = System.Drawing.Color.White;
            this.pnlTableHeading.Location = new System.Drawing.Point(12, 110);
            this.pnlTableHeading.Name = "pnlTableHeading";
            this.pnlTableHeading.Size = new System.Drawing.Size(1195, 68);
            this.pnlTableHeading.TabIndex = 4;
            // 
            // lblReadOnlyBadge
            // 
            this.lblReadOnlyBadge.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblReadOnlyBadge.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(250)))), ((int)(((byte)(248)))));
            this.lblReadOnlyBadge.Font = new System.Drawing.Font("Segoe UI Semibold", 8.5F, System.Drawing.FontStyle.Bold);
            this.lblReadOnlyBadge.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(126)))), ((int)(((byte)(119)))));
            this.lblReadOnlyBadge.Location = new System.Drawing.Point(1051, 18);
            this.lblReadOnlyBadge.Name = "lblReadOnlyBadge";
            this.lblReadOnlyBadge.Size = new System.Drawing.Size(120, 32);
            this.lblReadOnlyBadge.TabIndex = 3;
            this.lblReadOnlyBadge.Text = "VIEW ONLY";
            this.lblReadOnlyBadge.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTableSubtitle
            // 
            this.lblTableSubtitle.AutoSize = true;
            this.lblTableSubtitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTableSubtitle.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.lblTableSubtitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(139)))), ((int)(((byte)(162)))));
            this.lblTableSubtitle.Location = new System.Drawing.Point(72, 37);
            this.lblTableSubtitle.Name = "lblTableSubtitle";
            this.lblTableSubtitle.Size = new System.Drawing.Size(270, 15);
            this.lblTableSubtitle.TabIndex = 2;
            this.lblTableSubtitle.Text = "Payment details and related member information.";
            // 
            // lblTableTitle
            // 
            this.lblTableTitle.AutoSize = true;
            this.lblTableTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTableTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            this.lblTableTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(33)))), ((int)(((byte)(61)))));
            this.lblTableTitle.Location = new System.Drawing.Point(71, 15);
            this.lblTableTitle.Name = "lblTableTitle";
            this.lblTableTitle.Size = new System.Drawing.Size(127, 20);
            this.lblTableTitle.TabIndex = 1;
            this.lblTableTitle.Text = "Payment Records";
            // 
            // lblTableIcon
            // 
            this.lblTableIcon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(250)))), ((int)(((byte)(248)))));
            this.lblTableIcon.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold);
            this.lblTableIcon.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(166)))), ((int)(((byte)(154)))));
            this.lblTableIcon.Location = new System.Drawing.Point(18, 13);
            this.lblTableIcon.Name = "lblTableIcon";
            this.lblTableIcon.Size = new System.Drawing.Size(42, 42);
            this.lblTableIcon.TabIndex = 0;
            this.lblTableIcon.Text = "$";
            this.lblTableIcon.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dgvPayments
            // 
            this.dgvPayments.AllowUserToAddRows = false;
            this.dgvPayments.AllowUserToDeleteRows = false;
            this.dgvPayments.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(251)))), ((int)(((byte)(254)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(80)))), ((int)(((byte)(103)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(250)))), ((int)(((byte)(248)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(33)))), ((int)(((byte)(61)))));
            this.dgvPayments.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvPayments.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(43)))), ((int)(((byte)(75)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(7, 0, 0, 0);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(43)))), ((int)(((byte)(75)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPayments.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvPayments.ColumnHeadersHeight = 44;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(80)))), ((int)(((byte)(103)))));
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(7, 0, 0, 0);
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(250)))), ((int)(((byte)(248)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(33)))), ((int)(((byte)(61)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPayments.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvPayments.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvPayments.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(239)))), ((int)(((byte)(246)))));
            this.dgvPayments.Location = new System.Drawing.Point(12, 186);
            this.dgvPayments.MultiSelect = false;
            this.dgvPayments.Name = "dgvPayments";
            this.dgvPayments.ReadOnly = true;
            this.dgvPayments.RowHeadersVisible = false;
            this.dgvPayments.RowTemplate.Height = 45;
            this.dgvPayments.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPayments.Size = new System.Drawing.Size(1195, 217);
            this.dgvPayments.TabIndex = 5;
            this.dgvPayments.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(251)))), ((int)(((byte)(254)))));
            this.dgvPayments.ThemeStyle.AlternatingRowsStyle.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dgvPayments.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(80)))), ((int)(((byte)(103)))));
            this.dgvPayments.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(250)))), ((int)(((byte)(248)))));
            this.dgvPayments.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(33)))), ((int)(((byte)(61)))));
            this.dgvPayments.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(239)))), ((int)(((byte)(246)))));
            this.dgvPayments.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(43)))), ((int)(((byte)(75)))));
            this.dgvPayments.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dgvPayments.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvPayments.ThemeStyle.HeaderStyle.Height = 44;
            this.dgvPayments.ThemeStyle.ReadOnly = true;
            this.dgvPayments.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dgvPayments.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(80)))), ((int)(((byte)(103)))));
            this.dgvPayments.ThemeStyle.RowsStyle.Height = 45;
            this.dgvPayments.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(250)))), ((int)(((byte)(248)))));
            this.dgvPayments.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(33)))), ((int)(((byte)(61)))));
            // 
            // pnlFooter
            // 
            this.pnlFooter.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlFooter.BackColor = System.Drawing.Color.Transparent;
            this.pnlFooter.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(232)))), ((int)(((byte)(240)))));
            this.pnlFooter.BorderRadius = 8;
            this.pnlFooter.BorderThickness = 1;
            this.pnlFooter.Controls.Add(this.lblRecordsValue);
            this.pnlFooter.Controls.Add(this.lblRecordsCaption);
            this.pnlFooter.Controls.Add(this.lblFooterText);
            this.pnlFooter.Controls.Add(this.lblFooterIcon);
            this.pnlFooter.FillColor = System.Drawing.Color.White;
            this.pnlFooter.Location = new System.Drawing.Point(12, 409);
            this.pnlFooter.Name = "pnlFooter";
            this.pnlFooter.Size = new System.Drawing.Size(1195, 40);
            this.pnlFooter.TabIndex = 6;
            // 
            // lblRecordsValue
            // 
            this.lblRecordsValue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblRecordsValue.AutoSize = true;
            this.lblRecordsValue.BackColor = System.Drawing.Color.Transparent;
            this.lblRecordsValue.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.lblRecordsValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(33)))), ((int)(((byte)(61)))));
            this.lblRecordsValue.Location = new System.Drawing.Point(1154, 12);
            this.lblRecordsValue.Name = "lblRecordsValue";
            this.lblRecordsValue.Size = new System.Drawing.Size(19, 15);
            this.lblRecordsValue.TabIndex = 3;
            this.lblRecordsValue.Text = "—";
            // 
            // lblRecordsCaption
            // 
            this.lblRecordsCaption.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblRecordsCaption.AutoSize = true;
            this.lblRecordsCaption.BackColor = System.Drawing.Color.Transparent;
            this.lblRecordsCaption.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.lblRecordsCaption.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(116)))), ((int)(((byte)(139)))));
            this.lblRecordsCaption.Location = new System.Drawing.Point(1088, 12);
            this.lblRecordsCaption.Name = "lblRecordsCaption";
            this.lblRecordsCaption.Size = new System.Drawing.Size(52, 15);
            this.lblRecordsCaption.TabIndex = 2;
            this.lblRecordsCaption.Text = "Records:";
            // 
            // lblFooterText
            // 
            this.lblFooterText.AutoSize = true;
            this.lblFooterText.BackColor = System.Drawing.Color.Transparent;
            this.lblFooterText.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.lblFooterText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(116)))), ((int)(((byte)(139)))));
            this.lblFooterText.Location = new System.Drawing.Point(43, 12);
            this.lblFooterText.Name = "lblFooterText";
            this.lblFooterText.Size = new System.Drawing.Size(260, 15);
            this.lblFooterText.TabIndex = 1;
            this.lblFooterText.Text = "This screen is intended for viewing records only.";
            // 
            // lblFooterIcon
            // 
            this.lblFooterIcon.BackColor = System.Drawing.Color.Transparent;
            this.lblFooterIcon.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.lblFooterIcon.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(166)))), ((int)(((byte)(154)))));
            this.lblFooterIcon.Location = new System.Drawing.Point(13, 8);
            this.lblFooterIcon.Name = "lblFooterIcon";
            this.lblFooterIcon.Size = new System.Drawing.Size(24, 24);
            this.lblFooterIcon.TabIndex = 0;
            this.lblFooterIcon.Text = "i";
            this.lblFooterIcon.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmListPayment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(245)))), ((int)(((byte)(249)))));
            this.ClientSize = new System.Drawing.Size(1251, 611);
            this.Controls.Add(this.pnlFooter);
            this.Controls.Add(this.dgvPayments);
            this.Controls.Add(this.pnlTableHeading);
            this.Controls.Add(this.pnlHeader);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.MinimumSize = new System.Drawing.Size(1100, 650);
            this.Name = "frmListPayment";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Payments";
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.pnlHeaderIcon.ResumeLayout(false);
            this.pnlTableHeading.ResumeLayout(false);
            this.pnlTableHeading.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPayments)).EndInit();
            this.pnlFooter.ResumeLayout(false);
            this.pnlFooter.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlHeader;
        private Guna.UI2.WinForms.Guna2Panel pnlHeaderIcon;
        private System.Windows.Forms.Label lblHeaderIcon;
        private System.Windows.Forms.Label lblHeaderSubtitle;
        private System.Windows.Forms.Label lblHeaderTitle;
        private Guna.UI2.WinForms.Guna2Panel pnlTableHeading;
        private System.Windows.Forms.Label lblReadOnlyBadge;
        private System.Windows.Forms.Label lblTableSubtitle;
        private System.Windows.Forms.Label lblTableTitle;
        private System.Windows.Forms.Label lblTableIcon;
        private Guna.UI2.WinForms.Guna2DataGridView dgvPayments;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPaymentID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMemberID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMemberName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPaymentAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPaymentDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colUserName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNotes;
        private Guna.UI2.WinForms.Guna2Panel pnlFooter;
        private System.Windows.Forms.Label lblRecordsValue;
        private System.Windows.Forms.Label lblRecordsCaption;
        private System.Windows.Forms.Label lblFooterText;
        private System.Windows.Forms.Label lblFooterIcon;
    }
}
