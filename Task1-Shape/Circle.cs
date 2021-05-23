using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1_Shape
{
    class Circle:Shape
    {
        //Field to hold radius
        protected int _radius = 0;

        public Circle(int xCoord, int yCoord, int radius) : base (xCoord, yCoord)
        {
            //Set radius for cirkel
            _radius = radius;
        }

        public virtual double calculateArea()
        {
            double area = Math.PI * (_radius * _radius);

            return area;
        }
        public override string Display()
        {
            //Create sting with coordinates and area
            string text = base.Display() + $"\nArea:{calculateArea()}";

            //Return string
            return text;
        }
    }
}
