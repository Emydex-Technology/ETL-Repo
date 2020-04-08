using System;
using FarmSystem.Interfaces;

namespace FarmSystem.Models
{
    public abstract class Entity : IHasIdentifier
    {
        protected Entity()
        {
            Id = Guid.NewGuid().ToString();
        }

        public string Id { get; }
    }
}
