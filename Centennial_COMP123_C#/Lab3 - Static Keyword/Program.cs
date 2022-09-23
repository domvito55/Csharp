using System;
using System.Collections.Generic;

namespace Lab3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Account> accounts = new List<Account>();
            Random rand = new Random();

            accounts.Add(Account.CreateAccount("Narendra", rand.Next(50, 500)));
            accounts.Add(Account.CreateAccount("Ilia", rand.Next(50, 500)));
            accounts.Add(Account.CreateAccount("Yin", rand.Next(50, 500)));
            accounts.Add(Account.CreateAccount("Arben", rand.Next(50, 500)));
            accounts.Add(Account.CreateAccount("Patrick", rand.Next(50, 500)));
            accounts.Add(Account.CreateAccount("Joanne", rand.Next(50, 500)));
            accounts.Add(Account.CreateAccount("Nicoleta", rand.Next(50, 500)));
            accounts.Add(Account.CreateAccount("Mohammed", rand.Next(50, 500)));
            accounts.Add(Account.CreateAccount("Hao", rand.Next(50, 500)));
            accounts.Add(Account.CreateAccount("Mayy", rand.Next(50, 500)));

            Console.WriteLine("\nAll accounts");
            foreach (Account account in accounts)
            {
                Console.WriteLine(account);
            }

            foreach (Account account in accounts)
            {
                account.Deposit(rand.Next(4, 8) * 10);
            }

            Console.WriteLine("\nAfter deposit ");
            foreach (Account account in accounts)
            {
                Console.WriteLine(account);
            }

            foreach (Account account in accounts)
            {
                account.Withdraw(rand.Next(2, 5) * 10);
                if (account.Balance > 300)
                    account.AddName("(Hacked)");
            }

            Console.WriteLine("\nAfter withdrawal");
            foreach (Account account in accounts)
            {
                Console.WriteLine(account);
            }

            Console.Write($"\nPress any key to end the program . . .");
            Console.ReadKey();
        }

        class Account
        {
            //Constants
            private const int TRANSIT_NUMBER = 314;
            //Fields
            private static int nextAccountNumber;
            public readonly string Number;
            //Properties
            public double Balance { get; private set; }
            public List<string> Names { get; private set; }
            //Methods
            private Account(string number, string name, double balance)
            {
                Number = number;
                Balance = balance;
                Names = new List<string>() {name};

            }
            static Account()
            {
                nextAccountNumber = 10000;
            }
            public static Account CreateAccount(string name, double balance = 500)
            {
                string number;
                number = $"AC-{TRANSIT_NUMBER}-{nextAccountNumber++}";

                return new Account(number, name, balance);
            }
            public void AddName(string name)
            {
                Names.Add(name);
            }
            public void Deposit(double amount)
            {
                Balance += amount;
            }
            public void Withdraw(double amount)
            {
                Balance -= amount;
            }
            public override string ToString()
            {
                return $"[{Number}] {string.Join(", ", Names)} {Balance:C}";
            }
        }
    }
}
