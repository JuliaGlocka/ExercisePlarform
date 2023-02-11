using System;
namespace TrainingSpace
{
	public class VowelsandConsonants
	{
        string vowel = "aeyuio";
		string consonant = "qwrtpsdfghjklzxcvbnm";

		public string VowelsConsonants(int min, int max) 
		{
			string output = "";
			Random rnd = new();
			/*
            int rndvowel = rnd.Next(vowel.Length);
			Random rndc = new();
			int rndconsonant = rnd.Next(consonant.Length);
			*/
			int length = rnd.Next(min, max);

			for (int i = 0; i < length; i++)
			{
				if (i % 2 == 0)
				{
					output += vowel[rnd.Next(0, vowel.Length - 1)];
				}

				else
				{
					output += consonant[rnd.Next(0, consonant.Length - 1)];
				}
			}
			return output;
        }
    }
}

