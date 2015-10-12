/*Problem 9. Trapezoids

Write an expression that calculates trapezoid's area by given sides a and b and height h.*/

using System;
class Trapezoids
{
    static void Main()
    {
        double firstSide;
        double secondSide;
        double height;
        Console.WriteLine("Please enter the first Trapezoid side : ");
        firstSide = double.Parse(Console.ReadLine());
        Console.WriteLine("Please enter the second trapezoid side : ");
        secondSide = double.Parse(Console.ReadLine());
        Console.WriteLine("Please enter the height of the trapezoid :");
        height = double.Parse(Console.ReadLine());
        double trapezoidsArea;
        trapezoidsArea = ((firstSide + secondSide) / 2) * height;
        Console.WriteLine("The area of trapezoid with the given side {0} , {1} and height {2} is {3}", firstSide, secondSide, height, trapezoidsArea);
    }
}
