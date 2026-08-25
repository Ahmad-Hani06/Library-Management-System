namespace Library_Management_System.Fine
{
    partial class frmManageFine
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
            this.pnlHeaderIcon = new System.Windows.Forms.Panel();
            this.lblHeaderIcon = new System.Windows.Forms.Label();
            this.lblHeaderSubtitle = new System.Windows.Forms.Label();
            this.lblHeaderTitle = new System.Windows.Forms.Label();
            this.pnlTableHeading = new System.Windows.Forms.Panel();
            this.pnlActionHint = new System.Windows.Forms.Panel();
            this.lblActionHint = new System.Windows.Forms.Label();
            this.lblActionIcon = new System.Windows.Forms.Label();
            this.lblTableSubtitle = new System.Windows.Forms.Label();
            this.lblTableTitle = new System.Windows.Forms.Label();
            this.lblTableIcon = new System.Windows.Forms.Label();
            this.dgvManageFine = new Guna.UI2.WinForms.Guna2DataGridView();
            this.contextMenuStripFineActions = new Guna.UI2.WinForms.Guna2ContextMenuStrip();
            this.payFineToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.payDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlFooter = new System.Windows.Forms.Panel();
            this.lblFooterIcon = new System.Windows.Forms.Label();
            this.lblFooterText = new System.Windows.Forms.Label();
            this.pnlHeader.SuspendLayout();
            this.pnlHeaderIcon.SuspendLayout();
            this.pnlTableHeading.SuspendLayout();
            this.pnlActionHint.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvManageFine)).BeginInit();
            this.contextMenuStripFineActions.SuspendLayout();
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
            this.pnlHeader.Size = new System.Drawing.Size(1240, 108);
            this.pnlHeader.TabIndex = 0;
            // 
            // pnlHeaderIcon
            // 
            this.pnlHeaderIcon.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlHeaderIcon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(63)))), ((int)(((byte)(105)))));
            this.pnlHeaderIcon.Controls.Add(this.lblHeaderIcon);
            this.pnlHeaderIcon.Location = new System.Drawing.Point(1146, 22);
            this.pnlHeaderIcon.Name = "pnlHeaderIcon";
            this.pnlHeaderIcon.Size = new System.Drawing.Size(64, 64);
            this.pnlHeaderIcon.TabIndex = 2;
            // 
            // lblHeaderIcon
            // 
            this.lblHeaderIcon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblHeaderIcon.Font = new System.Drawing.Font("Segoe UI Semibold", 20F, System.Drawing.FontStyle.Bold);
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
            this.lblHeaderSubtitle.Location = new System.Drawing.Point(31, 66);
            this.lblHeaderSubtitle.Name = "lblHeaderSubtitle";
            this.lblHeaderSubtitle.Size = new System.Drawing.Size(348, 17);
            this.lblHeaderSubtitle.TabIndex = 1;
            this.lblHeaderSubtitle.Text = "Review library fines and track their current payment status.";
            // 
            // lblHeaderTitle
            // 
            this.lblHeaderTitle.AutoSize = true;
            this.lblHeaderTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 20F, System.Drawing.FontStyle.Bold);
            this.lblHeaderTitle.ForeColor = System.Drawing.Color.White;
            this.lblHeaderTitle.Location = new System.Drawing.Point(27, 25);
            this.lblHeaderTitle.Name = "lblHeaderTitle";
            this.lblHeaderTitle.Size = new System.Drawing.Size(186, 37);
            this.lblHeaderTitle.TabIndex = 0;
            this.lblHeaderTitle.Text = "Manage Fines";
            // 
            // pnlTableHeading
            // 
            this.pnlTableHeading.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlTableHeading.BackColor = System.Drawing.Color.White;
            this.pnlTableHeading.Controls.Add(this.pnlActionHint);
            this.pnlTableHeading.Controls.Add(this.lblTableSubtitle);
            this.pnlTableHeading.Controls.Add(this.lblTableTitle);
            this.pnlTableHeading.Controls.Add(this.lblTableIcon);
            this.pnlTableHeading.Location = new System.Drawing.Point(28, 132);
            this.pnlTableHeading.Name = "pnlTableHeading";
            this.pnlTableHeading.Size = new System.Drawing.Size(1184, 76);
            this.pnlTableHeading.TabIndex = 1;
            // 
            // pnlActionHint
            // 
            this.pnlActionHint.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlActionHint.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(250)))), ((int)(((byte)(248)))));
            this.pnlActionHint.Controls.Add(this.lblActionHint);
            this.pnlActionHint.Controls.Add(this.lblActionIcon);
            this.pnlActionHint.Location = new System.Drawing.Point(934, 18);
            this.pnlActionHint.Name = "pnlActionHint";
            this.pnlActionHint.Size = new System.Drawing.Size(222, 40);
            this.pnlActionHint.TabIndex = 3;
            // 
            // lblActionHint
            // 
            this.lblActionHint.AutoSize = true;
            this.lblActionHint.Font = new System.Drawing.Font("Segoe UI Semibold", 8F, System.Drawing.FontStyle.Bold);
            this.lblActionHint.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(126)))), ((int)(((byte)(119)))));
            this.lblActionHint.Location = new System.Drawing.Point(42, 13);
            this.lblActionHint.Name = "lblActionHint";
            this.lblActionHint.Size = new System.Drawing.Size(170, 13);
            this.lblActionHint.TabIndex = 1;
            this.lblActionHint.Text = "RIGHT-CLICK FOR FINE ACTIONS";
            // 
            // lblActionIcon
            // 
            this.lblActionIcon.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            this.lblActionIcon.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(166)))), ((int)(((byte)(154)))));
            this.lblActionIcon.Location = new System.Drawing.Point(12, 8);
            this.lblActionIcon.Name = "lblActionIcon";
            this.lblActionIcon.Size = new System.Drawing.Size(24, 24);
            this.lblActionIcon.TabIndex = 0;
            this.lblActionIcon.Text = "...";
            this.lblActionIcon.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTableSubtitle
            // 
            this.lblTableSubtitle.AutoSize = true;
            this.lblTableSubtitle.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.lblTableSubtitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(139)))), ((int)(((byte)(162)))));
            this.lblTableSubtitle.Location = new System.Drawing.Point(79, 43);
            this.lblTableSubtitle.Name = "lblTableSubtitle";
            this.lblTableSubtitle.Size = new System.Drawing.Size(330, 15);
            this.lblTableSubtitle.TabIndex = 2;
            this.lblTableSubtitle.Text = "Fine amounts, dates and payment status are displayed below.";
            // 
            // lblTableTitle
            // 
            this.lblTableTitle.AutoSize = true;
            this.lblTableTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.lblTableTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(33)))), ((int)(((byte)(61)))));
            this.lblTableTitle.Location = new System.Drawing.Point(77, 18);
            this.lblTableTitle.Name = "lblTableTitle";
            this.lblTableTitle.Size = new System.Drawing.Size(104, 21);
            this.lblTableTitle.TabIndex = 1;
            this.lblTableTitle.Text = "Fine Records";
            // 
            // lblTableIcon
            // 
            this.lblTableIcon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(250)))), ((int)(((byte)(248)))));
            this.lblTableIcon.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold);
            this.lblTableIcon.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(166)))), ((int)(((byte)(154)))));
            this.lblTableIcon.Location = new System.Drawing.Point(20, 15);
            this.lblTableIcon.Name = "lblTableIcon";
            this.lblTableIcon.Size = new System.Drawing.Size(46, 46);
            this.lblTableIcon.TabIndex = 0;
            this.lblTableIcon.Text = "$";
            this.lblTableIcon.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dgvManageFine
            // 
            this.dgvManageFine.AllowUserToAddRows = false;
            this.dgvManageFine.AllowUserToDeleteRows = false;
            this.dgvManageFine.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(251)))), ((int)(((byte)(254)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(80)))), ((int)(((byte)(103)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(250)))), ((int)(((byte)(248)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(33)))), ((int)(((byte)(61)))));
            this.dgvManageFine.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvManageFine.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
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
            this.dgvManageFine.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvManageFine.ColumnHeadersHeight = 44;
            this.dgvManageFine.ContextMenuStrip = this.contextMenuStripFineActions;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(80)))), ((int)(((byte)(103)))));
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(7, 0, 0, 0);
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(250)))), ((int)(((byte)(248)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(33)))), ((int)(((byte)(61)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvManageFine.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvManageFine.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvManageFine.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(239)))), ((int)(((byte)(246)))));
            this.dgvManageFine.Location = new System.Drawing.Point(28, 220);
            this.dgvManageFine.MultiSelect = false;
            this.dgvManageFine.Name = "dgvManageFine";
            this.dgvManageFine.ReadOnly = true;
            this.dgvManageFine.RowHeadersVisible = false;
            this.dgvManageFine.RowTemplate.Height = 46;
            this.dgvManageFine.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvManageFine.Size = new System.Drawing.Size(1184, 410);
            this.dgvManageFine.TabIndex = 2;
            this.dgvManageFine.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(251)))), ((int)(((byte)(254)))));
            this.dgvManageFine.ThemeStyle.AlternatingRowsStyle.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dgvManageFine.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(80)))), ((int)(((byte)(103)))));
            this.dgvManageFine.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(250)))), ((int)(((byte)(248)))));
            this.dgvManageFine.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(33)))), ((int)(((byte)(61)))));
            this.dgvManageFine.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(239)))), ((int)(((byte)(246)))));
            this.dgvManageFine.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(43)))), ((int)(((byte)(75)))));
            this.dgvManageFine.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dgvManageFine.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvManageFine.ThemeStyle.HeaderStyle.Height = 44;
            this.dgvManageFine.ThemeStyle.ReadOnly = true;
            this.dgvManageFine.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dgvManageFine.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(80)))), ((int)(((byte)(103)))));
            this.dgvManageFine.ThemeStyle.RowsStyle.Height = 46;
            this.dgvManageFine.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(250)))), ((int)(((byte)(248)))));
            this.dgvManageFine.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(33)))), ((int)(((byte)(61)))));
            // 
            // contextMenuStripFineActions
            // 
            this.contextMenuStripFineActions.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.contextMenuStripFineActions.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.payFineToolStripMenuItem,
            this.payDetailsToolStripMenuItem});
            this.contextMenuStripFineActions.Name = "contextMenuStripFineActions";
            this.contextMenuStripFineActions.RenderStyle.ArrowColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(166)))), ((int)(((byte)(154)))));
            this.contextMenuStripFineActions.RenderStyle.BorderColor = System.Drawing.Color.Gainsboro;
            this.contextMenuStripFineActions.RenderStyle.ColorTable = null;
            this.contextMenuStripFineActions.RenderStyle.RoundedEdges = true;
            this.contextMenuStripFineActions.RenderStyle.SelectionArrowColor = System.Drawing.Color.White;
            this.contextMenuStripFineActions.RenderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(166)))), ((int)(((byte)(154)))));
            this.contextMenuStripFineActions.RenderStyle.SelectionForeColor = System.Drawing.Color.White;
            this.contextMenuStripFineActions.RenderStyle.SeparatorColor = System.Drawing.Color.Gainsboro;
            this.contextMenuStripFineActions.RenderStyle.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.contextMenuStripFineActions.Size = new System.Drawing.Size(181, 70);
            // 
            // payFineToolStripMenuItem
            // 
            this.payFineToolStripMenuItem.Name = "payFineToolStripMenuItem";
            this.payFineToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.payFineToolStripMenuItem.Text = "Pay Fine";
            this.payFineToolStripMenuItem.Click += new System.EventHandler(this.payFineToolStripMenuItem_Click);
            // 
            // payDetailsToolStripMenuItem
            // 
            this.payDetailsToolStripMenuItem.Name = "payDetailsToolStripMenuItem";
            this.payDetailsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.payDetailsToolStripMenuItem.Text = "Pay Details";
            this.payDetailsToolStripMenuItem.Click += new System.EventHandler(this.payDetailsToolStripMenuItem_Click);
            // 
            // pnlFooter
            // 
            this.pnlFooter.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlFooter.BackColor = System.Drawing.Color.White;
            this.pnlFooter.Controls.Add(this.lblFooterIcon);
            this.pnlFooter.Controls.Add(this.lblFooterText);
            this.pnlFooter.Location = new System.Drawing.Point(28, 642);
            this.pnlFooter.Name = "pnlFooter";
            this.pnlFooter.Size = new System.Drawing.Size(1184, 40);
            this.pnlFooter.TabIndex = 3;
            // 
            // lblFooterIcon
            // 
            this.lblFooterIcon.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.lblFooterIcon.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(166)))), ((int)(((byte)(154)))));
            this.lblFooterIcon.Location = new System.Drawing.Point(14, 8);
            this.lblFooterIcon.Name = "lblFooterIcon";
            this.lblFooterIcon.Size = new System.Drawing.Size(24, 24);
            this.lblFooterIcon.TabIndex = 0;
            this.lblFooterIcon.Text = "i";
            this.lblFooterIcon.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblFooterText
            // 
            this.lblFooterText.AutoSize = true;
            this.lblFooterText.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.lblFooterText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(116)))), ((int)(((byte)(139)))));
            this.lblFooterText.Location = new System.Drawing.Point(44, 13);
            this.lblFooterText.Name = "lblFooterText";
            this.lblFooterText.Size = new System.Drawing.Size(311, 15);
            this.lblFooterText.TabIndex = 1;
            this.lblFooterText.Text = "Select a fine, then right-click to view the available actions.";
            // 
            // frmManageFine
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(245)))), ((int)(((byte)(249)))));
            this.ClientSize = new System.Drawing.Size(1240, 710);
            this.Controls.Add(this.pnlFooter);
            this.Controls.Add(this.dgvManageFine);
            this.Controls.Add(this.pnlTableHeading);
            this.Controls.Add(this.pnlHeader);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.MinimumSize = new System.Drawing.Size(1080, 600);
            this.Name = "frmManageFine";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manage Fines";
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.pnlHeaderIcon.ResumeLayout(false);
            this.pnlTableHeading.ResumeLayout(false);
            this.pnlTableHeading.PerformLayout();
            this.pnlActionHint.ResumeLayout(false);
            this.pnlActionHint.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvManageFine)).EndInit();
            this.contextMenuStripFineActions.ResumeLayout(false);
            this.pnlFooter.ResumeLayout(false);
            this.pnlFooter.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Panel pnlHeaderIcon;
        private System.Windows.Forms.Label lblHeaderIcon;
        private System.Windows.Forms.Label lblHeaderSubtitle;
        private System.Windows.Forms.Label lblHeaderTitle;
        private System.Windows.Forms.Panel pnlTableHeading;
        private System.Windows.Forms.Panel pnlActionHint;
        private System.Windows.Forms.Label lblActionHint;
        private System.Windows.Forms.Label lblActionIcon;
        private System.Windows.Forms.Label lblTableSubtitle;
        private System.Windows.Forms.Label lblTableTitle;
        private System.Windows.Forms.Label lblTableIcon;
        private Guna.UI2.WinForms.Guna2DataGridView dgvManageFine;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFineID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBorrowingID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMemberName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBookTitle;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFineType;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFineAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFineDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPaymentStatus;
        private Guna.UI2.WinForms.Guna2ContextMenuStrip contextMenuStripFineActions;
        private System.Windows.Forms.ToolStripMenuItem payFineToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem payDetailsToolStripMenuItem;
        private System.Windows.Forms.Panel pnlFooter;
        private System.Windows.Forms.Label lblFooterIcon;
        private System.Windows.Forms.Label lblFooterText;
    }
}
