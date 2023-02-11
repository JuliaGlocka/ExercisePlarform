using System;
namespace TrainingSpace
{
	
	public static class TextOperations
	{
		//metoda pierwsza
		public static bool FindStringInString(string sourcetext, string findtext)
		{
			for(int i = 0, j = 0; i < sourcetext.Length -1; i++)
			{
				if (sourcetext[i] == findtext[j])
				{
					if (j == findtext.Length - 1)
					{
						return true;
					}
					j++;
				}
				else
				{
					j = 0;
				}
			}
			return false;
		}
		//metoda druga
		public static int FindStringInStringTwo(string sourcetext, string findtext)
		{
			int result = 0;
			for (int i = 0, j = 0; i < sourcetext.Length - 1; i++)
			{
				if (sourcetext[i] == findtext[j])
				{
					if (j == findtext.Length - 1)
					{
						return i - j;
					}
					j++;
				}
				else
				{
					j = 0;
				}
			}
			return result;
		}
		//zamień
		public static int ChangeCharactersWhenFindString(string sourcetext, string findtext, string inputtext)
		{
			string result = string.Empty;
			for (int i = 0, j = 0; i < sourcetext.Length - 1; i++)
			{
				if (sourcetext[i] == findtext[j])
				{
					if (j == findtext.Length - 1)
					{
						return i - j;
					}
					j++;
				}
				else
				{
					j = 0;
				}
			}
			return 0;
			// return sourcetext - findtext + inputtext;
		}
    }
}

