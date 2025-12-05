using System;

namespace CodeWorkBench.Strings;

public static class StringUtilities
{
    public static string Reverse(string input)
    {
        if (string.IsNullOrEmpty(input))
            return input;

        char[] letters = input.ToCharArray();
        Array.Reverse(letters);
        return new string(letters);
    }
}