using System;

namespace FarmSystem.Test1
{
    public class AnimalBase
    {
        #region Constructor
        /// <summary>
        /// Create a new animal with the 
        /// </summary>
        /// <param name="noOfLegs">How many legs the animal has</param>
        /// <param name="name">The name of the animal</param>
        /// <param name="saying">What the animal says when it Talks</param>
        public AnimalBase(int noOfLegs, string name, string saying)
        {
            NoOfLegs = noOfLegs;
            Name = name;
            Saying = saying;
            Id = Guid.NewGuid().ToString();
        }
        /// <summary>
        /// Create a new animal with no initial details
        /// </summary>
        public AnimalBase()
        {

        }
        #endregion

        #region Properties
        /// <summary>
        /// The unique ID of the animal
        /// </summary>
        public string Id { get; set; }
        /// <summary>
        /// Number of legs that the animal has
        /// </summary>
        public int NoOfLegs { get; protected set; }
        /// <summary>
        /// Name of the animal
        /// </summary>
        public string Name { get; protected set; }
        /// <summary>
        /// What the animal says
        /// </summary>
        public string Saying { get; protected set; }

        #endregion

        #region Methods
        public virtual void Talk()
        {
            System.Console.WriteLine($"{Name} says {Saying}!");
        }

        public virtual void Walk()
        {
            System.Console.WriteLine($"{Name} is walking");
        }

        public virtual void Run()
        {
            System.Console.WriteLine($"{Name} is running");
        }
        #endregion
    }
}
