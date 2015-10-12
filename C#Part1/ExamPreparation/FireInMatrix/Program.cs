using System;
class Program
{
    static void Main(string[] args)
    {
      //  int n = 8;
        int n = int.Parse(Console.ReadLine());
        int count = n / 2;
        for (int i = 1; i <= count; i++)
        {
            String row = new string('.', count - i)
            + ("#")
            + (new string('.', (i - 1) * 2))
            + ("#")
            + new string('.', count - i);
            Console.WriteLine(row);
        }
        int secondPart = n / 4;
        int firstDots = 0;
        for (int i = 1; i <= secondPart; i++)
        {
            String row = new string('.', firstDots)
                + ("#")
                + (new string('.', (count - i) * 2))
                + ("#")
                + new string('.', firstDots);
            Console.WriteLine(row);
            firstDots++;
        }
        for (int i = 0; i < n; i++)
        {
            Console.Write('-');

        }
        Console.WriteLine();
        for (int i = 0; i < count; i++)
        {

            String row = new string('.', i)
                + new string('\\', count - i)
                + new string('/', count - i)
                + new String('.', i);
            Console.WriteLine(row);
        }
    }
}

