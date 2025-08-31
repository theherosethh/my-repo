using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datatype_exer
{
    internal class Switch_Statement
    {
        static void Main(string[] args)
        {
            //Usage:
            //**Use when if-else statement is too complex and unreadable, also it uses to switch to any statement without it have to excute line by line.
            //**It operate the same as if-else statement as it check the condition line by line whether it fullfills or skip the condition.
            //Syntax:
            //switch(variable)
            //{
            //case1
            //execute your code
            //break;
            //case2:
            //execute your code
            //break;
            //default:
            //execute your code 
            //break;
            //}

            // EXAMPLE_1: 

            //int x = 0;
            //switch (x)
            //{
            //    case 1:
            //        Console.WriteLine("the choice is 1");
            //    break;
            //    case 2:
            //        Console.WriteLine("the choice is 2");
            //    break;
            //    default:
            //        Console.WriteLine("Invalid choice");
            //    break;
            //}

            string str = "Java";
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





        }
      


    }

}
