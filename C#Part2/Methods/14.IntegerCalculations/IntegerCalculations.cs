/*Problem 14. Integer calculations

Write methods to calculate minimum, maximum, average, sum and product of given set of integer numbers.
Use variable number of arguments.
 */



using System;
using System.Linq;



class IntegerCalculations
{
    static int GetMax(int[] numbers)
    {
        		int max = numbers[0];

		for (int i = 1; i < numbers.Length; i++)
		{
			if (numbers[i] > max) max = numbers[i];
		}
		return max;
    }
    static int GetMin(int[] numbers)
    {
        int min = numbers[0];

		for (int i = 1; i < numbers.Length; i++)
		{
			if (numbers[i] < min) min = numbers[i];
		}
		return min;
    }
    static decimal GetAvarage(int[] numbers)
    {
        decimal avarage = (decimal)numbers.Sum() / numbers.Length;
        return avarage;
    }
    static int GetSum(int[] numbers)
    {
        int sum = 0;
        for (int i = 0; i < numbers.Length; i++)
        {
            sum += numbers[i];
        }
        return sum;
    }
    static int GetProduct(int[] numbers)
    {
        return numbers.Aggregate(1, (current, t) => current * t);
    }
    static void Main()
    {
        Console.Write("Please enter the nubmer of integers that you will enter : ");
        int numberLength = int.Parse(Console.ReadLine());
        int[] numbersArray = new int[numberLength];
        for (int i = 0; i <numberLength ; i++)
        {
            numbersArray[i] = int.Parse(Console.ReadLine());
        }
        Console.WriteLine("The sum of entered numbers is : {0}", GetSum(numbersArray));
        Console.WriteLine("The max of entered numbers is : {0}", GetMax(numbersArray));
        Console.WriteLine("The min of entered numbers is : {0}", GetMin(numbersArray));
        Console.WriteLine("The avarage of entered numbers is : {0}", GetAvarage(numbersArray));
        Console.WriteLine("The product of entered numbers is : {0}", GetProduct(numbersArray));
    }
}

