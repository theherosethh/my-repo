using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M2_Array_App
{
	internal class Mul_Array
	{

		/* int[ , ] x = { { 1, 2 ,3}, { 3, 4, 5 } }; */
		/*1. Two-Dimensional Array Declaration
		 * int[ , ] x = new int [2, 3];
		 * 2. Two-Dimensional Array initialization
		 * int[ , ] x = { { 1, 2 ,3}, { 3, 4, 5 } };
		 * 
		 * int [ , ] x = new int[2, 3]{ {1, 2, 3}, {3, 4, 5} };
		 * 
		 * 3. Access Elements from 2D Array
		 
			// a 2D array
			int[,] x = { { 1, 2, 3 }, { 3, 4, 5 } };

			// access first element from first row
			x[0, 0];  // returns 1

			// access third element from second row
			x[1, 2];  // returns 5

			// access third element from first row
			x[0, 2];  // returns 3
		 */

		static void Main(string[] args)
		{
			/*Example: C# 2D Array
			//initializing 2D array
			int[,] numbers = { { 2, 3 }, { 4, 5 } };

			// access first element from the first row
			Console.WriteLine("Element at index [0, 0] : " + numbers[0, 0]);

			// access first element from second row
			Console.WriteLine("Element at index [1, 0] : " + numbers[1, 0]);
			*/

			/*Change Array Elements
			int[,] numbers = { { 2, 3 }, { 4, 5 } };

			// old element
			Console.WriteLine("Old element at index [0, 0] : " + numbers[0, 0]);

			// assigning new value
			numbers[0, 0] = 222;

			// new element
			Console.WriteLine("New element at index [0, 0] : " + numbers[0, 0]);
			*/


			/*Iterating C# Array using Loop
			int[,] numbers = { { 2, 3, 9 }, { 4, 5, 9 } };

			for (int i = 0; i < numbers.GetLength(0); i++)
			{
				Console.Write("Row " + i + ": ");

				for (int j = 0; j < numbers.GetLength(1); j++)
				{
					Console.Write(numbers[i, j] + " ");

				}
				Console.WriteLine();
			}
			*/

			/*
			 * Note: We can also create a 3D array. Technically, a 3D array is an array that has multiple two-dimensional arrays as its elements. For example,
			 * int[ , , ] numbers = { { { 1, 3, 5 }, { 2, 4, 6 } }, { { 2, 4, 9 }, { 5, 7, 11 } } };
			 * Here, [ , , ] (2 commas) denotes the 3D array.
			 * 
			 */
		}
	}
}
