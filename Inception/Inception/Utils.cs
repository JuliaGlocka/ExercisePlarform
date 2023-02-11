using System;
namespace Inception
{
	public static class Utils
	{
		public static string GenerateRandomString(int length)
		{
			string letter = "azxcvbnmsdfghjklqwertyuio";

			Random rnd = new Random();
			string result = string.Empty;

			for (int i = 0; i < length - 1; ++i)
			{
				result += letter[rnd.Next(0, letter.Length -1)];
			}

			return result;
		}

		public static string GenerateWordBackwards(string input)
		{
			string result = "";
			for (int i = input.Length -1; i >= 0 ; i--)
			{
				result += input[i];
			}
			return result;
		}
	}
}

