using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FillSpheres
{
    public class Sphere
    {
        // Object properties;
        private Color Color { get; set; }
        private double Radius { get; set; }
        private int Thrown;

        // Constructor that defines the class properties;
        public Sphere(Color Color, double Radius, int Thrown)
        {
            this.Color = Color;
            this.Radius = Radius;
            this.Thrown = 0;
        }

        // Pops the sphere and set it's radius to 0;
        public void Pop()
        {
            Radius = 0;
        }

        // If the sphere is not popped, increase the amount of times the sphere was thrown;
        public void Throw()
        {
            if (Radius > 0)
            {
                this.Thrown++;
            }
        }

        // Returns the number of times the sphere was thrown;
        public int GetTimesThrown()
        {
            return this.Thrown;
        }
    }

}