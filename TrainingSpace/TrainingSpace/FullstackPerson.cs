using System;
namespace TrainingSpace
{
	class FullstackPerson
	{
		//pola wartości obiektu
		public string Name; //niedobra praktyka pole jako publiczne, ale o tym później
		//metody interakcje obiektu

		//deklaracja nowego obiekty TYP FullstackPerson
		//konstruktor - metoda ktora ywkonywana jest podczas wykonywania

		//chcemy przypisać wartość przekazywaną przez konstruktor poniżej do naszego pola publicznego powżyej
		public FullstackPerson(string Name)
		{
			// identyczna nazwa pola oraz parametru ^ przypisywanie wartości na tej samej zmiennej, tu błąd, nazwy nie mogą być identyczne, to nie ma sensu
			//Name = Name;
			this.Name = Name;

			//słowo kluczowe this reprezentuje konkretny obiekt a właściwość Name będziy się w stanie odnieść do naszego pola publiczego Name - przypiszemy w konstruktorze wartość do pola Name
			//w klasie FullstackDesignPatterns pokaże się błą∂ kompilacji, jeżeli w Fullstackperson = new Person() nie pojawi się wartość new Person ("Kuba") [nasz konstruktor oczekuje wartości typu string]

			//dodatkowa klasa publiczna

			
		}
        public void SayHi()
        {
            Console.WriteLine("Hello, my name is" + this.Name);
        }
        //w FullstackDesignPatterns wywołujemy tę metodę
    }
}

