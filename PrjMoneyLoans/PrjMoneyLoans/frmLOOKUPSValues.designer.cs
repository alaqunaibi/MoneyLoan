namespace PrjMoneyLoans
{
    partial class frmLOOKUPSValues
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLOOKUPSValues));
            this.btnNew = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.grdDisplayMembers = new System.Windows.Forms.DataGridView();
            this.ValueMember = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DisplayMember = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtDisplayMember = new System.Windows.Forms.TextBox();
            this.lblDisplayMember = new System.Windows.Forms.Label();
            this.txtValueMember = new System.Windows.Forms.TextBox();
            this.btnReturn = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.lblValueMember = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblClientTypeid = new System.Windows.Forms.Label();
            this.cmbLKUPTables = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.grdDisplayMembers)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnNew
            // 
            this.btnNew.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.btnNew.ForeColor = System.Drawing.Color.Navy;
            this.btnNew.Location = new System.Drawing.Point(604, 229);
            this.btnNew.Margin = new System.Windows.Forms.Padding(10, 3, 10, 3);
            this.btnNew.Name = "btnNew";
            this.btnNew.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.btnNew.Size = new System.Drawing.Size(90, 35);
            this.btnNew.TabIndex = 126;
            this.btnNew.Text = "جديـــد";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.btnClear.ForeColor = System.Drawing.Color.Navy;
            this.btnClear.Location = new System.Drawing.Point(386, 229);
            this.btnClear.Margin = new System.Windows.Forms.Padding(10, 3, 10, 3);
            this.btnClear.Name = "btnClear";
            this.btnClear.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.btnClear.Size = new System.Drawing.Size(102, 35);
            this.btnClear.TabIndex = 128;
            this.btnClear.Text = "مسح / تنظيف";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.btnSearch.ForeColor = System.Drawing.Color.Navy;
            this.btnSearch.Location = new System.Drawing.Point(283, 229);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(90, 35);
            this.btnSearch.TabIndex = 129;
            this.btnSearch.Text = "بحث";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // grdDisplayMembers
            // 
            this.grdDisplayMembers.AccessibleDescription = "أسماء الفصول";
            this.grdDisplayMembers.AllowUserToAddRows = false;
            this.grdDisplayMembers.AllowUserToDeleteRows = false;
            this.grdDisplayMembers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grdDisplayMembers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdDisplayMembers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ValueMember,
            this.DisplayMember});
            this.grdDisplayMembers.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.grdDisplayMembers.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this.grdDisplayMembers.Location = new System.Drawing.Point(2, 22);
            this.grdDisplayMembers.MultiSelect = false;
            this.grdDisplayMembers.Name = "grdDisplayMembers";
            this.grdDisplayMembers.ReadOnly = true;
            this.grdDisplayMembers.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.grdDisplayMembers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdDisplayMembers.Size = new System.Drawing.Size(368, 194);
            this.grdDisplayMembers.StandardTab = true;
            this.grdDisplayMembers.TabIndex = 134;
            this.grdDisplayMembers.TabStop = false;
            this.grdDisplayMembers.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdDisplayMembers_CellClick);
            // 
            // ValueMember
            // 
            this.ValueMember.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ValueMember.DataPropertyName = "ValueMember";
            this.ValueMember.HeaderText = "AAA الجنسية";
            this.ValueMember.Name = "ValueMember";
            this.ValueMember.ReadOnly = true;
            // 
            // DisplayMember
            // 
            this.DisplayMember.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.DisplayMember.DataPropertyName = "DisplayMember";
            this.DisplayMember.HeaderText = "اسم الجنسية";
            this.DisplayMember.Name = "DisplayMember";
            this.DisplayMember.ReadOnly = true;
            // 
            // txtDisplayMember
            // 
            this.txtDisplayMember.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.txtDisplayMember.Location = new System.Drawing.Point(376, 109);
            this.txtDisplayMember.Name = "txtDisplayMember";
            this.txtDisplayMember.Size = new System.Drawing.Size(252, 26);
            this.txtDisplayMember.TabIndex = 125;
            this.txtDisplayMember.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblDisplayMember
            // 
            this.lblDisplayMember.AutoSize = true;
            this.lblDisplayMember.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.lblDisplayMember.ForeColor = System.Drawing.Color.Navy;
            this.lblDisplayMember.Location = new System.Drawing.Point(642, 109);
            this.lblDisplayMember.Name = "lblDisplayMember";
            this.lblDisplayMember.Size = new System.Drawing.Size(74, 19);
            this.lblDisplayMember.TabIndex = 133;
            this.lblDisplayMember.Text = "اسم الجنسية";
            // 
            // txtValueMember
            // 
            this.txtValueMember.BackColor = System.Drawing.Color.White;
            this.txtValueMember.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.txtValueMember.Location = new System.Drawing.Point(555, 76);
            this.txtValueMember.Name = "txtValueMember";
            this.txtValueMember.ReadOnly = true;
            this.txtValueMember.Size = new System.Drawing.Size(73, 26);
            this.txtValueMember.TabIndex = 124;
            this.txtValueMember.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnReturn
            // 
            this.btnReturn.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.btnReturn.ForeColor = System.Drawing.Color.Navy;
            this.btnReturn.Location = new System.Drawing.Point(67, 229);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(90, 35);
            this.btnReturn.TabIndex = 131;
            this.btnReturn.Text = "عودة";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.btnDelete.ForeColor = System.Drawing.Color.Navy;
            this.btnDelete.Location = new System.Drawing.Point(170, 229);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(100, 35);
            this.btnDelete.TabIndex = 130;
            this.btnDelete.Text = "حــذف";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.btnSave.ForeColor = System.Drawing.Color.Navy;
            this.btnSave.Location = new System.Drawing.Point(501, 229);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(90, 35);
            this.btnSave.TabIndex = 127;
            this.btnSave.Text = "حفظ";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // lblValueMember
            // 
            this.lblValueMember.AutoSize = true;
            this.lblValueMember.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.lblValueMember.ForeColor = System.Drawing.Color.Navy;
            this.lblValueMember.Location = new System.Drawing.Point(644, 76);
            this.lblValueMember.Name = "lblValueMember";
            this.lblValueMember.Size = new System.Drawing.Size(72, 19);
            this.lblValueMember.TabIndex = 132;
            this.lblValueMember.Text = "رقم الجنسية";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblClientTypeid);
            this.panel1.Controls.Add(this.cmbLKUPTables);
            this.panel1.Location = new System.Drawing.Point(376, 22);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(373, 38);
            this.panel1.TabIndex = 137;
            this.panel1.Visible = false;
            // 
            // lblClientTypeid
            // 
            this.lblClientTypeid.Font = new System.Drawing.Font("Arial", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClientTypeid.ForeColor = System.Drawing.Color.Navy;
            this.lblClientTypeid.Location = new System.Drawing.Point(265, 4);
            this.lblClientTypeid.Name = "lblClientTypeid";
            this.lblClientTypeid.Size = new System.Drawing.Size(75, 27);
            this.lblClientTypeid.TabIndex = 137;
            this.lblClientTypeid.Text = "اسم القائمة";
            this.lblClientTypeid.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cmbLKUPTables
            // 
            this.cmbLKUPTables.DisplayMember = "LookUpTableNameArb";
            this.cmbLKUPTables.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.cmbLKUPTables.FormattingEnabled = true;
            this.cmbLKUPTables.Location = new System.Drawing.Point(3, 5);
            this.cmbLKUPTables.Name = "cmbLKUPTables";
            this.cmbLKUPTables.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cmbLKUPTables.Size = new System.Drawing.Size(249, 27);
            this.cmbLKUPTables.TabIndex = 138;
            this.cmbLKUPTables.Tag = "Number";
            this.cmbLKUPTables.ValueMember = "LookUpTableId";
            this.cmbLKUPTables.SelectedIndexChanged += new System.EventHandler(this.cmbLKUPTables_SelectedIndexChanged);
            // 
            // frmLOOKUPSValues
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(761, 279);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.grdDisplayMembers);
            this.Controls.Add(this.txtDisplayMember);
            this.Controls.Add(this.lblDisplayMember);
            this.Controls.Add(this.txtValueMember);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.lblValueMember);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmLOOKUPSValues";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ترمز قوائم النظام";
            this.Load += new System.EventHandler(this.frmLOOKUPS_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdDisplayMembers)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.DataGridView grdDisplayMembers;
        private System.Windows.Forms.DataGridViewTextBoxColumn ValueMember;
        private System.Windows.Forms.DataGridViewTextBoxColumn DisplayMember;
        private System.Windows.Forms.TextBox txtDisplayMember;
        private System.Windows.Forms.Label lblDisplayMember;
        private System.Windows.Forms.TextBox txtValueMember;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lblValueMember;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblClientTypeid;
        public System.Windows.Forms.ComboBox cmbLKUPTables;
    }
}