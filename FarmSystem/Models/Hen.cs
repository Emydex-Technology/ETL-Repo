using FarmSystem.Behaviors;
using FarmSystem.Interfaces;

namespace FarmSystem.Models
{
    public sealed class Hen : Animal
    {
        private Hen() { }

        public static IAnimal Purchase()
        {
            IAnimal animal = new Hen();
            animal
                .AddNewBehavior(new Talkative(animal, "CLUCKAAAAAWWWWK!"))
                .AddNewBehavior(new Scare(animal))
                .AddNewAttribute(new Legs(2));

            return animal;
        }
    }
}