namespace Library_Management_System.Member
{
    partial class frmShowMemberInfo
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
            this.ctrlMemberInfo1 = new Library_Management_System.Member.ctrlMemberInfo();
            this.SuspendLayout();
            // 
            // ctrlMemberInfo1
            // 
            this.ctrlMemberInfo1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(245)))), ((int)(((byte)(249)))));
            this.ctrlMemberInfo1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ctrlMemberInfo1.Location = new System.Drawing.Point(-4, -1);
            this.ctrlMemberInfo1.Name = "ctrlMemberInfo1";
            this.ctrlMemberInfo1.Size = new System.Drawing.Size(804, 224);
            this.ctrlMemberInfo1.TabIndex = 0;
            // 
            // frmShowMemberInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 223);
            this.Controls.Add(this.ctrlMemberInfo1);
            this.MaximizeBox = false;
            this.Name = "frmShowMemberInfo";
            this.Text = "frmShowMemberInfo";
            this.Load += new System.EventHandler(this.frmShowMemberInfo_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private ctrlMemberInfo ctrlMemberInfo1;
    }
}