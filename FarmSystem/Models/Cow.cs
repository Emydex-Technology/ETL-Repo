using FarmSystem.Behaviors;
using FarmSystem.Interfaces;

namespace FarmSystem.Models
{
    public sealed class Cow : Animal
    {
        private Cow() { }

        public static IAnimal Purchase()
        {
            IAnimal animal = new Cow();
            animal
                .AddNewBehavior(new Talkative(animal,"Moo!"))
                .AddNewBehavior(new Scare(animal))
                .AddNewBehavior(new Milkable(animal))
                .AddNewAttribute(new Legs(4));

            return animal;
        }
    }
}