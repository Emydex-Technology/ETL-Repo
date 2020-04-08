using System;
using FarmSystem.Interfaces;
using FarmSystem.Models;

namespace FarmSystem.Behaviors
{
    public abstract class Behavior : IBehavior
    {
        public event EventHandler<BehaviorEventArgs> Performed;

        protected void OnPerformed(BehaviorEventArgs e)
        {
            Performed?.Invoke(this, e);
        }
    }
}
