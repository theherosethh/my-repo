using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M2_String_Arg_APP
{
    public class Menu
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=====Menu=====");
            Console.WriteLine("1. PRACTICE_1");
            Console.WriteLine("2. PRACTICE_2");
            Console.WriteLine("3. PRACTICE_3");
            Console.WriteLine("4. PRACTICE_4");
            Console.WriteLine("5. PRACTICE_5");
            Console.WriteLine("6. PRACTICE_6");
            Console.WriteLine("7. PRACTICE_7");
            Console.WriteLine("8. PRACTICE_8");
            Console.WriteLine("9. PRACTICE_9");
            Console.WriteLine("10. PRACTICE_10");
            Console.WriteLine("11. Exit");

            while (true)
            {
                Console.Write("Enter option: ");
                int option = Convert.ToInt32(Console.ReadLine());

                switch (option)
                {
                    case 1:
                        Program.PRACTICE_1();
                        break;
                    case 2:
                        Program.PRACTICE_2();
                        break;
                    case 3:
                        Program.PRACTICE_3();
                        break;
                    case 4:
                        Program.PRACTICE_4();
                        break;
                    case 5:
                        Program.PRACTICE_5();
                        break;
                    case 6:
                        Program.PRACTICE_6();
                        break;
                    case 7:
                        Program.PRACTICE_7();
                        break;
                    case 8:
                        Program.PRACTICE_8();
                        break;
                    case 9:
                        Program.PRACTICE_9(args);
                        break;
                    case 10:
                        Program.PRACTICE_10(args);
                        break;
                    case 11:
                        Console.WriteLine("Exiting...");
                        System.Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Invalid option");
                        break;
                }
                Console.WriteLine("Press any key to return");
                Console.ReadKey();
            }
        }
    }
}
