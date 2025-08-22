using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_2_Practice.Topics
{
	internal class T03_Anonymous_Types
	{
		static void Main(string[] args)
		{
			// Create an anonymous type
			var student = new { Name = "Saroeun", Age = 25, Grade = "A" };

			Console.WriteLine("Student Name: " + student.Name);
			Console.WriteLine("Student Age: " + student.Age);
			Console.WriteLine("Student Grade: " + student.Grade);

			// Anonymous types are read-only
			// student.Age = 26; // ❌ ERROR: Cannot modify
		}
	}
}
