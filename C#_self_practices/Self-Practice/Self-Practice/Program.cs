using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Self_Practice
{
    public class Program
    {
        public static void Match_case()
        {
            string str = "Mysql";
            switch (str)
            {
                case "C#":
                case "Java":
                case "Python":
                    Console.WriteLine("it's program");
                    break;

                case "Mysql":
                case "Oracle":
                    Console.WriteLine("it's database");
                    break;
                default:
                    Console.WriteLine("Invalid");
                    break;
            }
            int x = 1;
            switch(x)
            {
                case 1:
                    Console.Write("x=1");
                    break;
                case 2:
                    Console.Write("x=2");
                    break;
            }
        }   
        public static void For_Loops()
        {
            //Used to execute a code for FINITE amount of time.
            for (int i = 1; i <= 10; i++)  
            {
                Console.WriteLine($"{i}.I love you"); 
            }
            Console.WriteLine("Happy New Year!");

            //Exercise Make No.9 Pattern.
            int rows = 7;
            for (int i = 1; i <= rows; i++)
            {
                for (int j = i; j < rows; j++)
                {
                    Console.Write(" ");
                }
                for (int k = 1; k <= i; k++)
                {
                    Console.Write("* ");
                }
                
                Console.WriteLine();    
            }  
        }
    }
}
