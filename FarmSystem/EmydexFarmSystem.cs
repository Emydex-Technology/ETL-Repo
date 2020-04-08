using System;
using System.Collections.Generic;
using System.Linq;
using FarmSystem.Interfaces;
using FarmSystem.Models;

namespace FarmSystem
{
    public class EmydexFarmSystem
    {
        private readonly Queue<IAnimal> _animals;
        public event EventHandler<BehaviorEventArgs> FarmActivity;

        protected virtual void OnFarmActivity(BehaviorEventArgs e)
        {
            FarmActivity?.Invoke(this, e);
        }

        private EmydexFarmSystem()
        {
            _animals = new Queue<IAnimal>();
        }

        public static EmydexFarmSystem CreateFarm()
        {
            return new EmydexFarmSystem();
        }

        public void Enter(params IAnimal[] animals)
        {
            animals.ForEach(Enter);
        }

        //TEST 1
        public void Enter(IAnimal animal)
        {
            animal.SomethingHappened += (o, e) => OnFarmActivity(e);
            _animals.Enqueue(animal);
            OnFarmActivity(new BehaviorEventArgs($"{animal.Name} has entered the farm"));
        }

        //TEST 2
        public void MakeNoise()
        {
            var talked = 0;
            foreach (var animal in _animals)
            {
                foreach (var behavior in animal.Behaviors)
                {
                    if (behavior is ITalkative talkative)
                    {
                        talked++;
                        talkative.Talk();
                    }
                }
            }
            if (talked == 0)
                OnFarmActivity(new BehaviorEventArgs("There are no animals on the farm that can talk"));
        }

        //TEST 3
        public void MilkAnimals()
        {
            var milked = 0;
            foreach (var animal in _animals)
            {
                foreach (var behavior in animal.Behaviors)
                {
                    if (behavior is IMilkableAnimal talkative)
                    {
                        milked++;
                        talkative.ProduceMilk();
                    }
                }
            }
            if (milked == 0)
                OnFarmActivity(new BehaviorEventArgs("Cannot identify the farm animals which can be milked"));
        }

        //TEST 4
        public void ReleaseAllAnimals()
        {
            do
            {
                var animal = _animals.Dequeue();
                OnFarmActivity(new BehaviorEventArgs($"{animal.Name} has left the farm"));
            } while (_animals.Any());

            OnFarmActivity(new BehaviorEventArgs("Emydex Farm is now empty"));
        }
    }
}