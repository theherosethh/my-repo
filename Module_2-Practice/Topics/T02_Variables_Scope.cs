using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_2_Practice.Topics
{
	internal class T02_Variables_Scope
	{
		static void Main(string[] args)
		{
			// Local variable
			int localVar = 10;

			Console.WriteLine("Local Variable: " + localVar);

			// Example of scope
			int outerVar = 5;
			{
				int innerVar = 20;
				Console.WriteLine("OuterVar inside block: " + outerVar);
				Console.WriteLine("InnerVar inside block: " + innerVar);
			}

			Console.WriteLine("OuterVar outside block: " + outerVar);
			// Console.WriteLine("InnerVar outside block: " + innerVar); // ❌ Error: innerVar not accessible
		}
	}
}
