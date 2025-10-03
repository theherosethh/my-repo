using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M2_Array_App
{
	internal class Jagged_Array
	{

		static void Main(string[] args)
		{
			/*C# Jagged Array
			 * C# Jagged Array Declaration
			 * dataType[ ][ ] nameOfArray = new dataType[rows][ ];
			 * // declare jagged array
				int[ ][ ] jaggedArray = new int[2][ ];
			 * 
			 *	// set size of the first array as 3
				jaggedArray[0] = new int[3];

				// set size of second array as 2
				jaggedArray[1] = new int[2];
			 * Initializing Jagged Array
			 * 1. Using the index number
			 *	// initialize the first array
				jaggedArray[0][0] = 1;
				jaggedArray[0][1] = 3;
				jaggedArray[0][2] = 5;

				// initialize the second array
				jaggedArray[1][0] = 2;
				jaggedArray[1][1] = 4;
			 * 
			 * 2. Initialize without setting size of array elements
			 *	// declaring string jagged array
				int[ ][ ] jaggedArray = new int[2] [ ];

				// initialize each array
				jaggedArray[0] = new int[] {1, 3, 5};
				jaggedArray[1] = new int[] {2, 4};
			 * 
			 * 3. Initialize while declaring Jagged Array
			 *	int[ ][ ] jaggedArray = {
					new int[ ] {10, 20, 30},
					new int[ ] {11, 22},
					new int[ ] {88, 99}
				};
			 * 
			 * Accessing elements of a jagged array
			 *	// access first element of second array
				jaggedArray[1][0];

				// access second element of the second array
				jaggedArray[1][1];

				// access second element of the first array
				jaggedArray[0][1];
			 * 
			 * 
			 */
			/*Example: C# Jagged Array
			// create a jagged array
			int[][] jaggedArray = {
				 new int[] {1, 3, 5},
				 new int[] {2, 4},
			};

			// print elements of jagged array
			Console.WriteLine("jaggedArray[1][0]: " + jaggedArray[1][0]);
			Console.WriteLine("jaggedArray[1][1]: " + jaggedArray[1][1]);

			Console.WriteLine("jaggedArray[0][2]: " + jaggedArray[0][2]);

			Console.ReadLine();
			*/


			/*Iterating through a jagged array
			// declare a jagged array
			int[][] jaggedArray = new int[2][];

			// set size of Jagged Array Elements
			jaggedArray[0] = new int[3];
			jaggedArray[1] = new int[2];

			// initialize the first array
			jaggedArray[0][0] = 1;
			jaggedArray[0][1] = 3;
			jaggedArray[0][2] = 5;

			// initialize the second array
			jaggedArray[1][0] = 2;
			jaggedArray[1][1] = 2;

			// outer for loop
			for (int i = 0; i < jaggedArray.Length; i++)
			{

				Console.Write("Element " + i + ": ");
				// inner for loop
				for (int j = 0; j < jaggedArray[i].Length; j++)
				{
					Console.Write(jaggedArray[i][j] + " ");
				}
				Console.WriteLine();
			}
			Console.ReadLine();
			*/


			/*Jagged Array with Multidimensional Array
			 * In C#, we can also use multidimensional arrays as Jagged Array Elements. For example,

				int[ ][ , ] jaggedArrayTwoD = new int[2][ , ] {
						new int[,] { {1, 8}, {6, 7} },
						new int[,] { {0, 3}, {5, 6}, {9, 10} }
				};
			 * 
			 * 
			 * 
			 * 
			 * 
			 */
			// declare and initialize jagged array with 2D array
			int[][,] jaggedArray = new int[3][,]  {
				  new int[ , ] { {1, 8}, {6, 7} },
				  new int[ , ] { {0, 3}, {5, 6}, {9, 10} },
				  new int[ , ] { {11, 23}, {100, 88}, {0, 10} }
			};

			Console.WriteLine(jaggedArray[0][0, 1]);
			Console.WriteLine(jaggedArray[1][2, 1]);
			Console.WriteLine(jaggedArray[2][1, 0]);

			Console.ReadLine();
		}
	}
}
