namespace OOP_Labb3_Polymorfism
{
    internal class Circle : Geometry
    {
        public double CircleRadius { get; set; }
        public double Pi { get; set; }
        //Constructor with set properties.
        public Circle()
        {
            CircleRadius = 4.4;
            Pi = 3.14;
        }
        //Override method with correct calculation
        public override double Area()
        {
            Console.WriteLine("Area of the Circle is: ");
            return CircleRadius * CircleRadius * Pi;
        }
    }
}
