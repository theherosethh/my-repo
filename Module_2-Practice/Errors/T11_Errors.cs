using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_2_Practice.Errors
{
	internal class T11_Errors
	{
		internal class T11_ExerciseWithErrors
		{
			static void Main(string[] args)
			{
				int[] nums = new int[3] { 1, 2 }; // ❌ ERROR: array size mismatch
				Console.WriteLine(nums[3]); // ❌ ERROR: index out of bounds
			}
		}
	}
}
