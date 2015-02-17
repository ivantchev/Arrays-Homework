using System;

//Write a program that allocates array of 20 integers and initializes each element by its index multiplied by 5.
//Print the obtained array on the console.

class AllocateArray
{
    static void Main()
    {
        int[] arr = new int[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19 };
        for (int index = 0; index < arr.Length; index++)
        {
            Console.WriteLine("Element[{0}] = {1}", index, arr[index] * 5);
        }
    }
}

