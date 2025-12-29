namespace CodeWorkBench.Algorithms;

public class Iteration
{
    public static int FindMax()
    {
       List<int> numbers = new List<int> {3, 7, 2, 9, 4};

       int largest = numbers[0];

       for (int i = 0; i < numbers.Count; i++)
       {
           if (numbers[i] > largest)
           {
               largest = numbers[i];
           }
       }

       return largest;
    }
}