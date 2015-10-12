﻿/*Problem 1. Square root

Write a program that reads an integer number and calculates and prints its square root.
If the number is invalid or negative, print Invalid number.
In all cases finally print Good bye.
Use try-catch-finally block.
 */

using System;

class SquareRoot
{
    static void Main()
    {
        Console.Write("PLease enter a number : ");
        try
        {
            double value = double.Parse(Console.ReadLine());

            if (value < 0)
            {
                Console.WriteLine("Invalid number");
            }
            else
            {
                Console.WriteLine("Square root = {0}", Math.Sqrt(value));
            }
        }
        catch (FormatException)
        {
            Console.WriteLine("Invalid number");
        }
        catch (ArgumentNullException)
        {
            Console.WriteLine("Value not entered");
        }
        catch (OverflowException)
        {
            Console.WriteLine("Value overflowed");
        }
        finally
        {
            Console.WriteLine("Goodbye!");
        }
    }
}
