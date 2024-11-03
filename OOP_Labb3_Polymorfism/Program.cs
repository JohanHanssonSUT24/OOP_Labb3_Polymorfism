namespace OOP_Labb3_Polymorfism
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Create List to store objects
            List<Geometry> geometry = new List<Geometry>();

            //Create objects of each class
            Geometry geoR = new Rectangle();

            Geometry geoC = new Circle();

            Geometry geoS = new Square();

            //Add objects to List
            geometry.Add(geoR);
            geometry.Add(geoC);
            geometry.Add(geoS);

            foreach (Geometry g in geometry)
            {
                Console.WriteLine(g.Area());
            }
        }
    }
}
