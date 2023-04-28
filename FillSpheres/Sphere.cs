using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FillSpheres
{
    public class Sphere
    {
        private Color Color { get; set; }
        private double Radius { get; set; }
        private int Thrown;

        public Sphere(Color Color, double Radius, int Thrown)
        {
            this.Color = Color;
            this.Radius = Radius;
            this.Thrown = 0;
        }

        public void Pop()
        {
            Radius = 0;
        }

        public void Throw()
        {
            if (Radius > 0)
            {
                this.Thrown++;
            }
        }

        public int GetTimesThrown()
        {
            return this.Thrown;
        }
    }

}