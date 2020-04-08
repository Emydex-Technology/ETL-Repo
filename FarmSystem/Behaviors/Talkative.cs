using FarmSystem.Interfaces;
using FarmSystem.Models;

namespace FarmSystem.Behaviors
{
    public class Talkative : Behavior, ITalkative
    {
        private readonly IAnimal _animal;

        public Talkative(IAnimal animal, string voice)
        {
            _animal = animal;
            Voice = voice;
        }

        public string Voice { get; }

        public void Talk() => OnPerformed(new BehaviorEventArgs($"{_animal.Name} says {Voice}"));
    }
}
