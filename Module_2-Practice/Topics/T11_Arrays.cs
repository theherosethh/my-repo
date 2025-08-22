using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_2_Practice.Topics
{
	internal class T11_Arrays
	{
		static void Main(string[] args)
		{
			// One-dimensional array
			int[] numbers = { 1, 2, 3, 4, 5 };
			foreach (var n in numbers)
				Console.WriteLine(n);

			// Multi-dimensional array
			int[,] matrix = { { 1, 2 }, { 3, 4 } };
			Console.WriteLine(matrix[1, 1]); // prints 4

			// Jagged (ragged) array
			int[][] jagged = new int[2][];
			jagged[0] = new int[] { 1, 2 };
			jagged[1] = new int[] { 3, 4, 5 };
			Console.WriteLine(jagged[1][2]); // prints 5
		}
	}
}
