using System;
using System.Data;
using System.Windows.Forms;
using System.Text.RegularExpressions ;
using System.Linq;

namespace PrjMoneyLoans
{
    public partial class frmLkupTblNames : Form
    {
  
        private static frmLkupTblNames inst;
        public static frmLkupTblNames GetForm
        {
            get
            {
                if (inst == null || inst.IsDisposed)
                    inst = new frmLkupTblNames();


                return inst;
            }
        }

        PrjMoneyLoans.DBLConMoney MoneyLoansDb;

        public frmLkupTblNames(){
        
            InitializeComponent();
            MoneyLoansDb = new DBLConMoney();

            grdLkupTbls.AutoGenerateColumns = false;
 
        }

        private void btnsave_Click(object sender, EventArgs e)
        {

               DataTable mytb, mytbLookUpTableId;
             try
             {

                int LookUpTableId = string.IsNullOrEmpty(txtLookUpTableId.Text) ? 0 : Convert.ToInt32(txtLookUpTableId.Text);
                string LookUpTableName = txtLookUpTableName.Text.Trim();
  
                  

           
                 mytb = MoneyLoansDb.GetLkupTableNames(LookUpTableName: LookUpTableName);
                 mytbLookUpTableId = MoneyLoansDb.GetLkupTableNames(LookUpTableId: LookUpTableId);
 


                 if (mytb.Rows.Count > 0 && mytbLookUpTableId.Rows.Count == 0)
                 {
                     throw (new DuplicateNameException());
                 }


                 int DBLookUpTableId=0;

                  if (mytb.Rows.Count > 0 && mytbLookUpTableId.Rows.Count > 0 )
                 {
                      DBLookUpTableId =Convert.ToInt32(mytb.Rows[0]["LookUpTableId"].ToString());

                      if (DBLookUpTableId != LookUpTableId)  // student number in database do not equal student number in Form
                      {
                          throw (new DuplicateNameException());
                      }
                  }


//=====================================
              mytb = MoneyLoansDb.GetLkupTableNames(-1);

              
                if (UtilityLoan.ChkDataType(mytb,this))
                {






                    DataTable result = MoneyLoansDb.SaveLkupTblNames(LookUpTableId, LookUpTableName, txtLookUpTableNameArb.Text, txtDisplayMember.Text, txtValueMember.Text);





                    grdLkupTbls.DataSource = MoneyLoansDb.GetLkupTableNames();

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
                    int LookUpTableId = string.IsNullOrEmpty(txtLookUpTableId.Text) ? 0 : Convert.ToInt32(txtLookUpTableId.Text);
                    string LookUpTableName = txtLookUpTableId.Text.Trim();

                    DataTable result = MoneyLoansDb.GetLkupTableNames(LookUpTableId, LookUpTableName);

                    grdLkupTbls.DataSource = result;
                 
            }

            catch
            {
                ClsSessionLoan.ErrorMessages();

            }

        }

        private void frmLkupTblNames_Load(object sender, EventArgs e)
        {
             btnClear_Click(null, null);

         }

        private void grdLkupTbls_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            int i = Convert.ToInt32( grdLkupTbls.CurrentRow.Cells["LookUpTableId"].Value.ToString());

            DataTable result = MoneyLoansDb.GetLkupTableNames(i);

            if (result.Rows.Count > 0)
            {
                 UtilityLoan.FillForm(this, result); 
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            UtilityLoan.ClearForm(this);


            DBLConMoney DbObj = new DBLConMoney();

            DataTable dt = new DataTable();

            dt = DbObj.GetLookUpTableMaxNo();

            txtLookUpTableId.Text = dt.Rows[0]["LookUpTableId"].ToString();
            txtLookUpTableId.Text = dt.Rows[0]["LookUpTableId_User"].ToString();  

            grdLkupTbls.DataSource = MoneyLoansDb.GetLkupTableNames();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

            try
            {

                int LookUpTableNamerid = UtilityLoan.IsNumber(txtLookUpTableId.Text) ? Convert.ToInt32(txtLookUpTableId.Text) : -1;

                if (LookUpTableNamerid == -1)
                {
                    throw (new Exception());
                }

                string strInfo = "جمعية المحافظة على القرآن الكريم - إدارة الحلقات";

                var yesno = MessageBox.Show("هل تريد حذف السجل؟", strInfo, MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (yesno == DialogResult.Yes)
                {
                    DBLConMoney DbObj = new DBLConMoney();

                
                    
                        DbObj.DeleteLookUpTable(LookUpTableNamerid);

                        UtilityLoan.ClearForm(this);


                        grdLkupTbls.DataSource = DbObj.GetLkupTableNames();
                   
                }
            }
            catch
            {
                ClsSessionLoan.ErrorMessages();
            }
        }

        private void btnClean_Click(object sender, EventArgs e)
        {
            UtilityLoan.ClearForm(this);
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

 
       
    }
}
