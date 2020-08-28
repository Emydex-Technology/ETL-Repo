using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FarmSystem.Test1
{
    public abstract class FarmAnimal
    {
        public string Id { get; set; }
        public int NoOfLegs { get; set; }
        public bool IsMilkable { get; set; }
        public virtual void Talk() { }
        public virtual void ProduceMilk()
        {
            throw new NotImplementedException();
        }
    }
}
