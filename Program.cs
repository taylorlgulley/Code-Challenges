using System;

namespace CodeChallenges
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        // The solution to the Longest Word problem on coderbyte
        // Refactor this solution to either use linq instead or remove the int because you can use .length in the if statement
        public static string LongestWord(string sen)
        {
            string maxLengthWord = "";
            List<string> words = sen.Split(' ').ToList();
            foreach (string word in words)
            {
                string parsedWord = Regex.Replace(word, @"[\W_]", string.Empty);
                if (parsedWord == maxLengthWord)
                {
                    maxLengthWord = parsedWord;
                }
                else if (parsedWord.Length > maxLengthWord.Length)
                {
                    maxLengthWord = parsedWord;
                }
            }
            return maxLengthWord;
        }
    }
}
