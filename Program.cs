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
        // My solution needs using statements for linq, collections.generic, and text.regular expressions
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
            // This is another solution using Linq in a one line return statement
            //    return Regex.Replace(sen, @"(\p{P})", "").Split(' ').OrderByDescending(i=>i.Length).First();
            // This one is only using linq
            /*
                string[] words = sen.Split(' ');

                return words.OrderByDescending( s => s.Length ).First();;
            */
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
         /*
            // another solution to the first factorial using recursion
            public static int FirstFactorial(int num) { 
            // catches if the num is less than 1 only reutrn 1
            if (num < 1)
            {
                return 1;
            }
            // if num is greater than 1 then return num multiplied by calling the function one less than what it was before then run it again
            if (num > 1)
            {
                return num * FirstFactorial(--num);
            }
    
            return num;
            
          }
          */
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
          // another solution to the Simple Adding problem
          /*
           * if statement to check if the number is less than 1 then return 0
          if (num < 1) {
            return 0;
            }

            * a recurvive method that calls itself 
          return num + SimpleAdding(num - 1);
          */

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
            // Second solution to capitalize the first letter utilizes the system.globalization
            // How this solution does it is it uses invariant culture as well as .ToTitleCase to capitalize the first letter, additionally it uses .ToLower to make sure only the first letter will be capital
            //    return CultureInfo.InvariantCulture.TextInfo.ToTitleCase(str.ToLower());
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
              /*
              // Another solution to fizzbuzz
              for (int i = 1; i <= 100; i++)  
              {  
                // a string to hold what you will console log
                string str = ""; 
                // Add fizz to the string if it is divisible by 3
                if (i % 3 == 0)  
                {  
                    str += "Fizz";  
                }  
                // Add buzz if it is divisible by 5
                if (i % 5 == 0)  
                {  
                    str += "Buzz";  
                }
                // if it nothing has been added to the string then add the number to the string
                if (str.Length == 0)  
                {  
                    str = i.ToString();  
                }  
                // console log the string
                Console.WriteLine(str);  
              } 
              */
          }

          // A solution to the CheckNums problem
          public static string CheckNums(int num1, int num2) { 

               // Multiple if/else if statements to check what the relationship between the numbers is
               if (num2 > num1)
               {
                    return "true";   
               }
               else if (num2 < num1)
               {
                   return "false";
               }
               // If the numbers are equal return "-1"
               else
               {
                    return "-1"; 
               }
          }

          // A solution to the TimeConvert problem
          public static string TimeConvert(int num) { 
            
            // int to hold the remainder after dividing by 60 for mins
            int mins = num % 60;
            // int to hold how many times 60 can go into the number for hours
            int hours = num / 60;
            // a string to hold the time in a 1:45 format
            // could also do it in this way  string time = String.Format("{0}:{1}",hour,min); or $"{hours}:{min}"
            string convertedTime = hours + ":" + mins;
    
            return convertedTime;

            // This is an alternate solution
            /*
                int hours = 0;
                while(minutes >= 60)
                {
                    minutes -= 60;
                    hours++;
                }
                string time = hours.ToString() + ":" + minutes.ToString();
                return time;
             */
          }

          // The solution to the AlphabetSoup problem
          public static string AlphabetSoup(string str) { 
  
            // order the letters of the string in ascending order then concatenate them. this uses Linq
            string orderedString = String.Concat(str.OrderBy(c => c));

            return orderedString;

            // other way to solve
            /*
                char[] charArray = str.ToCharArray();
                Array.Sort(charArray);
                return new string(charArray);
             */
          }
          /*
           * function that takes a string(sentence) and  string(word) returns index of where the word appears
           * 1.	Separate string by spaces into an array or list of words

            2.	For loop over the array by length of the array

            3.	Have if statement in the loop for if the string at the index of the loop matches the word

            4.	May have to do a ToLower to normalize the words and maybe Regex to remove symbols

            5.	If it matches return the index number for the word

           */
    }
}
