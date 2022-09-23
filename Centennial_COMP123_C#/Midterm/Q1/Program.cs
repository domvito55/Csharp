/* Matheus Teixeira
 * 301236904
 * Comp 123 - Sec. 006
 * 
 * Question 1
 * You will be writing 3 methods for this question:
 * [3] 1 - Write a method called "FahrenheitToCelsius" that takes a double value representing
 * the temperature in Fahrenheit and returns the temperature in Celsius. C = (F - 32) *5 / 9
 * [3] 2 - Write a second method called "CelsiusToKelvin" that takes a double value representing
 * the temperature in Celsius and returns the temperature in Kelvin. K = C + 273.15
 * [3] 3 - Write a third method called "FahrenheitToKelvin" that takes a double value representing
 * the temperature in Fahrenheit and returns the temperature in Kelvin. For this method you must
 * invoke the two previous methods appropriately. Don't duplicate code that has been written before.
 * [1] 4 - Write the code statements that you would add inside the Main() method to invoke the third
 * method and display the argument and the return value.
 */
using System;

namespace Midterm
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double argument;
            double returnValue;

            /* [1] 4 - Write the code statements that you would add inside the Main() method
             * to invoke the third method and display the argument and the return value.
             */
            Console.WriteLine(" Argument | Return Value ");
            for (argument = 32; argument <= 212; argument = argument + 18)
            {
                returnValue = FahrenheitToKelvin(argument);
                Console.WriteLine($"    {argument,3}   |     {returnValue}    ");
            }

            Console.ReadKey();
        }
        /* [3] 1 - Write a method called "FahrenheitToCelsius" that takes a double value representing
         * the temperature in Fahrenheit and returns the temperature in Celsius.C = (F - 32) *5 / 9
         */
        static double FahrenheitToCelsius(double F)
        {
            double C = (F - 32) * 5 / 9;
            return C;
        }
        /* [3] 2 - Write a second method called "CelsiusToKelvin" that takes a double value
         * representing the temperature in Celsius and returns the temperature in Kelvin.
         * K = C + 273.15
         */
        static double CelsiusToKelvin(double C)
        {
            double K = C + 273.15;
            return K;
        }
        /* [3] 3 - Write a third method called "FahrenheitToKelvin" that takes a double value
         * representing the temperature in Fahrenheit and returns the temperature in Kelvin.
         * For this method you must invoke the two previous methods appropriately.
         * Don't duplicate code that has been written before.
         */
        static double FahrenheitToKelvin(double F)
        {
            double C = FahrenheitToCelsius(F);
            double K = CelsiusToKelvin(C);
            return K;
        }
    }
}