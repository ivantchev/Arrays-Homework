using System;
//Selection sort

//Sorting an array means to arrange its elements in increasing order. Write a program to sort an array.
//Use the Selection sort algorithm: Find the smallest element, move it at the first position, 
//find the smallest from the rest, move it at the second position, etc.

class SelectionSort
{
    static void Main()
    {
        Console.Write("Please enter the size of the array: ");
        int n = int.Parse(Console.ReadLine());
        int[] arr = new int[n];
        for (int i = 0; i < arr.Length; i++)
        {
            Console.Write("Please enter the elements: ");
            arr[i] = int.Parse(Console.ReadLine());
        }

        for (int i = 0; i < arr.Length - 1; i++)
        {
            for (int j = i + 1; j < arr.Length; j++)
            {
                if (arr[i] > arr[j])
                {
                    int temp = arr[i];
                    arr[i] = arr[j];
                    arr[j] = temp;
                }
            }
        }
        Console.Write("Sorted array: ");
        for (int i = 0; i < arr.Length; i++)
        {
            Console.Write(arr[i]);
            if (i != arr.Length - 1)
            {
                Console.Write(", ");
            }
        }
        Console.WriteLine();
    }
}
