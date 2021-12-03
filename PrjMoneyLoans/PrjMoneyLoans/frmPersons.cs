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
    public partial class frmPersons : Form
    {
        DBLConMoney MoneyLoansDb;

        int AAccountId;
        int LookUpTableId;

        DataTable DataList;

      //=============================================

        private static frmPersons inst;
        public static frmPersons GetForm
        {
            get
            {
                if (inst == null || inst.IsDisposed)
                    inst = new frmPersons();
                return inst;
            }
        }
        //=============================================
     
        public frmPersons()
        {
            InitializeComponent();

            MoneyLoansDb = new DBLConMoney();

            grdPersons.AutoGenerateColumns = false;
 

            LookUpTableId = (int)ClsSessionLoan.LookupTable.Gender;
            DataList = MoneyLoansDb.GetLkupValues(LookUpTableId: LookUpTableId);
            cmbGenderId.DataSource = DataList;
//----------------------
             DataList = MoneyLoansDb.GetNationality();
            cmbNationalityId.DataSource = DataList;
//----------------------
             LookUpTableId = (int)ClsSessionLoan.LookupTable.MaritalStatus ;
            DataList = MoneyLoansDb.GetLkupValues(LookUpTableId: LookUpTableId);
            cmbMaritalStatusId.DataSource = DataList;
//----------------------
            LookUpTableId = (int)ClsSessionLoan.LookupTable.Qualifications;
            DataList = MoneyLoansDb.GetLkupValues(LookUpTableId: LookUpTableId);
            cmbQualificationID.DataSource = DataList;
//----------------------
            LookUpTableId = (int)ClsSessionLoan.LookupTable.StudyStage;
            DataList = MoneyLoansDb.GetLkupValues(LookUpTableId: LookUpTableId);
            cmbStudyStageId.DataSource = DataList;
//----------------------
             LookUpTableId = (int)ClsSessionLoan.LookupTable.HealthStatus;
            DataList = MoneyLoansDb.GetLkupValues(LookUpTableId: LookUpTableId);
            cmbHealthStatusId.DataSource = DataList;
//----------------------
            LookUpTableId = (int)ClsSessionLoan.LookupTable.PersonStatus;
            DataList = MoneyLoansDb.GetLkupValues(LookUpTableId: LookUpTableId);
            cmbPersonStatusId.DataSource = DataList;
//----------------------
            UtilityLoan.ClearForm(this);
         }

        private void btnSave_Click(object sender, EventArgs e)
        {
            int PersonId = string.IsNullOrEmpty(txtPersonId.Text) ? 0 : Convert.ToInt32(txtPersonId.Text);
            
            string PersonName = UtilityLoan.CleanString(txtPersonName.Text);
            try
            {
                if (string.IsNullOrEmpty(txtPersonName.Text) || PersonId == 0)
                {
                    txtPersonName.BackColor = Color.Red;

                    throw (new DataException());
                }
           
                 // To prevent Dublicate or Conflict PersonName & PersonId in AccountTable

                DataTable mytb = MoneyLoansDb.GetAccounts(PersonName: PersonName);
                DataTable mytbAccountId = MoneyLoansDb.GetAccounts(AccountId: AAccountId);
                  
                if (mytb.Rows.Count > 0 && mytbAccountId.Rows.Count == 0)
                {
                    throw (new DuplicateNameException());
                }


                int MoneyLoansDbID = 0;

                if (mytb.Rows.Count > 0 && mytbAccountId.Rows.Count > 0)
                {
                    MoneyLoansDbID = Convert.ToInt32(mytb.Rows[0]["AccountId"].ToString());

                    if (MoneyLoansDbID != AAccountId)  // Benefactor number in database do not equal Benefactor number in Form
                    {
                        
                        throw (new DuplicateNameException());
                    }
                }

                //==============================================================
                // To prevent Dublicate or Conflict PersonName & PersonId in AccountTable

                mytb = MoneyLoansDb.GetPersons(PersonName: PersonName, AccountId: AAccountId);
                DataTable mytbPersonId = MoneyLoansDb.GetPersons(PersonId: PersonId, AccountId: AAccountId);

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
               
                 mytb = MoneyLoansDb.GetPersons(-1);

                if (UtilityLoan.ChkDataType(mytb, this))
                {   
 
                    DateTime BithDate = Convert.ToDateTime(txtBithDate.Text);
                    
                    string PlaceOfBirth =txtPlaceOfBirth.Text.Trim();
                    
                    string DocId = txtDocId.Text.Trim();

                    int GenderId = (cmbGenderId.SelectedIndex == -1) ? 0 : Convert.ToInt32(cmbGenderId.SelectedValue);
                    
                    string Job= txtJob.Text ;

                    int NationalityId = (cmbNationalityId.SelectedIndex == -1) ? 0 : Convert.ToInt32(cmbNationalityId.SelectedValue);
                    
                    int MaritalStatusId = (cmbMaritalStatusId.SelectedIndex == -1) ? 0 : Convert.ToInt32(cmbMaritalStatusId.SelectedValue);
                    
                    int QualificationID = (cmbQualificationID.SelectedIndex == -1) ? 0 : Convert.ToInt32(cmbQualificationID.SelectedValue);
                      
                    int HealthStatusId = (cmbHealthStatusId.SelectedIndex == -1) ? 0 : Convert.ToInt32(cmbHealthStatusId.SelectedValue);
                    
                    int StudyStageId = (cmbStudyStageId.SelectedIndex == -1) ? 0 : Convert.ToInt32(cmbStudyStageId.SelectedValue);

                    int PersonStatusId = (cmbPersonStatusId.SelectedIndex == -1) ? 0 : Convert.ToInt32(cmbPersonStatusId.SelectedValue);

                    string Notes = txtNotes.Text.Trim();
                        
                    DataTable dt = MoneyLoansDb.SavePersons(PersonId, PersonName, BithDate, PlaceOfBirth, DocId, GenderId, Job, NationalityId,  MaritalStatusId, QualificationID,   HealthStatusId, StudyStageId, AAccountId, PersonStatusId,Notes);
                     
                //=============================
                    ClsSessionLoan.Persons = MoneyLoansDb.GetPersons(AccountId: AAccountId);

                    grdPersons.DataSource = ClsSessionLoan.Persons;
 
                    //ClsSessionLoan.rptno = (int)ClsSessionLoan.ReportNo.;

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

                ClsSessionLoan.ErrorBlankData();

                txtPersonName.BackColor = Color.White ;

            }
            catch (Exception ee)
            {
                string u = ee.Message;
                ClsSessionLoan.ErrorMessages();
            }
        }

        private void lblPersonId_Click(object sender, EventArgs e)
        {

        }

        private void txtPersonId_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnNew_Click(object sender, EventArgs e)
        {
             
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            UtilityLoan.ClearForm(this);
            txtPersonName.ReadOnly = false;
            btnSave.Enabled = false;
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try{
                   string PersonName = UtilityLoan.CleanString(txtPersonName.Text);

                   int PersonId = string.IsNullOrEmpty(txtPersonId.Text) ? 0 : Convert.ToInt32(txtPersonId.Text);

                   DateTime BithDate = UtilityLoan.IsDate(txtBithDate.Text) ? Convert.ToDateTime(txtBithDate.Text): Convert.ToDateTime("1/1/1900");

                    string PlaceOfBirth = txtPlaceOfBirth.Text.Trim();

                    string DocId = txtDocId.Text.Trim();

                    int GenderId = (cmbGenderId.SelectedIndex == -1) ? 0 : Convert.ToInt32(cmbGenderId.SelectedValue);

                    string Job = txtJob.Text;

                    int NationalityId = (cmbNationalityId.SelectedIndex == -1) ? 0 : Convert.ToInt32(cmbNationalityId.SelectedValue); ; ;

 
                    int MaritalStatusId = (cmbMaritalStatusId.SelectedIndex == -1) ? 0 : Convert.ToInt32(cmbMaritalStatusId.SelectedValue);

                    int QualificationID = (cmbQualificationID.SelectedIndex == -1) ? 0 : Convert.ToInt32(cmbQualificationID.SelectedValue);
  
                    int HealthStatusId = (cmbHealthStatusId.SelectedIndex == -1) ? 0 : Convert.ToInt32(cmbHealthStatusId.SelectedValue);

                    int StudyStageId = (cmbStudyStageId.SelectedIndex == -1) ? 0 : Convert.ToInt32(cmbStudyStageId.SelectedValue);

                    int PersonStatusId = (cmbPersonStatusId.SelectedIndex == -1) ? 0 : Convert.ToInt32(cmbPersonStatusId.SelectedValue);


                    string Notes = txtNotes.Text;

                    ClsSessionLoan.Persons = MoneyLoansDb.GetPersons(PersonId, PersonName, BithDate, PlaceOfBirth, DocId, GenderId, Job, NationalityId,  MaritalStatusId, QualificationID,  HealthStatusId, StudyStageId, AAccountId, PersonStatusId, Notes);

                    if (ClsSessionLoan.Persons.Rows.Count > 0)
                    {
                        grdPersons.DataSource = ClsSessionLoan.Persons;
                          txtPersonName.ReadOnly = true;
                 }
                else
                    {
                        MessageBox.Show("لا يوجد بيانات"); 
                    }

           
                  }
 
           
            catch (Exception ee)
            {
                string u = ee.Message;
                ClsSessionLoan.ErrorMessages();
            }
        }

        private void frmPersons_Load(object sender, EventArgs e)
        {
            txtAccountId.Text = ((FrmAccountsMng_Loan)this.Owner).txtAccountId.Text;

            cmbPersonStatusId.SelectedValue = "1";

            AAccountId = string.IsNullOrEmpty(txtAccountId.Text) ? 0 : Convert.ToInt32(txtAccountId.Text);

             
                DataTable MySrch = MoneyLoansDb.GetPersons(AccountId: AAccountId);

                if (MySrch.Rows.Count > 0)
                {
                    UtilityLoan.FillForm(this, MySrch);

                    ClsSessionLoan.Persons = MySrch;
                    grdPersons.DataSource = ClsSessionLoan.Persons;

                    txtPersonName.ReadOnly = true;
                }
             
          }

        private void grdPersons_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int PersonId = Convert.ToInt32(grdPersons.CurrentRow.Cells["gPersonId"].Value.ToString());

            DataTable MySrch = MoneyLoansDb.GetPersons(PersonId);

            ClsSessionLoan.Persons  = MySrch;

            if (MySrch.Rows.Count > 0)
            {
                UtilityLoan.FillForm(this, MySrch);
                txtPersonName.ReadOnly = true;
                btnSave.Enabled = true;

            }
        }

        private void txtBithDate_ValueChanged(object sender, EventArgs e)
        {
            txtBithDate.Format = DateTimePickerFormat.Custom;
            txtBithDate.CustomFormat = "yyyy/MM/dd";
                   
        }

        private void cmbNationalityId_SelectedIndexChanged(object sender, EventArgs e)
        {
            int NationalityId = Convert.ToInt32(cmbNationalityId.SelectedValue);


            DataTable MySrch = MoneyLoansDb.GetNationality(Nationalityid: NationalityId);


            string SDocTypeId = MySrch.Rows[0]["DocTypeId"].ToString();

           int DocTypeId = string.IsNullOrEmpty(SDocTypeId) ? 0 : Convert.ToInt32(SDocTypeId);

           LookUpTableId = (int)ClsSessionLoan.LookupTable.OfficialDocTypes ;
           DataList = MoneyLoansDb.GetLkupValues(ValueMember:DocTypeId,LookUpTableId: LookUpTableId);
 
            MySrch = DataList;

            if (MySrch.Rows.Count > 0 && DocTypeId != 0)
            {
                lblDocId.Visible = true;
                lblDocId.Text = MySrch.Rows[0]["DisplayMember"].ToString();

                txtDocId.Enabled = true;
                txtDocId.Tag = null;

                txtDocId.Visible = true;
            }
            else
            {
                txtDocId.Enabled = false;
                txtDocId.Tag = "NationalNO";

                txtDocId.Visible = false;

                lblDocId.Text = "";
                lblDocId.Visible = false;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

        }

        private void btnPrint_Click(object sender, EventArgs e)
        {

        }
    }
}
