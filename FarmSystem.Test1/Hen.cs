namespace FarmSystem.Test1
{
    public class Hen : AnimalBase
    {
        public Hen() : base(2, "Hen", "CLUCKAAAAAWWWWK")
        {

        }

        public override void Walk()
        {
            //Hen cannot walk (Original Hen did not have a Walk function)
        }
    }
}