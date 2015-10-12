using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Print
{
    static void Main()
    {

        decimal studentsNumber = decimal.Parse(Console.ReadLine());
        decimal sheetsPrint = decimal.Parse(Console.ReadLine());
        decimal realmsPrice = decimal.Parse(Console.ReadLine());
        int realmContain = 500;

        decimal totalSheets = studentsNumber * sheetsPrint;
        decimal totalRealms = totalSheets / realmContain;
        decimal totalPrice = totalRealms * realmsPrice;

        Console.WriteLine("{0:F2}", totalPrice);
    }
}

