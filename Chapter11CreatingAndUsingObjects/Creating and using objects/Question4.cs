using System;
using System.Collections.Generic;
using System.Text;

namespace Creating_and_using_objects
{
    class Question4
    {
        public static void Answer()
        {
            var milliSecondselapsed = Environment.TickCount;
            var secondsElapsed= milliSecondselapsed / 1000;
            var minuteElaped = secondsElapsed / 60;
            var hoursElaped = minuteElaped / 60;
            var daysElapsed = hoursElaped / 24;
            Console.WriteLine($"The program spent {daysElapsed} days, {hoursElaped} hours and {minuteElaped} minutes untill the moment of execution");
            Console.WriteLine("Press Enter to return to the Main menu");
            Console.ReadKey();
        }
    }
}
