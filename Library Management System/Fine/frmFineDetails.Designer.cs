namespace Library_Management_System.Fine
{
    partial class frmFineDetails
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
            this.ctrlFineDetails1 = new Library_Management_System.Fine.Controls.ctrlFineDetails();
            this.SuspendLayout();
            // 
            // ctrlFineDetails1
            // 
            this.ctrlFineDetails1.Location = new System.Drawing.Point(1, -1);
            this.ctrlFineDetails1.Name = "ctrlFineDetails1";
            this.ctrlFineDetails1.Size = new System.Drawing.Size(788, 405);
            this.ctrlFineDetails1.TabIndex = 0;
            // 
            // frmFineDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(787, 404);
            this.Controls.Add(this.ctrlFineDetails1);
            this.MaximizeBox = false;
            this.Name = "frmFineDetails";
            this.Text = "frmFineDetails";
            this.ResumeLayout(false);

        }

        #endregion

        private Controls.ctrlFineDetails ctrlFineDetails1;
    }
}