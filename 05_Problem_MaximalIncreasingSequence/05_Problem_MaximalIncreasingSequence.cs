using System;

//Write a program that finds the maximal increasing sequence in an array.
//Example:

//input	result
//3, 2, 3, 4, 2, 2, 4	2, 3, 4

class MaximalIncreasingSequence
{
    static void Main()
    {
        int[] array = { 3, 2, 3, 4, 2, 2, 4 };

        int counter = 1;
        int maxSequence = 1;
        int bestStart = 0;

        for (int i = 0; i < array.Length - 1; i++)
        {
            if (array[i] < array[i + 1])
            {
                counter++;
            }
            else if (array[i] > array[i + 1])
            {
                if (counter > maxSequence)
                {
                    maxSequence = counter;
                    counter = 1;
                    bestStart = i - maxSequence + 1;
                }
                counter = 1;
            }
        }
        Console.Write("The maximal increasing sequence is: ");
        for (int i = bestStart; i <= maxSequence; i++)
        {
            Console.Write(array[i]+ " ");
        }
        Console.WriteLine();

    }
}
