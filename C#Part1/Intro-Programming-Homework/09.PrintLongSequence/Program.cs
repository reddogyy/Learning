using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrintLongSequence
{
    class PrintLongSequence
    {
        static void Main(string[] args)
        {

            int positive = 0;
            int negative = -1;
            for (int i = 0; i <= 499; i++)
            {
                positive = positive + 2;
                negative = negative - 2;
                Console.Write(positive + "," + negative + ",");

            }



        }
    }
}
