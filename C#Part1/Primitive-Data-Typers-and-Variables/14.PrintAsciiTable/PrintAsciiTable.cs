using System;
class PrintAsciiTable
{
    static void Main(string[] args)
    {

        for (int i = 0; i <= 255; i++)
        {
            Console.WriteLine("{0} = {1}", i, (char)i);
        }
    }
}

