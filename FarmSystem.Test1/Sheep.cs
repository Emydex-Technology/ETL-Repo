using FarmSystem.Test2;
using System;

namespace FarmSystem.Test1
{
    public class Sheep : FarmAnimal, IMilkableAnimal
    {
        public static Sheep Create()
        {
            return new Sheep()
            {
                Id = new Guid().ToString(),
                NoOfLegs = 4,
                IsMilkable = true
            };
        }
        public override void Talk()
        {
            Console.WriteLine("Sheep says baa!");
        }

        public override void ProduceMilk()
        {
            Console.WriteLine("Sheep was milked!");
        }
    }

}