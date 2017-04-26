using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3_2
{
    public abstract class Factory
    {
        public int getCost(Fruit fruit, Cover cover)
        {
            return fruit.getCost() + cover.getCost();
        }

        public abstract Juis create();
        
    }
}
