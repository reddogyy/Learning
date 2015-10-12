/*Problem 5. Workdays

Write a method that calculates the number of workdays between today and given date, passed as parameter.
Consider that workdays are all days from Monday to Friday except a fixed list of public holidays specified preliminary as array.
*/

using System;
using System.Linq;
 class Workdays
    {
        static readonly DateTime[] holidays =
    {
        new DateTime(2015, 3, 2),new DateTime(2015, 3, 3), new DateTime(2015, 3, 4), new DateTime(2015, 3, 21),
        new DateTime(2015, 4, 10), new DateTime(2015, 4, 11), new DateTime(2015, 4, 12),
        new DateTime(2015, 4, 13), new DateTime(2015, 5, 1), new DateTime(2015, 5, 2),
        new DateTime(2015, 5, 3), new DateTime(2015, 5, 6), new DateTime(2015, 5, 24),
        new DateTime(2015, 9, 6), new DateTime(2015, 9, 19), new DateTime(2015, 9, 20),
        new DateTime(2015, 9, 21), new DateTime(2015, 9, 22), new DateTime(2015, 11, 1),
        new DateTime(2015, 12, 24), new DateTime(2015, 12, 25), new DateTime(2015, 12, 26),
        new DateTime(2015, 12, 27), new DateTime(2015, 12, 31)
    };
        static void Main()
        {
            DateTime dateNow = new DateTime(2015, 2, 20);
            DateTime dateFuture = new DateTime(2015, 9, 30);

            Console.WriteLine("Checking work days from {0:dd/MM/yyyy} to {1:dd/MM/yyyy}...\n",
                dateNow, dateFuture);

            Console.WriteLine("Total work days: {0}\n", GetNumberOfWorkDays(dateNow, dateFuture));
            Console.WriteLine("Total work days: {0}\n", GetBusinessDays(dateNow, dateFuture));
        }

        static int GetNumberOfWorkDays(DateTime dateNow, DateTime dateFuture)
        {
            int numberOfWorkDays = 0;

            if (dateNow > dateFuture)
            {
                DateTime swap = dateNow;
                dateNow = dateFuture;
                dateFuture = swap;
            }

            while (dateNow <= dateFuture)
            {
                if (!holidays.Contains(dateNow) && dateNow.DayOfWeek != DayOfWeek.Saturday &&
                    dateNow.DayOfWeek != DayOfWeek.Sunday)
                {
                    numberOfWorkDays++;
                }

                dateNow = dateNow.AddDays(1);
            }

            return numberOfWorkDays;
        }
    }
