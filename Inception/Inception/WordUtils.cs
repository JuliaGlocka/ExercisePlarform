using System;
namespace Inception
{//poziom klasy
    public class LetterCountEntity
    {
        public string Word { get; set; }
        public int Count { get; set; }
        public char Letter { get; set; }
    }
 //poziom klasy
    public static class WordsUtils //LetterCountEntity to encja
    {
        public static LetterCountEntity GetHighestLetterCount(LetterCountEntity[] elements) //metoda statyczna z typem zwracanym referencyjnym LetterCountEntity, parametr tablica
        {
            int max = 0; //zmienna max
            LetterCountEntity highest = new LetterCountEntity(); //zmienna highest, konstruktor

            foreach (LetterCountEntity element in elements) //dla każdego elementu w tablicy elements, elements to lista słów, element to słowo
            {
                int result = LetterCount(element.Word, element.Letter); // z linii 33

                if (result > max) //jeśli result > max  
                {
                    highest = element; 
                    max = result;
                    highest.Count = result;  
                }
            }

            return highest; // ta metoda zwraca wynik ilości liter, które powtórzyły się w jednym ze słów z elements największa ilość razy
        }
 //poziom metody
        private static int LetterCount(string word, char letter)
        {
            int count = 0;

            foreach (char character in word)
            {
                if (character == letter) // word ziemniak, letter z, count 1 
                {
                    count++;
                }
            }

            return count; //TO JEST NAZWA ARBITRALNA która może równie dobrze być taka sama jak np. nazwa metody
        }
    }
}
