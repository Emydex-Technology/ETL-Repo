namespace FarmSystem.Test1
{
    public class Cow : Animal, ICanTalk, ICanRun, ICanWalk, ICanProduceMilk
    {
        public Cow(string id, int numberOfLegs) : base(id, numberOfLegs, nameof(Cow))
        {
        }

        public string Talk()
        {
            return $"{nameof(Cow)} says Moo!";
        }

        public string Walk()
        {
            return $"{nameof(Cow)} is walking";
        }

        public string ProduceMilk()
        {
            return $"{nameof(Cow)} produced milk";
        }

        public string Run()
        {
            return $"{nameof(Cow)} is running";
        }

    }
}