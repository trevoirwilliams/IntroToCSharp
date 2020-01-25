using System;

namespace ClassesAndObjects
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person();
            Console.WriteLine("Enter Your Name: ");
            person.Name = Console.ReadLine();

            Console.WriteLine("Enter Your Age: ");
            person.Age = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter Your Salary: ");
            person.Salary = int.Parse(Console.ReadLine());


        }
    }
}
