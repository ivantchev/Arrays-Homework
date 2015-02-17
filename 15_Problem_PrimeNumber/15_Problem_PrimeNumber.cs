using System;

//Prime numbers

//Write a program that finds all prime numbers in the range [1...10 000 000]. Use the Sieve of Eratosthenes algorithm.

class PrimeNumber
{
    static void Main()
    {
        int n = 20;
        bool[] element = new bool[n];

        for (int i = 0; i < element.Length; i++)
        {
            element[i] = true;
        }
        for (int i = 2; i < element.Length; i++)
        {
            if (element[i]) 
            {
                for (int j = 2; j * i < element.Length; j++)
                {
                    element[j * i]  = false;
                }            
            }
        }
        for (int i = 2; i < element.Length; i++)
        {
            if (element[i] == true)
            {
                Console.Write(i + " ");
            }
        }
    }
}
