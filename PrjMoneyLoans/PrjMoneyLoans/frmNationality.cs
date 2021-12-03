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
    public partial class frmNationality : Form
    {  
       
        DBLConMoney MoneyLoansDb;
  
        private static frmNationality inst;
        public static frmNationality GetForm
        {
            get
            {
                if (inst == null || inst.IsDisposed)
                    inst = new frmNationality();
                return inst;
            }
        }


     
        public frmNationality()
        {
            InitializeComponent();
            MoneyLoansDb = new DBLConMoney();
            grdNationalitys.AutoGenerateColumns = false;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            UtilityLoan.ClearForm(this);
             

            DataTable dt = new DataTable();

            dt = MoneyLoansDb.GetNationalityMaxNo();

            txtNationalityid.Text = dt.Rows[0]["Nationalityid"].ToString();
            txtNationalityid_User.Text = dt.Rows[0]["Nationalityid_User"].ToString();

            grdNationalitys.DataSource = MoneyLoansDb.GetNationality();

            int LookUpTableId = (int)ClsSessionLoan.LookupTable.OfficialDocTypes;
            DataTable result = MoneyLoansDb.GetLkupValues(LookUpTableId: LookUpTableId);

            LstDocTypeId.DataSource = result;
         }

        private void btnsave_Click(object sender, EventArgs e)
        {     


              DataTable mytb, mytbNationalityid;
             try
             {

                int Nationalityid = string.IsNullOrEmpty(txtNationalityid.Text) ? 0 : Convert.ToInt16(txtNationalityid.Text);
                string Nationality = txtNationality.Text.Trim();

                 Nationality = UtilityLoan.CleanStringExceptNumbersEglish(Nationality); // Remove All Spaces

                 if (String.IsNullOrEmpty(Nationality))
                 {
                      throw (new DataException());
                 }
 
                 mytb = MoneyLoansDb.GetNationality(Nationality: Nationality);
                 mytbNationalityid = MoneyLoansDb.GetNationality(Nationalityid: Nationalityid);

                 if (mytb.Rows.Count > 0 && mytbNationalityid.Rows.Count == 0)
                 {
                     throw (new DuplicateNameException());
                 }


                 int DBNationalityid=0;

                  if (mytb.Rows.Count > 0 && mytbNationalityid.Rows.Count > 0 )
                 {
                      DBNationalityid =Convert.ToInt32(mytb.Rows[0]["Nationalityid"].ToString());

                      if (DBNationalityid != Nationalityid)  // student number in database do not equal student number in Form
                      {
                          throw (new DuplicateNameException());
                      }
                  }


//=====================================
               mytb = MoneyLoansDb.GetNationality(-1);
 
                if (UtilityLoan.ChkDataType(mytb, this))
                {
              
                    int DocTypeId = (LstDocTypeId.SelectedIndex  == -1)? 0: Convert.ToInt32(LstDocTypeId.SelectedValue);


                    DataTable result = MoneyLoansDb.SaveNationality(Nationalityid, Nationality, DocTypeId);

                    grdNationalitys.DataSource =  MoneyLoansDb.GetNationality( );

                    ClsSessionLoan.SaveMessages();
                    btnClear_Click(null, null);
                }
            }

             
             catch (DuplicateNameException NameDublicate)
             {
                 string s = NameDublicate.Message;

                 ClsSessionLoan.ErrorDublicateData();
             }

             catch (DataException DataError)
             {
                 string sd = DataError.Message;
                 ClsSessionLoan.ErrorMessages();  
                
             }
             catch
             {

                 ClsSessionLoan.ErrorMessages();
             }
         }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            try
            {


                int Nationalityid = UtilityLoan.IsNumber(txtNationalityid.Text.Trim()) ? Convert.ToInt32(txtNationalityid.Text) : -1;

                string Nationality = txtNationality.Text.Trim();

                DataTable result = MoneyLoansDb.GetNationality(Nationalityid, Nationality);

                grdNationalitys.DataSource = result;

            }

            catch( Exception  eee)
            {

                string  t= eee.Message;

                ClsSessionLoan.ErrorMessages();

            }
        }

        private void btnClean_Click(object sender, EventArgs e)
        {
            UtilityLoan.ClearForm(this);
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

                    int Nationalityid = UtilityLoan.IsNumber(txtNationalityid.Text) ? Convert.ToInt16(txtNationalityid.Text) : -1;

                    MoneyLoansDb.DeleteNationality(Nationalityid);

                    btnClear_Click(null, null);
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

        private void frmNationality_Load(object sender, EventArgs e)
        {
             
            btnClear_Click(null, null);
          }

        private void grdNationalitys_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtNationalityid.Text = grdNationalitys.CurrentRow.Cells["Nationalityid"].Value.ToString();

            txtNationalityid_User.Text = grdNationalitys.CurrentRow.Cells["Nationalityid_User"].Value.ToString();


            string s = grdNationalitys.CurrentRow.Cells["DocTypeId"].Value.ToString();

            LstDocTypeId.SelectedValue = string.IsNullOrEmpty(s) ? "0" : s;


            txtNationality.Text = grdNationalitys.CurrentRow.Cells["Nationality"].Value.ToString(); 
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
