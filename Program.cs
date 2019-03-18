using System;

namespace CodeChallenges
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        public static string LongestWord(string sen)
        {
            int maxWordLength = 0;
            string maxLengthWord = "";
            List<string> words = sen.Split(' ').ToList();
            foreach (string word in words)
            {
                string parsedWord = Regex.Replace(word, @"[\W_]", string.Empty);
                int wordLength = parsedWord.Length;
                if (wordLength == maxWordLength)
                {
                }
                else if (wordLength > maxWordLength)
                {
                    maxWordLength = wordLength;
                    maxLengthWord = parsedWord;
                }
            }
            return maxLengthWord;
        }
    }
}
