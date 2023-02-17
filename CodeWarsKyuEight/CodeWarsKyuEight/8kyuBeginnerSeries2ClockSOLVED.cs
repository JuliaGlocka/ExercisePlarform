using System;
namespace CodeWarsKyuEight;

public static class Clock
{
    public static int? Past(int h, int m, int s)
    {
        int htom = h * 3600000;
        int mtom = m * 60000;
        int stom = s * 1000;
        //#Happy Coding! ^_^

        if ((h <= 23) && (m <= 59) && (s <= 59))
        {
            return htom + mtom + stom;
        }

        else
            return null;
    }
}

/*
0 <= h <= 23
0 <= m <= 59
0 <= s <= 59
*/