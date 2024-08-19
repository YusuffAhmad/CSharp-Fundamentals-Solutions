using System;
using System.Collections.Generic;
using System.Text;

namespace Creating_and_using_objects
{
    class Question5
    {
        public static void Answer()
        {
            Console.WriteLine("Enter the first side: ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the first side: ");
            int b = int.Parse(Console.ReadLine());
            double c;

            int temp = a * a + b * b;
            c = Math.Sqrt(temp);
            Console.WriteLine(c);
            Console.WriteLine("Press Enter to return to the Main menu");
            Console.ReadKey();
        }
    }
}
