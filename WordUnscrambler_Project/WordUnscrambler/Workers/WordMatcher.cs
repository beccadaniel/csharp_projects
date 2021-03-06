﻿using System;
using System.Collections.Generic;
using WordUnscrambler.Data;

namespace WordUnscrambler.Workers
{
    public class WordMatcher
    {
        public List<MatchedWords> Match(string[] scrambledWords, string[] wordList)
        {
            var matchedWords = new List<MatchedWords>();

            foreach (var scrambledWord in scrambledWords)
            {
                foreach (var word in wordList)
                {
                    if (scrambledWord.Equals(word, StringComparison.OrdinalIgnoreCase))
                    {
                        matchedWords.Add(BuildMatchedWord(scrambledWord, word));
                    }
                    else
                    {
                        var scrambledWordArray = scrambledWord.ToCharArray();
                        var wordArray = word.ToCharArray();

                        Array.Sort(scrambledWordArray);
                        Array.Sort(wordArray);

                        var sortedScrambledWord = new string(scrambledWordArray);
                        var sortedWord = new string(wordArray);

                        if (sortedScrambledWord.Equals(sortedWord, StringComparison.OrdinalIgnoreCase))
                        {
                            matchedWords.Add(BuildMatchedWord(scrambledWord, word));
                        }
                    }
                }
            }

            return matchedWords;
        }

        private MatchedWords BuildMatchedWord(string scrambledWord, string word)
        {
            MatchedWords matchedWord = new MatchedWords
            {
                ScrambledWord = scrambledWord, Word = word
            };
            return matchedWord;
        }
    }
}
