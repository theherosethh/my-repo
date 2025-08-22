using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_2_Practice.Topics
{
	internal class T08_Conditions
	{
		static void Main(string[] args)
		{
			int num = 10;

			// if
			if (num > 5)
				Console.WriteLine("num > 5");

			// if-else
			if (num % 2 == 0)
				Console.WriteLine("num is even");
			else
				Console.WriteLine("num is odd");

			// switch
			int day = 3;
			switch (day)
			{
				case 1: Console.WriteLine("Monday"); break;
				case 2: Console.WriteLine("Tuesday"); break;
				case 3: Console.WriteLine("Wednesday"); break;
				default: Console.WriteLine("Other day"); break;
			}

			// ?: operator
			string result = (num > 5) ? "Greater" : "Smaller";
			Console.WriteLine(result);
		}
	}
}
