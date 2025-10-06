using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M2_Array_App_Exercise
{
public class Array_3
		{
		public void run()
		{
			
				/*
				 * Problem:
				 * Create a jagged array with 3 rows.
				 * - Row 1 should have 2 elements
				 * - Row 2 should have 3 elements
				 * - Row 3 should have 4 elements
				 * Ask the user to enter values for each row.
				 * Then print the jagged array.
				 */

				int[][] jagged = new int[3][];
				jagged[0] = new int[2];
				jagged[1] = new int[3];
				jagged[2] = new int[4];

				Console.WriteLine("Enter values for jagged array:");
				for (int i = 0; i < jagged.Length; i++)
				{
					Console.WriteLine($"\nRow {i + 1}:");
					for (int j = 0; j < jagged[i].Length; j++)
					{
						Console.Write($"Element {j + 1}: ");
						jagged[i][j] = int.Parse(Console.ReadLine());
					}
				}

				Console.WriteLine("\nJagged Array Output:");
				for (int i = 0; i < jagged.Length; i++)
				{
					Console.Write($"Row {i + 1}: ");
					for (int j = 0; j < jagged[i].Length; j++)
					{
						Console.Write(jagged[i][j] + " ");
					}
					Console.WriteLine();
				}
			}
		}
}
	
