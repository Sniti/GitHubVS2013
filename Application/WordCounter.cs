namespace Application
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
            this.text = Console.ReadLine();
        }

        public WordCounter(string text)
        {
            this.text = text;
        }

        private void Count()
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
