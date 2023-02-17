using System;
namespace CodeWarsKyuEight;

public class KataOne
{
    public static List<int> CreateList(int number)
    {
        List<int> list = new List<int>();

        for (int counter = 1; counter <= number; ++counter)
        {
            list.Add(counter);
        }

        return list;
    }
}
