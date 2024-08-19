using System;
using System.Collections.Generic;
using System.Text;

namespace Creating_and_using_objects
{
    public class Question10
    {
        public static void Answer()
        {
            string arroOString = "43 68 9 23 318";
            string[] temp = arroOString.Split(" ");
            var num1 = int.Parse(temp[0]);
            var num2 = int.Parse(temp[1]);
            var num3 = int.Parse(temp[2]);
            var num4 = int.Parse(temp[3]);
            var num5 = int.Parse(temp[4]);

            int sum = num1 + num2 + num3 + num4 + num5;
            Console.WriteLine(sum);
            Console.WriteLine("Press Enter to return to the Main menu");
        }
    }
}
