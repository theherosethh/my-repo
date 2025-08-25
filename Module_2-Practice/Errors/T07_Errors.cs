using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_2_Practice.Errors
{
	internal class T07_Errors
	{
		static void Main(string[] args)
		{
			int a = 10, b = 0;
			if (a != 0)
			{
				Console.WriteLine("Division:" + (a / b));
			}
			else
			{
				Console.Write("Cannot Divided by zero!");        
			}
			//Console.WriteLine("Division: " + (a / b)); // ❌ ERROR: divide by zero

			bool x = true, y = false;
			Console.WriteLine("x & y: " + (x & y)); // ❌ ERROR: invalid operands

			string? str = null;
			Console.WriteLine("Length: " + str?.Length); // ❌ ERROR: null reference
		}
	}
}
