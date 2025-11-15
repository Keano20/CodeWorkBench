using System;

namespace CodeWorkBench.Math;

public static class Primes
{
    // Checks if a single number is prime
    public static bool IsPrime(int number)
    {
        if (number < 2) return false; // 0 and 1 are not prime
        if (number == 2) return true; // 2 is a prime number
        if (number % 2 == 0) return false;

        for (int i = 3; i * i <= number; i += 2)
        {
            if (number % i == 0)
                return false;
        }
        return true;
    }
    
    // Prints all prime numbers up to a given limit
    public static void PrintPrimesUpTo(int limit)
    {
        for (int i = 2; i <= limit; i++)
        {
            if (IsPrime(i))
                 Console.WriteLine(i + "");
        }
        Console.WriteLine();
    }
    
    // Demo runner
    public static void Demo()
    {
        Console.Write("Enter an upper limit: ");
        if (int.TryParse(Console.ReadLine(), out int limit))
        {
            Console.WriteLine($"Prime numbers up to {limit}:");
            PrintPrimesUpTo(limit);
        }
        else
        {
            Console.WriteLine("Invalid Number.");
        }
    }
}