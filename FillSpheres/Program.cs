using System;

namespace FillSpheres
{
    class Program
    {
        static void Main(string[] args)
        {
            // Generates some Spheres;
            Sphere sphere1 = new Sphere(new Color(255, 0, 0), 10);
            Sphere sphere2 = new Sphere(new Color(0, 255, 0), 20);
            Sphere sphere3 = new Sphere(new Color(0, 0, 255), 30);

            // Throws the spheres around 3 times each;
            sphere1.Throw();
            sphere1.Throw();
            sphere1.Throw();
            sphere2.Throw();
            sphere2.Throw();
            sphere2.Throw();
            sphere3.Throw();
            sphere3.Throw();
            sphere3.Throw();

            // Pops the 2nd sphere;
            sphere2.Pop();

            //Results from spheres 1
            Console.WriteLine($"Sphere 1:");
            Console.WriteLine($"Color = {sphere1.Color.GetColorNames()}");
            Console.WriteLine($"Radius = {sphere1.Radius},");
            Console.WriteLine($"Times thrown = {sphere1.GetTimesThrown()}");
            //Result for sphere 2
            Console.WriteLine($"\nSphere 2:");
            Console.WriteLine($"Color = {sphere2.Color.GetColorNames()}");
            Console.WriteLine($"Radius = {sphere2.Radius},");
            Console.WriteLine($"Times thrown = {sphere2.GetTimesThrown()}");
            //Result for sphere 3
            Console.WriteLine($"\nSphere 3:");
            Console.WriteLine($"Color = {sphere3.Color.GetColorNames()}");
            Console.WriteLine($"Radius = {sphere3.Radius},");
            Console.WriteLine($"Times thrown = {sphere3.GetTimesThrown()}");
        }
    }
}
