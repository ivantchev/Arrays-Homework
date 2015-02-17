using System;
//Maximal sum

//Write a program that finds the sequence of maximal sum in given array.
//Example:

//input	result
//2, 3, -6, -1, 2, -1, 6, 4, -8, 8	2, -1, 6, 4

class MaximalSum
{
    static void Main()
    {
        int[] arr = { 2, 3, -6, -1, 2, -1, 6, 4, -8, 8 };
        int bestStart = 0;
        int sum = 0;
        int bestSum = 0;
        int end = 0;

        for (int i = 0; i < arr.Length; i++)
        {
            sum = arr[i];// indexa, koito se namira na i-ta poziciq
            for (int j = i + 1; j < arr.Length; j++)
            {
                if (sum > bestSum)
                {
                    bestSum = sum;
                    bestStart = i;
                    end = j; // zapametqvame tukushtata poziciq, kydeto tezi elementi sa s nai-golqma suma
                }
                sum += arr[j];
            }
        }
        Console.WriteLine("The maximal sequence");
        for (int i = bestStart; i < end; i++)
        {
            if (i != arr.Length - 1)
            {
                Console.Write(" ,");
            }
            Console.Write(arr[i]);
        }
        Console.WriteLine();
    }
}
