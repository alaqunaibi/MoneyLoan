namespace PrjMoneyLoans
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lblCash = new System.Windows.Forms.Label();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.lblEntryId_User = new System.Windows.Forms.Label();
            this.btnLogin = new System.Windows.Forms.Button();
            this.btnReturn = new System.Windows.Forms.Button();
            this.pnlError = new System.Windows.Forms.Panel();
            this.lblError = new System.Windows.Forms.Label();
            this.pnlError.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtPassword
            // 
            this.txtPassword.BackColor = System.Drawing.Color.GhostWhite;
            this.txtPassword.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.txtPassword.ForeColor = System.Drawing.Color.DarkGreen;
            this.txtPassword.Location = new System.Drawing.Point(118, 103);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtPassword.Size = new System.Drawing.Size(181, 26);
            this.txtPassword.TabIndex = 234;
            this.txtPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblCash
            // 
            this.lblCash.AutoSize = true;
            this.lblCash.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.lblCash.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblCash.Location = new System.Drawing.Point(312, 110);
            this.lblCash.Name = "lblCash";
            this.lblCash.Size = new System.Drawing.Size(62, 19);
            this.lblCash.TabIndex = 236;
            this.lblCash.Text = "كلمة السر";
            // 
            // txtUserName
            // 
            this.txtUserName.BackColor = System.Drawing.Color.GhostWhite;
            this.txtUserName.Font = new System.Drawing.Font("Tahoma", 12F);
            this.txtUserName.ForeColor = System.Drawing.Color.Navy;
            this.txtUserName.Location = new System.Drawing.Point(119, 67);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtUserName.Size = new System.Drawing.Size(180, 27);
            this.txtUserName.TabIndex = 233;
            this.txtUserName.Tag = "int";
            this.txtUserName.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblEntryId_User
            // 
            this.lblEntryId_User.AutoSize = true;
            this.lblEntryId_User.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.lblEntryId_User.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblEntryId_User.Location = new System.Drawing.Point(312, 67);
            this.lblEntryId_User.Name = "lblEntryId_User";
            this.lblEntryId_User.Size = new System.Drawing.Size(81, 19);
            this.lblEntryId_User.TabIndex = 235;
            this.lblEntryId_User.Text = "اسم المستخدم";
            this.lblEntryId_User.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.Lavender;
            this.btnLogin.Font = new System.Drawing.Font("Arial", 13F, System.Drawing.FontStyle.Bold);
            this.btnLogin.ForeColor = System.Drawing.Color.Indigo;
            this.btnLogin.Location = new System.Drawing.Point(249, 167);
            this.btnLogin.Margin = new System.Windows.Forms.Padding(10, 3, 10, 3);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.btnLogin.Size = new System.Drawing.Size(90, 35);
            this.btnLogin.TabIndex = 238;
            this.btnLogin.Text = "دخول";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // btnReturn
            // 
            this.btnReturn.BackColor = System.Drawing.Color.Lavender;
            this.btnReturn.Font = new System.Drawing.Font("Arial", 13F, System.Drawing.FontStyle.Bold);
            this.btnReturn.ForeColor = System.Drawing.Color.Indigo;
            this.btnReturn.Location = new System.Drawing.Point(139, 167);
            this.btnReturn.Margin = new System.Windows.Forms.Padding(10, 3, 10, 3);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.btnReturn.Size = new System.Drawing.Size(90, 35);
            this.btnReturn.TabIndex = 237;
            this.btnReturn.Text = "عودة";
            this.btnReturn.UseVisualStyleBackColor = false;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // pnlError
            // 
            this.pnlError.BackColor = System.Drawing.Color.MistyRose;
            this.pnlError.Controls.Add(this.lblError);
            this.pnlError.ForeColor = System.Drawing.Color.Maroon;
            this.pnlError.Location = new System.Drawing.Point(12, 219);
            this.pnlError.Name = "pnlError";
            this.pnlError.Size = new System.Drawing.Size(471, 47);
            this.pnlError.TabIndex = 239;
            this.pnlError.Visible = false;
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblError.ForeColor = System.Drawing.Color.Maroon;
            this.lblError.Location = new System.Drawing.Point(96, 11);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(256, 20);
            this.lblError.TabIndex = 0;
            this.lblError.Text = "اسم المسنخدم  او  كلمة السر غير صحيحة";
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(495, 269);
            this.Controls.Add(this.pnlError);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.lblCash);
            this.Controls.Add(this.txtUserName);
            this.Controls.Add(this.lblEntryId_User);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmLogin";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Text = "Login";
            this.pnlError.ResumeLayout(false);
            this.pnlError.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label lblCash;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.Label lblEntryId_User;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Panel pnlError;
        private System.Windows.Forms.Label lblError;
    }
}