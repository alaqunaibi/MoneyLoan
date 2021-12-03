namespace PrjMoneyLoans
{
    partial class frmCash
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCash));
            this.btnNew = new System.Windows.Forms.Button();
            this.btnsave = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnPrint = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnReturn = new System.Windows.Forms.Button();
            this.grdCash = new System.Windows.Forms.DataGridView();
            this.gEntryId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gDateEntry = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gEntryId_User = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gCash = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ggDepositType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.txtEntryId = new System.Windows.Forms.TextBox();
            this.PnlLblSchoolName = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblDepositorName = new System.Windows.Forms.Label();
            this.txtNotes = new System.Windows.Forms.TextBox();
            this.lblNotes = new System.Windows.Forms.Label();
            this.txtCash = new System.Windows.Forms.TextBox();
            this.lblCash = new System.Windows.Forms.Label();
            this.txtEntryId_User = new System.Windows.Forms.TextBox();
            this.lblEntryId_User = new System.Windows.Forms.Label();
            this.cmbDepositorId = new System.Windows.Forms.ComboBox();
            this.txtEntryDate = new System.Windows.Forms.DateTimePicker();
            this.lblBithDate = new System.Windows.Forms.Label();
            this.txtTotalAmount = new System.Windows.Forms.TextBox();
            this.lblTotalAmount = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbDepositTypeId = new System.Windows.Forms.ComboBox();
            this.lblEntryDate = new System.Windows.Forms.Label();
            this.tabResults = new System.Windows.Forms.TabControl();
            this.tbCash = new System.Windows.Forms.TabPage();
            this.pnlAllCash = new System.Windows.Forms.FlowLayoutPanel();
            this.tblDepositType = new System.Windows.Forms.TabPage();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCashClassify = new System.Windows.Forms.TextBox();
            this.grdCashClassify = new System.Windows.Forms.DataGridView();
            this.gCashClassify = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gCashSum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.mnuStdReports = new System.Windows.Forms.ToolStripDropDownButton();
            this.mnuRptCashBalance = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuRptCashDepositors = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdCash)).BeginInit();
            this.PnlLblSchoolName.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tabResults.SuspendLayout();
            this.tbCash.SuspendLayout();
            this.pnlAllCash.SuspendLayout();
            this.tblDepositType.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdCashClassify)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnNew
            // 
            this.btnNew.BackColor = System.Drawing.Color.Lavender;
            this.btnNew.Font = new System.Drawing.Font("Arial", 13F, System.Drawing.FontStyle.Bold);
            this.btnNew.ForeColor = System.Drawing.Color.Purple;
            this.btnNew.Location = new System.Drawing.Point(455, 3);
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
            this.btnsave.Location = new System.Drawing.Point(345, 3);
            this.btnsave.Margin = new System.Windows.Forms.Padding(10, 3, 10, 3);
            this.btnsave.Name = "btnsave";
            this.btnsave.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.btnsave.Size = new System.Drawing.Size(90, 35);
            this.btnsave.TabIndex = 8;
            this.btnsave.Text = "حفظ";
            this.btnsave.UseVisualStyleBackColor = false;
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Lavender;
            this.btnDelete.Font = new System.Drawing.Font("Arial", 13F, System.Drawing.FontStyle.Bold);
            this.btnDelete.ForeColor = System.Drawing.Color.Purple;
            this.btnDelete.Location = new System.Drawing.Point(225, 3);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(10, 3, 10, 3);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.btnDelete.Size = new System.Drawing.Size(100, 35);
            this.btnDelete.TabIndex = 23;
            this.btnDelete.Text = "حــذف";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnPrint
            // 
            this.btnPrint.BackColor = System.Drawing.Color.Lavender;
            this.btnPrint.Font = new System.Drawing.Font("Arial", 13F, System.Drawing.FontStyle.Bold);
            this.btnPrint.ForeColor = System.Drawing.Color.Purple;
            this.btnPrint.Location = new System.Drawing.Point(115, 3);
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
            this.flowLayoutPanel1.Controls.Add(this.btnDelete);
            this.flowLayoutPanel1.Controls.Add(this.btnPrint);
            this.flowLayoutPanel1.Controls.Add(this.btnReturn);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(12, 303);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.flowLayoutPanel1.Size = new System.Drawing.Size(555, 42);
            this.flowLayoutPanel1.TabIndex = 148;
            // 
            // btnReturn
            // 
            this.btnReturn.BackColor = System.Drawing.Color.Lavender;
            this.btnReturn.Font = new System.Drawing.Font("Arial", 13F, System.Drawing.FontStyle.Bold);
            this.btnReturn.ForeColor = System.Drawing.Color.Purple;
            this.btnReturn.Location = new System.Drawing.Point(12, 3);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(90, 35);
            this.btnReturn.TabIndex = 13;
            this.btnReturn.Text = "عودة";
            this.btnReturn.UseVisualStyleBackColor = false;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // grdCash
            // 
            this.grdCash.AccessibleDescription = "صندوق النقد";
            this.grdCash.AllowUserToAddRows = false;
            this.grdCash.AllowUserToDeleteRows = false;
            this.grdCash.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grdCash.BackgroundColor = System.Drawing.Color.Lavender;
            this.grdCash.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdCash.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.gEntryId,
            this.gDateEntry,
            this.gEntryId_User,
            this.gCash,
            this.ggDepositType});
            this.grdCash.Dock = System.Windows.Forms.DockStyle.Top;
            this.grdCash.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.grdCash.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.grdCash.Location = new System.Drawing.Point(0, 0);
            this.grdCash.MultiSelect = false;
            this.grdCash.Name = "grdCash";
            this.grdCash.ReadOnly = true;
            this.grdCash.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.grdCash.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdCash.Size = new System.Drawing.Size(460, 190);
            this.grdCash.StandardTab = true;
            this.grdCash.TabIndex = 14;
            this.grdCash.TabStop = false;
            this.grdCash.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdCash_CellClick);
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
            // gDateEntry
            // 
            this.gDateEntry.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.gDateEntry.DataPropertyName = "EntryDate_V";
            this.gDateEntry.HeaderText = "التاريخ";
            this.gDateEntry.Name = "gDateEntry";
            this.gDateEntry.ReadOnly = true;
            this.gDateEntry.Width = 63;
            // 
            // gEntryId_User
            // 
            this.gEntryId_User.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.gEntryId_User.DataPropertyName = "EntryId_User";
            this.gEntryId_User.FillWeight = 50F;
            this.gEntryId_User.HeaderText = "الرقم";
            this.gEntryId_User.Name = "gEntryId_User";
            this.gEntryId_User.ReadOnly = true;
            this.gEntryId_User.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.gEntryId_User.Width = 54;
            // 
            // gCash
            // 
            this.gCash.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.gCash.DataPropertyName = "Cash";
            dataGridViewCellStyle17.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle17.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gCash.DefaultCellStyle = dataGridViewCellStyle17;
            this.gCash.HeaderText = "المبلغ";
            this.gCash.Name = "gCash";
            this.gCash.ReadOnly = true;
            this.gCash.Width = 57;
            // 
            // ggDepositType
            // 
            this.ggDepositType.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.ggDepositType.DataPropertyName = "DepositType";
            this.ggDepositType.HeaderText = "الـسند";
            this.ggDepositType.Name = "ggDepositType";
            this.ggDepositType.ReadOnly = true;
            this.ggDepositType.Width = 59;
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
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 196F));
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 351);
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
            this.txtEntryId.Location = new System.Drawing.Point(413, 188);
            this.txtEntryId.Name = "txtEntryId";
            this.txtEntryId.ReadOnly = true;
            this.txtEntryId.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtEntryId.Size = new System.Drawing.Size(84, 27);
            this.txtEntryId.TabIndex = 1;
            this.txtEntryId.Tag = "int";
            this.txtEntryId.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtEntryId.Visible = false;
            // 
            // PnlLblSchoolName
            // 
            this.PnlLblSchoolName.BackColor = System.Drawing.Color.Lavender;
            this.PnlLblSchoolName.Controls.Add(this.lblTitle);
            this.PnlLblSchoolName.Location = new System.Drawing.Point(12, 56);
            this.PnlLblSchoolName.Name = "PnlLblSchoolName";
            this.PnlLblSchoolName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.PnlLblSchoolName.Size = new System.Drawing.Size(485, 40);
            this.PnlLblSchoolName.TabIndex = 237;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.Font = new System.Drawing.Font("Arial", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.lblTitle.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblTitle.Location = new System.Drawing.Point(184, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(117, 22);
            this.lblTitle.TabIndex = 223;
            this.lblTitle.Text = "ايداعات الصندوق";
            // 
            // lblDepositorName
            // 
            this.lblDepositorName.AutoSize = true;
            this.lblDepositorName.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.lblDepositorName.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblDepositorName.Location = new System.Drawing.Point(260, 8);
            this.lblDepositorName.Name = "lblDepositorName";
            this.lblDepositorName.Size = new System.Drawing.Size(69, 19);
            this.lblDepositorName.TabIndex = 236;
            this.lblDepositorName.Text = "اسم المودع";
            this.lblDepositorName.Click += new System.EventHandler(this.lblDepositorName_Click);
            // 
            // txtNotes
            // 
            this.txtNotes.AcceptsReturn = true;
            this.txtNotes.BackColor = System.Drawing.Color.GhostWhite;
            this.txtNotes.Font = new System.Drawing.Font("Tahoma", 12F);
            this.txtNotes.ForeColor = System.Drawing.Color.Navy;
            this.txtNotes.Location = new System.Drawing.Point(81, 237);
            this.txtNotes.Multiline = true;
            this.txtNotes.Name = "txtNotes";
            this.txtNotes.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtNotes.Size = new System.Drawing.Size(422, 38);
            this.txtNotes.TabIndex = 230;
            this.txtNotes.Tag = "string";
            // 
            // lblNotes
            // 
            this.lblNotes.AutoSize = true;
            this.lblNotes.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.lblNotes.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblNotes.Location = new System.Drawing.Point(12, 241);
            this.lblNotes.Name = "lblNotes";
            this.lblNotes.Size = new System.Drawing.Size(63, 19);
            this.lblNotes.TabIndex = 235;
            this.lblNotes.Text = "الملاحظات";
            // 
            // txtCash
            // 
            this.txtCash.BackColor = System.Drawing.Color.GhostWhite;
            this.txtCash.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.txtCash.ForeColor = System.Drawing.Color.DarkGreen;
            this.txtCash.Location = new System.Drawing.Point(80, 176);
            this.txtCash.Name = "txtCash";
            this.txtCash.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtCash.Size = new System.Drawing.Size(104, 26);
            this.txtCash.TabIndex = 226;
            this.txtCash.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblCash
            // 
            this.lblCash.AutoSize = true;
            this.lblCash.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.lblCash.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblCash.Location = new System.Drawing.Point(35, 176);
            this.lblCash.Name = "lblCash";
            this.lblCash.Size = new System.Drawing.Size(40, 19);
            this.lblCash.TabIndex = 232;
            this.lblCash.Text = "المبلغ";
            // 
            // txtEntryId_User
            // 
            this.txtEntryId_User.BackColor = System.Drawing.Color.GhostWhite;
            this.txtEntryId_User.Enabled = false;
            this.txtEntryId_User.Font = new System.Drawing.Font("Tahoma", 12F);
            this.txtEntryId_User.ForeColor = System.Drawing.Color.Navy;
            this.txtEntryId_User.Location = new System.Drawing.Point(81, 136);
            this.txtEntryId_User.Name = "txtEntryId_User";
            this.txtEntryId_User.ReadOnly = true;
            this.txtEntryId_User.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtEntryId_User.Size = new System.Drawing.Size(78, 27);
            this.txtEntryId_User.TabIndex = 225;
            this.txtEntryId_User.Tag = "int";
            this.txtEntryId_User.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblEntryId_User
            // 
            this.lblEntryId_User.AutoSize = true;
            this.lblEntryId_User.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.lblEntryId_User.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblEntryId_User.Location = new System.Drawing.Point(40, 139);
            this.lblEntryId_User.Name = "lblEntryId_User";
            this.lblEntryId_User.Size = new System.Drawing.Size(35, 19);
            this.lblEntryId_User.TabIndex = 231;
            this.lblEntryId_User.Text = "الرقم";
            // 
            // cmbDepositorId
            // 
            this.cmbDepositorId.BackColor = System.Drawing.Color.GhostWhite;
            this.cmbDepositorId.DisplayMember = "DepositorName";
            this.cmbDepositorId.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.cmbDepositorId.FormattingEnabled = true;
            this.cmbDepositorId.Location = new System.Drawing.Point(6, 7);
            this.cmbDepositorId.Name = "cmbDepositorId";
            this.cmbDepositorId.Size = new System.Drawing.Size(250, 26);
            this.cmbDepositorId.TabIndex = 238;
            this.cmbDepositorId.ValueMember = "DepositorId";
            this.cmbDepositorId.SelectedIndexChanged += new System.EventHandler(this.cmbDepositorId_SelectedIndexChanged);
            // 
            // txtEntryDate
            // 
            this.txtEntryDate.CalendarForeColor = System.Drawing.Color.Navy;
            this.txtEntryDate.CustomFormat = "yyyy/MM/dd";
            this.txtEntryDate.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.txtEntryDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.txtEntryDate.Location = new System.Drawing.Point(80, 102);
            this.txtEntryDate.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.txtEntryDate.Name = "txtEntryDate";
            this.txtEntryDate.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtEntryDate.RightToLeftLayout = true;
            this.txtEntryDate.Size = new System.Drawing.Size(118, 26);
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
            this.txtTotalAmount.BackColor = System.Drawing.Color.Ivory;
            this.txtTotalAmount.Enabled = false;
            this.txtTotalAmount.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Underline);
            this.txtTotalAmount.ForeColor = System.Drawing.Color.Navy;
            this.txtTotalAmount.Location = new System.Drawing.Point(206, 3);
            this.txtTotalAmount.Name = "txtTotalAmount";
            this.txtTotalAmount.ReadOnly = true;
            this.txtTotalAmount.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtTotalAmount.Size = new System.Drawing.Size(94, 27);
            this.txtTotalAmount.TabIndex = 269;
            this.txtTotalAmount.Tag = "int";
            this.txtTotalAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblTotalAmount
            // 
            this.lblTotalAmount.AutoSize = true;
            this.lblTotalAmount.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.lblTotalAmount.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblTotalAmount.Location = new System.Drawing.Point(306, 0);
            this.lblTotalAmount.Name = "lblTotalAmount";
            this.lblTotalAmount.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.lblTotalAmount.Size = new System.Drawing.Size(151, 24);
            this.lblTotalAmount.TabIndex = 270;
            this.lblTotalAmount.Text = "مجموع المبالغ المودعة لـه";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblBithDate);
            this.panel1.Controls.Add(this.lblDepositorName);
            this.panel1.Controls.Add(this.cmbDepositorId);
            this.panel1.Location = new System.Drawing.Point(165, 132);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(338, 39);
            this.panel1.TabIndex = 272;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label2.Location = new System.Drawing.Point(36, 209);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 19);
            this.label2.TabIndex = 278;
            this.label2.Text = "الـسند";
            // 
            // cmbDepositTypeId
            // 
            this.cmbDepositTypeId.BackColor = System.Drawing.Color.GhostWhite;
            this.cmbDepositTypeId.DisplayMember = "DisplayMember";
            this.cmbDepositTypeId.Enabled = false;
            this.cmbDepositTypeId.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.cmbDepositTypeId.ForeColor = System.Drawing.Color.Navy;
            this.cmbDepositTypeId.FormattingEnabled = true;
            this.cmbDepositTypeId.Location = new System.Drawing.Point(80, 206);
            this.cmbDepositTypeId.Name = "cmbDepositTypeId";
            this.cmbDepositTypeId.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cmbDepositTypeId.Size = new System.Drawing.Size(153, 27);
            this.cmbDepositTypeId.TabIndex = 277;
            this.cmbDepositTypeId.ValueMember = "ValueMember";
            // 
            // lblEntryDate
            // 
            this.lblEntryDate.AutoSize = true;
            this.lblEntryDate.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.lblEntryDate.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblEntryDate.Location = new System.Drawing.Point(30, 108);
            this.lblEntryDate.Name = "lblEntryDate";
            this.lblEntryDate.Size = new System.Drawing.Size(45, 19);
            this.lblEntryDate.TabIndex = 279;
            this.lblEntryDate.Text = "التاريخ";
            // 
            // tabResults
            // 
            this.tabResults.Controls.Add(this.tbCash);
            this.tabResults.Controls.Add(this.tblDepositType);
            this.tabResults.Location = new System.Drawing.Point(509, 46);
            this.tabResults.Name = "tabResults";
            this.tabResults.RightToLeftLayout = true;
            this.tabResults.SelectedIndex = 0;
            this.tabResults.Size = new System.Drawing.Size(468, 250);
            this.tabResults.TabIndex = 280;
            // 
            // tbCash
            // 
            this.tbCash.Controls.Add(this.pnlAllCash);
            this.tbCash.Controls.Add(this.grdCash);
            this.tbCash.Location = new System.Drawing.Point(4, 22);
            this.tbCash.Name = "tbCash";
            this.tbCash.Size = new System.Drawing.Size(460, 224);
            this.tbCash.TabIndex = 2;
            this.tbCash.Text = "صندوق النقد";
            this.tbCash.UseVisualStyleBackColor = true;
            // 
            // pnlAllCash
            // 
            this.pnlAllCash.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnlAllCash.Controls.Add(this.lblTotalAmount);
            this.pnlAllCash.Controls.Add(this.txtTotalAmount);
            this.pnlAllCash.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlAllCash.Location = new System.Drawing.Point(0, 192);
            this.pnlAllCash.Name = "pnlAllCash";
            this.pnlAllCash.Size = new System.Drawing.Size(460, 32);
            this.pnlAllCash.TabIndex = 272;
            // 
            // tblDepositType
            // 
            this.tblDepositType.Controls.Add(this.flowLayoutPanel2);
            this.tblDepositType.Controls.Add(this.grdCashClassify);
            this.tblDepositType.Location = new System.Drawing.Point(4, 22);
            this.tblDepositType.Name = "tblDepositType";
            this.tblDepositType.Size = new System.Drawing.Size(460, 224);
            this.tblDepositType.TabIndex = 1;
            this.tblDepositType.Text = "توزيع النقد حسب نوع الايداع";
            this.tblDepositType.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.flowLayoutPanel2.Controls.Add(this.label1);
            this.flowLayoutPanel2.Controls.Add(this.txtCashClassify);
            this.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(0, 192);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(460, 32);
            this.flowLayoutPanel2.TabIndex = 273;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label1.Location = new System.Drawing.Point(306, 0);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.label1.Size = new System.Drawing.Size(151, 24);
            this.label1.TabIndex = 270;
            this.label1.Text = "مجموع المبالغ المودعة لـه";
            // 
            // txtCashClassify
            // 
            this.txtCashClassify.BackColor = System.Drawing.Color.Ivory;
            this.txtCashClassify.Enabled = false;
            this.txtCashClassify.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Underline);
            this.txtCashClassify.ForeColor = System.Drawing.Color.Navy;
            this.txtCashClassify.Location = new System.Drawing.Point(206, 3);
            this.txtCashClassify.Name = "txtCashClassify";
            this.txtCashClassify.ReadOnly = true;
            this.txtCashClassify.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtCashClassify.Size = new System.Drawing.Size(94, 27);
            this.txtCashClassify.TabIndex = 269;
            this.txtCashClassify.Tag = "int";
            this.txtCashClassify.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // grdCashClassify
            // 
            this.grdCashClassify.AccessibleDescription = "توزيع النقد";
            this.grdCashClassify.AllowUserToAddRows = false;
            this.grdCashClassify.AllowUserToDeleteRows = false;
            this.grdCashClassify.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grdCashClassify.BackgroundColor = System.Drawing.Color.Lavender;
            this.grdCashClassify.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdCashClassify.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.gCashClassify,
            this.gCashSum});
            this.grdCashClassify.Dock = System.Windows.Forms.DockStyle.Top;
            this.grdCashClassify.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.grdCashClassify.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.grdCashClassify.Location = new System.Drawing.Point(0, 0);
            this.grdCashClassify.MultiSelect = false;
            this.grdCashClassify.Name = "grdCashClassify";
            this.grdCashClassify.ReadOnly = true;
            this.grdCashClassify.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.grdCashClassify.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdCashClassify.Size = new System.Drawing.Size(460, 190);
            this.grdCashClassify.StandardTab = true;
            this.grdCashClassify.TabIndex = 272;
            this.grdCashClassify.TabStop = false;
            // 
            // gCashClassify
            // 
            this.gCashClassify.DataPropertyName = "DepositType";
            this.gCashClassify.HeaderText = "نوع الايداع";
            this.gCashClassify.Name = "gCashClassify";
            this.gCashClassify.ReadOnly = true;
            // 
            // gCashSum
            // 
            this.gCashSum.DataPropertyName = "Cash";
            dataGridViewCellStyle18.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle18.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gCashSum.DefaultCellStyle = dataGridViewCellStyle18;
            this.gCashSum.HeaderText = "مجموع  المبالغ المودع";
            this.gCashSum.Name = "gCashSum";
            this.gCashSum.ReadOnly = true;
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
            this.toolStrip1.TabIndex = 281;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // mnuStdReports
            // 
            this.mnuStdReports.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.mnuStdReports.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuRptCashBalance,
            this.MnuRptCashDepositors});
            this.mnuStdReports.Image = ((System.Drawing.Image)(resources.GetObject("mnuStdReports.Image")));
            this.mnuStdReports.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.mnuStdReports.Name = "mnuStdReports";
            this.mnuStdReports.Size = new System.Drawing.Size(55, 22);
            this.mnuStdReports.Text = "التقارير";
            // 
            // mnuRptCashBalance
            // 
            this.mnuRptCashBalance.Name = "mnuRptCashBalance";
            this.mnuRptCashBalance.Size = new System.Drawing.Size(253, 22);
            this.mnuRptCashBalance.Text = "كشف أرصدة الصندوق";
            this.mnuRptCashBalance.Click += new System.EventHandler(this.mnuRptCashBalance_Click);
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
            // frmCash
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(978, 351);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.tabResults);
            this.Controls.Add(this.lblEntryDate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbDepositTypeId);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtEntryDate);
            this.Controls.Add(this.PnlLblSchoolName);
            this.Controls.Add(this.txtNotes);
            this.Controls.Add(this.lblNotes);
            this.Controls.Add(this.txtCash);
            this.Controls.Add(this.lblCash);
            this.Controls.Add(this.txtEntryId_User);
            this.Controls.Add(this.lblEntryId_User);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.txtEntryId);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmCash";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.Tag = "الصندوق";
            this.Text = "الصندوق";
            this.Load += new System.EventHandler(this.frmCash_Load);
            this.flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdCash)).EndInit();
            this.PnlLblSchoolName.ResumeLayout(false);
            this.PnlLblSchoolName.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabResults.ResumeLayout(false);
            this.tbCash.ResumeLayout(false);
            this.pnlAllCash.ResumeLayout(false);
            this.pnlAllCash.PerformLayout();
            this.tblDepositType.ResumeLayout(false);
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdCashClassify)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Button btnsave;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.DataGridView grdCash;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox txtEntryId;
        private System.Windows.Forms.Panel PnlLblSchoolName;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblDepositorName;
        private System.Windows.Forms.TextBox txtNotes;
        private System.Windows.Forms.Label lblNotes;
        private System.Windows.Forms.TextBox txtCash;
        private System.Windows.Forms.Label lblCash;
        private System.Windows.Forms.TextBox txtEntryId_User;
        private System.Windows.Forms.Label lblEntryId_User;
        private System.Windows.Forms.ComboBox cmbDepositorId;
        private System.Windows.Forms.DateTimePicker txtEntryDate;
        private System.Windows.Forms.Label lblBithDate;
        private System.Windows.Forms.TextBox txtTotalAmount;
        private System.Windows.Forms.Label lblTotalAmount;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbDepositTypeId;
        private System.Windows.Forms.Label lblEntryDate;
        private System.Windows.Forms.TabControl tabResults;
        private System.Windows.Forms.TabPage tbCash;
        private System.Windows.Forms.FlowLayoutPanel pnlAllCash;
        private System.Windows.Forms.TabPage tblDepositType;
        private System.Windows.Forms.DataGridView grdCashClassify;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCashClassify;
        private System.Windows.Forms.DataGridViewTextBoxColumn gCashClassify;
        private System.Windows.Forms.DataGridViewTextBoxColumn gCashSum;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripDropDownButton mnuStdReports;
        private System.Windows.Forms.ToolStripMenuItem mnuRptCashBalance;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripMenuItem MnuRptCashDepositors;
        private System.Windows.Forms.DataGridViewTextBoxColumn gEntryId;
        private System.Windows.Forms.DataGridViewTextBoxColumn gDateEntry;
        private System.Windows.Forms.DataGridViewTextBoxColumn gEntryId_User;
        private System.Windows.Forms.DataGridViewTextBoxColumn gCash;
        private System.Windows.Forms.DataGridViewTextBoxColumn ggDepositType;
    }
}