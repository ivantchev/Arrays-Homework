using System;
//Maximal K sum

//Write a program that reads two integer numbers N and K and an array of N elements from the console.
//Find in the array those K elements that have maximal sum.
class MaximalKSum
{
    static void Main()
    {
        Console.Write("Please enter the number of N elements in the array: ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("Please enter the number of K elements: ");
        int k = int.Parse(Console.ReadLine());

        int[] array = new int[n];

        for (int i = 0; i < array.Length; i++)
        {
            Console.Write("array[{0}]= ", i);
            array[i] = int.Parse(Console.ReadLine());
        }
        Array.Sort(array);
        int sum = 0;
        for (int i = 0; i < k; i++)
        {
            sum += array[array.Length - i - 1];
        }
        Console.WriteLine("The max sum of {0} elements in the array is {1}.", k, sum);
    }
}