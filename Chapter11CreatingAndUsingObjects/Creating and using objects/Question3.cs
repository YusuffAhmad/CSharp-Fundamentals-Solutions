using System;
using System.Collections.Generic;
using System.Text;

namespace Creating_and_using_objects
{
    class Question3
    {
        public static void Answer()
        {
            DayOfWeek day = DateTime.Today.DayOfWeek;
            Console.WriteLine(day);
            Console.WriteLine("Press Enter to return to the Main menu");
            Console.ReadKey();
        }
    }
}
