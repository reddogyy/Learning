/*Problem 9. Sum of n Numbers

Write a program that enters a number n and after that enters more n numbers and calculates and prints their sum. Note: You may need to use a for-loop.
 */

using System;
class SumOfNNumbers
{
    static void Main()
    {
        int numbers;
        Console.Write("Please enter how much numbers you will enter :");
        numbers = int.Parse(Console.ReadLine());
        double sum = 0D;
        double number;
        for (int i = 1; i <= numbers; i++)
        {
            Console.WriteLine("Please enter a number : ");
            number = double.Parse(Console.ReadLine());
            sum += number;
        }
        Console.WriteLine("The sum of the numbers is : {0}", sum);
    }
}

