namespace Library_Management_System.Fine
{
    partial class frmPayFine
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
            this.ctrlFine1 = new Library_Management_System.Fine.ctrlFine();
            this.SuspendLayout();
            // 
            // ctrlFine1
            // 
            this.ctrlFine1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(245)))), ((int)(((byte)(249)))));
            this.ctrlFine1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ctrlFine1.Location = new System.Drawing.Point(-3, -2);
            this.ctrlFine1.MinimumSize = new System.Drawing.Size(650, 464);
            this.ctrlFine1.Name = "ctrlFine1";
            this.ctrlFine1.Size = new System.Drawing.Size(813, 466);
            this.ctrlFine1.TabIndex = 0;
            // 
            // frmPayFine
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(790, 461);
            this.Controls.Add(this.ctrlFine1);
            this.MaximizeBox = false;
            this.Name = "frmPayFine";
            this.Text = "frmPayFine";
            //this.Load += new System.EventHandler(this.frmPayFine_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private ctrlFine ctrlFine1;
    }
}