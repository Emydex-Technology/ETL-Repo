using System;

namespace FarmSystem.Test1
{
    public class Hen : FarmAnimal
    {
        public static Hen Create()
        {
            return new Hen()
            {
                Id = new Guid().ToString(),
                NoOfLegs = 2,
                IsMilkable = false
            };
        }

        public override void Talk()
        {
            Console.WriteLine("Hen say CLUCKAAAAAWWWWK!");
        }
    }
}