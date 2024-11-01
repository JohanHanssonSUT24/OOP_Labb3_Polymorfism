using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Labb3_Polymorfism
{
    internal class Circle : Geometry
    {
        public double CircleArea { get; set; }
        public double Pi { get; set; }

        public Circle()
        {
            CircleArea = 4.4;
            Pi = 3.14;
        }
        public override double Area()
        {
            Console.WriteLine("Area of the Circle is: ");
            return CircleArea * CircleArea * Pi;
        }
    }
}
