using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_2_Practice.Topics
{
	internal class T09_Loops
	{
		static void Main(string[] args)
		{
			// for loop
			for (int i = 1; i <= 5; i++)
				Console.WriteLine("For loop: " + i);

			// while loop
			int j = 1;
			while (j <= 5)
			{
				Console.WriteLine("While loop: " + j);
				j++;
			}

			// do-while loop
			int k = 1;
			do
			{
				Console.WriteLine("Do-While loop: " + k);
				k++;
			} while (k <= 5);

			// foreach loop
			string[] fruits = { "Apple", "Banana", "Orange" };
			foreach (var fruit in fruits)
				Console.WriteLine("Fruit: " + fruit);

			// break and continue
			for (int n = 1; n <= 5; n++)
			{
				if (n == 3) continue;
				if (n == 5) break;
				Console.WriteLine("Loop n: " + n);
			}

			// goto statement
			int m = 0;
		start:
			if (m < 3)
			{
				Console.WriteLine("Goto: " + m);
				m++;
				goto start;
			}
		}
	}
}
