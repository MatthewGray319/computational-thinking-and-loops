using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace template_csharp_computational_thinking
{
    internal class Exercises
    {
        public static void AreTheseIntegersEqual()
        {
            // Ask the user for two integers. 
            // Check and see if the two integers are equal to each other.
            // If they are, inform the the user that the numbers are equal,
            // else inform the user that the numbers are not equal

            Console.Clear();
            Console.WriteLine("ARE THESE INTEGERS EQUAL?\n");

            // Enter your solution here
            Console.WriteLine("Enter your first number.")
            var UserInput=Int32.Parse(Console.ReadLine());
            Console.WriteLine("Enter your second number.")
            var UserInput2=Int32.Parse(Console.ReadLine());
            if (UserInput1==UserInput2)
            {
                Console.Write("The numbers ");
                Console.Write(UserInput);
                Console.Write(" and ");
                Console.Write(UserInput1);
                Console.Write(" are the same number");
            }
            else
            Console.Write("The numbers ");
            Console.WriteLine(UserInput);
            Console.WriteLine(" and ");
            Console.WriteLine(UserInput1);
            Console.Write(" are not equal to each other");



            Console.Write("Press enter to return to the Main Menu");
            Console.ReadLine();
        }

        public static void EvenOrOdd()
        {
            // Ask the user for a number.
            // Tell the user if that number is even or odd.

            Console.Clear();
            Console.WriteLine("EVEN OR ODD?\n");

            // Enter your solution here
            Console.WriteLine("Please enter a number.")
            var UserInput2_1 = Int32.Parse(Console.ReadLine());
            if (UserInput2_1 %== 0)
            {
                Console.Write(UserInput2_1);
                Console.Write(" is an even number");
            }
            else
            {
                Console.Write(UserInput2_1);
                Console.WriteLine(" is an odd number");
            }

            Console.Write("Press enter to return to the Main Menu");
            Console.ReadLine();
        }

        public static void VowelOrConsonant()
        {
            // Ask the user for a letter. Check whether a letter is a vowel or consonant.
            // Hint: You can do this problem using a switch or an if condition.

            Console.Clear();
            Console.WriteLine("VOWEL OR CONSONANT?\n");

            // Enter your solution here
            var UserInput3_1 = Console.ReadLine();

            switch (UserInput3_1)
            {
                case "a":
                    Console.Write("That letter ");
                    Console.Write(UserInput3_1);
                    Console.Write(" is a vowel";
                    break;
                case "e":
                    Console.Write("That letter ");
                    Console.Write(UserInput3_1);
                    Console.Write(" is a vowel";
                    break;
                case "i":
                    Console.Write("That letter ");
                    Console.Write(UserInput3_1);
                    Console.Write(" is a vowel";
                    break;
                case "o":
                    Console.Write("That letter ");
                    Console.Write(UserInput3_1);
                    Console.Write(" is a vowel";
                    break;
                case "u":
                    Console.Write("That letter ");
                    Console.Write(UserInput3_1);
                    Console.Write(" is a vowel";
                    break;
                default:
                    Console.Write("The letter ");
                    Console.Write(UserInput3_1);
                    Console.Write(" is a consonant";
            }

            Console.Write("Press enter to return to the Main Menu");
            Console.ReadLine();
        }

        public static void FindLargestNumber()
        {
            // Prompt the user to input two integer values.
            // Find and print the greatest value of the two integers.

            Console.Clear();
            Console.WriteLine("FIND THE LARGEST NUMBER\n");

            // Enter your solution here
            Console.WriteLine("Enter your first number.")
            var UserInput4_1 = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Enter your second number.")
            var UserInput4_2 = Int32.Parse(Console.ReadLine());
            if (UserInput4_1 > UserInput4_2) 
            {
                Console.Write(UserInput4_1);
                Console.Write(" is the larger number");
            }
            else if (UserInput4_1 < UserInput4_2)
            {
                Console.Write(UserInput4_2);
                Console.Write(" is the larger number");
            }


            Console.Write("Press enter to return to the Main Menu");
            Console.ReadLine();
        }

        public static void DivisibleBy3()
        {
            // Ask the user for a number and then tell them if it is divisible by 3

            Console.Clear();
            Console.WriteLine("DIVISIBLE BY 3\n");

            // Enter your solution here
            Console.WriteLine("Please enter a number.")
            var UserInput5 = Int32.Parse(Console.ReadLine());
            if (UserInput5 % 3 == 0) 
            {
                Console.WriteLine("divisible by 3");
            }
            else
            {
                Console.WriteLine("not divisible by 3");
            }

            Console.Write("Press enter to return to the Main Menu");
            Console.ReadLine();
        }

        public static void WordsToDigits()
        {
            // Having a string representation of a number, you need to print the digit form of the number.
            // Ask the user to enter a string representation of a number from zero to ten.
            // Using switch case, print the digit (0-10) representation of the number.

            Console.Clear();
            Console.WriteLine("WORDS TO DIGITS\n");

            // Enter your solution here
            Console.WriteLine("Please enter the string representation of a number from 0 to 10.")
            string UserInput6;
            UserInput6 = Console.ReadLine();
            switch (UserInput6)
            {
                case "zero":
                    ConsoleWriteLine(0);
                break;
                case "one":
                    ConsoleWriteLine(1);
                break;
                case "two":
                    ConsoleWriteLine(2);
                break;
                case "three":
                    ConsoleWriteLine(3);
                break;
                case "four":
                    ConsoleWriteLine(4);
                break;
                case "five":
                    ConsoleWriteLine(5);
                break;
                case "six":
                    ConsoleWriteLine(6);
                break;
                case "seven":
                    ConsoleWriteLine(7);
                break;
                case "eight":
                    ConsoleWriteLine(8);
                break;
                case "nine":
                    ConsoleWriteLine(9);
                break;
                case "ten":
                    ConsoleWriteLine(10);
                break;
                default:
                    Console.WriteLine("That is not a number from 0 to 10");
                break;
            }





            Console.Write("Press enter to return to the Main Menu");
            Console.ReadLine();
        }

        public static void WhichNameIsLonger()
        {
            // Ask the user for their first and last name.

            // Print the user's full name.
            // If the first name is longer than the last name, print "First is longer."
            // If the first name and last name are the same length, print "Same-sies!"
            // Otherwise, print "Last must be longer!"

            Console.Clear();
            Console.WriteLine("WHICH NAME IS LONGER?\n");

            // Enter your solution here
            Console.WriteLine("Please enter your first name.")
            var UserInput7_1 = Console.ReadLine();
            Console.WriteLine("Please enter your last name.")
            var UserInput7_2 = (Console.ReadLine();
            Console.Write(UserInput7_1 + UserInput7_2);
            if (UserInput7_1 > UserInput7_2)
            {
                Console.WriteLine("First is longer.");
            }
            else if (UserInput7_1 == UserInput7_2)
                {
                Console.WriteLine("Same-sies!")
                }
                else if (UserInput7_1 < UserInput7_2)
                {
                Console.WriteLine("Last must be longer!");
                }


            Console.Write("Press enter to return to the Main Menu");
            Console.ReadLine();
        }

        public static void AreNamesSame()
        {
            // Ask the user for 2 names.

            // If the two names are the same, print "The names are the same."
            // If they're not the same, print "The names are different."

            Console.Clear();
            Console.WriteLine("ARE THESE NAMES THE SAME?\n");

            // Enter your solution here
            Console.WriteLine("Please enter a name.")
            var UserInput8_1 = Console.ReadLine();
            Console.WriteLine("Please enter another name.")
            var UserInput8_2 = (Console.ReadLine();

            if (UserInput8_1 == UserInput8_2)
            {
                Console.WriteLine("The names are the same.");
            }
            else
            {
                Console.WriteLine("The names are different.");
            }

            Console.Write("Press enter to return to the Main Menu");
            Console.ReadLine();
        }

        public static void NameAndBirthplace()
        {
            // Ask the user for their first name and where they were born.
            // Print a sentence to the console that repeats this information.

            Console.Clear();
            Console.WriteLine("NAME AND PLACE OF BIRTH\n");

            // Enter your solution here
            Console.WriteLine("Please enter your first name.")
            var UserInput9_1 = Console.ReadLine();
            Console.WriteLine("Please enter your place of birth.")
            var UserInput9_2 = Console.ReadLine();
            Console.Write("Hi ");
            Console.Write(UserInput9_1);
            Console.Write("! You were born in ");
            Console.Write(UserInput9_2);


            Console.Write("Press enter to return to the Main Menu");
            Console.ReadLine();
        }


        //LOOPS SECTION
        //For this next section, in order to get a passing grade, each of the following problems must be solved using at least one of the the loop types we learned in class.

        public static void ReverseCounting()
        {
            // Ask the user for a number between 1-20. Starting at the number given,
            // count backwards to 1 and print the numbers to the console.

            Console.Clear();
            Console.WriteLine("REVERSE COUNTING\n");

            // SOLUTION HERE

            int(UserInput10);
            Console.WriteLine("Please enter a number from 1 - 20.")
            UserInput10 = Int32.Parse(Console.ReadLine());
            i = 0;
            while (i <= UserInput10)
            {
                Console.Write(UserInput10 - i);
                i++;
            }




            Console.Write("Press enter to return to the Main Menu");
            Console.ReadLine();
        }

        public static void SquareOfEvenNumbers()
        {
            // For the numbers 1-9, if a number is even print the square of that number (number multiplied by itself) and if it is odd, just print the number

            Console.Clear();
            Console.WriteLine("PRINT THE SQUARE OF EVEN NUMBERS\n");

            // SOLUTION HERE
            int j;
            j = 1;
            while (j <= 9)
            {
                if (j%2== 0) 
                {
                    Console.Write(j * j);
                    Console.Write(" ");
                }
                else 
                {
                    Console.Write(j);
                    Console.Write(" ");
                }
                j++;
            }

            Console.Write("Press enter to return to the Main Menu");
            Console.ReadLine();
        }

        public static void GuessMagicNumber()
        {
            // Write a console application that asks the user for an integer.
            // If that integer is evenly divisible by 3, then print “You Won!”.
            // If it isn’t, ask the user to “Try again.”
            // Keep asking them for a number (looping) until they win.

            Console.Clear();
            Console.WriteLine("GUESS THE MAGIC NUMBER\n");

            int userInput = Convert.ToInt32(Console.ReadLine());

            // This reads the user's input and converts it to an integer.
            // We'll assume that users can only input integers.
            // SOLUTION HERE
            Console.WriteLine("Please enter an integer.")
            var UserInput11 = Int32.Parse(Console.ReadLine());
            while (UserInput11 % 3 != 0)
            {
                Console.WriteLine("Try again.");
                UserInput11 = Int32.Parse(Console.ReadLine();
            }
            Console.WriteLine("You Won!");


            Console.Write("Press enter to return to the Main Menu");
            Console.ReadLine();
        }
    }
}
