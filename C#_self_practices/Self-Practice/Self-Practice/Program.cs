using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Self_Practice
{
    public class Program
    {
        public static void Match_case()
        {
            string str = "Mysql";
            switch (str)
            {
                case "C#":
                case "Java":
                case "Python":
                    Console.WriteLine("it's program");
                    break;

                case "Mysql":
                case "Oracle":
                    Console.WriteLine("it's database");
                    break;
                default:
                    Console.WriteLine("Invalid");
                    break;
            }
            int x = 1;
            switch(x)
            {
                case 1:
                    Console.Write("x=1");
                    break;
                case 2:
                    Console.Write("x=2");
                    break;
            }
        }   
        public static void For_Loops()
        {
           // Used to execute a code for FINITE amount of time.
            for (int i = 1; i <= 10; i++)
                {
                Console.WriteLine($"{i}.I love you");


            }
            Console.WriteLine("Happy New Year!");

            //Exercise Make No.9 Pattern.
            int rows = 7;
            for (int i = 1; i <= rows; i++)
            {
                for (int j = i; j < rows; j++)
                {
                    Console.Write(" ");
                }
                
                for (int k = 1; k <= i; k++)
                {
                    Console.Write("* ");
                }
                
                Console.WriteLine();
            }
            //Reveres the Pattern
            int rows1 = 7;
            for (int i = rows1; i >= 1; i--)
            {
                for (int j = rows1; j > i; j--)
                {
                    Console.Write(" ");
                }
                for (int k = 1; k <= i; k++)
                {
                    Console.Write("* ");
                }

                Console.WriteLine();
            }
        }
        public static void Do_While_Loops()
        {
            int i = 0;
            do
            {
                Console.WriteLine($"value of i is {i}");
                      i++;
            } while (i < 5); 



        }
        public static void While_Loops()
        {
            int x = 1; // given x value of 1 for starter of the following condition
            while (x <= 5) // as the value of x is already equal to 1 so the while loop condition starts from x = 1, and as x is less than 5, the loop start. 
            {
                Console.WriteLine("value of x: " + x);
                x++; // after the first x is printed which is x = 1, it increment from 1 to 2, x++ means x = 1 + 1.
            }

            while (true)
            {
                int y, n;
                Console.Write("Enter a number: ");
                n = Convert.ToInt32(Console.ReadLine());
                while (n <= 1) // loop if the n number is less than 1.
                {
                    Console.Write("Invadlid, Re-Enter again\nEnter a new number: ");
                    n = Convert.ToInt32(Console.ReadLine());
                }
                y = 2; //given the value for condition starter
                while (y <= n) // condition start from 3 and it's true as the 3 is less than n.
                {
                    Console.Write($"{y} ");
                    y = y + 2;
                }
                
                Console.ReadKey();   
            }
        }
        public static void While_Loops_ex1_calculator()
        {
            while (true)
            {
                Console.Write("1. Addition\n2. Subtraction\n3. Multiplication\n4. Division\n5. Exit\n");

                Console.Write("Enter your Choice(1-5): ");
                int choice = Convert.ToInt32(Console.ReadLine());
                if (choice == 5)
                {
                    Console.WriteLine("Exit Program.");
                    break;
                }
                else if (choice >= 6)
                {
                    Console.WriteLine("Invalid, Enter numbers again");
                    Console.Write("Enter your Choice(1-5): ");
                    choice = Convert.ToInt32(Console.ReadLine());
                }

                    Console.Write("Enter first number: ");
                double num1 = Convert.ToDouble(Console.ReadLine());

                Console.Write("Enter second number: ");
                double num2 = Convert.ToDouble(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        double result = num1 + num2;
                        Console.WriteLine($"Result {result}");
                        break;
                    case 2:
                        double result1 = num1 - num2;
                        Console.WriteLine($"Result {result1}");
                        break;
                    case 3:
                        double result2 = num1 * num2;
                        Console.WriteLine($"Result {result2}");
                        break;
                    case 4:
                        if (num2 != 0)
                        {
                            double result3 = num1 / num2;
                            Console.WriteLine($"Result {result3}");
                        }
                        else
                        {
                            Console.WriteLine("Cannot divided by zero");
                        }
                         break;
                }
                Console.WriteLine("Press any key to return to menu");
                Console.ReadKey();
            }
        }
        public static void Break_statement()
        {
            //write a program that start from 100 but stop at 50
            /*
            int x = 1;
            while (x <= 100)
            {
                Console.WriteLine(x);
                if (x == 50)
                    break;
                x++;
            }
            */
            //Write a program that keeps asking the user for a number.
            //If the user enters -1, stop the loop with break.
            //Otherwise, print the number back.
            //while (true)
            //{
            //    Console.Write("Enter a number, if -1 is exit: ");
            //    string input = Console.ReadLine();
            //    if (!int.TryParse(input, out int y)) //use the TryParse for convert string to integer safely, meaning it will return true or false.
            //    {
            //        Console.WriteLine("Invalid input, Enter only numbers.");
            //        continue;
            //    }

            //    Console.WriteLine($"You entered {y}");

            //    if (y == -1)
            //    {
            //        Console.WriteLine("Exiting...");
            //        break;
            //    }
            //}
            //Console.ReadKey();

            //Write a program that loops numbers starting from 1.
            //Stop the loop when you find the first number divisible by 7.
            //Print that number.

            //for (int i = 1; i <= 100; i++)
            //{
            //    if (i % 7 == 0)
            //    {
            //        Console.Write($"First multiple of 7 is {i}");
            //        break;
            //    }
            //}
            //Console.ReadKey();

            //press 3 to exit menu
            //while (true)
            //{
            //    Console.WriteLine("1. Hello");
            //    Console.WriteLine("2. World");
            //    Console.WriteLine("3. Exit");

            //    Console.WriteLine("\nEnter option: ");
            //    int option = Convert.ToInt32(Console.ReadLine());
            //    switch (option)
            //    {
            //        case 1:
            //            Console.WriteLine("Hello");
            //            break;
            //        case 2:
            //            Console.WriteLine("World");
            //            break;
            //        case 3:
            //            Console.WriteLine("Exiting the program");
            //            System.Environment.Exit(0);
            //            break;
            //        default:
            //            Console.WriteLine("Invalid, Try again");
            //            break;
            //    }
            //    Console.WriteLine("Press any key to return to menu");
            //    Console.ReadKey();
            //}

            //Another version using consolekeyinfo
            //while (true)
            //{
            //    Console.WriteLine("1. Hello");
            //    Console.WriteLine("2. World");
            //    Console.WriteLine("3. Exit");

            //    Console.Write("Enter option: ");
            //    ConsoleKeyInfo keyInfo = Console.ReadKey(true); //(true) mean wait for the key to press and don't show pressed key.
            //    char option = keyInfo.KeyChar; //key pressed return char, keyinfo.keychar (mean read the key that pressed)
            //    switch (option)
            //    {
            //        case '1':
            //            Console.WriteLine("Hello");
            //            break;
            //        case '2':
            //            Console.WriteLine("World");
            //            break;
            //        case '3':
            //            Console.WriteLine("Exiting the program");
            //            System.Environment.Exit(0);
            //            break;
            //        default:
            //            Console.WriteLine("Invalid, Try again");
            //            break;
            //    }
            //    Console.WriteLine("Press any key to return to menu");
            //    Console.ReadKey();
            //}


            //Ask the user for a word (string).
            //Loop through the characters of the string.
            //When the first vowel(a, e, i, o, u) is found, print it and break.
            //Console.Write("Enter a word: ");
            //string words = Console.ReadLine();

            //foreach (char c in words)
            //{
            //    if ("aeiou".Contains(char.ToLower(c)))
            //    {
            //        Console.WriteLine($"First vowel is: {c}");
            //        break;
            //    }
            //}

            //6. Guess the number (limited tries) Generate a random number between 1 and 20.
            //Ask the user to guess. Give them at most 5 attempts. If they guess correctly, break immediately and print "You win!".
            //If they use all attempts, end loop with "Game over."
            bool won = false;
            int attempt = 1;
            while (attempt <= 5)
            {
                Console.WriteLine("Guess the number between 1 and 20: ");
                int guess = Convert.ToInt32(Console.ReadLine());
                int correct = 10;
                if (guess == correct)
                {
                    Console.WriteLine($"You win!, the correct number is {correct}");
                    won = true;
                    break;
                }
                else if (guess < 10 )
                {
                    Console.WriteLine("Incorrect, too low.");
                }
                else if (guess > 10)
                {
                    Console.WriteLine("Incorrect, too high");
                }
                attempt++;
            }
            if (!won)
            {
                Console.WriteLine("Game over");
            }
            
        }
        public static void Continue_statement()
        {
            //use to skip if the condition is true but continue the loop condition
            int x = 1;
            while (x <= 5)
            {
                if (x == 3)
                {
                    x++;
                    continue;

                }
                Console.WriteLine(x);
                x++;
            }
            for (int i = 1; i <= 10; i++)
            {
                if (i == 4)
                {
                    continue;//  skip number 4 and console.writline, then goes back to the i++. Start from 5 and check condition again.
                }
                Console.WriteLine(i);
            }
        }
    }   
}
