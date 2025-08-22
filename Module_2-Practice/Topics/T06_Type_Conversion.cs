using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_2_Practice.Topics
{
	internal class T06_Type_Conversion
	{
		static void Main(string[] args)
		{
			// Implicit conversion
			int small = 100;
			double big = small; // implicit conversion
			Console.WriteLine("Implicit conversion: " + big);

			// Explicit conversion
			double d = 9.78;
			int i = (int)d; // explicit conversion
			Console.WriteLine("Explicit conversion: " + i);

			// Using Convert class
			string str = "123";
			int num = Convert.ToInt32(str);
			Console.WriteLine("Convert class: " + num);
		}
	}
}
