﻿using System;
using System.Collections.Generic;
namespace CodeWarsKyuEight;



public static class FilterGoose
{
    public static IEnumerable<string> GooseFilter(IEnumerable<string> birds)
    {
        // return IEnumerable of string containing all of the strings in the input collection, except those that match strings in geese
        string[] geese = new string[] { "African", "Roman Tufted", "Toulouse", "Pilgrim", "Steinbacher" };

        return geese;
    }
}

