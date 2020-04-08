using FarmSystem.Interfaces;
using FarmSystem.Models;

namespace FarmSystem.Behaviors
{
    public class Scare : Behavior, ICanRun
    {
        private readonly IAnimal _animal;

        public Scare(IAnimal animal)
        {
            _animal = animal;
        }

        public void Run() => OnPerformed(new BehaviorEventArgs($"{_animal.Name} is running"));
    }
}
