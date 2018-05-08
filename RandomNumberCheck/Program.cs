using System;

namespace RandomNumberCheck
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rndNum = new Random();
            int num;
            num = rndNum.Next(1, 10);

            Console.WriteLine("Today's Winner is Random selected number: " + num);

            switch (num)
            {
                case 1:
                    Console.WriteLine("Jonny is a Winner!");
                    break;
                case 2:
                    Console.WriteLine("Nancy is a Winner!");
                    break;
                case 3:
                    Console.WriteLine("Lucy is a Winner!");
                    break;
                default:
                    Console.WriteLine("Nobody wins, try again next time");
                    break;

            }


            Console.ReadKey();
        }
    }
}
