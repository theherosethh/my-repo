using System;
using System.Collections.Generic;

namespace M3_Class_Diagram_Practice
{
	public class Roles
	{
		// Store Role objects instead of strings
		static List<Roles> roles = new List<Roles>();

		public Users UsersRoles { get; set; }  // Optional relationship to another class
		public string Id { get; set; }
		public string Role { get; set; }

		public void addRole()
		{
			Console.Clear();
			Console.WriteLine("===== Add New Role =====");
			Console.Write("Enter Role ID: ");
			string id = Console.ReadLine();
			Console.Write("Enter Role Name: ");
			string roleName = Console.ReadLine();

			if (!string.IsNullOrWhiteSpace(id) && !string.IsNullOrWhiteSpace(roleName))
			{
				// Create a new Role object and add it to the list
				Roles newRole = new Roles
				{
					Id = id,
					Role = roleName
				};
				roles.Add(newRole);

				Console.WriteLine($"\n✅ Role Added Successfully!");
				Console.WriteLine($"ID: {id}, Role Name: {roleName}");
			}
			else
			{
				Console.WriteLine("❌ Role ID and Name cannot be empty. Try again.");
			}

			Console.WriteLine("\nPress Enter to return to menu...");
			Console.ReadLine();
		}

		public void editRole()
		{
			Console.Clear();
			Console.WriteLine("===== Edit Role =====");
			Console.Write("Enter Role ID to edit: ");
			string id = Console.ReadLine();

			Roles existingRole = roles.Find(r => r.Id == id);
			if (existingRole != null)
			{
				Console.Write($"Enter new Role Name for ID {id}: ");
				string newRoleName = Console.ReadLine();
				existingRole.Role = newRoleName;
				Console.WriteLine("✅ Role updated successfully!");
			}
			else
			{
				Console.WriteLine("❌ Role not found!");
			}

			Console.WriteLine("\nPress Enter to return to menu...");
			Console.ReadLine();
		}

		public void deleteRole()
		{
			Console.Clear();
			Console.WriteLine("===== Delete Role =====");
			Console.Write("Enter Role ID to delete: ");
			string id = Console.ReadLine();

			Roles roleToRemove = roles.Find(r => r.Id == id);
			if (roleToRemove != null)
			{
				roles.Remove(roleToRemove);
				Console.WriteLine("✅ Role deleted successfully!");
			}
			else
			{
				Console.WriteLine("❌ Role not found!");
			}

			Console.WriteLine("\nPress Enter to return to menu...");
			Console.ReadLine();
		}

		public void viewRole()
		{
			Console.Clear();
			Console.WriteLine("=== LIST OF ROLES ===");

			if (roles.Count == 0)
			{
				Console.WriteLine("No roles found. Please add some roles first.");
			}
			else
			{
				Console.WriteLine($"{"ID",-10} {"Role Name",-20}");
				Console.WriteLine(new string('-', 30));

				foreach (var role in roles)
				{
					Console.WriteLine($"{role.Id,-10} {role.Role,-20}");
				}
			}

			Console.WriteLine("\nPress Enter to return to menu...");
			Console.ReadLine();
		}
	}
}
