using System;

namespace FarmSystem.Test1
{
    public class Horse : Animal
    {
        private const string NAME = "Horse";

        private string _id;
        private int _noOfLegs;

        public override string Name => NAME;

        public string Id
        {
            get { return _id; }
            set
            {
                _id = value;
            }
        }


        public int NoOfLegs
        {
            get
            {
                return _noOfLegs;
            }
            set
            {
                _noOfLegs = 4;
            }
        }
        

        public void Talk()
        {
            Console.WriteLine("Horse says neigh!");
        }

        public void Run()
        {
            Console.WriteLine("Horse is running");
        }
        
    }
}