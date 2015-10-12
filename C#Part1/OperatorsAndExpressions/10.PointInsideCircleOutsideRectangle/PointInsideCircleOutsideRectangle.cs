/*Problem 10. Point Inside a Circle & Outside of a Rectangle

Write an expression that checks for given point (x, y) if it is within the circle K({1, 1}, 1.5) and out of the rectangle R(top=1, left=-1, width=6, height=2).
 * */

using System;
class PointInsideCircleOutsideRectangle
{
    static void Main()
    {
        Console.Write("x = ");
        double pointX = double.Parse(Console.ReadLine());
        Console.Write("y = ");
        double pointY = double.Parse(Console.ReadLine());
        double circleRadius = 1.5;
        double circleX = 1;
        double circleY = 1;

        bool isInsideCircle = ((pointX - circleX) * (pointX - circleX)) + ((pointY - circleY) * (pointY - circleY)) <= (circleRadius * circleRadius);
        bool isOutsideRectangle = pointX > 1 || pointX < 6 && pointY > -1 || pointY < 2;

        if (isInsideCircle && isOutsideRectangle)
        {
            Console.WriteLine("The given point is inside the circle and outside the rectangle");
        }
        else
        {
            if (isInsideCircle == true)
            {
                Console.WriteLine("The given point is inside the circle but not outside the rectangle");
            }
            if (isOutsideRectangle == true)
            {
                Console.WriteLine("The given point is outside the rectangle but not inside the circle.");
            }
        }
    }

}


