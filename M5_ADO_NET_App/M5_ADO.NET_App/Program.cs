using System;
using System.Data;

namespace M5_ADO.NET_App
{
    class Program
    {
        static void User_main()
        {
           
            bool backToMain = false;

            while (!backToMain)
            {
                Console.WriteLine("-----User Management-----");
                Console.WriteLine("1. View User");
                Console.WriteLine("2. Add User");
                Console.WriteLine("3. Edit User");
                Console.WriteLine("4. Delete User");
                Console.WriteLine("0. Back to Main Menu");
                Console.WriteLine("--------------------------");
                Console.Write("Select an option: ");

                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        Users users = new Users();
                        users.ViewUser();
                        //users.ConnectSQL();
                        
                        break;
                    case "2":
                        Console.WriteLine("Add User");
                        break;
                    case "3":
                        Console.WriteLine("Edit User");
                        break;
                    case "4":
                        Console.WriteLine("Delete User");
                        break;
                    case "0":
                        backToMain = true;
                        break;
                    default:
                        Console.WriteLine("Invalid choice! Press Enter to try again...");
                        Console.ReadLine();
                        break;
                }

                if (!backToMain)
                {
                    Console.WriteLine("Press Enter to continue...");
                    Console.ReadLine();
                }
            }
        }
        static void Main(string[] args)
        {
            bool exitProgram = false;

            while (!exitProgram)
            {
                Console.Clear();
                Console.WriteLine("==== MAIN MENU ====");
                Console.WriteLine("1. User Management");
                Console.WriteLine("0. Exit");
                Console.Write("Select an option: ");

                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        User_main();
                        break;
                    case "0":
                        exitProgram = true;
                        break;
                    default:
                        Console.WriteLine("Invalid choice! Press Enter to try again...");
                        Console.ReadLine();
                        break;
                }
            }
        }
    }
}
