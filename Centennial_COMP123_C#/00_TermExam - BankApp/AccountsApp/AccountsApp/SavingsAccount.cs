using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountsApp
{
    internal class SavingsAccount:Account
    {
        //Constants
        const double TRANSACTION_FEE = 2.25;

        //Properties
        public double Interest { get; set; }

        //Contructor
        public SavingsAccount(int number, string name, double balance, double interest) :
                            base(number, name, balance)
        {
            Interest = interest;
        }

        //Methods
        public override void Deposit(double amount)
        {
            Balance += (amount - TRANSACTION_FEE);
        }
        public override void Withdraw(double amount)
        {
            Balance -= (amount + TRANSACTION_FEE);
        }
    }
}
