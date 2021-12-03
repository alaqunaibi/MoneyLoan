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
     public partial class frmCash  : Form
    {
        DBLConMoney MoneyLoansDb;
        int EntryId;
        int DepositorId;
        int DepositTypeId;
        bool formload=false;
        int Rowidx = 0;
        int LookUpTableId;
        DataTable DataList;
        DateTime EntryDate;
        int OptFinanceYearId = 0;
        int CashProcessId;

        decimal DbCash;
        decimal Cash;

        private static frmCash inst;
        public static frmCash GetForm
        {
            get
            {
                if (inst == null || inst.IsDisposed)
                    inst = new frmCash();


                return inst;
            }
        }
        public frmCash()
        {
            InitializeComponent();
            MoneyLoansDb = new DBLConMoney();
            grdCash.AutoGenerateColumns = false;
            grdCashClassify.AutoGenerateColumns = false;

        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            UtilityLoan.ClearForm(this);

            cmbDepositTypeId.SelectedValue = ((int)ClsSessionLoan.DepositType.Loans).ToString();   


            DataTable dt = new DataTable();

            dt = MoneyLoansDb.GetCashMaxNo();

            txtEntryId.Text = dt.Rows[0]["EntryId"].ToString();
            txtEntryId_User.Text = dt.Rows[0]["EntryId_User"].ToString();

            EntryDate = DateTime.Now;
            txtEntryDate.Value = EntryDate;

            DepositorId = (cmbDepositorId.SelectedIndex == -1) ? 0 : Convert.ToInt32(cmbDepositorId.SelectedValue);

            ClsSessionLoan.Cash = MoneyLoansDb.GetCash(DepositorID: DepositorId);
            grdCash.DataSource = ClsSessionLoan.Cash;
 
            ClsSessionLoan.CashClassify = MoneyLoansDb.GetCashDepositType(DepositorID: DepositorId, EntryDate: EntryDate);
            grdCashClassify.DataSource = ClsSessionLoan.CashClassify;  
 
            if (ClsSessionLoan.Cash.Rows.Count > 0)
            {
                Decimal SumCash = ClsSessionLoan.Cash.AsEnumerable().Sum(row => row.Field<Decimal>("Cash"));
                txtTotalAmount.Text = SumCash.ToString();
            }
            else
            {
            txtTotalAmount.Text = string.Empty;
            }
 
            btnsave.Enabled = true;
            btnDelete.Enabled = false;
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            DataTable mytb;

            EntryId = string.IsNullOrEmpty(txtEntryId.Text) ? 0 : Convert.ToInt32(txtEntryId.Text);

            DepositorId = (cmbDepositorId.SelectedIndex == -1) ? 0 : Convert.ToInt32(cmbDepositorId.SelectedValue);
            DepositTypeId = (cmbDepositTypeId.SelectedIndex == -1) ? 0 : Convert.ToInt32(cmbDepositTypeId.SelectedValue);

              Cash = UtilityLoan.IsNumber(txtCash.Text)?Convert.ToDecimal(txtCash.Text):0;

            DataTable dtChkEntryCashAmount = MoneyLoansDb.GetCash(EntryId: EntryId, DepositTypeId: DepositTypeId);
                
            try
            {
                mytb = MoneyLoansDb.GetCash(-1);

                if (UtilityLoan.ChkDataType(mytb, this) && Cash > 0)
                {
                    string Notes;
                    Notes = txtNotes.Text.Trim();

                    EntryDate = Convert.ToDateTime(txtEntryDate.Value);



                    if ( Convert.ToInt32(MoneyLoansDb.ChkCashDate(EntryDate).Rows[0]["Result"].ToString())== 0 /*False*/)
                    {
                        throw (new OutOfMemoryException());
                    }

                     if (DepositorId == 0)
                    {
                        ClsSessionLoan.ErrorBlankData();
                    }
                    else
                    {
                        grdCash.DataSource = ClsSessionLoan.Cash;

                        if (dtChkEntryCashAmount.Rows.Count > 0)
                        {
                            DbCash = Convert.ToDecimal(dtChkEntryCashAmount.Rows[0]["Cash"]);

                            if (DbCash == Cash)
                            {
                                throw (new ArgumentOutOfRangeException());
                            }


                            DataTable dtResult = MoneyLoansDb.ChkUpdateCashAmount(EntryId, DepositorId, EntryDate, Cash, DepositTypeId, Notes);

                            if (Convert.ToInt32(dtResult.Rows[0]["Result"]) == 0 /*False*/ )
                            {
                                throw (new IndexOutOfRangeException());
                            }
                            else
                            {
                                CashProcessId = (int)ClsSessionLoan.CashProcess.CashModify;

                                MoneyLoansDb.SaveCashLogger(EntryId, DepositorId, EntryDate, Cash, DepositTypeId, CashProcessId);
                            }
                        }
                        else
                        {
                            MoneyLoansDb.SaveCash(EntryId, DepositorId, EntryDate, Cash, Notes, DepositTypeId);

                                CashProcessId = (int)ClsSessionLoan.CashProcess.Deposit;

                                MoneyLoansDb.SaveCashLogger(EntryId, DepositorId, EntryDate, Cash, DepositTypeId, CashProcessId);
                        }

                        ClsSessionLoan.Cash = MoneyLoansDb.GetCash(DepositorID: DepositorId);

                        if (grdCash.Rows.Count > 0 && grdCash.SelectedRows.Count > 0)
                        {
                            Rowidx = grdCash.CurrentRow.Index;
                        }
                        else if (ClsSessionLoan.Cash.Rows.Count > 0)
                        {
                            Rowidx = Convert.ToInt32(ClsSessionLoan.Cash.Rows[ClsSessionLoan.Cash.Rows.Count - 1]["EntryId_User"]) - 1;
                        }
                        else
                        {
                            Rowidx = 0;
                        }

                        grdCash.DataSource = ClsSessionLoan.Cash;
                        grdCashClassify.DataSource = MoneyLoansDb.GetCashDepositType();

                        ClsSessionLoan.rptno = (int)ClsSessionLoan.ReportNo.RptDepositors;
                        ClsSessionLoan.SaveMessages();

                        btnNew_Click(null, null);

                        grdCash.Rows[Rowidx].Selected = true;
                        grdCash.CurrentCell = grdCash.Rows[Rowidx].Cells["gCash"];

                        ClsSessionLoan.CashClassify = MoneyLoansDb.GetCashDepositType(DepositorID: DepositorId);
                        grdCashClassify.DataSource = ClsSessionLoan.CashClassify;

                        if (ClsSessionLoan.Cash.Rows.Count > 0)
                        {
                            Decimal SumCash = ClsSessionLoan.Cash.AsEnumerable().Sum(row => row.Field<Decimal>("Cash"));
                            txtTotalAmount.Text = SumCash.ToString();

                            SumCash = ClsSessionLoan.CashClassify.AsEnumerable().Sum(row => row.Field<Decimal>("Cash"));
                            txtCashClassify.Text = SumCash.ToString();
                        }
                        else

                        {
                            txtTotalAmount.Text = string.Empty;

                            txtCashClassify.Text = string.Empty;
                        }
                    }
                }
                else
                {
                    txtCash.BackColor = Color.Red;

                    ClsSessionLoan.ErrorDataMessage();

                    txtCash.BackColor = Color.White;
                }
            }

            catch (OutOfMemoryException  egg)
            {
                txtEntryDate.BackColor = Color.Red;
                    ClsSessionLoan.ErrorCashDateMessages();
                txtEntryDate.BackColor = Color.White;
            }

            catch (IndexOutOfRangeException err)
            {
                txtCash.BackColor = Color.Red;
                    ClsSessionLoan.ErrorModifyCashMessages();
                txtCash.BackColor = Color.White;
            }

            catch (ArgumentOutOfRangeException pp)
            {
                txtCash.BackColor = Color.Yellow;
                txtCash.ForeColor = Color.Red;

                ClsSessionLoan.ErrorCashAmountDidnotChangeMessages();

                txtCash.BackColor = Color.White;
                txtCash.ForeColor = Color.Black;
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
                 var yesno = MessageBox.Show("هل تريد حذف السجل؟", ClsSessionLoan.SystemTitle, MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (yesno == DialogResult.Yes)
                {
                   EntryId = string.IsNullOrEmpty(txtEntryId.Text) ? 0 : Convert.ToInt32(txtEntryId.Text);

                    DataTable dtNetCash = MoneyLoansDb.GetNetCashBalance(DepositTypeId);

                    decimal NetCash = Convert.ToDecimal(dtNetCash.Rows[0]["NetCash"]);
                    decimal CashAmount = Convert.ToDecimal(grdCash.CurrentRow.Cells["gCash"].Value.ToString());


                    if (NetCash >= CashAmount)
                    {

                        int CashProcessId = (int)ClsSessionLoan.CashProcess.CashWithDraw;

                        EntryDate = DateTime.Now;
                        Decimal Cash = Convert.ToDecimal(txtCash.Text);

                        MoneyLoansDb.DeleteCash(EntryId);
                        MoneyLoansDb.SaveCashLogger(EntryId,  DepositorId, EntryDate, Cash, DepositTypeId, CashProcessId);
                        MoneyLoansDb.SaveCashTransAction_loan(EntryId, DepositorId, EntryDate, Cash, DepositTypeId, CashProcessId);

                        UtilityLoan.ClearForm(this);

                        DepositorId = (cmbDepositorId.SelectedIndex == -1) ? 0 : Convert.ToInt32(cmbDepositorId.SelectedValue);

                        grdCash.DataSource = MoneyLoansDb.GetCash(DepositorID: DepositorId);

                        ClsSessionLoan.CashClassify = MoneyLoansDb.GetCashDepositType(DepositorID: DepositorId);
                        grdCashClassify.DataSource = ClsSessionLoan.CashClassify;



                    }
                    else
                    {
                        ClsSessionLoan.ErrorDeleteCashMessages(); 
                    }

                }
            }
            catch
            {
                ClsSessionLoan.ErrorMessages();
            }

        }

 

        private void btnPrint_Click(object sender, EventArgs e)
        {
            ClsSessionLoan.rptno = (int)ClsSessionLoan.ReportNo.RptCashDespositor;

            ClsSessionLoan.CashClassify = MoneyLoansDb.GetCashDepositType(DepositorID: DepositorId, EntryDate: EntryDate);

            if (ClsSessionLoan.CashClassify == null || ClsSessionLoan.CashClassify.Rows.Count <= 0)
            {
                MessageBox.Show("التقرير لا يحتوي على شيء", ClsSessionLoan.SystemTitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
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


        private void lblDepositorName_Click(object sender, EventArgs e)
        {

        }

        private void frmCash_Load(object sender, EventArgs e)
        {
            try
            {
                DataList = MoneyLoansDb.GetDepositors();

                if (DataList.Rows.Count > 0)
                {
                    LookUpTableId = (int)ClsSessionLoan.LookupTable.DepositType;
                    DataList = MoneyLoansDb.GetLkupValues(LookUpTableId: LookUpTableId);
                    cmbDepositTypeId.DataSource = DataList;

                    cmbDepositorId.DataSource = MoneyLoansDb.GetDepositors();

                    btnNew_Click(null, null);

                    formload = true;
                }
                else
                {
                    throw (new IndexOutOfRangeException());
                }
            }

            catch (IndexOutOfRangeException ee)
            {
                ClsSessionLoan.FillDepositorsName();
            }

            catch (Exception)
            {
                ClsSessionLoan.ErrorMessages();
            }
        }

        private void grdCash_CellClick(object sender, DataGridViewCellEventArgs e) 
        {
            int EntryId = Convert.ToInt32(grdCash.CurrentRow.Cells["gEntryId"].Value.ToString());
 
            DataTable MySrch = MoneyLoansDb.GetCash(EntryId);

            ClsSessionLoan.Cash = MySrch;

            if (MySrch.Rows.Count > 0)
            {
                UtilityLoan.FillForm(this, MySrch);

                txtEntryId_User.Text = grdCash.CurrentRow.Cells["gEntryId_User"].Value.ToString();
                btnsave.Enabled = true;
                btnDelete.Enabled = true;
            }
        }

        private void txtEntryDate_ValueChanged(object sender, EventArgs e)
        {
            txtEntryDate.Format = DateTimePickerFormat.Custom;
            txtEntryDate.CustomFormat = "yyyy/MM/dd";
        }

        private void cmbDepositorId_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (formload)
            {
                DepositorId = (cmbDepositorId.SelectedIndex == -1) ? 0 : Convert.ToInt32(cmbDepositorId.SelectedValue);
 
                DataTable dt = MoneyLoansDb.GetCashMaxNo();

                txtEntryId.Text = dt.Rows[0]["EntryId"].ToString();
                txtEntryId_User.Text = dt.Rows[0]["EntryId_User"].ToString();
                txtCash.Text = string.Empty;



                DateTime EntryDate = DateTime.Now;
                txtEntryDate.Value = EntryDate;

                OptFinanceYearId = (int)ClsSessionLoan.OptFinanceYearId.AllFinanceYears;

                ClsSessionLoan.Cash = MoneyLoansDb.GetCash(DepositorID:DepositorId, EntryDate: EntryDate, OptFinanceYearId: OptFinanceYearId);
                grdCash.DataSource = ClsSessionLoan.Cash;

                ClsSessionLoan.CashClassify = MoneyLoansDb.GetCashDepositType(DepositorID: DepositorId, EntryDate: EntryDate);
                grdCashClassify.DataSource = ClsSessionLoan.CashClassify;
 
                if (ClsSessionLoan.Cash.Rows.Count > 0)
                {
                    Decimal SumCash = ClsSessionLoan.Cash.AsEnumerable().Sum(row => row.Field<Decimal>("Cash"));
                    txtTotalAmount.Text = SumCash.ToString();

                    SumCash = ClsSessionLoan.CashClassify.AsEnumerable().Sum(row => row.Field<Decimal>("Cash"));
                    txtCashClassify.Text = SumCash.ToString();
                 }
                else
                 {
                     txtTotalAmount.Text = string.Empty;
                     txtCashClassify.Text = string.Empty;
                }

            }
        }

        private void mnuRptCashBalance_Click(object sender, EventArgs e)
        {
            ClsSessionLoan.rptno = (int)ClsSessionLoan.ReportNo.RptCashBalance;

           
            ClsSessionLoan.Cash = MoneyLoansDb.GetCashBalance();

            if (ClsSessionLoan.Cash == null || ClsSessionLoan.Cash.Rows.Count <= 0)
            {
                MessageBox.Show("التقرير لا يحتوي على شيء", ClsSessionLoan.SystemTitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            else
            {
                frmReports PrintStudent = new frmReports();

                PrintStudent.Show();
             }

        }

        private void MnuRptCashDepositors_Click(object sender, EventArgs e)
        {
            ClsSessionLoan.rptno = (int)ClsSessionLoan.ReportNo.RptCashDespositor;

            ClsSessionLoan.CashClassify = MoneyLoansDb.GetCashDepositType();

            if (ClsSessionLoan.CashClassify == null || ClsSessionLoan.CashClassify.Rows.Count <= 0)
            {
                MessageBox.Show("التقرير لا يحتوي على شيء", ClsSessionLoan.SystemTitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            else
            {
                frmReports PrintStudent = new frmReports();

                PrintStudent.Show();

            }

        }
    }
}
