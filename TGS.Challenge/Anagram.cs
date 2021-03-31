using System.Text.RegularExpressions;
namespace TGS.Challenge
{
  /*
        Devise a function that checks if 1 word is an anagram of another, if the words are anagrams of
        one another return true, else return false

        "Anagram": An anagram is a type of word play, the result of rearranging the letters of a word or
        phrase to produce a new word or phrase, using all the original letters exactly once; for example
        orchestra can be rearranged into carthorse.

        areAnagrams("horse", "shore") should return true
        areAnagrams("horse", "short") should return false

        NOTE: Punctuation, including spaces should be ignored, e.g.

        horse!! shore = true
        horse  !! shore = true
          horse? heroes = true

        There are accompanying unit tests for this exercise, ensure all tests pass & make
        sure the unit tests are correct too.
     */
    public class Anagram
    {
      public bool AreAnagrams(string word1, string word2)
      {
             
            word1 = Regex.Replace(word1, @"[^0-9a-zA-Z]+", string.Empty).ToLower();
            word2 = Regex.Replace(word2, @"[^0-9a-zA-Z]+", string.Empty).ToLower();

            if (word1.Length ==0 || word2.Length == 0)
            {
                throw new System.ArgumentException();
            }
            if (word1.Length != word2.Length) return false;

                int word1Count = 0;
            int word2Count = 0;

            for(int i = 0; i < word1.Length -1; i++)
            {
                word1Count++;
                word2Count = word1.Length - 1;
                if(word2.Contains(word1[i]) && word1Count == word2Count)
                {
                    return true;
                }

            }

        return false;
      }
    }
}
