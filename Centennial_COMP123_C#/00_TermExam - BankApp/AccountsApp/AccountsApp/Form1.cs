using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AccountsApp
{
    public partial class frmAccounts : Form
    {
        List<Account> accounts = new List<Account>();

        public frmAccounts()
        {
            InitializeComponent();
        }

        private void rbtnChecking_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnChecking.Checked)
            {
                txtDailyWithdrawLimit.Enabled = true;
                txtInterestRate.Enabled = false;
            }
        }

        private void rbtnSavings_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnSavings.Checked)
            {
                txtDailyWithdrawLimit.Enabled = false;
                txtInterestRate.Enabled = true;
            }
        }

        private void frmAccounts_Load(object sender, EventArgs e)
        {
            if (rbtnChecking.Checked)
            {
                txtDailyWithdrawLimit.Enabled = true;
                txtInterestRate.Enabled = false;
            }
            else if (rbtnSavings.Checked)
            {
                txtDailyWithdrawLimit.Enabled = false;
                txtInterestRate.Enabled = true;
            }
        }

        private void btnCreateAccount_Click(object sender, EventArgs e)
        {
            int number=0;
            double balance=0;
            double limit=0;
            double interest=0;

            try { number = int.Parse(txtAccountNumber.Text);}
            catch { MessageBox.Show("Account Number must be an integer");}
            try { balance = double.Parse(txtBalance.Text); }
            catch { MessageBox.Show("Balance must be a real number"); }
            if (rbtnChecking.Checked)
            {
                try
                {
                    limit = double.Parse(txtDailyWithdrawLimit.Text);
                    CheckingAccount account = new CheckingAccount(number, txtClientName.Text, balance, limit);
                    accounts.Add(account);
                }
                catch { MessageBox.Show("Daily Limit must be a real number"); }
            }
            else if (rbtnSavings.Checked)
            {
                try
                {
                    interest = double.Parse(txtInterestRate.Text);
                    SavingsAccount account = new SavingsAccount(number, txtClientName.Text, balance, interest);
                    accounts.Add(account);
                }
                catch { MessageBox.Show("Interest Rate must be a real number"); }
            }
            txtAccountNumber.Text = "";
            txtClientName.Text = "";
            txtBalance.Text = "";
            txtDailyWithdrawLimit.Text = "";
            txtInterestRate.Text = "";
            rbtnChecking.Checked = true;
            MessageBox.Show($"The total number of accounts is: {accounts.Count}");
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            int number = 0;
            bool found = false;

            try
            {
                number = int.Parse(txtAccountNumber.Text);
                foreach (Account account in accounts)
                {
                    if (account.Number == number)
                    {
                        found = true;
                        txtAccountNumber.Text = number.ToString();
                        txtClientName.Text = account.Name;
                        txtBalance.Text = account.Balance.ToString();
                        if (account is CheckingAccount)
                        {
                            rbtnChecking.Checked = true;
                            rbtnSavings.Checked = false;
                            CheckingAccount account2 = account as CheckingAccount;
                            txtDailyWithdrawLimit.Text = account2.Limit.ToString();
                            txtInterestRate.Text = "";
                        }
                        else if (account is SavingsAccount)
                        {
                            rbtnChecking.Checked = false;
                            rbtnSavings.Checked = true;
                            SavingsAccount account3 = account as SavingsAccount;
                            txtInterestRate.Text = account3.Interest.ToString();
                            txtDailyWithdrawLimit.Text = "";
                        }
                    }
                }
                if (!found)
                {
                    MessageBox.Show("This Account Number does not exist");
                }
            }
            catch { MessageBox.Show($"The number of existent accounts is: {accounts.Count}"); } 
        }
    }
}
