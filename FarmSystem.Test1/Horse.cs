namespace FarmSystem.Test1
{
    public class Horse : Animal, ICanTalk, ICanRun
    {
        public Horse(string id, int numberOfLegs) : base(id, numberOfLegs, nameof(Horse))
        {
        }


        public string Talk()
        {
            return $"{nameof(Horse)} says neigh!";
        }

        public string Run()
        {
            return $"{nameof(Horse)} is running";
        }
        
    }
}