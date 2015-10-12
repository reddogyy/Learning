/*Problem 6. Quadratic Equation

Write a program that reads the coefficients a, b and c of a quadratic equation ax2 + bx + c = 0 and solves it (prints its real roots).
 */

using System;
class QuadraticEquation
{
    static void Main()
    {
        Console.Write("Please enter the first number : ");
        double firstNumber = double.Parse(Console.ReadLine());
        Console.Write("PLease enter second number : ");
        double secondNumber = double.Parse(Console.ReadLine());
        Console.Write("PLease enter thir number : ");
        double thirdNumber = double.Parse(Console.ReadLine());
        double determinant = (secondNumber * secondNumber) - (4 * firstNumber * thirdNumber);

        if (determinant < 0)
        {
            Console.WriteLine("DETERMINANT is smaller than  0 so there is no solution");
        }
        else if (determinant > 0)
        {
            Console.WriteLine("X1 = {0}", (-secondNumber - Math.Sqrt(determinant)) / (2 * firstNumber));
            Console.WriteLine("X2 = {0}", (-secondNumber + Math.Sqrt(determinant)) / (2 * firstNumber));
        }
        else
        {
            Console.WriteLine("DETERMINANT = 0 so the answer is just one x={0}", (-secondNumber / (2 * firstNumber)));
        }
    }
}

