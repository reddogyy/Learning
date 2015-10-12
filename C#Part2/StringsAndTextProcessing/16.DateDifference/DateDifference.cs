/*Problem 16. Date difference

Write a program that reads two dates in the format: day.month.year and calculates the number of days between them.
 */

using System;
using System.Globalization;
class DateDifference
{
    static void Main()
    {
        Console.Write("Please enter first date at the following format DD.MM.YYYY : ");
        string startDate = Console.ReadLine();
        Console.Write("Please enter second date at the following format DD.MM.YYYY : ");
        string endDate = Console.ReadLine();

        DateTime start = DateTime.ParseExact(startDate, "d.M.yyyy", CultureInfo.InvariantCulture);
        DateTime end = DateTime.ParseExact(endDate, "d.M.yyyy", CultureInfo.InvariantCulture);

        Console.WriteLine("Distance between {0} and {1} -> {2} days\n", startDate, endDate, Math.Abs((end - start).TotalDays));
    }
}

