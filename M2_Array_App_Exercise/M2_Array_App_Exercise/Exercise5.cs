using System;
using System.Numerics;

class Exercise5
{
	public void run()
	{
        /*
         * Problem:
         * Create two 2D arrays (matrices) of size 2x2.
         * Ask the user to enter the values of both matrices.
         * Multiply the two matrices and store the result in a third matrix.
         * Print the result matrix.
         */

        // TODO: Write your code here

        //Declare 2D arrays
        //first matrices
        int[,] matrices1 = new int[2, 2];
        Console.WriteLine("Enter value of metrics1");
        for (int i = 0; i < 2; i++)
        {
            Console.WriteLine($"Enter value of rows {i + 1}: ");
            for (int j = 0; j < 2; j++)
            {
                Console.WriteLine($"Enter value of columns {j + 1} : ");
                matrices1[i, j] = int.Parse( Console.ReadLine() );
            }
            Console.WriteLine();
        }
        //second matrices
        int[,] matrices2 = new int[2, 2];
        Console.WriteLine("Enter value of metrics2");
        for (int i = 0; i < 2; i++)
        {
            Console.WriteLine($"Enter value of rows {i + 1}: ");
            for (int j = 0; j < 2; j++)
            {
                Console.WriteLine($"Enter value of columns {j + 1} : ");
                matrices2[i, j] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine();
        }
        //Multiply both matrices
        int[,] c = new int[2, 2];
        for (int i = 0; i < 2; i++)
        {
            for (int j = 0; j < 2; j++)
            {
                c[i, j] = 0;
                for (int k = 0; k < 2; k++)
                {
                    c[i, j] += matrices1[i, k] * matrices2[k, j]; 
                }
            }
        }
        //Print result 
        Console.WriteLine("\nResult matrix (AxB):");
        for (int i = 0; i < 2; i++)
        {
            for (int j = 0; j < 2; j++)
            {
                Console.Write(c[i, j] + "\t");
            }
            Console.WriteLine();
        }

    }
}
