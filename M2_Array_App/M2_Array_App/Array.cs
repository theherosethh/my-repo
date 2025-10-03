using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M2_Array_App
{
	internal class Array
	{
		/*
		 * Array: An array is a collection of similar types of data
		 * 1. C# Array Declaration
		 *	Syntax: datatype[] arrayName;
		 *		dataType - data type like int, string, char, etc	
		 *		arrayName - it is an identifier 
		 *		
		 * Example: int[] age;
		 * // declare an array
			int[] age;

			// allocate memory for array
			age = new int[5];
			 
			//int[] age = new int[5];
		 * 
		 * 2. Array initialization in C#
		 * int [] numbers = {1, 2, 3, 4, 5};
		 * // declare an array
			int[] age = new int[5];

			//initializing array
			age[0] = 12;
			age[1] = 4;
			age[2] = 5;
			...
		 * 
		 * 3. Access Array Elements
		 * 			// access element at index 2
			array[2];

			// access element at index 4
			array[4];
				array[2] - access the 3rd element
				array[4] - access the 5th element

		 *
		 *
		 *
		 *
		 *
		 *
		 *
		 */

		static void Main(string[] args)
		{
			/* Example: C# Array
			// create an array
			int[] numbers = { 1, 2, 3 };

			//access first element
			Console.WriteLine("Element in first index : " + numbers[0]);

			//access second element
			Console.WriteLine("Element in second index : " + numbers[1]);

			//access third element
			Console.WriteLine("Element in third index : " + numbers[2]);

			Console.ReadLine();

			//Output

			//	Element in first index : 1
			//	Element in second index : 2
			//	Element in third index : 3
			*/
			/*4. Change Array Elements

			// create an array
			int[] numbers = { 1, 2, 3 };

			Console.WriteLine("Old Value at index 0: " + numbers[0]);

			// change the value at index 0
			numbers[0] = 11;

			//print new value
			Console.WriteLine("New Value at index 0: " + numbers[0]);

			Console.ReadLine();

			*/
			/*5. Iterating C# Array using Loops


			int[] numbers = { 1, 2, 3 };

			for (int i = 0; i < numbers.Length; i++)
			{
				Console.WriteLine("Element in index " + i + ": " + numbers[i]);
			}

			Console.ReadLine();
			*/

			/*Example: Using foreach loop 



			int[] numbers = { 1, 2, 3 };

			Console.WriteLine("Array Elements: ");

			foreach (int num in numbers)
			{
				Console.WriteLine(num);
			}

			Console.ReadLine();
			*/

			/*6. C# Array Operations using System.Linq

			 // provides us various methods to use in an array
			 //using System.Linq;

			int[] numbers = { 51, 1, 3, 4, 98 };

			// get the minimum element
			Console.WriteLine("Smallest  Element: " + numbers.Min());

			// Max() returns the largest number in array
			Console.WriteLine("Largest Element: " + numbers.Max());

			Console.ReadLine();

			*/

			/*

			int[] numbers = { 30, 31, 94, 86, 55 };

			// get the sum of all array elements
			float sum = numbers.Sum();

			// get the total number of elements present in the array
			int count = numbers.Count();

			float average = sum / count;

			Console.WriteLine("Average : " + average);

			// compute the average
			Console.WriteLine("Average using Average() : " + numbers.Average());

			Console.ReadLine();
			*/
			/* Note: It is compulsory to use the System.Linq namespace while using Min(), Max(), Sum(), Count(), and Average() methods.
			 */

		}
		
	}
}

