using System;
using System.Collections.ObjectModel;
using System.Linq;

namespace FarmSystem.Test1
{
    public class EmydexFarmSystem
    {
        public ObservableCollection<FarmAnimal> _currentFarmAnimals;

        public EmydexFarmSystem()
        {
            _currentFarmAnimals = new ObservableCollection<FarmAnimal>();
            _currentFarmAnimals.CollectionChanged += CurrentFarmAnimalsUpdated;
        }

        void CurrentFarmAnimalsUpdated(object sender, EventArgs e)
        {
            if (sender == null) return;
            var farmAnimals = (ObservableCollection<FarmAnimal>)sender;
            if (farmAnimals.Count() == 0)
            {
                FarmEmpty();
            }
        }

        //TEST 1
        public void Enter(FarmAnimal animal)
        {
            var animalType = (animal.GetType()).Name;
            _currentFarmAnimals.Add(animal);
            Console.WriteLine($"{animalType} has entered the farm");
        }

        //TEST 2
        public void MakeNoise()
        {
            foreach (var animal in _currentFarmAnimals)
            {
                animal.Talk();
            }
        }

        //TEST 3
        public void MilkAnimals()
        {
            var milkableAnimals = _currentFarmAnimals.Where(x => x.IsMilkable);

            foreach (var animal in milkableAnimals)
            {
                animal.ProduceMilk();
            }
        }

        //TEST 4
        public void ReleaseAllAnimals()
        {
            foreach (var animal in _currentFarmAnimals)
            {
                var animalType = (animal.GetType()).Name;
                Console.WriteLine($"{animalType} has left the farm");
            }
            _currentFarmAnimals.Clear();
        }

        public void FarmEmpty()
        {
            Console.WriteLine("Emydex Farm is now empty");
        }
    }
}