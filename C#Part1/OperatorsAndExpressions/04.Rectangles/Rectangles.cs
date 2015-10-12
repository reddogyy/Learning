/*Problem 4. Rectangles

Write an expression that calculates rectangle’s perimeter and area by given width and height.*/

using System;

class Rectangles
{
    static void Main()
    {
        Console.WriteLine( "Program that calculate rectangles perimeter and area.");
        double firstSide;
        double secondSide;
        Console.WriteLine("Please enter the width : ");
        firstSide = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Please enter the height : ");
        secondSide = Convert.ToDouble(Console.ReadLine());
        double area = firstSide * secondSide;
        Console.WriteLine("Rectangle area is : {0}",area);
        double perimeter = (firstSide + secondSide) * 2;
        Console.WriteLine("Rectangle parimeter is : {0}" ,perimeter);

    }
}
