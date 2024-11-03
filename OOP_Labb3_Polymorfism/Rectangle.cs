namespace OOP_Labb3_Polymorfism
{
    internal class Rectangle : Geometry
    {
        public double rectangleLength { get; set; }
        public double rectangleWidth { get; set; }
        //Constructor with set properties.
        public Rectangle()
        {
            rectangleLength = 5;
            rectangleWidth = 2.3;
        }
        //Override method with correct calculation
        public override double Area()
        {

            Console.WriteLine("Area of the Rectangle is: ");
            return rectangleLength * rectangleWidth;
        }
    }
}
