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
        // The solution to the First Factorial problem on coderbyte
        public static int FirstFactorial(int num) 
        { 
            int factorial = 1;
            // For loop to iterate until reaching the number passed in
            for(var i = 1; i <= num; i++ )
            {
                factorial = factorial * i;
                // factorial *= i should work the same
            }
            return factorial;
         }
         // The solution to the Simple Adding problem on codebyte
           public static int SimpleAdding(int num) {
               int sum = 0;
               // For loop to add to a total until the passed in number is reached in the loop
                for(var i = 1; i <= num; i++)
                {
                    sum += i;
                }
            return sum;
            
          }
    }
}
