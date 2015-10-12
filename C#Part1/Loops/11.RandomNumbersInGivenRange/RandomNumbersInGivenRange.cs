/*Problem 11. Random Numbers in Given Range

Write a program that enters 3 integers n, min and max (min != max) and prints n random numbers in the range [min...max].
 */

using System;
class RandomNumbersInGivenRange
{
    static void Main()
    {
        Console.Write("Please enter a value for N:");
        int numberN = int.Parse(Console.ReadLine());
        Console.Write("Please enter a min value:");
        int minValue = int.Parse(Console.ReadLine());
        Console.Write("Please enter a max valuie :");
        int maxValue = int.Parse(Console.ReadLine());
        Random randomNumber = new Random();
        if (minValue != maxValue)
        {
            for (int i = 0; i < numberN; i++)
            {
                Console.Write(randomNumber.Next(minValue, maxValue+1));
                Console.Write(" ");
            }
        }
        else
        {
            Console.WriteLine("You entered one and a same value for min {0} , and for max {1}", minValue, maxValue);
        }
        Console.WriteLine();
    }
}
