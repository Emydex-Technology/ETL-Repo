using System;

namespace FarmSystem.Test1
{
    public class Animal : IAnimal
    {
        public Animal(string id, int numberOfLegs, string name)
        {
            Id = id ?? throw new ArgumentNullException(nameof(id), $"value of {nameof(id)} cannot be null");
            Name = name ?? throw new ArgumentNullException(nameof(name), $"value of {nameof(name)} cannot be null");

            if (numberOfLegs < 0)
                throw new ArgumentException(nameof(numberOfLegs), $"{nameof(numberOfLegs)} cannot be a negative number");

            NumberOfLegs = numberOfLegs;
        }

        public string Id { get; set; }
        public int NumberOfLegs { get; set; }
        public string Name { get; set; }
    }
}
