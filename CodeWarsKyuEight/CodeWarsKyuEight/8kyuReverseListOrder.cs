using System;
using System.Collections.Generic;
namespace CodeWarsKyuEight;


public class ReverseListOrder
{
    public static List<int> ReverseList(List<int> list)
    {
        List<int> listreversed = new List<int> ();

        for (int i = list.Count - 1; i >= 0; i--)
        {
            listreversed.Add(list[i]);
        }

        // Return a new list with its elements in reverse order compared to the input list
        // Do not mutate the original list!
        return listreversed;

    }
}

/*
II Solution below:

using System.Collections.Generic;
using System.Linq;

public class Kata
{
    public static List<int> ReverseList(List<int> list)
    {
        return Enumerable.Reverse(list).ToList();
    }
}



*/