using System;
using System.Linq;

public static class Kata
{
    public static void Main()
    {
        var test = Solution("The world is round");
        Console.WriteLine(test);
    }
    public static string Solution(string str)
    {
        // Converts the string to an Char array
        char[] charArray = str.ToCharArray();
        // Reverses said array
        Array.Reverse(charArray);
        // Prints reversed array as a string.
        return new string(charArray);  
    }
}
