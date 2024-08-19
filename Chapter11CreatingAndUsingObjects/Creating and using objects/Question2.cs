using System;
using System.Collections.Generic;
using System.Text;

namespace Creating_and_using_objects
{
    class Question2
    {
       public static void Answer()
        {
            int[] randomArray = new int[10]; 
            Random random = new Random();

            for(int i = 0; i <10; i++)
            {
             randomArray[i] = random.Next(100, 200);
            }
            for (int i = 0; i < randomArray.Length; i++)
            {
                int num = i + 1;
                Console.WriteLine($"Random number {num}: {randomArray[i]}");
            }
            Console.WriteLine("Press Enter to return to the Main menu");
            Console.ReadKey();
        }
    }
}
