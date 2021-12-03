using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using PrjMoneyLoans.Reports;

 namespace PrjMoneyLoans
{
     public partial class frmLoans  : Form
    {
        DBLConMoney MoneyLoansDb;
        int EntryId;
        int AccountId;
        bool formload=false;
        int Rowidx = 0;
        int DepositTypeId = 0;
        Decimal SumCash = 0;
        Decimal SumCashRemainder = 0;
        int OptRemainder;
        int RepayWayId;
        int InstalmentCalcId;
        int Period;
        Decimal LoanAmount;
 
        decimal InstalmentAmount;
          DataTable mytb;

        private static frmLoans inst;
        public static frmLoans GetForm
        {
            get
            {
                if (inst == null || inst.IsDisposed)
                    inst = new frmLoans();


                return inst;
            }
        }
        public frmLoans()
        {
            InitializeComponent();
            MoneyLoansDb = new DBLConMoney(); 

            grdLoans.AutoGenerateColumns = false;
         }




        private void btnNew_Click(object sender, EventArgs e)
        {
            UtilityLoan.ClearForm(this);
            UtilityLoan.ClearForm_WithinCtrl(pnlRepway);

            cmbInstalmentCalcId.SelectedIndex = -1;

            txtInstalmentAmount.Text = string.Empty;
            txtPeriod.Text = string.Empty;


            //========================================================================

            DataTable dt = new DataTable();

            dt = MoneyLoansDb.GetLoansMaxNo();

            txtEntryId.Text = dt.Rows[0]["EntryId"].ToString();
            txtEntryId_User.Text = dt.Rows[0]["EntryId_User"].ToString();

            txtEntryDate.Value = DateTime.Now;

            AccountId = (cmbAccountId.SelectedIndex == -1) ? -1 : Convert.ToInt32(cmbAccountId.SelectedValue);

            OptRemainder = (int)ClsSessionLoan.OptRemainder.WithRemainder;

            ClsSessionLoan.LoanAmount = MoneyLoansDb.GetLoans(AccountID: AccountId, OptRemainder: OptRemainder);
             grdLoans.DataSource = ClsSessionLoan.LoanAmount;
        

            if (ClsSessionLoan.LoanAmount.Rows.Count > 0)
            {
                Decimal SumLoanAmount = ClsSessionLoan.LoanAmount.AsEnumerable().Sum(row => row.Field<Decimal>("LoanAmount"));
                txtTotalAmount.Text = SumLoanAmount.ToString();
            }
            else

            {
                txtTotalAmount.Text = string.Empty;
            }

            

            btnsave.Enabled = true;
        }

        private bool CashIsLow(decimal LoanAmount,int DepositTypeId)
        {
            bool result=false;

             mytb = MoneyLoansDb.GetCash(DepositTypeId: DepositTypeId);

            if (mytb.Rows.Count > 0)
            {
                SumCash = mytb.AsEnumerable().Sum(row => row.Field<Decimal>("Cash"));
            }
            else
            {
                SumCash = 0;
            }


            int OptRemainder = (int)ClsSessionLoan.OptRemainder.WithRemainder;
 
            mytb = MoneyLoansDb.GetLoans(OptRemainder: OptRemainder);

            if (mytb.Rows.Count > 0)
            {
                SumCashRemainder = mytb.AsEnumerable().Sum(row => row.Field<Decimal>("Remainder"));
            }
            else
            {
                SumCashRemainder = 0;
            }


            if ((SumCash - SumCashRemainder)< LoanAmount)
            {
                result = true;
            }
            return result;

        }
        private void btnsave_Click(object sender, EventArgs e)
        {
             
            EntryId = string.IsNullOrEmpty(txtEntryId.Text) ? 0 : Convert.ToInt32(txtEntryId.Text);

              AccountId = (cmbAccountId.SelectedIndex == -1) ? 0 : Convert.ToInt32(cmbAccountId.SelectedValue);
            try
            {
                mytb = MoneyLoansDb.GetLoans(-1);

                if (UtilityLoan.ChkDataType(mytb, this))
                {
                    LoanAmount = Convert.ToDecimal(txtLoanAmount.Text);

                    string Notes;
                    Notes = txtNotes.Text.Trim();
                    DateTime EntryDate = Convert.ToDateTime(txtEntryDate.Value);

                    if (Convert.ToInt32(MoneyLoansDb.ChkLoanDate(EntryDate).Rows[0]["Result"].ToString()) == 0 /*False*/)
                    {
                        throw (new OutOfMemoryException());
                    }

                    if (pnlRepway.Visible)
                    {
                        RepayWayId = (cmbRepayWay.SelectedIndex == -1) ? 2 : Convert.ToInt32(cmbRepayWay.SelectedValue);

                        InstalmentCalcId = (cmbInstalmentCalcId.SelectedIndex == -1 || RepayWayId==2) ? 0 : Convert.ToInt32(cmbInstalmentCalcId.SelectedValue);

                        if (InstalmentCalcId == (int)ClsSessionLoan.Repayway.MonthlyAmount)
                        {
                            InstalmentAmount = Convert.ToDecimal(txtInstalmentAmount.Text);
                        }
                        else if (InstalmentCalcId == (int)ClsSessionLoan.Repayway.Period)
                        {
                            Period = Convert.ToInt32(txtPeriod.Text);
                            InstalmentAmount = Math.Round(LoanAmount / Period, 3);
                            txtInstalmentAmount.Text = InstalmentAmount.ToString();
                        }
                        else if (RepayWayId== (int)ClsSessionLoan.OrderInstalment.Random)
                        {
                            InstalmentAmount = 0;
                        }

                        if (InstalmentAmount > LoanAmount)
                        {
                            throw (new ArgumentOutOfRangeException());
                        }
                     }

                    DepositTypeId = (int)ClsSessionLoan.DepositType.Loans;

                    if (AccountId == 0)
                    {
                        ClsSessionLoan.ErrorBlankData();
                    }
                    else
                    {
                       if (CashIsLow(LoanAmount, DepositTypeId))
                        {
                            throw (new IndexOutOfRangeException());
                        }

                        grdLoans.DataSource = ClsSessionLoan.LoanAmount;

                        MoneyLoansDb.SaveLoans(EntryId, AccountId, EntryDate, LoanAmount, Notes, InstalmentAmount, InstalmentCalcId, Period, RepayWayId, DepositTypeId);

                        OptRemainder = (int)ClsSessionLoan.OptRemainder.WithRemainder;
                        ClsSessionLoan.LoanAmount = MoneyLoansDb.GetLoans(AccountID: AccountId, OptRemainder: OptRemainder);

                        if (grdLoans.Rows.Count > 0 && grdLoans.SelectedRows.Count > 0)
                        {
                            Rowidx = grdLoans.CurrentRow.Index;
                        }
                        else if (ClsSessionLoan.LoanAmount.Rows.Count > 0)
                        {
                            Rowidx = Convert.ToInt32(ClsSessionLoan.LoanAmount.Rows[ClsSessionLoan.LoanAmount.Rows.Count - 1]["EntryId_User"]) - 1;
                        }
                        else
                        {
                            Rowidx = 0;
                        }

                        grdLoans.DataSource = ClsSessionLoan.LoanAmount;

                        ClsSessionLoan.rptno = (int)ClsSessionLoan.ReportNo.RptAccounts;
                        ClsSessionLoan.SaveMessages();
                        btnNew_Click(null, null);

                        if (grdLoans.Rows.Count > 0)
                        {
                            grdLoans.Rows[Rowidx].Selected = true;
                            grdLoans.CurrentCell = grdLoans.Rows[Rowidx].Cells["gLoanAmount"];
                        }
                        if (ClsSessionLoan.LoanAmount.Rows.Count > 0)
                        {
                            Decimal SumLoanAmount = ClsSessionLoan.LoanAmount.AsEnumerable().Sum(row => row.Field<Decimal>("LoanAmount"));
                            txtTotalAmount.Text = SumLoanAmount.ToString();
                        }
                        else
                         {
                            txtTotalAmount.Text = string.Empty;
                        }
                    }
                }
            }
            catch (OutOfMemoryException egg)
            {
                txtEntryDate.BackColor = Color.Red;
                ClsSessionLoan.ErrorCashDateMessages();
                txtEntryDate.BackColor = Color.White;
            }
            catch (IndexOutOfRangeException ee)
            {
                string u = ee.Message;

                txtLoanAmount.BackColor = Color.Yellow;

                ClsSessionLoan.ErrorCashMessages();

                txtLoanAmount.BackColor = Color.White;

            }

            catch (ArgumentOutOfRangeException  ee)
            {
                txtInstalmentAmount.BackColor = Color.Yellow;
                txtLoanAmount.BackColor = Color.Yellow;

                string u = ee.Message;
                ClsSessionLoan.ErrorInstalmentMessages();

                txtInstalmentAmount.BackColor = Color.White;
                txtLoanAmount.BackColor = Color.White;
            }

            catch (Exception ee)
            {
                string u = ee.Message;
                ClsSessionLoan.ErrorMessages();
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            EntryId = 0;

            UtilityLoan.ClearForm(this);
            txtTotalAmount.Text = string.Empty;
            
            btnsave.Enabled = false;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

            try
            {
                 var yesno = MessageBox.Show("هل تريد حذف السجل؟", ClsSessionLoan.SystemTitle, MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (yesno == DialogResult.Yes)
                {
                    int EntryId = string.IsNullOrEmpty(txtEntryId.Text) ? 0 : Convert.ToInt32(txtEntryId.Text);

                    MoneyLoansDb.DeleteLoans(EntryId);

                    AccountId = (cmbAccountId.SelectedIndex == -1) ? 0 : Convert.ToInt32(cmbAccountId.SelectedValue);

                    UtilityLoan.ClearForm(this);

                    grdLoans.DataSource = MoneyLoansDb.GetLoans(AccountID: AccountId);
                }
            }
            catch
            {
                ClsSessionLoan.ErrorMessages();
            }

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            //=============================================================

            AccountId = (cmbAccountId.SelectedIndex == -1) ? 0 : Convert.ToInt32(cmbAccountId.SelectedValue);

            if (AccountId > 0)
            {
                int EntryId = string.IsNullOrEmpty(txtEntryId.Text) ? 0 : Convert.ToInt32(txtEntryId.Text);
                Decimal LoanAmount= UtilityLoan.IsNumber(txtLoanAmount.Text) ? Convert.ToDecimal(txtLoanAmount.Text) : 0;
                string Notes = txtNotes.Text.Trim();

                DateTime? EntryDate = UtilityLoan.IsDate(txtEntryDate.Text) ? Convert.ToDateTime(txtEntryDate.Value) : Convert.ToDateTime("1/1/1900");

                //=============================================================

                OptRemainder = (int)ClsSessionLoan.OptRemainder.WithRemainder;

                ClsSessionLoan.LoanAmount = MoneyLoansDb.GetLoans(EntryId, AccountId, EntryDate, LoanAmount, Notes, OptRemainder: OptRemainder);

                grdLoans.DataSource = ClsSessionLoan.LoanAmount;
  
                if (ClsSessionLoan.LoanAmount.Rows.Count > 0)
                {
                    Decimal SumLoanAmount = ClsSessionLoan.LoanAmount.AsEnumerable().Sum(row => row.Field<Decimal>("LoanAmount"));
                    txtTotalAmount.Text = SumLoanAmount.ToString();
                }
                else

                {
                    txtTotalAmount.Text = string.Empty;
                }


                ClsSessionLoan.rptno = (int)ClsSessionLoan.ReportNo.RptAccounts;
            }
            else
            {
                ClsSessionLoan.ErrorBlankData(); 
            }
         }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            ClsSessionLoan.rptno = (int)ClsSessionLoan.ReportNo.RptLoanAmounts;

             OptRemainder = (int)ClsSessionLoan.OptRemainder.WithRemainder;

             ClsSessionLoan.LoanAmount = MoneyLoansDb.GetLoans(AccountID: AccountId, OptRemainder: OptRemainder);
 
            if (ClsSessionLoan.LoanAmount == null || ClsSessionLoan.LoanAmount.Rows.Count <=0)
            {
                MessageBox.Show("ابحث  ثم اطبع ناتج البحث", ClsSessionLoan.SystemTitle , MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
             else
            {
               frmReports PrintStudent = new frmReports();
                PrintStudent.Show();
             }
         }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void lblAccountName_Click(object sender, EventArgs e)
        {

        }

        private void frmLoans_Load(object sender, EventArgs e)
        {

            btnNew_Click(null, null);

            cmbAccountId.DataSource = MoneyLoansDb.GetAccounts();
            cmbAccountId.SelectedIndex = -1;


            int LookUpTableId = (int)ClsSessionLoan.LookupTable.Repayway;
            DataTable DataList = MoneyLoansDb.GetLkupValues(LookUpTableId: LookUpTableId);
            cmbRepayWay.DataSource = DataList;


            LookUpTableId = (int)ClsSessionLoan.LookupTable.InstalmentCalculate;
            DataList = MoneyLoansDb.GetLkupValues(LookUpTableId: LookUpTableId);
            cmbInstalmentCalcId.DataSource = DataList;




            formload = true;
        }

        private void grdAccounts_CellClick(object sender, DataGridViewCellEventArgs e) 
        {
            int EntryId = Convert.ToInt32(grdLoans.CurrentRow.Cells["gEntryId"].Value.ToString());

            OptRemainder = (int)ClsSessionLoan.OptRemainder.WithRemainder;

            DataTable MySrch = MoneyLoansDb.GetLoans(EntryId, OptRemainder: OptRemainder);

            ClsSessionLoan.LoanAmount = MySrch;

            if (MySrch.Rows.Count > 0)
            {
                UtilityLoan.FillForm(this, MySrch);

                DataTable dr = MoneyLoansDb.GetInstalmentCalc_loan(LoanEntryId: EntryId);

                if (dr.Rows.Count > 0)
                {
                    cmbRepayWay.SelectedValue = ((int)ClsSessionLoan.OrderInstalment.Order).ToString();
                    UtilityLoan.FillForm_WithinCtrl(pnlRepway, MySrch);
                    pnlRepway.Enabled = true;
                }
                else
                {
                    cmbRepayWay.SelectedValue = ((int)ClsSessionLoan.OrderInstalment.Random).ToString();
                     UtilityLoan.ClearForm_WithinCtrl(pnlRepway);
                    pnlRepway.Enabled = false;
                }

                txtEntryId_User.Text = grdLoans.CurrentRow.Cells["gEntryId_User"].Value.ToString();
                btnsave.Enabled = true;
            }
        }

        private void txtEntryDate_ValueChanged(object sender, EventArgs e)
        {
            txtEntryDate.Format = DateTimePickerFormat.Custom;
            txtEntryDate.CustomFormat = "yyyy/MM/dd";
        }

        private void cmbAccountId_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (formload)
            {
                AccountId = (cmbAccountId.SelectedIndex == -1) ? 0 : Convert.ToInt32(cmbAccountId.SelectedValue);

                OptRemainder = (int)ClsSessionLoan.OptRemainder.WithRemainder;

                ClsSessionLoan.LoanAmount = MoneyLoansDb.GetLoans(AccountID:AccountId, OptRemainder: OptRemainder);

                grdLoans.DataSource = ClsSessionLoan.LoanAmount;

                DataTable dt = new DataTable();

                dt = MoneyLoansDb.GetLoansMaxNo();

                txtEntryId.Text = dt.Rows[0]["EntryId"].ToString();
                txtEntryId_User.Text = dt.Rows[0]["EntryId_User"].ToString();

                txtEntryDate.Value = DateTime.Now;


                txtLoanAmount.Text = string.Empty; 

                if (ClsSessionLoan.LoanAmount.Rows.Count > 0)
                {
                    Decimal SumLoanAmount = ClsSessionLoan.LoanAmount.AsEnumerable().Sum(row => row.Field<Decimal>("LoanAmount"));
                    txtTotalAmount.Text = SumLoanAmount.ToString();
                }
                else

                {
                    txtTotalAmount.Text = string.Empty;
                }

            }
        }

        private void cmbRepayWay_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (formload)
            {
                  RepayWayId = (cmbRepayWay.SelectedIndex == -1) ? 2 : Convert.ToInt32(cmbRepayWay.SelectedValue);

                if (RepayWayId == (int)ClsSessionLoan.OrderInstalment.Order)
                {
                    pnlRepway.Enabled  = true;
                }
                else
                {
                    pnlRepway.Enabled = false;
                }
            }


        }
 
        private void cmbInstalmentCalcId_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (formload)
            {
                InstalmentCalcId = (cmbInstalmentCalcId.SelectedIndex == -1) ? 2 : Convert.ToInt32(cmbInstalmentCalcId.SelectedValue);

                if (InstalmentCalcId == (int)ClsSessionLoan.Repayway.MonthlyAmount)
                {
                    lblPeriod.Visible = false;
                    txtPeriod.Visible = false;
                }
                else
                {
                    lblPeriod.Visible = true;
                    txtPeriod.Visible = true;
                }
            }
        }
  
        private void txtPeriod_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (UtilityLoan.IsNumber(txtLoanAmount.Text) && UtilityLoan.IsNumber(txtPeriod.Text))
                {
                    LoanAmount = Convert.ToDecimal(txtLoanAmount.Text);


                    Period = (Convert.ToInt32(txtPeriod.Text) == 0) ? 1 : Convert.ToInt32(txtPeriod.Text);

                    InstalmentAmount = Math.Round(LoanAmount / Period, 3);
                    txtInstalmentAmount.Text = InstalmentAmount.ToString();
                }
            }

            catch (DataException eew)
            {
                ClsSessionLoan.ErrorDataType();

            }
        }

        
    }
}
