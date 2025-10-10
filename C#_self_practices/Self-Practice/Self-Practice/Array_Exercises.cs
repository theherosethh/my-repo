using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Self_Practice
{
    public class Array_Exercises
    {
        public static void Array_Ex1()
        {

            // C# Sharp program that stores elements in an array and prints them.Input 10 elements from user.
            int[] element = new int[10];
            Console.Write("Input 10 elements in the array:\n");
            for (int i = 0; i < 10; i++)
            {
                Console.Write($"element - {i} : ");
                element[i] = int.Parse(Console.ReadLine());
            }
            Console.Write("Element in array are: ");
            for (int i = 0; i < element.Length; i++)
            {
                Console.Write(element[i] + " ");
            }
        }
        public static void Array_Ex2()
        {
            // C# Sharp program to read n values in an array and display them in reverse order.
            Console.Write("Input the number of Element to store in array: ");
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine($"Input {n} number of elements in the array:");

            int[] element1 = new int[n];
            for (int i = 0; i < n; i++)
            {
                Console.Write($"Input element - {i} : ");
                element1[i] = int.Parse(Console.ReadLine());
            }

            Console.Write("The value store in the original array are: ");
            for (int i = 0; i < element1.Length; i++)
            {
                Console.Write(element1[i] + " ");
            }
            
            //reversing element1

            Array.Reverse(element1);
            Console.Write("\nThe value store in the reverse array are: ");
            for (int i = 0; i < element1.Length; i++)
            {
                Console.Write(element1[i] + " ");
            }
            Console.ReadKey();
        }
        public static void Array_Ex3()
        {
            //Write a program in C# Sharp to find the sum of all array elements.
            Console.Write("Input the number of elements to be store in the array: ");
            int n = int.Parse(Console.ReadLine());

            Console.Write($"\nInput {n} in the array:\n");
            int[] element = new int[n];
            for (int i = 0; i < n; i++)
            {
                Console.Write($"Element - {i} : ");
                element[i] = int.Parse(Console.ReadLine());
            }
            int total = 0;
            for (int i = 0; i < element.Length; i++)
            {
                total += element[i];
            }
            Console.WriteLine($"\nSum of all element in the array is: {total}");
            Console.ReadKey();
        }    
    }   
}
