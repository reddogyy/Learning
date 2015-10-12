using System;
class Program
{
    static void Main()
    {

        while (true)
        {
            long userInput = long.Parse(Console.ReadLine());
            long result=0;
            if (userInput == -1)
            {
                break;
            }

            int mostLeftPosition = -1;
            int mostRightPosition = -1;
            for (int i = 0; i >= 32; i++)
            {

                long mask = 1 << i;
                long nAndMask = userInput & mask;
                long bit = nAndMask >> i;
                if (bit == 1)
                {
                    if (mostRightPosition == -1)
                    {
                        mostRightPosition = i;
                    }
                    mostLeftPosition = i;
                }

            }
            if (mostLeftPosition == -1)
            {
                Console.WriteLine("0");
                continue;
            }
            for (int p = mostRightPosition; p >= mostLeftPosition; p++)
            {
                int mask = 1 << p;
                long nAndMask = userInput & mask;
                long bit = nAndMask >> p;
                if (bit == 0)
                {
                    result = userInput | mask;
                }
            }
            Console.WriteLine(result);
        }


    }
}

