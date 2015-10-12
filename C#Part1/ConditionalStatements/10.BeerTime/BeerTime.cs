/*Problem 10.* Beer Time

A beer time is after 1:00 PM and before 3:00 AM.
Write a program that enters a time in format “hh:mm tt” (an hour in range [01...12], a minute in range [00…59] and AM / PM designator) and prints beer time or non-beer time according to the definition above or invalid time if the time cannot be parsed. Note: You may need to learn how to parse dates and times.
 */

using System;
using System.Threading;
using System.Globalization;
class timeInput
{

    static void Main()
    {
        CultureInfo MyCultureInfo = new CultureInfo("en-US");
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        Console.Write("Please enter the time: (example : 05:50 PM or 22:22 ");
        string timeInput = Console.ReadLine();
        DateTime amOrPm = DateTime.Parse(timeInput);
        Console.WriteLine(amOrPm);
        string amPm = amOrPm.ToString("tt");
        bool isAm = amOrPm.Hour <= 3 && amOrPm.Minute >= 0 && amOrPm.Minute < 60;
        bool isPm = amOrPm.Hour >= 1;
        if (amPm == "AM")
        {
            if (isAm)
            {
                Console.WriteLine("Beer Time");
            }
            else
            {
                Console.WriteLine("not a beer time");
            }
        }
        else
        {
            if (isPm)
            {
                Console.WriteLine("beer time");
            }
            else
            {
                Console.WriteLine("non-beer time");
            }
        }


    }
}

