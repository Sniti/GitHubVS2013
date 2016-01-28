namespace UnitTestProject
{
    using System.Collections.Generic;
    using System.Linq;

    using ConsoleApplication;

    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class WordCounterTest
    {
        /// <summary>
        /// Checks usual method
        /// </summary>
        [TestMethod]
        public void TestMethod1()
        {
            var dictionary = new Dictionary<string, int>
                              {
                                  { "is", 2 },
                                  { "this", 2 },
                                  { "a", 1 },
                                  { "and", 1 },
                                  { "so", 1 },
                                  { "statement", 1 }
                              };

            WordCounter text = new WordCounter("This is a statement, and so is this.");
            text.Count();
            Assert.IsTrue(!dictionary.Except(text.GetDictionary()).Any(), "Error");
        }

        /// <summary>
        /// Checks empty sentence
        /// </summary>
        [TestMethod]
        public void TestMethod2()
        {
            var dictionary = new Dictionary<string, int>();

            WordCounter text = new WordCounter(string.Empty);
            text.Count();
            Assert.IsTrue(!dictionary.Except(text.GetDictionary()).Any(), "Error");
        }

        /// <summary>
        /// Checks sentence with numbers
        /// </summary>
        [TestMethod]
        public void TestMethod3()
        {
            var dictionary = new Dictionary<string, int>
                              {
                                  { "123", 2 },
                                  { "21312", 1 },
                                  { "2452", 1 }
                              };

            WordCounter text = new WordCounter("21312 2452 123 123!!$$%#$^&$%");
            text.Count();
            Assert.IsTrue(!dictionary.Except(text.GetDictionary()).Any(), "Error");
        }
    }
}
