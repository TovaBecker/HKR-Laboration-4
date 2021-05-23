using System;

namespace Task1_Shape
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\tShape");
            //Create an object of my shape
            Shape myShape = new Shape(3, 4);
            //Write the result
            Console.WriteLine(myShape.Display());

            Console.WriteLine("\n\tCircle");
            //Create an object of my circle
            Circle myCircle = new Circle(8, 7, 4);
            //Write the result
            Console.WriteLine(myCircle.Display());

            Console.WriteLine("\n\tCylinder");
            //Create an object of my Cylinder
            Cylinder myCylinder = new Cylinder(2, 2, 5, 10);
            //Write the result
            Console.WriteLine(myCylinder.Display());
        }
    }
}
