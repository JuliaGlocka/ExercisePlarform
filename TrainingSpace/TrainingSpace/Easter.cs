using System;
namespace TrainingSpace
{
	public class Easter
	{
		public static DateTime EasterDate(int year)
		{
			int A = 24;
			int B = 5;
			int a = year % 19;
			int b = year % 4;
			int c = year % 7;
			int d = (a*19 +A) % 30;
			int e = (2 * b + 4 * c + 6 * d + B) % 7;
			DateTime wielkanoc = new DateTime(year, 3, 22).AddDays(d + e);

			return wielkanoc;
		}
		public static void CreateEasterDateInterval()
		{
			int beginyear = 1900;

			string result = "";
			for (; beginyear < 2050; beginyear++)
			{
				result += EasterDate(beginyear) + Environment.NewLine;
			}
			File.WriteAllText("./Easter.txt", result);
		}
	}
}




/*http client - wstep do pisania proxy restowych api (obejrzyj FILM!!!)
base 64 encoding obrazkow*/