namespace BddProject
{
    using System.Collections.Generic;
    using System.Linq;

    using ConsoleApplication;

    using Microsoft.VisualStudio.TestTools.UnitTesting;

    using TechTalk.SpecFlow;

    [Binding]
    public class TestSteps
    {
        private WordCounter wordCounter;


        [Given(@"a sentence ""(.*)""")]
        public void GivenASentence(string p0)
        {
            this.wordCounter = new WordCounter(p0);
            ScenarioContext.Current.Pending();
        }
        
        [When(@"the program is run")]
        public void WhenTheProgramIsRun()
        {
            this.wordCounter.Count();
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"I'm returned a distinct list ""(.*)""")]
        public void ThenIMReturnedADistinctList(string p0)
        {
            var dictionary = new Dictionary<string, int>();

            Assert.IsTrue(dictionary.SequenceEqual(this.wordCounter.GetDictionary()), "Error");
            ScenarioContext.Current.Pending();
        }
    }
}
