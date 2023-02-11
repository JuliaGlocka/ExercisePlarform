using System;
namespace Inception
{
	public class Generator
	{
       //plik
		public Generator()
		{
		}
		//Zima -> public const string _Zima = "Zima";
		public string[] ReadTextFile()
		{
			string fileContents = File.ReadAllText("../../../Translations.txt"); //parametr ścieżka dost. do pliku
			string[] entries = fileContents.Split("\n");
			return entries;
		}
		public string GetCode()
		{
			string[] data = ReadTextFile();
			string result = string.Empty;

			foreach(string item in data)
			{
				result += $"public const string _{item} = \"{item}\";" + Environment.NewLine;
			}
			return result;
		}
	}
}


