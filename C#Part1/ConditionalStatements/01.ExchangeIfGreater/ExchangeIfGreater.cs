/*Problem 1. Exchange If Greater

Write an if-statement that takes two double variables a and b and exchanges their values if the first one is greater than the second one. As a result print the values a and b, separated by a space.
 */

using System;
class ExchangeIfGreater
{
    static void Main()
    {
        double numberA;
        double numberB;
        Console.Write("Please enter first number : ");
        numberA = double.Parse(Console.ReadLine());
        Console.Write("Please enter second number : ");
        numberB = double.Parse(Console.ReadLine());
        if (numberA < numberB)
        {
            Console.WriteLine("Number {0} is greater then {1}.", numberA, numberB);
            Console.WriteLine("{0} , {1}", numberA, numberB);
        }
        else
        {
            Console.WriteLine("Number {0} is greater then {1}.", numberB, numberA);
            Console.WriteLine("{0} , {1}", numberB, numberA);
        }
    }
}

