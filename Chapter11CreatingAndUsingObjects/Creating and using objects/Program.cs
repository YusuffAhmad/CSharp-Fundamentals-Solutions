using System;
using Question7Test;
using CreatingAndUsingObjects;

namespace Creating_and_using_objects
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("--------- CHAPTER 14 CREATING AND USING OBJECT---------");
                Console.WriteLine("Enter the digit that corresponds each of the Questions from 1 to 11");
                var number = int.Parse(Console.ReadLine());
                switch (number)
                {
                    case 1:
                        Question1.Answer();
                        break;
                    case 2:
                        Question2.Answer();
                        break;
                    case 3:
                        Question3.Answer();
                        break;
                    case 4:
                        Question4.Answer();
                        break;
                    case 5:
                        Question5.Answer();
                        break;
                    case 6:
                        Question6.Solutions();
                        break;
                    case 7:
                        Question7.Testing();
                        break;
                    case 8:
                        Question8.Answer();
                        break;
                    case 9:
                        Question9.Answer();
                        break;
                    case 10:
                        Question10.Answer();
                        break;
                    case 11:
                        Question11.Answer();
                        break;
                    default:
                        break;
                }
                Console.ReadKey();
            }
           
        }
    }
}
