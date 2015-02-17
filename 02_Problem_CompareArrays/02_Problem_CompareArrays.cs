using System;

//Write a program that reads two integer arrays from the console and compares them element by element.

class CompareArrays
{
    static void Main()
    {
        Console.WriteLine("We are going to compare two Arrays");

        Console.Write("Please, enter the size of the first array: ");
        int n = int.Parse(Console.ReadLine());
        int[] firstArr = new int[n];

        Console.Write("Please, enter the size of the second array: ");
        int p = int.Parse(Console.ReadLine());
        int[] secondArr = new int[p];

        bool compareArr = true;
        if (n == p)
        {
            Console.WriteLine(" Enter the numbers for the first Array: ");
            for (int i = 0; i < n; i++)
            {
                Console.Write("First Array Elements[{0}]: ", i);
                firstArr[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine(" Enter the numbers for the second Array");
            for (int i = 0; i < p; i++)
            {
                Console.Write("Second Array Elements[{0}]: ", i);
                secondArr[i] = int.Parse(Console.ReadLine());
            }
            for (int i = 0; i < n; i++)
            {
                if (firstArr[i] != secondArr[i])
                {
                    compareArr = false;
                    break;
                }
            }
        }
        else
        {
            compareArr = false;
        }
        Console.WriteLine("Are they Equal:  ---> {0}", compareArr);
    }
}