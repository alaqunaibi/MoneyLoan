namespace PrjMoneyLoans
{
    partial class frmNationality
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmNationality));
            this.btnClear = new System.Windows.Forms.Button();
            this.btnClean = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.grdNationalitys = new System.Windows.Forms.DataGridView();
            this.Nationalityid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nationalityid_User = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nationality = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DocTypeId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtNationality = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtNationalityid = new System.Windows.Forms.TextBox();
            this.btnReturn = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnsave = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtNationalityid_User = new System.Windows.Forms.TextBox();
            this.LstDocTypeId = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.grdNationalitys)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.btnClear.Location = new System.Drawing.Point(588, 3);
            this.btnClear.Margin = new System.Windows.Forms.Padding(10, 3, 10, 3);
            this.btnClear.Name = "btnClear";
            this.btnClear.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.btnClear.Size = new System.Drawing.Size(90, 35);
            this.btnClear.TabIndex = 126;
            this.btnClear.Text = "جديـــد";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnClean
            // 
            this.btnClean.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.btnClean.Location = new System.Drawing.Point(370, 3);
            this.btnClean.Margin = new System.Windows.Forms.Padding(10, 3, 10, 3);
            this.btnClean.Name = "btnClean";
            this.btnClean.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.btnClean.Size = new System.Drawing.Size(102, 35);
            this.btnClean.TabIndex = 128;
            this.btnClean.Text = "مسح / تنظيف";
            this.btnClean.UseVisualStyleBackColor = true;
            this.btnClean.Click += new System.EventHandler(this.btnClean_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.btnEdit.Location = new System.Drawing.Point(267, 3);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(90, 35);
            this.btnEdit.TabIndex = 129;
            this.btnEdit.Text = "بحث";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // grdNationalitys
            // 
            this.grdNationalitys.AccessibleDescription = "أسماء الفصول";
            this.grdNationalitys.AllowUserToAddRows = false;
            this.grdNationalitys.AllowUserToDeleteRows = false;
            this.grdNationalitys.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grdNationalitys.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdNationalitys.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nationalityid,
            this.Nationalityid_User,
            this.Nationality,
            this.DocTypeId});
            this.grdNationalitys.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.grdNationalitys.Location = new System.Drawing.Point(410, 12);
            this.grdNationalitys.MultiSelect = false;
            this.grdNationalitys.Name = "grdNationalitys";
            this.grdNationalitys.ReadOnly = true;
            this.grdNationalitys.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.grdNationalitys.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdNationalitys.Size = new System.Drawing.Size(359, 194);
            this.grdNationalitys.StandardTab = true;
            this.grdNationalitys.TabIndex = 134;
            this.grdNationalitys.TabStop = false;
            this.grdNationalitys.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdNationalitys_CellClick);
            // 
            // Nationalityid
            // 
            this.Nationalityid.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Nationalityid.DataPropertyName = "Nationalityid";
            this.Nationalityid.HeaderText = "رقم الجنسية";
            this.Nationalityid.Name = "Nationalityid";
            this.Nationalityid.ReadOnly = true;
            this.Nationalityid.Visible = false;
            // 
            // Nationalityid_User
            // 
            this.Nationalityid_User.DataPropertyName = "Nationalityid_User";
            this.Nationalityid_User.HeaderText = "رقم الجنسية";
            this.Nationalityid_User.Name = "Nationalityid_User";
            this.Nationalityid_User.ReadOnly = true;
            // 
            // Nationality
            // 
            this.Nationality.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Nationality.DataPropertyName = "Nationality";
            this.Nationality.HeaderText = "اسم الجنسية";
            this.Nationality.Name = "Nationality";
            this.Nationality.ReadOnly = true;
            // 
            // DocTypeId
            // 
            this.DocTypeId.DataPropertyName = "DocTypeId";
            this.DocTypeId.HeaderText = "DocTypeId";
            this.DocTypeId.Name = "DocTypeId";
            this.DocTypeId.ReadOnly = true;
            this.DocTypeId.Visible = false;
            // 
            // txtNationality
            // 
            this.txtNationality.Font = new System.Drawing.Font("Tahoma", 12F);
            this.txtNationality.Location = new System.Drawing.Point(110, 60);
            this.txtNationality.Name = "txtNationality";
            this.txtNationality.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtNationality.Size = new System.Drawing.Size(263, 27);
            this.txtNationality.TabIndex = 125;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(33, 60);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 19);
            this.label6.TabIndex = 133;
            this.label6.Text = "اسم الجنسية";
            // 
            // txtNationalityid
            // 
            this.txtNationalityid.BackColor = System.Drawing.Color.Pink;
            this.txtNationalityid.Font = new System.Drawing.Font("Tahoma", 12F);
            this.txtNationalityid.Location = new System.Drawing.Point(339, 172);
            this.txtNationalityid.Name = "txtNationalityid";
            this.txtNationalityid.ReadOnly = true;
            this.txtNationalityid.Size = new System.Drawing.Size(65, 27);
            this.txtNationalityid.TabIndex = 124;
            this.txtNationalityid.Visible = false;
            // 
            // btnReturn
            // 
            this.btnReturn.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.btnReturn.Location = new System.Drawing.Point(65, 3);
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
            this.btnDelete.Location = new System.Drawing.Point(161, 3);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(100, 35);
            this.btnDelete.TabIndex = 130;
            this.btnDelete.Text = "حــذف";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnsave
            // 
            this.btnsave.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.btnsave.Location = new System.Drawing.Point(485, 3);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(90, 35);
            this.btnsave.TabIndex = 127;
            this.btnsave.Text = "حفظ";
            this.btnsave.UseVisualStyleBackColor = true;
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(35, 27);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 19);
            this.label5.TabIndex = 132;
            this.label5.Text = "رقم الجنسية";
            // 
            // txtNationalityid_User
            // 
            this.txtNationalityid_User.BackColor = System.Drawing.Color.White;
            this.txtNationalityid_User.Font = new System.Drawing.Font("Tahoma", 12F);
            this.txtNationalityid_User.Location = new System.Drawing.Point(110, 27);
            this.txtNationalityid_User.Name = "txtNationalityid_User";
            this.txtNationalityid_User.ReadOnly = true;
            this.txtNationalityid_User.Size = new System.Drawing.Size(65, 27);
            this.txtNationalityid_User.TabIndex = 235;
            // 
            // LstDocTypeId
            // 
            this.LstDocTypeId.DisplayMember = "DisplayMember";
            this.LstDocTypeId.Font = new System.Drawing.Font("Arial", 14F);
            this.LstDocTypeId.FormattingEnabled = true;
            this.LstDocTypeId.Location = new System.Drawing.Point(110, 93);
            this.LstDocTypeId.Name = "LstDocTypeId";
            this.LstDocTypeId.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.LstDocTypeId.Size = new System.Drawing.Size(264, 30);
            this.LstDocTypeId.TabIndex = 236;
            this.LstDocTypeId.ValueMember = "ValueMember";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(31, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 19);
            this.label4.TabIndex = 237;
            this.label4.Text = "وثيقة الاثبات";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.btnClear);
            this.flowLayoutPanel1.Controls.Add(this.btnsave);
            this.flowLayoutPanel1.Controls.Add(this.btnClean);
            this.flowLayoutPanel1.Controls.Add(this.btnEdit);
            this.flowLayoutPanel1.Controls.Add(this.btnDelete);
            this.flowLayoutPanel1.Controls.Add(this.btnReturn);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(35, 212);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(688, 44);
            this.flowLayoutPanel1.TabIndex = 238;
            // 
            // frmNationality
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(781, 264);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.LstDocTypeId);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtNationalityid_User);
            this.Controls.Add(this.grdNationalitys);
            this.Controls.Add(this.txtNationality);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtNationalityid);
            this.Controls.Add(this.label5);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmNationality";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.Text = "ترميز الجنسيات";
            this.Load += new System.EventHandler(this.frmNationality_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdNationalitys)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnClean;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.DataGridView grdNationalitys;
        private System.Windows.Forms.TextBox txtNationality;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtNationalityid;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnsave;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtNationalityid_User;
        private System.Windows.Forms.ComboBox LstDocTypeId;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nationalityid;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nationalityid_User;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nationality;
        private System.Windows.Forms.DataGridViewTextBoxColumn DocTypeId;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
    }
}