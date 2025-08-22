using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_2_Practice.Errors
{
	internal class T08_Errors
	{
		static void Main(string[] args)
		{
			int num = Console.ReadLine(); // ❌ ERROR: cannot assign string to int

			if num > 0 // ❌ ERROR: missing parentheses

				Console.WriteLine("Positive");

			string result = num % 2 = 0 ? "Even" : "Odd"; // ❌ ERROR: wrong operator
			Console.WriteLine(result);
		}
	}
}
