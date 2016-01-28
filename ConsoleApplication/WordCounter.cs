namespace ConsoleApplication
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text.RegularExpressions;

    public class WordCounter
    {
        private readonly string text;

        private Dictionary<string, int> dictionary;

        public WordCounter()
        {
            Console.WriteLine("Please enter text:");
            this.text = Console.ReadLine();
        }

        public WordCounter(string text)
        {
            this.text = text;
        }

        public void DisplayAll()
        {
            this.Count();

            if (this.dictionary == null || !this.dictionary.Any())
            {
                Console.WriteLine("You've entered empty string!");
                Console.WriteLine();
                return;
            }

            foreach (KeyValuePair<string, int> pair in this.dictionary)
            {
                Console.WriteLine("{0} {1}", pair.Key, pair.Value);
            }

            Console.WriteLine();
        }

        public Dictionary<string, int> GetDictionary()
        {
            return this.dictionary;
        }

        public void Count()
        {
            Regex regex = new Regex("\\w+");
            var frequencyList = regex.Matches(this.text)
                .Cast<Match>()
                .Select(c => c.Value.ToLowerInvariant())
                .GroupBy(c => c)
                .Select(g => new { Word = g.Key, Count = g.Count() })
                .OrderByDescending(g => g.Count)
                .ThenBy(g => g.Word);
            this.dictionary = frequencyList.ToDictionary(d => d.Word, d => d.Count);
        }
    }
}
