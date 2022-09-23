using System;

namespace CarDemoApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car gol = new Car("Gol", 20);
            Car mobi = new Car("Mobi");
            Console.WriteLine("\n------- Before addition -------\n");
            Console.WriteLine(gol);
            Console.WriteLine(mobi);
            gol++;
            mobi++;
            Console.WriteLine("\n-------- After addition -------\n");
            Console.WriteLine(gol);
            Console.WriteLine(mobi);

            Console.ReadKey();
        }
    }
    class Car
    {
        //Properties
        public string Model { get; set; }
        public double KilometersPerLitre { get; set; }
        //Constructors
        public Car (string model, double kilometersPerLitre)
        {
            Model = model;
            KilometersPerLitre = kilometersPerLitre;
        }
        public Car (string model)
        {
            Model = model;
            KilometersPerLitre = 15;
        }
        //Overload operator++
        public static Car operator++(Car car)
        {
            car.KilometersPerLitre = car.KilometersPerLitre+1;
            return car;
        }
        public override string ToString()
        {
            return $" Model: {Model}\n Efficiency (Km/Litre): {KilometersPerLitre}\n";
        }
    }
}
