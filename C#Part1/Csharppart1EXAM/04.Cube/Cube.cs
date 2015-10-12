using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
class Cube
{
    static void Main()
    {
        int userInput = int.Parse(Console.ReadLine());
        Console.WriteLine(new string(' ', userInput - 1)
               + new string(':', userInput));
        for (int i = 0; i != userInput-2; i++)
        {
            Console.WriteLine(new string(' ', (userInput - 2)-i)
                +new string(':',1)
                +new string('/',userInput-2)
                +new string(':',1)
                +new string('X',i)
                +new string(':', 1));        
        }
        Console.WriteLine(new string(':', userInput)
       + new string('X', userInput-2)
       + new string(':',1));
        for (int p = 0; p != userInput - 2; p++)
        {
            Console.WriteLine(new string(':', 1)
                + new string(' ', userInput - 2)
                + new string(':', 1)
                + new string('X', (userInput - 3) - p)
                + new string(':', 1));
        }
        Console.WriteLine(new string(':', userInput)
       + new string(' ', userInput-1));
    }
}

