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
            // stores the longest word
            string maxLengthWord = "";
            // splits the sentence on spaces and creates a list of the words
            List<string> words = sen.Split(' ').ToList();
            foreach (string word in words)
            {
                // Parses each word for any characters that are not letters
                string parsedWord = Regex.Replace(word, @"[\W_]", string.Empty);
                // This if statement sets the maxLengthWord to the last word of equal length Ex. Walk the dogs will return dogs
                if (parsedWord.Length == maxLengthWord.Length)
                {
                    maxLengthWord = parsedWord;
                }
                // sets the maxLengthWord to the parsedword if it has a greater length
                else if (parsedWord.Length > maxLengthWord.Length)
                {
                    maxLengthWord = parsedWord;
                }
            }
            return maxLengthWord;
        }

        public static int FirstFactorial(int num) 
        { 
            int factorial = 1;
            for(var i = 1; i <= num; i++ )
            {
                factorial = factorial * i;
            }
            return factorial;
         }
    }
}
