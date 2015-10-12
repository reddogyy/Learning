using System;
class NullValuesArithmetic
{
    static void Main(string[] args)
    {
        double? doubleNull = null;
        int? intNull = null;
        Console.WriteLine("The null variable value is : {0} {1}", doubleNull, intNull);
        doubleNull = 3;
        intNull = 10;
        Console.WriteLine("The variable value is : {0} {1}", doubleNull, intNull);

    }
}

