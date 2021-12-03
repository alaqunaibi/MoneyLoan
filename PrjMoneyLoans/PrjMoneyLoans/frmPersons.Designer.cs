namespace PrjMoneyLoans
{
    partial class frmPersons
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPersons));
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.cmbMaritalStatusId = new System.Windows.Forms.ComboBox();
            this.lblMaritalStatusId = new System.Windows.Forms.Label();
            this.txtPlaceOfBirth = new System.Windows.Forms.TextBox();
            this.lblPlaceOfBirth = new System.Windows.Forms.Label();
            this.cmbPersonStatusId = new System.Windows.Forms.ComboBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.txtBithDate = new System.Windows.Forms.DateTimePicker();
            this.txtPersonName = new System.Windows.Forms.TextBox();
            this.lblPersonName = new System.Windows.Forms.Label();
            this.txtNotes = new System.Windows.Forms.TextBox();
            this.lblNotes = new System.Windows.Forms.Label();
            this.txtJob = new System.Windows.Forms.TextBox();
            this.lblJob = new System.Windows.Forms.Label();
            this.lblBithDate = new System.Windows.Forms.Label();
            this.txtAccountId = new System.Windows.Forms.TextBox();
            this.lblPersonId = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnPrint = new System.Windows.Forms.Button();
            this.btnReturn = new System.Windows.Forms.Button();
            this.grdPersons = new System.Windows.Forms.DataGridView();
            this.gAccountId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gPersonId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gPersonName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtPersonId = new System.Windows.Forms.TextBox();
            this.txtDocId = new System.Windows.Forms.TextBox();
            this.lblDocId = new System.Windows.Forms.Label();
            this.cmbNationalityId = new System.Windows.Forms.ComboBox();
            this.lblNationalityId = new System.Windows.Forms.Label();
            this.lblGenderId = new System.Windows.Forms.Label();
            this.cmbQualificationID = new System.Windows.Forms.ComboBox();
            this.lblQualificationID = new System.Windows.Forms.Label();
            this.cmbHealthStatusId = new System.Windows.Forms.ComboBox();
            this.lblHealthStatusId = new System.Windows.Forms.Label();
            this.cmbStudyStageId = new System.Windows.Forms.ComboBox();
            this.lblStudyStageId = new System.Windows.Forms.Label();
            this.cmbGenderId = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdPersons)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Lavender;
            this.panel1.Controls.Add(this.lblTitle);
            this.panel1.Enabled = false;
            this.panel1.Location = new System.Drawing.Point(381, 14);
            this.panel1.Name = "panel1";
            this.panel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.panel1.Size = new System.Drawing.Size(566, 40);
            this.panel1.TabIndex = 273;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblTitle.Font = new System.Drawing.Font("Arial", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.lblTitle.Location = new System.Drawing.Point(219, 8);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(112, 22);
            this.lblTitle.TabIndex = 238;
            this.lblTitle.Text = "بـيـانـات الأفـــراد";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cmbMaritalStatusId
            // 
            this.cmbMaritalStatusId.BackColor = System.Drawing.Color.GhostWhite;
            this.cmbMaritalStatusId.DisplayMember = "DisplayMember";
            this.cmbMaritalStatusId.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmbMaritalStatusId.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.cmbMaritalStatusId.FormattingEnabled = true;
            this.cmbMaritalStatusId.Location = new System.Drawing.Point(728, 155);
            this.cmbMaritalStatusId.Name = "cmbMaritalStatusId";
            this.cmbMaritalStatusId.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cmbMaritalStatusId.Size = new System.Drawing.Size(118, 27);
            this.cmbMaritalStatusId.TabIndex = 272;
            this.cmbMaritalStatusId.ValueMember = "ValueMember";
            // 
            // lblMaritalStatusId
            // 
            this.lblMaritalStatusId.AutoSize = true;
            this.lblMaritalStatusId.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.lblMaritalStatusId.ForeColor = System.Drawing.Color.Navy;
            this.lblMaritalStatusId.Location = new System.Drawing.Point(848, 158);
            this.lblMaritalStatusId.Name = "lblMaritalStatusId";
            this.lblMaritalStatusId.Size = new System.Drawing.Size(99, 19);
            this.lblMaritalStatusId.TabIndex = 271;
            this.lblMaritalStatusId.Text = "الحالة الاجتماعية";
            // 
            // txtPlaceOfBirth
            // 
            this.txtPlaceOfBirth.BackColor = System.Drawing.Color.GhostWhite;
            this.txtPlaceOfBirth.Font = new System.Drawing.Font("Tahoma", 12F);
            this.txtPlaceOfBirth.Location = new System.Drawing.Point(381, 91);
            this.txtPlaceOfBirth.Name = "txtPlaceOfBirth";
            this.txtPlaceOfBirth.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtPlaceOfBirth.Size = new System.Drawing.Size(163, 27);
            this.txtPlaceOfBirth.TabIndex = 269;
            // 
            // lblPlaceOfBirth
            // 
            this.lblPlaceOfBirth.AutoSize = true;
            this.lblPlaceOfBirth.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.lblPlaceOfBirth.ForeColor = System.Drawing.Color.Navy;
            this.lblPlaceOfBirth.Location = new System.Drawing.Point(551, 99);
            this.lblPlaceOfBirth.Name = "lblPlaceOfBirth";
            this.lblPlaceOfBirth.Size = new System.Drawing.Size(72, 19);
            this.lblPlaceOfBirth.TabIndex = 270;
            this.lblPlaceOfBirth.Text = "مكان الولادة";
            // 
            // cmbPersonStatusId
            // 
            this.cmbPersonStatusId.BackColor = System.Drawing.Color.Khaki;
            this.cmbPersonStatusId.DisplayMember = "DisplayMember";
            this.cmbPersonStatusId.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmbPersonStatusId.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.cmbPersonStatusId.FormattingEnabled = true;
            this.cmbPersonStatusId.Location = new System.Drawing.Point(381, 299);
            this.cmbPersonStatusId.Name = "cmbPersonStatusId";
            this.cmbPersonStatusId.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cmbPersonStatusId.Size = new System.Drawing.Size(118, 27);
            this.cmbPersonStatusId.TabIndex = 267;
            this.cmbPersonStatusId.ValueMember = "ValueMember";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.BackColor = System.Drawing.Color.PowderBlue;
            this.lblStatus.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.lblStatus.ForeColor = System.Drawing.Color.Navy;
            this.lblStatus.Location = new System.Drawing.Point(505, 303);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(61, 19);
            this.lblStatus.TabIndex = 268;
            this.lblStatus.Text = "حالة الفرد";
            // 
            // txtBithDate
            // 
            this.txtBithDate.CalendarForeColor = System.Drawing.Color.Navy;
            this.txtBithDate.CustomFormat = "yyyy/MM/dd";
            this.txtBithDate.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.txtBithDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.txtBithDate.Location = new System.Drawing.Point(728, 94);
            this.txtBithDate.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.txtBithDate.Name = "txtBithDate";
            this.txtBithDate.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtBithDate.RightToLeftLayout = true;
            this.txtBithDate.Size = new System.Drawing.Size(118, 26);
            this.txtBithDate.TabIndex = 266;
            this.txtBithDate.ValueChanged += new System.EventHandler(this.txtBithDate_ValueChanged);
            // 
            // txtPersonName
            // 
            this.txtPersonName.BackColor = System.Drawing.Color.GhostWhite;
            this.txtPersonName.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.txtPersonName.Location = new System.Drawing.Point(381, 61);
            this.txtPersonName.Name = "txtPersonName";
            this.txtPersonName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtPersonName.Size = new System.Drawing.Size(260, 27);
            this.txtPersonName.TabIndex = 257;
            this.txtPersonName.Tag = "PersonName";
            // 
            // lblPersonName
            // 
            this.lblPersonName.AutoSize = true;
            this.lblPersonName.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.lblPersonName.ForeColor = System.Drawing.Color.Navy;
            this.lblPersonName.Location = new System.Drawing.Point(647, 67);
            this.lblPersonName.Name = "lblPersonName";
            this.lblPersonName.Size = new System.Drawing.Size(46, 19);
            this.lblPersonName.TabIndex = 265;
            this.lblPersonName.Text = "الاســـم";
            // 
            // txtNotes
            // 
            this.txtNotes.AcceptsReturn = true;
            this.txtNotes.Font = new System.Drawing.Font("Tahoma", 12F);
            this.txtNotes.Location = new System.Drawing.Point(381, 332);
            this.txtNotes.Multiline = true;
            this.txtNotes.Name = "txtNotes";
            this.txtNotes.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtNotes.Size = new System.Drawing.Size(465, 32);
            this.txtNotes.TabIndex = 258;
            this.txtNotes.Tag = "string";
            // 
            // lblNotes
            // 
            this.lblNotes.AutoSize = true;
            this.lblNotes.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.lblNotes.ForeColor = System.Drawing.Color.Navy;
            this.lblNotes.Location = new System.Drawing.Point(852, 336);
            this.lblNotes.Name = "lblNotes";
            this.lblNotes.Size = new System.Drawing.Size(63, 19);
            this.lblNotes.TabIndex = 264;
            this.lblNotes.Text = "الملاحظات";
            // 
            // txtJob
            // 
            this.txtJob.BackColor = System.Drawing.Color.GhostWhite;
            this.txtJob.Font = new System.Drawing.Font("Tahoma", 12F);
            this.txtJob.Location = new System.Drawing.Point(381, 184);
            this.txtJob.Name = "txtJob";
            this.txtJob.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtJob.Size = new System.Drawing.Size(163, 27);
            this.txtJob.TabIndex = 255;
            this.txtJob.Tag = "Optional";
            // 
            // lblJob
            // 
            this.lblJob.AutoSize = true;
            this.lblJob.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.lblJob.ForeColor = System.Drawing.Color.Navy;
            this.lblJob.Location = new System.Drawing.Point(550, 187);
            this.lblJob.Name = "lblJob";
            this.lblJob.Size = new System.Drawing.Size(48, 19);
            this.lblJob.TabIndex = 263;
            this.lblJob.Text = "الوظيفة";
            // 
            // lblBithDate
            // 
            this.lblBithDate.AutoSize = true;
            this.lblBithDate.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.lblBithDate.ForeColor = System.Drawing.Color.Navy;
            this.lblBithDate.Location = new System.Drawing.Point(848, 101);
            this.lblBithDate.Name = "lblBithDate";
            this.lblBithDate.Size = new System.Drawing.Size(74, 19);
            this.lblBithDate.TabIndex = 260;
            this.lblBithDate.Text = "تاريخ الميلاد";
            // 
            // txtAccountId
            // 
            this.txtAccountId.AcceptsReturn = true;
            this.txtAccountId.BackColor = System.Drawing.Color.Pink;
            this.txtAccountId.Enabled = false;
            this.txtAccountId.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.txtAccountId.Location = new System.Drawing.Point(381, 233);
            this.txtAccountId.Name = "txtAccountId";
            this.txtAccountId.ReadOnly = true;
            this.txtAccountId.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtAccountId.Size = new System.Drawing.Size(118, 27);
            this.txtAccountId.TabIndex = 253;
            this.txtAccountId.Tag = "int";
            this.txtAccountId.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtAccountId.Visible = false;
            // 
            // lblPersonId
            // 
            this.lblPersonId.AutoSize = true;
            this.lblPersonId.BackColor = System.Drawing.SystemColors.Control;
            this.lblPersonId.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.lblPersonId.ForeColor = System.Drawing.Color.Navy;
            this.lblPersonId.Location = new System.Drawing.Point(848, 67);
            this.lblPersonId.Name = "lblPersonId";
            this.lblPersonId.Size = new System.Drawing.Size(56, 19);
            this.lblPersonId.TabIndex = 259;
            this.lblPersonId.Text = "رقم الفرد";
            this.lblPersonId.Click += new System.EventHandler(this.lblPersonId_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.btnSave);
            this.flowLayoutPanel1.Controls.Add(this.btnClear);
            this.flowLayoutPanel1.Controls.Add(this.btnDelete);
            this.flowLayoutPanel1.Controls.Add(this.btnSearch);
            this.flowLayoutPanel1.Controls.Add(this.btnPrint);
            this.flowLayoutPanel1.Controls.Add(this.btnReturn);
            this.flowLayoutPanel1.ForeColor = System.Drawing.Color.Navy;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(200, 372);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.flowLayoutPanel1.Size = new System.Drawing.Size(682, 42);
            this.flowLayoutPanel1.TabIndex = 252;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.Lavender;
            this.btnSave.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.btnSave.ForeColor = System.Drawing.Color.Purple;
            this.btnSave.Location = new System.Drawing.Point(582, 3);
            this.btnSave.Margin = new System.Windows.Forms.Padding(10, 3, 10, 3);
            this.btnSave.Name = "btnSave";
            this.btnSave.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.btnSave.Size = new System.Drawing.Size(90, 35);
            this.btnSave.TabIndex = 8;
            this.btnSave.Text = "حفظ";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.Lavender;
            this.btnClear.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.btnClear.ForeColor = System.Drawing.Color.Purple;
            this.btnClear.Location = new System.Drawing.Point(460, 3);
            this.btnClear.Margin = new System.Windows.Forms.Padding(10, 3, 10, 3);
            this.btnClear.Name = "btnClear";
            this.btnClear.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.btnClear.Size = new System.Drawing.Size(102, 35);
            this.btnClear.TabIndex = 12;
            this.btnClear.Text = "مسح / تنظيف";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Lavender;
            this.btnDelete.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.btnDelete.ForeColor = System.Drawing.Color.Purple;
            this.btnDelete.Location = new System.Drawing.Point(340, 3);
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
            this.btnSearch.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.btnSearch.ForeColor = System.Drawing.Color.Purple;
            this.btnSearch.Location = new System.Drawing.Point(230, 3);
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
            this.btnPrint.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.btnPrint.ForeColor = System.Drawing.Color.Purple;
            this.btnPrint.Location = new System.Drawing.Point(120, 3);
            this.btnPrint.Margin = new System.Windows.Forms.Padding(10, 3, 10, 3);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.btnPrint.Size = new System.Drawing.Size(90, 35);
            this.btnPrint.TabIndex = 10;
            this.btnPrint.Text = "طباعة";
            this.btnPrint.UseVisualStyleBackColor = false;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // btnReturn
            // 
            this.btnReturn.BackColor = System.Drawing.Color.Lavender;
            this.btnReturn.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.btnReturn.ForeColor = System.Drawing.Color.Purple;
            this.btnReturn.Location = new System.Drawing.Point(17, 3);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(90, 35);
            this.btnReturn.TabIndex = 13;
            this.btnReturn.Text = "عودة";
            this.btnReturn.UseVisualStyleBackColor = false;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // grdPersons
            // 
            this.grdPersons.AccessibleDescription = "أسماء المتبرعين";
            this.grdPersons.AllowUserToAddRows = false;
            this.grdPersons.AllowUserToDeleteRows = false;
            this.grdPersons.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grdPersons.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdPersons.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.gAccountId,
            this.gPersonId,
            this.gPersonName});
            this.grdPersons.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.grdPersons.Location = new System.Drawing.Point(18, 13);
            this.grdPersons.MultiSelect = false;
            this.grdPersons.Name = "grdPersons";
            this.grdPersons.ReadOnly = true;
            this.grdPersons.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.grdPersons.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdPersons.Size = new System.Drawing.Size(356, 351);
            this.grdPersons.StandardTab = true;
            this.grdPersons.TabIndex = 251;
            this.grdPersons.TabStop = false;
            this.grdPersons.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdPersons_CellClick);
            // 
            // gAccountId
            // 
            this.gAccountId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.gAccountId.DataPropertyName = "AccountId";
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gAccountId.DefaultCellStyle = dataGridViewCellStyle1;
            this.gAccountId.HeaderText = "رقم الحساب";
            this.gAccountId.Name = "gAccountId";
            this.gAccountId.ReadOnly = true;
            this.gAccountId.Visible = false;
            // 
            // gPersonId
            // 
            this.gPersonId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.gPersonId.DataPropertyName = "PersonId";
            this.gPersonId.HeaderText = "رقم الفرد";
            this.gPersonId.Name = "gPersonId";
            this.gPersonId.ReadOnly = true;
            this.gPersonId.Width = 74;
            // 
            // gPersonName
            // 
            this.gPersonName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.gPersonName.DataPropertyName = "PersonName";
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gPersonName.DefaultCellStyle = dataGridViewCellStyle2;
            this.gPersonName.FillWeight = 200F;
            this.gPersonName.HeaderText = "اســم الفرد";
            this.gPersonName.Name = "gPersonName";
            this.gPersonName.ReadOnly = true;
            this.gPersonName.Width = 85;
            // 
            // txtPersonId
            // 
            this.txtPersonId.BackColor = System.Drawing.Color.GhostWhite;
            this.txtPersonId.Enabled = false;
            this.txtPersonId.Font = new System.Drawing.Font("Tahoma", 12F);
            this.txtPersonId.Location = new System.Drawing.Point(728, 61);
            this.txtPersonId.Name = "txtPersonId";
            this.txtPersonId.ReadOnly = true;
            this.txtPersonId.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtPersonId.Size = new System.Drawing.Size(118, 27);
            this.txtPersonId.TabIndex = 250;
            this.txtPersonId.Tag = "int";
            this.txtPersonId.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtPersonId.TextChanged += new System.EventHandler(this.txtPersonId_TextChanged);
            // 
            // txtDocId
            // 
            this.txtDocId.BackColor = System.Drawing.Color.GhostWhite;
            this.txtDocId.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txtDocId.Location = new System.Drawing.Point(381, 154);
            this.txtDocId.Name = "txtDocId";
            this.txtDocId.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtDocId.Size = new System.Drawing.Size(163, 26);
            this.txtDocId.TabIndex = 279;
            this.txtDocId.Tag = "";
            // 
            // lblDocId
            // 
            this.lblDocId.AutoSize = true;
            this.lblDocId.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.lblDocId.ForeColor = System.Drawing.Color.Navy;
            this.lblDocId.Location = new System.Drawing.Point(551, 157);
            this.lblDocId.Name = "lblDocId";
            this.lblDocId.Size = new System.Drawing.Size(66, 19);
            this.lblDocId.TabIndex = 278;
            this.lblDocId.Text = "رقم الوثيقة";
            // 
            // cmbNationalityId
            // 
            this.cmbNationalityId.BackColor = System.Drawing.Color.GhostWhite;
            this.cmbNationalityId.DisplayMember = "Nationality";
            this.cmbNationalityId.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmbNationalityId.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.cmbNationalityId.FormattingEnabled = true;
            this.cmbNationalityId.Location = new System.Drawing.Point(381, 122);
            this.cmbNationalityId.Name = "cmbNationalityId";
            this.cmbNationalityId.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cmbNationalityId.Size = new System.Drawing.Size(163, 27);
            this.cmbNationalityId.TabIndex = 276;
            this.cmbNationalityId.ValueMember = "NationalityId";
            this.cmbNationalityId.SelectedIndexChanged += new System.EventHandler(this.cmbNationalityId_SelectedIndexChanged);
            // 
            // lblNationalityId
            // 
            this.lblNationalityId.AutoSize = true;
            this.lblNationalityId.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.lblNationalityId.ForeColor = System.Drawing.Color.Navy;
            this.lblNationalityId.Location = new System.Drawing.Point(551, 125);
            this.lblNationalityId.Name = "lblNationalityId";
            this.lblNationalityId.Size = new System.Drawing.Size(50, 19);
            this.lblNationalityId.TabIndex = 277;
            this.lblNationalityId.Text = "الجنسية";
            // 
            // lblGenderId
            // 
            this.lblGenderId.AutoSize = true;
            this.lblGenderId.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.lblGenderId.ForeColor = System.Drawing.Color.Navy;
            this.lblGenderId.Location = new System.Drawing.Point(848, 122);
            this.lblGenderId.Name = "lblGenderId";
            this.lblGenderId.Size = new System.Drawing.Size(49, 19);
            this.lblGenderId.TabIndex = 280;
            this.lblGenderId.Text = "الجنــس";
            // 
            // cmbQualificationID
            // 
            this.cmbQualificationID.BackColor = System.Drawing.Color.GhostWhite;
            this.cmbQualificationID.DisplayMember = "DisplayMember";
            this.cmbQualificationID.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmbQualificationID.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.cmbQualificationID.FormattingEnabled = true;
            this.cmbQualificationID.Location = new System.Drawing.Point(728, 188);
            this.cmbQualificationID.Name = "cmbQualificationID";
            this.cmbQualificationID.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cmbQualificationID.Size = new System.Drawing.Size(118, 27);
            this.cmbQualificationID.TabIndex = 283;
            this.cmbQualificationID.ValueMember = "ValueMember";
            // 
            // lblQualificationID
            // 
            this.lblQualificationID.AutoSize = true;
            this.lblQualificationID.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.lblQualificationID.ForeColor = System.Drawing.Color.Navy;
            this.lblQualificationID.Location = new System.Drawing.Point(848, 188);
            this.lblQualificationID.Name = "lblQualificationID";
            this.lblQualificationID.Size = new System.Drawing.Size(84, 19);
            this.lblQualificationID.TabIndex = 282;
            this.lblQualificationID.Text = "المؤهل العلمي";
            // 
            // cmbHealthStatusId
            // 
            this.cmbHealthStatusId.BackColor = System.Drawing.Color.GhostWhite;
            this.cmbHealthStatusId.DisplayMember = "DisplayMember";
            this.cmbHealthStatusId.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmbHealthStatusId.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.cmbHealthStatusId.FormattingEnabled = true;
            this.cmbHealthStatusId.Location = new System.Drawing.Point(728, 255);
            this.cmbHealthStatusId.Name = "cmbHealthStatusId";
            this.cmbHealthStatusId.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cmbHealthStatusId.Size = new System.Drawing.Size(118, 27);
            this.cmbHealthStatusId.TabIndex = 289;
            this.cmbHealthStatusId.ValueMember = "ValueMember";
            // 
            // lblHealthStatusId
            // 
            this.lblHealthStatusId.AutoSize = true;
            this.lblHealthStatusId.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.lblHealthStatusId.ForeColor = System.Drawing.Color.Navy;
            this.lblHealthStatusId.Location = new System.Drawing.Point(848, 258);
            this.lblHealthStatusId.Name = "lblHealthStatusId";
            this.lblHealthStatusId.Size = new System.Drawing.Size(83, 19);
            this.lblHealthStatusId.TabIndex = 288;
            this.lblHealthStatusId.Text = "الحالة الصحية";
            // 
            // cmbStudyStageId
            // 
            this.cmbStudyStageId.BackColor = System.Drawing.Color.GhostWhite;
            this.cmbStudyStageId.DisplayMember = "DisplayMember";
            this.cmbStudyStageId.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmbStudyStageId.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.cmbStudyStageId.FormattingEnabled = true;
            this.cmbStudyStageId.Location = new System.Drawing.Point(728, 221);
            this.cmbStudyStageId.Name = "cmbStudyStageId";
            this.cmbStudyStageId.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cmbStudyStageId.Size = new System.Drawing.Size(118, 27);
            this.cmbStudyStageId.TabIndex = 291;
            this.cmbStudyStageId.ValueMember = "ValueMember";
            // 
            // lblStudyStageId
            // 
            this.lblStudyStageId.AutoSize = true;
            this.lblStudyStageId.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.lblStudyStageId.ForeColor = System.Drawing.Color.Navy;
            this.lblStudyStageId.Location = new System.Drawing.Point(848, 221);
            this.lblStudyStageId.Name = "lblStudyStageId";
            this.lblStudyStageId.Size = new System.Drawing.Size(87, 19);
            this.lblStudyStageId.TabIndex = 290;
            this.lblStudyStageId.Text = "السنة الدراسية";
            // 
            // cmbGenderId
            // 
            this.cmbGenderId.BackColor = System.Drawing.Color.GhostWhite;
            this.cmbGenderId.DisplayMember = "DisplayMember";
            this.cmbGenderId.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmbGenderId.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.cmbGenderId.FormattingEnabled = true;
            this.cmbGenderId.Location = new System.Drawing.Point(728, 123);
            this.cmbGenderId.Name = "cmbGenderId";
            this.cmbGenderId.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cmbGenderId.Size = new System.Drawing.Size(118, 27);
            this.cmbGenderId.TabIndex = 292;
            this.cmbGenderId.ValueMember = "ValueMember";
            // 
            // frmPersons
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(965, 419);
            this.Controls.Add(this.cmbGenderId);
            this.Controls.Add(this.cmbStudyStageId);
            this.Controls.Add(this.lblStudyStageId);
            this.Controls.Add(this.cmbHealthStatusId);
            this.Controls.Add(this.lblHealthStatusId);
            this.Controls.Add(this.cmbQualificationID);
            this.Controls.Add(this.lblQualificationID);
            this.Controls.Add(this.lblGenderId);
            this.Controls.Add(this.txtDocId);
            this.Controls.Add(this.lblDocId);
            this.Controls.Add(this.cmbNationalityId);
            this.Controls.Add(this.lblNationalityId);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.cmbMaritalStatusId);
            this.Controls.Add(this.lblMaritalStatusId);
            this.Controls.Add(this.txtPlaceOfBirth);
            this.Controls.Add(this.lblPlaceOfBirth);
            this.Controls.Add(this.cmbPersonStatusId);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.txtBithDate);
            this.Controls.Add(this.txtPersonName);
            this.Controls.Add(this.lblPersonName);
            this.Controls.Add(this.txtNotes);
            this.Controls.Add(this.lblNotes);
            this.Controls.Add(this.txtJob);
            this.Controls.Add(this.lblJob);
            this.Controls.Add(this.lblBithDate);
            this.Controls.Add(this.txtAccountId);
            this.Controls.Add(this.lblPersonId);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.grdPersons);
            this.Controls.Add(this.txtPersonId);
            this.ForeColor = System.Drawing.Color.MidnightBlue;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmPersons";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmPersons";
            this.Load += new System.EventHandler(this.frmPersons_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdPersons)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.ComboBox cmbMaritalStatusId;
        private System.Windows.Forms.Label lblMaritalStatusId;
        private System.Windows.Forms.TextBox txtPlaceOfBirth;
        private System.Windows.Forms.Label lblPlaceOfBirth;
        private System.Windows.Forms.ComboBox cmbPersonStatusId;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.DateTimePicker txtBithDate;
        private System.Windows.Forms.TextBox txtPersonName;
        private System.Windows.Forms.Label lblPersonName;
        private System.Windows.Forms.TextBox txtNotes;
        private System.Windows.Forms.Label lblNotes;
        private System.Windows.Forms.TextBox txtJob;
        private System.Windows.Forms.Label lblJob;
        private System.Windows.Forms.Label lblBithDate;
        private System.Windows.Forms.TextBox txtAccountId;
        private System.Windows.Forms.Label lblPersonId;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.DataGridView grdPersons;
         private System.Windows.Forms.TextBox txtPersonId;
        private System.Windows.Forms.TextBox txtDocId;
        private System.Windows.Forms.Label lblDocId;
        private System.Windows.Forms.ComboBox cmbNationalityId;
        private System.Windows.Forms.Label lblNationalityId;
        private System.Windows.Forms.Label lblGenderId;
        private System.Windows.Forms.ComboBox cmbQualificationID;
        private System.Windows.Forms.Label lblQualificationID;
        private System.Windows.Forms.ComboBox cmbHealthStatusId;
        private System.Windows.Forms.Label lblHealthStatusId;
        private System.Windows.Forms.ComboBox cmbStudyStageId;
        private System.Windows.Forms.Label lblStudyStageId;
        private System.Windows.Forms.ComboBox cmbGenderId;
        private System.Windows.Forms.DataGridViewTextBoxColumn gAccountId;
        private System.Windows.Forms.DataGridViewTextBoxColumn gPersonId;
        private System.Windows.Forms.DataGridViewTextBoxColumn gPersonName;
    }
}