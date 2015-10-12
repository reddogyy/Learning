/*Problem 12. Index of letters

Write a program that creates an array containing all letters from the alphabet (A-Z).
Read a word from the console and print the index of each of its letters in the array.
 */
using System;

class IndexOfLetters
{
    static void Main()
    {
        char[] alphaBet = { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z' };
        Console.Write("Please enter a word : ");
        string userInput = Console.ReadLine();
        char[] userInputChars = new char[userInput.Length];
        string toUpper = userInput.ToUpper();
        userInputChars = toUpper.ToCharArray();
        char tempChar;
        for (int i = 0; i < userInputChars.Length; i++)
        {
            tempChar = userInputChars[i];
            for (int j = 0; j < alphaBet.Length; j++)
            {
                if (tempChar == alphaBet[j])
                {
                    Console.WriteLine("The letter {0} is on possition {1} at the AlphaBet array .", userInput[i], j);
                    break;
                }
            }
        }
    }
}

