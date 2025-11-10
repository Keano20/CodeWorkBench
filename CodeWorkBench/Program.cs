using System;

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
                Console.WriteLine("2) Factors and GCD demo");
                Console.WriteLine("3) String palindrome demo");
                Console.WriteLine("4) Nested loops demo");
                Console.WriteLine("Enter to quit.");
                Console.Write("Choice: ");

                var input = Console.ReadLine();
                if (String.IsNullOrWhiteSpace(input)) break;
            }
        }
    }
}
