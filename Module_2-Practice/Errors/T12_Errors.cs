using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_2_Practice.Errors
{
	internal class T12_Errors
	{
		internal class T12_ExerciseWithErrors
		{
			static void Main(string[] args)
			{
				string name = 'Saroeun'; // ❌ ERROR: char quotes used
				Console.WriteLine(name.lenght); // ❌ ERROR: wrong property name
			}
		}
	}
}
