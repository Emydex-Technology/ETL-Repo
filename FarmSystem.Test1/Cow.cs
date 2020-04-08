using System;
using FarmSystem.Test2;

namespace FarmSystem.Test1
{
    public class Cow : AnimalBase, IMilkableAnimal
    {
        public Cow() : base(4, "Cow", "Moo")
        {
        }

        public void ProduceMilk()
        {
            Console.WriteLine($"{Name} was milked");
        }
    }
}