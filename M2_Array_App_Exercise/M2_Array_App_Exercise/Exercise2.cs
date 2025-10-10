using System;
using System.Xml.Schema;

class Exercise2
{
	public void run()
	{
        /*
         * Problem:
         * Create a 2D array with 4 rows and 3 columns.
         * Fill it with integer values entered by the user.
         * For each row, calculate and display the sum of its elements.
         */

        // TODO: Write your code here

        int[,] ints = new int [4, 3];
        Console.Write("Enter number of 4 rows and 3 elements each: ");
        for (int i = 0; i < 4; i++)
        {
            Console.Write($"\nRow {i + 1}");
            for (int j = 0; j < 3; j++)
            {
                Console.Write($"\nEnter element {j + 1}: ");
                ints[i, j] = int.Parse(Console.ReadLine());
            }    
        }
        Console.WriteLine("Sum of element for each row");
        for (int i = 0; i < 4; i++)
        {
            int total = 0;
            for (int j = 0; j < 3; j++)
            {
                total += ints[i, j];
            }
            Console.WriteLine($"Row {i + 1} sum of its elements {total}");
        }

    }
}
