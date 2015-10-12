/*Problem 13. Reverse sentence

Write a program that reverses the words in given sentence.
 */

using System;
class ReverseSentence
{
    static void Main()
    {
        Console.Write("Please enter a string and at the end use sign (.  ! ?): ");
        string text = Console.ReadLine();
        char sigh = text[text.Length - 1];
        text = text.Remove(text.Length - 1, 1);

        string[] words = text.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

        Array.Reverse(words);

        Console.WriteLine("Result: {0}{1}\n", string.Join(" ", words), sigh);
    }
}

