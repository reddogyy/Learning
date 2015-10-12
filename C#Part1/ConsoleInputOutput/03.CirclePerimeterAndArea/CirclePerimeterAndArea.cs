/*Problem 3. Circle Perimeter and Area

Write a program that reads the radius r of a circle and prints its perimeter and area formatted with 2 digits after the decimal point.
 */

using System;
class CirclePerimeterAndArea
{
    static void Main()
    {
        double radius;
        Console.Write("Please enter the circle radius :");
        radius = double.Parse(Console.ReadLine());
        double pi = 3.1415926535897932384626433832795;
        double area = pi * (radius * radius);
        double perimeter = (2 * pi) * radius;
        Console.WriteLine("The area is {0:F2} \n The Perimeter is {1:F2}", perimeter, area);

    }
}

