namespace Library_Management_System
{
    partial class frmLogin
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
            this.components = new System.ComponentModel.Container();
            this.formElipse = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.pnlBrand = new System.Windows.Forms.Panel();
            this.pnlQuote = new Guna.UI2.WinForms.Guna2Panel();
            this.lblQuoteAuthor = new System.Windows.Forms.Label();
            this.lblQuote = new System.Windows.Forms.Label();
            this.lblBrandDescription = new System.Windows.Forms.Label();
            this.lblHeroTitle = new System.Windows.Forms.Label();
            this.lblBrandSubtitle = new System.Windows.Forms.Label();
            this.lblBrandName = new System.Windows.Forms.Label();
            this.lblLogo = new System.Windows.Forms.Label();
            this.pnlLogin = new System.Windows.Forms.Panel();
            this.lblCopyright = new System.Windows.Forms.Label();
            this.pnlLoginContent = new System.Windows.Forms.Panel();
            this.lblSecurity = new System.Windows.Forms.Label();
            this.lblError = new System.Windows.Forms.Label();
            this.btnLogIn = new Guna.UI2.WinForms.Guna2Button();
            this.chkRememberMe = new Guna.UI2.WinForms.Guna2CheckBox();
            this.btnShowPassword = new Guna.UI2.WinForms.Guna2Button();
            this.txtPassword = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtUserName = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblUserName = new System.Windows.Forms.Label();
            this.pnlAccent = new System.Windows.Forms.Panel();
            this.lblWelcomeSubtitle = new System.Windows.Forms.Label();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.btnClose = new Guna.UI2.WinForms.Guna2Button();
            this.dragControl = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.pnlBrand.SuspendLayout();
            this.pnlQuote.SuspendLayout();
            this.pnlLogin.SuspendLayout();
            this.pnlLoginContent.SuspendLayout();
            this.SuspendLayout();
            // 
            // formElipse
            // 
            this.formElipse.BorderRadius = 18;
            this.formElipse.TargetControl = this;
            // 
            // pnlBrand
            // 
            this.pnlBrand.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(36)))), ((int)(((byte)(58)))));
            this.pnlBrand.Controls.Add(this.pnlQuote);
            this.pnlBrand.Controls.Add(this.lblBrandDescription);
            this.pnlBrand.Controls.Add(this.lblHeroTitle);
            this.pnlBrand.Controls.Add(this.lblBrandSubtitle);
            this.pnlBrand.Controls.Add(this.lblBrandName);
            this.pnlBrand.Controls.Add(this.lblLogo);
            this.pnlBrand.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlBrand.Location = new System.Drawing.Point(0, 0);
            this.pnlBrand.Name = "pnlBrand";
            this.pnlBrand.Size = new System.Drawing.Size(440, 700);
            this.pnlBrand.TabIndex = 0;
            // 
            // pnlQuote
            // 
            this.pnlQuote.BackColor = System.Drawing.Color.Transparent;
            this.pnlQuote.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.pnlQuote.BorderRadius = 12;
            this.pnlQuote.BorderThickness = 1;
            this.pnlQuote.Controls.Add(this.lblQuoteAuthor);
            this.pnlQuote.Controls.Add(this.lblQuote);
            this.pnlQuote.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.pnlQuote.Location = new System.Drawing.Point(48, 536);
            this.pnlQuote.Name = "pnlQuote";
            this.pnlQuote.Size = new System.Drawing.Size(344, 112);
            this.pnlQuote.TabIndex = 5;
            // 
            // lblQuoteAuthor
            // 
            this.lblQuoteAuthor.AutoSize = true;
            this.lblQuoteAuthor.BackColor = System.Drawing.Color.Transparent;
            this.lblQuoteAuthor.Font = new System.Drawing.Font("Segoe UI Semibold", 8.5F, System.Drawing.FontStyle.Bold);
            this.lblQuoteAuthor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(206)))), ((int)(((byte)(192)))));
            this.lblQuoteAuthor.Location = new System.Drawing.Point(20, 78);
            this.lblQuoteAuthor.Name = "lblQuoteAuthor";
            this.lblQuoteAuthor.Size = new System.Drawing.Size(137, 15);
            this.lblQuoteAuthor.TabIndex = 1;
            this.lblQuoteAuthor.Text = "— YOUR LIBRARY TEAM";
            // 
            // lblQuote
            // 
            this.lblQuote.BackColor = System.Drawing.Color.Transparent;
            this.lblQuote.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblQuote.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(232)))), ((int)(((byte)(242)))));
            this.lblQuote.Location = new System.Drawing.Point(20, 17);
            this.lblQuote.Name = "lblQuote";
            this.lblQuote.Size = new System.Drawing.Size(303, 49);
            this.lblQuote.TabIndex = 0;
            this.lblQuote.Text = "\"A library is not a luxury but one of the necessities of life.\"";
            // 
            // lblBrandDescription
            // 
            this.lblBrandDescription.BackColor = System.Drawing.Color.Transparent;
            this.lblBrandDescription.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.lblBrandDescription.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(187)))), ((int)(((byte)(207)))));
            this.lblBrandDescription.Location = new System.Drawing.Point(48, 311);
            this.lblBrandDescription.Name = "lblBrandDescription";
            this.lblBrandDescription.Size = new System.Drawing.Size(328, 55);
            this.lblBrandDescription.TabIndex = 4;
            this.lblBrandDescription.Text = "Manage books, members, and everyday library operations from one thoughtful space." +
    "";
            // 
            // lblHeroTitle
            // 
            this.lblHeroTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblHeroTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 27F, System.Drawing.FontStyle.Bold);
            this.lblHeroTitle.ForeColor = System.Drawing.Color.White;
            this.lblHeroTitle.Location = new System.Drawing.Point(43, 207);
            this.lblHeroTitle.Name = "lblHeroTitle";
            this.lblHeroTitle.Size = new System.Drawing.Size(350, 99);
            this.lblHeroTitle.TabIndex = 3;
            this.lblHeroTitle.Text = "Where every story\r\nfinds its reader.";
            // 
            // lblBrandSubtitle
            // 
            this.lblBrandSubtitle.AutoSize = true;
            this.lblBrandSubtitle.BackColor = System.Drawing.Color.Transparent;
            this.lblBrandSubtitle.Font = new System.Drawing.Font("Segoe UI Semibold", 7.5F, System.Drawing.FontStyle.Bold);
            this.lblBrandSubtitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(174)))), ((int)(((byte)(199)))));
            this.lblBrandSubtitle.Location = new System.Drawing.Point(111, 86);
            this.lblBrandSubtitle.Name = "lblBrandSubtitle";
            this.lblBrandSubtitle.Size = new System.Drawing.Size(118, 12);
            this.lblBrandSubtitle.TabIndex = 2;
            this.lblBrandSubtitle.Text = "LIBRARY MANAGEMENT";
            // 
            // lblBrandName
            // 
            this.lblBrandName.AutoSize = true;
            this.lblBrandName.BackColor = System.Drawing.Color.Transparent;
            this.lblBrandName.Font = new System.Drawing.Font("Segoe UI Semibold", 17F, System.Drawing.FontStyle.Bold);
            this.lblBrandName.ForeColor = System.Drawing.Color.White;
            this.lblBrandName.Location = new System.Drawing.Point(107, 54);
            this.lblBrandName.Name = "lblBrandName";
            this.lblBrandName.Size = new System.Drawing.Size(75, 31);
            this.lblBrandName.TabIndex = 1;
            this.lblBrandName.Text = "LIBRA";
            // 
            // lblLogo
            // 
            this.lblLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(170)))), ((int)(((byte)(158)))));
            this.lblLogo.Font = new System.Drawing.Font("Georgia", 22F, System.Drawing.FontStyle.Bold);
            this.lblLogo.ForeColor = System.Drawing.Color.White;
            this.lblLogo.Location = new System.Drawing.Point(48, 53);
            this.lblLogo.Name = "lblLogo";
            this.lblLogo.Size = new System.Drawing.Size(48, 48);
            this.lblLogo.TabIndex = 0;
            this.lblLogo.Text = "L";
            this.lblLogo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlLogin
            // 
            this.pnlLogin.BackColor = System.Drawing.Color.White;
            this.pnlLogin.Controls.Add(this.lblCopyright);
            this.pnlLogin.Controls.Add(this.pnlLoginContent);
            this.pnlLogin.Controls.Add(this.btnClose);
            this.pnlLogin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlLogin.Location = new System.Drawing.Point(440, 0);
            this.pnlLogin.Name = "pnlLogin";
            this.pnlLogin.Size = new System.Drawing.Size(680, 700);
            this.pnlLogin.TabIndex = 1;
            //this.pnlLogin.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlLogin_Paint);
            // 
            // lblCopyright
            // 
            this.lblCopyright.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCopyright.AutoSize = true;
            this.lblCopyright.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.lblCopyright.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(164)))), ((int)(((byte)(179)))));
            this.lblCopyright.Location = new System.Drawing.Point(469, 660);
            this.lblCopyright.Name = "lblCopyright";
            this.lblCopyright.Size = new System.Drawing.Size(152, 13);
            this.lblCopyright.TabIndex = 2;
            this.lblCopyright.Text = "© 2026 Library Management";
            // 
            // pnlLoginContent
            // 
            this.pnlLoginContent.Controls.Add(this.lblSecurity);
            this.pnlLoginContent.Controls.Add(this.lblError);
            this.pnlLoginContent.Controls.Add(this.btnLogIn);
            this.pnlLoginContent.Controls.Add(this.chkRememberMe);
            this.pnlLoginContent.Controls.Add(this.btnShowPassword);
            this.pnlLoginContent.Controls.Add(this.txtPassword);
            this.pnlLoginContent.Controls.Add(this.lblPassword);
            this.pnlLoginContent.Controls.Add(this.txtUserName);
            this.pnlLoginContent.Controls.Add(this.lblUserName);
            this.pnlLoginContent.Controls.Add(this.pnlAccent);
            this.pnlLoginContent.Controls.Add(this.lblWelcomeSubtitle);
            this.pnlLoginContent.Controls.Add(this.lblWelcome);
            this.pnlLoginContent.Location = new System.Drawing.Point(69, 67);
            this.pnlLoginContent.Name = "pnlLoginContent";
            this.pnlLoginContent.Size = new System.Drawing.Size(499, 546);
            this.pnlLoginContent.TabIndex = 1;
            // 
            // lblSecurity
            // 
            this.lblSecurity.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.lblSecurity.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(152)))), ((int)(((byte)(169)))));
            this.lblSecurity.Location = new System.Drawing.Point(0, 484);
            this.lblSecurity.Name = "lblSecurity";
            this.lblSecurity.Size = new System.Drawing.Size(456, 18);
            this.lblSecurity.TabIndex = 12;
            this.lblSecurity.Text = "●  Secure access · Authorized library staff only";
            this.lblSecurity.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.lblError.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.lblError.Location = new System.Drawing.Point(22, 386);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(231, 15);
            this.lblError.TabIndex = 10;
            this.lblError.Text = "Please enter your username and password.";
            this.lblError.Visible = false;
            // 
            // btnLogIn
            // 
            this.btnLogIn.BorderRadius = 9;
            this.btnLogIn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogIn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnLogIn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnLogIn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnLogIn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnLogIn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(166)))), ((int)(((byte)(154)))));
            this.btnLogIn.Font = new System.Drawing.Font("Segoe UI Semibold", 10.5F, System.Drawing.FontStyle.Bold);
            this.btnLogIn.ForeColor = System.Drawing.Color.White;
            this.btnLogIn.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(145)))), ((int)(((byte)(135)))));
            this.btnLogIn.Location = new System.Drawing.Point(22, 416);
            this.btnLogIn.Name = "btnLogIn";
            this.btnLogIn.Size = new System.Drawing.Size(456, 50);
            this.btnLogIn.TabIndex = 5;
            this.btnLogIn.Text = "LOG IN";
            this.btnLogIn.Click += new System.EventHandler(this.btnLogIn_Click);
            // 
            // chkRememberMe
            // 
            this.chkRememberMe.AutoSize = true;
            this.chkRememberMe.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(166)))), ((int)(((byte)(154)))));
            this.chkRememberMe.CheckedState.BorderRadius = 4;
            this.chkRememberMe.CheckedState.BorderThickness = 0;
            this.chkRememberMe.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(166)))), ((int)(((byte)(154)))));
            this.chkRememberMe.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chkRememberMe.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.chkRememberMe.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(87)))), ((int)(((byte)(105)))));
            this.chkRememberMe.Location = new System.Drawing.Point(22, 356);
            this.chkRememberMe.Name = "chkRememberMe";
            this.chkRememberMe.Size = new System.Drawing.Size(104, 19);
            this.chkRememberMe.TabIndex = 3;
            this.chkRememberMe.Text = "Remember me";
            this.chkRememberMe.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(191)))), ((int)(((byte)(205)))));
            this.chkRememberMe.UncheckedState.BorderRadius = 4;
            this.chkRememberMe.UncheckedState.BorderThickness = 1;
            this.chkRememberMe.UncheckedState.FillColor = System.Drawing.Color.White;
            // 
            // btnShowPassword
            // 
            this.btnShowPassword.BackColor = System.Drawing.Color.Transparent;
            this.btnShowPassword.BorderRadius = 6;
            this.btnShowPassword.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnShowPassword.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnShowPassword.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnShowPassword.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnShowPassword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnShowPassword.FillColor = System.Drawing.Color.White;
            this.btnShowPassword.Font = new System.Drawing.Font("Segoe UI Semibold", 8F, System.Drawing.FontStyle.Bold);
            this.btnShowPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(147)))), ((int)(((byte)(138)))));
            this.btnShowPassword.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(249)))), ((int)(((byte)(247)))));
            this.btnShowPassword.Location = new System.Drawing.Point(403, 239);
            this.btnShowPassword.Name = "btnShowPassword";
            this.btnShowPassword.Size = new System.Drawing.Size(75, 30);
            this.btnShowPassword.TabIndex = 9;
            this.btnShowPassword.TabStop = false;
            this.btnShowPassword.Text = "SHOW";
            // 
            // txtPassword
            // 
            this.txtPassword.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(214)))), ((int)(((byte)(227)))));
            this.txtPassword.BorderRadius = 9;
            this.txtPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPassword.DefaultText = "";
            this.txtPassword.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(166)))), ((int)(((byte)(154)))));
            this.txtPassword.FocusedState.FillColor = System.Drawing.Color.White;
            this.txtPassword.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(50)))), ((int)(((byte)(69)))));
            this.txtPassword.Location = new System.Drawing.Point(22, 277);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '●';
            this.txtPassword.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(166)))), ((int)(((byte)(180)))));
            this.txtPassword.PlaceholderText = "Enter your password";
            this.txtPassword.SelectedText = "";
            this.txtPassword.Size = new System.Drawing.Size(456, 50);
            this.txtPassword.TabIndex = 2;
            this.txtPassword.TextOffset = new System.Drawing.Point(6, 0);
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.lblPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(78)))), ((int)(((byte)(98)))));
            this.lblPassword.Location = new System.Drawing.Point(19, 253);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(57, 15);
            this.lblPassword.TabIndex = 7;
            this.lblPassword.Text = "Password";
            // 
            // txtUserName
            // 
            this.txtUserName.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(214)))), ((int)(((byte)(227)))));
            this.txtUserName.BorderRadius = 9;
            this.txtUserName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtUserName.DefaultText = "";
            this.txtUserName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(166)))), ((int)(((byte)(154)))));
            this.txtUserName.FocusedState.FillColor = System.Drawing.Color.White;
            this.txtUserName.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtUserName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(50)))), ((int)(((byte)(69)))));
            this.txtUserName.Location = new System.Drawing.Point(22, 176);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(166)))), ((int)(((byte)(180)))));
            this.txtUserName.PlaceholderText = "Enter your username";
            this.txtUserName.SelectedText = "";
            this.txtUserName.Size = new System.Drawing.Size(456, 50);
            this.txtUserName.TabIndex = 1;
            this.txtUserName.TextOffset = new System.Drawing.Point(6, 0);
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.lblUserName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(78)))), ((int)(((byte)(98)))));
            this.lblUserName.Location = new System.Drawing.Point(19, 152);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(63, 15);
            this.lblUserName.TabIndex = 5;
            this.lblUserName.Text = "User name";
            // 
            // pnlAccent
            // 
            this.pnlAccent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(166)))), ((int)(((byte)(154)))));
            this.pnlAccent.Location = new System.Drawing.Point(22, 119);
            this.pnlAccent.Name = "pnlAccent";
            this.pnlAccent.Size = new System.Drawing.Size(42, 3);
            this.pnlAccent.TabIndex = 4;
            // 
            // lblWelcomeSubtitle
            // 
            this.lblWelcomeSubtitle.AutoSize = true;
            this.lblWelcomeSubtitle.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblWelcomeSubtitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(128)))), ((int)(((byte)(146)))));
            this.lblWelcomeSubtitle.Location = new System.Drawing.Point(19, 80);
            this.lblWelcomeSubtitle.Name = "lblWelcomeSubtitle";
            this.lblWelcomeSubtitle.Size = new System.Drawing.Size(286, 19);
            this.lblWelcomeSubtitle.TabIndex = 3;
            this.lblWelcomeSubtitle.Text = "Sign in to continue to your library workspace.";
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Font = new System.Drawing.Font("Segoe UI Semibold", 26F, System.Drawing.FontStyle.Bold);
            this.lblWelcome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(38)))), ((int)(((byte)(58)))));
            this.lblWelcome.Location = new System.Drawing.Point(18, 24);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(251, 47);
            this.lblWelcome.TabIndex = 2;
            this.lblWelcome.Text = "Welcome back";
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.BorderRadius = 8;
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnClose.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnClose.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnClose.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnClose.FillColor = System.Drawing.Color.White;
            this.btnClose.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.btnClose.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(110)))), ((int)(((byte)(127)))));
            this.btnClose.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(239)))), ((int)(((byte)(239)))));
            this.btnClose.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
            this.btnClose.Location = new System.Drawing.Point(624, 16);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(40, 40);
            this.btnClose.TabIndex = 6;
            this.btnClose.TabStop = false;
            this.btnClose.Text = "×";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // dragControl
            // 
            this.dragControl.DockIndicatorTransparencyValue = 0.6D;
            this.dragControl.TargetControl = this.pnlBrand;
            this.dragControl.UseTransparentDrag = true;
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1120, 700);
            this.Controls.Add(this.pnlLogin);
            this.Controls.Add(this.pnlBrand);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Library Management - Sign in";
            this.pnlBrand.ResumeLayout(false);
            this.pnlBrand.PerformLayout();
            this.pnlQuote.ResumeLayout(false);
            this.pnlQuote.PerformLayout();
            this.pnlLogin.ResumeLayout(false);
            this.pnlLogin.PerformLayout();
            this.pnlLoginContent.ResumeLayout(false);
            this.pnlLoginContent.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Elipse formElipse;
        private System.Windows.Forms.Panel pnlBrand;
        private Guna.UI2.WinForms.Guna2Panel pnlQuote;
        private System.Windows.Forms.Label lblQuoteAuthor;
        private System.Windows.Forms.Label lblQuote;
        private System.Windows.Forms.Label lblBrandDescription;
        private System.Windows.Forms.Label lblHeroTitle;
        private System.Windows.Forms.Label lblBrandSubtitle;
        private System.Windows.Forms.Label lblBrandName;
        private System.Windows.Forms.Label lblLogo;
        private System.Windows.Forms.Panel pnlLogin;
        private System.Windows.Forms.Label lblCopyright;
        private System.Windows.Forms.Panel pnlLoginContent;
        private System.Windows.Forms.Label lblSecurity;
        private System.Windows.Forms.Label lblError;
        private Guna.UI2.WinForms.Guna2Button btnLogIn;
        private Guna.UI2.WinForms.Guna2CheckBox chkRememberMe;
        private Guna.UI2.WinForms.Guna2Button btnShowPassword;
        private Guna.UI2.WinForms.Guna2TextBox txtPassword;
        private System.Windows.Forms.Label lblPassword;
        private Guna.UI2.WinForms.Guna2TextBox txtUserName;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.Panel pnlAccent;
        private System.Windows.Forms.Label lblWelcomeSubtitle;
        private System.Windows.Forms.Label lblWelcome;
        private Guna.UI2.WinForms.Guna2Button btnClose;
        private Guna.UI2.WinForms.Guna2DragControl dragControl;
    }
}
