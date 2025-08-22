using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Module_2_Practice.Errors
{
	internal class T10_Errors
	{

		static void Main(string[] args)
		{
			int num = 5;
			Console.WriteLine(nameof(numVar)); // ❌ ERROR: wrong variable name
		}
	}
}
