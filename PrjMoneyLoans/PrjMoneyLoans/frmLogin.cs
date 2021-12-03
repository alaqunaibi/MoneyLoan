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
    public partial class frmLogin : Form
    {

        DBLConMoney MoneyLoansDb;

        public frmLogin()
        {
            InitializeComponent();

            MoneyLoansDb = new DBLConMoney();

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            DataTable tblUsers = MoneyLoansDb.GetUsers(txtUserName.Text, txtPassword.Text);

            if (tblUsers.Rows.Count >0)
            {
                pnlError.Visible = false ;

                MDIMain abc = new MDIMain();

                abc.Show();

                this.Hide();
            }
            else
            {
                pnlError.Visible = true;
            }
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
