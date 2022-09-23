/* Matheus Teixeira
 * 301236904
 * Comp 123 - Sec.006
 * 
 * Question 2
 * Create a new Console Application project called "ImportExportApp" (without quotes).
 * In your Program.cs file, inside your ImportExportApp namespace and outside the Program class,
 * create a new class called Car.
 * This class should have three public auto-implemented properties:
 * [2] CarID (int)
 * [2] Manufacturer (string)
 * [2] Model (string)
 * [3] In the Car class, override the ToString() method and have it returning a string with all
 * values from the Car properties.
 * In addition, the Car class must have two static methods:
 * [5] 1 - WriteFile: Saves one or more Car objects to a specified file (i.e. Cars.json) as JSON.
 * This method receives two parameters:
 * The first is a list of Car objects to be saved (Hint: You must use lists, not arrays),
 * The second is a string that represents the file name of the text file.
 * This method "returns" void, and writes each car object serialized to JSON in an individual line
 * in the file.
 * [5] 2 - ReadFile: Loads one or more Car objects from a specified file (i.e. Cars.json),
 * which comes in the same format as specified for method WriteFile. This method receives
 * one parameter: A string representing the file name of the text file to be loaded.
 * This method returns a list of Car objects loaded from the targeted file
 * (Hint: You must use lists, not arrays).
 * Once you are done, go back to the Main method in your Program.cs file, and write the test
 * harness that fully demonstrates that your code works as per requirements. In other words:
 * [2] - You must invoke the WriteFile method to write a list of car objects to your hard disk.
 * [2] - Then invoke the ReadFile method to load the data from the file you have just created.
 * [2] At the end, make sure to include a loop that iterates over the list of car objects you
 * have just loaded from the file, and display their information in the Console.
 * Make sure you completely adhere to all requirements. Do not change anything in terms of behavior,
 * property names, method names, identifiers, etc. You are expected to follow all C# naming
 * conventions. Penalties apply if these guidelines are not followed.
 * COPY THE ENTIRE CONTENT OF YOUR PROGRAM.CS FILE AND PASTE IT IN THE ANSWER BOX FOR THIS QUESTION.
 * Incomplete code will be graded ZERO marks.
 */
using System;
using System.Collections.Generic;
using System.Text.Json;
using System.IO;

namespace ImportExportApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //I created this 2 variables an a small function PopularCars() so I can run the code and
            //test it.
            List<Car> listCars = PopularCars();
            List<Car> listCarsReturned;

            /*
             * Once you are done, go back to the Main method in your Program.cs file, and write the test
             * harness that fully demonstrates that your code works as per requirements. In other words:
             * [2] - You must invoke the WriteFile method to write a list of car objects to your hard disk.
             */
            Car.WriteFile(listCars, "Cars.json");
            /* [2] - Then invoke the ReadFile method to load the data from the file you have just created.
             */
            listCarsReturned = Car.ReadFile("Cars.json");
            /* [2] At the end, make sure to include a loop that iterates over the list of car objects you
             * have just loaded from the file, and display their information in the Console.
             */
            Console.WriteLine("+------------------------------------------+");
            Console.WriteLine("|  CarID  | Manufacturer |      Model      |");
            Console.WriteLine("+------------------------------------------+");
            foreach (Car car in listCarsReturned)
            {
                Console.WriteLine(car);
            }
            Console.WriteLine("+------------------------------------------+");

            Console.ReadKey();
        }
        //I made this function to create a small list of Car so I can use it to run the test harness
        //and test my program before send upload it.
        public static List<Car> PopularCars()
        {
            List<Car> listCars = new List<Car>();

            Car fiat = new Car();
            fiat.CarID = 1000000;
            fiat.Manufacturer = "Fiat";
            fiat.Model = "Palio Weekend";

            Car volkswagen = new Car();
            volkswagen.CarID = 2000000;
            volkswagen.Manufacturer = "Volkswagen";
            volkswagen.Model = "Gol";

            Car chevrolet = new Car();
            chevrolet.CarID = 3000000;
            chevrolet.Manufacturer = "Chevrolet";
            chevrolet.Model = "Corsa";

            listCars.Add(fiat);
            listCars.Add(chevrolet);
            listCars.Add(volkswagen);

            return listCars;
        }
    }


    /* In your Program.cs file, inside your ImportExportApp namespace and outside the Program class,
     * create a new class called Car.
     */
    internal class Car
    {
        /*
         * This class should have three public auto-implemented properties:
         *[2] CarID(int)
         *[2] Manufacturer(string)
         *[2] Model(string)
         */
        public int CarID { get; set; }
        public string Manufacturer { get; set; }
        public string Model { get; set; }

        /*[3] In the Car class, override the ToString() method and have it returning a string
         * with all values from the Car properties.
         */
        public override string ToString()
        {
            return $"| {CarID,7} | {Manufacturer,12} | {Model,15} |";
        }
        /* In addition, the Car class must have two static methods:
         * [5] 1 - WriteFile: Saves one or more Car objects to a specified file (i.e. Cars.json)
         * as JSON. This method receives two parameters:
         * The first is a list of Car objects to be saved (Hint: You must use lists, not arrays),
         * The second is a string that represents the file name of the text file.
         * This method "returns" void, and writes each car object serialized to JSON in an individual
         * line in the file.
         */
        public static void WriteFile(List<Car> listCars, string filename = "Cars.json")
        {
            string serialCar;
            StreamWriter file = new StreamWriter(filename);

            foreach (Car car in listCars)
            {
                serialCar = JsonSerializer.Serialize(car);
                file.WriteLine(serialCar);
            }
            file.Close();
        }
        /* [5] 2 - ReadFile: Loads one or more Car objects from a specified file (i.e. Cars.json),
         * which comes in the same format as specified for method WriteFile. This method receives
         * one parameter: A string representing the file name of the text file to be loaded.
         * This method returns a list of Car objects loaded from the targeted file
         * (Hint: You must use lists, not arrays).
         */
        public static List<Car> ReadFile(string filename = "Cars.json")
        {
            StreamReader file = new StreamReader(filename);
            string serialCar = file.ReadLine();
            Car car;
            List<Car> listCars = new List<Car>();

            while (serialCar != null)
            {
                car = JsonSerializer.Deserialize<Car>(serialCar);
                listCars.Add(car);
                serialCar = file.ReadLine();
            }

            file.Close();
            return listCars;
        }
    }
}