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
    public partial class MDIMain : Form
    {
        // private int childFormNumber = 0;
        DBLConMoney MoneyLoansDb;

        public MDIMain()
        {
            InitializeComponent();
        }

        public bool CheckLookUpData(string frmName = "")
        {
            bool result = true;

            DataTable DataList = MoneyLoansDb.GetDepositors();

            if (frmName == "frmCash")
            {
                if (DataList.Rows.Count == 0)
                {
                    result = false;
                    ClsSessionLoan.FillDepositorsName();

                    frmDepositors.GetForm.MdiParent = this;
                     frmDepositors.GetForm.Tag = ((this.MnuDepositors)).Name;
                     frmDepositors.GetForm.Show();
                }
            }
            return result;
        }

        private void OpenFile(object sender, EventArgs e)
        {

            if (CheckLookUpData("frmCash"))
            {
                frmCash.GetForm.MdiParent = this;

                frmCash.GetForm.Tag = ((ToolStripMenuItem)sender).Name;

                frmCash.GetForm.Show();
            }
          }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            saveFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = saveFileDialog.FileName;
            }
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }

        private void CutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void ToolBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
           // toolStrip.Visible = MnuLookups.Checked;
        }

        private void StatusBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            statusStrip.Visible = MnuUsers.Checked;
        }

        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        private void contentsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        public void MnuDepositors_Click(object sender, EventArgs e)
        {
            frmDepositors.GetForm.MdiParent = this;

            frmDepositors.GetForm.Tag = ((ToolStripMenuItem)sender).Name;

            frmDepositors.GetForm.Show();
        }

        private void MnuOpenAccounts_Click(object sender, EventArgs e)
        {
            FrmAccountsMng_Loan.GetForm.MdiParent = this;

            FrmAccountsMng_Loan.GetForm.Tag = ((ToolStripMenuItem)sender).Name;

            FrmAccountsMng_Loan.GetForm.Show();
         }

        private void MnuNationality_Click(object sender, EventArgs e)
        {
            frmNationality.GetForm.MdiParent = this;

            frmNationality.GetForm.Tag = ((ToolStripMenuItem)sender).Name;

            frmNationality.GetForm.Show();
        }

        private void MnuSysCoding_Click(object sender, EventArgs e)
        {
            frmLOOKUPSValues.GetForm.MdiParent = this;

            frmLOOKUPSValues.GetForm.Tag = ((ToolStripMenuItem)sender).Name;

            frmLOOKUPSValues.GetForm.Show();
         }

        private void MDIMain_Load(object sender, EventArgs e)
        {
            MoneyLoansDb = new DBLConMoney();
            MoneyLoansDb.CheckNewFinanceYear();
        }

        private void MnuTables_Click(object sender, EventArgs e)
        {
            frmLkupTblNames.GetForm.MdiParent = this;

            frmLkupTblNames.GetForm.Tag = ((ToolStripMenuItem)sender).Name;

            frmLkupTblNames.GetForm.Show();
        }

        private void MnuLoans_Click(object sender, EventArgs e)
        {
            frmLoans.GetForm.MdiParent = this;

            frmLoans.GetForm.Tag = ((ToolStripMenuItem)sender).Name;

            frmLoans.GetForm.Show();
        }

        private void MnuInstallments_Click(object sender, EventArgs e)
        {
            frmInstalment.GetForm.MdiParent = this;

            frmInstalment.GetForm.Tag = ((ToolStripMenuItem)sender).Name;

            frmInstalment.GetForm.Show();
        }

        private void MnuQuit_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }
    }
}
