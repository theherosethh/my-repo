using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_2_Practice.Errors
{
	internal class T06_Errors
	{
		static void Main(string[] args)
        {
            double d = 9.99;
            int i = (int)d; // ❌ ERROR: cannot implicitly convert double to int

            string str = "132";
            int num = Convert.ToInt32(str); // ❌ ERROR: invalid string

            Console.WriteLine("i: " + i);
            Console.WriteLine("num: " + num);
        }
	}
}
