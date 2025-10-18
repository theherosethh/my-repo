using System;

namespace ClassTypesPractice
{
	// ========================================================
	// 1. Abstract Class Example
	// ========================================================
	abstract class Vehicle
	{
		public abstract void Start();   // Abstract method

		public void Stop()              // Normal method
		{
			Console.WriteLine("Vehicle stopped.");
		}
	}

	class Car : Vehicle
	{
		public override void Start()
		{
			Console.WriteLine("Car engine started.");
		}
	}
	class Plane : Vehicle
	{
        public override void Start()
        {
			Console.WriteLine("Plane engine started.");
        }
	}


	// ========================================================
	// 2. Concrete Class Example
	// ========================================================
	class Book
	{
		public string Title { get; set; }
		public string Author { get; set; }

		public void ShowInfo()
		{
			Console.WriteLine($"Book: {Title}, Author: {Author}");
		}
	}

	// ========================================================
	// 3. Sealed Class Example
	// ========================================================
	sealed class Logger
	{
		public void Log(string message)
		{
			Console.WriteLine($"[LOG]: {message}");
		}
	}

	// ========================================================
	// 4. Partial Class Example
	// ========================================================
	partial class Employee
	{
		public string FirstName { get; set; }
	}

	partial class Employee
	{
		public string LastName { get; set; }

		public void ShowFullName()
		{
			Console.WriteLine($"{FirstName} {LastName}");
		}
	}

	// ========================================================
	// 5. Static Class Example
	// ========================================================
	static class MathTools
	{
		public static int Square(int n) => n * n;
		public static int Cube(int n) => n * n * n;
	}

	// ========================================================
	// Main Program with Menu
	// ========================================================
	class Program
	{
		static void Main(string[] args)
		{
			int choice;
			do
			{
				Console.WriteLine("\n=== C# Class Types Practice ===");
				Console.WriteLine("1. Abstract Class");
				Console.WriteLine("2. Concrete Class");
				Console.WriteLine("3. Sealed Class");
				Console.WriteLine("4. Partial Class");
				Console.WriteLine("5. Static Class");
				Console.WriteLine("0. Exit");
				Console.Write("Enter your choice: ");

				if (!int.TryParse(Console.ReadLine(), out choice))
				{
					Console.WriteLine("Invalid input! Please enter a number.");
					continue;
				}

				Console.WriteLine(); // spacing

				switch (choice)
				{
					case 1:
						// ABSTRACT CLASS PRACTICE
						// Task: Create another Vehicle type (e.g., Bike) that overrides Start()
						Plane A_plane = new Plane();
						A_plane.Start();
						break;
						

					case 2:
						// CONCRETE CLASS PRACTICE
						// Task: Create another Book object and display both.

						Book new_book = new Book();
						new_book.Author = "Seth";
						new_book.Title = "Self-help book";
						new_book.ShowInfo();
						break;

					case 3:
						// SEALED CLASS PRACTICE
						// Task: Try to inherit Logger class → what error do you see?
						
						Logger loggers = new Logger();
						loggers.Log("Error");
						break;

					case 4:
						// PARTIAL CLASS PRACTICE
						// Task: Add MiddleName property in another partial class definition.

						
						break;

					case 5:
						// STATIC CLASS PRACTICE
						// Task: Add a new method Factorial(int n) inside MathTools.
						
						break;

					case 0:
						Console.WriteLine("Exiting program...");
						break;

					default:
						Console.WriteLine("Invalid choice. Try again!");
						break;
				}
			}
			while (choice != 0);
		}
	}
}
