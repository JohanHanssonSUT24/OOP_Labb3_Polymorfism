namespace OOP_Labb3_Polymorfism
{
    internal class Square : Geometry
    {
        public double SquareSide { get; set; }
        //Constructor with set properties.
        public Square()
        {
            SquareSide = 4.3;
        }
        //Override method with correct calculation
        public override double Area()
        {
            Console.WriteLine("Area of the Square is: ");
            return SquareSide * SquareSide;
        }
    }
}
