using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M2_Array_App_Exercise
{
	internal class Array_5
	{
		
		public void run()
		{
			/*
			 * Problem:
			 * 1. Store the names of students in a string array.
			 * 2. Store their marks in a 2D array (students x subjects).
			 * 3. Calculate the average marks for each student.
			 * 4. Print the results.
			 * 5. Finally, use foreach to print the list of student names.
			 */

			string[] students = { "Alice", "Bob", "Charlie" };
			int[,] marks = {
			{ 80, 90, 70 },
			{ 60, 75, 85 },
			{ 95, 88, 92 }
		};

			Console.WriteLine("Average Marks of Students:");
			for (int i = 0; i < students.Length; i++)
			{
				int total = 0;
				for (int j = 0; j < marks.GetLength(1); j++)
				{
					total += marks[i, j];
				}
				double average = (double)total / marks.GetLength(1);
				Console.WriteLine($"{students[i]}: {average:F2}");
			}

			Console.WriteLine("\nStudent list using foreach:");
			foreach (string student in students)
			{
				Console.WriteLine(student);
			}
		}
	}

}

