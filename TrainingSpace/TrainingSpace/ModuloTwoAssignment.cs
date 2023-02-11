/// Module Two Assignment
using System;

namespace ModuleTwoAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int column = 0; column < 8; column++)  // will create 8 row x 8 column pattern
            {
                for (int row = 0; row < 8; row++)
                {
                    if ((row + column) % 2 == 0)
                    {
                        Console.Write("1");
                    }
                    else if ((row + column) % 2 == 1)
                    {
                        Console.Write("O");
                    }
                    else
                    {
                        Console.Write("Neither 1 nor O");  // Built in unit test if logic for 1 and O fails
                    }
                }
                Console.WriteLine();
            }
        }
    }
}


/* 
Output:

1O1O1O1O
O1O1O1O1
1O1O1O1O
O1O1O1O1
1O1O1O1O
O1O1O1O1
1O1O1O1O
O1O1O1O1
*/


/// Module Two Assignment

/// For this assignment, you will create the pattern of a chess board that is 8 x 8.
/// Use X and O to represent the squares.
///     1.  Create the appropriate nested looping structure to output the characters in an 
///         8 x 8 grid on the screen using Console.Write() or Console.WriteLine() as appropriate.
///     2.  Include a decision structure to ensure that alternate rows start with opposite
///         characters as a real chess board alternates the colors among rows.

///    This is what your output should look like.
///    1O1O1O1O
///    O1O1O1O1
///    1O1O1O1O
///    O1O1O1O1
///    1O1O1O1O
///    O1O1O1O1
///    1O1O1O1O
///    O1O1O1O1

/// Grading Criteria:
///    Used a nested loop
///    Used a decision structure to flip row output
///    Output is correct per above image