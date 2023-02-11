using System;

namespace Inception
{
    public class PeselDateExtractorNoSpaghetti
    {
        public DateTime ExtractDate(string pesel)
        {
            string yearPart = pesel.Substring(0, 2);
            string monthPart = pesel.Substring(2, 2);
            string dayPart = pesel.Substring(4, 2);

            int year = int.Parse(yearPart) + 2000;
            int month = int.Parse(monthPart);
            int day = int.Parse(dayPart);

            return new DateTime(year, month, day, 0, 0, 0, DateTimeKind.Unspecified);
        }
    }
}
