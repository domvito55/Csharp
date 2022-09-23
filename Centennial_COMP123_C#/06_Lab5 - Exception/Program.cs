using System;

namespace Lab5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Calling first method
            //DivisionNoHandling();

            //Calling the second method
            //DivisionWithExceptionHandling();

            //Calling the third method
            //DivisionWithExceptionHandlingMoreInfo();

            //Calling the fourth method
            //DivisionWithExceptionHandlingThrow();

            //Calling the fifth method
            //GeneratingException();

            //Callin the sixth method
            HandlingRandomException();

            Console.ReadKey();
        }

        //Method 1
        static void DivisionNoHandling()
        {
            //call the Division method with argument 1 and 0
            Division(1, 0);
            //this will terminate your application
        }

        //Method 2
        static void DivisionWithExceptionHandling()
        {
            //call the Division method with argument 1 and 0
            try {
                Division(1, 0);
            }
            //You will catch the exception and do nothing
            catch
            {

            }
            //Your application should not crash
        }

        //Method 3
        static void DivisionWithExceptionHandlingMoreInfo()
        {
            //call the Division method with argument 1 and 0
            try
            {
                Division(1, 0);
            }
            //You will catch the exception and print the associated message
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            //your application should not crash
        }

        //Method 4
        static void DivisionWithExceptionHandlingThrow()
        {
            //call the Division method with argument 1 and 0
            try
            {
                Division(1, 0);
            }
            //You will catch the exception and print the associated message
            //You should create and throw a new exception
            catch (Exception e)
            {
                Console.WriteLine(e.Message);

                throw new Exception("Exception was handled, now I'm creating and throwing a new one.");
            }
            //your application will crash
        }

        //Method 5
        static void GeneratingException()
        {
            //You should create and throw a new exception
            throw new Exception("I'm creating and throwing a new exception.");

            //your application will crash
        }

        //Method 6
        static void HandlingRandomException()
        {
            //You should call the method below and catch all the possible exceptions individually and display a sensible output
            try
            {
                GeneratingRandomException();
            }
            catch (IndexOutOfRangeException e)
            {
                Console.WriteLine($"Catch 1: An Out Of Range Exception was catched. Here is the exception message: {e.Message}");
            }
            catch (NullReferenceException e)
            {
                Console.WriteLine($"Catch 2: A Null Reference Exception was catched. Here is the exception message: {e.Message}");
            }
            catch (InvalidOperationException e)
            {
                Console.WriteLine($"Catch 3: An Invalid Operation Exception was catched. Here is the exception message: {e.Message}");
            }
            catch (ArithmeticException e)
            {
                Console.WriteLine($"Catch 4: An Arithmetic Exception was catched. Here is the exception message: {e.Message}");
            }
            catch (FormatException e)
            {
                Console.WriteLine($"Catch 5: A Format Exception was catched. Here is the exception message: {e.Message}");
            }
            catch (InvalidCastException e)
            {
                Console.WriteLine($"Catch 6: An Invalid Cast Exception was catched. Here is the exception message: {e.Message}");
            }
            catch (OutOfMemoryException e)
            {
                Console.WriteLine($"Catch 7: An Out Of Memory Exception was catched. Here is the exception message: {e.Message}");
            }
            //your application will not crash
        }
        static void GeneratingRandomException()
        {
            int exceptionType = new Random().Next() % 6;
            switch (exceptionType)
            {
                case 0:
                    throw new IndexOutOfRangeException();
                case 1:
                    throw new NullReferenceException();
                case 2:
                    throw new InvalidOperationException();
                case 3:
                    throw new ArithmeticException();
                case 4:
                    throw new FormatException();
                case 5:
                    throw new InvalidCastException();
                case 6:
                    throw new OutOfMemoryException();
            }
        }

        //Given method
        static int Division(int top, int bottom) => top / bottom;
    }
}
