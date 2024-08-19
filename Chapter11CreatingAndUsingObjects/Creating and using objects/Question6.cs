using System;
using System.Collections.Generic;
using System.Text;

namespace Creating_and_using_objects
{
    class Question6
    {
        public static void Solutions()
        {
            Console.WriteLine("Enter 1 for Question 6a, 2 for 6b and 3 for 6c");
            var input = int.Parse(Console.ReadLine());
            switch (input)
            {
                case 1:
                    Answer1();
                    break;
                case 2:
                    Answer2();
                    break;
                case 3:
                    Answer3();
                    break;
                default:
                    break;
            }
        }
        public static void Answer1()
        {
            Console.WriteLine("Enter the first side: ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the first side: ");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the first side: ");
            int c = int.Parse(Console.ReadLine());

            int sides = a + b + c;
            int p = sides / 2;

            Console.WriteLine(p);

            Console.ReadKey();
        }
        public static void Answer2()
        {
            Console.WriteLine("Enter the first side: ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the first side: ");
            int h = int.Parse(Console.ReadLine());

            double temp= a * Math.ScaleB(h, a);
            double result = temp / 2;

            Console.ReadKey();
        }
        public static void Answer3()
        {
            Console.WriteLine("Enter the first side: ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the first side: ");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the first side: ");
            double y = double.Parse(Console.ReadLine());

            double temp = a * b * Math.Cos(y);
            double result = temp / 2;
            Console.WriteLine(result);

            Console.ReadKey();
        }
    }
}
