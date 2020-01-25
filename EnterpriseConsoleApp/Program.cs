using System;

namespace EnterpriseConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            string name;
            int age;
            char gender;
            double salary;
            bool isEmployed;

            Console.Write("Enter Your Name: ");
            name = Console.ReadLine();
            
            Console.Write("Enter Your Age: ");
            age = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Your Gender: ");
            gender = Convert.ToChar(Console.ReadLine());

            Console.Write("Enter Your Salary: ");
            salary = double.Parse(Console.ReadLine());

            Console.Write("Are you employed (true or false): ");
            isEmployed = bool.Parse(Console.ReadLine());

            //This is how we concatenate string in C#
            //Method using plus signs
            Console.WriteLine("Your name is " + name + " and you are "
                + age +" years old. Your gender is " + gender + 
                " and your income is " + salary+ ". Do you work? " +
                isEmployed);
            //Using Place holders 
            Console.WriteLine("Your name is {0} and you are {1}" +
                " years old. Your gender is {2} and your income " +
                "is {3}. Do you work? {4}", name, age, gender,salary,isEmployed);

            //This method is called interpolation
            Console.WriteLine($"Your name is {name} and you are {age}" +
                $" years old. Your gender is {gender} and your income " +
                $"is {salary}. Do you work? {isEmployed}");
        }
    }
}
