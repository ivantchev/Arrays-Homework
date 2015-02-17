using System;

//Index of letters

//Write a program that creates an array containing all letters from the alphabet (A-Z).
//Read a word from the console and print the index of each of its letters in the array.

class IndexOfLetters
{
    static void Main()
    {
        char[] charArr = new char[] {'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N'
            , 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z','a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n'
            , 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z'};

        Console.Write("Please enter a word: ");
        string text = Console.ReadLine();

        for (int i = 0; i < text.Length; i++)
        {
            for (int j = 0; j < charArr.Length; j++)
            {
                if (text[i] == charArr[j])
                {
                    Console.WriteLine("The letter {0} has an index of:  {1} ", text[i], j);
                }
            }
        }

    }
}

