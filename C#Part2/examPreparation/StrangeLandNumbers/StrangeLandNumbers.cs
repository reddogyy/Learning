using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrangeLandNumbers
{
    class StrangeLandNumbers
    {
        static void Main()
        {
            string userInput = Console.ReadLine();

            string[] strangeNumber = new string[] { "f", "bIN", "oBJEC", "mNTRAVL", "lPVKNQ", "pNWE", "hT" };
            List<double> decimalNumber = new List<double>();
            int counter = 1;
            for (int i = 0; i < userInput.Length; i++)
            {

                string tempString = userInput.Substring(userInput.Length - strangeNumber[i].Length, strangeNumber[i].Length);
                if (tempString.Contains(strangeNumber[i]))
                {
                    if (counter == 1)
                    {
                        decimalNumber.Add(i + 1);
                    }
                    else
                    {
                        double sevenPower = Math.Pow(7,counter);
                        decimalNumber.Add(sevenPower * (i + 1));
                    }
                }
                counter++;
            }
            /*
            switch (userInput)
	{
                case(userInput.Contains(one)):
                    {
                        decimalNumber.Add(1);
                    }
		default:
 break;
	}
             */
        }
    }
}
