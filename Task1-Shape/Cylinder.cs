using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1_Shape
{
    class Cylinder : Circle
    {
        //Field to hold radius
        protected int _height = 0;

        public Cylinder(int xCoord, int yCoord, int radius, int height) : base(xCoord, yCoord, radius)
        {
            //Set hight for cylinder
            _height = height;
        }

        public override double calculateArea()
        {
            //Calculate cylinders area
            double area = (2 * base.calculateArea()) + (2* Math.PI * _radius * _height);

            return area;
        }
        public double calculateVolume()
        {
            //Calculate volume with help of circel calculate area method
            double volume = base.calculateArea() * _height;

            return volume;
        }
        //Write over Display method in Circle
        public override string Display()
        {
            //Create sting with coordinates, area and volume
            string text = $"coordinates:\nx:{_xCoord}\ny:{_yCoord}\nArea:{calculateArea()}\nVolume:{calculateVolume()}";

            //Return string
            return text;
        }
    }
}
