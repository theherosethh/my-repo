using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M2_Array_App_Exercise
{
	public class Array_1
	{
		public void run()
		{
		/*
         * Problem:
         * Create a one-dimensional array of 5 integers.
         * Ask the user to enter 5 numbers and store them in the array.
         * Then print all numbers in reverse order.
         */

			int[] numbers = new int[5];

			Console.WriteLine("Enter 5 integers:");
			for (int i = 0; i < numbers.Length; i++)
			{
				Console.Write($"Number {i + 1}: ");
				numbers[i] = int.Parse(Console.ReadLine());
			}

			Console.WriteLine("\nNumbers in reverse order:");
			for (int i = numbers.Length - 1; i >= 0; i--)
			{
				Console.Write(numbers[i] + " ");
			}
		}
	}
}
