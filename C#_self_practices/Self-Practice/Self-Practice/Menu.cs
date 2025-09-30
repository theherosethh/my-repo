using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Self_Practice
{
    public class Menu
    {
       public static void Create_Menu()
        {
            while(true)
            {
                Console.WriteLine("1. Home");
                Console.WriteLine("2. About us");
                Console.WriteLine("3. Contact us");
                Console.WriteLine("4. Privacy");
                Console.WriteLine("5. Exit");

                Console.Write("Please choose Menu 1-4, 5 exit: ");
                //accept input
                int menu = Convert.ToInt32(Console.ReadLine());
                Console.ReadKey();

                //check condition
                switch (menu)
                {
                    case 1:
                        Console.Write("Welcome Home Page");
                        break;
                    case 2:
                        Console.Write("Welcome About us Page");
                        break;
                    case 3:
                        Console.Write("Welcome Contact us Page");
                        break;
                    case 4:
                        Console.Write("Welcome to Privacy Page");
                        break;
                    case 5:
                        System.Environment.Exit(5);
                        break;
                    default:
                        Console.Write("Invalid, Re-Enter again");
                        break;
                }
                Console.ReadKey();
            }
        }
    }
}
