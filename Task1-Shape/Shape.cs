using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1_Shape
{
    class Shape
    {
        //Two fields for the coordinates
        protected int _xCoord = 0;
        protected int _yCoord = 0;

        public Shape(int xCoord, int yCoord)
        {
            //Set coordinates for shape
            _xCoord = xCoord;
            _yCoord = yCoord;
        }
        public virtual string Display()
        {
            //Create sting with coordinates
            string text = $"Coordinates:\nx:{_xCoord}\ny:{_yCoord}";

            //Return string
            return text;
        }
    }
}
