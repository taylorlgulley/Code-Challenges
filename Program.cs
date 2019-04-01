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

          // Two solutions for the Letter Capitalize problem on coderbyte
          public static string LetterCapitalize(string str) 
          { 
               // this way required using System.Globalization to use ToTitleCase to upper case the first letter of each word
               //string capitalized = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(str);

                // create empty string to add new string to
                string str2 = "";
                // split the passed in string on the spaces
                var words = str.Split(' ');

                foreach (string word in words)
                {
                    // Loop over each word, take the first character of each word and upper case it then concatenate it with the Substring of word taken after the first character. Also add a space to the end and add it all to str2. 
                    str2 += (char.ToUpper(word[0]) + word.Substring(1) + " ");
                }
                // Remove the final space after the last word
                str = str2.Trim();

            return str;
          }

          // Two solutions for the First Reverse problem on coderbyte
          public static string FirstReverse(string str) { 
            
            // split the string into an array of chars, then reverse the array
            var array = str.ToCharArray();
            Array.Reverse(array);
            // use a string contructor to turn the array of chars into a string and retunr it
            return new string(array);

            // create an empty string
           // string reverse = String.Empty;
    
           //do a for loop running backwards to add characters to the empty string starting from the end of the original string(by bracket notation like an array)
            /*for (int i = str.Length - 1; i >= 0; i--)
            {
                reverse += str[i];
            }
            return reverse;*/
            
          }

          // A Solution to the FizzBuzz problem
          public static string FizzBuzz() {
          
              // A for loop to interate over each number from 1 to 100
              for (var i = 1; i <= 100; i++)
              {
                    // If and if else statements to log statements if the numbers is divisible by 3 or 5, the if statement for if it is divisible by both must come first otherwise it will stop if it matches one of the conditions
                    if (i % 3 = 0 && i % 5 = 0)
                    {
                        Console.WriteLine("FizzBuzz");
                    }
                    else if (i % 3 = 0)
                    {
                        Console.WriteLine("Fizz");
                    }
                    else if (i % 3 = 0)
                    {
                        Console.WriteLine("Buzz");
                    }
                    else
                    {
                        Console.WriteLine(i);
                    }
              }
          }
    }
}
