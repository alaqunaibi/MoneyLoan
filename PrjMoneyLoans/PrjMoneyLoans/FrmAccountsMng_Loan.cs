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
    public partial class FrmAccountsMng_Loan : Form
    {
   //=============================================

        private static FrmAccountsMng_Loan inst;
        public static FrmAccountsMng_Loan GetForm
        {
            get
            {
                if (inst == null || inst.IsDisposed)
                    inst = new FrmAccountsMng_Loan();
                return inst;
            }
        }
 //=============================================

        int LookUpTableId = 0;
        DataTable DataList;
        int AccountId = 0;
        // int ValueMember = 0;
        // int ItemId;
        // bool ChkValue;

        int Rowidx = 0;

        DBLConMoney MoneyLoansDb;

        //=============================================

        public FrmAccountsMng_Loan()
        {
            MoneyLoansDb = new DBLConMoney();
            InitializeComponent();

            grdSpensors.AutoGenerateColumns = false;
         
         }

        private void FrmAccountsMng_Loan_Load(object sender, EventArgs e)
        {
              LookUpTableId = (int)ClsSessionLoan.LookupTable.AccountStatus;
             DataList = MoneyLoansDb.GetLkupValues(LookUpTableId: LookUpTableId);
             cmbAccountStatusId.DataSource = DataList;
 
            LookUpTableId = (int)ClsSessionLoan.LookupTable.City;
             DataList = MoneyLoansDb.GetLkupValues(LookUpTableId: LookUpTableId);
             cmbCityId.DataSource = DataList;

             btnNew_Click(null, null);

             grdPersons.AutoGenerateColumns = false;


         }

        private void btnNew_Click(object sender, EventArgs e)
        {
            UtilityLoan.ClearForm(this);
            DataTable dt = new DataTable();

            Rowidx = 0;
            dt = MoneyLoansDb.GetAccountsMaxNo();
            txtAccountId.Text = dt.Rows[0]["AccountId"].ToString();

            dt = MoneyLoansDb.GetPersonsMaxNo();
            txtPersonId.Text = dt.Rows[0]["PersonId"].ToString();
 
            txtRegisterDate.Text = DateTime.Now.ToShortDateString();
            txtRegisterDate.Format = DateTimePickerFormat.Custom;
            txtRegisterDate.CustomFormat = "yyyy/MM/dd";
      
            grdSpensors.DataSource = MoneyLoansDb.GetAccounts();
            cmbAccountStatusId.SelectedIndex = 0;

            btnSave.Enabled = true;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
              AccountId = string.IsNullOrEmpty(txtAccountId.Text) ? 0 : Convert.ToInt32(txtAccountId.Text);
            int PersonId = string.IsNullOrEmpty(txtPersonId.Text) ? 0 : Convert.ToInt32(txtPersonId.Text);
            string PersonName =UtilityLoan.CleanStringExceptNumbersEglish(txtPersonName.Text);
    
            try
            {

            if (string.IsNullOrEmpty(txtPersonName.Text) || PersonId == 0)
            {
                throw (new DataException());
            }

                 // To prevent Dublicate or Conflict PersonName & PersonId in AccountTable

                DataTable mytb = MoneyLoansDb.GetAccounts(PersonName: PersonName);
                DataTable mytbAccountId = MoneyLoansDb.GetAccounts(AccountId: AccountId);

                if (mytb.Rows.Count > 0 && mytbAccountId.Rows.Count == 0)
                {
                    throw (new DuplicateNameException());
                }


                int MoneyLoansDbID = 0;

                if (mytb.Rows.Count > 0 && mytbAccountId.Rows.Count > 0)
                {
                    MoneyLoansDbID = Convert.ToInt32(mytb.Rows[0]["AccountId"].ToString());

                    if (MoneyLoansDbID != AccountId)
                    {
                        throw (new DuplicateNameException());
                    }
                }

                //==============================================================
                // To prevent Dublicate or Conflict PersonName & PersonId in AccountTable

                mytb = MoneyLoansDb.GetPersons(PersonName: PersonName);
                DataTable mytbPersonId = MoneyLoansDb.GetPersons(PersonId: PersonId);

                if (mytb.Rows.Count > 0 && mytbPersonId.Rows.Count == 0)
                {
                    throw (new DuplicateNameException());
                }

                   MoneyLoansDbID = 0;

                if (mytb.Rows.Count > 0 && mytbPersonId.Rows.Count > 0)
                {
                    MoneyLoansDbID = Convert.ToInt32(mytb.Rows[0]["PersonId"].ToString());

                    if (MoneyLoansDbID != PersonId)  
                    {
                        throw (new DuplicateNameException());
                    }
                }

                //==========================================================
                mytb = MoneyLoansDb.GetAccounts(-1);

                if (UtilityLoan.ChkDataType(mytb, this))
                {


                    string phone = txtphone.Text.Trim();
                    string Notes = txtNotes.Text.Trim();
                    string OtherPhone =txtOtherPhone.Text.Trim();

                    string District = txtDistrict.Text.Trim();
                    string Address = txtAddress.Text.Trim();
                  
                    int AccountStatusId = (cmbAccountStatusId.SelectedIndex == -1) ? 0 : Convert.ToInt32(cmbAccountStatusId.SelectedValue);

                    int CityId = (cmbCityId.SelectedIndex == -1) ? 0 : Convert.ToInt32(cmbCityId.SelectedValue);

                    DateTime RegisterDate = Convert.ToDateTime(txtRegisterDate.Text);

                    ClsSessionLoan.Accounts = MoneyLoansDb.SaveAccounts(AccountId, PersonId, RegisterDate, AccountStatusId, phone, OtherPhone, CityId, District, Address, Notes);

                    DataTable dt = MoneyLoansDb.SavePersons(PersonId, PersonName, AccountId: AccountId);
                    ClsSessionLoan.Accounts = MoneyLoansDb.GetAccounts();

                    if (grdSpensors.Rows.Count > 0)
                    {
                        Rowidx = grdSpensors.CurrentRow.Index;

                    }
                    else if (ClsSessionLoan.Accounts.Rows.Count > 0)
                    {
                        Rowidx = Convert.ToInt32(ClsSessionLoan.Accounts.Rows[ClsSessionLoan.Accounts.Rows.Count - 1]["AccountId_User"]) - 1;
                    }

                    else
                    {
                        Rowidx = 0;
                    }

                    grdSpensors.DataSource = ClsSessionLoan.Accounts;

                    grdSpensors.Rows[Rowidx].Selected = true;
                    grdSpensors.CurrentCell = grdSpensors.Rows[Rowidx].Cells["gPersonName"];
 
                    ClsSessionLoan.rptno = (int)ClsSessionLoan.ReportNo.RptAccounts;
                    ClsSessionLoan.SaveMessages();
                  }
            }

            catch (DuplicateNameException NameDublicate)
            {
                string s = NameDublicate.Message;

                ClsSessionLoan.ErrorDublicateData();
            }

            catch (DataException NameDublicate)
            {
                string s = NameDublicate.Message;

                ClsSessionLoan.ErrorMessages();
            }

            catch (Exception ee)
            {
                string u = ee.Message;
                ClsSessionLoan.ErrorMessages();


            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            AccountId = 0;
            UtilityLoan.ClearForm(this);
            btnSave.Enabled = false;
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                AccountId = string.IsNullOrEmpty(txtAccountId.Text) ? 0 : Convert.ToInt32(txtAccountId.Text);
                int PersonId = string.IsNullOrEmpty(txtPersonId.Text) ? 0 : Convert.ToInt32(txtPersonId.Text);

                string phone = txtphone.Text.Trim();
                string Notes = txtNotes.Text.Trim();
                string OtherPhone = txtOtherPhone.Text.Trim();

                string PersonName = txtPersonName.Text.Trim();


                int AccountStatusId = (cmbAccountStatusId.SelectedIndex == -1) ? 0 : Convert.ToInt32(cmbAccountStatusId.SelectedValue);

                int CityId = (cmbCityId.SelectedIndex == -1) ? 0 : Convert.ToInt32(cmbCityId.SelectedValue);

                string District = txtDistrict.Text.Trim();
                string Address = txtAddress.Text.Trim();
  
                DateTime RegisterDate = UtilityLoan.IsDate(txtRegisterDate.Text) ? Convert.ToDateTime(txtRegisterDate.Text) : Convert.ToDateTime("1/1/1900");

                ClsSessionLoan.Accounts = MoneyLoansDb.GetAccounts(AccountId, PersonId, RegisterDate, AccountStatusId, phone, OtherPhone, CityId, District, Address, Notes, PersonName);

                ClsSessionLoan.rptno = (int)ClsSessionLoan.ReportNo.RptAccounts;

                grdSpensors.DataSource = ClsSessionLoan.Accounts;

                }
            
            catch (Exception ee)
            {
                string u = ee.Message;
                ClsSessionLoan.ErrorMessages();


            }
        }

        private void txtRegisterDate_ValueChanged(object sender, EventArgs e)
        {
            txtRegisterDate.Format = DateTimePickerFormat.Short;


        }

        private void grdAccounts_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            AccountId = Convert.ToInt32(grdSpensors.CurrentRow.Cells["gSponer_AccountId"].Value.ToString());
 
            DataTable MySrch = MoneyLoansDb.GetAccounts(AccountId);

            ClsSessionLoan.Accounts  = MySrch;

            if (MySrch.Rows.Count > 0)
            {
                UtilityLoan.FillForm(this, MySrch);

                btnSave.Enabled = true;
            }

              MySrch = MoneyLoansDb.GetPersons(AccountId: AccountId);

              grdPersons.DataSource = MySrch;
 
        }

        private void MnuFamilyPersons_Click(object sender, EventArgs e)
        {
            DataTable MySrch = MoneyLoansDb.GetPersons(AccountId: AccountId);

            if (AccountId > 0  && MySrch.Rows.Count > 0 )
            {
                frmPersons.GetForm.Owner = this;

                frmPersons.GetForm.Tag = ((ToolStripMenuItem)sender).Name;

                frmPersons.GetForm.Show();
            }
            else
            {
                ClsSessionLoan.ErrorBlankData();
            }
          }

        private void btnShowHide_Click(object sender, EventArgs e)
        {
            if (ClsSessionLoan.ShowHide < 0)
            {
                ClsSessionLoan.ShowHide *= -1;
                this.Top = 10;
                this.Height = 687;
                btnShowHide.Text = "<<";

            }
            else
            {
                ClsSessionLoan.ShowHide *= -1;

                this.Height = 405; 
                //this.Top = ClsSessionLoan.frmTop;
                 btnShowHide.Text = ">>";

            }
        }

        private void MnuFamilyHouse_Click(object sender, EventArgs e)
        {
         
            ClsSessionLoan.SelectedLookupTable =  (int) ClsSessionLoan.LookupTable.HouseStatus ;
 
          
         }

        private void btnHouseStatusSave_Click(object sender, EventArgs e)
        {
               
               
         }


       

        private void grdHouseStatus_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

            try
            {
                var yesno = MessageBox.Show("هل تريد حذف السجل؟", ClsSessionLoan.SystemTitle, MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (yesno == DialogResult.Yes)
                {
                    AccountId = string.IsNullOrEmpty(txtAccountId.Text) ? 0 : Convert.ToInt32(txtAccountId.Text);

                    MoneyLoansDb.DeleteAccount(AccountId);
 
                    UtilityLoan.ClearForm(this);
                    grdSpensors.DataSource = MoneyLoansDb.GetAccounts();
                }
            }
            catch
            {
                ClsSessionLoan.ErrorMessages();
            }
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            mnuSpensorList_Click(null, null);
        }

        private void MnuFamilyFriends_Click(object sender, EventArgs e)
        {
            
        }

        private void mnuSpensorList_Click(object sender, EventArgs e)
        {
            ClsSessionLoan.rptno = (int)ClsSessionLoan.ReportNo.RptPersons;

            ClsSessionLoan.Persons = MoneyLoansDb.GetAccounts();
 

            if (ClsSessionLoan.Persons == null || ClsSessionLoan.Persons.Rows.Count <= 0)
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
