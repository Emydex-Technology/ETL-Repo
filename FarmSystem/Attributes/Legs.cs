using System.Threading;
using FarmSystem.Interfaces;

namespace FarmSystem.Behaviors
{
    public class Legs : IAttribute
    {
        public Legs(int noOfLegs)
        {
            NoOfLegs = noOfLegs;
        }

        public int NoOfLegs { get; }
    }
}
