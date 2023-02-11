using Inception;
// See https://aka.ms/new-console-template for more information

PeselDateExtractor extractor = new PeselDateExtractor();
DateTime extractedDate = extractor.ExtractDate("92040907689");
Console.WriteLine(extractedDate);
//hooray!


Console.WriteLine("Hello, World!");

Generator gen = new Generator();
gen.GetCode();

Console.WriteLine(Utils.GenerateRandomString(10));
Console.WriteLine(Utils.GenerateWordBackwards("Bartus"));
