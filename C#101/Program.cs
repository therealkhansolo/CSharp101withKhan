namespace C_101
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Mr Khan's C#101";


            /*C# is a case-sensitive language
            int number = 3;
            int Number = 3;
              */
            /*
             //All coding exercises were created & completed in a stand-alone IDE hence the inconsistencies

            //Below is coding exercise 1 which focused on variables and operators

                using System;

                namespace Coding.Exercise
                {
                    public class Exercise
                    {
                        public static int VariablesAndOperators()
                        {
                            var a = 5;
                            var b = 10;
                            var c = 3;

                           int result = ((a + b) / c);

                          return result;
                        }
                    }
                  }
*/
            /*
             

             //Below is coding exercise 2 which focused on boolean types and operators
             
                   using System;

                   namespace Coding.Exercise
                    {
                     public class Exercise
                        {
                            public static bool BooleanTypesAndOperators()
                            {          
                                int a = 5;
                                int b = 12;

                                bool isSumLargerOrEqualTo17 =  (a + b) >= 17;

                                return isSumLargerOrEqualTo17;
                       }
                            }
                   }
             */

            /*
             //Below is coding exercise 3 which focused on if/else conditional statements
                using System;

namespace Coding.Exercise
{
    public class Exercise
    {
        public static string IsElseConditionalStatement()
        {
            int number = 0;
            
            string result;
            
            if(number < 0)
            {
                result = "negative";
            }
            else if(number == 0)
            {
               result = "zero";
            }
            
            else
            {
                result = "positive";
            }
            return result;
        }
    }
}

             */

            /*
             //Below is coding exercise 4 which focused on Methods - AbsoluteOfSum method
                     using System;

namespace Coding.Exercise
{
    public class Exercise
    {
        public static int AbsoluteOfSum(int a, int b)
        {
            return Math.Abs(a + b);
        }
    }
}


             */

            /*
             * 
             //Below is coding exercise 5 which focused on String Interpolation - FormatDate method
                using System;

namespace Coding.Exercise
{
    public class Exercise
    {
        public static string FormatDate(int year, int month, int day)
        {
            return $"{year}/{month}/{day}";
        }
    }
}

             */

            /*
             //Below is coding exercise 6 which focused on switch statements - DescribeDay
            //Even learnt about the more effecient switch expression

            using System;

namespace Coding.Exercise
{
    public class Exercise
    {
        public static string DescribeDay(int dayNumber)
        {
            switch(dayNumber)
            {
                case 1:
                case 2:
                case 3:
                case 4:
                case 5:
                    return "Working day";
                    
                case 6:
                case 7:
                    return "Weekend";
                    
                default:
                    return "Invalid day number";
            }
        }
    }
}

             */

            /*
             //Below is coding exercise 7 which focused on the while loop

            using System;

namespace Coding.Exercise
{
    public class Exercise
    {
        public static int CalculateSumOfNumbersBetween(int firstNumber, int lastNumber)
        {
            int currentNumber = firstNumber;
            int sum = 0;
            
            while(currentNumber <= lastNumber)
            {
                sum += currentNumber;
                currentNumber++;
            }
            return sum;
        }
    }
}

             */


            /*
             //Below is coding exercise 8 which focused on the do-while loop
            using System;

using System;

namespace Coding.Exercise
{
    public class Exercise
    {
        public static string RepeatCharacter(char character, int targetLength)
        {
            string newWord = "";
            do
            {
                newWord += character;  
            }
            while(newWord.Length < targetLength);
            return newWord;
        }
    }
}
             */


            //Console.WriteLine("Enter a word: ");
            //var userInput = Console.ReadLine();

            //while(userInput.Length < 15)
            //{
            //    userInput += 'g';
            //    Console.WriteLine(userInput);
            //}

            //Console.WriteLine("The loop has finished my G.");

            //string word;
            //do
            //{
            //    Console.WriteLine("Enter a word longer than 10 letters");
            //    word = Console.ReadLine();
            //}
            //while(word.Length <= 10);

            //Console.WriteLine("The loop is finished.");


            /*
             //Below is coding exercise 9 which focused on for loops - building a number's factorial

            using System;

namespace Coding.Exercise
{
    public class Exercise
    {
        public static int Factorial(int number)
        {
            int result = 1;
            for(int i = 1; i <= number; i++)
            {
                result *= i;
            }
            
            return result;
        }
    }
}

             */

            /*
             //Below is coding exercise 10 which focused on arrays - building the 'hello' string

            using System;

namespace Coding.Exercise
{
    public class Exercise
    {
        public static string BuildHelloString()
        {
            char[] letters = new[] {'h', 'e', 'l', 'l', 'o'};
            var result = "";
            for(int i = 0; i < letters.Length; ++i)
            {
                result += letters[i];
            }
            return result;
        }
    }
}



             */

            /*
             //Below is coding exercise 11 which focused on arrays - is word present in collection
            
            using System;

namespace Coding.Exercise
{
    public class Exercise
    {
        public static bool IsWordPresentInCollection(string[] words, string wordToBeChecked)
        {
            for(var i = 0; i < words.Length; i++)
            {
                if(words[i] == wordToBeChecked)
                {
                    return true;
                }
            }
            return false;
        }
    }
}

             */

            /*
             //Below is coding exercise 12 which focused on multi-dimensional arrays - findmax

            using System;

namespace Coding.Exercise
{
    public class Exercise
    {
        public static int FindMax(int[,] numbers)
        {
            var height = numbers.GetLength(0);
            var width = numbers.GetLength(1);
            
            if(height == 0 || width == 0)
            return -1;
            
            int max = numbers[0,0];
            
            for(var i = 0; i < height; i++)
            {
                //max += height;
                for(var j = 0; j < width; j++)
                {
                    //max += width;
                    var number = numbers[i,j];
                    if(number > max)
                    {
                        max = number;
                    }
                }
            }
            return max;
        }
    }
}

             */

            /*
             //Below is coding exercise 13 which focused on Foreach loops - is any word longer than

            using System;

namespace Coding.Exercise
{
    public class Exercise
    {
        public static bool IsAnyWordLongerThan(int length, string[] words)
        {
            foreach(var word in words)
            {
                if(word.Length > length)
                {
                    return true;
                }
            }
            return false;
        }
    }
}

             */

            /*
             //Below is coding exercise 14 which focused on Lists - get only uppercase words

            namespace Coding.Exercise
{
    public class Exercise
    {
        public List<string> GetOnlyUpperCaseWords(List<string> words)
        {
            var result = new List<string>();
            
            foreach (var word in words)
            {
                if(result.Contains(word))
                    {
                        continue;
                    }
                    
                bool isWordUpperCase = true;
                
                foreach(var character in word)
                {
                    if(!char.IsUpper(character))
                    {
                        isWordUpperCase = false;
                    }
                }
                if(isWordUpperCase)
                {
                    result.Add(word);
                }
            }
            return result;
        }
    }
}
          */

            /*
             //Below is coding exercise 15 which focused on classes -
             */

            //var numbers = new[] { 10, -8, 2, 12, -17 };
            //int nonPositiveCount;
            //var onlyPositive = GetOnlyPositive(numbers, out nonPositiveCount); 
            
            //foreach(var positiveNumber in onlyPositive)
            //{
            //    Console.WriteLine(positiveNumber);
            //}
            //Console.WriteLine("Count of non-positive: " + nonPositiveCount);


            //List<int> GetOnlyPositive(int[] numbers, out int countOfNonPositive)
            //{
            //    countOfNonPositive = 0;
            //    var result = new List<int>();
            //    foreach (var number in numbers)
            //    {
            //        if (number > 0)
            //        {
            //            result.Add(number);
            //        }
            //        else
            //        {
            //            countOfNonPositive++;
            //        }
            //    }
            //    return result;
            //}

            //for (int i = 0; i < 14; i++)
            //{
            //    Console.WriteLine("Alhamdulillah");
            //}

            //Console.WriteLine("The loop is finished.");


            Console.ReadKey();
        }
    }
}
