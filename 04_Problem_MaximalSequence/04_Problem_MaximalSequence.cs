using System;

//Maximal sequence

//Write a program that finds the maximal sequence of equal elements in an array.


class MaximalSequence
{
    static void Main()
    {
        int[] arr = { 2, 1, 1, 2, 3, 3, 2, 2, 2, 1};
        int number = 0; 
        int sequence = 1;
        int maxSequence = 1;
        for (int i = 0; i < arr.Length-1; i++)
        {
            if (arr[i] == arr[i + 1])
            {
                sequence++;
                if (sequence > maxSequence) 
                {
                    maxSequence = sequence;
                    number = arr[i];
                }
            }
            else
            {
                sequence = 1;
            }
        }
        Console.Write("The Max Sequence of Equal Elements is : ");
        for (int i = 0; i < maxSequence; i++)
        {
            Console.Write(" {0} ", number);
        }
        Console.WriteLine();
    }
}
