using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_2_Practice.Errors
{
	internal class T04_Errors
	{
		static void Main(string[] args)
		{
			Console.Write("Enter number1: ");
			int num1 = Convert.ToInt32(Console.ReadLine()); // ❌ ERROR: cannot assign string to int

			Console.Write("Enter number2: ");
			int num2 = Convert.ToInt32(Console.ReadLine()); // ❌ ERROR: cannot assign string to int

			Console.WriteLine("Sum: " + (num1 + num2)); // ❌ ERROR: prints concatenation instead of sum
		}
	}
}
