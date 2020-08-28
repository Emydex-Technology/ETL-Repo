using System;

namespace FarmSystem.Test1
{
    public class Horse : FarmAnimal
    {
        public static Horse Create()
        {
            return new Horse()
            {
                Id = new Guid().ToString(),
                NoOfLegs = 4,
                IsMilkable = false
            };
        }

        public override void Talk()
        {
            Console.WriteLine("Horse says Neigh!");
        }
    }
}