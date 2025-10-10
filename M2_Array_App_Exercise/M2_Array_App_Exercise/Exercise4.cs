using System;

class Exercise4
{
	public void run()
	{
        /*
         * Problem:
         * Create an array of 5 strings to store favorite colors.
         * Fill the array with values entered by the user.
         * Print all colors using a foreach loop.
         */

        // TODO: Write your code here

        //Create a array
        string[] colors = new string[5];
        Console.WriteLine("Enter 5 favorite colors");
        for (int i = 0; i < 5; i++)
        {
            Console.Write($"Enter color {i + 1}: ");
            colors[i] = Console.ReadLine();
            Console.WriteLine();
        }
        
        foreach( string color in colors )
        {
            Console.WriteLine($"Your favorite colors are {color}");   
        }

    }
}
