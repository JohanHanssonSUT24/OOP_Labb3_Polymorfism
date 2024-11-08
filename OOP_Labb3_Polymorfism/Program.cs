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
            //Foreach-loop to see all of the objects added to the list and by using the Area-method
            foreach (Geometry g in geometry)
            {
                Console.WriteLine(g.Area());
            }
            //I have created several objects from the same parentclass (Geometry-class) but out of the different child-classes.
            //By using an override-method in each child-class the object can be identified by more than one type of object. This is polymorfism in practice.
        }
    }
}
