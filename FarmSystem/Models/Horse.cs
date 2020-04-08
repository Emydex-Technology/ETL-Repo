using FarmSystem.Behaviors;
using FarmSystem.Interfaces;

namespace FarmSystem.Models
{
    public sealed class Horse : Animal
    {
        private Horse() { }

        public static IAnimal Purchase()
        {
            IAnimal animal = new Horse();
            animal
                .AddNewBehavior(new Talkative(animal, "Neigh!"))
                .AddNewBehavior(new Scare(animal))
                .AddNewAttribute(new Legs(4));

            return animal;
        }
    }
}