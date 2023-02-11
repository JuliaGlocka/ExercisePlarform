using System;
namespace Inception
{
    public class Stemming
    {
        public Stemming()
        {
            IDictionary<int, string> sprawiedliwość = new Dictionary<int, string>();
            sprawiedliwość.Add(1, "sprawiedliwy"); //adding a key/value using the Add() method
            sprawiedliwość.Add(2, "sprawiedliwa");
            sprawiedliwość.Add(3, "sprawiedliwości");


            foreach (KeyValuePair<int, string> sample in sprawiedliwość)
            {
                Console.WriteLine(sample.Value.ToString());
            }
        }
    }
}