using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrunkenNumbers
{
    class DrunkenNumbers
    {
        static void Main(string[] args)
        {

            int roundNumbers = int.Parse(Console.ReadLine());
            int vladkoBeer = 0;
            int mitkoBeer = 0;

            for (int i = 0; i != roundNumbers; i++)
            {
                long userInput = long.Parse(Console.ReadLine());
                string tempNumber = Convert.ToString(userInput);
                tempNumber = tempNumber.Trim('0');
                int[] arrayNumbers = Array.ConvertAll(userInput.ToString().TrimStart('0').ToArray(), x => (int)x - 48);
                int numberLenght = arrayNumbers.Length / 2;
                bool isEven = arrayNumbers.Length%2==0;
                if (isEven==true)
                {
                    for (int s = 0; s != numberLenght; s++)
                    {
                        int mitkoBeerTemp = Convert.ToInt32(arrayNumbers[s]);
                        mitkoBeer += mitkoBeerTemp;
                        int vladkoBeerTemp = Convert.ToInt32(arrayNumbers[arrayNumbers.Length - s-1]);
                        vladkoBeer += vladkoBeerTemp;
                    }

                }
                else
                {
                    for (int s = 0; s != numberLenght; s++)
                    {
                        int mitkoBeerTemp = Convert.ToInt32(arrayNumbers[s]);
                        mitkoBeer += mitkoBeerTemp;
                        int vladkoBeerTemp = Convert.ToInt32(arrayNumbers[arrayNumbers.Length -s-1]);
                        vladkoBeer += vladkoBeerTemp;
                    }
                    vladkoBeer = vladkoBeer + arrayNumbers[numberLenght];
                    mitkoBeer = mitkoBeer + arrayNumbers[numberLenght];
                }
            }
         if (vladkoBeer > mitkoBeer)
         {
             Console.WriteLine("V {0}", vladkoBeer-mitkoBeer);
         }
         else if (mitkoBeer > vladkoBeer)
         {
             Console.WriteLine("M {0}", mitkoBeer-vladkoBeer);
         }
         else if (vladkoBeer == mitkoBeer)
         {
             Console.WriteLine("No {0}", mitkoBeer+vladkoBeer);
         }
        }
    }
}
