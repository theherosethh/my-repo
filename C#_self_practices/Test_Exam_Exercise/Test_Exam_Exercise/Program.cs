using System;

namespace Test_Exam_Exercise
{
   public class Program
    {
        public static void Ex1()
        {
            Console.Write("Enter your name: ");
            string name = Console.ReadLine();
            Console.Write("Enter your age: ");
            int age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"{name}, {age}");
        }
        public static void Ex2()
        {
            int number = 15;
            if (number % 2 == 0)
            {
                Console.WriteLine($"number {number} is Even");
            }
            else
            {
                Console.WriteLine($"number {number} is odd");
            }
        }
        public static void EX3()
        {
            for (int i = 1; i <= 50; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i);
                }
            }
        }
        public static void EX4()
        {
            int[] i = { 1, 3, 45, 555, 54 };
            int largest = i.Max();
            Console.WriteLine($"Largest number is {largest}");

            //or 

            int[] x = { 1, 3, 45, 5522, 54 };
            int largest1 = x[0];

            for (int y = 1; y < x.Length; y++)
            {
                if (x[y] > largest1)
                {
                    largest1 = x[y];
                }
            }
            Console.WriteLine($"Largst {largest1}");
           




        }
    }
    
}