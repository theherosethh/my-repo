using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M2_Array_App_Exercise
{
	public class Array_2
	{
		public void run()
		{
			/*
         * Problem:
         * Create a 2D array to store the marks of 3 students in 4 subjects.
         * Ask the user to enter the marks for each student.
         * Then calculate and display the total marks of each student.
         */

			int[,] marks = new int[3, 4];

			Console.WriteLine("Enter marks for 3 students (4 subjects each):");
			for (int i = 0; i < 3; i++)
			{
				Console.WriteLine($"\nStudent {i + 1}:");
				for (int j = 0; j < 4; j++)
				{
					Console.Write($"Subject {j + 1}: ");
					marks[i, j] = int.Parse(Console.ReadLine());
				}
			}

			Console.WriteLine("\nTotal Marks of Students:");
			for (int i = 0; i < 3; i++)
			{
				int total = 0;
				for (int j = 0; j < 4; j++)
				{
					total += marks[i, j];
				}
				Console.WriteLine($"Student {i + 1} Total = {total}");
			}
		}
	}
}
