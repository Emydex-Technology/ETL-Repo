using FarmSystem.Test2;
using System;

namespace FarmSystem.Test1
{
    public class Cow : FarmAnimal, IMilkableAnimal
    {
        public static Cow Create()
        {
            return new Cow()
            {
                Id = new Guid().ToString(),
                NoOfLegs = 4,
                IsMilkable = true
            };
        }
        public override void Talk()
        {
            Console.WriteLine("Cow says Moo!");
        }

        public override void ProduceMilk()
        {
            Console.WriteLine("Cow was milked!");
        }
    }
}