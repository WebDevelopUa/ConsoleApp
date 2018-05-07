using System;

namespace ConsoleSumCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            int num, num_1;

            Console.WriteLine("Enter first number:");
            num = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine("\nEnter second number:");
            num_1 = Convert.ToInt32(Console.ReadLine());

            
            Console.WriteLine("\nThe sum of two numbers is: " + (num + num_1).ToString());
            Console.ReadKey();



        }
    }
}
