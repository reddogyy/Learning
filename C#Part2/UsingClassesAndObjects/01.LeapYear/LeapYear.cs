﻿/*Problem 1. Leap year

Write a program that reads a year from the console and checks whether it is a leap one.
Use System.DateTime.
 */
using System;
using System.Linq;
class LeapYear
{
    static void Main()
    {
        Console.Write("Enter an year: ");
        DateTime date = DateTime.Parse("1.1." + Console.ReadLine() + "");

        Console.WriteLine("\nYear {0} is leap: {1}\n", date.Year, DateTime.IsLeapYear(date.Year));
    }
}
