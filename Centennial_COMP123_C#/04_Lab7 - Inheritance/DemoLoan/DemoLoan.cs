using System;

namespace DemoLoan
{
    internal class DemoLoan
    {
        static void Main(string[] args)
        {
            Loan aLoan = new Loan();
            aLoan.LoanNumber = 2239;
            aLoan.LastName = "Mitchell";
            aLoan.LoanAmount = 1000.00;
            Console.WriteLine($"Loan #{aLoan.LoanNumber} for {aLoan.LastName} is for {aLoan.LoanAmount:C2}");
        }
    }

    internal class Loan
    {
        public int LoanNumber { get; set; }
        public string LastName { get; set; }
        public double LoanAmount { get; set; }
    }
}
