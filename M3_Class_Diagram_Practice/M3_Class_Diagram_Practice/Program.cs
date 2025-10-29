using System;

namespace M3_Class_Diagram_Practice
{
	class Program
	{

		static void UserMenu()
		{
			bool backToMain = false;

			while (!backToMain)
			{
				Console.Clear();
				Console.WriteLine("---- USER MANAGEMENT ----");
				Console.WriteLine("1. Add User");
				Console.WriteLine("2. Edit User");
				Console.WriteLine("3. Delete Users");
				Console.WriteLine("0. Back to Main Menu");
				Console.Write("Select an option: ");

				string choice = Console.ReadLine();

				switch (choice)
				{
					case "1":
						Console.WriteLine("Adding new user...");
						break;
					case "2":
						Console.WriteLine("Edit user...");
						break;
					case "3":
						Console.WriteLine("Delete all users...");
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
		static void RoleMenu()
		{
			Roles roles = new Roles();

			bool backToMain = false;

			while (!backToMain)
			{
				Console.Clear();
				Console.WriteLine("---- USER MANAGEMENT ----");
				Console.WriteLine("1. Add Role");
				Console.WriteLine("2. Edit Role");
				Console.WriteLine("3. Delete Role");
				Console.WriteLine("4. View Role");
				Console.WriteLine("0. Back to Main Menu");
				Console.Write("Select an option: ");

				string choice = Console.ReadLine();

				switch (choice)
				{
					case "1":
						//Console.WriteLine("Adding new role...");
						
						roles.addRole();

						break;
					case "2":
						roles.editRole();
						break;
					case "3":
						
						roles.deleteRole();
						break;
					case "4":
						roles.viewRole();
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
			/* Main Menu
			 * 1. User Management
			 * 2. Role Management
			 * 0. Exit
			 * 
			 * Enter: 1
			 * User Management
			 * 1. Add New User
			 * 2. Edit User
			 * 3. Delete User
			 * 4. View User
			 * 5. Login
			 * 0. Back to Main
			 * 
			 * Enter: 2
			 * 1. Add New Role
			 * 2. Edit Role
			 * 3. Delete Role
			 * 4. View Role
			 * 0. Back to Main
			 * 
			 * 
			 */
			bool exitProgram = false;

			while (!exitProgram)
			{
				Console.Clear();
				Console.WriteLine("==== MAIN MENU ====");
				Console.WriteLine("1. User Management");
				Console.WriteLine("2. Role Management");
				Console.WriteLine("0. Exit");
				Console.Write("Select an option: ");

				string choice = Console.ReadLine();

				switch (choice)
				{
					case "1":
						UserMenu();
						break;
					case "2":
						RoleMenu();
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