using Microsoft.VisualStudio.TestTools.UnitTesting;
using WordUnscrambler.Workers;

namespace WordUnscrambler.Test.Unit
{
    [TestClass]
    public class WordMatcherTest
    {
        private readonly WordMatcher _wordMatcher = new WordMatcher();

        [TestMethod]
        public void ScrambledWordMatchesGivenWordInTheList()
        {
            string[] words = { "cat", "chair", "more", "should" };
            string[] scrambledWords = { "omre" };
            var matchedWords = _wordMatcher.Match(scrambledWords, words);

            Assert.IsTrue(matchedWords.Count == 1);
            Assert.IsTrue(matchedWords[0].ScrambledWord.Equals("omre"));
            Assert.IsTrue(matchedWords[0].Word.Equals("more"));
        }

        [TestMethod]
        public void ScrambledWordMatchesGivenWordsInTheList()
        {
            string[] words = { "cat", "chair", "more", "should" };
            string[] scrambledWords = { "omre", "act", "holdus" };

            var matchedWords = _wordMatcher.Match(scrambledWords, words);

            Assert.IsTrue(matchedWords.Count == 3);
            Assert.IsTrue(matchedWords[0].ScrambledWord.Equals("omre"));
            Assert.IsTrue(matchedWords[0].Word.Equals("more"));
            Assert.IsTrue(matchedWords[1].ScrambledWord.Equals("act"));
            Assert.IsTrue(matchedWords[1].Word.Equals("cat"));
            Assert.IsTrue(matchedWords[2].ScrambledWord.Equals("holdus"));
            Assert.IsTrue(matchedWords[2].Word.Equals("should"));

        }
    }
}
