using FarmSystem.Behaviors;
using FarmSystem.Interfaces;

namespace FarmSystem.Models
{
    public sealed class Sheep : Animal
    {
        private Sheep() { }

        public static IAnimal Purchase()
        {
            IAnimal animal = new Sheep();
            animal
                .AddNewBehavior(new Talkative(animal, "baa!"))
                .AddNewBehavior(new Scare(animal))
                .AddNewAttribute(new Legs(4));

            return animal;
        }
    }
}