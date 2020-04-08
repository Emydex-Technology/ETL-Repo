using System;

namespace FarmSystem.Models
{
    public class BehaviorEventArgs : EventArgs
    {
        public BehaviorEventArgs(string message)
        {
            Message = message;
        }

        public string Message { get; }
    }
}
