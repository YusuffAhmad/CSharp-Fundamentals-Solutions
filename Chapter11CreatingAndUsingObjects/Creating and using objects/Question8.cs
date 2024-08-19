using System;
using CreatingAndUsingObjects;
using System.Collections.Generic;
using System.Text;

namespace Question7Test
{
    public class Question8 : Cat
    {
        public static void Answer()
        {
            List<Cat> cats = new List<Cat>
            {
                 new Cat("Cat"),
                 new Cat("Cat"),
                 new Cat("Cat"),
                 new Cat("Cat"),
                 new Cat("Cat"),
                 new Cat("Cat"),
                 new Cat("Cat"),
                 new Cat("Cat"),
                 new Cat("Cat"),
                 new Cat("Cat"),
            };
            foreach (var cat in cats)
            {
                Console.WriteLine($" {cat.name + Sequence.NextValue()} {cat.SayMiau()} ");
            }
            Console.WriteLine("Press Enter to return to the Main menu");
        }
    }
        
}



