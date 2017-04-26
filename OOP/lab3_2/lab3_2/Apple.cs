using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3_2
{
    public class Apple: Fruit
    {
        public Apple()
        {
            cost = 8;
        }
        public override string getName()
        {
            return "Apple";
        }
    }
}
