using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class SaddyKopper
{
    static void Main()
    {
        long userInput = long.Parse(Console.ReadLine());
        long sumEven = 0;
        long originalNumber = userInput;
        long tempNumber = 0;
        long productEven = 1;
        long tempProductEven = 1;
        int rounds = 0;
        string productStr = Convert.ToString(productEven);
        bool isMoreDigits = productStr.Length > 0;

        do
        {
            while (userInput != 0)
            {

                originalNumber = userInput;
                while (originalNumber != 0)
                {
                    tempNumber = originalNumber % 10;
                    if (tempNumber % 2 == 1)
                    {
                        sumEven = sumEven + tempNumber;
                    }

                    originalNumber = originalNumber / 10;
                }
                tempProductEven *= sumEven;
                sumEven = 0;
                productEven = tempProductEven;
                userInput = userInput / 10;
            }
            userInput = productEven/10;
            tempProductEven = 1;
            rounds++;
        } while (productEven>10);
        
//
//          userInput = productEven/10;
//          tempProductEven = 1;
//          rounds++;
        

        Console.WriteLine(rounds);
        Console.WriteLine(productEven);

    }




}

