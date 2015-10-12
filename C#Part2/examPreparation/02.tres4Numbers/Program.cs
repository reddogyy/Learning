using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

class Program
{

    static string DecimalToBase(ulong decimalNumber, ulong numeralSystem)
    {
        StringBuilder sb = new StringBuilder();
        while (decimalNumber > 0)
        {
            var digit = decimalNumber % numeralSystem;
  //       if (digit > 0 && digit <= 9)
  //       {
  //
  //           result = (char)(digit + '0') + result;
  //       }
  //       else
  //       {
  //           result = (char)(digit - 10 + 'A') + result;
  //       }
            sb.Insert(0, digit);
            decimalNumber /= numeralSystem;
        }
        string result = sb.ToString();
        return result;
    }
    static void Main()
    {
        ulong userInput = ulong.Parse(Console.ReadLine());
        string temp = DecimalToBase(userInput, 9).Replace("0", "LON+")
            .Replace("1", "VK-")
            .Replace("2", "*ACAD")
            .Replace("3", "^MIM")
            .Replace("4", "ERIK|")
            .Replace("5", "SEY&")
            .Replace("6", "EMY>>")
            .Replace("7", "/TEL")
            .Replace("8", "<<DON");

        Console.WriteLine(temp);
    }
}
