using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_2_Practice.Topics
{
	internal class T10_NameOf
	{
		static void Main(string[] args)
		{
			int age = 25;
			string name = "Saroeun";

			Console.WriteLine(nameof(age)); // prints "age"
			Console.WriteLine(nameof(name)); // prints "name"

			// Useful in exceptions or logging
			try
			{
				throw new Exception($"{nameof(age)} cannot be negative");
			}
			catch (Exception ex)
			{
				Console.WriteLine(ex.Message);
			}
		}
	}
}
