using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5_1
{
    abstract public class Cook
    {
        protected Cook _next_cook;
        public abstract void toCook(Dishes[] dishes);
        public void setNextCook(Cook cook)
        {
            _next_cook = cook;
        }
    }
}
