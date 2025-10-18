using System;
using System.Diagnostics.Metrics;
namespace Diagram
{
    class Program
    {
        static void User_Management()
        {
            bool back_toMM = false;
            while (!back_toMM)
            {
                Console.WriteLine("====User Management====");
                Console.WriteLine("1. Add New User");
                Console.WriteLine("2. Edit User");
                Console.WriteLine("3. Delete User");
                Console.WriteLine("4. View User");
                Console.WriteLine("5. Loggin");
                Console.WriteLine("6. Back to Main Menu");

                Console.Write("Enter : ");
                int enter = int.Parse(Console.ReadLine());
                switch (enter)
                {
                    case 1:
                        Console.WriteLine("1. Add New User");
                        break;
                    case 2:
                        Console.WriteLine("2. Edit User");
                        break;
                    case 3:
                        Console.WriteLine("3. Delete User");
                        break;
                    case 4:
                        Console.WriteLine("4. View User");
                        break;
                    case 5:
                        Console.WriteLine("5. Loggin");
                        break;
                    case 6:
                        Console.WriteLine("6. Back to Main Menu");
                        back_toMM = true;
                        break;
                    default:
                        Console.WriteLine("Invalid please enter again");
                        break;
                }
                if (!back_toMM)
                {
                    Console.WriteLine("Press enter to continue...");
                    Console.ReadKey();
                }
            }

        }
        static void Role_Management()
        {
            bool back_toMM = false;
            while (!back_toMM)
            {
                Console.WriteLine("====Role Management=====");
                Console.WriteLine("1. Add New Role");
                Console.WriteLine("2. Edit Role");
                Console.WriteLine("3. Delete Role");
                Console.WriteLine("4. View Role");
                Console.WriteLine("5. Back to Main Menu");

                Console.Write("Enter");
                int enter = int.Parse(Console.ReadLine());
                switch (enter)
                {
                    case 1:
                        Console.WriteLine("1. Add New Role");
                        break;
                    case 2:
                        Console.WriteLine("1. Edit Role");
                        break;
                    case 3:
                        Console.WriteLine("3. Delete Role");
                        break;
                    case 4:
                        Console.WriteLine("4. View Role");
                        break;
                    case 5:
                        Console.WriteLine("5. Back to Main Menu");
                        back_toMM = true;
                        break;
                }
                if (!back_toMM)
                {
                    Console.WriteLine("Press enter to continue...");
                    Console.ReadKey();
                }
            }
        }
              
                   
        static void Main(string[] args)
        {
            bool exit = false;
            while (!exit)
            {
                Console.WriteLine("====Main Menu====");
                Console.WriteLine("1. User Management");
                Console.WriteLine("2. Role Management");
                Console.WriteLine("3. Exit");
                Console.Write("Enter: ");
                int enter = int.Parse(Console.ReadLine());
                switch (enter)
                {
                    case 1:
                        User_Management();
                        break;
                    case 2:
                        Role_Management();
                        break;
                    case 3:
                        Console.WriteLine("Exiting...");
                        exit = true;
                        break;
                    default:
                        Console.WriteLine("Invalid");
                        break;
                }
            }
        }
    }
}