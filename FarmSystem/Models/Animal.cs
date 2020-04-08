using System;
using System.Collections.Generic;
using FarmSystem.Interfaces;

namespace FarmSystem.Models
{
    /// <summary>
    /// Animal type defines creatures that the <see cref="EmydexFarmSystem"/> will support.
    /// </summary>
    public abstract class Animal : Entity, IAnimal
    {
        private List<IBehavior> _behaviors = new List<IBehavior>();
        private List<IAttribute> _attributes = new List<IAttribute>();

        // prevent incorrect instantiation, must be purchased from market 
        protected Animal() { }

        /// <summary>
        /// Event raised when activities occur on an Animal that may be of concern to external systems
        /// </summary>
        public event EventHandler<BehaviorEventArgs> SomethingHappened;

        /// <summary>
        /// Gets the <see cref="IBehavior"/>s the animal can perform
        /// </summary>
        public IReadOnlyCollection<IBehavior> Behaviors => _behaviors.AsReadOnly();

        /// <summary>
        /// Gets the <see cref="IAttribute"/>s applied to the animal 
        /// </summary>
        public IReadOnlyCollection<IAttribute> Attributes => _attributes.AsReadOnly();

        /// <summary>
        /// Add specific behaviors to an animal instance (i.e. <see cref="ITalkative"/>)
        /// </summary>
        /// <param name="behavior">The behaviour instance to add to the animal</param>
        /// <returns>Animal instance the behavior was added to</returns>
        /// <remarks>This is included to demonstrate the builder pattern</remarks>
        IAnimal IAnimal.AddNewBehavior(IBehavior behavior)
        {
            if (behavior == null) return this;
            _behaviors.Add(behavior);
            behavior.Performed += (o, e) => OnSomethingHappened(e);
            return this;
        }

        /// <summary>
        /// Add specific attributes to an animal instance (i.e. <see cref="IHasLegs"/>)
        /// </summary>
        /// <param name="attribute">The attribute instance to add to the animal</param>
        /// <returns>Animal instance the attribute was added to</returns>
        /// <remarks>This is included to demonstrate the builder pattern</remarks>
        IAnimal IAnimal.AddNewAttribute(IAttribute attribute)
        {
            if (attribute == null) return this;
            _attributes.Add(attribute);
            return this;
        }

        /// <summary>
        /// Event invocation performed here to allow derived class to override the event behavior
        /// </summary>
        /// <param name="e"></param>
        protected virtual void OnSomethingHappened(BehaviorEventArgs e)
        {
            SomethingHappened?.Invoke(this, e);
        }

        /// <summary>
        /// Get the type of the animal
        /// </summary>
        public string Name => GetType().Name;
    }
}
