using System;
namespace TrainingSpace
{
	class FullstackDesignPatterns
	{
		static void Main(string[] args)
		{
			FullstackPerson person = new FullstackPerson("Kuba");

			// person.Name = "Kuba"; //lub kosntruktor w klasie FullstackPerson

			//usuwamy ->	Console.WriteLine(person.Name); wywołyjemy SayHi
			person.SayHi();

			
		}
	}
}

//powiązanie bezpośrednie klas, COUPLING, metryka kodu o powiązanie statyczne = im mniejszy COUPLING tym lepszy kod
//jeżeli klasy są barszo COUPLING -> zmiana w 1. przekompilować 2. zmiana kompilacji, błąd kompilacji