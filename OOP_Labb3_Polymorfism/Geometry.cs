namespace OOP_Labb3_Polymorfism
{
    //Created abstract class due to security. I dont want anyone to create an instance of this class but of the subclasses.
    public abstract class Geometry
    {
        //Make abstract class so user must declare its own implementations within the subclasses.
        public abstract double Area();
    }
}
