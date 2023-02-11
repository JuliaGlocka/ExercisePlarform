using System;
namespace TrainingSpace
/*https ://www.youtube.com/watch?v=SFMVyiJ2S6g advanced chessboard
       idealne do wyświeytlania tablic są zawsze pętle
        attempt tablica dwuwymiarowa, pętla => szachownica*/
{
    public class ChessboardContainer
    {
        public int[,] ChessboardTableMethod(int[,] chessboard)
        {
            int[,] mychessboard = new int[8, 8];

            chessboard[0, 0] = 0;
            chessboard[1, 0] = 1;


            //gdy suma jest parzysta = 0 else 1 -> szachownica

            for (int i = 0; i < chessboard.Length; i++)
            {
                Console.WriteLine(chessboard.Length);
            }
            return mychessboard;
        }   

    }
}

/* js double loop
var x = 0;
var y = 0;

while (x <= 8) {
    while (y <= 7) {
        if (y % 2 == 0) {
            document.write("<div class=sq2> </div>")
            ++y;
        }
        else {
            document.write("<div class=sq1> </div>")
            ++y;
       }
   }
   y = 0;
   ++x;
} */