namespace PrjMoneyLoans
{
    partial class frmLoans
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLoans));
            this.btnNew = new System.Windows.Forms.Button();
            this.btnsave = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnPrint = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnReturn = new System.Windows.Forms.Button();
            this.grdLoans = new System.Windows.Forms.DataGridView();
            this.gEntryId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gEntryId_User = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gEntryDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gLoanAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.txtEntryId = new System.Windows.Forms.TextBox();
            this.PnlLblSchoolName = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblPersonName = new System.Windows.Forms.Label();
            this.txtNotes = new System.Windows.Forms.TextBox();
            this.lblNotes = new System.Windows.Forms.Label();
            this.txtLoanAmount = new System.Windows.Forms.TextBox();
            this.lblLoanAmount = new System.Windows.Forms.Label();
            this.txtEntryId_User = new System.Windows.Forms.TextBox();
            this.lblEntryId_User = new System.Windows.Forms.Label();
            this.cmbAccountId = new System.Windows.Forms.ComboBox();
            this.txtEntryDate = new System.Windows.Forms.DateTimePicker();
            this.lblBithDate = new System.Windows.Forms.Label();
            this.txtTotalAmount = new System.Windows.Forms.TextBox();
            this.lblTotalAmount = new System.Windows.Forms.Label();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblRepayWay = new System.Windows.Forms.Label();
            this.cmbRepayWay = new System.Windows.Forms.ComboBox();
            this.lblPeriod = new System.Windows.Forms.Label();
            this.txtPeriod = new System.Windows.Forms.TextBox();
            this.lblInstalmentCalculate = new System.Windows.Forms.Label();
            this.txtInstalmentAmount = new System.Windows.Forms.TextBox();
            this.cmbInstalmentCalcId = new System.Windows.Forms.ComboBox();
            this.lblEntryDate = new System.Windows.Forms.Label();
            this.pnlRepway = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdLoans)).BeginInit();
            this.PnlLblSchoolName.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.pnlRepway.SuspendLayout();
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
            this.flowLayoutPanel1.Location = new System.Drawing.Point(9, 249);
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
            // grdLoans
            // 
            this.grdLoans.AccessibleDescription = "أسماء المقترضين";
            this.grdLoans.AllowUserToAddRows = false;
            this.grdLoans.AllowUserToDeleteRows = false;
            this.grdLoans.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grdLoans.BackgroundColor = System.Drawing.Color.Lavender;
            this.grdLoans.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdLoans.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.gEntryId,
            this.gEntryId_User,
            this.gEntryDate,
            this.gLoanAmount});
            this.grdLoans.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.grdLoans.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.grdLoans.Location = new System.Drawing.Point(604, 5);
            this.grdLoans.MultiSelect = false;
            this.grdLoans.Name = "grdLoans";
            this.grdLoans.ReadOnly = true;
            this.grdLoans.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.grdLoans.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdLoans.Size = new System.Drawing.Size(362, 203);
            this.grdLoans.StandardTab = true;
            this.grdLoans.TabIndex = 14;
            this.grdLoans.TabStop = false;
            this.grdLoans.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdAccounts_CellClick);
            // 
            // gEntryId
            // 
            this.gEntryId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.gEntryId.DataPropertyName = "EntryId";
            this.gEntryId.FillWeight = 2F;
            this.gEntryId.HeaderText = "ر";
            this.gEntryId.MinimumWidth = 2;
            this.gEntryId.Name = "gEntryId";
            this.gEntryId.ReadOnly = true;
            this.gEntryId.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.gEntryId.Width = 5;
            // 
            // gEntryId_User
            // 
            this.gEntryId_User.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.gEntryId_User.DataPropertyName = "EntryId_User";
            this.gEntryId_User.FillWeight = 50F;
            this.gEntryId_User.HeaderText = "الرقم";
            this.gEntryId_User.Name = "gEntryId_User";
            this.gEntryId_User.ReadOnly = true;
            this.gEntryId_User.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.gEntryId_User.Width = 50;
            // 
            // gEntryDate
            // 
            this.gEntryDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.gEntryDate.DataPropertyName = "EntryDate_V";
            this.gEntryDate.FillWeight = 118.3333F;
            this.gEntryDate.HeaderText = "تاريخ القرض";
            this.gEntryDate.Name = "gEntryDate";
            this.gEntryDate.ReadOnly = true;
            // 
            // gLoanAmount
            // 
            this.gLoanAmount.DataPropertyName = "LoanAmount";
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gLoanAmount.DefaultCellStyle = dataGridViewCellStyle1;
            this.gLoanAmount.HeaderText = "المبلغ المقترض";
            this.gLoanAmount.Name = "gLoanAmount";
            this.gLoanAmount.ReadOnly = true;
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
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 192F));
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 294);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(978, 0);
            this.tableLayoutPanel1.TabIndex = 138;
            // 
            // txtEntryId
            // 
            this.txtEntryId.BackColor = System.Drawing.Color.LightPink;
            this.txtEntryId.Enabled = false;
            this.txtEntryId.Font = new System.Drawing.Font("Tahoma", 12F);
            this.txtEntryId.Location = new System.Drawing.Point(836, 254);
            this.txtEntryId.Name = "txtEntryId";
            this.txtEntryId.ReadOnly = true;
            this.txtEntryId.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtEntryId.Size = new System.Drawing.Size(113, 27);
            this.txtEntryId.TabIndex = 1;
            this.txtEntryId.Tag = "int";
            this.txtEntryId.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtEntryId.Visible = false;
            // 
            // PnlLblSchoolName
            // 
            this.PnlLblSchoolName.BackColor = System.Drawing.Color.Lavender;
            this.PnlLblSchoolName.Controls.Add(this.lblTitle);
            this.PnlLblSchoolName.Location = new System.Drawing.Point(4, 7);
            this.PnlLblSchoolName.Name = "PnlLblSchoolName";
            this.PnlLblSchoolName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.PnlLblSchoolName.Size = new System.Drawing.Size(594, 42);
            this.PnlLblSchoolName.TabIndex = 237;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.Font = new System.Drawing.Font("Arial", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.lblTitle.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblTitle.Location = new System.Drawing.Point(261, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(77, 22);
            this.lblTitle.TabIndex = 223;
            this.lblTitle.Text = "الــقــروض";
            // 
            // lblPersonName
            // 
            this.lblPersonName.AutoSize = true;
            this.lblPersonName.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.lblPersonName.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblPersonName.Location = new System.Drawing.Point(334, 9);
            this.lblPersonName.Name = "lblPersonName";
            this.lblPersonName.Size = new System.Drawing.Size(43, 19);
            this.lblPersonName.TabIndex = 236;
            this.lblPersonName.Text = "الاســم";
            // 
            // txtNotes
            // 
            this.txtNotes.AcceptsReturn = true;
            this.txtNotes.BackColor = System.Drawing.Color.GhostWhite;
            this.txtNotes.Font = new System.Drawing.Font("Tahoma", 12F);
            this.txtNotes.ForeColor = System.Drawing.Color.Navy;
            this.txtNotes.Location = new System.Drawing.Point(85, 202);
            this.txtNotes.Multiline = true;
            this.txtNotes.Name = "txtNotes";
            this.txtNotes.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtNotes.Size = new System.Drawing.Size(518, 29);
            this.txtNotes.TabIndex = 230;
            this.txtNotes.Tag = "string";
            // 
            // lblNotes
            // 
            this.lblNotes.AutoSize = true;
            this.lblNotes.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.lblNotes.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblNotes.Location = new System.Drawing.Point(12, 206);
            this.lblNotes.Name = "lblNotes";
            this.lblNotes.Size = new System.Drawing.Size(63, 19);
            this.lblNotes.TabIndex = 235;
            this.lblNotes.Text = "الملاحظات";
            // 
            // txtLoanAmount
            // 
            this.txtLoanAmount.BackColor = System.Drawing.Color.GhostWhite;
            this.txtLoanAmount.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.txtLoanAmount.ForeColor = System.Drawing.Color.DarkGreen;
            this.txtLoanAmount.Location = new System.Drawing.Point(87, 123);
            this.txtLoanAmount.Name = "txtLoanAmount";
            this.txtLoanAmount.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtLoanAmount.Size = new System.Drawing.Size(127, 26);
            this.txtLoanAmount.TabIndex = 226;
            this.txtLoanAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblLoanAmount
            // 
            this.lblLoanAmount.AutoSize = true;
            this.lblLoanAmount.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.lblLoanAmount.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblLoanAmount.Location = new System.Drawing.Point(35, 130);
            this.lblLoanAmount.Name = "lblLoanAmount";
            this.lblLoanAmount.Size = new System.Drawing.Size(40, 19);
            this.lblLoanAmount.TabIndex = 232;
            this.lblLoanAmount.Text = "المبلغ";
            // 
            // txtEntryId_User
            // 
            this.txtEntryId_User.BackColor = System.Drawing.Color.GhostWhite;
            this.txtEntryId_User.Enabled = false;
            this.txtEntryId_User.Font = new System.Drawing.Font("Tahoma", 12F);
            this.txtEntryId_User.ForeColor = System.Drawing.Color.Navy;
            this.txtEntryId_User.Location = new System.Drawing.Point(87, 87);
            this.txtEntryId_User.Name = "txtEntryId_User";
            this.txtEntryId_User.ReadOnly = true;
            this.txtEntryId_User.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtEntryId_User.Size = new System.Drawing.Size(88, 27);
            this.txtEntryId_User.TabIndex = 225;
            this.txtEntryId_User.Tag = "int";
            this.txtEntryId_User.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblEntryId_User
            // 
            this.lblEntryId_User.AutoSize = true;
            this.lblEntryId_User.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.lblEntryId_User.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblEntryId_User.Location = new System.Drawing.Point(40, 92);
            this.lblEntryId_User.Name = "lblEntryId_User";
            this.lblEntryId_User.Size = new System.Drawing.Size(35, 19);
            this.lblEntryId_User.TabIndex = 231;
            this.lblEntryId_User.Text = "الرقم";
            // 
            // cmbAccountId
            // 
            this.cmbAccountId.BackColor = System.Drawing.Color.GhostWhite;
            this.cmbAccountId.DisplayMember = "PersonName";
            this.cmbAccountId.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.cmbAccountId.FormattingEnabled = true;
            this.cmbAccountId.Location = new System.Drawing.Point(3, 6);
            this.cmbAccountId.Name = "cmbAccountId";
            this.cmbAccountId.Size = new System.Drawing.Size(325, 26);
            this.cmbAccountId.TabIndex = 238;
            this.cmbAccountId.ValueMember = "AccountId";
            this.cmbAccountId.SelectedIndexChanged += new System.EventHandler(this.cmbAccountId_SelectedIndexChanged);
            // 
            // txtEntryDate
            // 
            this.txtEntryDate.CalendarForeColor = System.Drawing.Color.Navy;
            this.txtEntryDate.CustomFormat = "yyyy/MM/dd";
            this.txtEntryDate.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.txtEntryDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.txtEntryDate.Location = new System.Drawing.Point(88, 54);
            this.txtEntryDate.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.txtEntryDate.Name = "txtEntryDate";
            this.txtEntryDate.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtEntryDate.RightToLeftLayout = true;
            this.txtEntryDate.Size = new System.Drawing.Size(131, 26);
            this.txtEntryDate.TabIndex = 268;
            this.txtEntryDate.ValueChanged += new System.EventHandler(this.txtEntryDate_ValueChanged);
            // 
            // lblBithDate
            // 
            this.lblBithDate.AutoSize = true;
            this.lblBithDate.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.lblBithDate.ForeColor = System.Drawing.Color.Navy;
            this.lblBithDate.Location = new System.Drawing.Point(-193, 8);
            this.lblBithDate.Name = "lblBithDate";
            this.lblBithDate.Size = new System.Drawing.Size(45, 19);
            this.lblBithDate.TabIndex = 267;
            this.lblBithDate.Text = "التاريخ";
            // 
            // txtTotalAmount
            // 
            this.txtTotalAmount.BackColor = System.Drawing.Color.MintCream;
            this.txtTotalAmount.Enabled = false;
            this.txtTotalAmount.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Underline);
            this.txtTotalAmount.ForeColor = System.Drawing.Color.Navy;
            this.txtTotalAmount.Location = new System.Drawing.Point(14, 3);
            this.txtTotalAmount.Name = "txtTotalAmount";
            this.txtTotalAmount.ReadOnly = true;
            this.txtTotalAmount.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtTotalAmount.Size = new System.Drawing.Size(94, 27);
            this.txtTotalAmount.TabIndex = 269;
            this.txtTotalAmount.Tag = "int";
            this.txtTotalAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblTotalAmount
            // 
            this.lblTotalAmount.AutoSize = true;
            this.lblTotalAmount.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.lblTotalAmount.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblTotalAmount.Location = new System.Drawing.Point(114, 5);
            this.lblTotalAmount.Margin = new System.Windows.Forms.Padding(3, 5, 3, 0);
            this.lblTotalAmount.Name = "lblTotalAmount";
            this.lblTotalAmount.Size = new System.Drawing.Size(140, 19);
            this.lblTotalAmount.TabIndex = 270;
            this.lblTotalAmount.Text = "مجموع المبالغ المقترضة";
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.lblTotalAmount);
            this.flowLayoutPanel2.Controls.Add(this.txtTotalAmount);
            this.flowLayoutPanel2.Location = new System.Drawing.Point(706, 214);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(257, 34);
            this.flowLayoutPanel2.TabIndex = 271;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblBithDate);
            this.panel1.Controls.Add(this.lblPersonName);
            this.panel1.Controls.Add(this.cmbAccountId);
            this.panel1.Location = new System.Drawing.Point(220, 78);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(378, 39);
            this.panel1.TabIndex = 272;
            // 
            // lblRepayWay
            // 
            this.lblRepayWay.AutoSize = true;
            this.lblRepayWay.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.lblRepayWay.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblRepayWay.Location = new System.Drawing.Point(391, 130);
            this.lblRepayWay.Name = "lblRepayWay";
            this.lblRepayWay.Size = new System.Drawing.Size(76, 19);
            this.lblRepayWay.TabIndex = 274;
            this.lblRepayWay.Text = "طريقة السداد";
            // 
            // cmbRepayWay
            // 
            this.cmbRepayWay.BackColor = System.Drawing.Color.GhostWhite;
            this.cmbRepayWay.DisplayMember = "DisplayMember";
            this.cmbRepayWay.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.cmbRepayWay.FormattingEnabled = true;
            this.cmbRepayWay.Location = new System.Drawing.Point(471, 123);
            this.cmbRepayWay.Name = "cmbRepayWay";
            this.cmbRepayWay.Size = new System.Drawing.Size(127, 26);
            this.cmbRepayWay.TabIndex = 275;
            this.cmbRepayWay.Tag = "user";
            this.cmbRepayWay.ValueMember = "ValueMember";
            this.cmbRepayWay.SelectedIndexChanged += new System.EventHandler(this.cmbRepayWay_SelectedIndexChanged);
            // 
            // lblPeriod
            // 
            this.lblPeriod.AutoSize = true;
            this.lblPeriod.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.lblPeriod.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblPeriod.Location = new System.Drawing.Point(246, 5);
            this.lblPeriod.Margin = new System.Windows.Forms.Padding(3, 5, 3, 0);
            this.lblPeriod.Name = "lblPeriod";
            this.lblPeriod.Size = new System.Drawing.Size(68, 19);
            this.lblPeriod.TabIndex = 280;
            this.lblPeriod.Text = "عدد الأشهر";
            this.lblPeriod.Visible = false;
            // 
            // txtPeriod
            // 
            this.txtPeriod.BackColor = System.Drawing.Color.GhostWhite;
            this.txtPeriod.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.txtPeriod.ForeColor = System.Drawing.Color.DarkGreen;
            this.txtPeriod.Location = new System.Drawing.Point(178, 3);
            this.txtPeriod.Name = "txtPeriod";
            this.txtPeriod.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtPeriod.Size = new System.Drawing.Size(62, 26);
            this.txtPeriod.TabIndex = 279;
            this.txtPeriod.Tag = "";
            this.txtPeriod.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtPeriod.Visible = false;
            this.txtPeriod.TextChanged += new System.EventHandler(this.txtPeriod_TextChanged);
            // 
            // lblInstalmentCalculate
            // 
            this.lblInstalmentCalculate.AutoSize = true;
            this.lblInstalmentCalculate.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.lblInstalmentCalculate.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblInstalmentCalculate.Location = new System.Drawing.Point(86, 5);
            this.lblInstalmentCalculate.Margin = new System.Windows.Forms.Padding(3, 5, 3, 0);
            this.lblInstalmentCalculate.Name = "lblInstalmentCalculate";
            this.lblInstalmentCalculate.Size = new System.Drawing.Size(86, 19);
            this.lblInstalmentCalculate.TabIndex = 278;
            this.lblInstalmentCalculate.Text = "القسط الشهري";
            // 
            // txtInstalmentAmount
            // 
            this.txtInstalmentAmount.BackColor = System.Drawing.Color.GhostWhite;
            this.txtInstalmentAmount.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.txtInstalmentAmount.ForeColor = System.Drawing.Color.DarkGreen;
            this.txtInstalmentAmount.Location = new System.Drawing.Point(3, 3);
            this.txtInstalmentAmount.Name = "txtInstalmentAmount";
            this.txtInstalmentAmount.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtInstalmentAmount.Size = new System.Drawing.Size(77, 26);
            this.txtInstalmentAmount.TabIndex = 277;
            this.txtInstalmentAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // cmbInstalmentCalcId
            // 
            this.cmbInstalmentCalcId.AccessibleDescription = "";
            this.cmbInstalmentCalcId.BackColor = System.Drawing.Color.GhostWhite;
            this.cmbInstalmentCalcId.DisplayMember = "DisplayMember";
            this.cmbInstalmentCalcId.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.cmbInstalmentCalcId.FormattingEnabled = true;
            this.cmbInstalmentCalcId.Location = new System.Drawing.Point(320, 3);
            this.cmbInstalmentCalcId.Name = "cmbInstalmentCalcId";
            this.cmbInstalmentCalcId.Size = new System.Drawing.Size(190, 26);
            this.cmbInstalmentCalcId.TabIndex = 276;
            this.cmbInstalmentCalcId.ValueMember = "ValueMember";
            this.cmbInstalmentCalcId.SelectedIndexChanged += new System.EventHandler(this.cmbInstalmentCalcId_SelectedIndexChanged);
            // 
            // lblEntryDate
            // 
            this.lblEntryDate.AutoSize = true;
            this.lblEntryDate.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.lblEntryDate.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblEntryDate.Location = new System.Drawing.Point(30, 58);
            this.lblEntryDate.Name = "lblEntryDate";
            this.lblEntryDate.Size = new System.Drawing.Size(45, 19);
            this.lblEntryDate.TabIndex = 278;
            this.lblEntryDate.Text = "التاريخ";
            // 
            // pnlRepway
            // 
            this.pnlRepway.Controls.Add(this.cmbInstalmentCalcId);
            this.pnlRepway.Controls.Add(this.lblPeriod);
            this.pnlRepway.Controls.Add(this.txtPeriod);
            this.pnlRepway.Controls.Add(this.lblInstalmentCalculate);
            this.pnlRepway.Controls.Add(this.txtInstalmentAmount);
            this.pnlRepway.Location = new System.Drawing.Point(85, 155);
            this.pnlRepway.Name = "pnlRepway";
            this.pnlRepway.Size = new System.Drawing.Size(513, 35);
            this.pnlRepway.TabIndex = 281;
            // 
            // frmLoans
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(978, 294);
            this.Controls.Add(this.pnlRepway);
            this.Controls.Add(this.PnlLblSchoolName);
            this.Controls.Add(this.lblEntryDate);
            this.Controls.Add(this.cmbRepayWay);
            this.Controls.Add(this.lblRepayWay);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.flowLayoutPanel2);
            this.Controls.Add(this.txtEntryDate);
            this.Controls.Add(this.txtNotes);
            this.Controls.Add(this.lblNotes);
            this.Controls.Add(this.txtLoanAmount);
            this.Controls.Add(this.lblLoanAmount);
            this.Controls.Add(this.txtEntryId_User);
            this.Controls.Add(this.lblEntryId_User);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.grdLoans);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.txtEntryId);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmLoans";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.Tag = "القروض";
            this.Text = "القروض";
            this.Load += new System.EventHandler(this.frmLoans_Load);
            this.flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdLoans)).EndInit();
            this.PnlLblSchoolName.ResumeLayout(false);
            this.PnlLblSchoolName.PerformLayout();
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnlRepway.ResumeLayout(false);
            this.pnlRepway.PerformLayout();
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
        private System.Windows.Forms.DataGridView grdLoans;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox txtEntryId;
        private System.Windows.Forms.Panel PnlLblSchoolName;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblPersonName;
        private System.Windows.Forms.TextBox txtNotes;
        private System.Windows.Forms.Label lblNotes;
        private System.Windows.Forms.TextBox txtLoanAmount;
        private System.Windows.Forms.Label lblLoanAmount;
        private System.Windows.Forms.TextBox txtEntryId_User;
        private System.Windows.Forms.Label lblEntryId_User;
        private System.Windows.Forms.ComboBox cmbAccountId;
        private System.Windows.Forms.DateTimePicker txtEntryDate;
        private System.Windows.Forms.Label lblBithDate;
        private System.Windows.Forms.TextBox txtTotalAmount;
        private System.Windows.Forms.Label lblTotalAmount;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn gEntryId;
        private System.Windows.Forms.DataGridViewTextBoxColumn gEntryId_User;
        private System.Windows.Forms.DataGridViewTextBoxColumn gEntryDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn gLoanAmount;
        private System.Windows.Forms.Label lblRepayWay;
        private System.Windows.Forms.ComboBox cmbRepayWay;
        private System.Windows.Forms.ComboBox cmbInstalmentCalcId;
        private System.Windows.Forms.Label lblInstalmentCalculate;
        private System.Windows.Forms.TextBox txtInstalmentAmount;
        private System.Windows.Forms.Label lblEntryDate;
        private System.Windows.Forms.Label lblPeriod;
        private System.Windows.Forms.TextBox txtPeriod;
        private System.Windows.Forms.FlowLayoutPanel pnlRepway;
    }
}