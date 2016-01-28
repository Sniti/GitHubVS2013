namespace MyProject.Specs
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    using ConsoleApplication;

    using Microsoft.VisualStudio.TestTools.UnitTesting;

    using TechTalk.SpecFlow;

    [Binding]
    public class CounterSteps
    {
        private Dictionary<string, int> dictionary = new Dictionary<string, int>();
        private WordCounter wordCounter;

        [Given(@"I have entered ""(.*)""")]
        public void GivenIHaveEntered(string sentence)
        {
            this.wordCounter = new WordCounter(sentence);
        }

        [When(@"I run application")]
        public void WhenIRunApplication()
        {
            this.wordCounter.Count();
        }

        [Then(@"the result should be ""(.*)""")]
        public void ThenTheResultShouldBe(string values)
        {
            string[] stringSeparators = { ", " };

            if (values != string.Empty)
            {
                foreach (string source in values.Split(stringSeparators, StringSplitOptions.None).ToList())
                {
                    this.dictionary.Add(source.Split(' ')[0], Convert.ToInt32(source.Split(' ')[1]));
                }
            }

            Assert.IsTrue(!this.dictionary.Except(this.wordCounter.GetDictionary()).Any(), "Error");
        }
    }
}
