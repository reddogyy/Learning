﻿/*
 * Problem 15. Prime numbers

Write a program that finds all prime numbers in the range [1...10 000 000]. Use the Sieve of Eratosthenes algorithm.
 */

using System;
using System.Collections.Generic;
class PrimeNumbers
{
    static void Main()
    {

        long sum = 0;
        long n = 10000000;
        bool[] e = new bool[n];
        for (int i = 2; i < n; i++)
        {
            e[i] = true;
        }
        for (int j = 2; j < n; j++)
        {
            if (e[j])
            {
                for (long p = 2; (p * j) < n; p++)
                {
                    e[p * j] = false;
                }
            }
        }

        for (int i = 2; i < n; i++)
        {
            if (e[i] == true)
            {
                Console.Write(" {0},", i);
            }
        }

    }
}
