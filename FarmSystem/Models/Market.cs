using System;
using FarmSystem.Interfaces;

namespace FarmSystem.Models
{
    public static class Market
    {
        public static IAnimal Purchase(Type type)
        {
            if (type == typeof(Cow))
            {
                return Cow.Purchase();
            }
            else if (type == typeof(Hen))
            {
                return Hen.Purchase();
            }
            else if (type == typeof(Horse))
            {
                return Horse.Purchase();
            }
            else if (type == typeof(Sheep))
            {
                return Sheep.Purchase();
            }
            throw new NotSupportedException($"Unable to purchase '{type.Name}' at this market");
        }
    }
}
