namespace FarmSystem.Test1
{
    public class Hen : Animal, ICanTalk, ICanRun
    {
        public Hen(string id, int numberOfLegs) : base(id, numberOfLegs, nameof(Hen))
        {
        }

        public string Talk()
        {
            return $"{nameof(Hen)} says CLUCKAAAAAWWWWK!";
        }

        public string Run()
        {
            return $"{nameof(Hen)} is running";
        }
    }
}