using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M2_Array_App
{
	internal class ArrayList
	{
		static void Main(string[] args)
		{

			/*C# ArrayList: In C#, an ArrayList stores elements of multiple data types whose size can be changed dynamically
			 * 
			 * 
			 * 
			 * 
			 * 
			 */
			/*
			// create an ArrayList
			ArrayList student = new ArrayList();

			// add elements to ArrayList
			student.Add("Jackson");
			student.Add(5);

			// display every element of myList 
			for (int i = 0; i < student.Count; i++)
			{
				Console.WriteLine(student[i]);
			}
			*/
			/*
			Create an ArrayList

			To create ArrayList in C#, we need to use the System.Collections namespace. Here is how we can create an arraylist in C#.

			// create an arraylist
			ArrayList myList = new ArrayList();

			Here, we have created an arraylist named myList.
			Basic Operations on ArrayList

			In C#, we can perform different operations on arraylists. We will look at some commonly used arraylist operations in this tutorial:

				Add Elements
				Access Elements
				Change Elements
				Remove Elements

			*/


			/*Add Elements in ArrayList
			// create an ArrayList
			ArrayList student = new ArrayList();

			// add elements to ArrayList
			student.Add("Tina");
			student.Add(5);
			*/


			/*Add Elements in an ArrayList using Object Initializer Syntax
			// create an ArrayList using var  
			ArrayList myList = new ArrayList() { "Pizza", 24, "Pen" };

			// iterate through items
			for (int i = 0; i < myList.Count; i++)
			{
				Console.WriteLine(myList[i]);
			}
			*/

			/*Add Elements in an ArrayList at specified index 
			 
			// create an ArrayList 
			ArrayList schoolDetails = new ArrayList();
			schoolDetails.Add("Mary's");
			schoolDetails.Add("France");
			schoolDetails.Add(23);

			// access the first element 
			Console.WriteLine("First element: " + schoolDetails[0]);

			// access the second element 
			Console.WriteLine("Second element: " + schoolDetails[1]);
			*/


			/*Iterate ArrayList 
			 

			// create an ArrayList containing 3 elements 
			ArrayList myList = new ArrayList();

			myList.Add("Science");
			myList.Add(true);
			myList.Add(5);

			// display every element of myList 
			for (int i = 0; i < myList.Count; i++)
			{
				Console.WriteLine(myList[i]);
			}
			*/

			/*Change ArrayList Elements 
			 
			// create an ArrayList 
			ArrayList myList = new ArrayList();

			myList.Add("Harry");
			myList.Add("Miller");

			Console.WriteLine("Original Second element: " + myList[1]);

			// change the value of second element 
			myList[1] = "Styles";

			Console.WriteLine("Updated second element: " + myList[1]);
			*/

			/*Remove ArrayList Elements: C# provides methods like Remove(), RemoveAt(), RemoveRange() to remove elements from ArrayList. 
			
			
			// create an ArrayList 
			ArrayList myList = new ArrayList();
			myList.Add("Jack");
			myList.Add(4);
			myList.Add("Jimmy");

			// remove "Jack" from myList
			myList.Remove("Jack");


			// iterate through myList after removing "Jack"
			for (int i = 0; i < myList.Count; i++)
			{
				Console.WriteLine(myList[i]);
			}
			*/

		}


	}
}
