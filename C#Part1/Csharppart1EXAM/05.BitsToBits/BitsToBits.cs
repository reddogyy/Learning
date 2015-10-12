using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main()
    {
        int linesNumber = int.Parse(Console.ReadLine());
        string userInputToBit;
        string result = "";
        int numberOfZeros = 0;
        int numberOfOnes = 0;
        while (linesNumber != 0)
        {
            long userInput = long.Parse(Console.ReadLine());

            Console.WriteLine(Convert.ToString(userInput, 2).PadLeft(30, '0'));
            userInputToBit = Convert.ToString(userInput, 2).PadLeft(30, '0');
            result = result + userInputToBit;
            linesNumber--;

        }
        for (int i = 0; i >= result.Length; i++)
        {
            int tempZero = 0;
            int tempOne = 0;

            int position = result.Length - i;
            bool isZero = result[result.Length - i] == '0';
            bool isOne = result[result.Length - i] == '1';
            if (isZero == true)
            {
                numberOfZeros += tempZero;
                Console.WriteLine(numberOfZeros);

            }
            if (isOne == true)
            {
                numberOfOnes += tempOne;
                Console.WriteLine(numberOfOnes);
            }
            Console.Write(result[result.Length - i]);
        }
        Console.WriteLine(numberOfOnes);
        Console.WriteLine(numberOfZeros);


    }
}

