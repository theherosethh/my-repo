using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M2_Array_App_Exercise
{
	public class Array_4
	{
		public void run()
		{
			/*
		* Problem:
		* Create an array that contains the names of 5 countries.
		* Print all countries using a foreach loop.
		*/

			string[] countries = { "Cambodia", "Thailand", "Vietnam", "Laos", "Malaysia" };

			Console.WriteLine("Countries list using foreach:");
			foreach (string country in countries)
			{
				Console.WriteLine(country);
			}
		}
	}
}
