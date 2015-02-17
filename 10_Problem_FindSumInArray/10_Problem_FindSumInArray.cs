using System;
//Find sum in array

//Write a program that finds in given array of integers a sequence of given sum S (if present).
//Example:

//array	                 S	    result
//4, 3, 1, 4, 2, 5, 8	 11	    4, 2, 5
class FindSumInArray
{
    static void Main()
    {
        int[] arr = { 4, 3, 1, 4, 2, 5, 8 };
        int givenSum = 11;
        int sum = 0;
        int bestStart = 0;
        int bestLenght = 0;

        for (int i = 0; i < arr.Length; i++)
        {
            sum = arr[i];
            for (int j = i+1; j < arr.Length; j++)
            {
                if (sum==givenSum)
                {
                    bestStart = i;
                    bestLenght = j;
                }
                sum += arr[j];
            }         
        }
        if (bestStart == 0 && bestLenght == 0)
        {
            Console.WriteLine("There is no such sequence {0} ", givenSum);
        }
        else
        {
            Console.WriteLine("The sequence of sum is: ");
            for (int i = bestStart; i < bestLenght; i++)
            {
                Console.WriteLine(arr[i]);
            }
        }
    }
}

