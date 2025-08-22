using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_2_Practice.Topics
{
	internal class T13_CommandLineArgs
	{
		
			static void Main(string[] args)
			{
				Console.WriteLine("Number of args: " + args.Length);
				foreach (var arg in args)
					Console.WriteLine(arg);
			}
		
	}

}
