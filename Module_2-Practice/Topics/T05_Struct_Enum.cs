using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_2_Practice.Topics
{
	struct Point
	{
		public int X;
		public int Y;
	}

	enum Days
	{
		Sunday,
		Monday,
		Tuesday,
		Wednesday,
		Thursday,
		Friday,
		Saturday
	}
	internal class T05_Struct_Enum
	{
		static void Main(string[] args)
		{
			// Struct example
			Point p;
			p.X = 10;
			p.Y = 20;
			Console.WriteLine($"Point: ({p.X}, {p.Y})");

			// Enum example
			Days today = Days.Monday;
			Console.WriteLine("Today is " + today);
		}
	}
}
