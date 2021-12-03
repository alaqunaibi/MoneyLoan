namespace PrjMoneyLoans
{
    partial class MDIMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MDIMain));
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.MnuDeposit = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuDepositors = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuCash = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.MnuRptDeposit = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.MnuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuBeneficary = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuOpenAccounts = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.MnuLoans = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuInstallments = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.MnuSysAdmin = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuLookups = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuNationality = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuSysCoding = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuTables = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuUsers = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuUserPermissions = new System.Windows.Forms.ToolStripMenuItem();
            this.windowsMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.cascadeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tileVerticalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tileHorizontalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.arrangeIconsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.MnuQuit = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MnuDeposit,
            this.MnuBeneficary,
            this.MnuSysAdmin,
            this.windowsMenu,
            this.MnuQuit});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.MdiWindowListItem = this.windowsMenu;
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(853, 24);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "MenuStrip";
            // 
            // MnuDeposit
            // 
            this.MnuDeposit.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MnuDepositors,
            this.MnuCash,
            this.toolStripSeparator5,
            this.MnuRptDeposit,
            this.toolStripSeparator3,
            this.MnuExit});
            this.MnuDeposit.ImageTransparentColor = System.Drawing.SystemColors.ActiveBorder;
            this.MnuDeposit.Name = "MnuDeposit";
            this.MnuDeposit.Size = new System.Drawing.Size(48, 20);
            this.MnuDeposit.Text = "الايداع";
            // 
            // MnuDepositors
            // 
            this.MnuDepositors.Image = ((System.Drawing.Image)(resources.GetObject("MnuDepositors.Image")));
            this.MnuDepositors.ImageTransparentColor = System.Drawing.Color.Black;
            this.MnuDepositors.Name = "MnuDepositors";
            this.MnuDepositors.Size = new System.Drawing.Size(152, 22);
            this.MnuDepositors.Text = "المودعون";
            this.MnuDepositors.Click += new System.EventHandler(this.MnuDepositors_Click);
            // 
            // MnuCash
            // 
            this.MnuCash.ImageTransparentColor = System.Drawing.Color.Black;
            this.MnuCash.Name = "MnuCash";
            this.MnuCash.Size = new System.Drawing.Size(152, 22);
            this.MnuCash.Text = "الصندوق";
            this.MnuCash.Click += new System.EventHandler(this.OpenFile);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(149, 6);
            // 
            // MnuRptDeposit
            // 
            this.MnuRptDeposit.Name = "MnuRptDeposit";
            this.MnuRptDeposit.Size = new System.Drawing.Size(152, 22);
            this.MnuRptDeposit.Text = "التقارير";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(149, 6);
            // 
            // MnuExit
            // 
            this.MnuExit.Name = "MnuExit";
            this.MnuExit.Size = new System.Drawing.Size(152, 22);
            this.MnuExit.Text = "الخروج";
            this.MnuExit.Click += new System.EventHandler(this.ExitToolsStripMenuItem_Click);
            // 
            // MnuBeneficary
            // 
            this.MnuBeneficary.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MnuOpenAccounts,
            this.toolStripSeparator6,
            this.MnuLoans,
            this.MnuInstallments,
            this.toolStripSeparator4,
            this.toolStripMenuItem1,
            this.toolStripSeparator7});
            this.MnuBeneficary.Name = "MnuBeneficary";
            this.MnuBeneficary.Size = new System.Drawing.Size(77, 20);
            this.MnuBeneficary.Text = "المستفيدون";
            // 
            // MnuOpenAccounts
            // 
            this.MnuOpenAccounts.ImageTransparentColor = System.Drawing.Color.Black;
            this.MnuOpenAccounts.Name = "MnuOpenAccounts";
            this.MnuOpenAccounts.Size = new System.Drawing.Size(152, 22);
            this.MnuOpenAccounts.Text = "الحسابات";
            this.MnuOpenAccounts.Click += new System.EventHandler(this.MnuOpenAccounts_Click);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(149, 6);
            // 
            // MnuLoans
            // 
            this.MnuLoans.ImageTransparentColor = System.Drawing.Color.Black;
            this.MnuLoans.Name = "MnuLoans";
            this.MnuLoans.Size = new System.Drawing.Size(152, 22);
            this.MnuLoans.Text = "القروض";
            this.MnuLoans.Click += new System.EventHandler(this.MnuLoans_Click);
            // 
            // MnuInstallments
            // 
            this.MnuInstallments.ImageTransparentColor = System.Drawing.Color.Black;
            this.MnuInstallments.Name = "MnuInstallments";
            this.MnuInstallments.Size = new System.Drawing.Size(152, 22);
            this.MnuInstallments.Text = "الأقساط";
            this.MnuInstallments.Click += new System.EventHandler(this.MnuInstallments_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(149, 6);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.toolStripMenuItem1.Text = "التقارير";
            // 
            // toolStripSeparator7
            // 
            this.toolStripSeparator7.Name = "toolStripSeparator7";
            this.toolStripSeparator7.Size = new System.Drawing.Size(149, 6);
            // 
            // MnuSysAdmin
            // 
            this.MnuSysAdmin.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MnuLookups,
            this.MnuUsers,
            this.MnuUserPermissions});
            this.MnuSysAdmin.Name = "MnuSysAdmin";
            this.MnuSysAdmin.Size = new System.Drawing.Size(75, 20);
            this.MnuSysAdmin.Text = "ادارة النظام";
            this.MnuSysAdmin.Visible = false;
            // 
            // MnuLookups
            // 
            this.MnuLookups.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MnuNationality,
            this.MnuSysCoding,
            this.MnuTables});
            this.MnuLookups.Name = "MnuLookups";
            this.MnuLookups.Size = new System.Drawing.Size(174, 22);
            this.MnuLookups.Text = "قوائم النظام";
            this.MnuLookups.Click += new System.EventHandler(this.ToolBarToolStripMenuItem_Click);
            // 
            // MnuNationality
            // 
            this.MnuNationality.Name = "MnuNationality";
            this.MnuNationality.Size = new System.Drawing.Size(152, 22);
            this.MnuNationality.Text = "الجنسيات";
            this.MnuNationality.Click += new System.EventHandler(this.MnuNationality_Click);
            // 
            // MnuSysCoding
            // 
            this.MnuSysCoding.Name = "MnuSysCoding";
            this.MnuSysCoding.Size = new System.Drawing.Size(152, 22);
            this.MnuSysCoding.Text = "قوائم الترميز";
            this.MnuSysCoding.Visible = false;
            this.MnuSysCoding.Click += new System.EventHandler(this.MnuSysCoding_Click);
            // 
            // MnuTables
            // 
            this.MnuTables.Name = "MnuTables";
            this.MnuTables.Size = new System.Drawing.Size(152, 22);
            this.MnuTables.Text = "الجداول";
            this.MnuTables.Visible = false;
            this.MnuTables.Click += new System.EventHandler(this.MnuTables_Click);
            // 
            // MnuUsers
            // 
            this.MnuUsers.Name = "MnuUsers";
            this.MnuUsers.Size = new System.Drawing.Size(174, 22);
            this.MnuUsers.Text = "المستخدون";
            this.MnuUsers.Click += new System.EventHandler(this.StatusBarToolStripMenuItem_Click);
            // 
            // MnuUserPermissions
            // 
            this.MnuUserPermissions.Name = "MnuUserPermissions";
            this.MnuUserPermissions.Size = new System.Drawing.Size(174, 22);
            this.MnuUserPermissions.Text = "الأذونات والصلاحيات";
            // 
            // windowsMenu
            // 
            this.windowsMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cascadeToolStripMenuItem,
            this.tileVerticalToolStripMenuItem,
            this.tileHorizontalToolStripMenuItem,
            this.closeAllToolStripMenuItem,
            this.arrangeIconsToolStripMenuItem});
            this.windowsMenu.Name = "windowsMenu";
            this.windowsMenu.Size = new System.Drawing.Size(85, 20);
            this.windowsMenu.Text = "تنظيم النوافـذ";
            this.windowsMenu.Visible = false;
            // 
            // cascadeToolStripMenuItem
            // 
            this.cascadeToolStripMenuItem.Name = "cascadeToolStripMenuItem";
            this.cascadeToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.cascadeToolStripMenuItem.Text = "تتابع";
            this.cascadeToolStripMenuItem.Click += new System.EventHandler(this.CascadeToolStripMenuItem_Click);
            // 
            // tileVerticalToolStripMenuItem
            // 
            this.tileVerticalToolStripMenuItem.Name = "tileVerticalToolStripMenuItem";
            this.tileVerticalToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.tileVerticalToolStripMenuItem.Text = "ترتيب عمودي";
            this.tileVerticalToolStripMenuItem.Click += new System.EventHandler(this.TileVerticalToolStripMenuItem_Click);
            // 
            // tileHorizontalToolStripMenuItem
            // 
            this.tileHorizontalToolStripMenuItem.Name = "tileHorizontalToolStripMenuItem";
            this.tileHorizontalToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.tileHorizontalToolStripMenuItem.Text = "ترتيب افقي";
            this.tileHorizontalToolStripMenuItem.Click += new System.EventHandler(this.TileHorizontalToolStripMenuItem_Click);
            // 
            // closeAllToolStripMenuItem
            // 
            this.closeAllToolStripMenuItem.Name = "closeAllToolStripMenuItem";
            this.closeAllToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.closeAllToolStripMenuItem.Text = "اغلاق الكل";
            this.closeAllToolStripMenuItem.Click += new System.EventHandler(this.CloseAllToolStripMenuItem_Click);
            // 
            // arrangeIconsToolStripMenuItem
            // 
            this.arrangeIconsToolStripMenuItem.Name = "arrangeIconsToolStripMenuItem";
            this.arrangeIconsToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.arrangeIconsToolStripMenuItem.Text = "تنظيم وترتيب";
            this.arrangeIconsToolStripMenuItem.Click += new System.EventHandler(this.ArrangeIconsToolStripMenuItem_Click);
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel});
            this.statusStrip.Location = new System.Drawing.Point(0, 431);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(853, 22);
            this.statusStrip.TabIndex = 2;
            this.statusStrip.Text = "StatusStrip";
            // 
            // toolStripStatusLabel
            // 
            this.toolStripStatusLabel.Name = "toolStripStatusLabel";
            this.toolStripStatusLabel.Size = new System.Drawing.Size(39, 17);
            this.toolStripStatusLabel.Text = "Status";
            // 
            // MnuQuit
            // 
            this.MnuQuit.Name = "MnuQuit";
            this.MnuQuit.Size = new System.Drawing.Size(51, 20);
            this.MnuQuit.Text = "الخروج";
            this.MnuQuit.Click += new System.EventHandler(this.MnuQuit_Click);
            // 
            // MDIMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(853, 453);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.menuStrip);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip;
            this.Name = "MDIMain";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "نظام إدارة القروض والأقساط";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MDIMain_Load);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion


        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
        private System.Windows.Forms.ToolStripMenuItem tileHorizontalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MnuDeposit;
        public System.Windows.Forms.ToolStripMenuItem MnuDepositors;
        private System.Windows.Forms.ToolStripMenuItem MnuCash;
        private System.Windows.Forms.ToolStripMenuItem MnuExit;
        private System.Windows.Forms.ToolStripMenuItem MnuBeneficary;
        private System.Windows.Forms.ToolStripMenuItem MnuOpenAccounts;
        private System.Windows.Forms.ToolStripMenuItem MnuInstallments;
        private System.Windows.Forms.ToolStripMenuItem MnuLoans;
        private System.Windows.Forms.ToolStripMenuItem MnuSysAdmin;
        private System.Windows.Forms.ToolStripMenuItem MnuLookups;
        private System.Windows.Forms.ToolStripMenuItem MnuUsers;
        private System.Windows.Forms.ToolStripMenuItem windowsMenu;
        private System.Windows.Forms.ToolStripMenuItem cascadeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tileVerticalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeAllToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem arrangeIconsToolStripMenuItem;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.ToolStripMenuItem MnuRptDeposit;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator7;
        private System.Windows.Forms.ToolStripMenuItem MnuUserPermissions;
        private System.Windows.Forms.ToolStripMenuItem MnuNationality;
        private System.Windows.Forms.ToolStripMenuItem MnuSysCoding;
        private System.Windows.Forms.ToolStripMenuItem MnuTables;
        private System.Windows.Forms.ToolStripMenuItem MnuQuit;
    }
}



