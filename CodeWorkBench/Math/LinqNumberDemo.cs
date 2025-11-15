using System;
using System.Linq;

namespace CodeWorkBench.Math;

public class LinqNumberDemo
{
    public static void Demo()
    {
        Console.WriteLine("\nLinq Demo");

        int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        
        // 1. Filter (Where)
        var evens = numbers.Where(n => n % 2 == 0);
        Console.WriteLine("Even Numbers: " + string.Join(", ", evens));
        
        // 2. Transform / Map (Select)
        var squares = numbers.Select(n => n * n);
        Console.WriteLine("Squares: " + String.Join(", ", squares));
        
        // 3. Sorting (OrderBy)
        var descending = numbers.OrderByDescending(n => n);
        Console.WriteLine("Descending: " + String.Join(", ", descending));
        
        // 4. Counting
        int countEven = numbers.Count(n => n % 2 == 0);
        Console.WriteLine("Count of even numbers: " + countEven);
        
        // 5. Grouping
        var grouped = numbers.GroupBy(n => n % 2 == 0 ? "Even" : "Odd");
        Console.WriteLine("\nGrouped:");

        foreach (var group in grouped)
        {
            Console.WriteLine(group.Key + ": " + string.Join(", ", group));
        }

    }
}