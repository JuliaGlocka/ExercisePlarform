using System;

namespace Inception
{
    public class PeselDateExtractor
    {
        public DateTime ExtractDate(string pesel)
        {
            string yearPart = pesel.Substring(0, 2);
            string monthPart = pesel.Substring(2, 2);
            string dayPart = pesel.Substring(4, 2);

            int year = int.Parse(yearPart) ; //usnięte + 2000 !!! :)
            int month = int.Parse(monthPart);
            int day = int.Parse(dayPart);

            if (month > 80)
            {
                month = month - 80;
                year = year + 1800;
            }
            else if (month > 60)
            {
                month = month - 60;
                year = year + 2200;
            }
            else if (month > 40)
            {
                month = month - 40;
                year = year + 2100;
            }
            else if (month > 20)
            {
                month = month - 20;
                year = year + 2000;
            }
            else
            {
                year = year + 1900;
            }

            // uwzględnij lata przestępne
            bool isLeap = DateTime.IsLeapYear(year);
            if (isLeap && month == 2 && day == 29)
            {
                return new DateTime(year, month, day, 0, 0, 0, DateTimeKind.Unspecified);
            }
            else if (!isLeap && month == 2 && day == 28)
            {
                return new DateTime(year, month, day, 0, 0, 0, DateTimeKind.Unspecified);
            }
            else
            {
                return new DateTime(year, month, day, 0, 0, 0, DateTimeKind.Unspecified);
            }
        }
    }
}



/* using System;
namespace Inception
{
    public class PeselDateExtractor
    {
        public DateTime ExtractDate(string pesel)
        {
            DateTime frompesel = new DateTime();

            string year = pesel.Substring(0, 2);
            string month = pesel.Substring(2, 2);
            string day = pesel.Substring(4, 2);

            int Year = int.Parse(year);
            int Month = int.Parse(month);
            int Day = int.Parse(day);

            if (Month > 80)
            {
                Month = Month - 80;
                Year = Year + 1800;
            }
            else if (Month > 60)
            {
                Month = Month - 60;
                Year = Year + 2200;
            }
            else if (Month > 40)
            {
                Month = Month - 40;
                Year = Year + 2100;
            }
            else if (Month > 20)
            {
                Month = Month - 20;
                Year = Year + 2000;
            }
            else
            {
                Year = Year + 1900;
            }

            Month = Month - 1;

            if (Month == 2 && Day > 28)
            {
                if (DateTime.IsLeapYear(Year))
                {
                    Day = 29;
                }
                else
                {
                    Day = 28;
                }
            }
            else if ((Month == 4 || Month == 6 || Month == 9 || Month == 11) && Day == 31)
            {
                Day = 30;
            }

            return new DateTime(Year, Month, Day, 0, 0, 0, frompesel.Kind);

        }

    }
}
*/

/*QUEST!!! Masz zablokować > 13 dla mies. oraz sty > 31, rok normalny luty > 28, przestepny > 19 ...  //wygenerowac $limit peseli, ktora mają walidującą się date np 50
konstruktor od klasy/typu Random /*


/*
Wyjaśnij bardo dokładnie krok po kroku co oznacza ten kod if (Month > 80)
			{
				Month = Month - 80;
				Year = Year + 1800;
			}
			else if (Month > 60)
			{
				Month = Month - 60;
				Year = Year + 2200;
			}
			else if (Month > 40)
			{
				Month = Month - 40;
				Year = Year + 2100;
			}
			else if (Month > 20)
			{
				Month = Month - 20;
				Year = Year + 2000;
			}
			else
			{
				Year = Year + 1900;
			}

			Month = Month - 1;

Kod jest fragmentem programu, który jest odpowiedzialny za wyciąganie informacji o dacie urodzenia z numeru PESEL. W Polsce, numer PESEL jest numerem identyfikacyjnym, który jest wygenerowany dla każdej osoby i zawiera informacje o dacie urodzenia.

Jeśli miesiąc jest większy niż 80, oznacza to, że data urodzenia należy do okresu od 1 stycznia 1800 roku do 31 grudnia 1899 roku. W takim przypadku, aby uzyskać prawidłowy miesiąc, należy odjąć 80 od wartości miesiąca i dodać 1800 do roku.

Podobnie, jeśli miesiąc jest większy niż 60, oznacza to, że data urodzenia należy do okresu od 1 stycznia 2200 roku do 31 grudnia 2299 roku. W takim przypadku, aby uzyskać prawidłowy miesiąc, należy odjąć 60 od wartości miesiąca i dodać 2200 do roku.

Kolejne warunki (Month > 40 i Month > 20) oznaczają, że data urodzenia należy do okresu od 1 stycznia 2100 roku do 31 grudnia 2199 roku lub od 1 stycznia 2000 roku do 31 grudnia 2099 roku, odpowiednio. W tych przypadkach, należy odjąć 40 lub 20 od wartości miesiąca i dodać 2100 lub 2000 do roku, aby uzyskać prawidłowe wartości.

Jeśli żaden z tych warunków nie jest spełniony, oznacza to, że data urodzenia należy do okresu od 1 stycznia 1900 roku do 31 grudnia 1999 roku. W takim przypadku, należy dodać 1900 do roku.

Ostatnia linijka odpowiedzialna jest za zmniejszenie wartości miesiąca o 1, ponieważ .NET używa indeksów miesięcy od 0 do 11, podczas gdy standardowy kalendarz używa indeksów miesięcy od 1 do 12.

*/