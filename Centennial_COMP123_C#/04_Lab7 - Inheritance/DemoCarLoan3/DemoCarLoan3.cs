using System;

namespace DemoCarLoan3
{
    internal class DemoCarLoan3
    {
        static void Main(string[] args)
        {
            /*Declarations*/
            Loan aLoan = new Loan(333, "Hanson", 7000.00);
            CarLoan aCarLoan = new CarLoan(444, "Carlisle", 30000.00, 2011, "BMW");

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
        /*constants*/
        public const double MINIMUM_LOAN = 5000;
        /*fields*/
        protected double loanAmount;
        /*Constructor*/
        public Loan(int num, string name, double amount)
        {
            LoanNumber = num;
            LastName = name;
            LoanAmount = amount;
        }
        /*properties*/
        public int LoanNumber { get; set; }
        public string LastName { get; set; }
        public double LoanAmount
        {
            set
            {
                if (value < MINIMUM_LOAN)
                {
                    LoanAmount = MINIMUM_LOAN;
                }
                else
                {
                    loanAmount = value;
                }
            }
            get { return loanAmount; }
        }
    }

    class CarLoan : Loan
    {
        /*Constants*/
        private const int EARLIEST_YEAR = 2006;
        private const int LOWEST_INVALID_NUM = 1000;

        /*fields*/
        private int year;
        /*Constructor*/
        public CarLoan(int num, string name,
            double amount, int year, string make) :
            base(num, name, amount)
        {
            Year = year;
            Make = make;
        }
        /*properties*/
        public int Year
        {
            set
            {
                if (value < EARLIEST_YEAR)
                {
                    year = value;
                    loanAmount = 0;
                }
                else
                {
                    year = value;
                }
            }
            get
            {
                return year;
            }
        }
        public string Make { get; set; }

        public new int LoanNumber
        {
            get
            {
                return base.LoanNumber;
            }
            set
            {
                if (value < LOWEST_INVALID_NUM)
                {
                    base.LoanNumber = value;
                }
                else
                {
                    base.LoanNumber = value % LOWEST_INVALID_NUM;
                }
            }
        }
    }
}
