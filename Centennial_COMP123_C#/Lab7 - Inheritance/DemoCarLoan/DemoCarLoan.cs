using System;

namespace DemoCarLoan
{
    internal class DemoCarLoan
    {
        static void Main(string[] args)
        {
            /*Declarations*/
            Loan aLoan = new Loan();
            CarLoan aCarLoan = new CarLoan();

            /*Assignments*/
            aLoan.LoanNumber = 2239;
            aLoan.LastName = "Mitchell";
            aLoan.LoanAmount = 1000.00;

            aCarLoan.LoanNumber = 3358;
            aCarLoan.LastName = "Jansen";
            aCarLoan.LoanAmount = 20000.00;
            aCarLoan.Make = "Ford";
            aCarLoan.Year = 2005;

            /*Display*/
            Console.WriteLine($"Loan #{aLoan.LoanNumber} for" +
                $" {aLoan.LastName} is for {aLoan.LoanAmount:C2}");

            Console.WriteLine($"Loan #{aCarLoan.LoanNumber} for" +
                $" {aCarLoan.LastName} is for {aCarLoan.LoanAmount:C2}");
            Console.WriteLine($"   Loan #{aCarLoan.LoanNumber}" +
                $" is for a {aCarLoan.Year} {aCarLoan.Make}");

        }
    }

    class Loan
    {
        public int LoanNumber { get; set; }
        public string LastName { get; set; }
        public double LoanAmount { get; set; }
    }

    class CarLoan : Loan
    {
        public int Year { get; set; }
        public string Make { get; set; }
    }
}
