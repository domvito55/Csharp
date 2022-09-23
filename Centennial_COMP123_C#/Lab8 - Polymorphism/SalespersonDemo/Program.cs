using System;

namespace SalespersonDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Write a program named SalespersonDemo that instantiates objects using classes
             * named RealEstateSalesperson and GirlScout.*/
            RealEstateSalesperson oprah = new RealEstateSalesperson("Oprah", "Winfrey", 0.15);
            GirlScout chiquinha = new GirlScout("Maria Antonieta", "de las Nieves");

            /*Demonstrate that each object can use a SalesSpeech() method appropriately.
              Also, use a MakeSale() method two or three times with each object*/
            Console.Write($"{oprah} says: ");
            oprah.SalesSpeech();
            oprah.MakeSale(1000000);
            oprah.MakeSale(1200000);
            oprah.MakeSale(1800000);

            Console.Write($"{chiquinha} says: ");
            chiquinha.SalesSpeech();
            chiquinha.MakeSale(1);
            chiquinha.MakeSale(2);
            chiquinha.MakeSale(4);

            /* display the final contents of each object’s data fields.*/
            Console.WriteLine($"{oprah} sold {oprah.TotalSold:C}; her comission rate is " +
                $"{oprah.ComissionRate};\ntherefore, she earned {oprah.TotalComission:C} in " +
                $"comissions.\n");

            Console.WriteLine($"{chiquinha} sold {chiquinha.NumberBox} boxes.\n");
        }

        /*First, create an abstract class named Salesperson.*/
        abstract class Salesperson
        {
            /*Fields include first and last names;*/
            string firstName;
            string lastName;
            /*the Salesperson constructor requires both these values.*/
            public Salesperson(string firstName, string lastName)
            {
                this.firstName = firstName;
                this.lastName = lastName;
            }
            /*Include properties for the fields.*/
            public string FirstName { get { return firstName; } }
            public string LastName { get { return lastName; } }
            /* Include a method that returns a string that holds the Salesperson’s
             * full name—the first and last names separated by a space.*/
            public override string ToString()
            {
                return $"{firstName} {lastName}";
            }
        }

        /*Create two child classes of Salesperson: RealEstateSalesperson and
          GirlScout.*/
        class RealEstateSalesperson : Salesperson, ISellable
        {
            /*The RealEstateSalesperson class contains fields for total value sold in
             * dollars and total commission earned (both of which are initialized to 0)*/
            double totalSold = 0;
            double totalComission = 0;
            /*and a commission rate field required by the class constructor.*/
            double comissionRate;
            public RealEstateSalesperson(string firstName, string lastName, double comissionRate):
                                        base(firstName, lastName)
            {
                this.comissionRate = comissionRate;
            }
            /*nclude properties for every field*/
            public double TotalSold { get { return totalSold; } }
            public double TotalComission { get { return totalComission; } }
            public double ComissionRate { get { return comissionRate; } }
            /*In RealEstateSalesperson class, implement SalesSpeech() to display an
             * appropriate one- or two-sentence sales speech that the objects of the class
             * could use.*/
            public void SalesSpeech()
            {
                Console.WriteLine("I will forever believe that buying a home is a great\n" +
                    "investment because you can’t live in a stock certificate;\n" +
                    "you can’t live in a mutual fund!\n");
            }
            /*In the RealEstateSalesperson class, implement the MakeSale() method to
             * accept an integer dollar value for a house, add the value to the 
             * RealEstateSalesperson’s total value sold, and compute the total commission
             * earned*/
            public void MakeSale(int price)
            {
                totalSold += price;
                totalComission += price * comissionRate;
            }


        }
        class GirlScout : Salesperson
        {
            /*The GirlScout class includes a field to hold the number of boxes of cookies
             * sold, which is initialized to 0*/
            double numberBox = 0;
            //Constructor
            public GirlScout(string firstName, string lastName) :
                             base(firstName, lastName)
            { }
            /*nclude properties for every field*/
            public double NumberBox { get { return numberBox; } }

            /*In GirlScout class, implement SalesSpeech() to display an appropriate
             * one- or two-sentence sales speech that the objects of the class could use.*/
            public void SalesSpeech()
            {
                Console.WriteLine("Which one do you sir want?\n" +
                    "The one that looks like lemon, is made of blackcurrant, and tastes like\ntamarind; " +
                    "the one that looks like currant, is made of tamarind, and tastes like\nlemon; or " +
                    "the one that looks like tamarind, is made of lemon, and tastes like\ncurrant.\n");
            }
            /* In the GirlScout class, implement the MakeSale() method to accept an integer
             * representing the number of boxes of cookies sold and add it to the total
             * field*/
            public void MakeSale(int numberBox)
            {
                this.numberBox += numberBox;
            }

        }
        /*Create an interface named ISellable that contains two methods:
         * SalesSpeech() and MakeSale(). */
        interface ISellable
        {
            public void SalesSpeech();
            public void MakeSale(int price);
        }
    }
}
