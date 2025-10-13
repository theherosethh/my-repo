using System;
using System.Text;

namespace M2_String_Arg_APP
{
	public class Program
	{
		public static void PRACTICE_1()
        {
            //Creating a String
            string message = "Welcome to C# programming!";
            Console.WriteLine(message);
        }
		public static void PRACTICE_2()
        {
            //String Operations (Concatenation and Length)
            string firstName = "Saroeun";
            string lastName = "Saing";
            string fullName = firstName + " " + lastName;

            Console.WriteLine("Full Name: " + fullName);
            Console.WriteLine("Length of full name: " + fullName.Length);

        }
        
        public static void PRACTICE_3()
        {
            //Substring and Replace
            string sentence = "I love programming in Java";

            string part = sentence.Substring(7, 11); // "programming"
            Console.WriteLine("Extracted word: " + part);

            string newSentence = sentence.Replace("Java", "C#");
            Console.WriteLine("After Replace: " + newSentence);
        }
        
        public static void PRACTICE_4()
        {
            //Searching in String
            Console.Write("Enter a sentence: ");
            string sentence = Console.ReadLine();

            Console.Write("Enter a word to search: ");
            string word = Console.ReadLine();

            int index = sentence.IndexOf(word);

            if (index != -1)
                Console.WriteLine($"'{word}' found at position {index}");
            else
                Console.WriteLine($"'{word}' not found in the sentence.");
        }

        public static void PRACTICE_5()
        {
            //Splitting and Joining Strings
            string sentence = "C#,Java,Python,PHP";
            string[] languages = sentence.Split(',');

            Console.WriteLine("Languages:");
            foreach (string lang in languages)
            {
                Console.WriteLine(lang);
            }

            string joined = String.Join(" | ", languages);
            Console.WriteLine("\nJoined string: " + joined);
        }
        
        public static void PRACTICE_6()
        {
            //Using StringBuilder
            StringBuilder sb = new StringBuilder("Learning");
            sb.Append(" C#");
            sb.Append(" is");
            sb.Append(" fun!");

            Console.WriteLine(sb.ToString());
        }

        public static void PRACTICE_7()
        {
            //String Comparison
            Console.Write("Enter first string: ");
            string str1 = Console.ReadLine();

            Console.Write("Enter second string: ");
            string str2 = Console.ReadLine();

            bool isEqual = str1.Equals(str2, StringComparison.OrdinalIgnoreCase);

            if (isEqual)
                Console.WriteLine("The strings are equal (case-insensitive).");
            else
                Console.WriteLine("The strings are not equal.");
        }

        public static void PRACTICE_8()
        {
            // String Features (Uppercase, Lowercase)
            Console.Write("Enter a sentence: ");
            string text = Console.ReadLine();

            Console.WriteLine("\nUppercase: " + text.ToUpper());
            Console.WriteLine("Lowercase: " + text.ToLower());
            Console.WriteLine("Length: " + text.Length);
        }

        public static void PRACTICE_9(string[] args)
        {
            //Using Command Line Arguments
            Console.WriteLine("Number of arguments: " + args.Length);

            for (int i = 0; i < args.Length; i++)
            {
                Console.WriteLine($"Argument {i + 1}: {args[i]}");
            }
        }

        public static void PRACTICE_10(string[] args)
        {
            //Command Line Sum
            if (args.Length < 2)
            {
                Console.WriteLine("Please provide two numbers as command line arguments.");
                return;
            }

            int num1 = Convert.ToInt32(args[0]);
            int num2 = Convert.ToInt32(args[1]);
            int sum = num1 + num2;

            Console.WriteLine($"Sum = {sum}");
        }
    }
}
