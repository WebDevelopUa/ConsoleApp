using System;

namespace CheckNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            double num;
 

            Console.WriteLine("Enter number:");
            num = Convert.ToDouble(Console.ReadLine());

            if (num > 18 && num < 50)
                Console.WriteLine("Access GRANTED, you chose range between 18 and 50");

            else if (num < 18)
                Console.WriteLine("Access DENIED, you chose range below 18");

            else if (num > 50)
                Console.WriteLine("Access DENIED, you chose range above 50");

            //else if (num == 18)
            //    Console.WriteLine("Access GRANTED, you chose 18");

            //else if (num == 50)
            //    Console.WriteLine("Access GRANTED, you chose 50");

            else
                Console.WriteLine("Congrats! You WIN! " + num + " is a lucky number for today");
 

            Console.ReadKey();
        }
    }
}
