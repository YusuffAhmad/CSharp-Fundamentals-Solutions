using System;

namespace Classes
{
    public class ScreenFeatures
    {
        public string Size { get; set; }
        public string Colour { get; set; }

        public ScreenFeatures( string size, string colour)
        {
            Size = size;
            Colour = colour;
        }
    }
}