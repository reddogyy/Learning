﻿/*Problem 13. Solve tasks

Write a program that can solve these tasks:
Reverses the digits of a number
Calculates the average of a sequence of integers
Solves a linear equation a * x + b = 0
Create appropriate methods.
Provide a simple text-based menu for the user to choose which task to solve.
Validate the input data:
The decimal number should be non-negative
The sequence should not be empty
a should not be equal to 0
 */

using System;

using System.Linq;
using System.Text;


class SolveTasks
    {
    static void Reverse()
    {
        Console.WriteLine("\n{0}\n", new string('-', 40));

        decimal number = 0;
        do
        {
            Console.Write("Enter a non-negative number (real or integer): ");
            number = decimal.Parse(Console.ReadLine());
        }
        while (number < 0);

        string temp = number.ToString();
        string result = string.Empty;
        StringBuilder sb = new StringBuilder();
        for (int i = temp.Length - 1; i >= 0; i--)
        {
            sb.Append(temp[i]);
        }

        Console.WriteLine(" {0} ", sb.ToString());

        return;
    }
    static void Avarage()
    {
        Console.WriteLine("\n{0}\n", new string('-', 40));

        int n = 0;
        do
        {
            Console.Write("Enter a non-negative number N (size of array): ");
            n = int.Parse(Console.ReadLine());
        }
        while (n <= 0);

        int[] numbers = new int[n];
        Console.WriteLine("\nEnter a {0} number(s) to array: ", n);
        for (int i = 0; i < numbers.Length; i++)
        {
            Console.Write("   {0}: ", i + 1);
            numbers[i] = int.Parse(Console.ReadLine());
        }
        Console.WriteLine("\nAverage sum = {0}\n\n{1}\n", numbers.Average(),
            new string('-', 40));

        return;

    }
    static void LinearEquation()
    {
        Console.WriteLine("\n{0}\n", new string('-', 40));

        decimal a = 0;

        do
        {
            Console.Write("Enter a non-zero number A: ");
            a = decimal.Parse(Console.ReadLine());
        }
        while (a == 0);

        Console.Write("Enter a number B: ");
        decimal b = decimal.Parse(Console.ReadLine());

        Console.WriteLine("\nResult -> x = -b / a = {0}\n\n{1}\n", -b / a,
            new string('-', 40));

    }
        static void Main()
        {
            string userChoice = "0";

            while (userChoice == "0")
            {
                Console.WriteLine("Program options: ");
                Console.WriteLine("   1) Reverses the digits of a number");
                Console.WriteLine("   2) Calculates the average of a sequence of integers");
                Console.WriteLine("   3) Solves a linear equation 'a * x + b = 0'");

                Console.Write("\nEnter your choice: ");
                userChoice = Console.ReadLine();

                switch (userChoice)
                {
                    case "1": 
                        Reverse();
                        return;
                    case "2": 
                        Avarage(); 
                        return;
                    case "3": 
                        LinearEquation(); 
                        return;
                    default:
                        Console.Clear();
                        userChoice = "0";
                        break;
                }
            }
        }
    }

