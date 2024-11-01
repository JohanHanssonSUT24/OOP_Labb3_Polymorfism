using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Labb3_Polymorfism
{
    internal class Square : Geometry
    {
        public double SquareArea { get; set; }
        public Square()
        {
            SquareArea = 4.3;
        }
        public override double Area()
        {
            Console.WriteLine("Area of the Square is: ");
            return SquareArea * SquareArea;
        }
    }
}
