using System;
namespace CodeWarsKyuEight;
using System.Text.RegularExpressions;

public class KataFourtyFour
{
    public static string Shortcut(string input)
    {
        input = Regex.Replace(input, "[aeiouAEIOU]", "");
        return input;
    }
}
