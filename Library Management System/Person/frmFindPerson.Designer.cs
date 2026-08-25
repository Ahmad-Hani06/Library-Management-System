namespace clsBussinessLogic
{
    partial class FindPerson
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
            this.ctrlFindPerson1 = new clsBussinessLogic.ctrlFindPerson();
            this.SuspendLayout();
            // 
            // ctrlFindPerson1
            // 
            this.ctrlFindPerson1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(245)))), ((int)(((byte)(249)))));
            this.ctrlFindPerson1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ctrlFindPerson1.Location = new System.Drawing.Point(2, 0);
            this.ctrlFindPerson1.Name = "ctrlFindPerson1";
            this.ctrlFindPerson1.Size = new System.Drawing.Size(877, 559);
            this.ctrlFindPerson1.TabIndex = 0;
            // 
            // FindPerson
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(877, 546);
            this.Controls.Add(this.ctrlFindPerson1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "FindPerson";
            this.Text = "Find Person";
            this.Load += new System.EventHandler(this.FindPerson_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private ctrlFindPerson ctrlFindPerson1;
    }
}

