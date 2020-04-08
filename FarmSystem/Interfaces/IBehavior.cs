using System;
using FarmSystem.Models;

namespace FarmSystem.Interfaces
{
    public interface IBehavior
    {
        event EventHandler<BehaviorEventArgs> Performed;
    }
}
