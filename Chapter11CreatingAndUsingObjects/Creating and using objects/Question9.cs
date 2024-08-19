using System;
using System.Collections.Generic;
using System.Text;

namespace Creating_and_using_objects
{
    public class Question9
    {
        public static void Answer()
        {
            Console.WriteLine("Enter the end date");
            DateTime date = DateTime.Parse(Console.ReadLine());
            for (DateTime currentDate = DateTime.Now.Date; currentDate < date; currentDate.AddDays(1))
            {
                if(currentDate.DayOfWeek != DayOfWeek.Saturday && currentDate.DayOfWeek != DayOfWeek.Sunday)
                {
                    Console.WriteLine(currentDate.DayOfWeek);
                }
            }
            Console.WriteLine("Press Enter to return to the Main menu");
            Console.ReadKey();
        }
    }
}
