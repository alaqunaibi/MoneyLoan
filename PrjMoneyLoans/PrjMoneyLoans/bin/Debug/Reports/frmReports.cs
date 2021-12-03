using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms ;
using System.IO;

namespace PrjMoneyLoans.Reports
{
    public partial class frmReports : Form
    {
        DBLConMoney objusertype;
        int rptno;

        string CharityCenters;
 
        public frmReports()
        {
            InitializeComponent();
         }

        private void frmReports_Load(object sender, EventArgs e)
        {
            reportViewer1.Reset();

             DataTable dt = new DataTable();
            objusertype = new DBLConMoney();


            string rptPath = "";
            string rptName = "";

            string exefile;

            ///==========
            /// 

            rptno = ClsSessionLoan.rptno;

            //https://web.whatsapp.com/

            CharityCenters = objusertype.GetTitle("MainTitle").Rows[0]["TitleValue"].ToString();

            //==============================================================
            if (rptno == (int)ClsSessionLoan.ReportNo.RptDepositors)
            {
                rptPath = @"rptDepositors.rdlc";
                rptName = "DSDepositors";
                dt = ClsSessionLoan.Depositors;
            }

            else if (rptno == (int)ClsSessionLoan.ReportNo.RptLoanAmounts)
            {
                rptPath = @"rptLoanAmounts.rdlc";
                rptName = "DSLoanAmounts";
                dt = ClsSessionLoan.LoanAmount;
             }
            else if (rptno == (int)ClsSessionLoan.ReportNo.RptDetailsLoanAmount)
            {
                rptPath = @"rptInstalmentTransactions.rdlc";
                rptName = "DSLoanTransActions";
                dt = ClsSessionLoan.DetailsLoanAmount;
             }
            else if (rptno == (int)ClsSessionLoan.ReportNo.RptCashBalance)
            {
                rptPath = @"rptCashBalance_Loan.rdlc";
                rptName = "DSCashBalance";
                dt = ClsSessionLoan.Cash;
             }
            
            else if (rptno == (int)ClsSessionLoan.ReportNo.RptCashDespositor)
            {
                rptPath = @"rptCashDespositor_Loan.rdlc";
                rptName = "DSCashDepositors";
                dt = ClsSessionLoan.CashClassify;
             }

            else if (rptno == (int)ClsSessionLoan.ReportNo.RptPersons)
            {
                rptPath = @"rptAccounts.rdlc";
                rptName = "Ds_Persons";
                dt = ClsSessionLoan.Persons;
             }



            //==============================================================

            //@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@

            try
            {
                ReportDataSource datasource;
                exefile = Path.GetDirectoryName(System.Windows.Forms.Application.ExecutablePath);

                rptPath = Path.Combine(exefile, "Reports", rptPath);

                reportViewer1.ProcessingMode = ProcessingMode.Local;
                reportViewer1.LocalReport.ReportPath = rptPath;
                reportViewer1.ShowPrintButton = true;
 
                //========================================================================

                if (dt.Rows.Count > 0)
                {
                    datasource = new ReportDataSource(rptName, dt);

                    reportViewer1.LocalReport.DataSources.Clear();
                    reportViewer1.LocalReport.DataSources.Add(datasource);

                    if (rptno == (int)ClsSessionLoan.ReportNo.RptDetailsLoanAmount)
                    {
                        datasource = new ReportDataSource("DSPersons", ClsSessionLoan.Persons);
                        reportViewer1.LocalReport.DataSources.Add(datasource);
                    }

                        ReportParameter rp = new ReportParameter("RptParm_Charity", CharityCenters);

                    reportViewer1.LocalReport.SetParameters(new ReportParameter[] { rp });
 
                  this.reportViewer1.RefreshReport();

                }
                else
                {
                      MessageBox.Show("التقرير فارغ",ClsSessionLoan.SystemTitle , MessageBoxButtons.OK, MessageBoxIcon.Information);
                     this.Close();
                }
             }

            catch (Exception mm)
            {
                MessageBox.Show(mm.Message);
            }
            this.reportViewer1.RefreshReport();
        }
        //@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@
    }
}