/*
 Problem 7. Point in a Circle

Write an expression that checks if given point (x, y) is inside a circle K({0, 0}, 2).
 */

using System;

class PointInACircle
{
    static void Main()
    {
        Console.Write("x = ");
        double pointX = double.Parse(Console.ReadLine());
        Console.Write("y = ");
        double pointY = double.Parse(Console.ReadLine());
        int circleRadius = 2;

        bool isInside = (pointX * pointX) + (pointY * pointY) <= (circleRadius * circleRadius);

        Console.WriteLine("These coordinates are inside the circle = " + isInside);
    }
}