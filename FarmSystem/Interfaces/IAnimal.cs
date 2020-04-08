using System;
using System.Collections.Generic;
using FarmSystem.Models;

namespace FarmSystem.Interfaces
{
    public interface IAnimal : IHasIdentifier
    {
        event EventHandler<BehaviorEventArgs> SomethingHappened;

        IAnimal AddNewBehavior(IBehavior behavior);
        IAnimal AddNewAttribute(IAttribute attribute);
        IReadOnlyCollection<IBehavior> Behaviors { get; }
        IReadOnlyCollection<IAttribute> Attributes { get; }

        string Name { get; }
    }
}
