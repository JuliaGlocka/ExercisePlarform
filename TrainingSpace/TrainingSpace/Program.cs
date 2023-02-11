// See https://aka.ms/new-console-template for more information
using NumberToWord;

using TrainingSpace;

// System.Diagnostics.Process.Start("chrome.dmg");


// Console.WriteLine("Hello, World!");
// Console.WriteLine(NumbersToWords.NumbersWords(101));
// Console.WriteLine(Easter.EasterDate(2012)); Easter.CreateEasterDateInterval();
//  Console.WriteLine(TextOperations.FindStringInStringTwo("Julxulia", "uli"));
// Console.WriteLine(NumbersToWords.NumbersWordsMore(333));

ConverterNtoW converterNtoW = new ConverterNtoW();
Console.WriteLine(converterNtoW.Convert("212"));

BanksCodesDictionary banks = new BanksCodesDictionary();

Console.WriteLine(banks.GetBankName("011160235341487120"));



// Console.WriteLine("SIŁA HASŁA =" +  PasswordUtils.PassStrength("jhsbfhbf&&&!!HHH"));