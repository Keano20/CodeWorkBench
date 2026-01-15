using System;
using System.Collections.Generic;

namespace CodeWorkBench.Algorithms;

public class Sorting
{
    public static List<int> BubbleSort(List<int> numbers)
    {
        for (int i = 0; i < numbers.Count - 1; i++)
        {
            for (int j = 0; j < numbers.Count - 1; j++)
            {
                if (numbers[j] > numbers[j + 1])
                {
                    // Swap Via deconstruction
                    //(numbers[j], numbers[j + 1]) = (numbers[j + 1], numbers[j]);
                    
                    // Traditional swap
                    int temp = numbers[j];
                    numbers[j] = numbers[j + 1];
                    numbers[j + 1] = temp;
                }
            }
        }
        return numbers;
    }
    
    public static void Demo()
    {
        List<int> input = new List<int> { 16, 5, 3, 8, 4, 2, 11 };
        List<int> sorted = BubbleSort(new List<int>(input));

        Console.WriteLine("Original: " + string.Join(", ", input));
        Console.WriteLine("Sorted:   " + string.Join(", ", sorted));
    }
}
