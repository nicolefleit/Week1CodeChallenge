using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week1CodeChallenge
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 21; i++)
			{
                Console.WriteLine(FizzBuzz(i));
			}
            for (int i = 92 ; i < 78; i++)
            {
                Console.WriteLine(FizzBuzz(i));
            }

            Console.WriteLine(Yodaizer("I like code"));
            string Forces = "The small spoon delivers an uneven cereal to milk ratio. Your forces are under attack. If Lord Of the Rings had a Scooby Doo ending who would Sauron really be?";
            for (int i = 0; i < Forces.Length; i++)
            {
                if ("aeiou".Contains(Forces[i].ToString().ToLower()))
                {
                    Console.WriteLine(TextStats(Forces));
                }
            }
             List<string> Words = Forces.Split(' ').ToList();
            for (int i = 0; i < Forces.Count(); i++)
            {
                Console.WriteLine(TextStats(Forces[i].ToString()));
            }

            Console.WriteLine(TextStats("The small spoon delivers an uneven cereal to milk ratio. Your forces are under attack. If Lord Of the Rings had a Scooby Doo ending who would Sauron really be?".Length.ToString()));
           
            //Create a for loop that loops through every odd number
            for (int i = 1; i < 26; i += 2)
            {
                // go through the IsPrime function and if it returns true...
                if (IsPrime(i))
                {
                    //...print to the Console
                    Console.WriteLine(i + " is a Prime number");
                }
                    //if returns false return just the number
                else
                {
                    Console.WriteLine(i);
                }
            }
            Console.WriteLine(  DashInsert(454793));
            Console.WriteLine(DashInsert(8675309));
            Console.ReadKey();

        }
        public static string FizzBuzz(int number)
        {
            if (number % 5 == 0 && number % 3 == 0)
            {
                return "FizzBuzz";
            }
            else if (number % 3 == 0)
            {
                return "Buzz";
            }
            else if (number % 5 == 0)
            {
                return "Fizz";
            }
            else if (number > 0)
            {
                return number.ToString();
            }
            return string.Empty;
        }
        public static string Yodaizer(string text)
        {
            // Create a new string in order to return the words in reverse
            string yoda = "";
            //Change the string into a list by splitting the words at the space
            List<string> words = text.Split(' ').ToList();
            //Then put the words in reverse order
            words.Reverse();
            //Create a for loop to put the space back into the string
            for (int i = 0; i < words.Count; i++)
            {
                //add the word plus a space to the string 
                yoda += words[i] + " ";
            }
            //trim the string of extra spaces and return string
            return yoda.Trim();
        }
        public static bool IsPrime(int number)
        {
            // check for evens 
            if (number % 2 == 0 )
            { return false; }
            //create a loop that cycles through numbers to see if the number is divisable by the number in the loop(i)
            for (int i = 3; i < number; i++)
            {
                //if number is divisable by i
                if (number % i == 0)
                {
                    //return false because it is not prime
                    return false;
                }

            }
            //pasted tests for not being prime so it must be prime
            return true;
        }
        public static string DashInsert(int number)
        {
            //set a temporary string
            string temp = string.Empty;
            //use a bool to store information about prior index
            bool prevOddNum = false;
            //changing the number int to a string 
            string dashNum = number.ToString();
            //looping through each number in the string
            for (int i = 0; i < dashNum.Length; i++)
            {
                //determining if the number is odd or even
                if (int.Parse(dashNum[i].ToString()) % 2 == 0)
                {
                    //if even send back just the number
                    temp += dashNum[i];
                    //record that the pervious number was not odd
                    prevOddNum = false;
                }
                    //if the number is odd...
                else
                {
                    //odd
                    if (prevOddNum)
                    {
                        //if number after pervious odd number is odd put a dash in between two numbers
                        temp += "-" + dashNum[i];
                    }
                    else

                    {
                        //if the pervious number is even return just the number
                        temp += dashNum[i];
                    }
                    //record that the pervious number was odd
                    prevOddNum = true;
                }
            }
            //return finished temp string
            return temp;
        }
        public static string TextStats (string input)
        {
            for (int i = 0; i < input.Length; i++)
            {
                Console.WriteLine(input[i]);
            }
            for (int i = 0; i < input.Count(); i++)
            {
                Console.WriteLine(input[i]);
            }
            return string.Empty;
        }
    }
}
