using System;
using System.Collections.Generic;

namespace Lab2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Pet doguinho = new Pet("Snoopy", 1, "dog");
            Pet catinho = new Pet("Tom", 2, "cat");
            Pet bunnicula = new Pet("Roger", 3, "rabbit");
            Pet swordfish = new Pet("Nemo", 4, "fish");
            int counter = 1;
            string filter;

            List <Pet> animals = new List<Pet>() {doguinho,catinho,bunnicula,swordfish};

            doguinho.Train();
            catinho.Train();
            catinho.SetOwner("Philip Sherman");
            bunnicula.SetOwner("Jessica Rabbit");
            swordfish.SetOwner("Philip Sherman");

            foreach (Pet p in animals)
            {
                Console.WriteLine($"\n-------------------- Pet #{counter++} --------------------");
                Console.Write(p);
            }
            Console.WriteLine($"\n------------------ End of List -----------------\n");

            Console.Write("If you want to look for a specific pet, type the owner's name now: ");
            filter = Console.ReadLine();

            counter = 1;
            foreach (Pet p in animals)
            {
                if (p.Owner.ToLower() == filter.ToLower())
                {
                    Console.WriteLine($"\n-------------------- Pet #{counter++} --------------------");
                    Console.Write(p);
                }
            }
            Console.WriteLine($"\n------------------ End of List -----------------\n");

            Console.Write($"\nPress any key to end the program . . .");
            Console.ReadKey();
        }
    }

    public class Pet
    {
        public string Name { get; }
        public string Owner { get; private set; }
        public int Age { get; }
        public string Description { get; }
        public bool IsHouseTrained { get; private set; }

        public Pet(string name, int age, string description)
        {
            Name = name;
            Age = age;
            Description = description;

            Owner = "no one";
            IsHouseTrained = false;
        }

        public override string ToString()
        {
            return $"Name: {Name}\nOwner: {Owner}\nAge: {Age}\nDescription: {Description}\n" +
                   $"Is house trained: {IsHouseTrained}\n";
        }

        public void SetOwner(string owner)
        {
            Owner = owner;
        }
        public void Train()
        {
            IsHouseTrained = true;
        }
    }
}
