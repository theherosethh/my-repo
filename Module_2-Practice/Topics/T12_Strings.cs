using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_2_Practice.Topics
{
	internal class T12_Strings
	{
		static void Main(string[] args)
		{
			// Create a string
			string str = "Hello C#";

			// Operations
			Console.WriteLine(str.Length);
			Console.WriteLine(str.ToUpper());
			Console.WriteLine(str.Substring(0, 5));
			Console.WriteLine(str.Replace("C#", "World"));

			// Features
			string multi = @"Line1
Line2";
			Console.WriteLine(multi);
		}
	}
}
