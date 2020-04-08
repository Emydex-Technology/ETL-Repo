using System;
using System.Collections.Generic;
using FarmSystem.Test2;

namespace FarmSystem.Test1
{
    public class EmydexFarmSystem
    {
        //TEST 1
        private readonly List<AnimalBase> Animals = new List<AnimalBase>();
        public event FarmEmptyEventHandler FarmEmptyEventHandler;

        public void Enter(AnimalBase animal)
        {
            //Hold all the animals so it is available for future activities
            Console.WriteLine($"{animal.Name} has entered the farm");
            Animals.Add(animal);
        }
     
        //TEST 2
        public void MakeNoise()
        {
            //Test 2 : Modify this method to make the animals talk
            Animals.ForEach((a) => a.Talk());
        }

        //TEST 3
        public void MilkAnimals()
        {
            Animals.ForEach((a) =>
            {
                IMilkableAnimal animal = a as IMilkableAnimal;
                animal?.ProduceMilk();
            });
        }

        //TEST 4
        public void ReleaseAllAnimals()
        {
            Animals.ForEach((a) => Console.WriteLine($"{a.Name} has left the farm"));
            Animals.Clear();
            FarmEmptyEventHandler?.Invoke(this,new FarmEmptyEventArgs("Emydex Farm is now empty"));
        }

    }
    public class FarmEmptyEventArgs : EventArgs
    {
        public FarmEmptyEventArgs(string message)
        {
            Message = message;
        }
        public string Message { get; set; }
    }

    public delegate void FarmEmptyEventHandler(Object sender, FarmEmptyEventArgs e);
}