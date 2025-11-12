using System;
using CodeWorkBench.Math;

namespace CodeWorkBench
{
    class Program
    {
        static void Main()
        {
            while (true)
            {
                Console.WriteLine("\nPractice Lab");
                Console.WriteLine("1) Primes demo");
                Console.WriteLine("2) Factors");
                Console.WriteLine("3) String palindrome demo");
                Console.WriteLine("4) Nested loops demo");
                Console.WriteLine("Enter to quit.");
                Console.Write("Choice: ");

                var input = Console.ReadLine();
                if (String.IsNullOrWhiteSpace(input)) break;

                switch (input.Trim())
                {
                    case "1":
                        Primes.Demo();
                        break;
                    case "2":
                        Factors.Demo();
                        break;
                    case "3":
                        break;
                    case "4":
                        break;
                    default:
                        Console.WriteLine("Unknown choice");
                        break;
                }
            }
        }
    }
}
