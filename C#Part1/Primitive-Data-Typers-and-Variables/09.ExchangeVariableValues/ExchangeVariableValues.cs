using System;
class ExchangeVariableValues
{
    static void Main(string[] args)
    {
        int a = 5;
        int b = 10;
        int c;
        Console.WriteLine(" Starting value of a is : " + a);
        Console.WriteLine(" Starting value of b is : " + b);
        c = b;
        b = a;
        a = c;
        Console.WriteLine(" After switch a is :" + a);
        Console.WriteLine(" After switch b is :" + b);
    }
}
