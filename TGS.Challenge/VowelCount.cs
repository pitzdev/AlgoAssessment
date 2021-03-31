using System;

namespace TGS.Challenge
{
    /*
        Devise a function that takes a string & returns the number of 
        vowels (aeiou) in that string.

        "Hi there!" = 3
        "What do you mean?"  = 6

        There are accompanying unit tests for this exercise, ensure all tests pass & make
        sure the unit tests are correct too.
     */
    public class VowelCount
    {
        public int Count(string value)
        {
            int vowelCount = 0;
            if (value.Length == 0)
            {
                throw new ArgumentException();
            }
            value = value.ToLower();
            for(int i= 0; i < value.Length; i++)
            {
                char c = value[i];
                if(c.Equals('a') || c.Equals('e') || c.Equals('i') || c.Equals('o') || c.Equals('u'))
                {
                    vowelCount++;
                }
            }
            return vowelCount;
        }
    }
}
