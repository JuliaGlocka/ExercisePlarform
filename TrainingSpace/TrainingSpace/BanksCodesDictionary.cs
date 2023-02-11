using System;
namespace TrainingSpace
{
	public class BanksCodesDictionary
	{
		protected Dictionary<string, string> BanksCodesMap = new Dictionary<string, string>();

		public BanksCodesDictionary()
		{
			string filecontent = File.ReadAllText("../../../BanksCodes.txt");
			ParseFileContent(filecontent);
		}

		protected virtual void ParseFileContent(string filecon)
		{
			string[] entries = filecon.Split(Environment.NewLine); // "\n"

			foreach(string entry in entries)
			{
				string[] record = entry.Split("\t");

				if (record.Length == 2)
				{
					BanksCodesMap.Add(record[0].Trim(), record[1]);
				}
			}
		}

		public virtual string GetBankName(string account)
		{
			string codeCandidate = account.Substring(2, 4);

			if (BanksCodesMap.ContainsKey(codeCandidate))
			{
				return BanksCodesMap[codeCandidate];
			}

			return string.Empty;
		}
	}
}

