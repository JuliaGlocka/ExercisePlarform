using System;
namespace CodeWarsKyuEight;

public class SolutionClassZero
{
   public static string EvenOrOdd(int number)
    {
        string output = "";
        if (number % 2 == 0)
        {
            output = "even";
        }

        else
        {
            output = "odd";
        }
        // Code goes here ...
        return output;
    }
}