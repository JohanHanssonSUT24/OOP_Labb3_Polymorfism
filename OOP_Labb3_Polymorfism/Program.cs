namespace OOP_Labb3_Polymorfism
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Geometry> geometry = new List<Geometry>();

            Geometry geoR = new Rectangle();

            Geometry geoC = new Circle();

            Geometry geoS = new Square();

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
