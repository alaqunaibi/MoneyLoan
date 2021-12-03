using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Windows.Forms;

namespace PrjMoneyLoans
{

    public class ClsSessionLoan
    {

        public static string ReportName;
        public static string SystemTitle = "نظام ادارة القروض والتقسيط";
        public static string strInfo = SystemTitle;

        public static int ShowHide = -1;

        public static int SelectedLookupTable;

        public enum OrderInstalment
        {
            Order = 1,
            Random = 2
        }

        public enum Repayway
        {
            MonthlyAmount = 1,
            Period = 2
        }
        public enum OptRemainder
        {
            All = 0,
            WithRemainder = 1,
            WithoutRemainder = 2
        }

        public enum OptFinanceYearId
        {
            AllFinanceYears = 0,
            OnlySelectedFinanceYear = 1
        }

        public enum CashProcess
        {
            All = 0,
            Deposit = 1,//ايداع
            RePayment = 2, // سداد قرض
            Payment = 3,            // صرف قرض
            CashWithDraw = 4,// سحب من الصندوق
            CashModify=5   //تعديل المبلغ
        }
        public enum DepositType
        {
            All = 0,
            Loans = 1,
            HelpFamily=2,
            Emergency=3
        }

        public enum LookupTable
        {
            AccountStatus = 1,
            City = 2,
            //AccountType=3,
            Gender=4,
            HealthStatus=5,
            //Manner=6,
            MaritalStatus=7,
            Qualifications=8,
            //RELATIONSHIP=9,
            StudyStage=10,
            HouseStatus=11,
            BuildingStatus=12,
            BuildingType=13,
            HouseComponent=14,
            FurnaturStatus=15,
            HomeFurnatur=16,
            RevenuItems=17,
            PaymentItems=18,
            StudyResourcesItems=19,
            FamilyOwnsItems=20,
            OfficialDocTypes=21,
            PersonStatus=22,
            DepositType = 23,
            Repayway= 24,
            InstalmentCalculate=25
        }

        public enum ReportNo
        {
            RptDepositors = 1,
            RptAccounts = 2,
            RptLoanAmounts = 3,
            RptDetailsLoanAmount = 4,
            RptPersons = 5,
            RptCashBalance = 6,
            RptCashDespositor=7 
           }


        public static Form myform;

        public static int rptno = 0;

        // private  DataTable  

        public static DataTable Depositors;
        public static DataTable Accounts;
        public static DataTable Persons;
        public static DataTable Cash;
        public static DataTable LoanAmount;
        public static DataTable DetailsLoanAmount;
        public static DataTable Instalments;
        public static DataTable PaymentAmount;
        public static DataTable CashClassify;
 
        public ClsSessionLoan()
        {
            //Re-set all the session values
        }

        public static void ErrorMessages()
        {
            MessageBox.Show("حدث خطأ في البيانات أو السجل غير موجود", strInfo, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public static void ErrorDataType()
        {
            MessageBox.Show("نوع البيانات غير مناسب", strInfo, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public static void ErrorCashMessages()
        {
            MessageBox.Show(" لا يمكن صرف القرض ", strInfo, MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        public static void ErrorModifyCashMessages()
        {
            MessageBox.Show(" لا يمكن تعديل قيمة المبلغ في الصندوق لعجز التغطية ", strInfo, MessageBoxButtons.OK, MessageBoxIcon.Warning );
        }

        public static void ErrorCashDateMessages()
        {
            MessageBox.Show(" تاريخ الادخال خاطئ--يرجى التأكد من صحة التاريخ المدخل ", strInfo, MessageBoxButtons.OK, MessageBoxIcon.Stop);
        }

        public static void ErrorCashAmountDidnotChangeMessages()
        {
            MessageBox.Show(" المبلغ لم بجر عليه أي تعديل ", strInfo, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public static void ErrorDeleteCashMessages()
        {
            MessageBox.Show(" لا يمكن حذف قيمة المبلغ في الصندوق لعجز التغطية ", strInfo, MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        public static void ErrorDataMessage()
        {
            MessageBox.Show("البيانات المدخلة خاطئة ، يرجى تدقيق البيانات المدخلة", strInfo, MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        public static void ErrorInstalmentMessages()
        {
            MessageBox.Show("لا يجوز أن يكون قيمة القسط الشهري أكبر من قيمة القرض", strInfo, MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }


        public static void PayAmountIsLarge()
        {

            MessageBox.Show("المبلغ المدفوع أكثر من المبلغ المستحق", strInfo, MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }



        public static void SaveMessages()
        {

            MessageBox.Show("تم حفظ البيانات والتعديلات بنجاح", strInfo, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public static void DeleteMessages()
        {

            MessageBox.Show("تمت عملية الحذف بنجاح", strInfo, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }


        public static void ErrorDublicateData()
        {
            string s1 = "لا يجوز تكرار البيانات";

            MessageBox.Show(s1 + "\n", strInfo, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }
        public static void ErrorBlankData()
        {
            string s1 = "يرجى أن تختار اسما مناسباً";

            MessageBox.Show(s1 + "\n", strInfo, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public static void FillDepositorsName()
        {
            MessageBox.Show("لطفاً أدخل أسماء المودعين على الأقل اسما واحداً", strInfo, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }


        public static void DataBaseNotExist()
        {
            MessageBox.Show("قاعدة البيانات غير موجودة ", strInfo, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}