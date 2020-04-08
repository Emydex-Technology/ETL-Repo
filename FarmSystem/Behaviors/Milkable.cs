using FarmSystem.Interfaces;
using FarmSystem.Models;

namespace FarmSystem.Behaviors
{
    public class Milkable : Behavior, IMilkableAnimal
    {
        private readonly IAnimal _animal;

        public Milkable(IAnimal animal)
        {
            _animal = animal;
        }

        public void ProduceMilk() => OnPerformed(new BehaviorEventArgs($"{_animal.Name} was milked!"));
    }
}
