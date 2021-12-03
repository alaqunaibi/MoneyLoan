namespace PrjMoneyLoans
{
    partial class frmDepositors
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDepositors));
            this.btnNew = new System.Windows.Forms.Button();
            this.btnsave = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnPrint = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnReturn = new System.Windows.Forms.Button();
            this.grdDepositors = new System.Windows.Forms.DataGridView();
            this.gDepositorId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gDepositorId_User = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gDepositorIdName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.txtDepositorId = new System.Windows.Forms.TextBox();
            this.PnlLblSchoolName = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.txtDepositorName = new System.Windows.Forms.TextBox();
            this.lblDepositorName = new System.Windows.Forms.Label();
            this.txtNotes = new System.Windows.Forms.TextBox();
            this.lblNotes = new System.Windows.Forms.Label();
            this.txtOtherPhone = new System.Windows.Forms.TextBox();
            this.lblOtherPhone = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.lblAddress = new System.Windows.Forms.Label();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.lblphone = new System.Windows.Forms.Label();
            this.txtDepositorID_User = new System.Windows.Forms.TextBox();
            this.lblDepositorId_User = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.mnuStdReports = new System.Windows.Forms.ToolStripDropDownButton();
            this.MnuRptCashDepositors = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.label1 = new System.Windows.Forms.Label();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdDepositors)).BeginInit();
            this.PnlLblSchoolName.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnNew
            // 
            this.btnNew.BackColor = System.Drawing.Color.Lavender;
            this.btnNew.Font = new System.Drawing.Font("Arial", 13F, System.Drawing.FontStyle.Bold);
            this.btnNew.ForeColor = System.Drawing.Color.Purple;
            this.btnNew.Location = new System.Drawing.Point(700, 3);
            this.btnNew.Margin = new System.Windows.Forms.Padding(10, 3, 10, 3);
            this.btnNew.Name = "btnNew";
            this.btnNew.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.btnNew.Size = new System.Drawing.Size(90, 35);
            this.btnNew.TabIndex = 11;
            this.btnNew.Text = "جديـــد";
            this.btnNew.UseVisualStyleBackColor = false;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnsave
            // 
            this.btnsave.BackColor = System.Drawing.Color.Lavender;
            this.btnsave.Font = new System.Drawing.Font("Arial", 13F, System.Drawing.FontStyle.Bold);
            this.btnsave.ForeColor = System.Drawing.Color.Purple;
            this.btnsave.Location = new System.Drawing.Point(590, 3);
            this.btnsave.Margin = new System.Windows.Forms.Padding(10, 3, 10, 3);
            this.btnsave.Name = "btnsave";
            this.btnsave.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.btnsave.Size = new System.Drawing.Size(90, 35);
            this.btnsave.TabIndex = 8;
            this.btnsave.Text = "حفظ";
            this.btnsave.UseVisualStyleBackColor = false;
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.Lavender;
            this.btnClear.Font = new System.Drawing.Font("Arial", 13F, System.Drawing.FontStyle.Bold);
            this.btnClear.ForeColor = System.Drawing.Color.Purple;
            this.btnClear.Location = new System.Drawing.Point(459, 3);
            this.btnClear.Margin = new System.Windows.Forms.Padding(10, 3, 10, 3);
            this.btnClear.Name = "btnClear";
            this.btnClear.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.btnClear.Size = new System.Drawing.Size(111, 35);
            this.btnClear.TabIndex = 12;
            this.btnClear.Text = "مسح / تنظيف";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Lavender;
            this.btnDelete.Font = new System.Drawing.Font("Arial", 13F, System.Drawing.FontStyle.Bold);
            this.btnDelete.ForeColor = System.Drawing.Color.Purple;
            this.btnDelete.Location = new System.Drawing.Point(339, 3);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(10, 3, 10, 3);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.btnDelete.Size = new System.Drawing.Size(100, 35);
            this.btnDelete.TabIndex = 23;
            this.btnDelete.Text = "حــذف";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.Lavender;
            this.btnSearch.Font = new System.Drawing.Font("Arial", 13F, System.Drawing.FontStyle.Bold);
            this.btnSearch.ForeColor = System.Drawing.Color.Purple;
            this.btnSearch.Location = new System.Drawing.Point(229, 3);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(10, 3, 10, 3);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.btnSearch.Size = new System.Drawing.Size(90, 35);
            this.btnSearch.TabIndex = 9;
            this.btnSearch.Text = "بحث";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnPrint
            // 
            this.btnPrint.BackColor = System.Drawing.Color.Lavender;
            this.btnPrint.Font = new System.Drawing.Font("Arial", 13F, System.Drawing.FontStyle.Bold);
            this.btnPrint.ForeColor = System.Drawing.Color.Purple;
            this.btnPrint.Location = new System.Drawing.Point(119, 3);
            this.btnPrint.Margin = new System.Windows.Forms.Padding(10, 3, 10, 3);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.btnPrint.Size = new System.Drawing.Size(90, 35);
            this.btnPrint.TabIndex = 10;
            this.btnPrint.Text = "طباعة";
            this.btnPrint.UseVisualStyleBackColor = false;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.btnNew);
            this.flowLayoutPanel1.Controls.Add(this.btnsave);
            this.flowLayoutPanel1.Controls.Add(this.btnClear);
            this.flowLayoutPanel1.Controls.Add(this.btnDelete);
            this.flowLayoutPanel1.Controls.Add(this.btnSearch);
            this.flowLayoutPanel1.Controls.Add(this.btnPrint);
            this.flowLayoutPanel1.Controls.Add(this.btnReturn);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(12, 331);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.flowLayoutPanel1.Size = new System.Drawing.Size(800, 42);
            this.flowLayoutPanel1.TabIndex = 148;
            // 
            // btnReturn
            // 
            this.btnReturn.BackColor = System.Drawing.Color.Lavender;
            this.btnReturn.Font = new System.Drawing.Font("Arial", 13F, System.Drawing.FontStyle.Bold);
            this.btnReturn.ForeColor = System.Drawing.Color.Purple;
            this.btnReturn.Location = new System.Drawing.Point(16, 3);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(90, 35);
            this.btnReturn.TabIndex = 13;
            this.btnReturn.Text = "عودة";
            this.btnReturn.UseVisualStyleBackColor = false;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // grdDepositors
            // 
            this.grdDepositors.AccessibleDescription = "أسماء المودعين";
            this.grdDepositors.AllowUserToAddRows = false;
            this.grdDepositors.AllowUserToDeleteRows = false;
            this.grdDepositors.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grdDepositors.BackgroundColor = System.Drawing.Color.Lavender;
            this.grdDepositors.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdDepositors.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.gDepositorId,
            this.gDepositorId_User,
            this.gDepositorIdName});
            this.grdDepositors.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.grdDepositors.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.grdDepositors.Location = new System.Drawing.Point(589, 49);
            this.grdDepositors.MultiSelect = false;
            this.grdDepositors.Name = "grdDepositors";
            this.grdDepositors.ReadOnly = true;
            this.grdDepositors.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.grdDepositors.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdDepositors.Size = new System.Drawing.Size(377, 279);
            this.grdDepositors.StandardTab = true;
            this.grdDepositors.TabIndex = 14;
            this.grdDepositors.TabStop = false;
            this.grdDepositors.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdDepositors_CellClick);
            // 
            // gDepositorId
            // 
            this.gDepositorId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.gDepositorId.DataPropertyName = "DepositorId";
            this.gDepositorId.FillWeight = 2F;
            this.gDepositorId.HeaderText = "ر";
            this.gDepositorId.MinimumWidth = 2;
            this.gDepositorId.Name = "gDepositorId";
            this.gDepositorId.ReadOnly = true;
            this.gDepositorId.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.gDepositorId.Width = 5;
            // 
            // gDepositorId_User
            // 
            this.gDepositorId_User.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.gDepositorId_User.DataPropertyName = "DepositorId_User";
            this.gDepositorId_User.FillWeight = 50F;
            this.gDepositorId_User.HeaderText = "الرقم";
            this.gDepositorId_User.Name = "gDepositorId_User";
            this.gDepositorId_User.ReadOnly = true;
            this.gDepositorId_User.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.gDepositorId_User.Width = 50;
            // 
            // gDepositorIdName
            // 
            this.gDepositorIdName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.gDepositorIdName.DataPropertyName = "DepositorName";
            this.gDepositorIdName.FillWeight = 118.3333F;
            this.gDepositorIdName.HeaderText = "اســم المودع";
            this.gDepositorIdName.Name = "gDepositorIdName";
            this.gDepositorIdName.ReadOnly = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AllowDrop = true;
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel1.ColumnCount = 5;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.98814F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 49.01186F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 153F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 156F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 168F));
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 375);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(978, 0);
            this.tableLayoutPanel1.TabIndex = 138;
            // 
            // txtDepositorId
            // 
            this.txtDepositorId.BackColor = System.Drawing.Color.LightPink;
            this.txtDepositorId.Enabled = false;
            this.txtDepositorId.Font = new System.Drawing.Font("Tahoma", 12F);
            this.txtDepositorId.Location = new System.Drawing.Point(470, 285);
            this.txtDepositorId.Name = "txtDepositorId";
            this.txtDepositorId.ReadOnly = true;
            this.txtDepositorId.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtDepositorId.Size = new System.Drawing.Size(113, 27);
            this.txtDepositorId.TabIndex = 1;
            this.txtDepositorId.Tag = "int";
            this.txtDepositorId.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtDepositorId.Visible = false;
            // 
            // PnlLblSchoolName
            // 
            this.PnlLblSchoolName.BackColor = System.Drawing.Color.Lavender;
            this.PnlLblSchoolName.Controls.Add(this.lblTitle);
            this.PnlLblSchoolName.Location = new System.Drawing.Point(12, 51);
            this.PnlLblSchoolName.Name = "PnlLblSchoolName";
            this.PnlLblSchoolName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.PnlLblSchoolName.Size = new System.Drawing.Size(571, 40);
            this.PnlLblSchoolName.TabIndex = 237;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.Font = new System.Drawing.Font("Arial", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.lblTitle.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblTitle.Location = new System.Drawing.Point(144, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(253, 22);
            this.lblTitle.TabIndex = 223;
            this.lblTitle.Text = "تسجيل معلومات المودعين في الصندوق";
            // 
            // txtDepositorName
            // 
            this.txtDepositorName.BackColor = System.Drawing.Color.GhostWhite;
            this.txtDepositorName.Font = new System.Drawing.Font("Tahoma", 12F);
            this.txtDepositorName.ForeColor = System.Drawing.Color.Navy;
            this.txtDepositorName.Location = new System.Drawing.Point(256, 97);
            this.txtDepositorName.Name = "txtDepositorName";
            this.txtDepositorName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtDepositorName.Size = new System.Drawing.Size(327, 27);
            this.txtDepositorName.TabIndex = 229;
            this.txtDepositorName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblDepositorName
            // 
            this.lblDepositorName.AutoSize = true;
            this.lblDepositorName.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.lblDepositorName.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblDepositorName.Location = new System.Drawing.Point(207, 101);
            this.lblDepositorName.Name = "lblDepositorName";
            this.lblDepositorName.Size = new System.Drawing.Size(43, 19);
            this.lblDepositorName.TabIndex = 236;
            this.lblDepositorName.Text = "الاســم";
            // 
            // txtNotes
            // 
            this.txtNotes.AcceptsReturn = true;
            this.txtNotes.BackColor = System.Drawing.Color.GhostWhite;
            this.txtNotes.Font = new System.Drawing.Font("Tahoma", 12F);
            this.txtNotes.ForeColor = System.Drawing.Color.Navy;
            this.txtNotes.Location = new System.Drawing.Point(80, 203);
            this.txtNotes.Multiline = true;
            this.txtNotes.Name = "txtNotes";
            this.txtNotes.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtNotes.Size = new System.Drawing.Size(503, 76);
            this.txtNotes.TabIndex = 230;
            this.txtNotes.Tag = "string";
            // 
            // lblNotes
            // 
            this.lblNotes.AutoSize = true;
            this.lblNotes.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.lblNotes.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblNotes.Location = new System.Drawing.Point(14, 203);
            this.lblNotes.Name = "lblNotes";
            this.lblNotes.Size = new System.Drawing.Size(63, 19);
            this.lblNotes.TabIndex = 235;
            this.lblNotes.Text = "الملاحظات";
            // 
            // txtOtherPhone
            // 
            this.txtOtherPhone.BackColor = System.Drawing.Color.GhostWhite;
            this.txtOtherPhone.Font = new System.Drawing.Font("Tahoma", 12F);
            this.txtOtherPhone.ForeColor = System.Drawing.Color.Navy;
            this.txtOtherPhone.Location = new System.Drawing.Point(397, 130);
            this.txtOtherPhone.Name = "txtOtherPhone";
            this.txtOtherPhone.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtOtherPhone.Size = new System.Drawing.Size(186, 27);
            this.txtOtherPhone.TabIndex = 227;
            this.txtOtherPhone.Tag = "Optional";
            // 
            // lblOtherPhone
            // 
            this.lblOtherPhone.AutoSize = true;
            this.lblOtherPhone.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.lblOtherPhone.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblOtherPhone.Location = new System.Drawing.Point(309, 134);
            this.lblOtherPhone.Name = "lblOtherPhone";
            this.lblOtherPhone.Size = new System.Drawing.Size(82, 19);
            this.lblOtherPhone.TabIndex = 234;
            this.lblOtherPhone.Text = "رقم هاتف آخر";
            // 
            // txtAddress
            // 
            this.txtAddress.BackColor = System.Drawing.Color.GhostWhite;
            this.txtAddress.Font = new System.Drawing.Font("Tahoma", 12F);
            this.txtAddress.ForeColor = System.Drawing.Color.Navy;
            this.txtAddress.Location = new System.Drawing.Point(80, 170);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtAddress.Size = new System.Drawing.Size(503, 27);
            this.txtAddress.TabIndex = 228;
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.lblAddress.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblAddress.Location = new System.Drawing.Point(30, 170);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(47, 19);
            this.lblAddress.TabIndex = 233;
            this.lblAddress.Text = "العنوان";
            // 
            // txtPhone
            // 
            this.txtPhone.BackColor = System.Drawing.Color.GhostWhite;
            this.txtPhone.Font = new System.Drawing.Font("Tahoma", 12F);
            this.txtPhone.ForeColor = System.Drawing.Color.Navy;
            this.txtPhone.Location = new System.Drawing.Point(80, 133);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtPhone.Size = new System.Drawing.Size(213, 27);
            this.txtPhone.TabIndex = 226;
            this.txtPhone.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblphone
            // 
            this.lblphone.AutoSize = true;
            this.lblphone.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.lblphone.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblphone.Location = new System.Drawing.Point(11, 134);
            this.lblphone.Name = "lblphone";
            this.lblphone.Size = new System.Drawing.Size(66, 19);
            this.lblphone.TabIndex = 232;
            this.lblphone.Text = "رقم الهاتف";
            // 
            // txtDepositorID_User
            // 
            this.txtDepositorID_User.BackColor = System.Drawing.Color.GhostWhite;
            this.txtDepositorID_User.Enabled = false;
            this.txtDepositorID_User.Font = new System.Drawing.Font("Tahoma", 12F);
            this.txtDepositorID_User.ForeColor = System.Drawing.Color.Navy;
            this.txtDepositorID_User.Location = new System.Drawing.Point(81, 97);
            this.txtDepositorID_User.Name = "txtDepositorID_User";
            this.txtDepositorID_User.ReadOnly = true;
            this.txtDepositorID_User.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtDepositorID_User.Size = new System.Drawing.Size(65, 27);
            this.txtDepositorID_User.TabIndex = 225;
            this.txtDepositorID_User.Tag = "int";
            this.txtDepositorID_User.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblDepositorId_User
            // 
            this.lblDepositorId_User.AutoSize = true;
            this.lblDepositorId_User.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.lblDepositorId_User.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblDepositorId_User.Location = new System.Drawing.Point(8, 62);
            this.lblDepositorId_User.Name = "lblDepositorId_User";
            this.lblDepositorId_User.Size = new System.Drawing.Size(67, 19);
            this.lblDepositorId_User.TabIndex = 231;
            this.lblDepositorId_User.Text = "رقم المودع";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuStdReports,
            this.toolStripButton1});
            this.toolStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.toolStrip1.Size = new System.Drawing.Size(978, 25);
            this.toolStrip1.TabIndex = 282;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // mnuStdReports
            // 
            this.mnuStdReports.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.mnuStdReports.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MnuRptCashDepositors});
            this.mnuStdReports.Image = ((System.Drawing.Image)(resources.GetObject("mnuStdReports.Image")));
            this.mnuStdReports.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.mnuStdReports.Name = "mnuStdReports";
            this.mnuStdReports.Size = new System.Drawing.Size(55, 22);
            this.mnuStdReports.Text = "التقارير";
            // 
            // MnuRptCashDepositors
            // 
            this.MnuRptCashDepositors.Name = "MnuRptCashDepositors";
            this.MnuRptCashDepositors.Size = new System.Drawing.Size(253, 22);
            this.MnuRptCashDepositors.Text = "كشف مساهمات المودعين بالصندوق";
            this.MnuRptCashDepositors.Click += new System.EventHandler(this.MnuRptCashDepositors_Click);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton1.Text = "toolStripButton1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label1.Location = new System.Drawing.Point(42, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 19);
            this.label1.TabIndex = 283;
            this.label1.Text = "الرقم";
            // 
            // frmDepositors
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(978, 375);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.PnlLblSchoolName);
            this.Controls.Add(this.txtDepositorName);
            this.Controls.Add(this.lblDepositorName);
            this.Controls.Add(this.txtNotes);
            this.Controls.Add(this.lblNotes);
            this.Controls.Add(this.txtOtherPhone);
            this.Controls.Add(this.lblOtherPhone);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.lblAddress);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.lblphone);
            this.Controls.Add(this.txtDepositorID_User);
            this.Controls.Add(this.lblDepositorId_User);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.grdDepositors);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.txtDepositorId);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmDepositors";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.Tag = "المودعون في الصندوق";
            this.Text = "المودعون في الصندوق";
            this.Load += new System.EventHandler(this.frmDepositors_Load);
            this.flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdDepositors)).EndInit();
            this.PnlLblSchoolName.ResumeLayout(false);
            this.PnlLblSchoolName.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Button btnsave;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.DataGridView grdDepositors;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox txtDepositorId;
        private System.Windows.Forms.Panel PnlLblSchoolName;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TextBox txtDepositorName;
        private System.Windows.Forms.Label lblDepositorName;
        private System.Windows.Forms.TextBox txtNotes;
        private System.Windows.Forms.Label lblNotes;
        private System.Windows.Forms.TextBox txtOtherPhone;
        private System.Windows.Forms.Label lblOtherPhone;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Label lblphone;
        private System.Windows.Forms.TextBox txtDepositorID_User;
        private System.Windows.Forms.Label lblDepositorId_User;
        private System.Windows.Forms.DataGridViewTextBoxColumn gDepositorId;
        private System.Windows.Forms.DataGridViewTextBoxColumn gDepositorId_User;
        private System.Windows.Forms.DataGridViewTextBoxColumn gDepositorIdName;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripDropDownButton mnuStdReports;
        private System.Windows.Forms.ToolStripMenuItem MnuRptCashDepositors;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.Label label1;
    }
}