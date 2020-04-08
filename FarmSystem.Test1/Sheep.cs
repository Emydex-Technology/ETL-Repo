namespace FarmSystem.Test1
{
    public class Sheep : Animal, ICanTalk, ICanRun
    {
        public Sheep(string id, int numberOfLegs) : base(id, numberOfLegs, nameof(Sheep))
        {
        }

        public string Talk()
        {
            return $"{nameof(Sheep)} says baa!";
        }
        
        public string Run()
        {
            return $"{nameof(Sheep)} is running";
        }
    }

}