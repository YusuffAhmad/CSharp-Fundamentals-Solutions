using CreatingAndUsingObjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace CreatingAndUsingObjects
{
    public class Cat
    {
        public string name { get; set; }
        public string color { get; set; }

        public Cat()
        {
            this.name = "Unnamed";
            this.color = "gray";
        }
        public Cat(string name)
        {
            this.name = name;
            this.color = color;
        }
        public string SayMiau()
        {
            return $"said: Miauuuuuu!";
        }
    }
    public class Sequence
    {
        public static int currentValue = 0;
        public Sequence()
        {
        }
        public static int NextValue()
        {
            currentValue++;
            return currentValue;
        }
    }
}

namespace Question7Test
{
    public class Question7
    {
        public static void Testing()
        {
            Sequence sequence = new Sequence();
            Cat firstCat = new Cat();
            firstCat.SayMiau();
            Console.WriteLine("Press Enter to return to the Main menu");
        }
    }
}