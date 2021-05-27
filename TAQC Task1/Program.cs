using System;

namespace TAQC_Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1-Check value 2-How are you");
            int checkV = Convert.ToInt32(Console.ReadLine());
            switch (checkV)
            {
                case 1:
                    int a, b;
                    Console.WriteLine("Enter a:");
                    a = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter b:");
                    b = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine($"Result of a + b = {a + b}");
                    Console.WriteLine($"Result of a - b = { a - b}");
                    Console.WriteLine($"Result of a * b = {a * b}");
                    Console.WriteLine($"Result of a / b = {a / b}");

                    break;
                case 2:
                    Console.WriteLine("How are you?");
                    string answer = Console.ReadLine();
                    Console.WriteLine($"You are {answer}");
                    break;
            }
        }
    }
}
