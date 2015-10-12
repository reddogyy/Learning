using System;
class ComparingFloats
{
    static void Main(string[] args)
    {
        float eps = 0.000001F;
        float a = -0.00000007F;
        float b = 0.00000007F;
        bool isEqual = (b - a) < eps;
        Console.WriteLine(a + " " + b);
        Console.WriteLine(a - b);
        Console.WriteLine(isEqual);
    }
}
