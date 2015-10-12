using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgeAfter10Years
{
    class AgeAfter10Years
    {
        static void Main(string[] args)
        {
            string myBirthDay;
            Console.WriteLine("Please enter your birthday:");
            myBirthDay = Console.ReadLine();
            DateTime birthDay;
            birthDay = Convert.ToDateTime(myBirthDay);
            DateTime currentTime = DateTime.Now;
            int myAge = currentTime.Year - birthDay.Year;
            Console.WriteLine("Your Birthday is :" + birthDay);
            Console.WriteLine("Your age is : " + myAge);
            Console.WriteLine("After ten years you will be "+ (myAge+10) +" years old" );
        }

    }
}
