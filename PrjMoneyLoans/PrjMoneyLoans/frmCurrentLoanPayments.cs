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
    public partial class frmCurrentLoanPayments : Form
    {

        int AccountID;
        int LoanEntryId = 0;
        int PaymentEntryId = 0;

        DBLConMoney MoneyLoansDb;

        private static frmCurrentLoanPayments inst;
        public static frmCurrentLoanPayments GetForm
        {
            get
            {
                if (inst == null || inst.IsDisposed)
                    inst = new frmCurrentLoanPayments();
                return inst;
            }
        }

        //=======================

        public frmCurrentLoanPayments()
        {
            InitializeComponent();

            MoneyLoansDb = new DBLConMoney();

            grdLoans.AutoGenerateColumns = false;
            grdPayments.AutoGenerateColumns = false;
            grdDetailsLoan.AutoGenerateColumns = false;
        }


        public void ShowInfo(int AccountID)
        {
          //Get all Current Loans of AccountId That is  Not Finished yet all its amounts and  Remainder  Greater than   Zero

            ClsSessionLoan.LoanAmount = MoneyLoansDb.GetLoans(AccountID: AccountID, OptRemainder:1);
  
            grdLoans.DataSource = ClsSessionLoan.LoanAmount;
           
             if (ClsSessionLoan.LoanAmount.Rows.Count > 0)
            {

                 grdLoans.Rows[0].Selected = true;
                 grdLoans.CurrentCell = grdLoans.Rows[0].Cells["gLoanAmount"];
                 //-------------
                Decimal SumLoanAmount = ClsSessionLoan.LoanAmount.AsEnumerable().Sum(row => row.Field<Decimal>("LoanAmount"));
                txtPrevLoanTotals.Text = SumLoanAmount.ToString();

                grdLoans_CellClick(null, null);
             }
            else
            {
                 txtPrevLoanTotals.Text = string.Empty;
            }

        }


        private void frmCurrentLoanPayments_Load(object sender, EventArgs e)
        {
            AccountID = ((frmInstalment)this.Owner).AccountID;

            txtPersonName.Text =  ((frmInstalment)this.Owner).PersonName;

            ShowInfo(AccountID);
         }

        private void grdDetailsLoan_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            int CellIndex;
            decimal RemainderValue;

            try
            {
                if (e.ColumnIndex == this.grdDetailsLoan.Columns["gRemainder"].Index)
                {
                     CellIndex = this.grdDetailsLoan.Columns["gRemainder"].Index;
 
                    RemainderValue = Convert.ToDecimal(e.Value.ToString());

                    if (RemainderValue == 0)
                    {
                        this.grdDetailsLoan.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.LightGreen;//   Color.FromArgb(255, 192, 192);
                        this.grdDetailsLoan.Rows[e.RowIndex].DefaultCellStyle.ForeColor = Color.Black;//   Color.FromArgb(255, 192, 192);

                        this.grdDetailsLoan.Columns[CellIndex].DefaultCellStyle.BackColor = Color.LightSeaGreen;
                        this.grdDetailsLoan.Columns[CellIndex].DefaultCellStyle.ForeColor = Color.Green;
                    }
                    else
                    {
                        this.grdDetailsLoan.Rows[e.RowIndex].DefaultCellStyle.ForeColor = Color.Navy;
                        this.grdDetailsLoan.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.White;

                    }

                }
            }
            catch
            {

            }
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
             int OptRemainder = (int)ClsSessionLoan.OptRemainder.WithRemainder;

            DataTable dtResult= new DataTable();
             
                ClsSessionLoan.rptno = (int)ClsSessionLoan.ReportNo.RptDetailsLoanAmount;
                ClsSessionLoan.DetailsLoanAmount = MoneyLoansDb.GetLoanTransactions(AccountID: AccountID,OptRemainder:OptRemainder);
                dtResult = ClsSessionLoan.LoanAmount;

                ClsSessionLoan.Persons = MoneyLoansDb.GetAccounts(AccountId: AccountID);
   
            if (dtResult == null || dtResult.Rows.Count <= 0)
            {
                MessageBox.Show("ابحث  ثم اطبع ناتج البحث", ClsSessionLoan.SystemTitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                frmReports PrintStudent = new frmReports();
                PrintStudent.Show();
            }
        }

        private void btnPrintPayment_Click(object sender, EventArgs e)
        {
           
        }

        private void btnPrintLoan_Click(object sender, EventArgs e)
        {
            int OptRemainder = (int)ClsSessionLoan.OptRemainder.WithRemainder;

            DataTable dtResult = new DataTable();

               ClsSessionLoan.rptno = (int)ClsSessionLoan.ReportNo.RptLoanAmounts;
               ClsSessionLoan.LoanAmount = MoneyLoansDb.GetLoans(AccountID: AccountID, OptRemainder: OptRemainder);
               dtResult = ClsSessionLoan.LoanAmount;

             if (dtResult == null || dtResult.Rows.Count <= 0)
            {
                MessageBox.Show("ابحث  ثم اطبع ناتج البحث", ClsSessionLoan.SystemTitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                frmReports PrintStudent = new frmReports();
                PrintStudent.Show();
            }
        }

        private void grdLoans_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            int OptRemainder = (int)ClsSessionLoan.OptRemainder.WithRemainder;

              LoanEntryId = 0;
            
            LoanEntryId = Convert.ToInt32(grdLoans.CurrentRow.Cells["gEntryId"].Value.ToString());

            ClsSessionLoan.PaymentAmount = MoneyLoansDb.GetPaymentAmount(AccountID: AccountID, LoanEntryId: LoanEntryId, OptRemainder: OptRemainder);
            grdPayments.DataSource = ClsSessionLoan.PaymentAmount;
            
            //-------------

            ClsSessionLoan.DetailsLoanAmount = MoneyLoansDb.GetLoanTransactions(AccountID: AccountID, LoanEntryId: LoanEntryId, OptRemainder: OptRemainder);
            grdDetailsLoan.DataSource = ClsSessionLoan.DetailsLoanAmount;

            //-------------

            if (ClsSessionLoan.DetailsLoanAmount.Rows.Count > 0)
            {
                Decimal SumInstalment = ClsSessionLoan.DetailsLoanAmount.AsEnumerable().Sum(row => row.Field<Decimal>("LastInstallment"));
                txtInstalmentTotals.Text = SumInstalment.ToString();
            }
            else
            {
                txtInstalmentTotals.Text = string.Empty;
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
            //-------------

        }

        private void grdPayments_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int OptRemainder = (int)ClsSessionLoan.OptRemainder.WithRemainder;

            PaymentEntryId = Convert.ToInt32(grdPayments.CurrentRow.Cells["gPaymentEntryId"].Value.ToString());

            ClsSessionLoan.DetailsLoanAmount = MoneyLoansDb.GetLoanTransactions(AccountID: AccountID, LoanEntryId: LoanEntryId, PaymentEntryId: PaymentEntryId, OptRemainder: OptRemainder);
            grdDetailsLoan.DataSource = ClsSessionLoan.DetailsLoanAmount;

            if (ClsSessionLoan.DetailsLoanAmount.Rows.Count > 0)
            {
                Decimal SumInstalment = ClsSessionLoan.DetailsLoanAmount.AsEnumerable().Sum(row => row.Field<Decimal>("LastInstallment"));
                txtInstalmentTotals.Text = SumInstalment.ToString();
            }
            else
            {
                txtInstalmentTotals.Text = string.Empty;
            }

        }
    }
}
