using System;
using System.Collections.Generic;

namespace FarmSystem.Test1
{
    public class EmydexFarmSystem
    {
        private readonly Queue<IAnimal> _animals;

        public EmydexFarmSystem()
        {
            _animals = new Queue<IAnimal>();
        }

        //TEST 1
        public void Enter(IAnimal animal)
        {
            _animals.Enqueue(animal);
            Console.WriteLine($"{animal.Name} has entered the Emydex farm");
        }
     
        //TEST 2
        public void MakeNoise()
        {
            foreach (var animal in _animals.ToArray())
            {
                var message = animal.GetType().GetMethod("Talk").Invoke(animal, null);
                Console.WriteLine(message);
            }
        }

        //TEST 3
        public void MilkAnimals()
        {
            foreach (var animal in _animals.ToArray())
            {
                if (animal is ICanProduceMilk)
                    Console.WriteLine($"{animal.Name} was milked!");
            }
        }

        //TEST 4
        public void ReleaseAllAnimals()
        {
            while (_animals.Count > 0)
            {
                var animal = _animals.Dequeue();

                var message = animal.GetType().GetMethod("Talk").Invoke(animal, null);
                Console.WriteLine($"{animal.Name} has left the farm");
            }

            Console.WriteLine($"Emydex Farm is now empty");
        }

        
    }
}