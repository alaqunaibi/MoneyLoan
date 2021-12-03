using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PrjMoneyLoans
{
    public partial class frmLOOKUPSValues : Form
    {  
       
        DBLConMoney MoneyLoansDb;
        int LookUpTableId;

        DataTable LkUpTableName = new DataTable();


        private static frmLOOKUPSValues inst;
        public static frmLOOKUPSValues GetForm
        {
            get
            {
                if (inst == null || inst.IsDisposed)
                    inst = new frmLOOKUPSValues();
                return inst;
            }
        }


     
        public frmLOOKUPSValues()
        {
    
            InitializeComponent();
            MoneyLoansDb = new DBLConMoney();
            grdDisplayMembers.AutoGenerateColumns = false;

            cmbLKUPTables.DataSource = MoneyLoansDb.GetLkupTableNames(ClsSessionLoan.SelectedLookupTable);
            LookUpTableId = cmbLKUPTables.SelectedIndex == -1 ? 0 : Convert.ToInt32(cmbLKUPTables.SelectedValue);
            LkUpTableName = MoneyLoansDb.GetLkupTableNames(LookUpTableId);

            this.ValueMember.HeaderText = LkUpTableName.Rows[0]["ValueMember"].ToString();
            this.DisplayMember.HeaderText = LkUpTableName.Rows[0]["DisplayMember"].ToString();


            lblValueMember.Text = LkUpTableName.Rows[0]["ValueMember"].ToString();
            lblDisplayMember.Text = LkUpTableName.Rows[0]["DisplayMember"].ToString();

            DataTable result = MoneyLoansDb.GetLkupValues(0, null, LookUpTableId);

            grdDisplayMembers.DataSource = result;
         }

      
        private void btnsave_Click(object sender, EventArgs e)
        {     


            DataTable mytb = MoneyLoansDb.GetLkupValues(-1);

            try
            {

                if (UtilityLoan.ChkDataType(mytb, this))
                {
                    int ValueMember = string.IsNullOrEmpty(txtValueMember.Text) ? 0 : Convert.ToInt32(txtValueMember.Text);
                    string DisplayMember = txtDisplayMember.Text.Trim();

                    DataTable result = MoneyLoansDb.SaveLkupValues(ValueMember, DisplayMember, LookUpTableId);

                    grdDisplayMembers.DataSource = result;

                    ClsSessionLoan.SaveMessages();

                    btnNew_Click(null, null);
                }
            }

            catch (Exception ee)
            {
                string u = ee.Message;
                ClsSessionLoan.ErrorMessages();

            }

        }

       

      

        private void btnDelete_Click(object sender, EventArgs e)
        {

            try
            {
                string strInfo = "جمعية المحافظة على القرآن الكريم - إدارة الحلقات";

                var yesno = MessageBox.Show("هل تريد حذف السجل؟", strInfo, MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (yesno == DialogResult.Yes)
                {
                      MoneyLoansDb = new DBLConMoney();

                    int ValueMember = UtilityLoan.IsNumber(txtValueMember.Text) ? Convert.ToInt32(txtValueMember.Text) : -1;

                    MoneyLoansDb.DeleteLkupValues(ValueMember, LookUpTableId);

                    UtilityLoan.ClearForm(this);

                    btnSearch_Click(null, null);

                   // grdDisplayMembers.DataSource = MoneyLoansDb.GetLkupValues();
                }
            }
            catch
            {
                ClsSessionLoan.ErrorMessages();
            }

        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       
        private void grdDisplayMembers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtValueMember.Text = grdDisplayMembers.CurrentRow.Cells["ValueMember"].Value.ToString();


            txtDisplayMember.Text = grdDisplayMembers.CurrentRow.Cells["DisplayMember"].Value.ToString(); 
        }

      

        private void cmbLKUPTables_SelectedIndexChanged(object sender, EventArgs e)
        {
             LookUpTableId = cmbLKUPTables.SelectedIndex == -1 ? 0 : Convert.ToInt32(cmbLKUPTables.SelectedValue);
           
             btnNew_Click(null, null);
            
             LkUpTableName = MoneyLoansDb.GetLkupTableNames(LookUpTableId);

             this.ValueMember.HeaderText = LkUpTableName.Rows[0]["ValueMember"].ToString();
             this.DisplayMember.HeaderText = LkUpTableName.Rows[0]["DisplayMember"].ToString();

             DataTable result = MoneyLoansDb.GetLkupValues(0, null, LookUpTableId);

             grdDisplayMembers.DataSource = result;
  
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            UtilityLoan.ClearForm(this);

            DataTable dt = new DataTable();

            dt = MoneyLoansDb.GetLkupValuesMaxNo(LookUpTableId);

            txtValueMember.Text = dt.Rows[0]["ValueMember"].ToString();

            grdDisplayMembers.DataSource = MoneyLoansDb.GetLkupValues(0,null,LookUpTableId);
      
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            UtilityLoan.ClearForm(this);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {


                int ValueMember = UtilityLoan.IsNumber(txtValueMember.Text.Trim()) ? Convert.ToInt32(txtValueMember.Text) : 0;

                string DisplayMember = txtDisplayMember.Text.Trim();

                DataTable result = MoneyLoansDb.GetLkupValues(ValueMember, DisplayMember, LookUpTableId);

                grdDisplayMembers.DataSource = result;

            }

            catch (Exception eee)
            {

                string t = eee.Message;

                ClsSessionLoan.ErrorMessages();

            }
        }

        private void frmLOOKUPS_Load(object sender, EventArgs e)
        {
            if (ClsSessionLoan.SelectedLookupTable == 0)
                panel1.Visible = true;
             else
                panel1.Visible = false;
            
            cmbLKUPTables.SelectedValue = ClsSessionLoan.SelectedLookupTable;
         }

         
    }
}
