using System;

//Frequent number

//Write a program that finds the most frequent number in an array.
//Example:

//input	result
//4, 1, 1, 4, 2, 3, 4, 4, 1, 2, 4, 9, 3	4 (5 times)

class FrequentNumber
{
    static void Main()
    {
        int[] arr = { 4, 1, 1, 4, 2, 3, 4, 4, 1, 2, 4, 9 };
        int b = 0;
        int max = 0; // zapametqvame dadena sreshtanta cifra
        int counter = 1;//broq4, kolko pati se sreshta dadenata cifra

        for (int i = 0; i < arr.Length; i++)
        {
            int a = arr[i]; // promenliva da mi pazi elementa na tekushtata poziciq i.

            for (int j = i + 1; j < arr.Length; j++)
            {
                if (a == arr[j])
                {
                    counter++;
                    if (counter > max) // proverka, kolko pati se sreshta
                    {
                        max = counter;
                        counter = 1;
                        b = a;
                    }
                }
            }
        }
        Console.Write("The most frequent number is: {0} and it is repeated --> {1} times ", b, max);
    }
}

