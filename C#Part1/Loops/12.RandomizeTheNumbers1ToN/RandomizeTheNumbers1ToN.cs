/*
 * Problem 12.* Randomize the Numbers 1…N

Write a program that enters in integer n and prints the numbers 1, 2, …, n in random order.
 */

using System;
class RandomizeTheNumbers1ToN
{
    static void Main()
    {
        Console.Write("Please enter a value for N :");
        int numberN = int.Parse(Console.ReadLine());
        int[] array = new int[numberN];
        for (int index = 0; index < numberN; index++)
        {
            array[index] = index +1;
        }
        Random randomNumber = new Random();

        foreach (int index in array)
        {
            int randNum = randomNumber.Next(0, numberN);
            int temp = array[randNum];
            array[randNum] = array[0];
            array[0] = temp;
        }
        Console.WriteLine(String.Join(" ", array));
    }
}

