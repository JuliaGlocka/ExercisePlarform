using System;
namespace CodeWarsKyuEight;
//Bug Fixing #5
public static class KataFive
{
    public static string buildString(string[] args)
    {
        return String.Format("I like {1}!", String.Join(",", args));
    }
}