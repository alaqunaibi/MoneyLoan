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
     public partial class frmInstalment   : Form
    {
        DBLConMoney MoneyLoansDb;
        int InstalmentEntryId;
        bool formload=false;
        int Rowidx = 0;
        int LoanEntryId;
        public int AccountID;
        public string PersonName;
            
        decimal Remainder;
        decimal LastInstallment;
        decimal InstalmentAmount;
        int PaymentWayId;
        int RepayWayId;
        decimal MonthlyInstalment;
        int PaymentEntryId;
        int DepositTypeId; 

        string Notes;
        string ChequeNo;

         DateTime ChequeDate;

         string BankName;
         DateTime ? EntryDate;


        int OptRemainder=0;
        int OptFinanceYearId = 0;


        private static frmInstalment inst;
        public static frmInstalment GetForm
        {
            get
            {
                if (inst == null || inst.IsDisposed)
                    inst = new frmInstalment();
                 return inst;
            }
        }
        public frmInstalment()
        {
            InitializeComponent();
            MoneyLoansDb = new DBLConMoney();
            grdInstalments.AutoGenerateColumns = false;
            grdPayments.AutoGenerateColumns = false;
            grdLoans.AutoGenerateColumns = false;
        }
 

        private void btnNew_Click(object sender, EventArgs e)
        {
            UtilityLoan.ClearForm(this);

            DataTable dt = new DataTable();

            dt = MoneyLoansDb.GetPaymentsMaxNo();

            txtPaymentEntryId.Text = dt.Rows[0]["PaymentEntryId"].ToString();
            txtPaymentEntryId_User.Text = dt.Rows[0]["PaymentEntryId_User"].ToString();

            txtEntryDate.Value = DateTime.Now;

            AccountID  = (cmbAccountId.SelectedIndex == -1) ? -1 : Convert.ToInt32(cmbAccountId.SelectedValue);

            OptRemainder = (int)ClsSessionLoan.OptRemainder.WithRemainder;

            OptFinanceYearId = (int)ClsSessionLoan.OptFinanceYearId.AllFinanceYears ;

            //get all payments  for  Active loan only
            ClsSessionLoan.PaymentAmount = MoneyLoansDb.GetPaymentAmount(AccountID: AccountID, OptRemainder: OptRemainder, OptFinanceYearId: OptFinanceYearId);
            grdPayments.DataSource = ClsSessionLoan.PaymentAmount;

             ClsSessionLoan.Instalments = MoneyLoansDb.GetInstalments(AccountID: AccountID, OptRemainder: OptRemainder, OptFinanceYearId: OptFinanceYearId);
            grdInstalments.DataSource = ClsSessionLoan.Instalments;

            //Get all loans of AccountId
            ClsSessionLoan.LoanAmount = MoneyLoansDb.GetLoans(AccountID: AccountID, OptRemainder: OptRemainder, OptFinanceYearId: OptFinanceYearId);
            grdLoans.DataSource = ClsSessionLoan.LoanAmount;
 
             if (ClsSessionLoan.Instalments.Rows.Count > 0)
            {
                Decimal SumInstalmentAmount = ClsSessionLoan.Instalments.AsEnumerable().Sum(row => row.Field<Decimal>("InstalmentAmount"));
                txtTotalAmount.Text = SumInstalmentAmount.ToString();
            }
            else
            {
                txtTotalAmount.Text = string.Empty;
             }
            //-------------

            if (ClsSessionLoan.LoanAmount.Rows.Count > 0)
            {
                Decimal SumLoanAmount = ClsSessionLoan.LoanAmount.AsEnumerable().Sum(row => row.Field<Decimal>("Remainder"));
                txtDueLoanTotals.Text = SumLoanAmount.ToString();
            }
            else
            {
                txtDueLoanTotals.Text = string.Empty;
             }
            //-------------

            if (ClsSessionLoan.PaymentAmount.Rows.Count > 0)
            {
                Decimal SumPaymentAmount = ClsSessionLoan.PaymentAmount.AsEnumerable().Sum(row => row.Field<Decimal>("PaymentAmount"));
                txtPaymentTotal.Text = SumPaymentAmount.ToString();
            }
            else
            {
                txtPaymentTotal.Text = string.Empty;
            }

            //---------------------------------
            btnsave.Enabled = true;
        }


        private bool PayAmountIsLarge(ref decimal PaymentAmount, int AccountID)
        {
            bool result = false;
            decimal SumRemainderLoan;

            OptRemainder = (int)ClsSessionLoan.OptRemainder.WithRemainder;
            OptFinanceYearId = (int)ClsSessionLoan.OptFinanceYearId.AllFinanceYears;

            DataTable mytb = MoneyLoansDb.GetLoans(AccountID: AccountID, OptRemainder: OptRemainder, OptFinanceYearId: OptFinanceYearId);

            if (mytb.Rows.Count > 0)
            {
                SumRemainderLoan= mytb.AsEnumerable().Sum(row => row.Field<Decimal>("Remainder"));
            }
            else
            {
                SumRemainderLoan = 0;
            }
 
            if (SumRemainderLoan < PaymentAmount)
            {
                result = true;
            }
            return result;
        }

        //==============================================
        private void DiscountInstalment(DataTable dtLoanAmount)
        {
            foreach (DataRow rw in ClsSessionLoan.LoanAmount.Rows)
            {
                Remainder = Convert.ToDecimal(rw["Remainder"]);
                LoanEntryId = Convert.ToInt32(rw["EntryId"]);
                RepayWayId = Convert.ToInt32(rw["RepayWayId"]);

                if (InstalmentAmount > 0)
                {
                    if (RepayWayId == (int)ClsSessionLoan.OrderInstalment.Order)
                    {
                        MonthlyInstalment = Convert.ToDecimal(rw["InstalmentAmount"]);
                        DiscountOrderRepay(LoanEntryId, Remainder, MonthlyInstalment);
                    }
                    else if (RepayWayId == (int)ClsSessionLoan.OrderInstalment.Random)
                    {
                        DiscountRandomRepay(LoanEntryId, Remainder);
                    }

                }
                else
                {
                    break;
                }
            }
        }

        //-------------------------------------------------------------
        private void DiscountRandomRepay(int LoanEntryId, decimal Remainder)
        {
                if (InstalmentAmount > 0)
                {
                    if (InstalmentAmount >= Remainder)
                    {
                        LastInstallment = Remainder;
                        InstalmentAmount = InstalmentAmount - Remainder;
                        Remainder = 0;
                    }
                    else
                    {
                        LastInstallment = InstalmentAmount;
                        Remainder = Remainder - InstalmentAmount;
                        InstalmentAmount = 0;
                    }
                    MoneyLoansDb.SaveInstalments(LoanEntryId: LoanEntryId, AccountID: AccountID, InstalmentAmount: LastInstallment, PaymentEntryId: PaymentEntryId);
                    MoneyLoansDb.SaveLoans_UpdInstalment(LoanEntryId, AccountID, LastInstallment, Remainder, EntryDate, PaymentEntryId: PaymentEntryId);
                }
     }
 //-------------------------------------------------------------
        private void DiscountOrderRepay( int LoanEntryId, decimal Remainder, decimal MonthlyInstalment)
            {
                     while (Remainder > 0 && InstalmentAmount > 0 )
                    {
                       // MonthlyInstalment = Convert.ToDecimal(rw["InstalmentAmount"]);

                        if (InstalmentAmount >= Remainder && InstalmentAmount >= MonthlyInstalment && Remainder>= MonthlyInstalment)
                        {
                            LastInstallment = MonthlyInstalment;
                            InstalmentAmount = InstalmentAmount - MonthlyInstalment;
                            Remainder = Remainder - MonthlyInstalment;
                          }
                    else if (InstalmentAmount >= Remainder && InstalmentAmount >= MonthlyInstalment && Remainder < MonthlyInstalment)
                   {
                       LastInstallment = Remainder;
                      InstalmentAmount = InstalmentAmount - Remainder;
                        Remainder = 0;
                 }

                else if (InstalmentAmount < Remainder && InstalmentAmount >= MonthlyInstalment)
                        {
                            LastInstallment = MonthlyInstalment;
                            Remainder = Remainder - LastInstallment;
                            InstalmentAmount = InstalmentAmount - LastInstallment;
                        }
                        else if (InstalmentAmount >= Remainder && InstalmentAmount < MonthlyInstalment)
                        {
                            LastInstallment = InstalmentAmount;
                            InstalmentAmount = InstalmentAmount - Remainder;
                            Remainder = 0;
                        }
                        else if (InstalmentAmount < Remainder && InstalmentAmount < MonthlyInstalment)
                        {
                            LastInstallment = InstalmentAmount;
                            Remainder = Remainder - LastInstallment;
                            InstalmentAmount = 0;
                        }
                        MoneyLoansDb.SaveInstalments(LoanEntryId: LoanEntryId, AccountID: AccountID, InstalmentAmount: LastInstallment, PaymentEntryId: PaymentEntryId);
                        MoneyLoansDb.SaveLoans_UpdInstalment(LoanEntryId, AccountID, LastInstallment, Remainder, EntryDate, PaymentEntryId: PaymentEntryId);
            }
        }
//-------------------------------------------------------------
        private void btnsave_Click(object sender, EventArgs e)
        {
             DataTable mytb;
            InstalmentEntryId = string.IsNullOrEmpty(txtPaymentEntryId.Text) ? 0 : Convert.ToInt32(txtPaymentEntryId.Text);

            AccountID = (cmbAccountId.SelectedIndex == -1) ? 0 : Convert.ToInt32(cmbAccountId.SelectedValue);
            try
            {
                mytb = MoneyLoansDb.GetPaymentAmount(-1);

                if (UtilityLoan.ChkDataType(mytb, this))
                {

                    DepositTypeId = (int)ClsSessionLoan.DepositType.Loans; //سداد قرض Repayment

                    InstalmentAmount = Convert.ToDecimal(txtPaymentAmount.Text);
                    Notes = txtNotes.Text.Trim();
                    EntryDate = Convert.ToDateTime(txtEntryDate.Value);

                    if (Convert.ToInt32(MoneyLoansDb.ChkInstalmentDate(EntryDate).Rows[0]["Result"].ToString()) == 0 /*False*/)
                    {
                        throw (new OutOfMemoryException());
                    }

                    PaymentWayId = Convert.ToInt32(cmbPaymentWayId.SelectedValue);

                    ChequeNo = txtChequeNo.Text.Trim();

                    ChequeDate = UtilityLoan.IsDate(txtChequeDate.Text) ? Convert.ToDateTime(txtChequeDate.Text) : Convert.ToDateTime("1/1/1900");

                    BankName = txtBankName.Text.Trim();

                    //----------------------------------

                    if (InstalmentEntryId == 0)
                    {
                        ClsSessionLoan.ErrorBlankData();
                    }
                    else
                    {
                        if (PayAmountIsLarge(ref InstalmentAmount, AccountID))
                        {

                            throw (new IndexOutOfRangeException());
                        }

                        OptRemainder = (int)ClsSessionLoan.OptRemainder.WithRemainder;
 
                        OptFinanceYearId = (int)ClsSessionLoan.OptFinanceYearId.AllFinanceYears;

                        //Get all loans of AccountId
                        ClsSessionLoan.LoanAmount = MoneyLoansDb.GetLoans(AccountID: AccountID, OptRemainder: OptRemainder, OptFinanceYearId: OptFinanceYearId);

 
                          PaymentEntryId = 0;

                        //InstalmentAmount   All payment at a time

                        DataTable dtresult = MoneyLoansDb.SavePaymentAmount(PaymentEntryId, AccountID, EntryDate, InstalmentAmount, Notes, PaymentWayId, ChequeNo, ChequeDate, BankName, DepositTypeId);

                        if (dtresult.Rows.Count > 0)
                        {
                            PaymentEntryId = Convert.ToInt32(dtresult.Rows[0]["PaymentEntryId"].ToString());
                        }


                        // Automatic discount instalment from  Payment Amount
                        //---------------------------------------------------
                         DiscountInstalment(ClsSessionLoan.LoanAmount);
                         //---------------------------------------------------
                        //After  discount process  finish
                        if (InstalmentAmount > 0)
                        {
                            pnlBalance.Visible = true;
                            txtBalance.Text = InstalmentAmount.ToString();
                        }
                        else
                        {
                            pnlBalance.Visible = false;
                            txtBalance.Text = string.Empty;
                        }

                        ClsSessionLoan.PaymentAmount = MoneyLoansDb.GetPaymentAmount(AccountID: AccountID, OptRemainder: OptRemainder, OptFinanceYearId: OptFinanceYearId);

                        if (grdPayments.Rows.Count > 0 && grdPayments.SelectedRows.Count > 0)
                        {
                            Rowidx = grdPayments.CurrentRow.Index;
                        }
                        else if (ClsSessionLoan.PaymentAmount.Rows.Count > 0)
                        {
                            Rowidx = Convert.ToInt32(ClsSessionLoan.PaymentAmount.Rows[ClsSessionLoan.PaymentAmount.Rows.Count - 1]["PaymentEntryId_User"]) - 1;
                        }
                        else
                        {
                            Rowidx = 0;
                        }

                        //ClsSessionLoan.rptno = (int)ClsSessionLoan.ReportNo.RptInstalmentEntrys;
                        ClsSessionLoan.SaveMessages();

                        btnNew_Click(null, null);

                        if (grdPayments.Rows.Count > 0)
                        {
                            grdPayments.Rows[Rowidx].Selected = true;
                            grdPayments.CurrentCell = grdPayments.Rows[Rowidx].Cells["gPaymentAmount"];
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
                txtPaymentAmount.BackColor = Color.Yellow;

                string u = ee.Message;
                ClsSessionLoan.PayAmountIsLarge();

                txtPaymentAmount.BackColor = Color.White;

            }
            catch (Exception ee)
            {
                string u = ee.Message;
                ClsSessionLoan.ErrorMessages();
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            InstalmentEntryId = 0;

            UtilityLoan.ClearForm(this);

            txtTotalAmount.Text = string.Empty;
            txtPaymentTotal.Text = string.Empty;
            txtDueLoanTotals.Text = string.Empty;

            btnsave.Enabled = false;
        }

        //private void btnDelete_Click(object sender, EventArgs e)
        //{

        //    try
        //    {
        //         var yesno = MessageBox.Show("هل تريد حذف السجل؟", ClsSessionLoan.SystemTitle, MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

        //        if (yesno == DialogResult.Yes)
        //        {


        //            InstalmentEntryId = string.IsNullOrEmpty(txtInstalmentEntryId.Text) ? 0 : Convert.ToInt32(txtInstalmentEntryId.Text);

        //            MoneyLoansDb.DeleteInstalments(InstalmentEntryId);

        //            UtilityLoan.ClearForm(this);

        //             grdInstalments.DataSource = MoneyLoansDb.GetInstalments(0);
        //        }
        //    }
        //    catch
        //    {
        //        ClsSessionLoan.ErrorMessages();
        //    }

        //}

        private void btnSearch_Click(object sender, EventArgs e)
        {
            //=============================================================

            AccountID = (cmbAccountId.SelectedIndex == -1) ? 0 : Convert.ToInt32(cmbAccountId.SelectedValue);

            if (AccountID > 0)
            {
                InstalmentEntryId = string.IsNullOrEmpty(txtPaymentEntryId.Text) ? 0 : Convert.ToInt32(txtPaymentEntryId.Text);
                
                //This is Payment Amount
                 InstalmentAmount = UtilityLoan.IsNumber(txtPaymentAmount.Text) ? Convert.ToDecimal(txtPaymentAmount.Text) : 0;

                  Notes = txtNotes.Text.Trim();

                  EntryDate = UtilityLoan.IsDate(txtEntryDate.Text) ? Convert.ToDateTime(txtEntryDate.Value) : Convert.ToDateTime("1/1/1900");
 
                  PaymentWayId = Convert.ToInt32(cmbPaymentWayId.SelectedValue);
                 
                  ChequeNo     = txtChequeNo.Text.Trim();

                  ChequeDate     = UtilityLoan.IsDate(txtChequeDate.Text) ? Convert.ToDateTime(txtChequeDate.Text) : Convert.ToDateTime("1/1/1900");

                  BankName     = txtBankName.Text.Trim();
 
                //=============================================================
                     OptRemainder = (int)ClsSessionLoan.OptRemainder.WithRemainder;
                 //=============================================================
                    ClsSessionLoan.PaymentAmount  = MoneyLoansDb.GetPaymentAmount(AccountID: AccountID, EntryDate: EntryDate, PaymentAmount: InstalmentAmount, Notes: Notes, PaymentWayId: PaymentWayId, ChequeNo: ChequeNo, ChequeDate: ChequeDate, BankName: BankName, OptRemainder: OptRemainder);

                    ClsSessionLoan.Instalments = MoneyLoansDb.GetInstalments(AccountID: AccountID, OptRemainder: OptRemainder);
 
                    grdInstalments.DataSource = ClsSessionLoan.Instalments;

                    grdPayments.DataSource = ClsSessionLoan.PaymentAmount;
                 //=============================================================
                 //Get all loans of AccountId
                ClsSessionLoan.LoanAmount = MoneyLoansDb.GetLoans(AccountID: AccountID, OptRemainder: OptRemainder);
 
                if (ClsSessionLoan.Instalments.Rows.Count > 0)
                {
                    Decimal SumInstalmentAmount = ClsSessionLoan.Instalments.AsEnumerable().Sum(row => row.Field<Decimal>("InstalmentAmount"));
                    txtTotalAmount.Text = SumInstalmentAmount.ToString();
                }
                else
                {
                    txtTotalAmount.Text = string.Empty;

                }
                //-------------

                if (ClsSessionLoan.LoanAmount.Rows.Count > 0)
                {
                    Decimal SumLoanAmount = ClsSessionLoan.LoanAmount.AsEnumerable().Sum(row => row.Field<Decimal>("Remainder"));
                    txtDueLoanTotals.Text = SumLoanAmount.ToString();
                }
                else
                {
                    txtDueLoanTotals.Text = string.Empty;

                }
                //-------------

                if (ClsSessionLoan.PaymentAmount.Rows.Count > 0)
                {
                    Decimal SumPaymentAmount = ClsSessionLoan.PaymentAmount.AsEnumerable().Sum(row => row.Field<Decimal>("PaymentAmount"));
                    txtPaymentTotal.Text = SumPaymentAmount.ToString();
                }
                else
                {
                    txtPaymentTotal.Text = string.Empty;
                }

                //--------------------------------- 
                //  ClsSessionLoan.rptno = (int)ClsSessionLoan.ReportNo.RptInstalmentEntrys;
            }
            else
            {
                ClsSessionLoan.ErrorBlankData(); 
            }
         }

        private void btnPrint_Click(object sender, EventArgs e)
        {
        //    ClsSessionLoan.rptno = (int)ClsSessionLoan.ReportNo.RptInstalmentEntrys ;

             

            if (ClsSessionLoan.Instalments == null || ClsSessionLoan.Instalments.Rows.Count <=0)
            {
                MessageBox.Show("ابحث  ثم اطبع ناتج البحث", ClsSessionLoan.SystemTitle , MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            else
            {
               // frmReports PrintStudent = new frmReports();

             //   PrintStudent.Show();

            }


        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void lblInstalmentEntryName_Click(object sender, EventArgs e)
        {

        }

        private void frmInstalment_Load(object sender, EventArgs e)
        {
            cmbAccountId.DataSource = MoneyLoansDb.GetAccounts();
            cmbPaymentWayId.DataSource = MoneyLoansDb.GetPaymentWay();

            cmbAccountId.SelectedIndex = -1;
            cmbPaymentWayId.SelectedIndex = -1;

            btnNew_Click(null, null);
             
            formload = true;
        }

        

        private void txtEntryDate_ValueChanged(object sender, EventArgs e)
        {
            txtEntryDate.Format = DateTimePickerFormat.Custom;
            txtEntryDate.CustomFormat = "yyyy/MM/dd";
        }

        private void grdInstalments_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void cmbAccountId_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (formload)
            {
                AccountID = (cmbAccountId.SelectedIndex == -1) ? 0 : Convert.ToInt32(cmbAccountId.SelectedValue);

                PersonName = cmbAccountId.Text;

                OptRemainder = (int)ClsSessionLoan.OptRemainder.WithRemainder;

                OptFinanceYearId = (int)ClsSessionLoan.OptFinanceYearId.AllFinanceYears;

                ClsSessionLoan.Instalments = MoneyLoansDb.GetInstalments(AccountID: AccountID, OptRemainder: OptRemainder, OptFinanceYearId: OptFinanceYearId);
 
                grdInstalments.DataSource = ClsSessionLoan.Instalments;

                DataTable dt = new DataTable();

                dt = MoneyLoansDb.GetPaymentsMaxNo();
 
                txtPaymentEntryId.Text = dt.Rows[0]["PaymentEntryId"].ToString();
                txtPaymentEntryId_User.Text = dt.Rows[0]["PaymentEntryId_User"].ToString();

                txtEntryDate.Value = DateTime.Now;
 
                txtPaymentAmount.Text = string.Empty;

                OptFinanceYearId = (int)ClsSessionLoan.OptFinanceYearId.AllFinanceYears;

                ClsSessionLoan.PaymentAmount = MoneyLoansDb.GetPaymentAmount(AccountID: AccountID, OptRemainder: OptRemainder, OptFinanceYearId: OptFinanceYearId);

                OptFinanceYearId = (int)ClsSessionLoan.OptFinanceYearId.AllFinanceYears;

                //Get all loans of AccountId
                ClsSessionLoan.LoanAmount = MoneyLoansDb.GetLoans(AccountID: AccountID, OptRemainder: OptRemainder, OptFinanceYearId: OptFinanceYearId);


                if (ClsSessionLoan.Instalments.Rows.Count > 0)
                {
                    Decimal SumInstalmentAmount = ClsSessionLoan.Instalments.AsEnumerable().Sum(row => row.Field<Decimal>("InstalmentAmount"));
                    txtTotalAmount.Text = SumInstalmentAmount.ToString();
                }
                else
                {
                    txtTotalAmount.Text = string.Empty;

                }
                    //-------------

                if (ClsSessionLoan.LoanAmount.Rows.Count > 0)
                {
                    Decimal SumLoanAmount = ClsSessionLoan.LoanAmount.AsEnumerable().Sum(row => row.Field<Decimal>("Remainder"));
                    txtDueLoanTotals.Text = SumLoanAmount.ToString();
                }
                else
                {
                    txtDueLoanTotals.Text = string.Empty;

                }
                    //-------------

                if (ClsSessionLoan.PaymentAmount.Rows.Count > 0)
                { 
                    Decimal SumPaymentAmount = ClsSessionLoan.PaymentAmount.AsEnumerable().Sum(row => row.Field<Decimal>("PaymentAmount"));
                    txtPaymentTotal.Text = SumPaymentAmount.ToString();
                }
                else
                {
                    txtPaymentTotal.Text = string.Empty;
                }

                 //---------------------------------

                grdInstalments.DataSource = ClsSessionLoan.Instalments;

                grdPayments.DataSource = ClsSessionLoan.PaymentAmount;
 
                grdLoans.DataSource = ClsSessionLoan.LoanAmount;

            }
        }
 

        private void txtChequeDate_ValueChanged(object sender, EventArgs e)
        {
            txtChequeDate.Format = DateTimePickerFormat.Custom;
            txtChequeDate.CustomFormat = "yyyy/MM/dd";

        }

        private void mnuPrevPayments_Click(object sender, EventArgs e)
        {
            AccountID = (cmbAccountId.SelectedIndex == -1) ? 0 : Convert.ToInt32(cmbAccountId.SelectedValue);

            frmCurrentLoanPayments.GetForm.Owner = this;

            frmCurrentLoanPayments.GetForm.Tag = ((ToolStripMenuItem)sender).Name;

            frmCurrentLoanPayments.GetForm.Show();

        }

        private void cmbPaymentWayId_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Convert.ToInt32(cmbPaymentWayId.SelectedValue) == 2)
            {
                PnlPaymentWay.Enabled = true;

                txtChequeNo.Enabled = true;
                txtChequeDate.Enabled = true;
                txtBankName.Enabled = true;

                txtChequeDate.Format = DateTimePickerFormat.Short;
                txtChequeDate.Text = txtChequeDate.Value.ToShortDateString();
            }

            else
            {
                PnlPaymentWay.Enabled = false;

                txtChequeNo.Enabled = false;
                txtChequeDate.Enabled = false;
                txtBankName.Enabled = false;


                txtBankName.Text = string.Empty;
                txtChequeNo.Text = string.Empty;

                txtChequeDate.Format = DateTimePickerFormat.Custom;
                txtChequeDate.CustomFormat = " ";
            }
        }

        private void mnuPrevLoans_Click(object sender, EventArgs e)
        {
            AccountID = (cmbAccountId.SelectedIndex == -1) ? 0 : Convert.ToInt32(cmbAccountId.SelectedValue);

            frmPrevLoanPayments.GetForm.Owner = this;

            frmPrevLoanPayments.GetForm.Tag = ((ToolStripMenuItem)sender).Name;

            frmPrevLoanPayments.GetForm.Show();

        }

        private void grdPayments_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (grdPayments.Rows.Count > 0)
            {
                InstalmentEntryId = Convert.ToInt32(grdPayments.CurrentRow.Cells["gPaymentEntryId"].Value.ToString());

                OptRemainder = (int)ClsSessionLoan.OptRemainder.WithRemainder;

                DataTable MySrch = MoneyLoansDb.GetPaymentAmount(InstalmentEntryId, OptRemainder: OptRemainder);

                ClsSessionLoan.Instalments = MySrch;

                if (MySrch.Rows.Count > 0)
                {
                    UtilityLoan.FillForm(this, MySrch);
                    if (PnlPaymentWay.Enabled)
                    {
                        UtilityLoan.FillForm_WithinCtrl(PnlPaymentWay, MySrch);
                    }
                    txtPaymentEntryId_User.Text = grdPayments.CurrentRow.Cells["gPaymentEntryId_User"].Value.ToString();
                    btnsave.Enabled = false;
                }
            }
        }

        private void bnDelete_Click(object sender, EventArgs e)
        {
            AccountID = (cmbAccountId.SelectedIndex == -1) ? 0 : Convert.ToInt32(cmbAccountId.SelectedValue);

            if (AccountID > 0)
            {
                InstalmentEntryId = string.IsNullOrEmpty(txtPaymentEntryId.Text) ? 0 : Convert.ToInt32(txtPaymentEntryId.Text);


                MoneyLoansDb.DeleteInstalments(InstalmentEntryId);


                ClsSessionLoan.Instalments = MoneyLoansDb.GetInstalments(AccountID: AccountID, OptRemainder: OptRemainder);

                grdInstalments.DataSource = ClsSessionLoan.Instalments;

                grdPayments.DataSource = ClsSessionLoan.PaymentAmount;


                ClsSessionLoan.LoanAmount = MoneyLoansDb.GetLoans(AccountID: AccountID, OptRemainder: OptRemainder, OptFinanceYearId: OptFinanceYearId);

                grdLoans.DataSource = ClsSessionLoan.LoanAmount;
            }
        }

        private void mnuRptPrevLoans_Click(object sender, EventArgs e)
        {

        }

        private void MnuRptActiveLoans_Click(object sender, EventArgs e)
        {

        }

        private void MnuRptPrevPayments_Click(object sender, EventArgs e)
        {

        }
        }
}
