using System;
using System.Collections.Generic;
using System.Text;

namespace Creating_and_using_objects
{
    class Question1
    {
        public static void Answer()
        {
            Console.WriteLine("Enter a year to check weather it is a leap year: ");
            int year = int.Parse(Console.ReadLine());

            var result = CheckALeapYear(year);
            Console.WriteLine(result == true ? $"{year} is a leap year" : $"{ year} is a not leap year");

            Console.WriteLine("Press Enter to return to the Main menu");
            Console.ReadKey();
        }
        public static bool CheckALeapYear(int year)
        {
            bool isLeapYear = false;
            if (year % 4 == 0)
            {
                return !isLeapYear;
            }
            else
            {
                return isLeapYear;
            }
        }
    }
}
