using System;
namespace CodeWorkBench.Math;

public static class Factors
{
    // Returns a list of all factors of a given number
    public static List<int> GetFactors(int number)
    {
        var factors = new List<int>();

        if (number <= 0)
            return factors;

        for (int i = 1; i <= number; i++)
        {
            if (number % i == 0)
                factors.Add(i);
        }
        
        return factors;
    }

    // Prints all factors
    public static void PrintFactors(int number)
    {
        var factors = GetFactors(number);
        Console.WriteLine($"Factors of {number}: {string.Join(",", factors)}");
    }
    
    // Checks if a number is perfect (sum of factors except itself equals number)
    public static bool IsPerfectNumber(int number)
    {
        if (number <= 1) return false;

        int sum = 0;
        for (int i = 1; i < number; i++)
            if (number % i == 0)
                sum += i;

        return sum == number;
    }
    
    public static void Demo()
    {
        Console.Write("Enter a number to find its factors: ");
        if (int.TryParse(Console.ReadLine(), out int n))
        {
            PrintFactors(n);

            if (IsPerfectNumber(n))
                Console.WriteLine($"{n} is a perfect number!");
            else
                Console.WriteLine($"{n} is not a perfect number.");
        }
        else
        {
            Console.WriteLine("Invalid input.");
        }
    }
}