namespace CodeWorkBench.Strings;

public static class  StringDemo
{
    public static void run()
    {
        string example = "John";
        string reversed = StringUtilities.Reverse(example);
        
        Console.WriteLine($"Original: {example}");
        Console.WriteLine($"Reversed: {reversed}");
    }
}