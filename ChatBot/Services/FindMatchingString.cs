using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ChatBot.Services
{
    public class FindMatchingString
    {
        public static bool findMatchingString(string inputWord, string[] matchingWords)
        {

            bool found = false;

            string[] words = new string[] { };
            words = inputWord.ToLowerInvariant().Split(new char[] { ' ' });

            for (int i = 0; i < words.Length; i++)
            {
                for (int j = 0; j < matchingWords.Length; j++)
                {
                    if (words[i] == matchingWords[j].ToLower())
                        found = true;
                }
            }

            return found;
        }
    }
}