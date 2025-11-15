using System;
using CodeWorkBench.Linq;
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
                Console.WriteLine("3) LINQ numbers demo");
                Console.WriteLine("4) LINQ Objects demo");
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
                        LinqNumberDemo.Demo();
                        break;
                    case "4":
                        LinqObjectDemo.Demo();
                        break;
                    default:
                        Console.WriteLine("Unknown choice");
                        break;
                }
            }
        }
    }
}
