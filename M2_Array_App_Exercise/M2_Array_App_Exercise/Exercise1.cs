using System;

class Exercise1
{
	public void run()
	{
        /*
         * Problem:
         * Create a one-dimensional array of 6 integers.
         * Ask the user to enter the numbers.
         * Then find and display the largest number in the array.
         */

        // TODO: Write your code here
        int[] numbers = new int [6];
        Console.Write("Enter 6 numbers: ");
        

        for (int i = 0; i < numbers.Length; i++)
        {
            Console.Write($"Number {i + 1}: ");
            numbers[i] = int.Parse(Console.ReadLine());
        }
        int Largest = numbers.Max();

        Console.WriteLine("Largest number is" + Largest);
    
    
    }
}
