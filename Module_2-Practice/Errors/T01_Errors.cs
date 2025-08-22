using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_2_Practice.Errors
{
	internal class T01_Errors
	{
		static void Main(string[] args)
		{
			int age = 25; // ❌ ERROR: assigning string to int
			double pi = 3.14; // ❌ ERROR: wrong decimal separator
			char nameLetter = 'S'; // ❌ ERROR: char must use single quotes

			Console.WriteLine("Age: " + age); // ❌ ERROR: variable name mismatch
			Console.WriteLine("Pi: " + pi); // ❌ ERROR: variable name mismatch
			Console.WriteLine("Letter: " + nameLetter);
		}
	}
}
