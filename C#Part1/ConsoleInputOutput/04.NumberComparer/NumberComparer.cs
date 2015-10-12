/*Problem 4. Number Comparer

Write a program that gets two numbers from the console and prints the greater of them.
Try to implement this without if statements.
 */

using System;
class NumberComparer
{
    static void Main()
    {
        double firstNumber;
        Console.Write("Please eanter your first number : ");
        firstNumber = double.Parse(Console.ReadLine());
        double secondNumber;
        Console.Write("Please enter your second number : ");
        secondNumber = double.Parse(Console.ReadLine());
        if (firstNumber > secondNumber)
        {
            Console.WriteLine("The number {0} is bigger then {1}", firstNumber, secondNumber);
        }
        else
        {
            Console.WriteLine("The number {0} is bigger then {1}", secondNumber, firstNumber);
        }
    }
}
