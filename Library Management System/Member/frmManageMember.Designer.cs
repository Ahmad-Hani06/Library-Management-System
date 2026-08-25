namespace Library_Management_System.Member
{
    partial class frmManageMember
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
            this.dgvManageMember = new Guna.UI2.WinForms.Guna2DataGridView();
            this.guna2ContextMenuStrip1 = new Guna.UI2.WinForms.Guna2ContextMenuStrip();
            this.editMemberToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showMemberDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.renewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.deactivToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlFooter = new System.Windows.Forms.Panel();
            this.lblFooterText = new System.Windows.Forms.Label();
            this.lblFooterIcon = new System.Windows.Forms.Label();
            this.pnlHeader.SuspendLayout();
            this.pnlHeaderIcon.SuspendLayout();
            this.pnlTableHeading.SuspendLayout();
            this.pnlActionHint.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvManageMember)).BeginInit();
            this.guna2ContextMenuStrip1.SuspendLayout();
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
            this.pnlHeader.Size = new System.Drawing.Size(1120, 112);
            this.pnlHeader.TabIndex = 0;
            // 
            // pnlHeaderIcon
            // 
            this.pnlHeaderIcon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(63)))), ((int)(((byte)(105)))));
            this.pnlHeaderIcon.Controls.Add(this.lblHeaderIcon);
            this.pnlHeaderIcon.Location = new System.Drawing.Point(1022, 24);
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
            this.lblHeaderIcon.Text = "";
            this.lblHeaderIcon.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblHeaderSubtitle
            // 
            this.lblHeaderSubtitle.AutoSize = true;
            this.lblHeaderSubtitle.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblHeaderSubtitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(184)))), ((int)(((byte)(209)))));
            this.lblHeaderSubtitle.Location = new System.Drawing.Point(33, 68);
            this.lblHeaderSubtitle.Name = "lblHeaderSubtitle";
            this.lblHeaderSubtitle.Size = new System.Drawing.Size(398, 17);
            this.lblHeaderSubtitle.TabIndex = 1;
            this.lblHeaderSubtitle.Text = "Review membership records and access available member actions.";
            // 
            // lblHeaderTitle
            // 
            this.lblHeaderTitle.AutoSize = true;
            this.lblHeaderTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 20F, System.Drawing.FontStyle.Bold);
            this.lblHeaderTitle.ForeColor = System.Drawing.Color.White;
            this.lblHeaderTitle.Location = new System.Drawing.Point(29, 27);
            this.lblHeaderTitle.Name = "lblHeaderTitle";
            this.lblHeaderTitle.Size = new System.Drawing.Size(238, 37);
            this.lblHeaderTitle.TabIndex = 0;
            this.lblHeaderTitle.Text = "Manage Members";
            // 
            // pnlTableHeading
            // 
            this.pnlTableHeading.BackColor = System.Drawing.Color.White;
            this.pnlTableHeading.Controls.Add(this.pnlActionHint);
            this.pnlTableHeading.Controls.Add(this.lblTableSubtitle);
            this.pnlTableHeading.Controls.Add(this.lblTableTitle);
            this.pnlTableHeading.Controls.Add(this.lblTableIcon);
            this.pnlTableHeading.Location = new System.Drawing.Point(28, 132);
            this.pnlTableHeading.Name = "pnlTableHeading";
            this.pnlTableHeading.Size = new System.Drawing.Size(1064, 76);
            this.pnlTableHeading.TabIndex = 1;
            // 
            // pnlActionHint
            // 
            this.pnlActionHint.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(250)))), ((int)(((byte)(248)))));
            this.pnlActionHint.Controls.Add(this.lblActionHint);
            this.pnlActionHint.Controls.Add(this.lblActionIcon);
            this.pnlActionHint.Location = new System.Drawing.Point(805, 18);
            this.pnlActionHint.Name = "pnlActionHint";
            this.pnlActionHint.Size = new System.Drawing.Size(230, 40);
            this.pnlActionHint.TabIndex = 3;
            // 
            // lblActionHint
            // 
            this.lblActionHint.AutoSize = true;
            this.lblActionHint.Font = new System.Drawing.Font("Segoe UI Semibold", 8F, System.Drawing.FontStyle.Bold);
            this.lblActionHint.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(126)))), ((int)(((byte)(119)))));
            this.lblActionHint.Location = new System.Drawing.Point(42, 13);
            this.lblActionHint.Name = "lblActionHint";
            this.lblActionHint.Size = new System.Drawing.Size(178, 13);
            this.lblActionHint.TabIndex = 1;
            this.lblActionHint.Text = "RIGHT-CLICK FOR MORE ACTIONS";
            // 
            // lblActionIcon
            // 
            this.lblActionIcon.Font = new System.Drawing.Font("Segoe MDL2 Assets", 12F);
            this.lblActionIcon.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(166)))), ((int)(((byte)(154)))));
            this.lblActionIcon.Location = new System.Drawing.Point(12, 9);
            this.lblActionIcon.Name = "lblActionIcon";
            this.lblActionIcon.Size = new System.Drawing.Size(24, 24);
            this.lblActionIcon.TabIndex = 0;
            this.lblActionIcon.Text = "";
            this.lblActionIcon.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTableSubtitle
            // 
            this.lblTableSubtitle.AutoSize = true;
            this.lblTableSubtitle.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.lblTableSubtitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(139)))), ((int)(((byte)(162)))));
            this.lblTableSubtitle.Location = new System.Drawing.Point(79, 43);
            this.lblTableSubtitle.Name = "lblTableSubtitle";
            this.lblTableSubtitle.Size = new System.Drawing.Size(305, 15);
            this.lblTableSubtitle.TabIndex = 2;
            this.lblTableSubtitle.Text = "All membership records are displayed in the table below.";
            // 
            // lblTableTitle
            // 
            this.lblTableTitle.AutoSize = true;
            this.lblTableTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.lblTableTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(33)))), ((int)(((byte)(61)))));
            this.lblTableTitle.Location = new System.Drawing.Point(77, 18);
            this.lblTableTitle.Name = "lblTableTitle";
            this.lblTableTitle.Size = new System.Drawing.Size(146, 21);
            this.lblTableTitle.TabIndex = 1;
            this.lblTableTitle.Text = "Member Directory";
            // 
            // lblTableIcon
            // 
            this.lblTableIcon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.lblTableIcon.Font = new System.Drawing.Font("Segoe MDL2 Assets", 17F);
            this.lblTableIcon.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(112)))), ((int)(((byte)(170)))));
            this.lblTableIcon.Location = new System.Drawing.Point(20, 15);
            this.lblTableIcon.Name = "lblTableIcon";
            this.lblTableIcon.Size = new System.Drawing.Size(46, 46);
            this.lblTableIcon.TabIndex = 0;
            this.lblTableIcon.Text = "";
            this.lblTableIcon.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dgvManageMember
            // 
            this.dgvManageMember.AllowUserToAddRows = false;
            this.dgvManageMember.AllowUserToDeleteRows = false;
            this.dgvManageMember.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(251)))), ((int)(((byte)(254)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(80)))), ((int)(((byte)(103)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(250)))), ((int)(((byte)(248)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(33)))), ((int)(((byte)(61)))));
            this.dgvManageMember.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(43)))), ((int)(((byte)(75)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(43)))), ((int)(((byte)(75)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvManageMember.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvManageMember.ColumnHeadersHeight = 44;
            this.dgvManageMember.ContextMenuStrip = this.guna2ContextMenuStrip1;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(80)))), ((int)(((byte)(103)))));
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(250)))), ((int)(((byte)(248)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(33)))), ((int)(((byte)(61)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvManageMember.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvManageMember.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(239)))), ((int)(((byte)(246)))));
            this.dgvManageMember.Location = new System.Drawing.Point(28, 220);
            this.dgvManageMember.MultiSelect = false;
            this.dgvManageMember.Name = "dgvManageMember";
            this.dgvManageMember.ReadOnly = true;
            this.dgvManageMember.RowHeadersVisible = false;
            this.dgvManageMember.RowTemplate.Height = 44;
            this.dgvManageMember.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvManageMember.Size = new System.Drawing.Size(1064, 400);
            this.dgvManageMember.TabIndex = 2;
            this.dgvManageMember.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(251)))), ((int)(((byte)(254)))));
            this.dgvManageMember.ThemeStyle.AlternatingRowsStyle.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dgvManageMember.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(80)))), ((int)(((byte)(103)))));
            this.dgvManageMember.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(250)))), ((int)(((byte)(248)))));
            this.dgvManageMember.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(33)))), ((int)(((byte)(61)))));
            this.dgvManageMember.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(239)))), ((int)(((byte)(246)))));
            this.dgvManageMember.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(43)))), ((int)(((byte)(75)))));
            this.dgvManageMember.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dgvManageMember.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvManageMember.ThemeStyle.HeaderStyle.Height = 44;
            this.dgvManageMember.ThemeStyle.ReadOnly = true;
            this.dgvManageMember.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dgvManageMember.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(80)))), ((int)(((byte)(103)))));
            this.dgvManageMember.ThemeStyle.RowsStyle.Height = 44;
            this.dgvManageMember.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(250)))), ((int)(((byte)(248)))));
            this.dgvManageMember.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(33)))), ((int)(((byte)(61)))));
            // 
            // guna2ContextMenuStrip1
            // 
            this.guna2ContextMenuStrip1.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.guna2ContextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editMemberToolStripMenuItem,
            this.showMemberDetailsToolStripMenuItem,
            this.renewToolStripMenuItem,
            this.toolStripSeparator1,
            this.deactivToolStripMenuItem});
            this.guna2ContextMenuStrip1.Name = "guna2ContextMenuStrip1";
            this.guna2ContextMenuStrip1.RenderStyle.ArrowColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(166)))), ((int)(((byte)(154)))));
            this.guna2ContextMenuStrip1.RenderStyle.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(225)))), ((int)(((byte)(236)))));
            this.guna2ContextMenuStrip1.RenderStyle.ColorTable = null;
            this.guna2ContextMenuStrip1.RenderStyle.RoundedEdges = true;
            this.guna2ContextMenuStrip1.RenderStyle.SelectionArrowColor = System.Drawing.Color.White;
            this.guna2ContextMenuStrip1.RenderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(166)))), ((int)(((byte)(154)))));
            this.guna2ContextMenuStrip1.RenderStyle.SelectionForeColor = System.Drawing.Color.White;
            this.guna2ContextMenuStrip1.RenderStyle.SeparatorColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(234)))), ((int)(((byte)(242)))));
            this.guna2ContextMenuStrip1.RenderStyle.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.guna2ContextMenuStrip1.Size = new System.Drawing.Size(205, 144);
            this.guna2ContextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.guna2ContextMenuStrip1_Opening);
            // 
            // editMemberToolStripMenuItem
            // 
            this.editMemberToolStripMenuItem.Name = "editMemberToolStripMenuItem";
            this.editMemberToolStripMenuItem.Padding = new System.Windows.Forms.Padding(4);
            this.editMemberToolStripMenuItem.Size = new System.Drawing.Size(212, 28);
            this.editMemberToolStripMenuItem.Text = "Edit Member";
            this.editMemberToolStripMenuItem.Click += new System.EventHandler(this.editMemberToolStripMenuItem_Click);
            // 
            // showMemberDetailsToolStripMenuItem
            // 
            this.showMemberDetailsToolStripMenuItem.Name = "showMemberDetailsToolStripMenuItem";
            this.showMemberDetailsToolStripMenuItem.Padding = new System.Windows.Forms.Padding(4);
            this.showMemberDetailsToolStripMenuItem.Size = new System.Drawing.Size(212, 28);
            this.showMemberDetailsToolStripMenuItem.Text = "Show Member Details";
            this.showMemberDetailsToolStripMenuItem.Click += new System.EventHandler(this.showMemberDetailsToolStripMenuItem_Click);
            // 
            // renewToolStripMenuItem
            // 
            this.renewToolStripMenuItem.Name = "renewToolStripMenuItem";
            this.renewToolStripMenuItem.Padding = new System.Windows.Forms.Padding(4);
            this.renewToolStripMenuItem.Size = new System.Drawing.Size(212, 28);
            this.renewToolStripMenuItem.Text = "Renew Membership";
            this.renewToolStripMenuItem.Click += new System.EventHandler(this.renewToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(201, 6);
            // 
            // deactivToolStripMenuItem
            // 
            this.deactivToolStripMenuItem.Name = "deactivToolStripMenuItem";
            this.deactivToolStripMenuItem.Padding = new System.Windows.Forms.Padding(4);
            this.deactivToolStripMenuItem.Size = new System.Drawing.Size(212, 28);
            this.deactivToolStripMenuItem.Text = "Dea";
            this.deactivToolStripMenuItem.Click += new System.EventHandler(this.deactivToolStripMenuItem_Click);
            // 
            // pnlFooter
            // 
            this.pnlFooter.BackColor = System.Drawing.Color.Transparent;
            this.pnlFooter.Controls.Add(this.lblFooterText);
            this.pnlFooter.Controls.Add(this.lblFooterIcon);
            this.pnlFooter.Location = new System.Drawing.Point(28, 635);
            this.pnlFooter.Name = "pnlFooter";
            this.pnlFooter.Size = new System.Drawing.Size(1064, 24);
            this.pnlFooter.TabIndex = 3;
            // 
            // lblFooterText
            // 
            this.lblFooterText.AutoSize = true;
            this.lblFooterText.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.lblFooterText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(127)))), ((int)(((byte)(151)))));
            this.lblFooterText.Location = new System.Drawing.Point(27, 4);
            this.lblFooterText.Name = "lblFooterText";
            this.lblFooterText.Size = new System.Drawing.Size(334, 15);
            this.lblFooterText.TabIndex = 1;
            this.lblFooterText.Text = "Select a member row and right-click to open member actions.";
            // 
            // lblFooterIcon
            // 
            this.lblFooterIcon.Font = new System.Drawing.Font("Segoe MDL2 Assets", 10F);
            this.lblFooterIcon.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(166)))), ((int)(((byte)(154)))));
            this.lblFooterIcon.Location = new System.Drawing.Point(0, 1);
            this.lblFooterIcon.Name = "lblFooterIcon";
            this.lblFooterIcon.Size = new System.Drawing.Size(22, 22);
            this.lblFooterIcon.TabIndex = 0;
            this.lblFooterIcon.Text = "";
            this.lblFooterIcon.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmManageMember
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(245)))), ((int)(((byte)(249)))));
            this.ClientSize = new System.Drawing.Size(1120, 680);
            this.ContextMenuStrip = this.guna2ContextMenuStrip1;
            this.Controls.Add(this.pnlFooter);
            this.Controls.Add(this.dgvManageMember);
            this.Controls.Add(this.pnlTableHeading);
            this.Controls.Add(this.pnlHeader);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmManageMember";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manage Members";
            this.Load += new System.EventHandler(this.frmManageMember_Load);
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.pnlHeaderIcon.ResumeLayout(false);
            this.pnlTableHeading.ResumeLayout(false);
            this.pnlTableHeading.PerformLayout();
            this.pnlActionHint.ResumeLayout(false);
            this.pnlActionHint.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvManageMember)).EndInit();
            this.guna2ContextMenuStrip1.ResumeLayout(false);
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
        private Guna.UI2.WinForms.Guna2DataGridView dgvManageMember;
        private Guna.UI2.WinForms.Guna2ContextMenuStrip guna2ContextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem editMemberToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showMemberDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem renewToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem deactivToolStripMenuItem;
        private System.Windows.Forms.Panel pnlFooter;
        private System.Windows.Forms.Label lblFooterText;
        private System.Windows.Forms.Label lblFooterIcon;
    }
}
