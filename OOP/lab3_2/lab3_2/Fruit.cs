using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3_2
{
    public abstract class Fruit
    {
        protected int cost;
        public int getCost()
        {
            return cost;
        }
        public abstract string getName();
    }
}
