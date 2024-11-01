using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Labb3_Polymorfism
{
    internal class Rectangle : Geometry
    {
        public double rectangleLength { get; set; }
        public double rectangleWidth { get; set; }
        public Rectangle()
        {
            rectangleLength = 5;
            rectangleWidth = 2.3;
        }
        public override double Area()
        {
            Console.WriteLine("Area of the Rectangle is: ");
            return rectangleLength * rectangleWidth;
        }
    }
}
