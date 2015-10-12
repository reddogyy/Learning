using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BunnyFactory
{
    class BunnyFactory
    {
        static void Main(string[] args)
        {
            var cages = Input();
            for (int stepNumber = 1; ; stepNumber++)
            {
                if (cages.Count < stepNumber)
                {
                    break;
                }
                var cageCount =
            }

        }
        static BigInteger SumListValuesRange(List<int> list, int startIndex,int endIndex)
        {
            BigInteger sum = 0;
            for (int i = startIndex; i <= endIndex; i++)
            {
                sum +=
            }
        }
        static List<int> Input()
        {
            var cages = new List<int>;
            while(true)
            {
                var userInput;
                if(userInput == "END"){
                    false;
                }
                var cage = int.Parse(Console.ReadLine());
                cages.Add(cage);
            }

        }
    }
}
