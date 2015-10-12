using System;
class Program
{
    static void Main(string[] args)
    {
        int secretNumber = int.Parse(Console.ReadLine());
        int bulls = int.Parse(Console.ReadLine());
        int cows = int.Parse(Console.ReadLine());
        bool foundNumber = false;
        for (int i = 1000; i <= 9999; i++)
        {
            int currentBulls = 0;
            int currentCows = 0;
            int currentNumber = i;
            int currentD = currentNumber % 10;
            currentNumber /= 10;
            int currentC = i % 10;
            currentNumber /= 10;
            int currentB = currentNumber % 10;
            currentNumber /= 10;
            int currentA = currentNumber % 10;
            currentNumber /= 10;

            int tempSecretNumber = secretNumber;
            int secretD = tempSecretNumber % 10;
            tempSecretNumber /= 10;
            int secretC = tempSecretNumber % 10;
            tempSecretNumber /= 10;
            int secretB = tempSecretNumber % 10;
            tempSecretNumber /= 10;
            int secretA = tempSecretNumber % 10;
            tempSecretNumber /= 10;
            if (currentA == 0 || currentB == 0 || currentC == 0 || currentD == 0)
            {
                continue;
            }

            #region Find bulls
            if (currentA == secretA)
            {
                currentBulls++;
                currentA = -1;
                secretA = -2;
            }
            if (currentB == secretB)
            {
                currentBulls++;
                currentB = -1;
                secretB = -2;
            }
            if (currentC == secretC)
            {
                currentBulls++;
                currentC = -1;
                secretC = -2;

            }
            if (currentD == secretD)
            {
                currentBulls++;
                currentD = -1;
                secretD = -2;
            }
            #endregion
            #region CurrentA
            if (currentA == secretB)
            {
                currentCows++;
                currentA = -1;
                secretB = -2;
            }
            if (currentA == secretC)
            {
                currentCows++;
                currentA = -1;
                secretC = -2;
            }
            if (currentA == secretD)
            {
                currentCows++;
                currentA = -1;
                secretD = -2;
            }
            #endregion
            #region CurrentB
            if (currentB == secretD)
            {
                currentCows++;
                currentB = -1;
                secretD = -2;
            }
            if (currentB == secretA)
            {
                currentCows++;
                currentB = -1;
                secretA = -2;
            }
            if (currentB == secretC)
            {
                currentCows++;
                currentB = -1;
                secretC = -2;
            }
            #endregion
            #region CurrentC
            if (currentC == secretA)
            {
                currentCows++;
                currentC = -1;
                secretA = -2;
            }
            if (currentC == secretB)
            {
                currentCows++;
                currentC = -1;
                secretB = -2;
            }
            if (currentC == secretD)
            {
                currentCows++;
                currentC = -1;
                secretD = -2;
            }
            #endregion
            #region CurrentD
            if (currentD == secretA)
            {
                currentCows++;
                currentD = -1;
                secretA = -2;
            }
            if (currentD == secretB)
            {
                currentCows++;
                currentD = -1;
                secretB = -2;
            }
            if (currentD == secretC)
            {
                currentCows++;
                currentD = -1;
                secretC = -2;
            }
            #endregion
            if (currentBulls == bulls && currentCows == cows)
            {
                foundNumber = true;
                Console.Write("{0} ", i);
            }
            if (!foundNumber)
            {
                Console.WriteLine("No");
            }
            else
            {
                Console.WriteLine();
            }
        }
    }
}

