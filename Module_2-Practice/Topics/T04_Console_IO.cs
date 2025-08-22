using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_2_Practice.Topics
{
	internal class T04_Console_IO
	{
		static void Main(string[] args)
		{
			// Output
			Console.WriteLine("Welcome to C# programming!");

			// Input
			Console.Write("Enter your name: ");
			string name = Console.ReadLine();

			Console.Write("Enter your age: ");
			int age = int.Parse(Console.ReadLine());

			Console.WriteLine($"Hello {name}, you are {age} years old.");
		}
	}

}
