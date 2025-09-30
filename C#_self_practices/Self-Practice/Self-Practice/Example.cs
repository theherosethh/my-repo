using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Self_Practice
{
    public class Example
    {
       public static void For_each_Loops()
        {
            string[] fruits = { "Apple", "Banana", "Oragne" };
            foreach (string fruit in fruits)
            {
                Console.WriteLine(fruit);
            }

        }

        public static void main()
        {
            for (int i = 10; i >= 1; i--)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("Happy New year");
        }

    }
}
