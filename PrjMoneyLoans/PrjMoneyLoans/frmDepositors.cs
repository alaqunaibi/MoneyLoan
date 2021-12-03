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
     public partial class frmDepositors  : Form
    {
        DBLConMoney MoneyLoansDb;
        int DepositorID;

        private static frmDepositors inst;
        public static frmDepositors GetForm
        {
            get
            {
                if (inst == null || inst.IsDisposed)
                    inst = new frmDepositors();
 
                return inst;
            }
        }
        public frmDepositors()
        {
            InitializeComponent();
            MoneyLoansDb = new DBLConMoney();
            grdDepositors.AutoGenerateColumns = false;
         }




        private void btnNew_Click(object sender, EventArgs e)
        {
            UtilityLoan.ClearForm(this);
             
            DataTable dt= new DataTable();
 
            dt = MoneyLoansDb.GetDepositorMaxNo();

            txtDepositorId.Text = dt.Rows[0]["DepositorID"].ToString();
            txtDepositorID_User.Text = dt.Rows[0]["DepositorID_User"].ToString();

            ClsSessionLoan.Depositors = MoneyLoansDb.GetDepositors();
            grdDepositors.DataSource = ClsSessionLoan.Depositors;
            btnsave.Enabled = true;
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
             DepositorID = string.IsNullOrEmpty(txtDepositorId.Text) ? 0 : Convert.ToInt32(txtDepositorId.Text);
             string DepositorName = UtilityLoan.CleanStringExceptNumbersEglish(txtDepositorName.Text); // Remove All Spaces

            try
            {

                if (String.IsNullOrEmpty(DepositorName))
                {
                    throw (new DataException());
                }

                DataTable mytb = MoneyLoansDb.GetDepositors(DepositorName: DepositorName);

                DataTable mytbDepositorID = MoneyLoansDb.GetDepositors(Depositorid: DepositorID);

                if (mytb.Rows.Count > 0 && mytbDepositorID.Rows.Count == 0)
                {
                    throw (new DuplicateNameException());
                }


                int MoneyLoansDbID = 0;

                if (mytb.Rows.Count > 0 && mytbDepositorID.Rows.Count > 0)
                {
                    MoneyLoansDbID = Convert.ToInt32(mytb.Rows[0]["DepositorId"].ToString());

                    if (MoneyLoansDbID != DepositorID)  // Depositor number in database do not equal Depositor number in Form
                    {
                        throw (new DuplicateNameException());
                    }
                }

                //==================
                mytb = MoneyLoansDb.GetDepositors(-1);

                if (UtilityLoan.ChkDataType(mytb, this))
                {

                    string phone = txtPhone.Text.Trim();


                    string Address = txtAddress.Text.Trim();

                    string OtherPhone, Notes;
  
                    OtherPhone = txtOtherPhone.Text.Trim();

                    Notes = txtNotes.Text.Trim();

 
                    if (string.IsNullOrEmpty(DepositorName))
                    {
                        ClsSessionLoan.ErrorMessages();
                    }
                    else
                    {
                       grdDepositors.DataSource = ClsSessionLoan.Depositors;

                        MoneyLoansDb.SaveDepositorsInfo(DepositorID, DepositorName, phone, Address,  OtherPhone, Notes);

                        ClsSessionLoan.Depositors = MoneyLoansDb.GetDepositors(DepositorID, DepositorName, phone, Address, OtherPhone, Notes);

                        grdDepositors.DataSource = ClsSessionLoan.Depositors;

                        ClsSessionLoan.rptno = (int)ClsSessionLoan.ReportNo.RptDepositors;

                        ClsSessionLoan.SaveMessages();

                        btnNew_Click(null, null);
                     }
                }
            }

            catch (DuplicateNameException NameDublicate)
            {
                string s = NameDublicate.Message;

                ClsSessionLoan.ErrorDublicateData();
            }
            
            catch (Exception ee)
            {
                string u = ee.Message;
                ClsSessionLoan.ErrorMessages();
             }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            DepositorID = 0;

            UtilityLoan.ClearForm(this);

            btnsave.Enabled = false;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

            try
            {
                 var yesno = MessageBox.Show("هل تريد حذف السجل؟", ClsSessionLoan.SystemTitle, MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (yesno == DialogResult.Yes)
                {


                    int DepositorId = string.IsNullOrEmpty(txtDepositorId.Text) ? 0 : Convert.ToInt32(txtDepositorId.Text);

                    MoneyLoansDb.DeleteDepositor(DepositorId);

                    UtilityLoan.ClearForm(this);

                     grdDepositors.DataSource = MoneyLoansDb.GetDepositors(0);
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

            int DepositorId = string.IsNullOrEmpty(txtDepositorId.Text) ? 0 : Convert.ToInt32(txtDepositorId.Text);
        
            string phone = txtPhone.Text.Trim();

             string DepositorName = txtDepositorName.Text.Trim();

            string Address = txtAddress.Text.Trim();

             //=============================================================


            string OtherPhone;
 
            OtherPhone = txtOtherPhone.Text.Trim();
             
            string Notes = txtNotes.Text.Trim();
             

            //=============================================================

            grdDepositors.AutoGenerateColumns = false;

            DBLConMoney MoneyLoansDb = new DBLConMoney();


            ClsSessionLoan.Depositors = MoneyLoansDb.GetDepositors(DepositorId, DepositorName, phone, Address, OtherPhone, Notes);

            grdDepositors.DataSource = ClsSessionLoan.Depositors ;

            ClsSessionLoan.rptno = (int)ClsSessionLoan.ReportNo.RptDepositors ;
         }

        private void btnPrint_Click(object sender, EventArgs e)
        {

             // CharityCenters = "نظام إدارة القروض والتقسيط";   //مركز الصدقة


            ClsSessionLoan.rptno = (int)ClsSessionLoan.ReportNo.RptDepositors ;

 
            if (ClsSessionLoan.Depositors == null || ClsSessionLoan.Depositors.Rows.Count <=0)
            {
                MessageBox.Show("ابحث عن مودع ثم اطبع ناتج البحث", ClsSessionLoan.SystemTitle , MessageBoxButtons.OK, MessageBoxIcon.Information);
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


        private void frmDepositors_Load(object sender, EventArgs e)
        {
             btnNew_Click(null, null);
        }

        private void grdDepositors_CellClick(object sender, DataGridViewCellEventArgs e) 
        {
 
            int DepositorID = Convert.ToInt32(grdDepositors.CurrentRow.Cells["gDepositorId"].Value.ToString());


            DataTable MySrch = MoneyLoansDb.GetDepositors(DepositorID);

            ClsSessionLoan.Depositors = MySrch;

            if (MySrch.Rows.Count > 0)
            {
                UtilityLoan.FillForm(this, MySrch);

                txtDepositorID_User.Text = grdDepositors.CurrentRow.Cells["gDepositorId_User"].Value.ToString();
                btnsave.Enabled = true;
            }
        }

        private void MnuRptCashDepositors_Click(object sender, EventArgs e)
        {
            btnPrint_Click(null, null);
        }

       
    }
}
