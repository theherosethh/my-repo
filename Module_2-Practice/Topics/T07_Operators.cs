using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_2_Practice.Topics
{
	internal class T07_Operators
	{
		static void Main(string[] args)
		{
			int a = 10, b = 3;

			// Arithmetic operators
			Console.WriteLine("Addition: " + (a + b));
			Console.WriteLine("Subtraction: " + (a - b));
			Console.WriteLine("Multiplication: " + (a * b));
			Console.WriteLine("Division: " + (a / b));
			Console.WriteLine("Modulus: " + (a % b));

			// Relational operators
			Console.WriteLine("a > b: " + (a > b));
			Console.WriteLine("a == b: " + (a == b));

			// Logical operators
			bool x = true, y = false;
			Console.WriteLine("x && y: " + (x && y));
			Console.WriteLine("x || y: " + (x || y));
			Console.WriteLine("!x: " + (!x));

			// Bit operators
			Console.WriteLine("a & b: " + (a & b));
			Console.WriteLine("a | b: " + (a | b));
			Console.WriteLine("a ^ b: " + (a ^ b));

			// Assignment operator
			int c = 5;
			c += 3;
			Console.WriteLine("c after +=3: " + c);

			// Null-conditional operator
			string? str = null;
			Console.WriteLine("Length: " + str?.Length); // prints nothing, no exception
		}
	}
}
