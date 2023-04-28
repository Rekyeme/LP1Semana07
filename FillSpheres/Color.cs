using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FillSpheres
{
    public class Color
    {
        // Color values;
        private int R { get; set; }
        private int G { get; set; }
        private int B { get; set; }
        private int Gr { get; set; }

        // Constructor that defines the colors;
        public Color(int red, int green, int blue, int grey)
        {
            R = red;
            G = green;
            B = blue;
            Gr = grey;

        }

        // Constructor that defines a value to alpha;
        public Color(int red, int green, int blue) : this(red, green, blue, 255)
        {
        }

        // Get the color value of Grey
        public int GetGrey()
        {
            return (R + G + B) / 3;
        } 

        // Get the colors name;
        public string GetColorNames()
        {
            if (R == 255 && G == 0 && B == 0)
            {
                return "Red";
            }
            else if (R == 0 && G == 255 && B == 0)
            {
                return "Green";
            }
            else if (R == 0 && G == 0 && B == 0)
            {
                return "Blue";
            }
            else
            {
                return "Unknown";
            }

        }
    }
}