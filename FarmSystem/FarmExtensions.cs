using System;
using System.Collections.Generic;
using FarmSystem.Interfaces;

namespace FarmSystem
{
    internal static class FarmExtensions
    {
        internal static void ForEach<T>(this IEnumerable<T> items, Action<T> action)
        {
            foreach (var item in items)
            {
                action(item);
            }
        }


        internal static void DoSomething<T>(this IEnumerable<IAnimal> animals, Action<T> action)
            where T : class
        {
            foreach (var animal in animals)
            {
                if (animal is T type)
                    action(type);
            }
        }
    }
}