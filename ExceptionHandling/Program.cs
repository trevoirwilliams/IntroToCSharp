using System;

namespace ExceptionHandling
{
    class Program
    {
        static void Main(string[] args)
        {

            /*
                try − A try block identifies a block of code for which
                    particular exceptions is activated. 
                catch − A program catches an exception with an 
                    exception handler 
                finally − The finally block is used to execute, 
                    whether an exception is thrown or not.
                throw − A program throws an exception when a problem 
                    shows up. 
             */

            Console.WriteLine("Enter first number: ");
            int n1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter second number: ");
            int n2 = int.Parse(Console.ReadLine());

            try
            {
                int result = n1 / n2;
                Console.WriteLine($"Result: {result}");
            }
            catch (Exception)
            {
                Console.WriteLine("Operation Failed");
            }
        }
    }
}
