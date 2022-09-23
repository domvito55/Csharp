using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountsApp
{
    internal class CheckingAccount : Account
    {
        //Constants
        const double TRANSACTION_FEE = 1.0;

        //Properties
        public double Limit { get; set; }

        //Contructor
        public CheckingAccount(int number, string name, double balance, double limit):
                            base(number, name, balance)
        {
            Limit = limit;
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
