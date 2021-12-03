namespace PrjMoneyLoans
{
    partial class frmLkupTblNames
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLkupTblNames));
            this.grdLkupTbls = new System.Windows.Forms.DataGridView();
            this.LookUpTableId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LookUpTableName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtLookUpTableName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnReturn = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.btnClean = new System.Windows.Forms.Button();
            this.txtLookUpTableId = new System.Windows.Forms.TextBox();
            this.txtLookUpTableNameArb = new System.Windows.Forms.TextBox();
            this.lblLookUpTableNameArb = new System.Windows.Forms.Label();
            this.txtDisplayMember = new System.Windows.Forms.TextBox();
            this.lblDisplayMember = new System.Windows.Forms.Label();
            this.txtValueMember = new System.Windows.Forms.TextBox();
            this.lblValueMember = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.grdLkupTbls)).BeginInit();
            this.SuspendLayout();
            // 
            // grdLkupTbls
            // 
            this.grdLkupTbls.AccessibleDescription = "جداول البحث";
            this.grdLkupTbls.AllowUserToAddRows = false;
            this.grdLkupTbls.AllowUserToDeleteRows = false;
            this.grdLkupTbls.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grdLkupTbls.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdLkupTbls.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.LookUpTableId,
            this.LookUpTableName});
            this.grdLkupTbls.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.grdLkupTbls.Location = new System.Drawing.Point(14, 3);
            this.grdLkupTbls.MultiSelect = false;
            this.grdLkupTbls.Name = "grdLkupTbls";
            this.grdLkupTbls.ReadOnly = true;
            this.grdLkupTbls.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.grdLkupTbls.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdLkupTbls.Size = new System.Drawing.Size(351, 194);
            this.grdLkupTbls.StandardTab = true;
            this.grdLkupTbls.TabIndex = 113;
            this.grdLkupTbls.TabStop = false;
            this.grdLkupTbls.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdLkupTbls_CellClick);
            // 
            // LookUpTableId
            // 
            this.LookUpTableId.DataPropertyName = "LookUpTableId";
            this.LookUpTableId.HeaderText = "رقم جدول البحث";
            this.LookUpTableId.Name = "LookUpTableId";
            this.LookUpTableId.ReadOnly = true;
            this.LookUpTableId.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // LookUpTableName
            // 
            this.LookUpTableName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.LookUpTableName.DataPropertyName = "LookUpTableName";
            this.LookUpTableName.HeaderText = "اسم جدول البحث";
            this.LookUpTableName.Name = "LookUpTableName";
            this.LookUpTableName.ReadOnly = true;
            // 
            // txtLookUpTableName
            // 
            this.txtLookUpTableName.Font = new System.Drawing.Font("Tahoma", 12F);
            this.txtLookUpTableName.Location = new System.Drawing.Point(371, 91);
            this.txtLookUpTableName.Name = "txtLookUpTableName";
            this.txtLookUpTableName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtLookUpTableName.Size = new System.Drawing.Size(263, 27);
            this.txtLookUpTableName.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(648, 91);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(94, 19);
            this.label6.TabIndex = 110;
            this.label6.Text = "اسم جدول البحث";
            // 
            // btnReturn
            // 
            this.btnReturn.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.btnReturn.Location = new System.Drawing.Point(71, 232);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(90, 35);
            this.btnReturn.TabIndex = 8;
            this.btnReturn.Text = "عودة";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.btnDelete.Location = new System.Drawing.Point(177, 232);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(100, 35);
            this.btnDelete.TabIndex = 7;
            this.btnDelete.Text = "حــذف";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.btnSave.Location = new System.Drawing.Point(517, 232);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(90, 35);
            this.btnSave.TabIndex = 4;
            this.btnSave.Text = "حفظ";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(650, 58);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 19);
            this.label5.TabIndex = 107;
            this.label5.Text = "رقم جدول البحث";
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.btnSearch.Location = new System.Drawing.Point(293, 232);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(90, 35);
            this.btnSearch.TabIndex = 6;
            this.btnSearch.Text = "بحث";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnNew
            // 
            this.btnNew.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.btnNew.Location = new System.Drawing.Point(623, 232);
            this.btnNew.Margin = new System.Windows.Forms.Padding(10, 3, 10, 3);
            this.btnNew.Name = "btnNew";
            this.btnNew.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.btnNew.Size = new System.Drawing.Size(90, 35);
            this.btnNew.TabIndex = 3;
            this.btnNew.Text = "جديـــد";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnClean
            // 
            this.btnClean.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.btnClean.Location = new System.Drawing.Point(399, 232);
            this.btnClean.Margin = new System.Windows.Forms.Padding(10, 3, 10, 3);
            this.btnClean.Name = "btnClean";
            this.btnClean.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.btnClean.Size = new System.Drawing.Size(102, 35);
            this.btnClean.TabIndex = 5;
            this.btnClean.Text = "مسح / تنظيف";
            this.btnClean.UseVisualStyleBackColor = true;
            this.btnClean.Click += new System.EventHandler(this.btnClean_Click);
            // 
            // txtLookUpTableId
            // 
            this.txtLookUpTableId.BackColor = System.Drawing.Color.White;
            this.txtLookUpTableId.Font = new System.Drawing.Font("Tahoma", 12F);
            this.txtLookUpTableId.Location = new System.Drawing.Point(549, 58);
            this.txtLookUpTableId.Name = "txtLookUpTableId";
            this.txtLookUpTableId.ReadOnly = true;
            this.txtLookUpTableId.Size = new System.Drawing.Size(85, 27);
            this.txtLookUpTableId.TabIndex = 233;
            // 
            // txtLookUpTableNameArb
            // 
            this.txtLookUpTableNameArb.Font = new System.Drawing.Font("Tahoma", 12F);
            this.txtLookUpTableNameArb.Location = new System.Drawing.Point(371, 124);
            this.txtLookUpTableNameArb.Name = "txtLookUpTableNameArb";
            this.txtLookUpTableNameArb.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtLookUpTableNameArb.Size = new System.Drawing.Size(263, 27);
            this.txtLookUpTableNameArb.TabIndex = 234;
            // 
            // lblLookUpTableNameArb
            // 
            this.lblLookUpTableNameArb.AutoSize = true;
            this.lblLookUpTableNameArb.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.lblLookUpTableNameArb.Location = new System.Drawing.Point(648, 124);
            this.lblLookUpTableNameArb.Name = "lblLookUpTableNameArb";
            this.lblLookUpTableNameArb.Size = new System.Drawing.Size(110, 19);
            this.lblLookUpTableNameArb.TabIndex = 235;
            this.lblLookUpTableNameArb.Text = "اسم الجدول بالعربي";
            // 
            // txtDisplayMember
            // 
            this.txtDisplayMember.Font = new System.Drawing.Font("Tahoma", 12F);
            this.txtDisplayMember.Location = new System.Drawing.Point(371, 160);
            this.txtDisplayMember.Name = "txtDisplayMember";
            this.txtDisplayMember.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtDisplayMember.Size = new System.Drawing.Size(263, 27);
            this.txtDisplayMember.TabIndex = 236;
            // 
            // lblDisplayMember
            // 
            this.lblDisplayMember.AutoSize = true;
            this.lblDisplayMember.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.lblDisplayMember.Location = new System.Drawing.Point(648, 160);
            this.lblDisplayMember.Name = "lblDisplayMember";
            this.lblDisplayMember.Size = new System.Drawing.Size(127, 19);
            this.lblDisplayMember.TabIndex = 237;
            this.lblDisplayMember.Text = "DisplayMember";
            // 
            // txtValueMember
            // 
            this.txtValueMember.Font = new System.Drawing.Font("Tahoma", 12F);
            this.txtValueMember.Location = new System.Drawing.Point(371, 193);
            this.txtValueMember.Name = "txtValueMember";
            this.txtValueMember.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtValueMember.Size = new System.Drawing.Size(263, 27);
            this.txtValueMember.TabIndex = 238;
            // 
            // lblValueMember
            // 
            this.lblValueMember.AutoSize = true;
            this.lblValueMember.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.lblValueMember.Location = new System.Drawing.Point(648, 193);
            this.lblValueMember.Name = "lblValueMember";
            this.lblValueMember.Size = new System.Drawing.Size(112, 19);
            this.lblValueMember.TabIndex = 239;
            this.lblValueMember.Text = "ValueMember";
            this.lblValueMember.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // frmLkupTblNames
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(776, 279);
            this.Controls.Add(this.txtValueMember);
            this.Controls.Add(this.lblValueMember);
            this.Controls.Add(this.txtDisplayMember);
            this.Controls.Add(this.lblDisplayMember);
            this.Controls.Add(this.txtLookUpTableNameArb);
            this.Controls.Add(this.lblLookUpTableNameArb);
            this.Controls.Add(this.txtLookUpTableId);
            this.Controls.Add(this.btnClean);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.grdLkupTbls);
            this.Controls.Add(this.txtLookUpTableName);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.label5);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmLkupTblNames";
            this.Text = "جداول البحث";
            this.Load += new System.EventHandler(this.frmLkupTblNames_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdLkupTbls)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView grdLkupTbls;
        private System.Windows.Forms.TextBox txtLookUpTableName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Button btnClean;
        private System.Windows.Forms.TextBox txtLookUpTableId;
        private System.Windows.Forms.DataGridViewTextBoxColumn LookUpTableId;
        private System.Windows.Forms.DataGridViewTextBoxColumn LookUpTableName;
        private System.Windows.Forms.TextBox txtLookUpTableNameArb;
        private System.Windows.Forms.Label lblLookUpTableNameArb;
        private System.Windows.Forms.TextBox txtDisplayMember;
        private System.Windows.Forms.Label lblDisplayMember;
        private System.Windows.Forms.TextBox txtValueMember;
        private System.Windows.Forms.Label lblValueMember;
    }
}