using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_2_Practice.Topics
{
	internal class T01_DataTypes_And_Literals
	{
		static void Main(string[] args)
		{
			// Integer data types
			int num1 = 100;
			long num2 = 10000000000L;

			// Floating-point data types
			float piFloat = 3.14f;
			double piDouble = 3.14159265358979;

			// Character data type
			char letter = 'A';

			// Other data types
			bool isTrue = true;
			decimal price = 99.99m;

			Console.WriteLine("Integer: " + num1);
			Console.WriteLine("Long: " + num2);
			Console.WriteLine("Float: " + piFloat);
			Console.WriteLine("Double: " + piDouble);
			Console.WriteLine("Char: " + letter);
			Console.WriteLine("Boolean: " + isTrue);
			Console.WriteLine("Decimal: " + price);

			Console.ReadKey();
		}
	}
}
