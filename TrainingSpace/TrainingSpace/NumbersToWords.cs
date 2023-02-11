using System;
namespace TrainingSpace
{
	public class NumbersToWords
	{
		protected static string[] words = new[] { "zero", "jeden" };
		public static string NumbersWords(int number)
		{
			string result = "";
			string num = number.ToString();
			foreach (char c in num)
			{
				int i = int.Parse(c.ToString());
				result += words[i] + " ";
            }
			return result;

		}

		protected static string[] wordsmore = new[] { "jeden", "dwa", "trzy", "cztery", "pięć", "sześć", "siedem", "osiem", "dziewięć", "dziesięć", "jedenaście", "dwanaście", "trzynaście", "czternaście", "piętnaście", "szesnaście", "siedemnaście", "osiemnaście", "dziewiętnaście", "dwadzieścia", "trzydzieści", "czterdzieści", "piećdziesiąt", "sześćdziesiąt", "siedemdziesiąt", "osiemdziesiąt", "dziewięćdziesiąt", "sto", "dwieście", "trzysta", "czterysta", "pięćset", "sześćset", "siedemset", "osiemset", "dziewięćset", "tysiąc" };
		public static string NumbersWordsMore(int number)
		{
			string result = "";
			string num = number.ToString();
			foreach (char c in num)
			{
				int i = int.Parse(c.ToString());
				result += words[i] + " ";
			}
			return result;
		}
	}
}

/* 
 * if (num.Length == 3) ALBO amiast drugiego IF && (num ==1) ALBO (num = number.ToString("1")
	{
			{
				if (num == 1)           ALBO if (num = number.ToString("1")
			}

		num[0] = number.ToString() == "sto"
	}

*/