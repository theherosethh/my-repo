using System;

class Exercise3
{
	public void run()
	{
        /*
         * Problem:
         * Create a jagged array to store test scores of 3 students.
         * - Student 1 has 2 test scores
         * - Student 2 has 4 test scores
         * - Student 3 has 3 test scores
         * Ask the user to input the scores.
         * Then display all scores in table format.
         */

        // TODO: Write your code here

        //Create jagged array
        int[][] scores = new int[3][];
        scores[0] = new int[2];
        scores[1] = new int[4];
        scores[2] = new int[3];

        //Input
        Console.WriteLine("Enter all students and scores:");
        for (int i = 0; i < scores.Length; i++)
        {
            Console.WriteLine($"\nEnter scores for student number {i + 1}:");
            for (int j = 0; j < scores[i].Length; j++)
            {
                Console.Write("\nEnter test scores: "); //include numbers of score for each element of array??
                scores[i][j] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine();   
        }

        //Display all scores in table format.
        Console.WriteLine("\nAll students scores in table format");
        for (int i = 0; i < scores.Length; i++)
        {
            Console.Write($"Student {i + 1} : ");
            for (int j = 0; j < scores[i].Length; j++)
            {
                Console.Write(scores[i][j] + " ");
            }
            Console.WriteLine();
        }
        
    } 
}
